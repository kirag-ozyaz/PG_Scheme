using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	[DebuggerStepThrough]
	[XmlRoot("Data")]
	[Serializable]
	public class Data
	{
		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Type
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
			}
		}

		[XmlText]
		public string Value
		{
			get
			{
				return this.string_1;
			}
			set
			{
				this.string_1 = value;
			}
		}

		public Data()
		{
			
			
		}

		private string string_0;

		private string string_1;
	}
}
