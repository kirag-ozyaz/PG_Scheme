using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace RequestsClient.Properties
{
	// Token: 0x0200003F RID: 63
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00007927 File Offset: 0x00005B27
		public static Settings Default
		{
			get
			{
				return Settings.a;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000792E File Offset: 0x00005B2E
		[SpecialSetting(SpecialSetting.ConnectionString)]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Data Source=coder-sergey;Initial Catalog=GES;User ID=sasha;Password=\"cegth pfobnf\";Connect Timeout=60;Encrypt=False;TrustServerCertificate=True")]
		[ApplicationScopedSetting]
		public string GESConnectionString
		{
			get
			{
				return (string)this["GESConnectionString"];
			}
		}

		// Token: 0x040000A1 RID: 161
		private static Settings a = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
