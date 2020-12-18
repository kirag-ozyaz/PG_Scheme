using System;
using System.Reflection;
using System.Xml;
using SchemeCtrl2.Xml;

internal class Class101
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
		PropertyInfo property = PropertyUtil.GetProperty(object_0, attribute);
		if (property != null && property.CanWrite)
		{
			try
			{
				object obj = PropertyUtil.ChangeType(attribute2, property.PropertyType);
				if (obj != null)
				{
					property.SetValue(object_0, obj, null);
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
			XmlElement xmlElement_ = (XmlElement)obj;
			Class101.smethod_1(xmlElement_, object_0);
		}
	}

	public static void smethod_3(object object_0, XmlWriter xmlWriter_0)
	{
		foreach (PropertyInfo propertyInfo in object_0.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
		{
			XmlSerializable xmlSerializable = (XmlSerializable)Attribute.GetCustomAttribute(propertyInfo, typeof(XmlSerializable));
			if (xmlSerializable != null)
			{
				string name = propertyInfo.Name;
				object value = propertyInfo.GetValue(object_0, null);
				if (value != null)
				{
					Class101.smethod_0(name, value, xmlWriter_0);
				}
			}
		}
	}
}
