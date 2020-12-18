namespace Prv.Forms.Exchange
{
    partial class FormUEOpl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUEOpl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripOpl = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenFiles = new System.Windows.Forms.ToolStripButton();
            this.dateRaznoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumToPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUVALb1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUVALS1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoplatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDBF = new System.Windows.Forms.DataGridView();
            this.dogovorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kWT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUVALb2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUVALS2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kWT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSTPLATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSetOpl = new System.Data.DataSet();
            this.dataTableOpl = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.backgroundWorkerImpSQL = new System.ComponentModel.BackgroundWorker();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.progressBarEndLess = new ControlsLbr.ProgressBarEndLess();
            this.backgroundWorkerLoadDBF = new System.ComponentModel.BackgroundWorker();
            this.openFileDialogOpl = new System.Windows.Forms.OpenFileDialog();
            this.statusStripOpl = new System.Windows.Forms.StatusStrip();
            this.statusLabelFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerOpl = new System.Windows.Forms.SplitContainer();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.ColumnFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeriod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnLand = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnPrig = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnBanderol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCatch = new System.Windows.Forms.DataGridViewButtonColumn();
            this.backgroundWorkerDelBanderol = new System.ComponentModel.BackgroundWorker();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripOpl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOpl)).BeginInit();
            this.panelProgress.SuspendLayout();
            this.statusStripOpl.SuspendLayout();
            this.splitContainerOpl.Panel1.SuspendLayout();
            this.splitContainerOpl.Panel2.SuspendLayout();
            this.splitContainerOpl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripOpl
            // 
            this.toolStripOpl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenFiles,
            this.toolStripSeparator1});
            this.toolStripOpl.Location = new System.Drawing.Point(0, 0);
            this.toolStripOpl.Name = "toolStripOpl";
            this.toolStripOpl.Size = new System.Drawing.Size(684, 25);
            this.toolStripOpl.TabIndex = 14;
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
            // dateRaznoDataGridViewTextBoxColumn
            // 
            this.dateRaznoDataGridViewTextBoxColumn.DataPropertyName = "Date_Razno";
            this.dateRaznoDataGridViewTextBoxColumn.HeaderText = "Дата разн";
            this.dateRaznoDataGridViewTextBoxColumn.Name = "dateRaznoDataGridViewTextBoxColumn";
            this.dateRaznoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumToPayDataGridViewTextBoxColumn
            // 
            this.sumToPayDataGridViewTextBoxColumn.DataPropertyName = "Sum_To_Pay";
            this.sumToPayDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.sumToPayDataGridViewTextBoxColumn.Name = "sumToPayDataGridViewTextBoxColumn";
            this.sumToPayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOUVALb1DataGridViewTextBoxColumn
            // 
            this.cOUVALb1DataGridViewTextBoxColumn.DataPropertyName = "COU_VAL_b1";
            this.cOUVALb1DataGridViewTextBoxColumn.HeaderText = "Пред1";
            this.cOUVALb1DataGridViewTextBoxColumn.Name = "cOUVALb1DataGridViewTextBoxColumn";
            this.cOUVALb1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOUVALS1DataGridViewTextBoxColumn
            // 
            this.cOUVALS1DataGridViewTextBoxColumn.DataPropertyName = "COU_VAL_S1";
            this.cOUVALS1DataGridViewTextBoxColumn.HeaderText = "Текущ1";
            this.cOUVALS1DataGridViewTextBoxColumn.Name = "cOUVALS1DataGridViewTextBoxColumn";
            this.cOUVALS1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateoplatDataGridViewTextBoxColumn
            // 
            this.dateoplatDataGridViewTextBoxColumn.DataPropertyName = "Date_oplat";
            this.dateoplatDataGridViewTextBoxColumn.HeaderText = "Дата опл";
            this.dateoplatDataGridViewTextBoxColumn.Name = "dateoplatDataGridViewTextBoxColumn";
            this.dateoplatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomPointDataGridViewTextBoxColumn
            // 
            this.nomPointDataGridViewTextBoxColumn.DataPropertyName = "NomPoint";
            this.nomPointDataGridViewTextBoxColumn.HeaderText = "Точка";
            this.nomPointDataGridViewTextBoxColumn.Name = "nomPointDataGridViewTextBoxColumn";
            this.nomPointDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewDBF
            // 
            this.dataGridViewDBF.AllowUserToAddRows = false;
            this.dataGridViewDBF.AllowUserToDeleteRows = false;
            this.dataGridViewDBF.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewDBF.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDBF.AutoGenerateColumns = false;
            this.dataGridViewDBF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dogovorDataGridViewTextBoxColumn,
            this.nomPointDataGridViewTextBoxColumn,
            this.dateoplatDataGridViewTextBoxColumn,
            this.dateRaznoDataGridViewTextBoxColumn,
            this.sumToPayDataGridViewTextBoxColumn,
            this.cOUVALb1DataGridViewTextBoxColumn,
            this.cOUVALS1DataGridViewTextBoxColumn,
            this.kWT1DataGridViewTextBoxColumn,
            this.cOUVALb2DataGridViewTextBoxColumn,
            this.cOUVALS2DataGridViewTextBoxColumn,
            this.kWT2DataGridViewTextBoxColumn,
            this.pODataGridViewTextBoxColumn,
            this.mESDataGridViewTextBoxColumn,
            this.iSTPLATDataGridViewTextBoxColumn});
            this.dataGridViewDBF.DataMember = "TableOpl";
            this.dataGridViewDBF.DataSource = this.dataSetOpl;
            this.dataGridViewDBF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDBF.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDBF.Name = "dataGridViewDBF";
            this.dataGridViewDBF.ReadOnly = true;
            this.dataGridViewDBF.RowHeadersVisible = false;
            this.dataGridViewDBF.Size = new System.Drawing.Size(684, 203);
            this.dataGridViewDBF.TabIndex = 13;
            // 
            // dogovorDataGridViewTextBoxColumn
            // 
            this.dogovorDataGridViewTextBoxColumn.DataPropertyName = "Dogovor";
            this.dogovorDataGridViewTextBoxColumn.HeaderText = "Договор (л/с)";
            this.dogovorDataGridViewTextBoxColumn.Name = "dogovorDataGridViewTextBoxColumn";
            this.dogovorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kWT1DataGridViewTextBoxColumn
            // 
            this.kWT1DataGridViewTextBoxColumn.DataPropertyName = "KWT1";
            this.kWT1DataGridViewTextBoxColumn.HeaderText = "кВт1";
            this.kWT1DataGridViewTextBoxColumn.Name = "kWT1DataGridViewTextBoxColumn";
            this.kWT1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOUVALb2DataGridViewTextBoxColumn
            // 
            this.cOUVALb2DataGridViewTextBoxColumn.DataPropertyName = "COU_VAL_b2";
            this.cOUVALb2DataGridViewTextBoxColumn.HeaderText = "Пред1";
            this.cOUVALb2DataGridViewTextBoxColumn.Name = "cOUVALb2DataGridViewTextBoxColumn";
            this.cOUVALb2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOUVALS2DataGridViewTextBoxColumn
            // 
            this.cOUVALS2DataGridViewTextBoxColumn.DataPropertyName = "COU_VAL_S2";
            this.cOUVALS2DataGridViewTextBoxColumn.HeaderText = "Текущ2";
            this.cOUVALS2DataGridViewTextBoxColumn.Name = "cOUVALS2DataGridViewTextBoxColumn";
            this.cOUVALS2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kWT2DataGridViewTextBoxColumn
            // 
            this.kWT2DataGridViewTextBoxColumn.DataPropertyName = "KWT2";
            this.kWT2DataGridViewTextBoxColumn.HeaderText = "кВт2";
            this.kWT2DataGridViewTextBoxColumn.Name = "kWT2DataGridViewTextBoxColumn";
            this.kWT2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pODataGridViewTextBoxColumn
            // 
            this.pODataGridViewTextBoxColumn.DataPropertyName = "PO";
            this.pODataGridViewTextBoxColumn.HeaderText = "PO";
            this.pODataGridViewTextBoxColumn.Name = "pODataGridViewTextBoxColumn";
            this.pODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mESDataGridViewTextBoxColumn
            // 
            this.mESDataGridViewTextBoxColumn.DataPropertyName = "MES";
            this.mESDataGridViewTextBoxColumn.HeaderText = "MES";
            this.mESDataGridViewTextBoxColumn.Name = "mESDataGridViewTextBoxColumn";
            this.mESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iSTPLATDataGridViewTextBoxColumn
            // 
            this.iSTPLATDataGridViewTextBoxColumn.DataPropertyName = "IST_PLAT";
            this.iSTPLATDataGridViewTextBoxColumn.HeaderText = "IST_PLAT";
            this.iSTPLATDataGridViewTextBoxColumn.Name = "iSTPLATDataGridViewTextBoxColumn";
            this.iSTPLATDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataSetOpl
            // 
            this.dataSetOpl.DataSetName = "NewDataSet";
            this.dataSetOpl.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableOpl});
            // 
            // dataTableOpl
            // 
            this.dataTableOpl.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
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
            this.dataTableOpl.TableName = "TableOpl";
            // 
            // dataColumn1
            // 
            this.dataColumn1.AllowDBNull = false;
            this.dataColumn1.ColumnName = "Dogovor";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "NomPoint";
            this.dataColumn2.DataType = typeof(decimal);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Date_oplat";
            this.dataColumn3.DataType = typeof(System.DateTime);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Date_Razno";
            this.dataColumn4.DataType = typeof(System.DateTime);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Sum_To_Pay";
            this.dataColumn5.DataType = typeof(decimal);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "COU_VAL_b1";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "COU_VAL_S1";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "KWT1";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "COU_VAL_b2";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "COU_VAL_S2";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "KWT2";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "PO";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "MES";
            this.dataColumn13.DataType = typeof(decimal);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "IST_PLAT";
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
            // backgroundWorkerImpSQL
            // 
            this.backgroundWorkerImpSQL.WorkerReportsProgress = true;
            this.backgroundWorkerImpSQL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerImpSQL_DoWork);
            this.backgroundWorkerImpSQL.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerImpSQL_ProgressChanged);
            this.backgroundWorkerImpSQL.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerImpSQL_RunWorkerCompleted);
            // 
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelProgress.Controls.Add(this.progressBar);
            this.panelProgress.Controls.Add(this.labelProgress);
            this.panelProgress.Controls.Add(this.progressBarEndLess);
            this.panelProgress.Location = new System.Drawing.Point(208, 183);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(274, 67);
            this.panelProgress.TabIndex = 15;
            this.panelProgress.Visible = false;
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
            // statusStripOpl
            // 
            this.statusStripOpl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelFile});
            this.statusStripOpl.Location = new System.Drawing.Point(0, 390);
            this.statusStripOpl.Name = "statusStripOpl";
            this.statusStripOpl.Size = new System.Drawing.Size(684, 22);
            this.statusStripOpl.TabIndex = 16;
            this.statusStripOpl.Text = "statusStrip1";
            // 
            // statusLabelFile
            // 
            this.statusLabelFile.Name = "statusLabelFile";
            this.statusLabelFile.Size = new System.Drawing.Size(669, 17);
            this.statusLabelFile.Spring = true;
            this.statusLabelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabelFile.ToolTipText = "Выбранный файл";
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
            this.splitContainerOpl.Panel1.Controls.Add(this.dataGridViewFiles);
            // 
            // splitContainerOpl.Panel2
            // 
            this.splitContainerOpl.Panel2.Controls.Add(this.dataGridViewDBF);
            this.splitContainerOpl.Size = new System.Drawing.Size(684, 412);
            this.splitContainerOpl.SplitterDistance = 205;
            this.splitContainerOpl.TabIndex = 17;
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dataGridViewFiles.Size = new System.Drawing.Size(684, 205);
            this.dataGridViewFiles.TabIndex = 1;
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
            dataGridViewCellStyle3.Format = "MMMM yyyy";
            this.ColumnPeriod.DefaultCellStyle = dataGridViewCellStyle3;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // FormUEOpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 412);
            this.Controls.Add(this.toolStripOpl);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.statusStripOpl);
            this.Controls.Add(this.splitContainerOpl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUEOpl";
            this.Text = "Загрузка оплаты из Ульяновскэнерго";
            this.toolStripOpl.ResumeLayout(false);
            this.toolStripOpl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableOpl)).EndInit();
            this.panelProgress.ResumeLayout(false);
            this.statusStripOpl.ResumeLayout(false);
            this.statusStripOpl.PerformLayout();
            this.splitContainerOpl.Panel1.ResumeLayout(false);
            this.splitContainerOpl.Panel2.ResumeLayout(false);
            this.splitContainerOpl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripOpl;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRaznoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumToPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUVALb1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUVALS1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoplatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewDBF;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogovorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kWT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUVALb2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUVALS2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kWT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSTPLATDataGridViewTextBoxColumn;
        private System.Data.DataSet dataSetOpl;
        private System.Data.DataTable dataTableOpl;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
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
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgress;
        private ControlsLbr.ProgressBarEndLess progressBarEndLess;
        private System.ComponentModel.BackgroundWorker backgroundWorkerImpSQL;
        private System.Windows.Forms.Panel panelProgress;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadDBF;
        private System.Windows.Forms.OpenFileDialog openFileDialogOpl;
        private System.Windows.Forms.StatusStrip statusStripOpl;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelFile;
        private System.Windows.Forms.SplitContainer splitContainerOpl;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.ComponentModel.BackgroundWorker backgroundWorkerDelBanderol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFile;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnPeriod;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnLand;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnPrig;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBanderol;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCatch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}