using System;
using System.ComponentModel;
using System.Globalization;
using SchemeModelN.Calculations;

internal class AmperageConverte : ExpandableObjectConverter
{
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return destinationType == typeof(ElectricAmperage) || base.CanConvertTo(context, destinationType);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == typeof(string) && value is ElectricAmperage)
		{
			return "Amperage";
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

}
