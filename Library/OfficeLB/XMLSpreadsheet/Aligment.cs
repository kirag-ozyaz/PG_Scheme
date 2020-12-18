using System;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	public class Aligment
	{
		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Vertical { get; set; }

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Horizontal { get; set; }

		public Aligment()
		{
			
			
		}

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;
	}
}
