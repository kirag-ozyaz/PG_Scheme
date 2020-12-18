using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Constants;
using DataSql;
using FormLbr;
using Passport.Controls.PanelFile;
using Passport.Forms.AirLine.Report;
using Passport.Properties;

namespace Passport.Forms.AirLine.Documents
{
	public class FormPylonEquipRepairAddEdit : FormBase
	{
		public int IdDoc
		{
			get
			{
				return this.NpimglPeBeJ;
			}
		}

		public StateFormCreate CreateState { get; set; }

		public FormPylonEquipRepairAddEdit()
		{
			Class330.Mus9JxKz1CNxy();
			this.NpimglPeBeJ = -1;
			this.int_0 = -1;
			this.int_1 = -1;
			base..ctor();
			this.method_18();
			this.method_0();
		}

		public FormPylonEquipRepairAddEdit(int IdObjList, int IdDoc, int IdDocType)
		{
			Class330.Mus9JxKz1CNxy();
			this.NpimglPeBeJ = -1;
			this.int_0 = -1;
			this.int_1 = -1;
			base..ctor();
			this.method_18();
			this.method_0();
			this.int_0 = IdObjList;
			this.NpimglPeBeJ = IdDoc;
			this.int_1 = IdDocType;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.method_2();
			StateFormCreate createState = this.CreateState;
			if (createState != null)
			{
				if (createState == 1)
				{
					this.method_12();
					this.panelFile_0.method_10(this.NpimglPeBeJ);
				}
			}
			else
			{
				this.method_11();
				this.method_10();
			}
			if (this.dataTable_2 == null || this.dataTable_2.Rows.Count == 0)
			{
				this.dataTable_2.Rows.Add(this.dataTable_2.NewRow());
			}
			this.method_1();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			FormPylonEquipRepairAddEdit.acsagR9MmRVeVo0KOV6U(this, e);
			if (base.DialogResult == DialogResult.OK && !this.method_13())
			{
				base.DialogResult = DialogResult.None;
				e.Cancel = true;
			}
		}

		private void method_0()
		{
			this.textBox_0.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.textBox_0.DataBindings[0].NullValue = string.Empty;
			this.richTextBox_0.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.richTextBox_0.DataBindings[0].NullValue = string.Empty;
			this.dateTimePicker_0.DataBindings[0].DataSourceNullValue = DateTime.Now;
			this.dateTimePicker_0.DataBindings[0].NullValue = DateTime.Now;
			this.comboBox_6.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.comboBox_6.DataBindings[0].NullValue = null;
			this.comboBox_0.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.comboBox_0.DataBindings[0].NullValue = null;
			this.comboBox_5.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.comboBox_5.DataBindings[0].NullValue = null;
			this.comboBox_4.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.comboBox_4.DataBindings[0].NullValue = null;
			this.comboBox_3.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.comboBox_3.DataBindings[0].NullValue = null;
			this.comboBox_2.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.comboBox_2.DataBindings[0].NullValue = null;
			this.comboBox_1.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.comboBox_1.DataBindings[0].NullValue = null;
		}

		private void method_1()
		{
			Control control = this.comboBox_0;
			Control control2 = this.comboBox_6;
			Control control3 = this.comboBox_5;
			this.comboBox_4.Enabled = true;
			control3.Enabled = true;
			control2.Enabled = true;
			control.Enabled = true;
			Control control4 = this.comboBox_3;
			Control control5 = this.comboBox_2;
			this.comboBox_1.Enabled = true;
			control5.Enabled = true;
			control4.Enabled = true;
		}

		private void method_2()
		{
			this.panelFile_0.SqlSettings = this.SqlSettings;
			this.method_3();
			this.method_4();
			this.method_5();
			this.method_7();
			this.method_8();
			this.method_9();
		}

		private void method_3()
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			string text = "where ParentKey = ';Passport;AirLine;PylonEquipExpl;WorkType;'\r\n and deleted = '0' and isGroup = '0' order by Value";
			base.SelectSqlData(dataTable, true, text, null, false, 0);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataTable;
			this.comboBox_6.DisplayMember = "Name";
			this.comboBox_6.ValueMember = "id";
			this.comboBox_6.DataSource = bindingSource;
		}

		private void method_4()
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			string text = "where ParentKey = ';Passport;AirLine;PylonEquipExpl;ReasonOfReplace;'\r\n and deleted = '0' and isGroup = '0' order by Value";
			base.SelectSqlData(dataTable, true, text, null, false, 0);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataTable;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "id";
			this.comboBox_0.DataSource = bindingSource;
		}

		private void method_5()
		{
			this.dataTable_0 = new DataTable();
			string text = string.Format("select ol.id, ol.Name from tSchm_ObjList as ol\r\ninner join tR_Classifier as c_ol on c_ol.id = ol.typeCodeId\r\nand c_ol.ParentKey = ';SCM;Pole;' and c_ol.isGroup = '0'\r\nwhere ol.deleted = '0' and (ol.idParent = '{0}'\r\nor ol.id in (Select idClutchFirst as idPylon from tP_CabSection\r\nwhere deleted = '0' and idObjList = '{0}' union\r\nselect idClutchSecond as idPylon from tP_CabSection\r\nwhere deleted = '0' and idObjList = '{0}'))\r\norder by ol.Name", this.int_0);
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			this.dataTable_0 = sqlDataCommand.SelectSqlData(text);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = this.dataTable_0;
			this.comboBox_5.DisplayMember = "Name";
			this.comboBox_5.ValueMember = "id";
			this.comboBox_5.DataSource = bindingSource;
		}

		private void method_6(int int_2)
		{
			this.comboBox_4.DataSource = null;
			this.comboBox_4.Items.Clear();
			DataTable dataTable = new DataTable("tSchm_ObjList");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			string text = string.Format("select ol.Id, ol.Name\r\nfrom tSchm_ObjList as ol\r\ninner join tR_Classifier as c on c.Id = ol.TypeCodeId\r\nand c.Deleted = '0' and c.IsGroup = '0'\r\nand ((c.ParentKey = ';SCM;InLine_Obj;Other_Obj;' and Value in (1,2))\r\n        or (c.ParentKey = ';SCM;InLine_Obj;Switch;' and Value in (8,14)))\r\nwhere ol.idParentAddl = '{0}' and ol.Deleted = '0'", int_2);
			dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataTable;
			this.comboBox_4.DisplayMember = "Name";
			this.comboBox_4.ValueMember = "id";
			this.comboBox_4.DataSource = bindingSource;
		}

		private void method_7()
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			string text = "where ParentKey = ';Passport;AirLine;PylonEquipExpl;Actions;'\r\n and deleted = '0' and isGroup = '0' order by Value";
			base.SelectSqlData(dataTable, true, text, null, false, 0);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataTable;
			this.comboBox_3.DisplayMember = "Name";
			this.comboBox_3.ValueMember = "id";
			this.comboBox_3.DataSource = bindingSource;
		}

		private void method_8()
		{
			DataTable dataTable = new DataTable("vWorkerGroup");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("FIO", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));
			base.SelectSqlData(dataTable, true, "where ParentKey = ';GroupWorker;HeadRegion;'", null, false, 0);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataTable;
			this.comboBox_2.DisplayMember = "FIO";
			this.comboBox_2.ValueMember = "id";
			this.comboBox_2.DataSource = bindingSource;
		}

		private void method_9()
		{
			DataTable dataTable = new DataTable("vWorkerGroup");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("FIO", typeof(string));
			dataTable.Columns.Add("Description", typeof(string));
			base.SelectSqlData(dataTable, true, "where ParentKey = ';GroupWorker;EngPTS;'", null, false, 0);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataTable;
			this.comboBox_1.DisplayMember = "FIO";
			this.comboBox_1.ValueMember = "id";
			this.comboBox_1.DataSource = bindingSource;
		}

		private void method_10()
		{
			string cmdText = "select Name, Comment as Unit from tR_Classifier\r\nwhere ParentKey = ';Passport;AirLine;PylonEquipExpl;CheckedParams;' and deleted = '0' and isGroup = '0'";
			using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
			{
				try
				{
					sqlConnection.Open();
					SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection);
					SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
					sqlDataAdapter.Fill(this.dataTable_1);
					sqlDataAdapter.Dispose();
					sqlCommand.Dispose();
					sqlConnection.Close();
				}
				catch
				{
					sqlConnection.Close();
				}
			}
		}

		private void method_11()
		{
			Class14.Class65 @class = this.class14_0.tP_DocList.method_4();
			@class.ParentId = -1;
			@class.idObjList = this.int_0;
			@class.DateDoc = this.dateTimePicker_0.Value;
			@class.NumberDoc = this.textBox_0.Text;
			@class.TypeDoc = this.int_1;
			@class.Comment = this.richTextBox_0.Text;
			@class.isActive = true;
			@class.Deleted = false;
			this.class14_0.tP_DocList.method_0(@class);
		}

		private void method_12()
		{
			string text = string.Format("where id = '{0}'", this.NpimglPeBeJ);
			base.SelectSqlData(this.class14_0.tP_DocList, true, text, null, false, 0);
			if (this.class14_0.tP_DocList.Rows.Count > 0 && this.class14_0.tP_DocList[0]["DataXml"] != DBNull.Value && Convert.ToString(this.class14_0.tP_DocList[0]["DataXml"]) != string.Empty)
			{
				this.method_15(Convert.ToString(this.class14_0.tP_DocList[0]["DataXml"]));
			}
		}

		private bool method_13()
		{
			this.class14_0.tP_DocList[0]["DataXml"] = this.method_16();
			this.class14_0.tP_DocList[0].EndEdit();
			StateFormCreate createState = this.CreateState;
			if (createState != null)
			{
				if (createState == 1)
				{
					if (!base.UpdateSqlDataOnlyChange(this.class14_0.tP_DocList))
					{
						return false;
					}
				}
			}
			else
			{
				this.NpimglPeBeJ = base.InsertSqlDataOneRow(this.class14_0.tP_DocList[0]);
				if (this.NpimglPeBeJ == -1)
				{
					return false;
				}
			}
			return this.method_14();
		}

		private bool method_14()
		{
			if (this.panelFile_0.IsSave)
			{
				if (this.NpimglPeBeJ != -1)
				{
					return this.panelFile_0.method_11(this.NpimglPeBeJ);
				}
			}
			return true;
		}

		private void method_15(string string_0)
		{
			XmlReader reader = XDocument.Load(new StringReader(string_0)).Root.CreateReader();
			this.dataSet_0.Clear();
			this.dataSet_0.ReadXml(reader);
		}

		private XDocument method_16()
		{
			XDocument xdocument = new XDocument();
			MemoryStream memoryStream = new MemoryStream();
			this.dataSet_0.WriteXml(memoryStream);
			memoryStream.Position = 0L;
			XDocument xdocument2 = XDocument.Load(XmlReader.Create(memoryStream));
			xdocument.Add(new XElement("AddlData", xdocument2.Root));
			return xdocument;
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void dataGridView_0_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			Class316.smethod_0(sender, e);
		}

		private void dataGridView_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
		}

		private void dataGridView_0_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			if (e.Control is DataGridViewComboBoxEditingControl)
			{
				DataGridViewComboBoxEditingControl dataGridViewComboBoxEditingControl = (DataGridViewComboBoxEditingControl)e.Control;
				dataGridViewComboBoxEditingControl.DropDownStyle = ComboBoxStyle.DropDown;
				dataGridViewComboBoxEditingControl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
				dataGridViewComboBoxEditingControl.AutoCompleteSource = AutoCompleteSource.ListItems;
			}
		}

		private void dataGridView_0_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			if (dataGridView.IsCurrentCellDirty)
			{
				dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void NrnmghjaDas(object sender, DataGridViewCellEventArgs e)
		{
		}

		private int method_17(string string_0, decimal decimal_0)
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			dataTable.Columns.Add("Value");
			string text = string.Format("where ParentKey = '{0}' and Value = '{1}' and deleted = '0' and isGroup = '0'", string_0, decimal_0);
			base.SelectSqlData(dataTable, true, text, null, false, 0);
			if (dataTable.Rows.Count > 0)
			{
				return Convert.ToInt32(dataTable.Rows[0]["id"]);
			}
			return -1;
		}

		private void comboBox_5_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_5.SelectedItem == null)
			{
				return;
			}
			this.method_6(Convert.ToInt32(this.comboBox_5.SelectedValue));
		}

		private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_2.SelectedItem == null)
			{
				this.label_5.Text = string.Empty;
				return;
			}
			this.label_5.Text = Convert.ToString(((DataRowView)this.comboBox_2.SelectedItem).Row["Description"]);
		}

		private void comboBox_2_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.comboBox_2.SelectedItem == null)
			{
				this.label_5.Text = string.Empty;
				return;
			}
			this.label_5.Text = Convert.ToString(((DataRowView)this.comboBox_2.SelectedItem).Row["Description"]);
		}

		private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_1.SelectedItem == null)
			{
				this.label_4.Text = string.Empty;
				return;
			}
			this.label_4.Text = Convert.ToString(((DataRowView)this.comboBox_1.SelectedItem).Row["Description"]);
		}

		private void comboBox_1_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.comboBox_1.SelectedItem == null)
			{
				this.label_4.Text = string.Empty;
				return;
			}
			this.label_4.Text = Convert.ToString(((DataRowView)this.comboBox_1.SelectedItem).Row["Description"]);
		}

		private void MqimgiqVmgT(object sender, EventArgs e)
		{
			new FormReportAirLineDocs(this.int_0, this.NpimglPeBeJ)
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent,
				StartPosition = FormStartPosition.CenterScreen,
				IdTypeDoc = this.method_17(";TypeDoc;tPeassport;AirLine;", 4m)
			}.Show();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_18()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.JasmgRpjUpp = new Label();
			this.textBox_0 = new TextBox();
			this.class14_0 = new Class14();
			this.label_0 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_1 = new Label();
			this.comboBox_0 = new ComboBox();
			this.dataSet_0 = new DataSet();
			this.dataTable_1 = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.dataColumn_2 = new DataColumn();
			this.dataTable_2 = new DataTable();
			this.dataColumn_3 = new DataColumn();
			this.dataColumn_4 = new DataColumn();
			this.dataColumn_5 = new DataColumn();
			this.dataColumn_6 = new DataColumn();
			this.dataColumn_7 = new DataColumn();
			this.dataColumn_8 = new DataColumn();
			this.dataColumn_9 = new DataColumn();
			this.label_2 = new Label();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.label_10 = new Label();
			this.comboBox_6 = new ComboBox();
			this.comboBox_1 = new ComboBox();
			this.comboBox_2 = new ComboBox();
			this.label_4 = new Label();
			this.label_5 = new Label();
			this.label_6 = new Label();
			this.comboBox_3 = new ComboBox();
			this.label_7 = new Label();
			this.comboBox_4 = new ComboBox();
			this.label_8 = new Label();
			this.comboBox_5 = new ComboBox();
			this.label_9 = new Label();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.label_3 = new Label();
			this.richTextBox_0 = new RichTextBox();
			this.tabPage_1 = new TabPage();
			this.panelFile_0 = new PanelFile();
			this.panel_0 = new Panel();
			this.button_2 = new Button();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			((ISupportInitialize)this.class14_0).BeginInit();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_1).BeginInit();
			((ISupportInitialize)this.dataTable_2).BeginInit();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			this.tabPage_1.SuspendLayout();
			this.panel_0.SuspendLayout();
			base.SuspendLayout();
			this.JasmgRpjUpp.AutoSize = true;
			this.JasmgRpjUpp.Location = new Point(8, 9);
			this.JasmgRpjUpp.Name = "label1";
			this.JasmgRpjUpp.Size = new Size(98, 13);
			this.JasmgRpjUpp.TabIndex = 0;
			this.JasmgRpjUpp.Text = "Номер документа";
			this.textBox_0.DataBindings.Add(new Binding("Text", this.class14_0, "tP_DocList.NumberDoc", true));
			this.textBox_0.Location = new Point(112, 6);
			this.textBox_0.Name = "txtNumberDoc";
			this.textBox_0.Size = new Size(100, 20);
			this.textBox_0.TabIndex = 0;
			this.class14_0.DataSetName = "dsDocuments";
			this.class14_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(243, 9);
			this.label_0.Name = "label2";
			this.label_0.Size = new Size(90, 13);
			this.label_0.TabIndex = 2;
			this.label_0.Text = "Дата документа";
			this.dateTimePicker_0.DataBindings.Add(new Binding("Text", this.class14_0, "tP_DocList.DateDoc", true));
			this.dateTimePicker_0.Location = new Point(339, 6);
			this.dateTimePicker_0.Name = "dtpDateDoc";
			this.dateTimePicker_0.Size = new Size(125, 20);
			this.dateTimePicker_0.TabIndex = 1;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(8, 62);
			this.label_1.Name = "label3";
			this.label_1.Size = new Size(50, 13);
			this.label_1.TabIndex = 4;
			this.label_1.Text = "Причина";
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tOther.idReason", true));
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(112, 59);
			this.comboBox_0.Name = "cmbReason";
			this.comboBox_0.Size = new Size(173, 21);
			this.comboBox_0.TabIndex = 3;
			this.dataSet_0.DataSetName = "DataSetPylonEquipRepair";
			this.dataSet_0.Tables.AddRange(new DataTable[]
			{
				this.dataTable_1,
				this.dataTable_2
			});
			this.dataTable_1.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.dataColumn_2
			});
			this.dataTable_1.TableName = "tParam";
			this.dataColumn_0.ColumnName = "Name";
			this.dataColumn_1.ColumnName = "Unit";
			this.dataColumn_2.ColumnName = "Count";
			this.dataTable_2.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_3,
				this.dataColumn_4,
				this.dataColumn_5,
				this.dataColumn_6,
				this.dataColumn_7,
				this.dataColumn_8,
				this.dataColumn_9
			});
			this.dataTable_2.TableName = "tOther";
			this.dataColumn_3.ColumnName = "idTypeWork";
			this.dataColumn_3.DataType = typeof(int);
			this.dataColumn_4.ColumnName = "idReason";
			this.dataColumn_4.DataType = typeof(int);
			this.dataColumn_5.ColumnName = "idPylon";
			this.dataColumn_5.DataType = typeof(int);
			this.dataColumn_6.ColumnName = "idEquipment";
			this.dataColumn_6.DataType = typeof(int);
			this.dataColumn_7.ColumnName = "idHeadRegion";
			this.dataColumn_7.DataType = typeof(int);
			this.dataColumn_8.ColumnName = "idEngineerPTS";
			this.dataColumn_8.DataType = typeof(int);
			this.dataColumn_9.ColumnName = "idAction";
			this.dataColumn_9.DataType = typeof(int);
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(8, 140);
			this.label_2.Margin = new Padding(3);
			this.label_2.Name = "label4";
			this.label_2.Size = new Size(139, 13);
			this.label_2.TabIndex = 6;
			this.label_2.Text = "Проверяемые параметры";
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(0, 0);
			this.tabControl_0.Name = "tabControl1";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(484, 545);
			this.tabControl_0.TabIndex = 12;
			this.tabPage_0.Controls.Add(this.label_10);
			this.tabPage_0.Controls.Add(this.comboBox_6);
			this.tabPage_0.Controls.Add(this.comboBox_1);
			this.tabPage_0.Controls.Add(this.comboBox_2);
			this.tabPage_0.Controls.Add(this.label_4);
			this.tabPage_0.Controls.Add(this.label_5);
			this.tabPage_0.Controls.Add(this.label_6);
			this.tabPage_0.Controls.Add(this.comboBox_3);
			this.tabPage_0.Controls.Add(this.label_7);
			this.tabPage_0.Controls.Add(this.comboBox_4);
			this.tabPage_0.Controls.Add(this.label_8);
			this.tabPage_0.Controls.Add(this.comboBox_5);
			this.tabPage_0.Controls.Add(this.label_9);
			this.tabPage_0.Controls.Add(this.dataGridView_0);
			this.tabPage_0.Controls.Add(this.label_3);
			this.tabPage_0.Controls.Add(this.richTextBox_0);
			this.tabPage_0.Controls.Add(this.JasmgRpjUpp);
			this.tabPage_0.Controls.Add(this.label_2);
			this.tabPage_0.Controls.Add(this.textBox_0);
			this.tabPage_0.Controls.Add(this.comboBox_0);
			this.tabPage_0.Controls.Add(this.label_0);
			this.tabPage_0.Controls.Add(this.label_1);
			this.tabPage_0.Controls.Add(this.dateTimePicker_0);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tpBase";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(476, 519);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Общее";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.label_10.AutoSize = true;
			this.label_10.Location = new Point(8, 35);
			this.label_10.Name = "label11";
			this.label_10.Size = new Size(58, 13);
			this.label_10.TabIndex = 19;
			this.label_10.Text = "Вид работ";
			this.comboBox_6.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tOther.idTypeWork", true));
			this.comboBox_6.FormattingEnabled = true;
			this.comboBox_6.Location = new Point(112, 32);
			this.comboBox_6.Name = "cmbTypeWork";
			this.comboBox_6.Size = new Size(173, 21);
			this.comboBox_6.TabIndex = 2;
			this.comboBox_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tOther.idEngineerPTS", true));
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(246, 492);
			this.comboBox_1.Name = "cmbEngineerPTS";
			this.comboBox_1.Size = new Size(218, 21);
			this.comboBox_1.TabIndex = 9;
			this.comboBox_1.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
			this.comboBox_1.SelectedValueChanged += this.comboBox_1_SelectedValueChanged;
			this.comboBox_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tOther.idHeadRegion", true));
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(246, 465);
			this.comboBox_2.Name = "cmbHeadNetRegion";
			this.comboBox_2.Size = new Size(218, 21);
			this.comboBox_2.TabIndex = 8;
			this.comboBox_2.SelectedIndexChanged += this.comboBox_2_SelectedIndexChanged;
			this.comboBox_2.SelectedValueChanged += this.comboBox_2_SelectedValueChanged;
			this.label_4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(90, 495);
			this.label_4.Name = "lblEngineerPTS";
			this.label_4.Size = new Size(78, 13);
			this.label_4.TabIndex = 17;
			this.label_4.Text = "Инженер ПТС";
			this.label_5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(90, 468);
			this.label_5.Name = "lblHeadRegion";
			this.label_5.Size = new Size(150, 13);
			this.label_5.TabIndex = 16;
			this.label_5.Text = "Начальник сетевого района";
			this.label_6.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(8, 468);
			this.label_6.Margin = new Padding(3, 3, 3, 0);
			this.label_6.Name = "label9";
			this.label_6.Size = new Size(77, 13);
			this.label_6.TabIndex = 15;
			this.label_6.Text = "Исполнители:";
			this.comboBox_3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.comboBox_3.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tOther.idAction", true));
			this.comboBox_3.FormattingEnabled = true;
			this.comboBox_3.Location = new Point(103, 354);
			this.comboBox_3.Name = "cmbAction";
			this.comboBox_3.Size = new Size(361, 21);
			this.comboBox_3.TabIndex = 6;
			this.label_7.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label_7.AutoSize = true;
			this.label_7.Location = new Point(8, 357);
			this.label_7.Margin = new Padding(3, 3, 3, 0);
			this.label_7.Name = "label8";
			this.label_7.Size = new Size(89, 13);
			this.label_7.TabIndex = 13;
			this.label_7.Text = "Принятые меры";
			this.comboBox_4.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tOther.idEquipment", true));
			this.comboBox_4.FormattingEnabled = true;
			this.comboBox_4.Location = new Point(112, 113);
			this.comboBox_4.Name = "cmbEquipment";
			this.comboBox_4.Size = new Size(173, 21);
			this.comboBox_4.TabIndex = 4;
			this.label_8.AutoSize = true;
			this.label_8.Location = new Point(8, 116);
			this.label_8.Name = "label7";
			this.label_8.Size = new Size(80, 13);
			this.label_8.TabIndex = 11;
			this.label_8.Text = "Оборудование";
			this.comboBox_5.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tOther.idPylon", true));
			this.comboBox_5.FormattingEnabled = true;
			this.comboBox_5.Location = new Point(112, 86);
			this.comboBox_5.Name = "cmbPylon";
			this.comboBox_5.Size = new Size(173, 21);
			this.comboBox_5.TabIndex = 3;
			this.comboBox_5.SelectedIndexChanged += this.comboBox_5_SelectedIndexChanged;
			this.label_9.AutoSize = true;
			this.label_9.Location = new Point(8, 89);
			this.label_9.Name = "label6";
			this.label_9.Size = new Size(39, 13);
			this.label_9.TabIndex = 9;
			this.label_9.Text = "Опора";
			this.dataGridView_0.AllowUserToAddRows = false;
			this.dataGridView_0.AllowUserToDeleteRows = false;
			this.dataGridView_0.AllowUserToOrderColumns = true;
			this.dataGridView_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left);
			this.dataGridView_0.AutoGenerateColumns = false;
			this.dataGridView_0.BackgroundColor = SystemColors.Window;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3
			});
			this.dataGridView_0.DataSource = this.bindingSource_0;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.Window;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Menu;
			dataGridViewCellStyle.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.Location = new Point(0, 159);
			this.dataGridView_0.Name = "dgvWork";
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(476, 186);
			this.dataGridView_0.TabIndex = 5;
			this.dataGridView_0.CellValueChanged += this.NrnmghjaDas;
			this.dataGridView_0.CurrentCellDirtyStateChanged += this.dataGridView_0_CurrentCellDirtyStateChanged;
			this.dataGridView_0.EditingControlShowing += this.dataGridView_0_EditingControlShowing;
			this.dataGridView_0.RowPrePaint += this.dataGridView_0_RowPrePaint;
			this.dataGridView_0.RowsAdded += this.dataGridView_0_RowsAdded;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_0.HeaderText = "id";
			this.dataGridViewTextBoxColumn_0.Name = "idDgvWork";
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_1.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_1.MinimumWidth = 70;
			this.dataGridViewTextBoxColumn_1.Name = "nameDgvWork";
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "Unit";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Ед. изм.";
			this.dataGridViewTextBoxColumn_2.Name = "unitDgvWork";
			this.dataGridViewTextBoxColumn_2.Width = 70;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn_3.HeaderText = "Кол-во";
			this.dataGridViewTextBoxColumn_3.Name = "countDgvWork";
			this.dataGridViewTextBoxColumn_3.Width = 70;
			this.bindingSource_0.DataMember = "tParam";
			this.bindingSource_0.DataSource = this.dataSet_0;
			this.label_3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(8, 381);
			this.label_3.Margin = new Padding(3, 3, 3, 0);
			this.label_3.Name = "label5";
			this.label_3.Size = new Size(69, 13);
			this.label_3.TabIndex = 8;
			this.label_3.Text = "Заключение";
			this.richTextBox_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.richTextBox_0.DataBindings.Add(new Binding("Text", this.class14_0, "tP_DocList.Comment", true));
			this.richTextBox_0.Location = new Point(11, 397);
			this.richTextBox_0.Name = "rtxtComment";
			this.richTextBox_0.Size = new Size(453, 62);
			this.richTextBox_0.TabIndex = 7;
			this.richTextBox_0.Text = "";
			this.tabPage_1.Controls.Add(this.panelFile_0);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tpFile";
			this.tabPage_1.Padding = new Padding(3);
			this.tabPage_1.Size = new Size(476, 519);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "Файлы";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.panelFile_0.Dock = DockStyle.Fill;
			this.panelFile_0.IdParent = 0;
			this.panelFile_0.Location = new Point(3, 3);
			this.panelFile_0.Name = "pFile";
			this.panelFile_0.Size = new Size(470, 513);
			this.panelFile_0.TabIndex = 0;
			this.panel_0.Controls.Add(this.button_2);
			this.panel_0.Controls.Add(this.button_0);
			this.panel_0.Controls.Add(this.button_1);
			this.panel_0.Dock = DockStyle.Bottom;
			this.panel_0.Location = new Point(0, 545);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(484, 52);
			this.panel_0.TabIndex = 8;
			this.button_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.button_2.BackgroundImage = Resources.smethod_44();
			this.button_2.BackgroundImageLayout = ImageLayout.Center;
			this.button_2.Location = new Point(278, 17);
			this.button_2.Name = "btnPrint";
			this.button_2.Size = new Size(34, 23);
			this.button_2.TabIndex = 12;
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.MqimgiqVmgT;
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Location = new Point(399, 17);
			this.button_0.Name = "btnCancel";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 11;
			this.button_0.Text = "Отмена";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_1_Click;
			this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.button_1.DialogResult = DialogResult.OK;
			this.button_1.Location = new Point(318, 17);
			this.button_1.Name = "btnOK";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 10;
			this.button_1.Text = "ОК";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_4.HeaderText = "id";
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_5.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_5.MinimumWidth = 70;
			this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "Unit";
			this.dataGridViewTextBoxColumn_6.HeaderText = "Ед. изм.";
			this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_6.Width = 70;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn_7.HeaderText = "Кол-во";
			this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_7.Width = 70;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(484, 597);
			base.Controls.Add(this.tabControl_0);
			base.Controls.Add(this.panel_0);
			base.Name = "FormPylonEquipRepairAddEdit";
			this.Text = "Акт проверки и ремонт обор-я";
			((ISupportInitialize)this.class14_0).EndInit();
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_1).EndInit();
			((ISupportInitialize)this.dataTable_2).EndInit();
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tabPage_0.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			this.tabPage_1.ResumeLayout(false);
			this.panel_0.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		internal static void acsagR9MmRVeVo0KOV6U(Form form_0, CancelEventArgs cancelEventArgs_0)
		{
			form_0.OnClosing(cancelEventArgs_0);
		}

		private int NpimglPeBeJ;

		private int int_0;

		private int int_1;

		private DataTable dataTable_0;

		[CompilerGenerated]
		private StateFormCreate stateFormCreate_0;

		private IContainer icontainer_0;

		private Label JasmgRpjUpp;

		private TextBox textBox_0;

		private Label label_0;

		private DateTimePicker dateTimePicker_0;

		private Label label_1;

		private ComboBox comboBox_0;

		private Label label_2;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private TabPage tabPage_1;

		private PanelFile panelFile_0;

		private DataGridView dataGridView_0;

		private Panel panel_0;

		private Button button_0;

		private Button button_1;

		private BindingSource bindingSource_0;

		private DataSet dataSet_0;

		private DataTable dataTable_1;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private Class14 class14_0;

		private Label label_3;

		private RichTextBox richTextBox_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private ComboBox comboBox_1;

		private ComboBox comboBox_2;

		private Label label_4;

		private Label label_5;

		private Label label_6;

		private ComboBox comboBox_3;

		private Label label_7;

		private ComboBox comboBox_4;

		private Label label_8;

		private ComboBox comboBox_5;

		private Label label_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private Label label_10;

		private ComboBox comboBox_6;

		private DataTable dataTable_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private DataColumn dataColumn_5;

		private DataColumn dataColumn_6;

		private DataColumn dataColumn_7;

		private DataColumn dataColumn_8;

		private DataColumn dataColumn_9;

		private Button button_2;
	}
}
