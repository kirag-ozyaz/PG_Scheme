namespace Documents.Forms.JournalRequest
{
    partial class FormReportRequest
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsGES = new Documents.DataSets.DataSetGES();
            this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            this.bindingSourceDoc = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "vJ_Request";
            this.bindingSource.DataSource = this.dsGES;
            // 
            // dsGES
            // 
            this.dsGES.DataSetName = "DataSetGES";
            this.dsGES.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerRus1
            // 
            this.reportViewerRus1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetGES";
            reportDataSource1.Value = this.bindingSource;
            reportDataSource2.Name = "DataSetDoc";
            reportDataSource2.Value = this.bindingSourceDoc;
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalRequest.ReportRequest.rdlc";
            this.reportViewerRus1.Location = new System.Drawing.Point(0, 0);
            this.reportViewerRus1.Name = "reportViewerRus1";
            this.reportViewerRus1.Size = new System.Drawing.Size(408, 262);
            this.reportViewerRus1.TabIndex = 0;
            // 
            // bindingSourceDoc
            // 
            this.bindingSourceDoc.DataMember = "tJ_RequestDoc";
            this.bindingSourceDoc.DataSource = this.dsGES;
            // 
            // FormReportRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 262);
            this.Controls.Add(this.reportViewerRus1);
            this.Name = "FormReportRequest";
            this.Text = "Печать задачи";
            this.Load += new System.EventHandler(this.FormReportRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsGES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSets.DataSetGES dsGES;
        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.BindingSource bindingSourceDoc;

    }
}