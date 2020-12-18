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
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DebuggerStepThrough]
	[Serializable]
	public class GroupingType
	{
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("PageBreakAtEnd", typeof(bool))]
		[XmlElement("Label", typeof(string))]
		[XmlElement("Parent", typeof(string))]
		[XmlElement("GroupExpressions", typeof(GroupExpressionsType))]
		[XmlElement("DataCollectionName", typeof(string))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlAnyElement]
		[XmlElement("Filters", typeof(FiltersType))]
		[XmlElement("DataElementOutput", typeof(GroupingTypeDataElementOutput))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("PageBreakAtStart", typeof(bool))]
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
		public ItemsChoiceType17[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType17_0;
			}
			set
			{
				this.itemsChoiceType17_0 = value;
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

		public GroupingType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType17[] itemsChoiceType17_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
