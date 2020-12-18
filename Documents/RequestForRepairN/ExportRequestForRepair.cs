using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;
using DataSql;
//ExportRequestForRepair
internal static class ExportRequestForRepair
{
    internal static int IdODS = 920;

	internal static DataTable LoadData(SQLSettings sqlsettings, DateTime dateBeg, DateTime dateEnd, bool isCrash)
	{
		string text = "'" + dateBeg.Date.ToString("yyyyMMdd") + "'";
		string text2 = "'" + dateEnd.Date.ToString("yyyyMMdd") + " 23:59:59'";
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
		string text4 = " (idDivision = " + ExportRequestForRepair.IdODS.ToString() + ") ";
		string text5;
		if (isCrash)
		{
			text5 = " and (Crash = 1) ";
		}
		else
		{
			text5 = " and (Crash = 0 or Crash is null) ";
		}
		DataTable dataTable = new SqlDataCommand(sqlsettings).SelectSqlData("vJ_RequestForRepairDaily", true, string.Concat(new string[]
		{
			" where ",
			text3,
			" and ",
			text4,
			" and deleted = 0",
			text5,
			" and agreed = 1 order by sr, id, datetripBeg"
		}), null);
		if (dateBeg.Date == dateEnd.Date)
		{
			foreach (DataRow dataRow in dataTable.Rows)
			{
				if (dateBeg.Date > Convert.ToDateTime(dataRow["dateTripBeg"]))
				{
					dataRow["dateTRipBeg"] = dateBeg.Date;
				}
				if (dateEnd.Date.AddDays(1.0).AddMinutes(-1.0) < Convert.ToDateTime(dataRow["DateTripEnd"]))
				{
					dataRow["dateTripEnd"] = dateEnd.Date.AddDays(1.0).AddMinutes(-1.0);
				}
			}
		}
		return dataTable;
	}

	private static DataTable LoadData(SQLSettings sqlsettings, DateTime dateBeg, DateTime dateEnd)
	{
		string text = "'" + dateBeg.Date.ToString("yyyyMMdd") + "'";
		string text2 = "'" + dateEnd.Date.ToString("yyyyMMdd") + " 23:59:59'";
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
		string text4 = " (idDivision = " + IdODS.ToString() + ") ";
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
					" and deleted = 0  and sendSite = 1  order by sr, id, datetripBeg"
				}), sqlConnection).Fill(dataTable);
				if (dateBeg.Date == dateEnd.Date)
				{
					foreach (DataRow dataRow in dataTable.Rows)
					{
						if (dateBeg.Date > Convert.ToDateTime(dataRow["dateTripBeg"]))
						{
							dataRow["dateTRipBeg"] = dateBeg.Date;
						}
						if (dateEnd.Date.AddDays(1.0).AddMinutes(-1.0) < Convert.ToDateTime(dataRow["DateTripEnd"]))
						{
							dataRow["dateTripEnd"] = dateEnd.Date.AddDays(1.0).AddMinutes(-1.0);
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		return dataTable;
	}

	private static string ConvertHTMLToExcelXML(string strHtml)
	{
		strHtml = strHtml.Replace("<tr>", "<Row ss:AutoFitHeight=\"1\" >\n");
		strHtml = strHtml.Replace("</tr>", "</Row>\n");
		strHtml = strHtml.Replace("<td>", "<Cell><Data ss:Type=\"String\">");
		strHtml = strHtml.Replace("</td>", "</Data></Cell>\n");
		return strHtml;
	}

	private static bool WriteToFile(string fileName, StringBuilder sb, bool isConvertToXML = false, Encoding encoding = null)
	{
		if (encoding == null)
		{
			encoding = Encoding.Unicode;
		}
		bool result;
		try
		{
			File.Delete(fileName);
			StreamWriter streamWriter = new StreamWriter(fileName, true, encoding);
			if (isConvertToXML)
			{
				streamWriter.Write(ExportRequestForRepair.ConvertHTMLToExcelXML(sb.ToString()));
			}
			else
			{
				streamWriter.Write(sb.ToString());
			}
			streamWriter.Close();
			result = true;
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
			result = false;
		}
		return result;
	}

	public static bool ToHTML(SQLSettings sqlsettings, string fileName, DateTime dateBeg, DateTime dateEnd, bool isCrash)
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
		stringBuilder.Append("<TD ALIGN=CENTER BORDERCOLOR=#ffffff COLSPAN=7><FONT SIZE=2><I><B>Плановые работы в сетях МУП \"УльГЭС\"</B></I></FONT>\n");
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append(string.Concat(new string[]
		{
			"<TD ALIGN=CENTER BORDERCOLOR=#ffffff COLSPAN=7><FONT SIZE=2><I><B>за период с ",
			dateBeg.ToShortDateString(),
			"г. по ",
			dateEnd.ToShortDateString(),
			"г.</B></I></FONT>\n"
		}));
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER ROWSPAN=2><FONT SIZE=2><B>Отключаемый объект</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER ROWSPAN=2><FONT SIZE=2><B>Цель отключения</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER ROWSPAN=2><FONT SIZE=2><B>Адрес</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER COLSPAN=2><FONT SIZE=2><B>Отключение</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER COLSPAN=2><FONT SIZE=2><B>Включение</B></FONT>\n");
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Дата</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Время</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Дата</B></FONT>\n");
		stringBuilder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Время</B></FONT>\n");
		stringBuilder.Append("</tr>\n");
		DataTable dataTable = ExportRequestForRepair.LoadData(sqlsettings, dateBeg, dateEnd, isCrash);
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
				string str3 = ExportRequestForRepair.GetNameRaion(dataRow["SR"].ToString());
				stringBuilder.Append("<TD VALIGN=CENTER BGCOLOR=#c0dcc0 COLSPAN=7><FONT SIZE=2><I><B>" + str3 + "</B></I></FONT>\n");
				stringBuilder.Append("</tr>\n");
				num = Convert.ToInt32(dataRow["idSR"]);
			}
			stringBuilder.Append("<TR>\n");
			stringBuilder.Append(string.Concat(new string[]
			{
				"<TD VALIGN=CENTER ROWSPAN=",
				(num3 + 1).ToString(),
				"><FONT SIZE=2>",
				dataRow["SchmObj"].ToString(),
				"</FONT>\n"
			}));
			stringBuilder.Append(string.Concat(new string[]
			{
				"<TD VALIGN=CENTER ROWSPAN=",
				(num3 + 1).ToString(),
				"><FONT SIZE=2>",
				dataRow["Purpose"].ToString(),
				"</FONT>\n"
			}));
			string text = (dataRow["Address"] == DBNull.Value || string.IsNullOrEmpty(dataRow["Address"].ToString())) ? "&nbsp;" : dataRow["Address"].ToString();
			stringBuilder.Append(string.Concat(new string[]
			{
				"<TD VALIGN=CENTER ROWSPAN=",
				(num3 + 1).ToString(),
				"><FONT SIZE=2>",
				text,
				"</FONT>\n"
			}));
			stringBuilder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(dataRow["datetripbeg"]).Date.ToShortDateString() + "</FONT>\n");
			stringBuilder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(dataRow["datetripbeg"]).ToShortTimeString() + "</FONT>\n");
			stringBuilder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(dataRow["datetripEnd"]).Date.ToShortDateString() + "</FONT>\n");
			stringBuilder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(dataRow["datetripEnd"]).ToShortTimeString() + "</FONT>\n");
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
				stringBuilder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(dataRow2["datetripbeg"]).Date.ToShortDateString() + "</FONT>\n");
				stringBuilder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(dataRow2["datetripbeg"]).ToShortTimeString() + "</FONT>\n");
				stringBuilder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(dataRow2["datetripEnd"]).Date.ToShortDateString() + "</FONT>\n");
				stringBuilder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(dataRow2["datetripEnd"]).ToShortTimeString() + "</FONT>\n");
				stringBuilder.Append("</tr>\n");
				num3++;
			}
			i += num3;
		}
		stringBuilder.Append("</table>\n");
		stringBuilder.Append("</body>\n");
		stringBuilder.Append("</html>\n");
		return ExportRequestForRepair.WriteToFile(fileName, stringBuilder, false, null);
	}

	public static bool ToHTML(SQLSettings sqlsettings, string fileName, DateTime dateBeg, DateTime dateEnd)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\"lang=\"ru\" xml:lang=\"ru\">\r\n                            <html>\r\n                            <meta http-equiv=\"Content-Language\" content=\"ru\" />\r\n                             <meta http-equiv=\"Content-Type\" content=\"text/html; charset=windows-1251\" />\r\n                             <head>\r\n                            <title></title>\r\n                            <BASEFONT FACE=\"Arial\" SIZE=8>\r\n                            <style>\r\n                            td,th{\r\n\t                            background-color:#FFFFFF;\r\n\t                            font-size:small;\r\n                            }\r\n                            th{\r\n\t                            text-align:center;\r\n\t                            vertical-align:center;\r\n                            }\r\n                            td{\r\n\t                            vertical-align:top;\r\n                            }\r\n                            .first-cell{\r\n\t                            width:20%;\r\n                            }\r\n                            .last-cell-date{\r\n\t                            width:11%;\r\n                            }\r\n                            .cell-status{\r\n\t                            width:19%;\r\n                            }\r\n                            .last-cell-time{\r\n\t                        width:8%;\r\n                            }\r\n                            .cell_sr{\r\n                                width:100%;\r\n                            }\r\n                            </style>\r\n                            <script type=\"text/javascript\">\r\n                            function doResize(){\r\n\t                            document.getElementById('t-header').setAttribute('width',document.getElementById('t-data').offsetWidth);\r\n                            }\r\n                            </script>\r\n                            </head>\r\n                            <body onLoad=\"doResize()\" onResize=\"doResize()\">");
		stringBuilder.Append("<table  id=\"t-header\" style = \" position:fixed; top:0px; height:85px; z-index:1000;background-color:black;\">\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append("<th    COLSPAN=8><I><B>Плановые работы в сетях МУП \"УльГЭС\"</B></I></FONT>");
		stringBuilder.Append("</tr>\n");
		stringBuilder.Append("<TR>\n");
		stringBuilder.Append(string.Format("<th    COLSPAN=8><I><B>за период с {0}г. по {1}г.</B></I></FONT>", dateBeg.ToString("dd.MM.yyyy"), dateEnd.ToString("dd.MM.yyyy")));
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
		DataTable dataTable = ExportRequestForRepair.LoadData(sqlsettings, dateBeg, dateEnd);
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
				string str3 = ExportRequestForRepair.GetNameRaion(dataRow["SR"].ToString());
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
		return ExportRequestForRepair.WriteToFile(fileName, stringBuilder, false, Encoding.GetEncoding(1251));
	}

	private static string GetNameRaion(string sr)
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

	public static bool ToExcel(SQLSettings sqlsettings, string fileName, DateTime date, bool isCrash)
	{
		DataTable dataTable_ = ExportRequestForRepair.LoadData(sqlsettings, date, date, isCrash);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(ExportRequestForRepair.ExcelHeader());
		stringBuilder.Append(ExportRequestForRepair.ExcelStyles());
		stringBuilder.Append(ExportRequestForRepair.WriteFirstWorkSheet(dataTable_, date));
		stringBuilder.Append(ExportRequestForRepair.ExcelWorkSheetOptions());
		stringBuilder.Append("</Workbook>\n");
		return ExportRequestForRepair.WriteToFile(fileName, stringBuilder, true, null);
	}

	private static string ExcelHeader()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<?xml version=\"1.0\"?>\n");
		stringBuilder.Append("<?mso-application progid=\"Excel.Sheet\"?>\n");
		stringBuilder.Append("<Workbook xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\" ");
		stringBuilder.Append("xmlns:o=\"urn:schemas-microsoft-com:office:office\" ");
		stringBuilder.Append("xmlns:x=\"urn:schemas-microsoft-com:office:excel\" ");
		stringBuilder.Append("xmlns:ss=\"urn:schemas-microsoft-com:office:spreadsheet\" ");
		stringBuilder.Append("xmlns:html=\"http://www.w3.org/TR/REC-html40\">\n");
		stringBuilder.Append("<DocumentProperties xmlns=\"urn:schemas-microsoft-com:office:office\">");
		stringBuilder.Append("<Author>Coder.ul</Author>");
		stringBuilder.Append("</DocumentProperties>");
		stringBuilder.Append("<ExcelWorkbook xmlns=\"urn:schemas-microsoft-com:office:excel\">\n");
		stringBuilder.Append("<ProtectStructure>False</ProtectStructure>\n");
		stringBuilder.Append("<ProtectWindows>False</ProtectWindows>\n");
		stringBuilder.Append("</ExcelWorkbook>\n");
		return stringBuilder.ToString();
	}

	private static string ExcelStyles()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<Styles>");
		stringBuilder.Append("<Style ss:ID=\"Default\" ss:Name=\"Normal\">");
		stringBuilder.Append("<Alignment ss:Vertical=\"Bottom\"/>");
		stringBuilder.Append("<Font/><Interior/><NumberFormat/> <Protection/>");
		stringBuilder.Append("</Style>");
		stringBuilder.Append("<Style ss:ID=\"sTitle\" ss:Name=\"Title\">");
		stringBuilder.Append("<Alignment ss:Horizontal=\"Center\" ss:Vertical=\"Center\"/>");
		stringBuilder.Append("<Font ss:FontName=\"Arial\" ss:Size=\"10\" x:Family=\"Swiss\" ss:Bold=\"1\" ss:Italic=\"1\"/>");
		stringBuilder.Append("</Style>");
		stringBuilder.Append("<Style ss:ID=\"sHeadColumn\" ss:Name=\"HeadColumn\">");
		stringBuilder.Append("<Alignment ss:Horizontal=\"Center\" ss:Vertical=\"Center\"/>");
		stringBuilder.Append("<Font ss:FontName=\"Arial\" ss:Size=\"8\" x:Family=\"Swiss\" ss:Bold=\"1\"/>");
		stringBuilder.Append("<Borders>");
		stringBuilder.Append("<Border ss:Position=\"Bottom\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
		stringBuilder.Append("<Border ss:Position=\"Left\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
		stringBuilder.Append("<Border ss:Position=\"Right\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
		stringBuilder.Append("<Border ss:Position=\"Top\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
		stringBuilder.Append("</Borders>");
		stringBuilder.Append("</Style>");
		stringBuilder.Append("<Style ss:ID=\"sSR\">");
		stringBuilder.Append("<Borders>");
		stringBuilder.Append("<Border ss:Position=\"Bottom\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
		stringBuilder.Append("<Border ss:Position=\"Left\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
		stringBuilder.Append("<Border ss:Position=\"Right\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
		stringBuilder.Append("<Border ss:Position=\"Top\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
		stringBuilder.Append("</Borders>");
		stringBuilder.Append("<Font ss:FontName=\"Arial\" ss:Size=\"8\" x:Family=\"Swiss\" ss:Bold=\"1\" ss:Italic=\"1\"/>");
		stringBuilder.Append("<Interior ss:Color=\"#c0dcc0\" ss:Pattern=\"Solid\"/>");
		stringBuilder.Append("</Style>");
		stringBuilder.Append("<Style ss:ID=\"sCell\">");
		stringBuilder.Append("<Borders>");
		stringBuilder.Append("<Border ss:Position=\"Bottom\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
		stringBuilder.Append("<Border ss:Position=\"Left\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
		stringBuilder.Append("<Border ss:Position=\"Right\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
		stringBuilder.Append("<Border ss:Position=\"Top\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
		stringBuilder.Append("</Borders>");
		stringBuilder.Append("<Font ss:FontName=\"Arial\" ss:Size=\"8\" x:Family=\"Swiss\"/>");
		stringBuilder.Append("<Alignment ss:Horizontal=\"Left\" ss:Vertical=\"Center\" ss:WrapText=\"1\"/>");
		stringBuilder.Append("</Style>");
		stringBuilder.Append("</Styles>");
		return stringBuilder.ToString();
	}

	private static string WriteFirstWorkSheet(DataTable table, DateTime date)
	{
		string text = string.Empty;
		new StringBuilder();
		string text2 = "\n";
		text = text + "<Worksheet ss:Name=\"Sheet1\">" + text2;
		text = text + "<Table ss:ExpandedColumnCount=\"4\" ss:ExpandedRowCount=\"1000\" x:FullColumns=\"1\"   x:FullRows=\"1\">" + text2;
		text = string.Concat(new string[]
		{
			text,
			"<Column ss:AutoFitWidth=\"1\" ss:Width=\"",
			180.ToString(),
			"\"/>",
			text2
		});
		text = string.Concat(new string[]
		{
			text,
			"<Column ss:AutoFitWidth=\"1\" ss:Width=\"",
			180.ToString(),
			"\"/>",
			text2
		});
		text = string.Concat(new string[]
		{
			text,
			"<Column ss:AutoFitWidth=\"1\" ss:Width=\"",
			180.ToString(),
			"\"/>",
			text2
		});
		text = text + "<Column ss:AutoFitWidth=\"1\" ss:Width=\"80\"/>" + text2;
		text = text + "<Row ss:Index=\"1\">" + text2;
		text = text + "<Cell ss:MergeAcross=\"3\" ss:StyleID=\"sTitle\"><Data ss:Type=\"String\">Плановые работы в сетях МУП \"УльГЭС\"</Data></Cell>" + text2;
		text = text + "</Row>" + text2;
		text = text + "<Row ss:Index=\"2\">" + text2;
		text = string.Concat(new string[]
		{
			text,
			"<Cell ss:MergeAcross=\"3\" ss:StyleID=\"sTitle\"><Data ss:Type=\"String\">на ",
			date.ToShortDateString(),
			"г.</Data></Cell>",
			text2
		});
		text = text + "</Row>" + text2;
		text = text + "<Row ss:Index=\"3\" ss:Height=\"25\">" + text2;
		text = text + "<Cell ss:StyleID=\"sHeadColumn\"><Data ss:Type=\"String\">Отключаемый объект</Data></Cell>" + text2;
		text = text + "<Cell ss:StyleID=\"sHeadColumn\"><Data ss:Type=\"String\">Цель отключения</Data></Cell>" + text2;
		text = text + "<Cell ss:StyleID=\"sHeadColumn\"><Data ss:Type=\"String\">Адрес</Data></Cell>" + text2;
		text = text + "<Cell ss:StyleID=\"sHeadColumn\"><Data ss:Type=\"String\">Время откл.</Data></Cell>" + text2;
		text = text + "</Row>" + text2;
		int num = 1;
		int num2 = 4;
		for (int i = 0; i < table.Rows.Count; i++)
		{
			DataRow dataRow = table.Rows[i];
			dataRow["datetripbeg"].ToString();
			dataRow["datetripend"].ToString();
			int num3 = i;
			int num4 = 0;
			for (;;)
			{
				num3++;
				if (num3 >= table.Rows.Count || Convert.ToInt32(dataRow["id"]) != Convert.ToInt32(table.Rows[num3]["id"]))
				{
					break;
				}
				num4++;
			}
			if (num != Convert.ToInt32(dataRow["idSR"]))
			{
				text = string.Concat(new string[]
				{
					text,
					"<Row ss:Index=\"",
					num2.ToString(),
					"\">",
					text2
				});
				string text3 = ExportRequestForRepair.GetNameRaion(dataRow["SR"].ToString());
				text = string.Concat(new string[]
				{
					text,
					"<Cell ss:MergeAcross=\"3\" ss:StyleID=\"sSR\"><Data ss:Type=\"String\">",
					text3,
					"</Data></Cell>",
					text2
				});
				text = text + "</Row>" + text2;
				num = Convert.ToInt32(dataRow["idSR"]);
				num2++;
			}
			int num5 = 13;
			if (num4 > 0)
			{
				num5 = (int)new List<float>
				{
					ExportRequestForRepair.GetHeight(dataRow["SchmObj"].ToString(), 180, num4),
					ExportRequestForRepair.GetHeight(dataRow["Purpose"].ToString(), 180, num4),
					ExportRequestForRepair.GetHeight(dataRow["Address"].ToString(), 180, num4)
				}.Max();
			}
			if (num4 <= 0)
			{
				text = string.Concat(new string[]
				{
					text,
					"<Row ss:Index=\"",
					num2.ToString(),
					"\" ss:AutoFitHeight=\"1\" >",
					text2
				});
			}
			else
			{
				text = string.Concat(new string[]
				{
					text,
					"<Row ss:Index=\"",
					num2.ToString(),
					"\" ss:Height=\"",
					num5.ToString(),
					"\">",
					text2
				});
			}
			text = string.Concat(new string[]
			{
				text,
				"<Cell ss:MergeDown=\"",
				num4.ToString(),
				"\" ss:StyleID=\"sCell\"><Data ss:Type=\"String\">",
				dataRow["SchmObj"].ToString().Replace("\n", "&#10;"),
				"</Data></Cell>",
				text2
			});
			text = string.Concat(new string[]
			{
				text,
				"<Cell ss:MergeDown=\"",
				num4.ToString(),
				"\" ss:StyleID=\"sCell\"><Data ss:Type=\"String\">",
				dataRow["Purpose"].ToString().Replace("\n", "&#10;"),
				"</Data></Cell>",
				text2
			});
			string text4 = (dataRow["Address"] == DBNull.Value || string.IsNullOrEmpty(dataRow["Address"].ToString())) ? "" : dataRow["Address"].ToString().Replace("\n", "&#10;");
			text = string.Concat(new string[]
			{
				text,
				"<Cell ss:MergeDown=\"",
				num4.ToString(),
				"\" ss:StyleID=\"sCell\"><Data ss:Type=\"String\">",
				text4,
				"</Data></Cell>",
				text2
			});
			text = string.Concat(new string[]
			{
				text,
				"<Cell ss:StyleID=\"sCell\"><Data ss:Type=\"String\">",
				Convert.ToDateTime(dataRow["datetripbeg"]).ToShortTimeString(),
				" - ",
				Convert.ToDateTime(dataRow["datetripEnd"]).ToShortTimeString(),
				"</Data></Cell>",
				text2
			});
			text = text + "</Row>" + text2;
			num3 = i;
			num4 = 1;
			for (;;)
			{
				num3++;
				if (num3 >= table.Rows.Count || Convert.ToInt32(dataRow["id"]) != Convert.ToInt32(table.Rows[num3]["id"]))
				{
					break;
				}
				DataRow dataRow2 = table.Rows[num3];
				string text5 = Convert.ToDateTime(dataRow2["datetripbeg"]).ToShortTimeString() + " - " + Convert.ToDateTime(dataRow2["datetripEnd"]).ToShortTimeString();
				text = string.Concat(new object[]
				{
					text,
					"<Row ss:Index=\"",
					num2 + num4,
					"\" ss:AutoFitHeight=\"0\">",
					text2
				});
				text = string.Concat(new string[]
				{
					text,
					"<Cell ss:Index = \"4\" ss:StyleID=\"sCell\"><Data ss:Type=\"String\">",
					text5,
					"</Data></Cell>",
					text2
				});
				text = text + "</Row>" + text2;
				num4++;
			}
			i = i + num4 - 1;
			num2 += num4;
		}
		text = text + "</Table>" + text2;
		return text + "</Worksheet>" + text2;
	}

	private static float GetHeight(string str, int widthCol, int rowMerge)
	{
		float num = 0f;
		int num2 = 0;
		for (;;)
		{
			int num3 = str.IndexOf('\n', num2);
			if (num3 == -1)
			{
				break;
			}
			string text = str.Substring(num2, num3 - num2);
			num2 = num3 + 1;
			num += 12.75f * (float)(TextRenderer.MeasureText(text, new Font("Arial", 8f)).Width / widthCol + 1);
		}
		Size size = TextRenderer.MeasureText(str.Substring(num2), new Font("Arial", 8f));
		num += (float)(size.Height * (size.Width / 180 + 1));
		num -= (float)rowMerge * 12.75f;
		if (num < 0f)
		{
			num = 0f;
		}
		return num;
	}

	private static string ExcelWorkSheetOptions()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("\n<WorksheetOptions xmlns=\"urn:schemas-microsoft-com:office:excel\">\n<Selected/>\n </WorksheetOptions>\n");
		return stringBuilder.ToString();
	}
	
}
