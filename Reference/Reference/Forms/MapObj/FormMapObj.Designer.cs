namespace Reference.Forms.MapObj
{
	public partial class FormMapObj : FormLbr.FormBase
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
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(Reference.Forms.MapObj.FormMapObj));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.toolBtnShowDeleteMapObj = new System.Windows.Forms.ToolStripButton();
			this.KjofMhfvQl = new System.Windows.Forms.ToolStripSeparator();
			this.toolBtnAddObj = new System.Windows.Forms.ToolStripButton();
			this.toolBtnEditObj = new System.Windows.Forms.ToolStripButton();
			this.toolBtnDelObj = new System.Windows.Forms.ToolStripButton();
			this.toolBtnDelObjFull = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparatorMapObj = new System.Windows.Forms.ToolStripSeparator();
			this.tootBtnAddParam = new System.Windows.Forms.ToolStripButton();
			this.toolBtnEditParam = new System.Windows.Forms.ToolStripButton();
			this.toolBtnDelParam = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparatorParam = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
			this.YaqfzqmoJo = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButtonFindPrev = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonFindNext = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
			this.splitContainerMain = new System.Windows.Forms.SplitContainer();
			this.tabControlTree = new System.Windows.Forms.TabControl();
			this.tabPagePunkts = new System.Windows.Forms.TabPage();
			this.treeViewPunkts = new System.Windows.Forms.TreeView();
			this.imageList_0 = new System.Windows.Forms.ImageList(this.icontainer_0);
			this.toolStripTreePunkts = new System.Windows.Forms.ToolStrip();
			this.toolBtnShowDeletePunkts = new System.Windows.Forms.ToolStripButton();
			this.toolTxtFindPunkts = new System.Windows.Forms.ToolStripTextBox();
			this.toolBtnFindPunkts = new System.Windows.Forms.ToolStripButton();
			this.tabPageRaions = new System.Windows.Forms.TabPage();
			this.treeViewRaion = new System.Windows.Forms.TreeView();
			this.groupBoxRaion = new System.Windows.Forms.GroupBox();
			this.cmbRaion_Punkt = new System.Windows.Forms.ComboBox();
			this.dataSet_1 = new System.Data.DataSet();
			this.dataTable_1 = new System.Data.DataTable();
			this.dataColumn_4 = new System.Data.DataColumn();
			this.dataColumn_5 = new System.Data.DataColumn();
			this.dataColumn_6 = new System.Data.DataColumn();
			this.dataColumn_7 = new System.Data.DataColumn();
			this.labelRaion_Punkt = new System.Windows.Forms.Label();
			this.cmbRaion_RaionCity = new System.Windows.Forms.ComboBox();
			this.dataSet_2 = new System.Data.DataSet();
			this.TSWHYESWDA = new System.Data.DataTable();
			this.dataColumn_8 = new System.Data.DataColumn();
			this.dataColumn_9 = new System.Data.DataColumn();
			this.dataColumn_10 = new System.Data.DataColumn();
			this.dataColumn_11 = new System.Data.DataColumn();
			this.labelRaion_RaionCity = new System.Windows.Forms.Label();
			this.cmbRaion_Obl = new System.Windows.Forms.ComboBox();
			this.dataSet_3 = new System.Data.DataSet();
			this.dataTable_2 = new System.Data.DataTable();
			this.dataColumn_12 = new System.Data.DataColumn();
			this.dataColumn_13 = new System.Data.DataColumn();
			this.dataColumn_14 = new System.Data.DataColumn();
			this.dataColumn_15 = new System.Data.DataColumn();
			this.labelRaion_Obl = new System.Windows.Forms.Label();
			this.toolStripRaion = new System.Windows.Forms.ToolStrip();
			this.toolBtnShowDeleteRaions = new System.Windows.Forms.ToolStripButton();
			this.aVffuKoEfC = new System.Windows.Forms.ToolStripTextBox();
			this.toolBtnFindRaion = new System.Windows.Forms.ToolStripButton();
			this.tabPageStreet = new System.Windows.Forms.TabPage();
			this.treeViewStreet = new System.Windows.Forms.TreeView();
			this.groupBoxStreet = new System.Windows.Forms.GroupBox();
			this.cmbStreet_Punkt = new System.Windows.Forms.ComboBox();
			this.dataSet_4 = new System.Data.DataSet();
			this.dataTable_3 = new System.Data.DataTable();
			this.dataColumn_16 = new System.Data.DataColumn();
			this.dataColumn_17 = new System.Data.DataColumn();
			this.dataColumn_18 = new System.Data.DataColumn();
			this.dataColumn_19 = new System.Data.DataColumn();
			this.labelStreet_Punkt = new System.Windows.Forms.Label();
			this.cmbStreet_RaionCity = new System.Windows.Forms.ComboBox();
			this.dataSet_5 = new System.Data.DataSet();
			this.dataTable_4 = new System.Data.DataTable();
			this.dataColumn_20 = new System.Data.DataColumn();
			this.dataColumn_21 = new System.Data.DataColumn();
			this.dataColumn_22 = new System.Data.DataColumn();
			this.dataColumn_23 = new System.Data.DataColumn();
			this.labelStreet_RaionCity = new System.Windows.Forms.Label();
			this.cmbStreet_Obl = new System.Windows.Forms.ComboBox();
			this.dataSet_0 = new System.Data.DataSet();
			this.dataTable_0 = new System.Data.DataTable();
			this.dataColumn_0 = new System.Data.DataColumn();
			this.dataColumn_1 = new System.Data.DataColumn();
			this.dataColumn_2 = new System.Data.DataColumn();
			this.dataColumn_3 = new System.Data.DataColumn();
			this.labelStreet_Obl = new System.Windows.Forms.Label();
			this.toolStripStreet = new System.Windows.Forms.ToolStrip();
			this.toolBtnShowDeleteStreet = new System.Windows.Forms.ToolStripButton();
			this.toolTxtFindStreet = new System.Windows.Forms.ToolStripTextBox();
			this.toolBtnFindStreet = new System.Windows.Forms.ToolStripButton();
			this.splitContainerGrid = new System.Windows.Forms.SplitContainer();
			this.dgvMapObj = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
			this.idMapDgvTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.raionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
			this.streetNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.houseDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.housePrefixDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.raionNameDgvTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.indexDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.isHouseDataGridViewCheckBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
			this.nameDgvTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.latitudeDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.vBkfDnumnw = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.commentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.deletedDgvCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.kladrObjIdDgvTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hAcIluWoWc = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolMenuItemAddObj = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemEditObj = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelObj = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelObjCheck = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelObjFull = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolMenuItemCopyObj = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemExcelObj = new System.Windows.Forms.ToolStripMenuItem();
			this.fCbIjhllk4 = new System.Windows.Forms.ToolStripMenuItem();
			this.bindingSource_0 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.class20_0 = new Class20();
			this.dgvMapObjParameter = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mapObjIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.otherTypeObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.countFloorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countPorchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countApartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.yearBuiltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reasonEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuDgvMapObj_1 = new System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.toolMenuAddObjParam = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuEditObjParam = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelObjParam = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.TqdIidAoTN = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuExportObjParam = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuPrintObjParam = new System.Windows.Forms.ToolStripMenuItem();
			this.bindingSource_1 = new System.Windows.Forms.BindingSource(this.icontainer_0);
			this.toolStripMain.SuspendLayout();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.tabControlTree.SuspendLayout();
			this.tabPagePunkts.SuspendLayout();
			this.toolStripTreePunkts.SuspendLayout();
			this.tabPageRaions.SuspendLayout();
			this.groupBoxRaion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dataSet_1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.TSWHYESWDA).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_3).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_2).BeginInit();
			this.toolStripRaion.SuspendLayout();
			this.tabPageStreet.SuspendLayout();
			this.groupBoxStreet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dataSet_4).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_3).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_5).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_4).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_0).BeginInit();
			this.toolStripStreet.SuspendLayout();
			this.splitContainerGrid.Panel1.SuspendLayout();
			this.splitContainerGrid.Panel2.SuspendLayout();
			this.splitContainerGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMapObj).BeginInit();
			this.hAcIluWoWc.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.class20_0).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvMapObjParameter).BeginInit();
			this.contextMenuDgvMapObj_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSource_1).BeginInit();
			base.SuspendLayout();
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnShowDeleteMapObj,
				this.KjofMhfvQl,
				this.toolBtnAddObj,
				this.toolBtnEditObj,
				this.toolBtnDelObj,
				this.toolBtnDelObjFull,
				this.toolStripSeparatorMapObj,
				this.tootBtnAddParam,
				this.toolBtnEditParam,
				this.toolBtnDelParam,
				this.toolStripSeparatorParam,
				this.toolStripButtonFind,
				this.YaqfzqmoJo,
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
			this.toolStripMain.Size = new System.Drawing.Size(866, 25);
			this.toolStripMain.TabIndex = 0;
			this.toolStripMain.Text = "toolStrip1";
			this.toolBtnShowDeleteMapObj.CheckOnClick = true;
			this.toolBtnShowDeleteMapObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnShowDeleteMapObj.Image = Reference.Properties.Resources.smethod_24();
			this.toolBtnShowDeleteMapObj.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDeleteMapObj.Name = "toolBtnShowDeleteMapObj";
			this.toolBtnShowDeleteMapObj.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDeleteMapObj.Text = "Показать удаленные объекты";
			this.toolBtnShowDeleteMapObj.Click += new System.EventHandler(this.toolBtnShowDeleteMapObj_Click);
			this.KjofMhfvQl.Name = "toolStripSeparatorShowDelete";
			this.KjofMhfvQl.Size = new System.Drawing.Size(6, 25);
			this.toolBtnAddObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnAddObj.Image = Reference.Properties.Resources.smethod_18();
			this.toolBtnAddObj.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolBtnAddObj.Name = "toolBtnAddObj";
			this.toolBtnAddObj.Size = new System.Drawing.Size(23, 22);
			this.toolBtnAddObj.Text = "Добавить новый объект";
			this.toolBtnAddObj.Click += new System.EventHandler(this.QakmBsilBY);
			this.toolBtnEditObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnEditObj.Image = Reference.Properties.Resources.smethod_20();
			this.toolBtnEditObj.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnEditObj.Name = "toolBtnEditObj";
			this.toolBtnEditObj.Size = new System.Drawing.Size(23, 22);
			this.toolBtnEditObj.Text = "toolStripButton1";
			this.toolBtnEditObj.Click += new System.EventHandler(this.toolBtnEditObj_Click);
			this.toolBtnDelObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDelObj.Image = Reference.Properties.Resources.smethod_21();
			this.toolBtnDelObj.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDelObj.Name = "toolBtnDelObj";
			this.toolBtnDelObj.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDelObj.Text = "Пометить на удаление";
			this.toolBtnDelObj.Click += new System.EventHandler(this.toolBtnDelObj_Click);
			this.toolBtnDelObjFull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDelObjFull.Image = Reference.Properties.Resources.smethod_19();
			this.toolBtnDelObjFull.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDelObjFull.Name = "toolBtnDelObjFull";
			this.toolBtnDelObjFull.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDelObjFull.Text = "Удалить полностью";
			this.toolBtnDelObjFull.Click += new System.EventHandler(this.toolBtnDelObjFull_Click);
			this.toolStripSeparatorMapObj.Name = "toolStripSeparatorMapObj";
			this.toolStripSeparatorMapObj.Size = new System.Drawing.Size(6, 25);
			this.tootBtnAddParam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tootBtnAddParam.Image = Reference.Properties.Resources.smethod_9();
			this.tootBtnAddParam.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.tootBtnAddParam.Name = "tootBtnAddParam";
			this.tootBtnAddParam.Size = new System.Drawing.Size(23, 22);
			this.tootBtnAddParam.Text = "Добавить параметры";
			this.tootBtnAddParam.Click += new System.EventHandler(this.tootBtnAddParam_Click);
			this.toolBtnEditParam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnEditParam.Image = Reference.Properties.Resources.smethod_11();
			this.toolBtnEditParam.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnEditParam.Name = "toolBtnEditParam";
			this.toolBtnEditParam.Size = new System.Drawing.Size(23, 22);
			this.toolBtnEditParam.Text = "Редактировать параметры";
			this.toolBtnEditParam.Click += new System.EventHandler(this.toolBtnEditParam_Click);
			this.toolBtnDelParam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDelParam.Image = Reference.Properties.Resources.smethod_10();
			this.toolBtnDelParam.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDelParam.Name = "toolBtnDelParam";
			this.toolBtnDelParam.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDelParam.Text = "Удалить параметры";
			this.toolBtnDelParam.Click += new System.EventHandler(this.toolBtnDelParam_Click);
			this.toolStripSeparatorParam.Name = "toolStripSeparatorParam";
			this.toolStripSeparatorParam.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFind.Image = Reference.Properties.Resources.smethod_14();
			this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFind.Name = "toolStripButtonFind";
			this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFind.Text = "Поиск";
			this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
			this.YaqfzqmoJo.Name = "toolStripTextBoxFind";
			this.YaqfzqmoJo.Size = new System.Drawing.Size(100, 25);
			this.YaqfzqmoJo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.YaqfzqmoJo_KeyDown);
			this.toolStripButtonFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFindPrev.Image = Reference.Properties.Resources.smethod_16();
			this.toolStripButtonFindPrev.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFindPrev.Name = "toolStripButtonFindPrev";
			this.toolStripButtonFindPrev.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFindPrev.Text = "Поиск назад";
			this.toolStripButtonFindPrev.Click += new System.EventHandler(this.toolStripButtonFindPrev_Click);
			this.toolStripButtonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFindNext.Image = Reference.Properties.Resources.smethod_15();
			this.toolStripButtonFindNext.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFindNext.Name = "toolStripButtonFindNext";
			this.toolStripButtonFindNext.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFindNext.Text = "Поиск вперед";
			this.toolStripButtonFindNext.Click += new System.EventHandler(this.toolStripButtonFindNext_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPrint.Image = Reference.Properties.Resources.smethod_22();
			this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonPrint.Name = "toolStripButtonPrint";
			this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonPrint.Text = "Печать";
			this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExportExcel.Image = Reference.Properties.Resources.smethod_13();
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
			this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainerMain.Location = new System.Drawing.Point(0, 25);
			this.splitContainerMain.Name = "splitContainerMain";
			this.splitContainerMain.Panel1.Controls.Add(this.tabControlTree);
			this.splitContainerMain.Panel2.Controls.Add(this.splitContainerGrid);
			this.splitContainerMain.Size = new System.Drawing.Size(866, 513);
			this.splitContainerMain.SplitterDistance = 285;
			this.splitContainerMain.TabIndex = 1;
			this.tabControlTree.Controls.Add(this.tabPagePunkts);
			this.tabControlTree.Controls.Add(this.tabPageRaions);
			this.tabControlTree.Controls.Add(this.tabPageStreet);
			this.tabControlTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlTree.Location = new System.Drawing.Point(0, 0);
			this.tabControlTree.Name = "tabControlTree";
			this.tabControlTree.SelectedIndex = 0;
			this.tabControlTree.Size = new System.Drawing.Size(285, 513);
			this.tabControlTree.TabIndex = 2;
			this.tabPagePunkts.Controls.Add(this.treeViewPunkts);
			this.tabPagePunkts.Controls.Add(this.toolStripTreePunkts);
			this.tabPagePunkts.Location = new System.Drawing.Point(4, 22);
			this.tabPagePunkts.Name = "tabPagePunkts";
			this.tabPagePunkts.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePunkts.Size = new System.Drawing.Size(277, 487);
			this.tabPagePunkts.TabIndex = 0;
			this.tabPagePunkts.Text = "Нас пункты";
			this.tabPagePunkts.UseVisualStyleBackColor = true;
			this.treeViewPunkts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewPunkts.ImageIndex = 0;
			this.treeViewPunkts.ImageList = this.imageList_0;
			this.treeViewPunkts.Location = new System.Drawing.Point(3, 28);
			this.treeViewPunkts.Name = "treeViewPunkts";
			this.treeViewPunkts.SelectedImageIndex = 0;
			this.treeViewPunkts.Size = new System.Drawing.Size(271, 456);
			this.treeViewPunkts.TabIndex = 1;
			this.treeViewPunkts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPunkts_AfterSelect);
			this.imageList_0.ImageStream = (System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList.ImageStream");
			this.imageList_0.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList_0.Images.SetKeyName(0, "FolderDocumentYellow.png");
			this.imageList_0.Images.SetKeyName(1, "FolderDeleteYellow.png");
			this.imageList_0.Images.SetKeyName(2, "Element.png");
			this.imageList_0.Images.SetKeyName(3, "ElementDelete.png");
			this.toolStripTreePunkts.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnShowDeletePunkts,
				this.toolTxtFindPunkts,
				this.toolBtnFindPunkts
			});
			this.toolStripTreePunkts.Location = new System.Drawing.Point(3, 3);
			this.toolStripTreePunkts.Name = "toolStripTreePunkts";
			this.toolStripTreePunkts.Size = new System.Drawing.Size(271, 25);
			this.toolStripTreePunkts.TabIndex = 2;
			this.toolStripTreePunkts.Text = "toolStrip1";
			this.toolBtnShowDeletePunkts.CheckOnClick = true;
			this.toolBtnShowDeletePunkts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnShowDeletePunkts.Image = Reference.Properties.Resources.smethod_24();
			this.toolBtnShowDeletePunkts.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDeletePunkts.Name = "toolBtnShowDeletePunkts";
			this.toolBtnShowDeletePunkts.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDeletePunkts.Text = "Показать удаленные";
			this.toolBtnShowDeletePunkts.Click += new System.EventHandler(this.VommcJqdrZ);
			this.toolTxtFindPunkts.Name = "toolTxtFindPunkts";
			this.toolTxtFindPunkts.Size = new System.Drawing.Size(100, 25);
			this.toolTxtFindPunkts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTxtFindPunkts_KeyDown);
			this.toolBtnFindPunkts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnFindPunkts.Image = Reference.Properties.Resources.smethod_14();
			this.toolBtnFindPunkts.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnFindPunkts.Name = "toolBtnFindPunkts";
			this.toolBtnFindPunkts.Size = new System.Drawing.Size(23, 22);
			this.toolBtnFindPunkts.Text = "Поиск";
			this.toolBtnFindPunkts.Click += new System.EventHandler(this.toolBtnFindPunkts_Click);
			this.tabPageRaions.Controls.Add(this.treeViewRaion);
			this.tabPageRaions.Controls.Add(this.groupBoxRaion);
			this.tabPageRaions.Controls.Add(this.toolStripRaion);
			this.tabPageRaions.Location = new System.Drawing.Point(4, 22);
			this.tabPageRaions.Name = "tabPageRaions";
			this.tabPageRaions.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageRaions.Size = new System.Drawing.Size(277, 487);
			this.tabPageRaions.TabIndex = 1;
			this.tabPageRaions.Text = "Районы";
			this.tabPageRaions.UseVisualStyleBackColor = true;
			this.treeViewRaion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewRaion.ImageIndex = 0;
			this.treeViewRaion.ImageList = this.imageList_0;
			this.treeViewRaion.Location = new System.Drawing.Point(3, 171);
			this.treeViewRaion.Name = "treeViewRaion";
			this.treeViewRaion.SelectedImageIndex = 0;
			this.treeViewRaion.Size = new System.Drawing.Size(271, 313);
			this.treeViewRaion.TabIndex = 2;
			this.treeViewRaion.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewRaion_AfterSelect);
			this.groupBoxRaion.Controls.Add(this.cmbRaion_Punkt);
			this.groupBoxRaion.Controls.Add(this.labelRaion_Punkt);
			this.groupBoxRaion.Controls.Add(this.cmbRaion_RaionCity);
			this.groupBoxRaion.Controls.Add(this.labelRaion_RaionCity);
			this.groupBoxRaion.Controls.Add(this.cmbRaion_Obl);
			this.groupBoxRaion.Controls.Add(this.labelRaion_Obl);
			this.groupBoxRaion.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxRaion.Location = new System.Drawing.Point(3, 28);
			this.groupBoxRaion.Name = "groupBoxRaion";
			this.groupBoxRaion.Size = new System.Drawing.Size(271, 143);
			this.groupBoxRaion.TabIndex = 1;
			this.groupBoxRaion.TabStop = false;
			this.cmbRaion_Punkt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbRaion_Punkt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbRaion_Punkt.DataSource = this.dataSet_1;
			this.cmbRaion_Punkt.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbRaion_Punkt.FormattingEnabled = true;
			this.cmbRaion_Punkt.Location = new System.Drawing.Point(9, 112);
			this.cmbRaion_Punkt.Name = "cmbRaion_Punkt";
			this.cmbRaion_Punkt.Size = new System.Drawing.Size(185, 21);
			this.cmbRaion_Punkt.TabIndex = 5;
			this.cmbRaion_Punkt.ValueMember = "tR_KladrObj.Id";
			this.cmbRaion_Punkt.SelectedIndexChanged += new System.EventHandler(this.cmbRaion_Punkt_SelectedIndexChanged);
			this.dataSet_1.DataSetName = "NewDataSet";
			this.dataSet_1.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dataTable_1
			});
			this.dataTable_1.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn_4,
				this.dataColumn_5,
				this.dataColumn_6,
				this.dataColumn_7
			});
			this.dataTable_1.Constraints.AddRange(new System.Data.Constraint[]
			{
				new System.Data.UniqueConstraint("Constraint1", new string[]
				{
					"Id"
				}, true)
			});
			this.dataTable_1.PrimaryKey = new System.Data.DataColumn[]
			{
				this.dataColumn_4
			};
			this.dataTable_1.TableName = "tR_KladrObj";
			this.dataColumn_4.AllowDBNull = false;
			this.dataColumn_4.ColumnName = "Id";
			this.dataColumn_4.DataType = typeof(int);
			this.dataColumn_5.ColumnName = "Name";
			this.dataColumn_6.ColumnName = "Socr";
			this.dataColumn_7.ColumnName = "NameSocr";
			this.dataColumn_7.Expression = "isnull(Name, '') + ' ' + isnull(Socr, '')";
			this.dataColumn_7.ReadOnly = true;
			this.labelRaion_Punkt.AutoSize = true;
			this.labelRaion_Punkt.Location = new System.Drawing.Point(6, 96);
			this.labelRaion_Punkt.Name = "labelRaion_Punkt";
			this.labelRaion_Punkt.Size = new System.Drawing.Size(102, 13);
			this.labelRaion_Punkt.TabIndex = 4;
			this.labelRaion_Punkt.Text = "Населенный пункт";
			this.cmbRaion_RaionCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbRaion_RaionCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbRaion_RaionCity.DataSource = this.dataSet_2;
			this.cmbRaion_RaionCity.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbRaion_RaionCity.FormattingEnabled = true;
			this.cmbRaion_RaionCity.Location = new System.Drawing.Point(9, 72);
			this.cmbRaion_RaionCity.Name = "cmbRaion_RaionCity";
			this.cmbRaion_RaionCity.Size = new System.Drawing.Size(185, 21);
			this.cmbRaion_RaionCity.TabIndex = 3;
			this.cmbRaion_RaionCity.ValueMember = "tR_KladrObj.Id";
			this.cmbRaion_RaionCity.SelectedIndexChanged += new System.EventHandler(this.cmbRaion_RaionCity_SelectedIndexChanged);
			this.dataSet_2.DataSetName = "NewDataSet";
			this.dataSet_2.Tables.AddRange(new System.Data.DataTable[]
			{
				this.TSWHYESWDA
			});
			this.TSWHYESWDA.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn_8,
				this.dataColumn_9,
				this.dataColumn_10,
				this.dataColumn_11
			});
			this.TSWHYESWDA.Constraints.AddRange(new System.Data.Constraint[]
			{
				new System.Data.UniqueConstraint("Constraint1", new string[]
				{
					"Id"
				}, true)
			});
			this.TSWHYESWDA.PrimaryKey = new System.Data.DataColumn[]
			{
				this.dataColumn_8
			};
			this.TSWHYESWDA.TableName = "tR_KladrObj";
			this.dataColumn_8.AllowDBNull = false;
			this.dataColumn_8.ColumnName = "Id";
			this.dataColumn_8.DataType = typeof(int);
			this.dataColumn_9.ColumnName = "Name";
			this.dataColumn_10.ColumnName = "Socr";
			this.dataColumn_11.ColumnName = "NameSocr";
			this.dataColumn_11.Expression = "Name + ' ' + Socr";
			this.dataColumn_11.ReadOnly = true;
			this.labelRaion_RaionCity.AutoSize = true;
			this.labelRaion_RaionCity.Location = new System.Drawing.Point(6, 56);
			this.labelRaion_RaionCity.Name = "labelRaion_RaionCity";
			this.labelRaion_RaionCity.Size = new System.Drawing.Size(72, 13);
			this.labelRaion_RaionCity.TabIndex = 2;
			this.labelRaion_RaionCity.Text = "Район/город";
			this.cmbRaion_Obl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbRaion_Obl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbRaion_Obl.DataSource = this.dataSet_3;
			this.cmbRaion_Obl.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbRaion_Obl.FormattingEnabled = true;
			this.cmbRaion_Obl.Location = new System.Drawing.Point(9, 32);
			this.cmbRaion_Obl.Name = "cmbRaion_Obl";
			this.cmbRaion_Obl.Size = new System.Drawing.Size(185, 21);
			this.cmbRaion_Obl.TabIndex = 1;
			this.cmbRaion_Obl.ValueMember = "tR_KladrObj.Id";
			this.cmbRaion_Obl.SelectedIndexChanged += new System.EventHandler(this.cmbRaion_Obl_SelectedIndexChanged);
			this.dataSet_3.DataSetName = "NewDataSet";
			this.dataSet_3.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dataTable_2
			});
			this.dataTable_2.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn_12,
				this.dataColumn_13,
				this.dataColumn_14,
				this.dataColumn_15
			});
			this.dataTable_2.TableName = "tR_KladrObj";
			this.dataColumn_12.ColumnName = "Id";
			this.dataColumn_12.DataType = typeof(int);
			this.dataColumn_13.ColumnName = "Name";
			this.dataColumn_14.ColumnName = "Socr";
			this.dataColumn_15.ColumnName = "NameSocr";
			this.dataColumn_15.Expression = "Name + ' ' + Socr";
			this.dataColumn_15.ReadOnly = true;
			this.labelRaion_Obl.AutoSize = true;
			this.labelRaion_Obl.Location = new System.Drawing.Point(6, 16);
			this.labelRaion_Obl.Name = "labelRaion_Obl";
			this.labelRaion_Obl.Size = new System.Drawing.Size(50, 13);
			this.labelRaion_Obl.TabIndex = 0;
			this.labelRaion_Obl.Text = "Область";
			this.toolStripRaion.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnShowDeleteRaions,
				this.aVffuKoEfC,
				this.toolBtnFindRaion
			});
			this.toolStripRaion.Location = new System.Drawing.Point(3, 3);
			this.toolStripRaion.Name = "toolStripRaion";
			this.toolStripRaion.Size = new System.Drawing.Size(271, 25);
			this.toolStripRaion.TabIndex = 0;
			this.toolStripRaion.Text = "toolStrip1";
			this.toolBtnShowDeleteRaions.CheckOnClick = true;
			this.toolBtnShowDeleteRaions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnShowDeleteRaions.Image = Reference.Properties.Resources.smethod_24();
			this.toolBtnShowDeleteRaions.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDeleteRaions.Name = "toolBtnShowDeleteRaions";
			this.toolBtnShowDeleteRaions.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDeleteRaions.Text = "Показать удаленные";
			this.toolBtnShowDeleteRaions.Click += new System.EventHandler(this.toolBtnShowDeleteRaions_Click);
			this.aVffuKoEfC.Name = "toolTxtFindRaion";
			this.aVffuKoEfC.Size = new System.Drawing.Size(100, 25);
			this.aVffuKoEfC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aVffuKoEfC_KeyDown);
			this.toolBtnFindRaion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnFindRaion.Image = Reference.Properties.Resources.smethod_14();
			this.toolBtnFindRaion.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnFindRaion.Name = "toolBtnFindRaion";
			this.toolBtnFindRaion.Size = new System.Drawing.Size(23, 22);
			this.toolBtnFindRaion.Text = "Поиск";
			this.toolBtnFindRaion.Click += new System.EventHandler(this.toolBtnFindRaion_Click);
			this.tabPageStreet.Controls.Add(this.treeViewStreet);
			this.tabPageStreet.Controls.Add(this.groupBoxStreet);
			this.tabPageStreet.Controls.Add(this.toolStripStreet);
			this.tabPageStreet.Location = new System.Drawing.Point(4, 22);
			this.tabPageStreet.Name = "tabPageStreet";
			this.tabPageStreet.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStreet.Size = new System.Drawing.Size(277, 487);
			this.tabPageStreet.TabIndex = 2;
			this.tabPageStreet.Text = "Улицы";
			this.tabPageStreet.UseVisualStyleBackColor = true;
			this.treeViewStreet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewStreet.ImageIndex = 0;
			this.treeViewStreet.ImageList = this.imageList_0;
			this.treeViewStreet.Location = new System.Drawing.Point(3, 171);
			this.treeViewStreet.Name = "treeViewStreet";
			this.treeViewStreet.SelectedImageIndex = 0;
			this.treeViewStreet.Size = new System.Drawing.Size(271, 313);
			this.treeViewStreet.TabIndex = 4;
			this.treeViewStreet.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewStreet_AfterSelect);
			this.groupBoxStreet.Controls.Add(this.cmbStreet_Punkt);
			this.groupBoxStreet.Controls.Add(this.labelStreet_Punkt);
			this.groupBoxStreet.Controls.Add(this.cmbStreet_RaionCity);
			this.groupBoxStreet.Controls.Add(this.labelStreet_RaionCity);
			this.groupBoxStreet.Controls.Add(this.cmbStreet_Obl);
			this.groupBoxStreet.Controls.Add(this.labelStreet_Obl);
			this.groupBoxStreet.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxStreet.Location = new System.Drawing.Point(3, 28);
			this.groupBoxStreet.Name = "groupBoxStreet";
			this.groupBoxStreet.Size = new System.Drawing.Size(271, 143);
			this.groupBoxStreet.TabIndex = 3;
			this.groupBoxStreet.TabStop = false;
			this.cmbStreet_Punkt.DataSource = this.dataSet_4;
			this.cmbStreet_Punkt.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbStreet_Punkt.FormattingEnabled = true;
			this.cmbStreet_Punkt.Location = new System.Drawing.Point(9, 112);
			this.cmbStreet_Punkt.Name = "cmbStreet_Punkt";
			this.cmbStreet_Punkt.Size = new System.Drawing.Size(185, 21);
			this.cmbStreet_Punkt.TabIndex = 5;
			this.cmbStreet_Punkt.ValueMember = "tR_KladrObj.Id";
			this.cmbStreet_Punkt.SelectedIndexChanged += new System.EventHandler(this.cmbStreet_Punkt_SelectedIndexChanged);
			this.dataSet_4.DataSetName = "NewDataSet";
			this.dataSet_4.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dataTable_3
			});
			this.dataTable_3.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn_16,
				this.dataColumn_17,
				this.dataColumn_18,
				this.dataColumn_19
			});
			this.dataTable_3.Constraints.AddRange(new System.Data.Constraint[]
			{
				new System.Data.UniqueConstraint("Constraint1", new string[]
				{
					"Id"
				}, true)
			});
			this.dataTable_3.PrimaryKey = new System.Data.DataColumn[]
			{
				this.dataColumn_16
			};
			this.dataTable_3.TableName = "tR_KladrObj";
			this.dataColumn_16.AllowDBNull = false;
			this.dataColumn_16.ColumnName = "Id";
			this.dataColumn_16.DataType = typeof(int);
			this.dataColumn_17.ColumnName = "Name";
			this.dataColumn_18.ColumnName = "Socr";
			this.dataColumn_19.ColumnName = "NameSocr";
			this.dataColumn_19.Expression = "Name + ' ' + Socr";
			this.dataColumn_19.ReadOnly = true;
			this.labelStreet_Punkt.AutoSize = true;
			this.labelStreet_Punkt.Location = new System.Drawing.Point(6, 96);
			this.labelStreet_Punkt.Name = "labelStreet_Punkt";
			this.labelStreet_Punkt.Size = new System.Drawing.Size(102, 13);
			this.labelStreet_Punkt.TabIndex = 4;
			this.labelStreet_Punkt.Text = "Населенный пункт";
			this.cmbStreet_RaionCity.DataSource = this.dataSet_5;
			this.cmbStreet_RaionCity.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbStreet_RaionCity.FormattingEnabled = true;
			this.cmbStreet_RaionCity.Location = new System.Drawing.Point(9, 72);
			this.cmbStreet_RaionCity.Name = "cmbStreet_RaionCity";
			this.cmbStreet_RaionCity.Size = new System.Drawing.Size(185, 21);
			this.cmbStreet_RaionCity.TabIndex = 3;
			this.cmbStreet_RaionCity.ValueMember = "tR_KladrObj.Id";
			this.cmbStreet_RaionCity.SelectedIndexChanged += new System.EventHandler(this.cmbStreet_RaionCity_SelectedIndexChanged);
			this.dataSet_5.DataSetName = "NewDataSet";
			this.dataSet_5.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dataTable_4
			});
			this.dataTable_4.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn_20,
				this.dataColumn_21,
				this.dataColumn_22,
				this.dataColumn_23
			});
			this.dataTable_4.Constraints.AddRange(new System.Data.Constraint[]
			{
				new System.Data.UniqueConstraint("Constraint1", new string[]
				{
					"Id"
				}, true)
			});
			this.dataTable_4.PrimaryKey = new System.Data.DataColumn[]
			{
				this.dataColumn_20
			};
			this.dataTable_4.TableName = "tR_KladrObj";
			this.dataColumn_20.AllowDBNull = false;
			this.dataColumn_20.ColumnName = "Id";
			this.dataColumn_20.DataType = typeof(int);
			this.dataColumn_21.ColumnName = "Name";
			this.dataColumn_22.ColumnName = "Socr";
			this.dataColumn_23.ColumnName = "NameSocr";
			this.dataColumn_23.Expression = "Name + ' ' + Socr";
			this.dataColumn_23.ReadOnly = true;
			this.labelStreet_RaionCity.AutoSize = true;
			this.labelStreet_RaionCity.Location = new System.Drawing.Point(6, 56);
			this.labelStreet_RaionCity.Name = "labelStreet_RaionCity";
			this.labelStreet_RaionCity.Size = new System.Drawing.Size(72, 13);
			this.labelStreet_RaionCity.TabIndex = 2;
			this.labelStreet_RaionCity.Text = "Район/город";
			this.cmbStreet_Obl.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dataSet_0, "tR_KladrObj.Id", true));
			this.cmbStreet_Obl.DataSource = this.dataSet_0;
			this.cmbStreet_Obl.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbStreet_Obl.FormattingEnabled = true;
			this.cmbStreet_Obl.Location = new System.Drawing.Point(9, 32);
			this.cmbStreet_Obl.Name = "cmbStreet_Obl";
			this.cmbStreet_Obl.Size = new System.Drawing.Size(185, 21);
			this.cmbStreet_Obl.TabIndex = 1;
			this.cmbStreet_Obl.ValueMember = "tR_KladrObj.Id";
			this.cmbStreet_Obl.SelectedIndexChanged += new System.EventHandler(this.cmbStreet_Obl_SelectedIndexChanged);
			this.dataSet_0.DataSetName = "NewDataSet";
			this.dataSet_0.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dataTable_0
			});
			this.dataTable_0.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn_0,
				this.dataColumn_1,
				this.dataColumn_2,
				this.dataColumn_3
			});
			this.dataTable_0.Constraints.AddRange(new System.Data.Constraint[]
			{
				new System.Data.UniqueConstraint("Constraint1", new string[]
				{
					"Id"
				}, true)
			});
			this.dataTable_0.MinimumCapacity = 40;
			this.dataTable_0.PrimaryKey = new System.Data.DataColumn[]
			{
				this.dataColumn_0
			};
			this.dataTable_0.TableName = "tR_KladrObj";
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.ColumnName = "Id";
			this.dataColumn_0.DataType = typeof(int);
			this.dataColumn_1.ColumnName = "Name";
			this.dataColumn_2.ColumnName = "Socr";
			this.dataColumn_3.ColumnName = "NameSocr";
			this.dataColumn_3.Expression = "Name + ' '+ Socr";
			this.dataColumn_3.ReadOnly = true;
			this.labelStreet_Obl.AutoSize = true;
			this.labelStreet_Obl.Location = new System.Drawing.Point(6, 16);
			this.labelStreet_Obl.Name = "labelStreet_Obl";
			this.labelStreet_Obl.Size = new System.Drawing.Size(50, 13);
			this.labelStreet_Obl.TabIndex = 0;
			this.labelStreet_Obl.Text = "Область";
			this.toolStripStreet.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnShowDeleteStreet,
				this.toolTxtFindStreet,
				this.toolBtnFindStreet
			});
			this.toolStripStreet.Location = new System.Drawing.Point(3, 3);
			this.toolStripStreet.Name = "toolStripStreet";
			this.toolStripStreet.Size = new System.Drawing.Size(271, 25);
			this.toolStripStreet.TabIndex = 5;
			this.toolStripStreet.Text = "toolStrip1";
			this.toolBtnShowDeleteStreet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnShowDeleteStreet.Image = Reference.Properties.Resources.smethod_24();
			this.toolBtnShowDeleteStreet.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDeleteStreet.Name = "toolBtnShowDeleteStreet";
			this.toolBtnShowDeleteStreet.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDeleteStreet.Text = "Показать удаленных";
			this.toolBtnShowDeleteStreet.Click += new System.EventHandler(this.toolBtnShowDeleteStreet_Click);
			this.toolTxtFindStreet.Name = "toolTxtFindStreet";
			this.toolTxtFindStreet.Size = new System.Drawing.Size(100, 25);
			this.toolTxtFindStreet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTxtFindStreet_KeyDown);
			this.toolBtnFindStreet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnFindStreet.Image = Reference.Properties.Resources.smethod_14();
			this.toolBtnFindStreet.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnFindStreet.Name = "toolBtnFindStreet";
			this.toolBtnFindStreet.Size = new System.Drawing.Size(23, 22);
			this.toolBtnFindStreet.Text = "Поиск";
			this.toolBtnFindStreet.Click += new System.EventHandler(this.toolBtnFindStreet_Click);
			this.splitContainerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerGrid.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainerGrid.Location = new System.Drawing.Point(0, 0);
			this.splitContainerGrid.Name = "splitContainerGrid";
			this.splitContainerGrid.Orientation = System.Windows.Forms.Orientation.Horizontal;
			this.splitContainerGrid.Panel1.Controls.Add(this.dgvMapObj);
			this.splitContainerGrid.Panel2.Controls.Add(this.dgvMapObjParameter);
			this.splitContainerGrid.Size = new System.Drawing.Size(577, 513);
			this.splitContainerGrid.SplitterDistance = 365;
			this.splitContainerGrid.TabIndex = 1;
			this.dgvMapObj.AllowUserToAddRows = false;
			this.dgvMapObj.AllowUserToDeleteRows = false;
			this.dgvMapObj.AutoGenerateColumns = false;
			this.dgvMapObj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMapObj.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idMapDgvTextBoxColumn,
				this.raionDataGridViewTextBoxColumn,
				this.ColumnImage,
				this.streetNameDataGridViewTextBoxColumn,
				this.houseDataGridViewTextBoxColumn,
				this.housePrefixDataGridViewTextBoxColumn,
				this.raionNameDgvTextBoxColumn,
				this.indexDataGridViewTextBoxColumn,
				this.isHouseDataGridViewCheckBoxColumn,
				this.nameDgvTextBoxColumn,
				this.latitudeDataGridViewTextBoxColumn,
				this.vBkfDnumnw,
				this.commentDataGridViewTextBoxColumn,
				this.deletedDgvCheckBoxColumn,
				this.kladrObjIdDgvTextBoxColumn,
				this.streetDataGridViewTextBoxColumn
			});
			this.dgvMapObj.ContextMenuStrip = this.hAcIluWoWc;
			this.dgvMapObj.DataSource = this.bindingSource_0;
			this.dgvMapObj.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvMapObj.Location = new System.Drawing.Point(0, 0);
			this.dgvMapObj.Name = "dgvMapObj";
			this.dgvMapObj.ReadOnly = true;
			this.dgvMapObj.RowHeadersWidth = 21;
			this.dgvMapObj.Size = new System.Drawing.Size(577, 365);
			this.dgvMapObj.TabIndex = 0;
			this.dgvMapObj.VirtualMode = true;
			this.dgvMapObj.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvMapObj_CellValueNeeded);
			this.dgvMapObj.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMapObj_RowEnter);
			this.idMapDgvTextBoxColumn.DataPropertyName = "idMap";
			this.idMapDgvTextBoxColumn.HeaderText = "idMap";
			this.idMapDgvTextBoxColumn.Name = "idMapDgvTextBoxColumn";
			this.idMapDgvTextBoxColumn.ReadOnly = true;
			this.idMapDgvTextBoxColumn.Visible = false;
			this.raionDataGridViewTextBoxColumn.DataPropertyName = "Raion";
			this.raionDataGridViewTextBoxColumn.HeaderText = "Raion";
			this.raionDataGridViewTextBoxColumn.Name = "raionDataGridViewTextBoxColumn";
			this.raionDataGridViewTextBoxColumn.ReadOnly = true;
			this.raionDataGridViewTextBoxColumn.Visible = false;
			dataGridViewCellStyle.NullValue = null;
			this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle;
			this.ColumnImage.HeaderText = "";
			this.ColumnImage.Name = "ColumnImage";
			this.ColumnImage.ReadOnly = true;
			this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnImage.Width = 16;
			this.streetNameDataGridViewTextBoxColumn.DataPropertyName = "streetName";
			this.streetNameDataGridViewTextBoxColumn.HeaderText = "Улица";
			this.streetNameDataGridViewTextBoxColumn.Name = "streetNameDataGridViewTextBoxColumn";
			this.streetNameDataGridViewTextBoxColumn.ReadOnly = true;
			this.streetNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.streetNameDataGridViewTextBoxColumn.Width = 120;
			this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
			this.houseDataGridViewTextBoxColumn.HeaderText = "Дом";
			this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
			this.houseDataGridViewTextBoxColumn.ReadOnly = true;
			this.houseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.houseDataGridViewTextBoxColumn.Width = 60;
			this.housePrefixDataGridViewTextBoxColumn.DataPropertyName = "HousePrefix";
			this.housePrefixDataGridViewTextBoxColumn.HeaderText = "Префикс дома";
			this.housePrefixDataGridViewTextBoxColumn.Name = "housePrefixDataGridViewTextBoxColumn";
			this.housePrefixDataGridViewTextBoxColumn.ReadOnly = true;
			this.housePrefixDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.housePrefixDataGridViewTextBoxColumn.Width = 70;
			this.raionNameDgvTextBoxColumn.DataPropertyName = "RaionName";
			this.raionNameDgvTextBoxColumn.HeaderText = "Район";
			this.raionNameDgvTextBoxColumn.Name = "raionNameDgvTextBoxColumn";
			this.raionNameDgvTextBoxColumn.ReadOnly = true;
			this.raionNameDgvTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.raionNameDgvTextBoxColumn.Width = 70;
			this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
			this.indexDataGridViewTextBoxColumn.HeaderText = "Индекс";
			this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
			this.indexDataGridViewTextBoxColumn.ReadOnly = true;
			this.indexDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.indexDataGridViewTextBoxColumn.Width = 70;
			this.isHouseDataGridViewCheckBoxColumn.DataPropertyName = "IsHouse";
			this.isHouseDataGridViewCheckBoxColumn.HeaderText = "Дом?";
			this.isHouseDataGridViewCheckBoxColumn.Name = "isHouseDataGridViewCheckBoxColumn";
			this.isHouseDataGridViewCheckBoxColumn.ReadOnly = true;
			this.isHouseDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.isHouseDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.isHouseDataGridViewCheckBoxColumn.Width = 50;
			this.nameDgvTextBoxColumn.DataPropertyName = "Name";
			this.nameDgvTextBoxColumn.HeaderText = "Наименование";
			this.nameDgvTextBoxColumn.Name = "nameDgvTextBoxColumn";
			this.nameDgvTextBoxColumn.ReadOnly = true;
			this.nameDgvTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.latitudeDataGridViewTextBoxColumn.DataPropertyName = "Latitude";
			this.latitudeDataGridViewTextBoxColumn.HeaderText = "Широта";
			this.latitudeDataGridViewTextBoxColumn.Name = "latitudeDataGridViewTextBoxColumn";
			this.latitudeDataGridViewTextBoxColumn.ReadOnly = true;
			this.latitudeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.latitudeDataGridViewTextBoxColumn.Width = 70;
			this.vBkfDnumnw.DataPropertyName = "Longitude";
			this.vBkfDnumnw.HeaderText = "Долгота";
			this.vBkfDnumnw.Name = "longitudeDataGridViewTextBoxColumn";
			this.vBkfDnumnw.ReadOnly = true;
			this.vBkfDnumnw.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.vBkfDnumnw.Width = 70;
			this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
			this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
			this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
			this.commentDataGridViewTextBoxColumn.ReadOnly = true;
			this.commentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.deletedDgvCheckBoxColumn.DataPropertyName = "Deleted";
			this.deletedDgvCheckBoxColumn.HeaderText = "Deleted";
			this.deletedDgvCheckBoxColumn.Name = "deletedDgvCheckBoxColumn";
			this.deletedDgvCheckBoxColumn.ReadOnly = true;
			this.deletedDgvCheckBoxColumn.Visible = false;
			this.kladrObjIdDgvTextBoxColumn.DataPropertyName = "KladrObjId";
			this.kladrObjIdDgvTextBoxColumn.HeaderText = "KladrObjId";
			this.kladrObjIdDgvTextBoxColumn.Name = "kladrObjIdDgvTextBoxColumn";
			this.kladrObjIdDgvTextBoxColumn.ReadOnly = true;
			this.kladrObjIdDgvTextBoxColumn.Visible = false;
			this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
			this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
			this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
			this.streetDataGridViewTextBoxColumn.ReadOnly = true;
			this.streetDataGridViewTextBoxColumn.Visible = false;
			this.hAcIluWoWc.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuItemAddObj,
				this.toolMenuItemEditObj,
				this.toolMenuItemDelObj,
				this.toolStripSeparator1,
				this.toolMenuItemCopyObj,
				this.toolMenuItemExcelObj,
				this.fCbIjhllk4
			});
			this.hAcIluWoWc.Name = "contextMenuDgvMapObj";
			this.hAcIluWoWc.Size = new System.Drawing.Size(158, 142);
			this.toolMenuItemAddObj.Image = Reference.Properties.Resources.smethod_2();
			this.toolMenuItemAddObj.Name = "toolMenuItemAddObj";
			this.toolMenuItemAddObj.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemAddObj.Text = "Добавить";
			this.toolMenuItemAddObj.Click += new System.EventHandler(this.toolMenuItemAddObj_Click);
			this.toolMenuItemEditObj.Image = Reference.Properties.Resources.smethod_4();
			this.toolMenuItemEditObj.Name = "toolMenuItemEditObj";
			this.toolMenuItemEditObj.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemEditObj.Text = "Редактировать";
			this.toolMenuItemEditObj.Click += new System.EventHandler(this.toolMenuItemEditObj_Click);
			this.toolMenuItemDelObj.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuItemDelObjCheck,
				this.toolMenuItemDelObjFull
			});
			this.toolMenuItemDelObj.Image = Reference.Properties.Resources.smethod_3();
			this.toolMenuItemDelObj.Name = "toolMenuItemDelObj";
			this.toolMenuItemDelObj.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemDelObj.Text = "Удалить";
			this.toolMenuItemDelObjCheck.Name = "toolMenuItemDelObjCheck";
			this.toolMenuItemDelObjCheck.Size = new System.Drawing.Size(198, 22);
			this.toolMenuItemDelObjCheck.Text = "Пометить на удаление";
			this.toolMenuItemDelObjCheck.Click += new System.EventHandler(this.toolMenuItemDelObjCheck_Click);
			this.toolMenuItemDelObjFull.Name = "toolMenuItemDelObjFull";
			this.toolMenuItemDelObjFull.Size = new System.Drawing.Size(198, 22);
			this.toolMenuItemDelObjFull.Text = "Удалить полностью";
			this.toolMenuItemDelObjFull.Click += new System.EventHandler(this.toolMenuItemDelObjFull_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
			this.toolMenuItemCopyObj.Image = Reference.Properties.Resources.smethod_6();
			this.toolMenuItemCopyObj.Name = "toolMenuItemCopyObj";
			this.toolMenuItemCopyObj.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemCopyObj.Text = "Копировать";
			this.toolMenuItemCopyObj.Click += new System.EventHandler(this.toolMenuItemCopyObj_Click);
			this.toolMenuItemExcelObj.Image = Reference.Properties.Resources.smethod_13();
			this.toolMenuItemExcelObj.Name = "toolMenuItemExcelObj";
			this.toolMenuItemExcelObj.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemExcelObj.Text = "Экспорт в Excel";
			this.toolMenuItemExcelObj.Click += new System.EventHandler(this.toolMenuItemExcelObj_Click);
			this.fCbIjhllk4.Image = Reference.Properties.Resources.smethod_22();
			this.fCbIjhllk4.Name = "toolMenuItemPrintObj";
			this.fCbIjhllk4.Size = new System.Drawing.Size(157, 22);
			this.fCbIjhllk4.Text = "Печать";
			this.fCbIjhllk4.Click += new System.EventHandler(this.fCbIjhllk4_Click);
			this.bindingSource_0.DataMember = "vMapObj";
			this.bindingSource_0.DataSource = this.class20_0;
			this.class20_0.DataSetName = "DataSetKladr";
			this.class20_0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.dgvMapObjParameter.AllowUserToAddRows = false;
			this.dgvMapObjParameter.AllowUserToDeleteRows = false;
			this.dgvMapObjParameter.AutoGenerateColumns = false;
			this.dgvMapObjParameter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMapObjParameter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
			{
				this.idDataGridViewTextBoxColumn,
				this.mapObjIdDataGridViewTextBoxColumn,
				this.typeObjDataGridViewTextBoxColumn,
				this.otherTypeObjDataGridViewTextBoxColumn,
				this.countFloorDataGridViewTextBoxColumn,
				this.countPorchDataGridViewTextBoxColumn,
				this.countApartmentDataGridViewTextBoxColumn,
				this.yearBuiltDataGridViewTextBoxColumn,
				this.dateBeginDataGridViewTextBoxColumn,
				this.dateEndDataGridViewTextBoxColumn,
				this.reasonEndDataGridViewTextBoxColumn,
				this.commentDataGridViewTextBoxColumn1
			});
			this.dgvMapObjParameter.ContextMenuStrip = this.contextMenuDgvMapObj_1;
			this.dgvMapObjParameter.DataSource = this.bindingSource_1;
			this.dgvMapObjParameter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvMapObjParameter.Location = new System.Drawing.Point(0, 0);
			this.dgvMapObjParameter.Name = "dgvMapObjParameter";
			this.dgvMapObjParameter.ReadOnly = true;
			this.dgvMapObjParameter.RowHeadersWidth = 20;
			this.dgvMapObjParameter.Size = new System.Drawing.Size(577, 144);
			this.dgvMapObjParameter.TabIndex = 0;
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			this.mapObjIdDataGridViewTextBoxColumn.DataPropertyName = "MapObjId";
			this.mapObjIdDataGridViewTextBoxColumn.HeaderText = "MapObjId";
			this.mapObjIdDataGridViewTextBoxColumn.Name = "mapObjIdDataGridViewTextBoxColumn";
			this.mapObjIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.mapObjIdDataGridViewTextBoxColumn.Visible = false;
			this.typeObjDataGridViewTextBoxColumn.DataPropertyName = "TypeObj";
			this.typeObjDataGridViewTextBoxColumn.DataSource = this.class20_0;
			this.typeObjDataGridViewTextBoxColumn.DisplayMember = "tR_Classifier.Name";
			this.typeObjDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.typeObjDataGridViewTextBoxColumn.HeaderText = "Тип";
			this.typeObjDataGridViewTextBoxColumn.Name = "typeObjDataGridViewTextBoxColumn";
			this.typeObjDataGridViewTextBoxColumn.ReadOnly = true;
			this.typeObjDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.typeObjDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.typeObjDataGridViewTextBoxColumn.ValueMember = "tR_Classifier.Id";
			this.otherTypeObjDataGridViewTextBoxColumn.DataPropertyName = "OtherTypeObj";
			this.otherTypeObjDataGridViewTextBoxColumn.DataSource = this.class20_0;
			this.otherTypeObjDataGridViewTextBoxColumn.DisplayMember = "tR_Classifier.Name";
			this.otherTypeObjDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.otherTypeObjDataGridViewTextBoxColumn.HeaderText = "Расш тип";
			this.otherTypeObjDataGridViewTextBoxColumn.Name = "otherTypeObjDataGridViewTextBoxColumn";
			this.otherTypeObjDataGridViewTextBoxColumn.ReadOnly = true;
			this.otherTypeObjDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.otherTypeObjDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.otherTypeObjDataGridViewTextBoxColumn.ValueMember = "tR_Classifier.Id";
			this.countFloorDataGridViewTextBoxColumn.DataPropertyName = "CountFloor";
			this.countFloorDataGridViewTextBoxColumn.HeaderText = "Этажность";
			this.countFloorDataGridViewTextBoxColumn.Name = "countFloorDataGridViewTextBoxColumn";
			this.countFloorDataGridViewTextBoxColumn.ReadOnly = true;
			this.countFloorDataGridViewTextBoxColumn.Width = 50;
			this.countPorchDataGridViewTextBoxColumn.DataPropertyName = "CountPorch";
			this.countPorchDataGridViewTextBoxColumn.HeaderText = "Подъездность";
			this.countPorchDataGridViewTextBoxColumn.Name = "countPorchDataGridViewTextBoxColumn";
			this.countPorchDataGridViewTextBoxColumn.ReadOnly = true;
			this.countPorchDataGridViewTextBoxColumn.Width = 50;
			this.countApartmentDataGridViewTextBoxColumn.DataPropertyName = "CountApartment";
			this.countApartmentDataGridViewTextBoxColumn.HeaderText = "Квартирность";
			this.countApartmentDataGridViewTextBoxColumn.Name = "countApartmentDataGridViewTextBoxColumn";
			this.countApartmentDataGridViewTextBoxColumn.ReadOnly = true;
			this.countApartmentDataGridViewTextBoxColumn.Width = 50;
			this.yearBuiltDataGridViewTextBoxColumn.DataPropertyName = "YearBuilt";
			this.yearBuiltDataGridViewTextBoxColumn.HeaderText = "Дата постройки";
			this.yearBuiltDataGridViewTextBoxColumn.Name = "yearBuiltDataGridViewTextBoxColumn";
			this.yearBuiltDataGridViewTextBoxColumn.ReadOnly = true;
			this.yearBuiltDataGridViewTextBoxColumn.Width = 70;
			this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "dateBegin";
			dataGridViewCellStyle2.Format = "d";
			dataGridViewCellStyle2.NullValue = null;
			this.dateBeginDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.dateBeginDataGridViewTextBoxColumn.HeaderText = "Начало";
			this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
			this.dateBeginDataGridViewTextBoxColumn.ReadOnly = true;
			this.dateBeginDataGridViewTextBoxColumn.Width = 70;
			this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "dateEnd";
			dataGridViewCellStyle3.Format = "d";
			dataGridViewCellStyle3.NullValue = null;
			this.dateEndDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
			this.dateEndDataGridViewTextBoxColumn.HeaderText = "Конец";
			this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
			this.dateEndDataGridViewTextBoxColumn.ReadOnly = true;
			this.dateEndDataGridViewTextBoxColumn.Width = 70;
			this.reasonEndDataGridViewTextBoxColumn.DataPropertyName = "ReasonEnd";
			this.reasonEndDataGridViewTextBoxColumn.DataSource = this.class20_0;
			this.reasonEndDataGridViewTextBoxColumn.DisplayMember = "tR_Classifier.Name";
			this.reasonEndDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.reasonEndDataGridViewTextBoxColumn.HeaderText = "Причина";
			this.reasonEndDataGridViewTextBoxColumn.Name = "reasonEndDataGridViewTextBoxColumn";
			this.reasonEndDataGridViewTextBoxColumn.ReadOnly = true;
			this.reasonEndDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.reasonEndDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.reasonEndDataGridViewTextBoxColumn.ValueMember = "tR_Classifier.Id";
			this.commentDataGridViewTextBoxColumn1.DataPropertyName = "Comment";
			this.commentDataGridViewTextBoxColumn1.HeaderText = "Комментарий";
			this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
			this.commentDataGridViewTextBoxColumn1.ReadOnly = true;
			this.contextMenuDgvMapObj_1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuAddObjParam,
				this.toolMenuEditObjParam,
				this.toolMenuItemDelObjParam,
				this.toolStripSeparator2,
				this.TqdIidAoTN,
				this.toolMenuExportObjParam,
				this.toolMenuPrintObjParam
			});
			this.contextMenuDgvMapObj_1.Name = "contextMenuDgvMapObj";
			this.contextMenuDgvMapObj_1.Size = new System.Drawing.Size(158, 142);
			this.toolMenuAddObjParam.Image = Reference.Properties.Resources.smethod_2();
			this.toolMenuAddObjParam.Name = "toolMenuAddObjParam";
			this.toolMenuAddObjParam.Size = new System.Drawing.Size(157, 22);
			this.toolMenuAddObjParam.Text = "Добавить";
			this.toolMenuAddObjParam.Click += new System.EventHandler(this.toolMenuAddObjParam_Click);
			this.toolMenuEditObjParam.Image = Reference.Properties.Resources.smethod_4();
			this.toolMenuEditObjParam.Name = "toolMenuEditObjParam";
			this.toolMenuEditObjParam.Size = new System.Drawing.Size(157, 22);
			this.toolMenuEditObjParam.Text = "Редактировать";
			this.toolMenuEditObjParam.Click += new System.EventHandler(this.toolMenuEditObjParam_Click);
			this.toolMenuItemDelObjParam.Image = Reference.Properties.Resources.smethod_3();
			this.toolMenuItemDelObjParam.Name = "toolMenuItemDelObjParam";
			this.toolMenuItemDelObjParam.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemDelObjParam.Text = "Удалить";
			this.toolMenuItemDelObjParam.Click += new System.EventHandler(this.toolMenuItemDelObjParam_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
			this.TqdIidAoTN.Image = Reference.Properties.Resources.smethod_6();
			this.TqdIidAoTN.Name = "toolMenuCopyObjParam";
			this.TqdIidAoTN.Size = new System.Drawing.Size(157, 22);
			this.TqdIidAoTN.Text = "Копировать";
			this.TqdIidAoTN.Click += new System.EventHandler(this.TqdIidAoTN_Click);
			this.toolMenuExportObjParam.Image = Reference.Properties.Resources.smethod_13();
			this.toolMenuExportObjParam.Name = "toolMenuExportObjParam";
			this.toolMenuExportObjParam.Size = new System.Drawing.Size(157, 22);
			this.toolMenuExportObjParam.Text = "Экспорт в Excel";
			this.toolMenuExportObjParam.Click += new System.EventHandler(this.toolMenuExportObjParam_Click);
			this.toolMenuPrintObjParam.Image = Reference.Properties.Resources.smethod_22();
			this.toolMenuPrintObjParam.Name = "toolMenuPrintObjParam";
			this.toolMenuPrintObjParam.Size = new System.Drawing.Size(157, 22);
			this.toolMenuPrintObjParam.Text = "Печать";
			this.toolMenuPrintObjParam.Click += new System.EventHandler(this.toolMenuPrintObjParam_Click);
			this.bindingSource_1.DataMember = "vMapObj_tMapObjParameter";
			this.bindingSource_1.DataSource = this.bindingSource_0;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(866, 538);
			base.Controls.Add(this.splitContainerMain);
			base.Controls.Add(this.toolStripMain);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "FormMapObj";
			this.Text = "Справочник объектов(домов)";
			base.Load += new System.EventHandler(this.FormMapObj_Load);
			this.toolStripMain.ResumeLayout(false);
			this.toolStripMain.PerformLayout();
			this.splitContainerMain.Panel1.ResumeLayout(false);
			this.splitContainerMain.Panel2.ResumeLayout(false);
			this.splitContainerMain.ResumeLayout(false);
			this.tabControlTree.ResumeLayout(false);
			this.tabPagePunkts.ResumeLayout(false);
			this.tabPagePunkts.PerformLayout();
			this.toolStripTreePunkts.ResumeLayout(false);
			this.toolStripTreePunkts.PerformLayout();
			this.tabPageRaions.ResumeLayout(false);
			this.tabPageRaions.PerformLayout();
			this.groupBoxRaion.ResumeLayout(false);
			this.groupBoxRaion.PerformLayout();
			this.toolStripRaion.ResumeLayout(false);
			this.toolStripRaion.PerformLayout();
			this.tabPageStreet.ResumeLayout(false);
			this.tabPageStreet.PerformLayout();
			this.groupBoxStreet.ResumeLayout(false);
			this.groupBoxStreet.PerformLayout();
			this.toolStripStreet.ResumeLayout(false);
			this.toolStripStreet.PerformLayout();
			this.splitContainerGrid.Panel1.ResumeLayout(false);
			this.splitContainerGrid.Panel2.ResumeLayout(false);
			this.splitContainerGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dgvMapObj).EndInit();
			this.hAcIluWoWc.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.bindingSource_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.class20_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvMapObjParameter).EndInit();
			this.contextMenuDgvMapObj_1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.bindingSource_1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dataSet_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_0).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.TSWHYESWDA).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_3).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_5).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_4).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_4).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_3).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataSet_1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataTable_1).EndInit();
		}

		private System.ComponentModel.IContainer icontainer_0;

		private System.Windows.Forms.ToolStrip toolStripMain;

		private System.Windows.Forms.SplitContainer splitContainerMain;

		private System.Windows.Forms.TreeView treeViewPunkts;

		private Class20 class20_0;

		private System.Windows.Forms.ImageList imageList_0;

		private System.Windows.Forms.TabControl tabControlTree;

		private System.Windows.Forms.TabPage tabPagePunkts;

		private System.Windows.Forms.ToolStrip toolStripTreePunkts;

		private System.Windows.Forms.TabPage tabPageRaions;

		private System.Windows.Forms.ToolStrip toolStripRaion;

		private System.Windows.Forms.TabPage tabPageStreet;

		private System.Windows.Forms.ToolStripButton toolBtnShowDeletePunkts;

		private System.Windows.Forms.GroupBox groupBoxRaion;

		private System.Windows.Forms.ToolStripButton toolBtnShowDeleteRaions;

		private System.Windows.Forms.Label labelRaion_Obl;

		private System.Windows.Forms.ComboBox cmbRaion_Punkt;

		private System.Windows.Forms.Label labelRaion_Punkt;

		private System.Windows.Forms.ComboBox cmbRaion_RaionCity;

		private System.Windows.Forms.Label labelRaion_RaionCity;

		private System.Windows.Forms.ComboBox cmbRaion_Obl;

		private System.Windows.Forms.TreeView treeViewRaion;

		private System.Windows.Forms.TreeView treeViewStreet;

		private System.Windows.Forms.GroupBox groupBoxStreet;

		private System.Windows.Forms.ComboBox cmbStreet_Punkt;

		private System.Windows.Forms.Label labelStreet_Punkt;

		private System.Windows.Forms.ComboBox cmbStreet_RaionCity;

		private System.Windows.Forms.Label labelStreet_RaionCity;

		private System.Windows.Forms.ComboBox cmbStreet_Obl;

		private System.Windows.Forms.Label labelStreet_Obl;

		private System.Windows.Forms.ToolStrip toolStripStreet;

		private System.Windows.Forms.ToolStripButton toolBtnShowDeleteStreet;

		private System.Data.DataSet dataSet_0;

		private System.Data.DataTable dataTable_0;

		private System.Data.DataColumn dataColumn_0;

		private System.Data.DataColumn dataColumn_1;

		private System.Data.DataColumn dataColumn_2;

		private System.Data.DataColumn dataColumn_3;

		private System.Data.DataSet dataSet_1;

		private System.Data.DataTable dataTable_1;

		private System.Data.DataColumn dataColumn_4;

		private System.Data.DataColumn dataColumn_5;

		private System.Data.DataColumn dataColumn_6;

		private System.Data.DataColumn dataColumn_7;

		private System.Data.DataSet dataSet_2;

		private System.Data.DataTable TSWHYESWDA;

		private System.Data.DataColumn dataColumn_8;

		private System.Data.DataColumn dataColumn_9;

		private System.Data.DataColumn dataColumn_10;

		private System.Data.DataColumn dataColumn_11;

		private System.Data.DataSet dataSet_3;

		private System.Data.DataTable dataTable_2;

		private System.Data.DataColumn dataColumn_12;

		private System.Data.DataColumn dataColumn_13;

		private System.Data.DataColumn dataColumn_14;

		private System.Data.DataColumn dataColumn_15;

		private System.Data.DataSet dataSet_4;

		private System.Data.DataTable dataTable_3;

		private System.Data.DataColumn dataColumn_16;

		private System.Data.DataColumn dataColumn_17;

		private System.Data.DataColumn dataColumn_18;

		private System.Data.DataColumn dataColumn_19;

		private System.Data.DataSet dataSet_5;

		private System.Data.DataTable dataTable_4;

		private System.Data.DataColumn dataColumn_20;

		private System.Data.DataColumn dataColumn_21;

		private System.Data.DataColumn dataColumn_22;

		private System.Data.DataColumn dataColumn_23;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvMapObj;

		private System.Windows.Forms.BindingSource bindingSource_0;

		private System.Windows.Forms.ToolStripButton toolBtnShowDeleteMapObj;

		private System.Windows.Forms.ToolStripTextBox toolTxtFindPunkts;

		private System.Windows.Forms.ToolStripButton toolBtnFindPunkts;

		private System.Windows.Forms.ToolStripTextBox aVffuKoEfC;

		private System.Windows.Forms.ToolStripButton toolBtnFindRaion;

		private System.Windows.Forms.ToolStripTextBox toolTxtFindStreet;

		private System.Windows.Forms.ToolStripButton toolBtnFindStreet;

		private System.Windows.Forms.SplitContainer splitContainerGrid;

		private System.Windows.Forms.BindingSource bindingSource_1;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvMapObjParameter;

		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn mapObjIdDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewComboBoxColumn typeObjDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewComboBoxColumn otherTypeObjDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn countFloorDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn countPorchDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn countApartmentDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn yearBuiltDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewComboBoxColumn reasonEndDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;

		private System.Windows.Forms.ToolStripSeparator KjofMhfvQl;

		private System.Windows.Forms.ToolStripButton toolBtnAddObj;

		private System.Windows.Forms.ToolStripButton toolBtnEditObj;

		private System.Windows.Forms.DataGridViewTextBoxColumn idMapDgvTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn raionDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull ColumnImage;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn streetNameDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn houseDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn housePrefixDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn raionNameDgvTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn indexDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn isHouseDataGridViewCheckBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDgvTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn latitudeDataGridViewTextBoxColumn;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn vBkfDnumnw;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn commentDataGridViewTextBoxColumn;

		private System.Windows.Forms.DataGridViewCheckBoxColumn deletedDgvCheckBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn kladrObjIdDgvTextBoxColumn;

		private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;

		private System.Windows.Forms.ToolStripButton toolBtnDelObj;

		private System.Windows.Forms.ToolStripButton toolBtnDelObjFull;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorMapObj;

		private System.Windows.Forms.ToolStripButton tootBtnAddParam;

		private System.Windows.Forms.ToolStripButton toolBtnEditParam;

		private System.Windows.Forms.ToolStripButton toolBtnDelParam;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorParam;

		private System.Windows.Forms.ToolStripButton toolStripButtonFind;

		private System.Windows.Forms.ToolStripTextBox YaqfzqmoJo;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		private System.Windows.Forms.ToolStripButton toolStripButtonPrint;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;

		private System.Windows.Forms.ContextMenuStrip hAcIluWoWc;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemAddObj;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemEditObj;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelObj;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelObjCheck;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelObjFull;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemCopyObj;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemExcelObj;

		private System.Windows.Forms.ToolStripMenuItem fCbIjhllk4;

		private System.Windows.Forms.ContextMenuStrip contextMenuDgvMapObj_1;

		private System.Windows.Forms.ToolStripMenuItem toolMenuAddObjParam;

		private System.Windows.Forms.ToolStripMenuItem toolMenuEditObjParam;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelObjParam;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		private System.Windows.Forms.ToolStripMenuItem TqdIidAoTN;

		private System.Windows.Forms.ToolStripMenuItem toolMenuExportObjParam;

		private System.Windows.Forms.ToolStripMenuItem toolMenuPrintObjParam;
	}
}
