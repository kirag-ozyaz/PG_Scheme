using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExportToPostGIS
{
    public class SQLSettingsGIS
    {
        string ServerPSQL = "192.168.1.33";
        string UserIdPSSQL = "postgres";
        string PasswordPSSQL = "psql";
        string DatabasePSSQL = "U10";
        string Schema = "";

        public string ToConnect()
        {
            return  "Server=" + ServerPSQL + ";User id=" + UserIdPSSQL + ";Password=" + PasswordPSSQL + ";Database=" + DatabasePSSQL;

        }
    }
}
