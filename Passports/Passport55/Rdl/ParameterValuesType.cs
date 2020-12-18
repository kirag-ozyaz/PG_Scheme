using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DebuggerStepThrough]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class ParameterValuesType
	{
		[XmlElement("ParameterValue")]
		public ParameterValueType[] ParameterValue
		{
			get
			{
				return this.parameterValueField;
			}
			set
			{
				this.parameterValueField = value;
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

		private ParameterValueType[] parameterValueField;

		private XmlAttribute[] anyAttrField;
	}
}
