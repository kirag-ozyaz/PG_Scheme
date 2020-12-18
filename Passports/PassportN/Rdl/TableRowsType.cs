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
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[Serializable]
	public class TableRowsType
	{
		[XmlElement("TableRow")]
		public TableRowType[] TableRow
		{
			get
			{
				return this.tableRowType_0;
			}
			set
			{
				this.tableRowType_0 = value;
			}
		}

		[XmlAnyAttribute]
		public XmlAttribute[] AnyAttr
		{
			get
			{
				return this.UrEaRduPaX;
			}
			set
			{
				this.UrEaRduPaX = value;
			}
		}

		public TableRowsType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private TableRowType[] tableRowType_0;

		private XmlAttribute[] UrEaRduPaX;
	}
}
