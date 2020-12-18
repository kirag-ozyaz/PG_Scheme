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

namespace Passport.Forms.Substation.Report.DataSet
{
	[XmlRoot("DataSetReportSubstation")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[ToolboxItem(true)]
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	public class DataSetReportSubstation : DataSet
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSetReportSubstation()
		{
			base.BeginInit();
			this.method_2();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_8);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected DataSetReportSubstation(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			if (base.IsBinarySerialized(info, context))
			{
				this.method_1(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_8);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
				return;
			}
			string s = (string)info.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["dtKTPMain"] != null)
				{
					base.Tables.Add(new DataSetReportSubstation.dtKTPMainDataTable(dataSet.Tables["dtKTPMain"]));
				}
				if (dataSet.Tables["dtEmpty"] != null)
				{
					base.Tables.Add(new DataSetReportSubstation.dtEmptyDataTable(dataSet.Tables["dtEmpty"]));
				}
				if (dataSet.Tables["dtEquipment"] != null)
				{
					base.Tables.Add(new DataSetReportSubstation.dtEquipmentDataTable(dataSet.Tables["dtEquipment"]));
				}
				if (dataSet.Tables["dtZTPMain"] != null)
				{
					base.Tables.Add(new DataSetReportSubstation.dtZTPMainDataTable(dataSet.Tables["dtZTPMain"]));
				}
				if (dataSet.Tables["dtNumberOfEntries"] != null)
				{
					base.Tables.Add(new DataSetReportSubstation.dtNumberOfEntriesDataTable(dataSet.Tables["dtNumberOfEntries"]));
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
			base.GetSerializationData(info, context);
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.method_8);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public DataSetReportSubstation.dtKTPMainDataTable dtKTPMain
		{
			get
			{
				return this.tabledtKTPMain;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetReportSubstation.dtEmptyDataTable dtEmpty
		{
			get
			{
				return this.tabledtEmpty;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public DataSetReportSubstation.dtEquipmentDataTable dtEquipment
		{
			get
			{
				return this.tabledtEquipment;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public DataSetReportSubstation.dtZTPMainDataTable dtZTPMain
		{
			get
			{
				return this.tabledtZTPMain;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportSubstation.dtNumberOfEntriesDataTable dtNumberOfEntries
		{
			get
			{
				return this.tabledtNumberOfEntries;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(true)]
		[DebuggerNonUserCode]
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
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			DataSetReportSubstation dataSetReportSubstation = (DataSetReportSubstation)base.Clone();
			dataSetReportSubstation.method_0();
			dataSetReportSubstation.SchemaSerializationMode = this.SchemaSerializationMode;
			return dataSetReportSubstation;
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
				if (dataSet.Tables["dtKTPMain"] != null)
				{
					base.Tables.Add(new DataSetReportSubstation.dtKTPMainDataTable(dataSet.Tables["dtKTPMain"]));
				}
				if (dataSet.Tables["dtEmpty"] != null)
				{
					base.Tables.Add(new DataSetReportSubstation.dtEmptyDataTable(dataSet.Tables["dtEmpty"]));
				}
				if (dataSet.Tables["dtEquipment"] != null)
				{
					base.Tables.Add(new DataSetReportSubstation.dtEquipmentDataTable(dataSet.Tables["dtEquipment"]));
				}
				if (dataSet.Tables["dtZTPMain"] != null)
				{
					base.Tables.Add(new DataSetReportSubstation.dtZTPMainDataTable(dataSet.Tables["dtZTPMain"]));
				}
				if (dataSet.Tables["dtNumberOfEntries"] != null)
				{
					base.Tables.Add(new DataSetReportSubstation.dtNumberOfEntriesDataTable(dataSet.Tables["dtNumberOfEntries"]));
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
			this.tabledtKTPMain = (DataSetReportSubstation.dtKTPMainDataTable)base.Tables["dtKTPMain"];
			if (bool_0 && this.tabledtKTPMain != null)
			{
				this.tabledtKTPMain.method_0();
			}
			this.tabledtEmpty = (DataSetReportSubstation.dtEmptyDataTable)base.Tables["dtEmpty"];
			if (bool_0 && this.tabledtEmpty != null)
			{
				this.tabledtEmpty.method_0();
			}
			this.tabledtEquipment = (DataSetReportSubstation.dtEquipmentDataTable)base.Tables["dtEquipment"];
			if (bool_0 && this.tabledtEquipment != null)
			{
				this.tabledtEquipment.method_0();
			}
			this.tabledtZTPMain = (DataSetReportSubstation.dtZTPMainDataTable)base.Tables["dtZTPMain"];
			if (bool_0 && this.tabledtZTPMain != null)
			{
				this.tabledtZTPMain.method_0();
			}
			this.tabledtNumberOfEntries = (DataSetReportSubstation.dtNumberOfEntriesDataTable)base.Tables["dtNumberOfEntries"];
			if (bool_0 && this.tabledtNumberOfEntries != null)
			{
				this.tabledtNumberOfEntries.method_0();
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_2()
		{
			base.DataSetName = "DataSetReportSubstation";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/DataSetReportSubstation.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tabledtKTPMain = new DataSetReportSubstation.dtKTPMainDataTable();
			base.Tables.Add(this.tabledtKTPMain);
			this.tabledtEmpty = new DataSetReportSubstation.dtEmptyDataTable();
			base.Tables.Add(this.tabledtEmpty);
			this.tabledtEquipment = new DataSetReportSubstation.dtEquipmentDataTable();
			base.Tables.Add(this.tabledtEquipment);
			this.tabledtZTPMain = new DataSetReportSubstation.dtZTPMainDataTable();
			base.Tables.Add(this.tabledtZTPMain);
			this.tabledtNumberOfEntries = new DataSetReportSubstation.dtNumberOfEntriesDataTable();
			base.Tables.Add(this.tabledtNumberOfEntries);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool method_3()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool method_4()
		{
			return false;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool method_5()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool method_6()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool method_7()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_8(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.method_0();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xmlSchemaSet_0)
		{
			DataSetReportSubstation dataSetReportSubstation = new DataSetReportSubstation();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dataSetReportSubstation.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSetReportSubstation.GetSchemaSerializable();
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

		private DataSetReportSubstation.dtKTPMainDataTable tabledtKTPMain;

		private DataSetReportSubstation.dtEmptyDataTable tabledtEmpty;

		private DataSetReportSubstation.dtEquipmentDataTable tabledtEquipment;

		private DataSetReportSubstation.dtZTPMainDataTable tabledtZTPMain;

		private DataSetReportSubstation.dtNumberOfEntriesDataTable tabledtNumberOfEntries;

		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtKTPMainRowChangeEventHandler(object sender, DataSetReportSubstation.dtKTPMainRowChangeEvent dtKTPMainRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtEmptyRowChangeEventHandler(object sender, DataSetReportSubstation.dtEmptyRowChangeEvent dtEmptyRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtEquipmentRowChangeEventHandler(object sender, DataSetReportSubstation.dtEquipmentRowChangeEvent dtEquipmentRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtZTPMainRowChangeEventHandler(object sender, DataSetReportSubstation.dtZTPMainRowChangeEvent dtZTPMainRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtNumberOfEntriesRowChangeEventHandler(object sender, DataSetReportSubstation.dtNumberOfEntriesRowChangeEvent dtNumberOfEntriesRowChangeEvent_0);

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtKTPMainDataTable : TypedTableBase<DataSetReportSubstation.dtKTPMainRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtKTPMainDataTable()
			{
				base.TableName = "dtKTPMain";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtKTPMainDataTable(DataTable dataTable_0)
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
			protected dtKTPMainDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
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
			public DataColumn DataColumn_0
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_1
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_2
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_3
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_4
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_5
			{
				get
				{
					return this.dataColumn_5;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_6
			{
				get
				{
					return this.dataColumn_6;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_7
			{
				get
				{
					return this.dataColumn_7;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_8
			{
				get
				{
					return this.dataColumn_8;
				}
			}

			[Browsable(false)]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportSubstation.dtKTPMainRow this[int index]
			{
				get
				{
					return (DataSetReportSubstation.dtKTPMainRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtKTPMainRow(DataSetReportSubstation.dtKTPMainRow dtKTPMainRow_0)
			{
				base.Rows.Add(dtKTPMainRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtKTPMainRow AdddtKTPMainRow(int idObjList, string Name, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8)
			{
				DataSetReportSubstation.dtKTPMainRow dtKTPMainRow = (DataSetReportSubstation.dtKTPMainRow)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					idObjList,
					Name,
					string_0,
					string_1,
					string_2,
					string_3,
					string_4,
					string_5,
					string_6,
					string_7,
					string_8
				};
				dtKTPMainRow.ItemArray = itemArray;
				base.Rows.Add(dtKTPMainRow);
				return dtKTPMainRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportSubstation.dtKTPMainDataTable dtKTPMainDataTable = (DataSetReportSubstation.dtKTPMainDataTable)base.Clone();
				dtKTPMainDataTable.method_0();
				return dtKTPMainDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportSubstation.dtKTPMainDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.columnid = base.Columns["id"];
				this.columnidObjList = base.Columns["idObjList"];
				this.columnName = base.Columns["Name"];
				this.dataColumn_0 = base.Columns["Тип"];
				this.dataColumn_1 = base.Columns["Инвентарный_номер"];
				this.dataColumn_2 = base.Columns["Регион"];
				this.dataColumn_3 = base.Columns["Улица"];
				this.dataColumn_4 = base.Columns["Дом"];
				this.dataColumn_5 = base.Columns["Дополнительно"];
				this.dataColumn_6 = base.Columns["Тип_ТП"];
				this.dataColumn_7 = base.Columns["Год_постройки"];
				this.dataColumn_8 = base.Columns["Год_ввода_в_эксплуатацию"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidObjList = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObjList);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.dataColumn_0 = new DataColumn("Тип", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Инвентарный_номер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("Регион", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("Улица", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("Дом", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Дополнительно", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("Тип_ТП", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("Год_постройки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("Год_ввода_в_эксплуатацию", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = -1L;
				this.columnid.AutoIncrementStep = -1L;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtKTPMainRow NewdtKTPMainRow()
			{
				return (DataSetReportSubstation.dtKTPMainRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportSubstation.dtKTPMainRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportSubstation.dtKTPMainRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtKTPMainRowChanged != null)
				{
					this.dtKTPMainRowChanged(this, new DataSetReportSubstation.dtKTPMainRowChangeEvent((DataSetReportSubstation.dtKTPMainRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtKTPMainRowChanging != null)
				{
					this.dtKTPMainRowChanging(this, new DataSetReportSubstation.dtKTPMainRowChangeEvent((DataSetReportSubstation.dtKTPMainRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtKTPMainRowDeleted != null)
				{
					this.dtKTPMainRowDeleted(this, new DataSetReportSubstation.dtKTPMainRowChangeEvent((DataSetReportSubstation.dtKTPMainRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtKTPMainRowDeleting != null)
				{
					this.dtKTPMainRowDeleting(this, new DataSetReportSubstation.dtKTPMainRowChangeEvent((DataSetReportSubstation.dtKTPMainRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtKTPMainRow(DataSetReportSubstation.dtKTPMainRow dtKTPMainRow_0)
			{
				base.Rows.Remove(dtKTPMainRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportSubstation dataSetReportSubstation = new DataSetReportSubstation();
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
				xmlSchemaAttribute.FixedValue = dataSetReportSubstation.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtKTPMainDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportSubstation.GetSchemaSerializable();
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

			private DataColumn columnName;

			private DataColumn dataColumn_0;

			private DataColumn dataColumn_1;

			private DataColumn dataColumn_2;

			private DataColumn dataColumn_3;

			private DataColumn dataColumn_4;

			private DataColumn dataColumn_5;

			private DataColumn dataColumn_6;

			private DataColumn dataColumn_7;

			private DataColumn dataColumn_8;
		}

		public class dtKTPMainRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtKTPMainRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.dtKTPMainDataTable_0 = (DataSetReportSubstation.dtKTPMainDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Int32_0
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtKTPMainDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtKTPMainDataTable_0.idColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idObjList
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtKTPMainDataTable_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtKTPMainDataTable_0.idObjListColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtKTPMainDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtKTPMainDataTable_0.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_0
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtKTPMainDataTable_0.DataColumn_0];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Тип' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtKTPMainDataTable_0.DataColumn_0] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_1
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtKTPMainDataTable_0.DataColumn_1];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Инвентарный_номер' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtKTPMainDataTable_0.DataColumn_1] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_2
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtKTPMainDataTable_0.DataColumn_2];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Регион' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtKTPMainDataTable_0.DataColumn_2] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_3
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtKTPMainDataTable_0.DataColumn_3];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Улица' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtKTPMainDataTable_0.DataColumn_3] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_4
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtKTPMainDataTable_0.DataColumn_4];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Дом' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtKTPMainDataTable_0.DataColumn_4] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_5
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtKTPMainDataTable_0.DataColumn_5];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Дополнительно' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtKTPMainDataTable_0.DataColumn_5] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_6
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtKTPMainDataTable_0.DataColumn_6];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Тип_ТП' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtKTPMainDataTable_0.DataColumn_6] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_7
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtKTPMainDataTable_0.DataColumn_7];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_постройки' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtKTPMainDataTable_0.DataColumn_7] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_8
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtKTPMainDataTable_0.DataColumn_8];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_ввода_в_эксплуатацию' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtKTPMainDataTable_0.DataColumn_8] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidNull()
			{
				return base.IsNull(this.dtKTPMainDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.dtKTPMainDataTable_0.idColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.dtKTPMainDataTable_0.idObjListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidObjListNull()
			{
				base[this.dtKTPMainDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtKTPMainDataTable_0.NameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameNull()
			{
				base[this.dtKTPMainDataTable_0.NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_0()
			{
				return base.IsNull(this.dtKTPMainDataTable_0.DataColumn_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_1()
			{
				base[this.dtKTPMainDataTable_0.DataColumn_0] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_2()
			{
				return base.IsNull(this.dtKTPMainDataTable_0.DataColumn_1);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_3()
			{
				base[this.dtKTPMainDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_4()
			{
				return base.IsNull(this.dtKTPMainDataTable_0.DataColumn_2);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5()
			{
				base[this.dtKTPMainDataTable_0.DataColumn_2] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.dtKTPMainDataTable_0.DataColumn_3);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7()
			{
				base[this.dtKTPMainDataTable_0.DataColumn_3] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_8()
			{
				return base.IsNull(this.dtKTPMainDataTable_0.DataColumn_4);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_9()
			{
				base[this.dtKTPMainDataTable_0.DataColumn_4] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_10()
			{
				return base.IsNull(this.dtKTPMainDataTable_0.DataColumn_5);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_11()
			{
				base[this.dtKTPMainDataTable_0.DataColumn_5] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_12()
			{
				return base.IsNull(this.dtKTPMainDataTable_0.DataColumn_6);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_13()
			{
				base[this.dtKTPMainDataTable_0.DataColumn_6] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_14()
			{
				return base.IsNull(this.dtKTPMainDataTable_0.DataColumn_7);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_15()
			{
				base[this.dtKTPMainDataTable_0.DataColumn_7] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_16()
			{
				return base.IsNull(this.dtKTPMainDataTable_0.DataColumn_8);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_17()
			{
				base[this.dtKTPMainDataTable_0.DataColumn_8] = Convert.DBNull;
			}

			private DataSetReportSubstation.dtKTPMainDataTable dtKTPMainDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtEmptyDataTable : TypedTableBase<DataSetReportSubstation.dtEmptyRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtEmptyDataTable()
			{
				base.TableName = "dtEmpty";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtEmptyDataTable(DataTable dataTable_0)
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected dtEmptyDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			[DebuggerNonUserCode]
			[Browsable(false)]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportSubstation.dtEmptyRow this[int index]
			{
				get
				{
					return (DataSetReportSubstation.dtEmptyRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtEmptyRow(DataSetReportSubstation.dtEmptyRow dtEmptyRow_0)
			{
				base.Rows.Add(dtEmptyRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportSubstation.dtEmptyRow AdddtEmptyRow(string Name)
			{
				DataSetReportSubstation.dtEmptyRow dtEmptyRow = (DataSetReportSubstation.dtEmptyRow)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					Name
				};
				dtEmptyRow.ItemArray = itemArray;
				base.Rows.Add(dtEmptyRow);
				return dtEmptyRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportSubstation.dtEmptyDataTable dtEmptyDataTable = (DataSetReportSubstation.dtEmptyDataTable)base.Clone();
				dtEmptyDataTable.method_0();
				return dtEmptyDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportSubstation.dtEmptyDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.columnid = base.Columns["id"];
				this.columnName = base.Columns["Name"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = -1L;
				this.columnid.AutoIncrementStep = -1L;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtEmptyRow NewdtEmptyRow()
			{
				return (DataSetReportSubstation.dtEmptyRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportSubstation.dtEmptyRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportSubstation.dtEmptyRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtEmptyRowChanged != null)
				{
					this.dtEmptyRowChanged(this, new DataSetReportSubstation.dtEmptyRowChangeEvent((DataSetReportSubstation.dtEmptyRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtEmptyRowChanging != null)
				{
					this.dtEmptyRowChanging(this, new DataSetReportSubstation.dtEmptyRowChangeEvent((DataSetReportSubstation.dtEmptyRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtEmptyRowDeleted != null)
				{
					this.dtEmptyRowDeleted(this, new DataSetReportSubstation.dtEmptyRowChangeEvent((DataSetReportSubstation.dtEmptyRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtEmptyRowDeleting != null)
				{
					this.dtEmptyRowDeleting(this, new DataSetReportSubstation.dtEmptyRowChangeEvent((DataSetReportSubstation.dtEmptyRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtEmptyRow(DataSetReportSubstation.dtEmptyRow dtEmptyRow_0)
			{
				base.Rows.Remove(dtEmptyRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportSubstation dataSetReportSubstation = new DataSetReportSubstation();
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
				xmlSchemaAttribute.FixedValue = dataSetReportSubstation.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtEmptyDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportSubstation.GetSchemaSerializable();
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

			private DataColumn columnName;
		}

		public class dtEmptyRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtEmptyRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.dtEmptyDataTable_0 = (DataSetReportSubstation.dtEmptyDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtEmptyDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'dtEmpty' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEmptyDataTable_0.idColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEmptyDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtEmpty' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEmptyDataTable_0.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidNull()
			{
				return base.IsNull(this.dtEmptyDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.dtEmptyDataTable_0.idColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtEmptyDataTable_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.dtEmptyDataTable_0.NameColumn] = Convert.DBNull;
			}

			private DataSetReportSubstation.dtEmptyDataTable dtEmptyDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtEquipmentDataTable : TypedTableBase<DataSetReportSubstation.dtEquipmentRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtEquipmentDataTable()
			{
				base.TableName = "dtEquipment";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtEquipmentDataTable(DataTable dataTable_0)
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
			protected dtEquipmentDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn GroupNameColumn
			{
				get
				{
					return this.columnGroupName;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn typeCodeIdColumn
			{
				get
				{
					return this.columntypeCodeId;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn typeNameColumn
			{
				get
				{
					return this.columntypeName;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_0
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_1
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_2
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_3
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_4
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_5
			{
				get
				{
					return this.dataColumn_5;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_6
			{
				get
				{
					return this.dataColumn_6;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_7
			{
				get
				{
					return this.dataColumn_7;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_8
			{
				get
				{
					return this.dataColumn_8;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_9
			{
				get
				{
					return this.dataColumn_9;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_10
			{
				get
				{
					return this.dataColumn_10;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_11
			{
				get
				{
					return this.dataColumn_11;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_12
			{
				get
				{
					return this.dataColumn_12;
				}
			}

			[DebuggerNonUserCode]
			[Browsable(false)]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportSubstation.dtEquipmentRow this[int index]
			{
				get
				{
					return (DataSetReportSubstation.dtEquipmentRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtEquipmentRow(DataSetReportSubstation.dtEquipmentRow dtEquipmentRow_0)
			{
				base.Rows.Add(dtEquipmentRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportSubstation.dtEquipmentRow AdddtEquipmentRow(int idObjList, string GroupName, int typeCodeId, string typeName, string Name, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, string string_12)
			{
				DataSetReportSubstation.dtEquipmentRow dtEquipmentRow = (DataSetReportSubstation.dtEquipmentRow)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					idObjList,
					GroupName,
					typeCodeId,
					typeName,
					Name,
					string_0,
					string_1,
					string_2,
					string_3,
					string_4,
					string_5,
					string_6,
					string_7,
					string_8,
					string_9,
					string_10,
					string_11,
					string_12
				};
				dtEquipmentRow.ItemArray = itemArray;
				base.Rows.Add(dtEquipmentRow);
				return dtEquipmentRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportSubstation.dtEquipmentDataTable dtEquipmentDataTable = (DataSetReportSubstation.dtEquipmentDataTable)base.Clone();
				dtEquipmentDataTable.method_0();
				return dtEquipmentDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportSubstation.dtEquipmentDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.columnid = base.Columns["id"];
				this.columnidObjList = base.Columns["idObjList"];
				this.columnGroupName = base.Columns["GroupName"];
				this.columntypeCodeId = base.Columns["typeCodeId"];
				this.columntypeName = base.Columns["typeName"];
				this.columnName = base.Columns["Name"];
				this.dataColumn_0 = base.Columns["Тип"];
				this.dataColumn_1 = base.Columns["Мощность"];
				this.dataColumn_2 = base.Columns["Номинальный_ток"];
				this.dataColumn_3 = base.Columns["Номинальное_напряжение"];
				this.dataColumn_4 = base.Columns["Заводской_номер"];
				this.dataColumn_5 = base.Columns["Год_установки"];
				this.dataColumn_6 = base.Columns["Инвентарный_номер"];
				this.dataColumn_7 = base.Columns["Артикул"];
				this.dataColumn_8 = base.Columns["Завод_изготовитель"];
				this.dataColumn_9 = base.Columns["Год_изготовления"];
				this.dataColumn_10 = base.Columns["Завод__изготовитель"];
				this.dataColumn_11 = base.Columns["Группа_соединений_обмоток"];
				this.dataColumn_12 = base.Columns["Описание"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidObjList = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObjList);
				this.columnGroupName = new DataColumn("GroupName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGroupName);
				this.columntypeCodeId = new DataColumn("typeCodeId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columntypeCodeId);
				this.columntypeName = new DataColumn("typeName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntypeName);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.dataColumn_0 = new DataColumn("Тип", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Мощность", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("Номинальный_ток", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("Номинальное_напряжение", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("Заводской_номер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Год_установки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("Инвентарный_номер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("Артикул", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("Завод_изготовитель", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("Год_изготовления", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("Завод__изготовитель", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("Группа_соединений_обмоток", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("Описание", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = -1L;
				this.columnid.AutoIncrementStep = -1L;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtEquipmentRow NewdtEquipmentRow()
			{
				return (DataSetReportSubstation.dtEquipmentRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportSubstation.dtEquipmentRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportSubstation.dtEquipmentRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtEquipmentRowChanged != null)
				{
					this.dtEquipmentRowChanged(this, new DataSetReportSubstation.dtEquipmentRowChangeEvent((DataSetReportSubstation.dtEquipmentRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtEquipmentRowChanging != null)
				{
					this.dtEquipmentRowChanging(this, new DataSetReportSubstation.dtEquipmentRowChangeEvent((DataSetReportSubstation.dtEquipmentRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtEquipmentRowDeleted != null)
				{
					this.dtEquipmentRowDeleted(this, new DataSetReportSubstation.dtEquipmentRowChangeEvent((DataSetReportSubstation.dtEquipmentRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtEquipmentRowDeleting != null)
				{
					this.dtEquipmentRowDeleting(this, new DataSetReportSubstation.dtEquipmentRowChangeEvent((DataSetReportSubstation.dtEquipmentRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovedtEquipmentRow(DataSetReportSubstation.dtEquipmentRow dtEquipmentRow_0)
			{
				base.Rows.Remove(dtEquipmentRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportSubstation dataSetReportSubstation = new DataSetReportSubstation();
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
				xmlSchemaAttribute.FixedValue = dataSetReportSubstation.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtEquipmentDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportSubstation.GetSchemaSerializable();
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

			private DataColumn columnGroupName;

			private DataColumn columntypeCodeId;

			private DataColumn columntypeName;

			private DataColumn columnName;

			private DataColumn dataColumn_0;

			private DataColumn dataColumn_1;

			private DataColumn dataColumn_2;

			private DataColumn dataColumn_3;

			private DataColumn dataColumn_4;

			private DataColumn dataColumn_5;

			private DataColumn dataColumn_6;

			private DataColumn dataColumn_7;

			private DataColumn dataColumn_8;

			private DataColumn dataColumn_9;

			private DataColumn dataColumn_10;

			private DataColumn dataColumn_11;

			private DataColumn dataColumn_12;
		}

		public class dtEquipmentRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtEquipmentRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.dtEquipmentDataTable_0 = (DataSetReportSubstation.dtEquipmentDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Int32_0
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtEquipmentDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.idColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idObjList
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtEquipmentDataTable_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.idObjListColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string GroupName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.GroupNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'GroupName' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.GroupNameColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int typeCodeId
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtEquipmentDataTable_0.typeCodeIdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'typeCodeId' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.typeCodeIdColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string typeName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.typeNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'typeName' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.typeNameColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_0
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_0];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Тип' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_0] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_1
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_1];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Мощность' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_1] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_2
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_2];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Номинальный_ток' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_2] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_3
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_3];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Номинальное_напряжение' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_3] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_4
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_4];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Заводской_номер' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_4] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_5
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_5];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_установки' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_5] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_6
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_6];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Инвентарный_номер' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_6] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_7
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_7];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Артикул' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_7] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_8
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_8];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Завод_изготовитель' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_8] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_9
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_9];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_изготовления' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_9] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_10
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_10];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Завод__изготовитель' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_10] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_11
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_11];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Группа_соединений_обмоток' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_11] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_12
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtEquipmentDataTable_0.DataColumn_12];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Описание' in table 'dtEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtEquipmentDataTable_0.DataColumn_12] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidNull()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.dtEquipmentDataTable_0.idColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.idObjListColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidObjListNull()
			{
				base[this.dtEquipmentDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsGroupNameNull()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.GroupNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetGroupNameNull()
			{
				base[this.dtEquipmentDataTable_0.GroupNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IstypeCodeIdNull()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.typeCodeIdColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SettypeCodeIdNull()
			{
				base[this.dtEquipmentDataTable_0.typeCodeIdColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IstypeNameNull()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.typeNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SettypeNameNull()
			{
				base[this.dtEquipmentDataTable_0.typeNameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.dtEquipmentDataTable_0.NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_0()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_1()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_0] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_2()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_1);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_3()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_4()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_2);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_2] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_3);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_3] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_8()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_4);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_9()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_4] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_10()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_5);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_11()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_5] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_12()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_6);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_13()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_6] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_14()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_7);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_15()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_7] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_16()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_8);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_17()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_8] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_18()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_9);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_19()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_9] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_20()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_10);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_21()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_10] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_22()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_11);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_23()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_11] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_12);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_12] = Convert.DBNull;
			}

			private DataSetReportSubstation.dtEquipmentDataTable dtEquipmentDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtZTPMainDataTable : TypedTableBase<DataSetReportSubstation.dtZTPMainRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtZTPMainDataTable()
			{
				base.TableName = "dtZTPMain";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtZTPMainDataTable(DataTable dataTable_0)
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected dtZTPMainDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEquipmentColumn
			{
				get
				{
					return this.columnidEquipment;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_0
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_1
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_2
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_3
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_4
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_5
			{
				get
				{
					return this.dataColumn_5;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_6
			{
				get
				{
					return this.dataColumn_6;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_7
			{
				get
				{
					return this.dataColumn_7;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_8
			{
				get
				{
					return this.dataColumn_8;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_9
			{
				get
				{
					return this.dataColumn_9;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_10
			{
				get
				{
					return this.dataColumn_10;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_11
			{
				get
				{
					return this.dataColumn_11;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_12
			{
				get
				{
					return this.dataColumn_12;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_13
			{
				get
				{
					return this.dataColumn_13;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_14
			{
				get
				{
					return this.dataColumn_14;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_15
			{
				get
				{
					return this.dataColumn_15;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_16
			{
				get
				{
					return this.dataColumn_16;
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
			public DataSetReportSubstation.dtZTPMainRow this[int index]
			{
				get
				{
					return (DataSetReportSubstation.dtZTPMainRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtZTPMainRow(DataSetReportSubstation.dtZTPMainRow dtZTPMainRow_0)
			{
				base.Rows.Add(dtZTPMainRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtZTPMainRow AdddtZTPMainRow(int int_0, int idObjList, int idEquipment, string Name, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, string string_12, string string_13, string string_14, string string_15, string string_16)
			{
				DataSetReportSubstation.dtZTPMainRow dtZTPMainRow = (DataSetReportSubstation.dtZTPMainRow)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
					idObjList,
					idEquipment,
					Name,
					string_0,
					string_1,
					string_2,
					string_3,
					string_4,
					string_5,
					string_6,
					string_7,
					string_8,
					string_9,
					string_10,
					string_11,
					string_12,
					string_13,
					string_14,
					string_15,
					string_16
				};
				dtZTPMainRow.ItemArray = itemArray;
				base.Rows.Add(dtZTPMainRow);
				return dtZTPMainRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportSubstation.dtZTPMainDataTable dtZTPMainDataTable = (DataSetReportSubstation.dtZTPMainDataTable)base.Clone();
				dtZTPMainDataTable.method_0();
				return dtZTPMainDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportSubstation.dtZTPMainDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.columnid = base.Columns["id"];
				this.columnidObjList = base.Columns["idObjList"];
				this.columnidEquipment = base.Columns["idEquipment"];
				this.columnName = base.Columns["Name"];
				this.dataColumn_0 = base.Columns["Тип"];
				this.dataColumn_1 = base.Columns["Год_ввода_в_эксплуатацию"];
				this.dataColumn_2 = base.Columns["Заводской_номер"];
				this.dataColumn_3 = base.Columns["Регион"];
				this.dataColumn_4 = base.Columns["Улица"];
				this.dataColumn_5 = base.Columns["Дом"];
				this.dataColumn_6 = base.Columns["Дополнительно"];
				this.dataColumn_7 = base.Columns["Инвентарный_номер"];
				this.dataColumn_8 = base.Columns["Типовой_проект"];
				this.dataColumn_9 = base.Columns["Длина"];
				this.dataColumn_10 = base.Columns["Ширина"];
				this.dataColumn_11 = base.Columns["Высота"];
				this.dataColumn_12 = base.Columns["Площадь_без_ОЗ"];
				this.dataColumn_13 = base.Columns["Площадь_с_ОЗ"];
				this.dataColumn_14 = base.Columns["Материал"];
				this.dataColumn_15 = base.Columns["Грозозащита"];
				this.dataColumn_16 = base.Columns["Год_постройки"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidObjList = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObjList);
				this.columnidEquipment = new DataColumn("idEquipment", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEquipment);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.dataColumn_0 = new DataColumn("Тип", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Год_ввода_в_эксплуатацию", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("Заводской_номер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("Регион", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("Улица", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Дом", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("Дополнительно", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("Инвентарный_номер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("Типовой_проект", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("Длина", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("Ширина", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("Высота", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("Площадь_без_ОЗ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
				this.dataColumn_13 = new DataColumn("Площадь_с_ОЗ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_13);
				this.dataColumn_14 = new DataColumn("Материал", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_14);
				this.dataColumn_15 = new DataColumn("Грозозащита", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_15);
				this.dataColumn_16 = new DataColumn("Год_постройки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_16);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtZTPMainRow NewdtZTPMainRow()
			{
				return (DataSetReportSubstation.dtZTPMainRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportSubstation.dtZTPMainRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportSubstation.dtZTPMainRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtZTPMainRowChanged != null)
				{
					this.dtZTPMainRowChanged(this, new DataSetReportSubstation.dtZTPMainRowChangeEvent((DataSetReportSubstation.dtZTPMainRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtZTPMainRowChanging != null)
				{
					this.dtZTPMainRowChanging(this, new DataSetReportSubstation.dtZTPMainRowChangeEvent((DataSetReportSubstation.dtZTPMainRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtZTPMainRowDeleted != null)
				{
					this.dtZTPMainRowDeleted(this, new DataSetReportSubstation.dtZTPMainRowChangeEvent((DataSetReportSubstation.dtZTPMainRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtZTPMainRowDeleting != null)
				{
					this.dtZTPMainRowDeleting(this, new DataSetReportSubstation.dtZTPMainRowChangeEvent((DataSetReportSubstation.dtZTPMainRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovedtZTPMainRow(DataSetReportSubstation.dtZTPMainRow dtZTPMainRow_0)
			{
				base.Rows.Remove(dtZTPMainRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportSubstation dataSetReportSubstation = new DataSetReportSubstation();
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
				xmlSchemaAttribute.FixedValue = dataSetReportSubstation.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtZTPMainDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportSubstation.GetSchemaSerializable();
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

			private DataColumn columnidEquipment;

			private DataColumn columnName;

			private DataColumn dataColumn_0;

			private DataColumn dataColumn_1;

			private DataColumn dataColumn_2;

			private DataColumn dataColumn_3;

			private DataColumn dataColumn_4;

			private DataColumn dataColumn_5;

			private DataColumn dataColumn_6;

			private DataColumn dataColumn_7;

			private DataColumn dataColumn_8;

			private DataColumn dataColumn_9;

			private DataColumn dataColumn_10;

			private DataColumn dataColumn_11;

			private DataColumn dataColumn_12;

			private DataColumn dataColumn_13;

			private DataColumn dataColumn_14;

			private DataColumn dataColumn_15;

			private DataColumn dataColumn_16;
		}

		public class dtZTPMainRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtZTPMainRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.dtZTPMainDataTable_0 = (DataSetReportSubstation.dtZTPMainDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtZTPMainDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.idColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idObjList
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtZTPMainDataTable_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.idObjListColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idEquipment
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtZTPMainDataTable_0.idEquipmentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idEquipment' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.idEquipmentColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.NameColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_0
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_0];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Тип' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_0] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_1
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_1];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_ввода_в_эксплуатацию' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_1] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_2
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_2];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Заводской_номер' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_2] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_3
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_3];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Регион' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_3] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_4
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_4];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Улица' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_4] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_5
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_5];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Дом' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_5] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_6
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_6];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Дополнительно' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_6] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_7
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_7];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Инвентарный_номер' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_7] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_8
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_8];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Типовой_проект' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_8] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_9
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_9];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Длина' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_9] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_10
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_10];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ширина' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_10] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_11
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_11];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Высота' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_11] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_12
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_12];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Площадь_без_ОЗ' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_12] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_13
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_13];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Площадь_с_ОЗ' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_13] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_14
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_14];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Материал' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_14] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_15
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_15];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Грозозащита' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_15] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_16
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtZTPMainDataTable_0.DataColumn_16];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_постройки' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtZTPMainDataTable_0.DataColumn_16] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidNull()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.dtZTPMainDataTable_0.idColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.idObjListColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidObjListNull()
			{
				base[this.dtZTPMainDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidEquipmentNull()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.idEquipmentColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidEquipmentNull()
			{
				base[this.dtZTPMainDataTable_0.idEquipmentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.dtZTPMainDataTable_0.NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_0()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_1()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_0] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_2()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_1);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_3()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_4()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_2);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_2] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_3);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_3] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_8()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_4);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_9()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_4] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_10()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_5);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_11()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_5] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_12()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_6);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_13()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_6] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_14()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_7);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_15()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_7] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_16()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_8);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_17()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_8] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_18()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_9);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_9] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_20()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_10);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_21()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_10] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_22()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_11);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_23()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_11] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_24()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_12);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_12] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_26()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_13);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_27()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_13] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_28()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_14);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_29()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_14] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_30()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_15);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_31()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_15] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_32()
			{
				return base.IsNull(this.dtZTPMainDataTable_0.DataColumn_16);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_33()
			{
				base[this.dtZTPMainDataTable_0.DataColumn_16] = Convert.DBNull;
			}

			private DataSetReportSubstation.dtZTPMainDataTable dtZTPMainDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtNumberOfEntriesDataTable : TypedTableBase<DataSetReportSubstation.dtNumberOfEntriesRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtNumberOfEntriesDataTable()
			{
				base.TableName = "dtNumberOfEntries";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtNumberOfEntriesDataTable(DataTable dataTable_0)
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected dtNumberOfEntriesDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CountAirLineLVColumn
			{
				get
				{
					return this.columnCountAirLineLV;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CountAirLineHVColumn
			{
				get
				{
					return this.columnCountAirLineHV;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CountCableLineLVColumn
			{
				get
				{
					return this.columnCountCableLineLV;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CountCableLineHVColumn
			{
				get
				{
					return this.columnCountCableLineHV;
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportSubstation.dtNumberOfEntriesRow this[int index]
			{
				get
				{
					return (DataSetReportSubstation.dtNumberOfEntriesRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtNumberOfEntriesRow(DataSetReportSubstation.dtNumberOfEntriesRow dtNumberOfEntriesRow_0)
			{
				base.Rows.Add(dtNumberOfEntriesRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtNumberOfEntriesRow AdddtNumberOfEntriesRow(int CountAirLineLV, int CountAirLineHV, int CountCableLineLV, int CountCableLineHV)
			{
				DataSetReportSubstation.dtNumberOfEntriesRow dtNumberOfEntriesRow = (DataSetReportSubstation.dtNumberOfEntriesRow)base.NewRow();
				object[] itemArray = new object[]
				{
					CountAirLineLV,
					CountAirLineHV,
					CountCableLineLV,
					CountCableLineHV
				};
				dtNumberOfEntriesRow.ItemArray = itemArray;
				base.Rows.Add(dtNumberOfEntriesRow);
				return dtNumberOfEntriesRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportSubstation.dtNumberOfEntriesDataTable dtNumberOfEntriesDataTable = (DataSetReportSubstation.dtNumberOfEntriesDataTable)base.Clone();
				dtNumberOfEntriesDataTable.method_0();
				return dtNumberOfEntriesDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportSubstation.dtNumberOfEntriesDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.columnCountAirLineLV = base.Columns["CountAirLineLV"];
				this.columnCountAirLineHV = base.Columns["CountAirLineHV"];
				this.columnCountCableLineLV = base.Columns["CountCableLineLV"];
				this.columnCountCableLineHV = base.Columns["CountCableLineHV"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.columnCountAirLineLV = new DataColumn("CountAirLineLV", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnCountAirLineLV);
				this.columnCountAirLineHV = new DataColumn("CountAirLineHV", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnCountAirLineHV);
				this.columnCountCableLineLV = new DataColumn("CountCableLineLV", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnCountCableLineLV);
				this.columnCountCableLineHV = new DataColumn("CountCableLineHV", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnCountCableLineHV);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtNumberOfEntriesRow NewdtNumberOfEntriesRow()
			{
				return (DataSetReportSubstation.dtNumberOfEntriesRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportSubstation.dtNumberOfEntriesRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportSubstation.dtNumberOfEntriesRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtNumberOfEntriesRowChanged != null)
				{
					this.dtNumberOfEntriesRowChanged(this, new DataSetReportSubstation.dtNumberOfEntriesRowChangeEvent((DataSetReportSubstation.dtNumberOfEntriesRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtNumberOfEntriesRowChanging != null)
				{
					this.dtNumberOfEntriesRowChanging(this, new DataSetReportSubstation.dtNumberOfEntriesRowChangeEvent((DataSetReportSubstation.dtNumberOfEntriesRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtNumberOfEntriesRowDeleted != null)
				{
					this.dtNumberOfEntriesRowDeleted(this, new DataSetReportSubstation.dtNumberOfEntriesRowChangeEvent((DataSetReportSubstation.dtNumberOfEntriesRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtNumberOfEntriesRowDeleting != null)
				{
					this.dtNumberOfEntriesRowDeleting(this, new DataSetReportSubstation.dtNumberOfEntriesRowChangeEvent((DataSetReportSubstation.dtNumberOfEntriesRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtNumberOfEntriesRow(DataSetReportSubstation.dtNumberOfEntriesRow dtNumberOfEntriesRow_0)
			{
				base.Rows.Remove(dtNumberOfEntriesRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportSubstation dataSetReportSubstation = new DataSetReportSubstation();
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
				xmlSchemaAttribute.FixedValue = dataSetReportSubstation.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtNumberOfEntriesDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportSubstation.GetSchemaSerializable();
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

			private DataColumn columnCountAirLineLV;

			private DataColumn columnCountAirLineHV;

			private DataColumn columnCountCableLineLV;

			private DataColumn columnCountCableLineHV;
		}

		public class dtNumberOfEntriesRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtNumberOfEntriesRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.dtNumberOfEntriesDataTable_0 = (DataSetReportSubstation.dtNumberOfEntriesDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int CountAirLineLV
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtNumberOfEntriesDataTable_0.CountAirLineLVColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CountAirLineLV' in table 'dtNumberOfEntries' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtNumberOfEntriesDataTable_0.CountAirLineLVColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int CountAirLineHV
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtNumberOfEntriesDataTable_0.CountAirLineHVColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CountAirLineHV' in table 'dtNumberOfEntries' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtNumberOfEntriesDataTable_0.CountAirLineHVColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int CountCableLineLV
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtNumberOfEntriesDataTable_0.CountCableLineLVColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CountCableLineLV' in table 'dtNumberOfEntries' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtNumberOfEntriesDataTable_0.CountCableLineLVColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int CountCableLineHV
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtNumberOfEntriesDataTable_0.CountCableLineHVColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CountCableLineHV' in table 'dtNumberOfEntries' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtNumberOfEntriesDataTable_0.CountCableLineHVColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsCountAirLineLVNull()
			{
				return base.IsNull(this.dtNumberOfEntriesDataTable_0.CountAirLineLVColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetCountAirLineLVNull()
			{
				base[this.dtNumberOfEntriesDataTable_0.CountAirLineLVColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsCountAirLineHVNull()
			{
				return base.IsNull(this.dtNumberOfEntriesDataTable_0.CountAirLineHVColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetCountAirLineHVNull()
			{
				base[this.dtNumberOfEntriesDataTable_0.CountAirLineHVColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsCountCableLineLVNull()
			{
				return base.IsNull(this.dtNumberOfEntriesDataTable_0.CountCableLineLVColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCountCableLineLVNull()
			{
				base[this.dtNumberOfEntriesDataTable_0.CountCableLineLVColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCountCableLineHVNull()
			{
				return base.IsNull(this.dtNumberOfEntriesDataTable_0.CountCableLineHVColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetCountCableLineHVNull()
			{
				base[this.dtNumberOfEntriesDataTable_0.CountCableLineHVColumn] = Convert.DBNull;
			}

			private DataSetReportSubstation.dtNumberOfEntriesDataTable dtNumberOfEntriesDataTable_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtKTPMainRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtKTPMainRowChangeEvent(DataSetReportSubstation.dtKTPMainRow dtKTPMainRow_1, DataRowAction action)
			{
				this.dtKTPMainRow_0 = dtKTPMainRow_1;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportSubstation.dtKTPMainRow Row
			{
				get
				{
					return this.dtKTPMainRow_0;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.dataRowAction_0;
				}
			}

			private DataSetReportSubstation.dtKTPMainRow dtKTPMainRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtEmptyRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtEmptyRowChangeEvent(DataSetReportSubstation.dtEmptyRow dtEmptyRow_1, DataRowAction action)
			{
				this.dtEmptyRow_0 = dtEmptyRow_1;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportSubstation.dtEmptyRow Row
			{
				get
				{
					return this.dtEmptyRow_0;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.dataRowAction_0;
				}
			}

			private DataSetReportSubstation.dtEmptyRow dtEmptyRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtEquipmentRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtEquipmentRowChangeEvent(DataSetReportSubstation.dtEquipmentRow dtEquipmentRow_1, DataRowAction action)
			{
				this.dtEquipmentRow_0 = dtEquipmentRow_1;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportSubstation.dtEquipmentRow Row
			{
				get
				{
					return this.dtEquipmentRow_0;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.dataRowAction_0;
				}
			}

			private DataSetReportSubstation.dtEquipmentRow dtEquipmentRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtZTPMainRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtZTPMainRowChangeEvent(DataSetReportSubstation.dtZTPMainRow dtZTPMainRow_1, DataRowAction action)
			{
				this.dtZTPMainRow_0 = dtZTPMainRow_1;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtZTPMainRow Row
			{
				get
				{
					return this.dtZTPMainRow_0;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.dataRowAction_0;
				}
			}

			private DataSetReportSubstation.dtZTPMainRow dtZTPMainRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtNumberOfEntriesRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtNumberOfEntriesRowChangeEvent(DataSetReportSubstation.dtNumberOfEntriesRow dtNumberOfEntriesRow_1, DataRowAction action)
			{
				this.dtNumberOfEntriesRow_0 = dtNumberOfEntriesRow_1;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportSubstation.dtNumberOfEntriesRow Row
			{
				get
				{
					return this.dtNumberOfEntriesRow_0;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.dataRowAction_0;
				}
			}

			private DataSetReportSubstation.dtNumberOfEntriesRow dtNumberOfEntriesRow_0;

			private DataRowAction dataRowAction_0;
		}
	}
}
