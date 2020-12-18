namespace Legal.Forms.Meter
{
    partial class FormMeterAddEdit
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsPoint = new Legal.DataSet.DataSetAbn();
            this.bsObjMeter = new System.Windows.Forms.BindingSource(this.components);
            this.radioButtonNew = new System.Windows.Forms.RadioButton();
            this.radioButtonEdit = new System.Windows.Forms.RadioButton();
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.bsLocation = new System.Windows.Forms.BindingSource(this.components);
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.dateTimePickerBeg = new System.Windows.Forms.DateTimePicker();
            this.labelDateBeg = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.bsTypeMeter = new System.Windows.Forms.BindingSource(this.components);
            this.bsMasterUst = new System.Windows.Forms.BindingSource(this.components);
            this.bsMasterDem = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransMasterUst = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransMasterDem = new System.Windows.Forms.BindingSource(this.components);
            this.tpTime = new System.Windows.Forms.TabPage();
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
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tpMeter = new System.Windows.Forms.TabPage();
            this.gbTrans = new System.Windows.Forms.GroupBox();
            this.cmbMarkTrans1 = new Legal.Classes.MultiColumnComboBoxExt();
            this.richTextBoxTransComment = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbTransMasterDem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTransMasterUst = new System.Windows.Forms.ComboBox();
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
            this.labelMarkTrans = new System.Windows.Forms.Label();
            this.gbMeter = new System.Windows.Forms.GroupBox();
            this.txtActDemontag = new System.Windows.Forms.TextBox();
            this.txtActUstanov = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMarkMeter1 = new Legal.Classes.MultiColumnComboBoxExt();
            this.nudTRK = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerDateDem = new ControlsLbr.NullableDateTimePicker();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.cmbWorkerDem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbWorkerUst = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.labelMarkMeter = new System.Windows.Forms.Label();
            this.labelTRK = new System.Windows.Forms.Label();
            this.tcMeter = new System.Windows.Forms.TabControl();
            this.dgvObjMeter = new System.Windows.Forms.DataGridView();
            this.idMeterRegDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebeginMeterDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendMeterDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarkMeterDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idworkerbeginMeterDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerEndMeterDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerEndMeterDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datemadeMeterDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecheckMeterDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberMeterDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idzone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Digit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentMeterDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TR_K = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActUstanov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActDemontag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMeter = new System.Windows.Forms.BindingSource(this.components);
            this.bsTrans = new System.Windows.Forms.BindingSource(this.components);
            this.dgvObjTrans = new System.Windows.Forms.DataGridView();
            this.idTransDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpointDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebeginTransDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateendTransDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typenameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMarkTransDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentPointDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idworkerbeginTransDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerEndTrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBeginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerEndDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datemadeTransDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecheckTransDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberTransDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idzoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentTransDGVTBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Primary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Secondary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelObjMeter = new System.Windows.Forms.Label();
            this.labelObjTrans = new System.Windows.Forms.Label();
            this.groupBoxNewEdit = new System.Windows.Forms.GroupBox();
            this.rbMeter = new System.Windows.Forms.RadioButton();
            this.rbTrans = new System.Windows.Forms.RadioButton();
            this.groupBoxMeterTrans = new System.Windows.Forms.GroupBox();
            this.buttonNewPoint = new System.Windows.Forms.Button();
            this.buttonEditPoint = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new ControlsLbr.NullableDateTimePicker();
            this.NUDN = new System.Windows.Forms.NumericUpDown();
            this.labelN = new System.Windows.Forms.Label();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnMeter_Restore = new System.Windows.Forms.Button();
            this.btnTrans_Restore = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnMeterParameters_Log = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVr_Zone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypeMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMasterUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMasterDem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransMasterUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransMasterDem)).BeginInit();
            this.tpTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZoneIndicator)).BeginInit();
            this.tpMeter.SuspendLayout();
            this.gbTrans.SuspendLayout();
            this.gbMeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTRK)).BeginInit();
            this.tcMeter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjTrans)).BeginInit();
            this.groupBoxNewEdit.SuspendLayout();
            this.groupBoxMeterTrans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDN)).BeginInit();
            this.SuspendLayout();
            // 
            // dsPoint
            // 
            this.dsPoint.DataSetName = "DataSetAbn";
            this.dsPoint.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsObjMeter
            // 
            this.bsObjMeter.DataMember = "vG_MeterVal";
            this.bsObjMeter.DataSource = this.dsPoint;
            // 
            // radioButtonNew
            // 
            this.radioButtonNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonNew.AutoSize = true;
            this.radioButtonNew.Checked = true;
            this.radioButtonNew.Location = new System.Drawing.Point(22, 13);
            this.radioButtonNew.Name = "radioButtonNew";
            this.radioButtonNew.Size = new System.Drawing.Size(59, 17);
            this.radioButtonNew.TabIndex = 31;
            this.radioButtonNew.TabStop = true;
            this.radioButtonNew.Text = "Новый";
            this.radioButtonNew.UseVisualStyleBackColor = true;
            this.radioButtonNew.CheckedChanged += new System.EventHandler(this.radioButtonNew_CheckedChanged);
            // 
            // radioButtonEdit
            // 
            this.radioButtonEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonEdit.AutoSize = true;
            this.radioButtonEdit.Location = new System.Drawing.Point(99, 13);
            this.radioButtonEdit.Name = "radioButtonEdit";
            this.radioButtonEdit.Size = new System.Drawing.Size(109, 17);
            this.radioButtonEdit.TabIndex = 30;
            this.radioButtonEdit.TabStop = true;
            this.radioButtonEdit.Text = "Редактирование";
            this.radioButtonEdit.UseVisualStyleBackColor = true;
            this.radioButtonEdit.CheckedChanged += new System.EventHandler(this.radioButtonEdit_CheckedChanged);
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
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(568, 542);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 28);
            this.buttonCancel.TabIndex = 34;
            this.buttonCancel.Text = "Выход";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(5, 542);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 28);
            this.buttonOK.TabIndex = 33;
            this.buttonOK.Text = "Сохранить";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // bsLocation
            // 
            this.bsLocation.DataMember = "tR_Classifier";
            this.bsLocation.DataSource = this.dsPoint;
            this.bsLocation.Filter = "ParentKey = \';SKUEE;PointLocation;\'";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateEnd.Location = new System.Drawing.Point(160, 4);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(103, 13);
            this.labelDateEnd.TabIndex = 37;
            this.labelDateEnd.Text = "Дата окончания";
            // 
            // dateTimePickerBeg
            // 
            this.dateTimePickerBeg.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsPoint, "tPoint.DateBegin", true));
            this.dateTimePickerBeg.Location = new System.Drawing.Point(11, 21);
            this.dateTimePickerBeg.Name = "dateTimePickerBeg";
            this.dateTimePickerBeg.Size = new System.Drawing.Size(138, 20);
            this.dateTimePickerBeg.TabIndex = 36;
            // 
            // labelDateBeg
            // 
            this.labelDateBeg.AutoSize = true;
            this.labelDateBeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateBeg.Location = new System.Drawing.Point(16, 5);
            this.labelDateBeg.Name = "labelDateBeg";
            this.labelDateBeg.Size = new System.Drawing.Size(82, 13);
            this.labelDateBeg.TabIndex = 35;
            this.labelDateBeg.Text = "Дата начала";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLocation.Location = new System.Drawing.Point(344, 4);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(94, 13);
            this.labelLocation.TabIndex = 39;
            this.labelLocation.Text = "Расположение";
            // 
            // bsTypeMeter
            // 
            this.bsTypeMeter.DataMember = "tR_Classifier";
            this.bsTypeMeter.DataSource = this.dsPoint;
            // 
            // bsMasterUst
            // 
            this.bsMasterUst.DataMember = "vWorkerGroup";
            this.bsMasterUst.DataSource = this.dsPoint;
            // 
            // bsMasterDem
            // 
            this.bsMasterDem.DataMember = "vWorkerGroup";
            this.bsMasterDem.DataSource = this.dsPoint;
            // 
            // bsTransMasterUst
            // 
            this.bsTransMasterUst.DataMember = "vWorkerGroup";
            this.bsTransMasterUst.DataSource = this.dsPoint;
            // 
            // bsTransMasterDem
            // 
            this.bsTransMasterDem.DataMember = "vWorkerGroup";
            this.bsTransMasterDem.DataSource = this.dsPoint;
            // 
            // tpTime
            // 
            this.tpTime.Controls.Add(this.dgvZoneIndicator);
            this.tpTime.Controls.Add(this.cmbZone);
            this.tpTime.Controls.Add(this.label5);
            this.tpTime.Location = new System.Drawing.Point(4, 22);
            this.tpTime.Name = "tpTime";
            this.tpTime.Padding = new System.Windows.Forms.Padding(3);
            this.tpTime.Size = new System.Drawing.Size(655, 308);
            this.tpTime.TabIndex = 2;
            this.tpTime.Text = "Временные зоны";
            this.tpTime.UseVisualStyleBackColor = true;
            // 
            // dgvZoneIndicator
            // 
            this.dgvZoneIndicator.AllowUserToAddRows = false;
            this.dgvZoneIndicator.AllowUserToDeleteRows = false;
            this.dgvZoneIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZoneIndicator.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvZoneIndicator.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvZoneIndicator.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvZoneIndicator.Location = new System.Drawing.Point(1, 27);
            this.dgvZoneIndicator.Name = "dgvZoneIndicator";
            this.dgvZoneIndicator.RowHeadersVisible = false;
            this.dgvZoneIndicator.Size = new System.Drawing.Size(417, 278);
            this.dgvZoneIndicator.TabIndex = 5;
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
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ColumnName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 80;
            // 
            // ColumnTime
            // 
            this.ColumnTime.DataPropertyName = "Time";
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ColumnTime.DefaultCellStyle = dataGridViewCellStyle3;
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
            // cmbZone
            // 
            this.cmbZone.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPoint, "tPointReg.IdZone", true));
            this.cmbZone.DataSource = this.dsZone;
            this.cmbZone.DisplayMember = "tr_Classifier.Name";
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(108, 5);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(280, 21);
            this.cmbZone.TabIndex = 4;
            this.cmbZone.ValueMember = "tr_Classifier.Id";
            this.cmbZone.SelectedIndexChanged += new System.EventHandler(this.cmbZone_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Временная зона";
            // 
            // tpMeter
            // 
            this.tpMeter.Controls.Add(this.gbTrans);
            this.tpMeter.Controls.Add(this.gbMeter);
            this.tpMeter.Location = new System.Drawing.Point(4, 22);
            this.tpMeter.Name = "tpMeter";
            this.tpMeter.Padding = new System.Windows.Forms.Padding(3);
            this.tpMeter.Size = new System.Drawing.Size(655, 308);
            this.tpMeter.TabIndex = 0;
            this.tpMeter.Text = "Реквизиты";
            this.tpMeter.UseVisualStyleBackColor = true;
            // 
            // gbTrans
            // 
            this.gbTrans.Controls.Add(this.cmbMarkTrans1);
            this.gbTrans.Controls.Add(this.richTextBoxTransComment);
            this.gbTrans.Controls.Add(this.label14);
            this.gbTrans.Controls.Add(this.cmbTransMasterDem);
            this.gbTrans.Controls.Add(this.label6);
            this.gbTrans.Controls.Add(this.cmbTransMasterUst);
            this.gbTrans.Controls.Add(this.label7);
            this.gbTrans.Controls.Add(this.dateTimePickerTransdateDem);
            this.gbTrans.Controls.Add(this.labelTransDateDem);
            this.gbTrans.Controls.Add(this.dateTimePickerTransDateUst);
            this.gbTrans.Controls.Add(this.labelTransDateUst);
            this.gbTrans.Controls.Add(this.cmbTransCheckYear);
            this.gbTrans.Controls.Add(this.cmbTransCheckKvartal);
            this.gbTrans.Controls.Add(this.labelTransCheckDate);
            this.gbTrans.Controls.Add(this.txtTransNumber);
            this.gbTrans.Controls.Add(this.labelNumberTrans);
            this.gbTrans.Controls.Add(this.dateTimePickerTransDateMade);
            this.gbTrans.Controls.Add(this.labelTransDateMade);
            this.gbTrans.Controls.Add(this.labelMarkTrans);
            this.gbTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTrans.Location = new System.Drawing.Point(335, 3);
            this.gbTrans.Name = "gbTrans";
            this.gbTrans.Size = new System.Drawing.Size(311, 302);
            this.gbTrans.TabIndex = 39;
            this.gbTrans.TabStop = false;
            this.gbTrans.Text = "Трансформатор";
            // 
            // cmbMarkTrans1
            // 
            this.cmbMarkTrans1.AutoComplete = true;
            this.cmbMarkTrans1.AutoDropdown = true;
            this.cmbMarkTrans1.BackColorEven = System.Drawing.Color.White;
            this.cmbMarkTrans1.BackColorOdd = System.Drawing.Color.White;
            this.cmbMarkTrans1.ColumnNames = "";
            this.cmbMarkTrans1.ColumnWidthDefault = 75;
            this.cmbMarkTrans1.ColumnWidths = "0;75;25;25;30;25;25;0";
            this.cmbMarkTrans1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMarkTrans1.FormattingEnabled = true;
            this.cmbMarkTrans1.LinkedColumnIndex = 0;
            this.cmbMarkTrans1.LinkedTextBox = null;
            this.cmbMarkTrans1.Location = new System.Drawing.Point(9, 30);
            this.cmbMarkTrans1.Name = "cmbMarkTrans1";
            this.cmbMarkTrans1.Size = new System.Drawing.Size(144, 21);
            this.cmbMarkTrans1.TabIndex = 74;
            this.cmbMarkTrans1.SelectedIndexChanged += new System.EventHandler(this.cmbMarkTrans1_SelectedIndexChanged);
            this.cmbMarkTrans1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbMarkTrans1_MouseDown);
            // 
            // richTextBoxTransComment
            // 
            this.richTextBoxTransComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTransComment.Location = new System.Drawing.Point(3, 204);
            this.richTextBoxTransComment.Name = "richTextBoxTransComment";
            this.richTextBoxTransComment.Size = new System.Drawing.Size(298, 95);
            this.richTextBoxTransComment.TabIndex = 73;
            this.richTextBoxTransComment.Text = "";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 72;
            this.label14.Text = "Комментарий";
            // 
            // cmbTransMasterDem
            // 
            this.cmbTransMasterDem.DataSource = this.bsTransMasterDem;
            this.cmbTransMasterDem.DisplayMember = "FIO";
            this.cmbTransMasterDem.FormattingEnabled = true;
            this.cmbTransMasterDem.Location = new System.Drawing.Point(157, 149);
            this.cmbTransMasterDem.Name = "cmbTransMasterDem";
            this.cmbTransMasterDem.Size = new System.Drawing.Size(144, 21);
            this.cmbTransMasterDem.TabIndex = 71;
            this.cmbTransMasterDem.ValueMember = "id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(154, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Мастер";
            // 
            // cmbTransMasterUst
            // 
            this.cmbTransMasterUst.DataSource = this.bsTransMasterUst;
            this.cmbTransMasterUst.DisplayMember = "FIO";
            this.cmbTransMasterUst.FormattingEnabled = true;
            this.cmbTransMasterUst.Location = new System.Drawing.Point(9, 149);
            this.cmbTransMasterUst.Name = "cmbTransMasterUst";
            this.cmbTransMasterUst.Size = new System.Drawing.Size(144, 21);
            this.cmbTransMasterUst.TabIndex = 69;
            this.cmbTransMasterUst.ValueMember = "id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "Мастер";
            // 
            // dateTimePickerTransdateDem
            // 
            this.dateTimePickerTransdateDem.Location = new System.Drawing.Point(157, 110);
            this.dateTimePickerTransdateDem.Name = "dateTimePickerTransdateDem";
            this.dateTimePickerTransdateDem.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerTransdateDem.TabIndex = 67;
            this.dateTimePickerTransdateDem.Value = new System.DateTime(2010, 11, 6, 11, 33, 27, 788);
            // 
            // labelTransDateDem
            // 
            this.labelTransDateDem.AutoSize = true;
            this.labelTransDateDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTransDateDem.Location = new System.Drawing.Point(154, 94);
            this.labelTransDateDem.Name = "labelTransDateDem";
            this.labelTransDateDem.Size = new System.Drawing.Size(93, 13);
            this.labelTransDateDem.TabIndex = 66;
            this.labelTransDateDem.Text = "Дата демонтажа";
            // 
            // dateTimePickerTransDateUst
            // 
            this.dateTimePickerTransDateUst.Location = new System.Drawing.Point(9, 110);
            this.dateTimePickerTransDateUst.Name = "dateTimePickerTransDateUst";
            this.dateTimePickerTransDateUst.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerTransDateUst.TabIndex = 65;
            this.dateTimePickerTransDateUst.Value = new System.DateTime(2010, 11, 11, 8, 44, 10, 0);
            // 
            // labelTransDateUst
            // 
            this.labelTransDateUst.AutoSize = true;
            this.labelTransDateUst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTransDateUst.Location = new System.Drawing.Point(6, 94);
            this.labelTransDateUst.Name = "labelTransDateUst";
            this.labelTransDateUst.Size = new System.Drawing.Size(88, 13);
            this.labelTransDateUst.TabIndex = 64;
            this.labelTransDateUst.Text = "Дата установки";
            // 
            // cmbTransCheckYear
            // 
            this.cmbTransCheckYear.FormattingEnabled = true;
            this.cmbTransCheckYear.Location = new System.Drawing.Point(209, 70);
            this.cmbTransCheckYear.Name = "cmbTransCheckYear";
            this.cmbTransCheckYear.Size = new System.Drawing.Size(92, 21);
            this.cmbTransCheckYear.TabIndex = 63;
            // 
            // cmbTransCheckKvartal
            // 
            this.cmbTransCheckKvartal.FormattingEnabled = true;
            this.cmbTransCheckKvartal.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cmbTransCheckKvartal.Location = new System.Drawing.Point(157, 70);
            this.cmbTransCheckKvartal.Name = "cmbTransCheckKvartal";
            this.cmbTransCheckKvartal.Size = new System.Drawing.Size(54, 21);
            this.cmbTransCheckKvartal.TabIndex = 62;
            // 
            // labelTransCheckDate
            // 
            this.labelTransCheckDate.AutoSize = true;
            this.labelTransCheckDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTransCheckDate.Location = new System.Drawing.Point(154, 55);
            this.labelTransCheckDate.Name = "labelTransCheckDate";
            this.labelTransCheckDate.Size = new System.Drawing.Size(95, 13);
            this.labelTransCheckDate.TabIndex = 61;
            this.labelTransCheckDate.Text = "Дата госповерки";
            // 
            // txtTransNumber
            // 
            this.txtTransNumber.Location = new System.Drawing.Point(9, 71);
            this.txtTransNumber.Name = "txtTransNumber";
            this.txtTransNumber.Size = new System.Drawing.Size(144, 20);
            this.txtTransNumber.TabIndex = 60;
            // 
            // labelNumberTrans
            // 
            this.labelNumberTrans.AutoSize = true;
            this.labelNumberTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberTrans.Location = new System.Drawing.Point(6, 55);
            this.labelNumberTrans.Name = "labelNumberTrans";
            this.labelNumberTrans.Size = new System.Drawing.Size(97, 13);
            this.labelNumberTrans.TabIndex = 59;
            this.labelNumberTrans.Text = "Заводской номер";
            // 
            // dateTimePickerTransDateMade
            // 
            this.dateTimePickerTransDateMade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTransDateMade.Location = new System.Drawing.Point(157, 31);
            this.dateTimePickerTransDateMade.Name = "dateTimePickerTransDateMade";
            this.dateTimePickerTransDateMade.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerTransDateMade.TabIndex = 58;
            this.dateTimePickerTransDateMade.Value = new System.DateTime(2010, 11, 8, 11, 2, 17, 129);
            // 
            // labelTransDateMade
            // 
            this.labelTransDateMade.AutoSize = true;
            this.labelTransDateMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTransDateMade.Location = new System.Drawing.Point(154, 15);
            this.labelTransDateMade.Name = "labelTransDateMade";
            this.labelTransDateMade.Size = new System.Drawing.Size(107, 13);
            this.labelTransDateMade.TabIndex = 57;
            this.labelTransDateMade.Text = "Дата производства";
            // 
            // labelMarkTrans
            // 
            this.labelMarkTrans.AutoSize = true;
            this.labelMarkTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMarkTrans.Location = new System.Drawing.Point(6, 15);
            this.labelMarkTrans.Name = "labelMarkTrans";
            this.labelMarkTrans.Size = new System.Drawing.Size(40, 13);
            this.labelMarkTrans.TabIndex = 55;
            this.labelMarkTrans.Text = "Марка";
            // 
            // gbMeter
            // 
            this.gbMeter.Controls.Add(this.btnMeterParameters_Log);
            this.gbMeter.Controls.Add(this.txtActDemontag);
            this.gbMeter.Controls.Add(this.txtActUstanov);
            this.gbMeter.Controls.Add(this.label8);
            this.gbMeter.Controls.Add(this.label1);
            this.gbMeter.Controls.Add(this.cmbMarkMeter1);
            this.gbMeter.Controls.Add(this.nudTRK);
            this.gbMeter.Controls.Add(this.dateTimePickerDateDem);
            this.gbMeter.Controls.Add(this.richTextBoxComment);
            this.gbMeter.Controls.Add(this.cmbWorkerDem);
            this.gbMeter.Controls.Add(this.label3);
            this.gbMeter.Controls.Add(this.cmbWorkerUst);
            this.gbMeter.Controls.Add(this.label2);
            this.gbMeter.Controls.Add(this.labelDateDem);
            this.gbMeter.Controls.Add(this.dateTimePickerDateUst);
            this.gbMeter.Controls.Add(this.labelDateUst);
            this.gbMeter.Controls.Add(this.cmbMeterCheckYear);
            this.gbMeter.Controls.Add(this.cmbMeterCheckKvartal);
            this.gbMeter.Controls.Add(this.labelDateCheck);
            this.gbMeter.Controls.Add(this.txtNumberMeter);
            this.gbMeter.Controls.Add(this.labelNumber);
            this.gbMeter.Controls.Add(this.dateTimePickerDateMade);
            this.gbMeter.Controls.Add(this.labelDateMade);
            this.gbMeter.Controls.Add(this.labelMarkMeter);
            this.gbMeter.Controls.Add(this.labelTRK);
            this.gbMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMeter.Location = new System.Drawing.Point(6, 3);
            this.gbMeter.Name = "gbMeter";
            this.gbMeter.Size = new System.Drawing.Size(323, 302);
            this.gbMeter.TabIndex = 38;
            this.gbMeter.TabStop = false;
            this.gbMeter.Text = "Счетчик";
            // 
            // txtActDemontag
            // 
            this.txtActDemontag.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPoint, "tPointReg.ActDemontag", true));
            this.txtActDemontag.Location = new System.Drawing.Point(157, 149);
            this.txtActDemontag.Name = "txtActDemontag";
            this.txtActDemontag.Size = new System.Drawing.Size(145, 20);
            this.txtActDemontag.TabIndex = 45;
            // 
            // txtActUstanov
            // 
            this.txtActUstanov.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPoint, "tPointReg.ActUstanov", true));
            this.txtActUstanov.Location = new System.Drawing.Point(6, 150);
            this.txtActUstanov.Name = "txtActUstanov";
            this.txtActUstanov.Size = new System.Drawing.Size(144, 20);
            this.txtActUstanov.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(154, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "Акт демонтажа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Акт установки";
            // 
            // cmbMarkMeter1
            // 
            this.cmbMarkMeter1.AutoComplete = true;
            this.cmbMarkMeter1.AutoDropdown = false;
            this.cmbMarkMeter1.BackColorEven = System.Drawing.Color.White;
            this.cmbMarkMeter1.BackColorOdd = System.Drawing.Color.White;
            this.cmbMarkMeter1.ColumnNames = "";
            this.cmbMarkMeter1.ColumnWidthDefault = 75;
            this.cmbMarkMeter1.ColumnWidths = "0;150;25;25;30;25;0;0;0;0;0";
            this.cmbMarkMeter1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMarkMeter1.DropDownWidth = 300;
            this.cmbMarkMeter1.FormattingEnabled = true;
            this.cmbMarkMeter1.LinkedColumnIndex = 0;
            this.cmbMarkMeter1.LinkedTextBox = null;
            this.cmbMarkMeter1.Location = new System.Drawing.Point(6, 30);
            this.cmbMarkMeter1.Name = "cmbMarkMeter1";
            this.cmbMarkMeter1.Size = new System.Drawing.Size(144, 21);
            this.cmbMarkMeter1.TabIndex = 41;
            this.cmbMarkMeter1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cmbMarkMeter1_MouseDown);
            // 
            // nudTRK
            // 
            this.nudTRK.Location = new System.Drawing.Point(245, 219);
            this.nudTRK.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTRK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTRK.Name = "nudTRK";
            this.nudTRK.Size = new System.Drawing.Size(58, 20);
            this.nudTRK.TabIndex = 39;
            this.nudTRK.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePickerDateDem
            // 
            this.dateTimePickerDateDem.Location = new System.Drawing.Point(157, 110);
            this.dateTimePickerDateDem.Name = "dateTimePickerDateDem";
            this.dateTimePickerDateDem.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerDateDem.TabIndex = 38;
            this.dateTimePickerDateDem.Value = new System.DateTime(2011, 5, 4, 9, 31, 6, 306);
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPoint, "tPointReg.Comment", true));
            this.richTextBoxComment.Location = new System.Drawing.Point(3, 245);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(297, 57);
            this.richTextBoxComment.TabIndex = 37;
            this.richTextBoxComment.Text = "";
            // 
            // cmbWorkerDem
            // 
            this.cmbWorkerDem.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPoint, "tPointReg.idWorkerEnd", true));
            this.cmbWorkerDem.DataSource = this.bsMasterDem;
            this.cmbWorkerDem.DisplayMember = "FIO";
            this.cmbWorkerDem.FormattingEnabled = true;
            this.cmbWorkerDem.Location = new System.Drawing.Point(156, 188);
            this.cmbWorkerDem.Name = "cmbWorkerDem";
            this.cmbWorkerDem.Size = new System.Drawing.Size(146, 21);
            this.cmbWorkerDem.TabIndex = 35;
            this.cmbWorkerDem.ValueMember = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(153, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Мастер";
            // 
            // cmbWorkerUst
            // 
            this.cmbWorkerUst.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPoint, "tPointReg.idWorkerBegin", true));
            this.cmbWorkerUst.DataSource = this.bsMasterUst;
            this.cmbWorkerUst.DisplayMember = "FIO";
            this.cmbWorkerUst.FormattingEnabled = true;
            this.cmbWorkerUst.Location = new System.Drawing.Point(6, 188);
            this.cmbWorkerUst.Name = "cmbWorkerUst";
            this.cmbWorkerUst.Size = new System.Drawing.Size(144, 21);
            this.cmbWorkerUst.TabIndex = 33;
            this.cmbWorkerUst.ValueMember = "id";
            this.cmbWorkerUst.SelectedIndexChanged += new System.EventHandler(this.cmbWorkerUst_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Мастер";
            // 
            // labelDateDem
            // 
            this.labelDateDem.AutoSize = true;
            this.labelDateDem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateDem.Location = new System.Drawing.Point(153, 94);
            this.labelDateDem.Name = "labelDateDem";
            this.labelDateDem.Size = new System.Drawing.Size(93, 13);
            this.labelDateDem.TabIndex = 30;
            this.labelDateDem.Text = "Дата демонтажа";
            // 
            // dateTimePickerDateUst
            // 
            this.dateTimePickerDateUst.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsPoint, "tPointReg.DateBegin", true));
            this.dateTimePickerDateUst.Location = new System.Drawing.Point(6, 110);
            this.dateTimePickerDateUst.Name = "dateTimePickerDateUst";
            this.dateTimePickerDateUst.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerDateUst.TabIndex = 29;
            this.dateTimePickerDateUst.Value = new System.DateTime(2010, 11, 11, 0, 0, 0, 0);
            // 
            // labelDateUst
            // 
            this.labelDateUst.AutoSize = true;
            this.labelDateUst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateUst.Location = new System.Drawing.Point(3, 94);
            this.labelDateUst.Name = "labelDateUst";
            this.labelDateUst.Size = new System.Drawing.Size(88, 13);
            this.labelDateUst.TabIndex = 28;
            this.labelDateUst.Text = "Дата установки";
            // 
            // cmbMeterCheckYear
            // 
            this.cmbMeterCheckYear.FormattingEnabled = true;
            this.cmbMeterCheckYear.Location = new System.Drawing.Point(208, 70);
            this.cmbMeterCheckYear.Name = "cmbMeterCheckYear";
            this.cmbMeterCheckYear.Size = new System.Drawing.Size(92, 21);
            this.cmbMeterCheckYear.TabIndex = 27;
            // 
            // cmbMeterCheckKvartal
            // 
            this.cmbMeterCheckKvartal.FormattingEnabled = true;
            this.cmbMeterCheckKvartal.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV"});
            this.cmbMeterCheckKvartal.Location = new System.Drawing.Point(156, 70);
            this.cmbMeterCheckKvartal.Name = "cmbMeterCheckKvartal";
            this.cmbMeterCheckKvartal.Size = new System.Drawing.Size(54, 21);
            this.cmbMeterCheckKvartal.TabIndex = 26;
            // 
            // labelDateCheck
            // 
            this.labelDateCheck.AutoSize = true;
            this.labelDateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateCheck.Location = new System.Drawing.Point(153, 54);
            this.labelDateCheck.Name = "labelDateCheck";
            this.labelDateCheck.Size = new System.Drawing.Size(95, 13);
            this.labelDateCheck.TabIndex = 25;
            this.labelDateCheck.Text = "Дата госповерки";
            // 
            // txtNumberMeter
            // 
            this.txtNumberMeter.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPoint, "tPointReg.Number", true));
            this.txtNumberMeter.Location = new System.Drawing.Point(6, 71);
            this.txtNumberMeter.Name = "txtNumberMeter";
            this.txtNumberMeter.Size = new System.Drawing.Size(144, 20);
            this.txtNumberMeter.TabIndex = 24;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber.Location = new System.Drawing.Point(3, 55);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(97, 13);
            this.labelNumber.TabIndex = 23;
            this.labelNumber.Text = "Заводской номер";
            // 
            // dateTimePickerDateMade
            // 
            this.dateTimePickerDateMade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsPoint, "tPointReg.DateMade", true));
            this.dateTimePickerDateMade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateMade.Location = new System.Drawing.Point(156, 31);
            this.dateTimePickerDateMade.Name = "dateTimePickerDateMade";
            this.dateTimePickerDateMade.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerDateMade.TabIndex = 22;
            this.dateTimePickerDateMade.Value = new System.DateTime(2010, 11, 8, 11, 2, 17, 129);
            // 
            // labelDateMade
            // 
            this.labelDateMade.AutoSize = true;
            this.labelDateMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateMade.Location = new System.Drawing.Point(153, 15);
            this.labelDateMade.Name = "labelDateMade";
            this.labelDateMade.Size = new System.Drawing.Size(107, 13);
            this.labelDateMade.TabIndex = 21;
            this.labelDateMade.Text = "Дата производства";
            // 
            // labelMarkMeter
            // 
            this.labelMarkMeter.AutoSize = true;
            this.labelMarkMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMarkMeter.Location = new System.Drawing.Point(3, 15);
            this.labelMarkMeter.Name = "labelMarkMeter";
            this.labelMarkMeter.Size = new System.Drawing.Size(40, 13);
            this.labelMarkMeter.TabIndex = 19;
            this.labelMarkMeter.Text = "Марка";
            // 
            // labelTRK
            // 
            this.labelTRK.AutoSize = true;
            this.labelTRK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTRK.Location = new System.Drawing.Point(131, 219);
            this.labelTRK.Name = "labelTRK";
            this.labelTRK.Size = new System.Drawing.Size(108, 13);
            this.labelTRK.TabIndex = 40;
            this.labelTRK.Text = "Коэфф. трансформ.";
            // 
            // tcMeter
            // 
            this.tcMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMeter.Controls.Add(this.tpMeter);
            this.tcMeter.Controls.Add(this.tpTime);
            this.tcMeter.Location = new System.Drawing.Point(5, 202);
            this.tcMeter.Name = "tcMeter";
            this.tcMeter.SelectedIndex = 0;
            this.tcMeter.Size = new System.Drawing.Size(663, 334);
            this.tcMeter.TabIndex = 32;
            // 
            // dgvObjMeter
            // 
            this.dgvObjMeter.AllowUserToAddRows = false;
            this.dgvObjMeter.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvObjMeter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvObjMeter.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjMeter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvObjMeter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjMeter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMeterRegDGVTBC,
            this.idpointDataGridViewTextBoxColumn,
            this.datebeginMeterDGVTBC,
            this.dateendMeterDGVTBC,
            this.typeDataGridViewTextBoxColumn,
            this.typenameDataGridViewTextBoxColumn,
            this.idMarkMeterDGVTBC,
            this.currentPointDataGridViewTextBoxColumn,
            this.idworkerbeginMeterDGVTBC,
            this.idWorkerEndMeterDGVTBC,
            this.workerBeginDataGridViewTextBoxColumn,
            this.workerEndMeterDGVTBC,
            this.datemadeMeterDGVTBC,
            this.datecheckMeterDGVTBC,
            this.numberMeterDGVTBC,
            this.idzone,
            this.Digit,
            this.zoneDataGridViewTextBoxColumn,
            this.commentMeterDGVTBC,
            this.TR_K,
            this.ActUstanov,
            this.ActDemontag});
            this.dgvObjMeter.DataSource = this.bsMeter;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjMeter.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvObjMeter.Location = new System.Drawing.Point(5, 65);
            this.dgvObjMeter.Name = "dgvObjMeter";
            this.dgvObjMeter.ReadOnly = true;
            this.dgvObjMeter.RowHeadersWidth = 5;
            this.dgvObjMeter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvObjMeter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjMeter.Size = new System.Drawing.Size(333, 131);
            this.dgvObjMeter.TabIndex = 5;
            this.dgvObjMeter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjMeter_CellClick);
            // 
            // idMeterRegDGVTBC
            // 
            this.idMeterRegDGVTBC.DataPropertyName = "id";
            this.idMeterRegDGVTBC.HeaderText = "id";
            this.idMeterRegDGVTBC.Name = "idMeterRegDGVTBC";
            this.idMeterRegDGVTBC.ReadOnly = true;
            this.idMeterRegDGVTBC.Visible = false;
            // 
            // idpointDataGridViewTextBoxColumn
            // 
            this.idpointDataGridViewTextBoxColumn.DataPropertyName = "idpoint";
            this.idpointDataGridViewTextBoxColumn.HeaderText = "idpoint";
            this.idpointDataGridViewTextBoxColumn.Name = "idpointDataGridViewTextBoxColumn";
            this.idpointDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpointDataGridViewTextBoxColumn.Visible = false;
            // 
            // datebeginMeterDGVTBC
            // 
            this.datebeginMeterDGVTBC.DataPropertyName = "datebegin";
            this.datebeginMeterDGVTBC.HeaderText = "Уст.";
            this.datebeginMeterDGVTBC.Name = "datebeginMeterDGVTBC";
            this.datebeginMeterDGVTBC.ReadOnly = true;
            this.datebeginMeterDGVTBC.Width = 65;
            // 
            // dateendMeterDGVTBC
            // 
            this.dateendMeterDGVTBC.DataPropertyName = "dateend";
            this.dateendMeterDGVTBC.HeaderText = "Дем.";
            this.dateendMeterDGVTBC.Name = "dateendMeterDGVTBC";
            this.dateendMeterDGVTBC.ReadOnly = true;
            this.dateendMeterDGVTBC.Width = 65;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Visible = false;
            // 
            // typenameDataGridViewTextBoxColumn
            // 
            this.typenameDataGridViewTextBoxColumn.DataPropertyName = "typename";
            this.typenameDataGridViewTextBoxColumn.HeaderText = "typename";
            this.typenameDataGridViewTextBoxColumn.Name = "typenameDataGridViewTextBoxColumn";
            this.typenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typenameDataGridViewTextBoxColumn.Visible = false;
            // 
            // idMarkMeterDGVTBC
            // 
            this.idMarkMeterDGVTBC.DataPropertyName = "idMark";
            this.idMarkMeterDGVTBC.HeaderText = "idMark";
            this.idMarkMeterDGVTBC.Name = "idMarkMeterDGVTBC";
            this.idMarkMeterDGVTBC.ReadOnly = true;
            this.idMarkMeterDGVTBC.Visible = false;
            // 
            // currentPointDataGridViewTextBoxColumn
            // 
            this.currentPointDataGridViewTextBoxColumn.DataPropertyName = "CurrentPoint";
            this.currentPointDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.currentPointDataGridViewTextBoxColumn.Name = "currentPointDataGridViewTextBoxColumn";
            this.currentPointDataGridViewTextBoxColumn.ReadOnly = true;
            this.currentPointDataGridViewTextBoxColumn.Width = 120;
            // 
            // idworkerbeginMeterDGVTBC
            // 
            this.idworkerbeginMeterDGVTBC.DataPropertyName = "idworkerbegin";
            this.idworkerbeginMeterDGVTBC.HeaderText = "idworkerbegin";
            this.idworkerbeginMeterDGVTBC.Name = "idworkerbeginMeterDGVTBC";
            this.idworkerbeginMeterDGVTBC.ReadOnly = true;
            this.idworkerbeginMeterDGVTBC.Visible = false;
            // 
            // idWorkerEndMeterDGVTBC
            // 
            this.idWorkerEndMeterDGVTBC.DataPropertyName = "idWorkerEnd";
            this.idWorkerEndMeterDGVTBC.HeaderText = "idWorkerEnd";
            this.idWorkerEndMeterDGVTBC.Name = "idWorkerEndMeterDGVTBC";
            this.idWorkerEndMeterDGVTBC.ReadOnly = true;
            this.idWorkerEndMeterDGVTBC.Visible = false;
            // 
            // workerBeginDataGridViewTextBoxColumn
            // 
            this.workerBeginDataGridViewTextBoxColumn.DataPropertyName = "workerBegin";
            this.workerBeginDataGridViewTextBoxColumn.HeaderText = "workerBegin";
            this.workerBeginDataGridViewTextBoxColumn.Name = "workerBeginDataGridViewTextBoxColumn";
            this.workerBeginDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerBeginDataGridViewTextBoxColumn.Visible = false;
            // 
            // workerEndMeterDGVTBC
            // 
            this.workerEndMeterDGVTBC.DataPropertyName = "workerEnd";
            this.workerEndMeterDGVTBC.HeaderText = "workerEnd";
            this.workerEndMeterDGVTBC.Name = "workerEndMeterDGVTBC";
            this.workerEndMeterDGVTBC.ReadOnly = true;
            this.workerEndMeterDGVTBC.Visible = false;
            // 
            // datemadeMeterDGVTBC
            // 
            this.datemadeMeterDGVTBC.DataPropertyName = "datemade";
            this.datemadeMeterDGVTBC.HeaderText = "datemade";
            this.datemadeMeterDGVTBC.Name = "datemadeMeterDGVTBC";
            this.datemadeMeterDGVTBC.ReadOnly = true;
            this.datemadeMeterDGVTBC.Visible = false;
            // 
            // datecheckMeterDGVTBC
            // 
            this.datecheckMeterDGVTBC.DataPropertyName = "datecheck";
            this.datecheckMeterDGVTBC.HeaderText = "datecheck";
            this.datecheckMeterDGVTBC.Name = "datecheckMeterDGVTBC";
            this.datecheckMeterDGVTBC.ReadOnly = true;
            this.datecheckMeterDGVTBC.Visible = false;
            // 
            // numberMeterDGVTBC
            // 
            this.numberMeterDGVTBC.DataPropertyName = "number";
            this.numberMeterDGVTBC.HeaderText = "number";
            this.numberMeterDGVTBC.Name = "numberMeterDGVTBC";
            this.numberMeterDGVTBC.ReadOnly = true;
            this.numberMeterDGVTBC.Visible = false;
            // 
            // idzone
            // 
            this.idzone.DataPropertyName = "idzone";
            this.idzone.HeaderText = "idzone";
            this.idzone.Name = "idzone";
            this.idzone.ReadOnly = true;
            this.idzone.Visible = false;
            // 
            // Digit
            // 
            this.Digit.DataPropertyName = "Digit";
            this.Digit.HeaderText = "Р";
            this.Digit.Name = "Digit";
            this.Digit.ReadOnly = true;
            this.Digit.Width = 20;
            // 
            // zoneDataGridViewTextBoxColumn
            // 
            this.zoneDataGridViewTextBoxColumn.DataPropertyName = "zone";
            this.zoneDataGridViewTextBoxColumn.HeaderText = "Зона";
            this.zoneDataGridViewTextBoxColumn.Name = "zoneDataGridViewTextBoxColumn";
            this.zoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.zoneDataGridViewTextBoxColumn.Width = 50;
            // 
            // commentMeterDGVTBC
            // 
            this.commentMeterDGVTBC.DataPropertyName = "comment";
            this.commentMeterDGVTBC.HeaderText = "comment";
            this.commentMeterDGVTBC.Name = "commentMeterDGVTBC";
            this.commentMeterDGVTBC.ReadOnly = true;
            this.commentMeterDGVTBC.Visible = false;
            // 
            // TR_K
            // 
            this.TR_K.DataPropertyName = "TR_K";
            this.TR_K.HeaderText = "TR_K";
            this.TR_K.Name = "TR_K";
            this.TR_K.ReadOnly = true;
            this.TR_K.Visible = false;
            // 
            // ActUstanov
            // 
            this.ActUstanov.DataPropertyName = "ActUstanov";
            this.ActUstanov.HeaderText = "ActUstanov";
            this.ActUstanov.Name = "ActUstanov";
            this.ActUstanov.ReadOnly = true;
            this.ActUstanov.Visible = false;
            // 
            // ActDemontag
            // 
            this.ActDemontag.DataPropertyName = "ActDemontag";
            this.ActDemontag.HeaderText = "ActDemontag";
            this.ActDemontag.Name = "ActDemontag";
            this.ActDemontag.ReadOnly = true;
            this.ActDemontag.Visible = false;
            // 
            // bsMeter
            // 
            this.bsMeter.DataMember = "vPointReg";
            this.bsMeter.DataSource = this.dsPoint;
            this.bsMeter.Filter = "type=245";
            // 
            // bsTrans
            // 
            this.bsTrans.DataMember = "vPointReg";
            this.bsTrans.DataSource = this.dsPoint;
            this.bsTrans.Filter = "type=246";
            // 
            // dgvObjTrans
            // 
            this.dgvObjTrans.AllowUserToAddRows = false;
            this.dgvObjTrans.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvObjTrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvObjTrans.AutoGenerateColumns = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvObjTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTransDGVTBC,
            this.idpointDataGridViewTextBoxColumn1,
            this.datebeginTransDGVTBC,
            this.dateendTransDGVTBC,
            this.typeDataGridViewTextBoxColumn1,
            this.typenameDataGridViewTextBoxColumn1,
            this.idMarkTransDGVTBC,
            this.currentPointDataGridViewTextBoxColumn1,
            this.idworkerbeginTransDGVTBC,
            this.idWorkerEndTrans,
            this.workerBeginDataGridViewTextBoxColumn1,
            this.workerEndDataGridViewTextBoxColumn1,
            this.datemadeTransDGVTBC,
            this.datecheckTransDGVTBC,
            this.numberTransDGVTBC,
            this.idzoneDataGridViewTextBoxColumn1,
            this.zoneDataGridViewTextBoxColumn1,
            this.commentTransDGVTBC,
            this.Primary,
            this.Secondary});
            this.dgvObjTrans.DataSource = this.bsTrans;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjTrans.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvObjTrans.Location = new System.Drawing.Point(344, 65);
            this.dgvObjTrans.Name = "dgvObjTrans";
            this.dgvObjTrans.ReadOnly = true;
            this.dgvObjTrans.RowHeadersWidth = 5;
            this.dgvObjTrans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvObjTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjTrans.Size = new System.Drawing.Size(321, 131);
            this.dgvObjTrans.TabIndex = 42;
            this.dgvObjTrans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObjTrans_CellClick);
            // 
            // idTransDGVTBC
            // 
            this.idTransDGVTBC.DataPropertyName = "id";
            this.idTransDGVTBC.HeaderText = "id";
            this.idTransDGVTBC.Name = "idTransDGVTBC";
            this.idTransDGVTBC.ReadOnly = true;
            this.idTransDGVTBC.Visible = false;
            // 
            // idpointDataGridViewTextBoxColumn1
            // 
            this.idpointDataGridViewTextBoxColumn1.DataPropertyName = "idpoint";
            this.idpointDataGridViewTextBoxColumn1.HeaderText = "idpoint";
            this.idpointDataGridViewTextBoxColumn1.Name = "idpointDataGridViewTextBoxColumn1";
            this.idpointDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idpointDataGridViewTextBoxColumn1.Visible = false;
            // 
            // datebeginTransDGVTBC
            // 
            this.datebeginTransDGVTBC.DataPropertyName = "datebegin";
            this.datebeginTransDGVTBC.HeaderText = "Уст.";
            this.datebeginTransDGVTBC.Name = "datebeginTransDGVTBC";
            this.datebeginTransDGVTBC.ReadOnly = true;
            this.datebeginTransDGVTBC.Width = 65;
            // 
            // dateendTransDGVTBC
            // 
            this.dateendTransDGVTBC.DataPropertyName = "dateend";
            this.dateendTransDGVTBC.HeaderText = "Дем.";
            this.dateendTransDGVTBC.Name = "dateendTransDGVTBC";
            this.dateendTransDGVTBC.ReadOnly = true;
            this.dateendTransDGVTBC.Width = 65;
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            this.typeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // typenameDataGridViewTextBoxColumn1
            // 
            this.typenameDataGridViewTextBoxColumn1.DataPropertyName = "typename";
            this.typenameDataGridViewTextBoxColumn1.HeaderText = "typename";
            this.typenameDataGridViewTextBoxColumn1.Name = "typenameDataGridViewTextBoxColumn1";
            this.typenameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.typenameDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idMarkTransDGVTBC
            // 
            this.idMarkTransDGVTBC.DataPropertyName = "idMark";
            this.idMarkTransDGVTBC.HeaderText = "idMark";
            this.idMarkTransDGVTBC.Name = "idMarkTransDGVTBC";
            this.idMarkTransDGVTBC.ReadOnly = true;
            this.idMarkTransDGVTBC.Visible = false;
            // 
            // currentPointDataGridViewTextBoxColumn1
            // 
            this.currentPointDataGridViewTextBoxColumn1.DataPropertyName = "CurrentPoint";
            this.currentPointDataGridViewTextBoxColumn1.HeaderText = "Тип";
            this.currentPointDataGridViewTextBoxColumn1.Name = "currentPointDataGridViewTextBoxColumn1";
            this.currentPointDataGridViewTextBoxColumn1.ReadOnly = true;
            this.currentPointDataGridViewTextBoxColumn1.Width = 95;
            // 
            // idworkerbeginTransDGVTBC
            // 
            this.idworkerbeginTransDGVTBC.DataPropertyName = "idworkerbegin";
            this.idworkerbeginTransDGVTBC.HeaderText = "idworkerbegin";
            this.idworkerbeginTransDGVTBC.Name = "idworkerbeginTransDGVTBC";
            this.idworkerbeginTransDGVTBC.ReadOnly = true;
            this.idworkerbeginTransDGVTBC.Visible = false;
            // 
            // idWorkerEndTrans
            // 
            this.idWorkerEndTrans.DataPropertyName = "idWorkerEnd";
            this.idWorkerEndTrans.HeaderText = "idWorkerEnd";
            this.idWorkerEndTrans.Name = "idWorkerEndTrans";
            this.idWorkerEndTrans.ReadOnly = true;
            this.idWorkerEndTrans.Visible = false;
            // 
            // workerBeginDataGridViewTextBoxColumn1
            // 
            this.workerBeginDataGridViewTextBoxColumn1.DataPropertyName = "workerBegin";
            this.workerBeginDataGridViewTextBoxColumn1.HeaderText = "workerBegin";
            this.workerBeginDataGridViewTextBoxColumn1.Name = "workerBeginDataGridViewTextBoxColumn1";
            this.workerBeginDataGridViewTextBoxColumn1.ReadOnly = true;
            this.workerBeginDataGridViewTextBoxColumn1.Visible = false;
            // 
            // workerEndDataGridViewTextBoxColumn1
            // 
            this.workerEndDataGridViewTextBoxColumn1.DataPropertyName = "workerEnd";
            this.workerEndDataGridViewTextBoxColumn1.HeaderText = "workerEnd";
            this.workerEndDataGridViewTextBoxColumn1.Name = "workerEndDataGridViewTextBoxColumn1";
            this.workerEndDataGridViewTextBoxColumn1.ReadOnly = true;
            this.workerEndDataGridViewTextBoxColumn1.Visible = false;
            // 
            // datemadeTransDGVTBC
            // 
            this.datemadeTransDGVTBC.DataPropertyName = "datemade";
            this.datemadeTransDGVTBC.HeaderText = "datemade";
            this.datemadeTransDGVTBC.Name = "datemadeTransDGVTBC";
            this.datemadeTransDGVTBC.ReadOnly = true;
            this.datemadeTransDGVTBC.Visible = false;
            // 
            // datecheckTransDGVTBC
            // 
            this.datecheckTransDGVTBC.DataPropertyName = "datecheck";
            this.datecheckTransDGVTBC.HeaderText = "datecheck";
            this.datecheckTransDGVTBC.Name = "datecheckTransDGVTBC";
            this.datecheckTransDGVTBC.ReadOnly = true;
            this.datecheckTransDGVTBC.Visible = false;
            // 
            // numberTransDGVTBC
            // 
            this.numberTransDGVTBC.DataPropertyName = "number";
            this.numberTransDGVTBC.HeaderText = "number";
            this.numberTransDGVTBC.Name = "numberTransDGVTBC";
            this.numberTransDGVTBC.ReadOnly = true;
            this.numberTransDGVTBC.Visible = false;
            // 
            // idzoneDataGridViewTextBoxColumn1
            // 
            this.idzoneDataGridViewTextBoxColumn1.DataPropertyName = "idzone";
            this.idzoneDataGridViewTextBoxColumn1.HeaderText = "idzone";
            this.idzoneDataGridViewTextBoxColumn1.Name = "idzoneDataGridViewTextBoxColumn1";
            this.idzoneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idzoneDataGridViewTextBoxColumn1.Visible = false;
            // 
            // zoneDataGridViewTextBoxColumn1
            // 
            this.zoneDataGridViewTextBoxColumn1.DataPropertyName = "zone";
            this.zoneDataGridViewTextBoxColumn1.HeaderText = "Зона";
            this.zoneDataGridViewTextBoxColumn1.Name = "zoneDataGridViewTextBoxColumn1";
            this.zoneDataGridViewTextBoxColumn1.ReadOnly = true;
            this.zoneDataGridViewTextBoxColumn1.Visible = false;
            this.zoneDataGridViewTextBoxColumn1.Width = 50;
            // 
            // commentTransDGVTBC
            // 
            this.commentTransDGVTBC.DataPropertyName = "comment";
            this.commentTransDGVTBC.HeaderText = "comment";
            this.commentTransDGVTBC.Name = "commentTransDGVTBC";
            this.commentTransDGVTBC.ReadOnly = true;
            this.commentTransDGVTBC.Visible = false;
            // 
            // Primary
            // 
            this.Primary.DataPropertyName = "Primary";
            this.Primary.HeaderText = "I";
            this.Primary.Name = "Primary";
            this.Primary.ReadOnly = true;
            this.Primary.Width = 40;
            // 
            // Secondary
            // 
            this.Secondary.DataPropertyName = "Secondary";
            this.Secondary.HeaderText = "II";
            this.Secondary.Name = "Secondary";
            this.Secondary.ReadOnly = true;
            this.Secondary.Width = 40;
            // 
            // labelObjMeter
            // 
            this.labelObjMeter.AutoSize = true;
            this.labelObjMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObjMeter.Location = new System.Drawing.Point(15, 46);
            this.labelObjMeter.Name = "labelObjMeter";
            this.labelObjMeter.Size = new System.Drawing.Size(70, 16);
            this.labelObjMeter.TabIndex = 43;
            this.labelObjMeter.Text = "Счетчик";
            // 
            // labelObjTrans
            // 
            this.labelObjTrans.AutoSize = true;
            this.labelObjTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObjTrans.Location = new System.Drawing.Point(354, 46);
            this.labelObjTrans.Name = "labelObjTrans";
            this.labelObjTrans.Size = new System.Drawing.Size(128, 16);
            this.labelObjTrans.TabIndex = 44;
            this.labelObjTrans.Text = "Трансформатор";
            // 
            // groupBoxNewEdit
            // 
            this.groupBoxNewEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxNewEdit.Controls.Add(this.radioButtonNew);
            this.groupBoxNewEdit.Controls.Add(this.radioButtonEdit);
            this.groupBoxNewEdit.Location = new System.Drawing.Point(113, 535);
            this.groupBoxNewEdit.Name = "groupBoxNewEdit";
            this.groupBoxNewEdit.Size = new System.Drawing.Size(224, 37);
            this.groupBoxNewEdit.TabIndex = 45;
            this.groupBoxNewEdit.TabStop = false;
            // 
            // rbMeter
            // 
            this.rbMeter.AutoSize = true;
            this.rbMeter.Checked = true;
            this.rbMeter.Location = new System.Drawing.Point(19, 13);
            this.rbMeter.Name = "rbMeter";
            this.rbMeter.Size = new System.Drawing.Size(65, 17);
            this.rbMeter.TabIndex = 46;
            this.rbMeter.TabStop = true;
            this.rbMeter.Text = "Счетчик";
            this.rbMeter.UseVisualStyleBackColor = true;
            this.rbMeter.CheckedChanged += new System.EventHandler(this.rbMeter_CheckedChanged);
            // 
            // rbTrans
            // 
            this.rbTrans.AutoSize = true;
            this.rbTrans.Location = new System.Drawing.Point(98, 13);
            this.rbTrans.Name = "rbTrans";
            this.rbTrans.Size = new System.Drawing.Size(107, 17);
            this.rbTrans.TabIndex = 47;
            this.rbTrans.Text = "Трансформатор";
            this.rbTrans.UseVisualStyleBackColor = true;
            this.rbTrans.CheckedChanged += new System.EventHandler(this.rbTrans_CheckedChanged);
            // 
            // groupBoxMeterTrans
            // 
            this.groupBoxMeterTrans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMeterTrans.Controls.Add(this.rbTrans);
            this.groupBoxMeterTrans.Controls.Add(this.rbMeter);
            this.groupBoxMeterTrans.Location = new System.Drawing.Point(343, 535);
            this.groupBoxMeterTrans.Name = "groupBoxMeterTrans";
            this.groupBoxMeterTrans.Size = new System.Drawing.Size(219, 37);
            this.groupBoxMeterTrans.TabIndex = 48;
            this.groupBoxMeterTrans.TabStop = false;
            // 
            // buttonNewPoint
            // 
            this.buttonNewPoint.FlatAppearance.BorderSize = 0;
            this.buttonNewPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewPoint.Image = global::Legal.Properties.Resources._1304663065_Add;
            this.buttonNewPoint.Location = new System.Drawing.Point(606, 12);
            this.buttonNewPoint.Name = "buttonNewPoint";
            this.buttonNewPoint.Size = new System.Drawing.Size(30, 34);
            this.buttonNewPoint.TabIndex = 49;
            this.buttonNewPoint.UseVisualStyleBackColor = true;
            this.buttonNewPoint.Visible = false;
            this.buttonNewPoint.Click += new System.EventHandler(this.buttonNewPoint_Click);
            // 
            // buttonEditPoint
            // 
            this.buttonEditPoint.FlatAppearance.BorderSize = 0;
            this.buttonEditPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditPoint.Image = global::Legal.Properties.Resources._1304663141_Pen;
            this.buttonEditPoint.Location = new System.Drawing.Point(638, 12);
            this.buttonEditPoint.Name = "buttonEditPoint";
            this.buttonEditPoint.Size = new System.Drawing.Size(30, 34);
            this.buttonEditPoint.TabIndex = 50;
            this.buttonEditPoint.UseVisualStyleBackColor = true;
            this.buttonEditPoint.Click += new System.EventHandler(this.buttonEditPoint_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(155, 21);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(143, 20);
            this.dateTimePickerEnd.TabIndex = 51;
            this.dateTimePickerEnd.Value = new System.DateTime(2011, 8, 4, 9, 6, 47, 331);
            // 
            // NUDN
            // 
            this.NUDN.Location = new System.Drawing.Point(305, 21);
            this.NUDN.Name = "NUDN";
            this.NUDN.Size = new System.Drawing.Size(33, 20);
            this.NUDN.TabIndex = 52;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelN.Location = new System.Drawing.Point(305, 4);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(19, 13);
            this.labelN.TabIndex = 53;
            this.labelN.Text = "№";
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(347, 20);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.Size = new System.Drawing.Size(260, 21);
            this.rtbLocation.TabIndex = 59;
            this.rtbLocation.Text = "";
            // 
            // btnMeter_Restore
            // 
            this.btnMeter_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMeter_Restore.Image = global::Legal.Properties.Resources.undo_green;
            this.btnMeter_Restore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeter_Restore.Location = new System.Drawing.Point(217, 44);
            this.btnMeter_Restore.Name = "btnMeter_Restore";
            this.btnMeter_Restore.Size = new System.Drawing.Size(104, 20);
            this.btnMeter_Restore.TabIndex = 60;
            this.btnMeter_Restore.Text = "восстановить";
            this.btnMeter_Restore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMeter_Restore.UseVisualStyleBackColor = true;
            this.btnMeter_Restore.Click += new System.EventHandler(this.btnMeter_Restore_Click);
            // 
            // btnTrans_Restore
            // 
            this.btnTrans_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrans_Restore.Image = global::Legal.Properties.Resources.undo_green;
            this.btnTrans_Restore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrans_Restore.Location = new System.Drawing.Point(541, 46);
            this.btnTrans_Restore.Name = "btnTrans_Restore";
            this.btnTrans_Restore.Size = new System.Drawing.Size(104, 20);
            this.btnTrans_Restore.TabIndex = 61;
            this.btnTrans_Restore.Text = "восстановить";
            this.btnTrans_Restore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrans_Restore.UseVisualStyleBackColor = true;
            this.btnTrans_Restore.Click += new System.EventHandler(this.btnTrans_Restore_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnMeterParameters_Log
            // 
            this.btnMeterParameters_Log.Location = new System.Drawing.Point(6, 216);
            this.btnMeterParameters_Log.Name = "btnMeterParameters_Log";
            this.btnMeterParameters_Log.Size = new System.Drawing.Size(84, 23);
            this.btnMeterParameters_Log.TabIndex = 46;
            this.btnMeterParameters_Log.Text = "Протокол";
            this.toolTip1.SetToolTip(this.btnMeterParameters_Log, "Протокол изменений");
            this.btnMeterParameters_Log.UseVisualStyleBackColor = true;
            this.btnMeterParameters_Log.Click += new System.EventHandler(this.btnMeterParameters_Log_Click);
            // 
            // FormMeterAddEdit
            // 
            this.ClientSize = new System.Drawing.Size(671, 574);
            this.Controls.Add(this.btnTrans_Restore);
            this.Controls.Add(this.btnMeter_Restore);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.NUDN);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.buttonEditPoint);
            this.Controls.Add(this.buttonNewPoint);
            this.Controls.Add(this.groupBoxMeterTrans);
            this.Controls.Add(this.groupBoxNewEdit);
            this.Controls.Add(this.labelObjTrans);
            this.Controls.Add(this.labelObjMeter);
            this.Controls.Add(this.dgvObjTrans);
            this.Controls.Add(this.dgvObjMeter);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.dateTimePickerBeg);
            this.Controls.Add(this.labelDateBeg);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.tcMeter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMeterAddEdit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Приборы учета";
            this.Load += new System.EventHandler(this.FormMeterAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsObjMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsZone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableVr_Zone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTypeMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMasterUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMasterDem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransMasterUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransMasterDem)).EndInit();
            this.tpTime.ResumeLayout(false);
            this.tpTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZoneIndicator)).EndInit();
            this.tpMeter.ResumeLayout(false);
            this.gbTrans.ResumeLayout(false);
            this.gbTrans.PerformLayout();
            this.gbMeter.ResumeLayout(false);
            this.gbMeter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTRK)).EndInit();
            this.tcMeter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjTrans)).EndInit();
            this.groupBoxNewEdit.ResumeLayout(false);
            this.groupBoxNewEdit.PerformLayout();
            this.groupBoxMeterTrans.ResumeLayout(false);
            this.groupBoxMeterTrans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet.DataSetAbn dsPoint;
        private System.Windows.Forms.BindingSource bsObjMeter;
        private System.Windows.Forms.RadioButton radioButtonNew;
        private System.Windows.Forms.RadioButton radioButtonEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.BindingSource bsLocation;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeg;
        private System.Windows.Forms.Label labelDateBeg;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.BindingSource bsTypeMeter;
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
        private System.Windows.Forms.BindingSource bsMasterUst;
        private System.Windows.Forms.BindingSource bsMasterDem;
        private System.Windows.Forms.BindingSource bsTransMasterUst;
        private System.Windows.Forms.BindingSource bsTransMasterDem;
        private System.Windows.Forms.TabPage tpTime;
        private System.Windows.Forms.DataGridView dgvZoneIndicator;
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
        private System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpMeter;
        private System.Windows.Forms.GroupBox gbTrans;
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
        private System.Windows.Forms.Label labelMarkTrans;
        private System.Windows.Forms.GroupBox gbMeter;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.ComboBox cmbWorkerDem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbWorkerUst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDateDem;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateUst;
        private System.Windows.Forms.Label labelDateUst;
        private System.Windows.Forms.ComboBox cmbMeterCheckYear;
        private System.Windows.Forms.ComboBox cmbMeterCheckKvartal;
        private System.Windows.Forms.Label labelDateCheck;
        private System.Windows.Forms.TextBox txtNumberMeter;
        private System.Windows.Forms.Label labelNumber;
        private ControlsLbr.NullableDateTimePicker dateTimePickerDateMade;
        private System.Windows.Forms.Label labelDateMade;
        private System.Windows.Forms.Label labelMarkMeter;
        private System.Windows.Forms.TabControl tcMeter;
        private System.Windows.Forms.DataGridView dgvObjMeter;
        private System.Windows.Forms.BindingSource bsMeter;
        private System.Windows.Forms.BindingSource bsTrans;
        private System.Windows.Forms.DataGridView dgvObjTrans;
        private System.Windows.Forms.Label labelObjMeter;
        private System.Windows.Forms.Label labelObjTrans;
        private ControlsLbr.NullableDateTimePicker dateTimePickerDateDem;
        private System.Windows.Forms.GroupBox groupBoxNewEdit;
        private System.Windows.Forms.RadioButton rbMeter;
        private System.Windows.Forms.RadioButton rbTrans;
        private System.Windows.Forms.GroupBox groupBoxMeterTrans;
        private System.Windows.Forms.Button buttonNewPoint;
        private System.Windows.Forms.Button buttonEditPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTransDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpointDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebeginTransDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendTransDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarkTransDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentPointDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkerbeginTransDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerEndTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerBeginDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerEndDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datemadeTransDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecheckTransDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberTransDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentTransDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Primary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Secondary;
        private ControlsLbr.NullableDateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.NumericUpDown NUDN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Data.DataSet dsZone;
        private System.Windows.Forms.Label labelTRK;
        private System.Windows.Forms.NumericUpDown nudTRK;
        private Classes.MultiColumnComboBoxExt cmbMarkMeter1;
        private Classes.MultiColumnComboBoxExt cmbMarkTrans1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnMeter_Restore;
        private System.Windows.Forms.Button btnTrans_Restore;
        private System.Windows.Forms.TextBox txtActDemontag;
        private System.Windows.Forms.TextBox txtActUstanov;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMeterRegDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebeginMeterDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateendMeterDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarkMeterDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkerbeginMeterDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerEndMeterDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerEndMeterDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn datemadeMeterDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecheckMeterDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberMeterDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Digit;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentMeterDGVTBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TR_K;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActUstanov;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActDemontag;
        private System.Windows.Forms.Button btnMeterParameters_Log;

    }
}
