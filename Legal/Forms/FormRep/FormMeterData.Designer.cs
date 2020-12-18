namespace Legal.Forms.FormRep
{
    partial class FormMeterData
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCntVal1 = new Legal.DataSet.dsCntVal();
            this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbtnTypeDocUser = new System.Windows.Forms.RadioButton();
            this.rbtnTypeDocCheck = new System.Windows.Forms.RadioButton();
            this.rbtnTypeDocAll = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnSortZone = new System.Windows.Forms.RadioButton();
            this.rbtnSortDate = new System.Windows.Forms.RadioButton();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "dtMeterData";
            this.bindingSource1.DataSource = this.dsCntVal1;
            // 
            // dsCntVal1
            // 
            this.dsCntVal1.DataSetName = "dsCntVal";
            this.dsCntVal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerRus1
            // 
            this.reportViewerRus1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsMeterData";
            reportDataSource1.Value = this.bindingSource1;
            reportDataSource2.Name = "dsMeter";
            reportDataSource2.Value = this.bindingSource2;
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportMeterData.rdlc";
            this.reportViewerRus1.Location = new System.Drawing.Point(-1, 110);
            this.reportViewerRus1.Name = "reportViewerRus1";
            this.reportViewerRus1.Size = new System.Drawing.Size(677, 430);
            this.reportViewerRus1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "с:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "по:";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(54, 59);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(131, 20);
            this.dtEnd.TabIndex = 37;
            // 
            // dtBegin
            // 
            this.dtBegin.Location = new System.Drawing.Point(54, 30);
            this.dtBegin.Name = "dtBegin";
            this.dtBegin.Size = new System.Drawing.Size(131, 20);
            this.dtBegin.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Период выборки показаний";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(588, 27);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 39;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(588, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Выход";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // rbtnTypeDocUser
            // 
            this.rbtnTypeDocUser.AutoSize = true;
            this.rbtnTypeDocUser.Checked = true;
            this.rbtnTypeDocUser.Location = new System.Drawing.Point(6, 18);
            this.rbtnTypeDocUser.Name = "rbtnTypeDocUser";
            this.rbtnTypeDocUser.Size = new System.Drawing.Size(160, 17);
            this.rbtnTypeDocUser.TabIndex = 41;
            this.rbtnTypeDocUser.TabStop = true;
            this.rbtnTypeDocUser.Text = "показания от потребителя";
            this.rbtnTypeDocUser.UseVisualStyleBackColor = true;
            // 
            // rbtnTypeDocCheck
            // 
            this.rbtnTypeDocCheck.AutoSize = true;
            this.rbtnTypeDocCheck.Location = new System.Drawing.Point(6, 39);
            this.rbtnTypeDocCheck.Name = "rbtnTypeDocCheck";
            this.rbtnTypeDocCheck.Size = new System.Drawing.Size(149, 17);
            this.rbtnTypeDocCheck.TabIndex = 42;
            this.rbtnTypeDocCheck.Text = "контрольные показания";
            this.rbtnTypeDocCheck.UseVisualStyleBackColor = true;
            // 
            // rbtnTypeDocAll
            // 
            this.rbtnTypeDocAll.AutoSize = true;
            this.rbtnTypeDocAll.Location = new System.Drawing.Point(6, 60);
            this.rbtnTypeDocAll.Name = "rbtnTypeDocAll";
            this.rbtnTypeDocAll.Size = new System.Drawing.Size(100, 17);
            this.rbtnTypeDocAll.TabIndex = 43;
            this.rbtnTypeDocAll.Text = "все показания";
            this.rbtnTypeDocAll.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTypeDocUser);
            this.groupBox1.Controls.Add(this.rbtnTypeDocAll);
            this.groupBox1.Controls.Add(this.rbtnTypeDocCheck);
            this.groupBox1.Location = new System.Drawing.Point(240, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 83);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Фильтр по типу акта ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnSortZone);
            this.groupBox2.Controls.Add(this.rbtnSortDate);
            this.groupBox2.Location = new System.Drawing.Point(450, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 64);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка";
            // 
            // rbtnSortZone
            // 
            this.rbtnSortZone.AutoSize = true;
            this.rbtnSortZone.Location = new System.Drawing.Point(9, 39);
            this.rbtnSortZone.Name = "rbtnSortZone";
            this.rbtnSortZone.Size = new System.Drawing.Size(64, 17);
            this.rbtnSortZone.TabIndex = 1;
            this.rbtnSortZone.Text = "по зоне";
            this.rbtnSortZone.UseVisualStyleBackColor = true;
            // 
            // rbtnSortDate
            // 
            this.rbtnSortDate.AutoSize = true;
            this.rbtnSortDate.Checked = true;
            this.rbtnSortDate.Location = new System.Drawing.Point(9, 18);
            this.rbtnSortDate.Name = "rbtnSortDate";
            this.rbtnSortDate.Size = new System.Drawing.Size(63, 17);
            this.rbtnSortDate.TabIndex = 0;
            this.rbtnSortDate.TabStop = true;
            this.rbtnSortDate.Text = "по дате";
            this.rbtnSortDate.UseVisualStyleBackColor = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "dtMeter";
            this.bindingSource2.DataSource = this.dsCntVal1;
            // 
            // FormMeterData
            // 
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(675, 538);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.dtBegin);
            this.Controls.Add(this.reportViewerRus1);
            this.Name = "FormMeterData";
            this.Text = "Показания прибора учета за выбранный период";
            this.Load += new System.EventHandler(this.FormMeterData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private DataSet.dsCntVal dsCntVal1;
        private System.Windows.Forms.RadioButton rbtnTypeDocUser;
        private System.Windows.Forms.RadioButton rbtnTypeDocCheck;
        private System.Windows.Forms.RadioButton rbtnTypeDocAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnSortZone;
        private System.Windows.Forms.RadioButton rbtnSortDate;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}
