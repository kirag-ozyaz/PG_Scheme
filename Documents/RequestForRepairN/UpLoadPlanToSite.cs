using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using DataSql;

/// <summary>
/// Выгрузка информации о плановых работах
/// </summary>
internal static class UpLoadPlanToSite
{
	internal static DataTable LoadTable(SQLSettings sqlsettings, DateTime dateTimeBeg, DateTime dateTimeEnd)
	{
		string text = "'" + dateTimeBeg.Date.ToString("yyyyMMdd") + "'";
		string text2 = "'" + dateTimeEnd.Date.ToString("yyyyMMdd") + " 23:59:59'";
		string text3 = string.Concat(new string[]
		{
			" ((dateTripBeg >= ",
			text,
			" and datetripBEg <= ",
			text2,
			") or (datetripend >= ",
			text,
			" and datetripEnd <= ",
			text2,
			") or (datetripBeg <= ",
			text,
			" and dateTRipEnd >= ",
			text2,
			")) "
		});
		string text4 = " (idDivision = " + UpLoadPlanToSite.Division.ToString() + ") ";
		DataTable dataTable = new DataTable();
		using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString()))
		{
			try
			{
				sqlConnection.Open();
				new SqlDataAdapter(string.Concat(new string[]
				{
					"select * from vJ_RequestForRepairDaily where ",
					text3,
					" and ",
					text4,
					" and deleted = 0  and sendSite = 1 and (crash = 0 or crash is null) and agreed = 1  order by sr, id, datetripBeg"
				}), sqlConnection).Fill(dataTable);
				if (dateTimeBeg.Date == dateTimeEnd.Date)
				{
					foreach (DataRow dataRow in dataTable.Rows)
					{
						if (dateTimeBeg.Date > Convert.ToDateTime(dataRow["dateTripBeg"]))
						{
							dataRow["dateTRipBeg"] = dateTimeBeg.Date;
						}
						if (dateTimeEnd.Date.AddDays(1.0).AddMinutes(-1.0) < Convert.ToDateTime(dataRow["DateTripEnd"]))
						{
							dataRow["dateTripEnd"] = dateTimeEnd.Date.AddDays(1.0).AddMinutes(-1.0);
						}
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message, ex.InnerException);
			}
		}
		return dataTable;
	}

	internal static void CreateHTMLPlan(SQLSettings sqlsettings, string fileName, DateTime dateTimeBeg, DateTime dateTimeEnd)
	{
		StringBuilder textFile = new StringBuilder();
		textFile.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\"lang=\"ru\" xml:lang=\"ru\">\r\n                            <html>\r\n                            <meta http-equiv=\"Content-Language\" content=\"ru\" />\r\n                             <meta http-equiv=\"Content-Type\" content=\"text/html; charset=windows-1251\" />\r\n                             <head>\r\n                            <title></title>\r\n                            <BASEFONT FACE=\"Arial\" SIZE=8>\r\n                            <style>\r\n                            td,th{\r\n\t                            background-color:#FFFFFF;\r\n\t                            font-size:small;\r\n                            }\r\n                            th{\r\n\t                            text-align:center;\r\n\t                            vertical-align:center;\r\n                            }\r\n                            td{\r\n\t                            vertical-align:top;\r\n                            }\r\n                            .first-cell{\r\n\t                            width:20%;\r\n                            }\r\n                            .last-cell-date{\r\n\t                            width:11%;\r\n                            }\r\n                            .cell-status{\r\n\t                            width:19%;\r\n                            }\r\n                            .last-cell-time{\r\n\t                        width:8%;\r\n                            }\r\n                            .cell_sr{\r\n                                width:100%;\r\n                            }\r\n                            </style>\r\n                            <script type=\"text/javascript\">\r\n                            function doResize(){\r\n\t                            document.getElementById('t-header').setAttribute('width',document.getElementById('t-data').offsetWidth);\r\n                            }\r\n                            </script>\r\n                            </head>\r\n                            <body onLoad=\"doResize()\" onResize=\"doResize()\">");
		textFile.Append("<table  id=\"t-header\" style = \" position:fixed; top:0px; height:85px; z-index:1000;background-color:black;\">\n");
		textFile.Append("<TR>\n");
		textFile.Append("<th    COLSPAN=8><I><B>Плановые работы в сетях МУП \"УльГЭС\"</B></I></FONT>");
		textFile.Append("</tr>\n");
		textFile.Append("<TR>\n");
		textFile.Append(string.Format("<th    COLSPAN=8><I><B>за период с {0}г. по {1}г.</B></I></FONT>", dateTimeBeg.ToString("dd.MM.yyyy"), dateTimeEnd.ToString("dd.MM.yyyy")));
		textFile.Append("</tr>\n");
		textFile.Append("<TR>\n");
		textFile.Append("<th  class=\"first-cell\" ALIGN=CENTER  ROWSPAN=2><B>Отключаемый <br />объект</B>\r\n\t\t\t                 <th    ROWSPAN=2><B>Адрес</B>\r\n\t\t\t                 <th    COLSPAN=2><B>Отключение</B>\r\n\t\t\t                 <th    COLSPAN=2><B>Включение</B>\r\n\t\t\t                 <th   class=\"cell-status\" ROWSPAN=2><B>Статус</B>");
		textFile.Append("</tr>\n");
		textFile.Append("<TR>\n");
		textFile.Append("<th class=\"last-cell-date\"    ><B>Дата</B>\r\n\t\t\t                <th class=\"last-cell-time\"    ><B>Время</B>\r\n\t\t\t                <th class=\"last-cell-date\"    ><B>Дата</B>\r\n\t\t\t                <th class=\"last-cell-time\"    ><B>Время</B>");
		textFile.Append("</tr>\n");
		textFile.Append("</table>\n");
		textFile.Append("<TABLE id=\"t-data\" style=\"width:100%; position:relative;top:75px;background-color:black;\">\n");
		textFile.Append("<tbody>\n");
		DataTable dataTable = UpLoadPlanToSite.LoadTable(sqlsettings, dateTimeBeg, dateTimeEnd);
		int idSR = -1;
		if (dataTable.Rows.Count == 0)
		{
			textFile.Append("<TR>\n");
			textFile.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#bfffff;\">плановых работ в электрических сетях МУП \"УльГЭС\" нет\n");
			textFile.Append("</tr>\n");
		}
		for (int i = 0; i < dataTable.Rows.Count; i++)
		{
			DataRow dataRow = dataTable.Rows[i];
			string strDatetripBeg = dataRow["datetripbeg"].ToString();
			string strDatetripEnd = dataRow["datetripend"].ToString();
			int num2 = i;
			int num3 = 0;
			for (;;)
			{
				num2++;
				if (num2 >= dataTable.Rows.Count || Convert.ToInt32(dataRow["id"]) != Convert.ToInt32(dataTable.Rows[num2]["id"]))
				{
					break;
				}
				strDatetripBeg = strDatetripBeg + "\n" + dataRow["datetripbeg"].ToString();
				strDatetripEnd = strDatetripEnd + "\n" + dataRow["datetripend"].ToString();
				num3++;
			}
			if (idSR != Convert.ToInt32(dataRow["idSR"]))
			{
				textFile.Append("<TR>\n");
				string strSR = UpLoadPlanToSite.GetDivision(dataRow["SR"].ToString());
				textFile.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#c0dcc0;\">" + strSR + "\n");
				textFile.Append("</tr>\n");
				idSR = Convert.ToInt32(dataRow["idSR"]);
			}
			textFile.Append("<TR>\n");
			string text = dataRow["SchmObj"].ToString();
			text = text.Replace(",", ", ");
			text = text.Replace(",  ", ", ");
			textFile.Append(string.Format("<TD class=\"first-cell\" >{0}\n", text));
			string text2 = (dataRow["Address"] == DBNull.Value || string.IsNullOrEmpty(dataRow["Address"].ToString())) ? "&nbsp;" : dataRow["Address"].ToString();
			List<string> list = text2.Split(new string[]
			{
				"\r\n"
			}, StringSplitOptions.None).ToList<string>();
			if (list.Count > 1 && list.Contains(""))
			{
				list.Remove("");
			}
			list.Sort();
			text2 = string.Join("<br>", list.ToArray());
			text2 = text2.Replace(",", ", ");
			text2 = text2.Replace(",  ", ", ");
			textFile.Append(string.Format("<TD >{0}\n", text2));
			string text3 = "";
			string text4 = "";
			string text5 = "";
			string text6 = "";
			num2 = i;
			num3 = 0;
			for (;;)
			{
				num2++;
				if (num2 >= dataTable.Rows.Count || Convert.ToInt32(dataRow["id"]) != Convert.ToInt32(dataTable.Rows[num2]["id"]))
				{
					break;
				}
				DataRow dataRow2 = dataTable.Rows[num2];
				text3 = text3 + "<br>" + Convert.ToDateTime(dataRow2["datetripbeg"]).Date.ToShortDateString();
				text5 = text5 + "<br>" + Convert.ToDateTime(dataRow2["datetripbeg"]).ToShortTimeString();
				text4 = text4 + "<br>" + Convert.ToDateTime(dataRow2["datetripEnd"]).Date.ToShortDateString();
				text6 = text6 + "<br>" + Convert.ToDateTime(dataRow2["datetripEnd"]).ToShortTimeString();
				num3++;
			}
			textFile.Append("<TD class=\"last-cell-date\">" + Convert.ToDateTime(dataRow["datetripbeg"]).Date.ToShortDateString() + text3 + "\n");
			textFile.Append("<TD class=\"last-cell-time\">" + Convert.ToDateTime(dataRow["datetripbeg"]).ToShortTimeString() + text5 + "\n");
			textFile.Append("<TD class=\"last-cell-date\">" + Convert.ToDateTime(dataRow["datetripEnd"]).Date.ToShortDateString() + text4 + "\n");
			textFile.Append("<TD class=\"last-cell-time\">" + Convert.ToDateTime(dataRow["datetripEnd"]).ToShortTimeString() + text6 + "\n");
			string arg = (dataRow["SiteStatus"] == DBNull.Value || string.IsNullOrEmpty(dataRow["SiteStatus"].ToString())) ? "&nbsp;" : dataRow["SiteStatus"].ToString();
			textFile.Append(string.Format("<TD class=\"cell-status\" >{0}\n", arg));
			i += num3;
		}
		textFile.Append("</tbody>\n");
		textFile.Append("</table>\n");
		textFile.Append("</body>\n");
		textFile.Append("</html>\n");
		UpLoadPlanToSite.SaveToFileHTML(fileName, textFile);
	}

	private static string GetDivision(string str)
	{
		if (str == "Сетевой район №1")
		{
			return "Ленинский район";
		}
		if (str == "Сетевой район №2")
		{
			return "Засвияжский район";
		}
		if (str == "Сетевой район №3")
		{
			return "Железнодорожный район";
		}
		if (!(str == "Сетевой район №4"))
		{
			return "";
		}
		return "Заволжский район";
	}

	private static void SaveToFileHTML(string fileName, StringBuilder TextToFile)
	{
		try
		{
			File.Delete(fileName);
			StreamWriter streamWriter = new StreamWriter(fileName, true, Encoding.GetEncoding(1251));
			streamWriter.Write(TextToFile.ToString());
			streamWriter.Close();
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message, ex.InnerException);
		}
	}

	internal static string GetFullFileName()
	{
		return UpLoadPlanToSite.GetDirectoryRequestForRepair() + UpLoadPlanToSite.FileName;
	}

	internal static void CreateSettingsConnectFTP(SQLSettings sqlsettings)
	{
		using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString()))
		{
			try
			{
				sqlConnection.Open();
				DbDataAdapter dbDataAdapter = new SqlDataAdapter("select [Settings] from tSettings where module = 'FTP05'", sqlConnection);
				DataTable dataTable = new DataTable();
				dbDataAdapter.Fill(dataTable);
				if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Settings"] != DBNull.Value)
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.LoadXml(dataTable.Rows[0]["Settings"].ToString());
					XmlNode xmlNode = xmlDocument.SelectSingleNode("ReqForRepairFTP");
					if (xmlNode != null)
					{
						XmlNode xmlNode2 = xmlNode.SelectSingleNode("FTP");
						if (xmlNode2 != null)
						{
							XmlAttribute xmlAttribute = xmlNode2.Attributes["UseFTP"];
							if (xmlAttribute != null)
							{
								UpLoadPlanToSite.UseFTP = Convert.ToBoolean(xmlAttribute.Value);
							}
							else
							{
								UpLoadPlanToSite.UseFTP = false;
							}
							xmlAttribute = xmlNode2.Attributes["FileName"];
							if (xmlAttribute != null)
							{
								UpLoadPlanToSite.FileName = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["PathName"];
							if (xmlAttribute != null)
							{
								UpLoadPlanToSite.PathName = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["FTPName"];
							if (xmlAttribute != null)
							{
								UpLoadPlanToSite.FTPName = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["User"];
							if (xmlAttribute != null)
							{
								UpLoadPlanToSite.User = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["Pwd"];
							if (xmlAttribute != null)
							{
								UpLoadPlanToSite.Pwd = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["Proxy"];
							if (xmlAttribute != null)
							{
								UpLoadPlanToSite.Proxy = xmlAttribute.Value;
								xmlAttribute = xmlNode2.Attributes["ProxyUser"];
								if (xmlAttribute != null)
								{
									UpLoadPlanToSite.ProxyUser = xmlAttribute.Value;
								}
								xmlAttribute = xmlNode2.Attributes["ProxyPwd"];
								if (xmlAttribute != null)
								{
									UpLoadPlanToSite.ProxyPwd = xmlAttribute.Value;
								}
							}
							XmlNode xmlNode3 = xmlNode2.SelectSingleNode("Shedule");
							if (xmlNode3 != null)
							{
								xmlAttribute = xmlNode3.Attributes["Start"];
								if (xmlAttribute != null)
								{
									UpLoadPlanToSite.Shedule = Convert.ToDateTime(xmlAttribute.Value);
								}
								xmlAttribute = xmlNode3.Attributes["Period"];
								if (xmlAttribute != null)
								{
									UpLoadPlanToSite.Period = Convert.ToInt32(xmlAttribute.Value);
								}
								xmlNode2 = xmlNode.SelectSingleNode("PathCURL");
								if (xmlNode2 != null && !string.IsNullOrEmpty(xmlNode2.InnerText))
								{
									UpLoadPlanToSite.PathCURL = xmlNode2.InnerText;
								}
							}
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

	private static string GetDirectoryRequestForRepair()
	{
		string str = "EIS\\RequestForRepair";
		string text = Path.GetTempPath() + "\\" + str + "\\";
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return text;
	}

	internal static void StartProcessUpload()
	{
		if (UseFTP)
		{
			CURLProcessUpLoadToURL.StartFTP(PathCURL, FTPName, User, Pwd, GetFullFileName(), Proxy, ProxyUser, ProxyPwd);
		}
	}

    private static int Division = 920;
    private static bool UseFTP = true;
    private static string FileName = "plan_rabota.php";
    private static string PathName = "";
    private static string FTPName = "";
    private static string User = "";
    private static string Pwd = "";
    private static string Proxy = "";
    private static string ProxyUser = "";
    private static string ProxyPwd = "";
    private static DateTime Shedule = DateTime.MinValue;
    private static int Period = 0;
    private static string PathCURL = "";
}
