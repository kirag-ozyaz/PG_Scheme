using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DataSql;
using FormLbr;
using Microsoft.Reporting.WinForms;

internal class Form5 : FormBase
{
	internal int IdObjList { get; set; }

	internal Form5(SQLSettings sqlsettings_0, int int_1)
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.method_0();
		this.SqlSettings = sqlsettings_0;
		this.IdObjList = int_1;
	}

	internal Form5()
	{
		Class330.Mus9JxKz1CNxy();
		base..ctor();
		this.method_0();
	}

	private void Form5_Load(object sender, EventArgs e)
	{
		base.SelectSqlData(this.class14_0, this.class14_0.tSchm_ObjList, true, "WHERE id = " + this.IdObjList.ToString());
		base.SelectSqlData(this.class14_0, this.class14_0.vP_CabSectionReportNew, true, "WHERE idObjList = " + this.IdObjList.ToString());
		this.Ublmsvtqask.ResetBindings(false);
		this.bindingSource_0.ResetBindings(false);
		this.reportViewer_0.RefreshReport();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Form5.RBrBsZ9f0iokWJKcW05I(this, bool_0);
	}

	private void method_0()
	{
		this.icontainer_0 = new Container();
		ReportDataSource reportDataSource = new ReportDataSource();
		ReportDataSource reportDataSource2 = new ReportDataSource();
		this.Ublmsvtqask = new BindingSource(this.icontainer_0);
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.tableLayoutPanel_0 = new TableLayoutPanel();
		this.reportViewer_0 = new ReportViewer();
		this.class14_0 = new Class14();
		this.button_0 = new Button();
		((ISupportInitialize)this.Ublmsvtqask).BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		this.tableLayoutPanel_0.SuspendLayout();
		((ISupportInitialize)this.class14_0).BeginInit();
		base.SuspendLayout();
		this.Ublmsvtqask.DataMember = "tSchm_ObjList";
		this.Ublmsvtqask.DataSource = this.class14_0;
		this.bindingSource_0.DataMember = "vP_CabSectionReportNew";
		this.bindingSource_0.DataSource = this.class14_0;
		this.tableLayoutPanel_0.ColumnCount = 2;
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 128f));
		this.tableLayoutPanel_0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20f));
		this.tableLayoutPanel_0.Controls.Add(this.reportViewer_0, 0, 0);
		this.tableLayoutPanel_0.Controls.Add(this.button_0, 1, 1);
		this.tableLayoutPanel_0.Dock = DockStyle.Fill;
		this.tableLayoutPanel_0.Location = new Point(0, 0);
		this.tableLayoutPanel_0.Name = "tableLayoutPanel1";
		this.tableLayoutPanel_0.RowCount = 2;
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
		this.tableLayoutPanel_0.RowStyles.Add(new RowStyle(SizeType.Absolute, 39f));
		this.tableLayoutPanel_0.Size = new Size(844, 450);
		this.tableLayoutPanel_0.TabIndex = 0;
		this.tableLayoutPanel_0.SetColumnSpan(this.reportViewer_0, 2);
		this.reportViewer_0.Dock = DockStyle.Fill;
		reportDataSource.Name = "dsCable";
		reportDataSource.Value = this.Ublmsvtqask;
		reportDataSource2.Name = "dsCabSectionNew";
		reportDataSource2.Value = this.bindingSource_0;
		this.reportViewer_0.LocalReport.DataSources.Add(reportDataSource);
		this.reportViewer_0.LocalReport.DataSources.Add(reportDataSource2);
		this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Passport.Forms.Cable.Report.ReportCableSection.rdlc";
		this.reportViewer_0.Location = new Point(3, 3);
		this.reportViewer_0.Name = "reportViewer1";
		this.reportViewer_0.Size = new Size(838, 405);
		this.reportViewer_0.TabIndex = 0;
		this.class14_0.DataSetName = "dsDocuments";
		this.class14_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.button_0.Location = new Point(719, 418);
		this.button_0.Margin = new Padding(3, 7, 3, 3);
		this.button_0.Name = "btnClose";
		this.button_0.Size = new Size(90, 23);
		this.button_0.TabIndex = 1;
		this.button_0.Text = "Закрыть";
		this.button_0.UseVisualStyleBackColor = true;
		this.button_0.Click += this.button_0_Click;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(844, 450);
		base.Controls.Add(this.tableLayoutPanel_0);
		base.Name = "FormCableSectionReport";
		this.Text = "Участки кабельной линии";
		base.Load += this.Form5_Load;
		((ISupportInitialize)this.Ublmsvtqask).EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		this.tableLayoutPanel_0.ResumeLayout(false);
		((ISupportInitialize)this.class14_0).EndInit();
		base.ResumeLayout(false);
	}

	internal static void RBrBsZ9f0iokWJKcW05I(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	[CompilerGenerated]
	private int int_0;

	private IContainer icontainer_0;

	private BindingSource Ublmsvtqask;

	private BindingSource bindingSource_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private ReportViewer reportViewer_0;

	private Button button_0;

	private Class14 class14_0;
}
