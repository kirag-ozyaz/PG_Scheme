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
	[DesignerCategory("code")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class HeaderType
	{
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlAnyElement]
		[XmlElement("FixedHeader", typeof(bool))]
		[XmlElement("RepeatOnNewPage", typeof(bool))]
		[XmlElement("TableRows", typeof(TableRowsType))]
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
		public ItemsChoiceType20[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType20_0;
			}
			set
			{
				this.itemsChoiceType20_0 = value;
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

		public HeaderType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType20[] itemsChoiceType20_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
