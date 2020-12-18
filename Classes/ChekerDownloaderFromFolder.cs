// Decompiled with JetBrains decompiler
// Type: EIS.ChekerDownloaderFromFolder
// Assembly: EIS, Version=1.1.20.0, Culture=neutral, PublicKeyToken=null
// MVID: D97E7465-1D18-4676-A9AC-C679BB2F90D9
// Assembly location: D:\Декомпилятор C#\EIS_2016-11-07\Deobfuscated\EIS.exe

using System.Collections.Generic;
using System.IO;

namespace EIS
{
  public class ChekerDownloaderFromFolder : ChekerDownloader
  {
    public ChekerDownloaderFromFolder(string soursePath)
      : base(soursePath)
    {
    }

    public ChekerDownloaderFromFolder(string soursePath, string updateArhivePath)
      : base(soursePath, updateArhivePath)
    {
    }

    protected override List<string> GetUpdateList()
    {
      string field7 = this.Field7;
      string str1;
      string str2;
      if ((int) field7[field7.Length - 1] != (int) Path.DirectorySeparatorChar)
      {
        string str3 = field7;
        string str4 = Path.DirectorySeparatorChar.ToString();
        string str5 = "settingsUpdates.xml";
        str2 = str1 = str3 + str4 + str5;
      }
      else
        str1 = str2 = field7 + "settingsUpdates.xml";
      string path = str2;
      if (File.Exists(path))
        return this.Method1(path);
      return base.GetUpdateList();
    }

    protected override bool DownloadUpdateArhive(string fileName)
    {
      string field7 = this.Field7;
      char directorySeparatorChar;
      string str1;
      string str2;
      if ((int) field7[field7.Length - 1] != (int) Path.DirectorySeparatorChar)
      {
        string str3 = field7;
        directorySeparatorChar = Path.DirectorySeparatorChar;
        string str4 = directorySeparatorChar.ToString();
        string str5 = fileName;
        str2 = str1 = str3 + str4 + str5;
      }
      else
        str1 = str2 = field7 + fileName;
      string sourceFileName = str2;
      string field4 = this.Field4;
      if (!Directory.Exists(this.Field4))
        Directory.CreateDirectory(this.Field4);
      string str6;
      string str7;
      if ((int) field4[field4.Length - 1] != (int) Path.DirectorySeparatorChar)
      {
        string str3 = field4;
        directorySeparatorChar = Path.DirectorySeparatorChar;
        string str4 = directorySeparatorChar.ToString();
        string str5 = fileName;
        str7 = str6 = str3 + str4 + str5;
      }
      else
        str6 = str7 = field4 + fileName;
      string destFileName = str7;
      try
      {
        File.Copy(sourceFileName, destFileName, true);
      }
      catch
      {
        return false;
      }
      return true;
    }
  }
}
