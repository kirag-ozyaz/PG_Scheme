using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;

namespace Reference.Forms
{
	public partial class FormKladrSocr : FormBase
	{
		public FormKladrSocr()
		{
			
			
			this.InitializeComponent();
		}

		private void FormKladrSocr_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class20_0, this.class20_0.tR_KladrSocr, true);
			this.bindingSource_0.Sort = "scname";
		}

		private void FormKladrSocr_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.class20_0.tR_KladrSocr.GetChanges() != null && MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.method_0();
			}
		}

		private void dgvKladrSocr_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if ((this.dgvKladrSocr.Columns[e.ColumnIndex].Name == "levelColumn" || this.dgvKladrSocr.Columns[e.ColumnIndex].Name == "scnameColumn" || this.dgvKladrSocr.Columns[e.ColumnIndex].Name == "socrnameColumn") && string.IsNullOrEmpty(e.FormattedValue.ToString()))
			{
				this.dgvKladrSocr.Rows[e.RowIndex].ErrorText = "Значение не может быть пустым";
				e.Cancel = true;
			}
		}

		private void dgvKladrSocr_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			this.dgvKladrSocr.Rows[e.RowIndex].ErrorText = string.Empty;
		}

		private void dgvKladrSocr_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
		{
			if ((this.dgvKladrSocr.Rows[e.RowIndex].Cells["levelColumn"].Value != null && !string.IsNullOrEmpty(this.dgvKladrSocr.Rows[e.RowIndex].Cells["levelColumn"].Value.ToString())) || (this.dgvKladrSocr.Rows[e.RowIndex].Cells["levelColumn"].Value != null && !string.IsNullOrEmpty(this.dgvKladrSocr.Rows[e.RowIndex].Cells["scnameColumn"].Value.ToString())) || (this.dgvKladrSocr.Rows[e.RowIndex].Cells["levelColumn"].Value != null && !string.IsNullOrEmpty(this.dgvKladrSocr.Rows[e.RowIndex].Cells["socrnameColumn"].Value.ToString())))
			{
				if (string.IsNullOrEmpty(this.dgvKladrSocr.Rows[e.RowIndex].Cells["levelColumn"].Value.ToString()) || string.IsNullOrEmpty(this.dgvKladrSocr.Rows[e.RowIndex].Cells["scnameColumn"].Value.ToString()) || string.IsNullOrEmpty(this.dgvKladrSocr.Rows[e.RowIndex].Cells["socrnameColumn"].Value.ToString()))
				{
					this.dgvKladrSocr.Rows[e.RowIndex].ErrorText = "Значение не может быть пустым";
					e.Cancel = true;
				}
				return;
			}
		}

		private void toolBtnAdd_Click(object sender, EventArgs e)
		{
			this.dgvKladrSocr.FirstDisplayedScrollingRowIndex = this.dgvKladrSocr.Rows.Count - 1;
			this.dgvKladrSocr.CurrentCell = this.dgvKladrSocr["levelColumn", this.dgvKladrSocr.Rows.Count - 1];
			this.dgvKladrSocr.BeginEdit(false);
		}

		private void toolBtnEdit_Click(object sender, EventArgs e)
		{
			this.dgvKladrSocr.Focus();
			this.dgvKladrSocr.BeginEdit(false);
		}

		private void toolBtnDel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы действительно хотите удалить выбранные записи?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				foreach (object obj in this.dgvKladrSocr.SelectedRows)
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					this.dgvKladrSocr.Rows.Remove(dataGridViewRow);
				}
			}
		}

		private void toolBtnSave_Click(object sender, EventArgs e)
		{
			this.method_0();
		}

		private void toolStripButtonFind_Click(object sender, EventArgs e)
		{
			this.dgvKladrSocr.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.toolStripTextBoxGrid.Text);
		}

		private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
		{
			this.dgvKladrSocr.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolStripTextBoxGrid.Text);
		}

		private void toolStripButtonFindNext_Click(object sender, EventArgs e)
		{
			this.dgvKladrSocr.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxGrid.Text);
		}

		private void toolStripTextBoxGrid_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.None && e.KeyCode == Keys.Return)
			{
				this.dgvKladrSocr.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxGrid.Text);
			}
		}

		private void toolStripButtonPrint_Click(object sender, EventArgs e)
		{
			this.dgvKladrSocr.PrintDataGridView();
		}

		private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
		{
			this.dgvKladrSocr.CopyToExcel(true);
		}

		private void toolStripButtonRefresh_Click(object sender, EventArgs e)
		{
			if (this.class20_0.tR_KladrSocr.GetChanges() != null && MessageBox.Show("Сохранить изменения?", "Сохранение", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.method_0();
			}
			base.SelectSqlData(this.class20_0, this.class20_0.tR_KladrSocr, true);
			this.bindingSource_0.Sort = "scname";
		}

		private void method_0()
		{
			base.Validate();
			this.dgvKladrSocr.EndEdit();
			base.InsertSqlData(this.class20_0, this.class20_0.tR_KladrSocr);
			base.UpdateSqlData(this.class20_0, this.class20_0.tR_KladrSocr);
			base.DeleteSqlData(this.class20_0, this.class20_0.tR_KladrSocr);
			this.class20_0.tR_KladrSocr.AcceptChanges();
		}

		private void toolMenuItemAdd_Click(object sender, EventArgs e)
		{
			this.toolBtnAdd_Click(sender, e);
		}

		private void toolMenuItemEdit_Click(object sender, EventArgs e)
		{
			this.toolBtnEdit_Click(sender, e);
		}

		private void toolMenuItemDel_Click(object sender, EventArgs e)
		{
			this.toolBtnDel_Click(sender, e);
		}

		private void toolMenuItemCopy_Click(object sender, EventArgs e)
		{
			this.dgvKladrSocr.CopyToBuffer(false);
		}

		private void toolMenuItemExport_Click(object sender, EventArgs e)
		{
			this.dgvKladrSocr.CopyToExcel(false);
		}

		private void toolMenuItemPrint_Click(object sender, EventArgs e)
		{
			this.dgvKladrSocr.PrintDataGridView();
		}
	}
}
