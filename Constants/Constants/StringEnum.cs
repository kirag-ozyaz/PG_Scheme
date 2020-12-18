using System;

namespace Constants
{
	public static class StringEnum
	{
		public static string GetStringValue(Enum value)
		{
			string result = null;
			StringValue[] array = value.GetType().GetField(value.ToString()).GetCustomAttributes(typeof(StringValue), false) as StringValue[];
			if (array.Length != 0)
			{
				result = array[0].Value;
			}
			return result;
		}
	}
}
