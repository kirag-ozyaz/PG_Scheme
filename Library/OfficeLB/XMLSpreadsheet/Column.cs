using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	[XmlRoot("Column")]
	[DebuggerStepThrough]
	[Serializable]
	public class Column
	{
		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string AutoFitWidth
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string Width
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

		public Column()
		{
			
			
		}

		private string string_0;

		private string string_1;
	}
}
