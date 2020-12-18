namespace Prv.Forms.Abonent
{
    partial class FormAddEditPoint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelCodeAbn = new System.Windows.Forms.Label();
            this.txtCodeAbn = new System.Windows.Forms.TextBox();
            this.groupBoxPoint = new System.Windows.Forms.GroupBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.dsPoint = new Prv.DataSets.DataSetPrv();
            this.bindingSourceLocation = new System.Windows.Forms.BindingSource(this.components);
            this.labelLocation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVoltage = new System.Windows.Forms.TextBox();
            this.cmbTension = new System.Windows.Forms.ComboBox();
            this.bindingSourceTension = new System.Windows.Forms.BindingSource(this.components);
            this.labelTension = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new ControlsLbr.NullableDateTimePicker();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.dateTimePickerBeg = new System.Windows.Forms.DateTimePicker();
            this.labelDateBeg = new System.Windows.Forms.Label();
            this.tabControlMark = new System.Windows.Forms.TabControl();
            this.tabPageMarkMeter = new System.Windows.Forms.TabPage();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxMeter = new System.Windows.Forms.GroupBox();
            this.cmbWorkerDem = new System.Windows.Forms.ComboBox();
            this.bindSourceWorkerDem = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cmbWorkerUst = new System.Windows.Forms.ComboBox();
            this.bindSourceMasterUst = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDateDem = new ControlsLbr.NullableDateTimePicker();
            this.labelDateDem = new System.Windows.Forms.Label();
            this.dateTimePickerDateUst = new System.Windows.Forms.DateTimePicker();
            this.labelDateUst = new System.Windows.Forms.Label();
            this.cmbMeterCheckYear = new System.Windows.Forms.ComboBox();
            this.cmbMeterCheckKvartal = new System.Windows.Forms.ComboBox();
            this.labelDateCheck = new System.Windows.Forms.Label();
            this.txtNumberMeter = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.dateTimePickerDateMade = new ControlsLbr.NullableDateTimePicker();
            this.labelDateMade = new System.Windows.Forms.Label();
            this.cmbMarkMeter = new ControlsLbr.MultiColumnComboBox();
            this.labelMarkMeter = new System.Windows.Forms.Label();
            this.cmbTypeMeter = new System.Windows.Forms.ComboBox();
            this.bindingSourceTypeMeter = new System.Windows.Forms.BindingSource(this.components);
            this.labelTypeMeter = new System.Windows.Forms.Label();
            this.tabPageZone = new System.Windows.Forms.TabPage();
            this.dgvZoneIndicator = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idZobeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSubZoneNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subZoneNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageMarkTrans = new System.Windows.Forms.TabPage();
            this.richTextBoxTransComment = new System.Windows.Forms.RichTextBox();
            this.dsTrans = new Prv.DataSets.DataSetPrv();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbTransMasterDem = new System.Windows.Forms.ComboBox();
            this.bindingSourceTransMasterDem = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTransMasterUst = new System.Windows.Forms.ComboBox();
            this.bindingSourceTransMasterUst = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerTransdateDem = new ControlsLbr.NullableDateTimePicker();
            this.labelTransDateDem = new System.Windows.Forms.Label();
            this.dateTimePickerTransDateUst = new System.Windows.Forms.DateTimePicker();
            this.labelTransDateUst = new System.Windows.Forms.Label();
            this.cmbTransCheckYear = new System.Windows.Forms.ComboBox();
            this.cmbTransCheckKvartal = new System.Windows.Forms.ComboBox();
            this.labelTransCheckDate = new System.Windows.Forms.Label();
            this.txtTransNumber = new System.Windows.Forms.TextBox();
            this.labelNumberTrans = new System.Windows.Forms.Label();
            this.dateTimePickerTransDateMade = new ControlsLbr.NullableDateTimePicker();
            this.labelTransDateMade = new System.Windows.Forms.Label();
            this.cmbMarkTrans = new ControlsLbr.MultiColumnComboBox();
            this.labelMarkTrans = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tbNPoint = new System.Windows.Forms.TextBox();
            this.lPoint = new System.Windows.Forms.Label();
            this.groupBoxPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTension)).BeginInit();
            this.tabControlMark.SuspendLayout();
            this.tabPageMarkMeter.SuspendLayout();
            this.groupBoxMeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSourceWorkerDem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSourceMasterUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypeMeter)).BeginInit();
            this.tabPageZone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZoneIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVr_Zone)).BeginInit();
            this.tabPageMarkTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTransMasterDem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTransMasterUst)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodeAbn
            // 
            this.labelCodeAbn.AutoSize = true;
            this.labelCodeAbn.Location = new System.Drawing.Point(16, 11);
            this.labelCodeAbn.Name = "labelCodeAbn";
            this.labelCodeAbn.Size = new System.Drawing.Size(91, 13);
            this.labelCodeAbn.TabIndex = 0;
            this.labelCodeAbn.Text = "Номер абонента";
            // 
            // txtCodeAbn
            // 
            this.txtCodeAbn.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodeAbn.Location = new System.Drawing.Point(113, 8);
            this.txtCodeAbn.Name = "txtCodeAbn";
            this.txtCodeAbn.ReadOnly = true;
            this.txtCodeAbn.Size = new System.Drawing.Size(100, 20);
            this.txtCodeAbn.TabIndex = 1;
            // 
            // groupBoxPoint
            // 
            this.groupBoxPoint.Controls.Add(this.cmbLocation);
            this.groupBoxPoint.Controls.Add(this.labelLocation);
            this.groupBoxPoint.Controls.Add(this.label1);
            this.groupBoxPoint.Controls.Add(this.txtVoltage);
            this.groupBoxPoint.Controls.Add(this.cmbTension);
            this.groupBoxPoint.Controls.Add(this.labelTension);
            this.groupBoxPoint.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxPoint.Controls.Add(this.labelDateEnd);
            this.groupBoxPoint.Controls.Add(this.dateTimePickerBeg);
            this.groupBoxPoint.Controls.Add(this.labelDateBeg);
            this.groupBoxPoint.Location = new System.Drawing.Point(0, 34);
            this.groupBoxPoint.Name = "groupBoxPoint";
            this.groupBoxPoint.Size = new System.Drawing.Size(339, 95);
            this.groupBoxPoint.TabIndex = 2;
            this.groupBoxPoint.TabStop = false;
            this.groupBoxPoint.Text = "Точка учета";
            // 
            // cmbLocation
            // 
            this.cmbLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPoint, "tPoint.idLocation", true));
            this.cmbLocation.DataSource = this.bindingSourceLocation;
            this.cmbLocation.DisplayMember = "Name";
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(179, 71);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(144, 21);
            this.cmbLocation.TabIndex = 9;
            this.cmbLocation.ValueMember = "Id";
            // 
            // dsPoint
            // 
            this.dsPoint.DataSetName = "DataSetPrv";
            this.dsPoint.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceLocation
            // 
            this.bindingSourceLocation.DataMember = "tR_Classifier";
            this.bindingSourceLocation.DataSource = this.dsPoint;
            this.bindingSourceLocation.Filter = "ParentKey = \';SKUEE;PointLocation;\'";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(176, 55);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(82, 13);
            this.labelLocation.TabIndex = 8;
            this.labelLocation.Text = "Расположение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "кВ";
            // 
            // txtVoltage
            // 
            this.txtVoltage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPoint, "tPoint.Voltage", true));
            this.txtVoltage.Location = new System.Drawing.Point(70, 71);
            this.txtVoltage.Name = "txtVoltage";
            this.txtVoltage.Size = new System.Drawing.Size(58, 20);
            this.txtVoltage.TabIndex = 6;
            // 
            // cmbTension
            // 
            this.cmbTension.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTension.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbTension.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPoint, "tPoint.idTension", true));
            this.cmbTension.DataSource = this.bindingSourceTension;
            this.cmbTension.DisplayMember = "Name";
            this.cmbTension.FormattingEnabled = true;
            this.cmbTension.Location = new System.Drawing.Point(15, 71);
            this.cmbTension.Name = "cmbTension";
            this.cmbTension.Size = new System.Drawing.Size(49, 21);
            this.cmbTension.TabIndex = 5;
            this.cmbTension.ValueMember = "Id";
            // 
            // bindingSourceTension
            // 
            this.bindingSourceTension.DataMember = "tR_Classifier";
            this.bindingSourceTension.DataSource = this.dsPoint;
            this.bindingSourceTension.Filter = "ParentKey = \';SKUEE;TypeTension;\'";
            // 
            // labelTension
            // 
            this.labelTension.AutoSize = true;
            this.labelTension.Location = new System.Drawing.Point(12, 55);
            this.labelTension.Name = "labelTension";
            this.labelTension.Size = new System.Drawing.Size(116, 13);
            this.labelTension.TabIndex = 4;
            this.labelTension.Text = "Уровень напряжения";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsPoint, "tPoint.DateEnd", true));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(179, 32);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerEnd.TabIndex = 3;
            this.dateTimePickerEnd.Value = new System.DateTime(2010, 11, 6, 9, 27, 27, 256);
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(176, 16);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(89, 13);
            this.labelDateEnd.TabIndex = 2;
            this.labelDateEnd.Text = "Дата окончания";
            // 
            // dateTimePickerBeg
            // 
            this.dateTimePickerBeg.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsPoint, "tPoint.DateBegin", true));
            this.dateTimePickerBeg.Location = new System.Drawing.Point(15, 32);
            this.dateTimePickerBeg.Name = "dateTimePickerBeg";
            this.dateTimePickerBeg.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerBeg.TabIndex = 1;
            this.dateTimePickerBeg.ValueChanged += new System.EventHandler(this.dateTimePickerBeg_ValueChanged);
            // 
            // labelDateBeg
            // 
            this.labelDateBeg.AutoSize = true;
            this.labelDateBeg.Location = new System.Drawing.Point(12, 16);
            this.labelDateBeg.Name = "labelDateBeg";
            this.labelDateBeg.Size = new System.Drawing.Size(71, 13);
            this.labelDateBeg.TabIndex = 0;
            this.labelDateBeg.Text = "Дата начала";
            // 
            // tabControlMark
            // 
            this.tabControlMark.Controls.Add(this.tabPageMarkMeter);
            this.tabControlMark.Controls.Add(this.tabPageZone);
            this.tabControlMark.Controls.Add(this.tabPageMarkTrans);
            this.tabControlMark.Location = new System.Drawing.Point(0, 128);
            this.tabControlMark.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMark.Name = "tabControlMark";
            this.tabControlMark.SelectedIndex = 0;
            this.tabControlMark.Size = new System.Drawing.Size(339, 318);
            this.tabControlMark.TabIndex = 3;
            // 
            // tabPageMarkMeter
            // 
            this.tabPageMarkMeter.Controls.Add(this.richTextBoxComment);
            this.tabPageMarkMeter.Controls.Add(this.label4);
            this.tabPageMarkMeter.Controls.Add(this.groupBoxMeter);
            this.tabPageMarkMeter.Controls.Add(this.cmbTypeMeter);
            this.tabPageMarkMeter.Controls.Add(this.labelTypeMeter);
            this.tabPageMarkMeter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageMarkMeter.Location = new System.Drawing.Point(4, 22);
            this.tabPageMarkMeter.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageMarkMeter.Name = "tabPageMarkMeter";
            this.tabPageMarkMeter.Size = new System.Drawing.Size(331, 292);
            this.tabPageMarkMeter.TabIndex = 0;
            this.tabPageMarkMeter.Text = "Прибор учета";
            this.tabPageMarkMeter.UseVisualStyleBackColor = true;
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPoint, "tPointReg.Comment", true));
            this.richTextBoxComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxComment.Location = new System.Drawing.Point(0, 231);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(331, 61);
            this.richTextBoxComment.TabIndex = 6;
            this.richTextBoxComment.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Комментарий";
            // 
            // groupBoxMeter
            // 
            this.groupBoxMeter.Controls.Add(this.cmbWorkerDem);
            this.groupBoxMeter.Controls.Add(this.label3);
            this.groupBoxMeter.Controls.Add(this.cmbWorkerUst);
            this.groupBoxMeter.Controls.Add(this.label2);
            this.groupBoxMeter.Controls.Add(this.dateTimePickerDateDem);
            this.groupBoxMeter.Controls.Add(this.labelDateDem);
            this.groupBoxMeter.Controls.Add(this.dateTimePickerDateUst);
            this.groupBoxMeter.Controls.Add(this.labelDateUst);
            this.groupBoxMeter.Controls.Add(this.cmbMeterCheckYear);
            this.groupBoxMeter.Controls.Add(this.cmbMeterCheckKvartal);
            this.groupBoxMeter.Controls.Add(this.labelDateCheck);
            this.groupBoxMeter.Controls.Add(this.txtNumberMeter);
            this.groupBoxMeter.Controls.Add(this.labelNumber);
            this.groupBoxMeter.Controls.Add(this.dateTimePickerDateMade);
            this.groupBoxMeter.Controls.Add(this.labelDateMade);
            this.groupBoxMeter.Controls.Add(this.cmbMarkMeter);
            this.groupBoxMeter.Controls.Add(this.labelMarkMeter);
            this.groupBoxMeter.Location = new System.Drawing.Point(0, 33);
            this.groupBoxMeter.Name = "groupBoxMeter";
            this.groupBoxMeter.Size = new System.Drawing.Size(335, 183);
            this.groupBoxMeter.TabIndex = 4;
            this.groupBoxMeter.TabStop = false;
            this.groupBoxMeter.Text = "Счетчик";
            // 
            // cmbWorkerDem
            // 
            this.cmbWorkerDem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWorkerDem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWorkerDem.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPoint, "tPointReg.idWorkerEnd", true));
            this.cmbWorkerDem.DataSource = this.bindSourceWorkerDem;
            this.cmbWorkerDem.DisplayMember = "FIO";
            this.cmbWorkerDem.FormattingEnabled = true;
            this.cmbWorkerDem.Location = new System.Drawing.Point(175, 150);
            this.cmbWorkerDem.Name = "cmbWorkerDem";
            this.cmbWorkerDem.Size = new System.Drawing.Size(144, 21);
            this.cmbWorkerDem.TabIndex = 18;
            this.cmbWorkerDem.ValueMember = "id";
            // 
            // bindSourceWorkerDem
            // 
            this.bindSourceWorkerDem.DataMember = "vWorkerGroup";
            this.bindSourceWorkerDem.DataSource = this.dsPoint;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Мастер";
            // 
            // cmbWorkerUst
            // 
            this.cmbWorkerUst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbWorkerUst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbWorkerUst.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPoint, "tPointReg.idWorkerBegin", true));
            this.cmbWorkerUst.DataSource = this.bindSourceMasterUst;
            this.cmbWorkerUst.DisplayMember = "FIO";
            this.cmbWorkerUst.FormattingEnabled = true;
            this.cmbWorkerUst.Location = new System.Drawing.Point(11, 150);
            this.cmbWorkerUst.Name = "cmbWorkerUst";
            this.cmbWorkerUst.Size = new System.Drawing.Size(144, 21);
            this.cmbWorkerUst.TabIndex = 16;
            this.cmbWorkerUst.ValueMember = "id";
            // 
            // bindSourceMasterUst
            // 
            this.bindSourceMasterUst.DataMember = "vWorkerGroup";
            this.bindSourceMasterUst.DataSource = this.dsPoint;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Мастер";
            // 
            // dateTimePickerDateDem
            // 
            this.dateTimePickerDateDem.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsPoint, "tPointReg.DateEnd", true));
            this.dateTimePickerDateDem.Location = new System.Drawing.Point(175, 111);
            this.dateTimePickerDateDem.Name = "dateTimePickerDateDem";
            this.dateTimePickerDateDem.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerDateDem.TabIndex = 14;
            this.dateTimePickerDateDem.Value = new System.DateTime(2010, 11, 6, 11, 33, 27, 788);
            // 
            // labelDateDem
            // 
            this.labelDateDem.AutoSize = true;
            this.labelDateDem.Location = new System.Drawing.Point(172, 95);
            this.labelDateDem.Name = "labelDateDem";
            this.labelDateDem.Size = new System.Drawing.Size(93, 13);
            this.labelDateDem.TabIndex = 13;
            this.labelDateDem.Text = "Дата демонтажа";
            // 
            // dateTimePickerDateUst
            // 
            this.dateTimePickerDateUst.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsPoint, "tPointReg.DateBegin", true));
            this.dateTimePickerDateUst.Location = new System.Drawing.Point(11, 111);
            this.dateTimePickerDateUst.Name = "dateTimePickerDateUst";
            this.dateTimePickerDateUst.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerDateUst.TabIndex = 12;
            this.dateTimePickerDateUst.Value = new System.DateTime(2010, 11, 11, 0, 0, 0, 0);
            this.dateTimePickerDateUst.ValueChanged += new System.EventHandler(this.dateTimePickerDateUst_ValueChanged);
            // 
            // labelDateUst
            // 
            this.labelDateUst.AutoSize = true;
            this.labelDateUst.Location = new System.Drawing.Point(8, 95);
            this.labelDateUst.Name = "labelDateUst";
            this.labelDateUst.Size = new System.Drawing.Size(88, 13);
            this.labelDateUst.TabIndex = 11;
            this.labelDateUst.Text = "Дата установки";
            // 
            // cmbMeterCheckYear
            // 
            this.cmbMeterCheckYear.FormattingEnabled = true;
            this.cmbMeterCheckYear.Location = new System.Drawing.Point(227, 71);
            this.cmbMeterCheckYear.Name = "cmbMeterCheckYear";
            this.cmbMeterCheckYear.Size = new System.Drawing.Size(92, 21);
            this.cmbMeterCheckYear.TabIndex = 10;
            // 
            // cmbMeterCheckKvartal
            // 
            this.cmbMeterCheckKvartal.FormattingEnabled = true;
            this.cmbMeterCheckKvartal.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cmbMeterCheckKvartal.Location = new System.Drawing.Point(175, 71);
            this.cmbMeterCheckKvartal.Name = "cmbMeterCheckKvartal";
            this.cmbMeterCheckKvartal.Size = new System.Drawing.Size(54, 21);
            this.cmbMeterCheckKvartal.TabIndex = 9;
            // 
            // labelDateCheck
            // 
            this.labelDateCheck.AutoSize = true;
            this.labelDateCheck.Location = new System.Drawing.Point(172, 56);
            this.labelDateCheck.Name = "labelDateCheck";
            this.labelDateCheck.Size = new System.Drawing.Size(95, 13);
            this.labelDateCheck.TabIndex = 8;
            this.labelDateCheck.Text = "Дата госповерки";
            // 
            // txtNumberMeter
            // 
            this.txtNumberMeter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPoint, "tPointReg.Number", true));
            this.txtNumberMeter.Location = new System.Drawing.Point(11, 72);
            this.txtNumberMeter.Name = "txtNumberMeter";
            this.txtNumberMeter.Size = new System.Drawing.Size(144, 20);
            this.txtNumberMeter.TabIndex = 7;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(8, 56);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(97, 13);
            this.labelNumber.TabIndex = 6;
            this.labelNumber.Text = "Заводской номер";
            // 
            // dateTimePickerDateMade
            // 
            this.dateTimePickerDateMade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsPoint, "tPointReg.DateMade", true));
            this.dateTimePickerDateMade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateMade.Location = new System.Drawing.Point(175, 32);
            this.dateTimePickerDateMade.Name = "dateTimePickerDateMade";
            this.dateTimePickerDateMade.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerDateMade.TabIndex = 5;
            this.dateTimePickerDateMade.Value = new System.DateTime(2010, 11, 8, 11, 2, 17, 129);
            // 
            // labelDateMade
            // 
            this.labelDateMade.AutoSize = true;
            this.labelDateMade.Location = new System.Drawing.Point(172, 16);
            this.labelDateMade.Name = "labelDateMade";
            this.labelDateMade.Size = new System.Drawing.Size(107, 13);
            this.labelDateMade.TabIndex = 4;
            this.labelDateMade.Text = "Дата производства";
            // 
            // cmbMarkMeter
            // 
            this.cmbMarkMeter.AutoComplete = true;
            this.cmbMarkMeter.AutoDropdown = true;
            this.cmbMarkMeter.BackColorEven = System.Drawing.Color.White;
            this.cmbMarkMeter.BackColorOdd = System.Drawing.Color.White;
            this.cmbMarkMeter.ColumnNames = "";
            this.cmbMarkMeter.ColumnWidthDefault = 75;
            this.cmbMarkMeter.ColumnWidths = "0;100;25;25;30;25;0;0;0;0;0";
            this.cmbMarkMeter.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPoint, "tPointReg.IdMark", true));
            this.cmbMarkMeter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMarkMeter.FormattingEnabled = true;
            this.cmbMarkMeter.LinkedColumnIndex = 0;
            this.cmbMarkMeter.LinkedTextBox = null;
            this.cmbMarkMeter.Location = new System.Drawing.Point(11, 32);
            this.cmbMarkMeter.Name = "cmbMarkMeter";
            this.cmbMarkMeter.Size = new System.Drawing.Size(144, 21);
            this.cmbMarkMeter.TabIndex = 3;
            // 
            // labelMarkMeter
            // 
            this.labelMarkMeter.AutoSize = true;
            this.labelMarkMeter.Location = new System.Drawing.Point(8, 16);
            this.labelMarkMeter.Name = "labelMarkMeter";
            this.labelMarkMeter.Size = new System.Drawing.Size(40, 13);
            this.labelMarkMeter.TabIndex = 2;
            this.labelMarkMeter.Text = "Марка";
            // 
            // cmbTypeMeter
            // 
            this.cmbTypeMeter.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPoint, "tPointReg.Type", true));
            this.cmbTypeMeter.DataSource = this.bindingSourceTypeMeter;
            this.cmbTypeMeter.DisplayMember = "Name";
            this.cmbTypeMeter.FormattingEnabled = true;
            this.cmbTypeMeter.Location = new System.Drawing.Point(109, 10);
            this.cmbTypeMeter.Name = "cmbTypeMeter";
            this.cmbTypeMeter.Size = new System.Drawing.Size(144, 21);
            this.cmbTypeMeter.TabIndex = 1;
            this.cmbTypeMeter.ValueMember = "Id";
            this.cmbTypeMeter.SelectedIndexChanged += new System.EventHandler(this.cmbTypeMeter_SelectedIndexChanged);
            // 
            // bindingSourceTypeMeter
            // 
            this.bindingSourceTypeMeter.DataMember = "tR_Classifier";
            this.bindingSourceTypeMeter.DataSource = this.dsPoint;
            // 
            // labelTypeMeter
            // 
            this.labelTypeMeter.AutoSize = true;
            this.labelTypeMeter.Location = new System.Drawing.Point(77, 13);
            this.labelTypeMeter.Name = "labelTypeMeter";
            this.labelTypeMeter.Size = new System.Drawing.Size(26, 13);
            this.labelTypeMeter.TabIndex = 0;
            this.labelTypeMeter.Text = "Тип";
            // 
            // tabPageZone
            // 
            this.tabPageZone.Controls.Add(this.dgvZoneIndicator);
            this.tabPageZone.Controls.Add(this.cmbZone);
            this.tabPageZone.Controls.Add(this.label5);
            this.tabPageZone.Location = new System.Drawing.Point(4, 22);
            this.tabPageZone.Name = "tabPageZone";
            this.tabPageZone.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZone.Size = new System.Drawing.Size(331, 292);
            this.tabPageZone.TabIndex = 2;
            this.tabPageZone.Text = "Временные зоны";
            this.tabPageZone.UseVisualStyleBackColor = true;
            // 
            // dgvZoneIndicator
            // 
            this.dgvZoneIndicator.AllowUserToAddRows = false;
            this.dgvZoneIndicator.AllowUserToDeleteRows = false;
            this.dgvZoneIndicator.AutoGenerateColumns = false;
            this.dgvZoneIndicator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZoneIndicator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnName,
            this.ColumnTime,
            this.ColumnUst,
            this.ColumnDem,
            this.idZobeNameDataGridViewTextBoxColumn,
            this.idSubZoneNameDataGridViewTextBoxColumn,
            this.timeBeginDataGridViewTextBoxColumn,
            this.timeEndDataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.zoneNameDataGridViewTextBoxColumn,
            this.subZoneNameDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn});
            this.dgvZoneIndicator.DataMember = "vr_Zone";
            this.dgvZoneIndicator.DataSource = this.dsZone;
            this.dgvZoneIndicator.Location = new System.Drawing.Point(0, 38);
            this.dgvZoneIndicator.Name = "dgvZoneIndicator";
            this.dgvZoneIndicator.RowHeadersVisible = false;
            this.dgvZoneIndicator.Size = new System.Drawing.Size(331, 254);
            this.dgvZoneIndicator.TabIndex = 2;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.DataPropertyName = "SubZoneName";
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ColumnName.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 80;
            // 
            // ColumnTime
            // 
            this.ColumnTime.DataPropertyName = "Time";
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ColumnTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnTime.HeaderText = "Время";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.Width = 80;
            // 
            // ColumnUst
            // 
            this.ColumnUst.DataPropertyName = "ValueBegin";
            this.ColumnUst.HeaderText = "Установка";
            this.ColumnUst.Name = "ColumnUst";
            this.ColumnUst.Width = 80;
            // 
            // ColumnDem
            // 
            this.ColumnDem.DataPropertyName = "ValueEnd";
            this.ColumnDem.HeaderText = "Демонтаж";
            this.ColumnDem.Name = "ColumnDem";
            this.ColumnDem.Width = 80;
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
            this.subZoneNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Visible = false;
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
            // cmbZone
            // 
            this.cmbZone.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPoint, "tPointReg.IdZone", true));
            this.cmbZone.DataSource = this.dsZone;
            this.cmbZone.DisplayMember = "tr_Classifier.Name";
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(117, 11);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(194, 21);
            this.cmbZone.TabIndex = 1;
            this.cmbZone.ValueMember = "tr_Classifier.Id";
            this.cmbZone.SelectedIndexChanged += new System.EventHandler(this.cmbZone_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Временная зона";
            // 
            // tabPageMarkTrans
            // 
            this.tabPageMarkTrans.Controls.Add(this.richTextBoxTransComment);
            this.tabPageMarkTrans.Controls.Add(this.label14);
            this.tabPageMarkTrans.Controls.Add(this.cmbTransMasterDem);
            this.tabPageMarkTrans.Controls.Add(this.label6);
            this.tabPageMarkTrans.Controls.Add(this.cmbTransMasterUst);
            this.tabPageMarkTrans.Controls.Add(this.label7);
            this.tabPageMarkTrans.Controls.Add(this.dateTimePickerTransdateDem);
            this.tabPageMarkTrans.Controls.Add(this.labelTransDateDem);
            this.tabPageMarkTrans.Controls.Add(this.dateTimePickerTransDateUst);
            this.tabPageMarkTrans.Controls.Add(this.labelTransDateUst);
            this.tabPageMarkTrans.Controls.Add(this.cmbTransCheckYear);
            this.tabPageMarkTrans.Controls.Add(this.cmbTransCheckKvartal);
            this.tabPageMarkTrans.Controls.Add(this.labelTransCheckDate);
            this.tabPageMarkTrans.Controls.Add(this.txtTransNumber);
            this.tabPageMarkTrans.Controls.Add(this.labelNumberTrans);
            this.tabPageMarkTrans.Controls.Add(this.dateTimePickerTransDateMade);
            this.tabPageMarkTrans.Controls.Add(this.labelTransDateMade);
            this.tabPageMarkTrans.Controls.Add(this.cmbMarkTrans);
            this.tabPageMarkTrans.Controls.Add(this.labelMarkTrans);
            this.tabPageMarkTrans.Location = new System.Drawing.Point(4, 22);
            this.tabPageMarkTrans.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageMarkTrans.Name = "tabPageMarkTrans";
            this.tabPageMarkTrans.Size = new System.Drawing.Size(331, 292);
            this.tabPageMarkTrans.TabIndex = 1;
            this.tabPageMarkTrans.Text = "Трансформатор";
            this.tabPageMarkTrans.UseVisualStyleBackColor = true;
            // 
            // richTextBoxTransComment
            // 
            this.richTextBoxTransComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTrans, "tPointReg.Comment", true));
            this.richTextBoxTransComment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxTransComment.Location = new System.Drawing.Point(0, 191);
            this.richTextBoxTransComment.Name = "richTextBoxTransComment";
            this.richTextBoxTransComment.Size = new System.Drawing.Size(331, 101);
            this.richTextBoxTransComment.TabIndex = 37;
            this.richTextBoxTransComment.Text = "";
            // 
            // dsTrans
            // 
            this.dsTrans.DataSetName = "DataSetPrv";
            this.dsTrans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 175);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Комментарий";
            // 
            // cmbTransMasterDem
            // 
            this.cmbTransMasterDem.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsTrans, "tPointReg.idWorkerEnd", true));
            this.cmbTransMasterDem.DataSource = this.bindingSourceTransMasterDem;
            this.cmbTransMasterDem.DisplayMember = "FIO";
            this.cmbTransMasterDem.FormattingEnabled = true;
            this.cmbTransMasterDem.Location = new System.Drawing.Point(175, 151);
            this.cmbTransMasterDem.Name = "cmbTransMasterDem";
            this.cmbTransMasterDem.Size = new System.Drawing.Size(144, 21);
            this.cmbTransMasterDem.TabIndex = 35;
            this.cmbTransMasterDem.ValueMember = "id";
            // 
            // bindingSourceTransMasterDem
            // 
            this.bindingSourceTransMasterDem.DataMember = "vWorkerGroup";
            this.bindingSourceTransMasterDem.DataSource = this.dsPoint;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Мастер";
            // 
            // cmbTransMasterUst
            // 
            this.cmbTransMasterUst.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsTrans, "tPointReg.idWorkerBegin", true));
            this.cmbTransMasterUst.DataSource = this.bindingSourceTransMasterUst;
            this.cmbTransMasterUst.DisplayMember = "FIO";
            this.cmbTransMasterUst.FormattingEnabled = true;
            this.cmbTransMasterUst.Location = new System.Drawing.Point(11, 151);
            this.cmbTransMasterUst.Name = "cmbTransMasterUst";
            this.cmbTransMasterUst.Size = new System.Drawing.Size(144, 21);
            this.cmbTransMasterUst.TabIndex = 33;
            this.cmbTransMasterUst.ValueMember = "id";
            // 
            // bindingSourceTransMasterUst
            // 
            this.bindingSourceTransMasterUst.DataMember = "vWorkerGroup";
            this.bindingSourceTransMasterUst.DataSource = this.dsPoint;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Мастер";
            // 
            // dateTimePickerTransdateDem
            // 
            this.dateTimePickerTransdateDem.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsTrans, "tPointReg.DateEnd", true));
            this.dateTimePickerTransdateDem.Location = new System.Drawing.Point(175, 112);
            this.dateTimePickerTransdateDem.Name = "dateTimePickerTransdateDem";
            this.dateTimePickerTransdateDem.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerTransdateDem.TabIndex = 31;
            this.dateTimePickerTransdateDem.Value = new System.DateTime(2010, 11, 6, 11, 33, 27, 788);
            // 
            // labelTransDateDem
            // 
            this.labelTransDateDem.AutoSize = true;
            this.labelTransDateDem.Location = new System.Drawing.Point(172, 96);
            this.labelTransDateDem.Name = "labelTransDateDem";
            this.labelTransDateDem.Size = new System.Drawing.Size(93, 13);
            this.labelTransDateDem.TabIndex = 30;
            this.labelTransDateDem.Text = "Дата демонтажа";
            // 
            // dateTimePickerTransDateUst
            // 
            this.dateTimePickerTransDateUst.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsTrans, "tPointReg.DateBegin", true));
            this.dateTimePickerTransDateUst.Location = new System.Drawing.Point(11, 112);
            this.dateTimePickerTransDateUst.Name = "dateTimePickerTransDateUst";
            this.dateTimePickerTransDateUst.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerTransDateUst.TabIndex = 29;
            this.dateTimePickerTransDateUst.Value = new System.DateTime(2010, 11, 11, 8, 44, 10, 0);
            this.dateTimePickerTransDateUst.ValueChanged += new System.EventHandler(this.dateTimePickerTransDateUst_ValueChanged);
            // 
            // labelTransDateUst
            // 
            this.labelTransDateUst.AutoSize = true;
            this.labelTransDateUst.Location = new System.Drawing.Point(8, 96);
            this.labelTransDateUst.Name = "labelTransDateUst";
            this.labelTransDateUst.Size = new System.Drawing.Size(88, 13);
            this.labelTransDateUst.TabIndex = 28;
            this.labelTransDateUst.Text = "Дата установки";
            // 
            // cmbTransCheckYear
            // 
            this.cmbTransCheckYear.FormattingEnabled = true;
            this.cmbTransCheckYear.Location = new System.Drawing.Point(227, 72);
            this.cmbTransCheckYear.Name = "cmbTransCheckYear";
            this.cmbTransCheckYear.Size = new System.Drawing.Size(92, 21);
            this.cmbTransCheckYear.TabIndex = 27;
            // 
            // cmbTransCheckKvartal
            // 
            this.cmbTransCheckKvartal.FormattingEnabled = true;
            this.cmbTransCheckKvartal.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cmbTransCheckKvartal.Location = new System.Drawing.Point(175, 72);
            this.cmbTransCheckKvartal.Name = "cmbTransCheckKvartal";
            this.cmbTransCheckKvartal.Size = new System.Drawing.Size(54, 21);
            this.cmbTransCheckKvartal.TabIndex = 26;
            // 
            // labelTransCheckDate
            // 
            this.labelTransCheckDate.AutoSize = true;
            this.labelTransCheckDate.Location = new System.Drawing.Point(172, 57);
            this.labelTransCheckDate.Name = "labelTransCheckDate";
            this.labelTransCheckDate.Size = new System.Drawing.Size(95, 13);
            this.labelTransCheckDate.TabIndex = 25;
            this.labelTransCheckDate.Text = "Дата госповерки";
            // 
            // txtTransNumber
            // 
            this.txtTransNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsTrans, "tPointReg.Number", true));
            this.txtTransNumber.Location = new System.Drawing.Point(11, 73);
            this.txtTransNumber.Name = "txtTransNumber";
            this.txtTransNumber.Size = new System.Drawing.Size(144, 20);
            this.txtTransNumber.TabIndex = 24;
            // 
            // labelNumberTrans
            // 
            this.labelNumberTrans.AutoSize = true;
            this.labelNumberTrans.Location = new System.Drawing.Point(8, 57);
            this.labelNumberTrans.Name = "labelNumberTrans";
            this.labelNumberTrans.Size = new System.Drawing.Size(97, 13);
            this.labelNumberTrans.TabIndex = 23;
            this.labelNumberTrans.Text = "Заводской номер";
            // 
            // dateTimePickerTransDateMade
            // 
            this.dateTimePickerTransDateMade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsTrans, "tPointReg.DateMade", true));
            this.dateTimePickerTransDateMade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransDateMade.Location = new System.Drawing.Point(175, 33);
            this.dateTimePickerTransDateMade.Name = "dateTimePickerTransDateMade";
            this.dateTimePickerTransDateMade.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerTransDateMade.TabIndex = 22;
            this.dateTimePickerTransDateMade.Value = new System.DateTime(2010, 11, 8, 11, 2, 17, 129);
            // 
            // labelTransDateMade
            // 
            this.labelTransDateMade.AutoSize = true;
            this.labelTransDateMade.Location = new System.Drawing.Point(172, 17);
            this.labelTransDateMade.Name = "labelTransDateMade";
            this.labelTransDateMade.Size = new System.Drawing.Size(107, 13);
            this.labelTransDateMade.TabIndex = 21;
            this.labelTransDateMade.Text = "Дата производства";
            // 
            // cmbMarkTrans
            // 
            this.cmbMarkTrans.AutoComplete = true;
            this.cmbMarkTrans.AutoDropdown = true;
            this.cmbMarkTrans.BackColorEven = System.Drawing.Color.White;
            this.cmbMarkTrans.BackColorOdd = System.Drawing.Color.White;
            this.cmbMarkTrans.ColumnNames = "";
            this.cmbMarkTrans.ColumnWidthDefault = 75;
            this.cmbMarkTrans.ColumnWidths = "0;100;25;25;30;25;0;0;0;0;0";
            this.cmbMarkTrans.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsTrans, "tPointReg.IdMark", true));
            this.cmbMarkTrans.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMarkTrans.FormattingEnabled = true;
            this.cmbMarkTrans.LinkedColumnIndex = 0;
            this.cmbMarkTrans.LinkedTextBox = null;
            this.cmbMarkTrans.Location = new System.Drawing.Point(11, 33);
            this.cmbMarkTrans.Name = "cmbMarkTrans";
            this.cmbMarkTrans.Size = new System.Drawing.Size(144, 21);
            this.cmbMarkTrans.TabIndex = 20;
            // 
            // labelMarkTrans
            // 
            this.labelMarkTrans.AutoSize = true;
            this.labelMarkTrans.Location = new System.Drawing.Point(8, 17);
            this.labelMarkTrans.Name = "labelMarkTrans";
            this.labelMarkTrans.Size = new System.Drawing.Size(40, 13);
            this.labelMarkTrans.TabIndex = 19;
            this.labelMarkTrans.Text = "Марка";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(15, 451);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(248, 451);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // tbNPoint
            // 
            this.tbNPoint.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPoint, "tPoint.Name", true));
            this.tbNPoint.Location = new System.Drawing.Point(271, 8);
            this.tbNPoint.Name = "tbNPoint";
            this.tbNPoint.Size = new System.Drawing.Size(52, 20);
            this.tbNPoint.TabIndex = 6;
            // 
            // lPoint
            // 
            this.lPoint.AutoSize = true;
            this.lPoint.Location = new System.Drawing.Point(228, 11);
            this.lPoint.Name = "lPoint";
            this.lPoint.Size = new System.Drawing.Size(37, 13);
            this.lPoint.TabIndex = 7;
            this.lPoint.Text = "Точка";
            // 
            // FormAddEditPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(339, 486);
            this.Controls.Add(this.lPoint);
            this.Controls.Add(this.tbNPoint);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.tabControlMark);
            this.Controls.Add(this.groupBoxPoint);
            this.Controls.Add(this.txtCodeAbn);
            this.Controls.Add(this.labelCodeAbn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEditPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddEditPoint";
            this.Load += new System.EventHandler(this.FormAddEditPoint_Load);
            this.groupBoxPoint.ResumeLayout(false);
            this.groupBoxPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTension)).EndInit();
            this.tabControlMark.ResumeLayout(false);
            this.tabPageMarkMeter.ResumeLayout(false);
            this.tabPageMarkMeter.PerformLayout();
            this.groupBoxMeter.ResumeLayout(false);
            this.groupBoxMeter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindSourceWorkerDem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindSourceMasterUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTypeMeter)).EndInit();
            this.tabPageZone.ResumeLayout(false);
            this.tabPageZone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZoneIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVr_Zone)).EndInit();
            this.tabPageMarkTrans.ResumeLayout(false);
            this.tabPageMarkTrans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTransMasterDem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTransMasterUst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodeAbn;
        private System.Windows.Forms.TextBox txtCodeAbn;
        private System.Windows.Forms.GroupBox groupBoxPoint;
        private Prv.DataSets.DataSetPrv dsPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVoltage;
        private System.Windows.Forms.ComboBox cmbTension;
        private System.Windows.Forms.Label labelTension;
        private ControlsLbr.NullableDateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeg;
        private System.Windows.Forms.Label labelDateBeg;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.BindingSource bindingSourceTension;
        private System.Windows.Forms.BindingSource bindingSourceLocation;
        private ControlsLbr.MultiColumnComboBox cmbMarkMeter;
        private System.Windows.Forms.Label labelMarkMeter;
        private System.Windows.Forms.ComboBox cmbTypeMeter;
        private System.Windows.Forms.Label labelTypeMeter;
        private System.Windows.Forms.BindingSource bindingSourceTypeMeter;
        private System.Windows.Forms.GroupBox groupBoxMeter;
        private ControlsLbr.NullableDateTimePicker dateTimePickerDateMade;
        private System.Windows.Forms.Label labelDateMade;
        private System.Windows.Forms.ComboBox cmbMeterCheckYear;
        private System.Windows.Forms.ComboBox cmbMeterCheckKvartal;
        private System.Windows.Forms.Label labelDateCheck;
        private System.Windows.Forms.TextBox txtNumberMeter;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.ComboBox cmbWorkerDem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbWorkerUst;
        private System.Windows.Forms.Label label2;
        private ControlsLbr.NullableDateTimePicker dateTimePickerDateDem;
        private System.Windows.Forms.Label labelDateDem;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateUst;
        private System.Windows.Forms.Label labelDateUst;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvZoneIndicator;
        private System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.BindingSource bindSourceWorkerDem;
        private System.Windows.Forms.BindingSource bindSourceMasterUst;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZobeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSubZoneNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subZoneNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBoxTransComment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbTransMasterDem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTransMasterUst;
        private System.Windows.Forms.Label label7;
        private ControlsLbr.NullableDateTimePicker dateTimePickerTransdateDem;
        private System.Windows.Forms.Label labelTransDateDem;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransDateUst;
        private System.Windows.Forms.Label labelTransDateUst;
        private System.Windows.Forms.ComboBox cmbTransCheckYear;
        private System.Windows.Forms.ComboBox cmbTransCheckKvartal;
        private System.Windows.Forms.Label labelTransCheckDate;
        private System.Windows.Forms.TextBox txtTransNumber;
        private System.Windows.Forms.Label labelNumberTrans;
        private ControlsLbr.NullableDateTimePicker dateTimePickerTransDateMade;
        private System.Windows.Forms.Label labelTransDateMade;
        private ControlsLbr.MultiColumnComboBox cmbMarkTrans;
        private System.Windows.Forms.Label labelMarkTrans;
        private Prv.DataSets.DataSetPrv dsTrans;
        private System.Windows.Forms.BindingSource bindingSourceTransMasterUst;
        private System.Windows.Forms.BindingSource bindingSourceTransMasterDem;
        public System.Windows.Forms.TabControl tabControlMark;
        public System.Windows.Forms.TabPage tabPageMarkTrans;
        public System.Windows.Forms.TabPage tabPageZone;
        public System.Windows.Forms.TabPage tabPageMarkMeter;
        private System.Windows.Forms.TextBox tbNPoint;
        private System.Windows.Forms.Label lPoint;

    }
}