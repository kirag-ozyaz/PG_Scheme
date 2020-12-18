using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
/// <summary>
/// отсылка данных с помощью сURL
/// </summary>
public static class CURLProcessUpLoadToURL
{
    /// <summary>
    /// Отсылка данных используя протокол ftp
    /// (приложение cUrl)
    /// </summary>
    public static void StartFTP(string pathCURL, string fTPName, string user, string pwd, string fullFileName, string proxy, string proxyUser, string proxyPwd)
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

    public static string StartHTTP(string pathCURL, string HTTPName, string json, string proxy, string proxyUser, string proxyPwd)
    {
        //    \\ULGES - FS\software\Ulges\EIS\Plugins\curl.exe
        //  - o result.data
        //  - k
        //  - U ulges\ftp_user: f1le - tp
        //  - x ulges - proxy:8080
        //  - H "Content-Type: application/json"
        //  - X POST
        //  - d "{\"app\":\"nadezhnost\",\"app_ver\":\"1256\",\"body\":{\"auth\":{\"login\":\"vasinee\",\"pwd\":\"IPay31k\"},\"type\":\"adjacentTso\",\"data\":[\"2232\"]}}"
        //https://nadezhnost.minenergo.gov.ru/integration/

        using (Process process = new Process())
        {
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.RedirectStandardError = true;
            //process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.FileName = pathCURL;
            process.StartInfo.WorkingDirectory = Path.GetDirectoryName(pathCURL);
            process.StartInfo.Arguments =
                " -k"
                + (string.IsNullOrEmpty(proxyUser) ? "" : string.Format(" -U {0}:{1} ", proxyUser, proxyPwd))
                + (string.IsNullOrEmpty(proxy) ? "" : string.Format(" -x {0} ", proxy))
                + " -H \"Content-Type: application/json\""
                + " -X POST "
                + string.Format(" -d \"{0}\" ", new object[] { json.Replace("\"", (char)92 + "\"") })
                + " " + HTTPName;
            
            process.Start();


            var reader = process.StandardOutput;
            string output = reader.ReadToEnd();

            return output;

        }
    
    }
}
