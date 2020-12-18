using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prv.Forms.Reports
{
    public partial class FormActs : FormLbr.FormBase
    {
        #region переменные
        private bool isNoKo;
        private bool isDetail;
        private bool isOpl;
        private bool isControler;
        private bool isDateAct;
        private DateTime dateCheck;
        private string where;
        #endregion

        private class ItemChecked
        {
            public string Name { get; set; }
            public int    Id   { get; set; }

            public ItemChecked()
            {
            }

            public ItemChecked(string name, int id)
            {
                Name = name;
                Id = id;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        #region FormActs Avents
        public FormActs()
        {
            InitializeComponent();

            dateTimePickerBeg.Value = DateTime.Now.Date;
            dateTimePickerEnd.Value = DateTime.Now.Date;
            dateTimePickerInit.Value =DateTime.Now.Date;
        }

        private void FormActs_Load(object sender, EventArgs e)
        {
            InitCheckDate();
            LoadDirectory();
        }
        private void InitCheckDate()
        {
            for (int i = System.DateTime.Now.Year; i >= 1950; i--)
                comboBoxYearCheck.Items.Add(i);
            comboBoxYearCheck.SelectedItem = System.DateTime.Now.Year - 16;

            switch (System.DateTime.Now.Month)
            {
                case 1:
                case 2:
                case 3: comboBoxKvartalCheck.SelectedIndex = 0; break;
                case 4:
                case 5:
                case 6: comboBoxKvartalCheck.SelectedIndex = 1; break;
                case 7:
                case 8:
                case 9: comboBoxKvartalCheck.SelectedIndex = 2; break;
                case 10:
                case 11:
                case 12: comboBoxKvartalCheck.SelectedIndex = 3; break;
            }
        }
        #endregion

        #region LoadData
        #region Справочники
        // Загрузка справочников
        private void LoadDirectory()
        {
            this.SelectSqlData(dsDirectory, dsDirectory.vWorkerGroup, true, " where idGroup = " + Constants.Constants.WorkerGroupControlerBS.ToString() +
                " and DateEnd is null order by FIO");
            comboBoxController.SelectedIndex = -1;
            this.SelectSqlDataTableOther(dsDirectory, dsDirectory.vWorkerGroupOp, "vWorkerGroup", true, " where idGroup = " + Constants.Constants.WorkerGroupOperatorBS.ToString() +
                " and DateEnd is null order by FIO");
            comboBoxUsers.SelectedIndex = -1;

            LoadPunkts();

            LoadRaions();

            LoadTypeObj();

            // справочник счетчиков
            DataTable dt = new DataTable("tR_MarkMeter");
            dt.Columns.Add("id", typeof(int));
            dt.Columns.Add("name", typeof(string));
            this.SelectSqlData(dt, true, " where deleted = 0 order by name, digit");
            cmbMarkMeter.DataSource = dt;
            cmbMarkMeter.DisplayMember = "Name";
            cmbMarkMeter.ValueMember = "Id";
            cmbMarkMeter.SelectedIndex = -1;

            // справочник статусов
            DataTable dtStatus = new DataTable("tR_Classifier");
            dtStatus.Columns.Add("id", typeof(int));
            dtStatus.Columns.Add("name", typeof(string));
            this.SelectSqlData(dtStatus, true, " where ParentId = 289 ");
            cmbStatus.DataSource = dtStatus;
            cmbStatus.DisplayMember = "Name";
            cmbStatus.ValueMember = "Id";
            //cmbMarkMeter.SelectedIndex = -1;

            cmbStatus.Visible = false;
        }
        // Формирование дерева
        private void LoadPunkts()
        {
            #region treeViewPunkts
            this.SelectSqlData(dsDirectory, dsDirectory.tR_KladrObj, true);
            LoadTreePunkts();
            #endregion
        }

        #region LoadTreePunkts
        private void LoadTreePunkts(TreeNode selNode = null)
        {
            treeViewPunkts.Nodes.Clear();

            string delete = " and deleted = false";
            foreach (DataRow dr in dsDirectory.tR_KladrObj.Select("ParentId is NULL" + delete, "name"))
            {   // Родительские группы
                TreeNode root = new TreeNode(dr["Name"].ToString() + " " + dr["Socr"].ToString());  // наименование
                root.Checked = true;
                root.Tag = dr["Id"];                                  // primary key
                treeViewPunkts.Nodes.Add(root);


                LoadTreePunktsNodes(root, selNode);                         // Формаирование дочерних элементов
                if ((selNode != null) && (Convert.ToInt32(selNode.Tag) == Convert.ToInt32(root.Tag)))
                {   // Выделенная ветвь
                    treeViewPunkts.SelectedNode = root;
                    treeViewPunkts.SelectedNode.Expand();
                }
            }
            treeViewPunkts.Nodes[0].Expand(); // развернуть первый уровень
        }
        // Формирование в дереве дочерних элементов
        private void LoadTreePunktsNodes(TreeNode root, TreeNode selNode)
        {
            string delete = " and Deleted = false";   // брать удаленные?
            foreach (DataRow dr in dsDirectory.tR_KladrObj.Select("ParentId = " + root.Tag.ToString() + delete, "Name ASC"))
            {
                TreeNode node = new TreeNode(dr["Name"].ToString() + " " + dr["Socr"].ToString());    // наименование
                node.Checked = true;
                node.Tag = dr["Id"];                                    // primary key
                root.Nodes.Add(node);

                LoadTreePunktsNodes(node, selNode);   // рекурсия

                if ((selNode != null) && (Convert.ToInt32(selNode.Tag) == Convert.ToInt32(node.Tag)))
                {   // выделяем элемент, если надо
                    treeViewPunkts.SelectedNode = node;
                    treeViewPunkts.SelectedNode.Expand();
                }
            }
        }
        #endregion

        // Загрузка районов
        private void LoadRaions()
        {
            this.SelectSqlData(dsDirectory, dsDirectory.tR_Classifier, true, " where IsGroup = 0 and deleted = 0 " +
                " and ParentKey = ';CityRaion;UlyanovskRaion;' order by name ");
            foreach (DataRow dr in dsDirectory.tR_Classifier.Rows)
            {
                ItemChecked item = new ItemChecked(dr["Name"].ToString(), Convert.ToInt32(dr["Id"]));
                checkedListBoxRaion.Items.Add(item, true);
            }
        }
        // загрузка типов строений
        private void LoadTypeObj()
        {
            this.SelectSqlData(dsDirectory, dsDirectory.tR_Classifier, true, " where IsGroup = 0 and deleted = 0 " +
                " and ParentKey = ';HouseParam;HouseType;' order by name ");
            foreach (DataRow dr in dsDirectory.tR_Classifier.Rows)
            {
                ItemChecked item = new ItemChecked(dr["Name"].ToString(), Convert.ToInt32(dr["Id"]));
                checkedListBoxTypeObj.Items.Add(item, true);
            }

            this.SelectSqlData(dsDirectory, dsDirectory.tR_Classifier, true, " where IsGroup = 0 and deleted = 0 " +
                " and ParentKey = ';HouseParam;HouseOtherType;' order by name ");
            foreach (DataRow dr in dsDirectory.tR_Classifier.Rows)
            {
                ItemChecked item = new ItemChecked(dr["Name"].ToString(), Convert.ToInt32(dr["Id"]));
                checkedListBoxOtherTypeObj.Items.Add(item, true);
            }
        }
        #endregion
        #endregion

        #region Working with SQL
        // загрузка таблица по НЕТ КО 
        private void LoadTableAkt(BackgroundWorker bw, bool isNoKo, bool isDetail)
        {
            dsRep.RepAct.Clear();
            dsRep.RepActDetail.Clear();
            
            while (!bw.CancellationPending)
            {
                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);
                    
                    string strCmd = "";
                    if (!isDetail)
                        if (isOpl)
                            if (isNoKo) strCmd = "select * from fn_PrvRepNoKoAndOpl(@d_beg, @d_end) ";
                            else strCmd = "select * from fn_PrvRepNoOpl(@d_beg, @d_end) ";
                        else
                            if (isNoKo) strCmd = "select * from fn_PrvRepNoKo(@d_beg, @d_end) ";
                            else strCmd = "select * from fn_PrvRepAct() ";
                    else
                        if (isOpl)
                            if (isNoKo) strCmd = "select * from fn_PrvRepNoKOAndOplDetail(@d_beg, @d_end) ";
                            else strCmd = "select * from fn_PrvRepNoOplDetail(@d_beg, @d_end) ";
                        else
                            if (isNoKo) strCmd = "select * from fn_PrvRepNoKoDetail(@d_beg, @d_end) ";
                            else strCmd = "select * from fn_PrvRepActDetail() ";

                    strCmd += where;//BuildWhereAkt();
                    strCmd += " order by kladrobj, street, house, houseprefix, apartmentint ";
                    SqlCommand sqlCmd = new SqlCommand(strCmd, con.Connection);

                    if ((isNoKo) || (isOpl))
                    {
                        DateTime d_beg = (radioButtonPeriod.Checked) ?
                            dateTimePickerBeg.Value.Date : dateTimePickerInit.Value.Date.AddDays(0 - Convert.ToDouble(numericUpDownDays.Value));
                        DateTime d_end = (radioButtonPeriod.Checked) ?
                            dateTimePickerEnd.Value.Date : dateTimePickerInit.Value.Date;
                        SqlParameter p = new SqlParameter("@d_beg", d_beg.ToString("yyyyMMdd"));
                        sqlCmd.Parameters.Add(p);
                        p = new SqlParameter("@d_end", d_end.ToString("yyyyMMdd"));
                        sqlCmd.Parameters.Add(p);
                    }

                    sqlCmd.CommandTimeout = 0;

                    SqlDataAdapter dAdapt = new SqlDataAdapter(sqlCmd);

                    if (!isDetail)
                    {
                        dAdapt.Fill(dsRep, "RepAct");

                        if (dsRep.RepAct.Rows.Count > 0)
                        {
                            // сохраним акт в журнале
                            // найдем максимальный номер документа
                            int MaxNumber = 0;

                            int dtYear = DateTime.Now.Year;
                            SelectSqlData(dsRep, dsRep.tPrv_JournalAct, true, " where Year(DateAct) = " + dtYear + " order by NumberAct desc");
                            if (dsRep.tPrv_JournalAct.Rows.Count > 0)
                                MaxNumber = (int)dsRep.tPrv_JournalAct.Rows[0]["NumberAct"];
                            MaxNumber = MaxNumber + 1;

                            dsRep.tPrv_JournalAct.Rows.Clear();
                            DataRow dr = dsRep.tPrv_JournalAct.NewRow();
                            dr["NumberAct"] = MaxNumber;
                            dr["DateAct"] = DateTime.Now.Date;
                            dr["AuthorAct"] = Environment.UserName;
                            dr["DateCurrent"] = DateTime.Now;
                            dr["Deleted"] = 0;
                            dsRep.tPrv_JournalAct.Rows.Add(dr);
                            int idJournal = 0;
                            idJournal = InsertSqlDataOneRow(dsRep, dsRep.tPrv_JournalAct);

                            if (idJournal > 0)
                            {
                                dsRep.RepAct.Rows[0].BeginEdit();
                                dsRep.RepAct.Rows[0]["NumberAct"] = MaxNumber;
                                dsRep.RepAct.Rows[0]["DateAct"] = DateTime.Now.Date;
                                dsRep.RepAct.Rows[0].EndEdit();

                                dsRep.tPrv_RepAct.Rows.Clear();
                                int j = 0;
                                for (int k = 0; k < dsRep.RepAct.Rows.Count; k++)
                                {
                                    DataRow rw = dsRep.tPrv_RepAct.NewRow();
                                    rw["CodeAbonent"] = dsRep.RepAct.Rows[k]["CodeAbonent"];
                                    rw["Address"] = dsRep.RepAct.Rows[k]["Address"];
                                    rw["FIO"] = dsRep.RepAct.Rows[k]["FIO"];
                                    rw["ContFIO"] = dsRep.RepAct.Rows[k]["ContFIO"];
                                    rw["CodeController"] = dsRep.RepAct.Rows[k]["CodeController"];
                                    rw["KladrObj"] = dsRep.RepAct.Rows[k]["KladrObj"];
                                    rw["KladrObjID"] = dsRep.RepAct.Rows[k]["KladrObjID"];
                                    rw["Raion"] = dsRep.RepAct.Rows[k]["Raion"];
                                    rw["Street"] = dsRep.RepAct.Rows[k]["Street"];
                                    rw["CodeStreet"] = dsRep.RepAct.Rows[k]["CodeStreet"];
                                    rw["House"] = dsRep.RepAct.Rows[k]["House"];
                                    rw["HousePrefix"] = dsRep.RepAct.Rows[k]["HousePrefix"];
                                    rw["Apartment"] = dsRep.RepAct.Rows[k]["Apartment"];
                                    rw["Mark"] = dsRep.RepAct.Rows[k]["Mark"];
                                    rw["idMark"] = dsRep.RepAct.Rows[k]["idMark"];
                                    rw["Number"] = dsRep.RepAct.Rows[k]["Number"];
                                    rw["CountFloor"] = dsRep.RepAct.Rows[k]["CountFloor"];
                                    rw["CountPorch"] = dsRep.RepAct.Rows[k]["CountPorch"];
                                    rw["CountApartment"] = dsRep.RepAct.Rows[k]["CountApartment"];
                                    rw["TypeObj"] = dsRep.RepAct.Rows[k]["TypeObj"];
                                    rw["OtherTypeObj"] = dsRep.RepAct.Rows[k]["OtherTypeObj"];
                                    rw["idReason"] = dsRep.RepAct.Rows[k]["idReason"];
                                    rw["idJournal"] = idJournal;

                                    dsRep.tPrv_RepAct.Rows.Add(rw);
                                    dsRep.tPrv_RepAct.Rows[j++].EndEdit();
                                }
                                if (dsRep.tPrv_RepAct.Rows.Count > 0)
                                    InsertSqlData(dsRep, dsRep.tPrv_RepAct);
                            }
                            else
                                MessageBox.Show("Не удалось записать документ ..");
                        }
                        

                    }
                    else
                        dAdapt.Fill(dsRep, "RepActDetail");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    con.CloseConnection();
                }
                break;
            }
        }
        // загрузка таблицы по пройденныи КО 
        private void LoadTableKO(BackgroundWorker bw, bool isDateAct)
        {
            while (!bw.CancellationPending)
            {
                dsRep.RepActKO.Clear();


                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    if (isDateAct)
                        if (isControler)
                            strCmd = "select * from fn_PrvRepKoDateAct(@d_beg, @d_end, 1) ";
                        else
                            strCmd = "select * from fn_PrvRepKoDateAct(@d_beg, @d_end, 0) ";
                    else
                        strCmd = "select * from fn_PrvRepKoDateIn(@d_beg, @d_end) ";

                    strCmd += BuildWhereKO();
                    strCmd += " order by Address";
                    SqlCommand cmd = new SqlCommand(strCmd, con.Connection);

                    DateTime d_beg = (radioButtonPeriod.Checked) ?
                        dateTimePickerBeg.Value.Date : dateTimePickerInit.Value.Date.AddDays(0 - Convert.ToDouble(numericUpDownDays.Value));
                    DateTime d_end = (radioButtonPeriod.Checked) ?
                        dateTimePickerEnd.Value.Date : dateTimePickerInit.Value.Date;
                    SqlParameter p = new SqlParameter("@d_beg", d_beg.ToString("yyyyMMdd"));
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@d_end", d_end.ToString("yyyyMMdd"));
                    cmd.Parameters.Add(p);

                    cmd.CommandTimeout = 0;

                    SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);

                    dAdapt.Fill(dsRep, "RepActKO");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    con.CloseConnection();
                }

                break;
            }
        }
        // загрузка таблицы по госповерке
        private void LoadTableCheckDate(BackgroundWorker bw)
        {
            while (!bw.CancellationPending)
            {
                dsRep.RepDateCheck.Clear();

                DataSql.SqlDataConnect con = new DataSql.SqlDataConnect();
                try
                {
                    con.OpenConnection(SqlSettings);

                    string strCmd = "";
                    if (radioButtonCheckDate.Checked)
                        strCmd = "select * from fn_PrvRepGosDateCheck(@param, @isnull) ";
                    else
                        strCmd = "select * from fn_PrvRepGosDateCheckPeriod(@param, @isnull) ";

                    strCmd += where;
                    strCmd += " order by Address";
                    SqlCommand cmd = new SqlCommand(strCmd, con.Connection);

                    SqlParameter p;
                    if (radioButtonCheckDate.Checked)
                        p = new SqlParameter("@param", dateCheck.ToString("yyyyMMdd"));
                    else
                        p = new SqlParameter("@param", textBoxDay.Text);
                    cmd.Parameters.Add(p);
                    p = new SqlParameter("@isnull", Convert.ToInt32(checkBoxWithNull.Checked));
                    cmd.Parameters.Add(p);
                    cmd.CommandTimeout = 0;

                    SqlDataAdapter dAdapt = new SqlDataAdapter(cmd);

                    dAdapt.Fill(dsRep, "RepDateCheck");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }
                finally
                {
                    con.CloseConnection();
                }

                break;
            }
        }
        #endregion

        #region TabControlPeriod Events
        // Смнеа страничек
        private void tabControlDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlDate.SelectedTab == tabPagePeriod)    // период дат
            {
                buttonNOKO.Visible = true;
                buttonAkt.Visible = true;
                buttonNoOpl.Visible = true;
                buttonNoKoAndOpl.Visible = true;
                buttonKO.Visible = true;
                buttonKOController.Visible = true;
                buttonGosCheck.Visible = false;
            }
            if (tabControlDate.SelectedTab == tabPageDateCheck) // гос поверка
            {
                buttonNOKO.Visible = false;
                buttonAkt.Visible = false;
                buttonNoOpl.Visible = false;
                buttonNoKoAndOpl.Visible = false;
                buttonKO.Visible = false;
                buttonKOController.Visible = false;
                buttonGosCheck.Visible = true;
            }
        }
        // Изменения критерия даты
        private void radioButtonPeriod_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPeriod.Checked)
            {
                dateTimePickerBeg.Enabled = true;
                dateTimePickerEnd.Enabled = true;
                dateTimePickerInit.Enabled = false;
                numericUpDownDays.Enabled = false;
            }
            else
            {
                dateTimePickerBeg.Enabled = false;
                dateTimePickerEnd.Enabled = false;
                dateTimePickerInit.Enabled = true;
                numericUpDownDays.Enabled = true;
            }
        }
        // госповерка
        private void radioButtonCheckDate_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxKvartalCheck.Enabled = (radioButtonCheckDate.Checked) ? true : false;
            comboBoxYearCheck.Enabled = (radioButtonCheckDate.Checked) ? true : false;
            textBoxDay.Enabled = (radioButtonCheckDate.Checked) ? false : true;
        }
        #endregion

        #region TabControlChoice
        #region TabPageAddLS
        private void rbLSOne_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownOneLS.Enabled = (rbLSOne.Checked) ? true : false;
            numericUpDownFirstLS.Enabled = (rbLSOne.Checked) ? false : true;
            numericUpDownLastLS.Enabled = (rbLSOne.Checked) ? false : true;
        }
        // Добавить лицевой счет(а)
        private void buttonAddLS_Click(object sender, EventArgs e)
        {
            string count = (dataGridViewLS.RowCount + 1).ToString();
            string isdel = (checkBoxDelLS.Checked) ? "true" : "false";
            string lsOne = "", lsFirst = "", lsLast = "";
            if (rbLSOne.Checked)
                lsOne = numericUpDownOneLS.Value.ToString();
            else
            {
                if (numericUpDownFirstLS.Value > numericUpDownLastLS.Value)
                {
                    MessageBox.Show("Неверный диапазон");
                    return;
                }
                else
                {
                    lsFirst = numericUpDownFirstLS.Value.ToString();
                    lsLast = numericUpDownLastLS.Value.ToString();
                }
            }

            dataGridViewLS.Rows.Add(count, isdel, lsOne, lsFirst, lsLast);
        }
        // Удалить л/с
        private void buttonDelLS_Click(object sender, EventArgs e)
        {
            if (dataGridViewLS.RowCount > 0)
            {
                dataGridViewLS.Rows.Remove(dataGridViewLS.CurrentRow);
            }
        }
        // ТОЖе добавить л/с
        private void numericUpDownOneLS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonAddLS_Click(sender, e);
                numericUpDownOneLS.ResetText();
            }
        }
        #endregion

        #region tabPageAddController
        // Добавить контроллера (ов)
        private void buttonAddController_Click(object sender, EventArgs e)
        {
            if (comboBoxController.SelectedIndex >= 0)
            {
                string count = (dataGridViewController.RowCount + 1).ToString();
                string isdel = (checkBoxDelController.Checked) ? "true" : "false";
                string controller = comboBoxController.Text.ToString();
                string codeContr = comboBoxController.SelectedValue.ToString();

                dataGridViewController.Rows.Add(count, isdel, controller, codeContr);
            }
        }
        // Удалить контроллера (ов)
        private void buttonDelController_Click(object sender, EventArgs e)
        {
            if (dataGridViewController.RowCount > 0)
            {
                dataGridViewController.Rows.Remove(dataGridViewController.CurrentRow);
            }
        }
        #endregion

        #region tabPageAddUser
        // Добавить Оператора (ов)
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedIndex >= 0)
            {
                string count = (dataGridViewUsers.RowCount + 1).ToString();
                string isdel = (checkBoxDelUser.Checked) ? "true" : "false";
                string operators = comboBoxUsers.Text.ToString();
                string codeOper = comboBoxUsers.SelectedValue.ToString();

                dataGridViewUsers.Rows.Add(count, isdel, operators, codeOper);
            }
        }
        // Удалить Оператора  (ов)
        private void buttonDelUser_Click(object sender, EventArgs e)
        {

            if (dataGridViewUsers.RowCount > 0)
            {
                dataGridViewUsers.Rows.Remove(dataGridViewUsers.CurrentRow);
            }
        }
        #endregion

        #region TabPageAddAddress
        // Выбор начеленного пункта
        private void treeViewPunkts_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.IsSelected && e.Node.Tag != null)
            {
                int id = Convert.ToInt32(e.Node.Tag);
                this.SelectSqlData(dsStreet, dsStreet.Tables["tR_KladrStreet"], true, " where KladrObjId = " +
                    id.ToString() + " order by name, socr");
            }
            else
                dsStreet.Tables["tr_kladrstreet"].Clear();
        }

        private List<TreeNode> GetCheckedNodes(TreeView treeView)
        {
            List<TreeNode> checkedNodes = new List<TreeNode>();
            foreach (TreeNode tn in treeView.Nodes)
                GetNodeRecursive(tn, checkedNodes);

            return checkedNodes;
        }
        private void GetNodeRecursive(TreeNode treeNode, List<TreeNode> checkNode)
        {
            if (treeNode.Checked == true)
               checkNode.Add(treeNode);
            foreach (TreeNode tn in treeNode.Nodes)
                GetNodeRecursive(tn, checkNode);

        }
        // Один дом
        private void rbHousesOne_CheckedChanged(object sender, EventArgs e)
        {
            txtHousesOne.Enabled = (rbHousesOne.Checked) ? true : false;
        }
        // Диапазон домов
        private void rbHousesRange_CheckedChanged(object sender, EventArgs e)
        {
            txtHousesRange1.Enabled = (rbHousesRange.Checked) ? true : false;
            txtHousesRange2.Enabled = (rbHousesRange.Checked) ? true : false;
        }
        // Одна квартира
        private void rbFlatsOne_CheckedChanged(object sender, EventArgs e)
        {
            txtFlatsOne.Enabled = (rbFlatsOne.Checked) ? true : false;
        }
        // Диапазон квартир
        private void rbFlatsRange_CheckedChanged(object sender, EventArgs e)
        {
            txtFlatsRange1.Enabled = (rbFlatsRange.Checked) ? true : false;
            txtFlatsRange2.Enabled = (rbFlatsRange.Checked) ? true : false;
        }

        // Добавить адрес
        private void buttonAddAdress_Click(object sender, EventArgs e)
        {
            if (comboBoxStreet.SelectedIndex >= 0)
            {
                string count = (dataGridViewAdress.RowCount + 1).ToString();
                string isdel = (checkBoxDelAdress.Checked) ? "true" : "false";
                string street = comboBoxStreet.Text.ToString();
                string codeStreet = comboBoxStreet.SelectedValue.ToString();

                // разбор домов
                string house = "";
                if (rbHousesAll.Checked) house = "Все";
                if (rbHousesOne.Checked) house = txtHousesOne.Text;
                if (rbHousesRange.Checked)
                    house = "с " + txtHousesRange1.Text + " по " + txtHousesRange2.Text;
                if (house == "") return;

                // разбор квартир
                string flat = "";
                if (rbFlatsAll.Checked) flat = "Все";
                if (rbFlatsOne.Checked) flat = txtFlatsOne.Text;
                if (rbFlatsRange.Checked)
                    flat = "с " + txtFlatsRange1.Text + " по " + txtFlatsRange2.Text;
                if (flat == "") return;

                dataGridViewAdress.Rows.Add(count, isdel, street, house, flat, codeStreet);
            }
        }
        // удалить адрес (а)
        private void buttonDelAdress_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdress.RowCount > 0)
            {
                dataGridViewAdress.Rows.Remove(dataGridViewAdress.CurrentRow);
            }
        }
        #endregion

        #region TabPageMark
        // Добавитьб счетчик
        private void buttonAddMarkMeter_Click(object sender, EventArgs e)
        {
            if (cmbMarkMeter.SelectedIndex >= 0)
            {
                string isdel = (checkBoxIsklMark.Checked) ? "true" : "false";
                string mark = cmbMarkMeter.Text.ToString();
                string idMark = cmbMarkMeter.SelectedValue.ToString();

                dgvMark.Rows.Add(mark, isdel, idMark);
            }

        }
        // Удалить счетчик
        private void buttonDelMarkMeter_Click(object sender, EventArgs e)
        {
            if (dgvMark.RowCount > 0)
            {
                dgvMark.Rows.Remove(dgvMark.CurrentRow);
            }
        }
        #endregion

        #region TabPageMapObj
        // Этажность
        private void checkBoxFloor_CheckedChanged(object sender, EventArgs e)
        {
            cmbFloor.Enabled = (checkBoxFloor.Checked) ? true : false;
            numericUpDownFloor.Enabled = (checkBoxFloor.Checked) ? true : false;
        }
        // Подъездность
        private void checkBoxPorch_CheckedChanged(object sender, EventArgs e)
        {
            cmbPorch.Enabled = (checkBoxPorch.Checked) ? true : false;
            numericUpDownPorch.Enabled = (checkBoxPorch.Checked) ? true : false;
        }
        // квартирность
        private void checkBoxApartment_CheckedChanged(object sender, EventArgs e)
        {
            cmbApartment.Enabled = (checkBoxApartment.Checked) ? true : false;
            numericUpDownApartment.Enabled = (checkBoxApartment.Checked) ? true : false;
        }
        #endregion
        #endregion

        #region backgroundworjer NOKO and AKTs
        // работа фонового рефима
        private void backgroundWorkerNoKo_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            LoadTableAkt(bw, isNoKo, isDetail);

            if (bw.CancellationPending)
                e.Cancel = true;
        }
        // завершение работы фонового режима
        private void backgroundWorkerNoKo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {   // если не отмена
                FormRepNoKo rep = new FormRepNoKo(dsRep, isDetail);
                rep.SqlSettings = this.SqlSettings;
                rep.MdiParent = this.ParentForm;
                rep.Show();
            }
            else
            {
                MessageBox.Show("Отменено пользователем");
            }
            EnableNoWaitingControls();
            this.Cursor = Cursors.Default;

            if (!isOpl)
                if (isNoKo)
                    buttonNOKO.Text = "Нет контрольных обходов";
                else
                    buttonAkt.Text = "Акт";
            else
                if (isNoKo)
                    buttonNoKoAndOpl.Text = "Нет оплаты и КО";
                else
                    buttonNoOpl.Text = "Нет оплаты";
        }
        #endregion

        #region Buttons NOKO and AKTS
        // Нет контрольных обходов
        private void buttonNOKO_Click(object sender, EventArgs e)
        {
            if (buttonNOKO.Text == "Отмена")  // Если Отмена
            {
                buttonNOKO.Text = "Отмена...";
                backgroundWorkerNoKo.CancelAsync();
            }
            if (buttonNOKO.Text == "Нет контрольных обходов")
            {
                DisableNoWaitingControls(buttonNOKO);
                this.Cursor = Cursors.AppStarting;
                isNoKo = true;
                isDetail = (radioButtonReportSmall.Checked) ? false : true;
                isOpl = false;
                where = BuildWhereAkt();
                backgroundWorkerNoKo.RunWorkerAsync();
                buttonNOKO.Text = "Отмена";
            }
        }
        // Акт обследований
        private void buttonAkt_Click(object sender, EventArgs e)
        {
            if (buttonAkt.Text == "Отмена")  // Если Отмена
            {
                buttonAkt.Text = "Отмена...";
                backgroundWorkerNoKo.CancelAsync();
            }
            if (buttonAkt.Text == "Акт")
            {
                DisableNoWaitingControls(buttonAkt);
                this.Cursor = Cursors.AppStarting;
                isNoKo = false;
                isDetail = (radioButtonReportSmall.Checked) ? false : true;
                isOpl = false;
                where = BuildWhereAkt();
                backgroundWorkerNoKo.RunWorkerAsync();
                buttonAkt.Text = "Отмена";
            }
        }
        // Нет оплаты
        private void buttonNoOpl_Click(object sender, EventArgs e)
        {
            if (buttonNoOpl.Text == "Отмена")  // Если Отмена
            {
                buttonNoOpl.Text = "Отмена...";
                backgroundWorkerNoKo.CancelAsync();
            }
            if (buttonNoOpl.Text == "Нет оплаты")
            {
                DisableNoWaitingControls(buttonNoOpl);
                this.Cursor = Cursors.AppStarting;
                isNoKo = false;
                isDetail = (radioButtonReportSmall.Checked) ? false : true;
                isOpl = true;
                where = BuildWhereAkt();
                backgroundWorkerNoKo.RunWorkerAsync();
                buttonNoOpl.Text = "Отмена";
            }
        }
        // Нет оплаты и КО
        private void buttonNoKoAndOpl_Click(object sender, EventArgs e)
        {
            if (buttonNoKoAndOpl.Text == "Отмена")  // Если Отмена
            {
                buttonNoKoAndOpl.Text = "Отмена...";
                backgroundWorkerNoKo.CancelAsync();
            }
            if (buttonNoKoAndOpl.Text == "Нет оплаты и КО")
            {
                DisableNoWaitingControls(buttonNoKoAndOpl);
                this.Cursor = Cursors.AppStarting;
                isNoKo = true;
                isDetail = (radioButtonReportSmall.Checked) ? false : true;
                isOpl = true;
                where = BuildWhereAkt();
                backgroundWorkerNoKo.RunWorkerAsync();
                buttonNoKoAndOpl.Text = "Отмена";
            }
        }
        #endregion

        #region Buttons KO Opertors and Cntroler
        // Отчет по КО по операторам
        private void buttonKO_Click(object sender, EventArgs e)
        {
            if (buttonKO.Text == "КО по операторам")
            {
                isDetail = (radioButtonReportSmall.Checked) ? false : true;
                isControler = false;
                this.contextMenuStripRepKO.Show(System.Windows.Forms.Cursor.Position);
            }
            else
            {
                if (buttonKO.Text == "Отмена")
                {
                    buttonKO.Text = "Отмена...";
                    backgroundWorkerKO.CancelAsync();
                }
            }
        }
        #region ContxtMenuKO Evetns
        // КО по операторам по дате обследования
        private void toolStripMenuItemMonthPay_Click(object sender, EventArgs e)
        {
            DisableNoWaitingControls(buttonKO);
            buttonKO.Text = "Отмена";
            this.Cursor = Cursors.AppStarting;
            isDateAct= true;
            where = BuildWhereKO();
            backgroundWorkerKO.RunWorkerAsync();
        }
        // КО по операторам по дате разноски
        private void toolStripMenuItemDatePay_Click(object sender, EventArgs e)
        {
            DisableNoWaitingControls(buttonKO);
            buttonKO.Text = "Отмена";
            this.Cursor = Cursors.AppStarting;
            isDateAct = false;
            where = BuildWhereKO();
            backgroundWorkerKO.RunWorkerAsync();
        }
        #endregion
        // КО по контролера
        private void buttonKOController_Click(object sender, EventArgs e)
        {
            if (buttonKOController.Text == "КО по контролерам")
            {
                isControler = true;
                isDetail = (radioButtonReportSmall.Checked) ? false : true;
                DisableNoWaitingControls(buttonKOController);
                buttonKOController.Text = "Отмена";
                this.Cursor = Cursors.AppStarting;
                isDateAct = true;
                where = BuildWhereKO();
                backgroundWorkerKO.RunWorkerAsync();
            }
            else
            {
                if (buttonKOController.Text == "Отмена")
                {
                    buttonKOController.Text = "Отмена...";
                    backgroundWorkerKO.CancelAsync();
                }
            }
        }
        #endregion

        #region backgroundWorkerKO
        // выполнение
        private void backgroundWorkerKO_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            LoadTableKO(bw, isDateAct);

            if (bw.CancellationPending)
                e.Cancel = true;
        }
        // завершение
        private void backgroundWorkerKO_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (!e.Cancelled)
            {   // если не отмена
                DateTime d_beg = (radioButtonPeriod.Checked) ?
                    dateTimePickerBeg.Value.Date : dateTimePickerInit.Value.Date.AddDays(0 - Convert.ToDouble(numericUpDownDays.Value));
                DateTime d_end = (radioButtonPeriod.Checked) ?
                    dateTimePickerEnd.Value.Date : dateTimePickerInit.Value.Date;
                FormRepKO rep = new FormRepKO(dsRep, d_beg, d_end, isDetail);
                rep.MdiParent = this.ParentForm;
                rep.Show();
            }
            else
            {
                MessageBox.Show("Отменено пользователем");
            }
            EnableNoWaitingControls();
            this.Cursor = Cursors.Default;
            buttonKO.Text = "КО по операторам";
            buttonKOController.Text = "КО по контролерам";
        }
        #endregion

        #region Disable/Enable Controls
        // Disable all controls
        private void DisableNoWaitingControls(Control ctrNoDisable)
        {
            foreach (Control ctrlChild in this.Controls)
            {
                if (ctrlChild == ctrNoDisable) continue;
                
                if (ctrlChild == panelButton)
                    foreach (Control ctrlPanel in ctrlChild.Controls )
                    {
                        if (ctrlPanel == ctrNoDisable) continue;

                        if (ctrlPanel != groupBoxWaiting)
                            ctrlPanel.Enabled = false;
                        else
                        {
                            ctrlPanel.Visible = true;
                            progressBarEndLess.AutoProgress = true;
                        }
                    }
                else
                    ctrlChild.Enabled = false;

            }
        }
        // Enable all controls
        private void EnableNoWaitingControls()
        {
            foreach (Control ctrlChild in this.Controls)
            {
                if (ctrlChild == panelButton)
                    foreach (Control ctrlPanel in ctrlChild.Controls)
                    {
                        if (ctrlPanel != groupBoxWaiting)
                            ctrlPanel.Enabled = true;
                        else
                        {
                            progressBarEndLess.AutoProgress = false;
                            ctrlPanel.Visible = false ;
                        }
                    }
                else
                    ctrlChild.Enabled = true;

            }
        }
        #endregion

        #region Формирование условия where
        // Условие по лицевым счетам
        private string BuildWhereLS()
        {
            string whereLS = "";
            string codeAbonent = "";
            string codeAbonentNot = "";
            // проход по всем записям выбранных Л/с
            for (int i = 0; i < dataGridViewLS.RowCount; i++)
            {
                if (dataGridViewLS.Rows[i].Cells["colLS"].Value.ToString() == "")
                {  // если дипазон
                    if (dataGridViewLS.Rows[i].Cells["colDelLS"].Value.ToString() == "true")
                    { // исключить
                        if (codeAbonentNot == "")
                            codeAbonentNot = " (codeabonent not between " +
                                dataGridViewLS.Rows[i].Cells["colFirstLS"].Value.ToString() +
                                " and " + dataGridViewLS.Rows[i].Cells["colLastLS"].Value.ToString() + ") ";
                        else
                            codeAbonentNot += " and (codeabonent not between " +
                                dataGridViewLS.Rows[i].Cells["colFirstLS"].Value.ToString() +
                                " and " + dataGridViewLS.Rows[i].Cells["colLastLS"].Value.ToString() + ") ";
                    }
                    else
                    {	// включить
                        if (codeAbonent == "")
                            codeAbonent = "(codeabonent between " +
                                dataGridViewLS.Rows[i].Cells["colFirstLS"].Value.ToString() +
                                " and " + dataGridViewLS.Rows[i].Cells["colLastLS"].Value.ToString() + ") ";
                        else
                            codeAbonent += " or (codeabonent between " +
                                dataGridViewLS.Rows[i].Cells["colFirstLS"].Value.ToString() +
                                " and " + dataGridViewLS.Rows[i].Cells["colLastLS"].Value.ToString() + ") ";
                    }
                }
                else// один абонент
                {
                    if (dataGridViewLS.Rows[i].Cells["colDelLS"].Value.ToString() == "true")
                    {
                        if (codeAbonentNot == "")
                            codeAbonentNot = " (codeabonent <> " +
                                dataGridViewLS.Rows[i].Cells["colLS"].Value.ToString() + ") ";
                        else
                            codeAbonentNot += " and (codeabonent <> " +
                                dataGridViewLS.Rows[i].Cells["colLS"].Value.ToString() + ") ";
                    }
                    else
                    {
                        if (codeAbonent == "")
                            codeAbonent = " (codeabonent = " +
                                dataGridViewLS.Rows[i].Cells["colLS"].Value.ToString() + ") ";
                        else
                            codeAbonent += " or (codeabonent = " +
                                dataGridViewLS.Rows[i].Cells["colLS"].Value.ToString() + ") ";
                    }
                }
            }

            if (codeAbonent != "")
                whereLS = " (" + codeAbonent + ") ";
            if (codeAbonentNot != "")
                if (whereLS == "")
                    whereLS = " (" + codeAbonentNot + ") ";
                else
                    whereLS = " (" + whereLS + " and (" + codeAbonentNot + ")) ";
            //Исключить "Нет допуска"
            if (cbNotLive.CheckState == CheckState.Checked)
                if (whereLS == "") whereLS = whereLS + " (idReason != 740 or idReason is null) ";
                    else whereLS = whereLS + "  and (idReason != 740 or idReason is null) ";
            if (cbAddStatus.CheckState == CheckState.Checked)
                if (whereLS == "") whereLS = whereLS + " (idReason = + " + cmbStatus.SelectedValue.ToString() + ") ";
                else whereLS = whereLS + "  and (idReason = + " + cmbStatus.SelectedValue.ToString() + ") ";

            return whereLS;
        }
        // Уловие по адресам
        private string BuildWhereAdress()
        {
            // АДРЕСА!!!!!!!!!!!!!!!!
            string whereAdress = "";
            string adress = "";
            string adressNot = "";
            if (dataGridViewAdress.RowCount > 0)
            {
                for (int i = 0; i < dataGridViewAdress.RowCount; i++)
                {
                    string codeStreet = dataGridViewAdress.Rows[i].Cells["colHousesCodeStreet"].Value.ToString();
                    string house = dataGridViewAdress.Rows[i].Cells["colHousesDom"].Value.ToString();
                    string flat = dataGridViewAdress.Rows[i].Cells["colHousesFlat"].Value.ToString();
                    if (dataGridViewAdress.Rows[i].Cells["colHousesDel"].Value.ToString() == "true")
                    {   // ИСКЛЮЧИТЬ
                        #region Все квартиры
                        if (flat == "Все")
                        {   //ВСЕ квартиры
                            if (house == "Все")  // все дома
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + ") ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + ") ";
                            if ((house.Substring(0, 1) != "с") && (house != "Все")) // один дом
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house + "') ";
                            if (house.Substring(0, 1) == "с") // диапазон
                            {   // строка House имеет вид "с 999 по 999"
                                int ind = house.IndexOf(" по ");
                                string h1 = house.Substring(2, ind - 1);
                                string h2 = house.Substring(ind + 4);
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "') ";
                            }
                        }
                        #endregion
                        #region Одна квартира
                        if ((flat.Substring(0, 1) != "с") && (flat != "Все")) //одна квартира
                        {
                            if (house == "Все")  // все дома
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and apartment = '" + flat + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and apartment = '" + flat + "') ";
                            if ((house.Substring(0, 1) != "с") && (house != "Все")) // один дом
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment = '" + flat + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment = '" + flat + "') ";
                            if (house.Substring(0, 1) == "с") // диапазон
                            {   // строка House имеет вид "с 999 по 999"
                                int ind = house.IndexOf(" по ");
                                string h1 = house.Substring(2, ind - 1);
                                string h2 = house.Substring(ind + 4);
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment = '" + flat + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment = '" + flat + "') ";
                            }
                        }
                        #endregion
                        #region Диапазон квартир
                        if (flat.Substring(0, 1) == "с") //диапазон квартир
                        {
                            int indflat = flat.IndexOf(" по ");
                            string f1 = flat.Substring(2, indflat - 1);
                            string f2 = flat.Substring(indflat + 4);
                            if (house == "Все")  // все дома
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                            if ((house.Substring(0, 1) != "с") && (house != "Все")) // один дом
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment >= '" + f1 + "' and apartment <= '" + f2 + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment >= '" + f1 + "' and apartment <= '" + f2 + "') ";
                            if (house.Substring(0, 1) == "с") // диапазон
                            {   // строка House имеет вид "с 999 по 999"
                                int ind = house.IndexOf(" по ");
                                string h1 = house.Substring(2, ind - 1);
                                string h2 = house.Substring(ind + 4);
                                if (adressNot == "")
                                    adressNot = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                                else
                                    adressNot += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                            }
                        }
                        #endregion
                    }
                    else // ВКЛЮЧИТЬ
                    {
                        #region Все квартиры
                        if (flat == "Все")
                        {   //ВСЕ квартиры
                            if (house == "Все")  // все дома
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + ") ";
                                else
                                    adress += " or (codestreet = " + codeStreet + ") ";
                            if ((house.Substring(0, 1) != "с") && (house != "Все")) // один дом
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house + "') ";
                            if (house.Substring(0, 1) == "с") // диапазон
                            {   // строка House имеет вид "с 999 по 999"
                                int ind = house.IndexOf(" по ");
                                string h1 = house.Substring(2, ind - 1);
                                string h2 = house.Substring(ind + 4);
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "') ";
                            }
                        }
                        #endregion
                        #region Одна квартира
                        if ((flat.Substring(0, 1) != "с") && (flat != "Все")) //одна квартира
                        {
                            if (house == "Все")  // все дома
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and apartment = '" + flat + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and apartment = '" + flat + "') ";
                            if ((house.Substring(0, 1) != "с") && (house != "Все")) // один дом
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment = '" + flat + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment = '" + flat + "') ";
                            if (house.Substring(0, 1) == "с") // диапазон
                            {   // строка House имеет вид "с 999 по 999"
                                int ind = house.IndexOf(" по ");
                                string h1 = house.Substring(2, ind - 1);
                                string h2 = house.Substring(ind + 4);
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment = '" + flat + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment = '" + flat + "') ";
                            }
                        }
                        #endregion
                        #region диапазон кваритр
                        if (flat.Substring(0, 1) == "с") //диапазон квартир
                        {
                            int indflat = flat.IndexOf(" по ");
                            string f1 = flat.Substring(2, indflat - 1);
                            string f2 = flat.Substring(indflat + 4);
                            if (house == "Все")  // все дома
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                            if ((house.Substring(0, 1) != "с") && (house != "Все")) // один дом
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment >= '" + f1 + "' and apartment <= '" + f2 + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') = '" + house +
                                        "' and apartment >= '" + f1 + "' and apartment <= '" + f2 + "') ";
                            if (house.Substring(0, 1) == "с") // диапазон
                            {   // строка House имеет вид "с 999 по 999"
                                int ind = house.IndexOf(" по ");
                                string h1 = house.Substring(2, ind - 1);
                                string h2 = house.Substring(ind + 4);
                                if (adress == "")
                                    adress = " (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                                else
                                    adress += " or (codestreet = " + codeStreet + " and rtrim(ltrim(str(house)))+isnull(houseprefix, '') >= '" +
                                        h1 + "' and rtrim(ltrim(str(house)))+isnull(houseprefix, '') <= '" + h2 + "' and apartment >= '" +
                                        f1 + "' and apartment <= '" + f2 + "') ";
                            }
                        }
                        #endregion
                    }
                }
            }
            else // нет улиц
            {
                List<TreeNode> checkedPunkts = GetCheckedNodes(treeViewPunkts);
                if (checkedPunkts.Count != treeViewPunkts.GetNodeCount(true) && checkedPunkts.Count > 0)
                {
                    foreach (TreeNode node in checkedPunkts)
                        adress += node.Tag + ",";
                    adress = " (kladrObjId in (" + adress.Remove(adress.Length - 1) + ")) ";
                }
            }

            if (adress != "")
                whereAdress = " (" + adress + ") ";
            if (adressNot != "")
                if (whereAdress == "")
                    whereAdress = " (not(" + adressNot + ")) ";
                else
                    whereAdress = " (" + whereAdress + " and (not(" + adressNot + "))) ";

            return whereAdress;
        }
        // Условие по контроллерам
        private string BuildWhereController()
        {
            // КОНТРОЛЛЕРЫ
            string whereController = "";
            string controller = "";
            string controllerNot = "";
            for (int i = 0; i < dataGridViewController.RowCount; i++)
            {
                if (dataGridViewController.Rows[i].Cells["colDelController"].Value.ToString() == "true")
                {
                    if (controllerNot == "")
                        controllerNot = " (CodeController <> " +
                            dataGridViewController.Rows[i].Cells["colCodeController"].Value.ToString() + ") ";
                    else
                        controllerNot += " and (codeController <> " +
                            dataGridViewController.Rows[i].Cells["colCodeController"].Value.ToString() + ") ";
                }
                else
                {
                    if (controller == "")
                        controller = " (CodeController = " +
                            dataGridViewController.Rows[i].Cells["colCodeController"].Value.ToString() + ") ";
                    else
                        controller += " or (codeController = " +
                            dataGridViewController.Rows[i].Cells["colCodeController"].Value.ToString() + ") ";
                }
            }

            if (controller != "")
                whereController = " (" + controller + ") ";
            if (controllerNot != "")
                if (whereController == "")
                    whereController = " (" + controllerNot + ") ";
                else
                    whereController = " (" + whereController + " and (" + controllerNot + ")) ";

            return whereController;
        }
        // Условие по приборам учета
        private string BuildWhereMark()
        {
            // ПРИБОРЫ УЧЕТА
            string whereMark = "";
            string mark = "";
            string markNot = "";
            for (int i = 0; i < dgvMark.RowCount; i++)
            {
                if (dgvMark.Rows[i].Cells["ColumnIsklMark"].Value.ToString() == "true")
                {
                    if (markNot == "")
                        markNot = " (idMark <> " +
                            dgvMark.Rows[i].Cells["ColumnIdMark"].Value.ToString() + ") ";
                    else
                        markNot += " and (idMark <> " +
                            dgvMark.Rows[i].Cells["ColumnIdMark"].Value.ToString() + ") ";
                }
                else
                {
                    if (mark == "")
                        mark = " (idMark = " +
                            dgvMark.Rows[i].Cells["ColumnIdMark"].Value.ToString() + ") ";
                    else
                        mark += " or (idMark = " +
                            dgvMark.Rows[i].Cells["ColumnIdMark"].Value.ToString() + ") ";
                }
            }

            if (mark != "")
                whereMark = " (" + mark + ") ";
            if (markNot != "")
                if (whereMark == "")
                    whereMark = " (" + markNot + ") ";
                else
                    whereMark = " (" + whereMark + " and (" + markNot + ")) ";

            return whereMark;
        }
        // Условие по операторам
        private string BuildWhereUser()
        {
            // ПОЛЬЗОВАТЕЛИ
            string whereUser = "";
            string user = "";
            string userNot = "";
            if (!isControler)
                for (int i = 0; i < dataGridViewUsers.RowCount; i++)
                {
                    if (dataGridViewUsers.Rows[i].Cells["ColDelUser"].Value.ToString() == "true")
                    {
                        if (userNot == "")
                            userNot = " (CodeOwner <> " +
                                dataGridViewUsers.Rows[i].Cells["colCodeUser"].Value.ToString() + ") ";
                        else
                            userNot += " and (codeOwner <> " +
                                dataGridViewUsers.Rows[i].Cells["colCodeUser"].Value.ToString() + ") ";
                    }
                    else
                    {
                        if (user == "")
                            user = " (CodeOwner = " +
                                dataGridViewUsers.Rows[i].Cells["colCodeUser"].Value.ToString() + ") ";
                        else
                            user += " or (codeOwner = " +
                                dataGridViewUsers.Rows[i].Cells["colCodeUser"].Value.ToString() + ") ";
                    }
                }
            else
                for (int i = 0; i < dataGridViewController.RowCount; i++)
                {
                    if (dataGridViewController.Rows[i].Cells["colDelController"].Value.ToString() == "true")
                    {
                        if (userNot == "")
                            userNot = " (CodeOwner <> " +
                               dataGridViewController.Rows[i].Cells["colCodeController"].Value.ToString() + ") ";
                        else
                            userNot += " and (codeOwner <> " +
                                dataGridViewController.Rows[i].Cells["colCodeController"].Value.ToString() + ") ";
                    }
                    else
                    {
                        if (user == "")
                            user = " (CodeOwner = " +
                                dataGridViewController.Rows[i].Cells["colCodeController"].Value.ToString() + ") ";
                        else
                            user += " or (codeOwner = " +
                                dataGridViewController.Rows[i].Cells["colCodeController"].Value.ToString() + ") ";
                    }
                }

            if (user != "")
                whereUser = " (" + user + ") ";
            if (userNot != "")
                if (whereUser == "")
                    whereUser = " (" + userNot + ") ";
                else
                    whereUser = " (" + whereUser + " and (" + userNot + ")) ";

            return whereUser;
        }
        // Условие по районам
        private string BuildWhereArea()
        {
            string whereArea = "";

            if ((checkedListBoxRaion.CheckedItems.Count == checkedListBoxRaion.Items.Count) ||
                (checkedListBoxRaion.CheckedItems.Count <= 0))
                return whereArea;
            else
            {
                foreach (ItemChecked item in checkedListBoxRaion.CheckedItems)
                {
                    whereArea += item.Id + ",";
                }
                whereArea = " (Raion in (" + whereArea.Remove(whereArea.Length - 1) + ")) ";
                return whereArea;
            }

        }
        // Условие по типу строения
        private string BuildWhereTypeObj()
        {
            string whereType = "";

            if ((checkedListBoxTypeObj.CheckedItems.Count != checkedListBoxTypeObj.Items.Count) &&
                (checkedListBoxTypeObj.CheckedItems.Count > 0))
            {
                foreach (ItemChecked item in checkedListBoxTypeObj.CheckedItems)
                {
                    whereType += item.Id + ",";
                }
                whereType = " (typeObj in (" + whereType.Remove(whereType.Length - 1) + ")) ";
            }

            string whereOtherType= "";
            if ((checkedListBoxOtherTypeObj.CheckedItems.Count != checkedListBoxOtherTypeObj.Items.Count) &&
                (checkedListBoxOtherTypeObj.CheckedItems.Count > 0))
            {
                foreach (ItemChecked item in checkedListBoxOtherTypeObj.CheckedItems)
                {
                    whereOtherType += item.Id + ",";
                }
                whereOtherType = " (othertypeObj in (" + whereOtherType.Remove(whereOtherType.Length - 1) + ")) ";
            }

            #region FLOOR
            string wherefloor = "";
            if ((checkBoxFloor.Checked) && (cmbFloor.SelectedIndex >= 0))
            {
                switch (cmbFloor.SelectedIndex)
                {
                    case 0: // больше
                        wherefloor = " (CountFloor > " + numericUpDownFloor.Value.ToString() + ") ";
                        break;
                    case 1: // равно
                        wherefloor = " (CountFloor = " + numericUpDownFloor.Value.ToString() + ") ";
                        break;
                    case 2: // меньше
                        wherefloor = " (CountFloor < " + numericUpDownFloor.Value.ToString() + ") ";
                        break;
                }
            }
            #endregion

            #region Porch
            string wherePorch = "";
            if ((checkBoxPorch.Checked) && (cmbPorch.SelectedIndex >= 0))
            {
                switch (cmbPorch.SelectedIndex)
                {
                    case 0: // больше
                        wherePorch = " (CountPorch > " + numericUpDownPorch.Value.ToString() + ") ";
                        break;
                    case 1: // равно
                        wherePorch = " (CountPorch = " + numericUpDownPorch.Value.ToString() + ") ";
                        break;
                    case 2: // меньше
                        wherePorch = " (CountPorch < " + numericUpDownPorch.Value.ToString() + ") ";
                        break;
                }
            }
            #endregion

            #region Apartment
            string whereApartment = "";
            if ((checkBoxApartment.Checked) && (cmbApartment.SelectedIndex >= 0))
            {
                switch (cmbApartment.SelectedIndex)
                {
                    case 0: // больше
                        whereApartment = " (CountApartment > " + numericUpDownApartment.Value.ToString() + ") ";
                        break;
                    case 1: // равно
                        whereApartment = " (CountApartment = " + numericUpDownApartment.Value.ToString() + ") ";
                        break;
                    case 2: // меньше
                        whereApartment = " (CountApartment < " + numericUpDownApartment.Value.ToString() + ") ";
                        break;
                }
            }
            #endregion

            string where = whereType;
            if (whereOtherType != "")
                if (where == "") where = whereOtherType;
                else where += " and " + whereOtherType;
            
            if (wherefloor != "")
                if (where == "") where = wherefloor;
                else where += " and " + wherefloor;

            if (wherePorch != "")
                if (where == "") where = wherePorch;
                else where += " and " + wherePorch;

            if (whereApartment != "")
                if (where == "") where = whereApartment;
                else where += " and " + whereApartment;

            if (where != "") where = " (" + where + ") ";

            return where;
        }
        // Формирование общего условия для АКТОВ
        private string BuildWhereAkt()
        {
            string where = "";
            // Лицевые счета
            string codeAbonent = BuildWhereLS();
            if (codeAbonent != "")
                where = (where == "") ? " where " + codeAbonent : where + " and " + codeAbonent;
            // Адреса
            string adress = BuildWhereAdress();
            if (adress != "")
                where = (where == "") ? " where " + adress : where + " and " + adress;
            // Контроллеры
            string controller = BuildWhereController();
            if (controller != "")
                where = (where == "") ? " where " + controller : where + " and " + controller;
            // Приборы учета
            string markMeter = BuildWhereMark();
            if (markMeter != "")
                where = (where == "") ? " where " + markMeter : where + " and " + markMeter;
            // Тип строения
            string typeMapObj = BuildWhereTypeObj();
            if (typeMapObj != "")
                where = (where == "") ? " where " + typeMapObj : where + " and " + typeMapObj;
            //// По неживущим
            //if (rbNotLive.Checked) // только неживущие
            //    where = (where == "") ? " where (notlive = 1)" : where + " and (notlive = 1)";
            //// По живущим
            //if (rbLive.Checked) // только живущие
            //    where = (where == "") ? " where (notlive = 0)" : where + " and (notlive = 0)";
            // По району
            string whereArea = BuildWhereArea();
            if (whereArea != "")
                where = (where == "") ? " where " + whereArea : where + " and " + whereArea;

            return where;
        }

        // Формирование общего условия для ПРОЙДЕННЫХ КО
        private string BuildWhereKO()
        {
            string where = "";
            // Лицевые счета
            string codeAbonent = BuildWhereLS();
            if (codeAbonent != "")
                where = (where == "") ? " where " + codeAbonent : where + " and " + codeAbonent;
            // Адреса
            string adress = BuildWhereAdress();
            if (adress != "")
                where = (where == "") ? " where " + adress : where + " and " + adress;
            // Контроллеры
            string user = BuildWhereUser();
            if (user != "")
                where = (where == "") ? " where " + user : where + " and " + user;
            // Приборы учета
            string markMeter = BuildWhereMark();
            if (markMeter != "")
                where = (where == "") ? " where " + markMeter : where + " and " + markMeter;
            // Тип строения
            string typeMapObj = BuildWhereTypeObj();
            if (typeMapObj != "")
                where = (where == "") ? " where " + typeMapObj : where + " and " + typeMapObj;
            // По району
            string whereArea = BuildWhereArea();
            if (whereArea != "")
                where = (where == "") ? " where " + whereArea : where + " and " + whereArea;

            return where;
        }
        #endregion

        #region Button GosCheck
        private void buttonGosCheck_Click(object sender, EventArgs e)
        {
            if (buttonGosCheck.Text == "Отмена")  // Если Отмена
            {
                buttonGosCheck.Text = "Отмена...";
                backgroundWorkerCheckDate.CancelAsync();
            }
            if (buttonGosCheck.Text == "Госповерка")
            {
                DisableNoWaitingControls(buttonGosCheck);
                this.Cursor = Cursors.AppStarting;
                dateCheck = GetGosDate();
                where = BuildWhereAkt();
                backgroundWorkerCheckDate.RunWorkerAsync();
                buttonGosCheck.Text = "Отмена";
            }
        }

        private DateTime GetGosDate()
        {
            DateTime d;
            int month = 0;
            switch (comboBoxKvartalCheck.SelectedIndex)
            {
                case 0: month = 1; break;
                case 1: month = 4; break;
                case 2: month = 7; break;
                case 3: month = 10; break;
            }
            d = new DateTime(Convert.ToInt32(comboBoxYearCheck.SelectedItem), month, 1);
            return d;
        }
        #endregion

        #region backgroundWorkerCheckDate 
        private void backgroundWorkerCheckDate_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;

            LoadTableCheckDate(bw);

            if (bw.CancellationPending)
                e.Cancel = true;
        }

        private void backgroundWorkerCheckDate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                FormRepGosCheck rep = new FormRepGosCheck(dsRep);
                rep.MdiParent = this.ParentForm;
                rep.Show();
            }
            else
            {
                MessageBox.Show("Отменено пользователем");
            }
            this.Cursor = Cursors.Default;
            EnableNoWaitingControls();
            buttonGosCheck.Text = "Госповерка";
        }
        #endregion

        private void buttonAktJournal_Click(object sender, EventArgs e)
        { 

            FormActJournal frm = new FormActJournal();
            frm.SqlSettings = this.SqlSettings;
            frm.Show();
        }

        private void cbAddStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAddStatus.Checked) cmbStatus.Visible = true; else cmbStatus.Visible = false;
        }

    }
}
