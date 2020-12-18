using System;
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
	public class StaticCategoriesType
	{
		[XmlElement("StaticMember")]
		public StaticMemberType[] StaticMember
		{
			get
			{
				return this.staticMemberField;
			}
			set
			{
				this.staticMemberField = value;
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

		private StaticMemberType[] staticMemberField;

		private XmlAttribute[] anyAttrField;
	}
}
