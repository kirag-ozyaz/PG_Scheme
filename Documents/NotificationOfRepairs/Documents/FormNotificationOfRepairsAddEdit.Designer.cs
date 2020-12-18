
	public partial class FormNotificationOfRepairsAddEdit : FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRequestFiled = new System.Windows.Forms.Label();
            this.labelSR = new System.Windows.Forms.Label();
            this.cmbSR = new System.Windows.Forms.ComboBox();
            this.DataSetNotifications = new NotificationOfRepairs.DataSets.DataSetNotifications();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshUploadParentDoc = new System.Windows.Forms.Button();
            this.btnOpenParentDamage = new System.Windows.Forms.Button();
            this.buttonChooseParentDamage = new System.Windows.Forms.Button();
            this.txtParentDamage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.labelObject = new System.Windows.Forms.Label();
            this.groupBoxDaily = new System.Windows.Forms.GroupBox();
            this.buttonDaily = new System.Windows.Forms.Button();
            this.checkBoxWeekEnd = new System.Windows.Forms.CheckBox();
            this.checkBoxDaily = new System.Windows.Forms.CheckBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerBeg = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDaily = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBegDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn();
            this.dateEndDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn();
            this.buttonOK = new System.Windows.Forms.Button();
            this.cmbUserCreate = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateCreate = new ControlsLbr.NullableDateTimePicker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.groupBoxTextNotification = new System.Windows.Forms.GroupBox();
            this.txtNotification = new System.Windows.Forms.RichTextBox();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.txtRequestFiled = new System.Windows.Forms.ComboBox();
            this.tabPageAbn = new System.Windows.Forms.TabPage();
            this.splitContainerAbn = new System.Windows.Forms.SplitContainer();
            this.dgvAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
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
            this.dataColumnPowerSet = new System.Data.DataColumn();
            this.dataColumncountPoint = new System.Data.DataColumn();
            this.dataColumnidSchmObj = new System.Data.DataColumn();
            this.dataColumnKladrObjId = new System.Data.DataColumn();
            this.dataColumnidStreet = new System.Data.DataColumn();
            this.dataColumnhouse = new System.Data.DataColumn();
            this.dataColumnTypeNotification = new System.Data.DataColumn();
            this.dataColumnSourceUserNotification = new System.Data.DataColumn();
            this.dataColumnSourceNotification = new System.Data.DataColumn();
            this.dataColumnTargetNotification = new System.Data.DataColumn();
            this.dataColumnStatusNotification = new System.Data.DataColumn();
            this.dataColumnIdTypeNotification = new System.Data.DataColumn();
            this.dataColumnIdStatusNotification = new System.Data.DataColumn();
            this.dataColumnIdAddress = new System.Data.DataColumn();
            this.splitContainerAbnCount = new System.Windows.Forms.SplitContainer();
            this.numCountPointSource = new System.Windows.Forms.NumericUpDown();
            this.numCountPointEE = new System.Windows.Forms.NumericUpDown();
            this.numCountPointCat3 = new System.Windows.Forms.NumericUpDown();
            this.groupBoxAbnObj1Catergory = new System.Windows.Forms.GroupBox();
            this.numCountPointCat1 = new System.Windows.Forms.NumericUpDown();
            this.numCountPointCat1Full = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
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
            this.toolBtnAddAbn = new System.Windows.Forms.ToolStripButton();
            this.toolBrnDelAbn = new System.Windows.Forms.ToolStripButton();
            this.toolBtnRefreshAbn = new System.Windows.Forms.ToolStripButton();
            this.tabPageDocuments = new System.Windows.Forms.TabPage();
            this.dgvDocs = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumnDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
            this.bsRequestForRepairDoc = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripDocuments = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnViewDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSaveDoc = new System.Windows.Forms.ToolStripButton();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.dataGridViewExcelFilter1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dateLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRequestForRepairLog = new System.Windows.Forms.BindingSource(this.components);
            this.bsLinkObjects = new System.Windows.Forms.BindingSource(this.components);
            this.dsLinkObjects = new System.Data.DataSet();
            this.tableLinkObjects = new System.Data.DataTable();
            this.dataColumn25 = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.tableRequestForReapirDoc = new System.Data.DataTable();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.tableAddress = new System.Data.DataTable();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.bsAddress = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransON = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTree = new ControlsLbr.TreeDataGridView();
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
            this.buttonCopy = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.bsRequestForRepair = new System.Windows.Forms.BindingSource(this.components);
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Адресс = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAbnDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameObjDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeAbnDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterComboBoxColumn();
            this.SourceUserNotification = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.TypeNotification = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterComboBoxColumn();
            this.SourceNotification = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.TargetNotification = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.StatusNotification = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterComboBoxColumn();
            this.categoryNameDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.powerSetDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countPointDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.commentODSDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idStatusNotification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTypeNotification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNotifications)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.groupBoxTextNotification.SuspendLayout();
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
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat1Full)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCountAbnObjCat2Full)).BeginInit();
            this.statusStripAbnObj.SuspendLayout();
            this.toolStripAbn.SuspendLayout();
            this.tabPageDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepairDoc)).BeginInit();
            this.toolStripDocuments.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepairLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRequestForReapirDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepair)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автор";
            // 
            // labelRequestFiled
            // 
            this.labelRequestFiled.AutoSize = true;
            this.labelRequestFiled.Location = new System.Drawing.Point(8, 66);
            this.labelRequestFiled.Name = "labelRequestFiled";
            this.labelRequestFiled.Size = new System.Drawing.Size(76, 13);
            this.labelRequestFiled.TabIndex = 4;
            this.labelRequestFiled.Text = "Заявку подал";
            // 
            // labelSR
            // 
            this.labelSR.AutoSize = true;
            this.labelSR.Location = new System.Drawing.Point(305, 39);
            this.labelSR.Name = "labelSR";
            this.labelSR.Size = new System.Drawing.Size(38, 13);
            this.labelSR.TabIndex = 6;
            this.labelSR.Text = "Район";
            // 
            // cmbSR
            // 
            this.cmbSR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSR.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.DataSetNotifications, "tJ_NotificationOfRepairs.idSR", true));
            this.cmbSR.FormattingEnabled = true;
            this.cmbSR.Location = new System.Drawing.Point(358, 36);
            this.cmbSR.Name = "cmbSR";
            this.cmbSR.Size = new System.Drawing.Size(518, 21);
            this.cmbSR.TabIndex = 7;
            this.cmbSR.SelectedIndexChanged += new System.EventHandler(this.cmbSR_SelectedIndexChanged);
            this.cmbSR.SelectedValueChanged += new System.EventHandler(this.cmbSR_SelectedValueChanged);
            // 
            // DataSetNotifications
            // 
            this.DataSetNotifications.DataSetName = "DataSetGES";
            this.DataSetNotifications.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRefreshUploadParentDoc);
            this.groupBox1.Controls.Add(this.btnOpenParentDamage);
            this.groupBox1.Controls.Add(this.buttonChooseParentDamage);
            this.groupBox1.Controls.Add(this.txtParentDamage);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtObject);
            this.groupBox1.Controls.Add(this.labelObject);
            this.groupBox1.Location = new System.Drawing.Point(11, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 70);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnRefreshUploadParentDoc
            // 
            this.btnRefreshUploadParentDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshUploadParentDoc.Image = global::NotificationOfRepairs.Properties.Resources.refresh_16;
            this.btnRefreshUploadParentDoc.Location = new System.Drawing.Point(834, 40);
            this.btnRefreshUploadParentDoc.Name = "btnRefreshUploadParentDoc";
            this.btnRefreshUploadParentDoc.Size = new System.Drawing.Size(26, 23);
            this.btnRefreshUploadParentDoc.TabIndex = 11;
            this.btnRefreshUploadParentDoc.Text = "...";
            this.btnRefreshUploadParentDoc.UseVisualStyleBackColor = true;
            // 
            // btnOpenParentDamage
            // 
            this.btnOpenParentDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenParentDamage.BackgroundImage = global::NotificationOfRepairs.Properties.Resources.ElementInformation;
            this.btnOpenParentDamage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenParentDamage.Location = new System.Drawing.Point(806, 40);
            this.btnOpenParentDamage.Name = "btnOpenParentDamage";
            this.btnOpenParentDamage.Size = new System.Drawing.Size(26, 23);
            this.btnOpenParentDamage.TabIndex = 10;
            this.btnOpenParentDamage.UseVisualStyleBackColor = true;
            // 
            // buttonChooseParentDamage
            // 
            this.buttonChooseParentDamage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChooseParentDamage.Location = new System.Drawing.Point(778, 40);
            this.buttonChooseParentDamage.Name = "buttonChooseParentDamage";
            this.buttonChooseParentDamage.Size = new System.Drawing.Size(26, 23);
            this.buttonChooseParentDamage.TabIndex = 9;
            this.buttonChooseParentDamage.Text = "...";
            this.buttonChooseParentDamage.UseVisualStyleBackColor = true;
            // 
            // txtParentDamage
            // 
            this.txtParentDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParentDamage.BackColor = System.Drawing.SystemColors.Window;
            this.txtParentDamage.Location = new System.Drawing.Point(131, 40);
            this.txtParentDamage.Name = "txtParentDamage";
            this.txtParentDamage.ReadOnly = true;
            this.txtParentDamage.Size = new System.Drawing.Size(641, 20);
            this.txtParentDamage.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Документ плановых \r\nработ";
            // 
            // txtObject
            // 
            this.txtObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObject.Location = new System.Drawing.Point(101, 16);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(758, 20);
            this.txtObject.TabIndex = 1;
            this.txtObject.TextChanged += new System.EventHandler(this.txtObject_TextChanged);
            // 
            // labelObject
            // 
            this.labelObject.AutoSize = true;
            this.labelObject.Location = new System.Drawing.Point(6, 16);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(45, 13);
            this.labelObject.TabIndex = 0;
            this.labelObject.Text = "Объект";
            // 
            // groupBoxDaily
            // 
            this.groupBoxDaily.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDaily.Controls.Add(this.buttonDaily);
            this.groupBoxDaily.Controls.Add(this.checkBoxWeekEnd);
            this.groupBoxDaily.Controls.Add(this.checkBoxDaily);
            this.groupBoxDaily.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxDaily.Controls.Add(this.label9);
            this.groupBoxDaily.Controls.Add(this.dateTimePickerBeg);
            this.groupBoxDaily.Controls.Add(this.label8);
            this.groupBoxDaily.Controls.Add(this.dgvDaily);
            this.groupBoxDaily.Location = new System.Drawing.Point(11, 161);
            this.groupBoxDaily.Name = "groupBoxDaily";
            this.groupBoxDaily.Size = new System.Drawing.Size(865, 167);
            this.groupBoxDaily.TabIndex = 10;
            this.groupBoxDaily.TabStop = false;
            this.groupBoxDaily.Text = "Даты отключения";
            this.groupBoxDaily.Enter += new System.EventHandler(this.groupBoxDaily_Enter);
            // 
            // buttonDaily
            // 
            this.buttonDaily.Location = new System.Drawing.Point(10, 115);
            this.buttonDaily.Name = "buttonDaily";
            this.buttonDaily.Size = new System.Drawing.Size(75, 23);
            this.buttonDaily.TabIndex = 20;
            this.buttonDaily.Text = "Добавить";
            this.buttonDaily.UseVisualStyleBackColor = true;
            this.buttonDaily.Click += new System.EventHandler(this.buttonDaily_Click);
            // 
            // checkBoxWeekEnd
            // 
            this.checkBoxWeekEnd.AutoSize = true;
            this.checkBoxWeekEnd.Checked = true;
            this.checkBoxWeekEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWeekEnd.Enabled = false;
            this.checkBoxWeekEnd.Location = new System.Drawing.Point(10, 92);
            this.checkBoxWeekEnd.Name = "checkBoxWeekEnd";
            this.checkBoxWeekEnd.Size = new System.Drawing.Size(78, 17);
            this.checkBoxWeekEnd.TabIndex = 19;
            this.checkBoxWeekEnd.Text = "Выходные";
            this.checkBoxWeekEnd.UseVisualStyleBackColor = true;
            // 
            // checkBoxDaily
            // 
            this.checkBoxDaily.AutoSize = true;
            this.checkBoxDaily.Location = new System.Drawing.Point(10, 69);
            this.checkBoxDaily.Name = "checkBoxDaily";
            this.checkBoxDaily.Size = new System.Drawing.Size(83, 17);
            this.checkBoxDaily.TabIndex = 18;
            this.checkBoxDaily.Text = "Ежедневно";
            this.checkBoxDaily.UseVisualStyleBackColor = true;
            this.checkBoxDaily.CheckedChanged += new System.EventHandler(this.checkBoxDaily_CheckedChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(31, 43);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(124, 20);
            this.dateTimePickerEnd.TabIndex = 15;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "по";
            // 
            // dateTimePickerBeg
            // 
            this.dateTimePickerBeg.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerBeg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBeg.Location = new System.Drawing.Point(31, 19);
            this.dateTimePickerBeg.Name = "dateTimePickerBeg";
            this.dateTimePickerBeg.Size = new System.Drawing.Size(124, 20);
            this.dateTimePickerBeg.TabIndex = 14;
            this.dateTimePickerBeg.ValueChanged += new System.EventHandler(this.dateTimePickerBeg_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "с";
            // 
            // dgvDaily
            // 
            this.dgvDaily.AllowUserToAddRows = false;
            this.dgvDaily.AllowUserToResizeColumns = false;
            this.dgvDaily.AllowUserToResizeRows = false;
            this.dgvDaily.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDaily.AutoGenerateColumns = false;
            this.dgvDaily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDaily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateBegDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn});
            this.dgvDaily.DataMember = "tJ_NotificationOfRepairsDaily";
            this.dgvDaily.DataSource = this.DataSetNotifications;
            this.dgvDaily.Location = new System.Drawing.Point(173, 19);
            this.dgvDaily.Name = "dgvDaily";
            this.dgvDaily.RowHeadersWidth = 30;
            this.dgvDaily.Size = new System.Drawing.Size(689, 142);
            this.dgvDaily.TabIndex = 12;
            this.dgvDaily.VirtualMode = true;
            this.dgvDaily.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDaily_CellEndEdit);
            this.dgvDaily.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDaily_CellFormatting);
            this.dgvDaily.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDaily_EditingControlShowing);
            this.dgvDaily.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDaily_RowsAdded);
            this.dgvDaily.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDaily_RowsRemoved);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateBegDataGridViewTextBoxColumn
            // 
            this.dateBegDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateBegDataGridViewTextBoxColumn.DataPropertyName = "dateBeg";
            dataGridViewCellStyle1.Format = "dd.MM.yyyy HH:mm";
            this.dateBegDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateBegDataGridViewTextBoxColumn.FillWeight = 50F;
            this.dateBegDataGridViewTextBoxColumn.HeaderText = "Начало";
            this.dateBegDataGridViewTextBoxColumn.Name = "dateBegDataGridViewTextBoxColumn";
            this.dateBegDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "dateEnd";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy HH:mm";
            this.dateEndDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateEndDataGridViewTextBoxColumn.FillWeight = 50F;
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "Окончание";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(15, 670);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // cmbUserCreate
            // 
            this.cmbUserCreate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.DataSetNotifications, "tJ_NotificationOfRepairs.idUserCreate", true));
            this.cmbUserCreate.Enabled = false;
            this.cmbUserCreate.FormattingEnabled = true;
            this.cmbUserCreate.Location = new System.Drawing.Point(101, 5);
            this.cmbUserCreate.Name = "cmbUserCreate";
            this.cmbUserCreate.Size = new System.Drawing.Size(181, 21);
            this.cmbUserCreate.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(302, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Номер";
            // 
            // txtNum
            // 
            this.txtNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSetNotifications, "tJ_NotificationOfRepairs.num", true));
            this.txtNum.Location = new System.Drawing.Point(358, 5);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(518, 20);
            this.txtNum.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Дата создания";
            // 
            // dtpDateCreate
            // 
            this.dtpDateCreate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateCreate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.DataSetNotifications, "tJ_NotificationOfRepairs.dateCreate", true));
            this.dtpDateCreate.Enabled = false;
            this.dtpDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateCreate.Location = new System.Drawing.Point(101, 37);
            this.dtpDateCreate.Name = "dtpDateCreate";
            this.dtpDateCreate.Size = new System.Drawing.Size(181, 20);
            this.dtpDateCreate.TabIndex = 17;
            this.dtpDateCreate.Value = new System.DateTime(2012, 10, 18, 8, 39, 41, 178);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tabPageAbn);
            this.tabControl.Controls.Add(this.tabPageDocuments);
            this.tabControl.Controls.Add(this.tabPageLog);
            this.tabControl.Location = new System.Drawing.Point(-4, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(896, 661);
            this.tabControl.TabIndex = 49;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.groupBoxTextNotification);
            this.tabPageGeneral.Controls.Add(this.cmbRegion);
            this.tabPageGeneral.Controls.Add(this.txtRequestFiled);
            this.tabPageGeneral.Controls.Add(this.cmbSR);
            this.tabPageGeneral.Controls.Add(this.label1);
            this.tabPageGeneral.Controls.Add(this.groupBoxDaily);
            this.tabPageGeneral.Controls.Add(this.labelRequestFiled);
            this.tabPageGeneral.Controls.Add(this.dtpDateCreate);
            this.tabPageGeneral.Controls.Add(this.label2);
            this.tabPageGeneral.Controls.Add(this.groupBox1);
            this.tabPageGeneral.Controls.Add(this.labelSR);
            this.tabPageGeneral.Controls.Add(this.cmbUserCreate);
            this.tabPageGeneral.Controls.Add(this.txtNum);
            this.tabPageGeneral.Controls.Add(this.label15);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(888, 635);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Общие";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // groupBoxTextNotification
            // 
            this.groupBoxTextNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTextNotification.Controls.Add(this.txtNotification);
            this.groupBoxTextNotification.Location = new System.Drawing.Point(11, 329);
            this.groupBoxTextNotification.Name = "groupBoxTextNotification";
            this.groupBoxTextNotification.Size = new System.Drawing.Size(865, 308);
            this.groupBoxTextNotification.TabIndex = 21;
            this.groupBoxTextNotification.TabStop = false;
            this.groupBoxTextNotification.Text = "Текст уведомления";
            // 
            // txtNotification
            // 
            this.txtNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotification.Location = new System.Drawing.Point(3, 16);
            this.txtNotification.Name = "txtNotification";
            this.txtNotification.Size = new System.Drawing.Size(859, 289);
            this.txtNotification.TabIndex = 0;
            this.txtNotification.Text = "";
            // 
            // cmbRegion
            // 
            this.cmbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRegion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.DataSetNotifications, "tJ_NotificationOfRepairs.idRegion", true));
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(358, 63);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(518, 21);
            this.cmbRegion.TabIndex = 20;
            this.cmbRegion.SelectedValueChanged += new System.EventHandler(this.cmbRegion_SelectedValueChanged);
            // 
            // txtRequestFiled
            // 
            this.txtRequestFiled.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRequestFiled.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtRequestFiled.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DataSetNotifications, "tJ_NotificationOfRepairs.reguestFiled", true));
            this.txtRequestFiled.FormattingEnabled = true;
            this.txtRequestFiled.Location = new System.Drawing.Point(101, 62);
            this.txtRequestFiled.Name = "txtRequestFiled";
            this.txtRequestFiled.Size = new System.Drawing.Size(181, 21);
            this.txtRequestFiled.TabIndex = 19;
            this.txtRequestFiled.SelectedIndexChanged += new System.EventHandler(this.txtRequestFiled_SelectedIndexChanged);
            // 
            // tabPageAbn
            // 
            this.tabPageAbn.Controls.Add(this.splitContainerAbn);
            this.tabPageAbn.Controls.Add(this.statusStripAbnObj);
            this.tabPageAbn.Controls.Add(this.toolStripAbn);
            this.tabPageAbn.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbn.Name = "tabPageAbn";
            this.tabPageAbn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbn.Size = new System.Drawing.Size(888, 635);
            this.tabPageAbn.TabIndex = 4;
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
            this.splitContainerAbn.Size = new System.Drawing.Size(882, 582);
            this.splitContainerAbn.SplitterDistance = 370;
            this.splitContainerAbn.TabIndex = 9;
            // 
            // dgvAbn
            // 
            this.dgvAbn.AllowUserToAddRows = false;
            this.dgvAbn.AllowUserToDeleteRows = false;
            this.dgvAbn.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAbn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAbn.AutoGenerateColumns = false;
            this.dgvAbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeAbonentDataGridViewTextBoxColumn,
            this.Адресс,
            this.idAbnDataGridViewTextBoxColumn,
            this.nameAbnDataGridViewTextBoxColumn,
            this.idAbnObjDataGridViewTextBoxColumn,
            this.nameObjDataGridViewTextBoxColumn,
            this.typeAbnDgvColumn,
            this.SourceUserNotification,
            this.TypeNotification,
            this.SourceNotification,
            this.TargetNotification,
            this.StatusNotification,
            this.categoryNameDgvColumn,
            this.powerSetDgvColumn,
            this.countPointDgvColumn,
            this.commentODSDgvColumn,
            this.idStatusNotification,
            this.idTypeNotification,
            this.idAddress});
            this.dgvAbn.DataSource = this.bsSchmAbnFull;
            this.dgvAbn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbn.Location = new System.Drawing.Point(0, 0);
            this.dgvAbn.Name = "dgvAbn";
            this.dgvAbn.ReadOnly = true;
            this.dgvAbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbn.Size = new System.Drawing.Size(882, 370);
            this.dgvAbn.TabIndex = 7;
            // 
            // bsSchmAbnFull
            // 
            this.bsSchmAbnFull.DataMember = "vl_SchmAbnFull";
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
            this.dataColumnPowerSet,
            this.dataColumncountPoint,
            this.dataColumnidSchmObj,
            this.dataColumnKladrObjId,
            this.dataColumnidStreet,
            this.dataColumnhouse,
            this.dataColumnTypeNotification,
            this.dataColumnSourceUserNotification,
            this.dataColumnSourceNotification,
            this.dataColumnTargetNotification,
            this.dataColumnStatusNotification,
            this.dataColumnIdTypeNotification,
            this.dataColumnIdStatusNotification,
            this.dataColumnIdAddress});
            this.tableSchmAbnFull.TableName = "vl_SchmAbnFull";
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
            // dataColumnPowerSet
            // 
            this.dataColumnPowerSet.ColumnName = "PowerSet";
            this.dataColumnPowerSet.DataType = typeof(decimal);
            // 
            // dataColumncountPoint
            // 
            this.dataColumncountPoint.ColumnName = "countPoint";
            this.dataColumncountPoint.DataType = typeof(int);
            // 
            // dataColumnidSchmObj
            // 
            this.dataColumnidSchmObj.ColumnName = "idSchmObj";
            this.dataColumnidSchmObj.DataType = typeof(int);
            // 
            // dataColumnKladrObjId
            // 
            this.dataColumnKladrObjId.ColumnName = "KladrObjId";
            this.dataColumnKladrObjId.DataType = typeof(int);
            // 
            // dataColumnidStreet
            // 
            this.dataColumnidStreet.ColumnName = "idStreet";
            this.dataColumnidStreet.DataType = typeof(int);
            // 
            // dataColumnhouse
            // 
            this.dataColumnhouse.ColumnName = "house";
            // 
            // dataColumnTypeNotification
            // 
            this.dataColumnTypeNotification.ColumnName = "TypeNotification";
            // 
            // dataColumnSourceUserNotification
            // 
            this.dataColumnSourceUserNotification.ColumnName = "SourceUserNotification";
            // 
            // dataColumnSourceNotification
            // 
            this.dataColumnSourceNotification.ColumnName = "SourceNotification";
            // 
            // dataColumnTargetNotification
            // 
            this.dataColumnTargetNotification.ColumnName = "TargetNotification";
            // 
            // dataColumnStatusNotification
            // 
            this.dataColumnStatusNotification.ColumnName = "StatusNotification";
            // 
            // dataColumnIdTypeNotification
            // 
            this.dataColumnIdTypeNotification.ColumnName = "idTypeNotification";
            // 
            // dataColumnIdStatusNotification
            // 
            this.dataColumnIdStatusNotification.ColumnName = "idStatusNotification";
            // 
            // dataColumnIdAddress
            // 
            this.dataColumnIdAddress.ColumnName = "idAddress";
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
            this.splitContainerAbnCount.Panel2.Controls.Add(this.groupBox8);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.label28);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.label29);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.label30);
            this.splitContainerAbnCount.Panel2.Controls.Add(this.groupBox9);
            this.splitContainerAbnCount.Size = new System.Drawing.Size(882, 208);
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
            this.groupBoxAbnObj1Catergory.Controls.Add(this.label4);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Частичное";
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
            this.statusStripAbnObj.Location = new System.Drawing.Point(3, 610);
            this.statusStripAbnObj.Name = "statusStripAbnObj";
            this.statusStripAbnObj.Size = new System.Drawing.Size(882, 22);
            this.statusStripAbnObj.TabIndex = 8;
            this.statusStripAbnObj.Text = "statusStrip1";
            // 
            // toolBtnRefreshCountAbn
            // 
            this.toolBtnRefreshCountAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshCountAbn.Image = global::NotificationOfRepairs.Properties.Resources.refresh_16;
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
            this.labelCountPoint.Size = new System.Drawing.Size(282, 17);
            this.labelCountPoint.Spring = true;
            this.labelCountPoint.Text = "Количество точек поставки: 0";
            // 
            // labelCountAbnObj
            // 
            this.labelCountAbnObj.Name = "labelCountAbnObj";
            this.labelCountAbnObj.Size = new System.Drawing.Size(282, 17);
            this.labelCountAbnObj.Spring = true;
            this.labelCountAbnObj.Text = "Количество объектов: 0";
            // 
            // labelCountAbn
            // 
            this.labelCountAbn.Name = "labelCountAbn";
            this.labelCountAbn.Size = new System.Drawing.Size(282, 17);
            this.labelCountAbn.Spring = true;
            this.labelCountAbn.Text = "Количество абонентов: 0";
            // 
            // toolStripAbn
            // 
            this.toolStripAbn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddAbn,
            this.toolBrnDelAbn,
            this.toolBtnRefreshAbn});
            this.toolStripAbn.Location = new System.Drawing.Point(3, 3);
            this.toolStripAbn.Name = "toolStripAbn";
            this.toolStripAbn.Size = new System.Drawing.Size(882, 25);
            this.toolStripAbn.TabIndex = 6;
            this.toolStripAbn.Text = "toolStrip1";
            // 
            // toolBtnAddAbn
            // 
            this.toolBtnAddAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddAbn.Image = global::NotificationOfRepairs.Properties.Resources.ElementAdd;
            this.toolBtnAddAbn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddAbn.Name = "toolBtnAddAbn";
            this.toolBtnAddAbn.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddAbn.Text = "toolStripButton1";
            this.toolBtnAddAbn.Click += new System.EventHandler(this.toolBtnAddAbn_Click);
            // 
            // toolBrnDelAbn
            // 
            this.toolBrnDelAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBrnDelAbn.Image = global::NotificationOfRepairs.Properties.Resources.ElementDel;
            this.toolBrnDelAbn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBrnDelAbn.Name = "toolBrnDelAbn";
            this.toolBrnDelAbn.Size = new System.Drawing.Size(23, 22);
            this.toolBrnDelAbn.Text = "Удалить абонентов";
            this.toolBrnDelAbn.Click += new System.EventHandler(this.toolBrnDelAbn_Click);
            // 
            // toolBtnRefreshAbn
            // 
            this.toolBtnRefreshAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshAbn.Image = global::NotificationOfRepairs.Properties.Resources.refresh_16;
            this.toolBtnRefreshAbn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefreshAbn.Name = "toolBtnRefreshAbn";
            this.toolBtnRefreshAbn.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRefreshAbn.Text = "Обновить";
            this.toolBtnRefreshAbn.Click += new System.EventHandler(this.toolBtnRefreshAbn_Click);
            // 
            // tabPageDocuments
            // 
            this.tabPageDocuments.Controls.Add(this.dgvDocs);
            this.tabPageDocuments.Controls.Add(this.toolStripDocuments);
            this.tabPageDocuments.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocuments.Name = "tabPageDocuments";
            this.tabPageDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocuments.Size = new System.Drawing.Size(888, 635);
            this.tabPageDocuments.TabIndex = 2;
            this.tabPageDocuments.Text = "Документы";
            this.tabPageDocuments.UseVisualStyleBackColor = true;
            // 
            // dgvDocs
            // 
            this.dgvDocs.AllowUserToAddRows = false;
            this.dgvDocs.AllowUserToDeleteRows = false;
            this.dgvDocs.AutoGenerateColumns = false;
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumnDoc,
            this.fileNameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.ColumnImage});
            this.dgvDocs.DataSource = this.bsRequestForRepairDoc;
            this.dgvDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocs.Location = new System.Drawing.Point(3, 28);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.RowHeadersWidth = 21;
            this.dgvDocs.Size = new System.Drawing.Size(882, 604);
            this.dgvDocs.TabIndex = 1;
            this.dgvDocs.VirtualMode = true;
            this.dgvDocs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocs_CellContentClick);
            this.dgvDocs.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvDocs_CellValueNeeded);
            // 
            // idDataGridViewTextBoxColumnDoc
            // 
            this.idDataGridViewTextBoxColumnDoc.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumnDoc.HeaderText = "id";
            this.idDataGridViewTextBoxColumnDoc.Name = "idDataGridViewTextBoxColumnDoc";
            this.idDataGridViewTextBoxColumnDoc.ReadOnly = true;
            this.idDataGridViewTextBoxColumnDoc.Visible = false;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "Файл";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fileNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.fileNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // ColumnImage
            // 
            dataGridViewCellStyle4.NullValue = null;
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnImage.HeaderText = "";
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnImage.Width = 30;
            // 
            // bsRequestForRepairDoc
            // 
            this.bsRequestForRepairDoc.DataMember = "tJ_NotificationOfRepairsDoc";
            this.bsRequestForRepairDoc.DataSource = this.DataSetNotifications;
            // 
            // toolStripDocuments
            // 
            this.toolStripDocuments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddDoc,
            this.toolBtnDelDoc,
            this.toolBtnViewDoc,
            this.toolBtnSaveDoc});
            this.toolStripDocuments.Location = new System.Drawing.Point(3, 3);
            this.toolStripDocuments.Name = "toolStripDocuments";
            this.toolStripDocuments.Size = new System.Drawing.Size(882, 25);
            this.toolStripDocuments.TabIndex = 0;
            this.toolStripDocuments.Text = "toolStrip1";
            // 
            // toolBtnAddDoc
            // 
            this.toolBtnAddDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddDoc.Image = global::NotificationOfRepairs.Properties.Resources.ElementAdd;
            this.toolBtnAddDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddDoc.Name = "toolBtnAddDoc";
            this.toolBtnAddDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddDoc.Text = "Добавить документ";
            this.toolBtnAddDoc.Click += new System.EventHandler(this.toolBtnAddDoc_Click);
            // 
            // toolBtnDelDoc
            // 
            this.toolBtnDelDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelDoc.Image = global::NotificationOfRepairs.Properties.Resources.ElementDel;
            this.toolBtnDelDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelDoc.Name = "toolBtnDelDoc";
            this.toolBtnDelDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelDoc.Text = "Удалить документ";
            this.toolBtnDelDoc.Click += new System.EventHandler(this.toolBtnDelDoc_Click);
            // 
            // toolBtnViewDoc
            // 
            this.toolBtnViewDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnViewDoc.Image = global::NotificationOfRepairs.Properties.Resources.ElementInformation;
            this.toolBtnViewDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnViewDoc.Name = "toolBtnViewDoc";
            this.toolBtnViewDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnViewDoc.Text = "Открыть документ";
            this.toolBtnViewDoc.Click += new System.EventHandler(this.toolBtnViewDoc_Click);
            // 
            // toolBtnSaveDoc
            // 
            this.toolBtnSaveDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSaveDoc.Image = global::NotificationOfRepairs.Properties.Resources.ElementGo;
            this.toolBtnSaveDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSaveDoc.Name = "toolBtnSaveDoc";
            this.toolBtnSaveDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSaveDoc.Text = "Сохранить документ";
            this.toolBtnSaveDoc.Click += new System.EventHandler(this.toolBtnSaveDoc_Click);
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.dataGridViewExcelFilter1);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(888, 635);
            this.tabPageLog.TabIndex = 3;
            this.tabPageLog.Text = "Логирование";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExcelFilter1
            // 
            this.dataGridViewExcelFilter1.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter1.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter1.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcelFilter1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateLogDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.userLogIDDataGridViewTextBoxColumn,
            this.userLogDataGridViewTextBoxColumn,
            this.userLogNameDataGridViewTextBoxColumn,
            this.idCommandDataGridViewTextBoxColumn,
            this.commandDataGridViewTextBoxColumn});
            this.dataGridViewExcelFilter1.DataSource = this.bsRequestForRepairLog;
            this.dataGridViewExcelFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExcelFilter1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewExcelFilter1.Name = "dataGridViewExcelFilter1";
            this.dataGridViewExcelFilter1.ReadOnly = true;
            this.dataGridViewExcelFilter1.RowHeadersWidth = 21;
            this.dataGridViewExcelFilter1.Size = new System.Drawing.Size(882, 629);
            this.dataGridViewExcelFilter1.TabIndex = 0;
            // 
            // dateLogDataGridViewTextBoxColumn
            // 
            this.dateLogDataGridViewTextBoxColumn.DataPropertyName = "dateLog";
            this.dateLogDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateLogDataGridViewTextBoxColumn.Name = "dateLogDataGridViewTextBoxColumn";
            this.dateLogDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // userLogIDDataGridViewTextBoxColumn
            // 
            this.userLogIDDataGridViewTextBoxColumn.DataPropertyName = "userLogID";
            this.userLogIDDataGridViewTextBoxColumn.HeaderText = "userLogID";
            this.userLogIDDataGridViewTextBoxColumn.Name = "userLogIDDataGridViewTextBoxColumn";
            this.userLogIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userLogIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // userLogDataGridViewTextBoxColumn
            // 
            this.userLogDataGridViewTextBoxColumn.DataPropertyName = "userLog";
            this.userLogDataGridViewTextBoxColumn.HeaderText = "userLog";
            this.userLogDataGridViewTextBoxColumn.Name = "userLogDataGridViewTextBoxColumn";
            this.userLogDataGridViewTextBoxColumn.ReadOnly = true;
            this.userLogDataGridViewTextBoxColumn.Visible = false;
            // 
            // userLogNameDataGridViewTextBoxColumn
            // 
            this.userLogNameDataGridViewTextBoxColumn.DataPropertyName = "userLogName";
            this.userLogNameDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.userLogNameDataGridViewTextBoxColumn.Name = "userLogNameDataGridViewTextBoxColumn";
            this.userLogNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCommandDataGridViewTextBoxColumn
            // 
            this.idCommandDataGridViewTextBoxColumn.DataPropertyName = "idCommand";
            this.idCommandDataGridViewTextBoxColumn.HeaderText = "idCommand";
            this.idCommandDataGridViewTextBoxColumn.Name = "idCommandDataGridViewTextBoxColumn";
            this.idCommandDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCommandDataGridViewTextBoxColumn.Visible = false;
            // 
            // commandDataGridViewTextBoxColumn
            // 
            this.commandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commandDataGridViewTextBoxColumn.DataPropertyName = "Command";
            this.commandDataGridViewTextBoxColumn.HeaderText = "Действие";
            this.commandDataGridViewTextBoxColumn.Name = "commandDataGridViewTextBoxColumn";
            this.commandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsRequestForRepairLog
            // 
            this.bsRequestForRepairLog.DataMember = "tJ_NotificationOfRepairsLog";
            this.bsRequestForRepairLog.DataSource = this.DataSetNotifications;
            this.bsRequestForRepairLog.Sort = "dateLog desc, id desc";
            // 
            // bsLinkObjects
            // 
            this.bsLinkObjects.DataMember = "tableLinkObjects";
            this.bsLinkObjects.DataSource = this.dsLinkObjects;
            this.bsLinkObjects.Sort = "Num";
            // 
            // dsLinkObjects
            // 
            this.dsLinkObjects.DataSetName = "NewDataSet";
            this.dsLinkObjects.Tables.AddRange(new System.Data.DataTable[] {
            this.tableLinkObjects,
            this.tableRequestForReapirDoc,
            this.tableAddress});
            // 
            // tableLinkObjects
            // 
            this.tableLinkObjects.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn25,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn16});
            this.tableLinkObjects.TableName = "tableLinkObjects";
            // 
            // dataColumn25
            // 
            this.dataColumn25.ColumnName = "Objects";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "DateBeg";
            this.dataColumn1.DataType = typeof(System.DateTime);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "DateEnd";
            this.dataColumn2.DataType = typeof(System.DateTime);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Duration";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Num";
            this.dataColumn4.DataType = typeof(short);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "Disabled";
            this.dataColumn16.DataType = typeof(bool);
            // 
            // tableRequestForReapirDoc
            // 
            this.tableRequestForReapirDoc.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn5,
            this.dataColumn17,
            this.dataColumn6,
            this.dataColumn7});
            this.tableRequestForReapirDoc.TableName = "tJ_RequestForReapirDoc";
            // 
            // dataColumn5
            // 
            this.dataColumn5.AllowDBNull = false;
            this.dataColumn5.AutoIncrement = true;
            this.dataColumn5.ColumnName = "id";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn17
            // 
            this.dataColumn17.AllowDBNull = false;
            this.dataColumn17.ColumnName = "idRequest";
            this.dataColumn17.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "FileName";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Comment";
            // 
            // tableAddress
            // 
            this.tableAddress.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15});
            this.tableAddress.TableName = "tableAddress";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "id";
            this.dataColumn8.DataType = typeof(int);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "idRequest";
            this.dataColumn9.DataType = typeof(int);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "City";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "idKladrObj";
            this.dataColumn11.DataType = typeof(int);
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "Street";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "idKladrStreet";
            this.dataColumn13.DataType = typeof(int);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "House";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "Name";
            // 
            // bsAddress
            // 
            this.bsAddress.DataMember = "tableAddress";
            this.bsAddress.DataSource = this.dsLinkObjects;
            this.bsAddress.Sort = "City, Street, House";
            // 
            // bsTransON
            // 
            this.bsTransON.DataMember = "tableTrans";
            this.bsTransON.DataSource = this.dataSetAdd;
            // 
            // dgvTree
            // 
            this.dgvTree.AllowUserToAddRows = false;
            this.dgvTree.AllowUserToDeleteRows = false;
            this.dgvTree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTree.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTree.ImageList = null;
            this.dgvTree.Location = new System.Drawing.Point(0, 0);
            this.dgvTree.Name = "dgvTree";
            this.dgvTree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTree.Size = new System.Drawing.Size(986, 291);
            this.dgvTree.TabIndex = 3;
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
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCopy.Location = new System.Drawing.Point(240, 674);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 50;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Visible = false;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(817, 670);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 51;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(321, 670);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(490, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 53;
            this.progressBar.Visible = false;
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(93, 675);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(201, 13);
            this.labelProgress.TabIndex = 52;
            this.labelProgress.Text = "Загрузка абонентов для уведомлений";
            this.labelProgress.Visible = false;
            // 
            // bsRequestForRepair
            // 
            this.bsRequestForRepair.DataMember = "tJ_NotificationOfRepairs";
            this.bsRequestForRepair.DataSource = this.DataSetNotifications;
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
            // Адресс
            // 
            this.Адресс.HeaderText = "Адрес";
            this.Адресс.Name = "Адресс";
            this.Адресс.ReadOnly = true;
            this.Адресс.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.nameAbnDataGridViewTextBoxColumn.DataPropertyName = "nameAbn";
            this.nameAbnDataGridViewTextBoxColumn.HeaderText = "Абонент";
            this.nameAbnDataGridViewTextBoxColumn.Name = "nameAbnDataGridViewTextBoxColumn";
            this.nameAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameAbnDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameAbnDataGridViewTextBoxColumn.Width = 62;
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
            this.nameObjDataGridViewTextBoxColumn.DataPropertyName = "nameObj";
            this.nameObjDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameObjDataGridViewTextBoxColumn.Name = "nameObjDataGridViewTextBoxColumn";
            this.nameObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameObjDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameObjDataGridViewTextBoxColumn.Width = 62;
            // 
            // typeAbnDgvColumn
            // 
            this.typeAbnDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeAbnDgvColumn.DataPropertyName = "typeAbn";
            this.typeAbnDgvColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeAbnDgvColumn.FillWeight = 48.97939F;
            this.typeAbnDgvColumn.HeaderText = "Тип абонента";
            this.typeAbnDgvColumn.Name = "typeAbnDgvColumn";
            this.typeAbnDgvColumn.ReadOnly = true;
            this.typeAbnDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SourceUserNotification
            // 
            this.SourceUserNotification.DataPropertyName = "SourceUserNotification";
            this.SourceUserNotification.HeaderText = "Пользователь";
            this.SourceUserNotification.Name = "SourceUserNotification";
            this.SourceUserNotification.ReadOnly = true;
            this.SourceUserNotification.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SourceUserNotification.ToolTipText = "Пользователь уведомляющий абонентов";
            // 
            // TypeNotification
            // 
            this.TypeNotification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeNotification.DataPropertyName = "TypeNotification";
            this.TypeNotification.FillWeight = 48.97655F;
            this.TypeNotification.HeaderText = "Тип уведомления";
            this.TypeNotification.Name = "TypeNotification";
            this.TypeNotification.ReadOnly = true;
            this.TypeNotification.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeNotification.ToolTipText = "Тип (способ) уведомления (как происходит уведомление)";
            // 
            // SourceNotification
            // 
            this.SourceNotification.DataPropertyName = "SourceNotification";
            this.SourceNotification.HeaderText = "Источник уведомления";
            this.SourceNotification.Name = "SourceNotification";
            this.SourceNotification.ReadOnly = true;
            this.SourceNotification.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SourceNotification.ToolTipText = "с чего происходит уведомление";
            // 
            // TargetNotification
            // 
            this.TargetNotification.DataPropertyName = "TargetNotification";
            this.TargetNotification.HeaderText = "Адрес уведомления";
            this.TargetNotification.Name = "TargetNotification";
            this.TargetNotification.ReadOnly = true;
            this.TargetNotification.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TargetNotification.ToolTipText = "на какой адрес призошло уведомление";
            // 
            // StatusNotification
            // 
            this.StatusNotification.DataPropertyName = "StatusNotification";
            this.StatusNotification.FillWeight = 50F;
            this.StatusNotification.HeaderText = "Статус уведомления";
            this.StatusNotification.Name = "StatusNotification";
            this.StatusNotification.ReadOnly = true;
            this.StatusNotification.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StatusNotification.ToolTipText = "получилось или нет";
            this.StatusNotification.Width = 62;
            // 
            // categoryNameDgvColumn
            // 
            this.categoryNameDgvColumn.DataPropertyName = "CategoryName";
            this.categoryNameDgvColumn.HeaderText = "Кат";
            this.categoryNameDgvColumn.Name = "categoryNameDgvColumn";
            this.categoryNameDgvColumn.ReadOnly = true;
            this.categoryNameDgvColumn.Width = 40;
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
            this.countPointDgvColumn.ReadOnly = true;
            this.countPointDgvColumn.Width = 40;
            // 
            // commentODSDgvColumn
            // 
            this.commentODSDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentODSDgvColumn.DataPropertyName = "CommentODS";
            this.commentODSDgvColumn.FillWeight = 4.534997F;
            this.commentODSDgvColumn.HeaderText = "Примечание";
            this.commentODSDgvColumn.Name = "commentODSDgvColumn";
            this.commentODSDgvColumn.ReadOnly = true;
            // 
            // idStatusNotification
            // 
            this.idStatusNotification.DataPropertyName = "idStatusNotification";
            this.idStatusNotification.HeaderText = "idStatusNotification";
            this.idStatusNotification.Name = "idStatusNotification";
            this.idStatusNotification.ReadOnly = true;
            this.idStatusNotification.Visible = false;
            // 
            // idTypeNotification
            // 
            this.idTypeNotification.DataPropertyName = "idTypeNotification";
            this.idTypeNotification.HeaderText = "idTypeNotification";
            this.idTypeNotification.Name = "idTypeNotification";
            this.idTypeNotification.ReadOnly = true;
            this.idTypeNotification.Visible = false;
            // 
            // idAddress
            // 
            this.idAddress.DataPropertyName = "idAddress";
            this.idAddress.HeaderText = "idAddress";
            this.idAddress.Name = "idAddress";
            this.idAddress.ReadOnly = true;
            this.idAddress.Visible = false;
            // 
            // FormNotificationOfRepairsAddEdit
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(897, 705);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormNotificationOfRepairsAddEdit";
            this.Text = "FormJournalRequestForRepairAddEditNoTreeAbn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNotificationOfRepairsAddEdit_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNotificationOfRepairsAddEdit_FormClosed);
            this.Load += new System.EventHandler(this.FormNotificationOfRepairsAddEdit_Load);
            this.Shown += new System.EventHandler(this.FormNotificationOfRepairsAddEdit_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNotifications)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxDaily.ResumeLayout(false);
            this.groupBoxDaily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.groupBoxTextNotification.ResumeLayout(false);
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
            this.tabPageDocuments.ResumeLayout(false);
            this.tabPageDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepairDoc)).EndInit();
            this.toolStripDocuments.ResumeLayout(false);
            this.toolStripDocuments.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepairLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRequestForReapirDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.ComponentModel.IContainer components = null;

		private NotificationOfRepairs.DataSets.DataSetNotifications DataSetNotifications;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.Label labelRequestFiled;

		private System.Windows.Forms.Label labelSR;

		private System.Windows.Forms.ComboBox cmbSR;

		private System.Windows.Forms.GroupBox groupBox1;

		private System.Windows.Forms.TextBox txtObject;

		private System.Windows.Forms.Label labelObject;

		private System.Windows.Forms.Button buttonOK;

		private System.Windows.Forms.ComboBox cmbUserCreate;

		private System.Windows.Forms.Label label15;

		private System.Windows.Forms.TextBox txtNum;

		private System.Windows.Forms.GroupBox groupBoxDaily;

		private System.Windows.Forms.DataGridView dgvDaily;

		private System.Windows.Forms.Label label2;

		private ControlsLbr.NullableDateTimePicker dtpDateCreate;

		private System.Windows.Forms.TabControl tabControl;

		private System.Windows.Forms.TabPage tabPageGeneral;

		private System.Windows.Forms.TabPage tabPageDocuments;

		private System.Data.DataSet dsLinkObjects;

		private System.Data.DataTable tableLinkObjects;

		private System.Data.DataColumn dataColumn25;

		private System.Data.DataColumn dataColumn1;

		private System.Data.DataColumn dataColumn2;

		private System.Data.DataColumn dataColumn3;

		private System.Data.DataColumn dataColumn4;

		private System.Windows.Forms.BindingSource bsLinkObjects;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvDocs;

		private System.Windows.Forms.BindingSource bsRequestForRepairDoc;

		private System.Windows.Forms.ToolStrip toolStripDocuments;

		private System.Windows.Forms.ToolStripButton toolBtnAddDoc;

		private System.Data.DataTable tableRequestForReapirDoc;

		private System.Data.DataColumn dataColumn5;

		private System.Data.DataColumn dataColumn17;

		private System.Data.DataColumn dataColumn6;

		private System.Data.DataColumn dataColumn7;

		private System.Windows.Forms.ToolStripButton toolBtnDelDoc;

		private System.Windows.Forms.ToolStripButton toolBtnViewDoc;

		private System.Windows.Forms.ToolStripButton toolBtnSaveDoc;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumnDoc;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull ColumnImage;

		private System.Windows.Forms.DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewLinkColumn fileNameDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;

		private System.Windows.Forms.Button buttonCopy;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn dateBegDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn dateEndDataGridViewTextBoxColumn;

		private System.Windows.Forms.ComboBox txtRequestFiled;

		private System.Windows.Forms.ComboBox cmbRegion;

		private System.Windows.Forms.BindingSource bsRequestForRepair;

		private System.Data.DataTable tableAddress;

		private System.Data.DataColumn dataColumn8;

		private System.Data.DataColumn dataColumn9;

		private System.Data.DataColumn dataColumn10;

		private System.Data.DataColumn dataColumn11;

		private System.Data.DataColumn dataColumn12;

		private System.Data.DataColumn dataColumn13;

		private System.Data.DataColumn dataColumn14;

		private System.Data.DataColumn dataColumn15;

		private System.Windows.Forms.BindingSource bsAddress;

		private System.ComponentModel.BackgroundWorker backgroundWorker;

		private System.Data.DataColumn dataColumn16;

		private System.Windows.Forms.TabPage tabPageLog;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter1;

		private System.Windows.Forms.BindingSource bsRequestForRepairLog;

		private System.Windows.Forms.DataGridViewTextBoxColumn dateLogDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn3;

		private System.Windows.Forms.DataGridViewTextBoxColumn userLogIDDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn userLogDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn userLogNameDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn idCommandDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn commandDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewCheckBoxColumn isSiteDataGridViewCheckBoxColumn;

		private System.Windows.Forms.Button buttonCancel;
    private System.Data.DataSet dataSetAdd;
    private System.Data.DataTable tableTransOff;
    private System.Data.DataColumn dataColumnidSub;
    private System.Data.DataColumn dataColumnSub;
    private System.Data.DataColumn dataColumnidTr;
    private System.Data.DataColumn dataColumnTrName;
    private System.Data.DataColumn dataColumnPower;
    private System.Data.DataColumn dataColumnLoad;
    private System.Data.DataTable tableSchmAbnFull;
    private System.Data.DataColumn dataColumnidAbn;
    private System.Data.DataColumn dataColumncodeAbonent;
    private System.Data.DataColumn dataColumnnameAbn;
    private System.Data.DataColumn dataColumntypeAbn;
    private System.Data.DataColumn dataColumnidAbnObj;
    private System.Data.DataColumn dataColumnnameObj;
    private System.Data.DataColumn dataColumnCommentODS;
    private System.Data.DataColumn dataColumnCategoryName;
    private System.Data.DataColumn dataColumnPowerSet;
    private System.Data.DataColumn dataColumncountPoint;
    private System.Data.DataColumn dataColumnidSchmObj;

    private System.Data.DataColumn dataColumnKladrObjId;
    private System.Data.DataColumn dataColumnidStreet;
    private System.Data.DataColumn dataColumnhouse;


    private System.Windows.Forms.BindingSource bsTransON;
    private System.Windows.Forms.BindingSource bsSchmAbnFull;
    private System.Windows.Forms.TabPage tabPageAbn;
    private System.Windows.Forms.SplitContainer splitContainerAbn;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvAbn;
    private System.Windows.Forms.SplitContainer splitContainerAbnCount;
    private System.Windows.Forms.NumericUpDown numCountPointSource;
    private System.Windows.Forms.NumericUpDown numCountPointEE;
    private System.Windows.Forms.NumericUpDown numCountPointCat3;
    private System.Windows.Forms.GroupBox groupBoxAbnObj1Catergory;
    private System.Windows.Forms.NumericUpDown numCountPointCat1;
    private System.Windows.Forms.NumericUpDown numCountPointCat1Full;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label23;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.GroupBox groupBox6;
    private System.Windows.Forms.NumericUpDown numCountPointCat2Full;
    private System.Windows.Forms.NumericUpDown numCountPointCat2;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label label24;
    private System.Windows.Forms.Label label25;
    private System.Windows.Forms.NumericUpDown numCountAbnObjSource;
    private System.Windows.Forms.NumericUpDown numCountAbnObjEE;
    private System.Windows.Forms.NumericUpDown numCountAbnObjCat3;
    private System.Windows.Forms.Label label31;
    private System.Windows.Forms.GroupBox groupBox8;
    private System.Windows.Forms.NumericUpDown numCountAbnObjCat1;
    private System.Windows.Forms.NumericUpDown numCountAbnObjCat1Full;
    private System.Windows.Forms.Label label26;
    private System.Windows.Forms.Label label27;
    private System.Windows.Forms.Label label28;
    private System.Windows.Forms.Label label29;
    private System.Windows.Forms.Label label30;
    private System.Windows.Forms.GroupBox groupBox9;
    private System.Windows.Forms.NumericUpDown numCountAbnObjCat2;
    private System.Windows.Forms.NumericUpDown numCountAbnObjCat2Full;
    private System.Windows.Forms.Label label35;
    private System.Windows.Forms.Label label36;
    private System.Windows.Forms.StatusStrip statusStripAbnObj;
    private System.Windows.Forms.ToolStripDropDownButton toolBtnRefreshCountAbn;
    private System.Windows.Forms.ToolStripStatusLabel labelCountPoint;
    private System.Windows.Forms.ToolStripStatusLabel labelCountAbnObj;
    private System.Windows.Forms.ToolStripStatusLabel labelCountAbn;
    private System.Windows.Forms.ToolStrip toolStripAbn;
    private System.Windows.Forms.ToolStripButton toolBtnRefreshAbn;
    private System.Windows.Forms.ToolStripButton toolBrnDelAbn;
    private System.Windows.Forms.ProgressBar progressBar;
    private System.Windows.Forms.Label labelProgress;
    private ControlsLbr.TreeDataGridView dgvTree;
    private ControlsLbr.TreeGridColumn subNameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idSubColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn busNameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idBusColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn cellNameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idCellColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn trNameColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idTrColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn powerColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn loadColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dateOnColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn noAdmissionKWTColumn;
    private System.Windows.Forms.GroupBox groupBoxTextNotification;
    private System.Windows.Forms.RichTextBox txtNotification;
    private System.Windows.Forms.Button btnRefreshUploadParentDoc;
    private System.Windows.Forms.Button btnOpenParentDamage;
    private System.Windows.Forms.Button buttonChooseParentDamage;
    private System.Windows.Forms.TextBox txtParentDamage;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ToolStripButton toolBtnAddAbn;
    private System.Windows.Forms.Button buttonDaily;
    private System.Windows.Forms.CheckBox checkBoxWeekEnd;
    private System.Windows.Forms.CheckBox checkBoxDaily;
    private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.DateTimePicker dateTimePickerBeg;
    private System.Windows.Forms.Label label8;
    private System.Data.DataColumn dataColumnTypeNotification;
    private System.Data.DataColumn dataColumnSourceUserNotification;
    private System.Data.DataColumn dataColumnSourceNotification;
    private System.Data.DataColumn dataColumnTargetNotification;
    private System.Data.DataColumn dataColumnStatusNotification;
    private System.Data.DataColumn dataColumnIdTypeNotification;
    private System.Data.DataColumn dataColumnIdStatusNotification;
    private System.Data.DataColumn dataColumnIdAddress;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Адресс;
    private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameAbnDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterComboBoxColumn typeAbnDgvColumn;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn SourceUserNotification;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterComboBoxColumn TypeNotification;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn SourceNotification;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn TargetNotification;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterComboBoxColumn StatusNotification;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn categoryNameDgvColumn;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn powerSetDgvColumn;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn countPointDgvColumn;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn commentODSDgvColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idStatusNotification;
    private System.Windows.Forms.DataGridViewTextBoxColumn idTypeNotification;
    private System.Windows.Forms.DataGridViewTextBoxColumn idAddress;
}
