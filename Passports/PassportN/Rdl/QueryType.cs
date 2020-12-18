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
	public class QueryType
	{
		[XmlElement("Timeout", typeof(uint))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("CommandText", typeof(string))]
		[XmlAnyElement]
		[XmlElement("CommandType", typeof(QueryTypeCommandType))]
		[XmlElement("QueryParameters", typeof(QueryParametersType))]
		[XmlElement("DataSourceName", typeof(string))]
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
		public ItemsChoiceType2[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType2_0;
			}
			set
			{
				this.itemsChoiceType2_0 = value;
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

		public QueryType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType2[] itemsChoiceType2_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
