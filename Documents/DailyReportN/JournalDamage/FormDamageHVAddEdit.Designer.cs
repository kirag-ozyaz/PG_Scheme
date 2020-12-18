using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace DailyReportN.JournalDamage
{
    internal partial class FormDamageHVAddEdit : FormLbr.FormBase
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormDamageHVAddEdit));
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            this.tabControlMain = new TabControl();
            this.tabPageGeneral = new TabPage();
            this.toolStrip81 = new ToolStrip();
            this.toolBtn81 = new ToolStripButton();
            this.splitContainerMainGeneral = new SplitContainer();
            this.cmbAPV = new ComboBox();
            this.dataSetDamage = new DailyReportN.DataSet.dsDamage();
            this.label12 = new Label();
            this.cmbAVR = new ComboBox();
            this.label8 = new Label();
            this.label7 = new Label();
            this.txtCoefSeason = new TextBox();
            this.buttonLoadTextBoxSum = new Button();
            this.txtCosFi = new TextBox();
            this.label16 = new Label();
            this.labelPowerV = new Label();
            this.txtV = new TextBox();
            this.label11 = new Label();
            this.txtA = new TextBox();
            this.txtKWT = new TextBox();
            this.label10 = new Label();
            this.txtCountSchmObj = new TextBox();
            this.label9 = new Label();
            this.cmbTypeRZA = new ComboBoxReadOnly();
            this.labelTypeRZA = new Label();
            this.groupBoxDefectData = new GroupBox();
            this.btnRequestForRepair = new Button();
            this.txtDocParent = new TextBox();
            this.label13 = new Label();
            this.label17 = new Label();
            this.labelDamageCharacter = new Label();
            this.dgvCharacterDamage = new DataGridView();
            this.ColumnTypeObj = new DataGridViewComboBoxColumn();
            this.ColumnSchmObj = new DataGridViewTextBoxColumn();
            this.columnIdSchmObj = new DataGridViewTextBoxColumn();
            this.ColumnBtn = new DataGridViewButtonColumn();
            this.ColumnCabSection = new DataGridViewComboBoxColumn();
            this.Column2 = new DataGridViewComboBoxColumn();
            this.Column3 = new DataGridViewComboBoxColumn();
            this.txtLocation = new RichTextBox();
            this.cmbReason = new ComboBoxReadOnly();
            this.labelReason = new Label();
            this.btnChoiceSchmObj = new Button();
            this.labelSchmObj = new Label();
            this.txtSchmObj = new TextBox();
            this.groupBoxResult = new GroupBox();
            this.groupBoxDefect = new GroupBox();
            this.txtLaboratoryInstruction = new RichTextBox();
            this.labelLaboratoryInstruction = new Label();
            this.txtDivisionInstruction = new RichTextBox();
            this.labelDivisionInstruction = new Label();
            this.chbDefect = new CheckBox();
            this.labelDivisionApply = new Label();
            this.checkBoxLaboratory = new CheckBox();
            this.cmbDivisionApply = new ComboBoxReadOnly();
            this.splitContainerWorkApplyGeneral = new SplitContainer();
            this.rbOnFact = new RadioButton();
            this.rbOnAverage = new RadioButton();
            this.label15 = new Label();
            this.labelSumNoAdmissionKWT = new Label();
            this.txtCountSchmObjOff = new TextBox();
            this.txtNoKWT = new TextBox();
            this.dgvOn = new DataGridViewExcelFilter();
            this.dateBegDgvColumn = new DataGridViewTextBoxColumn();
            this.dateOnDgvColumn = new DataGridViewFilterDateTimePickerColumn();
            this.countSchmObjDgvColumn = new DataGridViewTextBoxColumn();
            this.countSchmObjOffDgvColumn = new DataGridViewTextBoxColumn();
            this.noAdmissionKWTDgvColumn = new DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.idDamageDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.labelDamageOn = new Label();
            this.label1 = new Label();
            this.checkBoxApply = new CheckBox();
            this.dtpDataApply = new NullableDateTimePicker();
            this.labelDateAplly = new Label();
            this.txtCompletedWork = new RichTextBox();
            this.cmbWorkerApply = new ComboBoxReadOnly();
            this.labelCompletedWork = new Label();
            this.cmbCompletedWork = new ComboBoxReadOnly();
            this.cmbDivision = new ComboBoxReadOnly();
            this.label6 = new Label();
            this.labelCompiler = new Label();
            this.cmbCompiler = new ComboBoxReadOnly();
            this.dtpDateOwner = new DateTimePicker();
            this.label4 = new Label();
            this.label3 = new Label();
            this.txtOwner = new TextBox();
            this.label2 = new Label();
            this.dtpDateDoc = new DateTimePicker();
            this.labelNumRequest = new Label();
            this.txtNumRequest = new TextBox();
            this.tabPageTransformer = new TabPage();
            this.splitContainerTrans = new SplitContainer();
            this.dgvTrans = new DataGridViewExcelFilter();
            this.subDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.idSubDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.idTrDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.trNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.loadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.bsTransON = new BindingSource(this.components);
            this.dataSetAdd = new System.Data.DataSet();
            this.tableTransOff = new DataTable();
            this.dataColumnidSub = new DataColumn();
            this.dataColumnSub = new DataColumn();
            this.dataColumnidTr = new DataColumn();
            this.dataColumnTrName = new DataColumn();
            this.dataColumnPower = new DataColumn();
            this.dataColumnLoad = new DataColumn();
            this.tableSchmAbnFull = new DataTable();
            this.dataColumnidAbn = new DataColumn();
            this.dataColumncodeAbonent = new DataColumn();
            this.dataColumnnameAbn = new DataColumn();
            this.dataColumntypeAbn = new DataColumn();
            this.dataColumnidAbnObj = new DataColumn();
            this.dataColumnnameObj = new DataColumn();
            this.dataColumnCommentODS = new DataColumn();
            this.dataColumnTarifName = new System.Data.DataColumn();
            this.dataColumnVoltage = new System.Data.DataColumn();
            this.dataColumnCategoryName = new DataColumn();
            this.dataColumnPowerSet = new DataColumn();
            this.dataColumnCountPoint = new DataColumn();
this.dataColumnnameAbnNet = new DataColumn();
this.dataColumnidAbnNet = new DataColumn();
this.dataColumnidSchmObj = new System.Data.DataColumn();
            this.dgvTreeSub = new TreeDataGridView();
            this.subNameColumn = new TreeGridColumn();
            this.idSubColumn = new DataGridViewTextBoxColumn();
            this.busNameColumn = new DataGridViewTextBoxColumn();
            this.idBusColumn = new DataGridViewTextBoxColumn();
            this.cellNameColumn = new DataGridViewTextBoxColumn();
            this.idCellColumn = new DataGridViewTextBoxColumn();
            this.trNameColumn = new DataGridViewTextBoxColumn();
            this.idTrColumn = new DataGridViewTextBoxColumn();
            this.powerColumn = new DataGridViewTextBoxColumn();
            this.loadColumn = new DataGridViewTextBoxColumn();
            this.dateOnColumn = new DataGridViewTextBoxColumn();
            this.noAdmissionKWTColumn = new DataGridViewTextBoxColumn();
            this.statusStripTrans = new StatusStrip();
            this.labelCountTr = new ToolStripStatusLabel();
            this.labelSumPower = new ToolStripStatusLabel();
            this.labelSumLoad = new ToolStripStatusLabel();
            this.toolStripTransformer = new ToolStrip();
            this.toolBtnRefreshTrans = new ToolStripButton();
            this.tabPageAbn = new TabPage();
            this.splitContainerAbnMain = new SplitContainer();
            this.dgvAbn = new DataGridViewExcelFilter();
            this.codeAbonentDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameAbnDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.idAbnNetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameAbnNetDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.idSchmObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAbnDgvColumn = new DataGridViewFilterComboBoxColumn();
            this.idAbnObjDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.categoryNameDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.powerSetDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.сountPointDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.commentODSDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.tarifNameDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.voltageDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.bsSchmAbnFull = new BindingSource(this.components);
            this.toolStripAbn = new ToolStrip();
            this.toolBtnRefreshAbn = new ToolStripButton();
            this.toolBtnLoadSchm = new ToolStripButton();
            this.toolBtnDelAbn = new System.Windows.Forms.ToolStripButton();
            this.splitContainerAbnCount = new SplitContainer();
            this.numCountPointSource = new NumericUpDown();
            this.numCountPointEE = new NumericUpDown();
            this.numCountPointCat3 = new NumericUpDown();
            this.groupBoxAbnObj1Catergory = new GroupBox();
            this.numCountPointCat1 = new NumericUpDown();
            this.numCountPointCat1Full = new NumericUpDown();
            this.label18 = new Label();
            this.label14 = new Label();
            this.label23 = new Label();
            this.label22 = new Label();
            this.label21 = new Label();
            this.groupBox1 = new GroupBox();
            this.numCountPointCat2Full = new NumericUpDown();
            this.numCountPointCat2 = new NumericUpDown();
            this.label19 = new Label();
            this.label20 = new Label();
            this.label5 = new Label();
            this.numCountAbnObjSource = new NumericUpDown();
            this.numCountAbnObjEE = new NumericUpDown();
            this.numCountAbnObjCat3 = new NumericUpDown();
            this.label31 = new Label();
            this.groupBox4 = new GroupBox();
            this.numCountAbnObj670 = new NumericUpDown();
            this.numCountAbnObj150670 = new NumericUpDown();
            this.numCountAbnObj150 = new NumericUpDown();
            this.label34 = new Label();
            this.label33 = new Label();
            this.label32 = new Label();
            this.groupBox2 = new GroupBox();
            this.numCountAbnObjCat1 = new NumericUpDown();
            this.numCountAbnObjCat1Full = new NumericUpDown();
            this.label24 = new Label();
            this.label25 = new Label();
            this.label26 = new Label();
            this.label27 = new Label();
            this.label28 = new Label();
            this.groupBox3 = new GroupBox();
            this.numCountAbnObjCat2 = new NumericUpDown();
            this.numCountAbnObjCat2Full = new NumericUpDown();
            this.label29 = new Label();
            this.label30 = new Label();
            this.statusStripAbnObj = new StatusStrip();
            this.toolBtnRefreshCountAbn = new ToolStripDropDownButton();
            this.labelCountPoint = new ToolStripStatusLabel();
            this.labelCountAbnObj = new ToolStripStatusLabel();
            this.labelCountAbn = new ToolStripStatusLabel();
            this.buttonClose = new Button();
            this.buttonSave = new Button();
            this.backgroundWorker = new BackgroundWorker();
            this.labelProgress = new Label();
            this.progressBar = new ProgressBar();
            this.dataGridViewComboBoxColumn1 = new DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn0 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            this.dataGridViewComboBoxColumn2 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn4 = new DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            this.toolTipDocParent = new ToolTip(this.components);
            this.contextMenuDgvTree = new ContextMenuStrip(this.components);
            this.toolMenuItemOn = new ToolStripMenuItem();
            this.toolMenuItemOff = new ToolStripMenuItem();
            this.chkSendSiteME = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtNumRequestME = new System.Windows.Forms.TextBox();
            this.tabControlMain.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.toolStrip81.SuspendLayout();
            this.splitContainerMainGeneral.Panel1.SuspendLayout();
            this.splitContainerMainGeneral.Panel2.SuspendLayout();
            this.splitContainerMainGeneral.SuspendLayout();
            ((ISupportInitialize)this.dataSetDamage).BeginInit();
            this.groupBoxDefectData.SuspendLayout();
            ((ISupportInitialize)this.dgvCharacterDamage).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxDefect.SuspendLayout();
            this.splitContainerWorkApplyGeneral.Panel1.SuspendLayout();
            this.splitContainerWorkApplyGeneral.Panel2.SuspendLayout();
            this.splitContainerWorkApplyGeneral.SuspendLayout();
            ((ISupportInitialize)this.dgvOn).BeginInit();
            this.tabPageTransformer.SuspendLayout();
            this.splitContainerTrans.Panel1.SuspendLayout();
            this.splitContainerTrans.Panel2.SuspendLayout();
            this.splitContainerTrans.SuspendLayout();
            ((ISupportInitialize)this.dgvTrans).BeginInit();
            ((ISupportInitialize)this.bsTransON).BeginInit();
            ((ISupportInitialize)this.dataSetAdd).BeginInit();
            ((ISupportInitialize)this.tableTransOff).BeginInit();
            ((ISupportInitialize)this.tableSchmAbnFull).BeginInit();
            ((ISupportInitialize)this.dgvTreeSub).BeginInit();
            this.statusStripTrans.SuspendLayout();
            this.toolStripTransformer.SuspendLayout();
            this.tabPageAbn.SuspendLayout();
            this.splitContainerAbnMain.Panel1.SuspendLayout();
            this.splitContainerAbnMain.Panel2.SuspendLayout();
            this.splitContainerAbnMain.SuspendLayout();
            ((ISupportInitialize)this.dgvAbn).BeginInit();
            ((ISupportInitialize)this.bsSchmAbnFull).BeginInit();
            this.toolStripAbn.SuspendLayout();
            this.splitContainerAbnCount.Panel1.SuspendLayout();
            this.splitContainerAbnCount.Panel2.SuspendLayout();
            this.splitContainerAbnCount.SuspendLayout();
            ((ISupportInitialize)this.numCountPointSource).BeginInit();
            ((ISupportInitialize)this.numCountPointEE).BeginInit();
            ((ISupportInitialize)this.numCountPointCat3).BeginInit();
            this.groupBoxAbnObj1Catergory.SuspendLayout();
            ((ISupportInitialize)this.numCountPointCat1).BeginInit();
            ((ISupportInitialize)this.numCountPointCat1Full).BeginInit();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize)this.numCountPointCat2Full).BeginInit();
            ((ISupportInitialize)this.numCountPointCat2).BeginInit();
            ((ISupportInitialize)this.numCountAbnObjSource).BeginInit();
            ((ISupportInitialize)this.numCountAbnObjEE).BeginInit();
            ((ISupportInitialize)this.numCountAbnObjCat3).BeginInit();
            this.groupBox4.SuspendLayout();
            ((ISupportInitialize)this.numCountAbnObj670).BeginInit();
            ((ISupportInitialize)this.numCountAbnObj150670).BeginInit();
            ((ISupportInitialize)this.numCountAbnObj150).BeginInit();
            this.groupBox2.SuspendLayout();
            ((ISupportInitialize)this.numCountAbnObjCat1).BeginInit();
            ((ISupportInitialize)this.numCountAbnObjCat1Full).BeginInit();
            this.groupBox3.SuspendLayout();
            ((ISupportInitialize)this.numCountAbnObjCat2).BeginInit();
            ((ISupportInitialize)this.numCountAbnObjCat2Full).BeginInit();
            this.statusStripAbnObj.SuspendLayout();
            this.contextMenuDgvTree.SuspendLayout();
            base.SuspendLayout();
            this.tabControlMain.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.tabControlMain.Controls.Add(this.tabPageGeneral);
            this.tabControlMain.Controls.Add(this.tabPageTransformer);
            this.tabControlMain.Controls.Add(this.tabPageAbn);
            this.tabControlMain.Location = new Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new Size(969, 645);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.label37);
            this.tabPageGeneral.Controls.Add(this.txtNumRequestME);
            this.tabPageGeneral.Controls.Add(this.chkSendSiteME);
            this.tabPageGeneral.Controls.Add(this.toolStrip81);
            this.tabPageGeneral.Controls.Add(this.splitContainerMainGeneral);
            this.tabPageGeneral.Controls.Add(this.cmbDivision);
            this.tabPageGeneral.Controls.Add(this.label6);
            this.tabPageGeneral.Controls.Add(this.labelCompiler);
            this.tabPageGeneral.Controls.Add(this.cmbCompiler);
            this.tabPageGeneral.Controls.Add(this.dtpDateOwner);
            this.tabPageGeneral.Controls.Add(this.label4);
            this.tabPageGeneral.Controls.Add(this.label3);
            this.tabPageGeneral.Controls.Add(this.txtOwner);
            this.tabPageGeneral.Controls.Add(this.label2);
            this.tabPageGeneral.Controls.Add(this.dtpDateDoc);
            this.tabPageGeneral.Controls.Add(this.labelNumRequest);
            this.tabPageGeneral.Controls.Add(this.txtNumRequest);
            this.tabPageGeneral.Location = new Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new Padding(3);
            this.tabPageGeneral.Size = new Size(961, 619);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Общий";
            this.tabPageGeneral.UseVisualStyleBackColor = true;

            this.toolStrip81.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.toolStrip81.Dock = DockStyle.None;
            this.toolStrip81.GripStyle = ToolStripGripStyle.Hidden;
            this.toolStrip81.ImageScalingSize = new Size(24, 24);
            this.toolStrip81.Items.AddRange(new ToolStripItem[]
            {
            this.toolBtn81
            });

            this.toolStrip81.Location = new Point(927, 3);
            this.toolStrip81.Name = "toolStrip81";
            this.toolStrip81.Size = new Size(31, 31);
            this.toolStrip81.TabIndex = 19;
            this.toolStrip81.Text = "toolStrip1";
            this.toolBtn81.Checked = true;
            this.toolBtn81.CheckOnClick = true;
            this.toolBtn81.CheckState = CheckState.Checked;
            this.toolBtn81.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtn81.Image = global::DailyReportN.Properties.Resources.not81;
            this.toolBtn81.ImageTransparentColor = Color.Magenta;
            this.toolBtn81.Name = "toolBtn81";
            this.toolBtn81.Size = new Size(28, 28);
            this.toolBtn81.Text = "Использовать в бюллетене 8.1";
            this.toolBtn81.CheckedChanged += new EventHandler(this.toolBtn81_CheckedChanged);

            // 
            // chkSendSiteME
            // 
            //this.chkSendSiteME.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            //this.chkSendSiteME.Dock = DockStyle.None;
            this.chkSendSiteME.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSendSiteME.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.chkSendSiteME.AutoSize = false;
            this.chkSendSiteME.Location = new System.Drawing.Point(780, 36);
            this.chkSendSiteME.Name = "chkSendSiteME";
            this.chkSendSiteME.Size = new System.Drawing.Size(175, 17);
            this.chkSendSiteME.TabIndex = 20;
            this.chkSendSiteME.Text = "chkSendSiteME";
            this.chkSendSiteME.UseVisualStyleBackColor = true;
            this.chkSendSiteME.CheckedChanged += new System.EventHandler(this.chkSendSiteME_CheckedChanged);
            // 
            // label37
            // 
            this.label37.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(780, 5);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(99, 13);
            this.label37.TabIndex = 29;
            this.label37.Text = "Номер заявки\r\n МЭ";
            // 
            // txtNumRequestME
            // 
            this.txtNumRequestME.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtNumRequestME.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_Damage.numRequestME", true));
            this.txtNumRequestME.Location = new System.Drawing.Point(860, 7);
            this.txtNumRequestME.Name = "txtNumRequestME";
            this.txtNumRequestME.Size = new System.Drawing.Size(60, 20);
            this.txtNumRequestME.TabIndex = 28;


            this.splitContainerMainGeneral.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.splitContainerMainGeneral.Location = new Point(3, 60);
            this.splitContainerMainGeneral.Name = "splitContainerMainGeneral";
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.cmbAPV);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.label12);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.cmbAVR);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.label8);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.label7);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.txtCoefSeason);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.buttonLoadTextBoxSum);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.txtCosFi);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.label16);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.labelPowerV);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.txtV);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.label11);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.txtA);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.txtKWT);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.label10);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.txtCountSchmObj);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.label9);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.cmbTypeRZA);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.labelTypeRZA);
            this.splitContainerMainGeneral.Panel1.Controls.Add(this.groupBoxDefectData);
            this.splitContainerMainGeneral.Panel2.Controls.Add(this.groupBoxResult);
            this.splitContainerMainGeneral.Size = new Size(958, 556);
            this.splitContainerMainGeneral.SplitterDistance = 507;
            this.splitContainerMainGeneral.TabIndex = 18;
            this.cmbAPV.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.cmbAPV.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageHV.APR", true));
            this.cmbAPV.FormattingEnabled = true;
            this.cmbAPV.Location = new Point(277, 530);
            this.cmbAPV.Name = "cmbAPV";
            this.cmbAPV.Size = new Size(74, 21);
            this.cmbAPV.TabIndex = 35;
            this.dataSetDamage.DataSetName = "DataSetDamage";
            this.dataSetDamage.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.label12.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label12.AutoSize = true;
            this.label12.Location = new Point(178, 535);
            this.label12.Name = "label12";
            this.label12.Size = new Size(29, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "АПВ";
            this.cmbAVR.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.cmbAVR.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageHV.AVR", true));
            this.cmbAVR.FormattingEnabled = true;
            this.cmbAVR.Location = new Point(115, 530);
            this.cmbAVR.Name = "cmbAVR";
            this.cmbAVR.Size = new Size(55, 21);
            this.cmbAVR.TabIndex = 33;
            this.label8.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label8.AutoSize = true;
            this.label8.Location = new Point(10, 535);
            this.label8.Name = "label8";
            this.label8.Size = new Size(28, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "АВР";
            this.label7.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label7.Location = new Point(357, 479);
            this.label7.Name = "label7";
            this.label7.Size = new Size(68, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "Коэфф. сезонности";
            this.txtCoefSeason.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtCoefSeason.BackColor = SystemColors.Window;
            this.txtCoefSeason.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageHV.CoefSeason", true));
            this.txtCoefSeason.Location = new Point(431, 479);
            this.txtCoefSeason.Name = "txtCoefSeason";
            this.txtCoefSeason.Size = new Size(65, 20);
            this.txtCoefSeason.TabIndex = 30;
            this.txtCoefSeason.TextChanged += new EventHandler(this.txtCoefSeason_TextChanged);

            this.buttonLoadTextBoxSum.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.buttonLoadTextBoxSum.Location = new Point(430, 530);
            this.buttonLoadTextBoxSum.Name = "buttonLoadTextBoxSum";
            this.buttonLoadTextBoxSum.Size = new Size(75, 23);
            this.buttonLoadTextBoxSum.TabIndex = 29;
            this.buttonLoadTextBoxSum.Text = "Заполнить";
            this.buttonLoadTextBoxSum.UseVisualStyleBackColor = true;
            this.buttonLoadTextBoxSum.Click += new EventHandler(this.buttonLoadTextBoxSum_Click);

            this.txtCosFi.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtCosFi.BackColor = SystemColors.Window;
            this.txtCosFi.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageHV.CoefFI", true));
            this.txtCosFi.Location = new Point(431, 505);
            this.txtCosFi.Name = "txtCosFi";
            this.txtCosFi.Size = new Size(65, 20);
            this.txtCosFi.TabIndex = 28;
            this.txtCosFi.TextChanged += new EventHandler(this.txtCosFi_TextChanged);
            this.label16.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label16.AutoSize = true;
            this.label16.Location = new Point(357, 511);
            this.label16.Name = "label16";
            this.label16.Size = new Size(32, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "cos fi";
            this.labelPowerV.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.labelPowerV.AutoSize = true;
            this.labelPowerV.Location = new Point(178, 511);
            this.labelPowerV.Name = "labelPowerV";
            this.labelPowerV.Size = new Size(90, 13);
            this.labelPowerV.TabIndex = 24;
            this.labelPowerV.Text = "Напряжение, кВ";
            this.txtV.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtV.BackColor = SystemColors.Window;
            this.txtV.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageHV.PowerV", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtV.Location = new Point(277, 508);
            this.txtV.Name = "txtV";
            this.txtV.Size = new Size(74, 20);
            this.txtV.TabIndex = 23;
            this.txtV.TextChanged += new EventHandler(this.txtV_TextChanged);
            this.label11.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label11.AutoSize = true;
            this.label11.Location = new Point(10, 511);
            this.label11.Name = "label11";
            this.label11.Size = new Size(68, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Нагрузка, А";
            this.txtA.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtA.BackColor = SystemColors.Window;
            this.txtA.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageHV.PowerA", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtA.Location = new Point(115, 508);
            this.txtA.Name = "txtA";
            this.txtA.Size = new Size(55, 20);
            this.txtA.TabIndex = 20;
            this.txtA.TextChanged += new EventHandler(this.txtA_TextChanged);
            this.txtKWT.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtKWT.BackColor = SystemColors.Window;
            this.txtKWT.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageHV.ConnectedPower", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtKWT.Location = new Point(277, 479);
            this.txtKWT.Name = "txtKWT";
            this.txtKWT.ReadOnly = true;
            this.txtKWT.Size = new Size(74, 20);
            this.txtKWT.TabIndex = 19;
            this.txtKWT.TextChanged += new EventHandler(this.txtKWT_TextChanged);
            this.label10.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label10.Location = new Point(178, 476);
            this.label10.Name = "label10";
            this.label10.Size = new Size(108, 29);
            this.label10.TabIndex = 18;
            this.label10.Text = "Присоединенная мощность, кВт";
            this.txtCountSchmObj.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtCountSchmObj.BackColor = SystemColors.Window;
            this.txtCountSchmObj.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageHV.CountSchmObj", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtCountSchmObj.Location = new Point(115, 479);
            this.txtCountSchmObj.Name = "txtCountSchmObj";
            this.txtCountSchmObj.Size = new Size(55, 20);
            this.txtCountSchmObj.TabIndex = 17;
            this.txtCountSchmObj.TextChanged += new EventHandler(this.txtCountSchmObj_TextChanged);
            this.label9.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label9.Location = new Point(10, 476);
            this.label9.Name = "label9";
            this.label9.Size = new Size(108, 29);
            this.label9.TabIndex = 16;
            this.label9.Text = "Количество электроустановок";
            this.cmbTypeRZA.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.cmbTypeRZA.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_DamageHV.idTypeRZA", true));
            this.cmbTypeRZA.FormattingEnabled = true;
            this.cmbTypeRZA.Location = new Point(202, 449);
            this.cmbTypeRZA.Name = "cmbTypeRZA";
            this.cmbTypeRZA.ReadOnlyBackColor = SystemColors.Window;
            this.cmbTypeRZA.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbTypeRZA.Size = new Size(296, 21);
            this.cmbTypeRZA.TabIndex = 15;
            this.cmbTypeRZA.SelectedIndexChanged += new EventHandler(this.cmbTypeRZA_SelectedIndexChanged);
            this.labelTypeRZA.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.labelTypeRZA.AutoSize = true;
            this.labelTypeRZA.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelTypeRZA.Location = new Point(10, 452);
            this.labelTypeRZA.Name = "labelTypeRZA";
            this.labelTypeRZA.Size = new Size(186, 13);
            this.labelTypeRZA.TabIndex = 14;
            this.labelTypeRZA.Text = "Тип работы релейной защиты";
            this.groupBoxDefectData.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBoxDefectData.Controls.Add(this.btnRequestForRepair);
            this.groupBoxDefectData.Controls.Add(this.txtDocParent);
            this.groupBoxDefectData.Controls.Add(this.label13);
            this.groupBoxDefectData.Controls.Add(this.label17);
            this.groupBoxDefectData.Controls.Add(this.labelDamageCharacter);
            this.groupBoxDefectData.Controls.Add(this.dgvCharacterDamage);
            this.groupBoxDefectData.Controls.Add(this.txtLocation);
            this.groupBoxDefectData.Controls.Add(this.cmbReason);
            this.groupBoxDefectData.Controls.Add(this.labelReason);
            this.groupBoxDefectData.Controls.Add(this.btnChoiceSchmObj);
            this.groupBoxDefectData.Controls.Add(this.labelSchmObj);
            this.groupBoxDefectData.Controls.Add(this.txtSchmObj);
            this.groupBoxDefectData.Location = new Point(0, 0);
            this.groupBoxDefectData.Name = "groupBoxDefectData";
            this.groupBoxDefectData.Size = new Size(504, 443);
            this.groupBoxDefectData.TabIndex = 13;
            this.groupBoxDefectData.TabStop = false;
            this.groupBoxDefectData.Text = "Исходные данные";
            this.btnRequestForRepair.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnRequestForRepair.Location = new Point(469, 15);
            this.btnRequestForRepair.Name = "btnRequestForRepair";
            this.btnRequestForRepair.Size = new Size(27, 20);
            this.btnRequestForRepair.TabIndex = 12;
            this.btnRequestForRepair.Text = "...";
            this.btnRequestForRepair.UseVisualStyleBackColor = true;
            this.btnRequestForRepair.Click += new EventHandler(this.btnRequestForRepair_Click);
            this.txtDocParent.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtDocParent.BackColor = SystemColors.Window;
            this.txtDocParent.Location = new Point(141, 16);
            this.txtDocParent.Name = "txtDocParent";
            this.txtDocParent.ReadOnly = true;
            this.txtDocParent.Size = new Size(329, 20);
            this.txtDocParent.TabIndex = 11;
            this.txtDocParent.MouseLeave += new EventHandler(this.txtDocParent_MouseLeave);
            this.txtDocParent.MouseHover += new EventHandler(this.txtDocParent_MouseHover);
            this.label13.AutoSize = true;
            this.label13.Location = new Point(10, 19);
            this.label13.Name = "label13";
            this.label13.Size = new Size(115, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Документ-основание";
            this.label17.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label17.AutoSize = true;
            this.label17.Location = new Point(5, 318);
            this.label17.Name = "label17";
            this.label17.Size = new Size(110, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Место повреждения";
            this.labelDamageCharacter.AutoSize = true;
            this.labelDamageCharacter.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelDamageCharacter.Location = new Point(10, 79);
            this.labelDamageCharacter.Name = "labelDamageCharacter";
            this.labelDamageCharacter.Size = new Size(146, 13);
            this.labelDamageCharacter.TabIndex = 8;
            this.labelDamageCharacter.Text = "Характер повреждения";

            this.dgvCharacterDamage.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvCharacterDamage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharacterDamage.Columns.AddRange(new DataGridViewColumn[]
            {
            this.ColumnTypeObj,
            this.ColumnSchmObj,
            this.columnIdSchmObj,
            this.ColumnBtn,
            this.ColumnCabSection,
            this.Column2,
            this.Column3
            });
            this.dgvCharacterDamage.EditMode = DataGridViewEditMode.EditOnEnter;
            this.dgvCharacterDamage.Location = new Point(0, 95);
            this.dgvCharacterDamage.Name = "dgvCharacterDamage";
            this.dgvCharacterDamage.Size = new Size(504, 220);
            this.dgvCharacterDamage.TabIndex = 7;
            this.dgvCharacterDamage.CellContentClick += new DataGridViewCellEventHandler(this.dgvCharacterDamage_CellContentClick);
            this.dgvCharacterDamage.CurrentCellDirtyStateChanged += new EventHandler(this.dgvCharacterDamage_CurrentCellDirtyStateChanged);
            this.dgvCharacterDamage.DataError += new DataGridViewDataErrorEventHandler(this.dgvCharacterDamage_DataError);
            this.dgvCharacterDamage.MouseClick += new MouseEventHandler(this.dgvCharacterDamage_MouseClick);
            //this.dgvCharacterDamage.RowsRemoved += new DataGridViewRowsRemovedEventHandler(dgvCharacterDamage_RowsRemoved);

            this.ColumnTypeObj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnTypeObj.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnTypeObj.FillWeight = 50f;
            this.ColumnTypeObj.HeaderText = "Тип объекта";
            this.ColumnTypeObj.Name = "ColumnTypeObj";
            this.ColumnTypeObj.Resizable = DataGridViewTriState.True;
            this.ColumnTypeObj.SortMode = DataGridViewColumnSortMode.Programmatic;

            this.ColumnSchmObj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnSchmObj.HeaderText = "Объект";
            this.ColumnSchmObj.Name = "ColumnSchmObj";

            this.columnIdSchmObj.HeaderText = "idSchmObj";
            this.columnIdSchmObj.Name = "columnIdSchmObj";
            this.columnIdSchmObj.Visible = false;

            this.ColumnBtn.FillWeight = 40f;
            this.ColumnBtn.HeaderText = "";
            this.ColumnBtn.Name = "ColumnBtn";
            this.ColumnBtn.Text = "...";
            this.ColumnBtn.ToolTipText = "Выбрать объект";
            this.ColumnBtn.Width = 25;

            this.ColumnCabSection.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnCabSection.HeaderText = "Участок";
            this.ColumnCabSection.Name = "ColumnCabSection";
            this.ColumnCabSection.Resizable = DataGridViewTriState.True;
            this.ColumnCabSection.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.ColumnCabSection.Width = 60;

            this.Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column2.HeaderText = "Повреждение";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = DataGridViewTriState.True;
            this.Column2.SortMode = DataGridViewColumnSortMode.Automatic;

            this.Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column3.HeaderText = "Уточнение";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = DataGridViewTriState.True;
            this.Column3.SortMode = DataGridViewColumnSortMode.Automatic;

            this.txtLocation.AcceptsTab = true;
            this.txtLocation.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.txtLocation.BackColor = SystemColors.Window;
            this.txtLocation.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.DefectLocation", true));
            this.txtLocation.Location = new Point(0, 334);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new Size(504, 66);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.Text = "";
            this.cmbReason.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.cmbReason.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbReason.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbReason.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idReason", true));
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new Point(115, 406);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.ReadOnlyBackColor = SystemColors.Window;
            this.cmbReason.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbReason.Size = new Size(382, 21);
            this.cmbReason.TabIndex = 5;
            this.cmbReason.SelectedIndexChanged += new EventHandler(this.cmbReason_SelectedIndexChanged);
            this.labelReason.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.labelReason.AutoSize = true;
            this.labelReason.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelReason.Location = new Point(10, 409);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new Size(99, 13);
            this.labelReason.TabIndex = 4;
            this.labelReason.Text = "Неисправность";
            this.btnChoiceSchmObj.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnChoiceSchmObj.Location = new Point(469, 45);
            this.btnChoiceSchmObj.Name = "btnChoiceSchmObj";
            this.btnChoiceSchmObj.Size = new Size(27, 20);
            this.btnChoiceSchmObj.TabIndex = 2;
            this.btnChoiceSchmObj.Text = "...";
            this.btnChoiceSchmObj.UseVisualStyleBackColor = true;
            this.btnChoiceSchmObj.Click += new EventHandler(this.btnChoiceSchmObj_Click);
            this.labelSchmObj.AutoSize = true;
            this.labelSchmObj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelSchmObj.Location = new Point(10, 49);
            this.labelSchmObj.Name = "labelSchmObj";
            this.labelSchmObj.Size = new Size(125, 13);
            this.labelSchmObj.TabIndex = 1;
            this.labelSchmObj.Text = "Подстанция\\ячейка";
            this.txtSchmObj.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtSchmObj.BackColor = SystemColors.Window;
            this.txtSchmObj.Location = new Point(141, 45);
            this.txtSchmObj.Name = "txtSchmObj";
            this.txtSchmObj.ReadOnly = true;
            this.txtSchmObj.Size = new Size(329, 20);
            this.txtSchmObj.TabIndex = 0;
            this.txtSchmObj.TextChanged += new EventHandler(this.txtSchmObj_TextChanged);
            this.groupBoxResult.Controls.Add(this.groupBoxDefect);
            this.groupBoxResult.Controls.Add(this.splitContainerWorkApplyGeneral);
            this.groupBoxResult.Controls.Add(this.labelCompletedWork);
            this.groupBoxResult.Controls.Add(this.cmbCompletedWork);
            this.groupBoxResult.Dock = DockStyle.Fill;
            this.groupBoxResult.Location = new Point(0, 0);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new Size(447, 556);
            this.groupBoxResult.TabIndex = 14;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат (принятые меры)";
            this.groupBoxDefect.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBoxDefect.Controls.Add(this.txtLaboratoryInstruction);
            this.groupBoxDefect.Controls.Add(this.labelLaboratoryInstruction);
            this.groupBoxDefect.Controls.Add(this.txtDivisionInstruction);
            this.groupBoxDefect.Controls.Add(this.labelDivisionInstruction);
            this.groupBoxDefect.Controls.Add(this.chbDefect);
            this.groupBoxDefect.Controls.Add(this.labelDivisionApply);
            this.groupBoxDefect.Controls.Add(this.checkBoxLaboratory);
            this.groupBoxDefect.Controls.Add(this.cmbDivisionApply);
            this.groupBoxDefect.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.groupBoxDefect.Location = new Point(0, 361);
            this.groupBoxDefect.Name = "groupBoxDefect";
            this.groupBoxDefect.Size = new Size(447, 195);
            this.groupBoxDefect.TabIndex = 19;
            this.groupBoxDefect.TabStop = false;
            this.groupBoxDefect.Text = "Журнал дефектов";
            this.txtLaboratoryInstruction.AcceptsTab = true;
            this.txtLaboratoryInstruction.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtLaboratoryInstruction.BackColor = SystemColors.Window;
            this.txtLaboratoryInstruction.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.LaboratoryInstruction", true));
            this.txtLaboratoryInstruction.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.txtLaboratoryInstruction.Location = new Point(81, 144);
            this.txtLaboratoryInstruction.Name = "txtLaboratoryInstruction";
            this.txtLaboratoryInstruction.Size = new Size(360, 48);
            this.txtLaboratoryInstruction.TabIndex = 22;
            this.txtLaboratoryInstruction.Text = "";
            this.txtLaboratoryInstruction.Visible = false;
            this.labelLaboratoryInstruction.AutoSize = true;
            this.labelLaboratoryInstruction.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.labelLaboratoryInstruction.Location = new Point(6, 145);
            this.labelLaboratoryInstruction.Name = "labelLaboratoryInstruction";
            this.labelLaboratoryInstruction.Size = new Size(57, 13);
            this.labelLaboratoryInstruction.TabIndex = 21;
            this.labelLaboratoryInstruction.Text = "Указания";
            this.labelLaboratoryInstruction.Visible = false;
            this.txtDivisionInstruction.AcceptsTab = true;
            this.txtDivisionInstruction.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtDivisionInstruction.BackColor = SystemColors.Window;
            this.txtDivisionInstruction.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.DivisionInstruction", true));
            this.txtDivisionInstruction.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.txtDivisionInstruction.Location = new Point(81, 61);
            this.txtDivisionInstruction.Name = "txtDivisionInstruction";
            this.txtDivisionInstruction.Size = new Size(360, 58);
            this.txtDivisionInstruction.TabIndex = 20;
            this.txtDivisionInstruction.Text = "";
            this.txtDivisionInstruction.Visible = false;
            this.labelDivisionInstruction.AutoSize = true;
            this.labelDivisionInstruction.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.labelDivisionInstruction.Location = new Point(6, 61);
            this.labelDivisionInstruction.Name = "labelDivisionInstruction";
            this.labelDivisionInstruction.Size = new Size(57, 13);
            this.labelDivisionInstruction.TabIndex = 19;
            this.labelDivisionInstruction.Text = "Указания";
            this.labelDivisionInstruction.Visible = false;
            this.chbDefect.AutoSize = true;
            this.chbDefect.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.chbDefect.Location = new Point(6, 25);
            this.chbDefect.Name = "chbDefect";
            this.chbDefect.Size = new Size(66, 17);
            this.chbDefect.TabIndex = 18;
            this.chbDefect.Text = "Дефект";
            this.chbDefect.UseVisualStyleBackColor = true;
            this.chbDefect.CheckedChanged += new EventHandler(this.chbDefect_CheckedChanged);
            this.labelDivisionApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.labelDivisionApply.Location = new Point(78, 19);
            this.labelDivisionApply.Name = "labelDivisionApply";
            this.labelDivisionApply.Size = new Size(96, 27);
            this.labelDivisionApply.TabIndex = 15;
            this.labelDivisionApply.Text = "Подразделение исполнитель";
            this.labelDivisionApply.Visible = false;
            this.checkBoxLaboratory.AutoSize = true;
            this.checkBoxLaboratory.DataBindings.Add(new Binding("Checked", this.dataSetDamage, "tJ_Damage.isLaboratory", true, DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxLaboratory.Enabled = false;
            this.checkBoxLaboratory.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.checkBoxLaboratory.Location = new Point(6, 121);
            this.checkBoxLaboratory.Name = "checkBoxLaboratory";
            this.checkBoxLaboratory.Size = new Size(191, 17);
            this.checkBoxLaboratory.TabIndex = 17;
            this.checkBoxLaboratory.Text = "Производственная лаборатория";
            this.checkBoxLaboratory.UseVisualStyleBackColor = true;
            this.checkBoxLaboratory.Visible = false;
            this.checkBoxLaboratory.CheckedChanged += new EventHandler(this.checkBoxLaboratory_CheckedChanged);
            this.cmbDivisionApply.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.cmbDivisionApply.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbDivisionApply.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbDivisionApply.BackColor = SystemColors.Control;
            this.cmbDivisionApply.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idDivisionApply", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDivisionApply.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDivisionApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.cmbDivisionApply.ForeColor = SystemColors.WindowText;
            this.cmbDivisionApply.FormattingEnabled = true;
            this.cmbDivisionApply.Location = new Point(180, 21);
            this.cmbDivisionApply.Name = "cmbDivisionApply";
            this.cmbDivisionApply.ReadOnly = true;
            this.cmbDivisionApply.ReadOnlyBackColor = SystemColors.Window;
            this.cmbDivisionApply.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbDivisionApply.Size = new Size(261, 21);
            this.cmbDivisionApply.TabIndex = 16;
            this.cmbDivisionApply.TabStop = false;
            this.cmbDivisionApply.Visible = false;
            this.cmbDivisionApply.SelectedIndexChanged += new EventHandler(this.cmbDivisionApply_SelectedIndexChanged);
            this.splitContainerWorkApplyGeneral.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.splitContainerWorkApplyGeneral.Location = new Point(0, 38);
            this.splitContainerWorkApplyGeneral.Name = "splitContainerWorkApplyGeneral";
            this.splitContainerWorkApplyGeneral.Orientation = Orientation.Horizontal;
            this.splitContainerWorkApplyGeneral.Panel1.Controls.Add(this.rbOnFact);
            this.splitContainerWorkApplyGeneral.Panel1.Controls.Add(this.rbOnAverage);
            this.splitContainerWorkApplyGeneral.Panel1.Controls.Add(this.label15);
            this.splitContainerWorkApplyGeneral.Panel1.Controls.Add(this.labelSumNoAdmissionKWT);
            this.splitContainerWorkApplyGeneral.Panel1.Controls.Add(this.txtCountSchmObjOff);
            this.splitContainerWorkApplyGeneral.Panel1.Controls.Add(this.txtNoKWT);
            this.splitContainerWorkApplyGeneral.Panel1.Controls.Add(this.dgvOn);
            this.splitContainerWorkApplyGeneral.Panel1.Controls.Add(this.labelDamageOn);
            this.splitContainerWorkApplyGeneral.Panel2.Controls.Add(this.label1);
            this.splitContainerWorkApplyGeneral.Panel2.Controls.Add(this.checkBoxApply);
            this.splitContainerWorkApplyGeneral.Panel2.Controls.Add(this.dtpDataApply);
            this.splitContainerWorkApplyGeneral.Panel2.Controls.Add(this.labelDateAplly);
            this.splitContainerWorkApplyGeneral.Panel2.Controls.Add(this.txtCompletedWork);
            this.splitContainerWorkApplyGeneral.Panel2.Controls.Add(this.cmbWorkerApply);
            this.splitContainerWorkApplyGeneral.Size = new Size(447, 323);
            this.splitContainerWorkApplyGeneral.SplitterDistance = 192;
            this.splitContainerWorkApplyGeneral.TabIndex = 8;
            this.rbOnFact.AutoSize = true;
            this.rbOnFact.Location = new Point(223, 5);
            this.rbOnFact.Name = "rbOnFact";
            this.rbOnFact.Size = new Size(70, 17);
            this.rbOnFact.TabIndex = 28;
            this.rbOnFact.Text = "по факту";
            this.rbOnFact.UseVisualStyleBackColor = true;
            this.rbOnAverage.AutoSize = true;
            this.rbOnAverage.Checked = true;
            this.rbOnAverage.Location = new Point(75, 5);
            this.rbOnAverage.Name = "rbOnAverage";
            this.rbOnAverage.Size = new Size(89, 17);
            this.rbOnAverage.TabIndex = 27;
            this.rbOnAverage.TabStop = true;
            this.rbOnAverage.Text = "по среднему";
            this.rbOnAverage.UseVisualStyleBackColor = true;
            this.rbOnAverage.CheckedChanged += new EventHandler(this.rbOnAverage_CheckedChanged);
            this.label15.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.label15.AutoSize = true;
            this.label15.Location = new Point(10, 140);
            this.label15.Name = "label15";
            this.label15.Size = new Size(213, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Количество невключенных эл.установок";
            this.labelSumNoAdmissionKWT.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.labelSumNoAdmissionKWT.AutoSize = true;
            this.labelSumNoAdmissionKWT.Location = new Point(10, 166);
            this.labelSumNoAdmissionKWT.Name = "labelSumNoAdmissionKWT";
            this.labelSumNoAdmissionKWT.Size = new Size(151, 13);
            this.labelSumNoAdmissionKWT.TabIndex = 26;
            this.labelSumNoAdmissionKWT.Text = "Недопуск эл. энергии, кВт*ч";
            this.txtCountSchmObjOff.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtCountSchmObjOff.BackColor = SystemColors.Window;
            this.txtCountSchmObjOff.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageHV.CountSchmObjOff", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtCountSchmObjOff.Location = new Point(256, 137);
            this.txtCountSchmObjOff.Name = "txtCountSchmObjOff";
            this.txtCountSchmObjOff.ReadOnly = true;
            this.txtCountSchmObjOff.Size = new Size(100, 20);
            this.txtCountSchmObjOff.TabIndex = 2;
            this.txtNoKWT.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtNoKWT.BackColor = SystemColors.Window;
            this.txtNoKWT.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_DamageHV.NoAdmissionKWT", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtNoKWT.Location = new Point(256, 163);
            this.txtNoKWT.Name = "txtNoKWT";
            this.txtNoKWT.ReadOnly = true;
            this.txtNoKWT.Size = new Size(100, 20);
            this.txtNoKWT.TabIndex = 25;
            this.dgvOn.AllowUserToOrderColumns = true;
            this.dgvOn.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvOn.AutoGenerateColumns = false;
            this.dgvOn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOn.Columns.AddRange(new DataGridViewColumn[]
            {
            this.dateBegDgvColumn,
            this.dateOnDgvColumn,
            this.countSchmObjDgvColumn,
            this.countSchmObjOffDgvColumn,
            this.noAdmissionKWTDgvColumn,
            this.idDataGridViewTextBoxColumn1,
            this.idDamageDataGridViewTextBoxColumn1
            });
            this.dgvOn.DataMember = "tJ_DamageOn";
            this.dgvOn.DataSource = this.dataSetDamage;
            this.dgvOn.Location = new Point(0, 23);
            this.dgvOn.Name = "dgvOn";
            this.dgvOn.RowHeadersWidth = 21;
            this.dgvOn.Size = new Size(447, 108);
            this.dgvOn.TabIndex = 1;
            this.dgvOn.CellValueChanged += new DataGridViewCellEventHandler(this.dgvOn_CellValueChanged);
            this.dgvOn.DataError += new DataGridViewDataErrorEventHandler(this.dgvOn_DataError);
            this.dgvOn.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(this.dgvOn_EditingControlShowing);
            this.dgvOn.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgvOn_RowsAdded);
            this.dgvOn.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dgvOn_RowsRemoved);
            this.dateBegDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle.Format = "dd.MM.yyyy HH:mm";
            this.dateBegDgvColumn.DefaultCellStyle = dataGridViewCellStyle;
            this.dateBegDgvColumn.HeaderText = "Дата1";
            this.dateBegDgvColumn.Name = "dateBegDgvColumn";
            this.dateBegDgvColumn.ReadOnly = true;
            this.dateBegDgvColumn.Visible = false;
            this.dateOnDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dateOnDgvColumn.DataPropertyName = "dateOn";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy HH:mm";
            this.dateOnDgvColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateOnDgvColumn.FillWeight = 100.5905f;
            this.dateOnDgvColumn.HeaderText = "Дата включения";
            this.dateOnDgvColumn.MinimumWidth = 70;
            this.dateOnDgvColumn.Name = "dateOnDgvColumn";
            this.dateOnDgvColumn.Resizable = DataGridViewTriState.True;
            this.dateOnDgvColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            this.countSchmObjDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.countSchmObjDgvColumn.DataPropertyName = "countSchmObj";
            this.countSchmObjDgvColumn.FillWeight = 99.64599f;
            this.countSchmObjDgvColumn.HeaderText = "Количество трансформаторов";
            this.countSchmObjDgvColumn.MinimumWidth = 70;
            this.countSchmObjDgvColumn.Name = "countSchmObjDgvColumn";
            this.countSchmObjOffDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(224, 224, 224);
            this.countSchmObjOffDgvColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.countSchmObjOffDgvColumn.HeaderText = "Количество отключенных";
            this.countSchmObjOffDgvColumn.Name = "countSchmObjOffDgvColumn";
            this.countSchmObjOffDgvColumn.ReadOnly = true;
            this.countSchmObjOffDgvColumn.Visible = false;
            this.noAdmissionKWTDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.noAdmissionKWTDgvColumn.DataPropertyName = "noAdmissionKWT";
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            this.noAdmissionKWTDgvColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.noAdmissionKWTDgvColumn.HeaderText = "Недопуск эл.энергии";
            this.noAdmissionKWTDgvColumn.Name = "noAdmissionKWTDgvColumn";
            this.noAdmissionKWTDgvColumn.ReadOnly = true;
            this.noAdmissionKWTDgvColumn.Visible = false;
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDamageDataGridViewTextBoxColumn1.DataPropertyName = "idDamage";
            this.idDamageDataGridViewTextBoxColumn1.HeaderText = "idDamage";
            this.idDamageDataGridViewTextBoxColumn1.Name = "idDamageDataGridViewTextBoxColumn1";
            this.idDamageDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDamageDataGridViewTextBoxColumn1.Visible = false;
            this.labelDamageOn.AutoSize = true;
            this.labelDamageOn.Location = new Point(6, 7);
            this.labelDamageOn.Name = "labelDamageOn";
            this.labelDamageOn.Size = new Size(63, 13);
            this.labelDamageOn.TabIndex = 0;
            this.labelDamageOn.Text = "Включение";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Примечание";
            this.checkBoxApply.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.checkBoxApply.AutoSize = true;
            this.checkBoxApply.DataBindings.Add(new Binding("Checked", this.dataSetDamage, "tJ_Damage.isApply", true, DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxApply.Location = new Point(13, 76);
            this.checkBoxApply.Name = "checkBoxApply";
            this.checkBoxApply.Size = new Size(82, 17);
            this.checkBoxApply.TabIndex = 3;
            this.checkBoxApply.Text = "Исполнено";
            this.checkBoxApply.UseVisualStyleBackColor = true;
            this.checkBoxApply.CheckedChanged += new EventHandler(this.checkBoxApply_CheckedChanged);
            this.dtpDataApply.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dtpDataApply.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDataApply.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateApply", true));
            this.dtpDataApply.Format = DateTimePickerFormat.Custom;
            this.dtpDataApply.Location = new Point(101, 101);
            this.dtpDataApply.Name = "dtpDataApply";
            this.dtpDataApply.Size = new Size(256, 20);
            this.dtpDataApply.TabIndex = 6;
            this.dtpDataApply.Value = new DateTime(2015, 8, 6, 10, 0, 53, 2);
            this.dtpDataApply.ValueChanged += new EventHandler(this.dtpDataApply_ValueChanged);
            this.labelDateAplly.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.labelDateAplly.AutoSize = true;
            this.labelDateAplly.Location = new Point(10, 106);
            this.labelDateAplly.Name = "labelDateAplly";
            this.labelDateAplly.Size = new Size(77, 13);
            this.labelDateAplly.TabIndex = 5;
            this.labelDateAplly.Text = "Дата и время";
            this.txtCompletedWork.AcceptsTab = true;
            this.txtCompletedWork.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.txtCompletedWork.BackColor = SystemColors.Window;
            this.txtCompletedWork.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.ComletedWorkText", true));
            this.txtCompletedWork.Location = new Point(0, 16);
            this.txtCompletedWork.Name = "txtCompletedWork";
            this.txtCompletedWork.Size = new Size(447, 52);
            this.txtCompletedWork.TabIndex = 2;
            this.txtCompletedWork.Text = "";
            this.txtCompletedWork.TextChanged += new EventHandler(this.txtKWT_TextChanged);
            this.cmbWorkerApply.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.cmbWorkerApply.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbWorkerApply.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbWorkerApply.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idWorkerApply", true));
            this.cmbWorkerApply.FormattingEnabled = true;
            this.cmbWorkerApply.Location = new Point(101, 74);
            this.cmbWorkerApply.Name = "cmbWorkerApply";
            this.cmbWorkerApply.ReadOnlyBackColor = SystemColors.Window;
            this.cmbWorkerApply.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbWorkerApply.Size = new Size(196, 21);
            this.cmbWorkerApply.TabIndex = 4;
            this.cmbWorkerApply.SelectedIndexChanged += new EventHandler(this.cmbWorkerApply_SelectedIndexChanged);
            this.labelCompletedWork.AutoSize = true;
            this.labelCompletedWork.Location = new Point(10, 22);
            this.labelCompletedWork.Name = "labelCompletedWork";
            this.labelCompletedWork.Size = new Size(114, 13);
            this.labelCompletedWork.TabIndex = 1;
            this.labelCompletedWork.Text = "Выполненная работа";
            this.cmbCompletedWork.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.cmbCompletedWork.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompletedWork", true));
            this.cmbCompletedWork.FormattingEnabled = true;
            this.cmbCompletedWork.Location = new Point(130, 19);
            this.cmbCompletedWork.Name = "cmbCompletedWork";
            this.cmbCompletedWork.ReadOnlyBackColor = SystemColors.Window;
            this.cmbCompletedWork.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbCompletedWork.Size = new Size(313, 21);
            this.cmbCompletedWork.TabIndex = 0;
            this.cmbCompletedWork.SelectedIndexChanged += new EventHandler(this.cmbCompletedWork_SelectedIndexChanged);
            this.cmbDivision.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idDivision", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new Point(605, 33);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.ReadOnly = true;
            this.cmbDivision.ReadOnlyBackColor = SystemColors.Window;
            this.cmbDivision.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbDivision.Size = new Size(175, 21);
            this.cmbDivision.TabIndex = 11;
            this.cmbDivision.TabStop = false;
            this.cmbDivision.SelectedIndexChanged += new EventHandler(this.cmbDivision_SelectedIndexChanged);
            this.label6.AutoSize = true;
            this.label6.Location = new Point(515, 39);
            this.label6.Name = "label6";
            this.label6.Size = new Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Подразделение";
            this.labelCompiler.AutoSize = true;
            this.labelCompiler.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.labelCompiler.Location = new Point(515, 13);
            this.labelCompiler.Name = "labelCompiler";
            this.labelCompiler.Size = new Size(83, 13);
            this.labelCompiler.TabIndex = 9;
            this.labelCompiler.Text = "Составитель";
            this.cmbCompiler.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbCompiler.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbCompiler.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompiler", true));
            this.cmbCompiler.FormattingEnabled = true;
            this.cmbCompiler.Location = new Point(605, 5);
            this.cmbCompiler.Name = "cmbCompiler";
            this.cmbCompiler.ReadOnlyBackColor = SystemColors.Window;
            this.cmbCompiler.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbCompiler.Size = new Size(175, 21);
            this.cmbCompiler.TabIndex = 8;
            this.cmbCompiler.SelectedValueChanged += new EventHandler(this.cmbCompiler_SelectedValueChanged);
            this.dtpDateOwner.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateOwner", true));
            this.dtpDateOwner.Enabled = false;
            this.dtpDateOwner.Location = new Point(355, 33);
            this.dtpDateOwner.Name = "dtpDateOwner";
            this.dtpDateOwner.Size = new Size(144, 20);
            this.dtpDateOwner.TabIndex = 7;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(233, 39);
            this.label4.Name = "label4";
            this.label4.Size = new Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата создания";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Автор заявки";
            this.txtOwner.Location = new Point(105, 32);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new Size(122, 20);
            this.txtOwner.TabIndex = 4;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(233, 13);
            this.label2.Name = "label2";
            this.label2.Size = new Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата и время заявки";
            this.dtpDateDoc.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateDoc.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateDoc", true));
            this.dtpDateDoc.Format = DateTimePickerFormat.Custom;
            this.dtpDateDoc.Location = new Point(355, 7);
            this.dtpDateDoc.Name = "dtpDateDoc";
            this.dtpDateDoc.Size = new Size(144, 20);
            this.dtpDateDoc.TabIndex = 2;
            this.dtpDateDoc.ValueChanged += new EventHandler(this.dtpDateDoc_ValueChanged);
            this.dtpDateDoc.Validated += new EventHandler(this.dtpDateDoc_Validated);
            this.labelNumRequest.AutoSize = true;
            this.labelNumRequest.Location = new Point(8, 13);
            this.labelNumRequest.Name = "labelNumRequest";
            this.labelNumRequest.Size = new Size(80, 13);
            this.labelNumRequest.TabIndex = 1;
            this.labelNumRequest.Text = "Номер заявки";
            this.txtNumRequest.BackColor = SystemColors.Window;
            this.txtNumRequest.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.NumRequest", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtNumRequest.Location = new Point(105, 6);
            this.txtNumRequest.Name = "txtNumRequest";
            this.txtNumRequest.Size = new Size(122, 20);
            this.txtNumRequest.TabIndex = 0;
            this.txtNumRequest.TextChanged += new EventHandler(this.txtNumRequest_TextChanged);

            this.tabPageTransformer.Controls.Add(this.splitContainerTrans);
            this.tabPageTransformer.Controls.Add(this.statusStripTrans);
            this.tabPageTransformer.Controls.Add(this.toolStripTransformer);
            this.tabPageTransformer.Location = new Point(4, 22);
            this.tabPageTransformer.Name = "tabPageTransformer";
            this.tabPageTransformer.Padding = new Padding(3);
            this.tabPageTransformer.Size = new Size(961, 619);
            this.tabPageTransformer.TabIndex = 1;
            this.tabPageTransformer.Text = "Отключенные трансформаторы";
            this.tabPageTransformer.UseVisualStyleBackColor = true;
            this.splitContainerTrans.Dock = DockStyle.Fill;
            this.splitContainerTrans.Location = new Point(3, 28);
            this.splitContainerTrans.Name = "splitContainerTrans";
            this.splitContainerTrans.Orientation = Orientation.Horizontal;
            this.splitContainerTrans.Panel1.Controls.Add(this.dgvTrans);
            this.splitContainerTrans.Panel2.Controls.Add(this.dgvTreeSub);
            this.splitContainerTrans.Size = new Size(955, 566);
            this.splitContainerTrans.SplitterDistance = 283;
            this.splitContainerTrans.TabIndex = 4;

            this.dgvTrans.AllowUserToAddRows = false;
            this.dgvTrans.AllowUserToDeleteRows = false;
            this.dgvTrans.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            this.dgvTrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTrans.AutoGenerateColumns = false;
            this.dgvTrans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrans.Columns.AddRange(new DataGridViewColumn[]
            {
            this.subDataGridViewTextBoxColumn,
            this.idSubDataGridViewTextBoxColumn,
            this.idTrDataGridViewTextBoxColumn,
            this.trNameDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.loadDataGridViewTextBoxColumn
            });
            this.dgvTrans.DataSource = this.bsTransON;
            this.dgvTrans.Dock = DockStyle.Fill;
            this.dgvTrans.Location = new Point(0, 0);
            this.dgvTrans.Name = "dgvTrans";
            this.dgvTrans.RowHeadersWidth = 21;
            this.dgvTrans.Size = new Size(955, 283);
            this.dgvTrans.TabIndex = 2;
            this.dgvTrans.CellEndEdit += new DataGridViewCellEventHandler(this.dgvTrans_CellEndEdit);
            this.dgvTrans.RowsAdded += new DataGridViewRowsAddedEventHandler(this.dgvTrans_RowsAdded);
            this.dgvTrans.RowsRemoved += new DataGridViewRowsRemovedEventHandler(this.dgvTrans_RowsRemoved);
            this.subDataGridViewTextBoxColumn.DataPropertyName = "Sub";
            this.subDataGridViewTextBoxColumn.HeaderText = "Подстанция";
            this.subDataGridViewTextBoxColumn.Name = "subDataGridViewTextBoxColumn";
            this.subDataGridViewTextBoxColumn.ReadOnly = true;
            this.subDataGridViewTextBoxColumn.Visible = true;
            this.subDataGridViewTextBoxColumn.Width = 100;
            this.idSubDataGridViewTextBoxColumn.DataPropertyName = "idSub";
            this.idSubDataGridViewTextBoxColumn.HeaderText = "idSub";
            this.idSubDataGridViewTextBoxColumn.Name = "idSubDataGridViewTextBoxColumn";
            this.idSubDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSubDataGridViewTextBoxColumn.Visible = false;

            this.idTrDataGridViewTextBoxColumn.DataPropertyName = "idTr";
            this.idTrDataGridViewTextBoxColumn.HeaderText = "idTr";
            this.idTrDataGridViewTextBoxColumn.Name = "idTrDataGridViewTextBoxColumn";
            this.idTrDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTrDataGridViewTextBoxColumn.Visible = false;

            this.trNameDataGridViewTextBoxColumn.DataPropertyName = "TrName";
            this.trNameDataGridViewTextBoxColumn.HeaderText = "Трасформатор";
            this.trNameDataGridViewTextBoxColumn.Name = "trNameDataGridViewTextBoxColumn";
            this.trNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "Мощность";
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            this.loadDataGridViewTextBoxColumn.DataPropertyName = "Load";
            this.loadDataGridViewTextBoxColumn.HeaderText = "Нагрузка";
            this.loadDataGridViewTextBoxColumn.Name = "loadDataGridViewTextBoxColumn";
            this.bsTransON.DataMember = "tableTrans";
            this.bsTransON.DataSource = this.dataSetAdd;
            this.dataSetAdd.DataSetName = "dataSetAdd";
            this.dataSetAdd.Tables.AddRange(new DataTable[]
            {
            this.tableTransOff,
            this.tableSchmAbnFull
            });
            this.tableTransOff.Columns.AddRange(new DataColumn[]
            {
            this.dataColumnidSub,
            this.dataColumnSub,
            this.dataColumnidTr,
            this.dataColumnTrName,
            this.dataColumnPower,
            this.dataColumnLoad
            });
            this.tableTransOff.TableName = "tableTrans";
            this.dataColumnidSub.ColumnName = "idSub";
            this.dataColumnidSub.DataType = typeof(int);
            this.dataColumnSub.ColumnName = "Sub";
            this.dataColumnidTr.ColumnName = "idTr";
            this.dataColumnidTr.DataType = typeof(int);
            this.dataColumnTrName.ColumnName = "TrName";
            this.dataColumnPower.ColumnName = "Power";
            this.dataColumnPower.DataType = typeof(int);
            this.dataColumnLoad.ColumnName = "Load";
            this.dataColumnLoad.DataType = typeof(int);
            this.tableSchmAbnFull.Columns.AddRange(new DataColumn[]
            {
            this.dataColumnidAbn,
            this.dataColumncodeAbonent,
            this.dataColumnnameAbn,
            this.dataColumntypeAbn,
            this.dataColumnidAbnObj,
            this.dataColumnnameObj,
            this.dataColumnCommentODS,
            this.dataColumnCategoryName,
            this.dataColumnTarifName,
            this.dataColumnVoltage,
            this.dataColumnPowerSet,
            this.dataColumnCountPoint
            ,this.dataColumnidAbnNet
            ,this.dataColumnnameAbnNet
            ,this.dataColumnidSchmObj
            });
            this.tableSchmAbnFull.TableName = "vl_SchmAbnFull2";

            this.dataColumnidAbn.ColumnName = "idAbn";
            this.dataColumnidAbn.DataType = typeof(int);

            this.dataColumncodeAbonent.ColumnName = "codeAbonent";
            this.dataColumncodeAbonent.DataType = typeof(int);

            this.dataColumnnameAbn.ColumnName = "nameAbn";

            this.dataColumntypeAbn.ColumnName = "typeAbn";
            this.dataColumntypeAbn.DataType = typeof(int);

            this.dataColumnidAbnObj.ColumnName = "idAbnObj";
            this.dataColumnidAbnObj.DataType = typeof(int);

            this.dataColumnnameObj.ColumnName = "nameObj";

            this.dataColumnCommentODS.ColumnName = "CommentODS";

            this.dataColumnCategoryName.ColumnName = "CategoryName";

            this.dataColumnTarifName.ColumnName = "TarifName";

            this.dataColumnPowerSet.ColumnName = "PowerSet";
            this.dataColumnPowerSet.DataType = typeof(decimal);

            this.dataColumnCountPoint.ColumnName = "CountPoint";
            this.dataColumnCountPoint.DataType = typeof(int);

            this.dataColumnVoltage.ColumnName = "Voltage";

            this.dataColumnidAbnNet.ColumnName = "idAbnNet";

            this.dataColumnidAbnNet.DataType = typeof(int);
            this.dataColumnnameAbnNet.ColumnName = "nameAbnNet";

            // 
            // dataColumnidSchmObj
            // 
            this.dataColumnidSchmObj.ColumnName = "idSchmObj";
            this.dataColumnidSchmObj.DataType = typeof(int);

            this.dgvTreeSub.AllowUserToAddRows = false;
            this.dgvTreeSub.AllowUserToDeleteRows = false;
            this.dgvTreeSub.Columns.AddRange(new DataGridViewColumn[]
            {
            this.subNameColumn,
            this.idSubColumn,
            this.busNameColumn,
            this.idBusColumn,
            this.cellNameColumn,
            this.idCellColumn,
            this.trNameColumn,
            this.idTrColumn,
            this.powerColumn,
            this.loadColumn,
            this.dateOnColumn,
            this.noAdmissionKWTColumn
            });
            this.dgvTreeSub.Dock = DockStyle.Fill;
            this.dgvTreeSub.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.dgvTreeSub.ImageList = null;
            this.dgvTreeSub.Location = new Point(0, 0);
            this.dgvTreeSub.Name = "dgvTreeSub";
            this.dgvTreeSub.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreeSub.Size = new Size(955, 279);
            this.dgvTreeSub.TabIndex = 3;
            this.dgvTreeSub.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dgvTree_CellFormatting);
            this.dgvTreeSub.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dgvTree_CellMouseClick);
            this.subNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.subNameColumn.DataPropertyName = "SubName";
            this.subNameColumn.DefaultNodeImage = null;
            this.subNameColumn.HeaderText = "Подстанция";
            this.subNameColumn.Name = "subNameColumn";
            this.subNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idSubColumn.DataPropertyName = "idSub";
            this.idSubColumn.HeaderText = "idSub";
            this.idSubColumn.Name = "idSubColumn";
            this.idSubColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idSubColumn.Visible = false;
            this.busNameColumn.DataPropertyName = "BusName";
            this.busNameColumn.HeaderText = "Шина";
            this.busNameColumn.Name = "busNameColumn";
            this.busNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idBusColumn.DataPropertyName = "idBus";
            this.idBusColumn.HeaderText = "idBus";
            this.idBusColumn.Name = "idBusColumn";
            this.idBusColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idBusColumn.Visible = false;
            this.cellNameColumn.DataPropertyName = "CellName";
            this.cellNameColumn.HeaderText = "Ячейка";
            this.cellNameColumn.Name = "cellNameColumn";
            this.cellNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idCellColumn.DataPropertyName = "idCell";
            this.idCellColumn.HeaderText = "idCell";
            this.idCellColumn.Name = "idCellColumn";
            this.idCellColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idCellColumn.Visible = false;
            this.trNameColumn.DataPropertyName = "TrName";
            this.trNameColumn.HeaderText = "Трансформатор";
            this.trNameColumn.Name = "trNameColumn";
            this.trNameColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idTrColumn.DataPropertyName = "idTr";
            this.idTrColumn.HeaderText = "idTr";
            this.idTrColumn.Name = "idTrColumn";
            this.idTrColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.idTrColumn.Visible = false;
            this.powerColumn.DataPropertyName = "Power";
            this.powerColumn.HeaderText = "Мощность";
            this.powerColumn.Name = "powerColumn";
            this.powerColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.loadColumn.DataPropertyName = "Load";
            this.loadColumn.HeaderText = "Нагрузка";
            this.loadColumn.Name = "loadColumn";
            this.loadColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.dateOnColumn.DataPropertyName = "DateOn";
            dataGridViewCellStyle6.Format = "g";
            dataGridViewCellStyle6.NullValue = null;
            this.dateOnColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.dateOnColumn.HeaderText = "Дата включения";
            this.dateOnColumn.Name = "dateOnColumn";
            this.dateOnColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            this.noAdmissionKWTColumn.DataPropertyName = "noAddmissionKWT";
            this.noAdmissionKWTColumn.HeaderText = "Недоотпуск";
            this.noAdmissionKWTColumn.Name = "noAdmissionKWTColumn";
            this.noAdmissionKWTColumn.SortMode = DataGridViewColumnSortMode.NotSortable;


            this.statusStripTrans.Items.AddRange(new ToolStripItem[]
            {
            this.labelCountTr,
            this.labelSumPower,
            this.labelSumLoad
            });
            this.statusStripTrans.Location = new Point(3, 594);
            this.statusStripTrans.Name = "statusStripTrans";
            this.statusStripTrans.Size = new Size(955, 22);
            this.statusStripTrans.TabIndex = 5;
            this.statusStripTrans.Text = "statusStrip1";
            this.labelCountTr.Name = "labelCountTr";
            this.labelCountTr.Size = new Size(313, 17);
            this.labelCountTr.Spring = true;
            this.labelCountTr.Text = "Кол-во трансформаторов: 0";
            this.labelSumPower.Name = "labelSumPower";
            this.labelSumPower.Size = new Size(313, 17);
            this.labelSumPower.Spring = true;
            this.labelSumPower.Text = "Суммарная мощность: 0";
            this.labelSumLoad.Name = "labelSumLoad";
            this.labelSumLoad.Size = new Size(313, 17);
            this.labelSumLoad.Spring = true;
            this.labelSumLoad.Text = "Суммарная нагрузка: 0";
            this.toolStripTransformer.Items.AddRange(new ToolStripItem[]
            {
            this.toolBtnRefreshTrans
            });
            this.toolStripTransformer.Location = new Point(3, 3);
            this.toolStripTransformer.Name = "toolStripTransformer";
            this.toolStripTransformer.Size = new Size(955, 25);
            this.toolStripTransformer.TabIndex = 0;
            this.toolStripTransformer.Text = "toolStrip1";
            this.toolBtnRefreshTrans.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshTrans.Image = global::DailyReportN.Properties.Resources.Refresh;
            this.toolBtnRefreshTrans.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefreshTrans.Name = "toolBtnRefreshTrans";
            this.toolBtnRefreshTrans.Size = new Size(23, 22);
            this.toolBtnRefreshTrans.Text = "Обновить";
            this.toolBtnRefreshTrans.Click += new EventHandler(this.toolBtnRefreshTrans_Click);
            this.tabPageAbn.Controls.Add(this.splitContainerAbnMain);
            this.tabPageAbn.Controls.Add(this.statusStripAbnObj);
            this.tabPageAbn.Location = new Point(4, 22);
            this.tabPageAbn.Name = "tabPageAbn";
            this.tabPageAbn.Padding = new Padding(3);
            this.tabPageAbn.Size = new Size(961, 619);
            this.tabPageAbn.TabIndex = 2;
            this.tabPageAbn.Text = "Отключенные абоненты";
            this.tabPageAbn.UseVisualStyleBackColor = true;
            this.splitContainerAbnMain.Dock = DockStyle.Fill;
            this.splitContainerAbnMain.FixedPanel = FixedPanel.Panel2;
            this.splitContainerAbnMain.IsSplitterFixed = true;
            this.splitContainerAbnMain.Location = new Point(3, 3);
            this.splitContainerAbnMain.Name = "splitContainerAbnMain";
            this.splitContainerAbnMain.Orientation = Orientation.Horizontal;
            this.splitContainerAbnMain.Panel1.Controls.Add(this.dgvAbn);
            this.splitContainerAbnMain.Panel1.Controls.Add(this.toolStripAbn);
            this.splitContainerAbnMain.Panel2.Controls.Add(this.splitContainerAbnCount);
            this.splitContainerAbnMain.Size = new Size(955, 591);
            this.splitContainerAbnMain.SplitterDistance = 380;
            this.splitContainerAbnMain.TabIndex = 7;

            this.dgvAbn.AllowUserToAddRows = false;
            this.dgvAbn.AllowUserToDeleteRows = false;
            this.dgvAbn.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(224, 224, 224);
            this.dgvAbn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAbn.AutoGenerateColumns = false;
            this.dgvAbn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbn.Columns.AddRange(new DataGridViewColumn[]
            {
            this.codeAbonentDataGridViewTextBoxColumn,
            this.idAbnDataGridViewTextBoxColumn,
            this.nameAbnDataGridViewTextBoxColumn,
            this.typeAbnDgvColumn,
            this.idAbnObjDataGridViewTextBoxColumn,
            this.nameObjDataGridViewTextBoxColumn,
            this.categoryNameDgvColumn,
            this.tarifNameDgvColumn,
            this.voltageDgvColumn,
            this.powerSetDgvColumn,
            this.сountPointDgvColumn,
            this.commentODSDgvColumn

            ,this.idAbnNetDataGridViewTextBoxColumn
            ,this.nameAbnNetDataGridViewTextBoxColumn
            ,this.idSchmObjDataGridViewTextBoxColumn
            });
            this.dgvAbn.DataSource = this.bsSchmAbnFull;
            this.dgvAbn.Dock = DockStyle.Fill;
            this.dgvAbn.Location = new Point(0, 25);
            this.dgvAbn.Name = "dgvAbn";
            //this.dgvAbn.ReadOnly = true;
            this.dgvAbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbn.Size = new Size(955, 355);
            this.dgvAbn.TabIndex = 4;
            this.dgvAbn.CellMouseClick += new DataGridViewCellMouseEventHandler(dgvAbn_CellMouseClick);
            this.dgvAbn.CellEndEdit += new DataGridViewCellEventHandler(dgvAbn_CellEndEdit);

            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "codeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.codeAbonentDataGridViewTextBoxColumn.Visible = false;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 5;

            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            this.nameAbnDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.nameAbnDataGridViewTextBoxColumn.DataPropertyName = "nameAbn";
            this.nameAbnDataGridViewTextBoxColumn.FillWeight = 76.81039f;
            this.nameAbnDataGridViewTextBoxColumn.HeaderText = "Абонент";
            this.nameAbnDataGridViewTextBoxColumn.Name = "nameAbnDataGridViewTextBoxColumn";
            this.nameAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAbnDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;

            this.typeAbnDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.typeAbnDgvColumn.DataPropertyName = "typeAbn";
            this.typeAbnDgvColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeAbnDgvColumn.FillWeight = 67.16079f;
            this.typeAbnDgvColumn.HeaderText = "Тип абонента";
            this.typeAbnDgvColumn.Name = "typeAbnDgvColumn";
            this.typeAbnDgvColumn.ReadOnly = true;
            this.typeAbnDgvColumn.Resizable = DataGridViewTriState.True;
            this.idAbnObjDataGridViewTextBoxColumn.DataPropertyName = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.HeaderText = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.idAbnObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnObjDataGridViewTextBoxColumn.Visible = false;
            this.nameObjDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.nameObjDataGridViewTextBoxColumn.DataPropertyName = "nameObj";
            this.nameObjDataGridViewTextBoxColumn.FillWeight = 93.08762f;
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            this.nameObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameObjDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.categoryNameDgvColumn.DataPropertyName = "CategoryName";
            this.categoryNameDgvColumn.HeaderText = "Кат.";
            this.categoryNameDgvColumn.Name = "categoryNameDgvColumn";
            this.categoryNameDgvColumn.ReadOnly = true;
            this.categoryNameDgvColumn.Width = 40;
            // 
            // tarifNameDgvColumn
            // 
            this.tarifNameDgvColumn.DataPropertyName = "TarifName";
            this.tarifNameDgvColumn.HeaderText = "Тариф";
            this.tarifNameDgvColumn.Name = "tarifNameDgvColumn";
            this.tarifNameDgvColumn.ReadOnly = true;
            this.tarifNameDgvColumn.Width = 40;
            // 
            // voltageDgvColumn
            // 
            this.voltageDgvColumn.DataPropertyName = "Voltage";
            this.voltageDgvColumn.HeaderText = "Напряж.";
            this.voltageDgvColumn.Name = "voltageDgvColumn";
            this.voltageDgvColumn.ReadOnly = true;
            this.voltageDgvColumn.Width = 30;

            this.idAbnNetDataGridViewTextBoxColumn.DataPropertyName = "idAbnNet";
            this.idAbnNetDataGridViewTextBoxColumn.HeaderText = "idAbnNet";
            this.idAbnNetDataGridViewTextBoxColumn.Name = "idAbnNeDataGridViewTextBoxColumn";
            this.idAbnNetDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnNetDataGridViewTextBoxColumn.Visible = false;
            //
            this.nameAbnNetDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.nameAbnNetDataGridViewTextBoxColumn.DataPropertyName = "nameAbnNet";
            this.nameAbnNetDataGridViewTextBoxColumn.FillWeight = 76.81039f;
            this.nameAbnNetDataGridViewTextBoxColumn.HeaderText = "Сетевая организация";
            this.nameAbnNetDataGridViewTextBoxColumn.Name = "nameAbnNetDataGridViewTextBoxColumn";
            this.nameAbnNetDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAbnNetDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            // this.nameAbnNetDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSchmObjDataGridViewTextBoxColumn
            // 
            this.idSchmObjDataGridViewTextBoxColumn.DataPropertyName = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.HeaderText = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.Name = "idSchmObjDataGridViewTextBoxColumn";
            this.idSchmObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSchmObjDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idSchmObjDataGridViewTextBoxColumn.Visible = false;

            this.powerSetDgvColumn.DataPropertyName = "PowerSet";
            this.powerSetDgvColumn.HeaderText = "Мощность";
            this.powerSetDgvColumn.Name = "powerSetDgvColumn";
            this.powerSetDgvColumn.ReadOnly = true;
            this.powerSetDgvColumn.Width = 60;
            this.сountPointDgvColumn.DataPropertyName = "CountPoint";
            this.сountPointDgvColumn.HeaderText = "Кол-во т.у.";
            this.сountPointDgvColumn.Name = "сountPointDgvColumn";
            //this.сountPointDgvColumn.ReadOnly = true;
            this.сountPointDgvColumn.Width = 40;
            this.commentODSDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.commentODSDgvColumn.DataPropertyName = "CommentODS";
            this.commentODSDgvColumn.FillWeight = 111.0855f;
            this.commentODSDgvColumn.HeaderText = "Примечание";
            this.commentODSDgvColumn.Name = "commentODSDgvColumn";
            this.commentODSDgvColumn.ReadOnly = true;
            this.bsSchmAbnFull.DataMember = "vl_SchmAbnFull2";
            this.bsSchmAbnFull.DataSource = this.dataSetAdd;
            this.toolStripAbn.Items.AddRange(new ToolStripItem[]
            {
            this.toolBtnRefreshAbn,
            this.toolBtnDelAbn
            , toolBtnLoadSchm
            });
            this.toolStripAbn.Location = new Point(0, 0);
            this.toolStripAbn.Name = "toolStripAbn";
            this.toolStripAbn.Size = new Size(955, 25);
            this.toolStripAbn.TabIndex = 5;
            this.toolStripAbn.Text = "toolStrip1";


            this.toolBtnRefreshAbn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshAbn.Image = global::DailyReportN.Properties.Resources.Refresh;
            this.toolBtnRefreshAbn.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefreshAbn.Name = "toolBtnRefreshAbn";
            this.toolBtnRefreshAbn.Size = new Size(23, 22);
            this.toolBtnRefreshAbn.Text = "Обновить";
            this.toolBtnRefreshAbn.Click += new EventHandler(this.toolBtnRefreshTrans_Click);
            // 
            // toolBrnDelAbn
            // 
            this.toolBtnDelAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelAbn.Image = global::DailyReportN.Properties.Resources.ElementDel;
            this.toolBtnDelAbn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelAbn.Name = "toolBrnDelAbn";
            this.toolBtnDelAbn.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelAbn.Text = "Удалить абонентов";
            this.toolBtnDelAbn.Click += new System.EventHandler(this.toolBtnDelAbn_Click);
            
            //  toolBtnLoadSchm
            this.toolBtnLoadSchm.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnLoadSchm.Image = global::DailyReportN.Properties.Resources.Test;
            this.toolBtnLoadSchm.ImageTransparentColor = Color.Magenta;
            this.toolBtnLoadSchm.Name = "toolBtnLoadSchm";
            this.toolBtnLoadSchm.Size = new Size(23, 22);
            this.toolBtnLoadSchm.Text = "Загрузить схему без потока";
            this.toolBtnLoadSchm.Click += new EventHandler(this.toolBtnLoadSchm_Click);



            this.splitContainerAbnCount.Dock = DockStyle.Fill;
            this.splitContainerAbnCount.FixedPanel = FixedPanel.Panel1;
            this.splitContainerAbnCount.IsSplitterFixed = true;
            this.splitContainerAbnCount.Location = new Point(0, 0);
            this.splitContainerAbnCount.Name = "splitContainerAbnCount";
            this.splitContainerAbnCount.Panel1.Controls.Add(this.numCountPointSource);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.numCountPointEE);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.numCountPointCat3);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.groupBoxAbnObj1Catergory);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.label23);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.label22);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.label21);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.groupBox1);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.label5);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.numCountAbnObjSource);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.numCountAbnObjEE);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.numCountAbnObjCat3);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.label31);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.groupBox4);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.groupBox2);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.label26);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.label27);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.label28);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.groupBox3);
            this.splitContainerAbnCount.Size = new Size(955, 207);
            this.splitContainerAbnCount.SplitterDistance = 377;
            this.splitContainerAbnCount.TabIndex = 0;

            this.numCountPointSource.Location = new Point(17, 179);
            //NumericUpDown numericUpDown = this.numCountPointSource;
            int[] array = new int[4];
            array[0] = 999999;
            numCountPointSource.Maximum = new decimal(array);
            this.numCountPointSource.Name = "numCountPointSource";
            this.numCountPointSource.Size = new Size(144, 20);
            this.numCountPointSource.TabIndex = 11;
            this.numCountPointSource.ValueChanged += new EventHandler(this.numCountPointCat2_ValueChanged);

            this.numCountPointEE.Location = new Point(169, 141);
            //NumericUpDown numericUpDown2 = this.numCountPointEE;
            int[] array2 = new int[4];
            array2[0] = 999999;
            numCountPointEE.Maximum = new decimal(array2);
            this.numCountPointEE.Name = "numCountPointEE";
            this.numCountPointEE.Size = new Size(160, 20);
            this.numCountPointEE.TabIndex = 10;
            this.numCountPointEE.ValueChanged += new EventHandler(this.numCountPointCat2_ValueChanged);

            this.numCountPointCat3.Location = new Point(17, 141);
            //NumericUpDown numericUpDown3 = this.numCountPointCat3;
            int[] array3 = new int[4];
            array3[0] = 999999;
            numCountPointCat3.Maximum = new decimal(array3);
            this.numCountPointCat3.Name = "numCountPointCat3";
            this.numCountPointCat3.Size = new Size(144, 20);
            this.numCountPointCat3.TabIndex = 9;
            this.numCountPointCat3.ValueChanged += new EventHandler(this.numCountPointCat2_ValueChanged);

            this.groupBoxAbnObj1Catergory.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBoxAbnObj1Catergory.Controls.Add(this.numCountPointCat1);
            this.groupBoxAbnObj1Catergory.Controls.Add(this.numCountPointCat1Full);
            this.groupBoxAbnObj1Catergory.Controls.Add(this.label18);
            this.groupBoxAbnObj1Catergory.Controls.Add(this.label14);
            this.groupBoxAbnObj1Catergory.Location = new Point(8, 16);
            this.groupBoxAbnObj1Catergory.Name = "groupBoxAbnObj1Catergory";
            this.groupBoxAbnObj1Catergory.Size = new Size(358, 51);
            this.groupBoxAbnObj1Catergory.TabIndex = 1;
            this.groupBoxAbnObj1Catergory.TabStop = false;
            this.groupBoxAbnObj1Catergory.Text = "1 категория надежности";

            this.numCountPointCat1.Location = new Point(225, 19);
            //NumericUpDown numericUpDown4 = this.numCountPointCat1;
            int[] array4 = new int[4];
            array4[0] = 999999;
            numCountPointCat1.Maximum = new decimal(array4);
            this.numCountPointCat1.Name = "numCountPointCat1";
            this.numCountPointCat1.Size = new Size(96, 20);
            this.numCountPointCat1.TabIndex = 5;
            this.numCountPointCat1.ValueChanged += new EventHandler(this.numCountPointCat2_ValueChanged);

            this.numCountPointCat1Full.Location = new Point(57, 18);
            //NumericUpDown numericUpDown5 = this.numCountPointCat1Full;
            int[] array5 = new int[4];
            array5[0] = 999999;
            numCountPointCat1Full.Maximum = new decimal(array5);
            this.numCountPointCat1Full.Name = "numCountPointCat1Full";
            this.numCountPointCat1Full.Size = new Size(96, 20);
            this.numCountPointCat1Full.TabIndex = 4;
            this.numCountPointCat1Full.ValueChanged += new EventHandler(this.numCountPointCat2_ValueChanged);

            this.label18.AutoSize = true;
            this.label18.Location = new Point(158, 21);
            this.label18.Name = "label18";
            this.label18.Size = new Size(61, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Частичное";
            this.label14.AutoSize = true;
            this.label14.Location = new Point(6, 21);
            this.label14.Name = "label14";
            this.label14.Size = new Size(45, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Полное";
            this.label23.AutoSize = true;
            this.label23.Location = new Point(14, 163);
            this.label23.Name = "label23";
            this.label23.Size = new Size(209, 13);
            this.label23.TabIndex = 7;
            this.label23.Text = "Производители электрической энергии";
            this.label22.AutoSize = true;
            this.label22.Location = new Point(166, 124);
            this.label22.Name = "label22";
            this.label22.Size = new Size(158, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Электросетевая организация";
            this.label21.AutoSize = true;
            this.label21.Location = new Point(14, 124);
            this.label21.Name = "label21";
            this.label21.Size = new Size(132, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "3 категория надежности";
            this.groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBox1.Controls.Add(this.numCountPointCat2Full);
            this.groupBox1.Controls.Add(this.numCountPointCat2);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new Point(8, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(358, 51);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2 категория надежности";

            this.numCountPointCat2Full.Location = new Point(57, 18);
            //NumericUpDown numericUpDown6 = this.numCountPointCat2Full;
            int[] array6 = new int[4];
            array6[0] = 999999;
            numCountPointCat2Full.Maximum = new decimal(array6);
            this.numCountPointCat2Full.Name = "numCountPointCat2Full";
            this.numCountPointCat2Full.Size = new Size(96, 20);
            this.numCountPointCat2Full.TabIndex = 7;
            this.numCountPointCat2Full.ValueChanged += new EventHandler(this.numCountPointCat2_ValueChanged);

            this.numCountPointCat2.Location = new Point(225, 18);
            //        NumericUpDown numericUpDown7 = this.numericUpDown_6;
            int[] array7 = new int[4];
            array7[0] = 999999;
            numCountPointCat2.Maximum = new decimal(array7);
            this.numCountPointCat2.Name = "numCountPointCat2";
            this.numCountPointCat2.Size = new Size(96, 20);
            this.numCountPointCat2.TabIndex = 6;
            this.numCountPointCat2.ValueChanged += new EventHandler(this.numCountPointCat2_ValueChanged);

            this.label19.AutoSize = true;
            this.label19.Location = new Point(158, 21);
            this.label19.Name = "label19";
            this.label19.Size = new Size(61, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Частичное";
            this.label20.AutoSize = true;
            this.label20.Location = new Point(6, 21);
            this.label20.Name = "label20";
            this.label20.Size = new Size(45, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Полное";
            this.label5.AutoSize = true;
            this.label5.Location = new Point(5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new Size(147, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Количество точек поставки";

            this.numCountAbnObjSource.Location = new Point(12, 179);
            //NumericUpDown numCountAbnObjSource = this.numCountAbnObjSource;
            int[] array8 = new int[4];
            array8[0] = 999999;
            numCountAbnObjSource.Maximum = new decimal(array8);
            this.numCountAbnObjSource.Name = "numCountAbnObjSource";
            this.numCountAbnObjSource.Size = new Size(144, 20);
            this.numCountAbnObjSource.TabIndex = 21;
            this.numCountAbnObjSource.ValueChanged += new EventHandler(this.numCountAbnObjCat2Full_ValueChanged);

            this.numCountAbnObjEE.Location = new Point(164, 140);
            //NumericUpDown numericUpDown9 = this.numericUpDown_8;
            int[] array9 = new int[4];
            array9[0] = 999999;
            numCountAbnObjEE.Maximum = new decimal(array9);
            this.numCountAbnObjEE.Name = "numCountAbnObjEE";
            this.numCountAbnObjEE.Size = new Size(160, 20);
            this.numCountAbnObjEE.TabIndex = 20;
            this.numCountAbnObjEE.ValueChanged += new EventHandler(this.numCountAbnObjCat2Full_ValueChanged);

            this.numCountAbnObjCat3.Location = new Point(12, 140);
            //NumericUpDown numericUpDown10 = this.numericUpDown_9;
            int[] array10 = new int[4];
            array10[0] = 999999;
            numCountAbnObjCat3.Maximum = new decimal(array10);
            this.numCountAbnObjCat3.Name = "numCountAbnObjCat3";
            this.numCountAbnObjCat3.Size = new Size(144, 20);
            this.numCountAbnObjCat3.TabIndex = 19;
            this.numCountAbnObjCat3.ValueChanged += new EventHandler(this.numCountAbnObjCat2Full_ValueChanged);

            this.label31.AutoSize = true;
            this.label31.Location = new Point(3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new Size(169, 13);
            this.label31.TabIndex = 18;
            this.label31.Text = "Количество потребителей услуг";
            this.groupBox4.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBox4.Controls.Add(this.numCountAbnObj670);
            this.groupBox4.Controls.Add(this.numCountAbnObj150670);
            this.groupBox4.Controls.Add(this.numCountAbnObj150);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Location = new Point(367, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(200, 183);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Максимальная мощность";
            this.numCountAbnObj670.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

            this.numCountAbnObj670.Location = new Point(9, 112);
            //NumericUpDown numericUpDown11 = this.numCountAbnObj670;
            int[] array11 = new int[4];
            array11[0] = 999999;
            numCountAbnObj670.Maximum = new decimal(array11);
            this.numCountAbnObj670.Name = "numCountAbnObj670";
            this.numCountAbnObj670.Size = new Size(185, 20);
            this.numCountAbnObj670.TabIndex = 11;
            this.numCountAbnObj670.ValueChanged += new EventHandler(this.numCountAbnObjCat2Full_ValueChanged);

            this.numCountAbnObj150670.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.numCountAbnObj150670.Location = new Point(9, 73);
            //NumericUpDown numericUpDown12 = this.numericUpDown_11;
            int[] array12 = new int[4];
            array12[0] = 999999;
            numCountAbnObj150670.Maximum = new decimal(array12);
            this.numCountAbnObj150670.Name = "numCountAbnObj150670";
            this.numCountAbnObj150670.Size = new Size(185, 20);
            this.numCountAbnObj150670.TabIndex = 10;
            this.numCountAbnObj150670.ValueChanged += new EventHandler(this.numCountAbnObjCat2Full_ValueChanged);

            this.numCountAbnObj150.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.numCountAbnObj150.Location = new Point(9, 34);
            //NumericUpDown numericUpDown13 = this.numericUpDown_12;
            int[] array13 = new int[4];
            array13[0] = 999999;
            numCountAbnObj150.Maximum = new decimal(array13);
            this.numCountAbnObj150.Name = "numCountAbnObj150";
            this.numCountAbnObj150.Size = new Size(185, 20);
            this.numCountAbnObj150.TabIndex = 9;
            this.numCountAbnObj150.ValueChanged += new EventHandler(this.numCountAbnObjCat2Full_ValueChanged);

            this.label34.AutoSize = true;
            this.label34.Location = new Point(6, 96);
            this.label34.Name = "label34";
            this.label34.Size = new Size(62, 13);
            this.label34.TabIndex = 7;
            this.label34.Text = "От 670 кВт";
            this.label33.AutoSize = true;
            this.label33.Location = new Point(6, 57);
            this.label33.Name = "label33";
            this.label33.Size = new Size(98, 13);
            this.label33.TabIndex = 5;
            this.label33.Text = "От 150 до 670 кВт";
            this.label32.AutoSize = true;
            this.label32.Location = new Point(6, 18);
            this.label32.Name = "label32";
            this.label32.Size = new Size(64, 13);
            this.label32.TabIndex = 0;
            this.label32.Text = "До 150 кВт";
            this.groupBox2.Controls.Add(this.numCountAbnObjCat1);
            this.groupBox2.Controls.Add(this.numCountAbnObjCat1Full);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Location = new Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(358, 51);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "1 категория надежности";

            this.numCountAbnObjCat1.Location = new Point(225, 19);
            //NumericUpDown numericUpDown14 = this.numCountAbnObjCat1;
            int[] array14 = new int[4];
            array14[0] = 999999;
            numCountAbnObjCat1.Maximum = new decimal(array14);
            this.numCountAbnObjCat1.Name = "numCountAbnObjCat1";
            this.numCountAbnObjCat1.Size = new Size(96, 20);
            this.numCountAbnObjCat1.TabIndex = 6;
            this.numCountAbnObjCat1.ValueChanged += new EventHandler(this.numCountAbnObjCat2Full_ValueChanged);

            this.numCountAbnObjCat1Full.Location = new Point(53, 18);
            //NumericUpDown numericUpDown15 = this.numCountAbnObjCat1Full;
            int[] array15 = new int[4];
            array15[0] = 999999;
            numCountAbnObjCat1Full.Maximum = new decimal(array15);
            this.numCountAbnObjCat1Full.Name = "numCountAbnObjCat1Full";
            this.numCountAbnObjCat1Full.Size = new Size(96, 20);
            this.numCountAbnObjCat1Full.TabIndex = 5;
            this.numCountAbnObjCat1Full.ValueChanged += new EventHandler(this.numCountAbnObjCat2Full_ValueChanged);

            this.label24.AutoSize = true;
            this.label24.Location = new Point(158, 21);
            this.label24.Name = "label24";
            this.label24.Size = new Size(61, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Частичное";
            this.label25.AutoSize = true;
            this.label25.Location = new Point(6, 21);
            this.label25.Name = "label25";
            this.label25.Size = new Size(45, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Полное";
            this.label26.AutoSize = true;
            this.label26.Location = new Point(9, 163);
            this.label26.Name = "label26";
            this.label26.Size = new Size(209, 13);
            this.label26.TabIndex = 15;
            this.label26.Text = "Производители электрической энергии";
            this.label27.AutoSize = true;
            this.label27.Location = new Point(161, 124);
            this.label27.Name = "label27";
            this.label27.Size = new Size(158, 13);
            this.label27.TabIndex = 13;
            this.label27.Text = "Электросетевая организация";
            this.label28.AutoSize = true;
            this.label28.Location = new Point(9, 124);
            this.label28.Name = "label28";
            this.label28.Size = new Size(132, 13);
            this.label28.TabIndex = 11;
            this.label28.Text = "3 категория надежности";
            this.groupBox3.Controls.Add(this.numCountAbnObjCat2);
            this.groupBox3.Controls.Add(this.numCountAbnObjCat2Full);
            this.groupBox3.Controls.Add(this.label29);
            this.groupBox3.Controls.Add(this.label30);
            this.groupBox3.Location = new Point(3, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(358, 51);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2 категория надежности";

            this.numCountAbnObjCat2.Location = new Point(225, 18);
            //NumericUpDown numericUpDown16 = this.numCountAbnObjCat2;
            int[] array16 = new int[4];
            array16[0] = 999999;
            numCountAbnObjCat2.Maximum = new decimal(array16);
            this.numCountAbnObjCat2.Name = "numCountAbnObjCat2";
            this.numCountAbnObjCat2.Size = new Size(96, 20);
            this.numCountAbnObjCat2.TabIndex = 7;
            this.numCountAbnObjCat2.ValueChanged += new EventHandler(this.numCountAbnObjCat2Full_ValueChanged);

            this.numCountAbnObjCat2Full.Location = new Point(53, 18);
            //NumericUpDown numericUpDown17 = this.numCountAbnObjCat2Full;
            int[] array17 = new int[4];
            array17[0] = 999999;
            numCountAbnObjCat2Full.Maximum = new decimal(array17);
            this.numCountAbnObjCat2Full.Name = "numCountAbnObjCat2Full";
            this.numCountAbnObjCat2Full.Size = new Size(96, 20);
            this.numCountAbnObjCat2Full.TabIndex = 6;
            this.numCountAbnObjCat2Full.ValueChanged += new EventHandler(this.numCountAbnObjCat2Full_ValueChanged);

            this.label29.AutoSize = true;
            this.label29.Location = new Point(158, 21);
            this.label29.Name = "label29";
            this.label29.Size = new Size(61, 13);
            this.label29.TabIndex = 2;
            this.label29.Text = "Частичное";
            this.label30.AutoSize = true;
            this.label30.Location = new Point(6, 21);
            this.label30.Name = "label30";
            this.label30.Size = new Size(45, 13);
            this.label30.TabIndex = 0;
            this.label30.Text = "Полное";
            this.statusStripAbnObj.Items.AddRange(new ToolStripItem[]
            {
            this.toolBtnRefreshCountAbn,
            this.labelCountPoint,
            this.labelCountAbnObj,
            this.labelCountAbn
            });
            this.statusStripAbnObj.Location = new Point(3, 594);
            this.statusStripAbnObj.Name = "statusStripAbnObj";
            this.statusStripAbnObj.Size = new Size(955, 22);
            this.statusStripAbnObj.TabIndex = 6;
            this.statusStripAbnObj.Text = "statusStrip1";
            this.toolBtnRefreshCountAbn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshCountAbn.Image = global::DailyReportN.Properties.Resources.Refresh;
            this.toolBtnRefreshCountAbn.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefreshCountAbn.Name = "toolBtnRefreshCountAbn";
            this.toolBtnRefreshCountAbn.ShowDropDownArrow = false;
            this.toolBtnRefreshCountAbn.Size = new Size(20, 20);
            this.toolBtnRefreshCountAbn.Text = "Обновить итоги";
            this.toolBtnRefreshCountAbn.Click += new EventHandler(this.toolBtnRefreshCountAbn_Click);

            this.labelCountPoint.Name = "labelCountPoint";
            this.labelCountPoint.Size = new Size(306, 17);
            this.labelCountPoint.Spring = true;
            this.labelCountPoint.Text = "Количество точек поставки: 0";
            this.labelCountAbnObj.Name = "labelCountAbnObj";
            this.labelCountAbnObj.Size = new Size(306, 17);
            this.labelCountAbnObj.Spring = true;
            this.labelCountAbnObj.Text = "Количество объектов: 0";
            this.labelCountAbn.Name = "labelCountAbn";
            this.labelCountAbn.Size = new Size(306, 17);
            this.labelCountAbn.Spring = true;
            this.labelCountAbn.Text = "Количество абонентов: 0";
            this.buttonClose.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.buttonClose.DialogResult = DialogResult.Cancel;
            this.buttonClose.Location = new Point(880, 651);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            this.buttonSave.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.buttonSave.DialogResult = DialogResult.OK;
            this.buttonSave.Location = new Point(13, 651);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);

            this.backgroundWorker.DoWork += new DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);

            this.labelProgress.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new Point(93, 656);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new Size(222, 13);
            this.labelProgress.TabIndex = 3;
            this.labelProgress.Text = "Загрузка отключенных трансформаторов ";
            this.labelProgress.Visible = false;

            this.progressBar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.progressBar.Location = new Point(321, 651);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new Size(553, 23);
            this.progressBar.Style = ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible = false;
            this.dataGridViewComboBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn1.FillWeight = 50f;
            this.dataGridViewComboBoxColumn1.HeaderText = "Тип объекта";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn0.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn0.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn0.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewButtonColumn1.FillWeight = 40f;
            this.dataGridViewButtonColumn1.HeaderText = "";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Text = "...";
            this.dataGridViewButtonColumn1.ToolTipText = "Выбрать объект";
            this.dataGridViewButtonColumn1.Width = 25;
            this.dataGridViewComboBoxColumn2.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn2.HeaderText = "Участок";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewComboBoxColumn2.Width = 60;
            this.dataGridViewComboBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn3.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn3.HeaderText = "Повреждение";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn4.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn4.HeaderText = "Уточнение";
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewComboBoxColumn4.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn4.SortMode = DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "idDamage";
            this.dataGridViewTextBoxColumn4.HeaderText = "idDamage";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "countSchmObj";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество подстанций";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "noAdmissionKWT";
            this.dataGridViewTextBoxColumn6.HeaderText = "Недопуск эл.энергии";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Sub";
            this.dataGridViewTextBoxColumn13.HeaderText = "Подстанция";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn14.DataPropertyName = "idSub";
            this.dataGridViewTextBoxColumn14.HeaderText = "idSub";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Visible = false;
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Power";
            this.dataGridViewTextBoxColumn17.HeaderText = "Мощность";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Load";
            this.dataGridViewTextBoxColumn18.HeaderText = "Нагрузка";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.toolTipDocParent.IsBalloon = true;
            this.toolTipDocParent.ShowAlways = true;
            this.contextMenuDgvTree.Items.AddRange(new ToolStripItem[]
            {
            this.toolMenuItemOn,
            this.toolMenuItemOff
            });
            this.contextMenuDgvTree.Name = "contextMenuDgvTree";
            this.contextMenuDgvTree.Size = new Size(137, 48);
            this.toolMenuItemOn.Name = "toolMenuItemOn";
            this.toolMenuItemOn.Size = new Size(136, 22);
            this.toolMenuItemOn.Text = "Включить";
            this.toolMenuItemOn.Click += new EventHandler(this.toolMenuItemOn_Click);
            this.toolMenuItemOff.Name = "toolMenuItemOff";
            this.toolMenuItemOff.Size = new Size(136, 22);
            this.toolMenuItemOff.Text = "Отключить";
            this.toolMenuItemOff.Click += new EventHandler(this.toolMenuItemOff_Click);

            base.AcceptButton = this.buttonSave;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.buttonClose;
            base.ClientSize = new Size(967, 682);
            base.Controls.Add(this.progressBar);
            base.Controls.Add(this.labelProgress);
            base.Controls.Add(this.buttonSave);
            base.Controls.Add(this.buttonClose);
            base.Controls.Add(this.tabControlMain);
            base.Name = "FormDamageHVAddEdit";
            this.Text = "FormDamageHVAddEdit";
            base.FormClosing += new FormClosingEventHandler(this.FormDamageHVAddEdit_FormClosing);
            base.Load += new EventHandler(this.FormDamageHVAddEdit_Load);
            base.Shown += new EventHandler(this.FormDamageHVAddEdit_Shown);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.toolStrip81.ResumeLayout(false);
            this.toolStrip81.PerformLayout();
            this.splitContainerMainGeneral.Panel1.ResumeLayout(false);
            this.splitContainerMainGeneral.Panel1.PerformLayout();
            this.splitContainerMainGeneral.Panel2.ResumeLayout(false);
            this.splitContainerMainGeneral.ResumeLayout(false);
            ((ISupportInitialize)this.dataSetDamage).EndInit();
            this.groupBoxDefectData.ResumeLayout(false);
            this.groupBoxDefectData.PerformLayout();
            ((ISupportInitialize)this.dgvCharacterDamage).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxDefect.ResumeLayout(false);
            this.groupBoxDefect.PerformLayout();
            this.splitContainerWorkApplyGeneral.Panel1.ResumeLayout(false);
            this.splitContainerWorkApplyGeneral.Panel1.PerformLayout();
            this.splitContainerWorkApplyGeneral.Panel2.ResumeLayout(false);
            this.splitContainerWorkApplyGeneral.Panel2.PerformLayout();
            this.splitContainerWorkApplyGeneral.ResumeLayout(false);
            ((ISupportInitialize)this.dgvOn).EndInit();
            this.tabPageTransformer.ResumeLayout(false);
            this.tabPageTransformer.PerformLayout();
            this.splitContainerTrans.Panel1.ResumeLayout(false);
            this.splitContainerTrans.Panel2.ResumeLayout(false);
            this.splitContainerTrans.ResumeLayout(false);
            ((ISupportInitialize)this.dgvTrans).EndInit();
            ((ISupportInitialize)this.bsTransON).EndInit();
            ((ISupportInitialize)this.dataSetAdd).EndInit();
            ((ISupportInitialize)this.tableTransOff).EndInit();
            ((ISupportInitialize)this.tableSchmAbnFull).EndInit();
            ((ISupportInitialize)this.dgvTreeSub).EndInit();
            this.statusStripTrans.ResumeLayout(false);
            this.statusStripTrans.PerformLayout();
            this.toolStripTransformer.ResumeLayout(false);
            this.toolStripTransformer.PerformLayout();
            this.tabPageAbn.ResumeLayout(false);
            this.tabPageAbn.PerformLayout();
            this.splitContainerAbnMain.Panel1.ResumeLayout(false);
            this.splitContainerAbnMain.Panel1.PerformLayout();
            this.splitContainerAbnMain.Panel2.ResumeLayout(false);
            this.splitContainerAbnMain.ResumeLayout(false);
            ((ISupportInitialize)this.dgvAbn).EndInit();
            ((ISupportInitialize)this.bsSchmAbnFull).EndInit();
            this.toolStripAbn.ResumeLayout(false);
            this.toolStripAbn.PerformLayout();
            this.splitContainerAbnCount.Panel1.ResumeLayout(false);
            this.splitContainerAbnCount.Panel1.PerformLayout();
            this.splitContainerAbnCount.Panel2.ResumeLayout(false);
            this.splitContainerAbnCount.Panel2.PerformLayout();
            this.splitContainerAbnCount.ResumeLayout(false);
            ((ISupportInitialize)this.numCountPointSource).EndInit();
            ((ISupportInitialize)this.numCountPointEE).EndInit();
            ((ISupportInitialize)this.numCountPointCat3).EndInit();
            this.groupBoxAbnObj1Catergory.ResumeLayout(false);
            this.groupBoxAbnObj1Catergory.PerformLayout();
            ((ISupportInitialize)this.numCountPointCat1).EndInit();
            ((ISupportInitialize)this.numCountPointCat1Full).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((ISupportInitialize)this.numCountPointCat2Full).EndInit();
            ((ISupportInitialize)this.numCountPointCat2).EndInit();
            ((ISupportInitialize)this.numCountAbnObjSource).EndInit();
            ((ISupportInitialize)this.numCountAbnObjEE).EndInit();
            ((ISupportInitialize)this.numCountAbnObjCat3).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((ISupportInitialize)this.numCountAbnObj670).EndInit();
            ((ISupportInitialize)this.numCountAbnObj150670).EndInit();
            ((ISupportInitialize)this.numCountAbnObj150).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((ISupportInitialize)this.numCountAbnObjCat1).EndInit();
            ((ISupportInitialize)this.numCountAbnObjCat1Full).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((ISupportInitialize)this.numCountAbnObjCat2).EndInit();
            ((ISupportInitialize)this.numCountAbnObjCat2Full).EndInit();
            this.statusStripAbnObj.ResumeLayout(false);
            this.statusStripAbnObj.PerformLayout();
            this.contextMenuDgvTree.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }




        //private void dgvCharacterDamage_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private DailyReportN.DataSet.dsDamage.tJ_DamageDataTable tableDamage;

        private DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable tableDamageCharacter;



        //private Class171.Class176 tableDamageOn;
        private DailyReportN.DataSet.dsDamage.tJ_DamageOnDataTable tableDamageOn;

        private TabControl tabControlMain;

        private TabPage tabPageGeneral;

        private TabPage tabPageTransformer;

        private Button buttonClose;

        private Button buttonSave;

        private ComboBoxReadOnly cmbDivision;

        private Label label6;

        private Label labelCompiler;

        private ComboBoxReadOnly cmbCompiler;

        private DateTimePicker dtpDateOwner;

        private Label label4;

        private Label label3;

        private TextBox txtOwner;

        private Label label2;

        private DateTimePicker dtpDateDoc;

        private Label labelNumRequest;

        private TextBox txtNumRequest;

        private GroupBox groupBoxDefectData;

        private Button btnChoiceSchmObj;

        private Label labelSchmObj;

        private TextBox txtSchmObj;

        private RichTextBox txtLocation;

        private GroupBox groupBoxResult;

        private NullableDateTimePicker dtpDataApply;

        private Label labelDateAplly;

        private ComboBoxReadOnly cmbWorkerApply;

        private CheckBox checkBoxApply;

        private RichTextBox txtCompletedWork;

        private Label labelCompletedWork;

        private ComboBoxReadOnly cmbCompletedWork;

        private DataGridView dgvCharacterDamage;

        private ComboBoxReadOnly cmbReason;

        private Label labelReason;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn0;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        private SplitContainer splitContainerMainGeneral;

        private ComboBoxReadOnly cmbTypeRZA;

        private Label labelTypeRZA;

        private SplitContainer splitContainerWorkApplyGeneral;

        private DataGridViewExcelFilter dgvOn;

        private Label labelDamageOn;

        private Label label1;

        private Label labelSumNoAdmissionKWT;

        private TextBox txtNoKWT;

        private Label labelPowerV;

        private TextBox txtV;

        private Label label11;

        private TextBox txtA;

        private TextBox txtKWT;

        private Label label10;

        private TextBox txtCountSchmObj;

        private Label label9;

        private TextBox txtCosFi;

        private Label label16;

        private Label label15;

        private TextBox txtCountSchmObjOff;

        private ToolStrip toolStripTransformer;

        private ToolStripButton toolBtnRefreshTrans;

        private DataGridViewComboBoxColumn ColumnTypeObj;

        private DataGridViewTextBoxColumn ColumnSchmObj;

        private DataGridViewTextBoxColumn columnIdSchmObj;

        private DataGridViewButtonColumn ColumnBtn;

        private DataGridViewComboBoxColumn ColumnCabSection;

        private DataGridViewComboBoxColumn Column2;

        private DataGridViewComboBoxColumn Column3;

        private DataGridViewExcelFilter dgvTrans;

        private System.Data.DataSet dataSetAdd;

        private DataTable tableTransOff;

        private DataColumn dataColumnidSub;

        private DataColumn dataColumnSub;

        private DataColumn dataColumnidTr;

        private DataColumn dataColumnTrName;

        private DataColumn dataColumnPower;

        private DataColumn dataColumnLoad;

        internal DataTable tableSchmAbnFull;

        private DataColumn dataColumnidAbn;

        private DataColumn dataColumncodeAbonent;

        private DataColumn dataColumnnameAbn;

        private DataColumn dataColumntypeAbn;

        private DataColumn dataColumnidAbnObj;

        private DataColumn dataColumnnameObj;

private DataColumn dataColumnnameAbnNet;

private DataColumn dataColumnidAbnNet;


        private TabPage tabPageAbn;

        private DataGridViewExcelFilter dgvAbn;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;

        private BackgroundWorker backgroundWorker;

        private BindingSource bsTransON;

        private Label labelProgress;

        private ProgressBar progressBar;

        private BindingSource bsSchmAbnFull;

        private ToolStrip toolStripAbn;

        private ToolStripButton toolBtnRefreshAbn;

        private ToolStripButton toolBtnDelAbn;

        private DataGridViewTextBoxColumn subDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idSubDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idTrDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn trNameDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn loadDataGridViewTextBoxColumn;

        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;

        private DataGridViewButtonColumn dataGridViewButtonColumn1;

        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;

        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;

        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;

        private Label label17;

        private Label labelDamageCharacter;

        private Button buttonLoadTextBoxSum;

        private GroupBox groupBoxDefect;

        private RichTextBox txtLaboratoryInstruction;

        private Label labelLaboratoryInstruction;

        private RichTextBox txtDivisionInstruction;

        private Label labelDivisionInstruction;

        private CheckBox chbDefect;

        private Label labelDivisionApply;

        private CheckBox checkBoxLaboratory;

        private ComboBoxReadOnly cmbDivisionApply;

        private Label label7;

        private TextBox txtCoefSeason;

        private DataGridViewTextBoxColumn dateBegDgvColumn;

        private DataGridViewTextBoxColumn countSchmObjOffDgvColumn;

        private ComboBox cmbAVR;

        private Label label8;

        private ComboBox cmbAPV;

        private Label label12;

        private TextBox txtDocParent;

        private Label label13;

        private Button btnRequestForRepair;

        private ToolTip toolTipDocParent;

        private TreeDataGridView dgvTreeSub;

        private SplitContainer splitContainerTrans;

        private StatusStrip statusStripTrans;

        private ToolStripStatusLabel labelCountTr;

        private ToolStripStatusLabel labelSumPower;

        private ToolStripStatusLabel labelSumLoad;

        private StatusStrip statusStripAbnObj;

        private ToolStripStatusLabel labelCountPoint;

        private ToolStripStatusLabel labelCountAbn;

        private DataGridViewFilterDateTimePickerColumn dateOnDgvColumn;

        private DataGridViewTextBoxColumn countSchmObjDgvColumn;

        private DataGridViewTextBoxColumn noAdmissionKWTDgvColumn;

        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;

        private DataGridViewTextBoxColumn idDamageDataGridViewTextBoxColumn1;

        // private Class171 class171_0;
        internal DailyReportN.DataSet.dsDamage dataSetDamage;

        private ContextMenuStrip contextMenuDgvTree;

        private ToolStripMenuItem toolMenuItemOn;

        private TreeGridColumn subNameColumn;

        private DataGridViewTextBoxColumn idSubColumn;

        private DataGridViewTextBoxColumn busNameColumn;

        private DataGridViewTextBoxColumn idBusColumn;

        private DataGridViewTextBoxColumn cellNameColumn;

        private DataGridViewTextBoxColumn idCellColumn;

        private DataGridViewTextBoxColumn trNameColumn;

        private DataGridViewTextBoxColumn idTrColumn;

        private DataGridViewTextBoxColumn powerColumn;

        private DataGridViewTextBoxColumn loadColumn;

        private DataGridViewTextBoxColumn dateOnColumn;

        private DataGridViewTextBoxColumn noAdmissionKWTColumn;

        private RadioButton rbOnFact;

        private RadioButton rbOnAverage;

        private ToolStripMenuItem toolMenuItemOff;

        private DataColumn dataColumnCommentODS;

        private ToolStrip toolStrip81;

        private ToolStripButton toolBtn81;

        private SplitContainer splitContainerAbnMain;

        private SplitContainer splitContainerAbnCount;

        private GroupBox groupBoxAbnObj1Catergory;

        private Label label18;

        private Label label14;

        private Label label23;

        private Label label22;

        private Label label21;

        private GroupBox groupBox1;

        private Label label19;

        private Label label20;

        private Label label5;

        private Label label31;

        private GroupBox groupBox4;

        private Label label34;

        private Label label33;

        private Label label32;

        private GroupBox groupBox2;

        private Label label24;

        private Label label25;

        private Label label26;

        private Label label27;

        private Label label28;

        private GroupBox groupBox3;

        private Label label29;

        private Label label30;

        private ToolStripDropDownButton toolBtnRefreshCountAbn;

        private NumericUpDown numCountPointSource;

        private NumericUpDown numCountPointEE;

        private NumericUpDown numCountPointCat3;

        private NumericUpDown numCountPointCat1;

        private NumericUpDown numCountPointCat1Full;

        private NumericUpDown numCountPointCat2Full;

        private NumericUpDown numCountPointCat2;

        private NumericUpDown numCountAbnObjSource;

        private NumericUpDown numCountAbnObjEE;

        private NumericUpDown numCountAbnObjCat3;

        private NumericUpDown numCountAbnObj670;

        private NumericUpDown numCountAbnObj150670;

        private NumericUpDown numCountAbnObj150;

        private NumericUpDown numCountAbnObjCat1;

        private NumericUpDown numCountAbnObjCat1Full;

        private NumericUpDown numCountAbnObjCat2;

        private NumericUpDown numCountAbnObjCat2Full;

        private ToolStripStatusLabel labelCountAbnObj;

        private DataColumn dataColumnCategoryName;

        private DataColumn dataColumnPowerSet;

        private DataColumn dataColumnCountPoint;

        private DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idAbnNetDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nameAbnNetDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nameAbnDataGridViewTextBoxColumn;

        private DataGridViewFilterComboBoxColumn typeAbnDgvColumn;

        private DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn categoryNameDgvColumn;

        private DataGridViewFilterTextBoxColumn powerSetDgvColumn;

        private DataGridViewFilterTextBoxColumn сountPointDgvColumn;

        private DataGridViewFilterTextBoxColumn commentODSDgvColumn;
        private System.Windows.Forms.CheckBox chkSendSiteME;
        private System.Data.DataColumn dataColumnTarifName;
        private System.Data.DataColumn dataColumnVoltage;
        private DataGridViewFilterTextBoxColumn tarifNameDgvColumn;
        private DataGridViewFilterTextBoxColumn voltageDgvColumn;
        private Label label37;
        private TextBox txtNumRequestME;
        private ToolStripButton toolBtnLoadSchm;
        private System.Data.DataColumn dataColumnidSchmObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSchmObjDataGridViewTextBoxColumn;
    }
}