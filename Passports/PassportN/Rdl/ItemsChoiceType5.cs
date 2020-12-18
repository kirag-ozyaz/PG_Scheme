using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public enum ItemsChoiceType5
	{
		[XmlEnum("##any:")]
		Item,
		BackgroundColor,
		BackgroundGradientEndColor,
		BackgroundGradientType,
		BackgroundImage,
		BorderColor,
		BorderStyle,
		BorderWidth,
		Calendar,
		Color,
		Direction,
		FontFamily,
		FontSize,
		FontStyle,
		FontWeight,
		Format,
		Language,
		LineHeight,
		NumeralLanguage,
		NumeralVariant,
		PaddingBottom,
		PaddingLeft,
		PaddingRight,
		PaddingTop,
		TextAlign,
		TextDecoration,
		UnicodeBiDi,
		VerticalAlign,
		WritingMode
	}
}
