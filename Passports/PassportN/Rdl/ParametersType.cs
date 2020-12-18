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
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[Serializable]
	public class ParametersType
	{
		[XmlElement("Parameter")]
		public ParameterType[] Parameter
		{
			get
			{
				return this.parameterType_0;
			}
			set
			{
				this.parameterType_0 = value;
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

		public ParametersType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private ParameterType[] parameterType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
