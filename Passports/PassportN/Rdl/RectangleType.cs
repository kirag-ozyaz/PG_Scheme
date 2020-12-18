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
	public class RectangleType
	{
		[XmlAnyElement]
		[XmlElement("DataElementOutput", typeof(RectangleTypeDataElementOutput))]
		[XmlElement("PageBreakAtEnd", typeof(bool))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("Action", typeof(ActionType))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("ToolTip", typeof(string))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("Label", typeof(string))]
		[XmlElement("PageBreakAtStart", typeof(bool))]
		[XmlElement("ReportItems", typeof(ReportItemsType))]
		[XmlElement("RepeatWith", typeof(string))]
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
		public ItemsChoiceType12[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType12_0;
			}
			set
			{
				this.itemsChoiceType12_0 = value;
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

		public RectangleType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType12[] itemsChoiceType12_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
