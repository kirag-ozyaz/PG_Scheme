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
				return Settings.defaultInstance;
			}
		}

		[ApplicationScopedSetting]
		[DefaultSettingValue("Data Source=SALE-SQL;Initial Catalog=GES;Integrated Security=True")]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DebuggerNonUserCode]
		public string GESConnectionString
		{
			get
			{
				return (string)this["GESConnectionString"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=SALE-IIS;Initial Catalog=GES;Integrated Security=True")]
		public string GESConnectionString1
		{
			get
			{
				return (string)this["GESConnectionString1"];
			}
		}

		[DefaultSettingValue("Data Source=ulges-sql;Initial Catalog=GES;Integrated Security=True")]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
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

		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=|DataDirectory|\\Cache\\PassportPanelCache.sdf")]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
		public string ClientPassportPanelCacheConnectionString
		{
			get
			{
				return (string)this["ClientPassportPanelCacheConnectionString"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=CODER-SQL;Initial Catalog=GES;User ID=yura;Password=Shks94hpPsql")]
		public string GESConnectionString4
		{
			get
			{
				return (string)this["GESConnectionString4"];
			}
		}

		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
		[DefaultSettingValue("Data Source=CODER-SERVER;Initial Catalog=GES;Persist Security Info=True;User ID=yura;Password=Shks94hpPcoder")]
		public string GESConnectionString5
		{
			get
			{
				return (string)this["GESConnectionString5"];
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=192.168.8.252;Initial Catalog=GES;Integrated Security=True")]
		public string GESConnectionString6
		{
			get
			{
				return (string)this["GESConnectionString6"];
			}
		}

		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
		[DefaultSettingValue("Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True")]
		public string GESConnectionString7
		{
			get
			{
				return (string)this["GESConnectionString7"];
			}
		}

		[ApplicationScopedSetting]
		[DefaultSettingValue("Data Source=ulges-sql;Initial Catalog=Kab;Integrated Security=True")]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string KabConnectionString
		{
			get
			{
				return (string)this["KabConnectionString"];
			}
		}

		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=192.168.10.7\\SQLEXPRESS;Initial Catalog=GES_RES;User ID=admin;Password=coder.ul2012_admin")]
		public string GES_RESConnectionString
		{
			get
			{
				return (string)this["GES_RESConnectionString"];
			}
		}

		[DefaultSettingValue("Data Source=coder-sergey;Initial Catalog=GES;User ID=sasha;Password=\"cegth pfobnf\"")]
		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string GESConnectionString8
		{
			get
			{
				return (string)this["GESConnectionString8"];
			}
		}

		private static Settings defaultInstance;
	}
}
