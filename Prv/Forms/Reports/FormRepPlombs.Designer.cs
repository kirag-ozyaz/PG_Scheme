namespace Prv.Forms.Reports
{
    partial class FormRepPlombs
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
            this.vPlombBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPlomb = new Prv.DataSets.DataSetPlomb();
            this.reportViewer1 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            ((System.ComponentModel.ISupportInitialize)(this.vPlombBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlomb)).BeginInit();
            this.SuspendLayout();
            // 
            // vPlombBindingSource
            // 
            this.vPlombBindingSource.DataMember = "vPlombStatus";
            this.vPlombBindingSource.DataSource = this.dataSetPlomb;
            // 
            // dataSetPlomb
            // 
            this.dataSetPlomb.DataSetName = "DataSetPlomb";
            this.dataSetPlomb.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetPlomb_vPlombStatus";
            reportDataSource1.Value = this.vPlombBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DisplayName = "Отчет по выданным пломбам";
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Prv.FileReports.ReportPlombsGive.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(553, 370);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormRepPlombs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 370);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRepPlombs";
            this.Text = "Отчет по пломбам";
            this.Load += new System.EventHandler(this.FormRepPlombs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vPlombBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPlomb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewer1;
        private System.Windows.Forms.BindingSource vPlombBindingSource;
        private Prv.DataSets.DataSetPlomb dataSetPlomb;
    }
}