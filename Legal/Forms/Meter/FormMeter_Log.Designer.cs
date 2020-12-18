namespace Legal.Forms.Meter
{
    partial class FormMeter_Log
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
            this.dgvLog = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCnt1 = new Legal.DataSet.dsCnt();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueKWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeKWTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCnt1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLog
            // 
            this.dgvLog.AllowUserToAddRows = false;
            this.dgvLog.AllowUserToDeleteRows = false;
            this.dgvLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLog.AutoGenerateColumns = false;
            this.dgvLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.recTypeDataGridViewTextBoxColumn,
            this.datecommandDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.FIO,
            this.valueKWTDataGridViewTextBoxColumn,
            this.sizeKWTDataGridViewTextBoxColumn});
            this.dgvLog.DataSource = this.bindingSource1;
            this.dgvLog.Location = new System.Drawing.Point(1, 0);
            this.dgvLog.Name = "dgvLog";
            this.dgvLog.ReadOnly = true;
            this.dgvLog.RowHeadersWidth = 5;
            this.dgvLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLog.Size = new System.Drawing.Size(612, 377);
            this.dgvLog.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vG_FormMeter_Log";
            this.bindingSource1.DataSource = this.dsCnt1;
            // 
            // dsCnt1
            // 
            this.dsCnt1.DataSetName = "dsCnt";
            this.dsCnt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // recTypeDataGridViewTextBoxColumn
            // 
            this.recTypeDataGridViewTextBoxColumn.DataPropertyName = "RecType";
            this.recTypeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.recTypeDataGridViewTextBoxColumn.Name = "recTypeDataGridViewTextBoxColumn";
            this.recTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datecommandDataGridViewTextBoxColumn
            // 
            this.datecommandDataGridViewTextBoxColumn.DataPropertyName = "datecommand";
            this.datecommandDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.datecommandDataGridViewTextBoxColumn.Name = "datecommandDataGridViewTextBoxColumn";
            this.datecommandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Пользователь";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Visible = false;
            this.usernameDataGridViewTextBoxColumn.Width = 200;
            // 
            // FIO
            // 
            this.FIO.DataPropertyName = "FIO";
            this.FIO.HeaderText = "Специалист";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Width = 200;
            // 
            // valueKWTDataGridViewTextBoxColumn
            // 
            this.valueKWTDataGridViewTextBoxColumn.DataPropertyName = "ValueKWT";
            this.valueKWTDataGridViewTextBoxColumn.HeaderText = "Показание";
            this.valueKWTDataGridViewTextBoxColumn.Name = "valueKWTDataGridViewTextBoxColumn";
            this.valueKWTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeKWTDataGridViewTextBoxColumn
            // 
            this.sizeKWTDataGridViewTextBoxColumn.DataPropertyName = "SizeKWT";
            this.sizeKWTDataGridViewTextBoxColumn.HeaderText = "Расход";
            this.sizeKWTDataGridViewTextBoxColumn.Name = "sizeKWTDataGridViewTextBoxColumn";
            this.sizeKWTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormMeter_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 375);
            this.Controls.Add(this.dgvLog);
            this.Name = "FormMeter_Log";
            this.Text = "Протокол внесения показаний";
            this.Load += new System.EventHandler(this.FormMeter_Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCnt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLog;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataSet.dsCnt dsCnt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecommandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueKWTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeKWTDataGridViewTextBoxColumn;
    }
}