using System.Diagnostics;
using System.IO;

namespace SchemeService
{
    public class UtilsCURL
    {
        public static void UploadFileToFTPByCURL(string curlName, string ftpName, string ftpUser, string ftpPwd, string fileName, string ftpProxy, string ftpProxyUser, string ftpProxyPwd)
        {
            new Process
            {
                StartInfo =
                {
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    FileName = curlName,
                    WorkingDirectory = Path.GetDirectoryName(curlName),
                    Arguments = (string.IsNullOrEmpty(ftpProxyUser) ? "" : string.Format(" -U {0}:{1} ", ftpProxyUser, ftpProxyPwd)) + (string.IsNullOrEmpty(ftpProxy) ? "" : string.Format(" -x {0} ", ftpProxy)) + string.Format(" -T {0} ftp://{1}:{2}@{3}", new object[]
                    {
                        fileName,
                        ftpUser,
                        ftpPwd,
                        ftpName
                    })
                }
            }.Start();
        }
    }
}
