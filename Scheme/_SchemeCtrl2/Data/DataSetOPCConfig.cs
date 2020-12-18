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

namespace SchemeCtrl2.Data
{
	[XmlRoot("DataSetOPCConfig")]
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	internal class DataSetOPCConfig : DataSet
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetOPCConfig()
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
		protected DataSetOPCConfig(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0, false)
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
				if (dataSet.Tables["vParametersTags"] != null)
				{
					base.Tables.Add(new DataSetOPCConfig.vParametersTagsDataTable(dataSet.Tables["vParametersTags"]));
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

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public DataSetOPCConfig.vParametersTagsDataTable vParametersTags
		{
			get
			{
				return this.tablevParametersTags;
			}
		}

		[Browsable(true)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			DataSetOPCConfig dataSetOPCConfig = (DataSetOPCConfig)base.Clone();
			dataSetOPCConfig.method_0();
			dataSetOPCConfig.SchemaSerializationMode = this.SchemaSerializationMode;
			return dataSetOPCConfig;
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["vParametersTags"] != null)
				{
					base.Tables.Add(new DataSetOPCConfig.vParametersTagsDataTable(dataSet.Tables["vParametersTags"]));
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_1(bool bool_0)
		{
			this.tablevParametersTags = (DataSetOPCConfig.vParametersTagsDataTable)base.Tables["vParametersTags"];
			if (bool_0 && this.tablevParametersTags != null)
			{
				this.tablevParametersTags.method_2();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_2()
		{
			base.DataSetName = "DataSetOPCConfig";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/DataSetOPCConfig.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tablevParametersTags = new DataSetOPCConfig.vParametersTagsDataTable();
			base.Tables.Add(this.tablevParametersTags);
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			DataSetOPCConfig dataSetOPCConfig = new DataSetOPCConfig();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dataSetOPCConfig.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSetOPCConfig.GetSchemaSerializable();
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
					goto IL_141;
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
			IL_141:
			xmlSchemaSet_0.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}

		private DataSetOPCConfig.vParametersTagsDataTable tablevParametersTags;

		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate30(object sender, DataSetOPCConfig.EventArgs28 e);

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vParametersTagsDataTable : TypedTableBase<DataSetOPCConfig.Class73>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public vParametersTagsDataTable()
			{
				base.TableName = "vParametersTags";
				this.BeginInit();
				this.method_3();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal vParametersTagsDataTable(DataTable dataTable_0)
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
			protected vParametersTagsDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_2();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IdColumn
			{
				get
				{
					return this.columnId;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ServerIdColumn
			{
				get
				{
					return this.columnServerId;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParameterIdColumn
			{
				get
				{
					return this.columnParameterId;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ItemNameColumn
			{
				get
				{
					return this.columnItemName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn BitMaskColumn
			{
				get
				{
					return this.columnBitMask;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObjectIdColumn
			{
				get
				{
					return this.columnObjectId;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn SourceColumn
			{
				get
				{
					return this.columnSource;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AreaColumn
			{
				get
				{
					return this.columnArea;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn pDescriptionColumn
			{
				get
				{
					return this.columnpDescription;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn MeasureColumn
			{
				get
				{
					return this.columnMeasure;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ZeroNormalStateColumn
			{
				get
				{
					return this.columnZeroNormalState;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn StateNormNameColumn
			{
				get
				{
					return this.columnStateNormName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn StateAbnormNameColumn
			{
				get
				{
					return this.columnStateAbnormName;
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
			public DataSetOPCConfig.Class73 this[int int_0]
			{
				get
				{
					return (DataSetOPCConfig.Class73)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetOPCConfig.Delegate30 vParametersTagsRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetOPCConfig.Delegate30 vParametersTagsRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetOPCConfig.Delegate30 vParametersTagsRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetOPCConfig.Delegate30 vParametersTagsRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetOPCConfig.Class73 class73_0)
			{
				base.Rows.Add(class73_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetOPCConfig.Class73 method_1(int int_0, int int_1, int int_2, string string_0, int int_3, int int_4, string string_1, string string_2, string string_3, string string_4, bool bool_0, string string_5, string string_6)
			{
				DataSetOPCConfig.Class73 @class = (DataSetOPCConfig.Class73)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
					int_1,
					int_2,
					string_0,
					int_3,
					int_4,
					string_1,
					string_2,
					string_3,
					string_4,
					bool_0,
					string_5,
					string_6
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetOPCConfig.vParametersTagsDataTable vParametersTagsDataTable = (DataSetOPCConfig.vParametersTagsDataTable)base.Clone();
				vParametersTagsDataTable.method_2();
				return vParametersTagsDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetOPCConfig.vParametersTagsDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_2()
			{
				this.columnId = base.Columns["Id"];
				this.columnServerId = base.Columns["ServerId"];
				this.columnParameterId = base.Columns["ParameterId"];
				this.columnItemName = base.Columns["ItemName"];
				this.columnBitMask = base.Columns["BitMask"];
				this.columnObjectId = base.Columns["ObjectId"];
				this.columnSource = base.Columns["Source"];
				this.columnArea = base.Columns["Area"];
				this.columnpDescription = base.Columns["pDescription"];
				this.columnMeasure = base.Columns["Measure"];
				this.columnZeroNormalState = base.Columns["ZeroNormalState"];
				this.columnStateNormName = base.Columns["StateNormName"];
				this.columnStateAbnormName = base.Columns["StateAbnormName"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_3()
			{
				this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnId);
				this.columnServerId = new DataColumn("ServerId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnServerId);
				this.columnParameterId = new DataColumn("ParameterId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnParameterId);
				this.columnItemName = new DataColumn("ItemName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnItemName);
				this.columnBitMask = new DataColumn("BitMask", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnBitMask);
				this.columnObjectId = new DataColumn("ObjectId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnObjectId);
				this.columnSource = new DataColumn("Source", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSource);
				this.columnArea = new DataColumn("Area", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnArea);
				this.columnpDescription = new DataColumn("pDescription", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnpDescription);
				this.columnMeasure = new DataColumn("Measure", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMeasure);
				this.columnZeroNormalState = new DataColumn("ZeroNormalState", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnZeroNormalState);
				this.columnStateNormName = new DataColumn("StateNormName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnStateNormName);
				this.columnStateAbnormName = new DataColumn("StateAbnormName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnStateAbnormName);
				this.columnItemName.ReadOnly = true;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetOPCConfig.Class73 method_4()
			{
				return (DataSetOPCConfig.Class73)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetOPCConfig.Class73(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetOPCConfig.Class73);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vParametersTagsRowChanged != null)
				{
					this.vParametersTagsRowChanged(this, new DataSetOPCConfig.EventArgs28((DataSetOPCConfig.Class73)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vParametersTagsRowChanging != null)
				{
					this.vParametersTagsRowChanging(this, new DataSetOPCConfig.EventArgs28((DataSetOPCConfig.Class73)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vParametersTagsRowDeleted != null)
				{
					this.vParametersTagsRowDeleted(this, new DataSetOPCConfig.EventArgs28((DataSetOPCConfig.Class73)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vParametersTagsRowDeleting != null)
				{
					this.vParametersTagsRowDeleting(this, new DataSetOPCConfig.EventArgs28((DataSetOPCConfig.Class73)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5(DataSetOPCConfig.Class73 class73_0)
			{
				base.Rows.Remove(class73_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetOPCConfig dataSetOPCConfig = new DataSetOPCConfig();
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
				xmlSchemaAttribute.FixedValue = dataSetOPCConfig.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vParametersTagsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetOPCConfig.GetSchemaSerializable();
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
						goto IL_1F4;
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
				IL_1F4:
				xmlSchemaSet_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			private DataColumn columnId;

			private DataColumn columnServerId;

			private DataColumn columnParameterId;

			private DataColumn columnItemName;

			private DataColumn columnBitMask;

			private DataColumn columnObjectId;

			private DataColumn columnSource;

			private DataColumn columnArea;

			private DataColumn columnpDescription;

			private DataColumn columnMeasure;

			private DataColumn columnZeroNormalState;

			private DataColumn columnStateNormName;

			private DataColumn columnStateAbnormName;
		}

		public class Class73 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class73(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vParametersTagsDataTable_0 = (DataSetOPCConfig.vParametersTagsDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Id
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vParametersTagsDataTable_0.IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Id' in table 'vParametersTags' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vParametersTagsDataTable_0.IdColumn] = value;
				}
			}

			public int method_0()
			{
				int result;
				try
				{
					result = (int)base[this.vParametersTagsDataTable_0.ServerIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ServerId' in table 'vParametersTags' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(int int_0)
			{
				base[this.vParametersTagsDataTable_0.ServerIdColumn] = int_0;
			}

			public int method_2()
			{
				int result;
				try
				{
					result = (int)base[this.vParametersTagsDataTable_0.ParameterIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParameterId' in table 'vParametersTags' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(int int_0)
			{
				base[this.vParametersTagsDataTable_0.ParameterIdColumn] = int_0;
			}

			public string method_4()
			{
				string result;
				try
				{
					result = (string)base[this.vParametersTagsDataTable_0.ItemNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ItemName' in table 'vParametersTags' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(string value)
			{
				base[this.vParametersTagsDataTable_0.ItemNameColumn] = value;
			}

			public int method_6()
			{
				int result;
				try
				{
					result = (int)base[this.vParametersTagsDataTable_0.BitMaskColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'BitMask' in table 'vParametersTags' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(int int_0)
			{
				base[this.vParametersTagsDataTable_0.BitMaskColumn] = int_0;
			}

			public int method_8()
			{
				int result;
				try
				{
					result = (int)base[this.vParametersTagsDataTable_0.ObjectIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ObjectId' in table 'vParametersTags' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(int int_0)
			{
				base[this.vParametersTagsDataTable_0.ObjectIdColumn] = int_0;
			}

			public string method_10()
			{
				string result;
				try
				{
					result = (string)base[this.vParametersTagsDataTable_0.SourceColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Source' in table 'vParametersTags' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(string value)
			{
				base[this.vParametersTagsDataTable_0.SourceColumn] = value;
			}

			public string method_12()
			{
				string result;
				try
				{
					result = (string)base[this.vParametersTagsDataTable_0.AreaColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Area' in table 'vParametersTags' is DBNull.", innerException);
				}
				return result;
			}

			public void method_13(string value)
			{
				base[this.vParametersTagsDataTable_0.AreaColumn] = value;
			}

			public string method_14()
			{
				string result;
				try
				{
					result = (string)base[this.vParametersTagsDataTable_0.pDescriptionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'pDescription' in table 'vParametersTags' is DBNull.", innerException);
				}
				return result;
			}

			public void method_15(string value)
			{
				base[this.vParametersTagsDataTable_0.pDescriptionColumn] = value;
			}

			public string method_16()
			{
				string result;
				try
				{
					result = (string)base[this.vParametersTagsDataTable_0.MeasureColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Measure' in table 'vParametersTags' is DBNull.", innerException);
				}
				return result;
			}

			public void method_17(string value)
			{
				base[this.vParametersTagsDataTable_0.MeasureColumn] = value;
			}

			public bool method_18()
			{
				bool result;
				try
				{
					result = (bool)base[this.vParametersTagsDataTable_0.ZeroNormalStateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ZeroNormalState' in table 'vParametersTags' is DBNull.", innerException);
				}
				return result;
			}

			public void method_19(bool bool_0)
			{
				base[this.vParametersTagsDataTable_0.ZeroNormalStateColumn] = bool_0;
			}

			public string method_20()
			{
				string result;
				try
				{
					result = (string)base[this.vParametersTagsDataTable_0.StateNormNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'StateNormName' in table 'vParametersTags' is DBNull.", innerException);
				}
				return result;
			}

			public void method_21(string value)
			{
				base[this.vParametersTagsDataTable_0.StateNormNameColumn] = value;
			}

			public string method_22()
			{
				string result;
				try
				{
					result = (string)base[this.vParametersTagsDataTable_0.StateAbnormNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'StateAbnormName' in table 'vParametersTags' is DBNull.", innerException);
				}
				return result;
			}

			public void method_23(string value)
			{
				base[this.vParametersTagsDataTable_0.StateAbnormNameColumn] = value;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.IdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_25()
			{
				base[this.vParametersTagsDataTable_0.IdColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_26()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.ServerIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_27()
			{
				base[this.vParametersTagsDataTable_0.ServerIdColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_28()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.ParameterIdColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_29()
			{
				base[this.vParametersTagsDataTable_0.ParameterIdColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_30()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.ItemNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_31()
			{
				base[this.vParametersTagsDataTable_0.ItemNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_32()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.BitMaskColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_33()
			{
				base[this.vParametersTagsDataTable_0.BitMaskColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_34()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.ObjectIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_35()
			{
				base[this.vParametersTagsDataTable_0.ObjectIdColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_36()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.SourceColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_37()
			{
				base[this.vParametersTagsDataTable_0.SourceColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_38()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.AreaColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_39()
			{
				base[this.vParametersTagsDataTable_0.AreaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_40()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.pDescriptionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_41()
			{
				base[this.vParametersTagsDataTable_0.pDescriptionColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_42()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.MeasureColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_43()
			{
				base[this.vParametersTagsDataTable_0.MeasureColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_44()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.ZeroNormalStateColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_45()
			{
				base[this.vParametersTagsDataTable_0.ZeroNormalStateColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_46()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.StateNormNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_47()
			{
				base[this.vParametersTagsDataTable_0.StateNormNameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_48()
			{
				return base.IsNull(this.vParametersTagsDataTable_0.StateAbnormNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_49()
			{
				base[this.vParametersTagsDataTable_0.StateAbnormNameColumn] = Convert.DBNull;
			}

			private DataSetOPCConfig.vParametersTagsDataTable vParametersTagsDataTable_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs28 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs28(DataSetOPCConfig.Class73 class73_1, DataRowAction dataRowAction_1)
			{
				this.class73_0 = class73_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetOPCConfig.Class73 method_0()
			{
				return this.class73_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetOPCConfig.Class73 class73_0;

			private DataRowAction dataRowAction_0;
		}
	}
}
