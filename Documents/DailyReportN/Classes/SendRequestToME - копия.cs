using DataSql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClassLibrary;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using FormLbr;

public class SendRequestToME
{
    internal static SQLSettings SqlSettings { get; set; }
    internal static int IdDocument = -1;
    static DataTable dataTableDamage; // таблица данных
    static DataTable dataTableTSO; // таблица данных ТСО МЭ


    static DataTable LoadData()
    {
        DataTable dt = new DataTable();
        DataSql.SqlDataConnect sqlDataConnect = new DataSql.SqlDataConnect();
        using (SqlConnection sqlConnection = new SqlConnection(SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ClassLibrary.ResourceReader.GetStringAssembly(typeof(SendRequestToME).Assembly, "DailyReportN.GetTableDamage.sql"), sqlConnection);
                sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                sqlDataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
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
    public static void Send(int idDocument, SQLSettings sqlSettings)
    {
        SqlSettings = sqlSettings;
        IdDocument = idDocument;

        //Get_TSO_Neigh_List();

        CreateJSON();
        //SendJSON();
    }
    public static void Send(SQLSettings sqlSettings)
    {
        SqlSettings = sqlSettings;
        //Get_TSO_Neigh_List();

        CreateJSON();
        //SendJSON();
        // при любой отправке изменить поле isSendSiteMe
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
    }
    #endregion
    //1. "8.1_online" - оперативная информация по форме 8.
    //поэтапное включение подстанций, как делать ???
    private static void CreateJSON(string DATA_TYPE = "8.1_online")
    {
        int resultat = 0; // "Неправильный тип данных"
        dataTableDamage = LoadData();
        dataTableDamage.TableName = "tJ_Damage";
        if (dataTableDamage.Rows.Count == 0)
        {
            // аварийных событий нет
            return;
        }

        DataTable dtSetting = ReferenceTables.SettingsTable.GetSettingMinEnergo(SqlSettings);
        // возвращаемый результат от сервака минэнерго
        GetResult objectFromServer = new GetResult();
        if (dtSetting.Rows.Count == 0) { objectFromServer.result = 10; } // настроек нет
        if ((bool)dtSetting.Rows[0]["SendME"] != true) { objectFromServer.result = 7; } // запрет отправки с нашей стороны
        // логинимся
        string login = dtSetting.Rows[0]["Login"].ToString();
        // string pwd = SecureIt.Расшифровать(dtSetting.Rows[0]["Pwd"].ToString());
        string pwd = dtSetting.Rows[0]["Pwd"].ToString();
        string url = dtSetting.Rows[0]["URL"].ToString();

        // теперь можно отправить данные
        if (objectFromServer.result == 0) // ошибок нет
        {
            // Формируем JSON
            // шапка файла
            PostResult postResult = new PostResult();
            postResult.app = "nadezhnost";
            postResult.app_ver = "1256";
            postResult.body = new Body()
            {
                auth = new Auth()
                {
                    login = login,  
                    pwd = pwd       
                },
                type = DATA_TYPE
            };
            string tso_id = "2232";
            //
            string dt_recover;
            // тело файла
            postResult.body.data = new List<Datum>();
            for (int i = 0; i < dataTableDamage.Rows.Count; i++)
            {
                // проверим отправку документов (по корректности данных)
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
                    // проверить вхождение сетевых организаций в список минэнерго
                    tso_neigh_list = Get_TSO_Neigh_List(dataTableDamage.Rows[i]["tso_neigh_list"].ToString()),
                    log_info = DATA_TYPE == "8.1_online" ? dataTableDamage.Rows[i]["log_info"].ToString() : null,
                    org_reason_code = dataTableDamage.Rows[i]["org_reason_code"].ToString(),
                    tech_reason_code = dataTableDamage.Rows[i]["tech_reason_code"].ToString(),
                    accounting_in_indicators = dataTableDamage.Rows[i]["accounting_in_indicators"].ToString()
                });
            }
            // отправка данных
            //if (1 !=1)
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

                    request.Proxy = WebRequest.GetSystemWebProxy();
                    request.Proxy.Credentials = CredentialCache.DefaultCredentials;
                    request.Credentials = CredentialCache.DefaultCredentials;
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
                catch (Exception e)
                {
                    // ошибка внутренняя - системная не от минэнерго
                    // MessageBox.Show("Ошибка: " + e.ToString());
                    objectFromServer.result = 0;
                    objectFromServer.error = new Error()
                    {
                        code = "-1",
                        details = e.ToString()
                    };
                }
            }
        }
        // результат отправки данных
        if (objectFromServer != null)
        {
            int[] trueResult = { 10, 7, 11, 12 };
            if ((int)objectFromServer.result == 1)
                resultat = 3;  // "Отправлено";
            else if (Array.IndexOf(trueResult, (int)objectFromServer.result) > 0)
                resultat = (int)objectFromServer.result;
            else if ((int)objectFromServer.result == 0)
            {
                if (objectFromServer.error.code == "4")
                    resultat = 24; // ошибка авторизации
                else
                    resultat = 5; // "Ошибка отправки"
            }
            else
                resultat = 5; // "Ошибка отправки"

            SqlDataCommandN dd = new SqlDataCommandN(SqlSettings);
            //if (IdDocument != -1)
            //{
            //    dd.UpdateSqlData(dataTableDamage, "[isSendSiteMe] = " + resultat, " [id] = " + IdDocument);
            //}
            //else
            for (int i = 0; i < dataTableDamage.Rows.Count; i++)
            {
                if ((int)objectFromServer.result == 11 || (int)objectFromServer.result == 12)
                    dd.UpdateSqlData(dataTableDamage, "[isSendSiteMe] = " + dataTableDamage.Rows[i]["isSendSiteMe"], " [id] = " + dataTableDamage.Rows[i]["id"].ToString());
                else
                    dd.UpdateSqlData(dataTableDamage, "[isSendSiteMe] = " + resultat, " [id] = " + dataTableDamage.Rows[i]["id"].ToString());
            }
        }
    }
    /// <summary>
    /// получаем список сетевых организаций из минэнерго
    /// listNetOrg - спсиок сетевых организаций для проверки
    /// должен вернуться список, скорректированный со списком минэнерго
    /// </summary>
    private static string Get_TSO_Neigh_List(string listNetOrg)
    {
        if (listNetOrg.Length == 0) return "";
        dataTableTSO = new DataTable();
        // return список_контор
        return listNetOrg;
    }

    /// метод отправки postResult и получение результата и зминэнерго
    static string SendJSON(PostResult postResult)
    {
        string resultat = "";

        return resultat;
    }
}
