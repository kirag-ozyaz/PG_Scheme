using System;
using System.Runtime.CompilerServices;

namespace Passport.Forms.PassportEE
{
	public class TransfContract
	{
		public string NameSubstation { get; set; }

		public string Number { get; set; }

		public string DateContract { get; set; }

		public string DateEndContract { get; set; }

		public string NameAbonent { get; set; }

		public string MaxPower { get; set; }

		public string Link { get; set; }

		public TransfContract(string nameSubstation, string number, string dateContract, string dateEndContract, string nameAbonent, string maxPower, string link)
		{
			this.NameSubstation = nameSubstation;
			this.Number = number;
			this.DateContract = dateContract;
			this.DateEndContract = dateEndContract;
			this.NameAbonent = nameAbonent;
			this.MaxPower = maxPower;
			this.Link = link;
		}

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

		[CompilerGenerated]
		private string string_6;
	}
}
