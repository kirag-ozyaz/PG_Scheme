using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using Microsoft.Reporting.WinForms;
using Passport.DataSets;

namespace Passport.Forms.Cable.Report
{
	public class FormCableProtocolReport : FormBase
	{
		public int IdProtocol
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public FormCableProtocolReport()
		{
			this.method_0();
		}

		public FormCableProtocolReport(SQLSettings settings, int idProtocol)
		{
			this.method_0();
			this.SqlSettings = settings;
			this.int_0 = idProtocol;
		}

		private void FormCableProtocolReport_Load(object sender, EventArgs e)
		{
			base.SelectSqlData(this.dsDocuments_0, this.dsDocuments_0.vP_CabProtocol, true, string.Format("WHERE id = {0}", this.int_0), true);
			this.bindingSource_1.DataSource = this.dsDocuments_0.vP_CabProtocol;
			this.reportViewer_0.RefreshReport();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		private void method_0()
		{
			this.icontainer_0 = new Container();
			ReportDataSource reportDataSource = new ReportDataSource();
			this.bindingSource_1 = new BindingSource(this.icontainer_0);
			this.bindingSource_0 = new BindingSource(this.icontainer_0);
			this.dsDocuments_0 = new dsDocuments();
			this.reportViewer_0 = new ReportViewer();
			((ISupportInitialize)this.bindingSource_1).BeginInit();
			((ISupportInitialize)this.bindingSource_0).BeginInit();
			((ISupportInitialize)this.dsDocuments_0).BeginInit();
			base.SuspendLayout();
			this.bindingSource_1.DataSource = typeof(dsDocuments.vP_CabProtocolDataTable);
			this.bindingSource_0.DataMember = "vP_CabProtocol";
			this.bindingSource_0.DataSource = this.dsDocuments_0;
			this.dsDocuments_0.DataSetName = "dsDocuments";
			this.dsDocuments_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.reportViewer_0.Dock = DockStyle.Fill;
			reportDataSource.Name = "DataSet1";
			reportDataSource.Value = this.bindingSource_1;
			this.reportViewer_0.LocalReport.DataSources.Add(reportDataSource);
			this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.Cable.Report.ReportCabProtocol.rdlc";
			this.reportViewer_0.Location = new Point(0, 0);
			this.reportViewer_0.Name = "rpGeneral";
			this.reportViewer_0.Size = new Size(784, 562);
			this.reportViewer_0.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(784, 562);
			base.Controls.Add(this.reportViewer_0);
			base.Name = "FormCableProtocolReport";
			this.Text = "Протокол испытания образца кабеля (муфты)";
			base.Load += this.FormCableProtocolReport_Load;
			((ISupportInitialize)this.bindingSource_1).EndInit();
			((ISupportInitialize)this.bindingSource_0).EndInit();
			((ISupportInitialize)this.dsDocuments_0).EndInit();
			base.ResumeLayout(false);
		}

		private int int_0;

		private IContainer icontainer_0;

		private BindingSource bindingSource_0;

		private dsDocuments dsDocuments_0;

		private ReportViewer reportViewer_0;

		private BindingSource bindingSource_1;
	}
}
