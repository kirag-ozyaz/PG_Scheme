using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IncludeInSchema = false)]
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
