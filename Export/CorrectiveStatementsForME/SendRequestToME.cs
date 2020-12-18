using DataSql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryTSQL;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using FormLbr;
using System.Net.Cache;
using Logger;
using System.Diagnostics;
/// <summary>
/// Экспорт данных
/// </summary>
namespace StatementsForME
{
    /// <summary>
    /// отправка данных в минэнерго (JSON)
    /// </summary>
    public partial class SendRequestToME
    {
        public SQLSettings SqlSettings { get; set; }
        /// <summary>
        /// идентификатор Идентификатор документа
        /// </summary>
        public int IdDocument = -1;
        /// <summary>
        /// таблица данных
        /// </summary>
        static DataTable dataTableDamage;
        /// <summary>
        /// таблица данных ТСО МЭ
        /// </summary>
        static List<string> listTSO;
        
        /// получаем список сетевых организаций из минэнерго
        /// listNetOrg - спсиок сетевых организаций для проверки
        public List<string> LoadTableTSO()
        {
            List<string> listTSO = new List<string>();

            DataTable dtSetting = References.SettingsTable.GetSettingMinEnergo(SqlSettings);
            string login = dtSetting.Rows[0]["Login"].ToString();
            string pwd = dtSetting.Rows[0]["Pwd"].ToString();
            string url = dtSetting.Rows[0]["URL"].ToString();
            //
            string Proxy = dtSetting.Rows[0]["Proxy"].ToString();
            string ProxyUser = dtSetting.Rows[0]["ProxyUser"].ToString();
            string ProxyPwd = dtSetting.Rows[0]["ProxyPwd"].ToString();
            //
            string tso_id = "2232";

            PostResultTSO postResult = new PostResultTSO();
            postResult.app = "nadezhnost";
            postResult.app_ver = "1256";
            postResult.body = new BodyTSO()
            {
                auth = new Auth()
                {
                    login = login,
                    pwd = pwd
                },
                type = "adjacentTso"
            };
            postResult.body.data = new List<string>();
            postResult.body.data.Add(tso_id);

            string serialized = JsonConvert.SerializeObject(postResult);

            UTF8Encoding encoding = new UTF8Encoding(false); // без BOOM
            var json = encoding.GetBytes(serialized);

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                request.Method = WebRequestMethods.Http.Post; // "POST";
                request.ContentType = "application/json";

                request.ContentLength = json.Length;
                request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;

                // прокся по умолчанию
                if (Proxy == "")
                {
                    request.Proxy = WebRequest.GetSystemWebProxy();
                    request.Proxy.Credentials = CredentialCache.DefaultCredentials;
                }
                else
                {
                    WebProxy myProxy = new WebProxy
                    {
                        Address = new Uri($"http://{Proxy}/"),
                        Credentials = new NetworkCredential(ProxyUser, ProxyPwd)
                    };
                    request.Proxy = myProxy;
                }

                request.Credentials = CredentialCache.DefaultCredentials;
                request.CachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);

                using (Stream streamWriter = request.GetRequestStream())
                {
                    streamWriter.Write(json, 0, json.Length);
                }
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader myStreamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        var objectFromServer = JsonConvert.DeserializeObject<GetResultTSO>(myStreamReader.ReadToEnd());
                        foreach (var eData in objectFromServer.data)
                        {
                            foreach (var eAdjacent in eData.adjacent_tso_arr)
                            {
                                listTSO.Add(eAdjacent);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                listTSO.Add(e.ToString());
                //return null;
            }

            return listTSO;
        }
        /// <summary>
        /// вернуть регламентируемую таблицу ТСО из МИнэнерго
        /// </summary>
        /// <param name="G"></param>
        /// <returns></returns>
        public DataTable LoadTableTSO(int G)
        {
            DataTable tableTSO = new DataSetStatement.TableTSODataTable();

            DataTable dtSetting = References.SettingsTable.GetSettingMinEnergo(SqlSettings);
            string login = dtSetting.Rows[0]["Login"].ToString();
            string pwd = dtSetting.Rows[0]["Pwd"].ToString();
            string url = dtSetting.Rows[0]["URL"].ToString();
            //
            string Proxy = dtSetting.Rows[0]["Proxy"].ToString();
            string ProxyUser = dtSetting.Rows[0]["ProxyUser"].ToString();
            string ProxyPwd = dtSetting.Rows[0]["ProxyPwd"].ToString();
            //
            string tso_id = "2232";

            PostResultTSO postResult = new PostResultTSO();
            postResult.app = "nadezhnost";
            postResult.app_ver = "1256";
            postResult.body = new BodyTSO()
            {
                auth = new Auth()
                {
                    login = login,
                    pwd = pwd
                },
                type = "adjacentTso"
            };
            postResult.body.data = new List<string>();
            postResult.body.data.Add(tso_id);

            string serialized = JsonConvert.SerializeObject(postResult);

            if (G == 1)
            {
                string PathCURL = dtSetting.Rows[0]["PathCURL"].ToString();
                string myStringReader = CURLProcessUpLoadToURL.StartHTTP(PathCURL, url, serialized, Proxy, ProxyUser, ProxyPwd);

                var objectFromServer = JsonConvert.DeserializeObject<GetResultTSO>(myStringReader);
                foreach (var eData in objectFromServer.data)
                {
                    int max = eData.adjacent_tso_arr.Count() > eData.adjacent_tso_id_arr.Count() ? eData.adjacent_tso_arr.Count() : eData.adjacent_tso_arr.Count();
                    for (int k = 0; k < max; k++)
                    {
                        tableTSO.Rows.Add(eData.adjacent_tso_id_arr[k], eData.adjacent_tso_arr[k]);
                    }
                }

            }
            else if (G == 0)
            {
                UTF8Encoding encoding = new UTF8Encoding(false); // без BOOM
                var json = encoding.GetBytes(serialized);

                try
                {
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                    //IWebProxy proxy = request.Proxy;
                    var proxy = WebRequest.GetSystemWebProxy();
                    request.Method = WebRequestMethods.Http.Post; // "POST";
                    request.ContentType = "application/json";
                    request.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; en)";
                    request.KeepAlive = true;

                    request.ContentLength = json.Length;
                    request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;

                    // прокся по умолчанию
                    if (Proxy == "")
                    {
                        request.Proxy = WebRequest.GetSystemWebProxy();
                        request.Proxy.Credentials = CredentialCache.DefaultCredentials;
                    }
                    else
                    {
                        WebProxy myProxy = new WebProxy()
                        {
                            Address = new Uri($"http://{Proxy}"),
                            BypassProxyOnLocal = false,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(ProxyUser, ProxyPwd) // ошибка 407
                            //Credentials = new NetworkCredential("ftp_use1", "f1le-tp6") // ошибка 403
                        };
                        request.Proxy = myProxy;

                        //proxy.Credentials = new NetworkCredential("ftp_use1", "f1le-tp6"); //не пробовал
                        //proxy.Credentials = new NetworkCredential(ProxyUser, ProxyPwd); // ошибка 403
                        //request.Proxy = proxy;
                    }

                    using (Stream streamWriter = request.GetRequestStream())
                    {
                        streamWriter.Write(json, 0, json.Length);
                    }
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        using (StreamReader myStreamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                        {
                            var objectFromServer = JsonConvert.DeserializeObject<GetResultTSO>(myStreamReader.ReadToEnd());
                            foreach (var eData in objectFromServer.data)
                            {
                                int max = eData.adjacent_tso_arr.Count() > eData.adjacent_tso_id_arr.Count() ? eData.adjacent_tso_arr.Count() : eData.adjacent_tso_arr.Count();
                                for (int k = 0; k < max; k++)
                                {
                                    tableTSO.Rows.Add(eData.adjacent_tso_id_arr[k], eData.adjacent_tso_arr[k]);
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    tableTSO.Clear();
                    tableTSO.Rows.Add(e.ToString(), null);
                    // return null;
                }
            }
            return tableTSO;
        }
        /// <summary>
        /// Сбор аварийных событий одного документа
        /// </summary>
        /// <returns></returns>
        public DataTable LoadDataOneDokument()
        {
            DataTable dt = new DataTable();
            DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();

            // проверим есть ли данные простым запросом, чтобы не запускать тяжелый
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    System.Data.DataTable dataTable = new DataSql.SqlDataCommand(this.SqlSettings).SelectSqlData(String.Format("select * from tJ_Damage  where id = {0} ", IdDocument));

                    if (dataTable.Rows.Count <= 0)
                    {
                        return dt;
                    }
                }
                catch (Exception ex)
                {
                    Log.Write(LogLevel.Error, "StatementsForME", "StatementsForME", "LoadDataOneDokument - проверка наличия данных", ex.Message, null);
                }
            }
            // запускаем тяжеловеса
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(typeof(SendRequestToME).Assembly, "StatementsForME.GetTableDamage.sql"), sqlConnection);
                    sqlCommand.Parameters.Add("isSendSiteMe", SqlDbType.Int).Value = DBNull.Value;
                    sqlCommand.Parameters.Add("Year", SqlDbType.Int).Value = DBNull.Value;
                    sqlCommand.Parameters.Add("Month", SqlDbType.Int).Value = DBNull.Value;
                   
                    sqlCommand.Parameters.Add("idDoc", SqlDbType.Int).Value = IdDocument;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    sqlDataAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Log.Write(LogLevel.Error, "StatementsForME", "StatementsForME", "LoadDataOneDokument - загрузка данных", ex.Message, null);
                }
            }
            return dt;
        }
        /// <summary>
        /// Сбор аварийных событий
        /// </summary>
        /// <returns></returns>
        public DataTable LoadData(int isSendSiteMe, int? Year = null, int? Month = null)
        {
            DataTable dt = new DataTable();
            DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();

            // проверим есть ли данные простым запросом, чтобы не запускать тяжелый
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    System.Data.DataTable dataTable = new DataSql.SqlDataCommand(this.SqlSettings).SelectSqlData("select * from tJ_Damage  where deleted = 0 and "
                        + (isSendSiteMe != 0 ? "isSendSiteMe = " + isSendSiteMe : "")
                        + (Year != null && Month != null ? " and Year(DateDoc) = " + Year + " and Month(DateDoc) = " + Month : ""));

                    if (dataTable.Rows.Count <= 0)
                    {
                        return dt;
                    }
                    if (IdDocument != -1)
                    {
                        if (dataTable.Select("id = " + IdDocument).Count() <= 0)
                        {
                            return dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Log.Write(LogLevel.Error, "StatementsForME", "StatementsForME", "LoadData - проверка наличия данных", ex.Message, null);
                }
            }

            // запускаем тяжеловеса
            using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand(Library.ResourceReader.GetStringAssembly(typeof(SendRequestToME).Assembly, "StatementsForME.GetTableDamage.sql"), sqlConnection);
                    if (isSendSiteMe != 0)
                        sqlCommand.Parameters.Add("isSendSiteMe", SqlDbType.Int).Value = isSendSiteMe;
                    else
                        sqlCommand.Parameters.Add("isSendSiteMe", SqlDbType.Int).Value = DBNull.Value;
                    //if (!(Year == null && Month == null))
                    //{
                    //    sqlCommand.Parameters.Add("Year", SqlDbType.Int).Value = Year;
                    //    sqlCommand.Parameters.Add("Month", SqlDbType.Int).Value = Month;
                    //}
                    //else
                    //{
                    //    sqlCommand.Parameters.Add("Year", SqlDbType.Int).Value = DBNull.Value;
                    //    sqlCommand.Parameters.Add("Month", SqlDbType.Int).Value = DBNull.Value;
                    //}

                    if (Year != null)
                        sqlCommand.Parameters.Add("Year", SqlDbType.Int).Value = Year;
                    else
                        sqlCommand.Parameters.Add("Year", SqlDbType.Int).Value = DBNull.Value;

                    if (Month != null)
                        sqlCommand.Parameters.Add("Month", SqlDbType.Int).Value = Month;
                    else
                        sqlCommand.Parameters.Add("Month", SqlDbType.Int).Value = DBNull.Value;

                    sqlCommand.Parameters.Add("idDoc", SqlDbType.Int).Value = DBNull.Value;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                    sqlDataAdapter.Fill(dt);
                }
                catch (Exception ex)
                {
                    Log.Write(LogLevel.Error, "StatementsForME", "StatementsForME", "LoadData - загрузка данных", ex.Message, null);
                }
            }

            if (IdDocument != -1)
            {
                if (dt.Select("id = " + IdDocument).Count() != 0)
                    return dt.Select("id = " + IdDocument).CopyToDataTable();
                else
                    dt.Clear();
            }
            return dt;
        }
        public void Send(int idDocument, SQLSettings sqlSettings)
        {
            SqlSettings = sqlSettings;
            IdDocument = idDocument;
            SendJSONInstantly();
        }
        public void Send(SQLSettings sqlSettings)
        {
            SqlSettings = sqlSettings;
            SendJSONInstantly();
        }

        #region Формирование отправляемых данных (json)
        public class Auth
        {
            public string login { get; set; }
            public string pwd { get; set; }
        }
        public class Datum
        {
            public string tso_id { get; set; }
            public string num { get; set; }
            public string name { get; set; }
            public string obj_type { get; set; }
            public string obj_name { get; set; }
            public string voltage_lvl { get; set; }
            public string dt_start { get; set; }
            public string dt_recover { get; set; }
            public string dt_offset { get; set; }
            public string deenergized_type { get; set; }
            public string duration { get; set; }
            public string apv { get; set; }
            public string avr { get; set; }
            public string feed_objects_list { get; set; }
            public string consumers_fully_deenergized { get; set; }
            public string consumers_partial_deenergized { get; set; }
            public string tp_total { get; set; }
            public string tp_cat_1 { get; set; }
            public string tp_cat_2 { get; set; }
            public string tp_cat_3 { get; set; }
            public string tp_vn { get; set; }
            public string tp_sn1 { get; set; }
            public string tp_sn2 { get; set; }
            public string tp_nn { get; set; }
            public string tp_neigh_org { get; set; }
            public string power_total { get; set; }
            public string tso_neigh_list { get; set; }
            public string log_info { get; set; }
            public string org_reason_code { get; set; }
            public string tech_reason_code { get; set; }
            public string accounting_in_indicators { get; set; }

        }

        public class Body
        {
            public Auth auth { get; set; }
            public string type { get; set; }
            public List<Datum> data { get; set; }
        }
        public class PostResult
        {
            public string app { get; set; }
            public string app_ver { get; set; }
            public Body body { get; set; }
        }

        public class BodyTSO
        {
            public Auth auth { get; set; }
            public string type { get; set; }
            public List<string> data { get; set; }
        }
        public class PostResultTSO
        {
            public string app { get; set; }
            public string app_ver { get; set; }
            public BodyTSO body { get; set; }
        }


        #endregion
        #region Получение результата (потом надо будет десериализовать)  (json)
        public class Error
        {
            public string code { get; set; }
            public string details { get; set; }
        }
        public class GetResult
        {
            public int result { get; set; }
            public Error error { get; set; }
            public string warning { get; set; }
            public List<Datum> data { get; set; }
            //public List<string> data { get; set; }
        }
        public class DatumGetResultTSO
        {
            public string tso_id { get; set; }
            public List<string> adjacent_tso_id_arr { get; set; } // tso_id: 
            public List<string> adjacent_tso_arr { get; set; }
        }
        public class GetResultTSO
        {
            public int result { get; set; }
            public Error error { get; set; }
            public string warning { get; set; }
            public List<DatumGetResultTSO> data { get; set; }
        }
        #endregion
        /// 1. "8.1_online" - оперативная информация по форме 8.
        /// поэтапное включение подстанций, как делать ???
        /// метод отправки postResult и получение результата из минэнерго
        /// мгновенная отправка данных при статусе = 1
        /// при любой отправке изменить поле isSendSiteMe
        private void SendJSONInstantly(string DATA_TYPE = "8.1_online")
        {
            int resultat = 0; // "Неправильный тип данных"
            dataTableDamage = LoadData(1);
            dataTableDamage.TableName = "tJ_Damage";
            if (dataTableDamage.Rows.Count == 0)
            {
                // аварийных событий нет
                return;
            }
            // настройки подключения
            DataTable dtSetting = References.SettingsTable.GetSettingMinEnergo(SqlSettings);

            // возвращаемый результат от сервака минэнерго
            GetResult objectFromServer = new GetResult();
            if (dtSetting.Rows.Count == 0) { objectFromServer.result = 10; } // настроек нет
            if ((bool)dtSetting.Rows[0]["SendME"] != true) { objectFromServer.result = 7; } // запрет отправки с нашей стороны
                                                                                            // логинимся
            string login = dtSetting.Rows[0]["Login"].ToString();
            // string pwd = SecureIt.Расшифровать(dtSetting.Rows[0]["Pwd"].ToString());
            string pwd = dtSetting.Rows[0]["Pwd"].ToString();
            string url = dtSetting.Rows[0]["URL"].ToString();
            //
            string Proxy = dtSetting.Rows[0]["Proxy"].ToString();
            string ProxyUser = dtSetting.Rows[0]["ProxyUser"].ToString();
            string ProxyPwd = dtSetting.Rows[0]["ProxyPwd"].ToString();
            //
            string tso_id = "2232";
            // теперь можно сформировать данные
            if (objectFromServer.result == 0) // ошибок нет
            {
                // сформируем таблицу ТСО МЭ
                listTSO = LoadTableTSO();
                // Формируем JSON
                // шапка файла
                PostResult postResult = new PostResult();
                postResult.app = "nadezhnost";
                postResult.app_ver = "1256";
                postResult.body = new Body()
                {
                    auth = new Auth()
                    {
                        login = login,  //"kirillovag",
                        pwd = pwd       //"t4zbaYz"
                    },
                    type = DATA_TYPE
                };
                //
                string dt_recover;
                // тело файла
                postResult.body.data = new List<Datum>();
                for (int i = 0; i < dataTableDamage.Rows.Count; i++)
                {
                    // проверим отправку документов (по корректности данных)
                    // если нет привязки к сетевому району, то нет отправки
                    string net_name = dataTableDamage.Rows[i]["name"].ToString();
                    if (net_name.Length == 0)
                    {
                        objectFromServer.result = 13; // Нет привязки к сетевому району. Оправка отменена!
                        dataTableDamage.Rows[i]["isSendSiteMe"] = 13;
                        continue;
                    }
                    // если список абонентов пустой, то нет отправки
                    int tp_total = 0;
                    if ((bool)dtSetting.Rows[0]["SendNullListAbonent"])
                    {
                        tp_total = Convert.ToInt32(dataTableDamage.Rows[i]["tp_total"]);
                        if (tp_total == 0)
                        {
                            objectFromServer.result = 11; // Количество точек присоединения равно нулю. Оправка отменена!
                            dataTableDamage.Rows[i]["isSendSiteMe"] = 11;
                            continue;
                        }
                    }
                    // если есть хотя бы один правильный характер повреждения, то отправляем
                    // значение должжно быть не пустым
                    // КЛ, ВЛ, КВЛ, ТП, РП, ПС
                    if ((bool)dtSetting.Rows[0]["SendCorrectDamage"])
                    {
                        string list_obj_type = dataTableDamage.Rows[i]["list_obj_type"].ToString();
                        if (list_obj_type.Length == 0)
                        {
                            objectFromServer.result = 12; // Список характеров повреждения не для отправки. Оправка отменена!
                            dataTableDamage.Rows[i]["isSendSiteMe"] = 12;
                            continue;
                        }
                    }
                   dt_recover = dataTableDamage.Rows[i]["dt_recover"].ToString();
                    // проверить вхождение сетевых организаций в список минэнерго
                    string tso_neigh_list = GetTSONeighList(dataTableDamage.Rows[i]["tso_neigh_list"].ToString());
                    postResult.body.data.Add(new Datum
                    {
                        tso_id = tso_id,
                        num = "",
                        name = dataTableDamage.Rows[i]["name"].ToString(),
                        obj_type = dataTableDamage.Rows[i]["obj_type"].ToString(),
                        obj_name = dataTableDamage.Rows[i]["obj_name"].ToString(),
                        voltage_lvl = dataTableDamage.Rows[i]["voltage_lvl"].ToString(),
                        dt_start = dataTableDamage.Rows[i]["dt_start"].ToString(),
                        dt_recover = DATA_TYPE == "8.1_online" ? dt_recover : null,
                        dt_offset = "4", // Смещение от UTC в часах
                        deenergized_type = "В",
                        duration = dt_recover == "" ? "" : dataTableDamage.Rows[i]["duration"].ToString(),
                        apv = "2",
                        avr = "2",
                        feed_objects_list = dataTableDamage.Rows[i]["feed_objects_list"].ToString(),
                        consumers_fully_deenergized = "",
                        consumers_partial_deenergized = dataTableDamage.Rows[i]["consumers_partial_deenergized"].ToString(),
                        tp_total = tp_total.ToString(),
                        tp_cat_1 = dataTableDamage.Rows[i]["tp_cat_1"].ToString(),
                        tp_cat_2 = dataTableDamage.Rows[i]["tp_cat_2"].ToString(),
                        tp_cat_3 = dataTableDamage.Rows[i]["tp_cat_3"].ToString(),
                        tp_vn = dataTableDamage.Rows[i]["tp_vn"].ToString(),
                        tp_sn1 = dataTableDamage.Rows[i]["tp_sn1"].ToString(),
                        tp_sn2 = dataTableDamage.Rows[i]["tp_sn2"].ToString(),
                        tp_nn = dataTableDamage.Rows[i]["tp_nn"].ToString(),
                        tp_neigh_org = dataTableDamage.Rows[i]["tp_neigh_org"].ToString(),
                        power_total = dataTableDamage.Rows[i]["power_total"].ToString(),
                        tso_neigh_list = tso_neigh_list,
                        log_info = DATA_TYPE == "8.1_online" ? dataTableDamage.Rows[i]["log_info"].ToString() : null,
                        org_reason_code = dataTableDamage.Rows[i]["org_reason_code"].ToString(),
                        tech_reason_code = dataTableDamage.Rows[i]["tech_reason_code"].ToString(),
                        accounting_in_indicators = dataTableDamage.Rows[i]["accounting_in_indicators"].ToString()
                    });
                }
                // отправка данных
                //if (1 != 1)
                if (postResult.body.data.Count != 0)
                {
                    string serialized = JsonConvert.SerializeObject(postResult);
                    UTF8Encoding encoding = new UTF8Encoding(false);
                    var json = encoding.GetBytes(serialized);
                    try
                    {
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                        request.Method = WebRequestMethods.Http.Post;

                        request.ContentLength = json.Length;
                        request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;
                        // прокся по умолчанию
                        if (Proxy == "")
                        {
                            request.Proxy = WebRequest.GetSystemWebProxy();
                            request.Proxy.Credentials = CredentialCache.DefaultCredentials;
                        }
                        else
                        {
                            WebProxy myProxy = new WebProxy
                            {
                                Address = new Uri($"http://{Proxy}/"),
                                Credentials = new NetworkCredential(ProxyUser, ProxyPwd)
                            };
                            request.Proxy = myProxy;

                        }
                        //request.Credentials = CredentialCache.DefaultCredentials;
                        // отправляем данные
                        using (Stream streamWriter = request.GetRequestStream())
                        {
                            streamWriter.Write(json, 0, json.Length);
                        }
                        // принимаем ответ - результат
                        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                        {
                            using (StreamReader myStreamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                            {
                                // var objectFromServer = JsonConvert.DeserializeObject<GetResult>(myStreamReader.ReadToEnd());
                                // var objectFromServer = JsonConvert.DeserializeObject(myStreamReader.ReadToEnd());
                                objectFromServer = JsonConvert.DeserializeObject<GetResult>(myStreamReader.ReadToEnd());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // ошибка внутренняя - системная не от минэнерго
                        objectFromServer.result = 0;
                        objectFromServer.error = new Error()
                        {
                            code = "-1",
                            details = ex.ToString()
                        };
                        Log.Write(LogLevel.Error, "StatementsForME", "StatementsForME", "LoadData - отправка данных", ex.Message, null);
                    }
                }
            }
            // результат отправки данных
            if (objectFromServer != null)
            {
                int[] trueResult = { 10, 7, 11, 12, 13 };
                int[] trueErrorCode = { 1, 2, 3, 4, 5, 6, 7, 8};
                if ((int)objectFromServer.result == 1)
                    resultat = 3;  // "Отправлено";
                else if (Array.IndexOf(trueResult, (int)objectFromServer.result) > 0)
                    resultat = (int)objectFromServer.result;
                else if ((int)objectFromServer.result == 0) // 	0 - неуспешно
                {
                    // if (objectFromServer.error != null && objectFromServer.error.code == "4")
                    if (objectFromServer.error != null && Array.IndexOf(trueErrorCode, Convert.ToInt32(objectFromServer.error.code)) > 0)
                    {
                        resultat = 20 + Convert.ToInt32(objectFromServer.error.code); // ошибка авторизации
                        Log.Write(LogLevel.Error, "StatementsForME", "StatementsForME", "LoadData - отправка данных", objectFromServer.error.details, null);
                    }
                    else
                        resultat = 5; // "Ошибка отправки"
                }
                else
                    resultat = 5; // "Ошибка отправки"

                LibraryTSQL.SqlDataCommand cTSQL = new LibraryTSQL.SqlDataCommand(SqlSettings);

                int[] trueResult2 = { 11, 12, 13 };
                for (int i = 0; i < dataTableDamage.Rows.Count; i++)
                {
                    if (Array.IndexOf(trueResult2, (int)objectFromServer.result) > 0)
                    //if ((int)dataTableDamage.Rows[i]["isSendSiteMe"] == 11 || (int)dataTableDamage.Rows[i]["isSendSiteMe"] == 12 || (int)dataTableDamage.Rows[i]["isSendSiteMe"] == 13)
                            cTSQL.UpdateSqlData(dataTableDamage, "[isSendSiteMe] = " + dataTableDamage.Rows[i]["isSendSiteMe"], " [id] = " + dataTableDamage.Rows[i]["id"].ToString());
                    else
                        cTSQL.UpdateSqlData(dataTableDamage, "[isSendSiteMe] = " + resultat, " [id] = " + dataTableDamage.Rows[i]["id"].ToString());
                }
            }
        }
        /// <summary>
        /// 1. должен вернуться список, скорректированный со списком минэнерго
        /// 2. проверим корректность наименований смежных сетевх организаций
        /// </summary>
        private string GetTSONeighList(string listNetOrg)
        {
            string resultat = "";
            if (listNetOrg.Length == 0) return resultat;
            if (listTSO.Count() == 0) return resultat;

            foreach (var el in listNetOrg.Split(';').ToList())
            {
                string element = el.Trim();
                if (listTSO.Find((s) => s == element) != null)
                    if (listTSO.Find((s) => s == element).Count() > 0)
                    {
                        resultat = resultat + element + ";";
                    }
            }
            if (resultat != "") resultat = resultat.Remove(resultat.Length - 1);
            return resultat;
        }

    }
}