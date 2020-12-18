
	public partial class FormJournalRequestForRepairAddEditCrash : FormLbr.FormBase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.dataSetDamage = new RequestForRepairN.DataSets.DataSetDamage();
            this.labelRequestFiled = new System.Windows.Forms.Label();
            this.labelSR = new System.Windows.Forms.Label();
            this.cmbSR = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTypeDamage = new System.Windows.Forms.ComboBox();
            this.cmbTypeDisable = new System.Windows.Forms.ComboBox();
            this.cmbIsPlanned = new System.Windows.Forms.ComboBox();
            this.labelIsPlanned = new System.Windows.Forms.Label();
            this.labelPurpose = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.labelObject = new System.Windows.Forms.Label();
            this.toolStripScheme = new System.Windows.Forms.ToolStrip();
            this.toolBtnLinkSchmObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnLinkSchmObjEdit = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelSchmObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnViewSChmObj = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDaily = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFactEnd = new ControlsLbr.NullableDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDaily = new System.Windows.Forms.Button();
            this.dgvDaily = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBegDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn();
            this.dateEndDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn();
            this.checkBoxWeekEnd = new System.Windows.Forms.CheckBox();
            this.checkBoxDaily = new System.Windows.Forms.CheckBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerBeg = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxODS = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cmbDispatcher = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerDateAgreed = new ControlsLbr.NullableDateTimePicker();
            this.checkBoxAgreed = new System.Windows.Forms.CheckBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtAgreeWith = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.cmbUserCreate = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.labelWorker = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateCreate = new ControlsLbr.NullableDateTimePicker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.chkSendToSite = new System.Windows.Forms.CheckBox();
            this.cmbGroupWorks = new System.Windows.Forms.ComboBox();
            this.bsRequestForRepair = new System.Windows.Forms.BindingSource(this.components);
            this.labelGroupWork = new System.Windows.Forms.Label();
            this.cmbPerformerOrganization = new System.Windows.Forms.ComboBox();
            this.labelPerformer = new System.Windows.Forms.Label();
            this.cmbOrganization = new System.Windows.Forms.ComboBox();
            this.labelOrganization = new System.Windows.Forms.Label();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.txtRequestFiled = new System.Windows.Forms.ComboBox();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSettingsFTP = new System.Windows.Forms.ToolStripButton();
            this.tabPageSwitching = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvLinkObjects = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.objectsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBegDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disabledDgvColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.dgvAddress = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAddressDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRequestDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKladrObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKladrStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAddress = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripAddress = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddAddress = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelAddress = new System.Windows.Forms.ToolStripButton();
            this.tabPageDocuments = new System.Windows.Forms.TabPage();
            this.dgvDocs = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumnDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRequestDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.idRequestDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSiteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsRequestForRepairLog = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageAbn = new System.Windows.Forms.TabPage();
            this.splitContainerAbn = new System.Windows.Forms.SplitContainer();
            //this.dgvAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        this.dgvAbn = new ControlsLbr.TreeDataGridView();
        this.dgvTreeAbn = new ControlsLbr.TreeDataGridView(); 

        //this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
        //    this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //    this.nameAbnDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
        //    this.typeAbnDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterComboBoxColumn();
        //    this.idAbnObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        //    this.nameObjDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
        //    this.categoryNameDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
        //    this.powerSetDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
        //    this.countPointDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
        //    this.commentODSDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
        this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.idSchmObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.kladrObjIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.idStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.housesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.nameAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.typeAbnDgvColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
        this.idAbnObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.nameObjDataGridViewTextBoxColumn =  new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.categoryNameDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.tarifNameDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.powerSetDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.countPointDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.commentODSDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();


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
            this.dataColumnPowerSet = new System.Data.DataColumn();
            this.dataColumncountPoint = new System.Data.DataColumn();
        this.dataColumnidSchmObj = new System.Data.DataColumn();
        this.dataColumnKladrObjId = new System.Data.DataColumn();
        this.dataColumnidStreet = new System.Data.DataColumn();
        this.dataColumnhouse = new System.Data.DataColumn();

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
            this.idSubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTransON = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTreeSub = new ControlsLbr.TreeDataGridView();
            this.subNameColumn = new ControlsLbr.TreeGridColumn();

        this.nameAddressAbnObjColumn = new ControlsLbr.TreeGridColumn();
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
            this.buttonCopy = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStripScheme.SuspendLayout();
            this.groupBoxDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).BeginInit();
            this.groupBoxODS.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepair)).BeginInit();
            this.toolStripMain.SuspendLayout();
            this.tabPageSwitching.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRequestForReapirDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddress)).BeginInit();
            this.toolStripAddress.SuspendLayout();
            this.tabPageDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepairDoc)).BeginInit();
            this.toolStripDocuments.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelFilter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepairLog)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автор";
            // 
            // cmbWorker
            // 
            this.cmbWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.idWorker", true));
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(288, 66);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(21, 21);
            this.cmbWorker.TabIndex = 3;
            this.cmbWorker.Visible = false;
            this.cmbWorker.SelectedIndexChanged += new System.EventHandler(this.cmbWorker_SelectedIndexChanged);
            // 
            // dataSetDamage
            // 
            this.dataSetDamage.DataSetName = "DataSetGES";
            this.dataSetDamage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.cmbSR.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.idSR", true));
            this.cmbSR.FormattingEnabled = true;
            this.cmbSR.Location = new System.Drawing.Point(358, 36);
            this.cmbSR.Name = "cmbSR";
            this.cmbSR.Size = new System.Drawing.Size(622, 21);
            this.cmbSR.TabIndex = 7;
            this.cmbSR.SelectedIndexChanged += new System.EventHandler(this.cmbSR_SelectedIndexChanged);
            this.cmbSR.SelectedValueChanged += new System.EventHandler(this.cmbSR_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbTypeDamage);
            this.groupBox1.Controls.Add(this.cmbTypeDisable);
            this.groupBox1.Controls.Add(this.cmbIsPlanned);
            this.groupBox1.Controls.Add(this.labelIsPlanned);
            this.groupBox1.Controls.Add(this.labelPurpose);
            this.groupBox1.Controls.Add(this.txtPurpose);
            this.groupBox1.Controls.Add(this.txtObject);
            this.groupBox1.Controls.Add(this.labelObject);
            this.groupBox1.Location = new System.Drawing.Point(11, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 97);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // cmbTypeDamage
            // 
            this.cmbTypeDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTypeDamage.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.idTypeDamage", true));
            this.cmbTypeDamage.FormattingEnabled = true;
            this.cmbTypeDamage.Location = new System.Drawing.Point(366, 68);
            this.cmbTypeDamage.Name = "cmbTypeDamage";
            this.cmbTypeDamage.Size = new System.Drawing.Size(597, 21);
            this.cmbTypeDamage.TabIndex = 7;
            // 
            // cmbTypeDisable
            // 
            this.cmbTypeDisable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTypeDisable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTypeDisable.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.typeDisable", true));
            this.cmbTypeDisable.FormattingEnabled = true;
            this.cmbTypeDisable.Items.AddRange(new object[] {
            "Аварийный",
            "Плановый"});
            this.cmbTypeDisable.Location = new System.Drawing.Point(230, 68);
            this.cmbTypeDisable.Name = "cmbTypeDisable";
            this.cmbTypeDisable.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeDisable.TabIndex = 6;
            this.cmbTypeDisable.SelectedValueChanged += new System.EventHandler(this.cmbTypeDisable_SelectedValueChanged);
            // 
            // cmbIsPlanned
            // 
            this.cmbIsPlanned.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.IsPlanned", true));
            this.cmbIsPlanned.FormattingEnabled = true;
            this.cmbIsPlanned.Items.AddRange(new object[] {
            "Аварийный",
            "Плановый"});
            this.cmbIsPlanned.Location = new System.Drawing.Point(101, 68);
            this.cmbIsPlanned.Name = "cmbIsPlanned";
            this.cmbIsPlanned.Size = new System.Drawing.Size(121, 21);
            this.cmbIsPlanned.TabIndex = 5;
            this.cmbIsPlanned.SelectedIndexChanged += new System.EventHandler(this.cmbIsPlanned_SelectedIndexChanged);
            this.cmbIsPlanned.SelectedValueChanged += new System.EventHandler(this.cmbIsPlanned_SelectedValueChanged);
            // 
            // labelIsPlanned
            // 
            this.labelIsPlanned.AutoSize = true;
            this.labelIsPlanned.Location = new System.Drawing.Point(6, 71);
            this.labelIsPlanned.Name = "labelIsPlanned";
            this.labelIsPlanned.Size = new System.Drawing.Size(89, 13);
            this.labelIsPlanned.TabIndex = 4;
            this.labelIsPlanned.Text = "Вид отключения";
            // 
            // labelPurpose
            // 
            this.labelPurpose.AutoSize = true;
            this.labelPurpose.Location = new System.Drawing.Point(6, 45);
            this.labelPurpose.Name = "labelPurpose";
            this.labelPurpose.Size = new System.Drawing.Size(33, 13);
            this.labelPurpose.TabIndex = 3;
            this.labelPurpose.Text = "Цель";
            // 
            // txtPurpose
            // 
            this.txtPurpose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurpose.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.Purpose", true));
            this.txtPurpose.Location = new System.Drawing.Point(101, 42);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(862, 20);
            this.txtPurpose.TabIndex = 2;
            this.txtPurpose.TextChanged += new System.EventHandler(this.txtPurpose_TextChanged);
            // 
            // txtObject
            // 
            this.txtObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.schmObj", true));
            this.txtObject.Location = new System.Drawing.Point(101, 16);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(862, 20);
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
            // toolStripScheme
            // 
            this.toolStripScheme.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripScheme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnLinkSchmObj,
            this.toolBtnLinkSchmObjEdit,
            this.toolBtnDelSchmObj,
            this.toolBtnViewSChmObj,
            this.toolStripButton1});
            this.toolStripScheme.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripScheme.Location = new System.Drawing.Point(3, 3);
            this.toolStripScheme.Name = "toolStripScheme";
            this.toolStripScheme.Size = new System.Drawing.Size(986, 25);
            this.toolStripScheme.TabIndex = 47;
            this.toolStripScheme.Text = "toolStrip1";
            // 
            // toolBtnLinkSchmObj
            // 
            this.toolBtnLinkSchmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnLinkSchmObj.Image = global::RequestForRepairN.Properties.Resources.ElementAdd;
            this.toolBtnLinkSchmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnLinkSchmObj.Name = "toolBtnLinkSchmObj";
            this.toolBtnLinkSchmObj.Size = new System.Drawing.Size(23, 22);
            this.toolBtnLinkSchmObj.Text = "Привязать к схеме";
            this.toolBtnLinkSchmObj.Click += new System.EventHandler(this.toolBtnLinkSchmObj_Click);
            // 
            // toolBtnLinkSchmObjEdit
            // 
            this.toolBtnLinkSchmObjEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnLinkSchmObjEdit.Image = global::RequestForRepairN.Properties.Resources.ElementEdit;
            this.toolBtnLinkSchmObjEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnLinkSchmObjEdit.Name = "toolBtnLinkSchmObjEdit";
            this.toolBtnLinkSchmObjEdit.Size = new System.Drawing.Size(23, 22);
            this.toolBtnLinkSchmObjEdit.Text = "Редактировать";
            this.toolBtnLinkSchmObjEdit.Click += new System.EventHandler(this.toolBtnLinkSchmObjEdit_Click);
            // 
            // toolBtnDelSchmObj
            // 
            this.toolBtnDelSchmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelSchmObj.Image = global::RequestForRepairN.Properties.Resources.ElementDel;
            this.toolBtnDelSchmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelSchmObj.Name = "toolBtnDelSchmObj";
            this.toolBtnDelSchmObj.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelSchmObj.Text = "Удалить";
            this.toolBtnDelSchmObj.Click += new System.EventHandler(this.toolBtnDelSchmObj_Click);
            // 
            // toolBtnViewSChmObj
            // 
            this.toolBtnViewSChmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnViewSChmObj.Enabled = false;
            this.toolBtnViewSChmObj.Image = global::RequestForRepairN.Properties.Resources.ElementInformation;
            this.toolBtnViewSChmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnViewSChmObj.Name = "toolBtnViewSChmObj";
            this.toolBtnViewSChmObj.Size = new System.Drawing.Size(23, 22);
            this.toolBtnViewSChmObj.Text = "Показать на схеме";
            this.toolBtnViewSChmObj.Click += new System.EventHandler(this.toolBtnViewSChmObj_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::RequestForRepairN.Properties.Resources.refresh_16;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Обновить";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // groupBoxDaily
            // 
            this.groupBoxDaily.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDaily.Controls.Add(this.dateTimePickerFactEnd);
            this.groupBoxDaily.Controls.Add(this.label3);
            this.groupBoxDaily.Controls.Add(this.buttonDaily);
            this.groupBoxDaily.Controls.Add(this.dgvDaily);
            this.groupBoxDaily.Controls.Add(this.checkBoxWeekEnd);
            this.groupBoxDaily.Controls.Add(this.checkBoxDaily);
            this.groupBoxDaily.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxDaily.Controls.Add(this.label9);
            this.groupBoxDaily.Controls.Add(this.dateTimePickerBeg);
            this.groupBoxDaily.Controls.Add(this.label8);
            this.groupBoxDaily.Location = new System.Drawing.Point(11, 192);
            this.groupBoxDaily.Name = "groupBoxDaily";
            this.groupBoxDaily.Size = new System.Drawing.Size(969, 173);
            this.groupBoxDaily.TabIndex = 10;
            this.groupBoxDaily.TabStop = false;
            this.groupBoxDaily.Text = "Даты отключения";
            // 
            // dateTimePickerFactEnd
            // 
            this.dateTimePickerFactEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerFactEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_RequestForRepair.dateFactEnd", true));
            this.dateTimePickerFactEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFactEnd.Location = new System.Drawing.Point(351, 144);
            this.dateTimePickerFactEnd.Name = "dateTimePickerFactEnd";
            this.dateTimePickerFactEnd.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerFactEnd.TabIndex = 16;
            this.dateTimePickerFactEnd.Value = new System.DateTime(2015, 8, 10, 13, 57, 6, 22);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Фактическое время выполнения";
            // 
            // buttonDaily
            // 
            this.buttonDaily.Location = new System.Drawing.Point(9, 115);
            this.buttonDaily.Name = "buttonDaily";
            this.buttonDaily.Size = new System.Drawing.Size(75, 23);
            this.buttonDaily.TabIndex = 13;
            this.buttonDaily.Text = "Добавить";
            this.buttonDaily.UseVisualStyleBackColor = true;
            this.buttonDaily.Click += new System.EventHandler(this.buttonDaily_Click);
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
            this.idRequestDataGridViewTextBoxColumn,
            this.dateBegDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn});
            this.dgvDaily.DataMember = "tJ_RequestForRepairDaily";
            this.dgvDaily.DataSource = this.dataSetDamage;
            this.dgvDaily.Location = new System.Drawing.Point(178, 8);
            this.dgvDaily.Name = "dgvDaily";
            this.dgvDaily.RowHeadersWidth = 30;
            this.dgvDaily.Size = new System.Drawing.Size(791, 130);
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
            // idRequestDataGridViewTextBoxColumn
            // 
            this.idRequestDataGridViewTextBoxColumn.DataPropertyName = "idRequest";
            this.idRequestDataGridViewTextBoxColumn.HeaderText = "idRequest";
            this.idRequestDataGridViewTextBoxColumn.Name = "idRequestDataGridViewTextBoxColumn";
            this.idRequestDataGridViewTextBoxColumn.Visible = false;
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
            // checkBoxWeekEnd
            // 
            this.checkBoxWeekEnd.AutoSize = true;
            this.checkBoxWeekEnd.Checked = true;
            this.checkBoxWeekEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWeekEnd.Enabled = false;
            this.checkBoxWeekEnd.Location = new System.Drawing.Point(9, 92);
            this.checkBoxWeekEnd.Name = "checkBoxWeekEnd";
            this.checkBoxWeekEnd.Size = new System.Drawing.Size(78, 17);
            this.checkBoxWeekEnd.TabIndex = 11;
            this.checkBoxWeekEnd.Text = "Выходные";
            this.checkBoxWeekEnd.UseVisualStyleBackColor = true;
            // 
            // checkBoxDaily
            // 
            this.checkBoxDaily.AutoSize = true;
            this.checkBoxDaily.Location = new System.Drawing.Point(9, 69);
            this.checkBoxDaily.Name = "checkBoxDaily";
            this.checkBoxDaily.Size = new System.Drawing.Size(83, 17);
            this.checkBoxDaily.TabIndex = 10;
            this.checkBoxDaily.Text = "Ежедневно";
            this.checkBoxDaily.UseVisualStyleBackColor = true;
            this.checkBoxDaily.CheckedChanged += new System.EventHandler(this.checkBoxDaily_CheckedChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(30, 43);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(124, 20);
            this.dateTimePickerEnd.TabIndex = 1;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "по";
            // 
            // dateTimePickerBeg
            // 
            this.dateTimePickerBeg.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerBeg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBeg.Location = new System.Drawing.Point(30, 19);
            this.dateTimePickerBeg.Name = "dateTimePickerBeg";
            this.dateTimePickerBeg.Size = new System.Drawing.Size(124, 20);
            this.dateTimePickerBeg.TabIndex = 0;
            this.dateTimePickerBeg.ValueChanged += new System.EventHandler(this.dateTimePickerBeg_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "с";
            // 
            // groupBoxODS
            // 
            this.groupBoxODS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxODS.Controls.Add(this.cmbStatus);
            this.groupBoxODS.Controls.Add(this.labelStatus);
            this.groupBoxODS.Controls.Add(this.txtAddress);
            this.groupBoxODS.Controls.Add(this.cmbDispatcher);
            this.groupBoxODS.Controls.Add(this.label14);
            this.groupBoxODS.Controls.Add(this.label13);
            this.groupBoxODS.Controls.Add(this.dateTimePickerDateAgreed);
            this.groupBoxODS.Controls.Add(this.checkBoxAgreed);
            this.groupBoxODS.Controls.Add(this.labelAddress);
            this.groupBoxODS.Controls.Add(this.label11);
            this.groupBoxODS.Controls.Add(this.label10);
            this.groupBoxODS.Controls.Add(this.txtComment);
            this.groupBoxODS.Controls.Add(this.txtAgreeWith);
            this.groupBoxODS.Location = new System.Drawing.Point(11, 411);
            this.groupBoxODS.Name = "groupBoxODS";
            this.groupBoxODS.Size = new System.Drawing.Size(969, 200);
            this.groupBoxODS.TabIndex = 9;
            this.groupBoxODS.TabStop = false;
            this.groupBoxODS.VisibleChanged += new System.EventHandler(this.groupBoxODS_VisibleChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.status", true));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(160, 170);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(379, 21);
            this.cmbStatus.TabIndex = 13;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(74, 173);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(80, 13);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Статус заявки";
            // 
            // txtAdress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.Address", true));
            this.txtAddress.Location = new System.Drawing.Point(101, 71);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAdress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(862, 72);
            this.txtAddress.TabIndex = 11;
            // 
            // cmbDispatcher
            // 
            this.cmbDispatcher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDispatcher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDispatcher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDispatcher.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.WorkerAgreed", true));
            this.cmbDispatcher.FormattingEnabled = true;
            this.cmbDispatcher.Location = new System.Drawing.Point(412, 145);
            this.cmbDispatcher.Name = "cmbDispatcher";
            this.cmbDispatcher.Size = new System.Drawing.Size(551, 21);
            this.cmbDispatcher.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(329, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Согласующий";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(121, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Дата";
            // 
            // dateTimePickerDateAgreed
            // 
            this.dateTimePickerDateAgreed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerDateAgreed.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_RequestForRepair.DateAgreed", true));
            this.dateTimePickerDateAgreed.Location = new System.Drawing.Point(160, 147);
            this.dateTimePickerDateAgreed.Name = "dateTimePickerDateAgreed";
            this.dateTimePickerDateAgreed.Size = new System.Drawing.Size(163, 20);
            this.dateTimePickerDateAgreed.TabIndex = 7;
            this.dateTimePickerDateAgreed.Value = new System.DateTime(2012, 9, 26, 9, 58, 28, 932);
            // 
            // checkBoxAgreed
            // 
            this.checkBoxAgreed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAgreed.AutoSize = true;
            this.checkBoxAgreed.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetDamage, "tJ_RequestForRepair.Agreed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxAgreed.Location = new System.Drawing.Point(9, 150);
            this.checkBoxAgreed.Name = "checkBoxAgreed";
            this.checkBoxAgreed.Size = new System.Drawing.Size(92, 17);
            this.checkBoxAgreed.TabIndex = 6;
            this.checkBoxAgreed.Text = "Согласовано";
            this.checkBoxAgreed.UseVisualStyleBackColor = true;
            this.checkBoxAgreed.CheckedChanged += new System.EventHandler(this.checkBoxAgreed_CheckedChanged);
            this.checkBoxAgreed.CheckStateChanged += new System.EventHandler(this.checkBoxAgreed_CheckStateChanged);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(6, 74);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(44, 13);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Адреса";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Комментарий";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Согласовать с";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.Comment", true));
            this.txtComment.Location = new System.Drawing.Point(101, 45);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(862, 20);
            this.txtComment.TabIndex = 1;
            // 
            // txtAgreeWith
            // 
            this.txtAgreeWith.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgreeWith.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.AgreeWith", true));
            this.txtAgreeWith.Location = new System.Drawing.Point(101, 19);
            this.txtAgreeWith.Name = "txtAgreeWith";
            this.txtAgreeWith.Size = new System.Drawing.Size(862, 20);
            this.txtAgreeWith.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(15, 678);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // cmbUserCreate
            // 
            this.cmbUserCreate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.idUserCreate", true));
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
            this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.num", true));
            this.txtNum.Location = new System.Drawing.Point(358, 5);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(622, 20);
            this.txtNum.TabIndex = 14;
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(276, 86);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(56, 13);
            this.labelWorker.TabIndex = 15;
            this.labelWorker.Text = "Оператор";
            this.labelWorker.Visible = false;
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
            this.dtpDateCreate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_RequestForRepair.dateCreate", true));
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
            this.tabControl.Controls.Add(this.tabPageSwitching);
            this.tabControl.Controls.Add(this.tabPageDocuments);
            this.tabControl.Controls.Add(this.tabPageLog);
            this.tabControl.Controls.Add(this.tabPageAbn);
            this.tabControl.Controls.Add(this.tabPageTransformer);
            this.tabControl.Location = new System.Drawing.Point(-4, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 669);
            this.tabControl.TabIndex = 49;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.chkSendToSite);
            this.tabPageGeneral.Controls.Add(this.cmbGroupWorks);
            this.tabPageGeneral.Controls.Add(this.labelGroupWork);
            this.tabPageGeneral.Controls.Add(this.cmbPerformerOrganization);
            this.tabPageGeneral.Controls.Add(this.labelPerformer);
            this.tabPageGeneral.Controls.Add(this.cmbOrganization);
            this.tabPageGeneral.Controls.Add(this.labelOrganization);
            this.tabPageGeneral.Controls.Add(this.cmbRegion);
            this.tabPageGeneral.Controls.Add(this.txtRequestFiled);
            this.tabPageGeneral.Controls.Add(this.toolStripMain);
            this.tabPageGeneral.Controls.Add(this.cmbSR);
            this.tabPageGeneral.Controls.Add(this.label1);
            this.tabPageGeneral.Controls.Add(this.groupBoxDaily);
            this.tabPageGeneral.Controls.Add(this.cmbWorker);
            this.tabPageGeneral.Controls.Add(this.labelRequestFiled);
            this.tabPageGeneral.Controls.Add(this.groupBoxODS);
            this.tabPageGeneral.Controls.Add(this.dtpDateCreate);
            this.tabPageGeneral.Controls.Add(this.label2);
            this.tabPageGeneral.Controls.Add(this.groupBox1);
            this.tabPageGeneral.Controls.Add(this.labelSR);
            this.tabPageGeneral.Controls.Add(this.labelWorker);
            this.tabPageGeneral.Controls.Add(this.cmbUserCreate);
            this.tabPageGeneral.Controls.Add(this.txtNum);
            this.tabPageGeneral.Controls.Add(this.label15);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(992, 643);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Общие";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // chkSendToSite
            // 
            this.chkSendToSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSendToSite.AutoSize = true;
            this.chkSendToSite.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetDamage, "tJ_RequestForRepair.SendSite", true));
            this.chkSendToSite.Location = new System.Drawing.Point(20, 620);
            this.chkSendToSite.Name = "chkSendToSite";
            this.chkSendToSite.Size = new System.Drawing.Size(121, 17);
            this.chkSendToSite.TabIndex = 27;
            this.chkSendToSite.Text = "Отправить на сайт";
            this.chkSendToSite.UseVisualStyleBackColor = true;
            // 
            // cmbGroupWorks
            // 
            this.cmbGroupWorks.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsRequestForRepair, "groupWorks", true));
            this.cmbGroupWorks.FormattingEnabled = true;
            this.cmbGroupWorks.Location = new System.Drawing.Point(391, 384);
            this.cmbGroupWorks.Name = "cmbGroupWorks";
            this.cmbGroupWorks.Size = new System.Drawing.Size(159, 21);
            this.cmbGroupWorks.TabIndex = 26;
            this.cmbGroupWorks.SelectedIndexChanged += new System.EventHandler(this.cmbGroupWorks_SelectedIndexChanged);
            // 
            // bsRequestForRepair
            // 
            this.bsRequestForRepair.DataMember = "tJ_RequestForRepair";
            this.bsRequestForRepair.DataSource = this.dataSetDamage;
            // 
            // labelGroupWork
            // 
            this.labelGroupWork.AutoSize = true;
            this.labelGroupWork.Location = new System.Drawing.Point(388, 368);
            this.labelGroupWork.Name = "labelGroupWork";
            this.labelGroupWork.Size = new System.Drawing.Size(74, 13);
            this.labelGroupWork.TabIndex = 25;
            this.labelGroupWork.Text = "Группа работ";
            // 
            // cmbPerformerOrganization
            // 
            this.cmbPerformerOrganization.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.performerOrganization", true));
            this.cmbPerformerOrganization.FormattingEnabled = true;
            this.cmbPerformerOrganization.Location = new System.Drawing.Point(189, 384);
            this.cmbPerformerOrganization.Name = "cmbPerformerOrganization";
            this.cmbPerformerOrganization.Size = new System.Drawing.Size(193, 21);
            this.cmbPerformerOrganization.TabIndex = 24;
            this.cmbPerformerOrganization.SelectedIndexChanged += new System.EventHandler(this.cmbPerformerOrganization_SelectedIndexChanged);
            // 
            // labelPerformer
            // 
            this.labelPerformer.AutoSize = true;
            this.labelPerformer.Location = new System.Drawing.Point(186, 368);
            this.labelPerformer.Name = "labelPerformer";
            this.labelPerformer.Size = new System.Drawing.Size(144, 13);
            this.labelPerformer.TabIndex = 23;
            this.labelPerformer.Text = "Фактический исполнитель";
            // 
            // cmbOrganization
            // 
            this.cmbOrganization.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.organization", true));
            this.cmbOrganization.FormattingEnabled = true;
            this.cmbOrganization.Location = new System.Drawing.Point(20, 384);
            this.cmbOrganization.Name = "cmbOrganization";
            this.cmbOrganization.Size = new System.Drawing.Size(163, 21);
            this.cmbOrganization.TabIndex = 22;
            this.cmbOrganization.SelectedIndexChanged += new System.EventHandler(this.cmbOrganization_SelectedIndexChanged);
            // 
            // labelOrganization
            // 
            this.labelOrganization.AutoSize = true;
            this.labelOrganization.Location = new System.Drawing.Point(17, 368);
            this.labelOrganization.Name = "labelOrganization";
            this.labelOrganization.Size = new System.Drawing.Size(111, 13);
            this.labelOrganization.TabIndex = 21;
            this.labelOrganization.Text = "Ответственное лицо";
            // 
            // cmbRegion
            // 
            this.cmbRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbRegion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRegion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRegion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.idRegion", true));
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(358, 63);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(622, 21);
            this.cmbRegion.TabIndex = 20;
            this.cmbRegion.SelectedValueChanged += new System.EventHandler(this.cmbRegion_SelectedValueChanged);
            // 
            // txtRequestFiled
            // 
            this.txtRequestFiled.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRequestFiled.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtRequestFiled.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.reguestFiled", true));
            this.txtRequestFiled.FormattingEnabled = true;
            this.txtRequestFiled.Location = new System.Drawing.Point(101, 62);
            this.txtRequestFiled.Name = "txtRequestFiled";
            this.txtRequestFiled.Size = new System.Drawing.Size(181, 21);
            this.txtRequestFiled.TabIndex = 19;
            this.txtRequestFiled.SelectedIndexChanged += new System.EventHandler(this.txtRequestFiled_SelectedIndexChanged);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnCopy,
            this.toolBtnSettingsFTP});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(26, 25);
            this.toolStripMain.TabIndex = 18;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolBtnCopy
            // 
            this.toolBtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnCopy.Image = global::RequestForRepairN.Properties.Resources.CopyBuffer;
            this.toolBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnCopy.Name = "toolBtnCopy";
            this.toolBtnCopy.Size = new System.Drawing.Size(23, 22);
            this.toolBtnCopy.Text = "Копировать";
            this.toolBtnCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // toolBtnSettingsFTP
            // 
            this.toolBtnSettingsFTP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSettingsFTP.Image = global::RequestForRepairN.Properties.Resources.FTP;
            this.toolBtnSettingsFTP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSettingsFTP.Name = "toolBtnSettingsFTP";
            this.toolBtnSettingsFTP.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSettingsFTP.Text = "Настройки FTP";
            this.toolBtnSettingsFTP.Visible = false;
            this.toolBtnSettingsFTP.Click += new System.EventHandler(this.toolBtnSettingsFTP_Click);
            // 
            // tabPageSwitching
            // 
            this.tabPageSwitching.Controls.Add(this.splitContainer1);
            this.tabPageSwitching.Controls.Add(this.toolStripScheme);
            this.tabPageSwitching.Location = new System.Drawing.Point(4, 22);
            this.tabPageSwitching.Name = "tabPageSwitching";
            this.tabPageSwitching.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSwitching.Size = new System.Drawing.Size(992, 643);
            this.tabPageSwitching.TabIndex = 1;
            this.tabPageSwitching.Text = "Оперативные переключения";
            this.tabPageSwitching.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 28);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvLinkObjects);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAddress);
            this.splitContainer1.Panel2.Controls.Add(this.toolStripAddress);
            this.splitContainer1.Size = new System.Drawing.Size(986, 612);
            this.splitContainer1.SplitterDistance = 276;
            this.splitContainer1.TabIndex = 50;
            // 
            // dgvLinkObjects
            // 
            this.dgvLinkObjects.AllowUserToAddRows = false;
            this.dgvLinkObjects.AllowUserToDeleteRows = false;
            this.dgvLinkObjects.AllowUserToVisibleColumns = false;
            this.dgvLinkObjects.AutoGenerateColumns = false;
            this.dgvLinkObjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLinkObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinkObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectsDataGridViewTextBoxColumn1,
            this.dateBegDataGridViewTextBoxColumn2,
            this.dateEndDataGridViewTextBoxColumn2,
            this.durationDataGridViewTextBoxColumn1,
            this.numDataGridViewTextBoxColumn1,
            this.disabledDgvColumn});
            this.dgvLinkObjects.DataSource = this.bsLinkObjects;
            this.dgvLinkObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinkObjects.Location = new System.Drawing.Point(0, 0);
            this.dgvLinkObjects.Name = "dgvLinkObjects";
            this.dgvLinkObjects.ReadOnly = true;
            this.dgvLinkObjects.RowHeadersWidth = 21;
            this.dgvLinkObjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLinkObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinkObjects.Size = new System.Drawing.Size(986, 276);
            this.dgvLinkObjects.TabIndex = 49;
            this.dgvLinkObjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinkObjects_CellDoubleClick);
            this.dgvLinkObjects.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLinkObjects_CellFormatting);
            // 
            // objectsDataGridViewTextBoxColumn1
            // 
            this.objectsDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.objectsDataGridViewTextBoxColumn1.DataPropertyName = "Objects";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.objectsDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.objectsDataGridViewTextBoxColumn1.HeaderText = "Объекты";
            this.objectsDataGridViewTextBoxColumn1.Name = "objectsDataGridViewTextBoxColumn1";
            this.objectsDataGridViewTextBoxColumn1.ReadOnly = true;
            this.objectsDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dateBegDataGridViewTextBoxColumn2
            // 
            this.dateBegDataGridViewTextBoxColumn2.DataPropertyName = "DateBeg";
            this.dateBegDataGridViewTextBoxColumn2.HeaderText = "Начало";
            this.dateBegDataGridViewTextBoxColumn2.Name = "dateBegDataGridViewTextBoxColumn2";
            this.dateBegDataGridViewTextBoxColumn2.ReadOnly = true;
            this.dateBegDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dateBegDataGridViewTextBoxColumn2.Width = 90;
            // 
            // dateEndDataGridViewTextBoxColumn2
            // 
            this.dateEndDataGridViewTextBoxColumn2.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn2.HeaderText = "Окончание";
            this.dateEndDataGridViewTextBoxColumn2.Name = "dateEndDataGridViewTextBoxColumn2";
            this.dateEndDataGridViewTextBoxColumn2.ReadOnly = true;
            this.dateEndDataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dateEndDataGridViewTextBoxColumn2.Width = 90;
            // 
            // durationDataGridViewTextBoxColumn1
            // 
            this.durationDataGridViewTextBoxColumn1.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn1.HeaderText = "Длительность";
            this.durationDataGridViewTextBoxColumn1.Name = "durationDataGridViewTextBoxColumn1";
            this.durationDataGridViewTextBoxColumn1.ReadOnly = true;
            this.durationDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.durationDataGridViewTextBoxColumn1.Width = 90;
            // 
            // numDataGridViewTextBoxColumn1
            // 
            this.numDataGridViewTextBoxColumn1.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn1.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn1.Name = "numDataGridViewTextBoxColumn1";
            this.numDataGridViewTextBoxColumn1.ReadOnly = true;
            this.numDataGridViewTextBoxColumn1.Visible = false;
            // 
            // disabledDgvColumn
            // 
            this.disabledDgvColumn.DataPropertyName = "Disabled";
            this.disabledDgvColumn.HeaderText = "Disabled";
            this.disabledDgvColumn.Name = "disabledDgvColumn";
            this.disabledDgvColumn.ReadOnly = true;
            this.disabledDgvColumn.Visible = false;
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
            // dgvAddress
            // 
            this.dgvAddress.AllowUserToAddRows = false;
            this.dgvAddress.AllowUserToDeleteRows = false;
            this.dgvAddress.AutoGenerateColumns = false;
            this.dgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityDataGridViewTextBoxColumn,
            this.idAddressDgvColumn,
            this.idRequestDataGridViewTextBoxColumn2,
            this.idKladrObjDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.idKladrStreetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgvAddress.DataSource = this.bsAddress;
            this.dgvAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddress.Location = new System.Drawing.Point(0, 25);
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            this.dgvAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddress.Size = new System.Drawing.Size(986, 307);
            this.dgvAddress.TabIndex = 1;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.FillWeight = 30F;
            this.cityDataGridViewTextBoxColumn.HeaderText = "Нас пункт";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAddressDgvColumn
            // 
            this.idAddressDgvColumn.DataPropertyName = "id";
            this.idAddressDgvColumn.HeaderText = "id";
            this.idAddressDgvColumn.Name = "idAddressDgvColumn";
            this.idAddressDgvColumn.ReadOnly = true;
            this.idAddressDgvColumn.Visible = false;
            // 
            // idRequestDataGridViewTextBoxColumn2
            // 
            this.idRequestDataGridViewTextBoxColumn2.DataPropertyName = "idRequest";
            this.idRequestDataGridViewTextBoxColumn2.HeaderText = "idRequest";
            this.idRequestDataGridViewTextBoxColumn2.Name = "idRequestDataGridViewTextBoxColumn2";
            this.idRequestDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idRequestDataGridViewTextBoxColumn2.Visible = false;
            // 
            // idKladrObjDataGridViewTextBoxColumn
            // 
            this.idKladrObjDataGridViewTextBoxColumn.DataPropertyName = "idKladrObj";
            this.idKladrObjDataGridViewTextBoxColumn.HeaderText = "idKladrObj";
            this.idKladrObjDataGridViewTextBoxColumn.Name = "idKladrObjDataGridViewTextBoxColumn";
            this.idKladrObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKladrObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.FillWeight = 50F;
            this.streetDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idKladrStreetDataGridViewTextBoxColumn
            // 
            this.idKladrStreetDataGridViewTextBoxColumn.DataPropertyName = "idKladrStreet";
            this.idKladrStreetDataGridViewTextBoxColumn.HeaderText = "idKladrStreet";
            this.idKladrStreetDataGridViewTextBoxColumn.Name = "idKladrStreetDataGridViewTextBoxColumn";
            this.idKladrStreetDataGridViewTextBoxColumn.ReadOnly = true;
            this.idKladrStreetDataGridViewTextBoxColumn.Visible = false;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.FillWeight = 20F;
            this.houseDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsAddress
            // 
            this.bsAddress.DataMember = "tableAddress";
            this.bsAddress.DataSource = this.dsLinkObjects;
            this.bsAddress.Sort = "City, Street, House";
            // 
            // toolStripAddress
            // 
            this.toolStripAddress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddAddress,
            this.toolBtnDelAddress});
            this.toolStripAddress.Location = new System.Drawing.Point(0, 0);
            this.toolStripAddress.Name = "toolStripAddress";
            this.toolStripAddress.Size = new System.Drawing.Size(986, 25);
            this.toolStripAddress.TabIndex = 0;
            this.toolStripAddress.Text = "toolStrip1";
            // 
            // toolBtnAddAddress
            // 
            this.toolBtnAddAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddAddress.Image = global::RequestForRepairN.Properties.Resources.ElementAdd;
            this.toolBtnAddAddress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddAddress.Name = "toolBtnAddAddress";
            this.toolBtnAddAddress.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddAddress.Text = "Добавить адрес";
            this.toolBtnAddAddress.Click += new System.EventHandler(this.toolBtnAddAddress_Click);
            // 
            // toolBtnDelAddress
            // 
            this.toolBtnDelAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelAddress.Image = global::RequestForRepairN.Properties.Resources.ElementDel;
            this.toolBtnDelAddress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelAddress.Name = "toolBtnDelAddress";
            this.toolBtnDelAddress.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelAddress.Text = "Удалить адрес";
            this.toolBtnDelAddress.Click += new System.EventHandler(this.toolBtnDelAddress_Click);
            // 
            // tabPageDocuments
            // 
            this.tabPageDocuments.Controls.Add(this.dgvDocs);
            this.tabPageDocuments.Controls.Add(this.toolStripDocuments);
            this.tabPageDocuments.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocuments.Name = "tabPageDocuments";
            this.tabPageDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocuments.Size = new System.Drawing.Size(992, 643);
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
            this.idRequestDataGridViewTextBoxColumn1,
            this.fileNameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.ColumnImage});
            this.dgvDocs.DataSource = this.bsRequestForRepairDoc;
            this.dgvDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocs.Location = new System.Drawing.Point(3, 28);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.RowHeadersWidth = 21;
            this.dgvDocs.Size = new System.Drawing.Size(986, 612);
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
            // idRequestDataGridViewTextBoxColumn1
            // 
            this.idRequestDataGridViewTextBoxColumn1.DataPropertyName = "idRequest";
            this.idRequestDataGridViewTextBoxColumn1.HeaderText = "idRequest";
            this.idRequestDataGridViewTextBoxColumn1.Name = "idRequestDataGridViewTextBoxColumn1";
            this.idRequestDataGridViewTextBoxColumn1.Visible = false;
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
            this.bsRequestForRepairDoc.DataMember = "tJ_RequestForRepairDoc";
            this.bsRequestForRepairDoc.DataSource = this.dataSetDamage;
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
            this.toolStripDocuments.Size = new System.Drawing.Size(986, 25);
            this.toolStripDocuments.TabIndex = 0;
            this.toolStripDocuments.Text = "toolStrip1";
            // 
            // toolBtnAddDoc
            // 
            this.toolBtnAddDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddDoc.Image = global::RequestForRepairN.Properties.Resources.ElementAdd;
            this.toolBtnAddDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddDoc.Name = "toolBtnAddDoc";
            this.toolBtnAddDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddDoc.Text = "Добавить документ";
            this.toolBtnAddDoc.Click += new System.EventHandler(this.toolBtnAddDoc_Click);
            // 
            // toolBtnDelDoc
            // 
            this.toolBtnDelDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelDoc.Image = global::RequestForRepairN.Properties.Resources.ElementDel;
            this.toolBtnDelDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelDoc.Name = "toolBtnDelDoc";
            this.toolBtnDelDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelDoc.Text = "Удалить документ";
            this.toolBtnDelDoc.Click += new System.EventHandler(this.toolBtnDelDoc_Click);
            // 
            // toolBtnViewDoc
            // 
            this.toolBtnViewDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnViewDoc.Image = global::RequestForRepairN.Properties.Resources.ElementInformation;
            this.toolBtnViewDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnViewDoc.Name = "toolBtnViewDoc";
            this.toolBtnViewDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnViewDoc.Text = "Открыть документ";
            this.toolBtnViewDoc.Click += new System.EventHandler(this.toolBtnViewDoc_Click);
            // 
            // toolBtnSaveDoc
            // 
            this.toolBtnSaveDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSaveDoc.Image = global::RequestForRepairN.Properties.Resources.ElementGo;
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
            this.tabPageLog.Size = new System.Drawing.Size(992, 643);
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
            this.idRequestDataGridViewTextBoxColumn3,
            this.userLogIDDataGridViewTextBoxColumn,
            this.userLogDataGridViewTextBoxColumn,
            this.userLogNameDataGridViewTextBoxColumn,
            this.idCommandDataGridViewTextBoxColumn,
            this.commandDataGridViewTextBoxColumn,
            this.isSiteDataGridViewCheckBoxColumn});
            this.dataGridViewExcelFilter1.DataSource = this.bsRequestForRepairLog;
            this.dataGridViewExcelFilter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewExcelFilter1.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewExcelFilter1.Name = "dataGridViewExcelFilter1";
            this.dataGridViewExcelFilter1.ReadOnly = true;
            this.dataGridViewExcelFilter1.RowHeadersWidth = 21;
            this.dataGridViewExcelFilter1.Size = new System.Drawing.Size(986, 637);
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
            // idRequestDataGridViewTextBoxColumn3
            // 
            this.idRequestDataGridViewTextBoxColumn3.DataPropertyName = "idRequest";
            this.idRequestDataGridViewTextBoxColumn3.HeaderText = "idRequest";
            this.idRequestDataGridViewTextBoxColumn3.Name = "idRequestDataGridViewTextBoxColumn3";
            this.idRequestDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idRequestDataGridViewTextBoxColumn3.Visible = false;
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
            // isSiteDataGridViewCheckBoxColumn
            // 
            this.isSiteDataGridViewCheckBoxColumn.DataPropertyName = "isSite";
            this.isSiteDataGridViewCheckBoxColumn.HeaderText = "isSite";
            this.isSiteDataGridViewCheckBoxColumn.Name = "isSiteDataGridViewCheckBoxColumn";
            this.isSiteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bsRequestForRepairLog
            // 
            this.bsRequestForRepairLog.DataMember = "tJ_RequestForRepairLog";
            this.bsRequestForRepairLog.DataSource = this.dataSetDamage;
            this.bsRequestForRepairLog.Sort = "dateLog desc, id desc";
            // 
            // tabPageAbn
            // 
            this.tabPageAbn.Controls.Add(this.splitContainerAbn);
            this.tabPageAbn.Controls.Add(this.statusStripAbnObj);
            this.tabPageAbn.Controls.Add(this.toolStripAbn);
            this.tabPageAbn.Location = new System.Drawing.Point(4, 22);
            this.tabPageAbn.Name = "tabPageAbn";
            this.tabPageAbn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbn.Size = new System.Drawing.Size(992, 643);
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
            this.splitContainerAbn.Size = new System.Drawing.Size(986, 590);
            this.splitContainerAbn.SplitterDistance = 378;
            this.splitContainerAbn.TabIndex = 9;
        //// 
        // 
        // dgvAbn
        // 
        this.dgvAbn.AllowUserToAddRows = false;
            this.dgvAbn.AllowUserToDeleteRows = false;
            this.dgvAbn.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAbn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAbn.AutoGenerateColumns = false;
            this.dgvAbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.nameAddressAbnObjColumn,//
            this.codeAbonentDataGridViewTextBoxColumn,
            this.idAbnDataGridViewTextBoxColumn,
            this.nameAbnDataGridViewTextBoxColumn,
            this.typeAbnDgvColumn,
            this.idAbnObjDataGridViewTextBoxColumn,
            this.nameObjDataGridViewTextBoxColumn,
            this.categoryNameDgvColumn,
            this.tarifNameDgvColumn,
            this.powerSetDgvColumn,
            this.countPointDgvColumn,
            this.commentODSDgvColumn,
            this.idSchmObjDataGridViewTextBoxColumn,
            this.kladrObjIdDataGridViewTextBoxColumn,
            this.idStreetDataGridViewTextBoxColumn,
            this.housesDataGridViewTextBoxColumn});
            //this.dgvAbn.DataSource = this.bsSchmAbnFull;
            this.dgvAbn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbn.Location = new System.Drawing.Point(0, 0);
            this.dgvAbn.Name = "dgvAbn";
            this.dgvAbn.ReadOnly = true;
        this.dgvAbn.ImageList = null;
        this.dgvAbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbn.Size = new System.Drawing.Size(986, 378);
            this.dgvAbn.TabIndex = 7;

        //
        // nameAddressAbnObjColumn
        //
        this.nameAddressAbnObjColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
        this.nameAddressAbnObjColumn.DataPropertyName = "idAddress";
        this.nameAddressAbnObjColumn.DefaultNodeImage = null;
        this.nameAddressAbnObjColumn.HeaderText = "Адрес";
        this.nameAddressAbnObjColumn.Name = "nameAddressAbnObjColumn";
        this.nameAddressAbnObjColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
        // 
        // codeAbonentDataGridViewTextBoxColumn
        // 
        this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "codeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            //this.codeAbonentDataGridViewTextBoxColumn.Visible = false;
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
        // idSchmObjDataGridViewTextBoxColumn
        //
        this.idSchmObjDataGridViewTextBoxColumn.DataPropertyName = "idSchmObj";
        this.idSchmObjDataGridViewTextBoxColumn.HeaderText = "idSchmObj";
        this.idSchmObjDataGridViewTextBoxColumn.Name = "idSchmObjDataGridViewTextBoxColumn";
        this.idSchmObjDataGridViewTextBoxColumn.ReadOnly = true;
        this.idSchmObjDataGridViewTextBoxColumn.Visible = false;


        //
        // kladrObjIdDataGridViewTextBoxColumn
        //
        this.kladrObjIdDataGridViewTextBoxColumn.DataPropertyName = "KladrObjId";
        this.kladrObjIdDataGridViewTextBoxColumn.HeaderText = "KladrObjId";
        this.kladrObjIdDataGridViewTextBoxColumn.Name = "kladrObjIdDataGridViewTextBoxColumn";
        this.kladrObjIdDataGridViewTextBoxColumn.ReadOnly = true;
        this.kladrObjIdDataGridViewTextBoxColumn.Visible = false;
        //
        // idStreetDataGridViewTextBoxColumn
        //
        this.idStreetDataGridViewTextBoxColumn.DataPropertyName = "idStreet";
        this.idStreetDataGridViewTextBoxColumn.HeaderText = "idStreet";
        this.idStreetDataGridViewTextBoxColumn.Name = "idStreetDataGridViewTextBoxColumn";
        this.idStreetDataGridViewTextBoxColumn.ReadOnly = true;
        this.idStreetDataGridViewTextBoxColumn.Visible = false;
        //
        // housesDataGridViewTextBoxColumn
        //
        this.housesDataGridViewTextBoxColumn.DataPropertyName = "house";
        this.housesDataGridViewTextBoxColumn.HeaderText = "house";
        this.housesDataGridViewTextBoxColumn.Name = "housesDataGridViewTextBoxColumn";
        this.housesDataGridViewTextBoxColumn.ReadOnly = true;
        this.housesDataGridViewTextBoxColumn.Visible = false;
        // 
        // nameAbnDataGridViewTextBoxColumn
        // 
        this.nameAbnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameAbnDataGridViewTextBoxColumn.DataPropertyName = "nameAbn";
            this.nameAbnDataGridViewTextBoxColumn.FillWeight = 80.22783F;
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
            this.typeAbnDgvColumn.FillWeight = 67.65158F;
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
            this.nameObjDataGridViewTextBoxColumn.FillWeight = 91.93676F;
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
            this.commentODSDgvColumn.FillWeight = 108.416F;
            this.commentODSDgvColumn.HeaderText = "Примечание";
            this.commentODSDgvColumn.Name = "commentODSDgvColumn";
            this.commentODSDgvColumn.ReadOnly = true;
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
            this.dataColumnTarifName,
            this.dataColumnPowerSet,
            this.dataColumncountPoint,
            this.dataColumnidSchmObj,
            this.dataColumnKladrObjId,
            this.dataColumnidStreet,
            this.dataColumnhouse
            });
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
        // dataColumnTarifName
        // 
        this.dataColumnTarifName.ColumnName = "TarifName";
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
            //this.dataColumnhouse.DataType = typeof(int);





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
            this.splitContainerAbnCount.Size = new System.Drawing.Size(986, 208);
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
            this.groupBox7.Size = new System.Drawing.Size(231, 183);
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
            this.numCountAbnObj670.Size = new System.Drawing.Size(216, 20);
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
            this.numCountAbnObj150670.Size = new System.Drawing.Size(216, 20);
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
            this.numCountAbnObj150.Size = new System.Drawing.Size(216, 20);
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
            this.statusStripAbnObj.Location = new System.Drawing.Point(3, 618);
            this.statusStripAbnObj.Name = "statusStripAbnObj";
            this.statusStripAbnObj.Size = new System.Drawing.Size(986, 22);
            this.statusStripAbnObj.TabIndex = 8;
            this.statusStripAbnObj.Text = "statusStrip1";
            // 
            // toolBtnRefreshCountAbn
            // 
            this.toolBtnRefreshCountAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshCountAbn.Image = global::RequestForRepairN.Properties.Resources.refresh_16;
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
            this.labelCountPoint.Size = new System.Drawing.Size(317, 17);
            this.labelCountPoint.Spring = true;
            this.labelCountPoint.Text = "Количество точек поставки: 0";
            // 
            // labelCountAbnObj
            // 
            this.labelCountAbnObj.Name = "labelCountAbnObj";
            this.labelCountAbnObj.Size = new System.Drawing.Size(317, 17);
            this.labelCountAbnObj.Spring = true;
            this.labelCountAbnObj.Text = "Количество объектов: 0";
            // 
            // labelCountAbn
            // 
            this.labelCountAbn.Name = "labelCountAbn";
            this.labelCountAbn.Size = new System.Drawing.Size(317, 17);
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
            this.toolStripAbn.Size = new System.Drawing.Size(986, 25);
            this.toolStripAbn.TabIndex = 6;
            this.toolStripAbn.Text = "toolStrip1";
            // 
            // toolBtnRefreshAbn
            // 
            this.toolBtnRefreshAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshAbn.Image = global::RequestForRepairN.Properties.Resources.refresh_16;
            this.toolBtnRefreshAbn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefreshAbn.Name = "toolBtnRefreshAbn";
            this.toolBtnRefreshAbn.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRefreshAbn.Text = "Обновить";
            this.toolBtnRefreshAbn.Click += new System.EventHandler(this.toolBtnRefreshAbn_Click);
            // 
            // toolBrnDelAbn
            // 
            this.toolBtnDelAbn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelAbn.Image = global::RequestForRepairN.Properties.Resources.ElementDel;
            this.toolBtnDelAbn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelAbn.Name = "toolBtnDelAbn";
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
            this.tabPageTransformer.Size = new System.Drawing.Size(992, 643);
            this.tabPageTransformer.TabIndex = 5;
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
            this.splitContainerTrans.Size = new System.Drawing.Size(986, 590);
            this.splitContainerTrans.SplitterDistance = 295;
            this.splitContainerTrans.TabIndex = 4;
            // 
            // dgvTrans
            // 
            this.dgvTrans.AllowUserToAddRows = false;
            this.dgvTrans.AllowUserToDeleteRows = false;
            this.dgvTrans.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle6.Format = "g";
            dataGridViewCellStyle6.NullValue = null;
            this.dgvTrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTrans.AutoGenerateColumns = false;
            this.dgvTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSubDataGridViewTextBoxColumn,
            this.subDataGridViewTextBoxColumn,
            this.idTrDataGridViewTextBoxColumn,
            this.trNameDataGridViewTextBoxColumn,
            this.powerDataGridViewTextBoxColumn,
            this.loadDataGridViewTextBoxColumn});
            this.dgvTrans.DataSource = this.bsTransON;
            this.dgvTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrans.Location = new System.Drawing.Point(0, 0);
            this.dgvTrans.Name = "dgvTrans";
            this.dgvTrans.RowHeadersWidth = 21;
            this.dgvTrans.Size = new System.Drawing.Size(986, 295);
            this.dgvTrans.TabIndex = 2;
            // 
            // idSubDataGridViewTextBoxColumn
            // 
            this.idSubDataGridViewTextBoxColumn.DataPropertyName = "idSub";
            this.idSubDataGridViewTextBoxColumn.HeaderText = "idSub";
            this.idSubDataGridViewTextBoxColumn.Name = "idSubDataGridViewTextBoxColumn";
            this.idSubDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSubDataGridViewTextBoxColumn.Visible = false;
            // 
            // subDataGridViewTextBoxColumn
            // 
            this.subDataGridViewTextBoxColumn.DataPropertyName = "Sub";
            this.subDataGridViewTextBoxColumn.HeaderText = "Подстанция";
            this.subDataGridViewTextBoxColumn.Name = "subDataGridViewTextBoxColumn";
            this.subDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idTrDataGridViewTextBoxColumn
            // 
            this.idTrDataGridViewTextBoxColumn.DataPropertyName = "idTr";
            this.idTrDataGridViewTextBoxColumn.HeaderText = "idTr";
            this.idTrDataGridViewTextBoxColumn.Name = "idTrDataGridViewTextBoxColumn";
            this.idTrDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTrDataGridViewTextBoxColumn.Visible = false;
            this.idTrDataGridViewTextBoxColumn.Width = 50;
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
            this.dgvTreeSub.Name = "dgvTreeSub";
            this.dgvTreeSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTreeSub.Size = new System.Drawing.Size(986, 291);
            this.dgvTreeSub.TabIndex = 3;

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
            // statusStripTrans
            // 
            this.statusStripTrans.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelCountTr,
            this.labelSumPower,
            this.labelSumLoad});
            this.statusStripTrans.Location = new System.Drawing.Point(3, 618);
            this.statusStripTrans.Name = "statusStripTrans";
            this.statusStripTrans.Size = new System.Drawing.Size(986, 22);
            this.statusStripTrans.TabIndex = 5;
            this.statusStripTrans.Text = "statusStrip1";
            // 
            // labelCountTr
            // 
            this.labelCountTr.Name = "labelCountTr";
            this.labelCountTr.Size = new System.Drawing.Size(323, 17);
            this.labelCountTr.Spring = true;
            this.labelCountTr.Text = "Кол-во трансформаторов: 0";
            // 
            // labelSumPower
            // 
            this.labelSumPower.Name = "labelSumPower";
            this.labelSumPower.Size = new System.Drawing.Size(323, 17);
            this.labelSumPower.Spring = true;
            this.labelSumPower.Text = "Суммарная мощность: 0";
            // 
            // labelSumLoad
            // 
            this.labelSumLoad.Name = "labelSumLoad";
            this.labelSumLoad.Size = new System.Drawing.Size(323, 17);
            this.labelSumLoad.Spring = true;
            this.labelSumLoad.Text = "Суммарная нагрузка: 0";
            // 
            // toolStripTransformer
            // 
            this.toolStripTransformer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnRefreshTrans});
            this.toolStripTransformer.Location = new System.Drawing.Point(3, 3);
            this.toolStripTransformer.Name = "toolStripTransformer";
            this.toolStripTransformer.Size = new System.Drawing.Size(986, 25);
            this.toolStripTransformer.TabIndex = 0;
            this.toolStripTransformer.Text = "toolStrip1";
            // 
            // toolBtnRefreshTrans
            // 
            this.toolBtnRefreshTrans.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefreshTrans.Image = global::RequestForRepairN.Properties.Resources.refresh_16;
            this.toolBtnRefreshTrans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefreshTrans.Name = "toolBtnRefreshTrans";
            this.toolBtnRefreshTrans.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRefreshTrans.Text = "Обновить";
            this.toolBtnRefreshTrans.Click += new System.EventHandler(this.toolBtnRefreshTrans_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCopy.Location = new System.Drawing.Point(240, 682);
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
            this.buttonCancel.Location = new System.Drawing.Point(921, 678);
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
            this.progressBar.Location = new System.Drawing.Point(321, 678);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(594, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 53;
            this.progressBar.Visible = false;
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(93, 683);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(180, 13);
            this.labelProgress.TabIndex = 52;
            this.labelProgress.Text = "Загрузка отключенных абонентов";
            this.labelProgress.Visible = false;
            // 
            // FormJournalRequestForRepairAddEdit
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1001, 713);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormJournalRequestForRepairAddEdit";
            this.Text = "FormJournalRequestForRepairAddEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJournalRequestForRepairAddEdit_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJournalRequestForRepairAddEdit_FormClosed);
            this.Load += new System.EventHandler(this.FormJournalRequestForRepairAddEdit_Load);
            this.Shown += new System.EventHandler(this.FormJournalRequestForRepairAddEdit_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripScheme.ResumeLayout(false);
            this.toolStripScheme.PerformLayout();
            this.groupBoxDaily.ResumeLayout(false);
            this.groupBoxDaily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).EndInit();
            this.groupBoxODS.ResumeLayout(false);
            this.groupBoxODS.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepair)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.tabPageSwitching.ResumeLayout(false);
            this.tabPageSwitching.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRequestForReapirDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAddress)).EndInit();
            this.toolStripAddress.ResumeLayout(false);
            this.toolStripAddress.PerformLayout();
            this.tabPageDocuments.ResumeLayout(false);
            this.tabPageDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepairDoc)).EndInit();
            this.toolStripDocuments.ResumeLayout(false);
            this.toolStripDocuments.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcelFilter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepairLog)).EndInit();
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

		private System.ComponentModel.IContainer components = null;

		private RequestForRepairN.DataSets.DataSetDamage dataSetDamage;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.ComboBox cmbWorker;

		private System.Windows.Forms.Label labelRequestFiled;

		private System.Windows.Forms.Label labelSR;

		private System.Windows.Forms.ComboBox cmbSR;

		private System.Windows.Forms.GroupBox groupBox1;

		private System.Windows.Forms.Label label8;

		private System.Windows.Forms.ComboBox cmbIsPlanned;

		private System.Windows.Forms.Label labelIsPlanned;

		private System.Windows.Forms.Label labelPurpose;

		private System.Windows.Forms.TextBox txtPurpose;

		private System.Windows.Forms.TextBox txtObject;

		private System.Windows.Forms.Label labelObject;

		private System.Windows.Forms.Label label9;

		private System.Windows.Forms.GroupBox groupBoxODS;

		private System.Windows.Forms.TextBox txtComment;

		private System.Windows.Forms.TextBox txtAgreeWith;

		private System.Windows.Forms.Button buttonOK;

		private System.Windows.Forms.ComboBox cmbDispatcher;

		private System.Windows.Forms.Label label14;

		private System.Windows.Forms.Label label13;

		private ControlsLbr.NullableDateTimePicker dateTimePickerDateAgreed;

		private System.Windows.Forms.CheckBox checkBoxAgreed;

		private System.Windows.Forms.Label labelAddress;

		private System.Windows.Forms.Label label11;

		private System.Windows.Forms.Label label10;

		private System.Windows.Forms.ComboBox cmbUserCreate;

		private System.Windows.Forms.Label label15;

		private System.Windows.Forms.TextBox txtNum;

		private System.Windows.Forms.GroupBox groupBoxDaily;

		private System.Windows.Forms.Button buttonDaily;

		private System.Windows.Forms.DataGridView dgvDaily;

		private System.Windows.Forms.CheckBox checkBoxWeekEnd;

		private System.Windows.Forms.CheckBox checkBoxDaily;

		private System.Windows.Forms.DateTimePicker dateTimePickerEnd;

		private System.Windows.Forms.DateTimePicker dateTimePickerBeg;

		private System.Windows.Forms.Label labelWorker;

		private System.Windows.Forms.Label label2;

		private ControlsLbr.NullableDateTimePicker dtpDateCreate;

		private System.Windows.Forms.ToolStrip toolStripScheme;

		private System.Windows.Forms.ToolStripButton toolBtnLinkSchmObj;

		private System.Windows.Forms.ToolStripButton toolBtnDelSchmObj;

		private System.Windows.Forms.ToolStripButton toolBtnViewSChmObj;

		private System.Windows.Forms.TabControl tabControl;

		private System.Windows.Forms.TabPage tabPageGeneral;

		private System.Windows.Forms.TabPage tabPageSwitching;

		private System.Windows.Forms.TabPage tabPageDocuments;

		private System.Data.DataSet dsLinkObjects;

		private System.Data.DataTable tableLinkObjects;

		private System.Data.DataColumn dataColumn25;

		private System.Data.DataColumn dataColumn1;

		private System.Data.DataColumn dataColumn2;

		private System.Data.DataColumn dataColumn3;

		private System.Data.DataColumn dataColumn4;

		private System.Windows.Forms.ToolStripButton toolBtnLinkSchmObjEdit;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvLinkObjects;

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

		private System.Windows.Forms.ToolStrip toolStripMain;

		private System.Windows.Forms.ToolStripButton toolBtnCopy;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn dateBegDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn dateEndDataGridViewTextBoxColumn;

		private System.Windows.Forms.TextBox txtAddress;

		private System.Windows.Forms.ComboBox txtRequestFiled;

		private System.Windows.Forms.ComboBox cmbRegion;

		private System.Windows.Forms.ComboBox cmbTypeDisable;

		private System.Windows.Forms.Label label3;

		private System.Windows.Forms.ComboBox cmbPerformerOrganization;

		private System.Windows.Forms.Label labelPerformer;

		private System.Windows.Forms.ComboBox cmbOrganization;

		private System.Windows.Forms.Label labelOrganization;

		private System.Windows.Forms.ComboBox cmbGroupWorks;

		private System.Windows.Forms.Label labelGroupWork;

		private System.Windows.Forms.BindingSource bsRequestForRepair;

		private System.Windows.Forms.ComboBox cmbStatus;

		private System.Windows.Forms.Label labelStatus;

		private System.Windows.Forms.SplitContainer splitContainer1;

		private System.Data.DataTable tableAddress;

		private System.Data.DataColumn dataColumn8;

		private System.Data.DataColumn dataColumn9;

		private System.Data.DataColumn dataColumn10;

		private System.Data.DataColumn dataColumn11;

		private System.Data.DataColumn dataColumn12;

		private System.Data.DataColumn dataColumn13;

		private System.Data.DataColumn dataColumn14;

		private System.Data.DataColumn dataColumn15;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvAddress;

		private System.Windows.Forms.BindingSource bsAddress;

		private System.Windows.Forms.ToolStrip toolStripAddress;

		private System.Windows.Forms.ToolStripButton toolBtnAddAddress;

		private System.Windows.Forms.ToolStripButton toolBtnDelAddress;

		private System.ComponentModel.BackgroundWorker backgroundWorker;

		private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn idAddressDgvColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn2;

		private System.Windows.Forms.DataGridViewTextBoxColumn idKladrObjDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn idKladrStreetDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;

		private ControlsLbr.NullableDateTimePicker dateTimePickerFactEnd;

		private System.Windows.Forms.ToolStripButton toolBtnSettingsFTP;

		private System.Windows.Forms.ComboBox cmbTypeDamage;

		private System.Data.DataColumn dataColumn16;

		private System.Windows.Forms.DataGridViewTextBoxColumn objectsDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewTextBoxColumn dateBegDataGridViewTextBoxColumn2;

		private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn2;

		private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewCheckBoxColumn disabledDgvColumn;

		private System.Windows.Forms.CheckBox chkSendToSite;

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
private System.Data.DataColumn dataColumnTarifName;
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
    //private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvAbn;
    private ControlsLbr.TreeDataGridView dgvAbn;
    private ControlsLbr.TreeDataGridView dgvTreeAbn;

    //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
    //private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
    //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameAbnDataGridViewTextBoxColumn;
    //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterComboBoxColumn typeAbnDgvColumn;
    //private System.Windows.Forms.DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;
    //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameObjDataGridViewTextBoxColumn;
    //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn categoryNameDgvColumn;
    //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn powerSetDgvColumn;
    //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn countPointDgvColumn;
    //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn commentODSDgvColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
private System.Windows.Forms.DataGridViewTextBoxColumn idSchmObjDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn kladrObjIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idStreetDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn housesDataGridViewTextBoxColumn;


    private System.Windows.Forms.DataGridViewTextBoxColumn nameAbnDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewComboBoxColumn typeAbnDgvColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idAbnObjDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nameObjDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDgvColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn tarifNameDgvColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn powerSetDgvColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn countPointDgvColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn commentODSDgvColumn;


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
    private System.Windows.Forms.GroupBox groupBox7;
    private System.Windows.Forms.NumericUpDown numCountAbnObj670;
    private System.Windows.Forms.NumericUpDown numCountAbnObj150670;
    private System.Windows.Forms.NumericUpDown numCountAbnObj150;
    private System.Windows.Forms.Label label34;
    private System.Windows.Forms.Label label33;
    private System.Windows.Forms.Label label32;
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
    private System.Windows.Forms.ToolStripButton toolBtnDelAbn;
    private System.Windows.Forms.ProgressBar progressBar;
    private System.Windows.Forms.Label labelProgress;
    private System.Windows.Forms.TabPage tabPageTransformer;
    private System.Windows.Forms.SplitContainer splitContainerTrans;
    private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvTrans;
    private ControlsLbr.TreeDataGridView dgvTreeSub;
    private System.Windows.Forms.StatusStrip statusStripTrans;
    private System.Windows.Forms.ToolStripStatusLabel labelCountTr;
    private System.Windows.Forms.ToolStripStatusLabel labelSumPower;
    private System.Windows.Forms.ToolStripStatusLabel labelSumLoad;
    private System.Windows.Forms.ToolStrip toolStripTransformer;
    private System.Windows.Forms.ToolStripButton toolBtnRefreshTrans;
    private ControlsLbr.TreeGridColumn subNameColumn;
    private ControlsLbr.TreeGridColumn nameAddressAbnObjColumn;
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
    private System.Windows.Forms.DataGridViewTextBoxColumn idSubDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn subDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idTrDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn trNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn powerDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn loadDataGridViewTextBoxColumn;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
}
