namespace Legal.Forms.ActCheck
{
    partial class FormDocAct_CheckAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDocAct_CheckAdd));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbActType = new System.Windows.Forms.ComboBox();
            this.bsActType = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            this.panelPoint = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbEditPoint = new System.Windows.Forms.ToolStripButton();
            this.gbPointRegCheck = new System.Windows.Forms.GroupBox();
            this.dgvPointRegCheck = new System.Windows.Forms.DataGridView();
            this.idPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namePointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberTIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameTUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTUPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTIPR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPointReg = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSealTransU = new System.Windows.Forms.DataGridView();
            this.idTransU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerTransU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberTransU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActTransU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationTransU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentTransU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTypeTransU = new System.Windows.Forms.ComboBox();
            this.bsTransfU = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbnObjAkt1 = new Legal.DataSet.dsAbnObjAct();
            this.tbNumTransU = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNomTransUEnd = new System.Windows.Forms.TextBox();
            this.tbNomTransUBeg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tsSealTransU = new System.Windows.Forms.ToolStrip();
            this.tsbSealTransUAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbSealTransUDelete = new System.Windows.Forms.ToolStripButton();
            this.tbRatioTransU = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.qybCalibrationTransU = new ControlsLbr.QuarterYearBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbRepresentative = new System.Windows.Forms.GroupBox();
            this.tbRepresentFIO = new System.Windows.Forms.TextBox();
            this.tbRepresentPost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbOwner = new System.Windows.Forms.GroupBox();
            this.cbOwnerFIO = new System.Windows.Forms.ComboBox();
            this.bdsWorker1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbOwnerJobTitle = new System.Windows.Forms.ComboBox();
            this.lbOwnerJobTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpActDate = new System.Windows.Forms.DateTimePicker();
            this.tbActNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTransI = new System.Windows.Forms.GroupBox();
            this.dgvSealTransI = new System.Windows.Forms.DataGridView();
            this.idTransI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerTransI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberSealTransI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActTransI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationSealTransI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentSealTransI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTypeTransI = new System.Windows.Forms.ComboBox();
            this.bsTransfI = new System.Windows.Forms.BindingSource(this.components);
            this.tbNumTransI = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tsSealTransI = new System.Windows.Forms.ToolStrip();
            this.tsbSealTransIAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbSealTransIDelete = new System.Windows.Forms.ToolStripButton();
            this.tbRatioTransI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNomTransIEnd = new System.Windows.Forms.TextBox();
            this.tbNomTransIBeg = new System.Windows.Forms.TextBox();
            this.lbTransIRatio = new System.Windows.Forms.Label();
            this.lbNomTransI = new System.Windows.Forms.Label();
            this.qybCalibrationTransI = new ControlsLbr.QuarterYearBox();
            this.lbTypeTransI = new System.Windows.Forms.Label();
            this.lbCalibrationTransI = new System.Windows.Forms.Label();
            this.gbMeter = new System.Windows.Forms.GroupBox();
            this.dgvZoneIndicator = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZobeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSubZoneNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subZoneNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsZoneValue = new System.Windows.Forms.BindingSource(this.components);
            this.dsZone = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataTableVr_Zone = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.qybCalibrationMeter = new ControlsLbr.QuarterYearBox();
            this.cbTypeMeter = new System.Windows.Forms.ComboBox();
            this.cbNumMeter = new System.Windows.Forms.ComboBox();
            this.tsSealMeter = new System.Windows.Forms.ToolStrip();
            this.tsbSealMeterAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbSealMeterDelete = new System.Windows.Forms.ToolStripButton();
            this.dgvSealMeter = new System.Windows.Forms.DataGridView();
            this.idMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberSealMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationSealMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentSealMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCapasityMeter = new System.Windows.Forms.TextBox();
            this.lbCapacityMeter = new System.Windows.Forms.Label();
            this.lbCalibrationMeter = new System.Windows.Forms.Label();
            this.lbTypeMeter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNumMeter = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvStrikeRreveal = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idParentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isGroupDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deletedDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StrikeRevealValue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsActClassifierStrikeReveal = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMalfunction = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idParentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isGroupDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MalfunctionValue = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsActClassifierMalfunction = new System.Windows.Forms.BindingSource(this.components);
            this.tbFactConsuptionNote = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.tbPrincipSchemeNote = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpStrikeRrevealDate = new System.Windows.Forms.DateTimePicker();
            this.cbFactConsuption = new System.Windows.Forms.ComboBox();
            this.cbPrincipScheme = new System.Windows.Forms.ComboBox();
            this.tbStrikeRrevealNote = new System.Windows.Forms.TextBox();
            this.gbCheckLoad = new System.Windows.Forms.GroupBox();
            this.lt = new System.Windows.Forms.Label();
            this.nudP = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.nudCos = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.nudS = new System.Windows.Forms.NumericUpDown();
            this.nudSec = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.nudFc = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.nudFb = new System.Windows.Forms.NumericUpDown();
            this.nudFa = new System.Windows.Forms.NumericUpDown();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbMalfunctionNote = new System.Windows.Forms.TextBox();
            this.cbConformityRate = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbConformityRateNote = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtInput = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnOrderSave = new System.Windows.Forms.Button();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.bsOrder = new System.Windows.Forms.BindingSource(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsActType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            this.panelPoint.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.gbPointRegCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointRegCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPointReg)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSealTransU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransfU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnObjAkt1)).BeginInit();
            this.tsSealTransU.SuspendLayout();
            this.gbRepresentative.SuspendLayout();
            this.gbOwner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorker1)).BeginInit();
            this.gbTransI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSealTransI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransfI)).BeginInit();
            this.tsSealTransI.SuspendLayout();
            this.gbMeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZoneIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZoneValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVr_Zone)).BeginInit();
            this.tsSealMeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSealMeter)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrikeRreveal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActClassifierStrikeReveal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalfunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActClassifierMalfunction)).BeginInit();
            this.gbCheckLoad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFa)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(630, 588);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(727, 588);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 585);
            this.tabControl1.TabIndex = 111;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.cbActType);
            this.tabPage1.Controls.Add(this.panelPoint);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gbRepresentative);
            this.tabPage1.Controls.Add(this.gbOwner);
            this.tabPage1.Controls.Add(this.dtpActDate);
            this.tabPage1.Controls.Add(this.tbActNumber);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gbTransI);
            this.tabPage1.Controls.Add(this.gbMeter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Узел и приборы учета";
            // 
            // cbActType
            // 
            this.cbActType.DataSource = this.bsActType;
            this.cbActType.DisplayMember = "Name";
            this.cbActType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbActType.FormattingEnabled = true;
            this.cbActType.Location = new System.Drawing.Point(31, 143);
            this.cbActType.Name = "cbActType";
            this.cbActType.Size = new System.Drawing.Size(429, 21);
            this.cbActType.TabIndex = 126;
            this.cbActType.ValueMember = "Id";
            // 
            // bsActType
            // 
            this.bsActType.DataMember = "tR_Classifier_ActType";
            this.bsActType.DataSource = this.dsAbn;
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelPoint
            // 
            this.panelPoint.Controls.Add(this.toolStrip1);
            this.panelPoint.Controls.Add(this.gbPointRegCheck);
            this.panelPoint.Location = new System.Drawing.Point(2, 0);
            this.panelPoint.Name = "panelPoint";
            this.panelPoint.Size = new System.Drawing.Size(790, 137);
            this.panelPoint.TabIndex = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEditPoint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 112);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(790, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbEditPoint
            // 
            this.tsbEditPoint.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEditPoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditPoint.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditPoint.Image")));
            this.tsbEditPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditPoint.Name = "tsbEditPoint";
            this.tsbEditPoint.Size = new System.Drawing.Size(23, 22);
            this.tsbEditPoint.Text = "toolStripButton1";
            this.tsbEditPoint.ToolTipText = "Редактировать точку учета";
            this.tsbEditPoint.Click += new System.EventHandler(this.tsbEditPoint_Click);
            // 
            // gbPointRegCheck
            // 
            this.gbPointRegCheck.Controls.Add(this.dgvPointRegCheck);
            this.gbPointRegCheck.Location = new System.Drawing.Point(3, 6);
            this.gbPointRegCheck.Name = "gbPointRegCheck";
            this.gbPointRegCheck.Size = new System.Drawing.Size(784, 107);
            this.gbPointRegCheck.TabIndex = 124;
            this.gbPointRegCheck.TabStop = false;
            this.gbPointRegCheck.Text = "Точки учета";
            // 
            // dgvPointRegCheck
            // 
            this.dgvPointRegCheck.AllowUserToAddRows = false;
            this.dgvPointRegCheck.AllowUserToDeleteRows = false;
            this.dgvPointRegCheck.AutoGenerateColumns = false;
            this.dgvPointRegCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPointRegCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPoint,
            this.idAbnObjDataGridViewTextBoxColumn,
            this.namePointDataGridViewTextBoxColumn,
            this.numberMDataGridViewTextBoxColumn,
            this.nameMDataGridViewTextBoxColumn,
            this.numberTIDataGridViewTextBoxColumn,
            this.nameTIDataGridViewTextBoxColumn,
            this.numberTUDataGridViewTextBoxColumn,
            this.nameTUDataGridViewTextBoxColumn,
            this.idMPR,
            this.idTUPR,
            this.idTIPR});
            this.dgvPointRegCheck.DataSource = this.bsPointReg;
            this.dgvPointRegCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPointRegCheck.Location = new System.Drawing.Point(3, 16);
            this.dgvPointRegCheck.MultiSelect = false;
            this.dgvPointRegCheck.Name = "dgvPointRegCheck";
            this.dgvPointRegCheck.ReadOnly = true;
            this.dgvPointRegCheck.RowHeadersWidth = 5;
            this.dgvPointRegCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPointRegCheck.Size = new System.Drawing.Size(778, 88);
            this.dgvPointRegCheck.TabIndex = 0;
            this.dgvPointRegCheck.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // idPoint
            // 
            this.idPoint.DataPropertyName = "id";
            this.idPoint.HeaderText = "id";
            this.idPoint.Name = "idPoint";
            this.idPoint.ReadOnly = true;
            this.idPoint.Visible = false;
            // 
            // idAbnObjDataGridViewTextBoxColumn
            // 
            this.idAbnObjDataGridViewTextBoxColumn.DataPropertyName = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.HeaderText = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.idAbnObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // namePointDataGridViewTextBoxColumn
            // 
            this.namePointDataGridViewTextBoxColumn.DataPropertyName = "NamePoint";
            this.namePointDataGridViewTextBoxColumn.HeaderText = "№";
            this.namePointDataGridViewTextBoxColumn.Name = "namePointDataGridViewTextBoxColumn";
            this.namePointDataGridViewTextBoxColumn.ReadOnly = true;
            this.namePointDataGridViewTextBoxColumn.Width = 30;
            // 
            // numberMDataGridViewTextBoxColumn
            // 
            this.numberMDataGridViewTextBoxColumn.DataPropertyName = "NumberM";
            this.numberMDataGridViewTextBoxColumn.HeaderText = "№ счетчика";
            this.numberMDataGridViewTextBoxColumn.Name = "numberMDataGridViewTextBoxColumn";
            this.numberMDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberMDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameMDataGridViewTextBoxColumn
            // 
            this.nameMDataGridViewTextBoxColumn.DataPropertyName = "NameM";
            this.nameMDataGridViewTextBoxColumn.HeaderText = "Счетчик";
            this.nameMDataGridViewTextBoxColumn.Name = "nameMDataGridViewTextBoxColumn";
            this.nameMDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameMDataGridViewTextBoxColumn.Width = 120;
            // 
            // numberTIDataGridViewTextBoxColumn
            // 
            this.numberTIDataGridViewTextBoxColumn.DataPropertyName = "NumberTI";
            this.numberTIDataGridViewTextBoxColumn.HeaderText = "№ Тр. тока";
            this.numberTIDataGridViewTextBoxColumn.Name = "numberTIDataGridViewTextBoxColumn";
            this.numberTIDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberTIDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameTIDataGridViewTextBoxColumn
            // 
            this.nameTIDataGridViewTextBoxColumn.DataPropertyName = "NameTI";
            this.nameTIDataGridViewTextBoxColumn.HeaderText = "Тр. тока";
            this.nameTIDataGridViewTextBoxColumn.Name = "nameTIDataGridViewTextBoxColumn";
            this.nameTIDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameTIDataGridViewTextBoxColumn.Width = 120;
            // 
            // numberTUDataGridViewTextBoxColumn
            // 
            this.numberTUDataGridViewTextBoxColumn.DataPropertyName = "NumberTU";
            this.numberTUDataGridViewTextBoxColumn.HeaderText = "№ Тр. напр.";
            this.numberTUDataGridViewTextBoxColumn.Name = "numberTUDataGridViewTextBoxColumn";
            this.numberTUDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberTUDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameTUDataGridViewTextBoxColumn
            // 
            this.nameTUDataGridViewTextBoxColumn.DataPropertyName = "NameTU";
            this.nameTUDataGridViewTextBoxColumn.HeaderText = "Тр. напряжения";
            this.nameTUDataGridViewTextBoxColumn.Name = "nameTUDataGridViewTextBoxColumn";
            this.nameTUDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameTUDataGridViewTextBoxColumn.Width = 120;
            // 
            // idMPR
            // 
            this.idMPR.DataPropertyName = "idMPR";
            this.idMPR.HeaderText = "idMPR";
            this.idMPR.Name = "idMPR";
            this.idMPR.ReadOnly = true;
            this.idMPR.Visible = false;
            // 
            // idTUPR
            // 
            this.idTUPR.DataPropertyName = "idTUPR";
            this.idTUPR.HeaderText = "idTUPR";
            this.idTUPR.Name = "idTUPR";
            this.idTUPR.ReadOnly = true;
            this.idTUPR.Visible = false;
            // 
            // idTIPR
            // 
            this.idTIPR.DataPropertyName = "idTIPR";
            this.idTIPR.HeaderText = "idTIPR";
            this.idTIPR.Name = "idTIPR";
            this.idTIPR.ReadOnly = true;
            this.idTIPR.Visible = false;
            // 
            // bsPointReg
            // 
            this.bsPointReg.DataMember = "vPointRegCheck";
            this.bsPointReg.DataSource = this.dsAbn;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSealTransU);
            this.groupBox1.Controls.Add(this.cbTypeTransU);
            this.groupBox1.Controls.Add(this.tbNumTransU);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbNomTransUEnd);
            this.groupBox1.Controls.Add(this.tbNomTransUBeg);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tsSealTransU);
            this.groupBox1.Controls.Add(this.tbRatioTransU);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.qybCalibrationTransU);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Location = new System.Drawing.Point(530, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 293);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Трансформатор напряжения";
            // 
            // dgvSealTransU
            // 
            this.dgvSealTransU.AllowUserToAddRows = false;
            this.dgvSealTransU.BackgroundColor = System.Drawing.Color.White;
            this.dgvSealTransU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSealTransU.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransU,
            this.idWorkerTransU,
            this.NumberTransU,
            this.ActTransU,
            this.LocationTransU,
            this.CommentTransU});
            this.dgvSealTransU.Location = new System.Drawing.Point(7, 151);
            this.dgvSealTransU.Name = "dgvSealTransU";
            this.dgvSealTransU.RowHeadersVisible = false;
            this.dgvSealTransU.Size = new System.Drawing.Size(243, 109);
            this.dgvSealTransU.TabIndex = 124;
            // 
            // idTransU
            // 
            this.idTransU.DataPropertyName = "id";
            this.idTransU.HeaderText = "idMeter";
            this.idTransU.Name = "idTransU";
            this.idTransU.Visible = false;
            // 
            // idWorkerTransU
            // 
            this.idWorkerTransU.DataPropertyName = "idWorker";
            this.idWorkerTransU.HeaderText = "idWorker";
            this.idWorkerTransU.Name = "idWorkerTransU";
            this.idWorkerTransU.Visible = false;
            // 
            // NumberTransU
            // 
            this.NumberTransU.DataPropertyName = "Number";
            this.NumberTransU.HeaderText = "Номер";
            this.NumberTransU.Name = "NumberTransU";
            // 
            // ActTransU
            // 
            this.ActTransU.DataPropertyName = "Act";
            this.ActTransU.HeaderText = "Действие";
            this.ActTransU.Name = "ActTransU";
            this.ActTransU.Width = 80;
            // 
            // LocationTransU
            // 
            this.LocationTransU.DataPropertyName = "Location";
            this.LocationTransU.HeaderText = "Расположение";
            this.LocationTransU.Name = "LocationTransU";
            this.LocationTransU.Width = 140;
            // 
            // CommentTransU
            // 
            this.CommentTransU.DataPropertyName = "Comment";
            this.CommentTransU.HeaderText = "Коментарий";
            this.CommentTransU.Name = "CommentTransU";
            this.CommentTransU.Width = 150;
            // 
            // cbTypeTransU
            // 
            this.cbTypeTransU.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTypeTransU.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTypeTransU.DataSource = this.bsTransfU;
            this.cbTypeTransU.DisplayMember = "Name";
            this.cbTypeTransU.FormattingEnabled = true;
            this.cbTypeTransU.Location = new System.Drawing.Point(38, 44);
            this.cbTypeTransU.Name = "cbTypeTransU";
            this.cbTypeTransU.Size = new System.Drawing.Size(212, 21);
            this.cbTypeTransU.TabIndex = 123;
            this.cbTypeTransU.ValueMember = "idPointReg";
            // 
            // bsTransfU
            // 
            this.bsTransfU.DataMember = "vPointCheckTransFill";
            this.bsTransfU.DataSource = this.dsAbnObjAkt1;
            this.bsTransfU.Filter = "TypeTrans = 69";
            this.bsTransfU.CurrentChanged += new System.EventHandler(this.bsTransfU_CurrentChanged);
            // 
            // dsAbnObjAkt1
            // 
            this.dsAbnObjAkt1.DataSetName = "dsAbnObjAkt";
            this.dsAbnObjAkt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbNumTransU
            // 
            this.tbNumTransU.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbNumTransU.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNumTransU.Location = new System.Drawing.Point(54, 18);
            this.tbNumTransU.Name = "tbNumTransU";
            this.tbNumTransU.Size = new System.Drawing.Size(196, 20);
            this.tbNumTransU.TabIndex = 122;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 121;
            this.label16.Text = "Номер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 120;
            this.label6.Text = "/";
            // 
            // tbNomTransUEnd
            // 
            this.tbNomTransUEnd.Location = new System.Drawing.Point(174, 71);
            this.tbNomTransUEnd.Name = "tbNomTransUEnd";
            this.tbNomTransUEnd.Size = new System.Drawing.Size(76, 20);
            this.tbNomTransUEnd.TabIndex = 119;
            // 
            // tbNomTransUBeg
            // 
            this.tbNomTransUBeg.Location = new System.Drawing.Point(74, 71);
            this.tbNomTransUBeg.Name = "tbNomTransUBeg";
            this.tbNomTransUBeg.Size = new System.Drawing.Size(76, 20);
            this.tbNomTransUBeg.TabIndex = 118;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 117;
            this.label8.Text = "Номинал";
            // 
            // tsSealTransU
            // 
            this.tsSealTransU.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSealTransU.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSealTransUAdd,
            this.tsbSealTransUDelete});
            this.tsSealTransU.Location = new System.Drawing.Point(3, 265);
            this.tsSealTransU.Name = "tsSealTransU";
            this.tsSealTransU.Size = new System.Drawing.Size(250, 25);
            this.tsSealTransU.TabIndex = 116;
            this.tsSealTransU.Text = "toolStrip2";
            // 
            // tsbSealTransUAdd
            // 
            this.tsbSealTransUAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSealTransUAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbSealTransUAdd.Image")));
            this.tsbSealTransUAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSealTransUAdd.Name = "tsbSealTransUAdd";
            this.tsbSealTransUAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbSealTransUAdd.Text = "Установка пломбы";
            this.tsbSealTransUAdd.Click += new System.EventHandler(this.tsbSealTransUAdd_Click);
            // 
            // tsbSealTransUDelete
            // 
            this.tsbSealTransUDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSealTransUDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbSealTransUDelete.Image")));
            this.tsbSealTransUDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSealTransUDelete.Name = "tsbSealTransUDelete";
            this.tsbSealTransUDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbSealTransUDelete.Text = "Демонтаж пломбы";
            this.tsbSealTransUDelete.ToolTipText = "Демонтаж пломбы";
            this.tsbSealTransUDelete.Click += new System.EventHandler(this.tsbSealTransUDelete_Click);
            // 
            // tbRatioTransU
            // 
            this.tbRatioTransU.Location = new System.Drawing.Point(92, 97);
            this.tbRatioTransU.Name = "tbRatioTransU";
            this.tbRatioTransU.Size = new System.Drawing.Size(158, 20);
            this.tbRatioTransU.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Коэф. трансф.";
            // 
            // qybCalibrationTransU
            // 
            this.qybCalibrationTransU.Location = new System.Drawing.Point(77, 120);
            this.qybCalibrationTransU.Name = "qybCalibrationTransU";
            this.qybCalibrationTransU.Size = new System.Drawing.Size(176, 25);
            this.qybCalibrationTransU.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Тип";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Госповерка";
            // 
            // gbRepresentative
            // 
            this.gbRepresentative.Controls.Add(this.tbRepresentFIO);
            this.gbRepresentative.Controls.Add(this.tbRepresentPost);
            this.gbRepresentative.Controls.Add(this.label9);
            this.gbRepresentative.Controls.Add(this.label10);
            this.gbRepresentative.Location = new System.Drawing.Point(6, 213);
            this.gbRepresentative.Name = "gbRepresentative";
            this.gbRepresentative.Size = new System.Drawing.Size(778, 44);
            this.gbRepresentative.TabIndex = 121;
            this.gbRepresentative.TabStop = false;
            this.gbRepresentative.Text = "Представитель потребителя";
            // 
            // tbRepresentFIO
            // 
            this.tbRepresentFIO.Location = new System.Drawing.Point(587, 16);
            this.tbRepresentFIO.Name = "tbRepresentFIO";
            this.tbRepresentFIO.Size = new System.Drawing.Size(185, 20);
            this.tbRepresentFIO.TabIndex = 115;
            // 
            // tbRepresentPost
            // 
            this.tbRepresentPost.Location = new System.Drawing.Point(87, 16);
            this.tbRepresentPost.Name = "tbRepresentPost";
            this.tbRepresentPost.Size = new System.Drawing.Size(407, 20);
            this.tbRepresentPost.TabIndex = 114;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 111;
            this.label9.Text = "Должность";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(500, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 110;
            this.label10.Text = "Фамилия И.О.";
            // 
            // gbOwner
            // 
            this.gbOwner.Controls.Add(this.cbOwnerFIO);
            this.gbOwner.Controls.Add(this.cbOwnerJobTitle);
            this.gbOwner.Controls.Add(this.lbOwnerJobTitle);
            this.gbOwner.Controls.Add(this.label5);
            this.gbOwner.Location = new System.Drawing.Point(6, 170);
            this.gbOwner.Name = "gbOwner";
            this.gbOwner.Size = new System.Drawing.Size(778, 44);
            this.gbOwner.TabIndex = 120;
            this.gbOwner.TabStop = false;
            this.gbOwner.Text = "Акт составлен";
            // 
            // cbOwnerFIO
            // 
            this.cbOwnerFIO.FormattingEnabled = true;
            this.cbOwnerFIO.Location = new System.Drawing.Point(587, 16);
            this.cbOwnerFIO.Name = "cbOwnerFIO";
            this.cbOwnerFIO.Size = new System.Drawing.Size(185, 21);
            this.cbOwnerFIO.TabIndex = 113;
            // 
            // bdsWorker1
            // 
            this.bdsWorker1.DataMember = "vP_Worker";
            this.bdsWorker1.DataSource = this.dsAbnObjAkt1;
            // 
            // cbOwnerJobTitle
            // 
            this.cbOwnerJobTitle.FormattingEnabled = true;
            this.cbOwnerJobTitle.Location = new System.Drawing.Point(87, 16);
            this.cbOwnerJobTitle.Name = "cbOwnerJobTitle";
            this.cbOwnerJobTitle.Size = new System.Drawing.Size(407, 21);
            this.cbOwnerJobTitle.TabIndex = 112;
            this.cbOwnerJobTitle.SelectedIndexChanged += new System.EventHandler(this.cbOwnerJobTitle_SelectedIndexChanged);
            // 
            // lbOwnerJobTitle
            // 
            this.lbOwnerJobTitle.AutoSize = true;
            this.lbOwnerJobTitle.Location = new System.Drawing.Point(16, 19);
            this.lbOwnerJobTitle.Name = "lbOwnerJobTitle";
            this.lbOwnerJobTitle.Size = new System.Drawing.Size(65, 13);
            this.lbOwnerJobTitle.TabIndex = 111;
            this.lbOwnerJobTitle.Text = "Должность";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Фамилия И.О.";
            // 
            // dtpActDate
            // 
            this.dtpActDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpActDate.Location = new System.Drawing.Point(607, 143);
            this.dtpActDate.Name = "dtpActDate";
            this.dtpActDate.Size = new System.Drawing.Size(144, 21);
            this.dtpActDate.TabIndex = 118;
            // 
            // tbActNumber
            // 
            this.tbActNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbActNumber.Location = new System.Drawing.Point(486, 143);
            this.tbActNumber.Name = "tbActNumber";
            this.tbActNumber.Size = new System.Drawing.Size(80, 21);
            this.tbActNumber.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(565, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 116;
            this.label4.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(463, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 115;
            this.label1.Text = "№";
            // 
            // gbTransI
            // 
            this.gbTransI.Controls.Add(this.dgvSealTransI);
            this.gbTransI.Controls.Add(this.cbTypeTransI);
            this.gbTransI.Controls.Add(this.tbNumTransI);
            this.gbTransI.Controls.Add(this.label15);
            this.gbTransI.Controls.Add(this.tsSealTransI);
            this.gbTransI.Controls.Add(this.tbRatioTransI);
            this.gbTransI.Controls.Add(this.label2);
            this.gbTransI.Controls.Add(this.tbNomTransIEnd);
            this.gbTransI.Controls.Add(this.tbNomTransIBeg);
            this.gbTransI.Controls.Add(this.lbTransIRatio);
            this.gbTransI.Controls.Add(this.lbNomTransI);
            this.gbTransI.Controls.Add(this.qybCalibrationTransI);
            this.gbTransI.Controls.Add(this.lbTypeTransI);
            this.gbTransI.Controls.Add(this.lbCalibrationTransI);
            this.gbTransI.Location = new System.Drawing.Point(268, 260);
            this.gbTransI.Name = "gbTransI";
            this.gbTransI.Size = new System.Drawing.Size(255, 293);
            this.gbTransI.TabIndex = 113;
            this.gbTransI.TabStop = false;
            this.gbTransI.Text = "Трансформатор тока";
            // 
            // dgvSealTransI
            // 
            this.dgvSealTransI.AllowUserToAddRows = false;
            this.dgvSealTransI.BackgroundColor = System.Drawing.Color.White;
            this.dgvSealTransI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSealTransI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransI,
            this.idWorkerTransI,
            this.NumberSealTransI,
            this.ActTransI,
            this.LocationSealTransI,
            this.CommentSealTransI});
            this.dgvSealTransI.Location = new System.Drawing.Point(6, 151);
            this.dgvSealTransI.Name = "dgvSealTransI";
            this.dgvSealTransI.RowHeadersVisible = false;
            this.dgvSealTransI.Size = new System.Drawing.Size(243, 109);
            this.dgvSealTransI.TabIndex = 119;
            // 
            // idTransI
            // 
            this.idTransI.DataPropertyName = "id";
            this.idTransI.HeaderText = "idSealTransI";
            this.idTransI.Name = "idTransI";
            this.idTransI.Visible = false;
            // 
            // idWorkerTransI
            // 
            this.idWorkerTransI.DataPropertyName = "idWorker";
            this.idWorkerTransI.HeaderText = "idWorker";
            this.idWorkerTransI.Name = "idWorkerTransI";
            this.idWorkerTransI.Visible = false;
            // 
            // NumberSealTransI
            // 
            this.NumberSealTransI.DataPropertyName = "Number";
            this.NumberSealTransI.HeaderText = "Номер";
            this.NumberSealTransI.Name = "NumberSealTransI";
            // 
            // ActTransI
            // 
            this.ActTransI.DataPropertyName = "Act";
            this.ActTransI.HeaderText = "Действие";
            this.ActTransI.Name = "ActTransI";
            this.ActTransI.Width = 80;
            // 
            // LocationSealTransI
            // 
            this.LocationSealTransI.DataPropertyName = "Location";
            this.LocationSealTransI.HeaderText = "Расположение";
            this.LocationSealTransI.Name = "LocationSealTransI";
            this.LocationSealTransI.Width = 140;
            // 
            // CommentSealTransI
            // 
            this.CommentSealTransI.DataPropertyName = "Comment";
            this.CommentSealTransI.HeaderText = "Коментарий";
            this.CommentSealTransI.Name = "CommentSealTransI";
            this.CommentSealTransI.Width = 150;
            // 
            // cbTypeTransI
            // 
            this.cbTypeTransI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTypeTransI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTypeTransI.DataSource = this.bsTransfI;
            this.cbTypeTransI.DisplayMember = "Name";
            this.cbTypeTransI.FormattingEnabled = true;
            this.cbTypeTransI.Location = new System.Drawing.Point(40, 46);
            this.cbTypeTransI.Name = "cbTypeTransI";
            this.cbTypeTransI.Size = new System.Drawing.Size(209, 21);
            this.cbTypeTransI.TabIndex = 118;
            this.cbTypeTransI.ValueMember = "idPointReg";
            // 
            // bsTransfI
            // 
            this.bsTransfI.DataMember = "vPointCheckTransFill";
            this.bsTransfI.DataSource = this.dsAbnObjAkt1;
            this.bsTransfI.Filter = "TypeTrans = 68";
            this.bsTransfI.CurrentChanged += new System.EventHandler(this.bsTransfI_CurrentChanged);
            // 
            // tbNumTransI
            // 
            this.tbNumTransI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbNumTransI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbNumTransI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTransfI, "Number", true));
            this.tbNumTransI.Location = new System.Drawing.Point(53, 18);
            this.tbNumTransI.Name = "tbNumTransI";
            this.tbNumTransI.Size = new System.Drawing.Size(196, 20);
            this.tbNumTransI.TabIndex = 117;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 116;
            this.label15.Text = "Номер";
            // 
            // tsSealTransI
            // 
            this.tsSealTransI.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSealTransI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSealTransIAdd,
            this.tsbSealTransIDelete});
            this.tsSealTransI.Location = new System.Drawing.Point(3, 265);
            this.tsSealTransI.Name = "tsSealTransI";
            this.tsSealTransI.Size = new System.Drawing.Size(249, 25);
            this.tsSealTransI.TabIndex = 115;
            this.tsSealTransI.Text = "toolStrip1";
            this.tsSealTransI.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsSealTransI_ItemClicked);
            // 
            // tsbSealTransIAdd
            // 
            this.tsbSealTransIAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSealTransIAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbSealTransIAdd.Image")));
            this.tsbSealTransIAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSealTransIAdd.Name = "tsbSealTransIAdd";
            this.tsbSealTransIAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbSealTransIAdd.Text = "Установка пломбы";
            this.tsbSealTransIAdd.Click += new System.EventHandler(this.tsbSealTransIAdd_Click);
            // 
            // tsbSealTransIDelete
            // 
            this.tsbSealTransIDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSealTransIDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbSealTransIDelete.Image")));
            this.tsbSealTransIDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSealTransIDelete.Name = "tsbSealTransIDelete";
            this.tsbSealTransIDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbSealTransIDelete.Text = "Демонтаж пломбы";
            this.tsbSealTransIDelete.Click += new System.EventHandler(this.tsbSealTransIDelete_Click);
            // 
            // tbRatioTransI
            // 
            this.tbRatioTransI.Location = new System.Drawing.Point(94, 98);
            this.tbRatioTransI.Name = "tbRatioTransI";
            this.tbRatioTransI.Size = new System.Drawing.Size(155, 20);
            this.tbRatioTransI.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "/";
            // 
            // tbNomTransIEnd
            // 
            this.tbNomTransIEnd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTransfI, "Secondary", true));
            this.tbNomTransIEnd.Location = new System.Drawing.Point(173, 72);
            this.tbNomTransIEnd.Name = "tbNomTransIEnd";
            this.tbNomTransIEnd.Size = new System.Drawing.Size(76, 20);
            this.tbNomTransIEnd.TabIndex = 29;
            // 
            // tbNomTransIBeg
            // 
            this.tbNomTransIBeg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTransfI, "Primary", true));
            this.tbNomTransIBeg.Location = new System.Drawing.Point(73, 72);
            this.tbNomTransIBeg.Name = "tbNomTransIBeg";
            this.tbNomTransIBeg.Size = new System.Drawing.Size(76, 20);
            this.tbNomTransIBeg.TabIndex = 28;
            // 
            // lbTransIRatio
            // 
            this.lbTransIRatio.AutoSize = true;
            this.lbTransIRatio.Location = new System.Drawing.Point(8, 101);
            this.lbTransIRatio.Name = "lbTransIRatio";
            this.lbTransIRatio.Size = new System.Drawing.Size(80, 13);
            this.lbTransIRatio.TabIndex = 27;
            this.lbTransIRatio.Text = "Коэф. трансф.";
            // 
            // lbNomTransI
            // 
            this.lbNomTransI.AutoSize = true;
            this.lbNomTransI.Location = new System.Drawing.Point(8, 75);
            this.lbNomTransI.Name = "lbNomTransI";
            this.lbNomTransI.Size = new System.Drawing.Size(53, 13);
            this.lbNomTransI.TabIndex = 26;
            this.lbNomTransI.Text = "Номинал";
            // 
            // qybCalibrationTransI
            // 
            this.qybCalibrationTransI.Location = new System.Drawing.Point(79, 120);
            this.qybCalibrationTransI.Name = "qybCalibrationTransI";
            this.qybCalibrationTransI.Size = new System.Drawing.Size(173, 25);
            this.qybCalibrationTransI.TabIndex = 21;
            // 
            // lbTypeTransI
            // 
            this.lbTypeTransI.AutoSize = true;
            this.lbTypeTransI.Location = new System.Drawing.Point(8, 49);
            this.lbTypeTransI.Name = "lbTypeTransI";
            this.lbTypeTransI.Size = new System.Drawing.Size(26, 13);
            this.lbTypeTransI.TabIndex = 13;
            this.lbTypeTransI.Text = "Тип";
            // 
            // lbCalibrationTransI
            // 
            this.lbCalibrationTransI.AutoSize = true;
            this.lbCalibrationTransI.Location = new System.Drawing.Point(6, 126);
            this.lbCalibrationTransI.Name = "lbCalibrationTransI";
            this.lbCalibrationTransI.Size = new System.Drawing.Size(67, 13);
            this.lbCalibrationTransI.TabIndex = 18;
            this.lbCalibrationTransI.Text = "Госповерка";
            // 
            // gbMeter
            // 
            this.gbMeter.Controls.Add(this.dgvZoneIndicator);
            this.gbMeter.Controls.Add(this.qybCalibrationMeter);
            this.gbMeter.Controls.Add(this.cbTypeMeter);
            this.gbMeter.Controls.Add(this.cbNumMeter);
            this.gbMeter.Controls.Add(this.tsSealMeter);
            this.gbMeter.Controls.Add(this.dgvSealMeter);
            this.gbMeter.Controls.Add(this.tbCapasityMeter);
            this.gbMeter.Controls.Add(this.lbCapacityMeter);
            this.gbMeter.Controls.Add(this.lbCalibrationMeter);
            this.gbMeter.Controls.Add(this.lbTypeMeter);
            this.gbMeter.Controls.Add(this.label3);
            this.gbMeter.Controls.Add(this.lbNumMeter);
            this.gbMeter.Location = new System.Drawing.Point(6, 261);
            this.gbMeter.Name = "gbMeter";
            this.gbMeter.Size = new System.Drawing.Size(255, 292);
            this.gbMeter.TabIndex = 112;
            this.gbMeter.TabStop = false;
            this.gbMeter.Text = "Эл. счетчик";
            // 
            // dgvZoneIndicator
            // 
            this.dgvZoneIndicator.AllowUserToAddRows = false;
            this.dgvZoneIndicator.AllowUserToDeleteRows = false;
            this.dgvZoneIndicator.AutoGenerateColumns = false;
            this.dgvZoneIndicator.ColumnHeadersHeight = 21;
            this.dgvZoneIndicator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvZoneIndicator.ColumnHeadersVisible = false;
            this.dgvZoneIndicator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idZobeNameDataGridViewTextBoxColumn,
            this.idSubZoneNameDataGridViewTextBoxColumn,
            this.timeBeginDataGridViewTextBoxColumn,
            this.timeEndDataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.zoneNameDataGridViewTextBoxColumn,
            this.subZoneNameDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.valueBegin,
            this.valueEndDataGridViewTextBoxColumn});
            this.dgvZoneIndicator.DataSource = this.bsZoneValue;
            this.dgvZoneIndicator.Location = new System.Drawing.Point(9, 111);
            this.dgvZoneIndicator.Name = "dgvZoneIndicator";
            this.dgvZoneIndicator.RowHeadersWidth = 5;
            this.dgvZoneIndicator.Size = new System.Drawing.Size(240, 44);
            this.dgvZoneIndicator.TabIndex = 121;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idZobeNameDataGridViewTextBoxColumn
            // 
            this.idZobeNameDataGridViewTextBoxColumn.DataPropertyName = "IdZobeName";
            this.idZobeNameDataGridViewTextBoxColumn.HeaderText = "IdZobeName";
            this.idZobeNameDataGridViewTextBoxColumn.Name = "idZobeNameDataGridViewTextBoxColumn";
            this.idZobeNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // idSubZoneNameDataGridViewTextBoxColumn
            // 
            this.idSubZoneNameDataGridViewTextBoxColumn.DataPropertyName = "IdSubZoneName";
            this.idSubZoneNameDataGridViewTextBoxColumn.HeaderText = "IdSubZoneName";
            this.idSubZoneNameDataGridViewTextBoxColumn.Name = "idSubZoneNameDataGridViewTextBoxColumn";
            this.idSubZoneNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // timeBeginDataGridViewTextBoxColumn
            // 
            this.timeBeginDataGridViewTextBoxColumn.DataPropertyName = "TimeBegin";
            this.timeBeginDataGridViewTextBoxColumn.HeaderText = "TimeBegin";
            this.timeBeginDataGridViewTextBoxColumn.Name = "timeBeginDataGridViewTextBoxColumn";
            this.timeBeginDataGridViewTextBoxColumn.Visible = false;
            // 
            // timeEndDataGridViewTextBoxColumn
            // 
            this.timeEndDataGridViewTextBoxColumn.DataPropertyName = "TimeEnd";
            this.timeEndDataGridViewTextBoxColumn.HeaderText = "TimeEnd";
            this.timeEndDataGridViewTextBoxColumn.Name = "timeEndDataGridViewTextBoxColumn";
            this.timeEndDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateBeginDataGridViewTextBoxColumn
            // 
            this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn.HeaderText = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
            this.dateBeginDataGridViewTextBoxColumn.Visible = false;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Visible = false;
            // 
            // zoneNameDataGridViewTextBoxColumn
            // 
            this.zoneNameDataGridViewTextBoxColumn.DataPropertyName = "ZoneName";
            this.zoneNameDataGridViewTextBoxColumn.HeaderText = "ZoneName";
            this.zoneNameDataGridViewTextBoxColumn.Name = "zoneNameDataGridViewTextBoxColumn";
            this.zoneNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // subZoneNameDataGridViewTextBoxColumn
            // 
            this.subZoneNameDataGridViewTextBoxColumn.DataPropertyName = "SubZoneName";
            this.subZoneNameDataGridViewTextBoxColumn.HeaderText = "SubZoneName";
            this.subZoneNameDataGridViewTextBoxColumn.Name = "subZoneNameDataGridViewTextBoxColumn";
            this.subZoneNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Visible = false;
            // 
            // valueBegin
            // 
            this.valueBegin.DataPropertyName = "ValueBegin";
            this.valueBegin.HeaderText = "ValueBegin";
            this.valueBegin.Name = "valueBegin";
            this.valueBegin.Width = 60;
            // 
            // valueEndDataGridViewTextBoxColumn
            // 
            this.valueEndDataGridViewTextBoxColumn.DataPropertyName = "ValueEnd";
            this.valueEndDataGridViewTextBoxColumn.HeaderText = "ValueEnd";
            this.valueEndDataGridViewTextBoxColumn.Name = "valueEndDataGridViewTextBoxColumn";
            this.valueEndDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsZoneValue
            // 
            this.bsZoneValue.DataMember = "vr_Zone";
            this.bsZoneValue.DataSource = this.dsZone;
            // 
            // dsZone
            // 
            this.dsZone.DataSetName = "NewDataSet";
            this.dsZone.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTableVr_Zone});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable1.TableName = "tr_Classifier";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            this.dataColumn1.DataType = typeof(short);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Name";
            // 
            // dataTableVr_Zone
            // 
            this.dataTableVr_Zone.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14});
            this.dataTableVr_Zone.TableName = "vr_Zone";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Id";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "IdZobeName";
            this.dataColumn4.DataType = typeof(int);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "IdSubZoneName";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "TimeBegin";
            this.dataColumn6.DataType = typeof(System.DateTime);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "TimeEnd";
            this.dataColumn7.DataType = typeof(System.DateTime);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "DateBegin";
            this.dataColumn8.DataType = typeof(System.DateTime);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Comment";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "ZoneName";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "SubZoneName";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "Time";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "ValueBegin";
            this.dataColumn13.DataType = typeof(int);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "ValueEnd";
            this.dataColumn14.DataType = typeof(int);
            // 
            // qybCalibrationMeter
            // 
            this.qybCalibrationMeter.Location = new System.Drawing.Point(79, 156);
            this.qybCalibrationMeter.Name = "qybCalibrationMeter";
            this.qybCalibrationMeter.Size = new System.Drawing.Size(170, 25);
            this.qybCalibrationMeter.TabIndex = 120;
            // 
            // cbTypeMeter
            // 
            this.cbTypeMeter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTypeMeter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTypeMeter.FormattingEnabled = true;
            this.cbTypeMeter.Location = new System.Drawing.Point(38, 44);
            this.cbTypeMeter.Name = "cbTypeMeter";
            this.cbTypeMeter.Size = new System.Drawing.Size(211, 21);
            this.cbTypeMeter.TabIndex = 119;
            this.cbTypeMeter.SelectedIndexChanged += new System.EventHandler(this.cbTypeMeter_TextChanged);
            // 
            // cbNumMeter
            // 
            this.cbNumMeter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNumMeter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNumMeter.FormattingEnabled = true;
            this.cbNumMeter.Location = new System.Drawing.Point(53, 18);
            this.cbNumMeter.Name = "cbNumMeter";
            this.cbNumMeter.Size = new System.Drawing.Size(196, 21);
            this.cbNumMeter.TabIndex = 118;
            this.cbNumMeter.SelectedIndexChanged += new System.EventHandler(this.cbNumMeter_TextChanged);
            this.cbNumMeter.Leave += new System.EventHandler(this.cbNumMeter_Leave);
            // 
            // tsSealMeter
            // 
            this.tsSealMeter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsSealMeter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSealMeterAdd,
            this.tsbSealMeterDelete});
            this.tsSealMeter.Location = new System.Drawing.Point(3, 264);
            this.tsSealMeter.Name = "tsSealMeter";
            this.tsSealMeter.Size = new System.Drawing.Size(249, 25);
            this.tsSealMeter.TabIndex = 116;
            this.tsSealMeter.Text = "toolStrip3";
            // 
            // tsbSealMeterAdd
            // 
            this.tsbSealMeterAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSealMeterAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbSealMeterAdd.Image")));
            this.tsbSealMeterAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSealMeterAdd.Name = "tsbSealMeterAdd";
            this.tsbSealMeterAdd.Size = new System.Drawing.Size(23, 22);
            this.tsbSealMeterAdd.Text = "Установка пломбы";
            this.tsbSealMeterAdd.Click += new System.EventHandler(this.tsbSealMeterAdd_Click);
            // 
            // tsbSealMeterDelete
            // 
            this.tsbSealMeterDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSealMeterDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbSealMeterDelete.Image")));
            this.tsbSealMeterDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSealMeterDelete.Name = "tsbSealMeterDelete";
            this.tsbSealMeterDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbSealMeterDelete.Text = "Демонтаж пломбы";
            this.tsbSealMeterDelete.Click += new System.EventHandler(this.tsbSealMeterDelete_Click);
            // 
            // dgvSealMeter
            // 
            this.dgvSealMeter.AllowUserToAddRows = false;
            this.dgvSealMeter.BackgroundColor = System.Drawing.Color.White;
            this.dgvSealMeter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSealMeter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMeter,
            this.idWorkerMeter,
            this.NumberSealMeter,
            this.ActMeter,
            this.LocationSealMeter,
            this.CommentSealMeter});
            this.dgvSealMeter.Location = new System.Drawing.Point(6, 183);
            this.dgvSealMeter.Name = "dgvSealMeter";
            this.dgvSealMeter.RowHeadersVisible = false;
            this.dgvSealMeter.Size = new System.Drawing.Size(243, 77);
            this.dgvSealMeter.TabIndex = 113;
            // 
            // idMeter
            // 
            this.idMeter.DataPropertyName = "id";
            this.idMeter.HeaderText = "idMeter";
            this.idMeter.Name = "idMeter";
            this.idMeter.Visible = false;
            // 
            // idWorkerMeter
            // 
            this.idWorkerMeter.DataPropertyName = "idWorker";
            this.idWorkerMeter.HeaderText = "idWorker";
            this.idWorkerMeter.Name = "idWorkerMeter";
            this.idWorkerMeter.Visible = false;
            // 
            // NumberSealMeter
            // 
            this.NumberSealMeter.DataPropertyName = "Number";
            this.NumberSealMeter.HeaderText = "Номер";
            this.NumberSealMeter.Name = "NumberSealMeter";
            // 
            // ActMeter
            // 
            this.ActMeter.DataPropertyName = "Act";
            this.ActMeter.HeaderText = "Действие";
            this.ActMeter.Name = "ActMeter";
            this.ActMeter.Width = 80;
            // 
            // LocationSealMeter
            // 
            this.LocationSealMeter.DataPropertyName = "Location";
            this.LocationSealMeter.HeaderText = "Расположение";
            this.LocationSealMeter.Name = "LocationSealMeter";
            this.LocationSealMeter.Width = 140;
            // 
            // CommentSealMeter
            // 
            this.CommentSealMeter.DataPropertyName = "Comment";
            this.CommentSealMeter.HeaderText = "Коментарий";
            this.CommentSealMeter.Name = "CommentSealMeter";
            this.CommentSealMeter.Width = 150;
            // 
            // tbCapasityMeter
            // 
            this.tbCapasityMeter.Location = new System.Drawing.Point(85, 71);
            this.tbCapasityMeter.Name = "tbCapasityMeter";
            this.tbCapasityMeter.Size = new System.Drawing.Size(164, 20);
            this.tbCapasityMeter.TabIndex = 27;
            // 
            // lbCapacityMeter
            // 
            this.lbCapacityMeter.AutoSize = true;
            this.lbCapacityMeter.Location = new System.Drawing.Point(6, 74);
            this.lbCapacityMeter.Name = "lbCapacityMeter";
            this.lbCapacityMeter.Size = new System.Drawing.Size(73, 13);
            this.lbCapacityMeter.TabIndex = 26;
            this.lbCapacityMeter.Text = "Разрядность";
            // 
            // lbCalibrationMeter
            // 
            this.lbCalibrationMeter.AutoSize = true;
            this.lbCalibrationMeter.Location = new System.Drawing.Point(3, 162);
            this.lbCalibrationMeter.Name = "lbCalibrationMeter";
            this.lbCalibrationMeter.Size = new System.Drawing.Size(67, 13);
            this.lbCalibrationMeter.TabIndex = 22;
            this.lbCalibrationMeter.Text = "Госповерка";
            // 
            // lbTypeMeter
            // 
            this.lbTypeMeter.AutoSize = true;
            this.lbTypeMeter.Location = new System.Drawing.Point(6, 48);
            this.lbTypeMeter.Name = "lbTypeMeter";
            this.lbTypeMeter.Size = new System.Drawing.Size(26, 13);
            this.lbTypeMeter.TabIndex = 0;
            this.lbTypeMeter.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Текущие показания";
            // 
            // lbNumMeter
            // 
            this.lbNumMeter.AutoSize = true;
            this.lbNumMeter.Location = new System.Drawing.Point(6, 21);
            this.lbNumMeter.Name = "lbNumMeter";
            this.lbNumMeter.Size = new System.Drawing.Size(41, 13);
            this.lbNumMeter.TabIndex = 2;
            this.lbNumMeter.Text = "Номер";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvStrikeRreveal);
            this.tabPage2.Controls.Add(this.dgvMalfunction);
            this.tabPage2.Controls.Add(this.tbFactConsuptionNote);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.tbPrincipSchemeNote);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dtpStrikeRrevealDate);
            this.tabPage2.Controls.Add(this.cbFactConsuption);
            this.tabPage2.Controls.Add(this.cbPrincipScheme);
            this.tabPage2.Controls.Add(this.tbStrikeRrevealNote);
            this.tabPage2.Controls.Add(this.gbCheckLoad);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.tbMalfunctionNote);
            this.tabPage2.Controls.Add(this.cbConformityRate);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.tbConformityRateNote);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выявлено в результате осмотра";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvStrikeRreveal
            // 
            this.dgvStrikeRreveal.AllowUserToAddRows = false;
            this.dgvStrikeRreveal.AllowUserToDeleteRows = false;
            this.dgvStrikeRreveal.AutoGenerateColumns = false;
            this.dgvStrikeRreveal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStrikeRreveal.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStrikeRreveal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStrikeRreveal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrikeRreveal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.commentDataGridViewTextBoxColumn1,
            this.idParentDataGridViewTextBoxColumn1,
            this.isGroupDataGridViewCheckBoxColumn1,
            this.deletedDataGridViewCheckBoxColumn1,
            this.StrikeRevealValue});
            this.dgvStrikeRreveal.DataSource = this.bsActClassifierStrikeReveal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStrikeRreveal.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStrikeRreveal.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvStrikeRreveal.Location = new System.Drawing.Point(400, 273);
            this.dgvStrikeRreveal.Name = "dgvStrikeRreveal";
            this.dgvStrikeRreveal.RowHeadersVisible = false;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStrikeRreveal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStrikeRreveal.Size = new System.Drawing.Size(387, 233);
            this.dgvStrikeRreveal.TabIndex = 117;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Перечень предписаний";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 330;
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn1.HeaderText = "Comment";
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            this.commentDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idParentDataGridViewTextBoxColumn1
            // 
            this.idParentDataGridViewTextBoxColumn1.DataPropertyName = "idParent";
            this.idParentDataGridViewTextBoxColumn1.HeaderText = "idParent";
            this.idParentDataGridViewTextBoxColumn1.Name = "idParentDataGridViewTextBoxColumn1";
            this.idParentDataGridViewTextBoxColumn1.Visible = false;
            // 
            // isGroupDataGridViewCheckBoxColumn1
            // 
            this.isGroupDataGridViewCheckBoxColumn1.DataPropertyName = "isGroup";
            this.isGroupDataGridViewCheckBoxColumn1.HeaderText = "isGroup";
            this.isGroupDataGridViewCheckBoxColumn1.Name = "isGroupDataGridViewCheckBoxColumn1";
            this.isGroupDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // deletedDataGridViewCheckBoxColumn1
            // 
            this.deletedDataGridViewCheckBoxColumn1.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn1.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn1.Name = "deletedDataGridViewCheckBoxColumn1";
            this.deletedDataGridViewCheckBoxColumn1.Visible = false;
            // 
            // StrikeRevealValue
            // 
            this.StrikeRevealValue.DataPropertyName = "StrikeRevealValue";
            this.StrikeRevealValue.HeaderText = "";
            this.StrikeRevealValue.Name = "StrikeRevealValue";
            this.StrikeRevealValue.Width = 40;
            // 
            // bsActClassifierStrikeReveal
            // 
            this.bsActClassifierStrikeReveal.DataMember = "tR_ActClassifierStrikeReveal";
            this.bsActClassifierStrikeReveal.DataSource = this.dsAbnObjAkt1;
            // 
            // dgvMalfunction
            // 
            this.dgvMalfunction.AllowUserToAddRows = false;
            this.dgvMalfunction.AutoGenerateColumns = false;
            this.dgvMalfunction.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMalfunction.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMalfunction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMalfunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMalfunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.idParentDataGridViewTextBoxColumn,
            this.isGroupDataGridViewCheckBoxColumn,
            this.deletedDataGridViewCheckBoxColumn,
            this.MalfunctionValue});
            this.dgvMalfunction.DataSource = this.bsActClassifierMalfunction;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMalfunction.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMalfunction.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMalfunction.Location = new System.Drawing.Point(2, 253);
            this.dgvMalfunction.Name = "dgvMalfunction";
            this.dgvMalfunction.RowHeadersVisible = false;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMalfunction.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMalfunction.Size = new System.Drawing.Size(392, 253);
            this.dgvMalfunction.TabIndex = 116;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Перечень нарушений";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 330;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn2.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // idParentDataGridViewTextBoxColumn
            // 
            this.idParentDataGridViewTextBoxColumn.DataPropertyName = "idParent";
            this.idParentDataGridViewTextBoxColumn.HeaderText = "idParent";
            this.idParentDataGridViewTextBoxColumn.Name = "idParentDataGridViewTextBoxColumn";
            this.idParentDataGridViewTextBoxColumn.Visible = false;
            // 
            // isGroupDataGridViewCheckBoxColumn
            // 
            this.isGroupDataGridViewCheckBoxColumn.DataPropertyName = "isGroup";
            this.isGroupDataGridViewCheckBoxColumn.HeaderText = "isGroup";
            this.isGroupDataGridViewCheckBoxColumn.Name = "isGroupDataGridViewCheckBoxColumn";
            this.isGroupDataGridViewCheckBoxColumn.Visible = false;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // MalfunctionValue
            // 
            this.MalfunctionValue.DataPropertyName = "MalfunctionValue";
            this.MalfunctionValue.HeaderText = "";
            this.MalfunctionValue.Name = "MalfunctionValue";
            this.MalfunctionValue.Width = 40;
            // 
            // bsActClassifierMalfunction
            // 
            this.bsActClassifierMalfunction.DataMember = "tR_ActClassifierMalfunction";
            this.bsActClassifierMalfunction.DataSource = this.dsAbnObjAkt1;
            // 
            // tbFactConsuptionNote
            // 
            this.tbFactConsuptionNote.Location = new System.Drawing.Point(6, 207);
            this.tbFactConsuptionNote.Multiline = true;
            this.tbFactConsuptionNote.Name = "tbFactConsuptionNote";
            this.tbFactConsuptionNote.Size = new System.Drawing.Size(781, 40);
            this.tbFactConsuptionNote.TabIndex = 115;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(400, 257);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(143, 13);
            this.label35.TabIndex = 110;
            this.label35.Text = "Устранить недостатки до: ";
            // 
            // tbPrincipSchemeNote
            // 
            this.tbPrincipSchemeNote.Location = new System.Drawing.Point(6, 141);
            this.tbPrincipSchemeNote.Multiline = true;
            this.tbPrincipSchemeNote.Name = "tbPrincipSchemeNote";
            this.tbPrincipSchemeNote.Size = new System.Drawing.Size(781, 40);
            this.tbPrincipSchemeNote.TabIndex = 114;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 186);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(277, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Факт безучетного потребления имеется/не имеется";
            // 
            // dtpStrikeRrevealDate
            // 
            this.dtpStrikeRrevealDate.Location = new System.Drawing.Point(549, 254);
            this.dtpStrikeRrevealDate.Name = "dtpStrikeRrevealDate";
            this.dtpStrikeRrevealDate.Size = new System.Drawing.Size(139, 20);
            this.dtpStrikeRrevealDate.TabIndex = 109;
            // 
            // cbFactConsuption
            // 
            this.cbFactConsuption.FormattingEnabled = true;
            this.cbFactConsuption.Items.AddRange(new object[] {
            "имеется",
            "не имеется"});
            this.cbFactConsuption.Location = new System.Drawing.Point(289, 183);
            this.cbFactConsuption.Name = "cbFactConsuption";
            this.cbFactConsuption.Size = new System.Drawing.Size(121, 21);
            this.cbFactConsuption.TabIndex = 113;
            // 
            // cbPrincipScheme
            // 
            this.cbPrincipScheme.FormattingEnabled = true;
            this.cbPrincipScheme.Items.AddRange(new object[] {
            "верна",
            "не верна"});
            this.cbPrincipScheme.Location = new System.Drawing.Point(267, 117);
            this.cbPrincipScheme.Name = "cbPrincipScheme";
            this.cbPrincipScheme.Size = new System.Drawing.Size(121, 21);
            this.cbPrincipScheme.TabIndex = 112;
            // 
            // tbStrikeRrevealNote
            // 
            this.tbStrikeRrevealNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStrikeRrevealNote.Location = new System.Drawing.Point(399, 512);
            this.tbStrikeRrevealNote.Multiline = true;
            this.tbStrikeRrevealNote.Name = "tbStrikeRrevealNote";
            this.tbStrikeRrevealNote.Size = new System.Drawing.Size(388, 41);
            this.tbStrikeRrevealNote.TabIndex = 108;
            // 
            // gbCheckLoad
            // 
            this.gbCheckLoad.Controls.Add(this.lt);
            this.gbCheckLoad.Controls.Add(this.nudP);
            this.gbCheckLoad.Controls.Add(this.label36);
            this.gbCheckLoad.Controls.Add(this.nudCos);
            this.gbCheckLoad.Controls.Add(this.label37);
            this.gbCheckLoad.Controls.Add(this.nudS);
            this.gbCheckLoad.Controls.Add(this.nudSec);
            this.gbCheckLoad.Controls.Add(this.label22);
            this.gbCheckLoad.Controls.Add(this.nudTime);
            this.gbCheckLoad.Controls.Add(this.nudFc);
            this.gbCheckLoad.Controls.Add(this.label23);
            this.gbCheckLoad.Controls.Add(this.nudFb);
            this.gbCheckLoad.Controls.Add(this.nudFa);
            this.gbCheckLoad.Controls.Add(this.label24);
            this.gbCheckLoad.Controls.Add(this.label25);
            this.gbCheckLoad.Controls.Add(this.label27);
            this.gbCheckLoad.Controls.Add(this.label28);
            this.gbCheckLoad.Controls.Add(this.label29);
            this.gbCheckLoad.Controls.Add(this.label30);
            this.gbCheckLoad.Controls.Add(this.label31);
            this.gbCheckLoad.Controls.Add(this.label32);
            this.gbCheckLoad.Controls.Add(this.label33);
            this.gbCheckLoad.Controls.Add(this.label34);
            this.gbCheckLoad.Location = new System.Drawing.Point(6, 6);
            this.gbCheckLoad.Name = "gbCheckLoad";
            this.gbCheckLoad.Size = new System.Drawing.Size(781, 43);
            this.gbCheckLoad.TabIndex = 107;
            this.gbCheckLoad.TabStop = false;
            this.gbCheckLoad.Text = "Фактическая нагрузка на момент проверки";
            // 
            // lt
            // 
            this.lt.AutoSize = true;
            this.lt.Location = new System.Drawing.Point(391, 17);
            this.lt.Name = "lt";
            this.lt.Size = new System.Drawing.Size(16, 13);
            this.lt.TabIndex = 125;
            this.lt.Text = "t=";
            // 
            // nudP
            // 
            this.nudP.DecimalPlaces = 2;
            this.nudP.Location = new System.Drawing.Point(703, 15);
            this.nudP.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudP.Name = "nudP";
            this.nudP.Size = new System.Drawing.Size(50, 20);
            this.nudP.TabIndex = 124;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(681, 17);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 13);
            this.label36.TabIndex = 27;
            this.label36.Text = "P =";
            // 
            // nudCos
            // 
            this.nudCos.DecimalPlaces = 2;
            this.nudCos.Location = new System.Drawing.Point(622, 15);
            this.nudCos.Name = "nudCos";
            this.nudCos.Size = new System.Drawing.Size(50, 20);
            this.nudCos.TabIndex = 123;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(752, 17);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(25, 13);
            this.label37.TabIndex = 25;
            this.label37.Text = "кВт";
            // 
            // nudS
            // 
            this.nudS.DecimalPlaces = 2;
            this.nudS.Location = new System.Drawing.Point(499, 15);
            this.nudS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudS.Name = "nudS";
            this.nudS.Size = new System.Drawing.Size(50, 20);
            this.nudS.TabIndex = 122;
            // 
            // nudSec
            // 
            this.nudSec.DecimalPlaces = 2;
            this.nudSec.Location = new System.Drawing.Point(410, 15);
            this.nudSec.Name = "nudSec";
            this.nudSec.Size = new System.Drawing.Size(50, 20);
            this.nudSec.TabIndex = 121;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(460, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 13);
            this.label22.TabIndex = 22;
            this.label22.Text = "с.";
            // 
            // nudTime
            // 
            this.nudTime.DecimalPlaces = 2;
            this.nudTime.Location = new System.Drawing.Point(296, 15);
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(50, 20);
            this.nudTime.TabIndex = 120;
            // 
            // nudFc
            // 
            this.nudFc.DecimalPlaces = 2;
            this.nudFc.Location = new System.Drawing.Point(199, 15);
            this.nudFc.Name = "nudFc";
            this.nudFc.Size = new System.Drawing.Size(50, 20);
            this.nudFc.TabIndex = 119;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(345, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 13);
            this.label23.TabIndex = 21;
            this.label23.Text = "об/имп";
            // 
            // nudFb
            // 
            this.nudFb.DecimalPlaces = 2;
            this.nudFb.Location = new System.Drawing.Point(112, 15);
            this.nudFb.Name = "nudFb";
            this.nudFb.Size = new System.Drawing.Size(50, 20);
            this.nudFb.TabIndex = 118;
            // 
            // nudFa
            // 
            this.nudFa.DecimalPlaces = 2;
            this.nudFa.Location = new System.Drawing.Point(23, 15);
            this.nudFa.Name = "nudFa";
            this.nudFa.Size = new System.Drawing.Size(50, 20);
            this.nudFa.TabIndex = 28;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(274, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(21, 13);
            this.label24.TabIndex = 20;
            this.label24.Text = "N=";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(579, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 13);
            this.label25.TabIndex = 19;
            this.label25.Text = "Cosφ =";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(478, 17);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 13);
            this.label27.TabIndex = 16;
            this.label27.Text = "S =";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(162, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(14, 13);
            this.label28.TabIndex = 15;
            this.label28.Text = "А";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(248, 17);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(14, 13);
            this.label29.TabIndex = 14;
            this.label29.Text = "А";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(72, 17);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(14, 13);
            this.label30.TabIndex = 13;
            this.label30.Text = "А";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(550, 17);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(27, 13);
            this.label31.TabIndex = 12;
            this.label31.Text = "кВА";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(88, 17);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(26, 13);
            this.label32.TabIndex = 4;
            this.label32.Text = "IВ =";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(178, 17);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(26, 13);
            this.label33.TabIndex = 2;
            this.label33.Text = "IС =";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(1, 17);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(26, 13);
            this.label34.TabIndex = 0;
            this.label34.Text = "IА =";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Схема включения прибора учета верна/не верна";
            // 
            // tbMalfunctionNote
            // 
            this.tbMalfunctionNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMalfunctionNote.Location = new System.Drawing.Point(6, 512);
            this.tbMalfunctionNote.Multiline = true;
            this.tbMalfunctionNote.Name = "tbMalfunctionNote";
            this.tbMalfunctionNote.Size = new System.Drawing.Size(388, 41);
            this.tbMalfunctionNote.TabIndex = 108;
            // 
            // cbConformityRate
            // 
            this.cbConformityRate.FormattingEnabled = true;
            this.cbConformityRate.Items.AddRange(new object[] {
            "соответствует",
            "не соответствует"});
            this.cbConformityRate.Location = new System.Drawing.Point(418, 51);
            this.cbConformityRate.Name = "cbConformityRate";
            this.cbConformityRate.Size = new System.Drawing.Size(121, 21);
            this.cbConformityRate.TabIndex = 111;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 54);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(409, 13);
            this.label21.TabIndex = 27;
            this.label21.Text = "Работа прибора учета соответствует/не соответствует проведенным замерам";
            // 
            // tbConformityRateNote
            // 
            this.tbConformityRateNote.Location = new System.Drawing.Point(6, 74);
            this.tbConformityRateNote.Multiline = true;
            this.tbConformityRateNote.Name = "tbConformityRateNote";
            this.tbConformityRateNote.Size = new System.Drawing.Size(781, 40);
            this.tbConformityRateNote.TabIndex = 108;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.btnOrderSave);
            this.tabPage3.Controls.Add(this.cmbOrder);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Распоряжение";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtInput);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.txtAuthor);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(18, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 205);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // dtInput
            // 
            this.dtInput.Enabled = false;
            this.dtInput.Location = new System.Drawing.Point(15, 148);
            this.dtInput.Name = "dtInput";
            this.dtInput.Size = new System.Drawing.Size(200, 20);
            this.dtInput.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Дата заполнения:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(15, 66);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(200, 20);
            this.txtAuthor.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(153, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Акт заполнил пользователь:";
            // 
            // btnOrderSave
            // 
            this.btnOrderSave.Location = new System.Drawing.Point(18, 330);
            this.btnOrderSave.Name = "btnOrderSave";
            this.btnOrderSave.Size = new System.Drawing.Size(75, 23);
            this.btnOrderSave.TabIndex = 6;
            this.btnOrderSave.Text = "Сохранить";
            this.btnOrderSave.UseVisualStyleBackColor = true;
            this.btnOrderSave.Click += new System.EventHandler(this.btnOrderSave_Click);
            // 
            // cmbOrder
            // 
            this.cmbOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbOrder.DataSource = this.bsOrder;
            this.cmbOrder.DisplayMember = "NumberJournal";
            this.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(18, 284);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(200, 21);
            this.cmbOrder.TabIndex = 5;
            this.cmbOrder.ValueMember = "idOrder";
            // 
            // bsOrder
            // 
            this.bsOrder.DataMember = "vG_ActOrder";
            this.bsOrder.DataSource = this.dsAbnObjAkt1;
            this.bsOrder.CurrentChanged += new System.EventHandler(this.bsOrder_CurrentChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 247);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(175, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Распоряжение на обследование:";
            // 
            // FormDocAct_CheckAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "FormDocAct_CheckAdd";
            this.Text = "Добавление приборов учета электрической энергии";
            this.Shown += new System.EventHandler(this.FormDocAct_CheckAdd_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsActType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            this.panelPoint.ResumeLayout(false);
            this.panelPoint.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gbPointRegCheck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPointRegCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPointReg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSealTransU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransfU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnObjAkt1)).EndInit();
            this.tsSealTransU.ResumeLayout(false);
            this.tsSealTransU.PerformLayout();
            this.gbRepresentative.ResumeLayout(false);
            this.gbRepresentative.PerformLayout();
            this.gbOwner.ResumeLayout(false);
            this.gbOwner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsWorker1)).EndInit();
            this.gbTransI.ResumeLayout(false);
            this.gbTransI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSealTransI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransfI)).EndInit();
            this.tsSealTransI.ResumeLayout(false);
            this.tsSealTransI.PerformLayout();
            this.gbMeter.ResumeLayout(false);
            this.gbMeter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZoneIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsZoneValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVr_Zone)).EndInit();
            this.tsSealMeter.ResumeLayout(false);
            this.tsSealMeter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSealMeter)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrikeRreveal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActClassifierStrikeReveal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalfunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsActClassifierMalfunction)).EndInit();
            this.gbCheckLoad.ResumeLayout(false);
            this.gbCheckLoad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFa)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbRepresentative;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbOwner;
        private System.Windows.Forms.ComboBox cbOwnerFIO;
        private System.Windows.Forms.ComboBox cbOwnerJobTitle;
        private System.Windows.Forms.Label lbOwnerJobTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbTransI;
        private System.Windows.Forms.TextBox tbRatioTransI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNomTransIEnd;
        private System.Windows.Forms.TextBox tbNomTransIBeg;
        private System.Windows.Forms.Label lbTransIRatio;
        private System.Windows.Forms.Label lbNomTransI;
        private ControlsLbr.QuarterYearBox qybCalibrationTransI;
        private System.Windows.Forms.Label lbTypeTransI;
        private System.Windows.Forms.Label lbCalibrationTransI;
        private System.Windows.Forms.GroupBox gbMeter;
        private System.Windows.Forms.TextBox tbCapasityMeter;
        private System.Windows.Forms.Label lbCapacityMeter;
        private System.Windows.Forms.Label lbCalibrationMeter;
        private System.Windows.Forms.Label lbTypeMeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNumMeter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.DateTimePicker dtpStrikeRrevealDate;
        private System.Windows.Forms.TextBox tbMalfunctionNote;
        private System.Windows.Forms.TextBox tbStrikeRrevealNote;
        private System.Windows.Forms.TextBox tbFactConsuptionNote;
        private System.Windows.Forms.TextBox tbPrincipSchemeNote;
        private System.Windows.Forms.ComboBox cbFactConsuption;
        private System.Windows.Forms.ComboBox cbPrincipScheme;
        private System.Windows.Forms.ComboBox cbConformityRate;
        private System.Windows.Forms.TextBox tbConformityRateNote;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox gbCheckLoad;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRatioTransU;
        private System.Windows.Forms.Label label7;
        private ControlsLbr.QuarterYearBox qybCalibrationTransU;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvSealMeter;
        private System.Windows.Forms.ToolStrip tsSealTransU;
        private System.Windows.Forms.ToolStrip tsSealTransI;
        private System.Windows.Forms.ToolStrip tsSealMeter;
        private System.Windows.Forms.TextBox tbNumTransU;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNomTransUEnd;
        private System.Windows.Forms.TextBox tbNomTransUBeg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNumTransI;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbRepresentFIO;
        private System.Windows.Forms.TextBox tbRepresentPost;
        private System.Windows.Forms.ComboBox cbNumMeter;
        private System.Windows.Forms.ComboBox cbTypeTransU;
        private System.Windows.Forms.ComboBox cbTypeTransI;
        private System.Windows.Forms.ComboBox cbTypeMeter;
        private ControlsLbr.QuarterYearBox qybCalibrationMeter;
        private System.Windows.Forms.ToolStripButton tsbSealTransIAdd;
        private System.Windows.Forms.ToolStripButton tsbSealTransUAdd;
        private System.Windows.Forms.ToolStripButton tsbSealTransUDelete;
        private System.Windows.Forms.ToolStripButton tsbSealMeterAdd;
        private System.Windows.Forms.ToolStripButton tsbSealMeterDelete;
        private System.Windows.Forms.ToolStripButton tsbSealTransIDelete;
        private System.Windows.Forms.DataGridView dgvSealTransU;
        private System.Windows.Forms.DataGridView dgvSealTransI;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransU;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerTransU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberTransU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActTransU;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationTransU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentTransU;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransI;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerTransI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberSealTransI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActTransI;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationSealTransI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentSealTransI;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberSealMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationSealMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn CommentSealMeter;
        private System.Windows.Forms.GroupBox gbPointRegCheck;
        private System.Windows.Forms.DataGridView dgvPointRegCheck;
        private DataSet.DataSetAbn dsAbn;
        private System.Windows.Forms.BindingSource bsPointReg;
        private System.Windows.Forms.DateTimePicker dtpActDate;
        private System.Windows.Forms.TextBox tbActNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPoint;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbEditPoint;
        private System.Windows.Forms.ComboBox cbActType;
        private System.Windows.Forms.BindingSource bsActType;
        private System.Data.DataSet dsZone;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataTable dataTableVr_Zone;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Windows.Forms.DataGridView dgvZoneIndicator;
        private System.Windows.Forms.BindingSource bsActClassifierMalfunction;
        private System.Windows.Forms.BindingSource bsActClassifierStrikeReveal;
        //перед редактированием формы раскомментировать
        //private DataSet.dsAbnObjAct dsAbnObjAkt1;

        private System.Windows.Forms.DataGridView dgvMalfunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isGroupDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MalfunctionValue;
        private System.Windows.Forms.DataGridView dgvStrikeRreveal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isGroupDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StrikeRevealValue;
        private System.Windows.Forms.BindingSource bsZoneValue;
        private System.Windows.Forms.NumericUpDown nudFa;
        private System.Windows.Forms.NumericUpDown nudP;
        private System.Windows.Forms.NumericUpDown nudCos;
        private System.Windows.Forms.NumericUpDown nudS;
        private System.Windows.Forms.NumericUpDown nudSec;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.NumericUpDown nudFc;
        private System.Windows.Forms.NumericUpDown nudFb;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZobeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubZoneNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subZoneNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lt;
        private System.Windows.Forms.BindingSource bsTransfI;
        private System.Windows.Forms.BindingSource bsTransfU;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namePointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberTIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameTUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMPR;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTUPR;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTIPR;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DateTimePicker dtInput;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbOrder;
        private System.Windows.Forms.BindingSource bsOrder;
        private System.Windows.Forms.Button btnOrderSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource bdsWorker1;
    }
}