namespace Reference.Forms
{
	public partial class FormTrans : FormLbr.FormBase
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
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Reference.Forms.FormTrans));
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
			this.toolBtnEdit = new System.Windows.Forms.ToolStripButton();
			this.toolBtnDel = new System.Windows.Forms.ToolStripButton();
			this.ilScgFvUxM = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolBtnShowDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.RpecwghYhT = new System.Windows.Forms.ToolStripButton();
			this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonFindPrev = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonFindNext = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.vaDcdbdUsK = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
			this.DaWcrtsonX = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDel = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemDelCheck = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemDelFull = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemExportToExcel = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStripPicture = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItemSavePicture = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.treeView = new System.Windows.Forms.TreeView();
			this.TdJcIkLix0 = new System.Windows.Forms.SplitContainer();
			this.dgvCounter = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
			this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.class37_0 = new Class37();
			this.splitContainerComment = new System.Windows.Forms.SplitContainer();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.idDgvTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDgvTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.primaryDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.secondaryDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.precisionDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.intervalDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.typeTransDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deletedDgvCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.toolStrip.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.contextMenuStripPicture.SuspendLayout();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.TdJcIkLix0.Panel1.SuspendLayout();
			this.TdJcIkLix0.Panel2.SuspendLayout();
			this.TdJcIkLix0.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvCounter).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).BeginInit();
			this.splitContainerComment.Panel1.SuspendLayout();
			this.splitContainerComment.Panel2.SuspendLayout();
			this.splitContainerComment.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.pictureBox).BeginInit();
			base.SuspendLayout();
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnAdd,
				this.toolBtnEdit,
				this.toolBtnDel,
				this.ilScgFvUxM,
				this.toolStripSeparator1,
				this.toolBtnShowDelete,
				this.toolStripSeparator2,
				this.RpecwghYhT,
				this.toolStripTextBoxFind,
				this.toolStripButtonFindPrev,
				this.toolStripButtonFindNext,
				this.toolStripSeparator3,
				this.vaDcdbdUsK,
				this.toolStripSeparator4,
				this.toolStripButtonExportExcel,
				this.toolStripSeparator5,
				this.toolStripButtonRefresh
			});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(616, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip1";
			this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnAdd.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnAdd.Image");
			this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnAdd.Name = "toolBtnAdd";
			this.toolBtnAdd.Size = new System.Drawing.Size(23, 22);
			this.toolBtnAdd.Text = "Добавить новый счетчик";
			this.toolBtnAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
			this.toolBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnEdit.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnEdit.Image");
			this.toolBtnEdit.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnEdit.Name = "toolBtnEdit";
			this.toolBtnEdit.Size = new System.Drawing.Size(23, 22);
			this.toolBtnEdit.Text = "Редактировать";
			this.toolBtnEdit.Click += new System.EventHandler(this.toolBtnEdit_Click);
			this.toolBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDel.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnDel.Image");
			this.toolBtnDel.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDel.Name = "toolBtnDel";
			this.toolBtnDel.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDel.Text = "Пометить на удаление";
			this.toolBtnDel.Click += new System.EventHandler(this.toolBtnDel_Click);
			this.ilScgFvUxM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ilScgFvUxM.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnDelFull.Image");
			this.ilScgFvUxM.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.ilScgFvUxM.Name = "toolBtnDelFull";
			this.ilScgFvUxM.Size = new System.Drawing.Size(23, 22);
			this.ilScgFvUxM.Text = "Удалить полностью";
			this.ilScgFvUxM.Click += new System.EventHandler(this.ilScgFvUxM_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			this.toolBtnShowDelete.CheckOnClick = true;
			this.toolBtnShowDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnShowDelete.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolBtnShowDelete.Image");
			this.toolBtnShowDelete.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDelete.Name = "toolBtnShowDelete";
			this.toolBtnShowDelete.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDelete.Text = "Показать удаленные";
			this.toolBtnShowDelete.Click += new System.EventHandler(this.toolBtnShowDelete_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			this.RpecwghYhT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.RpecwghYhT.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonFind.Image");
			this.RpecwghYhT.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.RpecwghYhT.Name = "toolStripButtonFind";
			this.RpecwghYhT.Size = new System.Drawing.Size(23, 22);
			this.RpecwghYhT.Text = "Поиск";
			this.RpecwghYhT.Click += new System.EventHandler(this.RpecwghYhT_Click);
			this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
			this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
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
			this.vaDcdbdUsK.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.vaDcdbdUsK.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolStripButtonPrint.Image");
			this.vaDcdbdUsK.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.vaDcdbdUsK.Name = "toolStripButtonPrint";
			this.vaDcdbdUsK.Size = new System.Drawing.Size(23, 22);
			this.vaDcdbdUsK.Text = "Печать";
			this.vaDcdbdUsK.Click += new System.EventHandler(this.vaDcdbdUsK_Click);
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
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuItemAdd,
				this.DaWcrtsonX,
				this.toolMenuItemDel,
				this.toolStripSeparator6,
				this.toolMenuItemCopy,
				this.toolMenuItemExportToExcel,
				this.toolMenuItemPrint
			});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(158, 142);
			this.toolMenuItemAdd.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemAdd.Image");
			this.toolMenuItemAdd.Name = "toolMenuItemAdd";
			this.toolMenuItemAdd.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemAdd.Text = "Добавить";
			this.toolMenuItemAdd.Click += new System.EventHandler(this.toolMenuItemAdd_Click);
			this.DaWcrtsonX.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemEdit.Image");
			this.DaWcrtsonX.Name = "toolMenuItemEdit";
			this.DaWcrtsonX.Size = new System.Drawing.Size(157, 22);
			this.DaWcrtsonX.Text = "Изменить";
			this.DaWcrtsonX.Click += new System.EventHandler(this.DaWcrtsonX_Click);
			this.toolMenuItemDel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemDelCheck,
				this.toolStripMenuItemDelFull
			});
			this.toolMenuItemDel.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemDel.Image");
			this.toolMenuItemDel.Name = "toolMenuItemDel";
			this.toolMenuItemDel.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemDel.Text = "Удалить";
			this.toolStripMenuItemDelCheck.Name = "toolStripMenuItemDelCheck";
			this.toolStripMenuItemDelCheck.Size = new System.Drawing.Size(198, 22);
			this.toolStripMenuItemDelCheck.Text = "Пометить на удаление";
			this.toolStripMenuItemDelCheck.Click += new System.EventHandler(this.toolStripMenuItemDelCheck_Click);
			this.toolStripMenuItemDelFull.Name = "toolStripMenuItemDelFull";
			this.toolStripMenuItemDelFull.Size = new System.Drawing.Size(198, 22);
			this.toolStripMenuItemDelFull.Text = "Удалить полностью";
			this.toolStripMenuItemDelFull.Click += new System.EventHandler(this.toolStripMenuItemDelFull_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(154, 6);
			this.toolMenuItemCopy.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemCopy.Image");
			this.toolMenuItemCopy.Name = "toolMenuItemCopy";
			this.toolMenuItemCopy.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemCopy.Text = "Копировать";
			this.toolMenuItemCopy.Click += new System.EventHandler(this.toolMenuItemCopy_Click);
			this.toolMenuItemExportToExcel.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemExportToExcel.Image");
			this.toolMenuItemExportToExcel.Name = "toolMenuItemExportToExcel";
			this.toolMenuItemExportToExcel.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemExportToExcel.Text = "Экспорт в Excel";
			this.toolMenuItemExportToExcel.Click += new System.EventHandler(this.toolMenuItemExportToExcel_Click);
			this.toolMenuItemPrint.Image = (System.Drawing.Image)componentResourceManager.GetObject("toolMenuItemPrint.Image");
			this.toolMenuItemPrint.Name = "toolMenuItemPrint";
			this.toolMenuItemPrint.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemPrint.Text = "Печать";
			this.toolMenuItemPrint.Click += new System.EventHandler(this.toolMenuItemPrint_Click);
			this.contextMenuStripPicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripMenuItemSavePicture
			});
			this.contextMenuStripPicture.Name = "contextMenuStripPicture";
			this.contextMenuStripPicture.Size = new System.Drawing.Size(182, 26);
			this.toolStripMenuItemSavePicture.Name = "toolStripMenuItemSavePicture";
			this.toolStripMenuItemSavePicture.Size = new System.Drawing.Size(181, 22);
			this.toolStripMenuItemSavePicture.Text = "Сохранить рисунок";
			this.toolStripMenuItemSavePicture.Click += new System.EventHandler(this.toolStripMenuItemSavePicture_Click);
			this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMain.Location = new System.Drawing.Point(0, 25);
			this.splitContainerMain.Name = "splitContainerMain";
			this.splitContainerMain.Panel1.Controls.Add(this.treeView);
			this.splitContainerMain.Panel2.Controls.Add(this.TdJcIkLix0);
			this.splitContainerMain.Size = new System.Drawing.Size(616, 438);
			this.splitContainerMain.SplitterDistance = 137;
			this.splitContainerMain.TabIndex = 2;
			this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView.Location = new System.Drawing.Point(0, 0);
			this.treeView.Name = "treeView";
			this.treeView.Size = new System.Drawing.Size(137, 438);
			this.treeView.TabIndex = 0;
			this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
			this.TdJcIkLix0.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TdJcIkLix0.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.TdJcIkLix0.Location = new System.Drawing.Point(0, 0);
			this.TdJcIkLix0.Name = "splitContainerGrid";
			this.TdJcIkLix0.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.TdJcIkLix0.Panel1.Controls.Add(this.dgvCounter);
			this.TdJcIkLix0.Panel2.Controls.Add(this.splitContainerComment);
			this.TdJcIkLix0.Size = new System.Drawing.Size(475, 438);
			this.TdJcIkLix0.SplitterDistance = 311;
			this.TdJcIkLix0.TabIndex = 1;
			this.dgvCounter.AllowUserToAddRows = false;
			this.dgvCounter.AllowUserToDeleteRows = false;
			this.dgvCounter.AutoGenerateColumns = false;
			this.dgvCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCounter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idDgvTextBoxColumn,
				this.nameDgvTextBoxColumn,
				this.primaryDataGridViewTextBoxColumn,
				this.secondaryDataGridViewTextBoxColumn,
				this.precisionDataGridViewTextBoxColumn,
				this.intervalDataGridViewTextBoxColumn,
				this.typeTransDataGridViewTextBoxColumn,
				this.commentDataGridViewTextBoxColumn,
				this.deletedDgvCheckBoxColumn
			});
			this.dgvCounter.ContextMenuStrip = this.contextMenuStrip;
			this.dgvCounter.DataSource = this.bindingSource_0;
			this.dgvCounter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCounter.Location = new System.Drawing.Point(0, 0);
			this.dgvCounter.Name = "dgvCounter";
			this.dgvCounter.ReadOnly = true;
			this.dgvCounter.RowHeadersWidth = 21;
			this.dgvCounter.Size = new System.Drawing.Size(475, 311);
			this.dgvCounter.TabIndex = 0;
			this.dgvCounter.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCounter_CellFormatting);
			this.bindingSource_0.DataMember = "tR_MarkTrans";
			this.bindingSource_0.DataSource = this.class37_0;
			this.bindingSource_0.Sort = "Name, Primary, Secondary";
			this.class37_0.DataSetName = "DataSetMeters";
			this.class37_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.splitContainerComment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerComment.Location = new System.Drawing.Point(0, 0);
			this.splitContainerComment.Name = "splitContainerComment";
			this.splitContainerComment.Panel1.Controls.Add(this.richTextBox);
			this.splitContainerComment.Panel2.Controls.Add(this.pictureBox);
			this.splitContainerComment.Size = new System.Drawing.Size(475, 123);
			this.splitContainerComment.SplitterDistance = 212;
			this.splitContainerComment.TabIndex = 0;
			this.richTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource_0, "Comment", true));
			this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox.Location = new System.Drawing.Point(0, 0);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.Size = new System.Drawing.Size(212, 123);
			this.richTextBox.TabIndex = 0;
			this.richTextBox.Text = "";
			this.pictureBox.ContextMenuStrip = this.contextMenuStripPicture;
			this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bindingSource_0, "Image", true));
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(259, 123);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.idDgvTextBoxColumn.DataPropertyName = "id";
			this.idDgvTextBoxColumn.HeaderText = "id";
			this.idDgvTextBoxColumn.Name = "idDgvTextBoxColumn";
			this.idDgvTextBoxColumn.ReadOnly = true;
			this.idDgvTextBoxColumn.Visible = false;
			this.nameDgvTextBoxColumn.DataPropertyName = "Name";
			this.nameDgvTextBoxColumn.HeaderText = "Наименование";
			this.nameDgvTextBoxColumn.Name = "nameDgvTextBoxColumn";
			this.nameDgvTextBoxColumn.ReadOnly = true;
			this.nameDgvTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.primaryDataGridViewTextBoxColumn.DataPropertyName = "Primary";
			this.primaryDataGridViewTextBoxColumn.HeaderText = "Первич";
			this.primaryDataGridViewTextBoxColumn.Name = "primaryDataGridViewTextBoxColumn";
			this.primaryDataGridViewTextBoxColumn.ReadOnly = true;
			this.primaryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.primaryDataGridViewTextBoxColumn.Width = 70;
			this.secondaryDataGridViewTextBoxColumn.DataPropertyName = "Secondary";
			this.secondaryDataGridViewTextBoxColumn.HeaderText = "Вторич";
			this.secondaryDataGridViewTextBoxColumn.Name = "secondaryDataGridViewTextBoxColumn";
			this.secondaryDataGridViewTextBoxColumn.ReadOnly = true;
			this.secondaryDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.secondaryDataGridViewTextBoxColumn.Width = 70;
			this.precisionDataGridViewTextBoxColumn.DataPropertyName = "Precision";
			this.precisionDataGridViewTextBoxColumn.HeaderText = "Точность";
			this.precisionDataGridViewTextBoxColumn.Name = "precisionDataGridViewTextBoxColumn";
			this.precisionDataGridViewTextBoxColumn.ReadOnly = true;
			this.precisionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.precisionDataGridViewTextBoxColumn.Width = 70;
			this.intervalDataGridViewTextBoxColumn.DataPropertyName = "Interval";
			this.intervalDataGridViewTextBoxColumn.HeaderText = "Межпров. интервал";
			this.intervalDataGridViewTextBoxColumn.Name = "intervalDataGridViewTextBoxColumn";
			this.intervalDataGridViewTextBoxColumn.ReadOnly = true;
			this.intervalDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.intervalDataGridViewTextBoxColumn.Width = 70;
			this.typeTransDataGridViewTextBoxColumn.DataPropertyName = "TypeTrans";
			this.typeTransDataGridViewTextBoxColumn.HeaderText = "TypeTrans";
			this.typeTransDataGridViewTextBoxColumn.Name = "typeTransDataGridViewTextBoxColumn";
			this.typeTransDataGridViewTextBoxColumn.ReadOnly = true;
			this.typeTransDataGridViewTextBoxColumn.Visible = false;
			this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
			this.commentDataGridViewTextBoxColumn.HeaderText = "Comment";
			this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
			this.commentDataGridViewTextBoxColumn.ReadOnly = true;
			this.commentDataGridViewTextBoxColumn.Visible = false;
			this.deletedDgvCheckBoxColumn.DataPropertyName = "Deleted";
			this.deletedDgvCheckBoxColumn.HeaderText = "Deleted";
			this.deletedDgvCheckBoxColumn.Name = "deletedDgvCheckBoxColumn";
			this.deletedDgvCheckBoxColumn.ReadOnly = true;
			this.deletedDgvCheckBoxColumn.Visible = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(616, 463);
			base.Controls.Add(this.splitContainerMain);
			base.Controls.Add(this.toolStrip);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.KeyPreview = true;
			base.Name = "FormTrans";
			this.Text = "Трансформаторы";
			base.Load += new System.EventHandler(this.FormTrans_Load);
			base.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormTrans_KeyDown);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			this.contextMenuStripPicture.ResumeLayout(false);
			this.splitContainerMain.Panel1.ResumeLayout(false);
			this.splitContainerMain.Panel2.ResumeLayout(false);
			this.splitContainerMain.ResumeLayout(false);
			this.TdJcIkLix0.Panel1.ResumeLayout(false);
			this.TdJcIkLix0.Panel2.ResumeLayout(false);
			this.TdJcIkLix0.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvCounter).EndInit();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class37_0).EndInit();
			this.splitContainerComment.Panel1.ResumeLayout(false);
			this.splitContainerComment.Panel2.ResumeLayout(false);
			this.splitContainerComment.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.pictureBox).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.ToolStrip toolStrip;

		private Class37 class37_0;

		private System.Windows.Forms.BindingSource bindingSource_0;

		private System.Windows.Forms.ToolStripButton toolBtnAdd;

		private System.Windows.Forms.ToolStripButton toolBtnEdit;

		private System.Windows.Forms.ToolStripButton toolBtnDel;

		private System.Windows.Forms.ToolStripButton ilScgFvUxM;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripButton toolBtnShowDelete;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		private System.Windows.Forms.ToolStripButton RpecwghYhT;

		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		private System.Windows.Forms.ToolStripButton vaDcdbdUsK;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemAdd;

		private System.Windows.Forms.ToolStripMenuItem DaWcrtsonX;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemCopy;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemExportToExcel;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemPrint;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelCheck;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelFull;

		private System.Windows.Forms.ContextMenuStrip contextMenuStripPicture;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSavePicture;

		private System.Windows.Forms.SplitContainer splitContainerMain;

		private System.Windows.Forms.SplitContainer TdJcIkLix0;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvCounter;

		private System.Windows.Forms.SplitContainer splitContainerComment;

		private System.Windows.Forms.RichTextBox richTextBox;

		private System.Windows.Forms.PictureBox pictureBox;

		private System.Windows.Forms.TreeView treeView;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDgvTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDgvTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn primaryDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn secondaryDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn precisionDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn intervalDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn typeTransDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDgvCheckBoxColumn;
	}
}
