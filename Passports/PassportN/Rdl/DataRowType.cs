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
	public class DataRowType
	{
		[XmlElement("DataCell")]
		public DataCellType[] DataCell
		{
			get
			{
				return this.dataCellType_0;
			}
			set
			{
				this.dataCellType_0 = value;
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

		public DataRowType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private DataCellType[] dataCellType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
