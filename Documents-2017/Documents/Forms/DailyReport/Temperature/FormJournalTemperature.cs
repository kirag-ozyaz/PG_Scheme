namespace Documents.Forms.DailyReport.Temperature
{
    using ControlsLbr;
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
    using Documents.Forms.DailyReport.DataSets;
    using Documents.Properties;
    using FormLbr;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using System.Windows.Forms.DataVisualization.Charting;

    /// <summary>
    /// Архив погоды
    /// </summary>
    public class FormJournalTemperature : FormBase
    {
        private BindingSource bindingSource_0;
        private Chart chart_0;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewExcelFilter_0;
        private DataGridViewFilterComboBoxColumn dataGridViewFilterComboBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_0;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_10;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_11;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_13;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_8;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_0;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn_1;
        private DataSetDamage dataSetDamage_0;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private IContainer components = null;
        private TabControlVertical tabControlVertical_0;
        private TabPage tabPage_0;
        private TabPage tabPage_1;
        private ToolStrip toolStrip_0;
        private ToolStripButton toolBtnAdd;
        private ToolStripButton toolBtnEdit;
        private ToolStripButton toolBtnDel;
        private ToolStripButton toolBtnRefresh;
        private ToolStripButton toolBtnFind;
        private ToolStripButton toolBtnFindPrev;
        private ToolStripButton toolBtnFindNext;
        private ToolStripButton toolBtnLoadOldBase;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator_1;
        private ToolStripTextBox txtFind;

        public FormJournalTemperature()
        {
            this.InitializeComponent();
            this.toolBtnLoadOldBase.Visible = false;
            this.dateTimePicker_1 = new DateTimePicker();
            this.dateTimePicker_1.Format = DateTimePickerFormat.Short;
            this.dateTimePicker_1.Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddDays(-1.0);
            this.dateTimePicker_1.Size = new Size(100, 20);
            ToolStripControlHost host = new ToolStripControlHost(this.dateTimePicker_1) {
                Alignment = ToolStripItemAlignment.Right
            };
            this.toolStrip_0.Items.Add(host);
            ToolStripLabel label = new ToolStripLabel("Дата до") {
                Alignment = ToolStripItemAlignment.Right
            };
            this.toolStrip_0.Items.Add(label);
            this.dateTimePicker_0 = new DateTimePicker();
            this.dateTimePicker_0.Format = DateTimePickerFormat.Short;
            this.dateTimePicker_0.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker_0.Size = new Size(100, 20);
            ToolStripControlHost host2 = new ToolStripControlHost(this.dateTimePicker_0) {
                Alignment = ToolStripItemAlignment.Right
            };
            this.toolStrip_0.Items.Add(host2);
            ToolStripLabel label2 = new ToolStripLabel("Дата от") {
                Alignment = ToolStripItemAlignment.Right
            };
            this.toolStrip_0.Items.Add(label2);
        }

        private void dataGridViewExcelFilter_0_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((e.RowIndex >= 0) && (e.ColumnIndex >= 0)) && (this.toolBtnEdit.Visible && this.toolBtnEdit.Enabled))
            {
                this.toolBtnEdit_Click(sender, e);
            }
        }

        private void dataGridViewExcelFilter_0_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (((e.RowIndex >= 0) && (this.dataGridViewExcelFilter_0.Columns[this.dataGridViewFilterTextBoxColumn_0.Name].Index == e.ColumnIndex)) && ((Convert.ToDateTime(this.dataGridViewExcelFilter_0[e.ColumnIndex, e.RowIndex].Value).DayOfWeek == DayOfWeek.Saturday) || (Convert.ToDateTime(this.dataGridViewExcelFilter_0[e.ColumnIndex, e.RowIndex].Value).DayOfWeek == DayOfWeek.Sunday)))
            {
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormJournalTemperature_Load(object sender, EventArgs e)
        {
            this.method_1(null);
        }

        private void method_0()
        {
            DataTable table = new DataTable("tR_Classifier");
            table.Columns.Add("id", typeof(int));
            table.Columns.Add("name", typeof(string));
            base.SelectSqlData(table, true, "where ParentKey = ';ReportDaily;WindDirect;' and isGroup = 0 and deleted = 0 order by name", null, false, 0);
            BindingSource source = new BindingSource {
                DataSource = table
            };
            this.dataGridViewFilterComboBoxColumn_0.DisplayMember = "name";
            this.dataGridViewFilterComboBoxColumn_0.ValueMember = "id";
            this.dataGridViewFilterComboBoxColumn_0.DataSource = source;
        }

        private void method_1(int? nullable_0 = new int?())
        {
            this.method_0();
            if (!nullable_0.HasValue && (this.bindingSource_0.Current != null))
            {
                nullable_0 = new int?(Convert.ToInt32(((DataRowView) this.bindingSource_0.Current).Row["id"]));
            }
            base.SelectSqlData(this.dataSetDamage_0.tJ_Temperature, true, string.Format("where dateTemp >= '{0}' and dateTEmp <= '{1}' order by datetemp desc", this.dateTimePicker_0.Value.ToString("yyyyMMdd"), this.dateTimePicker_1.Value.ToString("yyyyMMdd")), null, false, 0);
            if (nullable_0.HasValue)
            {
                this.dataGridViewExcelFilter_0.SearchGrid(this.dataGridViewTextBoxColumn_0.Name, nullable_0.ToString(), true);
            }
            this.chart_0.DataBind();
            this.chart_0.Update();
        }

        private void method_2(object sender, FormClosedEventArgs e)
        {
            this.method_1(((FormTemperatureAddEdit) sender).method_0());
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormJournalTemperature));
            ChartArea item = new ChartArea();
            ChartArea area2 = new ChartArea();
            Legend legend = new Legend();
            Series series = new Series();
            Series series2 = new Series();
            Series series3 = new Series();
            this.toolStrip_0 = new ToolStrip();
            this.toolBtnAdd = new ToolStripButton();
            this.toolBtnEdit = new ToolStripButton();
            this.toolBtnDel = new ToolStripButton();
            this.toolStripSeparator_0 = new ToolStripSeparator();
            this.toolBtnRefresh = new ToolStripButton();
            this.toolStripSeparator_1 = new ToolStripSeparator();
            this.toolBtnFind = new ToolStripButton();
            this.txtFind = new ToolStripTextBox();
            this.toolBtnFindPrev = new ToolStripButton();
            this.toolBtnFindNext = new ToolStripButton();
            this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.toolBtnLoadOldBase = new ToolStripButton();
            this.bindingSource_0 = new BindingSource(this.components);
            this.dataSetDamage_0 = new DataSetDamage();
            this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterComboBoxColumn_0 = new DataGridViewFilterComboBoxColumn();
            this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
            this.chart_0 = new Chart();
            this.tabControlVertical_0 = new TabControlVertical();
            this.tabPage_0 = new TabPage();
            this.tabPage_1 = new TabPage();
            this.toolStrip_0.SuspendLayout();
            ((ISupportInitialize) this.dataGridViewExcelFilter_0).BeginInit();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetDamage_0.BeginInit();
            this.chart_0.BeginInit();
            this.tabControlVertical_0.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.tabPage_1.SuspendLayout();
            base.SuspendLayout();
            ToolStripItem[] toolStripItems = new ToolStripItem[] { this.toolBtnAdd, this.toolBtnEdit, this.toolBtnDel, this.toolStripSeparator_0, this.toolBtnRefresh, this.toolStripSeparator_1, this.toolBtnFind, this.txtFind, this.toolBtnFindPrev, this.toolBtnFindNext, this.toolBtnLoadOldBase };
            this.toolStrip_0.Items.AddRange(toolStripItems);
            this.toolStrip_0.Location = new Point(0, 0);
            this.toolStrip_0.Name = "toolStrip";
            this.toolStrip_0.Size = new Size(0x52f, 0x19);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            this.toolBtnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnAdd.Image = global::Properties.Resources.ElementAdd;
            this.toolBtnAdd.ImageTransparentColor = Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new Size(0x17, 0x16);
            this.toolBtnAdd.Text = "toolStripButton1";
            this.toolBtnAdd.Click += new EventHandler(this.toolBtnAdd_Click);
            this.toolBtnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnEdit.Image = global::Properties.Resources.ElementEdit;
            this.toolBtnEdit.ImageTransparentColor = Color.Magenta;
            this.toolBtnEdit.Name = "toolBtnEdit";
            this.toolBtnEdit.Size = new Size(0x17, 0x16);
            this.toolBtnEdit.Text = "toolStripButton2";
            this.toolBtnEdit.Click += new EventHandler(this.toolBtnEdit_Click);
            this.toolBtnDel.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnDel.Image = global::Properties.Resources.ElementDel;
            this.toolBtnDel.ImageTransparentColor = Color.Magenta;
            this.toolBtnDel.Name = "toolBtnDel";
            this.toolBtnDel.Size = new Size(0x17, 0x16);
            this.toolBtnDel.Text = "toolStripButton3";
            this.toolBtnDel.Click += new EventHandler(this.toolBtnDel_Click);
            this.toolStripSeparator_0.Name = "toolStripSeparator1";
            this.toolStripSeparator_0.Size = new Size(6, 0x19);
            this.toolBtnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnRefresh.Image = global::Properties.Resources.refresh_16;
            this.toolBtnRefresh.ImageTransparentColor = Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new Size(0x17, 0x16);
            this.toolBtnRefresh.Text = "toolStripButton4";
            this.toolBtnRefresh.Click += new EventHandler(this.toolBtnRefresh_Click);
            this.toolStripSeparator_1.Name = "toolStripSeparator2";
            this.toolStripSeparator_1.Size = new Size(6, 0x19);
            this.toolBtnFind.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFind.Image = global::Properties.Resources.Find;
            this.toolBtnFind.ImageTransparentColor = Color.Magenta;
            this.toolBtnFind.Name = "toolBtnFind";
            this.toolBtnFind.Size = new Size(0x17, 0x16);
            this.toolBtnFind.Text = "toolStripButton5";
            this.toolBtnFind.Click += new EventHandler(this.toolBtnFind_Click);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new Size(100, 0x19);
            this.txtFind.KeyDown += new KeyEventHandler(this.txtFind_KeyDown);
            this.toolBtnFindPrev.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = global::Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new Size(0x17, 0x16);
            this.toolBtnFindPrev.Text = "toolStripButton6";
            this.toolBtnFindPrev.Click += new EventHandler(this.toolBtnFindPrev_Click);
            this.toolBtnFindNext.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new Size(0x17, 0x16);
            this.toolBtnFindNext.Text = "toolStripButton7";
            this.toolBtnFindNext.Click += new EventHandler(this.toolBtnFindNext_Click);
            this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
            this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
            style.BackColor = Color.FromArgb(0xe0, 0xe0, 0xe0);
            this.dataGridViewExcelFilter_0.AlternatingRowsDefaultCellStyle = style;
            this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
            this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] { 
                this.dataGridViewFilterTextBoxColumn_0, this.dataGridViewTextBoxColumn_0, this.dataGridViewFilterTextBoxColumn_1, this.dataGridViewFilterTextBoxColumn_2, this.dataGridViewFilterTextBoxColumn_3, this.dataGridViewFilterTextBoxColumn_4, this.dataGridViewFilterTextBoxColumn_5, this.dataGridViewFilterTextBoxColumn_6, this.dataGridViewFilterTextBoxColumn_7, this.dataGridViewFilterComboBoxColumn_0, this.dataGridViewFilterTextBoxColumn_8, this.dataGridViewFilterTextBoxColumn_9, this.dataGridViewFilterTextBoxColumn_10, this.dataGridViewFilterTextBoxColumn_11, this.dataGridViewFilterTextBoxColumn_12, this.dataGridViewTextBoxColumn_1,
                this.dataGridViewFilterTextBoxColumn_13
            };
            this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
            this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
            this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
            this.dataGridViewExcelFilter_0.Location = new Point(3, 3);
            this.dataGridViewExcelFilter_0.MultiSelect = false;
            this.dataGridViewExcelFilter_0.Name = "dgv";
            this.dataGridViewExcelFilter_0.ReadOnly = true;
            this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExcelFilter_0.Size = new Size(0x50e, 470);
            this.dataGridViewExcelFilter_0.TabIndex = 1;
            this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            this.toolBtnLoadOldBase.DisplayStyle = ToolStripItemDisplayStyle.Image;
            this.toolBtnLoadOldBase.Image = (Image) resources.GetObject("toolBtnLoadOldBase.Image");
            this.toolBtnLoadOldBase.ImageTransparentColor = Color.Magenta;
            this.toolBtnLoadOldBase.Name = "toolBtnLoadOldBase";
            this.toolBtnLoadOldBase.Size = new Size(0x17, 0x16);
            this.toolBtnLoadOldBase.Text = "Загрузка из старой базы";
            this.toolBtnLoadOldBase.Click += new EventHandler(this.toolBtnLoadOldBase_Click);
            this.bindingSource_0.DataMember = "tJ_Temperature";
            this.bindingSource_0.DataSource = this.dataSetDamage_0;
            this.dataSetDamage_0.DataSetName = "DataSetDamage";
            this.dataSetDamage_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "DateTemp";
            this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Дата";
            this.dataGridViewFilterTextBoxColumn_0.Name = "dateTempDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_0.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn_0.HeaderText = "id";
            this.dataGridViewTextBoxColumn_0.Name = "idDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_0.ReadOnly = true;
            this.dataGridViewTextBoxColumn_0.Visible = false;
            this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "Night";
            this.dataGridViewFilterTextBoxColumn_1.HeaderText = "t Ночью";
            this.dataGridViewFilterTextBoxColumn_1.Name = "nightColumn";
            this.dataGridViewFilterTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_1.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "NightDown";
            this.dataGridViewFilterTextBoxColumn_2.HeaderText = "t Ночь От";
            this.dataGridViewFilterTextBoxColumn_2.Name = "nightDownDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_2.Visible = false;
            this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "NightUp";
            this.dataGridViewFilterTextBoxColumn_3.HeaderText = "t Ночь До";
            this.dataGridViewFilterTextBoxColumn_3.Name = "nightUpDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_3.Visible = false;
            this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "Day";
            this.dataGridViewFilterTextBoxColumn_4.HeaderText = "t Днем";
            this.dataGridViewFilterTextBoxColumn_4.Name = "dayColumn";
            this.dataGridViewFilterTextBoxColumn_4.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "DayDown";
            this.dataGridViewFilterTextBoxColumn_5.HeaderText = "t День От";
            this.dataGridViewFilterTextBoxColumn_5.Name = "dayDownDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_5.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_5.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_5.Visible = false;
            this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "DayUp";
            this.dataGridViewFilterTextBoxColumn_6.HeaderText = "t День До";
            this.dataGridViewFilterTextBoxColumn_6.Name = "dayUpDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_6.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_6.Visible = false;
            this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "TempAverage";
            this.dataGridViewFilterTextBoxColumn_7.HeaderText = "t Средняя";
            this.dataGridViewFilterTextBoxColumn_7.Name = "tempAverageDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_7.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterComboBoxColumn_0.DataPropertyName = "Wind";
            this.dataGridViewFilterComboBoxColumn_0.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewFilterComboBoxColumn_0.HeaderText = "Ветер";
            this.dataGridViewFilterComboBoxColumn_0.Name = "windDgvColumn";
            this.dataGridViewFilterComboBoxColumn_0.ReadOnly = true;
            this.dataGridViewFilterComboBoxColumn_0.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "Speed";
            this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Скорость ";
            this.dataGridViewFilterTextBoxColumn_8.Name = "speedColumn";
            this.dataGridViewFilterTextBoxColumn_8.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "SpeedDown";
            this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Скорость От";
            this.dataGridViewFilterTextBoxColumn_9.Name = "speedDownDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_9.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_9.Visible = false;
            this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "SpeedUp";
            this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Скорость До";
            this.dataGridViewFilterTextBoxColumn_10.Name = "speedUpDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_10.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_10.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_10.Visible = false;
            this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "Comment";
            this.dataGridViewFilterTextBoxColumn_11.HeaderText = "Примечание";
            this.dataGridViewFilterTextBoxColumn_11.Name = "commentDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_11.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_11.Resizable = DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "DateOwner";
            this.dataGridViewFilterTextBoxColumn_12.HeaderText = "Дата создания";
            this.dataGridViewFilterTextBoxColumn_12.Name = "dateOwnerDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_12.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn_1.DataPropertyName = "idOwner";
            this.dataGridViewTextBoxColumn_1.HeaderText = "idOwner";
            this.dataGridViewTextBoxColumn_1.Name = "idOwnerDataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn_1.ReadOnly = true;
            this.dataGridViewTextBoxColumn_1.Visible = false;
            this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "Owner";
            this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Автор";
            this.dataGridViewFilterTextBoxColumn_13.Name = "ownerDataGridViewTextBoxColumn";
            this.dataGridViewFilterTextBoxColumn_13.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn_13.Resizable = DataGridViewTriState.True;
            item.AxisX.LabelStyle.Format = "MM.yyyy";
            item.AxisX.LabelStyle.IntervalType = DateTimeIntervalType.Months;
            item.Name = "ChartArea1";
            area2.Name = "ChartArea2";
            this.chart_0.ChartAreas.Add(item);
            this.chart_0.ChartAreas.Add(area2);
            this.chart_0.DataSource = this.bindingSource_0;
            this.chart_0.Dock = DockStyle.Fill;
            legend.Name = "Legend1";
            this.chart_0.Legends.Add(legend);
            this.chart_0.Location = new Point(3, 3);
            this.chart_0.Name = "chartAbnObjPayment";
            this.chart_0.Palette = ChartColorPalette.Bright;
            series.BorderWidth = 2;
            series.ChartArea = "ChartArea1";
            series.ChartType = SeriesChartType.Line;
            series.Legend = "Legend1";
            series.LegendText = "t Ночью";
            series.Name = "Night";
            series.ToolTip = @"#VALX \n#VAL ℃";
            series.XValueMember = "DateTemp";
            series.YValueMembers = "NightDown, NightUp, DayDown, DayUp";
            series.YValuesPerPoint = 4;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "t Днем";
            series2.Name = "Day";
            series2.ToolTip = @"#VALX\n#VAL℃";
            series2.XValueMember = "DateTemp";
            series2.XValueType = ChartValueType.Date;
            series2.YValueMembers = "DayDown, DayUp";
            series2.YValuesPerPoint = 2;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea2";
            series3.ChartType = SeriesChartType.Line;
            series3.Label = " ";
            series3.LabelToolTip = "#VAL";
            series3.Legend = "Legend1";
            series3.LegendText = "Скорость ветра";
            series3.Name = "Speed";
            series3.ToolTip = @"#VALX\n#VALм/с";
            series3.XValueMember = "DateTemp";
            series3.XValueType = ChartValueType.Date;
            series3.YValueMembers = "SpeedDown, SpeedUp";
            series3.YValuesPerPoint = 2;
            series3.YValueType = ChartValueType.Int32;
            this.chart_0.Series.Add(series);
            this.chart_0.Series.Add(series2);
            this.chart_0.Series.Add(series3);
            this.chart_0.Size = new Size(0x50e, 470);
            this.chart_0.TabIndex = 7;
            this.chart_0.Text = "chart1";
            this.tabControlVertical_0.Alignment = TabAlignment.Right;
            this.tabControlVertical_0.Controls.Add(this.tabPage_0);
            this.tabControlVertical_0.Controls.Add(this.tabPage_1);
            this.tabControlVertical_0.Dock = DockStyle.Fill;
            this.tabControlVertical_0.Location = new Point(0, 0x19);
            this.tabControlVertical_0.Multiline = true;
            this.tabControlVertical_0.Name = "tabControlVertical1";
            this.tabControlVertical_0.SelectedIndex = 0;
            this.tabControlVertical_0.Size = new Size(0x52f, 0x1e4);
            this.tabControlVertical_0.TabIndex = 8;
            this.tabPage_0.Controls.Add(this.dataGridViewExcelFilter_0);
            this.tabPage_0.Location = new Point(4, 4);
            this.tabPage_0.Name = "tabPage1";
            this.tabPage_0.Padding = new Padding(3);
            this.tabPage_0.Size = new Size(0x514, 0x1dc);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Таблица";
            this.tabPage_0.UseVisualStyleBackColor = true;
            this.tabPage_1.Controls.Add(this.chart_0);
            this.tabPage_1.Location = new Point(4, 4);
            this.tabPage_1.Name = "tabPage2";
            this.tabPage_1.Padding = new Padding(3);
            this.tabPage_1.Size = new Size(0x514, 0x1dc);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "График";
            this.tabPage_1.UseVisualStyleBackColor = true;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x52f, 0x1fd);
            base.Controls.Add(this.tabControlVertical_0);
            base.Controls.Add(this.toolStrip_0);
            base.Icon = (Icon) resources.GetObject("$this.Icon");
            base.Name = "FormJournalTemperature";
            this.Text = "Архив погоды";
            base.Load += new EventHandler(this.FormJournalTemperature_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            ((ISupportInitialize) this.dataGridViewExcelFilter_0).EndInit();
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetDamage_0.EndInit();
            this.chart_0.EndInit();
            this.tabControlVertical_0.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.tabPage_1.ResumeLayout(false);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void toolBtnAdd_Click(object sender, EventArgs e)
        {
            FormTemperatureAddEdit form1 = new FormTemperatureAddEdit(null) {
                MdiParent = base.MdiParent
            };
            form1.SqlSettings=(this.SqlSettings);
            form1.FormClosed += new FormClosedEventHandler(this.method_2);
            form1.Show();
        }

        private void toolBtnEdit_Click(object sender, EventArgs e)
        {
            if (this.bindingSource_0.Current != null)
            {
                DataRow row = ((DataRowView) this.bindingSource_0.Current).Row;
                if (Convert.ToDateTime(row["dateTemp"]) < DateTime.Now.Date.AddDays(-2.0))
                {
                    MessageBox.Show("Редактирование невозможно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    FormTemperatureAddEdit form1 = new FormTemperatureAddEdit(new int?(Convert.ToInt32(row["id"]))) {
                        MdiParent = base.MdiParent
                    };
                    form1.SqlSettings=(this.SqlSettings);
                    form1.FormClosed += new FormClosedEventHandler(this.method_2);
                    form1.Show();
                }
            }
            else
            {
                MessageBox.Show("Не выбрана запись для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void toolBtnDel_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewExcelFilter_0.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dataGridViewExcelFilter_0.CurrentRow.Cells[this.dataGridViewTextBoxColumn_0.Name].Value);
                if (base.DeleteSqlDataById(this.dataSetDamage_0.tJ_Temperature, num))
                {
                    this.dataGridViewExcelFilter_0.Rows.Remove(this.dataGridViewExcelFilter_0.CurrentRow);
                    MessageBox.Show("Строка успешно удалена");
                }
            }
            else
            {
                MessageBox.Show("Не выбрана запись для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void toolBtnRefresh_Click(object sender, EventArgs e)
        {
            this.method_1(null);
        }

        private void toolBtnFind_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.txtFind.Text);
        }

        private void toolBtnFindPrev_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
        }

        private void toolBtnFindNext_Click(object sender, EventArgs e)
        {
            this.dataGridViewExcelFilter_0.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
        }

        private void toolBtnLoadOldBase_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(this.SqlSettings.GetConnectionString()))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction("LoadOldTemp");
                SqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.Transaction = transaction;
                try
                {
                    command.CommandText = "delete tJ_temperature ";
                    command.ExecuteNonQuery();
                    command.CommandText = "DBCC CHECKIDENT (tj_temperature, RESEED, 0)";
                    command.ExecuteNonQuery();
                    int? nullable = null;
                    command.CommandText = "";
                    List<DateTime> list = new List<DateTime>();
                    foreach (DataRow row in new SqlDataCommand(new SQLSettings("ulges-sql", "SR", "WINDOWS", "", "")).SelectSqlData("СоставительНизкого", false, "", nullable).Rows)
                    {
                        if ((row["Дата1"] != DBNull.Value) && !list.Contains(Convert.ToDateTime(row["Дата1"])))
                        {
                            list.Add(Convert.ToDateTime(row["Дата1"]));
                            string str = "null";
                            if (row["Ветер"] != DBNull.Value)
                            {
                                string str2 = row["Ветер"].ToString();
                                //uint num = Class227.smethod_0(str2);
                                uint num = ComputeStringHash(str2);
                                if (num <= 0x5f900cc8)//1603275976u
                                {
                                    if (num <= 0x297c28e6)
                                    {
                                        if (num == 0x2b17e1c)
                                        {
                                            if (str2 == "юго-западный")
                                            {
                                                str = "1606";
                                            }
                                        }
                                        else if ((num == 0x297c28e6) && (str2 == "юго-восточный"))
                                        {
                                            str = "1608";
                                        }
                                    }
                                    else if (num != 0x57bd1a80)
                                    {
                                        if ((num == 0x5f900cc8) && (str2 == "восточный"))
                                        {
                                            str = "1609";
                                        }
                                    }
                                    else if (str2 == "южный")
                                    {
                                        str = "1607";
                                    }
                                }
                                else if (num <= 0x65f94d64)
                                {
                                    if (num == 0x65c557ee)
                                    {
                                        if (str2 == "западный")
                                        {
                                            str = "1605";
                                        }
                                    }
                                    else if ((num == 0x65f94d64) && (str2 == "северо-западный"))
                                    {
                                        str = "1604";
                                    }
                                }
                                else if (num != 0xd03e7b4e)
                                {
                                    if ((num == 0xd065a28d) && (str2 == "северный"))
                                    {
                                        str = "1603";
                                    }
                                }
                                else if (str2 == "северо-восточный")
                                {
                                    str = "1610";
                                }
                            }
                            command.CommandText = command.CommandText + string.Format(" insert into tJ_Temperature(DateTEmp, NightDown, NightUp, DayDown, DayUp, \r\n                                                        TempAverage, wind, speeddown, speedup, comment, dateOwner, owner) \r\n                                                Values('{0}', {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11})", new object[] { Convert.ToDateTime(row["Дата1"]).ToString("yyyyMMdd"), (row["ТемператураНОт"] == DBNull.Value) ? "null" : row["ТемператураНОт"].ToString(), (row["ТемператураНДо"] == DBNull.Value) ? "null" : row["ТемператураНДо"].ToString(), (row["ТемператураДДо"] == DBNull.Value) ? "null" : row["ТемператураДДо"].ToString(), (row["ТемператураДДо"] == DBNull.Value) ? "null" : row["ТемператураДДо"].ToString(), (row["TemperatSrSut"] == DBNull.Value) ? "null" : row["TemperatSrSut"].ToString(), str, (row["СкоростьОт"] == DBNull.Value) ? "null" : row["СкоростьОт"].ToString(), (row["СкоростьДо"] == DBNull.Value) ? "null" : row["СкоростьДо"].ToString(), (row["Примечание"] == DBNull.Value) ? "null" : ("'" + row["Примечание"].ToString() + "'"), (row["Дата"] == DBNull.Value) ? "null" : ("'" + Convert.ToDateTime(row["Дата"]).ToString("yyyyMMdd") + "'"), (row["Составил"] == DBNull.Value) ? "null" : ("'" + row["Составил"].ToString() + "'") });
                        }
                    }
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    this.method_1(null);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Source);
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception exception2)
                    {
                        MessageBox.Show(exception2.Message, exception2.Source);
                    }
                }
            }
        }

        private void txtFind_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Modifiers == Keys.Shift)
                {
                    this.dataGridViewExcelFilter_0.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
                }
                if (e.Modifiers == Keys.NoName)
                {
                    this.dataGridViewExcelFilter_0.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
                }
            }
        }
        internal static uint ComputeStringHash(string p0)
        {
            uint num = 0;
            if (p0 != null)
            {
                num = 2166136261u;
                for (int i = 0; i < p0.Length; i++)
                {
                    num = ((uint)p0[i] ^ num) * 16777619u;
                }
            }
            return num;
        }
    }
}

