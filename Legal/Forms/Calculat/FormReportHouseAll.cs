using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ControlsLbr;


namespace Legal.Forms.Calculat
{
    public partial class FormReportHouseAll : FormLbr.FormBase
    {
        public int ABNSELECT;
        public int OBJSELECT;
        private int IDMAP;

        public FormReportHouseAll()
        {
            InitializeComponent();
            ABNSELECT = -1;
            IDMAP = -1;
        }

        private void FormReportHouseAll_Load(object sender, EventArgs e)
        {
            // устанавливаем расчетный период
            SelectSqlData(dsCalc1, dsCalc1.tG_PeriodCalc, true);
            dtBegin.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], 1);
            dtEnd.Value = new DateTime((int)dsCalc1.tG_PeriodCalc.Rows[0]["YearCalc"], (int)dsCalc1.tG_PeriodCalc.Rows[0]["MonthCalc"], dtBegin.Value.AddMonths(1).AddDays(-1).Day);
            cbLegal.Checked = false;
            cbDNU.Checked = false;
            cbPrv.Checked = false;
            rbHouse.Checked = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(1).AddDays(-1);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            dtBegin.Value = dtBegin.Value.AddMonths(-1);
            dtEnd.Value = dtEnd.Value.AddDays(1).AddMonths(-1).AddDays(-1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbHouse.Checked == true)
                Working();
            else
                Working1();
        }

        private void Working()
        {
            this.Cursor = Cursors.WaitCursor;

            dsCalc1.tG_HouseAll.Rows.Clear();
            this.dgvHouse.Columns.Clear();

            #region Вызвать функцию и получить данные

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";
                int par = 0;
                if (cbLegal.Checked == true)
                    par = 1;
                if (cbDNU.Checked == true)
                    par = 3;
                if (cbPrv.Checked == true)
                    par = 5;


                if (IDMAP > 0)
                    strCmd = "select * from fn_LegReport_HouseAll(@DateBegin, @DateEnd) where idMap = " + IDMAP + " order by Street, HouseAll";
                else
                {
                    if (ABNSELECT > 0)
                        strCmd = "select * from fn_LegReport_HouseAll_AbnSelect(@DateBegin, @DateEnd, @AbnSelect) order by Street, HouseAll";
                    else
                    
                        switch (par)
                        {
                            case 0:
                                strCmd = "select * from fn_LegReport_HouseAll(@DateBegin, @DateEnd) order by Street, HouseAll";
                                break;
                            case 1:
                                strCmd = "select * from fn_LegReport_HouseAll_Legal(@DateBegin, @DateEnd) order by Street, HouseAll";
                                break;
                            case 3:
                                strCmd = "select * from fn_LegReport_HouseAll_DNU(@DateBegin, @DateEnd) order by Street, HouseAll";
                                break;
                            case 5:
                                strCmd = "select * from fn_LegReport_HouseAll_Prv(@DateBegin, @DateEnd) order by Street, HouseAll";
                                break;
                        }
                }



                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                DateTime DateEnd = (DateTime)dtEnd.Value.Date;

                SqlParameter p1 = new SqlParameter("@DateBegin", DateBegin.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@DateEnd", DateEnd.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                if (ABNSELECT > 0)
                {
                    SqlParameter p3 = new SqlParameter("@AbnSelect", ABNSELECT);
                    sqlCmd.Parameters.Add(p3);
                }


                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCalc1, "tG_HouseAll");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
            #endregion

            #region Cоздание временной таблицы
            DataTable dt = new DataTable("dt_HouseAll");

            dt.Columns.Add(new DataColumn("idMap", typeof(int)));
            dt.Columns.Add(new DataColumn("idKladrObj", typeof(int)));
            dt.Columns.Add(new DataColumn("KladrObj", typeof(string)));
            dt.Columns.Add(new DataColumn("idStreet", typeof(int)));
            dt.Columns.Add(new DataColumn("Street", typeof(string)));
            dt.Columns.Add(new DataColumn("House", typeof(int)));
            dt.Columns.Add(new DataColumn("HousePrefix", typeof(string)));
            dt.Columns.Add(new DataColumn("HouseAll", typeof(string)));
            dt.Columns.Add(new DataColumn("TotalQuantity", typeof(long)));
            dt.Columns.Add(new DataColumn("AverageQuantity", typeof(long)));

            var CountMonth = 0;
            if (dtEnd.Value.Year == dtBegin.Value.Year)
                CountMonth = dtEnd.Value.Month - dtBegin.Value.Month + 1;
            else
                CountMonth = 12 * (dtEnd.Value.Year - dtBegin.Value.Year) - dtBegin.Value.Month + dtEnd.Value.Month + 1;

            string MonthName = "";
            DateTime dtBeg = dtBegin.Value; 

            for (var i = 0; i < CountMonth; i++) {
                if (dtBeg.Month < 10)
                    MonthName = dtBeg.Year.ToString() + "0" + dtBeg.Month.ToString();
                else
                    MonthName = dtBeg.Year.ToString() + dtBeg.Month.ToString();
                dt.Columns.Add(new DataColumn(MonthName, typeof(int)));
                dtBeg = dtBeg.AddMonths(1);
            }

            dsCalc1.Tables.Add(dt);

            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            #endregion

            #region Заполнение таблицы
            
            int RowsCount  = dsCalc1.tG_HouseAll.Rows.Count;
            int idMapSave = 0;

            DataRow drw = dt.NewRow();
            long TotalQuantityAll = 0;
            long AverageQuantityAll = 0;

            Dictionary<string, int> array = new Dictionary<string, int>();

            for (var i = 0; i < RowsCount; i++)
            {
                if (idMapSave != Convert.ToInt32(dsCalc1.tG_HouseAll.Rows[i]["idMap"]))
                {
                    if (i > 0)
                        dt.Rows.Add(drw);
                    drw = dt.NewRow();
                    drw["idMap"] = dsCalc1.tG_HouseAll.Rows[i]["idMap"];
                    drw["idKladrObj"] = dsCalc1.tG_HouseAll.Rows[i]["idKladrObj"];
                    drw["KladrObj"] = dsCalc1.tG_HouseAll.Rows[i]["KladrObj"];
                    drw["idStreet"] = dsCalc1.tG_HouseAll.Rows[i]["idStreet"];
                    drw["Street"] = dsCalc1.tG_HouseAll.Rows[i]["Street"];
                    drw["House"] = dsCalc1.tG_HouseAll.Rows[i]["House"];
                    drw["HousePrefix"] = dsCalc1.tG_HouseAll.Rows[i]["HousePrefix"];
                    drw["HouseAll"] = dsCalc1.tG_HouseAll.Rows[i]["HouseAll"];
                    drw["TotalQuantity"] = dsCalc1.tG_HouseAll.Rows[i]["TotalQuantity"];
                    drw["AverageQuantity"] = dsCalc1.tG_HouseAll.Rows[i]["AverageQuantity"];

                    
                    // Итоговые значения
                    TotalQuantityAll = TotalQuantityAll + Convert.ToInt64(dsCalc1.tG_HouseAll.Rows[i]["TotalQuantity"]);
                    AverageQuantityAll = AverageQuantityAll + Convert.ToInt32(dsCalc1.tG_HouseAll.Rows[i]["AverageQuantity"]);
                    
                    idMapSave = Convert.ToInt32(dsCalc1.tG_HouseAll.Rows[i]["idMap"]);
                }
                MonthName = Convert.ToString(dsCalc1.tG_HouseAll.Rows[i]["DateAct"]);
                if (MonthName != "")
                {
                    drw[MonthName] = dsCalc1.tG_HouseAll.Rows[i]["Quantity"];
                    if (array.ContainsKey(MonthName))
                        array[MonthName] += Convert.ToInt32(dsCalc1.tG_HouseAll.Rows[i]["Quantity"]);
                    else
                        array.Add(MonthName, Convert.ToInt32(dsCalc1.tG_HouseAll.Rows[i]["Quantity"]));
                }
            }
            dt.Rows.Add(drw);

            drw = dt.NewRow();
            drw["idMap"] = 0;
            drw["idKladrObj"] = 0;
            drw["KladrObj"] = " ";
            drw["idStreet"] = 0;
            drw["Street"] = "Всего";
            drw["House"] = 0;
            drw["HousePrefix"] = " ";
            drw["HouseAll"] = " ";
            drw["TotalQuantity"] = TotalQuantityAll;
            drw["AverageQuantity"] = TotalQuantityAll/CountMonth;
            //drw["AverageQuantity"] = AverageQuantityAll;
            foreach (var kvp in array)
            {
                drw[kvp.Key] = kvp.Value;
            }
            dt.Rows.Add(drw);
            #endregion


            // назначим источник данных грида
            dgvHouse.AutoGenerateColumns = false;
            dgvHouse.DataSource = bds;

            #region Формирование столбцов грида

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

            DataGridViewColumn idMap = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            idMap.Name = "idMap";
            DataGridViewColumn idKladrObj = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            idKladrObj.Name = "idKladrObj";
            DataGridViewColumn KladrObj = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            KladrObj.Name = "KladrObj";
            DataGridViewColumn idStreet = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            idStreet.Name = "idStreet";
            DataGridViewColumn Street = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Street.Name = "Street";
            DataGridViewColumn House = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            House.Name = "House";
            DataGridViewColumn HousePrefix = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            HousePrefix.Name = "HousePrefix";
            DataGridViewColumn HouseAll = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            HouseAll.Name = "HouseAll";
            DataGridViewColumn TotalQuantity = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            TotalQuantity.Name = "TotalQuantity";
            DataGridViewColumn AverageQuantity = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            AverageQuantity.Name = "AverageQuantity";

            dgvHouse.Columns.Add(idMap);
            dgvHouse.Columns.Add(idKladrObj);
            dgvHouse.Columns.Add(KladrObj);
            dgvHouse.Columns.Add(idStreet);
            dgvHouse.Columns.Add(Street);
            dgvHouse.Columns.Add(House);
            dgvHouse.Columns.Add(HousePrefix);
            dgvHouse.Columns.Add(HouseAll);
            dgvHouse.Columns.Add(TotalQuantity);
            dgvHouse.Columns.Add(AverageQuantity);
            
            for (var i = 10; i < 10+CountMonth; i++)
            {
                string ColName = dt.Columns[i].ColumnName;
                DataGridViewColumn Col = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
                Col.Name = ColName;
                dgvHouse.Columns.Add(Col);
                dgvHouse.Columns[ColName].Width = 70;
                dgvHouse.Columns[ColName].HeaderText = ColName;
                dgvHouse.Columns[ColName].ValueType = typeof(int);
                dgvHouse.Columns[ColName].DefaultCellStyle = IntStyle;
                dgvHouse.Columns[ColName].DataPropertyName = ColName;

            }

            dgvHouse.Columns["idMap"].Width = 70;
            dgvHouse.Columns["idMap"].HeaderText = "";
            dgvHouse.Columns["idMap"].ValueType = typeof(int);
            dgvHouse.Columns["idMap"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["idMap"].DataPropertyName = "idMap";
            dgvHouse.Columns["idMap"].Visible = false;

            dgvHouse.Columns["idKladrObj"].Width = 70;
            dgvHouse.Columns["idKladrObj"].HeaderText = "";
            dgvHouse.Columns["idKladrObj"].ValueType = typeof(int);
            dgvHouse.Columns["idKladrObj"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["idKladrObj"].DataPropertyName = "idKladrObj";
            dgvHouse.Columns["idKladrObj"].Visible = false;

            dgvHouse.Columns["KladrObj"].Width = 100;
            dgvHouse.Columns["KladrObj"].HeaderText = "Нас.пункт";
            dgvHouse.Columns["KladrObj"].ValueType = typeof(string);
            dgvHouse.Columns["KladrObj"].DefaultCellStyle = StringStyle;
            dgvHouse.Columns["KladrObj"].DataPropertyName = "KladrObj";

            dgvHouse.Columns["idStreet"].Width = 70;
            dgvHouse.Columns["idStreet"].HeaderText = "";
            dgvHouse.Columns["idStreet"].ValueType = typeof(int);
            dgvHouse.Columns["idStreet"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["idStreet"].DataPropertyName = "idStreet";
            dgvHouse.Columns["idStreet"].Visible = false;

            dgvHouse.Columns["Street"].Width = 250;
            dgvHouse.Columns["Street"].HeaderText = "Улица";
            dgvHouse.Columns["Street"].ValueType = typeof(string);
            dgvHouse.Columns["Street"].DefaultCellStyle = StringStyle;
            dgvHouse.Columns["Street"].DataPropertyName = "Street";

            dgvHouse.Columns["House"].Width = 70;
            dgvHouse.Columns["House"].HeaderText = "";
            dgvHouse.Columns["House"].ValueType = typeof(int);
            dgvHouse.Columns["House"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["House"].DataPropertyName = "House";
            dgvHouse.Columns["House"].Visible = false;

            dgvHouse.Columns["HousePrefix"].Width = 70;
            dgvHouse.Columns["HousePrefix"].HeaderText = "";
            dgvHouse.Columns["HousePrefix"].ValueType = typeof(string);
            dgvHouse.Columns["HousePrefix"].DefaultCellStyle = StringStyle;
            dgvHouse.Columns["HousePrefix"].DataPropertyName = "HousePrefix";
            dgvHouse.Columns["HousePrefix"].Visible = false;

            dgvHouse.Columns["HouseAll"].Width = 70;
            dgvHouse.Columns["HouseAll"].HeaderText = "Дом";
            dgvHouse.Columns["HouseAll"].ValueType = typeof(string);
            dgvHouse.Columns["HouseAll"].DefaultCellStyle = StringStyle;
            dgvHouse.Columns["HouseAll"].DataPropertyName = "HouseAll";
            dgvHouse.Columns["HouseAll"].Frozen = true;

            dgvHouse.Columns["TotalQuantity"].Width = 70;
            dgvHouse.Columns["TotalQuantity"].HeaderText = "Итого";
            dgvHouse.Columns["TotalQuantity"].ValueType = typeof(int);
            dgvHouse.Columns["TotalQuantity"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["TotalQuantity"].DataPropertyName = "TotalQuantity";
            dgvHouse.Columns["TotalQuantity"].Visible = true;

            dgvHouse.Columns["TotalQuantity"].Width = 70;
            dgvHouse.Columns["TotalQuantity"].HeaderText = "Всего";
            dgvHouse.Columns["TotalQuantity"].ValueType = typeof(long);
            dgvHouse.Columns["TotalQuantity"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["TotalQuantity"].DataPropertyName = "TotalQuantity";
            dgvHouse.Columns["TotalQuantity"].Visible = true;

            dgvHouse.Columns["AverageQuantity"].Width = 70;
            dgvHouse.Columns["AverageQuantity"].HeaderText = "Среднее";
            dgvHouse.Columns["AverageQuantity"].ValueType = typeof(int);
            dgvHouse.Columns["AverageQuantity"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["AverageQuantity"].DataPropertyName = "AverageQuantity";
            dgvHouse.Columns["AverageQuantity"].Visible = true;

            #endregion


            this.Cursor = Cursors.Default;


        }

        private void dgvHouse_DoubleClick(object sender, EventArgs e)
        {
            if (rbHouse.Checked != true)
            {
                int CodeAbn = Convert.ToInt32(dgvHouse.CurrentRow.Cells["CodeAbonent"].Value);
                if (dgvHouse.CurrentRow.Cells["AbnType"].Value.ToString() =="Потребитель ФЛ")
                {
                    int AbnType = (int)Constants.AbnType.Private;

                    Prv.Forms.Abonent.FormAbonent frm = new Prv.Forms.Abonent.FormAbonent(CodeAbn, AbnType);
                    frm.SqlSettings = this.SqlSettings;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                {
                    int idObj = Convert.ToInt32(dgvHouse.CurrentRow.Cells["idObj"].Value);
                    Legal.Forms.FormAbn frm = new Legal.Forms.FormAbn(CodeAbn, idObj);
                    frm.SqlSettings = this.SqlSettings;
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
            }
            else
            {
                DateTime DateBegin = (DateTime)dtBegin.Value.Date;
                DateTime DateEnd = (DateTime)dtEnd.Value.Date;
                int idMap = Convert.ToInt32(dgvHouse.CurrentRow.Cells["idMap"].Value);
                Legal.Forms.Calculat.FormReportHouseDetail frm = new Legal.Forms.Calculat.FormReportHouseDetail(DateBegin, DateEnd, idMap);
                frm.SqlSettings = this.SqlSettings;
                frm.MdiParent = this.MdiParent;
                frm.Show();
                //if (frm.ShowDialog() == DialogResult.OK)
                //{
                //}
            }
        }

        private void btnFilterObj_Click(object sender, EventArgs e)
        {
            FormAbnObjFind f = new FormAbnObjFind(-6);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (OBJSELECT > 0)
                {
                    SelectSqlData(dsCalc1, dsCalc1.tAbnObj, true, "where id = " + OBJSELECT);
                    if (dsCalc1.tAbnObj.Count > 0)
                    {
                        IDMAP = Convert.ToInt32(dsCalc1.tAbnObj.Rows[0]["idMap"]);
                        txtFilter.Text = dsCalc1.tAbnObj.Rows[0]["Name"].ToString();
                    }
                    Working();
                    ABNSELECT = -1;
                    OBJSELECT = -1;
                    IDMAP = -1;
                }
            }
        }

        private void btnFilterAbn_Click(object sender, EventArgs e)
        {
            FormAbnObjFind f = new FormAbnObjFind(-7);
            f.Owner = this;
            f.SqlSettings = this.SqlSettings;
            if (f.ShowDialog() == DialogResult.OK)
            {
                if (ABNSELECT > 0)
                {
                    SelectSqlData(dsCalc1, dsCalc1.tAbn, true, "where id = " + ABNSELECT);
                    if (dsCalc1.tAbn.Count > 0)
                    {
                        txtFilter.Text = dsCalc1.tAbn.Rows[0]["Name"].ToString();
                    }
                    Working();
                    ABNSELECT = -1;
                    OBJSELECT = -1;
                    IDMAP = -1;
                }
            }
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            ABNSELECT = -1;
            OBJSELECT = -1;
            IDMAP = -1;
            txtFilter.Text = "";
            Working();
        }

        private void Working1()
        {
            this.Cursor = Cursors.WaitCursor;
            dsCalc1.tG_HouseDetail.Rows.Clear();
            this.dgvHouse.Columns.Clear();

            #region Вызвать функцию и получить данные

            DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
            try
            {
                con.OpenConnection(SqlSettings);
                string strCmd = "";

                strCmd = "select * from fn_LegReport_HouseObject(@DateBegin, @DateEnd) order by AbnType, NameObj";

                SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                SqlParameter p1 = new SqlParameter("@DateBegin", dtBegin.Value.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p1);

                SqlParameter p2 = new SqlParameter("@DateEnd", dtEnd.Value.ToString("yyyyMMdd"));
                sqlCmd.Parameters.Add(p2);

                sqlCmd.CommandTimeout = 0;

                SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                dAdapt.Fill(dsCalc1, "tG_HouseDetail");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
            }
            finally
            {
                con.CloseConnection();
            }
            #endregion

            #region Cоздание временной таблицы
            DataTable dt = new DataTable("dt_HouseDetail");

            dt.Columns.Add(new DataColumn("AbnType", typeof(string)));
            dt.Columns.Add(new DataColumn("Status", typeof(string)));
            dt.Columns.Add(new DataColumn("dtStatus", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("idAbn", typeof(int)));
            dt.Columns.Add(new DataColumn("idObj", typeof(int)));
            dt.Columns.Add(new DataColumn("CodeAbonent", typeof(int)));
            dt.Columns.Add(new DataColumn("NameAbn", typeof(string)));
            dt.Columns.Add(new DataColumn("NameObj", typeof(string)));
            dt.Columns.Add(new DataColumn("TotalQuantity", typeof(int)));
            dt.Columns.Add(new DataColumn("AverageQuantity", typeof(int)));
            dt.Columns.Add(new DataColumn("idObjParent", typeof(int)));
            dt.Columns.Add(new DataColumn("idStatus", typeof(int)));
            dt.Columns.Add(new DataColumn("idMap", typeof(int)));


            var CountMonth = 0;
            if (dtEnd.Value.Year == dtBegin.Value.Year)
                CountMonth = dtEnd.Value.Month - dtBegin.Value.Month + 1;
            else
                CountMonth = 12 * (dtEnd.Value.Year - dtBegin.Value.Year) - dtBegin.Value.Month + dtEnd.Value.Month + 1;

            string MonthName = "";
            DateTime dtBeg = dtBegin.Value;

            for (var i = 0; i < CountMonth; i++)
            {
                if (dtBeg.Month < 10)
                    MonthName = dtBeg.Year.ToString() + "0" + dtBeg.Month.ToString();
                else
                    MonthName = dtBeg.Year.ToString() + dtBeg.Month.ToString();
                dt.Columns.Add(new DataColumn(MonthName, typeof(int)));
                dtBeg = dtBeg.AddMonths(1);
            }


            dsCalc1.Tables.Add(dt);

            BindingSource bds = new BindingSource();
            bds.DataSource = dt;
            #endregion

            // назначим источник данных грида
            dgvHouse.AutoGenerateColumns = false;
            dgvHouse.DataSource = bds;

            #region Заполнение таблицы

            int RowsCount = dsCalc1.tG_HouseDetail.Rows.Count;
            int idObjSave = 0;

            DataRow drw = dt.NewRow();

            int TotalQuantityAll = 0;
            int AverageQuantityAll = 0;

            Dictionary<string, int> array = new Dictionary<string, int>();

            for (var i = 0; i < RowsCount; i++)
            {
                if (idObjSave != Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["idObj"]))
                {
                    if (i > 0)
                        dt.Rows.Add(drw);
                    drw = dt.NewRow();
                    drw["AbnType"] = dsCalc1.tG_HouseDetail.Rows[i]["AbnType"];
                    drw["Status"] = dsCalc1.tG_HouseDetail.Rows[i]["Status"];
                    drw["dtStatus"] = dsCalc1.tG_HouseDetail.Rows[i]["dtStatus"];
                    drw["idObj"] = dsCalc1.tG_HouseDetail.Rows[i]["idObj"];
                    drw["CodeAbonent"] = dsCalc1.tG_HouseDetail.Rows[i]["CodeAbonent"];
                    drw["NameAbn"] = dsCalc1.tG_HouseDetail.Rows[i]["NameAbn"];
                    drw["NameObj"] = dsCalc1.tG_HouseDetail.Rows[i]["Nameobj"];
                    drw["TotalQuantity"] = dsCalc1.tG_HouseDetail.Rows[i]["TotalQuantity"];
                    drw["AverageQuantity"] = dsCalc1.tG_HouseDetail.Rows[i]["AverageQuantity"];
                    drw["idObjParent"] = dsCalc1.tG_HouseDetail.Rows[i]["IdObjParent"];
                    drw["idStatus"] = dsCalc1.tG_HouseDetail.Rows[i]["idStatus"];

                    if ((dsCalc1.tG_HouseDetail.Rows[i]["IdObjParent"].ToString() == "")
                        && (dsCalc1.tG_HouseDetail.Rows[i]["idStatus"].ToString() != "")
                        && (Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["idStatus"]) != 1293))
                    {
                        TotalQuantityAll = TotalQuantityAll + Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["TotalQuantity"]);
                        AverageQuantityAll = AverageQuantityAll + Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["AverageQuantity"]);
                    }

                    idObjSave = Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["idObj"]);
                }
                MonthName = Convert.ToString(dsCalc1.tG_HouseDetail.Rows[i]["DateAct"]);
                if (MonthName != "")
                {
                    drw[MonthName] = dsCalc1.tG_HouseDetail.Rows[i]["Quantity"];
                    if (dsCalc1.tG_HouseDetail.Rows[i]["IdObjParent"].ToString() == "")
                    {
                        if (array.ContainsKey(MonthName))
                            array[MonthName] += Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["Quantity"]);
                        else
                            array.Add(MonthName, Convert.ToInt32(dsCalc1.tG_HouseDetail.Rows[i]["Quantity"]));
                    }
                }


            }
            dt.Rows.Add(drw);

            drw = dt.NewRow();
            drw["NameAbn"] = "Итого";

            TotalQuantityAll = 0;
            AverageQuantityAll = 0;

            foreach (var kvp in array)
            {
                drw[kvp.Key] = kvp.Value;
                TotalQuantityAll += kvp.Value;
            }
            drw["TotalQuantity"] = TotalQuantityAll;
            drw["AverageQuantity"] = TotalQuantityAll / CountMonth;
            dt.Rows.Add(drw);

            #endregion

            #region Формирование столбцов грида

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

            DataGridViewColumn AbnType = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            AbnType.Name = "AbnType";
            DataGridViewColumn Status = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            Status.Name = "Status";
            DataGridViewColumn dtStatus = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            dtStatus.Name = "dtStatus";


            DataGridViewColumn idAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            idAbn.Name = "idAbn";
            DataGridViewColumn idObj = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            idObj.Name = "idObj";
            DataGridViewColumn CodeAbonent = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            CodeAbonent.Name = "CodeAbonent";
            DataGridViewColumn NameAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            NameAbn.Name = "NameAbn";
            DataGridViewColumn NameObj = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            NameObj.Name = "NameObj";

            DataGridViewColumn TotalQuantity = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            TotalQuantity.Name = "TotalQuantity";
            DataGridViewColumn AverageQuantity = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            AverageQuantity.Name = "AverageQuantity";

            DataGridViewColumn idObjParent = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            idObjParent.Name = "idObjParent";

            DataGridViewColumn idStatus = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            idStatus.Name = "idStatus";

            dgvHouse.Columns.Add(AbnType);
            dgvHouse.Columns.Add(Status);
            dgvHouse.Columns.Add(dtStatus);

            dgvHouse.Columns.Add(idAbn);
            dgvHouse.Columns.Add(idObj);
            dgvHouse.Columns.Add(CodeAbonent);
            dgvHouse.Columns.Add(NameAbn);
            dgvHouse.Columns.Add(NameObj);
            dgvHouse.Columns.Add(idObjParent);
            dgvHouse.Columns.Add(idStatus);
            dgvHouse.Columns.Add(TotalQuantity);
            dgvHouse.Columns.Add(AverageQuantity);

            for (var i = 12; i < 12 + CountMonth; i++)
            {
                string ColName = dt.Columns[i].ColumnName;
                DataGridViewColumn Col = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
                Col.Name = ColName;
                dgvHouse.Columns.Add(Col);
                dgvHouse.Columns[ColName].Width = 70;
                dgvHouse.Columns[ColName].HeaderText = ColName;
                dgvHouse.Columns[ColName].ValueType = typeof(int);
                dgvHouse.Columns[ColName].DefaultCellStyle = IntStyle;
                dgvHouse.Columns[ColName].DataPropertyName = ColName;

            }

            dgvHouse.Columns["AbnType"].Width = 100;
            dgvHouse.Columns["AbnType"].HeaderText = "Тип";
            dgvHouse.Columns["AbnType"].ValueType = typeof(string);
            dgvHouse.Columns["AbnType"].DefaultCellStyle = StringStyle;
            dgvHouse.Columns["AbnType"].DataPropertyName = "AbnType";

            dgvHouse.Columns["Status"].Width = 60;
            dgvHouse.Columns["Status"].HeaderText = "Статус";
            dgvHouse.Columns["Status"].ValueType = typeof(string);
            dgvHouse.Columns["Status"].DefaultCellStyle = StringStyle;
            dgvHouse.Columns["Status"].DataPropertyName = "Status";

            dgvHouse.Columns["dtStatus"].Width = 80;
            dgvHouse.Columns["dtStatus"].HeaderText = "Дата";
            dgvHouse.Columns["dtStatus"].ValueType = typeof(string);
            dgvHouse.Columns["dtStatus"].DefaultCellStyle = StringStyle;
            dgvHouse.Columns["dtStatus"].DataPropertyName = "dtStatus";



            dgvHouse.Columns["idAbn"].Width = 70;
            dgvHouse.Columns["idAbn"].HeaderText = "";
            dgvHouse.Columns["idAbn"].ValueType = typeof(int);
            dgvHouse.Columns["idAbn"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["idAbn"].DataPropertyName = "idAbn";
            dgvHouse.Columns["idAbn"].Visible = false;

            dgvHouse.Columns["idObj"].Width = 70;
            dgvHouse.Columns["idObj"].HeaderText = "";
            dgvHouse.Columns["idObj"].ValueType = typeof(int);
            dgvHouse.Columns["idObj"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["idObj"].DataPropertyName = "idObj";
            dgvHouse.Columns["idObj"].Visible = false;

            dgvHouse.Columns["CodeAbonent"].Width = 70;
            dgvHouse.Columns["CodeAbonent"].HeaderText = "Код";
            dgvHouse.Columns["CodeAbonent"].ValueType = typeof(int);
            dgvHouse.Columns["CodeAbonent"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["CodeAbonent"].DataPropertyName = "CodeAbonent";
            dgvHouse.Columns["CodeAbonent"].Visible = true;

            dgvHouse.Columns["NameAbn"].Width = 150;
            dgvHouse.Columns["NameAbn"].HeaderText = "Потребитель";
            dgvHouse.Columns["NameAbn"].ValueType = typeof(string);
            dgvHouse.Columns["NameAbn"].DefaultCellStyle = StringStyle;
            dgvHouse.Columns["NameAbn"].DataPropertyName = "NameAbn";

            dgvHouse.Columns["NameObj"].Width = 250;
            dgvHouse.Columns["NameObj"].HeaderText = "Объект";
            dgvHouse.Columns["NameObj"].ValueType = typeof(string);
            dgvHouse.Columns["NameObj"].DefaultCellStyle = StringStyle;
            dgvHouse.Columns["NameObj"].DataPropertyName = "NameObj";
            dgvHouse.Columns["NameObj"].Frozen = true;

            dgvHouse.Columns["TotalQuantity"].Width = 70;
            dgvHouse.Columns["TotalQuantity"].HeaderText = "Всего";
            dgvHouse.Columns["TotalQuantity"].ValueType = typeof(int);
            dgvHouse.Columns["TotalQuantity"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["TotalQuantity"].DataPropertyName = "TotalQuantity";
            dgvHouse.Columns["TotalQuantity"].Visible = true;

            dgvHouse.Columns["AverageQuantity"].Width = 70;
            dgvHouse.Columns["AverageQuantity"].HeaderText = "Среднее";
            dgvHouse.Columns["AverageQuantity"].ValueType = typeof(int);
            dgvHouse.Columns["AverageQuantity"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["AverageQuantity"].DataPropertyName = "AverageQuantity";
            dgvHouse.Columns["AverageQuantity"].Visible = true;

            dgvHouse.Columns["idObjParent"].Width = 0;
            dgvHouse.Columns["idObjParent"].HeaderText = "";
            dgvHouse.Columns["idObjParent"].ValueType = typeof(int);
            dgvHouse.Columns["idObjParent"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["idObjParent"].DataPropertyName = "idObjParent";
            dgvHouse.Columns["idObjParent"].Visible = false;

            dgvHouse.Columns["idStatus"].Width = 0;
            dgvHouse.Columns["idStatus"].HeaderText = "";
            dgvHouse.Columns["idStatus"].ValueType = typeof(int);
            dgvHouse.Columns["idStatus"].DefaultCellStyle = IntStyle;
            dgvHouse.Columns["idStatus"].DataPropertyName = "idStatus";
            dgvHouse.Columns["idStatus"].Visible = false;

            #endregion


            this.Cursor = Cursors.Default;


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.dgvHouse.ExportToExcel();
        }
    }
}
