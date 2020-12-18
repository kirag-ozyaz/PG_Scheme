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
	[XmlType(Namespace = "http://schemas.microsoft.com/sqlserver/reporting/2005/01/reportdefinition")]
	[DesignerCategory("code")]
	[Serializable]
	public class MatrixType
	{
		[XmlElement("DataSetName", typeof(string))]
		[XmlElement("DataElementOutput", typeof(MatrixTypeDataElementOutput))]
		[XmlElement("Filters", typeof(FiltersType))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("GroupsBeforeRowHeaders", typeof(uint))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("CellDataElementOutput", typeof(MatrixTypeCellDataElementOutput))]
		[XmlElement("CellDataElementName", typeof(string))]
		[XmlElement("ColumnGroupings", typeof(ColumnGroupingsType))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("Corner", typeof(CornerType))]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlElement("PageBreakAtStart", typeof(bool))]
		[XmlElement("MatrixRows", typeof(MatrixRowsType))]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("MatrixColumns", typeof(MatrixColumnsType))]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("Label", typeof(string))]
		[XmlElement("KeepTogether", typeof(bool))]
		[XmlElement("NoRows", typeof(string))]
		[XmlElement("LayoutDirection", typeof(MatrixTypeLayoutDirection))]
		[XmlElement("PageBreakAtEnd", typeof(bool))]
		[XmlChoiceIdentifier("ItemsElementName")]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("RowGroupings", typeof(RowGroupingsType))]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("Action", typeof(ActionType))]
		[XmlElement("Bookmark", typeof(string))]
		[XmlAnyElement]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
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
		public ItemsChoiceType19[] ItemsElementName
		{
			get
			{
				return this.itemsChoiceType19_0;
			}
			set
			{
				this.itemsChoiceType19_0 = value;
			}
		}

		[XmlAttribute(DataType = "normalizedString")]
		public string Name
		{
			get
			{
				return this.string_0;
			}
			set
			{
				this.string_0 = value;
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

		public MatrixType()
		{
			Class330.Mus9JxKz1CNxy();
			base..ctor();
		}

		private object[] object_0;

		private ItemsChoiceType19[] itemsChoiceType19_0;

		private string string_0;

		private XmlAttribute[] xmlAttribute_0;
	}
}
