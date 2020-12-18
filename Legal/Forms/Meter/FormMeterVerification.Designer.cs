namespace Legal.Forms.Meter
{
    partial class FormMeterVerification
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.dsCnt1 = new Legal.DataSet.dsCnt();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameShortDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.representationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.metNumberDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.metDateCheckDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.trNumberDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.trDateCheckDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCnt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(987, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AutoGenerateColumns = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.nameShortDataGridViewTextBoxColumn,
            this.representationDataGridViewTextBoxColumn,
            this.dPostDataGridViewTextBoxColumn,
            this.dFDataGridViewTextBoxColumn,
            this.dIDataGridViewTextBoxColumn,
            this.dODataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.idWorkerDataGridViewTextBoxColumn,
            this.fDataGridViewTextBoxColumn,
            this.metNumberDataGridViewTextBoxColumn,
            this.metDateCheckDataGridViewTextBoxColumn,
            this.trNumberDataGridViewTextBoxColumn,
            this.trDateCheckDataGridViewTextBoxColumn});
            this.dgvMain.DataSource = this.bindingSource1;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 25);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 15;
            this.dgvMain.Size = new System.Drawing.Size(987, 556);
            this.dgvMain.TabIndex = 1;
            // 
            // dsCnt1
            // 
            this.dsCnt1.DataSetName = "dsCnt";
            this.dsCnt1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vG_MeterVerification";
            this.bindingSource1.DataSource = this.dsCnt1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "№ дог";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeAbonentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 40;
            // 
            // nameShortDataGridViewTextBoxColumn
            // 
            this.nameShortDataGridViewTextBoxColumn.DataPropertyName = "NameShort";
            this.nameShortDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.nameShortDataGridViewTextBoxColumn.Name = "nameShortDataGridViewTextBoxColumn";
            this.nameShortDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameShortDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameShortDataGridViewTextBoxColumn.Width = 200;
            // 
            // representationDataGridViewTextBoxColumn
            // 
            this.representationDataGridViewTextBoxColumn.DataPropertyName = "Representation";
            this.representationDataGridViewTextBoxColumn.HeaderText = "Representation";
            this.representationDataGridViewTextBoxColumn.Name = "representationDataGridViewTextBoxColumn";
            this.representationDataGridViewTextBoxColumn.ReadOnly = true;
            this.representationDataGridViewTextBoxColumn.Visible = false;
            // 
            // dPostDataGridViewTextBoxColumn
            // 
            this.dPostDataGridViewTextBoxColumn.DataPropertyName = "D_Post";
            this.dPostDataGridViewTextBoxColumn.HeaderText = "D_Post";
            this.dPostDataGridViewTextBoxColumn.Name = "dPostDataGridViewTextBoxColumn";
            this.dPostDataGridViewTextBoxColumn.ReadOnly = true;
            this.dPostDataGridViewTextBoxColumn.Visible = false;
            // 
            // dFDataGridViewTextBoxColumn
            // 
            this.dFDataGridViewTextBoxColumn.DataPropertyName = "D_F";
            this.dFDataGridViewTextBoxColumn.HeaderText = "D_F";
            this.dFDataGridViewTextBoxColumn.Name = "dFDataGridViewTextBoxColumn";
            this.dFDataGridViewTextBoxColumn.ReadOnly = true;
            this.dFDataGridViewTextBoxColumn.Visible = false;
            // 
            // dIDataGridViewTextBoxColumn
            // 
            this.dIDataGridViewTextBoxColumn.DataPropertyName = "D_I";
            this.dIDataGridViewTextBoxColumn.HeaderText = "D_I";
            this.dIDataGridViewTextBoxColumn.Name = "dIDataGridViewTextBoxColumn";
            this.dIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIDataGridViewTextBoxColumn.Visible = false;
            // 
            // dODataGridViewTextBoxColumn
            // 
            this.dODataGridViewTextBoxColumn.DataPropertyName = "D_O";
            this.dODataGridViewTextBoxColumn.HeaderText = "D_O";
            this.dODataGridViewTextBoxColumn.Name = "dODataGridViewTextBoxColumn";
            this.dODataGridViewTextBoxColumn.ReadOnly = true;
            this.dODataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // idWorkerDataGridViewTextBoxColumn
            // 
            this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn.HeaderText = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
            this.idWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idWorkerDataGridViewTextBoxColumn.Visible = false;
            // 
            // fDataGridViewTextBoxColumn
            // 
            this.fDataGridViewTextBoxColumn.DataPropertyName = "F";
            this.fDataGridViewTextBoxColumn.HeaderText = "Мастер";
            this.fDataGridViewTextBoxColumn.Name = "fDataGridViewTextBoxColumn";
            this.fDataGridViewTextBoxColumn.ReadOnly = true;
            this.fDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // metNumberDataGridViewTextBoxColumn
            // 
            this.metNumberDataGridViewTextBoxColumn.DataPropertyName = "MetNumber";
            this.metNumberDataGridViewTextBoxColumn.HeaderText = "Счетчик";
            this.metNumberDataGridViewTextBoxColumn.Name = "metNumberDataGridViewTextBoxColumn";
            this.metNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.metNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // metDateCheckDataGridViewTextBoxColumn
            // 
            this.metDateCheckDataGridViewTextBoxColumn.DataPropertyName = "MetDateCheck";
            this.metDateCheckDataGridViewTextBoxColumn.HeaderText = "Дата поверки";
            this.metDateCheckDataGridViewTextBoxColumn.Name = "metDateCheckDataGridViewTextBoxColumn";
            this.metDateCheckDataGridViewTextBoxColumn.ReadOnly = true;
            this.metDateCheckDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // trNumberDataGridViewTextBoxColumn
            // 
            this.trNumberDataGridViewTextBoxColumn.DataPropertyName = "TrNumber";
            this.trNumberDataGridViewTextBoxColumn.HeaderText = "Трансформатор";
            this.trNumberDataGridViewTextBoxColumn.Name = "trNumberDataGridViewTextBoxColumn";
            this.trNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.trNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // trDateCheckDataGridViewTextBoxColumn
            // 
            this.trDateCheckDataGridViewTextBoxColumn.DataPropertyName = "TrDateCheck";
            this.trDateCheckDataGridViewTextBoxColumn.HeaderText = "Дата поверки";
            this.trDateCheckDataGridViewTextBoxColumn.Name = "trDateCheckDataGridViewTextBoxColumn";
            this.trDateCheckDataGridViewTextBoxColumn.ReadOnly = true;
            this.trDateCheckDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormMeterVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 581);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormMeterVerification";
            this.Text = "Отчет по государственной поверке приборов учета(тестируется)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCnt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvMain;
        private DataSet.dsCnt dsCnt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameShortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn representationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dODataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn fDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn metNumberDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn metDateCheckDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn trNumberDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn trDateCheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}