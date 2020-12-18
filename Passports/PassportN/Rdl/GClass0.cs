using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DebuggerStepThrough]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class GClass0
	{
		[XmlElement("GapDepth", typeof(uint))]
		[XmlElement("HeightRatio", typeof(uint))]
		[XmlElement("Inclination", typeof(string), DataType = "integer")]
		[XmlElement("Perspective", typeof(uint))]
		[XmlElement("Enabled", typeof(bool))]
		[XmlElement("Clustered", typeof(bool))]
		[XmlAnyElement]
		[XmlElement("DrawingStyle", typeof(ThreeDPropertiesTypeDrawingStyle))]
		[XmlElement("DepthRatio", typeof(uint))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("WallThickness", typeof(uint))]
		[XmlElement("Shading", typeof(ThreeDPropertiesTypeShading))]
		[XmlElement("ProjectionMode", typeof(ThreeDPropertiesTypeProjectionMode))]
		[XmlElement("Rotation", typeof(string), DataType = "integer")]
		public object[] Items
		{
			get
			{
				return this.object_0;
			}
			set
			{
				this.object_0 = value;
			}
		}

		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType26[] ItemsElementName
		{
			get
			{
				return this.LxLmkeWwev;
			}
			set
			{
				this.LxLmkeWwev = value;
			}
		}

		[XmlAnyAttribute]
		public XmlAttribute[] AnyAttr
		{
			get
			{
				return this.xmlAttribute_0;
			}
			set
			{
				this.xmlAttribute_0 = value;
			}
		}

		public GClass0()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType26[] LxLmkeWwev;

		private XmlAttribute[] xmlAttribute_0;
	}
}
