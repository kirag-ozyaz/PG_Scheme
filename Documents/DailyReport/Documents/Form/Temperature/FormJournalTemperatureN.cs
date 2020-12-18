﻿
    using ControlsLbr;
    using ControlsLbr.DataGridViewExcelFilter;
    using DataSql;
    using DailyReport.DataSets;
    //using Documents.Properties;
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

namespace Documents.Temperature
{
    /// <summary>
    /// Архив погоды
    /// </summary>
    public class FormJournalTemperatureN : FormBase
    {
        private BindingSource bindingSource_0;
        private Chart chartAbnObjPayment;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgv;
        private DataGridViewFilterComboBoxColumn windDgvColumn;
        private DataGridViewFilterTextBoxColumn dateTempDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn nightColumn;
        private DataGridViewFilterTextBoxColumn speedUpDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateOwnerDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn ownerDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn nightDownDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn nightUpDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dayColumn;
        private DataGridViewFilterTextBoxColumn dayDownDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dayUpDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn tempAverageDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn speedColumn;
        private DataGridViewFilterTextBoxColumn speedDownDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idOwnerDataGridViewTextBoxColumn;
        private dsDamage dataSetDamage;
        private DateTimePicker dateTimePicker_0;
        private DateTimePicker dateTimePicker_1;
        private IContainer components = null;
        private TabControlVertical tabControlVertical1;
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
        ChartArea chartArea;
        ChartArea chartArea2;
        Legend legend;
        Series Night;
        Series Day;
        Series Speed;

        public FormJournalTemperatureN()
        {
            this.InitializeComponent();
            this.toolBtnLoadOldBase.Visible = false;
            this.dateTimePicker_1 = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Value = new DateTime(DateTime.Now.Year + 1, 1, 1).AddDays(-1.0),
                Size = new Size(100, 20)
            };
            ToolStripControlHost host = new ToolStripControlHost(this.dateTimePicker_1) {
                Alignment = ToolStripItemAlignment.Right
            };
            this.toolStrip_0.Items.Add(host);
            ToolStripLabel label = new ToolStripLabel("Дата до") {
                Alignment = ToolStripItemAlignment.Right
            };
            this.toolStrip_0.Items.Add(label);
            this.dateTimePicker_0 = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Value = new DateTime(DateTime.Now.Year, 1, 1),
                Size = new Size(100, 20)
            };
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
            if (((e.RowIndex >= 0) && (this.dgv.Columns[this.dateTempDataGridViewTextBoxColumn.Name].Index == e.ColumnIndex)) && ((Convert.ToDateTime(this.dgv[e.ColumnIndex, e.RowIndex].Value).DayOfWeek == DayOfWeek.Saturday) || (Convert.ToDateTime(this.dgv[e.ColumnIndex, e.RowIndex].Value).DayOfWeek == DayOfWeek.Sunday)))
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
            this.windDgvColumn.DisplayMember = "name";
            this.windDgvColumn.ValueMember = "id";
            this.windDgvColumn.DataSource = source;
        }

        private void method_1(int? nullable_0 = new int?())
        {
            this.method_0();
            if (!nullable_0.HasValue && (this.bindingSource_0.Current != null))
            {
                nullable_0 = new int?(Convert.ToInt32(((DataRowView) this.bindingSource_0.Current).Row["id"]));
            }
            base.SelectSqlData(this.dataSetDamage.tJ_Temperature, true, string.Format("where dateTemp >= '{0}' and dateTEmp <= '{1}' order by datetemp desc", this.dateTimePicker_0.Value.ToString("yyyyMMdd"), this.dateTimePicker_1.Value.ToString("yyyyMMdd")), null, false, 0);
            if (nullable_0.HasValue)
            {
                this.dgv.SearchGrid(this.idDataGridViewTextBoxColumn.Name, nullable_0.ToString(), true);
            }
            this.chartAbnObjPayment.DataBind();
            this.chartAbnObjPayment.Update();
        }

        private void method_2(object sender, FormClosedEventArgs e)
        {
            this.method_1(((FormTemperatureAddEdit) sender).method_0());
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip_0 = new System.Windows.Forms.ToolStrip();
            this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_0 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnFind = new System.Windows.Forms.ToolStripButton();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolBtnLoadOldBase = new System.Windows.Forms.ToolStripButton();
            this.dgv = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.dateTempDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nightColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nightDownDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nightUpDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dayColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dayDownDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dayUpDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.tempAverageDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.windDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterComboBoxColumn();
            this.speedColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.speedDownDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.speedUpDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateOwnerDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDamage = new dsDamage();
            this.tabControlVertical1 = new ControlsLbr.TabControlVertical();
            this.tabPage_0 = new System.Windows.Forms.TabPage();
            this.tabPage_1 = new System.Windows.Forms.TabPage();
            this.toolStrip_0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).BeginInit();
            this.tabControlVertical1.SuspendLayout();
            this.tabPage_0.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_0
            // 
            this.toolStrip_0.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAdd,
            this.toolBtnEdit,
            this.toolBtnDel,
            this.toolStripSeparator_0,
            this.toolBtnRefresh,
            this.toolStripSeparator_1,
            this.toolBtnFind,
            this.txtFind,
            this.toolBtnFindPrev,
            this.toolBtnFindNext,
            this.toolBtnLoadOldBase});
            this.toolStrip_0.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_0.Name = "toolStrip_0";
            this.toolStrip_0.Size = new System.Drawing.Size(1327, 25);
            this.toolStrip_0.TabIndex = 0;
            this.toolStrip_0.Text = "toolStrip1";
            // 
            // toolBtnAdd
            // 
            this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAdd.Image = global::DailyReport.Properties.Resources.ElementAdd;
            this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAdd.Text = "toolStripButton1";
            this.toolBtnAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
            // 
            // toolBtnEdit
            // 
            this.toolBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEdit.Image = global::DailyReport.Properties.Resources.ElementEdit;
            this.toolBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEdit.Name = "toolBtnEdit";
            this.toolBtnEdit.Size = new System.Drawing.Size(23, 22);
            this.toolBtnEdit.Text = "toolStripButton2";
            this.toolBtnEdit.Click += new System.EventHandler(this.toolBtnEdit_Click);
            // 
            // toolBtnDel
            // 
            this.toolBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDel.Image = global::DailyReport.Properties.Resources.ElementDel;
            this.toolBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDel.Name = "toolBtnDel";
            this.toolBtnDel.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDel.Text = "toolStripButton3";
            this.toolBtnDel.Click += new System.EventHandler(this.toolBtnDel_Click);
            // 
            // toolStripSeparator_0
            // 
            this.toolStripSeparator_0.Name = "toolStripSeparator_0";
            this.toolStripSeparator_0.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnRefresh
            // 
            this.toolBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefresh.Image = global::DailyReport.Properties.Resources.refresh_16;
            this.toolBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRefresh.Text = "toolStripButton4";
            this.toolBtnRefresh.Click += new System.EventHandler(this.toolBtnRefresh_Click);
            // 
            // toolStripSeparator_1
            // 
            this.toolStripSeparator_1.Name = "toolStripSeparator_1";
            this.toolStripSeparator_1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnFind
            // 
            this.toolBtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFind.Image = global::DailyReport.Properties.Resources.Find;
            this.toolBtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFind.Name = "toolBtnFind";
            this.toolBtnFind.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFind.Text = "toolStripButton5";
            this.toolBtnFind.Click += new System.EventHandler(this.toolBtnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 25);
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // toolBtnFindPrev
            // 
            this.toolBtnFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = global::DailyReport.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindPrev.Text = "toolStripButton6";
            this.toolBtnFindPrev.Click += new System.EventHandler(this.toolBtnFindPrev_Click);
            // 
            // toolBtnFindNext
            // 
            this.toolBtnFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::DailyReport.Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindNext.Text = "toolStripButton7";
            this.toolBtnFindNext.Click += new System.EventHandler(this.toolBtnFindNext_Click);
            // 
            // toolBtnLoadOldBase
            // 
            this.toolBtnLoadOldBase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnLoadOldBase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnLoadOldBase.Name = "toolBtnLoadOldBase";
            this.toolBtnLoadOldBase.Size = new System.Drawing.Size(23, 22);
            this.toolBtnLoadOldBase.Text = "Загрузка из старой базы";
            this.toolBtnLoadOldBase.Click += new System.EventHandler(this.toolBtnLoadOldBase_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateTempDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nightColumn,
            this.nightDownDataGridViewTextBoxColumn,
            this.nightUpDataGridViewTextBoxColumn,
            this.dayColumn,
            this.dayDownDataGridViewTextBoxColumn,
            this.dayUpDataGridViewTextBoxColumn,
            this.tempAverageDataGridViewTextBoxColumn,
            this.windDgvColumn,
            this.speedColumn,
            this.speedDownDataGridViewTextBoxColumn,
            this.speedUpDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.dateOwnerDataGridViewTextBoxColumn,
            this.idOwnerDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bindingSource_0;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1294, 470);
            this.dgv.TabIndex = 1;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
            // 
            // dateTempDataGridViewTextBoxColumn
            // 
            this.dateTempDataGridViewTextBoxColumn.DataPropertyName = "DateTemp";
            this.dateTempDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateTempDataGridViewTextBoxColumn.Name = "dateTempDataGridViewTextBoxColumn";
            this.dateTempDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateTempDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nightColumn
            // 
            this.nightColumn.DataPropertyName = "Night";
            this.nightColumn.HeaderText = "t Ночью";
            this.nightColumn.Name = "nightColumn";
            this.nightColumn.ReadOnly = true;
            this.nightColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nightDownDataGridViewTextBoxColumn
            // 
            this.nightDownDataGridViewTextBoxColumn.DataPropertyName = "NightDown";
            this.nightDownDataGridViewTextBoxColumn.HeaderText = "t Ночь От";
            this.nightDownDataGridViewTextBoxColumn.Name = "nightDownDataGridViewTextBoxColumn";
            this.nightDownDataGridViewTextBoxColumn.ReadOnly = true;
            this.nightDownDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nightDownDataGridViewTextBoxColumn.Visible = false;
            // 
            // nightUpDataGridViewTextBoxColumn
            // 
            this.nightUpDataGridViewTextBoxColumn.DataPropertyName = "NightUp";
            this.nightUpDataGridViewTextBoxColumn.HeaderText = "t Ночь До";
            this.nightUpDataGridViewTextBoxColumn.Name = "nightUpDataGridViewTextBoxColumn";
            this.nightUpDataGridViewTextBoxColumn.ReadOnly = true;
            this.nightUpDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nightUpDataGridViewTextBoxColumn.Visible = false;
            // 
            // dayColumn
            // 
            this.dayColumn.DataPropertyName = "Day";
            this.dayColumn.HeaderText = "t Днем";
            this.dayColumn.Name = "dayColumn";
            this.dayColumn.ReadOnly = true;
            // 
            // dayDownDataGridViewTextBoxColumn
            // 
            this.dayDownDataGridViewTextBoxColumn.DataPropertyName = "DayDown";
            this.dayDownDataGridViewTextBoxColumn.HeaderText = "t День От";
            this.dayDownDataGridViewTextBoxColumn.Name = "dayDownDataGridViewTextBoxColumn";
            this.dayDownDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayDownDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dayDownDataGridViewTextBoxColumn.Visible = false;
            // 
            // dayUpDataGridViewTextBoxColumn
            // 
            this.dayUpDataGridViewTextBoxColumn.DataPropertyName = "DayUp";
            this.dayUpDataGridViewTextBoxColumn.HeaderText = "t День До";
            this.dayUpDataGridViewTextBoxColumn.Name = "dayUpDataGridViewTextBoxColumn";
            this.dayUpDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayUpDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dayUpDataGridViewTextBoxColumn.Visible = false;
            // 
            // tempAverageDataGridViewTextBoxColumn
            // 
            this.tempAverageDataGridViewTextBoxColumn.DataPropertyName = "TempAverage";
            this.tempAverageDataGridViewTextBoxColumn.HeaderText = "t Средняя";
            this.tempAverageDataGridViewTextBoxColumn.Name = "tempAverageDataGridViewTextBoxColumn";
            this.tempAverageDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempAverageDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // windDgvColumn
            // 
            this.windDgvColumn.DataPropertyName = "Wind";
            this.windDgvColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.windDgvColumn.HeaderText = "Ветер";
            this.windDgvColumn.Name = "windDgvColumn";
            this.windDgvColumn.ReadOnly = true;
            this.windDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // speedColumn
            // 
            this.speedColumn.DataPropertyName = "Speed";
            this.speedColumn.HeaderText = "Скорость ";
            this.speedColumn.Name = "speedColumn";
            this.speedColumn.ReadOnly = true;
            // 
            // speedDownDataGridViewTextBoxColumn
            // 
            this.speedDownDataGridViewTextBoxColumn.DataPropertyName = "SpeedDown";
            this.speedDownDataGridViewTextBoxColumn.HeaderText = "Скорость От";
            this.speedDownDataGridViewTextBoxColumn.Name = "speedDownDataGridViewTextBoxColumn";
            this.speedDownDataGridViewTextBoxColumn.ReadOnly = true;
            this.speedDownDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.speedDownDataGridViewTextBoxColumn.Visible = false;
            // 
            // speedUpDataGridViewTextBoxColumn
            // 
            this.speedUpDataGridViewTextBoxColumn.DataPropertyName = "SpeedUp";
            this.speedUpDataGridViewTextBoxColumn.HeaderText = "Скорость До";
            this.speedUpDataGridViewTextBoxColumn.Name = "speedUpDataGridViewTextBoxColumn";
            this.speedUpDataGridViewTextBoxColumn.ReadOnly = true;
            this.speedUpDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.speedUpDataGridViewTextBoxColumn.Visible = false;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Примечание";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateOwnerDataGridViewTextBoxColumn
            // 
            this.dateOwnerDataGridViewTextBoxColumn.DataPropertyName = "DateOwner";
            this.dateOwnerDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.dateOwnerDataGridViewTextBoxColumn.Name = "dateOwnerDataGridViewTextBoxColumn";
            this.dateOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOwnerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idOwnerDataGridViewTextBoxColumn
            // 
            this.idOwnerDataGridViewTextBoxColumn.DataPropertyName = "idOwner";
            this.idOwnerDataGridViewTextBoxColumn.HeaderText = "idOwner";
            this.idOwnerDataGridViewTextBoxColumn.Name = "idOwnerDataGridViewTextBoxColumn";
            this.idOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOwnerDataGridViewTextBoxColumn.Visible = false;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "Owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bindingSource_0
            // 
            this.bindingSource_0.DataMember = "tJ_Temperature";
            this.bindingSource_0.DataSource = this.dataSetDamage;
            // 
            // dataSetDamage
            // 
            this.dataSetDamage.DataSetName = "DataSetDamage";
            this.dataSetDamage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControlVertical1
            // 
            this.tabControlVertical1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControlVertical1.Controls.Add(this.tabPage_0);
            this.tabControlVertical1.Controls.Add(this.tabPage_1);
            this.tabControlVertical1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVertical1.Location = new System.Drawing.Point(0, 25);
            this.tabControlVertical1.Multiline = true;
            this.tabControlVertical1.Name = "tabControlVertical1";
            this.tabControlVertical1.SelectedIndex = 0;
            this.tabControlVertical1.Size = new System.Drawing.Size(1327, 484);
            this.tabControlVertical1.TabIndex = 8;
            // 
            // tabPage_0
            // 
            this.tabPage_0.Controls.Add(this.dgv);
            this.tabPage_0.Location = new System.Drawing.Point(4, 4);
            this.tabPage_0.Name = "tabPage_0";
            this.tabPage_0.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_0.Size = new System.Drawing.Size(1300, 476);
            this.tabPage_0.TabIndex = 0;
            this.tabPage_0.Text = "Таблица";
            this.tabPage_0.UseVisualStyleBackColor = true;
            // 
            // tabPage_1
            // 
            this.tabPage_1.Location = new System.Drawing.Point(4, 4);
            this.tabPage_1.Name = "tabPage_1";
            this.tabPage_1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_1.Size = new System.Drawing.Size(1300, 476);
            this.tabPage_1.TabIndex = 1;
            this.tabPage_1.Text = "График";
            this.tabPage_1.UseVisualStyleBackColor = true;
            // 
            // FormJournalTemperatureN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 509);
            this.Controls.Add(this.tabControlVertical1);
            this.Controls.Add(this.toolStrip_0);
            this.Name = "FormJournalTemperatureN";
            this.Text = "Архив погоды";
            this.Load += new System.EventHandler(this.FormJournalTemperature_Load);
            this.toolStrip_0.ResumeLayout(false);
            this.toolStrip_0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDamage)).EndInit();
            this.tabControlVertical1.ResumeLayout(false);
            this.tabPage_0.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
            if (this.dgv.CurrentRow != null)
            {
                int num = Convert.ToInt32(this.dgv.CurrentRow.Cells[this.idDataGridViewTextBoxColumn.Name].Value);
                if (base.DeleteSqlDataById(this.dataSetDamage.tJ_Temperature, num))
                {
                    this.dgv.Rows.Remove(this.dgv.CurrentRow);
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
            this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Begin, this.txtFind.Text);
        }

        private void toolBtnFindPrev_Click(object sender, EventArgs e)
        {
            this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
        }

        private void toolBtnFindNext_Click(object sender, EventArgs e)
        {
            this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
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
                    this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Prev, this.txtFind.Text);
                }
                if (e.Modifiers == Keys.NoName)
                {
                    this.dgv.SearchGrid(DataGridViewExcelFilter.TypeFind.Next, this.txtFind.Text);
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}

