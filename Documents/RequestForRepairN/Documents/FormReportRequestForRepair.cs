using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using ControlsLbr.ReportViewerRus;
//using Documents.Properties;
using FormLbr;
using Microsoft.Reporting.WinForms;
/// <summary>
/// Отчет заявок на ремонт оборудования
/// </summary>
internal partial class FormReportRequestForRepair : FormBase
{
    private bool isCrash;
    private string AppoveTitle = "Главный инженер";
    private string AppoveOrg = "МУП \"УльГЭС\"";
    private string AppoveFIO = "Л.Н.Демченко";
    private string SignatureTitle1 = "Начальник ОДС";
    private string SignatureFIO1 = "Л.Г. Белавина";
    private string SignatureTitle2 = "Зам.начальника ОДС";
    private string SignatureFIO2 = "А.Б. Манузин";

    internal FormReportRequestForRepair()
	{
		this.InitializeComponent();
		this.dateTimePickerBeg.Value = (this.dateTimePickerEnd.Value = DateTime.Now);
	}

	internal FormReportRequestForRepair(bool IsCrash = false)
	{
        this.InitializeComponent();
		this.dateTimePickerBeg.Value = (this.dateTimePickerEnd.Value = DateTime.Now);
		this.isCrash = IsCrash;
		if (IsCrash)
		{
			this.Text = "Отчет аварийных заявок на ремонт оборудования";
		}
	}

    private const int NO_DIVISION = 1665;
    private void FillListBoxSR()
    {
        string wSelectByDivision = "";
        if (this.cmdDivision.SelectedValue != null)
            if (Convert.ToInt32(this.cmdDivision.SelectedValue.ToString()) == NO_DIVISION) wSelectByDivision = "SESNO;";

        checkedListBoxSR.Items.Clear();
        DataTable dt = new DataTable("tR_Classifier");
        base.SelectSqlData(dt, true, " where ParentKey = ';NetworkAreas;" + wSelectByDivision + "' and deleted = 0 and isGroup = 0 order by name ");

        //base.SelectSqlData(this.dsReport, this.dsReport.tR_Classifier, true, " where ParentKey = ';NetworkAreas;" + wSelectByDivision + "' and deleted = 0 and isGroup = 0 order by name ");
        foreach (DataRow dataRow in dt.AsEnumerable()) // this.dsReport.tR_Classifier
        {
            FormReportRequestForRepair.SRForRepair @struct = new FormReportRequestForRepair.SRForRepair(Convert.ToInt32(dataRow["id"]), dataRow["name"].ToString());
            this.checkedListBoxSR.Items.Add(@struct, true);
        }

    }
    private void FillCmdDivision()
    {
        //this.cmdDivision.DataSource = null;

        base.SelectSqlData(this.dsReport, this.dsReport.tR_Classifier, true, " where ParentKey = ';Other;DivisionRequestRepair;' and isgroup = 0 and deleted = 0 order by name");
        this.cmdDivision.DataSource = this.dsReport.tR_Classifier;
        this.cmdDivision.DisplayMember = "name";
        this.cmdDivision.ValueMember = "ID";
        this.cmdDivision.SelectedValue = 920;
    }
    private void cmdDivision_SelectionChangeCommitted(object sender, EventArgs e)
    {
        FillListBoxSR();
    }

    private void FormReportRequestForRepair_Load(object sender, EventArgs e)
	{

        FillListBoxSR();
        FillCmdDivision();

        base.LoadFormConfig(null);
        //if (dateTimePickerBeg.Value.Date >= new DateTime(2020,08,01))
        //{
        //    AppoveTitle = "И.о. главный инженер";
        //    AppoveFIO = "Ю.М.Савинов";
        //}
        //else if  (dateTimePickerBeg.Value.Date >= new DateTime(2020, 11, 16))
        //{
        //    AppoveTitle = "Главный инженер";
        //    AppoveFIO = "С.А.Лапшов";
        //}
    }

	private void FormReportRequestForRepair_FormClosed(object sender, FormClosedEventArgs e)
	{
		base.SaveFormConfig(null);
	}

	private void buttonAplly_Click(object sender, EventArgs e)
	{
		if (this.checkBoxShowAdresses.Checked)
		{
			if (this.dateTimePickerBeg.Value.Date == this.dateTimePickerEnd.Value.Date)
			{
				this.reportViewerRus.LocalReport.ReportEmbeddedResource = "RequestForRepairN.Documents.Reports.ReportrequestForRepairFull.rdlc";
			}
			else
			{
				this.reportViewerRus.LocalReport.ReportEmbeddedResource = "RequestForRepairN.Documents.Reports.ReportrequestForRepairFullPeriod.rdlc";
			}
		}
		else if (this.dateTimePickerBeg.Value.Date == this.dateTimePickerEnd.Value.Date)
		{
			this.reportViewerRus.LocalReport.ReportEmbeddedResource = "RequestForRepairN.Documents.Reports.ReportrequestForRepairNoAddress.rdlc";
		}
		else
		{
			this.reportViewerRus.LocalReport.ReportEmbeddedResource = "RequestForRepairN.Documents.Reports.ReportrequestForRepairNoAddressPeriod.rdlc";
		}
		ReportParameter reportParameter = new ReportParameter("DateBegin", this.dateTimePickerBeg.Value.Date.ToString());
		this.reportViewerRus.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter
		});
		reportParameter = new ReportParameter("DateEnd", this.dateTimePickerEnd.Value.Date.ToString());
		this.reportViewerRus.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter
		});
		reportParameter = new ReportParameter("ShowAgreed", (!this.checkBoxIsAgreed.Checked).ToString());
		this.reportViewerRus.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter
		});
		reportParameter = new ReportParameter("AppoveTitle", this.AppoveTitle);
		this.reportViewerRus.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter
		});
		reportParameter = new ReportParameter("AppoveOrg", this.AppoveOrg);
		this.reportViewerRus.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter
		});
		reportParameter = new ReportParameter("AppoveFIO", this.AppoveFIO);
		this.reportViewerRus.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter
		});
		reportParameter = new ReportParameter("SignatureTitle1", string.IsNullOrEmpty(this.SignatureTitle1) ? null : this.SignatureTitle1);
		this.reportViewerRus.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter
		});
		reportParameter = new ReportParameter("SignatureFIO1", string.IsNullOrEmpty(this.SignatureFIO1) ? null : this.SignatureFIO1);
		this.reportViewerRus.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter
		});
		reportParameter = new ReportParameter("SignatureTitle2", string.IsNullOrEmpty(this.SignatureTitle2) ? null : this.SignatureTitle2);
		this.reportViewerRus.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter
		});
		reportParameter = new ReportParameter("SignatureFIO2", string.IsNullOrEmpty(this.SignatureFIO2) ? null : this.SignatureFIO2);
		this.reportViewerRus.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter
		});
		reportParameter = new ReportParameter("isCrash", this.isCrash.ToString());
		this.reportViewerRus.LocalReport.SetParameters(new ReportParameter[]
		{
			reportParameter
		});
		string txtDataBeg = "'" + this.dateTimePickerBeg.Value.Date.ToString("yyyyMMdd") + "'";
		string txtDataEnd = "'" + this.dateTimePickerEnd.Value.Date.ToString("yyyyMMdd") + " 23:59:59'";
		string txtInterval = string.Concat(new string[]
		{
			" ((dateTripBeg >= ",
			txtDataBeg,
			" and datetripBEg <= ",
			txtDataEnd,
			") or (datetripend >= ",
			txtDataBeg,
			" and datetripEnd <= ",
			txtDataEnd,
			") or (datetripBeg <= ",
			txtDataBeg,
			" and dateTRipEnd >= ",
			txtDataEnd,
			")) "
		});
		if (this.checkedListBoxSR.CheckedItems.Count <= 0)
		{
			this.dsReport.vJ_RequestForRepairDaily.Clear();
		}
		else
		{
			string txtListSR = "";
			foreach (object obj in this.checkedListBoxSR.CheckedItems)
			{
				txtListSR = txtListSR + ((FormReportRequestForRepair.SRForRepair)obj).Id.ToString() + ",";
			}
			txtListSR = " (idSR in (" + txtListSR.Remove(txtListSR.Length - 1) + ")) ";
			if (this.cmdDivision.SelectedValue == null)
			{
				this.dsReport.vJ_RequestForRepairDaily.Clear();
			}
			else
			{
				string txtDivision = " (idDivision = " + this.cmdDivision.SelectedValue.ToString() + ") ";
				string txtSchmObj = "";
				if (!string.IsNullOrEmpty(this.txtObject.Text))
				{
					txtSchmObj = " and (schmObj like '%" + this.txtObject.Text + "%') ";
				}
				string txtAgreed = "";
				if (this.checkBoxIsAgreed.Checked)
				{
					txtAgreed = " and (Agreed = 1) ";
				}
				string txtCrash;
				if (this.isCrash)
				{
					txtCrash = " and (Crash = 1) ";
				}
				else
				{
					txtCrash = " and (Crash = 0 or Crash is null) ";
				}
				base.SelectSqlData(this.dsReport, this.dsReport.vJ_RequestForRepairDaily, true, string.Concat(new string[]
				{
					" where ",
					txtInterval,
					" and ",
					txtListSR,
					" and ",
					txtDivision,
					txtSchmObj,
					txtAgreed,
					txtCrash,
					" and deleted = 0 order by sr, id, datetripBeg"
				}));
				this.GroupTableForReport(this.dateTimePickerBeg.Value.Date, this.dateTimePickerEnd.Value.Date);
			}
		}
		this.reportViewerRus.RefreshReport();
	}

	private void GroupTableForReport(DateTime dateBeg, DateTime dateEnd)
	{
		bool flag = dateBeg == dateEnd;
		for (int i = 0; i < this.dsReport.vJ_RequestForRepairDaily.Rows.Count; i++)
		{
			DataRow dataRow = this.dsReport.vJ_RequestForRepairDaily.Rows[i];
			string txtDataBeg = "";
			string txtDataEnd = "";
			string txtTimeEnd = "";
			string txtTimeBeg = "";
			if (!flag)
			{
				txtDataBeg = Convert.ToDateTime(dataRow["DateTripBeg"]).ToShortDateString();
				txtTimeBeg = Convert.ToDateTime(dataRow["DateTripBeg"]).ToShortTimeString();
				txtDataEnd = Convert.ToDateTime(dataRow["DateTripEnd"]).ToShortDateString();
				txtTimeEnd = Convert.ToDateTime(dataRow["DateTripEnd"]).ToShortTimeString();
			}
			else
			{
				if (dateBeg > Convert.ToDateTime(dataRow["DateTripBeg"]))
				{
					txtTimeBeg = "0:00";
				}
				else
				{
					txtTimeBeg = Convert.ToDateTime(dataRow["DateTripBeg"]).ToShortTimeString();
				}
				if (dateEnd.AddDays(1.0).AddMinutes(-1.0) < Convert.ToDateTime(dataRow["DateTripEnd"]))
				{
					txtTimeBeg += " - 23:59";
				}
				else
				{
					txtTimeBeg = txtTimeBeg + " - " + Convert.ToDateTime(dataRow["DateTripEnd"]).ToShortTimeString();
				}
			}
			int num = 1;
			while ((i + num) < this.dsReport.vJ_RequestForRepairDaily.Rows.Count)
			{
				DataRow dataRowDaily = this.dsReport.vJ_RequestForRepairDaily.Rows[i + num];
				if (Convert.ToInt32(dataRow["id"]) != Convert.ToInt32(dataRowDaily["id"]))
				{
					break;
				}
				if (!flag)
				{
					txtDataBeg = txtDataBeg + "\n" + Convert.ToDateTime(dataRowDaily["DateTripBeg"]).ToShortDateString();
					txtTimeBeg = txtTimeBeg + "\n" + Convert.ToDateTime(dataRowDaily["DateTripBeg"]).ToShortTimeString();
					txtDataEnd = txtDataEnd + "\n" + Convert.ToDateTime(dataRowDaily["DateTripEnd"]).ToShortDateString();
					txtTimeEnd = txtTimeEnd + "\n" + Convert.ToDateTime(dataRowDaily["DateTripEnd"]).ToShortTimeString();
				}
				else
				{
					if (dateBeg > Convert.ToDateTime(dataRowDaily["DateTripBeg"]))
					{
						txtTimeBeg += "\n0:00";
					}
					else
					{
						txtTimeBeg = txtTimeBeg + "\n" + Convert.ToDateTime(dataRowDaily["DateTripBeg"]).ToShortTimeString();
					}
					if (dateEnd.AddDays(1.0).AddMinutes(-1.0) < Convert.ToDateTime(dataRowDaily["DateTripEnd"]))
					{
						txtTimeBeg += " - 23:59";
					}
					else
					{
						txtTimeBeg = txtTimeBeg + " - " + Convert.ToDateTime(dataRowDaily["DateTripEnd"]).ToShortTimeString();
					}
				}
				this.dsReport.vJ_RequestForRepairDaily.Rows.Remove(dataRowDaily);
			}
			dataRow["dateBeg"] = txtDataBeg;
			dataRow["dateEnd"] = txtDataEnd;
			dataRow["timeBeg"] = txtTimeBeg;
			dataRow["timeEnd"] = txtTimeEnd;
		}
	}

	private void dateTimePickerBeg_ValueChanged(object sender, EventArgs e)
	{
		this.dateTimePickerEnd.MinDate = this.dateTimePickerBeg.Value;
	}

	private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
	{
		this.dateTimePickerBeg.MaxDate = this.dateTimePickerEnd.Value;
	}

	private void buttonClose_Click(object sender, EventArgs e)
	{
		base.Close();
	}

	private void toolBtnSettings_Click(object sender, EventArgs e)
	{
		FormReportReguestForRepairSettings formReportReguestForRepairSettings = new FormReportReguestForRepairSettings();
		formReportReguestForRepairSettings.AppoveTitle = this.AppoveTitle;
		formReportReguestForRepairSettings.AppoveOrg = this.AppoveOrg;
		formReportReguestForRepairSettings.AppoveFIO = this.AppoveFIO;
		formReportReguestForRepairSettings.SignatureTitle1 = this.SignatureTitle1;
		formReportReguestForRepairSettings.SignatureFIO1 = this.SignatureFIO1;
		formReportReguestForRepairSettings.SignatureTitle2 = this.SignatureTitle2;
		formReportReguestForRepairSettings.SignatureFIO2 = this.SignatureFIO2;
		if (formReportReguestForRepairSettings.ShowDialog() == DialogResult.OK)
		{
			this.AppoveTitle = formReportReguestForRepairSettings.AppoveTitle;
			this.AppoveOrg = formReportReguestForRepairSettings.AppoveOrg;
			this.AppoveFIO = formReportReguestForRepairSettings.AppoveFIO;
			this.SignatureTitle1 = formReportReguestForRepairSettings.SignatureTitle1;
			this.SignatureFIO1 = formReportReguestForRepairSettings.SignatureFIO1;
			this.SignatureTitle2 = formReportReguestForRepairSettings.SignatureTitle2;
			this.SignatureFIO2 = formReportReguestForRepairSettings.SignatureFIO2;
            //
            if (this.tSettings.Rows.Count == 0)
            {
                DataRow row = this.tSettings.NewRow();
                this.tSettings.Rows.Add(row);
            }
            this.tSettings.Rows[0]["Settings"] = this.CreateXmlConfig().InnerXml;
            this.tSettings.Rows[0]["Module"] = SettingModule;
            this.tSettings.Rows[0].EndEdit();
            if (!this.InsertSqlData(this.tSettings))
            {
                return;
            }
            if (!this.UpdateSqlData(this.tSettings))
            {
                return;
            }
            this.Close();
        }
	}
    DataTable tSettings;
    string SettingModule = "ReportRequest"; 
	protected override XmlDocument CreateXmlConfig()
	{
		XmlDocument xmlDocument = new XmlDocument();
		//XmlNode newChild = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);
		//xmlDocument.AppendChild(newChild);
		XmlNode xmlNode = xmlDocument.CreateElement(base.Name);
		xmlDocument.AppendChild(xmlNode);
		XmlAttribute xmlAttribute = xmlDocument.CreateAttribute("appoveTitle");
		xmlAttribute.Value = this.AppoveTitle;
		xmlNode.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("appoveOrg");
		xmlAttribute.Value = this.AppoveOrg;
		xmlNode.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("appoveFIO");
		xmlAttribute.Value = this.AppoveFIO;
		xmlNode.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("signatureTitle1");
		xmlAttribute.Value = this.SignatureTitle1;
		xmlNode.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("signatureFIO1");
		xmlAttribute.Value = this.SignatureFIO1;
		xmlNode.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("signatureTitle2");
		xmlAttribute.Value = this.SignatureTitle2;
		xmlNode.Attributes.Append(xmlAttribute);
		xmlAttribute = xmlDocument.CreateAttribute("signatureFIO2");
		xmlAttribute.Value = this.SignatureFIO2;
		xmlNode.Attributes.Append(xmlAttribute);
		return xmlDocument;
	}
   
    protected override void ApplyConfig(XmlDocument doc)
	{
        //XmlNode xmlNode = doc.SelectSingleNode(base.Name);
        //if (xmlNode != null)
        //{
        //	XmlAttribute xmlAttribute = xmlNode.Attributes["appoveTitle"];
        //	if (xmlAttribute != null)
        //	{
        //		this.AppoveTitle = xmlAttribute.Value;
        //	}
        //	xmlAttribute = xmlNode.Attributes["appoveOrg"];
        //	if (xmlAttribute != null)
        //	{
        //		this.AppoveOrg = xmlAttribute.Value;
        //	}
        //	xmlAttribute = xmlNode.Attributes["appoveFIO"];
        //	if (xmlAttribute != null)
        //	{
        //		this.AppoveFIO = xmlAttribute.Value;
        //	}
        //	xmlAttribute = xmlNode.Attributes["signatureTitle1"];
        //	if (xmlAttribute != null)
        //	{
        //		this.SignatureTitle1 = xmlAttribute.Value;
        //	}
        //	xmlAttribute = xmlNode.Attributes["signatureFIO1"];
        //	if (xmlAttribute != null)
        //	{
        //		this.SignatureFIO1 = xmlAttribute.Value;
        //	}
        //	xmlAttribute = xmlNode.Attributes["signatureTitle2"];
        //	if (xmlAttribute != null)
        //	{
        //		this.SignatureTitle2 = xmlAttribute.Value;
        //	}
        //	xmlAttribute = xmlNode.Attributes["signatureFIO2"];
        //	if (xmlAttribute != null)
        //	{
        //		this.SignatureFIO2 = xmlAttribute.Value;
        //	}
        //}
        /**************************************/
        using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
        {
            try
            {
                tSettings = new DataTable();
                tSettings.TableName = "tSettings";

                //sqlConnection.Open();
                //DbDataAdapter dbDataAdapter = new SqlDataAdapter($"select [id],[Settings],[Module] from {tSettings.TableName} where module = '{SettingModule}'", sqlConnection);
                //dbDataAdapter.Fill(tSettings);
                this.SelectSqlData(tSettings, true, $" where module = '{SettingModule}'");
                this.tSettings.PrimaryKey = new DataColumn[] { tSettings.Columns["id"] };
                if (tSettings.Rows.Count > 0 && tSettings.Rows[0]["Settings"] != DBNull.Value)
                {
                    XmlDocument xmlDocument = new XmlDocument();
                    xmlDocument.LoadXml(tSettings.Rows[0]["Settings"].ToString());
                    XmlNode xmlNode = doc.SelectSingleNode(base.Name);
                    if (xmlNode != null)
                    {
                        XmlAttribute xmlAttribute = xmlNode.Attributes["appoveTitle"];
                        if (xmlAttribute != null)
                        {
                            this.AppoveTitle = xmlAttribute.Value;
                        }
                        xmlAttribute = xmlNode.Attributes["appoveOrg"];
                        if (xmlAttribute != null)
                        {
                            this.AppoveOrg = xmlAttribute.Value;
                        }
                        xmlAttribute = xmlNode.Attributes["appoveFIO"];
                        if (xmlAttribute != null)
                        {
                            this.AppoveFIO = xmlAttribute.Value;
                        }
                        xmlAttribute = xmlNode.Attributes["signatureTitle1"];
                        if (xmlAttribute != null)
                        {
                            this.SignatureTitle1 = xmlAttribute.Value;
                        }
                        xmlAttribute = xmlNode.Attributes["signatureFIO1"];
                        if (xmlAttribute != null)
                        {
                            this.SignatureFIO1 = xmlAttribute.Value;
                        }
                        xmlAttribute = xmlNode.Attributes["signatureTitle2"];
                        if (xmlAttribute != null)
                        {
                            this.SignatureTitle2 = xmlAttribute.Value;
                        }
                        xmlAttribute = xmlNode.Attributes["signatureFIO2"];
                        if (xmlAttribute != null)
                        {
                            this.SignatureFIO2 = xmlAttribute.Value;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }


    }

	private struct SRForRepair
	{
        public int Id;
        public string Name;

        public SRForRepair(int id, string name)
		{
			this.Id = id;
			this.Name = name;
		}

		public override string ToString()
		{
			return this.Name;
		}
	}

  
}
