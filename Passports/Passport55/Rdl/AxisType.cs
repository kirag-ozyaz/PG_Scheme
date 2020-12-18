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
	public class AxisType
	{
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("MajorInterval", typeof(string))]
		[XmlElement("MinorGridLines", typeof(MinorGridLinesType))]
		[XmlElement("MinorInterval", typeof(string))]
		[XmlElement("MinorTickMarks", typeof(AxisTypeMinorTickMarks))]
		[XmlElement("Reverse", typeof(bool))]
		[XmlElement("Scalar", typeof(bool))]
		[XmlElement("Min", typeof(string))]
		[XmlElement("MajorGridLines", typeof(MajorGridLinesType))]
		[XmlElement("Visible", typeof(bool))]
		[XmlElement("MajorTickMarks", typeof(AxisTypeMajorTickMarks))]
		[XmlElement("Margin", typeof(bool))]
		[XmlElement("Max", typeof(string))]
		[XmlElement("Title", typeof(TitleType))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlAnyElement]
		[XmlElement("CrossAt", typeof(string))]
		[XmlElement("Interlaced", typeof(bool))]
		[XmlElement("LogScale", typeof(bool))]
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
		public ItemsChoiceType25[] ItemsElementName
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

		private ItemsChoiceType25[] itemsElementNameField;

		private XmlAttribute[] anyAttrField;
	}
}
