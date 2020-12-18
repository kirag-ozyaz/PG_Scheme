namespace Calculat
{
    partial class FormReportObjLinkPrint
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
            this.tG_ReportMain_LinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDop = new SchemeReports.ReportObjLink.dsDop();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tG_ReportMain_LinkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDop)).BeginInit();
            this.SuspendLayout();
            // 
            // tG_ReportMain_LinkBindingSource
            // 
            this.tG_ReportMain_LinkBindingSource.DataMember = "tG_ReportMain_Link";
            this.tG_ReportMain_LinkBindingSource.DataSource = this.dsDop;
            // 
            // dsDop
            // 
            this.dsDop.DataSetName = "dsDop";
            this.dsDop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tG_ReportMain_LinkBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SchemeReports.ReportObjLink.ReportObjLinkPrint-1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(612, 431);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormReportObjLinkPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 431);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportObjLinkPrint";
            this.Text = "FormReportObjLinkPrint";
            this.Load += new System.EventHandler(this.FormReportObjLinkPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tG_ReportMain_LinkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SchemeReports.ReportObjLink.dsDop dsDop;
        private System.Windows.Forms.BindingSource tG_ReportMain_LinkBindingSource;
    }
}