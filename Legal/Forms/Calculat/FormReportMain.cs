using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FormLbr.Classes;
using System.Linq;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using ControlsLbr;



namespace Legal.Forms.Calculat
{
    public partial class FormReportMain : FormLbr.FormBase
    {
        private int flag_net = 0;
        private int flag_sale = 0;
        private string dog_type = "";
        private string subcontract = "";
        public int idFilter = 0;

        public FormReportMain()
        {
            InitializeComponent();
            //dtBegin.Value = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, 1);
            //dtEnd.Value = new DateTime(System.DateTime.Now.Year, System.DateTime.Now.Month, dtBegin.Value.AddMonths(1).AddDays(-1).Day);
        }

        private void FormReportMain_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsCntVal1, dsCntVal1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsCntVal1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCntVal1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsCntVal1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCntVal1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);

            // виды платежа
            f_PaymentSelect_Load();

            // тип договора
            cmbDogovor_Load();

            // загрузка специалистов
            this.SelectSqlData(dsCntVal1, dsCntVal1.Tables["vWorkerGroup"], true,
                " where idgroup = " + Constants.Constants.WorkerGroupControlerUL + " order by fio ");

            for (int i = 0; i < dsCntVal1.vWorkerGroup.Rows.Count; i++)
            {
                clbSpecialist.Items.Add(new myList(dsCntVal1.vWorkerGroup[i]["id"].ToString(), dsCntVal1.vWorkerGroup[i]["FIO"].ToString()));
            }

            // загрузка тарифных групп
            treeViewTariff_Load(null);

            // загрузка сбытовых организаций
            this.SelectSqlData(dsCntVal1, dsCntVal1.Tables["tAbn"], true,
                " where TypeAbn = " + Constants.Constants.TypeAbnSale + " and Deleted = 0 and Name != '' order by Name ");

            for (int i = 0; i < dsCntVal1.tAbn.Rows.Count; i++)
            {
                clbOrgSale.Items.Add(new myList(dsCntVal1.tAbn[i]["id"].ToString(), dsCntVal1.tAbn[i]["Name"].ToString()));
            }

            // загрузка сетевых организаций
            this.SelectSqlDataTableOther(dsCntVal1, dsCntVal1.Tables["tAbn1"], "tAbn", true,
                " where TypeAbn = " + Constants.Constants.TypeAbnNet + " and Deleted = 0 and Name != '' order by Name ");

            for (int i = 0; i < dsCntVal1.tAbn1.Rows.Count; i++)
            {
                clbOrgNet.Items.Add(new myList(dsCntVal1.tAbn1[i]["id"].ToString(), dsCntVal1.tAbn1[i]["Name"].ToString()));
            }
            cmbGroup.SelectedIndex = 0;

            // загрузка подстанций
            DataSet.dsDop.vSchm_ObjListDataTable dt = new DataSet.dsDop.vSchm_ObjListDataTable();
            string whereType = "";
            foreach (Constants.SchmTypeSubstation type in Enum.GetValues(typeof(Constants.SchmTypeSubstation)))
                if (string.IsNullOrEmpty(whereType)) whereType = ((int)type).ToString();
                else whereType += "," + ((int)type).ToString();
            this.SelectSqlData(dt, true, " where typeCodeId in (" + whereType + ") and deleted = 0 order by typeCodeSocr, name");
            foreach (DataRow r in dt.Rows)
                clbStation.Items.Add(new myList(r["id"].ToString(), r["typeCodeSocr"] + "-" + r["Name"].ToString()));

            cmbGroup.SelectedIndex = 0;

            rbMaster.Checked = false;
            rbSpecial.Checked = true;

        }

        public class myList
        {
            private string id, name;
            public string Id
            {
                get { return id; }
            }
            public myList(string id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public override string ToString()
            {
                return name;
            }
        }

        #region BuildWhere
        // условие для контролеров
        private string BuildWhereContrl()
        {
            string whereContrl = "";
            if ((clbSpecialist.CheckedItems.Count <= 0) || (clbSpecialist.CheckedItems.Count == clbSpecialist.Items.Count))
                return whereContrl;
            else
            {
                for (int i = 0; i <= (clbSpecialist.CheckedItems.Count) - 1; i++)
                {
                    myList mylist = (myList)clbSpecialist.CheckedItems[i];
                    whereContrl += mylist.Id + ",";
                }
                if (rbSpecial.Checked == true)
                    whereContrl = "(idWorker in (" + whereContrl.Remove(whereContrl.Length - 1) + "))";
                else if (rbMaster.Checked == true)
                    whereContrl = "(idMaster in (" + whereContrl.Remove(whereContrl.Length - 1) + "))";
                else
                    whereContrl = "(Raion in (" + whereContrl.Remove(whereContrl.Length - 1) + "))";
                return whereContrl;
            }
        }

        // условие для даты
        private string BuildWhereDate()
        {
            string txtWhereDate = "";
            txtWhereDate += " (dtPay >= '" + dtBegin.Value.Date.ToString("yyyyMMdd") + "') and " +
                " (dtPay <= '" + dtEnd.Value.Date.ToString("yyyyMMdd") + "') ";
            return txtWhereDate;
        }

        // условие для типа договора
        private string BuildWhereTypeDog()
        {
            string txtWhereTypeDog = "";
            if ((int)cmbDogovor.SelectedValue == 501)
            {
                txtWhereTypeDog = "(NumberSchetFact Is Not Null and NumberSchetFact <> 0)";
                dog_type = ", по договорам купли-продажи";
            }
            if ((int)cmbDogovor.SelectedValue == 533)
            {
                txtWhereTypeDog = "(NumberSchetFact Is Null or NumberSchetFact = 0)";
                dog_type = ", по договорам энергоснабжения";
            }
            return txtWhereTypeDog;
        }

        // условие для вида начисления
        private string BuildWherePayment()
        {
            string txtWherePayment = "";
            if ((int)f_PaymentSelect.SelectedValue != -1)
                txtWherePayment = " (TypeOfEnergy = " + f_PaymentSelect.SelectedValue + ")";
            return txtWherePayment;
        }

        // условие для тарифов
        private string BuildWhereTariff()
        {
            int flag = 0;
            string txtWhereTariff = "";
            foreach (TreeNode group in treeViewTariff.Nodes[0].Nodes)
            {
                if (treeViewTariff.GetState(group) == CheckState.Checked)
                {
                    if (GetIdFromNodeTag(group.Tag).ToString() != "-1")
                        txtWhereTariff += GetIdFromNodeTag(group.Tag).ToString() + ",";
                }
                else
                    flag = 1;
                foreach (TreeNode subgroup in group.Nodes)
                {
                    if (treeViewTariff.GetState(subgroup) == CheckState.Checked)
                    {
                        if (GetIdFromNodeTag(subgroup.Tag).ToString() != "-1")
                            txtWhereTariff += GetIdFromNodeTag(subgroup.Tag).ToString() + ",";
                    }
                    else
                        flag = 1;
                    foreach (TreeNode node in subgroup.Nodes)
                    {
                        if (treeViewTariff.GetState(node) == CheckState.Checked)
                        {
                            if (GetIdFromNodeTag(node.Tag).ToString() != "-1")
                                txtWhereTariff += GetIdFromNodeTag(node.Tag).ToString() + ",";
                        }
                        else
                            flag = 1;
                    }
                }
            }
            if (txtWhereTariff != "")
                if (flag == 1)
                {
                    if (rbTariffGroup.Checked == false)
                        txtWhereTariff = " (idTariff in (" + txtWhereTariff.Remove(txtWhereTariff.Length - 1) + ")) ";
                    else
                        txtWhereTariff = txtWhereTariff.Remove(txtWhereTariff.Length - 1);
                }
                else
                    txtWhereTariff = "";
            return txtWhereTariff;
        }

        // условие для сбытовых организаций
        private string BuildWhereOrgSale()
        {
            string whereSale = "";
            if ((clbOrgSale.CheckedItems.Count <= 0) || (clbOrgSale.CheckedItems.Count == clbOrgSale.Items.Count))
                return whereSale;
            else
            {
                for (int i = 0; i <= (clbOrgSale.CheckedItems.Count) - 1; i++)
                {
                    myList mylist = (myList)clbOrgSale.CheckedItems[i];
                    whereSale += mylist.Id + ",";
                }
                whereSale = "(idAbnSale in (" + whereSale.Remove(whereSale.Length - 1) + "))";
                return whereSale;
            }
        }

        // условие для сетевых организаций
        private string BuildWhereOrgNet()
        {
            string whereNet = "";
            if ((clbOrgNet.CheckedItems.Count <= 0) || (clbOrgNet.CheckedItems.Count == clbOrgNet.Items.Count))
            {
                subcontract = "";
                return whereNet;
            }
            else
            {
                for (int i = 0; i <= (clbOrgNet.CheckedItems.Count) - 1; i++)
                {
                    myList mylist = (myList)clbOrgNet.CheckedItems[i];
                    whereNet += mylist.Id + ",";
                }
                if (whereNet == "434002,")
                    subcontract = ", по абонентам , непосред. присоед. к МУП УльГЭС";
                else
                    subcontract = ", по абонентам, опоср. присоед. к сетям МУП УльГЭС";
                whereNet = "(idAbnNet in (" + whereNet.Remove(whereNet.Length - 1) + "))";
                return whereNet;
            }
        }

        // условие для подстанций
        private string BuildWhereStation()
        {
            string whereStation = "";
            if ((clbStation.CheckedItems.Count <= 0) || (clbStation.CheckedItems.Count == clbStation.Items.Count))
                return whereStation;
            else
            {
                string whereSchmObj = "";
                for (int i = 0; i <= (clbStation.CheckedItems.Count) - 1; i++)
                    if (string.IsNullOrEmpty(whereSchmObj)) whereSchmObj = ((myList)clbStation.CheckedItems[i]).Id;
                    else whereSchmObj += "," + ((myList)clbStation.CheckedItems[i]).Id;

                if (!string.IsNullOrEmpty(whereSchmObj))
                {
                    DataTable dt = this.SelectSqlData("vL_SchmAbnFull", true, " where subid in (" + whereSchmObj + ") " +
                        " and typeAbn in (" + Constants.Constants.TypeAbnLegalAll + ")");
                    foreach (DataRow r in dt.Rows)
                        if (string.IsNullOrEmpty(whereStation)) whereStation = r["idAbnObj"].ToString();
                        else whereStation += "," + r["idAbnObj"].ToString();
                }
                if (whereStation.Length > 0)
                    whereStation = "(idAbnObj in (" + whereStation + "))";

                return whereStation;
            }
        }

        // условие для корректировки
        //private string BuildWhereCorrect()
        //{
        //    string txtWhereCorrect = "";
        //    //if (cbCorrect.Checked == true)
        //    //    txtWhereCorrect = "(NumberStorno Is Not Null and NumberStorno <> 0)";
        //    //if ((int)cmbDogovor.SelectedValue == 533)
        //    //    txtWhereCorrect = "(NumberStorno Is Null or NumberStorno = 0)";
        //    return txtWhereCorrect;
        //}

        // условие для групп потребителей
        private string BuildWhereGroupConsumer()
        {
            string whereGroupConsumer = "";
            if (cbGroup.Checked == true)
            {
                if (idFilter != 0)
                {
                    SelectSqlData(dsReportMainFilter1, dsReportMainFilter1.tG_FilterGroupConsumer, true, " where idFilter = " + idFilter);
                    if (dsReportMainFilter1.tG_FilterGroupConsumer.Rows.Count > 0)
                    {
                        for (int i = 0; i < dsReportMainFilter1.tG_FilterGroupConsumer.Rows.Count; i++)
                        {
                            whereGroupConsumer += dsReportMainFilter1.tG_FilterGroupConsumer.Rows[i]["idConsumer"] + ",";
                        }
                        whereGroupConsumer = "(Consumer in (" + whereGroupConsumer.Remove(whereGroupConsumer.Length - 1) + "))";
                    }
                }
            }
            return whereGroupConsumer;
        }

        // условие для безучетного
        private string BuildWhereUnmetered()
        {
            string txtWhereUnmetered = "";
            if (cbUnmetered.Checked == true)
                txtWhereUnmetered = "(ModeCalc in (1266,1267,1268))";
            return txtWhereUnmetered;
        }

        #endregion

        #region ContrlLoad
        // загрузка видов начислений
        private void f_PaymentSelect_Load()
        {
            int idType = 542;
            SelectSqlData(dsCntVal1, dsCntVal1.tR_Classifier, true, " where ParentID = " + idType.ToString());
            f_PaymentSelect.SelectedValue = 543;
            DataRow r = dsCntVal1.tR_Classifier.NewRow();
            r["id"] = -1;
            r["Name"] = "Все начисления";
            r["isGroup"] = 0;
            r["Deleted"] = 0;
            dsCntVal1.tR_Classifier.Rows.Add(r);
        }

        // загрузка типов договоров
        private void cmbDogovor_Load()
        {
            int idType = 500;
            SelectSqlDataTableOther(dsCntVal1, "tR_Classifier1", "tR_Classifier", true, " where ParentID = " + idType.ToString());
            cmbDogovor.SelectedValue = 501;
            DataRow r = dsCntVal1.tR_Classifier1.NewRow();
            r["id"] = -1;
            r["Name"] = "Все договора";
            r["isGroup"] = 0;
            r["Deleted"] = 0;
            dsCntVal1.tR_Classifier1.Rows.Add(r);
        }

        // загрузка тарифных групп
        private void treeViewTariff_Load(TreeNode selNode)
        {
            treeViewTariff.Nodes.Clear();

            // корневой узел
            this.SelectSqlDataTableOther(dsCntVal1, "tR_Classifier2", "tR_Classifier", true, " where ParentKey = ';SKUEE;Tariff;TariffLeg;' " +
                "and isGroup = 1 and deleted = 0");
            if (dsCntVal1.tR_Classifier2.Rows.Count <= 0) return;
            TreeNode root = new TreeNode(dsCntVal1.tR_Classifier2.Rows[0]["Name"].ToString());
            root.Tag = "All";
            treeViewTariff.Nodes.Add(root);

            if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(root.Tag)))
            {   // выделяем элемент, если надо
                treeViewTariff.SelectedNode = root;
                treeViewTariff.SelectedNode.Expand();
            }

            // группы тарифов
            this.SelectSqlDataTableOther(dsCntVal1, "tR_Classifier2", "tR_Classifier", true, " where ParentID = 515 order by id");

            foreach (DataRow dr in dsCntVal1.tR_Classifier2.Rows)
            {
                // добавляем новый узел
                TreeNode nodeGroup = new TreeNode();
                nodeGroup.Text = dr["Name"].ToString();
                if ((bool)dr["isGroup"] == false)
                    nodeGroup.Tag = "MainGroup" + dr["Id"].ToString();
                else
                    nodeGroup.Tag = "MainGroup";

                root.Nodes.Add(nodeGroup);

                if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(nodeGroup.Tag)))
                {   // выделяем элемент, если надо
                    treeViewTariff.SelectedNode = nodeGroup;
                    treeViewTariff.SelectedNode.Expand();
                }

                // добавляем новый подузел
                this.SelectSqlDataTableOther(dsCntVal1, "tR_Classifier3", "tR_Classifier", true, " where ParentID = " + dr["Id"].ToString() + " order by id");
                foreach (DataRow dr1 in dsCntVal1.tR_Classifier3.Rows)
                {
                    TreeNode nodeSubGroup = new TreeNode();
                    nodeSubGroup.Text = dr1["Name"].ToString();
                    if ((bool)dr1["isGroup"] == false)
                        nodeSubGroup.Tag = "SubGroup" + dr1["id"].ToString();
                    else
                        nodeSubGroup.Tag = "SubGroup";
                    nodeGroup.Nodes.Add(nodeSubGroup);

                    if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(nodeSubGroup.Tag)))
                    {   // выделяем элемент, если надо
                        treeViewTariff.SelectedNode = nodeSubGroup;
                        treeViewTariff.SelectedNode.Expand();
                    }

                    // добавляем новый тариф
                    this.SelectSqlDataTableOther(dsCntVal1, "tR_Classifier4", "tR_Classifier", true, " where ParentID = " + dr1["Id"].ToString() + " order by id");
                    foreach (DataRow dr2 in dsCntVal1.tR_Classifier4.Rows)
                    {
                        TreeNode nodeTariff = new TreeNode();
                        nodeTariff.Text = dr2["Name"].ToString();
                        nodeTariff.Tag = "Tariff" + dr2["id"].ToString();
                        nodeSubGroup.Nodes.Add(nodeTariff);

                        if ((selNode != null) && (GetIdFromNodeTag(selNode.Tag) == GetIdFromNodeTag(nodeTariff.Tag)))
                        {   // выделяем элемент, если надо
                            treeViewTariff.SelectedNode = nodeSubGroup;
                            treeViewTariff.SelectedNode.Expand();
                        }
                    }
                }
            }

            treeViewTariff.Nodes[0].Expand();
            treeViewTariff.Nodes[0].Checked = false;
            treeViewTariff.SelectedNode = treeViewTariff.Nodes[0];
        }

        private int GetIdFromNodeTag(System.Object tag)
        {
            string stTag = tag.ToString();

            if (stTag.IndexOf("All") >= 0) // all
                return -1;
            if (stTag.IndexOf("MainGroup") >= 0) // ветка group
                if (stTag.Length > 9)
                    return Convert.ToInt32(stTag.Substring(9));
                else
                    return -1;
            if (stTag.IndexOf("SubGroup") >= 0) // ветка subgroup
                if (stTag.Length > 8)
                    return Convert.ToInt32(stTag.Substring(8));
                else
                    return -1;
            if (stTag.IndexOf("Tariff") >= 0) // ветка tariff
                return Convert.ToInt32(stTag.Substring(6));

            return -1;
        }
        #endregion

        // формирование динамического грида
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            dsCntVal1.vG_ReportMain.Rows.Clear();
            this.dataGridView1.Columns.Clear();

            #region Формирование условия выборки данных
            string txtWhere = "";
            string txtWhereTariff = "";

            Boolean FlagNewTariff = false;
            DateTime DateNewTariff = new DateTime(2015, 7, 1);
            if (rbTariffGroup.Checked == true)
                FlagNewTariff = (dtBegin.Value >= DateNewTariff);

            if (!FlagNewTariff)
            {

                // условие для даты
                txtWhere += BuildWhereDate();

                // условие для контролеров
                if (BuildWhereContrl() != "")
                {
                    if (txtWhere != "")
                        txtWhere += " and " + BuildWhereContrl();
                    else
                        txtWhere = BuildWhereDate();
                }

                // условие для вида начисления
                if (BuildWherePayment() != "")
                {
                    if (txtWhere != "")
                        txtWhere += " and " + BuildWherePayment();
                    else
                        txtWhere = BuildWherePayment();
                }

                // условие для подстанций
                if (BuildWhereStation() != "")
                {
                    if (txtWhere != "")
                        txtWhere += " and " + BuildWhereStation();
                    else
                        txtWhere = BuildWhereStation();
                }

                // условие для групп потребителей
                if (BuildWhereGroupConsumer() != "")
                {
                    if (txtWhere != "")
                        txtWhere += " and " + BuildWhereGroupConsumer();
                    else
                        txtWhere = BuildWhereGroupConsumer();
                }

                // условие для безучетного потребления
                if (BuildWhereUnmetered() != "")
                {
                    if (txtWhere != "")
                        txtWhere += " and " + BuildWhereUnmetered();
                    else
                        txtWhere = BuildWhereUnmetered();
                }
            }

            // условие для типа договора
            if (BuildWhereTypeDog() != "")
            {
                if (txtWhere != "")
                    txtWhere += " and " + BuildWhereTypeDog();
                else
                    txtWhere = BuildWhereTypeDog();
            }

            // условие для сбытовых организаций
            if (BuildWhereOrgSale() != "")
            {
                if (txtWhere != "")
                    txtWhere += " and " + BuildWhereOrgSale();
                else
                    txtWhere = BuildWhereOrgSale();
            }

            // условие для сетевых организаций
            if (BuildWhereOrgNet() != "")
            {
                if (txtWhere != "")
                    txtWhere += " and " + BuildWhereOrgNet();
                else
                    txtWhere = BuildWhereOrgNet();
            }

            // условие для тарифов
            txtWhereTariff = BuildWhereTariff();
            if (txtWhereTariff != "")
            {
                if (rbTariffGroup.Checked == false)
                {
                    if (txtWhere != "")
                        txtWhere += " and " + txtWhereTariff;
                    else
                        txtWhere = txtWhereTariff;
                }
            }



            #endregion

            #region Вызвать функцию и получить данные

            if (rbTariffGroup.Checked == true)
            {
                dsCntVal1.vG_ReportMain_Excel.Clear();
                dsDop2.vG_LegReportMain_Excel_New.Clear();
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);
                    string strCmd = "";

                    if (FlagNewTariff)
                        if (txtWhere == "")
                            strCmd = "select * from fn_LegReportMain_Excel_NewTariff(@DateBegin, @DateEnd, @txtWhereTariff) order by codeabonent";
                        else
                            strCmd = "select * from fn_LegReportMain_Excel_NewTariff(@DateBegin, @DateEnd, @txtWhereTariff) where " + txtWhere + " order by codeabonent";
                    else
                        strCmd = "select * from fn_LegReportMain_Excel_New(@DateBegin, @DateEnd, @txtWhereTariff) where " + txtWhere + " order by codeabonent";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                    DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                    DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                    SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                    sqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                    sqlCmd.Parameters.Add(p2);

                    txtWhereTariff = txtWhereTariff.Replace(",", " ");
                    SqlParameter p3 = new SqlParameter("@txtWhereTariff", txtWhereTariff);
                    sqlCmd.Parameters.Add(p3);

                    sqlCmd.CommandTimeout = 0;

                    SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                    if (FlagNewTariff)
                        dAdapt.Fill(dsDop2, "vG_LegReportMain_Excel_New");
                    else
                        dAdapt.Fill(dsCntVal1, "vG_ReportMain_Excel");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    con.CloseConnection();
                }

            }
            else
            {
                dsCntVal1.vG_ReportMain.Clear();
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);
                    string strCmd = "";
                    if (cbCrossFlow.Checked == true)
                        strCmd = "select * from fn_LegReportMain_CrossFlow(@DateBegin, @DateEnd) where " + txtWhere + " order by codeabonent";
                    else if (cbDirect.Checked == true)
                        strCmd = "select * from fn_LegReportMain_DirectControl(@DateBegin, @DateEnd) where " + txtWhere + " order by codeabonent";
                    else if (cbUnmetered.Checked == true)
                        strCmd = "select * from fn_LegReportMain_Unmetered(@DateBegin, @DateEnd) where " + txtWhere + " order by codeabonent";
                    else if (cbODN.Checked == true)
                        strCmd = "select * from fn_LegReportMain_ODN(@DateBegin, @DateEnd) where " + txtWhere + " order by codeabonent";
                    else if (cbEnter.Checked == true)
                        strCmd = "select * from fn_LegReportMain_Enter(@DateBegin, @DateEnd) where " + txtWhere + " order by codeabonent";
                    else
                    {
                        if (cmbGroup.SelectedIndex == 7)
                            strCmd = "select * from fn_LegReportMain_Net(@DateBegin, @DateEnd) where " + txtWhere + " order by codeabonent";
                        else
                            strCmd = "select * from fn_LegReportMain_New(@DateBegin, @DateEnd) where " + txtWhere + " order by codeabonent";
                    }
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                    DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                    DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                    SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                    sqlCmd.Parameters.Add(p1);

                    SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                    sqlCmd.Parameters.Add(p2);

                    sqlCmd.CommandTimeout = 0;

                    SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                    dAdapt.Fill(dsCntVal1, "vG_ReportMain");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    con.CloseConnection();
                }

            }

            #endregion

            #region Cоздание временной таблицы
            DataTable dt = new DataTable("dtReportMain");

            if (rbTariffGroup.Checked == true)
                dt.Columns.Add(new DataColumn("ID", typeof(int)));

            dt.Columns.Add(new DataColumn("Code", typeof(int)));
            dt.Columns.Add(new DataColumn("Title", typeof(string)));

            if (rbTariffGroup.Checked == false)
            {
                if (cbObject.Checked == true || cmbGroup.SelectedIndex == 6)
                    dt.Columns.Add(new DataColumn("ObjName", typeof(string)));
                if (cbTariff.Checked == true)
                    dt.Columns.Add(new DataColumn("Tariff", typeof(decimal)));
                if (cbDate.Checked == true)
                    dt.Columns.Add(new DataColumn("dtPay", typeof(DateTime)));
                dt.Columns.Add(new DataColumn("Sum1", typeof(int)));
                dt.Columns.Add(new DataColumn("Sum2", typeof(decimal)));
                dt.Columns.Add(new DataColumn("Sum3", typeof(decimal)));
                dt.Columns.Add(new DataColumn("Sum4", typeof(decimal)));
            }
            else
            {
                if (FlagNewTariff)
                {
                    dt.Columns.Add(new DataColumn("Sum1", typeof(int)));
                    dt.Columns.Add(new DataColumn("Sum2", typeof(int)));
                    dt.Columns.Add(new DataColumn("Sum3", typeof(int)));
                    dt.Columns.Add(new DataColumn("TotSum", typeof(int)));
                    dt.Columns.Add(new DataColumn("Net", typeof(string)));
                    dt.Columns.Add(new DataColumn("Worker", typeof(string)));
                    dt.Columns.Add(new DataColumn("CodeAbnStr", typeof(string)));
                    dt.Columns.Add(new DataColumn("TypeDog", typeof(string)));
                    dt.Columns.Add(new DataColumn("GroupTariff", typeof(string)));
                }
                else
                {
                    if (cbDate.Checked == true)
                        dt.Columns.Add(new DataColumn("dtPay", typeof(DateTime)));
                    dt.Columns.Add(new DataColumn("Sum1", typeof(int)));
                    dt.Columns.Add(new DataColumn("Sum2", typeof(int)));
                    dt.Columns.Add(new DataColumn("Sum3", typeof(int)));
                    dt.Columns.Add(new DataColumn("Sum4", typeof(int)));
                    dt.Columns.Add(new DataColumn("Sum5", typeof(int)));
                    dt.Columns.Add(new DataColumn("Sum6", typeof(int)));
                    dt.Columns.Add(new DataColumn("TotSum", typeof(int)));
                    dt.Columns.Add(new DataColumn("Net", typeof(string)));
                    dt.Columns.Add(new DataColumn("Worker", typeof(string)));
                }
            }

            dsCntVal1.Tables.Add(dt);
            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            #endregion

            #region Формирование столбцов грида
            DataGridViewColumn ID = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            ID.Name = "ID";
            DataGridViewColumn Code = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Code.Name = "Code";
            DataGridViewColumn Title = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Title.Name = "Title";
            DataGridViewColumn Sum1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Sum1.Name = "Sum1";
            DataGridViewColumn Sum2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Sum2.Name = "Sum2";
            DataGridViewColumn Sum3 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Sum3.Name = "Sum3";
            DataGridViewColumn Sum4 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Sum4.Name = "Sum4";
            DataGridViewColumn Sum5 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Sum5.Name = "Sum5";
            DataGridViewColumn Sum6 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Sum6.Name = "Sum6";
            DataGridViewColumn TotSum = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            TotSum.Name = "TotSum";
            DataGridViewColumn Net = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Net.Name = "Net";
            DataGridViewColumn Worker = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Worker.Name = "Worker";
            DataGridViewColumn Tariff = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Tariff.Name = "Tariff";
            DataGridViewColumn ObjName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            ObjName.Name = "ObjName";
            DataGridViewColumn dtPay = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            dtPay.Name = "dtPay";
            DataGridViewColumn CodeAbnStr = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            CodeAbnStr.Name = "CodeAbnStr";
            DataGridViewColumn TypeDog = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            TypeDog.Name = "TypeDog";
            DataGridViewColumn GroupTariff = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            GroupTariff.Name = "GroupTariff";

            if (rbTariffGroup.Checked == false)
            {
                dataGridView1.Columns.Add(Code);
                dataGridView1.Columns.Add(Title);
                if (cbObject.Checked == true || cmbGroup.SelectedIndex == 6)
                    dataGridView1.Columns.Add(ObjName);
                if (cbTariff.Checked == true)
                    dataGridView1.Columns.Add(Tariff);
                if (cbDate.Checked == true)
                    dataGridView1.Columns.Add(dtPay);
                dataGridView1.Columns.Add(Sum1);
                dataGridView1.Columns.Add(Sum2);
                dataGridView1.Columns.Add(Sum3);
                dataGridView1.Columns.Add(Sum4);
            }
            else
            {
                if (FlagNewTariff)
                {
                    dataGridView1.Columns.Add(ID);
                    dataGridView1.Columns.Add(Code);
                    dataGridView1.Columns.Add(Title);
                    dataGridView1.Columns.Add(Sum1);
                    dataGridView1.Columns.Add(Sum2);
                    dataGridView1.Columns.Add(Sum3);
                    dataGridView1.Columns.Add(TotSum);
                    dataGridView1.Columns.Add(Net);
                    dataGridView1.Columns.Add(Worker);
                    dataGridView1.Columns.Add(CodeAbnStr);
                    dataGridView1.Columns.Add(TypeDog);
                    dataGridView1.Columns.Add(GroupTariff);
                }
                else
                {
                    dataGridView1.Columns.Add(ID);
                    dataGridView1.Columns.Add(Code);
                    dataGridView1.Columns.Add(Title);
                    if (cbDate.Checked == true)
                        dataGridView1.Columns.Add(dtPay);
                    dataGridView1.Columns.Add(Sum1);
                    dataGridView1.Columns.Add(Sum2);
                    dataGridView1.Columns.Add(Sum3);
                    dataGridView1.Columns.Add(Sum4);
                    dataGridView1.Columns.Add(Sum5);
                    dataGridView1.Columns.Add(Sum6);
                    dataGridView1.Columns.Add(TotSum);
                    dataGridView1.Columns.Add(Net);
                    dataGridView1.Columns.Add(Worker);
                }
            }

            DataGridViewCellStyle IntStyle = new DataGridViewCellStyle();
            IntStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            IntStyle.Format = "N0";

            DataGridViewCellStyle StringStyle = new DataGridViewCellStyle();
            StringStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            DataGridViewCellStyle DecStyle = new DataGridViewCellStyle();
            DecStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DecStyle.Format = "N2";

            DataGridViewCellStyle DecStyle6 = new DataGridViewCellStyle();
            DecStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            DecStyle6.Format = "N6";


            if (rbTariffGroup.Checked == true)
            {
                dataGridView1.Columns["ID"].Width = 70;
                dataGridView1.Columns["ID"].HeaderText = "AbnID";
                dataGridView1.Columns["ID"].ValueType = typeof(int);
                dataGridView1.Columns["ID"].DefaultCellStyle = IntStyle;
                dataGridView1.Columns["ID"].DataPropertyName = "ID";
            }
            dataGridView1.Columns["Code"].Width = 70;
            dataGridView1.Columns["Code"].HeaderText = "Код";
            dataGridView1.Columns["Code"].ValueType = typeof(int);
            dataGridView1.Columns["Code"].DefaultCellStyle = IntStyle;
            dataGridView1.Columns["Code"].DataPropertyName = "Code";

            dataGridView1.Columns["Title"].Width = 350;
            dataGridView1.Columns["Title"].HeaderText = "Наименование";
            dataGridView1.Columns["Title"].ValueType = typeof(string);
            dataGridView1.Columns["Title"].DefaultCellStyle = StringStyle;
            dataGridView1.Columns["Title"].DataPropertyName = "Title";

            if (rbTariffGroup.Checked == false)
            {

                if (cbObject.Checked == true || cmbGroup.SelectedIndex == 6)
                {
                    dataGridView1.Columns["ObjName"].Width = 350;
                    dataGridView1.Columns["ObjName"].HeaderText = "Объект";
                    dataGridView1.Columns["ObjName"].ValueType = typeof(string);
                    dataGridView1.Columns["ObjName"].DefaultCellStyle = StringStyle;
                    dataGridView1.Columns["ObjName"].DataPropertyName = "ObjName";
                }

                if (cbTariff.Checked == true)
                {
                    dataGridView1.Columns["Tariff"].HeaderText = "Тариф";
                    dataGridView1.Columns["Tariff"].Width = 100;
                    dataGridView1.Columns["Tariff"].ValueType = typeof(decimal);
                    dataGridView1.Columns["Tariff"].DefaultCellStyle = DecStyle6;
                    dataGridView1.Columns["Tariff"].DataPropertyName = "Tariff";
                }

                if (cbDate.Checked == true)
                {
                    dataGridView1.Columns["dtPay"].HeaderText = "Дата";
                    dataGridView1.Columns["dtPay"].Width = 100;
                    dataGridView1.Columns["dtPay"].ValueType = typeof(DateTime);
                    dataGridView1.Columns["dtPay"].DefaultCellStyle = StringStyle;
                    dataGridView1.Columns["dtPay"].DataPropertyName = "dtPay";
                }

                dataGridView1.Columns["Sum1"].Width = 100;
                dataGridView1.Columns["Sum1"].HeaderText = "Расход";
                dataGridView1.Columns["Sum1"].ValueType = typeof(int);
                dataGridView1.Columns["Sum1"].DefaultCellStyle = IntStyle;
                dataGridView1.Columns["Sum1"].DataPropertyName = "Sum1";

                dataGridView1.Columns["Sum2"].Width = 100;
                dataGridView1.Columns["Sum2"].HeaderText = "Сумма";
                dataGridView1.Columns["Sum2"].ValueType = typeof(decimal);
                dataGridView1.Columns["Sum2"].DefaultCellStyle = DecStyle;
                dataGridView1.Columns["Sum2"].DataPropertyName = "Sum2";

                dataGridView1.Columns["Sum3"].Width = 100;
                dataGridView1.Columns["Sum3"].HeaderText = "Налог";
                dataGridView1.Columns["Sum3"].ValueType = typeof(decimal);
                dataGridView1.Columns["Sum3"].DefaultCellStyle = DecStyle;
                dataGridView1.Columns["Sum3"].DataPropertyName = "Sum3";

                dataGridView1.Columns["Sum4"].Width = 100;
                dataGridView1.Columns["Sum4"].HeaderText = "Всего";
                dataGridView1.Columns["Sum4"].ValueType = typeof(decimal);
                dataGridView1.Columns["Sum4"].DefaultCellStyle = DecStyle;
                dataGridView1.Columns["Sum4"].DataPropertyName = "Sum4";

            }
            else
            {
                if (cbDate.Checked == true)
                {
                    dataGridView1.Columns["dtPay"].HeaderText = "Дата";
                    dataGridView1.Columns["dtPay"].Width = 100;
                    dataGridView1.Columns["dtPay"].ValueType = typeof(DateTime);
                    dataGridView1.Columns["dtPay"].DefaultCellStyle = StringStyle;
                    dataGridView1.Columns["dtPay"].DataPropertyName = "dtPay";
                }

                dataGridView1.Columns["Sum1"].Width = 100;
                dataGridView1.Columns["Sum1"].HeaderText = "ВН";
                dataGridView1.Columns["Sum1"].ValueType = typeof(int);
                dataGridView1.Columns["Sum1"].DefaultCellStyle = IntStyle;
                dataGridView1.Columns["Sum1"].DataPropertyName = "Sum1";

                dataGridView1.Columns["Sum2"].Width = 100;
                dataGridView1.Columns["Sum2"].HeaderText = "СН";
                dataGridView1.Columns["Sum2"].ValueType = typeof(int);
                dataGridView1.Columns["Sum2"].DefaultCellStyle = IntStyle;
                dataGridView1.Columns["Sum2"].DataPropertyName = "Sum2";

                dataGridView1.Columns["Sum3"].Width = 100;
                dataGridView1.Columns["Sum3"].HeaderText = "НН";
                dataGridView1.Columns["Sum3"].ValueType = typeof(int);
                dataGridView1.Columns["Sum3"].DefaultCellStyle = IntStyle;
                dataGridView1.Columns["Sum3"].DataPropertyName = "Sum3";

                if (!FlagNewTariff)
                {
                    dataGridView1.Columns["Sum4"].Width = 100;
                    dataGridView1.Columns["Sum4"].HeaderText = "ВН_НАС";
                    dataGridView1.Columns["Sum4"].ValueType = typeof(int);
                    dataGridView1.Columns["Sum4"].DefaultCellStyle = IntStyle;
                    dataGridView1.Columns["Sum4"].DataPropertyName = "Sum4";

                    dataGridView1.Columns["Sum5"].Width = 100;
                    dataGridView1.Columns["Sum5"].HeaderText = "СН_НАС";
                    dataGridView1.Columns["Sum5"].ValueType = typeof(int);
                    dataGridView1.Columns["Sum5"].DefaultCellStyle = IntStyle;
                    dataGridView1.Columns["Sum5"].DataPropertyName = "Sum5";

                    dataGridView1.Columns["Sum6"].Width = 100;
                    dataGridView1.Columns["Sum6"].HeaderText = "НН_НАС";
                    dataGridView1.Columns["Sum6"].ValueType = typeof(int);
                    dataGridView1.Columns["Sum6"].DefaultCellStyle = IntStyle;
                    dataGridView1.Columns["Sum6"].DataPropertyName = "Sum6";
                }

                dataGridView1.Columns["TotSum"].Width = 100;
                dataGridView1.Columns["TotSum"].HeaderText = "Всего";
                dataGridView1.Columns["TotSum"].ValueType = typeof(int);
                dataGridView1.Columns["TotSum"].DefaultCellStyle = IntStyle;
                dataGridView1.Columns["TotSum"].DataPropertyName = "TotSum";

                dataGridView1.Columns["Net"].Width = 150;
                dataGridView1.Columns["Net"].HeaderText = "Сеть";
                dataGridView1.Columns["Net"].ValueType = typeof(string);
                dataGridView1.Columns["Net"].DefaultCellStyle = StringStyle;
                dataGridView1.Columns["Net"].DataPropertyName = "Net";

                dataGridView1.Columns["Worker"].Width = 150;
                dataGridView1.Columns["Worker"].HeaderText = "Специалист";
                dataGridView1.Columns["Worker"].ValueType = typeof(string);
                dataGridView1.Columns["Worker"].DefaultCellStyle = StringStyle;
                dataGridView1.Columns["Worker"].DataPropertyName = "Worker";

                if (FlagNewTariff)
                {
                    dataGridView1.Columns["CodeAbnStr"].Width = 100;
                    dataGridView1.Columns["CodeAbnStr"].HeaderText = "№ договора";
                    dataGridView1.Columns["CodeAbnStr"].ValueType = typeof(string);
                    dataGridView1.Columns["CodeAbnStr"].DefaultCellStyle = StringStyle;
                    dataGridView1.Columns["CodeAbnStr"].DataPropertyName = "CodeAbnStr";

                    dataGridView1.Columns["TypeDog"].Width = 150;
                    dataGridView1.Columns["TypeDog"].HeaderText = "Тип";
                    dataGridView1.Columns["TypeDog"].ValueType = typeof(string);
                    dataGridView1.Columns["TypeDog"].DefaultCellStyle = StringStyle;
                    dataGridView1.Columns["TypeDog"].DataPropertyName = "TypeDog";

                    dataGridView1.Columns["GroupTariff"].Width = 300;
                    dataGridView1.Columns["GroupTariff"].HeaderText = "Группа потребителей";
                    dataGridView1.Columns["GroupTariff"].ValueType = typeof(string);
                    dataGridView1.Columns["GroupTariff"].DefaultCellStyle = StringStyle;
                    dataGridView1.Columns["GroupTariff"].DataPropertyName = "GroupTariff";

                }

            }
            // назначим источник данных грида
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bds;

            #endregion

            #region Группировка данных и заполнение таблицы

            int tSumPower = 0;
            tSumPower = dsCntVal1.vG_ReportMain.AsEnumerable()
                .Where(x => x.Field<int>("idTariff") > 1010)
                .Where(x => x.Field<int>("idTariff") < 1016)
                .Sum(x => x.Field<int>("Quantity"));

            if (rbTariffGroup.Checked == false)
            {
                #region Группировка столбцов расход+сумма
                #region Инициализация переменных
                int tSum1 = 0;
                decimal tSum2 = 0;
                decimal tSum3 = 0;
                decimal tSum4 = 0;
                #endregion

                if (cbTariff.Checked == true)
                    #region Дополнительно разбивать по тарифам
                    switch (cmbGroup.SelectedIndex)
                    {
                        #region абоненты
                        case 0:
                            var groupbyfilter = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                group row by new { id1 = row.Field<int>("CodeAbonent"), id2 = row.Field<string>("Name"), id3 = row.Field<decimal>("Tariff") }
                                                    into grp
                                                    orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                                    select new
                                                    {
                                                        Code = grp.Key.id1,
                                                        Nm = grp.Key.id2,
                                                        Tr = grp.Key.id3,
                                                        Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                        Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                        Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                        Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                    };

                            foreach (var g in groupbyfilter)
                            {
                                dt.Rows.Add(new object[] { g.Code, g.Nm, g.Tr, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                                tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                            }
                            if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                            dt.Rows.Add(new object[] { null, "Итого", null, tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region тарифные группы
                        case 1:
                            var groupbyfilter1 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by new { id1 = row.Field<int>("idTariff"), id2 = row.Field<string>("TariffGroup"), id3 = row.Field<decimal>("Tariff") }
                                                     into grp
                                                     orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                                     select new
                                                         {
                                                             Code = grp.Key.id1,
                                                             Nm = grp.Key.id2,
                                                             Tr = grp.Key.id3,
                                                             Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                             Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                             Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                             Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                         };

                            foreach (var g in groupbyfilter1)
                            {
                                dt.Rows.Add(new object[] { g.Code, g.Nm, g.Tr, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                                tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                            }
                            if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                            dt.Rows.Add(new object[] { null, "Итого", null, tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region специалисты
                        case 2:
                            var groupbyfilter2 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by new { id1 = row.Field<int>("idWorker"), id2 = row.Field<string>("Worker"), id3 = row.Field<decimal>("Tariff") }
                                                     into grp
                                                     orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                                     select new
                                                        {
                                                            Code = grp.Key.id1,
                                                            Nm = grp.Key.id2,
                                                            Tr = grp.Key.id3,
                                                            Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                            Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                            Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                            Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                        };

                            foreach (var g in groupbyfilter2)
                            {
                                dt.Rows.Add(new object[] { g.Code, g.Nm, g.Tr, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                                tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                            }
                            if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                            dt.Rows.Add(new object[] { null, "Итого", null, tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region договоры
                        case 3:
                            var groupbyfilter3 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by new { id1 = row.Field<int>("idDocType"), id2 = row.Field<string>("Dogovor"), id3 = row.Field<decimal>("Tariff") }
                                                     into grp
                                                     orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                                     select new
                                                        {
                                                            Code = grp.Key.id1,
                                                            Nm = grp.Key.id2,
                                                            Tr = grp.Key.id3,
                                                            Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                            Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                            Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                            Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                        };

                            foreach (var g in groupbyfilter3)
                            {
                                dt.Rows.Add(new object[] { g.Code, g.Nm, g.Tr, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                                tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                            }
                            if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                            dt.Rows.Add(new object[] { null, "Итого", null, tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region вид начисления
                        case 4:
                            var groupbyfilter4 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by new { id1 = row.Field<int>("TypeOfEnergy"), id2 = row.Field<string>("Energy"), id3 = row.Field<decimal>("Tariff") }
                                                     into grp
                                                     orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                                     select new
                                                         {
                                                             Code = grp.Key.id1,
                                                             Nm = grp.Key.id2,
                                                             Tr = grp.Key.id3,
                                                             Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                             Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                             Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                             Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                         };

                            foreach (var g in groupbyfilter4)
                            {
                                dt.Rows.Add(new object[] { g.Code, g.Nm, g.Tr, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                                tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                            }
                            if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                            dt.Rows.Add(new object[] { null, "Итого", null, tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region сети
                        case 7:
                            var groupbyfilter7 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by new { id1 = row.Field<int>("CodeAbonent"), id2 = row.Field<string>("Name"), id3 = row.Field<decimal>("Tariff") }
                                                     into grp
                                                     orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                                     select new
                                                     {
                                                         Code = grp.Key.id1,
                                                         Nm = grp.Key.id2,
                                                         Tr = grp.Key.id3,
                                                         LineName = grp.Select(r => r.Field<string>("TariffGroup")),
                                                         Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                         Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                         Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                         Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                     };

                            foreach (var g in groupbyfilter7)
                            {
                                dt.Rows.Add(new object[] { g.Code, g.Nm + " (" + g.LineName.First() + ")", g.Tr, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                                tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                            }
                            if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                            dt.Rows.Add(new object[] { null, "Итого", null, tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                    }
                    #endregion
                else if (cbObject.Checked == true)
                #region Дополнительно разбивать по объектам
                {
                    var groupbyfilter = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                        group row by new { id1 = row.Field<int>("CodeAbonent"), id2 = row.Field<string>("Name"), id3 = row.Field<string>("ObjName") }
                                            into grp
                                            orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                            select new
                                            {
                                                Code = grp.Key.id1,
                                                Nm = grp.Key.id2,
                                                Tr = grp.Key.id3,
                                                Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                            };

                    foreach (var g in groupbyfilter)
                    {
                        dt.Rows.Add(new object[] { g.Code, g.Nm, g.Tr, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                        tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                    }
                    if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                    dt.Rows.Add(new object[] { 0, "Итого", 0, tSum1, tSum2, tSum3, tSum4 });
                }
                #endregion
                else if (cbDate.Checked == true)
                    #region Дополнительно разбивать по дате
                    switch (cmbGroup.SelectedIndex)
                    {
                        #region абоненты
                        case 0:
                            var groupbyfilter = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                group row by new { id1 = row.Field<int>("CodeAbonent"), id2 = row.Field<string>("Name"), id3 = row.Field<DateTime>("dtPay") }
                                                    into grp
                                                    orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                                    select new
                                                    {
                                                        Code = grp.Key.id1,
                                                        Nm = grp.Key.id2,
                                                        Tr = grp.Key.id3,
                                                        Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                        Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                        Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                        Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                    };

                            foreach (var g in groupbyfilter)
                            {
                                dt.Rows.Add(new object[] { g.Code, g.Nm, g.Tr, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                                tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                            }
                            dt.Rows.Add(new object[] { null, "Итого", null, tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region тарифные группы
                        case 1:
                            var groupbyfilter1 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by new { id1 = row.Field<int>("idTariff"), id2 = row.Field<string>("TariffGroup"), id3 = row.Field<DateTime>("dtPay") }
                                                     into grp
                                                     orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                                     select new
                                                         {
                                                             Code = grp.Key.id1,
                                                             Nm = grp.Key.id2,
                                                             Tr = grp.Key.id3,
                                                             Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                             Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                             Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                             Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                         };

                            foreach (var g in groupbyfilter1)
                            {
                                dt.Rows.Add(new object[] { g.Code, g.Nm, g.Tr, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                                tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                            }
                            dt.Rows.Add(new object[] { null, "Итого", null, tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region специалисты
                        case 2:
                            var groupbyfilter2 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by new { id1 = row.Field<int>("idWorker"), id2 = row.Field<string>("Worker"), id3 = row.Field<DateTime>("dtPay") }
                                                     into grp
                                                     orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                                     select new
                                                        {
                                                            Code = grp.Key.id1,
                                                            Nm = grp.Key.id2,
                                                            Tr = grp.Key.id3,
                                                            Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                            Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                            Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                            Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                        };

                            foreach (var g in groupbyfilter2)
                            {
                                dt.Rows.Add(new object[] { g.Code, g.Nm, g.Tr, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                                tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                            }
                            dt.Rows.Add(new object[] { null, "Итого", null, tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region договоры
                        case 3:
                            var groupbyfilter3 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by new { id1 = row.Field<int>("idDocType"), id2 = row.Field<string>("Dogovor"), id3 = row.Field<DateTime>("dtPay") }
                                                     into grp
                                                     orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                                     select new
                                                        {
                                                            Code = grp.Key.id1,
                                                            Nm = grp.Key.id2,
                                                            Tr = grp.Key.id3,
                                                            Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                            Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                            Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                            Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                        };

                            foreach (var g in groupbyfilter3)
                            {
                                dt.Rows.Add(new object[] { g.Code, g.Nm, g.Tr, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                                tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                            }
                            dt.Rows.Add(new object[] { null, "Итого", null, tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region вид начисления
                        case 4:
                            var groupbyfilter4 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by new { id1 = row.Field<int>("TypeOfEnergy"), id2 = row.Field<string>("Energy"), id3 = row.Field<DateTime>("dtPay") }
                                                     into grp
                                                     orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                                     select new
                                                         {
                                                             Code = grp.Key.id1,
                                                             Nm = grp.Key.id2,
                                                             Tr = grp.Key.id3,
                                                             Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                             Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                             Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                             Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                         };

                            foreach (var g in groupbyfilter4)
                            {
                                dt.Rows.Add(new object[] { g.Code, g.Nm, g.Tr, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                                tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                            }
                            dt.Rows.Add(new object[] { null, "Итого", null, tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region объекты
                        case 6:
                            var groupbyfilter6 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by new { id1 = row.Field<int>("CodeAbonent"), id2 = row.Field<string>("Name"), id3 = row.Field<string>("ObjName"), id4 = row.Field<DateTime>("dtPay") }
                                                     into grp
                                                     orderby grp.Key.id1, grp.Key.id2, grp.Key.id3, grp.Key.id4
                                                     select new
                                                     {
                                                         Code = grp.Key.id1,
                                                         Nm = grp.Key.id2,
                                                         Tr = grp.Key.id3,
                                                         Dp = grp.Key.id4,
                                                         Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                         Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                         Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                         Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                     };

                            foreach (var g in groupbyfilter6)
                            {
                                dt.Rows.Add(new object[] { g.Code, g.Nm, g.Tr, g.Dp, g.Sum1, g.Sum2, g.Sum3, g.Sum4 });
                                tSum1 = tSum1 + g.Sum1; tSum2 = tSum2 + g.Sum2; tSum3 = tSum3 + g.Sum3; tSum4 = tSum4 + g.Sum4;
                            }
                            dt.Rows.Add(new object[] { null, "Итого", null, null, tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion

                    }
                    #endregion
                else
                #region Основная группировка
                {
                    switch (cmbGroup.SelectedIndex)
                    {
                        #region абоненты
                        case 0:
                            var groupbyfilter = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                group row by row.Field<int>("CodeAbonent") into grp
                                                orderby grp.Key
                                                select new
                                                {
                                                    KeyNo = grp.Key,
                                                    LineName = grp.Select(r => r.Field<string>("Name")),
                                                    Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                    Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                    Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                    Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                };

                            foreach (var grp in groupbyfilter)
                            {
                                dt.Rows.Add(new object[] { grp.KeyNo, grp.LineName.First(), grp.Sum1, grp.Sum2, grp.Sum3, grp.Sum4 });
                                tSum1 = tSum1 + grp.Sum1; tSum2 = tSum2 + grp.Sum2; tSum3 = tSum3 + grp.Sum3; tSum4 = tSum4 + grp.Sum4;
                            }
                            if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                            dt.Rows.Add(new object[] { null, "Итого", tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region тарифные группы
                        case 1:
                            var groupbyfilter1 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by row.Field<int>("idTariff") into grp
                                                 orderby grp.Key
                                                 select new
                                                 {
                                                     KeyNo = grp.Key,
                                                     LineName = grp.Select(r => r.Field<string>("TariffGroup")),
                                                     Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                     Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                     Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                     Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                 };

                            foreach (var grp in groupbyfilter1)
                            {
                                dt.Rows.Add(new object[] { grp.KeyNo, grp.LineName.First(), grp.Sum1, grp.Sum2, grp.Sum3, grp.Sum4 });
                                tSum1 = tSum1 + grp.Sum1; tSum2 = tSum2 + grp.Sum2; tSum3 = tSum3 + grp.Sum3; tSum4 = tSum4 + grp.Sum4;
                            }
                            if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                            dt.Rows.Add(new object[] { null, "Итого", tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region специалисты
                        case 2:
                            var groupbyfilter2 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by row.Field<int>("idWorker") into grp
                                                 orderby grp.Key
                                                 select new
                                                 {
                                                     KeyNo = grp.Key,
                                                     LineName = grp.Select(r => r.Field<string>("Worker")),
                                                     Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                     Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                     Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                     Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                 };

                            foreach (var grp in groupbyfilter2)
                            {
                                dt.Rows.Add(new object[] { grp.KeyNo, grp.LineName.First(), grp.Sum1, grp.Sum2, grp.Sum3, grp.Sum4 });
                                tSum1 = tSum1 + grp.Sum1; tSum2 = tSum2 + grp.Sum2; tSum3 = tSum3 + grp.Sum3; tSum4 = tSum4 + grp.Sum4;
                            }
                            if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                            dt.Rows.Add(new object[] { null, "Итого", tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region договоры
                        case 3:
                            var groupbyfilter3 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by row.Field<int>("idDocType") into grp
                                                 orderby grp.Key
                                                 select new
                                                 {
                                                     KeyNo = grp.Key,
                                                     LineName = grp.Select(r => r.Field<string>("Dogovor")),
                                                     Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                     Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                     Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                     Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                 };

                            foreach (var grp in groupbyfilter3)
                            {
                                dt.Rows.Add(new object[] { grp.KeyNo, grp.LineName.First(), grp.Sum1, grp.Sum2, grp.Sum3, grp.Sum4 });
                                tSum1 = tSum1 + grp.Sum1; tSum2 = tSum2 + grp.Sum2; tSum3 = tSum3 + grp.Sum3; tSum4 = tSum4 + grp.Sum4;
                            }
                            if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                            dt.Rows.Add(new object[] { null, "Итого", tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region вид начисления
                        case 4:
                            var groupbyfilter4 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by row.Field<int>("TypeOfEnergy") into grp
                                                 orderby grp.Key
                                                 select new
                                                 {
                                                     KeyNo = grp.Key,
                                                     LineName = grp.Select(r => r.Field<string>("Energy")),
                                                     Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                     Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                     Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                     Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                 };

                            foreach (var grp in groupbyfilter4)
                            {
                                dt.Rows.Add(new object[] { grp.KeyNo, grp.LineName.First(), grp.Sum1, grp.Sum2, grp.Sum3, grp.Sum4 });
                                tSum1 = tSum1 + grp.Sum1; tSum2 = tSum2 + grp.Sum2; tSum3 = tSum3 + grp.Sum3; tSum4 = tSum4 + grp.Sum4;
                            }
                            if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                            dt.Rows.Add(new object[] { null, "Итого", tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region подстанции
                        case 5:
                            var groupbyfilter5 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                 group row by row.Field<int>("idStation") into grp
                                                 orderby grp.Key
                                                 select new
                                                 {
                                                     KeyNo = grp.Key,
                                                     LineName = grp.Select(r => r.Field<string>("NameStation")),
                                                     Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                     Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                     Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                     Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                 };

                            foreach (var grp in groupbyfilter5)
                            {
                                dt.Rows.Add(new object[] { grp.KeyNo, grp.LineName.First(), grp.Sum1, grp.Sum2, grp.Sum3, grp.Sum4 });
                                tSum1 = tSum1 + grp.Sum1; tSum2 = tSum2 + grp.Sum2; tSum3 = tSum3 + grp.Sum3; tSum4 = tSum4 + grp.Sum4;
                            }
                            dt.Rows.Add(new object[] { null, "Итого", tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion
                        #region сети
                        case 7:
                            var groupbyfilter7 = from row in dsCntVal1.vG_ReportMain.AsEnumerable()
                                                group row by row.Field<int>("CodeAbonent") into grp
                                                orderby grp.Key
                                                select new
                                                {
                                                    KeyNo = grp.Key,
                                                    LineName = grp.Select(r => r.Field<string>("Name")),
                                                    Sum1 = grp.Sum(r => r.Field<int>("Quantity")),
                                                    Sum2 = grp.Sum(r => r.Field<decimal>("Summa")),
                                                    Sum3 = grp.Sum(r => r.Field<decimal>("Nalog")),
                                                    Sum4 = grp.Sum(r => r.Field<decimal>("SumTotal"))
                                                };

                            foreach (var grp in groupbyfilter7)
                            {
                                dt.Rows.Add(new object[] { grp.KeyNo, grp.LineName.First(), grp.Sum1, grp.Sum2, grp.Sum3, grp.Sum4 });
                                tSum1 = tSum1 + grp.Sum1; tSum2 = tSum2 + grp.Sum2; tSum3 = tSum3 + grp.Sum3; tSum4 = tSum4 + grp.Sum4;
                            }
                            if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                            dt.Rows.Add(new object[] { null, "Итого", tSum1, tSum2, tSum3, tSum4 });
                            break;
                        #endregion

                    }
                }
                #endregion
                #endregion
            }
            else
            {
                #region Группировка столбцов по уровням напряжения
                int tSum1 = 0;
                int tSum2 = 0;
                int tSum3 = 0;
                int tSum4 = 0;
                int tSum5 = 0;
                int tSum6 = 0;
                int tSum = 0;

                if (cbDate.Checked == true)
                {
                    var groupbyfilter = from row in dsCntVal1.vG_ReportMain_Excel.AsEnumerable()
                                        group row by new { id1 = row.Field<int>("CodeAbonent"), id2 = row.Field<DateTime>("dtPay"), id3 = row.Field<string>("Net") } into grp
                                        orderby grp.Key.id1, grp.Key.id2, grp.Key.id3
                                        select new
                                        {
                                            KeyNo = grp.Key.id1,
                                            KeyNo1 = grp.Key.id2,
                                            KeyNo2 = grp.Key.id3,
                                            id = grp.Select(r => r.Field<int>("id")),
                                            Name = grp.Select(r => r.Field<string>("Name")),
                                            Worker = grp.Select(r => r.Field<string>("Worker")),
                                            Sum1 = grp.Sum(r => r.Field<int>("sum1")),
                                            Sum2 = grp.Sum(r => r.Field<int>("sum2")),
                                            Sum3 = grp.Sum(r => r.Field<int>("sum3")),
                                            Sum4 = grp.Sum(r => r.Field<int>("sum4")),
                                            Sum5 = grp.Sum(r => r.Field<int>("sum5")),
                                            Sum6 = grp.Sum(r => r.Field<int>("sum6")),
                                            TotSum = grp.Sum(r => r.Field<int>("totsum"))
                                        };

                    foreach (var grp in groupbyfilter)
                    {
                        dt.Rows.Add(new object[] { grp.id.First(), grp.KeyNo, grp.Name.First(), grp.KeyNo1, grp.Sum1, grp.Sum2, grp.Sum3, grp.Sum4, grp.Sum5, grp.Sum6, grp.TotSum, grp.KeyNo2, grp.Worker.First() });
                        tSum1 = tSum1 + grp.Sum1; tSum2 = tSum2 + grp.Sum2; tSum3 = tSum3 + grp.Sum3; tSum4 = tSum4 + grp.Sum4; tSum5 = tSum5 + grp.Sum5; tSum6 = tSum6 + grp.Sum6; tSum = tSum + grp.TotSum;
                    }
                    if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                    dt.Rows.Add(new object[] { null, null, "Итого", null, tSum1, tSum2, tSum3, tSum4, tSum5, tSum6, tSum, "" });

                }
                else
                {
                    if (FlagNewTariff)
                    {
                        var groupbyfilter = from row in dsDop2.vG_LegReportMain_Excel_New.AsEnumerable()
                                            group row by new { id1 = row.Field<int>("CodeAbonent"), id2 = row.Field<string>("Net"), id3 = row.Field<string>("TypeDog"), id4 = row.Field<string>("GroupTariff") } into grp
                                            orderby grp.Key.id1, grp.Key.id2, grp.Key.id3, grp.Key.id4
                                            select new
                                            {
                                                KeyNo = grp.Key.id1,
                                                KeyNo1 = grp.Key.id2,
                                                KeyNo2 = grp.Key.id3,
                                                KeyNo3 = grp.Key.id4,
                                                id = grp.Select(r => r.Field<int>("id")),
                                                Name = grp.Select(r => r.Field<string>("Name")),
                                                Worker = grp.Select(r => r.Field<string>("Worker")),
                                                CodeAbnStr = grp.Select(r => r.Field<string>("CodeAbnStr")),
                                                //                                                TypeDog = grp.Select(r => r.Field<string>("TypeDog")),
                                                Sum1 = grp.Sum(r => r.Field<int>("sum1")),
                                                Sum2 = grp.Sum(r => r.Field<int>("sum2")),
                                                Sum3 = grp.Sum(r => r.Field<int>("sum3")),
                                                TotSum = grp.Sum(r => r.Field<int>("totsum"))
                                            };

                        foreach (var grp in groupbyfilter)
                        {
                            dt.Rows.Add(new object[] { grp.id.First(), grp.KeyNo, grp.Name.First(), grp.Sum1, grp.Sum2, grp.Sum3, grp.TotSum, grp.KeyNo1, grp.Worker.First(), grp.CodeAbnStr.First(), grp.KeyNo3, grp.KeyNo2 });
                            tSum1 = tSum1 + grp.Sum1; tSum2 = tSum2 + grp.Sum2; tSum3 = tSum3 + grp.Sum3; tSum = tSum + grp.TotSum;
                        }
                        if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                        dt.Rows.Add(new object[] { null, null, "Итого", tSum1, tSum2, tSum3, tSum, "" });

                        //var groupbyfilter = from row in dsDop2.vG_LegReportMain_Excel_New.AsEnumerable()
                        //                    select row;

                        //foreach (var grp in groupbyfilter)
                        //{
                        //    dt.Rows.Add(new object[] { grp.id, grp.CodeAbonent, grp.Name, grp.sum1, grp.sum2, grp.sum3, grp.totsum, grp.Net, grp.Worker, grp.CodeAbnStr, grp.TypeDog, grp.GroupTariff });
                        //    tSum1 = tSum1 + grp.sum1; tSum2 = tSum2 + grp.sum2; tSum3 = tSum3 + grp.sum3; tSum = tSum + grp.totsum;
                        //}
                        //dt.Rows.Add(new object[] { null, null, "Итого", tSum1, tSum2, tSum3, tSum, "" });


                    }
                    else
                    {
                        var groupbyfilter = from row in dsCntVal1.vG_ReportMain_Excel.AsEnumerable()
                                            group row by new { id1 = row.Field<int>("CodeAbonent"), id2 = row.Field<string>("Net") } into grp
                                            orderby grp.Key.id1, grp.Key.id2
                                            select new
                                            {
                                                KeyNo = grp.Key.id1,
                                                KeyNo1 = grp.Key.id2,
                                                id = grp.Select(r => r.Field<int>("id")),
                                                Name = grp.Select(r => r.Field<string>("Name")),
                                                Worker = grp.Select(r => r.Field<string>("Worker")),
                                                Sum1 = grp.Sum(r => r.Field<int>("sum1")),
                                                Sum2 = grp.Sum(r => r.Field<int>("sum2")),
                                                Sum3 = grp.Sum(r => r.Field<int>("sum3")),
                                                Sum4 = grp.Sum(r => r.Field<int>("sum4")),
                                                Sum5 = grp.Sum(r => r.Field<int>("sum5")),
                                                Sum6 = grp.Sum(r => r.Field<int>("sum6")),
                                                TotSum = grp.Sum(r => r.Field<int>("totsum"))
                                            };

                        foreach (var grp in groupbyfilter)
                        {
                            dt.Rows.Add(new object[] { grp.id.First(), grp.KeyNo, grp.Name.First(), grp.Sum1, grp.Sum2, grp.Sum3, grp.Sum4, grp.Sum5, grp.Sum6, grp.TotSum, grp.KeyNo1, grp.Worker.First() });
                            tSum1 = tSum1 + grp.Sum1; tSum2 = tSum2 + grp.Sum2; tSum3 = tSum3 + grp.Sum3; tSum4 = tSum4 + grp.Sum4; tSum5 = tSum5 + grp.Sum5; tSum6 = tSum6 + grp.Sum6; tSum = tSum + grp.TotSum;
                        }
                        if (tSum1 >= tSumPower) tSum1 -= tSumPower;
                        dt.Rows.Add(new object[] { null, null, "Итого", tSum1, tSum2, tSum3, tSum4, tSum5, tSum6, tSum, "" });
                    }
                }
                #endregion
            }

            txtRowCount.Text = (dataGridView1.RowCount - 1).ToString();
            this.Cursor = Cursors.Default;

            #endregion
        }

        // экспорт в Excel
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.Rows.Count > 0) && (rbTariffValue.Checked = true))
            {
                this.Cursor = Cursors.WaitCursor;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                // добавляем книгу и лист
                xlApp = new Excel.ApplicationClass();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                int ColCount = dataGridView1.Columns.Count;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:E").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:E").Font.Size = 10;

                // шрифт для наименования отчета
                xlWorkSheet.get_Range("A1", "H2").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A1", "H2").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "H2").Font.Size = 12;

                // наименование отчета
                xlWorkSheet.get_Range("A1", "H1").Merge(misValue);
                xlWorkSheet.get_Range("A1", "H1").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "H1").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "H1").Value2 = "Ведомость по передаче электроэнергии по сетям МУП УльГЭС";

                xlWorkSheet.get_Range("A2", "H2").Merge(misValue);
                xlWorkSheet.get_Range("A2", "H2").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "H2").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "H2").Value2 = "за период с " + dtBegin.Value.Date.ToShortDateString() + " по " + dtEnd.Value.Date.ToShortDateString() + dog_type + subcontract;

                int i = 0;
                int j = 0;
                int k = 4;

                // перечень сетевых организаций
                if (subcontract != "")
                {
                    for (i = 0; i <= (clbOrgNet.CheckedItems.Count) - 1; i++)
                    {
                        xlWorkSheet.Cells[i + 4, 1] = clbOrgNet.CheckedItems[i].ToString();
                        k = k + 1;
                    }
                }

                k = k + 2;
                if (ColCount == 7)
                {
                    // заголовок таблицы
                    xlWorkSheet.get_Range("A" + k, misValue).Value2 = "Код";
                    xlWorkSheet.get_Range("B" + k, misValue).Value2 = "Наименование";
                    if (cbTariff.Checked == true)
                        xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Тариф";
                    if (cbObject.Checked == true)
                        xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Объект";
                    if (cbDate.Checked == true)
                        xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Дата";
                    xlWorkSheet.get_Range("D" + k, misValue).Value2 = "Расход";
                    xlWorkSheet.get_Range("E" + k, misValue).Value2 = "Сумма";
                    xlWorkSheet.get_Range("F" + k, misValue).Value2 = "Налог";
                    xlWorkSheet.get_Range("G" + k, misValue).Value2 = "Всего";

                    // установим ширину столбцов
                    xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 8;
                    xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 40;
                    if (cbTariff.Checked == true)
                        xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 14;
                    if (cbObject.Checked == true)
                        xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 40;
                    xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 12;
                    xlWorkSheet.get_Range("E:E", misValue).ColumnWidth = 14;
                    xlWorkSheet.get_Range("F:F", misValue).ColumnWidth = 14;
                    xlWorkSheet.get_Range("G:G", misValue).ColumnWidth = 14;
                }
                else
                {
                    // заголовок таблицы
                    xlWorkSheet.get_Range("A" + k, misValue).Value2 = "Код";
                    xlWorkSheet.get_Range("B" + k, misValue).Value2 = "Наименование";
                    xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Расход";
                    xlWorkSheet.get_Range("D" + k, misValue).Value2 = "Сумма";
                    xlWorkSheet.get_Range("E" + k, misValue).Value2 = "Налог";
                    xlWorkSheet.get_Range("F" + k, misValue).Value2 = "Всего";

                    // установим ширину столбцов
                    xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 8;
                    xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 40;
                    xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 12;
                    xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 14;
                    xlWorkSheet.get_Range("E:E", misValue).ColumnWidth = 14;
                    xlWorkSheet.get_Range("F:F", misValue).ColumnWidth = 14;
                }
                xlWorkSheet.get_Range("A" + k, "G" + k).VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A" + k, "G" + k).HorizontalAlignment = Excel.Constants.xlCenter;

                k = k + 1;
                // вывод данных в ячейки
                int m = dataGridView1.RowCount;
                for (i = 0; i <= m - 1; i++)
                {
                    for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dataGridView1[j, i];
                        xlWorkSheet.Cells[i + k, j + 1] = cell.Value;
                    }
                }

                if (ColCount == 7)
                {
                    // форматирование данных
                    xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "### ##0";
                    xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "Общий";
                    if (cbTariff.Checked == true)
                        xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "### ##0,000000";
                    if (cbObject.Checked == true)
                        xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "Общий";
                    xlWorkSheet.get_Range("D:D", misValue).NumberFormat = "### ##0";
                    xlWorkSheet.get_Range("E:E", misValue).NumberFormat = "### ##0,00";
                    xlWorkSheet.get_Range("F:F", misValue).NumberFormat = "### ##0,00";
                    xlWorkSheet.get_Range("G:G", misValue).NumberFormat = "### ##0,00";
                }
                else
                {
                    // форматирование данных
                    xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "### ##0";
                    xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "Общий";
                    xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "### ##0";
                    xlWorkSheet.get_Range("D:D", misValue).NumberFormat = "### ##0,00";
                    xlWorkSheet.get_Range("E:E", misValue).NumberFormat = "### ##0,00";
                    xlWorkSheet.get_Range("F:F", misValue).NumberFormat = "### ##0,00";
                }

                //
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                k = k + m + 2;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).Merge(misValue);
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).Value2 = "Начальник службы контроля и учета электрической энергии";

                xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                xlWorkSheet.PageSetup.LeftMargin = 80;
                xlWorkSheet.PageSetup.RightMargin = 25;
                xlWorkSheet.PageSetup.BottomMargin = 25;
                xlWorkSheet.PageSetup.TopMargin = 25;



                this.Cursor = Cursors.Default;
                xlApp.Visible = true;
            }
            else
                MessageBox.Show("Нет данных для отчета ..");
        }

        // экспорт в Excel для сбытовой организации
        private void btnPrint1_Click(object sender, EventArgs e)
        {
            DateTime DateNewTariff = new DateTime(2015, 7, 1);
            Boolean FlagNewTariff = (dtBegin.Value >= DateNewTariff);


            if ((dataGridView1.Rows.Count > 0) && (rbTariffGroup.Checked = true))
            {
                this.Cursor = Cursors.WaitCursor;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;

                object misValue = System.Reflection.Missing.Value;

                // добавляем книгу и лист
                xlApp = new Excel.ApplicationClass();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                int ColCount = dataGridView1.Columns.Count + 1;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:M").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:M").Font.Size = 10;

                // шрифт для наименования отчета
                xlWorkSheet.get_Range("A1", "M3").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A1", "M3").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "M3").Font.Size = 12;

                // наименование отчета
                xlWorkSheet.get_Range("A1", "M1").Merge(misValue);
                xlWorkSheet.get_Range("A1", "M1").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "M1").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "M1").Value2 = "Ведомость по передаче электроэнергии по сетям МУП УльГЭС";

                xlWorkSheet.get_Range("A2", "N2").Merge(misValue);
                xlWorkSheet.get_Range("A2", "M2").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "M2").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "M2").Value2 = "за период с " + dtBegin.Value.Date.ToShortDateString() + " по " + dtEnd.Value.Date.ToShortDateString() + dog_type + subcontract;

                int i = 0;
                int j = 0;
                int k = 4;

                // перечень сетевых организаций
                if (subcontract != "")
                {
                    for (i = 0; i <= (clbOrgNet.CheckedItems.Count) - 1; i++)
                    {
                        xlWorkSheet.Cells[i + 4, 1] = clbOrgNet.CheckedItems[i].ToString();
                        k = k + 1;
                    }
                }

                k = k + 2;
                // заголовок таблицы
                if (cbDate.Checked == true)
                {
                    xlWorkSheet.get_Range("A" + k, misValue).Value2 = "Код";
                    xlWorkSheet.get_Range("B" + k, misValue).Value2 = "Наименование";
                    xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Дата";
                }
                else
                {
                    xlWorkSheet.get_Range("A" + k, misValue).Value2 = "AbnID";
                    xlWorkSheet.get_Range("B" + k, misValue).Value2 = "Код";
                    xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Наименование";
                }

                if (FlagNewTariff)
                {
                    xlWorkSheet.get_Range("D" + k, misValue).Value2 = "ВН";
                    xlWorkSheet.get_Range("E" + k, misValue).Value2 = "СН";
                    xlWorkSheet.get_Range("F" + k, misValue).Value2 = "НН";
                    xlWorkSheet.get_Range("G" + k, misValue).Value2 = "Всего";
                    xlWorkSheet.get_Range("H" + k, misValue).Value2 = "Сеть";
                    xlWorkSheet.get_Range("I" + k, misValue).Value2 = "Специалист";
                    xlWorkSheet.get_Range("J" + k, misValue).Value2 = "№ договора";
                    xlWorkSheet.get_Range("K" + k, misValue).Value2 = "Тип";
                    xlWorkSheet.get_Range("L" + k, misValue).Value2 = "Группа потребителей";
                }
                else
                {
                    xlWorkSheet.get_Range("D" + k, misValue).Value2 = "ВН";
                    xlWorkSheet.get_Range("E" + k, misValue).Value2 = "СН";
                    xlWorkSheet.get_Range("F" + k, misValue).Value2 = "НН";
                    xlWorkSheet.get_Range("G" + k, misValue).Value2 = "ВН_НАС";
                    xlWorkSheet.get_Range("H" + k, misValue).Value2 = "СН_НАС";
                    xlWorkSheet.get_Range("I" + k, misValue).Value2 = "НН_НАС";
                    xlWorkSheet.get_Range("J" + k, misValue).Value2 = "Всего";
                    xlWorkSheet.get_Range("K" + k, misValue).Value2 = "Сеть";
                    xlWorkSheet.get_Range("L" + k, misValue).Value2 = "Специалист";
                    xlWorkSheet.get_Range("M" + k, misValue).Value2 = "№ договора";
                }

                // установим ширину столбцов
                if (cbDate.Checked == true)
                {
                    xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 8;
                    xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 32;
                    xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 8;
                }
                else
                {
                    xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 8;
                    xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 8;
                    xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 32;
                }
                xlWorkSheet.get_Range("D:D", misValue).ColumnWidth = 9;
                xlWorkSheet.get_Range("E:E", misValue).ColumnWidth = 9;
                xlWorkSheet.get_Range("F:F", misValue).ColumnWidth = 9;
                xlWorkSheet.get_Range("G:G", misValue).ColumnWidth = 9;

                if (FlagNewTariff)
                {
                    xlWorkSheet.get_Range("H:H", misValue).ColumnWidth = 16;
                    xlWorkSheet.get_Range("I:I", misValue).ColumnWidth = 16;
                    xlWorkSheet.get_Range("J:J", misValue).ColumnWidth = 16;
                    xlWorkSheet.get_Range("K:K", misValue).ColumnWidth = 16;
                    xlWorkSheet.get_Range("L:L", misValue).ColumnWidth = 16;
                }
                else
                {
                    xlWorkSheet.get_Range("H:H", misValue).ColumnWidth = 9;
                    xlWorkSheet.get_Range("I:I", misValue).ColumnWidth = 9;
                    xlWorkSheet.get_Range("J:J", misValue).ColumnWidth = 9;
                    xlWorkSheet.get_Range("K:K", misValue).ColumnWidth = 16;
                    xlWorkSheet.get_Range("L:L", misValue).ColumnWidth = 16;
                    xlWorkSheet.get_Range("M:M", misValue).ColumnWidth = 16;
                }

                // форматирование данных
                if (cbDate.Checked == true)
                {
                    xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "### ##0";
                    xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "Общий";
                }
                else
                {
                    xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "### ##0";
                    xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "### ##0";
                    xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "Общий";
                }
                xlWorkSheet.get_Range("D:D", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("E:E", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("F:F", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("G:G", misValue).NumberFormat = "### ##0";

                if (FlagNewTariff)
                {
                    xlWorkSheet.get_Range("H:H", misValue).NumberFormat = "Общий";
                    xlWorkSheet.get_Range("I:I", misValue).NumberFormat = "Общий";
                    xlWorkSheet.get_Range("J:J", misValue).NumberFormat = "";
                    xlWorkSheet.get_Range("K:K", misValue).NumberFormat = "Общий";
                    xlWorkSheet.get_Range("L:L", misValue).NumberFormat = "Общий";
                    xlWorkSheet.get_Range("L:L", misValue).HorizontalAlignment = Excel.Constants.xlLeft;
                }
                else
                {
                    xlWorkSheet.get_Range("H:H", misValue).NumberFormat = "### ##0";
                    xlWorkSheet.get_Range("I:I", misValue).NumberFormat = "### ##0";
                    xlWorkSheet.get_Range("J:J", misValue).NumberFormat = "### ##0";
                    xlWorkSheet.get_Range("K:K", misValue).NumberFormat = "Общий";
                    xlWorkSheet.get_Range("L:L", misValue).NumberFormat = "Общий";
                    xlWorkSheet.get_Range("M:M", misValue).HorizontalAlignment = Excel.Constants.xlLeft;
                }



                k = k + 1;
                // вывод данных в ячейки
                int m = dataGridView1.RowCount;
                int CodeAbonent = 0;
                for (i = 0; i <= m - 1; i++)
                {
                    if (cbDate.Checked == true)
                    {
                        for (j = 1; j <= dataGridView1.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dataGridView1[j, i];
                            xlWorkSheet.Cells[i + k, j] = cell.Value;
                        }
                        if (i < m - 1)
                        {
                            CodeAbonent = Convert.ToInt32(dataGridView1[1, i].Value);
                            this.SelectSqlData(dsCntVal1, dsCntVal1.tAbn, true, " where CodeAbonent = " + CodeAbonent);
                            xlWorkSheet.Cells[i + k, dataGridView1.ColumnCount] = dsCntVal1.tAbn.Rows[0]["CodeAbnStr"].ToString();
                        }
                    }
                    else
                    {
                        for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                        {
                            DataGridViewCell cell = dataGridView1[j, i];
                            xlWorkSheet.Cells[i + k, j + 1] = cell.Value;
                        }
                        if (!FlagNewTariff)
                        {
                            if (i < m - 1)
                            {
                                CodeAbonent = Convert.ToInt32(dataGridView1[1, i].Value);
                                this.SelectSqlData(dsCntVal1, dsCntVal1.tAbn, true, " where CodeAbonent = " + CodeAbonent);
                                xlWorkSheet.Cells[i + k, dataGridView1.ColumnCount + 1] = dsCntVal1.tAbn.Rows[0]["CodeAbnStr"].ToString();
                            }
                        }
                    }
                }

                if (cbDate.Checked == true)
                {
                    xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount - 1]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount - 1]).Borders.Weight = Excel.XlBorderWeight.xlThin;
                }
                else
                {
                    if (FlagNewTariff)
                    {
                        xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount - 1]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount - 1]).Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }
                    else
                    {
                        xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        xlWorkSheet.get_Range(xlWorkSheet.Cells[k - 1, 1], xlWorkSheet.Cells[k - 1 + m, ColCount]).Borders.Weight = Excel.XlBorderWeight.xlThin;
                    }
                }

                k = k + m + 2;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).Merge(misValue);
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, ColCount]).Value2 = "Начальник службы контроля и учета электрической энергии                  И.А.Гулько";

                xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                xlWorkSheet.PageSetup.LeftMargin = 80;
                xlWorkSheet.PageSetup.RightMargin = 25;
                xlWorkSheet.PageSetup.BottomMargin = 25;
                xlWorkSheet.PageSetup.TopMargin = 25;

                xlApp.Visible = true;
                this.Cursor = Cursors.Default;
            }
            else
                MessageBox.Show("Нет данных для отчета ..");
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        // формирование итоговых сумм
        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            //int QuantityTotal;
            //decimal SumTotal;
            //QuantityTotal = 0;
            //SumTotal = 0;
            //for (int i = 0; i < dataGridView1.RowCount; i++)
            //{
            //    QuantityTotal = QuantityTotal + (int)(dataGridView1.Rows[i].Cells["Sum1"].Value);
            //    SumTotal = SumTotal + (decimal)(dataGridView1.Rows[i].Cells["Sum2"].Value);
            //}
            //this.txtQuantityTotal.Text = QuantityTotal.ToString("0,0");
            //this.txtSumTotal.Text = SumTotal.ToString("0,0.00");
        }

        // сдвинуть период вперед
        private void btnPlus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(1).AddDays(-1);
        }

        // сдвинуть период назад
        private void btnMinus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(-1).AddDays(-1);
        }

        // выход из формы
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNet_Click(object sender, EventArgs e)
        {
            if (clbOrgNet.Items.Count > 0)
            {
                if (flag_net == 0)
                {
                    for (int i = 0; i <= (clbOrgNet.Items.Count) - 1; i++)
                    {
                        clbOrgNet.SetItemChecked(i, true);
                    }
                    flag_net = 1;
                }
                else
                {
                    for (int i = 0; i <= (clbOrgNet.Items.Count) - 1; i++)
                    {
                        clbOrgNet.SetItemChecked(i, false);
                    }
                    flag_net = 0;
                }
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            if (clbOrgSale.Items.Count > 0)
            {
                if (flag_sale == 0)
                {
                    for (int i = 0; i <= (clbOrgSale.Items.Count) - 1; i++)
                    {
                        clbOrgSale.SetItemChecked(i, true);
                    }
                    flag_sale = 1;
                }
                else
                {
                    for (int i = 0; i <= (clbOrgSale.Items.Count) - 1; i++)
                    {
                        clbOrgSale.SetItemChecked(i, false);
                    }
                    flag_sale = 0;
                }
            }

        }

        private void rbTariffValue_CheckedChanged(object sender, EventArgs e)
        {
            cmbGroup.SelectedIndex = 0;
            cmbGroup.Enabled = true;

            cbGroup.Checked = false;
            cbGroup.Enabled = true;

            cbTariff.Checked = false;
            cbTariff.Enabled = true;

            cbObject.Checked = false;
            cbObject.Enabled = true;
        }

        private void rbTariffGroup_CheckedChanged(object sender, EventArgs e)
        {
            cmbGroup.SelectedIndex = 0;
            cmbGroup.Enabled = false;

            cbGroup.Checked = false;
            cbGroup.Enabled = false;

            cbTariff.Checked = false;
            cbTariff.Enabled = false;

            cbObject.Checked = false;
            cbObject.Enabled = false;
        }

        private void cbGroup_CheckStateChanged(object sender, EventArgs e)
        {
            idFilter = 0;
            Calculat.FormReportMainFilter frm = new FormReportMainFilter();
            frm.Owner = this;
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
                cbGroup.Checked = true;
            else
                cbGroup.Checked = false;
        }

        private void cbTariff_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTariff.Checked == true)
            {
                cbObject.Checked = false;
                cbDate.Checked = false;
            }
        }

        private void cbObject_CheckedChanged(object sender, EventArgs e)
        {
            if (cbObject.Checked == true)
            {
                cbTariff.Checked = false;
                cbDate.Checked = false;
            }
        }

        private void cbDate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDate.Checked == true)
            {
                cbTariff.Checked = false;
                cbObject.Checked = false;
            }
        }

        private void rbSpecial_CheckedChanged(object sender, EventArgs e)
        {
            // загрузка специалистов
            clbSpecialist.Items.Clear();
            this.SelectSqlData(dsCntVal1, dsCntVal1.Tables["vWorkerGroup"], true,
                " where idgroup = " + Constants.Constants.WorkerGroupControlerUL + " order by fio ");

            for (int i = 0; i < dsCntVal1.vWorkerGroup.Rows.Count; i++)
            {
                clbSpecialist.Items.Add(new myList(dsCntVal1.vWorkerGroup[i]["id"].ToString(), dsCntVal1.vWorkerGroup[i]["FIO"].ToString()));
            }

            clbSpecialist.Refresh();
        }

        private void rbMaster_CheckedChanged(object sender, EventArgs e)
        {
            // загрузка мастеров
            clbSpecialist.Items.Clear();
            this.SelectSqlData(dsCntVal1, dsCntVal1.Tables["vWorkerGroup"], true,
                " where idgroup = " + Constants.Constants.WorkerGroupMasterUL + " order by fio ");

            for (int i = 0; i < dsCntVal1.vWorkerGroup.Rows.Count; i++)
            {
                clbSpecialist.Items.Add(new myList(dsCntVal1.vWorkerGroup[i]["id"].ToString(), dsCntVal1.vWorkerGroup[i]["FIO"].ToString()));
            }

            clbSpecialist.Refresh();
        }

        private void rbRaion_CheckedChanged(object sender, EventArgs e)
        {
            // загрузка районов
            clbSpecialist.Items.Clear();
            DataTable dt = this.SelectSqlData("tR_Classifier", true, " where parentId = 195 order by Name ");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                clbSpecialist.Items.Add(new myList(dt.Rows[i]["id"].ToString(), dt.Rows[i]["Name"].ToString()));
            }

            clbSpecialist.Refresh();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);

                string strCmd = "";

                strCmd = "select * from fn_LegReportMain_Ulenergo(@DateBegin, @DateEnd)";
                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dsDop2.vG_ReportMain_Ulenergo.Rows.Clear();
                dAdapt.Fill(dsDop2, "vG_ReportMain_Ulenergo");

                
                
                Excel.Application excelapp = new Excel.Application();

                excelapp.SheetsInNewWorkbook = 1;
                excelapp.Workbooks.Add(Type.Missing);

                Excel.Workbooks excelappworkbooks = excelapp.Workbooks;
                Excel.Workbook excelappworkbook = excelappworkbooks[1];

                Excel.Sheets excelsheets = excelappworkbook.Worksheets;
                Excel.Worksheet excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);

                Excel.Range excelcells;

                // Заголовок
                excelcells = (Excel.Range)excelworksheet.Cells[1, 1];
                excelcells.Value2 = "";
                // Шапка
                for (int i = 1; i <= dsDop2.vG_ReportMain_Ulenergo.Columns.Count; i++)
                {
                    excelcells = (Excel.Range)excelworksheet.Cells[1, i];
                    excelcells.Value2 = dsDop2.vG_ReportMain_Ulenergo.Columns[i - 1].ColumnName;
                }
                // Данные
               // int c = 0;
                int row = dsDop2.vG_ReportMain_Ulenergo.Rows.Count;
                int col = dsDop2.vG_ReportMain_Ulenergo.Columns.Count;
                //foreach (DataRow row in dsDop2.vG_ReportMain_Ulenergo.Rows)
                //{
                //    c++;
                //    foreach (DataColumn column in dsDop2.vG_ReportMain_Ulenergo.Columns)
                //    {
                //        excelcells = (Excel.Range)excelworksheet.Cells[c + 1, column.Ordinal + 1];
                //        if (column.DataType == Type.GetType("System.String"))
                //            excelcells.NumberFormat = "@";
                //        if (column.DataType == Type.GetType("System.DateTime"))
                //            excelcells.NumberFormat = @"ДД.ММ.ГГГГ";
                //        if (column.DataType == Type.GetType("System.Boolean"))
                //            excelcells.NumberFormat = "@";

                //        excelcells.Value2 = row[column];
                //        txtCountRows.Text = (c + 1).ToString() + " из " + cnt.ToString();
                //    }
                //}


                for (int c = 0; c <= row-1; c++)
                {
                    for (int j = 0; j <= col-1; j++)
                    {
                        excelworksheet.Cells[c+3, j+1] = dsDop2.vG_ReportMain_Ulenergo.Rows[c][j];
                        if (dsDop2.vG_ReportMain_Ulenergo.Rows[c][j].GetType() == Type.GetType("System.String"))
                            excelcells.NumberFormat = "@";
                        if (dsDop2.vG_ReportMain_Ulenergo.Rows[c][j].GetType() == Type.GetType("System.DateTime"))
                            excelcells.NumberFormat = @"ДД.ММ.ГГГГ";
                        if (dsDop2.vG_ReportMain_Ulenergo.Rows[c][j].GetType() == Type.GetType("System.Boolean"))
                            excelcells.NumberFormat = "@";

                        txtCountRows.Text = (c + 1).ToString() + " из " + row.ToString();
                    }
                }

                txtCountRows.Text = "";
                this.Cursor = Cursors.Default;
                excelapp.Visible = true;
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }

        }

        private void btnDNU_Click(object sender, EventArgs e)
        {
            Legal.Forms.Export.FormImportDNU frm = new Legal.Forms.Export.FormImportDNU();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }

        }

        private void btnExportExcelOther_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.Rows.Count > 0) && (rbTariffValue.Checked = true))
            {
                this.Cursor = Cursors.WaitCursor;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                // добавляем книгу и лист
                xlApp = new Excel.ApplicationClass();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlApp.Visible = false;


                //int ColCount = dataGridView1.Columns.Count;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:E").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:E").Font.Size = 10;

                // шрифт для наименования отчета
                xlWorkSheet.get_Range("A1", "H2").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A1", "H2").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "H2").Font.Size = 12;

                // наименование отчета
                xlWorkSheet.get_Range("A1", "H1").Merge(misValue);
                xlWorkSheet.get_Range("A1", "H1").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "H1").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "H1").Value2 = "Ведомость по передаче электроэнергии по сетям МУП УльГЭС";

                xlWorkSheet.get_Range("A2", "H2").Merge(misValue);
                xlWorkSheet.get_Range("A2", "H2").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "H2").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "H2").Value2 = "за период с " + dtBegin.Value.Date.ToShortDateString() + " по " + dtEnd.Value.Date.ToShortDateString() + dog_type + subcontract;

                int i = 0;
                int j = 0;
                int k = 4;

                // перечень сетевых организаций
                if (subcontract != "")
                {
                    for (i = 0; i <= (clbOrgNet.CheckedItems.Count) - 1; i++)
                    {
                        xlWorkSheet.Cells[i + 4, 1] = clbOrgNet.CheckedItems[i].ToString();
                        k = k + 1;
                    }
                }

                k = k + 2;
                // заголовок таблицы

                xlWorkSheet.get_Range("A" + k, misValue).Value2 = "Код";
                xlWorkSheet.get_Range("B" + k, misValue).Value2 = "Наименование";
                int n = 3;

                int count_month = 0;
                if (dtEnd.Value.Month > dtBegin.Value.Month)
                    count_month = dtEnd.Value.Month - dtBegin.Value.Month + 1;
                else
                    count_month = 12 - dtBegin.Value.Month + dtEnd.Value.Month + 1;

                for (i = 1; i <= count_month; i++)
                {
                    xlWorkSheet.Cells[k, n] = dtBegin.Value.Date.AddMonths(i).AddDays(-1);
                    n += 1;
                }

                // установим ширину столбцов
                xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 8;
                xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 40;

                // вывод данных в ячейки
                int m = dataGridView1.RowCount;
                string abncode = "";
                int first_col = dtBegin.Value.Month;
                int ncol = 0;
                int nrowsheet = k+1;
                int[] total_sum = new int[count_month+3];

                for (i = 0; i < m - 1; i++)
                {
                    if (dataGridView1[0, i].Value.ToString() != abncode)
                    {
                        nrowsheet += 1;
                        abncode = dataGridView1[0, i].Value.ToString();
                        xlWorkSheet.Cells[nrowsheet, 1] = dataGridView1[0, i].Value;
                        xlWorkSheet.Cells[nrowsheet, 2] = dataGridView1[1, i].Value;
                    }
                    int mec = Convert.ToDateTime(dataGridView1[2, i].Value).Month; 
                    if (mec < first_col)
                        ncol = (12 - first_col) + 3 + mec;
                    else
                        ncol = mec - first_col + 3;
                    xlWorkSheet.Cells[nrowsheet, ncol] = dataGridView1[3, i].Value;
                    total_sum[ncol] = total_sum[ncol] + Convert.ToInt32(dataGridView1[3, i].Value);
                }

                xlWorkSheet.Cells[nrowsheet + 1, 2] = "Итого"; 
                for (i = 3; i < total_sum.Length; i++)
                {
                    xlWorkSheet.Cells[nrowsheet + 1, i] = total_sum[i];
                }

                // форматирование данных
                xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "Общий";
                //xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "### ##0";

                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[nrowsheet+1, count_month+2]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[nrowsheet+1, count_month+2]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                k = nrowsheet + 3;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).Merge(misValue);
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).Value2 = "Начальник службы контроля и учета электрической энергии";

                xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                //xlWorkSheet.PageSetup.LeftMargin = 80;
                xlWorkSheet.PageSetup.RightMargin = 25;
                xlWorkSheet.PageSetup.BottomMargin = 25;
                xlWorkSheet.PageSetup.TopMargin = 25;

                this.Cursor = Cursors.Default;
                xlApp.Visible = true;
            }
            else
                MessageBox.Show("Нет данных для отчета ..");
        }
        

        private void btnExportExcelObject_Click(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedIndex != 6)
            {
                MessageBox.Show("Выберите группировку строк <Объекты> и снова сформируйте отчет ..");
                return;
            }
            if (cbDate.Checked != true)
            {
                MessageBox.Show("Выберите <дополнит. разбивать по дате> и снова сформируйте отчет ..");
                return;
            }
 

            if ((dataGridView1.Rows.Count > 0) && (rbTariffValue.Checked = true))
            {
                this.Cursor = Cursors.WaitCursor;

                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                // добавляем книгу и лист
                xlApp = new Excel.ApplicationClass();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                xlApp.Visible = false;


                //int ColCount = dataGridView1.Columns.Count;

                // шрифт для всего листа
                xlWorkSheet.get_Range("A:E").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A:E").Font.Size = 10;

                // шрифт для наименования отчета
                xlWorkSheet.get_Range("A1", "H2").Font.Name = "Times New Roman";
                xlWorkSheet.get_Range("A1", "H2").Font.Bold = true;
                xlWorkSheet.get_Range("A1", "H2").Font.Size = 12;

                // наименование отчета
                xlWorkSheet.get_Range("A1", "H1").Merge(misValue);
                xlWorkSheet.get_Range("A1", "H1").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "H1").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A1", "H1").Value2 = "Ведомость по передаче электроэнергии по сетям МУП УльГЭС";

                xlWorkSheet.get_Range("A2", "H2").Merge(misValue);
                xlWorkSheet.get_Range("A2", "H2").VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "H2").HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range("A2", "H2").Value2 = "за период с " + dtBegin.Value.Date.ToShortDateString() + " по " + dtEnd.Value.Date.ToShortDateString() + dog_type + subcontract;

                int i = 0;
                int j = 0;
                int k = 4;

                // перечень сетевых организаций
                if (subcontract != "")
                {
                    for (i = 0; i <= (clbOrgNet.CheckedItems.Count) - 1; i++)
                    {
                        xlWorkSheet.Cells[i + 4, 1] = clbOrgNet.CheckedItems[i].ToString();
                        k = k + 1;
                    }
                }

                k = k + 2;
                // заголовок таблицы

                xlWorkSheet.get_Range("A" + k, misValue).Value2 = "Код";
                xlWorkSheet.get_Range("B" + k, misValue).Value2 = "Потребитель";
                xlWorkSheet.get_Range("C" + k, misValue).Value2 = "Объект";
                int n = 4;

                int count_month = 0;
                if (dtEnd.Value.Month > dtBegin.Value.Month)
                    count_month = dtEnd.Value.Month - dtBegin.Value.Month + 1;
                else
                    count_month = 12 - dtBegin.Value.Month + dtEnd.Value.Month + 1;

                for (i = 1; i <= count_month; i++)
                {
                    xlWorkSheet.Cells[k, n] = dtBegin.Value.Date.AddMonths(i).AddDays(-1);
                    n += 1;
                }

                // установим ширину столбцов
                xlWorkSheet.get_Range("A:A", misValue).ColumnWidth = 8;
                xlWorkSheet.get_Range("B:B", misValue).ColumnWidth = 40;
                xlWorkSheet.get_Range("C:C", misValue).ColumnWidth = 40;

                // вывод данных в ячейки
                int m = dataGridView1.RowCount;
                string abncode = "";
                int first_col = dtBegin.Value.Month;
                int ncol = 0;
                int nrowsheet = k+1;
                int[] total_sum = new int[count_month+4];

                for (i = 0; i < m - 1; i++)
                {
                    if (dataGridView1[2, i].Value.ToString() != abncode)
                    {
                        nrowsheet += 1;
                        abncode = dataGridView1[2, i].Value.ToString();
                        xlWorkSheet.Cells[nrowsheet, 1] = dataGridView1[0, i].Value;
                        xlWorkSheet.Cells[nrowsheet, 2] = dataGridView1[1, i].Value;

                        xlWorkSheet.Cells[nrowsheet, 3] = dataGridView1[2, i].Value;
                    }
                    int mec = Convert.ToDateTime(dataGridView1[3, i].Value).Month; 
                    if (mec < first_col)
                        ncol = (12 - first_col) + 4 + mec;
                    else
                        ncol = mec - first_col + 4;
                    xlWorkSheet.Cells[nrowsheet, ncol] = dataGridView1[4, i].Value;
                    total_sum[ncol] = total_sum[ncol] + Convert.ToInt32(dataGridView1[4, i].Value);
                }

                xlWorkSheet.Cells[nrowsheet + 1, 2] = "Итого"; 
                for (i = 3; i < total_sum.Length; i++)
                {
                    xlWorkSheet.Cells[nrowsheet + 1, i] = total_sum[i];
                }

                // форматирование данных
                xlWorkSheet.get_Range("A:A", misValue).NumberFormat = "### ##0";
                xlWorkSheet.get_Range("B:B", misValue).NumberFormat = "Общий";
                xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "Общий";
                //xlWorkSheet.get_Range("C:C", misValue).NumberFormat = "### ##0";

                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[nrowsheet+1, count_month+3]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[nrowsheet+1, count_month+3]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                k = nrowsheet + 3;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).Merge(misValue);
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).VerticalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).HorizontalAlignment = Excel.Constants.xlCenter;
                xlWorkSheet.get_Range(xlWorkSheet.Cells[k, 1], xlWorkSheet.Cells[k, count_month]).Value2 = "Начальник службы контроля и учета электрической энергии";

                xlWorkSheet.PageSetup.Orientation = Excel.XlPageOrientation.xlLandscape;

                //xlWorkSheet.PageSetup.LeftMargin = 80;
                xlWorkSheet.PageSetup.RightMargin = 25;
                xlWorkSheet.PageSetup.BottomMargin = 25;
                xlWorkSheet.PageSetup.TopMargin = 25;

                this.Cursor = Cursors.Default;
                xlApp.Visible = true;
            }
            else
                MessageBox.Show("Нет данных для отчета ..");

        }

        private void btnReportAverage_Click(object sender, EventArgs e)
        {
            Legal.Forms.Calculat.FormReportMain_Average frm = new Legal.Forms.Calculat.FormReportMain_Average();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnReportHouse_Click(object sender, EventArgs e)
        {
            Legal.Forms.Calculat.FormReportHouseAll frm = new Legal.Forms.Calculat.FormReportHouseAll();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnReportPeriod_Click(object sender, EventArgs e)
        {
            Legal.Forms.Calculat.FormReportPeriod frm = new Legal.Forms.Calculat.FormReportPeriod();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }


        private void btnJournalActCheck_Click(object sender, EventArgs e)
        {
            Legal.Forms.ActCheck.Form_Journal_ActReplace frm = new Legal.Forms.ActCheck.Form_Journal_ActReplace();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnJournalMeterDemontag_Click(object sender, EventArgs e)
        {
            Legal.Forms.ActCheck.Form_Journal_MeterDemontag frm = new Legal.Forms.ActCheck.Form_Journal_MeterDemontag();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnExcelObjLink_Click(object sender, EventArgs e)
        {
            Legal.Forms.Calculat.FormReportObjLink frm = new Legal.Forms.Calculat.FormReportObjLink();
            frm.SqlSettings = this.SqlSettings;
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }


    }
}
