using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JournalRequest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Documents.Forms.JournalRequest.FormJournalRequest f = new Documents.Forms.JournalRequest.FormJournalRequest();
            f.SqlSettings = new DataSql.SQLSettings("ulges-sql2", "ges", "windows", "", "");
            Application.Run(f);
        }
    }
}
