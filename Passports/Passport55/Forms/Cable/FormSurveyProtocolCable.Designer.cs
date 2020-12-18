using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Constants;
using ControlsLbr;
using DataSql;
using FormLbr;
using Passport.Classes;
using Passport.DataSets;

namespace Passport.Forms.Cable
{
	public class FormSurveyProtocolCable : FormBase
	{
		public int IdProtocol
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public int IdCable
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		public FormSurveyProtocolCable()
		{
			this.method_15();
		}

		public FormSurveyProtocolCable(SQLSettings settings, int int_3, int idCable, string cableName, StateFormCreate state)
		{
			this.method_15();
			this.SqlSettings = settings;
			this.string_0 = cableName;
			if (state != null)
			{
				if (state != 1)
				{
					if (state == 7)
					{
						this.Text = "Протокол обследования : " + cableName;
						this.int_0 = int_3;
						this.int_1 = idCable;
						this.stateFormCreate_0 = state;
						base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_CabProtocol, true, "WHERE idObjList = " + idCable.ToString() + " AND Deleted = ((0))");
						this.bindingSource_0.ResetBindings(false);
						this.bindingSource_0.Position = this.bindingSource_0.Find("id", int_3);
						this.bindingNavigator_0.Visible = true;
						foreach (object obj in this.tabPage_0.Controls)
						{
							Control control_ = (Control)obj;
							this.method_3(control_, true);
						}
						foreach (object obj2 in this.tabPage_1.Controls)
						{
							Control control_2 = (Control)obj2;
							this.method_3(control_2, true);
						}
						this.button_1.Visible = false;
						this.button_0.Text = "Закрыть";
					}
				}
				else
				{
					this.Text = "Редактирование протокола обследования";
					this.int_0 = int_3;
					this.int_1 = idCable;
					this.stateFormCreate_0 = state;
					this.method_0(idCable);
					this.method_2(idCable);
				}
			}
			else
			{
				this.Text = "Добавление протокола обследования";
				this.int_1 = idCable;
				this.stateFormCreate_0 = state;
				this.method_1(idCable, cableName);
				this.method_2(idCable);
			}
			this.method_4();
		}

		private void method_0(int int_3)
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_CabProtocol, true, "WHERE id = " + this.int_0.ToString() + " AND Deleted = ((0))");
			this.bindingSource_0.ResetBindings(false);
		}

		private void method_1(int int_3, string string_1)
		{
			dsDocuments.Class187 @class = this.dsDocuments_0.tP_CabProtocol.method_5();
			@class.method_1(int_3);
			@class.NaimKL = string_1;
			@class.method_11(false);
			this.dsDocuments_0.tP_CabProtocol.method_0(@class);
			this.bindingSource_0.ResetBindings(false);
			this.dsDocuments_0.tP_CabProtocol.BeginInit();
		}

		private void method_2(int int_3)
		{
			DataTable dataTable = base.SelectSqlData("vP_CabTestingMaxDate", true, "WHERE id = " + int_3.ToString());
			((DataRowView)this.bindingSource_0.Current)["IspData"] = ((dataTable.Rows.Count > 0) ? dataTable.Rows[0]["Date"] : DBNull.Value);
			this.dsDocuments_0.tP_CabProtocol.BeginInit();
		}

		private void method_3(Control control_0, bool bool_0)
		{
			if (control_0.GetType() == typeof(TextBox))
			{
				((TextBox)control_0).ReadOnly = bool_0;
			}
			if (control_0.GetType() == typeof(ComboBoxReadOnly))
			{
				((ComboBoxReadOnly)control_0).ReadOnly = bool_0;
			}
		}

		private void method_4()
		{
			string str = string.Format("WHERE idObjList = {0} AND Deleted = ((0))", this.int_1);
			string str2 = "ORDER BY Number";
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_CabSection, true, str + " " + str2);
			string str3 = "ORDER BY CONVERT(INT, CASE WHEN Name like '%[^0-9]%' THEN SUBSTRING(Name,1,PATINDEX('%[^0-9]%',Name)-1) ELSE Name END)";
			str = string.Format("WHERE idParent = {0} AND TypeCodeId IN (612, 926) AND Deleted = ((0))", this.int_1);
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tSchm_ObjList, true, str + " " + str3);
			this.comboBoxReadOnly_23.DataSource = this.method_5();
			this.comboBoxReadOnly_23.DisplayMember = "FIO";
			this.comboBoxReadOnly_23.ValueMember = "Id";
			this.comboBoxReadOnly_25.DataSource = this.method_6();
			this.comboBoxReadOnly_25.DisplayMember = "FIO";
			this.comboBoxReadOnly_25.ValueMember = "Id";
			this.comboBoxReadOnly_26.DataSource = this.method_8();
			this.comboBoxReadOnly_26.DisplayMember = "FIO";
			this.comboBoxReadOnly_26.ValueMember = "Id";
			this.comboBoxReadOnly_22.DataSource = this.method_9();
			this.comboBoxReadOnly_22.DisplayMember = "FIO";
			this.comboBoxReadOnly_22.ValueMember = "Id";
			this.comboBoxReadOnly_24.DataSource = this.method_7();
			this.comboBoxReadOnly_24.DisplayMember = "FIO";
			this.comboBoxReadOnly_24.ValueMember = "Id";
			this.comboBoxReadOnly_21.DataSource = this.method_10();
			this.comboBoxReadOnly_21.DisplayMember = "Name";
			this.comboBoxReadOnly_21.ValueMember = "id";
		}

		private void FormSurveyProtocolCable_Load(object sender, EventArgs e)
		{
			this.int_2 = Class110.smethod_0(this.SqlSettings, base.Name);
		}

		private DataTable method_5()
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vWorkerGroup, true, "WHERE ParentKey = ';GroupWorker;ChairmanCommission;'  AND DateEnd IS NULL");
			return this.dsDocuments_0.vWorkerGroup.Copy();
		}

		private DataTable method_6()
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vWorkerGroup, true, "WHERE ParentKey = ';GroupWorker;CableService;Chief;'  AND DateEnd IS NULL");
			return this.dsDocuments_0.vWorkerGroup.Copy();
		}

		private DataTable method_7()
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vWorkerGroup, true, "WHERE ParentKey = ';GroupWorker;EngPTS;'  AND DateEnd IS NULL");
			return this.dsDocuments_0.vWorkerGroup.Copy();
		}

		private DataTable method_8()
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vWorkerGroup, true, "WHERE ParentKey = ';GroupWorker;HeadPL;'  AND DateEnd IS NULL");
			return this.dsDocuments_0.vWorkerGroup.Copy();
		}

		private DataTable method_9()
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vWorkerGroup, true, "WHERE ParentKey = ';GroupWorker;HeadRegion;'  AND DateEnd IS NULL");
			return this.dsDocuments_0.vWorkerGroup.Copy();
		}

		private DataTable method_10()
		{
			new DataTable();
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_ValueLists, true, "WHERE ParentKey = ';Cable;Protocol;Survey;CauseDamage;' AND isGroup = 0");
			return this.dsDocuments_0.tP_ValueLists.Copy();
		}

		private DataTable method_11(int int_3)
		{
			new DataTable();
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_ValueLists, true, "WHERE ParentId = " + int_3.ToString() + " AND isGroup = 0");
			if (this.dsDocuments_0.tP_ValueLists.Rows.Count > 0)
			{
				this.comboBoxReadOnly_20.Enabled = true;
			}
			else
			{
				this.comboBoxReadOnly_20.Enabled = false;
				this.comboBoxReadOnly_20.SelectedValue = -1;
			}
			return this.dsDocuments_0.tP_ValueLists.Copy();
		}

		private void comboBoxReadOnly_21_SelectedIndexChanged(object sender, EventArgs e)
		{
			int num = 0;
			if (this.comboBoxReadOnly_21.SelectedValue != null && int.TryParse(this.comboBoxReadOnly_21.SelectedValue.ToString(), out num))
			{
				DataTable dataSource = this.method_11(num);
				this.comboBoxReadOnly_20.DataSource = dataSource;
				this.comboBoxReadOnly_20.DisplayMember = "Name";
				this.comboBoxReadOnly_20.ValueMember = "id";
				this.textBox_9.Enabled = (num == 462);
			}
		}

		private string method_12(int int_3)
		{
			DataTable dataTable = base.SelectSqlData("tP_ValueLists", true, "WHERE id = " + int_3.ToString());
			if (dataTable.Rows.Count <= 0)
			{
				return "";
			}
			return dataTable.Rows[0]["Name"].ToString();
		}

		private void FormSurveyProtocolCable_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (this.stateFormCreate_0 == null && !this.method_13())
				{
					e.Cancel = true;
					return;
				}
				if (this.stateFormCreate_0 == 1 && !this.method_14())
				{
					e.Cancel = true;
					return;
				}
				Class110.smethod_2(this.SqlSettings, this.int_2, this.stateFormCreate_0);
			}
			Class110.smethod_1(this.SqlSettings, this.int_2);
		}

		private bool method_13()
		{
			this.dsDocuments_0.tP_CabProtocol.Rows[0].EndEdit();
			this.int_0 = base.InsertSqlDataOneRow(this.dsDocuments_0, this.dsDocuments_0.tP_CabProtocol);
			return this.int_0 > 0;
		}

		private bool method_14()
		{
			this.dsDocuments_0.tP_CabProtocol.Rows[0].EndEdit();
			return base.UpdateSqlData(this.dsDocuments_0, this.dsDocuments_0.tP_CabProtocol);
		}

		private void comboBoxReadOnly_28_TextChanged(object sender, EventArgs e)
		{
			DataRowCollection rows = Clutch.GetData(this.SqlSettings, this.int_1, this.comboBoxReadOnly_28.Text, TypeObjList.ClutchConnecting, false).Rows;
			if (rows.Count > 0)
			{
				((DataRowView)this.bindingSource_0.Current)["MuftaTip"] = rows[0]["Тип"];
				((DataRowView)this.bindingSource_0.Current)["MuftaDataM"] = ((rows[0]["Дата монтажа"] is DateTime) ? rows[0]["Дата монтажа"] : DBNull.Value);
				((DataRowView)this.bindingSource_0.Current)["MonterFIO"] = rows[0]["Монтаж произвел"];
				this.bindingSource_0.ResetBindings(false);
			}
		}

		private void comboBoxReadOnly_27_TextChanged(object sender, EventArgs e)
		{
			DataRow[] array = this.dsDocuments_0.tP_CabSection.Select("Number = '" + this.comboBoxReadOnly_27.Text + "'");
			if (array.Count<DataRow>() > 0)
			{
				((DataRowView)this.bindingSource_0.Current)["KabelMarka"] = Class109.smethod_4(this.SqlSettings, (int)array[0]["id"]);
				((DataRowView)this.bindingSource_0.Current)["Urab"] = Math.Round((decimal)array[0]["Voltage"]).ToString();
				((DataRowView)this.bindingSource_0.Current)["KData"] = ((array[0]["YearLaying"] != DBNull.Value) ? array[0]["YearLaying"] : DBNull.Value);
				this.bindingSource_0.ResetBindings(false);
			}
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_15()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormSurveyProtocolCable));
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.bindingNavigator_0 = new BindingNavigator(this.icontainer_0);
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dsDocuments_0 = new dsDocuments();
			this.toolStripLabel_0 = new ToolStripLabel();
			this.toolStripButton_0 = new ToolStripButton();
			this.toolStripButton_1 = new ToolStripButton();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripTextBox_0 = new ToolStripTextBox();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripButton_2 = new ToolStripButton();
			this.toolStripButton_3 = new ToolStripButton();
			this.toolStripSeparator_2 = new ToolStripSeparator();
			this.toolStripButton_4 = new ToolStripButton();
			this.toolStripButton_5 = new ToolStripButton();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.comboBoxReadOnly_29 = new ComboBoxReadOnly();
			this.label_0 = new Label();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.comboBoxReadOnly_0 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_1 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_2 = new ComboBoxReadOnly();
			this.label_4 = new Label();
			this.comboBoxReadOnly_3 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_4 = new ComboBoxReadOnly();
			this.label_5 = new Label();
			this.label_6 = new Label();
			this.textBox_0 = new TextBox();
			this.comboBoxReadOnly_5 = new ComboBoxReadOnly();
			this.label_7 = new Label();
			this.label_8 = new Label();
			this.nullableDateTimePicker_0 = new NullableDateTimePicker();
			this.label_9 = new Label();
			this.label_10 = new Label();
			this.label_11 = new Label();
			this.label_12 = new Label();
			this.label_13 = new Label();
			this.label_14 = new Label();
			this.label_15 = new Label();
			this.groupBox_0 = new GroupBox();
			this.comboBoxReadOnly_28 = new ComboBoxReadOnly();
			this.label_16 = new Label();
			this.label_17 = new Label();
			this.label_18 = new Label();
			this.label_19 = new Label();
			this.textBox_1 = new TextBox();
			this.nullableDateTimePicker_1 = new NullableDateTimePicker();
			this.textBox_2 = new TextBox();
			this.groupBox_1 = new GroupBox();
			this.comboBoxReadOnly_27 = new ComboBoxReadOnly();
			this.textBox_11 = new TextBox();
			this.label_20 = new Label();
			this.label_21 = new Label();
			this.label_22 = new Label();
			this.label_23 = new Label();
			this.nullableDateTimePicker_2 = new NullableDateTimePicker();
			this.textBox_3 = new TextBox();
			this.textBox_4 = new TextBox();
			this.textBox_5 = new TextBox();
			this.comboBoxReadOnly_6 = new ComboBoxReadOnly();
			this.nullableDateTimePicker_3 = new NullableDateTimePicker();
			this.nullableDateTimePicker_4 = new NullableDateTimePicker();
			this.comboBoxReadOnly_7 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_8 = new ComboBoxReadOnly();
			this.textBox_6 = new TextBox();
			this.tabPage_1 = new TabPage();
			this.textBox_12 = new TextBox();
			this.textBox_13 = new TextBox();
			this.textBox_14 = new TextBox();
			this.textBox_15 = new TextBox();
			this.textBox_16 = new TextBox();
			this.textBox_17 = new TextBox();
			this.label_52 = new Label();
			this.label_47 = new Label();
			this.label_48 = new Label();
			this.label_49 = new Label();
			this.label_50 = new Label();
			this.label_51 = new Label();
			this.label_41 = new Label();
			this.comboBoxReadOnly_22 = new ComboBoxReadOnly();
			this.label_42 = new Label();
			this.label_43 = new Label();
			this.label_44 = new Label();
			this.label_45 = new Label();
			this.comboBoxReadOnly_23 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_24 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_25 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_26 = new ComboBoxReadOnly();
			this.textBox_10 = new TextBox();
			this.label_46 = new Label();
			this.label_38 = new Label();
			this.textBox_9 = new TextBox();
			this.comboBoxReadOnly_20 = new ComboBoxReadOnly();
			this.label_39 = new Label();
			this.label_40 = new Label();
			this.comboBoxReadOnly_21 = new ComboBoxReadOnly();
			this.label_31 = new Label();
			this.label_32 = new Label();
			this.label_33 = new Label();
			this.label_34 = new Label();
			this.label_35 = new Label();
			this.label_36 = new Label();
			this.label_37 = new Label();
			this.textBox_8 = new TextBox();
			this.comboBoxReadOnly_15 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_16 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_17 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_18 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_19 = new ComboBoxReadOnly();
			this.label_24 = new Label();
			this.label_25 = new Label();
			this.label_26 = new Label();
			this.label_27 = new Label();
			this.label_28 = new Label();
			this.label_29 = new Label();
			this.label_30 = new Label();
			this.textBox_7 = new TextBox();
			this.comboBoxReadOnly_9 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_10 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_11 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_12 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_13 = new ComboBoxReadOnly();
			this.comboBoxReadOnly_14 = new ComboBoxReadOnly();
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.tableLayoutPanel_0.SuspendLayout();
			((ISupportInitialize)this.bindingNavigator_0).BeginInit();
			this.bindingNavigator_0.SuspendLayout();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dsDocuments_0).BeginInit();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.groupBox_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			this.tabPage_1.SuspendLayout();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 4;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 261f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 129f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110f));
			this.tableLayoutPanel_0.Controls.Add(this.bindingNavigator_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.tabControl_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 3, 1);
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 2, 1);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 2;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 34f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.Size = new Size(722, 526);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.bindingNavigator_0.AddNewItem = null;
			this.bindingNavigator_0.BindingSource = this.bindingSource_0;
			this.bindingNavigator_0.CountItem = this.toolStripLabel_0;
			this.bindingNavigator_0.CountItemFormat = "из {0}";
			this.bindingNavigator_0.DeleteItem = null;
			this.bindingNavigator_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripButton_0,
				this.toolStripButton_1,
				this.toolStripSeparator_0,
				this.toolStripTextBox_0,
				this.toolStripLabel_0,
				this.toolStripSeparator_1,
				this.toolStripButton_2,
				this.toolStripButton_3,
				this.toolStripSeparator_2,
				this.toolStripButton_4,
				this.toolStripButton_5
			});
			this.bindingNavigator_0.Location = new Point(0, 430);
			this.bindingNavigator_0.MoveFirstItem = this.toolStripButton_0;
			this.bindingNavigator_0.MoveLastItem = this.toolStripButton_3;
			this.bindingNavigator_0.MoveNextItem = this.toolStripButton_2;
			this.bindingNavigator_0.MovePreviousItem = this.toolStripButton_1;
			this.bindingNavigator_0.Name = "bnCabSection";
			this.bindingNavigator_0.PositionItem = this.toolStripTextBox_0;
			this.bindingNavigator_0.RightToLeft = RightToLeft.No;
			this.bindingNavigator_0.Size = new Size(222, 25);
			this.bindingNavigator_0.TabIndex = 4;
			this.bindingNavigator_0.Text = "bindingNavigator1";
			this.bindingNavigator_0.Visible = false;
			this.bindingSource_0.DataMember = "tP_CabProtocol";
			this.bindingSource_0.DataSource = this.dsDocuments_0;
			this.dsDocuments_0.DataSetName = "dsDocuments";
			this.dsDocuments_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.toolStripLabel_0.Name = "bindingNavigatorCountItem";
			this.toolStripLabel_0.Size = new Size(36, 22);
			this.toolStripLabel_0.Text = "из {0}";
			this.toolStripLabel_0.ToolTipText = "Total number of items";
			this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_0.Image = (Image)componentResourceManager.GetObject("bindingNavigatorMoveFirstItem.Image");
			this.toolStripButton_0.Name = "bindingNavigatorMoveFirstItem";
			this.toolStripButton_0.RightToLeftAutoMirrorImage = true;
			this.toolStripButton_0.Size = new Size(23, 22);
			this.toolStripButton_0.Text = "Move first";
			this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_1.Image = (Image)componentResourceManager.GetObject("bindingNavigatorMovePreviousItem.Image");
			this.toolStripButton_1.Name = "bindingNavigatorMovePreviousItem";
			this.toolStripButton_1.RightToLeftAutoMirrorImage = true;
			this.toolStripButton_1.Size = new Size(23, 22);
			this.toolStripButton_1.Text = "Move previous";
			this.toolStripSeparator_0.Name = "bindingNavigatorSeparator";
			this.toolStripSeparator_0.Size = new Size(6, 25);
			this.toolStripTextBox_0.AccessibleName = "Position";
			this.toolStripTextBox_0.AutoSize = false;
			this.toolStripTextBox_0.Name = "bindingNavigatorPositionItem";
			this.toolStripTextBox_0.Size = new Size(50, 23);
			this.toolStripTextBox_0.Text = "0";
			this.toolStripTextBox_0.ToolTipText = "Current position";
			this.toolStripSeparator_1.Name = "bindingNavigatorSeparator1";
			this.toolStripSeparator_1.Size = new Size(6, 25);
			this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_2.Image = (Image)componentResourceManager.GetObject("bindingNavigatorMoveNextItem.Image");
			this.toolStripButton_2.Name = "bindingNavigatorMoveNextItem";
			this.toolStripButton_2.RightToLeftAutoMirrorImage = true;
			this.toolStripButton_2.Size = new Size(23, 22);
			this.toolStripButton_2.Text = "Move next";
			this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_3.Image = (Image)componentResourceManager.GetObject("bindingNavigatorMoveLastItem.Image");
			this.toolStripButton_3.Name = "bindingNavigatorMoveLastItem";
			this.toolStripButton_3.RightToLeftAutoMirrorImage = true;
			this.toolStripButton_3.Size = new Size(23, 22);
			this.toolStripButton_3.Text = "Move last";
			this.toolStripSeparator_2.Name = "bindingNavigatorSeparator2";
			this.toolStripSeparator_2.Size = new Size(6, 25);
			this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_4.Image = (Image)componentResourceManager.GetObject("bindingNavigatorAddNewItem.Image");
			this.toolStripButton_4.Name = "bindingNavigatorAddNewItem";
			this.toolStripButton_4.RightToLeftAutoMirrorImage = true;
			this.toolStripButton_4.Size = new Size(23, 20);
			this.toolStripButton_4.Text = "Add new";
			this.toolStripButton_4.Visible = false;
			this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.toolStripButton_5.Image = (Image)componentResourceManager.GetObject("bindingNavigatorDeleteItem.Image");
			this.toolStripButton_5.Name = "bindingNavigatorDeleteItem";
			this.toolStripButton_5.RightToLeftAutoMirrorImage = true;
			this.toolStripButton_5.Size = new Size(23, 20);
			this.toolStripButton_5.Text = "Delete";
			this.toolStripButton_5.Visible = false;
			this.tableLayoutPanel_0.SetColumnSpan(this.tabControl_0, 4);
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(3, 3);
			this.tabControl_0.Name = "tcGeneral";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(716, 486);
			this.tabControl_0.TabIndex = 0;
			this.tabPage_0.Controls.Add(this.comboBoxReadOnly_29);
			this.tabPage_0.Controls.Add(this.label_0);
			this.tabPage_0.Controls.Add(this.label_1);
			this.tabPage_0.Controls.Add(this.label_2);
			this.tabPage_0.Controls.Add(this.label_3);
			this.tabPage_0.Controls.Add(this.comboBoxReadOnly_0);
			this.tabPage_0.Controls.Add(this.comboBoxReadOnly_1);
			this.tabPage_0.Controls.Add(this.comboBoxReadOnly_2);
			this.tabPage_0.Controls.Add(this.label_4);
			this.tabPage_0.Controls.Add(this.comboBoxReadOnly_3);
			this.tabPage_0.Controls.Add(this.comboBoxReadOnly_4);
			this.tabPage_0.Controls.Add(this.label_5);
			this.tabPage_0.Controls.Add(this.label_6);
			this.tabPage_0.Controls.Add(this.textBox_0);
			this.tabPage_0.Controls.Add(this.comboBoxReadOnly_5);
			this.tabPage_0.Controls.Add(this.label_7);
			this.tabPage_0.Controls.Add(this.label_8);
			this.tabPage_0.Controls.Add(this.nullableDateTimePicker_0);
			this.tabPage_0.Controls.Add(this.label_9);
			this.tabPage_0.Controls.Add(this.label_10);
			this.tabPage_0.Controls.Add(this.label_11);
			this.tabPage_0.Controls.Add(this.label_12);
			this.tabPage_0.Controls.Add(this.label_13);
			this.tabPage_0.Controls.Add(this.label_14);
			this.tabPage_0.Controls.Add(this.label_15);
			this.tabPage_0.Controls.Add(this.groupBox_0);
			this.tabPage_0.Controls.Add(this.groupBox_1);
			this.tabPage_0.Controls.Add(this.textBox_5);
			this.tabPage_0.Controls.Add(this.comboBoxReadOnly_6);
			this.tabPage_0.Controls.Add(this.nullableDateTimePicker_3);
			this.tabPage_0.Controls.Add(this.nullableDateTimePicker_4);
			this.tabPage_0.Controls.Add(this.comboBoxReadOnly_7);
			this.tabPage_0.Controls.Add(this.comboBoxReadOnly_8);
			this.tabPage_0.Controls.Add(this.textBox_6);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tpGeneral";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(708, 460);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Общие сведения";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.comboBoxReadOnly_29.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_29.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_29.DataBindings.Add(new Binding("Text", this.bindingSource_0, "ProtocolTip", true));
			this.comboBoxReadOnly_29.FormattingEnabled = true;
			this.comboBoxReadOnly_29.Items.AddRange(new object[]
			{
				"муфты",
				"кабеля",
				"образца кабеля"
			});
			this.comboBoxReadOnly_29.Location = new Point(112, 52);
			this.comboBoxReadOnly_29.Name = "cbSurvey";
			this.comboBoxReadOnly_29.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_29.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_29.Size = new Size(166, 21);
			this.comboBoxReadOnly_29.TabIndex = 2;
			this.label_0.AutoSize = true;
			this.label_0.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.label_0.Location = new Point(289, 15);
			this.label_0.Name = "label24";
			this.label_0.Size = new Size(23, 18);
			this.label_0.TabIndex = 69;
			this.label_0.Text = "№";
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(8, 422);
			this.label_1.Name = "label23";
			this.label_1.Size = new Size(245, 13);
			this.label_1.TabIndex = 68;
			this.label_1.Text = "Характер повреждения по наружному осмотру";
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(8, 388);
			this.label_2.Name = "label22";
			this.label_2.Size = new Size(150, 13);
			this.label_2.TabIndex = 67;
			this.label_2.Text = "Повреждения, причиненные";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(421, 388);
			this.label_3.Name = "label21";
			this.label_3.Size = new Size(216, 13);
			this.label_3.TabIndex = 66;
			this.label_3.Text = "Наличие повреждения соседних кабелей";
			this.comboBoxReadOnly_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_0.DataBindings.Add(new Binding("Text", this.bindingSource_0, "ProchPovreg", true));
			this.comboBoxReadOnly_0.FormattingEnabled = true;
			this.comboBoxReadOnly_0.Items.AddRange(new object[]
			{
				"соседними трубами",
				"канализацией",
				"прочими сооуружениями"
			});
			this.comboBoxReadOnly_0.Location = new Point(164, 385);
			this.comboBoxReadOnly_0.Name = "cbThanDamaged";
			this.comboBoxReadOnly_0.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_0.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_0.Size = new Size(249, 21);
			this.comboBoxReadOnly_0.TabIndex = 23;
			this.comboBoxReadOnly_0.Tag = "Повреждения, причиненные";
			this.comboBoxReadOnly_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_1.DataBindings.Add(new Binding("Text", this.bindingSource_0, "SosedKabPovreg", true));
			this.comboBoxReadOnly_1.FormattingEnabled = true;
			this.comboBoxReadOnly_1.Location = new Point(643, 385);
			this.comboBoxReadOnly_1.Name = "cbNeighboringDamaged";
			this.comboBoxReadOnly_1.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_1.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_1.Size = new Size(53, 21);
			this.comboBoxReadOnly_1.TabIndex = 24;
			this.comboBoxReadOnly_1.Tag = "Наличие соседних кабелей";
			this.comboBoxReadOnly_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_2.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_2.DataBindings.Add(new Binding("Text", this.bindingSource_0, "XarakterPovreg", true));
			this.comboBoxReadOnly_2.FormattingEnabled = true;
			this.comboBoxReadOnly_2.Items.AddRange(new object[]
			{
				"оболочка кабеля",
				"жилы",
				"в муфте",
				"механическое повреждение",
				"корпус муфты"
			});
			this.comboBoxReadOnly_2.Location = new Point(259, 419);
			this.comboBoxReadOnly_2.Name = "cbCharacterDamaged";
			this.comboBoxReadOnly_2.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_2.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_2.Size = new Size(437, 21);
			this.comboBoxReadOnly_2.TabIndex = 25;
			this.comboBoxReadOnly_2.Tag = "Характер повреждения по наружному осмотру";
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(421, 354);
			this.label_4.Name = "label20";
			this.label_4.Size = new Size(110, 13);
			this.label_4.TabIndex = 62;
			this.label_4.Text = "Место повреждения";
			this.comboBoxReadOnly_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_3.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_3.DataBindings.Add(new Binding("Text", this.bindingSource_0, "MestoPovreg", true));
			this.comboBoxReadOnly_3.FormattingEnabled = true;
			this.comboBoxReadOnly_3.Items.AddRange(new object[]
			{
				"на прямой линии",
				"на изгибе",
				"сверху",
				"снизу",
				"сбоку"
			});
			this.comboBoxReadOnly_3.Location = new Point(537, 351);
			this.comboBoxReadOnly_3.Name = "cbDamagedCable";
			this.comboBoxReadOnly_3.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_3.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_3.Size = new Size(159, 21);
			this.comboBoxReadOnly_3.TabIndex = 22;
			this.comboBoxReadOnly_3.Tag = "Место повреждения";
			this.comboBoxReadOnly_4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_4.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_4.DataBindings.Add(new Binding("Text", this.bindingSource_0, "SostGrunt", true));
			this.comboBoxReadOnly_4.FormattingEnabled = true;
			this.comboBoxReadOnly_4.Items.AddRange(new object[]
			{
				"удовлетворительное",
				"неудовлетворительное"
			});
			this.comboBoxReadOnly_4.Location = new Point(267, 351);
			this.comboBoxReadOnly_4.Name = "cbGroundCondition";
			this.comboBoxReadOnly_4.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_4.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_4.Size = new Size(146, 21);
			this.comboBoxReadOnly_4.TabIndex = 21;
			this.comboBoxReadOnly_4.Tag = "Состояние грунта";
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(165, 354);
			this.label_5.Name = "label19";
			this.label_5.Size = new Size(97, 13);
			this.label_5.TabIndex = 59;
			this.label_5.Text = "Состояние грунта";
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(5, 354);
			this.label_6.Name = "label18";
			this.label_6.Size = new Size(112, 13);
			this.label_6.TabIndex = 58;
			this.label_6.Text = "Глубина залегани, м";
			this.textBox_0.BackColor = Color.White;
			this.textBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_0, "GlubZalegKab", true));
			this.textBox_0.Location = new Point(123, 351);
			this.textBox_0.Name = "tbCableDepth";
			this.textBox_0.Size = new Size(35, 20);
			this.textBox_0.TabIndex = 20;
			this.comboBoxReadOnly_5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_5.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_5.DataBindings.Add(new Binding("Text", this.bindingSource_0, "VidProkl", true));
			this.comboBoxReadOnly_5.FormattingEnabled = true;
			this.comboBoxReadOnly_5.Items.AddRange(new object[]
			{
				"тоннель",
				"коллектор",
				"дорога",
				"трамвайные пути",
				"эстакада",
				"кабельный канал",
				"траншея (без покрытия)",
				"траншея (с покрытием)",
				"траншея (под асфальтом)",
				"траншея (под бетоном)"
			});
			this.comboBoxReadOnly_5.Location = new Point(496, 318);
			this.comboBoxReadOnly_5.Name = "cbInstallationView";
			this.comboBoxReadOnly_5.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_5.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_5.Size = new Size(200, 21);
			this.comboBoxReadOnly_5.TabIndex = 19;
			this.comboBoxReadOnly_5.Tag = "Вид прокладки в месте повреджения";
			this.label_7.AutoSize = true;
			this.label_7.Location = new Point(296, 321);
			this.label_7.Name = "label17";
			this.label_7.Size = new Size(197, 13);
			this.label_7.TabIndex = 55;
			this.label_7.Text = "Вид прокладки в месте повреджения";
			this.label_8.AutoSize = true;
			this.label_8.Location = new Point(5, 321);
			this.label_8.Name = "label16";
			this.label_8.Size = new Size(153, 13);
			this.label_8.TabIndex = 54;
			this.label_8.Text = "Дата последнего испытания";
			this.nullableDateTimePicker_0.DataBindings.Add(new Binding("Value", this.bindingSource_0, "IspData", true));
			this.nullableDateTimePicker_0.Location = new Point(159, 318);
			this.nullableDateTimePicker_0.MinimumSize = new Size(135, 20);
			this.nullableDateTimePicker_0.Name = "dtpDateLastTesting";
			this.nullableDateTimePicker_0.Size = new Size(135, 20);
			this.nullableDateTimePicker_0.TabIndex = 18;
			this.nullableDateTimePicker_0.Value = new DateTime(2016, 8, 24, 13, 23, 59, 996);
			this.label_9.AutoSize = true;
			this.label_9.Location = new Point(480, 91);
			this.label_9.Name = "label7";
			this.label_9.Size = new Size(79, 13);
			this.label_9.TabIndex = 52;
			this.label_9.Text = "Дата ремонта";
			this.label_10.AutoSize = true;
			this.label_10.Location = new Point(235, 91);
			this.label_10.Name = "label6";
			this.label_10.Size = new Size(104, 13);
			this.label_10.TabIndex = 51;
			this.label_10.Text = "Дата повреждения";
			this.label_11.AutoSize = true;
			this.label_11.Location = new Point(22, 91);
			this.label_11.Name = "label5";
			this.label_11.Size = new Size(89, 13);
			this.label_11.TabIndex = 50;
			this.label_11.Text = "кабель вышел в";
			this.label_12.AutoSize = true;
			this.label_12.Location = new Point(32, 55);
			this.label_12.Name = "label4";
			this.label_12.Size = new Size(79, 13);
			this.label_12.TabIndex = 49;
			this.label_12.Text = "обследования";
			this.label_13.AutoSize = true;
			this.label_13.Location = new Point(289, 55);
			this.label_13.Name = "label3";
			this.label_13.Size = new Size(132, 13);
			this.label_13.TabIndex = 48;
			this.label_13.Text = "имеющего повреждение";
			this.label_14.AutoSize = true;
			this.label_14.Location = new Point(560, 123);
			this.label_14.Name = "label2";
			this.label_14.Size = new Size(30, 13);
			this.label_14.TabIndex = 47;
			this.label_14.Text = "Дом";
			this.label_15.AutoSize = true;
			this.label_15.Location = new Point(278, 123);
			this.label_15.Name = "label1";
			this.label_15.Size = new Size(143, 13);
			this.label_15.TabIndex = 46;
			this.label_15.Text = "Адрес места повреждения";
			this.groupBox_0.Controls.Add(this.comboBoxReadOnly_28);
			this.groupBox_0.Controls.Add(this.label_16);
			this.groupBox_0.Controls.Add(this.label_17);
			this.groupBox_0.Controls.Add(this.label_18);
			this.groupBox_0.Controls.Add(this.label_19);
			this.groupBox_0.Controls.Add(this.textBox_1);
			this.groupBox_0.Controls.Add(this.nullableDateTimePicker_1);
			this.groupBox_0.Controls.Add(this.textBox_2);
			this.groupBox_0.Location = new Point(5, 256);
			this.groupBox_0.Name = "gbClutch";
			this.groupBox_0.Size = new Size(691, 44);
			this.groupBox_0.TabIndex = 45;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Сведения о муфте";
			this.comboBoxReadOnly_28.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_28.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_28.DataBindings.Add(new Binding("Text", this.bindingSource_0, "MuftaN", true));
			this.comboBoxReadOnly_28.DataSource = this.dsDocuments_0;
			this.comboBoxReadOnly_28.DisplayMember = "tSchm_ObjList.Name";
			this.comboBoxReadOnly_28.FormattingEnabled = true;
			this.comboBoxReadOnly_28.Location = new Point(30, 15);
			this.comboBoxReadOnly_28.Name = "cbClutchNumber";
			this.comboBoxReadOnly_28.ReadOnlyBackColor = SystemColors.Control;
			this.comboBoxReadOnly_28.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_28.Size = new Size(49, 21);
			this.comboBoxReadOnly_28.TabIndex = 14;
			this.comboBoxReadOnly_28.ValueMember = "tSchm_ObjList.Id";
			this.comboBoxReadOnly_28.TextChanged += this.comboBoxReadOnly_28_TextChanged;
			this.label_16.AutoSize = true;
			this.label_16.Location = new Point(9, 19);
			this.label_16.Name = "label11";
			this.label_16.Size = new Size(18, 13);
			this.label_16.TabIndex = 22;
			this.label_16.Text = "№";
			this.label_17.AutoSize = true;
			this.label_17.Location = new Point(85, 19);
			this.label_17.Name = "label12";
			this.label_17.Size = new Size(26, 13);
			this.label_17.TabIndex = 23;
			this.label_17.Text = "Тип";
			this.label_18.AutoSize = true;
			this.label_18.Location = new Point(220, 19);
			this.label_18.Name = "label13";
			this.label_18.Size = new Size(81, 13);
			this.label_18.TabIndex = 24;
			this.label_18.Text = "Дата монтажа";
			this.label_19.AutoSize = true;
			this.label_19.Location = new Point(437, 19);
			this.label_19.Name = "label14";
			this.label_19.Size = new Size(105, 13);
			this.label_19.TabIndex = 25;
			this.label_19.Text = "Монтер-кабельщик";
			this.textBox_1.BackColor = Color.White;
			this.textBox_1.DataBindings.Add(new Binding("Text", this.bindingSource_0, "MonterFIO", true));
			this.textBox_1.Location = new Point(548, 16);
			this.textBox_1.Name = "tbCableMaster";
			this.textBox_1.ReadOnly = true;
			this.textBox_1.Size = new Size(135, 20);
			this.textBox_1.TabIndex = 17;
			this.textBox_1.Tag = "Монтер-кабельщик";
			this.nullableDateTimePicker_1.DataBindings.Add(new Binding("Value", this.bindingSource_0, "MuftaDataM", true));
			this.nullableDateTimePicker_1.Location = new Point(301, 16);
			this.nullableDateTimePicker_1.MinimumSize = new Size(135, 20);
			this.nullableDateTimePicker_1.Name = "dtpClutchDateMount";
			this.nullableDateTimePicker_1.Size = new Size(135, 20);
			this.nullableDateTimePicker_1.TabIndex = 16;
			this.nullableDateTimePicker_1.Tag = "Дата монтажа";
			this.nullableDateTimePicker_1.Value = new DateTime(2016, 8, 24, 13, 24, 0, 0);
			this.textBox_2.BackColor = Color.White;
			this.textBox_2.DataBindings.Add(new Binding("Text", this.bindingSource_0, "MuftaTip", true));
			this.textBox_2.Location = new Point(117, 16);
			this.textBox_2.Name = "tbClutchType";
			this.textBox_2.ReadOnly = true;
			this.textBox_2.Size = new Size(100, 20);
			this.textBox_2.TabIndex = 15;
			this.textBox_2.Tag = "Тип муфты";
			this.groupBox_1.Controls.Add(this.comboBoxReadOnly_27);
			this.groupBox_1.Controls.Add(this.textBox_11);
			this.groupBox_1.Controls.Add(this.label_20);
			this.groupBox_1.Controls.Add(this.label_21);
			this.groupBox_1.Controls.Add(this.label_22);
			this.groupBox_1.Controls.Add(this.label_23);
			this.groupBox_1.Controls.Add(this.nullableDateTimePicker_2);
			this.groupBox_1.Controls.Add(this.textBox_3);
			this.groupBox_1.Controls.Add(this.textBox_4);
			this.groupBox_1.Location = new Point(5, 156);
			this.groupBox_1.Name = "gbCable";
			this.groupBox_1.Size = new Size(691, 86);
			this.groupBox_1.TabIndex = 44;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "Данные кабеля";
			this.comboBoxReadOnly_27.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_27.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_27.DataBindings.Add(new Binding("Text", this.bindingSource_0, "UchN", true));
			this.comboBoxReadOnly_27.DataSource = this.dsDocuments_0;
			this.comboBoxReadOnly_27.DisplayMember = "tP_CabSection.Number";
			this.comboBoxReadOnly_27.FormattingEnabled = true;
			this.comboBoxReadOnly_27.Location = new Point(33, 51);
			this.comboBoxReadOnly_27.Name = "cbSectionNumber";
			this.comboBoxReadOnly_27.ReadOnlyBackColor = SystemColors.Control;
			this.comboBoxReadOnly_27.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_27.Size = new Size(46, 21);
			this.comboBoxReadOnly_27.TabIndex = 10;
			this.comboBoxReadOnly_27.ValueMember = "tP_CabSection.Number";
			this.comboBoxReadOnly_27.TextChanged += this.comboBoxReadOnly_27_TextChanged;
			this.textBox_11.BackColor = Color.White;
			this.textBox_11.DataBindings.Add(new Binding("Text", this.bindingSource_0, "NaimKL", true));
			this.textBox_11.Location = new Point(112, 16);
			this.textBox_11.Name = "tbCableName";
			this.textBox_11.Size = new Size(472, 20);
			this.textBox_11.TabIndex = 9;
			this.label_20.AutoSize = true;
			this.label_20.Location = new Point(458, 54);
			this.label_20.Name = "label8";
			this.label_20.Size = new Size(90, 13);
			this.label_20.TabIndex = 19;
			this.label_20.Text = "Дата прокладки";
			this.label_21.AutoSize = true;
			this.label_21.Location = new Point(280, 54);
			this.label_21.Name = "label9";
			this.label_21.Size = new Size(133, 13);
			this.label_21.TabIndex = 20;
			this.label_21.Text = "Рабочее напряжение, кВ";
			this.label_22.AutoSize = true;
			this.label_22.Location = new Point(85, 54);
			this.label_22.Name = "label10";
			this.label_22.Size = new Size(40, 13);
			this.label_22.TabIndex = 21;
			this.label_22.Text = "Марка";
			this.label_23.AutoSize = true;
			this.label_23.Location = new Point(9, 54);
			this.label_23.Name = "label15";
			this.label_23.Size = new Size(18, 13);
			this.label_23.TabIndex = 23;
			this.label_23.Text = "№";
			this.nullableDateTimePicker_2.DataBindings.Add(new Binding("Value", this.bindingSource_0, "KData", true));
			this.nullableDateTimePicker_2.Location = new Point(549, 51);
			this.nullableDateTimePicker_2.MinimumSize = new Size(135, 20);
			this.nullableDateTimePicker_2.Name = "dtpCableDataLaying";
			this.nullableDateTimePicker_2.Size = new Size(135, 20);
			this.nullableDateTimePicker_2.TabIndex = 13;
			this.nullableDateTimePicker_2.Value = new DateTime(2016, 8, 24, 13, 24, 0, 4);
			this.textBox_3.BackColor = Color.White;
			this.textBox_3.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Urab", true));
			this.textBox_3.Location = new Point(418, 51);
			this.textBox_3.Name = "tbCableVoltage";
			this.textBox_3.ReadOnly = true;
			this.textBox_3.Size = new Size(37, 20);
			this.textBox_3.TabIndex = 12;
			this.textBox_4.BackColor = Color.White;
			this.textBox_4.DataBindings.Add(new Binding("Text", this.bindingSource_0, "KabelMarka", true));
			this.textBox_4.Location = new Point(125, 51);
			this.textBox_4.Name = "tbCableMakeup";
			this.textBox_4.ReadOnly = true;
			this.textBox_4.Size = new Size(151, 20);
			this.textBox_4.TabIndex = 11;
			this.textBox_5.BackColor = Color.White;
			this.textBox_5.DataBindings.Add(new Binding("Text", this.bindingSource_0, "PovregAdressDom", true));
			this.textBox_5.Location = new Point(596, 120);
			this.textBox_5.Name = "tbHouse";
			this.textBox_5.Size = new Size(100, 20);
			this.textBox_5.TabIndex = 8;
			this.comboBoxReadOnly_6.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_6.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_6.DataBindings.Add(new Binding("Text", this.bindingSource_0, "PovregAdress", true));
			this.comboBoxReadOnly_6.FormattingEnabled = true;
			this.comboBoxReadOnly_6.Location = new Point(427, 120);
			this.comboBoxReadOnly_6.Name = "cbStreet";
			this.comboBoxReadOnly_6.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_6.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_6.Size = new Size(121, 21);
			this.comboBoxReadOnly_6.TabIndex = 7;
			this.nullableDateTimePicker_3.DataBindings.Add(new Binding("Value", this.bindingSource_0, "RemontData", true));
			this.nullableDateTimePicker_3.Location = new Point(561, 86);
			this.nullableDateTimePicker_3.MinimumSize = new Size(135, 20);
			this.nullableDateTimePicker_3.Name = "dtpDateRepair";
			this.nullableDateTimePicker_3.Size = new Size(135, 20);
			this.nullableDateTimePicker_3.TabIndex = 6;
			this.nullableDateTimePicker_3.Value = new DateTime(2016, 8, 24, 13, 24, 0, 7);
			this.nullableDateTimePicker_4.DataBindings.Add(new Binding("Value", this.bindingSource_0, "PovregData", true));
			this.nullableDateTimePicker_4.Location = new Point(341, 87);
			this.nullableDateTimePicker_4.MinimumSize = new Size(135, 20);
			this.nullableDateTimePicker_4.Name = "dtpDateDamage";
			this.nullableDateTimePicker_4.Size = new Size(135, 20);
			this.nullableDateTimePicker_4.TabIndex = 5;
			this.nullableDateTimePicker_4.Value = new DateTime(2016, 8, 24, 13, 24, 0, 9);
			this.comboBoxReadOnly_7.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_7.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_7.DataBindings.Add(new Binding("Text", this.bindingSource_0, "PovregVid", true));
			this.comboBoxReadOnly_7.FormattingEnabled = true;
			this.comboBoxReadOnly_7.Items.AddRange(new object[]
			{
				"в целом месте",
				"в муфте",
				"в разделке",
				"вынос кабеля",
				"переразводка",
				"врезка",
				"механич. повр-ие(обрыв)"
			});
			this.comboBoxReadOnly_7.Location = new Point(112, 86);
			this.comboBoxReadOnly_7.Name = "cbTypeDamage";
			this.comboBoxReadOnly_7.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_7.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_7.Size = new Size(121, 21);
			this.comboBoxReadOnly_7.TabIndex = 4;
			this.comboBoxReadOnly_8.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_8.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_8.DataBindings.Add(new Binding("Text", this.bindingSource_0, "PovregTip", true));
			this.comboBoxReadOnly_8.FormattingEnabled = true;
			this.comboBoxReadOnly_8.Items.AddRange(new object[]
			{
				"аварийное",
				"при профилактическом испытании",
				"по реконструкции",
				"для контрольного осмотра",
				"плановое",
				"не включено"
			});
			this.comboBoxReadOnly_8.Location = new Point(427, 52);
			this.comboBoxReadOnly_8.Name = "cbDamage";
			this.comboBoxReadOnly_8.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_8.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_8.Size = new Size(269, 21);
			this.comboBoxReadOnly_8.TabIndex = 3;
			this.textBox_6.BackColor = Color.White;
			this.textBox_6.DataBindings.Add(new Binding("Text", this.bindingSource_0, "ProtocolN", true));
			this.textBox_6.Location = new Point(318, 15);
			this.textBox_6.Name = "tbNumber";
			this.textBox_6.Size = new Size(63, 20);
			this.textBox_6.TabIndex = 1;
			this.tabPage_1.Controls.Add(this.textBox_12);
			this.tabPage_1.Controls.Add(this.textBox_13);
			this.tabPage_1.Controls.Add(this.textBox_14);
			this.tabPage_1.Controls.Add(this.textBox_15);
			this.tabPage_1.Controls.Add(this.textBox_16);
			this.tabPage_1.Controls.Add(this.textBox_17);
			this.tabPage_1.Controls.Add(this.label_52);
			this.tabPage_1.Controls.Add(this.label_47);
			this.tabPage_1.Controls.Add(this.label_48);
			this.tabPage_1.Controls.Add(this.label_49);
			this.tabPage_1.Controls.Add(this.label_50);
			this.tabPage_1.Controls.Add(this.label_51);
			this.tabPage_1.Controls.Add(this.label_41);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_22);
			this.tabPage_1.Controls.Add(this.label_42);
			this.tabPage_1.Controls.Add(this.label_43);
			this.tabPage_1.Controls.Add(this.label_44);
			this.tabPage_1.Controls.Add(this.label_45);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_23);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_24);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_25);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_26);
			this.tabPage_1.Controls.Add(this.textBox_10);
			this.tabPage_1.Controls.Add(this.label_46);
			this.tabPage_1.Controls.Add(this.label_38);
			this.tabPage_1.Controls.Add(this.textBox_9);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_20);
			this.tabPage_1.Controls.Add(this.label_39);
			this.tabPage_1.Controls.Add(this.label_40);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_21);
			this.tabPage_1.Controls.Add(this.label_31);
			this.tabPage_1.Controls.Add(this.label_32);
			this.tabPage_1.Controls.Add(this.label_33);
			this.tabPage_1.Controls.Add(this.label_34);
			this.tabPage_1.Controls.Add(this.label_35);
			this.tabPage_1.Controls.Add(this.label_36);
			this.tabPage_1.Controls.Add(this.label_37);
			this.tabPage_1.Controls.Add(this.textBox_8);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_15);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_16);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_17);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_18);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_19);
			this.tabPage_1.Controls.Add(this.label_24);
			this.tabPage_1.Controls.Add(this.label_25);
			this.tabPage_1.Controls.Add(this.label_26);
			this.tabPage_1.Controls.Add(this.label_27);
			this.tabPage_1.Controls.Add(this.label_28);
			this.tabPage_1.Controls.Add(this.label_29);
			this.tabPage_1.Controls.Add(this.label_30);
			this.tabPage_1.Controls.Add(this.textBox_7);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_9);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_10);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_11);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_12);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_13);
			this.tabPage_1.Controls.Add(this.comboBoxReadOnly_14);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tpResult";
			this.tabPage_1.Padding = new Padding(3);
			this.tabPage_1.Size = new Size(708, 460);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "Результаты и заключение";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.textBox_12.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Ground", true));
			this.textBox_12.Location = new Point(460, 184);
			this.textBox_12.Name = "tbGround";
			this.textBox_12.Size = new Size(236, 20);
			this.textBox_12.TabIndex = 60;
			this.textBox_13.DataBindings.Add(new Binding("Text", this.bindingSource_0, "FillingHole", true));
			this.textBox_13.Location = new Point(513, 157);
			this.textBox_13.Name = "tbFillingHole";
			this.textBox_13.Size = new Size(183, 20);
			this.textBox_13.TabIndex = 59;
			this.textBox_14.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Manhole", true));
			this.textBox_14.Location = new Point(453, 130);
			this.textBox_14.Name = "tbManhole";
			this.textBox_14.Size = new Size(243, 20);
			this.textBox_14.TabIndex = 58;
			this.textBox_15.DataBindings.Add(new Binding("Text", this.bindingSource_0, "NoMass", true));
			this.textBox_15.Location = new Point(510, 103);
			this.textBox_15.Name = "tbNoMass";
			this.textBox_15.Size = new Size(186, 20);
			this.textBox_15.TabIndex = 57;
			this.textBox_16.DataBindings.Add(new Binding("Text", this.bindingSource_0, "DegenerationMass", true));
			this.textBox_16.Location = new Point(510, 76);
			this.textBox_16.Name = "tbDegenerationMass";
			this.textBox_16.Size = new Size(186, 20);
			this.textBox_16.TabIndex = 56;
			this.textBox_17.DataBindings.Add(new Binding("Text", this.bindingSource_0, "Craks", true));
			this.textBox_17.Location = new Point(481, 49);
			this.textBox_17.Name = "tbCracks";
			this.textBox_17.Size = new Size(215, 20);
			this.textBox_17.TabIndex = 55;
			this.label_52.AutoSize = true;
			this.label_52.Location = new Point(384, 37);
			this.label_52.Name = "label53";
			this.label_52.Size = new Size(91, 13);
			this.label_52.TabIndex = 54;
			this.label_52.Text = "Дефекты пайки:";
			this.label_47.AutoSize = true;
			this.label_47.Location = new Point(384, 187);
			this.label_47.Name = "label52";
			this.label_47.Size = new Size(70, 13);
			this.label_47.TabIndex = 53;
			this.label_47.Text = "Заземлений";
			this.label_48.AutoSize = true;
			this.label_48.Location = new Point(384, 160);
			this.label_48.Name = "label51";
			this.label_48.Size = new Size(123, 13);
			this.label_48.TabIndex = 52;
			this.label_48.Text = "Заливочных отверстий";
			this.label_49.AutoSize = true;
			this.label_49.Location = new Point(384, 133);
			this.label_49.Name = "label50";
			this.label_49.Size = new Size(63, 13);
			this.label_49.TabIndex = 51;
			this.label_49.Text = "Горловины";
			this.label_50.AutoSize = true;
			this.label_50.Location = new Point(384, 106);
			this.label_50.Name = "label49";
			this.label_50.Size = new Size(121, 13);
			this.label_50.TabIndex = 50;
			this.label_50.Text = "Уход массы из муфты";
			this.label_51.AutoSize = true;
			this.label_51.Location = new Point(384, 79);
			this.label_51.Name = "label48";
			this.label_51.Size = new Size(120, 13);
			this.label_51.TabIndex = 49;
			this.label_51.Text = "Перерождение массы";
			this.label_41.AutoSize = true;
			this.label_41.Location = new Point(366, 378);
			this.label_41.Name = "label47";
			this.label_41.Size = new Size(148, 13);
			this.label_41.TabIndex = 48;
			this.label_41.Text = "Начальник эл. лаборатории";
			this.comboBoxReadOnly_22.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_22.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_22.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "NachSR", true));
			this.comboBoxReadOnly_22.FormattingEnabled = true;
			this.comboBoxReadOnly_22.Location = new Point(525, 405);
			this.comboBoxReadOnly_22.Name = "cbChiefNetRegion";
			this.comboBoxReadOnly_22.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_22.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_22.Size = new Size(146, 21);
			this.comboBoxReadOnly_22.TabIndex = 48;
			this.label_42.AutoSize = true;
			this.label_42.Location = new Point(88, 378);
			this.label_42.Name = "label46";
			this.label_42.Size = new Size(133, 13);
			this.label_42.TabIndex = 47;
			this.label_42.Text = "Председатель комиссии";
			this.label_43.AutoSize = true;
			this.label_43.Location = new Point(62, 405);
			this.label_43.Name = "label45";
			this.label_43.Size = new Size(160, 13);
			this.label_43.TabIndex = 46;
			this.label_43.Text = "Начальник службы каб. сетей";
			this.label_44.AutoSize = true;
			this.label_44.Location = new Point(366, 408);
			this.label_44.Name = "label44";
			this.label_44.Size = new Size(150, 13);
			this.label_44.TabIndex = 45;
			this.label_44.Text = "Начальник сетевого района";
			this.label_45.AutoSize = true;
			this.label_45.Location = new Point(143, 435);
			this.label_45.Name = "label43";
			this.label_45.Size = new Size(78, 13);
			this.label_45.TabIndex = 44;
			this.label_45.Text = "Инженер ПТС";
			this.comboBoxReadOnly_23.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_23.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_23.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "PredsKomiss", true));
			this.comboBoxReadOnly_23.FormattingEnabled = true;
			this.comboBoxReadOnly_23.Location = new Point(228, 375);
			this.comboBoxReadOnly_23.Name = "cbChairman";
			this.comboBoxReadOnly_23.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_23.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_23.Size = new Size(121, 21);
			this.comboBoxReadOnly_23.TabIndex = 44;
			this.comboBoxReadOnly_24.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_24.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_24.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "EngPTS", true));
			this.comboBoxReadOnly_24.FormattingEnabled = true;
			this.comboBoxReadOnly_24.Location = new Point(228, 432);
			this.comboBoxReadOnly_24.Name = "cbIngenerPTS";
			this.comboBoxReadOnly_24.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_24.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_24.Size = new Size(121, 21);
			this.comboBoxReadOnly_24.TabIndex = 46;
			this.comboBoxReadOnly_25.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_25.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_25.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "NachKS", true));
			this.comboBoxReadOnly_25.FormattingEnabled = true;
			this.comboBoxReadOnly_25.Location = new Point(228, 405);
			this.comboBoxReadOnly_25.Name = "cbChiefCable";
			this.comboBoxReadOnly_25.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_25.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_25.Size = new Size(121, 21);
			this.comboBoxReadOnly_25.TabIndex = 45;
			this.comboBoxReadOnly_26.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_26.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_26.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "NachLab", true));
			this.comboBoxReadOnly_26.FormattingEnabled = true;
			this.comboBoxReadOnly_26.Location = new Point(525, 375);
			this.comboBoxReadOnly_26.Name = "cbChiefLab";
			this.comboBoxReadOnly_26.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_26.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_26.Size = new Size(146, 21);
			this.comboBoxReadOnly_26.TabIndex = 47;
			this.textBox_10.BackColor = Color.White;
			this.textBox_10.DataBindings.Add(new Binding("Text", this.bindingSource_0, "PredlKomiss", true));
			this.textBox_10.Location = new Point(146, 344);
			this.textBox_10.Name = "tbCommissionProposal";
			this.textBox_10.Size = new Size(550, 20);
			this.textBox_10.TabIndex = 43;
			this.label_46.AutoSize = true;
			this.label_46.Location = new Point(10, 347);
			this.label_46.Name = "label42";
			this.label_46.Size = new Size(130, 13);
			this.label_46.TabIndex = 36;
			this.label_46.Text = "Предложение комиссии";
			this.label_38.AutoSize = true;
			this.label_38.Location = new Point(12, 321);
			this.label_38.Name = "label41";
			this.label_38.Size = new Size(100, 13);
			this.label_38.TabIndex = 35;
			this.label_38.Text = "Виновная сторона";
			this.textBox_9.BackColor = Color.White;
			this.textBox_9.Enabled = false;
			this.textBox_9.Location = new Point(118, 318);
			this.textBox_9.Name = "tbResponsibleParty";
			this.textBox_9.Size = new Size(578, 20);
			this.textBox_9.TabIndex = 42;
			this.comboBoxReadOnly_20.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_20.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_20.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "ZPrichinaDop", true));
			this.comboBoxReadOnly_20.Enabled = false;
			this.comboBoxReadOnly_20.FormattingEnabled = true;
			this.comboBoxReadOnly_20.Location = new Point(424, 291);
			this.comboBoxReadOnly_20.Name = "cbViewDamage";
			this.comboBoxReadOnly_20.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_20.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_20.Size = new Size(272, 21);
			this.comboBoxReadOnly_20.TabIndex = 41;
			this.label_39.AutoSize = true;
			this.label_39.Location = new Point(321, 294);
			this.label_39.Name = "label40";
			this.label_39.Size = new Size(97, 13);
			this.label_39.TabIndex = 30;
			this.label_39.Text = "Вид повреждения";
			this.label_40.AutoSize = true;
			this.label_40.Location = new Point(10, 294);
			this.label_40.Name = "label39";
			this.label_40.Size = new Size(121, 13);
			this.label_40.TabIndex = 29;
			this.label_40.Text = "Причина повреждения";
			this.comboBoxReadOnly_21.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_21.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_21.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "ZPrichina", true));
			this.comboBoxReadOnly_21.FormattingEnabled = true;
			this.comboBoxReadOnly_21.Location = new Point(137, 291);
			this.comboBoxReadOnly_21.Name = "cbCauseDamage2";
			this.comboBoxReadOnly_21.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_21.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_21.Size = new Size(167, 21);
			this.comboBoxReadOnly_21.TabIndex = 40;
			this.comboBoxReadOnly_21.SelectedIndexChanged += this.comboBoxReadOnly_21_SelectedIndexChanged;
			this.label_31.AutoSize = true;
			this.label_31.Location = new Point(384, 268);
			this.label_31.Name = "label32";
			this.label_31.Size = new Size(102, 13);
			this.label_31.TabIndex = 27;
			this.label_31.Text = "Прочие замечания";
			this.label_32.AutoSize = true;
			this.label_32.Location = new Point(384, 241);
			this.label_32.Name = "label33";
			this.label_32.Size = new Size(187, 13);
			this.label_32.TabIndex = 26;
			this.label_32.Text = "Состояние изоляции жил, качества";
			this.label_33.AutoSize = true;
			this.label_33.Location = new Point(384, 214);
			this.label_33.Name = "label34";
			this.label_33.Size = new Size(147, 13);
			this.label_33.TabIndex = 25;
			this.label_33.Text = "Состояние соединения жил";
			this.label_34.AutoSize = true;
			this.label_34.Location = new Point(384, 52);
			this.label_34.Name = "label35";
			this.label_34.Size = new Size(91, 13);
			this.label_34.TabIndex = 24;
			this.label_34.Text = "Наличие трещин";
			this.label_35.AutoSize = true;
			this.label_35.Location = new Point(384, 20);
			this.label_35.Name = "label36";
			this.label_35.Size = new Size(160, 13);
			this.label_35.TabIndex = 23;
			this.label_35.Text = "Состояние заливочной массы";
			this.label_36.AutoSize = true;
			this.label_36.Location = new Point(12, 241);
			this.label_36.Name = "label37";
			this.label_36.Size = new Size(122, 13);
			this.label_36.TabIndex = 22;
			this.label_36.Text = "Состояние уплотнений";
			this.label_37.AutoSize = true;
			this.label_37.Location = new Point(10, 214);
			this.label_37.Name = "label38";
			this.label_37.Size = new Size(142, 13);
			this.label_37.TabIndex = 21;
			this.label_37.Text = "Состояние корпуса муфты";
			this.textBox_8.BackColor = Color.White;
			this.textBox_8.DataBindings.Add(new Binding("Text", this.bindingSource_0, "MProchZamech", true));
			this.textBox_8.Location = new Point(492, 265);
			this.textBox_8.Name = "tbClutchOtherNotes";
			this.textBox_8.Size = new Size(204, 20);
			this.textBox_8.TabIndex = 39;
			this.comboBoxReadOnly_15.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_15.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_15.DataBindings.Add(new Binding("Text", this.bindingSource_0, "MIzolGila", true));
			this.comboBoxReadOnly_15.FormattingEnabled = true;
			this.comboBoxReadOnly_15.Items.AddRange(new object[]
			{
				"удовлетворительное",
				"сухая",
				"влажная"
			});
			this.comboBoxReadOnly_15.Location = new Point(577, 238);
			this.comboBoxReadOnly_15.Name = "cbClutchIsolationState";
			this.comboBoxReadOnly_15.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_15.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_15.Size = new Size(119, 21);
			this.comboBoxReadOnly_15.TabIndex = 38;
			this.comboBoxReadOnly_16.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_16.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_16.DataBindings.Add(new Binding("Text", this.bindingSource_0, "MSoedGila", true));
			this.comboBoxReadOnly_16.FormattingEnabled = true;
			this.comboBoxReadOnly_16.Items.AddRange(new object[]
			{
				"удовлетворительное",
				"неудовлетворительное"
			});
			this.comboBoxReadOnly_16.Location = new Point(537, 211);
			this.comboBoxReadOnly_16.Name = "cbInsulationConnectionState";
			this.comboBoxReadOnly_16.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_16.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_16.Size = new Size(159, 21);
			this.comboBoxReadOnly_16.TabIndex = 37;
			this.comboBoxReadOnly_17.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_17.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_17.DataBindings.Add(new Binding("Text", this.bindingSource_0, "MZalivMassa", true));
			this.comboBoxReadOnly_17.FormattingEnabled = true;
			this.comboBoxReadOnly_17.Items.AddRange(new object[]
			{
				"наличие трещин",
				"перерождение массы"
			});
			this.comboBoxReadOnly_17.Location = new Point(550, 17);
			this.comboBoxReadOnly_17.Name = "cbSealingCompound";
			this.comboBoxReadOnly_17.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_17.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_17.Size = new Size(146, 21);
			this.comboBoxReadOnly_17.TabIndex = 35;
			this.comboBoxReadOnly_18.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_18.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_18.DataBindings.Add(new Binding("Text", this.bindingSource_0, "MUplot", true));
			this.comboBoxReadOnly_18.FormattingEnabled = true;
			this.comboBoxReadOnly_18.Items.AddRange(new object[]
			{
				"удовлетворительное",
				"неудовлетворительное"
			});
			this.comboBoxReadOnly_18.Location = new Point(140, 238);
			this.comboBoxReadOnly_18.Name = "cbSealsState";
			this.comboBoxReadOnly_18.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_18.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_18.Size = new Size(238, 21);
			this.comboBoxReadOnly_18.TabIndex = 34;
			this.comboBoxReadOnly_19.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_19.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_19.DataBindings.Add(new Binding("Text", this.bindingSource_0, "MKorpus", true));
			this.comboBoxReadOnly_19.FormattingEnabled = true;
			this.comboBoxReadOnly_19.Location = new Point(158, 211);
			this.comboBoxReadOnly_19.Name = "cbClutchHousing";
			this.comboBoxReadOnly_19.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_19.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_19.Size = new Size(220, 21);
			this.comboBoxReadOnly_19.TabIndex = 33;
			this.label_24.AutoSize = true;
			this.label_24.Location = new Point(10, 187);
			this.label_24.Name = "label31";
			this.label_24.Size = new Size(102, 13);
			this.label_24.TabIndex = 13;
			this.label_24.Text = "Прочие замечания";
			this.label_25.AutoSize = true;
			this.label_25.Location = new Point(10, 160);
			this.label_25.Name = "label30";
			this.label_25.Size = new Size(216, 13);
			this.label_25.TabIndex = 12;
			this.label_25.Text = "Количество лент изоляции жил, толщина";
			this.label_26.AutoSize = true;
			this.label_26.Location = new Point(10, 133);
			this.label_26.Name = "label29";
			this.label_26.Size = new Size(135, 13);
			this.label_26.TabIndex = 11;
			this.label_26.Text = "Состояние изоляции жил";
			this.label_27.AutoSize = true;
			this.label_27.Location = new Point(10, 106);
			this.label_27.Name = "label28";
			this.label_27.Size = new Size(238, 13);
			this.label_27.TabIndex = 10;
			this.label_27.Text = "Количество лент поясной изоляции, толщина";
			this.label_28.AutoSize = true;
			this.label_28.Location = new Point(10, 79);
			this.label_28.Name = "label27";
			this.label_28.Size = new Size(157, 13);
			this.label_28.TabIndex = 9;
			this.label_28.Text = "Состояние поясной изоляции";
			this.label_29.AutoSize = true;
			this.label_29.Location = new Point(10, 52);
			this.label_29.Name = "label26";
			this.label_29.Size = new Size(206, 13);
			this.label_29.TabIndex = 8;
			this.label_29.Text = "Состояние оболдочки кабеля, толщина";
			this.label_30.AutoSize = true;
			this.label_30.Location = new Point(10, 20);
			this.label_30.Name = "label25";
			this.label_30.Size = new Size(167, 13);
			this.label_30.TabIndex = 7;
			this.label_30.Text = "Состояние защитных покрытий";
			this.textBox_7.BackColor = Color.White;
			this.textBox_7.DataBindings.Add(new Binding("Text", this.bindingSource_0, "KProchZamech", true));
			this.textBox_7.Location = new Point(118, 184);
			this.textBox_7.Name = "tbCableOtherNotes";
			this.textBox_7.Size = new Size(260, 20);
			this.textBox_7.TabIndex = 32;
			this.comboBoxReadOnly_9.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_9.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_9.DataBindings.Add(new Binding("Text", this.bindingSource_0, "KKolLentGila", true));
			this.comboBoxReadOnly_9.FormattingEnabled = true;
			this.comboBoxReadOnly_9.Items.AddRange(new object[]
			{
				"0,85",
				"2,1",
				"2,75",
				"ПХВ"
			});
			this.comboBoxReadOnly_9.Location = new Point(253, 157);
			this.comboBoxReadOnly_9.Name = "cbQualityTapes";
			this.comboBoxReadOnly_9.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_9.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_9.Size = new Size(125, 21);
			this.comboBoxReadOnly_9.TabIndex = 31;
			this.comboBoxReadOnly_10.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_10.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_10.DataBindings.Add(new Binding("Text", this.bindingSource_0, "KGila", true));
			this.comboBoxReadOnly_10.FormattingEnabled = true;
			this.comboBoxReadOnly_10.Items.AddRange(new object[]
			{
				"сухая",
				"влажная",
				"удовлетворительное"
			});
			this.comboBoxReadOnly_10.Location = new Point(151, 130);
			this.comboBoxReadOnly_10.Name = "cbIsolationState";
			this.comboBoxReadOnly_10.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_10.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_10.Size = new Size(227, 21);
			this.comboBoxReadOnly_10.TabIndex = 30;
			this.comboBoxReadOnly_11.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_11.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_11.DataBindings.Add(new Binding("Text", this.bindingSource_0, "KKolLentPoyas", true));
			this.comboBoxReadOnly_11.FormattingEnabled = true;
			this.comboBoxReadOnly_11.Items.AddRange(new object[]
			{
				"0,55",
				"1,1",
				"1,25",
				"ПХВ"
			});
			this.comboBoxReadOnly_11.Location = new Point(253, 103);
			this.comboBoxReadOnly_11.Name = "cbQualityInsulationState";
			this.comboBoxReadOnly_11.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_11.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_11.Size = new Size(125, 21);
			this.comboBoxReadOnly_11.TabIndex = 29;
			this.comboBoxReadOnly_12.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_12.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_12.DataBindings.Add(new Binding("Text", this.bindingSource_0, "KPoyasIzol", true));
			this.comboBoxReadOnly_12.FormattingEnabled = true;
			this.comboBoxReadOnly_12.Items.AddRange(new object[]
			{
				"сухая",
				"влажная",
				"удовлетворительное"
			});
			this.comboBoxReadOnly_12.Location = new Point(173, 76);
			this.comboBoxReadOnly_12.Name = "cbCableWrappingState";
			this.comboBoxReadOnly_12.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_12.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_12.Size = new Size(205, 21);
			this.comboBoxReadOnly_12.TabIndex = 28;
			this.comboBoxReadOnly_13.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_13.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_13.DataBindings.Add(new Binding("Text", this.bindingSource_0, "KObolochka", true));
			this.comboBoxReadOnly_13.FormattingEnabled = true;
			this.comboBoxReadOnly_13.Items.AddRange(new object[]
			{
				"коррозия",
				"удовлетворительное"
			});
			this.comboBoxReadOnly_13.Location = new Point(222, 49);
			this.comboBoxReadOnly_13.Name = "cbCableSheathState";
			this.comboBoxReadOnly_13.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_13.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_13.Size = new Size(156, 21);
			this.comboBoxReadOnly_13.TabIndex = 27;
			this.comboBoxReadOnly_14.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBoxReadOnly_14.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBoxReadOnly_14.DataBindings.Add(new Binding("Text", this.bindingSource_0, "KZashPokr", true));
			this.comboBoxReadOnly_14.FormattingEnabled = true;
			this.comboBoxReadOnly_14.Items.AddRange(new object[]
			{
				"разрушен",
				"сгнил",
				"удовлетворительное"
			});
			this.comboBoxReadOnly_14.Location = new Point(183, 17);
			this.comboBoxReadOnly_14.Name = "cbCableSheetingState";
			this.comboBoxReadOnly_14.ReadOnlyBackColor = Color.White;
			this.comboBoxReadOnly_14.ReadOnlyForeColor = SystemColors.WindowText;
			this.comboBoxReadOnly_14.Size = new Size(195, 21);
			this.comboBoxReadOnly_14.TabIndex = 26;
			this.button_0.DialogResult = DialogResult.Cancel;
			this.button_0.Dock = DockStyle.Left;
			this.button_0.Location = new Point(622, 497);
			this.button_0.Margin = new Padding(10, 5, 3, 5);
			this.button_0.Name = "btnClose";
			this.button_0.Size = new Size(75, 24);
			this.button_0.TabIndex = 50;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Click += this.button_0_Click;
			this.button_1.DialogResult = DialogResult.OK;
			this.button_1.Dock = DockStyle.Right;
			this.button_1.Location = new Point(502, 497);
			this.button_1.Margin = new Padding(3, 5, 10, 5);
			this.button_1.Name = "btnSave";
			this.button_1.Size = new Size(100, 24);
			this.button_1.TabIndex = 49;
			this.button_1.Text = "Применить";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.bindingSource_1.DataMember = "tP_CabSection";
			this.bindingSource_1.DataSource = this.dsDocuments_0;
			base.AcceptButton = this.button_1;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_0;
			base.ClientSize = new Size(722, 526);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormSurveyProtocolCable";
			this.Text = "FormSurveyProtocolCable";
			base.FormClosing += this.FormSurveyProtocolCable_FormClosing;
			base.Load += this.FormSurveyProtocolCable_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tableLayoutPanel_0.PerformLayout();
			((ISupportInitialize)this.bindingNavigator_0).EndInit();
			this.bindingNavigator_0.ResumeLayout(false);
			this.bindingNavigator_0.PerformLayout();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dsDocuments_0).EndInit();
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tabPage_0.PerformLayout();
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			this.tabPage_1.ResumeLayout(false);
			this.tabPage_1.PerformLayout();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			base.ResumeLayout(false);
		}

		private int int_0;

		private int int_1;

		private int int_2;

		private StateFormCreate stateFormCreate_0;

		private string string_0;

		private IContainer icontainer_0;

		private TableLayoutPanel tableLayoutPanel_0;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private Label label_0;

		private Label label_1;

		private Label label_2;

		private Label label_3;

		private ComboBoxReadOnly comboBoxReadOnly_0;

		private ComboBoxReadOnly comboBoxReadOnly_1;

		private ComboBoxReadOnly comboBoxReadOnly_2;

		private Label label_4;

		private ComboBoxReadOnly comboBoxReadOnly_3;

		private ComboBoxReadOnly comboBoxReadOnly_4;

		private Label label_5;

		private Label label_6;

		private TextBox textBox_0;

		private ComboBoxReadOnly comboBoxReadOnly_5;

		private Label label_7;

		private Label label_8;

		private NullableDateTimePicker nullableDateTimePicker_0;

		private Label label_9;

		private Label label_10;

		private Label label_11;

		private Label label_12;

		private Label label_13;

		private Label label_14;

		private Label label_15;

		private GroupBox groupBox_0;

		private Label label_16;

		private Label label_17;

		private Label label_18;

		private Label label_19;

		private TextBox textBox_1;

		private NullableDateTimePicker nullableDateTimePicker_1;

		private TextBox textBox_2;

		private GroupBox groupBox_1;

		private Label label_20;

		private Label label_21;

		private Label label_22;

		private Label label_23;

		private NullableDateTimePicker nullableDateTimePicker_2;

		private TextBox textBox_3;

		private TextBox textBox_4;

		private TextBox textBox_5;

		private ComboBoxReadOnly comboBoxReadOnly_6;

		private NullableDateTimePicker nullableDateTimePicker_3;

		private NullableDateTimePicker nullableDateTimePicker_4;

		private ComboBoxReadOnly comboBoxReadOnly_7;

		private ComboBoxReadOnly comboBoxReadOnly_8;

		private TextBox textBox_6;

		private TabPage tabPage_1;

		private Label label_24;

		private Label label_25;

		private Label label_26;

		private Label label_27;

		private Label label_28;

		private Label label_29;

		private Label label_30;

		private TextBox textBox_7;

		private ComboBoxReadOnly comboBoxReadOnly_9;

		private ComboBoxReadOnly comboBoxReadOnly_10;

		private ComboBoxReadOnly comboBoxReadOnly_11;

		private ComboBoxReadOnly comboBoxReadOnly_12;

		private ComboBoxReadOnly comboBoxReadOnly_13;

		private ComboBoxReadOnly comboBoxReadOnly_14;

		private Label label_31;

		private Label label_32;

		private Label label_33;

		private Label label_34;

		private Label label_35;

		private Label label_36;

		private Label label_37;

		private TextBox textBox_8;

		private ComboBoxReadOnly comboBoxReadOnly_15;

		private ComboBoxReadOnly comboBoxReadOnly_16;

		private ComboBoxReadOnly comboBoxReadOnly_17;

		private ComboBoxReadOnly comboBoxReadOnly_18;

		private ComboBoxReadOnly comboBoxReadOnly_19;

		private Label label_38;

		private TextBox textBox_9;

		private ComboBoxReadOnly comboBoxReadOnly_20;

		private Label label_39;

		private Label label_40;

		private ComboBoxReadOnly comboBoxReadOnly_21;

		private Label label_41;

		private Label label_42;

		private Label label_43;

		private Label label_44;

		private Label label_45;

		private ComboBoxReadOnly comboBoxReadOnly_22;

		private ComboBoxReadOnly comboBoxReadOnly_23;

		private ComboBoxReadOnly comboBoxReadOnly_24;

		private ComboBoxReadOnly comboBoxReadOnly_25;

		private ComboBoxReadOnly comboBoxReadOnly_26;

		private TextBox textBox_10;

		private Label label_46;

		private Button button_0;

		private Button button_1;

		private BindingSource bindingSource_0;

		private dsDocuments dsDocuments_0;

		private TextBox textBox_11;

		private ComboBoxReadOnly comboBoxReadOnly_27;

		private BindingSource bindingSource_1;

		private ComboBoxReadOnly comboBoxReadOnly_28;

		private ComboBoxReadOnly comboBoxReadOnly_29;

		private BindingNavigator bindingNavigator_0;

		private ToolStripLabel toolStripLabel_0;

		private ToolStripButton toolStripButton_0;

		private ToolStripButton toolStripButton_1;

		private ToolStripSeparator toolStripSeparator_0;

		private ToolStripTextBox toolStripTextBox_0;

		private ToolStripSeparator toolStripSeparator_1;

		private ToolStripButton toolStripButton_2;

		private ToolStripButton toolStripButton_3;

		private ToolStripSeparator toolStripSeparator_2;

		private ToolStripButton toolStripButton_4;

		private ToolStripButton toolStripButton_5;

		private Label label_47;

		private Label label_48;

		private Label label_49;

		private Label label_50;

		private Label label_51;

		private TextBox textBox_12;

		private TextBox textBox_13;

		private TextBox textBox_14;

		private TextBox textBox_15;

		private TextBox textBox_16;

		private TextBox textBox_17;

		private Label label_52;
	}
}
