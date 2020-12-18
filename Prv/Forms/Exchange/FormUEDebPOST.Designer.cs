namespace Prv.Forms.Exchange
{
    partial class FormUEDEbPOST
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUEDEbPOST));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerOpl = new System.Windows.Forms.SplitContainer();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBarEndLess = new ControlsLbr.ProgressBarEndLess();
            this.toolStripOpl = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenFiles = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.ColumnFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeriod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnLand = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnPrig = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnBanderol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCatch = new System.Windows.Forms.DataGridViewButtonColumn();
            this.statusStripOpl = new System.Windows.Forms.StatusStrip();
            this.statusLabelFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewDBF = new System.Windows.Forms.DataGridView();
            this.dOGOVORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMPOINTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gORODOKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uLICADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kORPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMPOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kODTIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTOGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATASOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMTARIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERIODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONSCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetDeb = new System.Data.DataSet();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn36 = new System.Data.DataColumn();
            this.dataColumn37 = new System.Data.DataColumn();
            this.dataColumn38 = new System.Data.DataColumn();
            this.dataColumn39 = new System.Data.DataColumn();
            this.dataColumn40 = new System.Data.DataColumn();
            this.dataColumn41 = new System.Data.DataColumn();
            this.dataColumn42 = new System.Data.DataColumn();
            this.dataColumn43 = new System.Data.DataColumn();
            this.dataColumn44 = new System.Data.DataColumn();
            this.dataColumn45 = new System.Data.DataColumn();
            this.dataColumn46 = new System.Data.DataColumn();
            this.dataColumn47 = new System.Data.DataColumn();
            this.dataColumn48 = new System.Data.DataColumn();
            this.dataColumn49 = new System.Data.DataColumn();
            this.dataColumn50 = new System.Data.DataColumn();
            this.dataColumn51 = new System.Data.DataColumn();
            this.dataColumn52 = new System.Data.DataColumn();
            this.backgroundWorkerImpSQL = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerLoadDBF = new System.ComponentModel.BackgroundWorker();
            this.openFileDialogOpl = new System.Windows.Forms.OpenFileDialog();
            this.splitContainerOpl.Panel1.SuspendLayout();
            this.splitContainerOpl.Panel2.SuspendLayout();
            this.splitContainerOpl.SuspendLayout();
            this.panelProgress.SuspendLayout();
            this.toolStripOpl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.statusStripOpl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerOpl
            // 
            this.splitContainerOpl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOpl.Location = new System.Drawing.Point(0, 0);
            this.splitContainerOpl.Name = "splitContainerOpl";
            this.splitContainerOpl.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerOpl.Panel1
            // 
            this.splitContainerOpl.Panel1.Controls.Add(this.panelProgress);
            this.splitContainerOpl.Panel1.Controls.Add(this.toolStripOpl);
            this.splitContainerOpl.Panel1.Controls.Add(this.dataGridViewFiles);
            // 
            // splitContainerOpl.Panel2
            // 
            this.splitContainerOpl.Panel2.Controls.Add(this.statusStripOpl);
            this.splitContainerOpl.Panel2.Controls.Add(this.dataGridViewDBF);
            this.splitContainerOpl.Size = new System.Drawing.Size(738, 510);
            this.splitContainerOpl.SplitterDistance = 233;
            this.splitContainerOpl.TabIndex = 0;
            // 
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelProgress.Controls.Add(this.progressBar);
            this.panelProgress.Controls.Add(this.labelProgress);
            this.panelProgress.Controls.Add(this.progressBarEndLess);
            this.panelProgress.Location = new System.Drawing.Point(222, 28);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(274, 67);
            this.panelProgress.TabIndex = 18;
            this.panelProgress.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(274, 34);
            this.progressBar.TabIndex = 2;
            this.progressBar.Visible = false;
            // 
            // labelProgress
            // 
            this.labelProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProgress.Location = new System.Drawing.Point(0, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(274, 34);
            this.labelProgress.TabIndex = 1;
            this.labelProgress.Text = "Подождите, идет загрузка данных из файла...";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBarEndLess
            // 
            this.progressBarEndLess.AutoProgressSpeed = 130;
            this.progressBarEndLess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarEndLess.Location = new System.Drawing.Point(0, 37);
            this.progressBarEndLess.Name = "progressBarEndLess";
            this.progressBarEndLess.NormalImage = ((System.Drawing.Image)(resources.GetObject("progressBarEndLess.NormalImage")));
            this.progressBarEndLess.PointImage = ((System.Drawing.Image)(resources.GetObject("progressBarEndLess.PointImage")));
            this.progressBarEndLess.Position = 0;
            this.progressBarEndLess.ProgressBoxStyle = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessBoxStyleConstants.SolidSameSize;
            this.progressBarEndLess.ProgressStyle = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessStyleConstants.LeftAndRight;
            this.progressBarEndLess.ProgressType = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessTypeConstants.GraphicType;
            this.progressBarEndLess.Size = new System.Drawing.Size(274, 30);
            this.progressBarEndLess.TabIndex = 0;
            this.progressBarEndLess.Visible = false;
            // 
            // toolStripOpl
            // 
            this.toolStripOpl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenFiles,
            this.toolStripSeparator1});
            this.toolStripOpl.Location = new System.Drawing.Point(0, 0);
            this.toolStripOpl.Name = "toolStripOpl";
            this.toolStripOpl.Size = new System.Drawing.Size(738, 25);
            this.toolStripOpl.TabIndex = 16;
            this.toolStripOpl.Text = "toolStrip1";
            // 
            // toolStripButtonOpenFiles
            // 
            this.toolStripButtonOpenFiles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpenFiles.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpenFiles.Image")));
            this.toolStripButtonOpenFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpenFiles.Name = "toolStripButtonOpenFiles";
            this.toolStripButtonOpenFiles.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpenFiles.Text = "Выбор файла оплаты";
            this.toolStripButtonOpenFiles.Click += new System.EventHandler(this.toolStripButtonOpenFiles_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFile,
            this.ColumnPeriod,
            this.ColumnLand,
            this.ColumnPrig,
            this.ColumnBanderol,
            this.ColumnCatch});
            this.dataGridViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFiles.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.RowHeadersWidth = 10;
            this.dataGridViewFiles.Size = new System.Drawing.Size(738, 233);
            this.dataGridViewFiles.TabIndex = 15;
            this.dataGridViewFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFiles_CellContentClick);
            this.dataGridViewFiles.CurrentCellChanged += new System.EventHandler(this.dataGridViewFiles_CurrentCellChanged);
            this.dataGridViewFiles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewFiles_MouseClick);
            // 
            // ColumnFile
            // 
            this.ColumnFile.HeaderText = "Имя файла";
            this.ColumnFile.Name = "ColumnFile";
            this.ColumnFile.ReadOnly = true;
            this.ColumnFile.Width = 400;
            // 
            // ColumnPeriod
            // 
            dataGridViewCellStyle2.Format = "MMMM yyyy";
            this.ColumnPeriod.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnPeriod.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnPeriod.HeaderText = "Период";
            this.ColumnPeriod.Name = "ColumnPeriod";
            this.ColumnPeriod.Visible = false;
            this.ColumnPeriod.Width = 110;
            // 
            // ColumnLand
            // 
            this.ColumnLand.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnLand.HeaderText = "Берег";
            this.ColumnLand.Items.AddRange(new object[] {
            "Правый берег",
            "Левый берег"});
            this.ColumnLand.Name = "ColumnLand";
            this.ColumnLand.Visible = false;
            // 
            // ColumnPrig
            // 
            this.ColumnPrig.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnPrig.HeaderText = "Приг/неприг";
            this.ColumnPrig.Items.AddRange(new object[] {
            "Непригород",
            "Пригород"});
            this.ColumnPrig.Name = "ColumnPrig";
            this.ColumnPrig.Visible = false;
            this.ColumnPrig.Width = 90;
            // 
            // ColumnBanderol
            // 
            this.ColumnBanderol.HeaderText = "Бандероль";
            this.ColumnBanderol.Name = "ColumnBanderol";
            this.ColumnBanderol.ReadOnly = true;
            this.ColumnBanderol.Visible = false;
            this.ColumnBanderol.Width = 70;
            // 
            // ColumnCatch
            // 
            this.ColumnCatch.HeaderText = "Провести";
            this.ColumnCatch.Name = "ColumnCatch";
            this.ColumnCatch.Text = "Провести";
            this.ColumnCatch.Width = 60;
            // 
            // statusStripOpl
            // 
            this.statusStripOpl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelFile});
            this.statusStripOpl.Location = new System.Drawing.Point(0, 251);
            this.statusStripOpl.Name = "statusStripOpl";
            this.statusStripOpl.Size = new System.Drawing.Size(738, 22);
            this.statusStripOpl.TabIndex = 17;
            this.statusStripOpl.Text = "statusStrip1";
            // 
            // statusLabelFile
            // 
            this.statusLabelFile.Name = "statusLabelFile";
            this.statusLabelFile.Size = new System.Drawing.Size(723, 17);
            this.statusLabelFile.Spring = true;
            this.statusLabelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabelFile.ToolTipText = "Выбранный файл";
            // 
            // dataGridViewDBF
            // 
            this.dataGridViewDBF.AllowUserToAddRows = false;
            this.dataGridViewDBF.AllowUserToDeleteRows = false;
            this.dataGridViewDBF.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewDBF.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDBF.AutoGenerateColumns = false;
            this.dataGridViewDBF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dOGOVORDataGridViewTextBoxColumn,
            this.nOMPOINTDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.rAIONDataGridViewTextBoxColumn,
            this.gORODOKDataGridViewTextBoxColumn,
            this.uLICADataGridViewTextBoxColumn,
            this.dOMDataGridViewTextBoxColumn,
            this.kORPDataGridViewTextBoxColumn,
            this.kVDataGridViewTextBoxColumn,
            this.nOMPOMDataGridViewTextBoxColumn,
            this.tIPDataGridViewTextBoxColumn,
            this.kODTIPDataGridViewTextBoxColumn,
            this.iTOGDataGridViewTextBoxColumn,
            this.dATASOBDataGridViewTextBoxColumn,
            this.nOMTARIFDataGridViewTextBoxColumn,
            this.pERIODDataGridViewTextBoxColumn,
            this.cONSCODEDataGridViewTextBoxColumn});
            this.dataGridViewDBF.DataMember = "TableDeb";
            this.dataGridViewDBF.DataSource = this.dataSetDeb;
            this.dataGridViewDBF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDBF.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDBF.Name = "dataGridViewDBF";
            this.dataGridViewDBF.ReadOnly = true;
            this.dataGridViewDBF.RowHeadersVisible = false;
            this.dataGridViewDBF.Size = new System.Drawing.Size(738, 273);
            this.dataGridViewDBF.TabIndex = 14;
            // 
            // dOGOVORDataGridViewTextBoxColumn
            // 
            this.dOGOVORDataGridViewTextBoxColumn.DataPropertyName = "DOGOVOR";
            this.dOGOVORDataGridViewTextBoxColumn.HeaderText = "DOGOVOR";
            this.dOGOVORDataGridViewTextBoxColumn.Name = "dOGOVORDataGridViewTextBoxColumn";
            this.dOGOVORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMPOINTDataGridViewTextBoxColumn
            // 
            this.nOMPOINTDataGridViewTextBoxColumn.DataPropertyName = "NOMPOINT";
            this.nOMPOINTDataGridViewTextBoxColumn.HeaderText = "NOMPOINT";
            this.nOMPOINTDataGridViewTextBoxColumn.Name = "nOMPOINTDataGridViewTextBoxColumn";
            this.nOMPOINTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rAIONDataGridViewTextBoxColumn
            // 
            this.rAIONDataGridViewTextBoxColumn.DataPropertyName = "RAION";
            this.rAIONDataGridViewTextBoxColumn.HeaderText = "RAION";
            this.rAIONDataGridViewTextBoxColumn.Name = "rAIONDataGridViewTextBoxColumn";
            this.rAIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gORODOKDataGridViewTextBoxColumn
            // 
            this.gORODOKDataGridViewTextBoxColumn.DataPropertyName = "GORODOK";
            this.gORODOKDataGridViewTextBoxColumn.HeaderText = "GORODOK";
            this.gORODOKDataGridViewTextBoxColumn.Name = "gORODOKDataGridViewTextBoxColumn";
            this.gORODOKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uLICADataGridViewTextBoxColumn
            // 
            this.uLICADataGridViewTextBoxColumn.DataPropertyName = "ULICA";
            this.uLICADataGridViewTextBoxColumn.HeaderText = "ULICA";
            this.uLICADataGridViewTextBoxColumn.Name = "uLICADataGridViewTextBoxColumn";
            this.uLICADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOMDataGridViewTextBoxColumn
            // 
            this.dOMDataGridViewTextBoxColumn.DataPropertyName = "DOM";
            this.dOMDataGridViewTextBoxColumn.HeaderText = "DOM";
            this.dOMDataGridViewTextBoxColumn.Name = "dOMDataGridViewTextBoxColumn";
            this.dOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kORPDataGridViewTextBoxColumn
            // 
            this.kORPDataGridViewTextBoxColumn.DataPropertyName = "KORP";
            this.kORPDataGridViewTextBoxColumn.HeaderText = "KORP";
            this.kORPDataGridViewTextBoxColumn.Name = "kORPDataGridViewTextBoxColumn";
            this.kORPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kVDataGridViewTextBoxColumn
            // 
            this.kVDataGridViewTextBoxColumn.DataPropertyName = "KV";
            this.kVDataGridViewTextBoxColumn.HeaderText = "KV";
            this.kVDataGridViewTextBoxColumn.Name = "kVDataGridViewTextBoxColumn";
            this.kVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMPOMDataGridViewTextBoxColumn
            // 
            this.nOMPOMDataGridViewTextBoxColumn.DataPropertyName = "NOMPOM";
            this.nOMPOMDataGridViewTextBoxColumn.HeaderText = "NOMPOM";
            this.nOMPOMDataGridViewTextBoxColumn.Name = "nOMPOMDataGridViewTextBoxColumn";
            this.nOMPOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPDataGridViewTextBoxColumn
            // 
            this.tIPDataGridViewTextBoxColumn.DataPropertyName = "TIP";
            this.tIPDataGridViewTextBoxColumn.HeaderText = "TIP";
            this.tIPDataGridViewTextBoxColumn.Name = "tIPDataGridViewTextBoxColumn";
            this.tIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kODTIPDataGridViewTextBoxColumn
            // 
            this.kODTIPDataGridViewTextBoxColumn.DataPropertyName = "KODTIP";
            this.kODTIPDataGridViewTextBoxColumn.HeaderText = "KODTIP";
            this.kODTIPDataGridViewTextBoxColumn.Name = "kODTIPDataGridViewTextBoxColumn";
            this.kODTIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTOGDataGridViewTextBoxColumn
            // 
            this.iTOGDataGridViewTextBoxColumn.DataPropertyName = "ITOG";
            this.iTOGDataGridViewTextBoxColumn.HeaderText = "ITOG";
            this.iTOGDataGridViewTextBoxColumn.Name = "iTOGDataGridViewTextBoxColumn";
            this.iTOGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATASOBDataGridViewTextBoxColumn
            // 
            this.dATASOBDataGridViewTextBoxColumn.DataPropertyName = "DATASOB";
            this.dATASOBDataGridViewTextBoxColumn.HeaderText = "DATASOB";
            this.dATASOBDataGridViewTextBoxColumn.Name = "dATASOBDataGridViewTextBoxColumn";
            this.dATASOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMTARIFDataGridViewTextBoxColumn
            // 
            this.nOMTARIFDataGridViewTextBoxColumn.DataPropertyName = "NOMTARIF";
            this.nOMTARIFDataGridViewTextBoxColumn.HeaderText = "NOMTARIF";
            this.nOMTARIFDataGridViewTextBoxColumn.Name = "nOMTARIFDataGridViewTextBoxColumn";
            this.nOMTARIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pERIODDataGridViewTextBoxColumn
            // 
            this.pERIODDataGridViewTextBoxColumn.DataPropertyName = "PERIOD";
            this.pERIODDataGridViewTextBoxColumn.HeaderText = "PERIOD";
            this.pERIODDataGridViewTextBoxColumn.Name = "pERIODDataGridViewTextBoxColumn";
            this.pERIODDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONSCODEDataGridViewTextBoxColumn
            // 
            this.cONSCODEDataGridViewTextBoxColumn.DataPropertyName = "CONS_CODE";
            this.cONSCODEDataGridViewTextBoxColumn.HeaderText = "CONS_CODE";
            this.cONSCODEDataGridViewTextBoxColumn.Name = "cONSCODEDataGridViewTextBoxColumn";
            this.cONSCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSetDeb
            // 
            this.dataSetDeb.DataSetName = "NewDataSet";
            this.dataSetDeb.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable2});
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn36,
            this.dataColumn37,
            this.dataColumn38,
            this.dataColumn39,
            this.dataColumn40,
            this.dataColumn41,
            this.dataColumn42,
            this.dataColumn43,
            this.dataColumn44,
            this.dataColumn45,
            this.dataColumn46,
            this.dataColumn47,
            this.dataColumn48,
            this.dataColumn49,
            this.dataColumn50,
            this.dataColumn51,
            this.dataColumn52});
            this.dataTable2.TableName = "TableDeb";
            // 
            // dataColumn36
            // 
            this.dataColumn36.ColumnName = "DOGOVOR";
            // 
            // dataColumn37
            // 
            this.dataColumn37.ColumnName = "NOMPOINT";
            // 
            // dataColumn38
            // 
            this.dataColumn38.ColumnName = "FIO";
            // 
            // dataColumn39
            // 
            this.dataColumn39.ColumnName = "RAION";
            // 
            // dataColumn40
            // 
            this.dataColumn40.ColumnName = "GORODOK";
            // 
            // dataColumn41
            // 
            this.dataColumn41.ColumnName = "ULICA";
            // 
            // dataColumn42
            // 
            this.dataColumn42.ColumnName = "DOM";
            // 
            // dataColumn43
            // 
            this.dataColumn43.ColumnName = "KORP";
            // 
            // dataColumn44
            // 
            this.dataColumn44.ColumnName = "KV";
            // 
            // dataColumn45
            // 
            this.dataColumn45.ColumnName = "NOMPOM";
            // 
            // dataColumn46
            // 
            this.dataColumn46.ColumnName = "TIP";
            // 
            // dataColumn47
            // 
            this.dataColumn47.ColumnName = "KODTIP";
            // 
            // dataColumn48
            // 
            this.dataColumn48.ColumnName = "ITOG";
            this.dataColumn48.DataType = typeof(decimal);
            // 
            // dataColumn49
            // 
            this.dataColumn49.ColumnName = "DATASOB";
            this.dataColumn49.DataType = typeof(System.DateTime);
            // 
            // dataColumn50
            // 
            this.dataColumn50.ColumnName = "NOMTARIF";
            // 
            // dataColumn51
            // 
            this.dataColumn51.ColumnName = "PERIOD";
            // 
            // dataColumn52
            // 
            this.dataColumn52.ColumnName = "CONS_CODE";
            // 
            // backgroundWorkerImpSQL
            // 
            this.backgroundWorkerImpSQL.WorkerReportsProgress = true;
            this.backgroundWorkerImpSQL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerImpSQL_DoWork);
            this.backgroundWorkerImpSQL.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerImpSQL_ProgressChanged);
            this.backgroundWorkerImpSQL.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerImpSQL_RunWorkerCompleted);
            // 
            // backgroundWorkerLoadDBF
            // 
            this.backgroundWorkerLoadDBF.WorkerReportsProgress = true;
            this.backgroundWorkerLoadDBF.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoadDBF_DoWork);
            this.backgroundWorkerLoadDBF.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoadDBF_RunWorkerCompleted);
            // 
            // openFileDialogOpl
            // 
            this.openFileDialogOpl.Filter = "dbf files (*.dbf)|*.dbf|All files (*.*)|*.*";
            this.openFileDialogOpl.InitialDirectory = "x:\\ImpExpFiles\\ULEnergo\\Oplata";
            this.openFileDialogOpl.Multiselect = true;
            // 
            // FormUEDEbPOST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 510);
            this.Controls.Add(this.splitContainerOpl);
            this.Name = "FormUEDEbPOST";
            this.Text = "Дебиторка из Ульяновскэнерго присланая по почте";
            this.splitContainerOpl.Panel1.ResumeLayout(false);
            this.splitContainerOpl.Panel1.PerformLayout();
            this.splitContainerOpl.Panel2.ResumeLayout(false);
            this.splitContainerOpl.Panel2.PerformLayout();
            this.splitContainerOpl.ResumeLayout(false);
            this.panelProgress.ResumeLayout(false);
            this.toolStripOpl.ResumeLayout(false);
            this.toolStripOpl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.statusStripOpl.ResumeLayout(false);
            this.statusStripOpl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerOpl;
        private System.Windows.Forms.ToolStrip toolStripOpl;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFiles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.ComponentModel.BackgroundWorker backgroundWorkerImpSQL;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadDBF;
        private System.Windows.Forms.OpenFileDialog openFileDialogOpl;
        private System.Windows.Forms.StatusStrip statusStripOpl;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelFile;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgress;
        private ControlsLbr.ProgressBarEndLess progressBarEndLess;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFile;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnPeriod;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnLand;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnPrig;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBanderol;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCatch;
        private System.Windows.Forms.DataGridView dataGridViewDBF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOGOVORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMPOINTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gORODOKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uLICADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kORPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMPOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODTIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTOGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATASOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMTARIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pERIODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cONSCODEDataGridViewTextBoxColumn;
        private System.Data.DataSet dataSetDeb;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn36;
        private System.Data.DataColumn dataColumn37;
        private System.Data.DataColumn dataColumn38;
        private System.Data.DataColumn dataColumn39;
        private System.Data.DataColumn dataColumn40;
        private System.Data.DataColumn dataColumn41;
        private System.Data.DataColumn dataColumn42;
        private System.Data.DataColumn dataColumn43;
        private System.Data.DataColumn dataColumn44;
        private System.Data.DataColumn dataColumn45;
        private System.Data.DataColumn dataColumn46;
        private System.Data.DataColumn dataColumn47;
        private System.Data.DataColumn dataColumn48;
        private System.Data.DataColumn dataColumn49;
        private System.Data.DataColumn dataColumn50;
        private System.Data.DataColumn dataColumn51;
        private System.Data.DataColumn dataColumn52;
    }
}