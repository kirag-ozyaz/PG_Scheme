namespace Legal.Forms.Calculat
{
    partial class FormReportObjLink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportObjLink));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgv1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilterN();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.dsDop1 = new Legal.DataSet.dsDop();
            this.tsbExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbExcel2 = new System.Windows.Forms.ToolStripButton();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.codeAbonent = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.objNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.cPNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.cellCPNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.tPDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.TPCell = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dtPayDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnObj1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idSchmObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueKWT = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.SizeKWT = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.NumberMeter = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.MeterType = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Location = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.PointName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjParentName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.MeterDataBegin = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn();
            this.CheckMr = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn();
            this.CheckIntervalMr = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.NameTrans = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.TypeTrans = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.DateBeginTrans = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn();
            this.DateCheckTrans = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn();
            this.IntervalTrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDop1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(648, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 23);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnOK.Location = new System.Drawing.Point(648, 324);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(138, 23);
            this.btnOK.TabIndex = 63;
            this.btnOK.Text = "Сформировать";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgv1
            // 
            this.dgv1.AllowUserToAddRows = false;
            this.dgv1.AllowUserToDeleteRows = false;
            this.dgv1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv1.AutoGenerateColumns = false;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeAbonent,
            this.nameDataGridViewTextBoxColumn,
            this.objNameDataGridViewTextBoxColumn,
            this.cPNameDataGridViewTextBoxColumn,
            this.cellCPNameDataGridViewTextBoxColumn,
            this.tPDataGridViewTextBoxColumn,
            this.TPCell,
            this.dtPayDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.idAbnObj1,
            this.idSchmObjDataGridViewTextBoxColumn,
            this.subIDDataGridViewTextBoxColumn,
            this.ValueKWT,
            this.SizeKWT,
            this.NumberMeter,
            this.MeterType,
            this.Location,
            this.PointName,
            this.ObjParentName,
            this.MeterDataBegin,
            this.CheckMr,
            this.CheckIntervalMr,
            this.NameTrans,
            this.TypeTrans,
            this.DateBeginTrans,
            this.DateCheckTrans,
            this.IntervalTrans,
            this.TypeAbn});
            this.dgv1.DataSource = this.bs;
            this.dgv1.Location = new System.Drawing.Point(0, 28);
            this.dgv1.Name = "dgv1";
            this.dgv1.ReadOnly = true;
            this.dgv1.RowHeadersWidth = 5;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(612, 391);
            this.dgv1.TabIndex = 65;
            this.dgv1.DoubleClick += new System.EventHandler(this.dgv1_DoubleClick);
            // 
            // bs
            // 
            this.bs.DataMember = "tG_ReportMain_Link";
            this.bs.DataSource = this.dsDop1;
            // 
            // dsDop1
            // 
            this.dsDop1.DataSetName = "dsDop";
            this.dsDop1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tsbExcel
            // 
            this.tsbExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcel.Image")));
            this.tsbExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcel.Name = "tsbExcel";
            this.tsbExcel.Size = new System.Drawing.Size(23, 22);
            this.tsbExcel.Text = "toolStripButton1";
            this.tsbExcel.ToolTipText = "Экспорт в Excel";
            this.tsbExcel.Visible = false;
            this.tsbExcel.Click += new System.EventHandler(this.cmdExcel_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExcel,
            this.tsbPrint,
            this.tsbExcel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(835, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbPrint.Text = "Печать";
            this.tsbPrint.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbExcel2
            // 
            this.tsbExcel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbExcel2.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcel2.Image")));
            this.tsbExcel2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcel2.Name = "tsbExcel2";
            this.tsbExcel2.Size = new System.Drawing.Size(23, 22);
            this.tsbExcel2.Text = "Выгрузка в  Excel";
            this.tsbExcel2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(32, 19);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 66;
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(32, 48);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "по:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "с:";
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(179, 18);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(16, 23);
            this.btnPlus.TabIndex = 68;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(179, 47);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(16, 23);
            this.btnMinus.TabIndex = 69;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnMinus);
            this.groupBox1.Controls.Add(this.btnPlus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.dtBegin);
            this.groupBox1.Location = new System.Drawing.Point(620, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 87);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "За период:";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // codeAbonent
            // 
            this.codeAbonent.DataPropertyName = "CodeAbonent";
            this.codeAbonent.HeaderText = "№дог";
            this.codeAbonent.Name = "codeAbonent";
            this.codeAbonent.ReadOnly = true;
            this.codeAbonent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeAbonent.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // objNameDataGridViewTextBoxColumn
            // 
            this.objNameDataGridViewTextBoxColumn.DataPropertyName = "ObjName";
            this.objNameDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.objNameDataGridViewTextBoxColumn.Name = "objNameDataGridViewTextBoxColumn";
            this.objNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.objNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.objNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // cPNameDataGridViewTextBoxColumn
            // 
            this.cPNameDataGridViewTextBoxColumn.DataPropertyName = "CPName";
            this.cPNameDataGridViewTextBoxColumn.HeaderText = "Пит. центр";
            this.cPNameDataGridViewTextBoxColumn.Name = "cPNameDataGridViewTextBoxColumn";
            this.cPNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cellCPNameDataGridViewTextBoxColumn
            // 
            this.cellCPNameDataGridViewTextBoxColumn.DataPropertyName = "CellCPName";
            this.cellCPNameDataGridViewTextBoxColumn.HeaderText = "Ячейка";
            this.cellCPNameDataGridViewTextBoxColumn.Name = "cellCPNameDataGridViewTextBoxColumn";
            this.cellCPNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cellCPNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cellCPNameDataGridViewTextBoxColumn.Width = 75;
            // 
            // tPDataGridViewTextBoxColumn
            // 
            this.tPDataGridViewTextBoxColumn.DataPropertyName = "TP";
            this.tPDataGridViewTextBoxColumn.HeaderText = "Подстанция";
            this.tPDataGridViewTextBoxColumn.Name = "tPDataGridViewTextBoxColumn";
            this.tPDataGridViewTextBoxColumn.ReadOnly = true;
            this.tPDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tPDataGridViewTextBoxColumn.Width = 75;
            // 
            // TPCell
            // 
            this.TPCell.DataPropertyName = "TPCell";
            this.TPCell.HeaderText = "Рубильник подстанции";
            this.TPCell.Name = "TPCell";
            this.TPCell.ReadOnly = true;
            this.TPCell.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtPayDataGridViewTextBoxColumn
            // 
            this.dtPayDataGridViewTextBoxColumn.DataPropertyName = "dtPay";
            dataGridViewCellStyle1.Format = "y";
            dataGridViewCellStyle1.NullValue = null;
            this.dtPayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtPayDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dtPayDataGridViewTextBoxColumn.Name = "dtPayDataGridViewTextBoxColumn";
            this.dtPayDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtPayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtPayDataGridViewTextBoxColumn.Width = 75;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Объем объекта";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quantityDataGridViewTextBoxColumn.Width = 75;
            // 
            // idAbnObj1
            // 
            this.idAbnObj1.DataPropertyName = "idAbnObj";
            this.idAbnObj1.HeaderText = "idAbnObj";
            this.idAbnObj1.Name = "idAbnObj1";
            this.idAbnObj1.ReadOnly = true;
            this.idAbnObj1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idAbnObj1.Visible = false;
            // 
            // idSchmObjDataGridViewTextBoxColumn
            // 
            this.idSchmObjDataGridViewTextBoxColumn.DataPropertyName = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.HeaderText = "idSchmObj";
            this.idSchmObjDataGridViewTextBoxColumn.Name = "idSchmObjDataGridViewTextBoxColumn";
            this.idSchmObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSchmObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // subIDDataGridViewTextBoxColumn
            // 
            this.subIDDataGridViewTextBoxColumn.DataPropertyName = "SubID";
            this.subIDDataGridViewTextBoxColumn.HeaderText = "SubID";
            this.subIDDataGridViewTextBoxColumn.Name = "subIDDataGridViewTextBoxColumn";
            this.subIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.subIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ValueKWT
            // 
            this.ValueKWT.DataPropertyName = "ValueKWT";
            this.ValueKWT.HeaderText = "Показания счетчика";
            this.ValueKWT.Name = "ValueKWT";
            this.ValueKWT.ReadOnly = true;
            this.ValueKWT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ValueKWT.Visible = false;
            // 
            // SizeKWT
            // 
            this.SizeKWT.DataPropertyName = "SizeKWT";
            this.SizeKWT.HeaderText = "Объем счетчика";
            this.SizeKWT.Name = "SizeKWT";
            this.SizeKWT.ReadOnly = true;
            this.SizeKWT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NumberMeter
            // 
            this.NumberMeter.DataPropertyName = "NumberMeter";
            this.NumberMeter.HeaderText = "Номер счетчика";
            this.NumberMeter.Name = "NumberMeter";
            this.NumberMeter.ReadOnly = true;
            this.NumberMeter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MeterType
            // 
            this.MeterType.DataPropertyName = "MeterType";
            this.MeterType.HeaderText = "Тип счетчика";
            this.MeterType.Name = "MeterType";
            this.MeterType.ReadOnly = true;
            this.MeterType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Location
            // 
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Расположение счетчика";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PointName
            // 
            this.PointName.DataPropertyName = "PointName";
            this.PointName.HeaderText = "PointName";
            this.PointName.Name = "PointName";
            this.PointName.ReadOnly = true;
            this.PointName.Visible = false;
            // 
            // ObjParentName
            // 
            this.ObjParentName.DataPropertyName = "ObjParentName";
            this.ObjParentName.HeaderText = "Минусуемый объект";
            this.ObjParentName.Name = "ObjParentName";
            this.ObjParentName.ReadOnly = true;
            this.ObjParentName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MeterDataBegin
            // 
            this.MeterDataBegin.DataPropertyName = "MeterDataBegin";
            this.MeterDataBegin.HeaderText = "Дата установки счетчика";
            this.MeterDataBegin.Name = "MeterDataBegin";
            this.MeterDataBegin.ReadOnly = true;
            this.MeterDataBegin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MeterDataBegin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // CheckMr
            // 
            this.CheckMr.DataPropertyName = "CheckMr";
            this.CheckMr.HeaderText = "Дата ГП";
            this.CheckMr.Name = "CheckMr";
            this.CheckMr.ReadOnly = true;
            this.CheckMr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckMr.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CheckIntervalMr
            // 
            this.CheckIntervalMr.DataPropertyName = "CheckIntervalMr";
            this.CheckIntervalMr.HeaderText = "Интервал ГП";
            this.CheckIntervalMr.Name = "CheckIntervalMr";
            this.CheckIntervalMr.ReadOnly = true;
            this.CheckIntervalMr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // NameTrans
            // 
            this.NameTrans.DataPropertyName = "NameTrans";
            this.NameTrans.HeaderText = "Трансформатор измерительный";
            this.NameTrans.Name = "NameTrans";
            this.NameTrans.ReadOnly = true;
            // 
            // TypeTrans
            // 
            this.TypeTrans.DataPropertyName = "TypeTrans";
            this.TypeTrans.HeaderText = "Тип трансформатора";
            this.TypeTrans.Name = "TypeTrans";
            this.TypeTrans.ReadOnly = true;
            // 
            // DateBeginTrans
            // 
            this.DateBeginTrans.DataPropertyName = "DateBeginTrans";
            this.DateBeginTrans.HeaderText = "Дата установки трансформатора";
            this.DateBeginTrans.Name = "DateBeginTrans";
            this.DateBeginTrans.ReadOnly = true;
            this.DateBeginTrans.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DateCheckTrans
            // 
            this.DateCheckTrans.DataPropertyName = "DateCheckTrans";
            this.DateCheckTrans.HeaderText = "Дата ГП трансформатора";
            this.DateCheckTrans.Name = "DateCheckTrans";
            this.DateCheckTrans.ReadOnly = true;
            this.DateCheckTrans.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DateCheckTrans.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // IntervalTrans
            // 
            this.IntervalTrans.DataPropertyName = "IntervalTrans";
            this.IntervalTrans.HeaderText = "Интервал ГП трансформатор";
            this.IntervalTrans.Name = "IntervalTrans";
            this.IntervalTrans.ReadOnly = true;
            // 
            // TypeAbn
            // 
            this.TypeAbn.DataPropertyName = "TypeAbn";
            this.TypeAbn.HeaderText = "Тип абонента";
            this.TypeAbn.Name = "TypeAbn";
            this.TypeAbn.ReadOnly = true;
            // 
            // FormReportObjLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormReportObjLink";
            this.Text = "Отчет. Потребление помесячно по объекта с привязками к схеме";
            this.Load += new System.EventHandler(this.FormReportObjLink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDop1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private Legal.DataSet.dsDop dsDop1;
        //private System.Windows.Forms.DataGridView dgv1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilterN dgv1;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.ToolStripButton tsbExcel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.GroupBox groupBox1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn tPCellDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbExcel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonent;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn objNameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn cPNameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn cellCPNameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn tPDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn TPCell;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dtPayDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn quantityDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn idAbnObj1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSchmObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subIDDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn ValueKWT;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn SizeKWT;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn NumberMeter;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn MeterType;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointName;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn ObjParentName;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn MeterDataBegin;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn CheckMr;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn CheckIntervalMr;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn NameTrans;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn TypeTrans;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn DateBeginTrans;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterDateTimePickerColumn DateCheckTrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntervalTrans;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn TypeAbn;
    }
}