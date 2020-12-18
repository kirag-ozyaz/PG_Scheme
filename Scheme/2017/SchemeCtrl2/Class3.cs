using System;
using System.Drawing;
using System.Reflection;
using SchemeCtrl2.Canvas;

internal class Class3
{
	private static PropertyInfo smethod_0(object object_0, string[] string_0, int int_0, ref object object_1)
	{
		object_1 = object_0;
		string string_ = string_0[int_0];
		PropertyInfo propertyInfo = Class3.smethod_3(object_0, string_);
		if (propertyInfo == null)
		{
			return null;
		}
		object_0 = propertyInfo.GetValue(object_0, null);
		int_0++;
		if (int_0 == string_0.Length)
		{
			return propertyInfo;
		}
		return Class3.smethod_0(object_0, string_0, int_0, ref object_1);
	}

	internal static PropertyInfo smethod_1(object object_0, ref object object_1, string string_0)
	{
		string[] string_ = string_0.Split(new char[]
		{
			'.'
		});
		return Class3.smethod_0(object_0, string_, 0, ref object_1);
	}

	internal static PropertyInfo smethod_2(ref object object_0, string string_0)
	{
		return Class3.smethod_1(object_0, ref object_0, string_0);
	}

	internal static PropertyInfo smethod_3(object object_0, string string_0)
	{
		if (object_0 == null)
		{
			return null;
		}
		return Class3.smethod_4(object_0.GetType(), string_0);
	}

	internal static PropertyInfo smethod_4(Type type_0, string string_0)
	{
		MemberInfo[] member = type_0.GetMember(string_0);
		for (int i = 0; i < member.Length; i++)
		{
			PropertyInfo propertyInfo = member[i] as PropertyInfo;
			if (propertyInfo != null)
			{
				return propertyInfo;
			}
		}
		return null;
	}

	private static bool smethod_5(object object_0)
	{
		if (object_0 == null)
		{
			return false;
		}
		Type type = object_0.GetType();
		if (!type.IsPrimitive && !type.IsEnum)
		{
			if (type != typeof(string))
			{
				return false;
			}
		}
		return true;
	}

	internal static object smethod_6(object object_0, Type type_0)
	{
		if (type_0 == typeof(UnitPoint))
		{
			return Class3.smethod_7(object_0.ToString(), type_0);
		}
		if (object_0.GetType() == type_0)
		{
			return object_0;
		}
		if (object_0.GetType() == typeof(string) && type_0.IsEnum)
		{
			try
			{
				return Enum.Parse(type_0, object_0.ToString());
			}
			catch
			{
			}
		}
		if (!type_0.IsPrimitive)
		{
			object obj = Class3.smethod_7(object_0.ToString(), type_0);
			if (obj != null)
			{
				return obj;
			}
		}
		try
		{
			return Convert.ChangeType(object_0, type_0);
		}
		catch
		{
		}
		return null;
	}

	internal static object smethod_7(string string_0, Type type_0)
	{
		if (type_0 == typeof(UnitPoint))
		{
			return Class3.smethod_9(new UnitPoint(0.0, 0.0), string_0);
		}
		if (type_0 == typeof(SizeF))
		{
			return Class3.smethod_9(new SizeF(0f, 0f), string_0);
		}
		if (type_0 == typeof(PointF))
		{
			return Class3.smethod_9(new PointF(0f, 0f), string_0);
		}
		if (type_0 == typeof(Color))
		{
			string_0 = string_0.Replace("Color ", "");
			string_0 = string_0.Trim(new char[]
			{
				'[',
				']'
			});
			Color color = Color.FromName(string_0);
			if (color.IsKnownColor)
			{
				return color;
			}
			Class3.Class4 @class = new Class3.Class4();
			Class3.smethod_9(@class, string_0);
			return @class.Color;
		}
		else
		{
			if (type_0 == typeof(RectangleF))
			{
				return Class3.smethod_9(new RectangleF(0f, 0f, 0f, 0f), string_0);
			}
			return null;
		}
	}

	internal static void smethod_8(string string_0, string string_1, object object_0)
	{
		if (string_0.Length == 0 || string_1.Length == 0)
		{
			return;
		}
		PropertyInfo propertyInfo = Class3.smethod_3(object_0, string_0);
		if (propertyInfo != null && propertyInfo.CanWrite)
		{
			try
			{
				object obj = Class3.smethod_6(string_1, propertyInfo.PropertyType);
				if (obj != null)
				{
					propertyInfo.SetValue(object_0, obj, null);
				}
			}
			catch
			{
			}
			return;
		}
	}

	internal static object smethod_9(object object_0, string string_0)
	{
		string_0 = string_0.Trim(new char[]
		{
			'{',
			'}'
		});
		string[] array = string_0.Split(new char[]
		{
			','
		});
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(new char[]
			{
				'='
			});
			if (array2.Length == 2)
			{
				string string_ = array2[0].Trim();
				string string_2 = array2[1].Trim();
				Class3.smethod_8(string_, string_2, object_0);
			}
		}
		return object_0;
	}

	public Class3()
	{
		Class90.TDroV38zslI2T();
		base..ctor();
	}

	internal class Class4
	{
		public int A
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		public int R
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		public int method_0()
		{
			return this.int_2;
		}

		public void method_1(int int_4)
		{
			this.int_2 = int_4;
		}

		public int B
		{
			get
			{
				return this.int_3;
			}
			set
			{
				this.int_3 = value;
			}
		}

		public Color Color
		{
			get
			{
				return Color.FromArgb(this.int_0, this.int_1, this.int_2, this.int_3);
			}
		}

		public Class4()
		{
			Class90.TDroV38zslI2T();
			base..ctor();
		}

		private int int_0;

		private int int_1;

		private int int_2;

		private int int_3;
	}
}
