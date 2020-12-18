namespace Documents.Forms.JournalRequest
{
    partial class FormAddEditRequest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsGES = new Documents.DataSets.DataSetGES();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxModul = new System.Windows.Forms.ComboBox();
            this.dsRef = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxTextTask = new System.Windows.Forms.RichTextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxWhom = new System.Windows.Forms.ComboBox();
            this.dgvDocs = new System.Windows.Forms.DataGridView();
            this.idDgvTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.fileNameDgvTxtColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImage = new ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull();
            this.shortFileNameDgvTxtColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolBtnDel = new System.Windows.Forms.ToolStripButton();
            this.contextMenuDgvDoc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuDel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dsGES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.contextMenuDgvDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsGES
            // 
            this.dsGES.DataSetName = "DataSetGES";
            this.dsGES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ задачи";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGES, "tJ_Request.id", true));
            this.textBoxId.Location = new System.Drawing.Point(74, 7);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(113, 20);
            this.textBoxId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модуль";
            // 
            // comboBoxModul
            // 
            this.comboBoxModul.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsGES, "tJ_Request.Modul", true));
            this.comboBoxModul.DataSource = this.dsRef;
            this.comboBoxModul.DisplayMember = "tR_Classifier.Name";
            this.comboBoxModul.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModul.FormattingEnabled = true;
            this.comboBoxModul.Location = new System.Drawing.Point(240, 6);
            this.comboBoxModul.Name = "comboBoxModul";
            this.comboBoxModul.Size = new System.Drawing.Size(156, 21);
            this.comboBoxModul.TabIndex = 3;
            this.comboBoxModul.ValueMember = "tR_Classifier.Id";
            // 
            // dsRef
            // 
            this.dsRef.DataSetName = "NewDataSet";
            this.dsRef.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable1.TableName = "tUser";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "idUser";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Name";
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.dataTable2.TableName = "tR_Classifier";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Id";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Name";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "ParentKey";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Текст Задачи";
            // 
            // richTextBoxTextTask
            // 
            this.richTextBoxTextTask.AcceptsTab = true;
            this.richTextBoxTextTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTextTask.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsGES, "tJ_Request.TextTask", true));
            this.richTextBoxTextTask.Location = new System.Drawing.Point(15, 85);
            this.richTextBoxTextTask.Name = "richTextBoxTextTask";
            this.richTextBoxTextTask.Size = new System.Drawing.Size(381, 95);
            this.richTextBoxTextTask.TabIndex = 5;
            this.richTextBoxTextTask.Text = "";
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(15, 309);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(321, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Кому";
            // 
            // comboBoxWhom
            // 
            this.comboBoxWhom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxWhom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxWhom.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsGES, "tJ_Request.idUserWhom", true));
            this.comboBoxWhom.DataSource = this.dsRef;
            this.comboBoxWhom.DisplayMember = "tUser.Name";
            this.comboBoxWhom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWhom.FormattingEnabled = true;
            this.comboBoxWhom.Location = new System.Drawing.Point(53, 40);
            this.comboBoxWhom.Name = "comboBoxWhom";
            this.comboBoxWhom.Size = new System.Drawing.Size(343, 21);
            this.comboBoxWhom.TabIndex = 13;
            this.comboBoxWhom.ValueMember = "tUser.idUser";
            // 
            // dgvDocs
            // 
            this.dgvDocs.AllowUserToAddRows = false;
            this.dgvDocs.AllowUserToDeleteRows = false;
            this.dgvDocs.AllowUserToResizeColumns = false;
            this.dgvDocs.AllowUserToResizeRows = false;
            this.dgvDocs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDocs.AutoGenerateColumns = false;
            this.dgvDocs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDocs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocs.ColumnHeadersVisible = false;
            this.dgvDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDgvTxtColumn,
            this.idRequestDataGridViewTextBoxColumn,
            this.documentDataGridViewImageColumn,
            this.fileNameDgvTxtColumn,
            this.ColumnImage,
            this.shortFileNameDgvTxtColumn});
            this.dgvDocs.DataMember = "tJ_RequestDoc";
            this.dgvDocs.DataSource = this.dsGES;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocs.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDocs.Location = new System.Drawing.Point(42, 183);
            this.dgvDocs.MultiSelect = false;
            this.dgvDocs.Name = "dgvDocs";
            this.dgvDocs.ReadOnly = true;
            this.dgvDocs.RowHeadersVisible = false;
            this.dgvDocs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocs.Size = new System.Drawing.Size(354, 101);
            this.dgvDocs.TabIndex = 14;
            this.dgvDocs.VirtualMode = true;
            this.dgvDocs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocs_CellContentClick);
            this.dgvDocs.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDocs_CellMouseClick);
            this.dgvDocs.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgvDocs_CellValueNeeded);
            // 
            // idDgvTxtColumn
            // 
            this.idDgvTxtColumn.DataPropertyName = "id";
            this.idDgvTxtColumn.HeaderText = "id";
            this.idDgvTxtColumn.Name = "idDgvTxtColumn";
            this.idDgvTxtColumn.ReadOnly = true;
            this.idDgvTxtColumn.Visible = false;
            // 
            // idRequestDataGridViewTextBoxColumn
            // 
            this.idRequestDataGridViewTextBoxColumn.DataPropertyName = "idRequest";
            this.idRequestDataGridViewTextBoxColumn.HeaderText = "idRequest";
            this.idRequestDataGridViewTextBoxColumn.Name = "idRequestDataGridViewTextBoxColumn";
            this.idRequestDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRequestDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentDataGridViewImageColumn
            // 
            this.documentDataGridViewImageColumn.DataPropertyName = "Document";
            this.documentDataGridViewImageColumn.HeaderText = "Document";
            this.documentDataGridViewImageColumn.Name = "documentDataGridViewImageColumn";
            this.documentDataGridViewImageColumn.ReadOnly = true;
            this.documentDataGridViewImageColumn.Visible = false;
            // 
            // fileNameDgvTxtColumn
            // 
            this.fileNameDgvTxtColumn.DataPropertyName = "FileName";
            this.fileNameDgvTxtColumn.HeaderText = "FileName";
            this.fileNameDgvTxtColumn.Name = "fileNameDgvTxtColumn";
            this.fileNameDgvTxtColumn.ReadOnly = true;
            this.fileNameDgvTxtColumn.Visible = false;
            // 
            // ColumnImage
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.ColumnImage.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnImage.HeaderText = "";
            this.ColumnImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Width = 30;
            // 
            // shortFileNameDgvTxtColumn
            // 
            this.shortFileNameDgvTxtColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shortFileNameDgvTxtColumn.HeaderText = "Файл";
            this.shortFileNameDgvTxtColumn.Name = "shortFileNameDgvTxtColumn";
            this.shortFileNameDgvTxtColumn.ReadOnly = true;
            this.shortFileNameDgvTxtColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shortFileNameDgvTxtColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // toolStrip
            // 
            this.toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnAdd,
            this.toolBtnDel});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(15, 183);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(24, 48);
            this.toolStrip.TabIndex = 15;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolBtnAdd
            // 
            this.toolBtnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnAdd.Image = global::Documents.Properties.Resources.ElementAdd;
            this.toolBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnAdd.Name = "toolBtnAdd";
            this.toolBtnAdd.Size = new System.Drawing.Size(22, 20);
            this.toolBtnAdd.Text = "Добавить файл";
            this.toolBtnAdd.Click += new System.EventHandler(this.toolBtnAdd_Click);
            // 
            // toolBtnDel
            // 
            this.toolBtnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnDel.Image = global::Documents.Properties.Resources.ElementDel;
            this.toolBtnDel.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.toolBtnDel.Name = "toolBtnDel";
            this.toolBtnDel.Size = new System.Drawing.Size(22, 20);
            this.toolBtnDel.Text = "Удалить";
            this.toolBtnDel.Click += new System.EventHandler(this.toolBtnDel_Click);
            // 
            // contextMenuDgvDoc
            // 
            this.contextMenuDgvDoc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuOpen,
            this.toolMenuSave,
            this.toolMenuDel});
            this.contextMenuDgvDoc.Name = "contextMenuDgvDoc";
            this.contextMenuDgvDoc.Size = new System.Drawing.Size(133, 70);
            // 
            // toolMenuOpen
            // 
            this.toolMenuOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolMenuOpen.Name = "toolMenuOpen";
            this.toolMenuOpen.Size = new System.Drawing.Size(132, 22);
            this.toolMenuOpen.Text = "Открыть";
            this.toolMenuOpen.Click += new System.EventHandler(this.toolMenuOpen_Click);
            // 
            // toolMenuSave
            // 
            this.toolMenuSave.Image = global::Documents.Properties.Resources.save;
            this.toolMenuSave.Name = "toolMenuSave";
            this.toolMenuSave.Size = new System.Drawing.Size(132, 22);
            this.toolMenuSave.Text = "Сохранить";
            this.toolMenuSave.Click += new System.EventHandler(this.toolMenuSave_Click);
            // 
            // toolMenuDel
            // 
            this.toolMenuDel.Image = global::Documents.Properties.Resources.ElementDel;
            this.toolMenuDel.Name = "toolMenuDel";
            this.toolMenuDel.Size = new System.Drawing.Size(132, 22);
            this.toolMenuDel.Text = "Удалить";
            this.toolMenuDel.Click += new System.EventHandler(this.toolMenuDel_Click);
            // 
            // FormAddEditRequest
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(405, 344);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dgvDocs);
            this.Controls.Add(this.comboBoxWhom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.richTextBoxTextTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxModul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEditRequest";
            this.Text = "j";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddEditRequest_FormClosing);
            this.Load += new System.EventHandler(this.FormAddEditRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsGES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocs)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.contextMenuDgvDoc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSets.DataSetGES dsGES;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxModul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxTextTask;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxWhom;
        private System.Data.DataSet dsRef;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.DataGridView dgvDocs;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolBtnAdd;
        private System.Windows.Forms.ToolStripButton toolBtnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDgvTxtColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn documentDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDgvTxtColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewImageColumnNotNull ColumnImage;
        private System.Windows.Forms.DataGridViewLinkColumn shortFileNameDgvTxtColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuDgvDoc;
        private System.Windows.Forms.ToolStripMenuItem toolMenuOpen;
        private System.Windows.Forms.ToolStripMenuItem toolMenuSave;
        private System.Windows.Forms.ToolStripMenuItem toolMenuDel;
    }
}