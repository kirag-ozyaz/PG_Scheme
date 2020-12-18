using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DebuggerStepThrough]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DesignerCategory("code")]
	[Serializable]
	public class BodyType
	{
		[XmlElement("Style", typeof(StyleType))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("ReportItems", typeof(ReportItemsType))]
		[XmlElement("ColumnSpacing", typeof(string), DataType = "normalizedString")]
		[XmlAnyElement]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("Columns", typeof(uint))]
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
		public ItemsChoiceType30[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType30_0;
			}
			set
			{
				this.itemsChoiceType30_0 = value;
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

		public BodyType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType30[] itemsChoiceType30_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
