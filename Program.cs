using EIS.Forms;
using FormLbr.Classes;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace EIS
{
    internal static class Program
    {
        public static string CURRENT_USER = "1";
        private const int SW_SHOWNOACTIVATE = 4;
        private static FormMain formMain;

        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        private static extern int SetForegroundWindow(IntPtr handle);

        [DllImport("user32.dll", EntryPoint = "ShowWindow")]
        private static extern bool ShowWindow(IntPtr handle, int cmdShow);

        [STAThread]
        private static void Main(string[] array)
        {
            if (array.Length != 0)
                AppConfig.FileName = array[0];
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (array.Length <= 1)
            {
                Process currentProcess = Process.GetCurrentProcess();
                foreach (Process process in Process.GetProcessesByName(Application.ProductName))
                {
                    if (process.Id != currentProcess.Id && process.SessionId == currentProcess.SessionId)
                    {
                        SetForegroundWindow(process.MainWindowHandle);
                        ShowWindow(process.MainWindowHandle, SW_SHOWNOACTIVATE);
                        return;
                    }
                }
            }
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            formMain = new FormMain();
            Application.Run(formMain);
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
#if !DEBUG
            if (formMain != null)
            {
                string path;
                if (string.IsNullOrEmpty(formMain.pathUpdate))
                {
                    if (formMain.backgroundWorkerUpdater.IsBusy)
                    {
                        //MessageBox.Show("busy");
                        while (formMain.backgroundWorkerUpdater.IsBusy)
                        {
                        }
                    }
                    if (string.IsNullOrEmpty(formMain.pathUpdate))
                    {
                        if (formMain.eisSettings.UpdateSettings.DownloadPath.IndexOf("ftp") == 0)  // начинается с ФТП
                        {
                            //MessageBox.Show("frpbeg");
                            EIS.ChekerDownloaderFromFTP checkFTP = new ChekerDownloaderFromFTP(formMain.eisSettings.UpdateSettings.DownloadPath);
                            checkFTP.CurrentVersion = Assembly.GetEntryAssembly().GetName().Version;
                            checkFTP.FTPUser = "ftpuser";
                            checkFTP.FTPPassword = "qazwsxedc";
                            //MessageBox.Show("frpbeg2");
                            path = checkFTP.PrepareUpdates();
                            //MessageBox.Show("frpend");
                        }
                        else
                        {
                            EIS.ChekerDownloaderFromFolder check = new ChekerDownloaderFromFolder(formMain.eisSettings.UpdateSettings.DownloadPath);
                            check.CurrentVersion = Assembly.GetEntryAssembly().GetName().Version;
                            path = check.PrepareUpdates();
                        }
                    }
                    else
                        path = formMain.pathUpdate;
                }
                else
                    path = formMain.pathUpdate;

                if (!string.IsNullOrEmpty(path))
                {
                    try
                    {
                        //MessageBox.Show(path);
                        Process.Start("EISUpdate.exe", path);
                        //MessageBox.Show("end");
                    }
                    catch { }
                }
            }
#endif
        }
        #region Глобальная ловля исключений
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs args)
        {
            try
            {
                int num = (int)MessageBox.Show(args.ExceptionObject.ToString());
                WriteEventLog(args.ExceptionObject.ToString());
                // показываем исключение/пишем в лог
            }
            catch (Exception ex)
            {
                try
                {
                    int num = (int)MessageBox.Show(ex.ToString());
                    WriteEventLog(ex.ToString());
                }
                finally
                {
                    Application.Exit();
                }
            }
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs args)
        {
            try
            {
                MessageBox.Show(args.Exception.ToString());
                WriteEventLog(args.Exception.ToString());
                // показываем исключение/пишем в лог
            }
            catch (Exception ex)
            {
                try
                {
                    MessageBox.Show(ex.ToString());
                    WriteEventLog(ex.ToString());
                }
                finally
                {
                    Application.Exit();
                }
            }
        }

        private static void WriteEventLog(string message)
        {
            if (!EventLog.SourceExists("EIS"))
            {
                EventLog.CreateEventSource("EIS", "EISLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Exiting, execute the application a second time to use the source.");
            }
            else
            {
                EventLog eventLog = new EventLog();
                eventLog.Source = "EIS";
                //string message = param0;
                eventLog.WriteEntry(message);
            }
        }
        #endregion
    }
}
