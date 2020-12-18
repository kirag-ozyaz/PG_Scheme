using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DesignerCategory("code")]
	[Serializable]
	public class DataPointsType
	{
		[XmlElement("DataPoint")]
		public DataPointType[] DataPoint
		{
			get
			{
				return this.dataPointType_0;
			}
			set
			{
				this.dataPointType_0 = value;
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

		public DataPointsType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private DataPointType[] dataPointType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
