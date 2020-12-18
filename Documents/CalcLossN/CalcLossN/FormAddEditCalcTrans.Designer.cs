using ControlsLbr.DataGridViewExcelFilter;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


	public partial class FormAddEditCalcTrans 
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDateCalc = new System.Windows.Forms.DateTimePicker();
            this.dsCalcN = new CalcLossN.DataSet.DataSetCalc();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameCalc = new System.Windows.Forms.TextBox();
            this.cmbAbnObj = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAbn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripAbnObj = new System.Windows.Forms.ToolStrip();
            this.toolBtnContractor = new System.Windows.Forms.ToolStripButton();
            this.txtAbnBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAbnBalance = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTPName = new System.Windows.Forms.TextBox();
            this.labelMakeupTrans = new System.Windows.Forms.Label();
            this.MakeupTrans = new System.Windows.Forms.TextBox();
            this.buttonMakeupTrans = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtRatedPowerTrans1 = new System.Windows.Forms.TextBox();
            this.txtNoLoadLoss = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ShortCircuitLoss = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtCoeffPowerReactive = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtPeriod = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.txtConsumtion = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.txtMiddleVoltage = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.txtCoeffDifference = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.txtSquareCoeff = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.txtLossElectrHH = new System.Windows.Forms.TextBox();
            this.txtParamLossElectrHH = new System.Windows.Forms.TextBox();
            this.lalbelLossElectrHH = new System.Windows.Forms.TextBox();
            this.txtActiveResistance = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.txtLoadPowerLoss = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.txtLoadLosses = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.txtLoadAverage = new System.Windows.Forms.TextBox();
            this.labelParamUnitYearLoss = new System.Windows.Forms.TextBox();
            this.labelUnitYearLoss = new System.Windows.Forms.TextBox();
            this.labelCoefLoss = new System.Windows.Forms.TextBox();
            this.labelParamCoefLoss = new System.Windows.Forms.TextBox();
            this.txtCoefLoss = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageCalc = new System.Windows.Forms.TabPage();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.dgvMonthSum = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDgvColumn = new DataGridViewTextBoxColumn();
            this.labeldgvMonthSum = new System.Windows.Forms.Label();
            this.tabControlTrans = new System.Windows.Forms.TabControl();
            this.tabPageTrans1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddTrans1 = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelTrans1 = new System.Windows.Forms.ToolStripButton();
            this.labelDgvMonth = new System.Windows.Forms.Label();
            this.dgvMonth = new System.Windows.Forms.DataGridView();
            this.colJanuary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFebruary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMarch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApril = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJune = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAugust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeptember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOctober = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNovember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDecember = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRatedVoltage = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageFile = new System.Windows.Forms.TabPage();
            this.dgvFiles = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.ColumnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCalcDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.bindingSourceFile = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripFile = new System.Windows.Forms.ToolStrip();
            this.toolBtnFileAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFileDelete = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFileView = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFileSave = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalcN)).BeginInit();
            this.toolStripAbnObj.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageCalc.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthSum)).BeginInit();
            this.tabControlTrans.SuspendLayout();
            this.tabPageTrans1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).BeginInit();
            this.tabPageFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFile)).BeginInit();
            this.toolStripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата документа";
            // 
            // dateTimePickerDateCalc
            // 
            this.dateTimePickerDateCalc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsCalcN, "tJ_CalcLoss.DateCalc", true));
            this.dateTimePickerDateCalc.Location = new System.Drawing.Point(108, 12);
            this.dateTimePickerDateCalc.Name = "dateTimePickerDateCalc";
            this.dateTimePickerDateCalc.Size = new System.Drawing.Size(165, 20);
            this.dateTimePickerDateCalc.TabIndex = 1;
            // 
            // dsCalcN
            // 
            this.dsCalcN.DataSetName = "DataSetCalc";
            this.dsCalcN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пользователь";
            // 
            // cmbOwner
            // 
            this.cmbOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOwner.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsCalcN, "tJ_CalcLoss.idOwner", true));
            this.cmbOwner.DataSource = this.dsCalcN;
            this.cmbOwner.DisplayMember = "tUser.Name";
            this.cmbOwner.Enabled = false;
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(503, 11);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(544, 21);
            this.cmbOwner.TabIndex = 5;
            this.cmbOwner.ValueMember = "tUser.IDUser";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя расчета";
            // 
            // txtNameCalc
            // 
            this.txtNameCalc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNameCalc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCalcN, "tJ_CalcLoss.nameCalc", true));
            this.txtNameCalc.Location = new System.Drawing.Point(147, 38);
            this.txtNameCalc.Name = "txtNameCalc";
            this.txtNameCalc.Size = new System.Drawing.Size(900, 20);
            this.txtNameCalc.TabIndex = 7;
            // 
            // cmbAbnObj
            // 
            this.cmbAbnObj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAbnObj.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAbnObj.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAbnObj.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dsCalcN, "tJ_CalcLoss.idAbnObj", true));
            this.cmbAbnObj.FormattingEnabled = true;
            this.cmbAbnObj.Location = new System.Drawing.Point(147, 76);
            this.cmbAbnObj.Name = "cmbAbnObj";
            this.cmbAbnObj.Size = new System.Drawing.Size(873, 21);
            this.cmbAbnObj.TabIndex = 12;
            this.cmbAbnObj.SelectedValueChanged += new System.EventHandler(this.cmbAbnObj_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Объект";
            // 
            // txtAbn
            // 
            this.txtAbn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAbn.BackColor = System.Drawing.SystemColors.Window;
            this.txtAbn.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dsCalcN, "tJ_CalcLoss.idAbn", true));
            this.txtAbn.Location = new System.Drawing.Point(147, 57);
            this.txtAbn.Name = "txtAbn";
            this.txtAbn.ReadOnly = true;
            this.txtAbn.Size = new System.Drawing.Size(873, 20);
            this.txtAbn.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Абонент";
            // 
            // toolStripAbnObj
            // 
            this.toolStripAbnObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripAbnObj.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripAbnObj.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripAbnObj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnContractor});
            this.toolStripAbnObj.Location = new System.Drawing.Point(1022, 65);
            this.toolStripAbnObj.Name = "toolStripAbnObj";
            this.toolStripAbnObj.Size = new System.Drawing.Size(26, 25);
            this.toolStripAbnObj.TabIndex = 10;
            this.toolStripAbnObj.Text = "toolStrip1";
            // 
            // toolBtnContractor
            // 
            this.toolBtnContractor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnContractor.Image = global::CalcLossN.Properties.Resources.partners;
            this.toolBtnContractor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnContractor.Name = "toolBtnContractor";
            this.toolBtnContractor.Size = new System.Drawing.Size(23, 22);
            this.toolBtnContractor.Text = "Выбрать контрагента";
            this.toolBtnContractor.Click += new System.EventHandler(this.toolBtnContractor_Click);
            // 
            // txtAbnBalance
            // 
            this.txtAbnBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAbnBalance.BackColor = System.Drawing.SystemColors.Window;
            this.txtAbnBalance.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dsCalcN, "tJ_CalcLoss.idAbnBalance", true));
            this.txtAbnBalance.Location = new System.Drawing.Point(147, 95);
            this.txtAbnBalance.Name = "txtAbnBalance";
            this.txtAbnBalance.ReadOnly = true;
            this.txtAbnBalance.Size = new System.Drawing.Size(873, 20);
            this.txtAbnBalance.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Баланс";
            // 
            // buttonAbnBalance
            // 
            this.buttonAbnBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbnBalance.Location = new System.Drawing.Point(1021, 95);
            this.buttonAbnBalance.Name = "buttonAbnBalance";
            this.buttonAbnBalance.Size = new System.Drawing.Size(26, 20);
            this.buttonAbnBalance.TabIndex = 15;
            this.buttonAbnBalance.Text = "...";
            this.buttonAbnBalance.UseVisualStyleBackColor = true;
            this.buttonAbnBalance.Click += new System.EventHandler(this.buttonAbnBalance_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Подстанции";
            // 
            // txtTPName
            // 
            this.txtTPName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTPName.BackColor = System.Drawing.SystemColors.Window;
            this.txtTPName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCalcN, "tJ_CalcLoss.tpName", true));
            this.txtTPName.Location = new System.Drawing.Point(147, 114);
            this.txtTPName.Name = "txtTPName";
            this.txtTPName.Size = new System.Drawing.Size(900, 20);
            this.txtTPName.TabIndex = 17;
            // 
            // labelMakeupTrans
            // 
            this.labelMakeupTrans.AutoSize = true;
            this.labelMakeupTrans.Location = new System.Drawing.Point(27, 6);
            this.labelMakeupTrans.Name = "labelMakeupTrans";
            this.labelMakeupTrans.Size = new System.Drawing.Size(129, 13);
            this.labelMakeupTrans.TabIndex = 1;
            this.labelMakeupTrans.Text = "Марка трансформатора";
            // 
            // MakeupTrans
            // 
            this.MakeupTrans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MakeupTrans.BackColor = System.Drawing.SystemColors.Window;
            this.MakeupTrans.Location = new System.Drawing.Point(162, 1);
            this.MakeupTrans.Name = "MakeupTrans";
            this.MakeupTrans.ReadOnly = true;
            this.MakeupTrans.Size = new System.Drawing.Size(853, 20);
            this.MakeupTrans.TabIndex = 2;
            this.MakeupTrans.Tag = "MakeupTrans";
            // 
            // buttonMakeupTrans
            // 
            this.buttonMakeupTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMakeupTrans.Location = new System.Drawing.Point(1017, 2);
            this.buttonMakeupTrans.Name = "buttonMakeupTrans";
            this.buttonMakeupTrans.Size = new System.Drawing.Size(26, 20);
            this.buttonMakeupTrans.TabIndex = 3;
            this.buttonMakeupTrans.Text = "...";
            this.buttonMakeupTrans.UseVisualStyleBackColor = true;
            this.buttonMakeupTrans.Click += new System.EventHandler(this.buttonMakeupTrans_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(27, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(827, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Номинальная мощность трансформатора";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(851, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Sном, МВА";
            // 
            // txtRatedPowerTrans1
            // 
            this.txtRatedPowerTrans1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRatedPowerTrans1.Location = new System.Drawing.Point(950, 25);
            this.txtRatedPowerTrans1.Name = "txtRatedPowerTrans1";
            this.txtRatedPowerTrans1.Size = new System.Drawing.Size(93, 20);
            this.txtRatedPowerTrans1.TabIndex = 6;
            this.txtRatedPowerTrans1.Tag = "RatedPower";
            this.txtRatedPowerTrans1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNoLoadLoss
            // 
            this.txtNoLoadLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNoLoadLoss.BackColor = System.Drawing.SystemColors.Window;
            this.txtNoLoadLoss.Location = new System.Drawing.Point(950, 44);
            this.txtNoLoadLoss.Name = "txtNoLoadLoss";
            this.txtNoLoadLoss.Size = new System.Drawing.Size(93, 20);
            this.txtNoLoadLoss.TabIndex = 9;
            this.txtNoLoadLoss.Tag = "NoLoadLoss";
            this.txtNoLoadLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.Location = new System.Drawing.Point(851, 44);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "∆Pхх, кВт";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox5.Location = new System.Drawing.Point(27, 44);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(827, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Потери мощности холостого хода";
            // 
            // ShortCircuitLoss
            // 
            this.ShortCircuitLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortCircuitLoss.Location = new System.Drawing.Point(950, 62);
            this.ShortCircuitLoss.Name = "ShortCircuitLoss";
            this.ShortCircuitLoss.Size = new System.Drawing.Size(93, 20);
            this.ShortCircuitLoss.TabIndex = 12;
            this.ShortCircuitLoss.Tag = "ShortCircuitLoss";
            this.ShortCircuitLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox7.Location = new System.Drawing.Point(851, 62);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 11;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "∆Pкз, кВт";
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox8.Location = new System.Drawing.Point(9, 62);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(845, 20);
            this.textBox8.TabIndex = 10;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "Потери мощности короткого замыкания";
            // 
            // txtCoeffPowerReactive
            // 
            this.txtCoeffPowerReactive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoeffPowerReactive.Location = new System.Drawing.Point(950, 157);
            this.txtCoeffPowerReactive.Name = "txtCoeffPowerReactive";
            this.txtCoeffPowerReactive.Size = new System.Drawing.Size(93, 20);
            this.txtCoeffPowerReactive.TabIndex = 29;
            this.txtCoeffPowerReactive.Tag = "CoeffPowerReactive";
            this.txtCoeffPowerReactive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox10.Location = new System.Drawing.Point(851, 157);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 28;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "tg φ";
            // 
            // textBox11
            // 
            this.textBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox11.Location = new System.Drawing.Point(9, 157);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(845, 20);
            this.textBox11.TabIndex = 27;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "Коэффициент реактивной мощности";
            // 
            // txtPeriod
            // 
            this.txtPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPeriod.Location = new System.Drawing.Point(950, 137);
            this.txtPeriod.Name = "txtPeriod";
            this.txtPeriod.Size = new System.Drawing.Size(93, 20);
            this.txtPeriod.TabIndex = 26;
            this.txtPeriod.Tag = "Period";
            this.txtPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox13.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox13.Location = new System.Drawing.Point(851, 137);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 25;
            this.textBox13.TabStop = false;
            this.textBox13.Text = "Т, час";
            // 
            // textBox14
            // 
            this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox14.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox14.Location = new System.Drawing.Point(9, 137);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(845, 20);
            this.textBox14.TabIndex = 24;
            this.textBox14.TabStop = false;
            this.textBox14.Text = "Базовый (расчетный) период";
            // 
            // txtConsumtion
            // 
            this.txtConsumtion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsumtion.Location = new System.Drawing.Point(950, 80);
            this.txtConsumtion.Name = "txtConsumtion";
            this.txtConsumtion.Size = new System.Drawing.Size(93, 20);
            this.txtConsumtion.TabIndex = 18;
            this.txtConsumtion.Tag = "Consumption";
            this.txtConsumtion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox16
            // 
            this.textBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox16.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox16.Location = new System.Drawing.Point(851, 80);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 17;
            this.textBox16.TabStop = false;
            this.textBox16.Text = "Wт, кВт*ч";
            // 
            // textBox17
            // 
            this.textBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox17.Location = new System.Drawing.Point(9, 80);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(845, 20);
            this.textBox17.TabIndex = 16;
            this.textBox17.TabStop = false;
            this.textBox17.Text = "Потребление активной электроэнергии за базовый период по счетчику";
            // 
            // txtMiddleVoltage
            // 
            this.txtMiddleVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMiddleVoltage.Location = new System.Drawing.Point(950, 117);
            this.txtMiddleVoltage.Name = "txtMiddleVoltage";
            this.txtMiddleVoltage.Size = new System.Drawing.Size(93, 20);
            this.txtMiddleVoltage.TabIndex = 23;
            this.txtMiddleVoltage.Tag = "MiddleVoltage";
            this.txtMiddleVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox19
            // 
            this.textBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox19.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox19.Location = new System.Drawing.Point(851, 117);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 22;
            this.textBox19.TabStop = false;
            this.textBox19.Text = "Uср, кВ";
            // 
            // textBox20
            // 
            this.textBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox20.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox20.Location = new System.Drawing.Point(9, 117);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(845, 20);
            this.textBox20.TabIndex = 21;
            this.textBox20.TabStop = false;
            this.textBox20.Text = "Среднее напряжение на высшей стороне трансформатора за базовый период";
            // 
            // txtCoeffDifference
            // 
            this.txtCoeffDifference.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoeffDifference.Location = new System.Drawing.Point(950, 195);
            this.txtCoeffDifference.Name = "txtCoeffDifference";
            this.txtCoeffDifference.Size = new System.Drawing.Size(93, 20);
            this.txtCoeffDifference.TabIndex = 35;
            this.txtCoeffDifference.Tag = "CoeffDifference";
            this.txtCoeffDifference.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox22
            // 
            this.textBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox22.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox22.Location = new System.Drawing.Point(851, 195);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(100, 20);
            this.textBox22.TabIndex = 34;
            this.textBox22.TabStop = false;
            this.textBox22.Text = "kк, о.е.";
            // 
            // textBox23
            // 
            this.textBox23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox23.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox23.Location = new System.Drawing.Point(9, 195);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(845, 20);
            this.textBox23.TabIndex = 33;
            this.textBox23.TabStop = false;
            this.textBox23.Text = "Коэффициент учитывающий различие конфигураций графиков активной и реактивной нагр" +
    "узки";
            // 
            // txtSquareCoeff
            // 
            this.txtSquareCoeff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSquareCoeff.Location = new System.Drawing.Point(950, 176);
            this.txtSquareCoeff.Name = "txtSquareCoeff";
            this.txtSquareCoeff.Size = new System.Drawing.Size(93, 20);
            this.txtSquareCoeff.TabIndex = 32;
            this.txtSquareCoeff.Tag = "SquareCoeffFromGraph";
            this.txtSquareCoeff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox25
            // 
            this.textBox25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox25.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox25.Location = new System.Drawing.Point(851, 176);
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(100, 20);
            this.textBox25.TabIndex = 31;
            this.textBox25.TabStop = false;
            this.textBox25.Text = "kφ², о.е.";
            // 
            // textBox26
            // 
            this.textBox26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox26.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox26.Location = new System.Drawing.Point(9, 176);
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(845, 20);
            this.textBox26.TabIndex = 30;
            this.textBox26.TabStop = false;
            this.textBox26.Text = "Квадрат коэффициента формы графика за базовый период";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.Location = new System.Drawing.Point(19, 734);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // txtLossElectrHH
            // 
            this.txtLossElectrHH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLossElectrHH.Location = new System.Drawing.Point(950, 214);
            this.txtLossElectrHH.Name = "txtLossElectrHH";
            this.txtLossElectrHH.ReadOnly = true;
            this.txtLossElectrHH.Size = new System.Drawing.Size(93, 20);
            this.txtLossElectrHH.TabIndex = 38;
            this.txtLossElectrHH.Tag = "LossElectrHH";
            this.txtLossElectrHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLossElectrHH.TextChanged += new System.EventHandler(this.txtLossElectrHH_TextChanged);
            // 
            // txtParamLossElectrHH
            // 
            this.txtParamLossElectrHH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParamLossElectrHH.BackColor = System.Drawing.SystemColors.Info;
            this.txtParamLossElectrHH.Location = new System.Drawing.Point(851, 214);
            this.txtParamLossElectrHH.Name = "txtParamLossElectrHH";
            this.txtParamLossElectrHH.ReadOnly = true;
            this.txtParamLossElectrHH.Size = new System.Drawing.Size(100, 20);
            this.txtParamLossElectrHH.TabIndex = 37;
            this.txtParamLossElectrHH.TabStop = false;
            this.txtParamLossElectrHH.Text = "∆Wхх, кВт*ч";
            // 
            // lalbelLossElectrHH
            // 
            this.lalbelLossElectrHH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lalbelLossElectrHH.BackColor = System.Drawing.SystemColors.Info;
            this.lalbelLossElectrHH.Location = new System.Drawing.Point(9, 214);
            this.lalbelLossElectrHH.Name = "lalbelLossElectrHH";
            this.lalbelLossElectrHH.ReadOnly = true;
            this.lalbelLossElectrHH.Size = new System.Drawing.Size(845, 20);
            this.lalbelLossElectrHH.TabIndex = 36;
            this.lalbelLossElectrHH.TabStop = false;
            this.lalbelLossElectrHH.Text = "Потери электроэнергии холостого хода в силовом трансформаторе";
            // 
            // txtActiveResistance
            // 
            this.txtActiveResistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActiveResistance.Location = new System.Drawing.Point(951, 10);
            this.txtActiveResistance.Name = "txtActiveResistance";
            this.txtActiveResistance.ReadOnly = true;
            this.txtActiveResistance.Size = new System.Drawing.Size(93, 20);
            this.txtActiveResistance.TabIndex = 2;
            this.txtActiveResistance.Tag = "ActiveResistance";
            this.txtActiveResistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox18
            // 
            this.textBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox18.BackColor = System.Drawing.SystemColors.Info;
            this.textBox18.Location = new System.Drawing.Point(852, 10);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 1;
            this.textBox18.TabStop = false;
            this.textBox18.Text = "Rт, Ом/фазу";
            // 
            // textBox28
            // 
            this.textBox28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox28.BackColor = System.Drawing.SystemColors.Info;
            this.textBox28.Location = new System.Drawing.Point(11, 10);
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.Size = new System.Drawing.Size(842, 20);
            this.textBox28.TabIndex = 0;
            this.textBox28.TabStop = false;
            this.textBox28.Text = "Активное сопротивление трансформатора";
            // 
            // txtLoadPowerLoss
            // 
            this.txtLoadPowerLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoadPowerLoss.Location = new System.Drawing.Point(951, 49);
            this.txtLoadPowerLoss.Name = "txtLoadPowerLoss";
            this.txtLoadPowerLoss.ReadOnly = true;
            this.txtLoadPowerLoss.Size = new System.Drawing.Size(93, 20);
            this.txtLoadPowerLoss.TabIndex = 8;
            this.txtLoadPowerLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.BackColor = System.Drawing.SystemColors.Info;
            this.textBox12.Location = new System.Drawing.Point(852, 49);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 7;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "∆Pср, кВт";
            // 
            // textBox15
            // 
            this.textBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox15.BackColor = System.Drawing.SystemColors.Info;
            this.textBox15.Location = new System.Drawing.Point(11, 49);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(842, 20);
            this.textBox15.TabIndex = 6;
            this.textBox15.TabStop = false;
            this.textBox15.Text = "Нагрузочные потери мощности в трансформаторе";
            // 
            // txtLoadLosses
            // 
            this.txtLoadLosses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoadLosses.Location = new System.Drawing.Point(951, 67);
            this.txtLoadLosses.Name = "txtLoadLosses";
            this.txtLoadLosses.ReadOnly = true;
            this.txtLoadLosses.Size = new System.Drawing.Size(93, 20);
            this.txtLoadLosses.TabIndex = 11;
            this.txtLoadLosses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox9
            // 
            this.textBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox9.BackColor = System.Drawing.SystemColors.Info;
            this.textBox9.Location = new System.Drawing.Point(852, 67);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 10;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "∆Wн, кВт*ч";
            // 
            // textBox29
            // 
            this.textBox29.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox29.BackColor = System.Drawing.SystemColors.Info;
            this.textBox29.Location = new System.Drawing.Point(11, 67);
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            this.textBox29.Size = new System.Drawing.Size(842, 20);
            this.textBox29.TabIndex = 9;
            this.textBox29.TabStop = false;
            this.textBox29.Text = "Нагрузочные потери электроэнергии в трансформаторе";
            // 
            // txtLoadAverage
            // 
            this.txtLoadAverage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoadAverage.Location = new System.Drawing.Point(951, 29);
            this.txtLoadAverage.Name = "txtLoadAverage";
            this.txtLoadAverage.ReadOnly = true;
            this.txtLoadAverage.Size = new System.Drawing.Size(93, 20);
            this.txtLoadAverage.TabIndex = 5;
            this.txtLoadAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelParamUnitYearLoss
            // 
            this.labelParamUnitYearLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParamUnitYearLoss.BackColor = System.Drawing.SystemColors.Info;
            this.labelParamUnitYearLoss.Location = new System.Drawing.Point(852, 29);
            this.labelParamUnitYearLoss.Name = "labelParamUnitYearLoss";
            this.labelParamUnitYearLoss.ReadOnly = true;
            this.labelParamUnitYearLoss.Size = new System.Drawing.Size(100, 20);
            this.labelParamUnitYearLoss.TabIndex = 4;
            this.labelParamUnitYearLoss.TabStop = false;
            this.labelParamUnitYearLoss.Text = "Рср, МВт";
            // 
            // labelUnitYearLoss
            // 
            this.labelUnitYearLoss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUnitYearLoss.BackColor = System.Drawing.SystemColors.Info;
            this.labelUnitYearLoss.Location = new System.Drawing.Point(11, 29);
            this.labelUnitYearLoss.Name = "labelUnitYearLoss";
            this.labelUnitYearLoss.ReadOnly = true;
            this.labelUnitYearLoss.Size = new System.Drawing.Size(842, 20);
            this.labelUnitYearLoss.TabIndex = 3;
            this.labelUnitYearLoss.TabStop = false;
            this.labelUnitYearLoss.Text = "Cреднее значение активной мощности за базовый период";
            // 
            // labelCoefLoss
            // 
            this.labelCoefLoss.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCoefLoss.BackColor = System.Drawing.SystemColors.Info;
            this.labelCoefLoss.Location = new System.Drawing.Point(11, 86);
            this.labelCoefLoss.Name = "labelCoefLoss";
            this.labelCoefLoss.ReadOnly = true;
            this.labelCoefLoss.Size = new System.Drawing.Size(842, 20);
            this.labelCoefLoss.TabIndex = 12;
            this.labelCoefLoss.TabStop = false;
            this.labelCoefLoss.Text = "Доля нагрузочных потерь в потребление активной электроэнергии";
            // 
            // labelParamCoefLoss
            // 
            this.labelParamCoefLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParamCoefLoss.BackColor = System.Drawing.SystemColors.Info;
            this.labelParamCoefLoss.Location = new System.Drawing.Point(852, 86);
            this.labelParamCoefLoss.Name = "labelParamCoefLoss";
            this.labelParamCoefLoss.ReadOnly = true;
            this.labelParamCoefLoss.Size = new System.Drawing.Size(100, 20);
            this.labelParamCoefLoss.TabIndex = 13;
            this.labelParamCoefLoss.TabStop = false;
            this.labelParamCoefLoss.Text = "%";
            // 
            // txtCoefLoss
            // 
            this.txtCoefLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCoefLoss.Location = new System.Drawing.Point(951, 86);
            this.txtCoefLoss.Name = "txtCoefLoss";
            this.txtCoefLoss.ReadOnly = true;
            this.txtCoefLoss.Size = new System.Drawing.Size(93, 20);
            this.txtCoefLoss.TabIndex = 14;
            this.txtCoefLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(977, 734);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCalcN, "tJ_CalcLoss.Comment", true));
            this.txtComment.Location = new System.Drawing.Point(91, 112);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(952, 26);
            this.txtComment.TabIndex = 16;
            this.txtComment.Text = "";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(8, 109);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(77, 13);
            this.labelComment.TabIndex = 15;
            this.labelComment.Text = "Комментарий";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrint.Location = new System.Drawing.Point(100, 734);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 2;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageCalc);
            this.tabControl.Controls.Add(this.tabPageFile);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1059, 728);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageCalc
            // 
            this.tabPageCalc.Controls.Add(this.panelBottom);
            this.tabPageCalc.Controls.Add(this.dgvMonthSum);
            this.tabPageCalc.Controls.Add(this.labeldgvMonthSum);
            this.tabPageCalc.Controls.Add(this.tabControlTrans);
            this.tabPageCalc.Controls.Add(this.txtNum);
            this.tabPageCalc.Controls.Add(this.label9);
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
            this.tabPageCalc.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalc.Name = "tabPageCalc";
            this.tabPageCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalc.Size = new System.Drawing.Size(1051, 702);
            this.tabPageCalc.TabIndex = 0;
            this.tabPageCalc.Text = "Расчет";
            this.tabPageCalc.UseVisualStyleBackColor = true;
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.Controls.Add(this.txtComment);
            this.panelBottom.Controls.Add(this.textBox28);
            this.panelBottom.Controls.Add(this.textBox18);
            this.panelBottom.Controls.Add(this.txtActiveResistance);
            this.panelBottom.Controls.Add(this.textBox15);
            this.panelBottom.Controls.Add(this.textBox12);
            this.panelBottom.Controls.Add(this.labelComment);
            this.panelBottom.Controls.Add(this.txtLoadPowerLoss);
            this.panelBottom.Controls.Add(this.textBox29);
            this.panelBottom.Controls.Add(this.txtCoefLoss);
            this.panelBottom.Controls.Add(this.textBox9);
            this.panelBottom.Controls.Add(this.labelParamCoefLoss);
            this.panelBottom.Controls.Add(this.txtLoadLosses);
            this.panelBottom.Controls.Add(this.labelCoefLoss);
            this.panelBottom.Controls.Add(this.labelUnitYearLoss);
            this.panelBottom.Controls.Add(this.txtLoadAverage);
            this.panelBottom.Controls.Add(this.labelParamUnitYearLoss);
            this.panelBottom.Location = new System.Drawing.Point(0, 557);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1051, 145);
            this.panelBottom.TabIndex = 21;
            // 
            // dgvMonthSum
            // 
            this.dgvMonthSum.AllowUserToAddRows = false;
            this.dgvMonthSum.AllowUserToDeleteRows = false;
            this.dgvMonthSum.AllowUserToResizeColumns = false;
            this.dgvMonthSum.AllowUserToResizeRows = false;
            this.dgvMonthSum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonthSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonthSum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvMonthSum.Location = new System.Drawing.Point(13, 498);
            this.dgvMonthSum.Name = "dgvMonthSum";
            this.dgvMonthSum.ReadOnly = true;
            this.dgvMonthSum.RowHeadersVisible = false;
            this.dgvMonthSum.Size = new System.Drawing.Size(1034, 57);
            this.dgvMonthSum.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Январь";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Февраль";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Март";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Апрель";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Май";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Июнь";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Июль";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "Август";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.HeaderText = "Сентябрь";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.HeaderText = "Октябрь";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.HeaderText = "Ноябрь";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.HeaderText = "Декабрь";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // labeldgvMonthSum
            // 
            this.labeldgvMonthSum.AutoSize = true;
            this.labeldgvMonthSum.Location = new System.Drawing.Point(12, 482);
            this.labeldgvMonthSum.Name = "labeldgvMonthSum";
            this.labeldgvMonthSum.Size = new System.Drawing.Size(403, 13);
            this.labeldgvMonthSum.TabIndex = 19;
            this.labeldgvMonthSum.Text = "Суммарные потери электроэнергии холостого хода с разбивкой по месяцам:";
            // 
            // tabControlTrans
            // 
            this.tabControlTrans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlTrans.Controls.Add(this.tabPageTrans1);
            this.tabControlTrans.Location = new System.Drawing.Point(0, 140);
            this.tabControlTrans.Name = "tabControlTrans";
            this.tabControlTrans.SelectedIndex = 0;
            this.tabControlTrans.Size = new System.Drawing.Size(1055, 339);
            this.tabControlTrans.TabIndex = 18;
            // 
            // tabPageTrans1
            // 
            this.tabPageTrans1.Controls.Add(this.toolStrip1);
            this.tabPageTrans1.Controls.Add(this.labelMakeupTrans);
            this.tabPageTrans1.Controls.Add(this.labelDgvMonth);
            this.tabPageTrans1.Controls.Add(this.MakeupTrans);
            this.tabPageTrans1.Controls.Add(this.dgvMonth);
            this.tabPageTrans1.Controls.Add(this.buttonMakeupTrans);
            this.tabPageTrans1.Controls.Add(this.txtRatedVoltage);
            this.tabPageTrans1.Controls.Add(this.textBox1);
            this.tabPageTrans1.Controls.Add(this.textBox21);
            this.tabPageTrans1.Controls.Add(this.textBox2);
            this.tabPageTrans1.Controls.Add(this.textBox24);
            this.tabPageTrans1.Controls.Add(this.txtRatedPowerTrans1);
            this.tabPageTrans1.Controls.Add(this.textBox5);
            this.tabPageTrans1.Controls.Add(this.textBox4);
            this.tabPageTrans1.Controls.Add(this.txtNoLoadLoss);
            this.tabPageTrans1.Controls.Add(this.textBox8);
            this.tabPageTrans1.Controls.Add(this.textBox7);
            this.tabPageTrans1.Controls.Add(this.ShortCircuitLoss);
            this.tabPageTrans1.Controls.Add(this.textBox17);
            this.tabPageTrans1.Controls.Add(this.textBox16);
            this.tabPageTrans1.Controls.Add(this.txtConsumtion);
            this.tabPageTrans1.Controls.Add(this.textBox14);
            this.tabPageTrans1.Controls.Add(this.textBox13);
            this.tabPageTrans1.Controls.Add(this.txtPeriod);
            this.tabPageTrans1.Controls.Add(this.textBox11);
            this.tabPageTrans1.Controls.Add(this.textBox10);
            this.tabPageTrans1.Controls.Add(this.txtCoeffPowerReactive);
            this.tabPageTrans1.Controls.Add(this.textBox26);
            this.tabPageTrans1.Controls.Add(this.textBox25);
            this.tabPageTrans1.Controls.Add(this.txtSquareCoeff);
            this.tabPageTrans1.Controls.Add(this.textBox23);
            this.tabPageTrans1.Controls.Add(this.textBox22);
            this.tabPageTrans1.Controls.Add(this.txtCoeffDifference);
            this.tabPageTrans1.Controls.Add(this.textBox20);
            this.tabPageTrans1.Controls.Add(this.txtLossElectrHH);
            this.tabPageTrans1.Controls.Add(this.textBox19);
            this.tabPageTrans1.Controls.Add(this.txtParamLossElectrHH);
            this.tabPageTrans1.Controls.Add(this.txtMiddleVoltage);
            this.tabPageTrans1.Controls.Add(this.lalbelLossElectrHH);
            this.tabPageTrans1.Location = new System.Drawing.Point(4, 22);
            this.tabPageTrans1.Name = "tabPageTrans1";
            this.tabPageTrans1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTrans1.Size = new System.Drawing.Size(1047, 313);
            this.tabPageTrans1.TabIndex = 0;
            this.tabPageTrans1.Text = "Т1";
            this.tabPageTrans1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddTrans1,
            this.toolBtnDelTrans1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolBtnAddTrans1
            // 
            this.toolBtnAddTrans1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddTrans1.Image = global::CalcLossN.Properties.Resources.ElementAdd;
            this.toolBtnAddTrans1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddTrans1.Name = "toolBtnAddTrans1";
            this.toolBtnAddTrans1.Size = new System.Drawing.Size(22, 20);
            this.toolBtnAddTrans1.Text = "Добавить трансформатор";
            this.toolBtnAddTrans1.Click += new System.EventHandler(this.toolBtnAddTrans1_Click);
            // 
            // toolBtnDelTrans1
            // 
            this.toolBtnDelTrans1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelTrans1.Image = global::CalcLossN.Properties.Resources.ElementDel;
            this.toolBtnDelTrans1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelTrans1.Name = "toolBtnDelTrans1";
            this.toolBtnDelTrans1.Size = new System.Drawing.Size(22, 20);
            this.toolBtnDelTrans1.Text = "Удалить трансформатор";
            this.toolBtnDelTrans1.Visible = false;
            this.toolBtnDelTrans1.Click += new System.EventHandler(this.toolBtnDelTrans1_Click);
            // 
            // labelDgvMonth
            // 
            this.labelDgvMonth.AutoSize = true;
            this.labelDgvMonth.Location = new System.Drawing.Point(6, 237);
            this.labelDgvMonth.Name = "labelDgvMonth";
            this.labelDgvMonth.Size = new System.Drawing.Size(342, 13);
            this.labelDgvMonth.TabIndex = 0;
            this.labelDgvMonth.Text = "Потери электроэнергии холостого хода с разбивкой по месяцам:";
            // 
            // dgvMonth
            // 
            this.dgvMonth.AllowUserToAddRows = false;
            this.dgvMonth.AllowUserToDeleteRows = false;
            this.dgvMonth.AllowUserToResizeColumns = false;
            this.dgvMonth.AllowUserToResizeRows = false;
            this.dgvMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colJanuary,
            this.colFebruary,
            this.colMarch,
            this.colApril,
            this.colMay,
            this.colJune,
            this.colJule,
            this.colAugust,
            this.colSeptember,
            this.colOctober,
            this.colNovember,
            this.colDecember});
            this.dgvMonth.Location = new System.Drawing.Point(9, 253);
            this.dgvMonth.Name = "dgvMonth";
            this.dgvMonth.ReadOnly = true;
            this.dgvMonth.RowHeadersVisible = false;
            this.dgvMonth.Size = new System.Drawing.Size(1034, 57);
            this.dgvMonth.TabIndex = 1;
            this.dgvMonth.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonth_CellValueChanged);
            // 
            // colJanuary
            // 
            this.colJanuary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJanuary.HeaderText = "Январь";
            this.colJanuary.Name = "colJanuary";
            this.colJanuary.ReadOnly = true;
            // 
            // colFebruary
            // 
            this.colFebruary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFebruary.HeaderText = "Февраль";
            this.colFebruary.Name = "colFebruary";
            this.colFebruary.ReadOnly = true;
            // 
            // colMarch
            // 
            this.colMarch.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMarch.HeaderText = "Март";
            this.colMarch.Name = "colMarch";
            this.colMarch.ReadOnly = true;
            // 
            // colApril
            // 
            this.colApril.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colApril.HeaderText = "Апрель";
            this.colApril.Name = "colApril";
            this.colApril.ReadOnly = true;
            // 
            // colMay
            // 
            this.colMay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMay.HeaderText = "Май";
            this.colMay.Name = "colMay";
            this.colMay.ReadOnly = true;
            // 
            // colJune
            // 
            this.colJune.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJune.HeaderText = "Июнь";
            this.colJune.Name = "colJune";
            this.colJune.ReadOnly = true;
            // 
            // colJule
            // 
            this.colJule.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colJule.HeaderText = "Июль";
            this.colJule.Name = "colJule";
            this.colJule.ReadOnly = true;
            // 
            // colAugust
            // 
            this.colAugust.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAugust.HeaderText = "Август";
            this.colAugust.Name = "colAugust";
            this.colAugust.ReadOnly = true;
            // 
            // colSeptember
            // 
            this.colSeptember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSeptember.HeaderText = "Сентябрь";
            this.colSeptember.Name = "colSeptember";
            this.colSeptember.ReadOnly = true;
            // 
            // colOctober
            // 
            this.colOctober.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOctober.HeaderText = "Октябрь";
            this.colOctober.Name = "colOctober";
            this.colOctober.ReadOnly = true;
            // 
            // colNovember
            // 
            this.colNovember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNovember.HeaderText = "Ноябрь";
            this.colNovember.Name = "colNovember";
            this.colNovember.ReadOnly = true;
            // 
            // colDecember
            // 
            this.colDecember.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDecember.HeaderText = "Декабрь";
            this.colDecember.Name = "colDecember";
            this.colDecember.ReadOnly = true;
            // 
            // txtRatedVoltage
            // 
            this.txtRatedVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRatedVoltage.Location = new System.Drawing.Point(950, 99);
            this.txtRatedVoltage.Name = "txtRatedVoltage";
            this.txtRatedVoltage.Size = new System.Drawing.Size(93, 20);
            this.txtRatedVoltage.TabIndex = 20;
            this.txtRatedVoltage.Tag = "RatedVoltage";
            this.txtRatedVoltage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox21
            // 
            this.textBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox21.Location = new System.Drawing.Point(851, 99);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(100, 20);
            this.textBox21.TabIndex = 19;
            this.textBox21.TabStop = false;
            this.textBox21.Text = "Uном, кВ";
            // 
            // textBox24
            // 
            this.textBox24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox24.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox24.Location = new System.Drawing.Point(9, 99);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(845, 20);
            this.textBox24.TabIndex = 15;
            this.textBox24.TabStop = false;
            this.textBox24.Text = "Номинальное напряжение высшей обмотки трансформатора";
            // 
            // txtNum
            // 
            this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsCalcN, "tJ_CalcLoss.num", true));
            this.txtNum.Location = new System.Drawing.Point(326, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(85, 20);
            this.txtNum.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Номер";
            // 
            // tabPageFile
            // 
            this.tabPageFile.Controls.Add(this.dgvFiles);
            this.tabPageFile.Controls.Add(this.toolStripFile);
            this.tabPageFile.Location = new System.Drawing.Point(4, 22);
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFile.Size = new System.Drawing.Size(1054, 702);
            this.tabPageFile.TabIndex = 1;
            this.tabPageFile.Text = "Файлы";
            this.tabPageFile.UseVisualStyleBackColor = true;
            // 
            // dgvFiles
            // 
            this.dgvFiles.AllowUserToAddRows = false;
            this.dgvFiles.AllowUserToDeleteRows = false;
            this.dgvFiles.AllowUserToResizeColumns = false;
            this.dgvFiles.AllowUserToResizeRows = false;
            this.dgvFiles.AllowUserToVisibleColumns = false;
            this.dgvFiles.AutoGenerateColumns = false;
            this.dgvFiles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImage,
            this.idDataGridViewTextBoxColumn,
            this.idCalcDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.dateInDgvColumn});

            this.dgvFiles.DataSource = this.bindingSourceFile;
            this.dgvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFiles.GridColor = System.Drawing.SystemColors.Window;
            this.dgvFiles.Location = new System.Drawing.Point(3, 28);
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.ReadOnly = true;
            this.dgvFiles.RowHeadersVisible = false;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(1048, 671);
            this.dgvFiles.TabIndex = 2;
            this.dgvFiles.VirtualMode = true;
            this.dgvFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellContent_Click);
            this.dgvFiles.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvFiles_CellValueNeeded);
            // 
            // ColumnImage
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnImage.HeaderText = "";
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnImage.Width = 20;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCalcDataGridViewTextBoxColumn
            // 
            this.idCalcDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idCalcDataGridViewTextBoxColumn.DataPropertyName = "idCalc";
            this.idCalcDataGridViewTextBoxColumn.HeaderText = "idCalc";
            this.idCalcDataGridViewTextBoxColumn.Name = "idCalcDataGridViewTextBoxColumn";
            this.idCalcDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCalcDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idCalcDataGridViewTextBoxColumn.Visible = false;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "Файл";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fileNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
//
        this.dateInDgvColumn.DataPropertyName = "dateIn";
        this.dateInDgvColumn.HeaderText = "Дата";
        this.dateInDgvColumn.Name = "dateInDgvColumn";
        this.dateInDgvColumn.ReadOnly = true;
        this.dateInDgvColumn.Width = 120;

        // 
        // bindingSourceFile
        // 
        this.bindingSourceFile.DataMember = "tJ_CalcLossFile";
            this.bindingSourceFile.DataSource = this.dsCalcN;
            // 
            // toolStripFile
            // 
            this.toolStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnFileAdd,
            this.toolBtnFileDelete,
            this.toolBtnFileView,
            this.toolBtnFileSave});
            this.toolStripFile.Location = new System.Drawing.Point(3, 3);
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(1048, 25);
            this.toolStripFile.TabIndex = 1;
            this.toolStripFile.Text = "toolStrip1";
            // 
            // toolBtnFileAdd
            // 
            this.toolBtnFileAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFileAdd.Image = global::CalcLossN.Properties.Resources.Add;
            this.toolBtnFileAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFileAdd.Name = "toolBtnFileAdd";
            this.toolBtnFileAdd.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFileAdd.Text = "Добавить файлы";
            this.toolBtnFileAdd.Click += new System.EventHandler(this.toolBtnFileAdd_Click);
            // 
            // toolBtnFileDelete
            // 
            this.toolBtnFileDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFileDelete.Image = global::CalcLossN.Properties.Resources.ElementDel;
            this.toolBtnFileDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFileDelete.Name = "toolBtnFileDelete";
            this.toolBtnFileDelete.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFileDelete.Text = "Удалить файлы";
            this.toolBtnFileDelete.Click += new System.EventHandler(this.toolBtnFileDelete_Click);
            // 
            // toolBtnFileView
            // 
            this.toolBtnFileView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFileView.Image = global::CalcLossN.Properties.Resources.ElementInformation;
            this.toolBtnFileView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFileView.Name = "toolBtnFileView";
            this.toolBtnFileView.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFileView.Text = "Просмотр файла";
            this.toolBtnFileView.Click += new System.EventHandler(this.toolBtnFileView_Click);
            // 
            // toolBtnFileSave
            // 
            this.toolBtnFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFileSave.Image = global::CalcLossN.Properties.Resources.Export;
            this.toolBtnFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFileSave.Name = "toolBtnFileSave";
            this.toolBtnFileSave.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFileSave.Text = "Сохранить файл";
            this.toolBtnFileSave.Click += new System.EventHandler(this.toolBtnFileSave_Click);
            // 
            // FormAddEditCalcTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 760);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonCancel);
            this.Icon = global::CalcLossN.Properties.Resources.icon1;
            this.MinimumSize = new System.Drawing.Size(550, 623);
            this.Name = "FormAddEditCalcTrans";
            this.Text = "Расчет потерь в трансформаторе";
            this.Load += new System.EventHandler(this.FormAddEditCalcTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCalcN)).EndInit();
            this.toolStripAbnObj.ResumeLayout(false);
            this.toolStripAbnObj.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageCalc.ResumeLayout(false);
            this.tabPageCalc.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonthSum)).EndInit();
            this.tabControlTrans.ResumeLayout(false);
            this.tabPageTrans1.ResumeLayout(false);
            this.tabPageTrans1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).EndInit();
            this.tabPageFile.ResumeLayout(false);
            this.tabPageFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFile)).EndInit();
            this.toolStripFile.ResumeLayout(false);
            this.toolStripFile.PerformLayout();
            this.ResumeLayout(false);

        }

        private Label label1;

        private DateTimePicker dateTimePickerDateCalc;

        private CalcLossN.DataSet.DataSetCalc dsCalcN;

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

        private Label labelMakeupTrans;

        private TextBox MakeupTrans;

        private Button buttonMakeupTrans;

        private TextBox textBox1;

        private TextBox textBox2;

        private TextBox txtRatedPowerTrans1;

        private TextBox txtNoLoadLoss;

        private TextBox textBox4;

        private TextBox textBox5;

        private TextBox ShortCircuitLoss;

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

        private TextBox txtMiddleVoltage;

        private TextBox textBox19;

        private TextBox textBox20;

        private TextBox txtCoeffDifference;

        private TextBox textBox22;

        private TextBox textBox23;

        private TextBox txtSquareCoeff;

        private TextBox textBox25;

        private TextBox textBox26;

        private Button buttonOK;

        private TextBox txtLossElectrHH;

        private TextBox txtParamLossElectrHH;

        private TextBox lalbelLossElectrHH;

        private TextBox txtActiveResistance;

        private TextBox textBox18;

        private TextBox textBox28;

        private TextBox txtLoadPowerLoss;

        private TextBox textBox12;

        private TextBox textBox15;

        private TextBox txtLoadLosses;

        private TextBox textBox9;

        private TextBox textBox29;

        private TextBox txtLoadAverage;

        private TextBox labelParamUnitYearLoss;

        private TextBox labelUnitYearLoss;

        private TextBox labelCoefLoss;

        private TextBox labelParamCoefLoss;

        private TextBox txtCoefLoss;

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

        private TextBox txtRatedVoltage;

        private TextBox textBox21;

        private TextBox textBox24;

        private Label labelDgvMonth;

        private DataGridView dgvMonth;

        private DataGridViewTextBoxColumn colJanuary;

        private DataGridViewTextBoxColumn colFebruary;

        private DataGridViewTextBoxColumn colMarch;

        private DataGridViewTextBoxColumn colApril;

        private DataGridViewTextBoxColumn colMay;

        private DataGridViewTextBoxColumn colJune;

        private DataGridViewTextBoxColumn colJule;

        private DataGridViewTextBoxColumn colAugust;

        private DataGridViewTextBoxColumn colSeptember;

        private DataGridViewTextBoxColumn colOctober;

        private DataGridViewTextBoxColumn colNovember;

        private DataGridViewTextBoxColumn colDecember;

        private TabControl tabControlTrans;

        private TabPage tabPageTrans1;

        private ToolStrip toolStrip1;

        private ToolStripButton toolBtnAddTrans1;

        private ToolStripButton toolBtnDelTrans1;

        private DataGridView dgvMonthSum;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;

        private Label labeldgvMonthSum;

        private Panel panelBottom;
    }

