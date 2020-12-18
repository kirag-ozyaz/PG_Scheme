using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public enum ItemsChoiceType26
	{
		[XmlEnum("##any:")]
		Item,
		Clustered,
		DepthRatio,
		DrawingStyle,
		Enabled,
		GapDepth,
		HeightRatio,
		Inclination,
		Perspective,
		ProjectionMode,
		Rotation,
		Shading,
		WallThickness
	}
}
