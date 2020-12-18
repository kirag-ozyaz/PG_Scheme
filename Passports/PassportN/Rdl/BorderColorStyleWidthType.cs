﻿using System;
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
	public class BorderColorStyleWidthType
	{
		[XmlElement("Left", typeof(string))]
		[XmlAnyElement]
		[XmlElement("Right", typeof(string))]
		[XmlElement("Bottom", typeof(string))]
		[XmlElement("Default", typeof(string))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Top", typeof(string))]
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

		[XmlIgnore]
		[XmlElement("ItemsElementName")]
		public ItemsChoiceType3[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType3_0;
			}
			set
			{
				this.itemsChoiceType3_0 = value;
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

		public BorderColorStyleWidthType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType3[] itemsChoiceType3_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}