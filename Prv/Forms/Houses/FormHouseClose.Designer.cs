namespace Prv.Forms.Houses
{
    partial class FormHouseClose
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.DGVEFAbnClose = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datechange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idmapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kladrobjidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allKWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y2007DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y2008DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAbnClose = new System.Windows.Forms.BindingSource(this.components);
            this.dsPrv = new Prv.DataSets.DataSetPrv();
            this.dateTimePickerEnd = new ControlsLbr.NullableDateTimePicker();
            this.labelReason = new System.Windows.Forms.Label();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.bCloseHouse = new System.Windows.Forms.Button();
            this.bindingSourceReason = new System.Windows.Forms.BindingSource(this.components);
            this.cmbReason = new System.Windows.Forms.ComboBox();
            this.toolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEFAbnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReason)).BeginInit();
            this.SuspendLayout();
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
            // DGVEFAbnClose
            // 
            this.DGVEFAbnClose.AllowUserToAddRows = false;
            this.DGVEFAbnClose.AllowUserToDeleteRows = false;
            this.DGVEFAbnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVEFAbnClose.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVEFAbnClose.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVEFAbnClose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEFAbnClose.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.apartmentDataGridViewTextBoxColumn,
            this.Reason,
            this.datechange,
            this.idReason,
            this.isActive,
            this.idmapDataGridViewTextBoxColumn,
            this.kladrobjidDataGridViewTextBoxColumn,
            this.allKWTDataGridViewTextBoxColumn,
            this.y2007DataGridViewTextBoxColumn,
            this.y2008DataGridViewTextBoxColumn});
            this.DGVEFAbnClose.DataSource = this.bsAbnClose;
            this.DGVEFAbnClose.Location = new System.Drawing.Point(0, 28);
            this.DGVEFAbnClose.Name = "DGVEFAbnClose";
            this.DGVEFAbnClose.ReadOnly = true;
            this.DGVEFAbnClose.Size = new System.Drawing.Size(833, 451);
            this.DGVEFAbnClose.TabIndex = 3;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Лиц. счет";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 80;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "Ф.И.О";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Width = 140;
            // 
            // apartmentDataGridViewTextBoxColumn
            // 
            this.apartmentDataGridViewTextBoxColumn.DataPropertyName = "Apartment";
            this.apartmentDataGridViewTextBoxColumn.HeaderText = "кв.";
            this.apartmentDataGridViewTextBoxColumn.Name = "apartmentDataGridViewTextBoxColumn";
            this.apartmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.apartmentDataGridViewTextBoxColumn.Width = 40;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Статус";
            this.Reason.Name = "Reason";
            this.Reason.ReadOnly = true;
            this.Reason.Width = 120;
            // 
            // datechange
            // 
            this.datechange.DataPropertyName = "datechange";
            this.datechange.HeaderText = "Дата";
            this.datechange.Name = "datechange";
            this.datechange.ReadOnly = true;
            this.datechange.Width = 80;
            // 
            // idReason
            // 
            this.idReason.DataPropertyName = "idReason";
            this.idReason.HeaderText = "idReason";
            this.idReason.Name = "idReason";
            this.idReason.ReadOnly = true;
            this.idReason.Visible = false;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "isActive";
            this.isActive.HeaderText = "isActive";
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Visible = false;
            // 
            // idmapDataGridViewTextBoxColumn
            // 
            this.idmapDataGridViewTextBoxColumn.DataPropertyName = "idmap";
            this.idmapDataGridViewTextBoxColumn.HeaderText = "idmap";
            this.idmapDataGridViewTextBoxColumn.Name = "idmapDataGridViewTextBoxColumn";
            this.idmapDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmapDataGridViewTextBoxColumn.Visible = false;
            // 
            // kladrobjidDataGridViewTextBoxColumn
            // 
            this.kladrobjidDataGridViewTextBoxColumn.DataPropertyName = "kladrobjid";
            this.kladrobjidDataGridViewTextBoxColumn.HeaderText = "kladrobjid";
            this.kladrobjidDataGridViewTextBoxColumn.Name = "kladrobjidDataGridViewTextBoxColumn";
            this.kladrobjidDataGridViewTextBoxColumn.ReadOnly = true;
            this.kladrobjidDataGridViewTextBoxColumn.Visible = false;
            // 
            // allKWTDataGridViewTextBoxColumn
            // 
            this.allKWTDataGridViewTextBoxColumn.DataPropertyName = "allKWT";
            this.allKWTDataGridViewTextBoxColumn.HeaderText = "Всего, кВт";
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
            // bsAbnClose
            // 
            this.bsAbnClose.DataMember = "vPrv_HousesClose";
            this.bsAbnClose.DataSource = this.dsPrv;
            // 
            // dsPrv
            // 
            this.dsPrv.DataSetName = "DataSetPrv";
            this.dsPrv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(107, 494);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerEnd.TabIndex = 13;
            this.dateTimePickerEnd.Value = new System.DateTime(2010, 11, 15, 13, 57, 14, 428);
            // 
            // labelReason
            // 
            this.labelReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelReason.AutoSize = true;
            this.labelReason.Location = new System.Drawing.Point(264, 497);
            this.labelReason.Name = "labelReason";
            this.labelReason.Size = new System.Drawing.Size(50, 13);
            this.labelReason.TabIndex = 14;
            this.labelReason.Text = "Причина";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(12, 497);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(89, 13);
            this.labelDateEnd.TabIndex = 12;
            this.labelDateEnd.Text = "Дата окончания";
            // 
            // bCloseHouse
            // 
            this.bCloseHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCloseHouse.Location = new System.Drawing.Point(649, 487);
            this.bCloseHouse.Name = "bCloseHouse";
            this.bCloseHouse.Size = new System.Drawing.Size(172, 33);
            this.bCloseHouse.TabIndex = 16;
            this.bCloseHouse.Text = "Закрыть дом";
            this.bCloseHouse.UseVisualStyleBackColor = true;
            this.bCloseHouse.Click += new System.EventHandler(this.bCloseHouse_Click);
            // 
            // bindingSourceReason
            // 
            this.bindingSourceReason.DataMember = "tR_Classifier";
            this.bindingSourceReason.DataSource = this.dsPrv;
            this.bindingSourceReason.Filter = "ParentKey = \';SKUEE;ReasonStatus;ReasonAbnFL;\'";
            // 
            // cmbReason
            // 
            this.cmbReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbReason.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbReason.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbReason.DataSource = this.bindingSourceReason;
            this.cmbReason.DisplayMember = "Name";
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Location = new System.Drawing.Point(320, 494);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(323, 21);
            this.cmbReason.TabIndex = 17;
            this.cmbReason.ValueMember = "Id";
            // 
            // FormHouseClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 526);
            this.Controls.Add(this.cmbReason);
            this.Controls.Add(this.bCloseHouse);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.labelReason);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.DGVEFAbnClose);
            this.Controls.Add(this.toolStripMain);
            this.Name = "FormHouseClose";
            this.Text = "Закрыть дом";
            this.Load += new System.EventHandler(this.FormHouseClose_Load);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEFAbnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPrv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReason)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter DGVEFAbnClose;
        private System.Windows.Forms.BindingSource bsAbnClose;
        private DataSets.DataSetPrv dsPrv;
        private ControlsLbr.NullableDateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelReason;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Button bCloseHouse;
        private System.Windows.Forms.BindingSource bindingSourceReason;
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn datechange;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReason;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kladrobjidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allKWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn y2007DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn y2008DataGridViewTextBoxColumn;
    }
}