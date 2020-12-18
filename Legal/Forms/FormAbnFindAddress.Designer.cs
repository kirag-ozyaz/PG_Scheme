namespace Legal.Forms
{
    partial class FormAbnFindAddress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbnFindAddress));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxGrid = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFindPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFindNext = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.dsObl = new System.Data.DataSet();
            this.dataTableObl = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dsRaionObl = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dsPunkts = new System.Data.DataSet();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dsRaionCity = new System.Data.DataSet();
            this.dataTableClassifier = new System.Data.DataTable();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dsStreet = new System.Data.DataSet();
            this.dataTable3 = new System.Data.DataTable();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dsTypeAbn = new System.Data.DataSet();
            this.dataTable4 = new System.Data.DataTable();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dsAbnFind = new Legal.DataSet.DataSetAbn();
            this.bindingSourceFind = new System.Windows.Forms.BindingSource(this.components);
            this.panelFind = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtApartment = new System.Windows.Forms.TextBox();
            this.groupBoxNameAbn = new System.Windows.Forms.GroupBox();
            this.txtNameAbn = new System.Windows.Forms.TextBox();
            this.checkBoxIsLike = new System.Windows.Forms.CheckBox();
            this.buttonFill = new System.Windows.Forms.Button();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHousePrefix = new System.Windows.Forms.TextBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbStreet = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRaionCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbRaionObl = new System.Windows.Forms.ComboBox();
            this.labelRaionObl = new System.Windows.Forms.Label();
            this.cmbObl = new System.Windows.Forms.ComboBox();
            this.labelObl = new System.Windows.Forms.Label();
            this.groupBoxFIO = new System.Windows.Forms.GroupBox();
            this.txtOtchestvo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTypeAbn = new System.Windows.Forms.Label();
            this.cmbControler = new System.Windows.Forms.ComboBox();
            this.cmbTypeAbn = new System.Windows.Forms.ComboBox();
            this.labelControler = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolLabelCountActive = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabelCountNotActive = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolLabelCountAll = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvFind = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDgvTxtColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.workerAbnDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.reasonStatusNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeAbnNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.typeAbnDgvTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewCheckBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn();
            this.kladrObjNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.raionCityDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.streetNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.housePrefixDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.apartmentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.indexDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Objid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schmObjName = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Flag = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsObl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableObl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRaionObl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPunkts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRaionCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClassifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTypeAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFind)).BeginInit();
            this.panelFind.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxNameAbn.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            this.groupBoxFIO.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFind)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFind,
            this.toolStripTextBoxGrid,
            this.toolStripButtonFindPrev,
            this.toolStripButtonFindNext,
            this.toolStripSeparator3,
            this.toolStripButtonPrint,
            this.toolStripSeparator4,
            this.toolStripButtonExportExcel,
            this.toolStripSeparator5,
            this.toolStripButtonRefresh});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(608, 25);
            this.toolStripMain.TabIndex = 8;
            this.toolStripMain.Text = "toolStripMain";
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
            // toolStripTextBoxGrid
            // 
            this.toolStripTextBoxGrid.Name = "toolStripTextBoxGrid";
            this.toolStripTextBoxGrid.Size = new System.Drawing.Size(100, 25);
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
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // dsObl
            // 
            this.dsObl.DataSetName = "NewDataSet";
            this.dsObl.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableObl});
            // 
            // dataTableObl
            // 
            this.dataTableObl.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.dataTableObl.TableName = "tR_KladrObj";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Id";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Name";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Socr";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "NameSocr";
            this.dataColumn4.Expression = "Name + \' \' + isnull(socr, \'\')";
            this.dataColumn4.ReadOnly = true;
            // 
            // dsRaionObl
            // 
            this.dsRaionObl.DataSetName = "NewDataSet";
            this.dsRaionObl.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
            this.dataTable1.TableName = "tR_KladrObj";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "Id";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Name";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "Socr";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "NameSocr";
            this.dataColumn8.Expression = "Name + \' \' + isnull(socr, \'\')";
            this.dataColumn8.ReadOnly = true;
            // 
            // dsPunkts
            // 
            this.dsPunkts.DataSetName = "NewDataSet";
            this.dsPunkts.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable2});
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12});
            this.dataTable2.TableName = "tR_KladrObj";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Id";
            this.dataColumn9.DataType = typeof(int);
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Name";
            // 
            // dataColumn11
            // 
            this.dataColumn11.ColumnName = "Socr";
            // 
            // dataColumn12
            // 
            this.dataColumn12.ColumnName = "NameSocr";
            this.dataColumn12.Expression = "Name + \' \' + isnull(socr, \'\')";
            this.dataColumn12.ReadOnly = true;
            // 
            // dsRaionCity
            // 
            this.dsRaionCity.DataSetName = "NewDataSet";
            this.dsRaionCity.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableClassifier});
            // 
            // dataTableClassifier
            // 
            this.dataTableClassifier.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn17,
            this.dataColumn18});
            this.dataTableClassifier.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "Id"}, true)});
            this.dataTableClassifier.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn17};
            this.dataTableClassifier.TableName = "tR_Classifier";
            // 
            // dataColumn17
            // 
            this.dataColumn17.AllowDBNull = false;
            this.dataColumn17.ColumnName = "Id";
            this.dataColumn17.DataType = typeof(int);
            // 
            // dataColumn18
            // 
            this.dataColumn18.ColumnName = "Name";
            // 
            // dsStreet
            // 
            this.dsStreet.DataSetName = "NewDataSet";
            this.dsStreet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable3});
            // 
            // dataTable3
            // 
            this.dataTable3.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn19});
            this.dataTable3.TableName = "tR_KladrStreet";
            // 
            // dataColumn13
            // 
            this.dataColumn13.ColumnName = "Id";
            this.dataColumn13.DataType = typeof(int);
            // 
            // dataColumn14
            // 
            this.dataColumn14.ColumnName = "Name";
            // 
            // dataColumn15
            // 
            this.dataColumn15.ColumnName = "Socr";
            // 
            // dataColumn16
            // 
            this.dataColumn16.ColumnName = "NameSocr";
            this.dataColumn16.Expression = "Name + \' \' + isnull(socr, \'\')";
            this.dataColumn16.ReadOnly = true;
            // 
            // dataColumn19
            // 
            this.dataColumn19.ColumnName = "Index";
            // 
            // dsTypeAbn
            // 
            this.dsTypeAbn.DataSetName = "NewDataSet";
            this.dsTypeAbn.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable4});
            // 
            // dataTable4
            // 
            this.dataTable4.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn20,
            this.dataColumn21});
            this.dataTable4.TableName = "tR_Classifier";
            // 
            // dataColumn20
            // 
            this.dataColumn20.ColumnName = "id";
            this.dataColumn20.DataType = typeof(int);
            // 
            // dataColumn21
            // 
            this.dataColumn21.ColumnName = "Name";
            // 
            // dsAbnFind
            // 
            this.dsAbnFind.DataSetName = "DataSetAbn";
            this.dsAbnFind.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSourceFind
            // 
            this.bindingSourceFind.DataMember = "vAbnFind";
            this.bindingSourceFind.DataSource = this.dsAbnFind;
            this.bindingSourceFind.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bindingSourceFind_ListChanged);
            // 
            // panelFind
            // 
            this.panelFind.Controls.Add(this.groupBox1);
            this.panelFind.Controls.Add(this.groupBoxNameAbn);
            this.panelFind.Controls.Add(this.checkBoxIsLike);
            this.panelFind.Controls.Add(this.buttonFill);
            this.panelFind.Controls.Add(this.groupBoxAddress);
            this.panelFind.Controls.Add(this.groupBoxFIO);
            this.panelFind.Controls.Add(this.labelTypeAbn);
            this.panelFind.Controls.Add(this.cmbControler);
            this.panelFind.Controls.Add(this.cmbTypeAbn);
            this.panelFind.Controls.Add(this.labelControler);
            this.panelFind.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFind.Location = new System.Drawing.Point(0, 25);
            this.panelFind.Name = "panelFind";
            this.panelFind.Size = new System.Drawing.Size(608, 190);
            this.panelFind.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApartment);
            this.groupBox1.Location = new System.Drawing.Point(310, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 40);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наименование объекта";
            // 
            // txtApartment
            // 
            this.txtApartment.Location = new System.Drawing.Point(6, 14);
            this.txtApartment.Name = "txtApartment";
            this.txtApartment.Size = new System.Drawing.Size(280, 20);
            this.txtApartment.TabIndex = 8;
            // 
            // groupBoxNameAbn
            // 
            this.groupBoxNameAbn.Controls.Add(this.txtNameAbn);
            this.groupBoxNameAbn.Location = new System.Drawing.Point(3, 3);
            this.groupBoxNameAbn.Name = "groupBoxNameAbn";
            this.groupBoxNameAbn.Size = new System.Drawing.Size(301, 41);
            this.groupBoxNameAbn.TabIndex = 7;
            this.groupBoxNameAbn.TabStop = false;
            this.groupBoxNameAbn.Text = "Наименование потребителя";
            // 
            // txtNameAbn
            // 
            this.txtNameAbn.Location = new System.Drawing.Point(9, 15);
            this.txtNameAbn.Name = "txtNameAbn";
            this.txtNameAbn.Size = new System.Drawing.Size(281, 20);
            this.txtNameAbn.TabIndex = 0;
            // 
            // checkBoxIsLike
            // 
            this.checkBoxIsLike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIsLike.AutoSize = true;
            this.checkBoxIsLike.Location = new System.Drawing.Point(464, 167);
            this.checkBoxIsLike.Name = "checkBoxIsLike";
            this.checkBoxIsLike.Size = new System.Drawing.Size(86, 17);
            this.checkBoxIsLike.TabIndex = 6;
            this.checkBoxIsLike.Text = "По шаблону";
            this.checkBoxIsLike.UseVisualStyleBackColor = true;
            // 
            // buttonFill
            // 
            this.buttonFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFill.Location = new System.Drawing.Point(464, 138);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(141, 23);
            this.buttonFill.TabIndex = 5;
            this.buttonFill.Text = "Заполнить";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.label6);
            this.groupBoxAddress.Controls.Add(this.txtHousePrefix);
            this.groupBoxAddress.Controls.Add(this.txtHouse);
            this.groupBoxAddress.Controls.Add(this.label5);
            this.groupBoxAddress.Controls.Add(this.cmbStreet);
            this.groupBoxAddress.Controls.Add(this.label4);
            this.groupBoxAddress.Controls.Add(this.cmbRaionCity);
            this.groupBoxAddress.Controls.Add(this.label3);
            this.groupBoxAddress.Controls.Add(this.label2);
            this.groupBoxAddress.Controls.Add(this.cmbCity);
            this.groupBoxAddress.Controls.Add(this.cmbRaionObl);
            this.groupBoxAddress.Controls.Add(this.labelRaionObl);
            this.groupBoxAddress.Controls.Add(this.cmbObl);
            this.groupBoxAddress.Controls.Add(this.labelObl);
            this.groupBoxAddress.Location = new System.Drawing.Point(0, 47);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(304, 137);
            this.groupBoxAddress.TabIndex = 0;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Преф";
            // 
            // txtHousePrefix
            // 
            this.txtHousePrefix.Location = new System.Drawing.Point(207, 111);
            this.txtHousePrefix.Name = "txtHousePrefix";
            this.txtHousePrefix.Size = new System.Drawing.Size(38, 20);
            this.txtHousePrefix.TabIndex = 5;
            // 
            // txtHouse
            // 
            this.txtHouse.Location = new System.Drawing.Point(160, 110);
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(41, 20);
            this.txtHouse.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Дом";
            // 
            // cmbStreet
            // 
            this.cmbStreet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStreet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbStreet.DataSource = this.dsStreet;
            this.cmbStreet.DisplayMember = "tR_KladrStreet.NameSocr";
            this.cmbStreet.FormattingEnabled = true;
            this.cmbStreet.Location = new System.Drawing.Point(160, 72);
            this.cmbStreet.Name = "cmbStreet";
            this.cmbStreet.Size = new System.Drawing.Size(133, 21);
            this.cmbStreet.TabIndex = 1;
            this.cmbStreet.ValueMember = "tR_KladrStreet.Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Улица";
            // 
            // cmbRaionCity
            // 
            this.cmbRaionCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRaionCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRaionCity.DataSource = this.dsRaionCity;
            this.cmbRaionCity.DisplayMember = "tR_Classifier.Name";
            this.cmbRaionCity.FormattingEnabled = true;
            this.cmbRaionCity.Location = new System.Drawing.Point(160, 32);
            this.cmbRaionCity.Name = "cmbRaionCity";
            this.cmbRaionCity.Size = new System.Drawing.Size(133, 21);
            this.cmbRaionCity.TabIndex = 15;
            this.cmbRaionCity.ValueMember = "tR_Classifier.Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Район";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Нас. пункт";
            // 
            // cmbCity
            // 
            this.cmbCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCity.DataSource = this.dsPunkts;
            this.cmbCity.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(9, 110);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(133, 21);
            this.cmbCity.TabIndex = 14;
            this.cmbCity.ValueMember = "tR_KladrObj.Id";
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // cmbRaionObl
            // 
            this.cmbRaionObl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbRaionObl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbRaionObl.DataSource = this.dsRaionObl;
            this.cmbRaionObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbRaionObl.FormattingEnabled = true;
            this.cmbRaionObl.Location = new System.Drawing.Point(9, 72);
            this.cmbRaionObl.Name = "cmbRaionObl";
            this.cmbRaionObl.Size = new System.Drawing.Size(133, 21);
            this.cmbRaionObl.TabIndex = 12;
            this.cmbRaionObl.ValueMember = "tR_KladrObj.Id";
            this.cmbRaionObl.SelectedIndexChanged += new System.EventHandler(this.cmbRaionObl_SelectedIndexChanged);
            // 
            // labelRaionObl
            // 
            this.labelRaionObl.AutoSize = true;
            this.labelRaionObl.Location = new System.Drawing.Point(6, 56);
            this.labelRaionObl.Name = "labelRaionObl";
            this.labelRaionObl.Size = new System.Drawing.Size(72, 13);
            this.labelRaionObl.TabIndex = 11;
            this.labelRaionObl.Text = "Район/город";
            // 
            // cmbObl
            // 
            this.cmbObl.DataSource = this.dsObl;
            this.cmbObl.DisplayMember = "tR_KladrObj.NameSocr";
            this.cmbObl.FormattingEnabled = true;
            this.cmbObl.Location = new System.Drawing.Point(9, 32);
            this.cmbObl.Name = "cmbObl";
            this.cmbObl.Size = new System.Drawing.Size(133, 21);
            this.cmbObl.TabIndex = 10;
            this.cmbObl.ValueMember = "tR_KladrObj.Id";
            this.cmbObl.SelectedIndexChanged += new System.EventHandler(this.cmbObl_SelectedIndexChanged);
            // 
            // labelObl
            // 
            this.labelObl.AutoSize = true;
            this.labelObl.Location = new System.Drawing.Point(6, 16);
            this.labelObl.Name = "labelObl";
            this.labelObl.Size = new System.Drawing.Size(50, 13);
            this.labelObl.TabIndex = 9;
            this.labelObl.Text = "Область";
            // 
            // groupBoxFIO
            // 
            this.groupBoxFIO.Controls.Add(this.txtOtchestvo);
            this.groupBoxFIO.Controls.Add(this.label10);
            this.groupBoxFIO.Controls.Add(this.txtName);
            this.groupBoxFIO.Controls.Add(this.label9);
            this.groupBoxFIO.Controls.Add(this.txtFamily);
            this.groupBoxFIO.Controls.Add(this.label8);
            this.groupBoxFIO.Location = new System.Drawing.Point(310, 47);
            this.groupBoxFIO.Name = "groupBoxFIO";
            this.groupBoxFIO.Size = new System.Drawing.Size(148, 137);
            this.groupBoxFIO.TabIndex = 1;
            this.groupBoxFIO.TabStop = false;
            this.groupBoxFIO.Text = "ФИО";
            // 
            // txtOtchestvo
            // 
            this.txtOtchestvo.Location = new System.Drawing.Point(9, 111);
            this.txtOtchestvo.Name = "txtOtchestvo";
            this.txtOtchestvo.Size = new System.Drawing.Size(129, 20);
            this.txtOtchestvo.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Отчество";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(9, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 20);
            this.txtName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Имя";
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(9, 32);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(129, 20);
            this.txtFamily.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Фамилия";
            // 
            // labelTypeAbn
            // 
            this.labelTypeAbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTypeAbn.AutoSize = true;
            this.labelTypeAbn.Location = new System.Drawing.Point(464, 47);
            this.labelTypeAbn.Name = "labelTypeAbn";
            this.labelTypeAbn.Size = new System.Drawing.Size(76, 13);
            this.labelTypeAbn.TabIndex = 1;
            this.labelTypeAbn.Text = "Тип абонента";
            // 
            // cmbControler
            // 
            this.cmbControler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbControler.DataSource = this.dsAbnFind;
            this.cmbControler.DisplayMember = "vWorkerGroup.FIO";
            this.cmbControler.FormattingEnabled = true;
            this.cmbControler.Location = new System.Drawing.Point(467, 102);
            this.cmbControler.Name = "cmbControler";
            this.cmbControler.Size = new System.Drawing.Size(138, 21);
            this.cmbControler.TabIndex = 4;
            this.cmbControler.ValueMember = "vWorkerGroup.id";
            // 
            // cmbTypeAbn
            // 
            this.cmbTypeAbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTypeAbn.DataSource = this.dsTypeAbn;
            this.cmbTypeAbn.DisplayMember = "tR_Classifier.Name";
            this.cmbTypeAbn.FormattingEnabled = true;
            this.cmbTypeAbn.Location = new System.Drawing.Point(467, 63);
            this.cmbTypeAbn.Name = "cmbTypeAbn";
            this.cmbTypeAbn.Size = new System.Drawing.Size(138, 21);
            this.cmbTypeAbn.TabIndex = 2;
            this.cmbTypeAbn.ValueMember = "tR_Classifier.id";
            // 
            // labelControler
            // 
            this.labelControler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControler.AutoSize = true;
            this.labelControler.Location = new System.Drawing.Point(464, 87);
            this.labelControler.Name = "labelControler";
            this.labelControler.Size = new System.Drawing.Size(61, 13);
            this.labelControler.TabIndex = 3;
            this.labelControler.Text = "Контролер";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolLabelCountActive,
            this.toolLabelCountNotActive,
            this.toolLabelCountAll});
            this.statusStrip.Location = new System.Drawing.Point(0, 511);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(608, 22);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "статус";
            // 
            // toolLabelCountActive
            // 
            this.toolLabelCountActive.Name = "toolLabelCountActive";
            this.toolLabelCountActive.Size = new System.Drawing.Size(197, 17);
            this.toolLabelCountActive.Spring = true;
            this.toolLabelCountActive.Text = "Активные - 0";
            // 
            // toolLabelCountNotActive
            // 
            this.toolLabelCountNotActive.Name = "toolLabelCountNotActive";
            this.toolLabelCountNotActive.Size = new System.Drawing.Size(197, 17);
            this.toolLabelCountNotActive.Spring = true;
            this.toolLabelCountNotActive.Text = "Неактивные - 0";
            // 
            // toolLabelCountAll
            // 
            this.toolLabelCountAll.Name = "toolLabelCountAll";
            this.toolLabelCountAll.Size = new System.Drawing.Size(197, 17);
            this.toolLabelCountAll.Spring = true;
            this.toolLabelCountAll.Text = "Всего - 0";
            // 
            // dgvFind
            // 
            this.dgvFind.AllowUserToAddRows = false;
            this.dgvFind.AllowUserToDeleteRows = false;
            this.dgvFind.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFind.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFind.AutoGenerateColumns = false;
            this.dgvFind.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeAbonentDgvTxtColumn,
            this.addressDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.workerAbnDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.reasonStatusNameDataGridViewTextBoxColumn,
            this.typeAbnNameDataGridViewTextBoxColumn,
            this.typeAbnDgvTxtColumn,
            this.deletedDataGridViewCheckBoxColumn,
            this.kladrObjNameDataGridViewTextBoxColumn,
            this.raionCityDataGridViewTextBoxColumn,
            this.streetNameDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.housePrefixDataGridViewTextBoxColumn,
            this.apartmentDataGridViewTextBoxColumn,
            this.indexDataGridViewTextBoxColumn,
            this.Objid,
            this.schmObjName,
            this.Flag});
            this.dgvFind.DataSource = this.bindingSourceFind;
            this.dgvFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFind.Location = new System.Drawing.Point(0, 215);
            this.dgvFind.MultiSelect = false;
            this.dgvFind.Name = "dgvFind";
            this.dgvFind.ReadOnly = true;
            this.dgvFind.RowHeadersWidth = 10;
            this.dgvFind.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFind.Size = new System.Drawing.Size(608, 296);
            this.dgvFind.TabIndex = 13;
            this.dgvFind.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFind_CellMouseDoubleClick);
            this.dgvFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvFind_KeyDown);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeAbonentDgvTxtColumn
            // 
            this.codeAbonentDgvTxtColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDgvTxtColumn.HeaderText = "Код";
            this.codeAbonentDgvTxtColumn.Name = "codeAbonentDgvTxtColumn";
            this.codeAbonentDgvTxtColumn.ReadOnly = true;
            this.codeAbonentDgvTxtColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeAbonentDgvTxtColumn.Width = 90;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Адрес - Наименование объекта";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addressDataGridViewTextBoxColumn.Width = 170;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование потребителя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // workerAbnDataGridViewTextBoxColumn
            // 
            this.workerAbnDataGridViewTextBoxColumn.DataPropertyName = "WorkerAbn";
            this.workerAbnDataGridViewTextBoxColumn.HeaderText = "Контролер";
            this.workerAbnDataGridViewTextBoxColumn.Name = "workerAbnDataGridViewTextBoxColumn";
            this.workerAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerAbnDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "Актив";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isActiveDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.isActiveDataGridViewCheckBoxColumn.Width = 50;
            // 
            // reasonStatusNameDataGridViewTextBoxColumn
            // 
            this.reasonStatusNameDataGridViewTextBoxColumn.DataPropertyName = "ReasonStatusName";
            this.reasonStatusNameDataGridViewTextBoxColumn.HeaderText = "Причина";
            this.reasonStatusNameDataGridViewTextBoxColumn.Name = "reasonStatusNameDataGridViewTextBoxColumn";
            this.reasonStatusNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.reasonStatusNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeAbnNameDataGridViewTextBoxColumn
            // 
            this.typeAbnNameDataGridViewTextBoxColumn.DataPropertyName = "typeAbnName";
            this.typeAbnNameDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeAbnNameDataGridViewTextBoxColumn.Name = "typeAbnNameDataGridViewTextBoxColumn";
            this.typeAbnNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeAbnNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // typeAbnDgvTxtColumn
            // 
            this.typeAbnDgvTxtColumn.DataPropertyName = "TypeAbn";
            this.typeAbnDgvTxtColumn.HeaderText = "TypeAbn";
            this.typeAbnDgvTxtColumn.Name = "typeAbnDgvTxtColumn";
            this.typeAbnDgvTxtColumn.ReadOnly = true;
            this.typeAbnDgvTxtColumn.Visible = false;
            // 
            // deletedDataGridViewCheckBoxColumn
            // 
            this.deletedDataGridViewCheckBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewCheckBoxColumn.HeaderText = "Удален";
            this.deletedDataGridViewCheckBoxColumn.Name = "deletedDataGridViewCheckBoxColumn";
            this.deletedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.deletedDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deletedDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kladrObjNameDataGridViewTextBoxColumn
            // 
            this.kladrObjNameDataGridViewTextBoxColumn.DataPropertyName = "kladrObjName";
            this.kladrObjNameDataGridViewTextBoxColumn.HeaderText = "Город";
            this.kladrObjNameDataGridViewTextBoxColumn.Name = "kladrObjNameDataGridViewTextBoxColumn";
            this.kladrObjNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.kladrObjNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // raionCityDataGridViewTextBoxColumn
            // 
            this.raionCityDataGridViewTextBoxColumn.DataPropertyName = "RaionCity";
            this.raionCityDataGridViewTextBoxColumn.HeaderText = "Район";
            this.raionCityDataGridViewTextBoxColumn.Name = "raionCityDataGridViewTextBoxColumn";
            this.raionCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.raionCityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // streetNameDataGridViewTextBoxColumn
            // 
            this.streetNameDataGridViewTextBoxColumn.DataPropertyName = "StreetName";
            this.streetNameDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetNameDataGridViewTextBoxColumn.Name = "streetNameDataGridViewTextBoxColumn";
            this.streetNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            this.houseDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.houseDataGridViewTextBoxColumn.Width = 40;
            // 
            // housePrefixDataGridViewTextBoxColumn
            // 
            this.housePrefixDataGridViewTextBoxColumn.DataPropertyName = "HousePrefix";
            this.housePrefixDataGridViewTextBoxColumn.HeaderText = "Префикс";
            this.housePrefixDataGridViewTextBoxColumn.Name = "housePrefixDataGridViewTextBoxColumn";
            this.housePrefixDataGridViewTextBoxColumn.ReadOnly = true;
            this.housePrefixDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.housePrefixDataGridViewTextBoxColumn.Width = 40;
            // 
            // apartmentDataGridViewTextBoxColumn
            // 
            this.apartmentDataGridViewTextBoxColumn.DataPropertyName = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.apartmentDataGridViewTextBoxColumn.Name = "apartmentDataGridViewTextBoxColumn";
            this.apartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.apartmentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.apartmentDataGridViewTextBoxColumn.Width = 40;
            // 
            // indexDataGridViewTextBoxColumn
            // 
            this.indexDataGridViewTextBoxColumn.DataPropertyName = "Index";
            this.indexDataGridViewTextBoxColumn.HeaderText = "Индекс";
            this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
            this.indexDataGridViewTextBoxColumn.ReadOnly = true;
            this.indexDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.indexDataGridViewTextBoxColumn.Width = 70;
            // 
            // Objid
            // 
            this.Objid.DataPropertyName = "Objid";
            this.Objid.HeaderText = "Objid";
            this.Objid.Name = "Objid";
            this.Objid.ReadOnly = true;
            this.Objid.Visible = false;
            // 
            // schmObjName
            // 
            this.schmObjName.DataPropertyName = "schmObjName";
            this.schmObjName.HeaderText = "Объект схемы";
            this.schmObjName.Name = "schmObjName";
            this.schmObjName.ReadOnly = true;
            this.schmObjName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.schmObjName.Width = 200;
            // 
            // Flag
            // 
            this.Flag.DataPropertyName = "Flag";
            this.Flag.HeaderText = "Действующий";
            this.Flag.Name = "Flag";
            this.Flag.ReadOnly = true;
            // 
            // FormAbnFindAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 533);
            this.Controls.Add(this.dgvFind);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panelFind);
            this.Controls.Add(this.toolStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAbnFindAddress";
            this.Text = "Поиск по адресу";
            this.Load += new System.EventHandler(this.FormAbnFindAddress_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAbnFindAddress_KeyDown);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsObl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableObl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRaionObl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPunkts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRaionCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableClassifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTypeAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFind)).EndInit();
            this.panelFind.ResumeLayout(false);
            this.panelFind.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxNameAbn.ResumeLayout(false);
            this.groupBoxNameAbn.PerformLayout();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            this.groupBoxFIO.ResumeLayout(false);
            this.groupBoxFIO.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxGrid;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindPrev;
        private System.Windows.Forms.ToolStripButton toolStripButtonFindNext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonExportExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Data.DataSet dsObl;
        private System.Data.DataTable dataTableObl;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataSet dsRaionObl;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataSet dsPunkts;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataSet dsRaionCity;
        private System.Data.DataTable dataTableClassifier;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataSet dsStreet;
        private System.Data.DataTable dataTable3;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataSet dsTypeAbn;
        private System.Data.DataTable dataTable4;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private DataSet.DataSetAbn dsAbnFind;
        private System.Windows.Forms.BindingSource bindingSourceFind;
        private System.Windows.Forms.Panel panelFind;
        private System.Windows.Forms.CheckBox checkBoxIsLike;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.TextBox txtApartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHousePrefix;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRaionCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbRaionObl;
        private System.Windows.Forms.Label labelRaionObl;
        private System.Windows.Forms.ComboBox cmbObl;
        private System.Windows.Forms.Label labelObl;
        private System.Windows.Forms.GroupBox groupBoxFIO;
        private System.Windows.Forms.TextBox txtOtchestvo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTypeAbn;
        private System.Windows.Forms.ComboBox cmbControler;
        private System.Windows.Forms.ComboBox cmbTypeAbn;
        private System.Windows.Forms.Label labelControler;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelCountActive;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelCountNotActive;
        private System.Windows.Forms.ToolStripStatusLabel toolLabelCountAll;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvFind;
        private System.Windows.Forms.GroupBox groupBoxNameAbn;
        private System.Windows.Forms.TextBox txtNameAbn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDgvTxtColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn addressDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn workerAbnDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn reasonStatusNameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn typeAbnNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAbnDgvTxtColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterCheckBoxColumn deletedDataGridViewCheckBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn kladrObjNameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn raionCityDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn streetNameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn houseDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn housePrefixDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn apartmentDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn indexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Objid;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn schmObjName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Flag;
    }
}