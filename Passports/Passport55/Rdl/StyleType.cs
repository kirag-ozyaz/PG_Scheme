using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DesignerCategory("code")]
	[Serializable]
	public class StyleType
	{
		[XmlElement("BackgroundGradientType", typeof(string))]
		[XmlElement("BorderWidth", typeof(BorderColorStyleWidthType))]
		[XmlElement("Calendar", typeof(string))]
		[XmlElement("FontWeight", typeof(string))]
		[XmlElement("Language", typeof(string))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("BackgroundColor", typeof(string))]
		[XmlElement("BackgroundGradientEndColor", typeof(string))]
		[XmlElement("BackgroundImage", typeof(BackgroundImageType))]
		[XmlElement("BorderColor", typeof(BorderColorStyleWidthType))]
		[XmlElement("BorderStyle", typeof(BorderColorStyleWidthType))]
		[XmlElement("Color", typeof(string))]
		[XmlElement("Direction", typeof(string))]
		[XmlElement("FontFamily", typeof(string))]
		[XmlElement("FontSize", typeof(string))]
		[XmlElement("FontStyle", typeof(string))]
		[XmlElement("Format", typeof(string))]
		[XmlAnyElement]
		[XmlElement("LineHeight", typeof(string))]
		[XmlElement("NumeralLanguage", typeof(string))]
		[XmlElement("NumeralVariant", typeof(string))]
		[XmlElement("PaddingBottom", typeof(string))]
		[XmlElement("PaddingLeft", typeof(string))]
		[XmlElement("PaddingRight", typeof(string))]
		[XmlElement("PaddingTop", typeof(string))]
		[XmlElement("TextAlign", typeof(string))]
		[XmlElement("TextDecoration", typeof(string))]
		[XmlElement("UnicodeBiDi", typeof(string))]
		[XmlElement("VerticalAlign", typeof(string))]
		[XmlElement("WritingMode", typeof(string))]
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
		public ItemsChoiceType5[] ItemsElementName
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

		private ItemsChoiceType5[] itemsElementNameField;

		private XmlAttribute[] anyAttrField;
	}
}
