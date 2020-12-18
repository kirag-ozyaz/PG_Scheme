namespace ReferenceWorker
{
	public partial class FormWorkers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolBtnShowDivision = new System.Windows.Forms.ToolStripButton();
            this.toolBtnShowJobTitle = new System.Windows.Forms.ToolStripButton();
            this.toolBtnShowGroupWorker = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnShowWorkerDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnPadez = new System.Windows.Forms.ToolStripButton();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.tabControlTree = new System.Windows.Forms.TabControl();
            this.tabPageDivision = new System.Windows.Forms.TabPage();
            this.treeViewDivision = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStripTreeDivision = new System.Windows.Forms.ToolStrip();
            this.toolBtnShowDeleteDivision = new System.Windows.Forms.ToolStripButton();
            this.toolTxtFindTreeDivision = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindTreeDivision = new System.Windows.Forms.ToolStripButton();
            this.toolBtnCloseDivision = new System.Windows.Forms.ToolStripButton();
            this.tabPageJobTitles = new System.Windows.Forms.TabPage();
            this.treeViewJobTitles = new System.Windows.Forms.TreeView();
            this.toolStripTreeJobTiltes = new System.Windows.Forms.ToolStrip();
            this.toolBtnShowDeleteJobTitles = new System.Windows.Forms.ToolStripButton();
            this.toolTxtFindTreeJobTitles = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindTreeJobTitles = new System.Windows.Forms.ToolStripButton();
            this.toolBtnCloseJobTitles = new System.Windows.Forms.ToolStripButton();
            this.tabPageGroupWorkerTree = new System.Windows.Forms.TabPage();
            this.treeViewGroupWorker = new System.Windows.Forms.TreeView();
            this.toolStripTreeGroupWorker = new System.Windows.Forms.ToolStrip();
            this.toolBtnShowDeleteGroupWorker = new System.Windows.Forms.ToolStripButton();
            this.toolTxtFindTreeGroupWorker = new System.Windows.Forms.ToolStripTextBox();
            this.toolBtnFindTreeGroupWorker = new System.Windows.Forms.ToolStripButton();
            this.toolBtnCloseGRoupWorker = new System.Windows.Forms.ToolStripButton();
            this.splitContainerGrid = new System.Windows.Forms.SplitContainer();
            this.dgvWorker = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDgvWorkerTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRRefDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.fDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dsWorker = new ReferenceWorker.DataSetWorker();
            this.divisionCurrentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDgvTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripWorker = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuAddWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuEditWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuDelWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuDateEndWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuDelFullWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparatorEditWorker = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenuItemCopyWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemExportToExcelWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemPrintWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.bsWorker = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlWorkerDetail = new System.Windows.Forms.TabControl();
            this.tabPageWorkerContact = new System.Windows.Forms.TabPage();
            this.dgvContact = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kadrExportDgvCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripContact = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuItemAddContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemEditContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemDelContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenuItemCopyContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemExportToExcelContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemPrintContact = new System.Windows.Forms.ToolStripMenuItem();
            this.bsContact = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContact = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddContact = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEditContact = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelContact = new System.Windows.Forms.ToolStripButton();
            this.tabPageWorkerHistory = new System.Windows.Forms.TabPage();
            this.dgvHistory = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.workerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divisionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.jobTitleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.contextMenuStripHistory = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuItemCopyHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemExportToExcelHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemPrintHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.bsHistory = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageGroupWorker = new System.Windows.Forms.TabPage();
            this.dgvGroupWorker = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuGroupWorker = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolManuItemAddGroupWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemEditGroupWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuItemDelGroupWorker = new System.Windows.Forms.ToolStripMenuItem();
            this.bsGroupWorker = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripGroup = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddGroup = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEditGroup = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelGroup = new System.Windows.Forms.ToolStripButton();
            this.tabPageGroupElectrical = new System.Windows.Forms.TabPage();
            this.dgvGroupElectrical = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDgvGroupElectricalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupElectricalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuGroupElectrical = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuAddGroupElectrical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuEditGroupElectrical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuDelGroupElectrical = new System.Windows.Forms.ToolStripMenuItem();
            this.bsElectrical = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCurrentgroupElectrical = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripGroupElectrical = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddGroupElectrical = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEditGroupElectrical = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelGroupElectrical = new System.Windows.Forms.ToolStripButton();
            this.toolStripMain.SuspendLayout();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tabControlTree.SuspendLayout();
            this.tabPageDivision.SuspendLayout();
            this.toolStripTreeDivision.SuspendLayout();
            this.tabPageJobTitles.SuspendLayout();
            this.toolStripTreeJobTiltes.SuspendLayout();
            this.tabPageGroupWorkerTree.SuspendLayout();
            this.toolStripTreeGroupWorker.SuspendLayout();
            this.splitContainerGrid.Panel1.SuspendLayout();
            this.splitContainerGrid.Panel2.SuspendLayout();
            this.splitContainerGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorker)).BeginInit();
            this.contextMenuStripWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsWorker)).BeginInit();
            this.tabControlWorkerDetail.SuspendLayout();
            this.tabPageWorkerContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).BeginInit();
            this.contextMenuStripContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsContact)).BeginInit();
            this.toolStripContact.SuspendLayout();
            this.tabPageWorkerHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            this.contextMenuStripHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsHistory)).BeginInit();
            this.tabPageGroupWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupWorker)).BeginInit();
            this.contextMenuGroupWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupWorker)).BeginInit();
            this.toolStripGroup.SuspendLayout();
            this.tabPageGroupElectrical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupElectrical)).BeginInit();
            this.contextMenuGroupElectrical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsElectrical)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStripGroupElectrical.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnShowDivision,
            this.toolBtnShowJobTitle,
            this.toolBtnShowGroupWorker,
            this.toolStripSeparator1,
            this.toolBtnShowWorkerDelete,
            this.toolStripSeparator2,
            this.toolStripButtonFind,
            this.toolStripTextBoxFind,
            this.toolStripButtonFindPrev,
            this.toolStripButtonFindNext,
            this.toolStripSeparator3,
            this.toolStripButtonPrint,
            this.toolStripSeparator4,
            this.toolStripButtonExportExcel,
            this.toolStripSeparator5,
            this.toolStripButtonRefresh,
            this.toolStripSeparator7,
            this.toolBtnPadez});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(924, 25);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolBtnShowDivision
            // 
            this.toolBtnShowDivision.Checked = true;
            this.toolBtnShowDivision.CheckOnClick = true;
            this.toolBtnShowDivision.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBtnShowDivision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowDivision.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnShowDivision.Image")));
            this.toolBtnShowDivision.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnShowDivision.Name = "toolBtnShowDivision";
            this.toolBtnShowDivision.Size = new System.Drawing.Size(23, 22);
            this.toolBtnShowDivision.Text = "Скрыть подразделения";
            this.toolBtnShowDivision.Click += new System.EventHandler(this.toolBtnShowDivision_Click);
            // 
            // toolBtnShowJobTitle
            // 
            this.toolBtnShowJobTitle.Checked = true;
            this.toolBtnShowJobTitle.CheckOnClick = true;
            this.toolBtnShowJobTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBtnShowJobTitle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowJobTitle.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnShowJobTitle.Image")));
            this.toolBtnShowJobTitle.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnShowJobTitle.Name = "toolBtnShowJobTitle";
            this.toolBtnShowJobTitle.Size = new System.Drawing.Size(23, 22);
            this.toolBtnShowJobTitle.Text = "Скрыть должности";
            this.toolBtnShowJobTitle.Click += new System.EventHandler(this.toolBtnShowJobTitle_Click);
            // 
            // toolBtnShowGroupWorker
            // 
            this.toolBtnShowGroupWorker.Checked = true;
            this.toolBtnShowGroupWorker.CheckOnClick = true;
            this.toolBtnShowGroupWorker.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBtnShowGroupWorker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowGroupWorker.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnShowGroupWorker.Image")));
            this.toolBtnShowGroupWorker.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnShowGroupWorker.Name = "toolBtnShowGroupWorker";
            this.toolBtnShowGroupWorker.Size = new System.Drawing.Size(23, 22);
            this.toolBtnShowGroupWorker.Text = "Скрыть группы";
            this.toolBtnShowGroupWorker.Click += new System.EventHandler(this.toolBtnShowGroupWorker_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnShowWorkerDelete
            // 
            this.toolBtnShowWorkerDelete.CheckOnClick = true;
            this.toolBtnShowWorkerDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowWorkerDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnShowWorkerDelete.Image")));
            this.toolBtnShowWorkerDelete.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnShowWorkerDelete.Name = "toolBtnShowWorkerDelete";
            this.toolBtnShowWorkerDelete.Size = new System.Drawing.Size(23, 22);
            this.toolBtnShowWorkerDelete.Text = "Показать уволенных";
            this.toolBtnShowWorkerDelete.Click += new System.EventHandler(this.toolBtnShowWorkerDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = global::ReferenceWorker.Properties.Resources.Find;
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
            this.toolStripTextBoxFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxFind_KeyDown);
            // 
            // toolStripButtonFindPrev
            // 
            this.toolStripButtonFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindPrev.Image = global::ReferenceWorker.Properties.Resources.FindPrev;
            this.toolStripButtonFindPrev.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFindPrev.Name = "toolStripButtonFindPrev";
            this.toolStripButtonFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindPrev.Text = "Поиск назад";
            this.toolStripButtonFindPrev.Click += new System.EventHandler(this.toolStripButtonFindPrev_Click);
            // 
            // toolStripButtonFindNext
            // 
            this.toolStripButtonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindNext.Image = global::ReferenceWorker.Properties.Resources.FindNext;
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
            this.toolStripButtonPrint.Image = global::ReferenceWorker.Properties.Resources.Print;
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
            this.toolStripButtonExportExcel.Image = global::ReferenceWorker.Properties.Resources.Excel;
            this.toolStripButtonExportExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonExportExcel.Name = "toolStripButtonExportExcel";
            this.toolStripButtonExportExcel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExportExcel.Text = "Экспорт в Excel";
            this.toolStripButtonExportExcel.Click += new System.EventHandler(this.toolStripButtonExportExcel_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = global::ReferenceWorker.Properties.Resources.Refresh;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Обновить";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolBtnPadez
            // 
            this.toolBtnPadez.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnPadez.Image = global::ReferenceWorker.Properties.Resources.ElementEdit;
            this.toolBtnPadez.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnPadez.Name = "toolBtnPadez";
            this.toolBtnPadez.Size = new System.Drawing.Size(23, 22);
            this.toolBtnPadez.Text = "Падежи";
            this.toolBtnPadez.Click += new System.EventHandler(this.toolBtnPadez_Click);
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 25);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tabControlTree);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.splitContainerGrid);
            this.splitContainerMain.Size = new System.Drawing.Size(924, 518);
            this.splitContainerMain.SplitterDistance = 281;
            this.splitContainerMain.TabIndex = 1;
            // 
            // tabControlTree
            // 
            this.tabControlTree.Controls.Add(this.tabPageDivision);
            this.tabControlTree.Controls.Add(this.tabPageJobTitles);
            this.tabControlTree.Controls.Add(this.tabPageGroupWorkerTree);
            this.tabControlTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTree.ImageList = this.imageList;
            this.tabControlTree.Location = new System.Drawing.Point(0, 0);
            this.tabControlTree.Name = "tabControlTree";
            this.tabControlTree.SelectedIndex = 0;
            this.tabControlTree.Size = new System.Drawing.Size(281, 518);
            this.tabControlTree.TabIndex = 0;
            this.tabControlTree.SelectedIndexChanged += new System.EventHandler(this.tabControlTree_SelectedIndexChanged);
            // 
            // tabPageDivision
            // 
            this.tabPageDivision.Controls.Add(this.treeViewDivision);
            this.tabPageDivision.Controls.Add(this.toolStripTreeDivision);
            this.tabPageDivision.ImageIndex = 4;
            this.tabPageDivision.Location = new System.Drawing.Point(4, 23);
            this.tabPageDivision.Name = "tabPageDivision";
            this.tabPageDivision.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDivision.Size = new System.Drawing.Size(273, 491);
            this.tabPageDivision.TabIndex = 0;
            this.tabPageDivision.Text = "Подразделения";
            this.tabPageDivision.UseVisualStyleBackColor = true;
            // 
            // treeViewDivision
            // 
            this.treeViewDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDivision.ImageIndex = 0;
            this.treeViewDivision.ImageList = this.imageList;
            this.treeViewDivision.Location = new System.Drawing.Point(3, 28);
            this.treeViewDivision.Name = "treeViewDivision";
            this.treeViewDivision.SelectedImageIndex = 0;
            this.treeViewDivision.Size = new System.Drawing.Size(267, 460);
            this.treeViewDivision.TabIndex = 0;
            this.treeViewDivision.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDivision_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "FolderDocumentYellow.png");
            this.imageList.Images.SetKeyName(1, "FolderDeleteYellow.png");
            this.imageList.Images.SetKeyName(2, "FolderYellow.png");
            this.imageList.Images.SetKeyName(3, "JOBPost.png");
            this.imageList.Images.SetKeyName(4, "Company.png");
            this.imageList.Images.SetKeyName(5, "Workers.png");
            // 
            // toolStripTreeDivision
            // 
            this.toolStripTreeDivision.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnShowDeleteDivision,
            this.toolTxtFindTreeDivision,
            this.toolBtnFindTreeDivision,
            this.toolBtnCloseDivision});
            this.toolStripTreeDivision.Location = new System.Drawing.Point(3, 3);
            this.toolStripTreeDivision.Name = "toolStripTreeDivision";
            this.toolStripTreeDivision.Size = new System.Drawing.Size(267, 25);
            this.toolStripTreeDivision.TabIndex = 1;
            this.toolStripTreeDivision.Text = "toolStrip1";
            // 
            // toolBtnShowDeleteDivision
            // 
            this.toolBtnShowDeleteDivision.CheckOnClick = true;
            this.toolBtnShowDeleteDivision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowDeleteDivision.Image = global::ReferenceWorker.Properties.Resources.Trash;
            this.toolBtnShowDeleteDivision.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnShowDeleteDivision.Name = "toolBtnShowDeleteDivision";
            this.toolBtnShowDeleteDivision.Size = new System.Drawing.Size(23, 22);
            this.toolBtnShowDeleteDivision.Text = "Показать удаленные";
            this.toolBtnShowDeleteDivision.Click += new System.EventHandler(this.toolBtnShowDeleteDivision_Click);
            // 
            // toolTxtFindTreeDivision
            // 
            this.toolTxtFindTreeDivision.Name = "toolTxtFindTreeDivision";
            this.toolTxtFindTreeDivision.Size = new System.Drawing.Size(100, 25);
            this.toolTxtFindTreeDivision.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTxtFindTreeDivision_KeyDown);
            // 
            // toolBtnFindTreeDivision
            // 
            this.toolBtnFindTreeDivision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindTreeDivision.Image = global::ReferenceWorker.Properties.Resources.Find;
            this.toolBtnFindTreeDivision.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnFindTreeDivision.Name = "toolBtnFindTreeDivision";
            this.toolBtnFindTreeDivision.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindTreeDivision.Text = "Поиск";
            this.toolBtnFindTreeDivision.Click += new System.EventHandler(this.toolBtnFindTreeDivision_Click);
            // 
            // toolBtnCloseDivision
            // 
            this.toolBtnCloseDivision.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBtnCloseDivision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnCloseDivision.Image = global::ReferenceWorker.Properties.Resources.Close;
            this.toolBtnCloseDivision.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnCloseDivision.Name = "toolBtnCloseDivision";
            this.toolBtnCloseDivision.Size = new System.Drawing.Size(23, 22);
            this.toolBtnCloseDivision.Text = "Скрыть дерево";
            this.toolBtnCloseDivision.Click += new System.EventHandler(this.toolBtnCloseDivision_Click);
            // 
            // tabPageJobTitles
            // 
            this.tabPageJobTitles.Controls.Add(this.treeViewJobTitles);
            this.tabPageJobTitles.Controls.Add(this.toolStripTreeJobTiltes);
            this.tabPageJobTitles.ImageIndex = 0;
            this.tabPageJobTitles.Location = new System.Drawing.Point(4, 23);
            this.tabPageJobTitles.Name = "tabPageJobTitles";
            this.tabPageJobTitles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageJobTitles.Size = new System.Drawing.Size(273, 491);
            this.tabPageJobTitles.TabIndex = 1;
            this.tabPageJobTitles.Text = "Должности";
            this.tabPageJobTitles.UseVisualStyleBackColor = true;
            // 
            // treeViewJobTitles
            // 
            this.treeViewJobTitles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewJobTitles.ImageIndex = 0;
            this.treeViewJobTitles.ImageList = this.imageList;
            this.treeViewJobTitles.Location = new System.Drawing.Point(3, 28);
            this.treeViewJobTitles.Name = "treeViewJobTitles";
            this.treeViewJobTitles.SelectedImageIndex = 0;
            this.treeViewJobTitles.Size = new System.Drawing.Size(267, 460);
            this.treeViewJobTitles.TabIndex = 2;
            this.treeViewJobTitles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewJobTitles_AfterSelect);
            // 
            // toolStripTreeJobTiltes
            // 
            this.toolStripTreeJobTiltes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnShowDeleteJobTitles,
            this.toolTxtFindTreeJobTitles,
            this.toolBtnFindTreeJobTitles,
            this.toolBtnCloseJobTitles});
            this.toolStripTreeJobTiltes.Location = new System.Drawing.Point(3, 3);
            this.toolStripTreeJobTiltes.Name = "toolStripTreeJobTiltes";
            this.toolStripTreeJobTiltes.Size = new System.Drawing.Size(267, 25);
            this.toolStripTreeJobTiltes.TabIndex = 3;
            this.toolStripTreeJobTiltes.Text = "toolStrip1";
            // 
            // toolBtnShowDeleteJobTitles
            // 
            this.toolBtnShowDeleteJobTitles.CheckOnClick = true;
            this.toolBtnShowDeleteJobTitles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowDeleteJobTitles.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnShowDeleteJobTitles.Image")));
            this.toolBtnShowDeleteJobTitles.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnShowDeleteJobTitles.Name = "toolBtnShowDeleteJobTitles";
            this.toolBtnShowDeleteJobTitles.Size = new System.Drawing.Size(23, 22);
            this.toolBtnShowDeleteJobTitles.Text = "Показать удаленные";
            this.toolBtnShowDeleteJobTitles.Click += new System.EventHandler(this.toolBtnShowDeleteJobTitles_Click);
            // 
            // toolTxtFindTreeJobTitles
            // 
            this.toolTxtFindTreeJobTitles.Name = "toolTxtFindTreeJobTitles";
            this.toolTxtFindTreeJobTitles.Size = new System.Drawing.Size(100, 25);
            this.toolTxtFindTreeJobTitles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTxtFindTreeJobTitles_KeyDown);
            // 
            // toolBtnFindTreeJobTitles
            // 
            this.toolBtnFindTreeJobTitles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindTreeJobTitles.Image = global::ReferenceWorker.Properties.Resources.Find;
            this.toolBtnFindTreeJobTitles.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnFindTreeJobTitles.Name = "toolBtnFindTreeJobTitles";
            this.toolBtnFindTreeJobTitles.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindTreeJobTitles.Text = "Поиск";
            this.toolBtnFindTreeJobTitles.Click += new System.EventHandler(this.toolBtnFindTreeJobTitles_Click);
            // 
            // toolBtnCloseJobTitles
            // 
            this.toolBtnCloseJobTitles.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBtnCloseJobTitles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnCloseJobTitles.Image = global::ReferenceWorker.Properties.Resources.Close;
            this.toolBtnCloseJobTitles.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnCloseJobTitles.Name = "toolBtnCloseJobTitles";
            this.toolBtnCloseJobTitles.Size = new System.Drawing.Size(23, 22);
            this.toolBtnCloseJobTitles.Text = "Скрыть дерево";
            this.toolBtnCloseJobTitles.Click += new System.EventHandler(this.toolBtnCloseJobTitles_Click);
            // 
            // tabPageGroupWorkerTree
            // 
            this.tabPageGroupWorkerTree.Controls.Add(this.treeViewGroupWorker);
            this.tabPageGroupWorkerTree.Controls.Add(this.toolStripTreeGroupWorker);
            this.tabPageGroupWorkerTree.ImageIndex = 5;
            this.tabPageGroupWorkerTree.Location = new System.Drawing.Point(4, 23);
            this.tabPageGroupWorkerTree.Name = "tabPageGroupWorkerTree";
            this.tabPageGroupWorkerTree.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroupWorkerTree.Size = new System.Drawing.Size(273, 491);
            this.tabPageGroupWorkerTree.TabIndex = 2;
            this.tabPageGroupWorkerTree.Text = "Группы";
            this.tabPageGroupWorkerTree.UseVisualStyleBackColor = true;
            // 
            // treeViewGroupWorker
            // 
            this.treeViewGroupWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewGroupWorker.ImageIndex = 0;
            this.treeViewGroupWorker.ImageList = this.imageList;
            this.treeViewGroupWorker.Location = new System.Drawing.Point(3, 28);
            this.treeViewGroupWorker.Name = "treeViewGroupWorker";
            this.treeViewGroupWorker.SelectedImageIndex = 0;
            this.treeViewGroupWorker.Size = new System.Drawing.Size(267, 460);
            this.treeViewGroupWorker.TabIndex = 5;
            this.treeViewGroupWorker.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewGroupWorker_AfterSelect);
            // 
            // toolStripTreeGroupWorker
            // 
            this.toolStripTreeGroupWorker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnShowDeleteGroupWorker,
            this.toolTxtFindTreeGroupWorker,
            this.toolBtnFindTreeGroupWorker,
            this.toolBtnCloseGRoupWorker});
            this.toolStripTreeGroupWorker.Location = new System.Drawing.Point(3, 3);
            this.toolStripTreeGroupWorker.Name = "toolStripTreeGroupWorker";
            this.toolStripTreeGroupWorker.Size = new System.Drawing.Size(267, 25);
            this.toolStripTreeGroupWorker.TabIndex = 6;
            this.toolStripTreeGroupWorker.Text = "toolStrip1";
            // 
            // toolBtnShowDeleteGroupWorker
            // 
            this.toolBtnShowDeleteGroupWorker.CheckOnClick = true;
            this.toolBtnShowDeleteGroupWorker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowDeleteGroupWorker.Image = global::ReferenceWorker.Properties.Resources.Trash;
            this.toolBtnShowDeleteGroupWorker.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnShowDeleteGroupWorker.Name = "toolBtnShowDeleteGroupWorker";
            this.toolBtnShowDeleteGroupWorker.Size = new System.Drawing.Size(23, 22);
            this.toolBtnShowDeleteGroupWorker.Text = "Показать удаленные";
            this.toolBtnShowDeleteGroupWorker.Click += new System.EventHandler(this.toolBtnShowDeleteGroupWorker_Click);
            // 
            // toolTxtFindTreeGroupWorker
            // 
            this.toolTxtFindTreeGroupWorker.Name = "toolTxtFindTreeGroupWorker";
            this.toolTxtFindTreeGroupWorker.Size = new System.Drawing.Size(100, 25);
            this.toolTxtFindTreeGroupWorker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTxtFindTreeGroupWorker_KeyDown);
            // 
            // toolBtnFindTreeGroupWorker
            // 
            this.toolBtnFindTreeGroupWorker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnFindTreeGroupWorker.Image = global::ReferenceWorker.Properties.Resources.Find;
            this.toolBtnFindTreeGroupWorker.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnFindTreeGroupWorker.Name = "toolBtnFindTreeGroupWorker";
            this.toolBtnFindTreeGroupWorker.Size = new System.Drawing.Size(23, 22);
            this.toolBtnFindTreeGroupWorker.Text = "Поиск";
            this.toolBtnFindTreeGroupWorker.Click += new System.EventHandler(this.toolBtnFindTreeGroupWorker_Click);
            // 
            // toolBtnCloseGRoupWorker
            // 
            this.toolBtnCloseGRoupWorker.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolBtnCloseGRoupWorker.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnCloseGRoupWorker.Image = global::ReferenceWorker.Properties.Resources.Close;
            this.toolBtnCloseGRoupWorker.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnCloseGRoupWorker.Name = "toolBtnCloseGRoupWorker";
            this.toolBtnCloseGRoupWorker.Size = new System.Drawing.Size(23, 22);
            this.toolBtnCloseGRoupWorker.Text = "Скрыть дерево";
            this.toolBtnCloseGRoupWorker.Click += new System.EventHandler(this.toolBtnCloseGRoupWorker_Click);
            // 
            // splitContainerGrid
            // 
            this.splitContainerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerGrid.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerGrid.Location = new System.Drawing.Point(0, 0);
            this.splitContainerGrid.Name = "splitContainerGrid";
            this.splitContainerGrid.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerGrid.Panel1
            // 
            this.splitContainerGrid.Panel1.Controls.Add(this.dgvWorker);
            // 
            // splitContainerGrid.Panel2
            // 
            this.splitContainerGrid.Panel2.Controls.Add(this.tabControlWorkerDetail);
            this.splitContainerGrid.Size = new System.Drawing.Size(639, 518);
            this.splitContainerGrid.SplitterDistance = 379;
            this.splitContainerGrid.TabIndex = 0;
            // 
            // dgvWorker
            // 
            this.dgvWorker.AllowUserToAddRows = false;
            this.dgvWorker.AllowUserToDeleteRows = false;
            this.dgvWorker.AllowUserToOrderColumns = true;
            this.dgvWorker.AllowUserToResizeRows = false;
            this.dgvWorker.AllowUserToVisibleColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvWorker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorker.AutoGenerateColumns = false;
            this.dgvWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDgvWorkerTextBoxColumn,
            this.iDRRefDataGridViewImageColumn,
            this.fDataGridViewTextBoxColumn,
            this.iDataGridViewTextBoxColumn,
            this.oDataGridViewTextBoxColumn,
            this.jobTitleDataGridViewTextBoxColumn,
            this.divisionCurrentDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.dateEndDgvTextBoxColumn});
            this.dgvWorker.ContextMenuStrip = this.contextMenuStripWorker;
            this.dgvWorker.DataSource = this.bsWorker;
            this.dgvWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorker.Location = new System.Drawing.Point(0, 0);
            this.dgvWorker.Name = "dgvWorker";
            this.dgvWorker.ReadOnly = true;
            this.dgvWorker.RowHeadersWidth = 21;
            this.dgvWorker.Size = new System.Drawing.Size(639, 379);
            this.dgvWorker.TabIndex = 0;
            this.dgvWorker.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvWorker_CellFormatting);
            this.dgvWorker.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorker_DataError);
            this.dgvWorker.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorker_RowEnter);
            this.dgvWorker.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvWorker_RowsAdded);
            this.dgvWorker.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvWorker_RowsRemoved);
            // 
            // idDgvWorkerTextBoxColumn
            // 
            this.idDgvWorkerTextBoxColumn.DataPropertyName = "id";
            this.idDgvWorkerTextBoxColumn.HeaderText = "id";
            this.idDgvWorkerTextBoxColumn.Name = "idDgvWorkerTextBoxColumn";
            this.idDgvWorkerTextBoxColumn.ReadOnly = true;
            this.idDgvWorkerTextBoxColumn.Visible = false;
            this.idDgvWorkerTextBoxColumn.Width = 20;
            // 
            // iDRRefDataGridViewImageColumn
            // 
            this.iDRRefDataGridViewImageColumn.DataPropertyName = "IDRRef";
            this.iDRRefDataGridViewImageColumn.HeaderText = "IDRRef";
            this.iDRRefDataGridViewImageColumn.Name = "iDRRefDataGridViewImageColumn";
            this.iDRRefDataGridViewImageColumn.ReadOnly = true;
            this.iDRRefDataGridViewImageColumn.Visible = false;
            // 
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "Фамлия";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            this.fDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDataGridViewTextBoxColumn
            // 
            this.iDataGridViewTextBoxColumn.DataPropertyName = "I";
            this.iDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.iDataGridViewTextBoxColumn.Name = "iDataGridViewTextBoxColumn";
            this.iDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oDataGridViewTextBoxColumn
            // 
            this.oDataGridViewTextBoxColumn.DataPropertyName = "O";
            this.oDataGridViewTextBoxColumn.HeaderText = "Oтчество";
            this.oDataGridViewTextBoxColumn.Name = "oDataGridViewTextBoxColumn";
            this.oDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jobTitleDataGridViewTextBoxColumn
            // 
            this.jobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn.DataSource = this.dsWorker;
            this.jobTitleDataGridViewTextBoxColumn.DisplayMember = "tR_JobTitle.Description";
            this.jobTitleDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.jobTitleDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.jobTitleDataGridViewTextBoxColumn.Name = "jobTitleDataGridViewTextBoxColumn";
            this.jobTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobTitleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jobTitleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.jobTitleDataGridViewTextBoxColumn.ValueMember = "tR_JobTitle.id";
            // 
            // dsWorker
            // 
            this.dsWorker.DataSetName = "DataSetWorkers";
            this.dsWorker.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // divisionCurrentDataGridViewTextBoxColumn
            // 
            this.divisionCurrentDataGridViewTextBoxColumn.DataPropertyName = "DivisionCurrent";
            this.divisionCurrentDataGridViewTextBoxColumn.DataSource = this.dsWorker;
            this.divisionCurrentDataGridViewTextBoxColumn.DisplayMember = "tR_Division.Description";
            this.divisionCurrentDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.divisionCurrentDataGridViewTextBoxColumn.HeaderText = "Подразделение";
            this.divisionCurrentDataGridViewTextBoxColumn.Name = "divisionCurrentDataGridViewTextBoxColumn";
            this.divisionCurrentDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionCurrentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.divisionCurrentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.divisionCurrentDataGridViewTextBoxColumn.ValueMember = "tR_Division.id";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.birthdayDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Дата рожд";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            this.birthdayDataGridViewTextBoxColumn.Width = 70;
            // 
            // divisionDataGridViewTextBoxColumn
            // 
            this.divisionDataGridViewTextBoxColumn.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn.HeaderText = "Division";
            this.divisionDataGridViewTextBoxColumn.Name = "divisionDataGridViewTextBoxColumn";
            this.divisionDataGridViewTextBoxColumn.ReadOnly = true;
            this.divisionDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateBeginDataGridViewTextBoxColumn
            // 
            this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "DateBegin";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dateBeginDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateBeginDataGridViewTextBoxColumn.HeaderText = "Работает с";
            this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
            this.dateBeginDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateBeginDataGridViewTextBoxColumn.Width = 70;
            // 
            // dateEndDgvTextBoxColumn
            // 
            this.dateEndDgvTextBoxColumn.DataPropertyName = "DateEnd";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dateEndDgvTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dateEndDgvTextBoxColumn.HeaderText = "Уволен";
            this.dateEndDgvTextBoxColumn.Name = "dateEndDgvTextBoxColumn";
            this.dateEndDgvTextBoxColumn.ReadOnly = true;
            this.dateEndDgvTextBoxColumn.Width = 70;
            // 
            // contextMenuStripWorker
            // 
            this.contextMenuStripWorker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuAddWorker,
            this.toolMenuEditWorker,
            this.toolMenuDelWorker,
            this.toolStripSeparatorEditWorker,
            this.toolMenuItemCopyWorker,
            this.toolMenuItemExportToExcelWorker,
            this.toolMenuItemPrintWorker});
            this.contextMenuStripWorker.Name = "contextMenuStripWorker";
            this.contextMenuStripWorker.Size = new System.Drawing.Size(158, 142);
            this.contextMenuStripWorker.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripWorker_Opening);
            // 
            // toolMenuAddWorker
            // 
            this.toolMenuAddWorker.Image = global::ReferenceWorker.Properties.Resources.ElementAdd;
            this.toolMenuAddWorker.Name = "toolMenuAddWorker";
            this.toolMenuAddWorker.Size = new System.Drawing.Size(157, 22);
            this.toolMenuAddWorker.Text = "Добавить";
            this.toolMenuAddWorker.Click += new System.EventHandler(this.toolMenuAddWorker_Click);
            // 
            // toolMenuEditWorker
            // 
            this.toolMenuEditWorker.Image = global::ReferenceWorker.Properties.Resources.ElementEdit;
            this.toolMenuEditWorker.Name = "toolMenuEditWorker";
            this.toolMenuEditWorker.Size = new System.Drawing.Size(157, 22);
            this.toolMenuEditWorker.Text = "Изменить";
            this.toolMenuEditWorker.Click += new System.EventHandler(this.toolMenuEditWorker_Click);
            // 
            // toolMenuDelWorker
            // 
            this.toolMenuDelWorker.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuDateEndWorker,
            this.toolMenuDelFullWorker});
            this.toolMenuDelWorker.Image = global::ReferenceWorker.Properties.Resources.ElementDel;
            this.toolMenuDelWorker.Name = "toolMenuDelWorker";
            this.toolMenuDelWorker.Size = new System.Drawing.Size(157, 22);
            this.toolMenuDelWorker.Text = "Удалить";
            // 
            // toolMenuDateEndWorker
            // 
            this.toolMenuDateEndWorker.Name = "toolMenuDateEndWorker";
            this.toolMenuDateEndWorker.Size = new System.Drawing.Size(198, 22);
            this.toolMenuDateEndWorker.Text = "Пометить на удаление";
            this.toolMenuDateEndWorker.Click += new System.EventHandler(this.toolMenuDateEndWorker_Click);
            // 
            // toolMenuDelFullWorker
            // 
            this.toolMenuDelFullWorker.Name = "toolMenuDelFullWorker";
            this.toolMenuDelFullWorker.Size = new System.Drawing.Size(198, 22);
            this.toolMenuDelFullWorker.Text = "Удалить полностью";
            this.toolMenuDelFullWorker.Click += new System.EventHandler(this.toolMenuDelFullWorker_Click);
            // 
            // toolStripSeparatorEditWorker
            // 
            this.toolStripSeparatorEditWorker.Name = "toolStripSeparatorEditWorker";
            this.toolStripSeparatorEditWorker.Size = new System.Drawing.Size(154, 6);
            // 
            // toolMenuItemCopyWorker
            // 
            this.toolMenuItemCopyWorker.Image = global::ReferenceWorker.Properties.Resources.CopyBuffer;
            this.toolMenuItemCopyWorker.Name = "toolMenuItemCopyWorker";
            this.toolMenuItemCopyWorker.Size = new System.Drawing.Size(157, 22);
            this.toolMenuItemCopyWorker.Text = "Копировать";
            this.toolMenuItemCopyWorker.Click += new System.EventHandler(this.toolMenuItemCopyWorker_Click);
            // 
            // toolMenuItemExportToExcelWorker
            // 
            this.toolMenuItemExportToExcelWorker.Image = global::ReferenceWorker.Properties.Resources.CopyBuffer;
            this.toolMenuItemExportToExcelWorker.Name = "toolMenuItemExportToExcelWorker";
            this.toolMenuItemExportToExcelWorker.Size = new System.Drawing.Size(157, 22);
            this.toolMenuItemExportToExcelWorker.Text = "Экспорт в Excel";
            this.toolMenuItemExportToExcelWorker.Click += new System.EventHandler(this.toolMenuItemExportToExcelWorker_Click);
            // 
            // toolMenuItemPrintWorker
            // 
            this.toolMenuItemPrintWorker.Image = global::ReferenceWorker.Properties.Resources.Print;
            this.toolMenuItemPrintWorker.Name = "toolMenuItemPrintWorker";
            this.toolMenuItemPrintWorker.Size = new System.Drawing.Size(157, 22);
            this.toolMenuItemPrintWorker.Text = "Печать";
            this.toolMenuItemPrintWorker.Click += new System.EventHandler(this.toolMenuItemPrintWorker_Click);
            // 
            // bsWorker
            // 
            this.bsWorker.DataMember = "tR_Worker";
            this.bsWorker.DataSource = this.dsWorker;
            // 
            // tabControlWorkerDetail
            // 
            this.tabControlWorkerDetail.Controls.Add(this.tabPageWorkerContact);
            this.tabControlWorkerDetail.Controls.Add(this.tabPageWorkerHistory);
            this.tabControlWorkerDetail.Controls.Add(this.tabPageGroupWorker);
            this.tabControlWorkerDetail.Controls.Add(this.tabPageGroupElectrical);
            this.tabControlWorkerDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlWorkerDetail.Location = new System.Drawing.Point(0, 0);
            this.tabControlWorkerDetail.Name = "tabControlWorkerDetail";
            this.tabControlWorkerDetail.SelectedIndex = 0;
            this.tabControlWorkerDetail.Size = new System.Drawing.Size(639, 135);
            this.tabControlWorkerDetail.TabIndex = 0;
            // 
            // tabPageWorkerContact
            // 
            this.tabPageWorkerContact.Controls.Add(this.dgvContact);
            this.tabPageWorkerContact.Controls.Add(this.toolStripContact);
            this.tabPageWorkerContact.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkerContact.Name = "tabPageWorkerContact";
            this.tabPageWorkerContact.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkerContact.Size = new System.Drawing.Size(631, 109);
            this.tabPageWorkerContact.TabIndex = 0;
            this.tabPageWorkerContact.Text = "Контактная информация";
            this.tabPageWorkerContact.UseVisualStyleBackColor = true;
            // 
            // dgvContact
            // 
            this.dgvContact.AllowUserToAddRows = false;
            this.dgvContact.AllowUserToDeleteRows = false;
            this.dgvContact.AllowUserToOrderColumns = true;
            this.dgvContact.AllowUserToResizeRows = false;
            this.dgvContact.AllowUserToVisibleColumns = false;
            this.dgvContact.AutoGenerateColumns = false;
            this.dgvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.workerDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.kadrExportDgvCheckBoxColumn,
            this.ColumnComment});
            this.dgvContact.ContextMenuStrip = this.contextMenuStripContact;
            this.dgvContact.DataSource = this.bsContact;
            this.dgvContact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContact.Location = new System.Drawing.Point(35, 3);
            this.dgvContact.Name = "dgvContact";
            this.dgvContact.ReadOnly = true;
            this.dgvContact.RowHeadersWidth = 21;
            this.dgvContact.Size = new System.Drawing.Size(593, 103);
            this.dgvContact.TabIndex = 0;
            this.dgvContact.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvContact_CellFormatting);
            this.dgvContact.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvContact_RowsAdded);
            this.dgvContact.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvContact_RowsRemoved);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // workerDataGridViewTextBoxColumn1
            // 
            this.workerDataGridViewTextBoxColumn1.DataPropertyName = "Worker";
            this.workerDataGridViewTextBoxColumn1.HeaderText = "Worker";
            this.workerDataGridViewTextBoxColumn1.Name = "workerDataGridViewTextBoxColumn1";
            this.workerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.workerDataGridViewTextBoxColumn1.Visible = false;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.DataSource = this.dsWorker;
            this.typeDataGridViewTextBoxColumn.DisplayMember = "tR_Classifier.Name";
            this.typeDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.typeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.typeDataGridViewTextBoxColumn.ValueMember = "tR_Classifier.Id";
            this.typeDataGridViewTextBoxColumn.Width = 200;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Значение";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 300;
            // 
            // kadrExportDgvCheckBoxColumn
            // 
            this.kadrExportDgvCheckBoxColumn.DataPropertyName = "KadrExport";
            this.kadrExportDgvCheckBoxColumn.HeaderText = "KadrExport";
            this.kadrExportDgvCheckBoxColumn.Name = "kadrExportDgvCheckBoxColumn";
            this.kadrExportDgvCheckBoxColumn.ReadOnly = true;
            this.kadrExportDgvCheckBoxColumn.Visible = false;
            // 
            // ColumnComment
            // 
            this.ColumnComment.DataPropertyName = "Comment";
            this.ColumnComment.HeaderText = "Доп. информация";
            this.ColumnComment.Name = "ColumnComment";
            this.ColumnComment.ReadOnly = true;
            this.ColumnComment.Width = 200;
            // 
            // contextMenuStripContact
            // 
            this.contextMenuStripContact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemAddContact,
            this.toolMenuItemEditContact,
            this.toolMenuItemDelContact,
            this.toolStripSeparator6,
            this.toolMenuItemCopyContact,
            this.toolMenuItemExportToExcelContact,
            this.toolMenuItemPrintContact});
            this.contextMenuStripContact.Name = "contextMenuStripContact";
            this.contextMenuStripContact.Size = new System.Drawing.Size(158, 142);
            // 
            // toolMenuItemAddContact
            // 
            this.toolMenuItemAddContact.Image = global::ReferenceWorker.Properties.Resources.ElementAdd;
            this.toolMenuItemAddContact.Name = "toolMenuItemAddContact";
            this.toolMenuItemAddContact.Size = new System.Drawing.Size(157, 22);
            this.toolMenuItemAddContact.Text = "Добавить";
            this.toolMenuItemAddContact.Click += new System.EventHandler(this.toolBtnAddContact_Click);
            // 
            // toolMenuItemEditContact
            // 
            this.toolMenuItemEditContact.Image = global::ReferenceWorker.Properties.Resources.ElementEdit;
            this.toolMenuItemEditContact.Name = "toolMenuItemEditContact";
            this.toolMenuItemEditContact.Size = new System.Drawing.Size(157, 22);
            this.toolMenuItemEditContact.Text = "Изменить";
            this.toolMenuItemEditContact.Click += new System.EventHandler(this.toolBtnEditContact_Click);
            // 
            // toolMenuItemDelContact
            // 
            this.toolMenuItemDelContact.Image = global::ReferenceWorker.Properties.Resources.ElementDel;
            this.toolMenuItemDelContact.Name = "toolMenuItemDelContact";
            this.toolMenuItemDelContact.Size = new System.Drawing.Size(157, 22);
            this.toolMenuItemDelContact.Text = "Удалить";
            this.toolMenuItemDelContact.Click += new System.EventHandler(this.toolBtnDelContact_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(154, 6);
            // 
            // toolMenuItemCopyContact
            // 
            this.toolMenuItemCopyContact.Image = global::ReferenceWorker.Properties.Resources.CopyBuffer;
            this.toolMenuItemCopyContact.Name = "toolMenuItemCopyContact";
            this.toolMenuItemCopyContact.Size = new System.Drawing.Size(157, 22);
            this.toolMenuItemCopyContact.Text = "Копировать";
            this.toolMenuItemCopyContact.Click += new System.EventHandler(this.toolMenuItemCopyContact_Click);
            // 
            // toolMenuItemExportToExcelContact
            // 
            this.toolMenuItemExportToExcelContact.Image = global::ReferenceWorker.Properties.Resources.Excel;
            this.toolMenuItemExportToExcelContact.Name = "toolMenuItemExportToExcelContact";
            this.toolMenuItemExportToExcelContact.Size = new System.Drawing.Size(157, 22);
            this.toolMenuItemExportToExcelContact.Text = "Экспорт в Excel";
            this.toolMenuItemExportToExcelContact.Click += new System.EventHandler(this.toolMenuItemExportToExcelContact_Click);
            // 
            // toolMenuItemPrintContact
            // 
            this.toolMenuItemPrintContact.Image = global::ReferenceWorker.Properties.Resources.Print;
            this.toolMenuItemPrintContact.Name = "toolMenuItemPrintContact";
            this.toolMenuItemPrintContact.Size = new System.Drawing.Size(157, 22);
            this.toolMenuItemPrintContact.Text = "Печать";
            this.toolMenuItemPrintContact.Click += new System.EventHandler(this.toolMenuItemPrintContact_Click);
            // 
            // bsContact
            // 
            this.bsContact.DataMember = "tR_WorkerContact";
            this.bsContact.DataSource = this.dsWorker;
            this.bsContact.Sort = "KadrExport, Description";
            // 
            // toolStripContact
            // 
            this.toolStripContact.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripContact.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripContact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddContact,
            this.toolBtnEditContact,
            this.toolBtnDelContact});
            this.toolStripContact.Location = new System.Drawing.Point(3, 3);
            this.toolStripContact.Name = "toolStripContact";
            this.toolStripContact.Size = new System.Drawing.Size(32, 103);
            this.toolStripContact.TabIndex = 1;
            this.toolStripContact.Text = "toolStrip1";
            // 
            // toolBtnAddContact
            // 
            this.toolBtnAddContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddContact.Image = global::ReferenceWorker.Properties.Resources.ElementAdd;
            this.toolBtnAddContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddContact.Name = "toolBtnAddContact";
            this.toolBtnAddContact.Size = new System.Drawing.Size(29, 20);
            this.toolBtnAddContact.Text = "Добавить контакт";
            this.toolBtnAddContact.Click += new System.EventHandler(this.toolBtnAddContact_Click);
            // 
            // toolBtnEditContact
            // 
            this.toolBtnEditContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEditContact.Image = global::ReferenceWorker.Properties.Resources.ElementEdit;
            this.toolBtnEditContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEditContact.Name = "toolBtnEditContact";
            this.toolBtnEditContact.Size = new System.Drawing.Size(29, 20);
            this.toolBtnEditContact.Text = "Редактировать контакт";
            this.toolBtnEditContact.Click += new System.EventHandler(this.toolBtnEditContact_Click);
            // 
            // toolBtnDelContact
            // 
            this.toolBtnDelContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelContact.Image = global::ReferenceWorker.Properties.Resources.ElementDel;
            this.toolBtnDelContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelContact.Name = "toolBtnDelContact";
            this.toolBtnDelContact.Size = new System.Drawing.Size(29, 20);
            this.toolBtnDelContact.Text = "Удалить контакт";
            this.toolBtnDelContact.Click += new System.EventHandler(this.toolBtnDelContact_Click);
            // 
            // tabPageWorkerHistory
            // 
            this.tabPageWorkerHistory.Controls.Add(this.dgvHistory);
            this.tabPageWorkerHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageWorkerHistory.Name = "tabPageWorkerHistory";
            this.tabPageWorkerHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWorkerHistory.Size = new System.Drawing.Size(631, 109);
            this.tabPageWorkerHistory.TabIndex = 1;
            this.tabPageWorkerHistory.Text = "История";
            this.tabPageWorkerHistory.UseVisualStyleBackColor = true;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToOrderColumns = true;
            this.dgvHistory.AllowUserToResizeRows = false;
            this.dgvHistory.AllowUserToVisibleColumns = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHistory.AutoGenerateColumns = false;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.periodDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.workerDataGridViewTextBoxColumn,
            this.divisionDataGridViewTextBoxColumn1,
            this.jobTitleDataGridViewTextBoxColumn1});
            this.dgvHistory.ContextMenuStrip = this.contextMenuStripHistory;
            this.dgvHistory.DataSource = this.bsHistory;
            this.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHistory.Location = new System.Drawing.Point(3, 3);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.RowHeadersWidth = 21;
            this.dgvHistory.Size = new System.Drawing.Size(625, 103);
            this.dgvHistory.TabIndex = 0;
            this.dgvHistory.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvHistory_DataError);
            this.dgvHistory.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvHistory_RowsAdded);
            this.dgvHistory.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvHistory_RowsRemoved);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.periodDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.periodDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.ReadOnly = true;
            this.periodDataGridViewTextBoxColumn.Width = 70;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.DataSource = this.dsWorker;
            this.statusDataGridViewTextBoxColumn.DisplayMember = "tR_Classifier.Name";
            this.statusDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.statusDataGridViewTextBoxColumn.ValueMember = "tR_Classifier.Id";
            this.statusDataGridViewTextBoxColumn.Width = 130;
            // 
            // workerDataGridViewTextBoxColumn
            // 
            this.workerDataGridViewTextBoxColumn.DataPropertyName = "Worker";
            this.workerDataGridViewTextBoxColumn.HeaderText = "Worker";
            this.workerDataGridViewTextBoxColumn.Name = "workerDataGridViewTextBoxColumn";
            this.workerDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerDataGridViewTextBoxColumn.Visible = false;
            // 
            // divisionDataGridViewTextBoxColumn1
            // 
            this.divisionDataGridViewTextBoxColumn1.DataPropertyName = "Division";
            this.divisionDataGridViewTextBoxColumn1.DataSource = this.dsWorker;
            this.divisionDataGridViewTextBoxColumn1.DisplayMember = "tR_Division.Description";
            this.divisionDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.divisionDataGridViewTextBoxColumn1.HeaderText = "Подразделение";
            this.divisionDataGridViewTextBoxColumn1.Name = "divisionDataGridViewTextBoxColumn1";
            this.divisionDataGridViewTextBoxColumn1.ReadOnly = true;
            this.divisionDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.divisionDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.divisionDataGridViewTextBoxColumn1.ValueMember = "tR_Division.id";
            this.divisionDataGridViewTextBoxColumn1.Width = 150;
            // 
            // jobTitleDataGridViewTextBoxColumn1
            // 
            this.jobTitleDataGridViewTextBoxColumn1.DataPropertyName = "JobTitle";
            this.jobTitleDataGridViewTextBoxColumn1.DataSource = this.dsWorker;
            this.jobTitleDataGridViewTextBoxColumn1.DisplayMember = "tR_JobTitle.Description";
            this.jobTitleDataGridViewTextBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.jobTitleDataGridViewTextBoxColumn1.HeaderText = "Должность";
            this.jobTitleDataGridViewTextBoxColumn1.Name = "jobTitleDataGridViewTextBoxColumn1";
            this.jobTitleDataGridViewTextBoxColumn1.ReadOnly = true;
            this.jobTitleDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.jobTitleDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.jobTitleDataGridViewTextBoxColumn1.ValueMember = "tR_JobTitle.id";
            this.jobTitleDataGridViewTextBoxColumn1.Width = 150;
            // 
            // contextMenuStripHistory
            // 
            this.contextMenuStripHistory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuItemCopyHistory,
            this.toolMenuItemExportToExcelHistory,
            this.toolMenuItemPrintHistory});
            this.contextMenuStripHistory.Name = "contextMenuStripHistory";
            this.contextMenuStripHistory.Size = new System.Drawing.Size(158, 70);
            // 
            // toolMenuItemCopyHistory
            // 
            this.toolMenuItemCopyHistory.Image = global::ReferenceWorker.Properties.Resources.CopyBuffer;
            this.toolMenuItemCopyHistory.Name = "toolMenuItemCopyHistory";
            this.toolMenuItemCopyHistory.Size = new System.Drawing.Size(157, 22);
            this.toolMenuItemCopyHistory.Text = "Копировать";
            this.toolMenuItemCopyHistory.Click += new System.EventHandler(this.toolMenuItemCopyHistory_Click);
            // 
            // toolMenuItemExportToExcelHistory
            // 
            this.toolMenuItemExportToExcelHistory.Image = global::ReferenceWorker.Properties.Resources.Excel;
            this.toolMenuItemExportToExcelHistory.Name = "toolMenuItemExportToExcelHistory";
            this.toolMenuItemExportToExcelHistory.Size = new System.Drawing.Size(157, 22);
            this.toolMenuItemExportToExcelHistory.Text = "Экспорт в Excel";
            this.toolMenuItemExportToExcelHistory.Click += new System.EventHandler(this.toolMenuItemExportToExcelHistory_Click);
            // 
            // toolMenuItemPrintHistory
            // 
            this.toolMenuItemPrintHistory.Image = global::ReferenceWorker.Properties.Resources.Print;
            this.toolMenuItemPrintHistory.Name = "toolMenuItemPrintHistory";
            this.toolMenuItemPrintHistory.Size = new System.Drawing.Size(157, 22);
            this.toolMenuItemPrintHistory.Text = "Печать";
            this.toolMenuItemPrintHistory.Click += new System.EventHandler(this.toolMenuItemPrintHistory_Click);
            // 
            // bsHistory
            // 
            this.bsHistory.DataMember = "tJ_StatusWorker";
            this.bsHistory.DataSource = this.dsWorker;
            this.bsHistory.Sort = "Period";
            // 
            // tabPageGroupWorker
            // 
            this.tabPageGroupWorker.Controls.Add(this.dgvGroupWorker);
            this.tabPageGroupWorker.Controls.Add(this.toolStripGroup);
            this.tabPageGroupWorker.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroupWorker.Name = "tabPageGroupWorker";
            this.tabPageGroupWorker.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroupWorker.Size = new System.Drawing.Size(631, 109);
            this.tabPageGroupWorker.TabIndex = 2;
            this.tabPageGroupWorker.Text = "Группы сотрудника";
            this.tabPageGroupWorker.UseVisualStyleBackColor = true;
            // 
            // dgvGroupWorker
            // 
            this.dgvGroupWorker.AllowUserToAddRows = false;
            this.dgvGroupWorker.AllowUserToDeleteRows = false;
            this.dgvGroupWorker.AutoGenerateColumns = false;
            this.dgvGroupWorker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupWorker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.idGroupDataGridViewTextBoxColumn,
            this.idWorkerDataGridViewTextBoxColumn});
            this.dgvGroupWorker.ContextMenuStrip = this.contextMenuGroupWorker;
            this.dgvGroupWorker.DataSource = this.bsGroupWorker;
            this.dgvGroupWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroupWorker.Location = new System.Drawing.Point(27, 3);
            this.dgvGroupWorker.Name = "dgvGroupWorker";
            this.dgvGroupWorker.ReadOnly = true;
            this.dgvGroupWorker.RowHeadersWidth = 20;
            this.dgvGroupWorker.Size = new System.Drawing.Size(601, 103);
            this.dgvGroupWorker.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // idGroupDataGridViewTextBoxColumn
            // 
            this.idGroupDataGridViewTextBoxColumn.DataPropertyName = "IdGroup";
            this.idGroupDataGridViewTextBoxColumn.DataSource = this.dsWorker;
            this.idGroupDataGridViewTextBoxColumn.DisplayMember = "tR_Classifier.Name";
            this.idGroupDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idGroupDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.idGroupDataGridViewTextBoxColumn.Name = "idGroupDataGridViewTextBoxColumn";
            this.idGroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.idGroupDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idGroupDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idGroupDataGridViewTextBoxColumn.ValueMember = "tR_Classifier.Id";
            this.idGroupDataGridViewTextBoxColumn.Width = 250;
            // 
            // idWorkerDataGridViewTextBoxColumn
            // 
            this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "IdWorker";
            this.idWorkerDataGridViewTextBoxColumn.HeaderText = "IdWorker";
            this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
            this.idWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idWorkerDataGridViewTextBoxColumn.Visible = false;
            // 
            // contextMenuGroupWorker
            // 
            this.contextMenuGroupWorker.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolManuItemAddGroupWorker,
            this.toolMenuItemEditGroupWorker,
            this.toolMenuItemDelGroupWorker});
            this.contextMenuGroupWorker.Name = "contextMenuGroupWorker";
            this.contextMenuGroupWorker.Size = new System.Drawing.Size(129, 70);
            // 
            // toolManuItemAddGroupWorker
            // 
            this.toolManuItemAddGroupWorker.Image = global::ReferenceWorker.Properties.Resources.ElementAdd;
            this.toolManuItemAddGroupWorker.Name = "toolManuItemAddGroupWorker";
            this.toolManuItemAddGroupWorker.Size = new System.Drawing.Size(128, 22);
            this.toolManuItemAddGroupWorker.Text = "Добавить";
            this.toolManuItemAddGroupWorker.Click += new System.EventHandler(this.toolManuItemAddGroupWorker_Click);
            // 
            // toolMenuItemEditGroupWorker
            // 
            this.toolMenuItemEditGroupWorker.Image = global::ReferenceWorker.Properties.Resources.ElementEdit;
            this.toolMenuItemEditGroupWorker.Name = "toolMenuItemEditGroupWorker";
            this.toolMenuItemEditGroupWorker.Size = new System.Drawing.Size(128, 22);
            this.toolMenuItemEditGroupWorker.Text = "Изменить";
            this.toolMenuItemEditGroupWorker.Click += new System.EventHandler(this.toolMenuItemEditGroupWorker_Click);
            // 
            // toolMenuItemDelGroupWorker
            // 
            this.toolMenuItemDelGroupWorker.Image = global::ReferenceWorker.Properties.Resources.ElementDel;
            this.toolMenuItemDelGroupWorker.Name = "toolMenuItemDelGroupWorker";
            this.toolMenuItemDelGroupWorker.Size = new System.Drawing.Size(128, 22);
            this.toolMenuItemDelGroupWorker.Text = "Удалить";
            this.toolMenuItemDelGroupWorker.Click += new System.EventHandler(this.toolMenuItemDelGroupWorker_Click);
            // 
            // bsGroupWorker
            // 
            this.bsGroupWorker.DataMember = "tL_ClassifierWorker";
            this.bsGroupWorker.DataSource = this.dsWorker;
            // 
            // toolStripGroup
            // 
            this.toolStripGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripGroup.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripGroup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddGroup,
            this.toolBtnEditGroup,
            this.toolBtnDelGroup});
            this.toolStripGroup.Location = new System.Drawing.Point(3, 3);
            this.toolStripGroup.Name = "toolStripGroup";
            this.toolStripGroup.Size = new System.Drawing.Size(24, 103);
            this.toolStripGroup.TabIndex = 1;
            this.toolStripGroup.Text = "toolStrip1";
            // 
            // toolBtnAddGroup
            // 
            this.toolBtnAddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddGroup.Image = global::ReferenceWorker.Properties.Resources.ElementAdd;
            this.toolBtnAddGroup.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnAddGroup.Name = "toolBtnAddGroup";
            this.toolBtnAddGroup.Size = new System.Drawing.Size(21, 20);
            this.toolBtnAddGroup.Text = "Доабвить";
            this.toolBtnAddGroup.Click += new System.EventHandler(this.toolBtnAddGroup_Click);
            // 
            // toolBtnEditGroup
            // 
            this.toolBtnEditGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEditGroup.Image = global::ReferenceWorker.Properties.Resources.ElementEdit;
            this.toolBtnEditGroup.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnEditGroup.Name = "toolBtnEditGroup";
            this.toolBtnEditGroup.Size = new System.Drawing.Size(21, 20);
            this.toolBtnEditGroup.Text = "Редактировать";
            this.toolBtnEditGroup.Click += new System.EventHandler(this.toolBtnEditGroup_Click);
            // 
            // toolBtnDelGroup
            // 
            this.toolBtnDelGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelGroup.Image = global::ReferenceWorker.Properties.Resources.ElementDel;
            this.toolBtnDelGroup.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnDelGroup.Name = "toolBtnDelGroup";
            this.toolBtnDelGroup.Size = new System.Drawing.Size(21, 20);
            this.toolBtnDelGroup.Text = "Удалить";
            this.toolBtnDelGroup.Click += new System.EventHandler(this.toolBtnDelGroup_Click);
            // 
            // tabPageGroupElectrical
            // 
            this.tabPageGroupElectrical.Controls.Add(this.dgvGroupElectrical);
            this.tabPageGroupElectrical.Controls.Add(this.panel1);
            this.tabPageGroupElectrical.Controls.Add(this.toolStripGroupElectrical);
            this.tabPageGroupElectrical.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroupElectrical.Name = "tabPageGroupElectrical";
            this.tabPageGroupElectrical.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroupElectrical.Size = new System.Drawing.Size(631, 109);
            this.tabPageGroupElectrical.TabIndex = 3;
            this.tabPageGroupElectrical.Text = "Группа допуска";
            this.tabPageGroupElectrical.UseVisualStyleBackColor = true;
            // 
            // dgvGroupElectrical
            // 
            this.dgvGroupElectrical.AllowUserToAddRows = false;
            this.dgvGroupElectrical.AllowUserToDeleteRows = false;
            this.dgvGroupElectrical.AutoGenerateColumns = false;
            this.dgvGroupElectrical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroupElectrical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDgvGroupElectricalColumn,
            this.idWorkerDataGridViewTextBoxColumn1,
            this.dateBeginDataGridViewTextBoxColumn1,
            this.dateEndDataGridViewTextBoxColumn,
            this.groupElectricalDataGridViewTextBoxColumn});
            this.dgvGroupElectrical.ContextMenuStrip = this.contextMenuGroupElectrical;
            this.dgvGroupElectrical.DataSource = this.bsElectrical;
            this.dgvGroupElectrical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGroupElectrical.Location = new System.Drawing.Point(27, 3);
            this.dgvGroupElectrical.MultiSelect = false;
            this.dgvGroupElectrical.Name = "dgvGroupElectrical";
            this.dgvGroupElectrical.ReadOnly = true;
            this.dgvGroupElectrical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGroupElectrical.Size = new System.Drawing.Size(466, 103);
            this.dgvGroupElectrical.TabIndex = 0;
            // 
            // idDgvGroupElectricalColumn
            // 
            this.idDgvGroupElectricalColumn.DataPropertyName = "id";
            this.idDgvGroupElectricalColumn.HeaderText = "id";
            this.idDgvGroupElectricalColumn.Name = "idDgvGroupElectricalColumn";
            this.idDgvGroupElectricalColumn.ReadOnly = true;
            this.idDgvGroupElectricalColumn.Visible = false;
            // 
            // idWorkerDataGridViewTextBoxColumn1
            // 
            this.idWorkerDataGridViewTextBoxColumn1.DataPropertyName = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn1.HeaderText = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn1.Name = "idWorkerDataGridViewTextBoxColumn1";
            this.idWorkerDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idWorkerDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dateBeginDataGridViewTextBoxColumn1
            // 
            this.dateBeginDataGridViewTextBoxColumn1.DataPropertyName = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn1.HeaderText = "Дата начала";
            this.dateBeginDataGridViewTextBoxColumn1.Name = "dateBeginDataGridViewTextBoxColumn1";
            this.dateBeginDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "Дата окончания";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateEndDataGridViewTextBoxColumn.Width = 120;
            // 
            // groupElectricalDataGridViewTextBoxColumn
            // 
            this.groupElectricalDataGridViewTextBoxColumn.DataPropertyName = "GroupElectrical";
            this.groupElectricalDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.groupElectricalDataGridViewTextBoxColumn.Name = "groupElectricalDataGridViewTextBoxColumn";
            this.groupElectricalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contextMenuGroupElectrical
            // 
            this.contextMenuGroupElectrical.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuAddGroupElectrical,
            this.toolMenuEditGroupElectrical,
            this.toolMenuDelGroupElectrical});
            this.contextMenuGroupElectrical.Name = "contextMenuGroupElectrical";
            this.contextMenuGroupElectrical.Size = new System.Drawing.Size(129, 70);
            // 
            // toolMenuAddGroupElectrical
            // 
            this.toolMenuAddGroupElectrical.Image = global::ReferenceWorker.Properties.Resources.ElementAdd;
            this.toolMenuAddGroupElectrical.Name = "toolMenuAddGroupElectrical";
            this.toolMenuAddGroupElectrical.Size = new System.Drawing.Size(128, 22);
            this.toolMenuAddGroupElectrical.Text = "Добавить";
            this.toolMenuAddGroupElectrical.Click += new System.EventHandler(this.toolMenuAddGroupElectrical_Click);
            // 
            // toolMenuEditGroupElectrical
            // 
            this.toolMenuEditGroupElectrical.Image = global::ReferenceWorker.Properties.Resources.ElementEdit;
            this.toolMenuEditGroupElectrical.Name = "toolMenuEditGroupElectrical";
            this.toolMenuEditGroupElectrical.Size = new System.Drawing.Size(128, 22);
            this.toolMenuEditGroupElectrical.Text = "Изменить";
            this.toolMenuEditGroupElectrical.Click += new System.EventHandler(this.toolMenuEditGroupElectrical_Click);
            // 
            // toolMenuDelGroupElectrical
            // 
            this.toolMenuDelGroupElectrical.Image = global::ReferenceWorker.Properties.Resources.ElementDel;
            this.toolMenuDelGroupElectrical.Name = "toolMenuDelGroupElectrical";
            this.toolMenuDelGroupElectrical.Size = new System.Drawing.Size(128, 22);
            this.toolMenuDelGroupElectrical.Text = "Удалить";
            this.toolMenuDelGroupElectrical.Click += new System.EventHandler(this.toolMenuDelGroupElectrical_Click);
            // 
            // bsElectrical
            // 
            this.bsElectrical.DataMember = "tJ_GroupElectricalWorker";
            this.bsElectrical.DataSource = this.dsWorker;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCurrentgroupElectrical);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(493, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 103);
            this.panel1.TabIndex = 2;
            // 
            // txtCurrentgroupElectrical
            // 
            this.txtCurrentgroupElectrical.Location = new System.Drawing.Point(3, 30);
            this.txtCurrentgroupElectrical.Name = "txtCurrentgroupElectrical";
            this.txtCurrentgroupElectrical.ReadOnly = true;
            this.txtCurrentgroupElectrical.Size = new System.Drawing.Size(129, 20);
            this.txtCurrentgroupElectrical.TabIndex = 1;
            this.txtCurrentgroupElectrical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущая группа";
            // 
            // toolStripGroupElectrical
            // 
            this.toolStripGroupElectrical.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripGroupElectrical.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripGroupElectrical.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddGroupElectrical,
            this.toolBtnEditGroupElectrical,
            this.toolBtnDelGroupElectrical});
            this.toolStripGroupElectrical.Location = new System.Drawing.Point(3, 3);
            this.toolStripGroupElectrical.Name = "toolStripGroupElectrical";
            this.toolStripGroupElectrical.Size = new System.Drawing.Size(24, 103);
            this.toolStripGroupElectrical.TabIndex = 1;
            this.toolStripGroupElectrical.Text = "toolStrip1";
            // 
            // toolBtnAddGroupElectrical
            // 
            this.toolBtnAddGroupElectrical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddGroupElectrical.Image = global::ReferenceWorker.Properties.Resources.ElementAdd;
            this.toolBtnAddGroupElectrical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddGroupElectrical.Name = "toolBtnAddGroupElectrical";
            this.toolBtnAddGroupElectrical.Size = new System.Drawing.Size(21, 20);
            this.toolBtnAddGroupElectrical.Text = "Добавить группу допуска электробезопасности";
            this.toolBtnAddGroupElectrical.Click += new System.EventHandler(this.toolBtnAddGroupElectrical_Click);
            // 
            // toolBtnEditGroupElectrical
            // 
            this.toolBtnEditGroupElectrical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEditGroupElectrical.Image = global::ReferenceWorker.Properties.Resources.ElementEdit;
            this.toolBtnEditGroupElectrical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEditGroupElectrical.Name = "toolBtnEditGroupElectrical";
            this.toolBtnEditGroupElectrical.Size = new System.Drawing.Size(21, 20);
            this.toolBtnEditGroupElectrical.Text = "Редактировать группу допуска электробезопасности";
            this.toolBtnEditGroupElectrical.Click += new System.EventHandler(this.toolBtnEditGroupElectrical_Click);
            // 
            // toolBtnDelGroupElectrical
            // 
            this.toolBtnDelGroupElectrical.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelGroupElectrical.Image = global::ReferenceWorker.Properties.Resources.ElementDel;
            this.toolBtnDelGroupElectrical.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelGroupElectrical.Name = "toolBtnDelGroupElectrical";
            this.toolBtnDelGroupElectrical.Size = new System.Drawing.Size(21, 20);
            this.toolBtnDelGroupElectrical.Text = "Удалить группу допуска";
            this.toolBtnDelGroupElectrical.Click += new System.EventHandler(this.toolBtnDelGroupElectrical_Click);
            // 
            // FormWorkers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 543);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.toolStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWorkers";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.FormWorkers_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            this.splitContainerMain.ResumeLayout(false);
            this.tabControlTree.ResumeLayout(false);
            this.tabPageDivision.ResumeLayout(false);
            this.tabPageDivision.PerformLayout();
            this.toolStripTreeDivision.ResumeLayout(false);
            this.toolStripTreeDivision.PerformLayout();
            this.tabPageJobTitles.ResumeLayout(false);
            this.tabPageJobTitles.PerformLayout();
            this.toolStripTreeJobTiltes.ResumeLayout(false);
            this.toolStripTreeJobTiltes.PerformLayout();
            this.tabPageGroupWorkerTree.ResumeLayout(false);
            this.tabPageGroupWorkerTree.PerformLayout();
            this.toolStripTreeGroupWorker.ResumeLayout(false);
            this.toolStripTreeGroupWorker.PerformLayout();
            this.splitContainerGrid.Panel1.ResumeLayout(false);
            this.splitContainerGrid.Panel2.ResumeLayout(false);
            this.splitContainerGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorker)).EndInit();
            this.contextMenuStripWorker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsWorker)).EndInit();
            this.tabControlWorkerDetail.ResumeLayout(false);
            this.tabPageWorkerContact.ResumeLayout(false);
            this.tabPageWorkerContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContact)).EndInit();
            this.contextMenuStripContact.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsContact)).EndInit();
            this.toolStripContact.ResumeLayout(false);
            this.toolStripContact.PerformLayout();
            this.tabPageWorkerHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            this.contextMenuStripHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsHistory)).EndInit();
            this.tabPageGroupWorker.ResumeLayout(false);
            this.tabPageGroupWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupWorker)).EndInit();
            this.contextMenuGroupWorker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupWorker)).EndInit();
            this.toolStripGroup.ResumeLayout(false);
            this.toolStripGroup.PerformLayout();
            this.tabPageGroupElectrical.ResumeLayout(false);
            this.tabPageGroupElectrical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroupElectrical)).EndInit();
            this.contextMenuGroupElectrical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsElectrical)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripGroupElectrical.ResumeLayout(false);
            this.toolStripGroupElectrical.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.ComponentModel.IContainer components=null;

		private System.Windows.Forms.ToolStrip toolStripMain;

		private System.Windows.Forms.SplitContainer splitContainerMain;

		private System.Windows.Forms.TabControl tabControlTree;

		private System.Windows.Forms.TabPage tabPageDivision;

		private System.Windows.Forms.TabPage tabPageJobTitles;

		private System.Windows.Forms.SplitContainer splitContainerGrid;

		private System.Windows.Forms.ImageList imageList;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvWorker;

		private System.Windows.Forms.TreeView treeViewDivision;

		private ReferenceWorker.DataSetWorker dsWorker;

		private System.Windows.Forms.BindingSource bsWorker;

		private System.Windows.Forms.ToolStrip toolStripTreeDivision;

		private System.Windows.Forms.ToolStripButton toolBtnShowDeleteDivision;

		private System.Windows.Forms.ToolStripTextBox toolTxtFindTreeDivision;

		private System.Windows.Forms.ToolStripButton toolBtnFindTreeDivision;

		private System.Windows.Forms.ToolStripButton toolBtnCloseDivision;

		private System.Windows.Forms.TreeView treeViewJobTitles;

		private System.Windows.Forms.ToolStrip toolStripTreeJobTiltes;

		private System.Windows.Forms.ToolStripButton toolBtnShowDeleteJobTitles;

		private System.Windows.Forms.ToolStripTextBox toolTxtFindTreeJobTitles;

		private System.Windows.Forms.ToolStripButton toolBtnFindTreeJobTitles;

		private System.Windows.Forms.ToolStripButton toolBtnCloseJobTitles;

		private System.Windows.Forms.ToolStripButton toolBtnShowDivision;

		private System.Windows.Forms.ToolStripButton toolBtnShowJobTitle;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripButton toolBtnShowWorkerDelete;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		private System.Windows.Forms.TabControl tabControlWorkerDetail;

		private System.Windows.Forms.TabPage tabPageWorkerContact;

		private System.Windows.Forms.TabPage tabPageWorkerHistory;

		private System.Windows.Forms.BindingSource bsHistory;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvHistory;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewComboBoxColumn statusDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn workerDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewComboBoxColumn divisionDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewComboBoxColumn jobTitleDataGridViewTextBoxColumn1;

		private System.Windows.Forms.ToolStripButton toolStripButtonFind;

		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		private System.Windows.Forms.BindingSource bsContact;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvContact;

		private System.Windows.Forms.ToolStripButton toolStripButtonPrint;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;

		private System.Windows.Forms.ContextMenuStrip contextMenuStripWorker;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemCopyWorker;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemExportToExcelWorker;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemPrintWorker;

		private System.Windows.Forms.ContextMenuStrip contextMenuStripHistory;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemCopyHistory;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemExportToExcelHistory;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemPrintHistory;

		private System.Windows.Forms.ContextMenuStrip contextMenuStripContact;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemAddContact;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemEditContact;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelContact;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemCopyContact;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemExportToExcelContact;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemPrintContact;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDgvWorkerTextBoxColumn;

		private System.Windows.Forms.DataGridViewImageColumn iDRRefDataGridViewImageColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn fDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn iDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn oDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewComboBoxColumn jobTitleDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewComboBoxColumn divisionCurrentDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn divisionDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDgvTextBoxColumn;

		private System.Windows.Forms.TabPage tabPageGroupWorker;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvGroupWorker;

		private System.Windows.Forms.TabPage tabPageGroupWorkerTree;

		private System.Windows.Forms.ToolStripButton toolBtnShowGroupWorker;

		private System.Windows.Forms.TreeView treeViewGroupWorker;

		private System.Windows.Forms.ToolStrip toolStripTreeGroupWorker;

		private System.Windows.Forms.ToolStripButton toolBtnShowDeleteGroupWorker;

		private System.Windows.Forms.ToolStripTextBox toolTxtFindTreeGroupWorker;

		private System.Windows.Forms.ToolStripButton toolBtnFindTreeGroupWorker;

		private System.Windows.Forms.ToolStripButton toolBtnCloseGRoupWorker;

		private System.Windows.Forms.BindingSource bsGroupWorker;

		private System.Windows.Forms.ContextMenuStrip contextMenuGroupWorker;

		private System.Windows.Forms.ToolStripMenuItem toolManuItemAddGroupWorker;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelGroupWorker;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemEditGroupWorker;

		private System.Windows.Forms.ToolStrip toolStripGroup;

		private System.Windows.Forms.ToolStripButton toolBtnAddGroup;

		private System.Windows.Forms.ToolStripButton toolBtnDelGroup;

		private System.Windows.Forms.ToolStripButton toolBtnEditGroup;

		private System.Windows.Forms.TabPage tabPageGroupElectrical;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvGroupElectrical;

		private System.Windows.Forms.Panel panel1;

		private System.Windows.Forms.ToolStrip toolStripGroupElectrical;

		private System.Windows.Forms.ToolStripButton toolBtnAddGroupElectrical;

		private System.Windows.Forms.ToolStripButton toolBtnEditGroupElectrical;

		private System.Windows.Forms.ToolStripButton toolBtnDelGroupElectrical;

		private System.Windows.Forms.BindingSource bsElectrical;

		private System.Windows.Forms.Label label1;

		private System.Windows.Forms.ContextMenuStrip contextMenuGroupElectrical;

		private System.Windows.Forms.ToolStripMenuItem toolMenuAddGroupElectrical;

		private System.Windows.Forms.ToolStripMenuItem toolMenuEditGroupElectrical;

		private System.Windows.Forms.ToolStripMenuItem toolMenuDelGroupElectrical;

		private System.Windows.Forms.TextBox txtCurrentgroupElectrical;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDgvGroupElectricalColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn groupElectricalDataGridViewTextBoxColumn;

		private System.Windows.Forms.ToolStripMenuItem toolMenuAddWorker;

		private System.Windows.Forms.ToolStripMenuItem toolMenuEditWorker;

		private System.Windows.Forms.ToolStripMenuItem toolMenuDelWorker;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorEditWorker;

		private System.Windows.Forms.ToolStripMenuItem toolMenuDateEndWorker;

		private System.Windows.Forms.ToolStripMenuItem toolMenuDelFullWorker;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;

		private System.Windows.Forms.DataGridViewComboBoxColumn idGroupDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		private System.Windows.Forms.ToolStripButton toolBtnPadez;

		private System.Windows.Forms.ToolStrip toolStripContact;

		private System.Windows.Forms.ToolStripButton toolBtnAddContact;

		private System.Windows.Forms.ToolStripButton toolBtnEditContact;

		private System.Windows.Forms.ToolStripButton toolBtnDelContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn kadrExportDgvCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnComment;
    }
}
