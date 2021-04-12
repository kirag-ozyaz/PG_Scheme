using DataSql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace ExportToPostGIS.SmartCity
{
    public partial class SmartCity
    {
        public SQLSettings SqlSettings { get; set; }

        private const string strApiV1 = "/api/v1/";

        /// <summary>
        /// таблица данных
        /// </summary>
        DataTable dataTableDamage;
        string Url = $"https://xn--d1ab1b.xn--73-6kc3bbqg7ac.xn--p1ai";//$"https://едс.контакт73.рф/";
        // string Url = $"https://ulyanovsk-eds.aisgorod.ru";
        string Login = $"a.kirillov";
        string Pwd = $"Ulges73!";
        private string Proxy = "";
        private string ProxyUser;
        private string ProxyPwd;

        // $"https://test-crm.aisgorod.ru/swagger/index.html"

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


            string ACCESS_TOKEN = "";
            GetResultToken ResultFromServer = GetToken();
            if (ResultFromServer != null)
            {
                if (ResultFromServer.result == 1)
                {
                    ACCESS_TOKEN = ResultFromServer.data.accessToken;
                }
            }
            if (ACCESS_TOKEN == "") return;
            // Получение списка организаций
            var Organizations1 = GetDate(ACCESS_TOKEN, new Organizations());
            ////// Получение организации по ИНН
            var Organizations2 = GetDateWhere(ACCESS_TOKEN, new Organizations(), $"Organizations?Inn=7303003290&Kpp=732501001");

            
            //
            //var ObjectToOrganizationLinks1 = GetDate(ACCESS_TOKEN, new ObjectToOrganizationLinks());
            // получение всех отключений
            var Shutdowns1 = GetDate(ACCESS_TOKEN, new Shutdowns());
            // Получение отключений по ид организации
            var Shutdowns2 = GetDateWhere(ACCESS_TOKEN, new Shutdowns(), $"Shutdowns?OrganizationId=10");
            var ShutdownCauses1 = GetDate(ACCESS_TOKEN, new ShutdownCauses());
            var WorkTypes1 = GetDate(ACCESS_TOKEN, new WorkTypes());
            var WorkKinds1 = GetDate(ACCESS_TOKEN, new WorkKinds());

            // проверяем отключения
            string Id = "19";
            var Shutdowns4 = GetDateWhere(ACCESS_TOKEN, new ShutdownsId(), $"Shutdowns/19");
            var ShutdownsAddressLinks1 = GetDateWhere(ACCESS_TOKEN, new ShutdownsAddressLinkId(), $"Shutdowns/{Id}/AddressLinks");
            var ShutdownsAddresses2 = GetDateWhere(ACCESS_TOKEN, new ShutdownsAddressesId(), $"Shutdowns/{Id}/Addresses");


            //var ConnectedServices1 =  GetDate(ACCESS_TOKEN, new ConnectedServices());
            //var Tickets1 = GetDate(ACCESS_TOKEN, new Tickets());
            //

        }

        public GetResultP<T> GetDateWhere<T>(string ACCESS_TOKEN, T type, string Where)
        {
            GetResultP<T> ResultFromServer = new GetResultP<T>();
            string UrlAdd = String.Concat(strApiV1,  $"{Where}");
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
                //WebResponse response1 = request.GetResponse();
                //using (Stream stream = response1.GetResponseStream())
                //{
                //    using (StreamReader reader = new StreamReader(stream))
                //    {
                //    }
                //}
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader myStreamReader = new StreamReader(stream))
                        {
                            var str = myStreamReader.ReadToEnd();

                            ResultFromServer.result = 1;
                            ResultFromServer.status = new Status()
                            {
                                code = ((int)response.StatusCode).ToString(),
                                details = response.StatusCode.ToString()
                            };
                            // var result = JsonConvert.DeserializeObject<List<T>>(myStreamReader.ReadToEnd());
                            var settings = new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore,
                                MissingMemberHandling = MissingMemberHandling.Ignore,
                                DateParseHandling = DateParseHandling.None
                            };

                            var result = JsonConvert.DeserializeObject<List<T>>(str, settings);
                            ResultFromServer.data = result;
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
                //WebResponse response1 = request.GetResponse();
                //using (Stream stream = response1.GetResponseStream())
                //{
                //    using (StreamReader reader = new StreamReader(stream))
                //    {
                //    }
                //}
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        using (StreamReader myStreamReader = new StreamReader(stream))
                        {
                            var str = myStreamReader.ReadToEnd();

                            ResultFromServer.result = 1;
                            ResultFromServer.status = new Status()
                            {
                                code = ((int)response.StatusCode).ToString(),
                                details = response.StatusCode.ToString()
                            };
                            // var result = JsonConvert.DeserializeObject<List<T>>(myStreamReader.ReadToEnd());
                            var settings = new JsonSerializerSettings
                            {
                                NullValueHandling = NullValueHandling.Ignore,
                                MissingMemberHandling = MissingMemberHandling.Ignore,
                                DateParseHandling = DateParseHandling.None
                            };

                            var result = JsonConvert.DeserializeObject<List<T>>(str, settings);
                            ResultFromServer.data = result;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //if (ex.GetType() == typeof(System.Net.WebException))
                //{
                    //var response = ((System.Net.WebException)ex).Response;
                    //using (StreamReader myStreamReader = new StreamReader(response.GetResponseStream()))
                    //{
                        ResultFromServer.result = -1;
                        ResultFromServer.status = new Status()
                        {
                            code = "0",
                            details = ex.Message,
                            body = ex.ToString()
                        };
                    //}
                //}
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
                if (ex.GetType() == typeof(System.Net.WebException))
                {
                    var response = ((System.Net.WebException)ex).Response;
                    using (StreamReader myStreamReader = new StreamReader(response.GetResponseStream()))
                    {
                        ResultFromServer.result = -1;
                        ResultFromServer.status = new Status()
                        {
                            code = ((int)((System.Net.HttpWebResponse)response).StatusCode).ToString(),
                            details = ex.Message,
                            body = myStreamReader.ReadToEnd()
                        };
                    }
                }
            }

            return ResultFromServer;
        }
    }
   
}
