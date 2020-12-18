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
	public class DataGroupingType
	{
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Static", typeof(bool))]
		[XmlAnyElement]
		[XmlElement("Subtotal", typeof(bool))]
		[XmlElement("Grouping", typeof(GroupingType))]
		[XmlElement("Sorting", typeof(SortingType))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("DataGroupings", typeof(DataGroupingsType))]
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
		public ItemsChoiceType28[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType28_0;
			}
			set
			{
				this.itemsChoiceType28_0 = value;
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

		public DataGroupingType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType28[] itemsChoiceType28_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
