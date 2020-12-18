using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using DataSql;
using FormLbr;
using Microsoft.Reporting.WinForms;
/// <summary>
/// Бюллетень перерывов электроснабжения в сетях 0,4 кВ
/// </summary>
internal partial class FormReportInterruptLV : FormBase
{
    private DataTable dataTableReport;
    private DataTable dataTableSettings;

    private bool hiddenConfirm = true;
    private double Width0 = 37.79527559055;
    private double Width1 = 6.82708;

    internal FormReportInterruptLV()
	{
		this.InitializeComponent();
	}

	private void FormReportInterruptLV_Load(object sender, EventArgs e)
	{
		this.dtpBegin.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
		this.dtpEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddSeconds(-1.0);
		this.FillFullReport();
		this.GetFieldApprove();
		if (!this.checkBoxApprove.Checked)
		{
			this.FillReportApproveAndRefreshReport();
		}
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
		base.SelectSqlData(this.dataTableSettings, true, " where module = 'ReportInterruptLV' ", null, false, 0);
	}
    /// <summary>
    /// Заполняем поля для утвердителя
    /// </summary>
	private void GetFieldApprove()
	{
		this.FillDataTableSettings();
		if (this.dataTableSettings.Rows.Count > 0)
		{
			foreach (XElement xelement in XDocument.Parse(this.dataTableSettings.Rows[0]["settings"].ToString()).Elements("confirm"))
			{
				if (xelement.Attribute("post") != null)
				{
					this.txtPost.Text = xelement.Attribute("post").Value.ToString();
				}
				if (xelement.Attribute("FIO") != null)
				{
					this.txtFIO.Text = xelement.Attribute("FIO").Value.ToString();
				}
				if (xelement.Attribute("visible") != null)
				{
					this.checkBoxApprove.Checked = Convert.ToBoolean(xelement.Attribute("visible").Value);
				}
			}
		}
	}
    /// <summary>
    /// заполниим таблицу отчета сетевыми районами с пустыми строками
    /// </summary>
	private void FillTableReportIterruptLVNetworkAreas()
	{
		this.dsDamage.tReportIterruptLV.Clear();
		foreach (DataRow dataRow in this.FillTableNetworkAreas().Rows)
		{
			DataRow dataRow2 = this.dsDamage.tReportIterruptLV.NewRow();
			dataRow2["numNetRegion"] = dataRow["value"];
			dataRow2["netRegionValue"] = dataRow["name"];
			for (int i = 2; i < this.dsDamage.tReportIterruptLV.Columns.Count; i++)
			{
				dataRow2[i] = 0;
			}
			this.dsDamage.tReportIterruptLV.Rows.Add(dataRow2);
		}
	}
    /// <summary>
    /// заполним таблицу сетевых районов
    /// </summary>
    /// <returns></returns>
	private DataTable FillTableNetworkAreas()
	{
		DataTable dataTable = new DataTable("tR_Classifier");
		dataTable.Columns.Add("value", typeof(decimal));
		dataTable.Columns.Add("name", typeof(string));
		base.SelectSqlData(dataTable, true, " where ParentKey = ';NetworkAreas;' and deleted = 0 and isGroup = 0 order by value asc ", null, false, 0);
		DataRow dataRow = dataTable.NewRow();
		dataRow["value"] = 0;
		dataRow["name"] = "Нет данных";
		dataTable.Rows.Add(dataRow);
		return dataTable;
	}
   
    /// <summary>
    /// заполним таблицу повреждений/дефектов
    /// </summary>
    private DataTable FillTableReasonDamage()
	{
		DataTable dataTable = new DataTable("tR_Classifier");
		dataTable.Columns.Add("value", typeof(decimal));
		base.SelectSqlData(dataTable, true, " where ParentKey like ';ReportDaily;PTS;ReasonDamage;LV;%' and deleted = '0' and isGroup = 0 order by value", null, false, 0);
		foreach (DataRow dataRow in dataTable.Rows)
		{
			dataRow["value"] = Convert.ToInt32(dataRow["value"]);
		}
		return dataTable;
	}
    /// <summary>
    /// формруем отчет
    /// </summary>
	private void FillFullReport()
	{
		string text = string.Empty;
		string text2 = string.Empty;
		foreach (DataRow dataRow in this.FillTableReasonDamage().Rows)
		{
			if (string.IsNullOrEmpty(text2))
			{
				text = " [" + dataRow["value"].ToString() + "] as c" + dataRow["value"].ToString();
				text2 = " [" + dataRow["value"].ToString() + "]";
			}
			else
			{
				text = string.Concat(new string[]
				{
					text,
					", [",
					dataRow["value"].ToString(),
					"] as c",
					dataRow["Value"].ToString()
				});
				text2 = text2 + ", [" + dataRow["value"].ToString() + "]";
			}
		}
		string select = string.Format(" select netRegionValue as numNetRegion, {0}  from  (select t.netRegionValue, t.codeDamage from  (select dam.id, dam.numDoc, dam.dateDoc, dam.idSchmObj, dam.idReasonPTS,  sub.idNetRegion, convert(int, sub.netRegionValue) as netRegionValue, c.value as codeDamage, c.name  from tJ_Damage as dam left join  tR_Classifier as c on dam.idReasonPTS = c.Id left join  vj_damage dv on dv.id = dam.id left join  vP_SubstationByNetRegion as sub on dv.idSub = sub.id  where dam.dateDoc >= '{2}' and dam.dateDoc < '{3}' and dam.deleted = 0 ) as t  ) as res  pivot  (  count(codeDamage)  for codeDamage in ({1})  ) as pvt ", new object[]
		{
			text,
			text2,
			this.dtpBegin.Value.Date.ToString("yyyyMMdd"),
			Convert.ToDateTime(this.dtpEnd.Value.AddDays(1.0)).Date.ToString("yyyyMMdd")
		});
		SqlDataCommand sqlDataCommand = new SqlDataCommand(this.SqlSettings);
		this.dataTableReport = sqlDataCommand.SelectSqlData(select);
		this.FillTableReportIterruptLVNetworkAreas();
		int countColumns = this.dsDamage.tReportIterruptLV.Columns.Count;
		int countRows = this.dsDamage.tReportIterruptLV.Rows.Count;
		for (int i = 0; i < countRows; i++)
		{
			for (int j = 2; j < countColumns; j++)
			{
				this.dsDamage.tReportIterruptLV.Rows[i][j] = 0;
			}
		}
		foreach (DataRow dataRow2 in this.dataTableReport.Rows)
		{
			for (int k = 0; k < countRows; k++)
			{
				if (dataRow2["numNetRegion"] != DBNull.Value)
				{
					if ((int)dataRow2["numNetRegion"] == (int)this.dsDamage.tReportIterruptLV.Rows[k]["numNetRegion"])
					{
						for (int l = 2; l < countColumns; l++)
						{
							if ((int)dataRow2[l - 1] > 0)
							{
								this.dsDamage.tReportIterruptLV.Rows[k][l] = dataRow2[l - 1];
							}
						}
					}
				}
				else
				{
					for (int m = 2; m < countColumns; m++)
					{
						if ((int)dataRow2[m - 1] > 0)
						{
							this.dsDamage.tReportIterruptLV.Rows[countRows - 1][m] = dataRow2[m - 1];
						}
					}
				}
			}
		}
         
		bool flag = true;
        for (int n = 0; n < countRows; n++)
        {
            if ((int)this.dsDamage.tReportIterruptLV.Rows[n]["numNetRegion"] != 0)
            {
                continue;
            }
            for (int num = 2; num < countColumns; num++)
            {
                if (((int)this.dsDamage.tReportIterruptLV[n][num]) != 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                this.dsDamage.tReportIterruptLV.Rows.RemoveAt(n);
            }
        }

        this.bsReportIterruptLV.DataSource = this.dsDamage.tReportIterruptLV;
	}

    /// <summary>
    /// заполняем поля утвердителя, диапозон бюллетня и обновляем отчет на основании данных
    /// </summary>
    private void FillReportApproveAndRefreshReport()
	{
		this.rViewerDoc.LocalReport.ReportEmbeddedResource = "DailyReportN.Reports.reportInterruptLV.rdlc";
		List<ReportParameter> list = new List<ReportParameter>();
		list.Add(new ReportParameter("dateBegin", this.dtpBegin.Value.ToString("dd.MM.yyyy")));
		list.Add(new ReportParameter("dateEnd", this.dtpEnd.Value.ToString("dd.MM.yyyy")));
		list.Add(new ReportParameter("post", this.txtPost.Text));
		list.Add(new ReportParameter("FIO", this.GetFIOApprove()));
		list.Add(new ReportParameter("hiddenConfirm", this.hiddenConfirm.ToString()));
		if (string.IsNullOrEmpty(this.txtPost.Text))
		{
			list.Add(new ReportParameter("line", "true"));
		}
		else
		{
			list.Add(new ReportParameter("line", "false"));
		}
		this.rViewerDoc.LocalReport.SetParameters(list);
		this.rViewerDoc.RefreshReport();
	}
    /// <summary>
    /// вернуть фамилию утвердителя
    /// </summary>
    /// <returns></returns>
	private string GetFIOApprove()
	{
		string text = "_______";
		Font font = new Font("Arial", 10f);
        //высота текста утвердителя
		double WidthApprove = this.Width1 * this.Width0 + 39.0;
		text += this.txtFIO.Text;
		Size size = TextRenderer.MeasureText(text, font);
		if ((double)size.Width <= WidthApprove)
		{
			if (WidthApprove - (double)size.Width >= 2.0)
			{
				while ((double)size.Width < WidthApprove - 13.0)
				{
					text = text.Insert(1, "_");
					size = TextRenderer.MeasureText(text, font);
				}
				return text;
			}
		}
		while ((double)size.Width > WidthApprove || WidthApprove - (double)size.Width < 2.0)
		{
			text = text.Remove(text.Length - 1);
			size = TextRenderer.MeasureText(text, font);
		}
		return text;
	}

	private void dtpBegin_ValueChanged(object sender, EventArgs e)
	{
		if (this.dtpEnd.Value < this.dtpBegin.Value)
		{
			this.dtpEnd.Value = this.dtpBegin.Value;
		}
	}

	private void dtpEnd_ValueChanged(object sender, EventArgs e)
	{
		if (this.dtpEnd.Value < this.dtpBegin.Value)
		{
			this.dtpBegin.Value = this.dtpEnd.Value;
		}
	}

	private void checkBoxcheckBoxApprove_CheckedChanged(object sender, EventArgs e)
	{
		if (this.checkBoxApprove.Checked)
		{
			this.hiddenConfirm = false;
		}
		else
		{
			this.hiddenConfirm = true;
		}
		this.FillReportApproveAndRefreshReport();
	}

	private void txtPost_Leave(object sender, EventArgs e)
	{
		if (!this.hiddenConfirm)
		{
			this.FillReportApproveAndRefreshReport();
		}
	}

	private void txtFIO_Leave(object sender, EventArgs e)
	{
		if (!this.hiddenConfirm)
		{
			this.FillReportApproveAndRefreshReport();
		}
	}

	private void btnApply_Click(object sender, EventArgs e)
	{
		this.FillFullReport();
		this.FillReportApproveAndRefreshReport();
	}

	private void FormReportInterruptLV_FormClosed(object sender, FormClosedEventArgs e)
	{
		XDocument xdocument = new XDocument(new XDeclaration("1.0", "utf-16", null), new object[]
		{
			new XElement("confirm", new object[]
			{
				new XAttribute("post", this.txtPost.Text),
				new XAttribute("FIO", this.txtFIO.Text),
				new XAttribute("visible", this.checkBoxApprove.Checked.ToString())
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
		dataRow["module"] = "ReportInterruptLV";
		this.dataTableSettings.Rows.Add(dataRow);
		this.dataTableSettings.Rows[0].EndEdit();
		base.InsertSqlData(this.dataTableSettings);
	}

}
