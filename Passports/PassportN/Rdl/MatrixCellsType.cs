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
	public class MatrixCellsType
	{
		[XmlElement("MatrixCell")]
		public MatrixCellType[] MatrixCell
		{
			get
			{
				return this.matrixCellType_0;
			}
			set
			{
				this.matrixCellType_0 = value;
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

		public MatrixCellsType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private MatrixCellType[] matrixCellType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
