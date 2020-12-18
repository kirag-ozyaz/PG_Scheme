using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[Serializable]
	public class CustomDataType
	{
		[XmlElement("DataRows", typeof(DataRowsType))]
		[XmlElement("DataColumnGroupings", typeof(DataColumnGroupingsType))]
		[XmlAnyElement]
		[XmlElement("Filters", typeof(FiltersType))]
		[XmlElement("DataRowGroupings", typeof(DataRowGroupingsType))]
		[XmlElement("DataSetName", typeof(string))]
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

		private XmlAttribute[] anyAttrField;
	}
}
