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

// Token: 0x0200000C RID: 12
internal static class g
{
	// Token: 0x0600004A RID: 74 RVA: 0x00004548 File Offset: 0x00002748
	internal static DataTable a(SQLSettings A_0, DateTime A_1)
	{
		string arg = "'" + A_1.Date.ToString("yyyyMMdd") + "'";
		string arg2 = "'" + A_1.Date.ToString("yyyyMMdd") + " 23:59:59'";
		string text = string.Format("(dateFactEnd is null or (dateFactEnd >= {0} and dateFactEnd <= {1}))", arg, arg2);
		string text2 = " (idDivision = " + global::g.a.ToString() + ") ";
		string connectionString = A_0.GetConnectionString();
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
				" and deleted = 0  and crash = 1 and agreed = 1  order by sr, id, datetripBeg"
			}), sqlConnection).Fill(dataTable);
		}
		catch (Exception ex)
		{
			throw new Exception(ex.Message, ex.InnerException);
		}
		return dataTable;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00004648 File Offset: 0x00002848
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

	// Token: 0x0600004C RID: 76 RVA: 0x000046A4 File Offset: 0x000028A4
	internal static void b(SQLSettings A_0, string A_1, DateTime A_2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<html>\n");
		stringBuilder.Append("<head>\n");
		stringBuilder.Append("<title></title>\n");
		stringBuilder.Append("<BASEFONT FACE=\"Arial\" SIZE=8>\n");
		stringBuilder.Append("</head>\n");
		stringBuilder.Append("<body>\n");
		stringBuilder.Append("<TABLE BORDER CELLSPACING=0>\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append("<TD ALIGN=CENTER BORDERCOLOR=#ffffff COLSPAN=8><FONT SIZE=2><I><B>Информация об аварийных отключениях за " + A_2.ToShortDateString() + "г.</B></I></FONT>\n");
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append("<TD WIDTH=20% ALIGN=CENTER VALIGN=CENTER ROWSPAN=2><FONT SIZE=2><B>Отключаемый объект</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER ROWSPAN=2><FONT SIZE=2><B>Адрес</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER COLSPAN=2><FONT SIZE=2><B>Отключение</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER COLSPAN=2><FONT SIZE=2><B>Планируемое включение</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER COLSPAN=2><FONT SIZE=2><B>Факт. включение</B></FONT>\n");
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Дата</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Время</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Дата</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Время</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Дата</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Время</B></FONT>\n");
		stringBuilder.Append("</tr>\n");
		DataTable dataTable = global::g.a(A_0, A_2);
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
				stringBuilder.Append("<TR>\n");
				string str3 = global::g.a(dataRow["SR"].ToString());
				stringBuilder.Append("<TD VALIGN=CENTER BGCOLOR=#c0dcc0 COLSPAN=8><FONT SIZE=2><I><B>" + str3 + "</B></I></FONT>\n");
				stringBuilder.Append("</tr>\n");
				num = Convert.ToInt32(dataRow["idSR"]);
			}
			stringBuilder.Append("<TR>\n");
			string text = "";
			if (dataRow["dateFactEnd"] != DBNull.Value)
			{
				text = "BGCOLOR=#F0F0F0 ";
			}
			string text2 = dataRow["SchmObj"].ToString();
			text2 = text2.Replace(",", ", ");
			text2 = text2.Replace(",  ", ", ");
			stringBuilder.Append(string.Concat(new string[]
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
			stringBuilder.Append(string.Concat(new string[]
			{
				"<TD VALIGN=CENTER ",
				text,
				"  ROWSPAN=",
				(num3 + 1).ToString(),
				"><FONT SIZE=2>",
				text3,
				"</FONT>\n"
			}));
			stringBuilder.Append(string.Concat(new string[]
			{
				"<TD VALIGN=TOP ",
				text,
				" ><FONT SIZE=2>",
				Convert.ToDateTime(dataRow["datetripbeg"]).Date.ToShortDateString(),
				"</FONT>\n"
			}));
			stringBuilder.Append(string.Concat(new string[]
			{
				"<TD VALIGN=TOP ",
				text,
				" ><FONT SIZE=2>",
				Convert.ToDateTime(dataRow["datetripbeg"]).ToShortTimeString(),
				"</FONT>\n"
			}));
			stringBuilder.Append(string.Concat(new string[]
			{
				"<TD VALIGN=TOP ",
				text,
				" ><FONT SIZE=2>",
				Convert.ToDateTime(dataRow["datetripEnd"]).Date.ToShortDateString(),
				"</FONT>\n"
			}));
			stringBuilder.Append(string.Concat(new string[]
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
			stringBuilder.Append(string.Concat(new string[]
			{
				"<TD VALIGN=TOP ",
				text,
				" ROWSPAN=",
				(num3 + 1).ToString(),
				"><FONT SIZE=2>",
				text4,
				"</FONT>\n"
			}));
			stringBuilder.Append(string.Concat(new string[]
			{
				"<TD VALIGN=TOP ",
				text,
				" ROWSPAN=",
				(num3 + 1).ToString(),
				"><FONT SIZE=2>",
				text5,
				"</FONT>\n"
			}));
			stringBuilder.Append("</tr>\n");
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
				stringBuilder.Append("<tr>\n");
				stringBuilder.Append(string.Concat(new string[]
				{
					"<TD VALIGN=TOP ",
					text,
					" ><FONT SIZE=2>",
					Convert.ToDateTime(dataRow2["datetripbeg"]).Date.ToShortDateString(),
					"</FONT>\n"
				}));
				stringBuilder.Append(string.Concat(new string[]
				{
					"<TD VALIGN=TOP ",
					text,
					" ><FONT SIZE=2>",
					Convert.ToDateTime(dataRow2["datetripbeg"]).ToShortTimeString(),
					"</FONT>\n"
				}));
				stringBuilder.Append(string.Concat(new string[]
				{
					"<TD VALIGN=TOP ",
					text,
					" ><FONT SIZE=2>",
					Convert.ToDateTime(dataRow2["datetripEnd"]).Date.ToShortDateString(),
					"</FONT>\n"
				}));
				stringBuilder.Append(string.Concat(new string[]
				{
					"<TD VALIGN=TOP ",
					text,
					" ><FONT SIZE=2>",
					Convert.ToDateTime(dataRow2["datetripEnd"]).ToShortTimeString(),
					"</FONT>\n"
				}));
				stringBuilder.Append("</tr>\n");
				num3++;
			}
			i += num3;
		}
		stringBuilder.Append("</table>\n");
		stringBuilder.Append("</body>\n");
		stringBuilder.Append("</html>\n");
		global::g.a(A_1, stringBuilder);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00004F50 File Offset: 0x00003150
	internal static void a(SQLSettings A_0, string A_1, DateTime A_2)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\"lang=\"ru\" xml:lang=\"ru\">\r\n                            <html>\r\n                            <meta http-equiv=\"Content-Language\" content=\"ru\" />\r\n                             <meta http-equiv=\"Content-Type\" content=\"text/html; charset=windows-1251\" />\r\n                             <head>\r\n                            <title></title>\r\n                            <BASEFONT FACE=\"Arial\" SIZE=8>\r\n                            <style>\r\n                            td,th{\r\n\t                            background-color:#FFFFFF;\r\n\t                            font-size:small;\r\n                            }\r\n                            th{\r\n\t                            text-align:center;\r\n\t                            vertical-align:center;\r\n                            }\r\n                            td{\r\n\t                            vertical-align:top;\r\n                            }\r\n                            .first-cell{\r\n\t                            width:20%;\r\n                            }\r\n                            .last-cell-date{\r\n\t                            width:11%;\r\n                            }\r\n                            .last-cell-time{\r\n\t                        width:8%;\r\n                            }\r\n                            .cell_sr{\r\n                                width:100%;\r\n                            }\r\n                            </style>\r\n                            <script type=\"text/javascript\">\r\n                            function doResize(){\r\n\t                            document.getElementById('t-header').setAttribute('width',document.getElementById('t-data').offsetWidth);\r\n                            }\r\n                            </script>\r\n                            </head>\r\n                            <body onLoad=\"doResize()\" onResize=\"doResize()\">");
		stringBuilder.Append("<table  id=\"t-header\" style = \" position:fixed; top:0px; height:85px; z-index:1000;background-color:black;\">\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append("<th    COLSPAN=8><I><B>Оперативная информация об аварийных отключениях на \r\n                                <?php\r\n                                echo date( 'H:i Y-m-d ');\r\n                                ?>  \r\n                                </B></I></FONT>");
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append("<th  class=\"first-cell\" ALIGN=CENTER  ROWSPAN=2><B>Отключаемый <br />объект</B>\r\n\t\t\t                 <th    ROWSPAN=2><B>Адрес</B>\r\n\t\t\t                 <th    COLSPAN=2><B>Отключение</B>\r\n\t\t\t                 <th    COLSPAN=2><B>Планируемое <br />включение</B>\r\n\t\t\t                 <th    COLSPAN=2><B>Факт. <br />включение</B>");
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append("<th class=\"last-cell-date\"    ><B>Дата</B>\r\n\t\t\t                <th class=\"last-cell-time\"    ><B>Время</B>\r\n\t\t\t                <th class=\"last-cell-date\"    ><B>Дата</B>\r\n\t\t\t                <th class=\"last-cell-time\"    ><B>Время</B>\r\n\t\t\t                <th class=\"last-cell-date\"    ><B>Дата</B>\r\n\t\t\t                <th class=\"last-cell-time\"    ><B>Время</B>");
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("</table>\n");
		stringBuilder.Append("<TABLE id=\"t-data\" style=\"width:100%; position:relative;top:75px;background-color:black;\">\n");
		stringBuilder.Append("<tbody>\n");
		DataTable dataTable = global::g.a(A_0, A_2);
		int num = -1;
		if (dataTable.Rows.Count == 0)
		{
			stringBuilder.Append("<TR>\n");
			stringBuilder.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#bfffff;\">аварийных отключений в электрических сетях МУП \"УльГЭС\" нет\n");
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
				string str3 = global::g.a(dataRow["SR"].ToString());
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
			string str4 = "";
			string str5 = "";
			if (dataRow["dateFactEnd"] != DBNull.Value)
			{
				str4 = Convert.ToDateTime(dataRow["dateFactEnd"]).Date.ToShortDateString();
				str5 = Convert.ToDateTime(dataRow["dateFactEnd"]).ToShortTimeString();
			}
			stringBuilder.Append(string.Format("<TD class=\"last-cell-date\" >" + str4 + "\n", new object[0]));
			stringBuilder.Append(string.Format("<TD class=\"last-cell-time\" >" + str5 + "\n", new object[0]));
			stringBuilder.Append("</tr>\n");
			i += num3;
		}
		stringBuilder.Append("</tbody>\n");
		stringBuilder.Append("</table>\n");
		stringBuilder.Append("</body>\n");
		stringBuilder.Append("</html>\n");
		global::g.a(A_1, stringBuilder);
	}

	// Token: 0x0600004E RID: 78 RVA: 0x000055CC File Offset: 0x000037CC
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

	// Token: 0x0600004F RID: 79 RVA: 0x0000562C File Offset: 0x0000382C
	internal static string c()
	{
		return global::g.b() + global::g.c;
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00005640 File Offset: 0x00003840
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
						XmlNode xmlNode2 = xmlNode.SelectSingleNode("FTP05");
						if (xmlNode2 != null)
						{
							XmlAttribute xmlAttribute = xmlNode2.Attributes["UseFTP"];
							if (xmlAttribute != null)
							{
								global::g.b = Convert.ToBoolean(xmlAttribute.Value);
							}
							else
							{
								global::g.b = false;
							}
							xmlAttribute = xmlNode2.Attributes["FileName"];
							if (xmlAttribute != null)
							{
								global::g.c = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["PathName"];
							if (xmlAttribute != null)
							{
								global::g.d = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["FTPName"];
							if (xmlAttribute != null)
							{
								global::g.e = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["User"];
							if (xmlAttribute != null)
							{
								global::g.f = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["Pwd"];
							if (xmlAttribute != null)
							{
								global::g.g = xmlAttribute.Value;
							}
							xmlAttribute = xmlNode2.Attributes["Proxy"];
							if (xmlAttribute != null)
							{
								global::g.h = xmlAttribute.Value;
								xmlAttribute = xmlNode2.Attributes["ProxyUser"];
								if (xmlAttribute != null)
								{
									global::g.i = xmlAttribute.Value;
								}
								xmlAttribute = xmlNode2.Attributes["ProxyPwd"];
								if (xmlAttribute != null)
								{
									global::g.j = xmlAttribute.Value;
								}
							}
							XmlNode xmlNode3 = xmlNode2.SelectSingleNode("Shedule");
							if (xmlNode3 != null)
							{
								xmlAttribute = xmlNode3.Attributes["Start"];
								if (xmlAttribute != null)
								{
									global::g.k = Convert.ToDateTime(xmlAttribute.Value);
								}
								xmlAttribute = xmlNode3.Attributes["Period"];
								if (xmlAttribute != null)
								{
									global::g.l = Convert.ToInt32(xmlAttribute.Value);
								}
								xmlNode2 = xmlNode.SelectSingleNode("PathCURL");
								if (xmlNode2 != null && !string.IsNullOrEmpty(xmlNode2.InnerText))
								{
									global::g.m = xmlNode2.InnerText;
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

	// Token: 0x06000051 RID: 81 RVA: 0x00005910 File Offset: 0x00003B10
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

	// Token: 0x06000052 RID: 82 RVA: 0x00005949 File Offset: 0x00003B49
	internal static void a()
	{
		if (global::g.b)
		{
			global::j.a(global::g.m, global::g.e, global::g.f, global::g.g, global::g.c(), global::g.h, global::g.i, global::g.j);
		}
	}

	// Token: 0x04000031 RID: 49
	internal static int a = 920;

	// Token: 0x04000032 RID: 50
	private static bool b = true;

	// Token: 0x04000033 RID: 51
	private static string c = "plan_rabota.php";

	// Token: 0x04000034 RID: 52
	private static string d = "";

	// Token: 0x04000035 RID: 53
	private static string e = "";

	// Token: 0x04000036 RID: 54
	private static string f = "";

	// Token: 0x04000037 RID: 55
	private static string g = "";

	// Token: 0x04000038 RID: 56
	private static string h = "";

	// Token: 0x04000039 RID: 57
	private static string i = "";

	// Token: 0x0400003A RID: 58
	private static string j = "";

	// Token: 0x0400003B RID: 59
	private static DateTime k = DateTime.MinValue;

	// Token: 0x0400003C RID: 60
	private static int l = 0;

	// Token: 0x0400003D RID: 61
	private static string m = "";
}
