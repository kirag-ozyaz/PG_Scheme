using System;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	public class Font
	{
		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string FontName { get; set; }

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Size { get; set; }

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Bold { get; set; }

		public Font()
		{
			
			
		}

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private string string_2;
	}
}
