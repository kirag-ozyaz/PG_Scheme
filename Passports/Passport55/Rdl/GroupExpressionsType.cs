﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class GroupExpressionsType
	{
		[XmlElement("GroupExpression")]
		public string[] GroupExpression
		{
			get
			{
				return this.groupExpressionField;
			}
			set
			{
				this.groupExpressionField = value;
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

		private string[] groupExpressionField;

		private XmlAttribute[] anyAttrField;
	}
}
