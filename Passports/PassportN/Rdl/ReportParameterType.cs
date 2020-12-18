using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[Serializable]
	public class ReportParameterType
	{
		[XmlElement("AllowBlank", typeof(bool))]
		[XmlAnyElement]
		[XmlElement("DataType", typeof(ReportParameterTypeDataType))]
		[XmlElement("MultiValue", typeof(bool))]
		[XmlElement("DefaultValue", typeof(DefaultValueType))]
		[XmlElement("Prompt", typeof(string))]
		[XmlElement("Nullable", typeof(bool))]
		[XmlElement("UsedInQuery", typeof(ReportParameterTypeUsedInQuery))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("ValidValues", typeof(ValidValuesType))]
		[XmlElement("Hidden", typeof(bool))]
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
		public ItemsChoiceType33[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType33_0;
			}
			set
			{
				this.itemsChoiceType33_0 = value;
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

		public ReportParameterType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType33[] itemsChoiceType33_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
