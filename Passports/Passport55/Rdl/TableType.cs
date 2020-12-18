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
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DesignerCategory("code")]
	[Serializable]
	public class TableType
	{
		[XmlElement("KeepTogether", typeof(bool))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("DataElementOutput", typeof(TableTypeDataElementOutput))]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("NoRows", typeof(string))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Action", typeof(ActionType))]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("DataSetName", typeof(string))]
		[XmlElement("DetailDataCollectionName", typeof(string))]
		[XmlElement("DetailDataElementName", typeof(string))]
		[XmlElement("DetailDataElementOutput", typeof(TableTypeDetailDataElementOutput))]
		[XmlElement("Details", typeof(DetailsType))]
		[XmlElement("FillPage", typeof(bool))]
		[XmlElement("Filters", typeof(FiltersType))]
		[XmlElement("Footer", typeof(FooterType))]
		[XmlElement("Header", typeof(HeaderType))]
		[XmlAnyElement]
		[XmlElement("Label", typeof(string))]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("PageBreakAtEnd", typeof(bool))]
		[XmlElement("PageBreakAtStart", typeof(bool))]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("TableColumns", typeof(TableColumnsType))]
		[XmlElement("TableGroups", typeof(TableGroupsType))]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
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

		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType21[] ItemsElementName
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

		private ItemsChoiceType21[] itemsElementNameField;

		private string nameField;

		private XmlAttribute[] anyAttrField;
	}
}
