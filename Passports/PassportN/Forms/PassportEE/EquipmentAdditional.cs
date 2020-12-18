using System;
using System.Runtime.CompilerServices;

namespace Passport.Forms.PassportEE
{
	public class EquipmentAdditional
	{
		public string NameSubstation { get; set; }

		public string Voltage { get; set; }

		public string CountMeter { get; set; }

		public string CountTransf { get; set; }

		public EquipmentAdditional(string nameSubstation, string voltage, string countMeter, string countTransf)
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
			this.NameSubstation = nameSubstation;
			this.Voltage = voltage;
			this.CountMeter = countMeter;
			this.CountTransf = countTransf;
		}

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;

		[CompilerGenerated]
		private string string_3;
	}
}
