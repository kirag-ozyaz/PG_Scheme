using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public enum ItemsChoiceType17
	{
		[XmlEnum("##any:")]
		Item,
		CustomProperties,
		DataCollectionName,
		DataElementName,
		DataElementOutput,
		Filters,
		GroupExpressions,
		Label,
		PageBreakAtEnd,
		PageBreakAtStart,
		Parent
	}
}
