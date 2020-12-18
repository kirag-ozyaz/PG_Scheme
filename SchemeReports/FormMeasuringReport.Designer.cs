using ControlsLbr;
using ControlsLbr.DataGridViewExcelFilter;
using Microsoft.Reporting.WinForms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SchemeReports
{
    partial class FormMeasuringReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeasuringReport));
            this.reportViewer0 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBarEndLess = new ControlsLbr.ProgressBarEndLess();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewTrans = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.roottpDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.cellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.transDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.measurementReport1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetScheme = new SchemeReports.DataSetScheme();
            this.dataGridViewCab = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.roottpDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.cellDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kLVLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ploadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.measurementReport2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.экспортТаблицыВExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelReport = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGrid = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmbYear = new System.Windows.Forms.ToolStripComboBox();
            this.tsbReport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolLabelTypeSchema = new System.Windows.Forms.ToolStripLabel();
            this.toolCmbTypeSchema = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.panelProgress.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementReport1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementReport2BindingSource)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panelReport.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer0
            // 
            this.reportViewer0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer0.Location = new System.Drawing.Point(0, 0);
            this.reportViewer0.Name = "reportViewer0";
            this.reportViewer0.Size = new System.Drawing.Size(1169, 475);
            this.reportViewer0.TabIndex = 0;
            // 
            // panelProgress
            // 
            this.panelProgress.BackColor = System.Drawing.SystemColors.Control;
            this.panelProgress.Controls.Add(this.label3);
            this.panelProgress.Controls.Add(this.progressBarEndLess);
            this.panelProgress.Location = new System.Drawing.Point(54, 139);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(431, 74);
            this.panelProgress.TabIndex = 8;
            this.panelProgress.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Подождите... Идет загрузка из базы";
            // 
            // progressBarEndLess
            // 
            this.progressBarEndLess.AutoProgressSpeed = 130;
            this.progressBarEndLess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBarEndLess.Location = new System.Drawing.Point(0, 39);
            this.progressBarEndLess.Name = "progressBarEndLess";
            this.progressBarEndLess.NormalImage = global::SchemeReports.Properties.Resources.NormalImage;
            this.progressBarEndLess.PointImage = global::SchemeReports.Properties.Resources.PointImage;
            this.progressBarEndLess.Position = 0;
            this.progressBarEndLess.ProgressBoxStyle = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessBoxStyleConstants.SolidSameSize;
            this.progressBarEndLess.ProgressStyle = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessStyleConstants.LeftAndRight;
            this.progressBarEndLess.ProgressType = ControlsLbr.ProgressBarEndLess.ProgressBarEndLessTypeConstants.GraphicType;
            this.progressBarEndLess.Size = new System.Drawing.Size(431, 35);
            this.progressBarEndLess.TabIndex = 5;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.splitContainer1);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 25);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(1169, 475);
            this.panelDataGrid.TabIndex = 9;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewTrans);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewCab);
            this.splitContainer1.Size = new System.Drawing.Size(1169, 475);
            this.splitContainer1.SplitterDistance = 234;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridViewTrans
            // 
            this.dataGridViewTrans.AllowUserToAddRows = false;
            this.dataGridViewTrans.AllowUserToDeleteRows = false;
            this.dataGridViewTrans.AutoGenerateColumns = false;
            this.dataGridViewTrans.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roottpDataGridViewTextBoxColumn,
            this.cellDataGridViewTextBoxColumn,
            this.tpDataGridViewTextBoxColumn,
            this.transDataGridViewTextBoxColumn,
            this.pkVADataGridViewTextBoxColumn,
            this.aDataGridViewTextBoxColumn,
            this.bDataGridViewTextBoxColumn,
            this.cDataGridViewTextBoxColumn,
            this.iDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.dispDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridViewTrans.DataSource = this.measurementReport1BindingSource;
            this.dataGridViewTrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrans.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTrans.Name = "dataGridViewTrans";
            this.dataGridViewTrans.ReadOnly = true;
            this.dataGridViewTrans.RowHeadersWidth = 21;
            this.dataGridViewTrans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTrans.Size = new System.Drawing.Size(1169, 234);
            this.dataGridViewTrans.TabIndex = 0;
            // 
            // roottpDataGridViewTextBoxColumn
            // 
            this.roottpDataGridViewTextBoxColumn.DataPropertyName = "roottp";
            this.roottpDataGridViewTextBoxColumn.HeaderText = "";
            this.roottpDataGridViewTextBoxColumn.Name = "roottpDataGridViewTextBoxColumn";
            this.roottpDataGridViewTextBoxColumn.ReadOnly = true;
            this.roottpDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roottpDataGridViewTextBoxColumn.Width = 200;
            // 
            // cellDataGridViewTextBoxColumn
            // 
            this.cellDataGridViewTextBoxColumn.DataPropertyName = "cell";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "F0";
            this.cellDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cellDataGridViewTextBoxColumn.HeaderText = "Ячейка";
            this.cellDataGridViewTextBoxColumn.Name = "cellDataGridViewTextBoxColumn";
            this.cellDataGridViewTextBoxColumn.ReadOnly = true;
            this.cellDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tpDataGridViewTextBoxColumn
            // 
            this.tpDataGridViewTextBoxColumn.DataPropertyName = "tp";
            this.tpDataGridViewTextBoxColumn.HeaderText = "№ ТП";
            this.tpDataGridViewTextBoxColumn.Name = "tpDataGridViewTextBoxColumn";
            this.tpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transDataGridViewTextBoxColumn
            // 
            this.transDataGridViewTextBoxColumn.DataPropertyName = "trans";
            this.transDataGridViewTextBoxColumn.HeaderText = "Тр-р";
            this.transDataGridViewTextBoxColumn.Name = "transDataGridViewTextBoxColumn";
            this.transDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pkVADataGridViewTextBoxColumn
            // 
            this.pkVADataGridViewTextBoxColumn.DataPropertyName = "PkVA";
            this.pkVADataGridViewTextBoxColumn.HeaderText = "Р, кВА";
            this.pkVADataGridViewTextBoxColumn.Name = "pkVADataGridViewTextBoxColumn";
            this.pkVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aDataGridViewTextBoxColumn
            // 
            this.aDataGridViewTextBoxColumn.DataPropertyName = "A";
            this.aDataGridViewTextBoxColumn.HeaderText = "A";
            this.aDataGridViewTextBoxColumn.Name = "aDataGridViewTextBoxColumn";
            this.aDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDataGridViewTextBoxColumn
            // 
            this.bDataGridViewTextBoxColumn.DataPropertyName = "B";
            this.bDataGridViewTextBoxColumn.HeaderText = "B";
            this.bDataGridViewTextBoxColumn.Name = "bDataGridViewTextBoxColumn";
            this.bDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cDataGridViewTextBoxColumn
            // 
            this.cDataGridViewTextBoxColumn.DataPropertyName = "C";
            this.cDataGridViewTextBoxColumn.HeaderText = "C";
            this.cDataGridViewTextBoxColumn.Name = "cDataGridViewTextBoxColumn";
            this.cDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDataGridViewTextBoxColumn
            // 
            this.iDataGridViewTextBoxColumn.DataPropertyName = "I";
            this.iDataGridViewTextBoxColumn.HeaderText = "Сумма Imax, A";
            this.iDataGridViewTextBoxColumn.Name = "iDataGridViewTextBoxColumn";
            this.iDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDataGridViewTextBoxColumn.Width = 110;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Время";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dispDataGridViewTextBoxColumn
            // 
            this.dispDataGridViewTextBoxColumn.DataPropertyName = "Disp";
            this.dispDataGridViewTextBoxColumn.HeaderText = "Диспетчер";
            this.dispDataGridViewTextBoxColumn.Name = "dispDataGridViewTextBoxColumn";
            this.dispDataGridViewTextBoxColumn.ReadOnly = true;
            this.dispDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // measurementReport1BindingSource
            // 
            this.measurementReport1BindingSource.DataMember = "MeasurementReport1";
            this.measurementReport1BindingSource.DataSource = this.dataSetScheme;
            // 
            // dataSetScheme
            // 
            this.dataSetScheme.DataSetName = "DataSetScheme";
            this.dataSetScheme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewCab
            // 
            this.dataGridViewCab.AllowUserToAddRows = false;
            this.dataGridViewCab.AllowUserToDeleteRows = false;
            this.dataGridViewCab.AutoGenerateColumns = false;
            this.dataGridViewCab.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roottpDataGridViewTextBoxColumn1,
            this.cellDataGridViewTextBoxColumn1,
            this.kLVLDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.ploadDataGridViewTextBoxColumn,
            this.measurementDataGridViewTextBoxColumn,
            this.loadingDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn1});
            this.dataGridViewCab.DataSource = this.measurementReport2BindingSource;
            this.dataGridViewCab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCab.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCab.Name = "dataGridViewCab";
            this.dataGridViewCab.ReadOnly = true;
            this.dataGridViewCab.RowHeadersWidth = 21;
            this.dataGridViewCab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCab.Size = new System.Drawing.Size(1169, 237);
            this.dataGridViewCab.TabIndex = 0;
            // 
            // roottpDataGridViewTextBoxColumn1
            // 
            this.roottpDataGridViewTextBoxColumn1.DataPropertyName = "roottp";
            this.roottpDataGridViewTextBoxColumn1.HeaderText = "";
            this.roottpDataGridViewTextBoxColumn1.Name = "roottpDataGridViewTextBoxColumn1";
            this.roottpDataGridViewTextBoxColumn1.ReadOnly = true;
            this.roottpDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roottpDataGridViewTextBoxColumn1.Width = 200;
            // 
            // cellDataGridViewTextBoxColumn1
            // 
            this.cellDataGridViewTextBoxColumn1.DataPropertyName = "cell";
            this.cellDataGridViewTextBoxColumn1.HeaderText = "Ячейка";
            this.cellDataGridViewTextBoxColumn1.Name = "cellDataGridViewTextBoxColumn1";
            this.cellDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kLVLDataGridViewTextBoxColumn
            // 
            this.kLVLDataGridViewTextBoxColumn.DataPropertyName = "KLVL";
            this.kLVLDataGridViewTextBoxColumn.HeaderText = "КЛ, ВЛ";
            this.kLVLDataGridViewTextBoxColumn.Name = "kLVLDataGridViewTextBoxColumn";
            this.kLVLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Сечение";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            this.sectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ploadDataGridViewTextBoxColumn
            // 
            this.ploadDataGridViewTextBoxColumn.DataPropertyName = "pload";
            this.ploadDataGridViewTextBoxColumn.HeaderText = "Доп. нагрузка";
            this.ploadDataGridViewTextBoxColumn.Name = "ploadDataGridViewTextBoxColumn";
            this.ploadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // measurementDataGridViewTextBoxColumn
            // 
            this.measurementDataGridViewTextBoxColumn.DataPropertyName = "measurement";
            this.measurementDataGridViewTextBoxColumn.HeaderText = "Замеры";
            this.measurementDataGridViewTextBoxColumn.Name = "measurementDataGridViewTextBoxColumn";
            this.measurementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loadingDataGridViewTextBoxColumn
            // 
            this.loadingDataGridViewTextBoxColumn.DataPropertyName = "loading";
            this.loadingDataGridViewTextBoxColumn.HeaderText = "Загрузка";
            this.loadingDataGridViewTextBoxColumn.Name = "loadingDataGridViewTextBoxColumn";
            this.loadingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn1.HeaderText = "Коментарий";
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            this.commentDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // measurementReport2BindingSource
            // 
            this.measurementReport2BindingSource.DataMember = "MeasurementReport2";
            this.measurementReport2BindingSource.DataSource = this.dataSetScheme;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортТаблицыВExcelToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 26);
            // 
            // экспортТаблицыВExcelToolStripMenuItem
            // 
            this.экспортТаблицыВExcelToolStripMenuItem.Name = "экспортТаблицыВExcelToolStripMenuItem";
            this.экспортТаблицыВExcelToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.экспортТаблицыВExcelToolStripMenuItem.Text = "Экспорт таблицы в Excel";
            this.экспортТаблицыВExcelToolStripMenuItem.Click += new System.EventHandler(this.экспортТаблицыВExcelToolStripMenuItem_Click);
            // 
            // panelReport
            // 
            this.panelReport.Controls.Add(this.reportViewer0);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Enabled = false;
            this.panelReport.Location = new System.Drawing.Point(0, 25);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(1169, 475);
            this.panelReport.TabIndex = 0;
            this.panelReport.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGrid,
            this.toolStripButtonReport,
            this.toolStripButton2,
            this.toolStripLabel1,
            this.cmbYear,
            this.tsbReport,
            this.toolStripButton1,
            this.toolLabelTypeSchema,
            this.toolCmbTypeSchema});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1169, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonGrid
            // 
            this.toolStripButtonGrid.Checked = true;
            this.toolStripButtonGrid.CheckOnClick = true;
            this.toolStripButtonGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGrid.Image = global::SchemeReports.Properties.Resources.table;
            this.toolStripButtonGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGrid.Name = "toolStripButtonGrid";
            this.toolStripButtonGrid.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGrid.Text = "Таблицы";
            this.toolStripButtonGrid.CheckedChanged += new System.EventHandler(this.toolStripButtonGrid_CheckedChanged);
            // 
            // toolStripButtonReport
            // 
            this.toolStripButtonReport.CheckOnClick = true;
            this.toolStripButtonReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReport.Image = global::SchemeReports.Properties.Resources.report_1914;
            this.toolStripButtonReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReport.Name = "toolStripButtonReport";
            this.toolStripButtonReport.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReport.Text = "Печатная форма";
            this.toolStripButtonReport.CheckedChanged += new System.EventHandler(this.toolStripButtonReport_CheckedChanged);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(26, 22);
            this.toolStripLabel1.Text = "Год";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 25);
            // 
            // tsbReport
            // 
            this.tsbReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbReport.Image = ((System.Drawing.Image)(resources.GetObject("tsbReport.Image")));
            this.tsbReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReport.Name = "tsbReport";
            this.tsbReport.Size = new System.Drawing.Size(95, 22);
            this.tsbReport.Text = "Сформировать";
            this.tsbReport.Click += new System.EventHandler(this.tsbReport_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(128, 22);
            this.toolStripButton1.Text = "Сформировать (тест)";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolLabelTypeSchema
            // 
            this.toolLabelTypeSchema.Name = "toolLabelTypeSchema";
            this.toolLabelTypeSchema.Size = new System.Drawing.Size(41, 22);
            this.toolLabelTypeSchema.Text = "Схема";
            // 
            // toolCmbTypeSchema
            // 
            this.toolCmbTypeSchema.Items.AddRange(new object[] {
            "Оперативная схема",
            "По точкам токоразделов"});
            this.toolCmbTypeSchema.Name = "toolCmbTypeSchema";
            this.toolCmbTypeSchema.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::SchemeReports.Properties.Resources.Excel;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // FormMeasuringReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 500);
            this.Controls.Add(this.panelProgress);
            this.Controls.Add(this.panelDataGrid);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMeasuringReport";
            this.Text = "Замеры";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMeasuringReport_Load);
            this.Resize += new System.EventHandler(this.FormMeasuringReport_Resize);
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            this.panelDataGrid.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementReport1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetScheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementReport2BindingSource)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelReport.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReportViewer reportViewer0;
        private Panel panelProgress;
        private Label label3;
        private ProgressBarEndLess progressBarEndLess;
        private BackgroundWorker backgroundWorker1;
        private Panel panelDataGrid;
        private SplitContainer splitContainer1;
        private Panel panelReport;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButtonGrid;
        private ToolStripButton toolStripButtonReport;
        private DataGridViewExcelFilter dataGridViewTrans;
        private DataGridViewExcelFilter dataGridViewCab;
        private BindingSource measurementReport1BindingSource;
        private DataSetScheme dataSetScheme;
        private BindingSource measurementReport2BindingSource;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem экспортТаблицыВExcelToolStripMenuItem;
        private ToolStripLabel toolStripLabel1;
        private ToolStripComboBox cmbYear;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn TemperatureD;
        private ToolStripButton tsbReport;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolLabelTypeSchema;
        private ToolStripComboBox toolCmbTypeSchema;
        private DataGridViewFilterTextBoxColumn roottpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cellDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn tpDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkVADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn aDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dispDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn roottpDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cellDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn kLVLDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ploadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn measurementDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loadingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private ToolStripButton toolStripButton2;
    }
}