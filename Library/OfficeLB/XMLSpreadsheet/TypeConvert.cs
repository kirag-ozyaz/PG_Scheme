using System;
using System.Collections.Generic;
using System.Text;

namespace OfficeLB.XMLSpreadsheet
{
	public class TypeConvert
	{
		public static string ToString(object value)
		{
			if (value != null)
			{
				if (DBNull.Value != value)
				{
					return value.ToString();
				}
			}
			return string.Empty;
		}

		public static short ToInt16(object value)
		{
			if (value != null)
			{
				if (DBNull.Value != value)
				{
					return short.Parse(value.ToString());
				}
			}
			return 0;
		}

		public static int ToInt32(object value)
		{
			if (value != null)
			{
				if (DBNull.Value != value)
				{
					return int.Parse(value.ToString());
				}
			}
			return 0;
		}

		public static long ToInt64(object value)
		{
			if (value != null)
			{
				if (DBNull.Value != value)
				{
					return long.Parse(value.ToString());
				}
			}
			return 0L;
		}

		public static decimal ToDecimal(object value)
		{
			if (value != null)
			{
				if (DBNull.Value != value)
				{
					return decimal.Parse(value.ToString());
				}
			}
			return 0m;
		}

		public static DateTime ToDateTime(object value)
		{
			if (value != null)
			{
				if (DBNull.Value != value)
				{
					return DateTime.Parse(value.ToString());
				}
			}
			return DateTime.MinValue;
		}

		public static List<T> ConvertToGeneric<T>(object[] valuesToConvert)
		{
			List<T> list = new List<T>();
			foreach (object obj in valuesToConvert)
			{
				list.Add((T)((object)obj));
			}
			return list;
		}

		public static T[] ConvertToArray<T>(IList<T> values)
		{
			T[] array = new T[values.Count];
			values.CopyTo(array, 0);
			return array;
		}

		public static string UTF8ByteArrayToString(byte[] characters)
		{
			return new UTF8Encoding().GetString(characters);
		}

		public static byte[] StringToUTF8ByteArray(string str)
		{
			return new UTF8Encoding().GetBytes(str);
		}

		public TypeConvert()
		{
			
			
		}
	}
}
