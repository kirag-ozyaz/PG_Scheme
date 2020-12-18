using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DebuggerStepThrough]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class TableCellsType
	{
		[XmlElement("TableCell")]
		public TableCellType[] TableCell
		{
			get
			{
				return this.tableCellType_0;
			}
			set
			{
				this.tableCellType_0 = value;
			}
		}

		[XmlAnyAttribute]
		public XmlAttribute[] AnyAttr
		{
			get
			{
				return this.xmlAttribute_0;
			}
			set
			{
				this.xmlAttribute_0 = value;
			}
		}

		public TableCellsType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private TableCellType[] tableCellType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
