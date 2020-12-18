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
    public class SmartCity
    {
        public SQLSettings SqlSettings { get; set; }
        /// <summary>
        /// таблица данных
        /// </summary>
        DataTable dataTableDamage;
        string Url = $"http://xn--d1ab1b.xn--73-6kc3bbqg7ac.xn--p1ai";//$"http://едс.контакт73.рф/";
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
            // Получим список организаций
            string UrlToken = "/api/Tickets"; // Organizations
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Concat(Url, UrlToken));
                request.Accept = "application /json";
                //request.ContentType = "text/json";
                request.Method = "GET";
                request.AuthenticationLevel = System.Net.Security.AuthenticationLevel.None;
                request.Headers.Add("Authorization", $"Bearer  {ACCESS_TOKEN}");
                //request.Headers.Add("Authorization", ACCESS_TOKEN);

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
                        //List<OrganizationItem> organizations = JsonConvert.DeserializeObject<List<OrganizationItem>>(myStreamReader.ReadToEnd()) as List<OrganizationItem>;
                        // var organizations = JsonConvert.DeserializeObject<List<Organization>>(myStreamReader.ReadToEnd());
                        var tickets = JsonConvert.DeserializeObject<List<Tickets>>(myStreamReader.ReadToEnd());
                    }
                }
             }
            catch //(Exception ex)
            {

            }

            var ttt = GetDate(ACCESS_TOKEN, new Organizations());
            // var ttt = GetDate(ACCESS_TOKEN, typeof( Organizations));
        }

        public GetResultP<T> GetDate<T>(string ACCESS_TOKEN, T type)
        {
            GetResultP<T> ResultFromServer = new GetResultP<T>();
            string UrlAdd = String.Concat("/api/", type.GetType().Name);
            //string UrlAdd = "/api/Organizations";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Concat(Url, UrlAdd));
                request.Accept = "application /json";
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
                        ResultFromServer.result = 1;
                        ResultFromServer.status = new Status()
                        {
                            code = ((int)response.StatusCode).ToString(),
                            details = response.StatusCode.ToString()
                        };
                        //List<OrganizationItem> organizations = JsonConvert.DeserializeObject<List<OrganizationItem>>(myStreamReader.ReadToEnd()) as List<OrganizationItem>;
                        var result = JsonConvert.DeserializeObject<List<T>>(myStreamReader.ReadToEnd());
                        ResultFromServer.data = result;
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
        /// <summary>
        /// Получение токена авторизации
        /// POST     ​
        /// /api/v1/token      
        /// </summary>
        /// <returns></returns>
        public GetResultToken GetToken()
        {
            GetResultToken ResultFromServer = new GetResultToken();
            Authentication authentication = new Authentication() { UserName = this.Login, Password = this.Pwd };
            string serialized = JsonConvert.SerializeObject(authentication);
            string UrlToken = "/api/token";
            try
            {
                // отправляем данные
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Concat(Url, UrlToken));
                request.Accept = "application/json";
                request.ContentType = "text/json";
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
    public class Authentication
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    public class Status
    {
        public string code { get; set; }
        public string details { get; set; }
        public string body { get; set; }
    }
    public class GetResult
    {
        public int result { get; set; }
        public Status status { get; set; }
    }
    public class GetResultToken : GetResult
    {
        public Token data { get; set; }
    }
    public class Token
    {
        public string accessToken { get; set; }
        public string validTo { get; set; }
    }
    public class Organizations
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string director { get; set; }
        public string inn { get; set; }
        public string ogrn { get; set; }
        public string kpp { get; set; }
    }

    public class GetResultP<T>
    {
        public int result { get; set; }
        public Status status { get; set; }
        public List<T> data { get; set; }
    }
    
    public class Tickets
    {
        public int id { get; set; }
        public int number { get; set; }
        public string address { get; set; }
        public string ticketStatusName { get; set; }
        public string workTypeName { get; set; }
        public string workKindName { get; set; }
        public string created { get; set; }
        public string performerOrganizationName { get; set; }
    }
}
