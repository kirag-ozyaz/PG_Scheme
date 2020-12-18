using System;
using ReferenceMapObj.DataSets;

namespace ReferenceMapObj
{
	public partial class FormMapObj : FormLbr.FormBase
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMapObj));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStripMain = new System.Windows.Forms.ToolStrip();
			this.toolBtnShowDeleteMapObj = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparatorShowDelete = new System.Windows.Forms.ToolStripSeparator();
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
			this.tabControlTree = new System.Windows.Forms.TabControl();
			this.tabPagePunkts = new System.Windows.Forms.TabPage();
			this.treeViewPunkts = new System.Windows.Forms.TreeView();
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.toolStripTreePunkts = new System.Windows.Forms.ToolStrip();
			this.toolBtnShowDeletePunkts = new System.Windows.Forms.ToolStripButton();
			this.toolTxtFindPunkts = new System.Windows.Forms.ToolStripTextBox();
			this.toolBtnFindPunkts = new System.Windows.Forms.ToolStripButton();
			this.tabPageRaions = new System.Windows.Forms.TabPage();
			this.treeViewRaion = new System.Windows.Forms.TreeView();
			this.groupBoxRaion = new System.Windows.Forms.GroupBox();
			this.cmbRaion_Punkt = new System.Windows.Forms.ComboBox();
			this.dsRaion_Punkt = new System.Data.DataSet();
			this.dtRaion_Punkt = new System.Data.DataTable();
			this.dataColumn4 = new System.Data.DataColumn();
			this.dataColumn5 = new System.Data.DataColumn();
			this.dataColumn6 = new System.Data.DataColumn();
			this.dataColumn7 = new System.Data.DataColumn();
			this.labelRaion_Punkt = new System.Windows.Forms.Label();
			this.cmbRaion_RaionCity = new System.Windows.Forms.ComboBox();
			this.dsRaion_RaionCity = new System.Data.DataSet();
			this.dtRaion_RaionCity = new System.Data.DataTable();
			this.dataColumn8 = new System.Data.DataColumn();
			this.dataColumn9 = new System.Data.DataColumn();
			this.dataColumn10 = new System.Data.DataColumn();
			this.dataColumn11 = new System.Data.DataColumn();
			this.labelRaion_RaionCity = new System.Windows.Forms.Label();
			this.cmbRaion_Obl = new System.Windows.Forms.ComboBox();
			this.dsRaion_Obl = new System.Data.DataSet();
			this.dtRaion_Obl = new System.Data.DataTable();
			this.dataColumn12 = new System.Data.DataColumn();
			this.dataColumn13 = new System.Data.DataColumn();
			this.dataColumn14 = new System.Data.DataColumn();
			this.dataColumn15 = new System.Data.DataColumn();
			this.labelRaion_Obl = new System.Windows.Forms.Label();
			this.toolStripRaion = new System.Windows.Forms.ToolStrip();
			this.toolBtnShowDeleteRaions = new System.Windows.Forms.ToolStripButton();
			this.toolTxtFindRaion = new System.Windows.Forms.ToolStripTextBox();
			this.toolBtnFindRaion = new System.Windows.Forms.ToolStripButton();
			this.tabPageStreet = new System.Windows.Forms.TabPage();
			this.treeViewStreet = new System.Windows.Forms.TreeView();
			this.groupBoxStreet = new System.Windows.Forms.GroupBox();
			this.cmbStreet_Punkt = new System.Windows.Forms.ComboBox();
			this.dsStreet_Punkt = new System.Data.DataSet();
			this.dtStreet_Punkt = new System.Data.DataTable();
			this.dataColumn16 = new System.Data.DataColumn();
			this.dataColumn17 = new System.Data.DataColumn();
			this.dataColumn18 = new System.Data.DataColumn();
			this.dataColumn19 = new System.Data.DataColumn();
			this.labelStreet_Punkt = new System.Windows.Forms.Label();
			this.cmbStreet_RaionCity = new System.Windows.Forms.ComboBox();
			this.dsStreet_RaionCity = new System.Data.DataSet();
			this.dtStreet_RaionCity = new System.Data.DataTable();
			this.dataColumn20 = new System.Data.DataColumn();
			this.dataColumn21 = new System.Data.DataColumn();
			this.dataColumn22 = new System.Data.DataColumn();
			this.dataColumn23 = new System.Data.DataColumn();
			this.labelStreet_RaionCity = new System.Windows.Forms.Label();
			this.cmbStreet_Obl = new System.Windows.Forms.ComboBox();
			this.dsStreet_Obl = new System.Data.DataSet();
			this.dtStreet_Obl = new System.Data.DataTable();
			this.dataColumn24 = new System.Data.DataColumn();
			this.dataColumn1 = new System.Data.DataColumn();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataColumn3 = new System.Data.DataColumn();
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
			this.longitudeDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.commentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
			this.deletedDgvCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.kladrObjIdDgvTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuDgvMapObj = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolMenuItemAddObj = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemEditObj = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelObj = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelObjCheck = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelObjFull = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolMenuItemCopyObj = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemExcelObj = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemPrintObj = new System.Windows.Forms.ToolStripMenuItem();
			this.bindingSourceMapObj = new System.Windows.Forms.BindingSource(this.components);
			this.dsKladr = new DataSetKladr();
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
			this.contextMenuDgvMapObjParam = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolMenuAddObjParam = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuEditObjParam = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItemDelObjParam = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolMenuCopyObjParam = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuExportObjParam = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuPrintObjParam = new System.Windows.Forms.ToolStripMenuItem();
			this.bindingSourceMapObjParameter = new System.Windows.Forms.BindingSource(this.components);
			this.toolStripMain.SuspendLayout();
			this.splitContainerMain.Panel1.SuspendLayout();
			this.splitContainerMain.Panel2.SuspendLayout();
			this.splitContainerMain.SuspendLayout();
			this.tabControlTree.SuspendLayout();
			this.tabPagePunkts.SuspendLayout();
			this.toolStripTreePunkts.SuspendLayout();
			this.tabPageRaions.SuspendLayout();
			this.groupBoxRaion.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dsRaion_Punkt).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dtRaion_Punkt).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dsRaion_RaionCity).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dtRaion_RaionCity).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dsRaion_Obl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dtRaion_Obl).BeginInit();
			this.toolStripRaion.SuspendLayout();
			this.tabPageStreet.SuspendLayout();
			this.groupBoxStreet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dsStreet_Punkt).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dtStreet_Punkt).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dsStreet_RaionCity).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dtStreet_RaionCity).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dsStreet_Obl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dtStreet_Obl).BeginInit();
			this.toolStripStreet.SuspendLayout();
			this.splitContainerGrid.Panel1.SuspendLayout();
			this.splitContainerGrid.Panel2.SuspendLayout();
			this.splitContainerGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvMapObj).BeginInit();
			this.contextMenuDgvMapObj.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSourceMapObj).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dsKladr).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dgvMapObjParameter).BeginInit();
			this.contextMenuDgvMapObjParam.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.bindingSourceMapObjParameter).BeginInit();
			base.SuspendLayout();
			this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnShowDeleteMapObj,
				this.toolStripSeparatorShowDelete,
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
			this.toolStripMain.Size = new System.Drawing.Size(866, 25);
			this.toolStripMain.TabIndex = 0;
			this.toolStripMain.Text = "toolStrip1";
			this.toolBtnShowDeleteMapObj.CheckOnClick = true;
			this.toolBtnShowDeleteMapObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnShowDeleteMapObj.Image = Properties.Resources.Trash;
			this.toolBtnShowDeleteMapObj.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDeleteMapObj.Name = "toolBtnShowDeleteMapObj";
			this.toolBtnShowDeleteMapObj.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDeleteMapObj.Text = "Показать удаленные объекты";
			this.toolBtnShowDeleteMapObj.Click += new System.EventHandler(this.toolBtnShowDeleteMapObj_Click);
			this.toolStripSeparatorShowDelete.Name = "toolStripSeparatorShowDelete";
			this.toolStripSeparatorShowDelete.Size = new System.Drawing.Size(6, 25);
			this.toolBtnAddObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnAddObj.Image = Properties.Resources.mapAdd;
			this.toolBtnAddObj.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolBtnAddObj.Name = "toolBtnAddObj";
			this.toolBtnAddObj.Size = new System.Drawing.Size(23, 22);
			this.toolBtnAddObj.Text = "Добавить новый объект";
			this.toolBtnAddObj.Click += new System.EventHandler(this.toolBtnAddObj_Click);
			this.toolBtnEditObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnEditObj.Image = Properties.Resources.MapEdit;
			this.toolBtnEditObj.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnEditObj.Name = "Редактирование объекта";
			this.toolBtnEditObj.Size = new System.Drawing.Size(23, 22);
			this.toolBtnEditObj.Text = "toolStripButton1";
			this.toolBtnEditObj.Click += new System.EventHandler(this.toolBtnEditObj_Click);
			this.toolBtnDelObj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDelObj.Image = Properties.Resources.mapGo;
			this.toolBtnDelObj.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDelObj.Name = "toolBtnDelObj";
			this.toolBtnDelObj.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDelObj.Text = "Пометить на удаление";
			this.toolBtnDelObj.Click += new System.EventHandler(this.toolBtnDelObj_Click);
			this.toolBtnDelObjFull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDelObjFull.Image = Properties.Resources.MapDel;
			this.toolBtnDelObjFull.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDelObjFull.Name = "toolBtnDelObjFull";
			this.toolBtnDelObjFull.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDelObjFull.Text = "Удалить полностью";
			this.toolBtnDelObjFull.Click += new System.EventHandler(this.toolBtnDelObjFull_Click);
			this.toolStripSeparatorMapObj.Name = "toolStripSeparatorMapObj";
			this.toolStripSeparatorMapObj.Size = new System.Drawing.Size(6, 25);
			this.tootBtnAddParam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tootBtnAddParam.Image = Properties.Resources.ElementAdd;
			this.tootBtnAddParam.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.tootBtnAddParam.Name = "tootBtnAddParam";
			this.tootBtnAddParam.Size = new System.Drawing.Size(23, 22);
			this.tootBtnAddParam.Text = "Добавить параметры";
			this.tootBtnAddParam.Click += new System.EventHandler(this.tootBtnAddParam_Click);
			this.toolBtnEditParam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnEditParam.Image = Properties.Resources.ElementEdit;
			this.toolBtnEditParam.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnEditParam.Name = "toolBtnEditParam";
			this.toolBtnEditParam.Size = new System.Drawing.Size(23, 22);
			this.toolBtnEditParam.Text = "Редактировать параметры";
			this.toolBtnEditParam.Click += new System.EventHandler(this.toolBtnEditParam_Click);
			this.toolBtnDelParam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnDelParam.Image = Properties.Resources.ElementDel;
			this.toolBtnDelParam.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnDelParam.Name = "toolBtnDelParam";
			this.toolBtnDelParam.Size = new System.Drawing.Size(23, 22);
			this.toolBtnDelParam.Text = "Удалить параметры";
			this.toolBtnDelParam.Click += new System.EventHandler(this.toolBtnDelParam_Click);
			this.toolStripSeparatorParam.Name = "toolStripSeparatorParam";
			this.toolStripSeparatorParam.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFind.Image = Properties.Resources.Find;
			this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFind.Name = "toolStripButtonFind";
			this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFind.Text = "Поиск";
			this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
			this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
			this.toolStripTextBoxFind.Size = new System.Drawing.Size(100, 25);
			this.toolStripTextBoxFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.YaqfzqmoJo_KeyDown);
			this.toolStripButtonFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFindPrev.Image = Properties.Resources.FindPrev;
			this.toolStripButtonFindPrev.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFindPrev.Name = "toolStripButtonFindPrev";
			this.toolStripButtonFindPrev.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFindPrev.Text = "Поиск назад";
			this.toolStripButtonFindPrev.Click += new System.EventHandler(this.toolStripButtonFindPrev_Click);
			this.toolStripButtonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonFindNext.Image = Properties.Resources.FindNext;
			this.toolStripButtonFindNext.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonFindNext.Name = "toolStripButtonFindNext";
			this.toolStripButtonFindNext.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonFindNext.Text = "Поиск вперед";
			this.toolStripButtonFindNext.Click += new System.EventHandler(this.toolStripButtonFindNext_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonPrint.Image = Properties.Resources.Print;
			this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonPrint.Name = "toolStripButtonPrint";
			this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonPrint.Text = "Печать";
			this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonExportExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonExportExcel.Image = Properties.Resources.Excel;
			this.toolStripButtonExportExcel.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolStripButtonExportExcel.Name = "toolStripButtonExportExcel";
			this.toolStripButtonExportExcel.Size = new System.Drawing.Size(23, 22);
			this.toolStripButtonExportExcel.Text = "Экспорт в Excel";
			this.toolStripButtonExportExcel.Click += new System.EventHandler(this.toolStripButtonExportExcel_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonRefresh.Image = Properties.Resources.Refresh;
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
			this.treeViewPunkts.ImageList = this.imageList;
			this.treeViewPunkts.Location = new System.Drawing.Point(3, 28);
			this.treeViewPunkts.Name = "treeViewPunkts";
			this.treeViewPunkts.SelectedImageIndex = 0;
			this.treeViewPunkts.Size = new System.Drawing.Size(271, 456);
			this.treeViewPunkts.TabIndex = 1;
			this.treeViewPunkts.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewPunkts_AfterSelect);

            this.imageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList.ImageStream");
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList.Images.SetKeyName(0, "FolderDocumentYellow.png");
			this.imageList.Images.SetKeyName(1, "FolderDeleteYellow.png");
			this.imageList.Images.SetKeyName(2, "Element.png");
			this.imageList.Images.SetKeyName(3, "ElementDelete.png");
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
			this.toolBtnShowDeletePunkts.Image = Properties.Resources.Trash;
			this.toolBtnShowDeletePunkts.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDeletePunkts.Name = "toolBtnShowDeletePunkts";
			this.toolBtnShowDeletePunkts.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDeletePunkts.Text = "Показать удаленные";
			this.toolBtnShowDeletePunkts.Click += new System.EventHandler(this.toolBtnShowDeletePunkts_Click);
			this.toolTxtFindPunkts.Name = "toolTxtFindPunkts";
			this.toolTxtFindPunkts.Size = new System.Drawing.Size(100, 25);
			this.toolTxtFindPunkts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTxtFindPunkts_KeyDown);
			this.toolBtnFindPunkts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnFindPunkts.Image = Properties.Resources.Find;
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
			this.treeViewRaion.ImageList = this.imageList;
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
			this.cmbRaion_Punkt.DataSource = this.dsRaion_Punkt;
			this.cmbRaion_Punkt.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbRaion_Punkt.FormattingEnabled = true;
			this.cmbRaion_Punkt.Location = new System.Drawing.Point(9, 112);
			this.cmbRaion_Punkt.Name = "cmbRaion_Punkt";
			this.cmbRaion_Punkt.Size = new System.Drawing.Size(185, 21);
			this.cmbRaion_Punkt.TabIndex = 5;
			this.cmbRaion_Punkt.ValueMember = "tR_KladrObj.Id";
			this.cmbRaion_Punkt.SelectedIndexChanged += new System.EventHandler(this.cmbRaion_Punkt_SelectedIndexChanged);
			this.dsRaion_Punkt.DataSetName = "NewDataSet";
			this.dsRaion_Punkt.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dtRaion_Punkt
			});
			this.dtRaion_Punkt.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn4,
				this.dataColumn5,
				this.dataColumn6,
				this.dataColumn7
			});
			this.dtRaion_Punkt.Constraints.AddRange(new System.Data.Constraint[]
			{
				new System.Data.UniqueConstraint("Constraint1", new string[]
				{
					"Id"
				}, true)
			});
			this.dtRaion_Punkt.PrimaryKey = new System.Data.DataColumn[]
			{
				this.dataColumn4
			};
			this.dtRaion_Punkt.TableName = "tR_KladrObj";
			this.dataColumn4.AllowDBNull = false;
			this.dataColumn4.ColumnName = "Id";
			this.dataColumn4.DataType = typeof(int);
			this.dataColumn5.ColumnName = "Name";
			this.dataColumn6.ColumnName = "Socr";
			this.dataColumn7.ColumnName = "NameSocr";
			this.dataColumn7.Expression = "isnull(Name, '') + ' ' + isnull(Socr, '')";
			this.dataColumn7.ReadOnly = true;
			this.labelRaion_Punkt.AutoSize = true;
			this.labelRaion_Punkt.Location = new System.Drawing.Point(6, 96);
			this.labelRaion_Punkt.Name = "labelRaion_Punkt";
			this.labelRaion_Punkt.Size = new System.Drawing.Size(102, 13);
			this.labelRaion_Punkt.TabIndex = 4;
			this.labelRaion_Punkt.Text = "Населенный пункт";
			this.cmbRaion_RaionCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbRaion_RaionCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbRaion_RaionCity.DataSource = this.dsRaion_RaionCity;
			this.cmbRaion_RaionCity.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbRaion_RaionCity.FormattingEnabled = true;
			this.cmbRaion_RaionCity.Location = new System.Drawing.Point(9, 72);
			this.cmbRaion_RaionCity.Name = "cmbRaion_RaionCity";
			this.cmbRaion_RaionCity.Size = new System.Drawing.Size(185, 21);
			this.cmbRaion_RaionCity.TabIndex = 3;
			this.cmbRaion_RaionCity.ValueMember = "tR_KladrObj.Id";
			this.cmbRaion_RaionCity.SelectedIndexChanged += new System.EventHandler(this.cmbRaion_RaionCity_SelectedIndexChanged);
			this.dsRaion_RaionCity.DataSetName = "NewDataSet";
			this.dsRaion_RaionCity.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dtRaion_RaionCity
			});
			this.dtRaion_RaionCity.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn8,
				this.dataColumn9,
				this.dataColumn10,
				this.dataColumn11
			});
			this.dtRaion_RaionCity.Constraints.AddRange(new System.Data.Constraint[]
			{
				new System.Data.UniqueConstraint("Constraint1", new string[]
				{
					"Id"
				}, true)
			});
			this.dtRaion_RaionCity.PrimaryKey = new System.Data.DataColumn[]
			{
				this.dataColumn8
			};
			this.dtRaion_RaionCity.TableName = "tR_KladrObj";
			this.dataColumn8.AllowDBNull = false;
			this.dataColumn8.ColumnName = "Id";
			this.dataColumn8.DataType = typeof(int);
			this.dataColumn9.ColumnName = "Name";
			this.dataColumn10.ColumnName = "Socr";
			this.dataColumn11.ColumnName = "NameSocr";
			this.dataColumn11.Expression = "Name + ' ' + Socr";
			this.dataColumn11.ReadOnly = true;
			this.labelRaion_RaionCity.AutoSize = true;
			this.labelRaion_RaionCity.Location = new System.Drawing.Point(6, 56);
			this.labelRaion_RaionCity.Name = "labelRaion_RaionCity";
			this.labelRaion_RaionCity.Size = new System.Drawing.Size(72, 13);
			this.labelRaion_RaionCity.TabIndex = 2;
			this.labelRaion_RaionCity.Text = "Район/город";
			this.cmbRaion_Obl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cmbRaion_Obl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbRaion_Obl.DataSource = this.dsRaion_Obl;
			this.cmbRaion_Obl.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbRaion_Obl.FormattingEnabled = true;
			this.cmbRaion_Obl.Location = new System.Drawing.Point(9, 32);
			this.cmbRaion_Obl.Name = "cmbRaion_Obl";
			this.cmbRaion_Obl.Size = new System.Drawing.Size(185, 21);
			this.cmbRaion_Obl.TabIndex = 1;
			this.cmbRaion_Obl.ValueMember = "tR_KladrObj.Id";
			this.cmbRaion_Obl.SelectedIndexChanged += new System.EventHandler(this.cmbRaion_Obl_SelectedIndexChanged);
			this.dsRaion_Obl.DataSetName = "NewDataSet";
			this.dsRaion_Obl.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dtRaion_Obl
			});
			this.dtRaion_Obl.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn12,
				this.dataColumn13,
				this.dataColumn14,
				this.dataColumn15
			});
			this.dtRaion_Obl.TableName = "tR_KladrObj";
			this.dataColumn12.ColumnName = "Id";
			this.dataColumn12.DataType = typeof(int);
			this.dataColumn13.ColumnName = "Name";
			this.dataColumn14.ColumnName = "Socr";
			this.dataColumn15.ColumnName = "NameSocr";
			this.dataColumn15.Expression = "Name + ' ' + Socr";
			this.dataColumn15.ReadOnly = true;
			this.labelRaion_Obl.AutoSize = true;
			this.labelRaion_Obl.Location = new System.Drawing.Point(6, 16);
			this.labelRaion_Obl.Name = "labelRaion_Obl";
			this.labelRaion_Obl.Size = new System.Drawing.Size(50, 13);
			this.labelRaion_Obl.TabIndex = 0;
			this.labelRaion_Obl.Text = "Область";
			this.toolStripRaion.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolBtnShowDeleteRaions,
				this.toolTxtFindRaion,
				this.toolBtnFindRaion
			});
			this.toolStripRaion.Location = new System.Drawing.Point(3, 3);
			this.toolStripRaion.Name = "toolStripRaion";
			this.toolStripRaion.Size = new System.Drawing.Size(271, 25);
			this.toolStripRaion.TabIndex = 0;
			this.toolStripRaion.Text = "toolStrip1";
			this.toolBtnShowDeleteRaions.CheckOnClick = true;
			this.toolBtnShowDeleteRaions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnShowDeleteRaions.Image = Properties.Resources.Trash;
			this.toolBtnShowDeleteRaions.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDeleteRaions.Name = "toolBtnShowDeleteRaions";
			this.toolBtnShowDeleteRaions.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDeleteRaions.Text = "Показать удаленные";
			this.toolBtnShowDeleteRaions.Click += new System.EventHandler(this.toolBtnShowDeleteRaions_Click);
			this.toolTxtFindRaion.Name = "toolTxtFindRaion";
			this.toolTxtFindRaion.Size = new System.Drawing.Size(100, 25);
			this.toolTxtFindRaion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.aVffuKoEfC_KeyDown);
			this.toolBtnFindRaion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnFindRaion.Image = Properties.Resources.Find;
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
			this.treeViewStreet.ImageList = this.imageList;
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
			this.cmbStreet_Punkt.DataSource = this.dsStreet_Punkt;
			this.cmbStreet_Punkt.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbStreet_Punkt.FormattingEnabled = true;
			this.cmbStreet_Punkt.Location = new System.Drawing.Point(9, 112);
			this.cmbStreet_Punkt.Name = "cmbStreet_Punkt";
			this.cmbStreet_Punkt.Size = new System.Drawing.Size(185, 21);
			this.cmbStreet_Punkt.TabIndex = 5;
			this.cmbStreet_Punkt.ValueMember = "tR_KladrObj.Id";
			this.cmbStreet_Punkt.SelectedIndexChanged += new System.EventHandler(this.cmbStreet_Punkt_SelectedIndexChanged);
			this.dsStreet_Punkt.DataSetName = "NewDataSet";
			this.dsStreet_Punkt.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dtStreet_Punkt
			});
			this.dtStreet_Punkt.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn16,
				this.dataColumn17,
				this.dataColumn18,
				this.dataColumn19
			});
			this.dtStreet_Punkt.Constraints.AddRange(new System.Data.Constraint[]
			{
				new System.Data.UniqueConstraint("Constraint1", new string[]
				{
					"Id"
				}, true)
			});
			this.dtStreet_Punkt.PrimaryKey = new System.Data.DataColumn[]
			{
				this.dataColumn16
			};
			this.dtStreet_Punkt.TableName = "tR_KladrObj";
			this.dataColumn16.AllowDBNull = false;
			this.dataColumn16.ColumnName = "Id";
			this.dataColumn16.DataType = typeof(int);
			this.dataColumn17.ColumnName = "Name";
			this.dataColumn18.ColumnName = "Socr";
			this.dataColumn19.ColumnName = "NameSocr";
			this.dataColumn19.Expression = "Name + ' ' + Socr";
			this.dataColumn19.ReadOnly = true;
			this.labelStreet_Punkt.AutoSize = true;
			this.labelStreet_Punkt.Location = new System.Drawing.Point(6, 96);
			this.labelStreet_Punkt.Name = "labelStreet_Punkt";
			this.labelStreet_Punkt.Size = new System.Drawing.Size(102, 13);
			this.labelStreet_Punkt.TabIndex = 4;
			this.labelStreet_Punkt.Text = "Населенный пункт";
			this.cmbStreet_RaionCity.DataSource = this.dsStreet_RaionCity;
			this.cmbStreet_RaionCity.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbStreet_RaionCity.FormattingEnabled = true;
			this.cmbStreet_RaionCity.Location = new System.Drawing.Point(9, 72);
			this.cmbStreet_RaionCity.Name = "cmbStreet_RaionCity";
			this.cmbStreet_RaionCity.Size = new System.Drawing.Size(185, 21);
			this.cmbStreet_RaionCity.TabIndex = 3;
			this.cmbStreet_RaionCity.ValueMember = "tR_KladrObj.Id";
			this.cmbStreet_RaionCity.SelectedIndexChanged += new System.EventHandler(this.cmbStreet_RaionCity_SelectedIndexChanged);
			this.dsStreet_RaionCity.DataSetName = "NewDataSet";
			this.dsStreet_RaionCity.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dtStreet_RaionCity
			});
			this.dtStreet_RaionCity.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn20,
				this.dataColumn21,
				this.dataColumn22,
				this.dataColumn23
			});
			this.dtStreet_RaionCity.Constraints.AddRange(new System.Data.Constraint[]
			{
				new System.Data.UniqueConstraint("Constraint1", new string[]
				{
					"Id"
				}, true)
			});
			this.dtStreet_RaionCity.PrimaryKey = new System.Data.DataColumn[]
			{
				this.dataColumn20
			};
			this.dtStreet_RaionCity.TableName = "tR_KladrObj";
			this.dataColumn20.AllowDBNull = false;
			this.dataColumn20.ColumnName = "Id";
			this.dataColumn20.DataType = typeof(int);
			this.dataColumn21.ColumnName = "Name";
			this.dataColumn22.ColumnName = "Socr";
			this.dataColumn23.ColumnName = "NameSocr";
			this.dataColumn23.Expression = "Name + ' ' + Socr";
			this.dataColumn23.ReadOnly = true;

            this.labelStreet_RaionCity.AutoSize = true;
			this.labelStreet_RaionCity.Location = new System.Drawing.Point(6, 56);
			this.labelStreet_RaionCity.Name = "labelStreet_RaionCity";
			this.labelStreet_RaionCity.Size = new System.Drawing.Size(72, 13);
			this.labelStreet_RaionCity.TabIndex = 2;
			this.labelStreet_RaionCity.Text = "Район/город";

            this.cmbStreet_Obl.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsStreet_Obl, "tR_KladrObj.Id", true));
            this.cmbStreet_Obl.DataSource = this.dsStreet_Obl;
			this.cmbStreet_Obl.DisplayMember = "tR_KladrObj.NameSocr";
			this.cmbStreet_Obl.FormattingEnabled = true;
			this.cmbStreet_Obl.Location = new System.Drawing.Point(9, 32);
			this.cmbStreet_Obl.Name = "cmbStreet_Obl";
			this.cmbStreet_Obl.Size = new System.Drawing.Size(185, 21);
			this.cmbStreet_Obl.TabIndex = 1;
			this.cmbStreet_Obl.ValueMember = "tR_KladrObj.Id";
			this.cmbStreet_Obl.SelectedIndexChanged += new System.EventHandler(this.cmbStreet_Obl_SelectedIndexChanged);

            this.dsStreet_Obl.DataSetName = "NewDataSet";
			this.dsStreet_Obl.Tables.AddRange(new System.Data.DataTable[]
			{
				this.dtStreet_Obl
			});
			this.dtStreet_Obl.Columns.AddRange(new System.Data.DataColumn[]
			{
				this.dataColumn24,
				this.dataColumn1,
				this.dataColumn2,
				this.dataColumn3
			});
			this.dtStreet_Obl.Constraints.AddRange(new System.Data.Constraint[]
			{
				new System.Data.UniqueConstraint("Constraint1", new string[]
				{
					"Id"
				}, true)
			});
			this.dtStreet_Obl.MinimumCapacity = 40;
			this.dtStreet_Obl.PrimaryKey = new System.Data.DataColumn[]
			{
				this.dataColumn24
			};
			this.dtStreet_Obl.TableName = "tR_KladrObj";
			this.dataColumn24.AllowDBNull = false;
			this.dataColumn24.ColumnName = "Id";
			this.dataColumn24.DataType = typeof(int);
			this.dataColumn1.ColumnName = "Name";
			this.dataColumn2.ColumnName = "Socr";
			this.dataColumn3.ColumnName = "NameSocr";
			this.dataColumn3.Expression = "Name + ' '+ Socr";
			this.dataColumn3.ReadOnly = true;
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
			this.toolBtnShowDeleteStreet.Image = Properties.Resources.Trash;
			this.toolBtnShowDeleteStreet.ImageTransparentColor = System.Drawing.Color.Transparent;
			this.toolBtnShowDeleteStreet.Name = "toolBtnShowDeleteStreet";
			this.toolBtnShowDeleteStreet.Size = new System.Drawing.Size(23, 22);
			this.toolBtnShowDeleteStreet.Text = "Показать удаленных";
			this.toolBtnShowDeleteStreet.Click += new System.EventHandler(this.toolBtnShowDeleteStreet_Click);
			this.toolTxtFindStreet.Name = "toolTxtFindStreet";
			this.toolTxtFindStreet.Size = new System.Drawing.Size(100, 25);
			this.toolTxtFindStreet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolTxtFindStreet_KeyDown);
			this.toolBtnFindStreet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolBtnFindStreet.Image = Properties.Resources.Find;
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
				this.longitudeDataGridViewTextBoxColumn,
				this.commentDataGridViewTextBoxColumn,
				this.deletedDgvCheckBoxColumn,
				this.kladrObjIdDgvTextBoxColumn,
				this.streetDataGridViewTextBoxColumn
			});
			this.dgvMapObj.ContextMenuStrip = this.contextMenuDgvMapObj;
			this.dgvMapObj.DataSource = this.bindingSourceMapObj;
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
            this.dgvMapObj.DoubleClick += new System.EventHandler(this.dgvMapObj_DoubleClick);
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
			this.longitudeDataGridViewTextBoxColumn.DataPropertyName = "Longitude";
			this.longitudeDataGridViewTextBoxColumn.HeaderText = "Долгота";
			this.longitudeDataGridViewTextBoxColumn.Name = "longitudeDataGridViewTextBoxColumn";
			this.longitudeDataGridViewTextBoxColumn.ReadOnly = true;
			this.longitudeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.longitudeDataGridViewTextBoxColumn.Width = 70;
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
			this.contextMenuDgvMapObj.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuItemAddObj,
				this.toolMenuItemEditObj,
				this.toolMenuItemDelObj,
				this.toolStripSeparator1,
				this.toolMenuItemCopyObj,
				this.toolMenuItemExcelObj,
				this.toolMenuItemPrintObj
			});
			this.contextMenuDgvMapObj.Name = "contextMenuDgvMapObj";
			this.contextMenuDgvMapObj.Size = new System.Drawing.Size(158, 142);
			this.toolMenuItemAddObj.Image = Properties.Resources.Buttonadd;
			this.toolMenuItemAddObj.Name = "toolMenuItemAddObj";
			this.toolMenuItemAddObj.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemAddObj.Text = "Добавить";
			this.toolMenuItemAddObj.Click += new System.EventHandler(this.toolMenuItemAddObj_Click);
			this.toolMenuItemEditObj.Image = Properties.Resources.ButtonEdit;
			this.toolMenuItemEditObj.Name = "toolMenuItemEditObj";
			this.toolMenuItemEditObj.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemEditObj.Text = "Редактировать";
			this.toolMenuItemEditObj.Click += new System.EventHandler(this.toolMenuItemEditObj_Click);
			this.toolMenuItemDelObj.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuItemDelObjCheck,
				this.toolMenuItemDelObjFull
			});
			this.toolMenuItemDelObj.Image = Properties.Resources.ButtonDel;
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
			this.toolMenuItemCopyObj.Image = Properties.Resources.CopyBuffer;
			this.toolMenuItemCopyObj.Name = "toolMenuItemCopyObj";
			this.toolMenuItemCopyObj.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemCopyObj.Text = "Копировать";
			this.toolMenuItemCopyObj.Click += new System.EventHandler(this.toolMenuItemCopyObj_Click);
			this.toolMenuItemExcelObj.Image = Properties.Resources.Excel;
			this.toolMenuItemExcelObj.Name = "toolMenuItemExcelObj";
			this.toolMenuItemExcelObj.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemExcelObj.Text = "Экспорт в Excel";
			this.toolMenuItemExcelObj.Click += new System.EventHandler(this.toolMenuItemExcelObj_Click);
			this.toolMenuItemPrintObj.Image = Properties.Resources.Print;
			this.toolMenuItemPrintObj.Name = "toolMenuItemPrintObj";
			this.toolMenuItemPrintObj.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemPrintObj.Text = "Печать";
			this.toolMenuItemPrintObj.Click += new System.EventHandler(this.toolMenuItemPrintObj_Click);
			this.bindingSourceMapObj.DataMember = "vMapObj";
			this.bindingSourceMapObj.DataSource = this.dsKladr;
			this.dsKladr.DataSetName = "DataSetKladr";
			this.dsKladr.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
			this.dgvMapObjParameter.ContextMenuStrip = this.contextMenuDgvMapObjParam;
			this.dgvMapObjParameter.DataSource = this.bindingSourceMapObjParameter;
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
			this.typeObjDataGridViewTextBoxColumn.DataSource = this.dsKladr;
			this.typeObjDataGridViewTextBoxColumn.DisplayMember = "tR_Classifier.Name";
			this.typeObjDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
			this.typeObjDataGridViewTextBoxColumn.HeaderText = "Тип";
			this.typeObjDataGridViewTextBoxColumn.Name = "typeObjDataGridViewTextBoxColumn";
			this.typeObjDataGridViewTextBoxColumn.ReadOnly = true;
			this.typeObjDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.typeObjDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.typeObjDataGridViewTextBoxColumn.ValueMember = "tR_Classifier.Id";
			this.otherTypeObjDataGridViewTextBoxColumn.DataPropertyName = "OtherTypeObj";
			this.otherTypeObjDataGridViewTextBoxColumn.DataSource = this.dsKladr;
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
			this.reasonEndDataGridViewTextBoxColumn.DataSource = this.dsKladr;
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
			this.contextMenuDgvMapObjParam.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
			{
				this.toolMenuAddObjParam,
				this.toolMenuEditObjParam,
				this.toolMenuItemDelObjParam,
				this.toolStripSeparator2,
				this.toolMenuCopyObjParam,
				this.toolMenuExportObjParam,
				this.toolMenuPrintObjParam
			});
			this.contextMenuDgvMapObjParam.Name = "contextMenuDgvMapObj";
			this.contextMenuDgvMapObjParam.Size = new System.Drawing.Size(158, 142);
			this.toolMenuAddObjParam.Image = Properties.Resources.Buttonadd;
			this.toolMenuAddObjParam.Name = "toolMenuAddObjParam";
			this.toolMenuAddObjParam.Size = new System.Drawing.Size(157, 22);
			this.toolMenuAddObjParam.Text = "Добавить";
			this.toolMenuAddObjParam.Click += new System.EventHandler(this.toolMenuAddObjParam_Click);
			this.toolMenuEditObjParam.Image = Properties.Resources.ButtonEdit;
			this.toolMenuEditObjParam.Name = "toolMenuEditObjParam";
			this.toolMenuEditObjParam.Size = new System.Drawing.Size(157, 22);
			this.toolMenuEditObjParam.Text = "Редактировать";
			this.toolMenuEditObjParam.Click += new System.EventHandler(this.toolMenuEditObjParam_Click);
			this.toolMenuItemDelObjParam.Image = Properties.Resources.ButtonDel;
			this.toolMenuItemDelObjParam.Name = "toolMenuItemDelObjParam";
			this.toolMenuItemDelObjParam.Size = new System.Drawing.Size(157, 22);
			this.toolMenuItemDelObjParam.Text = "Удалить";
			this.toolMenuItemDelObjParam.Click += new System.EventHandler(this.toolMenuItemDelObjParam_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(154, 6);
			this.toolMenuCopyObjParam.Image = Properties.Resources.CopyBuffer;
			this.toolMenuCopyObjParam.Name = "toolMenuCopyObjParam";
			this.toolMenuCopyObjParam.Size = new System.Drawing.Size(157, 22);
			this.toolMenuCopyObjParam.Text = "Копировать";
			this.toolMenuCopyObjParam.Click += new System.EventHandler(this.toolMenuCopyObjParam_Click);
			this.toolMenuExportObjParam.Image = Properties.Resources.Excel;
			this.toolMenuExportObjParam.Name = "toolMenuExportObjParam";
			this.toolMenuExportObjParam.Size = new System.Drawing.Size(157, 22);
			this.toolMenuExportObjParam.Text = "Экспорт в Excel";
			this.toolMenuExportObjParam.Click += new System.EventHandler(this.toolMenuExportObjParam_Click);
			this.toolMenuPrintObjParam.Image = Properties.Resources.Print;
			this.toolMenuPrintObjParam.Name = "toolMenuPrintObjParam";
			this.toolMenuPrintObjParam.Size = new System.Drawing.Size(157, 22);
			this.toolMenuPrintObjParam.Text = "Печать";
			this.toolMenuPrintObjParam.Click += new System.EventHandler(this.toolMenuPrintObjParam_Click);

            this.bindingSourceMapObjParameter.DataMember = "vMapObj_tMapObjParameter";
			this.bindingSourceMapObjParameter.DataSource = this.bindingSourceMapObj;

            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(866, 538);
			base.Controls.Add(this.splitContainerMain);
			base.Controls.Add(this.toolStripMain);
  
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("mapobj")));
            base.Name = "FormMapObj";
			this.Text = "Справочник объектов(домов) (N)";
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
			this.contextMenuDgvMapObj.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.bindingSourceMapObj).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dsKladr).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dgvMapObjParameter).EndInit();
			this.contextMenuDgvMapObjParam.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.bindingSourceMapObjParameter).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dsStreet_Obl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dtStreet_Obl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dsRaion_RaionCity).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dtRaion_RaionCity).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dsRaion_Obl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dtRaion_Obl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dsStreet_RaionCity).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dtStreet_RaionCity).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dsStreet_Punkt).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dtStreet_Punkt).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dsRaion_Punkt).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dtRaion_Punkt).EndInit();
		}


        private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.ToolStrip toolStripMain;

		private System.Windows.Forms.SplitContainer splitContainerMain;

		private System.Windows.Forms.TreeView treeViewPunkts;

		private DataSetKladr dsKladr;

		private System.Windows.Forms.ImageList imageList;

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

		private System.Data.DataSet dsStreet_Obl;

		private System.Data.DataTable dtStreet_Obl;

		private System.Data.DataColumn dataColumn24;

		private System.Data.DataColumn dataColumn1;

		private System.Data.DataColumn dataColumn2;

		private System.Data.DataColumn dataColumn3;

		private System.Data.DataSet dsRaion_Punkt;

		private System.Data.DataTable dtRaion_Punkt;

		private System.Data.DataColumn dataColumn4;

		private System.Data.DataColumn dataColumn5;

		private System.Data.DataColumn dataColumn6;

		private System.Data.DataColumn dataColumn7;

		private System.Data.DataSet dsRaion_RaionCity;

		private System.Data.DataTable dtRaion_RaionCity;

		private System.Data.DataColumn dataColumn8;

		private System.Data.DataColumn dataColumn9;

		private System.Data.DataColumn dataColumn10;

		private System.Data.DataColumn dataColumn11;

		private System.Data.DataSet dsRaion_Obl;

		private System.Data.DataTable dtRaion_Obl;

		private System.Data.DataColumn dataColumn12;

		private System.Data.DataColumn dataColumn13;

		private System.Data.DataColumn dataColumn14;

		private System.Data.DataColumn dataColumn15;

		private System.Data.DataSet dsStreet_Punkt;

		private System.Data.DataTable dtStreet_Punkt;

		private System.Data.DataColumn dataColumn16;

		private System.Data.DataColumn dataColumn17;

		private System.Data.DataColumn dataColumn18;

		private System.Data.DataColumn dataColumn19;

		private System.Data.DataSet dsStreet_RaionCity;

		private System.Data.DataTable dtStreet_RaionCity;

		private System.Data.DataColumn dataColumn20;

		private System.Data.DataColumn dataColumn21;

		private System.Data.DataColumn dataColumn22;

		private System.Data.DataColumn dataColumn23;

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvMapObj;

		private System.Windows.Forms.BindingSource bindingSourceMapObj;

		private System.Windows.Forms.ToolStripButton toolBtnShowDeleteMapObj;

		private System.Windows.Forms.ToolStripTextBox toolTxtFindPunkts;

		private System.Windows.Forms.ToolStripButton toolBtnFindPunkts;

		private System.Windows.Forms.ToolStripTextBox toolTxtFindRaion;

		private System.Windows.Forms.ToolStripButton toolBtnFindRaion;

		private System.Windows.Forms.ToolStripTextBox toolTxtFindStreet;

		private System.Windows.Forms.ToolStripButton toolBtnFindStreet;

		private System.Windows.Forms.SplitContainer splitContainerGrid;

		private System.Windows.Forms.BindingSource bindingSourceMapObjParameter;

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

		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorShowDelete;

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

		private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn longitudeDataGridViewTextBoxColumn;

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

		private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;

		private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		private System.Windows.Forms.ToolStripButton toolStripButtonPrint;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;

		private System.Windows.Forms.ContextMenuStrip contextMenuDgvMapObj;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemAddObj;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemEditObj;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelObj;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelObjCheck;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelObjFull;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemCopyObj;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemExcelObj;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemPrintObj;

		private System.Windows.Forms.ContextMenuStrip contextMenuDgvMapObjParam;

		private System.Windows.Forms.ToolStripMenuItem toolMenuAddObjParam;

		private System.Windows.Forms.ToolStripMenuItem toolMenuEditObjParam;

		private System.Windows.Forms.ToolStripMenuItem toolMenuItemDelObjParam;

		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		private System.Windows.Forms.ToolStripMenuItem toolMenuCopyObjParam;

		private System.Windows.Forms.ToolStripMenuItem toolMenuExportObjParam;

		private System.Windows.Forms.ToolStripMenuItem toolMenuPrintObjParam;
	}
}
