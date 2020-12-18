namespace Legal.Forms
{
    partial class FormLAbn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewAbn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.codeAbonentDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.CodeAbnStr = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.Worker = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.TypeDog = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.CountObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewAbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AbnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetLAbn1 = new Legal.DataSet.DataSetLAbn();
            this.tBoxAbnCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxObjCount = new System.Windows.Forms.TextBox();
            this.tBoxMeterCount = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cbStatus = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.txtCountRows = new System.Windows.Forms.ToolStripTextBox();
            this.btnNumberMonth = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLAbn1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewAbn
            // 
            this.dataGridViewAbn.AllowUserToAddRows = false;
            this.dataGridViewAbn.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAbn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAbn.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAbn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewAbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeAbonentDataGridViewTextBoxColumn,
            this.CodeAbnStr,
            this.nameDataGridViewTextBoxColumn,
            this.Worker,
            this.TypeDog,
            this.CountObj,
            this.CountMeter,
            this.idDataGridViewAbn});
            this.dataGridViewAbn.DataSource = this.AbnBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAbn.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewAbn.Location = new System.Drawing.Point(0, 27);
            this.dataGridViewAbn.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewAbn.Name = "dataGridViewAbn";
            this.dataGridViewAbn.NumbLineVisible = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAbn.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewAbn.RowHeadersWidth = 4;
            this.dataGridViewAbn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAbn.RowTemplate.Height = 24;
            this.dataGridViewAbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAbn.Size = new System.Drawing.Size(914, 504);
            this.dataGridViewAbn.TabIndex = 0;
            this.dataGridViewAbn.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridViewAbn_Paint);
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.codeAbonentDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "Код";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // CodeAbnStr
            // 
            this.CodeAbnStr.DataPropertyName = "CodeAbnStr";
            this.CodeAbnStr.HeaderText = "Дополнит.код";
            this.CodeAbnStr.Name = "CodeAbnStr";
            this.CodeAbnStr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // Worker
            // 
            this.Worker.DataPropertyName = "Famil";
            this.Worker.HeaderText = "Контролер";
            this.Worker.Name = "Worker";
            this.Worker.ReadOnly = true;
            this.Worker.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Worker.Width = 150;
            // 
            // TypeDog
            // 
            this.TypeDog.DataPropertyName = "TypeDog";
            this.TypeDog.HeaderText = "Договор";
            this.TypeDog.Name = "TypeDog";
            this.TypeDog.ReadOnly = true;
            this.TypeDog.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeDog.Width = 75;
            // 
            // CountObj
            // 
            this.CountObj.DataPropertyName = "CountObj";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.CountObj.DefaultCellStyle = dataGridViewCellStyle4;
            this.CountObj.HeaderText = "Объекты";
            this.CountObj.Name = "CountObj";
            this.CountObj.ReadOnly = true;
            this.CountObj.Width = 75;
            // 
            // CountMeter
            // 
            this.CountMeter.DataPropertyName = "CountMeter";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CountMeter.DefaultCellStyle = dataGridViewCellStyle5;
            this.CountMeter.HeaderText = "Счетчики";
            this.CountMeter.Name = "CountMeter";
            this.CountMeter.ReadOnly = true;
            this.CountMeter.Width = 75;
            // 
            // idDataGridViewAbn
            // 
            this.idDataGridViewAbn.DataPropertyName = "id";
            this.idDataGridViewAbn.HeaderText = "id";
            this.idDataGridViewAbn.Name = "idDataGridViewAbn";
            this.idDataGridViewAbn.Visible = false;
            // 
            // AbnBindingSource
            // 
            this.AbnBindingSource.DataMember = "vG_Customer";
            this.AbnBindingSource.DataSource = this.dataSetLAbn1;
            this.AbnBindingSource.Sort = "codeabonent";
            // 
            // dataSetLAbn1
            // 
            this.dataSetLAbn1.DataSetName = "DataSetLAbn";
            this.dataSetLAbn1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBoxAbnCount
            // 
            this.tBoxAbnCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBoxAbnCount.Enabled = false;
            this.tBoxAbnCount.Location = new System.Drawing.Point(123, 535);
            this.tBoxAbnCount.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxAbnCount.Name = "tBoxAbnCount";
            this.tBoxAbnCount.Size = new System.Drawing.Size(44, 20);
            this.tBoxAbnCount.TabIndex = 1;
            this.tBoxAbnCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 535);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Всего:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 535);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "абонентов";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 536);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "объектов";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 536);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "счетчиков";
            // 
            // tBoxObjCount
            // 
            this.tBoxObjCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBoxObjCount.Enabled = false;
            this.tBoxObjCount.Location = new System.Drawing.Point(241, 536);
            this.tBoxObjCount.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxObjCount.Name = "tBoxObjCount";
            this.tBoxObjCount.Size = new System.Drawing.Size(44, 20);
            this.tBoxObjCount.TabIndex = 6;
            this.tBoxObjCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBoxMeterCount
            // 
            this.tBoxMeterCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBoxMeterCount.Enabled = false;
            this.tBoxMeterCount.Location = new System.Drawing.Point(370, 536);
            this.tBoxMeterCount.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxMeterCount.Name = "tBoxMeterCount";
            this.tBoxMeterCount.Size = new System.Drawing.Size(44, 20);
            this.tBoxMeterCount.TabIndex = 7;
            this.tBoxMeterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbStatus,
            this.toolStripSeparator1,
            this.btnExcel,
            this.txtCountRows,
            this.btnNumberMonth,
            this.btnExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(914, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cbStatus
            // 
            this.cbStatus.Items.AddRange(new object[] {
            "Действующие",
            "Все "});
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 25);
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnExcel
            // 
            this.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcel.Image = global::Legal.Properties.Resources.xlsx_mac;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(23, 22);
            this.btnExcel.Text = "Экспорт в Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtCountRows
            // 
            this.txtCountRows.Name = "txtCountRows";
            this.txtCountRows.Size = new System.Drawing.Size(100, 25);
            this.txtCountRows.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNumberMonth
            // 
            this.btnNumberMonth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNumberMonth.Enabled = false;
            this.btnNumberMonth.Image = global::Legal.Properties.Resources._1304672652_Information;
            this.btnNumberMonth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNumberMonth.Name = "btnNumberMonth";
            this.btnNumberMonth.Size = new System.Drawing.Size(23, 22);
            this.btnNumberMonth.Text = "toolStripButton1";
            this.btnNumberMonth.Click += new System.EventHandler(this.btnNumberMonth_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(797, 536);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExport.Image = global::Legal.Properties.Resources.Export_To_Document;
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(23, 22);
            this.btnExport.Text = "Экспорт новых абонентов в 1С";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // FormLAbn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tBoxMeterCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBoxObjCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxAbnCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridViewAbn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLAbn";
            this.Text = "Потребители";
            this.Load += new System.EventHandler(this.FormLAbn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetLAbn1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter dataGridViewAbn;
        private Legal.DataSet.DataSetLAbn dataSetLAbn1;
        private System.Windows.Forms.BindingSource AbnBindingSource;
        private System.Windows.Forms.TextBox tBoxAbnCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxObjCount;
        private System.Windows.Forms.TextBox tBoxMeterCount;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripTextBox txtCountRows;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripComboBox cbStatus;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn CodeAbnStr;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn nameDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn Worker;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn TypeDog;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountObj;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewAbn;
        private System.Windows.Forms.ToolStripButton btnNumberMonth;
        private System.Windows.Forms.ToolStripButton btnExport;
    }
}
