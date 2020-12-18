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
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[Serializable]
	public class SeriesGroupingsType
	{
		[XmlElement("SeriesGrouping")]
		public SeriesGroupingType[] SeriesGrouping
		{
			get
			{
				return this.seriesGroupingType_0;
			}
			set
			{
				this.seriesGroupingType_0 = value;
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

		public SeriesGroupingsType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private SeriesGroupingType[] seriesGroupingType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
