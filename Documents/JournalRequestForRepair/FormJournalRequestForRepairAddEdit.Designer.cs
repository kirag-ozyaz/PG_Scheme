using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace RequestForRepair
{

    partial class FormJournalRequestForRepairAddEdit
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
        /// method_38
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSetN = new RequestForRepair.DataSets.DataSetN();
            this.buttonOK = new System.Windows.Forms.Button();
            this.bindingSource_2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_0 = new System.Data.DataSet();
            this.tblLinkObjects = new System.Data.DataTable();
            this.dataColumn_0 = new System.Data.DataColumn();
            this.dataColumn_1 = new System.Data.DataColumn();
            this.dataColumn_2 = new System.Data.DataColumn();
            this.dataColumn_3 = new System.Data.DataColumn();
            this.dataColumn_4 = new System.Data.DataColumn();
            this.dataColumn_17 = new System.Data.DataColumn();
            this.tblRequestForReapirDoc = new System.Data.DataTable();
            this.dataColumn_5 = new System.Data.DataColumn();
            this.dataColumn_6 = new System.Data.DataColumn();
            this.dataColumn_7 = new System.Data.DataColumn();
            this.dataColumn_8 = new System.Data.DataColumn();
            this.tblAddress = new System.Data.DataTable();
            this.dataColumn_9 = new System.Data.DataColumn();
            this.dataColumn_10 = new System.Data.DataColumn();
            this.dataColumn_11 = new System.Data.DataColumn();
            this.dataColumn_12 = new System.Data.DataColumn();
            this.dataColumn_13 = new System.Data.DataColumn();
            this.dataColumn_14 = new System.Data.DataColumn();
            this.dataColumn_15 = new System.Data.DataColumn();
            this.dataColumn_16 = new System.Data.DataColumn();
            this.bindingSource_3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource_4 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCopy = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.dgvLog = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.tabPageDocuments = new System.Windows.Forms.TabPage();
            this.dgvDocs = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumnDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRequestDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
            this.toolStripDocuments = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnViewDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSaveDoc = new System.Windows.Forms.ToolStripButton();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.tabPageSwitching = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvLinkObjects = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.objectsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBegDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disabledDgvColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvAddress = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAddressDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRequestDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKladrObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idKladrStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripAddress = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddAddress = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelAddress = new System.Windows.Forms.ToolStripButton();
            this.toolStripScheme = new System.Windows.Forms.ToolStrip();
            this.toolBtnLinkSchmObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnLinkSchmObjEdit = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelSchmObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnViewSChmObj = new System.Windows.Forms.ToolStripButton();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.chkSendToSite = new System.Windows.Forms.CheckBox();
            this.cmbGroupWorks = new System.Windows.Forms.ComboBox();
            this.labelGroupWork = new System.Windows.Forms.Label();
            this.cmbPerformerOrganization = new System.Windows.Forms.ComboBox();
            this.labelPerformer = new System.Windows.Forms.Label();
            this.cmbOrganization = new System.Windows.Forms.ComboBox();
            this.labelOrganization = new System.Windows.Forms.Label();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.cmbRequestFiled = new System.Windows.Forms.ComboBox();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSettingsFTP = new System.Windows.Forms.ToolStripButton();
            this.cmbSR = new System.Windows.Forms.ComboBox();
            this.label_0 = new System.Windows.Forms.Label();
            this.groupBoxDaily = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFactEnd = new ControlsLbr.NullableDateTimePicker();
            this.label_16 = new System.Windows.Forms.Label();
            this.buttonDaily = new System.Windows.Forms.Button();
            this.dgvDaily = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBegDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn();
            this.dateEndDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn();
            this.checkBoxWeekEnd = new System.Windows.Forms.CheckBox();
            this.checkBoxDaily = new System.Windows.Forms.CheckBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label_7 = new System.Windows.Forms.Label();
            this.dateTimePickerBeg = new System.Windows.Forms.DateTimePicker();
            this.label_3 = new System.Windows.Forms.Label();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.labelRequestFiled = new System.Windows.Forms.Label();
            this.groupBoxODS = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.cmbDispatcher = new System.Windows.Forms.ComboBox();
            this.label_8 = new System.Windows.Forms.Label();
            this.label_9 = new System.Windows.Forms.Label();
            this.dateTimePickerDateAgreed = new ControlsLbr.NullableDateTimePicker();
            this.checkBoxAgreed = new System.Windows.Forms.CheckBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.label_11 = new System.Windows.Forms.Label();
            this.label_12 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtAgreeWith = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateCreate = new ControlsLbr.NullableDateTimePicker();
            this.label_15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTypeDamage = new System.Windows.Forms.ComboBox();
            this.cmbTypeDisable = new System.Windows.Forms.ComboBox();
            this.cmbIsPlanned = new System.Windows.Forms.ComboBox();
            this.labelIsPlanned = new System.Windows.Forms.Label();
            this.labelPurpose = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.labelObject = new System.Windows.Forms.Label();
            this.labelSR = new System.Windows.Forms.Label();
            this.labelWorker = new System.Windows.Forms.Label();
            this.cmbUserCreate = new System.Windows.Forms.ComboBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label_13 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dateLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRequestDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLogNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isSiteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRequestForReapirDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_4)).BeginInit();
            this.tabPageLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            this.tabPageDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            this.toolStripDocuments.SuspendLayout();
            this.tabPageSwitching.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            this.toolStripAddress.SuspendLayout();
            this.toolStripScheme.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.groupBoxDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).BeginInit();
            this.groupBoxODS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetN
            // 
            this.dataSetN.DataSetName = "DataSetGES";
            this.dataSetN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(15, 682);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // bindingSource_2
            // 
            this.bindingSource_2.DataMember = "tJ_RequestForRepair";
            this.bindingSource_2.DataSource = this.dataSetN;
            // 
            // bindingSource_0
            // 
            this.bindingSource_0.DataMember = "tableLinkObjects";
            this.bindingSource_0.DataSource = this.dataSet_0;
            this.bindingSource_0.Sort = "Num";
            // 
            // dataSet_0
            // 
            this.dataSet_0.DataSetName = "NewDataSet";
            this.dataSet_0.Tables.AddRange(new System.Data.DataTable[] {
            this.tblLinkObjects,
            this.tblRequestForReapirDoc,
            this.tblAddress});
            // 
            // tblLinkObjects
            // 
            this.tblLinkObjects.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_0,
            this.dataColumn_1,
            this.dataColumn_2,
            this.dataColumn_3,
            this.dataColumn_4,
            this.dataColumn_17});
            this.tblLinkObjects.TableName = "tableLinkObjects";
            // 
            // dataColumn_0
            // 
            this.dataColumn_0.ColumnName = "Objects";
            // 
            // dataColumn_1
            // 
            this.dataColumn_1.ColumnName = "DateBeg";
            this.dataColumn_1.DataType = typeof(System.DateTime);
            // 
            // dataColumn_2
            // 
            this.dataColumn_2.ColumnName = "DateEnd";
            this.dataColumn_2.DataType = typeof(System.DateTime);
            // 
            // dataColumn_3
            // 
            this.dataColumn_3.ColumnName = "Duration";
            // 
            // dataColumn_4
            // 
            this.dataColumn_4.ColumnName = "Num";
            this.dataColumn_4.DataType = typeof(short);
            // 
            // dataColumn_17
            // 
            this.dataColumn_17.ColumnName = "Disabled";
            this.dataColumn_17.DataType = typeof(bool);
            // 
            // tblRequestForReapirDoc
            // 
            this.tblRequestForReapirDoc.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_5,
            this.dataColumn_6,
            this.dataColumn_7,
            this.dataColumn_8});
            this.tblRequestForReapirDoc.TableName = "tJ_RequestForReapirDoc";
            // 
            // dataColumn_5
            // 
            this.dataColumn_5.AllowDBNull = false;
            this.dataColumn_5.AutoIncrement = true;
            this.dataColumn_5.ColumnName = "id";
            this.dataColumn_5.DataType = typeof(int);
            // 
            // dataColumn_6
            // 
            this.dataColumn_6.AllowDBNull = false;
            this.dataColumn_6.ColumnName = "idRequest";
            this.dataColumn_6.DataType = typeof(int);
            // 
            // dataColumn_7
            // 
            this.dataColumn_7.ColumnName = "FileName";
            // 
            // dataColumn_8
            // 
            this.dataColumn_8.ColumnName = "Comment";
            // 
            // tblAddress
            // 
            this.tblAddress.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_9,
            this.dataColumn_10,
            this.dataColumn_11,
            this.dataColumn_12,
            this.dataColumn_13,
            this.dataColumn_14,
            this.dataColumn_15,
            this.dataColumn_16});
            this.tblAddress.TableName = "tableAddress";
            // 
            // dataColumn_9
            // 
            this.dataColumn_9.ColumnName = "id";
            this.dataColumn_9.DataType = typeof(int);
            // 
            // dataColumn_10
            // 
            this.dataColumn_10.ColumnName = "idRequest";
            this.dataColumn_10.DataType = typeof(int);
            // 
            // dataColumn_11
            // 
            this.dataColumn_11.ColumnName = "City";
            // 
            // dataColumn_12
            // 
            this.dataColumn_12.ColumnName = "idKladrObj";
            this.dataColumn_12.DataType = typeof(int);
            // 
            // dataColumn_13
            // 
            this.dataColumn_13.ColumnName = "Street";
            // 
            // dataColumn_14
            // 
            this.dataColumn_14.ColumnName = "idKladrStreet";
            this.dataColumn_14.DataType = typeof(int);
            // 
            // dataColumn_15
            // 
            this.dataColumn_15.ColumnName = "House";
            // 
            // dataColumn_16
            // 
            this.dataColumn_16.ColumnName = "Name";
            // 
            // bindingSource_3
            // 
            this.bindingSource_3.DataMember = "tableAddress";
            this.bindingSource_3.DataSource = this.dataSet_0;
            this.bindingSource_3.Sort = "City, Street, House";
            // 
            // bindingSource_1
            // 
            this.bindingSource_1.DataMember = "tJ_RequestForRepairDoc";
            this.bindingSource_1.DataSource = this.dataSetN;
            // 
            // bindingSource_4
            // 
            this.bindingSource_4.DataMember = "tJ_RequestForRepairLog";
            this.bindingSource_4.DataSource = this.dataSetN;
            this.bindingSource_4.Sort = "dateLog desc, id desc";
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
            // backgroundWorker_0
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(574, 682);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 51;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.dgvLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 22);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLog.Size = new System.Drawing.Size(657, 643);
            this.tabPageLog.TabIndex = 3;
            this.tabPageLog.Text = "Логирование";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.AutoGenerateColumns = false;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateLogDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.idRequestDataGridViewTextBoxColumn3,
            this.userLogIDDataGridViewTextBoxColumn,
            this.userLogDataGridViewTextBoxColumn,
            this.userLogNameDataGridViewTextBoxColumn,
            this.idCommandDataGridViewTextBoxColumn,
            this.commandDataGridViewTextBoxColumn,
            this.isSiteDataGridViewCheckBoxColumn});
            this.dgvLog.DataSource = this.bindingSource_4;
            this.dgvLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLog.Location = new System.Drawing.Point(3, 3);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersWidth = 21;
            this.dgvLog.Size = new System.Drawing.Size(651, 637);
            this.dgvLog.TabIndex = 0;
            // 
            // tabPageDocuments
            // 
            this.tabPageDocuments.Controls.Add(this.dgvDocs);
            this.tabPageDocuments.Controls.Add(this.toolStripDocuments);
            this.tabPageDocuments.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocuments.Name = "tabPageDocuments";
            this.tabPageDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocuments.Size = new System.Drawing.Size(657, 643);
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
            this.dgvDocs.DataSource = this.bindingSource_1;
            this.dgvDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocs.Location = new System.Drawing.Point(3, 28);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.RowHeadersWidth = 21;
            this.dgvDocs.Size = new System.Drawing.Size(651, 612);
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
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnImage.HeaderText = "";
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnImage.Width = 30;
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
            this.toolStripDocuments.Size = new System.Drawing.Size(651, 25);
            this.toolStripDocuments.TabIndex = 0;
            this.toolStripDocuments.Text = "toolStrip1";
            // 
            // toolBtnAddDoc
            // 
            this.toolBtnAddDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddDoc.Image = global::RequestForRepair.Properties.Resources.ElementAdd;
            this.toolBtnAddDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddDoc.Name = "toolBtnAddDoc";
            this.toolBtnAddDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddDoc.Text = "Добавить документ";
            this.toolBtnAddDoc.Click += new System.EventHandler(this.toolBtnAddDoc_Click);
            // 
            // toolBtnDelDoc
            // 
            this.toolBtnDelDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelDoc.Image = global::RequestForRepair.Properties.Resources.ElementDel;
            this.toolBtnDelDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelDoc.Name = "toolBtnDelDoc";
            this.toolBtnDelDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelDoc.Text = "Удалить документ";
            this.toolBtnDelDoc.Click += new System.EventHandler(this.toolBtnDelDoc_Click);
            // 
            // toolBtnViewDoc
            // 
            this.toolBtnViewDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnViewDoc.Image = global::RequestForRepair.Properties.Resources.ElementInformation;
            this.toolBtnViewDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnViewDoc.Name = "toolBtnViewDoc";
            this.toolBtnViewDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnViewDoc.Text = "Открыть документ";
            this.toolBtnViewDoc.Click += new System.EventHandler(this.toolBtnViewDoc_Click);
            // 
            // toolBtnSaveDoc
            // 
            this.toolBtnSaveDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSaveDoc.Image = global::RequestForRepair.Properties.Resources.ElementGo;
            this.toolBtnSaveDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSaveDoc.Name = "toolBtnSaveDoc";
            this.toolBtnSaveDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSaveDoc.Text = "Сохранить документ";
            this.toolBtnSaveDoc.Click += new System.EventHandler(this.toolBtnSaveDoc_Click);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(101, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(651, 25);
            this.miniToolStrip.TabIndex = 0;
            // 
            // tabPageSwitching
            // 
            this.tabPageSwitching.Controls.Add(this.splitContainer1);
            this.tabPageSwitching.Controls.Add(this.toolStripScheme);
            this.tabPageSwitching.Location = new System.Drawing.Point(4, 22);
            this.tabPageSwitching.Name = "tabPageSwitching";
            this.tabPageSwitching.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSwitching.Size = new System.Drawing.Size(657, 643);
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
            this.splitContainer1.Size = new System.Drawing.Size(651, 612);
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
            this.dgvLinkObjects.DataSource = this.bindingSource_0;
            this.dgvLinkObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinkObjects.Location = new System.Drawing.Point(0, 0);
            this.dgvLinkObjects.Name = "dgvLinkObjects";
            this.dgvLinkObjects.ReadOnly = true;
            this.dgvLinkObjects.RowHeadersWidth = 21;
            this.dgvLinkObjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLinkObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinkObjects.Size = new System.Drawing.Size(651, 276);
            this.dgvLinkObjects.TabIndex = 49;
            this.dgvLinkObjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinkObjects_CellDoubleClick);
            this.dgvLinkObjects.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLinkObjects_CellFormatting);
            // 
            // objectsDataGridViewTextBoxColumn1
            // 
            this.objectsDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.objectsDataGridViewTextBoxColumn1.DataPropertyName = "Objects";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.objectsDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvAddress.DataSource = this.bindingSource_3;
            this.dgvAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAddress.Location = new System.Drawing.Point(0, 25);
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            this.dgvAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddress.Size = new System.Drawing.Size(651, 307);
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
            // toolStripAddress
            // 
            this.toolStripAddress.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddAddress,
            this.toolBtnDelAddress});
            this.toolStripAddress.Location = new System.Drawing.Point(0, 0);
            this.toolStripAddress.Name = "toolStripAddress";
            this.toolStripAddress.Size = new System.Drawing.Size(651, 25);
            this.toolStripAddress.TabIndex = 0;
            this.toolStripAddress.Text = "toolStrip1";
            // 
            // toolBtnAddAddress
            // 
            this.toolBtnAddAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddAddress.Image = global::RequestForRepair.Properties.Resources.ElementAdd;
            this.toolBtnAddAddress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddAddress.Name = "toolBtnAddAddress";
            this.toolBtnAddAddress.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddAddress.Text = "Добавить адрес";
            this.toolBtnAddAddress.Click += new System.EventHandler(this.toolBtnAddAddress_Click);
            // 
            // toolBtnDelAddress
            // 
            this.toolBtnDelAddress.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelAddress.Image = global::RequestForRepair.Properties.Resources.ElementDel;
            this.toolBtnDelAddress.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelAddress.Name = "toolBtnDelAddress";
            this.toolBtnDelAddress.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelAddress.Text = "Удалить адрес";
            this.toolBtnDelAddress.Click += new System.EventHandler(this.toolBtnDelAddress_Click);
            // 
            // toolStripScheme
            // 
            this.toolStripScheme.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripScheme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnLinkSchmObj,
            this.toolBtnLinkSchmObjEdit,
            this.toolBtnDelSchmObj,
            this.toolBtnViewSChmObj});
            this.toolStripScheme.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStripScheme.Location = new System.Drawing.Point(3, 3);
            this.toolStripScheme.Name = "toolStripScheme";
            this.toolStripScheme.Size = new System.Drawing.Size(651, 25);
            this.toolStripScheme.TabIndex = 47;
            this.toolStripScheme.Text = "toolStrip1";
            // 
            // toolBtnLinkSchmObj
            // 
            this.toolBtnLinkSchmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnLinkSchmObj.Image = global::RequestForRepair.Properties.Resources.ElementAdd;
            this.toolBtnLinkSchmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnLinkSchmObj.Name = "toolBtnLinkSchmObj";
            this.toolBtnLinkSchmObj.Size = new System.Drawing.Size(23, 22);
            this.toolBtnLinkSchmObj.Text = "Привязать к схеме";
            this.toolBtnLinkSchmObj.Click += new System.EventHandler(this.toolBtnLinkSchmObj_Click);
            // 
            // toolBtnLinkSchmObjEdit
            // 
            this.toolBtnLinkSchmObjEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnLinkSchmObjEdit.Image = global::RequestForRepair.Properties.Resources.ElementEdit;
            this.toolBtnLinkSchmObjEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnLinkSchmObjEdit.Name = "toolBtnLinkSchmObjEdit";
            this.toolBtnLinkSchmObjEdit.Size = new System.Drawing.Size(23, 22);
            this.toolBtnLinkSchmObjEdit.Text = "Редактировать";
            this.toolBtnLinkSchmObjEdit.Click += new System.EventHandler(this.toolBtnLinkSchmObjEdit_Click);
            // 
            // toolBtnDelSchmObj
            // 
            this.toolBtnDelSchmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelSchmObj.Image = global::RequestForRepair.Properties.Resources.ElementDel;
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
            this.toolBtnViewSChmObj.Image = global::RequestForRepair.Properties.Resources.ElementInformation;
            this.toolBtnViewSChmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnViewSChmObj.Name = "toolBtnViewSChmObj";
            this.toolBtnViewSChmObj.Size = new System.Drawing.Size(23, 22);
            this.toolBtnViewSChmObj.Text = "Показать на схеме";
            this.toolBtnViewSChmObj.Click += new System.EventHandler(this.toolBtnViewSChmObj_Click);
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
            this.tabPageGeneral.Controls.Add(this.cmbRequestFiled);
            this.tabPageGeneral.Controls.Add(this.toolStripMain);
            this.tabPageGeneral.Controls.Add(this.cmbSR);
            this.tabPageGeneral.Controls.Add(this.label_0);
            this.tabPageGeneral.Controls.Add(this.groupBoxDaily);
            this.tabPageGeneral.Controls.Add(this.cmbWorker);
            this.tabPageGeneral.Controls.Add(this.labelRequestFiled);
            this.tabPageGeneral.Controls.Add(this.groupBoxODS);
            this.tabPageGeneral.Controls.Add(this.dateTimePickerDateCreate);
            this.tabPageGeneral.Controls.Add(this.label_15);
            this.tabPageGeneral.Controls.Add(this.groupBox1);
            this.tabPageGeneral.Controls.Add(this.labelSR);
            this.tabPageGeneral.Controls.Add(this.labelWorker);
            this.tabPageGeneral.Controls.Add(this.cmbUserCreate);
            this.tabPageGeneral.Controls.Add(this.txtNum);
            this.tabPageGeneral.Controls.Add(this.label_13);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(657, 643);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Общие";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // chkSendToSite
            // 
            this.chkSendToSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSendToSite.AutoSize = true;
            this.chkSendToSite.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetN, "tJ_RequestForRepair.SendSite", true));
            this.chkSendToSite.Location = new System.Drawing.Point(20, 620);
            this.chkSendToSite.Name = "chkSendToSite";
            this.chkSendToSite.Size = new System.Drawing.Size(121, 17);
            this.chkSendToSite.TabIndex = 27;
            this.chkSendToSite.Text = "Отправить на сайт";
            this.chkSendToSite.UseVisualStyleBackColor = true;
            // 
            // cmbGroupWorks
            // 
            this.cmbGroupWorks.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource_2, "groupWorks", true));
            this.cmbGroupWorks.FormattingEnabled = true;
            this.cmbGroupWorks.Location = new System.Drawing.Point(391, 384);
            this.cmbGroupWorks.Name = "cmbGroupWorks";
            this.cmbGroupWorks.Size = new System.Drawing.Size(159, 21);
            this.cmbGroupWorks.TabIndex = 26;
            this.cmbGroupWorks.SelectedIndexChanged += new System.EventHandler(this.cmbGroupWorks_SelectedIndexChanged);
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
            this.cmbPerformerOrganization.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.performerOrganization", true));
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
            this.cmbOrganization.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.organization", true));
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
            this.cmbRegion.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idRegion", true));
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Location = new System.Drawing.Point(358, 63);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(287, 21);
            this.cmbRegion.TabIndex = 20;
            this.cmbRegion.SelectedValueChanged += new System.EventHandler(this.cmbRegion_SelectedValueChanged);
            // 
            // cmbRequestFiled
            // 
            this.cmbRequestFiled.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRequestFiled.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRequestFiled.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetN, "tJ_RequestForRepair.reguestFiled", true));
            this.cmbRequestFiled.FormattingEnabled = true;
            this.cmbRequestFiled.Location = new System.Drawing.Point(101, 62);
            this.cmbRequestFiled.Name = "cmbRequestFiled";
            this.cmbRequestFiled.Size = new System.Drawing.Size(181, 21);
            this.cmbRequestFiled.TabIndex = 19;
            this.cmbRequestFiled.SelectedIndexChanged += new System.EventHandler(this.txtRequestFiled_SelectedIndexChanged);
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
            this.toolBtnCopy.Image = global::RequestForRepair.Properties.Resources.CopyBuffer;
            this.toolBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnCopy.Name = "toolBtnCopy";
            this.toolBtnCopy.Size = new System.Drawing.Size(23, 22);
            this.toolBtnCopy.Text = "Копировать";
            this.toolBtnCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // toolBtnSettingsFTP
            // 
            this.toolBtnSettingsFTP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSettingsFTP.Image = global::RequestForRepair.Properties.Resources.FTP;
            this.toolBtnSettingsFTP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSettingsFTP.Name = "toolBtnSettingsFTP";
            this.toolBtnSettingsFTP.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSettingsFTP.Text = "Настройки FTP";
            this.toolBtnSettingsFTP.Visible = false;
            this.toolBtnSettingsFTP.Click += new System.EventHandler(this.toolBtnSettingsFTP_Click);
            // 
            // cmbSR
            // 
            this.cmbSR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSR.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idSR", true));
            this.cmbSR.FormattingEnabled = true;
            this.cmbSR.Location = new System.Drawing.Point(358, 36);
            this.cmbSR.Name = "cmbSR";
            this.cmbSR.Size = new System.Drawing.Size(287, 21);
            this.cmbSR.TabIndex = 7;
            this.cmbSR.SelectedIndexChanged += new System.EventHandler(this.cmbSR_SelectedIndexChanged);
            this.cmbSR.SelectedValueChanged += new System.EventHandler(this.cmbSR_SelectedValueChanged);
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Location = new System.Drawing.Point(58, 8);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(37, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "Автор";
            // 
            // groupBoxDaily
            // 
            this.groupBoxDaily.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDaily.Controls.Add(this.dateTimePickerFactEnd);
            this.groupBoxDaily.Controls.Add(this.label_16);
            this.groupBoxDaily.Controls.Add(this.buttonDaily);
            this.groupBoxDaily.Controls.Add(this.dgvDaily);
            this.groupBoxDaily.Controls.Add(this.checkBoxWeekEnd);
            this.groupBoxDaily.Controls.Add(this.checkBoxDaily);
            this.groupBoxDaily.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxDaily.Controls.Add(this.label_7);
            this.groupBoxDaily.Controls.Add(this.dateTimePickerBeg);
            this.groupBoxDaily.Controls.Add(this.label_3);
            this.groupBoxDaily.Location = new System.Drawing.Point(11, 192);
            this.groupBoxDaily.Name = "groupBoxDaily";
            this.groupBoxDaily.Size = new System.Drawing.Size(634, 173);
            this.groupBoxDaily.TabIndex = 10;
            this.groupBoxDaily.TabStop = false;
            this.groupBoxDaily.Text = "Даты отключения";
            // 
            // dateTimePickerFactEnd
            // 
            this.dateTimePickerFactEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerFactEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetN, "tJ_RequestForRepair.dateFactEnd", true));
            this.dateTimePickerFactEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFactEnd.Location = new System.Drawing.Point(351, 144);
            this.dateTimePickerFactEnd.Name = "dateTimePickerFactEnd";
            this.dateTimePickerFactEnd.Size = new System.Drawing.Size(188, 20);
            this.dateTimePickerFactEnd.TabIndex = 16;
            this.dateTimePickerFactEnd.Value = new System.DateTime(2015, 8, 10, 13, 57, 6, 22);
            // 
            // label_16
            // 
            this.label_16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_16.AutoSize = true;
            this.label_16.Location = new System.Drawing.Point(175, 148);
            this.label_16.Name = "label_16";
            this.label_16.Size = new System.Drawing.Size(176, 13);
            this.label_16.TabIndex = 14;
            this.label_16.Text = "Фактическое время выполнения";
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
            this.dgvDaily.DataSource = this.dataSetN;
            this.dgvDaily.Location = new System.Drawing.Point(178, 8);
            this.dgvDaily.Name = "dgvDaily";
            this.dgvDaily.RowHeadersWidth = 30;
            this.dgvDaily.Size = new System.Drawing.Size(456, 130);
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
            dataGridViewCellStyle3.Format = "dd.MM.yyyy HH:mm";
            this.dateBegDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateBegDataGridViewTextBoxColumn.FillWeight = 50F;
            this.dateBegDataGridViewTextBoxColumn.HeaderText = "Начало";
            this.dateBegDataGridViewTextBoxColumn.Name = "dateBegDataGridViewTextBoxColumn";
            this.dateBegDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "dateEnd";
            dataGridViewCellStyle4.Format = "dd.MM.yyyy HH:mm";
            this.dateEndDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
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
            // label_7
            // 
            this.label_7.AutoSize = true;
            this.label_7.Location = new System.Drawing.Point(6, 50);
            this.label_7.Name = "label_7";
            this.label_7.Size = new System.Drawing.Size(19, 13);
            this.label_7.TabIndex = 9;
            this.label_7.Text = "по";
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
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Location = new System.Drawing.Point(11, 22);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(13, 13);
            this.label_3.TabIndex = 8;
            this.label_3.Text = "с";
            // 
            // cmbWorker
            // 
            this.cmbWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idWorker", true));
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(288, 66);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(21, 21);
            this.cmbWorker.TabIndex = 3;
            this.cmbWorker.Visible = false;
            this.cmbWorker.SelectedIndexChanged += new System.EventHandler(this.cmbWorker_SelectedIndexChanged);
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
            // groupBoxODS
            // 
            this.groupBoxODS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxODS.Controls.Add(this.cmbStatus);
            this.groupBoxODS.Controls.Add(this.labelStatus);
            this.groupBoxODS.Controls.Add(this.txtAdress);
            this.groupBoxODS.Controls.Add(this.cmbDispatcher);
            this.groupBoxODS.Controls.Add(this.label_8);
            this.groupBoxODS.Controls.Add(this.label_9);
            this.groupBoxODS.Controls.Add(this.dateTimePickerDateAgreed);
            this.groupBoxODS.Controls.Add(this.checkBoxAgreed);
            this.groupBoxODS.Controls.Add(this.labelAddress);
            this.groupBoxODS.Controls.Add(this.label_11);
            this.groupBoxODS.Controls.Add(this.label_12);
            this.groupBoxODS.Controls.Add(this.txtComment);
            this.groupBoxODS.Controls.Add(this.txtAgreeWith);
            this.groupBoxODS.Location = new System.Drawing.Point(11, 411);
            this.groupBoxODS.Name = "groupBoxODS";
            this.groupBoxODS.Size = new System.Drawing.Size(634, 200);
            this.groupBoxODS.TabIndex = 9;
            this.groupBoxODS.TabStop = false;
            this.groupBoxODS.VisibleChanged += new System.EventHandler(this.groupBoxODS_VisibleChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.status", true));
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
            this.txtAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetN, "tJ_RequestForRepair.Address", true));
            this.txtAdress.Location = new System.Drawing.Point(101, 71);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.ReadOnly = true;
            this.txtAdress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdress.Size = new System.Drawing.Size(527, 72);
            this.txtAdress.TabIndex = 11;
            // 
            // cmbDispatcher
            // 
            this.cmbDispatcher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDispatcher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDispatcher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDispatcher.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.WorkerAgreed", true));
            this.cmbDispatcher.FormattingEnabled = true;
            this.cmbDispatcher.Location = new System.Drawing.Point(412, 145);
            this.cmbDispatcher.Name = "cmbDispatcher";
            this.cmbDispatcher.Size = new System.Drawing.Size(216, 21);
            this.cmbDispatcher.TabIndex = 10;
            // 
            // label_8
            // 
            this.label_8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_8.AutoSize = true;
            this.label_8.Location = new System.Drawing.Point(329, 151);
            this.label_8.Name = "label_8";
            this.label_8.Size = new System.Drawing.Size(77, 13);
            this.label_8.TabIndex = 9;
            this.label_8.Text = "Согласующий";
            // 
            // label_9
            // 
            this.label_9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_9.AutoSize = true;
            this.label_9.Location = new System.Drawing.Point(121, 153);
            this.label_9.Name = "label_9";
            this.label_9.Size = new System.Drawing.Size(33, 13);
            this.label_9.TabIndex = 8;
            this.label_9.Text = "Дата";
            // 
            // dateTimePickerDateAgreed
            // 
            this.dateTimePickerDateAgreed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerDateAgreed.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetN, "tJ_RequestForRepair.DateAgreed", true));
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
            this.checkBoxAgreed.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetN, "tJ_RequestForRepair.Agreed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
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
            // label_11
            // 
            this.label_11.AutoSize = true;
            this.label_11.Location = new System.Drawing.Point(6, 48);
            this.label_11.Name = "label_11";
            this.label_11.Size = new System.Drawing.Size(77, 13);
            this.label_11.TabIndex = 4;
            this.label_11.Text = "Комментарий";
            // 
            // label_12
            // 
            this.label_12.AutoSize = true;
            this.label_12.Location = new System.Drawing.Point(6, 22);
            this.label_12.Name = "label_12";
            this.label_12.Size = new System.Drawing.Size(81, 13);
            this.label_12.TabIndex = 3;
            this.label_12.Text = "Согласовать с";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetN, "tJ_RequestForRepair.Comment", true));
            this.txtComment.Location = new System.Drawing.Point(101, 45);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(527, 20);
            this.txtComment.TabIndex = 1;
            // 
            // txtAgreeWith
            // 
            this.txtAgreeWith.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgreeWith.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetN, "tJ_RequestForRepair.AgreeWith", true));
            this.txtAgreeWith.Location = new System.Drawing.Point(101, 19);
            this.txtAgreeWith.Name = "txtAgreeWith";
            this.txtAgreeWith.Size = new System.Drawing.Size(527, 20);
            this.txtAgreeWith.TabIndex = 0;
            // 
            // dateTimePickerDateCreate
            // 
            this.dateTimePickerDateCreate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePickerDateCreate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetN, "tJ_RequestForRepair.dateCreate", true));
            this.dateTimePickerDateCreate.Enabled = false;
            this.dateTimePickerDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateCreate.Location = new System.Drawing.Point(101, 37);
            this.dateTimePickerDateCreate.Name = "dateTimePickerDateCreate";
            this.dateTimePickerDateCreate.Size = new System.Drawing.Size(181, 20);
            this.dateTimePickerDateCreate.TabIndex = 17;
            this.dateTimePickerDateCreate.Value = new System.DateTime(2012, 10, 18, 8, 39, 41, 178);
            // 
            // label_15
            // 
            this.label_15.AutoSize = true;
            this.label_15.Location = new System.Drawing.Point(8, 39);
            this.label_15.Name = "label_15";
            this.label_15.Size = new System.Drawing.Size(84, 13);
            this.label_15.TabIndex = 16;
            this.label_15.Text = "Дата создания";
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
            this.groupBox1.Size = new System.Drawing.Size(634, 97);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // cmbTypeDamage
            // 
            this.cmbTypeDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTypeDamage.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idTypeDamage", true));
            this.cmbTypeDamage.FormattingEnabled = true;
            this.cmbTypeDamage.Location = new System.Drawing.Point(366, 68);
            this.cmbTypeDamage.Name = "cmbTypeDamage";
            this.cmbTypeDamage.Size = new System.Drawing.Size(262, 21);
            this.cmbTypeDamage.TabIndex = 7;
            // 
            // cmbTypeDisable
            // 
            this.cmbTypeDisable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTypeDisable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTypeDisable.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.typeDisable", true));
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
            this.cmbIsPlanned.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.IsPlanned", true));
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
            this.txtPurpose.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetN, "tJ_RequestForRepair.Purpose", true));
            this.txtPurpose.Location = new System.Drawing.Point(101, 42);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(527, 20);
            this.txtPurpose.TabIndex = 2;
            this.txtPurpose.TextChanged += new System.EventHandler(this.txtPurpose_TextChanged);
            // 
            // txtObject
            // 
            this.txtObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetN, "tJ_RequestForRepair.schmObj", true));
            this.txtObject.Location = new System.Drawing.Point(101, 16);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(527, 20);
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
            // labelSR
            // 
            this.labelSR.AutoSize = true;
            this.labelSR.Location = new System.Drawing.Point(305, 39);
            this.labelSR.Name = "labelSR";
            this.labelSR.Size = new System.Drawing.Size(38, 13);
            this.labelSR.TabIndex = 6;
            this.labelSR.Text = "Район";
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
            // cmbUserCreate
            // 
            this.cmbUserCreate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetN, "tJ_RequestForRepair.idUserCreate", true));
            this.cmbUserCreate.Enabled = false;
            this.cmbUserCreate.FormattingEnabled = true;
            this.cmbUserCreate.Location = new System.Drawing.Point(101, 5);
            this.cmbUserCreate.Name = "cmbUserCreate";
            this.cmbUserCreate.Size = new System.Drawing.Size(181, 21);
            this.cmbUserCreate.TabIndex = 12;
            // 
            // txtNum
            // 
            this.txtNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetN, "tJ_RequestForRepair.num", true));
            this.txtNum.Location = new System.Drawing.Point(358, 5);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(287, 20);
            this.txtNum.TabIndex = 14;
            // 
            // label_13
            // 
            this.label_13.AutoSize = true;
            this.label_13.Location = new System.Drawing.Point(302, 8);
            this.label_13.Name = "label_13";
            this.label_13.Size = new System.Drawing.Size(41, 13);
            this.label_13.TabIndex = 13;
            this.label_13.Text = "Номер";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tabPageSwitching);
            this.tabControl.Controls.Add(this.tabPageDocuments);
            this.tabControl.Controls.Add(this.tabPageLog);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(665, 669);
            this.tabControl.TabIndex = 49;
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
            // FormJournalRequestForRepairAddEdit
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(664, 713);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormJournalRequestForRepairAddEdit";
            this.Text = "FormJournalRequestForRepairAddEdit (N)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJournalRequestForRepairAddEdit_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJournalRequestForRepairAddEdit_FormClosed);
            this.Load += new System.EventHandler(this.FormJournalRequestForRepairAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRequestForReapirDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_4)).EndInit();
            this.tabPageLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            this.tabPageDocuments.ResumeLayout(false);
            this.tabPageDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            this.toolStripDocuments.ResumeLayout(false);
            this.toolStripDocuments.PerformLayout();
            this.tabPageSwitching.ResumeLayout(false);
            this.tabPageSwitching.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            this.toolStripAddress.ResumeLayout(false);
            this.toolStripAddress.PerformLayout();
            this.toolStripScheme.ResumeLayout(false);
            this.toolStripScheme.PerformLayout();
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.groupBoxDaily.ResumeLayout(false);
            this.groupBoxDaily.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).EndInit();
            this.groupBoxODS.ResumeLayout(false);
            this.groupBoxODS.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
  

        //private DataRow dataRow;
        private DataTable tblRequestForRepairClientType2;
        private DataTable tblRequestForRepairClientType1;
        private DataTable tblRequestForRepairClientType3;
        private DataTable tblRequestForRepairClientType4;
        private DataTable tblRequestForRepairClientType5;
        private DataTable tblKladrObj;
        private DataTable tblKladrStreet;
        private DataTable tblKladrObjAddress;
        private System.Collections.Generic.Dictionary<int, string> dictionary_1;

        // private DataSetGES dataSetGES_0;
        private DataSets.DataSetN dataSetN;
        private Button buttonOK;
        private DataSet dataSet_0;
        private DataTable tblLinkObjects;
        private DataColumn dataColumn_0;
        private DataColumn dataColumn_1;
        private DataColumn dataColumn_2;
        private DataColumn dataColumn_3;
        private DataColumn dataColumn_4;
        private BindingSource bindingSource_0;
        private BindingSource bindingSource_1;
        private DataTable tblRequestForReapirDoc;
        private DataColumn dataColumn_5;
        private DataColumn dataColumn_6;
        private DataColumn dataColumn_7;
        private DataColumn dataColumn_8;
        private Button buttonCopy;
        private BindingSource bindingSource_2;
        private DataTable tblAddress;
        private DataColumn dataColumn_9;
        private DataColumn dataColumn_10;
        private DataColumn dataColumn_11;
        private DataColumn dataColumn_12;
        private DataColumn dataColumn_13;
        private DataColumn dataColumn_14;
        private DataColumn dataColumn_15;
        private DataColumn dataColumn_16;
        private BindingSource bindingSource_3;
        private BackgroundWorker backgroundWorker;
        private DataColumn dataColumn_17;
        private BindingSource bindingSource_4;
        private Button buttonCancel;
        private TabPage tabPageLog;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvLog;
        private TabPage tabPageDocuments;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvDocs;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumnDoc;
        private DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn1;
        private DataGridViewLinkColumn fileNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull ColumnImage;
        private ToolStrip toolStripDocuments;
        private ToolStripButton toolBtnAddDoc;
        private ToolStripButton toolBtnDelDoc;
        private ToolStripButton toolBtnViewDoc;
        private ToolStripButton toolBtnSaveDoc;
        private ToolStrip miniToolStrip;
        private TabPage tabPageSwitching;
        private SplitContainer splitContainer1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvLinkObjects;
        private DataGridViewTextBoxColumn objectsDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dateBegDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn numDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn disabledDgvColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvAddress;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idAddressDgvColumn;
        private DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn idKladrObjDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idKladrStreetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private ToolStrip toolStripAddress;
        private ToolStripButton toolBtnAddAddress;
        private ToolStripButton toolBtnDelAddress;
        private ToolStrip toolStripScheme;
        private ToolStripButton toolBtnLinkSchmObj;
        private ToolStripButton toolBtnLinkSchmObjEdit;
        private ToolStripButton toolBtnDelSchmObj;
        private ToolStripButton toolBtnViewSChmObj;
        private TabPage tabPageGeneral;
        private CheckBox chkSendToSite;
        private ComboBox cmbGroupWorks;
        private Label labelGroupWork;
        private ComboBox cmbPerformerOrganization;
        private Label labelPerformer;
        private ComboBox cmbOrganization;
        private Label labelOrganization;
        private ComboBox cmbRegion;
        private ComboBox cmbRequestFiled;
        private ToolStrip toolStripMain;
        private ToolStripButton toolBtnCopy;
        private ToolStripButton toolBtnSettingsFTP;
        private ComboBox cmbSR;
        private Label label_0;
        private GroupBox groupBoxDaily;
        private ControlsLbr.NullableDateTimePicker dateTimePickerFactEnd;
        private Label label_16;
        private Button buttonDaily;
        private DataGridView dgvDaily;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn dateBegDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn dateEndDataGridViewTextBoxColumn;
        private CheckBox checkBoxWeekEnd;
        private CheckBox checkBoxDaily;
        private DateTimePicker dateTimePickerEnd;
        private Label label_7;
        private DateTimePicker dateTimePickerBeg;
        private Label label_3;
        private ComboBox cmbWorker;
        private Label labelRequestFiled;
        private GroupBox groupBoxODS;
        private ComboBox cmbStatus;
        private Label labelStatus;
        private TextBox txtAdress;
        private ComboBox cmbDispatcher;
        private Label label_8;
        private Label label_9;
        private ControlsLbr.NullableDateTimePicker dateTimePickerDateAgreed;
        private CheckBox checkBoxAgreed;
        private Label labelAddress;
        private Label label_11;
        private Label label_12;
        private TextBox txtComment;
        private TextBox txtAgreeWith;
        private ControlsLbr.NullableDateTimePicker dateTimePickerDateCreate;
        private Label label_15;
        private GroupBox groupBox1;
        private ComboBox cmbTypeDamage;
        private ComboBox cmbTypeDisable;
        private ComboBox cmbIsPlanned;
        private Label labelIsPlanned;
        private Label labelPurpose;
        private TextBox txtPurpose;
        private TextBox txtObject;
        private Label labelObject;
        private Label labelSR;
        private Label labelWorker;
        private ComboBox cmbUserCreate;
        private TextBox txtNum;
        private Label label_13;
        private TabControl tabControl;
        private DataGridViewTextBoxColumn dateLogDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn userLogIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userLogDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userLogNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCommandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commandDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isSiteDataGridViewCheckBoxColumn;
    }
}