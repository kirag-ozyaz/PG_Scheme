namespace Reference.Forms
{
	public partial class FormKladr : FormLbr.FormBase
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
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Reference.Forms.FormKladr));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.toolBtnAddPunkts = new System.Windows.Forms.ToolStripButton();
			this.toolBtnEditPunkts = new System.Windows.Forms.ToolStripButton();
			this.toolBtnDelPunkts = new System.Windows.Forms.ToolStripButton();
			this.toolBtnDelPunktsFull = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparatorPuntks = new System.Windows.Forms.ToolStripSeparator();
			this.toolBtnAddStreet = new System.Windows.Forms.ToolStripButton();
			this.toolBtnEditStreet = new System.Windows.Forms.ToolStripButton();
			this.toolBtnDelStreet = new System.Windows.Forms.ToolStripButton();
			this.toolBtnDelStreetFull = new System.Windows.Forms.ToolStripButton();
			this.toolSeparatorStreet = new System.Windows.Forms.ToolStripSeparator();
			this.toolBtnShowDelStreet = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.treeViewPunkts = new System.Windows.Forms.TreeView();
			this.imageList_0 = new System.Windows.Forms.ImageList();
			this.toolStripTree = new System.Windows.Forms.ToolStrip();
			this.toolBtnShowDeletePunkts = new System.Windows.Forms.ToolStripButton();
			this.toolTextBoxFindPunkts = new System.Windows.Forms.ToolStripTextBox();
			this.toolBtnFindPunkts = new System.Windows.Forms.ToolStripButton();
			this.splitContainerStreetAndHouse = new System.Windows.Forms.SplitContainer();
			this.dgvStreet = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
			this.ColumnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
			this.idColumnStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kladrObjIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.socrDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.kladrCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.indexDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.gNINMBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deletedDgvCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.contextMenuDgvStreet = new System.Windows.Forms.ContextMenuStrip();
			this.toolMenuItemAddStreet = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemEditStreet = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelGrid = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelStreet = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelStreetFull = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolMenuItemCopyGrid = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemExportExcel = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.bindingSource_0 = new System.Windows.Forms.BindingSource();
			this.yoidejFsp2 = new Class20();
			this.UhAdrOjTe0 = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
			this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.streetIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.korpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.socrDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.kladrCodeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.indexDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gNINMBDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource_1 = new System.Windows.Forms.BindingSource();
			this.labelDoma = new System.Windows.Forms.Label();
			this.contextMenuTreeView = new System.Windows.Forms.ContextMenuStrip();
			this.toolMenuItemAddTree = new System.Windows.Forms.ToolStripMenuItem();
			this.zfidCpbaOL = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemAddStreetTree = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemEditPunkt = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelTree = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelPunkt = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelPunktFull = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMain.SuspendLayout();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.toolStripTree.SuspendLayout();
			this.splitContainerStreetAndHouse.Panel1.SuspendLayout();
			this.splitContainerStreetAndHouse.Panel2.SuspendLayout();
			this.splitContainerStreetAndHouse.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvStreet).BeginInit();
			this.contextMenuDgvStreet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.yoidejFsp2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.UhAdrOjTe0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_1).BeginInit();
			this.contextMenuTreeView.SuspendLayout();
			base.SuspendLayout();
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnAddPunkts,
				this.toolBtnEditPunkts,
				this.toolBtnDelPunkts,
				this.toolBtnDelPunktsFull,
				this.toolStripSeparatorPuntks,
				this.toolBtnAddStreet,
				this.toolBtnEditStreet,
				this.toolBtnDelStreet,
				this.toolBtnDelStreetFull,
				this.toolSeparatorStreet,
				this.toolBtnShowDelStreet,
				this.toolStripSeparator1,
				this.toolStripButtonFind,
				this.toolStripTextBoxFind,
				this.toolStripButtonFindPrev,
				this.toolStripButtonFindNext,
				this.toolStripSeparator3,
				this.toolStripButtonPrint,
				this.toolStripSeparator4,
				this.toolStripButtonExportExcel,
				this.toolStripSeparator5,
				this.toolStripButtonRefresh
			});
			this.toolStripMain.Location = new System.Drawing.Point(0, 0);
			this.toolStripMain.Name = "toolStripMain";
			this.toolStripMain.Size = new System.Drawing.Size(690, 25);
			this.toolStripMain.TabIndex = 0;
			this.toolStripMain.Text = "toolStrip1";
			this.toolBtnAddPunkts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnAddPunkts.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnAddPunkts.Image");
			this.toolBtnAddPunkts.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnAddPunkts.Name = "toolBtnAddPunkts";
			this.toolBtnAddPunkts.Size = new System.Drawing.Size(23, 22);
			this.toolBtnAddPunkts.Text = "Добавить населенный пункт";
			this.toolBtnAddPunkts.Click += new System.EventHandler(this.toolBtnAddPunkts_Click);
			this.toolBtnEditPunkts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnEditPunkts.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnEditPunkts.Image");
			this.toolBtnEditPunkts.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnEditPunkts.Name = "toolBtnEditPunkts";
			this.toolBtnEditPunkts.Size = new System.Drawing.Size(23, 22);
			this.toolBtnEditPunkts.Text = "Редактировать населенный пункт";
			this.toolBtnEditPunkts.Click += new System.EventHandler(this.toolBtnEditPunkts_Click);
			this.toolBtnDelPunkts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDelPunkts.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnDelPunkts.Image");
			this.toolBtnDelPunkts.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDelPunkts.Name = "toolBtnDelPunkts";
			this.toolBtnDelPunkts.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDelPunkts.Text = "Пометить на удлаение";
			this.toolBtnDelPunkts.Click += new System.EventHandler(this.toolBtnDelPunkts_Click);
			this.toolBtnDelPunktsFull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDelPunktsFull.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnDelPunktsFull.Image");
			this.toolBtnDelPunktsFull.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDelPunktsFull.Name = "toolBtnDelPunktsFull";
			this.toolBtnDelPunktsFull.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDelPunktsFull.Text = "Удалить полностью";
			this.toolBtnDelPunktsFull.Click += new System.EventHandler(this.toolBtnDelPunktsFull_Click);
			this.toolStripSeparatorPuntks.Name = "toolStripSeparatorPuntks";
			this.toolStripSeparatorPuntks.Size = new System.Drawing.Size(6, 25);
			this.toolBtnAddStreet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnAddStreet.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnAddStreet.Image");
			this.toolBtnAddStreet.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnAddStreet.Name = "toolBtnAddStreet";
			this.toolBtnAddStreet.Size = new System.Drawing.Size(23, 22);
			this.toolBtnAddStreet.Text = "Добавить улицу";
			this.toolBtnAddStreet.Click += new System.EventHandler(this.toolBtnAddStreet_Click);
			this.toolBtnEditStreet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnEditStreet.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnEditStreet.Image");
			this.toolBtnEditStreet.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnEditStreet.Name = "toolBtnEditStreet";
			this.toolBtnEditStreet.Size = new System.Drawing.Size(23, 22);
			this.toolBtnEditStreet.Text = "Редактировать улицу";
			this.toolBtnEditStreet.Click += new System.EventHandler(this.toolBtnEditStreet_Click);
			this.toolBtnDelStreet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDelStreet.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnDelStreet.Image");
			this.toolBtnDelStreet.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDelStreet.Name = "toolBtnDelStreet";
			this.toolBtnDelStreet.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDelStreet.Text = "Пометить на удаление";
			this.toolBtnDelStreet.Click += new System.EventHandler(this.toolBtnDelStreet_Click);
			this.toolBtnDelStreetFull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDelStreetFull.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnDelStreetFull.Image");
			this.toolBtnDelStreetFull.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDelStreetFull.Name = "toolBtnDelStreetFull";
			this.toolBtnDelStreetFull.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDelStreetFull.Text = "Удалить улицу";
			this.toolBtnDelStreetFull.Click += new System.EventHandler(this.toolBtnDelStreetFull_Click);
			this.toolSeparatorStreet.Name = "toolSeparatorStreet";
			this.toolSeparatorStreet.Size = new System.Drawing.Size(6, 25);
			this.toolBtnShowDelStreet.CheckOnClick = true;
			this.toolBtnShowDelStreet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnShowDelStreet.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnShowDelStreet.Image");
			this.toolBtnShowDelStreet.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDelStreet.Name = "toolBtnShowDelStreet";
			this.toolBtnShowDelStreet.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDelStreet.Text = "Показать удаленные улицы";
			this.toolBtnShowDelStreet.Click += new System.EventHandler(this.toolBtnShowDelStreet_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFind.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonFind.Image");
			this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFind.Name = "toolStripButtonFind";
			this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFind.Text = "Поиск";
			this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
			this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
			this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBoxFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxFind_KeyDown);
			this.toolStripButtonFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFindPrev.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonFindPrev.Image");
			this.toolStripButtonFindPrev.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFindPrev.Name = "toolStripButtonFindPrev";
			this.toolStripButtonFindPrev.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFindPrev.Text = "Поиск назад";
			this.toolStripButtonFindPrev.Click += new System.EventHandler(this.toolStripButtonFindPrev_Click);
			this.toolStripButtonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFindNext.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonFindNext.Image");
			this.toolStripButtonFindNext.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFindNext.Name = "toolStripButtonFindNext";
			this.toolStripButtonFindNext.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFindNext.Text = "Поиск вперед";
			this.toolStripButtonFindNext.Click += new System.EventHandler(this.toolStripButtonFindNext_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPrint.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonPrint.Image");
			this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonPrint.Name = "toolStripButtonPrint";
			this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonPrint.Text = "Печать";
			this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExportExcel.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonExportExcel.Image");
			this.toolStripButtonExportExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonExportExcel.Name = "toolStripButtonExportExcel";
			this.toolStripButtonExportExcel.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonExportExcel.Text = "Экспорт в Excel";
			this.toolStripButtonExportExcel.Click += new System.EventHandler(this.toolStripButtonExportExcel_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRefresh.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonRefresh.Image");
			this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
			this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonRefresh.Text = "Обновить";
			this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
			this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMain.Location = new System.Drawing.Point(0, 25);
			this.splitContainerMain.Name = "splitContainerMain";
			this.splitContainerMain.Panel1.Controls.Add(this.treeViewPunkts);
			this.splitContainerMain.Panel1.Controls.Add(this.toolStripTree);
			this.splitContainerMain.Panel2.Controls.Add(this.splitContainerStreetAndHouse);
			this.splitContainerMain.Size = new System.Drawing.Size(690, 523);
			this.splitContainerMain.SplitterDistance = 206;
			this.splitContainerMain.TabIndex = 1;
			this.treeViewPunkts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewPunkts.ImageIndex = 0;
			this.treeViewPunkts.ImageList = this.imageList_0;
			this.treeViewPunkts.Location = new System.Drawing.Point(0, 25);
			this.treeViewPunkts.Name = "treeViewPunkts";
			this.treeViewPunkts.SelectedImageIndex = 0;
			this.treeViewPunkts.Size = new System.Drawing.Size(206, 498);
			this.treeViewPunkts.TabIndex = 0;
			this.treeViewPunkts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPunkts_AfterSelect);
			this.treeViewPunkts.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewPunkts_MouseDown);
			this.imageList_0.ImageStream = (System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList.ImageStream");
			this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList_0.Images.SetKeyName(0, "FolderDocumentYellow.png");
			this.imageList_0.Images.SetKeyName(1, "FolderDeleteYellow.png");
			this.imageList_0.Images.SetKeyName(2, "Element.png");
			this.imageList_0.Images.SetKeyName(3, "ElementDelete.png");
			this.toolStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnShowDeletePunkts,
				this.toolTextBoxFindPunkts,
				this.toolBtnFindPunkts
			});
			this.toolStripTree.Location = new System.Drawing.Point(0, 0);
			this.toolStripTree.Name = "toolStripTree";
			this.toolStripTree.Size = new System.Drawing.Size(206, 25);
			this.toolStripTree.TabIndex = 1;
			this.toolStripTree.Text = "toolStrip1";
			this.toolBtnShowDeletePunkts.CheckOnClick = true;
			this.toolBtnShowDeletePunkts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnShowDeletePunkts.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnShowDeletePunkts.Image");
			this.toolBtnShowDeletePunkts.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDeletePunkts.Name = "toolBtnShowDeletePunkts";
			this.toolBtnShowDeletePunkts.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDeletePunkts.Text = "Показать удаленных";
			this.toolBtnShowDeletePunkts.Click += new System.EventHandler(this.toolBtnShowDeletePunkts_Click);
			this.toolTextBoxFindPunkts.Name = "toolTextBoxFindPunkts";
			this.toolTextBoxFindPunkts.Size = new System.Drawing.Size(100, 25);
			this.toolTextBoxFindPunkts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTextBoxFindPunkts_KeyDown);
			this.toolBtnFindPunkts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnFindPunkts.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnFindPunkts.Image");
			this.toolBtnFindPunkts.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnFindPunkts.Name = "toolBtnFindPunkts";
			this.toolBtnFindPunkts.Size = new System.Drawing.Size(23, 22);
			this.toolBtnFindPunkts.Text = "Поиск по дереву";
			this.toolBtnFindPunkts.Click += new System.EventHandler(this.toolBtnFindPunkts_Click);
			this.splitContainerStreetAndHouse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerStreetAndHouse.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainerStreetAndHouse.Location = new System.Drawing.Point(0, 0);
			this.splitContainerStreetAndHouse.Name = "splitContainerStreetAndHouse";
			this.splitContainerStreetAndHouse.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.splitContainerStreetAndHouse.Panel1.Controls.Add(this.dgvStreet);
			this.splitContainerStreetAndHouse.Panel2.Controls.Add(this.UhAdrOjTe0);
			this.splitContainerStreetAndHouse.Panel2.Controls.Add(this.labelDoma);
			this.splitContainerStreetAndHouse.Size = new System.Drawing.Size(480, 523);
			this.splitContainerStreetAndHouse.SplitterDistance = 415;
			this.splitContainerStreetAndHouse.TabIndex = 1;
			this.dgvStreet.AllowUserToAddRows = false;
			this.dgvStreet.AllowUserToDeleteRows = false;
			this.dgvStreet.AllowUserToVisibleColumns = false;
			this.dgvStreet.AutoGenerateColumns = false;
			this.dgvStreet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStreet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.ColumnImage,
				this.idColumnStreet,
				this.kladrObjIdDataGridViewTextBoxColumn,
				this.nameDataGridViewTextBoxColumn,
				this.socrDataGridViewTextBoxColumn,
				this.kladrCodeDataGridViewTextBoxColumn,
				this.indexDataGridViewTextBoxColumn,
				this.gNINMBDataGridViewTextBoxColumn,
				this.deletedDgvCheckBoxColumn
			});
			this.dgvStreet.ContextMenuStrip = this.contextMenuDgvStreet;
			this.dgvStreet.DataSource = this.bindingSource_0;
			this.dgvStreet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvStreet.Location = new System.Drawing.Point(0, 0);
			this.dgvStreet.Name = "dgvStreet";
			this.dgvStreet.ReadOnly = true;
			this.dgvStreet.RowHeadersWidth = 21;
			this.dgvStreet.Size = new System.Drawing.Size(480, 415);
			this.dgvStreet.TabIndex = 0;
			this.dgvStreet.VirtualMode = true;
			this.dgvStreet.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvStreet_CellValueNeeded);
			dataGridViewCellStyle.NullValue = null;
			this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle;
			this.ColumnImage.HeaderText = "";
			this.ColumnImage.Name = "ColumnImage";
			this.ColumnImage.ReadOnly = true;
			this.ColumnImage.Width = 16;
			this.idColumnStreet.DataPropertyName = "Id";
			this.idColumnStreet.HeaderText = "Id";
			this.idColumnStreet.Name = "idColumnStreet";
			this.idColumnStreet.ReadOnly = true;
			this.idColumnStreet.Visible = false;
			this.kladrObjIdDataGridViewTextBoxColumn.DataPropertyName = "KladrObjId";
			this.kladrObjIdDataGridViewTextBoxColumn.HeaderText = "KladrObjId";
			this.kladrObjIdDataGridViewTextBoxColumn.Name = "kladrObjIdDataGridViewTextBoxColumn";
			this.kladrObjIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.kladrObjIdDataGridViewTextBoxColumn.Visible = false;
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.nameDataGridViewTextBoxColumn.Width = 150;
			this.socrDataGridViewTextBoxColumn.DataPropertyName = "Socr";
			this.socrDataGridViewTextBoxColumn.HeaderText = "Префикс";
			this.socrDataGridViewTextBoxColumn.Name = "socrDataGridViewTextBoxColumn";
			this.socrDataGridViewTextBoxColumn.ReadOnly = true;
			this.socrDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.socrDataGridViewTextBoxColumn.Width = 70;
			this.kladrCodeDataGridViewTextBoxColumn.DataPropertyName = "KladrCode";
			this.kladrCodeDataGridViewTextBoxColumn.HeaderText = "КЛАДР";
			this.kladrCodeDataGridViewTextBoxColumn.Name = "kladrCodeDataGridViewTextBoxColumn";
			this.kladrCodeDataGridViewTextBoxColumn.ReadOnly = true;
			this.kladrCodeDataGridViewTextBoxColumn.Visible = false;
			this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
			this.indexDataGridViewTextBoxColumn.HeaderText = "Индекс";
			this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
			this.indexDataGridViewTextBoxColumn.ReadOnly = true;
			this.indexDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.indexDataGridViewTextBoxColumn.Width = 70;
			this.gNINMBDataGridViewTextBoxColumn.DataPropertyName = "GNINMB";
			this.gNINMBDataGridViewTextBoxColumn.HeaderText = "GNINMB";
			this.gNINMBDataGridViewTextBoxColumn.Name = "gNINMBDataGridViewTextBoxColumn";
			this.gNINMBDataGridViewTextBoxColumn.ReadOnly = true;
			this.gNINMBDataGridViewTextBoxColumn.Visible = false;
			this.deletedDgvCheckBoxColumn.DataPropertyName = "Deleted";
			this.deletedDgvCheckBoxColumn.HeaderText = "Deleted";
			this.deletedDgvCheckBoxColumn.Name = "deletedDgvCheckBoxColumn";
			this.deletedDgvCheckBoxColumn.ReadOnly = true;
			this.deletedDgvCheckBoxColumn.Visible = false;
			this.contextMenuDgvStreet.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuItemAddStreet,
				this.toolMenuItemEditStreet,
				this.toolMenuItemDelGrid,
				this.toolStripSeparator2,
				this.toolMenuItemCopyGrid,
				this.toolMenuItemExportExcel,
				this.toolMenuItemPrint
			});
			this.contextMenuDgvStreet.Name = "contextMenuDgvStreet";
			this.contextMenuDgvStreet.Size = new System.Drawing.Size(158, 142);
			this.toolMenuItemAddStreet.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemAddStreet.Image");
			this.toolMenuItemAddStreet.Name = "toolMenuItemAddStreet";
			this.toolMenuItemAddStreet.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemAddStreet.Text = "Добавить";
			this.toolMenuItemAddStreet.Click += new System.EventHandler(this.toolMenuItemAddStreet_Click);
			this.toolMenuItemEditStreet.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemEditStreet.Image");
			this.toolMenuItemEditStreet.Name = "toolMenuItemEditStreet";
			this.toolMenuItemEditStreet.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemEditStreet.Text = "Редактировать";
			this.toolMenuItemEditStreet.Click += new System.EventHandler(this.toolMenuItemEditStreet_Click);
			this.toolMenuItemDelGrid.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuItemDelStreet,
				this.toolMenuItemDelStreetFull
			});
			this.toolMenuItemDelGrid.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemDelGrid.Image");
			this.toolMenuItemDelGrid.Name = "toolMenuItemDelGrid";
			this.toolMenuItemDelGrid.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemDelGrid.Text = "Удалить";
			this.toolMenuItemDelStreet.Name = "toolMenuItemDelStreet";
			this.toolMenuItemDelStreet.Size = new System.Drawing.Size(198, 22);
			this.toolMenuItemDelStreet.Text = "Пометить на удаление";
			this.toolMenuItemDelStreet.Click += new System.EventHandler(this.toolMenuItemDelStreet_Click);
			this.toolMenuItemDelStreetFull.Name = "toolMenuItemDelStreetFull";
			this.toolMenuItemDelStreetFull.Size = new System.Drawing.Size(198, 22);
			this.toolMenuItemDelStreetFull.Text = "Удалить полностью";
			this.toolMenuItemDelStreetFull.Click += new System.EventHandler(this.toolMenuItemDelStreetFull_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
			this.toolMenuItemCopyGrid.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemCopyGrid.Image");
			this.toolMenuItemCopyGrid.Name = "toolMenuItemCopyGrid";
			this.toolMenuItemCopyGrid.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemCopyGrid.Text = "Копировать";
			this.toolMenuItemCopyGrid.Click += new System.EventHandler(this.toolMenuItemCopyGrid_Click);
			this.toolMenuItemExportExcel.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemExportExcel.Image");
			this.toolMenuItemExportExcel.Name = "toolMenuItemExportExcel";
			this.toolMenuItemExportExcel.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemExportExcel.Text = "Экспорт в Excel";
			this.toolMenuItemExportExcel.Click += new System.EventHandler(this.toolMenuItemExportExcel_Click);
			this.toolMenuItemPrint.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemPrint.Image");
			this.toolMenuItemPrint.Name = "toolMenuItemPrint";
			this.toolMenuItemPrint.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemPrint.Text = "Печать";
			this.toolMenuItemPrint.Click += new System.EventHandler(this.toolMenuItemPrint_Click);
			this.bindingSource_0.DataMember = "tR_KladrStreet";
			this.bindingSource_0.DataSource = this.yoidejFsp2;
			this.bindingSource_0.Filter = "Deleted = false";
			this.yoidejFsp2.DataSetName = "DataSetKladr";
			this.yoidejFsp2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.UhAdrOjTe0.AllowUserToAddRows = false;
			this.UhAdrOjTe0.AllowUserToDeleteRows = false;
			this.UhAdrOjTe0.AllowUserToVisibleColumns = false;
			this.UhAdrOjTe0.AutoGenerateColumns = false;
			this.UhAdrOjTe0.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UhAdrOjTe0.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idDataGridViewTextBoxColumn1,
				this.streetIdDataGridViewTextBoxColumn,
				this.nameDataGridViewTextBoxColumn1,
				this.korpDataGridViewTextBoxColumn,
				this.socrDataGridViewTextBoxColumn1,
				this.kladrCodeDataGridViewTextBoxColumn1,
				this.indexDataGridViewTextBoxColumn1,
				this.gNINMBDataGridViewTextBoxColumn1
			});
			this.UhAdrOjTe0.DataSource = this.bindingSource_1;
			this.UhAdrOjTe0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UhAdrOjTe0.Location = new System.Drawing.Point(0, 13);
			this.UhAdrOjTe0.Name = "dgvDoma";
			this.UhAdrOjTe0.ReadOnly = true;
			this.UhAdrOjTe0.RowHeadersWidth = 20;
			this.UhAdrOjTe0.Size = new System.Drawing.Size(480, 91);
			this.UhAdrOjTe0.TabIndex = 0;
			this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
			this.idDataGridViewTextBoxColumn1.ReadOnly = true;
			this.idDataGridViewTextBoxColumn1.Visible = false;
			this.streetIdDataGridViewTextBoxColumn.DataPropertyName = "StreetId";
			this.streetIdDataGridViewTextBoxColumn.HeaderText = "StreetId";
			this.streetIdDataGridViewTextBoxColumn.Name = "streetIdDataGridViewTextBoxColumn";
			this.streetIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.streetIdDataGridViewTextBoxColumn.Visible = false;
			this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
			this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
			this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
			this.korpDataGridViewTextBoxColumn.DataPropertyName = "Korp";
			this.korpDataGridViewTextBoxColumn.HeaderText = "Корпус";
			this.korpDataGridViewTextBoxColumn.Name = "korpDataGridViewTextBoxColumn";
			this.korpDataGridViewTextBoxColumn.ReadOnly = true;
			this.socrDataGridViewTextBoxColumn1.DataPropertyName = "Socr";
			this.socrDataGridViewTextBoxColumn1.HeaderText = "Префикс";
			this.socrDataGridViewTextBoxColumn1.Name = "socrDataGridViewTextBoxColumn1";
			this.socrDataGridViewTextBoxColumn1.ReadOnly = true;
			this.kladrCodeDataGridViewTextBoxColumn1.DataPropertyName = "KladrCode";
			this.kladrCodeDataGridViewTextBoxColumn1.HeaderText = "KladrCode";
			this.kladrCodeDataGridViewTextBoxColumn1.Name = "kladrCodeDataGridViewTextBoxColumn1";
			this.kladrCodeDataGridViewTextBoxColumn1.ReadOnly = true;
			this.kladrCodeDataGridViewTextBoxColumn1.Visible = false;
			this.indexDataGridViewTextBoxColumn1.DataPropertyName = "Index";
			this.indexDataGridViewTextBoxColumn1.HeaderText = "Индекс";
			this.indexDataGridViewTextBoxColumn1.Name = "indexDataGridViewTextBoxColumn1";
			this.indexDataGridViewTextBoxColumn1.ReadOnly = true;
			this.gNINMBDataGridViewTextBoxColumn1.DataPropertyName = "GNINMB";
			this.gNINMBDataGridViewTextBoxColumn1.HeaderText = "GNINMB";
			this.gNINMBDataGridViewTextBoxColumn1.Name = "gNINMBDataGridViewTextBoxColumn1";
			this.gNINMBDataGridViewTextBoxColumn1.ReadOnly = true;
			this.gNINMBDataGridViewTextBoxColumn1.Visible = false;
			this.bindingSource_1.DataMember = "tR_KladrStreet_tR_KladrDoma";
			this.bindingSource_1.DataSource = this.bindingSource_0;
			this.labelDoma.AutoSize = true;
			this.labelDoma.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelDoma.Location = new System.Drawing.Point(0, 0);
			this.labelDoma.Name = "labelDoma";
			this.labelDoma.Size = new System.Drawing.Size(122, 13);
			this.labelDoma.TabIndex = 1;
			this.labelDoma.Text = "Классификатор домов";
			this.contextMenuTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuItemAddTree,
				this.toolMenuItemEditPunkt,
				this.toolMenuItemDelTree
			});
			this.contextMenuTreeView.Name = "contextMenuTreeView";
			this.contextMenuTreeView.Size = new System.Drawing.Size(155, 70);
			this.contextMenuTreeView.Text = "Котенкстное меню дерева";
			this.toolMenuItemAddTree.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.zfidCpbaOL,
				this.toolMenuItemAddStreetTree
			});
			this.toolMenuItemAddTree.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemAddTree.Image");
			this.toolMenuItemAddTree.Name = "toolMenuItemAddTree";
			this.toolMenuItemAddTree.Size = new System.Drawing.Size(154, 22);
			this.toolMenuItemAddTree.Text = "Добавить";
			this.zfidCpbaOL.Name = "toolMenuItemAddPunktTree";
			this.zfidCpbaOL.Size = new System.Drawing.Size(178, 22);
			this.zfidCpbaOL.Text = "Населенный пункт";
			this.zfidCpbaOL.Click += new System.EventHandler(this.zfidCpbaOL_Click);
			this.toolMenuItemAddStreetTree.Name = "toolMenuItemAddStreetTree";
			this.toolMenuItemAddStreetTree.Size = new System.Drawing.Size(178, 22);
			this.toolMenuItemAddStreetTree.Text = "Улицу";
			this.toolMenuItemAddStreetTree.Click += new System.EventHandler(this.zenlJaxyjH);
			this.toolMenuItemEditPunkt.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemEditPunkt.Image");
			this.toolMenuItemEditPunkt.Name = "toolMenuItemEditPunkt";
			this.toolMenuItemEditPunkt.Size = new System.Drawing.Size(154, 22);
			this.toolMenuItemEditPunkt.Text = "Редактировать";
			this.toolMenuItemEditPunkt.Click += new System.EventHandler(this.toolMenuItemEditPunkt_Click);
			this.toolMenuItemDelTree.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuItemDelPunkt,
				this.toolMenuItemDelPunktFull
			});
			this.toolMenuItemDelTree.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemDelTree.Image");
			this.toolMenuItemDelTree.Name = "toolMenuItemDelTree";
			this.toolMenuItemDelTree.Size = new System.Drawing.Size(154, 22);
			this.toolMenuItemDelTree.Text = "Удалить";
			this.toolMenuItemDelPunkt.Name = "toolMenuItemDelPunkt";
			this.toolMenuItemDelPunkt.Size = new System.Drawing.Size(198, 22);
			this.toolMenuItemDelPunkt.Text = "Пометить на удаление";
			this.toolMenuItemDelPunkt.Click += new System.EventHandler(this.toolMenuItemDelPunkt_Click);
			this.toolMenuItemDelPunktFull.Name = "toolMenuItemDelPunktFull";
			this.toolMenuItemDelPunktFull.Size = new System.Drawing.Size(198, 22);
			this.toolMenuItemDelPunktFull.Text = "Удалить полностью";
			this.toolMenuItemDelPunktFull.Click += new System.EventHandler(this.toolMenuItemDelPunktFull_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(690, 548);
			base.Controls.Add(this.splitContainerMain);
			base.Controls.Add(this.toolStripMain);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormKladr";
			this.Text = "Классификатор адресов";
			base.Load += new System.EventHandler(this.FormKladr_Load);
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.splitContainerMain.Panel1.ResumeLayout(false);
			this.splitContainerMain.Panel1.PerformLayout();
			this.splitContainerMain.Panel2.ResumeLayout(false);
			this.splitContainerMain.ResumeLayout(false);
			this.toolStripTree.ResumeLayout(false);
			this.toolStripTree.PerformLayout();
			this.splitContainerStreetAndHouse.Panel1.ResumeLayout(false);
			this.splitContainerStreetAndHouse.Panel2.ResumeLayout(false);
			this.splitContainerStreetAndHouse.Panel2.PerformLayout();
			this.splitContainerStreetAndHouse.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvStreet).EndInit();
			this.contextMenuDgvStreet.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.yoidejFsp2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.UhAdrOjTe0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_1).EndInit();
			this.contextMenuTreeView.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.ToolStrip toolStripMain;

		private System.Windows.Forms.SplitContainer splitContainerMain;

		private System.Windows.Forms.TreeView treeViewPunkts;

		private Class20 yoidejFsp2;

		private System.Windows.Forms.BindingSource bindingSource_0;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvStreet;

		private System.Windows.Forms.ToolStrip toolStripTree;

		private System.Windows.Forms.ToolStripButton toolBtnShowDeletePunkts;

		private System.Windows.Forms.ToolStripTextBox toolTextBoxFindPunkts;

		private System.Windows.Forms.ToolStripButton toolBtnFindPunkts;

		private System.Windows.Forms.ImageList imageList_0;

		private System.Windows.Forms.ToolStripButton toolBtnAddPunkts;

		private System.Windows.Forms.ToolStripButton toolBtnEditPunkts;

		private System.Windows.Forms.ToolStripButton toolBtnDelPunkts;

		private System.Windows.Forms.ToolStripButton toolBtnDelPunktsFull;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorPuntks;

		private System.Windows.Forms.SplitContainer splitContainerStreetAndHouse;

		private System.Windows.Forms.BindingSource bindingSource_1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter UhAdrOjTe0;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewTextBoxColumn streetIdDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewTextBoxColumn korpDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn socrDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewTextBoxColumn kladrCodeDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn1;

		private System.Windows.Forms.DataGridViewTextBoxColumn gNINMBDataGridViewTextBoxColumn1;

		private System.Windows.Forms.Label labelDoma;

		private System.Windows.Forms.ToolStripButton toolBtnAddStreet;

		private System.Windows.Forms.ToolStripButton toolBtnEditStreet;

		private System.Windows.Forms.ToolStripButton toolBtnDelStreet;

		private System.Windows.Forms.ToolStripButton toolBtnDelStreetFull;

		private System.Windows.Forms.ToolStripSeparator toolSeparatorStreet;

		private System.Windows.Forms.ToolStripButton toolBtnShowDelStreet;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull ColumnImage;

		private System.Windows.Forms.DataGridViewTextBoxColumn idColumnStreet;

		private System.Windows.Forms.DataGridViewTextBoxColumn kladrObjIdDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn socrDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn kladrCodeDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn indexDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn gNINMBDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDgvCheckBoxColumn;

		private System.Windows.Forms.ToolStripButton toolStripButtonFind;

		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		private System.Windows.Forms.ToolStripButton toolStripButtonPrint;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;

		private System.Windows.Forms.ContextMenuStrip contextMenuTreeView;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemAddTree;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemEditPunkt;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelTree;

		private System.Windows.Forms.ToolStripMenuItem zfidCpbaOL;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemAddStreetTree;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelPunkt;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelPunktFull;

		private System.Windows.Forms.ContextMenuStrip contextMenuDgvStreet;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemAddStreet;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemEditStreet;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelGrid;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelStreet;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelStreetFull;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemCopyGrid;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemExportExcel;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemPrint;
	}
}
