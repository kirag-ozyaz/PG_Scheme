using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Constants;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;


namespace ReferenceWorker
{
	public partial class FormJobTitles : FormBase
	{
        string TableName = "k_tR_JobTitle";
		public FormJobTitles()
		{
			this.InitializeComponent();
		}

		private void FormJobTitles_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dataSet, this.dataSet.Tables[TableName], true);
			this.toolBtnAdd.Visible = false;
			this.toolBtnEdit.Visible = false;
			this.toolBtnDel.Visible = false;
			this.toolMenuAdd.Visible = false;
			this.toolMenuEdit.Visible = false;
			this.toolMenuDelRestore.Visible = false;
			this.toolMenuDelFull.Visible = false;
			this.toolStripSeparator6.Visible = false;
		}

		private void dgvExcelFilter_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			if (this.dgvExcelFilter.RowCount > 0 && e.ColumnIndex == this.dgvExcelFilter.Columns["ColumnImage"].Index)
			{
				if (Convert.ToBoolean(this.dgvExcelFilter["deletedDgvCheckBoxColumn", e.RowIndex].Value))
				{
					e.Value = this.imageList1.Images["ElementDelete.png"];
					return;
				}
				e.Value = this.imageList1.Images["Element.png"];
			}
		}

		private void toolBtnAdd_Click(object sender, EventArgs e)
		{
			this.frm = new FormJobTitlesAddEdit();
			this.frm.SqlSettings = this.SqlSettings;
			this.frm.MdiParent = base.MdiParent;
			this.frm.status = StateFormCreate.Add;
			this.frm.Show();
			this.frm.FormClosed -= this.formJobTitlesAddEdit_FormClosed;
			this.frm.FormClosed += this.formJobTitlesAddEdit_FormClosed;
		}

		private void toolMenuEdit_Click(object sender, EventArgs e)
		{
			if (this.dgvExcelFilter.CurrentRow == null)
			{
				return;
			}
			int id = Convert.ToInt32(this.dgvExcelFilter.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
			this.frm = new FormJobTitlesAddEdit(id);
			this.frm.SqlSettings = this.SqlSettings;
			this.frm.MdiParent = base.MdiParent;
			this.frm.status = StateFormCreate.Edit;
            this.frm.Show();
			this.frm.FormClosed -= this.formJobTitlesAddEdit_FormClosed;
			this.frm.FormClosed += this.formJobTitlesAddEdit_FormClosed;
		}

		private void formJobTitlesAddEdit_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.frm.DialogResult == DialogResult.OK)
			{
				base.SelectSqlData(this.dataSet, this.dataSet.Tables[TableName], true);
			}
		}

		private void toolMenuDelRestore_Click(object sender, EventArgs e)
		{
			if (this.dgvExcelFilter.CurrentRow == null)
			{
				return;
			}
			int id = Convert.ToInt32(this.dgvExcelFilter.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
			DataRow[] array = this.dataSet.Tables[TableName].Select("id = " + id.ToString());
			array[0]["deleted"] = !(bool)array[0]["deleted"];
			array[0].EndEdit();
			if (!base.UpdateSqlDataOnlyChange(this.dataSet.Tables[TableName]))
			{
				MessageBox.Show("не удалось изменить состояние записи");
				return;
			}
			base.SelectSqlData(this.dataSet, this.dataSet.Tables[TableName], true);
		}

		private void toolMenuDelFull_Click(object sender, EventArgs e)
		{
			if (this.dgvExcelFilter.CurrentRow == null)
			{
				return;
			}
			int id = Convert.ToInt32(this.dgvExcelFilter.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
			if (!base.DeleteSqlDataById(this.dataSet.Tables[TableName], id))
			{
				MessageBox.Show("не удалось удалить строку из БД");
				return;
			}
			base.SelectSqlData(this.dataSet, this.dataSet.Tables[TableName], true);
		}

		private void FdarTkgxvQ(object sender, EventArgs e)
		{
			if (this.toolStripButtonHideDeleted.Checked)
			{
				this.bs_JobTitle.Filter = this.bs_JobTitle.Filter.Replace("Deleted = false AND ", string.Empty);
				this.bs_JobTitle.Filter = this.bs_JobTitle.Filter.Replace(" AND Deleted = false", string.Empty);
				this.bs_JobTitle.Filter = this.bs_JobTitle.Filter.Replace("Deleted = false", string.Empty);
				this.toolStripButtonHideDeleted.Text = "Скрыть удаленные записи";
				return;
			}
			if (this.bs_JobTitle.Filter.Length > 0)
			{
				BindingSource bindingSource = this.bs_JobTitle;
				bindingSource.Filter += " AND Deleted = false";
			}
			else
			{
				BindingSource bindingSource2 = this.bs_JobTitle;
				bindingSource2.Filter += "Deleted = false";
			}
			this.toolStripButtonHideDeleted.Text = "Показать удаленные записи";
		}

		private void jEsrCgOgu8(object sender, EventArgs e)
		{
			this.dgvExcelFilter.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonFindNext_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
		}

		private void toolStripTextBoxFind_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.dgvExcelFilter.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
			}
		}

		private void toolStripButtonPrint_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.PrintDataGridView();
		}

		private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.CopyToExcel(true);
		}

		private void toolStripButtonRefresh_Click(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dataSet, this.dataSet.Tables[TableName], true);
		}

		private void toolBtnPadez_Click(object sender, EventArgs e)
		{
			if (this.dgvExcelFilter.CurrentRow != null)
			{
				new FormJobTitleAddEditPadez(Convert.ToInt32(this.dgvExcelFilter.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value))
				{
					SqlSettings = this.SqlSettings
				}.ShowDialog();
			}
		}

		private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.CopyToBuffer(false);
		}

		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.CopyToExcel(false);
		}

		private void toolStripMenuItemPrint_Click(object sender, EventArgs e)
		{
			this.dgvExcelFilter.PrintDataGridView();
		}

		private void FormJobTitles_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.frm != null)
			{
				this.frm.DialogResult = DialogResult.Cancel;
				this.frm.Close();
			}
		}

		private void dgvExcelFilter_CurrentCellChanged(object sender, EventArgs e)
		{
			if (this.dgvExcelFilter.CurrentRow == null)
			{
				return;
			}
			if (!Convert.ToBoolean(this.dgvExcelFilter.CurrentRow.Cells[this.deletedDgvCheckBoxColumn.Name].Value))
			{
				this.toolBtnDelRestore.Text = "Пометить на удаление";
				this.toolMenuDelRestore.Text = "Пометить на удаление";
				return;
			}
			this.toolBtnDelRestore.Text = "Восстановить";
			this.toolMenuDelRestore.Text = "Восстановить";
		}

		private FormJobTitlesAddEdit frm;
	}
}
