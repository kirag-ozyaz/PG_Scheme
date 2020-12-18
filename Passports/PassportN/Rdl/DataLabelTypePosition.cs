using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(AnonymousType = true)]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public enum DataLabelTypePosition
	{
		Auto,
		Top,
		TopLeft,
		TopRight,
		Left,
		Center,
		Right,
		BottomLeft,
		Bottom,
		BottomRight
	}
}
