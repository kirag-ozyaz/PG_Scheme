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
	public class ReportParameterType
	{
		[XmlElement("Hidden", typeof(bool))]
		[XmlElement("UsedInQuery", typeof(ReportParameterTypeUsedInQuery))]
		[XmlElement("ValidValues", typeof(ValidValuesType))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("AllowBlank", typeof(bool))]
		[XmlElement("DataType", typeof(ReportParameterTypeDataType))]
		[XmlElement("DefaultValue", typeof(DefaultValueType))]
		[XmlAnyElement]
		[XmlElement("MultiValue", typeof(bool))]
		[XmlElement("Nullable", typeof(bool))]
		[XmlElement("Prompt", typeof(string))]
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
		public ItemsChoiceType33[] ItemsElementName
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

		private ItemsChoiceType33[] itemsElementNameField;

		private string nameField;

		private XmlAttribute[] anyAttrField;
	}
}
