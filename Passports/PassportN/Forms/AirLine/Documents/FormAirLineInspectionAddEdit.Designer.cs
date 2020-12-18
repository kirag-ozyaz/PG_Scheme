using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
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
	public class FormAirLineInspectionAddEdit : FormBase
	{
		public int IdDoc
		{
			get
			{
				return this.int_0;
			}
		}

		public StateFormCreate CreateState { get; set; }

		public FormAirLineInspectionAddEdit()
		{
			Class330.Mus9JxKz1CNxy();
			this.int_0 = -1;
			this.int_1 = -1;
			base..ctor();
			this.method_14();
		}

		public FormAirLineInspectionAddEdit(int IdObjList, int IdDoc)
		{
			Class330.Mus9JxKz1CNxy();
			this.int_0 = -1;
			this.int_1 = -1;
			base..ctor();
			this.method_14();
			this.int_0 = IdDoc;
			this.int_1 = IdObjList;
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			this.method_0();
			StateFormCreate createState = this.CreateState;
			if (createState != null)
			{
				if (createState == 1)
				{
					this.Text = "Редактировать осмотр " + this.method_7(this.int_1);
					Control control = this.button_2;
					this.button_2.Enabled = true;
					control.Visible = true;
					this.method_6();
					this.panelFile_0.method_10(this.int_0);
				}
			}
			else
			{
				this.Text = "Добавить осмотр " + this.method_7(this.int_1);
				Control control2 = this.button_2;
				this.button_2.Enabled = false;
				control2.Visible = false;
				this.method_5();
			}
			if (this.dataTable_4 == null || this.dataTable_4.Rows.Count == 0)
			{
				this.dataTable_4.Rows.Add(this.dataTable_4.NewRow());
			}
			this.comboBox_0.Enabled = true;
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			FormAirLineInspectionAddEdit.jNfw8M9LpB43kxR2CIwr(this, e);
			if (base.DialogResult == DialogResult.OK && !this.method_11())
			{
				base.DialogResult = DialogResult.None;
				e.Cancel = true;
			}
		}

		private void method_0()
		{
			this.method_1();
			this.panelFile_0.SqlSettings = this.SqlSettings;
			this.method_2();
			this.method_3();
			this.method_4();
		}

		private void method_1()
		{
			this.textBox_0.DataBindings[0].NullValue = string.Empty;
			this.textBox_0.DataBindings[0].DataSourceNullValue = DBNull.Value;
			this.dateTimePicker_0.DataBindings[0].NullValue = DateTime.Now;
			this.dateTimePicker_0.DataBindings[0].DataSourceNullValue = DateTime.Now;
			this.comboBox_0.DataBindings[0].NullValue = null;
			this.comboBox_0.DataBindings[0].DataSourceNullValue = DBNull.Value;
		}

		private void method_2()
		{
			DataTable dataTable = new DataTable("tR_Classifier");
			dataTable.Columns.Add("id", typeof(int));
			dataTable.Columns.Add("Name", typeof(string));
			string text = string.Format("where ParentKey = ';Passport;AirLine;Inspect;TypeInspect;' and deleted = '0' and isGroup = '0'", new object[0]);
			base.SelectSqlData(dataTable, true, text, null, false, 0);
			BindingSource bindingSource = new BindingSource();
			bindingSource.DataSource = dataTable;
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "id";
			this.comboBox_0.DataSource = bindingSource;
		}

		private void method_3()
		{
			this.dataTable_0 = new DataTable();
			string text = string.Format("select ol.id, ol.Name from tSchm_ObjList as ol\r\ninner join tR_Classifier as c_ol on c_ol.id = ol.typeCodeId\r\nand c_ol.ParentKey = ';SCM;Pole;' and c_ol.isGroup = '0'\r\nwhere ol.deleted = '0' and (ol.idParent = '{0}'\r\nor ol.id in (Select idClutchFirst as idPylon from tP_CabSection\r\nwhere deleted = '0' and idObjList = '{0}' union\r\nselect idClutchSecond as idPylon from tP_CabSection\r\nwhere deleted = '0' and idObjList = '{0}'))\r\norder by ol.Name", this.int_1);
			SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
			this.dataTable_0 = sqlDataCommand.SelectSqlData(text);
		}

		private void method_4()
		{
			this.dataTable_1 = new DataTable("vP_Worker");
			this.dataTable_1.Columns.Add("id", typeof(int));
			this.dataTable_1.Columns.Add("FIO", typeof(string));
			string text = string.Format("WHERE ParentKey = ';GroupWorker;CableService;Check;'", new object[0]);
			base.SelectSqlData(this.dataTable_1, true, text, null, false, 0);
		}

		private void method_5()
		{
			Class14.Class65 @class = this.class14_0.tP_DocList.method_4();
			@class.ParentId = -1;
			@class.idObjList = this.int_1;
			@class.TypeDoc = this.method_8(";TypeDoc;tPassport;AirLine;", 5m);
			@class.DateDoc = this.dateTimePicker_0.Value;
			@class.Deleted = false;
			@class.isActive = true;
			@class.EndEdit();
			this.class14_0.tP_DocList.method_0(@class);
		}

		private void method_6()
		{
			base.SelectSqlData(this.class14_0.tP_DocList, true, string.Format("where id = '{0}'", this.int_0), null, false, 0);
			if (this.class14_0.tP_DocList.Rows.Count > 0 && this.class14_0.tP_DocList[0][this.class14_0.tP_DocList.DataColumn_6.ColumnName] != DBNull.Value)
			{
				this.method_9(Convert.ToString(this.class14_0.tP_DocList[0][this.class14_0.tP_DocList.DataColumn_6.ColumnName]));
			}
		}

		private string method_7(int int_2)
		{
			string text = string.Format("select ISNULL(c_ol.SocrName + ' - ', '') + ol.Name as FullName\r\nfrom tSchm_ObjList as ol\r\nleft join tR_Classifier as c_ol on c_ol.Id = ol.TypeCodeId\r\nwhere ol.Deleted = '0' and ol.id = '{0}'", int_2);
			DataTable dataTable = new SqlDataCommand(this.SqlSettings).SelectSqlData(text);
			if (dataTable != null && dataTable.Rows.Count > 0)
			{
				return Convert.ToString(dataTable.Rows[0]["FullName"]);
			}
			return string.Empty;
		}

		private int method_8(string string_0, decimal decimal_0)
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

		private void dataGridView_0_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (this.dataTable_0 == null)
			{
				return;
			}
			DataGridView dataGridView = (DataGridView)sender;
			for (int i = 0; i < e.RowCount; i++)
			{
				DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)dataGridView[this.dataGridViewComboBoxColumn_1.Index, e.RowIndex + i];
				BindingSource bindingSource = new BindingSource();
				bindingSource.DataSource = this.dataTable_0.Copy();
				dataGridViewComboBoxCell.DisplayMember = "Name";
				dataGridViewComboBoxCell.ValueMember = "id";
				dataGridViewComboBoxCell.DataSource = bindingSource;
			}
		}

		private void dataGridView_1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (this.dataTable_0 == null)
			{
				return;
			}
			DataGridView dataGridView = (DataGridView)sender;
			for (int i = 0; i < e.RowCount; i++)
			{
				DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)dataGridView[this.dataGridViewComboBoxColumn_0.Index, e.RowIndex + i];
				BindingSource bindingSource = new BindingSource();
				bindingSource.DataSource = this.dataTable_0.Copy();
				dataGridViewComboBoxCell.DisplayMember = "Name";
				dataGridViewComboBoxCell.ValueMember = "id";
				dataGridViewComboBoxCell.DataSource = bindingSource;
			}
		}

		private void dataGridView_2_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			if (this.dataTable_1 == null)
			{
				return;
			}
			for (int i = 0; i < e.RowCount; i++)
			{
				DataGridViewComboBoxCell dataGridViewComboBoxCell = (DataGridViewComboBoxCell)this.dataGridView_2[this.dataGridViewComboBoxColumn_2.Index, e.RowIndex];
				BindingSource bindingSource = new BindingSource();
				bindingSource.DataSource = this.dataTable_1.Copy();
				dataGridViewComboBoxCell.DisplayMember = "FIO";
				dataGridViewComboBoxCell.ValueMember = "id";
				dataGridViewComboBoxCell.DataSource = bindingSource;
			}
		}

		private void dataGridView_2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			DataGridView dataGridView = (DataGridView)sender;
			if (e.Control is DataGridViewComboBoxEditingControl && dataGridView.CurrentCell.ColumnIndex == this.dataGridViewComboBoxColumn_2.Index)
			{
				BindingSource bindingSource = (BindingSource)((DataGridViewComboBoxEditingControl)e.Control).DataSource;
				if (bindingSource != null)
				{
					bindingSource.Filter = string.Empty;
					StringBuilder stringBuilder = new StringBuilder();
					foreach (object obj in ((IEnumerable)dataGridView.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						if (!dataGridViewRow.IsNewRow && dataGridViewRow.Index != dataGridView.CurrentRow.Index && dataGridView.CurrentCell.Value != null)
						{
							stringBuilder.AppendFormat(",{0}", dataGridViewRow.Cells[this.dataGridViewComboBoxColumn_2.Index].Value);
						}
					}
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Remove(0, 1);
						bindingSource.Filter = string.Format("id not in ({0})", stringBuilder);
					}
				}
				if (dataGridView.CurrentCell != null && dataGridView.IsCurrentCellDirty)
				{
					dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
				}
			}
		}

		private void method_9(string string_0)
		{
			XmlReader reader = XDocument.Load(new StringReader(string_0)).Root.CreateReader();
			this.dataSet_0.Clear();
			this.dataSet_0.ReadXml(reader);
		}

		private XDocument method_10()
		{
			XDocument xdocument = new XDocument();
			MemoryStream memoryStream = new MemoryStream();
			this.dataSet_0.WriteXml(memoryStream);
			memoryStream.Position = 0L;
			XDocument xdocument2 = XDocument.Load(XmlReader.Create(memoryStream));
			xdocument.Add(new XElement("AddlData", xdocument2.Root));
			return xdocument;
		}

		private bool method_11()
		{
			return this.method_12() && this.method_13();
		}

		private bool method_12()
		{
			this.class14_0.tP_DocList[0]["DataXml"] = this.method_10();
			this.class14_0.tP_DocList[0].EndEdit();
			StateFormCreate createState = this.CreateState;
			if (createState != null)
			{
				return createState == 1 && base.UpdateSqlData(this.class14_0.tP_DocList);
			}
			this.int_0 = base.InsertSqlDataOneRow(this.class14_0.tP_DocList[0]);
			return this.int_0 != -1;
		}

		private bool method_13()
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

		private void button_1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void dataGridView_0_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
		{
			Class316.smethod_0(sender, e);
		}

		private void button_2_Click(object sender, EventArgs e)
		{
			new FormReportAirLineDocs(this.int_1, this.int_0)
			{
				SqlSettings = this.SqlSettings,
				MdiParent = base.MdiParent,
				StartPosition = FormStartPosition.CenterScreen,
				IdTypeDoc = this.method_8(";TypeDoc;tPassport;AirLine;", 5m)
			}.Show();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.ukCmldKycnp != null)
			{
				this.ukCmldKycnp.Dispose();
			}
			FormAirLineInspectionAddEdit.IiW2IX9yJHJ12FDLsMIF(this, disposing);
		}

		private void method_14()
		{
			this.ukCmldKycnp = new Container();
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.diamrsBiZoi = new TableLayoutPanel();
			this.label_4 = new Label();
			this.dataGridView_2 = new DataGridView();
			this.dataGridViewComboBoxColumn_2 = new DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.bindingSource_2 = new BindingSource(this.ukCmldKycnp);
			this.dataSet_0 = new DataSet();
			this.dataTable_2 = new DataTable();
			this.dataColumn_0 = new DataColumn();
			this.dataColumn_1 = new DataColumn();
			this.dataTable_3 = new DataTable();
			this.dataColumn_2 = new DataColumn();
			this.dataColumn_3 = new DataColumn();
			this.dataTable_4 = new DataTable();
			this.dataColumn_4 = new DataColumn();
			this.dataTable_5 = new DataTable();
			this.dataColumn_5 = new DataColumn();
			this.dataColumn_6 = new DataColumn();
			this.label_3 = new Label();
			this.label_5 = new Label();
			this.textBox_0 = new TextBox();
			this.class14_0 = new Class14();
			this.dataGridView_1 = new DataGridView();
			this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.bindingSource_0 = new BindingSource(this.ukCmldKycnp);
			this.comboBox_0 = new ComboBox();
			this.label_2 = new Label();
			this.label_0 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_1 = new Label();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewComboBoxColumn_1 = new DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.bindingSource_1 = new BindingSource(this.ukCmldKycnp);
			this.tabPage_1 = new TabPage();
			this.panelFile_0 = new PanelFile();
			this.panel_0 = new Panel();
			this.button_2 = new Button();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.diamrsBiZoi.SuspendLayout();
			((ISupportInitialize)this.dataGridView_2).BeginInit();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
			((ISupportInitialize)this.dataSet_0).BeginInit();
			((ISupportInitialize)this.dataTable_2).BeginInit();
			((ISupportInitialize)this.dataTable_3).BeginInit();
			((ISupportInitialize)this.dataTable_4).BeginInit();
			((ISupportInitialize)this.dataTable_5).BeginInit();
			((ISupportInitialize)this.class14_0).BeginInit();
			((ISupportInitialize)this.dataGridView_1).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			this.tabPage_1.SuspendLayout();
			this.panel_0.SuspendLayout();
			base.SuspendLayout();
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(0, 0);
			this.tabControl_0.Name = "tcMain";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(527, 497);
			this.tabControl_0.TabIndex = 0;
			this.tabPage_0.Controls.Add(this.diamrsBiZoi);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tpBase";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(519, 471);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Общие";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.diamrsBiZoi.ColumnCount = 5;
			this.diamrsBiZoi.ColumnStyles.Add(new ColumnStyle());
			this.diamrsBiZoi.ColumnStyles.Add(new ColumnStyle());
			this.diamrsBiZoi.ColumnStyles.Add(new ColumnStyle());
			this.diamrsBiZoi.ColumnStyles.Add(new ColumnStyle());
			this.diamrsBiZoi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.diamrsBiZoi.Controls.Add(this.label_4, 0, 0);
			this.diamrsBiZoi.Controls.Add(this.dataGridView_2, 0, 7);
			this.diamrsBiZoi.Controls.Add(this.label_3, 0, 1);
			this.diamrsBiZoi.Controls.Add(this.label_5, 0, 6);
			this.diamrsBiZoi.Controls.Add(this.textBox_0, 1, 0);
			this.diamrsBiZoi.Controls.Add(this.dataGridView_1, 0, 5);
			this.diamrsBiZoi.Controls.Add(this.comboBox_0, 1, 1);
			this.diamrsBiZoi.Controls.Add(this.label_2, 0, 4);
			this.diamrsBiZoi.Controls.Add(this.label_0, 2, 0);
			this.diamrsBiZoi.Controls.Add(this.dateTimePicker_0, 3, 0);
			this.diamrsBiZoi.Controls.Add(this.label_1, 0, 2);
			this.diamrsBiZoi.Controls.Add(this.dataGridView_0, 0, 3);
			this.diamrsBiZoi.Dock = DockStyle.Fill;
			this.diamrsBiZoi.Location = new Point(3, 3);
			this.diamrsBiZoi.Name = "tlpMain";
			this.diamrsBiZoi.RowCount = 8;
			this.diamrsBiZoi.RowStyles.Add(new RowStyle());
			this.diamrsBiZoi.RowStyles.Add(new RowStyle());
			this.diamrsBiZoi.RowStyles.Add(new RowStyle());
			this.diamrsBiZoi.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.diamrsBiZoi.RowStyles.Add(new RowStyle());
			this.diamrsBiZoi.RowStyles.Add(new RowStyle(SizeType.Percent, 50f));
			this.diamrsBiZoi.RowStyles.Add(new RowStyle());
			this.diamrsBiZoi.RowStyles.Add(new RowStyle());
			this.diamrsBiZoi.Size = new Size(513, 465);
			this.diamrsBiZoi.TabIndex = 12;
			this.label_4.AutoSize = true;
			this.label_4.Dock = DockStyle.Fill;
			this.label_4.Location = new Point(3, 0);
			this.label_4.Name = "label5";
			this.label_4.Size = new Size(98, 26);
			this.label_4.TabIndex = 8;
			this.label_4.Text = "Номер документа";
			this.label_4.TextAlign = ContentAlignment.MiddleLeft;
			this.dataGridView_2.AutoGenerateColumns = false;
			this.dataGridView_2.BackgroundColor = SystemColors.Window;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridView_2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_2.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewComboBoxColumn_2,
				this.dataGridViewTextBoxColumn_11
			});
			this.diamrsBiZoi.SetColumnSpan(this.dataGridView_2, 5);
			this.dataGridView_2.DataSource = this.bindingSource_2;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Menu;
			dataGridViewCellStyle2.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			this.dataGridView_2.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_2.Dock = DockStyle.Fill;
			this.dataGridView_2.Location = new Point(3, 374);
			this.dataGridView_2.Name = "dgvWorker";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridView_2.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_2.Size = new Size(507, 88);
			this.dataGridView_2.TabIndex = 11;
			this.dataGridView_2.EditingControlShowing += this.dataGridView_2_EditingControlShowing;
			this.dataGridView_2.RowPrePaint += this.dataGridView_0_RowPrePaint;
			this.dataGridView_2.RowsAdded += this.dataGridView_2_RowsAdded;
			this.dataGridViewComboBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewComboBoxColumn_2.DataPropertyName = "id";
			this.dataGridViewComboBoxColumn_2.HeaderText = "Фамилия И. О.";
			this.dataGridViewComboBoxColumn_2.Name = "idDgvWorker";
			this.dataGridViewComboBoxColumn_2.Resizable = DataGridViewTriState.True;
			this.dataGridViewComboBoxColumn_2.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_11.HeaderText = "Name";
			this.dataGridViewTextBoxColumn_11.Name = "nameDgvWorker";
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.bindingSource_2.DataMember = "tWorker";
			this.bindingSource_2.DataSource = this.dataSet_0;
			this.dataSet_0.DataSetName = "DataSetAirLineInspect";
			this.dataSet_0.Tables.AddRange(new DataTable[]
			{
				this.dataTable_2,
				this.dataTable_3,
				this.dataTable_4,
				this.dataTable_5
			});
			this.dataTable_2.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1
			});
			this.dataTable_2.TableName = "tDefect";
			this.dataColumn_0.ColumnName = "Name";
			this.dataColumn_1.ColumnName = "idPylon";
			this.dataColumn_1.DataType = typeof(int);
			this.dataTable_3.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_2,
				this.dataColumn_3
			});
			this.dataTable_3.TableName = "tRepair";
			this.dataColumn_2.ColumnName = "Name";
			this.dataColumn_3.ColumnName = "idPylon";
			this.dataColumn_3.DataType = typeof(int);
			this.dataTable_4.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_4
			});
			this.dataTable_4.TableName = "tOther";
			this.dataColumn_4.ColumnName = "idInspect";
			this.dataColumn_4.DataType = typeof(int);
			this.dataTable_5.Columns.AddRange(new DataColumn[]
			{
				this.dataColumn_5,
				this.dataColumn_6
			});
			this.dataTable_5.TableName = "tWorker";
			this.dataColumn_5.ColumnName = "id";
			this.dataColumn_5.DataType = typeof(int);
			this.dataColumn_6.ColumnName = "Name";
			this.label_3.AutoSize = true;
			this.label_3.Dock = DockStyle.Fill;
			this.label_3.Location = new Point(3, 29);
			this.label_3.Margin = new Padding(3, 3, 3, 0);
			this.label_3.Name = "label4";
			this.label_3.Size = new Size(98, 24);
			this.label_3.TabIndex = 6;
			this.label_3.Text = "Вид осмотра";
			this.label_3.TextAlign = ContentAlignment.MiddleLeft;
			this.label_5.AutoSize = true;
			this.diamrsBiZoi.SetColumnSpan(this.label_5, 5);
			this.label_5.Dock = DockStyle.Fill;
			this.label_5.Location = new Point(3, 358);
			this.label_5.Margin = new Padding(3, 3, 3, 0);
			this.label_5.Name = "label6";
			this.label_5.Size = new Size(507, 13);
			this.label_5.TabIndex = 10;
			this.label_5.Text = "Осмотр произвели";
			this.textBox_0.DataBindings.Add(new Binding("Text", this.class14_0, "tP_DocList.NumberDoc", true));
			this.textBox_0.Dock = DockStyle.Fill;
			this.textBox_0.Location = new Point(107, 3);
			this.textBox_0.Name = "txtNumberDoc";
			this.textBox_0.Size = new Size(172, 20);
			this.textBox_0.TabIndex = 9;
			this.class14_0.DataSetName = "dsDocuments";
			this.class14_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.dataGridView_1.AutoGenerateColumns = false;
			this.dataGridView_1.BackgroundColor = SystemColors.Window;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle4.BackColor = SystemColors.Control;
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			this.dataGridView_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewComboBoxColumn_0,
				this.dataGridViewTextBoxColumn_2
			});
			this.diamrsBiZoi.SetColumnSpan(this.dataGridView_1, 5);
			this.dataGridView_1.DataSource = this.bindingSource_0;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = SystemColors.Window;
			dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Menu;
			dataGridViewCellStyle5.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
			this.dataGridView_1.DefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView_1.Dock = DockStyle.Fill;
			this.dataGridView_1.Location = new Point(3, 223);
			this.dataGridView_1.Name = "dgvRepair";
			dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = SystemColors.Control;
			dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle6.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
			this.dataGridView_1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView_1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView_1.Size = new Size(507, 129);
			this.dataGridView_1.TabIndex = 5;
			this.dataGridView_1.RowPrePaint += this.dataGridView_0_RowPrePaint;
			this.dataGridView_1.RowsAdded += this.dataGridView_1_RowsAdded;
			this.dataGridViewComboBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewComboBoxColumn_0.DataPropertyName = "idPylon";
			this.dataGridViewComboBoxColumn_0.HeaderText = "Опора";
			this.dataGridViewComboBoxColumn_0.Name = "idPylonDgvRepair";
			this.dataGridViewComboBoxColumn_0.Resizable = DataGridViewTriState.True;
			this.dataGridViewComboBoxColumn_0.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewComboBoxColumn_0.Width = 120;
			this.dataGridViewTextBoxColumn_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_2.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_2.Name = "nameDgvRepair";
			this.bindingSource_0.DataMember = "tRepair";
			this.bindingSource_0.DataSource = this.dataSet_0;
			this.comboBox_0.DataBindings.Add(new Binding("SelectedValue", this.dataSet_0, "tOther.idInspect", true));
			this.comboBox_0.Dock = DockStyle.Fill;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(107, 29);
			this.comboBox_0.Name = "cmbTypeInspect";
			this.comboBox_0.Size = new Size(172, 21);
			this.comboBox_0.TabIndex = 7;
			this.label_2.AutoSize = true;
			this.diamrsBiZoi.SetColumnSpan(this.label_2, 5);
			this.label_2.Dock = DockStyle.Fill;
			this.label_2.Location = new Point(3, 207);
			this.label_2.Margin = new Padding(3, 3, 3, 0);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(507, 13);
			this.label_2.TabIndex = 4;
			this.label_2.Text = "Принятые меры";
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Fill;
			this.label_0.Location = new Point(285, 3);
			this.label_0.Margin = new Padding(3, 3, 3, 0);
			this.label_0.Name = "label1";
			this.label_0.Padding = new Padding(7, 0, 0, 0);
			this.label_0.Size = new Size(97, 23);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Дата документа";
			this.label_0.TextAlign = ContentAlignment.MiddleLeft;
			this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.class14_0, "tP_DocList.DateDoc", true));
			this.dateTimePicker_0.Dock = DockStyle.Fill;
			this.dateTimePicker_0.Location = new Point(388, 3);
			this.dateTimePicker_0.Name = "dtpDateDoc";
			this.dateTimePicker_0.Size = new Size(126, 20);
			this.dateTimePicker_0.TabIndex = 1;
			this.label_1.AutoSize = true;
			this.diamrsBiZoi.SetColumnSpan(this.label_1, 5);
			this.label_1.Dock = DockStyle.Fill;
			this.label_1.Location = new Point(3, 56);
			this.label_1.Margin = new Padding(3, 3, 3, 0);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(507, 13);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "Замеченные неисправности";
			this.dataGridView_0.AutoGenerateColumns = false;
			this.dataGridView_0.BackgroundColor = SystemColors.Window;
			dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle7.BackColor = SystemColors.Control;
			dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewComboBoxColumn_1,
				this.dataGridViewTextBoxColumn_3
			});
			this.diamrsBiZoi.SetColumnSpan(this.dataGridView_0, 5);
			this.dataGridView_0.DataSource = this.bindingSource_1;
			dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = SystemColors.Window;
			dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle8.SelectionBackColor = SystemColors.Menu;
			dataGridViewCellStyle8.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
			this.dataGridView_0.DefaultCellStyle = dataGridViewCellStyle8;
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(3, 72);
			this.dataGridView_0.Name = "dgvDefect";
			dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = SystemColors.Control;
			dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle9.Padding = new Padding(0, 3, 0, 3);
			dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dataGridView_0.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
			this.dataGridView_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_0.Size = new Size(507, 129);
			this.dataGridView_0.TabIndex = 3;
			this.dataGridView_0.RowPrePaint += this.dataGridView_0_RowPrePaint;
			this.dataGridView_0.RowsAdded += this.dataGridView_0_RowsAdded;
			this.dataGridViewComboBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			this.dataGridViewComboBoxColumn_1.DataPropertyName = "idPylon";
			this.dataGridViewComboBoxColumn_1.HeaderText = "Опора";
			this.dataGridViewComboBoxColumn_1.Name = "idPylonDgvDefect";
			this.dataGridViewComboBoxColumn_1.Resizable = DataGridViewTriState.True;
			this.dataGridViewComboBoxColumn_1.SortMode = DataGridViewColumnSortMode.Automatic;
			this.dataGridViewComboBoxColumn_1.Width = 120;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_3.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_3.Name = "nameDgvDefect";
			this.bindingSource_1.DataMember = "tDefect";
			this.bindingSource_1.DataSource = this.dataSet_0;
			this.tabPage_1.Controls.Add(this.panelFile_0);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tpFile";
			this.tabPage_1.Padding = new Padding(3);
			this.tabPage_1.Size = new Size(519, 471);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "Файлы";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.panelFile_0.Dock = DockStyle.Fill;
			this.panelFile_0.IdParent = 0;
			this.panelFile_0.Location = new Point(3, 3);
			this.panelFile_0.Name = "pFile";
			this.panelFile_0.Size = new Size(513, 465);
			this.panelFile_0.TabIndex = 0;
			this.panel_0.Controls.Add(this.button_2);
			this.panel_0.Controls.Add(this.button_0);
			this.panel_0.Controls.Add(this.button_1);
			this.panel_0.Dock = DockStyle.Bottom;
			this.panel_0.Location = new Point(0, 497);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(527, 46);
			this.panel_0.TabIndex = 1;
			this.button_2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_2.BackgroundImage = Resources.smethod_44();
			this.button_2.BackgroundImageLayout = ImageLayout.Center;
			this.button_2.Location = new Point(319, 11);
			this.button_2.Name = "btnPrint";
			this.button_2.Size = new Size(34, 23);
			this.button_2.TabIndex = 2;
			this.button_2.UseVisualStyleBackColor = true;
			this.button_2.Click += this.button_2_Click;
			this.button_0.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Location = new Point(359, 11);
			this.button_0.Name = "btnOK";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 1;
			this.button_0.Text = "ОК";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_1_Click;
			this.button_1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(440, 11);
			this.button_1.Name = "btnCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 0;
			this.button_1.Text = "Отмена";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.dataGridViewTextBoxColumn_0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_0.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_1.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_4.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn_5.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_6.HeaderText = "id";
			this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "idPasspDoc";
			this.dataGridViewTextBoxColumn_7.HeaderText = "idPasspDoc";
			this.dataGridViewTextBoxColumn_7.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "DateIn";
			this.dataGridViewTextBoxColumn_8.HeaderText = "DateIn";
			this.dataGridViewTextBoxColumn_8.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "DateCreate";
			this.dataGridViewTextBoxColumn_9.HeaderText = "DateCreate";
			this.dataGridViewTextBoxColumn_9.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Visible = false;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "FileName";
			this.dataGridViewTextBoxColumn_10.HeaderText = "FileName";
			this.dataGridViewTextBoxColumn_10.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(527, 543);
			base.Controls.Add(this.tabControl_0);
			base.Controls.Add(this.panel_0);
			base.Name = "FormAirLineInspectionAddEdit";
			this.Text = "Осмотр воздушной линии";
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.diamrsBiZoi.ResumeLayout(false);
			this.diamrsBiZoi.PerformLayout();
			((ISupportInitialize)this.dataGridView_2).EndInit();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			((ISupportInitialize)this.dataSet_0).EndInit();
			((ISupportInitialize)this.dataTable_2).EndInit();
			((ISupportInitialize)this.dataTable_3).EndInit();
			((ISupportInitialize)this.dataTable_4).EndInit();
			((ISupportInitialize)this.dataTable_5).EndInit();
			((ISupportInitialize)this.class14_0).EndInit();
			((ISupportInitialize)this.dataGridView_1).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			this.tabPage_1.ResumeLayout(false);
			this.panel_0.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		internal static void jNfw8M9LpB43kxR2CIwr(Form form_0, CancelEventArgs cancelEventArgs_0)
		{
			form_0.OnClosing(cancelEventArgs_0);
		}

		internal static void IiW2IX9yJHJ12FDLsMIF(Form form_0, bool bool_0)
		{
			form_0.Dispose(bool_0);
		}

		private int int_0;

		private int int_1;

		private DataTable dataTable_0;

		private DataTable dataTable_1;

		[CompilerGenerated]
		private StateFormCreate stateFormCreate_0;

		private IContainer ukCmldKycnp;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private TabPage tabPage_1;

		private Panel panel_0;

		private DateTimePicker dateTimePicker_0;

		private Label label_0;

		private Button button_0;

		private Button button_1;

		private Label label_1;

		private DataGridView dataGridView_0;

		private DataGridView dataGridView_1;

		private Label label_2;

		private PanelFile panelFile_0;

		private ComboBox comboBox_0;

		private Label label_3;

		private BindingSource bindingSource_0;

		private DataSet dataSet_0;

		private DataTable dataTable_2;

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataTable dataTable_3;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private BindingSource bindingSource_1;

		private TextBox textBox_0;

		private Label label_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridView dataGridView_2;

		private Label label_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_1;

		private BindingSource bindingSource_2;

		private Class14 class14_0;

		private TableLayoutPanel diamrsBiZoi;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataTable dataTable_4;

		private DataColumn dataColumn_4;

		private DataTable dataTable_5;

		private DataColumn dataColumn_5;

		private DataColumn dataColumn_6;

		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private Button button_2;
	}
}
