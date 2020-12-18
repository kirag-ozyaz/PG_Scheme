using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	[XmlRoot("Worksheet", Namespace = "urn:schemas-microsoft-com:office:spreadsheet", IsNullable = false)]
	[DebuggerStepThrough]
	[Serializable]
	public class Worksheet
	{
		[XmlAttribute(AttributeName = "Name", Form = XmlSchemaForm.Qualified)]
		public string Name
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

		[XmlElement("Table")]
		public Table Table
		{
			get
			{
				return this.table_0;
			}
			set
			{
				this.table_0 = value;
			}
		}

		[XmlElement("WorksheetOptions", typeof(WorksheetOptions), Namespace = "urn:schemas-microsoft-com:office:excel")]
		public WorksheetOptions WorksheetOptions
		{
			get
			{
				return this.worksheetOptions_0;
			}
			set
			{
				this.worksheetOptions_0 = value;
			}
		}

		public Worksheet()
		{
			
			
		}

		private string string_0;

		private Table table_0;

		private WorksheetOptions worksheetOptions_0;
	}
}
