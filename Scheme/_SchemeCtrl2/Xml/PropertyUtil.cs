using System;
using System.Drawing;
using System.Reflection;
using SchemeCtrl2.Canvas;

namespace SchemeCtrl2.Xml
{
	public class PropertyUtil
	{
		private static PropertyInfo smethod_0(object object_0, string[] string_0, int int_0, ref object object_1)
		{
			object_1 = object_0;
			string propertyname = string_0[int_0];
			PropertyInfo property = PropertyUtil.GetProperty(object_0, propertyname);
			if (property == null)
			{
				return null;
			}
			object_0 = property.GetValue(object_0, null);
			int_0++;
			if (int_0 == string_0.Length)
			{
				return property;
			}
			return PropertyUtil.smethod_0(object_0, string_0, int_0, ref object_1);
		}

		public static PropertyInfo GetNestedProperty(object dataobject, ref object nestedDataObject, string fullFieldname)
		{
			string[] string_ = fullFieldname.Split(new char[]
			{
				'.'
			});
			return PropertyUtil.smethod_0(dataobject, string_, 0, ref nestedDataObject);
		}

		public static PropertyInfo GetNestedProperty(ref object dataobject, string fullFieldname)
		{
			return PropertyUtil.GetNestedProperty(dataobject, ref dataobject, fullFieldname);
		}

		public static PropertyInfo GetProperty(object dataobject, string propertyname)
		{
			if (dataobject == null)
			{
				return null;
			}
			return PropertyUtil.GetProperty(dataobject.GetType(), propertyname);
		}

		public static PropertyInfo GetProperty(Type dataobjecttype, string propertyname)
		{
			MemberInfo[] member = dataobjecttype.GetMember(propertyname);
			foreach (MemberInfo memberInfo in member)
			{
				PropertyInfo propertyInfo = memberInfo as PropertyInfo;
				if (propertyInfo != null)
				{
					return propertyInfo;
				}
			}
			return null;
		}

		private static bool smethod_1(object object_0)
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

		public static object ChangeType(object value, Type type)
		{
			if (type == typeof(UnitPoint))
			{
				return PropertyUtil.Parse(value.ToString(), type);
			}
			if (value.GetType() == type)
			{
				return value;
			}
			if (value.GetType() == typeof(string) && type.IsEnum)
			{
				try
				{
					return Enum.Parse(type, value.ToString());
				}
				catch
				{
				}
			}
			if (!type.IsPrimitive)
			{
				object obj = PropertyUtil.Parse(value.ToString(), type);
				if (obj != null)
				{
					return obj;
				}
			}
			try
			{
				return Convert.ChangeType(value, type);
			}
			catch
			{
			}
			return null;
		}

		public static object Parse(string value, Type type)
		{
			if (type == typeof(UnitPoint))
			{
				return PropertyUtil.Parse(new UnitPoint(0.0, 0.0), value);
			}
			if (type == typeof(SizeF))
			{
				return PropertyUtil.Parse(new SizeF(0f, 0f), value);
			}
			if (type == typeof(PointF))
			{
				return PropertyUtil.Parse(new PointF(0f, 0f), value);
			}
			if (type == typeof(Color))
			{
				value = value.Replace("Color ", "");
				value = value.Trim(new char[]
				{
					'[',
					']'
				});
				Color color = Color.FromName(value);
				if (color.IsKnownColor)
				{
					return color;
				}
				PropertyUtil.Class1 @class = new PropertyUtil.Class1();
				PropertyUtil.Parse(@class, value);
				return @class.method_8();
			}
			else
			{
				if (type == typeof(RectangleF))
				{
					return PropertyUtil.Parse(new RectangleF(0f, 0f, 0f, 0f), value);
				}
				return null;
			}
		}

		public static void ParseProperty(string fieldname, string svalue, object dataobject)
		{
			if (fieldname.Length == 0 || svalue.Length == 0)
			{
				return;
			}
			PropertyInfo property = PropertyUtil.GetProperty(dataobject, fieldname);
			if (property != null && property.CanWrite)
			{
				try
				{
					object obj = PropertyUtil.ChangeType(svalue, property.PropertyType);
					if (obj != null)
					{
						property.SetValue(dataobject, obj, null);
					}
				}
				catch
				{
				}
				return;
			}
		}

		public static object Parse(object object_0, string valuestring)
		{
			valuestring = valuestring.Trim(new char[]
			{
				'{',
				'}'
			});
			string[] array = valuestring.Split(new char[]
			{
				','
			});
			foreach (string text in array)
			{
				string[] array3 = text.Split(new char[]
				{
					'='
				});
				if (array3.Length == 2)
				{
					string fieldname = array3[0].Trim();
					string svalue = array3[1].Trim();
					PropertyUtil.ParseProperty(fieldname, svalue, object_0);
				}
			}
			return object_0;
		}

		internal class Class1
		{
			public int method_0()
			{
				return this.int_0;
			}

			public void method_1(int int_4)
			{
				this.int_0 = int_4;
			}

			public int method_2()
			{
				return this.int_1;
			}

			public void method_3(int int_4)
			{
				this.int_1 = int_4;
			}

			public int method_4()
			{
				return this.int_2;
			}

			public void method_5(int int_4)
			{
				this.int_2 = int_4;
			}

			public int method_6()
			{
				return this.int_3;
			}

			public void method_7(int int_4)
			{
				this.int_3 = int_4;
			}

			public Color method_8()
			{
				return Color.FromArgb(this.int_0, this.int_1, this.int_2, this.int_3);
			}

			private int int_0;

			private int int_1;

			private int int_2;

			private int int_3;
		}
	}
}
