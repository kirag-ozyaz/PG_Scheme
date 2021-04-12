using Microsoft.Reporting.WinForms;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace JournalOrder
{
    internal partial class FormReportOrder : global::FormLbr.FormBase
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.components = new Container();
            ReportDataSource reportDataSource = new ReportDataSource();
            ReportDataSource reportDataSource2 = new ReportDataSource();
            this.bsOrder = new BindingSource(this.components);
            this.dataSetOrder = new DataSet.DataSetOrder();
            this.bsOrderInstruction = new BindingSource(this.components);
            this.reportViewer1 = new ReportViewer();
            ((ISupportInitialize)this.bsOrder).BeginInit();
            ((ISupportInitialize)this.dataSetOrder).BeginInit();
            ((ISupportInitialize)this.bsOrderInstruction).BeginInit();
            base.SuspendLayout();
            this.bsOrder.DataMember = "vJ_Order";
            this.bsOrder.DataSource = this.dataSetOrder;
            this.dataSetOrder.DataSetName = "DataSetOrder";
            this.dataSetOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.bsOrderInstruction.DataMember = "tJ_OrderInstruction";
            this.bsOrderInstruction.DataSource = this.dataSetOrder;
            this.reportViewer1.Dock = DockStyle.Fill;
            reportDataSource.Name = "vJ_Order";
            reportDataSource.Value = this.bsOrder;
            reportDataSource2.Name = "tJ_OrderInstruction";
            reportDataSource2.Value = this.bsOrderInstruction;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Documents.Reports.ReportOrder.rdlc";
            this.reportViewer1.Location = new Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new Size(607, 430);
            this.reportViewer1.TabIndex = 0;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(607, 430);
            base.Controls.Add(this.reportViewer1);
            base.Name = "FormReportOrder";
            this.Text = "FormReportOrder";
            base.Load += new System.EventHandler(this.FormReportOrder_Load);
            ((ISupportInitialize)this.bsOrder).EndInit();
            ((ISupportInitialize)this.dataSetOrder).EndInit();
            ((ISupportInitialize)this.bsOrderInstruction).EndInit();
            base.ResumeLayout(false);
        }




        private DataSet.DataSetOrder dataSetOrder;
        private ReportViewer reportViewer1;
        private BindingSource bsOrder;
        private BindingSource bsOrderInstruction;
    }
}