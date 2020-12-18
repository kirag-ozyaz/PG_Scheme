using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[Serializable]
	public class ThreeDPropertiesType
	{
		[XmlElement("Rotation", typeof(string), DataType = "integer")]
		[XmlElement("Clustered", typeof(bool))]
		[XmlElement("Enabled", typeof(bool))]
		[XmlElement("GapDepth", typeof(uint))]
		[XmlElement("HeightRatio", typeof(uint))]
		[XmlElement("Inclination", typeof(string), DataType = "integer")]
		[XmlElement("Perspective", typeof(uint))]
		[XmlElement("ProjectionMode", typeof(ThreeDPropertiesTypeProjectionMode))]
		[XmlElement("Shading", typeof(ThreeDPropertiesTypeShading))]
		[XmlElement("WallThickness", typeof(uint))]
		[XmlAnyElement]
		[XmlElement("DepthRatio", typeof(uint))]
		[XmlElement("DrawingStyle", typeof(ThreeDPropertiesTypeDrawingStyle))]
		[XmlChoiceIdentifier("ItemsElementName")]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		[XmlIgnore]
		[XmlElement("ItemsElementName")]
		public ItemsChoiceType26[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}

		[XmlAnyAttribute]
		public XmlAttribute[] AnyAttr
		{
			get
			{
				return this.anyAttrField;
			}
			set
			{
				this.anyAttrField = value;
			}
		}

		private object[] itemsField;

		private ItemsChoiceType26[] itemsElementNameField;

		private XmlAttribute[] anyAttrField;
	}
}
