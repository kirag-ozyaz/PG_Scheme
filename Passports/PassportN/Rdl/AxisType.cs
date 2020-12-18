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
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[Serializable]
	public class AxisType
	{
		[XmlElement("Max", typeof(string))]
		[XmlElement("MinorGridLines", typeof(MinorGridLinesType))]
		[XmlElement("Min", typeof(string))]
		[XmlElement("Margin", typeof(bool))]
		[XmlAnyElement]
		[XmlElement("CrossAt", typeof(string))]
		[XmlElement("Interlaced", typeof(bool))]
		[XmlElement("MajorGridLines", typeof(MajorGridLinesType))]
		[XmlElement("MajorTickMarks", typeof(AxisTypeMajorTickMarks))]
		[XmlElement("MajorInterval", typeof(string))]
		[XmlElement("LogScale", typeof(bool))]
		[XmlElement("MinorInterval", typeof(string))]
		[XmlElement("Title", typeof(TitleType))]
		[XmlElement("Visible", typeof(bool))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("MinorTickMarks", typeof(AxisTypeMinorTickMarks))]
		[XmlElement("Reverse", typeof(bool))]
		[XmlElement("Scalar", typeof(bool))]
		public object[] Items
		{
			get
			{
				return this.kQvamTwuBs;
			}
			set
			{
				this.kQvamTwuBs = value;
			}
		}

		[XmlIgnore]
		[XmlElement("ItemsElementName")]
		public ItemsChoiceType25[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType25_0;
			}
			set
			{
				this.itemsChoiceType25_0 = value;
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

		public AxisType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] kQvamTwuBs;

		private ItemsChoiceType25[] itemsChoiceType25_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
