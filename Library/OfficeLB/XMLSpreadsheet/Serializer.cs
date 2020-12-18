using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	public class Serializer
	{
		public static string SerializeObject(object obj, Type type)
		{
			XmlSerializerNamespaces namespaces = Serializer.smethod_0();
			MemoryStream memoryStream = new MemoryStream();
			XmlSerializer xmlSerializer = new XmlSerializer(type);
			XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
			xmlSerializer.Serialize(new NonXsiTextWriter(memoryStream, Encoding.UTF8), obj, namespaces);
			memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
			return TypeConvert.UTF8ByteArrayToString(memoryStream.ToArray());
		}

		private static XmlSerializerNamespaces smethod_0()
		{
			XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
			xmlSerializerNamespaces.Add("o", "urn:schemas-microsoft-com:office:office");
			xmlSerializerNamespaces.Add("x", "urn:schemas-microsoft-com:office:excel");
			xmlSerializerNamespaces.Add("ss", "urn:schemas-microsoft-com:office:spreadsheet");
			xmlSerializerNamespaces.Add("html", "http://www.w3.org/TR/REC-html40");
			return xmlSerializerNamespaces;
		}

		public static object DeserializeObject(string xmlizedString, Type type)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(type);
			MemoryStream stream = new MemoryStream(TypeConvert.StringToUTF8ByteArray(xmlizedString));
			return xmlSerializer.Deserialize(stream);
		}

		public Serializer()
		{
			
			
		}
	}
}
