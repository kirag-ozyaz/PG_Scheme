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

namespace Passport.Controls.TabPageSwitchgear
{
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[HelpKeyword("vs.data.DataSet")]
	[ToolboxItem(true)]
	[XmlRoot("dsSwitchgears")]
	[DesignerCategory("code")]
	[Serializable]
	internal class dsSwitchgears : DataSet
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public dsSwitchgears()
		{
			base.BeginInit();
			this.method_2();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_8);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected dsSwitchgears(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0, false)
		{
			if (base.IsBinarySerialized(serializationInfo_0, streamingContext_0))
			{
				this.method_1(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_8);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
				return;
			}
			string s = (string)serializationInfo_0.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["vPassportShowSwitchgears"] != null)
				{
					base.Tables.Add(new dsSwitchgears.vPassportShowSwitchgearsDataTable(dataSet.Tables["vPassportShowSwitchgears"]));
				}
				if (dataSet.Tables["vP_GetSwitchgears"] != null)
				{
					base.Tables.Add(new dsSwitchgears.vP_GetSwitchgearsDataTable(dataSet.Tables["vP_GetSwitchgears"]));
				}
				if (dataSet.Tables["vPassportShowBus"] != null)
				{
					base.Tables.Add(new dsSwitchgears.vPassportShowBusDataTable(dataSet.Tables["vPassportShowBus"]));
				}
				if (dataSet.Tables["vPassportShowCells"] != null)
				{
					base.Tables.Add(new dsSwitchgears.vPassportShowCellsDataTable(dataSet.Tables["vPassportShowCells"]));
				}
				if (dataSet.Tables["vPassportShowSwitches"] != null)
				{
					base.Tables.Add(new dsSwitchgears.vPassportShowSwitchesDataTable(dataSet.Tables["vPassportShowSwitches"]));
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
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.method_8);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public dsSwitchgears.vPassportShowSwitchgearsDataTable vPassportShowSwitchgears
		{
			get
			{
				return this.tablevPassportShowSwitchgears;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public dsSwitchgears.vP_GetSwitchgearsDataTable vP_GetSwitchgears
		{
			get
			{
				return this.tablevP_GetSwitchgears;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public dsSwitchgears.vPassportShowBusDataTable vPassportShowBus
		{
			get
			{
				return this.tablevPassportShowBus;
			}
		}

		[DebuggerNonUserCode]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public dsSwitchgears.vPassportShowCellsDataTable vPassportShowCells
		{
			get
			{
				return this.tablevPassportShowCells;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public dsSwitchgears.vPassportShowSwitchesDataTable vPassportShowSwitches
		{
			get
			{
				return this.tablevPassportShowSwitches;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(true)]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
			dsSwitchgears dsSwitchgears = (dsSwitchgears)base.Clone();
			dsSwitchgears.method_0();
			dsSwitchgears.SchemaSerializationMode = this.SchemaSerializationMode;
			return dsSwitchgears;
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["vPassportShowSwitchgears"] != null)
				{
					base.Tables.Add(new dsSwitchgears.vPassportShowSwitchgearsDataTable(dataSet.Tables["vPassportShowSwitchgears"]));
				}
				if (dataSet.Tables["vP_GetSwitchgears"] != null)
				{
					base.Tables.Add(new dsSwitchgears.vP_GetSwitchgearsDataTable(dataSet.Tables["vP_GetSwitchgears"]));
				}
				if (dataSet.Tables["vPassportShowBus"] != null)
				{
					base.Tables.Add(new dsSwitchgears.vPassportShowBusDataTable(dataSet.Tables["vPassportShowBus"]));
				}
				if (dataSet.Tables["vPassportShowCells"] != null)
				{
					base.Tables.Add(new dsSwitchgears.vPassportShowCellsDataTable(dataSet.Tables["vPassportShowCells"]));
				}
				if (dataSet.Tables["vPassportShowSwitches"] != null)
				{
					base.Tables.Add(new dsSwitchgears.vPassportShowSwitchesDataTable(dataSet.Tables["vPassportShowSwitches"]));
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_1(bool bool_0)
		{
			this.tablevPassportShowSwitchgears = (dsSwitchgears.vPassportShowSwitchgearsDataTable)base.Tables["vPassportShowSwitchgears"];
			if (bool_0 && this.tablevPassportShowSwitchgears != null)
			{
				this.tablevPassportShowSwitchgears.method_2();
			}
			this.tablevP_GetSwitchgears = (dsSwitchgears.vP_GetSwitchgearsDataTable)base.Tables["vP_GetSwitchgears"];
			if (bool_0 && this.tablevP_GetSwitchgears != null)
			{
				this.tablevP_GetSwitchgears.method_2();
			}
			this.tablevPassportShowBus = (dsSwitchgears.vPassportShowBusDataTable)base.Tables["vPassportShowBus"];
			if (bool_0 && this.tablevPassportShowBus != null)
			{
				this.tablevPassportShowBus.method_2();
			}
			this.tablevPassportShowCells = (dsSwitchgears.vPassportShowCellsDataTable)base.Tables["vPassportShowCells"];
			if (bool_0 && this.tablevPassportShowCells != null)
			{
				this.tablevPassportShowCells.method_2();
			}
			this.tablevPassportShowSwitches = (dsSwitchgears.vPassportShowSwitchesDataTable)base.Tables["vPassportShowSwitches"];
			if (bool_0 && this.tablevPassportShowSwitches != null)
			{
				this.tablevPassportShowSwitches.method_2();
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_2()
		{
			base.DataSetName = "dsSwitchgears";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/dsSwitchgears.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tablevPassportShowSwitchgears = new dsSwitchgears.vPassportShowSwitchgearsDataTable();
			base.Tables.Add(this.tablevPassportShowSwitchgears);
			this.tablevP_GetSwitchgears = new dsSwitchgears.vP_GetSwitchgearsDataTable();
			base.Tables.Add(this.tablevP_GetSwitchgears);
			this.tablevPassportShowBus = new dsSwitchgears.vPassportShowBusDataTable();
			base.Tables.Add(this.tablevPassportShowBus);
			this.tablevPassportShowCells = new dsSwitchgears.vPassportShowCellsDataTable();
			base.Tables.Add(this.tablevPassportShowCells);
			this.tablevPassportShowSwitches = new dsSwitchgears.vPassportShowSwitchesDataTable();
			base.Tables.Add(this.tablevPassportShowSwitches);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool method_5()
		{
			return false;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_8(object sender, CollectionChangeEventArgs e)
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
			dsSwitchgears dsSwitchgears = new dsSwitchgears();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dsSwitchgears.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dsSwitchgears.GetSchemaSerializable();
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

		private dsSwitchgears.vPassportShowSwitchgearsDataTable tablevPassportShowSwitchgears;

		private dsSwitchgears.vP_GetSwitchgearsDataTable tablevP_GetSwitchgears;

		private dsSwitchgears.vPassportShowBusDataTable tablevPassportShowBus;

		private dsSwitchgears.vPassportShowCellsDataTable tablevPassportShowCells;

		private dsSwitchgears.vPassportShowSwitchesDataTable tablevPassportShowSwitches;

		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate135(object sender, dsSwitchgears.EventArgs135 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate136(object sender, dsSwitchgears.EventArgs136 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate137(object sender, dsSwitchgears.EventArgs137 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate138(object sender, dsSwitchgears.EventArgs138 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate139(object sender, dsSwitchgears.EventArgs139 e);

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vPassportShowSwitchgearsDataTable : TypedTableBase<dsSwitchgears.Class199>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public vPassportShowSwitchgearsDataTable()
			{
				base.TableName = "vPassportShowSwitchgears";
				this.BeginInit();
				this.method_3();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal vPassportShowSwitchgearsDataTable(DataTable dataTable_0)
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
			protected vPassportShowSwitchgearsDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idCharColumn
			{
				get
				{
					return this.columnidChar;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParentIdCharColumn
			{
				get
				{
					return this.columnParentIdChar;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TabIndexColumn
			{
				get
				{
					return this.columnTabIndex;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn isGroupColumn
			{
				get
				{
					return this.columnisGroup;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[Browsable(false)]
			[DebuggerNonUserCode]
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
			public dsSwitchgears.Class199 this[int int_0]
			{
				get
				{
					return (dsSwitchgears.Class199)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate135 vPassportShowSwitchgearsRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate135 vPassportShowSwitchgearsRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate135 vPassportShowSwitchgearsRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate135 vPassportShowSwitchgearsRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(dsSwitchgears.Class199 class199_0)
			{
				base.Rows.Add(class199_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dsSwitchgears.Class199 method_1(int int_0, int int_1, DateTime dateTime_0, int int_2, int int_3, string string_0, string string_1, string string_2, int int_4, bool bool_0, bool bool_1, bool bool_2, bool bool_3)
			{
				dsSwitchgears.Class199 @class = (dsSwitchgears.Class199)base.NewRow();
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				dsSwitchgears.vPassportShowSwitchgearsDataTable vPassportShowSwitchgearsDataTable = (dsSwitchgears.vPassportShowSwitchgearsDataTable)base.Clone();
				vPassportShowSwitchgearsDataTable.method_2();
				return vPassportShowSwitchgearsDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new dsSwitchgears.vPassportShowSwitchgearsDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			public dsSwitchgears.Class199 method_4()
			{
				return (dsSwitchgears.Class199)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsSwitchgears.Class199(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(dsSwitchgears.Class199);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vPassportShowSwitchgearsRowChanged != null)
				{
					this.vPassportShowSwitchgearsRowChanged(this, new dsSwitchgears.EventArgs135((dsSwitchgears.Class199)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vPassportShowSwitchgearsRowChanging != null)
				{
					this.vPassportShowSwitchgearsRowChanging(this, new dsSwitchgears.EventArgs135((dsSwitchgears.Class199)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vPassportShowSwitchgearsRowDeleted != null)
				{
					this.vPassportShowSwitchgearsRowDeleted(this, new dsSwitchgears.EventArgs135((dsSwitchgears.Class199)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vPassportShowSwitchgearsRowDeleting != null)
				{
					this.vPassportShowSwitchgearsRowDeleting(this, new dsSwitchgears.EventArgs135((dsSwitchgears.Class199)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5(dsSwitchgears.Class199 class199_0)
			{
				base.Rows.Remove(class199_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsSwitchgears dsSwitchgears = new dsSwitchgears();
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
				xmlSchemaAttribute.FixedValue = dsSwitchgears.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vPassportShowSwitchgearsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dsSwitchgears.GetSchemaSerializable();
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

		public class Class199 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class199(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vPassportShowSwitchgearsDataTable_0 = (dsSwitchgears.vPassportShowSwitchgearsDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.vPassportShowSwitchgearsDataTable_0.idColumn];
				}
				set
				{
					base[this.vPassportShowSwitchgearsDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.vPassportShowSwitchgearsDataTable_0.idObjListColumn];
			}

			public void method_1(int int_0)
			{
				base[this.vPassportShowSwitchgearsDataTable_0.idObjListColumn] = int_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DateTime Date
			{
				get
				{
					return (DateTime)base[this.vPassportShowSwitchgearsDataTable_0.DateColumn];
				}
				set
				{
					base[this.vPassportShowSwitchgearsDataTable_0.DateColumn] = value;
				}
			}

			public int method_2()
			{
				return (int)base[this.vPassportShowSwitchgearsDataTable_0.idCharColumn];
			}

			public void method_3(int int_0)
			{
				base[this.vPassportShowSwitchgearsDataTable_0.idCharColumn] = int_0;
			}

			public int method_4()
			{
				int result;
				try
				{
					result = (int)base[this.vPassportShowSwitchgearsDataTable_0.ParentIdCharColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentIdChar' in table 'vPassportShowSwitchgears' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(int int_0)
			{
				base[this.vPassportShowSwitchgearsDataTable_0.ParentIdCharColumn] = int_0;
			}

			public string method_6()
			{
				string result;
				try
				{
					result = (string)base[this.vPassportShowSwitchgearsDataTable_0.ParentKeyCharColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKeyChar' in table 'vPassportShowSwitchgears' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(string string_0)
			{
				base[this.vPassportShowSwitchgearsDataTable_0.ParentKeyCharColumn] = string_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					return (string)base[this.vPassportShowSwitchgearsDataTable_0.NameColumn];
				}
				set
				{
					base[this.vPassportShowSwitchgearsDataTable_0.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vPassportShowSwitchgearsDataTable_0.ValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Value' in table 'vPassportShowSwitchgears' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vPassportShowSwitchgearsDataTable_0.ValueColumn] = value;
				}
			}

			public int method_8()
			{
				int result;
				try
				{
					result = (int)base[this.vPassportShowSwitchgearsDataTable_0.TabIndexColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TabIndex' in table 'vPassportShowSwitchgears' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(int int_0)
			{
				base[this.vPassportShowSwitchgearsDataTable_0.TabIndexColumn] = int_0;
			}

			public bool method_10()
			{
				return (bool)base[this.vPassportShowSwitchgearsDataTable_0.isGroupColumn];
			}

			public void method_11(bool bool_0)
			{
				base[this.vPassportShowSwitchgearsDataTable_0.isGroupColumn] = bool_0;
			}

			public bool method_12()
			{
				return (bool)base[this.vPassportShowSwitchgearsDataTable_0.DeletedColumn];
			}

			public void method_13(bool bool_0)
			{
				base[this.vPassportShowSwitchgearsDataTable_0.DeletedColumn] = bool_0;
			}

			public bool method_14()
			{
				return (bool)base[this.vPassportShowSwitchgearsDataTable_0.isActiveColumn];
			}

			public void method_15(bool bool_0)
			{
				base[this.vPassportShowSwitchgearsDataTable_0.isActiveColumn] = bool_0;
			}

			public bool method_16()
			{
				return (bool)base[this.vPassportShowSwitchgearsDataTable_0.CharDeletedColumn];
			}

			public void method_17(bool bool_0)
			{
				base[this.vPassportShowSwitchgearsDataTable_0.CharDeletedColumn] = bool_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_18()
			{
				return base.IsNull(this.vPassportShowSwitchgearsDataTable_0.ParentIdCharColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_19()
			{
				base[this.vPassportShowSwitchgearsDataTable_0.ParentIdCharColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.vPassportShowSwitchgearsDataTable_0.ParentKeyCharColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.vPassportShowSwitchgearsDataTable_0.ParentKeyCharColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_22()
			{
				return base.IsNull(this.vPassportShowSwitchgearsDataTable_0.ValueColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_23()
			{
				base[this.vPassportShowSwitchgearsDataTable_0.ValueColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.vPassportShowSwitchgearsDataTable_0.TabIndexColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_25()
			{
				base[this.vPassportShowSwitchgearsDataTable_0.TabIndexColumn] = Convert.DBNull;
			}

			private dsSwitchgears.vPassportShowSwitchgearsDataTable vPassportShowSwitchgearsDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vP_GetSwitchgearsDataTable : TypedTableBase<dsSwitchgears.Class200>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public vP_GetSwitchgearsDataTable()
			{
				base.TableName = "vP_GetSwitchgears";
				this.BeginInit();
				this.method_3();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal vP_GetSwitchgearsDataTable(DataTable dataTable_0)
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
			protected vP_GetSwitchgearsDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
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
			public DataColumn IdParentColumn
			{
				get
				{
					return this.columnIdParent;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TypeCodeIdColumn
			{
				get
				{
					return this.columnTypeCodeId;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ParentKeyColumn
			{
				get
				{
					return this.columnParentKey;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ValueColumn
			{
				get
				{
					return this.columnValue;
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
			public dsSwitchgears.Class200 this[int int_0]
			{
				get
				{
					return (dsSwitchgears.Class200)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate136 vP_GetSwitchgearsRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate136 vP_GetSwitchgearsRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate136 vP_GetSwitchgearsRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate136 vP_GetSwitchgearsRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(dsSwitchgears.Class200 class200_0)
			{
				base.Rows.Add(class200_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSwitchgears.Class200 method_1(int int_0, int int_1, int int_2, string string_0, decimal decimal_0, string string_1)
			{
				dsSwitchgears.Class200 @class = (dsSwitchgears.Class200)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
					int_1,
					int_2,
					string_0,
					decimal_0,
					string_1
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				dsSwitchgears.vP_GetSwitchgearsDataTable vP_GetSwitchgearsDataTable = (dsSwitchgears.vP_GetSwitchgearsDataTable)base.Clone();
				vP_GetSwitchgearsDataTable.method_2();
				return vP_GetSwitchgearsDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new dsSwitchgears.vP_GetSwitchgearsDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_2()
			{
				this.columnId = base.Columns["Id"];
				this.columnIdParent = base.Columns["IdParent"];
				this.columnTypeCodeId = base.Columns["TypeCodeId"];
				this.columnParentKey = base.Columns["ParentKey"];
				this.columnValue = base.Columns["Value"];
				this.columnName = base.Columns["Name"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_3()
			{
				this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnId);
				this.columnIdParent = new DataColumn("IdParent", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnIdParent);
				this.columnTypeCodeId = new DataColumn("TypeCodeId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTypeCodeId);
				this.columnParentKey = new DataColumn("ParentKey", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParentKey);
				this.columnValue = new DataColumn("Value", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnValue);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnId
				}, false));
				this.columnId.Unique = true;
				this.columnParentKey.MaxLength = 50;
				this.columnName.MaxLength = 100;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSwitchgears.Class200 method_4()
			{
				return (dsSwitchgears.Class200)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsSwitchgears.Class200(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(dsSwitchgears.Class200);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vP_GetSwitchgearsRowChanged != null)
				{
					this.vP_GetSwitchgearsRowChanged(this, new dsSwitchgears.EventArgs136((dsSwitchgears.Class200)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vP_GetSwitchgearsRowChanging != null)
				{
					this.vP_GetSwitchgearsRowChanging(this, new dsSwitchgears.EventArgs136((dsSwitchgears.Class200)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vP_GetSwitchgearsRowDeleted != null)
				{
					this.vP_GetSwitchgearsRowDeleted(this, new dsSwitchgears.EventArgs136((dsSwitchgears.Class200)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vP_GetSwitchgearsRowDeleting != null)
				{
					this.vP_GetSwitchgearsRowDeleting(this, new dsSwitchgears.EventArgs136((dsSwitchgears.Class200)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5(dsSwitchgears.Class200 class200_0)
			{
				base.Rows.Remove(class200_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsSwitchgears dsSwitchgears = new dsSwitchgears();
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
				xmlSchemaAttribute.FixedValue = dsSwitchgears.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vP_GetSwitchgearsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dsSwitchgears.GetSchemaSerializable();
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

			private DataColumn columnId;

			private DataColumn columnIdParent;

			private DataColumn columnTypeCodeId;

			private DataColumn columnParentKey;

			private DataColumn columnValue;

			private DataColumn columnName;
		}

		public class Class200 : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Class200(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vP_GetSwitchgearsDataTable_0 = (dsSwitchgears.vP_GetSwitchgearsDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Id
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vP_GetSwitchgearsDataTable_0.IdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Id' in table 'vP_GetSwitchgears' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vP_GetSwitchgearsDataTable_0.IdColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int IdParent
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vP_GetSwitchgearsDataTable_0.IdParentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'IdParent' in table 'vP_GetSwitchgears' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vP_GetSwitchgearsDataTable_0.IdParentColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int TypeCodeId
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vP_GetSwitchgearsDataTable_0.TypeCodeIdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TypeCodeId' in table 'vP_GetSwitchgears' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vP_GetSwitchgearsDataTable_0.TypeCodeIdColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ParentKey
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vP_GetSwitchgearsDataTable_0.ParentKeyColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ParentKey' in table 'vP_GetSwitchgears' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vP_GetSwitchgearsDataTable_0.ParentKeyColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public decimal Value
			{
				get
				{
					decimal result;
					try
					{
						result = (decimal)base[this.vP_GetSwitchgearsDataTable_0.ValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Value' in table 'vP_GetSwitchgears' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vP_GetSwitchgearsDataTable_0.ValueColumn] = value;
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
						result = (string)base[this.vP_GetSwitchgearsDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'vP_GetSwitchgears' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vP_GetSwitchgearsDataTable_0.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_0()
			{
				return base.IsNull(this.vP_GetSwitchgearsDataTable_0.IdColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_1()
			{
				base[this.vP_GetSwitchgearsDataTable_0.IdColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_2()
			{
				return base.IsNull(this.vP_GetSwitchgearsDataTable_0.IdParentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_3()
			{
				base[this.vP_GetSwitchgearsDataTable_0.IdParentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_4()
			{
				return base.IsNull(this.vP_GetSwitchgearsDataTable_0.TypeCodeIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5()
			{
				base[this.vP_GetSwitchgearsDataTable_0.TypeCodeIdColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.vP_GetSwitchgearsDataTable_0.ParentKeyColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_7()
			{
				base[this.vP_GetSwitchgearsDataTable_0.ParentKeyColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_8()
			{
				return base.IsNull(this.vP_GetSwitchgearsDataTable_0.ValueColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_9()
			{
				base[this.vP_GetSwitchgearsDataTable_0.ValueColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_10()
			{
				return base.IsNull(this.vP_GetSwitchgearsDataTable_0.NameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_11()
			{
				base[this.vP_GetSwitchgearsDataTable_0.NameColumn] = Convert.DBNull;
			}

			private dsSwitchgears.vP_GetSwitchgearsDataTable vP_GetSwitchgearsDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vPassportShowBusDataTable : TypedTableBase<dsSwitchgears.Class201>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public vPassportShowBusDataTable()
			{
				base.TableName = "vPassportShowBus";
				this.BeginInit();
				this.method_3();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal vPassportShowBusDataTable(DataTable dataTable_0)
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
			protected vPassportShowBusDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_2();
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParentIdCharColumn
			{
				get
				{
					return this.columnParentIdChar;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ParentKeyCharColumn
			{
				get
				{
					return this.columnParentKeyChar;
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
			public DataColumn ValueColumn
			{
				get
				{
					return this.columnValue;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TabIndexColumn
			{
				get
				{
					return this.columnTabIndex;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn isGroupColumn
			{
				get
				{
					return this.columnisGroup;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DeletedColumn
			{
				get
				{
					return this.columnDeleted;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn isActiveColumn
			{
				get
				{
					return this.columnisActive;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CharDeletedColumn
			{
				get
				{
					return this.columnCharDeleted;
				}
			}

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dsSwitchgears.Class201 this[int int_0]
			{
				get
				{
					return (dsSwitchgears.Class201)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate137 vPassportShowBusRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate137 vPassportShowBusRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate137 vPassportShowBusRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate137 vPassportShowBusRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(dsSwitchgears.Class201 class201_0)
			{
				base.Rows.Add(class201_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSwitchgears.Class201 method_1(int int_0, int int_1, DateTime dateTime_0, int int_2, int int_3, string string_0, string string_1, string string_2, int int_4, bool bool_0, bool bool_1, bool bool_2, bool bool_3)
			{
				dsSwitchgears.Class201 @class = (dsSwitchgears.Class201)base.NewRow();
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
				dsSwitchgears.vPassportShowBusDataTable vPassportShowBusDataTable = (dsSwitchgears.vPassportShowBusDataTable)base.Clone();
				vPassportShowBusDataTable.method_2();
				return vPassportShowBusDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new dsSwitchgears.vPassportShowBusDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			public dsSwitchgears.Class201 method_4()
			{
				return (dsSwitchgears.Class201)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsSwitchgears.Class201(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(dsSwitchgears.Class201);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vPassportShowBusRowChanged != null)
				{
					this.vPassportShowBusRowChanged(this, new dsSwitchgears.EventArgs137((dsSwitchgears.Class201)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vPassportShowBusRowChanging != null)
				{
					this.vPassportShowBusRowChanging(this, new dsSwitchgears.EventArgs137((dsSwitchgears.Class201)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vPassportShowBusRowDeleted != null)
				{
					this.vPassportShowBusRowDeleted(this, new dsSwitchgears.EventArgs137((dsSwitchgears.Class201)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vPassportShowBusRowDeleting != null)
				{
					this.vPassportShowBusRowDeleting(this, new dsSwitchgears.EventArgs137((dsSwitchgears.Class201)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5(dsSwitchgears.Class201 class201_0)
			{
				base.Rows.Remove(class201_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsSwitchgears dsSwitchgears = new dsSwitchgears();
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
				xmlSchemaAttribute.FixedValue = dsSwitchgears.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vPassportShowBusDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dsSwitchgears.GetSchemaSerializable();
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

		public class Class201 : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Class201(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vPassportShowBusDataTable_0 = (dsSwitchgears.vPassportShowBusDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Int32_0
			{
				get
				{
					return (int)base[this.vPassportShowBusDataTable_0.idColumn];
				}
				set
				{
					base[this.vPassportShowBusDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.vPassportShowBusDataTable_0.idObjListColumn];
			}

			public void method_1(int int_0)
			{
				base[this.vPassportShowBusDataTable_0.idObjListColumn] = int_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DateTime Date
			{
				get
				{
					return (DateTime)base[this.vPassportShowBusDataTable_0.DateColumn];
				}
				set
				{
					base[this.vPassportShowBusDataTable_0.DateColumn] = value;
				}
			}

			public int method_2()
			{
				return (int)base[this.vPassportShowBusDataTable_0.idCharColumn];
			}

			public void method_3(int int_0)
			{
				base[this.vPassportShowBusDataTable_0.idCharColumn] = int_0;
			}

			public int method_4()
			{
				int result;
				try
				{
					result = (int)base[this.vPassportShowBusDataTable_0.ParentIdCharColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentIdChar' in table 'vPassportShowBus' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(int int_0)
			{
				base[this.vPassportShowBusDataTable_0.ParentIdCharColumn] = int_0;
			}

			public string method_6()
			{
				string result;
				try
				{
					result = (string)base[this.vPassportShowBusDataTable_0.ParentKeyCharColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKeyChar' in table 'vPassportShowBus' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(string string_0)
			{
				base[this.vPassportShowBusDataTable_0.ParentKeyCharColumn] = string_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Name
			{
				get
				{
					return (string)base[this.vPassportShowBusDataTable_0.NameColumn];
				}
				set
				{
					base[this.vPassportShowBusDataTable_0.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vPassportShowBusDataTable_0.ValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Value' in table 'vPassportShowBus' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vPassportShowBusDataTable_0.ValueColumn] = value;
				}
			}

			public int method_8()
			{
				int result;
				try
				{
					result = (int)base[this.vPassportShowBusDataTable_0.TabIndexColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TabIndex' in table 'vPassportShowBus' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(int int_0)
			{
				base[this.vPassportShowBusDataTable_0.TabIndexColumn] = int_0;
			}

			public bool method_10()
			{
				return (bool)base[this.vPassportShowBusDataTable_0.isGroupColumn];
			}

			public void method_11(bool bool_0)
			{
				base[this.vPassportShowBusDataTable_0.isGroupColumn] = bool_0;
			}

			public bool method_12()
			{
				return (bool)base[this.vPassportShowBusDataTable_0.DeletedColumn];
			}

			public void method_13(bool bool_0)
			{
				base[this.vPassportShowBusDataTable_0.DeletedColumn] = bool_0;
			}

			public bool method_14()
			{
				return (bool)base[this.vPassportShowBusDataTable_0.isActiveColumn];
			}

			public void method_15(bool bool_0)
			{
				base[this.vPassportShowBusDataTable_0.isActiveColumn] = bool_0;
			}

			public bool method_16()
			{
				return (bool)base[this.vPassportShowBusDataTable_0.CharDeletedColumn];
			}

			public void method_17(bool bool_0)
			{
				base[this.vPassportShowBusDataTable_0.CharDeletedColumn] = bool_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_18()
			{
				return base.IsNull(this.vPassportShowBusDataTable_0.ParentIdCharColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.vPassportShowBusDataTable_0.ParentIdCharColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.vPassportShowBusDataTable_0.ParentKeyCharColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_21()
			{
				base[this.vPassportShowBusDataTable_0.ParentKeyCharColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_22()
			{
				return base.IsNull(this.vPassportShowBusDataTable_0.ValueColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_23()
			{
				base[this.vPassportShowBusDataTable_0.ValueColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.vPassportShowBusDataTable_0.TabIndexColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.vPassportShowBusDataTable_0.TabIndexColumn] = Convert.DBNull;
			}

			private dsSwitchgears.vPassportShowBusDataTable vPassportShowBusDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vPassportShowCellsDataTable : TypedTableBase<dsSwitchgears.Class202>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public vPassportShowCellsDataTable()
			{
				base.TableName = "vPassportShowCells";
				this.BeginInit();
				this.method_3();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal vPassportShowCellsDataTable(DataTable dataTable_0)
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
			protected vPassportShowCellsDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_2();
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ParentKeyCharColumn
			{
				get
				{
					return this.columnParentKeyChar;
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
			public DataColumn ValueColumn
			{
				get
				{
					return this.columnValue;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TabIndexColumn
			{
				get
				{
					return this.columnTabIndex;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn isActiveColumn
			{
				get
				{
					return this.columnisActive;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CharDeletedColumn
			{
				get
				{
					return this.columnCharDeleted;
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
			public dsSwitchgears.Class202 this[int int_0]
			{
				get
				{
					return (dsSwitchgears.Class202)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate138 vPassportShowCellsRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate138 vPassportShowCellsRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate138 vPassportShowCellsRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate138 vPassportShowCellsRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(dsSwitchgears.Class202 class202_0)
			{
				base.Rows.Add(class202_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dsSwitchgears.Class202 method_1(int int_0, int int_1, DateTime dateTime_0, int int_2, int int_3, string string_0, string string_1, string string_2, int int_4, bool bool_0, bool bool_1, bool bool_2, bool bool_3)
			{
				dsSwitchgears.Class202 @class = (dsSwitchgears.Class202)base.NewRow();
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
				dsSwitchgears.vPassportShowCellsDataTable vPassportShowCellsDataTable = (dsSwitchgears.vPassportShowCellsDataTable)base.Clone();
				vPassportShowCellsDataTable.method_2();
				return vPassportShowCellsDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new dsSwitchgears.vPassportShowCellsDataTable();
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			public dsSwitchgears.Class202 method_4()
			{
				return (dsSwitchgears.Class202)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsSwitchgears.Class202(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(dsSwitchgears.Class202);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vPassportShowCellsRowChanged != null)
				{
					this.vPassportShowCellsRowChanged(this, new dsSwitchgears.EventArgs138((dsSwitchgears.Class202)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vPassportShowCellsRowChanging != null)
				{
					this.vPassportShowCellsRowChanging(this, new dsSwitchgears.EventArgs138((dsSwitchgears.Class202)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vPassportShowCellsRowDeleted != null)
				{
					this.vPassportShowCellsRowDeleted(this, new dsSwitchgears.EventArgs138((dsSwitchgears.Class202)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vPassportShowCellsRowDeleting != null)
				{
					this.vPassportShowCellsRowDeleting(this, new dsSwitchgears.EventArgs138((dsSwitchgears.Class202)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5(dsSwitchgears.Class202 class202_0)
			{
				base.Rows.Remove(class202_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsSwitchgears dsSwitchgears = new dsSwitchgears();
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
				xmlSchemaAttribute.FixedValue = dsSwitchgears.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vPassportShowCellsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dsSwitchgears.GetSchemaSerializable();
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

		public class Class202 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class202(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vPassportShowCellsDataTable_0 = (dsSwitchgears.vPassportShowCellsDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Int32_0
			{
				get
				{
					return (int)base[this.vPassportShowCellsDataTable_0.idColumn];
				}
				set
				{
					base[this.vPassportShowCellsDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.vPassportShowCellsDataTable_0.idObjListColumn];
			}

			public void method_1(int int_0)
			{
				base[this.vPassportShowCellsDataTable_0.idObjListColumn] = int_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime Date
			{
				get
				{
					return (DateTime)base[this.vPassportShowCellsDataTable_0.DateColumn];
				}
				set
				{
					base[this.vPassportShowCellsDataTable_0.DateColumn] = value;
				}
			}

			public int method_2()
			{
				return (int)base[this.vPassportShowCellsDataTable_0.idCharColumn];
			}

			public void method_3(int int_0)
			{
				base[this.vPassportShowCellsDataTable_0.idCharColumn] = int_0;
			}

			public int method_4()
			{
				int result;
				try
				{
					result = (int)base[this.vPassportShowCellsDataTable_0.ParentIdCharColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentIdChar' in table 'vPassportShowCells' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(int int_0)
			{
				base[this.vPassportShowCellsDataTable_0.ParentIdCharColumn] = int_0;
			}

			public string method_6()
			{
				string result;
				try
				{
					result = (string)base[this.vPassportShowCellsDataTable_0.ParentKeyCharColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKeyChar' in table 'vPassportShowCells' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(string string_0)
			{
				base[this.vPassportShowCellsDataTable_0.ParentKeyCharColumn] = string_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Name
			{
				get
				{
					return (string)base[this.vPassportShowCellsDataTable_0.NameColumn];
				}
				set
				{
					base[this.vPassportShowCellsDataTable_0.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vPassportShowCellsDataTable_0.ValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Value' in table 'vPassportShowCells' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vPassportShowCellsDataTable_0.ValueColumn] = value;
				}
			}

			public int method_8()
			{
				int result;
				try
				{
					result = (int)base[this.vPassportShowCellsDataTable_0.TabIndexColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TabIndex' in table 'vPassportShowCells' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(int int_0)
			{
				base[this.vPassportShowCellsDataTable_0.TabIndexColumn] = int_0;
			}

			public bool method_10()
			{
				return (bool)base[this.vPassportShowCellsDataTable_0.isGroupColumn];
			}

			public void method_11(bool bool_0)
			{
				base[this.vPassportShowCellsDataTable_0.isGroupColumn] = bool_0;
			}

			public bool method_12()
			{
				return (bool)base[this.vPassportShowCellsDataTable_0.DeletedColumn];
			}

			public void method_13(bool bool_0)
			{
				base[this.vPassportShowCellsDataTable_0.DeletedColumn] = bool_0;
			}

			public bool method_14()
			{
				return (bool)base[this.vPassportShowCellsDataTable_0.isActiveColumn];
			}

			public void method_15(bool bool_0)
			{
				base[this.vPassportShowCellsDataTable_0.isActiveColumn] = bool_0;
			}

			public bool method_16()
			{
				return (bool)base[this.vPassportShowCellsDataTable_0.CharDeletedColumn];
			}

			public void method_17(bool bool_0)
			{
				base[this.vPassportShowCellsDataTable_0.CharDeletedColumn] = bool_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_18()
			{
				return base.IsNull(this.vPassportShowCellsDataTable_0.ParentIdCharColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_19()
			{
				base[this.vPassportShowCellsDataTable_0.ParentIdCharColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_20()
			{
				return base.IsNull(this.vPassportShowCellsDataTable_0.ParentKeyCharColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.vPassportShowCellsDataTable_0.ParentKeyCharColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_22()
			{
				return base.IsNull(this.vPassportShowCellsDataTable_0.ValueColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_23()
			{
				base[this.vPassportShowCellsDataTable_0.ValueColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.vPassportShowCellsDataTable_0.TabIndexColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.vPassportShowCellsDataTable_0.TabIndexColumn] = Convert.DBNull;
			}

			private dsSwitchgears.vPassportShowCellsDataTable vPassportShowCellsDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vPassportShowSwitchesDataTable : TypedTableBase<dsSwitchgears.Class203>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public vPassportShowSwitchesDataTable()
			{
				base.TableName = "vPassportShowSwitches";
				this.BeginInit();
				this.method_3();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal vPassportShowSwitchesDataTable(DataTable dataTable_0)
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
			protected vPassportShowSwitchesDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_2();
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsSwitchgears.Class203 this[int int_0]
			{
				get
				{
					return (dsSwitchgears.Class203)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate139 vPassportShowSwitchesRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate139 vPassportShowSwitchesRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate139 vPassportShowSwitchesRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event dsSwitchgears.Delegate139 vPassportShowSwitchesRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(dsSwitchgears.Class203 class203_0)
			{
				base.Rows.Add(class203_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dsSwitchgears.Class203 method_1(int int_0, int int_1, DateTime dateTime_0, int int_2, int int_3, string string_0, string string_1, string string_2, int int_4, bool bool_0, bool bool_1, bool bool_2, bool bool_3)
			{
				dsSwitchgears.Class203 @class = (dsSwitchgears.Class203)base.NewRow();
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
				dsSwitchgears.vPassportShowSwitchesDataTable vPassportShowSwitchesDataTable = (dsSwitchgears.vPassportShowSwitchesDataTable)base.Clone();
				vPassportShowSwitchesDataTable.method_2();
				return vPassportShowSwitchesDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new dsSwitchgears.vPassportShowSwitchesDataTable();
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
			public dsSwitchgears.Class203 method_4()
			{
				return (dsSwitchgears.Class203)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new dsSwitchgears.Class203(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(dsSwitchgears.Class203);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vPassportShowSwitchesRowChanged != null)
				{
					this.vPassportShowSwitchesRowChanged(this, new dsSwitchgears.EventArgs139((dsSwitchgears.Class203)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vPassportShowSwitchesRowChanging != null)
				{
					this.vPassportShowSwitchesRowChanging(this, new dsSwitchgears.EventArgs139((dsSwitchgears.Class203)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vPassportShowSwitchesRowDeleted != null)
				{
					this.vPassportShowSwitchesRowDeleted(this, new dsSwitchgears.EventArgs139((dsSwitchgears.Class203)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vPassportShowSwitchesRowDeleting != null)
				{
					this.vPassportShowSwitchesRowDeleting(this, new dsSwitchgears.EventArgs139((dsSwitchgears.Class203)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5(dsSwitchgears.Class203 class203_0)
			{
				base.Rows.Remove(class203_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				dsSwitchgears dsSwitchgears = new dsSwitchgears();
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
				xmlSchemaAttribute.FixedValue = dsSwitchgears.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vPassportShowSwitchesDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dsSwitchgears.GetSchemaSerializable();
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

		public class Class203 : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Class203(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vPassportShowSwitchesDataTable_0 = (dsSwitchgears.vPassportShowSwitchesDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Int32_0
			{
				get
				{
					return (int)base[this.vPassportShowSwitchesDataTable_0.idColumn];
				}
				set
				{
					base[this.vPassportShowSwitchesDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.vPassportShowSwitchesDataTable_0.idObjListColumn];
			}

			public void method_1(int int_0)
			{
				base[this.vPassportShowSwitchesDataTable_0.idObjListColumn] = int_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DateTime Date
			{
				get
				{
					return (DateTime)base[this.vPassportShowSwitchesDataTable_0.DateColumn];
				}
				set
				{
					base[this.vPassportShowSwitchesDataTable_0.DateColumn] = value;
				}
			}

			public int method_2()
			{
				return (int)base[this.vPassportShowSwitchesDataTable_0.idCharColumn];
			}

			public void method_3(int int_0)
			{
				base[this.vPassportShowSwitchesDataTable_0.idCharColumn] = int_0;
			}

			public int method_4()
			{
				int result;
				try
				{
					result = (int)base[this.vPassportShowSwitchesDataTable_0.ParentIdCharColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentIdChar' in table 'vPassportShowSwitches' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(int int_0)
			{
				base[this.vPassportShowSwitchesDataTable_0.ParentIdCharColumn] = int_0;
			}

			public string method_6()
			{
				string result;
				try
				{
					result = (string)base[this.vPassportShowSwitchesDataTable_0.ParentKeyCharColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKeyChar' in table 'vPassportShowSwitches' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(string string_0)
			{
				base[this.vPassportShowSwitchesDataTable_0.ParentKeyCharColumn] = string_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					return (string)base[this.vPassportShowSwitchesDataTable_0.NameColumn];
				}
				set
				{
					base[this.vPassportShowSwitchesDataTable_0.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vPassportShowSwitchesDataTable_0.ValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Value' in table 'vPassportShowSwitches' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vPassportShowSwitchesDataTable_0.ValueColumn] = value;
				}
			}

			public int method_8()
			{
				int result;
				try
				{
					result = (int)base[this.vPassportShowSwitchesDataTable_0.TabIndexColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TabIndex' in table 'vPassportShowSwitches' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(int int_0)
			{
				base[this.vPassportShowSwitchesDataTable_0.TabIndexColumn] = int_0;
			}

			public bool method_10()
			{
				return (bool)base[this.vPassportShowSwitchesDataTable_0.isGroupColumn];
			}

			public void method_11(bool bool_0)
			{
				base[this.vPassportShowSwitchesDataTable_0.isGroupColumn] = bool_0;
			}

			public bool method_12()
			{
				return (bool)base[this.vPassportShowSwitchesDataTable_0.DeletedColumn];
			}

			public void method_13(bool bool_0)
			{
				base[this.vPassportShowSwitchesDataTable_0.DeletedColumn] = bool_0;
			}

			public bool method_14()
			{
				return (bool)base[this.vPassportShowSwitchesDataTable_0.isActiveColumn];
			}

			public void method_15(bool bool_0)
			{
				base[this.vPassportShowSwitchesDataTable_0.isActiveColumn] = bool_0;
			}

			public bool method_16()
			{
				return (bool)base[this.vPassportShowSwitchesDataTable_0.CharDeletedColumn];
			}

			public void method_17(bool bool_0)
			{
				base[this.vPassportShowSwitchesDataTable_0.CharDeletedColumn] = bool_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_18()
			{
				return base.IsNull(this.vPassportShowSwitchesDataTable_0.ParentIdCharColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.vPassportShowSwitchesDataTable_0.ParentIdCharColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_20()
			{
				return base.IsNull(this.vPassportShowSwitchesDataTable_0.ParentKeyCharColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.vPassportShowSwitchesDataTable_0.ParentKeyCharColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_22()
			{
				return base.IsNull(this.vPassportShowSwitchesDataTable_0.ValueColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_23()
			{
				base[this.vPassportShowSwitchesDataTable_0.ValueColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.vPassportShowSwitchesDataTable_0.TabIndexColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.vPassportShowSwitchesDataTable_0.TabIndexColumn] = Convert.DBNull;
			}

			private dsSwitchgears.vPassportShowSwitchesDataTable vPassportShowSwitchesDataTable_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs135 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs135(dsSwitchgears.Class199 class199_1, DataRowAction dataRowAction_1)
			{
				this.class199_0 = class199_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public dsSwitchgears.Class199 method_0()
			{
				return this.class199_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private dsSwitchgears.Class199 class199_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs136 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs136(dsSwitchgears.Class200 class200_1, DataRowAction dataRowAction_1)
			{
				this.class200_0 = class200_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public dsSwitchgears.Class200 method_0()
			{
				return this.class200_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private dsSwitchgears.Class200 class200_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs137 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs137(dsSwitchgears.Class201 class201_1, DataRowAction dataRowAction_1)
			{
				this.class201_0 = class201_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public dsSwitchgears.Class201 method_0()
			{
				return this.class201_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private dsSwitchgears.Class201 class201_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs138 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs138(dsSwitchgears.Class202 class202_1, DataRowAction dataRowAction_1)
			{
				this.class202_0 = class202_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public dsSwitchgears.Class202 method_0()
			{
				return this.class202_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private dsSwitchgears.Class202 class202_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs139 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs139(dsSwitchgears.Class203 class203_1, DataRowAction dataRowAction_1)
			{
				this.class203_0 = class203_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public dsSwitchgears.Class203 method_0()
			{
				return this.class203_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private dsSwitchgears.Class203 class203_0;

			private DataRowAction dataRowAction_0;
		}
	}
}
