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
	public class FormAirLineRepairAddEdit : FormBase
	{
		public int IdDoc
		{
			get
			{
				return this.int_0;
			}
		}

		public StateFormCreate CreateState { get; set; }

		public FormAirLineRepairAddEdit()
		{
			Class330.Mus9JxKz1CNxy();
			this.int_0 = -1;
			this.int_1 = -1;
			this.int_2 = -1;
			base..ctor();
			this.method_13();
			this.method_1();
		}

		public FormAirLineRepairAddEdit(int IdObjList, int IdDoc, int IdDocType)
		{
			Class330.Mus9JxKz1CNxy();
			this.int_0 = -1;
			this.int_1 = -1;
			this.int_2 = -1;
			base..ctor();
			this.method_13();
			this.method_1();
			this.int_1 = IdObjList;
			this.int_0 = IdDoc;
			this.int_2 = IdDocType;
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
					Control lcYmdzXgeJB = this.LcYmdzXgeJB;
					this.LcYmdzXgeJB.Visible = true;
					lcYmdzXgeJB.Enabled = true;
					this.mdSmrdyrJbc();
					this.panelFile_0.method_10(this.int_0);
				}
			}
			else
			{
				Control lcYmdzXgeJB2 = this.LcYmdzXgeJB;
				this.LcYmdzXgeJB.Visible = false;
				lcYmdzXgeJB2.Enabled = false;
				this.method_7();
				this.method_6();
			}
			if (this.dataTable_3 == null || this.dataTable_3.Rows.Count == 0)
			{
				this.dataTable_3.Rows.Add(this.dataTable_3.NewRow());
			}
			this.method_0();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			FormAirLineRepairAddEdit.kfUR8K9CR2ZSPEGQfQng(this, e);
			if (base.DialogResult == DialogResult.OK && !this.method_8())
			{
				base.DialogResult = DialogResult.None;
				e.Cancel = true;
			}
		}

		private void method_0()
		{
			this.comboBox_0.Enabled = true;
			this.textBox_3.Enabled = true;
			this.textBox_2.Enabled = true;
			this.UsEmdDtpEgP.Enabled = true;
			this.textBox_1.Enabled = true;
			this.textBox_4.Enabled = true;
			this.comboBox_2.Enabled = true;
			this.comboBox_1.Enabled = true;
		}

		private void method_1()
		{
			this.textBox_0.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.textBox_0.DataBindings[0].NullValue = string.Empty;
			this.eemmdYmToXE.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.eemmdYmToXE.DataBindings[0].NullValue = string.Empty;
			this.dateTimePicker_0.DataBindings[0].DataSourceNullValue = DateTime.Now;
			this.dateTimePicker_0.DataBindings[0].NullValue = DateTime.Now;
			this.comboBox_0.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.comboBox_0.DataBindings[0].NullValue = null;
			this.textBox_3.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.textBox_3.DataBindings[0].NullValue = string.Empty;
			this.textBox_2.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.textBox_2.DataBindings[0].NullValue = string.Empty;
			this.UsEmdDtpEgP.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.UsEmdDtpEgP.DataBindings[0].NullValue = string.Empty;
			this.textBox_1.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.textBox_1.DataBindings[0].NullValue = string.Empty;
			this.textBox_4.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.textBox_4.DataBindings[0].NullValue = string.Empty;
			this.comboBox_2.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.comboBox_2.DataBindings[0].NullValue = null;
			this.comboBox_1.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.comboBox_1.DataBindings[0].NullValue = null;
		}

		private void method_2()
		{
			this.panelFile_0.SqlSettings = this.SqlSettings;
			this.method_3();
			this.method_4();
			this.bljmritkbZn();
			this.method_5();
		}

		private void method_3()
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			string text = "where ParentKey = ';Passport;AirLine;AirLineExpl;ReasonOfRepair;'\r\n and deleted = '0' and isGroup = '0' order by Value";
			base.SelectSqlData(dataTable, true, text, null, false, 0);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataTable;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "id";
			this.comboBox_0.DataSource = bindingSource;
		}

		private void method_4()
		{
			this.dataTable_0 = new DataTable();
			string text = string.Format("select id, Name from tSchm_ObjList as ol\r\nwhere ol.deleted = '0' and (ol.idParent = '{0}'\r\nor ol.id in (Select idClutchFirst as idPylon from tP_CabSection\r\nwhere deleted = '0' and idObjList = '{0}' union\r\nselect idClutchSecond as idPylon from tP_CabSection\r\nwhere deleted = '0' and idObjList = '{0}'))\r\norder by ol.Name", this.int_1);
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			this.dataTable_0 = sqlDataCommand.SelectSqlData(text);
		}

		private void bljmritkbZn()
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

		private void method_5()
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

		private void method_6()
		{
			string cmdText = "select ISNULL(SocrName, Name) as Name, Comment as Unit from tR_Classifier\r\nwhere ParentKey = ';Passport;AirLine;AirLineExpl;RepairWork;' and deleted = '0' and isGroup = '0'";
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

		private void method_7()
		{
			Class14.Class65 @class = this.class14_0.tP_DocList.method_4();
			@class.ParentId = -1;
			@class.idObjList = this.int_1;
			@class.DateDoc = this.dateTimePicker_0.Value;
			@class.NumberDoc = this.textBox_0.Text;
			@class.TypeDoc = this.int_2;
			@class.Comment = this.eemmdYmToXE.Text;
			@class.isActive = true;
			@class.Deleted = false;
			this.class14_0.tP_DocList.method_0(@class);
		}

		private void mdSmrdyrJbc()
		{
			string text = string.Format("where id = '{0}'", this.int_0);
			base.SelectSqlData(this.class14_0.tP_DocList, true, text, null, false, 0);
			if (this.class14_0.tP_DocList.Rows.Count > 0 && this.class14_0.tP_DocList[0]["DataXml"] != DBNull.Value && Convert.ToString(this.class14_0.tP_DocList[0]["DataXml"]) != string.Empty)
			{
				this.method_10(Convert.ToString(this.class14_0.tP_DocList[0]["DataXml"]));
			}
		}

		private bool method_8()
		{
			this.class14_0.tP_DocList[0]["DataXml"] = this.method_11();
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
				this.int_0 = base.InsertSqlDataOneRow(this.class14_0.tP_DocList[0]);
				if (this.int_0 == -1)
				{
					return false;
				}
			}
			return this.method_9();
		}

		private bool method_9()
		{
			if (this.panelFile_0.IsSave)
			{
				if (this.int_0 != -1)
				{
					return this.panelFile_0.method_11(this.int_0);
				}
			}
			return true;
		}

		private void method_10(string string_0)
		{
			XmlReader reader = XDocument.Load(new StringReader(string_0)).Root.CreateReader();
			this.dataSet_0.Clear();
			this.dataSet_0.ReadXml(reader);
		}

		private XDocument method_11()
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

		private void dataGridView_0_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == this.dataGridViewComboBoxColumn_0.Index)
			{
				((DataGridView)sender).Invalidate();
			}
		}

		private void dataGridView_0_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			Class316.smethod_1(sender, e);
		}

		private void dataGridView_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (this.dataTable_0 == null)
			{
				return;
			}
			for (int i = 0; i < e.RowCount; i++)
			{
				DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.dataGridView_0[this.dataGridViewComboBoxColumn_0.Index, e.RowIndex + i];
				BindingSource bindingSource = new BindingSource();
				bindingSource.DataSource = this.dataTable_0.Copy();
				dataGridViewComboBoxCell.DisplayMember = "Name";
				dataGridViewComboBoxCell.ValueMember = "id";
				dataGridViewComboBoxCell.DataSource = bindingSource;
			}
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

		private void method_12(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			Class316.smethod_0(sender, e);
		}

		private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_2.SelectedItem == null)
			{
				this.label_12.Text = string.Empty;
				return;
			}
			this.label_12.Text = Convert.ToString(((DataRowView)this.comboBox_2.SelectedItem).Row["Description"]);
		}

		private void comboBox_2_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.comboBox_2.SelectedItem == null)
			{
				this.label_12.Text = string.Empty;
				return;
			}
			this.label_12.Text = Convert.ToString(((DataRowView)this.comboBox_2.SelectedItem).Row["Description"]);
		}

		private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_1.SelectedItem == null)
			{
				this.label_11.Text = string.Empty;
				return;
			}
			this.label_11.Text = Convert.ToString(((DataRowView)this.comboBox_1.SelectedItem).Row["Description"]);
		}

		private void comboBox_1_SelectedValueChanged(object sender, EventArgs e)
		{
			if (this.comboBox_1.SelectedItem == null)
			{
				this.label_11.Text = string.Empty;
				return;
			}
			this.label_11.Text = Convert.ToString(((DataRowView)this.comboBox_1.SelectedItem).Row["Description"]);
		}

		private void LcYmdzXgeJB_Click(object sender, EventArgs e)
		{
			new FormReportAirLineDocs(this.int_1, this.int_0)
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent,
				IdTypeDoc = this.int_2,
				StartPosition = FormStartPosition.CenterParent
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

		private void method_13()
		{
			this.icontainer_0 = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.eemmdYmToXE = new RichTextBox();
			this.class14_0 = new Class14();
			this.label_7 = new Label();
			this.dataGridView_1 = new DataGridView();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.dataSet_0 = new DataSet();
			this.dataTable_1 = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.dataColumn_2 = new DataColumn();
			this.dataColumn_3 = new DataColumn();
			this.dataTable_2 = new DataTable();
			this.dataColumn_4 = new DataColumn();
			this.dataTable_3 = new DataTable();
			this.dataColumn_5 = new DataColumn();
			this.dataColumn_6 = new DataColumn();
			this.dataColumn_7 = new DataColumn();
			this.dataColumn_8 = new DataColumn();
			this.dataColumn_9 = new DataColumn();
			this.dataColumn_10 = new DataColumn();
			this.dataColumn_11 = new DataColumn();
			this.dataColumn_12 = new DataColumn();
			this.label_8 = new Label();
			this.UsEmdDtpEgP = new TextBox();
			this.label_9 = new Label();
			this.label_10 = new Label();
			this.comboBox_1 = new ComboBox();
			this.label_11 = new Label();
			this.label_12 = new Label();
			this.comboBox_2 = new ComboBox();
			this.label_13 = new Label();
			this.textBox_4 = new TextBox();
			this.label_14 = new Label();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.label_3 = new Label();
			this.textBox_1 = new TextBox();
			this.label_4 = new Label();
			this.textBox_2 = new TextBox();
			this.label_5 = new Label();
			this.textBox_3 = new TextBox();
			this.label_6 = new Label();
			this.comboBox_0 = new ComboBox();
			this.label_0 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_1 = new Label();
			this.textBox_0 = new TextBox();
			this.label_2 = new Label();
			this.tabPage_1 = new TabPage();
			this.panel_0 = new Panel();
			this.LcYmdzXgeJB = new Button();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.panelFile_0 = new PanelFile();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			((ISupportInitialize)this.class14_0).BeginInit();
			((ISupportInitialize)this.dataGridView_1).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_1).BeginInit();
			((ISupportInitialize)this.dataTable_2).BeginInit();
			((ISupportInitialize)this.dataTable_3).BeginInit();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			this.tabPage_1.SuspendLayout();
			this.panel_0.SuspendLayout();
			base.SuspendLayout();
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(0, 0);
			this.tabControl_0.Name = "tabControl1";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(801, 490);
			this.tabControl_0.TabIndex = 15;
			this.tabPage_0.Controls.Add(this.eemmdYmToXE);
			this.tabPage_0.Controls.Add(this.label_7);
			this.tabPage_0.Controls.Add(this.dataGridView_1);
			this.tabPage_0.Controls.Add(this.label_8);
			this.tabPage_0.Controls.Add(this.UsEmdDtpEgP);
			this.tabPage_0.Controls.Add(this.label_9);
			this.tabPage_0.Controls.Add(this.label_10);
			this.tabPage_0.Controls.Add(this.comboBox_1);
			this.tabPage_0.Controls.Add(this.label_11);
			this.tabPage_0.Controls.Add(this.label_12);
			this.tabPage_0.Controls.Add(this.comboBox_2);
			this.tabPage_0.Controls.Add(this.label_13);
			this.tabPage_0.Controls.Add(this.textBox_4);
			this.tabPage_0.Controls.Add(this.label_14);
			this.tabPage_0.Controls.Add(this.dataGridView_0);
			this.tabPage_0.Controls.Add(this.label_3);
			this.tabPage_0.Controls.Add(this.textBox_1);
			this.tabPage_0.Controls.Add(this.label_4);
			this.tabPage_0.Controls.Add(this.textBox_2);
			this.tabPage_0.Controls.Add(this.label_5);
			this.tabPage_0.Controls.Add(this.textBox_3);
			this.tabPage_0.Controls.Add(this.label_6);
			this.tabPage_0.Controls.Add(this.comboBox_0);
			this.tabPage_0.Controls.Add(this.label_0);
			this.tabPage_0.Controls.Add(this.dateTimePicker_0);
			this.tabPage_0.Controls.Add(this.label_1);
			this.tabPage_0.Controls.Add(this.textBox_0);
			this.tabPage_0.Controls.Add(this.label_2);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tpBase";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(793, 464);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Общие";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.eemmdYmToXE.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.eemmdYmToXE.DataBindings.Add(new Binding("Text", this.class14_0, "tP_DocList.Comment", true));
			this.eemmdYmToXE.Location = new Point(480, 269);
			this.eemmdYmToXE.Name = "rtxtComment";
			this.eemmdYmToXE.Size = new Size(302, 108);
			this.eemmdYmToXE.TabIndex = 10;
			this.eemmdYmToXE.Text = "";
			this.class14_0.DataSetName = "dsDocuments";
			this.class14_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.label_7.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.label_7.AutoSize = true;
			this.label_7.Location = new Point(477, 253);
			this.label_7.Margin = new Padding(3, 3, 3, 0);
			this.label_7.Name = "label15";
			this.label_7.Size = new Size(70, 13);
			this.label_7.TabIndex = 26;
			this.label_7.Text = "Примечание";
			this.dataGridView_1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.dataGridView_1.AutoGenerateColumns = false;
			this.dataGridView_1.BackgroundColor = SystemColors.Window;
			this.dataGridView_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0
			});
			this.dataGridView_1.DataSource = this.bindingSource_1;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = SystemColors.Window;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Menu;
			dataGridViewCellStyle.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.False;
			this.dataGridView_1.DefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_1.Location = new Point(480, 98);
			this.dataGridView_1.Name = "dgvAddress";
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dataGridView_1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_1.Size = new Size(302, 149);
			this.dataGridView_1.TabIndex = 9;
			this.bindingSource_1.DataMember = "tAddress";
			this.bindingSource_1.DataSource = this.dataSet_0;
			this.dataSet_0.DataSetName = "DataSetAirLineRepair";
			this.dataSet_0.Tables.AddRange(new DataTable[]
			{
				this.dataTable_1,
				this.dataTable_2,
				this.dataTable_3
			});
			this.dataTable_1.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.dataColumn_2,
				this.dataColumn_3
			});
			this.dataTable_1.TableName = "tWork";
			this.dataColumn_0.ColumnName = "Name";
			this.dataColumn_1.ColumnName = "Unit";
			this.dataColumn_2.ColumnName = "Count";
			this.dataColumn_3.ColumnName = "idPylon";
			this.dataColumn_3.DataType = typeof(int);
			this.dataTable_2.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_4
			});
			this.dataTable_2.TableName = "tAddress";
			this.dataColumn_4.ColumnName = "Name";
			this.dataTable_3.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_5,
				this.dataColumn_6,
				this.dataColumn_7,
				this.dataColumn_8,
				this.dataColumn_9,
				this.dataColumn_10,
				this.dataColumn_11,
				this.dataColumn_12
			});
			this.dataTable_3.TableName = "tOther";
			this.dataColumn_5.ColumnName = "idReason";
			this.dataColumn_5.DataType = typeof(int);
			this.dataColumn_6.ColumnName = "From";
			this.dataColumn_7.ColumnName = "To";
			this.dataColumn_8.ColumnName = "Length";
			this.dataColumn_9.ColumnName = "treeCount";
			this.dataColumn_10.ColumnName = "dateStartUp";
			this.dataColumn_11.ColumnName = "idHeadRegion";
			this.dataColumn_12.ColumnName = "idEngineerPTS";
			this.dataColumn_12.DataType = typeof(int);
			this.label_8.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.label_8.AutoSize = true;
			this.label_8.Location = new Point(586, 75);
			this.label_8.Name = "label14";
			this.label_8.Size = new Size(23, 13);
			this.label_8.TabIndex = 24;
			this.label_8.Text = "шт.";
			this.UsEmdDtpEgP.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.UsEmdDtpEgP.DataBindings.Add(new Binding("Text", this.dataSet_0, "tOther.treeCount", true));
			this.UsEmdDtpEgP.Location = new Point(480, 72);
			this.UsEmdDtpEgP.Margin = new Padding(10, 3, 3, 3);
			this.UsEmdDtpEgP.Name = "txtTreeCount";
			this.UsEmdDtpEgP.Size = new Size(100, 20);
			this.UsEmdDtpEgP.TabIndex = 8;
			this.label_9.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.label_9.AutoSize = true;
			this.label_9.Location = new Point(477, 56);
			this.label_9.Margin = new Padding(3, 3, 3, 0);
			this.label_9.Name = "label13";
			this.label_9.Size = new Size(272, 13);
			this.label_9.TabIndex = 22;
			this.label_9.Text = "Наличие деревьев, создающих угрозу повреждения";
			this.label_10.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.label_10.AutoSize = true;
			this.label_10.Location = new Point(477, 40);
			this.label_10.Name = "label12";
			this.label_10.Size = new Size(143, 13);
			this.label_10.TabIndex = 21;
			this.label_10.Text = "Мероприятия по деревьям";
			this.comboBox_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_1.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tOther.idEngineerPTS", true));
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(247, 431);
			this.comboBox_1.Name = "cmbEngineerPTS";
			this.comboBox_1.Size = new Size(170, 21);
			this.comboBox_1.TabIndex = 12;
			this.comboBox_1.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
			this.comboBox_1.SelectedValueChanged += this.comboBox_1_SelectedValueChanged;
			this.label_11.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label_11.AutoSize = true;
			this.label_11.Location = new Point(91, 434);
			this.label_11.Name = "lblEngineerPTS";
			this.label_11.Size = new Size(78, 13);
			this.label_11.TabIndex = 19;
			this.label_11.Text = "Инженер ПТС";
			this.label_12.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label_12.AutoSize = true;
			this.label_12.Location = new Point(91, 407);
			this.label_12.Name = "lblHeadRegion";
			this.label_12.Size = new Size(150, 13);
			this.label_12.TabIndex = 18;
			this.label_12.Text = "Начальник сетевого района";
			this.comboBox_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_2.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tOther.idHeadRegion", true));
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(247, 404);
			this.comboBox_2.Name = "cmbHeadNetRegion";
			this.comboBox_2.Size = new Size(170, 21);
			this.comboBox_2.TabIndex = 11;
			this.comboBox_2.SelectedIndexChanged += this.comboBox_2_SelectedIndexChanged;
			this.comboBox_2.SelectedValueChanged += this.comboBox_2_SelectedValueChanged;
			this.label_13.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label_13.AutoSize = true;
			this.label_13.Location = new Point(8, 407);
			this.label_13.Name = "label9";
			this.label_13.Size = new Size(77, 13);
			this.label_13.TabIndex = 16;
			this.label_13.Text = "Исполнители:";
			this.textBox_4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.textBox_4.DataBindings.Add(new Binding("Text", this.dataSet_0, "tOther.dateStartUp", true));
			this.textBox_4.Location = new Point(172, 378);
			this.textBox_4.Name = "txtDateStartUp";
			this.textBox_4.Size = new Size(140, 20);
			this.textBox_4.TabIndex = 7;
			this.label_14.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
			this.label_14.AutoSize = true;
			this.label_14.Location = new Point(8, 381);
			this.label_14.Margin = new Padding(3, 3, 3, 0);
			this.label_14.Name = "label8";
			this.label_14.Size = new Size(158, 13);
			this.label_14.TabIndex = 14;
			this.label_14.Text = "Дата приема в эксплуатацию";
			this.dataGridView_0.AllowUserToOrderColumns = true;
			this.dataGridView_0.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.dataGridView_0.AutoGenerateColumns = false;
			this.dataGridView_0.BackgroundColor = SystemColors.Window;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewComboBoxColumn_0,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9
			});
			this.dataGridView_0.DataSource = this.bindingSource_0;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Window;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Menu;
			dataGridViewCellStyle3.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_0.Location = new Point(11, 153);
			this.dataGridView_0.Name = "dgvWork";
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = SystemColors.Control;
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle4.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(450, 219);
			this.dataGridView_0.TabIndex = 6;
			this.dataGridView_0.CellValueChanged += this.dataGridView_0_CellValueChanged;
			this.dataGridView_0.CurrentCellDirtyStateChanged += this.dataGridView_0_CurrentCellDirtyStateChanged;
			this.dataGridView_0.EditingControlShowing += this.dataGridView_0_EditingControlShowing;
			this.dataGridView_0.RowPrePaint += this.dataGridView_0_RowPrePaint;
			this.dataGridView_0.RowsAdded += this.dataGridView_0_RowsAdded;
			this.dataGridViewComboBoxColumn_0.DataPropertyName = "idPylon";
			this.dataGridViewComboBoxColumn_0.HeaderText = "Опора";
			this.dataGridViewComboBoxColumn_0.MinimumWidth = 70;
			this.dataGridViewComboBoxColumn_0.Name = "idPylonDgvWork";
			this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewComboBoxColumn_0.Visible = false;
			this.dataGridViewComboBoxColumn_0.Width = 120;
			this.bindingSource_0.DataMember = "tWork";
			this.bindingSource_0.DataSource = this.dataSet_0;
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(8, 137);
			this.label_3.Margin = new Padding(3, 3, 3, 0);
			this.label_3.Name = "label7";
			this.label_3.Size = new Size(118, 13);
			this.label_3.TabIndex = 12;
			this.label_3.Text = "Выполненные работы";
			this.textBox_1.DataBindings.Add(new Binding("Text", this.dataSet_0, "tOther.Length", true));
			this.textBox_1.Location = new Point(122, 111);
			this.textBox_1.Name = "txtLength";
			this.textBox_1.Size = new Size(100, 20);
			this.textBox_1.TabIndex = 5;
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(15, 114);
			this.label_4.Margin = new Padding(10, 0, 3, 0);
			this.label_4.Name = "label6";
			this.label_4.Size = new Size(101, 13);
			this.label_4.TabIndex = 10;
			this.label_4.Text = "Протяженность, м";
			this.textBox_2.DataBindings.Add(new Binding("Text", this.dataSet_0, "tOther.To", true));
			this.textBox_2.Location = new Point(42, 85);
			this.textBox_2.Name = "txtTo";
			this.textBox_2.Size = new Size(419, 20);
			this.textBox_2.TabIndex = 4;
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(15, 88);
			this.label_5.Margin = new Padding(10, 0, 3, 0);
			this.label_5.Name = "label5";
			this.label_5.Size = new Size(22, 13);
			this.label_5.TabIndex = 8;
			this.label_5.Text = "по:";
			this.textBox_3.DataBindings.Add(new Binding("Text", this.dataSet_0, "tOther.From", true));
			this.textBox_3.Location = new Point(42, 59);
			this.textBox_3.Name = "txtFrom";
			this.textBox_3.Size = new Size(168, 20);
			this.textBox_3.TabIndex = 3;
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(15, 62);
			this.label_6.Margin = new Padding(10, 0, 3, 0);
			this.label_6.Name = "label4";
			this.label_6.Size = new Size(21, 13);
			this.label_6.TabIndex = 6;
			this.label_6.Text = "от:";
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tOther.idReason", true));
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(110, 32);
			this.comboBox_0.Name = "cmbReason";
			this.comboBox_0.Size = new Size(192, 21);
			this.comboBox_0.TabIndex = 2;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(8, 35);
			this.label_0.Name = "label3";
			this.label_0.Size = new Size(50, 13);
			this.label_0.TabIndex = 4;
			this.label_0.Text = "Причина";
			this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.class14_0, "tP_DocList.DateDoc", true));
			this.dateTimePicker_0.Location = new Point(327, 6);
			this.dateTimePicker_0.Name = "dtpDateDoc";
			this.dateTimePicker_0.Size = new Size(134, 20);
			this.dateTimePicker_0.TabIndex = 1;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(231, 9);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(90, 13);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "Дата документа";
			this.textBox_0.DataBindings.Add(new Binding("Text", this.class14_0, "tP_DocList.NumberDoc", true));
			this.textBox_0.Location = new Point(112, 6);
			this.textBox_0.Name = "txtDocNumber";
			this.textBox_0.Size = new Size(100, 20);
			this.textBox_0.TabIndex = 0;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(8, 9);
			this.label_2.Name = "label1";
			this.label_2.Size = new Size(98, 13);
			this.label_2.TabIndex = 0;
			this.label_2.Text = "Номер документа";
			this.tabPage_1.Controls.Add(this.panelFile_0);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tpFile";
			this.tabPage_1.Padding = new Padding(3);
			this.tabPage_1.Size = new Size(793, 464);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "Файлы";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.panel_0.Controls.Add(this.LcYmdzXgeJB);
			this.panel_0.Controls.Add(this.button_0);
			this.panel_0.Controls.Add(this.button_1);
			this.panel_0.Dock = DockStyle.Bottom;
			this.panel_0.Location = new Point(0, 490);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(801, 51);
			this.panel_0.TabIndex = 1;
			this.LcYmdzXgeJB.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.LcYmdzXgeJB.BackgroundImage = Resources.smethod_44();
			this.LcYmdzXgeJB.BackgroundImageLayout = ImageLayout.Center;
			this.LcYmdzXgeJB.Location = new Point(593, 16);
			this.LcYmdzXgeJB.Name = "btnPrint";
			this.LcYmdzXgeJB.Size = new Size(34, 23);
			this.LcYmdzXgeJB.TabIndex = 15;
			this.LcYmdzXgeJB.UseVisualStyleBackColor = true;
			this.LcYmdzXgeJB.Click += this.LcYmdzXgeJB_Click;
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Location = new Point(633, 16);
			this.button_0.Name = "btnOK";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 13;
			this.button_0.Text = "ОК";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_1_Click;
			this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(714, 16);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 14;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_1.HeaderText = "Адрес";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_2.HeaderText = "id";
			this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_3.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_3.MinimumWidth = 70;
			this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "Unit";
			this.dataGridViewTextBoxColumn_4.HeaderText = "Ед. изм.";
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_4.Width = 70;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn_5.HeaderText = "Кол-во";
			this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_5.Width = 70;
			this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_0.HeaderText = "Адрес";
			this.dataGridViewTextBoxColumn_0.Name = "nameDgvAddress";
			this.dataGridViewTextBoxColumn_6.HeaderText = "id";
			this.dataGridViewTextBoxColumn_6.Name = "idDgvWork";
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_7.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_7.MinimumWidth = 70;
			this.dataGridViewTextBoxColumn_7.Name = "nameDgvWork";
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "Unit";
			this.dataGridViewTextBoxColumn_8.HeaderText = "Ед. изм.";
			this.dataGridViewTextBoxColumn_8.Name = "unitDgvWork";
			this.dataGridViewTextBoxColumn_8.Width = 70;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn_9.HeaderText = "Кол-во";
			this.dataGridViewTextBoxColumn_9.Name = "countDgvWork";
			this.dataGridViewTextBoxColumn_9.Width = 70;
			this.panelFile_0.Dock = DockStyle.Fill;
			this.panelFile_0.IdParent = 0;
			this.panelFile_0.Location = new Point(3, 3);
			this.panelFile_0.Name = "pFile";
			this.panelFile_0.Size = new Size(787, 458);
			this.panelFile_0.TabIndex = 15;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(801, 541);
			base.Controls.Add(this.tabControl_0);
			base.Controls.Add(this.panel_0);
			base.Name = "FormAirLineRepairAddEdit";
			this.Text = "Акт приема-сдачи ВЛ";
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tabPage_0.PerformLayout();
			((ISupportInitialize)this.class14_0).EndInit();
			((ISupportInitialize)this.dataGridView_1).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_1).EndInit();
			((ISupportInitialize)this.dataTable_2).EndInit();
			((ISupportInitialize)this.dataTable_3).EndInit();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			this.tabPage_1.ResumeLayout(false);
			this.panel_0.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		internal static void kfUR8K9CR2ZSPEGQfQng(Form form_0, CancelEventArgs cancelEventArgs_0)
		{
			form_0.OnClosing(cancelEventArgs_0);
		}

		private int int_0;

		private int int_1;

		private int int_2;

		private DataTable dataTable_0;

		[CompilerGenerated]
		private StateFormCreate stateFormCreate_0;

		private IContainer icontainer_0;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private TabPage tabPage_1;

		private PanelFile panelFile_0;

		private Panel panel_0;

		private ComboBox comboBox_0;

		private Label label_0;

		private DateTimePicker dateTimePicker_0;

		private Label label_1;

		private TextBox textBox_0;

		private Label label_2;

		private Label label_3;

		private TextBox textBox_1;

		private Label label_4;

		private TextBox textBox_2;

		private Label label_5;

		private TextBox textBox_3;

		private Label label_6;

		private DataSet dataSet_0;

		private DataTable dataTable_1;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private BindingSource bindingSource_0;

		private DataGridView dataGridView_0;

		private RichTextBox eemmdYmToXE;

		private Label label_7;

		private DataGridView dataGridView_1;

		private Label label_8;

		private TextBox UsEmdDtpEgP;

		private Label label_9;

		private Label label_10;

		private ComboBox comboBox_1;

		private Label label_11;

		private Label label_12;

		private ComboBox comboBox_2;

		private Label label_13;

		private TextBox textBox_4;

		private Label label_14;

		private Button button_0;

		private Button button_1;

		private Class14 class14_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private BindingSource bindingSource_1;

		private DataTable dataTable_2;

		private DataColumn dataColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private Button LcYmdzXgeJB;

		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataTable dataTable_3;

		private DataColumn dataColumn_5;

		private DataColumn dataColumn_6;

		private DataColumn dataColumn_7;

		private DataColumn dataColumn_8;

		private DataColumn dataColumn_9;

		private DataColumn dataColumn_10;

		private DataColumn dataColumn_11;

		private DataColumn dataColumn_12;
	}
}
