using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Passport.Properties
{
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=SALE-SQL;Initial Catalog=GES;Integrated Security=True")]
		[DebuggerNonUserCode]
		public string GESConnectionString
		{
			get
			{
				return (string)this["GESConnectionString"];
			}
		}

		[ApplicationScopedSetting]
		[DefaultSettingValue("Data Source=SALE-IIS;Initial Catalog=GES;Integrated Security=True")]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string GESConnectionString1
		{
			get
			{
				return (string)this["GESConnectionString1"];
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=ulges-sql;Initial Catalog=GES;Integrated Security=True")]
		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string GESConnectionString2
		{
			get
			{
				return (string)this["GESConnectionString2"];
			}
		}

		[DefaultSettingValue("Data Source=CODER-SQL;Initial Catalog=GES;Integrated Security=True")]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
		public string GESConnectionString3
		{
			get
			{
				return (string)this["GESConnectionString3"];
			}
		}

		[DefaultSettingValue("Data Source=|DataDirectory|\\Cache\\PassportPanelCache.sdf")]
		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string ClientPassportPanelCacheConnectionString
		{
			get
			{
				return (string)this["ClientPassportPanelCacheConnectionString"];
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=CODER-SQL;Initial Catalog=GES;User ID=yura;Password=Shks94hpPsql")]
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		public string GESConnectionString4
		{
			get
			{
				return (string)this["GESConnectionString4"];
			}
		}

		[ApplicationScopedSetting]
		[DefaultSettingValue("Data Source=CODER-SERVER;Initial Catalog=GES;Persist Security Info=True;User ID=yura;Password=Shks94hpPcoder")]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string GESConnectionString5
		{
			get
			{
				return (string)this["GESConnectionString5"];
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
		[DefaultSettingValue("Data Source=192.168.8.252;Initial Catalog=GES;Integrated Security=True")]
		[DebuggerNonUserCode]
		public string GESConnectionString6
		{
			get
			{
				return (string)this["GESConnectionString6"];
			}
		}

		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True")]
		[ApplicationScopedSetting]
		public string GESConnectionString7
		{
			get
			{
				return (string)this["GESConnectionString7"];
			}
		}

		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=ulges-sql;Initial Catalog=Kab;Integrated Security=True")]
		[DebuggerNonUserCode]
		public string KabConnectionString
		{
			get
			{
				return (string)this["KabConnectionString"];
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=192.168.10.7\\SQLEXPRESS;Initial Catalog=GES_RES;User ID=admin;Password=coder.ul2012_admin")]
		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string GES_RESConnectionString
		{
			get
			{
				return (string)this["GES_RESConnectionString"];
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=coder-sergey;Initial Catalog=GES;User ID=sasha;Password=\"cegth pfobnf\"")]
		public string GESConnectionString8
		{
			get
			{
				return (string)this["GESConnectionString8"];
			}
		}

		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
