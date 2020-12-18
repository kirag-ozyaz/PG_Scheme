namespace Legal.Forms.FormRep
{
    partial class FormNotification
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vG_AbnDogDetailsDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsAbn = new Legal.DataSet.DataSetAbn();
            this.bsAbnDog = new System.Windows.Forms.BindingSource(this.components);
            this.checkedListBoxController = new System.Windows.Forms.CheckedListBox();
            this.lbSignature = new System.Windows.Forms.Label();
            this.cbSignature = new System.Windows.Forms.ComboBox();
            this.lbDogDate = new System.Windows.Forms.Label();
            this.lbPrilDate = new System.Windows.Forms.Label();
            this.dtpDogDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPrilDate = new System.Windows.Forms.DateTimePicker();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.reportViewerNotification = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsAbnContact1 = new Legal.DataSet.dsAbnContact();
            this.DGVEFdogdetails = new ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter();
            this.codeAbonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idWorkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSeason = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDogovor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vG_AbnDogDetailsDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnContact1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEFdogdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // vG_AbnDogDetailsDataTableBindingSource
            // 
            this.vG_AbnDogDetailsDataTableBindingSource.DataMember = "vG_AbnDogDetails";
            this.vG_AbnDogDetailsDataTableBindingSource.DataSource = this.dsAbn;
            // 
            // dsAbn
            // 
            this.dsAbn.DataSetName = "DataSetAbn";
            this.dsAbn.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsAbnDog
            // 
            this.bsAbnDog.DataMember = "vG_AbnDogDetails";
            this.bsAbnDog.DataSource = this.dsAbn;
            // 
            // checkedListBoxController
            // 
            this.checkedListBoxController.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxController.FormattingEnabled = true;
            this.checkedListBoxController.Location = new System.Drawing.Point(650, 12);
            this.checkedListBoxController.Name = "checkedListBoxController";
            this.checkedListBoxController.Size = new System.Drawing.Size(188, 214);
            this.checkedListBoxController.TabIndex = 1;
            // 
            // lbSignature
            // 
            this.lbSignature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSignature.AutoSize = true;
            this.lbSignature.Location = new System.Drawing.Point(647, 313);
            this.lbSignature.Name = "lbSignature";
            this.lbSignature.Size = new System.Drawing.Size(51, 13);
            this.lbSignature.TabIndex = 12;
            this.lbSignature.Text = "Подпись";
            // 
            // cbSignature
            // 
            this.cbSignature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSignature.FormattingEnabled = true;
            this.cbSignature.Items.AddRange(new object[] {
            "И.А.Гулько"});
            this.cbSignature.Location = new System.Drawing.Point(681, 329);
            this.cbSignature.Name = "cbSignature";
            this.cbSignature.Size = new System.Drawing.Size(157, 21);
            this.cbSignature.TabIndex = 11;
            // 
            // lbDogDate
            // 
            this.lbDogDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDogDate.AutoSize = true;
            this.lbDogDate.Location = new System.Drawing.Point(647, 274);
            this.lbDogDate.Name = "lbDogDate";
            this.lbDogDate.Size = new System.Drawing.Size(83, 13);
            this.lbDogDate.TabIndex = 10;
            this.lbDogDate.Text = "Дата договора";
            // 
            // lbPrilDate
            // 
            this.lbPrilDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPrilDate.AutoSize = true;
            this.lbPrilDate.Location = new System.Drawing.Point(647, 235);
            this.lbPrilDate.Name = "lbPrilDate";
            this.lbPrilDate.Size = new System.Drawing.Size(98, 13);
            this.lbPrilDate.TabIndex = 9;
            this.lbPrilDate.Text = "Дата приложения";
            // 
            // dtpDogDate
            // 
            this.dtpDogDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDogDate.Location = new System.Drawing.Point(681, 290);
            this.dtpDogDate.Name = "dtpDogDate";
            this.dtpDogDate.Size = new System.Drawing.Size(157, 20);
            this.dtpDogDate.TabIndex = 8;
            // 
            // dtpPrilDate
            // 
            this.dtpPrilDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPrilDate.Location = new System.Drawing.Point(681, 251);
            this.dtpPrilDate.Name = "dtpPrilDate";
            this.dtpPrilDate.Size = new System.Drawing.Size(157, 20);
            this.dtpPrilDate.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(681, 517);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(157, 23);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Location = new System.Drawing.Point(681, 488);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(157, 23);
            this.buttonCreate.TabIndex = 15;
            this.buttonCreate.Text = "Сформировать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // reportViewerNotification
            // 
            this.reportViewerNotification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DogDetailes";
            reportDataSource1.Value = this.vG_AbnDogDetailsDataTableBindingSource;
            this.reportViewerNotification.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerNotification.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportNotification.rdlc";
            this.reportViewerNotification.Location = new System.Drawing.Point(13, 256);
            this.reportViewerNotification.Name = "reportViewerNotification";
            this.reportViewerNotification.Size = new System.Drawing.Size(628, 285);
            this.reportViewerNotification.TabIndex = 16;
            this.reportViewerNotification.Load += new System.EventHandler(this.reportViewerNotification_Load);
            // 
            // dsAbnContact1
            // 
            this.dsAbnContact1.DataSetName = "dsAbnContact";
            this.dsAbnContact1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DGVEFdogdetails
            // 
            this.DGVEFdogdetails.AllowUserToAddRows = false;
            this.DGVEFdogdetails.AllowUserToDeleteRows = false;
            this.DGVEFdogdetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVEFdogdetails.AutoGenerateColumns = false;
            this.DGVEFdogdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEFdogdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeAbonentDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.idWorkerDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.docNumberDataGridViewTextBoxColumn,
            this.docDateDataGridViewTextBoxColumn,
            this.idDocTypeDataGridViewTextBoxColumn});
            this.DGVEFdogdetails.DataSource = this.bsAbnDog;
            this.DGVEFdogdetails.Location = new System.Drawing.Point(13, 12);
            this.DGVEFdogdetails.Name = "DGVEFdogdetails";
            this.DGVEFdogdetails.ReadOnly = true;
            this.DGVEFdogdetails.RowHeadersWidth = 5;
            this.DGVEFdogdetails.Size = new System.Drawing.Size(628, 238);
            this.DGVEFdogdetails.TabIndex = 17;
            // 
            // codeAbonentDataGridViewTextBoxColumn
            // 
            this.codeAbonentDataGridViewTextBoxColumn.DataPropertyName = "CodeAbonent";
            this.codeAbonentDataGridViewTextBoxColumn.HeaderText = "№ договора";
            this.codeAbonentDataGridViewTextBoxColumn.Name = "codeAbonentDataGridViewTextBoxColumn";
            this.codeAbonentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // idWorkerDataGridViewTextBoxColumn
            // 
            this.idWorkerDataGridViewTextBoxColumn.DataPropertyName = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn.HeaderText = "idWorker";
            this.idWorkerDataGridViewTextBoxColumn.Name = "idWorkerDataGridViewTextBoxColumn";
            this.idWorkerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idWorkerDataGridViewTextBoxColumn.Visible = false;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "Специалист";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // docNumberDataGridViewTextBoxColumn
            // 
            this.docNumberDataGridViewTextBoxColumn.DataPropertyName = "DocNumber";
            this.docNumberDataGridViewTextBoxColumn.HeaderText = "DocNumber";
            this.docNumberDataGridViewTextBoxColumn.Name = "docNumberDataGridViewTextBoxColumn";
            this.docNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.docNumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // docDateDataGridViewTextBoxColumn
            // 
            this.docDateDataGridViewTextBoxColumn.DataPropertyName = "DocDate";
            this.docDateDataGridViewTextBoxColumn.HeaderText = "Дата договора";
            this.docDateDataGridViewTextBoxColumn.Name = "docDateDataGridViewTextBoxColumn";
            this.docDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.docDateDataGridViewTextBoxColumn.Width = 120;
            // 
            // idDocTypeDataGridViewTextBoxColumn
            // 
            this.idDocTypeDataGridViewTextBoxColumn.DataPropertyName = "idDocType";
            this.idDocTypeDataGridViewTextBoxColumn.HeaderText = "idDocType";
            this.idDocTypeDataGridViewTextBoxColumn.Name = "idDocTypeDataGridViewTextBoxColumn";
            this.idDocTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDocTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(647, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Сезон";
            // 
            // cbSeason
            // 
            this.cbSeason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSeason.FormattingEnabled = true;
            this.cbSeason.Items.AddRange(new object[] {
            "декабря",
            "июня"});
            this.cbSeason.Location = new System.Drawing.Point(681, 369);
            this.cbSeason.Name = "cbSeason";
            this.cbSeason.Size = new System.Drawing.Size(157, 21);
            this.cbSeason.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(647, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Тип договора";
            // 
            // cmbDogovor
            // 
            this.cmbDogovor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDogovor.FormattingEnabled = true;
            this.cmbDogovor.Items.AddRange(new object[] {
            "Договор по передаче",
            "Договор энергоснабжения",
            "Все договора"});
            this.cmbDogovor.Location = new System.Drawing.Point(681, 409);
            this.cmbDogovor.Name = "cmbDogovor";
            this.cmbDogovor.Size = new System.Drawing.Size(157, 21);
            this.cmbDogovor.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Телефон";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.Location = new System.Drawing.Point(681, 449);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(157, 20);
            this.txtPhone.TabIndex = 23;
            // 
            // FormNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 553);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbDogovor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSeason);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVEFdogdetails);
            this.Controls.Add(this.reportViewerNotification);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.lbSignature);
            this.Controls.Add(this.cbSignature);
            this.Controls.Add(this.lbDogDate);
            this.Controls.Add(this.lbPrilDate);
            this.Controls.Add(this.dtpDogDate);
            this.Controls.Add(this.dtpPrilDate);
            this.Controls.Add(this.checkedListBoxController);
            this.Name = "FormNotification";
            this.Text = "Уведомления";
            this.Load += new System.EventHandler(this.FormNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vG_AbnDogDetailsDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAbnDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAbnContact1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEFdogdetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxController;
        private System.Windows.Forms.Label lbSignature;
        private System.Windows.Forms.ComboBox cbSignature;
        private System.Windows.Forms.Label lbDogDate;
        private System.Windows.Forms.Label lbPrilDate;
        private System.Windows.Forms.DateTimePicker dtpDogDate;
        private System.Windows.Forms.DateTimePicker dtpPrilDate;
        private System.Windows.Forms.BindingSource bsAbnDog;
        private DataSet.DataSetAbn dsAbn;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCreate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerNotification;
        private DataSet.dsAbnContact dsAbnContact1;
        private ControlsLbr.DataGridViewExcelFilter.DataGridViewExcelFilter DGVEFdogdetails;
        private System.Windows.Forms.BindingSource vG_AbnDogDetailsDataTableBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSeason;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAbonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idWorkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDogovor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
    }
}