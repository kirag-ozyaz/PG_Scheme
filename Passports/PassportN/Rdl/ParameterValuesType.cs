using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[Serializable]
	public class ParameterValuesType
	{
		[XmlElement("ParameterValue")]
		public ParameterValueType[] ParameterValue
		{
			get
			{
				return this.parameterValueType_0;
			}
			set
			{
				this.parameterValueType_0 = value;
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

		public ParameterValuesType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private ParameterValueType[] parameterValueType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
