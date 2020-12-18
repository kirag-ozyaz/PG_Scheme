namespace Legal.Forms.Meter
{
    partial class FormLCnt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLCnt));
            this.txtMeterCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListMeter = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.ndogDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.consumerDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.objNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.meterTypeDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.digitDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.phazeDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.voltageDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.precisionDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.intervalDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.tarifCountDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.tariffDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.TR_K = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.DateBegin = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.F = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.DateCheck = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.DateEnd = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.F1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.locationDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.DogType = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.region = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCnt = new Legal.DataSet.dsCnt();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbStatus = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.txtCountRows = new System.Windows.Forms.ToolStripTextBox();
            this.btnReportCountMeter = new System.Windows.Forms.ToolStripButton();
            this.btnExportExcel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCnt)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMeterCount
            // 
            this.txtMeterCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMeterCount.Enabled = false;
            this.txtMeterCount.Location = new System.Drawing.Point(126, 537);
            this.txtMeterCount.Name = "txtMeterCount";
            this.txtMeterCount.Size = new System.Drawing.Size(100, 20);
            this.txtMeterCount.TabIndex = 2;
            this.txtMeterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Всего счетчиков";
            // 
            // dgvListMeter
            // 
            this.dgvListMeter.AllowUserToAddRows = false;
            this.dgvListMeter.AllowUserToDeleteRows = false;
            this.dgvListMeter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListMeter.AutoGenerateColumns = false;
            this.dgvListMeter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMeter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ndogDataGridViewTextBoxColumn,
            this.consumerDataGridViewTextBoxColumn,
            this.objNameDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.meterTypeDataGridViewTextBoxColumn,
            this.digitDataGridViewTextBoxColumn,
            this.phazeDataGridViewTextBoxColumn,
            this.voltageDataGridViewTextBoxColumn,
            this.precisionDataGridViewTextBoxColumn,
            this.intervalDataGridViewTextBoxColumn,
            this.tarifCountDataGridViewTextBoxColumn,
            this.tariffDataGridViewTextBoxColumn,
            this.TR_K,
            this.DateBegin,
            this.F,
            this.DateCheck,
            this.DateEnd,
            this.F1,
            this.locationDgvColumn,
            this.DogType,
            this.region});
            this.dgvListMeter.DataSource = this.bindingSource1;
            this.dgvListMeter.Location = new System.Drawing.Point(-1, 28);
            this.dgvListMeter.Name = "dgvListMeter";
            this.dgvListMeter.ReadOnly = true;
            this.dgvListMeter.RowHeadersWidth = 4;
            this.dgvListMeter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListMeter.Size = new System.Drawing.Size(985, 503);
            this.dgvListMeter.TabIndex = 4;
            this.dgvListMeter.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvListMeter_Paint);
            // 
            // ndogDataGridViewTextBoxColumn
            // 
            this.ndogDataGridViewTextBoxColumn.DataPropertyName = "Ndog";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ndogDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ndogDataGridViewTextBoxColumn.HeaderText = "№дог";
            this.ndogDataGridViewTextBoxColumn.Name = "ndogDataGridViewTextBoxColumn";
            this.ndogDataGridViewTextBoxColumn.ReadOnly = true;
            this.ndogDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ndogDataGridViewTextBoxColumn.Width = 50;
            // 
            // consumerDataGridViewTextBoxColumn
            // 
            this.consumerDataGridViewTextBoxColumn.DataPropertyName = "Consumer";
            this.consumerDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.consumerDataGridViewTextBoxColumn.Name = "consumerDataGridViewTextBoxColumn";
            this.consumerDataGridViewTextBoxColumn.ReadOnly = true;
            this.consumerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.consumerDataGridViewTextBoxColumn.Width = 200;
            // 
            // objNameDataGridViewTextBoxColumn
            // 
            this.objNameDataGridViewTextBoxColumn.DataPropertyName = "ObjName";
            this.objNameDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.objNameDataGridViewTextBoxColumn.Name = "objNameDataGridViewTextBoxColumn";
            this.objNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.objNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.objNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numberDataGridViewTextBoxColumn.Width = 150;
            // 
            // meterTypeDataGridViewTextBoxColumn
            // 
            this.meterTypeDataGridViewTextBoxColumn.DataPropertyName = "MeterType";
            this.meterTypeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.meterTypeDataGridViewTextBoxColumn.Name = "meterTypeDataGridViewTextBoxColumn";
            this.meterTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.meterTypeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // digitDataGridViewTextBoxColumn
            // 
            this.digitDataGridViewTextBoxColumn.DataPropertyName = "Digit";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.digitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.digitDataGridViewTextBoxColumn.HeaderText = "Разрядность";
            this.digitDataGridViewTextBoxColumn.Name = "digitDataGridViewTextBoxColumn";
            this.digitDataGridViewTextBoxColumn.ReadOnly = true;
            this.digitDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.digitDataGridViewTextBoxColumn.Width = 50;
            // 
            // phazeDataGridViewTextBoxColumn
            // 
            this.phazeDataGridViewTextBoxColumn.DataPropertyName = "Phaze";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.phazeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.phazeDataGridViewTextBoxColumn.HeaderText = "Фазность";
            this.phazeDataGridViewTextBoxColumn.Name = "phazeDataGridViewTextBoxColumn";
            this.phazeDataGridViewTextBoxColumn.ReadOnly = true;
            this.phazeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.phazeDataGridViewTextBoxColumn.Width = 50;
            // 
            // voltageDataGridViewTextBoxColumn
            // 
            this.voltageDataGridViewTextBoxColumn.DataPropertyName = "Voltage";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.voltageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.voltageDataGridViewTextBoxColumn.HeaderText = "Напряжение";
            this.voltageDataGridViewTextBoxColumn.Name = "voltageDataGridViewTextBoxColumn";
            this.voltageDataGridViewTextBoxColumn.ReadOnly = true;
            this.voltageDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.voltageDataGridViewTextBoxColumn.Width = 50;
            // 
            // precisionDataGridViewTextBoxColumn
            // 
            this.precisionDataGridViewTextBoxColumn.DataPropertyName = "Precision";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.precisionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.precisionDataGridViewTextBoxColumn.HeaderText = "Точность";
            this.precisionDataGridViewTextBoxColumn.Name = "precisionDataGridViewTextBoxColumn";
            this.precisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.precisionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.precisionDataGridViewTextBoxColumn.Width = 50;
            // 
            // intervalDataGridViewTextBoxColumn
            // 
            this.intervalDataGridViewTextBoxColumn.DataPropertyName = "Interval";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.intervalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.intervalDataGridViewTextBoxColumn.HeaderText = "Интервал";
            this.intervalDataGridViewTextBoxColumn.Name = "intervalDataGridViewTextBoxColumn";
            this.intervalDataGridViewTextBoxColumn.ReadOnly = true;
            this.intervalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.intervalDataGridViewTextBoxColumn.Width = 50;
            // 
            // tarifCountDataGridViewTextBoxColumn
            // 
            this.tarifCountDataGridViewTextBoxColumn.DataPropertyName = "TarifCount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.tarifCountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.tarifCountDataGridViewTextBoxColumn.HeaderText = "КолТариф";
            this.tarifCountDataGridViewTextBoxColumn.Name = "tarifCountDataGridViewTextBoxColumn";
            this.tarifCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarifCountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tarifCountDataGridViewTextBoxColumn.Width = 50;
            // 
            // tariffDataGridViewTextBoxColumn
            // 
            this.tariffDataGridViewTextBoxColumn.DataPropertyName = "Tariff";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.tariffDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.tariffDataGridViewTextBoxColumn.HeaderText = "Тарифная группа";
            this.tariffDataGridViewTextBoxColumn.Name = "tariffDataGridViewTextBoxColumn";
            this.tariffDataGridViewTextBoxColumn.ReadOnly = true;
            this.tariffDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tariffDataGridViewTextBoxColumn.Width = 200;
            // 
            // TR_K
            // 
            this.TR_K.DataPropertyName = "TR_K";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.TR_K.DefaultCellStyle = dataGridViewCellStyle9;
            this.TR_K.HeaderText = "КоэфТр";
            this.TR_K.Name = "TR_K";
            this.TR_K.ReadOnly = true;
            this.TR_K.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TR_K.Width = 75;
            // 
            // DateBegin
            // 
            this.DateBegin.DataPropertyName = "DateBegin";
            this.DateBegin.HeaderText = "ДатаУст";
            this.DateBegin.Name = "DateBegin";
            this.DateBegin.ReadOnly = true;
            this.DateBegin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateBegin.Width = 75;
            // 
            // F
            // 
            this.F.DataPropertyName = "F";
            this.F.HeaderText = "Установка";
            this.F.Name = "F";
            this.F.ReadOnly = true;
            this.F.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DateCheck
            // 
            this.DateCheck.DataPropertyName = "DateCheck";
            this.DateCheck.HeaderText = "ДатаПов";
            this.DateCheck.Name = "DateCheck";
            this.DateCheck.ReadOnly = true;
            this.DateCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateCheck.Width = 75;
            // 
            // DateEnd
            // 
            this.DateEnd.DataPropertyName = "DateEnd";
            this.DateEnd.HeaderText = "ДатаДемонт";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.ReadOnly = true;
            this.DateEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateEnd.Width = 75;
            // 
            // F1
            // 
            this.F1.DataPropertyName = "F1";
            this.F1.HeaderText = "Демонтаж";
            this.F1.Name = "F1";
            this.F1.ReadOnly = true;
            this.F1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // locationDgvColumn
            // 
            this.locationDgvColumn.DataPropertyName = "location";
            this.locationDgvColumn.HeaderText = "Расположение";
            this.locationDgvColumn.Name = "locationDgvColumn";
            this.locationDgvColumn.ReadOnly = true;
            // 
            // DogType
            // 
            this.DogType.DataPropertyName = "DogType";
            this.DogType.HeaderText = "Договор";
            this.DogType.Name = "DogType";
            this.DogType.ReadOnly = true;
            this.DogType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // region
            // 
            this.region.DataPropertyName = "region";
            this.region.HeaderText = "Район";
            this.region.Name = "region";
            this.region.ReadOnly = true;
            this.region.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bindingSource1
            // 
            this.bindingSource1.AllowNew = false;
            this.bindingSource1.DataMember = "vG_AbnObjMeter_New";
            this.bindingSource1.DataSource = this.dsCnt;
            // 
            // dsCnt
            // 
            this.dsCnt.DataSetName = "dsCnt";
            this.dsCnt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(880, 534);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbStatus,
            this.toolStripSeparator1,
            this.btnExcel,
            this.txtCountRows,
            this.btnReportCountMeter,
            this.btnExportExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(984, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbStatus
            // 
            this.cbStatus.Items.AddRange(new object[] {
            "действующие",
            "все установленные"});
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 25);
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExcel
            // 
            this.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(23, 22);
            this.btnExcel.Text = "Экспорт в Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtCountRows
            // 
            this.txtCountRows.Name = "txtCountRows";
            this.txtCountRows.Size = new System.Drawing.Size(100, 25);
            this.txtCountRows.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReportCountMeter
            // 
            this.btnReportCountMeter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnReportCountMeter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReportCountMeter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportCountMeter.Name = "btnReportCountMeter";
            this.btnReportCountMeter.Size = new System.Drawing.Size(23, 22);
            this.btnReportCountMeter.Text = "toolStripButton1";
            this.btnReportCountMeter.ToolTipText = "Точки учета по уровням напряжения";
            this.btnReportCountMeter.Click += new System.EventHandler(this.btnReportCountMeter_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportExcel.Image")));
            this.btnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(23, 22);
            this.btnExportExcel.Text = "Выгрузка в  Excel";
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // FormLCnt
            // 
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.dgvListMeter);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMeterCount);
            this.Name = "FormLCnt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Приборы учета";
            this.Load += new System.EventHandler(this.FormLCnt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCnt)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Legal.DataSet.dsCnt dsCnt;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox txtMeterCount;
        private System.Windows.Forms.Label label1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvListMeter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cbStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripTextBox txtCountRows;
        private System.Windows.Forms.ToolStripButton btnReportCountMeter;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn ndogDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn consumerDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn objNameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn numberDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn meterTypeDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn digitDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn phazeDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn voltageDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn precisionDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn intervalDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn tarifCountDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn tariffDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn TR_K;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn DateBegin;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn F;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn DateCheck;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn DateEnd;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn F1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn locationDgvColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn DogType;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn region;
        private System.Windows.Forms.ToolStripButton btnExportExcel;
    }
}
