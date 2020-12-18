namespace Prv.Forms.Reports
{
    partial class FormAbnOpl
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RVAbnOpl = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bsDoc = new System.Windows.Forms.BindingSource(this.components);
            this.dsRep = new Prv.DataSets.DataSetRep();
            this.bsPrv = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrv)).BeginInit();
            this.SuspendLayout();
            // 
            // RVAbnOpl
            // 
            this.RVAbnOpl.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "vDocAll";
            reportDataSource3.Value = this.bsDoc;
            reportDataSource4.Name = "vAbnForRep";
            reportDataSource4.Value = this.bsPrv;
            this.RVAbnOpl.LocalReport.DataSources.Add(reportDataSource3);
            this.RVAbnOpl.LocalReport.DataSources.Add(reportDataSource4);
            this.RVAbnOpl.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportAbnOpl.rdlc";
            this.RVAbnOpl.Location = new System.Drawing.Point(0, 0);
            this.RVAbnOpl.Name = "RVAbnOpl";
            this.RVAbnOpl.Size = new System.Drawing.Size(756, 526);
            this.RVAbnOpl.TabIndex = 0;
            // 
            // bsDoc
            // 
            this.bsDoc.DataMember = "vDocAll";
            this.bsDoc.DataSource = this.dsRep;
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "DataSetRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsPrv
            // 
            this.bsPrv.DataMember = "vAbnForRep";
            this.bsPrv.DataSource = this.dsRep;
            // 
            // FormAbnOpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 526);
            this.Controls.Add(this.RVAbnOpl);
            this.Name = "FormAbnOpl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Абонент";
            this.Load += new System.EventHandler(this.FormAbnOpl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPrv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RVAbnOpl;
        private System.Windows.Forms.BindingSource bsPrv;
        private System.Windows.Forms.BindingSource bsDoc;
        private DataSets.DataSetRep dsRep;
    }
}