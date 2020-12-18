using DataSql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Xml;

namespace References
{
    /// <summary>
    /// Настройки передачи данных
    /// </summary>
    public static class SettingsTable
    {
        //public static SQLSettings sqlsettings { get; set; }
        public static DataTable GetSettingMinEnergo(SQLSettings sqlsettings)
        {
            DataTable ts = new DataTable("tSettingsME");
            ts.Columns.Add("SendME", typeof(bool));
            ts.Columns.Add("URL");
            ts.Columns.Add("Login");
            ts.Columns.Add("Pwd");
            ts.Columns.Add("CreateAktDHV", typeof(bool));
            ts.Columns.Add("CreateAktDLV", typeof(bool));
            ts.Columns.Add("SendNullListAbonent", typeof(bool));
            ts.Columns.Add("SendCorrectDamage", typeof(bool));
            ts.Columns.Add("Proxy");
            ts.Columns.Add("ProxyUser");
            ts.Columns.Add("ProxyPwd");
            ts.Columns.Add("PathCURL");

            //bool SendME = false;
            /// вернуть параметры подключения к минэнерго
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
                            XmlNode xmlNode2 = xmlNode.SelectSingleNode("MinEnergo");
                            if (xmlNode2 != null)
                            {
                                ts.Rows.Add(
                                    Convert.ToBoolean(xmlNode2.Attributes["SendME"].Value)
                                    , xmlNode2.Attributes["URL"].Value
                                    , xmlNode2.Attributes["Login"].Value
                                    , xmlNode2.Attributes["Pwd"].Value
                                    , Convert.ToBoolean(xmlNode2.Attributes["CreateAktDHV"].Value)
                                    , Convert.ToBoolean(xmlNode2.Attributes["CreateAktDLV"].Value)
                                    , Convert.ToBoolean(xmlNode2.Attributes["SendNullListAbonent"].Value)
                                    , Convert.ToBoolean(xmlNode2.Attributes["SendCorrectDamage"].Value));
                            }
                            if (ts.Rows.Count == 1)
                            {
                                XmlNode xmlNode3 = xmlNode.SelectSingleNode("FTP05");
                                if (xmlNode3 != null)
                                {
                                    XmlAttribute xmlAttribute = xmlNode3.Attributes["Proxy"];
                                    if (xmlAttribute != null)
                                    {
                                        ts.Rows[0]["Proxy"] = xmlAttribute.Value;
                                        ts.Rows[0]["ProxyUser"] = xmlNode3.Attributes["ProxyUser"].Value;
                                        ts.Rows[0]["ProxyPwd"] = xmlNode3.Attributes["ProxyPwd"].Value;
                                    }
                                }
                                xmlNode3 = xmlNode.SelectSingleNode("PathCURL");
                                if (xmlNode3 != null && !string.IsNullOrEmpty(xmlNode3.InnerText))
                                {
                                    ts.Rows[0]["PathCURL"] = xmlNode3.InnerText;
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
            return ts;
        }

        public static DataTable GetSettingSmartCity(SQLSettings sqlSettings)
        {
            DataTable ts = new DataTable("tSettingsSC");
            ts.Columns.Add("IntegrationSmartCity", typeof(bool));
            ts.Columns.Add("URL");
            ts.Columns.Add("Login");
            ts.Columns.Add("Pwd");
            ts.Columns.Add("Proxy");
            ts.Columns.Add("ProxyUser");
            ts.Columns.Add("ProxyPwd");

            return ts;
        }
    }
}
