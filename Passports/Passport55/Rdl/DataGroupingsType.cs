using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DesignerCategory("code")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DebuggerStepThrough]
	[Serializable]
	public class DataGroupingsType
	{
		[XmlElement("DataGrouping")]
		public DataGroupingType[] DataGrouping
		{
			get
			{
				return this.dataGroupingField;
			}
			set
			{
				this.dataGroupingField = value;
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

		private DataGroupingType[] dataGroupingField;

		private XmlAttribute[] anyAttrField;
	}
}
