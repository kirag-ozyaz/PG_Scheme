using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace SchemeCtrl2.Properties
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

		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=SALE-SQL;Initial Catalog=GES;Integrated Security=True")]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
		public string GESConnectionString
		{
			get
			{
				return (string)this["GESConnectionString"];
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=sale-iis;Initial Catalog=GES;Integrated Security=True")]
		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		public string GESConnectionString1
		{
			get
			{
				return (string)this["GESConnectionString1"];
			}
		}

		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=coder-sql;Initial Catalog=GES;Integrated Security=True")]
		public string GESConnectionString2
		{
			get
			{
				return (string)this["GESConnectionString2"];
			}
		}

		[DefaultSettingValue("Data Source=192.168.8.252;Initial Catalog=OPC_Config;Integrated Security=True")]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		public string OPC_ConfigConnectionString
		{
			get
			{
				return (string)this["OPC_ConfigConnectionString"];
			}
		}

		[DefaultSettingValue("Data Source=coder-server;Initial Catalog=GES;User ID=sasha;Password=\"cegth pfobnf\"")]
		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string GESConnectionString3
		{
			get
			{
				return (string)this["GESConnectionString3"];
			}
		}

		[DefaultSettingValue("Data Source=CODER-SERVER;Initial Catalog=GES;User ID=Ivan;Password=itrjkflrf")]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		public string GESConnectionString4
		{
			get
			{
				return (string)this["GESConnectionString4"];
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True")]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
		public string GESConnectionString5
		{
			get
			{
				return (string)this["GESConnectionString5"];
			}
		}

		[ApplicationScopedSetting]
		[DefaultSettingValue("Data Source=CODER-SERGEY;Initial Catalog=GES;Persist Security Info=True;User ID=Ivan;Password=itrjkflrf")]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DebuggerNonUserCode]
		public string GESConnectionString6
		{
			get
			{
				return (string)this["GESConnectionString6"];
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=coder-sergey;Initial Catalog=GES;Persist Security Info=True;User ID=sasha;Password=\"cegth pfobnf\"")]
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		public string GESConnectionString7
		{
			get
			{
				return (string)this["GESConnectionString7"];
			}
		}

		private static Settings defaultInstance;
	}
}
