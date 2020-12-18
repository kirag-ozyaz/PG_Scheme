using System;
using System.ComponentModel;

internal static class Class98
{
	internal static string smethod_0(this Enum enum_0)
	{
		DescriptionAttribute[] array = (DescriptionAttribute[])enum_0.GetType().GetField(enum_0.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
		if (array.Length == 0)
		{
			return enum_0.ToString();
		}
		return array[0].Description;
	}
}
