using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[Serializable]
	public class SortingType
	{
		[XmlElement("SortBy")]
		public SortByType[] SortBy
		{
			get
			{
				return this.sortByType_0;
			}
			set
			{
				this.sortByType_0 = value;
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

		public SortingType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private SortByType[] sortByType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
