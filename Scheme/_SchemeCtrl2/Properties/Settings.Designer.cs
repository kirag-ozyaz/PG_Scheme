using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SchemeCtrl2.Properties
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		public static Settings Default
		{
			get
			{
				return Settings.settings_0;
			}
		}

		[DefaultSettingValue("Data Source=SALE-SQL;Initial Catalog=GES;Integrated Security=True")]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
		public string GESConnectionString
		{
			get
			{
				return (string)this["GESConnectionString"];
			}
		}

		[DefaultSettingValue("Data Source=sale-iis;Initial Catalog=GES;Integrated Security=True")]
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string GESConnectionString1
		{
			get
			{
				return (string)this["GESConnectionString1"];
			}
		}

		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=coder-sql;Initial Catalog=GES;Integrated Security=True")]
		[DebuggerNonUserCode]
		public string GESConnectionString2
		{
			get
			{
				return (string)this["GESConnectionString2"];
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=192.168.8.252;Initial Catalog=OPC_Config;Integrated Security=True")]
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		public string OPC_ConfigConnectionString
		{
			get
			{
				return (string)this["OPC_ConfigConnectionString"];
			}
		}

		[ApplicationScopedSetting]
		[DefaultSettingValue("Data Source=coder-server;Initial Catalog=GES;User ID=sasha;Password=\"cegth pfobnf\"")]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DebuggerNonUserCode]
		public string GESConnectionString3
		{
			get
			{
				return (string)this["GESConnectionString3"];
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=CODER-SERVER;Initial Catalog=GES;User ID=Ivan;Password=itrjkflrf")]
		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string GESConnectionString4
		{
			get
			{
				return (string)this["GESConnectionString4"];
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
		[DefaultSettingValue("Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True")]
		[DebuggerNonUserCode]
		public string GESConnectionString5
		{
			get
			{
				return (string)this["GESConnectionString5"];
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		[DefaultSettingValue("Data Source=CODER-SERGEY;Initial Catalog=GES;Persist Security Info=True;User ID=Ivan;Password=itrjkflrf")]
		public string GESConnectionString6
		{
			get
			{
				return (string)this["GESConnectionString6"];
			}
		}

		[DefaultSettingValue("Data Source=coder-sergey;Initial Catalog=GES;Persist Security Info=True;User ID=sasha;Password=\"cegth pfobnf\"")]
		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string GESConnectionString7
		{
			get
			{
				return (string)this["GESConnectionString7"];
			}
		}

		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
