using DataSql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace StatementsForME
{
    /// <summary>
    /// отправка плановых работ на сайт
    /// </summary>
    public class StatementsPlannedToSite
    {
        public SQLSettings SqlSettings
        {
            get
            {
                return _sqlSettings;
            }
            set
            {
                if (value != null)
                {
                    _sqlSettings = value;
                    // считать надо конфигурационный файл
                    setting = new Settings();
                    setting.SqlSettings = this.SqlSettings;
                    setting.Parametr = "FTP";

                    int sIntervalUE = Convert.ToInt32(setting.GetAttribute("Interval", "int", "Shedule"));
                    if (sIntervalUE != 0)
                        Interval = sIntervalUE;
                    else
                        Interval = 8;
                    DataBeg = DateTime.Now.Date;
                    DataEnd = DateTime.Now.Date.AddDays(Interval).AddMilliseconds(-1);
                    PathName = setting.GetAttribute("PathName", "string").ToString();
                    FileName = setting.GetAttribute("FileName", "string").ToString();
                    FileNameSESNO = setting.GetAttribute("FileNameSESNO", "string").ToString();
                    //
                    useFTP = Convert.ToBoolean(setting.GetAttribute("UseFTP", "bool"));
                    
                    ftpName = setting.GetAttribute("FTPName", "string").ToString();
                    ftpUser = setting.GetAttribute("User", "string").ToString();
                    ftpPwd = setting.GetAttribute("Pwd", "string").ToString();
                    proxy = setting.GetAttribute("Proxy", "string").ToString();
                    proxyUser = setting.GetAttribute("ProxyUser", "string").ToString();
                    proxyPwd = setting.GetAttribute("ProxyPwd", "string").ToString();
                    //
                    IntervalShedule = Convert.ToInt32(setting.GetAttribute("Period", "int", "Shedule"));
                    StartShedule = Convert.ToDateTime(setting.GetAttribute("Start", "string", "Shedule"));

                    Settings settingCurl = new Settings();
                    settingCurl.SqlSettings = this.SqlSettings;
                    settingCurl.Parametr = "PathCURL";
                    pathToCURL = settingCurl.GetTextNodes("PathCURL", "string").ToString();
                }
            }
        }
        private SQLSettings _sqlSettings;

        public int Interval { get; set; }
        public DateTime DataBeg { get; set; }
        public DateTime DataEnd { get; set; }

        private Settings setting { get; set; }
        public int IntervalShedule { get; set; }
        public DateTime StartShedule { get; set; }
        public int IdDivision { get; set; } = IdODS;

        private const int IdODS = 920;
        private const int IdSESNO = 1665;
        public string PathName { get; set; } = "";
        public string FileName { get; set; } = "plan_rabota.php";
        public string FileNameSESNO { get; set; } = "plan_rabota_sesno.php";
        public bool useFTP { get; private set; }
        public string pathToCURL { get; private set; }
        public string ftpName { get; private set; }
        public string ftpUser { get; private set; }
        public string ftpPwd { get; private set; }
        public string proxy { get; private set; }
        public string proxyUser { get; private set; }
        public string proxyPwd { get; private set; }

        private string getStringWhereByDivision(int idDivision = IdODS)
        {
            string resultat = "";
            if (idDivision == IdODS)
            { resultat = " r.agreed = 1 and r.SendSite = 1 and r.iddivision = " + idDivision.ToString() + "  "; }
            else if (idDivision == IdSESNO)
            { resultat = " r.agreed = 1 and r.iddivision = " + idDivision.ToString() + "  "; }

            return resultat;
        }

        public void ToPHP()
        {
            ToPHP(DataBeg, DataEnd, IdDivision);
        }
        public void ToPHP(DateTime dateBeg, DateTime dateEnd, int idDivision = IdODS)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<html xmlns=\"http://www.w3.org/1999/xhtml\"lang=\"ru\" xml:lang=\"ru\">\r\n                            <html>\r\n                            <meta http-equiv=\"Content-Language\" content=\"ru\" />\r\n                             <meta http-equiv=\"Content-Type\" content=\"text/html; charset=windows-1251\" />\r\n                             <head>\r\n                            <title></title>\r\n                            <BASEFONT FACE=\"Arial\" SIZE=8>\r\n                            <style>\r\n                            td,th{\r\n\t                            background-color:#FFFFFF;\r\n\t                            font-size:small;\r\n                            }\r\n                            th{\r\n\t                            text-align:center;\r\n\t                            vertical-align:center;\r\n                            }\r\n                            td{\r\n\t                            vertical-align:top;\r\n                            }\r\n                            .first-cell{\r\n\t                            width:20%;\r\n                            }\r\n                            .last-cell-date{\r\n\t                            width:11%;\r\n                            }\r\n                            .cell-status{\r\n\t                            width:19%;\r\n                            }\r\n                            .last-cell-time{\r\n\t                        width:8%;\r\n                            }\r\n                            .cell_sr{\r\n                                width:100%;\r\n                            }\r\n                            </style>\r\n                            <script type=\"text/javascript\">\r\n                            function doResize(){\r\n\t                            document.getElementById('t-header').setAttribute('width',document.getElementById('t-data').offsetWidth);\r\n                            }\r\n                            </script>\r\n                            </head>\r\n                            <body onLoad=\"doResize()\" onResize=\"doResize()\">");
            stringBuilder.Append("<table  id=\"t-header\" style = \" position:fixed; top:0px; height:85px; z-index:1000;background-color:black;\">\n");
            stringBuilder.Append("<TR>\n");

            if (idDivision == IdODS)
                stringBuilder.Append("<th    COLSPAN=8><I><B>Плановые работы в сетях МУП \"УльГЭС\"</B></I></FONT>");
            else if (idDivision == IdSESNO)
                stringBuilder.Append("<th    COLSPAN=8><I><B>Плановые работы в сетях наружного освещения МУП \"УльГЭС\"</B></I></FONT>");
            else
                stringBuilder.Append("<th    COLSPAN=8><I><B> </B></I></FONT>");

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
            DataTable dataTable = this.LoadData(dateBeg, dateEnd, idDivision);
            int idSR = -1;
            if (dataTable.Rows.Count == 0)
            {
                stringBuilder.Append("<TR>\n");
                if (idDivision == IdODS)
                    stringBuilder.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#bfffff;\">плановых работ в электрических сетях МУП \"УльГЭС\" нет\n");
                else if (idDivision == IdSESNO)
                    stringBuilder.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#bfffff;\">плановых работ в  сетях наружного освещения МУП \"УльГЭС\" нет\n");
                else
                    stringBuilder.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#bfffff;\"> \n");

                stringBuilder.Append("</tr>\n");
            }
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow dataRow = dataTable.Rows[i];
                string datetripbeg = dataRow["datetripbeg"].ToString();
                string datetripend = dataRow["datetripend"].ToString();
                int num2 = i;
                int num3 = 0;
                for (; ; )
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
                if (idSR != Convert.ToInt32(dataRow["idSR"]))
                {
                    stringBuilder.Append("<TR>\n");
                    string nameRaion = References.Raions.GetNameRaion(dataRow["SR"].ToString());
                    stringBuilder.Append("<TD class=\"cell-sr\" COLSPAN=8 style=\"background-color:#c0dcc0;\">" + nameRaion + "\n");
                    stringBuilder.Append("</tr>\n");
                    idSR = Convert.ToInt32(dataRow["idSR"]);
                }
                stringBuilder.Append("<TR>\n");
                string txtSchmObj = dataRow["SchmObj"].ToString();
                txtSchmObj = txtSchmObj.Replace(",", ", ");
                txtSchmObj = txtSchmObj.Replace(",  ", ", ");
                stringBuilder.Append(string.Format("<TD class=\"first-cell\" >{0}\n", txtSchmObj));
                string txtAddress = (dataRow["Address"] == DBNull.Value || string.IsNullOrEmpty(dataRow["Address"].ToString())) ? "&nbsp;" : dataRow["Address"].ToString();
                List<string> listAddress = txtAddress.Split(new string[]
                {
                    "\r\n"
                }, StringSplitOptions.None).ToList<string>();
                if (listAddress.Count > 1 && listAddress.Contains(""))
                {
                    listAddress.Remove("");
                }
                listAddress.Sort();
                txtAddress = string.Join("<br>", listAddress.ToArray());
                txtAddress = txtAddress.Replace(",", ", ");
                txtAddress = txtAddress.Replace(",  ", ", ");
                stringBuilder.Append(string.Format("<TD >{0}\n", txtAddress));
                string txtDateBeg = "";
                string txtDateEnd = "";
                string txtTimeBeg = "";
                string txtTimeEnd = "";
                num2 = i;
                num3 = 0;
                for (; ; )
                {
                    num2++;
                    if (num2 >= dataTable.Rows.Count || Convert.ToInt32(dataRow["id"]) != Convert.ToInt32(dataTable.Rows[num2]["id"]))
                    {
                        break;
                    }
                    DataRow dataRow2 = dataTable.Rows[num2];
                    txtDateBeg = txtDateBeg + "<br>" + Convert.ToDateTime(dataRow2["datetripbeg"]).Date.ToShortDateString();
                    txtTimeBeg = txtTimeBeg + "<br>" + Convert.ToDateTime(dataRow2["datetripbeg"]).ToShortTimeString();
                    txtDateEnd = txtDateEnd + "<br>" + Convert.ToDateTime(dataRow2["datetripEnd"]).Date.ToShortDateString();
                    txtTimeEnd = txtTimeEnd + "<br>" + Convert.ToDateTime(dataRow2["datetripEnd"]).ToShortTimeString();
                    num3++;
                }
                stringBuilder.Append("<TD class=\"last-cell-date\">" + Convert.ToDateTime(dataRow["datetripbeg"]).Date.ToShortDateString() + txtDateBeg + "\n");
                stringBuilder.Append("<TD class=\"last-cell-time\">" + Convert.ToDateTime(dataRow["datetripbeg"]).ToShortTimeString() + txtTimeBeg + "\n");
                stringBuilder.Append("<TD class=\"last-cell-date\">" + Convert.ToDateTime(dataRow["datetripEnd"]).Date.ToShortDateString() + txtDateEnd + "\n");
                stringBuilder.Append("<TD class=\"last-cell-time\">" + Convert.ToDateTime(dataRow["datetripEnd"]).ToShortTimeString() + txtTimeEnd + "\n");
                string arg = (dataRow["SiteStatus"] == DBNull.Value || string.IsNullOrEmpty(dataRow["SiteStatus"].ToString())) ? "&nbsp;" : dataRow["SiteStatus"].ToString();
                stringBuilder.Append(string.Format("<TD class=\"cell-status\" >{0}\n", arg));
                i += num3;
            }
            stringBuilder.Append("</tbody>\n");
            stringBuilder.Append("</table>\n");
            stringBuilder.Append("</body>\n");
            stringBuilder.Append("</html>\n");
            if (this.PathName.Length > 0 && this.PathName[this.PathName.Length - 1] != '\\')
            {
                this.PathName += "\\";
            }
            if (idDivision == IdODS)
                SchemeService.UtilsFile.WriteToFileXML(this.PathName + this.FileName, stringBuilder, Encoding.GetEncoding(1251), false);
            else if (idDivision == IdSESNO)
                SchemeService.UtilsFile.WriteToFileXML(this.PathName + this.FileNameSESNO, stringBuilder, Encoding.GetEncoding(1251), false);
        }

        public DataTable LoadData()
        {
            return LoadData(DataBeg, DataEnd, IdDivision);
        }
        public DataTable LoadData(DateTime dateBeg, DateTime dateEnd, int idDivision = IdODS)
        {
            string txtWhereByDivision = getStringWhereByDivision(idDivision);

            string strDateBeg = "'" + dateBeg.Date.ToString("yyyyMMdd") + "'";
            string strDateEnd = "'" + dateEnd.Date.ToString("yyyyMMdd") + " 23:59:59'";
            string whereDate = string.Concat(new string[]
            {
                " ((dateTripBeg >= ",  strDateBeg, " and datetripBEg <= ", strDateEnd, ") " +
                " or (datetripend >= ", strDateBeg, " and datetripEnd <= ",  strDateEnd,") " +
                " or (datetripBeg <= ", strDateBeg, " and dateTRipEnd >= ",  strDateEnd, ")) "
            });
            string wheredDivision = " (idDivision = " + idDivision.ToString() + ") ";
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString()))
            {
                try
                {
                    sqlConnection.Open();
                    new SqlDataAdapter(string.Concat(new string[]
                    {
                        "select * from vJ_RequestForRepairDaily r where ",
                        whereDate,
                        " and ",
                        wheredDivision,
                        " and deleted = 0  and " + txtWhereByDivision + " and (crash = 0 or crash is null)  order by sr, id, datetripBeg"
                    }), sqlConnection).Fill(dataTable);
                    if (dateBeg.Date == dateEnd.Date)
                    {
                        foreach (object obj in dataTable.Rows)
                        {
                            DataRow dataRow = (DataRow)obj;
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
                    SchemeService.SchemeEventLog.WriteEntry("LoadData (" + idDivision.ToString() + "): " + ex.Message, EventLogEntryType.Error);
                }
            }
            return dataTable;
        }
        public void UploadFileToFTP(int idDivision = IdODS)
        {
            if (this.PathName.Length > 0 && this.PathName[this.PathName.Length - 1] != '\\')
            {
                this.PathName += "\\";
            }
            string fileName = this.PathName;
            if (idDivision == IdODS)
                fileName = fileName + this.FileName;
            else if (idDivision == IdSESNO)
                fileName = fileName + this.FileNameSESNO;

            if (this.useFTP)
            {
                SchemeService.UtilsCURL.UploadFileToFTPByCURL(this.pathToCURL, this.ftpName, this.ftpUser, this.ftpPwd, fileName, this.proxy, this.proxyUser, this.proxyPwd);
            }
        }

    }
}
