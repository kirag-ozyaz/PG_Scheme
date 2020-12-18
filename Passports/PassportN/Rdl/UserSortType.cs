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
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[GeneratedCode("xsd", "2.0.50727.42")]
	[Serializable]
	public class UserSortType
	{
		[XmlElement("SortExpression", typeof(string))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("SortTarget", typeof(string))]
		[XmlElement("SortExpressionScope", typeof(string))]
		[XmlAnyElement]
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

		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType13[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType13_0;
			}
			set
			{
				this.itemsChoiceType13_0 = value;
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

		public UserSortType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType13[] itemsChoiceType13_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
