using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DebuggerStepThrough]
	[Serializable]
	public class CustomReportItemType
	{
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("Type", typeof(string))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("CustomData", typeof(CustomDataType))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("DataElementOutput", typeof(CustomReportItemTypeDataElementOutput))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("Label", typeof(string))]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlElement("AltReportItem", typeof(ReportItemsType))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlAnyElement]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("ZIndex", typeof(uint))]
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
		public ItemsChoiceType29[] ItemsElementName
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

		private ItemsChoiceType29[] itemsElementNameField;

		private string nameField;

		private XmlAttribute[] anyAttrField;
	}
}
