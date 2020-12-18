using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	[DebuggerStepThrough]
	[XmlRoot("Style")]
	[DesignerCategory("code")]
	[Serializable]
	public class Style
	{
		[XmlElement("Font", typeof(Font))]
		public Font Font { get; set; }

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string ID { get; set; }

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Name { get; set; }

		[XmlElement("Aligment", typeof(Aligment))]
		public Aligment Aligment { get; set; }

		public Style()
		{
			
			
		}

		[CompilerGenerated]
		private Font font_0;

		[CompilerGenerated]
		private string string_0;

		[CompilerGenerated]
		private string string_1;

		[CompilerGenerated]
		private Aligment aligment_0;
	}
}
