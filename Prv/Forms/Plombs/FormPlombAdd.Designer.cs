namespace Prv.Forms.Plombs
{
    partial class FormPlombAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlombAdd));
            this.labelControler = new System.Windows.Forms.Label();
            this.cmbControler = new System.Windows.Forms.ComboBox();
            this.dsWorker = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTypePlomb = new System.Windows.Forms.ComboBox();
            this.labelTypePlomb = new System.Windows.Forms.Label();
            this.maskedTextBoxNumberEnd = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNumberBeg = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonDiapason = new System.Windows.Forms.RadioButton();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonNumber = new System.Windows.Forms.RadioButton();
            this.numericUpDownDigit = new System.Windows.Forms.NumericUpDown();
            this.labelDigit = new System.Windows.Forms.Label();
            this.txtSeria = new System.Windows.Forms.TextBox();
            this.checkBoxSeria = new System.Windows.Forms.CheckBox();
            this.labelDateinst = new System.Windows.Forms.Label();
            this.dateTimePickerDateInst = new System.Windows.Forms.DateTimePicker();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dsPlomb = new Prv.DataSets.DataSetPlomb();
            ((System.ComponentModel.ISupportInitialize)(this.dsWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlomb)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControler
            // 
            this.labelControler.AutoSize = true;
            this.labelControler.Location = new System.Drawing.Point(13, 21);
            this.labelControler.Name = "labelControler";
            this.labelControler.Size = new System.Drawing.Size(61, 13);
            this.labelControler.TabIndex = 0;
            this.labelControler.Text = "Контролер";
            // 
            // cmbControler
            // 
            this.cmbControler.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbControler.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbControler.DataSource = this.dsWorker;
            this.cmbControler.DisplayMember = "vWorkerGroup.FIO";
            this.cmbControler.FormattingEnabled = true;
            this.cmbControler.Location = new System.Drawing.Point(80, 18);
            this.cmbControler.Name = "cmbControler";
            this.cmbControler.Size = new System.Drawing.Size(164, 21);
            this.cmbControler.TabIndex = 1;
            this.cmbControler.ValueMember = "vWorkerGroup.id";
            // 
            // dsWorker
            // 
            this.dsWorker.DataSetName = "NewDataSet";
            this.dsWorker.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2});
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTypePlomb);
            this.groupBox1.Controls.Add(this.labelTypePlomb);
            this.groupBox1.Controls.Add(this.maskedTextBoxNumberEnd);
            this.groupBox1.Controls.Add(this.maskedTextBoxNumberBeg);
            this.groupBox1.Controls.Add(this.radioButtonDiapason);
            this.groupBox1.Controls.Add(this.maskedTextBoxNumber);
            this.groupBox1.Controls.Add(this.radioButtonNumber);
            this.groupBox1.Controls.Add(this.numericUpDownDigit);
            this.groupBox1.Controls.Add(this.labelDigit);
            this.groupBox1.Controls.Add(this.txtSeria);
            this.groupBox1.Controls.Add(this.checkBoxSeria);
            this.groupBox1.Location = new System.Drawing.Point(0, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 180);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // cmbTypePlomb
            // 
            this.cmbTypePlomb.DataSource = this.dsWorker;
            this.cmbTypePlomb.DisplayMember = "tR_Classifier.Name";
            this.cmbTypePlomb.FormattingEnabled = true;
            this.cmbTypePlomb.Location = new System.Drawing.Point(111, 19);
            this.cmbTypePlomb.Name = "cmbTypePlomb";
            this.cmbTypePlomb.Size = new System.Drawing.Size(121, 21);
            this.cmbTypePlomb.TabIndex = 1;
            this.cmbTypePlomb.ValueMember = "tR_Classifier.Id";
            // 
            // labelTypePlomb
            // 
            this.labelTypePlomb.AutoSize = true;
            this.labelTypePlomb.Location = new System.Drawing.Point(25, 22);
            this.labelTypePlomb.Name = "labelTypePlomb";
            this.labelTypePlomb.Size = new System.Drawing.Size(69, 13);
            this.labelTypePlomb.TabIndex = 0;
            this.labelTypePlomb.Text = "Тип пломбы";
            // 
            // maskedTextBoxNumberEnd
            // 
            this.maskedTextBoxNumberEnd.Enabled = false;
            this.maskedTextBoxNumberEnd.Location = new System.Drawing.Point(111, 144);
            this.maskedTextBoxNumberEnd.Mask = "0000000000";
            this.maskedTextBoxNumberEnd.Name = "maskedTextBoxNumberEnd";
            this.maskedTextBoxNumberEnd.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxNumberEnd.TabIndex = 10;
            this.maskedTextBoxNumberEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // maskedTextBoxNumberBeg
            // 
            this.maskedTextBoxNumberBeg.Enabled = false;
            this.maskedTextBoxNumberBeg.Location = new System.Drawing.Point(111, 125);
            this.maskedTextBoxNumberBeg.Mask = "0000000000";
            this.maskedTextBoxNumberBeg.Name = "maskedTextBoxNumberBeg";
            this.maskedTextBoxNumberBeg.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxNumberBeg.TabIndex = 9;
            this.maskedTextBoxNumberBeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioButtonDiapason
            // 
            this.radioButtonDiapason.AutoSize = true;
            this.radioButtonDiapason.Location = new System.Drawing.Point(28, 128);
            this.radioButtonDiapason.Name = "radioButtonDiapason";
            this.radioButtonDiapason.Size = new System.Drawing.Size(76, 17);
            this.radioButtonDiapason.TabIndex = 8;
            this.radioButtonDiapason.Text = "Диапазон";
            this.radioButtonDiapason.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(111, 99);
            this.maskedTextBoxNumber.Mask = "0000000000";
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(122, 20);
            this.maskedTextBoxNumber.TabIndex = 7;
            this.maskedTextBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radioButtonNumber
            // 
            this.radioButtonNumber.AutoSize = true;
            this.radioButtonNumber.Checked = true;
            this.radioButtonNumber.Location = new System.Drawing.Point(28, 99);
            this.radioButtonNumber.Name = "radioButtonNumber";
            this.radioButtonNumber.Size = new System.Drawing.Size(59, 17);
            this.radioButtonNumber.TabIndex = 6;
            this.radioButtonNumber.TabStop = true;
            this.radioButtonNumber.Text = "Номер";
            this.radioButtonNumber.UseVisualStyleBackColor = true;
            this.radioButtonNumber.CheckedChanged += new System.EventHandler(this.radioButtonNumber_CheckedChanged);
            // 
            // numericUpDownDigit
            // 
            this.numericUpDownDigit.Location = new System.Drawing.Point(111, 72);
            this.numericUpDownDigit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDigit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDigit.Name = "numericUpDownDigit";
            this.numericUpDownDigit.Size = new System.Drawing.Size(122, 20);
            this.numericUpDownDigit.TabIndex = 5;
            this.numericUpDownDigit.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDigit.ValueChanged += new System.EventHandler(this.numericUpDownDigit_ValueChanged);
            // 
            // labelDigit
            // 
            this.labelDigit.AutoSize = true;
            this.labelDigit.Location = new System.Drawing.Point(25, 74);
            this.labelDigit.Name = "labelDigit";
            this.labelDigit.Size = new System.Drawing.Size(44, 13);
            this.labelDigit.TabIndex = 4;
            this.labelDigit.Text = "Разряд";
            // 
            // txtSeria
            // 
            this.txtSeria.Enabled = false;
            this.txtSeria.Location = new System.Drawing.Point(111, 46);
            this.txtSeria.Name = "txtSeria";
            this.txtSeria.Size = new System.Drawing.Size(122, 20);
            this.txtSeria.TabIndex = 3;
            // 
            // checkBoxSeria
            // 
            this.checkBoxSeria.AutoSize = true;
            this.checkBoxSeria.Location = new System.Drawing.Point(28, 48);
            this.checkBoxSeria.Name = "checkBoxSeria";
            this.checkBoxSeria.Size = new System.Drawing.Size(57, 17);
            this.checkBoxSeria.TabIndex = 2;
            this.checkBoxSeria.Text = "Серия";
            this.checkBoxSeria.UseVisualStyleBackColor = true;
            this.checkBoxSeria.CheckedChanged += new System.EventHandler(this.checkBoxSeria_CheckedChanged);
            // 
            // labelDateinst
            // 
            this.labelDateinst.AutoSize = true;
            this.labelDateinst.Location = new System.Drawing.Point(13, 235);
            this.labelDateinst.Name = "labelDateinst";
            this.labelDateinst.Size = new System.Drawing.Size(33, 13);
            this.labelDateinst.TabIndex = 3;
            this.labelDateinst.Text = "Дата";
            // 
            // dateTimePickerDateInst
            // 
            this.dateTimePickerDateInst.Location = new System.Drawing.Point(80, 231);
            this.dateTimePickerDateInst.Name = "dateTimePickerDateInst";
            this.dateTimePickerDateInst.Size = new System.Drawing.Size(164, 20);
            this.dateTimePickerDateInst.TabIndex = 4;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 267);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(169, 267);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // dsPlomb
            // 
            this.dsPlomb.DataSetName = "DataSetPlomb";
            this.dsPlomb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormPlombAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(256, 302);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.dateTimePickerDateInst);
            this.Controls.Add(this.labelDateinst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbControler);
            this.Controls.Add(this.labelControler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPlombAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Выдача пломб";
            this.Load += new System.EventHandler(this.FormPlombAdd_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPlombAdd_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dsWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPlomb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelControler;
        private System.Windows.Forms.ComboBox cmbControler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.RadioButton radioButtonNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownDigit;
        private System.Windows.Forms.Label labelDigit;
        private System.Windows.Forms.TextBox txtSeria;
        private System.Windows.Forms.CheckBox checkBoxSeria;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberEnd;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberBeg;
        private System.Windows.Forms.RadioButton radioButtonDiapason;
        private System.Windows.Forms.Label labelDateinst;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateInst;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Data.DataSet dsWorker;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Windows.Forms.ComboBox cmbTypePlomb;
        private System.Windows.Forms.Label labelTypePlomb;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private Prv.DataSets.DataSetPlomb dsPlomb;
    }
}