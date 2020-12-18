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
	public class FilterValuesType
	{
		[XmlElement("FilterValue")]
		public string[] FilterValue
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
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

		public FilterValuesType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private string[] string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
