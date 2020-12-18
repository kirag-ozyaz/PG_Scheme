using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DebuggerStepThrough]
	[XmlRoot(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition", IsNullable = false)]
	[XmlType(AnonymousType = true)]
	[DesignerCategory("code")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class Report
	{
		[XmlElement("EmbeddedImages", typeof(EmbeddedImagesType))]
		[XmlElement("Description", typeof(string))]
		[XmlElement("InteractiveHeight", typeof(string), DataType = "normalizedString")]
		[XmlElement("Language", typeof(string))]
		[XmlElement("InteractiveWidth", typeof(string), DataType = "normalizedString")]
		[XmlElement("DataSchema", typeof(string))]
		[XmlElement("DataElementStyle", typeof(ReportDataElementStyle))]
		[XmlElement("DataSets", typeof(DataSetsType))]
		[XmlElement("DataTransform", typeof(string))]
		[XmlElement("DataSources", typeof(DataSourcesType))]
		[XmlElement("RightMargin", typeof(string), DataType = "normalizedString")]
		[XmlElement("ReportParameters", typeof(ReportParametersType))]
		[XmlElement("TopMargin", typeof(string), DataType = "normalizedString")]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("PageFooter", typeof(PageHeaderFooterType))]
		[XmlElement("LeftMargin", typeof(string), DataType = "normalizedString")]
		[XmlElement("PageHeader", typeof(PageHeaderFooterType))]
		[XmlElement("PageWidth", typeof(string), DataType = "normalizedString")]
		[XmlElement("PageHeight", typeof(string), DataType = "normalizedString")]
		[XmlElement("Body", typeof(BodyType))]
		[XmlElement("BottomMargin", typeof(string), DataType = "normalizedString")]
		[XmlElement("AutoRefresh", typeof(uint))]
		[XmlAnyElement]
		[XmlElement("Author", typeof(string))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("CodeModules", typeof(CodeModulesType))]
		[XmlElement("Classes", typeof(ClassesType))]
		[XmlElement("Code", typeof(string))]
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
		public ItemsChoiceType37[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType37_0;
			}
			set
			{
				this.itemsChoiceType37_0 = value;
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

		public Report()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType37[] itemsChoiceType37_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
