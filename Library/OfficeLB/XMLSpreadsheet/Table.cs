using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	[DebuggerStepThrough]
	[XmlRoot("Table")]
	[Serializable]
	public class Table
	{
		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string ExpandedColumnCount
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
		public string ExpandedRowCount
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string FullColumns
		{
			get
			{
				return this.string_2;
			}
			set
			{
				this.string_2 = value;
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string FullRows
		{
			get
			{
				return this.string_3;
			}
			set
			{
				this.string_3 = value;
			}
		}

		[XmlElement("Column", typeof(Column))]
		public Column[] Columns
		{
			get
			{
				return this.column_0;
			}
			set
			{
				this.column_0 = value;
			}
		}

		[XmlElement("Row", typeof(Row))]
		public Row[] Rows
		{
			get
			{
				return this.row_0;
			}
			set
			{
				this.row_0 = value;
			}
		}

		public Table()
		{
			
			
		}

		private Row[] row_0;

		private Column[] column_0;

		private string string_0;

		private string string_1;

		private string string_2;

		private string string_3;
	}
}
