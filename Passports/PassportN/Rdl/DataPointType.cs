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
	public class DataPointType
	{
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("DataElementOutput", typeof(DataPointTypeDataElementOutput))]
		[XmlAnyElement]
		[XmlElement("Action", typeof(ActionType))]
		[XmlElement("DataValues", typeof(DataValuesType))]
		[XmlElement("DataLabel", typeof(DataLabelType))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("Marker", typeof(MarkerType))]
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

		public DataPointType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
