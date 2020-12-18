using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Reference.Properties
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		[DefaultSettingValue("Data Source=SALE-SQL;Initial Catalog=GES;Integrated Security=True")]
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
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
		[DefaultSettingValue("Data Source=coder-sql;Initial Catalog=GES;Integrated Security=True")]
		public string GESConnectionString1
		{
			get
			{
				return (string)this["GESConnectionString1"];
			}
		}

		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=coder-server;Initial Catalog=GES;Persist Security Info=True;User ID=sasha;Password=\"cegth pfobnf\"")]
		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string GESConnectionString2
		{
			get
			{
				return (string)this["GESConnectionString2"];
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True")]
		public string GESConnectionString3
		{
			get
			{
				return (string)this["GESConnectionString3"];
			}
		}

		private static Settings defaultInstance;
	}
}
