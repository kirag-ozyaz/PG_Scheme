using System;

internal class AmperageProperties
{
    internal AmperageProperties()
    { }
    internal AmperageProperties(int voltage, int amperage, int power)
	{
		this.Amperages = amperage;
		this.Power = power;
		this.Voltage = voltage;
	}
	internal int Voltage;
	internal int Amperages;
	internal int Power;
}
