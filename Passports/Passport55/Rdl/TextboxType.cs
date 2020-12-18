using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[Serializable]
	public class TextboxType
	{
		[XmlElement("DataElementStyle", typeof(TextboxTypeDataElementStyle))]
		[XmlElement("Value", typeof(string))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("HideDuplicates", typeof(string))]
		[XmlElement("Label", typeof(string))]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("ToggleImage", typeof(ToggleImageType))]
		[XmlElement("DataElementOutput", typeof(TextboxTypeDataElementOutput))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("UserSort", typeof(UserSortType))]
		[XmlAnyElement]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("Action", typeof(ActionType))]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("CanGrow", typeof(bool))]
		[XmlElement("CanShrink", typeof(bool))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
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

		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType14[] ItemsElementName
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

		[XmlAttribute(DataType = "normalizedString")]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
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

		private ItemsChoiceType14[] itemsElementNameField;

		private string nameField;

		private XmlAttribute[] anyAttrField;
	}
}
