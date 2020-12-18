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
	public class RowGroupingsType
	{
		[XmlElement("RowGrouping")]
		public RowGroupingType[] RowGrouping
		{
			get
			{
				return this.rowGroupingField;
			}
			set
			{
				this.rowGroupingField = value;
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

		private RowGroupingType[] rowGroupingField;

		private XmlAttribute[] anyAttrField;
	}
}
