using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public enum ItemsChoiceType27
	{
		[XmlEnum("##any:")]
		Item,
		Action,
		Bookmark,
		CategoryAxis,
		CategoryGroupings,
		ChartData,
		ChartElementOutput,
		CustomProperties,
		DataElementName,
		DataElementOutput,
		DataSetName,
		Filters,
		Height,
		KeepTogether,
		Label,
		Left,
		Legend,
		LinkToChild,
		NoRows,
		PageBreakAtEnd,
		PageBreakAtStart,
		Palette,
		PlotArea,
		PointWidth,
		SeriesGroupings,
		Style,
		Subtype,
		ThreeDProperties,
		Title,
		ToolTip,
		Top,
		Type,
		ValueAxis,
		Visibility,
		Width,
		ZIndex
	}
}
