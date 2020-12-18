using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Passport.Controls.PanelPivotGrid
{
	[ToolboxItem(true)]
	[DesignerCategory("code")]
	[XmlRoot("dsPivotGrid")]
	[HelpKeyword("vs.data.DataSet")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	internal class dsPivotGrid : DataSet
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public dsPivotGrid()
		{
			base.BeginInit();
			this.method_2();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_4);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected dsPivotGrid(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0, false)
		{
			if (base.IsBinarySerialized(serializationInfo_0, streamingContext_0))
			{
				this.method_1(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_4);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
				return;
			}
			string s = (string)serializationInfo_0.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["vPassportShowData"] != null)
				{
					base.Tables.Add(new dsPivotGrid.vPassportShowDataDataTable(dataSet.Tables["vPassportShowData"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.method_0();
			}
			else
			{
				base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			}
			base.GetSerializationData(serializationInfo_0, streamingContext_0);
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.method_4);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public dsPivotGrid.vPassportShowDataDataTable vPassportShowData
		{
			get
			{
				return this.tablevPassportShowData;
			}
		}

		[DebuggerNonUserCode]
		[Browsable(true)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.method_2();
			base.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			dsPivotGrid dsPivotGrid = (dsPivotGrid)base.Clone();
			dsPivotGrid.method_0();
			dsPivotGrid.SchemaSerializationMode = this.SchemaSerializationMode;
			return dsPivotGrid;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["vPassportShowData"] != null)
				{
					base.Tables.Add(new dsPivotGrid.vPassportShowDataDataTable(dataSet.Tables["vPassportShowData"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.method_0();
				return;
			}
			base.ReadXml(reader);
			this.method_0();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_0()
		{
			this.method_1(true);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_1(bool bool_0)
		{
			this.tablevPassportShowData = (dsPivotGrid.vPassportShowDataDataTable)base.Tables["vPassportShowData"];
			if (bool_0 && this.tablevPassportShowData != null)
			{
				this.tablevPassportShowData.method_2();
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_2()
		{
			base.DataSetName = "dsPivotGrid";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/dsPivotGrid.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tablevPassportShowData = new dsPivotGrid.vPassportShowDataDataTable();
			base.Tables.Add(this.tablevPassportShowData);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool method_3()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_4(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.method_0();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			dsPivotGrid dsPivotGrid = new dsPivotGrid();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dsPivotGrid.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dsPivotGrid.GetSchemaSerializable();
			if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					foreach (object obj in xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace))
					{
						XmlSchema xmlSchema = (XmlSchema)obj;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length)
							{
								if (memoryStream.ReadByte() != memoryStream2.ReadByte())
								{
									break;
								}
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
					goto IL_13A;
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (memoryStream2 != null)
					{
						memoryStream2.Close();
					}
				}
				XmlSchemaComplexType result;
				return result;
			}
			IL_13A:
			xmlSchemaSet_0.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}

		private dsPivotGrid.vPassportShowDataDataTable tablevPassportShowData;

		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate140(object sender, dsPivotGrid.EventArgs140 e);

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vPassportShowDataDataTable : TypedTableBase<dsPivotGrid.Class204>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public vPassportShowDataDataTable()
			{
				base.TableName = "vPassportShowData";
				this.BeginInit();
				this.method_3();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal vPassportShowDataDataTable(DataTable dataTable_0)
			{
				base.TableName = dataTable_0.TableName;
				if (dataTable_0.CaseSensitive != dataTable_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = dataTable_0.CaseSensitive;
				}
				if (dataTable_0.Locale.ToString() != dataTable_0.DataSet.Locale.ToString())
				{
					base.Locale = dataTable_0.Locale;
				}
				if (dataTable_0.Namespace != dataTable_0.DataSet.Namespace)
				{
					base.Namespace = dataTable_0.Namespace;
				}
				base.Prefix = dataTable_0.Prefix;
				base.MinimumCapacity = dataTable_0.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected vPassportShowDataDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_2();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idObjListColumn
			{
				get
				{
					return this.columnidObjList;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DateColumn
			{
				get
				{
					return this.columnDate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idCharColumn
			{
				get
				{
					return this.columnidChar;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ParentIdCharColumn
			{
				get
				{
					return this.columnParentIdChar;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParentKeyCharColumn
			{
				get
				{
					return this.columnParentKeyChar;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ValueColumn
			{
				get
				{
					return this.columnValue;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TabIndexColumn
			{
				get
				{
					return this.columnTabIndex;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn isGroupColumn
			{
				get
				{
					return this.columnisGroup;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DeletedColumn
			{
				get
				{
					return this.columnDeleted;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn isActiveColumn
			{
				get
				{
					return this.columnisActive;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CharDeletedColumn
			{
				get
				{
					return this.columnCharDeleted;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dsPivotGrid.Class204 this[int int_0]
			{
				get
				{
					return (dsPivotGrid.Class204)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsPivotGrid.Delegate140 vPassportShowDataRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsPivotGrid.Delegate140 vPassportShowDataRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsPivotGrid.Delegate140 vPassportShowDataRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsPivotGrid.Delegate140 vPassportShowDataRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(dsPivotGrid.Class204 class204_0)
			{
				base.Rows.Add(class204_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dsPivotGrid.Class204 method_1(int int_0, int int_1, DateTime dateTime_0, int int_2, int int_3, string string_0, string string_1, string string_2, int int_4, bool bool_0, bool bool_1, bool bool_2, bool bool_3)
			{
				dsPivotGrid.Class204 @class = (dsPivotGrid.Class204)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
					int_1,
					dateTime_0,
					int_2,
					int_3,
					string_0,
					string_1,
					string_2,
					int_4,
					bool_0,
					bool_1,
					bool_2,
					bool_3
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				dsPivotGrid.vPassportShowDataDataTable vPassportShowDataDataTable = (dsPivotGrid.vPassportShowDataDataTable)base.Clone();
				vPassportShowDataDataTable.method_2();
				return vPassportShowDataDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new dsPivotGrid.vPassportShowDataDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_2()
			{
				this.columnid = base.Columns["id"];
				this.columnidObjList = base.Columns["idObjList"];
				this.columnDate = base.Columns["Date"];
				this.columnidChar = base.Columns["idChar"];
				this.columnParentIdChar = base.Columns["ParentIdChar"];
				this.columnParentKeyChar = base.Columns["ParentKeyChar"];
				this.columnName = base.Columns["Name"];
				this.columnValue = base.Columns["Value"];
				this.columnTabIndex = base.Columns["TabIndex"];
				this.columnisGroup = base.Columns["isGroup"];
				this.columnDeleted = base.Columns["Deleted"];
				this.columnisActive = base.Columns["isActive"];
				this.columnCharDeleted = base.Columns["CharDeleted"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_3()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidObjList = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObjList);
				this.columnDate = new DataColumn("Date", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDate);
				this.columnidChar = new DataColumn("idChar", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidChar);
				this.columnParentIdChar = new DataColumn("ParentIdChar", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnParentIdChar);
				this.columnParentKeyChar = new DataColumn("ParentKeyChar", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParentKeyChar);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnValue = new DataColumn("Value", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue);
				this.columnTabIndex = new DataColumn("TabIndex", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTabIndex);
				this.columnisGroup = new DataColumn("isGroup", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnisGroup);
				this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnDeleted);
				this.columnisActive = new DataColumn("isActive", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnisActive);
				this.columnCharDeleted = new DataColumn("CharDeleted", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnCharDeleted);
				this.columnid.AllowDBNull = false;
				this.columnidObjList.AllowDBNull = false;
				this.columnDate.AllowDBNull = false;
				this.columnidChar.AllowDBNull = false;
				this.columnParentKeyChar.MaxLength = 50;
				this.columnName.AllowDBNull = false;
				this.columnName.MaxLength = 50;
				this.columnValue.ReadOnly = true;
				this.columnValue.MaxLength = int.MaxValue;
				this.columnisGroup.AllowDBNull = false;
				this.columnDeleted.AllowDBNull = false;
				this.columnisActive.AllowDBNull = false;
				this.columnCharDeleted.AllowDBNull = false;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dsPivotGrid.Class204 method_4()
			{
				return (dsPivotGrid.Class204)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsPivotGrid.Class204(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(dsPivotGrid.Class204);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vPassportShowDataRowChanged != null)
				{
					this.vPassportShowDataRowChanged(this, new dsPivotGrid.EventArgs140((dsPivotGrid.Class204)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vPassportShowDataRowChanging != null)
				{
					this.vPassportShowDataRowChanging(this, new dsPivotGrid.EventArgs140((dsPivotGrid.Class204)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vPassportShowDataRowDeleted != null)
				{
					this.vPassportShowDataRowDeleted(this, new dsPivotGrid.EventArgs140((dsPivotGrid.Class204)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vPassportShowDataRowDeleting != null)
				{
					this.vPassportShowDataRowDeleting(this, new dsPivotGrid.EventArgs140((dsPivotGrid.Class204)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5(dsPivotGrid.Class204 class204_0)
			{
				base.Rows.Remove(class204_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsPivotGrid dsPivotGrid = new dsPivotGrid();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = dsPivotGrid.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vPassportShowDataDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dsPivotGrid.GetSchemaSerializable();
				if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length)
								{
									if (memoryStream.ReadByte() != memoryStream2.ReadByte())
									{
										break;
									}
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
						goto IL_1ED;
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
					XmlSchemaComplexType result;
					return result;
				}
				IL_1ED:
				xmlSchemaSet_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			private DataColumn columnid;

			private DataColumn columnidObjList;

			private DataColumn columnDate;

			private DataColumn columnidChar;

			private DataColumn columnParentIdChar;

			private DataColumn columnParentKeyChar;

			private DataColumn columnName;

			private DataColumn columnValue;

			private DataColumn columnTabIndex;

			private DataColumn columnisGroup;

			private DataColumn columnDeleted;

			private DataColumn columnisActive;

			private DataColumn columnCharDeleted;
		}

		public class Class204 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class204(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vPassportShowDataDataTable_0 = (dsPivotGrid.vPassportShowDataDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.vPassportShowDataDataTable_0.idColumn];
				}
				set
				{
					base[this.vPassportShowDataDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.vPassportShowDataDataTable_0.idObjListColumn];
			}

			public void method_1(int int_0)
			{
				base[this.vPassportShowDataDataTable_0.idObjListColumn] = int_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime Date
			{
				get
				{
					return (DateTime)base[this.vPassportShowDataDataTable_0.DateColumn];
				}
				set
				{
					base[this.vPassportShowDataDataTable_0.DateColumn] = value;
				}
			}

			public int method_2()
			{
				return (int)base[this.vPassportShowDataDataTable_0.idCharColumn];
			}

			public void method_3(int int_0)
			{
				base[this.vPassportShowDataDataTable_0.idCharColumn] = int_0;
			}

			public int method_4()
			{
				int result;
				try
				{
					result = (int)base[this.vPassportShowDataDataTable_0.ParentIdCharColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentIdChar' in table 'vPassportShowData' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(int int_0)
			{
				base[this.vPassportShowDataDataTable_0.ParentIdCharColumn] = int_0;
			}

			public string method_6()
			{
				string result;
				try
				{
					result = (string)base[this.vPassportShowDataDataTable_0.ParentKeyCharColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKeyChar' in table 'vPassportShowData' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(string string_0)
			{
				base[this.vPassportShowDataDataTable_0.ParentKeyCharColumn] = string_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					return (string)base[this.vPassportShowDataDataTable_0.NameColumn];
				}
				set
				{
					base[this.vPassportShowDataDataTable_0.NameColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vPassportShowDataDataTable_0.ValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Value' in table 'vPassportShowData' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vPassportShowDataDataTable_0.ValueColumn] = value;
				}
			}

			public int method_8()
			{
				int result;
				try
				{
					result = (int)base[this.vPassportShowDataDataTable_0.TabIndexColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TabIndex' in table 'vPassportShowData' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(int int_0)
			{
				base[this.vPassportShowDataDataTable_0.TabIndexColumn] = int_0;
			}

			public bool method_10()
			{
				return (bool)base[this.vPassportShowDataDataTable_0.isGroupColumn];
			}

			public void method_11(bool bool_0)
			{
				base[this.vPassportShowDataDataTable_0.isGroupColumn] = bool_0;
			}

			public bool method_12()
			{
				return (bool)base[this.vPassportShowDataDataTable_0.DeletedColumn];
			}

			public void method_13(bool bool_0)
			{
				base[this.vPassportShowDataDataTable_0.DeletedColumn] = bool_0;
			}

			public bool method_14()
			{
				return (bool)base[this.vPassportShowDataDataTable_0.isActiveColumn];
			}

			public void method_15(bool bool_0)
			{
				base[this.vPassportShowDataDataTable_0.isActiveColumn] = bool_0;
			}

			public bool method_16()
			{
				return (bool)base[this.vPassportShowDataDataTable_0.CharDeletedColumn];
			}

			public void method_17(bool bool_0)
			{
				base[this.vPassportShowDataDataTable_0.CharDeletedColumn] = bool_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_18()
			{
				return base.IsNull(this.vPassportShowDataDataTable_0.ParentIdCharColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_19()
			{
				base[this.vPassportShowDataDataTable_0.ParentIdCharColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_20()
			{
				return base.IsNull(this.vPassportShowDataDataTable_0.ParentKeyCharColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.vPassportShowDataDataTable_0.ParentKeyCharColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_22()
			{
				return base.IsNull(this.vPassportShowDataDataTable_0.ValueColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_23()
			{
				base[this.vPassportShowDataDataTable_0.ValueColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_24()
			{
				return base.IsNull(this.vPassportShowDataDataTable_0.TabIndexColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_25()
			{
				base[this.vPassportShowDataDataTable_0.TabIndexColumn] = Convert.DBNull;
			}

			private dsPivotGrid.vPassportShowDataDataTable vPassportShowDataDataTable_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs140 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs140(dsPivotGrid.Class204 class204_1, DataRowAction dataRowAction_1)
			{
				this.class204_0 = class204_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public dsPivotGrid.Class204 method_0()
			{
				return this.class204_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private dsPivotGrid.Class204 class204_0;

			private DataRowAction dataRowAction_0;
		}
	}
}
