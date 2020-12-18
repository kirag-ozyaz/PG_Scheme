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
using System.Xml;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using FormLbr.Classes;
using Passport.DataSets;
using Passport.Properties;

internal class Form1 : FormBase
{
	internal Form1(int int_2, int? nullable_1 = null)
	{
		this.method_13();
		this.int_0 = int_2;
		this.nullable_0 = nullable_1;
		this.Text = ((nullable_1 == null) ? "Новый документ - осмотр подстацнии" : "Редактировать документ - осмотр подстанции");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		this.textBox_0.Text = base.CallSQLScalarFunction("dbo.fn_Schm_GetFullNameObjById", new string[]
		{
			this.int_0.ToString()
		}).ToString();
		this.method_0();
		if (this.nullable_0 == null)
		{
			this.method_1();
			return;
		}
		base.SelectSqlData(this.dsDocuments_0.tP_DocList, true, "where id = " + this.nullable_0.ToString(), false);
		this.method_4();
		this.method_11();
	}

	private void method_0()
	{
		DataTable dataTable = new DataTable("vWorkerGroup");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("fio", typeof(string));
		base.SelectSqlData(dataTable, true, " where dateEnd is null order by fio ", true);
		this.comboBox_0.DisplayMember = "fio";
		this.comboBox_0.ValueMember = "id";
		this.comboBox_0.DataSource = dataTable;
		this.comboBox_0.SelectedIndex = -1;
	}

	private void method_1()
	{
		DataRow dataRow = this.dsDocuments_0.tP_DocList.NewRow();
		dataRow["ParentId"] = -1;
		dataRow["idObjList"] = this.int_0;
		dataRow["dateDoc"] = DateTime.Now.Date;
		dataRow["TypeDoc"] = 1374;
		dataRow["isActive"] = 1;
		dataRow["deleted"] = 0;
		this.dsDocuments_0.tP_DocList.Rows.Add(dataRow);
	}

	private void toolStripButton_0_Click(object sender, EventArgs e)
	{
		Form0 form = new Form0(null);
		form.SqlSettings = this.SqlSettings;
		if (form.ShowDialog() == DialogResult.OK)
		{
			this.dataGridView_0.Rows.Add(new object[]
			{
				form.method_0().string_0,
				form.method_0().dateTime_0,
				((Enum0)form.method_0().int_0).smethod_0(),
				form.method_0().int_0,
				form.method_0().nullable_0
			});
		}
	}

	private void toolStripButton_1_Click(object sender, EventArgs e)
	{
		if (this.dataGridView_0.CurrentRow != null)
		{
			Struct0 value = default(Struct0);
			if (this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value != null)
			{
				value.nullable_0 = new int?(Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value));
			}
			value.int_0 = Convert.ToInt32(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_3.Name].Value);
			value.dateTime_0 = Convert.ToDateTime(this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value);
			value.string_0 = this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value.ToString();
			Form0 form = new Form0(new Struct0?(value));
			form.SqlSettings = this.SqlSettings;
			if (form.ShowDialog() == DialogResult.OK)
			{
				this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value = form.method_0().nullable_0;
				this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_3.Name].Value = form.method_0().int_0;
				this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_2.Name].Value = ((Enum0)form.method_0().int_0).smethod_0();
				this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value = form.method_0().dateTime_0;
				this.dataGridView_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value = form.method_0().string_0;
			}
		}
	}

	private void toolStripButton_2_Click(object sender, EventArgs e)
	{
		if (this.dataGridView_0.CurrentRow != null && MessageBox.Show("Вы действительно хотите удалить выбранный документ?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			this.dataGridView_0.Rows.Remove(this.dataGridView_0.CurrentRow);
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (base.DialogResult == DialogResult.OK && !this.method_2())
		{
			e.Cancel = true;
			return;
		}
	}

	private bool method_2()
	{
		if (this.nullable_0 == null)
		{
			this.dsDocuments_0.tP_DocList.Rows[0]["DataXml"] = this.method_3().InnerXml;
			this.dsDocuments_0.tP_DocList.Rows[0].EndEdit();
			this.nullable_0 = new int?(base.InsertSqlDataOneRow(this.dsDocuments_0, this.dsDocuments_0.tP_DocList));
			if (this.nullable_0 < 0)
			{
				return false;
			}
		}
		else
		{
			this.dsDocuments_0.tP_DocList.Rows[0]["DataXml"] = this.method_3().InnerXml;
			this.dsDocuments_0.tP_DocList.Rows[0].EndEdit();
			if (!base.UpdateSqlData(this.dsDocuments_0.tP_DocList))
			{
				return false;
			}
		}
		return this.method_12();
	}

	private XmlDocument method_3()
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode xmlNode = xmlDocument.CreateElement("InspectSub");
		xmlDocument.AppendChild(xmlNode);
		if (this.comboBox_0.SelectedIndex >= 0)
		{
			XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("idInspectWorker");
			xmlAttribute.Value = this.comboBox_0.SelectedValue.ToString();
			xmlNode.Attributes.Append(xmlAttribute);
		}
		foreach (object obj in ((IEnumerable)this.dataGridView_0.Rows))
		{
			DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
			XmlNode xmlNode2 = xmlDocument.CreateElement("DocReason");
			xmlNode.AppendChild(xmlNode2);
			if (dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value != null)
			{
				XmlAttribute xmlAttribute2 = xmlDocument.CreateAttribute("idDoc");
				xmlAttribute2.Value = dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_4.Name].Value.ToString();
				xmlNode2.Attributes.Append(xmlAttribute2);
			}
			XmlAttribute xmlAttribute3 = xmlDocument.CreateAttribute("typeDoc");
			xmlAttribute3.Value = dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_3.Name].Value.ToString();
			xmlNode2.Attributes.Append(xmlAttribute3);
			xmlAttribute3 = xmlDocument.CreateAttribute("numDoc");
			xmlAttribute3.Value = dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value.ToString();
			xmlNode2.Attributes.Append(xmlAttribute3);
			xmlAttribute3 = xmlDocument.CreateAttribute("dateDoc");
			xmlAttribute3.Value = dataGridViewRow.Cells[this.dataGridViewTextBoxColumn_1.Name].Value.ToString();
			xmlNode2.Attributes.Append(xmlAttribute3);
		}
		return xmlDocument;
	}

	private void method_4()
	{
		try
		{
			if (this.dsDocuments_0.tP_DocList.Rows.Count != 0)
			{
				if (this.dsDocuments_0.tP_DocList.Rows[0]["DataXml"] != DBNull.Value)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(this.dsDocuments_0.tP_DocList.Rows[0]["DataXml"].ToString());
					XmlNode xmlNode = xmlDocument.SelectSingleNode("InspectSub");
					if (xmlNode != null)
					{
						XmlAttribute xmlAttribute = xmlNode.Attributes["idInspectWorker"];
						if (xmlAttribute != null)
						{
							this.comboBox_0.SelectedValue = Convert.ToInt32(xmlAttribute.Value);
						}
						foreach (object obj in xmlNode.SelectNodes("DocReason"))
						{
							XmlNode xmlNode2 = (XmlNode)obj;
							Struct0 @struct = default(Struct0);
							XmlAttribute xmlAttribute2 = xmlNode2.Attributes["idDoc"];
							if (xmlAttribute2 != null)
							{
								@struct.nullable_0 = new int?(Convert.ToInt32(xmlAttribute2.Value));
							}
							xmlAttribute2 = xmlNode2.Attributes["typeDoc"];
							if (xmlAttribute2 != null)
							{
								@struct.int_0 = Convert.ToInt32(xmlAttribute2.Value);
							}
							xmlAttribute2 = xmlNode2.Attributes["numDoc"];
							if (xmlAttribute2 != null)
							{
								@struct.string_0 = xmlAttribute2.Value;
							}
							xmlAttribute2 = xmlNode2.Attributes["dateDoc"];
							if (xmlAttribute2 != null)
							{
								@struct.dateTime_0 = Convert.ToDateTime(xmlAttribute2.Value);
							}
							if (@struct.int_0 == 891 && @struct.nullable_0 != null)
							{
								DataTable dataTable = new DataTable("tJ_Order");
								dataTable.Columns.Add("num", typeof(int));
								dataTable.Columns.Add("datebegin", typeof(DateTime));
								base.SelectSqlData(dataTable, true, "where id = " + @struct.nullable_0.ToString(), false);
								if (dataTable.Rows.Count > 0)
								{
									@struct.string_0 = dataTable.Rows[0]["num"].ToString();
									@struct.dateTime_0 = Convert.ToDateTime(dataTable.Rows[0]["datebegin"]);
								}
							}
							if (Struct0.smethod_1(@struct, Struct0.struct0_0))
							{
								this.dataGridView_0.Rows.Add(new object[]
								{
									@struct.string_0,
									@struct.dateTime_0,
									((Enum0)@struct.int_0).smethod_0(),
									@struct.int_0,
									@struct.nullable_0
								});
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.Source);
		}
	}

	private string method_5(string string_1, int? nullable_1 = null, byte[] byte_0 = null)
	{
		string text = Path.GetFileName(string_1);
		bool flag = true;
		while (this.dictionary_0.ContainsKey(text))
		{
			if (MessageBox.Show("Файл с именем " + text + " уже существует. Изменить имя файла на другое?", "Внимание.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				FormNewFileName formNewFileName = new FormNewFileName(text);
				if (formNewFileName.ShowDialog() == DialogResult.OK)
				{
					text = formNewFileName.method_0();
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
				FileWatcherArgsAddl value = new FileWatcherArgsAddl(nullable_1, text, null, 2);
				this.dictionary_0.Add(text, value);
				dsDocuments.Class191 @class = this.dsDocuments_0.tP_DocFile.method_5();
				@class.idDoc = -1;
				@class.FileName = text;
				if (byte_0 == null)
				{
					FileBinary fileBinary = new FileBinary(string_1);
					@class.File = fileBinary.ByteArray;
					@class.dateChange = fileBinary.LastChanged;
				}
				else
				{
					@class.File = byte_0;
					@class.dateChange = DateTime.Now;
				}
				if (nullable_1 != null)
				{
					@class.idTemplate = nullable_1.Value;
				}
				this.dsDocuments_0.tP_DocFile.method_0(@class);
				return text;
			}
		}
		goto IL_57;
	}

	private void toolStripButton_8_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Multiselect = true;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			foreach (string string_ in openFileDialog.FileNames)
			{
				this.method_5(string_, null, null);
			}
		}
	}

	private void toolStripButton_3_Click(object sender, EventArgs e)
	{
		this.method_7(true);
	}

	private void toolStripButton_4_Click(object sender, EventArgs e)
	{
		this.method_7(false);
	}

	private void toolStripButton_5_Click(object sender, EventArgs e)
	{
		if (this.bindingSource_0.Current != null && MessageBox.Show("Вы действительно хотите удалить выбранный файл?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			dsDocuments.Class191 @class = (dsDocuments.Class191)((DataRowView)this.bindingSource_0.Current).Row;
			string fileName = @class.FileName;
			if (this.dictionary_0.ContainsKey(fileName))
			{
				if (this.dictionary_0[fileName].Watcher != null)
				{
					this.dictionary_0[fileName].Watcher.AnyChanged -= this.method_8;
					this.dictionary_0[fileName].Watcher.Stop();
				}
				this.dictionary_0.Remove(fileName);
			}
			@class.Delete();
		}
	}

	private void toolStripButton_6_Click(object sender, EventArgs e)
	{
		if (this.dataGridViewExcelFilter_0.CurrentRow != null)
		{
			this.string_0 = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_0.Name].Value.ToString();
			this.dataGridViewExcelFilter_0.CurrentCell = this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewFilterTextBoxColumn_0.Name];
			this.dataGridViewExcelFilter_0.CurrentCell.Value = Path.GetFileNameWithoutExtension(this.string_0);
			this.dataGridViewExcelFilter_0.ReadOnly = false;
			this.dataGridViewFilterTextBoxColumn_0.ReadOnly = false;
			this.dataGridViewExcelFilter_0.BeginEdit(true);
		}
	}

	private void toolStripButton_7_Click(object sender, EventArgs e)
	{
		if (this.bindingSource_0.Current != null)
		{
			dsDocuments.Class191 @class = (dsDocuments.Class191)((DataRowView)this.bindingSource_0.Current).Row;
			if (@class["File"] == DBNull.Value)
			{
				try
				{
					using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
					{
						sqlConnection.Open();
						SqlDataReader sqlDataReader = new SqlCommand("SELECT [File] FROM tP_DocFile WHERE id = " + @class["id"].ToString(), sqlConnection).ExecuteReader();
						while (sqlDataReader.Read())
						{
							@class["File"] = sqlDataReader["File"];
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
				}
			}
			byte[] file = @class.File;
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.FileName = @class.FileName;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.method_6(saveFileDialog.FileName, file);
			}
		}
	}

	public bool method_6(string string_1, byte[] byte_0)
	{
		try
		{
			FileStream fileStream = new FileStream(string_1, FileMode.Create, FileAccess.Write);
			fileStream.Write(byte_0, 0, byte_0.Length);
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

	private void method_7(bool bool_0 = false)
	{
		if (this.bindingSource_0.Current != null)
		{
			dsDocuments.Class191 @class = (dsDocuments.Class191)((DataRowView)this.bindingSource_0.Current).Row;
			string fileName = @class.FileName;
			string text = this.method_9();
			string newFileNameIsExists = FileBinary.GetNewFileNameIsExists(text, fileName, false);
			int? num = null;
			if (@class["idTemplate"] != DBNull.Value)
			{
				num = new int?(@class.idTemplate);
			}
			DateTime dateChange = @class.dateChange;
			if (@class["File"] == DBNull.Value)
			{
				try
				{
					using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
					{
						sqlConnection.Open();
						SqlDataReader sqlDataReader = new SqlCommand("SELECT [File] FROM tP_DocFile WHERE id = " + @class["id"].ToString(), sqlConnection).ExecuteReader();
						while (sqlDataReader.Read())
						{
							@class["File"] = sqlDataReader["File"];
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, ex.Source);
				}
			}
			byte[] file;
			try
			{
				file = @class.File;
			}
			catch
			{
				MessageBox.Show("Нет содержимого файла");
				return;
			}
			FileBinary fileBinary = new FileBinary(file, newFileNameIsExists, DateTime.Now);
			fileBinary.SaveToDisk(text);
			Process.Start(text + "\\" + fileBinary.Name);
			if (bool_0)
			{
				if (this.dictionary_0.ContainsKey(fileName))
				{
					if (this.dictionary_0[fileName].Watcher == null)
					{
						FileWatcher fileWatcher = new FileWatcher(text, newFileNameIsExists);
						fileWatcher.AnyChanged += this.method_8;
						fileWatcher.Start();
						this.dictionary_0[fileName].Watcher = fileWatcher;
					}
					else
					{
						this.dictionary_0[fileName].Watcher.AnyChanged -= this.method_8;
						this.dictionary_0[fileName].Watcher.Stop();
						FileWatcher fileWatcher2 = new FileWatcher(text, newFileNameIsExists);
						fileWatcher2.AnyChanged += this.method_8;
						fileWatcher2.Start();
						this.dictionary_0[fileName].Watcher = fileWatcher2;
					}
					this.dictionary_0[fileName].TempName = newFileNameIsExists;
					this.dictionary_0[fileName].OpenState = 1;
					return;
				}
				FileWatcher fileWatcher3 = new FileWatcher(text, newFileNameIsExists);
				fileWatcher3.AnyChanged += this.method_8;
				fileWatcher3.Start();
				FileWatcherArgsAddl value = new FileWatcherArgsAddl(num, fileName, newFileNameIsExists, fileWatcher3, 1);
				this.dictionary_0.Add(fileName, value);
			}
		}
	}

	private void method_8(object sender, FileSystemEventArgs e)
	{
		Form1.Class99 @class = new Form1.Class99();
		@class.fileSystemEventArgs_0 = e;
		@class.ienumerable_0 = this.dictionary_0.Where(new Func<KeyValuePair<string, FileWatcherArgsAddl>, bool>(@class.method_0));
		if (@class.ienumerable_0.Count<KeyValuePair<string, FileWatcherArgsAddl>>() > 0)
		{
			FileBinary fileBinary = new FileBinary(@class.fileSystemEventArgs_0.FullPath);
			EnumerableRowCollection<dsDocuments.Class191> source = this.dsDocuments_0.tP_DocFile.Where(new Func<dsDocuments.Class191, bool>(@class.method_1));
			if (source.Count<dsDocuments.Class191>() == 0)
			{
				dsDocuments.Class191 class2 = this.dsDocuments_0.tP_DocFile.method_5();
				if (this.nullable_0 != null)
				{
					class2.idDoc = this.nullable_0.Value;
				}
				else
				{
					class2.idDoc = -1;
				}
				class2.FileName = @class.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.OriginalName;
				class2.File = fileBinary.ByteArray;
				class2.dateChange = fileBinary.LastChanged;
				class2.idTemplate = @class.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.IdTemplate.Value;
				this.dsDocuments_0.tP_DocFile.Rows.Add(class2);
			}
			else
			{
				source.First<dsDocuments.Class191>().File = fileBinary.ByteArray;
				source.First<dsDocuments.Class191>().dateChange = fileBinary.LastChanged;
				source.First<dsDocuments.Class191>().EndEdit();
			}
		}
		this.method_10();
	}

	private string method_9()
	{
		string text = "EIS\\Passport";
		if (!string.IsNullOrEmpty(this.textBox_1.Text))
		{
			text = text + "\\" + this.textBox_1.Text;
		}
		string text2 = Path.GetTempPath() + "\\" + text + "\\";
		if (!Directory.Exists(text2))
		{
			Directory.CreateDirectory(text2);
		}
		return text2;
	}

	private void method_10()
	{
		if (base.InvokeRequired)
		{
			base.Invoke(new Action(this.method_14));
			return;
		}
		this.bindingSource_0.ResetBindings(false);
	}

	private void dataGridViewExcelFilter_0_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
	{
		if (((DataGridView)sender).RowCount > 0 && this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value != null)
		{
			if (e.ColumnIndex == this.dataGridViewExcelFilter_0.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
			{
				if (!string.IsNullOrEmpty(Path.GetFileName(this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString())))
				{
					e.Value = Path.GetFileName(this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString());
				}
				else
				{
					e.Value = this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString();
				}
			}
			if (e.ColumnIndex == this.dataGridViewExcelFilter_0.Columns[this.dataGridViewImageColumnNotNull_0.Name].Index)
			{
				Icon icon = FileInfo.IconOfFile(this.dataGridViewExcelFilter_0[this.dataGridViewFilterTextBoxColumn_0.Name, e.RowIndex].Value.ToString());
				if (icon != null)
				{
					e.Value = icon.ToBitmap();
				}
			}
		}
	}

	private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
	{
		this.toolStripButton_4_Click(sender, e);
	}

	private void dataGridViewExcelFilter_0_CellEndEdit(object sender, DataGridViewCellEventArgs e)
	{
		this.dataGridViewExcelFilter_0.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
		string text = this.dataGridViewExcelFilter_0[e.ColumnIndex, e.RowIndex].Value.ToString() + Path.GetExtension(this.string_0);
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
			this.dataGridViewExcelFilter_0[e.ColumnIndex, e.RowIndex].Value = text;
		}
		this.string_0 = null;
	}

	private void dataGridViewExcelFilter_0_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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

	private void method_11()
	{
		if (this.nullable_0 == null)
		{
			this.dsDocuments_0.tP_DocFile.Clear();
			return;
		}
		try
		{
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				sqlConnection.Open();
				SqlDataReader sqlDataReader = new SqlCommand("SELECT id, idDoc, FileName, dateChange, idTemplate FROM tP_DocFile WHERE idDoc = " + this.nullable_0.ToString(), sqlConnection).ExecuteReader();
				while (sqlDataReader.Read())
				{
					dsDocuments.Class191 @class = this.dsDocuments_0.tP_DocFile.method_5();
					@class.Int32_0 = (int)sqlDataReader["id"];
					@class.idDoc = (int)sqlDataReader["idDoc"];
					@class.FileName = sqlDataReader["FileName"].ToString();
					if (sqlDataReader["dateChange"] != DBNull.Value)
					{
						@class.dateChange = (DateTime)sqlDataReader["dateChange"];
					}
					int? num = null;
					if (sqlDataReader["idTemplate"] != DBNull.Value)
					{
						num = new int?(@class.idTemplate = (int)sqlDataReader["idTemplate"]);
					}
					this.dsDocuments_0.tP_DocFile.Rows.Add(@class);
					@class.AcceptChanges();
					FileWatcherArgsAddl value = new FileWatcherArgsAddl(num, sqlDataReader["FileName"].ToString(), null, 2);
					this.dictionary_0.Add(sqlDataReader["FileName"].ToString(), value);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.Source);
		}
	}

	private bool method_12()
	{
		foreach (DataRow dataRow in this.dsDocuments_0.tP_DocFile)
		{
			if (dataRow.RowState != DataRowState.Deleted && dataRow.RowState != DataRowState.Detached && Convert.ToInt32(dataRow["idDoc"]) != this.nullable_0)
			{
				dataRow["idDoc"] = this.nullable_0;
				dataRow.EndEdit();
			}
		}
		if (base.InsertSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_DocFile) && base.UpdateSqlDataOnlyChange(this.dsDocuments_0.tP_DocFile) && base.DeleteSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_DocFile))
		{
			this.dsDocuments_0.tP_DocFile.AcceptChanges();
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

	private void method_13()
	{
		this.icontainer_0 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		this.textBox_0 = new TextBox();
		this.label_0 = new Label();
		this.dateTimePicker_0 = new DateTimePicker();
		this.dsDocuments_0 = new dsDocuments();
		this.label_1 = new Label();
		this.textBox_1 = new TextBox();
		this.label_2 = new Label();
		this.label_3 = new Label();
		this.comboBox_0 = new ComboBox();
		this.tabControl_0 = new TabControl();
		this.tabPage_0 = new TabPage();
		this.dataGridView_0 = new DataGridView();
		this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
		this.toolStrip_0 = new ToolStrip();
		this.toolStripButton_0 = new ToolStripButton();
		this.toolStripButton_1 = new ToolStripButton();
		this.toolStripButton_2 = new ToolStripButton();
		this.label_4 = new Label();
		this.tabPage_1 = new TabPage();
		this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
		this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
		this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
		this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
		this.dataGridViewImageColumnNotNull_0 = new DataGridViewImageColumnNotNull();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.toolStrip_1 = new ToolStrip();
		this.toolStripButton_8 = new ToolStripButton();
		this.toolStripButton_3 = new ToolStripButton();
		this.toolStripButton_4 = new ToolStripButton();
		this.toolStripButton_5 = new ToolStripButton();
		this.toolStripSeparator_0 = new ToolStripSeparator();
		this.toolStripButton_6 = new ToolStripButton();
		this.toolStripButton_7 = new ToolStripButton();
		this.button_0 = new Button();
		this.button_1 = new Button();
		this.label_5 = new Label();
		this.richTextBox_0 = new RichTextBox();
		((ISupportInitialize)this.dsDocuments_0).BeginInit();
		this.tabControl_0.SuspendLayout();
		this.tabPage_0.SuspendLayout();
		((ISupportInitialize)this.dataGridView_0).BeginInit();
		this.toolStrip_0.SuspendLayout();
		this.tabPage_1.SuspendLayout();
		this.dataGridViewExcelFilter_0.BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		this.toolStrip_1.SuspendLayout();
		base.SuspendLayout();
		this.textBox_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
		this.textBox_0.BackColor = SystemColors.Window;
		this.textBox_0.Location = new Point(86, 6);
		this.textBox_0.Name = "txtSSName";
		this.textBox_0.ReadOnly = true;
		this.textBox_0.Size = new Size(622, 20);
		this.textBox_0.TabIndex = 3;
		this.label_0.AutoSize = true;
		this.label_0.Location = new Point(12, 9);
		this.label_0.Name = "label1";
		this.label_0.Size = new Size(68, 13);
		this.label_0.TabIndex = 2;
		this.label_0.Text = "Подстанция";
		this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.dsDocuments_0, "tP_DocList.DateDoc", true));
		this.dateTimePicker_0.Location = new Point(320, 11);
		this.dateTimePicker_0.Name = "dateTimePicker1";
		this.dateTimePicker_0.Size = new Size(200, 20);
		this.dateTimePicker_0.TabIndex = 13;
		this.dsDocuments_0.DataSetName = "dsDocuments";
		this.dsDocuments_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.label_1.AutoSize = true;
		this.label_1.Location = new Point(224, 14);
		this.label_1.Name = "label3";
		this.label_1.Size = new Size(90, 13);
		this.label_1.TabIndex = 12;
		this.label_1.Text = "Дата документа";
		this.textBox_1.BackColor = SystemColors.Window;
		this.textBox_1.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_DocList.NumberDoc", true));
		this.textBox_1.Location = new Point(89, 11);
		this.textBox_1.Name = "textBox1";
		this.textBox_1.Size = new Size(129, 20);
		this.textBox_1.TabIndex = 11;
		this.label_2.AutoSize = true;
		this.label_2.Location = new Point(8, 14);
		this.label_2.Name = "label2";
		this.label_2.Size = new Size(75, 13);
		this.label_2.TabIndex = 10;
		this.label_2.Text = "№ документа";
		this.label_3.AutoSize = true;
		this.label_3.Location = new Point(8, 40);
		this.label_3.Name = "label4";
		this.label_3.Size = new Size(89, 13);
		this.label_3.TabIndex = 14;
		this.label_3.Text = "Кто осматривал";
		this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
		this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
		this.comboBox_0.FormattingEnabled = true;
		this.comboBox_0.Location = new Point(110, 37);
		this.comboBox_0.Name = "cmbInspectWorker";
		this.comboBox_0.Size = new Size(237, 21);
		this.comboBox_0.TabIndex = 15;
		this.tabControl_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.tabControl_0.Controls.Add(this.tabPage_0);
		this.tabControl_0.Controls.Add(this.tabPage_1);
		this.tabControl_0.Location = new Point(0, 32);
		this.tabControl_0.Name = "tabControl1";
		this.tabControl_0.SelectedIndex = 0;
		this.tabControl_0.Size = new Size(718, 369);
		this.tabControl_0.TabIndex = 16;
		this.tabPage_0.Controls.Add(this.richTextBox_0);
		this.tabPage_0.Controls.Add(this.label_5);
		this.tabPage_0.Controls.Add(this.dataGridView_0);
		this.tabPage_0.Controls.Add(this.toolStrip_0);
		this.tabPage_0.Controls.Add(this.label_4);
		this.tabPage_0.Controls.Add(this.label_2);
		this.tabPage_0.Controls.Add(this.comboBox_0);
		this.tabPage_0.Controls.Add(this.textBox_1);
		this.tabPage_0.Controls.Add(this.label_3);
		this.tabPage_0.Controls.Add(this.label_1);
		this.tabPage_0.Controls.Add(this.dateTimePicker_0);
		this.tabPage_0.Location = new Point(4, 22);
		this.tabPage_0.Name = "tabPageGeneral";
		this.tabPage_0.Padding = new Padding(3);
		this.tabPage_0.Size = new Size(710, 343);
		this.tabPage_0.TabIndex = 0;
		this.tabPage_0.Text = "Общие";
		this.tabPage_0.UseVisualStyleBackColor = true;
		this.dataGridView_0.AllowUserToAddRows = false;
		this.dataGridView_0.AllowUserToDeleteRows = false;
		this.dataGridView_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewTextBoxColumn_0,
			this.dataGridViewTextBoxColumn_1,
			this.dataGridViewTextBoxColumn_2,
			this.dataGridViewTextBoxColumn_3,
			this.dataGridViewTextBoxColumn_4
		});
		this.dataGridView_0.Location = new Point(0, 109);
		this.dataGridView_0.Name = "dgvDocReason";
		this.dataGridView_0.ReadOnly = true;
		this.dataGridView_0.Size = new Size(710, 129);
		this.dataGridView_0.TabIndex = 18;
		this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_0.HeaderText = "№ документа";
		this.dataGridViewTextBoxColumn_0.Name = "columnNumDoc";
		this.dataGridViewTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_1.HeaderText = "Дата";
		this.dataGridViewTextBoxColumn_1.Name = "columnDateDoc";
		this.dataGridViewTextBoxColumn_1.ReadOnly = true;
		this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewTextBoxColumn_2.HeaderText = "Тип документа";
		this.dataGridViewTextBoxColumn_2.Name = "columnTypeDoc";
		this.dataGridViewTextBoxColumn_2.ReadOnly = true;
		this.dataGridViewTextBoxColumn_3.HeaderText = "idTypeDoc";
		this.dataGridViewTextBoxColumn_3.Name = "columndIdTypeDoc";
		this.dataGridViewTextBoxColumn_3.ReadOnly = true;
		this.dataGridViewTextBoxColumn_3.Visible = false;
		this.dataGridViewTextBoxColumn_4.HeaderText = "Id";
		this.dataGridViewTextBoxColumn_4.Name = "columnIdDoc";
		this.dataGridViewTextBoxColumn_4.ReadOnly = true;
		this.dataGridViewTextBoxColumn_4.Visible = false;
		this.toolStrip_0.Dock = DockStyle.None;
		this.toolStrip_0.GripStyle = ToolStripGripStyle.Hidden;
		this.toolStrip_0.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_0,
			this.toolStripButton_1,
			this.toolStripButton_2
		});
		this.toolStrip_0.Location = new Point(11, 81);
		this.toolStrip_0.Name = "toolStrip1";
		this.toolStrip_0.Size = new Size(72, 25);
		this.toolStrip_0.TabIndex = 17;
		this.toolStrip_0.Text = "toolStrip1";
		this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_0.Image = Resources.ElementAdd;
		this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_0.Name = "toolBtnAddDocReason";
		this.toolStripButton_0.Size = new Size(23, 22);
		this.toolStripButton_0.Text = "toolStripButton1";
		this.toolStripButton_0.Click += this.toolStripButton_0_Click;
		this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_1.Image = Resources.ElementEdit;
		this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_1.Name = "toolBtnEditDocReason";
		this.toolStripButton_1.Size = new Size(23, 22);
		this.toolStripButton_1.Text = "toolStripButton2";
		this.toolStripButton_1.Click += this.toolStripButton_1_Click;
		this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_2.Image = Resources.ElementDel;
		this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_2.Name = "toolBtnDelDocReason";
		this.toolStripButton_2.Size = new Size(23, 22);
		this.toolStripButton_2.Text = "toolStripButton3";
		this.toolStripButton_2.Click += this.toolStripButton_2_Click;
		this.label_4.AutoSize = true;
		this.label_4.Location = new Point(8, 68);
		this.label_4.Name = "label5";
		this.label_4.Size = new Size(129, 13);
		this.label_4.TabIndex = 16;
		this.label_4.Text = "Документы (основание)";
		this.tabPage_1.Controls.Add(this.dataGridViewExcelFilter_0);
		this.tabPage_1.Controls.Add(this.toolStrip_1);
		this.tabPage_1.Location = new Point(4, 22);
		this.tabPage_1.Name = "tabPageFile";
		this.tabPage_1.Padding = new Padding(3);
		this.tabPage_1.Size = new Size(549, 231);
		this.tabPage_1.TabIndex = 1;
		this.tabPage_1.Text = "Файл";
		this.tabPage_1.UseVisualStyleBackColor = true;
		this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
		this.dataGridViewExcelFilter_0.AllowUserToResizeColumns = false;
		this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
		this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
		this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
		{
			this.dataGridViewFilterTextBoxColumn_0,
			this.dataGridViewTextBoxColumn_5,
			this.dataGridViewTextBoxColumn_6,
			this.dataGridViewTextBoxColumn_7,
			this.dataGridViewImageColumnNotNull_0
		});
		this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
		this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
		this.dataGridViewExcelFilter_0.EditMode = DataGridViewEditMode.EditProgrammatically;
		this.dataGridViewExcelFilter_0.Location = new Point(3, 28);
		this.dataGridViewExcelFilter_0.Name = "dgvFile";
		this.dataGridViewExcelFilter_0.ReadOnly = true;
		this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
		this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		this.dataGridViewExcelFilter_0.Size = new Size(543, 200);
		this.dataGridViewExcelFilter_0.TabIndex = 7;
		this.dataGridViewExcelFilter_0.VirtualMode = true;
		this.dataGridViewExcelFilter_0.CellDoubleClick += this.dataGridViewExcelFilter_0_CellDoubleClick;
		this.dataGridViewExcelFilter_0.CellEndEdit += this.dataGridViewExcelFilter_0_CellEndEdit;
		this.dataGridViewExcelFilter_0.CellValidating += this.dataGridViewExcelFilter_0_CellValidating;
		this.dataGridViewExcelFilter_0.CellValueNeeded += this.dataGridViewExcelFilter_0_CellValueNeeded;
		this.dataGridViewFilterTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "FileName";
		this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Файл";
		this.dataGridViewFilterTextBoxColumn_0.Name = "fileNameDgvColumn";
		this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
		this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
		this.dataGridViewTextBoxColumn_5.DataPropertyName = "id";
		this.dataGridViewTextBoxColumn_5.HeaderText = "id";
		this.dataGridViewTextBoxColumn_5.Name = "id";
		this.dataGridViewTextBoxColumn_5.ReadOnly = true;
		this.dataGridViewTextBoxColumn_5.Visible = false;
		this.dataGridViewTextBoxColumn_6.DataPropertyName = "dateChange";
		this.dataGridViewTextBoxColumn_6.HeaderText = "dateChange";
		this.dataGridViewTextBoxColumn_6.Name = "dateChangeDgvColumn";
		this.dataGridViewTextBoxColumn_6.ReadOnly = true;
		this.dataGridViewTextBoxColumn_6.Visible = false;
		this.dataGridViewTextBoxColumn_7.DataPropertyName = "idTemplate";
		this.dataGridViewTextBoxColumn_7.HeaderText = "idTemplate";
		this.dataGridViewTextBoxColumn_7.Name = "idTemplateDgvColumn";
		this.dataGridViewTextBoxColumn_7.ReadOnly = true;
		this.dataGridViewTextBoxColumn_7.Visible = false;
		dataGridViewCellStyle.NullValue = null;
		this.dataGridViewImageColumnNotNull_0.DefaultCellStyle = dataGridViewCellStyle;
		this.dataGridViewImageColumnNotNull_0.HeaderText = "";
		this.dataGridViewImageColumnNotNull_0.ImageLayout = DataGridViewImageCellLayout.Zoom;
		this.dataGridViewImageColumnNotNull_0.Name = "imageDgvColumn";
		this.dataGridViewImageColumnNotNull_0.ReadOnly = true;
		this.dataGridViewImageColumnNotNull_0.Width = 30;
		this.bindingSource_0.DataMember = "tP_DocFile";
		this.bindingSource_0.DataSource = this.dsDocuments_0;
		this.toolStrip_1.Items.AddRange(new ToolStripItem[]
		{
			this.toolStripButton_8,
			this.toolStripButton_3,
			this.toolStripButton_4,
			this.toolStripButton_5,
			this.toolStripSeparator_0,
			this.toolStripButton_6,
			this.toolStripButton_7
		});
		this.toolStrip_1.Location = new Point(3, 3);
		this.toolStrip_1.Name = "toolStripFile";
		this.toolStrip_1.Size = new Size(543, 25);
		this.toolStrip_1.TabIndex = 1;
		this.toolStrip_1.Text = "toolStrip1";
		this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_8.Image = Resources.ElementAdd;
		this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_8.Name = "toolBtnAddFile";
		this.toolStripButton_8.Size = new Size(23, 22);
		this.toolStripButton_8.Text = "Добавить файл";
		this.toolStripButton_8.Click += this.toolStripButton_8_Click;
		this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_3.Image = Resources.ElementEdit;
		this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_3.Name = "toolBtnEditFile";
		this.toolStripButton_3.Size = new Size(23, 22);
		this.toolStripButton_3.Text = "Редактировать файл";
		this.toolStripButton_3.Click += this.toolStripButton_3_Click;
		this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_4.Image = Resources.ElementInformation;
		this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_4.Name = "toolBtnOpenFile";
		this.toolStripButton_4.Size = new Size(23, 22);
		this.toolStripButton_4.Text = "Открыть файл";
		this.toolStripButton_4.Click += this.toolStripButton_4_Click;
		this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_5.Image = Resources.ElementDel;
		this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_5.Name = "toolBtnDelFile";
		this.toolStripButton_5.Size = new Size(23, 22);
		this.toolStripButton_5.Text = "Удалить файл";
		this.toolStripButton_5.Click += this.toolStripButton_5_Click;
		this.toolStripSeparator_0.Name = "toolStripSeparator3";
		this.toolStripSeparator_0.Size = new Size(6, 25);
		this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_6.Image = Resources.rename1;
		this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_6.Name = "toolBtnRenameFile";
		this.toolStripButton_6.Size = new Size(23, 22);
		this.toolStripButton_6.Text = "Переименовать";
		this.toolStripButton_6.Click += this.toolStripButton_6_Click;
		this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
		this.toolStripButton_7.Image = Resources.picture_save1;
		this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
		this.toolStripButton_7.Name = "toolBtnSaveFile";
		this.toolStripButton_7.Size = new Size(23, 22);
		this.toolStripButton_7.Text = "Сохранить файл на диск";
		this.toolStripButton_7.Click += this.toolStripButton_7_Click;
		this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_0.DialogResult = DialogResult.Cancel;
		this.button_0.Location = new Point(633, 403);
		this.button_0.Name = "buttonCancel";
		this.button_0.Size = new Size(75, 23);
		this.button_0.TabIndex = 17;
		this.button_0.Text = "Отмена";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_0_Click;
		this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
		this.button_1.DialogResult = DialogResult.OK;
		this.button_1.Location = new Point(497, 403);
		this.button_1.Name = "buttonSave";
		this.button_1.Size = new Size(130, 23);
		this.button_1.TabIndex = 18;
		this.button_1.Text = "Сохранить и закрыть";
		this.button_1.UseVisualStyleBackColor = true;
		this.button_1.Click += this.button_1_Click;
		this.label_5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
		this.label_5.AutoSize = true;
		this.label_5.Location = new Point(8, 241);
		this.label_5.Name = "label6";
		this.label_5.Size = new Size(77, 13);
		this.label_5.TabIndex = 19;
		this.label_5.Text = "Комментарий";
		this.richTextBox_0.AcceptsTab = true;
		this.richTextBox_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
		this.richTextBox_0.DataBindings.Add(new Binding("Text", this.dsDocuments_0, "tP_DocList.Comment", true));
		this.richTextBox_0.Location = new Point(0, 257);
		this.richTextBox_0.Name = "richTextBox1";
		this.richTextBox_0.Size = new Size(710, 86);
		this.richTextBox_0.TabIndex = 20;
		this.richTextBox_0.Text = "";
		base.AcceptButton = this.button_1;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.CancelButton = this.button_0;
		base.ClientSize = new Size(720, 436);
		base.Controls.Add(this.button_1);
		base.Controls.Add(this.button_0);
		base.Controls.Add(this.tabControl_0);
		base.Controls.Add(this.textBox_0);
		base.Controls.Add(this.label_0);
		base.Name = "FormInspectionSubstationAddEdit";
		this.Text = "FormInspectionSubstationAddEdit";
		base.FormClosing += this.Form1_FormClosing;
		base.Load += this.Form1_Load;
		((ISupportInitialize)this.dsDocuments_0).EndInit();
		this.tabControl_0.ResumeLayout(false);
		this.tabPage_0.ResumeLayout(false);
		this.tabPage_0.PerformLayout();
		((ISupportInitialize)this.dataGridView_0).EndInit();
		this.toolStrip_0.ResumeLayout(false);
		this.toolStrip_0.PerformLayout();
		this.tabPage_1.ResumeLayout(false);
		this.tabPage_1.PerformLayout();
		this.dataGridViewExcelFilter_0.EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		this.toolStrip_1.ResumeLayout(false);
		this.toolStrip_1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	[CompilerGenerated]
	private void method_14()
	{
		this.bindingSource_0.ResetBindings(false);
	}

	private int int_0;

	private int? nullable_0;

	private const int int_1 = 1374;

	private Dictionary<string, FileWatcherArgsAddl> dictionary_0 = new Dictionary<string, FileWatcherArgsAddl>();

	private string string_0 = "";

	private IContainer icontainer_0;

	private TextBox textBox_0;

	private Label label_0;

	private dsDocuments dsDocuments_0;

	private DateTimePicker dateTimePicker_0;

	private Label label_1;

	private TextBox textBox_1;

	private Label label_2;

	private Label label_3;

	private ComboBox comboBox_0;

	private TabControl tabControl_0;

	private TabPage tabPage_0;

	private DataGridView dataGridView_0;

	private ToolStrip toolStrip_0;

	private ToolStripButton toolStripButton_0;

	private ToolStripButton toolStripButton_1;

	private ToolStripButton toolStripButton_2;

	private Label label_4;

	private TabPage tabPage_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

	private Button button_0;

	private Button button_1;

	private BindingSource bindingSource_0;

	private ToolStrip toolStrip_1;

	private ToolStripButton toolStripButton_3;

	private ToolStripButton toolStripButton_4;

	private ToolStripButton toolStripButton_5;

	private ToolStripSeparator toolStripSeparator_0;

	private ToolStripButton toolStripButton_6;

	private ToolStripButton toolStripButton_7;

	private ToolStripButton toolStripButton_8;

	private DataGridViewExcelFilter dataGridViewExcelFilter_0;

	private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

	private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

	private DataGridViewImageColumnNotNull dataGridViewImageColumnNotNull_0;

	private RichTextBox richTextBox_0;

	private Label label_5;

	[CompilerGenerated]
	private sealed class Class99
	{
		internal bool method_0(KeyValuePair<string, FileWatcherArgsAddl> keyValuePair_0)
		{
			return keyValuePair_0.Value.TempName == this.fileSystemEventArgs_0.Name;
		}

		internal bool method_1(dsDocuments.Class191 class191_0)
		{
			return class191_0.RowState != DataRowState.Deleted && class191_0.FileName == this.ienumerable_0.First<KeyValuePair<string, FileWatcherArgsAddl>>().Value.OriginalName;
		}

		public FileSystemEventArgs fileSystemEventArgs_0;

		public IEnumerable<KeyValuePair<string, FileWatcherArgsAddl>> ienumerable_0;
	}
}
