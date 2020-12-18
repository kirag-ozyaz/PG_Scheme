using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class DataGroupingsType
	{
		[XmlElement("DataGrouping")]
		public DataGroupingType[] DataGrouping
		{
			get
			{
				return this.dataGroupingType_0;
			}
			set
			{
				this.dataGroupingType_0 = value;
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

		public DataGroupingsType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private DataGroupingType[] dataGroupingType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
