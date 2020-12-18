using ControlsLbr.DataGridViewExcelFilter;
using RequestForRepair.DataSets;
//using Documents.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RequestForRepair
{
    partial class FormJournalRequestForRepair
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolSplitBtnAddRequestRepair = new System.Windows.Forms.ToolStripSplitButton();
            this.toolBtnEditRequestRepair = new System.Windows.Forms.ToolStripButton();
            this.toolBtnReadRequestRepair = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelRequestRepair = new System.Windows.Forms.ToolStripButton();
            this.toolBtnImport = new System.Windows.Forms.ToolStripSplitButton();
            this.toolBtnImportODS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnImportPL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProgressBarLoad = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripLabelLoad = new System.Windows.Forms.ToolStripLabel();
            this.toolBtnRequestCopy = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSeparator_0 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBrnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolBtnReport = new System.Windows.Forms.ToolStripButton();
            this.toolBtnExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnFind = new System.Windows.Forms.ToolStripButton();
            this.toolTextFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnSettingsSend = new System.Windows.Forms.ToolStripButton();
            this.dgv = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.isSendDgvColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.isPlannedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deletedDgvCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateCreateDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.sRDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.reguestFiledDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.schmObjDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.PurposeDgvTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateTripBegDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateTripEndDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateFactEndDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.agreedDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.agreeWithDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewImageColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.workerCreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAgreedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddivisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.sendSiteDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorStatusDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.bindingSourceJournalRequestForRepair = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetGES_0 = new RequestForRepair.DataSets.DataSetN();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.checkedListBoxDivision = new System.Windows.Forms.CheckedListBox();
            this.label_2 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBeg = new System.Windows.Forms.DateTimePicker();
            this.label_1 = new System.Windows.Forms.Label();
            this.label_0 = new System.Windows.Forms.Label();
            this.toolStripFilter = new System.Windows.Forms.ToolStrip();
            this.toolBtnFilter = new System.Windows.Forms.ToolStripButton();
            this.toolBtnNoFilter = new System.Windows.Forms.ToolStripButton();
            this.splitContainerDgv = new System.Windows.Forms.SplitContainer();
            this.dgvDamage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.numrequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schmObjNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isApplyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingSource_1 = new System.Windows.Forms.BindingSource(this.components);
            //this.dataSetDamage_0 = new RequestForRepair.DataSets.dsDamage();
            this.lbChildDoc = new System.Windows.Forms.Label();
            this.backgroundWorkerLoad = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewFilterTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn3 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn4 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn5 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn6 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn7 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn8 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn9 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn10 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn11 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn12 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceJournalRequestForRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGES_0)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStripFilter.SuspendLayout();
            this.splitContainerDgv.Panel1.SuspendLayout();
            this.splitContainerDgv.Panel2.SuspendLayout();
            this.splitContainerDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_1)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dataSetDamage_0)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSplitBtnAddRequestRepair,
            this.toolBtnEditRequestRepair,
            this.toolBtnReadRequestRepair,
            this.toolBtnDelRequestRepair,
            this.toolBtnImport,
            this.toolStripProgressBarLoad,
            this.toolStripLabelLoad,
            this.toolBtnRequestCopy,
            this.toolStripSeparator_0,
            this.toolBrnRefresh,
            this.toolBtnReport,
            this.toolBtnExport,
            this.toolStripSeparator2,
            this.toolBtnFind,
            this.toolTextFind,
            this.toolBtnFindPrev,
            this.toolBtnFindNext,
            this.toolStripSeparator3,
            this.toolBtnSettingsSend});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1026, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolSplitBtnAddRequestRepair
            // 
            this.toolSplitBtnAddRequestRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSplitBtnAddRequestRepair.Image = global::RequestForRepair.Properties.Resources.ElementAdd;
            this.toolSplitBtnAddRequestRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSplitBtnAddRequestRepair.Name = "toolSplitBtnAddRequestRepair";
            this.toolSplitBtnAddRequestRepair.Size = new System.Drawing.Size(32, 22);
            this.toolSplitBtnAddRequestRepair.Text = "Новая заявка";
            // 
            // toolBtnEditRequestRepair
            // 
            this.toolBtnEditRequestRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEditRequestRepair.Image = global::RequestForRepair.Properties.Resources.ElementEdit;
            this.toolBtnEditRequestRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEditRequestRepair.Name = "toolBtnEditRequestRepair";
            this.toolBtnEditRequestRepair.Size = new System.Drawing.Size(23, 22);
            this.toolBtnEditRequestRepair.Text = "Редактировать заявку";
            this.toolBtnEditRequestRepair.Click += new System.EventHandler(this.toolBtnEditRequestRepair_Click);
            // 
            // toolBtnReadRequestRepair
            // 
            this.toolBtnReadRequestRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReadRequestRepair.Image = global::RequestForRepair.Properties.Resources.ElementInformation;
            this.toolBtnReadRequestRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReadRequestRepair.Name = "toolBtnReadRequestRepair";
            this.toolBtnReadRequestRepair.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReadRequestRepair.Text = "Просмотр заявки";
            this.toolBtnReadRequestRepair.Click += new System.EventHandler(this.toolBtnReadRequestRepair_Click);
            // 
            // toolBtnDelRequestRepair
            // 
            this.toolBtnDelRequestRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelRequestRepair.Image = global::RequestForRepair.Properties.Resources.ElementDel;
            this.toolBtnDelRequestRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelRequestRepair.Name = "toolBtnDelRequestRepair";
            this.toolBtnDelRequestRepair.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelRequestRepair.Text = "Удалить заявку";
            this.toolBtnDelRequestRepair.Click += new System.EventHandler(this.toolBtnDelRequestRepair_Click);
            // 
            // toolBtnImport
            // 
            this.toolBtnImport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBtnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnImport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnImportODS,
            this.toolBtnImportPL});
            this.toolBtnImport.Image = global::RequestForRepair.Properties.Resources.Import2;
            this.toolBtnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnImport.Name = "toolBtnImport";
            this.toolBtnImport.Size = new System.Drawing.Size(32, 22);
            this.toolBtnImport.Text = "toolStripSplitButton1";
            // 
            // toolBtnImportODS
            // 
            this.toolBtnImportODS.Name = "toolBtnImportODS";
            this.toolBtnImportODS.Size = new System.Drawing.Size(99, 22);
            this.toolBtnImportODS.Text = "ОДС";
            this.toolBtnImportODS.Click += new System.EventHandler(this.toolBtnImportODS_Click);
            // 
            // toolBtnImportPL
            // 
            this.toolBtnImportPL.Name = "toolBtnImportPL";
            this.toolBtnImportPL.Size = new System.Drawing.Size(99, 22);
            this.toolBtnImportPL.Text = "ПЛ";
            this.toolBtnImportPL.Click += new System.EventHandler(this.toolBtnImportPL_Click);
            // 
            // toolStripProgressBarLoad
            // 
            this.toolStripProgressBarLoad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripProgressBarLoad.Name = "toolStripProgressBarLoad";
            this.toolStripProgressBarLoad.Size = new System.Drawing.Size(100, 22);
            this.toolStripProgressBarLoad.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBarLoad.Visible = false;
            // 
            // toolStripLabelLoad
            // 
            this.toolStripLabelLoad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelLoad.Name = "toolStripLabelLoad";
            this.toolStripLabelLoad.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabelLoad.Text = "Загрузка";
            this.toolStripLabelLoad.Visible = false;
            // 
            // toolBtnRequestCopy
            // 
            this.toolBtnRequestCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRequestCopy.Image = global::RequestForRepair.Properties.Resources.CopyBuffer;
            this.toolBtnRequestCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRequestCopy.Name = "toolBtnRequestCopy";
            this.toolBtnRequestCopy.Size = new System.Drawing.Size(32, 22);
            this.toolBtnRequestCopy.Text = "Копировать";
            // 
            // toolStripSeparator_0
            // 
            this.toolStripSeparator_0.Name = "toolStripSeparator_0";
            this.toolStripSeparator_0.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBrnRefresh
            // 
            this.toolBrnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBrnRefresh.Image = global::RequestForRepair.Properties.Resources.refresh_16;
            this.toolBrnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBrnRefresh.Name = "toolBrnRefresh";
            this.toolBrnRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolBrnRefresh.Text = "Обновить";
            this.toolBrnRefresh.Click += new System.EventHandler(this.toolBrnRefresh_Click);
            // 
            // toolBtnReport
            // 
            this.toolBtnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReport.Image = global::RequestForRepair.Properties.Resources.report1;
            this.toolBtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReport.Text = "Отчет";
            this.toolBtnReport.Click += new System.EventHandler(this.toolBtnReport_Click);
            // 
            // toolBtnExport
            // 
            this.toolBtnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnExport.Image = global::RequestForRepair.Properties.Resources.report_go;
            this.toolBtnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnExport.Name = "toolBtnExport";
            this.toolBtnExport.Size = new System.Drawing.Size(23, 22);
            this.toolBtnExport.Text = "Экспорт";
            this.toolBtnExport.Click += new System.EventHandler(this.toolBtnExport_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnFind
            // 
            this.toolBtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFind.Image = global::RequestForRepair.Properties.Resources.Find;
            this.toolBtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFind.Name = "toolBtnFind";
            this.toolBtnFind.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFind.Text = "Поиск";
            this.toolBtnFind.Click += new System.EventHandler(this.toolBtnFind_Click);
            // 
            // toolTextFind
            // 
            this.toolTextFind.Name = "toolTextFind";
            this.toolTextFind.Size = new System.Drawing.Size(150, 25);
            this.toolTextFind.ToolTipText = "Текст для поиска";
            this.toolTextFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTextFind_KeyDown);
            // 
            // toolBtnFindPrev
            // 
            this.toolBtnFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = global::RequestForRepair.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindPrev.Text = "Поиск назад";
            this.toolBtnFindPrev.Click += new System.EventHandler(this.toolBtnFindPrev_Click);
            // 
            // toolBtnFindNext
            // 
            this.toolBtnFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::RequestForRepair.Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindNext.Text = "Поиск вперед";
            this.toolBtnFindNext.Click += new System.EventHandler(this.toolBtnFindNext_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnSettingsSend
            // 
            this.toolBtnSettingsSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSettingsSend.Image = global::RequestForRepair.Properties.Resources.FTP;
            this.toolBtnSettingsSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSettingsSend.Name = "toolBtnSettingsSend";
            this.toolBtnSettingsSend.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSettingsSend.Text = "Настройки отправки";
            this.toolBtnSettingsSend.Click += new System.EventHandler(this.toolBtnSettingsSend_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isSendDgvColumn,
            this.isPlannedDataGridViewCheckBoxColumn,
            this.deletedDgvCheckBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.dateCreateDgvColumn,
            this.sRDataGridViewTextBoxColumn,
            this.reguestFiledDataGridViewTextBoxColumn,
            this.schmObjDataGridViewTextBoxColumn,
            this.PurposeDgvTextBoxColumn,
            this.dateTripBegDgvColumn,
            this.dateTripEndDgvColumn,
            this.agreedDgvColumn,
            this.dateFactEndDgvColumn,
                this.agreeWithDataGridViewTextBoxColumn,

                this.commentDataGridViewImageColumn,
            this.workerCreateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dateAgreedDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.iddivisionDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.sendSiteDgvColumn,
            this.idDataGridViewTextBoxColumn,
            this.colorStatusDgvColumn});
            this.dgv.DataSource = this.bindingSourceJournalRequestForRepair;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 21;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(845, 400);
            this.dgv.TabIndex = 1;
            this.dgv.VirtualMode = true;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            this.dgv.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_RowPostPaint);
            // 
            // isSendDgvColumn
            // 
            this.isSendDgvColumn.DataPropertyName = "isSend";
            this.isSendDgvColumn.HeaderText = "isSend";
            this.isSendDgvColumn.Name = "isSendDgvColumn";
            this.isSendDgvColumn.ReadOnly = true;
            this.isSendDgvColumn.Visible = false;
            // 
            // isPlannedDataGridViewCheckBoxColumn
            // 
            this.isPlannedDataGridViewCheckBoxColumn.DataPropertyName = "IsPlanned";
            this.isPlannedDataGridViewCheckBoxColumn.HeaderText = "Плановый";
            this.isPlannedDataGridViewCheckBoxColumn.Name = "isPlannedDataGridViewCheckBoxColumn";
            this.isPlannedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isPlannedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // deletedDgvCheckBoxColumn
            // 
            this.deletedDgvCheckBoxColumn.DataPropertyName = "deleted";
            this.deletedDgvCheckBoxColumn.HeaderText = "Удалено";
            this.deletedDgvCheckBoxColumn.Name = "deletedDgvCheckBoxColumn";
            this.deletedDgvCheckBoxColumn.ReadOnly = true;
            this.deletedDgvCheckBoxColumn.Visible = false;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            this.numDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateCreateDgvColumn
            // 
            this.dateCreateDgvColumn.DataPropertyName = "dateCreate";
            this.dateCreateDgvColumn.HeaderText = "Дата";
            this.dateCreateDgvColumn.Name = "dateCreateDgvColumn";
            this.dateCreateDgvColumn.ReadOnly = true;
            // 
            // sRDataGridViewTextBoxColumn
            // 
            this.sRDataGridViewTextBoxColumn.DataPropertyName = "SRSocr";
            this.sRDataGridViewTextBoxColumn.HeaderText = "Район";
            this.sRDataGridViewTextBoxColumn.Name = "sRDataGridViewTextBoxColumn";
            this.sRDataGridViewTextBoxColumn.ReadOnly = true;
            this.sRDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // reguestFiledDataGridViewTextBoxColumn
            // 
            this.reguestFiledDataGridViewTextBoxColumn.DataPropertyName = "reguestFiled";
            this.reguestFiledDataGridViewTextBoxColumn.HeaderText = "Подал";
            this.reguestFiledDataGridViewTextBoxColumn.Name = "reguestFiledDataGridViewTextBoxColumn";
            this.reguestFiledDataGridViewTextBoxColumn.ReadOnly = true;
            this.reguestFiledDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // schmObjDataGridViewTextBoxColumn
            // 
            this.schmObjDataGridViewTextBoxColumn.DataPropertyName = "schmObj";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.schmObjDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.schmObjDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.schmObjDataGridViewTextBoxColumn.Name = "schmObjDataGridViewTextBoxColumn";
            this.schmObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.schmObjDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // PurposeDgvTextBoxColumn
            // 
            this.PurposeDgvTextBoxColumn.DataPropertyName = "Purpose";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PurposeDgvTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.PurposeDgvTextBoxColumn.HeaderText = "Цель";
            this.PurposeDgvTextBoxColumn.Name = "PurposeDgvTextBoxColumn";
            this.PurposeDgvTextBoxColumn.ReadOnly = true;
            // 
            // dateTripBegDataGridViewTextBoxColumn
            // 
            this.dateTripBegDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateTripBegDgvColumn.DataPropertyName = "DateTripBeg";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dateTripBegDgvColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dateTripBegDgvColumn.HeaderText = "Дата С";
            this.dateTripBegDgvColumn.Name = "dateTripBegDataGridViewTextBoxColumn";
            this.dateTripBegDgvColumn.ReadOnly = true;
            this.dateTripBegDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateTripEndDgvColumn
            // 
            this.dateTripEndDgvColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateTripEndDgvColumn.DataPropertyName = "DateTripEnd";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dateTripEndDgvColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.dateTripEndDgvColumn.HeaderText = "Дата По";
            this.dateTripEndDgvColumn.Name = "dateTripEndDgvColumn";
            this.dateTripEndDgvColumn.ReadOnly = true;
            this.dateTripEndDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // agreedDgvColumn
            // 
            this.agreedDgvColumn.DataPropertyName = "Agreed";
            this.agreedDgvColumn.FalseValue = "Нет";
            this.agreedDgvColumn.HeaderText = "Заявка разрешена";
            this.agreedDgvColumn.Name = "agreedDgvColumn";
            this.agreedDgvColumn.ReadOnly = true;
            this.agreedDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.agreedDgvColumn.TrueValue = "Да";
            //
            this.dateFactEndDgvColumn.DataPropertyName = "DateFactEnd";
            this.dateFactEndDgvColumn.HeaderText = "Фактическое время выполнения";
            this.dateFactEndDgvColumn.Name = "dateFactEndDgvColumn";
            this.dateFactEndDgvColumn.ReadOnly = true;
            this.dateFactEndDgvColumn.Visible = false;
            // 
            // agreeWithDataGridViewTextBoxColumn
            // 
            this.agreeWithDataGridViewTextBoxColumn.DataPropertyName = "AgreeWith";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.agreeWithDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.agreeWithDataGridViewTextBoxColumn.HeaderText = "Согласовать с";
            this.agreeWithDataGridViewTextBoxColumn.Name = "agreeWithDataGridViewTextBoxColumn";
            this.agreeWithDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewImageColumn
            // 
            this.commentDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.commentDataGridViewImageColumn.DataPropertyName = "Comment";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.commentDataGridViewImageColumn.HeaderText = "Комментарий";
            this.commentDataGridViewImageColumn.Name = "commentDataGridViewImageColumn";
            this.commentDataGridViewImageColumn.ReadOnly = true;
            this.commentDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.commentDataGridViewImageColumn.Width = 103;
            // 
            // workerCreateDataGridViewTextBoxColumn
            // 
            this.workerCreateDataGridViewTextBoxColumn.DataPropertyName = "workerCreate";
            this.workerCreateDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.workerCreateDataGridViewTextBoxColumn.Name = "workerCreateDataGridViewTextBoxColumn";
            this.workerCreateDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerCreateDataGridViewTextBoxColumn.Visible = false;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адреса";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateAgreedDataGridViewTextBoxColumn
            // 
            this.dateAgreedDataGridViewTextBoxColumn.DataPropertyName = "DateAgreed";
            dataGridViewCellStyle8.Format = "d";
            dataGridViewCellStyle8.NullValue = null;
            this.dateAgreedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.dateAgreedDataGridViewTextBoxColumn.HeaderText = "Дата согласования";
            this.dateAgreedDataGridViewTextBoxColumn.Name = "dateAgreedDataGridViewTextBoxColumn";
            this.dateAgreedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAgreedDataGridViewTextBoxColumn.Visible = false;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "Диспетчер";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Visible = false;
            // 
            // iddivisionDataGridViewTextBoxColumn
            // 
            this.iddivisionDataGridViewTextBoxColumn.DataPropertyName = "iddivision";
            this.iddivisionDataGridViewTextBoxColumn.HeaderText = "Код подразделения";
            this.iddivisionDataGridViewTextBoxColumn.Name = "iddivisionDataGridViewTextBoxColumn";
            this.iddivisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddivisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            this.divisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.divisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // sendSiteDgvColumn
            // 
            this.sendSiteDgvColumn.DataPropertyName = "SendSite";
            this.sendSiteDgvColumn.HeaderText = "На сайт";
            this.sendSiteDgvColumn.Name = "sendSiteDgvColumn";
            this.sendSiteDgvColumn.ReadOnly = true;
            this.sendSiteDgvColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // colorStatusDgvColumn
            // 
            this.colorStatusDgvColumn.DataPropertyName = "colorStatus";
            this.colorStatusDgvColumn.HeaderText = "colorStatus";
            this.colorStatusDgvColumn.Name = "colorStatusDgvColumn";
            this.colorStatusDgvColumn.ReadOnly = true;
            this.colorStatusDgvColumn.Visible = false;
            // 
            // bindingSourceJournalRequestForRepair
            // 
            this.bindingSourceJournalRequestForRepair.DataMember = "vJ_RequestForRepair";
            this.bindingSourceJournalRequestForRepair.DataSource = this.dataSetGES_0;
            this.bindingSourceJournalRequestForRepair.CurrentChanged += new System.EventHandler(this.bindingSourceJournalRequestForRepair_CurrentChanged);
            // 
            // dataSetGES_0
            // 
            this.dataSetGES_0.DataSetName = "DataSetGES";
            this.dataSetGES_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.checkedListBoxDivision);
            this.splitContainer.Panel1.Controls.Add(this.label_2);
            this.splitContainer.Panel1.Controls.Add(this.dateTimePickerEnd);
            this.splitContainer.Panel1.Controls.Add(this.dateTimePickerBeg);
            this.splitContainer.Panel1.Controls.Add(this.label_1);
            this.splitContainer.Panel1.Controls.Add(this.label_0);
            this.splitContainer.Panel1.Controls.Add(this.toolStripFilter);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainerDgv);
            this.splitContainer.Size = new System.Drawing.Size(1026, 554);
            this.splitContainer.SplitterDistance = 177;
            this.splitContainer.TabIndex = 2;
            // 
            // checkedListBoxDivision
            // 
            this.checkedListBoxDivision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxDivision.CheckOnClick = true;
            this.checkedListBoxDivision.FormattingEnabled = true;
            this.checkedListBoxDivision.Location = new System.Drawing.Point(15, 123);
            this.checkedListBoxDivision.Name = "checkedListBoxDivision";
            this.checkedListBoxDivision.Size = new System.Drawing.Size(153, 94);
            this.checkedListBoxDivision.TabIndex = 5;
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.Location = new System.Drawing.Point(12, 107);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(87, 13);
            this.label_2.TabIndex = 4;
            this.label_2.Text = "Подразделения";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerEnd.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(15, 84);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerEnd.TabIndex = 3;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // dateTimePickerBeg
            // 
            this.dateTimePickerBeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerBeg.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            this.dateTimePickerBeg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBeg.Location = new System.Drawing.Point(15, 45);
            this.dateTimePickerBeg.Name = "dateTimePickerBeg";
            this.dateTimePickerBeg.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerBeg.TabIndex = 2;
            this.dateTimePickerBeg.ValueChanged += new System.EventHandler(this.dateTimePickerBeg_ValueChanged);
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(12, 68);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(22, 13);
            this.label_1.TabIndex = 1;
            this.label_1.Text = "До";
            // 
            // label_0
            // 
            this.label_0.AutoSize = true;
            this.label_0.Location = new System.Drawing.Point(12, 29);
            this.label_0.Name = "label_0";
            this.label_0.Size = new System.Drawing.Size(20, 13);
            this.label_0.TabIndex = 0;
            this.label_0.Text = "От";
            // 
            // toolStripFilter
            // 
            this.toolStripFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnFilter,
            this.toolBtnNoFilter});
            this.toolStripFilter.Location = new System.Drawing.Point(0, 0);
            this.toolStripFilter.Name = "toolStripFilter";
            this.toolStripFilter.Size = new System.Drawing.Size(177, 25);
            this.toolStripFilter.TabIndex = 6;
            this.toolStripFilter.Text = "toolStrip1";
            // 
            // toolBtnFilter
            // 
            this.toolBtnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFilter.Image = global::RequestForRepair.Properties.Resources.filter;
            this.toolBtnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFilter.Name = "toolBtnFilter";
            this.toolBtnFilter.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFilter.Text = "Применить фильтр";
            this.toolBtnFilter.Click += new System.EventHandler(this.toolBtnFilter_Click);
            // 
            // toolBtnNoFilter
            // 
            this.toolBtnNoFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnNoFilter.Image = global::RequestForRepair.Properties.Resources.filter_delete;
            this.toolBtnNoFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnNoFilter.Name = "toolBtnNoFilter";
            this.toolBtnNoFilter.Size = new System.Drawing.Size(23, 22);
            this.toolBtnNoFilter.Text = "Убрать фильтр";
            this.toolBtnNoFilter.Click += new System.EventHandler(this.toolBtnNoFilter_Click);
            // 
            // splitContainerDgv
            // 
            this.splitContainerDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerDgv.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerDgv.Location = new System.Drawing.Point(0, 0);
            this.splitContainerDgv.Name = "splitContainerDgv";
            this.splitContainerDgv.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerDgv.Panel1
            // 
            this.splitContainerDgv.Panel1.Controls.Add(this.dgv);
            // 
            // splitContainerDgv.Panel2
            // 
            this.splitContainerDgv.Panel2.Controls.Add(this.dgvDamage);
            this.splitContainerDgv.Panel2.Controls.Add(this.lbChildDoc);
            this.splitContainerDgv.Panel2MinSize = 13;
            this.splitContainerDgv.Size = new System.Drawing.Size(845, 554);
            this.splitContainerDgv.SplitterDistance = 400;
            this.splitContainerDgv.TabIndex = 2;
            // 
            // dgvDamage
            // 
            this.dgvDamage.AllowUserToAddRows = false;
            this.dgvDamage.AllowUserToDeleteRows = false;
            this.dgvDamage.AllowUserToVisibleColumns = false;
            this.dgvDamage.AutoGenerateColumns = false;
            this.dgvDamage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numrequestDataGridViewTextBoxColumn,
            this.dateDocDataGridViewTextBoxColumn,
            this.typeDocNameDataGridViewTextBoxColumn,
            this.schmObjNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.isApplyDataGridViewCheckBoxColumn});
            this.dgvDamage.DataSource = this.bindingSource_1;
            this.dgvDamage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDamage.Location = new System.Drawing.Point(0, 13);
            this.dgvDamage.Name = "dgvDamage";
            this.dgvDamage.ReadOnly = true;
            this.dgvDamage.RowHeadersWidth = 21;
            this.dgvDamage.Size = new System.Drawing.Size(845, 137);
            this.dgvDamage.TabIndex = 9;
            // 
            // numrequestDataGridViewTextBoxColumn
            // 
            this.numrequestDataGridViewTextBoxColumn.DataPropertyName = "numrequest";
            this.numrequestDataGridViewTextBoxColumn.HeaderText = "№ док.";
            this.numrequestDataGridViewTextBoxColumn.Name = "numrequestDataGridViewTextBoxColumn";
            this.numrequestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDocDataGridViewTextBoxColumn
            // 
            this.dateDocDataGridViewTextBoxColumn.DataPropertyName = "dateDoc";
            this.dateDocDataGridViewTextBoxColumn.HeaderText = "Дата док";
            this.dateDocDataGridViewTextBoxColumn.Name = "dateDocDataGridViewTextBoxColumn";
            this.dateDocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDocNameDataGridViewTextBoxColumn
            // 
            this.typeDocNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDocNameDataGridViewTextBoxColumn.DataPropertyName = "TypeDocName";
            this.typeDocNameDataGridViewTextBoxColumn.HeaderText = "Тип документа";
            this.typeDocNameDataGridViewTextBoxColumn.Name = "typeDocNameDataGridViewTextBoxColumn";
            this.typeDocNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schmObjNameDataGridViewTextBoxColumn
            // 
            this.schmObjNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.schmObjNameDataGridViewTextBoxColumn.DataPropertyName = "schmObjName";
            this.schmObjNameDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.schmObjNameDataGridViewTextBoxColumn.Name = "schmObjNameDataGridViewTextBoxColumn";
            this.schmObjNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // isApplyDataGridViewCheckBoxColumn
            // 
            this.isApplyDataGridViewCheckBoxColumn.DataPropertyName = "isApply";
            this.isApplyDataGridViewCheckBoxColumn.HeaderText = "Исполнен";
            this.isApplyDataGridViewCheckBoxColumn.Name = "isApplyDataGridViewCheckBoxColumn";
            this.isApplyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bindingSource_1
            // 
            this.bindingSource_1.DataMember = "vJ_Damage";
            // this.bindingSource_1.DataSource = this.dataSetDamage_0;
            this.bindingSource_1.DataSource = this.dataSetGES_0;
            // 
            // dataSetDamage_0
            // 
            //this.dataSetDamage_0.DataSetName = "DataSetDamage";
            //this.dataSetDamage_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //// 
            // lbChildDoc
            // 
            this.lbChildDoc.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.lbChildDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbChildDoc.Location = new System.Drawing.Point(0, 0);
            this.lbChildDoc.Name = "lbChildDoc";
            this.lbChildDoc.Size = new System.Drawing.Size(845, 13);
            this.lbChildDoc.TabIndex = 8;
            this.lbChildDoc.Text = "Дочерние документы";
            this.lbChildDoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbChildDoc.Click += new System.EventHandler(this.lbChildDoc_Click);
            // 
            // backgroundWorkerLoad
            // 
            this.backgroundWorkerLoad.WorkerReportsProgress = true;
            this.backgroundWorkerLoad.WorkerSupportsCancellation = true;
            this.backgroundWorkerLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerLoad_DoWork);
            this.backgroundWorkerLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerLoad_RunWorkerCompleted);
            // 
            // dataGridViewFilterTextBoxColumn1
            // 
            this.dataGridViewFilterTextBoxColumn1.DataPropertyName = "num";
            this.dataGridViewFilterTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewFilterTextBoxColumn1.Name = "dataGridViewFilterTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn2
            // 
            this.dataGridViewFilterTextBoxColumn2.DataPropertyName = "dateCreate";
            this.dataGridViewFilterTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewFilterTextBoxColumn2.Name = "dataGridViewFilterTextBoxColumn2";
            // 
            // dataGridViewFilterTextBoxColumn3
            // 
            this.dataGridViewFilterTextBoxColumn3.DataPropertyName = "SRSocr";
            this.dataGridViewFilterTextBoxColumn3.HeaderText = "Район";
            this.dataGridViewFilterTextBoxColumn3.Name = "dataGridViewFilterTextBoxColumn3";
            this.dataGridViewFilterTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn4
            // 
            this.dataGridViewFilterTextBoxColumn4.DataPropertyName = "reguestFiled";
            this.dataGridViewFilterTextBoxColumn4.HeaderText = "Подал";
            this.dataGridViewFilterTextBoxColumn4.Name = "dataGridViewFilterTextBoxColumn4";
            this.dataGridViewFilterTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn5
            // 
            this.dataGridViewFilterTextBoxColumn5.DataPropertyName = "schmObj";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewFilterTextBoxColumn5.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn5.Name = "dataGridViewFilterTextBoxColumn5";
            this.dataGridViewFilterTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn6
            // 
            this.dataGridViewFilterTextBoxColumn6.DataPropertyName = "Purpose";
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewFilterTextBoxColumn6.HeaderText = "Цель";
            this.dataGridViewFilterTextBoxColumn6.Name = "dataGridViewFilterTextBoxColumn6";
            // 
            // dataGridViewFilterTextBoxColumn7
            // 
            this.dataGridViewFilterTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewFilterTextBoxColumn7.DataPropertyName = "DateTripBeg";
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewFilterTextBoxColumn7.HeaderText = "Дата С";
            this.dataGridViewFilterTextBoxColumn7.Name = "dataGridViewFilterTextBoxColumn7";
            this.dataGridViewFilterTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn8
            // 
            this.dataGridViewFilterTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewFilterTextBoxColumn8.DataPropertyName = "DateTripEnd";
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewFilterTextBoxColumn8.HeaderText = "Дата По";
            this.dataGridViewFilterTextBoxColumn8.Name = "dataGridViewFilterTextBoxColumn8";
            this.dataGridViewFilterTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn9
            // 
            this.dataGridViewFilterTextBoxColumn9.DataPropertyName = "DateFactEnd";
            this.dataGridViewFilterTextBoxColumn9.HeaderText = "Фактическое время выполнения";
            this.dataGridViewFilterTextBoxColumn9.Name = "dataGridViewFilterTextBoxColumn9";
            this.dataGridViewFilterTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AgreeWith";
            this.dataGridViewTextBoxColumn1.HeaderText = "Согласовать с";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewFilterTextBoxColumn10
            // 
            this.dataGridViewFilterTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewFilterTextBoxColumn10.DataPropertyName = "Comment";
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewFilterTextBoxColumn10.HeaderText = "Комментарий";
            this.dataGridViewFilterTextBoxColumn10.Name = "dataGridViewFilterTextBoxColumn10";
            this.dataGridViewFilterTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn10.Width = 103;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "workerCreate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Автор";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn3.HeaderText = "Адреса";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateAgreed";
            dataGridViewCellStyle15.Format = "d";
            dataGridViewCellStyle15.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewTextBoxColumn4.HeaderText = "Дата согласования";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn5.HeaderText = "Диспетчер";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "iddivision";
            this.dataGridViewTextBoxColumn6.HeaderText = "Код подразделения";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn11
            // 
            this.dataGridViewFilterTextBoxColumn11.DataPropertyName = "division";
            this.dataGridViewFilterTextBoxColumn11.HeaderText = "Подразделение";
            this.dataGridViewFilterTextBoxColumn11.Name = "dataGridViewFilterTextBoxColumn11";
            this.dataGridViewFilterTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn7.HeaderText = "id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn12
            // 
            this.dataGridViewFilterTextBoxColumn12.DataPropertyName = "colorStatus";
            this.dataGridViewFilterTextBoxColumn12.HeaderText = "colorStatus";
            this.dataGridViewFilterTextBoxColumn12.Name = "dataGridViewFilterTextBoxColumn12";
            this.dataGridViewFilterTextBoxColumn12.Visible = false;
            // 
            // FormJournalRequestForRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 579);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormJournalRequestForRepair";
            this.Text = "Журнал заявок на ремонт оборудования (N)";
            this.Load += new System.EventHandler(this.FormJournalRequestForRepair_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceJournalRequestForRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetGES_0)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.toolStripFilter.ResumeLayout(false);
            this.toolStripFilter.PerformLayout();
            this.splitContainerDgv.Panel1.ResumeLayout(false);
            this.splitContainerDgv.Panel2.ResumeLayout(false);
            this.splitContainerDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_1)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dataSetDamage_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //this.components = new Container();
        //ComponentResourceManager manager = new ComponentResourceManager(typeof(FormJournalRequestForRepair));
        //DataGridViewCellStyle style = new DataGridViewCellStyle();
        //DataGridViewCellStyle style2 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style3 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style4 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style5 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style6 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style7 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style8 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style9 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style10 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style11 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style12 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style13 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style14 = new DataGridViewCellStyle();
        //DataGridViewCellStyle style15 = new DataGridViewCellStyle();
        //this.toolStrip_0 = new ToolStrip();
        //this.toolStripSplitButton_0 = new ToolStripSplitButton();
        //this.toolStripButton_0 = new ToolStripButton();
        //this.toolStripButton_2 = new ToolStripButton();
        //this.toolStripButton_1 = new ToolStripButton();
        //this.toolStripSplitButton_1 = new ToolStripSplitButton();
        //this.toolStripMenuItem_0 = new ToolStripMenuItem();
        //this.toolStripMenuItem_1 = new ToolStripMenuItem();
        //this.toolStripProgressBar_0 = new ToolStripProgressBar();
        //this.toolStripLabel_0 = new ToolStripLabel();
        //this.toolStripSplitButton_2 = new ToolStripSplitButton();
        //this.toolStripSeparator_0 = new ToolStripSeparator();
        //this.toolStripButton_5 = new ToolStripButton();
        //this.toolStripButton_6 = new ToolStripButton();
        //this.toolStripButton_7 = new ToolStripButton();
        //this.toolStripSeparator_1 = new ToolStripSeparator();
        //this.toolStripButton_8 = new ToolStripButton();
        //this.toolStripTextBox_0 = new ToolStripTextBox();
        //this.toolStripButton_9 = new ToolStripButton();
        //this.toolStripButton_10 = new ToolStripButton();
        //this.toolStripSeparator_2 = new ToolStripSeparator();
        //this.toolStripButton_11 = new ToolStripButton();
        //this.dataGridViewExcelFilter_0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        //this.dataGridViewCheckBoxColumn_1 = new DataGridViewCheckBoxColumn();
        //this.dataGridViewCheckBoxColumn_2 = new DataGridViewCheckBoxColumn();
        //this.dataGridViewCheckBoxColumn_3 = new DataGridViewCheckBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_12 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_13 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_14 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_15 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_16 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_17 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_18 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_19 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterCheckBoxColumn_0 = new DataGridViewFilterCheckBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_20 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewTextBoxColumn_12 = new DataGridViewTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_21 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewTextBoxColumn_13 = new DataGridViewTextBoxColumn();
        //this.dataGridViewTextBoxColumn_14 = new DataGridViewTextBoxColumn();
        //this.dataGridViewTextBoxColumn_15 = new DataGridViewTextBoxColumn();
        //this.dataGridViewTextBoxColumn_16 = new DataGridViewTextBoxColumn();
        //this.dataGridViewTextBoxColumn_17 = new DataGridViewTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_22 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterCheckBoxColumn_1 = new DataGridViewFilterCheckBoxColumn();
        //this.dataGridViewTextBoxColumn_18 = new DataGridViewTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_23 = new DataGridViewFilterTextBoxColumn();
        //this.bindingSource_0 = new BindingSource(this.components);
        //this.dataSetGES_0 = new DataSetGES();
        //this.splitContainer_0 = new SplitContainer();
        //this.checkedListBox_0 = new CheckedListBox();
        //this.label_2 = new Label();
        //this.dateTimePicker_0 = new DateTimePicker();
        //this.dateTimePicker_1 = new DateTimePicker();
        //this.label_1 = new Label();
        //this.label_0 = new Label();
        //this.toolStrip_1 = new ToolStrip();
        //this.toolStripButton_3 = new ToolStripButton();
        //this.toolStripButton_4 = new ToolStripButton();
        //this.splitContainer_1 = new SplitContainer();
        //this.dataGridViewExcelFilter_1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
        //this.dataGridViewTextBoxColumn_7 = new DataGridViewTextBoxColumn();
        //this.dataGridViewTextBoxColumn_8 = new DataGridViewTextBoxColumn();
        //this.dataGridViewTextBoxColumn_9 = new DataGridViewTextBoxColumn();
        //this.dataGridViewTextBoxColumn_10 = new DataGridViewTextBoxColumn();
        //this.dataGridViewTextBoxColumn_11 = new DataGridViewTextBoxColumn();
        //this.dataGridViewCheckBoxColumn_0 = new DataGridViewCheckBoxColumn();
        //this.bindingSource_1 = new BindingSource(this.components);
        //this.dataSetDamage_0 = new DataSetDamage();
        //this.label_3 = new Label();
        //this.backgroundWorker_0 = new BackgroundWorker();
        //this.dataGridViewFilterTextBoxColumn_0 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_1 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_2 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_3 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_4 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_5 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_6 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_7 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_8 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewTextBoxColumn_0 = new DataGridViewTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_9 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewTextBoxColumn_1 = new DataGridViewTextBoxColumn();
        //this.dataGridViewTextBoxColumn_2 = new DataGridViewTextBoxColumn();
        //this.dataGridViewTextBoxColumn_3 = new DataGridViewTextBoxColumn();
        //this.dataGridViewTextBoxColumn_4 = new DataGridViewTextBoxColumn();
        //this.dataGridViewTextBoxColumn_5 = new DataGridViewTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_10 = new DataGridViewFilterTextBoxColumn();
        //this.dataGridViewTextBoxColumn_6 = new DataGridViewTextBoxColumn();
        //this.dataGridViewFilterTextBoxColumn_11 = new DataGridViewFilterTextBoxColumn();
        //this.toolStrip_0.SuspendLayout();
        //this.dataGridViewExcelFilter_0.BeginInit();
        //((ISupportInitialize)this.bindingSource_0).BeginInit();
        //this.dataSetGES_0.BeginInit();
        //this.splitContainer_0.Panel1.SuspendLayout();
        //this.splitContainer_0.Panel2.SuspendLayout();
        //this.splitContainer_0.SuspendLayout();
        //this.toolStrip_1.SuspendLayout();
        //this.splitContainer_1.Panel1.SuspendLayout();
        //this.splitContainer_1.Panel2.SuspendLayout();
        //this.splitContainer_1.SuspendLayout();
        //this.dataGridViewExcelFilter_1.BeginInit();
        //((ISupportInitialize)this.bindingSource_1).BeginInit();
        //this.dataSetDamage_0.BeginInit();
        //base.SuspendLayout();
        //ToolStripItem[] toolStripItems = new ToolStripItem[] {
        //    this.toolStripSplitButton_0, this.toolStripButton_0, this.toolStripButton_2, this.toolStripButton_1, this.toolStripSplitButton_1, this.toolStripProgressBar_0, this.toolStripLabel_0, this.toolStripSplitButton_2, this.toolStripSeparator_0, this.toolStripButton_5, this.toolStripButton_6, this.toolStripButton_7, this.toolStripSeparator_1, this.toolStripButton_8, this.toolStripTextBox_0, this.toolStripButton_9,
        //    this.toolStripButton_10, this.toolStripSeparator_2, this.toolStripButton_11
        //};
        //this.toolStrip_0.Items.AddRange(toolStripItems);
        //this.toolStrip_0.Location = new Point(0, 0);
        //this.toolStrip_0.Name = "toolStrip";
        //this.toolStrip_0.Size = new Size(0x402, 0x19);
        //this.toolStrip_0.TabIndex = 0;
        //this.toolStrip_0.Text = "toolStrip1";
        //this.toolStripSplitButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripSplitButton_0.Image = Resources.ElementAdd;
        //this.toolStripSplitButton_0.ImageTransparentColor = Color.Magenta;
        //this.toolStripSplitButton_0.Name = "toolSplitBtnAddRequestRepair";
        //this.toolStripSplitButton_0.Size = new Size(0x20, 0x16);
        //this.toolStripSplitButton_0.Text = "Новая заявка";
        //this.toolStripButton_0.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripButton_0.Image = Resources.ElementEdit;
        //this.toolStripButton_0.ImageTransparentColor = Color.Magenta;
        //this.toolStripButton_0.Name = "toolBtnEditRequestRepair";
        //this.toolStripButton_0.Size = new Size(0x17, 0x16);
        //this.toolStripButton_0.Text = "Редактировать заявку";
        //this.toolStripButton_0.Click += new EventHandler(this.toolStripButton_0_Click);
        //this.toolStripButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripButton_2.Image = Resources.ElementInformation;
        //this.toolStripButton_2.ImageTransparentColor = Color.Magenta;
        //this.toolStripButton_2.Name = "toolBtnReadRequestRepair";
        //this.toolStripButton_2.Size = new Size(0x17, 0x16);
        //this.toolStripButton_2.Text = "Просмотр заявки";
        //this.toolStripButton_2.Click += new EventHandler(this.toolStripButton_2_Click);
        //this.toolStripButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripButton_1.Image = Resources.ElementDel;
        //this.toolStripButton_1.ImageTransparentColor = Color.Magenta;
        //this.toolStripButton_1.Name = "toolBtnDelRequestRepair";
        //this.toolStripButton_1.Size = new Size(0x17, 0x16);
        //this.toolStripButton_1.Text = "Удалить заявку";
        //this.toolStripButton_1.Click += new EventHandler(this.toolStripButton_1_Click);
        //this.toolStripSplitButton_1.Alignment = ToolStripItemAlignment.Right;
        //this.toolStripSplitButton_1.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //ToolStripItem[] itemArray2 = new ToolStripItem[] { this.toolStripMenuItem_0, this.toolStripMenuItem_1 };
        //this.toolStripSplitButton_1.DropDownItems.AddRange(itemArray2);
        //this.toolStripSplitButton_1.Image = (Image) manager.GetObject("toolBtnImport.Image");
        //this.toolStripSplitButton_1.ImageTransparentColor = Color.Magenta;
        //this.toolStripSplitButton_1.Name = "toolBtnImport";
        //this.toolStripSplitButton_1.Size = new Size(0x20, 0x16);
        //this.toolStripSplitButton_1.Text = "toolStripSplitButton1";
        //this.toolStripMenuItem_0.Name = "toolBtnImportODS";
        //this.toolStripMenuItem_0.Size = new Size(0x63, 0x16);
        //this.toolStripMenuItem_0.Text = "ОДС";
        //this.toolStripMenuItem_0.Click += new EventHandler(this.toolStripMenuItem_0_Click);
        //this.toolStripMenuItem_1.Name = "toolBtnImportPL";
        //this.toolStripMenuItem_1.Size = new Size(0x63, 0x16);
        //this.toolStripMenuItem_1.Text = "ПЛ";
        //this.toolStripMenuItem_1.Click += new EventHandler(this.toolStripMenuItem_1_Click);
        //this.toolStripProgressBar_0.Alignment = ToolStripItemAlignment.Right;
        //this.toolStripProgressBar_0.Name = "toolStripProgressBarLoad";
        //this.toolStripProgressBar_0.Size = new Size(100, 0x16);
        //this.toolStripProgressBar_0.Style = ProgressBarStyle.Marquee;
        //this.toolStripProgressBar_0.Visible = false;
        //this.toolStripLabel_0.Alignment = ToolStripItemAlignment.Right;
        //this.toolStripLabel_0.Name = "toolStripLabelLoad";
        //this.toolStripLabel_0.Size = new Size(0x37, 0x16);
        //this.toolStripLabel_0.Text = "Загрузка";
        //this.toolStripLabel_0.Visible = false;
        //this.toolStripSplitButton_2.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripSplitButton_2.Image = Resources.CopyBuffer;
        //this.toolStripSplitButton_2.ImageTransparentColor = Color.Magenta;
        //this.toolStripSplitButton_2.Name = "toolBtnRequestCopy";
        //this.toolStripSplitButton_2.Size = new Size(0x20, 0x16);
        //this.toolStripSplitButton_2.Text = "Копировать";
        //this.toolStripSeparator_0.Name = "toolStripSeparator1";
        //this.toolStripSeparator_0.Size = new Size(6, 0x19);
        //this.toolStripButton_5.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripButton_5.Image = Resources.refresh_16;
        //this.toolStripButton_5.ImageTransparentColor = Color.Magenta;
        //this.toolStripButton_5.Name = "toolBrnRefresh";
        //this.toolStripButton_5.Size = new Size(0x17, 0x16);
        //this.toolStripButton_5.Text = "Обновить";
        //this.toolStripButton_5.Click += new EventHandler(this.toolStripButton_5_Click);
        //this.toolStripButton_6.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripButton_6.Image = Resources.report;
        //this.toolStripButton_6.ImageTransparentColor = Color.Magenta;
        //this.toolStripButton_6.Name = "toolBtnReport";
        //this.toolStripButton_6.Size = new Size(0x17, 0x16);
        //this.toolStripButton_6.Text = "Отчет";
        //this.toolStripButton_6.Click += new EventHandler(this.toolStripButton_6_Click);
        //this.toolStripButton_7.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripButton_7.Image = Resources.report_go;
        //this.toolStripButton_7.ImageTransparentColor = Color.Magenta;
        //this.toolStripButton_7.Name = "toolBtnExport";
        //this.toolStripButton_7.Size = new Size(0x17, 0x16);
        //this.toolStripButton_7.Text = "Экспорт";
        //this.toolStripButton_7.Click += new EventHandler(this.toolStripButton_7_Click);
        //this.toolStripSeparator_1.Name = "toolStripSeparator2";
        //this.toolStripSeparator_1.Size = new Size(6, 0x19);
        //this.toolStripButton_8.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripButton_8.Image = Resources.Find;
        //this.toolStripButton_8.ImageTransparentColor = Color.Magenta;
        //this.toolStripButton_8.Name = "toolBtnFind";
        //this.toolStripButton_8.Size = new Size(0x17, 0x16);
        //this.toolStripButton_8.Text = "Поиск";
        //this.toolStripButton_8.Click += new EventHandler(this.toolStripButton_8_Click);
        //this.toolStripTextBox_0.Name = "toolTextFind";
        //this.toolStripTextBox_0.Size = new Size(150, 0x19);
        //this.toolStripTextBox_0.ToolTipText = "Текст для поиска";
        //this.toolStripTextBox_0.KeyDown += new KeyEventHandler(this.toolStripTextBox_0_KeyDown);
        //this.toolStripButton_9.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripButton_9.Image = Resources.FindPrev;
        //this.toolStripButton_9.ImageTransparentColor = Color.Magenta;
        //this.toolStripButton_9.Name = "toolBtnFindPrev";
        //this.toolStripButton_9.Size = new Size(0x17, 0x16);
        //this.toolStripButton_9.Text = "Поиск назад";
        //this.toolStripButton_9.Click += new EventHandler(this.toolStripButton_9_Click);
        //this.toolStripButton_10.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripButton_10.Image = Resources.FindNext;
        //this.toolStripButton_10.ImageTransparentColor = Color.Magenta;
        //this.toolStripButton_10.Name = "toolBtnFindNext";
        //this.toolStripButton_10.Size = new Size(0x17, 0x16);
        //this.toolStripButton_10.Text = "Поиск вперед";
        //this.toolStripButton_10.Click += new EventHandler(this.toolStripButton_10_Click);
        //this.toolStripSeparator_2.Name = "toolStripSeparator3";
        //this.toolStripSeparator_2.Size = new Size(6, 0x19);
        //this.toolStripButton_11.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripButton_11.Image = Resources.FTP;
        //this.toolStripButton_11.ImageTransparentColor = Color.Magenta;
        //this.toolStripButton_11.Name = "toolBtnSettingsSend";
        //this.toolStripButton_11.Size = new Size(0x17, 0x16);
        //this.toolStripButton_11.Text = "Настройки отправки";
        //this.toolStripButton_11.Click += new EventHandler(this.toolStripButton_11_Click);
        //this.dataGridViewExcelFilter_0.AllowUserToAddRows = false;
        //this.dataGridViewExcelFilter_0.AllowUserToDeleteRows = false;
        //this.dataGridViewExcelFilter_0.AllowUserToOrderColumns = true;
        //this.dataGridViewExcelFilter_0.AutoGenerateColumns = false;
        //style.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //style.BackColor = SystemColors.Control;
        //style.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //style.ForeColor = SystemColors.WindowText;
        //style.SelectionBackColor = SystemColors.Highlight;
        //style.SelectionForeColor = SystemColors.HighlightText;
        //style.WrapMode = DataGridViewTriState.True;
        //this.dataGridViewExcelFilter_0.ColumnHeadersDefaultCellStyle = style;
        //this.dataGridViewExcelFilter_0.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //DataGridViewColumn[] dataGridViewColumns = new DataGridViewColumn[] {
        //    this.dataGridViewCheckBoxColumn_1, this.dataGridViewCheckBoxColumn_2, this.dataGridViewCheckBoxColumn_3, this.dataGridViewFilterTextBoxColumn_12, this.dataGridViewFilterTextBoxColumn_13, this.dataGridViewFilterTextBoxColumn_14, this.dataGridViewFilterTextBoxColumn_15, this.dataGridViewFilterTextBoxColumn_16, this.dataGridViewFilterTextBoxColumn_17, this.dataGridViewFilterTextBoxColumn_18, this.dataGridViewFilterTextBoxColumn_19, this.dataGridViewFilterCheckBoxColumn_0, this.dataGridViewFilterTextBoxColumn_20, this.dataGridViewTextBoxColumn_12, this.dataGridViewFilterTextBoxColumn_21, this.dataGridViewTextBoxColumn_13,
        //    this.dataGridViewTextBoxColumn_14, this.dataGridViewTextBoxColumn_15, this.dataGridViewTextBoxColumn_16, this.dataGridViewTextBoxColumn_17, this.dataGridViewFilterTextBoxColumn_22, this.dataGridViewFilterCheckBoxColumn_1, this.dataGridViewTextBoxColumn_18, this.dataGridViewFilterTextBoxColumn_23
        //};
        //this.dataGridViewExcelFilter_0.Columns.AddRange(dataGridViewColumns);
        //this.dataGridViewExcelFilter_0.DataSource = this.bindingSource_0;
        //style2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        //style2.BackColor = SystemColors.Window;
        //style2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0xcc);
        //style2.ForeColor = SystemColors.ControlText;
        //style2.SelectionBackColor = SystemColors.Highlight;
        //style2.SelectionForeColor = SystemColors.HighlightText;
        //style2.WrapMode = DataGridViewTriState.False;
        //this.dataGridViewExcelFilter_0.DefaultCellStyle = style2;
        //this.dataGridViewExcelFilter_0.Dock = DockStyle.Fill;
        //this.dataGridViewExcelFilter_0.Location = new Point(0, 0);
        //this.dataGridViewExcelFilter_0.Name = "dgv";
        //this.dataGridViewExcelFilter_0.ReadOnly = true;
        //this.dataGridViewExcelFilter_0.RowHeadersWidth = 0x15;
        //this.dataGridViewExcelFilter_0.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        //this.dataGridViewExcelFilter_0.Size = new Size(0x34d, 400);
        //this.dataGridViewExcelFilter_0.TabIndex = 1;
        //this.dataGridViewExcelFilter_0.VirtualMode = true;
        //this.dataGridViewExcelFilter_0.CellDoubleClick += new DataGridViewCellEventHandler(this.dataGridViewExcelFilter_0_CellDoubleClick);
        //this.dataGridViewExcelFilter_0.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dataGridViewExcelFilter_0_CellFormatting);
        //this.dataGridViewExcelFilter_0.RowPostPaint += new DataGridViewRowPostPaintEventHandler(this.dataGridViewExcelFilter_0_RowPostPaint);
        //this.dataGridViewCheckBoxColumn_1.DataPropertyName = "isSend";
        //this.dataGridViewCheckBoxColumn_1.HeaderText = "isSend";
        //this.dataGridViewCheckBoxColumn_1.Name = "isSendDgvColumn";
        //this.dataGridViewCheckBoxColumn_1.ReadOnly = true;
        //this.dataGridViewCheckBoxColumn_1.Visible = false;
        //this.dataGridViewCheckBoxColumn_2.DataPropertyName = "IsPlanned";
        //this.dataGridViewCheckBoxColumn_2.HeaderText = "Плановый";
        //this.dataGridViewCheckBoxColumn_2.Name = "isPlannedDataGridViewCheckBoxColumn";
        //this.dataGridViewCheckBoxColumn_2.ReadOnly = true;
        //this.dataGridViewCheckBoxColumn_2.Visible = false;
        //this.dataGridViewCheckBoxColumn_3.DataPropertyName = "deleted";
        //this.dataGridViewCheckBoxColumn_3.HeaderText = "Удалено";
        //this.dataGridViewCheckBoxColumn_3.Name = "deletedDgvCheckBoxColumn";
        //this.dataGridViewCheckBoxColumn_3.ReadOnly = true;
        //this.dataGridViewCheckBoxColumn_3.Visible = false;
        //this.dataGridViewFilterTextBoxColumn_12.DataPropertyName = "num";
        //this.dataGridViewFilterTextBoxColumn_12.HeaderText = "Номер";
        //this.dataGridViewFilterTextBoxColumn_12.Name = "numDataGridViewTextBoxColumn";
        //this.dataGridViewFilterTextBoxColumn_12.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_12.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_13.DataPropertyName = "dateCreate";
        //this.dataGridViewFilterTextBoxColumn_13.HeaderText = "Дата";
        //this.dataGridViewFilterTextBoxColumn_13.Name = "dateCreateDgvColumn";
        //this.dataGridViewFilterTextBoxColumn_13.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_14.DataPropertyName = "SRSocr";
        //this.dataGridViewFilterTextBoxColumn_14.HeaderText = "Район";
        //this.dataGridViewFilterTextBoxColumn_14.Name = "sRDataGridViewTextBoxColumn";
        //this.dataGridViewFilterTextBoxColumn_14.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_14.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_15.DataPropertyName = "reguestFiled";
        //this.dataGridViewFilterTextBoxColumn_15.HeaderText = "Подал";
        //this.dataGridViewFilterTextBoxColumn_15.Name = "reguestFiledDataGridViewTextBoxColumn";
        //this.dataGridViewFilterTextBoxColumn_15.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_15.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_16.DataPropertyName = "schmObj";
        //style3.WrapMode = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_16.DefaultCellStyle = style3;
        //this.dataGridViewFilterTextBoxColumn_16.HeaderText = "Объект";
        //this.dataGridViewFilterTextBoxColumn_16.Name = "schmObjDataGridViewTextBoxColumn";
        //this.dataGridViewFilterTextBoxColumn_16.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_16.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_17.DataPropertyName = "Purpose";
        //style4.WrapMode = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_17.DefaultCellStyle = style4;
        //this.dataGridViewFilterTextBoxColumn_17.HeaderText = "Цель";
        //this.dataGridViewFilterTextBoxColumn_17.Name = "PurposeDgvTextBoxColumn";
        //this.dataGridViewFilterTextBoxColumn_17.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_18.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //this.dataGridViewFilterTextBoxColumn_18.DataPropertyName = "DateTripBeg";
        //style5.WrapMode = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_18.DefaultCellStyle = style5;
        //this.dataGridViewFilterTextBoxColumn_18.HeaderText = "Дата С";
        //this.dataGridViewFilterTextBoxColumn_18.Name = "dateTripBegDataGridViewTextBoxColumn";
        //this.dataGridViewFilterTextBoxColumn_18.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_18.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_19.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //this.dataGridViewFilterTextBoxColumn_19.DataPropertyName = "DateTripEnd";
        //style6.WrapMode = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_19.DefaultCellStyle = style6;
        //this.dataGridViewFilterTextBoxColumn_19.HeaderText = "Дата По";
        //this.dataGridViewFilterTextBoxColumn_19.Name = "dateTripEndDgvColumn";
        //this.dataGridViewFilterTextBoxColumn_19.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_19.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterCheckBoxColumn_0.DataPropertyName = "Agreed";
        //this.dataGridViewFilterCheckBoxColumn_0.FalseValue = "Нет";
        //this.dataGridViewFilterCheckBoxColumn_0.HeaderText = "Заявка разрешена";
        //this.dataGridViewFilterCheckBoxColumn_0.Name = "agreedDgvColumn";
        //this.dataGridViewFilterCheckBoxColumn_0.ReadOnly = true;
        //this.dataGridViewFilterCheckBoxColumn_0.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterCheckBoxColumn_0.TrueValue = "Да";
        //this.dataGridViewFilterTextBoxColumn_20.DataPropertyName = "DateFactEnd";
        //this.dataGridViewFilterTextBoxColumn_20.HeaderText = "Фактическое время выполнения";
        //this.dataGridViewFilterTextBoxColumn_20.Name = "dateFactEndDgvColumn";
        //this.dataGridViewFilterTextBoxColumn_20.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_20.Visible = false;
        //this.dataGridViewTextBoxColumn_12.DataPropertyName = "AgreeWith";
        //style7.WrapMode = DataGridViewTriState.True;
        //this.dataGridViewTextBoxColumn_12.DefaultCellStyle = style7;
        //this.dataGridViewTextBoxColumn_12.HeaderText = "Согласовать с";
        //this.dataGridViewTextBoxColumn_12.Name = "agreeWithDataGridViewTextBoxColumn";
        //this.dataGridViewTextBoxColumn_12.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_21.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //this.dataGridViewFilterTextBoxColumn_21.DataPropertyName = "Comment";
        //style8.WrapMode = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_21.DefaultCellStyle = style8;
        //this.dataGridViewFilterTextBoxColumn_21.HeaderText = "Комментарий";
        //this.dataGridViewFilterTextBoxColumn_21.Name = "commentDataGridViewImageColumn";
        //this.dataGridViewFilterTextBoxColumn_21.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_21.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_21.Width = 0x67;
        //this.dataGridViewTextBoxColumn_13.DataPropertyName = "workerCreate";
        //this.dataGridViewTextBoxColumn_13.HeaderText = "Автор";
        //this.dataGridViewTextBoxColumn_13.Name = "workerCreateDataGridViewTextBoxColumn";
        //this.dataGridViewTextBoxColumn_13.ReadOnly = true;
        //this.dataGridViewTextBoxColumn_13.Visible = false;
        //this.dataGridViewTextBoxColumn_14.DataPropertyName = "Address";
        //this.dataGridViewTextBoxColumn_14.HeaderText = "Адреса";
        //this.dataGridViewTextBoxColumn_14.Name = "addressDataGridViewTextBoxColumn";
        //this.dataGridViewTextBoxColumn_14.ReadOnly = true;
        //this.dataGridViewTextBoxColumn_14.Visible = false;
        //this.dataGridViewTextBoxColumn_15.DataPropertyName = "DateAgreed";
        //style9.Format = "d";
        //style9.NullValue = null;
        //this.dataGridViewTextBoxColumn_15.DefaultCellStyle = style9;
        //this.dataGridViewTextBoxColumn_15.HeaderText = "Дата согласования";
        //this.dataGridViewTextBoxColumn_15.Name = "dateAgreedDataGridViewTextBoxColumn";
        //this.dataGridViewTextBoxColumn_15.ReadOnly = true;
        //this.dataGridViewTextBoxColumn_15.Visible = false;
        //this.dataGridViewTextBoxColumn_16.DataPropertyName = "FIO";
        //this.dataGridViewTextBoxColumn_16.HeaderText = "Диспетчер";
        //this.dataGridViewTextBoxColumn_16.Name = "fIODataGridViewTextBoxColumn";
        //this.dataGridViewTextBoxColumn_16.ReadOnly = true;
        //this.dataGridViewTextBoxColumn_16.Visible = false;
        //this.dataGridViewTextBoxColumn_17.DataPropertyName = "iddivision";
        //this.dataGridViewTextBoxColumn_17.HeaderText = "Код подразделения";
        //this.dataGridViewTextBoxColumn_17.Name = "iddivisionDataGridViewTextBoxColumn";
        //this.dataGridViewTextBoxColumn_17.ReadOnly = true;
        //this.dataGridViewTextBoxColumn_17.Visible = false;
        //this.dataGridViewFilterTextBoxColumn_22.DataPropertyName = "division";
        //this.dataGridViewFilterTextBoxColumn_22.HeaderText = "Подразделение";
        //this.dataGridViewFilterTextBoxColumn_22.Name = "divisionDataGridViewTextBoxColumn";
        //this.dataGridViewFilterTextBoxColumn_22.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_22.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_22.Visible = false;
        //this.dataGridViewFilterCheckBoxColumn_1.DataPropertyName = "SendSite";
        //this.dataGridViewFilterCheckBoxColumn_1.HeaderText = "На сайт";
        //this.dataGridViewFilterCheckBoxColumn_1.Name = "sendSiteDgvColumn";
        //this.dataGridViewFilterCheckBoxColumn_1.ReadOnly = true;
        //this.dataGridViewFilterCheckBoxColumn_1.Visible = false;
        //this.dataGridViewTextBoxColumn_18.DataPropertyName = "id";
        //this.dataGridViewTextBoxColumn_18.HeaderText = "id";
        //this.dataGridViewTextBoxColumn_18.Name = "idDataGridViewTextBoxColumn";
        //this.dataGridViewTextBoxColumn_18.ReadOnly = true;
        //this.dataGridViewTextBoxColumn_18.Visible = false;
        //this.dataGridViewFilterTextBoxColumn_23.DataPropertyName = "colorStatus";
        //this.dataGridViewFilterTextBoxColumn_23.HeaderText = "colorStatus";
        //this.dataGridViewFilterTextBoxColumn_23.Name = "colorStatusDgvColumn";
        //this.dataGridViewFilterTextBoxColumn_23.ReadOnly = true;
        //this.dataGridViewFilterTextBoxColumn_23.Visible = false;
        //this.bindingSource_0.DataMember = "vJ_RequestForRepair";
        //this.bindingSource_0.DataSource = this.dataSetGES_0;
        //this.bindingSource_0.CurrentChanged += new EventHandler(this.bindingSource_0_CurrentChanged);
        //this.dataSetGES_0.DataSetName = "DataSetGES";
        //this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        //this.splitContainer_0.Dock = DockStyle.Fill;
        //this.splitContainer_0.FixedPanel = FixedPanel.Panel1;
        //this.splitContainer_0.Location = new Point(0, 0x19);
        //this.splitContainer_0.Name = "splitContainer";
        //this.splitContainer_0.Panel1.Controls.Add(this.checkedListBox_0);
        //this.splitContainer_0.Panel1.Controls.Add(this.label_2);
        //this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_0);
        //this.splitContainer_0.Panel1.Controls.Add(this.dateTimePicker_1);
        //this.splitContainer_0.Panel1.Controls.Add(this.label_1);
        //this.splitContainer_0.Panel1.Controls.Add(this.label_0);
        //this.splitContainer_0.Panel1.Controls.Add(this.toolStrip_1);
        //this.splitContainer_0.Panel2.Controls.Add(this.splitContainer_1);
        //this.splitContainer_0.Size = new Size(0x402, 0x22a);
        //this.splitContainer_0.SplitterDistance = 0xb1;
        //this.splitContainer_0.TabIndex = 2;
        //this.checkedListBox_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        //this.checkedListBox_0.CheckOnClick = true;
        //this.checkedListBox_0.FormattingEnabled = true;
        //this.checkedListBox_0.Location = new Point(15, 0x7b);
        //this.checkedListBox_0.Name = "checkedListBoxDivision";
        //this.checkedListBox_0.Size = new Size(0x99, 0x5e);
        //this.checkedListBox_0.TabIndex = 5;
        //this.label_2.AutoSize = true;
        //this.label_2.Location = new Point(12, 0x6b);
        //this.label_2.Name = "label3";
        //this.label_2.Size = new Size(0x57, 13);
        //this.label_2.TabIndex = 4;
        //this.label_2.Text = "Подразделения";
        //this.dateTimePicker_0.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        //this.dateTimePicker_0.CustomFormat = "dd.MM.yyyy HH:mm:ss";
        //this.dateTimePicker_0.Format = DateTimePickerFormat.Custom;
        //this.dateTimePicker_0.Location = new Point(15, 0x54);
        //this.dateTimePicker_0.Name = "dateTimePickerEnd";
        //this.dateTimePicker_0.Size = new Size(0x99, 20);
        //this.dateTimePicker_0.TabIndex = 3;
        //this.dateTimePicker_0.ValueChanged += new EventHandler(this.dateTimePicker_0_ValueChanged);
        //this.dateTimePicker_1.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
        //this.dateTimePicker_1.CustomFormat = "dd.MM.yyyy HH:mm:ss";
        //this.dateTimePicker_1.Format = DateTimePickerFormat.Custom;
        //this.dateTimePicker_1.Location = new Point(15, 0x2d);
        //this.dateTimePicker_1.Name = "dateTimePickerBeg";
        //this.dateTimePicker_1.Size = new Size(0x99, 20);
        //this.dateTimePicker_1.TabIndex = 2;
        //this.dateTimePicker_1.ValueChanged += new EventHandler(this.dateTimePicker_1_ValueChanged);
        //this.label_1.AutoSize = true;
        //this.label_1.Location = new Point(12, 0x44);
        //this.label_1.Name = "label2";
        //this.label_1.Size = new Size(0x16, 13);
        //this.label_1.TabIndex = 1;
        //this.label_1.Text = "До";
        //this.label_0.AutoSize = true;
        //this.label_0.Location = new Point(12, 0x1d);
        //this.label_0.Name = "label1";
        //this.label_0.Size = new Size(20, 13);
        //this.label_0.TabIndex = 0;
        //this.label_0.Text = "От";
        //ToolStripItem[] itemArray3 = new ToolStripItem[] { this.toolStripButton_3, this.toolStripButton_4 };
        //this.toolStrip_1.Items.AddRange(itemArray3);
        //this.toolStrip_1.Location = new Point(0, 0);
        //this.toolStrip_1.Name = "toolStripFilter";
        //this.toolStrip_1.Size = new Size(0xb1, 0x19);
        //this.toolStrip_1.TabIndex = 6;
        //this.toolStrip_1.Text = "toolStrip1";
        //this.toolStripButton_3.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripButton_3.Image = Resources.filter;
        //this.toolStripButton_3.ImageTransparentColor = Color.Magenta;
        //this.toolStripButton_3.Name = "toolBtnFilter";
        //this.toolStripButton_3.Size = new Size(0x17, 0x16);
        //this.toolStripButton_3.Text = "Применить фильтр";
        //this.toolStripButton_3.Click += new EventHandler(this.toolStripButton_3_Click);
        //this.toolStripButton_4.DisplayStyle = ToolStripItemDisplayStyle.Image;
        //this.toolStripButton_4.Image = Resources.filter_delete;
        //this.toolStripButton_4.ImageTransparentColor = Color.Magenta;
        //this.toolStripButton_4.Name = "toolBtnNoFilter";
        //this.toolStripButton_4.Size = new Size(0x17, 0x16);
        //this.toolStripButton_4.Text = "Убрать фильтр";
        //this.toolStripButton_4.Click += new EventHandler(this.toolStripButton_4_Click);
        //this.splitContainer_1.Dock = DockStyle.Fill;
        //this.splitContainer_1.FixedPanel = FixedPanel.Panel2;
        //this.splitContainer_1.Location = new Point(0, 0);
        //this.splitContainer_1.Name = "splitContainerDgv";
        //this.splitContainer_1.Orientation = Orientation.Horizontal;
        //this.splitContainer_1.Panel1.Controls.Add(this.dataGridViewExcelFilter_0);
        //this.splitContainer_1.Panel2.Controls.Add(this.dataGridViewExcelFilter_1);
        //this.splitContainer_1.Panel2.Controls.Add(this.label_3);
        //this.splitContainer_1.Panel2MinSize = 13;
        //this.splitContainer_1.Size = new Size(0x34d, 0x22a);
        //this.splitContainer_1.SplitterDistance = 400;
        //this.splitContainer_1.TabIndex = 2;
        //this.dataGridViewExcelFilter_1.AllowUserToAddRows = false;
        //this.dataGridViewExcelFilter_1.AllowUserToDeleteRows = false;
        //this.dataGridViewExcelFilter_1.AllowUserToVisibleColumns = (false);
        //this.dataGridViewExcelFilter_1.AutoGenerateColumns = false;
        //this.dataGridViewExcelFilter_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        //DataGridViewColumn[] columnArray2 = new DataGridViewColumn[] { this.dataGridViewTextBoxColumn_7, this.dataGridViewTextBoxColumn_8, this.dataGridViewTextBoxColumn_9, this.dataGridViewTextBoxColumn_10, this.dataGridViewTextBoxColumn_11, this.dataGridViewCheckBoxColumn_0 };
        //this.dataGridViewExcelFilter_1.Columns.AddRange(columnArray2);
        //this.dataGridViewExcelFilter_1.DataSource = this.bindingSource_1;
        //this.dataGridViewExcelFilter_1.Dock = DockStyle.Fill;
        //this.dataGridViewExcelFilter_1.Location = new Point(0, 13);
        //this.dataGridViewExcelFilter_1.Name = "dgvDamage";
        //this.dataGridViewExcelFilter_1.ReadOnly = true;
        //this.dataGridViewExcelFilter_1.RowHeadersWidth = 0x15;
        //this.dataGridViewExcelFilter_1.Size = new Size(0x34d, 0x89);
        //this.dataGridViewExcelFilter_1.TabIndex = 9;
        //this.dataGridViewTextBoxColumn_7.DataPropertyName = "numrequest";
        //this.dataGridViewTextBoxColumn_7.HeaderText = "№ док.";
        //this.dataGridViewTextBoxColumn_7.Name = "numrequestDataGridViewTextBoxColumn";
        //this.dataGridViewTextBoxColumn_7.ReadOnly = true;
        //this.dataGridViewTextBoxColumn_8.DataPropertyName = "dateDoc";
        //this.dataGridViewTextBoxColumn_8.HeaderText = "Дата док";
        //this.dataGridViewTextBoxColumn_8.Name = "dateDocDataGridViewTextBoxColumn";
        //this.dataGridViewTextBoxColumn_8.ReadOnly = true;
        //this.dataGridViewTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //this.dataGridViewTextBoxColumn_9.DataPropertyName = "TypeDocName";
        //this.dataGridViewTextBoxColumn_9.HeaderText = "Тип документа";
        //this.dataGridViewTextBoxColumn_9.Name = "typeDocNameDataGridViewTextBoxColumn";
        //this.dataGridViewTextBoxColumn_9.ReadOnly = true;
        //this.dataGridViewTextBoxColumn_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //this.dataGridViewTextBoxColumn_10.DataPropertyName = "schmObjName";
        //this.dataGridViewTextBoxColumn_10.HeaderText = "Объект";
        //this.dataGridViewTextBoxColumn_10.Name = "schmObjNameDataGridViewTextBoxColumn";
        //this.dataGridViewTextBoxColumn_10.ReadOnly = true;
        //this.dataGridViewTextBoxColumn_11.DataPropertyName = "id";
        //this.dataGridViewTextBoxColumn_11.HeaderText = "id";
        //this.dataGridViewTextBoxColumn_11.Name = "idDataGridViewTextBoxColumn1";
        //this.dataGridViewTextBoxColumn_11.ReadOnly = true;
        //this.dataGridViewTextBoxColumn_11.Visible = false;
        //this.dataGridViewCheckBoxColumn_0.DataPropertyName = "isApply";
        //this.dataGridViewCheckBoxColumn_0.HeaderText = "Исполнен";
        //this.dataGridViewCheckBoxColumn_0.Name = "isApplyDataGridViewCheckBoxColumn";
        //this.dataGridViewCheckBoxColumn_0.ReadOnly = true;
        //this.bindingSource_1.DataMember = "vJ_Damage";
        //this.bindingSource_1.DataSource = this.dataSetDamage_0;
        //this.dataSetDamage_0.DataSetName = "DataSetDamage";
        //this.dataSetDamage_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
        //this.label_3.Cursor = Cursors.PanNorth;
        //this.label_3.Dock = DockStyle.Top;
        //this.label_3.Location = new Point(0, 0);
        //this.label_3.Name = "lbChildDoc";
        //this.label_3.Size = new Size(0x34d, 13);
        //this.label_3.TabIndex = 8;
        //this.label_3.Text = "Дочерние документы";
        //this.label_3.TextAlign = ContentAlignment.TopCenter;
        //this.label_3.Click += new EventHandler(this.label_3_Click);
        //this.backgroundWorker_0.WorkerReportsProgress = true;
        //this.backgroundWorker_0.WorkerSupportsCancellation = true;
        //this.backgroundWorker_0.DoWork += new DoWorkEventHandler(this.backgroundWorker_0_DoWork);
        //this.backgroundWorker_0.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.backgroundWorker_0_RunWorkerCompleted);
        //this.dataGridViewFilterTextBoxColumn_0.DataPropertyName = "num";
        //this.dataGridViewFilterTextBoxColumn_0.HeaderText = "Номер";
        //this.dataGridViewFilterTextBoxColumn_0.Name = "dataGridViewFilterTextBoxColumn1";
        //this.dataGridViewFilterTextBoxColumn_0.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_1.DataPropertyName = "dateCreate";
        //this.dataGridViewFilterTextBoxColumn_1.HeaderText = "Дата";
        //this.dataGridViewFilterTextBoxColumn_1.Name = "dataGridViewFilterTextBoxColumn2";
        //this.dataGridViewFilterTextBoxColumn_2.DataPropertyName = "SRSocr";
        //this.dataGridViewFilterTextBoxColumn_2.HeaderText = "Район";
        //this.dataGridViewFilterTextBoxColumn_2.Name = "dataGridViewFilterTextBoxColumn3";
        //this.dataGridViewFilterTextBoxColumn_2.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_3.DataPropertyName = "reguestFiled";
        //this.dataGridViewFilterTextBoxColumn_3.HeaderText = "Подал";
        //this.dataGridViewFilterTextBoxColumn_3.Name = "dataGridViewFilterTextBoxColumn4";
        //this.dataGridViewFilterTextBoxColumn_3.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_4.DataPropertyName = "schmObj";
        //style10.WrapMode = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_4.DefaultCellStyle = style10;
        //this.dataGridViewFilterTextBoxColumn_4.HeaderText = "Объект";
        //this.dataGridViewFilterTextBoxColumn_4.Name = "dataGridViewFilterTextBoxColumn5";
        //this.dataGridViewFilterTextBoxColumn_4.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_5.DataPropertyName = "Purpose";
        //style11.WrapMode = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_5.DefaultCellStyle = style11;
        //this.dataGridViewFilterTextBoxColumn_5.HeaderText = "Цель";
        //this.dataGridViewFilterTextBoxColumn_5.Name = "dataGridViewFilterTextBoxColumn6";
        //this.dataGridViewFilterTextBoxColumn_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //this.dataGridViewFilterTextBoxColumn_6.DataPropertyName = "DateTripBeg";
        //style12.WrapMode = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_6.DefaultCellStyle = style12;
        //this.dataGridViewFilterTextBoxColumn_6.HeaderText = "Дата С";
        //this.dataGridViewFilterTextBoxColumn_6.Name = "dataGridViewFilterTextBoxColumn7";
        //this.dataGridViewFilterTextBoxColumn_6.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //this.dataGridViewFilterTextBoxColumn_7.DataPropertyName = "DateTripEnd";
        //style13.WrapMode = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_7.DefaultCellStyle = style13;
        //this.dataGridViewFilterTextBoxColumn_7.HeaderText = "Дата По";
        //this.dataGridViewFilterTextBoxColumn_7.Name = "dataGridViewFilterTextBoxColumn8";
        //this.dataGridViewFilterTextBoxColumn_7.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_8.DataPropertyName = "DateFactEnd";
        //this.dataGridViewFilterTextBoxColumn_8.HeaderText = "Фактическое время выполнения";
        //this.dataGridViewFilterTextBoxColumn_8.Name = "dataGridViewFilterTextBoxColumn9";
        //this.dataGridViewFilterTextBoxColumn_8.Visible = false;
        //this.dataGridViewTextBoxColumn_0.DataPropertyName = "AgreeWith";
        //this.dataGridViewTextBoxColumn_0.HeaderText = "Согласовать с";
        //this.dataGridViewTextBoxColumn_0.Name = "dataGridViewTextBoxColumn1";
        //this.dataGridViewFilterTextBoxColumn_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        //this.dataGridViewFilterTextBoxColumn_9.DataPropertyName = "Comment";
        //style14.WrapMode = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_9.DefaultCellStyle = style14;
        //this.dataGridViewFilterTextBoxColumn_9.HeaderText = "Комментарий";
        //this.dataGridViewFilterTextBoxColumn_9.Name = "dataGridViewFilterTextBoxColumn10";
        //this.dataGridViewFilterTextBoxColumn_9.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_9.Width = 0x67;
        //this.dataGridViewTextBoxColumn_1.DataPropertyName = "workerCreate";
        //this.dataGridViewTextBoxColumn_1.HeaderText = "Автор";
        //this.dataGridViewTextBoxColumn_1.Name = "dataGridViewTextBoxColumn2";
        //this.dataGridViewTextBoxColumn_1.Visible = false;
        //this.dataGridViewTextBoxColumn_2.DataPropertyName = "Address";
        //this.dataGridViewTextBoxColumn_2.HeaderText = "Адреса";
        //this.dataGridViewTextBoxColumn_2.Name = "dataGridViewTextBoxColumn3";
        //this.dataGridViewTextBoxColumn_2.Visible = false;
        //this.dataGridViewTextBoxColumn_3.DataPropertyName = "DateAgreed";
        //style15.Format = "d";
        //style15.NullValue = null;
        //this.dataGridViewTextBoxColumn_3.DefaultCellStyle = style15;
        //this.dataGridViewTextBoxColumn_3.HeaderText = "Дата согласования";
        //this.dataGridViewTextBoxColumn_3.Name = "dataGridViewTextBoxColumn4";
        //this.dataGridViewTextBoxColumn_3.Visible = false;
        //this.dataGridViewTextBoxColumn_4.DataPropertyName = "FIO";
        //this.dataGridViewTextBoxColumn_4.HeaderText = "Диспетчер";
        //this.dataGridViewTextBoxColumn_4.Name = "dataGridViewTextBoxColumn5";
        //this.dataGridViewTextBoxColumn_4.Visible = false;
        //this.dataGridViewTextBoxColumn_5.DataPropertyName = "iddivision";
        //this.dataGridViewTextBoxColumn_5.HeaderText = "Код подразделения";
        //this.dataGridViewTextBoxColumn_5.Name = "dataGridViewTextBoxColumn6";
        //this.dataGridViewTextBoxColumn_5.Visible = false;
        //this.dataGridViewFilterTextBoxColumn_10.DataPropertyName = "division";
        //this.dataGridViewFilterTextBoxColumn_10.HeaderText = "Подразделение";
        //this.dataGridViewFilterTextBoxColumn_10.Name = "dataGridViewFilterTextBoxColumn11";
        //this.dataGridViewFilterTextBoxColumn_10.Resizable = DataGridViewTriState.True;
        //this.dataGridViewFilterTextBoxColumn_10.Visible = false;
        //this.dataGridViewTextBoxColumn_6.DataPropertyName = "id";
        //this.dataGridViewTextBoxColumn_6.HeaderText = "id";
        //this.dataGridViewTextBoxColumn_6.Name = "dataGridViewTextBoxColumn7";
        //this.dataGridViewTextBoxColumn_6.Visible = false;
        //this.dataGridViewFilterTextBoxColumn_11.DataPropertyName = "colorStatus";
        //this.dataGridViewFilterTextBoxColumn_11.HeaderText = "colorStatus";
        //this.dataGridViewFilterTextBoxColumn_11.Name = "dataGridViewFilterTextBoxColumn12";
        //this.dataGridViewFilterTextBoxColumn_11.Visible = false;
        //base.AutoScaleDimensions = new SizeF(6f, 13f);
        //base.AutoScaleMode = AutoScaleMode.Font;
        //base.ClientSize = new Size(0x402, 0x243);
        //base.Controls.Add(this.splitContainer_0);
        //base.Controls.Add(this.toolStrip_0);
        //base.Icon = (Icon) manager.GetObject("$this.Icon");
        //base.Name = "FormJournalRequestForRepair";
        //this.Text = "Журнал заявок на ремонт оборудования";
        //base.Load += new EventHandler(this.FormJournalRequestForRepair_Load);
        //this.toolStrip_0.ResumeLayout(false);
        //this.toolStrip_0.PerformLayout();
        //this.dataGridViewExcelFilter_0.EndInit();
        //((ISupportInitialize)this.bindingSource_0).EndInit();
        //this.dataSetGES_0.EndInit();
        //this.splitContainer_0.Panel1.ResumeLayout(false);
        //this.splitContainer_0.Panel1.PerformLayout();
        //this.splitContainer_0.Panel2.ResumeLayout(false);
        //this.splitContainer_0.ResumeLayout(false);
        //this.toolStrip_1.ResumeLayout(false);
        //this.toolStrip_1.PerformLayout();
        //this.splitContainer_1.Panel1.ResumeLayout(false);
        //this.splitContainer_1.Panel2.ResumeLayout(false);
        //this.splitContainer_1.ResumeLayout(false);
        //this.dataGridViewExcelFilter_1.EndInit();
        //((ISupportInitialize)this.bindingSource_1).EndInit();
        //this.dataSetDamage_0.EndInit();
        //base.ResumeLayout(false);
        //base.PerformLayout();



        private BackgroundWorker backgroundWorkerLoad;
        private BindingSource bindingSourceJournalRequestForRepair;
        private BindingSource bindingSource_1;

        private CheckedListBox checkedListBoxDivision;
        private DataGridViewCheckBoxColumn isApplyDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isSendDgvColumn;
        private DataGridViewCheckBoxColumn isPlannedDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn deletedDgvCheckBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgv;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvDamage;
        private DataGridViewFilterCheckBoxColumn agreedDgvColumn;
        private DataGridViewFilterCheckBoxColumn sendSiteDgvColumn;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn1;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn2;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn11;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn12;
        private DataGridViewFilterTextBoxColumn numDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateCreateDgvColumn;
        private DataGridViewFilterTextBoxColumn sRDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn reguestFiledDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn schmObjDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn PurposeDgvTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateTripBegDgvColumn;
        private DataGridViewFilterTextBoxColumn dateTripEndDgvColumn;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn3;
        private DataGridViewFilterTextBoxColumn dateFactEndDgvColumn;
        private DataGridViewFilterTextBoxColumn commentDataGridViewImageColumn;
        private DataGridViewFilterTextBoxColumn divisionDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn colorStatusDgvColumn;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn4;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn5;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn6;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn7;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn8;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn9;
        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn schmObjNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn agreeWithDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workerCreateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateAgreedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iddivisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn numrequestDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDocNameDataGridViewTextBoxColumn;
        //private dsDamage dataSetDamage_0;
        private DataSetN dataSetGES_0;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerBeg;
        private System.ComponentModel.IContainer components = null;


        private Label label_0;
        private Label label_1;
        private Label label_2;
        private Label lbChildDoc;
        private SplitContainer splitContainer;
        private SplitContainer splitContainerDgv;

        private ToolStrip toolStrip;
        private ToolStrip toolStripFilter;
        private ToolStripButton toolBtnEditRequestRepair;
        private ToolStripButton toolBtnDelRequestRepair;
        private ToolStripButton toolBtnFindNext;
        private ToolStripButton toolBtnSettingsSend;
        private ToolStripButton toolBtnReadRequestRepair;
        private ToolStripButton toolBtnFilter;
        private ToolStripButton toolBtnNoFilter;
        private ToolStripButton toolBrnRefresh;
        private ToolStripButton toolBtnReport;
        private ToolStripButton toolBtnExport;
        private ToolStripButton toolBtnFind;
        private ToolStripButton toolBtnFindPrev;
        private ToolStripLabel toolStripLabelLoad;
        private ToolStripMenuItem toolBtnImportODS;
        private ToolStripMenuItem toolBtnImportPL;
        private ToolStripProgressBar toolStripProgressBarLoad;
        private ToolStripSeparator toolStripSeparator_0;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSplitButton toolSplitBtnAddRequestRepair;
        private ToolStripSplitButton toolBtnImport;
        private ToolStripSplitButton toolBtnRequestCopy;
        private ToolStripTextBox toolTextFind;
    }
}
