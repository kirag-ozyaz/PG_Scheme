﻿using System;
using System.ComponentModel;
using System.Globalization;
using SchemeCtrl2.Calculations;

internal class Class84 : ExpandableObjectConverter
{
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
	{
		return destinationType == typeof(Amperage) || base.CanConvertTo(context, destinationType);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == typeof(string) && value is Amperage)
		{
			return "Amperage";
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}

	public Class84()
	{
		
		
	}
}
