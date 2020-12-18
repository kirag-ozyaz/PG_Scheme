using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType25
	{
		[XmlEnum("##any:")]
		Item,
		CrossAt,
		Interlaced,
		LogScale,
		MajorGridLines,
		MajorInterval,
		MajorTickMarks,
		Margin,
		Max,
		Min,
		MinorGridLines,
		MinorInterval,
		MinorTickMarks,
		Reverse,
		Scalar,
		Style,
		Title,
		Visible
	}
}
