using DataSql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Data.SqlClient;
using Logger;

namespace ExportToPostGIS.SmartCity
{
    public partial class SmartCity
    {
        /// <summary>
        /// интервал выбираемых ремонтных работ поумолчанию
        /// </summary>
        private const int IntervalRepair = 8;

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
                    //// считать надо конфигурационный файл
                    setting = new Settings();
                    setting.SqlSettings = this.SqlSettings;
                    setting.Parametr = "SendPlannedCMR";

                    int sInterval = Convert.ToInt32(setting.GetAttribute("Interval", "int", "Shedule"));
                    if (sInterval != 0)
                        Interval = sInterval;
                    else
                        Interval = IntervalRepair;
                    DataBeg = DateTime.Today.Date;
                    DataEnd = DateTime.Today.Date.AddDays(Interval).AddMilliseconds(-1);

                    IntervalShedule = Convert.ToInt32(setting.GetAttribute("Period", "int", "Shedule"));
                    StartShedule = Convert.ToDateTime(setting.GetAttribute("Start", "string", "Shedule"));

                    Proxy = setting.GetAttribute("Proxy", "string").ToString();
                    ProxyUser = setting.GetAttribute("ProxyUser", "string").ToString();
                    ProxyPwd = setting.GetAttribute("ProxyPwd", "string").ToString();

                    Url = setting.GetAttribute("Url", "string", "User").ToString();
                    Login = setting.GetAttribute("Login", "string", "User").ToString();
                    Pwd = setting.GetAttribute("Pwd", "string", "User").ToString();
                }
            }
        }
        private SQLSettings _sqlSettings;
        
        private Settings setting { get; set; }
        public int IntervalShedule { get; set; }
        public DateTime StartShedule { get; set; }
        // public DateTime DataStartShedule { get; set; }

        private const string strApiV1 = "/api/v1/";

        /// <summary>
        /// таблица данных
        /// </summary>
        DataTable dataTableDamage;
        public string Url  { get; private set; } = $"https://xn--d1ab1b.xn--73-6kc3bbqg7ac.xn--p1ai";//$"https://едс.контакт73.рф/";
                                                                              // string Url = $"https://ulyanovsk-eds.aisgorod.ru";
        public string Login { get; private set; } = $"a.kirillov";
        public string Pwd { get; private set; } = $"Ulges73!";

        public string Proxy { get; private set; } = "";
        public string ProxyUser { get; private set; }
        public string ProxyPwd { get; private set; }
        private string access_token;


        // $"https://test-crm.aisgorod.ru/swagger/index.html"

        // конфигурационные данные
        public DateTime DataBeg { get; set; } 
        public DateTime DataEnd { get; set; }
        public int Interval { get; set; } 
        
        public string query { get; set; } = $"ExportToPostGIS.SmartCity.RequestForRepairDaily.sql";
        public object INN { get; set; } = 7303003290;
        public object KPP { get; set; } = 732501001;
        public string ACCESS_TOKEN
        {
            get
            {
                if (access_token == null || access_token == "")
                {
                    GetResultToken ResultFromServer = GetToken();
                    if (ResultFromServer != null)
                    {
                        if (ResultFromServer.result == 1)
                        {
                            access_token = ResultFromServer.data.accessToken;
                        }
                    }
                    else
                        Log.Write(LogLevel.Error, "SmartCityIntegration", "SmartCityIntegration", "Create ACCESS_TOKEN", "Не удалось получить токен из ЦУГ", null);
                }
                return access_token;
            }
            set
            {
                access_token = value;

            }
        }

        public string queryCrash { get; set; } = $"ExportToPostGIS.SmartCity.RequestForRepairDailyCrash.sql";
        public string queryPlanned { get; set; } = $"ExportToPostGIS.SmartCity.RequestForRepairDailyPlanned.sql";
        
        public int idDivision { get; set; } = 920;

        /// <summary>
        /// получениие данных
        /// </summary>
        public DataTable LoadData(string query)
        {
            
            return LoadData(DataBeg, DataEnd, query);
        }
        public DataTable LoadData(DateTime dateBeg, DateTime dateEnd, string query)
        {
            DataTable dt = new DataTable();
            // заберемплановые работы
            using (SqlConnection sqlConnection = new SqlConnection(this.SqlSettings.GetConnectionString() + ";Connection Timeout=1000"))
            {
                sqlConnection.Open();
                using (SqlTransaction sqlTransaction = sqlConnection.BeginTransaction())
                {
                    try
                    {
                        string strSelect = Library.ResourceReader.GetStringAssembly(typeof(Program).Assembly, query);

                        using (SqlCommand sqlCommand = new SqlCommand(strSelect, sqlConnection))
                        {
                            sqlCommand.CommandTimeout = 0;
                            sqlCommand.Transaction = sqlTransaction;
                            if (DataBeg == null)
                                sqlCommand.Parameters.Add("dateBegin", SqlDbType.DateTime).Value = DBNull.Value;
                            else
                                sqlCommand.Parameters.Add("dateBegin", SqlDbType.DateTime).Value = dateBeg;
                            if (DataEnd == null)
                                sqlCommand.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = DBNull.Value;
                            else
                                sqlCommand.Parameters.Add("dateEnd", SqlDbType.DateTime).Value = dateEnd;
                            sqlCommand.Parameters.Add("idDivision", SqlDbType.Int).Value = idDivision;
                            //sqlCommand.Parameters.Add("periodToBeginDay", SqlDbType.Int).Value = DBNull.Value;
                            new SqlDataAdapter(sqlCommand).Fill(dt);
                        }

                        sqlTransaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback();
                        Log.Write(LogLevel.Error, "SmartCityIntegration", "SmartCityIntegration", "LoadData MSSQL", ex.Message, null);
                    }
                }
            }
            return dt;
        }
        public DataTable LoadData()
        {
            return LoadData(DataBeg, DataEnd, query);
        }
        /// <summary>
        /// Получение аварийных работ
        /// </summary>
        /// <returns></returns>
        public DataTable LoadDataCrash()
        {
            return LoadData(DataBeg, DataEnd, queryCrash);
        }
        /// <summary>
        /// Получение плановых работ
        /// </summary>
        /// <returns></returns>
        public DataTable LoadDataPlanned()
        {
            return LoadData(DataBeg, DataEnd, queryPlanned);
        }

        /// <summary>
        /// отправка/сохранение/ данных
        /// </summary>
        public void Send()
        {
            if (ACCESS_TOKEN == "")
            {
                Log.Write(LogLevel.Error, "SmartCityIntegration", "SmartCityIntegration", "Send", "Не удалось получить токен из ЦУГ", null);
                return;
            }
            //1. Получить по реквизитам текущий ид организации (из ЦУГ)
            var OrganizationCurrent = GetDateWhere(ACCESS_TOKEN, new Organizations(), $"Organizations?Inn={INN}&Kpp={KPP}");
            //2. Сформируем справочники (из ЦУГ)

            //3. Загрузить плановые и аварийные работы
            dataTableDamage = LoadData();

  
            //4. отправим данные
            //(или новое отключение, или обновление отключения)
            //проверить логи формирования заявок на аварию и плановую работу
        }

        public void Integration()
        {
            //int result = 0;
            //DataTable dtSetting = References.SettingsTable.GetSettingSmartCity(SqlSettings);

            //if (dtSetting.Rows.Count == 0) { result = 10; } // настроек нет
            //if ((bool)dtSetting.Rows[0]["IntegrationSmartCity"] != true) { result = 7; } // запрет отправки с нашей стороны
            //                                                                                // логинимся
            //string login = dtSetting.Rows[0]["Login"].ToString();
            //string pwd = dtSetting.Rows[0]["Pwd"].ToString();
            //string url = dtSetting.Rows[0]["URL"].ToString();
            ////
            //string Proxy = dtSetting.Rows[0]["Proxy"].ToString();
            //string ProxyUser = dtSetting.Rows[0]["ProxyUser"].ToString();
            //string ProxyPwd = dtSetting.Rows[0]["ProxyPwd"].ToString();

            if (ACCESS_TOKEN == "") return;
            // Получение списка организаций
            var Organizations1 = GetDate(ACCESS_TOKEN, new Organizations());
            // Получение организации по ИНН
            var Organizations2 = GetDateWhere(ACCESS_TOKEN, new Organizations(), $"Organizations?Inn=7303003290&Kpp=732501001");


            //
            //var ObjectToOrganizationLinks1 = GetDate(ACCESS_TOKEN, new ObjectToOrganizationLinks());
            // получение всех отключений
            var Shutdowns1 = GetDateWhere(ACCESS_TOKEN, new ShutdownsGetDTO(), $"Shutdowns");
            // Получение отключений по ид организации
            var Shutdowns2 = GetDateWhere(ACCESS_TOKEN, new ShutdownsGetDTO(), $"Shutdowns?OrganizationId=10");
            var ShutdownCauses1 = GetDate(ACCESS_TOKEN, new ShutdownCauses());
            var WorkTypes1 = GetDate(ACCESS_TOKEN, new WorkTypes());
            var WorkKinds1 = GetDate(ACCESS_TOKEN, new WorkKinds());

            // проверяем отключения
            string Id = "19";
            var Shutdowns4 = GetDateWhere(ACCESS_TOKEN, new ShutdownsGetDTO(), $"Shutdowns/19");
            var ShutdownsAddressLinks1 = GetDateWhere(ACCESS_TOKEN, new ShutdownsAddressLinkId(), $"Shutdowns/{Id}/AddressLinks");
            var ShutdownsAddresses2 = GetDateWhere(ACCESS_TOKEN, new ShutdownsAddressesId(), $"Shutdowns/{Id}/Addresses");


            //var ConnectedServices1 =  GetDate(ACCESS_TOKEN, new ConnectedServices());
            //var Tickets1 = GetDate(ACCESS_TOKEN, new Tickets());
            //

        }

        public GetResultP<T> GetDateWhere<T>(string ACCESS_TOKEN, T type, string Where)
        {
            GetResultP<T> ResultFromServer = new GetResultP<T>();
            string UrlAdd = String.Concat(strApiV1, $"{Where}");
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Concat(Url, UrlAdd));
                request.Accept = "text/plain";
                request.ContentType = "application/json";
                request.Method = "GET";
                request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;
                request.Headers.Add("Authorization", $"Bearer  {ACCESS_TOKEN}");

                // прокся по умолчанию
                if (Proxy == String.Empty)
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
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader myStreamReader = new StreamReader(response.GetResponseStream()))
                    {
                        ResultFromServer.status = 1;
                        ResultFromServer.result = new Status()
                        {
                            code = ((int)response.StatusCode).ToString(),
                            details = response.StatusCode.ToString()
                        };
                        var settingsSerialize = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore,
                            DateParseHandling = DateParseHandling.None
                        };
                        string str = myStreamReader.ReadToEnd();
                        if (str.Substring(0, 1) != "[") // если возвращается не список
                            str = $"[{str }]";

                        var result = JsonConvert.DeserializeObject<List<T>>(str, settingsSerialize);
                        ResultFromServer.data = result;
                    }
                }
            }
            catch (Exception ex)
            {
                ResultFromServer.status = -1;
                ResultFromServer.result = new Status()
                {
                    code = "0",
                    details = ex.Message,
                    body = ex.ToString()
                };
            }

            return ResultFromServer;
        }
        /// <summary>
        /// получение данных (списков)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ACCESS_TOKEN"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public GetResultP<T> GetDate<T>(string ACCESS_TOKEN, T type)
        {
            GetResultP<T> ResultFromServer = new GetResultP<T>();
            string UrlAdd = String.Concat(strApiV1, type.GetType().Name);
            //string UrlAdd = "/api/Organizations";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Concat(Url, UrlAdd));
                request.Accept = "text/plain";
                request.ContentType = "application/json";
                request.Method = "GET";
                request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;
                request.Headers.Add("Authorization", $"Bearer  {ACCESS_TOKEN}");

                // прокся по умолчанию
                if (Proxy == String.Empty)
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
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (StreamReader myStreamReader = new StreamReader(response.GetResponseStream()))
                    {
                        ResultFromServer.status = 1;
                        ResultFromServer.result = new Status()
                        {
                            code = ((int)response.StatusCode).ToString(),
                            details = response.StatusCode.ToString()
                        };
                        var settingsSerialize = new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            MissingMemberHandling = MissingMemberHandling.Ignore,
                            DateParseHandling = DateParseHandling.None
                        };
                        string str = myStreamReader.ReadToEnd();
                        if (str.Substring(0, 1) != "[") // если возвращается не список
                            str = $"[{str }]";
                        var result = JsonConvert.DeserializeObject<List<T>>(str, settingsSerialize);
                        ResultFromServer.data = result;
                    }
                }
            }
            catch (Exception ex)
            {
                ResultFromServer.status = -1;
                ResultFromServer.result = new Status()
                {
                    code = "0",
                    details = ex.Message,
                    body = ex.ToString()
                };
            }
            return ResultFromServer;
        }
        /// <summary>
        /// Получение токена авторизации
        /// POST  /api/v1/token      
        /// </summary>
        /// <returns></returns>
        public GetResultToken GetToken()
        {
            GetResultToken ResultFromServer = new GetResultToken();
            Authentication authentication = new Authentication() { UserName = this.Login, Password = this.Pwd };
            string serialized = JsonConvert.SerializeObject(authentication);
            string UrlToken = $"{strApiV1}token";
            try
            {
                // отправляем данные
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Concat(Url, UrlToken));
                request.Accept = "text/plain";
                request.ContentType = "application/json";
                request.Method = "POST";
                request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;
                // прокся по умолчанию
                if (Proxy == String.Empty)
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
                request.ContentLength = serialized.Length;

                // отправляю данные на сервер
                UTF8Encoding encoding = new UTF8Encoding(false);
                var json = encoding.GetBytes(serialized);
                using (Stream streamWriter = request.GetRequestStream())
                {
                    streamWriter.Write(json, 0, json.Length);
                }

                // принимаем ответ - результат
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (StreamReader myStreamReader = new StreamReader(response.GetResponseStream()))
                        {
                            ResultFromServer.result = 1;
                            ResultFromServer.status = new Status()
                            {
                                code = ((int)response.StatusCode).ToString(),
                                details = response.StatusCode.ToString()
                            };
                            //var objectFromServer = myStreamReader.ReadToEnd();
                            ResultFromServer.data = JsonConvert.DeserializeObject<Token>(myStreamReader.ReadToEnd());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ResultFromServer.result = -1;
                ResultFromServer.status = new Status()
                {
                    code = "0",
                    details = ex.Message,
                    body = ex.ToString()
                };
            }

            return ResultFromServer;
        }
        /// <summary>
        /// отправка данных в ЦУГ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ACCESS_TOKEN"></param>
        /// <param name="postData"></param>
        /// <param name="Where"></param>
        public GetResultP<T> PostResult<T>(string ACCESS_TOKEN, T postData, string Where)
        {
            GetResult objectFromServer = new GetResult();
            GetResultP<T> ResultFromServer = new GetResultP<T>();
            string UrlAdd = String.Concat(strApiV1, $"{Where}");

            string serialized = JsonConvert.SerializeObject(postData);
            byte[] byteArray = Encoding.UTF8.GetBytes(serialized);

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Concat(Url, UrlAdd));
                request.Accept = "text/plain";
                request.ContentType = "application/json";
                request.Method = "POST";
                request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;
                request.Headers.Add("Authorization", $"Bearer  {ACCESS_TOKEN}");
                request.ContentLength = byteArray.Length;

                // прокся по умолчанию
                if (Proxy == String.Empty)
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
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                var response = (HttpWebResponse)request.GetResponse();
                string StatusDescription = (((HttpWebResponse)response).StatusDescription);

                string responseFromServer;
                using (dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    responseFromServer = reader.ReadToEnd();
                }
                response.Close();
                // Надо распарсить возвращаемый текст для получения Id Shutdowns (отключения)
                // пример: Отключение #23 успешно создано
                string subStr = responseFromServer.Substring(responseFromServer.IndexOf("#"));
                int idShutdowns = Convert.ToInt32(subStr.Substring(1, subStr.IndexOf(" ")).Trim());

                ResultFromServer.status = 1;
                ResultFromServer.result = new Status()
                {
                    code = idShutdowns.ToString(),
                    details = StatusDescription,
                    body = responseFromServer
                };

                //// отправляем данные
                //using (Stream streamWriter = request.GetRequestStream())
                //{
                //    streamWriter.Write(byteArray, 0, byteArray.Length);
                //}
                //// принимаем ответ - результат
                //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                //{

                //    using (StreamReader myStreamReader = new StreamReader(response.GetResponseStream()))// , Encoding.UTF8
                //    {
                //        objectFromServer = JsonConvert.DeserializeObject<GetResult>(myStreamReader.ReadToEnd());
                //    }
                //}

            }
            catch (Exception ex)
            {
                ResultFromServer.status = -1;
                ResultFromServer.result = new Status()
                {
                    code = "0",
                    details = ex.Message,
                    body = ex.ToString()
                };
            }

            return ResultFromServer;
        }
        /// <summary>
        /// отправка скорректированных данных в ЦУГ
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ACCESS_TOKEN"></param>
        /// <param name="postData"></param>
        /// <param name="Where"></param>
        public GetResultP<T> PatchResult<T>(string ACCESS_TOKEN, T postData, string Where)
        {
            GetResult objectFromServer = new GetResult();
            GetResultP<T> ResultFromServer = new GetResultP<T>();
            string UrlAdd = String.Concat(strApiV1, $"{Where}");

            string serialized = JsonConvert.SerializeObject(postData);
            byte[] byteArray = Encoding.UTF8.GetBytes(serialized);

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Concat(Url, UrlAdd));
                request.Accept = "text/plain";
                request.ContentType = "application/json";
                request.Method = "PATCH";
                request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;
                request.Headers.Add("Authorization", $"Bearer  {ACCESS_TOKEN}");
                request.ContentLength = byteArray.Length;

                // прокся по умолчанию
                if (Proxy == String.Empty)
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
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                var response = (HttpWebResponse)request.GetResponse();
                string StatusDescription = (((HttpWebResponse)response).StatusDescription);

                string responseFromServer;
                using (dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    responseFromServer = reader.ReadToEnd();
                }
                response.Close();

                ResultFromServer.status = 1;
                ResultFromServer.result = new Status()
                {
                    code = "",
                    details = StatusDescription,
                    body = responseFromServer
                };


            }
            catch (Exception ex)
            {
                ResultFromServer.status = -1;
                ResultFromServer.result = new Status()
                {
                    code = "0",
                    details = ex.Message,
                    body = ex.ToString()
                };
            }

            return ResultFromServer;
        }


    }

}
