namespace Library
{
    partial class PageReestrDocs
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripDocuments = new System.Windows.Forms.ToolStrip();
            this.toolBtnAddDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnViewDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSaveDoc = new System.Windows.Forms.ToolStripButton();
            this.dataSetDoc = new System.Data.DataSet();
            this.tJ_DamageDoc = new System.Data.DataTable();
            this.id = new System.Data.DataColumn();
            this.idDamage = new System.Data.DataColumn();
            this.Document = new System.Data.DataColumn();
            this.FileName = new System.Data.DataColumn();
            this.Comment = new System.Data.DataColumn();
            this.cTypeDoc = new System.Data.DataColumn();
            this.bsDoc = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDocs = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.ColumnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDamageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_DamageDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripDocuments
            // 
            this.toolStripDocuments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAddDoc,
            this.toolBtnDelDoc,
            this.toolBtnViewDoc,
            this.toolBtnSaveDoc});
            this.toolStripDocuments.Location = new System.Drawing.Point(0, 0);
            this.toolStripDocuments.Name = "toolStripDocuments";
            this.toolStripDocuments.Size = new System.Drawing.Size(396, 25);
            this.toolStripDocuments.TabIndex = 2;
            this.toolStripDocuments.Text = "toolStrip1";
            // 
            // toolBtnAddDoc
            // 
            this.toolBtnAddDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddDoc.Image = global::Library.Properties.Resources.Add;
            this.toolBtnAddDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddDoc.Name = "toolBtnAddDoc";
            this.toolBtnAddDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddDoc.Text = "Добавить документ";
            this.toolBtnAddDoc.Click += new System.EventHandler(this.toolBtnAddDoc_Click);
            // 
            // toolBtnDelDoc
            // 
            this.toolBtnDelDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelDoc.Image = global::Library.Properties.Resources.Delete;
            this.toolBtnDelDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelDoc.Name = "toolBtnDelDoc";
            this.toolBtnDelDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelDoc.Text = "Удалить документ";
            this.toolBtnDelDoc.Click += new System.EventHandler(this.toolBtnDelDoc_Click);
            // 
            // toolBtnViewDoc
            // 
            this.toolBtnViewDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnViewDoc.Image = global::Library.Properties.Resources.Information;
            this.toolBtnViewDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnViewDoc.Name = "toolBtnViewDoc";
            this.toolBtnViewDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnViewDoc.Text = "Открыть документ";
            this.toolBtnViewDoc.Click += new System.EventHandler(this.toolBtnViewDoc_Click);
            // 
            // toolBtnSaveDoc
            // 
            this.toolBtnSaveDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSaveDoc.Image = global::Library.Properties.Resources.Export;
            this.toolBtnSaveDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSaveDoc.Name = "toolBtnSaveDoc";
            this.toolBtnSaveDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSaveDoc.Text = "Сохранить документ";
            this.toolBtnSaveDoc.Click += new System.EventHandler(this.toolBtnSaveDoc_Click);
            // 
            // dataSetDoc
            // 
            this.dataSetDoc.DataSetName = "DataSetDoc";
            this.dataSetDoc.Tables.AddRange(new System.Data.DataTable[] {
            this.tJ_DamageDoc});
            // 
            // tJ_DamageDoc
            // 
            this.tJ_DamageDoc.Columns.AddRange(new System.Data.DataColumn[] {
            this.id,
            this.idDamage,
            this.Document,
            this.FileName,
            this.Comment,
            this.cTypeDoc});
            this.tJ_DamageDoc.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "id"}, false)});
            this.tJ_DamageDoc.TableName = "tJ_DamageDoc";
            // 
            // id
            // 
            this.id.AllowDBNull = false;
            this.id.AutoIncrement = true;
            this.id.AutoIncrementSeed = ((long)(-1));
            this.id.AutoIncrementStep = ((long)(-1));
            this.id.ColumnName = "id";
            this.id.DataType = typeof(int);
            this.id.ReadOnly = true;
            // 
            // idDamage
            // 
            this.idDamage.AllowDBNull = false;
            this.idDamage.ColumnName = "idDamage";
            this.idDamage.DataType = typeof(int);
            // 
            // Document
            // 
            this.Document.ColumnName = "Document";
            this.Document.DataType = typeof(byte[]);
            // 
            // FileName
            // 
            this.FileName.ColumnName = "FileName";
            // 
            // Comment
            // 
            this.Comment.ColumnName = "Comment";
            // 
            // TypeDoc
            // 
            this.cTypeDoc.ColumnName = "TypeDoc";
            this.cTypeDoc.DataType = typeof(int);
            // 
            // bsDoc
            // 
            this.bsDoc.DataMember = "tJ_DamageDoc";
            this.bsDoc.DataSource = this.dataSetDoc;
            // 
            // dgvDocs
            // 
            this.dgvDocs.AllowUserToAddRows = false;
            this.dgvDocs.AllowUserToDeleteRows = false;
            this.dgvDocs.AutoGenerateColumns = false;
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImage,
            this.dataGridViewTextBoxColumn1,
            this.idDataGridViewTextBoxColumn,
            this.idDamageDataGridViewTextBoxColumn,
            this.documentDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dgvDocs.DataSource = this.bsDoc;
            this.dgvDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocs.Location = new System.Drawing.Point(0, 25);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.RowHeadersWidth = 21;
            this.dgvDocs.Size = new System.Drawing.Size(396, 192);
            this.dgvDocs.TabIndex = 3;
            this.dgvDocs.VirtualMode = true;
            this.dgvDocs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocs_CellValueChanged);
            this.dgvDocs.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvDocs_CellValueNeeded);
            // 
            // ColumnImage
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnImage.HeaderText = "";
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnImage.Visible = false;
            this.ColumnImage.Width = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TypeDoc";
            this.dataGridViewTextBoxColumn1.HeaderText = "TypeDoc";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDamageDataGridViewTextBoxColumn
            // 
            this.idDamageDataGridViewTextBoxColumn.DataPropertyName = "idDamage";
            this.idDamageDataGridViewTextBoxColumn.HeaderText = "idDamage";
            this.idDamageDataGridViewTextBoxColumn.Name = "idDamageDataGridViewTextBoxColumn";
            this.idDamageDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentDataGridViewTextBoxColumn
            // 
            this.documentDataGridViewTextBoxColumn.DataPropertyName = "Document";
            this.documentDataGridViewTextBoxColumn.HeaderText = "Document";
            this.documentDataGridViewTextBoxColumn.Name = "documentDataGridViewTextBoxColumn";
            this.documentDataGridViewTextBoxColumn.Visible = false;
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "Приложение";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Наименование приложения";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // PageReestrDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDocs);
            this.Controls.Add(this.toolStripDocuments);
            this.Name = "PageReestrDocs";
            this.Size = new System.Drawing.Size(396, 217);
            this.Load += new System.EventHandler(this.PageReestrDocs_Load);
            this.toolStripDocuments.ResumeLayout(false);
            this.toolStripDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tJ_DamageDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripDocuments;
        private System.Windows.Forms.ToolStripButton toolBtnAddDoc;
        private System.Windows.Forms.ToolStripButton toolBtnDelDoc;
        private System.Windows.Forms.ToolStripButton toolBtnViewDoc;
        private System.Windows.Forms.ToolStripButton toolBtnSaveDoc;
        private System.Data.DataSet dataSetDoc;
        private System.Data.DataTable tJ_DamageDoc;
        private System.Data.DataColumn id;
        private System.Data.DataColumn idDamage;
        private System.Data.DataColumn Document;
        private System.Data.DataColumn FileName;
        private System.Data.DataColumn Comment;
        private System.Windows.Forms.BindingSource bsDoc;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvDocs;
        private System.Data.DataColumn cTypeDoc;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull ColumnImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDamageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}
