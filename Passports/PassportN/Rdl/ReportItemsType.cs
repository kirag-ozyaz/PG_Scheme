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
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[Serializable]
	public class ReportItemsType
	{
		[XmlElement("CustomReportItem", typeof(CustomReportItemType))]
		[XmlElement("Chart", typeof(ChartType))]
		[XmlAnyElement]
		[XmlElement("Subreport", typeof(SubreportType))]
		[XmlElement("Rectangle", typeof(RectangleType))]
		[XmlElement("Table", typeof(TableType))]
		[XmlElement("Textbox", typeof(TextboxType))]
		[XmlElement("Image", typeof(ImageType))]
		[XmlElement("Line", typeof(LineType))]
		[XmlElement("Matrix", typeof(MatrixType))]
		[XmlElement("List", typeof(ListType))]
		public object[] Items
		{
			get
			{
				return this.nyKqLotsE;
			}
			set
			{
				this.nyKqLotsE = value;
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

		public ReportItemsType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] nyKqLotsE;

		private XmlAttribute[] xmlAttribute_0;
	}
}
