using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class StyleType
	{
		[XmlElement("UnicodeBiDi", typeof(string))]
		[XmlElement("VerticalAlign", typeof(string))]
		[XmlElement("FontWeight", typeof(string))]
		[XmlElement("TextAlign", typeof(string))]
		[XmlElement("FontSize", typeof(string))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("WritingMode", typeof(string))]
		[XmlElement("FontStyle", typeof(string))]
		[XmlElement("Format", typeof(string))]
		[XmlElement("PaddingBottom", typeof(string))]
		[XmlElement("NumeralVariant", typeof(string))]
		[XmlElement("PaddingRight", typeof(string))]
		[XmlElement("PaddingLeft", typeof(string))]
		[XmlElement("LineHeight", typeof(string))]
		[XmlElement("Language", typeof(string))]
		[XmlElement("NumeralLanguage", typeof(string))]
		[XmlElement("PaddingTop", typeof(string))]
		[XmlElement("BackgroundImage", typeof(BackgroundImageType))]
		[XmlElement("BackgroundGradientType", typeof(string))]
		[XmlElement("BorderStyle", typeof(BorderColorStyleWidthType))]
		[XmlElement("BorderColor", typeof(BorderColorStyleWidthType))]
		[XmlAnyElement]
		[XmlElement("TextDecoration", typeof(string))]
		[XmlElement("BackgroundGradientEndColor", typeof(string))]
		[XmlElement("BackgroundColor", typeof(string))]
		[XmlElement("BorderWidth", typeof(BorderColorStyleWidthType))]
		[XmlElement("FontFamily", typeof(string))]
		[XmlElement("Direction", typeof(string))]
		[XmlElement("Calendar", typeof(string))]
		[XmlElement("Color", typeof(string))]
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
		public ItemsChoiceType5[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType5_0;
			}
			set
			{
				this.itemsChoiceType5_0 = value;
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

		public StyleType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType5[] itemsChoiceType5_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
