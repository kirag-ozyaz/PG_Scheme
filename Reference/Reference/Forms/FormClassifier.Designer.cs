namespace Reference.Forms
{
	public partial class FormClassifier : FormLbr.FormBase
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.icontainer_0 = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode = new System.Windows.Forms.TreeNode("Все элементы", -2, -2);
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Reference.Forms.FormClassifier));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataTable_0 = new System.Data.DataTable();
			this.dataColumn_0 = new System.Data.DataColumn();
			this.dataColumn_1 = new System.Data.DataColumn();
			this.dataColumn_2 = new System.Data.DataColumn();
			this.dataColumn_3 = new System.Data.DataColumn();
			this.dataColumn_4 = new System.Data.DataColumn();
			this.dataColumn_5 = new System.Data.DataColumn();
			this.dataColumn_6 = new System.Data.DataColumn();
			this.dataColumn_7 = new System.Data.DataColumn();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.treeView = new System.Windows.Forms.TreeView();
			this.imageList_0 = new System.Windows.Forms.ImageList(this.icontainer_0);
			this.toolStripTree = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonCloseTree = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonHideElement = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonHideDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonTreeFind = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.dgvExcelFilter = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
			this.nameDgvTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.socrNameDgvTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ParentKeyDgvTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.parentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.otherIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deletedDgvCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.IsGroup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.idDgvTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.columnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
			this.contextMenuStripTree = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItemGridAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemGridAddGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemGridAddElement = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemGridEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemGridDel = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemGridDelCheck = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemGridDelFull = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemGridCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemGridExport = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemGridPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.class48_0 = new Class48();
			this.labelComment = new System.Windows.Forms.Label();
			this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonAddGroup = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonAddElement = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonDeleteFull = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonHideToolTree = new System.Windows.Forms.ToolStripButton();
			this.contextMenuStripTree_1 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItemTreeAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTreeAddGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTreeAddElement = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTreeEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTreeDel = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTreeDelCheck = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemTreeDelFull = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.toolStripTree.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvExcelFilter).BeginInit();
			this.contextMenuStripTree.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class48_0).BeginInit();
			this.toolStripMain.SuspendLayout();
			this.contextMenuStripTree_1.SuspendLayout();
			base.SuspendLayout();
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 25);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Panel1.Controls.Add(this.treeView);
			this.splitContainer.Panel1.Controls.Add(this.toolStripTree);
			this.splitContainer.Panel2.Controls.Add(this.dgvExcelFilter);
			this.splitContainer.Panel2.Controls.Add(this.labelComment);
			this.splitContainer.Panel2.Controls.Add(this.richTextBoxComment);
			this.splitContainer.Size = new System.Drawing.Size(693, 409);
			this.splitContainer.SplitterDistance = 233;
			this.splitContainer.TabIndex = 0;
			this.treeView.AllowDrop = true;
			this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView.ImageIndex = 0;
			this.treeView.ImageList = this.imageList_0;
			this.treeView.Location = new System.Drawing.Point(0, 25);
			this.treeView.Name = "treeView";
			treeNode.ImageIndex = -2;
			treeNode.Name = "Node0";
			treeNode.SelectedImageIndex = -2;
			treeNode.Text = "Все элементы";
			this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[]
			{
				treeNode
			});
			this.treeView.SelectedImageIndex = 0;
			this.treeView.Size = new System.Drawing.Size(233, 384);
			this.treeView.TabIndex = 0;
			this.treeView.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterCollapse);
			this.treeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterExpand);
			this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
			this.treeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDown);
			this.imageList_0.ImageStream = (System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList.ImageStream");
			this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList_0.Images.SetKeyName(0, "FolderDocumentYellow.png");
			this.imageList_0.Images.SetKeyName(1, "Element.png");
			this.imageList_0.Images.SetKeyName(2, "ElementDelete.png");
			this.imageList_0.Images.SetKeyName(3, "FolderOpenYellow.png");
			this.imageList_0.Images.SetKeyName(4, "FolderDeleteYellow.png");
			this.imageList_0.Images.SetKeyName(5, "FolderLockedYellow.png");
			this.imageList_0.Images.SetKeyName(6, "FolderParentYellow.png");
			this.imageList_0.Images.SetKeyName(7, "FolderYellow.png");
			this.toolStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripButtonCloseTree,
				this.toolStripButtonHideElement,
				this.toolStripButtonHideDelete,
				this.toolStripSeparator1,
				this.toolStripTextBoxFind,
				this.toolStripButtonTreeFind,
				this.toolStripSeparator2
			});
			this.toolStripTree.Location = new System.Drawing.Point(0, 0);
			this.toolStripTree.Name = "toolStripTree";
			this.toolStripTree.Size = new System.Drawing.Size(233, 25);
			this.toolStripTree.TabIndex = 1;
			this.toolStripTree.Text = "toolStrip2";
			this.toolStripButtonCloseTree.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButtonCloseTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonCloseTree.Image = Reference.Properties.Resources.smethod_5();
			this.toolStripButtonCloseTree.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonCloseTree.Name = "toolStripButtonCloseTree";
			this.toolStripButtonCloseTree.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonCloseTree.Text = "Закрыть";
			this.toolStripButtonCloseTree.Click += new System.EventHandler(this.toolStripButtonCloseTree_Click);
			this.toolStripButtonHideElement.Checked = true;
			this.toolStripButtonHideElement.CheckOnClick = true;
			this.toolStripButtonHideElement.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripButtonHideElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonHideElement.Image = Reference.Properties.Resources.smethod_26();
			this.toolStripButtonHideElement.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonHideElement.Name = "toolStripButtonHideElement";
			this.toolStripButtonHideElement.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonHideElement.Text = "Скрыть элементы";
			this.toolStripButtonHideElement.Click += new System.EventHandler(this.toolStripButtonHideElement_Click);
			this.toolStripButtonHideDelete.CheckOnClick = true;
			this.toolStripButtonHideDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonHideDelete.Image = Reference.Properties.Resources.smethod_24();
			this.toolStripButtonHideDelete.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonHideDelete.Name = "toolStripButtonHideDelete";
			this.toolStripButtonHideDelete.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonHideDelete.Text = "Показать удаленные";
			this.toolStripButtonHideDelete.Click += new System.EventHandler(this.toolStripButtonHideDelete_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
			this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBoxFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxFind_KeyDown);
			this.toolStripButtonTreeFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonTreeFind.Image = Reference.Properties.Resources.smethod_14();
			this.toolStripButtonTreeFind.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonTreeFind.Name = "toolStripButtonTreeFind";
			this.toolStripButtonTreeFind.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonTreeFind.Text = "Поиск";
			this.toolStripButtonTreeFind.Click += new System.EventHandler(this.toolStripButtonTreeFind_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			this.dgvExcelFilter.AllowUserToAddRows = false;
			this.dgvExcelFilter.AllowUserToDeleteRows = false;
			this.dgvExcelFilter.AllowUserToOrderColumns = true;
			this.dgvExcelFilter.AllowUserToResizeRows = false;
			this.dgvExcelFilter.AllowUserToVisibleColumns = false;
			this.dgvExcelFilter.AutoGenerateColumns = false;
			this.dgvExcelFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvExcelFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.nameDgvTextBoxColumn,
				this.socrNameDgvTextBoxColumn,
				this.valueDataGridViewTextBoxColumn,
				this.ParentKeyDgvTextBoxColumn,
				this.parentIdDataGridViewTextBoxColumn,
				this.otherIdDataGridViewTextBoxColumn,
				this.deletedDgvCheckBoxColumn,
				this.IsGroup,
				this.idDgvTextBoxColumn,
				this.columnImage
			});
			this.dgvExcelFilter.ContextMenuStrip = this.contextMenuStripTree;
			this.dgvExcelFilter.DataSource = this.bindingSource_0;
			this.dgvExcelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvExcelFilter.Location = new System.Drawing.Point(0, 0);
			this.dgvExcelFilter.Name = "dgvExcelFilter";
			this.dgvExcelFilter.ReadOnly = true;
			this.dgvExcelFilter.RowHeadersWidth = 21;
			this.dgvExcelFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvExcelFilter.Size = new System.Drawing.Size(456, 326);
			this.dgvExcelFilter.TabIndex = 0;
			this.dgvExcelFilter.VirtualMode = true;
			this.dgvExcelFilter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExcelFilter_CellDoubleClick);
			this.dgvExcelFilter.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvExcelFilter_CellFormatting);
			this.dgvExcelFilter.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvExcelFilter_CellValueNeeded);
			this.nameDgvTextBoxColumn.DataPropertyName = "Name";
			this.nameDgvTextBoxColumn.HeaderText = "Наименоваие";
			this.nameDgvTextBoxColumn.Name = "nameDgvTextBoxColumn";
			this.nameDgvTextBoxColumn.ReadOnly = true;
			this.nameDgvTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.nameDgvTextBoxColumn.Width = 150;
			this.socrNameDgvTextBoxColumn.DataPropertyName = "SocrName";
			this.socrNameDgvTextBoxColumn.HeaderText = "Сокр.";
			this.socrNameDgvTextBoxColumn.Name = "socrNameDgvTextBoxColumn";
			this.socrNameDgvTextBoxColumn.ReadOnly = true;
			this.socrNameDgvTextBoxColumn.Width = 50;
			this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
			this.valueDataGridViewTextBoxColumn.HeaderText = "Значение";
			this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
			this.valueDataGridViewTextBoxColumn.ReadOnly = true;
			this.valueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ParentKeyDgvTextBoxColumn.DataPropertyName = "ParentKey";
			this.ParentKeyDgvTextBoxColumn.HeaderText = "Ключ";
			this.ParentKeyDgvTextBoxColumn.Name = "ParentKeyDgvTextBoxColumn";
			this.ParentKeyDgvTextBoxColumn.ReadOnly = true;
			this.parentIdDataGridViewTextBoxColumn.DataPropertyName = "ParentId";
			this.parentIdDataGridViewTextBoxColumn.HeaderText = "ParentId";
			this.parentIdDataGridViewTextBoxColumn.Name = "parentIdDataGridViewTextBoxColumn";
			this.parentIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.parentIdDataGridViewTextBoxColumn.Visible = false;
			this.otherIdDataGridViewTextBoxColumn.DataPropertyName = "OtherId";
			this.otherIdDataGridViewTextBoxColumn.HeaderText = "OtherId";
			this.otherIdDataGridViewTextBoxColumn.Name = "otherIdDataGridViewTextBoxColumn";
			this.otherIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.otherIdDataGridViewTextBoxColumn.Visible = false;
			this.deletedDgvCheckBoxColumn.DataPropertyName = "Deleted";
			this.deletedDgvCheckBoxColumn.HeaderText = "Deleted";
			this.deletedDgvCheckBoxColumn.Name = "deletedDgvCheckBoxColumn";
			this.deletedDgvCheckBoxColumn.ReadOnly = true;
			this.deletedDgvCheckBoxColumn.Visible = false;
			this.IsGroup.DataPropertyName = "IsGroup";
			this.IsGroup.HeaderText = "IsGroup";
			this.IsGroup.Name = "IsGroup";
			this.IsGroup.ReadOnly = true;
			this.IsGroup.Visible = false;
			this.idDgvTextBoxColumn.DataPropertyName = "Id";
			this.idDgvTextBoxColumn.HeaderText = "Id";
			this.idDgvTextBoxColumn.Name = "idDgvTextBoxColumn";
			this.idDgvTextBoxColumn.ReadOnly = true;
			this.columnImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle.NullValue = null;
			this.columnImage.DefaultCellStyle = dataGridViewCellStyle;
			this.columnImage.HeaderText = "";
			this.columnImage.Name = "columnImage";
			this.columnImage.ReadOnly = true;
			this.columnImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.columnImage.Width = 21;
			this.contextMenuStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemGridAdd,
				this.toolStripMenuItemGridEdit,
				this.toolStripMenuItemGridDel,
				this.toolStripSeparator7,
				this.toolStripMenuItemGridCopy,
				this.toolStripMenuItemGridExport,
				this.toolStripMenuItemGridPrint
			});
			this.contextMenuStripTree.Name = "contextMenuStripTree";
			this.contextMenuStripTree.Size = new System.Drawing.Size(187, 142);
			this.toolStripMenuItemGridAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemGridAddGroup,
				this.toolStripMenuItemGridAddElement
			});
			this.toolStripMenuItemGridAdd.Image = Reference.Properties.Resources.smethod_2();
			this.toolStripMenuItemGridAdd.Name = "toolStripMenuItemGridAdd";
			this.toolStripMenuItemGridAdd.Size = new System.Drawing.Size(186, 22);
			this.toolStripMenuItemGridAdd.Text = "Добавить";
			this.toolStripMenuItemGridAddGroup.Image = Reference.Properties.Resources.smethod_17();
			this.toolStripMenuItemGridAddGroup.Name = "toolStripMenuItemGridAddGroup";
			this.toolStripMenuItemGridAddGroup.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItemGridAddGroup.Text = "Группу";
			this.toolStripMenuItemGridAddGroup.Click += new System.EventHandler(this.toolStripMenuItemGridAddGroup_Click);
			this.toolStripMenuItemGridAddElement.Image = Reference.Properties.Resources.smethod_9();
			this.toolStripMenuItemGridAddElement.Name = "toolStripMenuItemGridAddElement";
			this.toolStripMenuItemGridAddElement.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItemGridAddElement.Text = "Элемент";
			this.toolStripMenuItemGridAddElement.Click += new System.EventHandler(this.toolStripMenuItemGridAddElement_Click);
			this.toolStripMenuItemGridEdit.Image = Reference.Properties.Resources.smethod_4();
			this.toolStripMenuItemGridEdit.Name = "toolStripMenuItemGridEdit";
			this.toolStripMenuItemGridEdit.Size = new System.Drawing.Size(186, 22);
			this.toolStripMenuItemGridEdit.Text = "Изменить";
			this.toolStripMenuItemGridEdit.Click += new System.EventHandler(this.toolStripMenuItemGridEdit_Click);
			this.toolStripMenuItemGridDel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemGridDelCheck,
				this.toolStripMenuItemGridDelFull
			});
			this.toolStripMenuItemGridDel.Image = Reference.Properties.Resources.smethod_3();
			this.toolStripMenuItemGridDel.Name = "toolStripMenuItemGridDel";
			this.toolStripMenuItemGridDel.Size = new System.Drawing.Size(186, 22);
			this.toolStripMenuItemGridDel.Text = "Удалить";
			this.toolStripMenuItemGridDelCheck.Name = "toolStripMenuItemGridDelCheck";
			this.toolStripMenuItemGridDelCheck.Size = new System.Drawing.Size(198, 22);
			this.toolStripMenuItemGridDelCheck.Text = "Пометить на удаление";
			this.toolStripMenuItemGridDelCheck.Click += new System.EventHandler(this.toolStripMenuItemGridDelCheck_Click);
			this.toolStripMenuItemGridDelFull.Name = "toolStripMenuItemGridDelFull";
			this.toolStripMenuItemGridDelFull.Size = new System.Drawing.Size(198, 22);
			this.toolStripMenuItemGridDelFull.Text = "Удалить полностью";
			this.toolStripMenuItemGridDelFull.Click += new System.EventHandler(this.toolStripMenuItemGridDelFull_Click);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(183, 6);
			this.toolStripMenuItemGridCopy.Image = Reference.Properties.Resources.smethod_6();
			this.toolStripMenuItemGridCopy.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripMenuItemGridCopy.Name = "toolStripMenuItemGridCopy";
			this.toolStripMenuItemGridCopy.Size = new System.Drawing.Size(186, 22);
			this.toolStripMenuItemGridCopy.Text = "Копировать в буфер";
			this.toolStripMenuItemGridCopy.Click += new System.EventHandler(this.toolStripMenuItemGridCopy_Click);
			this.toolStripMenuItemGridExport.Image = Reference.Properties.Resources.smethod_13();
			this.toolStripMenuItemGridExport.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripMenuItemGridExport.Name = "toolStripMenuItemGridExport";
			this.toolStripMenuItemGridExport.Size = new System.Drawing.Size(186, 22);
			this.toolStripMenuItemGridExport.Text = "Экспорт в Excel";
			this.toolStripMenuItemGridExport.Click += new System.EventHandler(this.toolStripMenuItemGridExport_Click);
			this.toolStripMenuItemGridPrint.Image = Reference.Properties.Resources.smethod_22();
			this.toolStripMenuItemGridPrint.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripMenuItemGridPrint.Name = "toolStripMenuItemGridPrint";
			this.toolStripMenuItemGridPrint.Size = new System.Drawing.Size(186, 22);
			this.toolStripMenuItemGridPrint.Text = "Печать";
			this.toolStripMenuItemGridPrint.Click += new System.EventHandler(this.toolStripMenuItemGridPrint_Click);
			this.bindingSource_0.DataMember = "tR_Classifier";
			this.bindingSource_0.DataSource = this.class48_0;
			this.class48_0.DataSetName = "NewDataSet";
			this.class48_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.labelComment.AutoSize = true;
			this.labelComment.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labelComment.Location = new System.Drawing.Point(0, 326);
			this.labelComment.Name = "labelComment";
			this.labelComment.Size = new System.Drawing.Size(77, 13);
			this.labelComment.TabIndex = 2;
			this.labelComment.Text = "Комментарий";
			this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "Comment", true));
			this.richTextBoxComment.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.richTextBoxComment.Location = new System.Drawing.Point(0, 339);
			this.richTextBoxComment.Name = "richTextBoxComment";
			this.richTextBoxComment.ReadOnly = true;
			this.richTextBoxComment.Size = new System.Drawing.Size(456, 70);
			this.richTextBoxComment.TabIndex = 1;
			this.richTextBoxComment.Text = "";
			this.toolStripMain.BackColor = System.Drawing.SystemColors.Control;
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripButtonAddGroup,
				this.toolStripButtonAddElement,
				this.toolStripButtonEdit,
				this.toolStripButtonDelete,
				this.toolStripButtonDeleteFull,
				this.toolStripSeparator3,
				this.toolStripButtonPrint,
				this.toolStripSeparator4,
				this.toolStripButtonExcel,
				this.toolStripSeparator5,
				this.toolStripButtonRefresh,
				this.toolStripSeparator6,
				this.toolStripButtonHideToolTree
			});
			this.toolStripMain.Location = new System.Drawing.Point(0, 0);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Size = new System.Drawing.Size(693, 25);
			this.toolStripMain.TabIndex = 1;
			this.toolStripMain.Text = "toolStrip1";
			this.toolStripButtonAddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAddGroup.Image = Reference.Properties.Resources.smethod_17();
			this.toolStripButtonAddGroup.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonAddGroup.Name = "toolStripButtonAddGroup";
			this.toolStripButtonAddGroup.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonAddGroup.Text = "Добавить группу";
			this.toolStripButtonAddGroup.Click += new System.EventHandler(this.toolStripButtonAddGroup_Click);
			this.toolStripButtonAddElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonAddElement.Image = Reference.Properties.Resources.smethod_9();
			this.toolStripButtonAddElement.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonAddElement.Name = "toolStripButtonAddElement";
			this.toolStripButtonAddElement.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonAddElement.Text = "Добавить элемент";
			this.toolStripButtonAddElement.Click += new System.EventHandler(this.toolStripButtonAddElement_Click);
			this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonEdit.Image = Reference.Properties.Resources.smethod_11();
			this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonEdit.Name = "toolStripButtonEdit";
			this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonEdit.Text = "Изменить";
			this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
			this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDelete.Image = Reference.Properties.Resources.smethod_8();
			this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonDelete.Name = "toolStripButtonDelete";
			this.toolStripButtonDelete.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonDelete.Text = "Удалить";
			this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
			this.toolStripButtonDeleteFull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonDeleteFull.Image = Reference.Properties.Resources.smethod_10();
			this.toolStripButtonDeleteFull.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonDeleteFull.Name = "toolStripButtonDeleteFull";
			this.toolStripButtonDeleteFull.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonDeleteFull.Text = "Удалить полностью";
			this.toolStripButtonDeleteFull.Click += new System.EventHandler(this.toolStripButtonDeleteFull_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPrint.Image = Reference.Properties.Resources.smethod_22();
			this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonPrint.Name = "toolStripButtonPrint";
			this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonPrint.Text = "Печать";
			this.toolStripButtonPrint.Click += new System.EventHandler(this.EbjOqaSbwa);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExcel.Image = Reference.Properties.Resources.smethod_13();
			this.toolStripButtonExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonExcel.Name = "toolStripButtonExcel";
			this.toolStripButtonExcel.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonExcel.Text = "Экспорт в Excel";
			this.toolStripButtonExcel.Click += new System.EventHandler(this.toolStripButtonExcel_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRefresh.Image = Reference.Properties.Resources.smethod_23();
			this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
			this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonRefresh.Text = "Обновить справочник";
			this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonHideToolTree.Checked = true;
			this.toolStripButtonHideToolTree.CheckOnClick = true;
			this.toolStripButtonHideToolTree.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripButtonHideToolTree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonHideToolTree.Image = Reference.Properties.Resources.smethod_25();
			this.toolStripButtonHideToolTree.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonHideToolTree.Name = "toolStripButtonHideToolTree";
			this.toolStripButtonHideToolTree.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonHideToolTree.Text = "Скрыть панель дерева";
			this.toolStripButtonHideToolTree.Click += new System.EventHandler(this.toolStripButtonHideToolTree_Click);
			this.contextMenuStripTree_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemTreeAdd,
				this.toolStripMenuItemTreeEdit,
				this.toolStripMenuItemTreeDel
			});
			this.contextMenuStripTree_1.Name = "contextMenuStripTree";
			this.contextMenuStripTree_1.Size = new System.Drawing.Size(129, 70);
			this.contextMenuStripTree_1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripTree_1_Opening);
			this.toolStripMenuItemTreeAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemTreeAddGroup,
				this.toolStripMenuItemTreeAddElement
			});
			this.toolStripMenuItemTreeAdd.Image = Reference.Properties.Resources.smethod_2();
			this.toolStripMenuItemTreeAdd.Name = "toolStripMenuItemTreeAdd";
			this.toolStripMenuItemTreeAdd.Size = new System.Drawing.Size(128, 22);
			this.toolStripMenuItemTreeAdd.Text = "Добавить";
			this.toolStripMenuItemTreeAddGroup.Image = Reference.Properties.Resources.smethod_17();
			this.toolStripMenuItemTreeAddGroup.Name = "toolStripMenuItemTreeAddGroup";
			this.toolStripMenuItemTreeAddGroup.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItemTreeAddGroup.Text = "Группу";
			this.toolStripMenuItemTreeAddGroup.Click += new System.EventHandler(this.toolStripMenuItemTreeAddGroup_Click);
			this.toolStripMenuItemTreeAddElement.Image = Reference.Properties.Resources.smethod_9();
			this.toolStripMenuItemTreeAddElement.Name = "toolStripMenuItemTreeAddElement";
			this.toolStripMenuItemTreeAddElement.Size = new System.Drawing.Size(121, 22);
			this.toolStripMenuItemTreeAddElement.Text = "Элемент";
			this.toolStripMenuItemTreeAddElement.Click += new System.EventHandler(this.toolStripMenuItemTreeAddElement_Click);
			this.toolStripMenuItemTreeEdit.Image = Reference.Properties.Resources.smethod_4();
			this.toolStripMenuItemTreeEdit.Name = "toolStripMenuItemTreeEdit";
			this.toolStripMenuItemTreeEdit.Size = new System.Drawing.Size(128, 22);
			this.toolStripMenuItemTreeEdit.Text = "Изменить";
			this.toolStripMenuItemTreeEdit.Click += new System.EventHandler(this.toolStripMenuItemTreeEdit_Click);
			this.toolStripMenuItemTreeDel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemTreeDelCheck,
				this.toolStripMenuItemTreeDelFull
			});
			this.toolStripMenuItemTreeDel.Image = Reference.Properties.Resources.smethod_3();
			this.toolStripMenuItemTreeDel.Name = "toolStripMenuItemTreeDel";
			this.toolStripMenuItemTreeDel.Size = new System.Drawing.Size(128, 22);
			this.toolStripMenuItemTreeDel.Text = "Удалить";
			this.toolStripMenuItemTreeDelCheck.Name = "toolStripMenuItemTreeDelCheck";
			this.toolStripMenuItemTreeDelCheck.Size = new System.Drawing.Size(198, 22);
			this.toolStripMenuItemTreeDelCheck.Text = "Пометить на удаление";
			this.toolStripMenuItemTreeDelCheck.Click += new System.EventHandler(this.toolStripMenuItemTreeDelCheck_Click);
			this.toolStripMenuItemTreeDelFull.Name = "toolStripMenuItemTreeDelFull";
			this.toolStripMenuItemTreeDelFull.Size = new System.Drawing.Size(198, 22);
			this.toolStripMenuItemTreeDelFull.Text = "Удалить полностью";
			this.toolStripMenuItemTreeDelFull.Click += new System.EventHandler(this.toolStripMenuItemTreeDelFull_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(693, 434);
			base.Controls.Add(this.splitContainer);
			base.Controls.Add(this.toolStripMain);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.Name = "FormClassifier";
			base.PermissionsSql = false;
			this.Text = "Общий классификатор";
			base.Load += new System.EventHandler(this.FormClassifier_Load);
			base.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormClassifier_KeyDown);
			((System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			this.splitContainer.ResumeLayout(false);
			this.toolStripTree.ResumeLayout(false);
			this.toolStripTree.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvExcelFilter).EndInit();
			this.contextMenuStripTree.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class48_0).EndInit();
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.contextMenuStripTree_1.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private Class48 class48_0;

		private System.Data.DataTable dataTable_0;

		private System.Data.DataColumn dataColumn_0;

		private System.Data.DataColumn dataColumn_1;

		private System.Data.DataColumn dataColumn_2;

		private System.Data.DataColumn dataColumn_3;

		private System.Data.DataColumn dataColumn_4;

		private System.Data.DataColumn dataColumn_5;

		private System.Windows.Forms.BindingSource bindingSource_0;

		private System.Windows.Forms.SplitContainer splitContainer;

		private System.Windows.Forms.TreeView treeView;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvExcelFilter;

		private System.Data.DataColumn dataColumn_6;

		private System.Windows.Forms.ImageList imageList_0;

		private System.Windows.Forms.ToolStrip toolStripMain;

		private System.Windows.Forms.ToolStrip toolStripTree;

		private System.Windows.Forms.ToolStripButton toolStripButtonCloseTree;

		private System.Windows.Forms.ToolStripButton toolStripButtonHideElement;

		private System.Windows.Forms.ToolStripButton toolStripButtonHideDelete;

		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;

		private System.Windows.Forms.ToolStripButton toolStripButtonTreeFind;

		private System.Windows.Forms.ToolStripButton toolStripButtonAddGroup;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		private System.Data.DataColumn dataColumn_7;

		private System.Windows.Forms.Label labelComment;

		private System.Windows.Forms.RichTextBox richTextBoxComment;

		private System.Windows.Forms.ToolStripButton toolStripButtonEdit;

		private System.Windows.Forms.ToolStripButton toolStripButtonAddElement;

		private System.Windows.Forms.ToolStripButton toolStripButtonDelete;

		private System.Windows.Forms.ToolStripButton toolStripButtonDeleteFull;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		private System.Windows.Forms.ToolStripButton toolStripButtonPrint;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		private System.Windows.Forms.ToolStripButton toolStripButtonExcel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		private System.Windows.Forms.ToolStripButton toolStripButtonHideToolTree;

		private System.Windows.Forms.ContextMenuStrip contextMenuStripTree_1;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTreeAdd;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTreeAddGroup;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTreeAddElement;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTreeEdit;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTreeDel;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTreeDelCheck;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTreeDelFull;

		private System.Windows.Forms.ContextMenuStrip contextMenuStripTree;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGridAdd;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGridAddGroup;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGridAddElement;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGridEdit;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGridDel;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGridDelCheck;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGridDelFull;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGridCopy;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGridExport;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemGridPrint;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull columnImage;

		private System.Windows.Forms.DataGridViewTextBoxColumn nameDgvTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn socrNameDgvTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn ParentKeyDgvTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn parentIdDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn otherIdDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDgvCheckBoxColumn;

		private System.Windows.Forms.DataGridViewCheckBoxColumn IsGroup;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDgvTextBoxColumn;
	}
}
