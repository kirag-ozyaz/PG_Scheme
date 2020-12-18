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
	public class QueryParametersType
	{
		[XmlElement("QueryParameter")]
		public QueryParameterType[] QueryParameter
		{
			get
			{
				return this.queryParameterType_0;
			}
			set
			{
				this.queryParameterType_0 = value;
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

		public QueryParametersType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private QueryParameterType[] queryParameterType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
