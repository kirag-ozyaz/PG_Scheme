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
	public class DataSetType
	{
		[XmlElement("Query", typeof(QueryType))]
		[XmlElement("Fields", typeof(FieldsType))]
		[XmlElement("CaseSensitivity", typeof(DataSetTypeCaseSensitivity))]
		[XmlElement("KanatypeSensitivity", typeof(DataSetTypeKanatypeSensitivity))]
		[XmlElement("WidthSensitivity", typeof(DataSetTypeWidthSensitivity))]
		[XmlElement("Collation", typeof(string))]
		[XmlElement("Filters", typeof(FiltersType))]
		[XmlAnyElement]
		[XmlElement("AccentSensitivity", typeof(DataSetTypeAccentSensitivity))]
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

		[XmlAttribute(DataType = "normalizedString")]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
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

		private string nameField;

		private XmlAttribute[] anyAttrField;
	}
}
