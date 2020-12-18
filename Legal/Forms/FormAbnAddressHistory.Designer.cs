namespace Legal.Forms
{
    partial class FormAbnAddressHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAddressList = new System.Windows.Forms.DataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIdAbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bs1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbnAddressList1 = new Legal.DataSet.dsAbnAddressList();
            this.idStreetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRepresentation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.buttonEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnAddressList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAddressList
            // 
            this.dgvAddressList.AllowUserToAddRows = false;
            this.dgvAddressList.AllowUserToDeleteRows = false;
            this.dgvAddressList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddressList.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddressList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddressList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddressList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvIdAbn,
            this.Column1,
            this.idStreetDataGridViewTextBoxColumn,
            this.dgvRepresentation,
            this.dgvDt});
            this.dgvAddressList.DataSource = this.bs;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddressList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddressList.Location = new System.Drawing.Point(12, 28);
            this.dgvAddressList.MultiSelect = false;
            this.dgvAddressList.Name = "dgvAddressList";
            this.dgvAddressList.ReadOnly = true;
            this.dgvAddressList.RowHeadersWidth = 5;
            this.dgvAddressList.RowTemplate.Height = 24;
            this.dgvAddressList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddressList.Size = new System.Drawing.Size(903, 362);
            this.dgvAddressList.TabIndex = 0;
            this.dgvAddressList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddressList_CellDoubleClick);
            this.dgvAddressList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAddressList_CellFormatting);
            // 
            // dgvId
            // 
            this.dgvId.DataPropertyName = "id";
            this.dgvId.HeaderText = "id";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Visible = false;
            // 
            // dgvIdAbn
            // 
            this.dgvIdAbn.DataPropertyName = "idAbn";
            this.dgvIdAbn.HeaderText = "idAbn";
            this.dgvIdAbn.Name = "dgvIdAbn";
            this.dgvIdAbn.ReadOnly = true;
            this.dgvIdAbn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idTypeAddress";
            this.Column1.DataSource = this.bs1;
            this.Column1.DisplayMember = "Name";
            this.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Column1.HeaderText = "Тип адреса";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.ValueMember = "Id";
            this.Column1.Width = 160;
            // 
            // bs1
            // 
            this.bs1.DataMember = "tR_Classifier";
            this.bs1.DataSource = this.dsAbnAddressList1;
            // 
            // dsAbnAddressList1
            // 
            this.dsAbnAddressList1.DataSetName = "dsAbnAddressList";
            this.dsAbnAddressList1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idStreetDataGridViewTextBoxColumn
            // 
            this.idStreetDataGridViewTextBoxColumn.DataPropertyName = "idStreet";
            this.idStreetDataGridViewTextBoxColumn.HeaderText = "idStreet";
            this.idStreetDataGridViewTextBoxColumn.Name = "idStreetDataGridViewTextBoxColumn";
            this.idStreetDataGridViewTextBoxColumn.ReadOnly = true;
            this.idStreetDataGridViewTextBoxColumn.Visible = false;
            // 
            // dgvRepresentation
            // 
            this.dgvRepresentation.DataPropertyName = "Representation";
            this.dgvRepresentation.HeaderText = "Адрес";
            this.dgvRepresentation.Name = "dgvRepresentation";
            this.dgvRepresentation.ReadOnly = true;
            this.dgvRepresentation.Width = 620;
            // 
            // dgvDt
            // 
            this.dgvDt.DataPropertyName = "DateChange";
            this.dgvDt.HeaderText = "Дата";
            this.dgvDt.Name = "dgvDt";
            this.dgvDt.ReadOnly = true;
            this.dgvDt.Width = 115;
            // 
            // bs
            // 
            this.bs.DataMember = "tG_AbnAddress";
            this.bs.DataSource = this.dsAbnAddressList1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(927, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = global::Legal.Properties.Resources.ElementAdd;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Добавить адрес";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::Legal.Properties.Resources.ElementEdit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "Редактировать адрес";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = global::Legal.Properties.Resources.ElementDel;
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(23, 22);
            this.btnDel.Text = "Удалить адрес";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEnd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonEnd.Location = new System.Drawing.Point(840, 399);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(75, 23);
            this.buttonEnd.TabIndex = 2;
            this.buttonEnd.Text = "Выход";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // FormAbnAddressHistory
            // 
            this.ClientSize = new System.Drawing.Size(927, 434);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvAddressList);
            this.Name = "FormAbnAddressHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Адреса потребителя";
            this.Load += new System.EventHandler(this.FormAbnAddressHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddressList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnAddressList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddressList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private Legal.DataSet.dsAbnAddressList dsAbnAddressList1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingSource bs1;
        private System.Windows.Forms.Button buttonEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIdAbn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStreetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRepresentation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDt;
    }
}
