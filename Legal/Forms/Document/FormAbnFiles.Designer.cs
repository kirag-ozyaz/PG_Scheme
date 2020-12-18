namespace Legal.Forms.Document
{
    partial class FormAbnFiles
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
            this.toolStripAbnFiles = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButtonAdd = new System.Windows.Forms.ToolStripSplitButton();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.FolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbRenameFile = new System.Windows.Forms.ToolStripButton();
            this.tsbOpenFile = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSaveFile = new System.Windows.Forms.ToolStripButton();
            this.dgvAbnFiles = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.bsAbn_Files = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStripAbnFiles = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditNAmeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageFile = new System.Windows.Forms.DataGridViewImageColumn();
            this.IsGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripAbnFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbn_Files)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            this.contextMenuStripAbnFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripAbnFiles
            // 
            this.toolStripAbnFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButtonAdd,
            this.tsbRenameFile,
            this.tsbOpenFile,
            this.tsbDeleteFile,
            this.toolStripSeparator2,
            this.tsbSaveFile});
            this.toolStripAbnFiles.Location = new System.Drawing.Point(0, 0);
            this.toolStripAbnFiles.Name = "toolStripAbnFiles";
            this.toolStripAbnFiles.Size = new System.Drawing.Size(610, 25);
            this.toolStripAbnFiles.TabIndex = 0;
            this.toolStripAbnFiles.Text = "toolStrip1";
            // 
            // toolStripSplitButtonAdd
            // 
            this.toolStripSplitButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.toolStripSeparator5,
            this.FolderToolStripMenuItem,
            this.InsertToolStripMenuItem});
            this.toolStripSplitButtonAdd.Image = global::Legal.Properties.Resources._1304663065_Add;
            this.toolStripSplitButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonAdd.Name = "toolStripSplitButtonAdd";
            this.toolStripSplitButtonAdd.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButtonAdd.Text = "toolStripSplitButton2";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.FileToolStripMenuItem.Text = "Файл";
            this.FileToolStripMenuItem.Click += new System.EventHandler(this.AddFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(175, 6);
            // 
            // FolderToolStripMenuItem
            // 
            this.FolderToolStripMenuItem.Name = "FolderToolStripMenuItem";
            this.FolderToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.FolderToolStripMenuItem.Text = "Папку";
            this.FolderToolStripMenuItem.Click += new System.EventHandler(this.AddFolderToolStripMenuItem_Click);
            // 
            // InsertToolStripMenuItem
            // 
            this.InsertToolStripMenuItem.Name = "InsertToolStripMenuItem";
            this.InsertToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.InsertToolStripMenuItem.Text = "Поместить в папку";
            this.InsertToolStripMenuItem.Click += new System.EventHandler(this.AddInFolderToolStripMenuItem_Click);
            // 
            // tsbRenameFile
            // 
            this.tsbRenameFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRenameFile.Image = global::Legal.Properties.Resources._1304663141_Pen;
            this.tsbRenameFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRenameFile.Name = "tsbRenameFile";
            this.tsbRenameFile.Size = new System.Drawing.Size(23, 22);
            this.tsbRenameFile.Text = "Редактировать название";
            this.tsbRenameFile.Click += new System.EventHandler(this.tsbRenameFile_Click);
            // 
            // tsbOpenFile
            // 
            this.tsbOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpenFile.Image = global::Legal.Properties.Resources._1304672652_Information;
            this.tsbOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenFile.Name = "tsbOpenFile";
            this.tsbOpenFile.Size = new System.Drawing.Size(23, 22);
            this.tsbOpenFile.Text = "Открыть файл";
            this.tsbOpenFile.Click += new System.EventHandler(this.tsbOpenFile_Click);
            // 
            // tsbDeleteFile
            // 
            this.tsbDeleteFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteFile.Image = global::Legal.Properties.Resources.Delete;
            this.tsbDeleteFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteFile.Name = "tsbDeleteFile";
            this.tsbDeleteFile.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteFile.Text = "Удалить файл";
            this.tsbDeleteFile.Click += new System.EventHandler(this.tsbDeleteFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSaveFile
            // 
            this.tsbSaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveFile.Image = global::Legal.Properties.Resources.filesave;
            this.tsbSaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveFile.Name = "tsbSaveFile";
            this.tsbSaveFile.Size = new System.Drawing.Size(23, 22);
            this.tsbSaveFile.Text = "Сохранить файл";
            this.tsbSaveFile.Click += new System.EventHandler(this.tsbSaveFile_Click);
            // 
            // dgvAbnFiles
            // 
            this.dgvAbnFiles.AllowUserToAddRows = false;
            this.dgvAbnFiles.AllowUserToDeleteRows = false;
            this.dgvAbnFiles.AutoGenerateColumns = false;
            this.dgvAbnFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbnFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idAbnDataGridViewTextBoxColumn,
            this.fileName,
            this.fileDataGridViewImageColumn,
            this.dateDataGridViewTextBoxColumn,
            this.imageFile,
            this.IsGroup,
            this.ParentID});
            this.dgvAbnFiles.DataSource = this.bsAbn_Files;
            this.dgvAbnFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAbnFiles.Location = new System.Drawing.Point(0, 25);
            this.dgvAbnFiles.Name = "dgvAbnFiles";
            this.dgvAbnFiles.ReadOnly = true;
            this.dgvAbnFiles.RowHeadersWidth = 21;
            this.dgvAbnFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbnFiles.Size = new System.Drawing.Size(610, 456);
            this.dgvAbnFiles.TabIndex = 1;
            this.dgvAbnFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbnFiles_CellDoubleClick);
            this.dgvAbnFiles.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbnFiles_CellEndEdit);
            this.dgvAbnFiles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAbnFiles_CellFormatting);
            this.dgvAbnFiles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAbnFiles_CellMouseClick);
            this.dgvAbnFiles.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvAbnFiles_CellValidating);
            // 
            // bsAbn_Files
            // 
            this.bsAbn_Files.DataMember = "tAbn_Files";
            this.bsAbn_Files.DataSource = this.dsAbn;
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // contextMenuStripAbnFiles
            // 
            this.contextMenuStripAbnFiles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFileToolStripMenuItem,
            this.EditNAmeFileToolStripMenuItem,
            this.OpenFileToolStripMenuItem,
            this.DeleteFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.SaveFileToolStripMenuItem});
            this.contextMenuStripAbnFiles.Name = "contextMenuStripAbnFiles";
            this.contextMenuStripAbnFiles.Size = new System.Drawing.Size(208, 120);
            // 
            // AddFileToolStripMenuItem
            // 
            this.AddFileToolStripMenuItem.Image = global::Legal.Properties.Resources._1304663065_Add;
            this.AddFileToolStripMenuItem.Name = "AddFileToolStripMenuItem";
            this.AddFileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.AddFileToolStripMenuItem.Text = "Добавить";
            this.AddFileToolStripMenuItem.Click += new System.EventHandler(this.AddFileToolStripMenuItem_Click);
            // 
            // EditNAmeFileToolStripMenuItem
            // 
            this.EditNAmeFileToolStripMenuItem.Image = global::Legal.Properties.Resources._1304663141_Pen;
            this.EditNAmeFileToolStripMenuItem.Name = "EditNAmeFileToolStripMenuItem";
            this.EditNAmeFileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.EditNAmeFileToolStripMenuItem.Text = "Редактировать название";
            this.EditNAmeFileToolStripMenuItem.Click += new System.EventHandler(this.EditNAmeFileToolStripMenuItem_Click);
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Image = global::Legal.Properties.Resources._1304672652_Information;
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.OpenFileToolStripMenuItem.Text = "Просмотреть";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // DeleteFileToolStripMenuItem
            // 
            this.DeleteFileToolStripMenuItem.Image = global::Legal.Properties.Resources.Delete;
            this.DeleteFileToolStripMenuItem.Name = "DeleteFileToolStripMenuItem";
            this.DeleteFileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.DeleteFileToolStripMenuItem.Text = "Удалить";
            this.DeleteFileToolStripMenuItem.Click += new System.EventHandler(this.DeleteFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.Image = global::Legal.Properties.Resources.filesave;
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.SaveFileToolStripMenuItem.Text = "Сохранить";
            this.SaveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
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
            // fileName
            // 
            this.fileName.DataPropertyName = "FileName";
            this.fileName.HeaderText = "Имя";
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.fileName.Width = 400;
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // imageFile
            // 
            this.imageFile.HeaderText = "";
            this.imageFile.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageFile.Name = "imageFile";
            this.imageFile.ReadOnly = true;
            this.imageFile.Width = 30;
            // 
            // IsGroup
            // 
            this.IsGroup.DataPropertyName = "IsGroup";
            this.IsGroup.HeaderText = "IsGroup";
            this.IsGroup.Name = "IsGroup";
            this.IsGroup.ReadOnly = true;
            this.IsGroup.Visible = false;
            // 
            // ParentID
            // 
            this.ParentID.DataPropertyName = "ParentID";
            this.ParentID.HeaderText = "ParentID";
            this.ParentID.Name = "ParentID";
            this.ParentID.ReadOnly = true;
            this.ParentID.Visible = false;
            // 
            // FormAbnFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 481);
            this.Controls.Add(this.dgvAbnFiles);
            this.Controls.Add(this.toolStripAbnFiles);
            this.Name = "FormAbnFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Файлы контрагента";
            this.Load += new System.EventHandler(this.FormAbnFiles_Load);
            this.toolStripAbnFiles.ResumeLayout(false);
            this.toolStripAbnFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbnFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbn_Files)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            this.contextMenuStripAbnFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet.DataSetAbn dsAbn;
        private System.Windows.Forms.BindingSource bsAbn_Files;
        private System.Windows.Forms.ToolStrip toolStripAbnFiles;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvAbnFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripButton tsbRenameFile;
        private System.Windows.Forms.ToolStripButton tsbDeleteFile;
        private System.Windows.Forms.ToolStripButton tsbOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbSaveFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAbnFiles;
        private System.Windows.Forms.ToolStripMenuItem AddFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditNAmeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonAdd;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem FolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InsertToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileName;
        private System.Windows.Forms.DataGridViewImageColumn fileDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentID;
    }
}