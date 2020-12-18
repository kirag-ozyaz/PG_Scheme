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
	public class ChartDataType
	{
		[XmlElement("ChartSeries")]
		public ChartSeriesType[] ChartSeries
		{
			get
			{
				return this.chartSeriesField;
			}
			set
			{
				this.chartSeriesField = value;
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

		private ChartSeriesType[] chartSeriesField;

		private XmlAttribute[] anyAttrField;
	}
}
