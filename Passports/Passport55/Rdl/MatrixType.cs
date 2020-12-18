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
	public class MatrixType
	{
		[XmlElement("Action", typeof(ActionType))]
		[XmlElement("LayoutDirection", typeof(MatrixTypeLayoutDirection))]
		[XmlElement("Left", typeof(string), DataType = "normalizedString")]
		[XmlElement("Label", typeof(string))]
		[XmlElement("LinkToChild", typeof(string))]
		[XmlElement("NoRows", typeof(string))]
		[XmlElement("PageBreakAtEnd", typeof(bool))]
		[XmlElement("PageBreakAtStart", typeof(bool))]
		[XmlElement("RepeatWith", typeof(string))]
		[XmlElement("MatrixColumns", typeof(MatrixColumnsType))]
		[XmlAnyElement]
		[XmlElement("Bookmark", typeof(string))]
		[XmlElement("CellDataElementName", typeof(string))]
		[XmlElement("CellDataElementOutput", typeof(MatrixTypeCellDataElementOutput))]
		[XmlElement("ColumnGroupings", typeof(ColumnGroupingsType))]
		[XmlElement("Corner", typeof(CornerType))]
		[XmlElement("CustomProperties", typeof(CustomPropertiesType))]
		[XmlElement("DataElementName", typeof(string))]
		[XmlElement("DataElementOutput", typeof(MatrixTypeDataElementOutput))]
		[XmlElement("DataSetName", typeof(string))]
		[XmlElement("Filters", typeof(FiltersType))]
		[XmlElement("GroupsBeforeRowHeaders", typeof(uint))]
		[XmlElement("Height", typeof(string), DataType = "normalizedString")]
		[XmlElement("KeepTogether", typeof(bool))]
		[XmlElement("ZIndex", typeof(uint))]
		[XmlElement("MatrixRows", typeof(MatrixRowsType))]
		[XmlElement("Width", typeof(string), DataType = "normalizedString")]
		[XmlElement("Style", typeof(StyleType))]
		[XmlElement("ToolTip", typeof(string))]
		[XmlElement("Top", typeof(string), DataType = "normalizedString")]
		[XmlElement("Visibility", typeof(VisibilityType))]
		[XmlElement("RowGroupings", typeof(RowGroupingsType))]
		[XmlChoiceIdentifier("ItemsElementName")]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		[XmlElement("ItemsElementName")]
		[XmlIgnore]
		public ItemsChoiceType19[] ItemsElementName
		{
			get
			{
				return this.itemsElementNameField;
			}
			set
			{
				this.itemsElementNameField = value;
			}
		}

		[XmlAttribute(DataType = "normalizedString")]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
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

		private object[] itemsField;

		private ItemsChoiceType19[] itemsElementNameField;

		private string nameField;

		private XmlAttribute[] anyAttrField;
	}
}
