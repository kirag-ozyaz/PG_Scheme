// Decompiled with JetBrains decompiler
// Type: EIS.ChekerDownloaderFromFTP
// Assembly: EIS, Version=1.1.20.0, Culture=neutral, PublicKeyToken=null
// MVID: D97E7465-1D18-4676-A9AC-C679BB2F90D9
// Assembly location: D:\Декомпилятор C#\EIS_2016-11-07\Deobfuscated\EIS.exe

using System.Collections.Generic;
using System.IO;
using System.Net;

namespace EIS
{
  public class ChekerDownloaderFromFTP : ChekerDownloader
  {
    public string FTPUser { get; set; }

    public string FTPPassword { get; set; }

    public ChekerDownloaderFromFTP(string soursePath)
      : base(soursePath)
    {
      this.FTPPassword = this.FTPUser = string.Empty;
    }

    public ChekerDownloaderFromFTP(string soursePath, string updateArhivePath)
      : base(soursePath, updateArhivePath)
    {
      this.FTPPassword = this.FTPUser = string.Empty;
    }

    protected override List<string> GetUpdateList()
    {
      List<string> stringList = new List<string>();
      string dest = Path.GetTempPath() + "EISUpdate\\";
      if (!ChekerDownloaderFromFTP.Download(this.Field7, "settingsUpdates.xml", dest, this.FTPUser, this.FTPPassword))
        return base.GetUpdateList();
      string path1;
      string str1;
      if ((int) dest[dest.Length - 1] != (int) Path.DirectorySeparatorChar)
      {
        string str2 = dest;
        string str3 = Path.DirectorySeparatorChar.ToString();
        string str4 = "settingsUpdates.xml";
        str1 = path1 = str2 + str3 + str4;
      }
      else
        path1 = str1 = dest + "settingsUpdates.xml";
      string path2 = str1;
      if (System.IO.File.Exists(path2))
      {
        stringList = this.Method1(path2);
        try
        {
          System.IO.File.Delete(path2);
          Directory.Delete(path1);
        }
        catch
        {
        }
      }
      return stringList;
    }

    protected override bool DownloadUpdateArhive(string fileName)
    {
      if (!Directory.Exists(this.Field4))
        Directory.CreateDirectory(this.Field4);
      return ChekerDownloaderFromFTP.Download(this.Field7, fileName, this.Field4, this.FTPUser, this.FTPPassword);
    }

    public static bool Download(string downloaduri, string filename, string dest, string login, string password)
    {
      try
      {
        string str1 = downloaduri;
        string str2;
        string requestUriString;
        if ((int) str1[str1.Length - 1] != (int) Path.DirectorySeparatorChar)
        {
          string str3 = str1;
          string str4 = Path.DirectorySeparatorChar.ToString();
          string str5 = filename;
          requestUriString = str2 = str3 + str4 + str5;
        }
        else
          str2 = requestUriString = str1 + filename;
        FtpWebRequest ftpWebRequest = (FtpWebRequest) WebRequest.Create(requestUriString);
        string str6 = "RETR";
        ftpWebRequest.Method = str6;
        int num1 = 1;
        ftpWebRequest.KeepAlive = num1 != 0;
        int num2 = 1;
        ftpWebRequest.UsePassive = num2 != 0;
        int num3 = 1;
        ftpWebRequest.UseBinary = num3 != 0;
        NetworkCredential networkCredential = new NetworkCredential(login, password);
        ftpWebRequest.Credentials = (ICredentials) networkCredential;
        using (FtpWebResponse response = (FtpWebResponse) ftpWebRequest.GetResponse())
        {
          using (Stream responseStream = response.GetResponseStream())
          {
            string str3 = dest;
            string str4;
            string str5;
            if ((int) str3[str3.Length - 1] != (int) Path.DirectorySeparatorChar)
            {
              string str7 = str3;
              string str8 = Path.DirectorySeparatorChar.ToString();
              string str9 = filename;
              str5 = str4 = str7 + str8 + str9;
            }
            else
              str4 = str5 = str3 + filename;
            string path = str5;
            if (!Directory.Exists(dest))
              Directory.CreateDirectory(dest);
            FileStream fileStream = System.IO.File.Create(path);
            byte[] buffer = new byte[32768];
            int count;
            while ((count = responseStream.Read(buffer, 0, buffer.Length)) > 0)
              fileStream.Write(buffer, 0, count);
            fileStream.Close();
          }
        }
        return true;
      }
      catch
      {
        return false;
      }
    }
  }
}
