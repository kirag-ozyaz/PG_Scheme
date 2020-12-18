using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DesignerCategory("code")]
	[Serializable]
	public class PageHeaderFooterType
	{
		[XmlElement("PrintOnLastPage", typeof(bool))]
		[XmlElement("ReportItems", typeof(ReportItemsType))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("PrintOnFirstPage", typeof(bool))]
		[XmlAnyElement]
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
		public ItemsChoiceType34[] ItemsElementName
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

		private ItemsChoiceType34[] itemsElementNameField;

		private XmlAttribute[] anyAttrField;
	}
}
