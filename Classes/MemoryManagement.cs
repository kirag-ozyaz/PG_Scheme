using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace EIS.Forms
{
  public class MemoryManagement
  {
    [DllImport("kernel32.dll")]
    public static extern bool SetProcessWorkingSetSize(IntPtr proc, int min, int max);

    public void FlushMemory()
    {
      GC.Collect();
      GC.WaitForPendingFinalizers();
      if (Environment.OSVersion.Platform != PlatformID.Win32NT)
        return;
      MemoryManagement.SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
    }
  }
}
