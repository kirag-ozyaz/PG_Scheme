using System;
using System.ComponentModel;
using System.Globalization;

namespace SchemeCtrl2.Calculations
{
	public class CouplingRelationConverter : ExpandableObjectConverter
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
	}
}
