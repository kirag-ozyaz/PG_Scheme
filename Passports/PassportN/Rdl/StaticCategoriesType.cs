using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Rdl
{
	[GeneratedCode("xsd", "2.0.50727.42")]
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[Serializable]
	public class StaticCategoriesType
	{
		[XmlElement("StaticMember")]
		public StaticMemberType[] StaticMember
		{
			get
			{
				return this.staticMemberType_0;
			}
			set
			{
				this.staticMemberType_0 = value;
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

		public StaticCategoriesType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private StaticMemberType[] staticMemberType_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
