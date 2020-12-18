using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
	[Serializable]
	public enum ItemsChoiceType14
	{
		[XmlEnum("##any:")]
		Item,
		Action,
		Bookmark,
		CanGrow,
		CanShrink,
		CustomProperties,
		DataElementName,
		DataElementOutput,
		DataElementStyle,
		Height,
		HideDuplicates,
		Label,
		Left,
		LinkToChild,
		RepeatWith,
		Style,
		ToggleImage,
		ToolTip,
		Top,
		UserSort,
		Value,
		Visibility,
		Width,
		ZIndex
	}
}
