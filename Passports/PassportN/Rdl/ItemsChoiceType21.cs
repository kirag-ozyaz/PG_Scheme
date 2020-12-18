using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public enum ItemsChoiceType21
	{
		[XmlEnum("##any:")]
		Item,
		Action,
		Bookmark,
		CustomProperties,
		DataElementName,
		DataElementOutput,
		DataSetName,
		DetailDataCollectionName,
		DetailDataElementName,
		DetailDataElementOutput,
		Details,
		FillPage,
		Filters,
		Footer,
		Header,
		Height,
		KeepTogether,
		Label,
		Left,
		LinkToChild,
		NoRows,
		PageBreakAtEnd,
		PageBreakAtStart,
		RepeatWith,
		Style,
		TableColumns,
		TableGroups,
		ToolTip,
		Top,
		Visibility,
		Width,
		ZIndex
	}
}
