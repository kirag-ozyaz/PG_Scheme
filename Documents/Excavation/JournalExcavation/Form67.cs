using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ControlsLbr.ReportViewerRus;
using FormLbr;
using Microsoft.Reporting.WinForms;

internal partial class Form67 : FormBase
{
	internal Form67()
	{
		Class611.H9nE6ZDzTF9kb();
		this.int_0 = -1;
		
		this.method_0();
	}

	internal Form67(int int_1)
	{
		Class611.H9nE6ZDzTF9kb();
		this.int_0 = -1;
		
		this.method_0();
		this.int_0 = int_1;
	}

	private void Form67_Load(object sender, EventArgs e)
	{
		Class130.Class143 @class = new Class130.Class143();
		base.SelectSqlData(@class, true, " where idExcavation = " + this.int_0.ToString() + " and idType = " + 2.ToString(), null, false, 0);
		this.bindingSource_0.DataSource = @class;
		DataTable dataTable = base.SelectSqlData("vj_excavationSurface", true, " where idExcavation = " + this.int_0.ToString() + " and idType = " + 3.ToString());
		string text = string.Empty;
		foreach (object obj in dataTable.Rows)
		{
			DataRow dataRow = (DataRow)obj;
			if (!string.IsNullOrEmpty(text))
			{
				text += "; ";
			}
			text = string.Concat(new string[]
			{
				text,
				dataRow["surName"].ToString(),
				": ",
				dataRow["Value"].ToString(),
				" ",
				dataRow["Unit"].ToString()
			});
		}
		ReportParameter reportParameter = new ReportParameter("Material", text);
		this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter
		});
		dataTable = base.SelectSqlData("vj_excavationschmObj", true, " where idExcavation = " + this.int_0.ToString());
		string text2 = string.Empty;
		foreach (object obj2 in dataTable.Rows)
		{
			DataRow dataRow2 = (DataRow)obj2;
			if (!string.IsNullOrEmpty(text2))
			{
				text2 += "; ";
			}
			text2 += dataRow2["name"].ToString();
		}
		ReportParameter reportParameter2 = new ReportParameter("Cable", text2);
		this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter2
		});
		dataTable = base.SelectSqlData("vj_excavation", true, " where id = " + this.int_0.ToString());
		if (dataTable.Rows.Count > 0)
		{
			if (dataTable.Rows[0]["typeWorkName"] != DBNull.Value)
			{
				ReportParameter reportParameter3 = new ReportParameter("typeWork", dataTable.Rows[0]["typeWorkName"].ToString());
				this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
				{
					reportParameter3
				});
			}
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			dictionary.Add(759, 4);
			dictionary.Add(757, 2);
			dictionary.Add(756, 1);
			dictionary.Add(758, 3);
			Dictionary<int, string> dictionary2 = new Dictionary<int, string>();
			dictionary2.Add(759, "Исаев В.М.");
			dictionary2.Add(757, "Рябов Д.А.");
			dictionary2.Add(756, "Куфтырев Д.В.");
			dictionary2.Add(758, "Савинов Ю.М.");
			if (dataTable.Rows.Count > 0)
			{
				if (dataTable.Rows[0]["idSR"] == DBNull.Value)
				{
					MessageBox.Show("Не введен сетевой район");
				}
				else
				{
					try
					{
						int key = Convert.ToInt32(dataTable.Rows[0]["idSR"]);
						ReportParameter reportParameter4 = new ReportParameter("sr", dictionary[key].ToString());
						this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
						{
							reportParameter4
						});
						ReportParameter reportParameter5 = new ReportParameter("chieff", dictionary2[key]);
						this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
						{
							reportParameter5
						});
					}
					catch
					{
					}
				}
			}
		}
		dataTable = base.SelectSqlData("vj_excavationaddress", true, " where idExcavation = " + this.int_0.ToString());
		string text3 = string.Empty;
		foreach (object obj3 in dataTable.Rows)
		{
			DataRow dataRow3 = (DataRow)obj3;
			if (!string.IsNullOrEmpty(text3))
			{
				text3 += "; ";
			}
			text3 = text3 + dataRow3["street"].ToString() + ", " + dataRow3["house"].ToString();
		}
		ReportParameter reportParameter6 = new ReportParameter("Address", text3);
		this.reportViewerRus_0.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter6
		});
		this.reportViewerRus_0.RefreshReport();
	}

	private void method_0()
	{
		this.icontainer_0 = new Container();
		ReportDataSource reportDataSource = new ReportDataSource();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form67));
		this.reportViewerRus_0 = new ReportViewerRus();
		this.class130_0 = new Class130();
		this.bindingSource_0 = new BindingSource(this.icontainer_0);
		((ISupportInitialize)this.class130_0).BeginInit();
		((ISupportInitialize)this.bindingSource_0).BeginInit();
		base.SuspendLayout();
		this.reportViewerRus_0.Dock = DockStyle.Fill;
		reportDataSource.Name = "DataSetRecovery";
		reportDataSource.Value = this.bindingSource_0;
		this.reportViewerRus_0.LocalReport.DataSources.Add(reportDataSource);
		this.reportViewerRus_0.LocalReport.ReportEmbeddedResource = "Documents.Forms.JournalExcavation.Reports.ReportExcavationAct.rdlc";
		this.reportViewerRus_0.Location = new Point(0, 0);
		this.reportViewerRus_0.Name = "reportViewerRus1";
		this.reportViewerRus_0.Size = new Size(667, 414);
		this.reportViewerRus_0.TabIndex = 0;
		this.class130_0.DataSetName = "DataSetExcavation";
		this.class130_0.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(667, 414);
		base.Controls.Add(this.reportViewerRus_0);
		base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		base.Name = "FormReportAct";
		this.Text = "Акт передачи раскопок под асфальтирование";
		base.Load += this.Form67_Load;
		((ISupportInitialize)this.class130_0).EndInit();
		((ISupportInitialize)this.bindingSource_0).EndInit();
		base.ResumeLayout(false);
	}

	private int int_0;

	private ReportViewerRus reportViewerRus_0;

	private Class130 class130_0;

	private BindingSource bindingSource_0;
}
