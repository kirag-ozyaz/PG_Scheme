using System;
using System.Runtime.CompilerServices;

namespace Passport.Forms.PassportEE
{
	public class TransfAdditional
	{
		public string NameSubstation { get; set; }

		public string Inentory { get; set; }

		public string Type { get; set; }

		public string DateCommissioning { get; set; }

		public string DateManagement { get; set; }

		public string Sale { get; set; }

		public string BalanceSale { get; set; }

		public string Count { get; set; }

		public TransfAdditional(string nameSubstation, string inventory, string type, string dateCommissioning, string dateManagement, string sale, string balanceSale, string count)
		{
			this.NameSubstation = nameSubstation;
			this.Inentory = inventory;
			this.Type = type;
			this.DateCommissioning = dateCommissioning;
			this.DateManagement = dateManagement;
			this.Sale = sale;
			this.BalanceSale = balanceSale;
			this.Count = count;
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

		[CompilerGenerated]
		private string string_7;
	}
}
