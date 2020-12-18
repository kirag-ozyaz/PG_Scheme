using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DebuggerStepThrough]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DesignerCategory("code")]
	[Serializable]
	public class ChartType
	{
		[XmlElement("DataSetName", typeof(string))]
		[XmlElement("PlotArea", typeof(PlotAreaType))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("SeriesGroupings", typeof(SeriesGroupingsType))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("Type", typeof(ChartTypeType))]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlAnyElement]
		[XmlElement("Action", typeof(ActionType))]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("CategoryAxis", typeof(CategoryAxisType))]
		[XmlElement("CategoryGroupings", typeof(CategoryGroupingsType))]
		[XmlElement("ChartData", typeof(ChartDataType))]
		[XmlElement("ChartElementOutput", typeof(ChartTypeChartElementOutput))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("DataElementOutput", typeof(ChartTypeDataElementOutput))]
		[XmlElement("Filters", typeof(FiltersType))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("KeepTogether", typeof(bool))]
		[XmlElement("Label", typeof(string))]
		[XmlElement("Subtype", typeof(ChartTypeSubtype))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("NoRows", typeof(string))]
		[XmlElement("PageBreakAtEnd", typeof(bool))]
		[XmlElement("PageBreakAtStart", typeof(bool))]
		[XmlElement("Palette", typeof(ChartTypePalette))]
		[XmlElement("PointWidth", typeof(uint))]
		[XmlElement("Legend", typeof(LegendType))]
		[XmlElement("ThreeDProperties", typeof(ThreeDPropertiesType))]
		[XmlElement("Title", typeof(TitleType))]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("ValueAxis", typeof(ValueAxisType))]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("ZIndex", typeof(uint))]
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
		public ItemsChoiceType27[] ItemsElementName
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

		private ItemsChoiceType27[] itemsElementNameField;

		private string nameField;

		private XmlAttribute[] anyAttrField;
	}
}
