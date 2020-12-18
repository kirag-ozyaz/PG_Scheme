using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[Serializable]
	public class TextboxType
	{
		[XmlElement("Action", typeof(ActionType))]
		[XmlAnyElement]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("HideDuplicates", typeof(string))]
		[XmlElement("UserSort", typeof(UserSortType))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("Label", typeof(string))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("DataElementOutput", typeof(TextboxTypeDataElementOutput))]
		[XmlElement("DataElementStyle", typeof(TextboxTypeDataElementStyle))]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("CanShrink", typeof(bool))]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("CanGrow", typeof(bool))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("Value", typeof(string))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("ToggleImage", typeof(ToggleImageType))]
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
		public ItemsChoiceType14[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType14_0;
			}
			set
			{
				this.itemsChoiceType14_0 = value;
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

		public TextboxType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType14[] itemsChoiceType14_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
