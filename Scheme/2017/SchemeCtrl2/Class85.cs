using System;
using System.ComponentModel;
using System.Globalization;
using SchemeCtrl2.Calculations;

internal class Class85 : ExpandableObjectConverter
{
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return destinationType == typeof(CouplingRelation) || base.CanConvertTo(context, destinationType);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == typeof(string) && value is CouplingRelation)
		{
			return "Связь";
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	public Class85()
	{
		Class90.TDroV38zslI2T();
		base..ctor();
	}
}
