using ControlsLbr.DataGridViewExcelFilter;
using FormLbr;
using System.ComponentModel;
using System.Windows.Forms;

internal partial class FormReport81 : FormBase
{
	protected override void Dispose(bool disposing)
	{
		if (disposing && this.components != null)
		{
			this.components.Dispose();
		}
		base.Dispose(disposing);
	}
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolBtnExcel = new System.Windows.Forms.ToolStripButton();
            this.toolBtnReport = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.btnReport = new System.Windows.Forms.Button();
            this.groupBoxIs81 = new System.Windows.Forms.GroupBox();
            this.rbFilterIs81 = new System.Windows.Forms.RadioButton();
            this.rbFilterAll81 = new System.Windows.Forms.RadioButton();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.dtpFilterEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFilterBeg = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFilterPeriod = new System.Windows.Forms.RadioButton();
            this.cmbFilterYear = new System.Windows.Forms.ComboBox();
            this.rbFilterYear = new System.Windows.Forms.RadioButton();
            this.toolStripFilter = new System.Windows.Forms.ToolStrip();
            this.toolBtnFilterApply = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFilterDelete = new System.Windows.Forms.ToolStripButton();
            this.dgvReport = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.numDateDocDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeDocDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.sRNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.netRegionValueDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.schmObjNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.subNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeSchmObjDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.powerVDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.aPVDataGridViewCheckBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.countPointCat1FullDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countPointCat1DataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countPointCat2FullDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countPointCat2DataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countPointCat3DataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countPointCatEEDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countPointCatSourceDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countAbnObjCat1FullDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countAbnObjCat1DataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countAbnObjCat2FullDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countAbnObjCat2DataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countAbnObjCat3DataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countAbnObjCatEEDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countAbnObjCatSourceDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countAbnObj150DataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countAbnObj150670DataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countAbnObj670DataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateApplyDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateApplyMaxDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idDamageDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsReport81 = new System.Windows.Forms.BindingSource(this.components);
            this.dsDamage = new DailyReportN.DataSet.dsDamage();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStripMain.SuspendLayout();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.groupBoxIs81.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.toolStripFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReport81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.toolBtnExcel,
            this.toolBtnReport});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1135, 25);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 22);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.ToolTipText = "Загрузка данных";
            this.progressBar.Visible = false;
            // 
            // toolBtnExcel
            // 
            this.toolBtnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnExcel.Image = global::DailyReportN.Properties.Resources.Excel;
            this.toolBtnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnExcel.Name = "toolBtnExcel";
            this.toolBtnExcel.Size = new System.Drawing.Size(23, 22);
            this.toolBtnExcel.Text = "Экспорт в Excel";
            this.toolBtnExcel.Click += new System.EventHandler(this.toolBtnExcel_Click);
            // 
            // toolBtnReport
            // 
            this.toolBtnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReport.Image = global::DailyReportN.Properties.Resources.Report;
            this.toolBtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReport.Text = "Отчет";
            this.toolBtnReport.Click += new System.EventHandler(this.toolBtnReport_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 25);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.btnReport);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxIs81);
            this.splitContainerMain.Panel1.Controls.Add(this.groupBoxDate);
            this.splitContainerMain.Panel1.Controls.Add(this.toolStripFilter);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.dgvReport);
            this.splitContainerMain.Size = new System.Drawing.Size(1135, 690);
            this.splitContainerMain.SplitterDistance = 257;
            this.splitContainerMain.TabIndex = 1;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(12, 289);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(99, 23);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Сформировать";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // groupBoxIs81
            // 
            this.groupBoxIs81.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIs81.Controls.Add(this.rbFilterIs81);
            this.groupBoxIs81.Controls.Add(this.rbFilterAll81);
            this.groupBoxIs81.Location = new System.Drawing.Point(12, 211);
            this.groupBoxIs81.Name = "groupBoxIs81";
            this.groupBoxIs81.Size = new System.Drawing.Size(232, 72);
            this.groupBoxIs81.TabIndex = 2;
            this.groupBoxIs81.TabStop = false;
            // 
            // rbFilterIs81
            // 
            this.rbFilterIs81.AutoSize = true;
            this.rbFilterIs81.Checked = true;
            this.rbFilterIs81.Location = new System.Drawing.Point(9, 42);
            this.rbFilterIs81.Name = "rbFilterIs81";
            this.rbFilterIs81.Size = new System.Drawing.Size(80, 17);
            this.rbFilterIs81.TabIndex = 1;
            this.rbFilterIs81.TabStop = true;
            this.rbFilterIs81.Text = "Только 8.1";
            this.rbFilterIs81.UseVisualStyleBackColor = true;
            // 
            // rbFilterAll81
            // 
            this.rbFilterAll81.AutoSize = true;
            this.rbFilterAll81.Location = new System.Drawing.Point(9, 19);
            this.rbFilterAll81.Name = "rbFilterAll81";
            this.rbFilterAll81.Size = new System.Drawing.Size(115, 17);
            this.rbFilterAll81.TabIndex = 0;
            this.rbFilterAll81.Text = "Все повреждения";
            this.rbFilterAll81.UseVisualStyleBackColor = true;
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDate.Controls.Add(this.dtpFilterEnd);
            this.groupBoxDate.Controls.Add(this.label2);
            this.groupBoxDate.Controls.Add(this.dtpFilterBeg);
            this.groupBoxDate.Controls.Add(this.label1);
            this.groupBoxDate.Controls.Add(this.rbFilterPeriod);
            this.groupBoxDate.Controls.Add(this.cmbFilterYear);
            this.groupBoxDate.Controls.Add(this.rbFilterYear);
            this.groupBoxDate.Location = new System.Drawing.Point(12, 28);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(232, 177);
            this.groupBoxDate.TabIndex = 1;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Дата";
            // 
            // dtpFilterEnd
            // 
            this.dtpFilterEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFilterEnd.Enabled = false;
            this.dtpFilterEnd.Location = new System.Drawing.Point(6, 147);
            this.dtpFilterEnd.Name = "dtpFilterEnd";
            this.dtpFilterEnd.Size = new System.Drawing.Size(220, 20);
            this.dtpFilterEnd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Конец";
            // 
            // dtpFilterBeg
            // 
            this.dtpFilterBeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFilterBeg.Enabled = false;
            this.dtpFilterBeg.Location = new System.Drawing.Point(6, 105);
            this.dtpFilterBeg.Name = "dtpFilterBeg";
            this.dtpFilterBeg.Size = new System.Drawing.Size(220, 20);
            this.dtpFilterBeg.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Начало";
            // 
            // rbFilterPeriod
            // 
            this.rbFilterPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFilterPeriod.AutoSize = true;
            this.rbFilterPeriod.Location = new System.Drawing.Point(6, 69);
            this.rbFilterPeriod.Name = "rbFilterPeriod";
            this.rbFilterPeriod.Size = new System.Drawing.Size(63, 17);
            this.rbFilterPeriod.TabIndex = 2;
            this.rbFilterPeriod.Text = "Период";
            this.rbFilterPeriod.UseVisualStyleBackColor = true;
            this.rbFilterPeriod.CheckedChanged += new System.EventHandler(this.rbFilterPeriod_CheckedChanged);
            // 
            // cmbFilterYear
            // 
            this.cmbFilterYear.FormattingEnabled = true;
            this.cmbFilterYear.Location = new System.Drawing.Point(6, 42);
            this.cmbFilterYear.Name = "cmbFilterYear";
            this.cmbFilterYear.Size = new System.Drawing.Size(220, 21);
            this.cmbFilterYear.TabIndex = 1;
            // 
            // rbFilterYear
            // 
            this.rbFilterYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFilterYear.AutoSize = true;
            this.rbFilterYear.Checked = true;
            this.rbFilterYear.Location = new System.Drawing.Point(6, 19);
            this.rbFilterYear.Name = "rbFilterYear";
            this.rbFilterYear.Size = new System.Drawing.Size(43, 17);
            this.rbFilterYear.TabIndex = 0;
            this.rbFilterYear.TabStop = true;
            this.rbFilterYear.Text = "Год";
            this.rbFilterYear.UseVisualStyleBackColor = true;
            // 
            // toolStripFilter
            // 
            this.toolStripFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnFilterApply,
            this.toolBtnFilterDelete});
            this.toolStripFilter.Location = new System.Drawing.Point(0, 0);
            this.toolStripFilter.Name = "toolStripFilter";
            this.toolStripFilter.Size = new System.Drawing.Size(257, 25);
            this.toolStripFilter.TabIndex = 0;
            this.toolStripFilter.Text = "Фильтр";
            // 
            // toolBtnFilterApply
            // 
            this.toolBtnFilterApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFilterApply.Image = global::DailyReportN.Properties.Resources.filter;
            this.toolBtnFilterApply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFilterApply.Name = "toolBtnFilterApply";
            this.toolBtnFilterApply.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFilterApply.Text = "Применить фильтр";
            this.toolBtnFilterApply.Click += new System.EventHandler(this.toolBtnFilterApply_Click);
            // 
            // toolBtnFilterDelete
            // 
            this.toolBtnFilterDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFilterDelete.Image = global::DailyReportN.Properties.Resources.filter_delete;
            this.toolBtnFilterDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFilterDelete.Name = "toolBtnFilterDelete";
            this.toolBtnFilterDelete.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFilterDelete.Text = "Убрать фильтр";
            this.toolBtnFilterDelete.Click += new System.EventHandler(this.toolBtnFilterDelete_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoGenerateColumns = false;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDateDocDataGridViewTextBoxColumn,
            this.typeDocDataGridViewTextBoxColumn,
            this.sRNameDataGridViewTextBoxColumn,
            this.netRegionValueDataGridViewTextBoxColumn,
            this.schmObjNameDataGridViewTextBoxColumn,
            this.subNameDataGridViewTextBoxColumn,
            this.typeSchmObjDataGridViewTextBoxColumn,
            this.powerVDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.aPVDataGridViewCheckBoxColumn,
            this.countPointCat1FullDataGridViewTextBoxColumn,
            this.countPointCat1DataGridViewTextBoxColumn,
            this.countPointCat2FullDataGridViewTextBoxColumn,
            this.countPointCat2DataGridViewTextBoxColumn,
            this.countPointCat3DataGridViewTextBoxColumn,
            this.countPointCatEEDataGridViewTextBoxColumn,
            this.countPointCatSourceDataGridViewTextBoxColumn,
            this.countAbnObjCat1FullDataGridViewTextBoxColumn,
            this.countAbnObjCat1DataGridViewTextBoxColumn,
            this.countAbnObjCat2FullDataGridViewTextBoxColumn,
            this.countAbnObjCat2DataGridViewTextBoxColumn,
            this.countAbnObjCat3DataGridViewTextBoxColumn,
            this.countAbnObjCatEEDataGridViewTextBoxColumn,
            this.countAbnObjCatSourceDataGridViewTextBoxColumn,
            this.countAbnObj150DataGridViewTextBoxColumn,
            this.countAbnObj150670DataGridViewTextBoxColumn,
            this.countAbnObj670DataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.dateApplyDataGridViewTextBoxColumn,
            this.dateApplyMaxDataGridViewTextBoxColumn,
            this.idDamageDgvColumn});
            this.dgvReport.DataSource = this.bsReport81;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(0, 0);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersWidth = 21;
            this.dgvReport.Size = new System.Drawing.Size(874, 690);
            this.dgvReport.TabIndex = 0;
            // 
            // numDateDocDataGridViewTextBoxColumn
            // 
            this.numDateDocDataGridViewTextBoxColumn.DataPropertyName = "numDateDoc";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.numDateDocDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.numDateDocDataGridViewTextBoxColumn.HeaderText = "№ и дата";
            this.numDateDocDataGridViewTextBoxColumn.Name = "numDateDocDataGridViewTextBoxColumn";
            this.numDateDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDateDocDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeDocDataGridViewTextBoxColumn
            // 
            this.typeDocDataGridViewTextBoxColumn.DataPropertyName = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn.HeaderText = "Тип документа";
            this.typeDocDataGridViewTextBoxColumn.Name = "typeDocDataGridViewTextBoxColumn";
            this.typeDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDocDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDocDataGridViewTextBoxColumn.Width = 80;
            // 
            // sRNameDataGridViewTextBoxColumn
            // 
            this.sRNameDataGridViewTextBoxColumn.DataPropertyName = "SRName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sRNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.sRNameDataGridViewTextBoxColumn.HeaderText = "Сетевой район";
            this.sRNameDataGridViewTextBoxColumn.Name = "sRNameDataGridViewTextBoxColumn";
            this.sRNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sRNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sRNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // netRegionValueDataGridViewTextBoxColumn
            // 
            this.netRegionValueDataGridViewTextBoxColumn.DataPropertyName = "netRegionValue";
            this.netRegionValueDataGridViewTextBoxColumn.HeaderText = "Сет. р-н";
            this.netRegionValueDataGridViewTextBoxColumn.Name = "netRegionValueDataGridViewTextBoxColumn";
            this.netRegionValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.netRegionValueDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.netRegionValueDataGridViewTextBoxColumn.Width = 60;
            // 
            // schmObjNameDataGridViewTextBoxColumn
            // 
            this.schmObjNameDataGridViewTextBoxColumn.DataPropertyName = "schmObjName";
            this.schmObjNameDataGridViewTextBoxColumn.HeaderText = "Объект схемы";
            this.schmObjNameDataGridViewTextBoxColumn.Name = "schmObjNameDataGridViewTextBoxColumn";
            this.schmObjNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.schmObjNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.schmObjNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // subNameDataGridViewTextBoxColumn
            // 
            this.subNameDataGridViewTextBoxColumn.DataPropertyName = "subName";
            this.subNameDataGridViewTextBoxColumn.HeaderText = "ТП";
            this.subNameDataGridViewTextBoxColumn.Name = "subNameDataGridViewTextBoxColumn";
            this.subNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.subNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.subNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // typeSchmObjDataGridViewTextBoxColumn
            // 
            this.typeSchmObjDataGridViewTextBoxColumn.DataPropertyName = "TypeSchmObj";
            this.typeSchmObjDataGridViewTextBoxColumn.HeaderText = "Вид объекта";
            this.typeSchmObjDataGridViewTextBoxColumn.Name = "typeSchmObjDataGridViewTextBoxColumn";
            this.typeSchmObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeSchmObjDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeSchmObjDataGridViewTextBoxColumn.Width = 60;
            // 
            // powerVDataGridViewTextBoxColumn
            // 
            this.powerVDataGridViewTextBoxColumn.DataPropertyName = "PowerV";
            this.powerVDataGridViewTextBoxColumn.HeaderText = "Напр-е";
            this.powerVDataGridViewTextBoxColumn.Name = "powerVDataGridViewTextBoxColumn";
            this.powerVDataGridViewTextBoxColumn.ReadOnly = true;
            this.powerVDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.powerVDataGridViewTextBoxColumn.Width = 60;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Причина";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reasonDataGridViewTextBoxColumn.Width = 70;
            // 
            // aPVDataGridViewCheckBoxColumn
            // 
            this.aPVDataGridViewCheckBoxColumn.DataPropertyName = "APV";
            this.aPVDataGridViewCheckBoxColumn.HeaderText = "АПВ";
            this.aPVDataGridViewCheckBoxColumn.Name = "aPVDataGridViewCheckBoxColumn";
            this.aPVDataGridViewCheckBoxColumn.ReadOnly = true;
            this.aPVDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aPVDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aPVDataGridViewCheckBoxColumn.Width = 40;
            // 
            // countPointCat1FullDataGridViewTextBoxColumn
            // 
            this.countPointCat1FullDataGridViewTextBoxColumn.DataPropertyName = "countPointCat1Full";
            this.countPointCat1FullDataGridViewTextBoxColumn.HeaderText = "т.у. Кат1 Полное";
            this.countPointCat1FullDataGridViewTextBoxColumn.Name = "countPointCat1FullDataGridViewTextBoxColumn";
            this.countPointCat1FullDataGridViewTextBoxColumn.ReadOnly = true;
            this.countPointCat1FullDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countPointCat1FullDataGridViewTextBoxColumn.Width = 50;
            // 
            // countPointCat1DataGridViewTextBoxColumn
            // 
            this.countPointCat1DataGridViewTextBoxColumn.DataPropertyName = "countPointCat1";
            this.countPointCat1DataGridViewTextBoxColumn.HeaderText = "т.у. Кат1";
            this.countPointCat1DataGridViewTextBoxColumn.Name = "countPointCat1DataGridViewTextBoxColumn";
            this.countPointCat1DataGridViewTextBoxColumn.ReadOnly = true;
            this.countPointCat1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countPointCat1DataGridViewTextBoxColumn.Width = 50;
            // 
            // countPointCat2FullDataGridViewTextBoxColumn
            // 
            this.countPointCat2FullDataGridViewTextBoxColumn.DataPropertyName = "countPointCat2Full";
            this.countPointCat2FullDataGridViewTextBoxColumn.HeaderText = "т.у. Кат2 Полное";
            this.countPointCat2FullDataGridViewTextBoxColumn.Name = "countPointCat2FullDataGridViewTextBoxColumn";
            this.countPointCat2FullDataGridViewTextBoxColumn.ReadOnly = true;
            this.countPointCat2FullDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countPointCat2FullDataGridViewTextBoxColumn.Width = 50;
            // 
            // countPointCat2DataGridViewTextBoxColumn
            // 
            this.countPointCat2DataGridViewTextBoxColumn.DataPropertyName = "countPointCat2";
            this.countPointCat2DataGridViewTextBoxColumn.HeaderText = "т.у. Кат2";
            this.countPointCat2DataGridViewTextBoxColumn.Name = "countPointCat2DataGridViewTextBoxColumn";
            this.countPointCat2DataGridViewTextBoxColumn.ReadOnly = true;
            this.countPointCat2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countPointCat2DataGridViewTextBoxColumn.Width = 50;
            // 
            // countPointCat3DataGridViewTextBoxColumn
            // 
            this.countPointCat3DataGridViewTextBoxColumn.DataPropertyName = "countPointCat3";
            this.countPointCat3DataGridViewTextBoxColumn.HeaderText = "т.у. Кат3";
            this.countPointCat3DataGridViewTextBoxColumn.Name = "countPointCat3DataGridViewTextBoxColumn";
            this.countPointCat3DataGridViewTextBoxColumn.ReadOnly = true;
            this.countPointCat3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countPointCat3DataGridViewTextBoxColumn.Width = 50;
            // 
            // countPointCatEEDataGridViewTextBoxColumn
            // 
            this.countPointCatEEDataGridViewTextBoxColumn.DataPropertyName = "countPointEE";
            this.countPointCatEEDataGridViewTextBoxColumn.HeaderText = "т.у. Сеть";
            this.countPointCatEEDataGridViewTextBoxColumn.Name = "countPointCatEEDataGridViewTextBoxColumn";
            this.countPointCatEEDataGridViewTextBoxColumn.ReadOnly = true;
            this.countPointCatEEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countPointCatEEDataGridViewTextBoxColumn.Width = 50;
            // 
            // countPointCatSourceDataGridViewTextBoxColumn
            // 
            this.countPointCatSourceDataGridViewTextBoxColumn.DataPropertyName = "countPointSource";
            this.countPointCatSourceDataGridViewTextBoxColumn.HeaderText = "т.у. Произв";
            this.countPointCatSourceDataGridViewTextBoxColumn.Name = "countPointCatSourceDataGridViewTextBoxColumn";
            this.countPointCatSourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.countPointCatSourceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countPointCatSourceDataGridViewTextBoxColumn.Width = 50;
            // 
            // countAbnObjCat1FullDataGridViewTextBoxColumn
            // 
            this.countAbnObjCat1FullDataGridViewTextBoxColumn.DataPropertyName = "countAbnObjCat1Full";
            this.countAbnObjCat1FullDataGridViewTextBoxColumn.HeaderText = "Абн Кат1 Полное";
            this.countAbnObjCat1FullDataGridViewTextBoxColumn.Name = "countAbnObjCat1FullDataGridViewTextBoxColumn";
            this.countAbnObjCat1FullDataGridViewTextBoxColumn.ReadOnly = true;
            this.countAbnObjCat1FullDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countAbnObjCat1FullDataGridViewTextBoxColumn.Width = 50;
            // 
            // countAbnObjCat1DataGridViewTextBoxColumn
            // 
            this.countAbnObjCat1DataGridViewTextBoxColumn.DataPropertyName = "countAbnObjCat1";
            this.countAbnObjCat1DataGridViewTextBoxColumn.HeaderText = "Абн Кат1";
            this.countAbnObjCat1DataGridViewTextBoxColumn.Name = "countAbnObjCat1DataGridViewTextBoxColumn";
            this.countAbnObjCat1DataGridViewTextBoxColumn.ReadOnly = true;
            this.countAbnObjCat1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countAbnObjCat1DataGridViewTextBoxColumn.Width = 50;
            // 
            // countAbnObjCat2FullDataGridViewTextBoxColumn
            // 
            this.countAbnObjCat2FullDataGridViewTextBoxColumn.DataPropertyName = "countAbnObjCat2Full";
            this.countAbnObjCat2FullDataGridViewTextBoxColumn.HeaderText = "Абн Кат2 Полное";
            this.countAbnObjCat2FullDataGridViewTextBoxColumn.Name = "countAbnObjCat2FullDataGridViewTextBoxColumn";
            this.countAbnObjCat2FullDataGridViewTextBoxColumn.ReadOnly = true;
            this.countAbnObjCat2FullDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countAbnObjCat2FullDataGridViewTextBoxColumn.Width = 50;
            // 
            // countAbnObjCat2DataGridViewTextBoxColumn
            // 
            this.countAbnObjCat2DataGridViewTextBoxColumn.DataPropertyName = "countAbnObjCat2";
            this.countAbnObjCat2DataGridViewTextBoxColumn.HeaderText = "Абн Кат2";
            this.countAbnObjCat2DataGridViewTextBoxColumn.Name = "countAbnObjCat2DataGridViewTextBoxColumn";
            this.countAbnObjCat2DataGridViewTextBoxColumn.ReadOnly = true;
            this.countAbnObjCat2DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countAbnObjCat2DataGridViewTextBoxColumn.Width = 50;
            // 
            // countAbnObjCat3DataGridViewTextBoxColumn
            // 
            this.countAbnObjCat3DataGridViewTextBoxColumn.DataPropertyName = "countAbnObjCat3";
            this.countAbnObjCat3DataGridViewTextBoxColumn.HeaderText = "Абн Кат3";
            this.countAbnObjCat3DataGridViewTextBoxColumn.Name = "countAbnObjCat3DataGridViewTextBoxColumn";
            this.countAbnObjCat3DataGridViewTextBoxColumn.ReadOnly = true;
            this.countAbnObjCat3DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countAbnObjCat3DataGridViewTextBoxColumn.Width = 50;
            // 
            // countAbnObjCatEEDataGridViewTextBoxColumn
            // 
            this.countAbnObjCatEEDataGridViewTextBoxColumn.DataPropertyName = "countAbnObjEE";
            this.countAbnObjCatEEDataGridViewTextBoxColumn.HeaderText = "Абн Сеть";
            this.countAbnObjCatEEDataGridViewTextBoxColumn.Name = "countAbnObjCatEEDataGridViewTextBoxColumn";
            this.countAbnObjCatEEDataGridViewTextBoxColumn.ReadOnly = true;
            this.countAbnObjCatEEDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countAbnObjCatEEDataGridViewTextBoxColumn.Width = 50;
            // 
            // countAbnObjCatSourceDataGridViewTextBoxColumn
            // 
            this.countAbnObjCatSourceDataGridViewTextBoxColumn.DataPropertyName = "countAbnObjSource";
            this.countAbnObjCatSourceDataGridViewTextBoxColumn.HeaderText = "Абн Произв";
            this.countAbnObjCatSourceDataGridViewTextBoxColumn.Name = "countAbnObjCatSourceDataGridViewTextBoxColumn";
            this.countAbnObjCatSourceDataGridViewTextBoxColumn.ReadOnly = true;
            this.countAbnObjCatSourceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countAbnObjCatSourceDataGridViewTextBoxColumn.Width = 50;
            // 
            // countAbnObj150DataGridViewTextBoxColumn
            // 
            this.countAbnObj150DataGridViewTextBoxColumn.DataPropertyName = "countAbnObj150";
            this.countAbnObj150DataGridViewTextBoxColumn.HeaderText = "Абн до 150";
            this.countAbnObj150DataGridViewTextBoxColumn.Name = "countAbnObj150DataGridViewTextBoxColumn";
            this.countAbnObj150DataGridViewTextBoxColumn.ReadOnly = true;
            this.countAbnObj150DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // countAbnObj150670DataGridViewTextBoxColumn
            // 
            this.countAbnObj150670DataGridViewTextBoxColumn.DataPropertyName = "countAbnObj150670";
            this.countAbnObj150670DataGridViewTextBoxColumn.HeaderText = "Абн до 670";
            this.countAbnObj150670DataGridViewTextBoxColumn.Name = "countAbnObj150670DataGridViewTextBoxColumn";
            this.countAbnObj150670DataGridViewTextBoxColumn.ReadOnly = true;
            this.countAbnObj150670DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countAbnObj150670DataGridViewTextBoxColumn.Width = 50;
            // 
            // countAbnObj670DataGridViewTextBoxColumn
            // 
            this.countAbnObj670DataGridViewTextBoxColumn.DataPropertyName = "countAbnObj670";
            this.countAbnObj670DataGridViewTextBoxColumn.HeaderText = "Абн свыше 670";
            this.countAbnObj670DataGridViewTextBoxColumn.Name = "countAbnObj670DataGridViewTextBoxColumn";
            this.countAbnObj670DataGridViewTextBoxColumn.ReadOnly = true;
            this.countAbnObj670DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateBeginDataGridViewTextBoxColumn
            // 
            this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "dateBegin";
            this.dateBeginDataGridViewTextBoxColumn.HeaderText = "Дата прекращения";
            this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
            this.dateBeginDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateBeginDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateBeginDataGridViewTextBoxColumn.Width = 80;
            // 
            // dateApplyDataGridViewTextBoxColumn
            // 
            this.dateApplyDataGridViewTextBoxColumn.DataPropertyName = "dateApply";
            this.dateApplyDataGridViewTextBoxColumn.HeaderText = "Дата устранения";
            this.dateApplyDataGridViewTextBoxColumn.Name = "dateApplyDataGridViewTextBoxColumn";
            this.dateApplyDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateApplyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateApplyDataGridViewTextBoxColumn.Width = 80;
            // 
            // dateApplyMaxDataGridViewTextBoxColumn
            // 
            this.dateApplyMaxDataGridViewTextBoxColumn.DataPropertyName = "dateApplyMax";
            this.dateApplyMaxDataGridViewTextBoxColumn.HeaderText = "Дата восстановления";
            this.dateApplyMaxDataGridViewTextBoxColumn.Name = "dateApplyMaxDataGridViewTextBoxColumn";
            this.dateApplyMaxDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateApplyMaxDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateApplyMaxDataGridViewTextBoxColumn.Width = 80;
            // 
            // idDamageDgvColumn
            // 
            this.idDamageDgvColumn.DataPropertyName = "IdDamage";
            this.idDamageDgvColumn.HeaderText = "IdDamage";
            this.idDamageDgvColumn.Name = "idDamageDgvColumn";
            this.idDamageDgvColumn.ReadOnly = true;
            this.idDamageDgvColumn.Visible = false;
            // 
            // bsReport81
            // 
            this.bsReport81.DataMember = "Report81";
            this.bsReport81.DataSource = this.dsDamage;
            // 
            // dsDamage
            // 
            this.dsDamage.DataSetName = "DataSetDamage";
            this.dsDamage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // FormReport81
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 715);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStripMain);
            this.Name = "FormReport81";
            this.Text = "Бюллетень 8.1";
            this.Load += new System.EventHandler(this.FormReport81_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel1.PerformLayout();
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.ResumeLayout(false);
            this.groupBoxIs81.ResumeLayout(false);
            this.groupBoxIs81.PerformLayout();
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.toolStripFilter.ResumeLayout(false);
            this.toolStripFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReport81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDamage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.ComponentModel.IContainer components=null;
    private System.Windows.Forms.Button btnReport;

    private ToolStrip toolStripMain;

    private SplitContainer splitContainerMain;

    private ToolStrip toolStripFilter;

    private DailyReportN.DataSet.dsDamage dsDamage;

    private ToolStripButton toolBtnFilterApply;

    private ToolStripButton toolBtnFilterDelete;

    private DataGridViewExcelFilter dgvReport;

    private BindingSource bsReport81;

    private BackgroundWorker backgroundWorker;

    private System.Windows.Forms.GroupBox groupBoxDate;

    private DateTimePicker dtpFilterEnd;

    private System.Windows.Forms.Label label2;

    private DateTimePicker dtpFilterBeg;

    private System.Windows.Forms.Label label1;

    private RadioButton rbFilterPeriod;

    private ComboBox cmbFilterYear;

    private RadioButton rbFilterYear;

    private ToolStripProgressBar progressBar;

    //private DataGridViewFilterCheckBoxColumn dataGridViewFilterCheckBoxColumn_0;

    private System.Windows.Forms.GroupBox groupBoxIs81;

    private RadioButton rbFilterIs81;

    private RadioButton rbFilterAll81;

    private DataGridViewFilterTextBoxColumn numDateDocDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn typeDocDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn sRNameDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn netRegionValueDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn schmObjNameDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn subNameDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn typeSchmObjDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn powerVDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn reasonDataGridViewTextBoxColumn;

    private DataGridViewFilterCheckBoxColumn aPVDataGridViewCheckBoxColumn;

    private DataGridViewFilterTextBoxColumn countPointCat1FullDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countPointCat1DataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countPointCat2FullDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countPointCat2DataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countPointCat3DataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countPointCatEEDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countPointCatSourceDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countAbnObjCat1FullDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countAbnObjCat1DataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countAbnObjCat2FullDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countAbnObjCat2DataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countAbnObjCat3DataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countAbnObjCatEEDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countAbnObjCatSourceDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countAbnObj150DataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countAbnObj150670DataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn countAbnObj670DataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn dateBeginDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn dateApplyDataGridViewTextBoxColumn;

    private DataGridViewFilterTextBoxColumn dateApplyMaxDataGridViewTextBoxColumn;

    private DataGridViewTextBoxColumn idDamageDgvColumn;

    private ToolStripButton toolBtnExcel;

    private ToolStripButton toolBtnReport;
}
