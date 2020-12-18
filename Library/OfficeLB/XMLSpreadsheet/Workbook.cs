using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	[XmlRoot(ElementName = "Workbook", Namespace = "urn:schemas-microsoft-com:office:spreadsheet", IsNullable = false)]
	[DebuggerStepThrough]
	[Serializable]
	public class Workbook
	{
		[XmlElement("DocumentProperties", typeof(DocumentProperties), Namespace = "urn:schemas-microsoft-com:office:office")]
		public DocumentProperties DocumentProperties
		{
			get
			{
				return this.documentProperties_0;
			}
			set
			{
				this.documentProperties_0 = value;
			}
		}

		[XmlElement("ExcelWorkbook", typeof(ExcelWorkbook), Namespace = "urn:schemas-microsoft-com:office:excel")]
		public ExcelWorkbook ExcelWorkBook
		{
			get
			{
				return this.excelWorkbook_0;
			}
			set
			{
				this.excelWorkbook_0 = value;
			}
		}

		[XmlElement("Styles")]
		public Styles Styles
		{
			get
			{
				return this.styles_0;
			}
			set
			{
				this.styles_0 = value;
			}
		}

		[XmlElement("Worksheet", typeof(Worksheet), Namespace = "urn:schemas-microsoft-com:office:spreadsheet")]
		public Worksheet[] Worksheets
		{
			get
			{
				return this.worksheet_0;
			}
			set
			{
				this.worksheet_0 = value;
			}
		}

		public Workbook()
		{
			
			
		}

		private ExcelWorkbook excelWorkbook_0;

		private DocumentProperties documentProperties_0;

		private Styles styles_0;

		private Worksheet[] worksheet_0;
	}
}
