namespace Legal.Forms
{
    partial class FormAbnDetailsHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameShortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameFullDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kPPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oKVEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oKPODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankDestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAcntDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankPayerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankPayeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsAbnDetails1 = new Legal.DataSet.dsAbnDetails();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDetails1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAbnDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.nameShortDataGridViewTextBoxColumn,
            this.nameFullDataGridViewTextBoxColumn,
            this.iNNDataGridViewTextBoxColumn,
            this.kPPDataGridViewTextBoxColumn,
            this.oKVEDDataGridViewTextBoxColumn,
            this.oKPODataGridViewTextBoxColumn,
            this.bankIDDataGridViewTextBoxColumn,
            this.bankDestDataGridViewTextBoxColumn,
            this.bankAcntDataGridViewTextBoxColumn,
            this.dateChangeDataGridViewTextBoxColumn,
            this.bankPayerDataGridViewTextBoxColumn,
            this.bankPayeeDataGridViewTextBoxColumn});
            this.dataGridView1.DataMember = "vG_AbnDetailsHistory";
            this.dataGridView1.DataSource = this.dsAbnDetails1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 5;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(960, 554);
            this.dataGridView1.TabIndex = 0;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameShortDataGridViewTextBoxColumn
            // 
            this.nameShortDataGridViewTextBoxColumn.DataPropertyName = "NameShort";
            this.nameShortDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameShortDataGridViewTextBoxColumn.Name = "nameShortDataGridViewTextBoxColumn";
            this.nameShortDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameShortDataGridViewTextBoxColumn.Width = 200;
            // 
            // nameFullDataGridViewTextBoxColumn
            // 
            this.nameFullDataGridViewTextBoxColumn.DataPropertyName = "NameFull";
            this.nameFullDataGridViewTextBoxColumn.HeaderText = "Полное имя";
            this.nameFullDataGridViewTextBoxColumn.Name = "nameFullDataGridViewTextBoxColumn";
            this.nameFullDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameFullDataGridViewTextBoxColumn.Width = 300;
            // 
            // iNNDataGridViewTextBoxColumn
            // 
            this.iNNDataGridViewTextBoxColumn.DataPropertyName = "INN";
            this.iNNDataGridViewTextBoxColumn.HeaderText = "ИНН";
            this.iNNDataGridViewTextBoxColumn.Name = "iNNDataGridViewTextBoxColumn";
            this.iNNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kPPDataGridViewTextBoxColumn
            // 
            this.kPPDataGridViewTextBoxColumn.DataPropertyName = "KPP";
            this.kPPDataGridViewTextBoxColumn.HeaderText = "КПП";
            this.kPPDataGridViewTextBoxColumn.Name = "kPPDataGridViewTextBoxColumn";
            this.kPPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oKVEDDataGridViewTextBoxColumn
            // 
            this.oKVEDDataGridViewTextBoxColumn.DataPropertyName = "OKVED";
            this.oKVEDDataGridViewTextBoxColumn.HeaderText = "ОКВЭД";
            this.oKVEDDataGridViewTextBoxColumn.Name = "oKVEDDataGridViewTextBoxColumn";
            this.oKVEDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oKPODataGridViewTextBoxColumn
            // 
            this.oKPODataGridViewTextBoxColumn.DataPropertyName = "OKPO";
            this.oKPODataGridViewTextBoxColumn.HeaderText = "ОКПО";
            this.oKPODataGridViewTextBoxColumn.Name = "oKPODataGridViewTextBoxColumn";
            this.oKPODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankIDDataGridViewTextBoxColumn
            // 
            this.bankIDDataGridViewTextBoxColumn.DataPropertyName = "BankID";
            this.bankIDDataGridViewTextBoxColumn.HeaderText = "BankID";
            this.bankIDDataGridViewTextBoxColumn.Name = "bankIDDataGridViewTextBoxColumn";
            this.bankIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bankDestDataGridViewTextBoxColumn
            // 
            this.bankDestDataGridViewTextBoxColumn.DataPropertyName = "BankDest";
            this.bankDestDataGridViewTextBoxColumn.HeaderText = "BankDest";
            this.bankDestDataGridViewTextBoxColumn.Name = "bankDestDataGridViewTextBoxColumn";
            this.bankDestDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankDestDataGridViewTextBoxColumn.Visible = false;
            // 
            // bankAcntDataGridViewTextBoxColumn
            // 
            this.bankAcntDataGridViewTextBoxColumn.DataPropertyName = "BankAcnt";
            this.bankAcntDataGridViewTextBoxColumn.HeaderText = "Расчетный счет";
            this.bankAcntDataGridViewTextBoxColumn.Name = "bankAcntDataGridViewTextBoxColumn";
            this.bankAcntDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateChangeDataGridViewTextBoxColumn
            // 
            this.dateChangeDataGridViewTextBoxColumn.DataPropertyName = "DateChange";
            this.dateChangeDataGridViewTextBoxColumn.HeaderText = "Дата изменения";
            this.dateChangeDataGridViewTextBoxColumn.Name = "dateChangeDataGridViewTextBoxColumn";
            this.dateChangeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankPayerDataGridViewTextBoxColumn
            // 
            this.bankPayerDataGridViewTextBoxColumn.DataPropertyName = "BankPayer";
            this.bankPayerDataGridViewTextBoxColumn.HeaderText = "Банк плательщика";
            this.bankPayerDataGridViewTextBoxColumn.Name = "bankPayerDataGridViewTextBoxColumn";
            this.bankPayerDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankPayerDataGridViewTextBoxColumn.Width = 200;
            // 
            // bankPayeeDataGridViewTextBoxColumn
            // 
            this.bankPayeeDataGridViewTextBoxColumn.DataPropertyName = "BankPayee";
            this.bankPayeeDataGridViewTextBoxColumn.HeaderText = "Банк получателя";
            this.bankPayeeDataGridViewTextBoxColumn.Name = "bankPayeeDataGridViewTextBoxColumn";
            this.bankPayeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankPayeeDataGridViewTextBoxColumn.Width = 200;
            // 
            // dsAbnDetails1
            // 
            this.dsAbnDetails1.DataSetName = "dsAbnDetails";
            this.dsAbnDetails1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOK.Location = new System.Drawing.Point(897, 577);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "Выход";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormAbnDetailsHistory
            // 
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormAbnDetailsHistory";
            this.Text = "История реквизитов контрагента";
            this.Load += new System.EventHandler(this.FormAbnDetailsHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDetails1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Legal.DataSet.dsAbnDetails dsAbnDetails1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameShortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameFullDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kPPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oKVEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oKPODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankDestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAcntDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateChangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankPayerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankPayeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonOK;
    }
}
