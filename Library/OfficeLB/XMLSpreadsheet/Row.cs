using System;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OfficeLB.XMLSpreadsheet
{
	[DebuggerStepThrough]
	[XmlRoot("Row")]
	[Serializable]
	public class Row
	{
		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string AutoFitHeight
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
		public string Height
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
		public string StyleID
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

		[XmlElement("Cell", typeof(Cell))]
		public Cell[] Cells
		{
			get
			{
				return this.cell_0;
			}
			set
			{
				this.cell_0 = value;
			}
		}

		public Row()
		{
			
			
		}

		private Cell[] cell_0;

		private string string_0;

		private string string_1;

		private string string_2;
	}
}
