using ControlsLbr.DataGridViewExcelFilter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NotificationOfRepairs
{
	public partial class FormJournalNotificationOfRepairs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJournalNotificationOfRepairs));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolSplitBtnAddRequestRepair = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEditRequestRepair = new System.Windows.Forms.ToolStripButton();
            this.toolBtnReadRequestRepair = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelRequestRepair = new System.Windows.Forms.ToolStripButton();
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
            this.toolStripButtonExportExcel1 = new Library.ToolStripButtonExportExcel(this.components);
            this.dgv = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.deletedDgvCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateCreateDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.sRDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.reguestFiledDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateTripBeg = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateTripEnd = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.commentDataGridViewImageColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.workerCreateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddivisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorStatusDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.bsNotificationOfRepairs = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetNotifications = new NotificationOfRepairs.DataSets.DataSetNotifications();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBeg = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripFilter = new System.Windows.Forms.ToolStrip();
            this.toolBtnFilter = new System.Windows.Forms.ToolStripButton();
            this.toolBtnNoFilter = new System.Windows.Forms.ToolStripButton();
            this.splitContainerDgv = new System.Windows.Forms.SplitContainer();
            this.dgvRequest = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.numrequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schmObjNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRequest = new System.Windows.Forms.BindingSource(this.components);
            this.lbChildDoc = new System.Windows.Forms.Label();
            this.isApplyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsNotificationOfRepairs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNotifications)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStripFilter.SuspendLayout();
            this.splitContainerDgv.Panel1.SuspendLayout();
            this.splitContainerDgv.Panel2.SuspendLayout();
            this.splitContainerDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSplitBtnAddRequestRepair,
            this.toolBtnEditRequestRepair,
            this.toolBtnReadRequestRepair,
            this.toolBtnDelRequestRepair,
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
            this.toolSplitBtnAddRequestRepair.Image = global::NotificationOfRepairs.Properties.Resources.ElementAdd;
            this.toolSplitBtnAddRequestRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSplitBtnAddRequestRepair.Name = "toolSplitBtnAddRequestRepair";
            this.toolSplitBtnAddRequestRepair.Size = new System.Drawing.Size(23, 22);
            this.toolSplitBtnAddRequestRepair.Text = "Новая заявка";
            this.toolSplitBtnAddRequestRepair.Click += new System.EventHandler(this.toolSplitBtnAddRequestRepair_Click);
            // 
            // toolBtnEditRequestRepair
            // 
            this.toolBtnEditRequestRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEditRequestRepair.Image = global::NotificationOfRepairs.Properties.Resources.ElementEdit;
            this.toolBtnEditRequestRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEditRequestRepair.Name = "toolBtnEditRequestRepair";
            this.toolBtnEditRequestRepair.Size = new System.Drawing.Size(23, 22);
            this.toolBtnEditRequestRepair.Text = "Редактировать заявку";
            this.toolBtnEditRequestRepair.Click += new System.EventHandler(this.toolBtnEditRequestRepair_Click);
            // 
            // toolBtnReadRequestRepair
            // 
            this.toolBtnReadRequestRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReadRequestRepair.Image = global::NotificationOfRepairs.Properties.Resources.ElementInformation;
            this.toolBtnReadRequestRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReadRequestRepair.Name = "toolBtnReadRequestRepair";
            this.toolBtnReadRequestRepair.Size = new System.Drawing.Size(23, 22);
            this.toolBtnReadRequestRepair.Text = "Просмотр заявки";
            this.toolBtnReadRequestRepair.Click += new System.EventHandler(this.toolBtnReadRequestRepair_Click);
            // 
            // toolBtnDelRequestRepair
            // 
            this.toolBtnDelRequestRepair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelRequestRepair.Image = global::NotificationOfRepairs.Properties.Resources.ElementDel;
            this.toolBtnDelRequestRepair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelRequestRepair.Name = "toolBtnDelRequestRepair";
            this.toolBtnDelRequestRepair.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelRequestRepair.Text = "Удалить заявку";
            this.toolBtnDelRequestRepair.Click += new System.EventHandler(this.toolBtnDelRequestRepair_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBrnRefresh
            // 
            this.toolBrnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBrnRefresh.Image = global::NotificationOfRepairs.Properties.Resources.refresh_16;
            this.toolBrnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBrnRefresh.Name = "toolBrnRefresh";
            this.toolBrnRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolBrnRefresh.Text = "Обновить";
            this.toolBrnRefresh.Click += new System.EventHandler(this.toolBrnRefresh_Click);
            // 
            // toolBtnReport
            // 
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new System.Drawing.Size(23, 22);
            // 
            // toolBtnExport
            // 
            this.toolBtnExport.Name = "toolBtnExport";
            this.toolBtnExport.Size = new System.Drawing.Size(23, 22);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnFind
            // 
            this.toolBtnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFind.Image = global::NotificationOfRepairs.Properties.Resources.Find;
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
            this.toolBtnFindPrev.Image = global::NotificationOfRepairs.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindPrev.Text = "Поиск назад";
            this.toolBtnFindPrev.Click += new System.EventHandler(this.toolBtnFindPrev_Click);
            // 
            // toolBtnFindNext
            // 
            this.toolBtnFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::NotificationOfRepairs.Properties.Resources.FindNext;
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
            this.deletedDgvCheckBoxColumn,
            this.numDataGridViewTextBoxColumn,
            this.dateCreateDgvColumn,
            this.sRDataGridViewTextBoxColumn,
            this.reguestFiledDataGridViewTextBoxColumn,
            this.dateTripBeg,
            this.dateTripEnd,
            this.commentDataGridViewImageColumn,
            this.workerCreateDataGridViewTextBoxColumn,
            this.iddivisionDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.colorStatusDgvColumn});
            this.dgv.DataSource = this.bsNotificationOfRepairs;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
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
            // commentDataGridViewImageColumn
            // 
            this.commentDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.commentDataGridViewImageColumn.DataPropertyName = "Comment";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.commentDataGridViewImageColumn.DefaultCellStyle = dataGridViewCellStyle2;
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
            // bsNotificationOfRepairs
            // 
            this.bsNotificationOfRepairs.DataMember = "vJ_NotificationOfRepairs";
            this.bsNotificationOfRepairs.DataSource = this.DataSetNotifications;
            this.bsNotificationOfRepairs.CurrentChanged += new System.EventHandler(this.bsNotificationOfRepairs_CurrentChanged);
            // 
            // DataSetNotifications
            // 
            this.DataSetNotifications.DataSetName = "DataSetGES";
            this.DataSetNotifications.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.toolBtnFilter.Image = global::NotificationOfRepairs.Properties.Resources.filter;
            this.toolBtnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFilter.Name = "toolBtnFilter";
            this.toolBtnFilter.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFilter.Text = "Применить фильтр";
            this.toolBtnFilter.Click += new System.EventHandler(this.toolBtnFilter_Click);
            // 
            // toolBtnNoFilter
            // 
            this.toolBtnNoFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnNoFilter.Image = global::NotificationOfRepairs.Properties.Resources.filter_delete;
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
            this.splitContainerDgv.Panel2.Controls.Add(this.dgvRequest);
            this.splitContainerDgv.Panel2.Controls.Add(this.lbChildDoc);
            this.splitContainerDgv.Panel2MinSize = 13;
            this.splitContainerDgv.Size = new System.Drawing.Size(845, 554);
            this.splitContainerDgv.SplitterDistance = 400;
            this.splitContainerDgv.TabIndex = 2;
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.AllowUserToVisibleColumns = false;
            this.dgvRequest.AutoGenerateColumns = false;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numrequestDataGridViewTextBoxColumn,
            this.dateDocDataGridViewTextBoxColumn,
            this.typeDocNameDataGridViewTextBoxColumn,
            this.schmObjNameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1});
            this.dgvRequest.DataSource = this.bsRequest;
            this.dgvRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequest.Location = new System.Drawing.Point(0, 13);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.RowHeadersWidth = 21;
            this.dgvRequest.Size = new System.Drawing.Size(845, 137);
            this.dgvRequest.TabIndex = 9;
            this.dgvRequest.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRequestDefaultValuesNeeded);
            // 
            // numrequestDataGridViewTextBoxColumn
            // 
            this.numrequestDataGridViewTextBoxColumn.DataPropertyName = "num";
            this.numrequestDataGridViewTextBoxColumn.HeaderText = "№ док.";
            this.numrequestDataGridViewTextBoxColumn.Name = "numrequestDataGridViewTextBoxColumn";
            this.numrequestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDocDataGridViewTextBoxColumn
            // 
            this.dateDocDataGridViewTextBoxColumn.DataPropertyName = "dateCreate";
            this.dateDocDataGridViewTextBoxColumn.HeaderText = "Дата док";
            this.dateDocDataGridViewTextBoxColumn.Name = "dateDocDataGridViewTextBoxColumn";
            this.dateDocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDocNameDataGridViewTextBoxColumn
            // 
            this.typeDocNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDocNameDataGridViewTextBoxColumn.HeaderText = "Тип документа";
            this.typeDocNameDataGridViewTextBoxColumn.Name = "typeDocNameDataGridViewTextBoxColumn";
            this.typeDocNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schmObjNameDataGridViewTextBoxColumn
            // 
            this.schmObjNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.schmObjNameDataGridViewTextBoxColumn.DataPropertyName = "schmObj";
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
            // bsRequest
            // 
            this.bsRequest.DataMember = "vJ_RequestForRepair";
            this.bsRequest.DataSource = this.DataSetNotifications;
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
            // isApplyDataGridViewCheckBoxColumn
            // 
            this.isApplyDataGridViewCheckBoxColumn.Name = "isApplyDataGridViewCheckBoxColumn";
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
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewFilterTextBoxColumn5.HeaderText = "Объект";
            this.dataGridViewFilterTextBoxColumn5.Name = "dataGridViewFilterTextBoxColumn5";
            this.dataGridViewFilterTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn6
            // 
            this.dataGridViewFilterTextBoxColumn6.DataPropertyName = "Purpose";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFilterTextBoxColumn6.HeaderText = "Цель";
            this.dataGridViewFilterTextBoxColumn6.Name = "dataGridViewFilterTextBoxColumn6";
            // 
            // dataGridViewFilterTextBoxColumn7
            // 
            this.dataGridViewFilterTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewFilterTextBoxColumn7.DataPropertyName = "DateTripBeg";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewFilterTextBoxColumn7.HeaderText = "Дата С";
            this.dataGridViewFilterTextBoxColumn7.Name = "dataGridViewFilterTextBoxColumn7";
            this.dataGridViewFilterTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn8
            // 
            this.dataGridViewFilterTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewFilterTextBoxColumn8.DataPropertyName = "DateTripEnd";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle8;
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
            dataGridViewCellStyle9.Format = "d";
            dataGridViewCellStyle9.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle9;
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
            // FormJournalNotificationOfRepairs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 579);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormJournalNotificationOfRepairs";
            this.Text = "Журнал уведомлений абонентов об отключении";
            this.Load += new System.EventHandler(this.NotificationOfRepairs_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNotificationOfRepairs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetNotifications)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.toolStripFilter.ResumeLayout(false);
            this.toolStripFilter.PerformLayout();
            this.splitContainerDgv.Panel1.ResumeLayout(false);
            this.splitContainerDgv.Panel2.ResumeLayout(false);
            this.splitContainerDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private NotificationOfRepairs.DataSets.DataSetNotifications DataSetNotifications;
        private ToolStrip toolStrip;
        private BindingSource bsNotificationOfRepairs;
        private DataGridViewExcelFilter dgv;
        private ToolStripButton toolSplitBtnAddRequestRepair;
        private ToolStripButton toolBtnEditRequestRepair;
        private ToolStripButton toolBtnDelRequestRepair;
        private ToolStripButton toolBtnReadRequestRepair;
        private SplitContainer splitContainer;
        private Label label1;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerBeg;
        private Label label2;
        private BackgroundWorker backgroundWorker;
        private ToolStrip toolStripFilter;
        private ToolStripButton toolBtnFilter;
        private ToolStripButton toolBtnNoFilter;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolBrnRefresh;
        private ToolStripButton toolBtnReport;
        private ToolStripButton toolBtnExport;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolBtnFind;
        private ToolStripTextBox toolTextFind;
        private ToolStripButton toolBtnFindPrev;
        private ToolStripButton toolBtnFindNext;
        private ToolStripSeparator toolStripSeparator3;
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
        private DataGridViewExcelFilter dgvRequest;
        private DataGridViewTextBoxColumn numrequestDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDocNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn schmObjNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn isApplyDataGridViewCheckBoxColumn;
        private BindingSource bsRequest;
        private Library.ToolStripButtonExportExcel toolStripButtonExportExcel1;
        private DataGridViewCheckBoxColumn deletedDgvCheckBoxColumn;
        private DataGridViewFilterTextBoxColumn numDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateCreateDgvColumn;
        private DataGridViewFilterTextBoxColumn sRDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn reguestFiledDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateTripBeg;
        private DataGridViewFilterTextBoxColumn dateTripEnd;
        private DataGridViewFilterTextBoxColumn commentDataGridViewImageColumn;
        private DataGridViewTextBoxColumn workerCreateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn iddivisionDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn divisionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn colorStatusDgvColumn;
    }
}
