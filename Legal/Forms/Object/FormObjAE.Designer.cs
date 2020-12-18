namespace Legal.Forms.Object
{
    partial class FormObjAE
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
            System.Windows.Forms.Label regimeLabel;
            System.Windows.Forms.Label kLossLabel;
            System.Windows.Forms.Label powerFactLabel;
            System.Windows.Forms.Label powerOtherLabel;
            System.Windows.Forms.Label powerSetLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label idWorkerLabel;
            System.Windows.Forms.Label idAbnLabel;
            System.Windows.Forms.Label idObjParentLabel;
            System.Windows.Forms.Button btnObjParent;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label statusNameLabel;
            System.Windows.Forms.Label abnSaleLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label label14;
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            this.dsRaionObl = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dsObl = new System.Data.DataSet();
            this.dataTableObl = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dsPunkts = new System.Data.DataSet();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dsRaionCity = new System.Data.DataSet();
            this.dataTableClassifier = new System.Data.DataTable();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dsStreet = new System.Data.DataSet();
            this.dataTable3 = new System.Data.DataTable();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.bsTariff = new System.Windows.Forms.BindingSource(this.components);
            this.bsWorkers = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.contextMenuStripImage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewImages = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.ImageOriginal = new System.Windows.Forms.DataGridViewImageColumn();
            this.Compressed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripImage = new System.Windows.Forms.ToolStrip();
            this.tsbImage = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveImage = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveImage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pbScanDoc = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControlLuinkSchmAbnObj = new System.Windows.Forms.TabControl();
            this.tabPageLinkSchmAbnObj = new System.Windows.Forms.TabPage();
            this.dgvLinkSchmAbnObj = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.schmObjNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLinkSchmAbnDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSchmObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNumberDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docDateDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOwnerDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOwnerDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delDocDgvColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSourceLinkSchmAbnObj = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStripLinkSchmAbnObj = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddLinkSchmAbnObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelLinkSchmAbnObj = new System.Windows.Forms.ToolStripButton();
            this.tabPageOldLinkSchmAbnObj = new System.Windows.Forms.TabPage();
            this.dgvTP = new System.Windows.Forms.DataGridView();
            this.idxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCenter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberCell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObjoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameShinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataModDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pitSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pitNomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthKabDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signLowVoltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rubilnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTP = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripTP = new System.Windows.Forms.ToolStrip();
            this.tsbNewTP = new System.Windows.Forms.ToolStripButton();
            this.tsbEditTP = new System.Windows.Forms.ToolStripButton();
            this.tsbDelTP = new System.Windows.Forms.ToolStripButton();
            this.groupBoxLoss = new System.Windows.Forms.GroupBox();
            this.dgvLoss = new System.Windows.Forms.DataGridView();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonKLossTrans = new System.Windows.Forms.Button();
            this.cbxCalcLoss = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.PowerCalcNUD = new System.Windows.Forms.NumericUpDown();
            this.dtMeasurDate = new System.Windows.Forms.DateTimePicker();
            this.bsMeasur = new System.Windows.Forms.BindingSource(this.components);
            this.dsObj1 = new Legal.DataSet.dsObj();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMeasurAverage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMeasur = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtDatePowerFact = new System.Windows.Forms.DateTimePicker();
            this.PowerSetNUD = new System.Windows.Forms.NumericUpDown();
            this.dtDateTU = new System.Windows.Forms.DateTimePicker();
            this.txtNumberTU = new System.Windows.Forms.MaskedTextBox();
            this.PowerOtherNUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDateTP = new System.Windows.Forms.ComboBox();
            this.bsDateVidan = new System.Windows.Forms.BindingSource(this.components);
            this.PowerFactNUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbNumberTP = new System.Windows.Forms.ComboBox();
            this.bsNumRazr = new System.Windows.Forms.BindingSource(this.components);
            this.KLossNUD = new System.Windows.Forms.NumericUpDown();
            this.RegimeNUD = new System.Windows.Forms.NumericUpDown();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNewName = new System.Windows.Forms.Button();
            this.btnCopyName = new System.Windows.Forms.Button();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnObjSame = new System.Windows.Forms.Button();
            this.txtObjectSame = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.abnServicingComboBox = new System.Windows.Forms.ComboBox();
            this.cmbConsumer = new System.Windows.Forms.ComboBox();
            this.bsConsumer = new System.Windows.Forms.BindingSource(this.components);
            this.dsLObj = new Legal.DataSet.DataSetLObj();
            this.cmbConsumerGroup = new System.Windows.Forms.ComboBox();
            this.bsConsumerGroup = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubNetComment = new System.Windows.Forms.TextBox();
            this.cbxSubNet = new System.Windows.Forms.CheckBox();
            this.TariffcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.abnSaleComboBox = new System.Windows.Forms.ComboBox();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTariff = new System.Windows.Forms.Label();
            this.dateTimePickerDateChange = new System.Windows.Forms.DateTimePicker();
            this.AbnNetComboBox = new System.Windows.Forms.ComboBox();
            this.statusNameComboBox = new System.Windows.Forms.ComboBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.txtParent = new System.Windows.Forms.TextBox();
            this.txtCodeAbonent = new System.Windows.Forms.TextBox();
            this.txtAbn = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAddressComment = new System.Windows.Forms.TextBox();
            this.cmbRaionObl = new System.Windows.Forms.ComboBox();
            this.labelRaionObl = new System.Windows.Forms.Label();
            this.labelObl = new System.Windows.Forms.Label();
            this.cmbObl = new System.Windows.Forms.ComboBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.txtHousePrefix = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelHousePrefix = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.labelRaionCity = new System.Windows.Forms.Label();
            this.labelHouse = new System.Windows.Forms.Label();
            this.cmbRaionCity = new System.Windows.Forms.ComboBox();
            this.cmbStreet = new System.Windows.Forms.ComboBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageODS = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNumDocActApprovalReservation = new System.Windows.Forms.TextBox();
            this.txtEmergencyReserv = new System.Windows.Forms.TextBox();
            this.dtpDateDocActApprovalReservation = new System.Windows.Forms.DateTimePicker();
            this.txtTechnologicalReserv = new System.Windows.Forms.TextBox();
            this.txtCommentODS = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            regimeLabel = new System.Windows.Forms.Label();
            kLossLabel = new System.Windows.Forms.Label();
            powerFactLabel = new System.Windows.Forms.Label();
            powerOtherLabel = new System.Windows.Forms.Label();
            powerSetLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            idWorkerLabel = new System.Windows.Forms.Label();
            idAbnLabel = new System.Windows.Forms.Label();
            idObjParentLabel = new System.Windows.Forms.Label();
            btnObjParent = new System.Windows.Forms.Button();
            categoryLabel = new System.Windows.Forms.Label();
            statusNameLabel = new System.Windows.Forms.Label();
            abnSaleLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRaionObl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableObl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPunkts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRaionCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClassifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTariff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkers)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).BeginInit();
            this.toolStripImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanDoc)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabControlLuinkSchmAbnObj.SuspendLayout();
            this.tabPageLinkSchmAbnObj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkSchmAbnObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLinkSchmAbnObj)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStripLinkSchmAbnObj.SuspendLayout();
            this.tabPageOldLinkSchmAbnObj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTP)).BeginInit();
            this.toolStripTP.SuspendLayout();
            this.groupBoxLoss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoss)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerCalcNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerSetNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerOtherNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDateVidan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerFactNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNumRazr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KLossNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegimeNUD)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsConsumer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLObj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConsumerGroup)).BeginInit();
            this.groupBoxAddress.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageODS.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // regimeLabel
            // 
            regimeLabel.AutoSize = true;
            regimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            regimeLabel.Location = new System.Drawing.Point(7, 24);
            regimeLabel.Name = "regimeLabel";
            regimeLabel.Size = new System.Drawing.Size(51, 13);
            regimeLabel.TabIndex = 10;
            regimeLabel.Text = "Режим:";
            // 
            // kLossLabel
            // 
            kLossLabel.AutoSize = true;
            kLossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kLossLabel.Location = new System.Drawing.Point(4, 60);
            kLossLabel.Name = "kLossLabel";
            kLossLabel.Size = new System.Drawing.Size(54, 13);
            kLossLabel.TabIndex = 12;
            kLossLabel.Text = "Потери:";
            // 
            // powerFactLabel
            // 
            powerFactLabel.AutoSize = true;
            powerFactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            powerFactLabel.Location = new System.Drawing.Point(22, 122);
            powerFactLabel.Name = "powerFactLabel";
            powerFactLabel.Size = new System.Drawing.Size(151, 13);
            powerFactLabel.TabIndex = 18;
            powerFactLabel.Text = "По замерам инспекции:";
            // 
            // powerOtherLabel
            // 
            powerOtherLabel.AutoSize = true;
            powerOtherLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            powerOtherLabel.Location = new System.Drawing.Point(27, 56);
            powerOtherLabel.Name = "powerOtherLabel";
            powerOtherLabel.Size = new System.Drawing.Size(147, 13);
            powerOtherLabel.TabIndex = 16;
            powerOtherLabel.Text = "Разрешенная(рабочая):";
            // 
            // powerSetLabel
            // 
            powerSetLabel.AutoSize = true;
            powerSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            powerSetLabel.Location = new System.Drawing.Point(22, 21);
            powerSetLabel.Name = "powerSetLabel";
            powerSetLabel.Size = new System.Drawing.Size(152, 13);
            powerSetLabel.TabIndex = 14;
            powerSetLabel.Text = "Утвержденная УльГЭС :";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(50, 23);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 13);
            nameLabel.TabIndex = 30;
            nameLabel.Text = "Объект:";
            // 
            // idWorkerLabel
            // 
            idWorkerLabel.AutoSize = true;
            idWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idWorkerLabel.Location = new System.Drawing.Point(463, 76);
            idWorkerLabel.Name = "idWorkerLabel";
            idWorkerLabel.Size = new System.Drawing.Size(55, 13);
            idWorkerLabel.TabIndex = 32;
            idWorkerLabel.Text = "Мастер:";
            // 
            // idAbnLabel
            // 
            idAbnLabel.AutoSize = true;
            idAbnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idAbnLabel.Location = new System.Drawing.Point(13, 76);
            idAbnLabel.Name = "idAbnLabel";
            idAbnLabel.Size = new System.Drawing.Size(68, 13);
            idAbnLabel.TabIndex = 34;
            idAbnLabel.Text = "Владелец:";
            // 
            // idObjParentLabel
            // 
            idObjParentLabel.AutoSize = true;
            idObjParentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idObjParentLabel.Location = new System.Drawing.Point(7, 102);
            idObjParentLabel.Name = "idObjParentLabel";
            idObjParentLabel.Size = new System.Drawing.Size(74, 13);
            idObjParentLabel.TabIndex = 36;
            idObjParentLabel.Text = "Субобъект:";
            // 
            // btnObjParent
            // 
            btnObjParent.Location = new System.Drawing.Point(286, 96);
            btnObjParent.Name = "btnObjParent";
            btnObjParent.Size = new System.Drawing.Size(60, 25);
            btnObjParent.TabIndex = 39;
            btnObjParent.Text = "Выбор";
            btnObjParent.UseVisualStyleBackColor = true;
            btnObjParent.Click += new System.EventHandler(this.btnObjParent_Click);
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            categoryLabel.Location = new System.Drawing.Point(432, 125);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(73, 13);
            categoryLabel.TabIndex = 30;
            categoryLabel.Text = "Категория:";
            // 
            // statusNameLabel
            // 
            statusNameLabel.AutoSize = true;
            statusNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            statusNameLabel.Location = new System.Drawing.Point(59, 125);
            statusNameLabel.Name = "statusNameLabel";
            statusNameLabel.Size = new System.Drawing.Size(104, 13);
            statusNameLabel.TabIndex = 28;
            statusNameLabel.Text = "Статус объекта:";
            // 
            // abnSaleLabel
            // 
            abnSaleLabel.AutoSize = true;
            abnSaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            abnSaleLabel.Location = new System.Drawing.Point(6, 49);
            abnSaleLabel.Name = "abnSaleLabel";
            abnSaleLabel.Size = new System.Drawing.Size(149, 13);
            abnSaleLabel.TabIndex = 26;
            abnSaleLabel.Text = "Сбытовая организация:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            commentLabel.Location = new System.Drawing.Point(82, 289);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(84, 13);
            commentLabel.TabIndex = 42;
            commentLabel.Text = "Примечание:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label14.Location = new System.Drawing.Point(6, 72);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(186, 13);
            label14.TabIndex = 53;
            label14.Text = "Обслуживающая организация";
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsRaionObl
            // 
            this.dsRaionObl.DataSetName = "NewDataSet";
            this.dsRaionObl.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dataTable1.TableName = "tR_KladrObj";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Id";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Name";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Socr";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "NameSocr";
            this.dataColumn8.Expression = "Name + \' \' + isnull(socr, \'\')";
            this.dataColumn8.ReadOnly = true;
            // 
            // dsObl
            // 
            this.dsObl.DataSetName = "NewDataSet";
            this.dsObl.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableObl});
            // 
            // dataTableObl
            // 
            this.dataTableObl.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTableObl.TableName = "tR_KladrObj";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Name";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Socr";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "NameSocr";
            this.dataColumn4.Expression = "Name + \' \' + isnull(socr, \'\')";
            this.dataColumn4.ReadOnly = true;
            // 
            // dsPunkts
            // 
            this.dsPunkts.DataSetName = "NewDataSet";
            this.dsPunkts.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable2});
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12});
            this.dataTable2.TableName = "tR_KladrObj";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Id";
            this.dataColumn9.DataType = typeof(int);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Name";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Socr";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "NameSocr";
            this.dataColumn12.Expression = "Name + \' \' + isnull(socr, \'\')";
            this.dataColumn12.ReadOnly = true;
            // 
            // dsRaionCity
            // 
            this.dsRaionCity.DataSetName = "NewDataSet";
            this.dsRaionCity.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableClassifier});
            // 
            // dataTableClassifier
            // 
            this.dataTableClassifier.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn17,
            this.dataColumn18});
            this.dataTableClassifier.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Id"}, true)});
            this.dataTableClassifier.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn17};
            this.dataTableClassifier.TableName = "tR_Classifier";
            // 
            // dataColumn17
            // 
            this.dataColumn17.AllowDBNull = false;
            this.dataColumn17.ColumnName = "Id";
            this.dataColumn17.DataType = typeof(int);
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "Name";
            // 
            // dsStreet
            // 
            this.dsStreet.DataSetName = "NewDataSet";
            this.dsStreet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable3});
            // 
            // dataTable3
            // 
            this.dataTable3.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn19});
            this.dataTable3.TableName = "tR_KladrStreet";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "Id";
            this.dataColumn13.DataType = typeof(int);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "Name";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "Socr";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "NameSocr";
            this.dataColumn16.Expression = "Name + \' \' + isnull(socr, \'\')";
            this.dataColumn16.ReadOnly = true;
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "Index";
            // 
            // bsTariff
            // 
            this.bsTariff.DataMember = "tR_Classifier_Tariff";
            this.bsTariff.DataSource = this.dsAbn;
            // 
            // bsWorkers
            // 
            this.bsWorkers.DataMember = "vWorkerGroup";
            this.bsWorkers.DataSource = this.dsAbn;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(562, 616);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 31;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(450, 616);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 30;
            this.buttonOK.Text = "Сохранить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // contextMenuStripImage
            // 
            this.contextMenuStripImage.Name = "contextMenuStripImage";
            this.contextMenuStripImage.Size = new System.Drawing.Size(61, 4);
            // 
            // tabPage5
            // 
            this.tabPage5.AutoScroll = true;
            this.tabPage5.Controls.Add(this.dataGridViewImages);
            this.tabPage5.Controls.Add(this.toolStripImage);
            this.tabPage5.Controls.Add(this.pbScanDoc);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(667, 581);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Сканы документов";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImages
            // 
            this.dataGridViewImages.AllowUserToAddRows = false;
            this.dataGridViewImages.AllowUserToDeleteRows = false;
            this.dataGridViewImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImages.ColumnHeadersVisible = false;
            this.dataGridViewImages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.ImageOriginal,
            this.Compressed,
            this.id});
            this.dataGridViewImages.Location = new System.Drawing.Point(7, 28);
            this.dataGridViewImages.Name = "dataGridViewImages";
            this.dataGridViewImages.ReadOnly = true;
            this.dataGridViewImages.RowHeadersWidth = 4;
            this.dataGridViewImages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewImages.RowTemplate.Height = 200;
            this.dataGridViewImages.Size = new System.Drawing.Size(185, 550);
            this.dataGridViewImages.TabIndex = 40;
            this.dataGridViewImages.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewImages_CellMouseClick);
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.image.HeaderText = "image";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            // 
            // ImageOriginal
            // 
            this.ImageOriginal.HeaderText = "ImageOriginal";
            this.ImageOriginal.Name = "ImageOriginal";
            this.ImageOriginal.ReadOnly = true;
            this.ImageOriginal.Visible = false;
            // 
            // Compressed
            // 
            this.Compressed.HeaderText = "Compressed";
            this.Compressed.Name = "Compressed";
            this.Compressed.ReadOnly = true;
            this.Compressed.Visible = false;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // toolStripImage
            // 
            this.toolStripImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbImage,
            this.tsbRemoveImage,
            this.tsbSaveImage,
            this.toolStripButton1});
            this.toolStripImage.Location = new System.Drawing.Point(0, 0);
            this.toolStripImage.Name = "toolStripImage";
            this.toolStripImage.Size = new System.Drawing.Size(667, 25);
            this.toolStripImage.Stretch = true;
            this.toolStripImage.TabIndex = 2;
            this.toolStripImage.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // tsbImage
            // 
            this.tsbImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbImage.Image = global::Legal.Properties.Resources._1304663065_Add;
            this.tsbImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbImage.Name = "tsbImage";
            this.tsbImage.Size = new System.Drawing.Size(23, 22);
            this.tsbImage.Text = "Добавить изображение";
            this.tsbImage.Click += new System.EventHandler(this.tsbImage_Click);
            // 
            // tsbRemoveImage
            // 
            this.tsbRemoveImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRemoveImage.Image = global::Legal.Properties.Resources.Delete;
            this.tsbRemoveImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveImage.Name = "tsbRemoveImage";
            this.tsbRemoveImage.Size = new System.Drawing.Size(23, 22);
            this.tsbRemoveImage.Text = "Удалить изображение";
            this.tsbRemoveImage.Click += new System.EventHandler(this.tsbRemoveImage_Click);
            // 
            // tsbSaveImage
            // 
            this.tsbSaveImage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSaveImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveImage.Image = global::Legal.Properties.Resources.filesave;
            this.tsbSaveImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveImage.Name = "tsbSaveImage";
            this.tsbSaveImage.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveImage.Text = "Сохранить изображение в файл для просмотра и печати";
            this.tsbSaveImage.Click += new System.EventHandler(this.tsbSaveImage_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Legal.Properties.Resources.Print;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Открыть и напечатать изображение";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // pbScanDoc
            // 
            this.pbScanDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScanDoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbScanDoc.Location = new System.Drawing.Point(194, 28);
            this.pbScanDoc.Name = "pbScanDoc";
            this.pbScanDoc.Size = new System.Drawing.Size(473, 550);
            this.pbScanDoc.TabIndex = 1;
            this.pbScanDoc.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControlLuinkSchmAbnObj);
            this.tabPage3.Controls.Add(this.groupBoxLoss);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.KLossNUD);
            this.tabPage3.Controls.Add(this.RegimeNUD);
            this.tabPage3.Controls.Add(kLossLabel);
            this.tabPage3.Controls.Add(regimeLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(667, 581);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Технические";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControlLuinkSchmAbnObj
            // 
            this.tabControlLuinkSchmAbnObj.Controls.Add(this.tabPageLinkSchmAbnObj);
            this.tabControlLuinkSchmAbnObj.Controls.Add(this.tabPageOldLinkSchmAbnObj);
            this.tabControlLuinkSchmAbnObj.Location = new System.Drawing.Point(10, 305);
            this.tabControlLuinkSchmAbnObj.Name = "tabControlLuinkSchmAbnObj";
            this.tabControlLuinkSchmAbnObj.SelectedIndex = 0;
            this.tabControlLuinkSchmAbnObj.Size = new System.Drawing.Size(647, 276);
            this.tabControlLuinkSchmAbnObj.TabIndex = 49;
            // 
            // tabPageLinkSchmAbnObj
            // 
            this.tabPageLinkSchmAbnObj.Controls.Add(this.dgvLinkSchmAbnObj);
            this.tabPageLinkSchmAbnObj.Controls.Add(this.panel1);
            this.tabPageLinkSchmAbnObj.Controls.Add(this.toolStripLinkSchmAbnObj);
            this.tabPageLinkSchmAbnObj.Location = new System.Drawing.Point(4, 22);
            this.tabPageLinkSchmAbnObj.Name = "tabPageLinkSchmAbnObj";
            this.tabPageLinkSchmAbnObj.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLinkSchmAbnObj.Size = new System.Drawing.Size(639, 250);
            this.tabPageLinkSchmAbnObj.TabIndex = 0;
            this.tabPageLinkSchmAbnObj.Text = "Привязка к схеме";
            this.tabPageLinkSchmAbnObj.UseVisualStyleBackColor = true;
            // 
            // dgvLinkSchmAbnObj
            // 
            this.dgvLinkSchmAbnObj.AllowUserToAddRows = false;
            this.dgvLinkSchmAbnObj.AllowUserToDeleteRows = false;
            this.dgvLinkSchmAbnObj.AllowUserToOrderColumns = true;
            this.dgvLinkSchmAbnObj.AllowUserToResizeRows = false;
            this.dgvLinkSchmAbnObj.AutoGenerateColumns = false;
            this.dgvLinkSchmAbnObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinkSchmAbnObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schmObjNameDataGridViewTextBoxColumn,
            this.idLinkSchmAbnDgvColumn,
            this.idSchmObjDataGridViewTextBoxColumn,
            this.idAbnDataGridViewTextBoxColumn,
            this.idAbnObjDataGridViewTextBoxColumn,
            this.idPointDataGridViewTextBoxColumn,
            this.idDocDGV,
            this.typeDocDgvColumn,
            this.typeDocNameDataGridViewTextBoxColumn,
            this.docNumberDgvColumn,
            this.docDateDgvColumn,
            this.nameOwnerDgvColumn,
            this.dateOwnerDgvColumn,
            this.delDocDgvColumn});
            this.dgvLinkSchmAbnObj.DataSource = this.bindingSourceLinkSchmAbnObj;
            this.dgvLinkSchmAbnObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinkSchmAbnObj.Location = new System.Drawing.Point(27, 3);
            this.dgvLinkSchmAbnObj.Name = "dgvLinkSchmAbnObj";
            this.dgvLinkSchmAbnObj.ReadOnly = true;
            this.dgvLinkSchmAbnObj.RowHeadersWidth = 15;
            this.dgvLinkSchmAbnObj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinkSchmAbnObj.Size = new System.Drawing.Size(609, 212);
            this.dgvLinkSchmAbnObj.TabIndex = 1;
            this.dgvLinkSchmAbnObj.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinkSchmAbnObj_CellDoubleClick);
            this.dgvLinkSchmAbnObj.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLinkSchmAbnObj_CellFormatting);
            // 
            // schmObjNameDataGridViewTextBoxColumn
            // 
            this.schmObjNameDataGridViewTextBoxColumn.DataPropertyName = "SchmObjName";
            this.schmObjNameDataGridViewTextBoxColumn.HeaderText = "Объект схемы";
            this.schmObjNameDataGridViewTextBoxColumn.Name = "schmObjNameDataGridViewTextBoxColumn";
            this.schmObjNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.schmObjNameDataGridViewTextBoxColumn.Width = 196;
            // 
            // idLinkSchmAbnDgvColumn
            // 
            this.idLinkSchmAbnDgvColumn.DataPropertyName = "id";
            this.idLinkSchmAbnDgvColumn.HeaderText = "id";
            this.idLinkSchmAbnDgvColumn.Name = "idLinkSchmAbnDgvColumn";
            this.idLinkSchmAbnDgvColumn.ReadOnly = true;
            this.idLinkSchmAbnDgvColumn.Visible = false;
            this.idLinkSchmAbnDgvColumn.Width = 5;
            // 
            // idSchmObjDataGridViewTextBoxColumn
            // 
            this.idSchmObjDataGridViewTextBoxColumn.DataPropertyName = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.HeaderText = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.Name = "idSchmObjDataGridViewTextBoxColumn";
            this.idSchmObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSchmObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // idAbnObjDataGridViewTextBoxColumn
            // 
            this.idAbnObjDataGridViewTextBoxColumn.DataPropertyName = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.HeaderText = "idAbnObj";
            this.idAbnObjDataGridViewTextBoxColumn.Name = "idAbnObjDataGridViewTextBoxColumn";
            this.idAbnObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPointDataGridViewTextBoxColumn
            // 
            this.idPointDataGridViewTextBoxColumn.DataPropertyName = "idPoint";
            this.idPointDataGridViewTextBoxColumn.HeaderText = "idPoint";
            this.idPointDataGridViewTextBoxColumn.Name = "idPointDataGridViewTextBoxColumn";
            this.idPointDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDocDGV
            // 
            this.idDocDGV.DataPropertyName = "idDoc";
            this.idDocDGV.HeaderText = "idDoc";
            this.idDocDGV.Name = "idDocDGV";
            this.idDocDGV.ReadOnly = true;
            this.idDocDGV.Visible = false;
            // 
            // typeDocDgvColumn
            // 
            this.typeDocDgvColumn.DataPropertyName = "TypeDoc";
            this.typeDocDgvColumn.HeaderText = "TypeDoc";
            this.typeDocDgvColumn.Name = "typeDocDgvColumn";
            this.typeDocDgvColumn.ReadOnly = true;
            this.typeDocDgvColumn.Visible = false;
            // 
            // typeDocNameDataGridViewTextBoxColumn
            // 
            this.typeDocNameDataGridViewTextBoxColumn.DataPropertyName = "typeDocName";
            this.typeDocNameDataGridViewTextBoxColumn.HeaderText = "Документ";
            this.typeDocNameDataGridViewTextBoxColumn.Name = "typeDocNameDataGridViewTextBoxColumn";
            this.typeDocNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDocNameDataGridViewTextBoxColumn.Width = 196;
            // 
            // docNumberDgvColumn
            // 
            this.docNumberDgvColumn.DataPropertyName = "DocNumber";
            this.docNumberDgvColumn.HeaderText = "№ документа";
            this.docNumberDgvColumn.Name = "docNumberDgvColumn";
            this.docNumberDgvColumn.ReadOnly = true;
            // 
            // docDateDgvColumn
            // 
            this.docDateDgvColumn.DataPropertyName = "DocDate";
            this.docDateDgvColumn.HeaderText = "Дата документа";
            this.docDateDgvColumn.Name = "docDateDgvColumn";
            this.docDateDgvColumn.ReadOnly = true;
            // 
            // nameOwnerDgvColumn
            // 
            this.nameOwnerDgvColumn.DataPropertyName = "nameOwner";
            this.nameOwnerDgvColumn.HeaderText = "Пользователь";
            this.nameOwnerDgvColumn.Name = "nameOwnerDgvColumn";
            this.nameOwnerDgvColumn.ReadOnly = true;
            // 
            // dateOwnerDgvColumn
            // 
            this.dateOwnerDgvColumn.DataPropertyName = "dateOwner";
            this.dateOwnerDgvColumn.HeaderText = "Дата создания";
            this.dateOwnerDgvColumn.Name = "dateOwnerDgvColumn";
            this.dateOwnerDgvColumn.ReadOnly = true;
            // 
            // delDocDgvColumn
            // 
            this.delDocDgvColumn.DataPropertyName = "delDoc";
            this.delDocDgvColumn.HeaderText = "delDoc";
            this.delDocDgvColumn.Name = "delDocDgvColumn";
            this.delDocDgvColumn.ReadOnly = true;
            this.delDocDgvColumn.Visible = false;
            // 
            // bindingSourceLinkSchmAbnObj
            // 
            this.bindingSourceLinkSchmAbnObj.DataMember = "vL_SchmAbn";
            this.bindingSourceLinkSchmAbnObj.DataSource = this.dsAbn;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(27, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 32);
            this.panel1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceLinkSchmAbnObj, "dateOwner", true));
            this.textBox2.Location = new System.Drawing.Point(377, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(127, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(274, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Дата создания";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Пользователь";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceLinkSchmAbnObj, "nameOwner", true));
            this.textBox1.Location = new System.Drawing.Point(105, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 0;
            // 
            // toolStripLinkSchmAbnObj
            // 
            this.toolStripLinkSchmAbnObj.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripLinkSchmAbnObj.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripLinkSchmAbnObj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddLinkSchmAbnObj,
            this.toolBtnDelLinkSchmAbnObj});
            this.toolStripLinkSchmAbnObj.Location = new System.Drawing.Point(3, 3);
            this.toolStripLinkSchmAbnObj.Name = "toolStripLinkSchmAbnObj";
            this.toolStripLinkSchmAbnObj.Size = new System.Drawing.Size(24, 244);
            this.toolStripLinkSchmAbnObj.TabIndex = 0;
            this.toolStripLinkSchmAbnObj.Text = "toolStrip1";
            // 
            // toolBtnAddLinkSchmAbnObj
            // 
            this.toolBtnAddLinkSchmAbnObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddLinkSchmAbnObj.Image = global::Legal.Properties.Resources.ElementAdd;
            this.toolBtnAddLinkSchmAbnObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddLinkSchmAbnObj.Name = "toolBtnAddLinkSchmAbnObj";
            this.toolBtnAddLinkSchmAbnObj.Size = new System.Drawing.Size(21, 20);
            this.toolBtnAddLinkSchmAbnObj.Text = "Добавить связь";
            this.toolBtnAddLinkSchmAbnObj.Click += new System.EventHandler(this.toolBtnAddLinkSchmAbnObj_Click);
            // 
            // toolBtnDelLinkSchmAbnObj
            // 
            this.toolBtnDelLinkSchmAbnObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelLinkSchmAbnObj.Image = global::Legal.Properties.Resources.ElementDel;
            this.toolBtnDelLinkSchmAbnObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelLinkSchmAbnObj.Name = "toolBtnDelLinkSchmAbnObj";
            this.toolBtnDelLinkSchmAbnObj.Size = new System.Drawing.Size(21, 20);
            this.toolBtnDelLinkSchmAbnObj.Text = "Удалить связь";
            this.toolBtnDelLinkSchmAbnObj.Click += new System.EventHandler(this.toolBtnDelLinkSchmAbnObj_Click);
            // 
            // tabPageOldLinkSchmAbnObj
            // 
            this.tabPageOldLinkSchmAbnObj.Controls.Add(this.dgvTP);
            this.tabPageOldLinkSchmAbnObj.Controls.Add(this.toolStripTP);
            this.tabPageOldLinkSchmAbnObj.Location = new System.Drawing.Point(4, 22);
            this.tabPageOldLinkSchmAbnObj.Name = "tabPageOldLinkSchmAbnObj";
            this.tabPageOldLinkSchmAbnObj.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOldLinkSchmAbnObj.Size = new System.Drawing.Size(639, 250);
            this.tabPageOldLinkSchmAbnObj.TabIndex = 1;
            this.tabPageOldLinkSchmAbnObj.Text = "Подключения (из старой базы)";
            this.tabPageOldLinkSchmAbnObj.UseVisualStyleBackColor = true;
            // 
            // dgvTP
            // 
            this.dgvTP.AllowUserToAddRows = false;
            this.dgvTP.AllowUserToDeleteRows = false;
            this.dgvTP.AutoGenerateColumns = false;
            this.dgvTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idxDataGridViewTextBoxColumn,
            this.NameCenter,
            this.NumberCell,
            this.idObjDataGridViewTextBoxColumn,
            this.idObjoldDataGridViewTextBoxColumn,
            this.nameGroupDataGridViewTextBoxColumn,
            this.nameShinaDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.compNameDataGridViewTextBoxColumn,
            this.dataModDataGridViewTextBoxColumn,
            this.pitSumDataGridViewTextBoxColumn,
            this.pitNomDataGridViewTextBoxColumn,
            this.lengthKabDataGridViewTextBoxColumn,
            this.signLowVoltDataGridViewTextBoxColumn,
            this.rubilnikDataGridViewTextBoxColumn});
            this.dgvTP.DataSource = this.bsTP;
            this.dgvTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTP.Location = new System.Drawing.Point(28, 3);
            this.dgvTP.Name = "dgvTP";
            this.dgvTP.ReadOnly = true;
            this.dgvTP.RowHeadersVisible = false;
            this.dgvTP.RowHeadersWidth = 5;
            this.dgvTP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTP.Size = new System.Drawing.Size(608, 244);
            this.dgvTP.TabIndex = 6;
            // 
            // idxDataGridViewTextBoxColumn
            // 
            this.idxDataGridViewTextBoxColumn.DataPropertyName = "idx";
            this.idxDataGridViewTextBoxColumn.HeaderText = "idx";
            this.idxDataGridViewTextBoxColumn.Name = "idxDataGridViewTextBoxColumn";
            this.idxDataGridViewTextBoxColumn.ReadOnly = true;
            this.idxDataGridViewTextBoxColumn.Visible = false;
            // 
            // NameCenter
            // 
            this.NameCenter.DataPropertyName = "NameCenter";
            this.NameCenter.HeaderText = "Питающий центр";
            this.NameCenter.Name = "NameCenter";
            this.NameCenter.ReadOnly = true;
            this.NameCenter.Width = 150;
            // 
            // NumberCell
            // 
            this.NumberCell.DataPropertyName = "NumberCell";
            this.NumberCell.HeaderText = "Ячейка";
            this.NumberCell.Name = "NumberCell";
            this.NumberCell.ReadOnly = true;
            this.NumberCell.Width = 60;
            // 
            // idObjDataGridViewTextBoxColumn
            // 
            this.idObjDataGridViewTextBoxColumn.DataPropertyName = "idObj";
            this.idObjDataGridViewTextBoxColumn.HeaderText = "idObj";
            this.idObjDataGridViewTextBoxColumn.Name = "idObjDataGridViewTextBoxColumn";
            this.idObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // idObjoldDataGridViewTextBoxColumn
            // 
            this.idObjoldDataGridViewTextBoxColumn.DataPropertyName = "idObj_old";
            this.idObjoldDataGridViewTextBoxColumn.HeaderText = "idObj_old";
            this.idObjoldDataGridViewTextBoxColumn.Name = "idObjoldDataGridViewTextBoxColumn";
            this.idObjoldDataGridViewTextBoxColumn.ReadOnly = true;
            this.idObjoldDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameGroupDataGridViewTextBoxColumn
            // 
            this.nameGroupDataGridViewTextBoxColumn.DataPropertyName = "Name_Group";
            this.nameGroupDataGridViewTextBoxColumn.HeaderText = "Подстанция";
            this.nameGroupDataGridViewTextBoxColumn.Name = "nameGroupDataGridViewTextBoxColumn";
            this.nameGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameShinaDataGridViewTextBoxColumn
            // 
            this.nameShinaDataGridViewTextBoxColumn.DataPropertyName = "Name_Shina";
            this.nameShinaDataGridViewTextBoxColumn.HeaderText = "Шина";
            this.nameShinaDataGridViewTextBoxColumn.Name = "nameShinaDataGridViewTextBoxColumn";
            this.nameShinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameShinaDataGridViewTextBoxColumn.Width = 50;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 450;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // compNameDataGridViewTextBoxColumn
            // 
            this.compNameDataGridViewTextBoxColumn.DataPropertyName = "CompName";
            this.compNameDataGridViewTextBoxColumn.HeaderText = "CompName";
            this.compNameDataGridViewTextBoxColumn.Name = "compNameDataGridViewTextBoxColumn";
            this.compNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.compNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataModDataGridViewTextBoxColumn
            // 
            this.dataModDataGridViewTextBoxColumn.DataPropertyName = "DataMod";
            this.dataModDataGridViewTextBoxColumn.HeaderText = "DataMod";
            this.dataModDataGridViewTextBoxColumn.Name = "dataModDataGridViewTextBoxColumn";
            this.dataModDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataModDataGridViewTextBoxColumn.Visible = false;
            // 
            // pitSumDataGridViewTextBoxColumn
            // 
            this.pitSumDataGridViewTextBoxColumn.DataPropertyName = "PitSum";
            this.pitSumDataGridViewTextBoxColumn.HeaderText = "PitSum";
            this.pitSumDataGridViewTextBoxColumn.Name = "pitSumDataGridViewTextBoxColumn";
            this.pitSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.pitSumDataGridViewTextBoxColumn.Visible = false;
            // 
            // pitNomDataGridViewTextBoxColumn
            // 
            this.pitNomDataGridViewTextBoxColumn.DataPropertyName = "PitNom";
            this.pitNomDataGridViewTextBoxColumn.HeaderText = "PitNom";
            this.pitNomDataGridViewTextBoxColumn.Name = "pitNomDataGridViewTextBoxColumn";
            this.pitNomDataGridViewTextBoxColumn.ReadOnly = true;
            this.pitNomDataGridViewTextBoxColumn.Visible = false;
            // 
            // lengthKabDataGridViewTextBoxColumn
            // 
            this.lengthKabDataGridViewTextBoxColumn.DataPropertyName = "Length_Kab";
            this.lengthKabDataGridViewTextBoxColumn.HeaderText = "Length_Kab";
            this.lengthKabDataGridViewTextBoxColumn.Name = "lengthKabDataGridViewTextBoxColumn";
            this.lengthKabDataGridViewTextBoxColumn.ReadOnly = true;
            this.lengthKabDataGridViewTextBoxColumn.Visible = false;
            // 
            // signLowVoltDataGridViewTextBoxColumn
            // 
            this.signLowVoltDataGridViewTextBoxColumn.DataPropertyName = "Sign_LowVolt";
            this.signLowVoltDataGridViewTextBoxColumn.HeaderText = "Sign_LowVolt";
            this.signLowVoltDataGridViewTextBoxColumn.Name = "signLowVoltDataGridViewTextBoxColumn";
            this.signLowVoltDataGridViewTextBoxColumn.ReadOnly = true;
            this.signLowVoltDataGridViewTextBoxColumn.Visible = false;
            // 
            // rubilnikDataGridViewTextBoxColumn
            // 
            this.rubilnikDataGridViewTextBoxColumn.DataPropertyName = "Rubilnik";
            this.rubilnikDataGridViewTextBoxColumn.HeaderText = "Rubilnik";
            this.rubilnikDataGridViewTextBoxColumn.Name = "rubilnikDataGridViewTextBoxColumn";
            this.rubilnikDataGridViewTextBoxColumn.ReadOnly = true;
            this.rubilnikDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsTP
            // 
            this.bsTP.DataMember = "tConnect";
            this.bsTP.DataSource = this.dsAbn;
            // 
            // toolStripTP
            // 
            this.toolStripTP.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripTP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripTP.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTP.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripTP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewTP,
            this.tsbEditTP,
            this.tsbDelTP});
            this.toolStripTP.Location = new System.Drawing.Point(3, 3);
            this.toolStripTP.Name = "toolStripTP";
            this.toolStripTP.Size = new System.Drawing.Size(25, 244);
            this.toolStripTP.TabIndex = 0;
            this.toolStripTP.Text = "toolStrip1";
            // 
            // tsbNewTP
            // 
            this.tsbNewTP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewTP.Image = global::Legal.Properties.Resources._1304663065_Add;
            this.tsbNewTP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewTP.Name = "tsbNewTP";
            this.tsbNewTP.Size = new System.Drawing.Size(22, 24);
            this.tsbNewTP.Text = "Новое";
            this.tsbNewTP.Click += new System.EventHandler(this.tsbNewTP_Click);
            // 
            // tsbEditTP
            // 
            this.tsbEditTP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditTP.Image = global::Legal.Properties.Resources._1304663141_Pen;
            this.tsbEditTP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditTP.Name = "tsbEditTP";
            this.tsbEditTP.Size = new System.Drawing.Size(22, 24);
            this.tsbEditTP.Text = "Редактировать";
            this.tsbEditTP.Click += new System.EventHandler(this.tsbEditTP_Click);
            // 
            // tsbDelTP
            // 
            this.tsbDelTP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelTP.Image = global::Legal.Properties.Resources.Delete;
            this.tsbDelTP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelTP.Name = "tsbDelTP";
            this.tsbDelTP.Size = new System.Drawing.Size(22, 24);
            this.tsbDelTP.Text = "Удалить";
            this.tsbDelTP.Click += new System.EventHandler(this.tsbDelTP_Click);
            // 
            // groupBoxLoss
            // 
            this.groupBoxLoss.Controls.Add(this.dgvLoss);
            this.groupBoxLoss.Controls.Add(this.buttonKLossTrans);
            this.groupBoxLoss.Controls.Add(this.cbxCalcLoss);
            this.groupBoxLoss.Controls.Add(this.label3);
            this.groupBoxLoss.Location = new System.Drawing.Point(196, 3);
            this.groupBoxLoss.Name = "groupBoxLoss";
            this.groupBoxLoss.Size = new System.Drawing.Size(461, 107);
            this.groupBoxLoss.TabIndex = 48;
            this.groupBoxLoss.TabStop = false;
            // 
            // dgvLoss
            // 
            this.dgvLoss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Month,
            this.Value});
            this.dgvLoss.Location = new System.Drawing.Point(310, 9);
            this.dgvLoss.Name = "dgvLoss";
            this.dgvLoss.RowHeadersWidth = 5;
            this.dgvLoss.Size = new System.Drawing.Size(138, 94);
            this.dgvLoss.TabIndex = 47;
            // 
            // Month
            // 
            this.Month.HeaderText = "Месяц";
            this.Month.Name = "Month";
            this.Month.Width = 70;
            // 
            // Value
            // 
            this.Value.HeaderText = "кВт*ч";
            this.Value.Name = "Value";
            this.Value.Width = 50;
            // 
            // buttonKLossTrans
            // 
            this.buttonKLossTrans.Location = new System.Drawing.Point(229, 53);
            this.buttonKLossTrans.Name = "buttonKLossTrans";
            this.buttonKLossTrans.Size = new System.Drawing.Size(75, 23);
            this.buttonKLossTrans.TabIndex = 46;
            this.buttonKLossTrans.Text = "Потери";
            this.buttonKLossTrans.UseVisualStyleBackColor = true;
            this.buttonKLossTrans.Click += new System.EventHandler(this.buttonKLossTrans_Click);
            // 
            // cbxCalcLoss
            // 
            this.cbxCalcLoss.AutoSize = true;
            this.cbxCalcLoss.Location = new System.Drawing.Point(208, 58);
            this.cbxCalcLoss.Name = "cbxCalcLoss";
            this.cbxCalcLoss.Size = new System.Drawing.Size(15, 14);
            this.cbxCalcLoss.TabIndex = 36;
            this.cbxCalcLoss.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Рассчитывать потери при вводе:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.PowerCalcNUD);
            this.groupBox1.Controls.Add(this.dtMeasurDate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtMeasurAverage);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnMeasur);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(powerSetLabel);
            this.groupBox1.Controls.Add(this.dtDatePowerFact);
            this.groupBox1.Controls.Add(this.PowerSetNUD);
            this.groupBox1.Controls.Add(this.dtDateTU);
            this.groupBox1.Controls.Add(powerOtherLabel);
            this.groupBox1.Controls.Add(this.txtNumberTU);
            this.groupBox1.Controls.Add(this.PowerOtherNUD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbDateTP);
            this.groupBox1.Controls.Add(this.PowerFactNUD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbNumberTP);
            this.groupBox1.Controls.Add(powerFactLabel);
            this.groupBox1.Location = new System.Drawing.Point(10, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 193);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Мощность ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Из договоров УЭ:";
            // 
            // PowerCalcNUD
            // 
            this.PowerCalcNUD.DecimalPlaces = 3;
            this.PowerCalcNUD.Location = new System.Drawing.Point(181, 89);
            this.PowerCalcNUD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.PowerCalcNUD.Name = "PowerCalcNUD";
            this.PowerCalcNUD.Size = new System.Drawing.Size(102, 20);
            this.PowerCalcNUD.TabIndex = 51;
            this.PowerCalcNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtMeasurDate
            // 
            this.dtMeasurDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsMeasur, "DateOfIntroduction", true));
            this.dtMeasurDate.Location = new System.Drawing.Point(481, 162);
            this.dtMeasurDate.Name = "dtMeasurDate";
            this.dtMeasurDate.Size = new System.Drawing.Size(153, 20);
            this.dtMeasurDate.TabIndex = 50;
            // 
            // bsMeasur
            // 
            this.bsMeasur.DataMember = "tG_MeasurementsOfObject";
            this.bsMeasur.DataSource = this.dsObj1;
            // 
            // dsObj1
            // 
            this.dsObj1.DataSetName = "dsObj";
            this.dsObj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(445, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "от";
            // 
            // txtMeasurAverage
            // 
            this.txtMeasurAverage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMeasur, "AverageValue", true));
            this.txtMeasurAverage.Location = new System.Drawing.Point(323, 162);
            this.txtMeasurAverage.Name = "txtMeasurAverage";
            this.txtMeasurAverage.Size = new System.Drawing.Size(100, 20);
            this.txtMeasurAverage.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "среднее значение:";
            // 
            // btnMeasur
            // 
            this.btnMeasur.Image = global::Legal.Properties.Resources.edit;
            this.btnMeasur.Location = new System.Drawing.Point(163, 159);
            this.btnMeasur.Name = "btnMeasur";
            this.btnMeasur.Size = new System.Drawing.Size(23, 23);
            this.btnMeasur.TabIndex = 46;
            this.btnMeasur.UseVisualStyleBackColor = true;
            this.btnMeasur.Click += new System.EventHandler(this.btnMeasur_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Замеры зимнего дня:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "от";
            // 
            // dtDatePowerFact
            // 
            this.dtDatePowerFact.Enabled = false;
            this.dtDatePowerFact.Location = new System.Drawing.Point(335, 122);
            this.dtDatePowerFact.Name = "dtDatePowerFact";
            this.dtDatePowerFact.Size = new System.Drawing.Size(200, 20);
            this.dtDatePowerFact.TabIndex = 43;
            // 
            // PowerSetNUD
            // 
            this.PowerSetNUD.DecimalPlaces = 3;
            this.PowerSetNUD.Enabled = false;
            this.PowerSetNUD.Location = new System.Drawing.Point(181, 19);
            this.PowerSetNUD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.PowerSetNUD.Name = "PowerSetNUD";
            this.PowerSetNUD.Size = new System.Drawing.Size(102, 20);
            this.PowerSetNUD.TabIndex = 32;
            this.PowerSetNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtDateTU
            // 
            this.dtDateTU.Location = new System.Drawing.Point(478, 85);
            this.dtDateTU.Name = "dtDateTU";
            this.dtDateTU.Size = new System.Drawing.Size(144, 20);
            this.dtDateTU.TabIndex = 42;
            // 
            // txtNumberTU
            // 
            this.txtNumberTU.Location = new System.Drawing.Point(329, 86);
            this.txtNumberTU.Mask = "00000";
            this.txtNumberTU.Name = "txtNumberTU";
            this.txtNumberTU.PromptChar = ' ';
            this.txtNumberTU.Size = new System.Drawing.Size(121, 20);
            this.txtNumberTU.TabIndex = 41;
            this.txtNumberTU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNumberTU.ValidatingType = typeof(int);
            // 
            // PowerOtherNUD
            // 
            this.PowerOtherNUD.DecimalPlaces = 3;
            this.PowerOtherNUD.Location = new System.Drawing.Point(181, 54);
            this.PowerOtherNUD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.PowerOtherNUD.Name = "PowerOtherNUD";
            this.PowerOtherNUD.Size = new System.Drawing.Size(102, 20);
            this.PowerOtherNUD.TabIndex = 33;
            this.PowerOtherNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Технические условия:";
            // 
            // cmbDateTP
            // 
            this.cmbDateTP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDateVidan, "Date_Vidan", true));
            this.cmbDateTP.DataSource = this.bsDateVidan;
            this.cmbDateTP.DisplayMember = "Date_Vidan";
            this.cmbDateTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDateTP.FormattingEnabled = true;
            this.cmbDateTP.Location = new System.Drawing.Point(478, 37);
            this.cmbDateTP.Name = "cmbDateTP";
            this.cmbDateTP.Size = new System.Drawing.Size(121, 21);
            this.cmbDateTP.TabIndex = 40;
            this.cmbDateTP.ValueMember = "Date_Vidan";
            // 
            // bsDateVidan
            // 
            this.bsDateVidan.DataMember = "vG_PtsRazresh";
            this.bsDateVidan.DataSource = this.dsAbn;
            // 
            // PowerFactNUD
            // 
            this.PowerFactNUD.DecimalPlaces = 3;
            this.PowerFactNUD.Enabled = false;
            this.PowerFactNUD.Location = new System.Drawing.Point(181, 122);
            this.PowerFactNUD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.PowerFactNUD.Name = "PowerFactNUD";
            this.PowerFactNUD.Size = new System.Drawing.Size(102, 20);
            this.PowerFactNUD.TabIndex = 34;
            this.PowerFactNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Технологическое присоединение:";
            // 
            // cmbNumberTP
            // 
            this.cmbNumberTP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsNumRazr, "Num_Razr", true));
            this.cmbNumberTP.DataSource = this.bsNumRazr;
            this.cmbNumberTP.DisplayMember = "Num_Razr";
            this.cmbNumberTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumberTP.FormattingEnabled = true;
            this.cmbNumberTP.Location = new System.Drawing.Point(329, 37);
            this.cmbNumberTP.Name = "cmbNumberTP";
            this.cmbNumberTP.Size = new System.Drawing.Size(121, 21);
            this.cmbNumberTP.TabIndex = 39;
            this.cmbNumberTP.ValueMember = "Num_Razr";
            this.cmbNumberTP.SelectedIndexChanged += new System.EventHandler(this.cmbNumberTP_SelectedIndexChanged_1);
            // 
            // bsNumRazr
            // 
            this.bsNumRazr.DataMember = "vG_NumRazresh";
            this.bsNumRazr.DataSource = this.dsAbn;
            // 
            // KLossNUD
            // 
            this.KLossNUD.DecimalPlaces = 5;
            this.KLossNUD.Location = new System.Drawing.Point(64, 58);
            this.KLossNUD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.KLossNUD.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.KLossNUD.Name = "KLossNUD";
            this.KLossNUD.Size = new System.Drawing.Size(120, 20);
            this.KLossNUD.TabIndex = 31;
            this.KLossNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RegimeNUD
            // 
            this.RegimeNUD.Location = new System.Drawing.Point(64, 22);
            this.RegimeNUD.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.RegimeNUD.Name = "RegimeNUD";
            this.RegimeNUD.Size = new System.Drawing.Size(120, 20);
            this.RegimeNUD.TabIndex = 30;
            this.RegimeNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNewName);
            this.tabPage1.Controls.Add(this.btnCopyName);
            this.tabPage1.Controls.Add(this.txtShortName);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.btnObjSame);
            this.tabPage1.Controls.Add(this.txtObjectSame);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(btnObjParent);
            this.tabPage1.Controls.Add(idObjParentLabel);
            this.tabPage1.Controls.Add(this.txtParent);
            this.tabPage1.Controls.Add(this.txtCodeAbonent);
            this.tabPage1.Controls.Add(this.txtAbn);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(idAbnLabel);
            this.tabPage1.Controls.Add(idWorkerLabel);
            this.tabPage1.Controls.Add(this.cmbWorker);
            this.tabPage1.Controls.Add(nameLabel);
            this.tabPage1.Controls.Add(this.groupBoxAddress);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(667, 581);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNewName
            // 
            this.btnNewName.Image = global::Legal.Properties.Resources.arrow_up;
            this.btnNewName.Location = new System.Drawing.Point(620, 41);
            this.btnNewName.Name = "btnNewName";
            this.btnNewName.Size = new System.Drawing.Size(26, 23);
            this.btnNewName.TabIndex = 47;
            this.btnNewName.UseVisualStyleBackColor = true;
            this.btnNewName.Click += new System.EventHandler(this.btnNewName_Click);
            // 
            // btnCopyName
            // 
            this.btnCopyName.Image = global::Legal.Properties.Resources.arrow_down;
            this.btnCopyName.Location = new System.Drawing.Point(588, 41);
            this.btnCopyName.Name = "btnCopyName";
            this.btnCopyName.Size = new System.Drawing.Size(26, 23);
            this.btnCopyName.TabIndex = 46;
            this.btnCopyName.UseVisualStyleBackColor = true;
            this.btnCopyName.Click += new System.EventHandler(this.btnCopyName_Click);
            // 
            // txtShortName
            // 
            this.txtShortName.Location = new System.Drawing.Point(113, 43);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(461, 20);
            this.txtShortName.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = "Короткое имя:";
            // 
            // btnObjSame
            // 
            this.btnObjSame.Location = new System.Drawing.Point(597, 97);
            this.btnObjSame.Name = "btnObjSame";
            this.btnObjSame.Size = new System.Drawing.Size(60, 23);
            this.btnObjSame.TabIndex = 43;
            this.btnObjSame.Text = "Выбор";
            this.btnObjSame.UseVisualStyleBackColor = true;
            this.btnObjSame.Click += new System.EventHandler(this.btnObjSame_Click);
            // 
            // txtObjectSame
            // 
            this.txtObjectSame.Location = new System.Drawing.Point(406, 99);
            this.txtObjectSame.Name = "txtObjectSame";
            this.txtObjectSame.Size = new System.Drawing.Size(185, 20);
            this.txtObjectSame.TabIndex = 42;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Минус:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(label14);
            this.groupBox3.Controls.Add(this.abnServicingComboBox);
            this.groupBox3.Controls.Add(this.cmbConsumer);
            this.groupBox3.Controls.Add(this.cmbConsumerGroup);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtSubNetComment);
            this.groupBox3.Controls.Add(this.cbxSubNet);
            this.groupBox3.Controls.Add(commentLabel);
            this.groupBox3.Controls.Add(this.TariffcomboBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.abnSaleComboBox);
            this.groupBox3.Controls.Add(this.txtComment);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(abnSaleLabel);
            this.groupBox3.Controls.Add(this.labelTariff);
            this.groupBox3.Controls.Add(this.dateTimePickerDateChange);
            this.groupBox3.Controls.Add(this.AbnNetComboBox);
            this.groupBox3.Controls.Add(this.statusNameComboBox);
            this.groupBox3.Controls.Add(this.categoryComboBox);
            this.groupBox3.Controls.Add(statusNameLabel);
            this.groupBox3.Controls.Add(categoryLabel);
            this.groupBox3.Location = new System.Drawing.Point(11, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 322);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Экономические ";
            // 
            // abnServicingComboBox
            // 
            this.abnServicingComboBox.DisplayMember = "vAbnSale.id";
            this.abnServicingComboBox.FormattingEnabled = true;
            this.abnServicingComboBox.Location = new System.Drawing.Point(200, 69);
            this.abnServicingComboBox.Name = "abnServicingComboBox";
            this.abnServicingComboBox.Size = new System.Drawing.Size(434, 21);
            this.abnServicingComboBox.TabIndex = 52;
            this.abnServicingComboBox.ValueMember = "vAbnSale.id";
            this.abnServicingComboBox.TextChanged += new System.EventHandler(this.abnServicingComboBox_TextChanged);
            // 
            // cmbConsumer
            // 
            this.cmbConsumer.DataSource = this.bsConsumer;
            this.cmbConsumer.DisplayMember = "Name";
            this.cmbConsumer.FormattingEnabled = true;
            this.cmbConsumer.Location = new System.Drawing.Point(169, 214);
            this.cmbConsumer.Name = "cmbConsumer";
            this.cmbConsumer.Size = new System.Drawing.Size(465, 21);
            this.cmbConsumer.TabIndex = 51;
            this.cmbConsumer.ValueMember = "Id";
            // 
            // bsConsumer
            // 
            this.bsConsumer.DataMember = "tR_Classifier_Consumer";
            this.bsConsumer.DataSource = this.dsLObj;
            // 
            // dsLObj
            // 
            this.dsLObj.DataSetName = "DataSetLObj";
            this.dsLObj.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbConsumerGroup
            // 
            this.cmbConsumerGroup.DataSource = this.bsConsumerGroup;
            this.cmbConsumerGroup.DisplayMember = "Name";
            this.cmbConsumerGroup.FormattingEnabled = true;
            this.cmbConsumerGroup.Location = new System.Drawing.Point(169, 186);
            this.cmbConsumerGroup.Name = "cmbConsumerGroup";
            this.cmbConsumerGroup.Size = new System.Drawing.Size(465, 21);
            this.cmbConsumerGroup.TabIndex = 50;
            this.cmbConsumerGroup.ValueMember = "Id";
            this.cmbConsumerGroup.SelectedIndexChanged += new System.EventHandler(this.cmbConsumerGroup_SelectedIndexChanged);
            // 
            // bsConsumerGroup
            // 
            this.bsConsumerGroup.DataMember = "tR_Classifier_ConsumerGroup";
            this.bsConsumerGroup.DataSource = this.dsLObj;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Состав группы:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Группа потребителя:";
            // 
            // txtSubNetComment
            // 
            this.txtSubNetComment.Location = new System.Drawing.Point(169, 96);
            this.txtSubNetComment.MaxLength = 99;
            this.txtSubNetComment.Name = "txtSubNetComment";
            this.txtSubNetComment.Size = new System.Drawing.Size(465, 20);
            this.txtSubNetComment.TabIndex = 47;
            // 
            // cbxSubNet
            // 
            this.cbxSubNet.AutoSize = true;
            this.cbxSubNet.Location = new System.Drawing.Point(3, 98);
            this.cbxSubNet.Name = "cbxSubNet";
            this.cbxSubNet.Size = new System.Drawing.Size(138, 17);
            this.cbxSubNet.TabIndex = 46;
            this.cbxSubNet.Text = "Опосред. присоед:";
            this.cbxSubNet.UseVisualStyleBackColor = true;
            // 
            // TariffcomboBox
            // 
            this.TariffcomboBox.DataSource = this.bsTariff;
            this.TariffcomboBox.DisplayMember = "SocrName";
            this.TariffcomboBox.FormattingEnabled = true;
            this.TariffcomboBox.Location = new System.Drawing.Point(169, 149);
            this.TariffcomboBox.Name = "TariffcomboBox";
            this.TariffcomboBox.Size = new System.Drawing.Size(465, 21);
            this.TariffcomboBox.TabIndex = 45;
            this.TariffcomboBox.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Сетевая организация:";
            // 
            // abnSaleComboBox
            // 
            this.abnSaleComboBox.DataSource = this.dsAbn;
            this.abnSaleComboBox.DisplayMember = "vAbnSale.Name";
            this.abnSaleComboBox.FormattingEnabled = true;
            this.abnSaleComboBox.Location = new System.Drawing.Point(200, 46);
            this.abnSaleComboBox.Name = "abnSaleComboBox";
            this.abnSaleComboBox.Size = new System.Drawing.Size(434, 21);
            this.abnSaleComboBox.TabIndex = 27;
            this.abnSaleComboBox.ValueMember = "vAbnSale.id";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(169, 273);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(465, 40);
            this.txtComment.TabIndex = 43;
            this.txtComment.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(56, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Дата изменения:";
            // 
            // labelTariff
            // 
            this.labelTariff.AutoSize = true;
            this.labelTariff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTariff.Location = new System.Drawing.Point(115, 152);
            this.labelTariff.Name = "labelTariff";
            this.labelTariff.Size = new System.Drawing.Size(49, 13);
            this.labelTariff.TabIndex = 44;
            this.labelTariff.Text = "Тариф:";
            // 
            // dateTimePickerDateChange
            // 
            this.dateTimePickerDateChange.Enabled = false;
            this.dateTimePickerDateChange.Location = new System.Drawing.Point(169, 247);
            this.dateTimePickerDateChange.Name = "dateTimePickerDateChange";
            this.dateTimePickerDateChange.Size = new System.Drawing.Size(203, 20);
            this.dateTimePickerDateChange.TabIndex = 22;
            // 
            // AbnNetComboBox
            // 
            this.AbnNetComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AbnNetComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AbnNetComboBox.DataSource = this.dsAbn;
            this.AbnNetComboBox.DisplayMember = "vAbnNet.Name";
            this.AbnNetComboBox.FormattingEnabled = true;
            this.AbnNetComboBox.Location = new System.Drawing.Point(200, 19);
            this.AbnNetComboBox.Name = "AbnNetComboBox";
            this.AbnNetComboBox.Size = new System.Drawing.Size(434, 21);
            this.AbnNetComboBox.TabIndex = 24;
            this.AbnNetComboBox.ValueMember = "vAbnNet.id";
            // 
            // statusNameComboBox
            // 
            this.statusNameComboBox.DataSource = this.dsAbn;
            this.statusNameComboBox.DisplayMember = "vAbnObjStatus.Name";
            this.statusNameComboBox.FormattingEnabled = true;
            this.statusNameComboBox.Location = new System.Drawing.Point(169, 122);
            this.statusNameComboBox.Name = "statusNameComboBox";
            this.statusNameComboBox.Size = new System.Drawing.Size(260, 21);
            this.statusNameComboBox.TabIndex = 29;
            this.statusNameComboBox.ValueMember = "vAbnObjStatus.Id";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(511, 122);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(123, 21);
            this.categoryComboBox.TabIndex = 31;
            // 
            // txtParent
            // 
            this.txtParent.Location = new System.Drawing.Point(85, 99);
            this.txtParent.Name = "txtParent";
            this.txtParent.Size = new System.Drawing.Size(195, 20);
            this.txtParent.TabIndex = 38;
            // 
            // txtCodeAbonent
            // 
            this.txtCodeAbonent.Location = new System.Drawing.Point(87, 73);
            this.txtCodeAbonent.Name = "txtCodeAbonent";
            this.txtCodeAbonent.Size = new System.Drawing.Size(60, 20);
            this.txtCodeAbonent.TabIndex = 37;
            this.txtCodeAbonent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtAbn
            // 
            this.txtAbn.Location = new System.Drawing.Point(153, 73);
            this.txtAbn.Name = "txtAbn";
            this.txtAbn.Size = new System.Drawing.Size(304, 20);
            this.txtAbn.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(113, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(537, 20);
            this.txtName.TabIndex = 31;
            // 
            // cmbWorker
            // 
            this.cmbWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsAbn, "tAbnObj.idWorker", true));
            this.cmbWorker.DataSource = this.bsWorkers;
            this.cmbWorker.DisplayMember = "FIO";
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(524, 72);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(126, 21);
            this.cmbWorker.TabIndex = 33;
            this.cmbWorker.ValueMember = "id";
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.label19);
            this.groupBoxAddress.Controls.Add(this.txtAddressComment);
            this.groupBoxAddress.Controls.Add(this.cmbRaionObl);
            this.groupBoxAddress.Controls.Add(this.labelRaionObl);
            this.groupBoxAddress.Controls.Add(this.labelObl);
            this.groupBoxAddress.Controls.Add(this.cmbObl);
            this.groupBoxAddress.Controls.Add(this.txtIndex);
            this.groupBoxAddress.Controls.Add(this.labelIndex);
            this.groupBoxAddress.Controls.Add(this.txtHousePrefix);
            this.groupBoxAddress.Controls.Add(this.labelCity);
            this.groupBoxAddress.Controls.Add(this.labelHousePrefix);
            this.groupBoxAddress.Controls.Add(this.cmbCity);
            this.groupBoxAddress.Controls.Add(this.txtHouse);
            this.groupBoxAddress.Controls.Add(this.labelRaionCity);
            this.groupBoxAddress.Controls.Add(this.labelHouse);
            this.groupBoxAddress.Controls.Add(this.cmbRaionCity);
            this.groupBoxAddress.Controls.Add(this.cmbStreet);
            this.groupBoxAddress.Controls.Add(this.labelStreet);
            this.groupBoxAddress.Location = new System.Drawing.Point(11, 127);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(646, 123);
            this.groupBoxAddress.TabIndex = 29;
            this.groupBoxAddress.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Комментарий:";
            // 
            // txtAddressComment
            // 
            this.txtAddressComment.Location = new System.Drawing.Point(113, 99);
            this.txtAddressComment.Name = "txtAddressComment";
            this.txtAddressComment.Size = new System.Drawing.Size(521, 20);
            this.txtAddressComment.TabIndex = 16;
            // 
            // cmbRaionObl
            // 
            this.cmbRaionObl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRaionObl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRaionObl.DataSource = this.dsRaionObl;
            this.cmbRaionObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbRaionObl.FormattingEnabled = true;
            this.cmbRaionObl.Location = new System.Drawing.Point(290, 30);
            this.cmbRaionObl.Name = "cmbRaionObl";
            this.cmbRaionObl.Size = new System.Drawing.Size(166, 21);
            this.cmbRaionObl.TabIndex = 3;
            this.cmbRaionObl.ValueMember = "tR_KladrObj.Id";
            this.cmbRaionObl.SelectedIndexChanged += new System.EventHandler(this.cmbRaionObl_SelectedIndexChanged);
            // 
            // labelRaionObl
            // 
            this.labelRaionObl.AutoSize = true;
            this.labelRaionObl.Location = new System.Drawing.Point(287, 14);
            this.labelRaionObl.Name = "labelRaionObl";
            this.labelRaionObl.Size = new System.Drawing.Size(83, 13);
            this.labelRaionObl.TabIndex = 2;
            this.labelRaionObl.Text = "Район/город";
            // 
            // labelObl
            // 
            this.labelObl.AutoSize = true;
            this.labelObl.Location = new System.Drawing.Point(110, 13);
            this.labelObl.Name = "labelObl";
            this.labelObl.Size = new System.Drawing.Size(57, 13);
            this.labelObl.TabIndex = 0;
            this.labelObl.Text = "Область";
            // 
            // cmbObl
            // 
            this.cmbObl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbObl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbObl.DataSource = this.dsObl;
            this.cmbObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbObl.FormattingEnabled = true;
            this.cmbObl.Location = new System.Drawing.Point(113, 29);
            this.cmbObl.Name = "cmbObl";
            this.cmbObl.Size = new System.Drawing.Size(166, 21);
            this.cmbObl.TabIndex = 1;
            this.cmbObl.ValueMember = "tR_KladrObj.Id";
            this.cmbObl.SelectedIndexChanged += new System.EventHandler(this.cmbObl_SelectedIndexChanged);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(6, 29);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(92, 20);
            this.txtIndex.TabIndex = 15;
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(3, 13);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(51, 13);
            this.labelIndex.TabIndex = 14;
            this.labelIndex.Text = "Индекс";
            // 
            // txtHousePrefix
            // 
            this.txtHousePrefix.Location = new System.Drawing.Point(560, 71);
            this.txtHousePrefix.Name = "txtHousePrefix";
            this.txtHousePrefix.Size = new System.Drawing.Size(74, 20);
            this.txtHousePrefix.TabIndex = 13;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(110, 54);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(118, 13);
            this.labelCity.TabIndex = 4;
            this.labelCity.Text = "Населенный пункт";
            // 
            // labelHousePrefix
            // 
            this.labelHousePrefix.AutoSize = true;
            this.labelHousePrefix.Location = new System.Drawing.Point(557, 55);
            this.labelHousePrefix.Name = "labelHousePrefix";
            this.labelHousePrefix.Size = new System.Drawing.Size(60, 13);
            this.labelHousePrefix.TabIndex = 12;
            this.labelHousePrefix.Text = "Префикс";
            // 
            // cmbCity
            // 
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.DataSource = this.dsPunkts;
            this.cmbCity.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(113, 70);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(166, 21);
            this.cmbCity.TabIndex = 5;
            this.cmbCity.ValueMember = "tR_KladrObj.Id";
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // txtHouse
            // 
            this.txtHouse.Location = new System.Drawing.Point(468, 71);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(73, 20);
            this.txtHouse.TabIndex = 11;
            // 
            // labelRaionCity
            // 
            this.labelRaionCity.AutoSize = true;
            this.labelRaionCity.Location = new System.Drawing.Point(287, 54);
            this.labelRaionCity.Name = "labelRaionCity";
            this.labelRaionCity.Size = new System.Drawing.Size(88, 13);
            this.labelRaionCity.TabIndex = 6;
            this.labelRaionCity.Text = "Район города";
            // 
            // labelHouse
            // 
            this.labelHouse.AutoSize = true;
            this.labelHouse.Location = new System.Drawing.Point(465, 55);
            this.labelHouse.Name = "labelHouse";
            this.labelHouse.Size = new System.Drawing.Size(33, 13);
            this.labelHouse.TabIndex = 10;
            this.labelHouse.Text = "Дом";
            // 
            // cmbRaionCity
            // 
            this.cmbRaionCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRaionCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRaionCity.DataSource = this.dsRaionCity;
            this.cmbRaionCity.DisplayMember = "tR_Classifier.Name";
            this.cmbRaionCity.FormattingEnabled = true;
            this.cmbRaionCity.Location = new System.Drawing.Point(290, 70);
            this.cmbRaionCity.Name = "cmbRaionCity";
            this.cmbRaionCity.Size = new System.Drawing.Size(166, 21);
            this.cmbRaionCity.TabIndex = 7;
            this.cmbRaionCity.ValueMember = "tR_Classifier.Id";
            // 
            // cmbStreet
            // 
            this.cmbStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStreet.DataSource = this.dsStreet;
            this.cmbStreet.DisplayMember = "tR_KladrStreet.NameSocr";
            this.cmbStreet.FormattingEnabled = true;
            this.cmbStreet.Location = new System.Drawing.Point(468, 30);
            this.cmbStreet.Name = "cmbStreet";
            this.cmbStreet.Size = new System.Drawing.Size(166, 21);
            this.cmbStreet.TabIndex = 9;
            this.cmbStreet.ValueMember = "tR_KladrStreet.Id";
            this.cmbStreet.SelectedIndexChanged += new System.EventHandler(this.cmbStreet_SelectedIndexChanged);
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(465, 14);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(44, 13);
            this.labelStreet.TabIndex = 8;
            this.labelStreet.Text = "Улица";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPageODS);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(675, 607);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPageODS
            // 
            this.tabPageODS.Controls.Add(this.panel2);
            this.tabPageODS.Controls.Add(this.txtCommentODS);
            this.tabPageODS.Controls.Add(this.label18);
            this.tabPageODS.Location = new System.Drawing.Point(4, 22);
            this.tabPageODS.Name = "tabPageODS";
            this.tabPageODS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageODS.Size = new System.Drawing.Size(667, 581);
            this.tabPageODS.TabIndex = 5;
            this.tabPageODS.Text = "ОДС";
            this.tabPageODS.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.txtNumDocActApprovalReservation);
            this.panel2.Controls.Add(this.txtEmergencyReserv);
            this.panel2.Controls.Add(this.dtpDateDocActApprovalReservation);
            this.panel2.Controls.Add(this.txtTechnologicalReserv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 349);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 229);
            this.panel2.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(299, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "от";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(300, 94);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(28, 13);
            this.label26.TabIndex = 8;
            this.label26.Text = "кВт";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(10, 91);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(153, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Технологическая  броня";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(300, 61);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 13);
            this.label24.TabIndex = 8;
            this.label24.Text = "кВт";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(10, 58);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(110, 13);
            this.label22.TabIndex = 8;
            this.label22.Text = "Аварийная броня";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(10, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(172, 43);
            this.label20.TabIndex = 8;
            this.label20.Text = "Акт согласования технологической и аварийной брони";
            // 
            // txtNumDocActApprovalReservation
            // 
            this.txtNumDocActApprovalReservation.Location = new System.Drawing.Point(188, 15);
            this.txtNumDocActApprovalReservation.Name = "txtNumDocActApprovalReservation";
            this.txtNumDocActApprovalReservation.Size = new System.Drawing.Size(100, 20);
            this.txtNumDocActApprovalReservation.TabIndex = 7;
            // 
            // txtEmergencyReserv
            // 
            this.txtEmergencyReserv.Location = new System.Drawing.Point(191, 58);
            this.txtEmergencyReserv.Name = "txtEmergencyReserv";
            this.txtEmergencyReserv.Size = new System.Drawing.Size(100, 20);
            this.txtEmergencyReserv.TabIndex = 5;
            this.txtEmergencyReserv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // dtpDateDocActApprovalReservation
            // 
            this.dtpDateDocActApprovalReservation.Location = new System.Drawing.Point(325, 15);
            this.dtpDateDocActApprovalReservation.Name = "dtpDateDocActApprovalReservation";
            this.dtpDateDocActApprovalReservation.Size = new System.Drawing.Size(147, 20);
            this.dtpDateDocActApprovalReservation.TabIndex = 2;
            // 
            // txtTechnologicalReserv
            // 
            this.txtTechnologicalReserv.Location = new System.Drawing.Point(191, 91);
            this.txtTechnologicalReserv.Name = "txtTechnologicalReserv";
            this.txtTechnologicalReserv.Size = new System.Drawing.Size(100, 20);
            this.txtTechnologicalReserv.TabIndex = 4;
            this.txtTechnologicalReserv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtCommentODS
            // 
            this.txtCommentODS.AcceptsTab = true;
            this.txtCommentODS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommentODS.Location = new System.Drawing.Point(0, 19);
            this.txtCommentODS.Name = "txtCommentODS";
            this.txtCommentODS.Size = new System.Drawing.Size(667, 324);
            this.txtCommentODS.TabIndex = 1;
            this.txtCommentODS.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(165, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Доп информация для ОДС";
            // 
            // FormObjAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(674, 652);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormObjAE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormObjAE_FormClosing);
            this.Load += new System.EventHandler(this.FormObjAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRaionObl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableObl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPunkts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRaionCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClassifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTariff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorkers)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImages)).EndInit();
            this.toolStripImage.ResumeLayout(false);
            this.toolStripImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanDoc)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabControlLuinkSchmAbnObj.ResumeLayout(false);
            this.tabPageLinkSchmAbnObj.ResumeLayout(false);
            this.tabPageLinkSchmAbnObj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkSchmAbnObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLinkSchmAbnObj)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripLinkSchmAbnObj.ResumeLayout(false);
            this.toolStripLinkSchmAbnObj.PerformLayout();
            this.tabPageOldLinkSchmAbnObj.ResumeLayout(false);
            this.tabPageOldLinkSchmAbnObj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTP)).EndInit();
            this.toolStripTP.ResumeLayout(false);
            this.toolStripTP.PerformLayout();
            this.groupBoxLoss.ResumeLayout(false);
            this.groupBoxLoss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoss)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowerCalcNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerSetNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerOtherNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDateVidan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerFactNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNumRazr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KLossNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegimeNUD)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsConsumer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLObj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsConsumerGroup)).EndInit();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageODS.ResumeLayout(false);
            this.tabPageODS.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet.DataSetAbn dsAbn;
        private System.Data.DataSet dsRaionObl;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataSet dsObl;
        private System.Data.DataTable dataTableObl;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataSet dsPunkts;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataSet dsRaionCity;
        private System.Data.DataTable dataTableClassifier;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataSet dsStreet;
        private System.Data.DataTable dataTable3;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn19;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.BindingSource bsWorkers;
        private System.Windows.Forms.BindingSource bsTariff;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImage;
        private System.Windows.Forms.TabPage tabPage5;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewImages;
        private System.Windows.Forms.ToolStrip toolStripImage;
        private System.Windows.Forms.ToolStripButton tsbImage;
        private System.Windows.Forms.ToolStripButton tsbRemoveImage;
        private System.Windows.Forms.ToolStripButton tsbSaveImage;
        private System.Windows.Forms.PictureBox pbScanDoc;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtDatePowerFact;
        private System.Windows.Forms.NumericUpDown PowerSetNUD;
        private System.Windows.Forms.DateTimePicker dtDateTU;
        private System.Windows.Forms.MaskedTextBox txtNumberTU;
        private System.Windows.Forms.NumericUpDown PowerOtherNUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDateTP;
        private System.Windows.Forms.NumericUpDown PowerFactNUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbNumberTP;
        private System.Windows.Forms.CheckBox cbxCalcLoss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown KLossNUD;
        private System.Windows.Forms.NumericUpDown RegimeNUD;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox TariffcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox abnSaleComboBox;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTariff;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateChange;
        private System.Windows.Forms.ComboBox AbnNetComboBox;
        private System.Windows.Forms.ComboBox statusNameComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox txtParent;
        private System.Windows.Forms.TextBox txtCodeAbonent;
        private System.Windows.Forms.TextBox txtAbn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbWorker;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.ComboBox cmbRaionObl;
        private System.Windows.Forms.Label labelRaionObl;
        private System.Windows.Forms.Label labelObl;
        private System.Windows.Forms.ComboBox cmbObl;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.TextBox txtHousePrefix;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelHousePrefix;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.Label labelRaionCity;
        private System.Windows.Forms.Label labelHouse;
        private System.Windows.Forms.ComboBox cmbRaionCity;
        private System.Windows.Forms.ComboBox cmbStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewImageColumn image;
        private System.Windows.Forms.DataGridViewImageColumn ImageOriginal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Compressed;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.BindingSource bsNumRazr;
        private System.Windows.Forms.BindingSource bsDateVidan;
        private System.Windows.Forms.Button btnObjSame;
        private System.Windows.Forms.TextBox txtObjectSame;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonKLossTrans;
        private System.Windows.Forms.DataGridView dgvLoss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Month;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TextBox txtSubNetComment;
        private System.Windows.Forms.CheckBox cbxSubNet;
        private System.Windows.Forms.DataGridView dgvTP;
        private System.Windows.Forms.BindingSource bsTP;
        private System.Windows.Forms.ToolStrip toolStripTP;
        private System.Windows.Forms.ToolStripButton tsbNewTP;
        private System.Windows.Forms.ToolStripButton tsbEditTP;
        private System.Windows.Forms.ToolStripButton tsbDelTP;
        private System.Windows.Forms.GroupBox groupBoxLoss;
        private System.Windows.Forms.ComboBox cmbConsumer;
        private System.Windows.Forms.ComboBox cmbConsumerGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DataSet.DataSetLObj dsLObj;
        private System.Windows.Forms.BindingSource bsConsumerGroup;
        private System.Windows.Forms.BindingSource bsConsumer;
        private System.Windows.Forms.Button btnMeasur;
        private System.Windows.Forms.Label label6;
        private DataSet.dsObj dsObj1;
        private System.Windows.Forms.DateTimePicker dtMeasurDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMeasurAverage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource bsMeasur;
        private System.Windows.Forms.TabControl tabControlLuinkSchmAbnObj;
        private System.Windows.Forms.TabPage tabPageLinkSchmAbnObj;
        private System.Windows.Forms.TabPage tabPageOldLinkSchmAbnObj;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvLinkSchmAbnObj;
        private System.Windows.Forms.ToolStrip toolStripLinkSchmAbnObj;
        private System.Windows.Forms.ToolStripButton toolBtnAddLinkSchmAbnObj;
        private System.Windows.Forms.ToolStripButton toolBtnDelLinkSchmAbnObj;
        private System.Windows.Forms.BindingSource bindingSourceLinkSchmAbnObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn idxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameCenter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameGroupDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameShinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataModDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pitSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pitNomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthKabDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn signLowVoltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rubilnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown PowerCalcNUD;
        private System.Windows.Forms.ComboBox abnServicingComboBox;
        private System.Windows.Forms.Button btnNewName;
        private System.Windows.Forms.Button btnCopyName;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn schmObjNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLinkSchmAbnDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSchmObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDocDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDocNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumberDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDateDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOwnerDgvColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOwnerDgvColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delDocDgvColumn;
        private System.Windows.Forms.TabPage tabPageODS;
        private System.Windows.Forms.RichTextBox txtCommentODS;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAddressComment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNumDocActApprovalReservation;
        private System.Windows.Forms.TextBox txtEmergencyReserv;
        private System.Windows.Forms.DateTimePicker dtpDateDocActApprovalReservation;
        private System.Windows.Forms.TextBox txtTechnologicalReserv;
    }
}