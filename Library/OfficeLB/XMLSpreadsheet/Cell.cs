using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	[XmlRoot]
	[DebuggerStepThrough]
	[Serializable]
	public class Cell
	{
		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string StyleID
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

		public Data Data
		{
			get
			{
				return this.data_0;
			}
			set
			{
				this.data_0 = value;
			}
		}

		public Cell()
		{
			
			
		}

		private Data data_0;

		private string string_0;
	}
}
