using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DesignerCategory("code")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class StaticColumnType
	{
		[XmlAnyElement]
		[XmlElement("ReportItems", typeof(ReportItemsType))]
		public object[] Items
		{
			get
			{
				return this.vsnEuZyEtD;
			}
			set
			{
				this.vsnEuZyEtD = value;
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

		public StaticColumnType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] vsnEuZyEtD;

		private XmlAttribute[] xmlAttribute_0;
	}
}
