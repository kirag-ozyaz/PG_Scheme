using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
//using JournalCalcLoss.Report;
//using Documents.Properties;
using FormLbr;
/// <summary>
/// Журнал расчетов потерь
/// </summary>
	public partial class FormJournalCalcLoss : FormBase
	{
        private int Id;
        public FormJournalCalcLoss()
		{
			this.Id = -1;
			this.InitializeComponent();
		}

		private void FormJournalCalcLoss_Load(object sender, EventArgs e)
		{
			this.LoadTableJournalCalcLoss();
			base.SelectSqlData(this.dsCalcN.tR_Classifier, true, "where ParentKey = ';TypeDoc;tJ_CalcLoss;' and isGroup = 0 and deleted = 0 order by name", null, false, 0);
			foreach (DataRow dataRow in this.dsCalcN.tR_Classifier)
			{
				ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem(dataRow["Name"].ToString());
				toolStripMenuItem.Tag = dataRow["id"];
				this.toolBtnAddCalc.DropDownItems.Add(toolStripMenuItem);
				toolStripMenuItem.Click +=new EventHandler( this.toolStripMenuItem_Click);
			}
		}

		private void LoadTableJournalCalcLoss()
		{
			base.SelectSqlData(this.dsCalcN.vJ_CalcLoss, true, "where isActive = 1 and deleted = 0 order by dateCalc desc, num desc", null, false, 0);
			this.dgvCalcLoss.SearchGrid(this.idDgvColumn.Name, this.Id.ToString(), false);
		}

		private void toolStripMenuItem_Click(object sender, EventArgs e)
		{
			int typeCalc = Convert.ToInt32(((ToolStripMenuItem)sender).Tag);
            if (typeCalc == (int)Constants.TypeCalcLoss.TypeTrans)
            {
                FormAddEditCalcTrans formAddEditCalcTrans = new FormAddEditCalcTrans(-1, typeCalc, -1, -1);
                formAddEditCalcTrans.MdiParent = base.MdiParent;
                formAddEditCalcTrans.SqlSettings = this.SqlSettings;
                formAddEditCalcTrans.FormClosed += new FormClosedEventHandler(this.formAddEditCalcTrans_FormClosed);
                formAddEditCalcTrans.Show();
            }
            else
            {
                FormAddEditCalcCable formAddEditCalcCable = new FormAddEditCalcCable(-1, typeCalc, -1, -1);
                formAddEditCalcCable.MdiParent = base.MdiParent;
                formAddEditCalcCable.SqlSettings = this.SqlSettings;
                formAddEditCalcCable.FormClosed += new FormClosedEventHandler(this.formAddEditCalcTrans_FormClosed);
                formAddEditCalcCable.Show();
            }
		}

		private void formAddEditCalcTrans_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (((Form)sender).DialogResult == DialogResult.OK)
			{
				if (sender is FormAddEditCalcCable)
				{
					this.Id = ((FormAddEditCalcCable)sender).Id;
				}
				if (sender is FormAddEditCalcTrans)
				{
					this.Id = ((FormAddEditCalcTrans)sender).Id;
				}
				this.LoadTableJournalCalcLoss();
			}
        }

        private void toolBtnEditCalc_Click(object sender, EventArgs e)
        {
            if (this.dgvCalcLoss.CurrentRow != null)
            {
                int typeCalc = Convert.ToInt32(this.dgvCalcLoss.CurrentRow.Cells[this.idTypeCalcDgvColumn.Name].Value);
                int idCalc = Convert.ToInt32(this.dgvCalcLoss.CurrentRow.Cells[this.idDgvColumn.Name].Value);
                if (typeCalc == (int)Constants.TypeCalcLoss.TypeTrans)
                {
                    FormAddEditCalcTrans formAddEditCalcTrans = new FormAddEditCalcTrans(idCalc, typeCalc, -1, -1);
                    formAddEditCalcTrans.MdiParent = base.MdiParent;
                    formAddEditCalcTrans.SqlSettings = this.SqlSettings;
                    formAddEditCalcTrans.FormClosed += new FormClosedEventHandler(this.formAddEditCalcTrans_FormClosed);
                    formAddEditCalcTrans.Show();
                }
                else
                {
                    FormAddEditCalcCable formAddEditCalcCable = new FormAddEditCalcCable(idCalc, typeCalc, -1, -1);
                    formAddEditCalcCable.MdiParent = base.MdiParent;
                    formAddEditCalcCable.SqlSettings = this.SqlSettings;
                    formAddEditCalcCable.FormClosed += new FormClosedEventHandler(this.formAddEditCalcTrans_FormClosed);
                    formAddEditCalcCable.Show();
                }
            }
        }



        private void dgvCalcLoss_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (this.toolBtnEditCalc.Enabled && this.toolBtnEditCalc.Visible && e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				this.toolBtnEditCalc_Click(sender, e);
			}
		}

		private void toolBtnDelCalc_Click(object sender, EventArgs e)
		{
			if (this.dgvCalcLoss.SelectedRows.Count > 0)
			{
				if (MessageBox.Show("Вы действительно хотите удалить выбранные записи?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					string ids = "";
					foreach (DataGridViewRow dataGridViewRow in this.dgvCalcLoss.SelectedRows)
					{
						if (string.IsNullOrEmpty(ids))
						{
							ids = dataGridViewRow.Cells[this.idDgvColumn.Name].Value.ToString();
						}
						else
						{
							ids = ids + "," + dataGridViewRow.Cells[this.idDgvColumn.Name].Value.ToString();
						}
					}
					base.SelectSqlData(this.dsCalcN.tJ_CalcLoss, true, "where id in (" + ids + ")", null, false, 0);
					foreach (DataRow row in this.dsCalcN.tJ_CalcLoss)
					{
						row["deleted"] = 1;
						row.EndEdit();
					}
					base.UpdateSqlData(this.dsCalcN, this.dsCalcN.tJ_CalcLoss);
					this.LoadTableJournalCalcLoss();
					MessageBox.Show("Записи успешно удалены");
					return;
				}
			}
			else
			{
				MessageBox.Show("Выделите строки для удаления");
			}
		}

		private void toolBtnReport_Click(object sender, EventArgs e)
		{
			if (this.Id != -1 && this.dgvCalcLoss.CurrentRow != null)
			{
				if (Convert.ToInt32(this.dgvCalcLoss.CurrentRow.Cells[this.idTypeCalcDgvColumn.Name].Value) == (int)Constants.TypeCalcLoss.TypeTrans)
				{
					new FormReportCalcLossTrans(this.Id)
					{
						MdiParent = base.MdiParent,
						SqlSettings = this.SqlSettings
					}.Show();
					return;
				}
				new FormReportCalcLoss(this.Id)
				{
					MdiParent = base.MdiParent,
					SqlSettings = this.SqlSettings
				}.Show();
			}
		}

		private void toolBtnRefresh_Click(object sender, EventArgs e)
		{
			this.LoadTableJournalCalcLoss();
		}

		private void bindingSourceCalcLoss_CurrentChanged(object sender, EventArgs e)
		{
			if (this.bindingSourceCalcLoss.Current != null)
			{
				this.Id = Convert.ToInt32(((DataRowView)this.bindingSourceCalcLoss.Current)["id"]);
				return;
			}
			this.Id = -1;
		}
	}
