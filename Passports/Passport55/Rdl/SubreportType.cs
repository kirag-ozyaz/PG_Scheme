using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DesignerCategory("code")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class SubreportType
	{
		[XmlElement("ReportName", typeof(string))]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlElement("Parameters", typeof(ParametersType))]
		[XmlElement("Action", typeof(ActionType))]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("DataElementOutput", typeof(SubreportTypeDataElementOutput))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("MergeTransactions", typeof(bool))]
		[XmlElement("NoRows", typeof(string))]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("Label", typeof(string))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlAnyElement]
		[XmlElement("Style", typeof(StyleType))]
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
		public ItemsChoiceType16[] ItemsElementName
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

		private ItemsChoiceType16[] itemsElementNameField;

		private string nameField;

		private XmlAttribute[] anyAttrField;
	}
}
