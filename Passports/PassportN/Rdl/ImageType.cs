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
	public class ImageType
	{
		[XmlElement("Source", typeof(ImageTypeSource))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("Sizing", typeof(ImageTypeSizing))]
		[XmlElement("Value", typeof(string))]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlAnyElement]
		[XmlElement("Action", typeof(ActionType))]
		[XmlElement("MIMEType", typeof(string))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("DataElementOutput", typeof(ImageTypeDataElementOutput))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("Label", typeof(string))]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
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

		[XmlIgnore]
		[XmlElement("ItemsElementName")]
		public ItemsChoiceType15[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType15_0;
			}
			set
			{
				this.itemsChoiceType15_0 = value;
			}
		}

		[XmlAttribute(DataType = "normalizedString")]
		public string Name
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
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

		public ImageType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType15[] itemsChoiceType15_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
