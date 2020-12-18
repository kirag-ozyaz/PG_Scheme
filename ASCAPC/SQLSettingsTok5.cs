using DataSql;
using FormLbr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace ASCAPC
{
    public class SQLSettingsTok5 : SQLSettings
    {
        private string _dBName = "Tok_5";
        private string _serverDB = "ulges-sql";
        private string _autentification = "WINDOWS";

        //public new string DBName { get => _dBName; set => _dBName = value; }
        //public new string ServerDB { get => _serverDB; set => _serverDB = value; }
        //public new string Autentification { get => _autentification; set => _autentification = value; }
        public SQLSettingsTok5()
        {
            ServerDB = _serverDB;
            DBName = _dBName;
            Autentification = _autentification;
        }
    }
    public class FormBaseTok : FormBase
    {
        SqlDataCommand commandTok;
        public FormBaseTok()
        {
            //SQLSettings settings = new SQLSettings();
            commandTok = new SqlDataCommand(SqlSettings);
        }

        public override SQLSettings SqlSettings
        {
            get => base.SqlSettings;
            set
            {
                if (value == null)

                    base.SqlSettings = new SQLSettingsTok5();
            }
        }
    }

}
