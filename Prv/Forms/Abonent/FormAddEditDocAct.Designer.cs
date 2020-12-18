namespace Prv.Forms.Abonent
{
    partial class FormAddEditDocAct
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
            this.labelCodeAbonent = new System.Windows.Forms.Label();
            this.txtCodeAbonent = new System.Windows.Forms.TextBox();
            this.labelDateAct = new System.Windows.Forms.Label();
            this.dateTimePickerDateAct = new System.Windows.Forms.DateTimePicker();
            this.dsDocAct = new Prv.DataSets.DataSetPrv();
            this.cmbControler = new System.Windows.Forms.ComboBox();
            this.cmbTypeDoc = new System.Windows.Forms.ComboBox();
            this.txtIndicator = new System.Windows.Forms.TextBox();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.dsTopIndicator = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataTable4 = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.labelIndicator = new System.Windows.Forms.Label();
            this.labelTypeDoc = new System.Windows.Forms.Label();
            this.labelZone = new System.Windows.Forms.Label();
            this.labelControler = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.lbNumDoc = new System.Windows.Forms.Label();
            this.tbNumDoc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsDocAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCodeAbonent
            // 
            this.labelCodeAbonent.AutoSize = true;
            this.labelCodeAbonent.Location = new System.Drawing.Point(30, 15);
            this.labelCodeAbonent.Name = "labelCodeAbonent";
            this.labelCodeAbonent.Size = new System.Drawing.Size(79, 13);
            this.labelCodeAbonent.TabIndex = 16;
            this.labelCodeAbonent.Text = "Лицевой счет:";
            // 
            // txtCodeAbonent
            // 
            this.txtCodeAbonent.Location = new System.Drawing.Point(123, 12);
            this.txtCodeAbonent.Name = "txtCodeAbonent";
            this.txtCodeAbonent.ReadOnly = true;
            this.txtCodeAbonent.Size = new System.Drawing.Size(141, 20);
            this.txtCodeAbonent.TabIndex = 17;
            // 
            // labelDateAct
            // 
            this.labelDateAct.AutoSize = true;
            this.labelDateAct.Location = new System.Drawing.Point(73, 44);
            this.labelDateAct.Name = "labelDateAct";
            this.labelDateAct.Size = new System.Drawing.Size(36, 13);
            this.labelDateAct.TabIndex = 18;
            this.labelDateAct.Text = "Дата:";
            // 
            // dateTimePickerDateAct
            // 
            this.dateTimePickerDateAct.Checked = false;
            this.dateTimePickerDateAct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDocAct, "tDocAct.DateAct", true));
            this.dateTimePickerDateAct.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsDocAct, "tDocAct.DateAct", true));
            this.dateTimePickerDateAct.Location = new System.Drawing.Point(123, 38);
            this.dateTimePickerDateAct.Name = "dateTimePickerDateAct";
            this.dateTimePickerDateAct.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerDateAct.TabIndex = 19;
            this.dateTimePickerDateAct.ValueChanged += new System.EventHandler(this.dateTimePickerDateAct_ValueChanged);
            this.dateTimePickerDateAct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePickerDateAct_KeyDown);
            // 
            // dsDocAct
            // 
            this.dsDocAct.DataSetName = "DataSetPrv";
            this.dsDocAct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbControler
            // 
            this.cmbControler.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsDocAct, "tDocAct.IdWorker", true));
            this.cmbControler.DataSource = this.dsDocAct;
            this.cmbControler.DisplayMember = "vWorkerGroup.FIO";
            this.cmbControler.FormattingEnabled = true;
            this.cmbControler.Location = new System.Drawing.Point(123, 170);
            this.cmbControler.Name = "cmbControler";
            this.cmbControler.Size = new System.Drawing.Size(141, 21);
            this.cmbControler.TabIndex = 7;
            this.cmbControler.ValueMember = "vWorkerGroup.id";
            this.cmbControler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbControler_KeyDown);
            // 
            // cmbTypeDoc
            // 
            this.cmbTypeDoc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsDocAct, "tDocAct.idDocType", true));
            this.cmbTypeDoc.DataSource = this.dsDocAct;
            this.cmbTypeDoc.DisplayMember = "tR_Classifier.Name";
            this.cmbTypeDoc.FormattingEnabled = true;
            this.cmbTypeDoc.Location = new System.Drawing.Point(123, 116);
            this.cmbTypeDoc.Name = "cmbTypeDoc";
            this.cmbTypeDoc.Size = new System.Drawing.Size(141, 21);
            this.cmbTypeDoc.TabIndex = 3;
            this.cmbTypeDoc.ValueMember = "tR_Classifier.Id";
            this.cmbTypeDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbTypeDoc_KeyDown);
            // 
            // txtIndicator
            // 
            this.txtIndicator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDocAct, "tDocAct.ValueKWT", true));
            this.txtIndicator.Location = new System.Drawing.Point(123, 90);
            this.txtIndicator.Name = "txtIndicator";
            this.txtIndicator.Size = new System.Drawing.Size(141, 20);
            this.txtIndicator.TabIndex = 1;
            this.txtIndicator.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIndicator_KeyDown);
            // 
            // cmbZone
            // 
            this.cmbZone.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsDocAct, "tDocAct.IdZone", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cmbZone.DataSource = this.dsTopIndicator;
            this.cmbZone.DisplayMember = "vR_Zone.SubZoneName";
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(123, 143);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(141, 21);
            this.cmbZone.TabIndex = 5;
            this.cmbZone.ValueMember = "vR_Zone.IdSubZoneName";
            this.cmbZone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbZone_KeyDown);
            // 
            // dsTopIndicator
            // 
            this.dsTopIndicator.DataSetName = "NewDataSet";
            this.dsTopIndicator.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2,
            this.dataTable4});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn3});
            this.dataTable1.TableName = "tPointReg";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "idMark";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "idZone";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn2});
            this.dataTable2.TableName = "tR_MarkMeter";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Digit";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataTable4
            // 
            this.dataTable4.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn6,
            this.dataColumn7});
            this.dataTable4.TableName = "vR_Zone";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "IdSubZoneName";
            this.dataColumn6.DataType = typeof(int);
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "SubZoneName";
            // 
            // txtSize
            // 
            this.txtSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDocAct, "tDocAct.SizeKWT", true));
            this.txtSize.Location = new System.Drawing.Point(123, 197);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(141, 20);
            this.txtSize.TabIndex = 9;
            this.txtSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSize_KeyDown);
            // 
            // txtMoney
            // 
            this.txtMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDocAct, "tDocAct.ValueMoney", true));
            this.txtMoney.Location = new System.Drawing.Point(123, 223);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(141, 20);
            this.txtMoney.TabIndex = 11;
            this.txtMoney.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMoney_KeyDown);
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDocAct, "tDocAct.Comment", true));
            this.richTextBoxComment.Location = new System.Drawing.Point(123, 249);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(141, 69);
            this.richTextBoxComment.TabIndex = 13;
            this.richTextBoxComment.Text = "";
            // 
            // labelIndicator
            // 
            this.labelIndicator.AutoSize = true;
            this.labelIndicator.Location = new System.Drawing.Point(43, 93);
            this.labelIndicator.Name = "labelIndicator";
            this.labelIndicator.Size = new System.Drawing.Size(66, 13);
            this.labelIndicator.TabIndex = 0;
            this.labelIndicator.Text = "Показание:";
            // 
            // labelTypeDoc
            // 
            this.labelTypeDoc.AutoSize = true;
            this.labelTypeDoc.Location = new System.Drawing.Point(23, 119);
            this.labelTypeDoc.Name = "labelTypeDoc";
            this.labelTypeDoc.Size = new System.Drawing.Size(86, 13);
            this.labelTypeDoc.TabIndex = 2;
            this.labelTypeDoc.Text = "Тип документа:";
            // 
            // labelZone
            // 
            this.labelZone.AutoSize = true;
            this.labelZone.Location = new System.Drawing.Point(15, 146);
            this.labelZone.Name = "labelZone";
            this.labelZone.Size = new System.Drawing.Size(94, 13);
            this.labelZone.TabIndex = 4;
            this.labelZone.Text = "Временная зона:";
            // 
            // labelControler
            // 
            this.labelControler.AutoSize = true;
            this.labelControler.Location = new System.Drawing.Point(45, 173);
            this.labelControler.Name = "labelControler";
            this.labelControler.Size = new System.Drawing.Size(64, 13);
            this.labelControler.TabIndex = 6;
            this.labelControler.Text = "Контролер:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(19, 200);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(90, 13);
            this.labelSize.TabIndex = 8;
            this.labelSize.Text = "Объем (кВт*час)";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(42, 226);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(67, 13);
            this.labelMoney.TabIndex = 10;
            this.labelMoney.Text = "Сумма (руб)";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(29, 252);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(80, 13);
            this.labelComment.TabIndex = 12;
            this.labelComment.Text = "Комментарий:";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(12, 324);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 14;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(189, 324);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // lbNumDoc
            // 
            this.lbNumDoc.AutoSize = true;
            this.lbNumDoc.Location = new System.Drawing.Point(31, 67);
            this.lbNumDoc.Name = "lbNumDoc";
            this.lbNumDoc.Size = new System.Drawing.Size(78, 13);
            this.lbNumDoc.TabIndex = 20;
            this.lbNumDoc.Text = "№ документа:";
            // 
            // tbNumDoc
            // 
            this.tbNumDoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDocAct, "tDocAct.DocNumber", true));
            this.tbNumDoc.Location = new System.Drawing.Point(123, 64);
            this.tbNumDoc.Name = "tbNumDoc";
            this.tbNumDoc.Size = new System.Drawing.Size(141, 20);
            this.tbNumDoc.TabIndex = 21;
            // 
            // FormAddEditDocAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(276, 356);
            this.Controls.Add(this.lbNumDoc);
            this.Controls.Add(this.tbNumDoc);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelControler);
            this.Controls.Add(this.labelZone);
            this.Controls.Add(this.labelTypeDoc);
            this.Controls.Add(this.labelIndicator);
            this.Controls.Add(this.richTextBoxComment);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.cmbZone);
            this.Controls.Add(this.txtIndicator);
            this.Controls.Add(this.cmbTypeDoc);
            this.Controls.Add(this.cmbControler);
            this.Controls.Add(this.dateTimePickerDateAct);
            this.Controls.Add(this.labelDateAct);
            this.Controls.Add(this.txtCodeAbonent);
            this.Controls.Add(this.labelCodeAbonent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEditDocAct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddEditDocAct";
            this.Load += new System.EventHandler(this.FormAddEditDocAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDocAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTopIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodeAbonent;
        private System.Windows.Forms.TextBox txtCodeAbonent;
        private System.Windows.Forms.Label labelDateAct;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateAct;
        private System.Windows.Forms.ComboBox cmbControler;
        private System.Windows.Forms.ComboBox cmbTypeDoc;
        private System.Windows.Forms.TextBox txtIndicator;
        private System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.Label labelIndicator;
        private System.Windows.Forms.Label labelTypeDoc;
        private System.Windows.Forms.Label labelZone;
        private System.Windows.Forms.Label labelControler;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private Prv.DataSets.DataSetPrv dsDocAct;
        private System.Data.DataSet dsTopIndicator;
        private System.Data.DataTable dataTable1;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataTable dataTable4;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Windows.Forms.Label lbNumDoc;
        private System.Windows.Forms.TextBox tbNumDoc;
    }
}