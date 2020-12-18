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
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DebuggerStepThrough]
	[Serializable]
	public class ReportParametersType
	{
		[XmlElement("ReportParameter")]
		public ReportParameterType[] ReportParameter
		{
			get
			{
				return this.reportParameterField;
			}
			set
			{
				this.reportParameterField = value;
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

		private ReportParameterType[] reportParameterField;

		private XmlAttribute[] anyAttrField;
	}
}
