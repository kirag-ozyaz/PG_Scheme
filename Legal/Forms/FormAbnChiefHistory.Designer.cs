namespace Legal.Forms
{
    partial class FormAbnChiefHistory
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
            this.dataGridViewAbnChiefHistory = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.I_Post = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsAbnChiefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbnChief = new Legal.DataSet.dsAbnChief();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbnChiefHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnChiefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnChief)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAbnChiefHistory
            // 
            this.dataGridViewAbnChiefHistory.AllowUserToAddRows = false;
            this.dataGridViewAbnChiefHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewAbnChiefHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAbnChiefHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAbnChiefHistory.AutoGenerateColumns = false;
            this.dataGridViewAbnChiefHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbnChiefHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idAbnDataGridViewTextBoxColumn,
            this.dateChangeDataGridViewTextBoxColumn,
            this.I_Post,
            this.iFDataGridViewTextBoxColumn,
            this.iIDataGridViewTextBoxColumn,
            this.iODataGridViewTextBoxColumn});
            this.dataGridViewAbnChiefHistory.DataSource = this.dsAbnChiefBindingSource;
            this.dataGridViewAbnChiefHistory.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAbnChiefHistory.Name = "dataGridViewAbnChiefHistory";
            this.dataGridViewAbnChiefHistory.ReadOnly = true;
            this.dataGridViewAbnChiefHistory.RowHeadersWidth = 5;
            this.dataGridViewAbnChiefHistory.RowTemplate.Height = 24;
            this.dataGridViewAbnChiefHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAbnChiefHistory.Size = new System.Drawing.Size(960, 561);
            this.dataGridViewAbnChiefHistory.TabIndex = 0;
            this.dataGridViewAbnChiefHistory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAbnChiefHistory_CellContentClick);
            this.dataGridViewAbnChiefHistory.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewAbnChiefHistory_CellMouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateChangeDataGridViewTextBoxColumn
            // 
            this.dateChangeDataGridViewTextBoxColumn.DataPropertyName = "DateChange";
            this.dateChangeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateChangeDataGridViewTextBoxColumn.Name = "dateChangeDataGridViewTextBoxColumn";
            this.dateChangeDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateChangeDataGridViewTextBoxColumn.Width = 65;
            // 
            // I_Post
            // 
            this.I_Post.DataPropertyName = "I_Post";
            this.I_Post.HeaderText = "Должность";
            this.I_Post.Name = "I_Post";
            this.I_Post.ReadOnly = true;
            this.I_Post.Width = 353;
            // 
            // iFDataGridViewTextBoxColumn
            // 
            this.iFDataGridViewTextBoxColumn.DataPropertyName = "I_F";
            this.iFDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.iFDataGridViewTextBoxColumn.Name = "iFDataGridViewTextBoxColumn";
            this.iFDataGridViewTextBoxColumn.ReadOnly = true;
            this.iFDataGridViewTextBoxColumn.Width = 200;
            // 
            // iIDataGridViewTextBoxColumn
            // 
            this.iIDataGridViewTextBoxColumn.DataPropertyName = "I_I";
            this.iIDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.iIDataGridViewTextBoxColumn.Name = "iIDataGridViewTextBoxColumn";
            this.iIDataGridViewTextBoxColumn.ReadOnly = true;
            this.iIDataGridViewTextBoxColumn.Width = 170;
            // 
            // iODataGridViewTextBoxColumn
            // 
            this.iODataGridViewTextBoxColumn.DataPropertyName = "I_O";
            this.iODataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.iODataGridViewTextBoxColumn.Name = "iODataGridViewTextBoxColumn";
            this.iODataGridViewTextBoxColumn.ReadOnly = true;
            this.iODataGridViewTextBoxColumn.Width = 170;
            // 
            // dsAbnChiefBindingSource
            // 
            this.dsAbnChiefBindingSource.DataMember = "tG_AbnChief";
            this.dsAbnChiefBindingSource.DataSource = this.dsAbnChief;
            // 
            // dsAbnChief
            // 
            this.dsAbnChief.DataSetName = "dsAbnChief";
            this.dsAbnChief.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(897, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAbnChiefHistory
            // 
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewAbnChiefHistory);
            this.Name = "FormAbnChiefHistory";
            this.Text = "История изменений";
            this.Load += new System.EventHandler(this.FormAbnChiefHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbnChiefHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnChiefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnChief)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAbnChiefHistory;
        private System.Windows.Forms.BindingSource dsAbnChiefBindingSource;
        private Legal.DataSet.dsAbnChief dsAbnChief;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateChangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn I_Post;
        private System.Windows.Forms.DataGridViewTextBoxColumn iFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iODataGridViewTextBoxColumn;
    }
}
