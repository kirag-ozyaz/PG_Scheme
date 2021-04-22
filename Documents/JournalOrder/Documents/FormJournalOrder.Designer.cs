using ControlsLbr.DataGridViewExcelFilter;
using ControlsLbr.Scheme;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace JournalOrder
{
    public partial class FormJournalOrder
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.ComponentModel.IContainer components = null;


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJournalOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOrder = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bsOrder = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOrder = new JournalOrder.DataSet.DataSetOrder();
            this.toolStripOrder = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddOrder = new System.Windows.Forms.ToolStripButton();
            this.toolBtnAddOrderDivision = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolBtnEditOrder = new System.Windows.Forms.ToolStripButton();
            this.toolBtnReadOrder = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnReport = new System.Windows.Forms.ToolStripButton();
            this.toolBtnReportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnOrderClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.checkBoxCloseOrder = new System.Windows.Forms.CheckBox();
            this.checkBoxCurrentOrder = new System.Windows.Forms.CheckBox();
            this.checkBoxRegistered = new System.Windows.Forms.CheckBox();
            this.checkBoxNoRegistered = new System.Windows.Forms.CheckBox();
            this.panelDateFilter = new System.Windows.Forms.Panel();
            this.panelTree = new System.Windows.Forms.Panel();
            this.splitContainerFilter = new System.Windows.Forms.SplitContainer();
            this.checkBoxWhereSub = new System.Windows.Forms.CheckBox();
            this.treeViewSchmObjects = new ControlsLbr.Scheme.TreeViewSchmObjects();
            this.checkedListBoxDivision = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripFilter = new System.Windows.Forms.ToolStrip();
            this.toolBtnFilter = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFilterClear = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFind = new System.Windows.Forms.ToolStripButton();
            this.toolTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindNext = new System.Windows.Forms.ToolStripButton();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlOrder = new System.Windows.Forms.TabControl();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.dgvEvents = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bsOrderEvents = new System.Windows.Forms.BindingSource(this.components);
            this.srNumDgvColumn = new DataGridViewFilterTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewFilterTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn3 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn4 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn5 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn6 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn7 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn8 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn9 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.numDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.srNumDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateOutputDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.registeredDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
      /**/      this.outputMakerDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.instructionDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
     /**/       this.resolutionDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.srNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.headFioDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.acceptFIODataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.watchFIODataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.makerFIODataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.otherInstructionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outputFIODataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateCloseDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.closeFIODataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.beginResDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndResDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.instructionDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.acceptFIODataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.makerFioDataGridViewTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.evntDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.evntDateDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dispDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.closedDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDgvColumnEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrder)).BeginInit();
            this.toolStripOrder.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelDateFilter.SuspendLayout();
            this.panelTree.SuspendLayout();
            this.splitContainerFilter.Panel1.SuspendLayout();
            this.splitContainerFilter.Panel2.SuspendLayout();
            this.splitContainerFilter.SuspendLayout();
            this.toolStripFilter.SuspendLayout();
            this.tabControlOrder.SuspendLayout();
            this.tabPageView.SuspendLayout();
            this.tabPageEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderEvents)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDgvColumn,
            this.srNumDataGridViewTextBoxColumn,
            this.dateOutputDataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.registeredDgvColumn,
            this.outputMakerDataGridViewTextBoxColumn,
            this.instructionDataGridViewTextBoxColumn,
            this.resolutionDataGridViewTextBoxColumn,
            this.srNameDataGridViewTextBoxColumn,
            this.headFioDataGridViewTextBoxColumn,
            this.acceptFIODataGridViewTextBoxColumn,
            this.watchFIODataGridViewTextBoxColumn,
            this.makerFIODataGridViewTextBoxColumn,
            this.otherInstructionDataGridViewTextBoxColumn,
            this.outputFIODataGridViewTextBoxColumn,
            this.dateCloseDgvColumn,
            this.closeFIODataGridViewTextBoxColumn,
            this.beginResDgvColumn,
            this.EndResDgvColumn,
            this.idDgvColumn});
            this.dgvOrder.DataSource = this.bsOrder;
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(3, 47);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowHeadersWidth = 21;
            this.dgvOrder.RowTemplate.Height = 44;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(718, 487);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellDoubleClick);
            this.dgvOrder.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOrder_CellFormatting);
            // 
            // bsOrder
            // 
            this.bsOrder.DataMember = "vJ_Order";
            this.bsOrder.DataSource = this.dataSetOrder;
            // 
            // dataSetOrder
            // 
            this.dataSetOrder.DataSetName = "DataSetOrder";
            this.dataSetOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripOrder
            // 
            this.toolStripOrder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddOrder,
            this.toolBtnAddOrderDivision,
            this.toolBtnEditOrder,
            this.toolBtnReadOrder,
            this.toolBtnDelOrder,
            this.toolStripSeparator2,
            this.toolBtnRefresh,
            this.toolStripSeparator1,
            this.toolBtnReport,
            this.toolBtnReportExcel,
            this.toolStripSeparator3,
            this.toolBtnOrderClose,
            this.toolStripSeparator4,
            this.toolStripButton1});
            this.toolStripOrder.Location = new System.Drawing.Point(0, 0);
            this.toolStripOrder.Name = "toolStripOrder";
            this.toolStripOrder.Size = new System.Drawing.Size(918, 25);
            this.toolStripOrder.TabIndex = 2;
            this.toolStripOrder.Text = "toolStrip1";
            // 
            // toolBtnAddOrder
            // 
            this.toolBtnAddOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddOrder.Image = global::JournalOrder.Properties.Resources.ElementAdd;
            this.toolBtnAddOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddOrder.Name = "toolBtnAddOrder";
            this.toolBtnAddOrder.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddOrder.Text = "Создать наряд";
            this.toolBtnAddOrder.Click += new System.EventHandler(this.toolBtnAddOrder_Click);
            // 
            // toolBtnAddOrderDivision
            // 
            this.toolBtnAddOrderDivision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddOrderDivision.Image = global::JournalOrder.Properties.Resources.ElementAdd;
            this.toolBtnAddOrderDivision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddOrderDivision.Name = "toolBtnAddOrderDivision";
            this.toolBtnAddOrderDivision.Size = new System.Drawing.Size(29, 22);
            this.toolBtnAddOrderDivision.Text = "Создать наряд";
            // 
            // toolBtnEditOrder
            // 
            this.toolBtnEditOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEditOrder.Image = global::JournalOrder.Properties.Resources.ElementEdit;
            this.toolBtnEditOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEditOrder.Name = "toolBtnEditOrder";
            this.toolBtnEditOrder.Size = new System.Drawing.Size(23, 22);
            this.toolBtnEditOrder.Text = "Редактировать";
            this.toolBtnEditOrder.Click += new System.EventHandler(this.toolBtnEditOrder_Click);
            // 
            // toolBtnReadOrder
            // 
            this.toolBtnReadOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReadOrder.Image = global::JournalOrder.Properties.Resources.ElementInformation1;
            this.toolBtnReadOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReadOrder.Name = "toolBtnReadOrder";
            this.toolBtnReadOrder.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReadOrder.Text = "Просмотр наряда";
            this.toolBtnReadOrder.Click += new System.EventHandler(this.toolBtnReadOrder_Click);
            // 
            // toolBtnDelOrder
            // 
            this.toolBtnDelOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelOrder.Image = global::JournalOrder.Properties.Resources.ElementDel;
            this.toolBtnDelOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelOrder.Name = "toolBtnDelOrder";
            this.toolBtnDelOrder.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelOrder.Text = "Удалить наряд(ы)";
            this.toolBtnDelOrder.Click += new System.EventHandler(this.toolBtnDelOrder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnRefresh
            // 
            this.toolBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefresh.Image = global::JournalOrder.Properties.Resources.refresh_16;
            this.toolBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRefresh.Text = "Обновить";
            this.toolBtnRefresh.Click += new System.EventHandler(this.toolBtnRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnReport
            // 
            this.toolBtnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReport.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnReport.Image")));
            this.toolBtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReport.Text = "toolStripButton1";
            this.toolBtnReport.Visible = false;
            this.toolBtnReport.Click += new System.EventHandler(this.toolBtnReport_Click);
            // 
            // toolBtnReportExcel
            // 
            this.toolBtnReportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReportExcel.Image = global::JournalOrder.Properties.Resources.microsoftoffice2007excel_7581;
            this.toolBtnReportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReportExcel.Name = "toolBtnReportExcel";
            this.toolBtnReportExcel.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReportExcel.Text = "Печать наряда";
            this.toolBtnReportExcel.Click += new System.EventHandler(this.toolBtnReportExcel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnOrderClose
            // 
            this.toolBtnOrderClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnOrderClose.Image = global::JournalOrder.Properties.Resources.Orderclose;
            this.toolBtnOrderClose.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnOrderClose.Name = "toolBtnOrderClose";
            this.toolBtnOrderClose.Size = new System.Drawing.Size(23, 22);
            this.toolBtnOrderClose.Text = "Закрыть наряды";
            this.toolBtnOrderClose.Click += new System.EventHandler(this.toolBtnOrderClose_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::JournalOrder.Properties.Resources.ExportExcel;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(121, 22);
            this.toolStripButton1.Text = "Экспорт в эксель";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.Controls.Add(this.checkBoxCloseOrder);
            this.panelFilter.Controls.Add(this.checkBoxCurrentOrder);
            this.panelFilter.Controls.Add(this.checkBoxRegistered);
            this.panelFilter.Controls.Add(this.checkBoxNoRegistered);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(3, 3);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(718, 44);
            this.panelFilter.TabIndex = 3;
            // 
            // checkBoxCloseOrder
            // 
            this.checkBoxCloseOrder.AutoSize = true;
            this.checkBoxCloseOrder.BackColor = System.Drawing.Color.Gray;
            this.checkBoxCloseOrder.Checked = true;
            this.checkBoxCloseOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCloseOrder.Location = new System.Drawing.Point(411, 9);
            this.checkBoxCloseOrder.Name = "checkBoxCloseOrder";
            this.checkBoxCloseOrder.Size = new System.Drawing.Size(78, 17);
            this.checkBoxCloseOrder.TabIndex = 3;
            this.checkBoxCloseOrder.Text = "Закрытые";
            this.checkBoxCloseOrder.UseVisualStyleBackColor = false;
            this.checkBoxCloseOrder.CheckedChanged += new System.EventHandler(this.checkBoxRegistered_CheckedChanged);
            // 
            // checkBoxCurrentOrder
            // 
            this.checkBoxCurrentOrder.AutoSize = true;
            this.checkBoxCurrentOrder.BackColor = System.Drawing.Color.LawnGreen;
            this.checkBoxCurrentOrder.Checked = true;
            this.checkBoxCurrentOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCurrentOrder.Location = new System.Drawing.Point(307, 9);
            this.checkBoxCurrentOrder.Name = "checkBoxCurrentOrder";
            this.checkBoxCurrentOrder.Size = new System.Drawing.Size(98, 17);
            this.checkBoxCurrentOrder.TabIndex = 2;
            this.checkBoxCurrentOrder.Text = "Действующие";
            this.checkBoxCurrentOrder.UseVisualStyleBackColor = false;
            this.checkBoxCurrentOrder.CheckedChanged += new System.EventHandler(this.checkBoxRegistered_CheckedChanged);
            // 
            // checkBoxRegistered
            // 
            this.checkBoxRegistered.AutoSize = true;
            this.checkBoxRegistered.BackColor = System.Drawing.Color.White;
            this.checkBoxRegistered.Checked = true;
            this.checkBoxRegistered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRegistered.Location = new System.Drawing.Point(166, 9);
            this.checkBoxRegistered.Name = "checkBoxRegistered";
            this.checkBoxRegistered.Size = new System.Drawing.Size(135, 17);
            this.checkBoxRegistered.TabIndex = 1;
            this.checkBoxRegistered.Text = "Зарегистрированные";
            this.checkBoxRegistered.UseVisualStyleBackColor = false;
            this.checkBoxRegistered.CheckedChanged += new System.EventHandler(this.checkBoxRegistered_CheckedChanged);
            // 
            // checkBoxNoRegistered
            // 
            this.checkBoxNoRegistered.AutoSize = true;
            this.checkBoxNoRegistered.BackColor = System.Drawing.Color.Yellow;
            this.checkBoxNoRegistered.Checked = true;
            this.checkBoxNoRegistered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNoRegistered.Location = new System.Drawing.Point(12, 9);
            this.checkBoxNoRegistered.Name = "checkBoxNoRegistered";
            this.checkBoxNoRegistered.Size = new System.Drawing.Size(148, 17);
            this.checkBoxNoRegistered.TabIndex = 0;
            this.checkBoxNoRegistered.Text = "Незарегистрированные";
            this.checkBoxNoRegistered.UseVisualStyleBackColor = false;
            this.checkBoxNoRegistered.CheckedChanged += new System.EventHandler(this.checkBoxRegistered_CheckedChanged);
            // 
            // panelDateFilter
            // 
            this.panelDateFilter.Controls.Add(this.panelTree);
            this.panelDateFilter.Controls.Add(this.toolStripFilter);
            this.panelDateFilter.Controls.Add(this.dateTimePickerEnd);
            this.panelDateFilter.Controls.Add(this.label2);
            this.panelDateFilter.Controls.Add(this.dateTimePickerBegin);
            this.panelDateFilter.Controls.Add(this.label1);
            this.panelDateFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDateFilter.Location = new System.Drawing.Point(0, 0);
            this.panelDateFilter.Name = "panelDateFilter";
            this.panelDateFilter.Size = new System.Drawing.Size(182, 563);
            this.panelDateFilter.TabIndex = 4;
            // 
            // panelTree
            // 
            this.panelTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTree.Controls.Add(this.splitContainerFilter);
            this.panelTree.Location = new System.Drawing.Point(0, 106);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(182, 457);
            this.panelTree.TabIndex = 10;
            // 
            // splitContainerFilter
            // 
            this.splitContainerFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerFilter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerFilter.Location = new System.Drawing.Point(0, 0);
            this.splitContainerFilter.Name = "splitContainerFilter";
            this.splitContainerFilter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerFilter.Panel1
            // 
            this.splitContainerFilter.Panel1.Controls.Add(this.checkBoxWhereSub);
            this.splitContainerFilter.Panel1.Controls.Add(this.treeViewSchmObjects);
            // 
            // splitContainerFilter.Panel2
            // 
            this.splitContainerFilter.Panel2.Controls.Add(this.checkedListBoxDivision);
            this.splitContainerFilter.Panel2.Controls.Add(this.label3);
            this.splitContainerFilter.Size = new System.Drawing.Size(182, 457);
            this.splitContainerFilter.SplitterDistance = 352;
            this.splitContainerFilter.TabIndex = 10;
            // 
            // checkBoxWhereSub
            // 
            this.checkBoxWhereSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxWhereSub.AutoSize = true;
            this.checkBoxWhereSub.Checked = true;
            this.checkBoxWhereSub.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWhereSub.Location = new System.Drawing.Point(6, 333);
            this.checkBoxWhereSub.Name = "checkBoxWhereSub";
            this.checkBoxWhereSub.Size = new System.Drawing.Size(180, 17);
            this.checkBoxWhereSub.TabIndex = 13;
            this.checkBoxWhereSub.Text = "Фильтровать по подстанциям";
            this.checkBoxWhereSub.UseVisualStyleBackColor = true;
            // 
            // treeViewSchmObjects
            // 
            this.treeViewSchmObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewSchmObjects.CheckBoxes = true;
            this.treeViewSchmObjects.Location = new System.Drawing.Point(0, 0);
            this.treeViewSchmObjects.Name = "treeViewSchmObjects";
            this.treeViewSchmObjects.Size = new System.Drawing.Size(182, 327);
            this.treeViewSchmObjects.SqlSettings = null;
            this.treeViewSchmObjects.TabIndex = 9;
            // 
            // checkedListBoxDivision
            // 
            this.checkedListBoxDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxDivision.FormattingEnabled = true;
            this.checkedListBoxDivision.Location = new System.Drawing.Point(0, 13);
            this.checkedListBoxDivision.Name = "checkedListBoxDivision";
            this.checkedListBoxDivision.Size = new System.Drawing.Size(182, 88);
            this.checkedListBoxDivision.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Подразделения";
            // 
            // toolStripFilter
            // 
            this.toolStripFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnFilter,
            this.toolBtnFilterClear,
            this.toolBtnFind,
            this.toolTextBoxFind,
            this.toolBtnFindPrev,
            this.toolBtnFindNext});
            this.toolStripFilter.Location = new System.Drawing.Point(0, 0);
            this.toolStripFilter.Name = "toolStripFilter";
            this.toolStripFilter.Size = new System.Drawing.Size(182, 25);
            this.toolStripFilter.TabIndex = 10;
            this.toolStripFilter.Text = "toolStrip1";
            // 
            // toolBtnFilter
            // 
            this.toolBtnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFilter.Image = global::JournalOrder.Properties.Resources.filter;
            this.toolBtnFilter.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnFilter.Name = "toolBtnFilter";
            this.toolBtnFilter.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFilter.Text = "Применить фильтр";
            this.toolBtnFilter.Click += new System.EventHandler(this.toolBtnFilter_Click);
            // 
            // toolBtnFilterClear
            // 
            this.toolBtnFilterClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFilterClear.Image = global::JournalOrder.Properties.Resources.filter_delete;
            this.toolBtnFilterClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFilterClear.Name = "toolBtnFilterClear";
            this.toolBtnFilterClear.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFilterClear.Text = "Отменить фильтр";
            this.toolBtnFilterClear.Click += new System.EventHandler(this.toolBtnFilterClear_Click);
            // 
            // toolBtnFind
            // 
            this.toolBtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFind.Image = global::JournalOrder.Properties.Resources.Find;
            this.toolBtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFind.Name = "toolBtnFind";
            this.toolBtnFind.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFind.Text = "Поиск";
            this.toolBtnFind.Click += new System.EventHandler(this.toolBtnFind_Click);
            // 
            // toolTextBoxFind
            // 
            this.toolTextBoxFind.Name = "toolTextBoxFind";
            this.toolTextBoxFind.Size = new System.Drawing.Size(54, 25);
            this.toolTextBoxFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTextBoxFind_KeyDown);
            // 
            // toolBtnFindPrev
            // 
            this.toolBtnFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = global::JournalOrder.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindPrev.Text = "Поиск назад";
            this.toolBtnFindPrev.Click += new System.EventHandler(this.toolBtnFindPrev_Click);
            // 
            // toolBtnFindNext
            // 
            this.toolBtnFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::JournalOrder.Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindNext.Text = "Поиск вперед";
            this.toolBtnFindNext.Click += new System.EventHandler(this.toolBtnFindNext_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(6, 80);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(168, 20);
            this.dateTimePickerEnd.TabIndex = 7;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Конец";
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerBegin.Location = new System.Drawing.Point(6, 41);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(168, 20);
            this.dateTimePickerBegin.TabIndex = 5;
            this.dateTimePickerBegin.ValueChanged += new System.EventHandler(this.dateTimePickerBegin_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Начало";
            // 
            // tabControlOrder
            // 
            this.tabControlOrder.Controls.Add(this.tabPageView);
            this.tabControlOrder.Controls.Add(this.tabPageEvents);
            this.tabControlOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOrder.Location = new System.Drawing.Point(0, 0);
            this.tabControlOrder.Name = "tabControlOrder";
            this.tabControlOrder.SelectedIndex = 0;
            this.tabControlOrder.Size = new System.Drawing.Size(732, 563);
            this.tabControlOrder.TabIndex = 5;
            this.tabControlOrder.SelectedIndexChanged += new System.EventHandler(this.tabControlOrder_SelectedIndexChanged);
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.dgvOrder);
            this.tabPageView.Controls.Add(this.panelFilter);
            this.tabPageView.Location = new System.Drawing.Point(4, 22);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(724, 537);
            this.tabPageView.TabIndex = 0;
            this.tabPageView.Text = "Просмотр";
            this.tabPageView.UseVisualStyleBackColor = true;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.Controls.Add(this.dgvEvents);
            this.tabPageEvents.Location = new System.Drawing.Point(4, 22);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEvents.Size = new System.Drawing.Size(724, 537);
            this.tabPageEvents.TabIndex = 1;
            this.tabPageEvents.Text = "События";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.AutoGenerateColumns = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.srNumDgvColumn,
            this.instructionDataGridViewTextBoxColumn1,
            this.acceptFIODataGridViewTextBoxColumn1,
            this.makerFioDataGridViewTextBoxColumn1,
            this.evntDataGridViewTextBoxColumn,
            this.evntDateDataGridViewTextBoxColumn,
            this.dispDataGridViewTextBoxColumn,
            this.closedDgvColumn,
            this.idDgvColumnEvent});
            this.dgvEvents.DataSource = this.bsOrderEvents;
            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvents.Location = new System.Drawing.Point(3, 3);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersWidth = 21;
            this.dgvEvents.RowTemplate.Height = 44;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(718, 531);
            this.dgvEvents.TabIndex = 0;
            this.dgvEvents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellDoubleClick);
            this.dgvEvents.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEvents_CellFormatting);
            // 
            // bsOrderEvents
            // 
            this.bsOrderEvents.DataMember = "vJ_OrderEvents";
            this.bsOrderEvents.DataSource = this.dataSetOrder;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelDateFilter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlOrder);
            this.splitContainer1.Size = new System.Drawing.Size(918, 563);
            this.splitContainer1.SplitterDistance = 182;
            this.splitContainer1.TabIndex = 6;
            // 
            // dataGridViewFilterTextBoxColumn1
            // 
            this.dataGridViewFilterTextBoxColumn1.DataPropertyName = "num";
            this.dataGridViewFilterTextBoxColumn1.HeaderText = "№";
            this.dataGridViewFilterTextBoxColumn1.Name = "dataGridViewFilterTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn1.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OutputMaker";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Наряд выдал Производитель работ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewFilterTextBoxColumn2
            // 
            this.dataGridViewFilterTextBoxColumn2.DataPropertyName = "srNum";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewFilterTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewFilterTextBoxColumn2.HeaderText = "Сетевой район";
            this.dataGridViewFilterTextBoxColumn2.Name = "srNumDgvColumn2";
            this.dataGridViewFilterTextBoxColumn2.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFilterTextBoxColumn2.Width = 80;
            // 
            // dataGridViewFilterTextBoxColumn3
            // 
            this.dataGridViewFilterTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn3.DataPropertyName = "instruction";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewFilterTextBoxColumn3.HeaderText = "Содержание работ";
            this.dataGridViewFilterTextBoxColumn3.Name = "dataGridViewFilterTextBoxColumn3";
            this.dataGridViewFilterTextBoxColumn3.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Resolution";
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.HeaderText = "Разрешение выдал";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idSR";
            this.dataGridViewTextBoxColumn3.HeaderText = "idSR";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "srName";
            this.dataGridViewTextBoxColumn4.HeaderText = "srName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "headworker";
            this.dataGridViewTextBoxColumn5.HeaderText = "headworker";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "headFio";
            this.dataGridViewTextBoxColumn6.HeaderText = "headFio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "acceptworker";
            this.dataGridViewTextBoxColumn7.HeaderText = "acceptworker";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "acceptFIO";
            this.dataGridViewTextBoxColumn8.HeaderText = "acceptFIO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn9.HeaderText = "id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "watchWorker";
            this.dataGridViewTextBoxColumn10.HeaderText = "watchWorker";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "watchFIO";
            this.dataGridViewTextBoxColumn11.HeaderText = "watchFIO";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "makerWorker";
            this.dataGridViewTextBoxColumn12.HeaderText = "makerWorker";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "makerFIO";
            this.dataGridViewTextBoxColumn13.HeaderText = "makerFIO";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "otherInstruction";
            this.dataGridViewTextBoxColumn14.HeaderText = "otherInstruction";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "outputWorker";
            this.dataGridViewTextBoxColumn15.HeaderText = "outputWorker";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "outputFIO";
            this.dataGridViewTextBoxColumn16.HeaderText = "outputFIO";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "dateClose";
            this.dataGridViewTextBoxColumn17.HeaderText = "dateClose";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "closeWorker";
            this.dataGridViewTextBoxColumn18.HeaderText = "closeWorker";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "closeFIO";
            this.dataGridViewTextBoxColumn19.HeaderText = "closeFIO";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Visible = false;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "beginRes";
            this.dataGridViewTextBoxColumn20.HeaderText = "beginRes";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "EndRes";
            this.dataGridViewTextBoxColumn21.HeaderText = "EndRes";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "resWorkerId";
            this.dataGridViewTextBoxColumn22.HeaderText = "resWorkerId";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "resWorker";
            this.dataGridViewTextBoxColumn23.HeaderText = "resWorker";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn24.HeaderText = "id";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn4
            // 
            this.dataGridViewFilterTextBoxColumn4.DataPropertyName = "num";
            this.dataGridViewFilterTextBoxColumn4.HeaderText = "№ наряда";
            this.dataGridViewFilterTextBoxColumn4.Name = "dataGridViewFilterTextBoxColumn4";
            this.dataGridViewFilterTextBoxColumn4.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn4.Width = 60;
            // 
            // dataGridViewFilterTextBoxColumn5
            // 
            this.dataGridViewFilterTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFilterTextBoxColumn5.DataPropertyName = "instruction";
            this.dataGridViewFilterTextBoxColumn5.HeaderText = "Содержание работ";
            this.dataGridViewFilterTextBoxColumn5.Name = "dataGridViewFilterTextBoxColumn5";
            this.dataGridViewFilterTextBoxColumn5.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn6
            // 
            this.dataGridViewFilterTextBoxColumn6.DataPropertyName = "acceptFIO";
            this.dataGridViewFilterTextBoxColumn6.HeaderText = "Допускающий";
            this.dataGridViewFilterTextBoxColumn6.Name = "dataGridViewFilterTextBoxColumn6";
            this.dataGridViewFilterTextBoxColumn6.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn7
            // 
            this.dataGridViewFilterTextBoxColumn7.DataPropertyName = "makerFio";
            this.dataGridViewFilterTextBoxColumn7.HeaderText = "Производитель";
            this.dataGridViewFilterTextBoxColumn7.Name = "dataGridViewFilterTextBoxColumn7";
            this.dataGridViewFilterTextBoxColumn7.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn8
            // 
            this.dataGridViewFilterTextBoxColumn8.DataPropertyName = "Evnt";
            this.dataGridViewFilterTextBoxColumn8.HeaderText = "Состояние работ";
            this.dataGridViewFilterTextBoxColumn8.Name = "dataGridViewFilterTextBoxColumn8";
            this.dataGridViewFilterTextBoxColumn8.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "EvntDate";
            this.dataGridViewTextBoxColumn25.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "closed";
            this.dataGridViewTextBoxColumn26.HeaderText = "closed";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn9
            // 
            this.dataGridViewFilterTextBoxColumn9.DataPropertyName = "disp";
            this.dataGridViewFilterTextBoxColumn9.HeaderText = "Диспетчер";
            this.dataGridViewFilterTextBoxColumn9.Name = "dataGridViewFilterTextBoxColumn9";
            this.dataGridViewFilterTextBoxColumn9.ReadOnly = true;
            this.dataGridViewFilterTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // numDgvColumn
            // 
            this.numDgvColumn.DataPropertyName = "num";
            this.numDgvColumn.HeaderText = "№";
            this.numDgvColumn.Name = "numDgvColumn";
            this.numDgvColumn.ReadOnly = true;
            this.numDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numDgvColumn.Width = 50;
            // 
            // srNumDataGridViewTextBoxColumn
            // 
            this.srNumDataGridViewTextBoxColumn.DataPropertyName = "srNum";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.srNumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.srNumDataGridViewTextBoxColumn.HeaderText = "Сетевой район";
            this.srNumDataGridViewTextBoxColumn.Name = "srNumDataGridViewTextBoxColumn";
            this.srNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.srNumDataGridViewTextBoxColumn.Width = 90;
            // 
            // dateOutputDataGridViewTextBoxColumn
            // 
            this.dateOutputDataGridViewTextBoxColumn.DataPropertyName = "dateOutput";
            dataGridViewCellStyle3.Format = "dd.MM.yyyy HH:mm:ss";
            this.dateOutputDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateOutputDataGridViewTextBoxColumn.HeaderText = "Дата выдачи наряда";
            this.dateOutputDataGridViewTextBoxColumn.Name = "dateOutputDataGridViewTextBoxColumn";
            this.dateOutputDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOutputDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateOutputDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateBeginDataGridViewTextBoxColumn
            // 
            this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "dateBegin";
            this.dateBeginDataGridViewTextBoxColumn.HeaderText = "Дата начала работ";
            this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
            this.dateBeginDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateBeginDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "dateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "Дата окончания работ";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateEndDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // registeredDgvColumn
            // 
            this.registeredDgvColumn.DataPropertyName = "registered";
            this.registeredDgvColumn.HeaderText = "Зарегистрирован";
            this.registeredDgvColumn.Name = "registeredDgvColumn";
            this.registeredDgvColumn.ReadOnly = true;
            this.registeredDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.registeredDgvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.registeredDgvColumn.Visible = false;

            this.outputMakerDataGridViewTextBoxColumn.DataPropertyName = "OutputMaker";
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            this.outputMakerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.outputMakerDataGridViewTextBoxColumn.HeaderText = "Наряд выдал Производитель работ";
            this.outputMakerDataGridViewTextBoxColumn.Name = "outputMakerDataGridViewTextBoxColumn";
            this.outputMakerDataGridViewTextBoxColumn.ReadOnly = true;
            this.outputMakerDataGridViewTextBoxColumn.Visible = false;

            this.dataGridViewTextBoxColumn1.DataPropertyName = "OutputMaker";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Наряд выдал Производитель работ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;


            // 
            // instructionDataGridViewTextBoxColumn
            // 
            this.instructionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.instructionDataGridViewTextBoxColumn.DataPropertyName = "instruction";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.instructionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.instructionDataGridViewTextBoxColumn.HeaderText = "Содержание работ";
            this.instructionDataGridViewTextBoxColumn.Name = "instructionDataGridViewTextBoxColumn";
            this.instructionDataGridViewTextBoxColumn.ReadOnly = true;
            this.instructionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;

            this.resolutionDataGridViewTextBoxColumn.DataPropertyName = "Resolution";
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.True;
            this.resolutionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.resolutionDataGridViewTextBoxColumn.HeaderText = "Разрешение выдал";
            this.resolutionDataGridViewTextBoxColumn.Name = "resolutionDataGridViewTextBoxColumn";
            this.resolutionDataGridViewTextBoxColumn.ReadOnly = true;
            this.resolutionDataGridViewTextBoxColumn.Width = 120;
            this.resolutionDataGridViewTextBoxColumn.Visible = false;
            // 
            // srNameDataGridViewTextBoxColumn
            // 
            this.srNameDataGridViewTextBoxColumn.DataPropertyName = "srName";
            this.srNameDataGridViewTextBoxColumn.HeaderText = "Сетевой район (имя)";
            this.srNameDataGridViewTextBoxColumn.Name = "srNameDataGridViewTextBoxColumn";
            this.srNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.srNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.srNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // headFioDataGridViewTextBoxColumn
            // 
            this.headFioDataGridViewTextBoxColumn.DataPropertyName = "headFio";
            this.headFioDataGridViewTextBoxColumn.HeaderText = "Руководитель работ";
            this.headFioDataGridViewTextBoxColumn.Name = "headFioDataGridViewTextBoxColumn";
            this.headFioDataGridViewTextBoxColumn.ReadOnly = true;
            this.headFioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.headFioDataGridViewTextBoxColumn.Visible = false;
            // 
            // acceptFIODataGridViewTextBoxColumn
            // 
            this.acceptFIODataGridViewTextBoxColumn.DataPropertyName = "acceptFIO";
            this.acceptFIODataGridViewTextBoxColumn.HeaderText = "Допускающий";
            this.acceptFIODataGridViewTextBoxColumn.Name = "acceptFIODataGridViewTextBoxColumn";
            this.acceptFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.acceptFIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.acceptFIODataGridViewTextBoxColumn.Visible = false;
            // 
            // watchFIODataGridViewTextBoxColumn
            // 
            this.watchFIODataGridViewTextBoxColumn.DataPropertyName = "watchFIO";
            this.watchFIODataGridViewTextBoxColumn.HeaderText = "Наблюдающий";
            this.watchFIODataGridViewTextBoxColumn.Name = "watchFIODataGridViewTextBoxColumn";
            this.watchFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.watchFIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.watchFIODataGridViewTextBoxColumn.Visible = false;
            // 
            // makerFIODataGridViewTextBoxColumn
            // 
            this.makerFIODataGridViewTextBoxColumn.DataPropertyName = "makerFIO";
            this.makerFIODataGridViewTextBoxColumn.HeaderText = "Производитель работ";
            this.makerFIODataGridViewTextBoxColumn.Name = "makerFIODataGridViewTextBoxColumn";
            this.makerFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.makerFIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.makerFIODataGridViewTextBoxColumn.Visible = false;
            // 
            // otherInstructionDataGridViewTextBoxColumn
            // 
            this.otherInstructionDataGridViewTextBoxColumn.DataPropertyName = "otherInstruction";
            this.otherInstructionDataGridViewTextBoxColumn.HeaderText = "Отдельные указания";
            this.otherInstructionDataGridViewTextBoxColumn.Name = "otherInstructionDataGridViewTextBoxColumn";
            this.otherInstructionDataGridViewTextBoxColumn.ReadOnly = true;
            this.otherInstructionDataGridViewTextBoxColumn.Visible = false;
            // 
            // outputFIODataGridViewTextBoxColumn
            // 
            this.outputFIODataGridViewTextBoxColumn.DataPropertyName = "outputFIO";
            this.outputFIODataGridViewTextBoxColumn.HeaderText = "Наряд выдал";
            this.outputFIODataGridViewTextBoxColumn.Name = "outputFIODataGridViewTextBoxColumn";
            this.outputFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.outputFIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.outputFIODataGridViewTextBoxColumn.Visible = false;
            // 
            // dateCloseDgvColumn
            // 
            this.dateCloseDgvColumn.DataPropertyName = "dateClose";
            this.dateCloseDgvColumn.HeaderText = "Дата закрытия";
            this.dateCloseDgvColumn.Name = "dateCloseDgvColumn";
            this.dateCloseDgvColumn.ReadOnly = true;
            this.dateCloseDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateCloseDgvColumn.Visible = false;
            // 
            // closeFIODataGridViewTextBoxColumn
            // 
            this.closeFIODataGridViewTextBoxColumn.DataPropertyName = "closeFIO";
            this.closeFIODataGridViewTextBoxColumn.HeaderText = "Закрыл наряд";
            this.closeFIODataGridViewTextBoxColumn.Name = "closeFIODataGridViewTextBoxColumn";
            this.closeFIODataGridViewTextBoxColumn.ReadOnly = true;
            this.closeFIODataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.closeFIODataGridViewTextBoxColumn.Visible = false;
            // 
            // beginResDgvColumn
            // 
            this.beginResDgvColumn.DataPropertyName = "beginRes";
            this.beginResDgvColumn.HeaderText = "beginRes";
            this.beginResDgvColumn.Name = "beginResDgvColumn";
            this.beginResDgvColumn.ReadOnly = true;
            this.beginResDgvColumn.Visible = false;
            // 
            // EndResDgvColumn
            // 
            this.EndResDgvColumn.DataPropertyName = "EndRes";
            this.EndResDgvColumn.HeaderText = "EndRes";
            this.EndResDgvColumn.Name = "EndResDgvColumn";
            this.EndResDgvColumn.ReadOnly = true;
            this.EndResDgvColumn.Visible = false;
            // 
            // idDgvColumn
            // 
            this.idDgvColumn.DataPropertyName = "id";
            this.idDgvColumn.HeaderText = "id";
            this.idDgvColumn.Name = "idDgvColumn";
            this.idDgvColumn.ReadOnly = true;
            this.idDgvColumn.Visible = false;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "№ наряда";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numDataGridViewTextBoxColumn.Width = 60;
            //
            this.srNumDgvColumn.DataPropertyName = "srNum";
            this.srNumDgvColumn.HeaderText = "Сетевой район";
            this.srNumDgvColumn.Name = "srNumDgvColumn";
            this.srNumDgvColumn.ReadOnly = true;
            this.srNumDgvColumn.Width = 50;

            // 
            // instructionDataGridViewTextBoxColumn1
            // 
            this.instructionDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.instructionDataGridViewTextBoxColumn1.DataPropertyName = "instruction";
            this.instructionDataGridViewTextBoxColumn1.HeaderText = "Содержание работ";
            this.instructionDataGridViewTextBoxColumn1.Name = "instructionDataGridViewTextBoxColumn1";
            this.instructionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.instructionDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // acceptFIODataGridViewTextBoxColumn1
            // 
            this.acceptFIODataGridViewTextBoxColumn1.DataPropertyName = "acceptFIO";
            this.acceptFIODataGridViewTextBoxColumn1.HeaderText = "Допускающий";
            this.acceptFIODataGridViewTextBoxColumn1.Name = "acceptFIODataGridViewTextBoxColumn1";
            this.acceptFIODataGridViewTextBoxColumn1.ReadOnly = true;
            this.acceptFIODataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // makerFioDataGridViewTextBoxColumn1
            // 
            this.makerFioDataGridViewTextBoxColumn1.DataPropertyName = "makerFio";
            this.makerFioDataGridViewTextBoxColumn1.HeaderText = "Производитель";
            this.makerFioDataGridViewTextBoxColumn1.Name = "makerFioDataGridViewTextBoxColumn1";
            this.makerFioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.makerFioDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // evntDataGridViewTextBoxColumn
            // 
            this.evntDataGridViewTextBoxColumn.DataPropertyName = "Evnt";
            this.evntDataGridViewTextBoxColumn.HeaderText = "Состояние работ";
            this.evntDataGridViewTextBoxColumn.Name = "evntDataGridViewTextBoxColumn";
            this.evntDataGridViewTextBoxColumn.ReadOnly = true;
            this.evntDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // evntDateDataGridViewTextBoxColumn
            // 
            this.evntDateDataGridViewTextBoxColumn.DataPropertyName = "EvntDate";
            this.evntDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.evntDateDataGridViewTextBoxColumn.Name = "evntDateDataGridViewTextBoxColumn";
            this.evntDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.evntDateDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dispDataGridViewTextBoxColumn
            // 
            this.dispDataGridViewTextBoxColumn.DataPropertyName = "disp";
            this.dispDataGridViewTextBoxColumn.HeaderText = "Диспетчер";
            this.dispDataGridViewTextBoxColumn.Name = "dispDataGridViewTextBoxColumn";
            this.dispDataGridViewTextBoxColumn.ReadOnly = true;
            this.dispDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // closedDgvColumn
            // 
            this.closedDgvColumn.DataPropertyName = "closed";
            this.closedDgvColumn.HeaderText = "closed";
            this.closedDgvColumn.Name = "closedDgvColumn";
            this.closedDgvColumn.ReadOnly = true;
            this.closedDgvColumn.Visible = false;
            // 
            // idDgvColumnEvent
            // 
            this.idDgvColumnEvent.DataPropertyName = "id";
            this.idDgvColumnEvent.HeaderText = "id";
            this.idDgvColumnEvent.Name = "idDgvColumnEvent";
            this.idDgvColumnEvent.ReadOnly = true;
            this.idDgvColumnEvent.Visible = false;
            // 
            // FormJournalOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 588);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJournalOrder";
            this.Text = "Журнал нарядов (N1)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJournalOrder_FormClosed);
            this.Load += new System.EventHandler(this.FormJournalOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOrder)).EndInit();
            this.toolStripOrder.ResumeLayout(false);
            this.toolStripOrder.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelDateFilter.ResumeLayout(false);
            this.panelDateFilter.PerformLayout();
            this.panelTree.ResumeLayout(false);
            this.splitContainerFilter.Panel1.ResumeLayout(false);
            this.splitContainerFilter.Panel1.PerformLayout();
            this.splitContainerFilter.Panel2.ResumeLayout(false);
            this.splitContainerFilter.Panel2.PerformLayout();
            this.splitContainerFilter.ResumeLayout(false);
            this.toolStripFilter.ResumeLayout(false);
            this.toolStripFilter.PerformLayout();
            this.tabControlOrder.ResumeLayout(false);
            this.tabPageView.ResumeLayout(false);
            this.tabPageEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOrderEvents)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private DataSet.DataSetOrder dataSetOrder;
        private DataGridViewExcelFilter dgvOrder;
        private BindingSource bsOrder;
        private ToolStrip toolStripOrder;
        private ToolStripButton toolBtnAddOrder;
        private ToolStripButton toolBtnEditOrder;
        private ToolStripButton toolBtnDelOrder;
        private ToolStripButton toolBtnReport;
        private ToolStripButton toolBtnReportExcel;
        private ToolStripSeparator toolStripSeparator1;
        private Panel panelFilter;
        private CheckBox checkBoxCloseOrder;
        private CheckBox checkBoxCurrentOrder;
        private CheckBox checkBoxRegistered;
        private CheckBox checkBoxNoRegistered;
        private Panel panelDateFilter;
        private ToolStripButton toolBtnReadOrder;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolBtnRefresh;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolBtnOrderClose;
        private TabControl tabControlOrder;
        private TabPage tabPageView;
        private TabPage tabPageEvents;
        private BindingSource bsOrderEvents;
        private DataGridViewExcelFilter dgvEvents;
        private DateTimePicker dateTimePickerEnd;
        private Label label2;
        private DateTimePicker dateTimePickerBegin;
        private Label label1;
        private TreeViewSchmObjects treeViewSchmObjects;
        private SplitContainer splitContainer1;
        private Panel panelTree;
        private ToolStrip toolStripFilter;
        private ToolStripButton toolBtnFilter;
        private ToolStripButton toolBtnFilterClear;
        private ToolStripButton toolBtnFind;
        private ToolStripTextBox toolTextBoxFind;
        private ToolStripButton toolBtnFindPrev;
        private ToolStripButton toolBtnFindNext;
        private ToolStripDropDownButton toolBtnAddOrderDivision;
        private SplitContainer splitContainerFilter;
        private CheckedListBox checkedListBoxDivision;
        private Label label3;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn9;
        private DataGridViewFilterTextBoxColumn outputMakerDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn resolutionDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn srNumDgvColumn;
        private CheckBox checkBoxWhereSub;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton1;
        private DataGridViewFilterTextBoxColumn numDgvColumn;
        private DataGridViewFilterTextBoxColumn srNumDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateOutputDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateBeginDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private DataGridViewFilterCheckBoxColumn registeredDgvColumn;
        private DataGridViewFilterTextBoxColumn instructionDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn srNameDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn headFioDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn acceptFIODataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn watchFIODataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn makerFIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn otherInstructionDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn outputFIODataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateCloseDgvColumn;
        private DataGridViewFilterTextBoxColumn closeFIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn beginResDgvColumn;
        private DataGridViewTextBoxColumn EndResDgvColumn;
        private DataGridViewTextBoxColumn idDgvColumn;
        private DataGridViewFilterTextBoxColumn numDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn instructionDataGridViewTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn acceptFIODataGridViewTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn makerFioDataGridViewTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn evntDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn evntDateDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dispDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn closedDgvColumn;
        private DataGridViewTextBoxColumn idDgvColumnEvent;
    }
}
