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
	[DebuggerStepThrough]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class EmbeddedImagesType
	{
		[XmlElement("EmbeddedImage")]
		public EmbeddedImageType[] EmbeddedImage
		{
			get
			{
				return this.embeddedImageType_0;
			}
			set
			{
				this.embeddedImageType_0 = value;
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

		public EmbeddedImagesType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private EmbeddedImageType[] embeddedImageType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
