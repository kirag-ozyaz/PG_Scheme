namespace Legal.Forms
{
    partial class FormAbnStatusHistory
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
            this.dataGridViewAbnStatusHistory = new System.Windows.Forms.DataGridView();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateChangeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dsAbnStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbnStatus = new Legal.DataSet.dsAbnStatus();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbnStatusHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAbnStatusHistory
            // 
            this.dataGridViewAbnStatusHistory.AllowUserToAddRows = false;
            this.dataGridViewAbnStatusHistory.AllowUserToDeleteRows = false;
            this.dataGridViewAbnStatusHistory.AutoGenerateColumns = false;
            this.dataGridViewAbnStatusHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAbnStatusHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbnStatusHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.idAbnDataGridViewTextBoxColumn,
            this.dateChangeDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.Reason});
            this.dataGridViewAbnStatusHistory.DataMember = "vG_AbnStatusReason";
            this.dataGridViewAbnStatusHistory.DataSource = this.dsAbnStatusBindingSource;
            this.dataGridViewAbnStatusHistory.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAbnStatusHistory.MultiSelect = false;
            this.dataGridViewAbnStatusHistory.Name = "dataGridViewAbnStatusHistory";
            this.dataGridViewAbnStatusHistory.RowTemplate.Height = 24;
            this.dataGridViewAbnStatusHistory.Size = new System.Drawing.Size(644, 217);
            this.dataGridViewAbnStatusHistory.TabIndex = 0;
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Name";
            this.Reason.HeaderText = "Причина смены";
            this.Reason.Name = "Reason";
            this.Reason.Width = 400;
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
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateChangeDataGridViewTextBoxColumn
            // 
            this.dateChangeDataGridViewTextBoxColumn.DataPropertyName = "DateChange";
            this.dateChangeDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateChangeDataGridViewTextBoxColumn.Name = "dateChangeDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "Статус";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dsAbnStatusBindingSource
            // 
            this.dsAbnStatusBindingSource.DataSource = this.dsAbnStatus;
            this.dsAbnStatusBindingSource.Position = 0;
            // 
            // dsAbnStatus
            // 
            this.dsAbnStatus.DataSetName = "dsAbnStatus";
            this.dsAbnStatus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormAbnStatusHistory
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(668, 241);
            this.Controls.Add(this.dataGridViewAbnStatusHistory);
            this.Name = "FormAbnStatusHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "История статуса абонента";
            this.Load += new System.EventHandler(this.FormAbnStatusHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbnStatusHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAbnStatusHistory;
        private System.Windows.Forms.BindingSource dsAbnStatusBindingSource;
        private Legal.DataSet.dsAbnStatus dsAbnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateChangeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
    }
}
