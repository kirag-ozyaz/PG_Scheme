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
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[Serializable]
	public class DataSetType
	{
		[XmlElement("Query", typeof(QueryType))]
		[XmlElement("WidthSensitivity", typeof(DataSetTypeWidthSensitivity))]
		[XmlElement("CaseSensitivity", typeof(DataSetTypeCaseSensitivity))]
		[XmlAnyElement]
		[XmlElement("Collation", typeof(string))]
		[XmlElement("Fields", typeof(FieldsType))]
		[XmlElement("Filters", typeof(FiltersType))]
		[XmlElement("KanatypeSensitivity", typeof(DataSetTypeKanatypeSensitivity))]
		[XmlElement("AccentSensitivity", typeof(DataSetTypeAccentSensitivity))]
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

		[XmlAttribute(DataType = "normalizedString")]
		public string Name
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
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

		public DataSetType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
