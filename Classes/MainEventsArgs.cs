// Decompiled with JetBrains decompiler
// Type: EIS.Classes.MainEventsArgs
// Assembly: EIS, Version=1.1.20.0, Culture=neutral, PublicKeyToken=null
// MVID: D97E7465-1D18-4676-A9AC-C679BB2F90D9
// Assembly location: D:\Декомпилятор C#\EIS_2016-11-07\Deobfuscated\EIS.exe

using System;

namespace EIS.Classes
{
  public class MainEventsArgs : EventArgs
  {
    private string Field1;

    public string Message
    {
      get
      {
        return this.Field1;
      }
      set
      {
        this.Field1 = value;
      }
    }

    public MainEventsArgs(string message)
    {
      this.Field1 = message;
    }
  }
}
