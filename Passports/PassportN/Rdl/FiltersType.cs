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
	public class FiltersType
	{
		[XmlElement("Filter")]
		public FilterType[] Filter
		{
			get
			{
				return this.filterType_0;
			}
			set
			{
				this.filterType_0 = value;
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

		public FiltersType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private FilterType[] filterType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
