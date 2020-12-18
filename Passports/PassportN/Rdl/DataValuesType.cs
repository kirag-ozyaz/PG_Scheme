using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class DataValuesType
	{
		[XmlElement("DataValue")]
		public DataValueType[] DataValue
		{
			get
			{
				return this.WfoaJxBdiG;
			}
			set
			{
				this.WfoaJxBdiG = value;
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

		public DataValuesType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private DataValueType[] WfoaJxBdiG;

		private XmlAttribute[] xmlAttribute_0;
	}
}
