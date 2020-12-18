using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace DailyReportN.JournalDamage
{
    internal partial class FormDefectAddEdit : FormLbr.FormBase
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormDefectAddEdit));
            this.tabControl1 = new TabControl();
            this.tabPageGeneral = new TabPage();
            this.toolStrip81 = new ToolStrip();
            this.toolBtn81 = new ToolStripButton();
            this.cmbDivisionApply = new ComboBoxReadOnly();
            this.dataSetDamage = new DailyReportN.DataSet.dsDamage();
            this.splitContainer1 = new SplitContainer();
            this.groupBoxDefectData = new GroupBox();
            this.txtLocation = new RichTextBox();
            this.label7 = new Label();
            this.groupBoxAddress = new GroupBox();
            this.txtHousePrefix = new TextBox();
            this.labelObl = new Label();
            this.labelHousePrefix = new Label();
            this.cmbObl = new ComboBoxReadOnly();
            this.txtHouse = new TextBox();
            this.labelRaionObl = new Label();
            this.labelHouse = new Label();
            this.cmbRaionObl = new ComboBoxReadOnly();
            this.cmbStreet = new ComboBoxReadOnly();
            this.cmbCity = new ComboBoxReadOnly();
            this.labelStreet = new Label();
            this.labelCity = new Label();
            this.dgvCharacterDamage = new DataGridView();
            this.ColumnTypeObj = new DataGridViewComboBoxColumn();
            this.ColumnSchmObj = new DataGridViewTextBoxColumn();
            this.ColumnIdSchmObj = new DataGridViewTextBoxColumn();
            this.ColumnBtn = new DataGridViewButtonColumn();
            this.ColumnCabSection = new DataGridViewComboBoxColumn();
            this.ColumnDamage = new DataGridViewComboBoxColumn();
            this.ColumnDamageExtended = new DataGridViewComboBoxColumn();
            this.label1ChatacterDamage = new Label();
            this.cmbReason = new ComboBoxReadOnly();
            this.labelReason = new Label();
            this.btnChoiceSchmObj = new Button();
            this.labelSchmObj = new Label();
            this.txtSchmObj = new TextBox();
            this.cmbComplWorkODS = new ComboBoxReadOnly();
            this.txtComplWorkODS = new RichTextBox();
            this.label9 = new Label();
            this.txtInstruction = new RichTextBox();
            this.label8 = new Label();
            this.btnShowDocParent = new Button();
            this.checkBoxLaboratory = new CheckBox();
            this.labelDivisionApply = new Label();
            this.txtDocParent = new TextBox();
            this.label1 = new Label();
            this.groupBoxResult = new GroupBox();
            this.dtpDatePlanApply = new NullableDateTimePicker();
            this.label5 = new Label();
            this.dtpDataApply = new NullableDateTimePicker();
            this.labelDateAplly = new Label();
            this.cmbWorkerApply = new ComboBox();
            this.checkBoxApply = new CheckBox();
            this.txtCompletedWork = new RichTextBox();
            this.labelCompletedWork = new Label();
            this.cmbCompletedWork = new ComboBox();
            this.cmbDivision = new ComboBoxReadOnly();
            this.label6 = new Label();
            this.labelCompiler = new Label();
            this.cmbCompiler = new ComboBoxReadOnly();
            this.dtpDateOwner = new DateTimePicker();
            this.label4 = new Label();
            this.label3 = new Label();
            this.txtOwner = new TextBox();
            this.labelDateDoc = new Label();
            this.dtpDateDoc = new NullableDateTimePicker();
            this.labelNumRequest = new Label();
            this.txtNumRequest = new TextBox();
            this.tabPageAbn = new TabPage();
            this.splitContainerAbn = new SplitContainer();
            this.dgvAbn = new DataGridViewExcelFilter();
            this.bsSchmAbnFull = new BindingSource(this.components);
            this.dsDefect = new System.Data.DataSet();
            this.Table1 = new DataTable();
            this.dataColumn16 = new DataColumn();
            this.dataColumn1 = new DataColumn();
            this.dataColumn2 = new DataColumn();
            this.dataColumn3 = new DataColumn();
            this.dataColumn4 = new DataColumn();
            this.dataColumn5 = new DataColumn();
            this.dtSchmAbnFull = new DataTable();
            this.dataColumn6 = new DataColumn();
            this.dataColumn7 = new DataColumn();
            this.dataColumn8 = new DataColumn();
            this.dataColumn9 = new DataColumn();
            this.dataColumn10 = new DataColumn();
            this.dataColumn11 = new DataColumn();
            this.dataColumn12 = new DataColumn();
            this.splitContainerAbnCount = new SplitContainer();
            this.numCountPointSource = new NumericUpDown();
            this.numCountPointEE = new NumericUpDown();
            this.numCountPointCat3 = new NumericUpDown();
            this.groupBox_3 = new GroupBox();
            this.numCountPointCat1 = new NumericUpDown();
            this.numCountPointCat1Full = new NumericUpDown();
            this.label14 = new Label();
            this.label19 = new Label();
            this.label23 = new Label();
            this.label22 = new Label();
            this.label21 = new Label();
            this.groupBox6 = new GroupBox();
            this.numCountPointCat2Full = new NumericUpDown();
            this.numCountPointCat2 = new NumericUpDown();
            this.label20 = new Label();
            this.label24 = new Label();
            this.label25 = new Label();
            this.numCountAbnObjSource = new NumericUpDown();
            this.numCountAbnObjEE = new NumericUpDown();
            this.numCountAbnObjCat3 = new NumericUpDown();
            this.label31 = new Label();
            this.groupBox7 = new GroupBox();
            this.numCountAbnObj670 = new NumericUpDown();
            this.numCountAbnObj150670 = new NumericUpDown();
            this.numCountAbnObj150 = new NumericUpDown();
            this.label34 = new Label();
            this.label33 = new Label();
            this.label32 = new Label();
            this.groupBox8 = new GroupBox();
            this.numCountAbnObjCat1 = new NumericUpDown();
            this.numCountAbnObjCat1Full = new NumericUpDown();
            this.label26 = new Label();
            this.label27 = new Label();
            this.label28 = new Label();
            this.label29 = new Label();
            this.label30 = new Label();
            this.groupBox9 = new GroupBox();
            this.numCountAbnObjCat2 = new NumericUpDown();
            this.numCountAbnObjCat2Full = new NumericUpDown();
            this.label35 = new Label();
            this.label36 = new Label();
            this.statusStripAbnObj = new StatusStrip();
            this.toolBtnRefreshCountAbn = new ToolStripDropDownButton();
            this.labelCountPoint = new ToolStripStatusLabel();
            this.labelCountAbnObj = new ToolStripStatusLabel();
            this.labelCountAbn = new ToolStripStatusLabel();
            this.toolStripAbn = new ToolStrip();
            this.toolBtnRefreshAbn = new ToolStripButton();
            this.toolBrnDelAbn = new ToolStripButton();
            this.buttonClose = new Button();
            this.buttonSave = new Button();
            this.toolTipDocParent = new ToolTip(this.components);
            this.dataGridViewComboBoxColumn1 = new DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn2 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn4 = new DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new BackgroundWorker();
            this.progressBar = new ProgressBar();
            this.labelProgress = new Label();
            this.dataColumn13 = new DataColumn();
            this.dataColumn14 = new DataColumn();
            this.dataColumn15 = new DataColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameAbnDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.typeAbnDgvColumn = new DataGridViewFilterComboBoxColumn();
            this.idAbnObjDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new DataGridViewFilterTextBoxColumn();
            this.categoryNameDgColumn = new DataGridViewFilterTextBoxColumn();
            this.powerSetDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.countPointDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.commentODSDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.toolStrip81.SuspendLayout();
            ((ISupportInitialize)this.dataSetDamage).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxDefectData.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            ((ISupportInitialize)this.dgvCharacterDamage).BeginInit();
            this.groupBoxResult.SuspendLayout();
            this.tabPageAbn.SuspendLayout();
            this.splitContainerAbn.Panel1.SuspendLayout();
            this.splitContainerAbn.Panel2.SuspendLayout();
            this.splitContainerAbn.SuspendLayout();
            ((ISupportInitialize)this.dgvAbn).BeginInit();
            ((ISupportInitialize)this.bsSchmAbnFull).BeginInit();
            ((ISupportInitialize)this.dsDefect).BeginInit();
            ((ISupportInitialize)this.Table1).BeginInit();
            ((ISupportInitialize)this.dtSchmAbnFull).BeginInit();
            this.splitContainerAbnCount.Panel1.SuspendLayout();
            this.splitContainerAbnCount.Panel2.SuspendLayout();
            this.splitContainerAbnCount.SuspendLayout();
            ((ISupportInitialize)this.numCountPointSource).BeginInit();
            ((ISupportInitialize)this.numCountPointEE).BeginInit();
            ((ISupportInitialize)this.numCountPointCat3).BeginInit();
            this.groupBox_3.SuspendLayout();
            ((ISupportInitialize)this.numCountPointCat1).BeginInit();
            ((ISupportInitialize)this.numCountPointCat1Full).BeginInit();
            this.groupBox6.SuspendLayout();
            ((ISupportInitialize)this.numCountPointCat2Full).BeginInit();
            ((ISupportInitialize)this.numCountPointCat2).BeginInit();
            ((ISupportInitialize)this.numCountAbnObjSource).BeginInit();
            ((ISupportInitialize)this.numCountAbnObjEE).BeginInit();
            ((ISupportInitialize)this.numCountAbnObjCat3).BeginInit();
            this.groupBox7.SuspendLayout();
            ((ISupportInitialize)this.numCountAbnObj670).BeginInit();
            ((ISupportInitialize)this.numCountAbnObj150670).BeginInit();
            ((ISupportInitialize)this.numCountAbnObj150).BeginInit();
            this.groupBox8.SuspendLayout();
            ((ISupportInitialize)this.numCountAbnObjCat1).BeginInit();
            ((ISupportInitialize)this.numCountAbnObjCat1Full).BeginInit();
            this.groupBox9.SuspendLayout();
            ((ISupportInitialize)this.numCountAbnObjCat2).BeginInit();
            ((ISupportInitialize)this.numCountAbnObjCat2Full).BeginInit();
            this.statusStripAbnObj.SuspendLayout();
            this.toolStripAbn.SuspendLayout();
            base.SuspendLayout();
            this.tabControl1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageAbn);
            this.tabControl1.Location = new Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(904, 701);
            this.tabControl1.TabIndex = 0;
            this.tabPageGeneral.Controls.Add(this.toolStrip81);
            this.tabPageGeneral.Controls.Add(this.cmbDivisionApply);
            this.tabPageGeneral.Controls.Add(this.splitContainer1);
            this.tabPageGeneral.Controls.Add(this.btnShowDocParent);
            this.tabPageGeneral.Controls.Add(this.checkBoxLaboratory);
            this.tabPageGeneral.Controls.Add(this.labelDivisionApply);
            this.tabPageGeneral.Controls.Add(this.txtDocParent);
            this.tabPageGeneral.Controls.Add(this.label1);
            this.tabPageGeneral.Controls.Add(this.groupBoxResult);
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
            this.tabPageGeneral.Location = new Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new Padding(3);
            this.tabPageGeneral.Size = new Size(896, 675);
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
            this.toolStrip81.Location = new Point(859, 3);
            this.toolStrip81.Name = "toolStrip81";
            this.toolStrip81.Size = new Size(31, 31);
            this.toolStrip81.TabIndex = 25;
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

            this.cmbDivisionApply.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.cmbDivisionApply.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbDivisionApply.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbDivisionApply.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idDivisionApply", true));
            this.cmbDivisionApply.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDivisionApply.FormattingEnabled = true;
            this.cmbDivisionApply.Location = new Point(169, 486);
            this.cmbDivisionApply.Name = "cmbDivisionApply";
            this.cmbDivisionApply.ReadOnlyBackColor = SystemColors.Window;
            this.cmbDivisionApply.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbDivisionApply.Size = new Size(510, 21);
            this.cmbDivisionApply.TabIndex = 16;
            this.cmbDivisionApply.SelectedIndexChanged += new EventHandler(this.cmbDivisionApply_SelectedIndexChanged);

            this.cmbDivisionApply.KeyDown += new KeyEventHandler(this.cmbDivisionApply_KeyDown);
            this.dataSetDamage.DataSetName = "DataSetDamage";
            this.dataSetDamage.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.splitContainer1.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.splitContainer1.Location = new Point(3, 120);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDefectData);
            this.splitContainer1.Panel2.Controls.Add(this.cmbComplWorkODS);
            this.splitContainer1.Panel2.Controls.Add(this.txtComplWorkODS);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txtInstruction);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Size = new Size(887, 357);
            this.splitContainer1.SplitterDistance = 542;
            this.splitContainer1.TabIndex = 24;
            this.groupBoxDefectData.Controls.Add(this.txtLocation);
            this.groupBoxDefectData.Controls.Add(this.label7);
            this.groupBoxDefectData.Controls.Add(this.groupBoxAddress);
            this.groupBoxDefectData.Controls.Add(this.dgvCharacterDamage);
            this.groupBoxDefectData.Controls.Add(this.label1ChatacterDamage);
            this.groupBoxDefectData.Controls.Add(this.cmbReason);
            this.groupBoxDefectData.Controls.Add(this.labelReason);
            this.groupBoxDefectData.Controls.Add(this.btnChoiceSchmObj);
            this.groupBoxDefectData.Controls.Add(this.labelSchmObj);
            this.groupBoxDefectData.Controls.Add(this.txtSchmObj);
            this.groupBoxDefectData.Dock = DockStyle.Fill;
            this.groupBoxDefectData.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.groupBoxDefectData.Location = new Point(0, 0);
            this.groupBoxDefectData.Name = "groupBoxDefectData";
            this.groupBoxDefectData.Size = new Size(542, 357);
            this.groupBoxDefectData.TabIndex = 0;
            this.groupBoxDefectData.TabStop = false;
            this.groupBoxDefectData.Text = "Исходные данные";
            this.txtLocation.AcceptsTab = true;
            this.txtLocation.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtLocation.BackColor = SystemColors.Window;
            this.txtLocation.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.DefectLocation", true));
            this.txtLocation.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.txtLocation.Location = new Point(128, 178);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new Size(408, 40);
            this.txtLocation.TabIndex = 6;
            this.txtLocation.Text = "";
            this.label7.AutoSize = true;
            this.label7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.label7.Location = new Point(12, 178);
            this.label7.Name = "label7";
            this.label7.Size = new Size(110, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Место повреждения";
            this.groupBoxAddress.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBoxAddress.Controls.Add(this.txtHousePrefix);
            this.groupBoxAddress.Controls.Add(this.labelObl);
            this.groupBoxAddress.Controls.Add(this.labelHousePrefix);
            this.groupBoxAddress.Controls.Add(this.cmbObl);
            this.groupBoxAddress.Controls.Add(this.txtHouse);
            this.groupBoxAddress.Controls.Add(this.labelRaionObl);
            this.groupBoxAddress.Controls.Add(this.labelHouse);
            this.groupBoxAddress.Controls.Add(this.cmbRaionObl);
            this.groupBoxAddress.Controls.Add(this.cmbStreet);
            this.groupBoxAddress.Controls.Add(this.cmbCity);
            this.groupBoxAddress.Controls.Add(this.labelStreet);
            this.groupBoxAddress.Controls.Add(this.labelCity);
            this.groupBoxAddress.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.groupBoxAddress.Location = new Point(9, 72);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new Size(527, 100);
            this.groupBoxAddress.TabIndex = 4;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Адрес";
            this.txtHousePrefix.BackColor = SystemColors.Window;
            this.txtHousePrefix.Location = new Point(352, 72);
            this.txtHousePrefix.Name = "txtHousePrefix";
            this.txtHousePrefix.Size = new Size(64, 20);
            this.txtHousePrefix.TabIndex = 11;
            this.txtHousePrefix.TextChanged += new EventHandler(this.txtHousePrefix_TextChanged);
            this.labelObl.AutoSize = true;
            this.labelObl.Location = new Point(6, 16);
            this.labelObl.Name = "labelObl";
            this.labelObl.Size = new Size(50, 13);
            this.labelObl.TabIndex = 0;
            this.labelObl.Text = "Область";
            this.labelHousePrefix.AutoSize = true;
            this.labelHousePrefix.Location = new Point(349, 56);
            this.labelHousePrefix.Name = "labelHousePrefix";
            this.labelHousePrefix.Size = new Size(53, 13);
            this.labelHousePrefix.TabIndex = 10;
            this.labelHousePrefix.Text = "Префикс";
            this.cmbObl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbObl.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbObl.FormattingEnabled = true;
            this.cmbObl.Location = new Point(6, 32);
            this.cmbObl.Name = "cmbObl";
            this.cmbObl.ReadOnlyBackColor = SystemColors.Window;
            this.cmbObl.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbObl.Size = new Size(179, 21);
            this.cmbObl.TabIndex = 1;
            this.cmbObl.ValueMember = "tR_KladrObj.Id";
            this.cmbObl.SelectedIndexChanged += new EventHandler(this.cmbObl_SelectedIndexChanged);
            this.txtHouse.BackColor = SystemColors.Window;
            this.txtHouse.Location = new Point(273, 72);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new Size(63, 20);
            this.txtHouse.TabIndex = 9;
            this.txtHouse.TextChanged += new EventHandler(this.txtHouse_TextChanged);
            this.labelRaionObl.AutoSize = true;
            this.labelRaionObl.Location = new Point(203, 16);
            this.labelRaionObl.Name = "labelRaionObl";
            this.labelRaionObl.Size = new Size(72, 13);
            this.labelRaionObl.TabIndex = 2;
            this.labelRaionObl.Text = "Район/город";
            this.labelHouse.AutoSize = true;
            this.labelHouse.Location = new Point(270, 56);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new Size(30, 13);
            this.labelHouse.TabIndex = 8;
            this.labelHouse.Text = "Дом";
            this.cmbRaionObl.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbRaionObl.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbRaionObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbRaionObl.FormattingEnabled = true;
            this.cmbRaionObl.Location = new Point(195, 32);
            this.cmbRaionObl.Name = "cmbRaionObl";
            this.cmbRaionObl.ReadOnlyBackColor = SystemColors.Window;
            this.cmbRaionObl.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbRaionObl.Size = new Size(172, 21);
            this.cmbRaionObl.TabIndex = 3;
            this.cmbRaionObl.ValueMember = "tR_KladrObj.Id";
            this.cmbRaionObl.SelectedIndexChanged += new EventHandler(this.cmbRaionObl_SelectedIndexChanged);
            this.cmbStreet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbStreet.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbStreet.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idStreet", true));
            this.cmbStreet.DisplayMember = "tR_KladrStreet.NameSocr";
            this.cmbStreet.FormattingEnabled = true;
            this.cmbStreet.Location = new Point(6, 72);
            this.cmbStreet.Name = "cmbStreet";
            this.cmbStreet.ReadOnlyBackColor = SystemColors.Window;
            this.cmbStreet.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbStreet.Size = new Size(244, 21);
            this.cmbStreet.TabIndex = 7;
            this.cmbStreet.ValueMember = "tR_KladrStreet.Id";
            this.cmbStreet.SelectedIndexChanged += new EventHandler(this.cmbStreet_SelectedIndexChanged);
            this.cmbCity.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.cmbCity.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbCity.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new Point(373, 32);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.ReadOnlyBackColor = SystemColors.Window;
            this.cmbCity.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbCity.Size = new Size(148, 21);
            this.cmbCity.TabIndex = 5;
            this.cmbCity.ValueMember = "tR_KladrObj.Id";
            this.cmbCity.SelectedIndexChanged += new EventHandler(this.cmbCity_SelectedIndexChanged);
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new Point(6, 56);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new Size(39, 13);
            this.labelStreet.TabIndex = 6;
            this.labelStreet.Text = "Улица";
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new Point(382, 16);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new Size(102, 13);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "Населенный пункт";
            this.dgvCharacterDamage.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvCharacterDamage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCharacterDamage.Columns.AddRange(new DataGridViewColumn[]
            {
            this.ColumnTypeObj,
            this.ColumnSchmObj,
            this.ColumnIdSchmObj,
            this.ColumnBtn,
            this.ColumnCabSection,
            this.ColumnDamage,
            this.ColumnDamageExtended
            });
            this.dgvCharacterDamage.EditMode = DataGridViewEditMode.EditOnEnter;
            this.dgvCharacterDamage.Location = new Point(0, 237);
            this.dgvCharacterDamage.Name = "dgvCharacterDamage";
            this.dgvCharacterDamage.Size = new Size(542, 120);
            this.dgvCharacterDamage.TabIndex = 8;
            this.dgvCharacterDamage.CellContentClick += new DataGridViewCellEventHandler(this.dgvCharacterDamage_CellContentClick);
            this.dgvCharacterDamage.CurrentCellDirtyStateChanged += new EventHandler(this.dgvCharacterDamage_CurrentCellDirtyStateChanged);
            this.dgvCharacterDamage.DataError += new DataGridViewDataErrorEventHandler(this.dgvCharacterDamage_DataError);
            this.dgvCharacterDamage.MouseClick += new MouseEventHandler(this.dgvCharacterDamage_MouseClick);
            this.ColumnTypeObj.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.ColumnTypeObj.DefaultCellStyle = dataGridViewCellStyle;
            this.ColumnTypeObj.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnTypeObj.HeaderText = "Тип объекта";
            this.ColumnTypeObj.Name = "ColumnTypeObj";
            this.ColumnTypeObj.Resizable = DataGridViewTriState.True;
            this.ColumnTypeObj.SortMode = DataGridViewColumnSortMode.Programmatic;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.ColumnSchmObj.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnSchmObj.HeaderText = "Объект";
            this.ColumnSchmObj.Name = "ColumnSchmObj";
            this.ColumnSchmObj.ReadOnly = true;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.ColumnIdSchmObj.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnIdSchmObj.HeaderText = "IdSchmObj";
            this.ColumnIdSchmObj.Name = "ColumnIdSchmObj";
            this.ColumnIdSchmObj.ReadOnly = true;
            this.ColumnIdSchmObj.Visible = false;
            this.ColumnBtn.HeaderText = "";
            this.ColumnBtn.Name = "ColumnBtn";
            this.ColumnBtn.Text = "...";
            this.ColumnBtn.ToolTipText = "Выбрать объект";
            this.ColumnBtn.Visible = false;
            this.ColumnBtn.Width = 25;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.ColumnCabSection.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnCabSection.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnCabSection.HeaderText = "Участок";
            this.ColumnCabSection.Name = "ColumnCabSection";
            this.ColumnCabSection.ReadOnly = true;
            this.ColumnCabSection.Width = 60;
            this.ColumnDamage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.ColumnDamage.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnDamage.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnDamage.HeaderText = "Повреждение";
            this.ColumnDamage.Name = "ColumnDamage";
            this.ColumnDamageExtended.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.ColumnDamageExtended.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnDamageExtended.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnDamageExtended.HeaderText = "Уточнение";
            this.ColumnDamageExtended.Name = "ColumnDamageExtended";
            this.label1ChatacterDamage.AutoSize = true;
            this.label1ChatacterDamage.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.label1ChatacterDamage.Location = new Point(6, 221);
            this.label1ChatacterDamage.Name = "label1ChatacterDamage";
            this.label1ChatacterDamage.Size = new Size(126, 13);
            this.label1ChatacterDamage.TabIndex = 7;
            this.label1ChatacterDamage.Text = "Характер повреждения";
            this.cmbReason.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.cmbReason.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbReason.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbReason.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idReason", true));
            this.cmbReason.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new Point(153, 45);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.ReadOnlyBackColor = SystemColors.Window;
            this.cmbReason.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbReason.Size = new Size(383, 21);
            this.cmbReason.TabIndex = 3;
            this.cmbReason.SelectedIndexChanged += new EventHandler(this.cmbReason_SelectedIndexChanged);
            this.labelReason.AutoSize = true;
            this.labelReason.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.labelReason.Location = new Point(6, 48);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new Size(86, 13);
            this.labelReason.TabIndex = 2;
            this.labelReason.Text = "Неисправность";
            this.btnChoiceSchmObj.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnChoiceSchmObj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.btnChoiceSchmObj.Location = new Point(509, 19);
            this.btnChoiceSchmObj.Name = "btnChoiceSchmObj";
            this.btnChoiceSchmObj.Size = new Size(27, 20);
            this.btnChoiceSchmObj.TabIndex = 2;
            this.btnChoiceSchmObj.Text = "...";
            this.btnChoiceSchmObj.UseVisualStyleBackColor = true;
            this.btnChoiceSchmObj.Click += new EventHandler(this.btnChoiceSchmObj_Click);
            this.labelSchmObj.AutoSize = true;
            this.labelSchmObj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.labelSchmObj.Location = new Point(6, 22);
            this.labelSchmObj.Name = "labelSchmObj";
            this.labelSchmObj.Size = new Size(108, 13);
            this.labelSchmObj.TabIndex = 0;
            this.labelSchmObj.Text = "Подстанция\\ячейка";
            this.txtSchmObj.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtSchmObj.BackColor = SystemColors.Window;
            this.txtSchmObj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.txtSchmObj.Location = new Point(153, 19);
            this.txtSchmObj.Name = "txtSchmObj";
            this.txtSchmObj.ReadOnly = true;
            this.txtSchmObj.Size = new Size(357, 20);
            this.txtSchmObj.TabIndex = 1;
            this.txtSchmObj.TextChanged += new EventHandler(this.txtSchmObj_TextChanged);
            this.cmbComplWorkODS.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.cmbComplWorkODS.BackColor = SystemColors.Window;
            this.cmbComplWorkODS.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompletedWorkODS", true));
            this.cmbComplWorkODS.ForeColor = SystemColors.WindowText;
            this.cmbComplWorkODS.FormattingEnabled = true;
            this.cmbComplWorkODS.Location = new Point(192, 178);
            this.cmbComplWorkODS.Name = "cmbComplWorkODS";
            this.cmbComplWorkODS.ReadOnlyBackColor = SystemColors.Window;
            this.cmbComplWorkODS.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbComplWorkODS.Size = new Size(145, 21);
            this.cmbComplWorkODS.TabIndex = 3;
            this.txtComplWorkODS.AcceptsTab = true;
            this.txtComplWorkODS.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.txtComplWorkODS.BackColor = SystemColors.Window;
            this.txtComplWorkODS.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.CompletedWorkTextODS", true));
            this.txtComplWorkODS.Location = new Point(2, 206);
            this.txtComplWorkODS.Name = "txtComplWorkODS";
            this.txtComplWorkODS.Size = new Size(335, 151);
            this.txtComplWorkODS.TabIndex = 4;
            this.txtComplWorkODS.Text = "";
            this.label9.AutoSize = true;
            this.label9.Location = new Point(3, 181);
            this.label9.Name = "label9";
            this.label9.Size = new Size(189, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Выполненная работа составителем";
            this.txtInstruction.AcceptsTab = true;
            this.txtInstruction.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtInstruction.BackColor = SystemColors.Window;
            this.txtInstruction.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.DivisionInstruction", true));
            this.txtInstruction.Location = new Point(2, 25);
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.Size = new Size(335, 147);
            this.txtInstruction.TabIndex = 1;
            this.txtInstruction.Text = "";
            this.label8.AutoSize = true;
            this.label8.Location = new Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Указания";
            this.btnShowDocParent.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnShowDocParent.Enabled = false;
            this.btnShowDocParent.Location = new Point(853, 92);
            this.btnShowDocParent.Name = "btnShowDocParent";
            this.btnShowDocParent.Size = new Size(27, 20);
            this.btnShowDocParent.TabIndex = 23;
            this.btnShowDocParent.Text = "...";
            this.toolTipDocParent.SetToolTip(this.btnShowDocParent, "Открыть документ");
            this.btnShowDocParent.UseVisualStyleBackColor = true;
            this.btnShowDocParent.Click += new EventHandler(this.btnShowDocParent_Click);
            this.checkBoxLaboratory.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.checkBoxLaboratory.AutoSize = true;
            this.checkBoxLaboratory.DataBindings.Add(new Binding("Checked", this.dataSetDamage, "tJ_Damage.isLaboratory", true));
            this.checkBoxLaboratory.Location = new Point(689, 489);
            this.checkBoxLaboratory.Name = "checkBoxLaboratory";
            this.checkBoxLaboratory.Size = new Size(191, 17);
            this.checkBoxLaboratory.TabIndex = 17;
            this.checkBoxLaboratory.Text = "Производственная лаборатория";
            this.checkBoxLaboratory.UseVisualStyleBackColor = true;
            this.checkBoxLaboratory.CheckedChanged += new EventHandler(this.checkBoxLaboratory_CheckedChanged);
            this.labelDivisionApply.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.labelDivisionApply.AutoSize = true;
            this.labelDivisionApply.Location = new Point(8, 489);
            this.labelDivisionApply.Name = "labelDivisionApply";
            this.labelDivisionApply.Size = new Size(155, 13);
            this.labelDivisionApply.TabIndex = 15;
            this.labelDivisionApply.Text = "Подразделение исполнитель";
            this.txtDocParent.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtDocParent.BackColor = SystemColors.Window;
            this.txtDocParent.Location = new Point(129, 93);
            this.txtDocParent.Name = "txtDocParent";
            this.txtDocParent.ReadOnly = true;
            this.txtDocParent.Size = new Size(725, 20);
            this.txtDocParent.TabIndex = 13;
            this.label1.AutoSize = true;
            this.label1.Location = new Point(8, 96);
            this.label1.Name = "label1";
            this.label1.Size = new Size(115, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Документ-основание";
            this.groupBoxResult.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBoxResult.Controls.Add(this.dtpDatePlanApply);
            this.groupBoxResult.Controls.Add(this.label5);
            this.groupBoxResult.Controls.Add(this.dtpDataApply);
            this.groupBoxResult.Controls.Add(this.labelDateAplly);
            this.groupBoxResult.Controls.Add(this.cmbWorkerApply);
            this.groupBoxResult.Controls.Add(this.checkBoxApply);
            this.groupBoxResult.Controls.Add(this.txtCompletedWork);
            this.groupBoxResult.Controls.Add(this.labelCompletedWork);
            this.groupBoxResult.Controls.Add(this.cmbCompletedWork);
            this.groupBoxResult.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 204);
            this.groupBoxResult.Location = new Point(3, 513);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new Size(887, 156);
            this.groupBoxResult.TabIndex = 14;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Результат (принятые меры)";
            this.dtpDatePlanApply.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.dtpDatePlanApply.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDatePlanApply.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DatePlanApply", true, DataSourceUpdateMode.OnPropertyChanged));
            this.dtpDatePlanApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.dtpDatePlanApply.Format = DateTimePickerFormat.Custom;
            this.dtpDatePlanApply.Location = new Point(267, 103);
            this.dtpDatePlanApply.Name = "dtpDatePlanApply";
            this.dtpDatePlanApply.Size = new Size(417, 20);
            this.dtpDatePlanApply.TabIndex = 4;
            this.dtpDatePlanApply.Value = new DateTime(2015, 8, 6, 10, 0, 53, 2);
            this.dtpDatePlanApply.ValueChanged += new EventHandler(this.dtpDatePlanApply_ValueChanged);
            this.label5.AutoSize = true;
            this.label5.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.label5.Location = new Point(10, 108);
            this.label5.Name = "label5";
            this.label5.Size = new Size(251, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Планируемая дата и время выполнения работы";
            this.dtpDataApply.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.dtpDataApply.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDataApply.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateApply", true, DataSourceUpdateMode.OnPropertyChanged));
            this.dtpDataApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.dtpDataApply.Format = DateTimePickerFormat.Custom;
            this.dtpDataApply.Location = new Point(415, 129);
            this.dtpDataApply.Name = "dtpDataApply";
            this.dtpDataApply.Size = new Size(466, 20);
            this.dtpDataApply.TabIndex = 8;
            this.dtpDataApply.Value = new DateTime(2015, 8, 6, 10, 0, 53, 2);
            this.dtpDataApply.ValueChanged += new EventHandler(this.dtpDataApply_ValueChanged);
            this.labelDateAplly.AutoSize = true;
            this.labelDateAplly.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.labelDateAplly.Location = new Point(332, 132);
            this.labelDateAplly.Name = "labelDateAplly";
            this.labelDateAplly.Size = new Size(77, 13);
            this.labelDateAplly.TabIndex = 7;
            this.labelDateAplly.Text = "Дата и время";
            this.cmbWorkerApply.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbWorkerApply.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbWorkerApply.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idWorkerApply", true));
            this.cmbWorkerApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.cmbWorkerApply.FormattingEnabled = true;
            this.cmbWorkerApply.Location = new Point(130, 129);
            this.cmbWorkerApply.Name = "cmbWorkerApply";
            this.cmbWorkerApply.Size = new Size(196, 21);
            this.cmbWorkerApply.TabIndex = 6;
            this.cmbWorkerApply.SelectedIndexChanged += new EventHandler(this.cmbWorkerApply_SelectedIndexChanged);
            this.checkBoxApply.AutoSize = true;
            this.checkBoxApply.DataBindings.Add(new Binding("Checked", this.dataSetDamage, "tJ_Damage.isApply", true));
            this.checkBoxApply.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.checkBoxApply.Location = new Point(13, 132);
            this.checkBoxApply.Name = "checkBoxApply";
            this.checkBoxApply.Size = new Size(82, 17);
            this.checkBoxApply.TabIndex = 5;
            this.checkBoxApply.Text = "Исполнено";
            this.checkBoxApply.UseVisualStyleBackColor = true;
            this.txtCompletedWork.AcceptsTab = true;
            this.txtCompletedWork.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtCompletedWork.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.ComletedWorkText", true));
            this.txtCompletedWork.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.txtCompletedWork.Location = new Point(9, 47);
            this.txtCompletedWork.Name = "txtCompletedWork";
            this.txtCompletedWork.Size = new Size(874, 47);
            this.txtCompletedWork.TabIndex = 2;
            this.txtCompletedWork.Text = "";
            this.txtCompletedWork.TextChanged += new EventHandler(this.txtCompletedWork_TextChanged);
            this.labelCompletedWork.AutoSize = true;
            this.labelCompletedWork.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.labelCompletedWork.Location = new Point(10, 22);
            this.labelCompletedWork.Name = "labelCompletedWork";
            this.labelCompletedWork.Size = new Size(190, 13);
            this.labelCompletedWork.TabIndex = 0;
            this.labelCompletedWork.Text = "Выполненная работа исполнителем";
            this.cmbCompletedWork.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.cmbCompletedWork.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompletedWork", true));
            this.cmbCompletedWork.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.cmbCompletedWork.FormattingEnabled = true;
            this.cmbCompletedWork.Location = new Point(206, 19);
            this.cmbCompletedWork.Name = "cmbCompletedWork";
            this.cmbCompletedWork.Size = new Size(677, 21);
            this.cmbCompletedWork.TabIndex = 1;
            this.cmbCompletedWork.SelectedIndexChanged += new EventHandler(this.cmbCompletedWork_SelectedIndexChanged);
            this.cmbDivision.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.cmbDivision.BackColor = SystemColors.Window;
            this.cmbDivision.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idDivision", true, DataSourceUpdateMode.OnPropertyChanged));
            this.cmbDivision.ForeColor = SystemColors.WindowText;
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new Point(388, 59);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.ReadOnly = true;
            this.cmbDivision.ReadOnlyBackColor = SystemColors.Window;
            this.cmbDivision.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbDivision.Size = new Size(498, 21);
            this.cmbDivision.TabIndex = 11;
            this.cmbDivision.TabStop = false;
            this.label6.AutoSize = true;
            this.label6.Location = new Point(295, 66);
            this.label6.Name = "label6";
            this.label6.Size = new Size(87, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Подразделение";
            this.labelCompiler.AutoSize = true;
            this.labelCompiler.Location = new Point(8, 66);
            this.labelCompiler.Name = "labelCompiler";
            this.labelCompiler.Size = new Size(72, 13);
            this.labelCompiler.TabIndex = 8;
            this.labelCompiler.Text = "Составитель";
            this.cmbCompiler.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.cmbCompiler.AutoCompleteSource = AutoCompleteSource.ListItems;
            this.cmbCompiler.DataBindings.Add(new Binding("SelectedValue", this.dataSetDamage, "tJ_Damage.idCompiler", true));
            this.cmbCompiler.FormattingEnabled = true;
            this.cmbCompiler.Location = new Point(94, 59);
            this.cmbCompiler.Name = "cmbCompiler";
            this.cmbCompiler.ReadOnlyBackColor = SystemColors.Window;
            this.cmbCompiler.ReadOnlyForeColor = SystemColors.WindowText;
            this.cmbCompiler.Size = new Size(185, 21);
            this.cmbCompiler.TabIndex = 9;
            this.cmbCompiler.SelectedValueChanged += new EventHandler(this.cmbCompiler_SelectedValueChanged);
            this.dtpDateOwner.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.dtpDateOwner.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateOwner", true, DataSourceUpdateMode.OnPropertyChanged));
            this.dtpDateOwner.Enabled = false;
            this.dtpDateOwner.Location = new Point(355, 33);
            this.dtpDateOwner.Name = "dtpDateOwner";
            this.dtpDateOwner.Size = new Size(484, 20);
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
            this.label3.TabIndex = 4;
            this.label3.Text = "Автор заявки";
            this.txtOwner.Location = new Point(94, 32);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.ReadOnly = true;
            this.txtOwner.Size = new Size(133, 20);
            this.txtOwner.TabIndex = 5;
            this.labelDateDoc.AutoSize = true;
            this.labelDateDoc.Location = new Point(233, 13);
            this.labelDateDoc.Name = "labelDateDoc";
            this.labelDateDoc.Size = new Size(116, 13);
            this.labelDateDoc.TabIndex = 2;
            this.labelDateDoc.Text = "Дата и время заявки";
            this.dtpDateDoc.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.dtpDateDoc.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateDoc.DataBindings.Add(new Binding("Value", this.dataSetDamage, "tJ_Damage.DateDoc", true));
            this.dtpDateDoc.Format = DateTimePickerFormat.Custom;
            this.dtpDateDoc.Location = new Point(355, 7);
            this.dtpDateDoc.Name = "dtpDateDoc";
            this.dtpDateDoc.Size = new Size(484, 20);
            this.dtpDateDoc.TabIndex = 3;
            this.dtpDateDoc.Value = new DateTime(2015, 10, 14, 11, 28, 26, 725);
            this.dtpDateDoc.ValueChanged += new EventHandler(this.dtpDateDoc_ValueChanged);
            this.labelNumRequest.AutoSize = true;
            this.labelNumRequest.Location = new Point(8, 13);
            this.labelNumRequest.Name = "labelNumRequest";
            this.labelNumRequest.Size = new Size(80, 13);
            this.labelNumRequest.TabIndex = 0;
            this.labelNumRequest.Text = "Номер заявки";
            this.txtNumRequest.DataBindings.Add(new Binding("Text", this.dataSetDamage, "tJ_Damage.NumRequest", true, DataSourceUpdateMode.OnPropertyChanged));
            this.txtNumRequest.Location = new Point(94, 6);
            this.txtNumRequest.Name = "txtNumRequest";
            this.txtNumRequest.Size = new Size(133, 20);
            this.txtNumRequest.TabIndex = 1;
            this.txtNumRequest.TextChanged += new EventHandler(this.txtNumRequest_TextChanged);
            this.tabPageAbn.Controls.Add(this.splitContainerAbn);
            this.tabPageAbn.Controls.Add(this.statusStripAbnObj);
            this.tabPageAbn.Controls.Add(this.toolStripAbn);
            this.tabPageAbn.Location = new Point(4, 22);
            this.tabPageAbn.Name = "tabPageAbn";
            this.tabPageAbn.Padding = new Padding(3);
            this.tabPageAbn.Size = new Size(896, 675);
            this.tabPageAbn.TabIndex = 1;
            this.tabPageAbn.Text = "Отключенные абоненты";
            this.tabPageAbn.UseVisualStyleBackColor = true;
            this.splitContainerAbn.Dock = DockStyle.Fill;
            this.splitContainerAbn.FixedPanel = FixedPanel.Panel2;
            this.splitContainerAbn.IsSplitterFixed = true;
            this.splitContainerAbn.Location = new Point(3, 28);
            this.splitContainerAbn.Name = "splitContainerAbn";
            this.splitContainerAbn.Orientation = Orientation.Horizontal;
            this.splitContainerAbn.Panel1.Controls.Add(this.dgvAbn);
            this.splitContainerAbn.Panel2.Controls.Add(this.splitContainerAbnCount);
            this.splitContainerAbn.Size = new Size(890, 622);
            this.splitContainerAbn.SplitterDistance = 410;
            this.splitContainerAbn.TabIndex = 10;
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
            this.categoryNameDgColumn,
            this.powerSetDgvColumn,
            this.countPointDgvColumn,
            this.commentODSDgvColumn
            });
            this.dgvAbn.DataSource = this.bsSchmAbnFull;
            this.dgvAbn.Dock = DockStyle.Fill;
            this.dgvAbn.Location = new Point(0, 0);
            this.dgvAbn.Name = "dgvAbn";
            this.dgvAbn.ReadOnly = true;
            this.dgvAbn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbn.Size = new Size(890, 410);
            this.dgvAbn.TabIndex = 7;
            this.bsSchmAbnFull.DataMember = "vl_SchmAbnFull";
            this.bsSchmAbnFull.DataSource = this.dsDefect;
            this.dsDefect.DataSetName = "dsDefect";
            this.dsDefect.Tables.AddRange(new DataTable[]
            {
            this.Table1,
            this.dtSchmAbnFull
            });
            this.Table1.Columns.AddRange(new DataColumn[]
            {
            this.dataColumn16,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5
            });
            this.Table1.TableName = "Table1";
            this.dataColumn16.ColumnName = "idSub";
            this.dataColumn16.DataType = typeof(int);
            this.dataColumn1.ColumnName = "Sub";
            this.dataColumn2.ColumnName = "idTr";
            this.dataColumn2.DataType = typeof(int);
            this.dataColumn3.ColumnName = "TrName";
            this.dataColumn4.ColumnName = "Power";
            this.dataColumn4.DataType = typeof(int);
            this.dataColumn5.ColumnName = "Load";
            this.dataColumn5.DataType = typeof(int);
            this.dtSchmAbnFull.Columns.AddRange(new DataColumn[]
            {
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15
            });
            this.dtSchmAbnFull.TableName = "vl_SchmAbnFull";
            this.dataColumn6.ColumnName = "idAbn";
            this.dataColumn6.DataType = typeof(int);
            this.dataColumn7.ColumnName = "codeAbonent";
            this.dataColumn7.DataType = typeof(int);
            this.dataColumn8.ColumnName = "nameAbn";
            this.dataColumn9.ColumnName = "typeAbn";
            this.dataColumn9.DataType = typeof(int);
            this.dataColumn10.ColumnName = "idAbnObj";
            this.dataColumn10.DataType = typeof(int);
            this.dataColumn11.ColumnName = "nameObj";
            this.dataColumn12.ColumnName = "CommentODS";
            this.splitContainerAbnCount.Dock = DockStyle.Fill;
            this.splitContainerAbnCount.FixedPanel = FixedPanel.Panel1;
            this.splitContainerAbnCount.IsSplitterFixed = true;
            this.splitContainerAbnCount.Location = new Point(0, 0);
            this.splitContainerAbnCount.Name = "splitContainerAbnCount";
            this.splitContainerAbnCount.Panel1.Controls.Add(this.numCountPointSource);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.numCountPointEE);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.numCountPointCat3);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.groupBox_3);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.label23);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.label22);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.label21);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.groupBox6);
            this.splitContainerAbnCount.Panel1.Controls.Add(this.label25);
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
            this.splitContainerAbnCount.Size = new Size(890, 208);
            this.splitContainerAbnCount.SplitterDistance = 377;
            this.splitContainerAbnCount.TabIndex = 1;

            this.numCountPointSource.Location = new Point(17, 179);
            //NumericUpDown numericUpDown = this.numCountPointSource;
            int[] array = new int[4];
            array[0] = 999999;
            numCountPointSource.Maximum = new decimal(array);
            this.numCountPointSource.Name = "numCountPointSource";
            this.numCountPointSource.Size = new Size(144, 20);
            this.numCountPointSource.TabIndex = 11;
            this.numCountPointSource.ValueChanged += new EventHandler(this.numCountPointSource_ValueChanged);

            this.numCountPointEE.Location = new Point(169, 141);
            //NumericUpDown numericUpDown2 = this.numCountPointEE;
            int[] array2 = new int[4];
            array2[0] = 999999;
            numCountPointEE.Maximum = new decimal(array2);
            this.numCountPointEE.Name = "numCountPointEE";
            this.numCountPointEE.Size = new Size(160, 20);
            this.numCountPointEE.TabIndex = 10;
            this.numCountPointEE.ValueChanged += new EventHandler(this.numCountPointSource_ValueChanged);

            this.numCountPointCat3.Location = new Point(17, 141);
            //NumericUpDown numericUpDown3 = this.numCountPointCat3;
            int[] array3 = new int[4];
            array3[0] = 999999;
            numCountPointCat3.Maximum = new decimal(array3);
            this.numCountPointCat3.Name = "numCountPointCat3";
            this.numCountPointCat3.Size = new Size(144, 20);
            this.numCountPointCat3.TabIndex = 9;
            this.numCountPointCat3.ValueChanged += new EventHandler(this.numCountPointSource_ValueChanged);

            this.groupBox_3.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBox_3.Controls.Add(this.numCountPointCat1);
            this.groupBox_3.Controls.Add(this.numCountPointCat1Full);
            this.groupBox_3.Controls.Add(this.label14);
            this.groupBox_3.Controls.Add(this.label19);
            this.groupBox_3.Location = new Point(8, 16);
            this.groupBox_3.Name = "groupBoxAbnObj1Catergory";
            this.groupBox_3.Size = new Size(358, 51);
            this.groupBox_3.TabIndex = 1;
            this.groupBox_3.TabStop = false;
            this.groupBox_3.Text = "1 категория надежности";

            this.numCountPointCat1.Location = new Point(225, 19);
            //NumericUpDown numCountPointCat1 = this.numCountPointCat1;
            int[] array4 = new int[4];
            array4[0] = 999999;
            numCountPointCat1.Maximum = new decimal(array4);
            this.numCountPointCat1.Name = "numCountPointCat1";
            this.numCountPointCat1.Size = new Size(96, 20);
            this.numCountPointCat1.TabIndex = 5;
            this.numCountPointCat1.ValueChanged += new EventHandler(this.numCountPointSource_ValueChanged);

            this.numCountPointCat1Full.Location = new Point(57, 18);
            //NumericUpDown numCountPointCat1Full = this.numCountPointCat1Full;
            int[] array5 = new int[4];
            array5[0] = 999999;
            numCountPointCat1Full.Maximum = new decimal(array5);
            this.numCountPointCat1Full.Name = "numCountPointCat1Full";
            this.numCountPointCat1Full.Size = new Size(96, 20);
            this.numCountPointCat1Full.TabIndex = 4;
            this.numCountPointCat1Full.ValueChanged += new EventHandler(this.numCountPointSource_ValueChanged);

            this.label14.AutoSize = true;
            this.label14.Location = new Point(158, 21);
            this.label14.Name = "label14";
            this.label14.Size = new Size(61, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Частичное";
            this.label19.AutoSize = true;
            this.label19.Location = new Point(6, 21);
            this.label19.Name = "label19";
            this.label19.Size = new Size(45, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Полное";
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
            this.groupBox6.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBox6.Controls.Add(this.numCountPointCat2Full);
            this.groupBox6.Controls.Add(this.numCountPointCat2);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label24);
            this.groupBox6.Location = new Point(8, 70);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new Size(358, 51);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "2 категория надежности";

            this.numCountPointCat2Full.Location = new Point(57, 18);
            //NumericUpDown numCountPointCat2Full = this.numCountPointCat2Full;
            int[] array6 = new int[4];
            array6[0] = 999999;
            numCountPointCat2Full.Maximum = new decimal(array6);
            this.numCountPointCat2Full.Name = "numCountPointCat2Full";
            this.numCountPointCat2Full.Size = new Size(96, 20);
            this.numCountPointCat2Full.TabIndex = 7;
            this.numCountPointCat2Full.ValueChanged += new EventHandler(this.numCountPointSource_ValueChanged);

            this.numCountPointCat2.Location = new Point(225, 18);
            //NumericUpDown numCountPointCat2 = this.numCountPointCat2;
            int[] array7 = new int[4];
            array7[0] = 999999;
            numCountPointCat2.Maximum = new decimal(array7);
            this.numCountPointCat2.Name = "numCountPointCat2";
            this.numCountPointCat2.Size = new Size(96, 20);
            this.numCountPointCat2.TabIndex = 6;
            this.numCountPointCat2.ValueChanged += new EventHandler(this.numCountPointSource_ValueChanged);

            this.label20.AutoSize = true;
            this.label20.Location = new Point(158, 21);
            this.label20.Name = "label20";
            this.label20.Size = new Size(61, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Частичное";
            this.label24.AutoSize = true;
            this.label24.Location = new Point(6, 21);
            this.label24.Name = "label24";
            this.label24.Size = new Size(45, 13);
            this.label24.TabIndex = 0;
            this.label24.Text = "Полное";
            this.label25.AutoSize = true;
            this.label25.Location = new Point(5, 0);
            this.label25.Name = "label25";
            this.label25.Size = new Size(147, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Количество точек поставки";

            this.numCountAbnObjSource.Location = new Point(12, 179);
            //NumericUpDown numericUpDown8 = this.numCountAbnObjSource;
            int[] array8 = new int[4];
            array8[0] = 999999;
            numCountAbnObjSource.Maximum = new decimal(array8);
            this.numCountAbnObjSource.Name = "numCountAbnObjSource";
            this.numCountAbnObjSource.Size = new Size(144, 20);
            this.numCountAbnObjSource.TabIndex = 21;
            this.numCountAbnObjSource.ValueChanged += new EventHandler(this.numCountAbnObjSource_ValueChanged);

            this.numCountAbnObjEE.Location = new Point(164, 140);
            //NumericUpDown numericUpDown9 = this.numCountAbnObjEE;
            int[] array9 = new int[4];
            array9[0] = 999999;
            numCountAbnObjEE.Maximum = new decimal(array9);
            this.numCountAbnObjEE.Name = "numCountAbnObjEE";
            this.numCountAbnObjEE.Size = new Size(160, 20);
            this.numCountAbnObjEE.TabIndex = 20;
            this.numCountAbnObjEE.ValueChanged += new EventHandler(this.numCountAbnObjSource_ValueChanged);

            this.numCountAbnObjCat3.Location = new Point(12, 140);
            //NumericUpDown numericUpDown10 = this.numCountAbnObjCat3;
            int[] array10 = new int[4];
            array10[0] = 999999;
            numCountAbnObjCat3.Maximum = new decimal(array10);
            this.numCountAbnObjCat3.Name = "numCountAbnObjCat3";
            this.numCountAbnObjCat3.Size = new Size(144, 20);
            this.numCountAbnObjCat3.TabIndex = 19;
            this.numCountAbnObjCat3.ValueChanged += new EventHandler(this.numCountAbnObjSource_ValueChanged);

            this.label31.AutoSize = true;
            this.label31.Location = new Point(3, 0);
            this.label31.Name = "label31";
            this.label31.Size = new Size(169, 13);
            this.label31.TabIndex = 18;
            this.label31.Text = "Количество потребителей услуг";
            this.groupBox7.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.groupBox7.Controls.Add(this.numCountAbnObj670);
            this.groupBox7.Controls.Add(this.numCountAbnObj150670);
            this.groupBox7.Controls.Add(this.numCountAbnObj150);
            this.groupBox7.Controls.Add(this.label34);
            this.groupBox7.Controls.Add(this.label33);
            this.groupBox7.Controls.Add(this.label32);
            this.groupBox7.Location = new Point(367, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new Size(135, 183);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Максимальная мощность";

            this.numCountAbnObj670.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.numCountAbnObj670.Location = new Point(9, 112);
            //NumericUpDown numericUpDown11 = this.numCountAbnObj670;
            int[] array11 = new int[4];
            array11[0] = 999999;
            numCountAbnObj670.Maximum = new decimal(array11);
            this.numCountAbnObj670.Name = "numCountAbnObj670";
            this.numCountAbnObj670.Size = new Size(120, 20);
            this.numCountAbnObj670.TabIndex = 11;
            this.numCountAbnObj670.ValueChanged += new EventHandler(this.numCountAbnObjSource_ValueChanged);

            this.numCountAbnObj150670.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.numCountAbnObj150670.Location = new Point(9, 73);
            //NumericUpDown numericUpDown12 = this.numCountAbnObj150670;
            int[] array12 = new int[4];
            array12[0] = 999999;
            numCountAbnObj150670.Maximum = new decimal(array12);
            this.numCountAbnObj150670.Name = "numCountAbnObj150670";
            this.numCountAbnObj150670.Size = new Size(120, 20);
            this.numCountAbnObj150670.TabIndex = 10;
            this.numCountAbnObj150670.ValueChanged += new EventHandler(this.numCountAbnObjSource_ValueChanged);

            this.numCountAbnObj150.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.numCountAbnObj150.Location = new Point(9, 34);
            //NumericUpDown numericUpDown13 = this.numCountAbnObj150;
            int[] array13 = new int[4];
            array13[0] = 999999;
            numCountAbnObj150.Maximum = new decimal(array13);
            this.numCountAbnObj150.Name = "numCountAbnObj150";
            this.numCountAbnObj150.Size = new Size(120, 20);
            this.numCountAbnObj150.TabIndex = 9;
            this.numCountAbnObj150.ValueChanged += new EventHandler(this.numCountAbnObjSource_ValueChanged);

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
            this.groupBox8.Controls.Add(this.numCountAbnObjCat1);
            this.groupBox8.Controls.Add(this.numCountAbnObjCat1Full);
            this.groupBox8.Controls.Add(this.label26);
            this.groupBox8.Controls.Add(this.label27);
            this.groupBox8.Location = new Point(3, 16);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new Size(358, 51);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "1 категория надежности";

            this.numCountAbnObjCat1.Location = new Point(225, 19);
            //NumericUpDown numericUpDown14 = this.numCountAbnObjCat1;
            int[] array14 = new int[4];
            array14[0] = 999999;
            numCountAbnObjCat1.Maximum = new decimal(array14);
            this.numCountAbnObjCat1.Name = "numCountAbnObjCat1";
            this.numCountAbnObjCat1.Size = new Size(96, 20);
            this.numCountAbnObjCat1.TabIndex = 6;
            this.numCountAbnObjCat1.ValueChanged += new EventHandler(this.numCountAbnObjSource_ValueChanged);

            this.numCountAbnObjCat1Full.Location = new Point(53, 18);
            //NumericUpDown numericUpDown15 = this.numCountAbnObjCat1Full;
            int[] array15 = new int[4];
            array15[0] = 999999;
            numCountAbnObjCat1Full.Maximum = new decimal(array15);
            this.numCountAbnObjCat1Full.Name = "numCountAbnObjCat1Full";
            this.numCountAbnObjCat1Full.Size = new Size(96, 20);
            this.numCountAbnObjCat1Full.TabIndex = 5;
            this.numCountAbnObjCat1Full.ValueChanged += new EventHandler(this.numCountAbnObjSource_ValueChanged);

            this.label26.AutoSize = true;
            this.label26.Location = new Point(158, 21);
            this.label26.Name = "label26";
            this.label26.Size = new Size(61, 13);
            this.label26.TabIndex = 2;
            this.label26.Text = "Частичное";
            this.label27.AutoSize = true;
            this.label27.Location = new Point(6, 21);
            this.label27.Name = "label27";
            this.label27.Size = new Size(45, 13);
            this.label27.TabIndex = 0;
            this.label27.Text = "Полное";
            this.label28.AutoSize = true;
            this.label28.Location = new Point(9, 163);
            this.label28.Name = "label28";
            this.label28.Size = new Size(209, 13);
            this.label28.TabIndex = 15;
            this.label28.Text = "Производители электрической энергии";
            this.label29.AutoSize = true;
            this.label29.Location = new Point(161, 124);
            this.label29.Name = "label29";
            this.label29.Size = new Size(158, 13);
            this.label29.TabIndex = 13;
            this.label29.Text = "Электросетевая организация";
            this.label30.AutoSize = true;
            this.label30.Location = new Point(9, 124);
            this.label30.Name = "label30";
            this.label30.Size = new Size(132, 13);
            this.label30.TabIndex = 11;
            this.label30.Text = "3 категория надежности";
            this.groupBox9.Controls.Add(this.numCountAbnObjCat2);
            this.groupBox9.Controls.Add(this.numCountAbnObjCat2Full);
            this.groupBox9.Controls.Add(this.label35);
            this.groupBox9.Controls.Add(this.label36);
            this.groupBox9.Location = new Point(3, 70);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new Size(358, 51);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "2 категория надежности";

            this.numCountAbnObjCat2.Location = new Point(225, 18);
            //NumericUpDown numericUpDown16 = this.numCountAbnObjCat2;
            int[] array16 = new int[4];
            array16[0] = 999999;
            numCountAbnObjCat2.Maximum = new decimal(array16);
            this.numCountAbnObjCat2.Name = "numCountAbnObjCat2";
            this.numCountAbnObjCat2.Size = new Size(96, 20);
            this.numCountAbnObjCat2.TabIndex = 7;
            this.numCountAbnObjCat2.ValueChanged += new EventHandler(this.numCountAbnObjSource_ValueChanged);

            this.numCountAbnObjCat2Full.Location = new Point(53, 18);
            //NumericUpDown numericUpDown17 = this.numCountAbnObjCat2Full;
            int[] array17 = new int[4];
            array17[0] = 999999;
            numCountAbnObjCat2Full.Maximum = new decimal(array17);
            this.numCountAbnObjCat2Full.Name = "numCountAbnObjCat2Full";
            this.numCountAbnObjCat2Full.Size = new Size(96, 20);
            this.numCountAbnObjCat2Full.TabIndex = 6;
            this.numCountAbnObjCat2Full.ValueChanged += new EventHandler(this.numCountAbnObjSource_ValueChanged);

            this.label35.AutoSize = true;
            this.label35.Location = new Point(158, 21);
            this.label35.Name = "label35";
            this.label35.Size = new Size(61, 13);
            this.label35.TabIndex = 2;
            this.label35.Text = "Частичное";
            this.label36.AutoSize = true;
            this.label36.Location = new Point(6, 21);
            this.label36.Name = "label36";
            this.label36.Size = new Size(45, 13);
            this.label36.TabIndex = 0;
            this.label36.Text = "Полное";
            this.statusStripAbnObj.Items.AddRange(new ToolStripItem[]
            {
            this.toolBtnRefreshCountAbn,
            this.labelCountPoint,
            this.labelCountAbnObj,
            this.labelCountAbn
            });
            this.statusStripAbnObj.Location = new Point(3, 650);
            this.statusStripAbnObj.Name = "statusStripAbnObj";
            this.statusStripAbnObj.Size = new Size(890, 22);
            this.statusStripAbnObj.TabIndex = 11;
            this.statusStripAbnObj.Text = "statusStrip1";
            this.toolBtnRefreshCountAbn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshCountAbn.Image = (Image)global::DailyReportN.Properties.Resources.refresh_16;
            this.toolBtnRefreshCountAbn.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefreshCountAbn.Name = "toolBtnRefreshCountAbn";
            this.toolBtnRefreshCountAbn.ShowDropDownArrow = false;
            this.toolBtnRefreshCountAbn.Size = new Size(20, 20);
            this.toolBtnRefreshCountAbn.Text = "Обновить итоги";
            this.toolBtnRefreshCountAbn.Click += new EventHandler(this.toolBtnRefreshCountAbn_Click);

            this.labelCountPoint.Name = "labelCountPoint";
            this.labelCountPoint.Size = new Size(285, 17);
            this.labelCountPoint.Spring = true;
            this.labelCountPoint.Text = "Количество точек поставки: 0";
            this.labelCountAbnObj.Name = "labelCountAbnObj";
            this.labelCountAbnObj.Size = new Size(285, 17);
            this.labelCountAbnObj.Spring = true;
            this.labelCountAbnObj.Text = "Количество объектов: 0";
            this.labelCountAbn.Name = "labelCountAbn";
            this.labelCountAbn.Size = new Size(285, 17);
            this.labelCountAbn.Spring = true;
            this.labelCountAbn.Text = "Количество абонентов: 0";
            this.toolStripAbn.Items.AddRange(new ToolStripItem[]
            {
            this.toolBtnRefreshAbn,
            this.toolBrnDelAbn
            });
            this.toolStripAbn.Location = new Point(3, 3);
            this.toolStripAbn.Name = "toolStripAbn";
            this.toolStripAbn.Size = new Size(890, 25);
            this.toolStripAbn.TabIndex = 7;
            this.toolStripAbn.Text = "toolStrip1";
            this.toolBtnRefreshAbn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshAbn.Image = (Image)global::DailyReportN.Properties.Resources.refresh_16;
            this.toolBtnRefreshAbn.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefreshAbn.Name = "toolBtnRefreshAbn";
            this.toolBtnRefreshAbn.Size = new Size(23, 22);
            this.toolBtnRefreshAbn.Text = "Обновить";
            this.toolBtnRefreshAbn.Click += new EventHandler(this.toolBtnRefreshAbn_Click);

            this.toolBrnDelAbn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBrnDelAbn.Image = (Image)global::DailyReportN.Properties.Resources.Delete;
            this.toolBrnDelAbn.ImageTransparentColor = Color.Magenta;
            this.toolBrnDelAbn.Name = "toolBrnDelAbn";
            this.toolBrnDelAbn.Size = new Size(23, 22);
            this.toolBrnDelAbn.Text = "Удалить абонентов";
            this.toolBrnDelAbn.Click += new EventHandler(this.toolBrnDelAbn_Click);

            this.buttonClose.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.buttonClose.DialogResult = DialogResult.Cancel;
            this.buttonClose.Location = new Point(815, 707);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new EventHandler(this.buttonClose_Click);
            this.buttonSave.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.buttonSave.DialogResult = DialogResult.OK;
            this.buttonSave.Location = new Point(12, 707);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new EventHandler(this.buttonSave_Click);

            this.dataGridViewComboBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn1.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn1.HeaderText = "Тип объекта";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewComboBoxColumn2.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn2.HeaderText = "Участок";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.ReadOnly = true;
            this.dataGridViewComboBoxColumn2.Width = 60;
            this.dataGridViewComboBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn3.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn3.HeaderText = "Повреждение";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewComboBoxColumn4.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewComboBoxColumn4.HeaderText = "Уточнение";
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.backgroundWorker1.DoWork += new DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.progressBar.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.progressBar.Location = new Point(321, 707);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new Size(488, 23);
            this.progressBar.Style = ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 8;
            this.progressBar.Visible = false;
            this.labelProgress.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new Point(93, 712);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new Size(180, 13);
            this.labelProgress.TabIndex = 7;
            this.labelProgress.Text = "Загрузка отключенных абонентов";
            this.labelProgress.Visible = false;
            this.dataColumn13.ColumnName = "CategoryName";
            this.dataColumn14.ColumnName = "PowerSet";
            this.dataColumn14.DataType = typeof(decimal);
            this.dataColumn15.ColumnName = "countPoint";
            this.dataColumn15.DataType = typeof(int);
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
            this.nameAbnDataGridViewTextBoxColumn.FillWeight = 85.10515f;
            this.nameAbnDataGridViewTextBoxColumn.HeaderText = "Абонент";
            this.nameAbnDataGridViewTextBoxColumn.Name = "nameAbnDataGridViewTextBoxColumn";
            this.nameAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAbnDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.typeAbnDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.typeAbnDgvColumn.DataPropertyName = "typeAbn";
            this.typeAbnDgvColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeAbnDgvColumn.FillWeight = 70.30425f;
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
            this.nameObjDataGridViewTextBoxColumn.FillWeight = 91.27219f;
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            this.nameObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameObjDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            this.categoryNameDgColumn.DataPropertyName = "CategoryName";
            this.categoryNameDgColumn.HeaderText = "Кат";
            this.categoryNameDgColumn.Name = "categoryNameDgColumn";
            this.categoryNameDgColumn.ReadOnly = true;
            this.categoryNameDgColumn.Width = 50;
            this.powerSetDgvColumn.DataPropertyName = "PowerSet";
            this.powerSetDgvColumn.HeaderText = "Мощность";
            this.powerSetDgvColumn.Name = "powerSetDgvColumn";
            this.powerSetDgvColumn.ReadOnly = true;
            this.powerSetDgvColumn.Width = 50;
            this.countPointDgvColumn.DataPropertyName = "countPoint";
            this.countPointDgvColumn.HeaderText = "Кол-во т.у.";
            this.countPointDgvColumn.Name = "countPointDgvColumn";
            this.countPointDgvColumn.ReadOnly = true;
            this.countPointDgvColumn.Width = 40;
            this.commentODSDgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.commentODSDgvColumn.DataPropertyName = "CommentODS";
            this.commentODSDgvColumn.FillWeight = 101.5506f;
            this.commentODSDgvColumn.HeaderText = "Примечание";
            this.commentODSDgvColumn.Name = "commentODSDgvColumn";
            this.commentODSDgvColumn.ReadOnly = true;
            base.AcceptButton = this.buttonSave;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.CancelButton = this.buttonClose;
            base.ClientSize = new Size(902, 738);
            base.Controls.Add(this.progressBar);
            base.Controls.Add(this.labelProgress);
            base.Controls.Add(this.buttonSave);
            base.Controls.Add(this.buttonClose);
            base.Controls.Add(this.tabControl1);
            base.Name = "FormDefectAddEdit";
            this.Text = " ";
            base.FormClosing += new FormClosingEventHandler(this.FormDefectAddEdit_FormClosing);
            base.Load += new EventHandler(this.FormDefectAddEdit_Load);
            base.Shown += new EventHandler(this.FormDefectAddEdit_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.toolStrip81.ResumeLayout(false);
            this.toolStrip81.PerformLayout();
            ((ISupportInitialize)this.dataSetDamage).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxDefectData.ResumeLayout(false);
            this.groupBoxDefectData.PerformLayout();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            ((ISupportInitialize)this.dgvCharacterDamage).EndInit();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.tabPageAbn.ResumeLayout(false);
            this.tabPageAbn.PerformLayout();
            this.splitContainerAbn.Panel1.ResumeLayout(false);
            this.splitContainerAbn.Panel2.ResumeLayout(false);
            this.splitContainerAbn.ResumeLayout(false);
            ((ISupportInitialize)this.dgvAbn).EndInit();
            ((ISupportInitialize)this.bsSchmAbnFull).EndInit();
            ((ISupportInitialize)this.dsDefect).EndInit();
            ((ISupportInitialize)this.Table1).EndInit();
            ((ISupportInitialize)this.dtSchmAbnFull).EndInit();
            this.splitContainerAbnCount.Panel1.ResumeLayout(false);
            this.splitContainerAbnCount.Panel1.PerformLayout();
            this.splitContainerAbnCount.Panel2.ResumeLayout(false);
            this.splitContainerAbnCount.Panel2.PerformLayout();
            this.splitContainerAbnCount.ResumeLayout(false);
            ((ISupportInitialize)this.numCountPointSource).EndInit();
            ((ISupportInitialize)this.numCountPointEE).EndInit();
            ((ISupportInitialize)this.numCountPointCat3).EndInit();
            this.groupBox_3.ResumeLayout(false);
            this.groupBox_3.PerformLayout();
            ((ISupportInitialize)this.numCountPointCat1).EndInit();
            ((ISupportInitialize)this.numCountPointCat1Full).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((ISupportInitialize)this.numCountPointCat2Full).EndInit();
            ((ISupportInitialize)this.numCountPointCat2).EndInit();
            ((ISupportInitialize)this.numCountAbnObjSource).EndInit();
            ((ISupportInitialize)this.numCountAbnObjEE).EndInit();
            ((ISupportInitialize)this.numCountAbnObjCat3).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((ISupportInitialize)this.numCountAbnObj670).EndInit();
            ((ISupportInitialize)this.numCountAbnObj150670).EndInit();
            ((ISupportInitialize)this.numCountAbnObj150).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((ISupportInitialize)this.numCountAbnObjCat1).EndInit();
            ((ISupportInitialize)this.numCountAbnObjCat1Full).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((ISupportInitialize)this.numCountAbnObjCat2).EndInit();
            ((ISupportInitialize)this.numCountAbnObjCat2Full).EndInit();
            this.statusStripAbnObj.ResumeLayout(false);
            this.statusStripAbnObj.PerformLayout();
            this.toolStripAbn.ResumeLayout(false);
            this.toolStripAbn.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        //private Class171.Class172 tableDamage;
        private DailyReportN.DataSet.dsDamage.tJ_DamageDataTable tableDamage;
        //private Class171.Class184 tableDamageCharacter;
        private DailyReportN.DataSet.dsDamage.tJ_DamageCharacterDataTable tableDamageCharacter;

        private TabControl tabControl1;

        private TabPage tabPageGeneral;

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

        private GroupBox groupBoxResult;

        private NullableDateTimePicker dtpDataApply;

        private Label labelDateAplly;

        private ComboBox cmbWorkerApply;

        private CheckBox checkBoxApply;

        private RichTextBox txtCompletedWork;

        private Label labelCompletedWork;

        private ComboBox cmbCompletedWork;

        private DataGridView dgvCharacterDamage;

        private Label label1ChatacterDamage;

        private ComboBoxReadOnly cmbReason;

        private Label labelReason;

        private DailyReportN.DataSet.dsDamage dataSetDamage;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        private TextBox txtDocParent;

        private Label label1;

        private CheckBox checkBoxLaboratory;

        private Label labelDivisionApply;

        private NullableDateTimePicker dtpDatePlanApply;

        private Label label5;

        private Button btnShowDocParent;

        private ToolTip toolTipDocParent;

        private RichTextBox txtLocation;

        private Label label7;

        private GroupBox groupBoxAddress;

        private SplitContainer splitContainer1;

        private RichTextBox txtComplWorkODS;

        private Label label9;

        private RichTextBox txtInstruction;

        private Label label8;

        private ComboBoxReadOnly cmbComplWorkODS;

        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;

        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;

        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;

        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;

        private ComboBoxReadOnly cmbDivisionApply;

        private DataGridViewComboBoxColumn ColumnTypeObj;

        private DataGridViewTextBoxColumn ColumnSchmObj;

        private DataGridViewTextBoxColumn ColumnIdSchmObj;

        private DataGridViewButtonColumn ColumnBtn;

        private DataGridViewComboBoxColumn ColumnCabSection;

        private DataGridViewComboBoxColumn ColumnDamage;

        private DataGridViewComboBoxColumn ColumnDamageExtended;

        private ToolStrip toolStrip81;

        private ToolStripButton toolBtn81;

        private TabPage tabPageAbn;

        private ToolStrip toolStripAbn;

        private ToolStripButton toolBtnRefreshAbn;

        private ToolStripButton toolBrnDelAbn;

        private System.Data.DataSet dsDefect;

        private DataTable Table1;

        private DataColumn dataColumn16;

        private DataColumn dataColumn1;

        private DataColumn dataColumn2;

        private DataColumn dataColumn3;

        private DataColumn dataColumn4;

        private DataColumn dataColumn5;

        private DataTable dtSchmAbnFull;

        private DataColumn dataColumn6;

        private DataColumn dataColumn7;

        private DataColumn dataColumn8;

        private DataColumn dataColumn9;

        private DataColumn dataColumn10;

        private DataColumn dataColumn11;

        private DataColumn dataColumn12;

        private BindingSource bsSchmAbnFull;

        private SplitContainer splitContainerAbn;

        private DataGridViewExcelFilter dgvAbn;

        private SplitContainer splitContainerAbnCount;

        private NumericUpDown numCountPointSource;

        private NumericUpDown numCountPointEE;

        private NumericUpDown numCountPointCat3;

        private GroupBox groupBox_3;

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

        private StatusStrip statusStripAbnObj;

        private ToolStripDropDownButton toolBtnRefreshCountAbn;

        private ToolStripStatusLabel labelCountPoint;

        private ToolStripStatusLabel labelCountAbnObj;

        private ToolStripStatusLabel labelCountAbn;

        private BackgroundWorker backgroundWorker1;

        private ProgressBar progressBar;

        private Label labelProgress;

        private DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nameAbnDataGridViewTextBoxColumn;

        private DataGridViewFilterComboBoxColumn typeAbnDgvColumn;

        private DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn;

        private DataGridViewFilterTextBoxColumn categoryNameDgColumn;

        private DataGridViewFilterTextBoxColumn powerSetDgvColumn;

        private DataGridViewFilterTextBoxColumn countPointDgvColumn;

        private DataGridViewFilterTextBoxColumn commentODSDgvColumn;

        private DataColumn dataColumn13;

        private DataColumn dataColumn14;

        private DataColumn dataColumn15;
    }
}