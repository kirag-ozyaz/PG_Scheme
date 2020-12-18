namespace Legal.Forms
{
    partial class FormFindObject
    {
        /// <summary>
        ///Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindObject));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAbn = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.idObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberSubObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.addressShortDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.tariffDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.abnNetDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.abnSaleDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.tAbnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsFind1 = new Legal.DataSet.dsFind();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAbnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFind1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbn
            // 
            this.dgvAbn.AllowUserToAddRows = false;
            this.dgvAbn.AllowUserToDeleteRows = false;
            this.dgvAbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAbn.AutoGenerateColumns = false;
            this.dgvAbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObj,
            this.numberObjDataGridViewTextBoxColumn,
            this.numberSubObjDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressShortDataGridViewTextBoxColumn,
            this.tariffDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.abnNetDataGridViewTextBoxColumn,
            this.abnSaleDataGridViewTextBoxColumn});
            this.dgvAbn.DataSource = this.tAbnBindingSource;
            this.dgvAbn.Location = new System.Drawing.Point(0, 28);
            this.dgvAbn.MultiSelect = false;
            this.dgvAbn.Name = "dgvAbn";
            this.dgvAbn.ReadOnly = true;
            this.dgvAbn.RowHeadersWidth = 10;
            this.dgvAbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbn.Size = new System.Drawing.Size(1002, 482);
            this.dgvAbn.TabIndex = 0;
            this.dgvAbn.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAbn_CellMouseDoubleClick);
            this.dgvAbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAbn_KeyDown);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1002, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExcel
            // 
            this.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(23, 22);
            this.btnExcel.Text = "Экспорт в Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // idObj
            // 
            this.idObj.DataPropertyName = "idObj";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.idObj.DefaultCellStyle = dataGridViewCellStyle1;
            this.idObj.HeaderText = "idObj";
            this.idObj.Name = "idObj";
            this.idObj.ReadOnly = true;
            this.idObj.Visible = false;
            // 
            // numberObjDataGridViewTextBoxColumn
            // 
            this.numberObjDataGridViewTextBoxColumn.DataPropertyName = "NumberObj";
            this.numberObjDataGridViewTextBoxColumn.HeaderText = "№";
            this.numberObjDataGridViewTextBoxColumn.Name = "numberObjDataGridViewTextBoxColumn";
            this.numberObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberObjDataGridViewTextBoxColumn.Width = 40;
            // 
            // numberSubObjDataGridViewTextBoxColumn
            // 
            this.numberSubObjDataGridViewTextBoxColumn.DataPropertyName = "NumberSubObj";
            this.numberSubObjDataGridViewTextBoxColumn.HeaderText = "№№";
            this.numberSubObjDataGridViewTextBoxColumn.Name = "numberSubObjDataGridViewTextBoxColumn";
            this.numberSubObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberSubObjDataGridViewTextBoxColumn.Width = 20;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // addressShortDataGridViewTextBoxColumn
            // 
            this.addressShortDataGridViewTextBoxColumn.DataPropertyName = "AddressShort";
            this.addressShortDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.addressShortDataGridViewTextBoxColumn.Name = "addressShortDataGridViewTextBoxColumn";
            this.addressShortDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressShortDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addressShortDataGridViewTextBoxColumn.Width = 200;
            // 
            // tariffDataGridViewTextBoxColumn
            // 
            this.tariffDataGridViewTextBoxColumn.DataPropertyName = "Tariff";
            this.tariffDataGridViewTextBoxColumn.HeaderText = "Тариф";
            this.tariffDataGridViewTextBoxColumn.Name = "tariffDataGridViewTextBoxColumn";
            this.tariffDataGridViewTextBoxColumn.ReadOnly = true;
            this.tariffDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // abnNetDataGridViewTextBoxColumn
            // 
            this.abnNetDataGridViewTextBoxColumn.DataPropertyName = "AbnNet";
            this.abnNetDataGridViewTextBoxColumn.HeaderText = "Сетевая";
            this.abnNetDataGridViewTextBoxColumn.Name = "abnNetDataGridViewTextBoxColumn";
            this.abnNetDataGridViewTextBoxColumn.ReadOnly = true;
            this.abnNetDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.abnNetDataGridViewTextBoxColumn.Width = 200;
            // 
            // abnSaleDataGridViewTextBoxColumn
            // 
            this.abnSaleDataGridViewTextBoxColumn.DataPropertyName = "AbnSale";
            this.abnSaleDataGridViewTextBoxColumn.HeaderText = "Сбытовая";
            this.abnSaleDataGridViewTextBoxColumn.Name = "abnSaleDataGridViewTextBoxColumn";
            this.abnSaleDataGridViewTextBoxColumn.ReadOnly = true;
            this.abnSaleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.abnSaleDataGridViewTextBoxColumn.Width = 200;
            // 
            // tAbnBindingSource
            // 
            this.tAbnBindingSource.DataMember = "vG_LegGetObj3";
            this.tAbnBindingSource.DataSource = this.dsFind1;
            // 
            // dsFind1
            // 
            this.dsFind1.DataSetName = "dsFind";
            this.dsFind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormFindObject
            // 
            this.ClientSize = new System.Drawing.Size(1002, 506);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvAbn);
            this.Name = "FormFindObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.FormAbnFind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAbnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFind1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbn;
        private System.Windows.Forms.BindingSource tAbnBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        //private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dgv_nameGroup;
        private DataSet.dsFind dsFind1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberObjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberSubObjDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn addressShortDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn tariffDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn quantityDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn abnNetDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn abnSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnExcel;
    }
}
