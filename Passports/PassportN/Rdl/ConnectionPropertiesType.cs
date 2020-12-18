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
	public class ConnectionPropertiesType
	{
		[XmlElement("DataProvider", typeof(string))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("IntegratedSecurity", typeof(bool))]
		[XmlElement("Prompt", typeof(string))]
		[XmlElement("ConnectString", typeof(string))]
		[XmlAnyElement]
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
		public ItemsChoiceType[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType_0;
			}
			set
			{
				this.itemsChoiceType_0 = value;
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

		public ConnectionPropertiesType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType[] itemsChoiceType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
