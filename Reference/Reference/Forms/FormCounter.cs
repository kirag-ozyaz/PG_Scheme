using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using Reference.Properties;

namespace Reference.Forms
{
	public partial class FormCounter : FormBase
	{
		public FormCounter()
		{
			
			
			this.InitializeComponent();
		}

		private void FormCounter_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class37_0, this.class37_0.tR_MarkMeter, true);
			this.bindingSource_0.Filter = (this.toolBtnShowDelete.Checked ? "" : "Deleted = false");
		}

		private void FormCounter_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keys = e.Modifiers;
			if (keys != Keys.None)
			{
				if (keys == Keys.Control)
				{
					keys = e.KeyCode;
					if (keys <= Keys.Delete)
					{
						if (keys == Keys.Insert)
						{
							this.toolBtnAdd_Click(sender, e);
							return;
						}
						if (keys != Keys.Delete)
						{
							return;
						}
						this.toolBtnDel_Click(sender, e);
						return;
					}
					else
					{
						if (keys == Keys.C)
						{
							this.dgvCounter.CopyToBuffer(false);
							return;
						}
						if (keys == Keys.F)
						{
							this.toolStripTextBoxFind.Focus();
							return;
						}
						if (keys != Keys.P)
						{
							return;
						}
						this.dgvCounter.PrintDataGridView();
						return;
					}
				}
			}
			else
			{
				keys = e.KeyCode;
				if (keys == Keys.F2)
				{
					this.toolBtnEdit_Click(sender, e);
				}
			}
		}

		private void toolBtnAdd_Click(object sender, EventArgs e)
		{
			if (new FormCounterAddEdit(-1, true)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class37_0, this.class37_0.tR_MarkMeter, true);
			}
		}

		private void toolBtnEdit_Click(object sender, EventArgs e)
		{
			int num = Convert.ToInt32(this.dgvCounter.CurrentRow.Cells["idDgvTextBoxColumn"].Value);
			if (new FormCounterAddEdit(num, false)
			{
				SqlSettings = this.SqlSettings
			}.ShowDialog() == DialogResult.OK)
			{
				base.SelectSqlData(this.class37_0, this.class37_0.tR_MarkMeter, true);
				this.dgvCounter.CurrentCell = this.dgvCounter["nameDgvTextBoxColumn", this.method_0(this.dgvCounter, "idDgvTextBoxColumn", num)];
			}
		}

		private int method_0(DataGridViewExcelFilter dataGridViewExcelFilter_0, string string_0, int int_0)
		{
			foreach (object obj in ((IEnumerable)dataGridViewExcelFilter_0.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (Convert.ToInt32(dataGridViewRow.Cells[string_0].Value) == int_0)
				{
					return dataGridViewRow.Index;
				}
			}
			return 0;
		}

		private void toolBtnDel_Click(object sender, EventArgs e)
		{
			if (this.dgvCounter.CurrentRow == null)
			{
				return;
			}
			bool flag;
			if (Convert.ToBoolean(this.dgvCounter.CurrentRow.Cells["deletedDgvCheckBoxColumn"].Value))
			{
				if (MessageBox.Show("Вы действительно хотите отменить пометку на удаление?", "Отмена удаления", MessageBoxButtons.YesNo) != DialogResult.Yes)
				{
					return;
				}
				this.dgvCounter.CurrentRow.Cells["deletedDgvCheckBoxColumn"].Value = false;
				flag = false;
			}
			else
			{
				if (MessageBox.Show("Вы действительно хотите поменить на удаление выбранную запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
				{
					return;
				}
				this.dgvCounter.CurrentRow.Cells["deletedDgvCheckBoxColumn"].Value = true;
				flag = true;
			}
			((DataRowView)this.dgvCounter.CurrentRow.DataBoundItem).EndEdit();
			if (base.UpdateSqlData(this.class37_0, this.class37_0.tR_MarkMeter))
			{
				base.SelectSqlData(this.class37_0, this.class37_0.tR_MarkMeter, true);
				if (flag)
				{
					MessageBox.Show("Выбранный элемент помечен на удаление");
					return;
				}
				MessageBox.Show("Пометка на удаления успешна снята");
			}
		}

		private void Ipikrulrju_Click(object sender, EventArgs e)
		{
			if (this.dgvCounter.CurrentRow == null)
			{
				return;
			}
			if (MessageBox.Show("Вы действительно хотите удалить выбранный счетчик?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				this.dgvCounter.Rows.Remove(this.dgvCounter.CurrentRow);
				this.dgvCounter.EndEdit();
				base.DeleteSqlData(this.class37_0, this.class37_0.tR_MarkMeter);
				MessageBox.Show("Данные успешно удалены");
			}
		}

		private void toolBtnShowDelete_Click(object sender, EventArgs e)
		{
			if (this.toolBtnShowDelete.Checked)
			{
				this.bindingSource_0.Filter = "";
				return;
			}
			this.bindingSource_0.Filter = "Deleted = false";
		}

		private void toolStripButtonFind_Click(object sender, EventArgs e)
		{
			this.dgvCounter.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonFindPrev_Click(object sender, EventArgs e)
		{
			this.dgvCounter.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonFindNext_Click(object sender, EventArgs e)
		{
			this.dgvCounter.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.toolStripTextBoxFind.Text);
		}

		private void toolStripButtonPrint_Click(object sender, EventArgs e)
		{
			this.dgvCounter.PrintDataGridView();
		}

		private void toolStripButtonExportExcel_Click(object sender, EventArgs e)
		{
			this.dgvCounter.CopyToExcel(true);
		}

		private void toolStripButtonRefresh_Click(object sender, EventArgs e)
		{
			base.SelectSqlData(this.class37_0, this.class37_0.tR_MarkMeter, true);
		}

		private void dgvCounter_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && Convert.ToBoolean(this.dgvCounter["deletedDgvCheckBoxColumn", e.RowIndex].Value))
			{
				e.CellStyle.ForeColor = Color.Red;
			}
		}

		private void toolMenuItemAdd_Click(object sender, EventArgs e)
		{
			this.toolBtnAdd_Click(sender, e);
		}

		private void PyBctgfHr8(object sender, EventArgs e)
		{
			this.toolBtnEdit_Click(sender, e);
		}

		private void toolStripMenuItemDelCheck_Click(object sender, EventArgs e)
		{
			this.toolBtnDel_Click(sender, e);
		}

		private void toolStripMenuItemDelFull_Click(object sender, EventArgs e)
		{
			this.Ipikrulrju_Click(sender, e);
		}

		private void toolMenuItemCopy_Click(object sender, EventArgs e)
		{
			this.dgvCounter.CopyToBuffer(false);
		}

		private void toolMenuItemExportToExcel_Click(object sender, EventArgs e)
		{
			this.dgvCounter.CopyToExcel(false);
		}

		private void toolMenuItemPrint_Click(object sender, EventArgs e)
		{
			this.dgvCounter.PrintDataGridView();
		}

		private void toolStripMenuItemSavePicture_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Сохранить картинку как ...";
			saveFileDialog.OverwritePrompt = true;
			saveFileDialog.CheckPathExists = true;
			saveFileDialog.Filter = "Bitmap File(*.bmp)|*.bmp|GIF File(*.gif)|*.gif|JPEG File(*.jpg)|*.jpg|TIF File(*.tif)|*.tif|PNG File(*.png)|*.png";
			saveFileDialog.ShowHelp = true;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string fileName = saveFileDialog.FileName;
				string a = fileName.Remove(0, fileName.Length - 3);
				if (a == "bmp")
				{
					this.pictureBox.Image.Save(fileName, ImageFormat.Bmp);
					return;
				}
				if (a == "jpg")
				{
					this.pictureBox.Image.Save(fileName, ImageFormat.Jpeg);
					return;
				}
				if (a == "gif")
				{
					this.pictureBox.Image.Save(fileName, ImageFormat.Gif);
					return;
				}
				if (a == "tif")
				{
					this.pictureBox.Image.Save(fileName, ImageFormat.Tiff);
					return;
				}
				if (!(a == "png"))
				{
					return;
				}
				this.pictureBox.Image.Save(fileName, ImageFormat.Png);
			}
		}
	}
}
