namespace Documents.Forms.JournalRelayProtectionAutomation
{
    using ControlsLbr.ReportViewerRus;
    using Documents.DataSets;
    using FormLbr;
    using Microsoft.Reporting.WinForms;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormReportRelayProtectionAutomation : FormBase
    {
        private BindingSource bindingSource_0;
        private DataSetGES dataSetGES_0;
        private IContainer icontainer_0;
        private ControlsLbr.ReportViewerRus.ReportViewerRus reportViewerRus_0;

        public FormReportRelayProtectionAutomation()
        {
            this.method_0();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.icontainer_0 != null))
            {
                this.icontainer_0.Dispose();
            }
            base.Dispose(disposing);
        }

        private void FormReportRelayProtectionAutomation_Load(object sender, EventArgs e)
        {
            base.SelectSqlData(this.dataSetGES_0, this.dataSetGES_0.vJ_RelayProtectionAutomation, true, " where " + " (deleted = 0 and deletedObj = 0) " + " order by Sub_name, bus_name, cell_name");
            this.reportViewerRus_0.RefreshReport();
        }

        private void method_0()
        {
            this.icontainer_0 = new Container();
            ReportDataSource item = new ReportDataSource();
            this.bindingSource_0 = new BindingSource(this.icontainer_0);
            this.dataSetGES_0 = new DataSetGES();
            this.reportViewerRus_0 = new ControlsLbr.ReportViewerRus.ReportViewerRus();
            ((ISupportInitialize) this.bindingSource_0).BeginInit();
            this.dataSetGES_0.BeginInit();
            base.SuspendLayout();
            this.bindingSource_0.DataMember = "vJ_RelayProtectionAutomation";
            this.bindingSource_0.DataSource = this.dataSetGES_0;
            this.dataSetGES_0.DataSetName = "DataSetGES";
            this.dataSetGES_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            this.reportViewerRus_0.Dock = DockStyle.Fill;
            item.Name = "dsGES";
            item.Value = this.bindingSource_0;
            this.reportViewerRus_0.LocalReport.DataSources.Add(item);
            this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalRelayProtectionAutomation.ReportRelayProtectionAutomation.rdlc";
            this.reportViewerRus_0.Location = new Point(0, 0);
            this.reportViewerRus_0.Name = "reportViewer1";
            this.reportViewerRus_0.Size = new Size(0x25b, 0x106);
            this.reportViewerRus_0.TabIndex = 0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x25b, 0x106);
            base.Controls.Add(this.reportViewerRus_0);
            base.Name = "FormReportRelayProtectionAutomation";
            this.Text = "FormReportRelayProtectionAutomation";
            base.Load += new EventHandler(this.FormReportRelayProtectionAutomation_Load);
            ((ISupportInitialize) this.bindingSource_0).EndInit();
            this.dataSetGES_0.EndInit();
            base.ResumeLayout(false);
        }
    }
}

