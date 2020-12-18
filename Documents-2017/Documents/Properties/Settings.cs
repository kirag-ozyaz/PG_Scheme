namespace Documents.Properties
{
    using System;
    using System.CodeDom.Compiler;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [CompilerGenerated, GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed class Settings : ApplicationSettingsBase
    {
        private static Settings settings_0 = ((Settings) SettingsBase.Synchronized(new Settings()));

        public static Settings Default
        {
            get
            {
                return settings_0;
            }
        }

        [ApplicationScopedSetting, DefaultSettingValue("Data Source=GAMMA;Initial Catalog=GES;Integrated Security=True"), DebuggerNonUserCode, SpecialSetting(SpecialSetting.ConnectionString)]
        public string GESConnectionString
        {
            get
            {
                return (string) this["GESConnectionString"];
            }
        }

        [DebuggerNonUserCode, DefaultSettingValue("Data Source=sale-sql;Initial Catalog=GES;Integrated Security=True"), SpecialSetting(SpecialSetting.ConnectionString), ApplicationScopedSetting]
        public string GESConnectionString1
        {
            get
            {
                return (string) this["GESConnectionString1"];
            }
        }

        [DefaultSettingValue("Data Source=coder-sergey;Initial Catalog=GES;User ID=sasha;Password=\"cegth pfobnf\";Connect Timeout=60;Encrypt=False;TrustServerCertificate=True"), ApplicationScopedSetting, SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode]
        public string GESConnectionString2
        {
            get
            {
                return (string) this["GESConnectionString2"];
            }
        }

        [DefaultSettingValue("Data Source=192.168.8.252;Initial Catalog=Org;Integrated Security=True"), DebuggerNonUserCode, ApplicationScopedSetting, SpecialSetting(SpecialSetting.ConnectionString)]
        public string OrgConnectionString
        {
            get
            {
                return (string) this["OrgConnectionString"];
            }
        }

        [DebuggerNonUserCode, ApplicationScopedSetting, DefaultSettingValue("Data Source=SALE-SQL;Initial Catalog=Org;Integrated Security=True"), SpecialSetting(SpecialSetting.ConnectionString)]
        public string OrgConnectionString1
        {
            get
            {
                return (string) this["OrgConnectionString1"];
            }
        }

        [ApplicationScopedSetting, SpecialSetting(SpecialSetting.ConnectionString), DebuggerNonUserCode, DefaultSettingValue("Data Source=192.168.8.252;Initial Catalog=PrvDB;Integrated Security=True")]
        public string PrvDBConnectionString
        {
            get
            {
                return (string) this["PrvDBConnectionString"];
            }
        }

        [SpecialSetting(SpecialSetting.ConnectionString), ApplicationScopedSetting, DefaultSettingValue("Data Source=192.168.8.252;Initial Catalog=PrvDbnc;Integrated Security=True"), DebuggerNonUserCode]
        public string PrvDbncConnectionString
        {
            get
            {
                return (string) this["PrvDbncConnectionString"];
            }
        }

        [ApplicationScopedSetting, DebuggerNonUserCode, DefaultSettingValue("Data Source=192.168.1.43;Initial Catalog=GES;Integrated Security=True"), SpecialSetting(SpecialSetting.ConnectionString)]
        public string trueGESConnectionString
        {
            get
            {
                return (string) this["trueGESConnectionString"];
            }
        }
    }
}

