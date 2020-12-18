namespace Prv.Forms.Exchange
{
    partial class FormSBROpl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSBROpl));
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogDBF = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.contextMenuStripCopy = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataSetDBF = new System.Data.DataSet();
            this.dataTableDBF = new System.Data.DataTable();
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
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.kWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUVALSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMSUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAYTYPEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOUVALBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.backgroundWorkerCatch = new System.ComponentModel.BackgroundWorker();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.toolStripMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripImport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCatch = new System.Windows.Forms.ToolStripMenuItem();
            this.oPERATORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMOPPCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nUMOPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUMTOPAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUNKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nPLPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nLCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDBF = new System.Windows.Forms.DataGridView();
            this.backgroundWorkerCancel = new System.ComponentModel.BackgroundWorker();
            this.colDirectory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcodePackPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodePackLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.contextMenuStripCopy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDBF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableDBF)).BeginInit();
            this.panelProgress.SuspendLayout();
            this.contextMenuStripImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBF)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.ShortcutKeyDisplayString = " ";
            this.toolStripMenuItemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItemCopy.Text = "Копировать";
            // 
            // openFileDialogDBF
            // 
            this.openFileDialogDBF.Filter = "dbf files (*.dbf)|*.dbf|All files (*.*)|*.*";
            this.openFileDialogDBF.InitialDirectory = "x:\\ImpExpFiles\\Bank\\";
            this.openFileDialogDBF.Multiselect = true;
            this.openFileDialogDBF.RestoreDirectory = true;
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToResizeRows = false;
            this.dataGridViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDirectory,
            this.colFileName,
            this.OK,
            this.colPackPB,
            this.colPackLB,
            this.colcodePackPB,
            this.colCodePackLB});
            this.dataGridViewFiles.Location = new System.Drawing.Point(0, -1);
            this.dataGridViewFiles.MultiSelect = false;
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.ReadOnly = true;
            this.dataGridViewFiles.RowHeadersVisible = false;
            this.dataGridViewFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFiles.Size = new System.Drawing.Size(477, 170);
            this.dataGridViewFiles.TabIndex = 7;
            this.dataGridViewFiles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFiles_CellMouseClick);
            this.dataGridViewFiles.SelectionChanged += new System.EventHandler(this.dataGridViewFiles_SelectionChanged);
            // 
            // contextMenuStripCopy
            // 
            this.contextMenuStripCopy.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy});
            this.contextMenuStripCopy.Name = "contextMenuStrip1";
            this.contextMenuStripCopy.Size = new System.Drawing.Size(150, 26);
            // 
            // dataSetDBF
            // 
            this.dataSetDBF.DataSetName = "NewDataSet";
            this.dataSetDBF.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableDBF});
            // 
            // dataTableDBF
            // 
            this.dataTableDBF.Columns.AddRange(new System.Data.DataColumn[] {
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
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18});
            this.dataTableDBF.TableName = "TableDBF";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "PLP_DATE";
            this.dataColumn1.DataType = typeof(System.DateTime);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "NPLP";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "PROC_DATE";
            this.dataColumn3.DataType = typeof(System.DateTime);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "NUMOP";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "NUMOP_PC";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "PUNKT";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "OPERATOR";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "N_LC";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "FIO";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "ADDRESS";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "SUM_TO_PAY";
            this.dataColumn11.DataType = typeof(decimal);
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "COMSUM";
            this.dataColumn12.DataType = typeof(decimal);
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "PAYTYPE";
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "PO";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "MES";
            this.dataColumn15.DataType = typeof(decimal);
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "COU_VAL_B";
            // 
            // dataColumn17
            // 
            this.dataColumn17.ColumnName = "COU_VAL_S";
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "KWT";
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(12, 181);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(105, 23);
            this.buttonAddFiles.TabIndex = 6;
            this.buttonAddFiles.Text = "Добавить файлы";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // kWTDataGridViewTextBoxColumn
            // 
            this.kWTDataGridViewTextBoxColumn.DataPropertyName = "KWT";
            this.kWTDataGridViewTextBoxColumn.HeaderText = "KWT";
            this.kWTDataGridViewTextBoxColumn.Name = "kWTDataGridViewTextBoxColumn";
            this.kWTDataGridViewTextBoxColumn.ReadOnly = true;
            this.kWTDataGridViewTextBoxColumn.Visible = false;
            // 
            // cOUVALSDataGridViewTextBoxColumn
            // 
            this.cOUVALSDataGridViewTextBoxColumn.DataPropertyName = "COU_VAL_S";
            this.cOUVALSDataGridViewTextBoxColumn.HeaderText = "COU_VAL_S";
            this.cOUVALSDataGridViewTextBoxColumn.Name = "cOUVALSDataGridViewTextBoxColumn";
            this.cOUVALSDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOUVALSDataGridViewTextBoxColumn.Visible = false;
            // 
            // cOMSUMDataGridViewTextBoxColumn
            // 
            this.cOMSUMDataGridViewTextBoxColumn.DataPropertyName = "COMSUM";
            this.cOMSUMDataGridViewTextBoxColumn.HeaderText = "COMSUM";
            this.cOMSUMDataGridViewTextBoxColumn.Name = "cOMSUMDataGridViewTextBoxColumn";
            this.cOMSUMDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOMSUMDataGridViewTextBoxColumn.Visible = false;
            // 
            // pAYTYPEDataGridViewTextBoxColumn
            // 
            this.pAYTYPEDataGridViewTextBoxColumn.DataPropertyName = "PAYTYPE";
            this.pAYTYPEDataGridViewTextBoxColumn.HeaderText = "PAYTYPE";
            this.pAYTYPEDataGridViewTextBoxColumn.Name = "pAYTYPEDataGridViewTextBoxColumn";
            this.pAYTYPEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pAYTYPEDataGridViewTextBoxColumn.Visible = false;
            // 
            // pODataGridViewTextBoxColumn
            // 
            this.pODataGridViewTextBoxColumn.DataPropertyName = "PO";
            this.pODataGridViewTextBoxColumn.HeaderText = "PO";
            this.pODataGridViewTextBoxColumn.Name = "pODataGridViewTextBoxColumn";
            this.pODataGridViewTextBoxColumn.ReadOnly = true;
            this.pODataGridViewTextBoxColumn.Visible = false;
            // 
            // mESDataGridViewTextBoxColumn
            // 
            this.mESDataGridViewTextBoxColumn.DataPropertyName = "MES";
            this.mESDataGridViewTextBoxColumn.HeaderText = "MES";
            this.mESDataGridViewTextBoxColumn.Name = "mESDataGridViewTextBoxColumn";
            this.mESDataGridViewTextBoxColumn.ReadOnly = true;
            this.mESDataGridViewTextBoxColumn.Visible = false;
            // 
            // cOUVALBDataGridViewTextBoxColumn
            // 
            this.cOUVALBDataGridViewTextBoxColumn.DataPropertyName = "COU_VAL_B";
            this.cOUVALBDataGridViewTextBoxColumn.HeaderText = "COU_VAL_B";
            this.cOUVALBDataGridViewTextBoxColumn.Name = "cOUVALBDataGridViewTextBoxColumn";
            this.cOUVALBDataGridViewTextBoxColumn.ReadOnly = true;
            this.cOUVALBDataGridViewTextBoxColumn.Visible = false;
            // 
            // panelProgress
            // 
            this.panelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProgress.Controls.Add(this.labelProgress);
            this.panelProgress.Controls.Add(this.progressBar);
            this.panelProgress.Location = new System.Drawing.Point(123, 175);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(179, 36);
            this.panelProgress.TabIndex = 11;
            this.panelProgress.Visible = false;
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProgress.Location = new System.Drawing.Point(0, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(179, 22);
            this.labelProgress.TabIndex = 1;
            this.labelProgress.Text = "Загрузка";
            this.labelProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(0, 21);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(179, 15);
            this.progressBar.TabIndex = 0;
            // 
            // labelPeriod
            // 
            this.labelPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(308, 184);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(45, 13);
            this.labelPeriod.TabIndex = 8;
            this.labelPeriod.Text = "Период";
            this.labelPeriod.Visible = false;
            // 
            // backgroundWorkerCatch
            // 
            this.backgroundWorkerCatch.WorkerReportsProgress = true;
            this.backgroundWorkerCatch.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCatch_DoWork);
            this.backgroundWorkerCatch.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerCatch_RunWorkerCompleted);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMonth.FormatString = "MMMM yyyy";
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Location = new System.Drawing.Point(359, 181);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(105, 21);
            this.comboBoxMonth.TabIndex = 9;
            this.comboBoxMonth.Visible = false;
            // 
            // toolStripMenuItemDel
            // 
            this.toolStripMenuItemDel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemDel.Image")));
            this.toolStripMenuItemDel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItemDel.Name = "toolStripMenuItemDel";
            this.toolStripMenuItemDel.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItemDel.Text = "Удалить";
            this.toolStripMenuItemDel.Click += new System.EventHandler(this.toolStripMenuItemDel_Click);
            // 
            // toolStripMenuItemCancel
            // 
            this.toolStripMenuItemCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCancel.Image")));
            this.toolStripMenuItemCancel.Name = "toolStripMenuItemCancel";
            this.toolStripMenuItemCancel.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItemCancel.Text = "Отменить";
            // 
            // contextMenuStripImport
            // 
            this.contextMenuStripImport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCatch,
            this.toolStripMenuItemCancel,
            this.toolStripMenuItemDel});
            this.contextMenuStripImport.Name = "contextMenuStripImport";
            this.contextMenuStripImport.Size = new System.Drawing.Size(129, 70);
            // 
            // toolStripMenuItemCatch
            // 
            this.toolStripMenuItemCatch.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCatch.Image")));
            this.toolStripMenuItemCatch.Name = "toolStripMenuItemCatch";
            this.toolStripMenuItemCatch.Size = new System.Drawing.Size(128, 22);
            this.toolStripMenuItemCatch.Text = "Провести";
            this.toolStripMenuItemCatch.Click += new System.EventHandler(this.toolStripMenuItemCatch_Click);
            // 
            // oPERATORDataGridViewTextBoxColumn
            // 
            this.oPERATORDataGridViewTextBoxColumn.DataPropertyName = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn.HeaderText = "OPERATOR";
            this.oPERATORDataGridViewTextBoxColumn.Name = "oPERATORDataGridViewTextBoxColumn";
            this.oPERATORDataGridViewTextBoxColumn.ReadOnly = true;
            this.oPERATORDataGridViewTextBoxColumn.Visible = false;
            // 
            // nUMOPPCDataGridViewTextBoxColumn
            // 
            this.nUMOPPCDataGridViewTextBoxColumn.DataPropertyName = "NUMOP_PC";
            this.nUMOPPCDataGridViewTextBoxColumn.HeaderText = "NUMOP_PC";
            this.nUMOPPCDataGridViewTextBoxColumn.Name = "nUMOPPCDataGridViewTextBoxColumn";
            this.nUMOPPCDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMOPPCDataGridViewTextBoxColumn.Visible = false;
            // 
            // nUMOPDataGridViewTextBoxColumn
            // 
            this.nUMOPDataGridViewTextBoxColumn.DataPropertyName = "NUMOP";
            this.nUMOPDataGridViewTextBoxColumn.HeaderText = "NUMOP";
            this.nUMOPDataGridViewTextBoxColumn.Name = "nUMOPDataGridViewTextBoxColumn";
            this.nUMOPDataGridViewTextBoxColumn.ReadOnly = true;
            this.nUMOPDataGridViewTextBoxColumn.Visible = false;
            // 
            // sUMTOPAYDataGridViewTextBoxColumn
            // 
            this.sUMTOPAYDataGridViewTextBoxColumn.DataPropertyName = "SUM_TO_PAY";
            this.sUMTOPAYDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.sUMTOPAYDataGridViewTextBoxColumn.Name = "sUMTOPAYDataGridViewTextBoxColumn";
            this.sUMTOPAYDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUMTOPAYDataGridViewTextBoxColumn.Width = 50;
            // 
            // pUNKTDataGridViewTextBoxColumn
            // 
            this.pUNKTDataGridViewTextBoxColumn.DataPropertyName = "PUNKT";
            this.pUNKTDataGridViewTextBoxColumn.HeaderText = "Пункт";
            this.pUNKTDataGridViewTextBoxColumn.Name = "pUNKTDataGridViewTextBoxColumn";
            this.pUNKTDataGridViewTextBoxColumn.ReadOnly = true;
            this.pUNKTDataGridViewTextBoxColumn.Width = 80;
            // 
            // pLPDATEDataGridViewTextBoxColumn
            // 
            this.pLPDATEDataGridViewTextBoxColumn.DataPropertyName = "PLP_DATE";
            this.pLPDATEDataGridViewTextBoxColumn.HeaderText = "PLP_DATE";
            this.pLPDATEDataGridViewTextBoxColumn.Name = "pLPDATEDataGridViewTextBoxColumn";
            this.pLPDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pLPDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // nPLPDataGridViewTextBoxColumn
            // 
            this.nPLPDataGridViewTextBoxColumn.DataPropertyName = "NPLP";
            this.nPLPDataGridViewTextBoxColumn.HeaderText = "NPLP";
            this.nPLPDataGridViewTextBoxColumn.Name = "nPLPDataGridViewTextBoxColumn";
            this.nPLPDataGridViewTextBoxColumn.ReadOnly = true;
            this.nPLPDataGridViewTextBoxColumn.Visible = false;
            // 
            // pROCDATEDataGridViewTextBoxColumn
            // 
            this.pROCDATEDataGridViewTextBoxColumn.DataPropertyName = "PROC_DATE";
            this.pROCDATEDataGridViewTextBoxColumn.HeaderText = "PROC_DATE";
            this.pROCDATEDataGridViewTextBoxColumn.Name = "pROCDATEDataGridViewTextBoxColumn";
            this.pROCDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROCDATEDataGridViewTextBoxColumn.Visible = false;
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            this.aDDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDDRESSDataGridViewTextBoxColumn.Width = 130;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Width = 130;
            // 
            // nLCDataGridViewTextBoxColumn
            // 
            this.nLCDataGridViewTextBoxColumn.DataPropertyName = "N_LC";
            this.nLCDataGridViewTextBoxColumn.HeaderText = "Л/счет";
            this.nLCDataGridViewTextBoxColumn.Name = "nLCDataGridViewTextBoxColumn";
            this.nLCDataGridViewTextBoxColumn.ReadOnly = true;
            this.nLCDataGridViewTextBoxColumn.Width = 60;
            // 
            // dataGridViewDBF
            // 
            this.dataGridViewDBF.AllowUserToAddRows = false;
            this.dataGridViewDBF.AllowUserToDeleteRows = false;
            this.dataGridViewDBF.AllowUserToResizeRows = false;
            this.dataGridViewDBF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDBF.AutoGenerateColumns = false;
            this.dataGridViewDBF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nLCDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.sUMTOPAYDataGridViewTextBoxColumn,
            this.pUNKTDataGridViewTextBoxColumn,
            this.pLPDATEDataGridViewTextBoxColumn,
            this.nPLPDataGridViewTextBoxColumn,
            this.pROCDATEDataGridViewTextBoxColumn,
            this.nUMOPDataGridViewTextBoxColumn,
            this.nUMOPPCDataGridViewTextBoxColumn,
            this.oPERATORDataGridViewTextBoxColumn,
            this.cOMSUMDataGridViewTextBoxColumn,
            this.pAYTYPEDataGridViewTextBoxColumn,
            this.pODataGridViewTextBoxColumn,
            this.mESDataGridViewTextBoxColumn,
            this.cOUVALBDataGridViewTextBoxColumn,
            this.cOUVALSDataGridViewTextBoxColumn,
            this.kWTDataGridViewTextBoxColumn});
            this.dataGridViewDBF.ContextMenuStrip = this.contextMenuStripCopy;
            this.dataGridViewDBF.DataMember = "TableDBF";
            this.dataGridViewDBF.DataSource = this.dataSetDBF;
            this.dataGridViewDBF.Location = new System.Drawing.Point(0, 215);
            this.dataGridViewDBF.Name = "dataGridViewDBF";
            this.dataGridViewDBF.ReadOnly = true;
            this.dataGridViewDBF.RowHeadersVisible = false;
            this.dataGridViewDBF.Size = new System.Drawing.Size(477, 170);
            this.dataGridViewDBF.TabIndex = 10;
            // 
            // backgroundWorkerCancel
            // 
            this.backgroundWorkerCancel.WorkerReportsProgress = true;
            // 
            // colDirectory
            // 
            this.colDirectory.HeaderText = "Папка";
            this.colDirectory.Name = "colDirectory";
            this.colDirectory.ReadOnly = true;
            this.colDirectory.Width = 300;
            // 
            // colFileName
            // 
            this.colFileName.HeaderText = "Имя файла";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            // 
            // OK
            // 
            this.OK.HeaderText = "";
            this.OK.Name = "OK";
            this.OK.ReadOnly = true;
            this.OK.Width = 40;
            // 
            // colPackPB
            // 
            this.colPackPB.HeaderText = "Пачка ПБ";
            this.colPackPB.Name = "colPackPB";
            this.colPackPB.ReadOnly = true;
            this.colPackPB.Visible = false;
            // 
            // colPackLB
            // 
            this.colPackLB.HeaderText = "Пачка ЛБ";
            this.colPackLB.Name = "colPackLB";
            this.colPackLB.ReadOnly = true;
            this.colPackLB.Visible = false;
            // 
            // colcodePackPB
            // 
            this.colcodePackPB.HeaderText = "codePackPB";
            this.colcodePackPB.Name = "colcodePackPB";
            this.colcodePackPB.ReadOnly = true;
            this.colcodePackPB.Visible = false;
            this.colcodePackPB.Width = 50;
            // 
            // colCodePackLB
            // 
            this.colCodePackLB.HeaderText = "codePackLB";
            this.colCodePackLB.Name = "colCodePackLB";
            this.colCodePackLB.ReadOnly = true;
            this.colCodePackLB.Visible = false;
            // 
            // FormSBROpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 385);
            this.Controls.Add(this.dataGridViewFiles);
            this.Controls.Add(this.buttonAddFiles);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.dataGridViewDBF);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSBROpl";
            this.Text = "Загрузка оплаты из СБР";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.contextMenuStripCopy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDBF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableDBF)).EndInit();
            this.panelProgress.ResumeLayout(false);
            this.contextMenuStripImport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
        private System.Windows.Forms.OpenFileDialog openFileDialogDBF;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCopy;
        private System.Data.DataSet dataSetDBF;
        private System.Data.DataTable dataTableDBF;
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
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn kWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUVALSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMSUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAYTYPEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOUVALBDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelPeriod;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCatch;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCancel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripImport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPERATORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMOPPCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nUMOPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUMTOPAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUNKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLPDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nPLPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROCDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nLCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridViewDBF;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirectory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcodePackPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodePackLB;
    }
}