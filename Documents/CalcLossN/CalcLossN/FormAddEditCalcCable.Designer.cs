using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


	public partial class FormAddEditCalcCable 
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}

            base.Dispose(disposing); 
        }

		private System.ComponentModel.IContainer components=null;
        private void InitializeComponent()
        {
            this.components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            ComponentResourceManager resource = new ComponentResourceManager(typeof(FormAddEditCalcCable));
            this.label1 = new Label();
            this.dateTimePickerDateCalc = new DateTimePicker();
            this.dataSetCalc = new CalcLossN.DataSet.DataSetCalc();
            //this.dsCalcN = new CalcLossN.DataSet.DataSetCalc();
            this.label2 = new Label();
            this.cmbOwner = new ComboBox();
            this.label3 = new Label();
            this.txtNameCalc = new TextBox();
            this.cmbAbnObj = new ComboBox();
            this.label5 = new Label();
            this.txtAbn = new TextBox();
            this.label4 = new Label();
            this.toolStripAbnObj = new ToolStrip();
            this.toolBtnContractor = new ToolStripButton();
            this.txtAbnBalance = new TextBox();
            this.label6 = new Label();
            this.buttonAbnBalance = new Button();
            this.label7 = new Label();
            this.txtTPName = new TextBox();
            this.label8 = new Label();
            this.txtMakeupCable = new TextBox();
            this.buttonMakeupCable = new Button();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.txtLineLenght = new TextBox();
            this.txtUdActiveResistance = new TextBox();
            this.textBox4 = new TextBox();
            this.textBox5 = new TextBox();
            this.txtVoltageValue = new TextBox();
            this.textBox7 = new TextBox();
            this.textBox8 = new TextBox();
            this.txtCoeffPowerReactive = new TextBox();
            this.textBox10 = new TextBox();
            this.textBox11 = new TextBox();
            this.txtPeriod = new TextBox();
            this.textBox13 = new TextBox();
            this.textBox14 = new TextBox();
            this.txtConsumtion = new TextBox();
            this.textBox16 = new TextBox();
            this.textBox17 = new TextBox();
            this.txtCountChain = new TextBox();
            this.textBox19 = new TextBox();
            this.textBox20 = new TextBox();
            this.txtCoeffDifference = new TextBox();
            this.textBox22 = new TextBox();
            this.textBox23 = new TextBox();
            this.txtSquareCoeff = new TextBox();
            this.textBox25 = new TextBox();
            this.textBox26 = new TextBox();
            this.buttonOK = new Button();
            this.txtActiveResistance = new TextBox();
            this.textBox6 = new TextBox();
            this.textBox27 = new TextBox();
            this.txtLoadAverage = new TextBox();
            this.textBox18 = new TextBox();
            this.textBox28 = new TextBox();
            this.txtLoadPowerLoss = new TextBox();
            this.textBox12 = new TextBox();
            this.textBox15 = new TextBox();
            this.txtLoadLosses = new TextBox();
            this.textBox9 = new TextBox();
            this.textBox29 = new TextBox();
            this.txtUnitYearLoss = new TextBox();
            this.labelParamUnitYearLoss = new TextBox();
            this.labelUnitYearLoss = new TextBox();
            this.labelParamYearLoss = new TextBox();
            this.txtYearLoss = new TextBox();
            this.labelCoefLoss = new TextBox();
            this.labelParamCoefLoss = new TextBox();
            this.txtCoefLoss = new TextBox();
            this.txtSumLoadLoss = new TextBox();
            this.labelParamSumLoadLoss = new TextBox();
            this.labelSumLoadLoss = new TextBox();
            this.buttonCancel = new Button();
            this.txtComment = new RichTextBox();
            this.labelComment = new Label();
            this.buttonPrint = new Button();
            this.tabControl = new TabControl();
            this.tabPageCalc = new TabPage();
            this.txtIsolationLoss = new TextBox();
            this.labelUnitIsolationLoss = new TextBox();
            this.labelIsolationLoss = new TextBox();
            this.txtCoeffIsolation = new TextBox();
            this.labelUnitCoeffIsolation = new TextBox();
            this.labelCoeffIsolataion = new TextBox();
            this.checkBoxIsIsolation = new CheckBox();
            this.labelIsIsolation = new TextBox();
            this.txtNum = new TextBox();
            this.label9 = new Label();
            this.tabPageFile = new TabPage();
            this.dgvFiles = new DataGridViewExcelFilter();
            this.ColumnImage = new DataGridViewImageColumnNotNull();
            this.idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.idCalcDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new DataGridViewLinkColumn();
            this.dateInDgvColumn = new DataGridViewTextBoxColumn();
            this.bindingSourceFile = new BindingSource(this.components);
            this.toolStripFile = new ToolStrip();
            this.toolBtnFileAdd = new ToolStripButton();
            this.toolBtnFileDelete = new ToolStripButton();
            this.toolBtnFileView = new ToolStripButton();
            this.toolBtnFileSave = new ToolStripButton();
            this.tabPageIsolation = new TabPage();
            this.splitContainerIsolation = new SplitContainer();
            this.dataGridView1 = new DataGridView();
            this.sectionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.isolation6DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.isolation10DataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dataSet0 = new DataSet();
            this.dataTableKLIsolation = new DataTable();
            this.dataColumn0 = new DataColumn();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataTableVLIsolation = new DataTable();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataTableSettings = new DataTable();
            this.dataColumn5 = new DataColumn();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.dataGridView2 = new DataGridView();
            this.isolation6DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.isolation10DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((ISupportInitialize)this.dataSetCalc).BeginInit();
            this.toolStripAbnObj.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageCalc.SuspendLayout();
            this.tabPageFile.SuspendLayout();
            ((ISupportInitialize)this.dgvFiles).BeginInit();
            ((ISupportInitialize)this.bindingSourceFile).BeginInit();
            this.toolStripFile.SuspendLayout();
            this.tabPageIsolation.SuspendLayout();
            this.splitContainerIsolation.Panel1.SuspendLayout();
            this.splitContainerIsolation.Panel2.SuspendLayout();
            this.splitContainerIsolation.SuspendLayout();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            ((ISupportInitialize)this.dataSet0).BeginInit();
            ((ISupportInitialize)this.dataTableKLIsolation).BeginInit();
            ((ISupportInitialize)this.dataTableVLIsolation).BeginInit();
            ((ISupportInitialize)this.dataTableSettings).BeginInit();
            ((ISupportInitialize)this.dataGridView2).BeginInit();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата документа";
            this.dateTimePickerDateCalc.DataBindings.Add(new Binding("Value", this.dataSetCalc, "tJ_CalcLoss.DateCalc", true));
            this.dateTimePickerDateCalc.Location = new Point(108, 12);
            this.dateTimePickerDateCalc.Name = "dateTimePickerDateCalc";
            this.dateTimePickerDateCalc.Size = new Size(165, 20);
            this.dateTimePickerDateCalc.TabIndex = 1;
            this.dataSetCalc.DataSetName = "dsCalc";
            this.dataSetCalc.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(417, 14);
            this.label2.Name = "label2";
            this.label2.Size = new Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пользователь";
            this.cmbOwner.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.cmbOwner.DataBindings.Add(new Binding("SelectedValue", this.dataSetCalc, "tJ_CalcLoss.idOwner", true));
            this.cmbOwner.DataSource = this.dataSetCalc;
            this.cmbOwner.DisplayMember = "tUser.Name";
            this.cmbOwner.Enabled = false;
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new Point(503, 11);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new Size(249, 21);
            this.cmbOwner.TabIndex = 3;
            this.cmbOwner.ValueMember = "tUser.IDUser";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя расчета";
            this.txtNameCalc.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtNameCalc.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLoss.nameCalc", true));
            this.txtNameCalc.Location = new Point(108, 38);
            this.txtNameCalc.Name = "txtNameCalc";
            this.txtNameCalc.Size = new Size(644, 20);
            this.txtNameCalc.TabIndex = 5;

            this.cmbAbnObj.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.cmbAbnObj.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbAbnObj.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbAbnObj.DataBindings.Add(new Binding("Tag", this.dataSetCalc, "tJ_CalcLoss.idAbnObj", true));
            this.cmbAbnObj.FormattingEnabled = true;
            this.cmbAbnObj.Location = new Point(108, 76);
            this.cmbAbnObj.Name = "cmbAbnObj";
            this.cmbAbnObj.Size = new Size(617, 21);
            this.cmbAbnObj.TabIndex = 22;
            this.cmbAbnObj.SelectedValueChanged +=new System.EventHandler( this.cmbAbnObj_SelectedValueChanged);
            this.label5.AutoSize = true;
            this.label5.Location = new Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new Size(45, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Объект";
            this.txtAbn.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtAbn.BackColor = SystemColors.Window;
            this.txtAbn.DataBindings.Add(new Binding("Tag", this.dataSetCalc, "tJ_CalcLoss.idAbn", true));
            this.txtAbn.Location = new Point(108, 57);
            this.txtAbn.Name = "txtAbn";
            this.txtAbn.ReadOnly = true;
            this.txtAbn.Size = new Size(617, 20);
            this.txtAbn.TabIndex = 20;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Абонент";
            this.toolStripAbnObj.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.toolStripAbnObj.Dock = DockStyle.None;
            this.toolStripAbnObj.GripStyle = ToolStripGripStyle.Hidden;
            this.toolStripAbnObj.Items.AddRange(new ToolStripItem[]
            {
                this.toolBtnContractor
            });
            this.toolStripAbnObj.Location = new Point(727, 65);
            this.toolStripAbnObj.Name = "toolStripAbnObj";
            this.toolStripAbnObj.Size = new Size(26, 25);
            this.toolStripAbnObj.TabIndex = 23;
            this.toolStripAbnObj.Text = "toolStrip1";
            this.toolBtnContractor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnContractor.Image = global::CalcLossN.Properties.Resources.partners;
            this.toolBtnContractor.ImageTransparentColor = Color.Magenta;
            this.toolBtnContractor.Name = "toolBtnContractor";
            this.toolBtnContractor.Size = new Size(23, 22);
            this.toolBtnContractor.Text = "Выбрать контрагента";
            this.toolBtnContractor.Click +=new System.EventHandler( this.toolBtnContractor_Click);

            this.txtAbnBalance.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtAbnBalance.BackColor = SystemColors.Window;
            this.txtAbnBalance.DataBindings.Add(new Binding("Tag", this.dataSetCalc, "tJ_CalcLoss.idAbnBalance", true));
            this.txtAbnBalance.Location = new Point(108, 95);
            this.txtAbnBalance.Name = "txtAbnBalance";
            this.txtAbnBalance.ReadOnly = true;
            this.txtAbnBalance.Size = new Size(617, 20);
            this.txtAbnBalance.TabIndex = 24;
            this.label6.AutoSize = true;
            this.label6.Location = new Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new Size(44, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Баланс";
            this.buttonAbnBalance.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.buttonAbnBalance.Location = new Point(726, 95);
            this.buttonAbnBalance.Name = "buttonAbnBalance";
            this.buttonAbnBalance.Size = new Size(26, 20);
            this.buttonAbnBalance.TabIndex = 26;
            this.buttonAbnBalance.Text = "...";
            this.buttonAbnBalance.UseVisualStyleBackColor = true;
            this.buttonAbnBalance.Click +=new System.EventHandler( this.buttonAbnBalance_Click);
            this.label7.AutoSize = true;
            this.label7.Location = new Point(12, 117);
            this.label7.Name = "label7";
            this.label7.Size = new Size(68, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Подстанции";
            this.txtTPName.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtTPName.BackColor = SystemColors.Window;
            this.txtTPName.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLoss.tpName", true));
            this.txtTPName.Location = new Point(108, 114);
            this.txtTPName.Name = "txtTPName";
            this.txtTPName.Size = new Size(644, 20);
            this.txtTPName.TabIndex = 28;
            this.label8.AutoSize = true;
            this.label8.Location = new Point(12, 136);
            this.label8.Name = "label8";
            this.label8.Size = new Size(85, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Марка провода";
            this.txtMakeupCable.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtMakeupCable.BackColor = SystemColors.Window;
            this.txtMakeupCable.DataBindings.Add(new Binding("Tag", this.dataSetCalc, "tJ_CalcLossCable.makeupCable", true));
            this.txtMakeupCable.Location = new Point(108, 132);
            this.txtMakeupCable.Name = "txtMakeupCable";
            this.txtMakeupCable.ReadOnly = true;
            this.txtMakeupCable.Size = new Size(617, 20);
            this.txtMakeupCable.TabIndex = 30;
            this.buttonMakeupCable.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.buttonMakeupCable.Location = new Point(726, 132);
            this.buttonMakeupCable.Name = "buttonMakeupCable";
            this.buttonMakeupCable.Size = new Size(26, 20);
            this.buttonMakeupCable.TabIndex = 31;
            this.buttonMakeupCable.Text = "...";
            this.buttonMakeupCable.UseVisualStyleBackColor = true;
            this.buttonMakeupCable.Click +=new System.EventHandler ( this.buttonMakeupCable_Click);
            this.textBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox1.BackColor = SystemColors.ControlLight;
            this.textBox1.Location = new Point(15, 158);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new Size(547, 20);
            this.textBox1.TabIndex = 33;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Длина линии";

            this.textBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox2.BackColor = SystemColors.ControlLight;
            this.textBox2.Location = new Point(561, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new Size(100, 20);
            this.textBox2.TabIndex = 34;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "L, км";
            this.txtLineLenght.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtLineLenght.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.lenghtCable", true));
            this.txtLineLenght.Location = new Point(660, 158);
            this.txtLineLenght.Name = "txtLineLenght";
            this.txtLineLenght.Size = new Size(93, 20);
            this.txtLineLenght.TabIndex = 35;
            this.txtLineLenght.TextAlign = HorizontalAlignment.Right;
            this.txtUdActiveResistance.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtUdActiveResistance.BackColor = SystemColors.Window;
            this.txtUdActiveResistance.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.UdResistance", true));
            this.txtUdActiveResistance.Location = new Point(660, 177);
            this.txtUdActiveResistance.Name = "txtUdActiveResistance";
            this.txtUdActiveResistance.Size = new Size(93, 20);
            this.txtUdActiveResistance.TabIndex = 38;
            this.txtUdActiveResistance.TextAlign = HorizontalAlignment.Right;
            this.textBox4.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox4.BackColor = SystemColors.ControlLight;
            this.textBox4.Location = new Point(561, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new Size(100, 20);
            this.textBox4.TabIndex = 37;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "r0, Ом/км";
            this.textBox5.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox5.BackColor = SystemColors.ControlLight;
            this.textBox5.Location = new Point(15, 177);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new Size(547, 20);
            this.textBox5.TabIndex = 36;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Удельное активное сопротивление линии на 1 км провода";
            this.txtVoltageValue.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtVoltageValue.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.Voltage", true));
            this.txtVoltageValue.Location = new Point(660, 195);
            this.txtVoltageValue.Name = "txtVoltageValue";
            this.txtVoltageValue.Size = new Size(93, 20);
            this.txtVoltageValue.TabIndex = 41;
            this.txtVoltageValue.TextAlign = HorizontalAlignment.Right;
            this.txtVoltageValue.TextChanged +=new System.EventHandler( this.txtVoltageValue_TextChanged);
            this.textBox7.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox7.BackColor = SystemColors.ControlLight;
            this.textBox7.Location = new Point(561, 195);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new Size(100, 20);
            this.textBox7.TabIndex = 40;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "Uср, кВ";
            this.textBox8.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox8.BackColor = SystemColors.ControlLight;
            this.textBox8.Location = new Point(15, 195);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new Size(547, 20);
            this.textBox8.TabIndex = 39;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Среднее напряжение линии";
            this.txtCoeffPowerReactive.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtCoeffPowerReactive.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.CoeffPowerREactive", true));
            this.txtCoeffPowerReactive.Location = new Point(660, 250);
            this.txtCoeffPowerReactive.Name = "txtCoeffPowerReactive";
            this.txtCoeffPowerReactive.Size = new Size(93, 20);
            this.txtCoeffPowerReactive.TabIndex = 50;
            this.txtCoeffPowerReactive.TextAlign = HorizontalAlignment.Right;
            this.textBox10.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox10.BackColor = SystemColors.ControlLight;
            this.textBox10.Location = new Point(561, 250);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new Size(100, 20);
            this.textBox10.TabIndex = 49;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "tg φ";
            this.textBox11.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox11.BackColor = SystemColors.ControlLight;
            this.textBox11.Location = new Point(15, 250);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new Size(547, 20);
            this.textBox11.TabIndex = 48;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "Коэффициент реактивной мощности";
            this.txtPeriod.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtPeriod.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.period", true));
            this.txtPeriod.Location = new Point(660, 232);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new Size(93, 20);
            this.txtPeriod.TabIndex = 47;
            this.txtPeriod.TextAlign = HorizontalAlignment.Right;
            this.textBox13.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox13.BackColor = SystemColors.ControlLight;
            this.textBox13.Location = new Point(561, 232);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new Size(100, 20);
            this.textBox13.TabIndex = 46;
            this.textBox13.TabStop = false;
            this.textBox13.Text = "Т, час";
            this.textBox14.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox14.BackColor = SystemColors.ControlLight;
            this.textBox14.Location = new Point(15, 232);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new Size(547, 20);
            this.textBox14.TabIndex = 45;
            this.textBox14.TabStop = false;
            this.textBox14.Text = "Базовый (расчетный) период";
            this.txtConsumtion.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtConsumtion.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.consumption", true));
            this.txtConsumtion.Location = new Point(660, 213);
            this.txtConsumtion.Name = "txtConsumtion";
            this.txtConsumtion.Size = new Size(93, 20);
            this.txtConsumtion.TabIndex = 44;
            this.txtConsumtion.TextAlign = HorizontalAlignment.Right;
            this.textBox16.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox16.BackColor = SystemColors.ControlLight;
            this.textBox16.Location = new Point(561, 213);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new Size(100, 20);
            this.textBox16.TabIndex = 43;
            this.textBox16.TabStop = false;
            this.textBox16.Text = "Wт, кВт*ч";
            this.textBox17.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox17.BackColor = SystemColors.ControlLight;
            this.textBox17.Location = new Point(15, 213);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new Size(547, 20);
            this.textBox17.TabIndex = 42;
            this.textBox17.TabStop = false;
            this.textBox17.Text = "Потребление активной электроэнергии за базовый период по счетчику";
            this.txtCountChain.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtCountChain.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.CountChain", true));
            this.txtCountChain.Location = new Point(660, 306);
            this.txtCountChain.Name = "txtCountChain";
            this.txtCountChain.Size = new Size(93, 20);
            this.txtCountChain.TabIndex = 59;
            this.txtCountChain.TextAlign = HorizontalAlignment.Right;
            this.textBox19.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox19.BackColor = SystemColors.ControlLight;
            this.textBox19.Location = new Point(561, 306);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new Size(100, 20);
            this.textBox19.TabIndex = 58;
            this.textBox19.TabStop = false;
            this.textBox19.Text = "nц, шт";
            this.textBox20.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox20.BackColor = SystemColors.ControlLight;
            this.textBox20.Location = new Point(15, 306);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new Size(547, 20);
            this.textBox20.TabIndex = 57;
            this.textBox20.TabStop = false;
            this.textBox20.Text = "Количество параллельных цепей, шт.";
            this.txtCoeffDifference.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtCoeffDifference.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.CoeffDifferences", true));
            this.txtCoeffDifference.Location = new Point(660, 288);
            this.txtCoeffDifference.Name = "txtCoeffDifference";
            this.txtCoeffDifference.Size = new Size(93, 20);
            this.txtCoeffDifference.TabIndex = 56;
            this.txtCoeffDifference.TextAlign = HorizontalAlignment.Right;
            this.textBox22.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox22.BackColor = SystemColors.ControlLight;
            this.textBox22.Location = new Point(561, 288);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new Size(100, 20);
            this.textBox22.TabIndex = 55;
            this.textBox22.TabStop = false;
            this.textBox22.Text = "kк, о.е.";
            this.textBox23.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox23.BackColor = SystemColors.ControlLight;
            this.textBox23.Location = new Point(15, 288);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new Size(547, 20);
            this.textBox23.TabIndex = 54;
            this.textBox23.TabStop = false;
            this.textBox23.Text = "Коэффициент учитывающий различие конфигураций графиков активной и реактивной нагрузки";
            this.txtSquareCoeff.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtSquareCoeff.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.SquareCoeffFromGraph", true));
            this.txtSquareCoeff.Location = new Point(660, 269);
            this.txtSquareCoeff.Name = "txtSquareCoeff";
            this.txtSquareCoeff.Size = new Size(93, 20);
            this.txtSquareCoeff.TabIndex = 53;
            this.txtSquareCoeff.TextAlign = HorizontalAlignment.Right;
            this.textBox25.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox25.BackColor = SystemColors.ControlLight;
            this.textBox25.Location = new Point(561, 269);
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new Size(100, 20);
            this.textBox25.TabIndex = 52;
            this.textBox25.TabStop = false;
            this.textBox25.Text = "kφ², о.е.";
            this.textBox26.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox26.BackColor = SystemColors.ControlLight;
            this.textBox26.Location = new Point(15, 269);
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new Size(547, 20);
            this.textBox26.TabIndex = 51;
            this.textBox26.TabStop = false;
            this.textBox26.Text = "Квадрат коэффициента формы графика за базовый период";
            this.buttonOK.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.buttonOK.Location = new Point(19, 645);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new Size(75, 23);
            this.buttonOK.TabIndex = 85;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click +=new System.EventHandler( this.buttonOK_Click);

            this.txtActiveResistance.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtActiveResistance.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.ActiveResistance", true));
            this.txtActiveResistance.Location = new Point(660, 330);
            this.txtActiveResistance.Name = "txtActiveResistance";
            this.txtActiveResistance.ReadOnly = true;
            this.txtActiveResistance.Size = new Size(93, 20);
            this.txtActiveResistance.TabIndex = 63;
            this.txtActiveResistance.TextAlign = HorizontalAlignment.Right;
            this.textBox6.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox6.BackColor = SystemColors.Info;
            this.textBox6.Location = new Point(561, 330);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new Size(100, 20);
            this.textBox6.TabIndex = 62;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "Rкл, Ом";
            this.textBox27.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox27.BackColor = SystemColors.Info;
            this.textBox27.Location = new Point(15, 330);
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            this.textBox27.Size = new Size(547, 20);
            this.textBox27.TabIndex = 61;
            this.textBox27.TabStop = false;
            this.textBox27.Text = "Активное сопротивление линии";
            this.txtLoadAverage.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtLoadAverage.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.LoadAverage", true));
            this.txtLoadAverage.Location = new Point(660, 348);
            this.txtLoadAverage.Name = "txtLoadAverage";
            this.txtLoadAverage.ReadOnly = true;
            this.txtLoadAverage.Size = new Size(93, 20);
            this.txtLoadAverage.TabIndex = 66;
            this.txtLoadAverage.TextAlign = HorizontalAlignment.Right;
            this.textBox18.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox18.BackColor = SystemColors.Info;
            this.textBox18.Location = new Point(561, 348);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new Size(100, 20);
            this.textBox18.TabIndex = 65;
            this.textBox18.TabStop = false;
            this.textBox18.Text = "Рср, МВт";
            this.textBox28.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox28.BackColor = SystemColors.Info;
            this.textBox28.Location = new Point(15, 348);
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.Size = new Size(547, 20);
            this.textBox28.TabIndex = 64;
            this.textBox28.TabStop = false;
            this.textBox28.Text = "Cреднее значение активной мощности за базовый период";
            this.txtLoadPowerLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtLoadPowerLoss.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.LoadPowerLoss", true));
            this.txtLoadPowerLoss.Location = new Point(660, 367);
            this.txtLoadPowerLoss.Name = "txtLoadPowerLoss";
            this.txtLoadPowerLoss.ReadOnly = true;
            this.txtLoadPowerLoss.Size = new Size(93, 20);
            this.txtLoadPowerLoss.TabIndex = 69;
            this.txtLoadPowerLoss.TextAlign = HorizontalAlignment.Right;
            this.textBox12.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox12.BackColor = SystemColors.Info;
            this.textBox12.Location = new Point(561, 367);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new Size(100, 20);
            this.textBox12.TabIndex = 68;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "∆Pср, кВт";
            this.textBox15.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox15.BackColor = SystemColors.Info;
            this.textBox15.Location = new Point(15, 367);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new Size(547, 20);
            this.textBox15.TabIndex = 67;
            this.textBox15.TabStop = false;
            this.textBox15.Text = "Нагрузочные потери мощности в линии";
            this.txtLoadLosses.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtLoadLosses.Location = new Point(660, 385);
            this.txtLoadLosses.Name = "txtLoadLosses";
            this.txtLoadLosses.ReadOnly = true;
            this.txtLoadLosses.Size = new Size(93, 20);
            this.txtLoadLosses.TabIndex = 72;
            this.txtLoadLosses.TextAlign = HorizontalAlignment.Right;
            this.textBox9.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.textBox9.BackColor = SystemColors.Info;
            this.textBox9.Location = new Point(561, 385);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new Size(100, 20);
            this.textBox9.TabIndex = 71;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "∆Wн, кВт*ч";
            this.textBox29.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.textBox29.BackColor = SystemColors.Info;
            this.textBox29.Location = new Point(15, 385);
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            this.textBox29.Size = new Size(547, 20);
            this.textBox29.TabIndex = 70;
            this.textBox29.TabStop = false;
            this.textBox29.Text = "Нагрузочные потери электроэнергии в линии";
            this.txtUnitYearLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtUnitYearLoss.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.UnitYearLoss", true));
            this.txtUnitYearLoss.Location = new Point(660, 404);
            this.txtUnitYearLoss.Name = "txtUnitYearLoss";
            this.txtUnitYearLoss.Size = new Size(93, 20);
            this.txtUnitYearLoss.TabIndex = 75;
            this.txtUnitYearLoss.TextAlign = HorizontalAlignment.Right;
            this.labelParamUnitYearLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.labelParamUnitYearLoss.BackColor = SystemColors.Info;
            this.labelParamUnitYearLoss.Location = new Point(561, 404);
            this.labelParamUnitYearLoss.Name = "labelParamUnitYearLoss";
            this.labelParamUnitYearLoss.ReadOnly = true;
            this.labelParamUnitYearLoss.Size = new Size(100, 20);
            this.labelParamUnitYearLoss.TabIndex = 74;
            this.labelParamUnitYearLoss.TabStop = false;
            this.labelParamUnitYearLoss.Text = "1км/ кВт.ч год";
            this.labelUnitYearLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.labelUnitYearLoss.BackColor = SystemColors.Info;
            this.labelUnitYearLoss.Location = new Point(15, 404);
            this.labelUnitYearLoss.Name = "labelUnitYearLoss";
            this.labelUnitYearLoss.ReadOnly = true;
            this.labelUnitYearLoss.Size = new Size(547, 20);
            this.labelUnitYearLoss.TabIndex = 73;
            this.labelUnitYearLoss.TabStop = false;
            this.labelUnitYearLoss.Text = "Удельные годовые потери электроэнергии от токов утечки ВЛ";
            this.labelParamYearLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.labelParamYearLoss.BackColor = SystemColors.Info;
            this.labelParamYearLoss.Location = new Point(561, 424);
            this.labelParamYearLoss.Name = "labelParamYearLoss";
            this.labelParamYearLoss.ReadOnly = true;
            this.labelParamYearLoss.Size = new Size(100, 20);
            this.labelParamYearLoss.TabIndex = 76;
            this.labelParamYearLoss.TabStop = false;
            this.labelParamYearLoss.Text = "км/ кВт.ч год";
            this.txtYearLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtYearLoss.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.YearLoss", true));
            this.txtYearLoss.Location = new Point(660, 424);
            this.txtYearLoss.Name = "txtYearLoss";
            this.txtYearLoss.ReadOnly = true;
            this.txtYearLoss.Size = new Size(93, 20);
            this.txtYearLoss.TabIndex = 77;
            this.txtYearLoss.TextAlign = HorizontalAlignment.Right;
            this.labelCoefLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.labelCoefLoss.BackColor = SystemColors.Info;
            this.labelCoefLoss.Location = new Point(15, 462);
            this.labelCoefLoss.Name = "labelCoefLoss";
            this.labelCoefLoss.ReadOnly = true;
            this.labelCoefLoss.Size = new Size(547, 20);
            this.labelCoefLoss.TabIndex = 81;
            this.labelCoefLoss.TabStop = false;
            this.labelCoefLoss.Text = "Доля нагрузочных потерь в потребление активной электроэнергии";
            this.labelParamCoefLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.labelParamCoefLoss.BackColor = SystemColors.Info;
            this.labelParamCoefLoss.Location = new Point(561, 462);
            this.labelParamCoefLoss.Name = "labelParamCoefLoss";
            this.labelParamCoefLoss.ReadOnly = true;
            this.labelParamCoefLoss.Size = new Size(100, 20);
            this.labelParamCoefLoss.TabIndex = 82;
            this.labelParamCoefLoss.TabStop = false;
            this.labelParamCoefLoss.Text = "%";
            this.txtCoefLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtCoefLoss.Location = new Point(660, 462);
            this.txtCoefLoss.Name = "txtCoefLoss";
            this.txtCoefLoss.ReadOnly = true;
            this.txtCoefLoss.Size = new Size(93, 20);
            this.txtCoefLoss.TabIndex = 83;
            this.txtCoefLoss.TextAlign = HorizontalAlignment.Right;
            this.txtSumLoadLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtSumLoadLoss.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.SumLoadLosses", true));
            this.txtSumLoadLoss.Location = new Point(660, 443);
            this.txtSumLoadLoss.Name = "txtSumLoadLoss";
            this.txtSumLoadLoss.ReadOnly = true;
            this.txtSumLoadLoss.Size = new Size(93, 20);
            this.txtSumLoadLoss.TabIndex = 80;
            this.txtSumLoadLoss.TextAlign = HorizontalAlignment.Right;
            this.labelParamSumLoadLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.labelParamSumLoadLoss.BackColor = SystemColors.Info;
            this.labelParamSumLoadLoss.Location = new Point(561, 443);
            this.labelParamSumLoadLoss.Name = "labelParamSumLoadLoss";
            this.labelParamSumLoadLoss.ReadOnly = true;
            this.labelParamSumLoadLoss.Size = new Size(100, 20);
            this.labelParamSumLoadLoss.TabIndex = 79;
            this.labelParamSumLoadLoss.TabStop = false;
            this.labelParamSumLoadLoss.Text = "∆Wн, кВт*ч";
            this.labelSumLoadLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.labelSumLoadLoss.BackColor = SystemColors.Info;
            this.labelSumLoadLoss.Location = new Point(15, 443);
            this.labelSumLoadLoss.Name = "labelSumLoadLoss";
            this.labelSumLoadLoss.ReadOnly = true;
            this.labelSumLoadLoss.Size = new Size(547, 20);
            this.labelSumLoadLoss.TabIndex = 78;
            this.labelSumLoadLoss.TabStop = false;
            this.labelSumLoadLoss.Text = "Суммарные потери электроэенргии в ВЛ";
            this.buttonCancel.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.buttonCancel.Location = new Point(682, 645);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new Size(75, 23);
            this.buttonCancel.TabIndex = 86;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click +=new System.EventHandler( this.buttonCancel_Click);
            this.txtComment.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.txtComment.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLoss.Comment", true));
            this.txtComment.Location = new Point(95, 546);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new Size(657, 67);
            this.txtComment.TabIndex = 85;
            this.txtComment.Text = "";
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new Point(13, 543);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new Size(77, 13);
            this.labelComment.TabIndex = 86;
            this.labelComment.Text = "Комментарий";
            this.buttonPrint.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.buttonPrint.Location = new Point(100, 645);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new Size(75, 23);
            this.buttonPrint.TabIndex = 87;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click +=new System.EventHandler( this.buttonPrint_Click);
            this.tabControl.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.tabControl.Controls.Add(this.tabPageCalc);
            this.tabControl.Controls.Add(this.tabPageFile);
            this.tabControl.Controls.Add(this.tabPageIsolation);
            this.tabControl.Location = new Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new Size(764, 639);
            this.tabControl.TabIndex = 88;
            this.tabPageCalc.Controls.Add(this.txtIsolationLoss);
            this.tabPageCalc.Controls.Add(this.labelUnitIsolationLoss);
            this.tabPageCalc.Controls.Add(this.labelIsolationLoss);
            this.tabPageCalc.Controls.Add(this.txtCoeffIsolation);
            this.tabPageCalc.Controls.Add(this.labelUnitCoeffIsolation);
            this.tabPageCalc.Controls.Add(this.labelCoeffIsolataion);
            this.tabPageCalc.Controls.Add(this.checkBoxIsIsolation);
            this.tabPageCalc.Controls.Add(this.labelIsIsolation);
            this.tabPageCalc.Controls.Add(this.txtNum);
            this.tabPageCalc.Controls.Add(this.label9);
            this.tabPageCalc.Controls.Add(this.labelComment);
            this.tabPageCalc.Controls.Add(this.txtComment);
            this.tabPageCalc.Controls.Add(this.txtSumLoadLoss);
            this.tabPageCalc.Controls.Add(this.labelParamSumLoadLoss);
            this.tabPageCalc.Controls.Add(this.labelSumLoadLoss);
            this.tabPageCalc.Controls.Add(this.txtCoefLoss);
            this.tabPageCalc.Controls.Add(this.labelParamCoefLoss);
            this.tabPageCalc.Controls.Add(this.labelCoefLoss);
            this.tabPageCalc.Controls.Add(this.txtYearLoss);
            this.tabPageCalc.Controls.Add(this.labelParamYearLoss);
            this.tabPageCalc.Controls.Add(this.txtUnitYearLoss);
            this.tabPageCalc.Controls.Add(this.labelParamUnitYearLoss);
            this.tabPageCalc.Controls.Add(this.labelUnitYearLoss);
            this.tabPageCalc.Controls.Add(this.txtLoadLosses);
            this.tabPageCalc.Controls.Add(this.textBox9);
            this.tabPageCalc.Controls.Add(this.textBox29);
            this.tabPageCalc.Controls.Add(this.txtLoadPowerLoss);
            this.tabPageCalc.Controls.Add(this.textBox12);
            this.tabPageCalc.Controls.Add(this.textBox15);
            this.tabPageCalc.Controls.Add(this.txtLoadAverage);
            this.tabPageCalc.Controls.Add(this.textBox18);
            this.tabPageCalc.Controls.Add(this.textBox28);
            this.tabPageCalc.Controls.Add(this.txtActiveResistance);
            this.tabPageCalc.Controls.Add(this.textBox6);
            this.tabPageCalc.Controls.Add(this.textBox27);
            this.tabPageCalc.Controls.Add(this.txtCountChain);
            this.tabPageCalc.Controls.Add(this.textBox19);
            this.tabPageCalc.Controls.Add(this.textBox20);
            this.tabPageCalc.Controls.Add(this.txtCoeffDifference);
            this.tabPageCalc.Controls.Add(this.textBox22);
            this.tabPageCalc.Controls.Add(this.textBox23);
            this.tabPageCalc.Controls.Add(this.txtSquareCoeff);
            this.tabPageCalc.Controls.Add(this.textBox25);
            this.tabPageCalc.Controls.Add(this.textBox26);
            this.tabPageCalc.Controls.Add(this.txtCoeffPowerReactive);
            this.tabPageCalc.Controls.Add(this.textBox10);
            this.tabPageCalc.Controls.Add(this.textBox11);
            this.tabPageCalc.Controls.Add(this.txtPeriod);
            this.tabPageCalc.Controls.Add(this.textBox13);
            this.tabPageCalc.Controls.Add(this.textBox14);
            this.tabPageCalc.Controls.Add(this.txtConsumtion);
            this.tabPageCalc.Controls.Add(this.textBox16);
            this.tabPageCalc.Controls.Add(this.textBox17);
            this.tabPageCalc.Controls.Add(this.txtVoltageValue);
            this.tabPageCalc.Controls.Add(this.textBox7);
            this.tabPageCalc.Controls.Add(this.textBox8);
            this.tabPageCalc.Controls.Add(this.txtUdActiveResistance);
            this.tabPageCalc.Controls.Add(this.textBox4);
            this.tabPageCalc.Controls.Add(this.textBox5);
            this.tabPageCalc.Controls.Add(this.txtLineLenght);
            this.tabPageCalc.Controls.Add(this.textBox2);
            this.tabPageCalc.Controls.Add(this.textBox1);
            this.tabPageCalc.Controls.Add(this.buttonMakeupCable);
            this.tabPageCalc.Controls.Add(this.txtMakeupCable);
            this.tabPageCalc.Controls.Add(this.label8);
            this.tabPageCalc.Controls.Add(this.txtTPName);
            this.tabPageCalc.Controls.Add(this.label7);
            this.tabPageCalc.Controls.Add(this.buttonAbnBalance);
            this.tabPageCalc.Controls.Add(this.label6);
            this.tabPageCalc.Controls.Add(this.txtAbnBalance);
            this.tabPageCalc.Controls.Add(this.toolStripAbnObj);
            this.tabPageCalc.Controls.Add(this.cmbAbnObj);
            this.tabPageCalc.Controls.Add(this.label5);
            this.tabPageCalc.Controls.Add(this.txtAbn);
            this.tabPageCalc.Controls.Add(this.label4);
            this.tabPageCalc.Controls.Add(this.txtNameCalc);
            this.tabPageCalc.Controls.Add(this.label3);
            this.tabPageCalc.Controls.Add(this.cmbOwner);
            this.tabPageCalc.Controls.Add(this.label2);
            this.tabPageCalc.Controls.Add(this.dateTimePickerDateCalc);
            this.tabPageCalc.Controls.Add(this.label1);
            this.tabPageCalc.Location = new Point(4, 22);
            this.tabPageCalc.Name = "tabPageCalc";
            this.tabPageCalc.Padding = new Padding(3);
            this.tabPageCalc.Size = new Size(756, 613);
            this.tabPageCalc.TabIndex = 0;
            this.tabPageCalc.Text = "Расчет";
            this.tabPageCalc.UseVisualStyleBackColor = true;
            this.txtIsolationLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtIsolationLoss.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.IsolationLosses", true));
            this.txtIsolationLoss.Enabled = false;
            this.txtIsolationLoss.Location = new Point(660, 520);
            this.txtIsolationLoss.Name = "txtIsolationLoss";
            this.txtIsolationLoss.Size = new Size(93, 20);
            this.txtIsolationLoss.TabIndex = 97;
            this.txtIsolationLoss.TextAlign = HorizontalAlignment.Right;
            this.labelUnitIsolationLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.labelUnitIsolationLoss.BackColor = SystemColors.Info;
            this.labelUnitIsolationLoss.Location = new Point(561, 520);
            this.labelUnitIsolationLoss.Name = "labelUnitIsolationLoss";
            this.labelUnitIsolationLoss.ReadOnly = true;
            this.labelUnitIsolationLoss.Size = new Size(100, 20);
            this.labelUnitIsolationLoss.TabIndex = 96;
            this.labelUnitIsolationLoss.TabStop = false;
            this.labelUnitIsolationLoss.Text = "кВт*ч";
            this.labelIsolationLoss.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.labelIsolationLoss.BackColor = SystemColors.Info;
            this.labelIsolationLoss.Location = new Point(15, 520);
            this.labelIsolationLoss.Name = "labelIsolationLoss";
            this.labelIsolationLoss.ReadOnly = true;
            this.labelIsolationLoss.Size = new Size(547, 20);
            this.labelIsolationLoss.TabIndex = 95;
            this.labelIsolationLoss.TabStop = false;
            this.labelIsolationLoss.Text = "Потери электроэенргии в изоляции (изоляторах)";
            this.txtCoeffIsolation.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtCoeffIsolation.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLossCable.CoeffIsolation", true));
            this.txtCoeffIsolation.Enabled = false;
            this.txtCoeffIsolation.Location = new Point(660, 500);
            this.txtCoeffIsolation.Name = "txtCoeffIsolation";
            this.txtCoeffIsolation.Size = new Size(93, 20);
            this.txtCoeffIsolation.TabIndex = 94;
            this.txtCoeffIsolation.TextAlign = HorizontalAlignment.Right;
            this.labelUnitCoeffIsolation.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.labelUnitCoeffIsolation.BackColor = SystemColors.Info;
            this.labelUnitCoeffIsolation.Location = new Point(561, 500);
            this.labelUnitCoeffIsolation.Name = "labelUnitCoeffIsolation";
            this.labelUnitCoeffIsolation.ReadOnly = true;
            this.labelUnitCoeffIsolation.Size = new Size(100, 20);
            this.labelUnitCoeffIsolation.TabIndex = 93;
            this.labelUnitCoeffIsolation.TabStop = false;
            this.labelUnitCoeffIsolation.Text = "тыс.кВт*ч/км в год";
            this.labelCoeffIsolataion.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.labelCoeffIsolataion.BackColor = SystemColors.Info;
            this.labelCoeffIsolataion.Location = new Point(15, 500);
            this.labelCoeffIsolataion.Name = "labelCoeffIsolataion";
            this.labelCoeffIsolataion.ReadOnly = true;
            this.labelCoeffIsolataion.Size = new Size(547, 20);
            this.labelCoeffIsolataion.TabIndex = 92;
            this.labelCoeffIsolataion.TabStop = false;
            this.labelCoeffIsolataion.Text = "Удельные потери в изоляции (изоляторах)";
            this.checkBoxIsIsolation.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.checkBoxIsIsolation.AutoSize = true;
            this.checkBoxIsIsolation.DataBindings.Add(new Binding("Checked", this.dataSetCalc, "tJ_CalcLossCable.isIsolation", true));
            this.checkBoxIsIsolation.Location = new Point(698, 484);
            this.checkBoxIsIsolation.Name = "checkBoxIsIsolation";
            this.checkBoxIsIsolation.Size = new Size(15, 14);
            this.checkBoxIsIsolation.TabIndex = 91;
            this.checkBoxIsIsolation.UseVisualStyleBackColor = true;
            this.checkBoxIsIsolation.CheckedChanged +=new System.EventHandler( this.checkBoxIsIsolation_CheckedChanged);
            this.labelIsIsolation.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.labelIsIsolation.BackColor = SystemColors.Info;
            this.labelIsIsolation.Location = new Point(15, 481);
            this.labelIsIsolation.Name = "labelIsIsolation";
            this.labelIsIsolation.ReadOnly = true;
            this.labelIsIsolation.Size = new Size(547, 20);
            this.labelIsIsolation.TabIndex = 90;
            this.labelIsIsolation.TabStop = false;
            this.labelIsIsolation.Text = "Потери электроэнергии в изоляторах (изоляции)";
            this.txtNum.DataBindings.Add(new Binding("Text", this.dataSetCalc, "tJ_CalcLoss.num", true));
            this.txtNum.Location = new Point(326, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new Size(85, 20);
            this.txtNum.TabIndex = 89;
            this.label9.AutoSize = true;
            this.label9.Location = new Point(279, 14);
            this.label9.Name = "label9";
            this.label9.Size = new Size(41, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "Номер";
            this.tabPageFile.Controls.Add(this.dgvFiles);
            this.tabPageFile.Controls.Add(this.toolStripFile);
            this.tabPageFile.Location = new Point(4, 22);
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.Padding = new Padding(3);
            this.tabPageFile.Size = new Size(756, 613);
            this.tabPageFile.TabIndex = 1;
            this.tabPageFile.Text = "Файлы";
            this.tabPageFile.UseVisualStyleBackColor = true;
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AllowUserToResizeColumns = false;
            this.dgvFiles.AllowUserToResizeRows = false;
            this.dgvFiles.AllowUserToVisibleColumns = false;
            this.dgvFiles.AutoGenerateColumns = false;
            this.dgvFiles.BackgroundColor = SystemColors.Window;
            this.dgvFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new DataGridViewColumn[]
            {
                this.ColumnImage,
                this.idDataGridViewTextBoxColumn,
                this.idCalcDataGridViewTextBoxColumn,
                this.fileNameDataGridViewTextBoxColumn,
                this.dateInDgvColumn
            });
            this.dgvFiles.DataSource = this.bindingSourceFile;
            this.dgvFiles.Dock = DockStyle.Fill;
            this.dgvFiles.GridColor = SystemColors.Window;
            this.dgvFiles.Location = new Point(3, 28);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowHeadersVisible = false;
            this.dgvFiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new Size(750, 582);
            this.dgvFiles.TabIndex = 2;
            this.dgvFiles.VirtualMode = true;
            this.dgvFiles.CellContentClick +=new DataGridViewCellEventHandler( this.dgvFiles_CellContentClick);
            this.dgvFiles.CellValueNeeded +=new DataGridViewCellValueEventHandler (this.dgvFiles_CellValueNeeded);
            dataGridViewCellStyle.NullValue = null;
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle;
            this.ColumnImage.HeaderText = "";
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Resizable = DataGridViewTriState.False;
            this.ColumnImage.Width = 20;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idCalcDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.idCalcDataGridViewTextBoxColumn.DataPropertyName = "idCalc";
            this.idCalcDataGridViewTextBoxColumn.HeaderText = "idCalc";
            this.idCalcDataGridViewTextBoxColumn.Name = "idCalcDataGridViewTextBoxColumn";
            this.idCalcDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCalcDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.idCalcDataGridViewTextBoxColumn.Visible = false;
            this.fileNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "Файл";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.fileNameDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dateInDgvColumn.DataPropertyName = "dateIn";
            this.dateInDgvColumn.HeaderText = "Дата";
            this.dateInDgvColumn.Name = "dateInDgvColumn";
            this.dateInDgvColumn.ReadOnly = true;
            this.dateInDgvColumn.Width = 120;
            this.bindingSourceFile.DataMember = "tJ_CalcLossFile";
            this.bindingSourceFile.DataSource = this.dataSetCalc;
            this.toolStripFile.Items.AddRange(new ToolStripItem[]
            {
                this.toolBtnFileAdd,
                this.toolBtnFileDelete,
                this.toolBtnFileView,
                this.toolBtnFileSave
            });
            this.toolStripFile.Location = new Point(3, 3);
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new Size(750, 25);
            this.toolStripFile.TabIndex = 1;
            this.toolStripFile.Text = "toolStrip1";

            this.toolBtnFileAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFileAdd.Image = (Image)global::CalcLossN.Properties.Resources.ElementAdd;
            this.toolBtnFileAdd.ImageTransparentColor = Color.Magenta;
            this.toolBtnFileAdd.Name = "toolBtnFileAdd";
            this.toolBtnFileAdd.Size = new Size(23, 22);
            this.toolBtnFileAdd.Text = "Добавить файлы";
            this.toolBtnFileAdd.Click +=new System.EventHandler( this.toolBtnFileAdd_Click);
            this.toolBtnFileDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFileDelete.Image = (Image)global::CalcLossN.Properties.Resources.ElementDel;
            this.toolBtnFileDelete.ImageTransparentColor = Color.Magenta;
            this.toolBtnFileDelete.Name = "toolBtnFileDelete";
            this.toolBtnFileDelete.Size = new Size(23, 22);
            this.toolBtnFileDelete.Text = "Удалить файлы";
            this.toolBtnFileDelete.Click +=new System.EventHandler( this.toolBtnFileDelete_Click);
            this.toolBtnFileView.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFileView.Image = (Image)global::CalcLossN.Properties.Resources.ElementInformation;
            this.toolBtnFileView.ImageTransparentColor = Color.Magenta;
            this.toolBtnFileView.Name = "toolBtnFileView";
            this.toolBtnFileView.Size = new Size(23, 22);
            this.toolBtnFileView.Text = "Просмотр файла";
            this.toolBtnFileView.Click +=new System.EventHandler( this.toolBtnFileView_Click);
            this.toolBtnFileSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFileSave.Image = (Image)global::CalcLossN.Properties.Resources.Export;
            this.toolBtnFileSave.ImageTransparentColor = Color.Magenta;
            this.toolBtnFileSave.Name = "toolBtnFileSave";
            this.toolBtnFileSave.Size = new Size(23, 22);
            this.toolBtnFileSave.Text = "Сохранить файл";
            this.toolBtnFileSave.Click += new System.EventHandler(this.toolBtnFileSave_Click);


            this.tabPageIsolation.Controls.Add(this.splitContainerIsolation);
            this.tabPageIsolation.Location = new Point(4, 22);
            this.tabPageIsolation.Name = "tabPageIsolation";
            this.tabPageIsolation.Padding = new Padding(3);
            this.tabPageIsolation.Size = new Size(756, 613);
            this.tabPageIsolation.TabIndex = 2;
            this.tabPageIsolation.Text = "Изоляция";
            this.tabPageIsolation.UseVisualStyleBackColor = true;
            this.splitContainerIsolation.Dock = DockStyle.Fill;
            this.splitContainerIsolation.Location = new Point(3, 3);
            this.splitContainerIsolation.Name = "splitContainerIsolation";
            this.splitContainerIsolation.Orientation = Orientation.Horizontal;
            this.splitContainerIsolation.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainerIsolation.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainerIsolation.Size = new Size(750, 607);
            this.splitContainerIsolation.SplitterDistance = 341;
            this.splitContainerIsolation.TabIndex = 0;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
                this.sectionDataGridViewTextBoxColumn,
                this.isolation6DataGridViewTextBoxColumn1,
                this.isolation10DataGridViewTextBoxColumn1
            });
            this.dataGridView1.DataMember = "dtKLIsolation";
            this.dataGridView1.DataSource = this.dataSet0;
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.Location = new Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new Size(750, 341);
            this.dataGridView1.TabIndex = 0;
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Сечение, мм2";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.isolation6DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.isolation6DataGridViewTextBoxColumn1.DataPropertyName = "Isolation6";
            this.isolation6DataGridViewTextBoxColumn1.HeaderText = "Уд. потери в изоляции (6кВ)";
            this.isolation6DataGridViewTextBoxColumn1.Name = "isolation6DataGridViewTextBoxColumn1";
            this.isolation10DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.isolation10DataGridViewTextBoxColumn1.DataPropertyName = "Isolation10";
            this.isolation10DataGridViewTextBoxColumn1.HeaderText = "Уд. потери в изоляции (10кВ)";
            this.isolation10DataGridViewTextBoxColumn1.Name = "isolation10DataGridViewTextBoxColumn1";
            this.dataSet0.DataSetName = "NewDataSet";
            this.dataSet0.Tables.AddRange(new DataTable[]
            {
                this.dataTableKLIsolation,
                this.dataTableVLIsolation,
                this.dataTableSettings
            });
            this.dataTableKLIsolation.Columns.AddRange(new DataColumn[]
            {
                this.dataColumn0,
                this.dataColumn1,
                this.dataColumn2
            });
            this.dataTableKLIsolation.TableName = "dtKLIsolation";
            this.dataColumn0.ColumnName = "section";
            this.dataColumn0.DataType = typeof(decimal);
            this.dataColumn1.ColumnName = "Isolation6";
            this.dataColumn1.DataType = typeof(decimal);
            this.dataColumn2.ColumnName = "Isolation10";
            this.dataColumn2.DataType = typeof(decimal);
            this.dataTableVLIsolation.Columns.AddRange(new DataColumn[]
            {
                this.dataColumn3,
                this.dataColumn4
            });
            this.dataTableVLIsolation.TableName = "dtVLIsolation";
            this.dataColumn3.ColumnName = "Isolation6";
            this.dataColumn3.DataType = typeof(decimal);
            this.dataColumn4.ColumnName = "Isolation10";
            this.dataColumn4.DataType = typeof(decimal);
            this.dataTableSettings.Columns.AddRange(new DataColumn[]
            {
                this.dataColumn5,
                this.dataColumn6,
                this.dataColumn7
            });
            this.dataTableSettings.Constraints.AddRange(new Constraint[]
            {
                new UniqueConstraint("Constraint1", new string[]
                {
                    "id"
                }, true)
            });
            this.dataTableSettings.PrimaryKey = new DataColumn[]
            {
                this.dataColumn5
            };
            this.dataTableSettings.TableName = "tSettings";
            this.dataColumn5.AllowDBNull = false;
            this.dataColumn5.AutoIncrement = true;
            this.dataColumn5.ColumnName = "id";
            this.dataColumn5.DataType = typeof(int);
            this.dataColumn6.ColumnName = "settings";
            this.dataColumn7.ColumnName = "module";
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new DataGridViewColumn[]
            {
                this.isolation6DataGridViewTextBoxColumn,
                this.isolation10DataGridViewTextBoxColumn
            });
            this.dataGridView2.DataMember = "dtVLIsolation";
            this.dataGridView2.DataSource = this.dataSet0;
            this.dataGridView2.Dock = DockStyle.Fill;
            this.dataGridView2.Location = new Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new Size(750, 262);
            this.dataGridView2.TabIndex = 0;
            this.isolation6DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.isolation6DataGridViewTextBoxColumn.DataPropertyName = "Isolation6";
            this.isolation6DataGridViewTextBoxColumn.HeaderText = "Уд. потери по изоляторам (6кВ)";
            this.isolation6DataGridViewTextBoxColumn.Name = "isolation6DataGridViewTextBoxColumn";
            this.isolation10DataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.isolation10DataGridViewTextBoxColumn.DataPropertyName = "Isolation10";
            this.isolation10DataGridViewTextBoxColumn.HeaderText = "Уд. потери по изоляторам (10кВ)";
            this.isolation10DataGridViewTextBoxColumn.Name = "isolation10DataGridViewTextBoxColumn";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(764, 671);
            base.Controls.Add(this.tabControl);
            base.Controls.Add(this.buttonOK);
            base.Controls.Add(this.buttonPrint);
            base.Controls.Add(this.buttonCancel);
            base.Icon = (Icon)global::CalcLossN.Properties.Resources.icon1;
            this.MinimumSize = new Size(550, 623);
            base.Name = "FormAddEditCalcCable";
            this.Text = "Расчет потерь в КЛ/ВЛ";
            base.Load +=new System.EventHandler( this.FormAddEditCalcCable_Load);
            ((ISupportInitialize)this.dataSetCalc).EndInit();
            this.toolStripAbnObj.ResumeLayout(false);
            this.toolStripAbnObj.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageCalc.ResumeLayout(false);
            this.tabPageCalc.PerformLayout();
            this.tabPageFile.ResumeLayout(false);
            this.tabPageFile.PerformLayout();
            ((ISupportInitialize)this.dgvFiles).EndInit();
            ((ISupportInitialize)this.bindingSourceFile).EndInit();
            this.toolStripFile.ResumeLayout(false);
            this.toolStripFile.PerformLayout();
            this.tabPageIsolation.ResumeLayout(false);
            this.splitContainerIsolation.Panel1.ResumeLayout(false);
            this.splitContainerIsolation.Panel2.ResumeLayout(false);
            this.splitContainerIsolation.ResumeLayout(false);
            ((ISupportInitialize)this.dataGridView1).EndInit();
            ((ISupportInitialize)this.dataSet0).EndInit();
            ((ISupportInitialize)this.dataTableKLIsolation).EndInit();
            ((ISupportInitialize)this.dataTableVLIsolation).EndInit();
            ((ISupportInitialize)this.dataTableSettings).EndInit();
            ((ISupportInitialize)this.dataGridView2).EndInit();
            base.ResumeLayout(false);
        }



        private Label label1;

        private DateTimePicker dateTimePickerDateCalc;

        private CalcLossN.DataSet.DataSetCalc dataSetCalc;

        private Label label2;

        private ComboBox cmbOwner;

        private Label label3;

        private TextBox txtNameCalc;

        private ComboBox cmbAbnObj;

        private Label label5;

        private TextBox txtAbn;

        private Label label4;

        private ToolStrip toolStripAbnObj;

        private ToolStripButton toolBtnContractor;

        private TextBox txtAbnBalance;

        private Label label6;

        private Button buttonAbnBalance;

        private Label label7;

        private TextBox txtTPName;

        private Label label8;

        private TextBox txtMakeupCable;

        private Button buttonMakeupCable;

        private TextBox textBox1;

        private TextBox textBox2;

        private TextBox txtLineLenght;

        private TextBox txtUdActiveResistance;

        private TextBox textBox4;

        private TextBox textBox5;

        private TextBox txtVoltageValue;

        private TextBox textBox7;

        private TextBox textBox8;

        private TextBox txtCoeffPowerReactive;

        private TextBox textBox10;

        private TextBox textBox11;

        private TextBox txtPeriod;

        private TextBox textBox13;

        private TextBox textBox14;

        private TextBox txtConsumtion;

        private TextBox textBox16;

        private TextBox textBox17;

        private TextBox txtCountChain;

        private TextBox textBox19;

        private TextBox textBox20;

        private TextBox txtCoeffDifference;

        private TextBox textBox22;

        private TextBox textBox23;

        private TextBox txtSquareCoeff;

        private TextBox textBox25;

        private TextBox textBox26;

        private Button buttonOK;

        private TextBox txtActiveResistance;

        private TextBox textBox6;

        private TextBox textBox27;

        private TextBox txtLoadAverage;

        private TextBox textBox18;

        private TextBox textBox28;

        private TextBox txtLoadPowerLoss;

        private TextBox textBox12;

        private TextBox textBox15;

        private TextBox txtLoadLosses;

        private TextBox textBox9;

        private TextBox textBox29;

        private TextBox txtUnitYearLoss;

        private TextBox labelParamUnitYearLoss;

        private TextBox labelUnitYearLoss;

        private TextBox labelParamYearLoss;

        private TextBox txtYearLoss;

        private TextBox labelCoefLoss;

        private TextBox labelParamCoefLoss;

        private TextBox txtCoefLoss;

        private TextBox txtSumLoadLoss;

        private TextBox labelParamSumLoadLoss;

        private TextBox labelSumLoadLoss;

        private Button buttonCancel;

        private RichTextBox txtComment;

        private Label labelComment;

        private Button buttonPrint;

        private TabControl tabControl;

        private TabPage tabPageCalc;

        private TabPage tabPageFile;

        private TextBox txtNum;

        private Label label9;

        private ToolStrip toolStripFile;

        private ToolStripButton toolBtnFileAdd;

        private ToolStripButton toolBtnFileDelete;

        private ToolStripButton toolBtnFileView;

        private ToolStripButton toolBtnFileSave;

        private DataGridViewExcelFilter dgvFiles;

        private BindingSource bindingSourceFile;

        private DataGridViewImageColumnNotNull ColumnImage;

        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn idCalcDataGridViewTextBoxColumn;

        private DataGridViewLinkColumn fileNameDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn dateInDgvColumn;

        private TabPage tabPageIsolation;

        private SplitContainer splitContainerIsolation;

        private DataGridView dataGridView1;

        private DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn isolation6DataGridViewTextBoxColumn1;

        private DataGridViewTextBoxColumn isolation10DataGridViewTextBoxColumn1;

        private DataSet dataSet0;

        private DataTable dataTableKLIsolation;

        private DataColumn dataColumn0;

        private DataColumn dataColumn1;

        private DataColumn dataColumn2;

        private DataTable dataTableVLIsolation;

        private DataColumn dataColumn3;

        private DataColumn dataColumn4;

        private DataGridView dataGridView2;

        private DataGridViewTextBoxColumn isolation6DataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn isolation10DataGridViewTextBoxColumn;

        private DataTable dataTableSettings;

        private DataColumn dataColumn5;

        private DataColumn dataColumn6;

        private DataColumn dataColumn7;

        private TextBox txtIsolationLoss;

        private TextBox labelUnitIsolationLoss;

        private TextBox labelIsolationLoss;

        private TextBox txtCoeffIsolation;

        private TextBox labelUnitCoeffIsolation;

        private TextBox labelCoeffIsolataion;

        private CheckBox checkBoxIsIsolation;

        private TextBox labelIsIsolation;
    }

