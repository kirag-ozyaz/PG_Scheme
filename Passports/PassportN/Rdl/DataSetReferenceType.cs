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
	public class DataSetReferenceType
	{
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlAnyElement]
		[XmlElement("LabelField", typeof(string))]
		[XmlElement("DataSetName", typeof(string))]
		[XmlElement("ValueField", typeof(string))]
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
		public ItemsChoiceType31[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType31_0;
			}
			set
			{
				this.itemsChoiceType31_0 = value;
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

		public DataSetReferenceType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType31[] itemsChoiceType31_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
