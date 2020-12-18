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
	public class BackgroundImageType
	{
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Source", typeof(BackgroundImageTypeSource))]
		[XmlElement("Value", typeof(string))]
		[XmlAnyElement]
		[XmlElement("BackgroundRepeat", typeof(string))]
		[XmlElement("MIMEType", typeof(string))]
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
		public ItemsChoiceType4[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType4_0;
			}
			set
			{
				this.itemsChoiceType4_0 = value;
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

		public BackgroundImageType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType4[] itemsChoiceType4_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
