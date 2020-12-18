using System;

namespace SchemeCtrl2.ElectricModel.Calculations
{
	public class AmperageProperties
	{
		public AmperageProperties()
		{
		}

		public AmperageProperties(int voltage, int amperage, int power)
		{
			this.amperage = amperage;
			this.power = power;
			this.voltage = voltage;
		}

		public int voltage;

		public int amperage;

		public int power;
	}
}
