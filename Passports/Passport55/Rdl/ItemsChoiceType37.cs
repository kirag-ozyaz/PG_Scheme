using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public enum ItemsChoiceType37
	{
		[XmlEnum("##any:")]
		Item,
		Author,
		AutoRefresh,
		Body,
		BottomMargin,
		Classes,
		Code,
		CodeModules,
		CustomProperties,
		DataElementName,
		DataElementStyle,
		DataSchema,
		DataSets,
		DataSources,
		DataTransform,
		Description,
		EmbeddedImages,
		InteractiveHeight,
		InteractiveWidth,
		Language,
		LeftMargin,
		PageFooter,
		PageHeader,
		PageHeight,
		PageWidth,
		ReportParameters,
		RightMargin,
		TopMargin,
		Width
	}
}
