using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public enum ItemsChoiceType19
	{
		[XmlEnum("##any:")]
		Item,
		Action,
		Bookmark,
		CellDataElementName,
		CellDataElementOutput,
		ColumnGroupings,
		Corner,
		CustomProperties,
		DataElementName,
		DataElementOutput,
		DataSetName,
		Filters,
		GroupsBeforeRowHeaders,
		Height,
		KeepTogether,
		Label,
		LayoutDirection,
		Left,
		LinkToChild,
		MatrixColumns,
		MatrixRows,
		NoRows,
		PageBreakAtEnd,
		PageBreakAtStart,
		RepeatWith,
		RowGroupings,
		Style,
		ToolTip,
		Top,
		Visibility,
		Width,
		ZIndex
	}
}
