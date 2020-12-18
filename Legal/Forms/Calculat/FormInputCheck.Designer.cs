namespace Legal.Forms.Calculat
{
    partial class FormInputCheck
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCntVal1 = new Legal.DataSet.dsCntVal();
            this.checkedListBoxController = new System.Windows.Forms.CheckedListBox();
            this.cBoxPeriod = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numMonth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMinus = new System.Windows.Forms.NumericUpDown();
            this.numPlus = new System.Windows.Forms.NumericUpDown();
            this.buttonBegin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "dtAbnObjCheck";
            this.bindingSource1.DataSource = this.dsCntVal1;
            // 
            // dsCntVal1
            // 
            this.dsCntVal1.DataSetName = "dsCntVal";
            this.dsCntVal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkedListBoxController
            // 
            this.checkedListBoxController.FormattingEnabled = true;
            this.checkedListBoxController.Location = new System.Drawing.Point(580, 5);
            this.checkedListBoxController.Name = "checkedListBoxController";
            this.checkedListBoxController.Size = new System.Drawing.Size(188, 124);
            this.checkedListBoxController.TabIndex = 0;
            // 
            // cBoxPeriod
            // 
            this.cBoxPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxPeriod.FormatString = "MMMM yyyy";
            this.cBoxPeriod.FormattingEnabled = true;
            this.cBoxPeriod.Location = new System.Drawing.Point(423, 15);
            this.cBoxPeriod.Name = "cBoxPeriod";
            this.cBoxPeriod.Size = new System.Drawing.Size(137, 21);
            this.cBoxPeriod.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите месяц и год за который требуется выполнить проверку:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(91, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество предшествующих месяцев для проверки:";
            // 
            // numMonth
            // 
            this.numMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMonth.Location = new System.Drawing.Point(423, 95);
            this.numMonth.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numMonth.Name = "numMonth";
            this.numMonth.Size = new System.Drawing.Size(65, 20);
            this.numMonth.TabIndex = 7;
            this.numMonth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(95, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите допустимый процент отклонения расхода:";
            // 
            // numMinus
            // 
            this.numMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numMinus.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMinus.Location = new System.Drawing.Point(423, 58);
            this.numMinus.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numMinus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numMinus.Name = "numMinus";
            this.numMinus.Size = new System.Drawing.Size(52, 20);
            this.numMinus.TabIndex = 4;
            this.numMinus.Value = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            // 
            // numPlus
            // 
            this.numPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numPlus.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numPlus.Location = new System.Drawing.Point(498, 58);
            this.numPlus.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numPlus.Name = "numPlus";
            this.numPlus.Size = new System.Drawing.Size(49, 20);
            this.numPlus.TabIndex = 5;
            this.numPlus.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // buttonBegin
            // 
            this.buttonBegin.Location = new System.Drawing.Point(826, 42);
            this.buttonBegin.Name = "buttonBegin";
            this.buttonBegin.Size = new System.Drawing.Size(104, 28);
            this.buttonBegin.TabIndex = 9;
            this.buttonBegin.Text = "Сформировать";
            this.buttonBegin.UseVisualStyleBackColor = true;
            this.buttonBegin.Click += new System.EventHandler(this.buttonBegin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(476, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(547, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numMonth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numPlus);
            this.groupBox1.Controls.Add(this.numMinus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxPeriod);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 126);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // reportViewerRus1
            // 
            this.reportViewerRus1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "dsAbnObjCheck";
            reportDataSource1.Value = this.bindingSource1;
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Legal.Reports.ReportCheck.rdlc";
            this.reportViewerRus1.Location = new System.Drawing.Point(3, 135);
            this.reportViewerRus1.Name = "reportViewerRus1";
            this.reportViewerRus1.Size = new System.Drawing.Size(975, 476);
            this.reportViewerRus1.TabIndex = 27;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(826, 90);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(104, 23);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormInputCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(984, 612);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.reportViewerRus1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonBegin);
            this.Controls.Add(this.checkedListBoxController);
            this.Name = "FormInputCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проверка на полноту";
            this.Load += new System.EventHandler(this.FormInputCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCntVal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPlus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxController;
        private System.Windows.Forms.ComboBox cBoxPeriod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMinus;
        private System.Windows.Forms.NumericUpDown numPlus;
        private System.Windows.Forms.Button buttonBegin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
        private DataSet.dsCntVal dsCntVal1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonCancel;
    }
}