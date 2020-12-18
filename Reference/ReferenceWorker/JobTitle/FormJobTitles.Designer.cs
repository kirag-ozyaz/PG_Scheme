namespace ReferenceWorker
{
	public partial class FormJobTitles : FormLbr.FormBase
	{
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJobTitles));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDel = new System.Windows.Forms.ToolStripSplitButton();
            this.toolBtnDelRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBtnDelFull = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonHideDeleted = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBtnPadez = new System.Windows.Forms.ToolStripButton();
            this.dgvExcelFilter = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.ColumnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRRefDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.descriptionDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.rNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.razrjadDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.deletedDgvCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuDelRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuDelFull = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.bs_JobTitle = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new System.Data.DataSet();
            this.dataTable_0 = new System.Data.DataTable();
            this.dataColumn_0 = new System.Data.DataColumn();
            this.dataColumn_1 = new System.Data.DataColumn();
            this.dataColumn_2 = new System.Data.DataColumn();
            this.dataColumn_3 = new System.Data.DataColumn();
            this.dataColumn_4 = new System.Data.DataColumn();
            this.dataColumn_5 = new System.Data.DataColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelFilter)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_JobTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAdd,
            this.toolBtnEdit,
            this.toolBtnDel,
            this.toolStripButtonHideDeleted,
            this.toolStripSeparator1,
            this.toolStripButtonFind,
            this.toolStripTextBoxFind,
            this.toolStripButtonFindPrev,
            this.toolStripButtonFindNext,
            this.toolStripSeparator2,
            this.toolStripButtonPrint,
            this.toolStripSeparator3,
            this.toolStripButtonExportExcel,
            this.toolStripSeparator4,
            this.toolStripButtonRefresh,
            this.toolStripSeparator5,
            this.toolBtnPadez});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(534, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolBtnAdd
            // 
            this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAdd.Image = global::ReferenceWorker.Properties.Resources.ElementAdd;
            this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAdd.Text = "Добавить должность";
            this.toolBtnAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
            // 
            // toolBtnEdit
            // 
            this.toolBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnEdit.Image = global::ReferenceWorker.Properties.Resources.ElementEdit;
            this.toolBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnEdit.Name = "toolBtnEdit";
            this.toolBtnEdit.Size = new System.Drawing.Size(23, 22);
            this.toolBtnEdit.Text = "Редактировать должность";
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
            this.toolBtnDelRestore.Click += new System.EventHandler(this.toolMenuDelRestore_Click);
            // 
            // toolBtnDelFull
            // 
            this.toolBtnDelFull.Name = "toolBtnDelFull";
            this.toolBtnDelFull.Size = new System.Drawing.Size(198, 22);
            this.toolBtnDelFull.Text = "Удалить полностью";
            this.toolBtnDelFull.Click += new System.EventHandler(this.toolMenuDelFull_Click);
            // 
            // toolStripButtonHideDeleted
            // 
            this.toolStripButtonHideDeleted.CheckOnClick = true;
            this.toolStripButtonHideDeleted.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonHideDeleted.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHideDeleted.Image")));
            this.toolStripButtonHideDeleted.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonHideDeleted.Name = "toolStripButtonHideDeleted";
            this.toolStripButtonHideDeleted.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonHideDeleted.Text = "Показать удаленные записи";
            this.toolStripButtonHideDeleted.Click += new System.EventHandler(this.FdarTkgxvQ);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFind.Image")));
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.Click += new System.EventHandler(this.jEsrCgOgu8);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // dgvExcelFilter
            // 
            this.dgvExcelFilter.AllowUserToAddRows = false;
            this.dgvExcelFilter.AllowUserToDeleteRows = false;
            this.dgvExcelFilter.AllowUserToOrderColumns = true;
            this.dgvExcelFilter.AllowUserToVisibleColumns = false;
            this.dgvExcelFilter.AutoGenerateColumns = false;
            this.dgvExcelFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExcelFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImage,
            this.idDataGridViewTextBoxColumn,
            this.iDRRefDataGridViewImageColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.rNameDataGridViewTextBoxColumn,
            this.razrjadDataGridViewTextBoxColumn,
            this.deletedDgvCheckBoxColumn});
            this.dgvExcelFilter.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvExcelFilter.DataSource = this.bs_JobTitle;
            this.dgvExcelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExcelFilter.Location = new System.Drawing.Point(0, 25);
            this.dgvExcelFilter.Name = "dgvExcelFilter";
            this.dgvExcelFilter.ReadOnly = true;
            this.dgvExcelFilter.RowHeadersWidth = 20;
            this.dgvExcelFilter.Size = new System.Drawing.Size(534, 305);
            this.dgvExcelFilter.TabIndex = 1;
            this.dgvExcelFilter.VirtualMode = true;
            this.dgvExcelFilter.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvExcelFilter_CellValueNeeded);
            this.dgvExcelFilter.CurrentCellChanged += new System.EventHandler(this.dgvExcelFilter_CurrentCellChanged);
            // 
            // ColumnImage
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnImage.HeaderText = "";
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnImage.Width = 16;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // iDRRefDataGridViewImageColumn
            // 
            this.iDRRefDataGridViewImageColumn.DataPropertyName = "IDRRef";
            this.iDRRefDataGridViewImageColumn.HeaderText = "IDRRef";
            this.iDRRefDataGridViewImageColumn.Name = "iDRRefDataGridViewImageColumn";
            this.iDRRefDataGridViewImageColumn.ReadOnly = true;
            this.iDRRefDataGridViewImageColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descriptionDataGridViewTextBoxColumn.Width = 240;
            // 
            // rNameDataGridViewTextBoxColumn
            // 
            this.rNameDataGridViewTextBoxColumn.DataPropertyName = "RName";
            this.rNameDataGridViewTextBoxColumn.HeaderText = "Ранг";
            this.rNameDataGridViewTextBoxColumn.Name = "rNameDataGridViewTextBoxColumn";
            this.rNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.rNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rNameDataGridViewTextBoxColumn.Width = 60;
            // 
            // razrjadDataGridViewTextBoxColumn
            // 
            this.razrjadDataGridViewTextBoxColumn.DataPropertyName = "Razrjad";
            this.razrjadDataGridViewTextBoxColumn.HeaderText = "Разряд";
            this.razrjadDataGridViewTextBoxColumn.Name = "razrjadDataGridViewTextBoxColumn";
            this.razrjadDataGridViewTextBoxColumn.ReadOnly = true;
            this.razrjadDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.razrjadDataGridViewTextBoxColumn.Width = 50;
            // 
            // deletedDgvCheckBoxColumn
            // 
            this.deletedDgvCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDgvCheckBoxColumn.HeaderText = "Deleted";
            this.deletedDgvCheckBoxColumn.Name = "deletedDgvCheckBoxColumn";
            this.deletedDgvCheckBoxColumn.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuAdd,
            this.toolMenuEdit,
            this.toolMenuDelRestore,
            this.toolMenuDelFull,
            this.toolStripSeparator6,
            this.toolStripMenuItemCopy,
            this.toolStripMenuItem_0,
            this.toolStripMenuItemPrint});
            this.contextMenuStrip1.Name = "contextMenuStrip";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 164);
            // 
            // toolMenuAdd
            // 
            this.toolMenuAdd.Image = global::ReferenceWorker.Properties.Resources.ElementAdd;
            this.toolMenuAdd.Name = "toolMenuAdd";
            this.toolMenuAdd.Size = new System.Drawing.Size(198, 22);
            this.toolMenuAdd.Text = "Добавить";
            this.toolMenuAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
            // 
            // toolMenuEdit
            // 
            this.toolMenuEdit.Image = global::ReferenceWorker.Properties.Resources.ElementEdit;
            this.toolMenuEdit.Name = "toolMenuEdit";
            this.toolMenuEdit.Size = new System.Drawing.Size(198, 22);
            this.toolMenuEdit.Text = "Редактировать";
            this.toolMenuEdit.Click += new System.EventHandler(this.toolMenuEdit_Click);
            // 
            // toolMenuDelRestore
            // 
            this.toolMenuDelRestore.Image = global::ReferenceWorker.Properties.Resources.Trash;
            this.toolMenuDelRestore.Name = "toolMenuDelRestore";
            this.toolMenuDelRestore.Size = new System.Drawing.Size(198, 22);
            this.toolMenuDelRestore.Text = "Пометить на удаление";
            this.toolMenuDelRestore.Click += new System.EventHandler(this.toolMenuDelRestore_Click);
            // 
            // toolMenuDelFull
            // 
            this.toolMenuDelFull.Image = global::ReferenceWorker.Properties.Resources.ElementDel;
            this.toolMenuDelFull.Name = "toolMenuDelFull";
            this.toolMenuDelFull.Size = new System.Drawing.Size(198, 22);
            this.toolMenuDelFull.Text = "Удалить полностью";
            this.toolMenuDelFull.Click += new System.EventHandler(this.toolMenuDelFull_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(195, 6);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemCopy.Image")));
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemCopy.Text = "Копировать";
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.toolStripMenuItemCopy_Click);
            // 
            // toolStripMenuItem_0
            // 
            this.toolStripMenuItem_0.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem_0.Image")));
            this.toolStripMenuItem_0.Name = "toolStripMenuItem_0";
            this.toolStripMenuItem_0.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItem_0.Text = "Экспорт в Excel";
            this.toolStripMenuItem_0.Click += new System.EventHandler(this.toolStripMenuItem_0_Click);
            // 
            // toolStripMenuItemPrint
            // 
            this.toolStripMenuItemPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemPrint.Image")));
            this.toolStripMenuItemPrint.Name = "toolStripMenuItemPrint";
            this.toolStripMenuItemPrint.Size = new System.Drawing.Size(198, 22);
            this.toolStripMenuItemPrint.Text = "Печать";
            this.toolStripMenuItemPrint.Click += new System.EventHandler(this.toolStripMenuItemPrint_Click);
            // 
            // bs_JobTitle
            // 
            this.bs_JobTitle.DataMember = "tR_JobTitle";
            this.bs_JobTitle.DataSource = this.dataSet;
            this.bs_JobTitle.Filter = "Deleted = false";
            this.bs_JobTitle.Sort = "Description, RName, Razrjad";
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
            this.dataColumn_5});
            this.dataTable_0.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Id"}, true)});
            this.dataTable_0.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn_0};
            this.dataTable_0.TableName = "tR_JobTitle";
            // 
            // dataColumn_0
            // 
            this.dataColumn_0.AllowDBNull = false;
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
            this.dataColumn_2.AllowDBNull = false;
            this.dataColumn_2.ColumnName = "Description";
            // 
            // dataColumn_3
            // 
            this.dataColumn_3.ColumnName = "RName";
            // 
            // dataColumn_4
            // 
            this.dataColumn_4.ColumnName = "Razrjad";
            // 
            // dataColumn_5
            // 
            this.dataColumn_5.AllowDBNull = false;
            this.dataColumn_5.ColumnName = "Deleted";
            this.dataColumn_5.DataType = typeof(bool);
            this.dataColumn_5.DefaultValue = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Element.png");
            this.imageList1.Images.SetKeyName(1, "ElementDelete.png");
            // 
            // FormJobTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 330);
            this.Controls.Add(this.dgvExcelFilter);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormJobTitles";
            this.Text = "Справочник должностей";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJobTitles_FormClosed);
            this.Load += new System.EventHandler(this.FormJobTitles_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExcelFilter)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_JobTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable_0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}


		private System.Windows.Forms.ToolStrip toolStrip;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvExcelFilter;

		private System.Data.DataSet dataSet;

		private System.Data.DataTable dataTable_0;

		private System.Data.DataColumn dataColumn_0;

		private System.Data.DataColumn dataColumn_1;

		private System.Data.DataColumn dataColumn_2;

		private System.Data.DataColumn dataColumn_3;

		private System.Data.DataColumn dataColumn_4;

		private System.Data.DataColumn dataColumn_5;

		private System.Windows.Forms.BindingSource bs_JobTitle;

		private System.Windows.Forms.ImageList imageList1;

		private System.Windows.Forms.ToolStripButton toolStripButtonHideDeleted;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripButton toolStripButtonFind;

		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		private System.Windows.Forms.ToolStripButton toolStripButtonPrint;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemPrint;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		private System.Windows.Forms.ToolStripButton toolBtnPadez;

		private System.Windows.Forms.ToolStripButton toolBtnAdd;

		private System.Windows.Forms.ToolStripButton toolBtnEdit;

		private System.Windows.Forms.ToolStripSplitButton toolBtnDel;

		private System.Windows.Forms.ToolStripMenuItem toolBtnDelRestore;

		private System.Windows.Forms.ToolStripMenuItem toolBtnDelFull;

		private System.Windows.Forms.ToolStripMenuItem toolMenuAdd;

		private System.Windows.Forms.ToolStripMenuItem toolMenuEdit;

		private System.Windows.Forms.ToolStripMenuItem toolMenuDelRestore;

		private System.Windows.Forms.ToolStripMenuItem toolMenuDelFull;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull ColumnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn iDRRefDataGridViewImageColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn rNameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn razrjadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDgvCheckBoxColumn;
    }
}
