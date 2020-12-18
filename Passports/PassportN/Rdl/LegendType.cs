﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class LegendType
	{
		[XmlElement("InsidePlotArea", typeof(bool))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Layout", typeof(LegendTypeLayout))]
		[XmlElement("Visible", typeof(bool))]
		[XmlElement("Style", typeof(StyleType))]
		[XmlAnyElement]
		[XmlElement("Position", typeof(LegendTypePosition))]
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
		public ItemsChoiceType24[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType24_0;
			}
			set
			{
				this.itemsChoiceType24_0 = value;
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

		public LegendType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType24[] itemsChoiceType24_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}