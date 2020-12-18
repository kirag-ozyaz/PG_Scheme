namespace Prv.Forms.Abonent
{
    partial class FormAddEditDocOpl
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelZone = new System.Windows.Forms.Label();
            this.labelTypeDoc = new System.Windows.Forms.Label();
            this.labelIndicator = new System.Windows.Forms.Label();
            this.richTextBoxComment = new System.Windows.Forms.RichTextBox();
            this.dsDocOpl = new Prv.DataSets.DataSetPrv();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.cmbZone = new System.Windows.Forms.ComboBox();
            this.dsReference = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataTable4 = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.txtIndicator = new System.Windows.Forms.TextBox();
            this.cmbTypeDoc = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDateAct = new System.Windows.Forms.DateTimePicker();
            this.labelDateAct = new System.Windows.Forms.Label();
            this.txtCodeAbonent = new System.Windows.Forms.TextBox();
            this.labelCodeAbonent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsDocOpl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(190, 264);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 35;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(13, 264);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 34;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(30, 192);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(80, 13);
            this.labelComment.TabIndex = 32;
            this.labelComment.Text = "Комментарий:";
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Location = new System.Drawing.Point(43, 166);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(67, 13);
            this.labelMoney.TabIndex = 30;
            this.labelMoney.Text = "Сумма (руб)";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(20, 140);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(90, 13);
            this.labelSize.TabIndex = 28;
            this.labelSize.Text = "Объем (кВт*час)";
            // 
            // labelZone
            // 
            this.labelZone.AutoSize = true;
            this.labelZone.Location = new System.Drawing.Point(16, 114);
            this.labelZone.Name = "labelZone";
            this.labelZone.Size = new System.Drawing.Size(94, 13);
            this.labelZone.TabIndex = 24;
            this.labelZone.Text = "Временная зона:";
            // 
            // labelTypeDoc
            // 
            this.labelTypeDoc.AutoSize = true;
            this.labelTypeDoc.Location = new System.Drawing.Point(24, 87);
            this.labelTypeDoc.Name = "labelTypeDoc";
            this.labelTypeDoc.Size = new System.Drawing.Size(86, 13);
            this.labelTypeDoc.TabIndex = 22;
            this.labelTypeDoc.Text = "Тип документа:";
            // 
            // labelIndicator
            // 
            this.labelIndicator.AutoSize = true;
            this.labelIndicator.Location = new System.Drawing.Point(44, 61);
            this.labelIndicator.Name = "labelIndicator";
            this.labelIndicator.Size = new System.Drawing.Size(66, 13);
            this.labelIndicator.TabIndex = 20;
            this.labelIndicator.Text = "Показание:";
            // 
            // richTextBoxComment
            // 
            this.richTextBoxComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDocOpl, "tDocOpl.Comment", true));
            this.richTextBoxComment.Location = new System.Drawing.Point(124, 189);
            this.richTextBoxComment.Name = "richTextBoxComment";
            this.richTextBoxComment.Size = new System.Drawing.Size(141, 69);
            this.richTextBoxComment.TabIndex = 33;
            this.richTextBoxComment.Text = "";
            // 
            // dsDocOpl
            // 
            this.dsDocOpl.DataSetName = "DataSetPrv";
            this.dsDocOpl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMoney
            // 
            this.txtMoney.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDocOpl, "tDocOpl.ValueMoney", true));
            this.txtMoney.Location = new System.Drawing.Point(124, 163);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(141, 20);
            this.txtMoney.TabIndex = 31;
            // 
            // txtSize
            // 
            this.txtSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDocOpl, "tDocOpl.SizeKWT", true));
            this.txtSize.Location = new System.Drawing.Point(124, 137);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(141, 20);
            this.txtSize.TabIndex = 29;
            // 
            // cmbZone
            // 
            this.cmbZone.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsDocOpl, "tDocOpl.IdZone", true));
            this.cmbZone.DataSource = this.dsReference;
            this.cmbZone.DisplayMember = "vR_Zone.SubZoneName";
            this.cmbZone.FormattingEnabled = true;
            this.cmbZone.Location = new System.Drawing.Point(124, 111);
            this.cmbZone.Name = "cmbZone";
            this.cmbZone.Size = new System.Drawing.Size(141, 21);
            this.cmbZone.TabIndex = 25;
            this.cmbZone.ValueMember = "vR_Zone.IdSubZoneName";
            // 
            // dsReference
            // 
            this.dsReference.DataSetName = "NewDataSet";
            this.dsReference.Tables.AddRange(new System.Data.DataTable[] {
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
            // txtIndicator
            // 
            this.txtIndicator.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDocOpl, "tDocOpl.ValueKWT", true));
            this.txtIndicator.Location = new System.Drawing.Point(124, 58);
            this.txtIndicator.Name = "txtIndicator";
            this.txtIndicator.Size = new System.Drawing.Size(141, 20);
            this.txtIndicator.TabIndex = 21;
            // 
            // cmbTypeDoc
            // 
            this.cmbTypeDoc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.dsDocOpl, "tDocOpl.idDocType", true));
            this.cmbTypeDoc.DataSource = this.dsDocOpl;
            this.cmbTypeDoc.DisplayMember = "tR_Classifier.Name";
            this.cmbTypeDoc.FormattingEnabled = true;
            this.cmbTypeDoc.Location = new System.Drawing.Point(124, 84);
            this.cmbTypeDoc.Name = "cmbTypeDoc";
            this.cmbTypeDoc.Size = new System.Drawing.Size(141, 21);
            this.cmbTypeDoc.TabIndex = 23;
            this.cmbTypeDoc.ValueMember = "tR_Classifier.Id";
            // 
            // dateTimePickerDateAct
            // 
            this.dateTimePickerDateAct.Checked = false;
            this.dateTimePickerDateAct.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dsDocOpl, "tDocOpl.DateOpl", true));
            this.dateTimePickerDateAct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dsDocOpl, "tDocOpl.DateOpl", true));
            this.dateTimePickerDateAct.Location = new System.Drawing.Point(124, 32);
            this.dateTimePickerDateAct.Name = "dateTimePickerDateAct";
            this.dateTimePickerDateAct.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerDateAct.TabIndex = 39;
            // 
            // labelDateAct
            // 
            this.labelDateAct.AutoSize = true;
            this.labelDateAct.Location = new System.Drawing.Point(74, 38);
            this.labelDateAct.Name = "labelDateAct";
            this.labelDateAct.Size = new System.Drawing.Size(36, 13);
            this.labelDateAct.TabIndex = 38;
            this.labelDateAct.Text = "Дата:";
            // 
            // txtCodeAbonent
            // 
            this.txtCodeAbonent.Location = new System.Drawing.Point(124, 6);
            this.txtCodeAbonent.Name = "txtCodeAbonent";
            this.txtCodeAbonent.ReadOnly = true;
            this.txtCodeAbonent.Size = new System.Drawing.Size(141, 20);
            this.txtCodeAbonent.TabIndex = 37;
            // 
            // labelCodeAbonent
            // 
            this.labelCodeAbonent.AutoSize = true;
            this.labelCodeAbonent.Location = new System.Drawing.Point(31, 9);
            this.labelCodeAbonent.Name = "labelCodeAbonent";
            this.labelCodeAbonent.Size = new System.Drawing.Size(79, 13);
            this.labelCodeAbonent.TabIndex = 36;
            this.labelCodeAbonent.Text = "Лицевой счет:";
            // 
            // FormAddEditDocOpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(279, 300);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelZone);
            this.Controls.Add(this.labelTypeDoc);
            this.Controls.Add(this.labelIndicator);
            this.Controls.Add(this.richTextBoxComment);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.cmbZone);
            this.Controls.Add(this.txtIndicator);
            this.Controls.Add(this.cmbTypeDoc);
            this.Controls.Add(this.dateTimePickerDateAct);
            this.Controls.Add(this.labelDateAct);
            this.Controls.Add(this.txtCodeAbonent);
            this.Controls.Add(this.labelCodeAbonent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEditDocOpl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddEditDocOpl";
            this.Load += new System.EventHandler(this.FormAddEditDocOpl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsDocOpl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelZone;
        private System.Windows.Forms.Label labelTypeDoc;
        private System.Windows.Forms.Label labelIndicator;
        private System.Windows.Forms.RichTextBox richTextBoxComment;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.ComboBox cmbZone;
        private System.Windows.Forms.TextBox txtIndicator;
        private System.Windows.Forms.ComboBox cmbTypeDoc;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateAct;
        private System.Windows.Forms.Label labelDateAct;
        private System.Windows.Forms.TextBox txtCodeAbonent;
        private System.Windows.Forms.Label labelCodeAbonent;
        private System.Data.DataSet dsReference;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataTable dataTable4;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private Prv.DataSets.DataSetPrv dsDocOpl;
    }
}