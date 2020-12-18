namespace Prv.Forms.Houses
{
    partial class FormHouses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvefHouses = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.idmapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrobjidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrObj = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housePrefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.house = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countAllDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countActivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countNotActivUchetDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countNotActivOtherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allKWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y2007DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y2008DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsHouses = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrv = new Prv.DataSets.DataSetPrv();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
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
            this.panelWait = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsHouses = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DebAbonentHouseTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DebAllHouseMonthTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВExelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.закрытьДомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelStatHouseTSMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActiveChangeStatus = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefHouses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHouses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrv)).BeginInit();
            this.toolStripMain.SuspendLayout();
            this.panelWait.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cmsHouses.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvefHouses
            // 
            this.dgvefHouses.AllowUserToAddRows = false;
            this.dgvefHouses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvefHouses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvefHouses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvefHouses.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvefHouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvefHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvefHouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmapDataGridViewTextBoxColumn,
            this.kladrobjidDataGridViewTextBoxColumn,
            this.kladrObj,
            this.idStreetDataGridViewTextBoxColumn,
            this.street,
            this.houseDataGridViewTextBoxColumn,
            this.housePrefixDataGridViewTextBoxColumn,
            this.house,
            this.countAllDataGridViewTextBoxColumn,
            this.countActivDataGridViewTextBoxColumn,
            this.countNotActivUchetDataGridViewTextBoxColumn,
            this.countNotActivOtherDataGridViewTextBoxColumn,
            this.allKWTDataGridViewTextBoxColumn,
            this.y2007DataGridViewTextBoxColumn,
            this.y2008DataGridViewTextBoxColumn});
            this.dgvefHouses.DataSource = this.bsHouses;
            this.dgvefHouses.Location = new System.Drawing.Point(0, 28);
            this.dgvefHouses.Name = "dgvefHouses";
            this.dgvefHouses.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvefHouses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvefHouses.Size = new System.Drawing.Size(833, 498);
            this.dgvefHouses.TabIndex = 0;
            this.dgvefHouses.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvefHouses_CellMouseClick);
            this.dgvefHouses.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvefHouses_CellMouseDoubleClick);
            // 
            // idmapDataGridViewTextBoxColumn
            // 
            this.idmapDataGridViewTextBoxColumn.DataPropertyName = "idmap";
            this.idmapDataGridViewTextBoxColumn.Frozen = true;
            this.idmapDataGridViewTextBoxColumn.HeaderText = "idmap";
            this.idmapDataGridViewTextBoxColumn.Name = "idmapDataGridViewTextBoxColumn";
            this.idmapDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmapDataGridViewTextBoxColumn.Visible = false;
            // 
            // kladrobjidDataGridViewTextBoxColumn
            // 
            this.kladrobjidDataGridViewTextBoxColumn.DataPropertyName = "kladrobjid";
            this.kladrobjidDataGridViewTextBoxColumn.Frozen = true;
            this.kladrobjidDataGridViewTextBoxColumn.HeaderText = "kladrobjid";
            this.kladrobjidDataGridViewTextBoxColumn.Name = "kladrobjidDataGridViewTextBoxColumn";
            this.kladrobjidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kladrobjidDataGridViewTextBoxColumn.Visible = false;
            // 
            // kladrObj
            // 
            this.kladrObj.DataPropertyName = "KladrObj";
            this.kladrObj.Frozen = true;
            this.kladrObj.HeaderText = "Нас. пункт";
            this.kladrObj.Name = "kladrObj";
            this.kladrObj.ReadOnly = true;
            this.kladrObj.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.kladrObj.Width = 80;
            // 
            // idStreetDataGridViewTextBoxColumn
            // 
            this.idStreetDataGridViewTextBoxColumn.DataPropertyName = "idStreet";
            this.idStreetDataGridViewTextBoxColumn.Frozen = true;
            this.idStreetDataGridViewTextBoxColumn.HeaderText = "idStreet";
            this.idStreetDataGridViewTextBoxColumn.Name = "idStreetDataGridViewTextBoxColumn";
            this.idStreetDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStreetDataGridViewTextBoxColumn.Visible = false;
            // 
            // street
            // 
            this.street.DataPropertyName = "Street";
            this.street.Frozen = true;
            this.street.HeaderText = "Улица";
            this.street.Name = "street";
            this.street.ReadOnly = true;
            this.street.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.Frozen = true;
            this.houseDataGridViewTextBoxColumn.HeaderText = "House";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            this.houseDataGridViewTextBoxColumn.Visible = false;
            // 
            // housePrefixDataGridViewTextBoxColumn
            // 
            this.housePrefixDataGridViewTextBoxColumn.DataPropertyName = "HousePrefix";
            this.housePrefixDataGridViewTextBoxColumn.Frozen = true;
            this.housePrefixDataGridViewTextBoxColumn.HeaderText = "HousePrefix";
            this.housePrefixDataGridViewTextBoxColumn.Name = "housePrefixDataGridViewTextBoxColumn";
            this.housePrefixDataGridViewTextBoxColumn.ReadOnly = true;
            this.housePrefixDataGridViewTextBoxColumn.Visible = false;
            // 
            // house
            // 
            this.house.DataPropertyName = "HouseAll";
            this.house.Frozen = true;
            this.house.HeaderText = "Дом";
            this.house.Name = "house";
            this.house.ReadOnly = true;
            this.house.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.house.Width = 40;
            // 
            // countAllDataGridViewTextBoxColumn
            // 
            this.countAllDataGridViewTextBoxColumn.DataPropertyName = "countAll";
            this.countAllDataGridViewTextBoxColumn.HeaderText = "Все аб.";
            this.countAllDataGridViewTextBoxColumn.Name = "countAllDataGridViewTextBoxColumn";
            this.countAllDataGridViewTextBoxColumn.ReadOnly = true;
            this.countAllDataGridViewTextBoxColumn.Width = 60;
            // 
            // countActivDataGridViewTextBoxColumn
            // 
            this.countActivDataGridViewTextBoxColumn.DataPropertyName = "CountActiv";
            this.countActivDataGridViewTextBoxColumn.HeaderText = "Активные аб.";
            this.countActivDataGridViewTextBoxColumn.Name = "countActivDataGridViewTextBoxColumn";
            this.countActivDataGridViewTextBoxColumn.ReadOnly = true;
            this.countActivDataGridViewTextBoxColumn.Width = 60;
            // 
            // countNotActivUchetDataGridViewTextBoxColumn
            // 
            this.countNotActivUchetDataGridViewTextBoxColumn.DataPropertyName = "CountNotActivUchet";
            this.countNotActivUchetDataGridViewTextBoxColumn.HeaderText = "На общем уч. аб.";
            this.countNotActivUchetDataGridViewTextBoxColumn.Name = "countNotActivUchetDataGridViewTextBoxColumn";
            this.countNotActivUchetDataGridViewTextBoxColumn.ReadOnly = true;
            this.countNotActivUchetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.countNotActivUchetDataGridViewTextBoxColumn.Width = 70;
            // 
            // countNotActivOtherDataGridViewTextBoxColumn
            // 
            this.countNotActivOtherDataGridViewTextBoxColumn.DataPropertyName = "CountNotActivOther";
            this.countNotActivOtherDataGridViewTextBoxColumn.HeaderText = "Прочие неакт. аб.";
            this.countNotActivOtherDataGridViewTextBoxColumn.Name = "countNotActivOtherDataGridViewTextBoxColumn";
            this.countNotActivOtherDataGridViewTextBoxColumn.ReadOnly = true;
            this.countNotActivOtherDataGridViewTextBoxColumn.Width = 60;
            // 
            // allKWTDataGridViewTextBoxColumn
            // 
            this.allKWTDataGridViewTextBoxColumn.DataPropertyName = "allKWT";
            this.allKWTDataGridViewTextBoxColumn.HeaderText = "Всего";
            this.allKWTDataGridViewTextBoxColumn.Name = "allKWTDataGridViewTextBoxColumn";
            this.allKWTDataGridViewTextBoxColumn.ReadOnly = true;
            this.allKWTDataGridViewTextBoxColumn.Width = 60;
            // 
            // y2007DataGridViewTextBoxColumn
            // 
            this.y2007DataGridViewTextBoxColumn.DataPropertyName = "y2007";
            this.y2007DataGridViewTextBoxColumn.HeaderText = "2007г.";
            this.y2007DataGridViewTextBoxColumn.Name = "y2007DataGridViewTextBoxColumn";
            this.y2007DataGridViewTextBoxColumn.ReadOnly = true;
            this.y2007DataGridViewTextBoxColumn.Width = 60;
            // 
            // y2008DataGridViewTextBoxColumn
            // 
            this.y2008DataGridViewTextBoxColumn.DataPropertyName = "y2008";
            this.y2008DataGridViewTextBoxColumn.HeaderText = "2008г.";
            this.y2008DataGridViewTextBoxColumn.Name = "y2008DataGridViewTextBoxColumn";
            this.y2008DataGridViewTextBoxColumn.ReadOnly = true;
            this.y2008DataGridViewTextBoxColumn.Width = 60;
            // 
            // bsHouses
            // 
            this.bsHouses.DataMember = "vPrv_HouseAll";
            this.bsHouses.DataSource = this.dsPrv;
            // 
            // dsPrv
            // 
            this.dsPrv.DataSetName = "DataSetPrv";
            this.dsPrv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFind,
            this.toolStripTextBoxFind,
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
            this.toolStripMain.Size = new System.Drawing.Size(833, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Image = global::Prv.Properties.Resources.Find;
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
            // 
            // toolStripButtonFindPrev
            // 
            this.toolStripButtonFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindPrev.Image = global::Prv.Properties.Resources.FindPrev;
            this.toolStripButtonFindPrev.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonFindPrev.Name = "toolStripButtonFindPrev";
            this.toolStripButtonFindPrev.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFindPrev.Text = "Поиск назад";
            this.toolStripButtonFindPrev.Click += new System.EventHandler(this.toolStripButtonFindPrev_Click);
            // 
            // toolStripButtonFindNext
            // 
            this.toolStripButtonFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFindNext.Image = global::Prv.Properties.Resources.FindNext;
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
            this.toolStripButtonPrint.Image = global::Prv.Properties.Resources.Print;
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
            this.toolStripButtonExportExcel.Image = global::Prv.Properties.Resources.Excel;
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
            this.toolStripButtonRefresh.Image = global::Prv.Properties.Resources.Refresh;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Обновить";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // panelWait
            // 
            this.panelWait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelWait.Controls.Add(this.groupBox1);
            this.panelWait.Location = new System.Drawing.Point(245, 211);
            this.panelWait.Name = "panelWait";
            this.panelWait.Size = new System.Drawing.Size(298, 61);
            this.panelWait.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 49);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Идет формирование отчета.";
            // 
            // cmsHouses
            // 
            this.cmsHouses.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DebAbonentHouseTSMI,
            this.DebAllHouseMonthTSMI,
            this.экспортВExelToolStripMenuItem,
            this.печатьToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.закрытьДомToolStripMenuItem,
            this.DelStatHouseTSMenuItem,
            this.tsmiActiveChangeStatus});
            this.cmsHouses.Name = "cmsHouses";
            this.cmsHouses.Size = new System.Drawing.Size(397, 208);
            // 
            // DebAbonentHouseTSMI
            // 
            this.DebAbonentHouseTSMI.Name = "DebAbonentHouseTSMI";
            this.DebAbonentHouseTSMI.Size = new System.Drawing.Size(396, 22);
            this.DebAbonentHouseTSMI.Text = "Текущий объект, текущий год, по абонентно, по месячно.";
            this.DebAbonentHouseTSMI.Click += new System.EventHandler(this.DebAbonentHouseTSMI_Click);
            // 
            // DebAllHouseMonthTSMI
            // 
            this.DebAllHouseMonthTSMI.Name = "DebAllHouseMonthTSMI";
            this.DebAllHouseMonthTSMI.Size = new System.Drawing.Size(396, 22);
            this.DebAllHouseMonthTSMI.Text = "Все объекты помесячно за текущий год.";
            this.DebAllHouseMonthTSMI.Click += new System.EventHandler(this.DebAllHouseMonthTSMI_Click);
            // 
            // экспортВExelToolStripMenuItem
            // 
            this.экспортВExelToolStripMenuItem.Image = global::Prv.Properties.Resources.Excel;
            this.экспортВExelToolStripMenuItem.Name = "экспортВExelToolStripMenuItem";
            this.экспортВExelToolStripMenuItem.Size = new System.Drawing.Size(396, 22);
            this.экспортВExelToolStripMenuItem.Text = "Экспорт в Exel";
            this.экспортВExelToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonExportExcel_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Image = global::Prv.Properties.Resources.Print;
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(396, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Image = global::Prv.Properties.Resources.Refresh;
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(396, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(393, 6);
            // 
            // закрытьДомToolStripMenuItem
            // 
            this.закрытьДомToolStripMenuItem.Name = "закрытьДомToolStripMenuItem";
            this.закрытьДомToolStripMenuItem.Size = new System.Drawing.Size(396, 22);
            this.закрытьДомToolStripMenuItem.Text = "Закрыть дом";
            this.закрытьДомToolStripMenuItem.Click += new System.EventHandler(this.CloseHouseToolStripMenuItem_Click);
            // 
            // DelStatHouseTSMenuItem
            // 
            this.DelStatHouseTSMenuItem.Name = "DelStatHouseTSMenuItem";
            this.DelStatHouseTSMenuItem.Size = new System.Drawing.Size(396, 22);
            this.DelStatHouseTSMenuItem.Text = "Удалить текущий статус у дома";
            this.DelStatHouseTSMenuItem.Click += new System.EventHandler(this.DelStatHouseTSMenuItem_Click);
            // 
            // tsmiActiveChangeStatus
            // 
            this.tsmiActiveChangeStatus.Name = "tsmiActiveChangeStatus";
            this.tsmiActiveChangeStatus.Size = new System.Drawing.Size(396, 22);
            this.tsmiActiveChangeStatus.Text = "Сменить статус у активных";
            this.tsmiActiveChangeStatus.Click += new System.EventHandler(this.tsmiActiveChangeStatus_Click);
            // 
            // FormHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 526);
            this.Controls.Add(this.panelWait);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.dgvefHouses);
            this.Name = "FormHouses";
            this.Text = "Дома";
            this.Load += new System.EventHandler(this.FormHouses_Load);
            this.Shown += new System.EventHandler(this.FormHouses_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvefHouses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsHouses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrv)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.panelWait.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cmsHouses.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvefHouses;
        private System.Windows.Forms.ToolStrip toolStripMain;
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
        private System.Windows.Forms.BindingSource bsHouses;
        private DataSets.DataSetPrv dsPrv;
        private System.Windows.Forms.Panel panelWait;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsHouses;
        private System.Windows.Forms.ToolStripMenuItem DebAbonentHouseTSMI;
        private System.Windows.Forms.ToolStripMenuItem DebAllHouseMonthTSMI;
        private System.Windows.Forms.ToolStripMenuItem экспортВExelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kladrobjidDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn kladrObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStreetDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housePrefixDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn house;
        private System.Windows.Forms.DataGridViewTextBoxColumn countAllDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countActivDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn countNotActivUchetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countNotActivOtherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allKWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn y2007DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn y2008DataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem закрытьДомToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DelStatHouseTSMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiActiveChangeStatus;
    }
}