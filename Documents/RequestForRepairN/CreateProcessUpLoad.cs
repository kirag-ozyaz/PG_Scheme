using System;
using System.Diagnostics;
using System.IO;

internal static class CreateProcessUpLoad
{
    /// <summary>
    /// Отсылка данных используя протокол ftp
    /// (приложение cUrl)
    /// </summary>
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
