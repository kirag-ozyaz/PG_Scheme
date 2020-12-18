
using ControlsLbr.DataGridViewExcelFilter;
using ControlsLbr.Scheme;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace DailyReportN.JournalActDetection
{
    public partial class FormJournalActDetection : FormLbr.FormBase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolBtnInfo = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnFind = new System.Windows.Forms.ToolStripButton();
            this.txtFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnReport = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsMenuAmergencyShutdown = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMenuReportAccidents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBTnLoadOld = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolBtnLoadOldDamageLV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnLoadOldDefect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnLoadAbnDefectLV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnLoadOldDamageНV = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnDamageNoApply = new System.Windows.Forms.ToolStripButton();
            this.toolBtnExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolBtnPrint = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.checkBoxWhereSub = new System.Windows.Forms.CheckBox();
            this.toolStripTreeSchmObj = new System.Windows.Forms.ToolStrip();
            this.toolBtnFindTreeSchmObj = new System.Windows.Forms.ToolStripButton();
            this.txtFindTreeSchmObj = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindPrevTreeSchmObj = new System.Windows.Forms.ToolStripButton();
            this.toolBtnFindNextTreeSchmObj = new System.Windows.Forms.ToolStripButton();
            this.treeViewSchmObjects = new ControlsLbr.Scheme.TreeViewSchmObjects();
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
            this.dgvActDetection = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bsDamage = new System.Windows.Forms.BindingSource(this.components);
            this.dsDamage = new DailyReportN.DataSet.dsDamage();
            this.toolItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDamage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.numrequestDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.numDocDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateDocDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeDocNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.schmObjNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.netRegionSubDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.numcrashDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.defectLocationDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.divisionApplyDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.isLaboratoryDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.dateApplyDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.isApplyDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.workerApplyDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.completedWorkDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.compilerDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.InstructionDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameOwnerDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateOwnerDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.comletedWorkTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodPTSDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.kodPTSStrDgvColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.signCrashTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signCrashNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeEquipColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeEquipNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idParentDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonCrashEquipTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonCrashEquipNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonCrashTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonCrashNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDocDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VoltageDgvColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStripTreeSchmObj.SuspendLayout();
            this.toolStripFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActDetection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDamage)).BeginInit();
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
            this.toolStripSeparator2,
            this.toolBtnFind,
            this.txtFind,
            this.toolBtnFindPrev,
            this.toolBtnFindNext,
            this.toolStripSeparator3,
            this.toolBtnReport,
            this.toolBTnLoadOld,
            this.toolBtnDamageNoApply,
            this.toolBtnExportExcel,
            this.toolBtnPrint});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1022, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolBtnAdd
            // 
            this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAdd.Image = global::DailyReportN.Properties.Resources.Add;
            this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAdd.Text = "Добавить";
            this.toolBtnAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.tsMenuAmergencyShutdown,
            this.tsMenuReportAccidents});
            this.toolBtnReport.Image = global::DailyReportN.Properties.Resources.Report;
            this.toolBtnReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReport.Name = "toolBtnReport";
            this.toolBtnReport.Size = new System.Drawing.Size(29, 22);
            this.toolBtnReport.Text = "Отчеты";
            // 
            // tsMenuAmergencyShutdown
            // 
            this.tsMenuAmergencyShutdown.Name = "tsMenuAmergencyShutdown";
            this.tsMenuAmergencyShutdown.Size = new System.Drawing.Size(270, 22);
            this.tsMenuAmergencyShutdown.Text = "Бюллетень аварийных отключений";
            this.tsMenuAmergencyShutdown.Click += new System.EventHandler(this.tsMenuAmergencyShutdown_Click);
            // 
            // tsMenuReportAccidents
            // 
            this.tsMenuReportAccidents.Name = "tsMenuReportAccidents";
            this.tsMenuReportAccidents.Size = new System.Drawing.Size(270, 22);
            this.tsMenuReportAccidents.Text = "Перечень аварий";
            this.tsMenuReportAccidents.Click += new System.EventHandler(this.tsMenuReportAccidents_Click);
            // 
            // toolBTnLoadOld
            // 
            this.toolBTnLoadOld.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBTnLoadOld.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBTnLoadOld.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnLoadOldDamageLV,
            this.toolBtnLoadOldDefect,
            this.toolBtnLoadAbnDefectLV,
            this.toolBtnLoadOldDamageНV});
            this.toolBTnLoadOld.Image = global::DailyReportN.Properties.Resources.Load;
            this.toolBTnLoadOld.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBTnLoadOld.Name = "toolBTnLoadOld";
            this.toolBTnLoadOld.Size = new System.Drawing.Size(29, 22);
            this.toolBTnLoadOld.Text = "Загрузка из старой базы";
            // 
            // toolBtnLoadOldDamageLV
            // 
            this.toolBtnLoadOldDamageLV.Name = "toolBtnLoadOldDamageLV";
            this.toolBtnLoadOldDamageLV.Size = new System.Drawing.Size(210, 22);
            this.toolBtnLoadOldDamageLV.Text = "0.4кВ";
            this.toolBtnLoadOldDamageLV.Click += new System.EventHandler(this.toolBtnLoadOldDamageLV_Click);
            // 
            // toolBtnLoadOldDefect
            // 
            this.toolBtnLoadOldDefect.Name = "toolBtnLoadOldDefect";
            this.toolBtnLoadOldDefect.Size = new System.Drawing.Size(210, 22);
            this.toolBtnLoadOldDefect.Text = "Дефект";
            this.toolBtnLoadOldDefect.Click += new System.EventHandler(this.toolBtnLoadOldDefect_Click);
            // 
            // toolBtnLoadAbnDefectLV
            // 
            this.toolBtnLoadAbnDefectLV.Name = "toolBtnLoadAbnDefectLV";
            this.toolBtnLoadAbnDefectLV.Size = new System.Drawing.Size(210, 22);
            this.toolBtnLoadAbnDefectLV.Text = "Загрузить абонентов НН";
            this.toolBtnLoadAbnDefectLV.Click += new System.EventHandler(this.toolBtnLoadAbnDefectLV_Click);
            // 
            // toolBtnLoadOldDamageНV
            // 
            this.toolBtnLoadOldDamageНV.Name = "toolBtnLoadOldDamageНV";
            this.toolBtnLoadOldDamageНV.Size = new System.Drawing.Size(210, 22);
            this.toolBtnLoadOldDamageНV.Text = "ВН";
            this.toolBtnLoadOldDamageНV.Click += new System.EventHandler(this.toolBtnLoadOldDamageНV_Click);
            // 
            // toolBtnDamageNoApply
            // 
            this.toolBtnDamageNoApply.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBtnDamageNoApply.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDamageNoApply.Image = global::DailyReportN.Properties.Resources.ElementAccept;
            this.toolBtnDamageNoApply.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDamageNoApply.Name = "toolBtnDamageNoApply";
            this.toolBtnDamageNoApply.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDamageNoApply.Text = "Разблокировать документ";
            this.toolBtnDamageNoApply.Visible = false;
            this.toolBtnDamageNoApply.Click += new System.EventHandler(this.toolBtnDamageNoApply_Click);
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
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.checkBoxWhereSub);
            this.splitContainer.Panel1.Controls.Add(this.toolStripTreeSchmObj);
            this.splitContainer.Panel1.Controls.Add(this.treeViewSchmObjects);
            this.splitContainer.Panel1.Controls.Add(this.dtpFilterEnd);
            this.splitContainer.Panel1.Controls.Add(this.label2);
            this.splitContainer.Panel1.Controls.Add(this.dtpFilterBeg);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.Controls.Add(this.toolStripFilter);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dgvActDetection);
            this.splitContainer.Size = new System.Drawing.Size(1022, 577);
            this.splitContainer.SplitterDistance = 258;
            this.splitContainer.TabIndex = 1;
            // 
            // checkBoxWhereSub
            // 
            this.checkBoxWhereSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxWhereSub.AutoSize = true;
            this.checkBoxWhereSub.Checked = true;
            this.checkBoxWhereSub.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWhereSub.Location = new System.Drawing.Point(15, 555);
            this.checkBoxWhereSub.Name = "checkBoxWhereSub";
            this.checkBoxWhereSub.Size = new System.Drawing.Size(180, 17);
            this.checkBoxWhereSub.TabIndex = 12;
            this.checkBoxWhereSub.Text = "Фильтровать по подстанциям";
            this.checkBoxWhereSub.UseVisualStyleBackColor = true;
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
            this.toolStripTreeSchmObj.Location = new System.Drawing.Point(15, 103);
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
            this.treeViewSchmObjects.Location = new System.Drawing.Point(12, 126);
            this.treeViewSchmObjects.Name = "treeViewSchmObjects";
            this.treeViewSchmObjects.Size = new System.Drawing.Size(234, 423);
            this.treeViewSchmObjects.SqlSettings = null;
            this.treeViewSchmObjects.TabIndex = 10;
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
            // dgvActDetection
            // 
            this.dgvActDetection.AllowUserToAddRows = false;
            this.dgvActDetection.AllowUserToDeleteRows = false;
            this.dgvActDetection.AllowUserToOrderColumns = true;
            this.dgvActDetection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActDetection.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActDetection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActDetection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActDetection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numrequestDataGridViewTextBoxColumn,
            this.numDocDataGridViewTextBoxColumn,
            this.dateDocDgvColumn,
            this.typeDocNameDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.schmObjNameDataGridViewTextBoxColumn,
            this.netRegionSubDgvColumn,
            this.numcrashDgvColumn,
            this.defectLocationDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.divisionApplyDataGridViewTextBoxColumn,
            this.isLaboratoryDgvColumn,
            this.dateApplyDgvColumn,
            this.isApplyDgvColumn,
            this.workerApplyDataGridViewTextBoxColumn,
            this.completedWorkDataGridViewTextBoxColumn,
            this.compilerDataGridViewTextBoxColumn,
            this.InstructionDgvColumn,
            this.nameOwnerDgvColumn,
            this.dateOwnerDgvColumn,
            this.comletedWorkTextDataGridViewTextBoxColumn,
            this.KodPTSDgvColumn,
            this.kodPTSStrDgvColumn,
            this.signCrashTypeColumn,
            this.signCrashNameColumn,
            this.typeEquipColumn,
            this.typeEquipNameColumn,
            this.idParentDgvColumn,
            this.reasonCrashEquipTypeColumn,
            this.reasonCrashEquipNameColumn,
            this.reasonCrashTypeColumn,
            this.reasonCrashNameColumn,
            this.typeDocDgvColumn,
            this.idDataGridViewTextBoxColumn,
            this.VoltageDgvColumn});
            this.dgvActDetection.DataSource = this.bsDamage;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActDetection.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvActDetection.Location = new System.Drawing.Point(0, 0);
            this.dgvActDetection.Name = "dgvActDetection";
            this.dgvActDetection.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActDetection.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvActDetection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActDetection.Size = new System.Drawing.Size(760, 577);
            this.dgvActDetection.TabIndex = 0;
            this.dgvActDetection.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActDetection_CellDoubleClick);
            this.dgvActDetection.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvActDetection_CellFormatting);
            this.dgvActDetection.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvActDetection_CellMouseClick);
            this.dgvActDetection.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvActDetection_RowPostPaint);
            // 
            // bsDamage
            // 
            this.bsDamage.DataMember = "vJ_Damage";
            this.bsDamage.DataSource = this.dsDamage;
            // 
            // dsDamage
            // 
            this.dsDamage.DataSetName = "DataSetDamage";
            this.dsDamage.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolItemAdd
            // 
            this.toolItemAdd.Image = global::DailyReportN.Properties.Resources.Add;
            this.toolItemAdd.Name = "toolItemAdd";
            this.toolItemAdd.Size = new System.Drawing.Size(135, 26);
            this.toolItemAdd.Text = "Добавить";
            this.toolItemAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
            // 
            // toolItemEdit
            // 
            this.toolItemEdit.Image = global::DailyReportN.Properties.Resources.Edit;
            this.toolItemEdit.Name = "toolItemEdit";
            this.toolItemEdit.Size = new System.Drawing.Size(135, 26);
            this.toolItemEdit.Text = "Изменить";
            this.toolItemEdit.Click += new System.EventHandler(this.toolBtnEdit_Click);
            // 
            // toolItemInfo
            // 
            this.toolItemInfo.Image = global::DailyReportN.Properties.Resources.ElementInformation;
            this.toolItemInfo.Name = "toolItemInfo";
            this.toolItemInfo.Size = new System.Drawing.Size(135, 26);
            this.toolItemInfo.Text = "Просмотр";
            this.toolItemInfo.Click += new System.EventHandler(this.toolBtnInfo_Click);
            // 
            // toolItemDel
            // 
            this.toolItemDel.Image = global::DailyReportN.Properties.Resources.Delete;
            this.toolItemDel.Name = "toolItemDel";
            this.toolItemDel.Size = new System.Drawing.Size(135, 26);
            this.toolItemDel.Text = "Удалить";
            this.toolItemDel.Click += new System.EventHandler(this.toolBtnDel_Click);
            // 
            // contextMenuDamage
            // 
            this.contextMenuDamage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuDamage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolItemAdd,
            this.toolItemEdit,
            this.toolItemInfo,
            this.toolItemDel});
            this.contextMenuDamage.Name = "contextMenuDamage";
            this.contextMenuDamage.Size = new System.Drawing.Size(136, 108);
            this.contextMenuDamage.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuDamage_Opening);
            // 
            // numrequestDataGridViewTextBoxColumn
            // 
            this.numrequestDataGridViewTextBoxColumn.DataPropertyName = "numrequest";
            this.numrequestDataGridViewTextBoxColumn.HeaderText = "№ акта";
            this.numrequestDataGridViewTextBoxColumn.Name = "numrequestDataGridViewTextBoxColumn";
            this.numrequestDataGridViewTextBoxColumn.ReadOnly = true;
            this.numrequestDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numrequestDataGridViewTextBoxColumn.Visible = false;
            this.numrequestDataGridViewTextBoxColumn.Width = 5;
            // 
            // numDocDataGridViewTextBoxColumn
            // 
            this.numDocDataGridViewTextBoxColumn.DataPropertyName = "numDoc";
            this.numDocDataGridViewTextBoxColumn.HeaderText = "№ док. нарушение";
            this.numDocDataGridViewTextBoxColumn.Name = "numDocDataGridViewTextBoxColumn";
            this.numDocDataGridViewTextBoxColumn.ReadOnly = true;
            this.numDocDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numDocDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateDocDgvColumn
            // 
            this.dateDocDgvColumn.DataPropertyName = "dateDoc";
            this.dateDocDgvColumn.HeaderText = "Дата док. нарушения";
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
            this.typeDocNameDataGridViewTextBoxColumn.Visible = false;
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
            this.schmObjNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // netRegionSubDgvColumn
            // 
            this.netRegionSubDgvColumn.DataPropertyName = "NetRegionSub";
            this.netRegionSubDgvColumn.HeaderText = "Сетевой район";
            this.netRegionSubDgvColumn.Name = "netRegionSubDgvColumn";
            this.netRegionSubDgvColumn.ReadOnly = true;
            // 
            // numcrashDgvColumn
            // 
            this.numcrashDgvColumn.DataPropertyName = "numcrash";
            this.numcrashDgvColumn.HeaderText = "Номер аварии";
            this.numcrashDgvColumn.Name = "numcrashDgvColumn";
            this.numcrashDgvColumn.ReadOnly = true;
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
            this.defectLocationDataGridViewTextBoxColumn.Visible = false;
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
            this.reasonDataGridViewTextBoxColumn.Visible = false;
            // 
            // divisionApplyDataGridViewTextBoxColumn
            // 
            this.divisionApplyDataGridViewTextBoxColumn.DataPropertyName = "DivisionApply";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.divisionApplyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.divisionApplyDataGridViewTextBoxColumn.HeaderText = "Подразделение исполнитель";
            this.divisionApplyDataGridViewTextBoxColumn.Name = "divisionApplyDataGridViewTextBoxColumn";
            this.divisionApplyDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionApplyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.divisionApplyDataGridViewTextBoxColumn.Visible = false;
            // 
            // isLaboratoryDgvColumn
            // 
            this.isLaboratoryDgvColumn.DataPropertyName = "isLaboratory";
            this.isLaboratoryDgvColumn.HeaderText = "ПЛ";
            this.isLaboratoryDgvColumn.Name = "isLaboratoryDgvColumn";
            this.isLaboratoryDgvColumn.ReadOnly = true;
            this.isLaboratoryDgvColumn.Visible = false;
            this.isLaboratoryDgvColumn.Width = 40;
            // 
            // dateApplyDgvColumn
            // 
            this.dateApplyDgvColumn.DataPropertyName = "dateApply";
            this.dateApplyDgvColumn.HeaderText = "Дата устранения";
            this.dateApplyDgvColumn.Name = "dateApplyDgvColumn";
            this.dateApplyDgvColumn.ReadOnly = true;
            this.dateApplyDgvColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateApplyDgvColumn.Visible = false;
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
            // workerApplyDataGridViewTextBoxColumn
            // 
            this.workerApplyDataGridViewTextBoxColumn.DataPropertyName = "workerApply";
            this.workerApplyDataGridViewTextBoxColumn.HeaderText = "Выполнил";
            this.workerApplyDataGridViewTextBoxColumn.Name = "workerApplyDataGridViewTextBoxColumn";
            this.workerApplyDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerApplyDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workerApplyDataGridViewTextBoxColumn.Visible = false;
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
            this.completedWorkDataGridViewTextBoxColumn.Visible = false;
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
            this.InstructionDgvColumn.Visible = false;
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
            this.kodPTSStrDgvColumn.Visible = false;
            // 
            // signCrashTypeColumn
            // 
            this.signCrashTypeColumn.DataPropertyName = "signCrashType";
            this.signCrashTypeColumn.HeaderText = "Код учетного признака аварии";
            this.signCrashTypeColumn.Name = "signCrashTypeColumn";
            this.signCrashTypeColumn.ReadOnly = true;
            // 
            // signCrashNameColumn
            // 
            this.signCrashNameColumn.DataPropertyName = "signCrashName";
            this.signCrashNameColumn.HeaderText = "Учетный признак аварии";
            this.signCrashNameColumn.Name = "signCrashNameColumn";
            this.signCrashNameColumn.ReadOnly = true;
            // 
            // typeEquipColumn
            // 
            this.typeEquipColumn.DataPropertyName = "typeEquip";
            this.typeEquipColumn.HeaderText = "Код оборудования";
            this.typeEquipColumn.Name = "typeEquipColumn";
            this.typeEquipColumn.ReadOnly = true;
            // 
            // typeEquipNameColumn
            // 
            this.typeEquipNameColumn.DataPropertyName = "typeEquipName";
            this.typeEquipNameColumn.HeaderText = "Вид оборудования";
            this.typeEquipNameColumn.Name = "typeEquipNameColumn";
            this.typeEquipNameColumn.ReadOnly = true;
            // 
            // idParentDgvColumn
            // 
            this.idParentDgvColumn.DataPropertyName = "idParent";
            this.idParentDgvColumn.HeaderText = "Родитель";
            this.idParentDgvColumn.Name = "idParentDgvColumn";
            this.idParentDgvColumn.ReadOnly = true;
            this.idParentDgvColumn.Visible = false;
            // 
            // reasonCrashEquipTypeColumn
            // 
            this.reasonCrashEquipTypeColumn.DataPropertyName = "reasonCrashEquipType";
            this.reasonCrashEquipTypeColumn.HeaderText = "Код технической причины";
            this.reasonCrashEquipTypeColumn.Name = "reasonCrashEquipTypeColumn";
            this.reasonCrashEquipTypeColumn.ReadOnly = true;
            // 
            // reasonCrashEquipNameColumn
            // 
            this.reasonCrashEquipNameColumn.DataPropertyName = "reasonCrashEquipName";
            this.reasonCrashEquipNameColumn.HeaderText = "Техническая причина";
            this.reasonCrashEquipNameColumn.Name = "reasonCrashEquipNameColumn";
            this.reasonCrashEquipNameColumn.ReadOnly = true;
            // 
            // reasonCrashTypeColumn
            // 
            this.reasonCrashTypeColumn.DataPropertyName = "reasonCrashType";
            this.reasonCrashTypeColumn.HeaderText = "Код организ. причины аварии";
            this.reasonCrashTypeColumn.Name = "reasonCrashTypeColumn";
            this.reasonCrashTypeColumn.ReadOnly = true;
            // 
            // reasonCrashNameColumn
            // 
            this.reasonCrashNameColumn.DataPropertyName = "reasonCrashName";
            this.reasonCrashNameColumn.HeaderText = "Организ. причина аварии";
            this.reasonCrashNameColumn.Name = "reasonCrashNameColumn";
            this.reasonCrashNameColumn.ReadOnly = true;
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
            // VoltageDgvColumn
            // 
            this.VoltageDgvColumn.DataPropertyName = "Voltage";
            this.VoltageDgvColumn.HeaderText = "Уровень напряжения";
            this.VoltageDgvColumn.Name = "VoltageDgvColumn";
            this.VoltageDgvColumn.ReadOnly = true;
            // 
            // FormJournalActDetection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 602);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormJournalActDetection";
            this.Text = "Журнал актов расследования (N2)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJournalActDetection_FormClosed);
            this.Load += new System.EventHandler(this.FormJournalActDetection_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.toolStripTreeSchmObj.ResumeLayout(false);
            this.toolStripTreeSchmObj.PerformLayout();
            this.toolStripFilter.ResumeLayout(false);
            this.toolStripFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActDetection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDamage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDamage)).EndInit();
            this.contextMenuDamage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private ToolStrip toolStrip;

        private SplitContainer splitContainer;

        private DateTimePicker dtpFilterEnd;

        private Label label2;

        private DateTimePicker dtpFilterBeg;

        private Label label1;

        private ToolStrip toolStripFilter;

        private ToolStripButton toolBtnFilterApply;

        private ToolStripButton toolBtnFilterDelete;

        private ToolStripButton toolBtnPrevYear;

        private ToolStripButton toolBtnNextYear;

        private ToolStripButton toolBtnEdit;

        private DataGridViewExcelFilter dgvActDetection;

        private BindingSource bsDamage;

        private DailyReportN.DataSet.dsDamage dsDamage;

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

        private ToolStripSeparator toolStripSeparator2;

        private ToolStripButton toolBtnFind;

        private ToolStripTextBox txtFind;

        private ToolStripButton toolBtnFindPrev;

        private ToolStripButton toolBtnFindNext;

        private ToolStripSeparator toolStripSeparator3;

        private ToolStripDropDownButton toolBtnReport;

        private ToolStripSeparator toolStripSeparator4;

        private ToolStripDropDownButton toolBTnLoadOld;

        private ToolStripMenuItem toolBtnLoadOldDamageLV;

        private ToolStripMenuItem toolBtnLoadOldDefect;

        private ToolStripButton toolBtnDamageNoApply;

        private ToolStripButton toolBtnExportExcel;

        private ToolStripButton toolBtnPrint;

        private ToolStripMenuItem toolBtnLoadAbnDefectLV;

        private ToolStripMenuItem toolBtnLoadOldDamageНV;

        private ToolStripButton toolBtnAdd;

        private ToolStripMenuItem toolItemAdd;

        private ToolStripMenuItem toolItemEdit;

        private ToolStripMenuItem toolItemInfo;

        private ToolStripMenuItem toolItemDel;

        private ContextMenuStrip contextMenuDamage;

        //private DataGridViewFilterTextBoxColumn signCrashTypeDgvActDetection;

        //private DataGridViewFilterTextBoxColumn signCrashNameDgvActDetection;

        //private DataGridViewFilterTextBoxColumn typeEquipDgvActDetection;

        //private DataGridViewFilterTextBoxColumn typeEquipNameDgvActDetection;

        //private DataGridViewFilterTextBoxColumn reasonCrashEquipTypeDgvActDetection;

        //private DataGridViewFilterTextBoxColumn reasonCrashEquipNameDgvActDetection;

        //private DataGridViewFilterTextBoxColumn reasonCrashTypeDgvActDetection;

        //private DataGridViewFilterTextBoxColumn reasonCrashNameDgvActDetection;

        private ToolStripMenuItem tsMenuAmergencyShutdown;

        private ToolStripMenuItem tsMenuReportAccidents;
        private DataGridViewFilterTextBoxColumn numrequestDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn numDocDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn dateDocDgvColumn;
        private DataGridViewFilterTextBoxColumn typeDocNameDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn divisionDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn schmObjNameDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn netRegionSubDgvColumn;
        private DataGridViewFilterTextBoxColumn numcrashDgvColumn;
        private DataGridViewFilterTextBoxColumn defectLocationDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn reasonDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn divisionApplyDataGridViewTextBoxColumn;
        private DataGridViewFilterCheckBoxColumn isLaboratoryDgvColumn;
        private DataGridViewFilterTextBoxColumn dateApplyDgvColumn;
        private DataGridViewFilterCheckBoxColumn isApplyDgvColumn;
        private DataGridViewFilterTextBoxColumn workerApplyDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn completedWorkDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn compilerDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn InstructionDgvColumn;
        private DataGridViewFilterTextBoxColumn nameOwnerDgvColumn;
        private DataGridViewFilterTextBoxColumn dateOwnerDgvColumn;
        private DataGridViewTextBoxColumn comletedWorkTextDataGridViewTextBoxColumn;
        private DataGridViewFilterTextBoxColumn KodPTSDgvColumn;
        private DataGridViewFilterTextBoxColumn kodPTSStrDgvColumn;
        private DataGridViewTextBoxColumn signCrashTypeColumn;
        private DataGridViewTextBoxColumn signCrashNameColumn;
        private DataGridViewTextBoxColumn typeEquipColumn;
        private DataGridViewTextBoxColumn typeEquipNameColumn;
        private DataGridViewTextBoxColumn idParentDgvColumn;
        private DataGridViewTextBoxColumn reasonCrashEquipTypeColumn;
        private DataGridViewTextBoxColumn reasonCrashEquipNameColumn;
        private DataGridViewTextBoxColumn reasonCrashTypeColumn;
        private DataGridViewTextBoxColumn reasonCrashNameColumn;
        private DataGridViewTextBoxColumn typeDocDgvColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn VoltageDgvColumn;
    }

}