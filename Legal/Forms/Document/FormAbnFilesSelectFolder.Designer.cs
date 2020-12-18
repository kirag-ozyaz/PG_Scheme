namespace Legal.Forms.Document
{
    partial class FormAbnFilesSelectFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbnFilesSelectFolder));
            this.bsFolder = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            this.dataGridViewFolders = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isGroupDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFolders)).BeginInit();
            this.SuspendLayout();
            // 
            // bsFolder
            // 
            this.bsFolder.DataMember = "tAbn_Files";
            this.bsFolder.DataSource = this.dsAbn;
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewFolders
            // 
            this.dataGridViewFolders.AllowUserToAddRows = false;
            this.dataGridViewFolders.AllowUserToDeleteRows = false;
            this.dataGridViewFolders.AutoGenerateColumns = false;
            this.dataGridViewFolders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFolders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idAbnDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.fileDataGridViewImageColumn,
            this.dateDataGridViewTextBoxColumn,
            this.deletedDataGridViewTextBoxColumn,
            this.parentIDDataGridViewTextBoxColumn,
            this.isGroupDataGridViewTextBoxColumn});
            this.dataGridViewFolders.DataSource = this.bsFolder;
            this.dataGridViewFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFolders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFolders.Name = "dataGridViewFolders";
            this.dataGridViewFolders.ReadOnly = true;
            this.dataGridViewFolders.RowHeadersWidth = 5;
            this.dataGridViewFolders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFolders.Size = new System.Drawing.Size(477, 262);
            this.dataGridViewFolders.TabIndex = 0;
            this.dataGridViewFolders.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewFolders_CellMouseDoubleClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fileNameDataGridViewTextBoxColumn.Width = 440;
            // 
            // fileDataGridViewImageColumn
            // 
            this.fileDataGridViewImageColumn.DataPropertyName = "File";
            this.fileDataGridViewImageColumn.HeaderText = "File";
            this.fileDataGridViewImageColumn.Name = "fileDataGridViewImageColumn";
            this.fileDataGridViewImageColumn.ReadOnly = true;
            this.fileDataGridViewImageColumn.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Visible = false;
            // 
            // deletedDataGridViewTextBoxColumn
            // 
            this.deletedDataGridViewTextBoxColumn.DataPropertyName = "Deleted";
            this.deletedDataGridViewTextBoxColumn.HeaderText = "Deleted";
            this.deletedDataGridViewTextBoxColumn.Name = "deletedDataGridViewTextBoxColumn";
            this.deletedDataGridViewTextBoxColumn.ReadOnly = true;
            this.deletedDataGridViewTextBoxColumn.Visible = false;
            // 
            // parentIDDataGridViewTextBoxColumn
            // 
            this.parentIDDataGridViewTextBoxColumn.DataPropertyName = "ParentID";
            this.parentIDDataGridViewTextBoxColumn.HeaderText = "ParentID";
            this.parentIDDataGridViewTextBoxColumn.Name = "parentIDDataGridViewTextBoxColumn";
            this.parentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // isGroupDataGridViewTextBoxColumn
            // 
            this.isGroupDataGridViewTextBoxColumn.DataPropertyName = "IsGroup";
            this.isGroupDataGridViewTextBoxColumn.HeaderText = "IsGroup";
            this.isGroupDataGridViewTextBoxColumn.Name = "isGroupDataGridViewTextBoxColumn";
            this.isGroupDataGridViewTextBoxColumn.ReadOnly = true;
            this.isGroupDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormAbnFilesSelectFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 262);
            this.Controls.Add(this.dataGridViewFolders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAbnFilesSelectFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выбрать паку";
            this.Load += new System.EventHandler(this.FormAbnFilesSelectFolder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFolders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bsFolder;
        private DataSet.DataSetAbn dsAbn;
        private System.Windows.Forms.DataGridView dataGridViewFolders;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fileDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deletedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isGroupDataGridViewTextBoxColumn;
    }
}