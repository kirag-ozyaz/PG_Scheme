using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[Serializable]
	public class QueryType
	{
		[XmlAnyElement]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("CommandType", typeof(QueryTypeCommandType))]
		[XmlElement("CommandText", typeof(string))]
		[XmlElement("DataSourceName", typeof(string))]
		[XmlElement("QueryParameters", typeof(QueryParametersType))]
		[XmlElement("Timeout", typeof(uint))]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType2[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}

		[XmlAnyAttribute]
		public XmlAttribute[] AnyAttr
		{
			get
			{
				return this.anyAttrField;
			}
			set
			{
				this.anyAttrField = value;
			}
		}

		private object[] itemsField;

		private ItemsChoiceType2[] itemsElementNameField;

		private XmlAttribute[] anyAttrField;
	}
}
