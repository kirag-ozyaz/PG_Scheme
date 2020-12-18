namespace Legal.Forms.ActCheck
{
    partial class Form_Journal_MeterDemontag
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbnDocum1 = new Legal.DataSet.dsAbnDocum();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.workerAbnDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idAbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abnNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idObjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objNameDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dtBeginMeterDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dtEndMeterDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.workerDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateActDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.docNumberDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.idDocTypeNewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPointRegNewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberNewDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dtBeginMeterNewDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.workerNewDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.dateActNewDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.docNumberNewDataGridViewTextBoxColumn = new ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerAbnDataGridViewTextBoxColumn,
            this.idAbnDataGridViewTextBoxColumn,
            this.codeAbonentDataGridViewTextBoxColumn,
            this.abnNameDataGridViewTextBoxColumn,
            this.idObjDataGridViewTextBoxColumn,
            this.objNameDataGridViewTextBoxColumn,
            this.idPointDataGridViewTextBoxColumn,
            this.pointNameDataGridViewTextBoxColumn,
            this.idDocTypeDataGridViewTextBoxColumn,
            this.idPointRegDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.dtBeginMeterDataGridViewTextBoxColumn,
            this.dtEndMeterDataGridViewTextBoxColumn,
            this.workerDataGridViewTextBoxColumn,
            this.dateActDataGridViewTextBoxColumn,
            this.docNumberDataGridViewTextBoxColumn,
            this.idDocTypeNewDataGridViewTextBoxColumn,
            this.idPointRegNewDataGridViewTextBoxColumn,
            this.numberNewDataGridViewTextBoxColumn,
            this.dtBeginMeterNewDataGridViewTextBoxColumn,
            this.workerNewDataGridViewTextBoxColumn,
            this.dateActNewDataGridViewTextBoxColumn,
            this.docNumberNewDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.bs;
            this.dgv.Location = new System.Drawing.Point(171, 28);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 5;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(763, 485);
            this.dgv.TabIndex = 1;
            // 
            // bs
            // 
            this.bs.DataMember = "tMeterDemontag";
            this.bs.DataSource = this.dsAbnDocum1;
            // 
            // dsAbnDocum1
            // 
            this.dsAbnDocum1.DataSetName = "dsAbnDocum";
            this.dsAbnDocum1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnd.Location = new System.Drawing.Point(49, 438);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 23);
            this.btnEnd.TabIndex = 80;
            this.btnEnd.Text = "Выход";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.Location = new System.Drawing.Point(49, 397);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 79;
            this.btnOK.Text = "Выполнить";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 78;
            this.label2.Text = "Конец";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Начало";
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus.Location = new System.Drawing.Point(149, 88);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(16, 23);
            this.btnMinus.TabIndex = 76;
            this.btnMinus.Text = "<";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus.Location = new System.Drawing.Point(149, 51);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(16, 23);
            this.btnPlus.TabIndex = 75;
            this.btnPlus.Text = ">";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(12, 91);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 74;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(12, 52);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 73;
            // 
            // workerAbnDataGridViewTextBoxColumn
            // 
            this.workerAbnDataGridViewTextBoxColumn.DataPropertyName = "WorkerAbn";
            this.workerAbnDataGridViewTextBoxColumn.HeaderText = "Специалист";
            this.workerAbnDataGridViewTextBoxColumn.Name = "workerAbnDataGridViewTextBoxColumn";
            this.workerAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerAbnDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workerAbnDataGridViewTextBoxColumn.Width = 150;
            // 
            // idAbnDataGridViewTextBoxColumn
            // 
            this.idAbnDataGridViewTextBoxColumn.DataPropertyName = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.HeaderText = "idAbn";
            this.idAbnDataGridViewTextBoxColumn.Name = "idAbnDataGridViewTextBoxColumn";
            this.idAbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbnDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "№ дог";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            this.codeAbonentDataGridViewTextBoxColumn.Width = 70;
            // 
            // abnNameDataGridViewTextBoxColumn
            // 
            this.abnNameDataGridViewTextBoxColumn.DataPropertyName = "abnName";
            this.abnNameDataGridViewTextBoxColumn.HeaderText = "Потребитель";
            this.abnNameDataGridViewTextBoxColumn.Name = "abnNameDataGridViewTextBoxColumn";
            this.abnNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.abnNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.abnNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // idObjDataGridViewTextBoxColumn
            // 
            this.idObjDataGridViewTextBoxColumn.DataPropertyName = "idObj";
            this.idObjDataGridViewTextBoxColumn.HeaderText = "idObj";
            this.idObjDataGridViewTextBoxColumn.Name = "idObjDataGridViewTextBoxColumn";
            this.idObjDataGridViewTextBoxColumn.ReadOnly = true;
            this.idObjDataGridViewTextBoxColumn.Visible = false;
            // 
            // objNameDataGridViewTextBoxColumn
            // 
            this.objNameDataGridViewTextBoxColumn.DataPropertyName = "objName";
            this.objNameDataGridViewTextBoxColumn.HeaderText = "Объект";
            this.objNameDataGridViewTextBoxColumn.Name = "objNameDataGridViewTextBoxColumn";
            this.objNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.objNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.objNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // idPointDataGridViewTextBoxColumn
            // 
            this.idPointDataGridViewTextBoxColumn.DataPropertyName = "idPoint";
            this.idPointDataGridViewTextBoxColumn.HeaderText = "idPoint";
            this.idPointDataGridViewTextBoxColumn.Name = "idPointDataGridViewTextBoxColumn";
            this.idPointDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointDataGridViewTextBoxColumn.Visible = false;
            // 
            // pointNameDataGridViewTextBoxColumn
            // 
            this.pointNameDataGridViewTextBoxColumn.DataPropertyName = "pointName";
            this.pointNameDataGridViewTextBoxColumn.HeaderText = "";
            this.pointNameDataGridViewTextBoxColumn.Name = "pointNameDataGridViewTextBoxColumn";
            this.pointNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pointNameDataGridViewTextBoxColumn.Width = 20;
            // 
            // idDocTypeDataGridViewTextBoxColumn
            // 
            this.idDocTypeDataGridViewTextBoxColumn.DataPropertyName = "idDocType";
            this.idDocTypeDataGridViewTextBoxColumn.HeaderText = "idDocType";
            this.idDocTypeDataGridViewTextBoxColumn.Name = "idDocTypeDataGridViewTextBoxColumn";
            this.idDocTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPointRegDataGridViewTextBoxColumn
            // 
            this.idPointRegDataGridViewTextBoxColumn.DataPropertyName = "idPointReg";
            this.idPointRegDataGridViewTextBoxColumn.HeaderText = "idPointReg";
            this.idPointRegDataGridViewTextBoxColumn.Name = "idPointRegDataGridViewTextBoxColumn";
            this.idPointRegDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointRegDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Прибор";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtBeginMeterDataGridViewTextBoxColumn
            // 
            this.dtBeginMeterDataGridViewTextBoxColumn.DataPropertyName = "dtBeginMeter";
            this.dtBeginMeterDataGridViewTextBoxColumn.FillWeight = 70F;
            this.dtBeginMeterDataGridViewTextBoxColumn.HeaderText = "ДатаУстановки";
            this.dtBeginMeterDataGridViewTextBoxColumn.Name = "dtBeginMeterDataGridViewTextBoxColumn";
            this.dtBeginMeterDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtBeginMeterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtBeginMeterDataGridViewTextBoxColumn.Width = 70;
            // 
            // dtEndMeterDataGridViewTextBoxColumn
            // 
            this.dtEndMeterDataGridViewTextBoxColumn.DataPropertyName = "dtEndMeter";
            this.dtEndMeterDataGridViewTextBoxColumn.HeaderText = "ДатаСнятия";
            this.dtEndMeterDataGridViewTextBoxColumn.Name = "dtEndMeterDataGridViewTextBoxColumn";
            this.dtEndMeterDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtEndMeterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtEndMeterDataGridViewTextBoxColumn.Width = 70;
            // 
            // workerDataGridViewTextBoxColumn
            // 
            this.workerDataGridViewTextBoxColumn.DataPropertyName = "Worker";
            this.workerDataGridViewTextBoxColumn.HeaderText = "Мастер";
            this.workerDataGridViewTextBoxColumn.Name = "workerDataGridViewTextBoxColumn";
            this.workerDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workerDataGridViewTextBoxColumn.Width = 70;
            // 
            // dateActDataGridViewTextBoxColumn
            // 
            this.dateActDataGridViewTextBoxColumn.DataPropertyName = "DateAct";
            this.dateActDataGridViewTextBoxColumn.HeaderText = "ДатаАста";
            this.dateActDataGridViewTextBoxColumn.Name = "dateActDataGridViewTextBoxColumn";
            this.dateActDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateActDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateActDataGridViewTextBoxColumn.Width = 70;
            // 
            // docNumberDataGridViewTextBoxColumn
            // 
            this.docNumberDataGridViewTextBoxColumn.DataPropertyName = "DocNumber";
            this.docNumberDataGridViewTextBoxColumn.HeaderText = "НомерАкта";
            this.docNumberDataGridViewTextBoxColumn.Name = "docNumberDataGridViewTextBoxColumn";
            this.docNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.docNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.docNumberDataGridViewTextBoxColumn.Width = 70;
            // 
            // idDocTypeNewDataGridViewTextBoxColumn
            // 
            this.idDocTypeNewDataGridViewTextBoxColumn.DataPropertyName = "idDocType_New";
            this.idDocTypeNewDataGridViewTextBoxColumn.HeaderText = "idDocType_New";
            this.idDocTypeNewDataGridViewTextBoxColumn.Name = "idDocTypeNewDataGridViewTextBoxColumn";
            this.idDocTypeNewDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocTypeNewDataGridViewTextBoxColumn.Visible = false;
            // 
            // idPointRegNewDataGridViewTextBoxColumn
            // 
            this.idPointRegNewDataGridViewTextBoxColumn.DataPropertyName = "idPointReg_New";
            this.idPointRegNewDataGridViewTextBoxColumn.HeaderText = "idPointReg_New";
            this.idPointRegNewDataGridViewTextBoxColumn.Name = "idPointRegNewDataGridViewTextBoxColumn";
            this.idPointRegNewDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPointRegNewDataGridViewTextBoxColumn.Visible = false;
            // 
            // numberNewDataGridViewTextBoxColumn
            // 
            this.numberNewDataGridViewTextBoxColumn.DataPropertyName = "Number_New";
            this.numberNewDataGridViewTextBoxColumn.HeaderText = "ПриборНовый";
            this.numberNewDataGridViewTextBoxColumn.Name = "numberNewDataGridViewTextBoxColumn";
            this.numberNewDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberNewDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dtBeginMeterNewDataGridViewTextBoxColumn
            // 
            this.dtBeginMeterNewDataGridViewTextBoxColumn.DataPropertyName = "dtBeginMeter_New";
            this.dtBeginMeterNewDataGridViewTextBoxColumn.HeaderText = "ДатаУстановки";
            this.dtBeginMeterNewDataGridViewTextBoxColumn.Name = "dtBeginMeterNewDataGridViewTextBoxColumn";
            this.dtBeginMeterNewDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtBeginMeterNewDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtBeginMeterNewDataGridViewTextBoxColumn.Width = 70;
            // 
            // workerNewDataGridViewTextBoxColumn
            // 
            this.workerNewDataGridViewTextBoxColumn.DataPropertyName = "Worker_New";
            this.workerNewDataGridViewTextBoxColumn.HeaderText = "Мастер";
            this.workerNewDataGridViewTextBoxColumn.Name = "workerNewDataGridViewTextBoxColumn";
            this.workerNewDataGridViewTextBoxColumn.ReadOnly = true;
            this.workerNewDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.workerNewDataGridViewTextBoxColumn.Width = 70;
            // 
            // dateActNewDataGridViewTextBoxColumn
            // 
            this.dateActNewDataGridViewTextBoxColumn.DataPropertyName = "DateAct_New";
            this.dateActNewDataGridViewTextBoxColumn.HeaderText = "ДатаАкта";
            this.dateActNewDataGridViewTextBoxColumn.Name = "dateActNewDataGridViewTextBoxColumn";
            this.dateActNewDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateActNewDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dateActNewDataGridViewTextBoxColumn.Width = 70;
            // 
            // docNumberNewDataGridViewTextBoxColumn
            // 
            this.docNumberNewDataGridViewTextBoxColumn.DataPropertyName = "DocNumber_New";
            this.docNumberNewDataGridViewTextBoxColumn.HeaderText = "НомерАкта";
            this.docNumberNewDataGridViewTextBoxColumn.Name = "docNumberNewDataGridViewTextBoxColumn";
            this.docNumberNewDataGridViewTextBoxColumn.ReadOnly = true;
            this.docNumberNewDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.docNumberNewDataGridViewTextBoxColumn.Width = 70;
            // 
            // btnExcel
            // 
            this.btnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcel.Image = global::Legal.Properties.Resources.Microsoft_Excel;
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(23, 22);
            this.btnExcel.Text = "toolStripButton1";
            this.btnExcel.ToolTipText = "Экспорт в Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Form_Journal_MeterDemontag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtBegin);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form_Journal_MeterDemontag";
            this.Text = "Журнал замены приборов учета";
            this.Load += new System.EventHandler(this.Form_Journal_MeterDemontag_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnDocum1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private DataSet.dsAbnDocum dsAbnDocum1;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn workerAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn abnNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn objNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pointNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointRegDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn numberDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dtBeginMeterDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dtEndMeterDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn workerDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dateActDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn docNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocTypeNewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPointRegNewDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn numberNewDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dtBeginMeterNewDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn workerNewDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn dateActNewDataGridViewTextBoxColumn;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewFilterTextBoxColumn docNumberNewDataGridViewTextBoxColumn;
    }
}