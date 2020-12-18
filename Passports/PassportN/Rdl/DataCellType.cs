using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DebuggerStepThrough]
	[Serializable]
	public class DataCellType
	{
		[XmlElement("DataValue")]
		public DataValueType[] DataValue
		{
			get
			{
				return this.dataValueType_0;
			}
			set
			{
				this.dataValueType_0 = value;
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

		public DataCellType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private DataValueType[] dataValueType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
