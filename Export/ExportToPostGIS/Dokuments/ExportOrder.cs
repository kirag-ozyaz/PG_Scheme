using Logger;
using Npgsql;
using DataSql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.IO;
//using Logger;
using System.Data.SqlClient;
using Scheme.Forms;
using System.ServiceModel;
using SchemeCtrl2.Canvas;
using SchemeCtrl2.DrawTool;
using SchemeCtrl2.Layers;
using System.Diagnostics;
using System.Xml;
using System.Drawing;
using LibraryTSQL;

namespace ExportToPostGIS.Dokuments
{
    public class Document
    {
        public SQLSettings SqlSettings { get; set; }
        public int? IdDocument { get;  set; } = -1;
        public virtual Library.Dokuments.eTypeDocuments TypeDocument { get;  set; }

        public string ServerPSQL = "192.168.1.33";
        public string UserIdPSSQL = "postgres";
        public string PasswordPSSQL = "psql";
        public string DatabasePSSQL = "U10";
        public string DatabasePSSQL_GIS = "gis";
        public string connectionString { get; set; }
        public string connectionString_GIS { get; set; }
    }
    public class Order : Document
    {
        public new Library.Dokuments.eTypeDocuments TypeDocument = Library.Dokuments.eTypeDocuments.Order;
        /// <summary>
        /// таблица данных
        /// </summary>
        DataTable dataTableOrder;
        internal void Export(int? IdDocument)
        {
            dataTableOrder = LoadDataDokument(IdDocument);
        }
        internal void Export()
        {
            // 0.
            // Проблема - 1: наложение разных событий на схеме на одну и туже координату
            // Проблема - 2: стыковка наименований подстанций в схеме и карте

            // 1. тянем документы
            dataTableOrder = LoadDataDokument();
            // 2. Удалим старые документы в  tSchm_Label

            DataSetDokuments dsDokuments = new DataSetDokuments();

            LibraryTSQL.cTSQL tSQL = new LibraryTSQL.cTSQL();
            tSQL.SqlSettings = this.SqlSettings;
            tSQL.SelectSqlData(dsDokuments,dsDokuments.tSchm_Label, true, $" where ExtendedTypeLabel = {(int)Library.Dokuments.eTypeDocuments.Order} ");

            // соберем удаляемые лабелы для удаления через сервер WCF
            // id может повторяться, пока так думаю
            Dictionary<int, NodeChangeDB> dictNodeId = new Dictionary<int, NodeChangeDB>();
            for (int i = dsDokuments.tSchm_Label.Rows.Count - 1; i >= 0; i--)
            {
                DataRow row = dsDokuments.tSchm_Label.Rows[i];
                // возьмем координаты лабела
                string SchemaXml = Convert.ToString(row["XmlCoords"]);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(SchemaXml);
                XmlNode xmlNodeObj = xmlDocument.SelectSingleNode("Obj");
                double X1 = Convert.ToDouble(xmlNodeObj.Attributes["X1"].Value);
                double Y1 = Convert.ToDouble(xmlNodeObj.Attributes["Y1"].Value);

                int IdBase = (int)row["id"];
                string textNode = (string)row["Name"];

                dictNodeId.Add(IdBase, 
                    new NodeChangeDB { IdBase = IdBase, idAction = SchemeEventType.NodeDel, text = textNode
                    , point = new PointF((float)X1,(float)Y1)
                    });
                // удалим лабел в базе
                dsDokuments.tSchm_Label.Rows[i].Delete();
            }

            tSQL.DeleteSqlDataN(dsDokuments.tSchm_Label);
            // заполним новыми Label
            double deltaY = 0.3;
            double deltaХ = 0.3;
            foreach (DataRow row in dataTableOrder.Rows)
            {
                // Документ Наряд
                int NUMDoc = Convert.ToInt32(row["NUM"]);
                int IdDoc = Convert.ToInt32(row["ID"]);
                System.DateTime DATEOUTPUT = Convert.ToDateTime(row["DATEOUTPUT"]);
                System.DateTime DATEBEGIN = Convert.ToDateTime(row["DATEBEGIN"]);
                System.DateTime DATEEND = Convert.ToDateTime(row["DATEEND"]);
                // Подстанция
                int SubId = Convert.ToInt32(row["subid"]);
                string SubName = Convert.ToString(row["subname"]);
                // Координаты подстанции
                // левый нижний край
                if (row["SchemaXml"] == DBNull.Value) continue;
                string SchemaXml = Convert.ToString(row["SchemaXml"]);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(SchemaXml);

                XmlNode xmlNodeObj = xmlDocument.SelectSingleNode("Obj");
                if (xmlNodeObj == null) continue;

                double X1 = Convert.ToDouble(xmlNodeObj.Attributes["X1"].Value);
                double Y1 = Convert.ToDouble(xmlNodeObj.Attributes["Y1"].Value);
                // создадим NodeTool
                XmlDocument xmlLabel = new XmlDocument();
                XmlNode xmlLabelObj = xmlLabel.CreateElement("Obj");
                xmlLabel.AppendChild(xmlLabelObj);

                XmlAttribute xmlAttribute = xmlLabel.CreateAttribute("X1");
                xmlAttribute.Value = X1.ToString();
                xmlLabelObj.Attributes.Append(xmlAttribute);

                xmlAttribute = xmlLabel.CreateAttribute("Y1");
                // от нижней точки подстанции, спустим вниз NodeTool
                // 0.05 - типа зазор
                Y1 = Y1 - deltaY - 0.05; 
                xmlAttribute.Value = Y1.ToString();
                xmlLabelObj.Attributes.Append(xmlAttribute);

                int Color = -65281;
                xmlAttribute = xmlLabel.CreateAttribute("Color");
                xmlAttribute.Value = Color.ToString();
                xmlLabelObj.Attributes.Append(xmlAttribute);

                string XmlCoords = xmlLabel.InnerXml;

                DataRow row1 = dsDokuments.tSchm_Label.NewRow();

                row1["Name"] = $"Наряд № {NUMDoc} от {DATEOUTPUT.ToString("dd.MM.yyyy hh:mm")}\r\n" +
                    $"{SubName}\r\n" +
                    $"(с {DATEBEGIN.ToString("dd.MM.yyyy hh:mm")} по {DATEEND.ToString("dd.MM.yyyy hh:mm")})";
                row1["TypeLabel"] = (int)eTypeLabelTool.Node;
                //row1["idParent"] = SubId;
                row1["XmlCoords"] = XmlCoords;
                //row1["Tag"] = IdDoc;
                row1["ExtendedTypeLabel"] = (int)Library.Dokuments.eTypeDocuments.Order;
                row1["XmlSubstation"] = new NodeChangeDB.Substation { IdSub = SubId , NameSub= SubName}.ToXmlSubstation();

                dsDokuments.tSchm_Label.Rows.Add(row1);

            }
            tSQL.InsertSqlData(dsDokuments.tSchm_Label);
            // 2.3. чтобы отправить данные на сервер WCF, сделаем повторный запрос
            // дополним словарь добавляемыми данными
            dsDokuments.tSchm_Label.Rows.Clear();
            tSQL.SelectSqlData(dsDokuments, dsDokuments.tSchm_Label, true, $" where ExtendedTypeLabel = {(int)Library.Dokuments.eTypeDocuments.Order} ");
            foreach (DataRow row in dsDokuments.tSchm_Label.Rows)
            {
                // возьмем координаты лабела
                string SchemaXml = Convert.ToString(row["XmlCoords"]);
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(SchemaXml);
                XmlNode xmlNodeObj = xmlDocument.SelectSingleNode("Obj");
                double X1 = Convert.ToDouble(xmlNodeObj.Attributes["X1"].Value);
                double Y1 = Convert.ToDouble(xmlNodeObj.Attributes["Y1"].Value);
                // возьмем данные подстанции
                string XmlSubstation = Convert.ToString(row["XmlSubstation"]);
                xmlDocument.LoadXml(XmlSubstation);
                xmlNodeObj = xmlDocument.SelectSingleNode("Substation");
                int IdSub = Convert.ToInt32(xmlNodeObj.Attributes["IdSub"].Value);
                string NameSub = Convert.ToString(xmlNodeObj.Attributes["NameSub"].Value);
                // данные лабела
                int IdBase = (int)row["id"];
                string textNode = (string)row["Name"];
                dictNodeId.Add(IdBase,
                    new NodeChangeDB
                    {
                        IdBase = IdBase,
                        idAction = SchemeEventType.NodeAdd,
                        text = textNode,
                        point = new PointF((float)X1, (float)Y1),
                        substation = new NodeChangeDB.Substation{ IdSub = IdSub, NameSub = NameSub }
                    });
            }

            #region 2.5 сформируем подключение к серверу WCF (сначало к Scheme)
            // данные грузить не надо!
            //Uri uriWCF = new Uri("net.tcp://192.168.1.248:22222/WCFSchemeServer");
            //FormGeneralScheme2 formGeneralScheme2 = new FormGeneralScheme2(new SQLSettings(SqlSettings), new EndpointAddress(uriWCF), 1);

            /*
             Используем следующие объекты
             eTypeLabelTool.Node = NodeTool = 6 (это кругляш с восклицательным знаком) - эту хрень обрабатывать надо через WCF
                                                                                    (таблицу tSchm_Label использует WCF)
             eTypeLabelTool.FreeLabel = FreeLabelTool = 8 (это квадрат с текстом) - это обновляется при рефреше схемы, 
                                                                                добавляем/удаляем в таблицу tSchm_Label
             */
            CanvasControl canvasScheme = new CanvasControl();

            Uri uriWCF = new Uri("net.tcp://192.168.1.248:22222/WCFSchemeServer");
            EndpointAddress endPoint = new EndpointAddress(uriWCF);

            GUID.Set(this.SqlSettings);
            Guid guid = GUID.Get();

            SchemeCtrl2.WCF.Proxy_Singleton ProxySingleton = SchemeCtrl2.WCF.Proxy_Singleton.GetInstance();
            
            try
            {
                // ConnectToServer
#pragma warning disable CS0618 // Тип или член устарел
                IPAddress ipaddress = Dns.GetHostByName(Dns.GetHostName()).AddressList[0];
#pragma warning restore CS0618 // Тип или член устарел
                NetTcpBinding netTcpBinding = new NetTcpBinding(SecurityMode.None);
                netTcpBinding.Security.Mode = SecurityMode.None;
                netTcpBinding.SendTimeout = TimeSpan.FromSeconds(10.0);
                netTcpBinding.ReliableSession.Enabled = true;
                ProxySingleton.Connect(ipaddress.ToString() + Environment.UserName + "_" + Process.GetCurrentProcess().Id.ToString(), netTcpBinding, endPoint, guid);

                foreach (var enum1 in dictNodeId)
                {
                    int idNodeDB = enum1.Value.IdBase;
                    int idAction = (int)enum1.Value.idAction;
                    string NameNode = enum1.Value.text;
                    System.Drawing.PointF pointF = enum1.Value.point;
                    ProxySingleton.NodeChange(idNodeDB, idAction, NameNode, pointF, System.Drawing.Color.Cyan, guid);
                }
                //DisConnectServer
                ProxySingleton.ExitChatSession();
            }
            catch
            {
            }
            #endregion

            // 5. сформируем данные для карты
            // 5.0 соберем список подстанций
            var ss1 = dictNodeId.Where(w => w.Value.substation != null);
            var ss2 = ss1.Select(s => s.Value.substation.NameSub.ToString());
            var strSubstation = String.Concat("'", String.Join("', '", ss2.ToArray()), "'");
            // 5.1 подключимся к базе карты
            SQLSettingsGIS settingsGIS = new SQLSettingsGIS();
            string connectionString = settingsGIS.ToConnect();
            pSQL dd = new pSQL
            {
                connectionString = connectionString
            };

            string chemaElectric = "NetworkElectric";
            string tableSubstation = "SubStationN";
            DataTable tableSub = dd.SelectSqlData(chemaElectric, tableSubstation, $" where \"Name\" in ({strSubstation})");
            // Тип документа событий на карте (в данном случае наряд на работу = 5)
            int idTypeAlarmMap = 5;
            // закроем алармы, сделаем Visibility = false
            string chemaEvents = "Events";
            string tableAlarm = "Alarm";
            NpgsqlConnection conn1 = new NpgsqlConnection(connectionString);
            NpgsqlCommand com1 = new NpgsqlCommand($"UPDATE \"{chemaEvents}\".\"{tableAlarm}\" SET \"Visibility\" = false Where \"idTypeAlarm\" = {idTypeAlarmMap}", conn1);
            conn1.Open();
            int reader1 = com1.ExecuteNonQuery();
            conn1.Close();

            // выходная таблица событий на карту
            DataTable tableMapAlarm = new DataTable();
            tableMapAlarm.Columns.Add("Name", Type.GetType("System.String"));
            tableMapAlarm.Columns.Add("Description", Type.GetType("System.String"));
            tableMapAlarm.Columns.Add("Begin", Type.GetType("System.DateTime"));
            tableMapAlarm.Columns.Add("End", Type.GetType("System.DateTime"));

            tableMapAlarm.Columns.Add("Visibility", Type.GetType("System.Boolean"));
            tableMapAlarm.Columns.Add("DateEvent", Type.GetType("System.DateTime"));
            tableMapAlarm.Columns.Add("idTypeAlarm", Type.GetType("System.Int32"));

            tableMapAlarm.Columns.Add("geom", typeof(String));

            foreach (DataRow row in dataTableOrder.Rows)
            {
                // Документ Наряд
                int NUMDoc = Convert.ToInt32(row["NUM"]);
                int IdDoc = Convert.ToInt32(row["ID"]);
                System.DateTime DATEOUTPUT = Convert.ToDateTime(row["DATEOUTPUT"]);
                System.DateTime DATEBEGIN = Convert.ToDateTime(row["DATEBEGIN"]);
                System.DateTime DATEEND = Convert.ToDateTime(row["DATEEND"]);
                // Подстанция
                int SubId = Convert.ToInt32(row["subid"]);
                string SubName = Convert.ToString(row["subname"]);
                //
                DataRow row1 = tableMapAlarm.NewRow();
                row1["Name"] = $"Наряд № {NUMDoc} от {DATEOUTPUT.ToString("dd.MM.yyyy hh:mm")}";
                row1["Description"] = SubName;
                row1["Begin"] = DATEBEGIN;
                row1["End"] = DATEEND;
                row1["DateEvent"] = DATEOUTPUT;
                row1["idTypeAlarm"] = idTypeAlarmMap; // для документа наряд
                row1["Visibility"] = true;
                // 5.2 найдем координаты подстанций
                var currentSub = tableSub.AsEnumerable().Where(w => w["Name"].ToString() == SubName);
                if (currentSub.Count()>0)
                    row1["geom"] = currentSub.First()["geom"];
                // 5.3 отпрвим данные в таблицу (слой) событий 
                tableMapAlarm.Rows.Add(row1);
                
            }
            dd.ExportSqlData(tableMapAlarm, chemaEvents, tableAlarm);
        }
        /// <summary>
        /// получение списка активных нарядов
        /// </summary>
        /// <param name="IdDocument"></param>
        /// <returns></returns>
        public DataTable LoadDataDokument(int? IdDocument = null)
        {
            DataTable dt = new DataTable();
            DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();


            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(typeof(Order).Assembly, "ExportToPostGIS.Dokuments.GetTableOrder.sql"), sqlConnection);

                    if (IdDocument != null)
                        sqlCommand.Parameters.Add("IdDocument", SqlDbType.Int).Value = IdDocument;
                    else
                        sqlCommand.Parameters.Add("IdDocument", SqlDbType.Int).Value = DBNull.Value;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    sqlDataAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Log.Write(Logger.LogLevel.Error, "ExportToPostGIS", "ExportOrder", "LoadDataDokument - загрузка данных", ex.Message, null);
                }
            }
            return dt;
        }
    }
}
public enum SchemeEventType
{
    NodeAdd = 1,
    NodeDel = 2,
    NodeChange = 3
}
internal  class NodeChangeDB
{
    public  int IdBase { get; set; }
    public  SchemeEventType idAction { get; set; }
    public  string text { get; set; }
    /// <summary>
    /// координаты на схеме
    /// </summary>
    public  PointF point { get; set; }
    public Substation substation { get; set; }
    public class Substation
    {
        public int IdSub { get; set; }
        public string NameSub { get; set; }

        public  string ToXmlSubstation()
        {
            XmlDocument xmlSubstation = new XmlDocument();
            XmlNode xmlNode = xmlSubstation.CreateElement("Substation");
            xmlSubstation.AppendChild(xmlNode);

            XmlAttribute xmlAttribute = xmlSubstation.CreateAttribute("NameSub");
            xmlAttribute.Value = NameSub.ToString();
            xmlNode.Attributes.Append(xmlAttribute);

            xmlAttribute = xmlSubstation.CreateAttribute("IdSub");
            xmlAttribute.Value = IdSub.ToString();
            xmlNode.Attributes.Append(xmlAttribute);

            return xmlSubstation.InnerXml;
        }
    }
}
internal static class GUID
{
    private static SQLSettings sqlsettings;
    private static Guid guid;

    internal static void Set(SQLSettings sqlsettings_1)
    {
        sqlsettings = sqlsettings_1;
        CreateGuid();
    }

    internal static Guid Get()
    {
        return guid;
    }

    private static void CreateGuid()
    {
        if (sqlsettings == null)
        {
            guid = Guid.Empty;
            return;
        }
        SqlConnection sqlConnection = new SqlConnection(sqlsettings.GetConnectionString());
        SqlCommand sqlCommand = new SqlCommand(string.Format("SELECT [database_guid] FROM sys.databases INNER JOIN sys.database_recovery_status ON sys.database_recovery_status.database_id = sys.databases.database_id WHERE [name] = '{0}'", GUID.sqlsettings.DBName), sqlConnection);
        try
        {
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                guid = (Guid)sqlDataReader[0];
            }
            else
            {
                guid = Guid.Empty;
            }
        }
        catch
        {
            guid = Guid.Empty;
        }
    }
}
/**
 * 
 * 
 * 
 * 

SELECT doc.[_Version], doc.[_Number], doc.[_Date_Time], vt7523.*
From [dbo].[_Document396] doc
  left join.[dbo].[_Document396_VT7523] vt7523 on vt7523.[_Document396_IDRRef] = doc.[_IDRRef]
  where doc.[_Date_Time] = '4020-09-30 00:00:00.000' and doc.[_Number] = '0000-000010'
  order by  doc.[_Date_Time] desc
 * 
 * 
 * 
 */