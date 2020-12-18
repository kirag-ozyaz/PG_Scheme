namespace Legal.Forms.Calculat
{
    partial class FormReportMeasur
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsObj1 = new Legal.DataSet.dsObj();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.clbStation = new System.Windows.Forms.CheckedListBox();
            this.dgvMeasur = new System.Windows.Forms.DataGridView();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.abnNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.objNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.averageValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.clbStation);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условия";
            // 
            // cmbDay
            // 
            this.cmbDay.DataSource = this.bindingSource1;
            this.cmbDay.DisplayMember = "DateOfIntroduction";
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Location = new System.Drawing.Point(9, 46);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(121, 21);
            this.cmbDay.TabIndex = 67;
            this.cmbDay.ValueMember = "DateOfIntroduction";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "vG_MeasurementsDays";
            this.bindingSource1.DataSource = this.dsObj1;
            // 
            // dsObj1
            // 
            this.dsObj1.DataSetName = "dsObj";
            this.dsObj1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Режимные дни:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Подстанции:";
            // 
            // clbStation
            // 
            this.clbStation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.clbStation.FormattingEnabled = true;
            this.clbStation.HorizontalScrollbar = true;
            this.clbStation.Location = new System.Drawing.Point(9, 105);
            this.clbStation.Name = "clbStation";
            this.clbStation.Size = new System.Drawing.Size(119, 274);
            this.clbStation.TabIndex = 64;
            // 
            // dgvMeasur
            // 
            this.dgvMeasur.AllowUserToAddRows = false;
            this.dgvMeasur.AllowUserToDeleteRows = false;
            this.dgvMeasur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMeasur.AutoGenerateColumns = false;
            this.dgvMeasur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeasur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeAbonentDataGridViewTextBoxColumn,
            this.abnNameDataGridViewTextBoxColumn,
            this.objNameDataGridViewTextBoxColumn,
            this.averageValueDataGridViewTextBoxColumn});
            this.dgvMeasur.DataSource = this.bindingSource2;
            this.dgvMeasur.Location = new System.Drawing.Point(156, 13);
            this.dgvMeasur.Name = "dgvMeasur";
            this.dgvMeasur.ReadOnly = true;
            this.dgvMeasur.RowHeadersWidth = 10;
            this.dgvMeasur.Size = new System.Drawing.Size(709, 527);
            this.dgvMeasur.TabIndex = 1;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 70;
            // 
            // abnNameDataGridViewTextBoxColumn
            // 
            this.abnNameDataGridViewTextBoxColumn.DataPropertyName = "AbnName";
            this.abnNameDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.abnNameDataGridViewTextBoxColumn.Name = "abnNameDataGridViewTextBoxColumn";
            this.abnNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.abnNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.abnNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // objNameDataGridViewTextBoxColumn
            // 
            this.objNameDataGridViewTextBoxColumn.DataPropertyName = "ObjName";
            this.objNameDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.objNameDataGridViewTextBoxColumn.Name = "objNameDataGridViewTextBoxColumn";
            this.objNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.objNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.objNameDataGridViewTextBoxColumn.Width = 300;
            // 
            // averageValueDataGridViewTextBoxColumn
            // 
            this.averageValueDataGridViewTextBoxColumn.DataPropertyName = "AverageValue";
            this.averageValueDataGridViewTextBoxColumn.HeaderText = "Мощность";
            this.averageValueDataGridViewTextBoxColumn.Name = "averageValueDataGridViewTextBoxColumn";
            this.averageValueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "vG_MeasurementReport";
            this.bindingSource2.DataSource = this.dsObj1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(17, 414);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Сформировать";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(17, 492);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Выйти";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(17, 454);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(119, 23);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Экспорт";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // FormReportMeasur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(868, 540);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dgvMeasur);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormReportMeasur";
            this.Text = "Отчет по замерам режимного дня";
            this.Load += new System.EventHandler(this.FormReportMeasur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsObj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeasur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox clbStation;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.DataGridView dgvMeasur;
        private DataSet.dsObj dsObj1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button btnExcel;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn abnNameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn objNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageValueDataGridViewTextBoxColumn;
    }
}