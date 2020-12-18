using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class SubreportType
	{
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlElement("Action", typeof(ActionType))]
		[XmlAnyElement]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("DataElementOutput", typeof(SubreportTypeDataElementOutput))]
		[XmlElement("ReportName", typeof(string))]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlElement("Parameters", typeof(ParametersType))]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("NoRows", typeof(string))]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("Label", typeof(string))]
		[XmlElement("MergeTransactions", typeof(bool))]
		[XmlElement("LinkToChild", typeof(string))]
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
		public ItemsChoiceType16[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType16_0;
			}
			set
			{
				this.itemsChoiceType16_0 = value;
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

		public SubreportType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType16[] itemsChoiceType16_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
