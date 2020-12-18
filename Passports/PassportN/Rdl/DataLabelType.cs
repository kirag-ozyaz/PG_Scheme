using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class DataLabelType
	{
		[XmlElement("Visible", typeof(bool))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Value", typeof(string))]
		[XmlElement("Rotation", typeof(string), DataType = "integer")]
		[XmlElement("Position", typeof(DataLabelTypePosition))]
		[XmlElement("Style", typeof(StyleType))]
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

		[XmlIgnore]
		[XmlElement("ItemsElementName")]
		public ItemsChoiceType23[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType23_0;
			}
			set
			{
				this.itemsChoiceType23_0 = value;
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

		public DataLabelType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType23[] itemsChoiceType23_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
