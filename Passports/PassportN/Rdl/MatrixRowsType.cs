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
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class MatrixRowsType
	{
		[XmlElement("MatrixRow")]
		public MatrixRowType[] MatrixRow
		{
			get
			{
				return this.matrixRowType_0;
			}
			set
			{
				this.matrixRowType_0 = value;
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

		public MatrixRowsType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private MatrixRowType[] matrixRowType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
