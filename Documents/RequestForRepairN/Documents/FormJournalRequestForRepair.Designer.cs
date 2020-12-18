using ControlsLbr.DataGridViewExcelFilter;
using RequestForRepairN.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace RequestForRepairN
{
	public partial class FormJournalRequestForRepair
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private global::System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJournalRequestForRepair));
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.toolStripButtonExportExcel1 = new Library.ToolStripButtonExportExcel(this.components);
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
            this.dateTripBeg = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateTripEnd = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
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
            this.bsRequestForRepair = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetDamage = new RequestForRepairN.DataSets.DataSetDamage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.checkedListBoxDivision = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBeg = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.bsDamage = new System.Windows.Forms.BindingSource(this.components);
            this.lbChildDoc = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDamage)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStripFilter.SuspendLayout();
            this.splitContainerDgv.Panel1.SuspendLayout();
            this.splitContainerDgv.Panel2.SuspendLayout();
            this.splitContainerDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamage)).BeginInit();
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
            this.toolStripSeparator1,
            this.toolBrnRefresh,
            this.toolBtnReport,
            this.toolBtnExport,
            this.toolStripSeparator2,
            this.toolBtnFind,
            this.toolTextFind,
            this.toolBtnFindPrev,
            this.toolBtnFindNext,
            this.toolStripSeparator3,
            this.toolBtnSettingsSend,
            this.toolStripButtonExportExcel1});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1026, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolSplitBtnAddRequestRepair
            // 
            this.toolSplitBtnAddRequestRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSplitBtnAddRequestRepair.Image = global::RequestForRepairN.Properties.Resources.ElementAdd;
            this.toolSplitBtnAddRequestRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSplitBtnAddRequestRepair.Name = "toolSplitBtnAddRequestRepair";
            this.toolSplitBtnAddRequestRepair.Size = new System.Drawing.Size(32, 22);
            this.toolSplitBtnAddRequestRepair.Text = "Новая заявка";
            // 
            // toolBtnEditRequestRepair
            // 
            this.toolBtnEditRequestRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEditRequestRepair.Image = global::RequestForRepairN.Properties.Resources.ElementEdit;
            this.toolBtnEditRequestRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEditRequestRepair.Name = "toolBtnEditRequestRepair";
            this.toolBtnEditRequestRepair.Size = new System.Drawing.Size(23, 22);
            this.toolBtnEditRequestRepair.Text = "Редактировать заявку";
            this.toolBtnEditRequestRepair.Click += new System.EventHandler(this.toolBtnEditRequestRepair_Click);
            // 
            // toolBtnReadRequestRepair
            // 
            this.toolBtnReadRequestRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReadRequestRepair.Image = global::RequestForRepairN.Properties.Resources.ElementInformation;
            this.toolBtnReadRequestRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReadRequestRepair.Name = "toolBtnReadRequestRepair";
            this.toolBtnReadRequestRepair.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReadRequestRepair.Text = "Просмотр заявки";
            this.toolBtnReadRequestRepair.Click += new System.EventHandler(this.toolBtnReadRequestRepair_Click);
            // 
            // toolBtnDelRequestRepair
            // 
            this.toolBtnDelRequestRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelRequestRepair.Image = global::RequestForRepairN.Properties.Resources.ElementDel;
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
            this.toolBtnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnImport.Name = "toolBtnImport";
            this.toolBtnImport.Size = new System.Drawing.Size(16, 22);
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
            this.toolBtnRequestCopy.Image = global::RequestForRepairN.Properties.Resources.CopyBuffer;
            this.toolBtnRequestCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRequestCopy.Name = "toolBtnRequestCopy";
            this.toolBtnRequestCopy.Size = new System.Drawing.Size(32, 22);
            this.toolBtnRequestCopy.Text = "Копировать";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBrnRefresh
            // 
            this.toolBrnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBrnRefresh.Image = global::RequestForRepairN.Properties.Resources.refresh_16;
            this.toolBrnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBrnRefresh.Name = "toolBrnRefresh";
            this.toolBrnRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolBrnRefresh.Text = "Обновить";
            this.toolBrnRefresh.Click += new System.EventHandler(this.toolBrnRefresh_Click);
            // 
            // toolBtnReport
            // 
            this.toolBtnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReport.Image = global::RequestForRepairN.Properties.Resources.report;
            this.toolBtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReport.Text = "Отчет";
            this.toolBtnReport.Click += new System.EventHandler(this.toolBtnReport_Click);
            // 
            // toolBtnExport
            // 
            this.toolBtnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnExport.Image = global::RequestForRepairN.Properties.Resources.report_go;
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
            this.toolBtnFind.Image = global::RequestForRepairN.Properties.Resources.Find;
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
            this.toolBtnFindPrev.Image = global::RequestForRepairN.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindPrev.Text = "Поиск назад";
            this.toolBtnFindPrev.Click += new System.EventHandler(this.toolBtnFindPrev_Click);
            // 
            // toolBtnFindNext
            // 
            this.toolBtnFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::RequestForRepairN.Properties.Resources.FindNext;
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
            this.toolBtnSettingsSend.Image = global::RequestForRepairN.Properties.Resources.FTP;
            this.toolBtnSettingsSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSettingsSend.Name = "toolBtnSettingsSend";
            this.toolBtnSettingsSend.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSettingsSend.Text = "Настройки отправки";
            this.toolBtnSettingsSend.Click += new System.EventHandler(this.toolBtnSettingsSend_Click);
            // 
            // toolStripButtonExportExcel1
            // 
            this.toolStripButtonExportExcel1.DataGridView = this.dgv;
            this.toolStripButtonExportExcel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExportExcel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExportExcel1.Name = "toolStripButtonExportExcel1";
            this.toolStripButtonExportExcel1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExportExcel1.Text = "Экспорт в Excel";
            this.toolStripButtonExportExcel1.Click += new System.EventHandler(this.toolStripButtonExportExcel1_Click);
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
            this.dateTripBeg,
            this.dateTripEnd,
            this.agreedDgvColumn,
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
            this.dgv.DataSource = this.bsRequestForRepair;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle7;
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
            this.isSendDgvColumn.Width = 5;
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
            // dateTripBeg
            // 
            this.dateTripBeg.DataPropertyName = "dateTripBeg";
            this.dateTripBeg.HeaderText = "Дата С";
            this.dateTripBeg.Name = "dateTripBeg";
            this.dateTripBeg.ReadOnly = true;
            this.dateTripBeg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateTripEnd
            // 
            this.dateTripEnd.DataPropertyName = "dateTripEnd";
            this.dateTripEnd.HeaderText = "Дата По";
            this.dateTripEnd.Name = "dateTripEnd";
            this.dateTripEnd.ReadOnly = true;
            this.dateTripEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // agreeWithDataGridViewTextBoxColumn
            // 
            this.agreeWithDataGridViewTextBoxColumn.DataPropertyName = "AgreeWith";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.agreeWithDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.agreeWithDataGridViewTextBoxColumn.HeaderText = "Согласовать с";
            this.agreeWithDataGridViewTextBoxColumn.Name = "agreeWithDataGridViewTextBoxColumn";
            this.agreeWithDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewImageColumn
            // 
            this.commentDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.commentDataGridViewImageColumn.DataPropertyName = "Comment";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.dateAgreedDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
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
            // bsRequestForRepair
            // 
            this.bsRequestForRepair.DataMember = "vJ_RequestForRepair";
            this.bsRequestForRepair.DataSource = this.DataSetDamage;
            this.bsRequestForRepair.CurrentChanged += new System.EventHandler(this.bsRequestForRepair_CurrentChanged);
            // 
            // DataSetDamage
            // 
            this.DataSetDamage.DataSetName = "DataSetGES";
            this.DataSetDamage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.splitContainer.Panel1.Controls.Add(this.label3);
            this.splitContainer.Panel1.Controls.Add(this.dateTimePickerEnd);
            this.splitContainer.Panel1.Controls.Add(this.dateTimePickerBeg);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.label1);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Подразделения";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "От";
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
            this.toolBtnFilter.Image = global::RequestForRepairN.Properties.Resources.filter;
            this.toolBtnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFilter.Name = "toolBtnFilter";
            this.toolBtnFilter.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFilter.Text = "Применить фильтр";
            this.toolBtnFilter.Click += new System.EventHandler(this.toolBtnFilter_Click);
            // 
            // toolBtnNoFilter
            // 
            this.toolBtnNoFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnNoFilter.Image = global::RequestForRepairN.Properties.Resources.filter_delete;
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
            this.dgvDamage.DataSource = this.bsDamage;
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
            // bsDamage
            // 
            this.bsDamage.DataMember = "vJ_Damage";
            this.bsDamage.DataSource = this.DataSetDamage;
            // 
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
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
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
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewFilterTextBoxColumn5.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn5.Name = "dataGridViewFilterTextBoxColumn5";
            this.dataGridViewFilterTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn6
            // 
            this.dataGridViewFilterTextBoxColumn6.DataPropertyName = "Purpose";
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewFilterTextBoxColumn6.HeaderText = "Цель";
            this.dataGridViewFilterTextBoxColumn6.Name = "dataGridViewFilterTextBoxColumn6";
            // 
            // dataGridViewFilterTextBoxColumn7
            // 
            this.dataGridViewFilterTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewFilterTextBoxColumn7.DataPropertyName = "DateTripBeg";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewFilterTextBoxColumn7.HeaderText = "Дата С";
            this.dataGridViewFilterTextBoxColumn7.Name = "dataGridViewFilterTextBoxColumn7";
            this.dataGridViewFilterTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn8
            // 
            this.dataGridViewFilterTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewFilterTextBoxColumn8.DataPropertyName = "DateTripEnd";
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Format = "d";
            dataGridViewCellStyle13.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle13;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJournalRequestForRepair";
            this.Text = "Журнал заявок на ремонт оборудования (N2)";
            this.Load += new System.EventHandler(this.FormJournalRequestForRepair_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequestForRepair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetDamage)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsDamage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private RequestForRepairN.DataSets.DataSetDamage DataSetDamage;

        //private RequestForRepairN.DataSets.DataSetN DataSetDamage;

        private ToolStrip toolStrip;

        private BindingSource bsRequestForRepair;

        private DataGridViewExcelFilter dgv;

        private ToolStripSplitButton toolSplitBtnAddRequestRepair;

        private ToolStripButton toolBtnEditRequestRepair;

        private ToolStripButton toolBtnDelRequestRepair;

        private ToolStripButton toolBtnReadRequestRepair;

        private ToolStripSplitButton toolBtnImport;

        private ToolStripMenuItem toolBtnImportODS;

        private ToolStripMenuItem toolBtnImportPL;

        private SplitContainer splitContainer;

        private Label label1;

        private DateTimePicker dateTimePickerEnd;

        private DateTimePicker dateTimePickerBeg;

        private Label label2;

        private CheckedListBox checkedListBoxDivision;

        private Label label3;

        private ToolStripProgressBar toolStripProgressBarLoad;

        private ToolStripLabel toolStripLabelLoad;

        private BackgroundWorker backgroundWorker;

        private ToolStrip toolStripFilter;

        private ToolStripButton toolBtnFilter;

        private ToolStripButton toolBtnNoFilter;

        private ToolStripSeparator toolStripSeparator1;

        private ToolStripButton toolBrnRefresh;

        private ToolStripButton toolBtnReport;

        private ToolStripButton toolBtnExport;

        private ToolStripSplitButton toolBtnRequestCopy;

        private ToolStripSeparator toolStripSeparator2;

        private ToolStripButton toolBtnFind;

        private ToolStripTextBox toolTextFind;

        private ToolStripButton toolBtnFindPrev;

        private ToolStripButton toolBtnFindNext;

        private ToolStripSeparator toolStripSeparator3;

        private ToolStripButton toolBtnSettingsSend;

        private SplitContainer splitContainerDgv;

        private Label lbChildDoc;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn1;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn2;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn3;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn4;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn5;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn6;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn7;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn8;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn9;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn10;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn11;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn12;

        private DataGridViewExcelFilter dgvDamage;

        private DataGridViewTextBoxColumn numrequestDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn dateDocDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn typeDocNameDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn schmObjNameDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;

        private DataGridViewCheckBoxColumn isApplyDataGridViewCheckBoxColumn;

        private BindingSource bsDamage;

        

        //private DataGridViewFilterTextBoxColumn dateTripBegDataGridViewTextBoxColumn;

        //private DataGridViewFilterTextBoxColumn dateTripEndDgvColumn;

        //private DataGridViewFilterTextBoxColumn dateFactEndDgvColumn;
        private Library.ToolStripButtonExportExcel toolStripButtonExportExcel1;
        private DataGridViewCheckBoxColumn isSendDgvColumn;
        private DataGridViewCheckBoxColumn isPlannedDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn deletedDgvCheckBoxColumn;
        private DataGridViewFilterTextBoxColumn numDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateCreateDgvColumn;
        private DataGridViewFilterTextBoxColumn sRDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn reguestFiledDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn schmObjDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn PurposeDgvTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateTripBeg;
        private DataGridViewFilterTextBoxColumn dateTripEnd;
        private DataGridViewFilterCheckBoxColumn agreedDgvColumn;
        private DataGridViewTextBoxColumn agreeWithDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn commentDataGridViewImageColumn;
        private DataGridViewTextBoxColumn workerCreateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateAgreedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iddivisionDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn divisionDataGridViewTextBoxColumn;
        private DataGridViewFilterCheckBoxColumn sendSiteDgvColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn colorStatusDgvColumn;
    }
}
