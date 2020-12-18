using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Scheme.Properties
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

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=sale-sql;Initial Catalog=GES;Integrated Security=True")]
		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		public string GESConnectionString
		{
			get
			{
				return (string)this["GESConnectionString"];
			}
		}

		[ApplicationScopedSetting]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=coder-server;Initial Catalog=GES;User ID=sasha;Password=\"cegth pfobnf\"")]
		public string GESConnectionString1
		{
			get
			{
				return (string)this["GESConnectionString1"];
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		[DefaultSettingValue("Data Source=CODER-SERVER;Initial Catalog=GES;User ID=Ivan;Password=itrjkflrf")]
		public string GESConnectionString2
		{
			get
			{
				return (string)this["GESConnectionString2"];
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=CODER-SERGEY;Initial Catalog=GES;Persist Security Info=True;User ID=Ivan;Password=itrjkflrf")]
		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		public string GESConnectionString3
		{
			get
			{
				return (string)this["GESConnectionString3"];
			}
		}

		[DefaultSettingValue("Data Source=ulges-sql2;Initial Catalog=GES;Integrated Security=True")]
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string GESConnectionString4
		{
			get
			{
				return (string)this["GESConnectionString4"];
			}
		}

		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DefaultSettingValue("Data Source=coder-sergey;Initial Catalog=GES;Persist Security Info=True;User ID=sasha;Password=\"cegth pfobnf\"")]
		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		public string GESConnectionString5
		{
			get
			{
				return (string)this["GESConnectionString5"];
			}
		}

		private static Settings defaultInstance;
	}
}
