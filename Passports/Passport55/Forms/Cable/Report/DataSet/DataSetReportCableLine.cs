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

namespace Passport.Forms.Cable.Report.DataSet
{
	[XmlRoot("DataSetReportCableLine")]
	[HelpKeyword("vs.data.DataSet")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[Serializable]
	public class DataSetReportCableLine : DataSet
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSetReportCableLine()
		{
			base.BeginInit();
			this.method_2();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_4);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected DataSetReportCableLine(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			if (base.IsBinarySerialized(info, context))
			{
				this.method_1(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_4);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
				return;
			}
			string s = (string)info.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["tCableLinePassport"] != null)
				{
					base.Tables.Add(new DataSetReportCableLine.tCableLinePassportDataTable(dataSet.Tables["tCableLinePassport"]));
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
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.method_4);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetReportCableLine.tCableLinePassportDataTable tCableLinePassport
		{
			get
			{
				return this.tabletCableLinePassport;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Browsable(true)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DebuggerNonUserCode]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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
			DataSetReportCableLine dataSetReportCableLine = (DataSetReportCableLine)base.Clone();
			dataSetReportCableLine.method_0();
			dataSetReportCableLine.SchemaSerializationMode = this.SchemaSerializationMode;
			return dataSetReportCableLine;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["tCableLinePassport"] != null)
				{
					base.Tables.Add(new DataSetReportCableLine.tCableLinePassportDataTable(dataSet.Tables["tCableLinePassport"]));
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_0()
		{
			this.method_1(true);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_1(bool bool_0)
		{
			this.tabletCableLinePassport = (DataSetReportCableLine.tCableLinePassportDataTable)base.Tables["tCableLinePassport"];
			if (bool_0 && this.tabletCableLinePassport != null)
			{
				this.tabletCableLinePassport.method_0();
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_2()
		{
			base.DataSetName = "DataSetReportCableLine";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/DataSetReportCableLine.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tabletCableLinePassport = new DataSetReportCableLine.tCableLinePassportDataTable();
			base.Tables.Add(this.tabletCableLinePassport);
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
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xmlSchemaSet_0)
		{
			DataSetReportCableLine dataSetReportCableLine = new DataSetReportCableLine();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dataSetReportCableLine.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSetReportCableLine.GetSchemaSerializable();
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

		private DataSetReportCableLine.tCableLinePassportDataTable tabletCableLinePassport;

		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void tCableLinePassportRowChangeEventHandler(object sender, DataSetReportCableLine.tCableLinePassportRowChangeEvent tCableLinePassportRowChangeEvent_0);

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tCableLinePassportDataTable : TypedTableBase<DataSetReportCableLine.tCableLinePassportRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tCableLinePassportDataTable()
			{
				base.TableName = "tCableLinePassport";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tCableLinePassportDataTable(DataTable dataTable_0)
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
			protected tCableLinePassportDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_13
			{
				get
				{
					return this.dataColumn_13;
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
			public DataSetReportCableLine.tCableLinePassportRow this[int index]
			{
				get
				{
					return (DataSetReportCableLine.tCableLinePassportRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportCableLine.tCableLinePassportRowChangeEventHandler tCableLinePassportRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportCableLine.tCableLinePassportRowChangeEventHandler tCableLinePassportRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportCableLine.tCableLinePassportRowChangeEventHandler tCableLinePassportRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportCableLine.tCableLinePassportRowChangeEventHandler tCableLinePassportRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddtCableLinePassportRow(DataSetReportCableLine.tCableLinePassportRow tCableLinePassportRow_0)
			{
				base.Rows.Add(tCableLinePassportRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportCableLine.tCableLinePassportRow AddtCableLinePassportRow(int int_0, int idObjList, int idEquipment, string Name, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, string string_12, string string_13)
			{
				DataSetReportCableLine.tCableLinePassportRow tCableLinePassportRow = (DataSetReportCableLine.tCableLinePassportRow)base.NewRow();
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
					string_13
				};
				tCableLinePassportRow.ItemArray = itemArray;
				base.Rows.Add(tCableLinePassportRow);
				return tCableLinePassportRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportCableLine.tCableLinePassportDataTable tCableLinePassportDataTable = (DataSetReportCableLine.tCableLinePassportDataTable)base.Clone();
				tCableLinePassportDataTable.method_0();
				return tCableLinePassportDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportCableLine.tCableLinePassportDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.columnid = base.Columns["id"];
				this.columnidObjList = base.Columns["idObjList"];
				this.columnidEquipment = base.Columns["idEquipment"];
				this.columnName = base.Columns["Name"];
				this.dataColumn_0 = base.Columns["Участок"];
				this.dataColumn_1 = base.Columns["Состояние_линии"];
				this.dataColumn_2 = base.Columns["Принадлежность"];
				this.dataColumn_3 = base.Columns["Год_прокладки"];
				this.dataColumn_4 = base.Columns["Год_ввода_в_эксплуатацию"];
				this.dataColumn_5 = base.Columns["Год_реконструкции"];
				this.dataColumn_6 = base.Columns["Допустимый_ток_летом"];
				this.dataColumn_7 = base.Columns["Допустимый_ток_зимой"];
				this.dataColumn_8 = base.Columns["Длина_трассы"];
				this.dataColumn_9 = base.Columns["Сечение"];
				this.dataColumn_10 = base.Columns["Марка_кабеля"];
				this.dataColumn_11 = base.Columns["Инвентарный_номер"];
				this.dataColumn_12 = base.Columns["Рабочее_напряжение"];
				this.dataColumn_13 = base.Columns["Балансовая_стоимость"];
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
				this.dataColumn_0 = new DataColumn("Участок", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Состояние_линии", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("Принадлежность", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("Год_прокладки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("Год_ввода_в_эксплуатацию", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Год_реконструкции", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("Допустимый_ток_летом", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("Допустимый_ток_зимой", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("Длина_трассы", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("Сечение", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("Марка_кабеля", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("Инвентарный_номер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("Рабочее_напряжение", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
				this.dataColumn_13 = new DataColumn("Балансовая_стоимость", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_13);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportCableLine.tCableLinePassportRow NewtCableLinePassportRow()
			{
				return (DataSetReportCableLine.tCableLinePassportRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportCableLine.tCableLinePassportRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportCableLine.tCableLinePassportRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tCableLinePassportRowChanged != null)
				{
					this.tCableLinePassportRowChanged(this, new DataSetReportCableLine.tCableLinePassportRowChangeEvent((DataSetReportCableLine.tCableLinePassportRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tCableLinePassportRowChanging != null)
				{
					this.tCableLinePassportRowChanging(this, new DataSetReportCableLine.tCableLinePassportRowChangeEvent((DataSetReportCableLine.tCableLinePassportRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tCableLinePassportRowDeleted != null)
				{
					this.tCableLinePassportRowDeleted(this, new DataSetReportCableLine.tCableLinePassportRowChangeEvent((DataSetReportCableLine.tCableLinePassportRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tCableLinePassportRowDeleting != null)
				{
					this.tCableLinePassportRowDeleting(this, new DataSetReportCableLine.tCableLinePassportRowChangeEvent((DataSetReportCableLine.tCableLinePassportRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovetCableLinePassportRow(DataSetReportCableLine.tCableLinePassportRow tCableLinePassportRow_0)
			{
				base.Rows.Remove(tCableLinePassportRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportCableLine dataSetReportCableLine = new DataSetReportCableLine();
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
				xmlSchemaAttribute.FixedValue = dataSetReportCableLine.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tCableLinePassportDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportCableLine.GetSchemaSerializable();
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
		}

		public class tCableLinePassportRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tCableLinePassportRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tCableLinePassportDataTable_0 = (DataSetReportCableLine.tCableLinePassportDataTable)base.Table;
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
						result = (int)base[this.tCableLinePassportDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.idColumn] = value;
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
						result = (int)base[this.tCableLinePassportDataTable_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.idObjListColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idEquipment
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tCableLinePassportDataTable_0.idEquipmentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idEquipment' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.idEquipmentColumn] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.NameColumn] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_0];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Участок' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_0] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_1];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Состояние_линии' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_1] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_2];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Принадлежность' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_2] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_3];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_прокладки' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_3] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_4];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_ввода_в_эксплуатацию' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_4] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_5
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_5];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_реконструкции' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_5] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_6];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Допустимый_ток_летом' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_6] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_7];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Допустимый_ток_зимой' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_7] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_8];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Длина_трассы' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_8] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_9];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Сечение' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_9] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_10];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Марка_кабеля' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_10] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_11];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Инвентарный_номер' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_11] = value;
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
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_12];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Рабочее_напряжение' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_12] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_13
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tCableLinePassportDataTable_0.DataColumn_13];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Балансовая_стоимость' in table 'tCableLinePassport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tCableLinePassportDataTable_0.DataColumn_13] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidNull()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.tCableLinePassportDataTable_0.idColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.idObjListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidObjListNull()
			{
				base[this.tCableLinePassportDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidEquipmentNull()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.idEquipmentColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidEquipmentNull()
			{
				base[this.tCableLinePassportDataTable_0.idEquipmentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.NameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameNull()
			{
				base[this.tCableLinePassportDataTable_0.NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_0()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_1()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_0] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_2()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_1);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_3()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_4()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_2);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_2] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_6()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_3);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_7()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_3] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_8()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_4);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_9()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_4] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_10()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_5);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_11()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_5] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_12()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_6);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_13()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_6] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_14()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_7);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_15()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_7] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_16()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_8);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_17()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_8] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_18()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_9);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_19()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_9] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_20()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_10);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_21()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_10] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_22()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_11);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_23()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_11] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_24()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_12);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_12] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_26()
			{
				return base.IsNull(this.tCableLinePassportDataTable_0.DataColumn_13);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_27()
			{
				base[this.tCableLinePassportDataTable_0.DataColumn_13] = Convert.DBNull;
			}

			private DataSetReportCableLine.tCableLinePassportDataTable tCableLinePassportDataTable_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class tCableLinePassportRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tCableLinePassportRowChangeEvent(DataSetReportCableLine.tCableLinePassportRow tCableLinePassportRow_1, DataRowAction action)
			{
				this.tCableLinePassportRow_0 = tCableLinePassportRow_1;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportCableLine.tCableLinePassportRow Row
			{
				get
				{
					return this.tCableLinePassportRow_0;
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

			private DataSetReportCableLine.tCableLinePassportRow tCableLinePassportRow_0;

			private DataRowAction dataRowAction_0;
		}
	}
}
