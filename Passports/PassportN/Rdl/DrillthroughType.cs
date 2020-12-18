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
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class DrillthroughType
	{
		[XmlElement("BookmarkLink", typeof(string))]
		[XmlElement("Parameters", typeof(ParametersType))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("ReportName", typeof(string))]
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
		public ItemsChoiceType7[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType7_0;
			}
			set
			{
				this.itemsChoiceType7_0 = value;
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

		public DrillthroughType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType7[] itemsChoiceType7_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
