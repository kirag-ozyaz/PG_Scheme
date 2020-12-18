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
/// Выгрузка информации об аварийных отключениях
/// </summary>
internal static class UpLoadCrashToSite
{
	internal static DataTable LoadTable(SQLSettings sqlsettings, DateTime dateTimeBeg)
	{
		string arg = "'" + dateTimeBeg.Date.ToString("yyyyMMdd") + "'";
		string arg2 = "'" + dateTimeBeg.Date.ToString("yyyyMMdd") + " 23:59:59'";
		string text = string.Format("(dateFactEnd is null or (dateFactEnd >= {0} and dateFactEnd <= {1}))", arg, arg2);
		string text2 = " (idDivision = " + UpLoadCrashToSite.Division.ToString() + ") ";
		string connectionString = sqlsettings.GetConnectionString();
		DataTable dataTable = new DataTable();
		SqlConnection sqlConnection = new SqlConnection(connectionString);
		try
		{
			sqlConnection.Open();
			new SqlDataAdapter(string.Concat(new string[]
			{
				"select * from vJ_RequestForRepairDaily where ",
				text,
				" and ",
				text2,
				" and deleted = 0  and sendSite = 1 and crash = 1 and agreed = 1  order by sr, id, datetripBeg"
			}), sqlConnection).Fill(dataTable);
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message, ex.InnerException);
		}
		return dataTable;
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

	internal static void CreateHTMLCrash(SQLSettings sqlsettings, string FileName, DateTime dateTimeBeg)
	{
		StringBuilder textFile = new StringBuilder();
		textFile.Append("<html>\n");
		textFile.Append("<head>\n");
		textFile.Append("<title></title>\n");
		textFile.Append("<BASEFONT FACE=\"Arial\" SIZE=8>\n");
		textFile.Append("</head>\n");
		textFile.Append("<body>\n");
		textFile.Append("<TABLE BORDER CELLSPACING=0>\n");
		textFile.Append("<TR>\n");
		textFile.Append("<TD ALIGN=CENTER BORDERCOLOR=#ffffff COLSPAN=8><FONT SIZE=2><I><B>Информация об аварийных отключениях за " + dateTimeBeg.ToShortDateString() + "г.</B></I></FONT>\n");
		textFile.Append("</tr>\n");
		textFile.Append("<TR>\n");
		textFile.Append("<TD WIDTH=20% ALIGN=CENTER VALIGN=CENTER ROWSPAN=2><FONT SIZE=2><B>Отключаемый объект</B></FONT>\n");
		textFile.Append("<TD ALIGN=CENTER VALIGN=CENTER ROWSPAN=2><FONT SIZE=2><B>Адрес</B></FONT>\n");
		textFile.Append("<TD ALIGN=CENTER VALIGN=CENTER COLSPAN=2><FONT SIZE=2><B>Отключение</B></FONT>\n");
		textFile.Append("<TD ALIGN=CENTER VALIGN=CENTER COLSPAN=2><FONT SIZE=2><B>Планируемое включение</B></FONT>\n");
		textFile.Append("<TD ALIGN=CENTER VALIGN=CENTER COLSPAN=2><FONT SIZE=2><B>Факт. включение</B></FONT>\n");
		textFile.Append("</tr>\n");
		textFile.Append("<TR>\n");
		textFile.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Дата</B></FONT>\n");
		textFile.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Время</B></FONT>\n");
		textFile.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Дата</B></FONT>\n");
		textFile.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Время</B></FONT>\n");
		textFile.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Дата</B></FONT>\n");
		textFile.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Время</B></FONT>\n");
		textFile.Append("</tr>\n");
		DataTable dataTable = UpLoadCrashToSite.LoadTable(sqlsettings, dateTimeBeg);
		int num = -1;
		for (int i = 0; i < dataTable.Rows.Count; i++)
		{
			DataRow dataRow = dataTable.Rows[i];
			string str = dataRow["datetripbeg"].ToString();
			string str2 = dataRow["datetripend"].ToString();
			int num2 = i;
			int num3 = 0;
			for (;;)
			{
				num2++;
				if (num2 >= dataTable.Rows.Count || Convert.ToInt32(dataRow["id"]) != Convert.ToInt32(dataTable.Rows[num2]["id"]))
				{
					break;
				}
				str = str + "\n" + dataRow["datetripbeg"].ToString();
				str2 = str2 + "\n" + dataRow["datetripend"].ToString();
				num3++;
			}
			if (num != Convert.ToInt32(dataRow["idSR"]))
			{
				textFile.Append("<TR>\n");
				string str3 = UpLoadCrashToSite.GetDivision(dataRow["SR"].ToString());
				textFile.Append("<TD VALIGN=CENTER BGCOLOR=#c0dcc0 COLSPAN=8><FONT SIZE=2><I><B>" + str3 + "</B></I></FONT>\n");
				textFile.Append("</tr>\n");
				num = Convert.ToInt32(dataRow["idSR"]);
			}
			textFile.Append("<TR>\n");
			string text = "";
			if (dataRow["dateFactEnd"] != DBNull.Value)
			{
				text = "BGCOLOR=#F0F0F0 ";
			}
			string text2 = dataRow["SchmObj"].ToString();
			text2 = text2.Replace(",", ", ");
			text2 = text2.Replace(",  ", ", ");
			textFile.Append(string.Concat(new string[]
			{
				"<TD WIDTH=20% VALIGN=TOP ",
				text,
				" ROWSPAN=",
				(num3 + 1).ToString(),
				"><FONT SIZE=2>",
				text2,
				"</FONT>\n"
			}));
			string text3 = (dataRow["Address"] == DBNull.Value || string.IsNullOrEmpty(dataRow["Address"].ToString())) ? "&nbsp;" : dataRow["Address"].ToString();
			List<string> list = text3.Split(new string[]
			{
				"\r\n"
			}, StringSplitOptions.None).ToList<string>();
			if (list.Count > 1 && list.Contains(""))
			{
				list.Remove("");
			}
			list.Sort();
			text3 = string.Join("<br>", list.ToArray());
			text3 = text3.Replace(",", ", ");
			text3 = text3.Replace(",  ", ", ");
			textFile.Append(string.Concat(new string[]
			{
				"<TD VALIGN=CENTER ",
				text,
				"  ROWSPAN=",
				(num3 + 1).ToString(),
				"><FONT SIZE=2>",
				text3,
				"</FONT>\n"
			}));
			textFile.Append(string.Concat(new string[]
			{
				"<TD VALIGN=TOP ",
				text,
				" ><FONT SIZE=2>",
				Convert.ToDateTime(dataRow["datetripbeg"]).Date.ToShortDateString(),
				"</FONT>\n"
			}));
			textFile.Append(string.Concat(new string[]
			{
				"<TD VALIGN=TOP ",
				text,
				" ><FONT SIZE=2>",
				Convert.ToDateTime(dataRow["datetripbeg"]).ToShortTimeString(),
				"</FONT>\n"
			}));
			textFile.Append(string.Concat(new string[]
			{
				"<TD VALIGN=TOP ",
				text,
				" ><FONT SIZE=2>",
				Convert.ToDateTime(dataRow["datetripEnd"]).Date.ToShortDateString(),
				"</FONT>\n"
			}));
			textFile.Append(string.Concat(new string[]
			{
				"<TD VALIGN=TOP ",
				text,
				" ><FONT SIZE=2>",
				Convert.ToDateTime(dataRow["datetripEnd"]).ToShortTimeString(),
				"</FONT>\n"
			}));
			string text4 = "";
			string text5 = "";
			if (dataRow["dateFactEnd"] != DBNull.Value)
			{
				text4 = Convert.ToDateTime(dataRow["dateFactEnd"]).Date.ToShortDateString();
				text5 = Convert.ToDateTime(dataRow["dateFactEnd"]).ToShortTimeString();
			}
			textFile.Append(string.Concat(new string[]
			{
				"<TD VALIGN=TOP ",
				text,
				" ROWSPAN=",
				(num3 + 1).ToString(),
				"><FONT SIZE=2>",
				text4,
				"</FONT>\n"
			}));
			textFile.Append(string.Concat(new string[]
			{
				"<TD VALIGN=TOP ",
				text,
				" ROWSPAN=",
				(num3 + 1).ToString(),
				"><FONT SIZE=2>",
				text5,
				"</FONT>\n"
			}));
			textFile.Append("</tr>\n");
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
				textFile.Append("<tr>\n");
				textFile.Append(string.Concat(new string[]
				{
					"<TD VALIGN=TOP ",
					text,
					" ><FONT SIZE=2>",
					Convert.ToDateTime(dataRow2["datetripbeg"]).Date.ToShortDateString(),
					"</FONT>\n"
				}));
				textFile.Append(string.Concat(new string[]
				{
					"<TD VALIGN=TOP ",
					text,
					" ><FONT SIZE=2>",
					Convert.ToDateTime(dataRow2["datetripbeg"]).ToShortTimeString(),
					"</FONT>\n"
				}));
				textFile.Append(string.Concat(new string[]
				{
					"<TD VALIGN=TOP ",
					text,
					" ><FONT SIZE=2>",
					Convert.ToDateTime(dataRow2["datetripEnd"]).Date.ToShortDateString(),
					"</FONT>\n"
				}));
				textFile.Append(string.Concat(new string[]
				{
					"<TD VALIGN=TOP ",
					text,
					" ><FONT SIZE=2>",
					Convert.ToDateTime(dataRow2["datetripEnd"]).ToShortTimeString(),
					"</FONT>\n"
				}));
				textFile.Append("</tr>\n");
				num3++;
			}
			i += num3;
		}
		textFile.Append("</table>\n");
		textFile.Append("</body>\n");
		textFile.Append("</html>\n");
		UpLoadCrashToSite.SaveToFileHTML(FileName, textFile);
	}

	internal static void CreateHTMLCrashN2(SQLSettings sqlsettings, string FileName, DateTime dateTimeBeg)
	{
		StringBuilder textFile = new StringBuilder();
		textFile.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\"lang=\"ru\" xml:lang=\"ru\">\r\n                            <html>\r\n                            <meta http-equiv=\"Content-Language\" content=\"ru\" />\r\n                             <meta http-equiv=\"Content-Type\" content=\"text/html; charset=windows-1251\" />\r\n                             <head>\r\n                            <title></title>\r\n                            <BASEFONT FACE=\"Arial\" SIZE=8>\r\n                            <style>\r\n                            td,th{\r\n\t                            background-color:#FFFFFF;\r\n\t                            font-size:small;\r\n                            }\r\n                            th{\r\n\t                            text-align:center;\r\n\t                            vertical-align:center;\r\n                            }\r\n                            td{\r\n\t                            vertical-align:top;\r\n                            }\r\n                            .first-cell{\r\n\t                            width:20%;\r\n                            }\r\n                            .last-cell-date{\r\n\t                            width:11%;\r\n                            }\r\n                            .last-cell-time{\r\n\t                        width:8%;\r\n                            }\r\n                            .cell_sr{\r\n                                width:100%;\r\n                            }\r\n                            </style>\r\n                            <script type=\"text/javascript\">\r\n                            function doResize(){\r\n\t                            document.getElementById('t-header').setAttribute('width',document.getElementById('t-data').offsetWidth);\r\n                            }\r\n                            </script>\r\n                            </head>\r\n                            <body onLoad=\"doResize()\" onResize=\"doResize()\">");
		textFile.Append("<table  id=\"t-header\" style = \" position:fixed; top:0px; height:85px; z-index:1000;background-color:black;\">\n");
		textFile.Append("<TR>\n");
		textFile.Append("<th    COLSPAN=8><I><B>Оперативная информация об аварийных отключениях на \r\n                                <?php\r\n                                echo date( 'H:i Y-m-d ');\r\n                                ?>  \r\n                                </B></I></FONT>");
		textFile.Append("</tr>\n");
		textFile.Append("<TR>\n");
		textFile.Append("<th  class=\"first-cell\" ALIGN=CENTER  ROWSPAN=2><B>Отключаемый <br />объект</B>\r\n\t\t\t                 <th    ROWSPAN=2><B>Адрес</B>\r\n\t\t\t                 <th    COLSPAN=2><B>Отключение</B>\r\n\t\t\t                 <th    COLSPAN=2><B>Планируемое <br />включение</B>\r\n\t\t\t                 <th    COLSPAN=2><B>Факт. <br />включение</B>");
		textFile.Append("</tr>\n");
		textFile.Append("<TR>\n");
		textFile.Append("<th class=\"last-cell-date\"    ><B>Дата</B>\r\n\t\t\t                <th class=\"last-cell-time\"    ><B>Время</B>\r\n\t\t\t                <th class=\"last-cell-date\"    ><B>Дата</B>\r\n\t\t\t                <th class=\"last-cell-time\"    ><B>Время</B>\r\n\t\t\t                <th class=\"last-cell-date\"    ><B>Дата</B>\r\n\t\t\t                <th class=\"last-cell-time\"    ><B>Время</B>");
		textFile.Append("</tr>\n");
		textFile.Append("</table>\n");
		textFile.Append("<TABLE id=\"t-data\" style=\"width:100%; position:relative;top:75px;background-color:black;\">\n");
		textFile.Append("<tbody>\n");
		DataTable dataTable = UpLoadCrashToSite.LoadTable(sqlsettings, dateTimeBeg);
		int num = -1;
		if (dataTable.Rows.Count == 0)
		{
			textFile.Append("<TR>\n");
			textFile.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#bfffff;\">аварийных отключений в электрических сетях МУП \"УльГЭС\" нет\n");
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
			if (num != Convert.ToInt32(dataRow["idSR"]))
			{
				textFile.Append("<TR>\n");
				string str3 = UpLoadCrashToSite.GetDivision(dataRow["SR"].ToString());
				textFile.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#c0dcc0;\">" + str3 + "\n");
				textFile.Append("</tr>\n");
				num = Convert.ToInt32(dataRow["idSR"]);
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
			string strDateFactEnd = "";
			string strTimeFactEnd = "";
			if (dataRow["dateFactEnd"] != DBNull.Value)
			{
				strDateFactEnd = Convert.ToDateTime(dataRow["dateFactEnd"]).Date.ToShortDateString();
				strTimeFactEnd = Convert.ToDateTime(dataRow["dateFactEnd"]).ToShortTimeString();
			}
			textFile.Append(string.Format("<TD class=\"last-cell-date\" >" + strDateFactEnd + "\n", new object[0]));
			textFile.Append(string.Format("<TD class=\"last-cell-time\" >" + strTimeFactEnd + "\n", new object[0]));
			textFile.Append("</tr>\n");
			i += num3;
		}
		textFile.Append("</tbody>\n");
		textFile.Append("</table>\n");
		textFile.Append("</body>\n");
		textFile.Append("</html>\n");
		UpLoadCrashToSite.SaveToFileHTML(FileName, textFile);
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

	internal static string GetFullFileName()
	{
		return UpLoadCrashToSite.GetDirectoryRequestForRepair() + UpLoadCrashToSite.FileName;
	}
    /// <summary>
    /// собираем установки/настройки соединения с ftp севером
    /// </summary>
    /// <param name="sqlsettings"></param>
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
						XmlNode xmlNode2 = xmlNode.SelectSingleNode("FTP05");
						if (xmlNode2 != null)
						{
							XmlAttribute xmlAttribute = xmlNode2.Attributes["UseFTP"];
							if (xmlAttribute != null)
							{
								UpLoadCrashToSite.UseFTP = Convert.ToBoolean(xmlAttribute.Value);
							}
							else
							{
								UpLoadCrashToSite.UseFTP = false;
							}
							xmlAttribute = xmlNode2.Attributes["FileName"];
							if (xmlAttribute != null)
							{
								UpLoadCrashToSite.FileName = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["PathName"];
							if (xmlAttribute != null)
							{
								UpLoadCrashToSite.PathName = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["FTPName"];
							if (xmlAttribute != null)
							{
								UpLoadCrashToSite.FTPName = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["User"];
							if (xmlAttribute != null)
							{
								UpLoadCrashToSite.User = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["Pwd"];
							if (xmlAttribute != null)
							{
								UpLoadCrashToSite.Pwd = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["Proxy"];
							if (xmlAttribute != null)
							{
								UpLoadCrashToSite.Proxy = xmlAttribute.Value;
								xmlAttribute = xmlNode2.Attributes["ProxyUser"];
								if (xmlAttribute != null)
								{
									UpLoadCrashToSite.ProxyUser = xmlAttribute.Value;
								}
								xmlAttribute = xmlNode2.Attributes["ProxyPwd"];
								if (xmlAttribute != null)
								{
									UpLoadCrashToSite.ProxyPwd = xmlAttribute.Value;
								}
							}
							XmlNode xmlNode3 = xmlNode2.SelectSingleNode("Shedule");
							if (xmlNode3 != null)
							{
								xmlAttribute = xmlNode3.Attributes["Start"];
								if (xmlAttribute != null)
								{
									UpLoadCrashToSite.Shedule = Convert.ToDateTime(xmlAttribute.Value);
								}
								xmlAttribute = xmlNode3.Attributes["Period"];
								if (xmlAttribute != null)
								{
									UpLoadCrashToSite.Period = Convert.ToInt32(xmlAttribute.Value);
								}
								xmlNode2 = xmlNode.SelectSingleNode("PathCURL");
								if (xmlNode2 != null && !string.IsNullOrEmpty(xmlNode2.InnerText))
								{
									UpLoadCrashToSite.PathCURL = xmlNode2.InnerText;
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
