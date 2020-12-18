using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using Microsoft.Reporting.WinForms;

internal class Form4 : FormBase
{
	internal int method_0()
	{
		return this.int_0;
	}

	internal void method_1(int int_1)
	{
		this.int_0 = int_1;
	}

	internal Form4()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.method_2();
	}

	internal Form4(SQLSettings sqlsettings_0, int int_1)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.method_2();
		this.SqlSettings = sqlsettings_0;
		this.int_0 = int_1;
	}

	private void Form4_Load(object sender, EventArgs e)
	{
		base.SelectSqlData(this.class14_0.vP_CabProtocol, true, string.Format("WHERE id = {0}", this.int_0), null, true, 0);
		this.bindingSource_0.DataSource = this.class14_0.vP_CabProtocol;
		this.reportViewer_0.RefreshReport();
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Form4.ukQM0o9fv40VinjpGPMd(this, bool_0);
	}

	private void method_2()
	{
		this.icontainer_0 = new Container();
		ReportDataSource reportDataSource = new ReportDataSource();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.uprmsHjiMjv = new BindingSource(this.icontainer_0);
		this.class14_0 = new Class14();
		this.reportViewer_0 = new ReportViewer();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		((ISupportInitialize)this.uprmsHjiMjv).BeginInit();
		((ISupportInitialize)this.class14_0).BeginInit();
		base.SuspendLayout();
		this.bindingSource_0.DataSource = typeof(Class14.Class49);
		this.uprmsHjiMjv.DataMember = "vP_CabProtocol";
		this.uprmsHjiMjv.DataSource = this.class14_0;
		this.class14_0.DataSetName = "dsDocuments";
		this.class14_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.reportViewer_0.Dock = DockStyle.Fill;
		reportDataSource.Name = "DataSet1";
		reportDataSource.Value = this.bindingSource_0;
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
		base.Load += this.Form4_Load;
		((ISupportInitialize)this.bindingSource_0).EndInit();
		((ISupportInitialize)this.uprmsHjiMjv).EndInit();
		((ISupportInitialize)this.class14_0).EndInit();
		base.ResumeLayout(false);
	}

	internal static void ukQM0o9fv40VinjpGPMd(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private int int_0;

	private IContainer icontainer_0;

	private BindingSource uprmsHjiMjv;

	private Class14 class14_0;

	private ReportViewer reportViewer_0;

	private BindingSource bindingSource_0;
}
