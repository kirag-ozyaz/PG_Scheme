
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
using FormLbr;
using FormLbr.Classes;
using RequestForRepair.DataSets;
using RequestsClient.Forms.JournalRequestForRepair;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace RequestForRepair
{

    /// <summary>
    /// Журнал заявок на ремонт оборудования
    /// Журнал по отключениям для службы 05
    /// крайняя версия
    /// </summary>
    public partial class FormJournalRequestForRepair : FormBase
    {
        private bool isLoadRequestsClient;
        private bool isCrash;

        //private const int ODS_DIVISION = 920;
        //private const int PL_DIVISION = 921;
        private int Distance = 400;
        private string sortString = "";

        public FormJournalRequestForRepair()
        {
            this.InitializeComponent();
        }

        public FormJournalRequestForRepair(bool isCrash = false)
        {
            this.InitializeComponent();
            this.isCrash = isCrash;
            if (isCrash)
            {
                this.Text = "Журнал по отключениям для службы 05 (N)";
                //base.Icon = global::RequestForRepair.Properties.Resources.repair_Crash1;
                //this.Icon = ((System.Drawing.Icon)(resources.GetObject("repair_Crash1")));
                this.Icon = (Icon)global::RequestForRepair.Properties.Resources.repair_Crash1;
            }
            else
            {
                this.Text = "Журнал заявок на ремонт оборудования (N)";
                // this.Icon = ((System.Drawing.Icon)(resources.GetObject("repair")));
                this.Icon = (Icon)global::RequestForRepair.Properties.Resources.repair;
            }
        }

        private void backgroundWorkerLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            string str = "'" + this.dateTimePickerBeg.Value.Date.ToString("yyyyMMdd") + "'";
            string str2 = "'" + this.dateTimePickerEnd.Value.ToString("yyyyMMdd HH:mm:ss") + "'";
            string[] textArray1 = new string[] { " ((dateBeg <= ", str2, " and dateEnd >= ", str, "))" };
            string str3 = string.Concat(textArray1);
            str3 = string.Format(" (id in (select idRequest from tj_requestForRepairDaily where {0})) ", str3);
            string str4 = " and (crash = 0 or crash is null) ";
            if (this.isCrash)
            {
                str4 = " and (crash = 1) ";
            }
            string str5 = "";
            foreach (object obj2 in this.checkedListBoxDivision.CheckedItems)
            {
                DivisionRequestForRepair struct2 = (DivisionRequestForRepair)obj2;
                str5 = str5 + struct2.id.ToString() + ",";
            }
            if (str5.Length > 0)
            {
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_RequestForRepair, true, " where " + str3 + str4 + " and idDivision in (" + str5.Remove(str5.Length - 1) + ") and deleted = 0 order by datecreate desc");
            }
            else
            {
                this.dataSetGES_0.vJ_RequestForRepair.Clear();
            }
            e.Result = e.Argument;
        }

        private void backgroundWorkerLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.toolStrip.Enabled = true;
            this.splitContainer.Enabled = true;
            this.toolStripProgressBarLoad.Visible = false;
            this.toolStripLabelLoad.Visible = false;
            this.bindingSourceJournalRequestForRepair.DataMember = this.dataSetGES_0.vJ_RequestForRepair.TableName;
            this.bindingSourceJournalRequestForRepair.Sort = this.sortString;
            if ((e.Result != null) && (Convert.ToInt32(e.Result) > 0))
            {
                this.dgv.SearchGrid(this.idDataGridViewTextBoxColumn.Name, e.Result.ToString(), false);
            }
        }

        private void bindingSourceJournalRequestForRepair_CurrentChanged(object sender, EventArgs e)
        {
            // this.dataSetDamage_0.vJ_Damage.Clear();
            this.dataSetGES_0.vJ_Damage.Clear();
            if ((this.bindingSourceJournalRequestForRepair.Current != null) && (this.bindingSourceJournalRequestForRepair.Current is DataRowView))
            {
                int num = Convert.ToInt32(((DataRowView)this.bindingSourceJournalRequestForRepair.Current).Row["id"]);
                try
                {
                    using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(string.Format("with  tree (numRequest, dateDoc, TypeDocName, TYpeDoc, schmObjName, id, isApply)\r\n                                                as (select numRequest, dateDoc, TypeDocName, TypeDoc, schmObjName, id, isApply\r\n\t\t\t\t\t\t\t\t\t\t\t\t   from vj_damage\r\n\t                                                where idReqForRepair = {0}\r\n\t                                                union all \r\n\t                                                select v.numRequest, v.dateDoc, v.TypeDocName, v.typeDoc, v.schmObjName, v.id, v.isApply\r\n\t                                                from vj_damage\tv\r\n\t\t                                                inner join tree on tree.id = v.idParent \r\n\t\t                                            )\r\n                                                    select * from tree", num), connection))
                        {
                            //dataSetDamage_0.EnforceConstraints = false;
                            // new SqlDataAdapter(command).Fill(this.dataSetDamage_0.vJ_Damage);
                            new SqlDataAdapter(command).Fill(this.dataSetGES_0.vJ_Damage);
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ошибка заполнения таблиц: " + exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (this.toolBtnEditRequestRepair.Enabled && this.toolBtnEditRequestRepair.Visible)
                {
                    this.toolBtnEditRequestRepair_Click(sender, e);
                }
                else
                {
                    this.toolBtnReadRequestRepair_Click(sender, e);
                }
            }
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(this.dgv[this.agreedDgvColumn.Name, e.RowIndex].Value))
                {
                    e.CellStyle.BackColor = Color.LightGreen;
                }
                if (Convert.ToInt32(this.dgv[this.iddivisionDataGridViewTextBoxColumn.Name, e.RowIndex].Value) == 0x399)
                {
                    e.CellStyle.BackColor = Color.LightGray;
                }
                if ((this.dgv[this.isSendDgvColumn.Name, e.RowIndex].Value != DBNull.Value) && (this.dgv.Columns[e.ColumnIndex] == this.numDataGridViewTextBoxColumn))
                {
                    if (!Convert.ToBoolean(this.dgv[this.isSendDgvColumn.Name, e.RowIndex].Value))
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.Green;
                    }
                }
                if (this.dgv[this.colorStatusDgvColumn.Name, e.RowIndex].Value != DBNull.Value)
                {
                    try
                    {
                        Color color = Color.FromName(this.dgv[this.colorStatusDgvColumn.Name, e.RowIndex].Value.ToString());
                        e.CellStyle.BackColor = color;
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgv.AutoResizeRow(e.RowIndex);
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerBeg.MaxDate = this.dateTimePickerEnd.Value;
        }

        private void dateTimePickerBeg_ValueChanged(object sender, EventArgs e)
        {
            this.dateTimePickerEnd.MinDate = this.dateTimePickerBeg.Value;
        }


        private void FormJournalRequestForRepair_Load(object sender, EventArgs e)
        {
            this.toolBtnImport.Visible = false;
            this.dateTimePickerBeg.Value = DateTime.Now.Date;
            this.dateTimePickerEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);
            this.LoadRequestsClient();
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tR_Classifier, true, " where ParentKey = ';Other;DivisionRequestRepair;' and isgroup = 0 and deleted = 0 order by name");
            foreach (DataRow row in this.dataSetGES_0.tR_Classifier.Rows)
            {
                ToolStripMenuItem item = new ToolStripMenuItem();
                item.Click += new EventHandler(this.toolSplitBtnAddRequestRepair_Click);
                item.Text = row["SocrName"].ToString();
                item.Tag = row["id"];
                this.toolSplitBtnAddRequestRepair.DropDownItems.Add(item);
                ToolStripMenuItem item2 = new ToolStripMenuItem();
                item2.Click += new EventHandler(this.toolBtnRequestCopy_Click);
                item2.Text = row["SocrName"].ToString();
                item2.Tag = row["id"];
                this.toolBtnRequestCopy.DropDownItems.Add(item2);
                DivisionRequestForRepair divisionRequestForRepair = new DivisionRequestForRepair(Convert.ToInt32(row["Id"]), row["Name"].ToString());
                this.checkedListBoxDivision.Items.Add(divisionRequestForRepair, true);
            }
            this.splitContainerDgvBuild();
            this.LoadData();
        }

        private void lbChildDoc_Click(object sender, EventArgs e)
        {
            if (this.lbChildDoc.Cursor == Cursors.PanNorth)
            {
                this.splitContainerDgv.SplitterDistance = this.Distance;
                this.splitContainerDgv.IsSplitterFixed = false;
                this.lbChildDoc.Cursor = Cursors.PanSouth;
            }
            else if (this.lbChildDoc.Cursor == Cursors.PanSouth)
            {
                this.Distance = this.splitContainerDgv.SplitterDistance;
                this.splitContainerDgv.SplitterDistance = (this.splitContainerDgv.Height - this.splitContainerDgv.SplitterWidth) - this.lbChildDoc.Height;
                this.splitContainerDgv.IsSplitterFixed = true;
                this.lbChildDoc.Cursor = Cursors.PanNorth;
            }
        }

        private void LoadRequestsClient()
        {
            try
            {
                Assembly.Load("RequestsClient");
                this.isLoadRequestsClient = true;
            }
            catch (Exception)
            {
            }
            this.toolBtnSettingsSend.Visible = this.isLoadRequestsClient;
        }

        private void method_1(object sender, EventArgs e)
        {
            // RequestForRepair.FormJournalRequestForRepairAddEdit edit1 = new RequestForRepair.FormJournalRequestForRepairAddEdit(-1, Convert.ToInt32(((ToolStripMenuItem)sender).Tag), eActionRequestRepair.Add, this.isCrash);//0
            FormJournalRequestForRepairAddEdit edit1 = new FormJournalRequestForRepairAddEdit(-1, Convert.ToInt32(((ToolStripMenuItem)sender).Tag), eActionRequestRepair.Add, this.isCrash);//0
            edit1.GoToSchema += (new GoToSchemaEventHandler(this.f_GoToSchema));
            edit1.SqlSettings = (this.SqlSettings);
            edit1.MdiParent = base.MdiParent;
            edit1.FormClosed += new FormClosedEventHandler(this.method_5);
            edit1.Show();
        }

        private void LoadData()
        {
            int argument = -1;
            if (this.dgv.CurrentRow != null)
            {
                argument = Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
            }
            this.toolStrip.Enabled = false;
            this.splitContainer.Enabled = false;
            this.toolStripProgressBarLoad.Visible = true;
            this.toolStripLabelLoad.Visible = true;
            this.sortString = this.bindingSourceJournalRequestForRepair.Sort;
            this.bindingSourceJournalRequestForRepair.Sort = string.Empty;
            this.bindingSourceJournalRequestForRepair.DataMember = null;
            this.backgroundWorkerLoad.RunWorkerAsync(argument);
        }

        private void splitContainerDgvBuild()
        {
            if (this.isCrash)
            {
                this.splitContainerDgv.SplitterDistance = (this.splitContainerDgv.Height - this.splitContainerDgv.SplitterWidth) - this.lbChildDoc.Height;
                this.splitContainerDgv.IsSplitterFixed = true;
            }
            else
            {
                this.splitContainerDgv.Panel2Collapsed = true;
            }
        }


        private void toolSplitBtnAddRequestRepair_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(((ToolStripMenuItem)sender).Tag) == 920) && this.isLoadRequestsClient)
            {
                this.method_1(sender, e);
            }
            else
            {
                //RequestForRepair.FormJournalRequestForRepairAddEdit form1 = new RequestForRepair.FormJournalRequestForRepairAddEdit(-1, Convert.ToInt32(((ToolStripMenuItem)sender).Tag), eActionRequestRepair.Add, this.isCrash);
                // {вызывать старую форму; для 921} - 1(t)
                FormJournalRequestForRepairAddEditPL form1 = new FormJournalRequestForRepairAddEditPL(-1, Convert.ToInt32(((ToolStripMenuItem)sender).Tag), eActionRequestRepair.Add, this.isCrash);
                form1.GoToSchema += (new GoToSchemaEventHandler(this.f_GoToSchema));
                form1.SqlSettings = (this.SqlSettings);
                form1.MdiParent = base.MdiParent;
                form1.FormClosed += new FormClosedEventHandler(this.method_5);
                form1.Show();
            }
        }

        private void f_GoToSchema(object sender, GoToSchemaEventArgs e)
        {
            this.OnGoToSchema(e);
        }

        private void method_4()
        {
            //RequestForRepair.FormJournalRequestForRepairAddEdit edit1 = new RequestForRepair.FormJournalRequestForRepairAddEdit(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Edit, this.isCrash);//1
            FormJournalRequestForRepairAddEdit edit1 = new FormJournalRequestForRepairAddEdit(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Edit, this.isCrash);//1

            edit1.GoToSchema += (new GoToSchemaEventHandler(this.f_GoToSchema));
            edit1.SqlSettings = (this.SqlSettings);
            edit1.MdiParent = base.MdiParent;
            edit1.FormClosed += new FormClosedEventHandler(this.method_5);
            edit1.Show();
        }

        private void method_5(object sender, FormClosedEventArgs e)
        {
            if (((Form)sender).DialogResult == DialogResult.OK)
            {
                this.LoadData();
            }
        }

        private void method_6()
        {
            // RequestForRepair.FormJournalRequestForRepairAddEdit edit1 = new RequestForRepair.FormJournalRequestForRepairAddEdit(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Read, false);//2
            FormJournalRequestForRepairAddEdit edit1 = new FormJournalRequestForRepairAddEdit(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Read, false);//2
            edit1.GoToSchema += (new GoToSchemaEventHandler(this.f_GoToSchema));
            edit1.SqlSettings = (this.SqlSettings);
            edit1.MdiParent = base.MdiParent;
            edit1.Show();
        }

        private void toolBtnRequestCopy_Click(object sender, EventArgs e)
        {
            if ((this.dgv.CurrentRow != null) && (((ToolStripMenuItem)sender).Tag != null))
            {
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepair, true, " where id = " + this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value.ToString());
                if (this.dataSetGES_0.tJ_RequestForRepair.Rows.Count > 0)
                {
                    DataRow row = this.dataSetGES_0.tJ_RequestForRepair.NewRow();
                    row.ItemArray = this.dataSetGES_0.tJ_RequestForRepair.Rows[0].ItemArray;
                    row["idDivision"] = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
                    row["Agreed"] = false;
                    if ((Convert.ToInt32(((ToolStripMenuItem)sender).Tag) == 920) && this.isLoadRequestsClient)
                    {
                        this.method_8(row);
                    }
                    else
                    {
                        // RequestForRepair.FormJournalRequestForRepairAddEdit form1 = new RequestForRepair.FormJournalRequestForRepairAddEdit(row);
                        // {вызывать старую форму; для 921} - 2(p)
                        FormJournalRequestForRepairAddEditPL form1 = new FormJournalRequestForRepairAddEditPL(row);
                        form1.GoToSchema += (new GoToSchemaEventHandler(this.f_GoToSchema));
                        form1.SqlSettings = (this.SqlSettings);
                        form1.MdiParent = base.MdiParent;
                        form1.FormClosed += new FormClosedEventHandler(this.method_5);
                        form1.Show();
                    }
                }
            }
        }

        private void method_8(DataRow dataRow_0)
        {
            // RequestForRepair.FormJournalRequestForRepairAddEdit edit1 = new RequestForRepair.FormJournalRequestForRepairAddEdit(dataRow_0);
            FormJournalRequestForRepairAddEdit edit1 = new FormJournalRequestForRepairAddEdit(dataRow_0);
            edit1.GoToSchema += (new GoToSchemaEventHandler(this.f_GoToSchema));
            edit1.SqlSettings = (this.SqlSettings);
            edit1.MdiParent = base.MdiParent;
            edit1.FormClosed += new FormClosedEventHandler(this.method_5);
            edit1.Show();
        }

        private void importOldZayavki(int idDivision)
        {
            SQLSettings settings;
            if (idDivision == 920)
            {
                settings = new SQLSettings("ulges-sql", "zayavki_ODS", "WINDOWS", "", "");
            }
            else
            {
                settings = new SQLSettings("ulges-sql", "zayavki_PL", "WINDOWS", "", "");
            }
            SqlDataCommand command1 = new SqlDataCommand(settings);
            //int? nullable = null;
            DataTable table = command1.SelectSqlData("DH55388", false, "", null);
            //nullable = null;
            DataTable table2 = command1.SelectSqlData("_1SJOURN", false, "", null);
            DataTable table3 = command1.SelectSqlData("SC55410", false, "", null);
            DataTable table4 = base.SelectSqlData("vWorkerGroup", false, "");
            DataTable table5 = base.SelectSqlData("tUser", false, "");
            SqlDataConnect connect = new SqlDataConnect();
            connect.OpenConnection(this.SqlSettings);
            new SqlCommand("disable trigger dbo.AfterInsert_tJ_RequestForRepair on dbo.tj_requestForRepair ", connect.Connection).ExecuteNonQuery();
            DataSetN tges = new DataSetN();
            foreach (DataRow row in table.Rows)
            {
                TimeSpan span;
                tges.tJ_RequestForRepair.Clear();
                tges.tJ_RequestForRepairDaily.Clear();
                DataRow row2 = tges.tJ_RequestForRepair.NewRow();
                DataRow row3 = tges.tJ_RequestForRepairDaily.NewRow();
                row2["num"] = -1;
                if (idDivision == 920)
                {
                    if (TimeSpan.TryParse(row["SP55469"].ToString(), out span))
                    {
                        row2["dateCreate"] = Convert.ToDateTime(row["SP55397"]).Add(TimeSpan.Parse(row["SP55469"].ToString()));
                    }
                    else
                    {
                        row2["dateCreate"] = Convert.ToDateTime(row["SP55397"]);
                    }
                }
                else
                {
                    row2["dateCreate"] = Convert.ToDateTime(row["SP55397"]);
                }
                DataRow[] rowArray = table2.Select("IDDOC = '" + row["IDDOC"].ToString() + "'");
                if (rowArray.Length != 0)
                {
                    row2["num"] = Convert.ToInt32(rowArray[0]["DOCNO"].ToString().Trim());
                    DataRow[] rowArray2 = table3.Select("ID = '" + rowArray[0]["SP55413"].ToString() + "'");
                    if (rowArray2.Length != 0)
                    {
                        DataRow[] rowArray3 = table4.Select("FIO = '" + rowArray2[0]["DESCR"].ToString().Trim() + "'");
                        if (rowArray3.Length != 0)
                        {
                            row2["idWorker"] = rowArray3[0]["id"];
                            DataRow[] rowArray4 = table5.Select("idWorker = " + table4.Rows[0]["id"].ToString());
                            if (rowArray4.Length != 0)
                            {
                                row2["idUserCreate"] = rowArray4[0]["idUser"];
                            }
                        }
                        else
                        {
                            row2["idWorker"] = 0;
                        }
                    }
                    else
                    {
                        row2["IdWorker"] = -1;
                    }
                }
                else
                {
                    row2["IdWorker"] = -1;
                }
                row2["ReguestFiled"] = row["SP55452"].ToString().Trim();
                switch (Convert.ToInt32(row["SP55391"]))
                {
                    case 1:
                        row2["idSR"] = 0x2f4;
                        break;

                    case 2:
                        row2["idSR"] = 0x2f5;
                        break;

                    case 3:
                        row2["idSR"] = 0x2f6;
                        break;

                    case 4:
                        row2["idSR"] = 0x2f7;
                        break;

                    default:
                        {
                            continue;
                        }
                }
                row2["SchmObj"] = row["SP55393"].ToString().Trim();
                row2["Purpose"] = row["SP55394"].ToString().Trim();
                row2["IsPlanned"] = row["SP55395"].ToString().Trim() == "16QE";
                if (TimeSpan.TryParse(row["SP55398"].ToString(), out span))
                {
                    row3["DateBeg"] = Convert.ToDateTime(row["SP55396"]).Add(TimeSpan.Parse(row["SP55398"].ToString()));
                }
                else
                {
                    row3["DateBeg"] = Convert.ToDateTime(row["SP55396"]);
                }
                if (rowArray.Length != 0)
                {
                    string str = rowArray[0]["Date_TIMe_IDDOC"].ToString().Trim().Remove(8);
                    DateTime time2 = new DateTime(Convert.ToInt32(str.Remove(4)), Convert.ToInt32(str.Substring(4, 2)), Convert.ToInt32(str.Substring(6, 2)));
                    if (TimeSpan.TryParse(row["SP55449"].ToString(), out span))
                    {
                        row3["DateEnd"] = time2.Add(TimeSpan.Parse(row["SP55449"].ToString()));
                    }
                    else
                    {
                        row3["DateEnd"] = time2;
                    }
                }
                else if (TimeSpan.TryParse(row["SP55449"].ToString(), out span))
                {
                    row3["DateEnd"] = Convert.ToDateTime(row["SP55396"]).Add(TimeSpan.Parse(row["SP55449"].ToString()));
                }
                else
                {
                    row3["DateEnd"] = Convert.ToDateTime(row["SP55396"]);
                }
                row2["Agreed"] = row["SP55400"].ToString().Trim() == "16QY";
                row2["AgreeWith"] = row["SP55399"].ToString().Trim();
                row2["Comment"] = row["SP475"].ToString().Trim();
                if (idDivision == 920)
                {
                    row2["Address"] = row["SP55463"].ToString().Trim();
                }
                row2["iddivision"] = idDivision;
                row2["deleted"] = false;
                tges.tJ_RequestForRepair.Rows.Add(row2);
                int num = base.InsertSqlDataOneRow(tges, tges.tJ_RequestForRepair);
                row3["idRequest"] = num;
                tges.tJ_RequestForRepairDaily.Rows.Add(row3);
                base.InsertSqlData(tges, tges.tJ_RequestForRepairDaily);
            }
            new SqlCommand("enable trigger dbo.AfterInsert_tJ_RequestForRepair on dbo.tj_requestForRepair ", connect.Connection).ExecuteNonQuery();
        }

        private void toolBtnEditRequestRepair_Click(object sender, EventArgs e)
        {
            if (this.dgv.CurrentRow != null)
            {
                if ((Convert.ToInt32(this.dgv.CurrentRow.Cells[this.iddivisionDataGridViewTextBoxColumn.Name].Value) == 920) && this.isLoadRequestsClient)
                {
                    this.method_4();
                }
                else
                {
                    //RequestForRepair.FormJournalRequestForRepairAddEdit form1 = new RequestForRepair.FormJournalRequestForRepairAddEdit(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Edit, false);
                    // {вызывать старую форму; для 921} - 3(s)
                    FormJournalRequestForRepairAddEditPL form1 = new FormJournalRequestForRepairAddEditPL(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Edit, false);
                    form1.GoToSchema += (new GoToSchemaEventHandler(this.f_GoToSchema));
                    form1.SqlSettings = (this.SqlSettings);
                    form1.MdiParent = base.MdiParent;
                    form1.FormClosed += new FormClosedEventHandler(this.method_5);
                    form1.Show();
                }
            }
        }

        private void toolBtnDelRequestRepair_Click(object sender, EventArgs e)
        {
            if ((this.dgv.SelectedRows.Count != 0) && (MessageBox.Show("Вы действительно хотите удалить выделенные заявки?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string str = "";
                foreach (DataGridViewRow row in this.dgv.SelectedRows)
                {
                    str = str + row.Cells[this.idDataGridViewTextBoxColumn.Name].Value.ToString() + ",";
                }
                base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepair, true, "where id in (" + str.Remove(str.Length - 1) + ")");
                List<int> list = new List<int>();
                foreach (DataRow row2 in this.dataSetGES_0.tJ_RequestForRepair.Rows)
                {
                    if (((row2["isSend"] != DBNull.Value) && Convert.ToBoolean(row2["isSend"])) || ((row2["SendSite"] != DBNull.Value) && Convert.ToBoolean(row2["SendSite"])))
                    {
                        MessageBox.Show("Заявку №" + row2["num"].ToString() + " невозможно удалить.\r\nНевозможно удалить отправленные заявки.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        list.Add(Convert.ToInt32(row2["id"]));
                    }
                    else
                    {
                        int num = Convert.ToInt32(row2["id"]);
                        SqlDataCommand command = new SqlDataCommand(this.SqlSettings);
                        if (command.SelectSqlData(string.Format("with  tree (id, isApply, level)\r\n                                                as (select id, isApply,  0 as level  from tj_damage\r\n\t                                                where idReqForRepair = {0}\r\n\t                                                union all \r\n\t                                                select tj_damage.id, tJ_Damage.isApply, level+1\r\n\t                                                from tj_damage\t\r\n\t\t                                                inner join tree on tree.id = tj_damage.idParent \r\n\t\t                                            )\r\n\r\n                                                select * from tree\r\n                                                where isApply = 1", num)).Rows.Count > 0)
                        {
                            MessageBox.Show("Заявку №" + row2["num"].ToString() + " невозможно удалить.\r\nУ данной заявки есть согласованные дочерние документы.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            list.Add(Convert.ToInt32(row2["id"]));
                        }
                        else
                        {
                            DataTable table = command.SelectSqlData(string.Format("with  tree (id,  isApply, nameDOC)\r\n                                                as (select id,  isApply, typeDocname + isnull(' №' + numRequest, '') + \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tisnull(' от ' + CONVERT(VARCHAR(10),datedoc,104), '')\r\n\t\t\t\t\t\t\t\t\t\t\t\t   from vj_damage\r\n\t                                                where idReqForRepair = {0}\r\n\t                                                union all \r\n\t                                                select v.id, v.isApply, v.typeDocName+ isnull(' №' + v.numRequest, '') + \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tisnull(' от ' + CONVERT(VARCHAR(10),v.datedoc,104), '')\r\n\t                                                from vj_damage\tv\r\n\t\t                                                inner join tree on tree.id = v.idParent \r\n\t\t                                            )\r\n                                                    select * from tree", num));
                            if (table.Rows.Count > 0)
                            {
                                string str2 = "";
                                string str3 = "";
                                foreach (DataRow row3 in table.Rows)
                                {
                                    if (string.IsNullOrEmpty(str2))
                                    {
                                        str2 = row3["nameDoc"].ToString();
                                    }
                                    else
                                    {
                                        str2 = str2 + "\r\n" + row3["nameDoc"].ToString();
                                    }
                                    if (string.IsNullOrEmpty(str3))
                                    {
                                        str3 = row3["id"].ToString();
                                    }
                                    else
                                    {
                                        str3 = str3 + "," + row3["id"].ToString();
                                    }
                                }
                                if (MessageBox.Show(string.Format("Вы действительно хотите удалить заявку №{0}?\r\nУ данной заявки есть следующие дочерние документы:\r\n{1}", row2["num"].ToString(), str2), "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    command.UpdateSqlData(new DataTable("tJ_damage"), "set deleted = 1", "where id in (" + str3 + ")");
                                }
                                else
                                {
                                    list.Add(Convert.ToInt32(row2["id"]));
                                    goto Label_03AB;
                                }
                            }
                            row2["deleted"] = true;
                            row2.EndEdit();
                            Label_03AB:;
                        }
                    }
                }
                base.UpdateSqlData(this.dataSetGES_0, this.dataSetGES_0.tJ_RequestForRepair);
                foreach (DataGridViewRow row4 in this.dgv.SelectedRows)
                {
                    if (!list.Contains(Convert.ToInt32(row4.Cells[this.idDataGridViewTextBoxColumn.Name].Value)))
                    {
                        this.dgv.Rows.Remove(row4);
                    }
                }
            }
        }

        private void toolBtnFindNext_Click(object sender, EventArgs e)
        {
            this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolTextFind.Text);
        }

        private void toolBtnSettingsSend_Click(object sender, EventArgs e)
        {
            FormSettingsSender sender1 = new FormSettingsSender()
            {
                SqlSettings = (this.SqlSettings),
                MdiParent = base.MdiParent
            };
            sender1.Show();
        }

        private void toolBtnReadRequestRepair_Click(object sender, EventArgs e)
        {
            if (this.dgv.CurrentRow != null)
            {
                if ((Convert.ToInt32(this.dgv.CurrentRow.Cells[this.iddivisionDataGridViewTextBoxColumn.Name].Value) == 920) && this.isLoadRequestsClient)
                {
                    this.method_6();
                }
                else
                {
                    //RequestForRepair.FormJournalRequestForRepairAddEdit form1 = new RequestForRepair.FormJournalRequestForRepairAddEdit(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Read, false);
                    // {вызывать старую форму; для 921} - 4(r)
                    FormJournalRequestForRepairAddEditPL form1 = new FormJournalRequestForRepairAddEditPL(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Read, false);

                    form1.GoToSchema += (new GoToSchemaEventHandler(this.f_GoToSchema));
                    form1.SqlSettings = (this.SqlSettings);
                    form1.MdiParent = base.MdiParent;
                    form1.Show();
                }
            }
        }

        private void toolBtnFilter_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void toolBtnNoFilter_Click(object sender, EventArgs e)
        {
            this.dateTimePickerBeg.MaxDate = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePickerBeg.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePickerEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);
            for (int i = 0; i < this.checkedListBoxDivision.Items.Count; i++)
            {
                this.checkedListBoxDivision.SetItemChecked(i, true);
            }
            this.LoadData();
        }

        private void toolBrnRefresh_Click(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void toolBtnReport_Click(object sender, EventArgs e)
        {
            Documents.JournalRequestForRepair.FormReportRequestForRepairN form1 = new Documents.JournalRequestForRepair.FormReportRequestForRepairN(this.isCrash);
            form1.SqlSettings = this.SqlSettings;
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }

        private void toolBtnExport_Click(object sender, EventArgs e)
        {
            Documents.JournalRequestForRepair.FormExportRequestForRepair form1 = new Documents.JournalRequestForRepair.FormExportRequestForRepair(this.isCrash);
            form1.SqlSettings = this.SqlSettings;
            form1.MdiParent = base.MdiParent;
            form1.Show();
        }

        private void toolBtnFind_Click(object sender, EventArgs e)
        {
            this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.toolTextFind.Text);
        }

        private void toolBtnFindPrev_Click(object sender, EventArgs e)
        {
            this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolTextFind.Text);
        }

        private void toolBtnImportODS_Click(object sender, EventArgs e)
        {
            this.importOldZayavki(920);
        }

        private void toolBtnImportPL_Click(object sender, EventArgs e)
        {
            this.importOldZayavki(921);//921
        }

        private void toolTextFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (e.Modifiers)
                {
                    case Keys.None:
                        this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolTextFind.Text);
                        break;

                    case Keys.Shift:
                        this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolTextFind.Text);
                        break;
                }
            }
        }
    }
}



