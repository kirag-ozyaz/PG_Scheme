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
				return this.columnGroupingField;
			}
			set
			{
				this.columnGroupingField = value;
			}
		}

		[XmlAnyAttribute]
		public XmlAttribute[] AnyAttr
		{
			get
			{
				return this.anyAttrField;
			}
			set
			{
				this.anyAttrField = value;
			}
		}

		private ColumnGroupingType[] columnGroupingField;

		private XmlAttribute[] anyAttrField;
	}
}
