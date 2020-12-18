using System;
using System.Runtime.CompilerServices;

namespace Passport.Forms.PassportEE
{
	public class Company
	{
		public double Number { get; set; }

		public string Region { get; set; }

		public string Name { get; set; }

		public string INN { get; set; }

		public string KPP { get; set; }

		public string Activity { get; set; }

		public string RST_ORG_ID { get; set; }

		public string ShortName
		{
			get
			{
				return this.Name.Replace("ООО \"", "").Replace("ОАО \"", "").Replace("ЗАО \"", "").Replace("МУП \"", "").Replace("ИП ", "").Replace("\"", "");
			}
		}

		public string FullNameOrg
		{
			get
			{
				return string.Concat(new string[]
				{
					"Субъект РФ:",
					this.Region,
					"_Организация:",
					this.Name,
					"_ИНН:",
					this.INN,
					"_КПП:",
					this.KPP
				});
			}
		}

		[CompilerGenerated]
		private double double_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;

		[CompilerGenerated]
		private string string_4;

		[CompilerGenerated]
		private string string_5;
	}
}
