using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(AnonymousType = true)]
	[XmlRoot(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IsNullable = false)]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class Report
	{
		[XmlElement("InteractiveWidth", typeof(string), DataType = "normalizedString")]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("DataElementStyle", typeof(ReportDataElementStyle))]
		[XmlElement("DataSchema", typeof(string))]
		[XmlElement("DataSets", typeof(DataSetsType))]
		[XmlElement("DataSources", typeof(DataSourcesType))]
		[XmlElement("DataTransform", typeof(string))]
		[XmlElement("Description", typeof(string))]
		[XmlElement("EmbeddedImages", typeof(EmbeddedImagesType))]
		[XmlElement("InteractiveHeight", typeof(string), DataType = "normalizedString")]
		[XmlElement("Language", typeof(string))]
		[XmlElement("LeftMargin", typeof(string), DataType = "normalizedString")]
		[XmlElement("PageFooter", typeof(PageHeaderFooterType))]
		[XmlElement("CodeModules", typeof(CodeModulesType))]
		[XmlElement("PageHeight", typeof(string), DataType = "normalizedString")]
		[XmlElement("PageWidth", typeof(string), DataType = "normalizedString")]
		[XmlElement("ReportParameters", typeof(ReportParametersType))]
		[XmlElement("RightMargin", typeof(string), DataType = "normalizedString")]
		[XmlElement("Code", typeof(string))]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("PageHeader", typeof(PageHeaderFooterType))]
		[XmlAnyElement]
		[XmlElement("TopMargin", typeof(string), DataType = "normalizedString")]
		[XmlElement("Author", typeof(string))]
		[XmlElement("AutoRefresh", typeof(uint))]
		[XmlElement("Body", typeof(BodyType))]
		[XmlElement("BottomMargin", typeof(string), DataType = "normalizedString")]
		[XmlElement("Classes", typeof(ClassesType))]
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
		public ItemsChoiceType37[] ItemsElementName
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

		private ItemsChoiceType37[] itemsElementNameField;

		private XmlAttribute[] anyAttrField;
	}
}
