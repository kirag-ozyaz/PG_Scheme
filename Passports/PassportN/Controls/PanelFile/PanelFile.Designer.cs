using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataSql;
using FormLbr.Classes;
using Passport.Properties;

namespace Passport.Controls.PanelFile
{
	public class PanelFile : Panel
	{
		public int IdParent { get; set; }

		[Browsable(true)]
		public SQLSettings SqlSettings
		{
			private get
			{
				return this.sqlsettings_0;
			}
			set
			{
				this.sqlsettings_0 = value;
			}
		}

		public bool IsSave
		{
			get
			{
				return this.bool_0;
			}
		}

		public PanelFile()
		{
			Class330.Mus9JxKz1CNxy();
			this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
			this.string_0 = "";
			base..ctor();
			this.method_12();
			this.dgvFile.AutoGenerateColumns = false;
		}

		public PanelFile(SQLSettings SqlSettings)
		{
			Class330.Mus9JxKz1CNxy();
			this.dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();
			this.string_0 = "";
			base..ctor();
			this.method_12();
			this.sqlsettings_0 = SqlSettings;
			this.dgvFile.AutoGenerateColumns = false;
		}

		private void dgvFile_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
		{
		}

		private void dgvFile_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			foreach (object obj in ((IEnumerable)this.dgvFile.Rows))
			{
				DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
				if (!dataGridViewRow.IsNewRow && this.dgvFile[this.FileNameDgvFile.Name, dataGridViewRow.Index].Value != null)
				{
					if (!string.IsNullOrEmpty(Path.GetFileName(this.dgvFile[this.FileNameDgvFile.Name, dataGridViewRow.Index].Value.ToString())))
					{
						dataGridViewRow.Cells[this.FileDgvFile.Index].Value = Path.GetFileName(this.dgvFile[this.FileNameDgvFile.Name, dataGridViewRow.Index].Value.ToString());
					}
					else
					{
						dataGridViewRow.Cells[this.FileDgvFile.Index].Value = this.dgvFile[this.FileNameDgvFile.Name, e.RowIndex].Value.ToString();
					}
					Icon icon = FileInfo.IconOfFile(this.dgvFile[this.FileNameDgvFile.Name, dataGridViewRow.Index].Value.ToString());
					if (icon != null)
					{
						dataGridViewRow.Cells[this.FileDgvFile.Index].Value = icon.ToBitmap();
					}
				}
			}
		}

		private void dgvFile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			this.method_3(false);
		}

		private void dgvFile_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			this.dgvFile.ReadOnly = true;
			this.FileNameDgvFile.ReadOnly = true;
			string text = this.dgvFile[e.ColumnIndex, e.RowIndex].Value.ToString() + Path.GetExtension(this.string_0);
			if (text == this.string_0)
			{
				return;
			}
			if (this.dictionary_0.ContainsKey(this.string_0))
			{
				FileWatcherArgsAddl fileWatcherArgsAddl = this.dictionary_0[this.string_0];
				fileWatcherArgsAddl.OriginalName = text;
				this.dictionary_0.Remove(this.string_0);
				this.dictionary_0.Add(text, fileWatcherArgsAddl);
				this.dgvFile[e.ColumnIndex, e.RowIndex].Value = text;
				this.bool_0 = true;
			}
			this.string_0 = null;
		}

		private void dgvFile_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (e.ColumnIndex == 1 && e.RowIndex >= 0 && !string.IsNullOrEmpty(this.string_0))
			{
				string text = e.FormattedValue + Path.GetExtension(this.string_0);
				if (text == this.string_0)
				{
					return;
				}
				if (this.dictionary_0.ContainsKey(text))
				{
					MessageBox.Show("Файл с таким именем уже существует", "");
					e.Cancel = true;
				}
			}
		}

		private void dgvFile_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.Button == MouseButtons.Right)
			{
				dataGridView.ClearSelection();
				dataGridView.Rows[e.RowIndex].Selected = true;
				dataGridView.CurrentCell = dataGridView[e.ColumnIndex, e.RowIndex];
				Rectangle cellDisplayRectangle = dataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
				this.cmsFile.Show(dataGridView, cellDisplayRectangle.Left + e.X, cellDisplayRectangle.Top + e.Y);
			}
		}

		private void dgvFile_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			if (dataGridView.Rows[e.RowIndex].IsNewRow)
			{
				return;
			}
			int num = e.RowIndex + 1;
			if (dataGridView.Rows[e.RowIndex].HeaderCell.Value == null || !dataGridView.Rows[e.RowIndex].HeaderCell.Value.Equals(num.ToString()))
			{
				dataGridView.Rows[e.RowIndex].HeaderCell.Value = num.ToString();
			}
		}

		private void tsmiAddFile_Click(object sender, EventArgs e)
		{
			this.method_0();
		}

		private void tsmiEditFile_Click(object sender, EventArgs e)
		{
			this.method_2();
		}

		private void tsmiOpenFile_Click(object sender, EventArgs e)
		{
			this.method_3(false);
		}

		private void tsmiDelFile_Click(object sender, EventArgs e)
		{
			this.method_4();
		}

		private void tsmiRenameFile_Click(object sender, EventArgs e)
		{
			this.method_5();
		}

		private void tsmiSaveAsFile_Click(object sender, EventArgs e)
		{
			this.method_6();
		}

		private void method_0()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				foreach (string string_ in openFileDialog.FileNames)
				{
					if (!string.IsNullOrEmpty(this.method_1(string_, null, null)))
					{
						this.bool_0 = true;
					}
				}
			}
		}

		private string method_1(string string_1, int? nullable_0 = null, byte[] byte_0 = null)
		{
			string fileName = Path.GetFileName(string_1);
			bool flag = true;
			while (this.dictionary_0.ContainsKey(fileName))
			{
				if (MessageBox.Show("Файл с именем " + fileName + " уже существует. Изменить имя файла на другое?", "Внимание.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					FormNewFileName_1 formNewFileName_ = new FormNewFileName_1(fileName);
					if (formNewFileName_.ShowDialog() == DialogResult.OK)
					{
						fileName = formNewFileName_.FileName;
					}
				}
				else
				{
					flag = false;
					IL_57:
					if (!flag)
					{
						return null;
					}
					FileWatcherArgsAddl value = new FileWatcherArgsAddl(nullable_0, fileName, null, 2);
					this.dictionary_0.Add(fileName, value);
					DataRow dataRow = this.dataSet_0.Tables[this.dataTable_0.TableName].NewRow();
					dataRow["idDoc"] = -1;
					dataRow["FileName"] = fileName;
					if (byte_0 == null)
					{
						FileBinary fileBinary = new FileBinary(string_1);
						dataRow["File"] = fileBinary.ByteArray;
						dataRow["dateChange"] = fileBinary.LastChanged;
					}
					else
					{
						dataRow["File"] = byte_0;
						dataRow["dateChange"] = DateTime.Now;
					}
					if (nullable_0 != null)
					{
						dataRow["idTemplate"] = nullable_0.Value;
					}
					this.dataSet_0.Tables[this.dataTable_0.TableName].Rows.Add(dataRow);
					return fileName;
				}
			}
			goto IL_57;
		}

		private void method_2()
		{
			if (this.bindingSource_0 != null && this.bindingSource_0.Current != null)
			{
				this.method_3(true);
				return;
			}
		}

		private void method_3(bool bool_1)
		{
			if (this.bindingSource_0 != null && this.bindingSource_0.Current != null)
			{
				DataRow row = ((DataRowView)this.bindingSource_0.Current).Row;
				string text = Convert.ToString(row["FileName"]);
				string text2 = this.method_7();
				string newFileNameIsExists = FileBinary.GetNewFileNameIsExists(text2, text, false);
				int? num = null;
				if (row["idTemplate"] != DBNull.Value)
				{
					num = new int?(Convert.ToInt32(row["idTemplate"]));
				}
				Convert.ToDateTime(row["dateChange"]);
				if (row["File"] == DBNull.Value)
				{
					try
					{
						using (SqlConnection sqlConnection = new SqlConnection(this.sqlsettings_0.GetConnectionString()))
						{
							sqlConnection.Open();
							SqlDataReader sqlDataReader = new SqlCommand(string.Format("select [File] from tP_DocFile where id = '{0}'", row["id"]), sqlConnection).ExecuteReader();
							while (sqlDataReader.Read())
							{
								row["File"] = sqlDataReader["File"];
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ex.Source);
					}
				}
				byte[] array;
				try
				{
					array = (byte[])row["File"];
				}
				catch
				{
					MessageBox.Show("Нет содержимого файла");
					return;
				}
				FileBinary fileBinary = new FileBinary(array, newFileNameIsExists, DateTime.Now);
				fileBinary.SaveToDisk(text2);
				Process.Start(text2 + "\\" + fileBinary.Name);
				if (bool_1)
				{
					if (this.dictionary_0.ContainsKey(text))
					{
						if (this.dictionary_0[text].Watcher == null)
						{
							FileWatcher fileWatcher = new FileWatcher(text2, newFileNameIsExists);
							fileWatcher.AnyChanged += this.method_8;
							fileWatcher.Start();
							this.dictionary_0[text].Watcher = fileWatcher;
						}
						else
						{
							this.dictionary_0[text].Watcher.AnyChanged -= this.method_8;
							this.dictionary_0[text].Watcher.Stop();
							FileWatcher fileWatcher2 = new FileWatcher(text2, newFileNameIsExists);
							fileWatcher2.AnyChanged += this.method_8;
							fileWatcher2.Start();
							this.dictionary_0[text].Watcher = fileWatcher2;
						}
						this.dictionary_0[text].TempName = newFileNameIsExists;
						this.dictionary_0[text].OpenState = 1;
						return;
					}
					FileWatcher fileWatcher3 = new FileWatcher(text2, newFileNameIsExists);
					fileWatcher3.AnyChanged += this.method_8;
					fileWatcher3.Start();
					FileWatcherArgsAddl value = new FileWatcherArgsAddl(num, text, newFileNameIsExists, fileWatcher3, 1);
					this.dictionary_0.Add(text, value);
				}
				return;
			}
		}

		private void method_4()
		{
			if (this.bindingSource_0 != null && this.bindingSource_0.Current != null)
			{
				if (MessageBox.Show("Вы действительно хотите удалить выбранный файл?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					DataRow row = ((DataRowView)this.bindingSource_0.Current).Row;
					string key = Convert.ToString(row["FileName"]);
					if (this.dictionary_0.ContainsKey(key))
					{
						if (this.dictionary_0[key].Watcher != null)
						{
							this.dictionary_0[key].Watcher.AnyChanged -= this.method_8;
							this.dictionary_0[key].Watcher.Stop();
						}
						this.dictionary_0.Remove(key);
					}
					row.Delete();
					this.bool_0 = true;
				}
				return;
			}
		}

		private void method_5()
		{
			if (this.bindingSource_0 != null && this.bindingSource_0.Current != null)
			{
				this.string_0 = ((DataRowView)this.bindingSource_0.Current).Row["FileName"].ToString();
				this.dgvFile.CurrentCell = this.dgvFile.CurrentRow.Cells[this.FileNameDgvFile.Index];
				this.dgvFile.CurrentCell.Value = Path.GetFileNameWithoutExtension(this.string_0);
				this.dgvFile.ReadOnly = false;
				this.FileNameDgvFile.ReadOnly = false;
				this.dgvFile.BeginEdit(true);
				return;
			}
		}

		private void method_6()
		{
			if (this.bindingSource_0 != null && this.bindingSource_0.Current != null)
			{
				DataRow row = ((DataRowView)this.bindingSource_0.Current).Row;
				if (row["File"] == DBNull.Value)
				{
					try
					{
						using (SqlConnection sqlConnection = new SqlConnection(this.sqlsettings_0.GetConnectionString()))
						{
							sqlConnection.Open();
							SqlDataReader sqlDataReader = new SqlCommand(string.Format("SELECT [File] FROM tP_DocFile WHERE id = '{0}'", row["id"]), sqlConnection).ExecuteReader();
							while (sqlDataReader.Read())
							{
								row["File"] = sqlDataReader["File"];
							}
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ex.Source);
					}
				}
				byte[] byteArray = (byte[])row["File"];
				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.FileName = Convert.ToString(row["FileName"]);
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.ByteArrayToFile(saveFileDialog.FileName, byteArray);
				}
				return;
			}
		}

		private string method_7()
		{
			string text = Path.GetTempPath() + "\\tmpFile\\";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			return text;
		}

		private void method_8(object sender, FileSystemEventArgs e)
		{
			IEnumerable<KeyValuePair<string, FileWatcherArgsAddl>> fwargs = from item in this.dictionary_0
			where item.Value.TempName == e.Name
			select item;
			if (fwargs.Count<KeyValuePair<string, FileWatcherArgsAddl>>() > 0)
			{
				FileBinary fileBinary = new FileBinary(e.FullPath);
				EnumerableRowCollection<DataRow> source = from rowFiles in this.dataSet_0.Tables[this.dataTable_0.TableName].AsEnumerable()
				where rowFiles.RowState != DataRowState.Deleted && rowFiles["FileName"] == fwargs.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.OriginalName
				select rowFiles;
				if (source.Count<DataRow>() == 0)
				{
					DataRow dataRow = this.dataTable_0.NewRow();
					dataRow["idDoc"] = this.IdParent;
					dataRow["FileName"] = fwargs.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.OriginalName;
					dataRow["File"] = fileBinary.ByteArray;
					dataRow["dateChange"] = fileBinary.LastChanged;
					dataRow["idTemplate"] = fwargs.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.IdTemplate.Value;
					this.dataTable_0.Rows.Add(dataRow);
				}
				else
				{
					source.First<DataRow>()["File"] = fileBinary.ByteArray;
					source.First<DataRow>()["dateChange"] = fileBinary.LastChanged;
					source.First<DataRow>().EndEdit();
					this.bool_0 = true;
				}
			}
			this.method_9();
		}

		public bool ByteArrayToFile(string fileName, byte[] byteArray)
		{
			try
			{
				FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
				fileStream.Write(byteArray, 0, byteArray.Length);
				fileStream.Close();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
				ex.ToString();
			}
			return false;
		}

		private void method_9()
		{
			if (base.InvokeRequired)
			{
				base.Invoke(new Action(this.method_13));
				return;
			}
			this.bindingSource_0.ResetBindings(false);
		}

		internal void method_10(int int_1)
		{
			try
			{
				using (SqlConnection sqlConnection = new SqlConnection(this.sqlsettings_0.GetConnectionString()))
				{
					sqlConnection.Open();
					SqlDataReader sqlDataReader = new SqlCommand(string.Format("SELECT id, idDoc, FileName, dateChange, idTemplate FROM tP_DocFile WHERE idDoc = '{0}'", int_1), sqlConnection).ExecuteReader();
					while (sqlDataReader.Read())
					{
						DataRow dataRow = this.dataSet_0.Tables[this.dataTable_0.TableName].NewRow();
						dataRow["id"] = (int)sqlDataReader["id"];
						dataRow["idDoc"] = (int)sqlDataReader["idDoc"];
						dataRow["FileName"] = sqlDataReader["FileName"].ToString();
						if (sqlDataReader["dateChange"] != DBNull.Value)
						{
							dataRow["dateChange"] = (DateTime)sqlDataReader["dateChange"];
						}
						int? num = null;
						if (sqlDataReader["idTemplate"] != DBNull.Value)
						{
							num = new int?((int)sqlDataReader["idTemplate"]);
							dataRow["idTemplate"] = sqlDataReader["idTemplate"];
						}
						this.dataSet_0.Tables[this.dataTable_0.TableName].Rows.Add(dataRow);
						dataRow.AcceptChanges();
						FileWatcherArgsAddl value = new FileWatcherArgsAddl(num, sqlDataReader["FileName"].ToString(), null, 2);
						this.dictionary_0.Add(sqlDataReader["FileName"].ToString(), value);
					}
				}
				this.idDgvFile.Visible = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, ex.Source);
			}
		}

		internal bool method_11(int int_1)
		{
			foreach (object obj in this.dataSet_0.Tables[this.dataTable_0.TableName].Rows)
			{
				DataRow dataRow = (DataRow)obj;
				if (dataRow.RowState != DataRowState.Deleted && dataRow.RowState != DataRowState.Detached && Convert.ToInt32(dataRow["idDoc"]) != int_1)
				{
					dataRow["idDoc"] = int_1;
					dataRow.EndEdit();
				}
			}
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.sqlsettings_0);
			if (sqlDataCommand.InsertSqlData(this.dataSet_0, this.dataSet_0.Tables[this.dataTable_0.TableName]) && sqlDataCommand.UpdateSqlData(this.dataSet_0, this.dataSet_0.Tables[this.dataTable_0.TableName]) && sqlDataCommand.DeleteSqlData(this.dataSet_0, this.dataSet_0.Tables[this.dataTable_0.TableName]))
			{
				this.dataSet_0.Tables[this.dataTable_0.TableName].AcceptChanges();
				return true;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_12()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.tsFile = new ToolStrip();
			this.tsBtnAddFile = new ToolStripButton();
			this.tsBtnEditFile = new ToolStripButton();
			this.tsBtnOpenFile = new ToolStripButton();
			this.tsBtnDelFile = new ToolStripButton();
			this.hhoaElKgeDC = new ToolStripButton();
			this.tsBtnSaveAsFile = new ToolStripButton();
			this.dgvFile = new DataGridView();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dataSet_0 = new DataSet();
			this.dataTable_0 = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.OjVaEkvjkEw = new DataColumn();
			this.dataColumn_2 = new DataColumn();
			this.dataColumn_3 = new DataColumn();
			this.dataColumn_4 = new DataColumn();
			this.cmsFile = new ContextMenuStrip(this.icontainer_0);
			this.tsmiAddFile = new ToolStripMenuItem();
			this.tsmiEditFile = new ToolStripMenuItem();
			this.tsmiOpenFile = new ToolStripMenuItem();
			this.tsmiDelFile = new ToolStripMenuItem();
			this.tsmiRenameFile = new ToolStripMenuItem();
			this.tsmiSaveAsFile = new ToolStripMenuItem();
			this.idDgvFile = new DataGridViewTextBoxColumn();
			this.idDocDgvFile = new DataGridViewTextBoxColumn();
			this.FileDgvFile = new DataGridViewImageColumn();
			this.FileNameDgvFile = new DataGridViewTextBoxColumn();
			this.dateChangeDgvFile = new DataGridViewTextBoxColumn();
			this.idTemplateDgvFile = new DataGridViewTextBoxColumn();
			this.tsFile.SuspendLayout();
			((ISupportInitialize)this.dgvFile).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_0).BeginInit();
			this.cmsFile.SuspendLayout();
			base.SuspendLayout();
			this.tsFile.GripStyle = ToolStripGripStyle.Hidden;
			this.tsFile.Items.AddRange(new ToolStripItem[]
			{
				this.tsBtnAddFile,
				this.tsBtnEditFile,
				this.tsBtnOpenFile,
				this.tsBtnDelFile,
				this.hhoaElKgeDC,
				this.tsBtnSaveAsFile
			});
			this.tsFile.Location = new Point(0, 0);
			this.tsFile.Name = "tsFile";
			this.tsFile.Size = new Size(370, 25);
			this.tsFile.TabIndex = 0;
			this.tsFile.Text = "toolStrip1";
			this.tsBtnAddFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsBtnAddFile.Image = Resources.smethod_24();
			this.tsBtnAddFile.ImageTransparentColor = Color.Magenta;
			this.tsBtnAddFile.Name = "tsBtnAddFile";
			this.tsBtnAddFile.Size = new Size(23, 22);
			this.tsBtnAddFile.Text = "Добавить файл";
			this.tsBtnAddFile.Click += this.tsmiAddFile_Click;
			this.tsBtnEditFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsBtnEditFile.Image = Resources.smethod_26();
			this.tsBtnEditFile.ImageTransparentColor = Color.Magenta;
			this.tsBtnEditFile.Name = "tsBtnEditFile";
			this.tsBtnEditFile.Size = new Size(23, 22);
			this.tsBtnEditFile.Text = "Редактировать файл";
			this.tsBtnEditFile.Click += this.tsmiEditFile_Click;
			this.tsBtnOpenFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsBtnOpenFile.Image = Resources.smethod_28();
			this.tsBtnOpenFile.ImageTransparentColor = Color.Magenta;
			this.tsBtnOpenFile.Name = "tsBtnOpenFile";
			this.tsBtnOpenFile.Size = new Size(23, 22);
			this.tsBtnOpenFile.Text = "Открыть файл";
			this.tsBtnOpenFile.Click += this.tsmiOpenFile_Click;
			this.tsBtnDelFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsBtnDelFile.Image = Resources.smethod_25();
			this.tsBtnDelFile.ImageTransparentColor = Color.Magenta;
			this.tsBtnDelFile.Name = "tsBtnDelFile";
			this.tsBtnDelFile.Size = new Size(23, 22);
			this.tsBtnDelFile.Text = "Удалить файл";
			this.tsBtnDelFile.Click += this.tsmiDelFile_Click;
			this.hhoaElKgeDC.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.hhoaElKgeDC.Image = Resources.smethod_46();
			this.hhoaElKgeDC.ImageTransparentColor = Color.Magenta;
			this.hhoaElKgeDC.Name = "tsBtnRenameFile";
			this.hhoaElKgeDC.Size = new Size(23, 22);
			this.hhoaElKgeDC.Text = "Переименовать файл";
			this.hhoaElKgeDC.Click += this.tsmiRenameFile_Click;
			this.tsBtnSaveAsFile.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsBtnSaveAsFile.Image = Resources.smethod_29();
			this.tsBtnSaveAsFile.ImageTransparentColor = Color.Magenta;
			this.tsBtnSaveAsFile.Name = "tsBtnSaveAsFile";
			this.tsBtnSaveAsFile.Size = new Size(23, 22);
			this.tsBtnSaveAsFile.Text = "Сохранить как...";
			this.tsBtnSaveAsFile.Click += this.tsmiSaveAsFile_Click;
			this.dgvFile.AllowUserToAddRows = false;
			this.dgvFile.AllowUserToDeleteRows = false;
			this.dgvFile.AutoGenerateColumns = false;
			this.dgvFile.BackgroundColor = SystemColors.Window;
			this.dgvFile.Columns.AddRange(new DataGridViewColumn[]
			{
				this.idDgvFile,
				this.idDocDgvFile,
				this.FileDgvFile,
				this.FileNameDgvFile,
				this.dateChangeDgvFile,
				this.idTemplateDgvFile
			});
			this.dgvFile.DataSource = this.bindingSource_0;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.Window;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.HighlightText;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.Highlight;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
			this.dgvFile.DefaultCellStyle = dataGridViewCellStyle;
			this.dgvFile.Dock = DockStyle.Fill;
			this.dgvFile.Location = new Point(0, 25);
			this.dgvFile.Name = "dgvFile";
			this.dgvFile.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dgvFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvFile.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dgvFile.SelectionMode = DataGridViewSelectionMode.CellSelect;
			this.dgvFile.Size = new Size(370, 398);
			this.dgvFile.TabIndex = 0;
			this.dgvFile.CellDoubleClick += this.dgvFile_CellDoubleClick;
			this.dgvFile.CellEndEdit += this.dgvFile_CellEndEdit;
			this.dgvFile.CellMouseClick += this.dgvFile_CellMouseClick;
			this.dgvFile.CellValidating += this.dgvFile_CellValidating;
			this.dgvFile.CellValueNeeded += this.dgvFile_CellValueNeeded;
			this.dgvFile.RowPrePaint += this.dgvFile_RowPrePaint;
			this.dgvFile.RowsAdded += this.dgvFile_RowsAdded;
			this.bindingSource_0.DataMember = "tP_DocFile";
			this.bindingSource_0.DataSource = this.dataSet_0;
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Tables.AddRange(new DataTable[]
			{
				this.dataTable_0
			});
			this.dataTable_0.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.OjVaEkvjkEw,
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
			this.dataTable_0.TableName = "tP_DocFile";
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.AutoIncrementSeed = -1L;
			this.dataColumn_0.AutoIncrementStep = -1L;
			this.dataColumn_0.ColumnName = "id";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_0.ReadOnly = true;
			this.dataColumn_1.ColumnName = "idDoc";
			this.dataColumn_1.DataType = typeof(int);
			this.OjVaEkvjkEw.ColumnName = "FileName";
			this.dataColumn_2.ColumnName = "File";
			this.dataColumn_2.DataType = typeof(byte[]);
			this.dataColumn_3.ColumnName = "dateChange";
			this.dataColumn_3.DataType = typeof(DateTime);
			this.dataColumn_4.ColumnName = "idTemplate";
			this.dataColumn_4.DataType = typeof(int);
			this.cmsFile.Items.AddRange(new ToolStripItem[]
			{
				this.tsmiAddFile,
				this.tsmiEditFile,
				this.tsmiOpenFile,
				this.tsmiDelFile,
				this.tsmiRenameFile,
				this.tsmiSaveAsFile
			});
			this.cmsFile.Name = "cmsFile";
			this.cmsFile.Size = new Size(163, 136);
			this.tsmiAddFile.Image = Resources.smethod_24();
			this.tsmiAddFile.Name = "tsmiAddFile";
			this.tsmiAddFile.Size = new Size(162, 22);
			this.tsmiAddFile.Text = "Добавить";
			this.tsmiAddFile.Click += this.tsmiAddFile_Click;
			this.tsmiEditFile.Image = Resources.smethod_26();
			this.tsmiEditFile.Name = "tsmiEditFile";
			this.tsmiEditFile.Size = new Size(162, 22);
			this.tsmiEditFile.Text = "Редактировать";
			this.tsmiEditFile.Click += this.tsmiEditFile_Click;
			this.tsmiOpenFile.Image = Resources.smethod_28();
			this.tsmiOpenFile.Name = "tsmiOpenFile";
			this.tsmiOpenFile.Size = new Size(162, 22);
			this.tsmiOpenFile.Text = "Открыть";
			this.tsmiOpenFile.Click += this.tsmiOpenFile_Click;
			this.tsmiDelFile.Image = Resources.smethod_25();
			this.tsmiDelFile.Name = "tsmiDelFile";
			this.tsmiDelFile.Size = new Size(162, 22);
			this.tsmiDelFile.Text = "Удалить";
			this.tsmiDelFile.Click += this.tsmiDelFile_Click;
			this.tsmiRenameFile.Image = Resources.smethod_46();
			this.tsmiRenameFile.Name = "tsmiRenameFile";
			this.tsmiRenameFile.Size = new Size(162, 22);
			this.tsmiRenameFile.Text = "Переименовать";
			this.tsmiRenameFile.Click += this.tsmiRenameFile_Click;
			this.tsmiSaveAsFile.Image = Resources.smethod_29();
			this.tsmiSaveAsFile.Name = "tsmiSaveAsFile";
			this.tsmiSaveAsFile.Size = new Size(162, 22);
			this.tsmiSaveAsFile.Text = "Сохранить как...";
			this.tsmiSaveAsFile.Click += this.tsmiSaveAsFile_Click;
			this.idDgvFile.DataPropertyName = "id";
			this.idDgvFile.HeaderText = "id";
			this.idDgvFile.Name = "idDgvFile";
			this.idDgvFile.ReadOnly = true;
			this.idDgvFile.Visible = false;
			this.idDocDgvFile.DataPropertyName = "idDoc";
			this.idDocDgvFile.HeaderText = "idDoc";
			this.idDocDgvFile.Name = "idDocDgvFile";
			this.idDocDgvFile.ReadOnly = true;
			this.idDocDgvFile.Visible = false;
			this.FileDgvFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.FileDgvFile.HeaderText = "";
			this.FileDgvFile.ImageLayout = DataGridViewImageCellLayout.Zoom;
			this.FileDgvFile.Name = "FileDgvFile";
			this.FileDgvFile.ReadOnly = true;
			this.FileDgvFile.Resizable = DataGridViewTriState.False;
			this.FileDgvFile.Width = 25;
			this.FileNameDgvFile.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.FileNameDgvFile.DataPropertyName = "FileName";
			this.FileNameDgvFile.HeaderText = "Имя файла";
			this.FileNameDgvFile.Name = "FileNameDgvFile";
			this.FileNameDgvFile.ReadOnly = true;
			this.dateChangeDgvFile.DataPropertyName = "dateChange";
			this.dateChangeDgvFile.HeaderText = "dateChange";
			this.dateChangeDgvFile.Name = "dateChangeDgvFile";
			this.dateChangeDgvFile.ReadOnly = true;
			this.dateChangeDgvFile.Visible = false;
			this.idTemplateDgvFile.DataPropertyName = "idTemplate";
			this.idTemplateDgvFile.HeaderText = "idTemplate";
			this.idTemplateDgvFile.Name = "idTemplateDgvFile";
			this.idTemplateDgvFile.ReadOnly = true;
			this.idTemplateDgvFile.Visible = false;
			base.Controls.Add(this.dgvFile);
			base.Controls.Add(this.tsFile);
			base.Size = new Size(370, 423);
			this.tsFile.ResumeLayout(false);
			this.tsFile.PerformLayout();
			((ISupportInitialize)this.dgvFile).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_0).EndInit();
			this.cmsFile.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		[CompilerGenerated]
		private void method_13()
		{
			this.bindingSource_0.ResetBindings(false);
		}

		private bool bool_0;

		private SQLSettings sqlsettings_0;

		[CompilerGenerated]
		private int int_0;

		private Dictionary<string, FileWatcherArgsAddl> dictionary_0;

		private string string_0;

		private IContainer icontainer_0;

		private DataGridView dgvFile;

		private ToolStripButton tsBtnAddFile;

		private ToolStripButton tsBtnEditFile;

		private ToolStripButton tsBtnOpenFile;

		private ToolStripButton tsBtnDelFile;

		private ToolStripButton hhoaElKgeDC;

		private ToolStripButton tsBtnSaveAsFile;

		private ContextMenuStrip cmsFile;

		private ToolStripMenuItem tsmiAddFile;

		private ToolStripMenuItem tsmiEditFile;

		private ToolStripMenuItem tsmiOpenFile;

		private ToolStripMenuItem tsmiDelFile;

		private ToolStripMenuItem tsmiRenameFile;

		private ToolStripMenuItem tsmiSaveAsFile;

		private BindingSource bindingSource_0;

		private DataSet dataSet_0;

		private DataTable dataTable_0;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn OjVaEkvjkEw;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private ToolStrip tsFile;

		private DataGridViewTextBoxColumn idDgvFile;

		private DataGridViewTextBoxColumn idDocDgvFile;

		private DataGridViewImageColumn FileDgvFile;

		private DataGridViewTextBoxColumn FileNameDgvFile;

		private DataGridViewTextBoxColumn dateChangeDgvFile;

		private DataGridViewTextBoxColumn idTemplateDgvFile;
	}
}
