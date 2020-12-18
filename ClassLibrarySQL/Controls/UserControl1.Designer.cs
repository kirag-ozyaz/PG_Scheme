namespace Library
{
    partial class UserControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolBtnAddDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDelDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnViewDoc = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSaveDoc = new System.Windows.Forms.ToolStripButton();
            this.toolStripDocuments = new System.Windows.Forms.ToolStrip();
            this.ColumnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
            this.dgvDocs = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.toolStripDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBtnAddDoc
            // 
            this.toolBtnAddDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAddDoc.Image = global::Library.Properties.Resources.Add;
            this.toolBtnAddDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAddDoc.Name = "toolBtnAddDoc";
            this.toolBtnAddDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnAddDoc.Text = "Добавить документ";
            // 
            // toolBtnDelDoc
            // 
            this.toolBtnDelDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDelDoc.Image = global::Library.Properties.Resources.Delete;
            this.toolBtnDelDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnDelDoc.Name = "toolBtnDelDoc";
            this.toolBtnDelDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnDelDoc.Text = "Удалить документ";
            // 
            // toolBtnViewDoc
            // 
            this.toolBtnViewDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnViewDoc.Image = global::Library.Properties.Resources.Information;
            this.toolBtnViewDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnViewDoc.Name = "toolBtnViewDoc";
            this.toolBtnViewDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnViewDoc.Text = "Открыть документ";
            // 
            // toolBtnSaveDoc
            // 
            this.toolBtnSaveDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSaveDoc.Image = global::Library.Properties.Resources.Export;
            this.toolBtnSaveDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSaveDoc.Name = "toolBtnSaveDoc";
            this.toolBtnSaveDoc.Size = new System.Drawing.Size(23, 22);
            this.toolBtnSaveDoc.Text = "Сохранить документ";
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
            this.toolStripDocuments.Size = new System.Drawing.Size(360, 25);
            this.toolStripDocuments.TabIndex = 3;
            this.toolStripDocuments.Text = "toolStrip1";
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
            // dgvDocs
            // 
            this.dgvDocs.AllowUserToAddRows = false;
            this.dgvDocs.AllowUserToDeleteRows = false;
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnImage});
            this.dgvDocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocs.Location = new System.Drawing.Point(0, 25);
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.RowHeadersWidth = 21;
            this.dgvDocs.Size = new System.Drawing.Size(360, 198);
            this.dgvDocs.TabIndex = 4;
            this.dgvDocs.VirtualMode = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDocs);
            this.Controls.Add(this.toolStripDocuments);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(360, 223);
            this.toolStripDocuments.ResumeLayout(false);
            this.toolStripDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton toolBtnAddDoc;
        private System.Windows.Forms.ToolStripButton toolBtnDelDoc;
        private System.Windows.Forms.ToolStripButton toolBtnViewDoc;
        private System.Windows.Forms.ToolStripButton toolBtnSaveDoc;
        private System.Windows.Forms.ToolStrip toolStripDocuments;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull ColumnImage;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dgvDocs;
    }
}
