using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Passport.Forms.Documents.Substation
{
	public class FormActRoutineMaintenance : FormDocBase
	{
		public FormActRoutineMaintenance()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.method_19();
		}

		private void FormActRoutineMaintenance_Load(object sender, EventArgs e)
		{
		}

		private void zuhmtoyoMel(object sender, EventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_1 != null)
			{
				this.icontainer_1.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_19()
		{
			DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			this.tableLayoutPanel_0 = new TableLayoutPanel();
			this.button_0 = new Button();
			this.tabControl_0 = new TabControl();
			this.tabPage_0 = new TabPage();
			this.tableLayoutPanel_1 = new TableLayoutPanel();
			this.panel_0 = new Panel();
			this.dataGridView_0 = new DataGridView();
			this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
			this.dataGridViewComboBoxColumn_0 = new DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
			this.label_0 = new Label();
			this.panel_1 = new Panel();
			this.label_1 = new Label();
			this.label_2 = new Label();
			this.label_3 = new Label();
			this.textBox_0 = new TextBox();
			this.textBox_1 = new TextBox();
			this.textBox_2 = new TextBox();
			this.comboBox_0 = new ComboBox();
			this.label_4 = new Label();
			this.label_5 = new Label();
			this.panel_2 = new Panel();
			this.label_6 = new Label();
			this.label_7 = new Label();
			this.textBox_3 = new TextBox();
			this.textBox_4 = new TextBox();
			this.label_8 = new Label();
			this.label_9 = new Label();
			this.panel_3 = new Panel();
			this.label_10 = new Label();
			this.textBox_5 = new TextBox();
			this.label_11 = new Label();
			this.label_12 = new Label();
			this.textBox_6 = new TextBox();
			this.textBox_7 = new TextBox();
			this.label_13 = new Label();
			this.panel_4 = new Panel();
			this.dataGridView_1 = new DataGridView();
			this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
			this.label_14 = new Label();
			this.tabPage_1 = new TabPage();
			this.tableLayoutPanel_2 = new TableLayoutPanel();
			this.tableLayoutPanel_3 = new TableLayoutPanel();
			this.label_15 = new Label();
			this.label_16 = new Label();
			this.label_17 = new Label();
			this.label_18 = new Label();
			this.label_19 = new Label();
			this.comboBox_1 = new ComboBox();
			this.comboBox_2 = new ComboBox();
			this.comboBox_3 = new ComboBox();
			this.comboBox_4 = new ComboBox();
			this.comboBox_5 = new ComboBox();
			this.comboBox_6 = new ComboBox();
			this.panel_5 = new Panel();
			this.textBox_8 = new TextBox();
			this.label_20 = new Label();
			this.panel_6 = new Panel();
			this.textBox_9 = new TextBox();
			this.label_21 = new Label();
			this.panel_7 = new Panel();
			this.textBox_10 = new TextBox();
			this.label_22 = new Label();
			this.panel_8 = new Panel();
			this.textBox_11 = new TextBox();
			this.dateTimePicker_0 = new DateTimePicker();
			this.label_23 = new Label();
			this.label_24 = new Label();
			this.button_1 = new Button();
			this.tableLayoutPanel_0.SuspendLayout();
			this.tabControl_0.SuspendLayout();
			this.tabPage_0.SuspendLayout();
			this.tableLayoutPanel_1.SuspendLayout();
			this.panel_0.SuspendLayout();
			((ISupportInitialize)this.dataGridView_0).BeginInit();
			this.panel_1.SuspendLayout();
			this.panel_2.SuspendLayout();
			this.panel_3.SuspendLayout();
			this.panel_4.SuspendLayout();
			((ISupportInitialize)this.dataGridView_1).BeginInit();
			this.tabPage_1.SuspendLayout();
			this.tableLayoutPanel_2.SuspendLayout();
			this.tableLayoutPanel_3.SuspendLayout();
			this.panel_5.SuspendLayout();
			this.panel_6.SuspendLayout();
			this.panel_7.SuspendLayout();
			this.panel_8.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel_0.ColumnCount = 2;
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 105f));
			this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
			this.tableLayoutPanel_0.Controls.Add(this.button_0, 0, 1);
			this.tableLayoutPanel_0.Controls.Add(this.tabControl_0, 0, 0);
			this.tableLayoutPanel_0.Controls.Add(this.button_1, 0, 1);
			this.tableLayoutPanel_0.Dock = DockStyle.Fill;
			this.tableLayoutPanel_0.Location = new Point(0, 0);
			this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
			this.tableLayoutPanel_0.RowCount = 2;
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 43f));
			this.tableLayoutPanel_0.Size = new Size(804, 593);
			this.tableLayoutPanel_0.TabIndex = 0;
			this.button_0.Dock = DockStyle.Left;
			this.button_0.Location = new Point(704, 558);
			this.button_0.Margin = new Padding(5, 8, 3, 10);
			this.button_0.Name = "btnClose";
			this.button_0.Size = new Size(75, 25);
			this.button_0.TabIndex = 3;
			this.button_0.Text = "Закрыть";
			this.button_0.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_0.SetColumnSpan(this.tabControl_0, 2);
			this.tabControl_0.Controls.Add(this.tabPage_0);
			this.tabControl_0.Controls.Add(this.tabPage_1);
			this.tabControl_0.Dock = DockStyle.Fill;
			this.tabControl_0.Location = new Point(3, 3);
			this.tabControl_0.Name = "tabControl1";
			this.tabControl_0.SelectedIndex = 0;
			this.tabControl_0.Size = new Size(798, 544);
			this.tabControl_0.TabIndex = 1;
			this.tabPage_0.Controls.Add(this.tableLayoutPanel_1);
			this.tabPage_0.Location = new Point(4, 22);
			this.tabPage_0.Name = "tpGeneral";
			this.tabPage_0.Padding = new Padding(3);
			this.tabPage_0.Size = new Size(790, 518);
			this.tabPage_0.TabIndex = 0;
			this.tabPage_0.Text = "Общие";
			this.tabPage_0.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_1.ColumnCount = 1;
			this.tableLayoutPanel_1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.Controls.Add(this.panel_0, 0, 4);
			this.tableLayoutPanel_1.Controls.Add(this.panel_1, 0, 0);
			this.tableLayoutPanel_1.Controls.Add(this.panel_2, 0, 1);
			this.tableLayoutPanel_1.Controls.Add(this.panel_3, 0, 2);
			this.tableLayoutPanel_1.Controls.Add(this.panel_4, 0, 3);
			this.tableLayoutPanel_1.Dock = DockStyle.Fill;
			this.tableLayoutPanel_1.Location = new Point(3, 3);
			this.tableLayoutPanel_1.Name = "tableLayoutPanel2";
			this.tableLayoutPanel_1.RowCount = 5;
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 58f));
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32f));
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Absolute, 150f));
			this.tableLayoutPanel_1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_1.Size = new Size(784, 512);
			this.tableLayoutPanel_1.TabIndex = 1;
			this.panel_0.Controls.Add(this.dataGridView_0);
			this.panel_0.Controls.Add(this.label_0);
			this.panel_0.Dock = DockStyle.Fill;
			this.panel_0.Location = new Point(3, 275);
			this.panel_0.Name = "panel1";
			this.panel_0.Size = new Size(778, 234);
			this.panel_0.TabIndex = 0;
			this.dataGridView_0.BackgroundColor = Color.White;
			dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.BackColor = SystemColors.Control;
			dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dataGridView_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_0.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_0,
				this.dataGridViewComboBoxColumn_0,
				this.dataGridViewTextBoxColumn_1,
				this.dataGridViewTextBoxColumn_2,
				this.dataGridViewCheckBoxColumn_0,
				this.dataGridViewTextBoxColumn_3
			});
			this.dataGridView_0.Dock = DockStyle.Fill;
			this.dataGridView_0.Location = new Point(0, 13);
			this.dataGridView_0.MultiSelect = false;
			this.dataGridView_0.Name = "dgvMaintenWorks";
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = SystemColors.Control;
			dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dataGridView_0.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_0.Size = new Size(778, 221);
			this.dataGridView_0.TabIndex = 51;
			this.dataGridViewTextBoxColumn_0.HeaderText = "idWork";
			this.dataGridViewTextBoxColumn_0.Name = "idWork";
			this.dataGridViewTextBoxColumn_0.Visible = false;
			this.dataGridViewComboBoxColumn_0.HeaderText = "Перечень работ";
			this.dataGridViewComboBoxColumn_0.Name = "WorkList";
			this.dataGridViewComboBoxColumn_0.Width = 180;
			this.dataGridViewTextBoxColumn_1.HeaderText = "Наименование материалов";
			this.dataGridViewTextBoxColumn_1.Name = "NaimInstr";
			this.dataGridViewTextBoxColumn_1.Width = 130;
			this.dataGridViewTextBoxColumn_2.HeaderText = "Кол-во материалов";
			this.dataGridViewTextBoxColumn_2.Name = "CountInstr";
			this.dataGridViewTextBoxColumn_2.Width = 90;
			this.dataGridViewCheckBoxColumn_0.HeaderText = "Отметка о выполнении";
			this.dataGridViewCheckBoxColumn_0.Name = "isSuccess";
			this.dataGridViewCheckBoxColumn_0.Width = 90;
			this.dataGridViewTextBoxColumn_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn_3.HeaderText = "Примечание";
			this.dataGridViewTextBoxColumn_3.Name = "Comment";
			this.dataGridViewTextBoxColumn_3.Resizable = DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn_3.SortMode = DataGridViewColumnSortMode.NotSortable;
			this.label_0.AutoSize = true;
			this.label_0.Dock = DockStyle.Top;
			this.label_0.Location = new Point(0, 0);
			this.label_0.Name = "label10";
			this.label_0.Size = new Size(280, 13);
			this.label_0.TabIndex = 50;
			this.label_0.Text = "При ремонте ТП были проведены следующие работы";
			this.panel_1.Controls.Add(this.label_1);
			this.panel_1.Controls.Add(this.label_2);
			this.panel_1.Controls.Add(this.label_3);
			this.panel_1.Controls.Add(this.textBox_0);
			this.panel_1.Controls.Add(this.textBox_1);
			this.panel_1.Controls.Add(this.textBox_2);
			this.panel_1.Controls.Add(this.comboBox_0);
			this.panel_1.Controls.Add(this.label_4);
			this.panel_1.Controls.Add(this.label_5);
			this.panel_1.Dock = DockStyle.Fill;
			this.panel_1.Location = new Point(3, 3);
			this.panel_1.Name = "panel2";
			this.panel_1.Size = new Size(778, 26);
			this.panel_1.TabIndex = 1;
			this.label_1.AutoSize = true;
			this.label_1.Location = new Point(689, 6);
			this.label_1.Name = "lbVoltage2";
			this.label_1.Size = new Size(20, 13);
			this.label_1.TabIndex = 43;
			this.label_1.Text = "кВ";
			this.label_2.AutoSize = true;
			this.label_2.Location = new Point(471, 6);
			this.label_2.Name = "lbVoltage";
			this.label_2.Size = new Size(106, 13);
			this.label_2.TabIndex = 42;
			this.label_2.Text = "кВА     Напряжение";
			this.label_3.AutoSize = true;
			this.label_3.Location = new Point(346, 6);
			this.label_3.Name = "lbPower";
			this.label_3.Size = new Size(60, 13);
			this.label_3.TabIndex = 41;
			this.label_3.Text = "Мощность";
			this.textBox_0.Location = new Point(583, 3);
			this.textBox_0.Name = "tbVoltage";
			this.textBox_0.Size = new Size(100, 20);
			this.textBox_0.TabIndex = 40;
			this.textBox_1.Location = new Point(412, 3);
			this.textBox_1.Name = "tbPower";
			this.textBox_1.Size = new Size(53, 20);
			this.textBox_1.TabIndex = 39;
			this.textBox_2.Location = new Point(193, 3);
			this.textBox_2.Name = "tbTypeSS";
			this.textBox_2.Size = new Size(138, 20);
			this.textBox_2.TabIndex = 38;
			this.comboBox_0.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_0.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_0.FormattingEnabled = true;
			this.comboBox_0.Location = new Point(51, 3);
			this.comboBox_0.Name = "cbNameSS";
			this.comboBox_0.Size = new Size(91, 21);
			this.comboBox_0.TabIndex = 37;
			this.label_4.AutoSize = true;
			this.label_4.Location = new Point(158, 6);
			this.label_4.Name = "lbType";
			this.label_4.Size = new Size(29, 13);
			this.label_4.TabIndex = 36;
			this.label_4.Text = "Тип ";
			this.label_5.AutoSize = true;
			this.label_5.Location = new Point(9, 6);
			this.label_5.Name = "lbNameSS";
			this.label_5.Size = new Size(36, 13);
			this.label_5.TabIndex = 35;
			this.label_5.Text = "ТП №";
			this.panel_2.Controls.Add(this.label_6);
			this.panel_2.Controls.Add(this.label_7);
			this.panel_2.Controls.Add(this.textBox_3);
			this.panel_2.Controls.Add(this.textBox_4);
			this.panel_2.Controls.Add(this.label_8);
			this.panel_2.Controls.Add(this.label_9);
			this.panel_2.Dock = DockStyle.Fill;
			this.panel_2.Location = new Point(3, 35);
			this.panel_2.Name = "panel3";
			this.panel_2.Size = new Size(778, 52);
			this.panel_2.TabIndex = 2;
			this.label_6.AutoSize = true;
			this.label_6.Location = new Point(471, 33);
			this.label_6.Name = "label4";
			this.label_6.Size = new Size(24, 13);
			this.label_6.TabIndex = 46;
			this.label_6.Text = "лет";
			this.label_7.AutoSize = true;
			this.label_7.Location = new Point(471, 7);
			this.label_7.Name = "label3";
			this.label_7.Size = new Size(24, 13);
			this.label_7.TabIndex = 45;
			this.label_7.Text = "лет";
			this.textBox_3.Location = new Point(365, 29);
			this.textBox_3.Name = "tbTimeFromRepair";
			this.textBox_3.Size = new Size(100, 20);
			this.textBox_3.TabIndex = 44;
			this.textBox_4.Location = new Point(365, 3);
			this.textBox_4.Name = "tbTimeFromExpl";
			this.textBox_4.Size = new Size(100, 20);
			this.textBox_4.TabIndex = 43;
			this.label_8.AutoSize = true;
			this.label_8.Location = new Point(9, 32);
			this.label_8.Name = "label2";
			this.label_8.Size = new Size(241, 13);
			this.label_8.TabIndex = 42;
			this.label_8.Text = ", с момента окончания предыдущего ремонта";
			this.label_9.AutoSize = true;
			this.label_9.Location = new Point(9, 6);
			this.label_9.Name = "label1";
			this.label_9.Size = new Size(338, 13);
			this.label_9.TabIndex = 41;
			this.label_9.Text = "ТП проработала с начала эксплуатации до настоящего ремонта ";
			this.panel_3.Controls.Add(this.label_10);
			this.panel_3.Controls.Add(this.textBox_5);
			this.panel_3.Controls.Add(this.label_11);
			this.panel_3.Controls.Add(this.label_12);
			this.panel_3.Controls.Add(this.textBox_6);
			this.panel_3.Controls.Add(this.textBox_7);
			this.panel_3.Controls.Add(this.label_13);
			this.panel_3.Dock = DockStyle.Fill;
			this.panel_3.Location = new Point(3, 93);
			this.panel_3.Name = "panel4";
			this.panel_3.Size = new Size(778, 26);
			this.panel_3.TabIndex = 3;
			this.label_10.AutoSize = true;
			this.label_10.Location = new Point(632, 6);
			this.label_10.Name = "label8";
			this.label_10.Size = new Size(18, 13);
			this.label_10.TabIndex = 54;
			this.label_10.Text = "г. ";
			this.textBox_5.Location = new Point(514, 3);
			this.textBox_5.Name = "tpPlanPPR";
			this.textBox_5.Size = new Size(100, 20);
			this.textBox_5.TabIndex = 53;
			this.label_11.AutoSize = true;
			this.label_11.Location = new Point(366, 6);
			this.label_11.Name = "label7";
			this.label_11.Size = new Size(148, 13);
			this.label_11.TabIndex = 52;
			this.label_11.Text = "г.   при сроке по плану ППР";
			this.label_12.AutoSize = true;
			this.label_12.Location = new Point(231, 6);
			this.label_12.Name = "label6";
			this.label_12.Size = new Size(33, 13);
			this.label_12.TabIndex = 51;
			this.label_12.Text = "г. по ";
			this.textBox_6.Location = new Point(260, 3);
			this.textBox_6.Name = "tbRepairDateEnd";
			this.textBox_6.Size = new Size(100, 20);
			this.textBox_6.TabIndex = 50;
			this.textBox_7.Location = new Point(125, 3);
			this.textBox_7.Name = "tbRepairDateBegin";
			this.textBox_7.Size = new Size(100, 20);
			this.textBox_7.TabIndex = 49;
			this.label_13.AutoSize = true;
			this.label_13.Location = new Point(9, 6);
			this.label_13.Name = "label5";
			this.label_13.Size = new Size(110, 13);
			this.label_13.TabIndex = 48;
			this.label_13.Text = "Ремонт выполнен с ";
			this.panel_4.Controls.Add(this.dataGridView_1);
			this.panel_4.Controls.Add(this.label_14);
			this.panel_4.Dock = DockStyle.Fill;
			this.panel_4.Location = new Point(3, 125);
			this.panel_4.Name = "panel5";
			this.panel_4.Size = new Size(778, 144);
			this.panel_4.TabIndex = 4;
			this.dataGridView_1.AllowUserToDeleteRows = false;
			this.dataGridView_1.AllowUserToResizeRows = false;
			this.dataGridView_1.BackgroundColor = Color.White;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			this.dataGridView_1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_1.Columns.AddRange(new DataGridViewColumn[]
			{
				this.dataGridViewTextBoxColumn_4,
				this.dataGridViewTextBoxColumn_5,
				this.dataGridViewTextBoxColumn_6,
				this.dataGridViewTextBoxColumn_7,
				this.dataGridViewTextBoxColumn_8,
				this.dataGridViewTextBoxColumn_9,
				this.dataGridViewTextBoxColumn_10,
				this.dataGridViewTextBoxColumn_11
			});
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.White;
			dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = Color.White;
			dataGridViewCellStyle4.SelectionForeColor = Color.Blue;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
			this.dataGridView_1.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView_1.Dock = DockStyle.Fill;
			this.dataGridView_1.Location = new Point(0, 13);
			this.dataGridView_1.Margin = new Padding(3, 10, 3, 3);
			this.dataGridView_1.MultiSelect = false;
			this.dataGridView_1.Name = "dgvTransf";
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = SystemColors.Control;
			dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
			dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			this.dataGridView_1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView_1.Size = new Size(778, 131);
			this.dataGridView_1.TabIndex = 50;
			this.dataGridViewTextBoxColumn_4.HeaderText = "idTrans";
			this.dataGridViewTextBoxColumn_4.Name = "idTrans";
			this.dataGridViewTextBoxColumn_4.Visible = false;
			this.dataGridViewTextBoxColumn_5.HeaderText = "№ тр.";
			this.dataGridViewTextBoxColumn_5.Name = "NumberTrans";
			this.dataGridViewTextBoxColumn_5.Width = 70;
			this.dataGridViewTextBoxColumn_6.HeaderText = "Тип";
			this.dataGridViewTextBoxColumn_6.Name = "TypeTrans";
			this.dataGridViewTextBoxColumn_6.Width = 120;
			this.dataGridViewTextBoxColumn_7.HeaderText = "Заводской номер";
			this.dataGridViewTextBoxColumn_7.Name = "SerialNumberTrans";
			this.dataGridViewTextBoxColumn_7.Width = 115;
			this.dataGridViewTextBoxColumn_8.HeaderText = "Мощность";
			this.dataGridViewTextBoxColumn_8.Name = "PowerTrans";
			this.dataGridViewTextBoxColumn_9.HeaderText = "Год изготовления";
			this.dataGridViewTextBoxColumn_9.Name = "YearBuildTrans";
			this.dataGridViewTextBoxColumn_9.Width = 90;
			this.dataGridViewTextBoxColumn_10.HeaderText = "Группа соединений";
			this.dataGridViewTextBoxColumn_10.Name = "GroupTrans";
			this.dataGridViewTextBoxColumn_10.Width = 110;
			this.dataGridViewTextBoxColumn_11.HeaderText = "Положение ПБВ";
			this.dataGridViewTextBoxColumn_11.Name = "StatusPBVTrans";
			this.dataGridViewTextBoxColumn_11.Width = 130;
			this.label_14.AutoSize = true;
			this.label_14.Dock = DockStyle.Top;
			this.label_14.Location = new Point(0, 0);
			this.label_14.Name = "label11";
			this.label_14.Size = new Size(146, 13);
			this.label_14.TabIndex = 0;
			this.label_14.Text = "Данные трансформаторов:";
			this.tabPage_1.Controls.Add(this.tableLayoutPanel_2);
			this.tabPage_1.Location = new Point(4, 22);
			this.tabPage_1.Name = "tpTest";
			this.tabPage_1.Padding = new Padding(3);
			this.tabPage_1.Size = new Size(790, 518);
			this.tabPage_1.TabIndex = 1;
			this.tabPage_1.Text = "Испытания";
			this.tabPage_1.UseVisualStyleBackColor = true;
			this.tableLayoutPanel_2.ColumnCount = 1;
			this.tableLayoutPanel_2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_2.Controls.Add(this.tableLayoutPanel_3, 0, 4);
			this.tableLayoutPanel_2.Controls.Add(this.panel_5, 0, 3);
			this.tableLayoutPanel_2.Controls.Add(this.panel_6, 0, 2);
			this.tableLayoutPanel_2.Controls.Add(this.panel_7, 0, 1);
			this.tableLayoutPanel_2.Controls.Add(this.panel_8, 0, 0);
			this.tableLayoutPanel_2.Dock = DockStyle.Fill;
			this.tableLayoutPanel_2.Location = new Point(3, 3);
			this.tableLayoutPanel_2.Name = "tableLayoutPanel3";
			this.tableLayoutPanel_2.RowCount = 5;
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Absolute, 36f));
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.95588f));
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Percent, 54.04412f));
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Absolute, 120f));
			this.tableLayoutPanel_2.RowStyles.Add(new RowStyle(SizeType.Absolute, 83f));
			this.tableLayoutPanel_2.Size = new Size(784, 512);
			this.tableLayoutPanel_2.TabIndex = 0;
			this.tableLayoutPanel_3.ColumnCount = 6;
			this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240f));
			this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 156f));
			this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 177f));
			this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 35f));
			this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 148f));
			this.tableLayoutPanel_3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.tableLayoutPanel_3.Controls.Add(this.label_15, 0, 0);
			this.tableLayoutPanel_3.Controls.Add(this.label_16, 0, 1);
			this.tableLayoutPanel_3.Controls.Add(this.label_17, 0, 2);
			this.tableLayoutPanel_3.Controls.Add(this.label_18, 2, 0);
			this.tableLayoutPanel_3.Controls.Add(this.label_19, 2, 1);
			this.tableLayoutPanel_3.Controls.Add(this.comboBox_1, 1, 0);
			this.tableLayoutPanel_3.Controls.Add(this.comboBox_2, 1, 1);
			this.tableLayoutPanel_3.Controls.Add(this.comboBox_3, 1, 2);
			this.tableLayoutPanel_3.Controls.Add(this.comboBox_4, 3, 0);
			this.tableLayoutPanel_3.Controls.Add(this.comboBox_5, 4, 0);
			this.tableLayoutPanel_3.Controls.Add(this.comboBox_6, 4, 1);
			this.tableLayoutPanel_3.Dock = DockStyle.Fill;
			this.tableLayoutPanel_3.Location = new Point(3, 431);
			this.tableLayoutPanel_3.Name = "tableLayoutPanel4";
			this.tableLayoutPanel_3.RowCount = 3;
			this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333f));
			this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333f));
			this.tableLayoutPanel_3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333f));
			this.tableLayoutPanel_3.Size = new Size(778, 78);
			this.tableLayoutPanel_3.TabIndex = 0;
			this.label_15.AutoSize = true;
			this.label_15.Dock = DockStyle.Fill;
			this.label_15.Location = new Point(3, 0);
			this.label_15.Name = "label9";
			this.label_15.Size = new Size(234, 26);
			this.label_15.TabIndex = 0;
			this.label_15.Text = "Инженер ПТС";
			this.label_15.TextAlign = ContentAlignment.MiddleLeft;
			this.label_16.AutoSize = true;
			this.label_16.Dock = DockStyle.Fill;
			this.label_16.Location = new Point(3, 26);
			this.label_16.Name = "label12";
			this.label_16.Size = new Size(234, 26);
			this.label_16.TabIndex = 1;
			this.label_16.Text = "Начальник производственной лаборатории";
			this.label_16.TextAlign = ContentAlignment.MiddleLeft;
			this.label_17.AutoSize = true;
			this.label_17.Dock = DockStyle.Fill;
			this.label_17.Location = new Point(3, 52);
			this.label_17.Name = "label13";
			this.label_17.Size = new Size(234, 26);
			this.label_17.TabIndex = 2;
			this.label_17.Text = "Электромонтер (производитель работ)";
			this.label_17.TextAlign = ContentAlignment.MiddleLeft;
			this.label_18.AutoSize = true;
			this.label_18.Dock = DockStyle.Fill;
			this.label_18.Location = new Point(399, 0);
			this.label_18.Name = "label14";
			this.label_18.Size = new Size(171, 26);
			this.label_18.TabIndex = 3;
			this.label_18.Text = "Начальник сетевого района №";
			this.label_18.TextAlign = ContentAlignment.MiddleLeft;
			this.label_19.AutoSize = true;
			this.label_19.Dock = DockStyle.Fill;
			this.label_19.Location = new Point(399, 26);
			this.label_19.Name = "label15";
			this.label_19.Size = new Size(171, 26);
			this.label_19.TabIndex = 4;
			this.label_19.Text = "Мастер сетевого района";
			this.label_19.TextAlign = ContentAlignment.MiddleLeft;
			this.comboBox_1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_1.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_1.Dock = DockStyle.Fill;
			this.comboBox_1.FormattingEnabled = true;
			this.comboBox_1.Location = new Point(243, 3);
			this.comboBox_1.Name = "cbEngineerPTS";
			this.comboBox_1.Size = new Size(150, 21);
			this.comboBox_1.TabIndex = 5;
			this.comboBox_2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_2.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_2.Dock = DockStyle.Fill;
			this.comboBox_2.FormattingEnabled = true;
			this.comboBox_2.Location = new Point(243, 29);
			this.comboBox_2.Name = "HeadProdLab";
			this.comboBox_2.Size = new Size(150, 21);
			this.comboBox_2.TabIndex = 6;
			this.comboBox_3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_3.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_3.Dock = DockStyle.Fill;
			this.comboBox_3.FormattingEnabled = true;
			this.comboBox_3.Location = new Point(243, 55);
			this.comboBox_3.Name = "cbElectrician";
			this.comboBox_3.Size = new Size(150, 21);
			this.comboBox_3.TabIndex = 7;
			this.comboBox_4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_4.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_4.Dock = DockStyle.Fill;
			this.comboBox_4.FormattingEnabled = true;
			this.comboBox_4.Items.AddRange(new object[]
			{
				"1",
				"2",
				"3",
				"4"
			});
			this.comboBox_4.Location = new Point(576, 3);
			this.comboBox_4.Name = "cbNumberRegion";
			this.comboBox_4.Size = new Size(29, 21);
			this.comboBox_4.TabIndex = 8;
			this.comboBox_4.SelectedIndexChanged += this.zuhmtoyoMel;
			this.comboBox_5.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_5.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_5.Dock = DockStyle.Fill;
			this.comboBox_5.FormattingEnabled = true;
			this.comboBox_5.Location = new Point(611, 3);
			this.comboBox_5.Name = "cbHeadNetRegion";
			this.comboBox_5.Size = new Size(142, 21);
			this.comboBox_5.TabIndex = 9;
			this.comboBox_6.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.comboBox_6.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.comboBox_6.Dock = DockStyle.Fill;
			this.comboBox_6.FormattingEnabled = true;
			this.comboBox_6.Location = new Point(611, 29);
			this.comboBox_6.Name = "cbMasterNetRegion";
			this.comboBox_6.Size = new Size(142, 21);
			this.comboBox_6.TabIndex = 10;
			this.panel_5.Controls.Add(this.textBox_8);
			this.panel_5.Controls.Add(this.label_20);
			this.panel_5.Dock = DockStyle.Fill;
			this.panel_5.Location = new Point(3, 311);
			this.panel_5.Name = "panel6";
			this.panel_5.Size = new Size(778, 114);
			this.panel_5.TabIndex = 1;
			this.textBox_8.Dock = DockStyle.Fill;
			this.textBox_8.Location = new Point(0, 13);
			this.textBox_8.Multiline = true;
			this.textBox_8.Name = "tbComments";
			this.textBox_8.Size = new Size(778, 101);
			this.textBox_8.TabIndex = 1;
			this.label_20.AutoSize = true;
			this.label_20.Dock = DockStyle.Top;
			this.label_20.Location = new Point(0, 0);
			this.label_20.Name = "label16";
			this.label_20.Size = new Size(392, 13);
			this.label_20.TabIndex = 0;
			this.label_20.Text = "Замечания по выполнению текущего ремонта ТП, выявленные комиссией:";
			this.panel_6.Controls.Add(this.textBox_9);
			this.panel_6.Controls.Add(this.label_21);
			this.panel_6.Dock = DockStyle.Fill;
			this.panel_6.Location = new Point(3, 164);
			this.panel_6.Name = "panel7";
			this.panel_6.Size = new Size(778, 141);
			this.panel_6.TabIndex = 2;
			this.textBox_9.Dock = DockStyle.Fill;
			this.textBox_9.Location = new Point(0, 13);
			this.textBox_9.Multiline = true;
			this.textBox_9.Name = "tbTestParam";
			this.textBox_9.Size = new Size(778, 128);
			this.textBox_9.TabIndex = 1;
			this.label_21.AutoSize = true;
			this.label_21.Dock = DockStyle.Top;
			this.label_21.Location = new Point(0, 0);
			this.label_21.Name = "label17";
			this.label_21.Size = new Size(124, 13);
			this.label_21.TabIndex = 0;
			this.label_21.Text = "Параметры испытаний";
			this.panel_7.Controls.Add(this.textBox_10);
			this.panel_7.Controls.Add(this.label_22);
			this.panel_7.Dock = DockStyle.Fill;
			this.panel_7.Location = new Point(3, 39);
			this.panel_7.Name = "panel8";
			this.panel_7.Size = new Size(778, 119);
			this.panel_7.TabIndex = 3;
			this.textBox_10.Dock = DockStyle.Fill;
			this.textBox_10.Location = new Point(0, 13);
			this.textBox_10.Multiline = true;
			this.textBox_10.Name = "tbTestConducted";
			this.textBox_10.Size = new Size(778, 106);
			this.textBox_10.TabIndex = 1;
			this.label_22.AutoSize = true;
			this.label_22.Dock = DockStyle.Top;
			this.label_22.Location = new Point(0, 0);
			this.label_22.Name = "label18";
			this.label_22.Size = new Size(133, 13);
			this.label_22.TabIndex = 0;
			this.label_22.Text = "Испытания проводились";
			this.panel_8.Controls.Add(this.textBox_11);
			this.panel_8.Controls.Add(this.dateTimePicker_0);
			this.panel_8.Controls.Add(this.label_23);
			this.panel_8.Controls.Add(this.label_24);
			this.panel_8.Dock = DockStyle.Fill;
			this.panel_8.Location = new Point(3, 3);
			this.panel_8.Name = "panel9";
			this.panel_8.Size = new Size(778, 30);
			this.panel_8.TabIndex = 4;
			this.textBox_11.Location = new Point(517, 5);
			this.textBox_11.Name = "tbProtocolNumber";
			this.textBox_11.Size = new Size(100, 20);
			this.textBox_11.TabIndex = 3;
			this.dateTimePicker_0.Location = new Point(646, 6);
			this.dateTimePicker_0.Name = "dtpProtocolDate";
			this.dateTimePicker_0.Size = new Size(124, 20);
			this.dateTimePicker_0.TabIndex = 2;
			this.label_23.AutoSize = true;
			this.label_23.Location = new Point(622, 8);
			this.label_23.Name = "label20";
			this.label_23.Size = new Size(18, 13);
			this.label_23.TabIndex = 1;
			this.label_23.Text = "от";
			this.label_24.AutoSize = true;
			this.label_24.Location = new Point(3, 8);
			this.label_24.Name = "label19";
			this.label_24.Size = new Size(514, 13);
			this.label_24.TabIndex = 0;
			this.label_24.Text = "Оборудование прошло необходимые испытания, измерения (протоколы испытаний и измерений №";
			this.button_1.Dock = DockStyle.Right;
			this.button_1.Location = new Point(589, 558);
			this.button_1.Margin = new Padding(3, 8, 10, 10);
			this.button_1.Name = "btnSave";
			this.button_1.Size = new Size(100, 25);
			this.button_1.TabIndex = 2;
			this.button_1.Text = "Сохранить";
			this.button_1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(804, 593);
			base.Controls.Add(this.tableLayoutPanel_0);
			base.Name = "FormActRoutineMaintenance";
			this.Text = "Акт приемки из текущего ремонта трансформаторной подстанции";
			base.Load += this.FormActRoutineMaintenance_Load;
			this.tableLayoutPanel_0.ResumeLayout(false);
			this.tabControl_0.ResumeLayout(false);
			this.tabPage_0.ResumeLayout(false);
			this.tableLayoutPanel_1.ResumeLayout(false);
			this.panel_0.ResumeLayout(false);
			this.panel_0.PerformLayout();
			((ISupportInitialize)this.dataGridView_0).EndInit();
			this.panel_1.ResumeLayout(false);
			this.panel_1.PerformLayout();
			this.panel_2.ResumeLayout(false);
			this.panel_2.PerformLayout();
			this.panel_3.ResumeLayout(false);
			this.panel_3.PerformLayout();
			this.panel_4.ResumeLayout(false);
			this.panel_4.PerformLayout();
			((ISupportInitialize)this.dataGridView_1).EndInit();
			this.tabPage_1.ResumeLayout(false);
			this.tableLayoutPanel_2.ResumeLayout(false);
			this.tableLayoutPanel_3.ResumeLayout(false);
			this.tableLayoutPanel_3.PerformLayout();
			this.panel_5.ResumeLayout(false);
			this.panel_5.PerformLayout();
			this.panel_6.ResumeLayout(false);
			this.panel_6.PerformLayout();
			this.panel_7.ResumeLayout(false);
			this.panel_7.PerformLayout();
			this.panel_8.ResumeLayout(false);
			this.panel_8.PerformLayout();
			base.ResumeLayout(false);
		}

		private IContainer icontainer_1;

		private TableLayoutPanel tableLayoutPanel_0;

		private Button button_0;

		private TabControl tabControl_0;

		private TabPage tabPage_0;

		private TableLayoutPanel tableLayoutPanel_1;

		private Panel panel_0;

		private DataGridView dataGridView_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;

		private DataGridViewComboBoxColumn dataGridViewComboBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_2;

		private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn_0;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_3;

		private Label label_0;

		private Panel panel_1;

		private Label label_1;

		private Label label_2;

		private Label label_3;

		private TextBox textBox_0;

		private TextBox textBox_1;

		private TextBox textBox_2;

		private ComboBox comboBox_0;

		private Label label_4;

		private Label label_5;

		private Panel panel_2;

		private Label label_6;

		private Label label_7;

		private TextBox textBox_3;

		private TextBox textBox_4;

		private Label label_8;

		private Label label_9;

		private Panel panel_3;

		private Label label_10;

		private TextBox textBox_5;

		private Label label_11;

		private Label label_12;

		private TextBox textBox_6;

		private TextBox textBox_7;

		private Label label_13;

		private Panel panel_4;

		private DataGridView dataGridView_1;

		private Label label_14;

		private TabPage tabPage_1;

		private Button button_1;

		private TableLayoutPanel tableLayoutPanel_2;

		private TableLayoutPanel tableLayoutPanel_3;

		private Label label_15;

		private Label label_16;

		private Label label_17;

		private Label label_18;

		private Label label_19;

		private ComboBox comboBox_1;

		private ComboBox comboBox_2;

		private ComboBox comboBox_3;

		private ComboBox comboBox_4;

		private Panel panel_5;

		private TextBox textBox_8;

		private Label label_20;

		private Panel panel_6;

		private TextBox textBox_9;

		private Label label_21;

		private Panel panel_7;

		private TextBox textBox_10;

		private Label label_22;

		private Panel panel_8;

		private TextBox textBox_11;

		private DateTimePicker dateTimePicker_0;

		private Label label_23;

		private Label label_24;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_4;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_5;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_6;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_7;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_8;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_9;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_10;

		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_11;

		private ComboBox comboBox_5;

		private ComboBox comboBox_6;
	}
}
