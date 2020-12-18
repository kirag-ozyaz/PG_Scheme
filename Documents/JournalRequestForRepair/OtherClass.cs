using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Xml;
using DataSql;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Drawing;

namespace RequestForRepair
{

    internal class _CertificatePolicy : ICertificatePolicy
    {
      
        public bool CheckValidationResult(ServicePoint sPoint, X509Certificate cert, WebRequest wRequest, int certProb)
        {
            return true;
        }
    }
    /// <summary>
    /// Выгрузка информации об аварийных отключениях
    /// </summary>
    internal static class UpLoadCrashToSite
    {
        internal static DataTable LoadTable(SQLSettings sqlsettings, DateTime dateTime)
        {
            string strDate1 = "'" + dateTime.Date.ToString("yyyyMMdd") + "'";
            string strDate2 = "'" + dateTime.Date.ToString("yyyyMMdd") + " 23:59:59'";
            string text = string.Format("(dateFactEnd is null or (dateFactEnd >= {0} and dateFactEnd <= {1}))", strDate1, strDate2);
            string text2 = " (idDivision = " + UpLoadCrashToSite.Division.ToString() + ") ";
            DataTable dataTable = new DataTable();
            SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString());
            try
            {
                sqlConnection.Open();
                new SqlDataAdapter(string.Concat(new string[]
                {"select * from vJ_RequestForRepairDaily where ", text, " and ", text2, " and deleted = 0  and crash = 1 and agreed = 1  order by sr, id, datetripBeg"}), sqlConnection).Fill(dataTable);
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
                StreamWriter write1 = new StreamWriter(fileName, true, Encoding.GetEncoding(1251));
                write1.Write(TextToFile.ToString());
                write1.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        internal static void CreateHTMLCrash(SQLSettings sqlsettings, string fileName, DateTime dateTime)
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
            stringBuilder.Append("<TD ALIGN=CENTER BORDERCOLOR=#ffffff COLSPAN=8><FONT SIZE=2><I><B>Информация об аварийных отключениях за " + dateTime.ToShortDateString() + "г.</B></I></FONT>\n");
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
            DataTable dataTable = UpLoadCrashToSite.LoadTable(sqlsettings, dateTime);
            int num = -1;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                string str = dataRow["datetripbeg"].ToString();
                string str2 = dataRow["datetripend"].ToString();
                int num2 = i;
                int num3 = 0;
                while (true)
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
                    string str3 = UpLoadCrashToSite.Get_Division(dataRow["SR"].ToString());
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
                { "<TD WIDTH=20% VALIGN=TOP ", text, " ROWSPAN=",  (num3 + 1).ToString(), "><FONT SIZE=2>", text2,  "</FONT>\n" }));
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
                { "<TD VALIGN=CENTER ", text, "  ROWSPAN=", (num3 + 1).ToString(), "><FONT SIZE=2>", text3, "</FONT>\n" }));
                stringBuilder.Append(string.Concat(new string[]
                { "<TD VALIGN=TOP ", text, " ><FONT SIZE=2>", Convert.ToDateTime(dataRow["datetripbeg"]).Date.ToShortDateString(), "</FONT>\n" }));
                stringBuilder.Append(string.Concat(new string[]
                { "<TD VALIGN=TOP ", text, " ><FONT SIZE=2>", Convert.ToDateTime(dataRow["datetripbeg"]).ToShortTimeString(), "</FONT>\n" }));
                stringBuilder.Append(string.Concat(new string[]
                { "<TD VALIGN=TOP ", text, " ><FONT SIZE=2>", Convert.ToDateTime(dataRow["datetripEnd"]).Date.ToShortDateString(), "</FONT>\n" }));
                stringBuilder.Append(string.Concat(new string[]
                { "<TD VALIGN=TOP ", text, " ><FONT SIZE=2>", Convert.ToDateTime(dataRow["datetripEnd"]).ToShortTimeString(), "</FONT>\n" }));
                string text4 = "";
                string text5 = "";
                if (dataRow["dateFactEnd"] != DBNull.Value)
                {
                    text4 = Convert.ToDateTime(dataRow["dateFactEnd"]).Date.ToShortDateString();
                    text5 = Convert.ToDateTime(dataRow["dateFactEnd"]).ToShortTimeString();
                }
                stringBuilder.Append(string.Concat(new string[]
                { "<TD VALIGN=TOP ", text, " ROWSPAN=", (num3 + 1).ToString(), "><FONT SIZE=2>", text4, "</FONT>\n" }));
                stringBuilder.Append(string.Concat(new string[]
                { "<TD VALIGN=TOP ", text, " ROWSPAN=", (num3 + 1).ToString(), "><FONT SIZE=2>", text5, "</FONT>\n" }));
                stringBuilder.Append("</tr>\n");
                num2 = i;
                num3 = 0;
                while (true)
                {
                    num2++;
                if (num2 >= dataTable.Rows.Count || Convert.ToInt32(dataRow["id"]) != Convert.ToInt32(dataTable.Rows[num2]["id"]))
                    {
                        break;
                    }
                    DataRow dataRow2 = dataTable.Rows[num2];
                    stringBuilder.Append("<tr>\n");
                    stringBuilder.Append(string.Concat(new string[]
                    { "<TD VALIGN=TOP ", text, " ><FONT SIZE=2>", Convert.ToDateTime(dataRow2["datetripbeg"]).Date.ToShortDateString(), "</FONT>\n"}));
                    stringBuilder.Append(string.Concat(new string[]
                    { "<TD VALIGN=TOP ", text, " ><FONT SIZE=2>", Convert.ToDateTime(dataRow2["datetripbeg"]).ToShortTimeString(), "</FONT>\n"}));
                    stringBuilder.Append(string.Concat(new string[]
                    { "<TD VALIGN=TOP ", text, " ><FONT SIZE=2>", Convert.ToDateTime(dataRow2["datetripEnd"]).Date.ToShortDateString(),"</FONT>\n" }));
                    stringBuilder.Append(string.Concat(new string[]
                    { "<TD VALIGN=TOP ", text, " ><FONT SIZE=2>", Convert.ToDateTime(dataRow2["datetripEnd"]).ToShortTimeString(),"</FONT>\n"}));
                    stringBuilder.Append("</tr>\n");
                    num3++;
                }
                i += num3;
            }
            stringBuilder.Append("</table>\n");
            stringBuilder.Append("</body>\n");
            stringBuilder.Append("</html>\n");
            UpLoadCrashToSite.SaveToFileHTML(fileName, stringBuilder);
        }

        internal static void CreateHTMLCrash_2(SQLSettings sqlsettings, string fileName, DateTime dateTime)
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
            DataTable dataTable = UpLoadCrashToSite.LoadTable(sqlsettings, dateTime);
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
                while (true)
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
                    string str3 = UpLoadCrashToSite.Get_Division(dataRow["SR"].ToString());
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
                while (true)
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
            UpLoadCrashToSite.SaveToFileHTML(fileName, stringBuilder);
        }

        private static string Get_Division(string str)
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

        internal static void CreateSettingsConnectFTP(SQLSettings sqlsettings_0)
        {
            using (SqlConnection sqlConnection = new SqlConnection(sqlsettings_0.GetConnectionString()))
            {
                try
                {
                    sqlConnection.Open();
                    DbDataAdapter adapter = new SqlDataAdapter("select [Settings] from tSettings where module = 'FTP05'", sqlConnection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Settings"] != DBNull.Value)
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.LoadXml(dataTable.Rows[0]["Settings"].ToString());
                        XmlNode xmlNode = xml.SelectSingleNode("ReqForRepairFTP");
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
                                        UpLoadCrashToSite.StartDateTime = Convert.ToDateTime(xmlAttribute.Value);
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
            if (UpLoadCrashToSite.UseFTP)
            {
                CreateVisibleProcessUpLoad.Start(UpLoadCrashToSite.PathCURL, UpLoadCrashToSite.FTPName, UpLoadCrashToSite.User, UpLoadCrashToSite.Pwd, UpLoadCrashToSite.GetFullFileName(), UpLoadCrashToSite.Proxy, UpLoadCrashToSite.ProxyUser, UpLoadCrashToSite.ProxyPwd);
            }
        }

        internal static int Division = 920;
        private static bool UseFTP = true;
        private static string FileName = "plan_rabota.php";
        private static string PathName = "";
        private static string FTPName = "";
        private static string User = "";
        private static string Pwd = "";
        private static string Proxy = "";
        private static string ProxyUser = "";
        private static string ProxyPwd = "";
        private static DateTime StartDateTime = DateTime.MinValue;
        private static int Period = 0;
        private static string PathCURL = "";
    }
    internal static class CreateVisibleProcessUpLoad
    {
        internal static void Start(string pathCURL, string fTPName, string user, string pwd, string fullFileName, string proxy, string proxyUser, string proxyPwd)
        {
            new Process
            {
                StartInfo =
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                FileName = pathCURL,
                WorkingDirectory = Path.GetDirectoryName(pathCURL),
                Arguments = (string.IsNullOrEmpty(proxyUser) ? "" : string.Format(" -U {0}:{1} ", proxyUser, proxyPwd)) + (string.IsNullOrEmpty(proxy) ? "" : string.Format(" -x {0} ", proxy)) + string.Format(" -T {0} ftp://{1}:{2}@{3}", new object[]
                {
                    fullFileName,
                    user,
                    pwd,
                    fTPName
                })
            }
            }.Start();
        }
    }
    /// <summary>
    /// Выгрузка информации о плановых работах
    /// </summary>
    internal static class UpLoadPlanToSite
    {
        internal static DataTable LoadTable(SQLSettings sqlsettings, DateTime dateTime_1, DateTime dateTime_2)
        {
            string strData1 = "'" + dateTime_1.Date.ToString("yyyyMMdd") + "'";
            string strData2 = "'" + dateTime_2.Date.ToString("yyyyMMdd") + " 23:59:59'";
            string text3 = string.Concat(new string[]
            { " ((dateTripBeg >= ", strData1, " and datetripBEg <= ", strData2, ") or (datetripend >= ", strData1, " and datetripEnd <= ", strData2, ") or (datetripBeg <= ", strData1, " and dateTRipEnd >= ", strData2, ")) " });
            string strDivision = " (idDivision = " + UpLoadPlanToSite.Division.ToString() + ") ";
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString()))
            {
                try
                {
                    sqlConnection.Open();
                    new SqlDataAdapter(string.Concat(new string[]
                    { "select * from vJ_RequestForRepairDaily where ", text3, " and ", strDivision, " and deleted = 0 and sendSite = 1 order by sr, id, datetripBeg" }), sqlConnection).Fill(dataTable);
                    if (dateTime_1.Date == dateTime_2.Date)
                    {
                        foreach (DataRow dataRow in dataTable.Rows)
                        {
                            if (dateTime_1.Date > Convert.ToDateTime(dataRow["dateTripBeg"]))
                            {
                                dataRow["dateTRipBeg"] = dateTime_1.Date;
                            }
                            if (dateTime_2.Date.AddDays(1.0).AddMinutes(-1.0) < Convert.ToDateTime(dataRow["DateTripEnd"]))
                            {
                                dataRow["dateTripEnd"] = dateTime_2.Date.AddDays(1.0).AddMinutes(-1.0);
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
        internal static void CreateHTMLPlan(SQLSettings sqlsettings, string filename, DateTime dateTime_1, DateTime dateTime_2)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\"lang=\"ru\" xml:lang=\"ru\">\r\n                            <html>\r\n                            <meta http-equiv=\"Content-Language\" content=\"ru\" />\r\n                             <meta http-equiv=\"Content-Type\" content=\"text/html; charset=windows-1251\" />\r\n                             <head>\r\n                            <title></title>\r\n                            <BASEFONT FACE=\"Arial\" SIZE=8>\r\n                            <style>\r\n                            td,th{\r\n\t                            background-color:#FFFFFF;\r\n\t                            font-size:small;\r\n                            }\r\n                            th{\r\n\t                            text-align:center;\r\n\t                            vertical-align:center;\r\n                            }\r\n                            td{\r\n\t                            vertical-align:top;\r\n                            }\r\n                            .first-cell{\r\n\t                            width:20%;\r\n                            }\r\n                            .last-cell-date{\r\n\t                            width:11%;\r\n                            }\r\n                            .cell-status{\r\n\t                            width:19%;\r\n                            }\r\n                            .last-cell-time{\r\n\t                        width:8%;\r\n                            }\r\n                            .cell_sr{\r\n                                width:100%;\r\n                            }\r\n                            </style>\r\n                            <script type=\"text/javascript\">\r\n                            function doResize(){\r\n\t                            document.getElementById('t-header').setAttribute('width',document.getElementById('t-data').offsetWidth);\r\n                            }\r\n                            </script>\r\n                            </head>\r\n                            <body onLoad=\"doResize()\" onResize=\"doResize()\">");
            stringBuilder.Append("<table  id=\"t-header\" style = \" position:fixed; top:0px; height:85px; z-index:1000;background-color:black;\">\n");
            stringBuilder.Append("<TR>\n");
            stringBuilder.Append("<th    COLSPAN=8><I><B>Плановые работы в сетях МУП \"УльГЭС\"</B></I></FONT>");
            stringBuilder.Append("</tr>\n");
            stringBuilder.Append("<TR>\n");
            stringBuilder.Append(string.Format("<th    COLSPAN=8><I><B>за период с {0}г. по {1}г.</B></I></FONT>", dateTime_1.ToString("dd.MM.yyyy"), dateTime_2.ToString("dd.MM.yyyy")));
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
            DataTable dataTable = UpLoadPlanToSite.LoadTable(sqlsettings, dateTime_1, dateTime_2);
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
                string datetripbeg = dataRow["datetripbeg"].ToString();
                string datetripend = dataRow["datetripend"].ToString();
                int num2 = i;
                int num3 = 0;
                while (true)
                {
                    num2++;
                    if (num2 >= dataTable.Rows.Count || Convert.ToInt32(dataRow["id"]) != Convert.ToInt32(dataTable.Rows[num2]["id"]))
                    {
                        break;
                    }
                    datetripbeg = datetripbeg + "\n" + dataRow["datetripbeg"].ToString();
                    datetripend = datetripend + "\n" + dataRow["datetripend"].ToString();
                    num3++;
                }
                if (num != Convert.ToInt32(dataRow["idSR"]))
                {
                    stringBuilder.Append("<TR>\n");
                    string str3 = UpLoadPlanToSite.GetDivision(dataRow["SR"].ToString());
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
                while (true)
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
            UpLoadPlanToSite.SaveToFileHTML(filename, stringBuilder);
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
                StreamWriter write1 = new StreamWriter(fileName, true, Encoding.GetEncoding(1251));
                write1.Write(TextToFile.ToString());
                write1.Close();
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
                    DbDataAdapter adapter = new SqlDataAdapter("select [Settings] from tSettings where module = 'FTP05'", sqlConnection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    if (dataTable.Rows.Count > 0 && dataTable.Rows[0]["Settings"] != DBNull.Value)
                    {
                        XmlDocument xml = new XmlDocument();
                        xml.LoadXml(dataTable.Rows[0]["Settings"].ToString());
                        XmlNode xmlNode = xml.SelectSingleNode("ReqForRepairFTP");
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
            if (UpLoadPlanToSite.UseFTP)
            {
                CreateVisibleProcessUpLoad.Start(UpLoadPlanToSite.PathCURL, UpLoadPlanToSite.FTPName, UpLoadPlanToSite.User, UpLoadPlanToSite.Pwd, UpLoadPlanToSite.GetFullFileName(), UpLoadPlanToSite.Proxy, UpLoadPlanToSite.ProxyUser, UpLoadPlanToSite.ProxyPwd);
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

    internal class RegisterHouseMaps
    {
        /// <summary>
        /// дом с префиксом
        /// </summary>
        internal string Name
        {
            get;
            set;
        }
        /// <summary>
        /// Идентификатор дома на карте
        /// </summary>
        internal int Id
        {
            get;
            set;
        }
        //internal RegisterHouseMaps()
        //{
        //}
        internal RegisterHouseMaps(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }

    /// <summary>
    /// класс из RequestsClient.dll
    /// </summary>
    public static class FileInfo
    {
        private static uint FILE_ATTRIBUTE_NORMAL = 0x80;
        private static uint SHGFI_ICON = 0x100;
        private static uint SHGFI_LARGEICON = 0;
        private static uint SHGFI_USEFILEATTRIBUTES = 0x10;

        public static Icon IconOfFile(string FileName)
        {
            SHFILEINFO psfi = new SHFILEINFO();
            uint uFlags = SHGFI_USEFILEATTRIBUTES | SHGFI_ICON;
            uFlags |= SHGFI_LARGEICON;
            if (SHGetFileInfo(FileName, FILE_ATTRIBUTE_NORMAL, ref psfi, Marshal.SizeOf(psfi), uFlags) == 0)
            {
                return null;
            }
            return Icon.FromHandle(psfi.hIcon);
        }

        [DllImport("shell32.dll")]
        public static extern int SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, int cbfileInfo, uint uFlags);

        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }
    }
    //Struct4
    public struct StructMailAddress
    {
        public StructMailAddress(string a, string b)
        {
            this.address = a;
            this.displayName = b;
        }

        public string address;
        public string displayName;
    }
}


