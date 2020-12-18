namespace ReferenceWorker
{
	public partial class FormDivisions : FormLbr.FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDivisions));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Все элементы");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDel = new System.Windows.Forms.ToolStripSplitButton();
            this.toolBtnDelRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnDelFull = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonHideDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHideTree = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFindNext = new System.Windows.Forms.ToolStripButton();
            this.StyrpKunvf = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList_0 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripTree = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxFindTree = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFindTree = new System.Windows.Forms.ToolStripButton();
            this.dgvExcelFilter = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.bs_Division = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new System.Data.DataSet();
            this.dataTable_0 = new System.Data.DataTable();
            this.dataColumn_0 = new System.Data.DataColumn();
            this.dataColumn_1 = new System.Data.DataColumn();
            this.dataColumn_2 = new System.Data.DataColumn();
            this.dataColumn_3 = new System.Data.DataColumn();
            this.dataColumn_4 = new System.Data.DataColumn();
            this.dataColumn_5 = new System.Data.DataColumn();
            this.dataColumn_6 = new System.Data.DataColumn();
            this.contMenuTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuDelRest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuDelFull = new System.Windows.Forms.ToolStripMenuItem();
            this.ColumnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
            this.idDgvTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRRefDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.parentIDRRefDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripMain.SuspendLayout();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.toolStripTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelFilter)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Division)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).BeginInit();
            this.contMenuTreeView.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAdd,
            this.toolBtnEdit,
            this.toolBtnDel,
            this.toolStripButtonHideDelete,
            this.toolStripButtonHideTree,
            this.toolStripSeparator3,
            this.toolStripButtonFind,
            this.toolStripTextBoxFind,
            this.toolStripButtonFindPrev,
            this.toolStripButtonFindNext,
            this.StyrpKunvf,
            this.toolStripButtonPrint,
            this.toolStripSeparator2,
            this.toolStripButtonExportExcel,
            this.toolStripSeparator4,
            this.toolStripButtonRefresh});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(590, 25);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolBtnAdd
            // 
            this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAdd.Image = global::ReferenceWorker.Properties.Resources.ElementAdd;
            this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAdd.Text = "Добавить подразделение";
            this.toolBtnAdd.Click += new System.EventHandler(this.toolMenuAdd_Click);
            // 
            // toolBtnEdit
            // 
            this.toolBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEdit.Image = global::ReferenceWorker.Properties.Resources.ElementEdit;
            this.toolBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEdit.Name = "toolBtnEdit";
            this.toolBtnEdit.Size = new System.Drawing.Size(23, 22);
            this.toolBtnEdit.Text = "Редактировать подразделение";
            this.toolBtnEdit.Click += new System.EventHandler(this.toolMenuEdit_Click);
            // 
            // toolBtnDel
            // 
            this.toolBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnDelRestore,
            this.toolBtnDelFull});
            this.toolBtnDel.Image = global::ReferenceWorker.Properties.Resources.ElementDel;
            this.toolBtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDel.Name = "toolBtnDel";
            this.toolBtnDel.Size = new System.Drawing.Size(32, 22);
            this.toolBtnDel.Text = "Удалить";
            // 
            // toolBtnDelRestore
            // 
            this.toolBtnDelRestore.Name = "toolBtnDelRestore";
            this.toolBtnDelRestore.Size = new System.Drawing.Size(198, 22);
            this.toolBtnDelRestore.Text = "Пометить на удаление";
            this.toolBtnDelRestore.Click += new System.EventHandler(this.toolMenuDelRest_Click);
            // 
            // toolBtnDelFull
            // 
            this.toolBtnDelFull.Name = "toolBtnDelFull";
            this.toolBtnDelFull.Size = new System.Drawing.Size(198, 22);
            this.toolBtnDelFull.Text = "Удалить полностью";
            this.toolBtnDelFull.Click += new System.EventHandler(this.toolMenuDelFull_Click);
            // 
            // toolStripButtonHideDelete
            // 
            this.toolStripButtonHideDelete.CheckOnClick = true;
            this.toolStripButtonHideDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHideDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHideDelete.Image")));
            this.toolStripButtonHideDelete.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonHideDelete.Name = "toolStripButtonHideDelete";
            this.toolStripButtonHideDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonHideDelete.Text = "Показать удаленных";
            this.toolStripButtonHideDelete.Click += new System.EventHandler(this.toolStripButtonHideDelete_Click);
            // 
            // toolStripButtonHideTree
            // 
            this.toolStripButtonHideTree.Checked = true;
            this.toolStripButtonHideTree.CheckOnClick = true;
            this.toolStripButtonHideTree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripButtonHideTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHideTree.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHideTree.Image")));
            this.toolStripButtonHideTree.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonHideTree.Name = "toolStripButtonHideTree";
            this.toolStripButtonHideTree.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonHideTree.Text = "Сркыть дерево";
            this.toolStripButtonHideTree.Click += new System.EventHandler(this.toolStripButtonHideTree_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFind.Image")));
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
            this.toolStripButtonFindPrev.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFindPrev.Image")));
            this.toolStripButtonFindPrev.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFindPrev.Name = "toolStripButtonFindPrev";
            this.toolStripButtonFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindPrev.Text = "Поиск назад";
            this.toolStripButtonFindPrev.Click += new System.EventHandler(this.toolStripButtonFindPrev_Click);
            // 
            // toolStripButtonFindNext
            // 
            this.toolStripButtonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindNext.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFindNext.Image")));
            this.toolStripButtonFindNext.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFindNext.Name = "toolStripButtonFindNext";
            this.toolStripButtonFindNext.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindNext.Text = "Поиск вперед";
            this.toolStripButtonFindNext.Click += new System.EventHandler(this.toolStripButtonFindNext_Click);
            // 
            // StyrpKunvf
            // 
            this.StyrpKunvf.Name = "StyrpKunvf";
            this.StyrpKunvf.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrint.Text = "Печать";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonExportExcel
            // 
            this.toolStripButtonExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExportExcel.Image")));
            this.toolStripButtonExportExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonExportExcel.Name = "toolStripButtonExportExcel";
            this.toolStripButtonExportExcel.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExportExcel.Text = "Экспорт в Excel";
            this.toolStripButtonExportExcel.Click += new System.EventHandler(this.toolStripButtonExportExcel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Обновить";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            this.splitContainer.Panel1.Controls.Add(this.toolStripTree);
            this.splitContainer.Panel1MinSize = 0;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dgvExcelFilter);
            this.splitContainer.Size = new System.Drawing.Size(590, 322);
            this.splitContainer.SplitterDistance = 190;
            this.splitContainer.TabIndex = 1;
            // 
            // treeView
            // 
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList_0;
            this.treeView.Location = new System.Drawing.Point(0, 25);
            this.treeView.Name = "treeView";
            treeNode1.Name = "Node0";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            treeNode1.Text = "Все элементы";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(190, 297);
            this.treeView.TabIndex = 1;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList_0
            // 
            this.imageList_0.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_0.ImageStream")));
            this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_0.Images.SetKeyName(0, "FolderDocumentYellow.png");
            this.imageList_0.Images.SetKeyName(1, "FolderDeleteYellow.png");
            this.imageList_0.Images.SetKeyName(2, "FolderYellow.png");
            // 
            // toolStripTree
            // 
            this.toolStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonClose,
            this.toolStripTextBoxFindTree,
            this.toolStripButtonFindTree});
            this.toolStripTree.Location = new System.Drawing.Point(0, 0);
            this.toolStripTree.Name = "toolStripTree";
            this.toolStripTree.Size = new System.Drawing.Size(190, 25);
            this.toolStripTree.TabIndex = 0;
            this.toolStripTree.Text = "toolStrip2";
            // 
            // toolStripButtonClose
            // 
            this.toolStripButtonClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonClose.Image")));
            this.toolStripButtonClose.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonClose.Name = "toolStripButtonClose";
            this.toolStripButtonClose.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonClose.Text = "Скрыть дерево";
            this.toolStripButtonClose.Click += new System.EventHandler(this.toolStripButtonClose_Click);
            // 
            // toolStripTextBoxFindTree
            // 
            this.toolStripTextBoxFindTree.Name = "toolStripTextBoxFindTree";
            this.toolStripTextBoxFindTree.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxFindTree.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxFindTree_KeyDown);
            // 
            // toolStripButtonFindTree
            // 
            this.toolStripButtonFindTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindTree.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFindTree.Image")));
            this.toolStripButtonFindTree.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFindTree.Name = "toolStripButtonFindTree";
            this.toolStripButtonFindTree.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindTree.Text = "Поиск";
            this.toolStripButtonFindTree.Click += new System.EventHandler(this.toolStripButtonFindTree_Click);
            // 
            // dgvExcelFilter
            // 
            this.dgvExcelFilter.AllowUserToAddRows = false;
            this.dgvExcelFilter.AllowUserToDeleteRows = false;
            this.dgvExcelFilter.AllowUserToVisibleColumns = false;
            this.dgvExcelFilter.AutoGenerateColumns = false;
            this.dgvExcelFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcelFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImage,
            this.idDgvTextBoxColumn,
            this.iDRRefDataGridViewImageColumn,
            this.parentIDRRefDataGridViewImageColumn,
            this.codeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.deletedDataGridViewCheckBoxColumn});
            this.dgvExcelFilter.ContextMenuStrip = this.contextMenuStrip;
            this.dgvExcelFilter.DataSource = this.bs_Division;
            this.dgvExcelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExcelFilter.Location = new System.Drawing.Point(0, 0);
            this.dgvExcelFilter.Name = "dgvExcelFilter";
            this.dgvExcelFilter.ReadOnly = true;
            this.dgvExcelFilter.RowHeadersWidth = 20;
            this.dgvExcelFilter.Size = new System.Drawing.Size(396, 322);
            this.dgvExcelFilter.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy,
            this.toolStripMenuItem_0,
            this.toolStripMenuItemPrint});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(158, 70);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopy.Image")));
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemCopy.Text = "Копировать";
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.toolStripMenuItemCopy_Click);
            // 
            // toolStripMenuItem_0
            // 
            this.toolStripMenuItem_0.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_0.Image")));
            this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
            this.toolStripMenuItem_0.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItem_0.Text = "Экспорт в Excel";
            this.toolStripMenuItem_0.Click += new System.EventHandler(this.toolStripMenuItem_0_Click);
            // 
            // toolStripMenuItemPrint
            // 
            this.toolStripMenuItemPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemPrint.Image")));
            this.toolStripMenuItemPrint.Name = "toolStripMenuItemPrint";
            this.toolStripMenuItemPrint.Size = new System.Drawing.Size(157, 22);
            this.toolStripMenuItemPrint.Text = "Печать";
            this.toolStripMenuItemPrint.Click += new System.EventHandler(this.toolStripMenuItemPrint_Click);
            // 
            // bs_Division
            // 
            this.bs_Division.DataMember = "k_tR_Division";
            this.bs_Division.DataSource = this.dataSet;
            this.bs_Division.Filter = "Deleted = false";
            this.bs_Division.Sort = "Description";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable_0});
            // 
            // dataTable_0
            // 
            this.dataTable_0.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn_0,
            this.dataColumn_1,
            this.dataColumn_2,
            this.dataColumn_3,
            this.dataColumn_4,
            this.dataColumn_5,
            this.dataColumn_6});
            this.dataTable_0.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Id"}, true)});
            this.dataTable_0.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn_0};
            this.dataTable_0.TableName = "k_tR_Division";
            // 
            // dataColumn_0
            // 
            this.dataColumn_0.AllowDBNull = false;
            this.dataColumn_0.AutoIncrement = true;
            this.dataColumn_0.ColumnName = "Id";
            this.dataColumn_0.DataType = typeof(int);
            // 
            // dataColumn_1
            // 
            this.dataColumn_1.ColumnName = "IDRRef";
            this.dataColumn_1.DataType = typeof(byte[]);
            // 
            // dataColumn_2
            // 
            this.dataColumn_2.ColumnName = "ParentIDRRef";
            this.dataColumn_2.DataType = typeof(byte[]);
            // 
            // dataColumn_3
            // 
            this.dataColumn_3.ColumnName = "Code";
            // 
            // dataColumn_4
            // 
            this.dataColumn_4.ColumnName = "Description";
            // 
            // dataColumn_5
            // 
            this.dataColumn_5.ColumnName = "Deleted";
            this.dataColumn_5.DataType = typeof(bool);
            // 
            // dataColumn_6
            // 
            this.dataColumn_6.ColumnName = "ParentID";
            this.dataColumn_6.DataType = typeof(int);
            // 
            // contMenuTreeView
            // 
            this.contMenuTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuAdd,
            this.toolMenuEdit,
            this.toolMenuDelRest,
            this.toolMenuDelFull});
            this.contMenuTreeView.Name = "contMenuTreeView";
            this.contMenuTreeView.Size = new System.Drawing.Size(199, 92);
            // 
            // toolMenuAdd
            // 
            this.toolMenuAdd.Image = global::ReferenceWorker.Properties.Resources.ElementAdd;
            this.toolMenuAdd.Name = "toolMenuAdd";
            this.toolMenuAdd.Size = new System.Drawing.Size(198, 22);
            this.toolMenuAdd.Text = "Добавить";
            this.toolMenuAdd.Click += new System.EventHandler(this.toolMenuAdd_Click);
            // 
            // toolMenuEdit
            // 
            this.toolMenuEdit.Image = global::ReferenceWorker.Properties.Resources.ElementEdit;
            this.toolMenuEdit.Name = "toolMenuEdit";
            this.toolMenuEdit.Size = new System.Drawing.Size(198, 22);
            this.toolMenuEdit.Text = "Редактировать";
            this.toolMenuEdit.Click += new System.EventHandler(this.toolMenuEdit_Click);
            // 
            // toolMenuDelRest
            // 
            this.toolMenuDelRest.Image = global::ReferenceWorker.Properties.Resources.Trash;
            this.toolMenuDelRest.Name = "toolMenuDelRest";
            this.toolMenuDelRest.Size = new System.Drawing.Size(198, 22);
            this.toolMenuDelRest.Text = "Пометить на удаление";
            this.toolMenuDelRest.Click += new System.EventHandler(this.toolMenuDelRest_Click);
            // 
            // toolMenuDelFull
            // 
            this.toolMenuDelFull.Image = global::ReferenceWorker.Properties.Resources.ElementDel;
            this.toolMenuDelFull.Name = "toolMenuDelFull";
            this.toolMenuDelFull.Size = new System.Drawing.Size(198, 22);
            this.toolMenuDelFull.Text = "Удалить полностью";
            this.toolMenuDelFull.Click += new System.EventHandler(this.toolMenuDelFull_Click);
            // 
            // ColumnImage
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnImage.HeaderText = "";
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Width = 16;
            // 
            // idDgvTextBoxColumn
            // 
            this.idDgvTextBoxColumn.DataPropertyName = "Id";
            this.idDgvTextBoxColumn.HeaderText = "Id";
            this.idDgvTextBoxColumn.Name = "idDgvTextBoxColumn";
            this.idDgvTextBoxColumn.ReadOnly = true;
            this.idDgvTextBoxColumn.Visible = false;
            // 
            // iDRRefDataGridViewImageColumn
            // 
            this.iDRRefDataGridViewImageColumn.DataPropertyName = "IDRRef";
            this.iDRRefDataGridViewImageColumn.HeaderText = "IDRRef";
            this.iDRRefDataGridViewImageColumn.Name = "iDRRefDataGridViewImageColumn";
            this.iDRRefDataGridViewImageColumn.ReadOnly = true;
            this.iDRRefDataGridViewImageColumn.Visible = false;
            // 
            // parentIDRRefDataGridViewImageColumn
            // 
            this.parentIDRRefDataGridViewImageColumn.DataPropertyName = "ParentIDRRef";
            this.parentIDRRefDataGridViewImageColumn.HeaderText = "ParentIDRRef";
            this.parentIDRRefDataGridViewImageColumn.Name = "parentIDRRefDataGridViewImageColumn";
            this.parentIDRRefDataGridViewImageColumn.ReadOnly = true;
            this.parentIDRRefDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.parentIDRRefDataGridViewImageColumn.Visible = false;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            this.codeDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 240;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.deletedDataGridViewCheckBoxColumn.Visible = false;
            // 
            // FormDivisions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 347);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDivisions";
            this.Text = "Подразделения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDivisions_FormClosing);
            this.Load += new System.EventHandler(this.FormDivisions_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.ResumeLayout(false);
            this.toolStripTree.ResumeLayout(false);
            this.toolStripTree.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelFilter)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_Division)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).EndInit();
            this.contMenuTreeView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.ComponentModel.IContainer components;

		private System.Windows.Forms.ToolStrip toolStripMain;

		private System.Windows.Forms.SplitContainer splitContainer;

		private System.Windows.Forms.TreeView treeView;

		private System.Windows.Forms.ToolStrip toolStripTree;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvExcelFilter;

		private System.Windows.Forms.ToolStripButton toolStripButtonClose;

		private System.Data.DataSet dataSet;

		private System.Data.DataTable dataTable_0;

		private System.Data.DataColumn dataColumn_0;

		private System.Data.DataColumn dataColumn_1;

		private System.Data.DataColumn dataColumn_2;

		private System.Data.DataColumn dataColumn_3;

		private System.Data.DataColumn dataColumn_4;

		private System.Data.DataColumn dataColumn_5;

		private System.Windows.Forms.BindingSource bs_Division;

		private System.Windows.Forms.ToolStripButton toolStripButtonHideDelete;

		private System.Data.DataColumn dataColumn_6;

		private System.Windows.Forms.ImageList imageList_0;

		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFindTree;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindTree;

		private System.Windows.Forms.ToolStripButton toolStripButtonHideTree;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		private System.Windows.Forms.ToolStripButton toolStripButtonFind;

		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;

		private System.Windows.Forms.ToolStripSeparator StyrpKunvf;

		private System.Windows.Forms.ToolStripButton toolStripButtonPrint;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPrint;

		private System.Windows.Forms.ToolStripButton toolBtnAdd;

		private System.Windows.Forms.ToolStripButton toolBtnEdit;

		private System.Windows.Forms.ToolStripSplitButton toolBtnDel;

		private System.Windows.Forms.ToolStripMenuItem toolBtnDelRestore;

		private System.Windows.Forms.ToolStripMenuItem toolBtnDelFull;

		private System.Windows.Forms.ContextMenuStrip contMenuTreeView;

		private System.Windows.Forms.ToolStripMenuItem toolMenuAdd;

		private System.Windows.Forms.ToolStripMenuItem toolMenuEdit;

		private System.Windows.Forms.ToolStripMenuItem toolMenuDelRest;

		private System.Windows.Forms.ToolStripMenuItem toolMenuDelFull;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull ColumnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDgvTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn iDRRefDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn parentIDRRefDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDataGridViewCheckBoxColumn;
    }
}
