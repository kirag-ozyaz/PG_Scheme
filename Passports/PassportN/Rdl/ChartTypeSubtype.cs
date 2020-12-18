using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(AnonymousType = true)]
	[Serializable]
	public enum ChartTypeSubtype
	{
		Stacked,
		PercentStacked,
		Plain,
		Smooth,
		Exploded,
		Line,
		SmoothLine,
		HighLowClose,
		OpenHighLowClose,
		Candlestick
	}
}
