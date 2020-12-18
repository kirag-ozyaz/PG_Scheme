using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using SchemeCtrl2.Data;

namespace SchemeCtrl2.Canvas.Forms
{
	public partial class FormJRelayProtectionAutomationEditBySchmObj : FormBase
	{
		private void method_0()
		{
			this.icontainer_0 = new Container();
			this.dataSetScheme_0 = new DataSetScheme();
			this.label_0 = new Label();
			this.dateTimePicker_0 = new DateTimePicker();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.label_1 = new Label();
			this.comboBox_0 = new ComboBox();
			this.label_2 = new Label();
			this.comboBox_1 = new ComboBox();
			this.label_3 = new Label();
			this.comboBox_2 = new ComboBox();
			this.label_4 = new Label();
			this.comboBox_3 = new ComboBox();
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.button_0 = new Button();
			this.button_1 = new Button();
			this.textBox_0 = new TextBox();
			this.groupBox_0 = new GroupBox();
			this.comboBox_4 = new ComboBox();
			this.label_5 = new Label();
			this.textBox_1 = new TextBox();
			this.textBox_2 = new TextBox();
			this.label_6 = new Label();
			this.label_7 = new Label();
			this.groupBox_1 = new GroupBox();
			this.textBox_3 = new TextBox();
			this.label_9 = new Label();
			this.textBox_4 = new TextBox();
			this.label_10 = new Label();
			this.textBox_5 = new TextBox();
			this.label_8 = new Label();
			this.groupBox_2 = new GroupBox();
			this.textBox_6 = new TextBox();
			this.label_11 = new Label();
			this.textBox_7 = new TextBox();
			this.label_12 = new Label();
			this.groupBox_3 = new GroupBox();
			this.textBox_8 = new TextBox();
			this.label_13 = new Label();
			this.textBox_9 = new TextBox();
			this.label_14 = new Label();
			this.groupBox_4 = new GroupBox();
			this.textBox_10 = new TextBox();
			this.label_15 = new Label();
			this.textBox_11 = new TextBox();
			this.label_16 = new Label();
			this.groupBox_5 = new GroupBox();
			this.comboBox_5 = new ComboBox();
			this.comboBox_6 = new ComboBox();
			this.groupBox_6 = new GroupBox();
			this.textBox_12 = new TextBox();
			this.label_17 = new Label();
			this.textBox_13 = new TextBox();
			this.label_18 = new Label();
			this.label_19 = new Label();
			this.richTextBox_0 = new RichTextBox();
			this.groupBox_7 = new GroupBox();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.panel_0 = new Panel();
			this.label_20 = new Label();
			this.dataGridViewExcelFilter_0 = new DataGridViewExcelFilter();
			this.bindingSource_2 = new BindingSource(this.icontainer_0);
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_19 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_20 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_21 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_22 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_23 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_24 = new DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_25 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_26 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_27 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_28 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_29 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_30 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_31 = new DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
			((ISupportInitialize)this.dataSetScheme_0).BeginInit();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			this.groupBox_0.SuspendLayout();
			this.groupBox_1.SuspendLayout();
			this.groupBox_2.SuspendLayout();
			this.groupBox_3.SuspendLayout();
			this.groupBox_4.SuspendLayout();
			this.groupBox_5.SuspendLayout();
			this.groupBox_6.SuspendLayout();
			this.groupBox_7.SuspendLayout();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.panel_0.SuspendLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_0).BeginInit();
			((ISupportInitialize)this.bindingSource_2).BeginInit();
			base.SuspendLayout();
			this.dataSetScheme_0.DataSetName = "DataSetGES";
			this.dataSetScheme_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.label_0.AutoSize = true;
			this.label_0.Location = new Point(237, 6);
			this.label_0.Name = "label1";
			this.label_0.Size = new Size(33, 13);
			this.label_0.TabIndex = 0;
			this.label_0.Text = "Дата";
			this.dateTimePicker_0.DataBindings.Add(new Binding("Value", this.bindingSource_1, "dateIn", true));
			this.dateTimePicker_0.Enabled = false;
			this.dateTimePicker_0.Location = new Point(276, 3);
			this.dateTimePicker_0.Name = "dateTimePickerIn";
			this.dateTimePicker_0.Size = new Size(145, 20);
			this.dateTimePicker_0.TabIndex = 1;
			this.bindingSource_1.DataMember = "tJ_RelayProtectionAutomationValue";
			this.bindingSource_1.DataSource = this.dataSetScheme_0;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(6, 21);
			this.label_1.Name = "label2";
			this.label_1.Size = new Size(88, 13);
			this.label_1.TabIndex = 2;
			this.label_1.Text = "Тип подстанции";
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(100, 18);
			this.comboBox_0.Name = "cmbTypeSub";
			this.comboBox_0.Size = new Size(83, 21);
			this.comboBox_0.TabIndex = 3;
			this.comboBox_0.SelectedIndexChanged += this.comboBox_0_SelectedIndexChanged;
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(189, 21);
			this.label_2.Name = "label3";
			this.label_2.Size = new Size(68, 13);
			this.label_2.TabIndex = 4;
			this.label_2.Text = "Подстанция";
			this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(263, 18);
			this.comboBox_1.Name = "cmbSub";
			this.comboBox_1.Size = new Size(87, 21);
			this.comboBox_1.TabIndex = 5;
			this.comboBox_1.SelectedIndexChanged += this.comboBox_1_SelectedIndexChanged;
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(356, 21);
			this.label_3.Name = "label4";
			this.label_3.Size = new Size(34, 13);
			this.label_3.TabIndex = 6;
			this.label_3.Text = "Шина";
			this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(396, 18);
			this.comboBox_2.Name = "cmbBus";
			this.comboBox_2.Size = new Size(48, 21);
			this.comboBox_2.TabIndex = 7;
			this.comboBox_2.SelectedIndexChanged += this.comboBox_2_SelectedIndexChanged;
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(450, 21);
			this.label_4.Name = "label5";
			this.label_4.Size = new Size(44, 13);
			this.label_4.TabIndex = 8;
			this.label_4.Text = "Ячейка";
			this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_3.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_0, "idSchmObj", true));
			this.comboBox_3.FormattingEnabled = true;
			this.comboBox_3.Location = new Point(500, 18);
			this.comboBox_3.Name = "cmbCell";
			this.comboBox_3.Size = new Size(53, 21);
			this.comboBox_3.TabIndex = 9;
			this.bindingSource_0.DataMember = "tJ_RelayProtectionAutomation";
			this.bindingSource_0.DataSource = this.dataSetScheme_0;
			this.button_0.DialogResult = DialogResult.OK;
			this.button_0.Location = new Point(13, 223);
			this.button_0.Name = "buttonOK";
			this.button_0.Size = new Size(75, 23);
			this.button_0.TabIndex = 10;
			this.button_0.Text = "ОК";
			this.button_0.UseVisualStyleBackColor = true;
			this.button_0.Visible = false;
			this.button_0.Click += this.button_0_Click;
			this.button_1.DialogResult = DialogResult.Cancel;
			this.button_1.Location = new Point(227, 223);
			this.button_1.Name = "buttonCancel";
			this.button_1.Size = new Size(75, 23);
			this.button_1.TabIndex = 11;
			this.button_1.Text = "Закрыть";
			this.button_1.UseVisualStyleBackColor = true;
			this.button_1.Click += this.button_1_Click;
			this.textBox_0.BackColor = SystemColors.Window;
			this.textBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_0, "name", true));
			this.textBox_0.Location = new Point(81, 3);
			this.textBox_0.Name = "txtNote";
			this.textBox_0.ReadOnly = true;
			this.textBox_0.Size = new Size(147, 20);
			this.textBox_0.TabIndex = 12;
			this.textBox_0.TextChanged += this.textBox_0_TextChanged;
			this.groupBox_0.Controls.Add(this.comboBox_4);
			this.groupBox_0.Controls.Add(this.label_5);
			this.groupBox_0.Controls.Add(this.textBox_1);
			this.groupBox_0.Controls.Add(this.textBox_2);
			this.groupBox_0.Controls.Add(this.label_6);
			this.groupBox_0.Controls.Add(this.label_7);
			this.groupBox_0.Location = new Point(6, 29);
			this.groupBox_0.Name = "groupBoxTransformator";
			this.groupBox_0.Size = new Size(415, 55);
			this.groupBox_0.TabIndex = 13;
			this.groupBox_0.TabStop = false;
			this.groupBox_0.Text = "Трансформатор";
			this.comboBox_4.DataBindings.Add(new Binding("SelectedValue", this.bindingSource_1, "idTypeTr", true));
			this.comboBox_4.Enabled = false;
			this.comboBox_4.FormattingEnabled = true;
			this.comboBox_4.Location = new Point(228, 24);
			this.comboBox_4.Name = "cmbTypeTr";
			this.comboBox_4.Size = new Size(178, 21);
			this.comboBox_4.TabIndex = 5;
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(196, 27);
			this.label_5.Name = "label8";
			this.label_5.Size = new Size(26, 13);
			this.label_5.TabIndex = 4;
			this.label_5.Text = "Тип";
			this.textBox_1.BackColor = SystemColors.Window;
			this.textBox_1.DataBindings.Add(new Binding("Text", this.bindingSource_1, "amp_secondary", true));
			this.textBox_1.Location = new Point(128, 24);
			this.textBox_1.Name = "txtT2";
			this.textBox_1.ReadOnly = true;
			this.textBox_1.Size = new Size(62, 20);
			this.textBox_1.TabIndex = 3;
			this.textBox_2.BackColor = SystemColors.Window;
			this.textBox_2.DataBindings.Add(new Binding("Text", this.bindingSource_1, "amp_primary", true));
			this.textBox_2.Location = new Point(34, 24);
			this.textBox_2.Name = "txtT1";
			this.textBox_2.ReadOnly = true;
			this.textBox_2.Size = new Size(62, 20);
			this.textBox_2.TabIndex = 2;
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(102, 27);
			this.label_6.Name = "label7";
			this.label_6.Size = new Size(20, 13);
			this.label_6.TabIndex = 1;
			this.label_6.Text = "Т2";
			this.label_7.AutoSize = true;
			this.label_7.Location = new Point(8, 27);
			this.label_7.Name = "label6";
			this.label_7.Size = new Size(20, 13);
			this.label_7.TabIndex = 0;
			this.label_7.Text = "Т1";
			this.groupBox_1.Controls.Add(this.textBox_3);
			this.groupBox_1.Controls.Add(this.label_9);
			this.groupBox_1.Controls.Add(this.textBox_4);
			this.groupBox_1.Controls.Add(this.label_10);
			this.groupBox_1.Controls.Add(this.textBox_5);
			this.groupBox_1.Controls.Add(this.label_8);
			this.groupBox_1.Location = new Point(6, 90);
			this.groupBox_1.Name = "groupBoxMTZ";
			this.groupBox_1.Size = new Size(415, 58);
			this.groupBox_1.TabIndex = 14;
			this.groupBox_1.TabStop = false;
			this.groupBox_1.Text = "МТЗ";
			this.textBox_3.BackColor = SystemColors.Window;
			this.textBox_3.DataBindings.Add(new Binding("Text", this.bindingSource_1, "speed_mtz", true));
			this.textBox_3.Location = new Point(297, 22);
			this.textBox_3.Name = "txtSpeedMTZ";
			this.textBox_3.ReadOnly = true;
			this.textBox_3.Size = new Size(109, 20);
			this.textBox_3.TabIndex = 5;
			this.label_9.AutoSize = true;
			this.label_9.Location = new Point(228, 25);
			this.label_9.Name = "label11";
			this.label_9.Size = new Size(63, 13);
			this.label_9.TabIndex = 4;
			this.label_9.Text = "Ускорение";
			this.textBox_4.BackColor = SystemColors.Window;
			this.textBox_4.DataBindings.Add(new Binding("Text", this.bindingSource_1, "time_mtz", true));
			this.textBox_4.Location = new Point(148, 22);
			this.textBox_4.Name = "txtTimeMTZ";
			this.textBox_4.ReadOnly = true;
			this.textBox_4.Size = new Size(74, 20);
			this.textBox_4.TabIndex = 3;
			this.label_10.AutoSize = true;
			this.label_10.Location = new Point(102, 25);
			this.label_10.Name = "label10";
			this.label_10.Size = new Size(40, 13);
			this.label_10.TabIndex = 2;
			this.label_10.Text = "Время";
			this.textBox_5.BackColor = SystemColors.Window;
			this.textBox_5.DataBindings.Add(new Binding("Text", this.bindingSource_1, "amp_mtz", true));
			this.textBox_5.Location = new Point(34, 22);
			this.textBox_5.Name = "txtAmpMTZ";
			this.textBox_5.ReadOnly = true;
			this.textBox_5.Size = new Size(62, 20);
			this.textBox_5.TabIndex = 1;
			this.label_8.AutoSize = true;
			this.label_8.Location = new Point(6, 25);
			this.label_8.Name = "label9";
			this.label_8.Size = new Size(26, 13);
			this.label_8.TabIndex = 0;
			this.label_8.Text = "Ток";
			this.groupBox_2.Controls.Add(this.textBox_6);
			this.groupBox_2.Controls.Add(this.label_11);
			this.groupBox_2.Controls.Add(this.textBox_7);
			this.groupBox_2.Controls.Add(this.label_12);
			this.groupBox_2.Location = new Point(221, 151);
			this.groupBox_2.Name = "groupBoxOZZ";
			this.groupBox_2.Size = new Size(200, 58);
			this.groupBox_2.TabIndex = 15;
			this.groupBox_2.TabStop = false;
			this.groupBox_2.Text = "ОЗЗ";
			this.textBox_6.BackColor = SystemColors.Window;
			this.textBox_6.DataBindings.Add(new Binding("Text", this.bindingSource_1, "time_ozz", true));
			this.textBox_6.Location = new Point(138, 22);
			this.textBox_6.Name = "txtTimeOZZ";
			this.textBox_6.ReadOnly = true;
			this.textBox_6.Size = new Size(54, 20);
			this.textBox_6.TabIndex = 3;
			this.label_11.AutoSize = true;
			this.label_11.Location = new Point(92, 25);
			this.label_11.Name = "label13";
			this.label_11.Size = new Size(40, 13);
			this.label_11.TabIndex = 2;
			this.label_11.Text = "Время";
			this.textBox_7.BackColor = SystemColors.Window;
			this.textBox_7.DataBindings.Add(new Binding("Text", this.bindingSource_1, "amp_ozz", true));
			this.textBox_7.Location = new Point(34, 22);
			this.textBox_7.Name = "txtAmpOzz";
			this.textBox_7.ReadOnly = true;
			this.textBox_7.Size = new Size(52, 20);
			this.textBox_7.TabIndex = 1;
			this.label_12.AutoSize = true;
			this.label_12.Location = new Point(6, 25);
			this.label_12.Name = "label14";
			this.label_12.Size = new Size(26, 13);
			this.label_12.TabIndex = 0;
			this.label_12.Text = "Ток";
			this.groupBox_3.Controls.Add(this.textBox_8);
			this.groupBox_3.Controls.Add(this.label_13);
			this.groupBox_3.Controls.Add(this.textBox_9);
			this.groupBox_3.Controls.Add(this.label_14);
			this.groupBox_3.Location = new Point(6, 151);
			this.groupBox_3.Name = "groupBoxTO";
			this.groupBox_3.Size = new Size(209, 58);
			this.groupBox_3.TabIndex = 16;
			this.groupBox_3.TabStop = false;
			this.groupBox_3.Text = "ТО";
			this.textBox_8.BackColor = SystemColors.Window;
			this.textBox_8.DataBindings.Add(new Binding("Text", this.bindingSource_1, "time_to", true));
			this.textBox_8.Location = new Point(148, 22);
			this.textBox_8.Name = "txtTimeTO";
			this.textBox_8.ReadOnly = true;
			this.textBox_8.Size = new Size(57, 20);
			this.textBox_8.TabIndex = 3;
			this.label_13.AutoSize = true;
			this.label_13.Location = new Point(102, 29);
			this.label_13.Name = "label12";
			this.label_13.Size = new Size(40, 13);
			this.label_13.TabIndex = 2;
			this.label_13.Text = "Время";
			this.textBox_9.BackColor = SystemColors.Window;
			this.textBox_9.DataBindings.Add(new Binding("Text", this.bindingSource_1, "amp_to", true));
			this.textBox_9.Location = new Point(34, 22);
			this.textBox_9.Name = "txtAmpTO";
			this.textBox_9.ReadOnly = true;
			this.textBox_9.Size = new Size(62, 20);
			this.textBox_9.TabIndex = 1;
			this.label_14.AutoSize = true;
			this.label_14.Location = new Point(6, 25);
			this.label_14.Name = "label15";
			this.label_14.Size = new Size(26, 13);
			this.label_14.TabIndex = 0;
			this.label_14.Text = "Ток";
			this.groupBox_4.Controls.Add(this.textBox_10);
			this.groupBox_4.Controls.Add(this.label_15);
			this.groupBox_4.Controls.Add(this.textBox_11);
			this.groupBox_4.Controls.Add(this.label_16);
			this.groupBox_4.Location = new Point(6, 215);
			this.groupBox_4.Name = "groupBoxUROV";
			this.groupBox_4.Size = new Size(209, 58);
			this.groupBox_4.TabIndex = 18;
			this.groupBox_4.TabStop = false;
			this.groupBox_4.Text = "УРОВ";
			this.textBox_10.BackColor = SystemColors.Window;
			this.textBox_10.DataBindings.Add(new Binding("Text", this.bindingSource_1, "time_urov", true));
			this.textBox_10.Location = new Point(148, 22);
			this.textBox_10.Name = "txtTimeUrov";
			this.textBox_10.ReadOnly = true;
			this.textBox_10.Size = new Size(57, 20);
			this.textBox_10.TabIndex = 3;
			this.label_15.AutoSize = true;
			this.label_15.Location = new Point(102, 25);
			this.label_15.Name = "label18";
			this.label_15.Size = new Size(40, 13);
			this.label_15.TabIndex = 2;
			this.label_15.Text = "Время";
			this.textBox_11.BackColor = SystemColors.Window;
			this.textBox_11.DataBindings.Add(new Binding("Text", this.bindingSource_1, "amp_urov", true));
			this.textBox_11.Location = new Point(34, 22);
			this.textBox_11.Name = "txtAmpUrov";
			this.textBox_11.ReadOnly = true;
			this.textBox_11.Size = new Size(62, 20);
			this.textBox_11.TabIndex = 1;
			this.label_16.AutoSize = true;
			this.label_16.Location = new Point(6, 25);
			this.label_16.Name = "label19";
			this.label_16.Size = new Size(26, 13);
			this.label_16.TabIndex = 0;
			this.label_16.Text = "Ток";
			this.groupBox_5.Controls.Add(this.comboBox_5);
			this.groupBox_5.Controls.Add(this.comboBox_6);
			this.groupBox_5.Location = new Point(6, 279);
			this.groupBox_5.Name = "groupBox3";
			this.groupBox_5.Size = new Size(415, 54);
			this.groupBox_5.TabIndex = 19;
			this.groupBox_5.TabStop = false;
			this.groupBox_5.Text = "Тип реле и микропроц. устр-ва";
			this.comboBox_5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_5.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_5.DataBindings.Add(new Binding("SelectedItem", this.bindingSource_1, "type_proc", true));
			this.comboBox_5.DataBindings.Add(new Binding("Text", this.bindingSource_1, "type_proc", true));
			this.comboBox_5.Enabled = false;
			this.comboBox_5.FormattingEnabled = true;
			this.comboBox_5.Location = new Point(249, 19);
			this.comboBox_5.Name = "cmbMicroProc";
			this.comboBox_5.Size = new Size(157, 21);
			this.comboBox_5.Sorted = true;
			this.comboBox_5.TabIndex = 1;
			this.comboBox_5.TextUpdate += this.comboBox_5_TextUpdate;
			this.comboBox_6.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_6.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_6.DataBindings.Add(new Binding("SelectedItem", this.bindingSource_1, "type_relay", true));
			this.comboBox_6.DataBindings.Add(new Binding("Text", this.bindingSource_1, "type_relay", true));
			this.comboBox_6.Enabled = false;
			this.comboBox_6.FormattingEnabled = true;
			this.comboBox_6.Location = new Point(8, 19);
			this.comboBox_6.Name = "cmbRele";
			this.comboBox_6.Size = new Size(157, 21);
			this.comboBox_6.Sorted = true;
			this.comboBox_6.TabIndex = 0;
			this.comboBox_6.TextUpdate += this.comboBox_6_TextUpdate;
			this.groupBox_6.Controls.Add(this.textBox_12);
			this.groupBox_6.Controls.Add(this.label_17);
			this.groupBox_6.Controls.Add(this.textBox_13);
			this.groupBox_6.Controls.Add(this.label_18);
			this.groupBox_6.Location = new Point(6, 339);
			this.groupBox_6.Name = "groupBox4";
			this.groupBox_6.Size = new Size(415, 50);
			this.groupBox_6.TabIndex = 20;
			this.groupBox_6.TabStop = false;
			this.groupBox_6.Text = "Центр питания";
			this.textBox_12.BackColor = SystemColors.Window;
			this.textBox_12.DataBindings.Add(new Binding("Text", this.bindingSource_1, "cp_cell", true));
			this.textBox_12.Enabled = false;
			this.textBox_12.Location = new Point(249, 22);
			this.textBox_12.Name = "txtcp_cell";
			this.textBox_12.ReadOnly = true;
			this.textBox_12.Size = new Size(157, 20);
			this.textBox_12.TabIndex = 3;
			this.label_17.AutoSize = true;
			this.label_17.Location = new Point(196, 25);
			this.label_17.Name = "label21";
			this.label_17.Size = new Size(44, 13);
			this.label_17.TabIndex = 2;
			this.label_17.Text = "Ячейка";
			this.textBox_13.BackColor = SystemColors.Window;
			this.textBox_13.DataBindings.Add(new Binding("Text", this.bindingSource_1, "cp", true));
			this.textBox_13.Location = new Point(39, 22);
			this.textBox_13.Name = "txtcp_name";
			this.textBox_13.ReadOnly = true;
			this.textBox_13.Size = new Size(151, 20);
			this.textBox_13.TabIndex = 1;
			this.label_18.AutoSize = true;
			this.label_18.Location = new Point(8, 25);
			this.label_18.Name = "label20";
			this.label_18.Size = new Size(29, 13);
			this.label_18.TabIndex = 0;
			this.label_18.Text = "Имя";
			this.label_19.AutoSize = true;
			this.label_19.Location = new Point(14, 394);
			this.label_19.Name = "label22";
			this.label_19.Size = new Size(70, 13);
			this.label_19.TabIndex = 21;
			this.label_19.Text = "Примечание";
			this.richTextBox_0.BackColor = SystemColors.Window;
			this.richTextBox_0.DataBindings.Add(new Binding("Text", this.bindingSource_1, "comment", true));
			this.richTextBox_0.Location = new Point(6, 410);
			this.richTextBox_0.Name = "txtComment";
			this.richTextBox_0.ReadOnly = true;
			this.richTextBox_0.Size = new Size(415, 43);
			this.richTextBox_0.TabIndex = 22;
			this.richTextBox_0.Text = "";
			this.richTextBox_0.TextChanged += this.richTextBox_0_TextChanged;
			this.groupBox_7.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.groupBox_7.Controls.Add(this.label_1);
			this.groupBox_7.Controls.Add(this.comboBox_0);
			this.groupBox_7.Controls.Add(this.label_2);
			this.groupBox_7.Controls.Add(this.comboBox_1);
			this.groupBox_7.Controls.Add(this.label_3);
			this.groupBox_7.Controls.Add(this.comboBox_2);
			this.groupBox_7.Controls.Add(this.label_4);
			this.groupBox_7.Controls.Add(this.comboBox_3);
			this.groupBox_7.Enabled = false;
			this.groupBox_7.Location = new Point(4, 0);
			this.groupBox_7.Name = "groupBoxSchmObj";
			this.groupBox_7.Size = new Size(572, 50);
			this.groupBox_7.TabIndex = 23;
			this.groupBox_7.TabStop = false;
			this.groupBox_7.Text = "Объект";
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Location = new Point(582, 56);
			this.tabControl_0.Name = "tabControl";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(438, 493);
			this.tabControl_0.TabIndex = 24;
			this.tabControl_0.Visible = false;
			this.tabControl_0.SelectedIndexChanged += this.tabControl_0_SelectedIndexChanged;
			this.tabPage_0.Controls.Add(this.panel_0);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tabPage";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(430, 467);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "tabPage";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.panel_0.Controls.Add(this.label_20);
			this.panel_0.Controls.Add(this.textBox_0);
			this.panel_0.Controls.Add(this.richTextBox_0);
			this.panel_0.Controls.Add(this.groupBox_0);
			this.panel_0.Controls.Add(this.label_19);
			this.panel_0.Controls.Add(this.groupBox_1);
			this.panel_0.Controls.Add(this.groupBox_6);
			this.panel_0.Controls.Add(this.groupBox_3);
			this.panel_0.Controls.Add(this.dateTimePicker_0);
			this.panel_0.Controls.Add(this.groupBox_5);
			this.panel_0.Controls.Add(this.label_0);
			this.panel_0.Controls.Add(this.groupBox_2);
			this.panel_0.Controls.Add(this.groupBox_4);
			this.panel_0.Dock = DockStyle.Fill;
			this.panel_0.Location = new Point(3, 3);
			this.panel_0.Name = "panel";
			this.panel_0.Size = new Size(424, 461);
			this.panel_0.TabIndex = 0;
			this.label_20.AutoSize = true;
			this.label_20.Location = new Point(3, 6);
			this.label_20.Name = "label16";
			this.label_20.Size = new Size(72, 13);
			this.label_20.TabIndex = 0;
			this.label_20.Text = "Имя уставки";
			this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
			this.dataGridViewExcelFilter_0.AllowUserToResizeRows = false;
			this.dataGridViewExcelFilter_0.AllowUserToVisibleColumns = false;
			this.dataGridViewExcelFilter_0.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
			this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewExcelFilter_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewTextBoxColumn_3,
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11,
				this.dataGridViewTextBoxColumn_12,
				this.dataGridViewTextBoxColumn_13,
				this.dataGridViewTextBoxColumn_14,
				this.dataGridViewTextBoxColumn_15,
				this.dataGridViewTextBoxColumn_16,
				this.dataGridViewTextBoxColumn_17,
				this.dataGridViewTextBoxColumn_18,
				this.dataGridViewTextBoxColumn_19,
				this.dataGridViewTextBoxColumn_20,
				this.dataGridViewTextBoxColumn_21,
				this.dataGridViewTextBoxColumn_22,
				this.dataGridViewTextBoxColumn_23,
				this.dataGridViewTextBoxColumn_24,
				this.dataGridViewCheckBoxColumn_0,
				this.dataGridViewCheckBoxColumn_1,
				this.dataGridViewTextBoxColumn_25,
				this.dataGridViewTextBoxColumn_26,
				this.dataGridViewTextBoxColumn_27,
				this.dataGridViewTextBoxColumn_28,
				this.dataGridViewTextBoxColumn_29,
				this.dataGridViewTextBoxColumn_30,
				this.dataGridViewTextBoxColumn_31,
				this.dataGridViewCheckBoxColumn_2
			});
			this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_2;
			this.dataGridViewExcelFilter_0.Location = new Point(4, 56);
			this.dataGridViewExcelFilter_0.Name = "dgv";
			this.dataGridViewExcelFilter_0.ReadOnly = true;
			this.dataGridViewExcelFilter_0.RowHeadersVisible = false;
			this.dataGridViewExcelFilter_0.Size = new Size(572, 150);
			this.dataGridViewExcelFilter_0.TabIndex = 25;
			this.bindingSource_2.DataMember = "vJ_RelayProtectionAutomation";
			this.bindingSource_2.DataSource = this.dataSetScheme_0;
			this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn_0.HeaderText = "id";
			this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_0.ReadOnly = true;
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewTextBoxColumn_1.DataPropertyName = "relayidValue";
			this.dataGridViewTextBoxColumn_1.HeaderText = "relayidValue";
			this.dataGridViewTextBoxColumn_1.Name = "relayidValueDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_1.ReadOnly = true;
			this.dataGridViewTextBoxColumn_1.Visible = false;
			this.dataGridViewTextBoxColumn_2.DataPropertyName = "subId";
			this.dataGridViewTextBoxColumn_2.HeaderText = "subId";
			this.dataGridViewTextBoxColumn_2.Name = "subIdDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_2.ReadOnly = true;
			this.dataGridViewTextBoxColumn_2.Visible = false;
			this.dataGridViewTextBoxColumn_3.DataPropertyName = "sub_Name";
			this.dataGridViewTextBoxColumn_3.HeaderText = "sub_Name";
			this.dataGridViewTextBoxColumn_3.Name = "subNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_3.ReadOnly = true;
			this.dataGridViewTextBoxColumn_3.Visible = false;
			this.dataGridViewTextBoxColumn_4.DataPropertyName = "typeSub";
			this.dataGridViewTextBoxColumn_4.HeaderText = "typeSub";
			this.dataGridViewTextBoxColumn_4.Name = "typeSubDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_4.ReadOnly = true;
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.DataPropertyName = "busID";
			this.dataGridViewTextBoxColumn_5.HeaderText = "busID";
			this.dataGridViewTextBoxColumn_5.Name = "busIDDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_5.ReadOnly = true;
			this.dataGridViewTextBoxColumn_5.Visible = false;
			this.dataGridViewTextBoxColumn_6.DataPropertyName = "bus_name";
			this.dataGridViewTextBoxColumn_6.HeaderText = "bus_name";
			this.dataGridViewTextBoxColumn_6.Name = "busnameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_6.ReadOnly = true;
			this.dataGridViewTextBoxColumn_6.Visible = false;
			this.dataGridViewTextBoxColumn_7.DataPropertyName = "cell_Name";
			this.dataGridViewTextBoxColumn_7.HeaderText = "cell_Name";
			this.dataGridViewTextBoxColumn_7.Name = "cellNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_7.ReadOnly = true;
			this.dataGridViewTextBoxColumn_7.Visible = false;
			this.dataGridViewTextBoxColumn_8.DataPropertyName = "cellID";
			this.dataGridViewTextBoxColumn_8.HeaderText = "cellID";
			this.dataGridViewTextBoxColumn_8.Name = "cellIDDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_8.ReadOnly = true;
			this.dataGridViewTextBoxColumn_8.Visible = false;
			this.dataGridViewTextBoxColumn_9.DataPropertyName = "relName";
			this.dataGridViewTextBoxColumn_9.HeaderText = "№ прогр";
			this.dataGridViewTextBoxColumn_9.Name = "relNameDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_9.ReadOnly = true;
			this.dataGridViewTextBoxColumn_9.Width = 40;
			this.dataGridViewTextBoxColumn_10.DataPropertyName = "amp_primary";
			this.dataGridViewTextBoxColumn_10.HeaderText = "amp_primary";
			this.dataGridViewTextBoxColumn_10.Name = "ampprimaryDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_10.ReadOnly = true;
			this.dataGridViewTextBoxColumn_10.Visible = false;
			this.dataGridViewTextBoxColumn_11.DataPropertyName = "amp_secondary";
			this.dataGridViewTextBoxColumn_11.HeaderText = "amp_secondary";
			this.dataGridViewTextBoxColumn_11.Name = "ampsecondaryDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_11.ReadOnly = true;
			this.dataGridViewTextBoxColumn_11.Visible = false;
			this.dataGridViewTextBoxColumn_12.DataPropertyName = "idTypeTr";
			this.dataGridViewTextBoxColumn_12.HeaderText = "idTypeTr";
			this.dataGridViewTextBoxColumn_12.Name = "idTypeTrDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_12.ReadOnly = true;
			this.dataGridViewTextBoxColumn_12.Visible = false;
			this.dataGridViewTextBoxColumn_13.DataPropertyName = "Typetr";
			this.dataGridViewTextBoxColumn_13.HeaderText = "Тип тр";
			this.dataGridViewTextBoxColumn_13.Name = "typetrDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_13.ReadOnly = true;
			this.dataGridViewTextBoxColumn_13.Width = 40;
			this.dataGridViewTextBoxColumn_14.DataPropertyName = "CoefTR";
			this.dataGridViewTextBoxColumn_14.HeaderText = "Коэф. Тр.";
			this.dataGridViewTextBoxColumn_14.Name = "CoefTR";
			this.dataGridViewTextBoxColumn_14.ReadOnly = true;
			this.dataGridViewTextBoxColumn_14.Width = 40;
			this.dataGridViewTextBoxColumn_15.DataPropertyName = "amp_mtz";
			this.dataGridViewTextBoxColumn_15.HeaderText = "МТЗ, А";
			this.dataGridViewTextBoxColumn_15.Name = "ampmtzDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_15.ReadOnly = true;
			this.dataGridViewTextBoxColumn_15.Width = 40;
			this.dataGridViewTextBoxColumn_16.DataPropertyName = "time_mtz";
			this.dataGridViewTextBoxColumn_16.HeaderText = "МТЗ, с";
			this.dataGridViewTextBoxColumn_16.Name = "timemtzDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_16.ReadOnly = true;
			this.dataGridViewTextBoxColumn_16.Width = 40;
			this.dataGridViewTextBoxColumn_17.DataPropertyName = "amp_to";
			this.dataGridViewTextBoxColumn_17.HeaderText = "ТО, А";
			this.dataGridViewTextBoxColumn_17.Name = "amptoDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_17.ReadOnly = true;
			this.dataGridViewTextBoxColumn_17.Width = 40;
			this.dataGridViewTextBoxColumn_18.DataPropertyName = "time_to";
			this.dataGridViewTextBoxColumn_18.HeaderText = "ТО, с";
			this.dataGridViewTextBoxColumn_18.Name = "timetoDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_18.ReadOnly = true;
			this.dataGridViewTextBoxColumn_18.Width = 40;
			this.dataGridViewTextBoxColumn_19.DataPropertyName = "amp_ozz";
			this.dataGridViewTextBoxColumn_19.HeaderText = "ОЗЗ, А";
			this.dataGridViewTextBoxColumn_19.Name = "ampozzDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_19.ReadOnly = true;
			this.dataGridViewTextBoxColumn_19.Width = 40;
			this.dataGridViewTextBoxColumn_20.DataPropertyName = "time_ozz";
			this.dataGridViewTextBoxColumn_20.HeaderText = "ОЗЗ, с";
			this.dataGridViewTextBoxColumn_20.Name = "timeozzDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_20.ReadOnly = true;
			this.dataGridViewTextBoxColumn_20.Width = 40;
			this.dataGridViewTextBoxColumn_21.DataPropertyName = "act_ozz";
			this.dataGridViewTextBoxColumn_21.HeaderText = "Действие ОЗЗ";
			this.dataGridViewTextBoxColumn_21.Name = "act_ozzDGVTxtColumn";
			this.dataGridViewTextBoxColumn_21.ReadOnly = true;
			this.dataGridViewTextBoxColumn_21.Width = 35;
			this.dataGridViewTextBoxColumn_22.DataPropertyName = "speed_mtz";
			this.dataGridViewTextBoxColumn_22.HeaderText = "Ускор МТЗ";
			this.dataGridViewTextBoxColumn_22.Name = "speedmtzDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_22.ReadOnly = true;
			this.dataGridViewTextBoxColumn_22.Width = 40;
			this.dataGridViewTextBoxColumn_23.DataPropertyName = "amp_urov";
			this.dataGridViewTextBoxColumn_23.HeaderText = "УРОВ, А";
			this.dataGridViewTextBoxColumn_23.Name = "ampurovDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_23.ReadOnly = true;
			this.dataGridViewTextBoxColumn_23.Width = 40;
			this.dataGridViewTextBoxColumn_24.DataPropertyName = "time_urov";
			this.dataGridViewTextBoxColumn_24.HeaderText = "УРОВ, с";
			this.dataGridViewTextBoxColumn_24.Name = "timeurovDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_24.ReadOnly = true;
			this.dataGridViewTextBoxColumn_24.Width = 40;
			this.dataGridViewCheckBoxColumn_0.DataPropertyName = "avr";
			this.dataGridViewCheckBoxColumn_0.HeaderText = "АВР";
			this.dataGridViewCheckBoxColumn_0.Name = "avrDGVTxtColumn";
			this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_0.Width = 30;
			this.dataGridViewCheckBoxColumn_1.DataPropertyName = "lzsh";
			this.dataGridViewCheckBoxColumn_1.HeaderText = "ЛЗШ";
			this.dataGridViewCheckBoxColumn_1.Name = "lzshDataGridViewCheckBoxColumn";
			this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_1.Width = 40;
			this.dataGridViewTextBoxColumn_25.DataPropertyName = "type_relay";
			this.dataGridViewTextBoxColumn_25.HeaderText = "Тип реле";
			this.dataGridViewTextBoxColumn_25.Name = "typerelayDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_25.ReadOnly = true;
			this.dataGridViewTextBoxColumn_25.Width = 50;
			this.dataGridViewTextBoxColumn_26.DataPropertyName = "type_proc";
			this.dataGridViewTextBoxColumn_26.HeaderText = "Тип микропроц";
			this.dataGridViewTextBoxColumn_26.Name = "typeprocDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_26.ReadOnly = true;
			this.dataGridViewTextBoxColumn_26.Width = 50;
			this.dataGridViewTextBoxColumn_27.DataPropertyName = "cp";
			this.dataGridViewTextBoxColumn_27.HeaderText = "cp";
			this.dataGridViewTextBoxColumn_27.Name = "cpDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_27.ReadOnly = true;
			this.dataGridViewTextBoxColumn_27.Visible = false;
			this.dataGridViewTextBoxColumn_28.DataPropertyName = "cp_cell";
			this.dataGridViewTextBoxColumn_28.HeaderText = "cp_cell";
			this.dataGridViewTextBoxColumn_28.Name = "cpcellDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_28.ReadOnly = true;
			this.dataGridViewTextBoxColumn_28.Visible = false;
			this.dataGridViewTextBoxColumn_29.DataPropertyName = "comment";
			this.dataGridViewTextBoxColumn_29.HeaderText = "comment";
			this.dataGridViewTextBoxColumn_29.Name = "commentDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_29.ReadOnly = true;
			this.dataGridViewTextBoxColumn_29.Visible = false;
			this.dataGridViewTextBoxColumn_30.DataPropertyName = "dateCreate";
			this.dataGridViewTextBoxColumn_30.HeaderText = "dateCreate";
			this.dataGridViewTextBoxColumn_30.Name = "dateCreateDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_30.ReadOnly = true;
			this.dataGridViewTextBoxColumn_30.Visible = false;
			this.dataGridViewTextBoxColumn_31.DataPropertyName = "dateIn";
			this.dataGridViewTextBoxColumn_31.HeaderText = "dateIn";
			this.dataGridViewTextBoxColumn_31.Name = "dateInDataGridViewTextBoxColumn";
			this.dataGridViewTextBoxColumn_31.ReadOnly = true;
			this.dataGridViewTextBoxColumn_31.Visible = false;
			this.dataGridViewCheckBoxColumn_2.DataPropertyName = "deleted";
			this.dataGridViewCheckBoxColumn_2.HeaderText = "deleted";
			this.dataGridViewCheckBoxColumn_2.Name = "deletedDataGridViewCheckBoxColumn";
			this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
			this.dataGridViewCheckBoxColumn_2.Visible = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.CancelButton = this.button_1;
			base.ClientSize = new Size(583, 250);
			base.Controls.Add(this.dataGridViewExcelFilter_0);
			base.Controls.Add(this.tabControl_0);
			base.Controls.Add(this.groupBox_7);
			base.Controls.Add(this.button_1);
			base.Controls.Add(this.button_0);
			this.MaximumSize = new Size(1000, 288);
			this.MinimumSize = new Size(599, 288);
			base.Name = "FormJRelayProtectionAutomationEditBySchmObj";
			this.Text = "Уставки РЗА";
			base.FormClosing += this.FormJRelayProtectionAutomationEditBySchmObj_FormClosing;
			base.Load += this.FormJRelayProtectionAutomationEditBySchmObj_Load;
			((ISupportInitialize)this.dataSetScheme_0).EndInit();
			((ISupportInitialize)this.bindingSource_1).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			this.groupBox_0.ResumeLayout(false);
			this.groupBox_0.PerformLayout();
			this.groupBox_1.ResumeLayout(false);
			this.groupBox_1.PerformLayout();
			this.groupBox_2.ResumeLayout(false);
			this.groupBox_2.PerformLayout();
			this.groupBox_3.ResumeLayout(false);
			this.groupBox_3.PerformLayout();
			this.groupBox_4.ResumeLayout(false);
			this.groupBox_4.PerformLayout();
			this.groupBox_5.ResumeLayout(false);
			this.groupBox_6.ResumeLayout(false);
			this.groupBox_6.PerformLayout();
			this.groupBox_7.ResumeLayout(false);
			this.groupBox_7.PerformLayout();
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			((ISupportInitialize)this.dataGridViewExcelFilter_0).EndInit();
			((ISupportInitialize)this.bindingSource_2).EndInit();
			base.ResumeLayout(false);
		}

		public FormJRelayProtectionAutomationEditBySchmObj()
		{
			this.method_0();
		}

		public FormJRelayProtectionAutomationEditBySchmObj(int type_sub, int subid, int busid, int cellid)
		{
			this.method_0();
			this.method_1(type_sub, subid, busid, cellid);
		}

		private void method_1(int int_6, int int_7, int int_8, int int_9)
		{
			this.int_0 = int_6;
			this.int_1 = int_7;
			this.int_2 = int_8;
			this.int_3 = int_9;
			this.dateTimePicker_0.Value = DateTime.Now.Date;
			if (this.int_4 == -1)
			{
				this.Text = "Новая уставка";
				return;
			}
			if (this.int_5 < 0)
			{
				this.Text = "Новые значения";
				return;
			}
			this.Text = "Редактирование";
		}

		private void FormJRelayProtectionAutomationEditBySchmObj_Load(object sender, EventArgs e)
		{
			this.dataTable_0 = this.method_2();
			this.dataTable_1 = this.method_2();
			this.dataTable_2 = new DataTable("vSChm_treeCellLine");
			DataColumn column = new DataColumn("id", Type.GetType("System.Int32"));
			this.dataTable_2.Columns.Add(column);
			DataColumn column2 = new DataColumn("Name", Type.GetType("System.String"));
			this.dataTable_2.Columns.Add(column2);
			this.method_3();
			this.comboBox_0.SelectedValue = this.int_0;
			this.comboBox_1.SelectedValue = this.int_1;
			this.comboBox_2.SelectedValue = this.int_2;
			this.comboBox_3.SelectedValue = this.int_3;
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			base.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.vJ_RelayProtectionAutomation, true, " where cellid = " + this.int_3.ToString() + " order by relName ");
			if (this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows.Count > 0)
			{
				this.tabPage_0.Text = this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows[0]["relName"].ToString();
				this.tabPage_0.Tag = new FormJRelayProtectionAutomationEditBySchmObj.Struct0(Convert.ToInt32(this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows[0]["id"]), Convert.ToInt32(this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows[0]["relayidValue"]));
				list.Add(Convert.ToInt32(this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows[0]["relayidValue"]));
				list2.Add(Convert.ToInt32(this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows[0]["id"]));
				if (this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows.Count > 1)
				{
					for (int i = 1; i < this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows.Count; i++)
					{
						TabPage tabPage = new TabPage();
						tabPage.BackColor = Color.Transparent;
						tabPage.UseVisualStyleBackColor = true;
						tabPage.Text = this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows[i]["relName"].ToString();
						tabPage.Tag = new FormJRelayProtectionAutomationEditBySchmObj.Struct0(Convert.ToInt32(this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows[i]["id"]), Convert.ToInt32(this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows[i]["relayidValue"]));
						list.Add(Convert.ToInt32(this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows[i]["relayidValue"]));
						list2.Add(Convert.ToInt32(this.dataSetScheme_0.vJ_RelayProtectionAutomation.Rows[i]["id"]));
						this.tabControl_0.TabPages.Add(tabPage);
					}
				}
			}
			else
			{
				this.tabPage_0.Text = "Нет уставок";
				this.panel_0.Visible = false;
				this.button_0.Enabled = false;
			}
			string text = "";
			foreach (int num in list)
			{
				text = text + num.ToString() + ",";
			}
			string text2 = "";
			foreach (int num2 in list2)
			{
				text2 = text2 + num2.ToString() + ",";
			}
			if (text.Length > 0)
			{
				base.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tJ_RelayProtectionAutomationValue, true, "where id in (" + text.Remove(text.Length - 1) + ")");
				base.SelectSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tJ_RelayProtectionAutomation, true, "where id in (" + text2.Remove(text2.Length - 1) + ")");
				this.bindingSource_1.Position = this.bindingSource_1.Find("id", ((FormJRelayProtectionAutomationEditBySchmObj.Struct0)this.tabPage_0.Tag).int_1);
				this.bindingSource_0.Position = this.bindingSource_0.Find("id", ((FormJRelayProtectionAutomationEditBySchmObj.Struct0)this.tabPage_0.Tag).int_0);
			}
		}

		private void tabControl_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			((TabPage)this.panel_0.Parent).Controls.Remove(this.panel_0);
			this.tabControl_0.SelectedTab.Controls.Add(this.panel_0);
			this.bindingSource_1.Position = this.bindingSource_1.Find("id", ((FormJRelayProtectionAutomationEditBySchmObj.Struct0)this.tabControl_0.SelectedTab.Tag).int_1);
			this.bindingSource_0.Position = this.bindingSource_0.Find("id", ((FormJRelayProtectionAutomationEditBySchmObj.Struct0)this.tabControl_0.SelectedTab.Tag).int_0);
			this.panel_0.Refresh();
			this.tabControl_0.Invalidate();
		}

		private DataTable method_2()
		{
			Type type = Type.GetType("System.Int32");
			DataTable dataTable = new DataTable("tSchm_ObjList");
			DataColumn dataColumn = new DataColumn("id", type);
			dataTable.Columns.Add(dataColumn);
			DataColumn column = new DataColumn("Name", Type.GetType("System.String"));
			dataTable.Columns.Add(column);
			dataTable.PrimaryKey = new DataColumn[]
			{
				dataColumn
			};
			return dataTable;
		}

		private void method_3()
		{
			DataSetScheme dataSetScheme = new DataSetScheme();
			base.SelectSqlData(dataSetScheme, dataSetScheme.tR_Classifier, true, " where ParentKey = ';SCM;PS;' and isgroup = 0 and deleted = 0 order by name");
			this.comboBox_0.DisplayMember = "Name";
			this.comboBox_0.ValueMember = "id";
			this.comboBox_0.DataSource = dataSetScheme.tR_Classifier;
			this.comboBox_1.DisplayMember = "Name";
			this.comboBox_1.ValueMember = "Id";
			this.comboBox_1.DataSource = this.dataTable_0;
			this.comboBox_2.DisplayMember = "Name";
			this.comboBox_2.ValueMember = "Id";
			this.comboBox_2.DataSource = this.dataTable_1;
			this.comboBox_3.DisplayMember = "Name";
			this.comboBox_3.ValueMember = "Id";
			this.comboBox_3.DataSource = this.dataTable_2;
			DataSetScheme dataSetScheme2 = new DataSetScheme();
			base.SelectSqlData(dataSetScheme2, dataSetScheme2.tR_Classifier, true, " where ParentKey = ';TypeTransformatorAmperage;' and isgroup = 0 and deleted = 0 order by name");
			this.comboBox_4.DisplayMember = "Name";
			this.comboBox_4.ValueMember = "id";
			this.comboBox_4.DataSource = dataSetScheme2.tR_Classifier;
			DataTable dataTable = new DataTable("tJ_RelayProtectionAutomationValue");
			DataColumn column = new DataColumn("type_relay");
			dataTable.Columns.Add(column);
			base.SelectSqlData(dataTable, true, " group by type_relay order by type_relay", false);
			foreach (object obj in dataTable.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				this.comboBox_6.Items.Add(dataRow["type_relay"].ToString());
			}
			dataTable = new DataTable("tJ_RelayProtectionAutomationValue");
			DataColumn column2 = new DataColumn("type_proc");
			dataTable.Columns.Add(column2);
			base.SelectSqlData(dataTable, true, " group by type_proc order by type_proc", false);
			foreach (object obj2 in dataTable.Rows)
			{
				DataRow dataRow2 = (DataRow)obj2;
				this.comboBox_5.Items.Add(dataRow2["type_proc"].ToString());
			}
		}

		private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_0.SelectedIndex < 0)
			{
				this.dataTable_0.Clear();
				return;
			}
			base.SelectSqlData(this.dataTable_0, true, " where typeCodeId = " + this.comboBox_0.SelectedValue.ToString() + " and deleted = 0 order by name", false);
			this.comboBox_1.SelectedIndex = -1;
		}

		private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_1.SelectedIndex < 0)
			{
				this.dataTable_1.Clear();
				return;
			}
			DataSetScheme dataSetScheme = new DataSetScheme();
			base.SelectSqlData(dataSetScheme, dataSetScheme.tR_Classifier, true, " where ParentKey in (';SCM;BUS;BUSHV;', ';SCM;BUS;BUSMV;') and deleted = 0 and isgroup = 0 ");
			string text = "";
			foreach (object obj in dataSetScheme.tR_Classifier.Rows)
			{
				DataRow dataRow = (DataRow)obj;
				text = text + dataRow["id"].ToString() + ",";
			}
			text = text.Remove(text.Length - 1);
			base.SelectSqlData(this.dataTable_1, true, string.Concat(new string[]
			{
				" where idParent = ",
				this.comboBox_1.SelectedValue.ToString(),
				" and typecodeId in (",
				text,
				") and deleted = 0 order by name"
			}), false);
			this.comboBox_2.SelectedIndex = -1;
		}

		private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox_2.SelectedIndex < 0)
			{
				this.dataTable_2.Clear();
				return;
			}
			base.SelectSqlData(this.dataTable_2, true, " where ParentLink = " + this.comboBox_2.SelectedValue.ToString() + " order by name", false);
			this.comboBox_3.SelectedIndex = -1;
		}

		private void FormJRelayProtectionAutomationEditBySchmObj_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				if (this.comboBox_3.SelectedValue == null)
				{
					MessageBox.Show("Выберите ячейку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					e.Cancel = true;
					return;
				}
				this.dataSetScheme_0.tJ_RelayProtectionAutomation.Rows[0].EndEdit();
				if (this.int_4 < 0)
				{
					try
					{
						this.int_4 = base.InsertSqlDataOneRow(this.dataSetScheme_0, this.dataSetScheme_0.tJ_RelayProtectionAutomation);
						if (this.int_4 > 0)
						{
							this.dataSetScheme_0.tJ_RelayProtectionAutomationValue.Rows[0]["idRelay"] = this.int_4;
							this.dataSetScheme_0.tJ_RelayProtectionAutomationValue.Rows[0].EndEdit();
							base.InsertSqlDataOneRow(this.dataSetScheme_0, this.dataSetScheme_0.tJ_RelayProtectionAutomationValue);
							return;
						}
						e.Cancel = true;
						return;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message, ex.Source);
						return;
					}
				}
				if (this.int_5 < 0)
				{
					this.dataSetScheme_0.tJ_RelayProtectionAutomationValue.Rows[0].EndEdit();
					base.InsertSqlDataOneRow(this.dataSetScheme_0, this.dataSetScheme_0.tJ_RelayProtectionAutomationValue);
					return;
				}
				this.dataSetScheme_0.tJ_RelayProtectionAutomationValue.Rows[0].EndEdit();
				base.UpdateSqlData(this.dataSetScheme_0, this.dataSetScheme_0.tJ_RelayProtectionAutomationValue);
			}
		}

		private void button_0_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		private void button_1_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		private void comboBox_6_TextUpdate(object sender, EventArgs e)
		{
			this.dataSetScheme_0.tJ_RelayProtectionAutomationValue.Rows[0]["type_relay"] = this.comboBox_6.Text;
		}

		private void comboBox_5_TextUpdate(object sender, EventArgs e)
		{
			this.dataSetScheme_0.tJ_RelayProtectionAutomationValue.Rows[0]["type_proc"] = this.comboBox_5.Text;
		}

		private void richTextBox_0_TextChanged(object sender, EventArgs e)
		{
		}

		private void textBox_0_TextChanged(object sender, EventArgs e)
		{
		}

		private DataSetScheme dataSetScheme_0;

		private Label label_0;

		private DateTimePicker dateTimePicker_0;

		private Label label_1;

		private ComboBox comboBox_0;

		private Label label_2;

		private ComboBox comboBox_1;

		private Label label_3;

		private ComboBox comboBox_2;

		private Label label_4;

		private ComboBox comboBox_3;

		private Button button_0;

		private Button button_1;

		private TextBox textBox_0;

		private GroupBox groupBox_0;

		private ComboBox comboBox_4;

		private Label label_5;

		private TextBox textBox_1;

		private TextBox textBox_2;

		private Label label_6;

		private Label label_7;

		private GroupBox groupBox_1;

		private Label label_8;

		private TextBox textBox_3;

		private Label label_9;

		private TextBox textBox_4;

		private Label label_10;

		private TextBox textBox_5;

		private GroupBox groupBox_2;

		private TextBox textBox_6;

		private Label label_11;

		private TextBox textBox_7;

		private Label label_12;

		private GroupBox groupBox_3;

		private TextBox textBox_8;

		private Label label_13;

		private TextBox textBox_9;

		private Label label_14;

		private GroupBox groupBox_4;

		private TextBox textBox_10;

		private Label label_15;

		private TextBox textBox_11;

		private Label label_16;

		private GroupBox groupBox_5;

		private ComboBox comboBox_5;

		private ComboBox comboBox_6;

		private GroupBox groupBox_6;

		private TextBox textBox_12;

		private Label label_17;

		private TextBox textBox_13;

		private Label label_18;

		private Label label_19;

		private RichTextBox richTextBox_0;

		private GroupBox groupBox_7;

		private BindingSource bindingSource_0;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private Label label_20;

		private Panel panel_0;

		private BindingSource bindingSource_1;

		private DataGridViewExcelFilter dataGridViewExcelFilter_0;

		private BindingSource bindingSource_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_12;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_13;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_14;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_15;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_16;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_17;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_18;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_19;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_20;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_21;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_22;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_23;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_24;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_25;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_26;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_27;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_28;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_29;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_30;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_31;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_2;

		private int int_0 = -1;

		private int int_1 = -1;

		private int int_2 = -1;

		private int int_3 = -1;

		private int int_4 = -1;

		private int int_5 = -1;

		private DataTable dataTable_0;

		private DataTable dataTable_1;

		private DataTable dataTable_2;

		private struct Struct0
		{
			public Struct0(int int_2, int int_3)
			{
				this.int_0 = int_2;
				this.int_1 = int_3;
			}

			internal int int_0;

			internal int int_1;
		}
	}
}
