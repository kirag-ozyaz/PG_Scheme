namespace Prv.Forms.Reports
{
    partial class FormRepAbnFlag
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
            this.dgvefAbnFlags = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bsAbnFlags = new System.Windows.Forms.BindingSource(this.components);
            this.dsRep = new Prv.DataSets.DataSetRep();
            this.cbGroupFlags = new System.Windows.Forms.ComboBox();
            this.bsGroupName = new System.Windows.Forms.BindingSource(this.components);
            this.clbFlags = new System.Windows.Forms.CheckedListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.idmapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrobjidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.housePrefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseAllDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countFlagsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvefAbnFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnFlags)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupName)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvefAbnFlags
            // 
            this.dgvefAbnFlags.AllowUserToAddRows = false;
            this.dgvefAbnFlags.AllowUserToDeleteRows = false;
            this.dgvefAbnFlags.AllowUserToOrderColumns = true;
            this.dgvefAbnFlags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvefAbnFlags.AutoGenerateColumns = false;
            this.dgvefAbnFlags.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvefAbnFlags.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmapDataGridViewTextBoxColumn,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.typeAbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.kladrobjidDataGridViewTextBoxColumn,
            this.kladrObjDataGridViewTextBoxColumn,
            this.idStreetDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.houseDataGridViewTextBoxColumn,
            this.housePrefixDataGridViewTextBoxColumn,
            this.houseAllDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.countFlagsDataGridViewTextBoxColumn});
            this.dgvefAbnFlags.DataSource = this.bsAbnFlags;
            this.dgvefAbnFlags.Location = new System.Drawing.Point(3, 28);
            this.dgvefAbnFlags.Name = "dgvefAbnFlags";
            this.dgvefAbnFlags.ReadOnly = true;
            this.dgvefAbnFlags.RowHeadersWidth = 21;
            this.dgvefAbnFlags.Size = new System.Drawing.Size(596, 541);
            this.dgvefAbnFlags.TabIndex = 0;
            // 
            // bsAbnFlags
            // 
            this.bsAbnFlags.DataMember = "vAbn_HouseFlags";
            this.bsAbnFlags.DataSource = this.dsRep;
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "DataSetRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbGroupFlags
            // 
            this.cbGroupFlags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGroupFlags.DataSource = this.bsGroupName;
            this.cbGroupFlags.DisplayMember = "Name";
            this.cbGroupFlags.FormattingEnabled = true;
            this.cbGroupFlags.Location = new System.Drawing.Point(609, 13);
            this.cbGroupFlags.Name = "cbGroupFlags";
            this.cbGroupFlags.Size = new System.Drawing.Size(144, 21);
            this.cbGroupFlags.TabIndex = 1;
            this.cbGroupFlags.ValueMember = "Id";
            this.cbGroupFlags.SelectedIndexChanged += new System.EventHandler(this.cbGroupFlags_SelectedIndexChanged);
            // 
            // bsGroupName
            // 
            this.bsGroupName.DataMember = "tR_Classifier_GroupFlags";
            this.bsGroupName.DataSource = this.dsRep;
            // 
            // clbFlags
            // 
            this.clbFlags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clbFlags.FormattingEnabled = true;
            this.clbFlags.Location = new System.Drawing.Point(609, 52);
            this.clbFlags.Name = "clbFlags";
            this.clbFlags.Size = new System.Drawing.Size(144, 454);
            this.clbFlags.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(609, 540);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(144, 23);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Выход";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Location = new System.Drawing.Point(609, 511);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(144, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Сформировать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.toolStripMain);
            this.panel1.Controls.Add(this.dgvefAbnFlags);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 572);
            this.panel1.TabIndex = 5;
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
            this.toolStripMain.Size = new System.Drawing.Size(602, 25);
            this.toolStripMain.TabIndex = 2;
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
            this.toolStripTextBoxFind.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxFind_KeyDown);
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
            // idmapDataGridViewTextBoxColumn
            // 
            this.idmapDataGridViewTextBoxColumn.DataPropertyName = "idmap";
            this.idmapDataGridViewTextBoxColumn.HeaderText = "idmap";
            this.idmapDataGridViewTextBoxColumn.Name = "idmapDataGridViewTextBoxColumn";
            this.idmapDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmapDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "№";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeAbnDataGridViewTextBoxColumn
            // 
            this.typeAbnDataGridViewTextBoxColumn.DataPropertyName = "TypeAbn";
            this.typeAbnDataGridViewTextBoxColumn.HeaderText = "TypeAbn";
            this.typeAbnDataGridViewTextBoxColumn.Name = "typeAbnDataGridViewTextBoxColumn";
            this.typeAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kladrobjidDataGridViewTextBoxColumn
            // 
            this.kladrobjidDataGridViewTextBoxColumn.DataPropertyName = "kladrobjid";
            this.kladrobjidDataGridViewTextBoxColumn.HeaderText = "kladrobjid";
            this.kladrobjidDataGridViewTextBoxColumn.Name = "kladrobjidDataGridViewTextBoxColumn";
            this.kladrobjidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kladrobjidDataGridViewTextBoxColumn.Visible = false;
            // 
            // kladrObjDataGridViewTextBoxColumn
            // 
            this.kladrObjDataGridViewTextBoxColumn.DataPropertyName = "KladrObj";
            this.kladrObjDataGridViewTextBoxColumn.HeaderText = "Нас.пункт";
            this.kladrObjDataGridViewTextBoxColumn.Name = "kladrObjDataGridViewTextBoxColumn";
            this.kladrObjDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idStreetDataGridViewTextBoxColumn
            // 
            this.idStreetDataGridViewTextBoxColumn.DataPropertyName = "idStreet";
            this.idStreetDataGridViewTextBoxColumn.HeaderText = "idStreet";
            this.idStreetDataGridViewTextBoxColumn.Name = "idStreetDataGridViewTextBoxColumn";
            this.idStreetDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStreetDataGridViewTextBoxColumn.Visible = false;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Улица";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // houseDataGridViewTextBoxColumn
            // 
            this.houseDataGridViewTextBoxColumn.DataPropertyName = "House";
            this.houseDataGridViewTextBoxColumn.HeaderText = "House";
            this.houseDataGridViewTextBoxColumn.Name = "houseDataGridViewTextBoxColumn";
            this.houseDataGridViewTextBoxColumn.ReadOnly = true;
            this.houseDataGridViewTextBoxColumn.Visible = false;
            // 
            // housePrefixDataGridViewTextBoxColumn
            // 
            this.housePrefixDataGridViewTextBoxColumn.DataPropertyName = "HousePrefix";
            this.housePrefixDataGridViewTextBoxColumn.HeaderText = "HousePrefix";
            this.housePrefixDataGridViewTextBoxColumn.Name = "housePrefixDataGridViewTextBoxColumn";
            this.housePrefixDataGridViewTextBoxColumn.ReadOnly = true;
            this.housePrefixDataGridViewTextBoxColumn.Visible = false;
            // 
            // houseAllDataGridViewTextBoxColumn
            // 
            this.houseAllDataGridViewTextBoxColumn.DataPropertyName = "HouseAll";
            this.houseAllDataGridViewTextBoxColumn.HeaderText = "Дом";
            this.houseAllDataGridViewTextBoxColumn.Name = "houseAllDataGridViewTextBoxColumn";
            this.houseAllDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // countFlagsDataGridViewTextBoxColumn
            // 
            this.countFlagsDataGridViewTextBoxColumn.DataPropertyName = "CountFlags";
            this.countFlagsDataGridViewTextBoxColumn.HeaderText = "CountFlags";
            this.countFlagsDataGridViewTextBoxColumn.Name = "countFlagsDataGridViewTextBoxColumn";
            this.countFlagsDataGridViewTextBoxColumn.ReadOnly = true;
            this.countFlagsDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormRepAbnFlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.clbFlags);
            this.Controls.Add(this.cbGroupFlags);
            this.Name = "FormRepAbnFlag";
            this.Text = "Отчет по признакам";
            this.Load += new System.EventHandler(this.FormRepAbnFlag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvefAbnFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnFlags)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGroupName)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSets.DataSetRep dsRep;
        private System.Windows.Forms.BindingSource bsAbnFlags;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvefAbnFlags;
        private System.Windows.Forms.BindingSource bsGroupName;
        private System.Windows.Forms.ComboBox cbGroupFlags;
        private System.Windows.Forms.CheckedListBox clbFlags;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idmapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kladrobjidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kladrObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housePrefixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseAllDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countFlagsDataGridViewTextBoxColumn;
    }
}