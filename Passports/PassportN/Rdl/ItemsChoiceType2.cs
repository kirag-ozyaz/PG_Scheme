using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public enum ItemsChoiceType2
	{
		[XmlEnum("##any:")]
		Item,
		CommandText,
		CommandType,
		DataSourceName,
		QueryParameters,
		Timeout
	}
}
