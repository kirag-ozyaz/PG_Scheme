﻿using System;
using System.ComponentModel;
using System.Globalization;

namespace SchemeCtrl2.Calculations
{
	public class AmperageConverter : ExpandableObjectConverter
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
	}
}
