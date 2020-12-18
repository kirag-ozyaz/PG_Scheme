using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class DataSetsType
	{
		[XmlElement("DataSet")]
		public DataSetType[] DataSet
		{
			get
			{
				return this.dataSetType_0;
			}
			set
			{
				this.dataSetType_0 = value;
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

		public DataSetsType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private DataSetType[] dataSetType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
