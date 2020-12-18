using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Properties;
using WinFormsUI.Docking;

namespace SchemeCtrl2.Canvas.Forms
{
	public class FormSchmObjFile : DockContentBase
	{
		public FormSchmObjFile()
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.method_0();
		}

		public FormSchmObjFile(DrawObjectBase obj)
		{
			Class90.TDroV38zslI2T();
			base..ctor();
			this.method_0();
			this.drawObjectBase_0 = obj;
			if (obj != null)
			{
				this.Text = "Файлы " + this.drawObjectBase_0.ToString();
			}
		}

		private void FormSchmObjFile_Load(object sender, EventArgs e)
		{
			if (this.drawObjectBase_0 != null && this.drawObjectBase_0.IdBase > 0)
			{
				base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables[this.dataTable_0.TableName], true, " where idObj = " + this.drawObjectBase_0.IdBase.ToString());
				this.toolStripButton_0.Enabled = !this.drawObjectBase_0.LimitedEditing;
				this.toolStripButton_1.Enabled = !this.drawObjectBase_0.LimitedEditing;
				this.dataGridViewTextBoxColumn_3.ReadOnly = this.drawObjectBase_0.LimitedEditing;
			}
			else
			{
				this.toolStrip_0.Enabled = false;
				this.dataGridViewExcelFilter_0.Enabled = false;
			}
			this.dataGridViewExcelFilter_0.CellValueChanged += this.dataGridViewExcelFilter_0_CellValueChanged;
		}

		private void toolStripButton_0_Click(object sender, EventArgs e)
		{
			try
			{
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Multiselect = true;
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					for (int i = 0; i < openFileDialog.FileNames.Length; i++)
					{
						DataRow dataRow = this.class22_0.tSchm_ObjFile.NewRow();
						dataRow["idObj"] = this.drawObjectBase_0.IdBase;
						dataRow["Document"] = File.ReadAllBytes(openFileDialog.FileNames[i]);
						dataRow["FileName"] = Path.GetFileName(openFileDialog.FileNames[i]);
						dataRow["DateIn"] = DateTime.Now;
						this.class22_0.tSchm_ObjFile.Rows.Add(dataRow);
						dataRow = this.dataSet_0.Tables[this.dataTable_0.TableName].NewRow();
						dataRow["idObj"] = this.drawObjectBase_0.IdBase;
						dataRow["FileName"] = Path.GetFileName(openFileDialog.FileNames[i]);
						dataRow["DateIn"] = DateTime.Now;
						this.dataSet_0.Tables[this.dataTable_0.TableName].Rows.Add(dataRow);
					}
				}
				base.InsertSqlData(this.class22_0, this.class22_0.tSchm_ObjFile);
				this.class22_0.tSchm_ObjFile.Clear();
				this.dataGridViewExcelFilter_0.CellValueChanged -= this.dataGridViewExcelFilter_0_CellValueChanged;
				base.SelectSqlData(this.dataSet_0, this.dataSet_0.Tables[this.dataTable_0.TableName], true, " where idObj = " + this.drawObjectBase_0.IdBase.ToString());
				this.dataGridViewExcelFilter_0.CellValueChanged += this.dataGridViewExcelFilter_0_CellValueChanged;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void toolStripButton_1_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.CurrentRow != null)
			{
				int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
				this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
				base.DeleteSqlDataById(this.class22_0.tSchm_ObjFile, num);
				return;
			}
			MessageBox.Show("Не выбрано ни одного файла");
		}

		private void toolStripButton_2_Click(object sender, EventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.CurrentRow == null)
			{
				return;
			}
			int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
			base.SelectSqlData(this.class22_0, this.class22_0.tSchm_ObjFile, true, " where id = " + num.ToString());
			if (this.class22_0.tSchm_ObjFile.Rows.Count > 0)
			{
				byte[] array = (byte[])this.class22_0.tSchm_ObjFile.Rows[0]["Document"];
				string text = Path.GetTempFileName();
				text = Path.ChangeExtension(text, Path.GetExtension(this.class22_0.tSchm_ObjFile.Rows[0]["FileName"].ToString()));
				FileStream fileStream = File.Create(text);
				fileStream.Write(array, 0, array.Length);
				fileStream.Close();
				new Process
				{
					StartInfo = 
					{
						FileName = text,
						UseShellExecute = true
					}
				}.Start();
			}
		}

		private void toolStripButton_3_Click(object sender, EventArgs e)
		{
			try
			{
				int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
				base.SelectSqlData(this.class22_0, this.class22_0.tSchm_ObjFile, true, " where id = " + num.ToString());
				if (this.class22_0.tSchm_ObjFile.Rows.Count > 0)
				{
					string text = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewLinkColumn_0.Name].Value.ToString();
					string extension = Path.GetExtension(text);
					SaveFileDialog saveFileDialog = new SaveFileDialog();
					saveFileDialog.Filter = "(*" + extension + ")|*" + extension;
					saveFileDialog.FileName = text;
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						byte[] array = (byte[])this.class22_0.tSchm_ObjFile.Rows[0]["Document"];
						FileStream fileStream = File.Create(saveFileDialog.FileName);
						fileStream.Write(array, 0, array.Length);
						fileStream.Close();
						MessageBox.Show("Файл успешно сохранен", "Сохранение");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		private void dataGridViewExcelFilter_0_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
			if (this.dataGridViewExcelFilter_0.RowCount > 0 && this.dataGridViewExcelFilter_0[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value != null && e.ColumnIndex == this.dataGridViewExcelFilter_0.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
			{
				Icon icon = FileInfo.IconOfFile(this.dataGridViewExcelFilter_0[this.dataGridViewLinkColumn_0.Name, e.RowIndex].Value.ToString());
				e.Value = icon.ToBitmap();
			}
		}

		private void dataGridViewExcelFilter_0_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == this.dataGridViewExcelFilter_0.Columns[this.dataGridViewLinkColumn_0.Name].Index)
			{
				this.toolStripButton_2_Click(sender, e);
			}
		}

		private void dataGridViewExcelFilter_0_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == this.dataGridViewExcelFilter_0.Columns[this.dataGridViewTextBoxColumn_3.Name].Index)
			{
				foreach (object obj in this.dataSet_0.Tables[this.dataTable_0.TableName].Rows)
				{
					DataRow dataRow = (DataRow)obj;
					if (dataRow.RowState != DataRowState.Detached && dataRow.RowState != DataRowState.Deleted)
					{
						dataRow.EndEdit();
					}
				}
				base.UpdateSqlData(this.dataSet_0, this.dataSet_0.Tables[this.dataTable_0.TableName]);
				this.dataSet_0.Tables[this.dataTable_0.TableName].AcceptChanges();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_0()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			this.toolStrip_0 = new ToolStrip();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripButton_3 = new ToolStripButton();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dataSet_0 = new DataSet();
			this.dataTable_0 = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.dataColumn_2 = new DataColumn();
			this.dataColumn_3 = new DataColumn();
			this.dataColumn_4 = new DataColumn();
			this.class22_0 = new Class22();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewLinkColumn_0 = new DataGridViewLinkColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.toolStrip_0.SuspendLayout();
			this.dataGridViewExcelFilter_0.BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_0).BeginInit();
			((ISupportInitialize)this.class22_0).BeginInit();
			base.SuspendLayout();
			this.toolStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripButton_2,
				this.toolStripButton_3
			});
			this.toolStrip_0.Location = new Point(0, 0);
			this.toolStrip_0.Name = "toolStrip";
			this.toolStrip_0.Size = new Size(634, 25);
			this.toolStrip_0.TabIndex = 0;
			this.toolStrip_0.Text = "toolStrip1";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = Resources.ElementAdd;
			this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_0.Name = "toolBtnFileAdd";
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Добавить файлы";
			this.toolStripButton_0.Click += this.toolStripButton_0_Click;
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = Resources.ElementDel;
			this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_1.Name = "toolBtnFileDelete";
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Удалить файлы";
			this.toolStripButton_1.Click += this.toolStripButton_1_Click;
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = Resources.ElementInformation;
			this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_2.Name = "toolBtnFileView";
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Просмотр файла";
			this.toolStripButton_2.Click += this.toolStripButton_2_Click;
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = Resources.ElementGo;
			this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
			this.toolStripButton_3.Name = "toolBtnFileSave";
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Сохранить файл";
			this.toolStripButton_3.Click += this.toolStripButton_3_Click;
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_0.BackgroundColor = SystemColors.Window;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewImageColumnNotNull_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewLinkColumn_0,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3
			});
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
			this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
			this.dataGridViewExcelFilter_0.GridColor = SystemColors.Window;
			this.dataGridViewExcelFilter_0.Location = new Point(0, 25);
			this.dataGridViewExcelFilter_0.Name = "dgvFiles";
			this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_0.Size = new Size(634, 306);
			this.dataGridViewExcelFilter_0.TabIndex = 1;
			this.dataGridViewExcelFilter_0.VirtualMode = true;
			this.dataGridViewExcelFilter_0.CellContentClick += this.dataGridViewExcelFilter_0_CellContentClick;
			this.dataGridViewExcelFilter_0.CellValueNeeded += this.dataGridViewExcelFilter_0_CellValueNeeded;
			this.bindingSource_0.DataMember = "tSchm_ObjFile";
			this.bindingSource_0.DataSource = this.dataSet_0;
			this.bindingSource_0.Sort = "FileName";
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Tables.AddRange(new DataTable[]
			{
				this.dataTable_0
			});
			this.dataTable_0.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.dataColumn_2,
				this.dataColumn_3,
				this.dataColumn_4
			});
			this.dataTable_0.Constraints.AddRange(new Constraint[]
			{
				new UniqueConstraint("Constraint1", new string[]
				{
					"id"
				}, true)
			});
			this.dataTable_0.PrimaryKey = new DataColumn[]
			{
				this.dataColumn_0
			};
			this.dataTable_0.TableName = "tSchm_ObjFile";
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.ColumnName = "id";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_1.ColumnName = "idObj";
			this.dataColumn_1.DataType = typeof(int);
			this.dataColumn_2.AllowDBNull = false;
			this.dataColumn_2.ColumnName = "FileName";
			this.dataColumn_3.AllowDBNull = false;
			this.dataColumn_3.ColumnName = "dateIn";
			this.dataColumn_3.DataType = typeof(DateTime);
			this.dataColumn_4.ColumnName = "Comment";
			this.class22_0.DataSetName = "DataSetScheme";
			this.class22_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "id";
			this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_0.Visible = false;
			dataGridViewCellStyle.NullValue = null;
			this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridViewImageColumnNotNull_0.HeaderText = "";
			this.dataGridViewImageColumnNotNull_0.Name = "ColumnImage";
			this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
			this.dataGridViewImageColumnNotNull_0.Resizable = DataGridViewTriState.False;
			this.dataGridViewImageColumnNotNull_0.Width = 20;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "idObj";
			this.dataGridViewTextBoxColumn_1.HeaderText = "idObj";
			this.dataGridViewTextBoxColumn_1.Name = "idObjDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewLinkColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewLinkColumn_0.DataPropertyName = "FileName";
			this.dataGridViewLinkColumn_0.FillWeight = 25f;
			this.dataGridViewLinkColumn_0.HeaderText = "Имя файла";
			this.dataGridViewLinkColumn_0.Name = "fileNameDataGridViewTextBoxColumn";
			this.dataGridViewLinkColumn_0.ReadOnly = true;
			this.dataGridViewLinkColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewLinkColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "dateIn";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Дата";
			this.dataGridViewTextBoxColumn_2.Name = "dateInDgvColumn";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Width = 90;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "Comment";
			this.dataGridViewTextBoxColumn_3.FillWeight = 75f;
			this.dataGridViewTextBoxColumn_3.HeaderText = "Комментарий";
			this.dataGridViewTextBoxColumn_3.Name = "commentDataGridViewTextBoxColumn";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(634, 331);
			base.Controls.Add(this.dataGridViewExcelFilter_0);
			base.Controls.Add(this.toolStrip_0);
			this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			base.Name = "FormSchmObjFile";
			this.Text = "FormSchmObjFile";
			base.Load += this.FormSchmObjFile_Load;
			this.toolStrip_0.ResumeLayout(false);
			this.toolStrip_0.PerformLayout();
			this.dataGridViewExcelFilter_0.EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_0).EndInit();
			((ISupportInitialize)this.class22_0).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private DrawObjectBase drawObjectBase_0;

		private IContainer icontainer_0;

		private ToolStrip toolStrip_0;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private BindingSource bindingSource_0;

		private Class22 class22_0;

		private ToolStripButton toolStripButton_0;

		private DataSet dataSet_0;

		private DataTable dataTable_0;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private ToolStripButton toolStripButton_1;

		private ToolStripButton toolStripButton_2;

		private ToolStripButton toolStripButton_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewLinkColumn dataGridViewLinkColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;
	}
}
