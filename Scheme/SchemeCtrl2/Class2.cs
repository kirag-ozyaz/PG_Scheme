using System;
using System.Reflection;
using System.Xml;
using SchemeCtrl2.Xml;

internal class Class2
{
	public static void smethod_0(string string_0, object object_0, XmlWriter xmlWriter_0)
	{
		string text = string.Empty;
		if (object_0 is string)
		{
			text = (object_0 as string);
		}
		if (text.Length == 0 && object_0.GetType() == typeof(float))
		{
			text = XmlConvert.ToString(Math.Round((double)((float)object_0), 8));
		}
		if (text.Length == 0 && object_0.GetType() == typeof(double))
		{
			text = XmlConvert.ToString(Math.Round((double)object_0, 8));
		}
		if (text.Length == 0)
		{
			text = object_0.ToString();
		}
		xmlWriter_0.WriteStartElement("property");
		xmlWriter_0.WriteAttributeString("name", string_0);
		xmlWriter_0.WriteAttributeString("value", text);
		xmlWriter_0.WriteEndElement();
	}

	public static void smethod_1(XmlElement xmlElement_0, object object_0)
	{
		if (xmlElement_0.Name != "property")
		{
			return;
		}
		string attribute = xmlElement_0.GetAttribute("name");
		string attribute2 = xmlElement_0.GetAttribute("value");
		if (attribute.Length == 0 || attribute2.Length == 0)
		{
			return;
		}
		PropertyInfo propertyInfo = Class3.smethod_3(object_0, attribute);
		if (propertyInfo != null && propertyInfo.CanWrite)
		{
			try
			{
				object obj = Class3.smethod_6(attribute2, propertyInfo.PropertyType);
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

	public static void smethod_2(XmlElement xmlElement_0, object object_0)
	{
		foreach (object obj in xmlElement_0.ChildNodes)
		{
			Class2.smethod_1((XmlElement)obj, object_0);
		}
	}

	public static void smethod_3(object object_0, XmlWriter xmlWriter_0)
	{
		foreach (PropertyInfo propertyInfo in object_0.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
		{
			if ((XmlSerializable)Attribute.GetCustomAttribute(propertyInfo, typeof(XmlSerializable)) != null)
			{
				string name = propertyInfo.Name;
				object value = propertyInfo.GetValue(object_0, null);
				if (value != null)
				{
					Class2.smethod_0(name, value, xmlWriter_0);
				}
			}
		}
	}

	public Class2()
	{
		
		
	}
}
