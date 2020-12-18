namespace Prv.Forms.Reports
{
    partial class FormWorkControllers
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bsRepWorkController = new System.Windows.Forms.BindingSource(this.components);
            this.dsRep = new Prv.DataSets.DataSetRep();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxPeriod = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvefWork = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.panelWait = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RWRepWorkControllers = new Microsoft.Reporting.WinForms.ReportViewer();
            this.codeControllerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.abnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abnNOTkoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevKODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevItogNotLiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itogNotLiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevPlombDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plombDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevObslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevObslUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obslUEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevBezuchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezuchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezuchKWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevBezdogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezdogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bezdogKWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prevMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsRepWorkController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefWork)).BeginInit();
            this.panelWait.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsRepWorkController
            // 
            this.bsRepWorkController.DataMember = "fn_PrvRepWorkController";
            this.bsRepWorkController.DataSource = this.dsRep;
            this.bsRepWorkController.CurrentChanged += new System.EventHandler(this.bsRepWorkController_CurrentChanged);
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "DataSetRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFind,
            this.toolStripTextBoxFind,
            this.toolStripButtonFindPrev,
            this.toolStripButtonFindNext,
            this.toolStripSeparator3,
            this.toolStripButtonPrint,
            this.toolStripSeparator4,
            this.toolStripButtonExportExcel,
            this.toolStripButtonRefresh,
            this.toolStripComboBoxPeriod,
            this.toolStripSeparator5});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(623, 25);
            this.toolStripMain.TabIndex = 2;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = global::Prv.Properties.Resources.Find;
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButtonFindPrev
            // 
            this.toolStripButtonFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindPrev.Image = global::Prv.Properties.Resources.FindPrev;
            this.toolStripButtonFindPrev.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFindPrev.Name = "toolStripButtonFindPrev";
            this.toolStripButtonFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindPrev.Text = "Поиск назад";
            this.toolStripButtonFindPrev.Click += new System.EventHandler(this.toolStripButtonFindPrev_Click);
            // 
            // toolStripButtonFindNext
            // 
            this.toolStripButtonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindNext.Image = global::Prv.Properties.Resources.FindNext;
            this.toolStripButtonFindNext.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFindNext.Name = "toolStripButtonFindNext";
            this.toolStripButtonFindNext.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindNext.Text = "Поиск вперед";
            this.toolStripButtonFindNext.Click += new System.EventHandler(this.toolStripButtonFindNext_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Image = global::Prv.Properties.Resources.Print;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrint.Text = "Печать";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonExportExcel
            // 
            this.toolStripButtonExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExportExcel.Image = global::Prv.Properties.Resources.Excel;
            this.toolStripButtonExportExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonExportExcel.Name = "toolStripButtonExportExcel";
            this.toolStripButtonExportExcel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExportExcel.Text = "Экспорт в Excel";
            this.toolStripButtonExportExcel.Click += new System.EventHandler(this.toolStripButtonExportExcel_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::Prv.Properties.Resources.Refresh;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Обновить";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripComboBoxPeriod
            // 
            this.toolStripComboBoxPeriod.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxPeriod.Name = "toolStripComboBoxPeriod";
            this.toolStripComboBoxPeriod.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // dgvefWork
            // 
            this.dgvefWork.AllowUserToAddRows = false;
            this.dgvefWork.AllowUserToDeleteRows = false;
            this.dgvefWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvefWork.AutoGenerateColumns = false;
            this.dgvefWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvefWork.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeControllerDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.abnDataGridViewTextBoxColumn,
            this.abnNOTkoDataGridViewTextBoxColumn,
            this.percentDataGridViewTextBoxColumn,
            this.prevKODataGridViewTextBoxColumn,
            this.kODataGridViewTextBoxColumn,
            this.KOd,
            this.prevItogNotLiveDataGridViewTextBoxColumn,
            this.itogNotLiveDataGridViewTextBoxColumn,
            this.prevPlombDataGridViewTextBoxColumn,
            this.plombDataGridViewTextBoxColumn,
            this.prevObslDataGridViewTextBoxColumn,
            this.obslDataGridViewTextBoxColumn,
            this.prevObslUEDataGridViewTextBoxColumn,
            this.obslUEDataGridViewTextBoxColumn,
            this.prevBezuchDataGridViewTextBoxColumn,
            this.bezuchDataGridViewTextBoxColumn,
            this.bezuchKWTDataGridViewTextBoxColumn,
            this.prevBezdogDataGridViewTextBoxColumn,
            this.bezdogDataGridViewTextBoxColumn,
            this.bezdogKWTDataGridViewTextBoxColumn,
            this.prevMeterDataGridViewTextBoxColumn,
            this.meterDataGridViewTextBoxColumn});
            this.dgvefWork.DataSource = this.bsRepWorkController;
            this.dgvefWork.Location = new System.Drawing.Point(0, 29);
            this.dgvefWork.Name = "dgvefWork";
            this.dgvefWork.ReadOnly = true;
            this.dgvefWork.RowHeadersWidth = 21;
            this.dgvefWork.Size = new System.Drawing.Size(623, 138);
            this.dgvefWork.TabIndex = 3;
            // 
            // panelWait
            // 
            this.panelWait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelWait.Controls.Add(this.groupBox1);
            this.panelWait.Location = new System.Drawing.Point(162, 170);
            this.panelWait.Name = "panelWait";
            this.panelWait.Size = new System.Drawing.Size(298, 61);
            this.panelWait.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Идет формирование отчета.";
            // 
            // RWRepWorkControllers
            // 
            this.RWRepWorkControllers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSetRep";
            reportDataSource1.Value = this.bsRepWorkController;
            this.RWRepWorkControllers.LocalReport.DataSources.Add(reportDataSource1);
            this.RWRepWorkControllers.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportWorkControllers.rdlc";
            this.RWRepWorkControllers.Location = new System.Drawing.Point(0, 170);
            this.RWRepWorkControllers.Name = "RWRepWorkControllers";
            this.RWRepWorkControllers.Size = new System.Drawing.Size(623, 229);
            this.RWRepWorkControllers.TabIndex = 5;
            // 
            // codeControllerDataGridViewTextBoxColumn
            // 
            this.codeControllerDataGridViewTextBoxColumn.DataPropertyName = "CodeController";
            this.codeControllerDataGridViewTextBoxColumn.HeaderText = "CodeController";
            this.codeControllerDataGridViewTextBoxColumn.Name = "codeControllerDataGridViewTextBoxColumn";
            this.codeControllerDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeControllerDataGridViewTextBoxColumn.Visible = false;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "Ф.И.О.";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // abnDataGridViewTextBoxColumn
            // 
            this.abnDataGridViewTextBoxColumn.DataPropertyName = "Abn";
            this.abnDataGridViewTextBoxColumn.HeaderText = "Кол-во абонентов";
            this.abnDataGridViewTextBoxColumn.Name = "abnDataGridViewTextBoxColumn";
            this.abnDataGridViewTextBoxColumn.ReadOnly = true;
            this.abnDataGridViewTextBoxColumn.Width = 80;
            // 
            // abnNOTkoDataGridViewTextBoxColumn
            // 
            this.abnNOTkoDataGridViewTextBoxColumn.DataPropertyName = "abnNOTko";
            this.abnNOTkoDataGridViewTextBoxColumn.HeaderText = "Нет КО 186 дней";
            this.abnNOTkoDataGridViewTextBoxColumn.Name = "abnNOTkoDataGridViewTextBoxColumn";
            this.abnNOTkoDataGridViewTextBoxColumn.ReadOnly = true;
            this.abnNOTkoDataGridViewTextBoxColumn.Width = 80;
            // 
            // percentDataGridViewTextBoxColumn
            // 
            this.percentDataGridViewTextBoxColumn.DataPropertyName = "Percent";
            this.percentDataGridViewTextBoxColumn.HeaderText = "%";
            this.percentDataGridViewTextBoxColumn.Name = "percentDataGridViewTextBoxColumn";
            this.percentDataGridViewTextBoxColumn.ReadOnly = true;
            this.percentDataGridViewTextBoxColumn.Width = 40;
            // 
            // prevKODataGridViewTextBoxColumn
            // 
            this.prevKODataGridViewTextBoxColumn.DataPropertyName = "PrevKO";
            this.prevKODataGridViewTextBoxColumn.HeaderText = "Предыдущее кол-во КО";
            this.prevKODataGridViewTextBoxColumn.Name = "prevKODataGridViewTextBoxColumn";
            this.prevKODataGridViewTextBoxColumn.ReadOnly = true;
            this.prevKODataGridViewTextBoxColumn.Width = 80;
            // 
            // kODataGridViewTextBoxColumn
            // 
            this.kODataGridViewTextBoxColumn.DataPropertyName = "KO";
            this.kODataGridViewTextBoxColumn.HeaderText = "Текущее кол-во КО";
            this.kODataGridViewTextBoxColumn.Name = "kODataGridViewTextBoxColumn";
            this.kODataGridViewTextBoxColumn.ReadOnly = true;
            this.kODataGridViewTextBoxColumn.Width = 80;
            // 
            // KOd
            // 
            this.KOd.DataPropertyName = "KOd";
            this.KOd.HeaderText = "Текущее кол-во обойденных абонентов";
            this.KOd.Name = "KOd";
            this.KOd.ReadOnly = true;
            // 
            // prevItogNotLiveDataGridViewTextBoxColumn
            // 
            this.prevItogNotLiveDataGridViewTextBoxColumn.DataPropertyName = "PrevItogNotLive";
            this.prevItogNotLiveDataGridViewTextBoxColumn.HeaderText = "Предыдущее кол-во \"Нет допуска\"";
            this.prevItogNotLiveDataGridViewTextBoxColumn.Name = "prevItogNotLiveDataGridViewTextBoxColumn";
            this.prevItogNotLiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.prevItogNotLiveDataGridViewTextBoxColumn.Width = 80;
            // 
            // itogNotLiveDataGridViewTextBoxColumn
            // 
            this.itogNotLiveDataGridViewTextBoxColumn.DataPropertyName = "ItogNotLive";
            this.itogNotLiveDataGridViewTextBoxColumn.HeaderText = "Текущее кол-во \"Нет допуска\"";
            this.itogNotLiveDataGridViewTextBoxColumn.Name = "itogNotLiveDataGridViewTextBoxColumn";
            this.itogNotLiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.itogNotLiveDataGridViewTextBoxColumn.Width = 80;
            // 
            // prevPlombDataGridViewTextBoxColumn
            // 
            this.prevPlombDataGridViewTextBoxColumn.DataPropertyName = "PrevPlomb";
            this.prevPlombDataGridViewTextBoxColumn.HeaderText = "Предыдущее кол-во пломбировок";
            this.prevPlombDataGridViewTextBoxColumn.Name = "prevPlombDataGridViewTextBoxColumn";
            this.prevPlombDataGridViewTextBoxColumn.ReadOnly = true;
            this.prevPlombDataGridViewTextBoxColumn.Width = 80;
            // 
            // plombDataGridViewTextBoxColumn
            // 
            this.plombDataGridViewTextBoxColumn.DataPropertyName = "Plomb";
            this.plombDataGridViewTextBoxColumn.HeaderText = "Текущее кол-во пломбировок";
            this.plombDataGridViewTextBoxColumn.Name = "plombDataGridViewTextBoxColumn";
            this.plombDataGridViewTextBoxColumn.ReadOnly = true;
            this.plombDataGridViewTextBoxColumn.Width = 80;
            // 
            // prevObslDataGridViewTextBoxColumn
            // 
            this.prevObslDataGridViewTextBoxColumn.DataPropertyName = "PrevObsl";
            this.prevObslDataGridViewTextBoxColumn.HeaderText = "Предыдущее кол-во обследований";
            this.prevObslDataGridViewTextBoxColumn.Name = "prevObslDataGridViewTextBoxColumn";
            this.prevObslDataGridViewTextBoxColumn.ReadOnly = true;
            this.prevObslDataGridViewTextBoxColumn.Width = 80;
            // 
            // obslDataGridViewTextBoxColumn
            // 
            this.obslDataGridViewTextBoxColumn.DataPropertyName = "Obsl";
            this.obslDataGridViewTextBoxColumn.HeaderText = "Текущее кол-во обследований";
            this.obslDataGridViewTextBoxColumn.Name = "obslDataGridViewTextBoxColumn";
            this.obslDataGridViewTextBoxColumn.ReadOnly = true;
            this.obslDataGridViewTextBoxColumn.Width = 80;
            // 
            // prevObslUEDataGridViewTextBoxColumn
            // 
            this.prevObslUEDataGridViewTextBoxColumn.DataPropertyName = "PrevObslUE";
            this.prevObslUEDataGridViewTextBoxColumn.HeaderText = "Предыдущее кол-во обследований с УЭ";
            this.prevObslUEDataGridViewTextBoxColumn.Name = "prevObslUEDataGridViewTextBoxColumn";
            this.prevObslUEDataGridViewTextBoxColumn.ReadOnly = true;
            this.prevObslUEDataGridViewTextBoxColumn.Width = 80;
            // 
            // obslUEDataGridViewTextBoxColumn
            // 
            this.obslUEDataGridViewTextBoxColumn.DataPropertyName = "ObslUE";
            this.obslUEDataGridViewTextBoxColumn.HeaderText = "Текущее кол-во обследований с УЭ";
            this.obslUEDataGridViewTextBoxColumn.Name = "obslUEDataGridViewTextBoxColumn";
            this.obslUEDataGridViewTextBoxColumn.ReadOnly = true;
            this.obslUEDataGridViewTextBoxColumn.Width = 80;
            // 
            // prevBezuchDataGridViewTextBoxColumn
            // 
            this.prevBezuchDataGridViewTextBoxColumn.DataPropertyName = "PrevBezuch";
            this.prevBezuchDataGridViewTextBoxColumn.HeaderText = "Предыдущее кол-во Актов бузучетного потребления";
            this.prevBezuchDataGridViewTextBoxColumn.Name = "prevBezuchDataGridViewTextBoxColumn";
            this.prevBezuchDataGridViewTextBoxColumn.ReadOnly = true;
            this.prevBezuchDataGridViewTextBoxColumn.Width = 80;
            // 
            // bezuchDataGridViewTextBoxColumn
            // 
            this.bezuchDataGridViewTextBoxColumn.DataPropertyName = "Bezuch";
            this.bezuchDataGridViewTextBoxColumn.HeaderText = "Текущее кол-во Актов бузучетного потребления";
            this.bezuchDataGridViewTextBoxColumn.Name = "bezuchDataGridViewTextBoxColumn";
            this.bezuchDataGridViewTextBoxColumn.ReadOnly = true;
            this.bezuchDataGridViewTextBoxColumn.Width = 80;
            // 
            // bezuchKWTDataGridViewTextBoxColumn
            // 
            this.bezuchKWTDataGridViewTextBoxColumn.DataPropertyName = "BezuchKWT";
            this.bezuchKWTDataGridViewTextBoxColumn.HeaderText = "Акт б/у, кВт";
            this.bezuchKWTDataGridViewTextBoxColumn.Name = "bezuchKWTDataGridViewTextBoxColumn";
            this.bezuchKWTDataGridViewTextBoxColumn.ReadOnly = true;
            this.bezuchKWTDataGridViewTextBoxColumn.Width = 80;
            // 
            // prevBezdogDataGridViewTextBoxColumn
            // 
            this.prevBezdogDataGridViewTextBoxColumn.DataPropertyName = "PrevBezdog";
            this.prevBezdogDataGridViewTextBoxColumn.HeaderText = "Предыдущее кол-во Актов бездоговорного потребления";
            this.prevBezdogDataGridViewTextBoxColumn.Name = "prevBezdogDataGridViewTextBoxColumn";
            this.prevBezdogDataGridViewTextBoxColumn.ReadOnly = true;
            this.prevBezdogDataGridViewTextBoxColumn.Width = 80;
            // 
            // bezdogDataGridViewTextBoxColumn
            // 
            this.bezdogDataGridViewTextBoxColumn.DataPropertyName = "Bezdog";
            this.bezdogDataGridViewTextBoxColumn.HeaderText = "Текущее кол-во Актов бездоговорного потребления";
            this.bezdogDataGridViewTextBoxColumn.Name = "bezdogDataGridViewTextBoxColumn";
            this.bezdogDataGridViewTextBoxColumn.ReadOnly = true;
            this.bezdogDataGridViewTextBoxColumn.Width = 80;
            // 
            // bezdogKWTDataGridViewTextBoxColumn
            // 
            this.bezdogKWTDataGridViewTextBoxColumn.DataPropertyName = "BezdogKWT";
            this.bezdogKWTDataGridViewTextBoxColumn.HeaderText = "Акт б/д, кВт";
            this.bezdogKWTDataGridViewTextBoxColumn.Name = "bezdogKWTDataGridViewTextBoxColumn";
            this.bezdogKWTDataGridViewTextBoxColumn.ReadOnly = true;
            this.bezdogKWTDataGridViewTextBoxColumn.Width = 80;
            // 
            // prevMeterDataGridViewTextBoxColumn
            // 
            this.prevMeterDataGridViewTextBoxColumn.DataPropertyName = "PrevMeter";
            this.prevMeterDataGridViewTextBoxColumn.HeaderText = "Предыдущее ко-во установленных счетчиков";
            this.prevMeterDataGridViewTextBoxColumn.Name = "prevMeterDataGridViewTextBoxColumn";
            this.prevMeterDataGridViewTextBoxColumn.ReadOnly = true;
            this.prevMeterDataGridViewTextBoxColumn.Width = 80;
            // 
            // meterDataGridViewTextBoxColumn
            // 
            this.meterDataGridViewTextBoxColumn.DataPropertyName = "Meter";
            this.meterDataGridViewTextBoxColumn.HeaderText = "Текущее ко-во установленных счетчиков";
            this.meterDataGridViewTextBoxColumn.Name = "meterDataGridViewTextBoxColumn";
            this.meterDataGridViewTextBoxColumn.ReadOnly = true;
            this.meterDataGridViewTextBoxColumn.Width = 80;
            // 
            // FormWorkControllers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 400);
            this.Controls.Add(this.panelWait);
            this.Controls.Add(this.dgvefWork);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.RWRepWorkControllers);
            this.Name = "FormWorkControllers";
            this.Text = "Отчет по контролерам";
            this.Load += new System.EventHandler(this.FormWorkControllers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRepWorkController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefWork)).EndInit();
            this.panelWait.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxPeriod;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvefWork;
        private System.Windows.Forms.BindingSource bsRepWorkController;
        private DataSets.DataSetRep dsRep;
        private System.Windows.Forms.Panel panelWait;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer RWRepWorkControllers;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeControllerDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abnNOTkoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevKODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn KOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevItogNotLiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itogNotLiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevPlombDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plombDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevObslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevObslUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn obslUEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevBezuchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezuchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezuchKWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevBezdogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezdogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bezdogKWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prevMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterDataGridViewTextBoxColumn;
    }
}