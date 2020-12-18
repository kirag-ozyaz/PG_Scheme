using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace DailyReportN.JournalDamage
{
    internal partial class FormDamageLVAddEdit : FormLbr.FormBase
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.toolStrip81 = new System.Windows.Forms.ToolStrip();
            this.toolBtn81 = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxDefectData = new System.Windows.Forms.GroupBox();
            this.btnRequestForRepair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocParent = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelObl = new System.Windows.Forms.Label();
            this.cmbObl = new ControlsLbr.ComboBoxReadOnly();
            this.txtHousePrefix = new System.Windows.Forms.TextBox();
            this.labelRaionObl = new System.Windows.Forms.Label();
            this.cmbRaionObl = new ControlsLbr.ComboBoxReadOnly();
            this.labelHousePrefix = new System.Windows.Forms.Label();
            this.cmbCity = new ControlsLbr.ComboBoxReadOnly();
            this.labelCity = new System.Windows.Forms.Label();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.cmbStreet = new ControlsLbr.ComboBoxReadOnly();
            this.dataSetDamage = new DailyReportN.DataSet.dsDamage();
            this.labelHouse = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.RichTextBox();
            this.dgvCharacterDamage = new System.Windows.Forms.DataGridView();
            this.ColumnTypeObj = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnSchmObj = new DataGridViewTextBoxColumn();
            this.columnIdSchmObj = new DataGridViewTextBoxColumn();
            this.ColumnBtn = new DataGridViewButtonColumn();
            this.ColumnCabSection = new DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label1ChatacterDamage = new System.Windows.Forms.Label();
            this.labelReason = new System.Windows.Forms.Label();
            this.cmbReason = new ControlsLbr.ComboBoxReadOnly();
            this.btnChoiceSchmObj = new System.Windows.Forms.Button();
            this.labelSchmObj = new System.Windows.Forms.Label();
            this.txtSchmObj = new System.Windows.Forms.TextBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.dtpDataApply = new ControlsLbr.NullableDateTimePicker();
            this.labelDateAplly = new System.Windows.Forms.Label();
            this.cmbWorkerApply = new ControlsLbr.ComboBoxReadOnly();
            this.checkBoxApply = new System.Windows.Forms.CheckBox();
            this.txtCompletedWork = new System.Windows.Forms.RichTextBox();
            this.labelCompletedWork = new System.Windows.Forms.Label();
            this.cmbCompletedWork = new ControlsLbr.ComboBoxReadOnly();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtLaboratoryInstruction = new System.Windows.Forms.RichTextBox();
            this.labelLaboratoryInstruction = new System.Windows.Forms.Label();
            this.txtDivisionInstruction = new System.Windows.Forms.RichTextBox();
            this.labelDivisionInstruction = new System.Windows.Forms.Label();
            this.chbDefect = new System.Windows.Forms.CheckBox();
            this.labelDivisionApply = new System.Windows.Forms.Label();
            this.checkBoxLaboratory = new System.Windows.Forms.CheckBox();
            this.cmbDivisionApply = new ControlsLbr.ComboBoxReadOnly();
            this.groupBoxDeclarer = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeclarerAddress = new System.Windows.Forms.TextBox();
            this.txtDeclarerTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDeclarer = new System.Windows.Forms.TextBox();
            this.cmbDivision = new ControlsLbr.ComboBoxReadOnly();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCompiler = new System.Windows.Forms.Label();
            this.cmbCompiler = new ControlsLbr.ComboBoxReadOnly();
            this.dtpDateOwner = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.labelDateDoc = new System.Windows.Forms.Label();
            this.dtpDateDoc = new ControlsLbr.NullableDateTimePicker();
            this.labelNumRequest = new System.Windows.Forms.Label();
            this.txtNumRequest = new System.Windows.Forms.TextBox();
            this.tabPageWeather = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTempComment = new System.Windows.Forms.RichTextBox();
            this.dsDamageN = new DailyReportN.DataSet.dsDamage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSpeedUp = new System.Windows.Forms.TextBox();
            this.txtSpeedDown = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbWindDirect = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTempAverage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNightUp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNightDown = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDayUp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDayDown = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tabPagePTS = new System.Windows.Forms.TabPage();
            this.txtReasonPTS = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbReasonPTS = new ControlsLbr.ComboBoxReadOnly();
            this.tabPageAbn = new System.Windows.Forms.TabPage();
            this.splitContainerAbn = new System.Windows.Forms.SplitContainer();
            this.dgvAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAbnDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeAbnDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterComboBoxColumn();
            this.idAbnObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.categoryNameDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.powerSetDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countPointDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.commentODSDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.tarifNameDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.voltageDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.bsSchmAbnFull = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAdd = new System.Data.DataSet();
            this.tableTransOff = new System.Data.DataTable();
            this.dataColumnidSub = new System.Data.DataColumn();
            this.dataColumnSub = new System.Data.DataColumn();
            this.dataColumnidTr = new System.Data.DataColumn();
            this.dataColumnTrName = new System.Data.DataColumn();
            this.dataColumnPower = new System.Data.DataColumn();
            this.dataColumnLoad = new System.Data.DataColumn();
            this.tableSchmAbnFull = new System.Data.DataTable();
            this.dataColumnidAbn = new System.Data.DataColumn();
            this.dataColumncodeAbonent = new System.Data.DataColumn();
            this.dataColumnnameAbn = new System.Data.DataColumn();
            this.dataColumntypeAbn = new System.Data.DataColumn();
            this.dataColumnidAbnObj = new System.Data.DataColumn();
            this.dataColumnnameObj = new System.Data.DataColumn();
            this.dataColumnCommentODS = new System.Data.DataColumn();
            this.dataColumnCategoryName = new System.Data.DataColumn();
            this.dataColumnTarifName = new System.Data.DataColumn();
            this.dataColumnVoltage = new System.Data.DataColumn();
            this.dataColumnPowerSet = new System.Data.DataColumn();
            this.dataColumncountPoint = new System.Data.DataColumn();
            this.splitContainerAbnCount = new System.Windows.Forms.SplitContainer();
            this.numCountPointSource = new System.Windows.Forms.NumericUpDown();
            this.numCountPointEE = new System.Windows.Forms.NumericUpDown();
            this.numCountPointCat3 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxAbnObj1Catergory = new System.Windows.Forms.GroupBox();
            this.numCountPointCat1 = new System.Windows.Forms.NumericUpDown();
            this.numCountPointCat1Full = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numCountPointCat2Full = new System.Windows.Forms.NumericUpDown();
            this.numCountPointCat2 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.numCountAbnObjSource = new System.Windows.Forms.NumericUpDown();
            this.numCountAbnObjEE = new System.Windows.Forms.NumericUpDown();
            this.numCountAbnObjCat3 = new System.Windows.Forms.NumericUpDown();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numCountAbnObj670 = new System.Windows.Forms.NumericUpDown();
            this.numCountAbnObj150670 = new System.Windows.Forms.NumericUpDown();
            this.numCountAbnObj150 = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.numCountAbnObjCat1 = new System.Windows.Forms.NumericUpDown();
            this.numCountAbnObjCat1Full = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.numCountAbnObjCat2 = new System.Windows.Forms.NumericUpDown();
            this.numCountAbnObjCat2Full = new System.Windows.Forms.NumericUpDown();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.statusStripAbnObj = new System.Windows.Forms.StatusStrip();
            this.toolBtnRefreshCountAbn = new System.Windows.Forms.ToolStripDropDownButton();
            this.labelCountPoint = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelCountAbnObj = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelCountAbn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripAbn = new System.Windows.Forms.ToolStrip();
            this.toolBtnRefreshAbn = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelAbn = new System.Windows.Forms.ToolStripButton();
            this.tabPageTransformer = new System.Windows.Forms.TabPage();
            this.splitContainerTrans = new System.Windows.Forms.SplitContainer();
            this.dgvTrans = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bsTransON = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTreeSub = new ControlsLbr.TreeDataGridView();
            this.subNameColumn = new ControlsLbr.TreeGridColumn();
            this.idSubColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCellColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTrColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOnColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noAdmissionKWTColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStripTrans = new System.Windows.Forms.StatusStrip();
            this.labelCountTr = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelSumPower = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelSumLoad = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTransformer = new System.Windows.Forms.ToolStrip();
            this.toolBtnRefreshTrans = new System.Windows.Forms.ToolStripButton();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolTipDocParent = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuDgvTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuItemOn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemOff = new System.Windows.Forms.ToolStripMenuItem();
            this.subDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataColumnnameAbnNet = new DataColumn();
            this.dataColumnidAbnNet = new DataColumn();
            this.dataColumnidSchmObj = new System.Data.DataColumn();
            this.chkSendSiteME = new System.Windows.Forms.CheckBox();
            this.label37 = new System.Windows.Forms.Label();
            this.txtNumRequestME = new System.Windows.Forms.TextBox();
            this.idAbnNetDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameAbnNetDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.idSchmObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.toolStrip81.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxDefectData.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacterDamage)).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxDeclarer.SuspendLayout();
            this.tabPageWeather.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDamageN)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPagePTS.SuspendLayout();
            this.tabPageAbn.SuspendLayout();
            this.splitContainerAbn.Panel1.SuspendLayout();
            this.splitContainerAbn.Panel2.SuspendLayout();
            this.splitContainerAbn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSchmAbnFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTransOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSchmAbnFull)).BeginInit();
            this.splitContainerAbnCount.Panel1.SuspendLayout();
            this.splitContainerAbnCount.Panel2.SuspendLayout();
            this.splitContainerAbnCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointEE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointCat3)).BeginInit();
            this.groupBoxAbnObj1Catergory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointCat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointCat1Full)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointCat2Full)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointCat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjEE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat3)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObj670)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObj150670)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObj150)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat1Full)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat2Full)).BeginInit();
            this.statusStripAbnObj.SuspendLayout();
            this.toolStripAbn.SuspendLayout();
            this.tabPageTransformer.SuspendLayout();
            this.splitContainerTrans.Panel1.SuspendLayout();
            this.splitContainerTrans.Panel2.SuspendLayout();
            this.splitContainerTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreeSub)).BeginInit();
            this.statusStripTrans.SuspendLayout();
            this.toolStripTransformer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageWeather);
            this.tabControl1.Controls.Add(this.tabPagePTS);
            this.tabControl1.Controls.Add(this.tabPageAbn);
            this.tabControl1.Controls.Add(this.tabPageTransformer);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 621);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.label37);
            this.tabPageGeneral.Controls.Add(this.txtNumRequestME);
            this.tabPageGeneral.Controls.Add(this.chkSendSiteME);
            this.tabPageGeneral.Controls.Add(this.toolStrip81);
            this.tabPageGeneral.Controls.Add(this.splitContainer1);
            this.tabPageGeneral.Controls.Add(this.groupBoxDeclarer);
            this.tabPageGeneral.Controls.Add(this.cmbDivision);
            this.tabPageGeneral.Controls.Add(this.label6);
            this.tabPageGeneral.Controls.Add(this.labelCompiler);
            this.tabPageGeneral.Controls.Add(this.cmbCompiler);
            this.tabPageGeneral.Controls.Add(this.dtpDateOwner);
            this.tabPageGeneral.Controls.Add(this.label4);
            this.tabPageGeneral.Controls.Add(this.label3);
            this.tabPageGeneral.Controls.Add(this.txtOwner);
            this.tabPageGeneral.Controls.Add(this.labelDateDoc);
            this.tabPageGeneral.Controls.Add(this.dtpDateDoc);
            this.tabPageGeneral.Controls.Add(this.labelNumRequest);
            this.tabPageGeneral.Controls.Add(this.txtNumRequest);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(1048, 595);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Общий";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // toolStrip81
            // 
            this.toolStrip81.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip81.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip81.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip81.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip81.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtn81});
            this.toolStrip81.Location = new System.Drawing.Point(1014, 3);
            this.toolStrip81.Name = "toolStrip81";
            this.toolStrip81.Size = new System.Drawing.Size(31, 31);
            this.toolStrip81.TabIndex = 26;
            this.toolStrip81.Text = "toolStrip1";
            // 
            // toolBtn81
            // 
            this.toolBtn81.Checked = true;
            this.toolBtn81.CheckOnClick = true;
            this.toolBtn81.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBtn81.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtn81.Image = global::DailyReportN.Properties.Resources.not81;
            this.toolBtn81.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtn81.Name = "toolBtn81";
            this.toolBtn81.Size = new System.Drawing.Size(28, 28);
            this.toolBtn81.Text = "Использовать в бюллетене 8.1";
            this.toolBtn81.CheckedChanged += new System.EventHandler(this.toolBtn81_CheckedChanged);

            // 
            // chkSendSiteME
            // 
            this.chkSendSiteME.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSendSiteME.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            //this.chkSendSiteME.Dock = DockStyle.None;
            this.chkSendSiteME.AutoSize = false;
            this.chkSendSiteME.Location = new System.Drawing.Point(780, 35);
            this.chkSendSiteME.Name = "chkSendSiteME";
            this.chkSendSiteME.Size = new System.Drawing.Size(265, 17);
            this.chkSendSiteME.TabIndex = 20;
            this.chkSendSiteME.Text = "chkSendSiteME";
            this.chkSendSiteME.UseVisualStyleBackColor = true;
            this.chkSendSiteME.CheckedChanged += new EventHandler(this.chkSendSiteME_CheckedChanged);
            //this.chkSendSiteME.CheckStateChanged += new EventHandler(this.chkSendSiteME_CheckedChanged);
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
            this.txtNumRequestME.Size = new System.Drawing.Size(100, 20);
            this.txtNumRequestME.TabIndex = 28;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 166);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDefectData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxResult);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer1.Size = new System.Drawing.Size(1048, 429);
            this.splitContainer1.SplitterDistance = 481;
            this.splitContainer1.TabIndex = 19;
            // 
            // groupBoxDefectData
            // 
            this.groupBoxDefectData.Controls.Add(this.btnRequestForRepair);
            this.groupBoxDefectData.Controls.Add(this.label2);
            this.groupBoxDefectData.Controls.Add(this.txtDocParent);
            this.groupBoxDefectData.Controls.Add(this.label18);
            this.groupBoxDefectData.Controls.Add(this.groupBox4);
            this.groupBoxDefectData.Controls.Add(this.txtLocation);
            this.groupBoxDefectData.Controls.Add(this.dgvCharacterDamage);
            this.groupBoxDefectData.Controls.Add(this.label1ChatacterDamage);
            this.groupBoxDefectData.Controls.Add(this.labelReason);
            this.groupBoxDefectData.Controls.Add(this.cmbReason);
            this.groupBoxDefectData.Controls.Add(this.btnChoiceSchmObj);
            this.groupBoxDefectData.Controls.Add(this.labelSchmObj);
            this.groupBoxDefectData.Controls.Add(this.txtSchmObj);
            this.groupBoxDefectData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDefectData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDefectData.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDefectData.Name = "groupBoxDefectData";
            this.groupBoxDefectData.Size = new System.Drawing.Size(481, 429);
            this.groupBoxDefectData.TabIndex = 13;
            this.groupBoxDefectData.TabStop = false;
            this.groupBoxDefectData.Text = "Исходные данные";
            // 
            // btnRequestForRepair
            // 
            this.btnRequestForRepair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRequestForRepair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRequestForRepair.Location = new System.Drawing.Point(447, 19);
            this.btnRequestForRepair.Name = "btnRequestForRepair";
            this.btnRequestForRepair.Size = new System.Drawing.Size(27, 20);
            this.btnRequestForRepair.TabIndex = 24;
            this.btnRequestForRepair.Text = "...";
            this.btnRequestForRepair.UseVisualStyleBackColor = true;
            this.btnRequestForRepair.Click += new System.EventHandler(this.btnRequestForRepair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Документ-основание";
            // 
            // txtDocParent
            // 
            this.txtDocParent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocParent.BackColor = System.Drawing.SystemColors.Window;
            this.txtDocParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDocParent.Location = new System.Drawing.Point(146, 20);
            this.txtDocParent.Name = "txtDocParent";
            this.txtDocParent.ReadOnly = true;
            this.txtDocParent.Size = new System.Drawing.Size(295, 20);
            this.txtDocParent.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(14, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 13);
            this.label18.TabIndex = 19;
            this.label18.Text = "Место повреждения";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.labelObl);
            this.groupBox4.Controls.Add(this.cmbObl);
            this.groupBox4.Controls.Add(this.txtHousePrefix);
            this.groupBox4.Controls.Add(this.labelRaionObl);
            this.groupBox4.Controls.Add(this.cmbRaionObl);
            this.groupBox4.Controls.Add(this.labelHousePrefix);
            this.groupBox4.Controls.Add(this.cmbCity);
            this.groupBox4.Controls.Add(this.labelCity);
            this.groupBox4.Controls.Add(this.txtHouse);
            this.groupBox4.Controls.Add(this.labelStreet);
            this.groupBox4.Controls.Add(this.cmbStreet);
            this.groupBox4.Controls.Add(this.labelHouse);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(11, 100);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(465, 102);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Адрес";
            // 
            // labelObl
            // 
            this.labelObl.AutoSize = true;
            this.labelObl.Location = new System.Drawing.Point(6, 16);
            this.labelObl.Name = "labelObl";
            this.labelObl.Size = new System.Drawing.Size(50, 13);
            this.labelObl.TabIndex = 2;
            this.labelObl.Text = "Область";
            // 
            // cmbObl
            // 
            this.cmbObl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbObl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbObl.FormattingEnabled = true;
            this.cmbObl.Location = new System.Drawing.Point(6, 32);
            this.cmbObl.Name = "cmbObl";
            this.cmbObl.ReadOnlyBackColor = System.Drawing.SystemColors.Window;
            this.cmbObl.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbObl.Size = new System.Drawing.Size(179, 21);
            this.cmbObl.TabIndex = 3;
            this.cmbObl.ValueMember = "tR_KladrObj.Id";
            this.cmbObl.SelectedIndexChanged += new System.EventHandler(this.cmbObl_SelectedIndexChanged);
            // 
            // txtHousePrefix
            // 
            this.txtHousePrefix.BackColor = System.Drawing.SystemColors.Window;
            this.txtHousePrefix.Location = new System.Drawing.Point(352, 72);
            this.txtHousePrefix.Name = "txtHousePrefix";
            this.txtHousePrefix.Size = new System.Drawing.Size(64, 20);
            this.txtHousePrefix.TabIndex = 17;
            this.txtHousePrefix.TextChanged += new System.EventHandler(this.txtCompletedWork_TextChanged);
            // 
            // labelRaionObl
            // 
            this.labelRaionObl.AutoSize = true;
            this.labelRaionObl.Location = new System.Drawing.Point(203, 16);
            this.labelRaionObl.Name = "labelRaionObl";
            this.labelRaionObl.Size = new System.Drawing.Size(72, 13);
            this.labelRaionObl.TabIndex = 4;
            this.labelRaionObl.Text = "Район/город";
            // 
            // cmbRaionObl
            // 
            this.cmbRaionObl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRaionObl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRaionObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbRaionObl.FormattingEnabled = true;
            this.cmbRaionObl.Location = new System.Drawing.Point(195, 32);
            this.cmbRaionObl.Name = "cmbRaionObl";
            this.cmbRaionObl.ReadOnlyBackColor = System.Drawing.SystemColors.Window;
            this.cmbRaionObl.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbRaionObl.Size = new System.Drawing.Size(172, 21);
            this.cmbRaionObl.TabIndex = 5;
            this.cmbRaionObl.ValueMember = "tR_KladrObj.Id";
            this.cmbRaionObl.SelectedIndexChanged += new System.EventHandler(this.cmbRaionObl_SelectedIndexChanged);
            // 
            // labelHousePrefix
            // 
            this.labelHousePrefix.AutoSize = true;
            this.labelHousePrefix.Location = new System.Drawing.Point(349, 56);
            this.labelHousePrefix.Name = "labelHousePrefix";
            this.labelHousePrefix.Size = new System.Drawing.Size(53, 13);
            this.labelHousePrefix.TabIndex = 16;
            this.labelHousePrefix.Text = "Префикс";
            // 
            // cmbCity
            // 
            this.cmbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(373, 32);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.ReadOnlyBackColor = System.Drawing.SystemColors.Window;
            this.cmbCity.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCity.Size = new System.Drawing.Size(86, 21);
            this.cmbCity.TabIndex = 7;
            this.cmbCity.ValueMember = "tR_KladrObj.Id";
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(382, 16);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(102, 13);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "Населенный пункт";
            // 
            // txtHouse
            // 
            this.txtHouse.BackColor = System.Drawing.SystemColors.Window;
            this.txtHouse.Location = new System.Drawing.Point(273, 72);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(63, 20);
            this.txtHouse.TabIndex = 15;
            this.txtHouse.TextChanged += new System.EventHandler(this.txtHouse_TextChanged);
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(6, 56);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(39, 13);
            this.labelStreet.TabIndex = 10;
            this.labelStreet.Text = "Улица";
            // 
            // cmbStreet
            // 
            this.cmbStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStreet.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idStreet", true));
            this.cmbStreet.DisplayMember = "tR_KladrStreet.NameSocr";
            this.cmbStreet.FormattingEnabled = true;
            this.cmbStreet.Location = new System.Drawing.Point(6, 72);
            this.cmbStreet.Name = "cmbStreet";
            this.cmbStreet.ReadOnlyBackColor = System.Drawing.SystemColors.Window;
            this.cmbStreet.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbStreet.Size = new System.Drawing.Size(244, 21);
            this.cmbStreet.TabIndex = 11;
            this.cmbStreet.ValueMember = "tR_KladrStreet.Id";
            this.cmbStreet.SelectedIndexChanged += new System.EventHandler(this.cmbStreet_SelectedIndexChanged);
            // 
            // dataSetDamage
            // 
            this.dataSetDamage.DataSetName = "DataSetDamage";
            this.dataSetDamage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Location = new System.Drawing.Point(270, 56);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(30, 13);
            this.labelHouse.TabIndex = 14;
            this.labelHouse.Text = "Дом";
            // 
            // txtLocation
            // 
            this.txtLocation.AcceptsTab = true;
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_Damage.DefectLocation", true));
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLocation.Location = new System.Drawing.Point(11, 221);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(463, 42);
            this.txtLocation.TabIndex = 0;
            this.txtLocation.Text = "";
            // 
            // dgvCharacterDamage
            // 
            this.dgvCharacterDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCharacterDamage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharacterDamage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTypeObj,
            this.ColumnSchmObj,
            this.columnIdSchmObj,
            this.ColumnBtn,
            this.ColumnCabSection,
            this.Column2,
            this.Column3});
            this.dgvCharacterDamage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCharacterDamage.Location = new System.Drawing.Point(0, 288);
            this.dgvCharacterDamage.Name = "dgvCharacterDamage";
            this.dgvCharacterDamage.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dgvCharacterDamage.Size = new System.Drawing.Size(481, 135);
            this.dgvCharacterDamage.TabIndex = 7;
            this.dgvCharacterDamage.CellContentClick += new DataGridViewCellEventHandler(this.dgvCharacterDamage_CellContentClick);
            this.dgvCharacterDamage.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvCharacterDamage_CurrentCellDirtyStateChanged);
            this.dgvCharacterDamage.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvCharacterDamage_DataError);
            
            this.dgvCharacterDamage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCharacterDamage_MouseClick);
            // 
            // ColumnTypeObj
            // 
            this.ColumnTypeObj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColumnTypeObj.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnTypeObj.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnTypeObj.HeaderText = "Тип объекта";
            this.ColumnTypeObj.Name = "ColumnTypeObj";
            this.ColumnTypeObj.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnTypeObj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            //
            // ColumnSchmObj
            //
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
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column2.HeaderText = "Повреждение";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Column3.HeaderText = "Уточнение";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1ChatacterDamage
            // 
            this.label1ChatacterDamage.AutoSize = true;
            this.label1ChatacterDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1ChatacterDamage.Location = new System.Drawing.Point(14, 265);
            this.label1ChatacterDamage.Name = "label1ChatacterDamage";
            this.label1ChatacterDamage.Size = new System.Drawing.Size(126, 13);
            this.label1ChatacterDamage.TabIndex = 6;
            this.label1ChatacterDamage.Text = "Характер повреждения";
            // 
            // labelReason
            // 
            this.labelReason.AutoSize = true;
            this.labelReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReason.Location = new System.Drawing.Point(14, 78);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(86, 13);
            this.labelReason.TabIndex = 4;
            this.labelReason.Text = "Неисправность";
            // 
            // cmbReason
            // 
            this.cmbReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReason.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idReason", true));
            this.cmbReason.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new System.Drawing.Point(106, 75);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.ReadOnlyBackColor = System.Drawing.SystemColors.Window;
            this.cmbReason.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbReason.Size = new System.Drawing.Size(368, 21);
            this.cmbReason.TabIndex = 5;
            this.cmbReason.SelectedIndexChanged += new System.EventHandler(this.cmbReason_SelectedIndexChanged);
            // 
            // btnChoiceSchmObj
            // 
            this.btnChoiceSchmObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoiceSchmObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChoiceSchmObj.Location = new System.Drawing.Point(447, 47);
            this.btnChoiceSchmObj.Name = "btnChoiceSchmObj";
            this.btnChoiceSchmObj.Size = new System.Drawing.Size(27, 20);
            this.btnChoiceSchmObj.TabIndex = 2;
            this.btnChoiceSchmObj.Text = "...";
            this.btnChoiceSchmObj.UseVisualStyleBackColor = true;
            this.btnChoiceSchmObj.Click += new System.EventHandler(this.btnChoiceSchmObj_Click);
            // 
            // labelSchmObj
            // 
            this.labelSchmObj.AutoSize = true;
            this.labelSchmObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSchmObj.Location = new System.Drawing.Point(14, 50);
            this.labelSchmObj.Name = "labelSchmObj";
            this.labelSchmObj.Size = new System.Drawing.Size(108, 13);
            this.labelSchmObj.TabIndex = 1;
            this.labelSchmObj.Text = "Подстанция\\ячейка";
            // 
            // txtSchmObj
            // 
            this.txtSchmObj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSchmObj.BackColor = System.Drawing.SystemColors.Window;
            this.txtSchmObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSchmObj.Location = new System.Drawing.Point(146, 47);
            this.txtSchmObj.Name = "txtSchmObj";
            this.txtSchmObj.ReadOnly = true;
            this.txtSchmObj.Size = new System.Drawing.Size(295, 20);
            this.txtSchmObj.TabIndex = 0;
            this.txtSchmObj.TextChanged += new System.EventHandler(this.txtSchmObj_TextChanged);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResult.Controls.Add(this.dtpDataApply);
            this.groupBoxResult.Controls.Add(this.labelDateAplly);
            this.groupBoxResult.Controls.Add(this.cmbWorkerApply);
            this.groupBoxResult.Controls.Add(this.checkBoxApply);
            this.groupBoxResult.Controls.Add(this.txtCompletedWork);
            this.groupBoxResult.Controls.Add(this.labelCompletedWork);
            this.groupBoxResult.Controls.Add(this.cmbCompletedWork);
            this.groupBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxResult.Location = new System.Drawing.Point(3, 0);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(551, 201);
            this.groupBoxResult.TabIndex = 14;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат (принятые меры)";
            // 
            // dtpDataApply
            // 
            this.dtpDataApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDataApply.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDataApply.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Damage.DateApply", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpDataApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDataApply.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataApply.Location = new System.Drawing.Point(415, 169);
            this.dtpDataApply.Name = "dtpDataApply";
            this.dtpDataApply.Size = new System.Drawing.Size(128, 20);
            this.dtpDataApply.TabIndex = 6;
            this.dtpDataApply.Value = new System.DateTime(2015, 8, 6, 10, 0, 53, 2);
            this.dtpDataApply.ValueChanged += new System.EventHandler(this.dtpDataApply_ValueChanged);
            // 
            // labelDateAplly
            // 
            this.labelDateAplly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDateAplly.AutoSize = true;
            this.labelDateAplly.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateAplly.Location = new System.Drawing.Point(332, 175);
            this.labelDateAplly.Name = "labelDateAplly";
            this.labelDateAplly.Size = new System.Drawing.Size(77, 13);
            this.labelDateAplly.TabIndex = 5;
            this.labelDateAplly.Text = "Дата и время";
            // 
            // cmbWorkerApply
            // 
            this.cmbWorkerApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbWorkerApply.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWorkerApply.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWorkerApply.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idWorkerApply", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbWorkerApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbWorkerApply.FormattingEnabled = true;
            this.cmbWorkerApply.Location = new System.Drawing.Point(130, 170);
            this.cmbWorkerApply.Name = "cmbWorkerApply";
            this.cmbWorkerApply.ReadOnlyBackColor = System.Drawing.SystemColors.Window;
            this.cmbWorkerApply.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbWorkerApply.Size = new System.Drawing.Size(196, 21);
            this.cmbWorkerApply.TabIndex = 4;
            this.cmbWorkerApply.SelectedIndexChanged += new System.EventHandler(this.cmbWorkerApply_SelectedIndexChanged);
            // 
            // checkBoxApply
            // 
            this.checkBoxApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxApply.AutoSize = true;
            this.checkBoxApply.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetDamage, "tJ_Damage.isApply", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxApply.Location = new System.Drawing.Point(13, 174);
            this.checkBoxApply.Name = "checkBoxApply";
            this.checkBoxApply.Size = new System.Drawing.Size(82, 17);
            this.checkBoxApply.TabIndex = 3;
            this.checkBoxApply.Text = "Исполнено";
            this.checkBoxApply.UseVisualStyleBackColor = true;
            this.checkBoxApply.CheckedChanged += new System.EventHandler(this.checkBoxApply_CheckedChanged);
            // 
            // txtCompletedWork
            // 
            this.txtCompletedWork.AcceptsTab = true;
            this.txtCompletedWork.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompletedWork.BackColor = System.Drawing.SystemColors.Window;
            this.txtCompletedWork.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_Damage.ComletedWorkText", true));
            this.txtCompletedWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCompletedWork.Location = new System.Drawing.Point(9, 47);
            this.txtCompletedWork.Name = "txtCompletedWork";
            this.txtCompletedWork.Size = new System.Drawing.Size(536, 121);
            this.txtCompletedWork.TabIndex = 2;
            this.txtCompletedWork.Text = "";
            this.txtCompletedWork.TextChanged += new System.EventHandler(this.txtCompletedWork_TextChanged);
            // 
            // labelCompletedWork
            // 
            this.labelCompletedWork.AutoSize = true;
            this.labelCompletedWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompletedWork.Location = new System.Drawing.Point(10, 22);
            this.labelCompletedWork.Name = "labelCompletedWork";
            this.labelCompletedWork.Size = new System.Drawing.Size(114, 13);
            this.labelCompletedWork.TabIndex = 1;
            this.labelCompletedWork.Text = "Выполненная работа";
            // 
            // cmbCompletedWork
            // 
            this.cmbCompletedWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCompletedWork.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompletedWork", true));
            this.cmbCompletedWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCompletedWork.FormattingEnabled = true;
            this.cmbCompletedWork.Location = new System.Drawing.Point(130, 19);
            this.cmbCompletedWork.Name = "cmbCompletedWork";
            this.cmbCompletedWork.ReadOnlyBackColor = System.Drawing.SystemColors.Window;
            this.cmbCompletedWork.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCompletedWork.Size = new System.Drawing.Size(415, 21);
            this.cmbCompletedWork.TabIndex = 0;
            this.cmbCompletedWork.SelectedIndexChanged += new System.EventHandler(this.cmbCompletedWork_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtLaboratoryInstruction);
            this.groupBox5.Controls.Add(this.labelLaboratoryInstruction);
            this.groupBox5.Controls.Add(this.txtDivisionInstruction);
            this.groupBox5.Controls.Add(this.labelDivisionInstruction);
            this.groupBox5.Controls.Add(this.chbDefect);
            this.groupBox5.Controls.Add(this.labelDivisionApply);
            this.groupBox5.Controls.Add(this.checkBoxLaboratory);
            this.groupBox5.Controls.Add(this.cmbDivisionApply);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(3, 204);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(551, 215);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Журнал дефектов";
            // 
            // txtLaboratoryInstruction
            // 
            this.txtLaboratoryInstruction.AcceptsTab = true;
            this.txtLaboratoryInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLaboratoryInstruction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_Damage.LaboratoryInstruction", true));
            this.txtLaboratoryInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLaboratoryInstruction.Location = new System.Drawing.Point(81, 145);
            this.txtLaboratoryInstruction.Name = "txtLaboratoryInstruction";
            this.txtLaboratoryInstruction.Size = new System.Drawing.Size(464, 58);
            this.txtLaboratoryInstruction.TabIndex = 22;
            this.txtLaboratoryInstruction.Text = "";
            this.txtLaboratoryInstruction.Visible = false;
            this.txtLaboratoryInstruction.TextChanged += new System.EventHandler(this.txtCompletedWork_TextChanged);
            // 
            // labelLaboratoryInstruction
            // 
            this.labelLaboratoryInstruction.AutoSize = true;
            this.labelLaboratoryInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLaboratoryInstruction.Location = new System.Drawing.Point(6, 145);
            this.labelLaboratoryInstruction.Name = "labelLaboratoryInstruction";
            this.labelLaboratoryInstruction.Size = new System.Drawing.Size(57, 13);
            this.labelLaboratoryInstruction.TabIndex = 21;
            this.labelLaboratoryInstruction.Text = "Указания";
            this.labelLaboratoryInstruction.Visible = false;
            // 
            // txtDivisionInstruction
            // 
            this.txtDivisionInstruction.AcceptsTab = true;
            this.txtDivisionInstruction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDivisionInstruction.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_Damage.DivisionInstruction", true));
            this.txtDivisionInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDivisionInstruction.Location = new System.Drawing.Point(81, 61);
            this.txtDivisionInstruction.Name = "txtDivisionInstruction";
            this.txtDivisionInstruction.Size = new System.Drawing.Size(464, 58);
            this.txtDivisionInstruction.TabIndex = 20;
            this.txtDivisionInstruction.Text = "";
            this.txtDivisionInstruction.Visible = false;
            this.txtDivisionInstruction.TextChanged += new System.EventHandler(this.txtCompletedWork_TextChanged);
            // 
            // labelDivisionInstruction
            // 
            this.labelDivisionInstruction.AutoSize = true;
            this.labelDivisionInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDivisionInstruction.Location = new System.Drawing.Point(6, 61);
            this.labelDivisionInstruction.Name = "labelDivisionInstruction";
            this.labelDivisionInstruction.Size = new System.Drawing.Size(57, 13);
            this.labelDivisionInstruction.TabIndex = 19;
            this.labelDivisionInstruction.Text = "Указания";
            this.labelDivisionInstruction.Visible = false;
            // 
            // chbDefect
            // 
            this.chbDefect.AutoSize = true;
            this.chbDefect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbDefect.Location = new System.Drawing.Point(6, 25);
            this.chbDefect.Name = "chbDefect";
            this.chbDefect.Size = new System.Drawing.Size(66, 17);
            this.chbDefect.TabIndex = 18;
            this.chbDefect.Text = "Дефект";
            this.chbDefect.UseVisualStyleBackColor = true;
            this.chbDefect.CheckedChanged += new System.EventHandler(this.chbDefect_CheckedChanged);
            // 
            // labelDivisionApply
            // 
            this.labelDivisionApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDivisionApply.Location = new System.Drawing.Point(78, 19);
            this.labelDivisionApply.Name = "labelDivisionApply";
            this.labelDivisionApply.Size = new System.Drawing.Size(96, 27);
            this.labelDivisionApply.TabIndex = 15;
            this.labelDivisionApply.Text = "Подразделение исполнитель";
            this.labelDivisionApply.Visible = false;
            // 
            // checkBoxLaboratory
            // 
            this.checkBoxLaboratory.AutoSize = true;
            this.checkBoxLaboratory.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetDamage, "tJ_Damage.isLaboratory", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxLaboratory.Enabled = false;
            this.checkBoxLaboratory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxLaboratory.Location = new System.Drawing.Point(6, 125);
            this.checkBoxLaboratory.Name = "checkBoxLaboratory";
            this.checkBoxLaboratory.Size = new System.Drawing.Size(191, 17);
            this.checkBoxLaboratory.TabIndex = 17;
            this.checkBoxLaboratory.Text = "Производственная лаборатория";
            this.checkBoxLaboratory.UseVisualStyleBackColor = true;
            this.checkBoxLaboratory.Visible = false;
            this.checkBoxLaboratory.CheckedChanged += new System.EventHandler(this.checkBoxLaboratory_CheckedChanged);
            // 
            // cmbDivisionApply
            // 
            this.cmbDivisionApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDivisionApply.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDivisionApply.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDivisionApply.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDivisionApply.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idDivisionApply", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDivisionApply.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDivisionApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbDivisionApply.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDivisionApply.FormattingEnabled = true;
            this.cmbDivisionApply.Location = new System.Drawing.Point(180, 21);
            this.cmbDivisionApply.Name = "cmbDivisionApply";
            this.cmbDivisionApply.ReadOnly = true;
            this.cmbDivisionApply.ReadOnlyBackColor = System.Drawing.SystemColors.Window;
            this.cmbDivisionApply.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDivisionApply.Size = new System.Drawing.Size(365, 21);
            this.cmbDivisionApply.TabIndex = 16;
            this.cmbDivisionApply.TabStop = false;
            this.cmbDivisionApply.Visible = false;
            this.cmbDivisionApply.SelectedIndexChanged += new System.EventHandler(this.cmbDivisionApply_SelectedIndexChanged);
            this.cmbDivisionApply.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbDivisionApply_KeyDown);
            // 
            // groupBoxDeclarer
            // 
            this.groupBoxDeclarer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDeclarer.Controls.Add(this.label8);
            this.groupBoxDeclarer.Controls.Add(this.txtDeclarerAddress);
            this.groupBoxDeclarer.Controls.Add(this.txtDeclarerTel);
            this.groupBoxDeclarer.Controls.Add(this.label7);
            this.groupBoxDeclarer.Controls.Add(this.txtDeclarer);
            this.groupBoxDeclarer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDeclarer.Location = new System.Drawing.Point(11, 85);
            this.groupBoxDeclarer.Name = "groupBoxDeclarer";
            this.groupBoxDeclarer.Size = new System.Drawing.Size(1027, 75);
            this.groupBoxDeclarer.TabIndex = 12;
            this.groupBoxDeclarer.TabStop = false;
            this.groupBoxDeclarer.Text = "Заявитель";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Адрес заявителя";
            // 
            // txtDeclarerAddress
            // 
            this.txtDeclarerAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeclarerAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtDeclarerAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_DamageLV.DeclarerAddress", true));
            this.txtDeclarerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDeclarerAddress.Location = new System.Drawing.Point(106, 45);
            this.txtDeclarerAddress.Name = "txtDeclarerAddress";
            this.txtDeclarerAddress.Size = new System.Drawing.Size(915, 20);
            this.txtDeclarerAddress.TabIndex = 3;
            this.txtDeclarerAddress.TextChanged += new System.EventHandler(this.txtCompletedWork_TextChanged);
            // 
            // txtDeclarerTel
            // 
            this.txtDeclarerTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeclarerTel.BackColor = System.Drawing.SystemColors.Window;
            this.txtDeclarerTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_DamageLV.DeclarerTel", true));
            this.txtDeclarerTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDeclarerTel.Location = new System.Drawing.Point(332, 19);
            this.txtDeclarerTel.Name = "txtDeclarerTel";
            this.txtDeclarerTel.Size = new System.Drawing.Size(689, 20);
            this.txtDeclarerTel.TabIndex = 2;
            this.txtDeclarerTel.TextChanged += new System.EventHandler(this.txtCompletedWork_TextChanged);
            this.txtDeclarerTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeclarerTel_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(274, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Телефон";
            // 
            // txtDeclarer
            // 
            this.txtDeclarer.BackColor = System.Drawing.SystemColors.Window;
            this.txtDeclarer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_DamageLV.Declarer", true));
            this.txtDeclarer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDeclarer.Location = new System.Drawing.Point(6, 19);
            this.txtDeclarer.Name = "txtDeclarer";
            this.txtDeclarer.Size = new System.Drawing.Size(262, 20);
            this.txtDeclarer.TabIndex = 0;
            this.txtDeclarer.TextChanged += new System.EventHandler(this.txtCompletedWork_TextChanged);
            // 
            // cmbDivision
            // 
            this.cmbDivision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDivision.BackColor = System.Drawing.SystemColors.Control;
            this.cmbDivision.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idDivision", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDivision.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(388, 59);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.ReadOnly = true;
            this.cmbDivision.ReadOnlyBackColor = System.Drawing.SystemColors.Window;
            this.cmbDivision.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbDivision.Size = new System.Drawing.Size(650, 21);
            this.cmbDivision.TabIndex = 11;
            this.cmbDivision.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Подразделение";
            // 
            // labelCompiler
            // 
            this.labelCompiler.AutoSize = true;
            this.labelCompiler.Location = new System.Drawing.Point(8, 66);
            this.labelCompiler.Name = "labelCompiler";
            this.labelCompiler.Size = new System.Drawing.Size(72, 13);
            this.labelCompiler.TabIndex = 9;
            this.labelCompiler.Text = "Составитель";
            // 
            // cmbCompiler
            // 
            this.cmbCompiler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCompiler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCompiler.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompiler", true));
            this.cmbCompiler.FormattingEnabled = true;
            this.cmbCompiler.Location = new System.Drawing.Point(94, 58);
            this.cmbCompiler.Name = "cmbCompiler";
            this.cmbCompiler.ReadOnlyBackColor = System.Drawing.SystemColors.Window;
            this.cmbCompiler.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbCompiler.Size = new System.Drawing.Size(185, 21);
            this.cmbCompiler.TabIndex = 8;
            this.cmbCompiler.SelectedValueChanged += new System.EventHandler(this.cmbCompiler_SelectedValueChanged);
            // 
            // dtpDateOwner
            // 
            this.dtpDateOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateOwner.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateOwner.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Damage.DateOwner", true));
            this.dtpDateOwner.Enabled = false;
            this.dtpDateOwner.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOwner.Location = new System.Drawing.Point(355, 33);
            this.dtpDateOwner.Name = "dtpDateOwner";
            this.dtpDateOwner.Size = new System.Drawing.Size(400, 20);
            this.dtpDateOwner.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата создания";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Автор заявки";
            // 
            // txtOwner
            // 
            this.txtOwner.Location = new System.Drawing.Point(94, 32);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new System.Drawing.Size(133, 20);
            this.txtOwner.TabIndex = 4;
            // 
            // labelDateDoc
            // 
            this.labelDateDoc.AutoSize = true;
            this.labelDateDoc.Location = new System.Drawing.Point(233, 13);
            this.labelDateDoc.Name = "labelDateDoc";
            this.labelDateDoc.Size = new System.Drawing.Size(116, 13);
            this.labelDateDoc.TabIndex = 3;
            this.labelDateDoc.Text = "Дата и время заявки";
            // 
            // dtpDateDoc
            // 
            this.dtpDateDoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateDoc.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateDoc.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_Damage.DateDoc", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dtpDateDoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateDoc.Location = new System.Drawing.Point(355, 7);
            this.dtpDateDoc.Name = "dtpDateDoc";
            this.dtpDateDoc.Size = new System.Drawing.Size(400, 20);
            this.dtpDateDoc.TabIndex = 2;
            this.dtpDateDoc.Value = new System.DateTime(2015, 10, 14, 9, 53, 30, 497);
            this.dtpDateDoc.ValueChanged += new System.EventHandler(this.dtpDateDoc_ValueChanged);
            // 
            // labelNumRequest
            // 
            this.labelNumRequest.AutoSize = true;
            this.labelNumRequest.Location = new System.Drawing.Point(8, 13);
            this.labelNumRequest.Name = "labelNumRequest";
            this.labelNumRequest.Size = new System.Drawing.Size(80, 13);
            this.labelNumRequest.TabIndex = 1;
            this.labelNumRequest.Text = "Номер заявки";
            // 
            // txtNumRequest
            // 
            this.txtNumRequest.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_Damage.NumRequest", true));
            this.txtNumRequest.Location = new System.Drawing.Point(94, 6);
            this.txtNumRequest.Name = "txtNumRequest";
            this.txtNumRequest.Size = new System.Drawing.Size(133, 20);
            this.txtNumRequest.TabIndex = 0;
            this.txtNumRequest.TextChanged += new System.EventHandler(this.txtNumRequest_TextChanged);
            // 
            // tabPageWeather
            // 
            this.tabPageWeather.Controls.Add(this.label10);
            this.tabPageWeather.Controls.Add(this.txtTempComment);
            this.tabPageWeather.Controls.Add(this.groupBox3);
            this.tabPageWeather.Controls.Add(this.label12);
            this.tabPageWeather.Controls.Add(this.txtTempAverage);
            this.tabPageWeather.Controls.Add(this.groupBox1);
            this.tabPageWeather.Controls.Add(this.groupBox2);
            this.tabPageWeather.Location = new System.Drawing.Point(4, 22);
            this.tabPageWeather.Name = "tabPageWeather";
            this.tabPageWeather.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWeather.Size = new System.Drawing.Size(1048, 595);
            this.tabPageWeather.TabIndex = 1;
            this.tabPageWeather.Text = "Погода";
            this.tabPageWeather.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Примечание";
            // 
            // txtTempComment
            // 
            this.txtTempComment.AcceptsTab = true;
            this.txtTempComment.BackColor = System.Drawing.SystemColors.Window;
            this.txtTempComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDamageN, "tJ_Temperature.Comment", true));
            this.txtTempComment.Location = new System.Drawing.Point(8, 260);
            this.txtTempComment.Name = "txtTempComment";
            this.txtTempComment.ReadOnly = true;
            this.txtTempComment.Size = new System.Drawing.Size(271, 82);
            this.txtTempComment.TabIndex = 20;
            this.txtTempComment.Text = "";
            // 
            // dsDamageN
            // 
            this.dsDamageN.DataSetName = "DataSetDamage";
            this.dsDamageN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSpeedUp);
            this.groupBox3.Controls.Add(this.txtSpeedDown);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbWindDirect);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(8, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 97);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ветер";
            // 
            // txtSpeedUp
            // 
            this.txtSpeedUp.BackColor = System.Drawing.SystemColors.Window;
            this.txtSpeedUp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDamageN, "tJ_Temperature.SpeedUp", true));
            this.txtSpeedUp.Location = new System.Drawing.Point(145, 65);
            this.txtSpeedUp.Name = "txtSpeedUp";
            this.txtSpeedUp.ReadOnly = true;
            this.txtSpeedUp.Size = new System.Drawing.Size(120, 20);
            this.txtSpeedUp.TabIndex = 5;
            // 
            // txtSpeedDown
            // 
            this.txtSpeedDown.BackColor = System.Drawing.SystemColors.Window;
            this.txtSpeedDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDamageN, "tJ_Temperature.SpeedDown", true));
            this.txtSpeedDown.Location = new System.Drawing.Point(9, 65);
            this.txtSpeedDown.Name = "txtSpeedDown";
            this.txtSpeedDown.ReadOnly = true;
            this.txtSpeedDown.Size = new System.Drawing.Size(120, 20);
            this.txtSpeedDown.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Скорость до (м/с)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Скорость от (м/с)";
            // 
            // cmbWindDirect
            // 
            this.cmbWindDirect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWindDirect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWindDirect.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsDamageN, "tJ_Temperature.Wind", true));
            this.cmbWindDirect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cmbWindDirect.Enabled = false;
            this.cmbWindDirect.FormattingEnabled = true;
            this.cmbWindDirect.Location = new System.Drawing.Point(87, 19);
            this.cmbWindDirect.Name = "cmbWindDirect";
            this.cmbWindDirect.Size = new System.Drawing.Size(178, 21);
            this.cmbWindDirect.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Направление";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Среднесуточная температура";
            // 
            // txtTempAverage
            // 
            this.txtTempAverage.BackColor = System.Drawing.SystemColors.Window;
            this.txtTempAverage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDamageN, "tJ_Temperature.TempAverage", true));
            this.txtTempAverage.Location = new System.Drawing.Point(171, 118);
            this.txtTempAverage.Name = "txtTempAverage";
            this.txtTempAverage.ReadOnly = true;
            this.txtTempAverage.Size = new System.Drawing.Size(108, 20);
            this.txtTempAverage.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNightUp);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtNightDown);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 50);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Температура ночью";
            // 
            // txtNightUp
            // 
            this.txtNightUp.BackColor = System.Drawing.SystemColors.Window;
            this.txtNightUp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDamageN, "tJ_Temperature.NightUp", true));
            this.txtNightUp.Location = new System.Drawing.Point(163, 19);
            this.txtNightUp.Name = "txtNightUp";
            this.txtNightUp.ReadOnly = true;
            this.txtNightUp.Size = new System.Drawing.Size(102, 20);
            this.txtNightUp.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(137, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "До";
            // 
            // txtNightDown
            // 
            this.txtNightDown.BackColor = System.Drawing.SystemColors.Window;
            this.txtNightDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDamageN, "tJ_Temperature.NightDown", true));
            this.txtNightDown.Location = new System.Drawing.Point(32, 19);
            this.txtNightDown.Name = "txtNightDown";
            this.txtNightDown.ReadOnly = true;
            this.txtNightDown.Size = new System.Drawing.Size(99, 20);
            this.txtNightDown.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "От";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDayUp);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDayDown);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(8, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 50);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Температура днем";
            // 
            // txtDayUp
            // 
            this.txtDayUp.BackColor = System.Drawing.SystemColors.Window;
            this.txtDayUp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDamageN, "tJ_Temperature.DayUp", true));
            this.txtDayUp.Location = new System.Drawing.Point(163, 19);
            this.txtDayUp.Name = "txtDayUp";
            this.txtDayUp.ReadOnly = true;
            this.txtDayUp.Size = new System.Drawing.Size(102, 20);
            this.txtDayUp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "До";
            // 
            // txtDayDown
            // 
            this.txtDayDown.BackColor = System.Drawing.SystemColors.Window;
            this.txtDayDown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDamageN, "tJ_Temperature.DayDown", true));
            this.txtDayDown.Location = new System.Drawing.Point(32, 19);
            this.txtDayDown.Name = "txtDayDown";
            this.txtDayDown.ReadOnly = true;
            this.txtDayDown.Size = new System.Drawing.Size(99, 20);
            this.txtDayDown.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "От";
            // 
            // tabPagePTS
            // 
            this.tabPagePTS.Controls.Add(this.txtReasonPTS);
            this.tabPagePTS.Controls.Add(this.label16);
            this.tabPagePTS.Controls.Add(this.cmbReasonPTS);
            this.tabPagePTS.Location = new System.Drawing.Point(4, 22);
            this.tabPagePTS.Name = "tabPagePTS";
            this.tabPagePTS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePTS.Size = new System.Drawing.Size(1048, 595);
            this.tabPagePTS.TabIndex = 2;
            this.tabPagePTS.Text = "ПТС";
            this.tabPagePTS.UseVisualStyleBackColor = true;
            // 
            // txtReasonPTS
            // 
            this.txtReasonPTS.Location = new System.Drawing.Point(398, 28);
            this.txtReasonPTS.Name = "txtReasonPTS";
            this.txtReasonPTS.ReadOnly = true;
            this.txtReasonPTS.Size = new System.Drawing.Size(100, 20);
            this.txtReasonPTS.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Код повреждения";
            // 
            // cmbReasonPTS
            // 
            this.cmbReasonPTS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbReasonPTS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReasonPTS.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idReasonPTS", true));
            this.cmbReasonPTS.FormattingEnabled = true;
            this.cmbReasonPTS.Location = new System.Drawing.Point(11, 28);
            this.cmbReasonPTS.Name = "cmbReasonPTS";
            this.cmbReasonPTS.ReadOnlyBackColor = System.Drawing.SystemColors.Window;
            this.cmbReasonPTS.ReadOnlyForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbReasonPTS.Size = new System.Drawing.Size(381, 21);
            this.cmbReasonPTS.TabIndex = 0;
            this.cmbReasonPTS.SelectedIndexChanged += new System.EventHandler(this.cmbReasonPTS_SelectedIndexChanged);
            // 
            // tabPageAbn
            // 
            this.tabPageAbn.Controls.Add(this.splitContainerAbn);
            this.tabPageAbn.Controls.Add(this.statusStripAbnObj);
            this.tabPageAbn.Controls.Add(this.toolStripAbn);
            this.tabPageAbn.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbn.Name = "tabPageAbn";
            this.tabPageAbn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbn.Size = new System.Drawing.Size(1048, 595);
            this.tabPageAbn.TabIndex = 3;
            this.tabPageAbn.Text = "Отключенные абоненты";
            this.tabPageAbn.UseVisualStyleBackColor = true;
            // 
            // splitContainerAbn
            // 
            this.splitContainerAbn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAbn.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerAbn.IsSplitterFixed = true;
            this.splitContainerAbn.Location = new System.Drawing.Point(3, 28);
            this.splitContainerAbn.Name = "splitContainerAbn";
            this.splitContainerAbn.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerAbn.Panel1
            // 
            this.splitContainerAbn.Panel1.Controls.Add(this.dgvAbn);
            // 
            // splitContainerAbn.Panel2
            // 
            this.splitContainerAbn.Panel2.Controls.Add(this.splitContainerAbnCount);
            this.splitContainerAbn.Size = new System.Drawing.Size(1042, 542);
            this.splitContainerAbn.SplitterDistance = 330;
            this.splitContainerAbn.TabIndex = 9;
            // 
            // dgvAbn
            // 
            this.dgvAbn.AllowUserToAddRows = false;
            this.dgvAbn.AllowUserToDeleteRows = false;
            this.dgvAbn.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAbn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAbn.AutoGenerateColumns = false;
            this.dgvAbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.countPointDgvColumn,
            this.commentODSDgvColumn
            ,this.idAbnNetDataGridViewTextBoxColumn
            ,this.nameAbnNetDataGridViewTextBoxColumn
            ,this.idSchmObjDataGridViewTextBoxColumn
            });
            this.dgvAbn.DataSource = this.bsSchmAbnFull;
            this.dgvAbn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbn.Location = new System.Drawing.Point(0, 0);
            this.dgvAbn.Name = "dgvAbn";
            //this.dgvAbn.ReadOnly = true;
            this.dgvAbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbn.Size = new System.Drawing.Size(1042, 330);
            this.dgvAbn.TabIndex = 7;
            this.dgvAbn.CellEndEdit += new DataGridViewCellEventHandler(dgvAbn_CellEndEdit);
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "codeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeAbonentDataGridViewTextBoxColumn.Visible = false;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 5;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameAbnDataGridViewTextBoxColumn
            // 
            this.nameAbnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameAbnDataGridViewTextBoxColumn.DataPropertyName = "nameAbn";
            this.nameAbnDataGridViewTextBoxColumn.FillWeight = 85.95069F;
            this.nameAbnDataGridViewTextBoxColumn.HeaderText = "Абонент";
            this.nameAbnDataGridViewTextBoxColumn.Name = "nameAbnDataGridViewTextBoxColumn";
            this.nameAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAbnDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeAbnDgvColumn
            // 
            this.typeAbnDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeAbnDgvColumn.DataPropertyName = "typeAbn";
            this.typeAbnDgvColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeAbnDgvColumn.FillWeight = 70.12179F;
            this.typeAbnDgvColumn.HeaderText = "Тип абонента";
            this.typeAbnDgvColumn.Name = "typeAbnDgvColumn";
            this.typeAbnDgvColumn.ReadOnly = true;
            this.typeAbnDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idAbnObjDataGridViewTextBoxColumn
            // 
            this.idAbnObjDataGridViewTextBoxColumn.DataPropertyName = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.HeaderText = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.idAbnObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameObjDataGridViewTextBoxColumn
            // 
            this.nameObjDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameObjDataGridViewTextBoxColumn.DataPropertyName = "nameObj";
            this.nameObjDataGridViewTextBoxColumn.FillWeight = 90.81149F;
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            this.nameObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameObjDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // categoryNameDgvColumn
            // 
            this.categoryNameDgvColumn.DataPropertyName = "CategoryName";
            this.categoryNameDgvColumn.HeaderText = "Кат";
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
            // 
            // voltageDgvColumn
            // 
            this.voltageDgvColumn.DataPropertyName = "Voltage";
            this.voltageDgvColumn.HeaderText = "Напряж.";
            this.voltageDgvColumn.Name = "voltageDgvColumn";
            this.voltageDgvColumn.ReadOnly = true;
            this.voltageDgvColumn.Width = 25;

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
            this.nameAbnNetDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSchmObjDataGridViewTextBoxColumn
            // 
            this.idSchmObjDataGridViewTextBoxColumn.DataPropertyName = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.HeaderText = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.Name = "idSchmObjDataGridViewTextBoxColumn";
            this.idSchmObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSchmObjDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idSchmObjDataGridViewTextBoxColumn.Visible = false;
            //
            // powerSetDgvColumn
            // 
            this.powerSetDgvColumn.DataPropertyName = "PowerSet";
            this.powerSetDgvColumn.HeaderText = "Мощность";
            this.powerSetDgvColumn.Name = "powerSetDgvColumn";
            this.powerSetDgvColumn.ReadOnly = true;
            this.powerSetDgvColumn.Width = 60;
            // 
            // countPointDgvColumn
            // 
            this.countPointDgvColumn.DataPropertyName = "countPoint";
            this.countPointDgvColumn.HeaderText = "Кол-во т.у.";
            this.countPointDgvColumn.Name = "countPointDgvColumn";
            //this.countPointDgvColumn.ReadOnly = true;
            this.countPointDgvColumn.Width = 40;
            // 
            // commentODSDgvColumn
            // 
            this.commentODSDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentODSDgvColumn.DataPropertyName = "CommentODS";
            this.commentODSDgvColumn.FillWeight = 101.3481F;
            this.commentODSDgvColumn.HeaderText = "Примечание";
            this.commentODSDgvColumn.Name = "commentODSDgvColumn";
            this.commentODSDgvColumn.ReadOnly = true;
            // 
            // bsSchmAbnFull
            // 
            this.bsSchmAbnFull.DataMember = "vl_SchmAbnFull2";
            this.bsSchmAbnFull.DataSource = this.dataSetAdd;
            // 
            // dataSetAdd
            // 
            this.dataSetAdd.DataSetName = "dataSetAdd";
            this.dataSetAdd.Tables.AddRange(new System.Data.DataTable[] {
            this.tableTransOff,
            this.tableSchmAbnFull});
            // 
            // tableTransOff
            // 
            this.tableTransOff.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumnidSub,
            this.dataColumnSub,
            this.dataColumnidTr,
            this.dataColumnTrName,
            this.dataColumnPower,
            this.dataColumnLoad});
            this.tableTransOff.TableName = "tableTrans";
            // 
            // dataColumnidSub
            // 
            this.dataColumnidSub.ColumnName = "idSub";
            this.dataColumnidSub.DataType = typeof(int);
            // 
            // dataColumnSub
            // 
            this.dataColumnSub.ColumnName = "Sub";
            // 
            // dataColumnidTr
            // 
            this.dataColumnidTr.ColumnName = "idTr";
            this.dataColumnidTr.DataType = typeof(int);
            // 
            // dataColumnTrName
            // 
            this.dataColumnTrName.ColumnName = "TrName";
            // 
            // dataColumnPower
            // 
            this.dataColumnPower.ColumnName = "Power";
            this.dataColumnPower.DataType = typeof(int);
            // 
            // dataColumnLoad
            // 
            this.dataColumnLoad.ColumnName = "Load";
            this.dataColumnLoad.DataType = typeof(int);
            // 
            // tableSchmAbnFull
            // 
            this.tableSchmAbnFull.Columns.AddRange(new System.Data.DataColumn[] {
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
            this.dataColumncountPoint
            ,this.dataColumnidAbnNet
            ,this.dataColumnnameAbnNet
            ,this.dataColumnidSchmObj
            });
            this.tableSchmAbnFull.TableName = "vl_SchmAbnFull2";
            // 
            // dataColumnidAbn
            // 
            this.dataColumnidAbn.ColumnName = "idAbn";
            this.dataColumnidAbn.DataType = typeof(int);
            // 
            // dataColumncodeAbonent
            // 
            this.dataColumncodeAbonent.ColumnName = "codeAbonent";
            this.dataColumncodeAbonent.DataType = typeof(int);
            // 
            // dataColumnnameAbn
            // 
            this.dataColumnnameAbn.ColumnName = "nameAbn";
            // 
            // dataColumntypeAbn
            // 
            this.dataColumntypeAbn.ColumnName = "typeAbn";
            this.dataColumntypeAbn.DataType = typeof(int);
            // 
            // dataColumnidAbnObj
            // 
            this.dataColumnidAbnObj.ColumnName = "idAbnObj";
            this.dataColumnidAbnObj.DataType = typeof(int);
            // 
            // dataColumnnameObj
            // 
            this.dataColumnnameObj.ColumnName = "nameObj";
            // 
            // dataColumnCommentODS
            // 
            this.dataColumnCommentODS.ColumnName = "CommentODS";
            // 
            // dataColumnCategoryName
            // 
            this.dataColumnCategoryName.ColumnName = "CategoryName";
            // 
            // dataColumnTarifName
            // 
            this.dataColumnTarifName.ColumnName = "TarifName";
            //
            // dataColumnVoltage
            //
            this.dataColumnVoltage.ColumnName = "Voltage";
            // 
            // dataColumnPowerSet
            // 
            this.dataColumnPowerSet.ColumnName = "PowerSet";
            this.dataColumnPowerSet.DataType = typeof(decimal);
            // 
            // dataColumncountPoint
            // 
            this.dataColumncountPoint.ColumnName = "countPoint";
            this.dataColumncountPoint.DataType = typeof(int);

            this.dataColumnidAbnNet.ColumnName = "idAbnNet";

            this.dataColumnidAbnNet.DataType = typeof(int);
            this.dataColumnnameAbnNet.ColumnName = "nameAbnNet";
            // 
            // dataColumnidSchmObj
            // 
            this.dataColumnidSchmObj.ColumnName = "idSchmObj";
            this.dataColumnidSchmObj.DataType = typeof(int);
            // 
            // splitContainerAbnCount
            // 
            this.splitContainerAbnCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAbnCount.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerAbnCount.IsSplitterFixed = true;
            this.splitContainerAbnCount.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAbnCount.Name = "splitContainerAbnCount";
            // 
            // splitContainerAbnCount.Panel1
            // 
            this.splitContainerAbnCount.Panel1.Controls.Add(this.numCountPointSource);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.numCountPointEE);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.numCountPointCat3);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.groupBoxAbnObj1Catergory);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.label23);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.label22);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.label21);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.groupBox6);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.label25);
            // 
            // splitContainerAbnCount.Panel2
            // 
            this.splitContainerAbnCount.Panel2.Controls.Add(this.numCountAbnObjSource);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.numCountAbnObjEE);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.numCountAbnObjCat3);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.label31);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.groupBox7);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.groupBox8);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.label28);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.label29);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.label30);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.groupBox9);
            this.splitContainerAbnCount.Size = new System.Drawing.Size(1042, 208);
            this.splitContainerAbnCount.SplitterDistance = 377;
            this.splitContainerAbnCount.TabIndex = 1;
            // 
            // numCountPointSource
            // 
            this.numCountPointSource.Location = new System.Drawing.Point(17, 179);
            this.numCountPointSource.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountPointSource.Name = "numCountPointSource";
            this.numCountPointSource.Size = new System.Drawing.Size(144, 20);
            this.numCountPointSource.TabIndex = 11;
            this.numCountPointSource.ValueChanged += new System.EventHandler(this.numCountPointCat2_ValueChanged);
            // 
            // numCountPointEE
            // 
            this.numCountPointEE.Location = new System.Drawing.Point(169, 141);
            this.numCountPointEE.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountPointEE.Name = "numCountPointEE";
            this.numCountPointEE.Size = new System.Drawing.Size(160, 20);
            this.numCountPointEE.TabIndex = 10;
            this.numCountPointEE.ValueChanged += new System.EventHandler(this.numCountPointCat2_ValueChanged);
            // 
            // numCountPointCat3
            // 
            this.numCountPointCat3.Location = new System.Drawing.Point(17, 141);
            this.numCountPointCat3.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountPointCat3.Name = "numCountPointCat3";
            this.numCountPointCat3.Size = new System.Drawing.Size(144, 20);
            this.numCountPointCat3.TabIndex = 9;
            this.numCountPointCat3.ValueChanged += new System.EventHandler(this.numCountPointCat2_ValueChanged);
            // 
            // groupBoxAbnObj1Catergory
            // 
            this.groupBoxAbnObj1Catergory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAbnObj1Catergory.Controls.Add(this.numCountPointCat1);
            this.groupBoxAbnObj1Catergory.Controls.Add(this.numCountPointCat1Full);
            this.groupBoxAbnObj1Catergory.Controls.Add(this.label14);
            this.groupBoxAbnObj1Catergory.Controls.Add(this.label19);
            this.groupBoxAbnObj1Catergory.Location = new System.Drawing.Point(8, 16);
            this.groupBoxAbnObj1Catergory.Name = "groupBoxAbnObj1Catergory";
            this.groupBoxAbnObj1Catergory.Size = new System.Drawing.Size(358, 51);
            this.groupBoxAbnObj1Catergory.TabIndex = 1;
            this.groupBoxAbnObj1Catergory.TabStop = false;
            this.groupBoxAbnObj1Catergory.Text = "1 категория надежности";
            // 
            // numCountPointCat1
            // 
            this.numCountPointCat1.Location = new System.Drawing.Point(225, 19);
            this.numCountPointCat1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountPointCat1.Name = "numCountPointCat1";
            this.numCountPointCat1.Size = new System.Drawing.Size(96, 20);
            this.numCountPointCat1.TabIndex = 5;
            this.numCountPointCat1.ValueChanged += new System.EventHandler(this.numCountPointCat2_ValueChanged);
            // 
            // numCountPointCat1Full
            // 
            this.numCountPointCat1Full.Location = new System.Drawing.Point(57, 18);
            this.numCountPointCat1Full.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountPointCat1Full.Name = "numCountPointCat1Full";
            this.numCountPointCat1Full.Size = new System.Drawing.Size(96, 20);
            this.numCountPointCat1Full.TabIndex = 4;
            this.numCountPointCat1Full.ValueChanged += new System.EventHandler(this.numCountPointCat2_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(158, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Частичное";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Полное";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(14, 163);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(209, 13);
            this.label23.TabIndex = 7;
            this.label23.Text = "Производители электрической энергии";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(166, 124);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(158, 13);
            this.label22.TabIndex = 5;
            this.label22.Text = "Электросетевая организация";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 124);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "3 категория надежности";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.numCountPointCat2Full);
            this.groupBox6.Controls.Add(this.numCountPointCat2);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Location = new System.Drawing.Point(8, 70);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(358, 51);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "2 категория надежности";
            // 
            // numCountPointCat2Full
            // 
            this.numCountPointCat2Full.Location = new System.Drawing.Point(57, 18);
            this.numCountPointCat2Full.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountPointCat2Full.Name = "numCountPointCat2Full";
            this.numCountPointCat2Full.Size = new System.Drawing.Size(96, 20);
            this.numCountPointCat2Full.TabIndex = 7;
            this.numCountPointCat2Full.ValueChanged += new System.EventHandler(this.numCountPointCat2_ValueChanged);
            // 
            // numCountPointCat2
            // 
            this.numCountPointCat2.Location = new System.Drawing.Point(225, 18);
            this.numCountPointCat2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountPointCat2.Name = "numCountPointCat2";
            this.numCountPointCat2.Size = new System.Drawing.Size(96, 20);
            this.numCountPointCat2.TabIndex = 6;
            this.numCountPointCat2.ValueChanged += new System.EventHandler(this.numCountPointCat2_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(158, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(61, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Частичное";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(45, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Полное";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(147, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Количество точек поставки";
            // 
            // numCountAbnObjSource
            // 
            this.numCountAbnObjSource.Location = new System.Drawing.Point(12, 179);
            this.numCountAbnObjSource.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountAbnObjSource.Name = "numCountAbnObjSource";
            this.numCountAbnObjSource.Size = new System.Drawing.Size(144, 20);
            this.numCountAbnObjSource.TabIndex = 21;
            this.numCountAbnObjSource.ValueChanged += new System.EventHandler(this.numCountAbnObjCat2Full_ValueChanged);
            // 
            // numCountAbnObjEE
            // 
            this.numCountAbnObjEE.Location = new System.Drawing.Point(164, 140);
            this.numCountAbnObjEE.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountAbnObjEE.Name = "numCountAbnObjEE";
            this.numCountAbnObjEE.Size = new System.Drawing.Size(160, 20);
            this.numCountAbnObjEE.TabIndex = 20;
            this.numCountAbnObjEE.ValueChanged += new System.EventHandler(this.numCountAbnObjCat2Full_ValueChanged);
            // 
            // numCountAbnObjCat3
            // 
            this.numCountAbnObjCat3.Location = new System.Drawing.Point(12, 140);
            this.numCountAbnObjCat3.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountAbnObjCat3.Name = "numCountAbnObjCat3";
            this.numCountAbnObjCat3.Size = new System.Drawing.Size(144, 20);
            this.numCountAbnObjCat3.TabIndex = 19;
            this.numCountAbnObjCat3.ValueChanged += new System.EventHandler(this.numCountAbnObjCat2Full_ValueChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(169, 13);
            this.label31.TabIndex = 18;
            this.label31.Text = "Количество потребителей услуг";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.numCountAbnObj670);
            this.groupBox7.Controls.Add(this.numCountAbnObj150670);
            this.groupBox7.Controls.Add(this.numCountAbnObj150);
            this.groupBox7.Controls.Add(this.label34);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Location = new System.Drawing.Point(367, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(287, 183);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Максимальная мощность";
            // 
            // numCountAbnObj670
            // 
            this.numCountAbnObj670.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCountAbnObj670.Location = new System.Drawing.Point(9, 112);
            this.numCountAbnObj670.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountAbnObj670.Name = "numCountAbnObj670";
            this.numCountAbnObj670.Size = new System.Drawing.Size(272, 20);
            this.numCountAbnObj670.TabIndex = 11;
            this.numCountAbnObj670.ValueChanged += new System.EventHandler(this.numCountAbnObjCat2Full_ValueChanged);
            // 
            // numCountAbnObj150670
            // 
            this.numCountAbnObj150670.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCountAbnObj150670.Location = new System.Drawing.Point(9, 73);
            this.numCountAbnObj150670.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountAbnObj150670.Name = "numCountAbnObj150670";
            this.numCountAbnObj150670.Size = new System.Drawing.Size(272, 20);
            this.numCountAbnObj150670.TabIndex = 10;
            this.numCountAbnObj150670.ValueChanged += new System.EventHandler(this.numCountAbnObjCat2Full_ValueChanged);
            // 
            // numCountAbnObj150
            // 
            this.numCountAbnObj150.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCountAbnObj150.Location = new System.Drawing.Point(9, 34);
            this.numCountAbnObj150.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountAbnObj150.Name = "numCountAbnObj150";
            this.numCountAbnObj150.Size = new System.Drawing.Size(272, 20);
            this.numCountAbnObj150.TabIndex = 9;
            this.numCountAbnObj150.ValueChanged += new System.EventHandler(this.numCountAbnObjCat2Full_ValueChanged);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 96);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(62, 13);
            this.label34.TabIndex = 7;
            this.label34.Text = "От 670 кВт";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 57);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(98, 13);
            this.label33.TabIndex = 5;
            this.label33.Text = "От 150 до 670 кВт";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(6, 18);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(64, 13);
            this.label32.TabIndex = 0;
            this.label32.Text = "До 150 кВт";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.numCountAbnObjCat1);
            this.groupBox8.Controls.Add(this.numCountAbnObjCat1Full);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Location = new System.Drawing.Point(3, 16);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(358, 51);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "1 категория надежности";
            // 
            // numCountAbnObjCat1
            // 
            this.numCountAbnObjCat1.Location = new System.Drawing.Point(225, 19);
            this.numCountAbnObjCat1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountAbnObjCat1.Name = "numCountAbnObjCat1";
            this.numCountAbnObjCat1.Size = new System.Drawing.Size(96, 20);
            this.numCountAbnObjCat1.TabIndex = 6;
            this.numCountAbnObjCat1.ValueChanged += new System.EventHandler(this.numCountAbnObjCat2Full_ValueChanged);
            // 
            // numCountAbnObjCat1Full
            // 
            this.numCountAbnObjCat1Full.Location = new System.Drawing.Point(53, 18);
            this.numCountAbnObjCat1Full.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountAbnObjCat1Full.Name = "numCountAbnObjCat1Full";
            this.numCountAbnObjCat1Full.Size = new System.Drawing.Size(96, 20);
            this.numCountAbnObjCat1Full.TabIndex = 5;
            this.numCountAbnObjCat1Full.ValueChanged += new System.EventHandler(this.numCountAbnObjCat2Full_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(158, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Частичное";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 21);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(45, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Полное";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(9, 163);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(209, 13);
            this.label28.TabIndex = 15;
            this.label28.Text = "Производители электрической энергии";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(161, 124);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(158, 13);
            this.label29.TabIndex = 13;
            this.label29.Text = "Электросетевая организация";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(9, 124);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(132, 13);
            this.label30.TabIndex = 11;
            this.label30.Text = "3 категория надежности";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.numCountAbnObjCat2);
            this.groupBox9.Controls.Add(this.numCountAbnObjCat2Full);
            this.groupBox9.Controls.Add(this.label35);
            this.groupBox9.Controls.Add(this.label36);
            this.groupBox9.Location = new System.Drawing.Point(3, 70);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(358, 51);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "2 категория надежности";
            // 
            // numCountAbnObjCat2
            // 
            this.numCountAbnObjCat2.Location = new System.Drawing.Point(225, 18);
            this.numCountAbnObjCat2.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountAbnObjCat2.Name = "numCountAbnObjCat2";
            this.numCountAbnObjCat2.Size = new System.Drawing.Size(96, 20);
            this.numCountAbnObjCat2.TabIndex = 7;
            this.numCountAbnObjCat2.ValueChanged += new System.EventHandler(this.numCountAbnObjCat2Full_ValueChanged);
            // 
            // numCountAbnObjCat2Full
            // 
            this.numCountAbnObjCat2Full.Location = new System.Drawing.Point(53, 18);
            this.numCountAbnObjCat2Full.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numCountAbnObjCat2Full.Name = "numCountAbnObjCat2Full";
            this.numCountAbnObjCat2Full.Size = new System.Drawing.Size(96, 20);
            this.numCountAbnObjCat2Full.TabIndex = 6;
            this.numCountAbnObjCat2Full.ValueChanged += new System.EventHandler(this.numCountAbnObjCat2Full_ValueChanged);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(158, 21);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(61, 13);
            this.label35.TabIndex = 2;
            this.label35.Text = "Частичное";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(6, 21);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(45, 13);
            this.label36.TabIndex = 0;
            this.label36.Text = "Полное";
            // 
            // statusStripAbnObj
            // 
            this.statusStripAbnObj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnRefreshCountAbn,
            this.labelCountPoint,
            this.labelCountAbnObj,
            this.labelCountAbn});
            this.statusStripAbnObj.Location = new System.Drawing.Point(3, 570);
            this.statusStripAbnObj.Name = "statusStripAbnObj";
            this.statusStripAbnObj.Size = new System.Drawing.Size(1042, 22);
            this.statusStripAbnObj.TabIndex = 8;
            this.statusStripAbnObj.Text = "statusStrip1";
            // 
            // toolBtnRefreshCountAbn
            // 
            this.toolBtnRefreshCountAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshCountAbn.Image = global::DailyReportN.Properties.Resources.refresh_16;
            this.toolBtnRefreshCountAbn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefreshCountAbn.Name = "toolBtnRefreshCountAbn";
            this.toolBtnRefreshCountAbn.ShowDropDownArrow = false;
            this.toolBtnRefreshCountAbn.Size = new System.Drawing.Size(20, 20);
            this.toolBtnRefreshCountAbn.Text = "Обновить итоги";
            this.toolBtnRefreshCountAbn.Click += new System.EventHandler(this.toolBtnRefreshCountAbn_Click);
            // 
            // labelCountPoint
            // 
            this.labelCountPoint.Name = "labelCountPoint";
            this.labelCountPoint.Size = new System.Drawing.Size(335, 17);
            this.labelCountPoint.Spring = true;
            this.labelCountPoint.Text = "Количество точек поставки: 0";
            // 
            // labelCountAbnObj
            // 
            this.labelCountAbnObj.Name = "labelCountAbnObj";
            this.labelCountAbnObj.Size = new System.Drawing.Size(335, 17);
            this.labelCountAbnObj.Spring = true;
            this.labelCountAbnObj.Text = "Количество объектов: 0";
            // 
            // labelCountAbn
            // 
            this.labelCountAbn.Name = "labelCountAbn";
            this.labelCountAbn.Size = new System.Drawing.Size(335, 17);
            this.labelCountAbn.Spring = true;
            this.labelCountAbn.Text = "Количество абонентов: 0";
            // 
            // toolStripAbn
            // 
            this.toolStripAbn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnRefreshAbn,
            this.toolBtnDelAbn});
            this.toolStripAbn.Location = new System.Drawing.Point(3, 3);
            this.toolStripAbn.Name = "toolStripAbn";
            this.toolStripAbn.Size = new System.Drawing.Size(1042, 25);
            this.toolStripAbn.TabIndex = 6;
            this.toolStripAbn.Text = "toolStrip1";
            // 
            // toolBtnRefreshAbn
            // 
            this.toolBtnRefreshAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshAbn.Image = global::DailyReportN.Properties.Resources.refresh_16;
            this.toolBtnRefreshAbn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefreshAbn.Name = "toolBtnRefreshAbn";
            this.toolBtnRefreshAbn.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRefreshAbn.Text = "Обновить";
            this.toolBtnRefreshAbn.Click += new System.EventHandler(this.toolBtnRefreshAbn_Click);
            // 
            // toolBrnDelAbn
            // 
            this.toolBtnDelAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelAbn.Image = global::DailyReportN.Properties.Resources.ElementDel;
            this.toolBtnDelAbn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelAbn.Name = "toolBrnDelAbn";
            this.toolBtnDelAbn.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelAbn.Text = "Удалить абонентов";
            this.toolBtnDelAbn.Click += new System.EventHandler(this.toolBrnDelAbn_Click);
            // 
            // tabPageTransformer
            // 
            this.tabPageTransformer.Controls.Add(this.splitContainerTrans);
            this.tabPageTransformer.Controls.Add(this.statusStripTrans);
            this.tabPageTransformer.Controls.Add(this.toolStripTransformer);
            this.tabPageTransformer.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransformer.Name = "tabPageTransformer";
            this.tabPageTransformer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransformer.Size = new System.Drawing.Size(1048, 595);
            this.tabPageTransformer.TabIndex = 4;
            this.tabPageTransformer.Text = "Отключенные трансформаторы";
            this.tabPageTransformer.UseVisualStyleBackColor = true;
            // 
            // splitContainerTrans
            // 
            this.splitContainerTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTrans.Location = new System.Drawing.Point(3, 28);
            this.splitContainerTrans.Name = "splitContainerTrans";
            this.splitContainerTrans.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTrans.Panel1
            // 
            this.splitContainerTrans.Panel1.Controls.Add(this.dgvTrans);
            // 
            // splitContainerTrans.Panel2
            // 
            this.splitContainerTrans.Panel2.Controls.Add(this.dgvTreeSub);
            this.splitContainerTrans.Size = new System.Drawing.Size(1042, 542);
            this.splitContainerTrans.SplitterDistance = 271;
            this.splitContainerTrans.TabIndex = 4;
            // 
            // dgvTrans
            // 
            this.dgvTrans.AllowUserToAddRows = false;
            this.dgvTrans.AllowUserToDeleteRows = false;
            this.dgvTrans.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.Format = "g";
            dataGridViewCellStyle5.NullValue = null;
            this.dgvTrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTrans.AutoGenerateColumns = false;
            this.dgvTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subDataGridViewTextBoxColumn,
            this.idSubDataGridViewTextBoxColumn,
            this.idTrDataGridViewTextBoxColumn,
            this.trNameDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.loadDataGridViewTextBoxColumn});
            this.dgvTrans.DataSource = this.bsTransON;
            this.dgvTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrans.Location = new System.Drawing.Point(0, 0);
            this.dgvTrans.Name = "dgvTrans";
            this.dgvTrans.RowHeadersWidth = 21;
            this.dgvTrans.Size = new System.Drawing.Size(1042, 271);
            this.dgvTrans.TabIndex = 2;
            this.dgvTrans.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrans_CellEndEdit);
            this.dgvTrans.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvTrans_RowsAdded);
            this.dgvTrans.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvTrans_RowsRemoved);
            // 
            // bsTransON
            // 
            this.bsTransON.DataMember = "tableTrans";
            this.bsTransON.DataSource = this.dataSetAdd;
            // 
            // dgvTree
            // 
            this.dgvTreeSub.AllowUserToAddRows = false;
            this.dgvTreeSub.AllowUserToDeleteRows = false;
            this.dgvTreeSub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.noAdmissionKWTColumn});
            this.dgvTreeSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTreeSub.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTreeSub.ImageList = null;
            this.dgvTreeSub.Location = new System.Drawing.Point(0, 0);
            this.dgvTreeSub.Name = "dgvTree";
            this.dgvTreeSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreeSub.Size = new System.Drawing.Size(1042, 267);
            this.dgvTreeSub.TabIndex = 3;
            this.dgvTreeSub.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTree_CellFormatting);
            this.dgvTreeSub.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTree_CellMouseClick);
            // 
            // subNameColumn
            // 
            this.subNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.subNameColumn.DataPropertyName = "SubName";
            this.subNameColumn.DefaultNodeImage = null;
            this.subNameColumn.HeaderText = "Подстанция";
            this.subNameColumn.Name = "subNameColumn";
            this.subNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idSubColumn
            // 
            this.idSubColumn.DataPropertyName = "idSub";
            this.idSubColumn.HeaderText = "idSub";
            this.idSubColumn.Name = "idSubColumn";
            this.idSubColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idSubColumn.Visible = false;
            // 
            // busNameColumn
            // 
            this.busNameColumn.DataPropertyName = "BusName";
            this.busNameColumn.HeaderText = "Шина";
            this.busNameColumn.Name = "busNameColumn";
            this.busNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idBusColumn
            // 
            this.idBusColumn.DataPropertyName = "idBus";
            this.idBusColumn.HeaderText = "idBus";
            this.idBusColumn.Name = "idBusColumn";
            this.idBusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idBusColumn.Visible = false;
            // 
            // cellNameColumn
            // 
            this.cellNameColumn.DataPropertyName = "CellName";
            this.cellNameColumn.HeaderText = "Ячейка";
            this.cellNameColumn.Name = "cellNameColumn";
            this.cellNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idCellColumn
            // 
            this.idCellColumn.DataPropertyName = "idCell";
            this.idCellColumn.HeaderText = "idCell";
            this.idCellColumn.Name = "idCellColumn";
            this.idCellColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idCellColumn.Visible = false;
            // 
            // trNameColumn
            // 
            this.trNameColumn.DataPropertyName = "TrName";
            this.trNameColumn.HeaderText = "Трансформатор";
            this.trNameColumn.Name = "trNameColumn";
            this.trNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // idTrColumn
            // 
            this.idTrColumn.DataPropertyName = "idTr";
            this.idTrColumn.HeaderText = "idTr";
            this.idTrColumn.Name = "idTrColumn";
            this.idTrColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idTrColumn.Visible = false;
            // 
            // powerColumn
            // 
            this.powerColumn.DataPropertyName = "Power";
            this.powerColumn.HeaderText = "Мощность";
            this.powerColumn.Name = "powerColumn";
            this.powerColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // loadColumn
            // 
            this.loadColumn.DataPropertyName = "Load";
            this.loadColumn.HeaderText = "Нагрузка";
            this.loadColumn.Name = "loadColumn";
            this.loadColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateOnColumn
            // 
            this.dateOnColumn.DataPropertyName = "DateOn";
            this.dateOnColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.dateOnColumn.HeaderText = "Дата включения";
            this.dateOnColumn.Name = "dateOnColumn";
            this.dateOnColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // noAdmissionKWTColumn
            // 
            this.noAdmissionKWTColumn.DataPropertyName = "noAddmissionKWT";
            this.noAdmissionKWTColumn.HeaderText = "Недоотпуск";
            this.noAdmissionKWTColumn.Name = "noAdmissionKWTColumn";
            this.noAdmissionKWTColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // statusStripTrans
            // 
            this.statusStripTrans.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelCountTr,
            this.labelSumPower,
            this.labelSumLoad});
            this.statusStripTrans.Location = new System.Drawing.Point(3, 570);
            this.statusStripTrans.Name = "statusStripTrans";
            this.statusStripTrans.Size = new System.Drawing.Size(1042, 22);
            this.statusStripTrans.TabIndex = 5;
            this.statusStripTrans.Text = "statusStrip1";
            // 
            // labelCountTr
            // 
            this.labelCountTr.Name = "labelCountTr";
            this.labelCountTr.Size = new System.Drawing.Size(342, 17);
            this.labelCountTr.Spring = true;
            this.labelCountTr.Text = "Кол-во трансформаторов: 0";
            // 
            // labelSumPower
            // 
            this.labelSumPower.Name = "labelSumPower";
            this.labelSumPower.Size = new System.Drawing.Size(342, 17);
            this.labelSumPower.Spring = true;
            this.labelSumPower.Text = "Суммарная мощность: 0";
            // 
            // labelSumLoad
            // 
            this.labelSumLoad.Name = "labelSumLoad";
            this.labelSumLoad.Size = new System.Drawing.Size(342, 17);
            this.labelSumLoad.Spring = true;
            this.labelSumLoad.Text = "Суммарная нагрузка: 0";
            // 
            // toolStripTransformer
            // 
            this.toolStripTransformer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnRefreshTrans});
            this.toolStripTransformer.Location = new System.Drawing.Point(3, 3);
            this.toolStripTransformer.Name = "toolStripTransformer";
            this.toolStripTransformer.Size = new System.Drawing.Size(1042, 25);
            this.toolStripTransformer.TabIndex = 0;
            this.toolStripTransformer.Text = "toolStrip1";
            // 
            // toolBtnRefreshTrans
            // 
            this.toolBtnRefreshTrans.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshTrans.Image = global::DailyReportN.Properties.Resources.Refresh;
            this.toolBtnRefreshTrans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefreshTrans.Name = "toolBtnRefreshTrans";
            this.toolBtnRefreshTrans.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRefreshTrans.Text = "Обновить";
            this.toolBtnRefreshTrans.Click += new System.EventHandler(this.toolBtnRefreshTrans_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(967, 627);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(12, 627);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewComboBoxColumn1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn1.HeaderText = "Объект";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn2.HeaderText = "Повреждение";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn3.HeaderText = "Уточнение";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(321, 627);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(640, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(93, 632);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(180, 13);
            this.labelProgress.TabIndex = 5;
            this.labelProgress.Text = "Загрузка отключенных абонентов";
            this.labelProgress.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // toolTipDocParent
            // 
            this.toolTipDocParent.IsBalloon = true;
            this.toolTipDocParent.ShowAlways = true;
            // 
            // contextMenuDgvTree
            // 
            this.contextMenuDgvTree.Name = "contextMenuDgvTree";
            this.contextMenuDgvTree.Size = new System.Drawing.Size(61, 4);
            // 
            // toolMenuItemOn
            // 
            this.toolMenuItemOn.Name = "toolMenuItemOn";
            this.toolMenuItemOn.Size = new System.Drawing.Size(32, 19);
            // 
            // toolMenuItemOff
            // 
            this.toolMenuItemOff.Name = "toolMenuItemOff";
            this.toolMenuItemOff.Size = new System.Drawing.Size(32, 19);
            // 
            // subDataGridViewTextBoxColumn
            // 
            this.subDataGridViewTextBoxColumn.DataPropertyName = "Sub";
            this.subDataGridViewTextBoxColumn.HeaderText = "Подстанция";
            this.subDataGridViewTextBoxColumn.Name = "subDataGridViewTextBoxColumn";
            this.subDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSubDataGridViewTextBoxColumn
            // 
            this.idSubDataGridViewTextBoxColumn.DataPropertyName = "idSub";
            this.idSubDataGridViewTextBoxColumn.HeaderText = "idSub";
            this.idSubDataGridViewTextBoxColumn.Name = "idSubDataGridViewTextBoxColumn";
            this.idSubDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSubDataGridViewTextBoxColumn.Visible = false;
            // 
            // idTrDataGridViewTextBoxColumn
            // 
            this.idTrDataGridViewTextBoxColumn.DataPropertyName = "idTr";
            this.idTrDataGridViewTextBoxColumn.HeaderText = "idTr";
            this.idTrDataGridViewTextBoxColumn.Name = "idTrDataGridViewTextBoxColumn";
            this.idTrDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTrDataGridViewTextBoxColumn.Visible = false;
            // 
            // trNameDataGridViewTextBoxColumn
            // 
            this.trNameDataGridViewTextBoxColumn.DataPropertyName = "TrName";
            this.trNameDataGridViewTextBoxColumn.HeaderText = "Трасформатор";
            this.trNameDataGridViewTextBoxColumn.Name = "trNameDataGridViewTextBoxColumn";
            this.trNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // powerDataGridViewTextBoxColumn
            // 
            this.powerDataGridViewTextBoxColumn.DataPropertyName = "Power";
            this.powerDataGridViewTextBoxColumn.HeaderText = "Мощность";
            this.powerDataGridViewTextBoxColumn.Name = "powerDataGridViewTextBoxColumn";
            // 
            // loadDataGridViewTextBoxColumn
            // 
            this.loadDataGridViewTextBoxColumn.DataPropertyName = "Load";
            this.loadDataGridViewTextBoxColumn.HeaderText = "Нагрузка";
            this.loadDataGridViewTextBoxColumn.Name = "loadDataGridViewTextBoxColumn";
            // 
            // FormDamageLVAddEdit
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(1054, 658);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDamageLVAddEdit";
            this.Text = "FormDamageLVAddEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDamageLVAddEdit_FormClosing);
            this.Load += new System.EventHandler(this.FormDamageLVAddEdit_Load);
            this.Shown += new System.EventHandler(this.FormDamageLVAddEdit_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.toolStrip81.ResumeLayout(false);
            this.toolStrip81.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxDefectData.ResumeLayout(false);
            this.groupBoxDefectData.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCharacterDamage)).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxDeclarer.ResumeLayout(false);
            this.groupBoxDeclarer.PerformLayout();
            this.tabPageWeather.ResumeLayout(false);
            this.tabPageWeather.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsDamageN)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPagePTS.ResumeLayout(false);
            this.tabPagePTS.PerformLayout();
            this.tabPageAbn.ResumeLayout(false);
            this.tabPageAbn.PerformLayout();
            this.splitContainerAbn.Panel1.ResumeLayout(false);
            this.splitContainerAbn.Panel2.ResumeLayout(false);
            this.splitContainerAbn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSchmAbnFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTransOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSchmAbnFull)).EndInit();
            this.splitContainerAbnCount.Panel1.ResumeLayout(false);
            this.splitContainerAbnCount.Panel1.PerformLayout();
            this.splitContainerAbnCount.Panel2.ResumeLayout(false);
            this.splitContainerAbnCount.Panel2.PerformLayout();
            this.splitContainerAbnCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointEE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointCat3)).EndInit();
            this.groupBoxAbnObj1Catergory.ResumeLayout(false);
            this.groupBoxAbnObj1Catergory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointCat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointCat1Full)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointCat2Full)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountPointCat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjEE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat3)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObj670)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObj150670)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObj150)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat1Full)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat2Full)).EndInit();
            this.statusStripAbnObj.ResumeLayout(false);
            this.statusStripAbnObj.PerformLayout();
            this.toolStripAbn.ResumeLayout(false);
            this.toolStripAbn.PerformLayout();
            this.tabPageTransformer.ResumeLayout(false);
            this.tabPageTransformer.PerformLayout();
            this.splitContainerTrans.Panel1.ResumeLayout(false);
            this.splitContainerTrans.Panel2.ResumeLayout(false);
            this.splitContainerTrans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreeSub)).EndInit();
            this.statusStripTrans.ResumeLayout(false);
            this.statusStripTrans.PerformLayout();
            this.toolStripTransformer.ResumeLayout(false);
            this.toolStripTransformer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private DailyReportN.DataSet.dsDamage.tJ_DamageDataTable tableDamage;
        private DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable tableDamageCharacter;

        private TabControl tabControl1;

        private TabPage tabPageGeneral;

        private TabPage tabPageWeather;

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

        private Label labelDateDoc;

        private NullableDateTimePicker dtpDateDoc;

        private Label labelNumRequest;

        private TextBox txtNumRequest;

        private GroupBox groupBoxDeclarer;

        private Label label8;

        private TextBox txtDeclarerAddress;

        private TextBox txtDeclarerTel;

        private Label label7;

        private TextBox txtDeclarer;

        private GroupBox groupBoxDefectData;

        private Button btnChoiceSchmObj;

        private Label labelSchmObj;

        private TextBox txtSchmObj;

        private Label labelObl;

        private ComboBoxReadOnly cmbObl;

        private ComboBoxReadOnly cmbRaionObl;

        private Label labelRaionObl;

        private Label labelCity;

        private ComboBoxReadOnly cmbCity;

        private ComboBoxReadOnly cmbStreet;

        private Label labelStreet;

        private TextBox txtHousePrefix;

        private Label labelHousePrefix;

        private TextBox txtHouse;

        private Label labelHouse;

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

        private Label label1ChatacterDamage;

        private ComboBoxReadOnly cmbReason;

        private Label labelReason;

        private CheckBox checkBoxLaboratory;

        private ComboBoxReadOnly cmbDivisionApply;

        private Label labelDivisionApply;

        //private Class171 dataSetDamage;
        internal DailyReportN.DataSet.dsDamage dataSetDamage;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        private Label label10;

        private RichTextBox txtTempComment;

        private DailyReportN.DataSet.dsDamage dsDamageN;

        private GroupBox groupBox3;

        private TextBox txtSpeedUp;

        private TextBox txtSpeedDown;

        private Label label9;

        private Label label5;

        private ComboBox cmbWindDirect;

        private Label label11;

        private Label label12;

        private TextBox txtTempAverage;

        private GroupBox groupBox1;

        private TextBox txtNightUp;

        private Label label13;

        private TextBox txtNightDown;

        private Label label15;

        private GroupBox groupBox2;

        private TextBox txtDayUp;

        private Label label1;

        private TextBox txtDayDown;

        private Label label17;

        private TabPage tabPagePTS;

        private ComboBoxReadOnly cmbReasonPTS;

        private TextBox txtReasonPTS;

        private Label label16;

        private Label label18;

        private GroupBox groupBox4;

        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;

        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;

        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;

        private GroupBox groupBox5;

        private CheckBox chbDefect;

        private SplitContainer splitContainer1;

        private Label labelDivisionInstruction;

        private RichTextBox txtLaboratoryInstruction;

        private Label labelLaboratoryInstruction;

        private RichTextBox txtDivisionInstruction;

        private DataGridViewComboBoxColumn ColumnTypeObj;
        private DataGridViewTextBoxColumn ColumnSchmObj;
        private DataGridViewTextBoxColumn columnIdSchmObj;
        private DataGridViewButtonColumn ColumnBtn;
        private DataGridViewComboBoxColumn ColumnCabSection;
        private DataGridViewComboBoxColumn Column2;

        private DataGridViewComboBoxColumn Column3;

        private TabPage tabPageAbn;

        private ToolStrip toolStripAbn;

        private ToolStripButton toolBtnRefreshAbn;

        private ProgressBar progressBar;

        private Label labelProgress;

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

        private BindingSource bsSchmAbnFull;

        private DataGridViewExcelFilter dgvAbn;

        private BackgroundWorker backgroundWorker;

        private ToolStripButton toolBtnDelAbn;

        private Label label2;

        private TextBox txtDocParent;

        private Button btnRequestForRepair;

        private ToolTip toolTipDocParent;

        private DataColumn dataColumnCommentODS;

        private ToolStrip toolStrip81;

        private ToolStripButton toolBtn81;

        private SplitContainer splitContainerAbn;

        private StatusStrip statusStripAbnObj;

        private ToolStripDropDownButton toolBtnRefreshCountAbn;

        private ToolStripStatusLabel labelCountPoint;

        private ToolStripStatusLabel labelCountAbnObj;

        private ToolStripStatusLabel labelCountAbn;

        private SplitContainer splitContainerAbnCount;

        private NumericUpDown numCountPointSource;

        private NumericUpDown numCountPointEE;

        private NumericUpDown numCountPointCat3;

        private GroupBox groupBoxAbnObj1Catergory;

        private NumericUpDown numCountPointCat1;

        private NumericUpDown numCountPointCat1Full;

        private Label label14;

        private Label label19;

        private Label label23;

        private Label label22;

        private Label label21;

        private GroupBox groupBox6;

        private NumericUpDown numCountPointCat2Full;

        private NumericUpDown numCountPointCat2;

        private Label label20;

        private Label label24;

        private Label label25;

        private NumericUpDown numCountAbnObjSource;

        private NumericUpDown numCountAbnObjEE;

        private NumericUpDown numCountAbnObjCat3;

        private Label label31;

        private GroupBox groupBox7;

        private NumericUpDown numCountAbnObj670;

        private NumericUpDown numCountAbnObj150670;

        private NumericUpDown numCountAbnObj150;

        private Label label34;

        private Label label33;

        private Label label32;

        private GroupBox groupBox8;

        private NumericUpDown numCountAbnObjCat1;

        private NumericUpDown numCountAbnObjCat1Full;

        private Label label26;

        private Label label27;

        private Label label28;

        private Label label29;

        private Label label30;

        private GroupBox groupBox9;

        private NumericUpDown numCountAbnObjCat2;

        private NumericUpDown numCountAbnObjCat2Full;

        private Label label35;

        private Label label36;

        private DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nameAbnDataGridViewTextBoxColumn;

        private DataGridViewFilterComboBoxColumn typeAbnDgvColumn;

        private DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn categoryNameDgvColumn;

        private DataGridViewFilterTextBoxColumn powerSetDgvColumn;

        private DataGridViewFilterTextBoxColumn countPointDgvColumn;

        private DataGridViewFilterTextBoxColumn commentODSDgvColumn;
        private DataGridViewFilterTextBoxColumn tarifNameDgvColumn;
        private DataGridViewFilterTextBoxColumn voltageDgvColumn;
        private DataColumn dataColumnCategoryName;
        private System.Data.DataColumn dataColumnTarifName;
        private System.Data.DataColumn dataColumnVoltage;
        private DataColumn dataColumnPowerSet;

        private DataColumn dataColumncountPoint;
        private BindingSource bsTransON;
        private TabPage tabPageTransformer;
        private SplitContainer splitContainerTrans;
        private DataGridViewExcelFilter dgvTrans;
        private TreeDataGridView dgvTreeSub;
        private StatusStrip statusStripTrans;
        private ToolStripStatusLabel labelCountTr;
        private ToolStripStatusLabel labelSumPower;
        private ToolStripStatusLabel labelSumLoad;
        private ToolStrip toolStripTransformer;
        private ToolStripButton toolBtnRefreshTrans;

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
        private ContextMenuStrip contextMenuDgvTree;
        private ToolStripMenuItem toolMenuItemOn;
        private ToolStripMenuItem toolMenuItemOff;
        private DataGridViewTextBoxColumn subDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSubDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idTrDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loadDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkSendSiteME;
        private Label label37;
        private TextBox txtNumRequestME;
        private DataColumn dataColumnnameAbnNet;
        private DataColumn dataColumnidAbnNet;
        private DataGridViewTextBoxColumn idAbnNetDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn nameAbnNetDataGridViewTextBoxColumn;
        private System.Data.DataColumn dataColumnidSchmObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSchmObjDataGridViewTextBoxColumn;
    }
}