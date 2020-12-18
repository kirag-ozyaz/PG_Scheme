namespace Legal.Forms.Meter
{
    partial class FormMeterParameters_Log
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
            this.dgvMeterParameters = new System.Windows.Forms.DataGridView();
            this.idPointRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datecommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerBeginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerEndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tRKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCnt1 = new Legal.DataSet.dsCnt();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeterParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCnt1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeterParameters
            // 
            this.dgvMeterParameters.AllowUserToAddRows = false;
            this.dgvMeterParameters.AllowUserToDeleteRows = false;
            this.dgvMeterParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMeterParameters.AutoGenerateColumns = false;
            this.dgvMeterParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeterParameters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPointRegDataGridViewTextBoxColumn,
            this.recTypeDataGridViewTextBoxColumn,
            this.datecommandDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.dateBeginDataGridViewTextBoxColumn,
            this.dateEndDataGridViewTextBoxColumn,
            this.workerBeginDataGridViewTextBoxColumn,
            this.workerEndDataGridViewTextBoxColumn,
            this.meterDataGridViewTextBoxColumn,
            this.markMeterDataGridViewTextBoxColumn,
            this.tRKDataGridViewTextBoxColumn,
            this.zoneDataGridViewTextBoxColumn});
            this.dgvMeterParameters.DataSource = this.bindingSource1;
            this.dgvMeterParameters.Location = new System.Drawing.Point(0, -1);
            this.dgvMeterParameters.Name = "dgvMeterParameters";
            this.dgvMeterParameters.ReadOnly = true;
            this.dgvMeterParameters.RowHeadersWidth = 5;
            this.dgvMeterParameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMeterParameters.Size = new System.Drawing.Size(735, 394);
            this.dgvMeterParameters.TabIndex = 0;
            // 
            // idPointRegDataGridViewTextBoxColumn
            // 
            this.idPointRegDataGridViewTextBoxColumn.DataPropertyName = "idPointReg";
            this.idPointRegDataGridViewTextBoxColumn.HeaderText = "idPointReg";
            this.idPointRegDataGridViewTextBoxColumn.Name = "idPointRegDataGridViewTextBoxColumn";
            this.idPointRegDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointRegDataGridViewTextBoxColumn.Visible = false;
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
            // 
            // dateBeginDataGridViewTextBoxColumn
            // 
            this.dateBeginDataGridViewTextBoxColumn.DataPropertyName = "DateBegin";
            this.dateBeginDataGridViewTextBoxColumn.HeaderText = "Установка";
            this.dateBeginDataGridViewTextBoxColumn.Name = "dateBeginDataGridViewTextBoxColumn";
            this.dateBeginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEndDataGridViewTextBoxColumn
            // 
            this.dateEndDataGridViewTextBoxColumn.DataPropertyName = "DateEnd";
            this.dateEndDataGridViewTextBoxColumn.HeaderText = "Демонтаж";
            this.dateEndDataGridViewTextBoxColumn.Name = "dateEndDataGridViewTextBoxColumn";
            this.dateEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workerBeginDataGridViewTextBoxColumn
            // 
            this.workerBeginDataGridViewTextBoxColumn.DataPropertyName = "WorkerBegin";
            this.workerBeginDataGridViewTextBoxColumn.HeaderText = "Мастер установки";
            this.workerBeginDataGridViewTextBoxColumn.Name = "workerBeginDataGridViewTextBoxColumn";
            this.workerBeginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workerEndDataGridViewTextBoxColumn
            // 
            this.workerEndDataGridViewTextBoxColumn.DataPropertyName = "WorkerEnd";
            this.workerEndDataGridViewTextBoxColumn.HeaderText = "Мастер демонтажа";
            this.workerEndDataGridViewTextBoxColumn.Name = "workerEndDataGridViewTextBoxColumn";
            this.workerEndDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meterDataGridViewTextBoxColumn
            // 
            this.meterDataGridViewTextBoxColumn.DataPropertyName = "Meter";
            this.meterDataGridViewTextBoxColumn.HeaderText = "Номер прибора";
            this.meterDataGridViewTextBoxColumn.Name = "meterDataGridViewTextBoxColumn";
            this.meterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markMeterDataGridViewTextBoxColumn
            // 
            this.markMeterDataGridViewTextBoxColumn.DataPropertyName = "MarkMeter";
            this.markMeterDataGridViewTextBoxColumn.HeaderText = "Тип прибора";
            this.markMeterDataGridViewTextBoxColumn.Name = "markMeterDataGridViewTextBoxColumn";
            this.markMeterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tRKDataGridViewTextBoxColumn
            // 
            this.tRKDataGridViewTextBoxColumn.DataPropertyName = "TR_K";
            this.tRKDataGridViewTextBoxColumn.HeaderText = "Коэффициент";
            this.tRKDataGridViewTextBoxColumn.Name = "tRKDataGridViewTextBoxColumn";
            this.tRKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zoneDataGridViewTextBoxColumn
            // 
            this.zoneDataGridViewTextBoxColumn.DataPropertyName = "Zone";
            this.zoneDataGridViewTextBoxColumn.HeaderText = "Зонность";
            this.zoneDataGridViewTextBoxColumn.Name = "zoneDataGridViewTextBoxColumn";
            this.zoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vG_PointParameters_Log";
            this.bindingSource1.DataSource = this.dsCnt1;
            // 
            // dsCnt1
            // 
            this.dsCnt1.DataSetName = "dsCnt";
            this.dsCnt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormMeterParameters_Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 393);
            this.Controls.Add(this.dgvMeterParameters);
            this.Name = "FormMeterParameters_Log";
            this.Text = "Протокол изменений параметров приборов учета";
            this.Load += new System.EventHandler(this.FormMeterParameters_Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeterParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCnt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeterParameters;
        private DataSet.dsCnt dsCnt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actUstanovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actDemontagDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datecommandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerBeginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerEndDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tRKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneDataGridViewTextBoxColumn;
    }
}