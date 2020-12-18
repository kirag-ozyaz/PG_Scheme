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
	public class CustomPropertiesType
	{
		[XmlElement("CustomProperty")]
		public CustomPropertyType[] CustomProperty
		{
			get
			{
				return this.customPropertyType_0;
			}
			set
			{
				this.customPropertyType_0 = value;
			}
		}

		[XmlAnyAttribute]
		public XmlAttribute[] AnyAttr
		{
			get
			{
				return this.LmXmjFxqod;
			}
			set
			{
				this.LmXmjFxqod = value;
			}
		}

		public CustomPropertiesType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private CustomPropertyType[] customPropertyType_0;

		private XmlAttribute[] LmXmjFxqod;
	}
}
