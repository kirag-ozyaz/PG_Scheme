using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using DataSql;
//using Documents.Properties;
using FormLbr;
using FormLbr.Classes;
using RequestForRepairN.DataSets;
//using RequestsClient.Forms.JournalRequestForRepair;

namespace RequestForRepairN
{
    /// <summary>
    /// Журнал заявок на ремонт оборудования:
    /// Журнал по отключениям для службы 05
    /// N2
    /// </summary>
    public partial class FormJournalRequestForRepair : FormBase
	{
        private bool IsLoadRequestsClient;
        private bool IsCrash;
        private string sortString = "";
        private int Distance = 400;

        private const int ODS_DIVISION = 920;
        private const int PL_DIVISION = 921;
        private const int NO_DIVISION = 1665;

        public FormJournalRequestForRepair()
		{
			this.InitializeComponent();
		}

		public FormJournalRequestForRepair(bool isCrash = false)
		{
			this.InitializeComponent();
			this.IsCrash = isCrash;
			
            if (IsCrash)
            {
                this.Text = "Журнал по отключениям для службы 05 (N2)";
                this.Icon = (Icon)RequestForRepairN.Properties.Resources.repair_Crash;
            }
            else
            {
                this.Icon = (Icon)RequestForRepairN.Properties.Resources.repair;
            }
        }

        private void FormJournalRequestForRepair_Load(object sender, EventArgs e)
		{
			this.toolBtnImport.Visible = false;
			this.dateTimePickerBeg.Value = DateTime.Now.Date;
			this.dateTimePickerEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);
			this.LoadRequestsClient();
			base.SelectSqlData(this.DataSetDamage, this.DataSetDamage.tR_Classifier, true, " where ParentKey = ';Other;DivisionRequestRepair;' and isgroup = 0 and deleted = 0 order by name");
			foreach (DataRow dataRow in this.DataSetDamage.tR_Classifier.Rows)
			{
		
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
				toolStripMenuItem.Click += new EventHandler(this.toolSplitBtnAddRequestRepair_Click);
                toolStripMenuItem.Text = dataRow["SocrName"].ToString();
				toolStripMenuItem.Tag = dataRow["id"];
				this.toolSplitBtnAddRequestRepair.DropDownItems.Add(toolStripMenuItem);

                ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
				toolStripMenuItem2.Click += new EventHandler(this.toolBtnRequestCopy_Click);
                toolStripMenuItem2.Text = dataRow["SocrName"].ToString();
				toolStripMenuItem2.Tag = dataRow["id"];
				this.toolBtnRequestCopy.DropDownItems.Add(toolStripMenuItem2);

                DivisionRequestForRepair divisionRequestForRepair = new DivisionRequestForRepair(Convert.ToInt32(dataRow["Id"]), dataRow["Name"].ToString());
				this.checkedListBoxDivision.Items.Add(divisionRequestForRepair, true);
			}
			this.splitContainerDgvBuild();
			this.LoadData();
		}

		private void LoadRequestsClient()
		{
			try
			{
				Assembly.Load("RequestsClient");
				this.IsLoadRequestsClient = true;
			}
			catch (Exception)
			{
			}
			this.toolBtnSettingsSend.Visible = this.IsLoadRequestsClient;
		}
        /// <summary>
        /// добавим документ новой формой
        /// </summary>
		private void DocumentAdd(object sender, EventArgs e)
		{
            if (this.IsCrash)
            {
                FormJournalRequestForRepairAddEditAlarm formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEditAlarm(-1, Convert.ToInt32(((ToolStripMenuItem)sender).Tag), eActionRequestRepair.Add, this.IsCrash);
                formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
                formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
                formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
                formJournalRequestForRepairAddEdit.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
                formJournalRequestForRepairAddEdit.Show();
            }
                else
            {
                FormJournalRequestForRepairAddEdit formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEdit(-1, Convert.ToInt32(((ToolStripMenuItem)sender).Tag), eActionRequestRepair.Add, this.IsCrash);
                formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
                formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
                formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
                formJournalRequestForRepairAddEdit.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
                formJournalRequestForRepairAddEdit.Show();
            }
		}
        /// <summary>
        /// добавим документ новой формой (для всех)
        /// </summary>
		private void toolSplitBtnAddRequestRepair_Click(object sender, EventArgs e)
		{
            int idDivision = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);

            if (idDivision == ODS_DIVISION && this.IsLoadRequestsClient)
			{
				this.DocumentAdd(sender, e);
				return;
			}
            //if (idDivision == NO_DIVISION)
            //{

            //    return;
            //}

            FormJournalRequestForRepairAddEditPL form = new FormJournalRequestForRepairAddEditPL(-1, idDivision, eActionRequestRepair.Add, this.IsCrash);
			form.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
			form.SqlSettings = this.SqlSettings;
			form.MdiParent = base.MdiParent;
			form.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
			form.Show();
		}

		private void f_GoToSchema(object sender, GoToSchemaEventArgs e)
		{
			this.OnGoToSchema(e);
		}
        /// <summary>
        /// редактирование документа новой формой
        /// </summary>
		private void toolBtnEditRequestRepair_Click(object sender, EventArgs e)
		{
            int idDivision = Convert.ToInt32(this.dgv.CurrentRow.Cells[this.iddivisionDataGridViewTextBoxColumn.Name].Value);
            if (this.dgv.CurrentRow != null)
			{
				if (Convert.ToInt32(this.dgv.CurrentRow.Cells[this.iddivisionDataGridViewTextBoxColumn.Name].Value) == ODS_DIVISION && this.IsLoadRequestsClient)
				{
					this.DocumentEdit();
					return;
				}
                if (idDivision == NO_DIVISION)
                {
                    FormJournalRequestForRepairAddEditPL formn = new FormJournalRequestForRepairAddEditPL(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), NO_DIVISION, eActionRequestRepair.Edit, false);
                    formn.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
                    formn.SqlSettings = this.SqlSettings;
                    formn.MdiParent = base.MdiParent;
                    formn.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
                    formn.Show();
                    return;
                }
                FormJournalRequestForRepairAddEditPL form = new FormJournalRequestForRepairAddEditPL(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Edit, false);
				form.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
				form.SqlSettings = this.SqlSettings;
				form.MdiParent = base.MdiParent;
				form.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
				form.Show();
			}
		}

		private void DocumentEdit()
		{
            if (this.IsCrash)
            {
                FormJournalRequestForRepairAddEditAlarm formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEditAlarm(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Edit, this.IsCrash);
                formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
                formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
                formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
                formJournalRequestForRepairAddEdit.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
                formJournalRequestForRepairAddEdit.Show();
            }
            else
            {
                FormJournalRequestForRepairAddEdit formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEdit(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Edit, this.IsCrash);
                formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
                formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
                formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
                formJournalRequestForRepairAddEdit.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
                formJournalRequestForRepairAddEdit.Show();
            }
		}

		private void f_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (((Form)sender).DialogResult == DialogResult.OK)
			{
				this.LoadData();
			}
		}

		private void toolBtnReadRequestRepair_Click(object sender, EventArgs e)
		{
			if (this.dgv.CurrentRow != null)
			{
				if (Convert.ToInt32(this.dgv.CurrentRow.Cells[this.iddivisionDataGridViewTextBoxColumn.Name].Value) == ODS_DIVISION && this.IsLoadRequestsClient)
				{
					this.DocumentRead();
					return;
				}
				FormJournalRequestForRepairAddEditPL form = new FormJournalRequestForRepairAddEditPL(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Read, false);
				form.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
				form.SqlSettings = this.SqlSettings;
				form.MdiParent = base.MdiParent;
				form.Show();
			}
		}
        /// <summary>
        /// чтение документа новой формой
        /// </summary>
		private void DocumentRead()
		{
            if (this.IsCrash)
            {
                FormJournalRequestForRepairAddEditAlarm formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEditAlarm(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Read, false);
                formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
                formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
                formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
                formJournalRequestForRepairAddEdit.Show();

            }
            else
            {
                FormJournalRequestForRepairAddEdit formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEdit(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Read, false);
                formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
                formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
                formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
                formJournalRequestForRepairAddEdit.Show();
            }
		}

		private void toolBtnDelRequestRepair_Click(object sender, EventArgs e)
		{
			if (this.dgv.SelectedRows.Count == 0)
			{
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить выделенные заявки?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				string text = "";
				foreach (DataGridViewRow dataGridViewRow in this.dgv.SelectedRows)
				{
					text = text + dataGridViewRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value.ToString() + ",";
				}
				base.SelectSqlData(this.DataSetDamage, this.DataSetDamage.tJ_RequestForRepair, true, "where id in (" + text.Remove(text.Length - 1) + ")");
				List<int> list = new List<int>();
				foreach (DataRow dataRow in this.DataSetDamage.tJ_RequestForRepair.Rows)
                {
                    if (dataRow["Status"] != DBNull.Value)
                    {
                        MessageBox.Show("Заявку №" + dataRow["num"].ToString() + " невозможно удалить.\r\nНевозможно удалить зарегистрированные заявки.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        list.Add(Convert.ToInt32(dataRow["id"]));
                    }
                    else
                    if ((dataRow["isSend"] != DBNull.Value && Convert.ToBoolean(dataRow["isSend"])) || (dataRow["SendSite"] != DBNull.Value && Convert.ToBoolean(dataRow["SendSite"])))
                    {
                        MessageBox.Show("Заявку №" + dataRow["num"].ToString() + " невозможно удалить.\r\nНевозможно удалить отправленные заявки.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        list.Add(Convert.ToInt32(dataRow["id"]));
                    }
                    else
                    {
                        int idReqForRepair = Convert.ToInt32(dataRow["id"]);
                        SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
                        DataTable dataTable = sqlDataCommand.SelectSqlData(string.Format("with  tree (id, isApply, level)\r\n                                                as (select id, isApply,  0 as level  from tj_damage\r\n\t                                                where idReqForRepair = {0}\r\n\t                                                union all \r\n\t                                                select tj_damage.id, tJ_Damage.isApply, level+1\r\n\t                                                from tj_damage\t\r\n\t\t                                                inner join tree on tree.id = tj_damage.idParent \r\n\t\t                                            )\r\n\r\n                                                select * from tree\r\n                                                where isApply = 1", idReqForRepair));
                        if (dataTable.Rows.Count > 0)
                        {
                            MessageBox.Show("Заявку №" + dataRow["num"].ToString() + " невозможно удалить.\r\nУ данной заявки есть согласованные дочерние документы.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            list.Add(Convert.ToInt32(dataRow["id"]));
                        }
                        else
                        {
                            dataTable = sqlDataCommand.SelectSqlData(string.Format("with  tree (id,  isApply, nameDOC)\r\n                                                as (select id,  isApply, typeDocname + isnull(' №' + numRequest, '') + \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tisnull(' от ' + CONVERT(VARCHAR(10),datedoc,104), '')\r\n\t\t\t\t\t\t\t\t\t\t\t\t   from vj_damage\r\n\t                                                where idReqForRepair = {0}\r\n\t                                                union all \r\n\t                                                select v.id, v.isApply, v.typeDocName+ isnull(' №' + v.numRequest, '') + \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tisnull(' от ' + CONVERT(VARCHAR(10),v.datedoc,104), '')\r\n\t                                                from vj_damage\tv\r\n\t\t                                                inner join tree on tree.id = v.idParent \r\n\t\t                                            )\r\n                                                    select * from tree", idReqForRepair));
                            if (dataTable.Rows.Count > 0)
                            {
                                string text2 = "";
                                string text3 = "";
                                foreach (DataRow dataRow2 in dataTable.Rows)
                                {
                                    if (string.IsNullOrEmpty(text2))
                                    {
                                        text2 = dataRow2["nameDoc"].ToString();
                                    }
                                    else
                                    {
                                        text2 = text2 + "\r\n" + dataRow2["nameDoc"].ToString();
                                    }
                                    if (string.IsNullOrEmpty(text3))
                                    {
                                        text3 = dataRow2["id"].ToString();
                                    }
                                    else
                                    {
                                        text3 = text3 + "," + dataRow2["id"].ToString();
                                    }
                                }
                                if (MessageBox.Show(string.Format("Вы действительно хотите удалить заявку №{0}?\r\nУ данной заявки есть следующие дочерние документы:\r\n{1}", dataRow["num"].ToString(), text2), "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                                {
                                    list.Add(Convert.ToInt32(dataRow["id"]));
                                    continue;
                                }
                                sqlDataCommand.UpdateSqlData(new DataTable("tJ_damage"), "set deleted = 1", "where id in (" + text3 + ")");
                            }
                            dataRow["deleted"] = true;
                            dataRow.EndEdit();
                        }
                    }
                }
                base.UpdateSqlData(this.DataSetDamage, this.DataSetDamage.tJ_RequestForRepair);
				foreach (DataGridViewRow dataGridViewRow2 in this.dgv.SelectedRows)
				{
					if (!list.Contains(Convert.ToInt32(dataGridViewRow2.Cells[this.idDataGridViewTextBoxColumn.Name].Value)))
					{
						this.dgv.Rows.Remove(dataGridViewRow2);
					}
				}
			}
		}

		private void toolBtnRequestCopy_Click(object sender, EventArgs e)
		{
			if (this.dgv.CurrentRow != null && ((ToolStripMenuItem)sender).Tag != null)
			{
				base.SelectSqlData(this.DataSetDamage, this.DataSetDamage.tJ_RequestForRepair, true, " where id = " + this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value.ToString());
				if (this.DataSetDamage.tJ_RequestForRepair.Rows.Count > 0)
				{
					DataRow dataRow = this.DataSetDamage.tJ_RequestForRepair.NewRow();
					dataRow.ItemArray = this.DataSetDamage.tJ_RequestForRepair.Rows[0].ItemArray;
					dataRow["idDivision"] = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
					dataRow["Agreed"] = false;
                    if (Convert.ToInt32(((ToolStripMenuItem)sender).Tag) == ODS_DIVISION && this.IsLoadRequestsClient)
                    {
                        this.DocumentCopy(dataRow);

                    }
                    else
                    {
                        FormJournalRequestForRepairAddEditPL form = new FormJournalRequestForRepairAddEditPL(dataRow);
                        form.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
                        form.SqlSettings = this.SqlSettings;
                        form.MdiParent = base.MdiParent;
                        form.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
                        form.Show();
                    }
				}
			}
		}
        /// <summary>
        /// копирование документа новой формой
        /// </summary>
        /// <param name="row"></param>
		private void DocumentCopy(DataRow row)
		{
            FormJournalRequestForRepairAddEdit formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEdit(row);
			formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
			formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
			formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
			formJournalRequestForRepairAddEdit.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
			formJournalRequestForRepairAddEdit.Show();
		}

		private void toolBrnRefresh_Click(object sender, EventArgs e)
		{
			this.LoadData();
		}

		private void toolBtnReport_Click(object sender, EventArgs e)
		{
			new FormReportRequestForRepair(this.IsCrash)
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void toolBtnExport_Click(object sender, EventArgs e)
		{
			new FormExportRequestForRepair(this.IsCrash)
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				if (this.toolBtnEditRequestRepair.Enabled && this.toolBtnEditRequestRepair.Visible)
				{
					this.toolBtnEditRequestRepair_Click(sender, e);
					return;
				}
				this.toolBtnReadRequestRepair_Click(sender, e);
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
				if (Convert.ToInt32(this.dgv[this.iddivisionDataGridViewTextBoxColumn.Name, e.RowIndex].Value) == PL_DIVISION)
				{
					e.CellStyle.BackColor = Color.LightGray;
				}
                else if (Convert.ToInt32(this.dgv[this.iddivisionDataGridViewTextBoxColumn.Name, e.RowIndex].Value) == NO_DIVISION)
                {
                    e.CellStyle.BackColor = Color.LightCyan;
                }
                if (this.dgv[this.isSendDgvColumn.Name, e.RowIndex].Value != DBNull.Value && this.dgv.Columns[e.ColumnIndex] == this.numDataGridViewTextBoxColumn)
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
						Color backColor = Color.FromName(this.dgv[this.colorStatusDgvColumn.Name, e.RowIndex].Value.ToString());
						e.CellStyle.BackColor = backColor;
					}
					catch
					{
					}
				}
			}
		}

		private void toolBtnImportODS_Click(object sender, EventArgs e)
		{
			this.importOldZayavki(ODS_DIVISION);
		}

		private void toolBtnImportPL_Click(object sender, EventArgs e)
		{
			this.importOldZayavki(PL_DIVISION);
		}

		private void importOldZayavki(int idDivision)
		{
			SQLSettings sqlSett;
			if (idDivision == ODS_DIVISION)
			{
				sqlSett = new SQLSettings("ulges-sql", "zayavki_ODS", "WINDOWS", "", "");
			}
			else
			{
				sqlSett = new SQLSettings("ulges-sql", "zayavki_PL", "WINDOWS", "", "");
			}
			SqlDataCommand sqlDataCommand = new SqlDataCommand(sqlSett);
			DataTable dataTable = sqlDataCommand.SelectSqlData("DH55388", false, "", null);
			DataTable dataTable2 = sqlDataCommand.SelectSqlData("_1SJOURN", false, "", null);
			DataTable dataTable3 = sqlDataCommand.SelectSqlData("SC55410", false, "", null);
			DataTable dataTable4 = base.SelectSqlData("vWorkerGroup", false, "");
			DataTable dataTable5 = base.SelectSqlData("tUser", false, "");
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			sqlDataConnect.OpenConnection(this.SqlSettings);
			new SqlCommand("disable trigger dbo.AfterInsert_tJ_RequestForRepair on dbo.tj_requestForRepair ", sqlDataConnect.Connection).ExecuteNonQuery();
            DataSetDamage tges = new DataSetDamage();
			foreach (DataRow dataRow in dataTable.Rows)
			{
				tges.tJ_RequestForRepair.Clear();
				tges.tJ_RequestForRepairDaily.Clear();
				DataRow dataRow2 = tges.tJ_RequestForRepair.NewRow();
				DataRow dataRow3 = tges.tJ_RequestForRepairDaily.NewRow();
				dataRow2["num"] = -1;
				TimeSpan timeSpan;
				if (idDivision == ODS_DIVISION)
				{
					if (TimeSpan.TryParse(dataRow["SP55469"].ToString(), out timeSpan))
					{
						dataRow2["dateCreate"] = Convert.ToDateTime(dataRow["SP55397"]).Add(TimeSpan.Parse(dataRow["SP55469"].ToString()));
					}
					else
					{
						dataRow2["dateCreate"] = Convert.ToDateTime(dataRow["SP55397"]);
					}
				}
				else
				{
					dataRow2["dateCreate"] = Convert.ToDateTime(dataRow["SP55397"]);
				}
				DataRow[] array = dataTable2.Select("IDDOC = '" + dataRow["IDDOC"].ToString() + "'");
				if (array.Length != 0)
				{
					dataRow2["num"] = Convert.ToInt32(array[0]["DOCNO"].ToString().Trim());
					DataRow[] array2 = dataTable3.Select("ID = '" + array[0]["SP55413"].ToString() + "'");
					if (array2.Length != 0)
					{
						DataRow[] array3 = dataTable4.Select("FIO = '" + array2[0]["DESCR"].ToString().Trim() + "'");
						if (array3.Length != 0)
						{
							dataRow2["idWorker"] = array3[0]["id"];
							DataRow[] array4 = dataTable5.Select("idWorker = " + dataTable4.Rows[0]["id"].ToString());
							if (array4.Length != 0)
							{
								dataRow2["idUserCreate"] = array4[0]["idUser"];
							}
						}
						else
						{
							dataRow2["idWorker"] = 0;
						}
					}
					else
					{
						dataRow2["IdWorker"] = -1;
					}
				}
				else
				{
					dataRow2["IdWorker"] = -1;
				}
				dataRow2["ReguestFiled"] = dataRow["SP55452"].ToString().Trim();
				switch (Convert.ToInt32(dataRow["SP55391"]))
				{
				case 1:
					dataRow2["idSR"] = 756;
					break;
				case 2:
					dataRow2["idSR"] = 757;
					break;
				case 3:
					dataRow2["idSR"] = 758;
					break;
				case 4:
					dataRow2["idSR"] = 759;
					break;
				default:
					continue;
				}
				dataRow2["SchmObj"] = dataRow["SP55393"].ToString().Trim();
				dataRow2["Purpose"] = dataRow["SP55394"].ToString().Trim();
				dataRow2["IsPlanned"] = (dataRow["SP55395"].ToString().Trim() == "16QE");
				if (TimeSpan.TryParse(dataRow["SP55398"].ToString(), out timeSpan))
				{
					dataRow3["DateBeg"] = Convert.ToDateTime(dataRow["SP55396"]).Add(TimeSpan.Parse(dataRow["SP55398"].ToString()));
				}
				else
				{
					dataRow3["DateBeg"] = Convert.ToDateTime(dataRow["SP55396"]);
				}
				if (array.Length != 0)
				{
					string text = array[0]["Date_TIMe_IDDOC"].ToString().Trim().Remove(8);
					DateTime dateTime = new DateTime(Convert.ToInt32(text.Remove(4)), Convert.ToInt32(text.Substring(4, 2)), Convert.ToInt32(text.Substring(6, 2)));
					if (TimeSpan.TryParse(dataRow["SP55449"].ToString(), out timeSpan))
					{
						dataRow3["DateEnd"] = dateTime.Add(TimeSpan.Parse(dataRow["SP55449"].ToString()));
					}
					else
					{
						dataRow3["DateEnd"] = dateTime;
					}
				}
				else if (TimeSpan.TryParse(dataRow["SP55449"].ToString(), out timeSpan))
				{
					dataRow3["DateEnd"] = Convert.ToDateTime(dataRow["SP55396"]).Add(TimeSpan.Parse(dataRow["SP55449"].ToString()));
				}
				else
				{
					dataRow3["DateEnd"] = Convert.ToDateTime(dataRow["SP55396"]);
				}
				dataRow2["Agreed"] = (dataRow["SP55400"].ToString().Trim() == "16QY");
				dataRow2["AgreeWith"] = dataRow["SP55399"].ToString().Trim();
				dataRow2["Comment"] = dataRow["SP475"].ToString().Trim();
				if (idDivision == ODS_DIVISION)
				{
					dataRow2["Address"] = dataRow["SP55463"].ToString().Trim();
				}
				dataRow2["iddivision"] = idDivision;
				dataRow2["deleted"] = false;
				tges.tJ_RequestForRepair.Rows.Add(dataRow2);
				int idRequest = base.InsertSqlDataOneRow(tges, tges.tJ_RequestForRepair);
				dataRow3["idRequest"] = idRequest;
				tges.tJ_RequestForRepairDaily.Rows.Add(dataRow3);
				base.InsertSqlData(tges, tges.tJ_RequestForRepairDaily);
			}
			new SqlCommand("enable trigger dbo.AfterInsert_tJ_RequestForRepair on dbo.tj_requestForRepair ", sqlDataConnect.Connection).ExecuteNonQuery();
		}

		private void dateTimePickerBeg_ValueChanged(object sender, EventArgs e)
		{
			this.dateTimePickerEnd.MinDate = this.dateTimePickerBeg.Value;
		}

		private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
		{
			this.dateTimePickerBeg.MaxDate = this.dateTimePickerEnd.Value;
		}

		private void LoadData()
		{
			int idDamage = -1;
			if (this.dgv.CurrentRow != null)
			{
				idDamage = Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
			}
			this.toolStrip.Enabled = false;
			this.splitContainer.Enabled = false;
			this.toolStripProgressBarLoad.Visible = true;
			this.toolStripLabelLoad.Visible = true;
			this.sortString = this.bsRequestForRepair.Sort;
			this.bsRequestForRepair.Sort = string.Empty;
			this.bsRequestForRepair.DataMember = null;
			this.backgroundWorker.RunWorkerAsync(idDamage);
		}

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			string text = "'" + this.dateTimePickerBeg.Value.Date.ToString("yyyyMMdd") + "'";
			string text2 = "'" + this.dateTimePickerEnd.Value.ToString("yyyyMMdd HH:mm:ss") + "'";
			string text3 = string.Concat(new string[]
			{
				" ((dateBeg <= ",
				text2,
				" and dateEnd >= ",
				text,
				"))"
			});
			text3 = string.Format(" (id in (select idRequest from tj_requestForRepairDaily where {0})) ", text3);
			string text4 = " and (crash = 0 or crash is null) ";
			if (this.IsCrash)
			{
				text4 = " and (crash = 1) ";
			}
			string text5 = "";
			foreach (object obj in this.checkedListBoxDivision.CheckedItems)
			{
				text5 = text5 + ((DivisionRequestForRepair)obj).Id.ToString() + ",";
			}
			if (text5.Length > 0)
			{
				base.SelectSqlData(this.DataSetDamage, this.DataSetDamage.vJ_RequestForRepair, true, string.Concat(new string[]
				{
					" where ",
					text3,
					text4,
					" and idDivision in (",
					text5.Remove(text5.Length - 1),
					") and deleted = 0 order by datecreate desc"
				}));
			}
			else
			{
				this.DataSetDamage.vJ_RequestForRepair.Clear();
			}
			e.Result = e.Argument;
		}

		private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.toolStrip.Enabled = true;
			this.splitContainer.Enabled = true;
			this.toolStripProgressBarLoad.Visible = false;
			this.toolStripLabelLoad.Visible = false;
			this.bsRequestForRepair.DataMember = this.DataSetDamage.vJ_RequestForRepair.TableName;
			this.bsRequestForRepair.Sort = this.sortString;
			if (e.Result != null && Convert.ToInt32(e.Result) > 0)
			{
				this.dgv.SearchGrid(this.idDataGridViewTextBoxColumn.Name, e.Result.ToString(), false);
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

		private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			this.dgv.AutoResizeRow(e.RowIndex);
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
				Keys modifiers = e.Modifiers;
				if (modifiers == Keys.None)
				{
					this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolTextFind.Text);
					return;
				}
				if (modifiers != Keys.Shift)
				{
					return;
				}
				this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolTextFind.Text);
			}
		}

		private void toolBtnSettingsSend_Click(object sender, EventArgs e)
		{
			new FormSettingsSender
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent
			}.Show();
		}

		private void splitContainerDgvBuild()
		{
            if (this.IsCrash)
            {
                this.splitContainerDgv.SplitterDistance = this.splitContainerDgv.Height - this.splitContainerDgv.SplitterWidth - this.lbChildDoc.Height;
                this.splitContainerDgv.IsSplitterFixed = true;

            }
            else
                this.splitContainerDgv.Panel2Collapsed = true;
        }

        private void lbChildDoc_Click(object sender, EventArgs e)
		{
			if (this.lbChildDoc.Cursor == Cursors.PanNorth)
			{
				this.splitContainerDgv.SplitterDistance = this.Distance;
				this.splitContainerDgv.IsSplitterFixed = false;
				this.lbChildDoc.Cursor = Cursors.PanSouth;
				return;
			}
			if (this.lbChildDoc.Cursor == Cursors.PanSouth)
			{
				this.Distance = this.splitContainerDgv.SplitterDistance;
				this.splitContainerDgv.SplitterDistance = this.splitContainerDgv.Height - this.splitContainerDgv.SplitterWidth - this.lbChildDoc.Height;
				this.splitContainerDgv.IsSplitterFixed = true;
				this.lbChildDoc.Cursor = Cursors.PanNorth;
			}
		}

		private void bsRequestForRepair_CurrentChanged(object sender, EventArgs e)
		{
			this.DataSetDamage.vJ_Damage.Clear();
			if (this.bsRequestForRepair.Current != null && this.bsRequestForRepair.Current is DataRowView)
			{
				int idReqForRepair = Convert.ToInt32(((DataRowView)this.bsRequestForRepair.Current).Row["id"]);
				try
				{
					using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
					{
						sqlConnection.Open();
						using (SqlCommand sqlCommand = new SqlCommand(string.Format("with  tree (numRequest, dateDoc, TypeDocName, TYpeDoc, schmObjName, id, isApply)\r\n                                                as (select numRequest, dateDoc, TypeDocName, TypeDoc, schmObjName, id, isApply\r\n\t\t\t\t\t\t\t\t\t\t\t\t   from vj_damage\r\n\t                                                where idReqForRepair = {0}\r\n\t                                                union all \r\n\t                                                select v.numRequest, v.dateDoc, v.TypeDocName, v.typeDoc, v.schmObjName, v.id, v.isApply\r\n\t                                                from vj_damage\tv\r\n\t\t                                                inner join tree on tree.id = v.idParent \r\n\t\t                                            )\r\n                                                    select * from tree", idReqForRepair), sqlConnection))
						{
							new SqlDataAdapter(sqlCommand).Fill(this.DataSetDamage.vJ_Damage);
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
		}

        private void toolStripButtonExportExcel1_Click(object sender, EventArgs e)
        {
            this.dgv.ExportToExcel();
        }
    }
}
