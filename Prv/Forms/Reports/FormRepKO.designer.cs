namespace Prv.Forms.Reports
{
    partial class FormRepKO
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsRep = new Prv.DataSets.DataSetRep();
            this.reportViewer1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).BeginInit();
            this.SuspendLayout();
            // 
            // dsRep
            // 
            this.dsRep.DataSetName = "DataSetRep";
            this.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetRep_RepActKO";
            reportDataSource1.Value = this.dsRep.RepActKO;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reports.FileReports.ReportKOItog.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(685, 358);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormRepKO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 358);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRepKO";
            this.Text = "Отчет по КО";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RepKO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsRep)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewer1;
		private DataSets.DataSetRep dsRep;
	}
}