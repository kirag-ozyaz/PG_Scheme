using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DebuggerStepThrough]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DesignerCategory("code")]
	[Serializable]
	public class ChartType
	{
		[XmlElement("Type", typeof(ChartTypeType))]
		[XmlElement("ValueAxis", typeof(ValueAxisType))]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("Title", typeof(TitleType))]
		[XmlElement("DataSetName", typeof(string))]
		[XmlElement("Filters", typeof(FiltersType))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("DataElementOutput", typeof(ChartTypeDataElementOutput))]
		[XmlElement("Label", typeof(string))]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("KeepTogether", typeof(bool))]
		[XmlElement("CategoryGroupings", typeof(CategoryGroupingsType))]
		[XmlElement("ChartData", typeof(ChartDataType))]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("CategoryAxis", typeof(CategoryAxisType))]
		[XmlAnyElement]
		[XmlElement("Action", typeof(ActionType))]
		[XmlElement("ChartElementOutput", typeof(ChartTypeChartElementOutput))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("Legend", typeof(LegendType))]
		[XmlElement("PageBreakAtStart", typeof(bool))]
		[XmlElement("PlotArea", typeof(PlotAreaType))]
		[XmlElement("PageBreakAtEnd", typeof(bool))]
		[XmlElement("NoRows", typeof(string))]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("Subtype", typeof(ChartTypeSubtype))]
		[XmlElement("ThreeDProperties", typeof(GClass0))]
		[XmlElement("Palette", typeof(ChartTypePalette))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("PointWidth", typeof(uint))]
		[XmlElement("SeriesGroupings", typeof(SeriesGroupingsType))]
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
		public ItemsChoiceType27[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType27_0;
			}
			set
			{
				this.itemsChoiceType27_0 = value;
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

		public ChartType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType27[] itemsChoiceType27_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
