using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class ParameterValueType
	{
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Label", typeof(string))]
		[XmlElement("Value", typeof(string))]
		[XmlAnyElement]
		public object[] Items
		{
			get
			{
				return this.gtdogNyOo;
			}
			set
			{
				this.gtdogNyOo = value;
			}
		}

		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType32[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType32_0;
			}
			set
			{
				this.itemsChoiceType32_0 = value;
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

		public ParameterValueType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] gtdogNyOo;

		private ItemsChoiceType32[] itemsChoiceType32_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
