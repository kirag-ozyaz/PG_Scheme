using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DesignerCategory("code")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[Serializable]
	public class ColumnGroupingsType
	{
		[XmlElement("ColumnGrouping")]
		public ColumnGroupingType[] ColumnGrouping
		{
			get
			{
				return this.columnGroupingType_0;
			}
			set
			{
				this.columnGroupingType_0 = value;
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

		public ColumnGroupingsType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private ColumnGroupingType[] columnGroupingType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
