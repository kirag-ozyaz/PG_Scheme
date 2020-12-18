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
using FormLbr;
using FormLbr.Classes;
using NotificationOfRepairs.DataSets;

namespace NotificationOfRepairs
{
    /// <summary>
    /// Журнал уведомлений об отключениях потребителей
    /// </summary>
    public partial class FormJournalNotificationOfRepairs : FormBase
	{
        string TypeDocNameRequest = "";
        int TypeDocRequest = 0;

        private string sortString = "";
        private int Distance = 400;

        private const int ODS_DIVISION = 920;
        private const int PL_DIVISION = 921;
        private const int NO_DIVISION = 1665;

		public FormJournalNotificationOfRepairs()
		{
			this.InitializeComponent();
        }

        private void NotificationOfRepairs_Load(object sender, EventArgs e)
		{
			this.dateTimePickerBeg.Value = DateTime.Now.Date;
			this.dateTimePickerEnd.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddSeconds(-1.0);

            TypeDocRequest = (int)Library.Dokuments.eTypeDocuments.RequestForRepair;
            base.SelectSqlData(this.DataSetNotifications, this.DataSetNotifications.tR_Classifier, true, $" where id = {TypeDocRequest} and isgroup = 0 and deleted = 0 order by name");
            
            if (this.DataSetNotifications.tR_Classifier.Rows.Count > 0)
            {
                DataRow ppp = DataSetNotifications.tR_Classifier.Rows[0];
                TypeDocNameRequest = ppp["Name"].ToString();
            }

            this.splitContainerDgvBuild();
			this.LoadData();
		}

        /// <summary>
        /// добавим документ новой формой
        /// </summary>
		private void DocumentAdd(object sender, EventArgs e)
		{
            //if (this.IsCrash)
            //{
            //    FormJournalRequestForRepairAddEditAlarm formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEditAlarm(-1, Convert.ToInt32(((ToolStripMenuItem)sender).Tag), eActionRequestRepair.Add, this.IsCrash);
            //    formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            //    formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
            //    formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
            //    formJournalRequestForRepairAddEdit.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
            //    formJournalRequestForRepairAddEdit.Show();
            //}
            //    else
            //{
            //    FormJournalRequestForRepairAddEdit formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEdit(-1, Convert.ToInt32(((ToolStripMenuItem)sender).Tag), eActionRequestRepair.Add, this.IsCrash);
            //    formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            //    formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
            //    formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
            //    formJournalRequestForRepairAddEdit.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
            //    formJournalRequestForRepairAddEdit.Show();
            //}
            FormNotificationOfRepairsAddEdit frm = new FormNotificationOfRepairsAddEdit(-1, 0, Library.Dokuments.eActionRequestRepair.Add);
            frm.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            frm.SqlSettings = this.SqlSettings;
            frm.MdiParent = base.MdiParent;
            frm.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
            frm.Show();
        }
        /// <summary>
        /// добавим документ новой формой (для всех)
        /// </summary>
		private void toolSplitBtnAddRequestRepair_Click(object sender, EventArgs e)
		{
            //int idDocument = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);

            //if (idDocument == ODS_DIVISION )
			//{
				this.DocumentAdd(sender, e);
			//	return;
			//}

   //         FormJournalRequestForRepairAddEditPL form = new FormJournalRequestForRepairAddEditPL(-1, idDivision, eActionRequestRepair.Add, this.IsCrash);
			//form.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
			//form.SqlSettings = this.SqlSettings;
			//form.MdiParent = base.MdiParent;
			//form.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
			//form.Show();
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
				if (Convert.ToInt32(this.dgv.CurrentRow.Cells[this.iddivisionDataGridViewTextBoxColumn.Name].Value) == ODS_DIVISION )
				{
					this.DocumentEdit();
					return;
				}
    //            if (idDivision == NO_DIVISION)
    //            {
    //                FormJournalRequestForRepairAddEditPL formn = new FormJournalRequestForRepairAddEditPL(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), NO_DIVISION, eActionRequestRepair.Edit, false);
    //                formn.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
    //                formn.SqlSettings = this.SqlSettings;
    //                formn.MdiParent = base.MdiParent;
    //                formn.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
    //                formn.Show();
    //                return;
    //            }
    //            FormJournalRequestForRepairAddEditPL form = new FormJournalRequestForRepairAddEditPL(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Edit, false);
				//form.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
				//form.SqlSettings = this.SqlSettings;
				//form.MdiParent = base.MdiParent;
				//form.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
				//form.Show();
			}
		}

		private void DocumentEdit()
		{
            //if (this.IsCrash)
            //{
            //    FormJournalRequestForRepairAddEditAlarm formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEditAlarm(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Edit, this.IsCrash);
            //    formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            //    formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
            //    formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
            //    formJournalRequestForRepairAddEdit.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
            //    formJournalRequestForRepairAddEdit.Show();
            //}
            //else
            //{
            //    FormJournalRequestForRepairAddEdit formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEdit(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Edit, this.IsCrash);
            //    formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            //    formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
            //    formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
            //    formJournalRequestForRepairAddEdit.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
            //    formJournalRequestForRepairAddEdit.Show();
            //}
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
				if (Convert.ToInt32(this.dgv.CurrentRow.Cells[this.iddivisionDataGridViewTextBoxColumn.Name].Value) == ODS_DIVISION )
				{
					this.DocumentRead();
					return;
				}
				//FormJournalRequestForRepairAddEditPL form = new FormJournalRequestForRepairAddEditPL(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Read, false);
				//form.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
				//form.SqlSettings = this.SqlSettings;
				//form.MdiParent = base.MdiParent;
				//form.Show();
			}
		}
        /// <summary>
        /// чтение документа новой формой
        /// </summary>
		private void DocumentRead()
		{
            //if (this.IsCrash)
            //{
            //    FormJournalRequestForRepairAddEditAlarm formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEditAlarm(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Read, false);
            //    formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            //    formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
            //    formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
            //    formJournalRequestForRepairAddEdit.Show();

            //}
            //else
            //{
            //    FormJournalRequestForRepairAddEdit formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEdit(Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value), -1, eActionRequestRepair.Read, false);
            //    formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
            //    formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
            //    formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
            //    formJournalRequestForRepairAddEdit.Show();
            //}
		}

		private void toolBtnDelRequestRepair_Click(object sender, EventArgs e)
		{
			//if (this.dgv.SelectedRows.Count == 0)
			//{
			//	return;
			//}
			//if (MessageBox.Show("Вы действительно хотите удалить выделенные заявки?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			//{
			//	string text = "";
			//	foreach (DataGridViewRow dataGridViewRow in this.dgv.SelectedRows)
			//	{
			//		text = text + dataGridViewRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value.ToString() + ",";
			//	}
			//	base.SelectSqlData(this.DataSetNotifications, this.DataSetNotifications.tJ_RequestForRepair, true, "where id in (" + text.Remove(text.Length - 1) + ")");
			//	List<int> list = new List<int>();
			//	foreach (DataRow dataRow in this.DataSetNotifications.tJ_RequestForRepair.Rows)
   //             {
   //                 if (dataRow["Status"] != DBNull.Value)
   //                 {
   //                     MessageBox.Show("Заявку №" + dataRow["num"].ToString() + " невозможно удалить.\r\nНевозможно удалить зарегистрированные заявки.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Hand);
   //                     list.Add(Convert.ToInt32(dataRow["id"]));
   //                 }
   //                 else
   //                 if ((dataRow["isSend"] != DBNull.Value && Convert.ToBoolean(dataRow["isSend"])) || (dataRow["SendSite"] != DBNull.Value && Convert.ToBoolean(dataRow["SendSite"])))
   //                 {
   //                     MessageBox.Show("Заявку №" + dataRow["num"].ToString() + " невозможно удалить.\r\nНевозможно удалить отправленные заявки.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Hand);
   //                     list.Add(Convert.ToInt32(dataRow["id"]));
   //                 }
   //                 else
   //                 {
   //                     int idReqForRepair = Convert.ToInt32(dataRow["id"]);
   //                     SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
   //                     DataTable dataTable = sqlDataCommand.SelectSqlData(string.Format("with  tree (id, isApply, level)\r\n                                                as (select id, isApply,  0 as level  from tj_damage\r\n\t                                                where idReqForRepair = {0}\r\n\t                                                union all \r\n\t                                                select tj_damage.id, tJ_Damage.isApply, level+1\r\n\t                                                from tj_damage\t\r\n\t\t                                                inner join tree on tree.id = tj_damage.idParent \r\n\t\t                                            )\r\n\r\n                                                select * from tree\r\n                                                where isApply = 1", idReqForRepair));
   //                     if (dataTable.Rows.Count > 0)
   //                     {
   //                         MessageBox.Show("Заявку №" + dataRow["num"].ToString() + " невозможно удалить.\r\nУ данной заявки есть согласованные дочерние документы.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Hand);
   //                         list.Add(Convert.ToInt32(dataRow["id"]));
   //                     }
   //                     else
   //                     {
   //                         dataTable = sqlDataCommand.SelectSqlData(string.Format("with  tree (id,  isApply, nameDOC)\r\n                                                as (select id,  isApply, typeDocname + isnull(' №' + numRequest, '') + \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\tisnull(' от ' + CONVERT(VARCHAR(10),datedoc,104), '')\r\n\t\t\t\t\t\t\t\t\t\t\t\t   from vj_damage\r\n\t                                                where idReqForRepair = {0}\r\n\t                                                union all \r\n\t                                                select v.id, v.isApply, v.typeDocName+ isnull(' №' + v.numRequest, '') + \r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tisnull(' от ' + CONVERT(VARCHAR(10),v.datedoc,104), '')\r\n\t                                                from vj_damage\tv\r\n\t\t                                                inner join tree on tree.id = v.idParent \r\n\t\t                                            )\r\n                                                    select * from tree", idReqForRepair));
   //                         if (dataTable.Rows.Count > 0)
   //                         {
   //                             string text2 = "";
   //                             string text3 = "";
   //                             foreach (DataRow dataRow2 in dataTable.Rows)
   //                             {
   //                                 if (string.IsNullOrEmpty(text2))
   //                                 {
   //                                     text2 = dataRow2["nameDoc"].ToString();
   //                                 }
   //                                 else
   //                                 {
   //                                     text2 = text2 + "\r\n" + dataRow2["nameDoc"].ToString();
   //                                 }
   //                                 if (string.IsNullOrEmpty(text3))
   //                                 {
   //                                     text3 = dataRow2["id"].ToString();
   //                                 }
   //                                 else
   //                                 {
   //                                     text3 = text3 + "," + dataRow2["id"].ToString();
   //                                 }
   //                             }
   //                             if (MessageBox.Show(string.Format("Вы действительно хотите удалить заявку №{0}?\r\nУ данной заявки есть следующие дочерние документы:\r\n{1}", dataRow["num"].ToString(), text2), "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
   //                             {
   //                                 list.Add(Convert.ToInt32(dataRow["id"]));
   //                                 continue;
   //                             }
   //                             sqlDataCommand.UpdateSqlData(new DataTable("tJ_damage"), "set deleted = 1", "where id in (" + text3 + ")");
   //                         }
   //                         dataRow["deleted"] = true;
   //                         dataRow.EndEdit();
   //                     }
   //                 }
   //             }
   //             base.UpdateSqlData(this.DataSetNotifications, this.DataSetNotifications.tJ_RequestForRepair);
			//	foreach (DataGridViewRow dataGridViewRow2 in this.dgv.SelectedRows)
			//	{
			//		if (!list.Contains(Convert.ToInt32(dataGridViewRow2.Cells[this.idDataGridViewTextBoxColumn.Name].Value)))
			//		{
			//			this.dgv.Rows.Remove(dataGridViewRow2);
			//		}
			//	}
			//}
		}

        /// <summary>
        /// копирование документа новой формой
        /// </summary>
        /// <param name="row"></param>
		private void DocumentCopy(DataRow row)
		{
   //         FormJournalRequestForRepairAddEdit formJournalRequestForRepairAddEdit = new FormJournalRequestForRepairAddEdit(row);
			//formJournalRequestForRepairAddEdit.GoToSchema += new GoToSchemaEventHandler(this.f_GoToSchema);
			//formJournalRequestForRepairAddEdit.SqlSettings = this.SqlSettings;
			//formJournalRequestForRepairAddEdit.MdiParent = base.MdiParent;
			//formJournalRequestForRepairAddEdit.FormClosed += new FormClosedEventHandler(this.f_FormClosed);
			//formJournalRequestForRepairAddEdit.Show();
		}

		private void toolBrnRefresh_Click(object sender, EventArgs e)
		{
			this.LoadData();
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
				//if (Convert.ToBoolean(this.dgv[this.agreedDgvColumn.Name, e.RowIndex].Value))
				//{
				//	e.CellStyle.BackColor = Color.LightGreen;
				//}
				if (Convert.ToInt32(this.dgv[this.iddivisionDataGridViewTextBoxColumn.Name, e.RowIndex].Value) == PL_DIVISION)
				{
					e.CellStyle.BackColor = Color.LightGray;
				}
                else if (Convert.ToInt32(this.dgv[this.iddivisionDataGridViewTextBoxColumn.Name, e.RowIndex].Value) == NO_DIVISION)
                {
                    e.CellStyle.BackColor = Color.LightCyan;
                }
    //            if (this.dgv[this.isSendDgvColumn.Name, e.RowIndex].Value != DBNull.Value && this.dgv.Columns[e.ColumnIndex] == this.numDataGridViewTextBoxColumn)
				//{
				//	if (!Convert.ToBoolean(this.dgv[this.isSendDgvColumn.Name, e.RowIndex].Value))
				//	{
				//		e.CellStyle.BackColor = Color.Red;
				//	}
				//	else
				//	{
				//		e.CellStyle.BackColor = Color.Green;
				//	}
				//}
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

			this.sortString = this.bsNotificationOfRepairs.Sort;
            try
            {
                this.bsNotificationOfRepairs.Sort = string.Empty;
                this.bsNotificationOfRepairs.DataMember = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
			this.backgroundWorker.RunWorkerAsync(idDamage);
		}

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
		{
            string textBeg = "'" + this.dateTimePickerBeg.Value.Date.ToString("yyyyMMdd") + "'";
            string textEnd = "'" + this.dateTimePickerEnd.Value.ToString("yyyyMMdd HH:mm:ss") + "'";
            string textWhere = string.Concat(new string[] { " ((dateBeg <= ", textEnd, " and dateEnd >= ", textBeg, "))" });
            textWhere = string.Format(" (id in (select idNotification from tJ_NotificationOfRepairsDaily where {0})) ", textWhere);
            textWhere = string.Concat(new string[] { " where ", textWhere, "   and deleted = 0 order by datecreate desc" });

            base.SelectSqlData(this.DataSetNotifications, this.DataSetNotifications.vJ_RequestForRepair, true, textWhere);

            e.Result = e.Argument;
        }

		private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
            this.toolStrip.Enabled = true;
            this.splitContainer.Enabled = true;
            this.bsNotificationOfRepairs.DataMember = this.DataSetNotifications.vJ_NotificationOfRepairs.TableName;
            this.bsNotificationOfRepairs.Sort = this.sortString;
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



		private void splitContainerDgvBuild()
		{

				this.splitContainerDgv.SplitterDistance = this.splitContainerDgv.Height - this.splitContainerDgv.SplitterWidth - this.lbChildDoc.Height;
				this.splitContainerDgv.IsSplitterFixed = true;
				return;

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

		private void bsNotificationOfRepairs_CurrentChanged(object sender, EventArgs e)
		{

            this.DataSetNotifications.vJ_RequestForRepair.Clear();
            if (this.bsNotificationOfRepairs.Current != null && this.bsNotificationOfRepairs.Current is DataRowView)
            {
                int idReqForRepair = Convert.ToInt32(((DataRowView)this.bsNotificationOfRepairs.Current).Row["idRequestForRepair"]);
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
                    {
                        sqlConnection.Open();
                        using (SqlCommand sqlCommand = new SqlCommand(string.Format(" " +
            " with  tree (num, dateCreate, TypeDocName, TYpeDoc, schmObj, id) " +
            " as (select num, dateCreate, {2}, {1}, schmObj, id  " +
            " from vJ_RequestForRepair " +
            " where id = {0}" +
            " union all " +
            " select v.num, v.dateCreate, TypeDocName={2}, typeDoc = {1}, v.schmObj, v.id " +
            " from vJ_RequestForRepair v" +
            " inner join tree on tree.id = v.id)" +
            " select * from tree", idReqForRepair, TypeDocRequest, TypeDocNameRequest), sqlConnection))
                        {
                            new SqlDataAdapter(sqlCommand).Fill(this.DataSetNotifications.vJ_RequestForRepair);
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

        private void dgvRequestDefaultValuesNeeded(object sender,   System.Windows.Forms.DataGridViewRowEventArgs e)
        {
            e.Row.Cells["typeDocNameDataGridViewTextBoxColumn"].Value = "Заявки на ремонт";
        }
    }
}
