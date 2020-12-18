using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class TableType
	{
		[XmlElement("Label", typeof(string))]
		[XmlElement("KeepTogether", typeof(bool))]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("PageBreakAtEnd", typeof(bool))]
		[XmlElement("NoRows", typeof(string))]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("PageBreakAtStart", typeof(bool))]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlElement("TableColumns", typeof(TableColumnsType))]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("TableGroups", typeof(TableGroupsType))]
		[XmlElement("DataSetName", typeof(string))]
		[XmlElement("DataElementOutput", typeof(TableTypeDataElementOutput))]
		[XmlElement("DetailDataElementName", typeof(string))]
		[XmlElement("DetailDataCollectionName", typeof(string))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("Action", typeof(ActionType))]
		[XmlAnyElement]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("DetailDataElementOutput", typeof(TableTypeDetailDataElementOutput))]
		[XmlElement("FillPage", typeof(bool))]
		[XmlElement("Filters", typeof(FiltersType))]
		[XmlElement("Footer", typeof(FooterType))]
		[XmlElement("Header", typeof(HeaderType))]
		[XmlElement("Details", typeof(DetailsType))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
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
		public ItemsChoiceType21[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType21_0;
			}
			set
			{
				this.itemsChoiceType21_0 = value;
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

		public TableType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType21[] itemsChoiceType21_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
