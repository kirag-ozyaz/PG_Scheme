using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using ControlsLbr.ReportViewerRus;
using FormLbr;
using Microsoft.Reporting.WinForms;

/// <summary>
/// Суточный рапорт по дефектам
/// </summary>
internal partial class FormReportDailyDefect : FormBase
{
	internal FormReportDailyDefect()
	{
		//
		this.ListDivision = new List<int>();
		
		this.InitializeComponent();
		this.dtpBeg.Value = (this.dtpEnd.Value = DateTime.Now);
	}

	private void FormReportDailyDefect_Load(object sender, EventArgs e)
	{
		base.LoadFormConfig(null);
		this.FillChkDivisionApply();
		this.FillDataTableSettings();
		this.FillTableReportDailyDefect();
		this.FillReport();
	}

	private void FormReportDailyDefect_FormClosing(object sender, FormClosingEventArgs e)
	{
		this.SaveSettingReport();
		base.SaveFormConfig(null);
	}

	private void buttonLoad_Click(object sender, EventArgs e)
	{
		this.FillTableReportDailyDefect();
		this.FillReport();
	}

	private void FillChkDivisionApply()
	{
		DataTable dataTable = new DataTable("tR_Classifier");
		dataTable.Columns.Add("id", typeof(int));
		dataTable.Columns.Add("name", typeof(string));
		base.SelectSqlData(dataTable, true, "where ParentKey = ';ReportDaily;DivisionApply;' and isGroup = 0 and deleted = 0 order by value", null, false, 0);
		dataTable.Rows.Add(new object[]
		{
			-1,
			"Производственная лаборатория"
		});
		foreach (DataRow dataRow in dataTable.Rows)
		{
			if (this.ListDivision.Count != 0 && !this.ListDivision.Contains(Convert.ToInt32(dataRow["id"])))
			{
				this.chkListBoxDivision.Items.Add(new FormReportDailyDefect.StructureFilter(Convert.ToInt32(dataRow["id"]), dataRow["name"].ToString()), false);
			}
			else
			{
				this.chkListBoxDivision.Items.Add(new FormReportDailyDefect.StructureFilter(Convert.ToInt32(dataRow["id"]), dataRow["name"].ToString()), true);
			}
		}
	}

	private void FillTableReportDailyDefect()
	{
		this.dsDamage.ReportDailyDefect.Clear();
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
		{
			sqlConnection.Open();
			using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
			{
				try
				{
					string cmdText;
					if (this.chkDefectLocation.Checked)
					{
						cmdText = Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportDailyDefectWithLocation.sql");
					}
					else
					{
						cmdText = Library.ResourceReader.GetStringAssembly(this.GetType(), "DailyReportN.SqlScripts.ReportDailyDefect.sql");
					}
					using (SqlCommand sqlCommand = new SqlCommand(cmdText, sqlConnection))
					{
						sqlCommand.CommandTimeout = 0;
						sqlCommand.Transaction = sqlTransaction;
						sqlCommand.Parameters.Add("dBeg", SqlDbType.DateTime).Value = this.dtpBeg.Value.Date;
						sqlCommand.Parameters.Add("dEnd", SqlDbType.DateTime).Value = this.dtpEnd.Value.Date.AddDays(1.0);
						new SqlDataAdapter(sqlCommand).Fill(this.dsDamage.ReportDailyDefect);
					}
					sqlTransaction.Commit();
				}
				catch (Exception ex)
				{
					sqlTransaction.Rollback();
					MessageBox.Show(ex.Message, ex.Source);
				}
			}
		}
	}

	private void FillReport()
	{
		this.rptViewer.Reset();
		ReportDataSource reportDataSource = new ReportDataSource();
		reportDataSource.Name = "DataSetReportDailyDefect";
		reportDataSource.Value = this.bsDailyDefect;
		this.rptViewer.LocalReport.DataSources.Add(reportDataSource);
		if (this.chkFullReport.Checked)
		{
			this.rptViewer.LocalReport.ReportEmbeddedResource = "DailyReportN.Reports.ReportDailyDefectFull.rdlc";
		}
		else
		{
			this.rptViewer.LocalReport.ReportEmbeddedResource = "DailyReportN.Reports.ReportDailyDefect.rdlc";
		}
		List<ReportParameter> list = new List<ReportParameter>();
		if (!string.IsNullOrEmpty(this.txt1.Text))
		{
			list.Add(new ReportParameter("textName1", this.txt1.Text));
		}
		else
		{
			list.Add(new ReportParameter("textName1"));
		}
		if (!string.IsNullOrEmpty(this.txt2.Text))
		{
			list.Add(new ReportParameter("textName2", this.txt2.Text));
		}
		if (!string.IsNullOrEmpty(this.txtForWhom.Text))
		{
			list.Add(new ReportParameter("textForWhom", this.txtForWhom.Text));
		}
		if (this.dtpBeg.Value.Date == this.dtpEnd.Value.Date)
		{
			list.Add(new ReportParameter("dateReport", this.dtpBeg.Value.Date.ToString("dd.MM.yyyy")));
		}
		else
		{
			list.Add(new ReportParameter("dateReport", this.dtpBeg.Value.Date.ToString("dd.MM.yyyy") + " - " + this.dtpEnd.Value.Date.ToString("dd.MM.yyyy")));
		}
		if (this.chkFullReport.Checked)
		{
			if (this.dtpBeg.Value.Date != this.dtpEnd.Value.Date)
			{
				list.Add(new ReportParameter("VisibleDateDefect", true.ToString()));
			}
			else
			{
				list.Add(new ReportParameter("VisibleDateDefect", false.ToString()));
			}
		}
		if (this.chkListBoxDivision.CheckedItems.Count > 0 && this.chkListBoxDivision.CheckedItems.Count < this.chkListBoxDivision.Items.Count)
		{
			string text = "";
			foreach (object obj in this.chkListBoxDivision.CheckedItems)
			{
				if (string.IsNullOrEmpty(text))
				{
					text = ((FormReportDailyDefect.StructureFilter)obj).Id.ToString();
				}
				else
				{
					text = text + "," + ((FormReportDailyDefect.StructureFilter)obj).Id.ToString();
				}
			}
			this.bsDailyDefect.Filter = " idDivisionApply in (" + text + ") ";
		}
		else
		{
			this.bsDailyDefect.Filter = "";
		}
		if (this.chkNotApply.Checked)
		{
			list.Add(new ReportParameter("isNoApply", true.ToString()));
			if (string.IsNullOrEmpty(this.bsDailyDefect.Filter))
			{
				this.bsDailyDefect.Filter = " (isApply = 0 or isApply is null)";
			}
			else
			{
				BindingSource bindingSource = this.bsDailyDefect;
				bindingSource.Filter += " and (isApply = 0 or isApply is null) ";
			}
		}
		list.Add(new ReportParameter("ReportUser", this.GetUserFullName()));
		this.rptViewer.LocalReport.SetParameters(list);
		this.rptViewer.RefreshReport();
	}

	private void txt1_Leave(object sender, EventArgs e)
	{
		this.FillReport();
	}

	private string GetUserFullName()
	{
		using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
		{
			sqlConnection.Open();
			using (SqlCommand sqlCommand = new SqlCommand("select isnull(w.fio, u.name) as name from tuser u\r\n\t                                left join vr_worker w on u.idWorker = w.id\r\n                                    where login = SYSTEM_USER", sqlConnection))
			{
				sqlCommand.CommandTimeout = 0;
				DbDataAdapter dbDataAdapter = new SqlDataAdapter(sqlCommand);
				DataTable dataTable = new DataTable();
				dbDataAdapter.Fill(dataTable);
				if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["name"] != DBNull.Value)
				{
					return dataTable.Rows[0]["name"].ToString();
				}
			}
		}
		return string.Empty;
	}

	private void FillDataTableSettings()
	{
		this.dataTableSettings = new DataTable("tSettings");
		this.dataTableSettings.Columns.Add("id", typeof(int));
		this.dataTableSettings.PrimaryKey = new DataColumn[]
		{
			this.dataTableSettings.Columns["id"]
		};
		this.dataTableSettings.Columns["id"].AutoIncrement = true;
		this.dataTableSettings.Columns.Add("hostIP", typeof(string));
		this.dataTableSettings.Columns.Add("settings", typeof(object));
		this.dataTableSettings.Columns.Add("module", typeof(string));
		base.SelectSqlData(this.dataTableSettings, true, " where module = 'ReportDailyDefect' ", null, false, 0);
		if (this.dataTableSettings.Rows.Count > 0)
		{
			string xml = this.dataTableSettings.Rows[0]["settings"].ToString();
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.LoadXml(xml);
			XmlNode xmlNode = xmlDocument.SelectSingleNode("Sett");
			if (xmlNode != null)
			{
				if (xmlNode.Attributes["text1"] != null)
				{
					this.txt1.Text = xmlNode.Attributes["text1"].Value.ToString();
				}
				if (xmlNode.Attributes["text2"] != null)
				{
					this.txt2.Text = xmlNode.Attributes["text2"].Value.ToString();
				}
				if (xmlNode.Attributes["ForWhom"] != null)
				{
					this.txtForWhom.Text = xmlNode.Attributes["ForWhom"].Value.ToString();
				}
			}
		}
	}

	private void SaveSettingReport()
	{
		XDocument xdocument = new XDocument(new XDeclaration("1.0", "utf-16", null), new object[]
		{
			new XElement("Sett", new object[]
			{
				new XAttribute("text1", this.txt1.Text),
				new XAttribute("text2", this.txt2.Text),
				new XAttribute("ForWhom", this.txtForWhom.Text)
			})
		});
		if (this.dataTableSettings.Rows.Count > 0)
		{
			this.dataTableSettings.Rows[0]["settings"] = xdocument.ToString();
			base.UpdateSqlData(this.dataTableSettings);
			return;
		}
		DataRow dataRow = this.dataTableSettings.NewRow();
		dataRow["settings"] = xdocument.ToString();
		dataRow["module"] = "ReportDailyDefect";
		this.dataTableSettings.Rows.Add(dataRow);
		this.dataTableSettings.Rows[0].EndEdit();
		base.InsertSqlData(this.dataTableSettings);
	}

	protected override void ApplyConfig(XmlDocument xml)
	{
		XmlNode xmlNode = xml.SelectSingleNode(base.Name);
		if (xmlNode != null)
		{
			foreach (XmlNode xmlNode2 in xmlNode.SelectNodes("Item"))
			{
				if (!string.IsNullOrEmpty(xmlNode2.InnerText))
				{
					this.ListDivision.Add(Convert.ToInt32(xmlNode2.InnerText));
				}
			}
		}
	}

	protected override XmlDocument CreateXmlConfig()
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
		xmlDocument.AppendChild(newChild);
		XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
		xmlDocument.AppendChild(xmlNode);
		foreach (object obj in this.chkListBoxDivision.CheckedItems)
		{
			XmlNode xmlNode2 = xmlDocument.CreateElement("Item");
			xmlNode2.InnerText = ((FormReportDailyDefect.StructureFilter)obj).Id.ToString();
			xmlNode.AppendChild(xmlNode2);
		}
		return xmlDocument;
	}

	private void chkFullReport_CheckedChanged(object sender, EventArgs e)
	{
		this.FillReport();
	}

	private void chkNotApply_CheckedChanged(object sender, EventArgs e)
	{
		this.FillReport();
	}

	private class StructureFilter
	{
		internal StructureFilter(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		public override string ToString()
		{
			return this.Name;
		}

		internal int Id;
		internal string Name;
	}
}
