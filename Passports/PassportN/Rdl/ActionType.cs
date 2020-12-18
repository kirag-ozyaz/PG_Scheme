using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[Serializable]
	public class ActionType
	{
		[XmlAnyElement]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Drillthrough", typeof(DrillthroughType))]
		[XmlElement("Label", typeof(string))]
		[XmlElement("Hyperlink", typeof(string))]
		[XmlElement("BookmarkLink", typeof(string))]
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
		public ItemsChoiceType8[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType8_0;
			}
			set
			{
				this.itemsChoiceType8_0 = value;
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

		public ActionType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType8[] itemsChoiceType8_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
