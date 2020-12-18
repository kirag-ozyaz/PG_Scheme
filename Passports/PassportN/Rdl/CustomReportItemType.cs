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
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[Serializable]
	public class CustomReportItemType
	{
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("AltReportItem", typeof(ReportItemsType))]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlAnyElement]
		[XmlElement("Bookmark", typeof(string))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("CustomData", typeof(CustomDataType))]
		[XmlElement("Label", typeof(string))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("DataElementOutput", typeof(CustomReportItemTypeDataElementOutput))]
		[XmlElement("Type", typeof(string))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("DataElementName", typeof(string))]
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
		public ItemsChoiceType29[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType29_0;
			}
			set
			{
				this.itemsChoiceType29_0 = value;
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

		public CustomReportItemType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType29[] itemsChoiceType29_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
