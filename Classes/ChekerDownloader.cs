// Decompiled with JetBrains decompiler
// Type: EIS.ChekerDownloader
// Assembly: EIS, Version=1.1.20.0, Culture=neutral, PublicKeyToken=null
// MVID: D97E7465-1D18-4676-A9AC-C679BB2F90D9
// Assembly location: D:\Декомпилятор C#\EIS_2016-11-07\Deobfuscated\EIS.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace EIS
{
  public abstract class ChekerDownloader
  {
    internal string Field7 = string.Empty;
    internal string Field6 = string.Empty;
    internal string Field5 = string.Empty;
    internal string Field4 = string.Empty;
    internal const string Field8 = "settingsUpdates.xml";

    public Version CurrentVersion { get; set; }

    public string UpdateArhivePath
    {
      get
      {
        return this.Field4;
      }
      set
      {
        this.Field4 = value;
      }
    }

    public bool RemoveUpdateArhiveAfterExtract { get; set; }

    public bool OnlyDownload { get; set; }

    public ChekerDownloader(string soursePath)
    {
      this.Field7 = soursePath;
      this.Field4 = Path.GetTempPath() + "EISUpdateArhive\\";
      this.OnlyDownload = false;
    }

    public ChekerDownloader(string soursePath, string updateArhivePath)
    {
      this.Field7 = soursePath;
      this.Field4 = updateArhivePath;
      this.OnlyDownload = true;
    }

    public string PrepareUpdates()
    {
      List<string> updateList = this.GetUpdateList();
      if (updateList.Count == 0)
        return string.Empty;
      string str1 = Path.GetTempPath() + "EISUpdate\\";
      if (Directory.Exists(str1))
        Directory.Delete(str1, true);
      if (!this.OnlyDownload)
        Directory.CreateDirectory(str1);
      foreach (string fileName in updateList)
      {
        if (this.DownloadUpdateArhive(fileName) && !this.OnlyDownload)
        {
          string field4 = this.Field4;
          string str2;
          string sCompressedFile;
          if ((int) field4[field4.Length - 1] != (int) Path.DirectorySeparatorChar)
          {
            string str3 = field4;
            string str4 = Path.DirectorySeparatorChar.ToString();
            string str5 = fileName;
            sCompressedFile = str2 = str3 + str4 + str5;
          }
          else
            str2 = sCompressedFile = field4 + fileName;
          Compress.DecompressToDirectory(sCompressedFile, str1);
          if (this.RemoveUpdateArhiveAfterExtract)
            File.Delete(this.Field4);
        }
      }
      if (this.OnlyDownload)
        this.DownloadUpdateArhive("settingsUpdates.xml");
      if (Directory.Exists(str1) && Directory.GetFiles(str1).Length != 0)
        return str1;
      return string.Empty;
    }

    protected virtual List<string> GetUpdateList()
    {
      return new List<string>();
    }

    protected virtual bool DownloadUpdateArhive(string fileName)
    {
      return false;
    }

    internal List<string> Method1(string _param1)
    {
      List<string> stringList = new List<string>();
      XmlDocument xmlDocument = new XmlDocument();
      StreamReader streamReader = new StreamReader(_param1);
      string end = streamReader.ReadToEnd();
      xmlDocument.LoadXml(end);
      string xpath = "UpdSetings";
      foreach (XmlNode childNode in xmlDocument.SelectSingleNode(xpath).SelectSingleNode("Files").ChildNodes)
      {
        Version version = new Version(childNode.Attributes["Version"].Value.ToString());
        string str = childNode.Attributes["FileName"].Value.ToString();
        if (version > this.CurrentVersion)
        {
          stringList.Add(str);
          this.CurrentVersion = version;
        }
      }
      streamReader.Close();
      return stringList;
    }
  }
}
