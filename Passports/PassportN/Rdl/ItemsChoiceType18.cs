using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType18
	{
		[XmlEnum("##any:")]
		Item,
		Action,
		Bookmark,
		CustomProperties,
		DataElementName,
		DataElementOutput,
		DataInstanceElementOutput,
		DataInstanceName,
		DataSetName,
		FillPage,
		Filters,
		Grouping,
		Height,
		KeepTogether,
		Label,
		Left,
		LinkToChild,
		NoRows,
		PageBreakAtEnd,
		PageBreakAtStart,
		RepeatWith,
		ReportItems,
		Sorting,
		Style,
		ToolTip,
		Top,
		Visibility,
		Width,
		ZIndex
	}
}
