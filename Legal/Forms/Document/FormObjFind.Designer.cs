namespace Legal.Forms.Document
{
    partial class FormObjFind
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbxFilter = new System.Windows.Forms.ToolStripComboBox();
            this.txtFilter = new System.Windows.Forms.ToolStripTextBox();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.btnDelFilter = new System.Windows.Forms.ToolStripButton();
            this.dgvAbn = new System.Windows.Forms.DataGridView();
            this.dgvidAbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.objNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dgvidAbnObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsFind1 = new Legal.DataSet.dsFind();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFind1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbxFilter,
            this.txtFilter,
            this.btnFilter,
            this.btnDelFilter});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(670, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbxFilter
            // 
            this.cbxFilter.Items.AddRange(new object[] {
            "Наименование",
            "Объект"});
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Size = new System.Drawing.Size(200, 25);
            // 
            // txtFilter
            // 
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(250, 25);
            // 
            // btnFilter
            // 
            this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFilter.Image = global::Legal.Properties.Resources.Filtr_my;
            this.btnFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(23, 22);
            this.btnFilter.Text = "toolStripButton1";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnDelFilter
            // 
            this.btnDelFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelFilter.Image = global::Legal.Properties.Resources.dialog_close;
            this.btnDelFilter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelFilter.Name = "btnDelFilter";
            this.btnDelFilter.Size = new System.Drawing.Size(23, 22);
            this.btnDelFilter.Text = "toolStripButton2";
            this.btnDelFilter.Click += new System.EventHandler(this.btnDelFilter_Click);
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
            this.dgvidAbn,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.objNameDataGridViewTextBoxColumn,
            this.dgvidAbnObj});
            this.dgvAbn.DataSource = this.bindingSource1;
            this.dgvAbn.Location = new System.Drawing.Point(0, 28);
            this.dgvAbn.MultiSelect = false;
            this.dgvAbn.Name = "dgvAbn";
            this.dgvAbn.ReadOnly = true;
            this.dgvAbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbn.Size = new System.Drawing.Size(670, 383);
            this.dgvAbn.TabIndex = 1;
            this.dgvAbn.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAbn_CellMouseDoubleClick);
            this.dgvAbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAbn_KeyDown);
            // 
            // dgvidAbn
            // 
            this.dgvidAbn.DataPropertyName = "idAbn";
            this.dgvidAbn.HeaderText = "idAbn";
            this.dgvidAbn.Name = "dgvidAbn";
            this.dgvidAbn.ReadOnly = true;
            this.dgvidAbn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvidAbn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvidAbn.Visible = false;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 70;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // objNameDataGridViewTextBoxColumn
            // 
            this.objNameDataGridViewTextBoxColumn.DataPropertyName = "ObjName";
            this.objNameDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.objNameDataGridViewTextBoxColumn.Name = "objNameDataGridViewTextBoxColumn";
            this.objNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.objNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.objNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // dgvidAbnObj
            // 
            this.dgvidAbnObj.DataPropertyName = "idAbnObj";
            this.dgvidAbnObj.HeaderText = "idAbnObj";
            this.dgvidAbnObj.Name = "dgvidAbnObj";
            this.dgvidAbnObj.ReadOnly = true;
            this.dgvidAbnObj.Visible = false;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vG_Find";
            this.bindingSource1.DataSource = this.dsFind1;
            // 
            // dsFind1
            // 
            this.dsFind1.DataSetName = "dsFind";
            this.dsFind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormObjFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 407);
            this.Controls.Add(this.dgvAbn);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormObjFind";
            this.Text = "Выбор";
            this.Load += new System.EventHandler(this.FormObjFind_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFind1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvAbn;
        private DataSet.dsFind dsFind1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripComboBox cbxFilter;
        private System.Windows.Forms.ToolStripTextBox txtFilter;
        private System.Windows.Forms.ToolStripButton btnFilter;
        private System.Windows.Forms.ToolStripButton btnDelFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidAbn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn objNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvidAbnObj;
    }
}