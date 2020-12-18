using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class RowGroupingsType
	{
		[XmlElement("RowGrouping")]
		public RowGroupingType[] RowGrouping
		{
			get
			{
				return this.rowGroupingType_0;
			}
			set
			{
				this.rowGroupingType_0 = value;
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

		public RowGroupingsType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private RowGroupingType[] rowGroupingType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
