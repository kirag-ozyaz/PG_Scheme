namespace Prv.Forms.Reports
{
    partial class FormRepGosCheck
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
            this.RepDateCheckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRep = new Prv.DataSets.DataSetRep();
            this.reportViewerRus1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            ((System.ComponentModel.ISupportInitialize)(this.RepDateCheckBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRep)).BeginInit();
            this.SuspendLayout();
            // 
            // RepDateCheckBindingSource
            // 
            this.RepDateCheckBindingSource.DataMember = "RepDateCheck";
            this.RepDateCheckBindingSource.DataSource = this.dataSetRep;
            // 
            // dataSetRep
            // 
            this.dataSetRep.DataSetName = "DataSetRep";
            this.dataSetRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerRus1
            // 
            this.reportViewerRus1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetRep_RepDateCheck";
            reportDataSource1.Value = this.RepDateCheckBindingSource;
            this.reportViewerRus1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerRus1.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportGosCheck.rdlc";
            this.reportViewerRus1.Location = new System.Drawing.Point(0, 0);
            this.reportViewerRus1.Name = "reportViewerRus1";
            this.reportViewerRus1.Size = new System.Drawing.Size(654, 376);
            this.reportViewerRus1.TabIndex = 0;
            // 
            // FormRepGosCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 376);
            this.Controls.Add(this.reportViewerRus1);
            this.Name = "FormRepGosCheck";
            this.Text = "Госповерка";
            this.Load += new System.EventHandler(this.FormGosCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RepDateCheckBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSets.DataSetRep dataSetRep;
        private System.Windows.Forms.BindingSource RepDateCheckBindingSource;
        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus1;
    }
}