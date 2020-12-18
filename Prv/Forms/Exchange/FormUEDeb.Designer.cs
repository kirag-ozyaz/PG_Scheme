namespace Prv.Forms.Exchange
{
    partial class FormUEDeb
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUEDeb));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainerDeb = new System.Windows.Forms.SplitContainer();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.ColumnFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYear = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnMonth = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnPrig = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnCatch = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStripDeb = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpenFiles = new System.Windows.Forms.ToolStripButton();
            this.statusStripDeb = new System.Windows.Forms.StatusStrip();
            this.statusLabelFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataSetDeb = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
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
            this.openFileDialogDeb = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorkerImpSQL = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerLoadDBF = new System.ComponentModel.BackgroundWorker();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.progressBarEndLess = new ControlsLbr.ProgressBarEndLess();
            this.nOMTARIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECEIPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iTOGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOGOVORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sETIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gORODOKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewDBF = new System.Windows.Forms.DataGridView();
            this.splitContainerDeb.Panel1.SuspendLayout();
            this.splitContainerDeb.Panel2.SuspendLayout();
            this.splitContainerDeb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.toolStripDeb.SuspendLayout();
            this.statusStripDeb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDeb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            this.panelProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBF)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerDeb
            // 
            this.splitContainerDeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDeb.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDeb.Name = "splitContainerDeb";
            this.splitContainerDeb.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDeb.Panel1
            // 
            this.splitContainerDeb.Panel1.Controls.Add(this.dataGridViewFiles);
            this.splitContainerDeb.Panel1.Controls.Add(this.toolStripDeb);
            // 
            // splitContainerDeb.Panel2
            // 
            this.splitContainerDeb.Panel2.Controls.Add(this.statusStripDeb);
            this.splitContainerDeb.Panel2.Controls.Add(this.dataGridViewDBF);
            this.splitContainerDeb.Size = new System.Drawing.Size(800, 474);
            this.splitContainerDeb.SplitterDistance = 313;
            this.splitContainerDeb.TabIndex = 0;
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFile,
            this.ColumnYear,
            this.ColumnMonth,
            this.ColumnPrig,
            this.ColumnCatch});
            this.dataGridViewFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFiles.Location = new System.Drawing.Point(0, 25);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.RowHeadersWidth = 10;
            this.dataGridViewFiles.Size = new System.Drawing.Size(800, 288);
            this.dataGridViewFiles.TabIndex = 17;
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
            // ColumnYear
            // 
            dataGridViewCellStyle4.Format = "MMMM yyyy";
            this.ColumnYear.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnYear.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColumnYear.HeaderText = "Год";
            this.ColumnYear.Name = "ColumnYear";
            this.ColumnYear.Width = 70;
            // 
            // ColumnMonth
            // 
            this.ColumnMonth.HeaderText = "Месяц";
            this.ColumnMonth.Items.AddRange(new object[] {
            "январь",
            "февраль",
            "март",
            "апрель",
            "май",
            "июнь",
            "июль",
            "август",
            "сентябрь",
            "октябрь",
            "ноябрь",
            "декабрь"});
            this.ColumnMonth.Name = "ColumnMonth";
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
            // ColumnCatch
            // 
            this.ColumnCatch.HeaderText = "Провести";
            this.ColumnCatch.Name = "ColumnCatch";
            this.ColumnCatch.Text = "Провести";
            this.ColumnCatch.Width = 60;
            // 
            // toolStripDeb
            // 
            this.toolStripDeb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpenFiles});
            this.toolStripDeb.Location = new System.Drawing.Point(0, 0);
            this.toolStripDeb.Name = "toolStripDeb";
            this.toolStripDeb.Size = new System.Drawing.Size(800, 25);
            this.toolStripDeb.TabIndex = 16;
            this.toolStripDeb.Text = "toolStrip1";
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
            // statusStripDeb
            // 
            this.statusStripDeb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelFile});
            this.statusStripDeb.Location = new System.Drawing.Point(0, 135);
            this.statusStripDeb.Name = "statusStripDeb";
            this.statusStripDeb.Size = new System.Drawing.Size(800, 22);
            this.statusStripDeb.TabIndex = 17;
            this.statusStripDeb.Text = "statusStrip1";
            // 
            // statusLabelFile
            // 
            this.statusLabelFile.Name = "statusLabelFile";
            this.statusLabelFile.Size = new System.Drawing.Size(785, 17);
            this.statusLabelFile.Spring = true;
            this.statusLabelFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusLabelFile.ToolTipText = "Выбранный файл";
            // 
            // dataSetDeb
            // 
            this.dataSetDeb.DataSetName = "NewDataSet";
            this.dataSetDeb.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10});
            this.dataTable1.TableName = "TableDeb";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "GORODOK";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "SETI";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "DOGOVOR";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "FIO";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "ADRESS";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "TIP";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "ITOG";
            this.dataColumn7.DataType = typeof(decimal);
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "DATA_D";
            this.dataColumn8.DataType = typeof(System.DateTime);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "RECEIPT";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "NOMTARIF";
            this.dataColumn10.DataType = typeof(decimal);
            // 
            // openFileDialogDeb
            // 
            this.openFileDialogDeb.Filter = "dbf files (*.dbf)|*.dbf|All files (*.*)|*.*";
            this.openFileDialogDeb.Multiselect = true;
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
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelProgress.Controls.Add(this.progressBar);
            this.panelProgress.Controls.Add(this.labelProgress);
            this.panelProgress.Controls.Add(this.progressBarEndLess);
            this.panelProgress.Location = new System.Drawing.Point(263, 204);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(274, 67);
            this.panelProgress.TabIndex = 16;
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
            // nOMTARIFDataGridViewTextBoxColumn
            // 
            this.nOMTARIFDataGridViewTextBoxColumn.DataPropertyName = "NOMTARIF";
            this.nOMTARIFDataGridViewTextBoxColumn.HeaderText = "NOMTARIF";
            this.nOMTARIFDataGridViewTextBoxColumn.Name = "nOMTARIFDataGridViewTextBoxColumn";
            this.nOMTARIFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rECEIPTDataGridViewTextBoxColumn
            // 
            this.rECEIPTDataGridViewTextBoxColumn.DataPropertyName = "RECEIPT";
            this.rECEIPTDataGridViewTextBoxColumn.HeaderText = "RECEIPT";
            this.rECEIPTDataGridViewTextBoxColumn.Name = "rECEIPTDataGridViewTextBoxColumn";
            this.rECEIPTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATADDataGridViewTextBoxColumn
            // 
            this.dATADDataGridViewTextBoxColumn.DataPropertyName = "DATA_D";
            this.dATADDataGridViewTextBoxColumn.HeaderText = "DATA_D";
            this.dATADDataGridViewTextBoxColumn.Name = "dATADDataGridViewTextBoxColumn";
            this.dATADDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iTOGDataGridViewTextBoxColumn
            // 
            this.iTOGDataGridViewTextBoxColumn.DataPropertyName = "ITOG";
            this.iTOGDataGridViewTextBoxColumn.HeaderText = "ITOG";
            this.iTOGDataGridViewTextBoxColumn.Name = "iTOGDataGridViewTextBoxColumn";
            this.iTOGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tIPDataGridViewTextBoxColumn
            // 
            this.tIPDataGridViewTextBoxColumn.DataPropertyName = "TIP";
            this.tIPDataGridViewTextBoxColumn.HeaderText = "TIP";
            this.tIPDataGridViewTextBoxColumn.Name = "tIPDataGridViewTextBoxColumn";
            this.tIPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDRESSDataGridViewTextBoxColumn
            // 
            this.aDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADRESS";
            this.aDRESSDataGridViewTextBoxColumn.HeaderText = "ADRESS";
            this.aDRESSDataGridViewTextBoxColumn.Name = "aDRESSDataGridViewTextBoxColumn";
            this.aDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOGOVORDataGridViewTextBoxColumn
            // 
            this.dOGOVORDataGridViewTextBoxColumn.DataPropertyName = "DOGOVOR";
            this.dOGOVORDataGridViewTextBoxColumn.HeaderText = "DOGOVOR";
            this.dOGOVORDataGridViewTextBoxColumn.Name = "dOGOVORDataGridViewTextBoxColumn";
            this.dOGOVORDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sETIDataGridViewTextBoxColumn
            // 
            this.sETIDataGridViewTextBoxColumn.DataPropertyName = "SETI";
            this.sETIDataGridViewTextBoxColumn.HeaderText = "SETI";
            this.sETIDataGridViewTextBoxColumn.Name = "sETIDataGridViewTextBoxColumn";
            this.sETIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gORODOKDataGridViewTextBoxColumn
            // 
            this.gORODOKDataGridViewTextBoxColumn.DataPropertyName = "GORODOK";
            this.gORODOKDataGridViewTextBoxColumn.HeaderText = "GORODOK";
            this.gORODOKDataGridViewTextBoxColumn.Name = "gORODOKDataGridViewTextBoxColumn";
            this.gORODOKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewDBF
            // 
            this.dataGridViewDBF.AllowUserToAddRows = false;
            this.dataGridViewDBF.AllowUserToDeleteRows = false;
            this.dataGridViewDBF.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewDBF.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDBF.AutoGenerateColumns = false;
            this.dataGridViewDBF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDBF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gORODOKDataGridViewTextBoxColumn,
            this.sETIDataGridViewTextBoxColumn,
            this.dOGOVORDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.aDRESSDataGridViewTextBoxColumn,
            this.tIPDataGridViewTextBoxColumn,
            this.iTOGDataGridViewTextBoxColumn,
            this.dATADDataGridViewTextBoxColumn,
            this.rECEIPTDataGridViewTextBoxColumn,
            this.nOMTARIFDataGridViewTextBoxColumn});
            this.dataGridViewDBF.DataMember = "TableDeb";
            this.dataGridViewDBF.DataSource = this.dataSetDeb;
            this.dataGridViewDBF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDBF.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDBF.Name = "dataGridViewDBF";
            this.dataGridViewDBF.ReadOnly = true;
            this.dataGridViewDBF.RowHeadersVisible = false;
            this.dataGridViewDBF.Size = new System.Drawing.Size(800, 157);
            this.dataGridViewDBF.TabIndex = 18;
            // 
            // FormUEDeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.splitContainerDeb);
            this.Name = "FormUEDeb";
            this.Text = "Загрузка дебиторки из УЭ";
            this.Load += new System.EventHandler(this.FormUEDeb_Load);
            this.splitContainerDeb.Panel1.ResumeLayout(false);
            this.splitContainerDeb.Panel1.PerformLayout();
            this.splitContainerDeb.Panel2.ResumeLayout(false);
            this.splitContainerDeb.Panel2.PerformLayout();
            this.splitContainerDeb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.toolStripDeb.ResumeLayout(false);
            this.toolStripDeb.PerformLayout();
            this.statusStripDeb.ResumeLayout(false);
            this.statusStripDeb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDeb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            this.panelProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDBF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerDeb;
        private System.Windows.Forms.ToolStrip toolStripDeb;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpenFiles;
        private System.Windows.Forms.StatusStrip statusStripDeb;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelFile;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialogDeb;
        private System.ComponentModel.BackgroundWorker backgroundWorkerImpSQL;
        private System.ComponentModel.BackgroundWorker backgroundWorkerLoadDBF;
        private System.Data.DataSet dataSetDeb;
        private System.Data.DataTable dataTable1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFile;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnYear;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnMonth;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnPrig;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnCatch;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProgress;
        private ControlsLbr.ProgressBarEndLess progressBarEndLess;
        private System.Windows.Forms.DataGridView dataGridViewDBF;
        private System.Windows.Forms.DataGridViewTextBoxColumn gORODOKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sETIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOGOVORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iTOGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECEIPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMTARIFDataGridViewTextBoxColumn;

    }
}