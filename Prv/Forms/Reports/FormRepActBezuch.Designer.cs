namespace Prv.Forms.Reports
{
    partial class FormRepActBezuch
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
            this.bsActBezuch = new System.Windows.Forms.BindingSource(this.components);
            this.dsRep = new Prv.DataSets.DataSetRep();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cBoxPeriod = new System.Windows.Forms.ComboBox();
            this.labelAct = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.btkCancel = new System.Windows.Forms.Button();
            this.buttonExec = new System.Windows.Forms.Button();
            this.RWRepActBezuch = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bsActBezuch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsActBezuch
            // 
            this.bsActBezuch.DataMember = "vDocActBezuch";
            this.bsActBezuch.DataSource = this.dsRep;
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "DataSetRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cBoxPeriod);
            this.panel1.Controls.Add(this.labelAct);
            this.panel1.Controls.Add(this.comboBoxYear);
            this.panel1.Controls.Add(this.labelYear);
            this.panel1.Controls.Add(this.btkCancel);
            this.panel1.Controls.Add(this.buttonExec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 47);
            this.panel1.TabIndex = 3;
            // 
            // cBoxPeriod
            // 
            this.cBoxPeriod.FormatString = "MMMM yyyy";
            this.cBoxPeriod.FormattingEnabled = true;
            this.cBoxPeriod.Location = new System.Drawing.Point(365, 13);
            this.cBoxPeriod.Name = "cBoxPeriod";
            this.cBoxPeriod.Size = new System.Drawing.Size(135, 21);
            this.cBoxPeriod.TabIndex = 10;
            // 
            // labelAct
            // 
            this.labelAct.AutoSize = true;
            this.labelAct.Location = new System.Drawing.Point(216, 16);
            this.labelAct.Name = "labelAct";
            this.labelAct.Size = new System.Drawing.Size(143, 13);
            this.labelAct.TabIndex = 9;
            this.labelAct.Text = "Период внесенных данных";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Location = new System.Drawing.Point(88, 15);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(104, 21);
            this.comboBoxYear.TabIndex = 8;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(3, 10);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(79, 26);
            this.labelYear.TabIndex = 7;
            this.labelYear.Text = "Год \r\nобследования";
            // 
            // btkCancel
            // 
            this.btkCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btkCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btkCancel.Location = new System.Drawing.Point(699, 13);
            this.btkCancel.Name = "btkCancel";
            this.btkCancel.Size = new System.Drawing.Size(75, 23);
            this.btkCancel.TabIndex = 3;
            this.btkCancel.Text = "Закрыть";
            this.btkCancel.UseVisualStyleBackColor = true;
            this.btkCancel.Click += new System.EventHandler(this.btkCancel_Click);
            // 
            // buttonExec
            // 
            this.buttonExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExec.Location = new System.Drawing.Point(604, 13);
            this.buttonExec.Name = "buttonExec";
            this.buttonExec.Size = new System.Drawing.Size(92, 23);
            this.buttonExec.TabIndex = 0;
            this.buttonExec.Text = "Сформировать";
            this.buttonExec.UseVisualStyleBackColor = true;
            this.buttonExec.Click += new System.EventHandler(this.buttonExec_Click);
            // 
            // RWRepActBezuch
            // 
            this.RWRepActBezuch.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "vDocActBezuch";
            reportDataSource1.Value = this.bsActBezuch;
            this.RWRepActBezuch.LocalReport.DataSources.Add(reportDataSource1);
            this.RWRepActBezuch.LocalReport.ReportEmbeddedResource = "Prv.FileReports.RepActBY.rdlc";
            this.RWRepActBezuch.Location = new System.Drawing.Point(0, 47);
            this.RWRepActBezuch.Name = "RWRepActBezuch";
            this.RWRepActBezuch.Size = new System.Drawing.Size(780, 398);
            this.RWRepActBezuch.TabIndex = 4;
            // 
            // FormRepActBezuch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 445);
            this.Controls.Add(this.RWRepActBezuch);
            this.Controls.Add(this.panel1);
            this.Name = "FormRepActBezuch";
            this.Text = "Акты неучтенного потребления";
            this.Load += new System.EventHandler(this.FormRepActBezuch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsActBezuch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btkCancel;
        private System.Windows.Forms.Button buttonExec;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelAct;
        private System.Windows.Forms.ComboBox cBoxPeriod;
        private DataSets.DataSetRep dsRep;
        private Microsoft.Reporting.WinForms.ReportViewer RWRepActBezuch;
        private System.Windows.Forms.BindingSource bsActBezuch;
    }
}