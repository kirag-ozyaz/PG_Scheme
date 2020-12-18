namespace Legal.Forms
{
    partial class FormAbnFindShort
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
            this.dgvAbn = new System.Windows.Forms.DataGridView();
            this.dgvIDAbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodeAbonent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abnWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsFind1 = new Legal.DataSet.dsFind();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.dgvIDAbn,
            this.dgvCodeAbonent,
            this.nameDataGridViewTextBoxColumn,
            this.abnWorkerDataGridViewTextBoxColumn});
            this.dgvAbn.DataSource = this.bindingSource1;
            this.dgvAbn.Location = new System.Drawing.Point(0, 0);
            this.dgvAbn.MultiSelect = false;
            this.dgvAbn.Name = "dgvAbn";
            this.dgvAbn.ReadOnly = true;
            this.dgvAbn.RowHeadersWidth = 10;
            this.dgvAbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbn.Size = new System.Drawing.Size(717, 387);
            this.dgvAbn.TabIndex = 0;
            this.dgvAbn.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAbn_CellMouseDoubleClick);
            this.dgvAbn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAbn_KeyDown);
            // 
            // dgvIDAbn
            // 
            this.dgvIDAbn.DataPropertyName = "idAbn";
            this.dgvIDAbn.HeaderText = "idAbn";
            this.dgvIDAbn.Name = "dgvIDAbn";
            this.dgvIDAbn.ReadOnly = true;
            this.dgvIDAbn.Visible = false;
            // 
            // dgvCodeAbonent
            // 
            this.dgvCodeAbonent.DataPropertyName = "CodeAbonent";
            this.dgvCodeAbonent.HeaderText = "Код";
            this.dgvCodeAbonent.Name = "dgvCodeAbonent";
            this.dgvCodeAbonent.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 400;
            // 
            // abnWorkerDataGridViewTextBoxColumn
            // 
            this.abnWorkerDataGridViewTextBoxColumn.DataPropertyName = "AbnWorker";
            this.abnWorkerDataGridViewTextBoxColumn.HeaderText = "Специалист";
            this.abnWorkerDataGridViewTextBoxColumn.Name = "abnWorkerDataGridViewTextBoxColumn";
            this.abnWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.abnWorkerDataGridViewTextBoxColumn.Width = 200;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vG_AbnObjCntShort";
            this.bindingSource1.DataSource = this.dsFind1;
            // 
            // dsFind1
            // 
            this.dsFind1.DataSetName = "dsFind";
            this.dsFind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormAbnFindShort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 387);
            this.Controls.Add(this.dgvAbn);
            this.Name = "FormAbnFindShort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск абонента";
            this.Load += new System.EventHandler(this.FormAbnFindShort_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsFind1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDAbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodeAbonent;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abnWorkerDataGridViewTextBoxColumn;
        private DataSet.dsFind dsFind1;
    }
}