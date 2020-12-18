namespace Legal.Forms.Object
{
    partial class FormObj_Linking
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
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsObj1 = new Legal.DataSet.dsObj();
            this.idObjDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSelect
            // 
            this.dgvSelect.AllowUserToAddRows = false;
            this.dgvSelect.AllowUserToDeleteRows = false;
            this.dgvSelect.AutoGenerateColumns = false;
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idObjDGV,
            this.NameDGV});
            this.dgvSelect.DataSource = this.bindingSource1;
            this.dgvSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelect.Location = new System.Drawing.Point(0, 0);
            this.dgvSelect.MultiSelect = false;
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.RowHeadersWidth = 10;
            this.dgvSelect.Size = new System.Drawing.Size(576, 413);
            this.dgvSelect.TabIndex = 1;
            this.dgvSelect.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSelect_CellMouseDoubleClick);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "dtObj";
            this.bindingSource1.DataSource = this.dsObj1;
            // 
            // dsObj1
            // 
            this.dsObj1.DataSetName = "dsObj";
            this.dsObj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idObjDGV
            // 
            this.idObjDGV.DataPropertyName = "idObj";
            this.idObjDGV.HeaderText = "idObj";
            this.idObjDGV.Name = "idObjDGV";
            this.idObjDGV.ReadOnly = true;
            this.idObjDGV.Visible = false;
            // 
            // NameDGV
            // 
            this.NameDGV.DataPropertyName = "Title";
            this.NameDGV.HeaderText = "Объект";
            this.NameDGV.Name = "NameDGV";
            this.NameDGV.ReadOnly = true;
            this.NameDGV.Width = 550;
            // 
            // FormObj_Linking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 413);
            this.Controls.Add(this.dgvSelect);
            this.Name = "FormObj_Linking";
            this.Text = "Привязка субобъекта к родительскому объекту";
            this.Load += new System.EventHandler(this.FormObj_Linking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSelect;
        private DataSet.dsObj dsObj1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDGV;
    }
}