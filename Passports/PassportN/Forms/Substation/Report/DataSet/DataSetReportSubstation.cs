using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Passport.Forms.Substation.Report.DataSet
{
	[ToolboxItem(true)]
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.DataSet")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[XmlRoot("DataSetReportSubstation")]
	[Serializable]
	public class DataSetReportSubstation : DataSet
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSetReportSubstation()
		{
			Class330.Mus9JxKz1CNxy();
			this.schemaSerializationMode_0 = SchemaSerializationMode.IncludeSchema;
			base..ctor();
			base.BeginInit();
			this.method_2();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_8);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected DataSetReportSubstation(SerializationInfo info, StreamingContext context)
		{
			Class330.Mus9JxKz1CNxy();
			this.schemaSerializationMode_0 = SchemaSerializationMode.IncludeSchema;
			base..ctor(info, context, false);
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
					base.Tables.Add(new DataSetReportSubstation.GClass1(dataSet.Tables["dtKTPMain"]));
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
					base.Tables.Add(new DataSetReportSubstation.GClass2(dataSet.Tables["dtZTPMain"]));
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
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public DataSetReportSubstation.GClass1 GClass1_0
		{
			get
			{
				return this.gclass1_0;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public DataSetReportSubstation.dtEmptyDataTable dtEmpty
		{
			get
			{
				return this.dtEmptyDataTable_0;
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
				return this.dtEquipmentDataTable_0;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportSubstation.GClass2 GClass2_0
		{
			get
			{
				return this.gclass2_0;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSetReportSubstation.dtNumberOfEntriesDataTable dtNumberOfEntries
		{
			get
			{
				return this.dtNumberOfEntriesDataTable_0;
			}
		}

		[Browsable(true)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this.schemaSerializationMode_0;
			}
			set
			{
				this.schemaSerializationMode_0 = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataSet Clone()
		{
			DataSetReportSubstation dataSetReportSubstation = (DataSetReportSubstation)base.Clone();
			dataSetReportSubstation.method_0();
			dataSetReportSubstation.SchemaSerializationMode = this.SchemaSerializationMode;
			return dataSetReportSubstation;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
					base.Tables.Add(new DataSetReportSubstation.GClass1(dataSet.Tables["dtKTPMain"]));
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
					base.Tables.Add(new DataSetReportSubstation.GClass2(dataSet.Tables["dtZTPMain"]));
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_1(bool bool_0)
		{
			this.gclass1_0 = (DataSetReportSubstation.GClass1)base.Tables["dtKTPMain"];
			if (bool_0 && this.gclass1_0 != null)
			{
				this.gclass1_0.method_0();
			}
			this.dtEmptyDataTable_0 = (DataSetReportSubstation.dtEmptyDataTable)base.Tables["dtEmpty"];
			if (bool_0 && this.dtEmptyDataTable_0 != null)
			{
				this.dtEmptyDataTable_0.method_0();
			}
			this.dtEquipmentDataTable_0 = (DataSetReportSubstation.dtEquipmentDataTable)base.Tables["dtEquipment"];
			if (bool_0 && this.dtEquipmentDataTable_0 != null)
			{
				this.dtEquipmentDataTable_0.method_0();
			}
			this.gclass2_0 = (DataSetReportSubstation.GClass2)base.Tables["dtZTPMain"];
			if (bool_0 && this.gclass2_0 != null)
			{
				this.gclass2_0.method_0();
			}
			this.dtNumberOfEntriesDataTable_0 = (DataSetReportSubstation.dtNumberOfEntriesDataTable)base.Tables["dtNumberOfEntries"];
			if (bool_0 && this.dtNumberOfEntriesDataTable_0 != null)
			{
				this.dtNumberOfEntriesDataTable_0.method_0();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_2()
		{
			base.DataSetName = "DataSetReportSubstation";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/DataSetReportSubstation.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.gclass1_0 = new DataSetReportSubstation.GClass1();
			base.Tables.Add(this.gclass1_0);
			this.dtEmptyDataTable_0 = new DataSetReportSubstation.dtEmptyDataTable();
			base.Tables.Add(this.dtEmptyDataTable_0);
			this.dtEquipmentDataTable_0 = new DataSetReportSubstation.dtEquipmentDataTable();
			base.Tables.Add(this.dtEquipmentDataTable_0);
			this.gclass2_0 = new DataSetReportSubstation.GClass2();
			base.Tables.Add(this.gclass2_0);
			this.dtNumberOfEntriesDataTable_0 = new DataSetReportSubstation.dtNumberOfEntriesDataTable();
			base.Tables.Add(this.dtNumberOfEntriesDataTable_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool method_3()
		{
			return false;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			DataSetReportSubstation dataSetReportSubstation = new DataSetReportSubstation();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dataSetReportSubstation.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSetReportSubstation.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
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
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}

		private DataSetReportSubstation.GClass1 gclass1_0;

		private DataSetReportSubstation.dtEmptyDataTable dtEmptyDataTable_0;

		private DataSetReportSubstation.dtEquipmentDataTable dtEquipmentDataTable_0;

		private DataSetReportSubstation.GClass2 gclass2_0;

		private DataSetReportSubstation.dtNumberOfEntriesDataTable dtNumberOfEntriesDataTable_0;

		private SchemaSerializationMode schemaSerializationMode_0;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtKTPMainRowChangeEventHandler(object sender, DataSetReportSubstation.dtKTPMainRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtEmptyRowChangeEventHandler(object sender, DataSetReportSubstation.dtEmptyRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtEquipmentRowChangeEventHandler(object sender, DataSetReportSubstation.dtEquipmentRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtZTPMainRowChangeEventHandler(object sender, DataSetReportSubstation.dtZTPMainRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtNumberOfEntriesRowChangeEventHandler(object sender, DataSetReportSubstation.dtNumberOfEntriesRowChangeEvent e);

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GClass1 : TypedTableBase<DataSetReportSubstation.dtKTPMainRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public GClass1()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtKTPMain";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal GClass1(DataTable table)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected GClass1(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idObjListColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_0
			{
				get
				{
					return this.EeLatIrvdcm;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_1
			{
				get
				{
					return this.WiUatCxymNq;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_2
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_3
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_4
			{
				get
				{
					return this.dataColumn_5;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_5
			{
				get
				{
					return this.dataColumn_6;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_6
			{
				get
				{
					return this.dataColumn_7;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_7
			{
				get
				{
					return this.dataColumn_8;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_8
			{
				get
				{
					return this.OrKathvWdTP;
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
			public DataSetReportSubstation.dtKTPMainRow this[int index]
			{
				get
				{
					return (DataSetReportSubstation.dtKTPMainRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler = this.dtKTPMainRowChangeEventHandler_0;
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler2;
					do
					{
						dtKTPMainRowChangeEventHandler2 = dtKTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtKTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtKTPMainRowChangeEventHandler)Delegate.Combine(dtKTPMainRowChangeEventHandler2, value);
						dtKTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtKTPMainRowChangeEventHandler>(ref this.dtKTPMainRowChangeEventHandler_0, value2, dtKTPMainRowChangeEventHandler2);
					}
					while (dtKTPMainRowChangeEventHandler != dtKTPMainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler = this.dtKTPMainRowChangeEventHandler_0;
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler2;
					do
					{
						dtKTPMainRowChangeEventHandler2 = dtKTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtKTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtKTPMainRowChangeEventHandler)Delegate.Remove(dtKTPMainRowChangeEventHandler2, value);
						dtKTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtKTPMainRowChangeEventHandler>(ref this.dtKTPMainRowChangeEventHandler_0, value2, dtKTPMainRowChangeEventHandler2);
					}
					while (dtKTPMainRowChangeEventHandler != dtKTPMainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler = this.dtKTPMainRowChangeEventHandler_1;
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler2;
					do
					{
						dtKTPMainRowChangeEventHandler2 = dtKTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtKTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtKTPMainRowChangeEventHandler)Delegate.Combine(dtKTPMainRowChangeEventHandler2, value);
						dtKTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtKTPMainRowChangeEventHandler>(ref this.dtKTPMainRowChangeEventHandler_1, value2, dtKTPMainRowChangeEventHandler2);
					}
					while (dtKTPMainRowChangeEventHandler != dtKTPMainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler = this.dtKTPMainRowChangeEventHandler_1;
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler2;
					do
					{
						dtKTPMainRowChangeEventHandler2 = dtKTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtKTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtKTPMainRowChangeEventHandler)Delegate.Remove(dtKTPMainRowChangeEventHandler2, value);
						dtKTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtKTPMainRowChangeEventHandler>(ref this.dtKTPMainRowChangeEventHandler_1, value2, dtKTPMainRowChangeEventHandler2);
					}
					while (dtKTPMainRowChangeEventHandler != dtKTPMainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler = this.dtKTPMainRowChangeEventHandler_2;
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler2;
					do
					{
						dtKTPMainRowChangeEventHandler2 = dtKTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtKTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtKTPMainRowChangeEventHandler)Delegate.Combine(dtKTPMainRowChangeEventHandler2, value);
						dtKTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtKTPMainRowChangeEventHandler>(ref this.dtKTPMainRowChangeEventHandler_2, value2, dtKTPMainRowChangeEventHandler2);
					}
					while (dtKTPMainRowChangeEventHandler != dtKTPMainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler = this.dtKTPMainRowChangeEventHandler_2;
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler2;
					do
					{
						dtKTPMainRowChangeEventHandler2 = dtKTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtKTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtKTPMainRowChangeEventHandler)Delegate.Remove(dtKTPMainRowChangeEventHandler2, value);
						dtKTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtKTPMainRowChangeEventHandler>(ref this.dtKTPMainRowChangeEventHandler_2, value2, dtKTPMainRowChangeEventHandler2);
					}
					while (dtKTPMainRowChangeEventHandler != dtKTPMainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler = this.dtKTPMainRowChangeEventHandler_3;
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler2;
					do
					{
						dtKTPMainRowChangeEventHandler2 = dtKTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtKTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtKTPMainRowChangeEventHandler)Delegate.Combine(dtKTPMainRowChangeEventHandler2, value);
						dtKTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtKTPMainRowChangeEventHandler>(ref this.dtKTPMainRowChangeEventHandler_3, value2, dtKTPMainRowChangeEventHandler2);
					}
					while (dtKTPMainRowChangeEventHandler != dtKTPMainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler = this.dtKTPMainRowChangeEventHandler_3;
					DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler2;
					do
					{
						dtKTPMainRowChangeEventHandler2 = dtKTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtKTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtKTPMainRowChangeEventHandler)Delegate.Remove(dtKTPMainRowChangeEventHandler2, value);
						dtKTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtKTPMainRowChangeEventHandler>(ref this.dtKTPMainRowChangeEventHandler_3, value2, dtKTPMainRowChangeEventHandler2);
					}
					while (dtKTPMainRowChangeEventHandler != dtKTPMainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtKTPMainRow(DataSetReportSubstation.dtKTPMainRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
				DataSetReportSubstation.GClass1 gclass = (DataSetReportSubstation.GClass1)base.Clone();
				gclass.method_0();
				return gclass;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportSubstation.GClass1();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["idObjList"];
				this.dataColumn_2 = base.Columns["Name"];
				this.EeLatIrvdcm = base.Columns["Тип"];
				this.WiUatCxymNq = base.Columns["Инвентарный_номер"];
				this.dataColumn_3 = base.Columns["Регион"];
				this.dataColumn_4 = base.Columns["Улица"];
				this.dataColumn_5 = base.Columns["Дом"];
				this.dataColumn_6 = base.Columns["Дополнительно"];
				this.dataColumn_7 = base.Columns["Тип_ТП"];
				this.dataColumn_8 = base.Columns["Год_постройки"];
				this.OrKathvWdTP = base.Columns["Год_ввода_в_эксплуатацию"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.EeLatIrvdcm = new DataColumn("Тип", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.EeLatIrvdcm);
				this.WiUatCxymNq = new DataColumn("Инвентарный_номер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.WiUatCxymNq);
				this.dataColumn_3 = new DataColumn("Регион", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("Улица", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Дом", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("Дополнительно", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("Тип_ТП", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("Год_постройки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.OrKathvWdTP = new DataColumn("Год_ввода_в_эксплуатацию", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.OrKathvWdTP);
				this.dataColumn_0.AutoIncrement = true;
				this.dataColumn_0.AutoIncrementSeed = -1L;
				this.dataColumn_0.AutoIncrementStep = -1L;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtKTPMainRow NewdtKTPMainRow()
			{
				return (DataSetReportSubstation.dtKTPMainRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtKTPMainRowChangeEventHandler_1 != null)
				{
					this.dtKTPMainRowChangeEventHandler_1(this, new DataSetReportSubstation.dtKTPMainRowChangeEvent((DataSetReportSubstation.dtKTPMainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtKTPMainRowChangeEventHandler_0 != null)
				{
					this.dtKTPMainRowChangeEventHandler_0(this, new DataSetReportSubstation.dtKTPMainRowChangeEvent((DataSetReportSubstation.dtKTPMainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtKTPMainRowChangeEventHandler_3 != null)
				{
					this.dtKTPMainRowChangeEventHandler_3(this, new DataSetReportSubstation.dtKTPMainRowChangeEvent((DataSetReportSubstation.dtKTPMainRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtKTPMainRowChangeEventHandler_2 != null)
				{
					this.dtKTPMainRowChangeEventHandler_2(this, new DataSetReportSubstation.dtKTPMainRowChangeEvent((DataSetReportSubstation.dtKTPMainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtKTPMainRow(DataSetReportSubstation.dtKTPMainRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
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
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
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
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			private DataColumn dataColumn_0;

			private DataColumn dataColumn_1;

			private DataColumn dataColumn_2;

			private DataColumn EeLatIrvdcm;

			private DataColumn WiUatCxymNq;

			private DataColumn dataColumn_3;

			private DataColumn dataColumn_4;

			private DataColumn dataColumn_5;

			private DataColumn dataColumn_6;

			private DataColumn dataColumn_7;

			private DataColumn dataColumn_8;

			private DataColumn OrKathvWdTP;

			[CompilerGenerated]
			private DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportSubstation.dtKTPMainRowChangeEventHandler dtKTPMainRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtEmptyDataTable : TypedTableBase<DataSetReportSubstation.dtEmptyRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtEmptyDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtEmpty";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtEmptyDataTable(DataTable table)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected dtEmptyDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			public DataSetReportSubstation.dtEmptyRow this[int index]
			{
				get
				{
					return (DataSetReportSubstation.dtEmptyRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler = this.FhtatlEckGT;
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler2;
					do
					{
						dtEmptyRowChangeEventHandler2 = dtEmptyRowChangeEventHandler;
						DataSetReportSubstation.dtEmptyRowChangeEventHandler value2 = (DataSetReportSubstation.dtEmptyRowChangeEventHandler)Delegate.Combine(dtEmptyRowChangeEventHandler2, value);
						dtEmptyRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEmptyRowChangeEventHandler>(ref this.FhtatlEckGT, value2, dtEmptyRowChangeEventHandler2);
					}
					while (dtEmptyRowChangeEventHandler != dtEmptyRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler = this.FhtatlEckGT;
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler2;
					do
					{
						dtEmptyRowChangeEventHandler2 = dtEmptyRowChangeEventHandler;
						DataSetReportSubstation.dtEmptyRowChangeEventHandler value2 = (DataSetReportSubstation.dtEmptyRowChangeEventHandler)Delegate.Remove(dtEmptyRowChangeEventHandler2, value);
						dtEmptyRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEmptyRowChangeEventHandler>(ref this.FhtatlEckGT, value2, dtEmptyRowChangeEventHandler2);
					}
					while (dtEmptyRowChangeEventHandler != dtEmptyRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler = this.dtEmptyRowChangeEventHandler_0;
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler2;
					do
					{
						dtEmptyRowChangeEventHandler2 = dtEmptyRowChangeEventHandler;
						DataSetReportSubstation.dtEmptyRowChangeEventHandler value2 = (DataSetReportSubstation.dtEmptyRowChangeEventHandler)Delegate.Combine(dtEmptyRowChangeEventHandler2, value);
						dtEmptyRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEmptyRowChangeEventHandler>(ref this.dtEmptyRowChangeEventHandler_0, value2, dtEmptyRowChangeEventHandler2);
					}
					while (dtEmptyRowChangeEventHandler != dtEmptyRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler = this.dtEmptyRowChangeEventHandler_0;
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler2;
					do
					{
						dtEmptyRowChangeEventHandler2 = dtEmptyRowChangeEventHandler;
						DataSetReportSubstation.dtEmptyRowChangeEventHandler value2 = (DataSetReportSubstation.dtEmptyRowChangeEventHandler)Delegate.Remove(dtEmptyRowChangeEventHandler2, value);
						dtEmptyRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEmptyRowChangeEventHandler>(ref this.dtEmptyRowChangeEventHandler_0, value2, dtEmptyRowChangeEventHandler2);
					}
					while (dtEmptyRowChangeEventHandler != dtEmptyRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler = this.dtEmptyRowChangeEventHandler_1;
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler2;
					do
					{
						dtEmptyRowChangeEventHandler2 = dtEmptyRowChangeEventHandler;
						DataSetReportSubstation.dtEmptyRowChangeEventHandler value2 = (DataSetReportSubstation.dtEmptyRowChangeEventHandler)Delegate.Combine(dtEmptyRowChangeEventHandler2, value);
						dtEmptyRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEmptyRowChangeEventHandler>(ref this.dtEmptyRowChangeEventHandler_1, value2, dtEmptyRowChangeEventHandler2);
					}
					while (dtEmptyRowChangeEventHandler != dtEmptyRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler = this.dtEmptyRowChangeEventHandler_1;
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler2;
					do
					{
						dtEmptyRowChangeEventHandler2 = dtEmptyRowChangeEventHandler;
						DataSetReportSubstation.dtEmptyRowChangeEventHandler value2 = (DataSetReportSubstation.dtEmptyRowChangeEventHandler)Delegate.Remove(dtEmptyRowChangeEventHandler2, value);
						dtEmptyRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEmptyRowChangeEventHandler>(ref this.dtEmptyRowChangeEventHandler_1, value2, dtEmptyRowChangeEventHandler2);
					}
					while (dtEmptyRowChangeEventHandler != dtEmptyRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler = this.dtEmptyRowChangeEventHandler_2;
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler2;
					do
					{
						dtEmptyRowChangeEventHandler2 = dtEmptyRowChangeEventHandler;
						DataSetReportSubstation.dtEmptyRowChangeEventHandler value2 = (DataSetReportSubstation.dtEmptyRowChangeEventHandler)Delegate.Combine(dtEmptyRowChangeEventHandler2, value);
						dtEmptyRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEmptyRowChangeEventHandler>(ref this.dtEmptyRowChangeEventHandler_2, value2, dtEmptyRowChangeEventHandler2);
					}
					while (dtEmptyRowChangeEventHandler != dtEmptyRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler = this.dtEmptyRowChangeEventHandler_2;
					DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler2;
					do
					{
						dtEmptyRowChangeEventHandler2 = dtEmptyRowChangeEventHandler;
						DataSetReportSubstation.dtEmptyRowChangeEventHandler value2 = (DataSetReportSubstation.dtEmptyRowChangeEventHandler)Delegate.Remove(dtEmptyRowChangeEventHandler2, value);
						dtEmptyRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEmptyRowChangeEventHandler>(ref this.dtEmptyRowChangeEventHandler_2, value2, dtEmptyRowChangeEventHandler2);
					}
					while (dtEmptyRowChangeEventHandler != dtEmptyRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtEmptyRow(DataSetReportSubstation.dtEmptyRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["Name"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_0.AutoIncrement = true;
				this.dataColumn_0.AutoIncrementSeed = -1L;
				this.dataColumn_0.AutoIncrementStep = -1L;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportSubstation.dtEmptyRow NewdtEmptyRow()
			{
				return (DataSetReportSubstation.dtEmptyRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportSubstation.dtEmptyRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportSubstation.dtEmptyRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtEmptyRowChangeEventHandler_0 != null)
				{
					this.dtEmptyRowChangeEventHandler_0(this, new DataSetReportSubstation.dtEmptyRowChangeEvent((DataSetReportSubstation.dtEmptyRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.FhtatlEckGT != null)
				{
					this.FhtatlEckGT(this, new DataSetReportSubstation.dtEmptyRowChangeEvent((DataSetReportSubstation.dtEmptyRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtEmptyRowChangeEventHandler_2 != null)
				{
					this.dtEmptyRowChangeEventHandler_2(this, new DataSetReportSubstation.dtEmptyRowChangeEvent((DataSetReportSubstation.dtEmptyRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtEmptyRowChangeEventHandler_1 != null)
				{
					this.dtEmptyRowChangeEventHandler_1(this, new DataSetReportSubstation.dtEmptyRowChangeEvent((DataSetReportSubstation.dtEmptyRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtEmptyRow(DataSetReportSubstation.dtEmptyRow row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
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
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
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
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			private DataColumn dataColumn_0;

			private DataColumn dataColumn_1;

			[CompilerGenerated]
			private DataSetReportSubstation.dtEmptyRowChangeEventHandler FhtatlEckGT;

			[CompilerGenerated]
			private DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportSubstation.dtEmptyRowChangeEventHandler dtEmptyRowChangeEventHandler_2;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtEquipmentDataTable : TypedTableBase<DataSetReportSubstation.dtEquipmentRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtEquipmentDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtEquipment";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtEquipmentDataTable(DataTable table)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected dtEquipmentDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idObjListColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn GroupNameColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn typeCodeIdColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn typeNameColumn
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.dataColumn_5;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_0
			{
				get
				{
					return this.dataColumn_6;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_1
			{
				get
				{
					return this.dataColumn_7;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_2
			{
				get
				{
					return this.dataColumn_8;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_3
			{
				get
				{
					return this.dataColumn_9;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_4
			{
				get
				{
					return this.dataColumn_10;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_5
			{
				get
				{
					return this.dataColumn_11;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_6
			{
				get
				{
					return this.dataColumn_12;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_7
			{
				get
				{
					return this.dataColumn_13;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_8
			{
				get
				{
					return this.dataColumn_14;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_9
			{
				get
				{
					return this.dataColumn_15;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_10
			{
				get
				{
					return this.dataColumn_16;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_11
			{
				get
				{
					return this.dataColumn_17;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_12
			{
				get
				{
					return this.dataColumn_18;
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
			public DataSetReportSubstation.dtEquipmentRow this[int index]
			{
				get
				{
					return (DataSetReportSubstation.dtEquipmentRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler = this.dtEquipmentRowChangeEventHandler_0;
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler2;
					do
					{
						dtEquipmentRowChangeEventHandler2 = dtEquipmentRowChangeEventHandler;
						DataSetReportSubstation.dtEquipmentRowChangeEventHandler value2 = (DataSetReportSubstation.dtEquipmentRowChangeEventHandler)Delegate.Combine(dtEquipmentRowChangeEventHandler2, value);
						dtEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEquipmentRowChangeEventHandler>(ref this.dtEquipmentRowChangeEventHandler_0, value2, dtEquipmentRowChangeEventHandler2);
					}
					while (dtEquipmentRowChangeEventHandler != dtEquipmentRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler = this.dtEquipmentRowChangeEventHandler_0;
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler2;
					do
					{
						dtEquipmentRowChangeEventHandler2 = dtEquipmentRowChangeEventHandler;
						DataSetReportSubstation.dtEquipmentRowChangeEventHandler value2 = (DataSetReportSubstation.dtEquipmentRowChangeEventHandler)Delegate.Remove(dtEquipmentRowChangeEventHandler2, value);
						dtEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEquipmentRowChangeEventHandler>(ref this.dtEquipmentRowChangeEventHandler_0, value2, dtEquipmentRowChangeEventHandler2);
					}
					while (dtEquipmentRowChangeEventHandler != dtEquipmentRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler = this.dtEquipmentRowChangeEventHandler_1;
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler2;
					do
					{
						dtEquipmentRowChangeEventHandler2 = dtEquipmentRowChangeEventHandler;
						DataSetReportSubstation.dtEquipmentRowChangeEventHandler value2 = (DataSetReportSubstation.dtEquipmentRowChangeEventHandler)Delegate.Combine(dtEquipmentRowChangeEventHandler2, value);
						dtEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEquipmentRowChangeEventHandler>(ref this.dtEquipmentRowChangeEventHandler_1, value2, dtEquipmentRowChangeEventHandler2);
					}
					while (dtEquipmentRowChangeEventHandler != dtEquipmentRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler = this.dtEquipmentRowChangeEventHandler_1;
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler2;
					do
					{
						dtEquipmentRowChangeEventHandler2 = dtEquipmentRowChangeEventHandler;
						DataSetReportSubstation.dtEquipmentRowChangeEventHandler value2 = (DataSetReportSubstation.dtEquipmentRowChangeEventHandler)Delegate.Remove(dtEquipmentRowChangeEventHandler2, value);
						dtEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEquipmentRowChangeEventHandler>(ref this.dtEquipmentRowChangeEventHandler_1, value2, dtEquipmentRowChangeEventHandler2);
					}
					while (dtEquipmentRowChangeEventHandler != dtEquipmentRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler = this.dtEquipmentRowChangeEventHandler_2;
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler2;
					do
					{
						dtEquipmentRowChangeEventHandler2 = dtEquipmentRowChangeEventHandler;
						DataSetReportSubstation.dtEquipmentRowChangeEventHandler value2 = (DataSetReportSubstation.dtEquipmentRowChangeEventHandler)Delegate.Combine(dtEquipmentRowChangeEventHandler2, value);
						dtEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEquipmentRowChangeEventHandler>(ref this.dtEquipmentRowChangeEventHandler_2, value2, dtEquipmentRowChangeEventHandler2);
					}
					while (dtEquipmentRowChangeEventHandler != dtEquipmentRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler = this.dtEquipmentRowChangeEventHandler_2;
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler2;
					do
					{
						dtEquipmentRowChangeEventHandler2 = dtEquipmentRowChangeEventHandler;
						DataSetReportSubstation.dtEquipmentRowChangeEventHandler value2 = (DataSetReportSubstation.dtEquipmentRowChangeEventHandler)Delegate.Remove(dtEquipmentRowChangeEventHandler2, value);
						dtEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEquipmentRowChangeEventHandler>(ref this.dtEquipmentRowChangeEventHandler_2, value2, dtEquipmentRowChangeEventHandler2);
					}
					while (dtEquipmentRowChangeEventHandler != dtEquipmentRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler = this.dtEquipmentRowChangeEventHandler_3;
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler2;
					do
					{
						dtEquipmentRowChangeEventHandler2 = dtEquipmentRowChangeEventHandler;
						DataSetReportSubstation.dtEquipmentRowChangeEventHandler value2 = (DataSetReportSubstation.dtEquipmentRowChangeEventHandler)Delegate.Combine(dtEquipmentRowChangeEventHandler2, value);
						dtEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEquipmentRowChangeEventHandler>(ref this.dtEquipmentRowChangeEventHandler_3, value2, dtEquipmentRowChangeEventHandler2);
					}
					while (dtEquipmentRowChangeEventHandler != dtEquipmentRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler = this.dtEquipmentRowChangeEventHandler_3;
					DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler2;
					do
					{
						dtEquipmentRowChangeEventHandler2 = dtEquipmentRowChangeEventHandler;
						DataSetReportSubstation.dtEquipmentRowChangeEventHandler value2 = (DataSetReportSubstation.dtEquipmentRowChangeEventHandler)Delegate.Remove(dtEquipmentRowChangeEventHandler2, value);
						dtEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtEquipmentRowChangeEventHandler>(ref this.dtEquipmentRowChangeEventHandler_3, value2, dtEquipmentRowChangeEventHandler2);
					}
					while (dtEquipmentRowChangeEventHandler != dtEquipmentRowChangeEventHandler2);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtEquipmentRow(DataSetReportSubstation.dtEquipmentRow row)
			{
				base.Rows.Add(row);
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["idObjList"];
				this.dataColumn_2 = base.Columns["GroupName"];
				this.dataColumn_3 = base.Columns["typeCodeId"];
				this.dataColumn_4 = base.Columns["typeName"];
				this.dataColumn_5 = base.Columns["Name"];
				this.dataColumn_6 = base.Columns["Тип"];
				this.dataColumn_7 = base.Columns["Мощность"];
				this.dataColumn_8 = base.Columns["Номинальный_ток"];
				this.dataColumn_9 = base.Columns["Номинальное_напряжение"];
				this.dataColumn_10 = base.Columns["Заводской_номер"];
				this.dataColumn_11 = base.Columns["Год_установки"];
				this.dataColumn_12 = base.Columns["Инвентарный_номер"];
				this.dataColumn_13 = base.Columns["Артикул"];
				this.dataColumn_14 = base.Columns["Завод_изготовитель"];
				this.dataColumn_15 = base.Columns["Год_изготовления"];
				this.dataColumn_16 = base.Columns["Завод__изготовитель"];
				this.dataColumn_17 = base.Columns["Группа_соединений_обмоток"];
				this.dataColumn_18 = base.Columns["Описание"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("GroupName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("typeCodeId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("typeName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("Тип", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("Мощность", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("Номинальный_ток", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("Номинальное_напряжение", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("Заводской_номер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("Год_установки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("Инвентарный_номер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
				this.dataColumn_13 = new DataColumn("Артикул", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_13);
				this.dataColumn_14 = new DataColumn("Завод_изготовитель", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_14);
				this.dataColumn_15 = new DataColumn("Год_изготовления", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_15);
				this.dataColumn_16 = new DataColumn("Завод__изготовитель", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_16);
				this.dataColumn_17 = new DataColumn("Группа_соединений_обмоток", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_17);
				this.dataColumn_18 = new DataColumn("Описание", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_18);
				this.dataColumn_0.AutoIncrement = true;
				this.dataColumn_0.AutoIncrementSeed = -1L;
				this.dataColumn_0.AutoIncrementStep = -1L;
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
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtEquipmentRowChangeEventHandler_1 != null)
				{
					this.dtEquipmentRowChangeEventHandler_1(this, new DataSetReportSubstation.dtEquipmentRowChangeEvent((DataSetReportSubstation.dtEquipmentRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtEquipmentRowChangeEventHandler_0 != null)
				{
					this.dtEquipmentRowChangeEventHandler_0(this, new DataSetReportSubstation.dtEquipmentRowChangeEvent((DataSetReportSubstation.dtEquipmentRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtEquipmentRowChangeEventHandler_3 != null)
				{
					this.dtEquipmentRowChangeEventHandler_3(this, new DataSetReportSubstation.dtEquipmentRowChangeEvent((DataSetReportSubstation.dtEquipmentRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtEquipmentRowChangeEventHandler_2 != null)
				{
					this.dtEquipmentRowChangeEventHandler_2(this, new DataSetReportSubstation.dtEquipmentRowChangeEvent((DataSetReportSubstation.dtEquipmentRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtEquipmentRow(DataSetReportSubstation.dtEquipmentRow row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
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
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
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
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

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

			private DataColumn dataColumn_17;

			private DataColumn dataColumn_18;

			[CompilerGenerated]
			private DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportSubstation.dtEquipmentRowChangeEventHandler dtEquipmentRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class GClass2 : TypedTableBase<DataSetReportSubstation.dtZTPMainRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public GClass2()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtZTPMain";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal GClass2(DataTable table)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected GClass2(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idObjListColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idEquipmentColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_0
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_1
			{
				get
				{
					return this.dataColumn_5;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_2
			{
				get
				{
					return this.dataColumn_6;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_3
			{
				get
				{
					return this.dataColumn_7;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_4
			{
				get
				{
					return this.dataColumn_8;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_5
			{
				get
				{
					return this.dataColumn_9;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_6
			{
				get
				{
					return this.dataColumn_10;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_7
			{
				get
				{
					return this.dataColumn_11;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_8
			{
				get
				{
					return this.dataColumn_12;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_9
			{
				get
				{
					return this.dataColumn_13;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_10
			{
				get
				{
					return this.dataColumn_14;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_11
			{
				get
				{
					return this.dataColumn_15;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_12
			{
				get
				{
					return this.dataColumn_16;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_13
			{
				get
				{
					return this.dataColumn_17;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_14
			{
				get
				{
					return this.dataColumn_18;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_15
			{
				get
				{
					return this.dataColumn_19;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_16
			{
				get
				{
					return this.dataColumn_20;
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
			public DataSetReportSubstation.dtZTPMainRow this[int index]
			{
				get
				{
					return (DataSetReportSubstation.dtZTPMainRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler = this.dtZTPMainRowChangeEventHandler_0;
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler2;
					do
					{
						dtZTPMainRowChangeEventHandler2 = dtZTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtZTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtZTPMainRowChangeEventHandler)Delegate.Combine(dtZTPMainRowChangeEventHandler2, value);
						dtZTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtZTPMainRowChangeEventHandler>(ref this.dtZTPMainRowChangeEventHandler_0, value2, dtZTPMainRowChangeEventHandler2);
					}
					while (dtZTPMainRowChangeEventHandler != dtZTPMainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler = this.dtZTPMainRowChangeEventHandler_0;
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler2;
					do
					{
						dtZTPMainRowChangeEventHandler2 = dtZTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtZTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtZTPMainRowChangeEventHandler)Delegate.Remove(dtZTPMainRowChangeEventHandler2, value);
						dtZTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtZTPMainRowChangeEventHandler>(ref this.dtZTPMainRowChangeEventHandler_0, value2, dtZTPMainRowChangeEventHandler2);
					}
					while (dtZTPMainRowChangeEventHandler != dtZTPMainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler = this.dtZTPMainRowChangeEventHandler_1;
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler2;
					do
					{
						dtZTPMainRowChangeEventHandler2 = dtZTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtZTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtZTPMainRowChangeEventHandler)Delegate.Combine(dtZTPMainRowChangeEventHandler2, value);
						dtZTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtZTPMainRowChangeEventHandler>(ref this.dtZTPMainRowChangeEventHandler_1, value2, dtZTPMainRowChangeEventHandler2);
					}
					while (dtZTPMainRowChangeEventHandler != dtZTPMainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler = this.dtZTPMainRowChangeEventHandler_1;
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler2;
					do
					{
						dtZTPMainRowChangeEventHandler2 = dtZTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtZTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtZTPMainRowChangeEventHandler)Delegate.Remove(dtZTPMainRowChangeEventHandler2, value);
						dtZTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtZTPMainRowChangeEventHandler>(ref this.dtZTPMainRowChangeEventHandler_1, value2, dtZTPMainRowChangeEventHandler2);
					}
					while (dtZTPMainRowChangeEventHandler != dtZTPMainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler = this.dtZTPMainRowChangeEventHandler_2;
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler2;
					do
					{
						dtZTPMainRowChangeEventHandler2 = dtZTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtZTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtZTPMainRowChangeEventHandler)Delegate.Combine(dtZTPMainRowChangeEventHandler2, value);
						dtZTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtZTPMainRowChangeEventHandler>(ref this.dtZTPMainRowChangeEventHandler_2, value2, dtZTPMainRowChangeEventHandler2);
					}
					while (dtZTPMainRowChangeEventHandler != dtZTPMainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler = this.dtZTPMainRowChangeEventHandler_2;
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler2;
					do
					{
						dtZTPMainRowChangeEventHandler2 = dtZTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtZTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtZTPMainRowChangeEventHandler)Delegate.Remove(dtZTPMainRowChangeEventHandler2, value);
						dtZTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtZTPMainRowChangeEventHandler>(ref this.dtZTPMainRowChangeEventHandler_2, value2, dtZTPMainRowChangeEventHandler2);
					}
					while (dtZTPMainRowChangeEventHandler != dtZTPMainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler = this.dtZTPMainRowChangeEventHandler_3;
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler2;
					do
					{
						dtZTPMainRowChangeEventHandler2 = dtZTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtZTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtZTPMainRowChangeEventHandler)Delegate.Combine(dtZTPMainRowChangeEventHandler2, value);
						dtZTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtZTPMainRowChangeEventHandler>(ref this.dtZTPMainRowChangeEventHandler_3, value2, dtZTPMainRowChangeEventHandler2);
					}
					while (dtZTPMainRowChangeEventHandler != dtZTPMainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler = this.dtZTPMainRowChangeEventHandler_3;
					DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler2;
					do
					{
						dtZTPMainRowChangeEventHandler2 = dtZTPMainRowChangeEventHandler;
						DataSetReportSubstation.dtZTPMainRowChangeEventHandler value2 = (DataSetReportSubstation.dtZTPMainRowChangeEventHandler)Delegate.Remove(dtZTPMainRowChangeEventHandler2, value);
						dtZTPMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtZTPMainRowChangeEventHandler>(ref this.dtZTPMainRowChangeEventHandler_3, value2, dtZTPMainRowChangeEventHandler2);
					}
					while (dtZTPMainRowChangeEventHandler != dtZTPMainRowChangeEventHandler2);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtZTPMainRow(DataSetReportSubstation.dtZTPMainRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtZTPMainRow AdddtZTPMainRow(int id, int idObjList, int idEquipment, string Name, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, string string_12, string string_13, string string_14, string string_15, string string_16)
			{
				DataSetReportSubstation.dtZTPMainRow dtZTPMainRow = (DataSetReportSubstation.dtZTPMainRow)base.NewRow();
				object[] itemArray = new object[]
				{
					id,
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
				DataSetReportSubstation.GClass2 gclass = (DataSetReportSubstation.GClass2)base.Clone();
				gclass.method_0();
				return gclass;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportSubstation.GClass2();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["idObjList"];
				this.dataColumn_2 = base.Columns["idEquipment"];
				this.dataColumn_3 = base.Columns["Name"];
				this.dataColumn_4 = base.Columns["Тип"];
				this.dataColumn_5 = base.Columns["Год_ввода_в_эксплуатацию"];
				this.dataColumn_6 = base.Columns["Заводской_номер"];
				this.dataColumn_7 = base.Columns["Регион"];
				this.dataColumn_8 = base.Columns["Улица"];
				this.dataColumn_9 = base.Columns["Дом"];
				this.dataColumn_10 = base.Columns["Дополнительно"];
				this.dataColumn_11 = base.Columns["Инвентарный_номер"];
				this.dataColumn_12 = base.Columns["Типовой_проект"];
				this.dataColumn_13 = base.Columns["Длина"];
				this.dataColumn_14 = base.Columns["Ширина"];
				this.dataColumn_15 = base.Columns["Высота"];
				this.dataColumn_16 = base.Columns["Площадь_без_ОЗ"];
				this.dataColumn_17 = base.Columns["Площадь_с_ОЗ"];
				this.dataColumn_18 = base.Columns["Материал"];
				this.dataColumn_19 = base.Columns["Грозозащита"];
				this.dataColumn_20 = base.Columns["Год_постройки"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("idEquipment", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("Тип", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Год_ввода_в_эксплуатацию", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("Заводской_номер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("Регион", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("Улица", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("Дом", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("Дополнительно", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("Инвентарный_номер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("Типовой_проект", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
				this.dataColumn_13 = new DataColumn("Длина", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_13);
				this.dataColumn_14 = new DataColumn("Ширина", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_14);
				this.dataColumn_15 = new DataColumn("Высота", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_15);
				this.dataColumn_16 = new DataColumn("Площадь_без_ОЗ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_16);
				this.dataColumn_17 = new DataColumn("Площадь_с_ОЗ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_17);
				this.dataColumn_18 = new DataColumn("Материал", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_18);
				this.dataColumn_19 = new DataColumn("Грозозащита", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_19);
				this.dataColumn_20 = new DataColumn("Год_постройки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_20);
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportSubstation.dtZTPMainRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtZTPMainRowChangeEventHandler_1 != null)
				{
					this.dtZTPMainRowChangeEventHandler_1(this, new DataSetReportSubstation.dtZTPMainRowChangeEvent((DataSetReportSubstation.dtZTPMainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtZTPMainRowChangeEventHandler_0 != null)
				{
					this.dtZTPMainRowChangeEventHandler_0(this, new DataSetReportSubstation.dtZTPMainRowChangeEvent((DataSetReportSubstation.dtZTPMainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtZTPMainRowChangeEventHandler_3 != null)
				{
					this.dtZTPMainRowChangeEventHandler_3(this, new DataSetReportSubstation.dtZTPMainRowChangeEvent((DataSetReportSubstation.dtZTPMainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtZTPMainRowChangeEventHandler_2 != null)
				{
					this.dtZTPMainRowChangeEventHandler_2(this, new DataSetReportSubstation.dtZTPMainRowChangeEvent((DataSetReportSubstation.dtZTPMainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtZTPMainRow(DataSetReportSubstation.dtZTPMainRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
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
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
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
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

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

			private DataColumn dataColumn_17;

			private DataColumn dataColumn_18;

			private DataColumn dataColumn_19;

			private DataColumn dataColumn_20;

			[CompilerGenerated]
			private DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportSubstation.dtZTPMainRowChangeEventHandler dtZTPMainRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtNumberOfEntriesDataTable : TypedTableBase<DataSetReportSubstation.dtNumberOfEntriesRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtNumberOfEntriesDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtNumberOfEntries";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtNumberOfEntriesDataTable(DataTable table)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected dtNumberOfEntriesDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CountAirLineLVColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CountAirLineHVColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CountCableLineLVColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CountCableLineHVColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			public DataSetReportSubstation.dtNumberOfEntriesRow this[int index]
			{
				get
				{
					return (DataSetReportSubstation.dtNumberOfEntriesRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler = this.dtNumberOfEntriesRowChangeEventHandler_0;
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler2;
					do
					{
						dtNumberOfEntriesRowChangeEventHandler2 = dtNumberOfEntriesRowChangeEventHandler;
						DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler value2 = (DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler)Delegate.Combine(dtNumberOfEntriesRowChangeEventHandler2, value);
						dtNumberOfEntriesRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler>(ref this.dtNumberOfEntriesRowChangeEventHandler_0, value2, dtNumberOfEntriesRowChangeEventHandler2);
					}
					while (dtNumberOfEntriesRowChangeEventHandler != dtNumberOfEntriesRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler = this.dtNumberOfEntriesRowChangeEventHandler_0;
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler2;
					do
					{
						dtNumberOfEntriesRowChangeEventHandler2 = dtNumberOfEntriesRowChangeEventHandler;
						DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler value2 = (DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler)Delegate.Remove(dtNumberOfEntriesRowChangeEventHandler2, value);
						dtNumberOfEntriesRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler>(ref this.dtNumberOfEntriesRowChangeEventHandler_0, value2, dtNumberOfEntriesRowChangeEventHandler2);
					}
					while (dtNumberOfEntriesRowChangeEventHandler != dtNumberOfEntriesRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler = this.dtNumberOfEntriesRowChangeEventHandler_1;
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler2;
					do
					{
						dtNumberOfEntriesRowChangeEventHandler2 = dtNumberOfEntriesRowChangeEventHandler;
						DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler value2 = (DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler)Delegate.Combine(dtNumberOfEntriesRowChangeEventHandler2, value);
						dtNumberOfEntriesRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler>(ref this.dtNumberOfEntriesRowChangeEventHandler_1, value2, dtNumberOfEntriesRowChangeEventHandler2);
					}
					while (dtNumberOfEntriesRowChangeEventHandler != dtNumberOfEntriesRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler = this.dtNumberOfEntriesRowChangeEventHandler_1;
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler2;
					do
					{
						dtNumberOfEntriesRowChangeEventHandler2 = dtNumberOfEntriesRowChangeEventHandler;
						DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler value2 = (DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler)Delegate.Remove(dtNumberOfEntriesRowChangeEventHandler2, value);
						dtNumberOfEntriesRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler>(ref this.dtNumberOfEntriesRowChangeEventHandler_1, value2, dtNumberOfEntriesRowChangeEventHandler2);
					}
					while (dtNumberOfEntriesRowChangeEventHandler != dtNumberOfEntriesRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler = this.dtNumberOfEntriesRowChangeEventHandler_2;
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler2;
					do
					{
						dtNumberOfEntriesRowChangeEventHandler2 = dtNumberOfEntriesRowChangeEventHandler;
						DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler value2 = (DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler)Delegate.Combine(dtNumberOfEntriesRowChangeEventHandler2, value);
						dtNumberOfEntriesRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler>(ref this.dtNumberOfEntriesRowChangeEventHandler_2, value2, dtNumberOfEntriesRowChangeEventHandler2);
					}
					while (dtNumberOfEntriesRowChangeEventHandler != dtNumberOfEntriesRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler = this.dtNumberOfEntriesRowChangeEventHandler_2;
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler2;
					do
					{
						dtNumberOfEntriesRowChangeEventHandler2 = dtNumberOfEntriesRowChangeEventHandler;
						DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler value2 = (DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler)Delegate.Remove(dtNumberOfEntriesRowChangeEventHandler2, value);
						dtNumberOfEntriesRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler>(ref this.dtNumberOfEntriesRowChangeEventHandler_2, value2, dtNumberOfEntriesRowChangeEventHandler2);
					}
					while (dtNumberOfEntriesRowChangeEventHandler != dtNumberOfEntriesRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler = this.dtNumberOfEntriesRowChangeEventHandler_3;
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler2;
					do
					{
						dtNumberOfEntriesRowChangeEventHandler2 = dtNumberOfEntriesRowChangeEventHandler;
						DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler value2 = (DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler)Delegate.Combine(dtNumberOfEntriesRowChangeEventHandler2, value);
						dtNumberOfEntriesRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler>(ref this.dtNumberOfEntriesRowChangeEventHandler_3, value2, dtNumberOfEntriesRowChangeEventHandler2);
					}
					while (dtNumberOfEntriesRowChangeEventHandler != dtNumberOfEntriesRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler = this.dtNumberOfEntriesRowChangeEventHandler_3;
					DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler2;
					do
					{
						dtNumberOfEntriesRowChangeEventHandler2 = dtNumberOfEntriesRowChangeEventHandler;
						DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler value2 = (DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler)Delegate.Remove(dtNumberOfEntriesRowChangeEventHandler2, value);
						dtNumberOfEntriesRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler>(ref this.dtNumberOfEntriesRowChangeEventHandler_3, value2, dtNumberOfEntriesRowChangeEventHandler2);
					}
					while (dtNumberOfEntriesRowChangeEventHandler != dtNumberOfEntriesRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtNumberOfEntriesRow(DataSetReportSubstation.dtNumberOfEntriesRow row)
			{
				base.Rows.Add(row);
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportSubstation.dtNumberOfEntriesDataTable dtNumberOfEntriesDataTable = (DataSetReportSubstation.dtNumberOfEntriesDataTable)base.Clone();
				dtNumberOfEntriesDataTable.method_0();
				return dtNumberOfEntriesDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportSubstation.dtNumberOfEntriesDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["CountAirLineLV"];
				this.dataColumn_1 = base.Columns["CountAirLineHV"];
				this.dataColumn_2 = base.Columns["CountCableLineLV"];
				this.dataColumn_3 = base.Columns["CountCableLineHV"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("CountAirLineLV", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("CountAirLineHV", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("CountCableLineLV", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("CountCableLineHV", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportSubstation.dtNumberOfEntriesRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtNumberOfEntriesRowChangeEventHandler_1 != null)
				{
					this.dtNumberOfEntriesRowChangeEventHandler_1(this, new DataSetReportSubstation.dtNumberOfEntriesRowChangeEvent((DataSetReportSubstation.dtNumberOfEntriesRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtNumberOfEntriesRowChangeEventHandler_0 != null)
				{
					this.dtNumberOfEntriesRowChangeEventHandler_0(this, new DataSetReportSubstation.dtNumberOfEntriesRowChangeEvent((DataSetReportSubstation.dtNumberOfEntriesRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtNumberOfEntriesRowChangeEventHandler_3 != null)
				{
					this.dtNumberOfEntriesRowChangeEventHandler_3(this, new DataSetReportSubstation.dtNumberOfEntriesRowChangeEvent((DataSetReportSubstation.dtNumberOfEntriesRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtNumberOfEntriesRowChangeEventHandler_2 != null)
				{
					this.dtNumberOfEntriesRowChangeEventHandler_2(this, new DataSetReportSubstation.dtNumberOfEntriesRowChangeEvent((DataSetReportSubstation.dtNumberOfEntriesRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtNumberOfEntriesRow(DataSetReportSubstation.dtNumberOfEntriesRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
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
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
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
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			private DataColumn dataColumn_0;

			private DataColumn dataColumn_1;

			private DataColumn dataColumn_2;

			private DataColumn dataColumn_3;

			[CompilerGenerated]
			private DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportSubstation.dtNumberOfEntriesRowChangeEventHandler dtNumberOfEntriesRowChangeEventHandler_3;
		}

		public class dtKTPMainRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtKTPMainRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.gclass1_0 = (DataSetReportSubstation.GClass1)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int id
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.gclass1_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass1_0.idColumn] = value;
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
						result = (int)base[this.gclass1_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass1_0.idObjListColumn] = value;
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
						result = (string)base[this.gclass1_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass1_0.NameColumn] = value;
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
						result = (string)base[this.gclass1_0.DataColumn_0];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Тип' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass1_0.DataColumn_0] = value;
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
						result = (string)base[this.gclass1_0.DataColumn_1];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Инвентарный_номер' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass1_0.DataColumn_1] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_2
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.gclass1_0.DataColumn_2];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Регион' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass1_0.DataColumn_2] = value;
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
						result = (string)base[this.gclass1_0.DataColumn_3];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Улица' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass1_0.DataColumn_3] = value;
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
						result = (string)base[this.gclass1_0.DataColumn_4];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Дом' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass1_0.DataColumn_4] = value;
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
						result = (string)base[this.gclass1_0.DataColumn_5];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Дополнительно' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass1_0.DataColumn_5] = value;
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
						result = (string)base[this.gclass1_0.DataColumn_6];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Тип_ТП' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass1_0.DataColumn_6] = value;
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
						result = (string)base[this.gclass1_0.DataColumn_7];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_постройки' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass1_0.DataColumn_7] = value;
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
						result = (string)base[this.gclass1_0.DataColumn_8];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_ввода_в_эксплуатацию' in table 'dtKTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass1_0.DataColumn_8] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidNull()
			{
				return base.IsNull(this.gclass1_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.gclass1_0.idColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.gclass1_0.idObjListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidObjListNull()
			{
				base[this.gclass1_0.idObjListColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.gclass1_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.gclass1_0.NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_0()
			{
				return base.IsNull(this.gclass1_0.DataColumn_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_1()
			{
				base[this.gclass1_0.DataColumn_0] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_2()
			{
				return base.IsNull(this.gclass1_0.DataColumn_1);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_3()
			{
				base[this.gclass1_0.DataColumn_1] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_4()
			{
				return base.IsNull(this.gclass1_0.DataColumn_2);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5()
			{
				base[this.gclass1_0.DataColumn_2] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_6()
			{
				return base.IsNull(this.gclass1_0.DataColumn_3);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7()
			{
				base[this.gclass1_0.DataColumn_3] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_8()
			{
				return base.IsNull(this.gclass1_0.DataColumn_4);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_9()
			{
				base[this.gclass1_0.DataColumn_4] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_10()
			{
				return base.IsNull(this.gclass1_0.DataColumn_5);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_11()
			{
				base[this.gclass1_0.DataColumn_5] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_12()
			{
				return base.IsNull(this.gclass1_0.DataColumn_6);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_13()
			{
				base[this.gclass1_0.DataColumn_6] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_14()
			{
				return base.IsNull(this.gclass1_0.DataColumn_7);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_15()
			{
				base[this.gclass1_0.DataColumn_7] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_16()
			{
				return base.IsNull(this.gclass1_0.DataColumn_8);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_17()
			{
				base[this.gclass1_0.DataColumn_8] = Convert.DBNull;
			}

			private DataSetReportSubstation.GClass1 gclass1_0;
		}

		public class dtEmptyRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtEmptyRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtEmptyDataTable_0 = (DataSetReportSubstation.dtEmptyDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int id
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtEmptyDataTable_0.NameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameNull()
			{
				base[this.dtEmptyDataTable_0.NameColumn] = Convert.DBNull;
			}

			private DataSetReportSubstation.dtEmptyDataTable dtEmptyDataTable_0;
		}

		public class dtEquipmentRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtEquipmentRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtEquipmentDataTable_0 = (DataSetReportSubstation.dtEquipmentDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int id
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidNull()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.idColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IstypeCodeIdNull()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.typeCodeIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SettypeCodeIdNull()
			{
				base[this.dtEquipmentDataTable_0.typeCodeIdColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IstypeNameNull()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.typeNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SettypeNameNull()
			{
				base[this.dtEquipmentDataTable_0.typeNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.NameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_3()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_10);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_24()
			{
				return base.IsNull(this.dtEquipmentDataTable_0.DataColumn_12);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_25()
			{
				base[this.dtEquipmentDataTable_0.DataColumn_12] = Convert.DBNull;
			}

			private DataSetReportSubstation.dtEquipmentDataTable dtEquipmentDataTable_0;
		}

		public class dtZTPMainRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtZTPMainRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.gclass2_0 = (DataSetReportSubstation.GClass2)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int id
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.gclass2_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.idColumn] = value;
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
						result = (int)base[this.gclass2_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.idObjListColumn] = value;
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
						result = (int)base[this.gclass2_0.idEquipmentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idEquipment' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.idEquipmentColumn] = value;
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
						result = (string)base[this.gclass2_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.NameColumn] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_0];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Тип' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_0] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_1];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_ввода_в_эксплуатацию' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_1] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_2
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.gclass2_0.DataColumn_2];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Заводской_номер' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_2] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_3];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Регион' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_3] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_4];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Улица' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_4] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_5];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Дом' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_5] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_6];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Дополнительно' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_6] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_7];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Инвентарный_номер' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_7] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_8];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Типовой_проект' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_8] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_9];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Длина' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_9] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_10];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ширина' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_10] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_11];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Высота' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_11] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_12];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Площадь_без_ОЗ' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_12] = value;
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
						result = (string)base[this.gclass2_0.DataColumn_13];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Площадь_с_ОЗ' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_13] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_14
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.gclass2_0.DataColumn_14];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Материал' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_14] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_15
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.gclass2_0.DataColumn_15];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Грозозащита' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_15] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_16
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.gclass2_0.DataColumn_16];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Год_постройки' in table 'dtZTPMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.gclass2_0.DataColumn_16] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidNull()
			{
				return base.IsNull(this.gclass2_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.gclass2_0.idColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.gclass2_0.idObjListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidObjListNull()
			{
				base[this.gclass2_0.idObjListColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidEquipmentNull()
			{
				return base.IsNull(this.gclass2_0.idEquipmentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidEquipmentNull()
			{
				base[this.gclass2_0.idEquipmentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.gclass2_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.gclass2_0.NameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_0()
			{
				return base.IsNull(this.gclass2_0.DataColumn_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_1()
			{
				base[this.gclass2_0.DataColumn_0] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_2()
			{
				return base.IsNull(this.gclass2_0.DataColumn_1);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_3()
			{
				base[this.gclass2_0.DataColumn_1] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_4()
			{
				return base.IsNull(this.gclass2_0.DataColumn_2);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5()
			{
				base[this.gclass2_0.DataColumn_2] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.gclass2_0.DataColumn_3);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_7()
			{
				base[this.gclass2_0.DataColumn_3] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_8()
			{
				return base.IsNull(this.gclass2_0.DataColumn_4);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_9()
			{
				base[this.gclass2_0.DataColumn_4] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_10()
			{
				return base.IsNull(this.gclass2_0.DataColumn_5);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_11()
			{
				base[this.gclass2_0.DataColumn_5] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_12()
			{
				return base.IsNull(this.gclass2_0.DataColumn_6);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_13()
			{
				base[this.gclass2_0.DataColumn_6] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_14()
			{
				return base.IsNull(this.gclass2_0.DataColumn_7);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_15()
			{
				base[this.gclass2_0.DataColumn_7] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_16()
			{
				return base.IsNull(this.gclass2_0.DataColumn_8);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_17()
			{
				base[this.gclass2_0.DataColumn_8] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_18()
			{
				return base.IsNull(this.gclass2_0.DataColumn_9);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.gclass2_0.DataColumn_9] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.gclass2_0.DataColumn_10);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.gclass2_0.DataColumn_10] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_22()
			{
				return base.IsNull(this.gclass2_0.DataColumn_11);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_23()
			{
				base[this.gclass2_0.DataColumn_11] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.gclass2_0.DataColumn_12);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.gclass2_0.DataColumn_12] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_26()
			{
				return base.IsNull(this.gclass2_0.DataColumn_13);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_27()
			{
				base[this.gclass2_0.DataColumn_13] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_28()
			{
				return base.IsNull(this.gclass2_0.DataColumn_14);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_29()
			{
				base[this.gclass2_0.DataColumn_14] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_30()
			{
				return base.IsNull(this.gclass2_0.DataColumn_15);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_31()
			{
				base[this.gclass2_0.DataColumn_15] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_32()
			{
				return base.IsNull(this.gclass2_0.DataColumn_16);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_33()
			{
				base[this.gclass2_0.DataColumn_16] = Convert.DBNull;
			}

			private DataSetReportSubstation.GClass2 gclass2_0;
		}

		public class dtNumberOfEntriesRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtNumberOfEntriesRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsCountCableLineHVNull()
			{
				return base.IsNull(this.dtNumberOfEntriesDataTable_0.CountCableLineHVColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			public dtKTPMainRowChangeEvent(DataSetReportSubstation.dtKTPMainRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtKTPMainRow_0 = row;
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
			public dtEmptyRowChangeEvent(DataSetReportSubstation.dtEmptyRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtEmptyRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtEmptyRow Row
			{
				get
				{
					return this.dtEmptyRow_0;
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

			private DataSetReportSubstation.dtEmptyRow dtEmptyRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtEquipmentRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtEquipmentRowChangeEvent(DataSetReportSubstation.dtEquipmentRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtEquipmentRow_0 = row;
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			public dtZTPMainRowChangeEvent(DataSetReportSubstation.dtZTPMainRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtZTPMainRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtNumberOfEntriesRowChangeEvent(DataSetReportSubstation.dtNumberOfEntriesRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtNumberOfEntriesRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportSubstation.dtNumberOfEntriesRow Row
			{
				get
				{
					return this.dtNumberOfEntriesRow_0;
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

			private DataSetReportSubstation.dtNumberOfEntriesRow dtNumberOfEntriesRow_0;

			private DataRowAction dataRowAction_0;
		}
	}
}
