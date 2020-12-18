using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class TableColumnsType
	{
		[XmlElement("TableColumn")]
		public TableColumnType[] TableColumn
		{
			get
			{
				return this.tableColumnType_0;
			}
			set
			{
				this.tableColumnType_0 = value;
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

		public TableColumnsType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private TableColumnType[] tableColumnType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
