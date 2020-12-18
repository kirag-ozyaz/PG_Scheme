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
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DesignerCategory("code")]
	[Serializable]
	public class ParameterType
	{
		[XmlElement("Omit", typeof(string))]
		[XmlAnyElement]
		[XmlElement("Value", typeof(string))]
		[XmlChoiceIdentifier("ItemsElementName")]
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
		public ItemsChoiceType6[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType6_0;
			}
			set
			{
				this.itemsChoiceType6_0 = value;
			}
		}

		[XmlAttribute]
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

		public ParameterType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType6[] itemsChoiceType6_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
