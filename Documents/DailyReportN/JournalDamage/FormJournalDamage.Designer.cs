using ControlsLbr.DataGridViewExcelFilter;
using ControlsLbr.Scheme;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace DailyReportN.JournalDamage
{
	public partial class FormJournalDamage : FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private global::System.ComponentModel.IContainer components=null;


        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnAdd = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolBtnInfo = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator_1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnFind = new System.Windows.Forms.ToolStripButton();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnReport = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolMenuItemReportDailyLV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemSheetInterruptLV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemReportDailyDefect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemReportDailyHV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuAmergencyShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemReport81 = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетРуководителюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBTnLoadOld = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolBtnLoadOldDamageLV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnLoadOldDefect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnLoadAbnDefectLV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnLoadOldDamageНV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnLoadOldDamageLVMySQL = new System.Windows.Forms.ToolStripMenuItem();
            this.damageHVToDamageMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damageLVToDamageMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnDamageNoApply = new System.Windows.Forms.ToolStripButton();
            this.toolBtnUnLockSend = new System.Windows.Forms.ToolStripButton();
            this.toolBtnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSettingMail = new System.Windows.Forms.ToolStripButton();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBoxLegend = new System.Windows.Forms.GroupBox();
            this.txtLegendNoSESNO = new System.Windows.Forms.TextBox();
            this.txtLegendUnExec = new System.Windows.Forms.TextBox();
            this.txtLegendOverdue = new System.Windows.Forms.TextBox();
            this.txtLegendInWork = new System.Windows.Forms.TextBox();
            this.txtLegendApply = new System.Windows.Forms.TextBox();
            this.checkedListBoxDivisionApply = new System.Windows.Forms.CheckedListBox();
            this.checkBoxWhereSub = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripTreeSchmObj = new System.Windows.Forms.ToolStrip();
            this.toolBtnFindTreeSchmObj = new System.Windows.Forms.ToolStripButton();
            this.txtFindTreeSchmObj = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindPrevTreeSchmObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindNextTreeSchmObj = new System.Windows.Forms.ToolStripButton();
            this.treeViewSchmObjects = new ControlsLbr.Scheme.TreeViewSchmObjects();
            this.checkedListBoxDivision = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFilterEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFilterBeg = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripFilter = new System.Windows.Forms.ToolStrip();
            this.toolBtnFilterApply = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFilterDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnPrevYear = new System.Windows.Forms.ToolStripButton();
            this.toolBtnNextYear = new System.Windows.Forms.ToolStripButton();
            this.splitContainerDgv = new System.Windows.Forms.SplitContainer();
            this.dgvDamage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.isLaboratoryDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.isApplyDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.numrequestDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.numDocDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateDocDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeDocNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.schmObjNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.netRegionSubDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.defectLocationDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.cityDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.streetDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.characterDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.divisionApplyDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateApplyDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.datePlanEndDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.workerApplyDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.completedWorkDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.compilerDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.InstructionDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameOwnerDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateOwnerDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.comletedWorkTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodPTSDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.kodPTSStrDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idParentDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isNoSESNODgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.is81DgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.typeDocDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReasonDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReqForRepairDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendSiteMeDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.isSendSiteMeDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsDamage = new System.Windows.Forms.BindingSource(this.components);
            this.dsDamageN = new DailyReportN.DataSet.dsDamage();
            this.dgvLinkDocs = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.numDocDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLinkDocDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isParentDgvColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bsLinkDocs = new System.Windows.Forms.BindingSource(this.components);
            this.dsJournalLocalN = new System.Data.DataSet();
            this.dtLinkDocs = new System.Data.DataTable();
            this.id = new System.Data.DataColumn();
            this.TypeDoc = new System.Data.DataColumn();
            this.TypeDocName = new System.Data.DataColumn();
            this.numDoc = new System.Data.DataColumn();
            this.dateDoc = new System.Data.DataColumn();
            this.idReqForRepair = new System.Data.DataColumn();
            this.isParent = new System.Data.DataColumn();
            this.lbLinkDoc = new System.Windows.Forms.Label();
            this.contextMenuDamage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolItemActDetection = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemActDetectionAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridViewFilterTextBoxColumn1 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn2 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn3 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn4 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn5 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn6 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn7 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn8 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn9 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn10 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn11 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn12 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn13 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn14 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn15 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn16 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn17 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn18 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewFilterTextBoxColumn19 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.toolStrip.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBoxLegend.SuspendLayout();
            this.toolStripTreeSchmObj.SuspendLayout();
            this.toolStripFilter.SuspendLayout();
            this.splitContainerDgv.Panel1.SuspendLayout();
            this.splitContainerDgv.Panel2.SuspendLayout();
            this.splitContainerDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDamageN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLinkDocs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJournalLocalN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLinkDocs)).BeginInit();
            this.contextMenuDamage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAdd,
            this.toolBtnEdit,
            this.toolBtnInfo,
            this.toolBtnDel,
            this.toolStripSeparator1,
            this.toolBtnRefresh,
            this.toolStripSeparator_1,
            this.toolBtnFind,
            this.txtFind,
            this.toolBtnFindPrev,
            this.toolBtnFindNext,
            this.toolStripSeparator3,
            this.toolBtnReport,
            this.toolBTnLoadOld,
            this.toolBtnDamageNoApply,
            this.toolBtnUnLockSend,
            this.toolBtnExportExcel,
            this.toolBtnPrint,
            this.toolBtnSettingMail,
            this.progressBar});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1276, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolBtnAdd
            // 
            this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAdd.Image = global::DailyReportN.Properties.Resources.Add;
            this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new System.Drawing.Size(29, 22);
            this.toolBtnAdd.Text = "Добавить";
            // 
            // toolBtnEdit
            // 
            this.toolBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEdit.Image = global::DailyReportN.Properties.Resources.Edit;
            this.toolBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEdit.Name = "toolBtnEdit";
            this.toolBtnEdit.Size = new System.Drawing.Size(23, 22);
            this.toolBtnEdit.Text = "Редактировать";
            this.toolBtnEdit.Click += new System.EventHandler(this.toolBtnEdit_Click);
            // 
            // toolBtnInfo
            // 
            this.toolBtnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnInfo.Image = global::DailyReportN.Properties.Resources.ElementInformation;
            this.toolBtnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnInfo.Name = "toolBtnInfo";
            this.toolBtnInfo.Size = new System.Drawing.Size(23, 22);
            this.toolBtnInfo.Text = "Информация";
            this.toolBtnInfo.Click += new System.EventHandler(this.toolBtnInfo_Click);
            // 
            // toolBtnDel
            // 
            this.toolBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDel.Image = global::DailyReportN.Properties.Resources.ElementDel;
            this.toolBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDel.Name = "toolBtnDel";
            this.toolBtnDel.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDel.Text = "Удалить документ";
            this.toolBtnDel.Click += new System.EventHandler(this.toolBtnDel_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnRefresh
            // 
            this.toolBtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnRefresh.Image = global::DailyReportN.Properties.Resources.Refresh;
            this.toolBtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnRefresh.Name = "toolBtnRefresh";
            this.toolBtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolBtnRefresh.Text = "Обновить";
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
            this.toolBtnFind.Image = global::DailyReportN.Properties.Resources.Find;
            this.toolBtnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFind.Name = "toolBtnFind";
            this.toolBtnFind.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFind.Text = "Искать";
            this.toolBtnFind.Click += new System.EventHandler(this.toolBtnFind_Click);
            // 
            // txtFind
            // 
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(100, 25);
            this.txtFind.ToolTipText = "Текст для поиска";
            this.txtFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFind_KeyDown);
            // 
            // toolBtnFindPrev
            // 
            this.toolBtnFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrev.Image = global::DailyReportN.Properties.Resources.FindPrev;
            this.toolBtnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindPrev.Name = "toolBtnFindPrev";
            this.toolBtnFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindPrev.Text = "Искать назад";
            this.toolBtnFindPrev.Click += new System.EventHandler(this.toolBtnFindPrev_Click);
            // 
            // toolBtnFindNext
            // 
            this.toolBtnFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNext.Image = global::DailyReportN.Properties.Resources.FindNext;
            this.toolBtnFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindNext.Name = "toolBtnFindNext";
            this.toolBtnFindNext.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindNext.Text = "Искать вперед";
            this.toolBtnFindNext.Click += new System.EventHandler(this.toolBtnFindNext_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnReport
            // 
            this.toolBtnReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemReportDailyLV,
            this.toolMenuItemSheetInterruptLV,
            this.toolMenuItemReportDailyDefect,
            this.toolMenuItemReportDailyHV,
            this.tsMenuAmergencyShutdown,
            this.toolMenuItemReport81,
            this.отчетРуководителюToolStripMenuItem});
            this.toolBtnReport.Image = global::DailyReportN.Properties.Resources.Report;
            this.toolBtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new System.Drawing.Size(29, 22);
            this.toolBtnReport.Text = "Отчеты";
            // 
            // toolMenuItemReportDailyLV
            // 
            this.toolMenuItemReportDailyLV.Name = "toolMenuItemReportDailyLV";
            this.toolMenuItemReportDailyLV.Size = new System.Drawing.Size(381, 22);
            this.toolMenuItemReportDailyLV.Text = "Суточный рапорт в сетях 0,4кВ (ОДС)";
            this.toolMenuItemReportDailyLV.Click += new System.EventHandler(this.toolMenuItemReportDailyLV_Click);
            // 
            // toolMenuItemSheetInterruptLV
            // 
            this.toolMenuItemSheetInterruptLV.Name = "toolMenuItemSheetInterruptLV";
            this.toolMenuItemSheetInterruptLV.Size = new System.Drawing.Size(381, 22);
            this.toolMenuItemSheetInterruptLV.Text = "Бюллетень перерывов электроснабжения в сетях 0,4 кВ";
            this.toolMenuItemSheetInterruptLV.Click += new System.EventHandler(this.toolMenuItemSheetInterruptLV_Click);
            // 
            // toolMenuItemReportDailyDefect
            // 
            this.toolMenuItemReportDailyDefect.Name = "toolMenuItemReportDailyDefect";
            this.toolMenuItemReportDailyDefect.Size = new System.Drawing.Size(381, 22);
            this.toolMenuItemReportDailyDefect.Text = "Суточный рапорт по дефектам";
            this.toolMenuItemReportDailyDefect.Click += new System.EventHandler(this.toolMenuItemReportDailyDefect_Click);
            // 
            // toolMenuItemReportDailyHV
            // 
            this.toolMenuItemReportDailyHV.Name = "toolMenuItemReportDailyHV";
            this.toolMenuItemReportDailyHV.Size = new System.Drawing.Size(381, 22);
            this.toolMenuItemReportDailyHV.Text = "Суточный рапорт в сетях 6-10 кВ";
            this.toolMenuItemReportDailyHV.Click += new System.EventHandler(this.toolMenuItemReportDailyHV_Click);
            // 
            // tsMenuAmergencyShutdown
            // 
            this.tsMenuAmergencyShutdown.Name = "tsMenuAmergencyShutdown";
            this.tsMenuAmergencyShutdown.Size = new System.Drawing.Size(381, 22);
            this.tsMenuAmergencyShutdown.Text = "Бюллетень аварийных отключений";
            this.tsMenuAmergencyShutdown.Click += new System.EventHandler(this.tsMenuAmergencyShutdown_Click);
            // 
            // toolMenuItemReport81
            // 
            this.toolMenuItemReport81.Name = "toolMenuItemReport81";
            this.toolMenuItemReport81.Size = new System.Drawing.Size(381, 22);
            this.toolMenuItemReport81.Text = "Бюллетень 8.1";
            this.toolMenuItemReport81.Click += new System.EventHandler(this.toolMenuItemReport81_Click);
            // 
            // отчетРуководителюToolStripMenuItem
            // 
            this.отчетРуководителюToolStripMenuItem.Name = "отчетРуководителюToolStripMenuItem";
            this.отчетРуководителюToolStripMenuItem.Size = new System.Drawing.Size(381, 22);
            this.отчетРуководителюToolStripMenuItem.Text = "Отчет руководителю";
            this.отчетРуководителюToolStripMenuItem.Click += new System.EventHandler(this.отчетРуководителюToolStripMenuItem_Click);
            // 
            // toolBTnLoadOld
            // 
            this.toolBTnLoadOld.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBTnLoadOld.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBTnLoadOld.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnLoadOldDamageLV,
            this.toolBtnLoadOldDefect,
            this.toolBtnLoadAbnDefectLV,
            this.toolBtnLoadOldDamageНV,
            this.toolBtnLoadOldDamageLVMySQL,
            this.damageHVToDamageMainToolStripMenuItem,
            this.damageLVToDamageMainToolStripMenuItem});
            this.toolBTnLoadOld.Image = global::DailyReportN.Properties.Resources.Load;
            this.toolBTnLoadOld.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBTnLoadOld.Name = "toolBTnLoadOld";
            this.toolBTnLoadOld.Size = new System.Drawing.Size(29, 22);
            this.toolBTnLoadOld.Text = "Загрузка из старой базы";
            // 
            // toolBtnLoadOldDamageLV
            // 
            this.toolBtnLoadOldDamageLV.Name = "toolBtnLoadOldDamageLV";
            this.toolBtnLoadOldDamageLV.Size = new System.Drawing.Size(219, 22);
            this.toolBtnLoadOldDamageLV.Text = "0.4кВ";
            this.toolBtnLoadOldDamageLV.Click += new System.EventHandler(this.toolBtnLoadOldDamageLV_Click);
            // 
            // toolBtnLoadOldDefect
            // 
            this.toolBtnLoadOldDefect.Name = "toolBtnLoadOldDefect";
            this.toolBtnLoadOldDefect.Size = new System.Drawing.Size(219, 22);
            this.toolBtnLoadOldDefect.Text = "Дефект";
            this.toolBtnLoadOldDefect.Click += new System.EventHandler(this.toolBtnLoadOldDefect_Click);
            // 
            // toolBtnLoadAbnDefectLV
            // 
            this.toolBtnLoadAbnDefectLV.Name = "toolBtnLoadAbnDefectLV";
            this.toolBtnLoadAbnDefectLV.Size = new System.Drawing.Size(219, 22);
            this.toolBtnLoadAbnDefectLV.Text = "Загрузить абонентов НН";
            this.toolBtnLoadAbnDefectLV.Click += new System.EventHandler(this.toolBtnLoadAbnDefectLV_Click);
            // 
            // toolBtnLoadOldDamageНV
            // 
            this.toolBtnLoadOldDamageНV.Name = "toolBtnLoadOldDamageНV";
            this.toolBtnLoadOldDamageНV.Size = new System.Drawing.Size(219, 22);
            this.toolBtnLoadOldDamageНV.Text = "ВН";
            this.toolBtnLoadOldDamageНV.Click += new System.EventHandler(this.toolBtnLoadOldDamageНV_Click);
            // 
            // toolBtnLoadOldDamageLVMySQL
            // 
            this.toolBtnLoadOldDamageLVMySQL.Name = "toolBtnLoadOldDamageLVMySQL";
            this.toolBtnLoadOldDamageLVMySQL.Size = new System.Drawing.Size(219, 22);
            this.toolBtnLoadOldDamageLVMySQL.Text = "Mysql";
            this.toolBtnLoadOldDamageLVMySQL.Click += new System.EventHandler(this.toolBtnLoadOldDamageLVMySQL_Click);
            // 
            // damageHVToDamageMainToolStripMenuItem
            // 
            this.damageHVToDamageMainToolStripMenuItem.Name = "damageHVToDamageMainToolStripMenuItem";
            this.damageHVToDamageMainToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.damageHVToDamageMainToolStripMenuItem.Text = "DamageHVToDamageMain";
            this.damageHVToDamageMainToolStripMenuItem.Click += new System.EventHandler(this.damageHVToDamageMainToolStripMenuItem_Click);
            // 
            // damageLVToDamageMainToolStripMenuItem
            // 
            this.damageLVToDamageMainToolStripMenuItem.Name = "damageLVToDamageMainToolStripMenuItem";
            this.damageLVToDamageMainToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.damageLVToDamageMainToolStripMenuItem.Text = "DamageLVToDamageMain";
            this.damageLVToDamageMainToolStripMenuItem.Click += new System.EventHandler(this.damageLVToDamageMainToolStripMenuItem_Click);
            // 
            // toolBtnDamageNoApply
            // 
            this.toolBtnDamageNoApply.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBtnDamageNoApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDamageNoApply.Image = global::DailyReportN.Properties.Resources.ElementUnLock1;
            this.toolBtnDamageNoApply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDamageNoApply.Name = "toolBtnDamageNoApply";
            this.toolBtnDamageNoApply.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDamageNoApply.Text = "Разблокировать документ";
            this.toolBtnDamageNoApply.Visible = false;
            this.toolBtnDamageNoApply.Click += new System.EventHandler(this.toolBtnDamageNoApply_Click);
            // 
            // toolBtnUnLockSend
            // 
            this.toolBtnUnLockSend.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBtnUnLockSend.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnUnLockSend.Image = global::DailyReportN.Properties.Resources.ElementUnLockSendRed2;
            this.toolBtnUnLockSend.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnUnLockSend.Name = "toolBtnUnLockSend";
            this.toolBtnUnLockSend.Size = new System.Drawing.Size(23, 22);
            this.toolBtnUnLockSend.Text = "toolBtnUnLockSend";
            this.toolBtnUnLockSend.ToolTipText = "Разблокировать отправку в МЭ";
            this.toolBtnUnLockSend.Visible = false;
            this.toolBtnUnLockSend.Click += new System.EventHandler(this.toolBtnUnLockSend_Click);
            // 
            // toolBtnExportExcel
            // 
            this.toolBtnExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnExportExcel.Image = global::DailyReportN.Properties.Resources.Excel;
            this.toolBtnExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnExportExcel.Name = "toolBtnExportExcel";
            this.toolBtnExportExcel.Size = new System.Drawing.Size(23, 22);
            this.toolBtnExportExcel.Text = "Экспорт в Excel";
            this.toolBtnExportExcel.Click += new System.EventHandler(this.toolBtnExportExcel_Click);
            // 
            // toolBtnPrint
            // 
            this.toolBtnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnPrint.Image = global::DailyReportN.Properties.Resources.Print;
            this.toolBtnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnPrint.Name = "toolBtnPrint";
            this.toolBtnPrint.Size = new System.Drawing.Size(23, 22);
            this.toolBtnPrint.Text = "Печать";
            this.toolBtnPrint.Click += new System.EventHandler(this.toolBtnPrint_Click);
            // 
            // toolBtnSettingMail
            // 
            this.toolBtnSettingMail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSettingMail.Image = global::DailyReportN.Properties.Resources.mail;
            this.toolBtnSettingMail.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSettingMail.Name = "toolBtnSettingMail";
            this.toolBtnSettingMail.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSettingMail.Text = "Настройки отправки почты";
            this.toolBtnSettingMail.Click += new System.EventHandler(this.toolBtnSettingMail_Click);
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
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.groupBoxLegend);
            this.splitContainer.Panel1.Controls.Add(this.checkedListBoxDivisionApply);
            this.splitContainer.Panel1.Controls.Add(this.checkBoxWhereSub);
            this.splitContainer.Panel1.Controls.Add(this.label4);
            this.splitContainer.Panel1.Controls.Add(this.toolStripTreeSchmObj);
            this.splitContainer.Panel1.Controls.Add(this.treeViewSchmObjects);
            this.splitContainer.Panel1.Controls.Add(this.checkedListBoxDivision);
            this.splitContainer.Panel1.Controls.Add(this.label3);
            this.splitContainer.Panel1.Controls.Add(this.dtpFilterEnd);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.dtpFilterBeg);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.toolStripFilter);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainerDgv);
            this.splitContainer.Size = new System.Drawing.Size(1276, 713);
            this.splitContainer.SplitterDistance = 258;
            this.splitContainer.TabIndex = 1;
            // 
            // groupBoxLegend
            // 
            this.groupBoxLegend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxLegend.Controls.Add(this.txtLegendNoSESNO);
            this.groupBoxLegend.Controls.Add(this.txtLegendUnExec);
            this.groupBoxLegend.Controls.Add(this.txtLegendOverdue);
            this.groupBoxLegend.Controls.Add(this.txtLegendInWork);
            this.groupBoxLegend.Controls.Add(this.txtLegendApply);
            this.groupBoxLegend.Location = new System.Drawing.Point(0, 559);
            this.groupBoxLegend.Name = "groupBoxLegend";
            this.groupBoxLegend.Size = new System.Drawing.Size(258, 151);
            this.groupBoxLegend.TabIndex = 16;
            this.groupBoxLegend.TabStop = false;
            this.groupBoxLegend.Text = "Легенда";
            // 
            // txtLegendNoSESNO
            // 
            this.txtLegendNoSESNO.BackColor = System.Drawing.Color.Orange;
            this.txtLegendNoSESNO.Location = new System.Drawing.Point(6, 123);
            this.txtLegendNoSESNO.Name = "txtLegendNoSESNO";
            this.txtLegendNoSESNO.ReadOnly = true;
            this.txtLegendNoSESNO.Size = new System.Drawing.Size(183, 20);
            this.txtLegendNoSESNO.TabIndex = 5;
            this.txtLegendNoSESNO.Text = "0 - нет сетей Горсвет";
            // 
            // txtLegendUnExec
            // 
            this.txtLegendUnExec.BackColor = System.Drawing.Color.LightPink;
            this.txtLegendUnExec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLegendUnExec.ForeColor = System.Drawing.Color.Red;
            this.txtLegendUnExec.Location = new System.Drawing.Point(6, 97);
            this.txtLegendUnExec.Name = "txtLegendUnExec";
            this.txtLegendUnExec.ReadOnly = true;
            this.txtLegendUnExec.Size = new System.Drawing.Size(183, 20);
            this.txtLegendUnExec.TabIndex = 4;
            this.txtLegendUnExec.Text = "0 - неоформлено";
            // 
            // txtLegendOverdue
            // 
            this.txtLegendOverdue.BackColor = System.Drawing.SystemColors.Window;
            this.txtLegendOverdue.ForeColor = System.Drawing.Color.Red;
            this.txtLegendOverdue.Location = new System.Drawing.Point(6, 71);
            this.txtLegendOverdue.Name = "txtLegendOverdue";
            this.txtLegendOverdue.ReadOnly = true;
            this.txtLegendOverdue.Size = new System.Drawing.Size(183, 20);
            this.txtLegendOverdue.TabIndex = 3;
            this.txtLegendOverdue.Text = "0 - просрочено";
            // 
            // txtLegendInWork
            // 
            this.txtLegendInWork.BackColor = System.Drawing.SystemColors.Window;
            this.txtLegendInWork.Location = new System.Drawing.Point(6, 45);
            this.txtLegendInWork.Name = "txtLegendInWork";
            this.txtLegendInWork.ReadOnly = true;
            this.txtLegendInWork.Size = new System.Drawing.Size(183, 20);
            this.txtLegendInWork.TabIndex = 2;
            this.txtLegendInWork.Text = "0 - в работе";
            // 
            // txtLegendApply
            // 
            this.txtLegendApply.BackColor = System.Drawing.SystemColors.Window;
            this.txtLegendApply.ForeColor = System.Drawing.Color.Green;
            this.txtLegendApply.Location = new System.Drawing.Point(6, 19);
            this.txtLegendApply.Name = "txtLegendApply";
            this.txtLegendApply.ReadOnly = true;
            this.txtLegendApply.Size = new System.Drawing.Size(183, 20);
            this.txtLegendApply.TabIndex = 0;
            this.txtLegendApply.Text = "0 - устранено";
            // 
            // checkedListBoxDivisionApply
            // 
            this.checkedListBoxDivisionApply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxDivisionApply.CheckOnClick = true;
            this.checkedListBoxDivisionApply.FormattingEnabled = true;
            this.checkedListBoxDivisionApply.Location = new System.Drawing.Point(12, 217);
            this.checkedListBoxDivisionApply.Name = "checkedListBoxDivisionApply";
            this.checkedListBoxDivisionApply.Size = new System.Drawing.Size(234, 94);
            this.checkedListBoxDivisionApply.TabIndex = 14;
            // 
            // checkBoxWhereSub
            // 
            this.checkBoxWhereSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxWhereSub.AutoSize = true;
            this.checkBoxWhereSub.Checked = true;
            this.checkBoxWhereSub.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWhereSub.Location = new System.Drawing.Point(12, 536);
            this.checkBoxWhereSub.Name = "checkBoxWhereSub";
            this.checkBoxWhereSub.Size = new System.Drawing.Size(180, 17);
            this.checkBoxWhereSub.TabIndex = 12;
            this.checkBoxWhereSub.Text = "Фильтровать по подстанциям";
            this.checkBoxWhereSub.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Подразделение-исполнитель";
            // 
            // toolStripTreeSchmObj
            // 
            this.toolStripTreeSchmObj.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripTreeSchmObj.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTreeSchmObj.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnFindTreeSchmObj,
            this.txtFindTreeSchmObj,
            this.toolBtnFindPrevTreeSchmObj,
            this.toolBtnFindNextTreeSchmObj});
            this.toolStripTreeSchmObj.Location = new System.Drawing.Point(15, 314);
            this.toolStripTreeSchmObj.Name = "toolStripTreeSchmObj";
            this.toolStripTreeSchmObj.Size = new System.Drawing.Size(174, 25);
            this.toolStripTreeSchmObj.TabIndex = 11;
            this.toolStripTreeSchmObj.Text = "toolStrip1";
            // 
            // toolBtnFindTreeSchmObj
            // 
            this.toolBtnFindTreeSchmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindTreeSchmObj.Image = global::DailyReportN.Properties.Resources.Find;
            this.toolBtnFindTreeSchmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindTreeSchmObj.Name = "toolBtnFindTreeSchmObj";
            this.toolBtnFindTreeSchmObj.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindTreeSchmObj.Text = "Искать";
            this.toolBtnFindTreeSchmObj.Click += new System.EventHandler(this.toolBtnFindTreeSchmObj_Click);
            // 
            // txtFindTreeSchmObj
            // 
            this.txtFindTreeSchmObj.Name = "txtFindTreeSchmObj";
            this.txtFindTreeSchmObj.Size = new System.Drawing.Size(100, 25);
            this.txtFindTreeSchmObj.ToolTipText = "Текст для поиска";
            this.txtFindTreeSchmObj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFindTreeSchmObj_KeyDown);
            // 
            // toolBtnFindPrevTreeSchmObj
            // 
            this.toolBtnFindPrevTreeSchmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindPrevTreeSchmObj.Image = global::DailyReportN.Properties.Resources.FindPrev;
            this.toolBtnFindPrevTreeSchmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindPrevTreeSchmObj.Name = "toolBtnFindPrevTreeSchmObj";
            this.toolBtnFindPrevTreeSchmObj.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindPrevTreeSchmObj.Text = "Искать назад";
            this.toolBtnFindPrevTreeSchmObj.Click += new System.EventHandler(this.toolBtnFindPrevTreeSchmObj_Click);
            // 
            // toolBtnFindNextTreeSchmObj
            // 
            this.toolBtnFindNextTreeSchmObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindNextTreeSchmObj.Image = global::DailyReportN.Properties.Resources.FindNext;
            this.toolBtnFindNextTreeSchmObj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnFindNextTreeSchmObj.Name = "toolBtnFindNextTreeSchmObj";
            this.toolBtnFindNextTreeSchmObj.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindNextTreeSchmObj.Text = "Искать вперед";
            this.toolBtnFindNextTreeSchmObj.Click += new System.EventHandler(this.toolBtnFindNextTreeSchmObj_Click);
            // 
            // treeViewSchmObjects
            // 
            this.treeViewSchmObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewSchmObjects.CheckBoxes = true;
            this.treeViewSchmObjects.Location = new System.Drawing.Point(12, 342);
            this.treeViewSchmObjects.Name = "treeViewSchmObjects";
            this.treeViewSchmObjects.Size = new System.Drawing.Size(234, 188);
            this.treeViewSchmObjects.SqlSettings = null;
            this.treeViewSchmObjects.TabIndex = 10;
            // 
            // checkedListBoxDivision
            // 
            this.checkedListBoxDivision.CheckOnClick = true;
            this.checkedListBoxDivision.FormattingEnabled = true;
            this.checkedListBoxDivision.Location = new System.Drawing.Point(12, 119);
            this.checkedListBoxDivision.Name = "checkedListBoxDivision";
            this.checkedListBoxDivision.Size = new System.Drawing.Size(234, 79);
            this.checkedListBoxDivision.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Подразделения";
            // 
            // dtpFilterEnd
            // 
            this.dtpFilterEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFilterEnd.CausesValidation = false;
            this.dtpFilterEnd.Location = new System.Drawing.Point(12, 80);
            this.dtpFilterEnd.Name = "dtpFilterEnd";
            this.dtpFilterEnd.Size = new System.Drawing.Size(234, 20);
            this.dtpFilterEnd.TabIndex = 4;
            this.dtpFilterEnd.ValueChanged += new System.EventHandler(this.dtpFilterEnd_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "До";
            // 
            // dtpFilterBeg
            // 
            this.dtpFilterBeg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFilterBeg.CausesValidation = false;
            this.dtpFilterBeg.Location = new System.Drawing.Point(12, 41);
            this.dtpFilterBeg.Name = "dtpFilterBeg";
            this.dtpFilterBeg.Size = new System.Drawing.Size(234, 20);
            this.dtpFilterBeg.TabIndex = 2;
            this.dtpFilterBeg.ValueChanged += new System.EventHandler(this.dtpFilterBeg_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "От";
            // 
            // toolStripFilter
            // 
            this.toolStripFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnFilterApply,
            this.toolBtnFilterDelete,
            this.toolStripSeparator4,
            this.toolBtnPrevYear,
            this.toolBtnNextYear});
            this.toolStripFilter.Location = new System.Drawing.Point(0, 0);
            this.toolStripFilter.Name = "toolStripFilter";
            this.toolStripFilter.Size = new System.Drawing.Size(258, 25);
            this.toolStripFilter.TabIndex = 0;
            this.toolStripFilter.Text = "toolStrip1";
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnPrevYear
            // 
            this.toolBtnPrevYear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnPrevYear.Image = global::DailyReportN.Properties.Resources.arrowPrev;
            this.toolBtnPrevYear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnPrevYear.Name = "toolBtnPrevYear";
            this.toolBtnPrevYear.Size = new System.Drawing.Size(23, 22);
            this.toolBtnPrevYear.Text = "Предыдущий год";
            this.toolBtnPrevYear.Click += new System.EventHandler(this.toolBtnPrevYear_Click);
            // 
            // toolBtnNextYear
            // 
            this.toolBtnNextYear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnNextYear.Image = global::DailyReportN.Properties.Resources.arrowNext;
            this.toolBtnNextYear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnNextYear.Name = "toolBtnNextYear";
            this.toolBtnNextYear.Size = new System.Drawing.Size(23, 22);
            this.toolBtnNextYear.Text = "Следующий год";
            this.toolBtnNextYear.Click += new System.EventHandler(this.toolBtnNextYear_Click);
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
            this.splitContainerDgv.Panel1.Controls.Add(this.dgvDamage);
            // 
            // splitContainerDgv.Panel2
            // 
            this.splitContainerDgv.Panel2.Controls.Add(this.dgvLinkDocs);
            this.splitContainerDgv.Panel2.Controls.Add(this.lbLinkDoc);
            this.splitContainerDgv.Panel2MinSize = 13;
            this.splitContainerDgv.Size = new System.Drawing.Size(1014, 713);
            this.splitContainerDgv.SplitterDistance = 555;
            this.splitContainerDgv.TabIndex = 1;
            // 
            // dgvDamage
            // 
            this.dgvDamage.AllowUserToAddRows = false;
            this.dgvDamage.AllowUserToDeleteRows = false;
            this.dgvDamage.AllowUserToOrderColumns = true;
            this.dgvDamage.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDamage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDamage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDamage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isLaboratoryDgvColumn,
            this.isApplyDgvColumn,
            this.numrequestDataGridViewTextBoxColumn,
            this.numDocDataGridViewTextBoxColumn,
            this.dateDocDgvColumn,
            this.typeDocNameDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.schmObjNameDataGridViewTextBoxColumn,
            this.netRegionSubDgvColumn,
            this.defectLocationDataGridViewTextBoxColumn,
            this.cityDgvColumn,
            this.streetDgvColumn,
            this.characterDgvColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.divisionApplyDataGridViewTextBoxColumn,
            this.dateApplyDgvColumn,
            this.datePlanEndDgvColumn,
            this.workerApplyDataGridViewTextBoxColumn,
            this.completedWorkDataGridViewTextBoxColumn,
            this.compilerDataGridViewTextBoxColumn,
            this.InstructionDgvColumn,
            this.nameOwnerDgvColumn,
            this.dateOwnerDgvColumn,
            this.comletedWorkTextDataGridViewTextBoxColumn,
            this.KodPTSDgvColumn,
            this.kodPTSStrDgvColumn,
            this.idParentDgvColumn,
            this.isNoSESNODgvColumn,
            this.is81DgvColumn,
            this.typeDocDgvColumn,
            this.idDataGridViewTextBoxColumn,
            this.idReasonDgvColumn,
            this.idReqForRepairDgvColumn,
            this.SendSiteMeDgvColumn,
            this.isSendSiteMeDgvColumn});
            this.dgvDamage.DataSource = this.bsDamage;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDamage.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDamage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDamage.Location = new System.Drawing.Point(0, 0);
            this.dgvDamage.Name = "dgvDamage";
            this.dgvDamage.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDamage.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDamage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDamage.Size = new System.Drawing.Size(1014, 555);
            this.dgvDamage.TabIndex = 0;
            this.dgvDamage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDamage_CellDoubleClick);
            this.dgvDamage.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDamage_CellFormatting);
            this.dgvDamage.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDamage_CellMouseClick);
            this.dgvDamage.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDamage_RowPostPaint);
            // 
            // isLaboratoryDgvColumn
            // 
            this.isLaboratoryDgvColumn.DataPropertyName = "isLaboratory";
            this.isLaboratoryDgvColumn.FalseValue = "Нет";
            this.isLaboratoryDgvColumn.HeaderText = "ПЛ";
            this.isLaboratoryDgvColumn.Name = "isLaboratoryDgvColumn";
            this.isLaboratoryDgvColumn.ReadOnly = true;
            this.isLaboratoryDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isLaboratoryDgvColumn.TrueValue = "Да";
            this.isLaboratoryDgvColumn.Visible = false;
            this.isLaboratoryDgvColumn.Width = 5;
            // 
            // isApplyDgvColumn
            // 
            this.isApplyDgvColumn.DataPropertyName = "isApply";
            this.isApplyDgvColumn.HeaderText = "Выполнено";
            this.isApplyDgvColumn.Name = "isApplyDgvColumn";
            this.isApplyDgvColumn.ReadOnly = true;
            this.isApplyDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isApplyDgvColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.isApplyDgvColumn.Visible = false;
            // 
            // numrequestDataGridViewTextBoxColumn
            // 
            this.numrequestDataGridViewTextBoxColumn.DataPropertyName = "numrequest";
            this.numrequestDataGridViewTextBoxColumn.HeaderText = "№ заявки";
            this.numrequestDataGridViewTextBoxColumn.Name = "numrequestDataGridViewTextBoxColumn";
            this.numrequestDataGridViewTextBoxColumn.ReadOnly = true;
            this.numrequestDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // numDocDataGridViewTextBoxColumn
            // 
            this.numDocDataGridViewTextBoxColumn.DataPropertyName = "numDoc";
            this.numDocDataGridViewTextBoxColumn.HeaderText = "№ документа";
            this.numDocDataGridViewTextBoxColumn.Name = "numDocDataGridViewTextBoxColumn";
            this.numDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDocDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numDocDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDocDgvColumn
            // 
            this.dateDocDgvColumn.DataPropertyName = "dateDoc";
            this.dateDocDgvColumn.HeaderText = "Дата заявки";
            this.dateDocDgvColumn.Name = "dateDocDgvColumn";
            this.dateDocDgvColumn.ReadOnly = true;
            this.dateDocDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeDocNameDataGridViewTextBoxColumn
            // 
            this.typeDocNameDataGridViewTextBoxColumn.DataPropertyName = "TypeDocName";
            this.typeDocNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDocNameDataGridViewTextBoxColumn.Name = "typeDocNameDataGridViewTextBoxColumn";
            this.typeDocNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDocNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            this.divisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.divisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // schmObjNameDataGridViewTextBoxColumn
            // 
            this.schmObjNameDataGridViewTextBoxColumn.DataPropertyName = "schmObjName";
            this.schmObjNameDataGridViewTextBoxColumn.HeaderText = "Электроустановка";
            this.schmObjNameDataGridViewTextBoxColumn.Name = "schmObjNameDataGridViewTextBoxColumn";
            this.schmObjNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.schmObjNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // netRegionSubDgvColumn
            // 
            this.netRegionSubDgvColumn.DataPropertyName = "NetRegionSub";
            this.netRegionSubDgvColumn.HeaderText = "Сетевой район";
            this.netRegionSubDgvColumn.Name = "netRegionSubDgvColumn";
            this.netRegionSubDgvColumn.ReadOnly = true;
            // 
            // defectLocationDataGridViewTextBoxColumn
            // 
            this.defectLocationDataGridViewTextBoxColumn.DataPropertyName = "defectLocation";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.defectLocationDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.defectLocationDataGridViewTextBoxColumn.HeaderText = "Место повреждения";
            this.defectLocationDataGridViewTextBoxColumn.Name = "defectLocationDataGridViewTextBoxColumn";
            this.defectLocationDataGridViewTextBoxColumn.ReadOnly = true;
            this.defectLocationDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cityDgvColumn
            // 
            this.cityDgvColumn.DataPropertyName = "City";
            this.cityDgvColumn.HeaderText = "Город";
            this.cityDgvColumn.Name = "cityDgvColumn";
            this.cityDgvColumn.ReadOnly = true;
            this.cityDgvColumn.Visible = false;
            // 
            // streetDgvColumn
            // 
            this.streetDgvColumn.DataPropertyName = "Street";
            this.streetDgvColumn.HeaderText = "Улица";
            this.streetDgvColumn.Name = "streetDgvColumn";
            this.streetDgvColumn.ReadOnly = true;
            this.streetDgvColumn.Visible = false;
            // 
            // characterDgvColumn
            // 
            this.characterDgvColumn.DataPropertyName = "Character";
            this.characterDgvColumn.HeaderText = "Характер повреждения";
            this.characterDgvColumn.Name = "characterDgvColumn";
            this.characterDgvColumn.ReadOnly = true;
            this.characterDgvColumn.Visible = false;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reasonDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Причина";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // divisionApplyDataGridViewTextBoxColumn
            // 
            this.divisionApplyDataGridViewTextBoxColumn.DataPropertyName = "DivisionApply";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.divisionApplyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.divisionApplyDataGridViewTextBoxColumn.FilteringEnabled = false;
            this.divisionApplyDataGridViewTextBoxColumn.HeaderText = "Подразделение исполнитель";
            this.divisionApplyDataGridViewTextBoxColumn.Name = "divisionApplyDataGridViewTextBoxColumn";
            this.divisionApplyDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionApplyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateApplyDgvColumn
            // 
            this.dateApplyDgvColumn.DataPropertyName = "dateApply";
            this.dateApplyDgvColumn.HeaderText = "Дата устранения";
            this.dateApplyDgvColumn.Name = "dateApplyDgvColumn";
            this.dateApplyDgvColumn.ReadOnly = true;
            this.dateApplyDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // datePlanEndDgvColumn
            // 
            this.datePlanEndDgvColumn.DataPropertyName = "datePlanEnd";
            this.datePlanEndDgvColumn.HeaderText = "План дата устранения";
            this.datePlanEndDgvColumn.Name = "datePlanEndDgvColumn";
            this.datePlanEndDgvColumn.ReadOnly = true;
            // 
            // workerApplyDataGridViewTextBoxColumn
            // 
            this.workerApplyDataGridViewTextBoxColumn.DataPropertyName = "workerApply";
            this.workerApplyDataGridViewTextBoxColumn.HeaderText = "Выполнил";
            this.workerApplyDataGridViewTextBoxColumn.Name = "workerApplyDataGridViewTextBoxColumn";
            this.workerApplyDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerApplyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // completedWorkDataGridViewTextBoxColumn
            // 
            this.completedWorkDataGridViewTextBoxColumn.DataPropertyName = "completedWork";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.completedWorkDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.completedWorkDataGridViewTextBoxColumn.HeaderText = "Выполненная работа";
            this.completedWorkDataGridViewTextBoxColumn.Name = "completedWorkDataGridViewTextBoxColumn";
            this.completedWorkDataGridViewTextBoxColumn.ReadOnly = true;
            this.completedWorkDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // compilerDataGridViewTextBoxColumn
            // 
            this.compilerDataGridViewTextBoxColumn.DataPropertyName = "compiler";
            this.compilerDataGridViewTextBoxColumn.HeaderText = "Составитель";
            this.compilerDataGridViewTextBoxColumn.Name = "compilerDataGridViewTextBoxColumn";
            this.compilerDataGridViewTextBoxColumn.ReadOnly = true;
            this.compilerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.compilerDataGridViewTextBoxColumn.Visible = false;
            // 
            // InstructionDgvColumn
            // 
            this.InstructionDgvColumn.DataPropertyName = "Instruction";
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.InstructionDgvColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.InstructionDgvColumn.HeaderText = "Указания";
            this.InstructionDgvColumn.Name = "InstructionDgvColumn";
            this.InstructionDgvColumn.ReadOnly = true;
            this.InstructionDgvColumn.Width = 120;
            // 
            // nameOwnerDgvColumn
            // 
            this.nameOwnerDgvColumn.DataPropertyName = "ownerName";
            this.nameOwnerDgvColumn.HeaderText = "Автор";
            this.nameOwnerDgvColumn.Name = "nameOwnerDgvColumn";
            this.nameOwnerDgvColumn.ReadOnly = true;
            this.nameOwnerDgvColumn.Visible = false;
            // 
            // dateOwnerDgvColumn
            // 
            this.dateOwnerDgvColumn.DataPropertyName = "dateOwner";
            this.dateOwnerDgvColumn.HeaderText = "Дата создания";
            this.dateOwnerDgvColumn.Name = "dateOwnerDgvColumn";
            this.dateOwnerDgvColumn.ReadOnly = true;
            this.dateOwnerDgvColumn.Visible = false;
            // 
            // comletedWorkTextDataGridViewTextBoxColumn
            // 
            this.comletedWorkTextDataGridViewTextBoxColumn.DataPropertyName = "ComletedWorkText";
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.comletedWorkTextDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.comletedWorkTextDataGridViewTextBoxColumn.HeaderText = "Выполненная работа текст";
            this.comletedWorkTextDataGridViewTextBoxColumn.Name = "comletedWorkTextDataGridViewTextBoxColumn";
            this.comletedWorkTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.comletedWorkTextDataGridViewTextBoxColumn.Visible = false;
            // 
            // KodPTSDgvColumn
            // 
            this.KodPTSDgvColumn.DataPropertyName = "KodPTS";
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = null;
            this.KodPTSDgvColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.KodPTSDgvColumn.HeaderText = "Код повреждения";
            this.KodPTSDgvColumn.Name = "KodPTSDgvColumn";
            this.KodPTSDgvColumn.ReadOnly = true;
            this.KodPTSDgvColumn.Visible = false;
            // 
            // kodPTSStrDgvColumn
            // 
            this.kodPTSStrDgvColumn.DataPropertyName = "KodPTSStr";
            this.kodPTSStrDgvColumn.HeaderText = "Код повреждения (стр)";
            this.kodPTSStrDgvColumn.Name = "kodPTSStrDgvColumn";
            this.kodPTSStrDgvColumn.ReadOnly = true;
            this.kodPTSStrDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // idParentDgvColumn
            // 
            this.idParentDgvColumn.DataPropertyName = "idParent";
            this.idParentDgvColumn.HeaderText = "Родитель";
            this.idParentDgvColumn.Name = "idParentDgvColumn";
            this.idParentDgvColumn.ReadOnly = true;
            this.idParentDgvColumn.Visible = false;
            // 
            // isNoSESNODgvColumn
            // 
            this.isNoSESNODgvColumn.DataPropertyName = "isNoSESNO";
            this.isNoSESNODgvColumn.HeaderText = "не горсвет";
            this.isNoSESNODgvColumn.Name = "isNoSESNODgvColumn";
            this.isNoSESNODgvColumn.ReadOnly = true;
            this.isNoSESNODgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isNoSESNODgvColumn.Visible = false;
            // 
            // is81DgvColumn
            // 
            this.is81DgvColumn.DataPropertyName = "is81";
            this.is81DgvColumn.HeaderText = "8.1";
            this.is81DgvColumn.Name = "is81DgvColumn";
            this.is81DgvColumn.ReadOnly = true;
            // 
            // typeDocDgvColumn
            // 
            this.typeDocDgvColumn.DataPropertyName = "TypeDoc";
            this.typeDocDgvColumn.HeaderText = "TypeDoc";
            this.typeDocDgvColumn.Name = "typeDocDgvColumn";
            this.typeDocDgvColumn.ReadOnly = true;
            this.typeDocDgvColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idReasonDgvColumn
            // 
            this.idReasonDgvColumn.DataPropertyName = "idReason";
            this.idReasonDgvColumn.HeaderText = "idReason";
            this.idReasonDgvColumn.Name = "idReasonDgvColumn";
            this.idReasonDgvColumn.ReadOnly = true;
            this.idReasonDgvColumn.Visible = false;
            // 
            // idReqForRepairDgvColumn
            // 
            this.idReqForRepairDgvColumn.DataPropertyName = "idReqForRepair";
            this.idReqForRepairDgvColumn.HeaderText = "idReqForRepair";
            this.idReqForRepairDgvColumn.Name = "idReqForRepairDgvColumn";
            this.idReqForRepairDgvColumn.ReadOnly = true;
            this.idReqForRepairDgvColumn.Visible = false;
            // 
            // SendSiteMeDgvColumn
            // 
            this.SendSiteMeDgvColumn.DataPropertyName = "SendSiteMe";
            this.SendSiteMeDgvColumn.HeaderText = "Статус отправки";
            this.SendSiteMeDgvColumn.Name = "SendSiteMeDgvColumn";
            this.SendSiteMeDgvColumn.ReadOnly = true;
            this.SendSiteMeDgvColumn.Visible = false;
            // 
            // isSendSiteMeDgvColumn
            // 
            this.isSendSiteMeDgvColumn.DataPropertyName = "isSendSiteMe";
            this.isSendSiteMeDgvColumn.HeaderText = "isSendSiteMe";
            this.isSendSiteMeDgvColumn.Name = "isSendSiteMeDgvColumn";
            this.isSendSiteMeDgvColumn.ReadOnly = true;
            this.isSendSiteMeDgvColumn.Visible = false;
            // 
            // bsDamage
            // 
            this.bsDamage.DataMember = "vJ_Damage";
            this.bsDamage.DataSource = this.dsDamageN;
            this.bsDamage.CurrentChanged += new System.EventHandler(this.bsDamage_CurrentChanged);
            this.bsDamage.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsDamage_ListChanged);
            // 
            // dsDamageN
            // 
            this.dsDamageN.DataSetName = "DataSetDamage";
            this.dsDamageN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvLinkDocs
            // 
            this.dgvLinkDocs.AllowUserToAddRows = false;
            this.dgvLinkDocs.AllowUserToDeleteRows = false;
            this.dgvLinkDocs.AllowUserToVisibleColumns = false;
            this.dgvLinkDocs.AutoGenerateColumns = false;
            this.dgvLinkDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinkDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDocDataGridViewTextBoxColumn1,
            this.dateDocDataGridViewTextBoxColumn,
            this.idLinkDocDgvColumn,
            this.typeDocDataGridViewTextBoxColumn,
            this.typeDocNameDataGridViewTextBoxColumn1,
            this.isParentDgvColumn});
            this.dgvLinkDocs.DataSource = this.bsLinkDocs;
            this.dgvLinkDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLinkDocs.Location = new System.Drawing.Point(0, 13);
            this.dgvLinkDocs.Name = "dgvLinkDocs";
            this.dgvLinkDocs.ReadOnly = true;
            this.dgvLinkDocs.Size = new System.Drawing.Size(1014, 141);
            this.dgvLinkDocs.TabIndex = 10;
            this.dgvLinkDocs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLinkDocs_CellFormatting);
            // 
            // numDocDataGridViewTextBoxColumn1
            // 
            this.numDocDataGridViewTextBoxColumn1.DataPropertyName = "numDoc";
            this.numDocDataGridViewTextBoxColumn1.HeaderText = "№ документа";
            this.numDocDataGridViewTextBoxColumn1.Name = "numDocDataGridViewTextBoxColumn1";
            this.numDocDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateDocDataGridViewTextBoxColumn
            // 
            this.dateDocDataGridViewTextBoxColumn.DataPropertyName = "dateDoc";
            this.dateDocDataGridViewTextBoxColumn.HeaderText = "Дата документа";
            this.dateDocDataGridViewTextBoxColumn.Name = "dateDocDataGridViewTextBoxColumn";
            this.dateDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDocDataGridViewTextBoxColumn.Width = 150;
            // 
            // idLinkDocDgvColumn
            // 
            this.idLinkDocDgvColumn.DataPropertyName = "id";
            this.idLinkDocDgvColumn.HeaderText = "id";
            this.idLinkDocDgvColumn.Name = "idLinkDocDgvColumn";
            this.idLinkDocDgvColumn.ReadOnly = true;
            this.idLinkDocDgvColumn.Visible = false;
            // 
            // typeDocDataGridViewTextBoxColumn
            // 
            this.typeDocDataGridViewTextBoxColumn.DataPropertyName = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn.HeaderText = "TypeDoc";
            this.typeDocDataGridViewTextBoxColumn.Name = "typeDocDataGridViewTextBoxColumn";
            this.typeDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDocDataGridViewTextBoxColumn.Visible = false;
            // 
            // typeDocNameDataGridViewTextBoxColumn1
            // 
            this.typeDocNameDataGridViewTextBoxColumn1.DataPropertyName = "TypeDocName";
            this.typeDocNameDataGridViewTextBoxColumn1.HeaderText = "Тип документа";
            this.typeDocNameDataGridViewTextBoxColumn1.Name = "typeDocNameDataGridViewTextBoxColumn1";
            this.typeDocNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.typeDocNameDataGridViewTextBoxColumn1.Width = 250;
            // 
            // isParentDgvColumn
            // 
            this.isParentDgvColumn.DataPropertyName = "isParent";
            this.isParentDgvColumn.HeaderText = "isParent";
            this.isParentDgvColumn.Name = "isParentDgvColumn";
            this.isParentDgvColumn.ReadOnly = true;
            this.isParentDgvColumn.Visible = false;
            // 
            // bsLinkDocs
            // 
            this.bsLinkDocs.DataMember = "dtLinkDocs";
            this.bsLinkDocs.DataSource = this.dsJournalLocalN;
            // 
            // dsJournalLocalN
            // 
            this.dsJournalLocalN.DataSetName = "NewDataSet";
            this.dsJournalLocalN.Tables.AddRange(new System.Data.DataTable[] {
            this.dtLinkDocs});
            // 
            // dtLinkDocs
            // 
            this.dtLinkDocs.Columns.AddRange(new System.Data.DataColumn[] {
            this.id,
            this.TypeDoc,
            this.TypeDocName,
            this.numDoc,
            this.dateDoc,
            this.idReqForRepair,
            this.isParent});
            this.dtLinkDocs.TableName = "dtLinkDocs";
            // 
            // id
            // 
            this.id.ColumnName = "id";
            this.id.DataType = typeof(int);
            // 
            // TypeDoc
            // 
            this.TypeDoc.ColumnName = "TypeDoc";
            this.TypeDoc.DataType = typeof(int);
            // 
            // TypeDocName
            // 
            this.TypeDocName.ColumnName = "TypeDocName";
            // 
            // numDoc
            // 
            this.numDoc.ColumnName = "numDoc";
            // 
            // dateDoc
            // 
            this.dateDoc.ColumnName = "dateDoc";
            this.dateDoc.DataType = typeof(System.DateTime);
            // 
            // idReqForRepair
            // 
            this.idReqForRepair.ColumnName = "idReqForRepair";
            this.idReqForRepair.DataType = typeof(int);
            // 
            // isParent
            // 
            this.isParent.ColumnName = "isParent";
            this.isParent.DataType = typeof(bool);
            // 
            // lbLinkDoc
            // 
            this.lbLinkDoc.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.lbLinkDoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLinkDoc.Location = new System.Drawing.Point(0, 0);
            this.lbLinkDoc.Name = "lbLinkDoc";
            this.lbLinkDoc.Size = new System.Drawing.Size(1014, 13);
            this.lbLinkDoc.TabIndex = 9;
            this.lbLinkDoc.Text = "Связанные документы";
            this.lbLinkDoc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbLinkDoc.Click += new System.EventHandler(this.lbLinkDoc_Click);
            // 
            // contextMenuDamage
            // 
            this.contextMenuDamage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolItemAdd,
            this.toolItemEdit,
            this.toolItemInfo,
            this.toolItemDel,
            this.toolStripSeparator5,
            this.toolItemActDetection});
            this.contextMenuDamage.Name = "contextMenuDamage";
            this.contextMenuDamage.Size = new System.Drawing.Size(180, 120);
            this.contextMenuDamage.Opening += new System.ComponentModel.CancelEventHandler(this.ccontextMenuDamage_Opening);
            // 
            // toolItemAdd
            // 
            this.toolItemAdd.Image = global::DailyReportN.Properties.Resources.Add;
            this.toolItemAdd.Name = "toolItemAdd";
            this.toolItemAdd.Size = new System.Drawing.Size(179, 22);
            this.toolItemAdd.Text = "Добавить";
            // 
            // toolItemEdit
            // 
            this.toolItemEdit.Image = global::DailyReportN.Properties.Resources.Edit;
            this.toolItemEdit.Name = "toolItemEdit";
            this.toolItemEdit.Size = new System.Drawing.Size(179, 22);
            this.toolItemEdit.Text = "Изменить";
            this.toolItemEdit.Click += new System.EventHandler(this.toolBtnEdit_Click);
            // 
            // toolItemInfo
            // 
            this.toolItemInfo.Image = global::DailyReportN.Properties.Resources.ElementInformation;
            this.toolItemInfo.Name = "toolItemInfo";
            this.toolItemInfo.Size = new System.Drawing.Size(179, 22);
            this.toolItemInfo.Text = "Просмотр";
            this.toolItemInfo.Click += new System.EventHandler(this.toolBtnInfo_Click);
            // 
            // toolItemDel
            // 
            this.toolItemDel.Image = global::DailyReportN.Properties.Resources.Delete;
            this.toolItemDel.Name = "toolItemDel";
            this.toolItemDel.Size = new System.Drawing.Size(179, 22);
            this.toolItemDel.Text = "Удалить";
            this.toolItemDel.Click += new System.EventHandler(this.toolBtnDel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(176, 6);
            // 
            // toolItemActDetection
            // 
            this.toolItemActDetection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolItemActDetectionAdd,
            this.toolStripSeparator6});
            this.toolItemActDetection.Name = "toolItemActDetection";
            this.toolItemActDetection.Size = new System.Drawing.Size(179, 22);
            this.toolItemActDetection.Text = "Акт расследования";
            // 
            // toolItemActDetectionAdd
            // 
            this.toolItemActDetectionAdd.Name = "toolItemActDetectionAdd";
            this.toolItemActDetectionAdd.Size = new System.Drawing.Size(117, 22);
            this.toolItemActDetectionAdd.Text = "Создать";
            this.toolItemActDetectionAdd.Click += new System.EventHandler(this.toolItemActDetectionAdd_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(114, 6);
            // 
            // dataGridViewFilterTextBoxColumn1
            // 
            this.dataGridViewFilterTextBoxColumn1.DataPropertyName = "numrequest";
            this.dataGridViewFilterTextBoxColumn1.HeaderText = "№ заявки";
            this.dataGridViewFilterTextBoxColumn1.Name = "dataGridViewFilterTextBoxColumn1";
            this.dataGridViewFilterTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn2
            // 
            this.dataGridViewFilterTextBoxColumn2.DataPropertyName = "numDoc";
            this.dataGridViewFilterTextBoxColumn2.HeaderText = "№ документа";
            this.dataGridViewFilterTextBoxColumn2.Name = "dataGridViewFilterTextBoxColumn2";
            this.dataGridViewFilterTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn2.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn3
            // 
            this.dataGridViewFilterTextBoxColumn3.DataPropertyName = "dateDoc";
            this.dataGridViewFilterTextBoxColumn3.HeaderText = "Дата заявки";
            this.dataGridViewFilterTextBoxColumn3.Name = "dataGridViewFilterTextBoxColumn3";
            this.dataGridViewFilterTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn4
            // 
            this.dataGridViewFilterTextBoxColumn4.DataPropertyName = "TypeDocName";
            this.dataGridViewFilterTextBoxColumn4.HeaderText = "Тип";
            this.dataGridViewFilterTextBoxColumn4.Name = "dataGridViewFilterTextBoxColumn4";
            this.dataGridViewFilterTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn5
            // 
            this.dataGridViewFilterTextBoxColumn5.DataPropertyName = "Division";
            this.dataGridViewFilterTextBoxColumn5.HeaderText = "Подразделение";
            this.dataGridViewFilterTextBoxColumn5.Name = "dataGridViewFilterTextBoxColumn5";
            this.dataGridViewFilterTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn5.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn6
            // 
            this.dataGridViewFilterTextBoxColumn6.DataPropertyName = "schmObjName";
            this.dataGridViewFilterTextBoxColumn6.HeaderText = "Электроустановка";
            this.dataGridViewFilterTextBoxColumn6.Name = "dataGridViewFilterTextBoxColumn6";
            this.dataGridViewFilterTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn7
            // 
            this.dataGridViewFilterTextBoxColumn7.DataPropertyName = "NetRegionSub";
            this.dataGridViewFilterTextBoxColumn7.HeaderText = "Сетевой район";
            this.dataGridViewFilterTextBoxColumn7.Name = "dataGridViewFilterTextBoxColumn7";
            // 
            // dataGridViewFilterTextBoxColumn8
            // 
            this.dataGridViewFilterTextBoxColumn8.DataPropertyName = "defectLocation";
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewFilterTextBoxColumn8.HeaderText = "Место повреждения";
            this.dataGridViewFilterTextBoxColumn8.Name = "dataGridViewFilterTextBoxColumn8";
            this.dataGridViewFilterTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn9
            // 
            this.dataGridViewFilterTextBoxColumn9.DataPropertyName = "Reason";
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewFilterTextBoxColumn9.HeaderText = "Причина";
            this.dataGridViewFilterTextBoxColumn9.Name = "dataGridViewFilterTextBoxColumn9";
            this.dataGridViewFilterTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn10
            // 
            this.dataGridViewFilterTextBoxColumn10.DataPropertyName = "DivisionApply";
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewFilterTextBoxColumn10.HeaderText = "Подразделение исполнитель";
            this.dataGridViewFilterTextBoxColumn10.Name = "dataGridViewFilterTextBoxColumn10";
            this.dataGridViewFilterTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn11
            // 
            this.dataGridViewFilterTextBoxColumn11.DataPropertyName = "dateApply";
            this.dataGridViewFilterTextBoxColumn11.HeaderText = "Дата устранения";
            this.dataGridViewFilterTextBoxColumn11.Name = "dataGridViewFilterTextBoxColumn11";
            this.dataGridViewFilterTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn12
            // 
            this.dataGridViewFilterTextBoxColumn12.DataPropertyName = "workerApply";
            this.dataGridViewFilterTextBoxColumn12.HeaderText = "Выполнил";
            this.dataGridViewFilterTextBoxColumn12.Name = "dataGridViewFilterTextBoxColumn12";
            this.dataGridViewFilterTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn13
            // 
            this.dataGridViewFilterTextBoxColumn13.DataPropertyName = "completedWork";
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewFilterTextBoxColumn13.HeaderText = "Выполненная работа";
            this.dataGridViewFilterTextBoxColumn13.Name = "dataGridViewFilterTextBoxColumn13";
            this.dataGridViewFilterTextBoxColumn13.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewFilterTextBoxColumn14
            // 
            this.dataGridViewFilterTextBoxColumn14.DataPropertyName = "compiler";
            this.dataGridViewFilterTextBoxColumn14.HeaderText = "Составитель";
            this.dataGridViewFilterTextBoxColumn14.Name = "dataGridViewFilterTextBoxColumn14";
            this.dataGridViewFilterTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn14.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn15
            // 
            this.dataGridViewFilterTextBoxColumn15.DataPropertyName = "Instruction";
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFilterTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewFilterTextBoxColumn15.HeaderText = "Указания";
            this.dataGridViewFilterTextBoxColumn15.Name = "dataGridViewFilterTextBoxColumn15";
            this.dataGridViewFilterTextBoxColumn15.Width = 120;
            // 
            // dataGridViewFilterTextBoxColumn16
            // 
            this.dataGridViewFilterTextBoxColumn16.DataPropertyName = "ownerName";
            this.dataGridViewFilterTextBoxColumn16.HeaderText = "Автор";
            this.dataGridViewFilterTextBoxColumn16.Name = "dataGridViewFilterTextBoxColumn16";
            this.dataGridViewFilterTextBoxColumn16.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn17
            // 
            this.dataGridViewFilterTextBoxColumn17.DataPropertyName = "dateOwner";
            this.dataGridViewFilterTextBoxColumn17.HeaderText = "Дата создания";
            this.dataGridViewFilterTextBoxColumn17.Name = "dataGridViewFilterTextBoxColumn17";
            this.dataGridViewFilterTextBoxColumn17.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ComletedWorkText";
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn1.HeaderText = "Выполненная работа текст";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn18
            // 
            this.dataGridViewFilterTextBoxColumn18.DataPropertyName = "KodPTS";
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = null;
            this.dataGridViewFilterTextBoxColumn18.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewFilterTextBoxColumn18.HeaderText = "Код повреждения";
            this.dataGridViewFilterTextBoxColumn18.Name = "dataGridViewFilterTextBoxColumn18";
            this.dataGridViewFilterTextBoxColumn18.Visible = false;
            // 
            // dataGridViewFilterTextBoxColumn19
            // 
            this.dataGridViewFilterTextBoxColumn19.DataPropertyName = "KodPTSStr";
            this.dataGridViewFilterTextBoxColumn19.HeaderText = "Код повреждения (стр)";
            this.dataGridViewFilterTextBoxColumn19.Name = "dataGridViewFilterTextBoxColumn19";
            this.dataGridViewFilterTextBoxColumn19.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idParent";
            this.dataGridViewTextBoxColumn2.HeaderText = "Родитель";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn3.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "idReason";
            this.dataGridViewTextBoxColumn5.HeaderText = "idReason";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "idReqForRepair";
            this.dataGridViewTextBoxColumn6.HeaderText = "idReqForRepair";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // FormJournalDamage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 738);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormJournalDamage";
            this.Text = "Журнал технологических нарушений (N2)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJournalDamage_FormClosed);
            this.Load += new System.EventHandler(this.FormJournalDamage_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.groupBoxLegend.ResumeLayout(false);
            this.groupBoxLegend.PerformLayout();
            this.toolStripTreeSchmObj.ResumeLayout(false);
            this.toolStripTreeSchmObj.PerformLayout();
            this.toolStripFilter.ResumeLayout(false);
            this.toolStripFilter.PerformLayout();
            this.splitContainerDgv.Panel1.ResumeLayout(false);
            this.splitContainerDgv.Panel2.ResumeLayout(false);
            this.splitContainerDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDamageN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLinkDocs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsJournalLocalN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtLinkDocs)).EndInit();
            this.contextMenuDamage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private ToolStrip toolStrip;

        private SplitContainer splitContainer;

        private CheckedListBox checkedListBoxDivision;

        private Label label3;

        private DateTimePicker dtpFilterEnd;

        private Label label2;

        private DateTimePicker dtpFilterBeg;

        private Label label1;

        private ToolStrip toolStripFilter;

        private ToolStripButton toolBtnFilterApply;

        private ToolStripButton toolBtnFilterDelete;

        private ToolStripButton toolBtnPrevYear;

        private ToolStripButton toolBtnNextYear;

        private ToolStripDropDownButton toolBtnAdd;

        private ToolStripButton toolBtnEdit;

        private DataGridViewExcelFilter dgvDamage;

        private BindingSource bsDamage;

        // private Class171 class171_0;
        private DailyReportN.DataSet.dsDamage dsDamageN;
        //private dsDamage dsDamageN;

        private ToolStripButton toolBtnInfo;

        private TreeViewSchmObjects treeViewSchmObjects;

        private ToolStrip toolStripTreeSchmObj;

        private ToolStripButton toolBtnFindTreeSchmObj;

        private ToolStripTextBox txtFindTreeSchmObj;

        private ToolStripButton toolBtnFindPrevTreeSchmObj;

        private ToolStripButton toolBtnFindNextTreeSchmObj;

        private CheckBox checkBoxWhereSub;

        private ToolStripButton toolBtnDel;

        private ToolStripSeparator toolStripSeparator1;

        private ToolStripButton toolBtnRefresh;

        private ToolStripSeparator toolStripSeparator_1;

        private ToolStripButton toolBtnFind;

        private ToolStripTextBox txtFind;

        private ToolStripButton toolBtnFindPrev;

        private ToolStripButton toolBtnFindNext;

        private ToolStripSeparator toolStripSeparator3;

        private ToolStripDropDownButton toolBtnReport;

        private ToolStripMenuItem toolMenuItemReportDailyLV;

        private ToolStripSeparator toolStripSeparator4;

        private ToolStripDropDownButton toolBTnLoadOld;

        private ToolStripMenuItem toolBtnLoadOldDamageLV;

        private ToolStripMenuItem toolMenuItemSheetInterruptLV;

        private ToolStripMenuItem toolMenuItemReportDailyDefect;

        private ToolStripMenuItem toolBtnLoadOldDefect;

        private ToolStripButton toolBtnDamageNoApply;

        private ToolStripButton toolBtnExportExcel;

        private ToolStripButton toolBtnPrint;

        private ToolStripMenuItem toolMenuItemReportDailyHV;

        private ToolStripMenuItem toolBtnLoadAbnDefectLV;

        private ToolStripMenuItem toolBtnLoadOldDamageНV;

        private ContextMenuStrip contextMenuDamage;

        private ToolStripMenuItem toolItemAdd;

        private ToolStripMenuItem toolItemEdit;

        private ToolStripMenuItem toolItemInfo;

        private ToolStripMenuItem toolItemDel;

        private ToolStripSeparator toolStripSeparator5;

        private ToolStripMenuItem toolItemActDetection;

        private ToolStripMenuItem toolItemActDetectionAdd;

        private ToolStripSeparator toolStripSeparator6;

        private SplitContainer splitContainerDgv;

        private Label lbLinkDoc;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn1;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn2;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn3;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn4;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn5;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn6;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn7;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn8;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn9;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn10;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn11;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn12;

        //private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn_12;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn14;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn15;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn16;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn17;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn18;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn19;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

        private DataGridViewExcelFilter dgvLinkDocs;

        private BindingSource bsLinkDocs;

        private System.Data.DataSet dsJournalLocalN;

        private DataTable dtLinkDocs;

        private DataColumn id;

        private DataColumn TypeDoc;

        private DataColumn TypeDocName;

        private DataColumn numDoc;

        private DataColumn dateDoc;

        private DataColumn idReqForRepair;

        private DataColumn isParent;

        private DataGridViewTextBoxColumn numDocDataGridViewTextBoxColumn1;

        private DataGridViewTextBoxColumn dateDocDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn idLinkDocDgvColumn;

        private DataGridViewTextBoxColumn typeDocDataGridViewTextBoxColumn;

        private DataGridViewTextBoxColumn typeDocNameDataGridViewTextBoxColumn1;

        private DataGridViewCheckBoxColumn isParentDgvColumn;

        private CheckedListBox checkedListBoxDivisionApply;

        private Label label4;

        private ToolStripMenuItem tsMenuAmergencyShutdown;

        private DataGridViewFilterTextBoxColumn dataGridViewFilterTextBoxColumn13;

        private GroupBox groupBoxLegend;

        private TextBox txtLegendApply;

        private TextBox txtLegendNoSESNO;

        private TextBox txtLegendUnExec;

        private TextBox txtLegendOverdue;

        private TextBox txtLegendInWork;

        private ToolStripMenuItem toolBtnLoadOldDamageLVMySQL;

        private ToolStripButton toolBtnSettingMail;

        private ToolStripProgressBar progressBar;

        private BackgroundWorker backgroundWorker;

        private DataGridViewFilterTextBoxColumn cityDgvColumn;

        private DataGridViewFilterTextBoxColumn streetDgvColumn;

        private DataGridViewFilterTextBoxColumn characterDgvColumn;

        //private DataGridViewFilterCheckBoxColumn is81DgvColumn;

        private ToolStripMenuItem damageHVToDamageMainToolStripMenuItem;

        private ToolStripMenuItem damageLVToDamageMainToolStripMenuItem;

        private ToolStripMenuItem toolMenuItemReport81;
        private DataGridViewFilterCheckBoxColumn isLaboratoryDgvColumn;
        private DataGridViewFilterCheckBoxColumn is81DgvColumn;
        private DataGridViewFilterCheckBoxColumn isApplyDgvColumn;
        private DataGridViewFilterTextBoxColumn numrequestDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn numDocDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateDocDgvColumn;
        private DataGridViewFilterTextBoxColumn typeDocNameDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn divisionDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn schmObjNameDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn netRegionSubDgvColumn;
        private DataGridViewFilterTextBoxColumn defectLocationDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn reasonDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn divisionApplyDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateApplyDgvColumn;
        private DataGridViewFilterTextBoxColumn datePlanEndDgvColumn;
        private DataGridViewFilterTextBoxColumn workerApplyDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn completedWorkDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn compilerDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn InstructionDgvColumn;
        private DataGridViewFilterTextBoxColumn nameOwnerDgvColumn;
        private DataGridViewFilterTextBoxColumn dateOwnerDgvColumn;
        private DataGridViewTextBoxColumn comletedWorkTextDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn KodPTSDgvColumn;
        private DataGridViewFilterTextBoxColumn kodPTSStrDgvColumn;
        private DataGridViewTextBoxColumn idParentDgvColumn;
        private DataGridViewFilterCheckBoxColumn isNoSESNODgvColumn;
        private DataGridViewTextBoxColumn typeDocDgvColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idReasonDgvColumn;
        private DataGridViewTextBoxColumn idReqForRepairDgvColumn;
        private DataGridViewTextBoxColumn isSendSiteMeDgvColumn;
        private DataGridViewFilterTextBoxColumn SendSiteMeDgvColumn;
        private ToolStripButton toolBtnUnLockSend;
        private ToolStripMenuItem отчетРуководителюToolStripMenuItem;
    }
}
