namespace Legal.Forms
{
    partial class FormAbnDocum
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
            this.dataGridViewDocList = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentKeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsAbnDocumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbnDocum = new Legal.DataSet.dsAbnDocum();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.договорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDocList
            // 
            this.dataGridViewDocList.AllowUserToAddRows = false;
            this.dataGridViewDocList.AllowUserToDeleteRows = false;
            this.dataGridViewDocList.AutoGenerateColumns = false;
            this.dataGridViewDocList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.AbnID,
            this.docNumberDataGridViewTextBoxColumn,
            this.docDateDataGridViewTextBoxColumn,
            this.idDocType,
            this.nameDataGridViewTextBoxColumn,
            this.parentKeyDataGridViewTextBoxColumn});
            this.dataGridViewDocList.DataMember = "vAbnDoc_List";
            this.dataGridViewDocList.DataSource = this.dsAbnDocumBindingSource;
            this.dataGridViewDocList.Location = new System.Drawing.Point(10, 28);
            this.dataGridViewDocList.Name = "dataGridViewDocList";
            this.dataGridViewDocList.ReadOnly = true;
            this.dataGridViewDocList.RowTemplate.Height = 24;
            this.dataGridViewDocList.Size = new System.Drawing.Size(970, 620);
            this.dataGridViewDocList.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 200;
            // 
            // AbnID
            // 
            this.AbnID.DataPropertyName = "idAbn";
            this.AbnID.HeaderText = "idAbn";
            this.AbnID.Name = "AbnID";
            this.AbnID.ReadOnly = true;
            this.AbnID.Visible = false;
            // 
            // docNumberDataGridViewTextBoxColumn
            // 
            this.docNumberDataGridViewTextBoxColumn.DataPropertyName = "DocNumber";
            this.docNumberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.docNumberDataGridViewTextBoxColumn.Name = "docNumberDataGridViewTextBoxColumn";
            this.docNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.docNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // docDateDataGridViewTextBoxColumn
            // 
            this.docDateDataGridViewTextBoxColumn.DataPropertyName = "DocDate";
            this.docDateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.docDateDataGridViewTextBoxColumn.Name = "docDateDataGridViewTextBoxColumn";
            this.docDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.docDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // idDocType
            // 
            this.idDocType.DataPropertyName = "idDocType";
            this.idDocType.HeaderText = "idDocType";
            this.idDocType.Name = "idDocType";
            this.idDocType.ReadOnly = true;
            this.idDocType.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Тип документа";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 550;
            // 
            // parentKeyDataGridViewTextBoxColumn
            // 
            this.parentKeyDataGridViewTextBoxColumn.DataPropertyName = "ParentKey";
            this.parentKeyDataGridViewTextBoxColumn.HeaderText = "ParentKey";
            this.parentKeyDataGridViewTextBoxColumn.Name = "parentKeyDataGridViewTextBoxColumn";
            this.parentKeyDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentKeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // dsAbnDocumBindingSource
            // 
            this.dsAbnDocumBindingSource.DataSource = this.dsAbnDocum;
            this.dsAbnDocumBindingSource.Position = 0;
            // 
            // dsAbnDocum
            // 
            this.dsAbnDocum.DataSetName = "dsAbnDocum";
            this.dsAbnDocum.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(992, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.договорToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::Legal.Properties.Resources.ElementAdd;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButton1.Text = "Новый документ";
            // 
            // договорToolStripMenuItem
            // 
            this.договорToolStripMenuItem.Name = "договорToolStripMenuItem";
            this.договорToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.договорToolStripMenuItem.Text = "Договор передачи";
            this.договорToolStripMenuItem.Click += new System.EventHandler(this.договорToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Legal.Properties.Resources.ElementEdit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Редактировать документ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Legal.Properties.Resources.ElementDel;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить документ";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // FormAbnDocum
            // 
            this.ClientSize = new System.Drawing.Size(992, 660);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewDocList);
            this.Name = "FormAbnDocum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Документы контрагента";
            this.Load += new System.EventHandler(this.FormAbnDocum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDocList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource dsAbnDocumBindingSource;
        private Legal.DataSet.dsAbnDocum dsAbnDocum;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem договорToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn AbnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentKeyDataGridViewTextBoxColumn;
    }
}
