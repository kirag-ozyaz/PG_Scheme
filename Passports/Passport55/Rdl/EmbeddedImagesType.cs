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
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class EmbeddedImagesType
	{
		[XmlElement("EmbeddedImage")]
		public EmbeddedImageType[] EmbeddedImage
		{
			get
			{
				return this.embeddedImageField;
			}
			set
			{
				this.embeddedImageField = value;
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

		private EmbeddedImageType[] embeddedImageField;

		private XmlAttribute[] anyAttrField;
	}
}
