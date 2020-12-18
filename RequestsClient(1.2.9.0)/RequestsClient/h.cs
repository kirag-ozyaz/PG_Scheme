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

// Token: 0x0200000D RID: 13
internal static class h
{
	// Token: 0x06000054 RID: 84 RVA: 0x00005A08 File Offset: 0x00003C08
	internal static DataTable a(SQLSettings A_0, DateTime A_1, DateTime A_2)
	{
		string text = "'" + A_1.Date.ToString("yyyyMMdd") + "'";
		string text2 = "'" + A_2.Date.ToString("yyyyMMdd") + " 23:59:59'";
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
		string text4 = " (idDivision = " + global::h.a.ToString() + ") ";
		DataTable dataTable = new DataTable();
		using (SqlConnection sqlConnection = new SqlConnection(A_0.GetConnectionString()))
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
					" and deleted = 0  and sendSite = 1  order by sr, id, datetripBeg"
				}), sqlConnection).Fill(dataTable);
				if (A_1.Date == A_2.Date)
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						if (A_1.Date > Convert.ToDateTime(dataRow["dateTripBeg"]))
						{
							dataRow["dateTRipBeg"] = A_1.Date;
						}
						if (A_2.Date.AddDays(1.0).AddMinutes(-1.0) < Convert.ToDateTime(dataRow["DateTripEnd"]))
						{
							dataRow["dateTripEnd"] = A_2.Date.AddDays(1.0).AddMinutes(-1.0);
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

	// Token: 0x06000055 RID: 85 RVA: 0x00005CB4 File Offset: 0x00003EB4
	internal static void a(SQLSettings A_0, string A_1, DateTime A_2, DateTime A_3)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\"lang=\"ru\" xml:lang=\"ru\">\r\n                            <html>\r\n                            <meta http-equiv=\"Content-Language\" content=\"ru\" />\r\n                             <meta http-equiv=\"Content-Type\" content=\"text/html; charset=windows-1251\" />\r\n                             <head>\r\n                            <title></title>\r\n                            <BASEFONT FACE=\"Arial\" SIZE=8>\r\n                            <style>\r\n                            td,th{\r\n\t                            background-color:#FFFFFF;\r\n\t                            font-size:small;\r\n                            }\r\n                            th{\r\n\t                            text-align:center;\r\n\t                            vertical-align:center;\r\n                            }\r\n                            td{\r\n\t                            vertical-align:top;\r\n                            }\r\n                            .first-cell{\r\n\t                            width:20%;\r\n                            }\r\n                            .last-cell-date{\r\n\t                            width:11%;\r\n                            }\r\n                            .cell-status{\r\n\t                            width:19%;\r\n                            }\r\n                            .last-cell-time{\r\n\t                        width:8%;\r\n                            }\r\n                            .cell_sr{\r\n                                width:100%;\r\n                            }\r\n                            </style>\r\n                            <script type=\"text/javascript\">\r\n                            function doResize(){\r\n\t                            document.getElementById('t-header').setAttribute('width',document.getElementById('t-data').offsetWidth);\r\n                            }\r\n                            </script>\r\n                            </head>\r\n                            <body onLoad=\"doResize()\" onResize=\"doResize()\">");
		stringBuilder.Append("<table  id=\"t-header\" style = \" position:fixed; top:0px; height:85px; z-index:1000;background-color:black;\">\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append("<th    COLSPAN=8><I><B>Плановые работы в сетях МУП \"УльГЭС\"</B></I></FONT>");
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append(string.Format("<th    COLSPAN=8><I><B>за период с {0}г. по {1}г.</B></I></FONT>", A_2.ToString("dd.MM.yyyy"), A_3.ToString("dd.MM.yyyy")));
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append("<th  class=\"first-cell\" ALIGN=CENTER  ROWSPAN=2><B>Отключаемый <br />объект</B>\r\n\t\t\t                 <th    ROWSPAN=2><B>Адрес</B>\r\n\t\t\t                 <th    COLSPAN=2><B>Отключение</B>\r\n\t\t\t                 <th    COLSPAN=2><B>Включение</B>\r\n\t\t\t                 <th   class=\"cell-status\" ROWSPAN=2><B>Статус</B>");
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append("<th class=\"last-cell-date\"    ><B>Дата</B>\r\n\t\t\t                <th class=\"last-cell-time\"    ><B>Время</B>\r\n\t\t\t                <th class=\"last-cell-date\"    ><B>Дата</B>\r\n\t\t\t                <th class=\"last-cell-time\"    ><B>Время</B>");
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("</table>\n");
		stringBuilder.Append("<TABLE id=\"t-data\" style=\"width:100%; position:relative;top:75px;background-color:black;\">\n");
		stringBuilder.Append("<tbody>\n");
		DataTable dataTable = global::h.a(A_0, A_2, A_3);
		int num = -1;
		if (dataTable.Rows.Count == 0)
		{
			stringBuilder.Append("<TR>\n");
			stringBuilder.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#bfffff;\">плановых работ в электрических сетях МУП \"УльГЭС\" нет\n");
			stringBuilder.Append("</tr>\n");
		}
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
				stringBuilder.Append("<TR>\n");
				string str3 = global::h.a(dataRow["SR"].ToString());
				stringBuilder.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#c0dcc0;\">" + str3 + "\n");
				stringBuilder.Append("</tr>\n");
				num = Convert.ToInt32(dataRow["idSR"]);
			}
			stringBuilder.Append("<TR>\n");
			string text = dataRow["SchmObj"].ToString();
			text = text.Replace(",", ", ");
			text = text.Replace(",  ", ", ");
			stringBuilder.Append(string.Format("<TD class=\"first-cell\" >{0}\n", text));
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
			stringBuilder.Append(string.Format("<TD >{0}\n", text2));
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
			stringBuilder.Append("<TD class=\"last-cell-date\">" + Convert.ToDateTime(dataRow["datetripbeg"]).Date.ToShortDateString() + text3 + "\n");
			stringBuilder.Append("<TD class=\"last-cell-time\">" + Convert.ToDateTime(dataRow["datetripbeg"]).ToShortTimeString() + text5 + "\n");
			stringBuilder.Append("<TD class=\"last-cell-date\">" + Convert.ToDateTime(dataRow["datetripEnd"]).Date.ToShortDateString() + text4 + "\n");
			stringBuilder.Append("<TD class=\"last-cell-time\">" + Convert.ToDateTime(dataRow["datetripEnd"]).ToShortTimeString() + text6 + "\n");
			string arg = (dataRow["SiteStatus"] == DBNull.Value || string.IsNullOrEmpty(dataRow["SiteStatus"].ToString())) ? "&nbsp;" : dataRow["SiteStatus"].ToString();
			stringBuilder.Append(string.Format("<TD class=\"cell-status\" >{0}\n", arg));
			i += num3;
		}
		stringBuilder.Append("</tbody>\n");
		stringBuilder.Append("</table>\n");
		stringBuilder.Append("</body>\n");
		stringBuilder.Append("</html>\n");
		global::h.a(A_1, stringBuilder);
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00006318 File Offset: 0x00004518
	private static string a(string sr)
	{
		if (sr == "Сетевой район №1")
		{
			return "Ленинский район";
		}
		if (sr == "Сетевой район №2")
		{
			return "Засвияжский район";
		}
		if (sr == "Сетевой район №3")
		{
			return "Железнодорожный район";
		}
		if (!(sr == "Сетевой район №4"))
		{
			return "";
		}
		return "Заволжский район";
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00006378 File Offset: 0x00004578
	private static void a(string A_0, StringBuilder A_1)
	{
		try
		{
			File.Delete(A_0);
			StreamWriter streamWriter = new StreamWriter(A_0, true, Encoding.GetEncoding(1251));
			streamWriter.Write(A_1.ToString());
			streamWriter.Close();
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message, ex.InnerException);
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000063D4 File Offset: 0x000045D4
	internal static string c()
	{
		return global::h.b() + global::h.c;
	}

	// Token: 0x06000059 RID: 89 RVA: 0x000063E8 File Offset: 0x000045E8
	internal static void a(SQLSettings A_0)
	{
		using (SqlConnection sqlConnection = new SqlConnection(A_0.GetConnectionString()))
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
								global::h.b = Convert.ToBoolean(xmlAttribute.Value);
							}
							else
							{
								global::h.b = false;
							}
							xmlAttribute = xmlNode2.Attributes["FileName"];
							if (xmlAttribute != null)
							{
								global::h.c = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["PathName"];
							if (xmlAttribute != null)
							{
								global::h.d = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["FTPName"];
							if (xmlAttribute != null)
							{
								global::h.e = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["User"];
							if (xmlAttribute != null)
							{
								global::h.f = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["Pwd"];
							if (xmlAttribute != null)
							{
								global::h.g = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["Proxy"];
							if (xmlAttribute != null)
							{
								global::h.h = xmlAttribute.Value;
								xmlAttribute = xmlNode2.Attributes["ProxyUser"];
								if (xmlAttribute != null)
								{
									global::h.i = xmlAttribute.Value;
								}
								xmlAttribute = xmlNode2.Attributes["ProxyPwd"];
								if (xmlAttribute != null)
								{
									global::h.j = xmlAttribute.Value;
								}
							}
							XmlNode xmlNode3 = xmlNode2.SelectSingleNode("Shedule");
							if (xmlNode3 != null)
							{
								xmlAttribute = xmlNode3.Attributes["Start"];
								if (xmlAttribute != null)
								{
									global::h.k = Convert.ToDateTime(xmlAttribute.Value);
								}
								xmlAttribute = xmlNode3.Attributes["Period"];
								if (xmlAttribute != null)
								{
									global::h.l = Convert.ToInt32(xmlAttribute.Value);
								}
								xmlNode2 = xmlNode.SelectSingleNode("PathCURL");
								if (xmlNode2 != null && !string.IsNullOrEmpty(xmlNode2.InnerText))
								{
									global::h.m = xmlNode2.InnerText;
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

	// Token: 0x0600005A RID: 90 RVA: 0x000066B8 File Offset: 0x000048B8
	private static string b()
	{
		string str = "EIS\\RequestForRepair";
		string text = Path.GetTempPath() + "\\" + str + "\\";
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		return text;
	}

	// Token: 0x0600005B RID: 91 RVA: 0x000066F1 File Offset: 0x000048F1
	internal static void a()
	{
		if (global::h.b)
		{
			global::j.a(global::h.m, global::h.e, global::h.f, global::h.g, global::h.c(), global::h.h, global::h.i, global::h.j);
		}
	}

	// Token: 0x0400003E RID: 62
	private static int a = 920;

	// Token: 0x0400003F RID: 63
	private static bool b = true;

	// Token: 0x04000040 RID: 64
	private static string c = "plan_rabota.php";

	// Token: 0x04000041 RID: 65
	private static string d = "";

	// Token: 0x04000042 RID: 66
	private static string e = "";

	// Token: 0x04000043 RID: 67
	private static string f = "";

	// Token: 0x04000044 RID: 68
	private static string g = "";

	// Token: 0x04000045 RID: 69
	private static string h = "";

	// Token: 0x04000046 RID: 70
	private static string i = "";

	// Token: 0x04000047 RID: 71
	private static string j = "";

	// Token: 0x04000048 RID: 72
	private static DateTime k = DateTime.MinValue;

	// Token: 0x04000049 RID: 73
	private static int l = 0;

	// Token: 0x0400004A RID: 74
	private static string m = "";
}
