namespace Prv.Forms.Houses
{
    partial class FormHousesAllDebMonth
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsPrv = new Prv.DataSets.DataSetPrv();
            this.bsAllHouses = new System.Windows.Forms.BindingSource(this.components);
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
            this.dgvefHousesAll = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.panelWait = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idmapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrobjidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrObjDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housePrefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseAllDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.countAllDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m9DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m11DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m12DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAllHouses)).BeginInit();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefHousesAll)).BeginInit();
            this.panelWait.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsPrv
            // 
            this.dsPrv.DataSetName = "DataSetPrv";
            this.dsPrv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsAllHouses
            // 
            this.bsAllHouses.DataMember = "fn_PrvGetMapHouseAllDeb";
            this.bsAllHouses.DataSource = this.dsPrv;
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
            this.toolStripMain.TabIndex = 3;
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
            // dgvefHousesAll
            // 
            this.dgvefHousesAll.AllowUserToAddRows = false;
            this.dgvefHousesAll.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvefHousesAll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvefHousesAll.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvefHousesAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvefHousesAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvefHousesAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmapDataGridViewTextBoxColumn,
            this.kladrobjidDataGridViewTextBoxColumn,
            this.kladrObjDataGridViewTextBoxColumn,
            this.idStreetDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.housePrefixDataGridViewTextBoxColumn,
            this.houseAllDataGridViewTextBoxColumn,
            this.countAllDataGridViewTextBoxColumn,
            this.m1DataGridViewTextBoxColumn,
            this.m2DataGridViewTextBoxColumn,
            this.m3DataGridViewTextBoxColumn,
            this.m4DataGridViewTextBoxColumn,
            this.m5DataGridViewTextBoxColumn,
            this.m6DataGridViewTextBoxColumn,
            this.m7DataGridViewTextBoxColumn,
            this.m8DataGridViewTextBoxColumn,
            this.m9DataGridViewTextBoxColumn,
            this.m10DataGridViewTextBoxColumn,
            this.m11DataGridViewTextBoxColumn,
            this.m12DataGridViewTextBoxColumn});
            this.dgvefHousesAll.DataSource = this.bsAllHouses;
            this.dgvefHousesAll.Location = new System.Drawing.Point(0, 28);
            this.dgvefHousesAll.Name = "dgvefHousesAll";
            this.dgvefHousesAll.ReadOnly = true;
            this.dgvefHousesAll.RowHeadersWidth = 21;
            this.dgvefHousesAll.Size = new System.Drawing.Size(833, 498);
            this.dgvefHousesAll.TabIndex = 4;
            // 
            // panelWait
            // 
            this.panelWait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelWait.Controls.Add(this.groupBox1);
            this.panelWait.Location = new System.Drawing.Point(267, 233);
            this.panelWait.Name = "panelWait";
            this.panelWait.Size = new System.Drawing.Size(298, 61);
            this.panelWait.TabIndex = 5;
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
            // kladrObjDataGridViewTextBoxColumn
            // 
            this.kladrObjDataGridViewTextBoxColumn.DataPropertyName = "KladrObj";
            this.kladrObjDataGridViewTextBoxColumn.Frozen = true;
            this.kladrObjDataGridViewTextBoxColumn.HeaderText = "Нас.пункт";
            this.kladrObjDataGridViewTextBoxColumn.Name = "kladrObjDataGridViewTextBoxColumn";
            this.kladrObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.kladrObjDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.Frozen = true;
            this.streetDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // houseAllDataGridViewTextBoxColumn
            // 
            this.houseAllDataGridViewTextBoxColumn.DataPropertyName = "HouseAll";
            this.houseAllDataGridViewTextBoxColumn.Frozen = true;
            this.houseAllDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.houseAllDataGridViewTextBoxColumn.Name = "houseAllDataGridViewTextBoxColumn";
            this.houseAllDataGridViewTextBoxColumn.ReadOnly = true;
            this.houseAllDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.houseAllDataGridViewTextBoxColumn.Width = 40;
            // 
            // countAllDataGridViewTextBoxColumn
            // 
            this.countAllDataGridViewTextBoxColumn.DataPropertyName = "countAll";
            this.countAllDataGridViewTextBoxColumn.HeaderText = "Аб.";
            this.countAllDataGridViewTextBoxColumn.Name = "countAllDataGridViewTextBoxColumn";
            this.countAllDataGridViewTextBoxColumn.ReadOnly = true;
            this.countAllDataGridViewTextBoxColumn.Width = 40;
            // 
            // m1DataGridViewTextBoxColumn
            // 
            this.m1DataGridViewTextBoxColumn.DataPropertyName = "M1";
            this.m1DataGridViewTextBoxColumn.HeaderText = "январь";
            this.m1DataGridViewTextBoxColumn.Name = "m1DataGridViewTextBoxColumn";
            this.m1DataGridViewTextBoxColumn.ReadOnly = true;
            this.m1DataGridViewTextBoxColumn.Width = 65;
            // 
            // m2DataGridViewTextBoxColumn
            // 
            this.m2DataGridViewTextBoxColumn.DataPropertyName = "M2";
            this.m2DataGridViewTextBoxColumn.HeaderText = "февраль";
            this.m2DataGridViewTextBoxColumn.Name = "m2DataGridViewTextBoxColumn";
            this.m2DataGridViewTextBoxColumn.ReadOnly = true;
            this.m2DataGridViewTextBoxColumn.Width = 65;
            // 
            // m3DataGridViewTextBoxColumn
            // 
            this.m3DataGridViewTextBoxColumn.DataPropertyName = "M3";
            this.m3DataGridViewTextBoxColumn.HeaderText = "март";
            this.m3DataGridViewTextBoxColumn.Name = "m3DataGridViewTextBoxColumn";
            this.m3DataGridViewTextBoxColumn.ReadOnly = true;
            this.m3DataGridViewTextBoxColumn.Width = 65;
            // 
            // m4DataGridViewTextBoxColumn
            // 
            this.m4DataGridViewTextBoxColumn.DataPropertyName = "M4";
            this.m4DataGridViewTextBoxColumn.HeaderText = "апрель";
            this.m4DataGridViewTextBoxColumn.Name = "m4DataGridViewTextBoxColumn";
            this.m4DataGridViewTextBoxColumn.ReadOnly = true;
            this.m4DataGridViewTextBoxColumn.Width = 65;
            // 
            // m5DataGridViewTextBoxColumn
            // 
            this.m5DataGridViewTextBoxColumn.DataPropertyName = "M5";
            this.m5DataGridViewTextBoxColumn.HeaderText = "май";
            this.m5DataGridViewTextBoxColumn.Name = "m5DataGridViewTextBoxColumn";
            this.m5DataGridViewTextBoxColumn.ReadOnly = true;
            this.m5DataGridViewTextBoxColumn.Width = 65;
            // 
            // m6DataGridViewTextBoxColumn
            // 
            this.m6DataGridViewTextBoxColumn.DataPropertyName = "M6";
            this.m6DataGridViewTextBoxColumn.HeaderText = "июнь";
            this.m6DataGridViewTextBoxColumn.Name = "m6DataGridViewTextBoxColumn";
            this.m6DataGridViewTextBoxColumn.ReadOnly = true;
            this.m6DataGridViewTextBoxColumn.Width = 65;
            // 
            // m7DataGridViewTextBoxColumn
            // 
            this.m7DataGridViewTextBoxColumn.DataPropertyName = "M7";
            this.m7DataGridViewTextBoxColumn.HeaderText = "июль";
            this.m7DataGridViewTextBoxColumn.Name = "m7DataGridViewTextBoxColumn";
            this.m7DataGridViewTextBoxColumn.ReadOnly = true;
            this.m7DataGridViewTextBoxColumn.Width = 65;
            // 
            // m8DataGridViewTextBoxColumn
            // 
            this.m8DataGridViewTextBoxColumn.DataPropertyName = "M8";
            this.m8DataGridViewTextBoxColumn.HeaderText = "август";
            this.m8DataGridViewTextBoxColumn.Name = "m8DataGridViewTextBoxColumn";
            this.m8DataGridViewTextBoxColumn.ReadOnly = true;
            this.m8DataGridViewTextBoxColumn.Width = 65;
            // 
            // m9DataGridViewTextBoxColumn
            // 
            this.m9DataGridViewTextBoxColumn.DataPropertyName = "M9";
            this.m9DataGridViewTextBoxColumn.HeaderText = "сентябрь";
            this.m9DataGridViewTextBoxColumn.Name = "m9DataGridViewTextBoxColumn";
            this.m9DataGridViewTextBoxColumn.ReadOnly = true;
            this.m9DataGridViewTextBoxColumn.Width = 65;
            // 
            // m10DataGridViewTextBoxColumn
            // 
            this.m10DataGridViewTextBoxColumn.DataPropertyName = "M10";
            this.m10DataGridViewTextBoxColumn.HeaderText = "октябрь";
            this.m10DataGridViewTextBoxColumn.Name = "m10DataGridViewTextBoxColumn";
            this.m10DataGridViewTextBoxColumn.ReadOnly = true;
            this.m10DataGridViewTextBoxColumn.Width = 65;
            // 
            // m11DataGridViewTextBoxColumn
            // 
            this.m11DataGridViewTextBoxColumn.DataPropertyName = "M11";
            this.m11DataGridViewTextBoxColumn.HeaderText = "ноябрь";
            this.m11DataGridViewTextBoxColumn.Name = "m11DataGridViewTextBoxColumn";
            this.m11DataGridViewTextBoxColumn.ReadOnly = true;
            this.m11DataGridViewTextBoxColumn.Width = 65;
            // 
            // m12DataGridViewTextBoxColumn
            // 
            this.m12DataGridViewTextBoxColumn.DataPropertyName = "M12";
            this.m12DataGridViewTextBoxColumn.HeaderText = "декабрь";
            this.m12DataGridViewTextBoxColumn.Name = "m12DataGridViewTextBoxColumn";
            this.m12DataGridViewTextBoxColumn.ReadOnly = true;
            this.m12DataGridViewTextBoxColumn.Width = 65;
            // 
            // FormHousesAllDebMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 526);
            this.Controls.Add(this.panelWait);
            this.Controls.Add(this.dgvefHousesAll);
            this.Controls.Add(this.toolStripMain);
            this.Name = "FormHousesAllDebMonth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormHousesAllDebMonth";
            this.Load += new System.EventHandler(this.FormHousesAllDebMonth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsPrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAllHouses)).EndInit();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefHousesAll)).EndInit();
            this.panelWait.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DataSetPrv dsPrv;
        private System.Windows.Forms.BindingSource bsAllHouses;
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
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvefHousesAll;
        private System.Windows.Forms.Panel panelWait;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kladrobjidDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn kladrObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStreetDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housePrefixDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn houseAllDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countAllDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m9DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m11DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn m12DataGridViewTextBoxColumn;
    }
}