namespace Legal.Forms.Export
{
    partial class FormExportNewAbn
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
            this.dgvAbn = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSelectAbn = new System.Windows.Forms.Button();
            this.btnExportAbn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.saveFileDialogExport = new System.Windows.Forms.SaveFileDialog();
            this.cbDirect = new System.Windows.Forms.CheckBox();
            this.bindingSourceAbn = new System.Windows.Forms.BindingSource(this.components);
            this.dsCalc1 = new Legal.DataSet.dsCalc();
            this.SelectCell = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.abnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abnCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numDogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rschDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankNamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kschDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bIKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrcodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrNanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oTRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abnOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtPayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAbn
            // 
            this.dgvAbn.AllowUserToAddRows = false;
            this.dgvAbn.AllowUserToDeleteRows = false;
            this.dgvAbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAbn.AutoGenerateColumns = false;
            this.dgvAbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectCell,
            this.abnID,
            this.abnCodeDataGridViewTextBoxColumn,
            this.fullNamDataGridViewTextBoxColumn,
            this.numDogDataGridViewTextBoxColumn,
            this.shortNameDataGridViewTextBoxColumn,
            this.iNN,
            this.typeOrgDataGridViewTextBoxColumn,
            this.budgDataGridViewTextBoxColumn,
            this.rschDataGridViewTextBoxColumn,
            this.bankNamDataGridViewTextBoxColumn,
            this.kschDataGridViewTextBoxColumn,
            this.bIKDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.contrcodDataGridViewTextBoxColumn,
            this.contrNanDataGridViewTextBoxColumn,
            this.oTRDataGridViewTextBoxColumn,
            this.altNameDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.dogDateDataGridViewTextBoxColumn,
            this.postDataGridViewTextBoxColumn,
            this.abnOwnerDataGridViewTextBoxColumn,
            this.dtPayDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.dateCommandDataGridViewTextBoxColumn});
            this.dgvAbn.DataSource = this.bindingSourceAbn;
            this.dgvAbn.Location = new System.Drawing.Point(180, 0);
            this.dgvAbn.MultiSelect = false;
            this.dgvAbn.Name = "dgvAbn";
            this.dgvAbn.RowHeadersWidth = 5;
            this.dgvAbn.Size = new System.Drawing.Size(689, 516);
            this.dgvAbn.TabIndex = 0;
            this.dgvAbn.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dgvAbn_RowStateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "с:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "по:";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(40, 79);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 37;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(40, 50);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Выберите период:";
            // 
            // btnSelectAbn
            // 
            this.btnSelectAbn.Location = new System.Drawing.Point(17, 193);
            this.btnSelectAbn.Name = "btnSelectAbn";
            this.btnSelectAbn.Size = new System.Drawing.Size(154, 23);
            this.btnSelectAbn.TabIndex = 86;
            this.btnSelectAbn.Text = "Сформировать";
            this.btnSelectAbn.UseVisualStyleBackColor = true;
            this.btnSelectAbn.Click += new System.EventHandler(this.btnSelectAbn_Click);
            // 
            // btnExportAbn
            // 
            this.btnExportAbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportAbn.Location = new System.Drawing.Point(373, 531);
            this.btnExportAbn.Name = "btnExportAbn";
            this.btnExportAbn.Size = new System.Drawing.Size(159, 23);
            this.btnExportAbn.TabIndex = 87;
            this.btnExportAbn.Text = "Экспорт";
            this.btnExportAbn.UseVisualStyleBackColor = true;
            this.btnExportAbn.Click += new System.EventHandler(this.btnExportAbn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(698, 531);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 23);
            this.btnExit.TabIndex = 88;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFile.AutoEllipsis = true;
            this.buttonFile.Location = new System.Drawing.Point(330, 531);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(20, 20);
            this.buttonFile.TabIndex = 100;
            this.buttonFile.Text = "...";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFile.Location = new System.Drawing.Point(17, 531);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.ReadOnly = true;
            this.textBoxFile.Size = new System.Drawing.Size(293, 20);
            this.textBoxFile.TabIndex = 99;
            // 
            // cbDirect
            // 
            this.cbDirect.AutoSize = true;
            this.cbDirect.Location = new System.Drawing.Point(17, 134);
            this.cbDirect.Name = "cbDirect";
            this.cbDirect.Size = new System.Drawing.Size(154, 17);
            this.cbDirect.TabIndex = 102;
            this.cbDirect.Text = "только прямые договора";
            this.cbDirect.UseVisualStyleBackColor = true;
            // 
            // bindingSourceAbn
            // 
            this.bindingSourceAbn.DataMember = "vG_Abn1C_Selected";
            this.bindingSourceAbn.DataSource = this.dsCalc1;
            // 
            // dsCalc1
            // 
            this.dsCalc1.DataSetName = "dsCalc";
            this.dsCalc1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SelectCell
            // 
            this.SelectCell.HeaderText = "Выбор";
            this.SelectCell.Name = "SelectCell";
            this.SelectCell.Width = 46;
            // 
            // abnID
            // 
            this.abnID.DataPropertyName = "AbnID";
            this.abnID.HeaderText = "AbnID";
            this.abnID.Name = "abnID";
            this.abnID.ReadOnly = true;
            this.abnID.Visible = false;
            this.abnID.Width = 62;
            // 
            // abnCodeDataGridViewTextBoxColumn
            // 
            this.abnCodeDataGridViewTextBoxColumn.DataPropertyName = "AbnCode";
            this.abnCodeDataGridViewTextBoxColumn.HeaderText = "Код";
            this.abnCodeDataGridViewTextBoxColumn.Name = "abnCodeDataGridViewTextBoxColumn";
            this.abnCodeDataGridViewTextBoxColumn.Width = 60;
            // 
            // fullNamDataGridViewTextBoxColumn
            // 
            this.fullNamDataGridViewTextBoxColumn.DataPropertyName = "FullNam";
            this.fullNamDataGridViewTextBoxColumn.HeaderText = "FullNam";
            this.fullNamDataGridViewTextBoxColumn.Name = "fullNamDataGridViewTextBoxColumn";
            this.fullNamDataGridViewTextBoxColumn.Visible = false;
            this.fullNamDataGridViewTextBoxColumn.Width = 70;
            // 
            // numDogDataGridViewTextBoxColumn
            // 
            this.numDogDataGridViewTextBoxColumn.DataPropertyName = "NumDog";
            this.numDogDataGridViewTextBoxColumn.HeaderText = "NumDog";
            this.numDogDataGridViewTextBoxColumn.Name = "numDogDataGridViewTextBoxColumn";
            this.numDogDataGridViewTextBoxColumn.Visible = false;
            this.numDogDataGridViewTextBoxColumn.Width = 74;
            // 
            // shortNameDataGridViewTextBoxColumn
            // 
            this.shortNameDataGridViewTextBoxColumn.DataPropertyName = "ShortName";
            this.shortNameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.shortNameDataGridViewTextBoxColumn.Name = "shortNameDataGridViewTextBoxColumn";
            this.shortNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // iNN
            // 
            this.iNN.DataPropertyName = "INN";
            this.iNN.HeaderText = "ИНН";
            this.iNN.Name = "iNN";
            this.iNN.ReadOnly = true;
            this.iNN.Width = 90;
            // 
            // typeOrgDataGridViewTextBoxColumn
            // 
            this.typeOrgDataGridViewTextBoxColumn.DataPropertyName = "TypeOrg";
            this.typeOrgDataGridViewTextBoxColumn.HeaderText = "TypeOrg";
            this.typeOrgDataGridViewTextBoxColumn.Name = "typeOrgDataGridViewTextBoxColumn";
            this.typeOrgDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeOrgDataGridViewTextBoxColumn.Visible = false;
            this.typeOrgDataGridViewTextBoxColumn.Width = 73;
            // 
            // budgDataGridViewTextBoxColumn
            // 
            this.budgDataGridViewTextBoxColumn.DataPropertyName = "Budg";
            this.budgDataGridViewTextBoxColumn.HeaderText = "Budg";
            this.budgDataGridViewTextBoxColumn.Name = "budgDataGridViewTextBoxColumn";
            this.budgDataGridViewTextBoxColumn.ReadOnly = true;
            this.budgDataGridViewTextBoxColumn.Visible = false;
            this.budgDataGridViewTextBoxColumn.Width = 57;
            // 
            // rschDataGridViewTextBoxColumn
            // 
            this.rschDataGridViewTextBoxColumn.DataPropertyName = "Rsch";
            this.rschDataGridViewTextBoxColumn.HeaderText = "Rsch";
            this.rschDataGridViewTextBoxColumn.Name = "rschDataGridViewTextBoxColumn";
            this.rschDataGridViewTextBoxColumn.Visible = false;
            this.rschDataGridViewTextBoxColumn.Width = 57;
            // 
            // bankNamDataGridViewTextBoxColumn
            // 
            this.bankNamDataGridViewTextBoxColumn.DataPropertyName = "BankNam";
            this.bankNamDataGridViewTextBoxColumn.HeaderText = "BankNam";
            this.bankNamDataGridViewTextBoxColumn.Name = "bankNamDataGridViewTextBoxColumn";
            this.bankNamDataGridViewTextBoxColumn.Visible = false;
            this.bankNamDataGridViewTextBoxColumn.Width = 79;
            // 
            // kschDataGridViewTextBoxColumn
            // 
            this.kschDataGridViewTextBoxColumn.DataPropertyName = "Ksch";
            this.kschDataGridViewTextBoxColumn.HeaderText = "Ksch";
            this.kschDataGridViewTextBoxColumn.Name = "kschDataGridViewTextBoxColumn";
            this.kschDataGridViewTextBoxColumn.Visible = false;
            this.kschDataGridViewTextBoxColumn.Width = 56;
            // 
            // bIKDataGridViewTextBoxColumn
            // 
            this.bIKDataGridViewTextBoxColumn.DataPropertyName = "BIK";
            this.bIKDataGridViewTextBoxColumn.HeaderText = "BIK";
            this.bIKDataGridViewTextBoxColumn.Name = "bIKDataGridViewTextBoxColumn";
            this.bIKDataGridViewTextBoxColumn.Visible = false;
            this.bIKDataGridViewTextBoxColumn.Width = 49;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Visible = false;
            this.cityDataGridViewTextBoxColumn.Width = 49;
            // 
            // contrcodDataGridViewTextBoxColumn
            // 
            this.contrcodDataGridViewTextBoxColumn.DataPropertyName = "Contrcod";
            this.contrcodDataGridViewTextBoxColumn.HeaderText = "Contrcod";
            this.contrcodDataGridViewTextBoxColumn.Name = "contrcodDataGridViewTextBoxColumn";
            this.contrcodDataGridViewTextBoxColumn.Visible = false;
            this.contrcodDataGridViewTextBoxColumn.Width = 75;
            // 
            // contrNanDataGridViewTextBoxColumn
            // 
            this.contrNanDataGridViewTextBoxColumn.DataPropertyName = "ContrNan";
            this.contrNanDataGridViewTextBoxColumn.HeaderText = "ContrNan";
            this.contrNanDataGridViewTextBoxColumn.Name = "contrNanDataGridViewTextBoxColumn";
            this.contrNanDataGridViewTextBoxColumn.Visible = false;
            this.contrNanDataGridViewTextBoxColumn.Width = 77;
            // 
            // oTRDataGridViewTextBoxColumn
            // 
            this.oTRDataGridViewTextBoxColumn.DataPropertyName = "OTR";
            this.oTRDataGridViewTextBoxColumn.HeaderText = "OTR";
            this.oTRDataGridViewTextBoxColumn.Name = "oTRDataGridViewTextBoxColumn";
            this.oTRDataGridViewTextBoxColumn.ReadOnly = true;
            this.oTRDataGridViewTextBoxColumn.Visible = false;
            this.oTRDataGridViewTextBoxColumn.Width = 55;
            // 
            // altNameDataGridViewTextBoxColumn
            // 
            this.altNameDataGridViewTextBoxColumn.DataPropertyName = "AltName";
            this.altNameDataGridViewTextBoxColumn.HeaderText = "AltName";
            this.altNameDataGridViewTextBoxColumn.Name = "altNameDataGridViewTextBoxColumn";
            this.altNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.altNameDataGridViewTextBoxColumn.Visible = false;
            this.altNameDataGridViewTextBoxColumn.Width = 72;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.Visible = false;
            this.streetDataGridViewTextBoxColumn.Width = 60;
            // 
            // dogDateDataGridViewTextBoxColumn
            // 
            this.dogDateDataGridViewTextBoxColumn.DataPropertyName = "DogDate";
            this.dogDateDataGridViewTextBoxColumn.HeaderText = "Договор";
            this.dogDateDataGridViewTextBoxColumn.Name = "dogDateDataGridViewTextBoxColumn";
            this.dogDateDataGridViewTextBoxColumn.Width = 80;
            // 
            // postDataGridViewTextBoxColumn
            // 
            this.postDataGridViewTextBoxColumn.DataPropertyName = "Post";
            this.postDataGridViewTextBoxColumn.HeaderText = "Post";
            this.postDataGridViewTextBoxColumn.Name = "postDataGridViewTextBoxColumn";
            this.postDataGridViewTextBoxColumn.Visible = false;
            this.postDataGridViewTextBoxColumn.Width = 53;
            // 
            // abnOwnerDataGridViewTextBoxColumn
            // 
            this.abnOwnerDataGridViewTextBoxColumn.DataPropertyName = "AbnOwner";
            this.abnOwnerDataGridViewTextBoxColumn.HeaderText = "AbnOwner";
            this.abnOwnerDataGridViewTextBoxColumn.Name = "abnOwnerDataGridViewTextBoxColumn";
            this.abnOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            this.abnOwnerDataGridViewTextBoxColumn.Visible = false;
            this.abnOwnerDataGridViewTextBoxColumn.Width = 82;
            // 
            // dtPayDataGridViewTextBoxColumn
            // 
            this.dtPayDataGridViewTextBoxColumn.DataPropertyName = "dtPay";
            this.dtPayDataGridViewTextBoxColumn.HeaderText = "dtPay";
            this.dtPayDataGridViewTextBoxColumn.Name = "dtPayDataGridViewTextBoxColumn";
            this.dtPayDataGridViewTextBoxColumn.ReadOnly = true;
            this.dtPayDataGridViewTextBoxColumn.Visible = false;
            this.dtPayDataGridViewTextBoxColumn.Width = 59;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Специалист";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // dateCommandDataGridViewTextBoxColumn
            // 
            this.dateCommandDataGridViewTextBoxColumn.DataPropertyName = "DateCommand";
            this.dateCommandDataGridViewTextBoxColumn.HeaderText = "Дата ввода";
            this.dateCommandDataGridViewTextBoxColumn.Name = "dateCommandDataGridViewTextBoxColumn";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 275);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(154, 48);
            this.richTextBox1.TabIndex = 103;
            this.richTextBox1.Text = "Для экспорта потребителя нужен корректный ИНН.";
            // 
            // FormExportNewAbn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 563);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.cbDirect);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExportAbn);
            this.Controls.Add(this.btnSelectAbn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtBegin);
            this.Controls.Add(this.dgvAbn);
            this.Name = "FormExportNewAbn";
            this.Text = "Экспорт новых потребителей в 1С";
            this.Load += new System.EventHandler(this.FormExportNewAbn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCalc1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAbn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSelectAbn;
        private System.Windows.Forms.Button btnExportAbn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExport;
        private DataSet.dsCalc dsCalc1;
        private System.Windows.Forms.BindingSource bindingSourceAbn;
        private System.Windows.Forms.CheckBox cbDirect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectCell;
        private System.Windows.Forms.DataGridViewTextBoxColumn abnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn abnCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNN;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn budgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rschDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankNamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kschDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bIKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrcodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrNanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oTRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn abnOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtPayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCommandDataGridViewTextBoxColumn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}