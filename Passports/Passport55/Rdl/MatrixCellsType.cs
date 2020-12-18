﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[Serializable]
	public class MatrixCellsType
	{
		[XmlElement("MatrixCell")]
		public MatrixCellType[] MatrixCell
		{
			get
			{
				return this.matrixCellField;
			}
			set
			{
				this.matrixCellField = value;
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

		private MatrixCellType[] matrixCellField;

		private XmlAttribute[] anyAttrField;
	}
}