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
	public class LineType
	{
		[XmlElement("DataElementOutput", typeof(LineTypeDataElementOutput))]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("Label", typeof(string))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlElement("Action", typeof(ActionType))]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlAnyElement]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
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
		public ItemsChoiceType11[] ItemsElementName
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

		private ItemsChoiceType11[] itemsElementNameField;

		private string nameField;

		private XmlAttribute[] anyAttrField;
	}
}
