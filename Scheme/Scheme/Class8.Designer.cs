using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataSql;
using Microsoft.Reporting.WinForms;
using SchemeCtrl2.DrawTool;
using WinFormsUI.Docking;

internal class Class8 : DockContentBase
{
	internal Class8(List<ObjectOnLine> list_1)
	{
		
		this.list_0 = new List<ObjectOnLine>();
		
		this.method_0();
		this.list_0 = list_1;
	}

	internal Class8(DataTable dataTable_2, DataTable dataTable_3, string string_0)
	{
		
		this.list_0 = new List<ObjectOnLine>();
		
		this.method_0();
		this.dataTable_0 = dataTable_2;
		this.dataTable_1 = dataTable_3;
		this.QyeKsmrCvo = string_0;
	}

	private void Class8_Load(object sender, EventArgs e)
	{
		if (this.list_0.Count > 0)
		{
			ObjectOnLine objectOnLine = this.list_0[0];
			this.SqlSettings = objectOnLine.Layer.Parent.SqlSettings;
			string value = string.Empty;
			if (objectOnLine.IsNormalSection)
			{
				value = "Список включенных \"Нормальных разрезов\"";
			}
			else
			{
				value = "Список отключенных комутационных аппаратов";
			}
			ReportParameter parameters = new ReportParameter("ReportName", value);
			this.reportViewer_0.LocalReport.SetParameters(parameters);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("where idObj in (");
			bool flag = true;
			foreach (ObjectOnLine objectOnLine2 in this.list_0)
			{
				if (!flag)
				{
					stringBuilder.Append(", ");
				}
				else
				{
					flag = false;
				}
				stringBuilder.Append(objectOnLine2.IdBase);
			}
			stringBuilder.Append(")");
			base.SelectSqlData(this.class19_0, this.class19_0.vSchm_LogDispatcher, true, stringBuilder.ToString());
			foreach (object obj in this.class19_0.vSchm_LogDispatcher.Rows)
			{
				Class19.Class47 @class = (Class19.Class47)obj;
				DataRow dataRow = this.class19_0.vShm_SwitchReport.NewRow();
				dataRow[0] = @class.NameObj;
				dataRow[1] = @class.username;
				dataRow[2] = @class.DateLog;
				this.class19_0.vShm_SwitchReport.Rows.Add(dataRow);
			}
			stringBuilder = new StringBuilder();
			foreach (ObjectOnLine objectOnLine3 in this.list_0)
			{
				if (this.class19_0.vSchm_LogDispatcher.Select(" idObj = " + objectOnLine3.IdBase).Length == 0)
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(", ");
					}
					stringBuilder.Append(objectOnLine3.IdBase);
				}
			}
			SqlDataConnect sqlDataConnect = new SqlDataConnect();
			sqlDataConnect.OpenConnection(this.SqlSettings);
			SqlDataReader sqlDataReader = new SqlCommand("select id, dbo.fn_Schm_GetFullNameObjById(id) from tSChm_ObjList where id in (" + stringBuilder + ")", sqlDataConnect.Connection).ExecuteReader();
			while (sqlDataReader.Read())
			{
				DataRow dataRow2 = this.class19_0.vShm_SwitchReport.NewRow();
				string text = sqlDataReader.GetValue(1).ToString();
				if (text != "")
				{
					dataRow2[0] = text;
				}
				else
				{
					dataRow2[0] = sqlDataReader.GetValue(0);
				}
				this.class19_0.vShm_SwitchReport.Rows.Add(dataRow2);
			}
			this.reportViewer_0.RefreshReport();
			return;
		}
		ReportDataSource reportDataSource = new ReportDataSource();
		reportDataSource.Name = "TPMeasurement";
		reportDataSource.Value = this.dataTable_0;
		this.reportViewer_0.LocalReport.DataSources.Add(reportDataSource);
		ReportDataSource reportDataSource2 = new ReportDataSource();
		reportDataSource2.Name = "CabMeasurement";
		reportDataSource2.Value = this.dataTable_1;
		this.reportViewer_0.LocalReport.DataSources.Add(reportDataSource2);
		this.reportViewer_0.LocalReport.ReportEmbeddedResource = this.QyeKsmrCvo;
		this.reportViewer_0.RefreshReport();
	}

	protected override void Dispose(bool bool_0)
	{
		if (bool_0 && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		Class8.t6RhbqZEJ5yyO6P7qHO(this, bool_0);
	}

	private void method_0()
	{
		this.icontainer_0 = new Container();
		ReportDataSource reportDataSource = new ReportDataSource();
		this.reportViewer_0 = new ReportViewer();
		this.class19_0 = new Class19();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		this.bindingSource_1 = new BindingSource(this.icontainer_0);
		((ISupportInitialize)this.class19_0).BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		((ISupportInitialize)this.bindingSource_1).BeginInit();
		base.SuspendLayout();
		this.reportViewer_0.Dock = DockStyle.Fill;
		reportDataSource.Name = "DataSet1";
		reportDataSource.Value = this.bindingSource_1;
		this.reportViewer_0.LocalReport.DataSources.Add(reportDataSource);
		this.reportViewer_0.LocalReport.ReportEmbeddedResource = "Scheme.FileReports.SwitchReport.rdlc";
		this.reportViewer_0.Location = new Point(0, 0);
		this.reportViewer_0.Name = "reportViewer1";
		this.reportViewer_0.Size = new Size(681, 547);
		this.reportViewer_0.TabIndex = 0;
		this.class19_0.DataSetName = "DataSetScheme";
		this.class19_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.bindingSource_0.DataMember = "vSchm_LogDispatcher";
		this.bindingSource_0.DataSource = this.class19_0;
		this.bindingSource_1.DataMember = "vShm_SwitchReport";
		this.bindingSource_1.DataSource = this.class19_0;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(681, 547);
		base.Controls.Add(this.reportViewer_0);
		this.MinimumSize = new Size(380, 379);
		base.Name = "FormReport";
		this.Text = "Отчёт";
		base.Load += this.Class8_Load;
		((ISupportInitialize)this.class19_0).EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		((ISupportInitialize)this.bindingSource_1).EndInit();
		base.ResumeLayout(false);
	}

	internal static void t6RhbqZEJ5yyO6P7qHO(Form form_0, bool bool_0)
	{
		form_0.Dispose(bool_0);
	}

	private List<ObjectOnLine> list_0;

	private DataTable dataTable_0;

	private DataTable dataTable_1;

	private string QyeKsmrCvo;

	private IContainer icontainer_0;

	private ReportViewer reportViewer_0;

	private Class19 class19_0;

	private BindingSource bindingSource_0;

	private BindingSource bindingSource_1;
}
