namespace Prv.Forms.Plombs
{
    partial class FormPlombUstDemEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlombUstDemEdit));
            this.groupBoxUst = new System.Windows.Forms.GroupBox();
            this.dateTimePickerUst = new System.Windows.Forms.DateTimePicker();
            this.dsPlombUst = new Prv.DataSets.DataSetPlomb();
            this.labelDateUst = new System.Windows.Forms.Label();
            this.cmbControlerUst = new System.Windows.Forms.ComboBox();
            this.bindingSourceWorkerUst = new System.Windows.Forms.BindingSource(this.components);
            this.dsForm = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataTable3 = new System.Data.DataTable();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.labelControlerUst = new System.Windows.Forms.Label();
            this.groupBoxDem = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDem = new ControlsLbr.NullableDateTimePicker();
            this.dsPlombDem = new Prv.DataSets.DataSetPlomb();
            this.labelDateDem = new System.Windows.Forms.Label();
            this.cmbControlerDem = new System.Windows.Forms.ComboBox();
            this.bindingSourceWorkerDem = new System.Windows.Forms.BindingSource(this.components);
            this.labelControlerDem = new System.Windows.Forms.Label();
            this.groupBoxPlomb = new System.Windows.Forms.GroupBox();
            this.cmbSEriaNumber = new System.Windows.Forms.ComboBox();
            this.labelSeriaNumber = new System.Windows.Forms.Label();
            this.cmbTypePlomb = new System.Windows.Forms.ComboBox();
            this.labelTypePlomb = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlombUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceWorkerUst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            this.groupBoxDem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlombDem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceWorkerDem)).BeginInit();
            this.groupBoxPlomb.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUst
            // 
            this.groupBoxUst.Controls.Add(this.dateTimePickerUst);
            this.groupBoxUst.Controls.Add(this.labelDateUst);
            this.groupBoxUst.Controls.Add(this.cmbControlerUst);
            this.groupBoxUst.Controls.Add(this.labelControlerUst);
            this.groupBoxUst.Location = new System.Drawing.Point(1, 1);
            this.groupBoxUst.Name = "groupBoxUst";
            this.groupBoxUst.Size = new System.Drawing.Size(164, 100);
            this.groupBoxUst.TabIndex = 0;
            this.groupBoxUst.TabStop = false;
            this.groupBoxUst.Text = "Установка";
            // 
            // dateTimePickerUst
            // 
            this.dateTimePickerUst.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsPlombUst, "tPlomb.DateInst", true));
            this.dateTimePickerUst.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlombUst, "tPlomb.DateInst", true));
            this.dateTimePickerUst.Location = new System.Drawing.Point(14, 74);
            this.dateTimePickerUst.Name = "dateTimePickerUst";
            this.dateTimePickerUst.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerUst.TabIndex = 3;
            this.dateTimePickerUst.ValueChanged += new System.EventHandler(this.dateTimePickerUst_ValueChanged);
            // 
            // dsPlombUst
            // 
            this.dsPlombUst.DataSetName = "DataSetPlomb";
            this.dsPlombUst.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelDateUst
            // 
            this.labelDateUst.AutoSize = true;
            this.labelDateUst.Location = new System.Drawing.Point(11, 56);
            this.labelDateUst.Name = "labelDateUst";
            this.labelDateUst.Size = new System.Drawing.Size(33, 13);
            this.labelDateUst.TabIndex = 2;
            this.labelDateUst.Text = "Дата";
            // 
            // cmbControlerUst
            // 
            this.cmbControlerUst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbControlerUst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbControlerUst.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPlombUst, "tPlomb.idWorker", true));
            this.cmbControlerUst.DataSource = this.bindingSourceWorkerUst;
            this.cmbControlerUst.DisplayMember = "FIO";
            this.cmbControlerUst.FormattingEnabled = true;
            this.cmbControlerUst.Location = new System.Drawing.Point(14, 32);
            this.cmbControlerUst.Name = "cmbControlerUst";
            this.cmbControlerUst.Size = new System.Drawing.Size(141, 21);
            this.cmbControlerUst.TabIndex = 1;
            this.cmbControlerUst.ValueMember = "id";
            this.cmbControlerUst.SelectedIndexChanged += new System.EventHandler(this.cmbControlerUst_SelectedIndexChanged);
            // 
            // bindingSourceWorkerUst
            // 
            this.bindingSourceWorkerUst.DataMember = "vWorkerGroup";
            this.bindingSourceWorkerUst.DataSource = this.dsForm;
            // 
            // dsForm
            // 
            this.dsForm.DataSetName = "NewDataSet";
            this.dsForm.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2,
            this.dataTable3});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2});
            this.dataTable1.TableName = "vWorkerGroup";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "id";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "FIO";
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3,
            this.dataColumn4});
            this.dataTable2.TableName = "tR_Classifier";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Id";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Name";
            // 
            // dataTable3
            // 
            this.dataTable3.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9});
            this.dataTable3.TableName = "vPlombStatus";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "id";
            this.dataColumn5.DataType = typeof(int);
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "Seria";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "NumberString";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "DigitNumber";
            this.dataColumn8.DataType = typeof(int);
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "SeriaNumber";
            this.dataColumn9.Expression = "isnull(seria, \'\') + iif(seria is null, \'\', \' \') + isnull(numberstring, \'\')";
            this.dataColumn9.ReadOnly = true;
            // 
            // labelControlerUst
            // 
            this.labelControlerUst.AutoSize = true;
            this.labelControlerUst.Location = new System.Drawing.Point(11, 16);
            this.labelControlerUst.Name = "labelControlerUst";
            this.labelControlerUst.Size = new System.Drawing.Size(61, 13);
            this.labelControlerUst.TabIndex = 0;
            this.labelControlerUst.Text = "Контролер";
            // 
            // groupBoxDem
            // 
            this.groupBoxDem.Controls.Add(this.dateTimePickerDem);
            this.groupBoxDem.Controls.Add(this.labelDateDem);
            this.groupBoxDem.Controls.Add(this.cmbControlerDem);
            this.groupBoxDem.Controls.Add(this.labelControlerDem);
            this.groupBoxDem.Location = new System.Drawing.Point(171, 1);
            this.groupBoxDem.Name = "groupBoxDem";
            this.groupBoxDem.Size = new System.Drawing.Size(164, 100);
            this.groupBoxDem.TabIndex = 1;
            this.groupBoxDem.TabStop = false;
            this.groupBoxDem.Text = "Демонтаж";
            // 
            // dateTimePickerDem
            // 
            this.dateTimePickerDem.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsPlombDem, "tPlomb.DateInst", true));
            this.dateTimePickerDem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsPlombDem, "tPlomb.DateInst", true));
            this.dateTimePickerDem.Location = new System.Drawing.Point(14, 72);
            this.dateTimePickerDem.Name = "dateTimePickerDem";
            this.dateTimePickerDem.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerDem.TabIndex = 3;
            this.dateTimePickerDem.Value = new System.DateTime(2010, 11, 19, 10, 3, 23, 846);
            // 
            // dsPlombDem
            // 
            this.dsPlombDem.DataSetName = "DataSetPlomb";
            this.dsPlombDem.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelDateDem
            // 
            this.labelDateDem.AutoSize = true;
            this.labelDateDem.Location = new System.Drawing.Point(11, 56);
            this.labelDateDem.Name = "labelDateDem";
            this.labelDateDem.Size = new System.Drawing.Size(33, 13);
            this.labelDateDem.TabIndex = 2;
            this.labelDateDem.Text = "Дата";
            // 
            // cmbControlerDem
            // 
            this.cmbControlerDem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbControlerDem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbControlerDem.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPlombDem, "tPlomb.idWorker", true));
            this.cmbControlerDem.DataSource = this.bindingSourceWorkerDem;
            this.cmbControlerDem.DisplayMember = "FIO";
            this.cmbControlerDem.FormattingEnabled = true;
            this.cmbControlerDem.Location = new System.Drawing.Point(14, 32);
            this.cmbControlerDem.Name = "cmbControlerDem";
            this.cmbControlerDem.Size = new System.Drawing.Size(141, 21);
            this.cmbControlerDem.TabIndex = 1;
            this.cmbControlerDem.ValueMember = "id";
            // 
            // bindingSourceWorkerDem
            // 
            this.bindingSourceWorkerDem.DataMember = "vWorkerGroup";
            this.bindingSourceWorkerDem.DataSource = this.dsForm;
            // 
            // labelControlerDem
            // 
            this.labelControlerDem.AutoSize = true;
            this.labelControlerDem.Location = new System.Drawing.Point(11, 16);
            this.labelControlerDem.Name = "labelControlerDem";
            this.labelControlerDem.Size = new System.Drawing.Size(61, 13);
            this.labelControlerDem.TabIndex = 0;
            this.labelControlerDem.Text = "Контролер";
            // 
            // groupBoxPlomb
            // 
            this.groupBoxPlomb.Controls.Add(this.cmbSEriaNumber);
            this.groupBoxPlomb.Controls.Add(this.labelSeriaNumber);
            this.groupBoxPlomb.Controls.Add(this.cmbTypePlomb);
            this.groupBoxPlomb.Controls.Add(this.labelTypePlomb);
            this.groupBoxPlomb.Location = new System.Drawing.Point(1, 101);
            this.groupBoxPlomb.Name = "groupBoxPlomb";
            this.groupBoxPlomb.Size = new System.Drawing.Size(334, 76);
            this.groupBoxPlomb.TabIndex = 2;
            this.groupBoxPlomb.TabStop = false;
            this.groupBoxPlomb.Text = "Пломба";
            // 
            // cmbSEriaNumber
            // 
            this.cmbSEriaNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSEriaNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSEriaNumber.DataSource = this.dsForm;
            this.cmbSEriaNumber.DisplayMember = "vPlombStatus.SeriaNumber";
            this.cmbSEriaNumber.FormattingEnabled = true;
            this.cmbSEriaNumber.Location = new System.Drawing.Point(117, 44);
            this.cmbSEriaNumber.Name = "cmbSEriaNumber";
            this.cmbSEriaNumber.Size = new System.Drawing.Size(176, 21);
            this.cmbSEriaNumber.TabIndex = 3;
            this.cmbSEriaNumber.ValueMember = "vPlombStatus.id";
            // 
            // labelSeriaNumber
            // 
            this.labelSeriaNumber.AutoSize = true;
            this.labelSeriaNumber.Location = new System.Drawing.Point(29, 47);
            this.labelSeriaNumber.Name = "labelSeriaNumber";
            this.labelSeriaNumber.Size = new System.Drawing.Size(82, 13);
            this.labelSeriaNumber.TabIndex = 2;
            this.labelSeriaNumber.Text = "Серия и номер";
            // 
            // cmbTypePlomb
            // 
            this.cmbTypePlomb.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsPlombUst, "tPlomb.typePlomb", true));
            this.cmbTypePlomb.DataSource = this.dsForm;
            this.cmbTypePlomb.DisplayMember = "tR_Classifier.Name";
            this.cmbTypePlomb.FormattingEnabled = true;
            this.cmbTypePlomb.Location = new System.Drawing.Point(117, 13);
            this.cmbTypePlomb.Name = "cmbTypePlomb";
            this.cmbTypePlomb.Size = new System.Drawing.Size(176, 21);
            this.cmbTypePlomb.TabIndex = 1;
            this.cmbTypePlomb.ValueMember = "tR_Classifier.Id";
            this.cmbTypePlomb.SelectedIndexChanged += new System.EventHandler(this.cmbControlerUst_SelectedIndexChanged);
            // 
            // labelTypePlomb
            // 
            this.labelTypePlomb.AutoSize = true;
            this.labelTypePlomb.Location = new System.Drawing.Point(42, 16);
            this.labelTypePlomb.Name = "labelTypePlomb";
            this.labelTypePlomb.Size = new System.Drawing.Size(69, 13);
            this.labelTypePlomb.TabIndex = 0;
            this.labelTypePlomb.Text = "Тип пломбы";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(15, 193);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 3;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(251, 193);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormPlombUstDemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(334, 227);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.groupBoxPlomb);
            this.Controls.Add(this.groupBoxDem);
            this.Controls.Add(this.groupBoxUst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlombUstDemEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormPlombUstDemEdit";
            this.Load += new System.EventHandler(this.FormPlombUstDemEdit_Load);
            this.groupBoxUst.ResumeLayout(false);
            this.groupBoxUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlombUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceWorkerUst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            this.groupBoxDem.ResumeLayout(false);
            this.groupBoxDem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlombDem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceWorkerDem)).EndInit();
            this.groupBoxPlomb.ResumeLayout(false);
            this.groupBoxPlomb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUst;
        private System.Windows.Forms.DateTimePicker dateTimePickerUst;
        private System.Windows.Forms.Label labelDateUst;
        private System.Windows.Forms.ComboBox cmbControlerUst;
        private System.Windows.Forms.Label labelControlerUst;
        private System.Windows.Forms.GroupBox groupBoxDem;
        private ControlsLbr.NullableDateTimePicker dateTimePickerDem;
        private System.Windows.Forms.Label labelDateDem;
        private System.Windows.Forms.ComboBox cmbControlerDem;
        private System.Windows.Forms.Label labelControlerDem;
        private System.Windows.Forms.GroupBox groupBoxPlomb;
        private System.Windows.Forms.ComboBox cmbSEriaNumber;
        private System.Windows.Forms.Label labelSeriaNumber;
        private System.Windows.Forms.ComboBox cmbTypePlomb;
        private System.Windows.Forms.Label labelTypePlomb;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private Prv.DataSets.DataSetPlomb dsPlombUst;
        private System.Windows.Forms.BindingSource bindingSourceWorkerUst;
        private System.Windows.Forms.BindingSource bindingSourceWorkerDem;
        private System.Data.DataSet dsForm;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private Prv.DataSets.DataSetPlomb dsPlombDem;
        private System.Data.DataTable dataTable3;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
    }
}