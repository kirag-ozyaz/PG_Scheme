using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Reference.Properties;

namespace Reference.Forms
{
	public partial class FormJobTitles : FormBase
	{
		public FormJobTitles()
		{
			
			
			this.InitializeComponent();
		}

		private void FormJobTitles_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tR_JobTitle"], true);
			this.toolBtnAdd.Visible = false;
			this.toolBtnEdit.Visible = false;
			this.toolBtnDel.Visible = false;
			this.ErfjNoVmLp.Visible = false;
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
					e.Value = this.imageList_0.Images["ElementDelete.png"];
					return;
				}
				e.Value = this.imageList_0.Images["Element.png"];
			}
		}

		private void ErfjNoVmLp_Click(object sender, EventArgs e)
		{
			this.formJobTitlesAddEdit_0 = new FormJobTitlesAddEdit();
			this.formJobTitlesAddEdit_0.SqlSettings = this.SqlSettings;
			this.formJobTitlesAddEdit_0.MdiParent = base.MdiParent;
			this.formJobTitlesAddEdit_0.method_1(0);
			this.formJobTitlesAddEdit_0.Show();
			this.formJobTitlesAddEdit_0.FormClosed -= this.formJobTitlesAddEdit_0_FormClosed;
			this.formJobTitlesAddEdit_0.FormClosed += this.formJobTitlesAddEdit_0_FormClosed;
		}

		private void toolMenuEdit_Click(object sender, EventArgs e)
		{
			if (this.dgvExcelFilter.CurrentRow == null)
			{
				return;
			}
			int int_ = Convert.ToInt32(this.dgvExcelFilter.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
			this.formJobTitlesAddEdit_0 = new FormJobTitlesAddEdit(int_);
			this.formJobTitlesAddEdit_0.SqlSettings = this.SqlSettings;
			this.formJobTitlesAddEdit_0.MdiParent = base.MdiParent;
			this.formJobTitlesAddEdit_0.method_1(1);
			this.formJobTitlesAddEdit_0.Show();
			this.formJobTitlesAddEdit_0.FormClosed -= this.formJobTitlesAddEdit_0_FormClosed;
			this.formJobTitlesAddEdit_0.FormClosed += this.formJobTitlesAddEdit_0_FormClosed;
		}

		private void formJobTitlesAddEdit_0_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.formJobTitlesAddEdit_0.DialogResult == DialogResult.OK)
			{
				base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tR_JobTitle"], true);
			}
		}

		private void toolMenuDelRestore_Click(object sender, EventArgs e)
		{
			if (this.dgvExcelFilter.CurrentRow == null)
			{
				return;
			}
			int num = Convert.ToInt32(this.dgvExcelFilter.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
			DataRow[] array = this.dataSet_0.Tables["tR_JobTitle"].Select("id = " + num.ToString());
			array[0]["deleted"] = !(bool)array[0]["deleted"];
			array[0].EndEdit();
			if (!base.UpdateSqlDataOnlyChange(this.dataSet_0.Tables["tR_JobTitle"]))
			{
				MessageBox.Show("не удалось изменить состояние записи");
				return;
			}
			base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tR_JobTitle"], true);
		}

		private void toolMenuDelFull_Click(object sender, EventArgs e)
		{
			if (this.dgvExcelFilter.CurrentRow == null)
			{
				return;
			}
			int id = Convert.ToInt32(this.dgvExcelFilter.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
			if (!base.DeleteSqlDataById(this.dataSet_0.Tables["tR_JobTitle"], id))
			{
				MessageBox.Show("не удалось удалить строку из БД");
				return;
			}
			base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tR_JobTitle"], true);
		}

		private void FdarTkgxvQ(object sender, EventArgs e)
		{
			if (this.toolStripButtonHideDeleted.Checked)
			{
				this.bindingSource_0.Filter = this.bindingSource_0.Filter.Replace("Deleted = false AND ", string.Empty);
				this.bindingSource_0.Filter = this.bindingSource_0.Filter.Replace(" AND Deleted = false", string.Empty);
				this.bindingSource_0.Filter = this.bindingSource_0.Filter.Replace("Deleted = false", string.Empty);
				this.toolStripButtonHideDeleted.Text = "Скрыть удаленные записи";
				return;
			}
			if (this.bindingSource_0.Filter.Length > 0)
			{
				BindingSource bindingSource = this.bindingSource_0;
				bindingSource.Filter += " AND Deleted = false";
			}
			else
			{
				BindingSource bindingSource2 = this.bindingSource_0;
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
			base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables["tR_JobTitle"], true);
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
			if (this.formJobTitlesAddEdit_0 != null)
			{
				this.formJobTitlesAddEdit_0.DialogResult = DialogResult.Cancel;
				this.formJobTitlesAddEdit_0.Close();
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

		private FormJobTitlesAddEdit formJobTitlesAddEdit_0;
	}
}
