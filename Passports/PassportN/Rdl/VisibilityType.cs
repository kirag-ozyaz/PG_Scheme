using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class VisibilityType
	{
		[XmlElement("Hidden", typeof(string))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlAnyElement]
		[XmlElement("ToggleItem", typeof(string))]
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
		public ItemsChoiceType9[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType9_0;
			}
			set
			{
				this.itemsChoiceType9_0 = value;
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

		public VisibilityType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType9[] itemsChoiceType9_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
