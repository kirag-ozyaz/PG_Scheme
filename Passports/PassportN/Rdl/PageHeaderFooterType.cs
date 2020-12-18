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
	[DesignerCategory("code")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class PageHeaderFooterType
	{
		[XmlElement("PrintOnLastPage", typeof(bool))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("ReportItems", typeof(ReportItemsType))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlAnyElement]
		[XmlElement("PrintOnFirstPage", typeof(bool))]
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
		public ItemsChoiceType34[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType34_0;
			}
			set
			{
				this.itemsChoiceType34_0 = value;
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

		public PageHeaderFooterType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType34[] itemsChoiceType34_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
