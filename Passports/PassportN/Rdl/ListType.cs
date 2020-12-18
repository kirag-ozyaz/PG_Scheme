using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class ListType
	{
		[XmlElement("PageBreakAtStart", typeof(bool))]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlElement("PageBreakAtEnd", typeof(bool))]
		[XmlElement("DataElementOutput", typeof(ListTypeDataElementOutput))]
		[XmlElement("NoRows", typeof(string))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("Bookmark", typeof(string))]
		[XmlAnyElement]
		[XmlElement("Action", typeof(ActionType))]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("Grouping", typeof(GroupingType))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("Filters", typeof(FiltersType))]
		[XmlElement("FillPage", typeof(bool))]
		[XmlElement("DataSetName", typeof(string))]
		[XmlElement("DataInstanceElementOutput", typeof(ListTypeDataInstanceElementOutput))]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("Label", typeof(string))]
		[XmlElement("KeepTogether", typeof(bool))]
		[XmlElement("DataInstanceName", typeof(string))]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("Sorting", typeof(SortingType))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("ReportItems", typeof(ReportItemsType))]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("Style", typeof(StyleType))]
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
		public ItemsChoiceType18[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType18_0;
			}
			set
			{
				this.itemsChoiceType18_0 = value;
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

		public ListType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType18[] itemsChoiceType18_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
