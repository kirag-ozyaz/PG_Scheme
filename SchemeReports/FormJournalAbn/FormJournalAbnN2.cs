using ControlsLbr.DataGridViewExcelFilter;
using FormLbr.Classes;
using Legal.Forms;
using Passport.Forms;
using Prv.Forms.Abonent;
using Reference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using WinFormsUI.Docking;

namespace Abonent

{
    /// <summary>
    /// журнал контрагентов (N1)
    /// </summary>
    public partial class FormJournalAbnN2 : DockContentBase
    {
        public FormJournalAbnN2()
        {
            InitializeComponent();
            //this.dgv.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_DataError);
        }
        private void FormJournalAbn_Load(object sender, EventArgs e)
        {
            this.FillControls();
            base.LoadFormConfig(null);
            /********************/
            this.chkVersion2019.Checked = true;
            this.dataColumndeletedAbn.DefaultValue = false;
            this.dataColumnactiveAbn.DefaultValue = true;
            this.dataColumnobjActive.DefaultValue = true;
        }
        private void FormJournalAbn_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
        }
        /// <summary>
        /// заполним контролы данными
        /// </summary>
        private void FillControls()
        {
            this.FillTableClassifier();
            List<DataRow> listKladrObj = new List<DataRow>();
            this.FillTableKladrObj(2, listKladrObj);
            this.FillComboBoxKladrObj(listKladrObj);
            this.chkControls();
        }

        private void FillTableClassifier()
        {
            DataTable dataTable = Tables.TableClassifier();
            string TypeAbn = string.Concat(new string[]
            {
                ((int)Constants.AbnType.PassportPS).ToString(), ",",
                ((int)Constants.AbnType.Mount).ToString(),  ",",
                ((int)Constants.AbnType.Maker).ToString(),  ",",
                ((int)Constants.AbnType.OtherAbn).ToString()
            });
            base.SelectSqlData(dataTable, true, string.Format(" where ParentKey = ';SKUEE;TypeAbn;' and id not in ({0}) and isGroup = 0 and deleted = 0 order by name", TypeAbn), null, false, 0);
            this.chkTypeAbn.Items.Clear();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                this.chkTypeAbn.Items.Add(new TypeAbn(Convert.ToInt32(dataRow["id"]), dataRow["name"].ToString()), true);
            }
        }

        private void FillTableKladrObj(int Id, List<DataRow> listKladrObj)
        {
            DataTable dataTable = Tables.CreateTableKladrObj();
            base.SelectSqlData(dataTable, true, " where id = " + Id.ToString(), null, false, 0);
            if (dataTable.Rows.Count != 0 && (dataTable.Rows[0]["PrimaryKey"] == DBNull.Value || !(dataTable.Rows[0]["PrimaryKey"].ToString() == "Country")))
            {
                if (dataTable.Rows[0]["ParentId"] != DBNull.Value)
                {
                    listKladrObj.Add(dataTable.Rows[0]);
                    this.FillTableKladrObj(Convert.ToInt32(dataTable.Rows[0]["ParentId"]), listKladrObj);
                    return;
                }
            }
        }
        /// <summary>
        /// заполнить выпадающие списки объектов кладра (улицы, области, города)
        /// </summary>
        /// <param name="listKladrObj"></param>
		private void FillComboBoxKladrObj(List<DataRow> listKladrObj)
        {
            DataTable dataTable = Tables.CreateTableKladrObj();
            switch (listKladrObj.Count)
            {
                case 0:
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.DisplayMember = "namefull";
                    this.cmbObl.ValueMember = "id";
                    this.cmbObl.DataSource = dataTable;
                    base.SelectSqlData(dataTable, true, " where PrimaryKey = 'Subject' and deleted = 0 order by name, socr", null, false, 0);
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.SelectedIndex = 0;
                    return;
                case 1:
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.DisplayMember = "namefull";
                    this.cmbObl.ValueMember = "id";
                    this.cmbObl.DataSource = dataTable;
                    base.SelectSqlData(dataTable, true, " where ParentId = " + listKladrObj[0]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.SelectedValue = Convert.ToInt32(listKladrObj[0]["Id"]);
                    return;
                case 2:
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.DisplayMember = "namefull";
                    this.cmbObl.ValueMember = "id";
                    this.cmbObl.DataSource = dataTable;
                    base.SelectSqlData(dataTable, true, " where ParentId = " + listKladrObj[1]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
                    this.cmbObl.SelectedIndex = -1;
                    this.cmbObl.SelectedValue = Convert.ToInt32(listKladrObj[1]["Id"]);
                    this.cmbRaionObl.SelectedValue = Convert.ToInt32(listKladrObj[0]["Id"]);
                    return;
            }
            this.cmbObl.SelectedIndex = -1;
            this.cmbObl.DisplayMember = "namefull";
            this.cmbObl.ValueMember = "id";
            this.cmbObl.DataSource = dataTable;
            base.SelectSqlData(dataTable, true, " where ParentId = " + listKladrObj[2]["ParentId"].ToString() + " and deleted = 0 order by name, socr", null, false, 0);
            this.cmbObl.SelectedIndex = -1;
            this.cmbObl.SelectedValue = Convert.ToInt32(listKladrObj[2]["Id"]);
            this.cmbRaionObl.SelectedValue = Convert.ToInt32(listKladrObj[1]["Id"]);
            this.cmbCity.SelectedValue = Convert.ToInt32(listKladrObj[0]["Id"]);
        }

        private void FillTableMarkMeter()
        {
            DataTable dataTable = new DataTable("tR_MarkMeter");
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("name", typeof(string));
            dataTable.Columns.Add("digit", typeof(int));
            dataTable.Columns.Add("phaze", typeof(int));
            dataTable.Columns.Add("voltage", typeof(int));
            dataTable.Columns.Add("precision", typeof(decimal));
            base.SelectSqlData(dataTable, true, " where deleted = 0 order by name, digit", null, false, 0);
            this.cmbPointTypeMeter.DataSource = dataTable;
            this.cmbPointTypeMeter.DisplayMember = "Name";
            this.cmbPointTypeMeter.ValueMember = "Id";
            this.cmbPointTypeMeter.SelectedIndex = -1;
        }
        /// <summary>
        /// отключим контролы
        /// </summary>
		private void chkControls()
        {
            if (!this.chkSchmObjName.Checked && !this.chkSubName.Checked && !this.chkBusName.Checked && !this.chkCellName.Checked)
            {
                DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn = this.subNameDgvColumn;
                this.subNameDgvColumn.Visible = false;
                dataGridViewFilterTextBoxColumn.AllowUserVisibleColumn = false;
                DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn2 = this.busNameDgvColumn;
                this.busNameDgvColumn.Visible = false;
                dataGridViewFilterTextBoxColumn2.AllowUserVisibleColumn = false;
                DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn3 = this.cellNameDgvColumn;
                this.cellNameDgvColumn.Visible = false;
                dataGridViewFilterTextBoxColumn3.AllowUserVisibleColumn = false;
                DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn4 = this.schmObjNameDgvColumn;
                this.schmObjNameDgvColumn.Visible = false;
                dataGridViewFilterTextBoxColumn4.AllowUserVisibleColumn = false;
                DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn5 = this.idSchmObjDgvColumn;
                this.idSchmObjDgvColumn.Visible = false;
                dataGridViewFilterTextBoxColumn5.AllowUserVisibleColumn = false;
            }
            else
            {
                if (this.chkSubName.Checked && !this.subNameDgvColumn.AllowUserVisibleColumn)
                {
                    this.subNameDgvColumn.AllowUserVisibleColumn = true;
                    this.subNameDgvColumn.Visible = true;
                }
                if (this.chkBusName.Checked && !this.busNameDgvColumn.AllowUserVisibleColumn)
                {
                    this.busNameDgvColumn.AllowUserVisibleColumn = true;
                    this.busNameDgvColumn.Visible = true;
                }
                if (this.chkCellName.Checked && !this.cellNameDgvColumn.AllowUserVisibleColumn)
                {
                    this.cellNameDgvColumn.AllowUserVisibleColumn = true;
                    this.cellNameDgvColumn.Visible = true;
                }
                if (this.chkSchmObjName.Checked && !this.schmObjNameDgvColumn.AllowUserVisibleColumn)
                {
                    this.schmObjNameDgvColumn.AllowUserVisibleColumn = true;
                    this.schmObjNameDgvColumn.Visible = true;
                }
            }
            this.pointTypeMeterDgvColumn.AllowUserVisibleColumn = (this.pointTypeMeterDgvColumn.Visible = this.chkPointTypeMeter.Checked);
            this.pointNumberDgvColumn.AllowUserVisibleColumn = (this.pointNumberDgvColumn.Visible = this.chkPointNumber.Checked);
        }
        private void buttonApplyFilter_Click(object sender, EventArgs e)
        {
            this.buttonApplyFilter.Enabled = false;
            this.dgv.Enabled = false;
            this.dgv.DataSource = null;
            this.progressBar.Visible = true;
            this.chkControls();
            this.backgroundWorker.RunWorkerAsync(new object[] { this.createTextQuery(), this.chkVersion2019.Checked });
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.TableFindAbn.Clear();
            if ((bool)((object[])e.Argument)[1])
            {
                this.dataColumnnameAbnObj.ColumnName = "nameObj";
                this.nameAbnObjDgvColumn.DataPropertyName = "nameObj";
                this.dataGridViewFilterTextBoxColumn4.DataPropertyName = "nameObj";
                //
                //KladrObjName
                this.KladrObjNameDgvColumn.DataPropertyName = "City";
                this.dataColumnKladrObjName.ColumnName = "City";
                this.dataGridViewFilterTextBoxColumn5.DataPropertyName = "City";
                //IdSub = subid
                this.dataColumnIdSub.ColumnName = "subid";
                this.dataGridViewFilterTextBoxColumn15.DataPropertyName = "subid";
                this.IdSubDgvColumn.DataPropertyName = "subid";

                Reference.Tables.LoadTableSChmAbnFull_2019(TableFindAbn, this.SqlSettings, DateTime.Now);
                //    
            }
            else
            {
                this.dataColumnnameAbnObj.ColumnName = "nameAbnObj";
                this.nameAbnObjDgvColumn.DataPropertyName = "nameAbnObj";
                this.dataGridViewFilterTextBoxColumn4.DataPropertyName = "nameAbnObj";

                this.KladrObjNameDgvColumn.DataPropertyName = "KladrObjName";
                this.dataColumnKladrObjName.ColumnName = "KladrObjName";
                this.dataGridViewFilterTextBoxColumn5.DataPropertyName = "KladrObjName";

                this.dataColumnIdSub.ColumnName = "IdSub";
                this.dataGridViewFilterTextBoxColumn15.DataPropertyName = "IdSub";
                this.IdSubDgvColumn.DataPropertyName = "IdSub";


                using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                {
                    try
                    {
                        sqlConnection.Open();
                        try
                        {
                            using (SqlCommand sqlCommand = new SqlCommand())
                            {
                                sqlCommand.Connection = sqlConnection;
                                sqlCommand.CommandTimeout = 0;
                                sqlCommand.CommandText = ((object[])e.Argument)[0].ToString();
                                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                                {
                                    sqlDataAdapter.Fill(this.TableFindAbn);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        finally
                        {
                            sqlConnection.Close();
                        }
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show(ex2.Message, ex2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.buttonApplyFilter.Enabled = true;
            this.dgv.Enabled = true;
            this.dgv.DataSource = this.bindingSource;
            this.progressBar.Visible = false;
            base.SaveFormConfig(null);
        }

        private string createTextQuery()
        {
            return string.Concat(new string[]
            {
                "with ActiveObj (idAbnObj,isActive) as   (select  abnObjDog.id,1 from  tAbnDoc_List lst " +
    "                   inner JOIN tAbnDoc_Dogovor dog ON dog.idList = lst.id " +
    "                   inner JOIN tG_Dog_Obj obj ON obj.idDog = dog.id " +
    "                   inner JOIN tAbnObj AS abnobjDog ON abnobjDog.id = obj.idObj " +
    "                   where  lst.deleted = 0 and lst.isActive <> 0 and dog.FlagBreak = 0 and obj.dateEnd is null " +
    "         group by abnObjDog.id) ",
                this.addSelectForWith(),
                " select a.idAbn, a.codeAbonent, a.name as nameAbn, a.typeAbn, a.TypeAbnName, a.deleted as deletedAbn, a.isActive as activeAbn, " +
    "                            a.id as idAbnObj, a.nameObj as nameAbnObj, a.KladrObjName, a.streetname, " +
    "                            cast(a.house as varchar(10)) + isnull(a.houseprefix, '') as house, " +
    "                            case when a.TypeAbn in (207,230,231) then isnull(ActiveObj.isActive, 0) else 1 end as objActive ",
                this.addColumnsForTextSelect(),
                " from vAbnObj a left join ActiveObj on ActiveObj.idAbnObj = a.id ",
                this.createTextLeftJoin()
            }) + " " + this.createTextWhere();
        }

        private string addColumnsForTextSelect()
        {
            string text = "";
            if (this.chkSchmObjName.Checked || this.chkSubName.Checked || this.chkBusName.Checked || this.chkCellName.Checked)
            {
                text += "\r\n,link.idSchmObj ";
                if (this.chkCellName.Checked)
                {
                    text += "\r\n,cell.CellName ";
                }
                if (this.chkBusName.Checked)
                {
                    text += "\r\n,isnull(cell.BusName, bus.busname) as busname ";
                }
                if (this.chkSubName.Checked)
                {
                    text += "\r\n,isnull(cell.subname, isnull(bus.subname, sub.fullname)) as subname ";
                }
                if (this.chkSchmObjName.Checked)
                {
                    text += "\r\n ,isnull(isnull(cell.subname, isnull(bus.subname, sub.fullname)), '')+ " +
                        "                isnull('\\' + isnull(cell.BusName, bus.busname), '')+isnull('\\'+cell.CellName, '') as schmObjName ";
                }
                if (this.chkSchmObjName.Checked || this.chkSubName.Checked)
                {
                    text += "\r\n, isnull(cell.subid, isnull(bus.subid, sub.id)) as IdSub ";
                }
            }
            if (this.chkPointTypeMeter.Checked)
            {
                text += "\r\n,meter.Name as PointTypeMeter";
            }
            if (this.chkPointNumber.Checked)
            {
                text += "\r\n,pReg.Number as PointNumber";
            }
            return text;
        }

        private string addSelectForWith()
        {
            string text = "";
            if (this.chkSchmObjName.Checked || this.chkSubName.Checked || this.chkBusName.Checked || this.chkCellName.Checked)
            {
                text += ", cell (cellId, cellName, busId, busName, subId, subName, deleted) AS " +
                    "    (SELECT  cell.Id, ISNULL(c.SocrName + ' ', '') + cell.Name [Text], " +
                    "                    bus.id,  ISNULL(cBus.SocrName + '-', '') + bus.Name [Text], " +
                    "                    sub.id,  ISNULL(cSub.SocrName + '-', '') + sub.Name [Text], " +
                    "                    case when cell.deleted = 0 and bus.deleted = 0 and sub.deleted = 0 then 0 else 1 end " +
                    "     FROM tSchm_ObjList AS bus " +
                    "        JOIN tR_Classifier AS cBus ON bus.TypeCodeId = cBus.id AND cBus.ParentKey LIKE ';SCM;BUS;%' " +
                    "        JOIN tSchm_ObjList AS point ON bus.id = point.IdParent " +
                    "        JOIN tSchm_Relation AS rel ON point.id = rel.SourceObj or point.id = rel.DestObj " +
                    "        JOIN tSchm_ObjList AS cell ON rel.Edge = cell.id " +
                    "        JOIN tR_Classifier AS c ON cell.TypeCodeId = c.id AND c.ParentKey LIKE ';SCM;Cell;%' " +
                    "        join tschm_objlist as sub on sub.id = bus.idparent " +
                    "        JOIN tR_Classifier AS cSub ON sub.TypeCodeId = cSub.id " +
                    "     WHERE cell.Id != bus.Id AND cell.Deleted = ((0)) AND bus.Deleted = ((0)) AND point.Deleted = ((0))) ";
                if (this.chkSchmObjName.Checked || this.chkSubName.Checked || this.chkBusName.Checked)
                {
                    text += ", bus (Id, busName, subid, subname, deleted) AS " +
                        "  (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name, sub.id, ISNULL(cSub.SocrName + '-', '') + sub.Name, " +
                        "                   case when o.deleted = 0 and sub.deleted = 0 then 0 else 1 end " +
                        "    FROM tSchm_ObjList AS o " +
                        "     JOIN tR_Classifier AS c ON o.TypeCodeId = c.Id " +
                        "     join tSChm_ObjList sub on sub.id = o.idParent " +
                        "     join tR_Classifier AS cSub ON sub.TypeCodeId = cSub.Id " +
                        "    WHERE c.ParentKey LIKE ';SCM;BUS;%' AND o.Deleted = ((0))) " +
                        " ";
                }
                if (this.chkSchmObjName.Checked || this.chkSubName.Checked)
                {
                    text += ", sub (Id, FullName, deleted) AS " +
                        "                                (SELECT o.Id, ISNULL(c.SocrName + '-', '') + o.Name [Text], o.deleted " +
                        "                                 FROM tSchm_ObjList AS o " +
                        "                                    LEFT JOIN tR_Classifier AS c ON o.TypeCodeId = c.id " +
                        "                                 WHERE c.ParentKey LIKE ';SCM;PS;%' AND o.Deleted = ((0))) ";
                }
            }
            return text;
        }

        private string createTextLeftJoin()
        {
            string text = "";
            if (this.chkSchmObjName.Checked || this.chkSubName.Checked || this.chkBusName.Checked || this.chkCellName.Checked)
            {
                text += " left join tl_SchmAbn link on link.idAbnObj = a.id ";
                text += " left join cell on cell.cellid = link.idSchmObj ";
                if (this.chkSchmObjName.Checked || this.chkSubName.Checked || this.chkBusName.Checked)
                {
                    text += " left join bus on bus.id = link.idSChmObj ";
                }
                if (this.chkSchmObjName.Checked || this.chkSubName.Checked)
                {
                    text += " left join sub on sub.id = link.idSChmObj ";
                }
            }
            if (this.cmbPointTypeMeter.SelectedIndex >= 0 || this.chkPointTypeMeter.Checked || !string.IsNullOrEmpty(this.txtPointNumber.Text) || this.chkPointNumber.Checked)
            {
                text += " left join tPoint p on p.idAbnObj = a.id ";
                if (this.rbPointCurrent.Checked)
                {
                    text += " left join tPointReg pReg on pReg.id = (select top 1 id " +
                        "             from tPointReg " +
                        "             where idPoint = p.id and [type] in (245,247,248) " +
                        "             order by datebegin desc) ";
                }
                else
                {
                    text += " left join tPointReg pReg on pReg.idPoint = p.id and pREg.[type] in (245,247,248) ";
                }
                if (this.chkPointTypeMeter.Checked)
                {
                    text += " left join tR_MarkMeter meter on meter.id = pREg.idMark ";
                }
            }
            return text;
        }

        private string createTextWhere()
        {
            string text = "";
            if (!string.IsNullOrEmpty(this.txtCodeAbn.Text))
            {
                text += string.Format(" where (a.codeAbonent = {0}) ", this.txtCodeAbn.Text);
            }
            if (!string.IsNullOrEmpty(this.txtNameAbn.Text))
            {
                string str;
                if (this.chkPrecision.Checked)
                {
                    str = string.Format("(a.name = '{0}') ", this.txtNameAbn.Text);
                }
                else
                {
                    str = string.Format("(a.name like '%{0}%') ", this.txtNameAbn.Text);
                }
                text = this.addWhereText(text, str);
            }
            if (this.chkTypeAbn.CheckedItems.Count > 0)
            {
                List<string> list = new List<string>();
                foreach (object obj in this.chkTypeAbn.CheckedItems)
                {
                    list.Add(((TypeAbn)obj).Id.ToString());
                }
                string string_ = string.Format("(a.TypeAbn in ({0})) ", string.Join(",", list.ToArray()));
                text = this.addWhereText(text, string_);
            }
            if (this.chkActiveAbn.Checked)
            {
                string str = "(a.isActive = 1) ";
                text = this.addWhereText(text, str);
            }
            if (!this.chkShowDelAbn.Checked)
            {
                string str = "(a.deleted = 0) ";
                text = this.addWhereText(text, str);
            }
            if (!string.IsNullOrEmpty(this.txtNameAbnObj.Text))
            {
                string str;
                if (this.chkPrecision.Checked)
                {
                    str = string.Format("(a.nameObj = '{0}') ", this.txtNameAbnObj.Text);
                }
                else
                {
                    str = string.Format("(a.nameObj like '%{0}%') ", this.txtNameAbnObj.Text);
                }
                text = this.addWhereText(text, str);
            }
            if (this.cmbStreet.SelectedIndex < 0)
            {
                if (this.cmbCity.SelectedIndex >= 0)
                {
                    string string_ = string.Format("(a.KladrObjId = {0})", this.cmbCity.SelectedValue);
                    text = this.addWhereText(text, string_);
                }
                else if (this.cmbRaionObl.SelectedIndex >= 0)
                {
                    string str;
                    if (this.GetCountAbnObj(Convert.ToInt32(this.cmbRaionObl.SelectedValue)) > 0)
                    {
                        str = string.Format("(a.KladrObjId = {0})", this.cmbRaionObl.SelectedValue);
                    }
                    else
                    {
                        str = string.Format("(a.KladrObjParent = {0})", this.cmbRaionObl.SelectedValue);
                    }
                    text = this.addWhereText(text, str);
                }
            }
            else
            {
                string string_ = string.Format("(a.idStreet = {0})", this.cmbStreet.SelectedValue);
                text = this.addWhereText(text, string_);
            }
            if (!string.IsNullOrEmpty(this.txtHouse.Text))
            {
                string str = string.Format("(a.house = {0})", this.txtHouse.Text);
                text = this.addWhereText(text, str);
            }
            if (!string.IsNullOrEmpty(this.txtHousePrefix.Text))
            {
                string str;
                if (this.chkPrecision.Checked)
                {
                    str = string.Format("(a.housePrefix = '{0}')", this.txtHousePrefix.Text);
                }
                else
                {
                    str = string.Format("(a.housePrefix like '%{0}%')", this.txtHousePrefix.Text);
                }
                text = this.addWhereText(text, str);
            }
            if (this.chkActiveAbnObj.Checked)
            {
                string str = "(a.TypeAbn not in (207,230,231) or activeObj.isActive = 1) ";
                text = this.addWhereText(text, str);
            }
            if (this.cmbPointTypeMeter.SelectedIndex >= 0)
            {
                string str = string.Format("(pREg.idMark = {0})", this.cmbPointTypeMeter.SelectedValue);
                text = this.addWhereText(text, str);
            }
            if (!string.IsNullOrEmpty(this.txtPointNumber.Text))
            {
                string str;
                if (this.chkPrecision.Checked)
                {
                    str = string.Format("(pReg.Number = '{0}')", this.txtPointNumber.Text);
                }
                else
                {
                    str = string.Format("(pReg.Number like '%{0}%')", this.txtPointNumber.Text);
                }
                text = this.addWhereText(text, str);

            }
            return text;
        }

        private string addWhereText(string strOut, string strAddWhere)
        {
            if (string.IsNullOrEmpty(strOut))
            {
                strOut = " where " + strAddWhere;
            }
            else
            {
                strOut = strOut + "and " + strAddWhere;
            }
            return strOut;
        }

        private int GetCountAbnObj(int idRaion)
        {
            int result = 0;
            int result2;
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
            {
                try
                {
                    sqlConnection.Open();
                    try
                    {
                        using (SqlCommand sqlCommand = new SqlCommand())
                        {
                            sqlCommand.Connection = sqlConnection;
                            sqlCommand.CommandTimeout = 0;
                            sqlCommand.CommandText = "select count(*) from vAbnObj where KladrObjId = " + idRaion.ToString();
                            result = Convert.ToInt32(sqlCommand.ExecuteScalar());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                    return result;
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, ex2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    result2 = 0;
                }
            }
            return result2;
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (Convert.ToBoolean(this.dgv[this.deletedAbnDgvColumn.Name, e.RowIndex].Value))
                {
                    e.CellStyle.BackColor = Color.Red;
                    return;
                }
                int typeAbn = Convert.ToInt32(this.dgv[this.typeAbnDgvColumn.Name, e.RowIndex].Value);
                if (typeAbn == (int)Constants.AbnType.Net) e.CellStyle.ForeColor = Color.Blue;
                else if (typeAbn == (int)Constants.AbnType.Sale) e.CellStyle.ForeColor = Color.Green;
                else if (typeAbn == (int)Constants.AbnType.Legal) e.CellStyle.BackColor = Color.LightGray;

                if (!Convert.ToBoolean(this.dgv[this.activeAbnDgvColumn.Name, e.RowIndex].Value))
                {
                    DataGridViewColumn dataGridViewColumn = this.dgv.Columns[e.ColumnIndex];
                    if (dataGridViewColumn == this.codeAbonentDataGridViewTextBoxColumn || dataGridViewColumn == this.nameAbnDataGridViewTextBoxColumn || dataGridViewColumn == this.typeAbnNameDataGridViewTextBoxColumn)
                    {
                        e.CellStyle.BackColor = Color.LightYellow;
                    }
                }
                if (!Convert.ToBoolean(this.dgv[this.objActiveDgvColumn.Name, e.RowIndex].Value) && this.dgv.Columns[e.ColumnIndex] == this.nameAbnObjDgvColumn)
                {
                    e.CellStyle.BackColor = Color.LightYellow;
                }
            }
        }

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Right && e.Clicks == 1 && this.dgv.CurrentRow != null)
            {
                DataGridViewRow currentRow = this.dgv.CurrentRow;
                this.contextMenuDgv.Show(Cursor.Position);
            }
        }

        private void cmbObl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbObl.SelectedIndex < 0)
            {
                this.cmbRaionObl.DataSource = null;
                return;
            }
            DataTable dataTable = Tables.CreateTableKladrObj();
            this.cmbRaionObl.DisplayMember = "nameFull";
            this.cmbRaionObl.ValueMember = "id";
            this.cmbRaionObl.DataSource = dataTable;
            base.SelectSqlData(dataTable, true, " where ParentId = " + this.cmbObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
            this.cmbRaionObl.SelectedIndex = -1;
        }

        private void cmbRaionObl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbRaionObl.SelectedIndex < 0)
            {
                this.cmbCity.DataSource = null;
                this.cmbStreet.DataSource = null;
                return;
            }
            DataTable dataTable = Tables.CreateTableKladrObj();
            this.cmbCity.DisplayMember = "namefull";
            this.cmbCity.ValueMember = "id";
            this.cmbCity.DataSource = dataTable;
            base.SelectSqlData(dataTable, true, " where ParentId = " + this.cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
            this.cmbCity.SelectedIndex = -1;
            dataTable = Tables.CreateTableKladrKladrStreet();
            this.cmbStreet.SelectedIndex = -1;
            this.cmbStreet.DisplayMember = "namefull";
            this.cmbStreet.ValueMember = "id";
            this.cmbStreet.DataSource = dataTable;
            base.SelectSqlData(dataTable, true, " where KladrObjId = " + this.cmbRaionObl.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
            this.cmbStreet.SelectedIndex = -1;
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbCity.SelectedIndex < 0)
            {
                this.cmbStreet.DataSource = null;
                return;
            }
            DataTable dataTable = Tables.CreateTableKladrKladrStreet();
            this.cmbStreet.SelectedIndex = -1;
            this.cmbStreet.DisplayMember = "namefull";
            this.cmbStreet.ValueMember = "id";
            this.cmbStreet.DataSource = dataTable;
            base.SelectSqlData(dataTable, true, " where KladrObjId = " + this.cmbCity.SelectedValue.ToString() + " and deleted = 0 order by name, socr", null, false, 0);
            this.cmbStreet.SelectedIndex = -1;
        }

        private void contextMenuDgv_Opening(object sender, CancelEventArgs e)
        {
            if (this.dgv.CurrentRow != null)
            {
                if (!Convert.ToBoolean(this.dgv.CurrentRow.Cells[this.deletedAbnDgvColumn.Name].Value))
                {
                    int typeAbn = Convert.ToInt32(this.dgv.CurrentRow.Cells[this.typeAbnDgvColumn.Name].Value);

                    switch (typeAbn)
                    {
                        case (int)Constants.AbnType.Private: this.toolMenuShowAbn.Enabled = true; break;
                        case (int)Constants.AbnType.Legal: this.toolMenuShowAbn.Enabled = true; break;
                        case (int)Constants.AbnType.Sale: this.toolMenuShowAbn.Enabled = true; break;
                        case (int)Constants.AbnType.Net: this.toolMenuShowAbn.Enabled = true; break;
                        case (int)Constants.AbnType.PrivateNoDog: this.toolMenuShowAbn.Enabled = true; break;
                        default:
                            this.toolMenuShowAbn.Enabled = false;
                            break;
                    }
                    //         
                }
                else
                {
                    this.toolMenuShowAbn.Enabled = false;
                }
                //IL_D2:
                if (this.dgv.CurrentRow.Cells[this.idSchmObjDgvColumn.Name].Value == DBNull.Value)
                {
                    this.toolMenuGoToSchemaSchmObj.Enabled = false;
                    this.toolMenuGoToSchemaSchmObj.Tag = null;
                }
                else
                {
                    this.toolMenuGoToSchemaSchmObj.Tag = this.dgv.CurrentRow.Cells[this.idSchmObjDgvColumn.Name].Value;
                    this.toolMenuGoToSchemaSchmObj.Enabled = true;
                }
                if (this.dgv.CurrentRow.Cells[this.IdSubDgvColumn.Name].Value == DBNull.Value)
                {
                    this.toolMenuGoToSchemaSubstation.Enabled = false;
                    this.toolMenuGoToSchemaSubstation.Tag = null;
                    this.toolMenuItemPassportSubstation.Enabled = false;
                    this.toolMenuItemPassportSubstation.Tag = null;
                    return;
                }
                this.toolMenuGoToSchemaSubstation.Tag = this.dgv.CurrentRow.Cells[this.IdSubDgvColumn.Name].Value;
                this.toolMenuGoToSchemaSubstation.Enabled = true;
                this.toolMenuItemPassportSubstation.Tag = this.dgv.CurrentRow.Cells[this.IdSubDgvColumn.Name].Value;
                this.toolMenuItemPassportSubstation.Enabled = true;
            }
        }

        private void toolMenuGoToSchemaSchmObj_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem && ((ToolStripMenuItem)sender).Tag != null)
            {
                this.OnGoToSchema(new GoToSchemaEventArgs(Convert.ToInt32(((ToolStripMenuItem)sender).Tag)));
            }
        }

        private void toolMenuGoToSchemaSubstation_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem && ((ToolStripMenuItem)sender).Tag != null)
            {
                this.OnGoToSchema(new GoToSchemaEventArgs(Convert.ToInt32(((ToolStripMenuItem)sender).Tag)));
            }
        }

        private void toolMenuShowAbn_Click(object sender, EventArgs e)
        {
            int typeAbn = Convert.ToInt32(this.dgv.CurrentRow.Cells[this.typeAbnDgvColumn.Name].Value);

            if (typeAbn == (int)Constants.AbnType.PrivateNoDog || typeAbn == (int)Constants.AbnType.Private)
            {
                FormAbonent formAbonent = new FormAbonent(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.codeAbonentDataGridViewTextBoxColumn.Name].Value), Convert.ToInt32(this.dgv.CurrentRow.Cells[this.typeAbnDgvColumn.Name].Value));
                formAbonent.SqlSettings = this.SqlSettings;
                if (base.DockPanel == null)
                {
                    formAbonent.MdiParent = base.MdiParent;
                }
                else
                {
                    formAbonent.MdiParent = base.DockPanel.FindForm().MdiParent;
                }
                formAbonent.Show();
                //return;
            }
            else if (typeAbn == (int)Constants.AbnType.Sale || typeAbn == (int)Constants.AbnType.Net || typeAbn == (int)Constants.AbnType.Legal)
            {
                FormAbn formAbn = new FormAbn(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.codeAbonentDataGridViewTextBoxColumn.Name].Value), Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idAbnObjDgvColumn.Name].Value));
                formAbn.SqlSettings = this.SqlSettings;
                if (base.DockPanel == null)
                {
                    formAbn.MdiParent = base.MdiParent;
                }
                else
                {
                    formAbn.MdiParent = base.DockPanel.FindForm().MdiParent;
                }
                formAbn.Show();
            }
        }

        private void toolMenuItemPassportSubstation_Click(object sender, EventArgs e)
        {
            FormDockPassport formDockPassport = new FormDockPassport(this.SqlSettings, Convert.ToInt32(((ToolStripMenuItem)sender).Tag));
            if (base.DockPanel == null)
            {
                formDockPassport.MdiParent = base.MdiParent;
                formDockPassport.Show();
                return;
            }
            formDockPassport.Show(base.DockPanel);
        }

        protected override XmlDocument CreateXmlConfig()
        {
            XmlDocument xmlDocument = new XmlDocument();
            XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
            xmlDocument.AppendChild(newChild);
            XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
            xmlDocument.AppendChild(xmlNode);
            XmlNode xmlNodeColumn = xmlDocument.CreateElement("AddColumn");
            xmlNode.AppendChild(xmlNodeColumn);
            if (this.chkSubName.Checked)
            {
                XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("ColSub");
                xmlAttribute.Value = this.chkSubName.Checked.ToString();
                xmlNodeColumn.Attributes.Append(xmlAttribute);
            }
            if (this.chkBusName.Checked)
            {
                XmlAttribute xmlAttribute2 = xmlDocument.CreateAttribute("ColBus");
                xmlAttribute2.Value = this.chkBusName.Checked.ToString();
                xmlNodeColumn.Attributes.Append(xmlAttribute2);
            }
            if (this.chkCellName.Checked)
            {
                XmlAttribute xmlAttribute3 = xmlDocument.CreateAttribute("ColCell");
                xmlAttribute3.Value = this.chkCellName.Checked.ToString();
                xmlNodeColumn.Attributes.Append(xmlAttribute3);
            }
            if (this.chkSchmObjName.Checked)
            {
                XmlAttribute xmlAttribute4 = xmlDocument.CreateAttribute("ColSchmObj");
                xmlAttribute4.Value = this.chkSchmObjName.Checked.ToString();
                xmlNodeColumn.Attributes.Append(xmlAttribute4);
            }
            XmlNode xmlNodeTypeAbn = xmlDocument.CreateElement("TypeAbn");
            xmlNode.AppendChild(xmlNodeTypeAbn);
            foreach (object obj in this.chkTypeAbn.CheckedItems)
            {
                XmlNode xmlNodeRow = xmlDocument.CreateElement("IdKladrObj");
                xmlNodeRow.InnerText = ((TypeAbn)obj).Id.ToString();
                xmlNodeTypeAbn.AppendChild(xmlNodeRow);
            }
            int IdKladrObj;
            if (this.cmbCity.SelectedIndex >= 0)
            {
                IdKladrObj = Convert.ToInt32(this.cmbCity.SelectedValue);
            }
            else if (this.cmbRaionObl.SelectedIndex >= 0)
            {
                IdKladrObj = Convert.ToInt32(this.cmbRaionObl.SelectedValue);
            }
            else
            {
                IdKladrObj = Convert.ToInt32(this.cmbObl.SelectedValue);
            }
            XmlAttribute xmlAttributeIdKladrObj = xmlDocument.CreateAttribute("IdKladrObj");
            xmlAttributeIdKladrObj.Value = IdKladrObj.ToString();
            xmlNode.Attributes.Append(xmlAttributeIdKladrObj);
            return xmlDocument;
        }

        protected override void ApplyConfig(XmlDocument doc)
        {
            new List<int>();
            XmlNode xmlNode = doc.SelectSingleNode(base.Name);
            if (xmlNode == null)
            {
                return;
            }
            XmlNode xmlNodeColumn = xmlNode.SelectSingleNode("AddColumn");
            if (xmlNodeColumn != null)
            {
                XmlAttribute xmlAttribute = xmlNodeColumn.Attributes["ColSub"];
                if (xmlAttribute != null)
                {
                    this.chkSubName.Checked = Convert.ToBoolean(xmlAttribute.Value);
                }
                xmlAttribute = xmlNodeColumn.Attributes["ColBus"];
                if (xmlAttribute != null)
                {
                    this.chkBusName.Checked = Convert.ToBoolean(xmlAttribute.Value);
                }
                xmlAttribute = xmlNodeColumn.Attributes["ColCell"];
                if (xmlAttribute != null)
                {
                    this.chkCellName.Checked = Convert.ToBoolean(xmlAttribute.Value);
                }
                xmlAttribute = xmlNodeColumn.Attributes["ColSchmObj"];
                if (xmlAttribute != null)
                {
                    this.chkSchmObjName.Checked = Convert.ToBoolean(xmlAttribute.Value);
                }
            }
            XmlNode xmlNodeTypeAbn = xmlNode.SelectSingleNode("TypeAbn");
            if (xmlNodeTypeAbn != null)
            {
                List<int> list = new List<int>();
                foreach (object obj in xmlNodeTypeAbn.SelectNodes("row"))
                {
                    XmlNode xmlNode4 = (XmlNode)obj;
                    if (!string.IsNullOrEmpty(xmlNode4.InnerText))
                    {
                        list.Add(Convert.ToInt32(xmlNode4.InnerText));
                    }
                }
                for (int i = 0; i < this.chkTypeAbn.Items.Count; i++)
                {
                    if (list.Contains(((TypeAbn)this.chkTypeAbn.Items[i]).Id))
                    {
                        this.chkTypeAbn.SetItemChecked(i, true);
                    }
                    else
                    {
                        this.chkTypeAbn.SetItemChecked(i, false);
                    }
                }
            }
            XmlAttribute xmlAttributeKladrObj = xmlNode.Attributes["IdKladrObj"];
            if (xmlAttributeKladrObj != null)
            {
                List<DataRow> list_ = new List<DataRow>();
                this.FillTableKladrObj(Convert.ToInt32(xmlAttributeKladrObj.Value), list_);
                this.FillComboBoxKladrObj(list_);
            }
        }

        private void toolBtnFind_Click(object sender, EventArgs e)
        {
            this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.toolTextFind.Text);
        }

        private void toolBtnFindPrev_Click(object sender, EventArgs e)
        {
            this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolTextFind.Text);
        }

        private void toolBtnFindNext_Click(object sender, EventArgs e)
        {
            this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolTextFind.Text);
        }

        private void toolTextFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (e.Modifiers == Keys.None)
                {
                    this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolTextFind.Text);
                }
                if (e.Modifiers == Keys.Shift)
                {
                    this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolTextFind.Text);
                }
            }
        }

        private void tooBtnExportToExcel_Click(object sender, EventArgs e)
        {
            this.dgv.ExportToExcel();
        }

        private void tabControlFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlFilter.SelectedTab == this.tabPageFilterAdd && this.cmbPointTypeMeter.Items.Count == 0)
            {
                this.FillTableMarkMeter();
            }
        }

        private void cmbPointTypeMeter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbPointTypeMeter.SelectedIndex < 0)
            {
                this.chkPointTypeMeter.Checked = false;
                return;
            }
            this.chkPointTypeMeter.Checked = true;
        }

        private void txtPointNumber_TextChanged(object sender, EventArgs e)
        {
            this.chkPointNumber.Checked = !string.IsNullOrEmpty(this.txtPointNumber.Text);
        }

        private void dgv_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }
    }
}
