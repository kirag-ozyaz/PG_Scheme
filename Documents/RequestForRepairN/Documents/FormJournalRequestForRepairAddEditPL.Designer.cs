using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal partial class FormJournalRequestForRepairAddEditPL : FormLbr.FormBase
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}

	private global::System.ComponentModel.IContainer components = null;

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSetDamage = new RequestForRepairN.DataSets.DataSetDamage();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRequestFiled = new System.Windows.Forms.Label();
            this.labelSR = new System.Windows.Forms.Label();
            this.cmbSR = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbIsPlanned = new System.Windows.Forms.ComboBox();
            this.labelIsPlanned = new System.Windows.Forms.Label();
            this.labelPurpose = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.txtObject = new System.Windows.Forms.TextBox();
            this.cmbWorker = new System.Windows.Forms.ComboBox();
            this.labelObject = new System.Windows.Forms.Label();
            this.labelWorker = new System.Windows.Forms.Label();
            this.toolStripScheme = new System.Windows.Forms.ToolStrip();
            this.toolBtnLinkSchmObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnLinkSchmObjEdit = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelSchmObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnViewSChmObj = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDaily = new System.Windows.Forms.GroupBox();
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
            this.dtpFactEnd = new ControlsLbr.NullableDateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxODS = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.cmbDispatcher = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerDateAgreed = new ControlsLbr.NullableDateTimePicker();
            this.checkBoxAgreed = new System.Windows.Forms.CheckBox();
            this.dtpDateCreate = new ControlsLbr.NullableDateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtAgreeWith = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.cmbUserCreate = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.txtRequestFiled = new System.Windows.Forms.ComboBox();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.tabPageSwitching = new System.Windows.Forms.TabPage();
            this.dgvLinkObjects = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.objectsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBegDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLinkObjects = new System.Windows.Forms.BindingSource(this.components);
            this.dsLinkObjects = new System.Data.DataSet();
            this.tableLinkObjects = new System.Data.DataTable();
            this.dataColumn25 = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.tableRequestForReapirDoc = new System.Data.DataTable();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.tabPageDocuments = new System.Windows.Forms.TabPage();
            this.dgvDocs = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumnDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
            this.idRequestDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRequestForRepairDoc = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnViewDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSaveDoc = new System.Windows.Forms.ToolStripButton();
            this.buttonCopy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStripScheme.SuspendLayout();
            this.groupBoxDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDaily)).BeginInit();
            this.groupBoxODS.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.tabPageSwitching.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLinkObjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRequestForReapirDoc)).BeginInit();
            this.tabPageDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepairDoc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataSetDamage
            // 
            this.dataSetDamage.DataSetName = "DataSetGES";
            this.dataSetDamage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.labelRequestFiled.Location = new System.Drawing.Point(19, 35);
            this.labelRequestFiled.Name = "labelRequestFiled";
            this.labelRequestFiled.Size = new System.Drawing.Size(76, 13);
            this.labelRequestFiled.TabIndex = 4;
            this.labelRequestFiled.Text = "Заявку подал";
            // 
            // labelSR
            // 
            this.labelSR.AutoSize = true;
            this.labelSR.Location = new System.Drawing.Point(302, 35);
            this.labelSR.Name = "labelSR";
            this.labelSR.Size = new System.Drawing.Size(38, 13);
            this.labelSR.TabIndex = 6;
            this.labelSR.Text = "Район";
            // 
            // cmbSR
            // 
            this.cmbSR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSR.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.idSR", true));
            this.cmbSR.FormattingEnabled = true;
            this.cmbSR.Location = new System.Drawing.Point(358, 32);
            this.cmbSR.Name = "cmbSR";
            this.cmbSR.Size = new System.Drawing.Size(198, 21);
            this.cmbSR.TabIndex = 7;
            this.cmbSR.SelectedIndexChanged += new System.EventHandler(this.cmbSR_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbIsPlanned);
            this.groupBox1.Controls.Add(this.labelIsPlanned);
            this.groupBox1.Controls.Add(this.labelPurpose);
            this.groupBox1.Controls.Add(this.txtPurpose);
            this.groupBox1.Controls.Add(this.txtObject);
            this.groupBox1.Controls.Add(this.cmbWorker);
            this.groupBox1.Controls.Add(this.labelObject);
            this.groupBox1.Controls.Add(this.labelWorker);
            this.groupBox1.Location = new System.Drawing.Point(11, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 97);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // cmbIsPlanned
            // 
            this.cmbIsPlanned.FormattingEnabled = true;
            this.cmbIsPlanned.Items.AddRange(new object[] {
            "Аварийный",
            "Плановый"});
            this.cmbIsPlanned.Location = new System.Drawing.Point(101, 68);
            this.cmbIsPlanned.Name = "cmbIsPlanned";
            this.cmbIsPlanned.Size = new System.Drawing.Size(121, 21);
            this.cmbIsPlanned.TabIndex = 5;
            this.cmbIsPlanned.SelectedIndexChanged += new System.EventHandler(this.cmbIsPlanned_SelectedIndexChanged);
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
            this.txtPurpose.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.Purpose", true));
            this.txtPurpose.Location = new System.Drawing.Point(101, 42);
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(438, 20);
            this.txtPurpose.TabIndex = 2;
            this.txtPurpose.TextChanged += new System.EventHandler(this.txtPurpose_TextChanged);
            // 
            // txtObject
            // 
            this.txtObject.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.schmObj", true));
            this.txtObject.Location = new System.Drawing.Point(101, 16);
            this.txtObject.Name = "txtObject";
            this.txtObject.Size = new System.Drawing.Size(438, 20);
            this.txtObject.TabIndex = 1;
            this.txtObject.TextChanged += new System.EventHandler(this.txtObject_TextChanged);
            // 
            // cmbWorker
            // 
            this.cmbWorker.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWorker.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWorker.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.idWorker", true));
            this.cmbWorker.FormattingEnabled = true;
            this.cmbWorker.Location = new System.Drawing.Point(319, 68);
            this.cmbWorker.Name = "cmbWorker";
            this.cmbWorker.Size = new System.Drawing.Size(198, 21);
            this.cmbWorker.TabIndex = 3;
            this.cmbWorker.Visible = false;
            this.cmbWorker.SelectedIndexChanged += new System.EventHandler(this.cmbWorker_SelectedIndexChanged);
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
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Location = new System.Drawing.Point(254, 71);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(56, 13);
            this.labelWorker.TabIndex = 15;
            this.labelWorker.Text = "Оператор";
            this.labelWorker.Visible = false;
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
            this.toolStripScheme.Size = new System.Drawing.Size(562, 25);
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
            // groupBoxDaily
            // 
            this.groupBoxDaily.Controls.Add(this.buttonDaily);
            this.groupBoxDaily.Controls.Add(this.dgvDaily);
            this.groupBoxDaily.Controls.Add(this.checkBoxWeekEnd);
            this.groupBoxDaily.Controls.Add(this.checkBoxDaily);
            this.groupBoxDaily.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxDaily.Controls.Add(this.label9);
            this.groupBoxDaily.Controls.Add(this.dateTimePickerBeg);
            this.groupBoxDaily.Controls.Add(this.label8);
            this.groupBoxDaily.Location = new System.Drawing.Point(11, 151);
            this.groupBoxDaily.Name = "groupBoxDaily";
            this.groupBoxDaily.Size = new System.Drawing.Size(545, 141);
            this.groupBoxDaily.TabIndex = 10;
            this.groupBoxDaily.TabStop = false;
            this.groupBoxDaily.Text = "Даты отключения";
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
            this.dgvDaily.Size = new System.Drawing.Size(367, 101);
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
            // dtpFactEnd
            // 
            this.dtpFactEnd.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpFactEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_RequestForRepair.dateFactEnd", true));
            this.dtpFactEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFactEnd.Location = new System.Drawing.Point(147, 45);
            this.dtpFactEnd.Name = "dtpFactEnd";
            this.dtpFactEnd.Size = new System.Drawing.Size(227, 20);
            this.dtpFactEnd.TabIndex = 17;
            this.dtpFactEnd.Value = new System.DateTime(2015, 8, 10, 13, 57, 6, 22);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Время закрытия заявки";
            // 
            // groupBoxODS
            // 
            this.groupBoxODS.Controls.Add(this.dtpFactEnd);
            this.groupBoxODS.Controls.Add(this.label3);
            this.groupBoxODS.Controls.Add(this.cmbStatus);
            this.groupBoxODS.Controls.Add(this.labelStatus);
            this.groupBoxODS.Controls.Add(this.txtAdress);
            this.groupBoxODS.Controls.Add(this.cmbDispatcher);
            this.groupBoxODS.Controls.Add(this.label14);
            this.groupBoxODS.Controls.Add(this.label13);
            this.groupBoxODS.Controls.Add(this.dateTimePickerDateAgreed);
            this.groupBoxODS.Controls.Add(this.checkBoxAgreed);
            this.groupBoxODS.Controls.Add(this.dtpDateCreate);
            this.groupBoxODS.Controls.Add(this.label2);
            this.groupBoxODS.Controls.Add(this.label12);
            this.groupBoxODS.Controls.Add(this.label11);
            this.groupBoxODS.Controls.Add(this.label10);
            this.groupBoxODS.Controls.Add(this.txtComment);
            this.groupBoxODS.Controls.Add(this.txtAgreeWith);
            this.groupBoxODS.Location = new System.Drawing.Point(11, 294);
            this.groupBoxODS.Name = "groupBoxODS";
            this.groupBoxODS.Size = new System.Drawing.Size(545, 256);
            this.groupBoxODS.TabIndex = 9;
            this.groupBoxODS.TabStop = false;
            this.groupBoxODS.VisibleChanged += new System.EventHandler(this.groupBoxODS_VisibleChanged);
            // 
            // cmbStatus
            // 
            this.cmbStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.status", true));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(165, 224);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(374, 21);
            this.cmbStatus.TabIndex = 15;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(79, 227);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(80, 13);
            this.labelStatus.TabIndex = 14;
            this.labelStatus.Text = "Статус заявки";
            // 
            // txtAdress
            // 
            this.txtAdress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.Address", true));
            this.txtAdress.Location = new System.Drawing.Point(106, 126);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(433, 64);
            this.txtAdress.TabIndex = 11;
            // 
            // cmbDispatcher
            // 
            this.cmbDispatcher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDispatcher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDispatcher.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSetDamage, "tJ_RequestForRepair.WorkerAgreed", true));
            this.cmbDispatcher.FormattingEnabled = true;
            this.cmbDispatcher.Location = new System.Drawing.Point(400, 196);
            this.cmbDispatcher.Name = "cmbDispatcher";
            this.cmbDispatcher.Size = new System.Drawing.Size(139, 21);
            this.cmbDispatcher.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(316, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Руководитель";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(108, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Дата";
            // 
            // dateTimePickerDateAgreed
            // 
            this.dateTimePickerDateAgreed.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_RequestForRepair.DateAgreed", true));
            this.dateTimePickerDateAgreed.Location = new System.Drawing.Point(147, 196);
            this.dateTimePickerDateAgreed.Name = "dateTimePickerDateAgreed";
            this.dateTimePickerDateAgreed.Size = new System.Drawing.Size(163, 20);
            this.dateTimePickerDateAgreed.TabIndex = 7;
            this.dateTimePickerDateAgreed.Value = new System.DateTime(2012, 9, 26, 9, 58, 28, 932);
            // 
            // checkBoxAgreed
            // 
            this.checkBoxAgreed.AutoSize = true;
            this.checkBoxAgreed.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.dataSetDamage, "tJ_RequestForRepair.Agreed", true));
            this.checkBoxAgreed.Location = new System.Drawing.Point(14, 198);
            this.checkBoxAgreed.Name = "checkBoxAgreed";
            this.checkBoxAgreed.Size = new System.Drawing.Size(83, 17);
            this.checkBoxAgreed.TabIndex = 6;
            this.checkBoxAgreed.Text = "Разрешено";
            this.checkBoxAgreed.UseVisualStyleBackColor = true;
            this.checkBoxAgreed.CheckedChanged += new System.EventHandler(this.checkBoxAgreed_CheckedChanged);
            // 
            // dtpDateCreate
            // 
            this.dtpDateCreate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDateCreate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dataSetDamage, "tJ_RequestForRepair.dateOpenRequest", true));
            this.dtpDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateCreate.Location = new System.Drawing.Point(147, 19);
            this.dtpDateCreate.Name = "dtpDateCreate";
            this.dtpDateCreate.Size = new System.Drawing.Size(227, 20);
            this.dtpDateCreate.TabIndex = 17;
            this.dtpDateCreate.Value = new System.DateTime(2012, 10, 18, 8, 39, 41, 178);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Время открытия заявки";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Адреса";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Комментарий";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Согласовать с";
            // 
            // txtComment
            // 
            this.txtComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.Comment", true));
            this.txtComment.Location = new System.Drawing.Point(106, 100);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(433, 20);
            this.txtComment.TabIndex = 1;
            // 
            // txtAgreeWith
            // 
            this.txtAgreeWith.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.AgreeWith", true));
            this.txtAgreeWith.Location = new System.Drawing.Point(106, 74);
            this.txtAgreeWith.Name = "txtAgreeWith";
            this.txtAgreeWith.Size = new System.Drawing.Size(433, 20);
            this.txtAgreeWith.TabIndex = 0;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(15, 587);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(485, 587);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
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
            this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.num", true));
            this.txtNum.Location = new System.Drawing.Point(358, 5);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(198, 20);
            this.txtNum.TabIndex = 14;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGeneral);
            this.tabControl.Controls.Add(this.tabPageSwitching);
            this.tabControl.Controls.Add(this.tabPageDocuments);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(576, 581);
            this.tabControl.TabIndex = 49;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.txtRequestFiled);
            this.tabPageGeneral.Controls.Add(this.toolStripMain);
            this.tabPageGeneral.Controls.Add(this.cmbSR);
            this.tabPageGeneral.Controls.Add(this.label1);
            this.tabPageGeneral.Controls.Add(this.groupBoxDaily);
            this.tabPageGeneral.Controls.Add(this.labelRequestFiled);
            this.tabPageGeneral.Controls.Add(this.groupBoxODS);
            this.tabPageGeneral.Controls.Add(this.groupBox1);
            this.tabPageGeneral.Controls.Add(this.labelSR);
            this.tabPageGeneral.Controls.Add(this.cmbUserCreate);
            this.tabPageGeneral.Controls.Add(this.txtNum);
            this.tabPageGeneral.Controls.Add(this.label15);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(568, 555);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "Общие";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // txtRequestFiled
            // 
            this.txtRequestFiled.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRequestFiled.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtRequestFiled.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dataSetDamage, "tJ_RequestForRepair.reguestFiled", true));
            this.txtRequestFiled.FormattingEnabled = true;
            this.txtRequestFiled.Location = new System.Drawing.Point(101, 32);
            this.txtRequestFiled.Name = "txtRequestFiled";
            this.txtRequestFiled.Size = new System.Drawing.Size(181, 21);
            this.txtRequestFiled.TabIndex = 19;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnCopy});
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
            this.toolBtnCopy.Click += new System.EventHandler(this.toolBtnCopy_Click);
            // 
            // tabPageSwitching
            // 
            this.tabPageSwitching.Controls.Add(this.dgvLinkObjects);
            this.tabPageSwitching.Controls.Add(this.toolStripScheme);
            this.tabPageSwitching.Location = new System.Drawing.Point(4, 22);
            this.tabPageSwitching.Name = "tabPageSwitching";
            this.tabPageSwitching.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSwitching.Size = new System.Drawing.Size(568, 555);
            this.tabPageSwitching.TabIndex = 1;
            this.tabPageSwitching.Text = "Оперативные переключения";
            this.tabPageSwitching.UseVisualStyleBackColor = true;
            // 
            // dgvLinkObjects
            // 
            this.dgvLinkObjects.AllowUserToAddRows = false;
            this.dgvLinkObjects.AllowUserToDeleteRows = false;
            this.dgvLinkObjects.AllowUserToOrderColumns = true;
            this.dgvLinkObjects.AllowUserToVisibleColumns = false;
            this.dgvLinkObjects.AutoGenerateColumns = false;
            this.dgvLinkObjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLinkObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinkObjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectsDataGridViewTextBoxColumn1,
            this.dateBegDataGridViewTextBoxColumn2,
            this.dateEndDataGridViewTextBoxColumn2,
            this.durationDataGridViewTextBoxColumn1,
            this.numDataGridViewTextBoxColumn1});
            this.dgvLinkObjects.DataSource = this.bsLinkObjects;
            this.dgvLinkObjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinkObjects.Location = new System.Drawing.Point(3, 28);
            this.dgvLinkObjects.Name = "dgvLinkObjects";
            this.dgvLinkObjects.ReadOnly = true;
            this.dgvLinkObjects.RowHeadersWidth = 21;
            this.dgvLinkObjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLinkObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLinkObjects.Size = new System.Drawing.Size(562, 524);
            this.dgvLinkObjects.TabIndex = 49;
            this.dgvLinkObjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLinkObjects_CellDoubleClick);
            // 
            // objectsDataGridViewTextBoxColumn1
            // 
            this.objectsDataGridViewTextBoxColumn1.DataPropertyName = "Objects";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.objectsDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.objectsDataGridViewTextBoxColumn1.HeaderText = "Объекты";
            this.objectsDataGridViewTextBoxColumn1.Name = "objectsDataGridViewTextBoxColumn1";
            this.objectsDataGridViewTextBoxColumn1.ReadOnly = true;
            this.objectsDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.objectsDataGridViewTextBoxColumn1.Width = 250;
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
            this.tableRequestForReapirDoc});
            // 
            // tableLinkObjects
            // 
            this.tableLinkObjects.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn25,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
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
            // tableRequestForReapirDoc
            // 
            this.tableRequestForReapirDoc.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.tableRequestForReapirDoc.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "id"}, true)});
            this.tableRequestForReapirDoc.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn5};
            this.tableRequestForReapirDoc.TableName = "tJ_RequestForReapirDoc";
            // 
            // dataColumn5
            // 
            this.dataColumn5.AllowDBNull = false;
            this.dataColumn5.AutoIncrement = true;
            this.dataColumn5.ColumnName = "id";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.AllowDBNull = false;
            this.dataColumn6.ColumnName = "idRequest";
            this.dataColumn6.DataType = typeof(int);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "FileName";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "Comment";
            // 
            // tabPageDocuments
            // 
            this.tabPageDocuments.Controls.Add(this.dgvDocs);
            this.tabPageDocuments.Controls.Add(this.toolStrip1);
            this.tabPageDocuments.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocuments.Name = "tabPageDocuments";
            this.tabPageDocuments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocuments.Size = new System.Drawing.Size(568, 555);
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
            this.ColumnImage,
            this.idRequestDataGridViewTextBoxColumn1,
            this.fileNameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgvDocs.DataSource = this.bsRequestForRepairDoc;
            this.dgvDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocs.Location = new System.Drawing.Point(3, 28);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.RowHeadersWidth = 21;
            this.dgvDocs.Size = new System.Drawing.Size(562, 524);
            this.dgvDocs.TabIndex = 1;
            this.dgvDocs.VirtualMode = true;
            // 
            // idDataGridViewTextBoxColumnDoc
            // 
            this.idDataGridViewTextBoxColumnDoc.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumnDoc.HeaderText = "id";
            this.idDataGridViewTextBoxColumnDoc.Name = "idDataGridViewTextBoxColumnDoc";
            this.idDataGridViewTextBoxColumnDoc.ReadOnly = true;
            this.idDataGridViewTextBoxColumnDoc.Visible = false;
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
            // bsRequestForRepairDoc
            // 
            this.bsRequestForRepairDoc.DataMember = "tJ_RequestForRepairDoc";
            this.bsRequestForRepairDoc.DataSource = this.dataSetDamage;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddDoc,
            this.toolBtnDelDoc,
            this.toolBtnViewDoc,
            this.toolBtnSaveDoc});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(562, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(240, 587);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 50;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Visible = false;
            this.buttonCopy.Click += new System.EventHandler(this.toolBtnCopy_Click);
            // 
            // FormJournalRequestForRepairAddEditPL
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(572, 619);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormJournalRequestForRepairAddEditPL";
            this.Text = "FormJournalRequestForRepairAddEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormJournalRequestForRepairAddEdit_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJournalRequestForRepairAddEdit_FormClosed);
            this.Load += new System.EventHandler(this.FormJournalRequestForRepairAddEdit_Load);
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
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.tabPageSwitching.ResumeLayout(false);
            this.tabPageSwitching.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableLinkObjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRequestForReapirDoc)).EndInit();
            this.tabPageDocuments.ResumeLayout(false);
            this.tabPageDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepairDoc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

    }



    private RequestForRepairN.DataSets.DataSetDamage dataSetDamage;

    private Label label1;

    private Label labelRequestFiled;

    private Label labelSR;

    private ComboBox cmbSR;

    private GroupBox groupBox1;

    private Label label8;

    private ComboBox cmbIsPlanned;

    private Label labelIsPlanned;

    private Label labelPurpose;

    private TextBox txtPurpose;

    private TextBox txtObject;

    private Label labelObject;

    private Label label9;

    private GroupBox groupBoxODS;

    private TextBox txtComment;

    private TextBox txtAgreeWith;

    private Button buttonOK;

    private Button buttonCancel;

    private ComboBox cmbDispatcher;

    private Label label14;

    private Label label13;

    private NullableDateTimePicker dateTimePickerDateAgreed;

    private CheckBox checkBoxAgreed;

    private Label label12;

    private Label label11;

    private Label label10;

    private ComboBox cmbUserCreate;

    private Label label15;

    private TextBox txtNum;

    private GroupBox groupBoxDaily;

    private Button buttonDaily;

    private DataGridView dgvDaily;

    private CheckBox checkBoxWeekEnd;

    private CheckBox checkBoxDaily;

    private DateTimePicker dateTimePickerEnd;

    private DateTimePicker dateTimePickerBeg;

    private Label label2;

    private NullableDateTimePicker dtpDateCreate;

    private ToolStrip toolStripScheme;

    private ToolStripButton toolBtnLinkSchmObj;

    private ToolStripButton toolBtnDelSchmObj;

    private ToolStripButton toolBtnViewSChmObj;

    private TabControl tabControl;

    private TabPage tabPageGeneral;

    private TabPage tabPageSwitching;

    private TabPage tabPageDocuments;

    private DataSet dsLinkObjects;

    private DataTable tableLinkObjects;

    private DataColumn dataColumn25;

    private DataColumn dataColumn1;

    private DataColumn dataColumn2;

    private DataColumn dataColumn3;

    private DataColumn dataColumn4;

    private ToolStripButton toolBtnLinkSchmObjEdit;

    private DataGridViewExcelFilter dgvLinkObjects;

    private BindingSource bsLinkObjects;

    private DataGridViewTextBoxColumn objectsDataGridViewTextBoxColumn1;

    private DataGridViewTextBoxColumn dateBegDataGridViewTextBoxColumn2;

    private DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn2;

    private DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn1;

    private DataGridViewTextBoxColumn numDataGridViewTextBoxColumn1;

    private DataGridViewExcelFilter dgvDocs;

    private BindingSource bsRequestForRepairDoc;

    private ToolStrip toolStrip1;

    private ToolStripButton toolBtnAddDoc;

    private DataTable tableRequestForReapirDoc;

    private DataColumn dataColumn5;

    private DataColumn dataColumn6;

    private DataColumn dataColumn7;

    private DataColumn dataColumn8;

    private ToolStripButton toolBtnDelDoc;

    private ToolStripButton toolBtnViewDoc;

    private ToolStripButton toolBtnSaveDoc;

    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumnDoc;

    private DataGridViewImageColumnNotNull ColumnImage;

    private DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn1;

    private DataGridViewLinkColumn fileNameDataGridViewTextBoxColumn;

    private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;

    private Button buttonCopy;

    private ToolStrip toolStripMain;

    private ToolStripButton toolBtnCopy;

    private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

    private DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn;

    private DataGridViewFilterDateTimePickerColumn dateBegDataGridViewTextBoxColumn;

    private DataGridViewFilterDateTimePickerColumn dateEndDataGridViewTextBoxColumn;

    private TextBox txtAdress;

    private ComboBox txtRequestFiled;

    private Label label3;

    private NullableDateTimePicker dtpFactEnd;

    private ComboBox cmbStatus;

    private Label labelStatus;

    private ComboBox cmbWorker;

    private Label labelWorker;
}
