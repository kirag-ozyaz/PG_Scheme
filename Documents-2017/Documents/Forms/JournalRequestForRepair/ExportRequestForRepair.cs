using DataSql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
namespace Documents.JournalRequestForRepair
{
    internal static class ExportRequestForRepair
    {
        internal static int IdODS = 920;

        internal static DataTable smethod_0(SQLSettings sqlsettings_0, DateTime dateTime_0, DateTime dateTime_1, bool bool_0)
        {
            string str = "'" + dateTime_0.Date.ToString("yyyyMMdd") + "'";
            string str2 = "'" + dateTime_1.Date.ToString("yyyyMMdd") + " 23:59:59'";
            string[] textArray1 = new string[] { " ((dateTripBeg >= ", str, " and datetripBEg <= ", str2, ") or (datetripend >= ", str, " and datetripEnd <= ", str2, ") or (datetripBeg <= ", str, " and dateTRipEnd >= ", str2, ")) " };
            string str3 = string.Concat(textArray1);
            string str4 = " (idDivision = " + IdODS.ToString() + ") ";
            string str5 = "";
            if (bool_0)
            {
                str5 = " and (Crash = 1) ";
            }
            else
            {
                str5 = " and (Crash = 0 or Crash is null) ";
            }
            string[] textArray2 = new string[] { " where ", str3, " and ", str4, " and deleted = 0", str5, " and agreed = 1 order by sr, id, datetripBeg" };
            DataTable table = new SqlDataCommand(sqlsettings_0).SelectSqlData("vJ_RequestForRepairDaily", true, string.Concat(textArray2), null);
            if (dateTime_0.Date == dateTime_1.Date)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (dateTime_0.Date > Convert.ToDateTime(row["dateTripBeg"]))
                    {
                        row["dateTRipBeg"] = dateTime_0.Date;
                    }
                    if (dateTime_1.Date.AddDays(1.0).AddMinutes(-1.0) < Convert.ToDateTime(row["DateTripEnd"]))
                    {
                        row["dateTripEnd"] = dateTime_1.Date.AddDays(1.0).AddMinutes(-1.0);
                    }
                }
            }
            return table;
        }

        private static DataTable smethod_1(SQLSettings sqlsettings_0, DateTime dateTime_0, DateTime dateTime_1)
        {
            string str = "'" + dateTime_0.Date.ToString("yyyyMMdd") + "'";
            string str2 = "'" + dateTime_1.Date.ToString("yyyyMMdd") + " 23:59:59'";
            string[] textArray1 = new string[] { " ((dateTripBeg >= ", str, " and datetripBEg <= ", str2, ") or (datetripend >= ", str, " and datetripEnd <= ", str2, ") or (datetripBeg <= ", str, " and dateTRipEnd >= ", str2, ")) " };
            string str3 = string.Concat(textArray1);
            string str4 = " (idDivision = " + IdODS.ToString() + ") ";
            DataTable dataTable = new DataTable();
            SqlConnection selectConnection = new SqlConnection(sqlsettings_0.GetConnectionString());
            try
            {
                selectConnection.Open();
                string[] textArray2 = new string[] { "select * from vJ_RequestForRepairDaily where ", str3, " and ", str4, " and deleted = 0  and sendSite = 1  order by sr, id, datetripBeg" };
                new SqlDataAdapter(string.Concat(textArray2), selectConnection).Fill(dataTable);
                if (!(dateTime_0.Date == dateTime_1.Date))
                {
                    return dataTable;
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    if (dateTime_0.Date > Convert.ToDateTime(row["dateTripBeg"]))
                    {
                        row["dateTRipBeg"] = dateTime_0.Date;
                    }
                    if (dateTime_1.Date.AddDays(1.0).AddMinutes(-1.0) < Convert.ToDateTime(row["DateTripEnd"]))
                    {
                        row["dateTripEnd"] = dateTime_1.Date.AddDays(1.0).AddMinutes(-1.0);
                    }
                }
            }
            catch (Exception exception1)
            {
                MessageBox.Show(exception1.Message);
            }
            finally
            {
                if (selectConnection != null)
                {
                    selectConnection.Dispose();
                }
            }
            return dataTable;
        }

        private static string smethod_10(DataTable dataTable_0, DateTime dateTime_0)
        {
            string str = string.Empty;
            new StringBuilder();
            string str2 = "\n";
            str = (str + "<Worksheet ss:Name=\"Sheet1\">" + str2) + "<Table ss:ExpandedColumnCount=\"4\" ss:ExpandedRowCount=\"1000\" x:FullColumns=\"1\"   x:FullRows=\"1\">" + str2;
            string[] textArray1 = new string[] { str, "<Column ss:AutoFitWidth=\"1\" ss:Width=\"", 180.ToString(), "\"/>", str2 };
            str = string.Concat(textArray1);
            string[] textArray2 = new string[5];
            textArray2[0] = str;
            textArray2[1] = "<Column ss:AutoFitWidth=\"1\" ss:Width=\"";
            textArray2[2] = 180.ToString();
            textArray2[3] = "\"/>";
            textArray2[4] = str2;
            str = string.Concat(textArray2);
            string[] textArray3 = new string[5];
            textArray3[0] = str;
            textArray3[1] = "<Column ss:AutoFitWidth=\"1\" ss:Width=\"";
            textArray3[2] = 180.ToString();
            textArray3[3] = "\"/>";
            textArray3[4] = str2;
            str = ((((string.Concat(textArray3) + "<Column ss:AutoFitWidth=\"1\" ss:Width=\"80\"/>" + str2) + "<Row ss:Index=\"1\">" + str2) + "<Cell ss:MergeAcross=\"3\" ss:StyleID=\"sTitle\"><Data ss:Type=\"String\">Плановые работы в сетях МУП \"УльГЭС\"</Data></Cell>" + str2) + "</Row>" + str2) + "<Row ss:Index=\"2\">" + str2;
            str = (((((((str + "<Cell ss:MergeAcross=\"3\" ss:StyleID=\"sTitle\"><Data ss:Type=\"String\">на " + dateTime_0.ToShortDateString() + "г.</Data></Cell>" + str2) + "</Row>" + str2) + "<Row ss:Index=\"3\" ss:Height=\"25\">" + str2) + "<Cell ss:StyleID=\"sHeadColumn\"><Data ss:Type=\"String\">Отключаемый объект</Data></Cell>" + str2) + "<Cell ss:StyleID=\"sHeadColumn\"><Data ss:Type=\"String\">Цель отключения</Data></Cell>" + str2) + "<Cell ss:StyleID=\"sHeadColumn\"><Data ss:Type=\"String\">Адрес</Data></Cell>" + str2) + "<Cell ss:StyleID=\"sHeadColumn\"><Data ss:Type=\"String\">Время откл.</Data></Cell>" + str2) + "</Row>" + str2;
            int num = 1;
            int num2 = 4;
            for (int i = 0; i < dataTable_0.Rows.Count; i++)
            {
                DataRow row = dataTable_0.Rows[i];
                row["datetripbeg"].ToString();
                row["datetripend"].ToString();
                int num5 = i;
                int num6 = 0;
                goto Label_0212;
                Label_01DD:
                if (Convert.ToInt32(row["id"]) != Convert.ToInt32(dataTable_0.Rows[num5]["id"]))
                {
                    goto Label_0227;
                }
                num6++;
                Label_0212:
                num5++;
                if (num5 < dataTable_0.Rows.Count)
                {
                    goto Label_01DD;
                }
                Label_0227:
                if (num != Convert.ToInt32(row["idSR"]))
                {
                    string[] textArray5 = new string[] { str, "<Row ss:Index=\"", num2.ToString(), "\">", str2 };
                    str = string.Concat(textArray5);
                    string str4 = smethod_6(row["SR"].ToString());
                    str = (str + "<Cell ss:MergeAcross=\"3\" ss:StyleID=\"sSR\"><Data ss:Type=\"String\">" + str4 + "</Data></Cell>" + str2) + "</Row>" + str2;
                    num = Convert.ToInt32(row["idSR"]);
                    num2++;
                }
                int num7 = 13;
                if (num6 > 0)
                {
                    List<float> list1 = new List<float> {
                    smethod_11(row["SchmObj"].ToString(), 180, num6),
                    smethod_11(row["Purpose"].ToString(), 180, num6),
                    smethod_11(row["Address"].ToString(), 180, num6)
                };
                    num7 = (int)((IEnumerable<float>)list1).Max();
                }
                if (num6 <= 0)
                {
                    string[] textArray7 = new string[] { str, "<Row ss:Index=\"", num2.ToString(), "\" ss:AutoFitHeight=\"1\" >", str2 };
                    str = string.Concat(textArray7);
                }
                else
                {
                    string[] textArray8 = new string[] { str, "<Row ss:Index=\"", num2.ToString(), "\" ss:Height=\"", num7.ToString(), "\">", str2 };
                    str = string.Concat(textArray8);
                }
                string[] textArray9 = new string[] { str, "<Cell ss:MergeDown=\"", num6.ToString(), "\" ss:StyleID=\"sCell\"><Data ss:Type=\"String\">", row["SchmObj"].ToString().Replace("\n", "&#10;"), "</Data></Cell>", str2 };
                str = string.Concat(textArray9);
                string[] textArray10 = new string[] { str, "<Cell ss:MergeDown=\"", num6.ToString(), "\" ss:StyleID=\"sCell\"><Data ss:Type=\"String\">", row["Purpose"].ToString().Replace("\n", "&#10;"), "</Data></Cell>", str2 };
                str = string.Concat(textArray10);
                string str3 = ((row["Address"] == DBNull.Value) || string.IsNullOrEmpty(row["Address"].ToString())) ? "" : row["Address"].ToString().Replace("\n", "&#10;");
                string[] textArray11 = new string[] { str, "<Cell ss:MergeDown=\"", num6.ToString(), "\" ss:StyleID=\"sCell\"><Data ss:Type=\"String\">", str3, "</Data></Cell>", str2 };
                str = string.Concat(textArray11);
                str = (str + "<Cell ss:StyleID=\"sCell\"><Data ss:Type=\"String\">" + Convert.ToDateTime(row["datetripbeg"]).ToShortTimeString() + " - " + Convert.ToDateTime(row["datetripEnd"]).ToShortTimeString() + "</Data></Cell>" + str2) + "</Row>" + str2;
                num5 = i;
                num6 = 1;
                goto Label_0671;
                Label_0584:
                if (Convert.ToInt32(row["id"]) != Convert.ToInt32(dataTable_0.Rows[num5]["id"]))
                {
                    goto Label_0689;
                }
                DataRow row2 = dataTable_0.Rows[num5];
                string str5 = Convert.ToDateTime(row2["datetripbeg"]).ToShortTimeString() + " - " + Convert.ToDateTime(row2["datetripEnd"]).ToShortTimeString();
                object[] objArray1 = new object[] { str, "<Row ss:Index=\"", num2 + num6, "\" ss:AutoFitHeight=\"0\">", str2 };
                str = string.Concat(objArray1);
                str = (str + "<Cell ss:Index = \"4\" ss:StyleID=\"sCell\"><Data ss:Type=\"String\">" + str5 + "</Data></Cell>" + str2) + "</Row>" + str2;
                num6++;
                Label_0671:
                num5++;
                if (num5 < dataTable_0.Rows.Count)
                {
                    goto Label_0584;
                }
                Label_0689:
                i = (i + num6) - 1;
                num2 += num6;
            }
            return ((str + "</Table>" + str2) + "</Worksheet>" + str2);
        }

        private static float smethod_11(string string_0, int int_1, int int_2)
        {
            int index;
            float num = 0f;
            int startIndex = 0;
            Label_0042:
            index = 0;
            index = string_0.IndexOf('\n', startIndex);
            if (index != -1)
            {
                startIndex = index + 1;
                Size size = TextRenderer.MeasureText(string_0.Substring(startIndex, index - startIndex), new Font("Arial", 8f));
                num += 12.75f * ((size.Width / int_1) + 1);
                goto Label_0042;
            }
            Size size2 = TextRenderer.MeasureText(string_0.Substring(startIndex), new Font("Arial", 8f));
            num += size2.Height * ((size2.Width / 180) + 1);
            num -= int_2 * 12.75f;
            if (num < 0f)
            {
                num = 0f;
            }
            return num;
        }

        private static string smethod_12()
        {
            StringBuilder builder1 = new StringBuilder();
            builder1.Append("\n<WorksheetOptions xmlns=\"urn:schemas-microsoft-com:office:excel\">\n<Selected/>\n </WorksheetOptions>\n");
            return builder1.ToString();
        }

        internal static bool smethod_13(string string_0, int int_1, string string_1, string string_2, string string_3, string string_4, List<Struct4> list_0, string string_5, string string_6, List<string> list_1 = null, bool bool_0 = false)
        {
            try
            {
                SmtpClient client = new SmtpClient(string_0, int_1)
                {
                    EnableSsl = bool_0,
                    Credentials = new NetworkCredential(string_1, string_2)
                };
                MailMessage message = new MailMessage
                {
                    From = new MailAddress(string_3, string_4)
                };
                foreach (Struct4 struct2 in list_0)
                {
                    if (!string.IsNullOrEmpty(struct2.str1))
                    {
                        message.To.Add(new MailAddress(struct2.str1, struct2.str2));
                    }
                }
                message.Subject = string_5;
                message.Body = string_6;
                if (list_1 != null)
                {
                    using (List<string>.Enumerator enumerator2 = list_1.GetEnumerator())
                    {
                        while (enumerator2.MoveNext())
                        {
                            Attachment item = new Attachment(enumerator2.Current, "application/octet-stream");
                            message.Attachments.Add(item);
                        }
                    }
                    try
                    {
                        client.Send(message);
                        goto Label_012F;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        return false;
                    }
                }
                client.Send(message);
            }
            catch (Exception exception2)
            {
                MessageBox.Show(exception2.Message, exception2.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            Label_012F:
            return true;
        }

        private static string smethod_2(string string_0)
        {
            string_0 = string_0.Replace("<tr>", "<Row ss:AutoFitHeight=\"1\" >\n");
            string_0 = string_0.Replace("</tr>", "</Row>\n");
            string_0 = string_0.Replace("<td>", "<Cell><Data ss:Type=\"String\">");
            string_0 = string_0.Replace("</td>", "</Data></Cell>\n");
            return string_0;
        }

        private static bool smethod_3(string string_0, StringBuilder stringBuilder_0, bool bool_0 = false, Encoding encoding_0 = null)
        {
            if (encoding_0 == null)
            {
                encoding_0 = Encoding.Unicode;
            }
            try
            {
                File.Delete(string_0);
                StreamWriter writer = new StreamWriter(string_0, true, encoding_0);
                if (bool_0)
                {
                    writer.Write(smethod_2(stringBuilder_0.ToString()));
                }
                else
                {
                    writer.Write(stringBuilder_0.ToString());
                }
                writer.Close();
                return true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        public static bool smethod_4(SQLSettings sqlsettings_0, string string_0, DateTime dateTime_0, DateTime dateTime_1, bool bool_0)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<html>\n");
            builder.Append("<head>\n");
            builder.Append("<title></title>\n");
            builder.Append("<BASEFONT FACE=\"Arial\" SIZE=8>\n");
            builder.Append("</head>\n");
            builder.Append("<body>\n");
            builder.Append("<TABLE BORDER CELLSPACING=0>\n");
            builder.Append("<TR>\n");
            builder.Append("<TD ALIGN=CENTER BORDERCOLOR=#ffffff COLSPAN=7><FONT SIZE=2><I><B>Плановые работы в сетях МУП \"УльГЭС\"</B></I></FONT>\n");
            builder.Append("</tr>\n");
            builder.Append("<TR>\n");
            builder.Append("<TD ALIGN=CENTER BORDERCOLOR=#ffffff COLSPAN=7><FONT SIZE=2><I><B>за период с " + dateTime_0.ToShortDateString() + "г. по " + dateTime_1.ToShortDateString() + "г.</B></I></FONT>\n");
            builder.Append("</tr>\n");
            builder.Append("<TR>\n");
            builder.Append("<TD ALIGN=CENTER VALIGN=CENTER ROWSPAN=2><FONT SIZE=2><B>Отключаемый объект</B></FONT>\n");
            builder.Append("<TD ALIGN=CENTER VALIGN=CENTER ROWSPAN=2><FONT SIZE=2><B>Цель отключения</B></FONT>\n");
            builder.Append("<TD ALIGN=CENTER VALIGN=CENTER ROWSPAN=2><FONT SIZE=2><B>Адрес</B></FONT>\n");
            builder.Append("<TD ALIGN=CENTER VALIGN=CENTER COLSPAN=2><FONT SIZE=2><B>Отключение</B></FONT>\n");
            builder.Append("<TD ALIGN=CENTER VALIGN=CENTER COLSPAN=2><FONT SIZE=2><B>Включение</B></FONT>\n");
            builder.Append("</tr>\n");
            builder.Append("<TR>\n");
            builder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Дата</B></FONT>\n");
            builder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Время</B></FONT>\n");
            builder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Дата</B></FONT>\n");
            builder.Append("<TD ALIGN=CENTER VALIGN=CENTER><FONT SIZE=2><B>Время</B></FONT>\n");
            builder.Append("</tr>\n");
            DataTable table = smethod_0(sqlsettings_0, dateTime_0, dateTime_1, bool_0);
            int num = -1;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string str = row["datetripbeg"].ToString();
                string str2 = row["datetripend"].ToString();
                int num3 = i;
                int num4 = 0;
                goto Label_0233;
                Label_01C0:
                if (Convert.ToInt32(row["id"]) != Convert.ToInt32(table.Rows[num3]["id"]))
                {
                    goto Label_024B;
                }
                str = str + "\n" + row["datetripbeg"].ToString();
                str2 = str2 + "\n" + row["datetripend"].ToString();
                num4++;
                Label_0233:
                num3++;
                if (num3 < table.Rows.Count)
                {
                    goto Label_01C0;
                }
                Label_024B:
                if (num != Convert.ToInt32(row["idSR"]))
                {
                    builder.Append("<TR>\n");
                    builder.Append("<TD VALIGN=CENTER BGCOLOR=#c0dcc0 COLSPAN=7><FONT SIZE=2><I><B>" + smethod_6(row["SR"].ToString()) + "</B></I></FONT>\n");
                    builder.Append("</tr>\n");
                    num = Convert.ToInt32(row["idSR"]);
                }
                builder.Append("<TR>\n");
                string[] textArray2 = new string[5];
                textArray2[0] = "<TD VALIGN=CENTER ROWSPAN=";
                int num5 = num4 + 1;
                textArray2[1] = num5.ToString();
                textArray2[2] = "><FONT SIZE=2>";
                textArray2[3] = row["SchmObj"].ToString();
                textArray2[4] = "</FONT>\n";
                builder.Append(string.Concat(textArray2));
                string[] textArray3 = new string[5];
                textArray3[0] = "<TD VALIGN=CENTER ROWSPAN=";
                num5 = num4 + 1;
                textArray3[1] = num5.ToString();
                textArray3[2] = "><FONT SIZE=2>";
                textArray3[3] = row["Purpose"].ToString();
                textArray3[4] = "</FONT>\n";
                builder.Append(string.Concat(textArray3));
                string str3 = ((row["Address"] == DBNull.Value) || string.IsNullOrEmpty(row["Address"].ToString())) ? "&nbsp;" : row["Address"].ToString();
                string[] textArray4 = new string[] { "<TD VALIGN=CENTER ROWSPAN=", (num4 + 1).ToString(), "><FONT SIZE=2>", str3, "</FONT>\n" };
                builder.Append(string.Concat(textArray4));
                builder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(row["datetripbeg"]).Date.ToShortDateString() + "</FONT>\n");
                builder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(row["datetripbeg"]).ToShortTimeString() + "</FONT>\n");
                builder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(row["datetripEnd"]).Date.ToShortDateString() + "</FONT>\n");
                builder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(row["datetripEnd"]).ToShortTimeString() + "</FONT>\n");
                builder.Append("</tr>\n");
                num3 = i;
                num4 = 0;
                goto Label_05FF;
                Label_04CE:
                if (Convert.ToInt32(row["id"]) != Convert.ToInt32(table.Rows[num3]["id"]))
                {
                    goto Label_0617;
                }
                DataRow row2 = table.Rows[num3];
                builder.Append("<tr>\n");
                builder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(row2["datetripbeg"]).Date.ToShortDateString() + "</FONT>\n");
                builder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(row2["datetripbeg"]).ToShortTimeString() + "</FONT>\n");
                builder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(row2["datetripEnd"]).Date.ToShortDateString() + "</FONT>\n");
                builder.Append("<TD VALIGN=CENTER><FONT SIZE=2>" + Convert.ToDateTime(row2["datetripEnd"]).ToShortTimeString() + "</FONT>\n");
                builder.Append("</tr>\n");
                num4++;
                Label_05FF:
                num3++;
                if (num3 < table.Rows.Count)
                {
                    goto Label_04CE;
                }
                Label_0617:
                i += num4;
            }
            builder.Append("</table>\n");
            builder.Append("</body>\n");
            builder.Append("</html>\n");
            return smethod_3(string_0, builder, false, null);
        }

        public static bool smethod_5(SQLSettings sqlsettings_0, string string_0, DateTime dateTime_0, DateTime dateTime_1)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\"lang=\"ru\" xml:lang=\"ru\">\r\n                            <html>\r\n                            <meta http-equiv=\"Content-Language\" content=\"ru\" />\r\n                             <meta http-equiv=\"Content-Type\" content=\"text/html; charset=windows-1251\" />\r\n                             <head>\r\n                            <title></title>\r\n                            <BASEFONT FACE=\"Arial\" SIZE=8>\r\n                            <style>\r\n                            td,th{\r\n\t                            background-color:#FFFFFF;\r\n\t                            font-size:small;\r\n                            }\r\n                            th{\r\n\t                            text-align:center;\r\n\t                            vertical-align:center;\r\n                            }\r\n                            td{\r\n\t                            vertical-align:top;\r\n                            }\r\n                            .first-cell{\r\n\t                            width:20%;\r\n                            }\r\n                            .last-cell-date{\r\n\t                            width:11%;\r\n                            }\r\n                            .cell-status{\r\n\t                            width:19%;\r\n                            }\r\n                            .last-cell-time{\r\n\t                        width:8%;\r\n                            }\r\n                            .cell_sr{\r\n                                width:100%;\r\n                            }\r\n                            </style>\r\n                            <script type=\"text/javascript\">\r\n                            function doResize(){\r\n\t                            document.getElementById('t-header').setAttribute('width',document.getElementById('t-data').offsetWidth);\r\n                            }\r\n                            </script>\r\n                            </head>\r\n                            <body onLoad=\"doResize()\" onResize=\"doResize()\">");
            builder.Append("<table  id=\"t-header\" style = \" position:fixed; top:0px; height:85px; z-index:1000;background-color:black;\">\n");
            builder.Append("<TR>\n");
            builder.Append("<th    COLSPAN=8><I><B>Плановые работы в сетях МУП \"УльГЭС\"</B></I></FONT>");
            builder.Append("</tr>\n");
            builder.Append("<TR>\n");
            builder.Append(string.Format("<th    COLSPAN=8><I><B>за период с {0}г. по {1}г.</B></I></FONT>", dateTime_0.ToString("dd.MM.yyyy"), dateTime_1.ToString("dd.MM.yyyy")));
            builder.Append("</tr>\n");
            builder.Append("<TR>\n");
            builder.Append("<th  class=\"first-cell\" ALIGN=CENTER  ROWSPAN=2><B>Отключаемый <br />объект</B>\r\n\t\t\t                 <th    ROWSPAN=2><B>Адрес</B>\r\n\t\t\t                 <th    COLSPAN=2><B>Отключение</B>\r\n\t\t\t                 <th    COLSPAN=2><B>Включение</B>\r\n\t\t\t                 <th   class=\"cell-status\" ROWSPAN=2><B>Статус</B>");
            builder.Append("</tr>\n");
            builder.Append("<TR>\n");
            builder.Append("<th class=\"last-cell-date\"    ><B>Дата</B>\r\n\t\t\t                <th class=\"last-cell-time\"    ><B>Время</B>\r\n\t\t\t                <th class=\"last-cell-date\"    ><B>Дата</B>\r\n\t\t\t                <th class=\"last-cell-time\"    ><B>Время</B>");
            builder.Append("</tr>\n");
            builder.Append("</table>\n");
            builder.Append("<TABLE id=\"t-data\" style=\"width:100%; position:relative;top:75px;background-color:black;\">\n");
            builder.Append("<tbody>\n");
            DataTable table = smethod_1(sqlsettings_0, dateTime_0, dateTime_1);
            int num = -1;
            if (table.Rows.Count == 0)
            {
                builder.Append("<TR>\n");
                builder.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#bfffff;\">плановых работ в электрических сетях МУП \"УльГЭС\" нет\n");
                builder.Append("</tr>\n");
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string str = row["datetripbeg"].ToString();
                string str2 = row["datetripend"].ToString();
                int num3 = i;
                int num4 = 0;
                goto Label_01E1;
                Label_016E:
                if (Convert.ToInt32(row["id"]) != Convert.ToInt32(table.Rows[num3]["id"]))
                {
                    goto Label_01F9;
                }
                str = str + "\n" + row["datetripbeg"].ToString();
                str2 = str2 + "\n" + row["datetripend"].ToString();
                num4++;
                Label_01E1:
                num3++;
                if (num3 < table.Rows.Count)
                {
                    goto Label_016E;
                }
                Label_01F9:
                if (num != Convert.ToInt32(row["idSR"]))
                {
                    builder.Append("<TR>\n");
                    builder.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#c0dcc0;\">" + smethod_6(row["SR"].ToString()) + "\n");
                    builder.Append("</tr>\n");
                    num = Convert.ToInt32(row["idSR"]);
                }
                builder.Append("<TR>\n");
                string str3 = row["SchmObj"].ToString().Replace(",", ", ").Replace(",  ", ", ");
                builder.Append(string.Format("<TD class=\"first-cell\" >{0}\n", str3));
                string str4 = ((row["Address"] == DBNull.Value) || string.IsNullOrEmpty(row["Address"].ToString())) ? "&nbsp;" : row["Address"].ToString();
                string[] separator = new string[] { "\r\n" };
                List<string> list = str4.Split(separator, StringSplitOptions.None).ToList<string>();
                if ((list.Count > 1) && list.Contains(""))
                {
                    list.Remove("");
                }
                list.Sort();
                str4 = string.Join("<br>", list.ToArray()).Replace(",", ", ").Replace(",  ", ", ");
                builder.Append(string.Format("<TD >{0}\n", str4));
                string str5 = "";
                string str6 = "";
                string str7 = "";
                string str8 = "";
                num3 = i;
                num4 = 0;
                goto Label_04B9;
                Label_03C0:
                if (Convert.ToInt32(row["id"]) != Convert.ToInt32(table.Rows[num3]["id"]))
                {
                    goto Label_04D1;
                }
                DataRow row2 = table.Rows[num3];
                str5 = str5 + "<br>" + Convert.ToDateTime(row2["datetripbeg"]).Date.ToShortDateString();
                str7 = str7 + "<br>" + Convert.ToDateTime(row2["datetripbeg"]).ToShortTimeString();
                str6 = str6 + "<br>" + Convert.ToDateTime(row2["datetripEnd"]).Date.ToShortDateString();
                str8 = str8 + "<br>" + Convert.ToDateTime(row2["datetripEnd"]).ToShortTimeString();
                num4++;
                Label_04B9:
                num3++;
                if (num3 < table.Rows.Count)
                {
                    goto Label_03C0;
                }
                Label_04D1:
                builder.Append("<TD class=\"last-cell-date\">" + Convert.ToDateTime(row["datetripbeg"]).Date.ToShortDateString() + str5 + "\n");
                builder.Append("<TD class=\"last-cell-time\">" + Convert.ToDateTime(row["datetripbeg"]).ToShortTimeString() + str7 + "\n");
                builder.Append("<TD class=\"last-cell-date\">" + Convert.ToDateTime(row["datetripEnd"]).Date.ToShortDateString() + str6 + "\n");
                builder.Append("<TD class=\"last-cell-time\">" + Convert.ToDateTime(row["datetripEnd"]).ToShortTimeString() + str8 + "\n");
                string str9 = ((row["SiteStatus"] == DBNull.Value) || string.IsNullOrEmpty(row["SiteStatus"].ToString())) ? "&nbsp;" : row["SiteStatus"].ToString();
                builder.Append(string.Format("<TD class=\"cell-status\" >{0}\n", str9));
                i += num4;
            }
            builder.Append("</tbody>\n");
            builder.Append("</table>\n");
            builder.Append("</body>\n");
            builder.Append("</html>\n");
            return smethod_3(string_0, builder, false, Encoding.GetEncoding(0x4e3));
        }

        private static string smethod_6(string string_0)
        {
            if (string_0 == "Сетевой район №1")
            {
                return "Ленинский район";
            }
            if (string_0 == "Сетевой район №2")
            {
                return "Засвияжский район";
            }
            if (string_0 == "Сетевой район №3")
            {
                return "Железнодорожный район";
            }
            if (string_0 != "Сетевой район №4")
            {
                return "";
            }
            return "Заволжский район";
        }

        public static bool smethod_7(SQLSettings sqlsettings_0, string string_0, DateTime dateTime_0, bool bool_0)
        {
            DataTable table = smethod_0(sqlsettings_0, dateTime_0, dateTime_0, bool_0);
            StringBuilder builder = new StringBuilder();
            builder.Append(smethod_8());
            builder.Append(smethod_9());
            builder.Append(smethod_10(table, dateTime_0));
            builder.Append(smethod_12());
            builder.Append("</Workbook>\n");
            return smethod_3(string_0, builder, true, null);
        }

        private static string smethod_8()
        {
            StringBuilder builder1 = new StringBuilder();
            builder1.Append("<?xml version=\"1.0\"?>\n");
            builder1.Append("<?mso-application progid=\"Excel.Sheet\"?>\n");
            builder1.Append("<Workbook xmlns=\"urn:schemas-microsoft-com:office:spreadsheet\" ");
            builder1.Append("xmlns:o=\"urn:schemas-microsoft-com:office:office\" ");
            builder1.Append("xmlns:x=\"urn:schemas-microsoft-com:office:excel\" ");
            builder1.Append("xmlns:ss=\"urn:schemas-microsoft-com:office:spreadsheet\" ");
            builder1.Append("xmlns:html=\"http://www.w3.org/TR/REC-html40\">\n");
            builder1.Append("<DocumentProperties xmlns=\"urn:schemas-microsoft-com:office:office\">");
            builder1.Append("<Author>Coder.ul</Author>");
            builder1.Append("</DocumentProperties>");
            builder1.Append("<ExcelWorkbook xmlns=\"urn:schemas-microsoft-com:office:excel\">\n");
            builder1.Append("<ProtectStructure>False</ProtectStructure>\n");
            builder1.Append("<ProtectWindows>False</ProtectWindows>\n");
            builder1.Append("</ExcelWorkbook>\n");
            return builder1.ToString();
        }

        private static string smethod_9()
        {
            StringBuilder builder1 = new StringBuilder();
            builder1.Append("<Styles>");
            builder1.Append("<Style ss:ID=\"Default\" ss:Name=\"Normal\">");
            builder1.Append("<Alignment ss:Vertical=\"Bottom\"/>");
            builder1.Append("<Font/><Interior/><NumberFormat/> <Protection/>");
            builder1.Append("</Style>");
            builder1.Append("<Style ss:ID=\"sTitle\" ss:Name=\"Title\">");
            builder1.Append("<Alignment ss:Horizontal=\"Center\" ss:Vertical=\"Center\"/>");
            builder1.Append("<Font ss:FontName=\"Arial\" ss:Size=\"10\" x:Family=\"Swiss\" ss:Bold=\"1\" ss:Italic=\"1\"/>");
            builder1.Append("</Style>");
            builder1.Append("<Style ss:ID=\"sHeadColumn\" ss:Name=\"HeadColumn\">");
            builder1.Append("<Alignment ss:Horizontal=\"Center\" ss:Vertical=\"Center\"/>");
            builder1.Append("<Font ss:FontName=\"Arial\" ss:Size=\"8\" x:Family=\"Swiss\" ss:Bold=\"1\"/>");
            builder1.Append("<Borders>");
            builder1.Append("<Border ss:Position=\"Bottom\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            builder1.Append("<Border ss:Position=\"Left\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            builder1.Append("<Border ss:Position=\"Right\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            builder1.Append("<Border ss:Position=\"Top\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            builder1.Append("</Borders>");
            builder1.Append("</Style>");
            builder1.Append("<Style ss:ID=\"sSR\">");
            builder1.Append("<Borders>");
            builder1.Append("<Border ss:Position=\"Bottom\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            builder1.Append("<Border ss:Position=\"Left\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            builder1.Append("<Border ss:Position=\"Right\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            builder1.Append("<Border ss:Position=\"Top\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            builder1.Append("</Borders>");
            builder1.Append("<Font ss:FontName=\"Arial\" ss:Size=\"8\" x:Family=\"Swiss\" ss:Bold=\"1\" ss:Italic=\"1\"/>");
            builder1.Append("<Interior ss:Color=\"#c0dcc0\" ss:Pattern=\"Solid\"/>");
            builder1.Append("</Style>");
            builder1.Append("<Style ss:ID=\"sCell\">");
            builder1.Append("<Borders>");
            builder1.Append("<Border ss:Position=\"Bottom\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            builder1.Append("<Border ss:Position=\"Left\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            builder1.Append("<Border ss:Position=\"Right\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            builder1.Append("<Border ss:Position=\"Top\" ss:LineStyle=\"Continuous\" ss:Weight=\"1\"/>");
            builder1.Append("</Borders>");
            builder1.Append("<Font ss:FontName=\"Arial\" ss:Size=\"8\" x:Family=\"Swiss\"/>");
            builder1.Append("<Alignment ss:Horizontal=\"Left\" ss:Vertical=\"Center\" ss:WrapText=\"1\"/>");
            builder1.Append("</Style>");
            builder1.Append("</Styles>");
            return builder1.ToString();
        }
    }

}