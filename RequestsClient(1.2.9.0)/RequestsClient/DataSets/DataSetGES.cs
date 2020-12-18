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

namespace RequestsClient.DataSets
{
	// Token: 0x02000047 RID: 71
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[HelpKeyword("vs.data.DataSet")]
	[ToolboxItem(true)]
	[DesignerCategory("code")]
	[XmlRoot("DataSetGES")]
	[Serializable]
	internal class DataSetGES : DataSet
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x0001B924 File Offset: 0x00019B24
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetGES()
		{
			base.BeginInit();
			this.o();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.a);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0001B978 File Offset: 0x00019B78
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected DataSetGES(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1, false)
		{
			if (base.IsBinarySerialized(A_0, A_1))
			{
				this.a(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.a);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
				return;
			}
			string s = (string)A_0.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(A_0, A_1) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["tR_Classifier"] != null)
				{
					base.Tables.Add(new DataSetGES.tR_ClassifierDataTable(dataSet.Tables["tR_Classifier"]));
				}
				if (dataSet.Tables["vSchm_ObjList"] != null)
				{
					base.Tables.Add(new DataSetGES.vSchm_ObjListDataTable(dataSet.Tables["vSchm_ObjList"]));
				}
				if (dataSet.Tables["vSchm_TreeCellLine"] != null)
				{
					base.Tables.Add(new DataSetGES.vSchm_TreeCellLineDataTable(dataSet.Tables["vSchm_TreeCellLine"]));
				}
				if (dataSet.Tables["tSchm_Relation"] != null)
				{
					base.Tables.Add(new DataSetGES.tSchm_RelationDataTable(dataSet.Tables["tSchm_Relation"]));
				}
				if (dataSet.Tables["tL_RequestForRepairSchmObjList"] != null)
				{
					base.Tables.Add(new DataSetGES.tL_RequestForRepairSchmObjListDataTable(dataSet.Tables["tL_RequestForRepairSchmObjList"]));
				}
				if (dataSet.Tables["tJ_RequestForRepair"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_RequestForRepairDataTable(dataSet.Tables["tJ_RequestForRepair"]));
				}
				if (dataSet.Tables["tJ_RequestForRepairDaily"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_RequestForRepairDailyDataTable(dataSet.Tables["tJ_RequestForRepairDaily"]));
				}
				if (dataSet.Tables["tJ_RequestForRepairDoc"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_RequestForRepairDocDataTable(dataSet.Tables["tJ_RequestForRepairDoc"]));
				}
				if (dataSet.Tables["tR_RequestForRepairClient"] != null)
				{
					base.Tables.Add(new DataSetGES.tR_RequestForRepairClientDataTable(dataSet.Tables["tR_RequestForRepairClient"]));
				}
				if (dataSet.Tables["tJ_RequestForRepairAddress"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_RequestForRepairAddressDataTable(dataSet.Tables["tJ_RequestForRepairAddress"]));
				}
				if (dataSet.Tables["tJ_Damage"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_DamageDataTable(dataSet.Tables["tJ_Damage"]));
				}
				if (dataSet.Tables["tJ_DamageHV"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_DamageHVDataTable(dataSet.Tables["tJ_DamageHV"]));
				}
				if (dataSet.Tables["tJ_DamageLV"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_DamageLVDataTable(dataSet.Tables["tJ_DamageLV"]));
				}
				if (dataSet.Tables["tJ_RequestForRepairLog"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_RequestForRepairLogDataTable(dataSet.Tables["tJ_RequestForRepairLog"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.af();
			}
			else
			{
				base.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			}
			base.GetSerializationData(A_0, A_1);
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.a);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0001BD5F File Offset: 0x00019F5F
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public DataSetGES.tR_ClassifierDataTable tR_Classifier
		{
			get
			{
				return this.tabletR_Classifier;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0001BD67 File Offset: 0x00019F67
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetGES.vSchm_ObjListDataTable vSchm_ObjList
		{
			get
			{
				return this.tablevSchm_ObjList;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0001BD6F File Offset: 0x00019F6F
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public DataSetGES.vSchm_TreeCellLineDataTable vSchm_TreeCellLine
		{
			get
			{
				return this.tablevSchm_TreeCellLine;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0001BD77 File Offset: 0x00019F77
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetGES.tSchm_RelationDataTable tSchm_Relation
		{
			get
			{
				return this.tabletSchm_Relation;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0001BD7F File Offset: 0x00019F7F
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetGES.tL_RequestForRepairSchmObjListDataTable tL_RequestForRepairSchmObjList
		{
			get
			{
				return this.tabletL_RequestForRepairSchmObjList;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0001BD87 File Offset: 0x00019F87
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetGES.tJ_RequestForRepairDataTable tJ_RequestForRepair
		{
			get
			{
				return this.tabletJ_RequestForRepair;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0001BD8F File Offset: 0x00019F8F
		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetGES.tJ_RequestForRepairDailyDataTable tJ_RequestForRepairDaily
		{
			get
			{
				return this.tabletJ_RequestForRepairDaily;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0001BD97 File Offset: 0x00019F97
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public DataSetGES.tJ_RequestForRepairDocDataTable tJ_RequestForRepairDoc
		{
			get
			{
				return this.tabletJ_RequestForRepairDoc;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0001BD9F File Offset: 0x00019F9F
		[DebuggerNonUserCode]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetGES.tR_RequestForRepairClientDataTable tR_RequestForRepairClient
		{
			get
			{
				return this.tabletR_RequestForRepairClient;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0001BDA7 File Offset: 0x00019FA7
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetGES.tJ_RequestForRepairAddressDataTable tJ_RequestForRepairAddress
		{
			get
			{
				return this.tabletJ_RequestForRepairAddress;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0001BDAF File Offset: 0x00019FAF
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetGES.tJ_DamageDataTable tJ_Damage
		{
			get
			{
				return this.tabletJ_Damage;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0001BDB7 File Offset: 0x00019FB7
		[DebuggerNonUserCode]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetGES.tJ_DamageHVDataTable tJ_DamageHV
		{
			get
			{
				return this.tabletJ_DamageHV;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0001BDBF File Offset: 0x00019FBF
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public DataSetGES.tJ_DamageLVDataTable tJ_DamageLV
		{
			get
			{
				return this.tabletJ_DamageLV;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0001BDC7 File Offset: 0x00019FC7
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public DataSetGES.tJ_RequestForRepairLogDataTable tJ_RequestForRepairLog
		{
			get
			{
				return this.tabletJ_RequestForRepairLog;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0001BDCF File Offset: 0x00019FCF
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0001BDD7 File Offset: 0x00019FD7
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(true)]
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0001BDE0 File Offset: 0x00019FE0
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

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0001BDE8 File Offset: 0x00019FE8
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

		// Token: 0x060001E7 RID: 487 RVA: 0x0001BDF0 File Offset: 0x00019FF0
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.o();
			base.EndInit();
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0001BE04 File Offset: 0x0001A004
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataSet Clone()
		{
			DataSetGES dataSetGES = (DataSetGES)base.Clone();
			dataSetGES.af();
			dataSetGES.SchemaSerializationMode = this.SchemaSerializationMode;
			return dataSetGES;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0001BE23 File Offset: 0x0001A023
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0001BE26 File Offset: 0x0001A026
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0001BE2C File Offset: 0x0001A02C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["tR_Classifier"] != null)
				{
					base.Tables.Add(new DataSetGES.tR_ClassifierDataTable(dataSet.Tables["tR_Classifier"]));
				}
				if (dataSet.Tables["vSchm_ObjList"] != null)
				{
					base.Tables.Add(new DataSetGES.vSchm_ObjListDataTable(dataSet.Tables["vSchm_ObjList"]));
				}
				if (dataSet.Tables["vSchm_TreeCellLine"] != null)
				{
					base.Tables.Add(new DataSetGES.vSchm_TreeCellLineDataTable(dataSet.Tables["vSchm_TreeCellLine"]));
				}
				if (dataSet.Tables["tSchm_Relation"] != null)
				{
					base.Tables.Add(new DataSetGES.tSchm_RelationDataTable(dataSet.Tables["tSchm_Relation"]));
				}
				if (dataSet.Tables["tL_RequestForRepairSchmObjList"] != null)
				{
					base.Tables.Add(new DataSetGES.tL_RequestForRepairSchmObjListDataTable(dataSet.Tables["tL_RequestForRepairSchmObjList"]));
				}
				if (dataSet.Tables["tJ_RequestForRepair"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_RequestForRepairDataTable(dataSet.Tables["tJ_RequestForRepair"]));
				}
				if (dataSet.Tables["tJ_RequestForRepairDaily"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_RequestForRepairDailyDataTable(dataSet.Tables["tJ_RequestForRepairDaily"]));
				}
				if (dataSet.Tables["tJ_RequestForRepairDoc"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_RequestForRepairDocDataTable(dataSet.Tables["tJ_RequestForRepairDoc"]));
				}
				if (dataSet.Tables["tR_RequestForRepairClient"] != null)
				{
					base.Tables.Add(new DataSetGES.tR_RequestForRepairClientDataTable(dataSet.Tables["tR_RequestForRepairClient"]));
				}
				if (dataSet.Tables["tJ_RequestForRepairAddress"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_RequestForRepairAddressDataTable(dataSet.Tables["tJ_RequestForRepairAddress"]));
				}
				if (dataSet.Tables["tJ_Damage"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_DamageDataTable(dataSet.Tables["tJ_Damage"]));
				}
				if (dataSet.Tables["tJ_DamageHV"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_DamageHVDataTable(dataSet.Tables["tJ_DamageHV"]));
				}
				if (dataSet.Tables["tJ_DamageLV"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_DamageLVDataTable(dataSet.Tables["tJ_DamageLV"]));
				}
				if (dataSet.Tables["tJ_RequestForRepairLog"] != null)
				{
					base.Tables.Add(new DataSetGES.tJ_RequestForRepairLogDataTable(dataSet.Tables["tJ_RequestForRepairLog"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.af();
				return;
			}
			base.ReadXml(reader);
			this.af();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0001C17C File Offset: 0x0001A37C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0001C1B0 File Offset: 0x0001A3B0
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void af()
		{
			this.a(true);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0001C1BC File Offset: 0x0001A3BC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void a(bool A_0)
		{
			this.tabletR_Classifier = (DataSetGES.tR_ClassifierDataTable)base.Tables["tR_Classifier"];
			if (A_0 && this.tabletR_Classifier != null)
			{
				this.tabletR_Classifier.m();
			}
			this.tablevSchm_ObjList = (DataSetGES.vSchm_ObjListDataTable)base.Tables["vSchm_ObjList"];
			if (A_0 && this.tablevSchm_ObjList != null)
			{
				this.tablevSchm_ObjList.l();
			}
			this.tablevSchm_TreeCellLine = (DataSetGES.vSchm_TreeCellLineDataTable)base.Tables["vSchm_TreeCellLine"];
			if (A_0 && this.tablevSchm_TreeCellLine != null)
			{
				this.tablevSchm_TreeCellLine.i();
			}
			this.tabletSchm_Relation = (DataSetGES.tSchm_RelationDataTable)base.Tables["tSchm_Relation"];
			if (A_0 && this.tabletSchm_Relation != null)
			{
				this.tabletSchm_Relation.g();
			}
			this.tabletL_RequestForRepairSchmObjList = (DataSetGES.tL_RequestForRepairSchmObjListDataTable)base.Tables["tL_RequestForRepairSchmObjList"];
			if (A_0 && this.tabletL_RequestForRepairSchmObjList != null)
			{
				this.tabletL_RequestForRepairSchmObjList.j();
			}
			this.tabletJ_RequestForRepair = (DataSetGES.tJ_RequestForRepairDataTable)base.Tables["tJ_RequestForRepair"];
			if (A_0 && this.tabletJ_RequestForRepair != null)
			{
				this.tabletJ_RequestForRepair.ai();
			}
			this.tabletJ_RequestForRepairDaily = (DataSetGES.tJ_RequestForRepairDailyDataTable)base.Tables["tJ_RequestForRepairDaily"];
			if (A_0 && this.tabletJ_RequestForRepairDaily != null)
			{
				this.tabletJ_RequestForRepairDaily.g();
			}
			this.tabletJ_RequestForRepairDoc = (DataSetGES.tJ_RequestForRepairDocDataTable)base.Tables["tJ_RequestForRepairDoc"];
			if (A_0 && this.tabletJ_RequestForRepairDoc != null)
			{
				this.tabletJ_RequestForRepairDoc.h();
			}
			this.tabletR_RequestForRepairClient = (DataSetGES.tR_RequestForRepairClientDataTable)base.Tables["tR_RequestForRepairClient"];
			if (A_0 && this.tabletR_RequestForRepairClient != null)
			{
				this.tabletR_RequestForRepairClient.j();
			}
			this.tabletJ_RequestForRepairAddress = (DataSetGES.tJ_RequestForRepairAddressDataTable)base.Tables["tJ_RequestForRepairAddress"];
			if (A_0 && this.tabletJ_RequestForRepairAddress != null)
			{
				this.tabletJ_RequestForRepairAddress.i();
			}
			this.tabletJ_Damage = (DataSetGES.tJ_DamageDataTable)base.Tables["tJ_Damage"];
			if (A_0 && this.tabletJ_Damage != null)
			{
				this.tabletJ_Damage.ai();
			}
			this.tabletJ_DamageHV = (DataSetGES.tJ_DamageHVDataTable)base.Tables["tJ_DamageHV"];
			if (A_0 && this.tabletJ_DamageHV != null)
			{
				this.tabletJ_DamageHV.q();
			}
			this.tabletJ_DamageLV = (DataSetGES.tJ_DamageLVDataTable)base.Tables["tJ_DamageLV"];
			if (A_0 && this.tabletJ_DamageLV != null)
			{
				this.tabletJ_DamageLV.h();
			}
			this.tabletJ_RequestForRepairLog = (DataSetGES.tJ_RequestForRepairLogDataTable)base.Tables["tJ_RequestForRepairLog"];
			if (A_0 && this.tabletJ_RequestForRepairLog != null)
			{
				this.tabletJ_RequestForRepairLog.l();
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0001C478 File Offset: 0x0001A678
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void o()
		{
			base.DataSetName = "DataSetGES";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/DataSetGES.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tabletR_Classifier = new DataSetGES.tR_ClassifierDataTable();
			base.Tables.Add(this.tabletR_Classifier);
			this.tablevSchm_ObjList = new DataSetGES.vSchm_ObjListDataTable();
			base.Tables.Add(this.tablevSchm_ObjList);
			this.tablevSchm_TreeCellLine = new DataSetGES.vSchm_TreeCellLineDataTable();
			base.Tables.Add(this.tablevSchm_TreeCellLine);
			this.tabletSchm_Relation = new DataSetGES.tSchm_RelationDataTable();
			base.Tables.Add(this.tabletSchm_Relation);
			this.tabletL_RequestForRepairSchmObjList = new DataSetGES.tL_RequestForRepairSchmObjListDataTable();
			base.Tables.Add(this.tabletL_RequestForRepairSchmObjList);
			this.tabletJ_RequestForRepair = new DataSetGES.tJ_RequestForRepairDataTable();
			base.Tables.Add(this.tabletJ_RequestForRepair);
			this.tabletJ_RequestForRepairDaily = new DataSetGES.tJ_RequestForRepairDailyDataTable();
			base.Tables.Add(this.tabletJ_RequestForRepairDaily);
			this.tabletJ_RequestForRepairDoc = new DataSetGES.tJ_RequestForRepairDocDataTable();
			base.Tables.Add(this.tabletJ_RequestForRepairDoc);
			this.tabletR_RequestForRepairClient = new DataSetGES.tR_RequestForRepairClientDataTable();
			base.Tables.Add(this.tabletR_RequestForRepairClient);
			this.tabletJ_RequestForRepairAddress = new DataSetGES.tJ_RequestForRepairAddressDataTable();
			base.Tables.Add(this.tabletJ_RequestForRepairAddress);
			this.tabletJ_Damage = new DataSetGES.tJ_DamageDataTable();
			base.Tables.Add(this.tabletJ_Damage);
			this.tabletJ_DamageHV = new DataSetGES.tJ_DamageHVDataTable();
			base.Tables.Add(this.tabletJ_DamageHV);
			this.tabletJ_DamageLV = new DataSetGES.tJ_DamageLVDataTable();
			base.Tables.Add(this.tabletJ_DamageLV);
			this.tabletJ_RequestForRepairLog = new DataSetGES.tJ_RequestForRepairLogDataTable();
			base.Tables.Add(this.tabletJ_RequestForRepairLog);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0001C63C File Offset: 0x0001A83C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool n()
		{
			return false;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0001C63F File Offset: 0x0001A83F
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool m()
		{
			return false;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0001C642 File Offset: 0x0001A842
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool l()
		{
			return false;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0001C645 File Offset: 0x0001A845
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool k()
		{
			return false;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0001C648 File Offset: 0x0001A848
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool j()
		{
			return false;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0001C64B File Offset: 0x0001A84B
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool i()
		{
			return false;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0001C64E File Offset: 0x0001A84E
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool h()
		{
			return false;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0001C651 File Offset: 0x0001A851
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool g()
		{
			return false;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0001C654 File Offset: 0x0001A854
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool f()
		{
			return false;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0001C657 File Offset: 0x0001A857
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool e()
		{
			return false;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0001C65A File Offset: 0x0001A85A
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool d()
		{
			return false;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0001C65D File Offset: 0x0001A85D
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool c()
		{
			return false;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0001C660 File Offset: 0x0001A860
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool b()
		{
			return false;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001C663 File Offset: 0x0001A863
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool a()
		{
			return false;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0001C666 File Offset: 0x0001A866
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void a(object A_0, CollectionChangeEventArgs A_1)
		{
			if (A_1.Action == CollectionChangeAction.Remove)
			{
				this.af();
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0001C678 File Offset: 0x0001A878
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType a(XmlSchemaSet A_0)
		{
			DataSetGES dataSetGES = new DataSetGES();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dataSetGES.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
			if (A_0.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
					{
						XmlSchema xmlSchema = (XmlSchema)obj;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
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
			}
			A_0.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}

		// Token: 0x04000204 RID: 516
		private DataSetGES.tR_ClassifierDataTable tabletR_Classifier;

		// Token: 0x04000205 RID: 517
		private DataSetGES.vSchm_ObjListDataTable tablevSchm_ObjList;

		// Token: 0x04000206 RID: 518
		private DataSetGES.vSchm_TreeCellLineDataTable tablevSchm_TreeCellLine;

		// Token: 0x04000207 RID: 519
		private DataSetGES.tSchm_RelationDataTable tabletSchm_Relation;

		// Token: 0x04000208 RID: 520
		private DataSetGES.tL_RequestForRepairSchmObjListDataTable tabletL_RequestForRepairSchmObjList;

		// Token: 0x04000209 RID: 521
		private DataSetGES.tJ_RequestForRepairDataTable tabletJ_RequestForRepair;

		// Token: 0x0400020A RID: 522
		private DataSetGES.tJ_RequestForRepairDailyDataTable tabletJ_RequestForRepairDaily;

		// Token: 0x0400020B RID: 523
		private DataSetGES.tJ_RequestForRepairDocDataTable tabletJ_RequestForRepairDoc;

		// Token: 0x0400020C RID: 524
		private DataSetGES.tR_RequestForRepairClientDataTable tabletR_RequestForRepairClient;

		// Token: 0x0400020D RID: 525
		private DataSetGES.tJ_RequestForRepairAddressDataTable tabletJ_RequestForRepairAddress;

		// Token: 0x0400020E RID: 526
		private DataSetGES.tJ_DamageDataTable tabletJ_Damage;

		// Token: 0x0400020F RID: 527
		private DataSetGES.tJ_DamageHVDataTable tabletJ_DamageHV;

		// Token: 0x04000210 RID: 528
		private DataSetGES.tJ_DamageLVDataTable tabletJ_DamageLV;

		// Token: 0x04000211 RID: 529
		private DataSetGES.tJ_RequestForRepairLogDataTable tabletJ_RequestForRepairLog;

		// Token: 0x04000212 RID: 530
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x06000201 RID: 513
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void a(object A_0, DataSetGES.ac A_1);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x06000205 RID: 517
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void b(object A_0, DataSetGES.ad A_1);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x06000209 RID: 521
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void c(object A_0, DataSetGES.ae A_1);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x0600020D RID: 525
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void d(object A_0, DataSetGES.af A_1);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x06000211 RID: 529
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void e(object A_0, DataSetGES.ag A_1);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x06000215 RID: 533
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void f(object A_0, DataSetGES.ah A_1);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x06000219 RID: 537
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void g(object A_0, DataSetGES.ai A_1);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x0600021D RID: 541
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void h(object A_0, DataSetGES.aj A_1);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x06000221 RID: 545
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void i(object A_0, DataSetGES.ak A_1);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x06000225 RID: 549
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void j(object A_0, DataSetGES.al A_1);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x06000229 RID: 553
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void k(object A_0, DataSetGES.am A_1);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x0600022D RID: 557
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void l(object A_0, DataSetGES.an A_1);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x06000231 RID: 561
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void m(object A_0, DataSetGES.ao A_1);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x06000235 RID: 565
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void n(object A_0, DataSetGES.ap A_1);

		// Token: 0x02000056 RID: 86
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tR_ClassifierDataTable : TypedTableBase<DataSetGES.o>
		{
			// Token: 0x06000238 RID: 568 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tR_ClassifierDataTable()
			{
				base.TableName = "tR_Classifier";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x06000239 RID: 569 RVA: 0x0001C7E0 File Offset: 0x0001A9E0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tR_ClassifierDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x0600023A RID: 570 RVA: 0x0001C888 File Offset: 0x0001AA88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected tR_ClassifierDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.m();
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x0600023B RID: 571 RVA: 0x0001C898 File Offset: 0x0001AA98
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IdColumn
			{
				get
				{
					return this.columnId;
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x0600023C RID: 572 RVA: 0x0001C8A0 File Offset: 0x0001AAA0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x0600023D RID: 573 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SocrNameColumn
			{
				get
				{
					return this.columnSocrName;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x0600023E RID: 574 RVA: 0x0001C8B0 File Offset: 0x0001AAB0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ValueColumn
			{
				get
				{
					return this.columnValue;
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x0600023F RID: 575 RVA: 0x0001C8B8 File Offset: 0x0001AAB8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CommentColumn
			{
				get
				{
					return this.columnComment;
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x06000240 RID: 576 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParentIdColumn
			{
				get
				{
					return this.columnParentId;
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x06000241 RID: 577 RVA: 0x0001C8C8 File Offset: 0x0001AAC8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParentKeyColumn
			{
				get
				{
					return this.columnParentKey;
				}
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000242 RID: 578 RVA: 0x0001C8D0 File Offset: 0x0001AAD0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn OtherIdColumn
			{
				get
				{
					return this.columnOtherId;
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000243 RID: 579 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IsGroupColumn
			{
				get
				{
					return this.columnIsGroup;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000244 RID: 580 RVA: 0x0001C8E0 File Offset: 0x0001AAE0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DeletedColumn
			{
				get
				{
					return this.columnDeleted;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000245 RID: 581 RVA: 0x0001C8E8 File Offset: 0x0001AAE8
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

			// Token: 0x1700005D RID: 93
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.o this[int A_0]
			{
				get
				{
					return (DataSetGES.o)base.Rows[A_0];
				}
			}

			// Token: 0x14000008 RID: 8
			// (add) Token: 0x06000247 RID: 583 RVA: 0x0001C908 File Offset: 0x0001AB08
			// (remove) Token: 0x06000248 RID: 584 RVA: 0x0001C940 File Offset: 0x0001AB40
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.a tR_ClassifierRowChanging;

			// Token: 0x14000009 RID: 9
			// (add) Token: 0x06000249 RID: 585 RVA: 0x0001C978 File Offset: 0x0001AB78
			// (remove) Token: 0x0600024A RID: 586 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.a tR_ClassifierRowChanged;

			// Token: 0x1400000A RID: 10
			// (add) Token: 0x0600024B RID: 587 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
			// (remove) Token: 0x0600024C RID: 588 RVA: 0x0001CA20 File Offset: 0x0001AC20
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.a tR_ClassifierRowDeleting;

			// Token: 0x1400000B RID: 11
			// (add) Token: 0x0600024D RID: 589 RVA: 0x0001CA58 File Offset: 0x0001AC58
			// (remove) Token: 0x0600024E RID: 590 RVA: 0x0001CA90 File Offset: 0x0001AC90
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.a tR_ClassifierRowDeleted;

			// Token: 0x0600024F RID: 591 RVA: 0x0001CAC5 File Offset: 0x0001ACC5
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void a(DataSetGES.o A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x06000250 RID: 592 RVA: 0x0001CAD4 File Offset: 0x0001ACD4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.o a(string A_0, string A_1, decimal A_2, string A_3, int A_4, string A_5, byte[] A_6, bool A_7, bool A_8)
			{
				DataSetGES.o o = (DataSetGES.o)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					A_0,
					A_1,
					A_2,
					A_3,
					A_4,
					A_5,
					A_6,
					A_7,
					A_8
				};
				o.ItemArray = itemArray;
				base.Rows.Add(o);
				return o;
			}

			// Token: 0x06000251 RID: 593 RVA: 0x0001CB48 File Offset: 0x0001AD48
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.o b(int A_0)
			{
				return (DataSetGES.o)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x06000252 RID: 594 RVA: 0x0001CB69 File Offset: 0x0001AD69
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetGES.tR_ClassifierDataTable tR_ClassifierDataTable = (DataSetGES.tR_ClassifierDataTable)base.Clone();
				tR_ClassifierDataTable.m();
				return tR_ClassifierDataTable;
			}

			// Token: 0x06000253 RID: 595 RVA: 0x0001CB7C File Offset: 0x0001AD7C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.tR_ClassifierDataTable();
			}

			// Token: 0x06000254 RID: 596 RVA: 0x0001CB84 File Offset: 0x0001AD84
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void m()
			{
				this.columnId = base.Columns["Id"];
				this.columnName = base.Columns["Name"];
				this.columnSocrName = base.Columns["SocrName"];
				this.columnValue = base.Columns["Value"];
				this.columnComment = base.Columns["Comment"];
				this.columnParentId = base.Columns["ParentId"];
				this.columnParentKey = base.Columns["ParentKey"];
				this.columnOtherId = base.Columns["OtherId"];
				this.columnIsGroup = base.Columns["IsGroup"];
				this.columnDeleted = base.Columns["Deleted"];
			}

			// Token: 0x06000255 RID: 597 RVA: 0x0001CC70 File Offset: 0x0001AE70
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void a()
			{
				this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnId);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnSocrName = new DataColumn("SocrName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSocrName);
				this.columnValue = new DataColumn("Value", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnValue);
				this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnComment);
				this.columnParentId = new DataColumn("ParentId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnParentId);
				this.columnParentKey = new DataColumn("ParentKey", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParentKey);
				this.columnOtherId = new DataColumn("OtherId", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnOtherId);
				this.columnIsGroup = new DataColumn("IsGroup", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnIsGroup);
				this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnDeleted);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnId
				}, true));
				this.columnId.AutoIncrement = true;
				this.columnId.AutoIncrementSeed = -1L;
				this.columnId.AutoIncrementStep = -1L;
				this.columnId.AllowDBNull = false;
				this.columnId.ReadOnly = true;
				this.columnId.Unique = true;
				this.columnName.AllowDBNull = false;
				this.columnName.MaxLength = 100;
				this.columnSocrName.MaxLength = 50;
				this.columnComment.MaxLength = 1024;
				this.columnParentKey.MaxLength = 50;
				this.columnIsGroup.AllowDBNull = false;
				this.columnDeleted.AllowDBNull = false;
			}

			// Token: 0x06000256 RID: 598 RVA: 0x0001CF09 File Offset: 0x0001B109
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.o n()
			{
				return (DataSetGES.o)base.NewRow();
			}

			// Token: 0x06000257 RID: 599 RVA: 0x0001CF16 File Offset: 0x0001B116
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.o(builder);
			}

			// Token: 0x06000258 RID: 600 RVA: 0x0001CF1E File Offset: 0x0001B11E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.o);
			}

			// Token: 0x06000259 RID: 601 RVA: 0x0001CF2A File Offset: 0x0001B12A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tR_ClassifierRowChanged != null)
				{
					this.tR_ClassifierRowChanged(this, new DataSetGES.ac((DataSetGES.o)e.Row, e.Action));
				}
			}

			// Token: 0x0600025A RID: 602 RVA: 0x0001CF5D File Offset: 0x0001B15D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tR_ClassifierRowChanging != null)
				{
					this.tR_ClassifierRowChanging(this, new DataSetGES.ac((DataSetGES.o)e.Row, e.Action));
				}
			}

			// Token: 0x0600025B RID: 603 RVA: 0x0001CF90 File Offset: 0x0001B190
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tR_ClassifierRowDeleted != null)
				{
					this.tR_ClassifierRowDeleted(this, new DataSetGES.ac((DataSetGES.o)e.Row, e.Action));
				}
			}

			// Token: 0x0600025C RID: 604 RVA: 0x0001CFC3 File Offset: 0x0001B1C3
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tR_ClassifierRowDeleting != null)
				{
					this.tR_ClassifierRowDeleting(this, new DataSetGES.ac((DataSetGES.o)e.Row, e.Action));
				}
			}

			// Token: 0x0600025D RID: 605 RVA: 0x0001CFF6 File Offset: 0x0001B1F6
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void b(DataSetGES.o A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x0600025E RID: 606 RVA: 0x0001D004 File Offset: 0x0001B204
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tR_ClassifierDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000213 RID: 531
			private DataColumn columnId;

			// Token: 0x04000214 RID: 532
			private DataColumn columnName;

			// Token: 0x04000215 RID: 533
			private DataColumn columnSocrName;

			// Token: 0x04000216 RID: 534
			private DataColumn columnValue;

			// Token: 0x04000217 RID: 535
			private DataColumn columnComment;

			// Token: 0x04000218 RID: 536
			private DataColumn columnParentId;

			// Token: 0x04000219 RID: 537
			private DataColumn columnParentKey;

			// Token: 0x0400021A RID: 538
			private DataColumn columnOtherId;

			// Token: 0x0400021B RID: 539
			private DataColumn columnIsGroup;

			// Token: 0x0400021C RID: 540
			private DataColumn columnDeleted;
		}

		// Token: 0x02000057 RID: 87
		public class o : DataRow
		{
			// Token: 0x0600025F RID: 607 RVA: 0x0001D1F8 File Offset: 0x0001B3F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal o(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.tR_ClassifierDataTable)base.Table;
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000260 RID: 608 RVA: 0x0001D212 File Offset: 0x0001B412
			// (set) Token: 0x06000261 RID: 609 RVA: 0x0001D22A File Offset: 0x0001B42A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Id
			{
				get
				{
					return (int)base[this.a.IdColumn];
				}
				set
				{
					base[this.a.IdColumn] = value;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x06000262 RID: 610 RVA: 0x0001D243 File Offset: 0x0001B443
			// (set) Token: 0x06000263 RID: 611 RVA: 0x0001D25B File Offset: 0x0001B45B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Name
			{
				get
				{
					return (string)base[this.a.NameColumn];
				}
				set
				{
					base[this.a.NameColumn] = value;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000264 RID: 612 RVA: 0x0001D270 File Offset: 0x0001B470
			// (set) Token: 0x06000265 RID: 613 RVA: 0x0001D2B4 File Offset: 0x0001B4B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string SocrName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.a.SocrNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SocrName' in table 'tR_Classifier' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.SocrNameColumn] = value;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000266 RID: 614 RVA: 0x0001D2C8 File Offset: 0x0001B4C8
			// (set) Token: 0x06000267 RID: 615 RVA: 0x0001D30C File Offset: 0x0001B50C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public decimal Value
			{
				get
				{
					decimal result;
					try
					{
						result = (decimal)base[this.a.ValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Value' in table 'tR_Classifier' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.ValueColumn] = value;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000268 RID: 616 RVA: 0x0001D328 File Offset: 0x0001B528
			// (set) Token: 0x06000269 RID: 617 RVA: 0x0001D36C File Offset: 0x0001B56C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Comment
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.a.CommentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Comment' in table 'tR_Classifier' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.CommentColumn] = value;
				}
			}

			// Token: 0x0600026A RID: 618 RVA: 0x0001D380 File Offset: 0x0001B580
			public int f()
			{
				int result;
				try
				{
					result = (int)base[this.a.ParentIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentId' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600026B RID: 619 RVA: 0x0001D3C4 File Offset: 0x0001B5C4
			public void b(int A_0)
			{
				base[this.a.ParentIdColumn] = A_0;
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x0600026C RID: 620 RVA: 0x0001D3E0 File Offset: 0x0001B5E0
			// (set) Token: 0x0600026D RID: 621 RVA: 0x0001D424 File Offset: 0x0001B624
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ParentKey
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.a.ParentKeyColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ParentKey' in table 'tR_Classifier' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.ParentKeyColumn] = value;
				}
			}

			// Token: 0x0600026E RID: 622 RVA: 0x0001D438 File Offset: 0x0001B638
			public byte[] h()
			{
				byte[] result;
				try
				{
					result = (byte[])base[this.a.OtherIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'OtherId' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600026F RID: 623 RVA: 0x0001D47C File Offset: 0x0001B67C
			public void a(byte[] A_0)
			{
				base[this.a.OtherIdColumn] = A_0;
			}

			// Token: 0x06000270 RID: 624 RVA: 0x0001D490 File Offset: 0x0001B690
			public bool i()
			{
				return (bool)base[this.a.IsGroupColumn];
			}

			// Token: 0x06000271 RID: 625 RVA: 0x0001D4A8 File Offset: 0x0001B6A8
			public void a(bool A_0)
			{
				base[this.a.IsGroupColumn] = A_0;
			}

			// Token: 0x06000272 RID: 626 RVA: 0x0001D4C1 File Offset: 0x0001B6C1
			public bool j()
			{
				return (bool)base[this.a.DeletedColumn];
			}

			// Token: 0x06000273 RID: 627 RVA: 0x0001D4D9 File Offset: 0x0001B6D9
			public void b(bool A_0)
			{
				base[this.a.DeletedColumn] = A_0;
			}

			// Token: 0x06000274 RID: 628 RVA: 0x0001D4F2 File Offset: 0x0001B6F2
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool k()
			{
				return base.IsNull(this.a.SocrNameColumn);
			}

			// Token: 0x06000275 RID: 629 RVA: 0x0001D505 File Offset: 0x0001B705
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void l()
			{
				base[this.a.SocrNameColumn] = Convert.DBNull;
			}

			// Token: 0x06000276 RID: 630 RVA: 0x0001D51D File Offset: 0x0001B71D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool m()
			{
				return base.IsNull(this.a.ValueColumn);
			}

			// Token: 0x06000277 RID: 631 RVA: 0x0001D530 File Offset: 0x0001B730
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void n()
			{
				base[this.a.ValueColumn] = Convert.DBNull;
			}

			// Token: 0x06000278 RID: 632 RVA: 0x0001D548 File Offset: 0x0001B748
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool o()
			{
				return base.IsNull(this.a.CommentColumn);
			}

			// Token: 0x06000279 RID: 633 RVA: 0x0001D55B File Offset: 0x0001B75B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void p()
			{
				base[this.a.CommentColumn] = Convert.DBNull;
			}

			// Token: 0x0600027A RID: 634 RVA: 0x0001D573 File Offset: 0x0001B773
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool q()
			{
				return base.IsNull(this.a.ParentIdColumn);
			}

			// Token: 0x0600027B RID: 635 RVA: 0x0001D586 File Offset: 0x0001B786
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void r()
			{
				base[this.a.ParentIdColumn] = Convert.DBNull;
			}

			// Token: 0x0600027C RID: 636 RVA: 0x0001D59E File Offset: 0x0001B79E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool s()
			{
				return base.IsNull(this.a.ParentKeyColumn);
			}

			// Token: 0x0600027D RID: 637 RVA: 0x0001D5B1 File Offset: 0x0001B7B1
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void t()
			{
				base[this.a.ParentKeyColumn] = Convert.DBNull;
			}

			// Token: 0x0600027E RID: 638 RVA: 0x0001D5C9 File Offset: 0x0001B7C9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool u()
			{
				return base.IsNull(this.a.OtherIdColumn);
			}

			// Token: 0x0600027F RID: 639 RVA: 0x0001D5DC File Offset: 0x0001B7DC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void v()
			{
				base[this.a.OtherIdColumn] = Convert.DBNull;
			}

			// Token: 0x04000221 RID: 545
			private DataSetGES.tR_ClassifierDataTable a;
		}

		// Token: 0x02000058 RID: 88
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vSchm_ObjListDataTable : TypedTableBase<DataSetGES.p>
		{
			// Token: 0x06000280 RID: 640 RVA: 0x0001D5F4 File Offset: 0x0001B7F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public vSchm_ObjListDataTable()
			{
				base.TableName = "vSchm_ObjList";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x06000281 RID: 641 RVA: 0x0001D61C File Offset: 0x0001B81C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal vSchm_ObjListDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x06000282 RID: 642 RVA: 0x0001D6C4 File Offset: 0x0001B8C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected vSchm_ObjListDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.l();
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000283 RID: 643 RVA: 0x0001D6D4 File Offset: 0x0001B8D4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IdColumn
			{
				get
				{
					return this.columnId;
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000284 RID: 644 RVA: 0x0001D6DC File Offset: 0x0001B8DC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000285 RID: 645 RVA: 0x0001D6E4 File Offset: 0x0001B8E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TypeCodeIdColumn
			{
				get
				{
					return this.columnTypeCodeId;
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000286 RID: 646 RVA: 0x0001D6EC File Offset: 0x0001B8EC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn typecodeColumn
			{
				get
				{
					return this.columntypecode;
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000287 RID: 647 RVA: 0x0001D6F4 File Offset: 0x0001B8F4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn typeCodeSocrColumn
			{
				get
				{
					return this.columntypeCodeSocr;
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000288 RID: 648 RVA: 0x0001D6FC File Offset: 0x0001B8FC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IdParentColumn
			{
				get
				{
					return this.columnIdParent;
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000289 RID: 649 RVA: 0x0001D704 File Offset: 0x0001B904
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn OnOffColumn
			{
				get
				{
					return this.columnOnOff;
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x0600028A RID: 650 RVA: 0x0001D70C File Offset: 0x0001B90C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NamePColumn
			{
				get
				{
					return this.columnNameP;
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x0600028B RID: 651 RVA: 0x0001D714 File Offset: 0x0001B914
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DeletedColumn
			{
				get
				{
					return this.columnDeleted;
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x0600028C RID: 652 RVA: 0x0001D71C File Offset: 0x0001B91C
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

			// Token: 0x1700006E RID: 110
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.p this[int A_0]
			{
				get
				{
					return (DataSetGES.p)base.Rows[A_0];
				}
			}

			// Token: 0x1400000C RID: 12
			// (add) Token: 0x0600028E RID: 654 RVA: 0x0001D73C File Offset: 0x0001B93C
			// (remove) Token: 0x0600028F RID: 655 RVA: 0x0001D774 File Offset: 0x0001B974
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.b vSchm_ObjListRowChanging;

			// Token: 0x1400000D RID: 13
			// (add) Token: 0x06000290 RID: 656 RVA: 0x0001D7AC File Offset: 0x0001B9AC
			// (remove) Token: 0x06000291 RID: 657 RVA: 0x0001D7E4 File Offset: 0x0001B9E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.b vSchm_ObjListRowChanged;

			// Token: 0x1400000E RID: 14
			// (add) Token: 0x06000292 RID: 658 RVA: 0x0001D81C File Offset: 0x0001BA1C
			// (remove) Token: 0x06000293 RID: 659 RVA: 0x0001D854 File Offset: 0x0001BA54
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.b vSchm_ObjListRowDeleting;

			// Token: 0x1400000F RID: 15
			// (add) Token: 0x06000294 RID: 660 RVA: 0x0001D88C File Offset: 0x0001BA8C
			// (remove) Token: 0x06000295 RID: 661 RVA: 0x0001D8C4 File Offset: 0x0001BAC4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.b vSchm_ObjListRowDeleted;

			// Token: 0x06000296 RID: 662 RVA: 0x0001D8F9 File Offset: 0x0001BAF9
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void a(DataSetGES.p A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x06000297 RID: 663 RVA: 0x0001D908 File Offset: 0x0001BB08
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.p a(int A_0, string A_1, int A_2, string A_3, string A_4, int A_5, bool A_6, int A_7, bool A_8)
			{
				DataSetGES.p p = (DataSetGES.p)base.NewRow();
				object[] itemArray = new object[]
				{
					A_0,
					A_1,
					A_2,
					A_3,
					A_4,
					A_5,
					A_6,
					A_7,
					A_8
				};
				p.ItemArray = itemArray;
				base.Rows.Add(p);
				return p;
			}

			// Token: 0x06000298 RID: 664 RVA: 0x0001D985 File Offset: 0x0001BB85
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.p b(int A_0)
			{
				return (DataSetGES.p)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x06000299 RID: 665 RVA: 0x0001D9A6 File Offset: 0x0001BBA6
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetGES.vSchm_ObjListDataTable vSchm_ObjListDataTable = (DataSetGES.vSchm_ObjListDataTable)base.Clone();
				vSchm_ObjListDataTable.l();
				return vSchm_ObjListDataTable;
			}

			// Token: 0x0600029A RID: 666 RVA: 0x0001D9B9 File Offset: 0x0001BBB9
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.vSchm_ObjListDataTable();
			}

			// Token: 0x0600029B RID: 667 RVA: 0x0001D9C0 File Offset: 0x0001BBC0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void l()
			{
				this.columnId = base.Columns["Id"];
				this.columnName = base.Columns["Name"];
				this.columnTypeCodeId = base.Columns["TypeCodeId"];
				this.columntypecode = base.Columns["typecode"];
				this.columntypeCodeSocr = base.Columns["typeCodeSocr"];
				this.columnIdParent = base.Columns["IdParent"];
				this.columnOnOff = base.Columns["OnOff"];
				this.columnNameP = base.Columns["NameP"];
				this.columnDeleted = base.Columns["Deleted"];
			}

			// Token: 0x0600029C RID: 668 RVA: 0x0001DA94 File Offset: 0x0001BC94
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void a()
			{
				this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnId);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnTypeCodeId = new DataColumn("TypeCodeId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTypeCodeId);
				this.columntypecode = new DataColumn("typecode", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntypecode);
				this.columntypeCodeSocr = new DataColumn("typeCodeSocr", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntypeCodeSocr);
				this.columnIdParent = new DataColumn("IdParent", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnIdParent);
				this.columnOnOff = new DataColumn("OnOff", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnOnOff);
				this.columnNameP = new DataColumn("NameP", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnNameP);
				this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnDeleted);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnId
				}, true));
				this.columnId.AllowDBNull = false;
				this.columnId.Unique = true;
				this.columnName.MaxLength = 512;
				this.columntypecode.MaxLength = 100;
				this.columntypeCodeSocr.MaxLength = 50;
				this.columnNameP.ReadOnly = true;
				this.columnDeleted.AllowDBNull = false;
			}

			// Token: 0x0600029D RID: 669 RVA: 0x0001DCB5 File Offset: 0x0001BEB5
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.p m()
			{
				return (DataSetGES.p)base.NewRow();
			}

			// Token: 0x0600029E RID: 670 RVA: 0x0001DCC2 File Offset: 0x0001BEC2
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.p(builder);
			}

			// Token: 0x0600029F RID: 671 RVA: 0x0001DCCA File Offset: 0x0001BECA
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.p);
			}

			// Token: 0x060002A0 RID: 672 RVA: 0x0001DCD6 File Offset: 0x0001BED6
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.vSchm_ObjListRowChanged != null)
				{
					this.vSchm_ObjListRowChanged(this, new DataSetGES.ad((DataSetGES.p)e.Row, e.Action));
				}
			}

			// Token: 0x060002A1 RID: 673 RVA: 0x0001DD09 File Offset: 0x0001BF09
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.vSchm_ObjListRowChanging != null)
				{
					this.vSchm_ObjListRowChanging(this, new DataSetGES.ad((DataSetGES.p)e.Row, e.Action));
				}
			}

			// Token: 0x060002A2 RID: 674 RVA: 0x0001DD3C File Offset: 0x0001BF3C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.vSchm_ObjListRowDeleted != null)
				{
					this.vSchm_ObjListRowDeleted(this, new DataSetGES.ad((DataSetGES.p)e.Row, e.Action));
				}
			}

			// Token: 0x060002A3 RID: 675 RVA: 0x0001DD6F File Offset: 0x0001BF6F
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.vSchm_ObjListRowDeleting != null)
				{
					this.vSchm_ObjListRowDeleting(this, new DataSetGES.ad((DataSetGES.p)e.Row, e.Action));
				}
			}

			// Token: 0x060002A4 RID: 676 RVA: 0x0001DDA2 File Offset: 0x0001BFA2
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void b(DataSetGES.p A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x060002A5 RID: 677 RVA: 0x0001DDB0 File Offset: 0x0001BFB0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vSchm_ObjListDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000222 RID: 546
			private DataColumn columnId;

			// Token: 0x04000223 RID: 547
			private DataColumn columnName;

			// Token: 0x04000224 RID: 548
			private DataColumn columnTypeCodeId;

			// Token: 0x04000225 RID: 549
			private DataColumn columntypecode;

			// Token: 0x04000226 RID: 550
			private DataColumn columntypeCodeSocr;

			// Token: 0x04000227 RID: 551
			private DataColumn columnIdParent;

			// Token: 0x04000228 RID: 552
			private DataColumn columnOnOff;

			// Token: 0x04000229 RID: 553
			private DataColumn columnNameP;

			// Token: 0x0400022A RID: 554
			private DataColumn columnDeleted;
		}

		// Token: 0x02000059 RID: 89
		public class p : DataRow
		{
			// Token: 0x060002A6 RID: 678 RVA: 0x0001DFA4 File Offset: 0x0001C1A4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal p(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.vSchm_ObjListDataTable)base.Table;
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x060002A7 RID: 679 RVA: 0x0001DFBE File Offset: 0x0001C1BE
			// (set) Token: 0x060002A8 RID: 680 RVA: 0x0001DFD6 File Offset: 0x0001C1D6
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Id
			{
				get
				{
					return (int)base[this.a.IdColumn];
				}
				set
				{
					base[this.a.IdColumn] = value;
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x060002A9 RID: 681 RVA: 0x0001DFF0 File Offset: 0x0001C1F0
			// (set) Token: 0x060002AA RID: 682 RVA: 0x0001E034 File Offset: 0x0001C234
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.a.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'vSchm_ObjList' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.NameColumn] = value;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x060002AB RID: 683 RVA: 0x0001E048 File Offset: 0x0001C248
			// (set) Token: 0x060002AC RID: 684 RVA: 0x0001E08C File Offset: 0x0001C28C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int TypeCodeId
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.a.TypeCodeIdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TypeCodeId' in table 'vSchm_ObjList' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.TypeCodeIdColumn] = value;
				}
			}

			// Token: 0x060002AD RID: 685 RVA: 0x0001E0A8 File Offset: 0x0001C2A8
			public string d()
			{
				string result;
				try
				{
					result = (string)base[this.a.typecodeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typecode' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060002AE RID: 686 RVA: 0x0001E0EC File Offset: 0x0001C2EC
			public void b(string value)
			{
				base[this.a.typecodeColumn] = value;
			}

			// Token: 0x060002AF RID: 687 RVA: 0x0001E100 File Offset: 0x0001C300
			public string e()
			{
				string result;
				try
				{
					result = (string)base[this.a.typeCodeSocrColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typeCodeSocr' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060002B0 RID: 688 RVA: 0x0001E144 File Offset: 0x0001C344
			public void c(string value)
			{
				base[this.a.typeCodeSocrColumn] = value;
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x060002B1 RID: 689 RVA: 0x0001E158 File Offset: 0x0001C358
			// (set) Token: 0x060002B2 RID: 690 RVA: 0x0001E19C File Offset: 0x0001C39C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int IdParent
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.a.IdParentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'IdParent' in table 'vSchm_ObjList' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.IdParentColumn] = value;
				}
			}

			// Token: 0x060002B3 RID: 691 RVA: 0x0001E1B8 File Offset: 0x0001C3B8
			public bool g()
			{
				bool result;
				try
				{
					result = (bool)base[this.a.OnOffColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'OnOff' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060002B4 RID: 692 RVA: 0x0001E1FC File Offset: 0x0001C3FC
			public void a(bool A_0)
			{
				base[this.a.OnOffColumn] = A_0;
			}

			// Token: 0x060002B5 RID: 693 RVA: 0x0001E218 File Offset: 0x0001C418
			public int h()
			{
				int result;
				try
				{
					result = (int)base[this.a.NamePColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NameP' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060002B6 RID: 694 RVA: 0x0001E25C File Offset: 0x0001C45C
			public void d(int A_0)
			{
				base[this.a.NamePColumn] = A_0;
			}

			// Token: 0x060002B7 RID: 695 RVA: 0x0001E275 File Offset: 0x0001C475
			public bool i()
			{
				return (bool)base[this.a.DeletedColumn];
			}

			// Token: 0x060002B8 RID: 696 RVA: 0x0001E28D File Offset: 0x0001C48D
			public void b(bool A_0)
			{
				base[this.a.DeletedColumn] = A_0;
			}

			// Token: 0x060002B9 RID: 697 RVA: 0x0001E2A6 File Offset: 0x0001C4A6
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool j()
			{
				return base.IsNull(this.a.NameColumn);
			}

			// Token: 0x060002BA RID: 698 RVA: 0x0001E2B9 File Offset: 0x0001C4B9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void k()
			{
				base[this.a.NameColumn] = Convert.DBNull;
			}

			// Token: 0x060002BB RID: 699 RVA: 0x0001E2D1 File Offset: 0x0001C4D1
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool l()
			{
				return base.IsNull(this.a.TypeCodeIdColumn);
			}

			// Token: 0x060002BC RID: 700 RVA: 0x0001E2E4 File Offset: 0x0001C4E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void m()
			{
				base[this.a.TypeCodeIdColumn] = Convert.DBNull;
			}

			// Token: 0x060002BD RID: 701 RVA: 0x0001E2FC File Offset: 0x0001C4FC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool n()
			{
				return base.IsNull(this.a.typecodeColumn);
			}

			// Token: 0x060002BE RID: 702 RVA: 0x0001E30F File Offset: 0x0001C50F
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void o()
			{
				base[this.a.typecodeColumn] = Convert.DBNull;
			}

			// Token: 0x060002BF RID: 703 RVA: 0x0001E327 File Offset: 0x0001C527
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool p()
			{
				return base.IsNull(this.a.typeCodeSocrColumn);
			}

			// Token: 0x060002C0 RID: 704 RVA: 0x0001E33A File Offset: 0x0001C53A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void q()
			{
				base[this.a.typeCodeSocrColumn] = Convert.DBNull;
			}

			// Token: 0x060002C1 RID: 705 RVA: 0x0001E352 File Offset: 0x0001C552
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool r()
			{
				return base.IsNull(this.a.IdParentColumn);
			}

			// Token: 0x060002C2 RID: 706 RVA: 0x0001E365 File Offset: 0x0001C565
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void s()
			{
				base[this.a.IdParentColumn] = Convert.DBNull;
			}

			// Token: 0x060002C3 RID: 707 RVA: 0x0001E37D File Offset: 0x0001C57D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool t()
			{
				return base.IsNull(this.a.OnOffColumn);
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x0001E390 File Offset: 0x0001C590
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void u()
			{
				base[this.a.OnOffColumn] = Convert.DBNull;
			}

			// Token: 0x060002C5 RID: 709 RVA: 0x0001E3A8 File Offset: 0x0001C5A8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool v()
			{
				return base.IsNull(this.a.NamePColumn);
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x0001E3BB File Offset: 0x0001C5BB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void w()
			{
				base[this.a.NamePColumn] = Convert.DBNull;
			}

			// Token: 0x0400022F RID: 559
			private DataSetGES.vSchm_ObjListDataTable a;
		}

		// Token: 0x0200005A RID: 90
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vSchm_TreeCellLineDataTable : TypedTableBase<DataSetGES.q>
		{
			// Token: 0x060002C7 RID: 711 RVA: 0x0001E3D3 File Offset: 0x0001C5D3
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public vSchm_TreeCellLineDataTable()
			{
				base.TableName = "vSchm_TreeCellLine";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x0001E3F8 File Offset: 0x0001C5F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal vSchm_TreeCellLineDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x0001E4A0 File Offset: 0x0001C6A0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected vSchm_TreeCellLineDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.i();
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x060002CA RID: 714 RVA: 0x0001E4B0 File Offset: 0x0001C6B0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IdColumn
			{
				get
				{
					return this.columnId;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060002CB RID: 715 RVA: 0x0001E4B8 File Offset: 0x0001C6B8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParentLinkColumn
			{
				get
				{
					return this.columnParentLink;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x060002CC RID: 716 RVA: 0x0001E4C0 File Offset: 0x0001C6C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TypeCodeIdColumn
			{
				get
				{
					return this.columnTypeCodeId;
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060002CD RID: 717 RVA: 0x0001E4C8 File Offset: 0x0001C6C8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParentKeyColumn
			{
				get
				{
					return this.columnParentKey;
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x060002CE RID: 718 RVA: 0x0001E4D0 File Offset: 0x0001C6D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x060002CF RID: 719 RVA: 0x0001E4D8 File Offset: 0x0001C6D8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn FullNameColumn
			{
				get
				{
					return this.columnFullName;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x060002D0 RID: 720 RVA: 0x0001E4E0 File Offset: 0x0001C6E0
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

			// Token: 0x1700007A RID: 122
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.q this[int A_0]
			{
				get
				{
					return (DataSetGES.q)base.Rows[A_0];
				}
			}

			// Token: 0x14000010 RID: 16
			// (add) Token: 0x060002D2 RID: 722 RVA: 0x0001E500 File Offset: 0x0001C700
			// (remove) Token: 0x060002D3 RID: 723 RVA: 0x0001E538 File Offset: 0x0001C738
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.c vSchm_TreeCellLineRowChanging;

			// Token: 0x14000011 RID: 17
			// (add) Token: 0x060002D4 RID: 724 RVA: 0x0001E570 File Offset: 0x0001C770
			// (remove) Token: 0x060002D5 RID: 725 RVA: 0x0001E5A8 File Offset: 0x0001C7A8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.c vSchm_TreeCellLineRowChanged;

			// Token: 0x14000012 RID: 18
			// (add) Token: 0x060002D6 RID: 726 RVA: 0x0001E5E0 File Offset: 0x0001C7E0
			// (remove) Token: 0x060002D7 RID: 727 RVA: 0x0001E618 File Offset: 0x0001C818
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.c vSchm_TreeCellLineRowDeleting;

			// Token: 0x14000013 RID: 19
			// (add) Token: 0x060002D8 RID: 728 RVA: 0x0001E650 File Offset: 0x0001C850
			// (remove) Token: 0x060002D9 RID: 729 RVA: 0x0001E688 File Offset: 0x0001C888
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.c vSchm_TreeCellLineRowDeleted;

			// Token: 0x060002DA RID: 730 RVA: 0x0001E6BD File Offset: 0x0001C8BD
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void a(DataSetGES.q A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x060002DB RID: 731 RVA: 0x0001E6CC File Offset: 0x0001C8CC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.q a(int A_0, int A_1, int A_2, string A_3, string A_4, string A_5)
			{
				DataSetGES.q q = (DataSetGES.q)base.NewRow();
				object[] itemArray = new object[]
				{
					A_0,
					A_1,
					A_2,
					A_3,
					A_4,
					A_5
				};
				q.ItemArray = itemArray;
				base.Rows.Add(q);
				return q;
			}

			// Token: 0x060002DC RID: 732 RVA: 0x0001E72A File Offset: 0x0001C92A
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetGES.vSchm_TreeCellLineDataTable vSchm_TreeCellLineDataTable = (DataSetGES.vSchm_TreeCellLineDataTable)base.Clone();
				vSchm_TreeCellLineDataTable.i();
				return vSchm_TreeCellLineDataTable;
			}

			// Token: 0x060002DD RID: 733 RVA: 0x0001E73D File Offset: 0x0001C93D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.vSchm_TreeCellLineDataTable();
			}

			// Token: 0x060002DE RID: 734 RVA: 0x0001E744 File Offset: 0x0001C944
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void i()
			{
				this.columnId = base.Columns["Id"];
				this.columnParentLink = base.Columns["ParentLink"];
				this.columnTypeCodeId = base.Columns["TypeCodeId"];
				this.columnParentKey = base.Columns["ParentKey"];
				this.columnName = base.Columns["Name"];
				this.columnFullName = base.Columns["FullName"];
			}

			// Token: 0x060002DF RID: 735 RVA: 0x0001E7D8 File Offset: 0x0001C9D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void a()
			{
				this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnId);
				this.columnParentLink = new DataColumn("ParentLink", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnParentLink);
				this.columnTypeCodeId = new DataColumn("TypeCodeId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTypeCodeId);
				this.columnParentKey = new DataColumn("ParentKey", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParentKey);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnFullName = new DataColumn("FullName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFullName);
				this.columnId.AllowDBNull = false;
				this.columnParentLink.AllowDBNull = false;
				this.columnParentKey.MaxLength = 50;
				this.columnName.MaxLength = 512;
				this.columnFullName.ReadOnly = true;
				this.columnFullName.MaxLength = 565;
			}

			// Token: 0x060002E0 RID: 736 RVA: 0x0001E944 File Offset: 0x0001CB44
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.q j()
			{
				return (DataSetGES.q)base.NewRow();
			}

			// Token: 0x060002E1 RID: 737 RVA: 0x0001E951 File Offset: 0x0001CB51
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.q(builder);
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x0001E959 File Offset: 0x0001CB59
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.q);
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x0001E965 File Offset: 0x0001CB65
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.vSchm_TreeCellLineRowChanged != null)
				{
					this.vSchm_TreeCellLineRowChanged(this, new DataSetGES.ae((DataSetGES.q)e.Row, e.Action));
				}
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x0001E998 File Offset: 0x0001CB98
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.vSchm_TreeCellLineRowChanging != null)
				{
					this.vSchm_TreeCellLineRowChanging(this, new DataSetGES.ae((DataSetGES.q)e.Row, e.Action));
				}
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x0001E9CB File Offset: 0x0001CBCB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.vSchm_TreeCellLineRowDeleted != null)
				{
					this.vSchm_TreeCellLineRowDeleted(this, new DataSetGES.ae((DataSetGES.q)e.Row, e.Action));
				}
			}

			// Token: 0x060002E6 RID: 742 RVA: 0x0001E9FE File Offset: 0x0001CBFE
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.vSchm_TreeCellLineRowDeleting != null)
				{
					this.vSchm_TreeCellLineRowDeleting(this, new DataSetGES.ae((DataSetGES.q)e.Row, e.Action));
				}
			}

			// Token: 0x060002E7 RID: 743 RVA: 0x0001EA31 File Offset: 0x0001CC31
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void b(DataSetGES.q A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x060002E8 RID: 744 RVA: 0x0001EA40 File Offset: 0x0001CC40
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vSchm_TreeCellLineDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000230 RID: 560
			private DataColumn columnId;

			// Token: 0x04000231 RID: 561
			private DataColumn columnParentLink;

			// Token: 0x04000232 RID: 562
			private DataColumn columnTypeCodeId;

			// Token: 0x04000233 RID: 563
			private DataColumn columnParentKey;

			// Token: 0x04000234 RID: 564
			private DataColumn columnName;

			// Token: 0x04000235 RID: 565
			private DataColumn columnFullName;
		}

		// Token: 0x0200005B RID: 91
		public class q : DataRow
		{
			// Token: 0x060002E9 RID: 745 RVA: 0x0001EC34 File Offset: 0x0001CE34
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal q(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.vSchm_TreeCellLineDataTable)base.Table;
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x060002EA RID: 746 RVA: 0x0001EC4E File Offset: 0x0001CE4E
			// (set) Token: 0x060002EB RID: 747 RVA: 0x0001EC66 File Offset: 0x0001CE66
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Id
			{
				get
				{
					return (int)base[this.a.IdColumn];
				}
				set
				{
					base[this.a.IdColumn] = value;
				}
			}

			// Token: 0x060002EC RID: 748 RVA: 0x0001EC7F File Offset: 0x0001CE7F
			public int b()
			{
				return (int)base[this.a.ParentLinkColumn];
			}

			// Token: 0x060002ED RID: 749 RVA: 0x0001EC97 File Offset: 0x0001CE97
			public void b(int A_0)
			{
				base[this.a.ParentLinkColumn] = A_0;
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x060002EE RID: 750 RVA: 0x0001ECB0 File Offset: 0x0001CEB0
			// (set) Token: 0x060002EF RID: 751 RVA: 0x0001ECF4 File Offset: 0x0001CEF4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int TypeCodeId
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.a.TypeCodeIdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TypeCodeId' in table 'vSchm_TreeCellLine' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.TypeCodeIdColumn] = value;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x060002F0 RID: 752 RVA: 0x0001ED10 File Offset: 0x0001CF10
			// (set) Token: 0x060002F1 RID: 753 RVA: 0x0001ED54 File Offset: 0x0001CF54
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string ParentKey
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.a.ParentKeyColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ParentKey' in table 'vSchm_TreeCellLine' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.ParentKeyColumn] = value;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x060002F2 RID: 754 RVA: 0x0001ED68 File Offset: 0x0001CF68
			// (set) Token: 0x060002F3 RID: 755 RVA: 0x0001EDAC File Offset: 0x0001CFAC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.a.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'vSchm_TreeCellLine' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.NameColumn] = value;
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x060002F4 RID: 756 RVA: 0x0001EDC0 File Offset: 0x0001CFC0
			// (set) Token: 0x060002F5 RID: 757 RVA: 0x0001EE04 File Offset: 0x0001D004
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string FullName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.a.FullNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'FullName' in table 'vSchm_TreeCellLine' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.FullNameColumn] = value;
				}
			}

			// Token: 0x060002F6 RID: 758 RVA: 0x0001EE18 File Offset: 0x0001D018
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool g()
			{
				return base.IsNull(this.a.TypeCodeIdColumn);
			}

			// Token: 0x060002F7 RID: 759 RVA: 0x0001EE2B File Offset: 0x0001D02B
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void h()
			{
				base[this.a.TypeCodeIdColumn] = Convert.DBNull;
			}

			// Token: 0x060002F8 RID: 760 RVA: 0x0001EE43 File Offset: 0x0001D043
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool i()
			{
				return base.IsNull(this.a.ParentKeyColumn);
			}

			// Token: 0x060002F9 RID: 761 RVA: 0x0001EE56 File Offset: 0x0001D056
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void j()
			{
				base[this.a.ParentKeyColumn] = Convert.DBNull;
			}

			// Token: 0x060002FA RID: 762 RVA: 0x0001EE6E File Offset: 0x0001D06E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool k()
			{
				return base.IsNull(this.a.NameColumn);
			}

			// Token: 0x060002FB RID: 763 RVA: 0x0001EE81 File Offset: 0x0001D081
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void l()
			{
				base[this.a.NameColumn] = Convert.DBNull;
			}

			// Token: 0x060002FC RID: 764 RVA: 0x0001EE99 File Offset: 0x0001D099
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool m()
			{
				return base.IsNull(this.a.FullNameColumn);
			}

			// Token: 0x060002FD RID: 765 RVA: 0x0001EEAC File Offset: 0x0001D0AC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void n()
			{
				base[this.a.FullNameColumn] = Convert.DBNull;
			}

			// Token: 0x0400023A RID: 570
			private DataSetGES.vSchm_TreeCellLineDataTable a;
		}

		// Token: 0x0200005C RID: 92
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSchm_RelationDataTable : TypedTableBase<DataSetGES.r>
		{
			// Token: 0x060002FE RID: 766 RVA: 0x0001EEC4 File Offset: 0x0001D0C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tSchm_RelationDataTable()
			{
				base.TableName = "tSchm_Relation";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x060002FF RID: 767 RVA: 0x0001EEEC File Offset: 0x0001D0EC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tSchm_RelationDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x06000300 RID: 768 RVA: 0x0001EF94 File Offset: 0x0001D194
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected tSchm_RelationDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.g();
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x06000301 RID: 769 RVA: 0x0001EFA4 File Offset: 0x0001D1A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x06000302 RID: 770 RVA: 0x0001EFAC File Offset: 0x0001D1AC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SourceObjColumn
			{
				get
				{
					return this.columnSourceObj;
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x06000303 RID: 771 RVA: 0x0001EFB4 File Offset: 0x0001D1B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DestObjColumn
			{
				get
				{
					return this.columnDestObj;
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x06000304 RID: 772 RVA: 0x0001EFBC File Offset: 0x0001D1BC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn EdgeColumn
			{
				get
				{
					return this.columnEdge;
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x06000305 RID: 773 RVA: 0x0001EFC4 File Offset: 0x0001D1C4
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

			// Token: 0x17000085 RID: 133
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.r this[int A_0]
			{
				get
				{
					return (DataSetGES.r)base.Rows[A_0];
				}
			}

			// Token: 0x14000014 RID: 20
			// (add) Token: 0x06000307 RID: 775 RVA: 0x0001EFE4 File Offset: 0x0001D1E4
			// (remove) Token: 0x06000308 RID: 776 RVA: 0x0001F01C File Offset: 0x0001D21C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.d tSchm_RelationRowChanging;

			// Token: 0x14000015 RID: 21
			// (add) Token: 0x06000309 RID: 777 RVA: 0x0001F054 File Offset: 0x0001D254
			// (remove) Token: 0x0600030A RID: 778 RVA: 0x0001F08C File Offset: 0x0001D28C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.d tSchm_RelationRowChanged;

			// Token: 0x14000016 RID: 22
			// (add) Token: 0x0600030B RID: 779 RVA: 0x0001F0C4 File Offset: 0x0001D2C4
			// (remove) Token: 0x0600030C RID: 780 RVA: 0x0001F0FC File Offset: 0x0001D2FC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.d tSchm_RelationRowDeleting;

			// Token: 0x14000017 RID: 23
			// (add) Token: 0x0600030D RID: 781 RVA: 0x0001F134 File Offset: 0x0001D334
			// (remove) Token: 0x0600030E RID: 782 RVA: 0x0001F16C File Offset: 0x0001D36C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.d tSchm_RelationRowDeleted;

			// Token: 0x0600030F RID: 783 RVA: 0x0001F1A1 File Offset: 0x0001D3A1
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void a(DataSetGES.r A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x06000310 RID: 784 RVA: 0x0001F1B0 File Offset: 0x0001D3B0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.r a(int A_0, int A_1, int A_2)
			{
				DataSetGES.r r = (DataSetGES.r)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					A_0,
					A_1,
					A_2
				};
				r.ItemArray = itemArray;
				base.Rows.Add(r);
				return r;
			}

			// Token: 0x06000311 RID: 785 RVA: 0x0001F1FF File Offset: 0x0001D3FF
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.r b(int A_0)
			{
				return (DataSetGES.r)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x06000312 RID: 786 RVA: 0x0001F220 File Offset: 0x0001D420
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetGES.tSchm_RelationDataTable tSchm_RelationDataTable = (DataSetGES.tSchm_RelationDataTable)base.Clone();
				tSchm_RelationDataTable.g();
				return tSchm_RelationDataTable;
			}

			// Token: 0x06000313 RID: 787 RVA: 0x0001F233 File Offset: 0x0001D433
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.tSchm_RelationDataTable();
			}

			// Token: 0x06000314 RID: 788 RVA: 0x0001F23C File Offset: 0x0001D43C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void g()
			{
				this.columnid = base.Columns["id"];
				this.columnSourceObj = base.Columns["SourceObj"];
				this.columnDestObj = base.Columns["DestObj"];
				this.columnEdge = base.Columns["Edge"];
			}

			// Token: 0x06000315 RID: 789 RVA: 0x0001F2A4 File Offset: 0x0001D4A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void a()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnSourceObj = new DataColumn("SourceObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnSourceObj);
				this.columnDestObj = new DataColumn("DestObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnDestObj);
				this.columnEdge = new DataColumn("Edge", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnEdge);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnid
				}, true));
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = -1L;
				this.columnid.AutoIncrementStep = -1L;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
				this.columnSourceObj.AllowDBNull = false;
				this.columnDestObj.AllowDBNull = false;
			}

			// Token: 0x06000316 RID: 790 RVA: 0x0001F3EC File Offset: 0x0001D5EC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.r h()
			{
				return (DataSetGES.r)base.NewRow();
			}

			// Token: 0x06000317 RID: 791 RVA: 0x0001F3F9 File Offset: 0x0001D5F9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.r(builder);
			}

			// Token: 0x06000318 RID: 792 RVA: 0x0001F401 File Offset: 0x0001D601
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.r);
			}

			// Token: 0x06000319 RID: 793 RVA: 0x0001F40D File Offset: 0x0001D60D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tSchm_RelationRowChanged != null)
				{
					this.tSchm_RelationRowChanged(this, new DataSetGES.af((DataSetGES.r)e.Row, e.Action));
				}
			}

			// Token: 0x0600031A RID: 794 RVA: 0x0001F440 File Offset: 0x0001D640
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tSchm_RelationRowChanging != null)
				{
					this.tSchm_RelationRowChanging(this, new DataSetGES.af((DataSetGES.r)e.Row, e.Action));
				}
			}

			// Token: 0x0600031B RID: 795 RVA: 0x0001F473 File Offset: 0x0001D673
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tSchm_RelationRowDeleted != null)
				{
					this.tSchm_RelationRowDeleted(this, new DataSetGES.af((DataSetGES.r)e.Row, e.Action));
				}
			}

			// Token: 0x0600031C RID: 796 RVA: 0x0001F4A6 File Offset: 0x0001D6A6
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tSchm_RelationRowDeleting != null)
				{
					this.tSchm_RelationRowDeleting(this, new DataSetGES.af((DataSetGES.r)e.Row, e.Action));
				}
			}

			// Token: 0x0600031D RID: 797 RVA: 0x0001F4D9 File Offset: 0x0001D6D9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void b(DataSetGES.r A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x0600031E RID: 798 RVA: 0x0001F4E8 File Offset: 0x0001D6E8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSchm_RelationDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x0400023B RID: 571
			private DataColumn columnid;

			// Token: 0x0400023C RID: 572
			private DataColumn columnSourceObj;

			// Token: 0x0400023D RID: 573
			private DataColumn columnDestObj;

			// Token: 0x0400023E RID: 574
			private DataColumn columnEdge;
		}

		// Token: 0x0200005D RID: 93
		public class r : DataRow
		{
			// Token: 0x0600031F RID: 799 RVA: 0x0001F6DC File Offset: 0x0001D8DC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal r(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.tSchm_RelationDataTable)base.Table;
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x06000320 RID: 800 RVA: 0x0001F6F6 File Offset: 0x0001D8F6
			// (set) Token: 0x06000321 RID: 801 RVA: 0x0001F70E File Offset: 0x0001D90E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int id
			{
				get
				{
					return (int)base[this.a.idColumn];
				}
				set
				{
					base[this.a.idColumn] = value;
				}
			}

			// Token: 0x06000322 RID: 802 RVA: 0x0001F727 File Offset: 0x0001D927
			public int b()
			{
				return (int)base[this.a.SourceObjColumn];
			}

			// Token: 0x06000323 RID: 803 RVA: 0x0001F73F File Offset: 0x0001D93F
			public void b(int A_0)
			{
				base[this.a.SourceObjColumn] = A_0;
			}

			// Token: 0x06000324 RID: 804 RVA: 0x0001F758 File Offset: 0x0001D958
			public int c()
			{
				return (int)base[this.a.DestObjColumn];
			}

			// Token: 0x06000325 RID: 805 RVA: 0x0001F770 File Offset: 0x0001D970
			public void c(int A_0)
			{
				base[this.a.DestObjColumn] = A_0;
			}

			// Token: 0x06000326 RID: 806 RVA: 0x0001F78C File Offset: 0x0001D98C
			public int d()
			{
				int result;
				try
				{
					result = (int)base[this.a.EdgeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Edge' in table 'tSchm_Relation' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000327 RID: 807 RVA: 0x0001F7D0 File Offset: 0x0001D9D0
			public void d(int A_0)
			{
				base[this.a.EdgeColumn] = A_0;
			}

			// Token: 0x06000328 RID: 808 RVA: 0x0001F7E9 File Offset: 0x0001D9E9
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool e()
			{
				return base.IsNull(this.a.EdgeColumn);
			}

			// Token: 0x06000329 RID: 809 RVA: 0x0001F7FC File Offset: 0x0001D9FC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void f()
			{
				base[this.a.EdgeColumn] = Convert.DBNull;
			}

			// Token: 0x04000243 RID: 579
			private DataSetGES.tSchm_RelationDataTable a;
		}

		// Token: 0x0200005E RID: 94
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tL_RequestForRepairSchmObjListDataTable : TypedTableBase<DataSetGES.s>
		{
			// Token: 0x0600032A RID: 810 RVA: 0x0001F814 File Offset: 0x0001DA14
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tL_RequestForRepairSchmObjListDataTable()
			{
				base.TableName = "tL_RequestForRepairSchmObjList";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x0600032B RID: 811 RVA: 0x0001F83C File Offset: 0x0001DA3C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tL_RequestForRepairSchmObjListDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x0600032C RID: 812 RVA: 0x0001F8E4 File Offset: 0x0001DAE4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected tL_RequestForRepairSchmObjListDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.j();
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x0600032D RID: 813 RVA: 0x0001F8F4 File Offset: 0x0001DAF4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x0600032E RID: 814 RVA: 0x0001F8FC File Offset: 0x0001DAFC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idRequestColumn
			{
				get
				{
					return this.columnidRequest;
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x0600032F RID: 815 RVA: 0x0001F904 File Offset: 0x0001DB04
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idSchmObjColumn
			{
				get
				{
					return this.columnidSchmObj;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000330 RID: 816 RVA: 0x0001F90C File Offset: 0x0001DB0C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DateBegColumn
			{
				get
				{
					return this.columnDateBeg;
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000331 RID: 817 RVA: 0x0001F914 File Offset: 0x0001DB14
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DateEndColumn
			{
				get
				{
					return this.columnDateEnd;
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000332 RID: 818 RVA: 0x0001F91C File Offset: 0x0001DB1C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DurationColumn
			{
				get
				{
					return this.columnDuration;
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000333 RID: 819 RVA: 0x0001F924 File Offset: 0x0001DB24
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NumColumn
			{
				get
				{
					return this.columnNum;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000334 RID: 820 RVA: 0x0001F92C File Offset: 0x0001DB2C
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

			// Token: 0x1700008F RID: 143
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.s this[int A_0]
			{
				get
				{
					return (DataSetGES.s)base.Rows[A_0];
				}
			}

			// Token: 0x14000018 RID: 24
			// (add) Token: 0x06000336 RID: 822 RVA: 0x0001F94C File Offset: 0x0001DB4C
			// (remove) Token: 0x06000337 RID: 823 RVA: 0x0001F984 File Offset: 0x0001DB84
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.e tL_RequestForRepairSchmObjListRowChanging;

			// Token: 0x14000019 RID: 25
			// (add) Token: 0x06000338 RID: 824 RVA: 0x0001F9BC File Offset: 0x0001DBBC
			// (remove) Token: 0x06000339 RID: 825 RVA: 0x0001F9F4 File Offset: 0x0001DBF4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.e tL_RequestForRepairSchmObjListRowChanged;

			// Token: 0x1400001A RID: 26
			// (add) Token: 0x0600033A RID: 826 RVA: 0x0001FA2C File Offset: 0x0001DC2C
			// (remove) Token: 0x0600033B RID: 827 RVA: 0x0001FA64 File Offset: 0x0001DC64
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.e tL_RequestForRepairSchmObjListRowDeleting;

			// Token: 0x1400001B RID: 27
			// (add) Token: 0x0600033C RID: 828 RVA: 0x0001FA9C File Offset: 0x0001DC9C
			// (remove) Token: 0x0600033D RID: 829 RVA: 0x0001FAD4 File Offset: 0x0001DCD4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.e tL_RequestForRepairSchmObjListRowDeleted;

			// Token: 0x0600033E RID: 830 RVA: 0x0001FB09 File Offset: 0x0001DD09
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void a(DataSetGES.s A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x0600033F RID: 831 RVA: 0x0001FB18 File Offset: 0x0001DD18
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.s a(int A_0, int A_1, DateTime A_2, DateTime A_3, string A_4, short A_5)
			{
				DataSetGES.s s = (DataSetGES.s)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					A_0,
					A_1,
					A_2,
					A_3,
					A_4,
					A_5
				};
				s.ItemArray = itemArray;
				base.Rows.Add(s);
				return s;
			}

			// Token: 0x06000340 RID: 832 RVA: 0x0001FB80 File Offset: 0x0001DD80
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.s b(int A_0)
			{
				return (DataSetGES.s)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x06000341 RID: 833 RVA: 0x0001FBA1 File Offset: 0x0001DDA1
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetGES.tL_RequestForRepairSchmObjListDataTable tL_RequestForRepairSchmObjListDataTable = (DataSetGES.tL_RequestForRepairSchmObjListDataTable)base.Clone();
				tL_RequestForRepairSchmObjListDataTable.j();
				return tL_RequestForRepairSchmObjListDataTable;
			}

			// Token: 0x06000342 RID: 834 RVA: 0x0001FBB4 File Offset: 0x0001DDB4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.tL_RequestForRepairSchmObjListDataTable();
			}

			// Token: 0x06000343 RID: 835 RVA: 0x0001FBBC File Offset: 0x0001DDBC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void j()
			{
				this.columnid = base.Columns["id"];
				this.columnidRequest = base.Columns["idRequest"];
				this.columnidSchmObj = base.Columns["idSchmObj"];
				this.columnDateBeg = base.Columns["DateBeg"];
				this.columnDateEnd = base.Columns["DateEnd"];
				this.columnDuration = base.Columns["Duration"];
				this.columnNum = base.Columns["Num"];
			}

			// Token: 0x06000344 RID: 836 RVA: 0x0001FC64 File Offset: 0x0001DE64
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void a()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidRequest = new DataColumn("idRequest", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidRequest);
				this.columnidSchmObj = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidSchmObj);
				this.columnDateBeg = new DataColumn("DateBeg", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateBeg);
				this.columnDateEnd = new DataColumn("DateEnd", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateEnd);
				this.columnDuration = new DataColumn("Duration", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDuration);
				this.columnNum = new DataColumn("Num", typeof(short), null, MappingType.Element);
				base.Columns.Add(this.columnNum);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnid
				}, true));
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = -1L;
				this.columnid.AutoIncrementStep = -1L;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
				this.columnidRequest.AllowDBNull = false;
				this.columnidSchmObj.AllowDBNull = false;
				this.columnDateBeg.AllowDBNull = false;
				this.columnDateEnd.AllowDBNull = false;
				this.columnDuration.AllowDBNull = false;
				this.columnDuration.MaxLength = 100;
				this.columnNum.AllowDBNull = false;
			}

			// Token: 0x06000345 RID: 837 RVA: 0x0001FE70 File Offset: 0x0001E070
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.s k()
			{
				return (DataSetGES.s)base.NewRow();
			}

			// Token: 0x06000346 RID: 838 RVA: 0x0001FE7D File Offset: 0x0001E07D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.s(builder);
			}

			// Token: 0x06000347 RID: 839 RVA: 0x0001FE85 File Offset: 0x0001E085
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.s);
			}

			// Token: 0x06000348 RID: 840 RVA: 0x0001FE91 File Offset: 0x0001E091
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tL_RequestForRepairSchmObjListRowChanged != null)
				{
					this.tL_RequestForRepairSchmObjListRowChanged(this, new DataSetGES.ag((DataSetGES.s)e.Row, e.Action));
				}
			}

			// Token: 0x06000349 RID: 841 RVA: 0x0001FEC4 File Offset: 0x0001E0C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tL_RequestForRepairSchmObjListRowChanging != null)
				{
					this.tL_RequestForRepairSchmObjListRowChanging(this, new DataSetGES.ag((DataSetGES.s)e.Row, e.Action));
				}
			}

			// Token: 0x0600034A RID: 842 RVA: 0x0001FEF7 File Offset: 0x0001E0F7
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tL_RequestForRepairSchmObjListRowDeleted != null)
				{
					this.tL_RequestForRepairSchmObjListRowDeleted(this, new DataSetGES.ag((DataSetGES.s)e.Row, e.Action));
				}
			}

			// Token: 0x0600034B RID: 843 RVA: 0x0001FF2A File Offset: 0x0001E12A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tL_RequestForRepairSchmObjListRowDeleting != null)
				{
					this.tL_RequestForRepairSchmObjListRowDeleting(this, new DataSetGES.ag((DataSetGES.s)e.Row, e.Action));
				}
			}

			// Token: 0x0600034C RID: 844 RVA: 0x0001FF5D File Offset: 0x0001E15D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void b(DataSetGES.s A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x0600034D RID: 845 RVA: 0x0001FF6C File Offset: 0x0001E16C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tL_RequestForRepairSchmObjListDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000244 RID: 580
			private DataColumn columnid;

			// Token: 0x04000245 RID: 581
			private DataColumn columnidRequest;

			// Token: 0x04000246 RID: 582
			private DataColumn columnidSchmObj;

			// Token: 0x04000247 RID: 583
			private DataColumn columnDateBeg;

			// Token: 0x04000248 RID: 584
			private DataColumn columnDateEnd;

			// Token: 0x04000249 RID: 585
			private DataColumn columnDuration;

			// Token: 0x0400024A RID: 586
			private DataColumn columnNum;
		}

		// Token: 0x0200005F RID: 95
		public class s : DataRow
		{
			// Token: 0x0600034E RID: 846 RVA: 0x00020160 File Offset: 0x0001E360
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal s(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.tL_RequestForRepairSchmObjListDataTable)base.Table;
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x0600034F RID: 847 RVA: 0x0002017A File Offset: 0x0001E37A
			// (set) Token: 0x06000350 RID: 848 RVA: 0x00020192 File Offset: 0x0001E392
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int id
			{
				get
				{
					return (int)base[this.a.idColumn];
				}
				set
				{
					base[this.a.idColumn] = value;
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x06000351 RID: 849 RVA: 0x000201AB File Offset: 0x0001E3AB
			// (set) Token: 0x06000352 RID: 850 RVA: 0x000201C3 File Offset: 0x0001E3C3
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idRequest
			{
				get
				{
					return (int)base[this.a.idRequestColumn];
				}
				set
				{
					base[this.a.idRequestColumn] = value;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x06000353 RID: 851 RVA: 0x000201DC File Offset: 0x0001E3DC
			// (set) Token: 0x06000354 RID: 852 RVA: 0x000201F4 File Offset: 0x0001E3F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idSchmObj
			{
				get
				{
					return (int)base[this.a.idSchmObjColumn];
				}
				set
				{
					base[this.a.idSchmObjColumn] = value;
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000355 RID: 853 RVA: 0x0002020D File Offset: 0x0001E40D
			// (set) Token: 0x06000356 RID: 854 RVA: 0x00020225 File Offset: 0x0001E425
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime DateBeg
			{
				get
				{
					return (DateTime)base[this.a.DateBegColumn];
				}
				set
				{
					base[this.a.DateBegColumn] = value;
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000357 RID: 855 RVA: 0x0002023E File Offset: 0x0001E43E
			// (set) Token: 0x06000358 RID: 856 RVA: 0x00020256 File Offset: 0x0001E456
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DateTime DateEnd
			{
				get
				{
					return (DateTime)base[this.a.DateEndColumn];
				}
				set
				{
					base[this.a.DateEndColumn] = value;
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x06000359 RID: 857 RVA: 0x0002026F File Offset: 0x0001E46F
			// (set) Token: 0x0600035A RID: 858 RVA: 0x00020287 File Offset: 0x0001E487
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Duration
			{
				get
				{
					return (string)base[this.a.DurationColumn];
				}
				set
				{
					base[this.a.DurationColumn] = value;
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x0600035B RID: 859 RVA: 0x0002029B File Offset: 0x0001E49B
			// (set) Token: 0x0600035C RID: 860 RVA: 0x000202B3 File Offset: 0x0001E4B3
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public short Num
			{
				get
				{
					return (short)base[this.a.NumColumn];
				}
				set
				{
					base[this.a.NumColumn] = value;
				}
			}

			// Token: 0x0400024F RID: 591
			private DataSetGES.tL_RequestForRepairSchmObjListDataTable a;
		}

		// Token: 0x02000060 RID: 96
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tJ_RequestForRepairDataTable : TypedTableBase<DataSetGES.t>
		{
			// Token: 0x0600035D RID: 861 RVA: 0x000202CC File Offset: 0x0001E4CC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tJ_RequestForRepairDataTable()
			{
				base.TableName = "tJ_RequestForRepair";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x0600035E RID: 862 RVA: 0x000202F4 File Offset: 0x0001E4F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tJ_RequestForRepairDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x0600035F RID: 863 RVA: 0x0002039C File Offset: 0x0001E59C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected tJ_RequestForRepairDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.ai();
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x06000360 RID: 864 RVA: 0x000203AC File Offset: 0x0001E5AC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x06000361 RID: 865 RVA: 0x000203B4 File Offset: 0x0001E5B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn numColumn
			{
				get
				{
					return this.columnnum;
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x06000362 RID: 866 RVA: 0x000203BC File Offset: 0x0001E5BC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dateCreateColumn
			{
				get
				{
					return this.columndateCreate;
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x06000363 RID: 867 RVA: 0x000203C4 File Offset: 0x0001E5C4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idWorkerColumn
			{
				get
				{
					return this.columnidWorker;
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x06000364 RID: 868 RVA: 0x000203CC File Offset: 0x0001E5CC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn reguestFiledColumn
			{
				get
				{
					return this.columnreguestFiled;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x06000365 RID: 869 RVA: 0x000203D4 File Offset: 0x0001E5D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idSRColumn
			{
				get
				{
					return this.columnidSR;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x06000366 RID: 870 RVA: 0x000203DC File Offset: 0x0001E5DC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn schmObjColumn
			{
				get
				{
					return this.columnschmObj;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x06000367 RID: 871 RVA: 0x000203E4 File Offset: 0x0001E5E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn PurposeColumn
			{
				get
				{
					return this.columnPurpose;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x06000368 RID: 872 RVA: 0x000203EC File Offset: 0x0001E5EC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IsPlannedColumn
			{
				get
				{
					return this.columnIsPlanned;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x06000369 RID: 873 RVA: 0x000203F4 File Offset: 0x0001E5F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CrashColumn
			{
				get
				{
					return this.columnCrash;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x0600036A RID: 874 RVA: 0x000203FC File Offset: 0x0001E5FC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AgreeWithColumn
			{
				get
				{
					return this.columnAgreeWith;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x0600036B RID: 875 RVA: 0x00020404 File Offset: 0x0001E604
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CommentColumn
			{
				get
				{
					return this.columnComment;
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x0600036C RID: 876 RVA: 0x0002040C File Offset: 0x0001E60C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AddressColumn
			{
				get
				{
					return this.columnAddress;
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x0600036D RID: 877 RVA: 0x00020414 File Offset: 0x0001E614
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AgreedColumn
			{
				get
				{
					return this.columnAgreed;
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x0600036E RID: 878 RVA: 0x0002041C File Offset: 0x0001E61C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DateAgreedColumn
			{
				get
				{
					return this.columnDateAgreed;
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x0600036F RID: 879 RVA: 0x00020424 File Offset: 0x0001E624
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn WorkerAgreedColumn
			{
				get
				{
					return this.columnWorkerAgreed;
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x06000370 RID: 880 RVA: 0x0002042C File Offset: 0x0001E62C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn iddivisionColumn
			{
				get
				{
					return this.columniddivision;
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x06000371 RID: 881 RVA: 0x00020434 File Offset: 0x0001E634
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idUserCreateColumn
			{
				get
				{
					return this.columnidUserCreate;
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x06000372 RID: 882 RVA: 0x0002043C File Offset: 0x0001E63C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn deletedColumn
			{
				get
				{
					return this.columndeleted;
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000373 RID: 883 RVA: 0x00020444 File Offset: 0x0001E644
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idRegionColumn
			{
				get
				{
					return this.columnidRegion;
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000374 RID: 884 RVA: 0x0002044C File Offset: 0x0001E64C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn typeDisableColumn
			{
				get
				{
					return this.columntypeDisable;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000375 RID: 885 RVA: 0x00020454 File Offset: 0x0001E654
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn dateFactEndColumn
			{
				get
				{
					return this.columndateFactEnd;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000376 RID: 886 RVA: 0x0002045C File Offset: 0x0001E65C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn organizationColumn
			{
				get
				{
					return this.columnorganization;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000377 RID: 887 RVA: 0x00020464 File Offset: 0x0001E664
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn performerOrganizationColumn
			{
				get
				{
					return this.columnperformerOrganization;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x06000378 RID: 888 RVA: 0x0002046C File Offset: 0x0001E66C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn groupWorksColumn
			{
				get
				{
					return this.columngroupWorks;
				}
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000379 RID: 889 RVA: 0x00020474 File Offset: 0x0001E674
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn statusColumn
			{
				get
				{
					return this.columnstatus;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x0600037A RID: 890 RVA: 0x0002047C File Offset: 0x0001E67C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idRICColumn
			{
				get
				{
					return this.columnidRIC;
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x0600037B RID: 891 RVA: 0x00020484 File Offset: 0x0001E684
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn messageRICColumn
			{
				get
				{
					return this.columnmessageRIC;
				}
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x0600037C RID: 892 RVA: 0x0002048C File Offset: 0x0001E68C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn isSendColumn
			{
				get
				{
					return this.columnisSend;
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x0600037D RID: 893 RVA: 0x00020494 File Offset: 0x0001E694
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTypeDamageColumn
			{
				get
				{
					return this.columnidTypeDamage;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x0600037E RID: 894 RVA: 0x0002049C File Offset: 0x0001E69C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SendSiteColumn
			{
				get
				{
					return this.columnSendSite;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x0600037F RID: 895 RVA: 0x000204A4 File Offset: 0x0001E6A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn LogXmlColumn
			{
				get
				{
					return this.columnLogXml;
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000380 RID: 896 RVA: 0x000204AC File Offset: 0x0001E6AC
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

			// Token: 0x170000B8 RID: 184
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.t this[int A_0]
			{
				get
				{
					return (DataSetGES.t)base.Rows[A_0];
				}
			}

			// Token: 0x1400001C RID: 28
			// (add) Token: 0x06000382 RID: 898 RVA: 0x000204CC File Offset: 0x0001E6CC
			// (remove) Token: 0x06000383 RID: 899 RVA: 0x00020504 File Offset: 0x0001E704
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.f tJ_RequestForRepairRowChanging;

			// Token: 0x1400001D RID: 29
			// (add) Token: 0x06000384 RID: 900 RVA: 0x0002053C File Offset: 0x0001E73C
			// (remove) Token: 0x06000385 RID: 901 RVA: 0x00020574 File Offset: 0x0001E774
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.f tJ_RequestForRepairRowChanged;

			// Token: 0x1400001E RID: 30
			// (add) Token: 0x06000386 RID: 902 RVA: 0x000205AC File Offset: 0x0001E7AC
			// (remove) Token: 0x06000387 RID: 903 RVA: 0x000205E4 File Offset: 0x0001E7E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.f tJ_RequestForRepairRowDeleting;

			// Token: 0x1400001F RID: 31
			// (add) Token: 0x06000388 RID: 904 RVA: 0x0002061C File Offset: 0x0001E81C
			// (remove) Token: 0x06000389 RID: 905 RVA: 0x00020654 File Offset: 0x0001E854
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.f tJ_RequestForRepairRowDeleted;

			// Token: 0x0600038A RID: 906 RVA: 0x00020689 File Offset: 0x0001E889
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void a(DataSetGES.t A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x0600038B RID: 907 RVA: 0x00020698 File Offset: 0x0001E898
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.t a(int A_0, DateTime A_1, int A_2, string A_3, int A_4, string A_5, string A_6, bool A_7, bool A_8, string A_9, string A_10, string A_11, bool A_12, DateTime A_13, int A_14, int A_15, int A_16, bool A_17, int A_18, int A_19, DateTime A_20, int A_21, int A_22, int A_23, int A_24, int A_25, string A_26, bool A_27, string A_28, bool A_29, string A_30)
			{
				DataSetGES.t t = (DataSetGES.t)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					A_0,
					A_1,
					A_2,
					A_3,
					A_4,
					A_5,
					A_6,
					A_7,
					A_8,
					A_9,
					A_10,
					A_11,
					A_12,
					A_13,
					A_14,
					A_15,
					A_16,
					A_17,
					A_18,
					A_19,
					A_20,
					A_21,
					A_22,
					A_23,
					A_24,
					A_25,
					A_26,
					A_27,
					A_28,
					A_29,
					A_30
				};
				t.ItemArray = itemArray;
				base.Rows.Add(t);
				return t;
			}

			// Token: 0x0600038C RID: 908 RVA: 0x000207EA File Offset: 0x0001E9EA
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.t b(int A_0)
			{
				return (DataSetGES.t)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x0600038D RID: 909 RVA: 0x0002080B File Offset: 0x0001EA0B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetGES.tJ_RequestForRepairDataTable tJ_RequestForRepairDataTable = (DataSetGES.tJ_RequestForRepairDataTable)base.Clone();
				tJ_RequestForRepairDataTable.ai();
				return tJ_RequestForRepairDataTable;
			}

			// Token: 0x0600038E RID: 910 RVA: 0x0002081E File Offset: 0x0001EA1E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.tJ_RequestForRepairDataTable();
			}

			// Token: 0x0600038F RID: 911 RVA: 0x00020828 File Offset: 0x0001EA28
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void ai()
			{
				this.columnid = base.Columns["id"];
				this.columnnum = base.Columns["num"];
				this.columndateCreate = base.Columns["dateCreate"];
				this.columnidWorker = base.Columns["idWorker"];
				this.columnreguestFiled = base.Columns["reguestFiled"];
				this.columnidSR = base.Columns["idSR"];
				this.columnschmObj = base.Columns["schmObj"];
				this.columnPurpose = base.Columns["Purpose"];
				this.columnIsPlanned = base.Columns["IsPlanned"];
				this.columnCrash = base.Columns["Crash"];
				this.columnAgreeWith = base.Columns["AgreeWith"];
				this.columnComment = base.Columns["Comment"];
				this.columnAddress = base.Columns["Address"];
				this.columnAgreed = base.Columns["Agreed"];
				this.columnDateAgreed = base.Columns["DateAgreed"];
				this.columnWorkerAgreed = base.Columns["WorkerAgreed"];
				this.columniddivision = base.Columns["iddivision"];
				this.columnidUserCreate = base.Columns["idUserCreate"];
				this.columndeleted = base.Columns["deleted"];
				this.columnidRegion = base.Columns["idRegion"];
				this.columntypeDisable = base.Columns["typeDisable"];
				this.columndateFactEnd = base.Columns["dateFactEnd"];
				this.columnorganization = base.Columns["organization"];
				this.columnperformerOrganization = base.Columns["performerOrganization"];
				this.columngroupWorks = base.Columns["groupWorks"];
				this.columnstatus = base.Columns["status"];
				this.columnidRIC = base.Columns["idRIC"];
				this.columnmessageRIC = base.Columns["messageRIC"];
				this.columnisSend = base.Columns["isSend"];
				this.columnidTypeDamage = base.Columns["idTypeDamage"];
				this.columnSendSite = base.Columns["SendSite"];
				this.columnLogXml = base.Columns["LogXml"];
			}

			// Token: 0x06000390 RID: 912 RVA: 0x00020AF8 File Offset: 0x0001ECF8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void a()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnnum = new DataColumn("num", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnnum);
				this.columndateCreate = new DataColumn("dateCreate", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columndateCreate);
				this.columnidWorker = new DataColumn("idWorker", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidWorker);
				this.columnreguestFiled = new DataColumn("reguestFiled", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnreguestFiled);
				this.columnidSR = new DataColumn("idSR", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidSR);
				this.columnschmObj = new DataColumn("schmObj", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnschmObj);
				this.columnPurpose = new DataColumn("Purpose", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPurpose);
				this.columnIsPlanned = new DataColumn("IsPlanned", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnIsPlanned);
				this.columnCrash = new DataColumn("Crash", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnCrash);
				this.columnAgreeWith = new DataColumn("AgreeWith", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAgreeWith);
				this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnComment);
				this.columnAddress = new DataColumn("Address", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAddress);
				this.columnAgreed = new DataColumn("Agreed", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnAgreed);
				this.columnDateAgreed = new DataColumn("DateAgreed", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateAgreed);
				this.columnWorkerAgreed = new DataColumn("WorkerAgreed", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnWorkerAgreed);
				this.columniddivision = new DataColumn("iddivision", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columniddivision);
				this.columnidUserCreate = new DataColumn("idUserCreate", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidUserCreate);
				this.columndeleted = new DataColumn("deleted", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columndeleted);
				this.columnidRegion = new DataColumn("idRegion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidRegion);
				this.columntypeDisable = new DataColumn("typeDisable", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columntypeDisable);
				this.columndateFactEnd = new DataColumn("dateFactEnd", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columndateFactEnd);
				this.columnorganization = new DataColumn("organization", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnorganization);
				this.columnperformerOrganization = new DataColumn("performerOrganization", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnperformerOrganization);
				this.columngroupWorks = new DataColumn("groupWorks", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columngroupWorks);
				this.columnstatus = new DataColumn("status", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnstatus);
				this.columnidRIC = new DataColumn("idRIC", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidRIC);
				this.columnmessageRIC = new DataColumn("messageRIC", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnmessageRIC);
				this.columnisSend = new DataColumn("isSend", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnisSend);
				this.columnidTypeDamage = new DataColumn("idTypeDamage", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnidTypeDamage);
				this.columnSendSite = new DataColumn("SendSite", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnSendSite);
				this.columnLogXml = new DataColumn("LogXml", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLogXml);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnid
				}, true));
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = -1L;
				this.columnid.AutoIncrementStep = -1L;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
				this.columnnum.AllowDBNull = false;
				this.columndateCreate.AllowDBNull = false;
				this.columnreguestFiled.AllowDBNull = false;
				this.columnreguestFiled.MaxLength = 256;
				this.columnidSR.AllowDBNull = false;
				this.columnschmObj.AllowDBNull = false;
				this.columnschmObj.MaxLength = 256;
				this.columnPurpose.AllowDBNull = false;
				this.columnPurpose.MaxLength = 256;
				this.columnIsPlanned.AllowDBNull = false;
				this.columnAgreeWith.MaxLength = 256;
				this.columnComment.MaxLength = 256;
				this.columnAgreed.AllowDBNull = false;
				this.columniddivision.AllowDBNull = false;
				this.columndeleted.DefaultValue = false;
			}

			// Token: 0x06000391 RID: 913 RVA: 0x000211E1 File Offset: 0x0001F3E1
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.t aj()
			{
				return (DataSetGES.t)base.NewRow();
			}

			// Token: 0x06000392 RID: 914 RVA: 0x000211EE File Offset: 0x0001F3EE
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.t(builder);
			}

			// Token: 0x06000393 RID: 915 RVA: 0x000211F6 File Offset: 0x0001F3F6
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.t);
			}

			// Token: 0x06000394 RID: 916 RVA: 0x00021202 File Offset: 0x0001F402
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tJ_RequestForRepairRowChanged != null)
				{
					this.tJ_RequestForRepairRowChanged(this, new DataSetGES.ah((DataSetGES.t)e.Row, e.Action));
				}
			}

			// Token: 0x06000395 RID: 917 RVA: 0x00021235 File Offset: 0x0001F435
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tJ_RequestForRepairRowChanging != null)
				{
					this.tJ_RequestForRepairRowChanging(this, new DataSetGES.ah((DataSetGES.t)e.Row, e.Action));
				}
			}

			// Token: 0x06000396 RID: 918 RVA: 0x00021268 File Offset: 0x0001F468
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tJ_RequestForRepairRowDeleted != null)
				{
					this.tJ_RequestForRepairRowDeleted(this, new DataSetGES.ah((DataSetGES.t)e.Row, e.Action));
				}
			}

			// Token: 0x06000397 RID: 919 RVA: 0x0002129B File Offset: 0x0001F49B
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tJ_RequestForRepairRowDeleting != null)
				{
					this.tJ_RequestForRepairRowDeleting(this, new DataSetGES.ah((DataSetGES.t)e.Row, e.Action));
				}
			}

			// Token: 0x06000398 RID: 920 RVA: 0x000212CE File Offset: 0x0001F4CE
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void b(DataSetGES.t A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x06000399 RID: 921 RVA: 0x000212DC File Offset: 0x0001F4DC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tJ_RequestForRepairDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000250 RID: 592
			private DataColumn columnid;

			// Token: 0x04000251 RID: 593
			private DataColumn columnnum;

			// Token: 0x04000252 RID: 594
			private DataColumn columndateCreate;

			// Token: 0x04000253 RID: 595
			private DataColumn columnidWorker;

			// Token: 0x04000254 RID: 596
			private DataColumn columnreguestFiled;

			// Token: 0x04000255 RID: 597
			private DataColumn columnidSR;

			// Token: 0x04000256 RID: 598
			private DataColumn columnschmObj;

			// Token: 0x04000257 RID: 599
			private DataColumn columnPurpose;

			// Token: 0x04000258 RID: 600
			private DataColumn columnIsPlanned;

			// Token: 0x04000259 RID: 601
			private DataColumn columnCrash;

			// Token: 0x0400025A RID: 602
			private DataColumn columnAgreeWith;

			// Token: 0x0400025B RID: 603
			private DataColumn columnComment;

			// Token: 0x0400025C RID: 604
			private DataColumn columnAddress;

			// Token: 0x0400025D RID: 605
			private DataColumn columnAgreed;

			// Token: 0x0400025E RID: 606
			private DataColumn columnDateAgreed;

			// Token: 0x0400025F RID: 607
			private DataColumn columnWorkerAgreed;

			// Token: 0x04000260 RID: 608
			private DataColumn columniddivision;

			// Token: 0x04000261 RID: 609
			private DataColumn columnidUserCreate;

			// Token: 0x04000262 RID: 610
			private DataColumn columndeleted;

			// Token: 0x04000263 RID: 611
			private DataColumn columnidRegion;

			// Token: 0x04000264 RID: 612
			private DataColumn columntypeDisable;

			// Token: 0x04000265 RID: 613
			private DataColumn columndateFactEnd;

			// Token: 0x04000266 RID: 614
			private DataColumn columnorganization;

			// Token: 0x04000267 RID: 615
			private DataColumn columnperformerOrganization;

			// Token: 0x04000268 RID: 616
			private DataColumn columngroupWorks;

			// Token: 0x04000269 RID: 617
			private DataColumn columnstatus;

			// Token: 0x0400026A RID: 618
			private DataColumn columnidRIC;

			// Token: 0x0400026B RID: 619
			private DataColumn columnmessageRIC;

			// Token: 0x0400026C RID: 620
			private DataColumn columnisSend;

			// Token: 0x0400026D RID: 621
			private DataColumn columnidTypeDamage;

			// Token: 0x0400026E RID: 622
			private DataColumn columnSendSite;

			// Token: 0x0400026F RID: 623
			private DataColumn columnLogXml;
		}

		// Token: 0x02000061 RID: 97
		public class t : DataRow
		{
			// Token: 0x0600039A RID: 922 RVA: 0x000214D0 File Offset: 0x0001F6D0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal t(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.tJ_RequestForRepairDataTable)base.Table;
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x0600039B RID: 923 RVA: 0x000214EA File Offset: 0x0001F6EA
			// (set) Token: 0x0600039C RID: 924 RVA: 0x00021502 File Offset: 0x0001F702
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int id
			{
				get
				{
					return (int)base[this.a.idColumn];
				}
				set
				{
					base[this.a.idColumn] = value;
				}
			}

			// Token: 0x0600039D RID: 925 RVA: 0x0002151B File Offset: 0x0001F71B
			public int b()
			{
				return (int)base[this.a.numColumn];
			}

			// Token: 0x0600039E RID: 926 RVA: 0x00021533 File Offset: 0x0001F733
			public void b(int A_0)
			{
				base[this.a.numColumn] = A_0;
			}

			// Token: 0x0600039F RID: 927 RVA: 0x0002154C File Offset: 0x0001F74C
			public DateTime c()
			{
				return (DateTime)base[this.a.dateCreateColumn];
			}

			// Token: 0x060003A0 RID: 928 RVA: 0x00021564 File Offset: 0x0001F764
			public void a(DateTime A_0)
			{
				base[this.a.dateCreateColumn] = A_0;
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x060003A1 RID: 929 RVA: 0x00021580 File Offset: 0x0001F780
			// (set) Token: 0x060003A2 RID: 930 RVA: 0x000215C4 File Offset: 0x0001F7C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idWorker
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.a.idWorkerColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idWorker' in table 'tJ_RequestForRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.idWorkerColumn] = value;
				}
			}

			// Token: 0x060003A3 RID: 931 RVA: 0x000215DD File Offset: 0x0001F7DD
			public string e()
			{
				return (string)base[this.a.reguestFiledColumn];
			}

			// Token: 0x060003A4 RID: 932 RVA: 0x000215F5 File Offset: 0x0001F7F5
			public void a(string value)
			{
				base[this.a.reguestFiledColumn] = value;
			}

			// Token: 0x060003A5 RID: 933 RVA: 0x00021609 File Offset: 0x0001F809
			public int f()
			{
				return (int)base[this.a.idSRColumn];
			}

			// Token: 0x060003A6 RID: 934 RVA: 0x00021621 File Offset: 0x0001F821
			public void d(int A_0)
			{
				base[this.a.idSRColumn] = A_0;
			}

			// Token: 0x060003A7 RID: 935 RVA: 0x0002163A File Offset: 0x0001F83A
			public string g()
			{
				return (string)base[this.a.schmObjColumn];
			}

			// Token: 0x060003A8 RID: 936 RVA: 0x00021652 File Offset: 0x0001F852
			public void b(string value)
			{
				base[this.a.schmObjColumn] = value;
			}

			// Token: 0x060003A9 RID: 937 RVA: 0x00021666 File Offset: 0x0001F866
			public string h()
			{
				return (string)base[this.a.PurposeColumn];
			}

			// Token: 0x060003AA RID: 938 RVA: 0x0002167E File Offset: 0x0001F87E
			public void c(string value)
			{
				base[this.a.PurposeColumn] = value;
			}

			// Token: 0x060003AB RID: 939 RVA: 0x00021692 File Offset: 0x0001F892
			public bool i()
			{
				return (bool)base[this.a.IsPlannedColumn];
			}

			// Token: 0x060003AC RID: 940 RVA: 0x000216AA File Offset: 0x0001F8AA
			public void a(bool A_0)
			{
				base[this.a.IsPlannedColumn] = A_0;
			}

			// Token: 0x060003AD RID: 941 RVA: 0x000216C4 File Offset: 0x0001F8C4
			public bool j()
			{
				bool result;
				try
				{
					result = (bool)base[this.a.CrashColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Crash' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003AE RID: 942 RVA: 0x00021708 File Offset: 0x0001F908
			public void b(bool A_0)
			{
				base[this.a.CrashColumn] = A_0;
			}

			// Token: 0x060003AF RID: 943 RVA: 0x00021724 File Offset: 0x0001F924
			public string k()
			{
				string result;
				try
				{
					result = (string)base[this.a.AgreeWithColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'AgreeWith' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003B0 RID: 944 RVA: 0x00021768 File Offset: 0x0001F968
			public void d(string value)
			{
				base[this.a.AgreeWithColumn] = value;
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x060003B1 RID: 945 RVA: 0x0002177C File Offset: 0x0001F97C
			// (set) Token: 0x060003B2 RID: 946 RVA: 0x000217C0 File Offset: 0x0001F9C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Comment
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.a.CommentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Comment' in table 'tJ_RequestForRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.CommentColumn] = value;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x060003B3 RID: 947 RVA: 0x000217D4 File Offset: 0x0001F9D4
			// (set) Token: 0x060003B4 RID: 948 RVA: 0x00021818 File Offset: 0x0001FA18
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Address
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.a.AddressColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Address' in table 'tJ_RequestForRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.AddressColumn] = value;
				}
			}

			// Token: 0x060003B5 RID: 949 RVA: 0x0002182C File Offset: 0x0001FA2C
			public bool n()
			{
				return (bool)base[this.a.AgreedColumn];
			}

			// Token: 0x060003B6 RID: 950 RVA: 0x00021844 File Offset: 0x0001FA44
			public void c(bool A_0)
			{
				base[this.a.AgreedColumn] = A_0;
			}

			// Token: 0x060003B7 RID: 951 RVA: 0x00021860 File Offset: 0x0001FA60
			public DateTime o()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.a.DateAgreedColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateAgreed' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003B8 RID: 952 RVA: 0x000218A4 File Offset: 0x0001FAA4
			public void b(DateTime A_0)
			{
				base[this.a.DateAgreedColumn] = A_0;
			}

			// Token: 0x060003B9 RID: 953 RVA: 0x000218C0 File Offset: 0x0001FAC0
			public int p()
			{
				int result;
				try
				{
					result = (int)base[this.a.WorkerAgreedColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'WorkerAgreed' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003BA RID: 954 RVA: 0x00021904 File Offset: 0x0001FB04
			public void e(int A_0)
			{
				base[this.a.WorkerAgreedColumn] = A_0;
			}

			// Token: 0x060003BB RID: 955 RVA: 0x0002191D File Offset: 0x0001FB1D
			public int q()
			{
				return (int)base[this.a.iddivisionColumn];
			}

			// Token: 0x060003BC RID: 956 RVA: 0x00021935 File Offset: 0x0001FB35
			public void f(int A_0)
			{
				base[this.a.iddivisionColumn] = A_0;
			}

			// Token: 0x060003BD RID: 957 RVA: 0x00021950 File Offset: 0x0001FB50
			public int r()
			{
				int result;
				try
				{
					result = (int)base[this.a.idUserCreateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idUserCreate' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003BE RID: 958 RVA: 0x00021994 File Offset: 0x0001FB94
			public void g(int A_0)
			{
				base[this.a.idUserCreateColumn] = A_0;
			}

			// Token: 0x060003BF RID: 959 RVA: 0x000219B0 File Offset: 0x0001FBB0
			public bool s()
			{
				bool result;
				try
				{
					result = (bool)base[this.a.deletedColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'deleted' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003C0 RID: 960 RVA: 0x000219F4 File Offset: 0x0001FBF4
			public void d(bool A_0)
			{
				base[this.a.deletedColumn] = A_0;
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x00021A10 File Offset: 0x0001FC10
			public int t()
			{
				int result;
				try
				{
					result = (int)base[this.a.idRegionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idRegion' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003C2 RID: 962 RVA: 0x00021A54 File Offset: 0x0001FC54
			public void h(int A_0)
			{
				base[this.a.idRegionColumn] = A_0;
			}

			// Token: 0x060003C3 RID: 963 RVA: 0x00021A70 File Offset: 0x0001FC70
			public int u()
			{
				int result;
				try
				{
					result = (int)base[this.a.typeDisableColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typeDisable' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003C4 RID: 964 RVA: 0x00021AB4 File Offset: 0x0001FCB4
			public void i(int A_0)
			{
				base[this.a.typeDisableColumn] = A_0;
			}

			// Token: 0x060003C5 RID: 965 RVA: 0x00021AD0 File Offset: 0x0001FCD0
			public DateTime v()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.a.dateFactEndColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateFactEnd' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003C6 RID: 966 RVA: 0x00021B14 File Offset: 0x0001FD14
			public void c(DateTime A_0)
			{
				base[this.a.dateFactEndColumn] = A_0;
			}

			// Token: 0x060003C7 RID: 967 RVA: 0x00021B30 File Offset: 0x0001FD30
			public int w()
			{
				int result;
				try
				{
					result = (int)base[this.a.organizationColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'organization' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003C8 RID: 968 RVA: 0x00021B74 File Offset: 0x0001FD74
			public void j(int A_0)
			{
				base[this.a.organizationColumn] = A_0;
			}

			// Token: 0x060003C9 RID: 969 RVA: 0x00021B90 File Offset: 0x0001FD90
			public int x()
			{
				int result;
				try
				{
					result = (int)base[this.a.performerOrganizationColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'performerOrganization' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003CA RID: 970 RVA: 0x00021BD4 File Offset: 0x0001FDD4
			public void k(int A_0)
			{
				base[this.a.performerOrganizationColumn] = A_0;
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x060003CB RID: 971 RVA: 0x00021BF0 File Offset: 0x0001FDF0
			// (set) Token: 0x060003CC RID: 972 RVA: 0x00021C34 File Offset: 0x0001FE34
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int groupWorks
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.a.groupWorksColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'groupWorks' in table 'tJ_RequestForRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.groupWorksColumn] = value;
				}
			}

			// Token: 0x060003CD RID: 973 RVA: 0x00021C50 File Offset: 0x0001FE50
			public int z()
			{
				int result;
				try
				{
					result = (int)base[this.a.statusColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'status' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003CE RID: 974 RVA: 0x00021C94 File Offset: 0x0001FE94
			public void m(int A_0)
			{
				base[this.a.statusColumn] = A_0;
			}

			// Token: 0x060003CF RID: 975 RVA: 0x00021CB0 File Offset: 0x0001FEB0
			public int aa()
			{
				int result;
				try
				{
					result = (int)base[this.a.idRICColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idRIC' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003D0 RID: 976 RVA: 0x00021CF4 File Offset: 0x0001FEF4
			public void n(int A_0)
			{
				base[this.a.idRICColumn] = A_0;
			}

			// Token: 0x060003D1 RID: 977 RVA: 0x00021D10 File Offset: 0x0001FF10
			public string ab()
			{
				string result;
				try
				{
					result = (string)base[this.a.messageRICColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'messageRIC' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003D2 RID: 978 RVA: 0x00021D54 File Offset: 0x0001FF54
			public void g(string value)
			{
				base[this.a.messageRICColumn] = value;
			}

			// Token: 0x060003D3 RID: 979 RVA: 0x00021D68 File Offset: 0x0001FF68
			public bool ac()
			{
				bool result;
				try
				{
					result = (bool)base[this.a.isSendColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isSend' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003D4 RID: 980 RVA: 0x00021DAC File Offset: 0x0001FFAC
			public void e(bool A_0)
			{
				base[this.a.isSendColumn] = A_0;
			}

			// Token: 0x060003D5 RID: 981 RVA: 0x00021DC8 File Offset: 0x0001FFC8
			public string ad()
			{
				string result;
				try
				{
					result = (string)base[this.a.idTypeDamageColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idTypeDamage' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003D6 RID: 982 RVA: 0x00021E0C File Offset: 0x0002000C
			public void h(string value)
			{
				base[this.a.idTypeDamageColumn] = value;
			}

			// Token: 0x060003D7 RID: 983 RVA: 0x00021E20 File Offset: 0x00020020
			public bool ae()
			{
				bool result;
				try
				{
					result = (bool)base[this.a.SendSiteColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SendSite' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003D8 RID: 984 RVA: 0x00021E64 File Offset: 0x00020064
			public void f(bool A_0)
			{
				base[this.a.SendSiteColumn] = A_0;
			}

			// Token: 0x060003D9 RID: 985 RVA: 0x00021E80 File Offset: 0x00020080
			public string af()
			{
				string result;
				try
				{
					result = (string)base[this.a.LogXmlColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'LogXml' in table 'tJ_RequestForRepair' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060003DA RID: 986 RVA: 0x00021EC4 File Offset: 0x000200C4
			public void i(string value)
			{
				base[this.a.LogXmlColumn] = value;
			}

			// Token: 0x060003DB RID: 987 RVA: 0x00021ED8 File Offset: 0x000200D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool ag()
			{
				return base.IsNull(this.a.idWorkerColumn);
			}

			// Token: 0x060003DC RID: 988 RVA: 0x00021EEB File Offset: 0x000200EB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void ah()
			{
				base[this.a.idWorkerColumn] = Convert.DBNull;
			}

			// Token: 0x060003DD RID: 989 RVA: 0x00021F03 File Offset: 0x00020103
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool ai()
			{
				return base.IsNull(this.a.CrashColumn);
			}

			// Token: 0x060003DE RID: 990 RVA: 0x00021F16 File Offset: 0x00020116
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void aj()
			{
				base[this.a.CrashColumn] = Convert.DBNull;
			}

			// Token: 0x060003DF RID: 991 RVA: 0x00021F2E File Offset: 0x0002012E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool ak()
			{
				return base.IsNull(this.a.AgreeWithColumn);
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x00021F41 File Offset: 0x00020141
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void al()
			{
				base[this.a.AgreeWithColumn] = Convert.DBNull;
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x00021F59 File Offset: 0x00020159
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool am()
			{
				return base.IsNull(this.a.CommentColumn);
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x00021F6C File Offset: 0x0002016C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void an()
			{
				base[this.a.CommentColumn] = Convert.DBNull;
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x00021F84 File Offset: 0x00020184
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool ao()
			{
				return base.IsNull(this.a.AddressColumn);
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x00021F97 File Offset: 0x00020197
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void ap()
			{
				base[this.a.AddressColumn] = Convert.DBNull;
			}

			// Token: 0x060003E5 RID: 997 RVA: 0x00021FAF File Offset: 0x000201AF
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool aq()
			{
				return base.IsNull(this.a.DateAgreedColumn);
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x00021FC2 File Offset: 0x000201C2
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void ar()
			{
				base[this.a.DateAgreedColumn] = Convert.DBNull;
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x00021FDA File Offset: 0x000201DA
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool @as()
			{
				return base.IsNull(this.a.WorkerAgreedColumn);
			}

			// Token: 0x060003E8 RID: 1000 RVA: 0x00021FED File Offset: 0x000201ED
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void at()
			{
				base[this.a.WorkerAgreedColumn] = Convert.DBNull;
			}

			// Token: 0x060003E9 RID: 1001 RVA: 0x00022005 File Offset: 0x00020205
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool au()
			{
				return base.IsNull(this.a.idUserCreateColumn);
			}

			// Token: 0x060003EA RID: 1002 RVA: 0x00022018 File Offset: 0x00020218
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void av()
			{
				base[this.a.idUserCreateColumn] = Convert.DBNull;
			}

			// Token: 0x060003EB RID: 1003 RVA: 0x00022030 File Offset: 0x00020230
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool aw()
			{
				return base.IsNull(this.a.deletedColumn);
			}

			// Token: 0x060003EC RID: 1004 RVA: 0x00022043 File Offset: 0x00020243
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void ax()
			{
				base[this.a.deletedColumn] = Convert.DBNull;
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x0002205B File Offset: 0x0002025B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool ay()
			{
				return base.IsNull(this.a.idRegionColumn);
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x0002206E File Offset: 0x0002026E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void az()
			{
				base[this.a.idRegionColumn] = Convert.DBNull;
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x00022086 File Offset: 0x00020286
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool a0()
			{
				return base.IsNull(this.a.typeDisableColumn);
			}

			// Token: 0x060003F0 RID: 1008 RVA: 0x00022099 File Offset: 0x00020299
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void a1()
			{
				base[this.a.typeDisableColumn] = Convert.DBNull;
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x000220B1 File Offset: 0x000202B1
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool a2()
			{
				return base.IsNull(this.a.dateFactEndColumn);
			}

			// Token: 0x060003F2 RID: 1010 RVA: 0x000220C4 File Offset: 0x000202C4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void a3()
			{
				base[this.a.dateFactEndColumn] = Convert.DBNull;
			}

			// Token: 0x060003F3 RID: 1011 RVA: 0x000220DC File Offset: 0x000202DC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool a4()
			{
				return base.IsNull(this.a.organizationColumn);
			}

			// Token: 0x060003F4 RID: 1012 RVA: 0x000220EF File Offset: 0x000202EF
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void a5()
			{
				base[this.a.organizationColumn] = Convert.DBNull;
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x00022107 File Offset: 0x00020307
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool a6()
			{
				return base.IsNull(this.a.performerOrganizationColumn);
			}

			// Token: 0x060003F6 RID: 1014 RVA: 0x0002211A File Offset: 0x0002031A
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void a7()
			{
				base[this.a.performerOrganizationColumn] = Convert.DBNull;
			}

			// Token: 0x060003F7 RID: 1015 RVA: 0x00022132 File Offset: 0x00020332
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool a8()
			{
				return base.IsNull(this.a.groupWorksColumn);
			}

			// Token: 0x060003F8 RID: 1016 RVA: 0x00022145 File Offset: 0x00020345
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void a9()
			{
				base[this.a.groupWorksColumn] = Convert.DBNull;
			}

			// Token: 0x060003F9 RID: 1017 RVA: 0x0002215D File Offset: 0x0002035D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool ba()
			{
				return base.IsNull(this.a.statusColumn);
			}

			// Token: 0x060003FA RID: 1018 RVA: 0x00022170 File Offset: 0x00020370
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bb()
			{
				base[this.a.statusColumn] = Convert.DBNull;
			}

			// Token: 0x060003FB RID: 1019 RVA: 0x00022188 File Offset: 0x00020388
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool bc()
			{
				return base.IsNull(this.a.idRICColumn);
			}

			// Token: 0x060003FC RID: 1020 RVA: 0x0002219B File Offset: 0x0002039B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bd()
			{
				base[this.a.idRICColumn] = Convert.DBNull;
			}

			// Token: 0x060003FD RID: 1021 RVA: 0x000221B3 File Offset: 0x000203B3
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool be()
			{
				return base.IsNull(this.a.messageRICColumn);
			}

			// Token: 0x060003FE RID: 1022 RVA: 0x000221C6 File Offset: 0x000203C6
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bf()
			{
				base[this.a.messageRICColumn] = Convert.DBNull;
			}

			// Token: 0x060003FF RID: 1023 RVA: 0x000221DE File Offset: 0x000203DE
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bg()
			{
				return base.IsNull(this.a.isSendColumn);
			}

			// Token: 0x06000400 RID: 1024 RVA: 0x000221F1 File Offset: 0x000203F1
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void bh()
			{
				base[this.a.isSendColumn] = Convert.DBNull;
			}

			// Token: 0x06000401 RID: 1025 RVA: 0x00022209 File Offset: 0x00020409
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool bi()
			{
				return base.IsNull(this.a.idTypeDamageColumn);
			}

			// Token: 0x06000402 RID: 1026 RVA: 0x0002221C File Offset: 0x0002041C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void bj()
			{
				base[this.a.idTypeDamageColumn] = Convert.DBNull;
			}

			// Token: 0x06000403 RID: 1027 RVA: 0x00022234 File Offset: 0x00020434
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bk()
			{
				return base.IsNull(this.a.SendSiteColumn);
			}

			// Token: 0x06000404 RID: 1028 RVA: 0x00022247 File Offset: 0x00020447
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bl()
			{
				base[this.a.SendSiteColumn] = Convert.DBNull;
			}

			// Token: 0x06000405 RID: 1029 RVA: 0x0002225F File Offset: 0x0002045F
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool bm()
			{
				return base.IsNull(this.a.LogXmlColumn);
			}

			// Token: 0x06000406 RID: 1030 RVA: 0x00022272 File Offset: 0x00020472
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bn()
			{
				base[this.a.LogXmlColumn] = Convert.DBNull;
			}

			// Token: 0x04000274 RID: 628
			private DataSetGES.tJ_RequestForRepairDataTable a;
		}

		// Token: 0x02000062 RID: 98
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tJ_RequestForRepairDailyDataTable : TypedTableBase<DataSetGES.u>
		{
			// Token: 0x06000407 RID: 1031 RVA: 0x0002228A File Offset: 0x0002048A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tJ_RequestForRepairDailyDataTable()
			{
				base.TableName = "tJ_RequestForRepairDaily";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x06000408 RID: 1032 RVA: 0x000222B0 File Offset: 0x000204B0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tJ_RequestForRepairDailyDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x06000409 RID: 1033 RVA: 0x00022358 File Offset: 0x00020558
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected tJ_RequestForRepairDailyDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.g();
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x0600040A RID: 1034 RVA: 0x00022368 File Offset: 0x00020568
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x0600040B RID: 1035 RVA: 0x00022370 File Offset: 0x00020570
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idRequestColumn
			{
				get
				{
					return this.columnidRequest;
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x0600040C RID: 1036 RVA: 0x00022378 File Offset: 0x00020578
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dateBegColumn
			{
				get
				{
					return this.columndateBeg;
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x0600040D RID: 1037 RVA: 0x00022380 File Offset: 0x00020580
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn dateEndColumn
			{
				get
				{
					return this.columndateEnd;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x0600040E RID: 1038 RVA: 0x00022388 File Offset: 0x00020588
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

			// Token: 0x170000C3 RID: 195
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.u this[int A_0]
			{
				get
				{
					return (DataSetGES.u)base.Rows[A_0];
				}
			}

			// Token: 0x14000020 RID: 32
			// (add) Token: 0x06000410 RID: 1040 RVA: 0x000223A8 File Offset: 0x000205A8
			// (remove) Token: 0x06000411 RID: 1041 RVA: 0x000223E0 File Offset: 0x000205E0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.g tJ_RequestForRepairDailyRowChanging;

			// Token: 0x14000021 RID: 33
			// (add) Token: 0x06000412 RID: 1042 RVA: 0x00022418 File Offset: 0x00020618
			// (remove) Token: 0x06000413 RID: 1043 RVA: 0x00022450 File Offset: 0x00020650
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.g tJ_RequestForRepairDailyRowChanged;

			// Token: 0x14000022 RID: 34
			// (add) Token: 0x06000414 RID: 1044 RVA: 0x00022488 File Offset: 0x00020688
			// (remove) Token: 0x06000415 RID: 1045 RVA: 0x000224C0 File Offset: 0x000206C0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.g tJ_RequestForRepairDailyRowDeleting;

			// Token: 0x14000023 RID: 35
			// (add) Token: 0x06000416 RID: 1046 RVA: 0x000224F8 File Offset: 0x000206F8
			// (remove) Token: 0x06000417 RID: 1047 RVA: 0x00022530 File Offset: 0x00020730
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.g tJ_RequestForRepairDailyRowDeleted;

			// Token: 0x06000418 RID: 1048 RVA: 0x00022565 File Offset: 0x00020765
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void a(DataSetGES.u A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x06000419 RID: 1049 RVA: 0x00022574 File Offset: 0x00020774
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.u a(int A_0, DateTime A_1, DateTime A_2)
			{
				DataSetGES.u u = (DataSetGES.u)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					A_0,
					A_1,
					A_2
				};
				u.ItemArray = itemArray;
				base.Rows.Add(u);
				return u;
			}

			// Token: 0x0600041A RID: 1050 RVA: 0x000225C3 File Offset: 0x000207C3
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.u b(int A_0)
			{
				return (DataSetGES.u)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x0600041B RID: 1051 RVA: 0x000225E4 File Offset: 0x000207E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetGES.tJ_RequestForRepairDailyDataTable tJ_RequestForRepairDailyDataTable = (DataSetGES.tJ_RequestForRepairDailyDataTable)base.Clone();
				tJ_RequestForRepairDailyDataTable.g();
				return tJ_RequestForRepairDailyDataTable;
			}

			// Token: 0x0600041C RID: 1052 RVA: 0x000225F7 File Offset: 0x000207F7
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.tJ_RequestForRepairDailyDataTable();
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x00022600 File Offset: 0x00020800
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void g()
			{
				this.columnid = base.Columns["id"];
				this.columnidRequest = base.Columns["idRequest"];
				this.columndateBeg = base.Columns["dateBeg"];
				this.columndateEnd = base.Columns["dateEnd"];
			}

			// Token: 0x0600041E RID: 1054 RVA: 0x00022668 File Offset: 0x00020868
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void a()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidRequest = new DataColumn("idRequest", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidRequest);
				this.columndateBeg = new DataColumn("dateBeg", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columndateBeg);
				this.columndateEnd = new DataColumn("dateEnd", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columndateEnd);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnid
				}, true));
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = -1L;
				this.columnid.AutoIncrementStep = -1L;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
				this.columnidRequest.AllowDBNull = false;
				this.columndateBeg.AllowDBNull = false;
				this.columndateEnd.AllowDBNull = false;
			}

			// Token: 0x0600041F RID: 1055 RVA: 0x000227BC File Offset: 0x000209BC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.u h()
			{
				return (DataSetGES.u)base.NewRow();
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x000227C9 File Offset: 0x000209C9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.u(builder);
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x000227D1 File Offset: 0x000209D1
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.u);
			}

			// Token: 0x06000422 RID: 1058 RVA: 0x000227DD File Offset: 0x000209DD
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tJ_RequestForRepairDailyRowChanged != null)
				{
					this.tJ_RequestForRepairDailyRowChanged(this, new DataSetGES.ai((DataSetGES.u)e.Row, e.Action));
				}
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x00022810 File Offset: 0x00020A10
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tJ_RequestForRepairDailyRowChanging != null)
				{
					this.tJ_RequestForRepairDailyRowChanging(this, new DataSetGES.ai((DataSetGES.u)e.Row, e.Action));
				}
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x00022843 File Offset: 0x00020A43
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tJ_RequestForRepairDailyRowDeleted != null)
				{
					this.tJ_RequestForRepairDailyRowDeleted(this, new DataSetGES.ai((DataSetGES.u)e.Row, e.Action));
				}
			}

			// Token: 0x06000425 RID: 1061 RVA: 0x00022876 File Offset: 0x00020A76
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tJ_RequestForRepairDailyRowDeleting != null)
				{
					this.tJ_RequestForRepairDailyRowDeleting(this, new DataSetGES.ai((DataSetGES.u)e.Row, e.Action));
				}
			}

			// Token: 0x06000426 RID: 1062 RVA: 0x000228A9 File Offset: 0x00020AA9
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void b(DataSetGES.u A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x000228B8 File Offset: 0x00020AB8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tJ_RequestForRepairDailyDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000275 RID: 629
			private DataColumn columnid;

			// Token: 0x04000276 RID: 630
			private DataColumn columnidRequest;

			// Token: 0x04000277 RID: 631
			private DataColumn columndateBeg;

			// Token: 0x04000278 RID: 632
			private DataColumn columndateEnd;
		}

		// Token: 0x02000063 RID: 99
		public class u : DataRow
		{
			// Token: 0x06000428 RID: 1064 RVA: 0x00022AAC File Offset: 0x00020CAC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal u(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.tJ_RequestForRepairDailyDataTable)base.Table;
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x06000429 RID: 1065 RVA: 0x00022AC6 File Offset: 0x00020CC6
			// (set) Token: 0x0600042A RID: 1066 RVA: 0x00022ADE File Offset: 0x00020CDE
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int id
			{
				get
				{
					return (int)base[this.a.idColumn];
				}
				set
				{
					base[this.a.idColumn] = value;
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x0600042B RID: 1067 RVA: 0x00022AF7 File Offset: 0x00020CF7
			// (set) Token: 0x0600042C RID: 1068 RVA: 0x00022B0F File Offset: 0x00020D0F
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idRequest
			{
				get
				{
					return (int)base[this.a.idRequestColumn];
				}
				set
				{
					base[this.a.idRequestColumn] = value;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x0600042D RID: 1069 RVA: 0x00022B28 File Offset: 0x00020D28
			// (set) Token: 0x0600042E RID: 1070 RVA: 0x00022B40 File Offset: 0x00020D40
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dateBeg
			{
				get
				{
					return (DateTime)base[this.a.dateBegColumn];
				}
				set
				{
					base[this.a.dateBegColumn] = value;
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x0600042F RID: 1071 RVA: 0x00022B59 File Offset: 0x00020D59
			// (set) Token: 0x06000430 RID: 1072 RVA: 0x00022B71 File Offset: 0x00020D71
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dateEnd
			{
				get
				{
					return (DateTime)base[this.a.dateEndColumn];
				}
				set
				{
					base[this.a.dateEndColumn] = value;
				}
			}

			// Token: 0x0400027D RID: 637
			private DataSetGES.tJ_RequestForRepairDailyDataTable a;
		}

		// Token: 0x02000064 RID: 100
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tJ_RequestForRepairDocDataTable : TypedTableBase<DataSetGES.v>
		{
			// Token: 0x06000431 RID: 1073 RVA: 0x00022B8A File Offset: 0x00020D8A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tJ_RequestForRepairDocDataTable()
			{
				base.TableName = "tJ_RequestForRepairDoc";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x00022BB0 File Offset: 0x00020DB0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tJ_RequestForRepairDocDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x06000433 RID: 1075 RVA: 0x00022C58 File Offset: 0x00020E58
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected tJ_RequestForRepairDocDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.h();
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x06000434 RID: 1076 RVA: 0x00022C68 File Offset: 0x00020E68
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x06000435 RID: 1077 RVA: 0x00022C70 File Offset: 0x00020E70
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idRequestColumn
			{
				get
				{
					return this.columnidRequest;
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x06000436 RID: 1078 RVA: 0x00022C78 File Offset: 0x00020E78
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DocumentColumn
			{
				get
				{
					return this.columnDocument;
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x06000437 RID: 1079 RVA: 0x00022C80 File Offset: 0x00020E80
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn FileNameColumn
			{
				get
				{
					return this.columnFileName;
				}
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x06000438 RID: 1080 RVA: 0x00022C88 File Offset: 0x00020E88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CommentColumn
			{
				get
				{
					return this.columnComment;
				}
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x06000439 RID: 1081 RVA: 0x00022C90 File Offset: 0x00020E90
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

			// Token: 0x170000CE RID: 206
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.v this[int A_0]
			{
				get
				{
					return (DataSetGES.v)base.Rows[A_0];
				}
			}

			// Token: 0x14000024 RID: 36
			// (add) Token: 0x0600043B RID: 1083 RVA: 0x00022CB0 File Offset: 0x00020EB0
			// (remove) Token: 0x0600043C RID: 1084 RVA: 0x00022CE8 File Offset: 0x00020EE8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.h tJ_RequestForRepairDocRowChanging;

			// Token: 0x14000025 RID: 37
			// (add) Token: 0x0600043D RID: 1085 RVA: 0x00022D20 File Offset: 0x00020F20
			// (remove) Token: 0x0600043E RID: 1086 RVA: 0x00022D58 File Offset: 0x00020F58
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.h tJ_RequestForRepairDocRowChanged;

			// Token: 0x14000026 RID: 38
			// (add) Token: 0x0600043F RID: 1087 RVA: 0x00022D90 File Offset: 0x00020F90
			// (remove) Token: 0x06000440 RID: 1088 RVA: 0x00022DC8 File Offset: 0x00020FC8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.h tJ_RequestForRepairDocRowDeleting;

			// Token: 0x14000027 RID: 39
			// (add) Token: 0x06000441 RID: 1089 RVA: 0x00022E00 File Offset: 0x00021000
			// (remove) Token: 0x06000442 RID: 1090 RVA: 0x00022E38 File Offset: 0x00021038
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.h tJ_RequestForRepairDocRowDeleted;

			// Token: 0x06000443 RID: 1091 RVA: 0x00022E6D File Offset: 0x0002106D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void a(DataSetGES.v A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x06000444 RID: 1092 RVA: 0x00022E7C File Offset: 0x0002107C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.v a(int A_0, byte[] A_1, string A_2, string A_3)
			{
				DataSetGES.v v = (DataSetGES.v)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					A_0,
					A_1,
					A_2,
					A_3
				};
				v.ItemArray = itemArray;
				base.Rows.Add(v);
				return v;
			}

			// Token: 0x06000445 RID: 1093 RVA: 0x00022EC6 File Offset: 0x000210C6
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.v b(int A_0)
			{
				return (DataSetGES.v)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x00022EE7 File Offset: 0x000210E7
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetGES.tJ_RequestForRepairDocDataTable tJ_RequestForRepairDocDataTable = (DataSetGES.tJ_RequestForRepairDocDataTable)base.Clone();
				tJ_RequestForRepairDocDataTable.h();
				return tJ_RequestForRepairDocDataTable;
			}

			// Token: 0x06000447 RID: 1095 RVA: 0x00022EFA File Offset: 0x000210FA
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.tJ_RequestForRepairDocDataTable();
			}

			// Token: 0x06000448 RID: 1096 RVA: 0x00022F04 File Offset: 0x00021104
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void h()
			{
				this.columnid = base.Columns["id"];
				this.columnidRequest = base.Columns["idRequest"];
				this.columnDocument = base.Columns["Document"];
				this.columnFileName = base.Columns["FileName"];
				this.columnComment = base.Columns["Comment"];
			}

			// Token: 0x06000449 RID: 1097 RVA: 0x00022F80 File Offset: 0x00021180
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void a()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidRequest = new DataColumn("idRequest", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidRequest);
				this.columnDocument = new DataColumn("Document", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnDocument);
				this.columnFileName = new DataColumn("FileName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFileName);
				this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnComment);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnid
				}, true));
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = -1L;
				this.columnid.AutoIncrementStep = -1L;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
				this.columnidRequest.AllowDBNull = false;
				this.columnDocument.AllowDBNull = false;
				this.columnFileName.AllowDBNull = false;
				this.columnFileName.MaxLength = 1024;
				this.columnComment.MaxLength = 1024;
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x00023121 File Offset: 0x00021321
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.v i()
			{
				return (DataSetGES.v)base.NewRow();
			}

			// Token: 0x0600044B RID: 1099 RVA: 0x0002312E File Offset: 0x0002132E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.v(builder);
			}

			// Token: 0x0600044C RID: 1100 RVA: 0x00023136 File Offset: 0x00021336
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.v);
			}

			// Token: 0x0600044D RID: 1101 RVA: 0x00023142 File Offset: 0x00021342
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tJ_RequestForRepairDocRowChanged != null)
				{
					this.tJ_RequestForRepairDocRowChanged(this, new DataSetGES.aj((DataSetGES.v)e.Row, e.Action));
				}
			}

			// Token: 0x0600044E RID: 1102 RVA: 0x00023175 File Offset: 0x00021375
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tJ_RequestForRepairDocRowChanging != null)
				{
					this.tJ_RequestForRepairDocRowChanging(this, new DataSetGES.aj((DataSetGES.v)e.Row, e.Action));
				}
			}

			// Token: 0x0600044F RID: 1103 RVA: 0x000231A8 File Offset: 0x000213A8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tJ_RequestForRepairDocRowDeleted != null)
				{
					this.tJ_RequestForRepairDocRowDeleted(this, new DataSetGES.aj((DataSetGES.v)e.Row, e.Action));
				}
			}

			// Token: 0x06000450 RID: 1104 RVA: 0x000231DB File Offset: 0x000213DB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tJ_RequestForRepairDocRowDeleting != null)
				{
					this.tJ_RequestForRepairDocRowDeleting(this, new DataSetGES.aj((DataSetGES.v)e.Row, e.Action));
				}
			}

			// Token: 0x06000451 RID: 1105 RVA: 0x0002320E File Offset: 0x0002140E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void b(DataSetGES.v A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x06000452 RID: 1106 RVA: 0x0002321C File Offset: 0x0002141C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tJ_RequestForRepairDocDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x0400027E RID: 638
			private DataColumn columnid;

			// Token: 0x0400027F RID: 639
			private DataColumn columnidRequest;

			// Token: 0x04000280 RID: 640
			private DataColumn columnDocument;

			// Token: 0x04000281 RID: 641
			private DataColumn columnFileName;

			// Token: 0x04000282 RID: 642
			private DataColumn columnComment;
		}

		// Token: 0x02000065 RID: 101
		public class v : DataRow
		{
			// Token: 0x06000453 RID: 1107 RVA: 0x00023410 File Offset: 0x00021610
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal v(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.tJ_RequestForRepairDocDataTable)base.Table;
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x06000454 RID: 1108 RVA: 0x0002342A File Offset: 0x0002162A
			// (set) Token: 0x06000455 RID: 1109 RVA: 0x00023442 File Offset: 0x00021642
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int id
			{
				get
				{
					return (int)base[this.a.idColumn];
				}
				set
				{
					base[this.a.idColumn] = value;
				}
			}

			// Token: 0x06000456 RID: 1110 RVA: 0x0002345B File Offset: 0x0002165B
			public int b()
			{
				return (int)base[this.a.idRequestColumn];
			}

			// Token: 0x06000457 RID: 1111 RVA: 0x00023473 File Offset: 0x00021673
			public void b(int A_0)
			{
				base[this.a.idRequestColumn] = A_0;
			}

			// Token: 0x06000458 RID: 1112 RVA: 0x0002348C File Offset: 0x0002168C
			public byte[] c()
			{
				return (byte[])base[this.a.DocumentColumn];
			}

			// Token: 0x06000459 RID: 1113 RVA: 0x000234A4 File Offset: 0x000216A4
			public void a(byte[] A_0)
			{
				base[this.a.DocumentColumn] = A_0;
			}

			// Token: 0x0600045A RID: 1114 RVA: 0x000234B8 File Offset: 0x000216B8
			public string d()
			{
				return (string)base[this.a.FileNameColumn];
			}

			// Token: 0x0600045B RID: 1115 RVA: 0x000234D0 File Offset: 0x000216D0
			public void a(string value)
			{
				base[this.a.FileNameColumn] = value;
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x0600045C RID: 1116 RVA: 0x000234E4 File Offset: 0x000216E4
			// (set) Token: 0x0600045D RID: 1117 RVA: 0x00023528 File Offset: 0x00021728
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Comment
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.a.CommentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Comment' in table 'tJ_RequestForRepairDoc' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.CommentColumn] = value;
				}
			}

			// Token: 0x0600045E RID: 1118 RVA: 0x0002353C File Offset: 0x0002173C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool f()
			{
				return base.IsNull(this.a.CommentColumn);
			}

			// Token: 0x0600045F RID: 1119 RVA: 0x0002354F File Offset: 0x0002174F
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void g()
			{
				base[this.a.CommentColumn] = Convert.DBNull;
			}

			// Token: 0x04000287 RID: 647
			private DataSetGES.tJ_RequestForRepairDocDataTable a;
		}

		// Token: 0x02000066 RID: 102
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tR_RequestForRepairClientDataTable : TypedTableBase<DataSetGES.w>
		{
			// Token: 0x06000460 RID: 1120 RVA: 0x00023567 File Offset: 0x00021767
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tR_RequestForRepairClientDataTable()
			{
				base.TableName = "tR_RequestForRepairClient";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x06000461 RID: 1121 RVA: 0x0002358C File Offset: 0x0002178C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tR_RequestForRepairClientDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x06000462 RID: 1122 RVA: 0x00023634 File Offset: 0x00021834
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected tR_RequestForRepairClientDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.j();
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x06000463 RID: 1123 RVA: 0x00023644 File Offset: 0x00021844
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x06000464 RID: 1124 RVA: 0x0002364C File Offset: 0x0002184C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x06000465 RID: 1125 RVA: 0x00023654 File Offset: 0x00021854
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ValueColumn
			{
				get
				{
					return this.columnValue;
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x06000466 RID: 1126 RVA: 0x0002365C File Offset: 0x0002185C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TypeColumn
			{
				get
				{
					return this.columnType;
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x06000467 RID: 1127 RVA: 0x00023664 File Offset: 0x00021864
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn GesIdColumn
			{
				get
				{
					return this.columnGesId;
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x06000468 RID: 1128 RVA: 0x0002366C File Offset: 0x0002186C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn GesNameColumn
			{
				get
				{
					return this.columnGesName;
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x06000469 RID: 1129 RVA: 0x00023674 File Offset: 0x00021874
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IsDefaultColumn
			{
				get
				{
					return this.columnIsDefault;
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x0600046A RID: 1130 RVA: 0x0002367C File Offset: 0x0002187C
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

			// Token: 0x170000D9 RID: 217
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.w this[int A_0]
			{
				get
				{
					return (DataSetGES.w)base.Rows[A_0];
				}
			}

			// Token: 0x14000028 RID: 40
			// (add) Token: 0x0600046C RID: 1132 RVA: 0x0002369C File Offset: 0x0002189C
			// (remove) Token: 0x0600046D RID: 1133 RVA: 0x000236D4 File Offset: 0x000218D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.i tR_RequestForRepairClientRowChanging;

			// Token: 0x14000029 RID: 41
			// (add) Token: 0x0600046E RID: 1134 RVA: 0x0002370C File Offset: 0x0002190C
			// (remove) Token: 0x0600046F RID: 1135 RVA: 0x00023744 File Offset: 0x00021944
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.i tR_RequestForRepairClientRowChanged;

			// Token: 0x1400002A RID: 42
			// (add) Token: 0x06000470 RID: 1136 RVA: 0x0002377C File Offset: 0x0002197C
			// (remove) Token: 0x06000471 RID: 1137 RVA: 0x000237B4 File Offset: 0x000219B4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.i tR_RequestForRepairClientRowDeleting;

			// Token: 0x1400002B RID: 43
			// (add) Token: 0x06000472 RID: 1138 RVA: 0x000237EC File Offset: 0x000219EC
			// (remove) Token: 0x06000473 RID: 1139 RVA: 0x00023824 File Offset: 0x00021A24
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.i tR_RequestForRepairClientRowDeleted;

			// Token: 0x06000474 RID: 1140 RVA: 0x00023859 File Offset: 0x00021A59
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void a(DataSetGES.w A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x06000475 RID: 1141 RVA: 0x00023868 File Offset: 0x00021A68
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.w a(string A_0, int A_1, int A_2, int A_3, string A_4, bool A_5)
			{
				DataSetGES.w w = (DataSetGES.w)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					A_0,
					A_1,
					A_2,
					A_3,
					A_4,
					A_5
				};
				w.ItemArray = itemArray;
				base.Rows.Add(w);
				return w;
			}

			// Token: 0x06000476 RID: 1142 RVA: 0x000238CB File Offset: 0x00021ACB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.w b(int A_0)
			{
				return (DataSetGES.w)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x06000477 RID: 1143 RVA: 0x000238EC File Offset: 0x00021AEC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetGES.tR_RequestForRepairClientDataTable tR_RequestForRepairClientDataTable = (DataSetGES.tR_RequestForRepairClientDataTable)base.Clone();
				tR_RequestForRepairClientDataTable.j();
				return tR_RequestForRepairClientDataTable;
			}

			// Token: 0x06000478 RID: 1144 RVA: 0x000238FF File Offset: 0x00021AFF
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.tR_RequestForRepairClientDataTable();
			}

			// Token: 0x06000479 RID: 1145 RVA: 0x00023908 File Offset: 0x00021B08
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void j()
			{
				this.columnid = base.Columns["id"];
				this.columnName = base.Columns["Name"];
				this.columnValue = base.Columns["Value"];
				this.columnType = base.Columns["Type"];
				this.columnGesId = base.Columns["GesId"];
				this.columnGesName = base.Columns["GesName"];
				this.columnIsDefault = base.Columns["IsDefault"];
			}

			// Token: 0x0600047A RID: 1146 RVA: 0x000239B0 File Offset: 0x00021BB0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void a()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnValue = new DataColumn("Value", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnValue);
				this.columnType = new DataColumn("Type", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnType);
				this.columnGesId = new DataColumn("GesId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnGesId);
				this.columnGesName = new DataColumn("GesName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGesName);
				this.columnIsDefault = new DataColumn("IsDefault", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnIsDefault);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnid
				}, true));
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = -1L;
				this.columnid.AutoIncrementStep = -1L;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
				this.columnName.MaxLength = 1024;
				this.columnGesName.MaxLength = 1024;
			}

			// Token: 0x0600047B RID: 1147 RVA: 0x00023B87 File Offset: 0x00021D87
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.w k()
			{
				return (DataSetGES.w)base.NewRow();
			}

			// Token: 0x0600047C RID: 1148 RVA: 0x00023B94 File Offset: 0x00021D94
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.w(builder);
			}

			// Token: 0x0600047D RID: 1149 RVA: 0x00023B9C File Offset: 0x00021D9C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.w);
			}

			// Token: 0x0600047E RID: 1150 RVA: 0x00023BA8 File Offset: 0x00021DA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tR_RequestForRepairClientRowChanged != null)
				{
					this.tR_RequestForRepairClientRowChanged(this, new DataSetGES.ak((DataSetGES.w)e.Row, e.Action));
				}
			}

			// Token: 0x0600047F RID: 1151 RVA: 0x00023BDB File Offset: 0x00021DDB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tR_RequestForRepairClientRowChanging != null)
				{
					this.tR_RequestForRepairClientRowChanging(this, new DataSetGES.ak((DataSetGES.w)e.Row, e.Action));
				}
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x00023C0E File Offset: 0x00021E0E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tR_RequestForRepairClientRowDeleted != null)
				{
					this.tR_RequestForRepairClientRowDeleted(this, new DataSetGES.ak((DataSetGES.w)e.Row, e.Action));
				}
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x00023C41 File Offset: 0x00021E41
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tR_RequestForRepairClientRowDeleting != null)
				{
					this.tR_RequestForRepairClientRowDeleting(this, new DataSetGES.ak((DataSetGES.w)e.Row, e.Action));
				}
			}

			// Token: 0x06000482 RID: 1154 RVA: 0x00023C74 File Offset: 0x00021E74
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void b(DataSetGES.w A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x06000483 RID: 1155 RVA: 0x00023C84 File Offset: 0x00021E84
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tR_RequestForRepairClientDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000288 RID: 648
			private DataColumn columnid;

			// Token: 0x04000289 RID: 649
			private DataColumn columnName;

			// Token: 0x0400028A RID: 650
			private DataColumn columnValue;

			// Token: 0x0400028B RID: 651
			private DataColumn columnType;

			// Token: 0x0400028C RID: 652
			private DataColumn columnGesId;

			// Token: 0x0400028D RID: 653
			private DataColumn columnGesName;

			// Token: 0x0400028E RID: 654
			private DataColumn columnIsDefault;
		}

		// Token: 0x02000067 RID: 103
		public class w : DataRow
		{
			// Token: 0x06000484 RID: 1156 RVA: 0x00023E78 File Offset: 0x00022078
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal w(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.tR_RequestForRepairClientDataTable)base.Table;
			}

			// Token: 0x170000DA RID: 218
			// (get) Token: 0x06000485 RID: 1157 RVA: 0x00023E92 File Offset: 0x00022092
			// (set) Token: 0x06000486 RID: 1158 RVA: 0x00023EAA File Offset: 0x000220AA
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int id
			{
				get
				{
					return (int)base[this.a.idColumn];
				}
				set
				{
					base[this.a.idColumn] = value;
				}
			}

			// Token: 0x170000DB RID: 219
			// (get) Token: 0x06000487 RID: 1159 RVA: 0x00023EC4 File Offset: 0x000220C4
			// (set) Token: 0x06000488 RID: 1160 RVA: 0x00023F08 File Offset: 0x00022108
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.a.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'tR_RequestForRepairClient' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.NameColumn] = value;
				}
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x06000489 RID: 1161 RVA: 0x00023F1C File Offset: 0x0002211C
			// (set) Token: 0x0600048A RID: 1162 RVA: 0x00023F60 File Offset: 0x00022160
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Value
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.a.ValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Value' in table 'tR_RequestForRepairClient' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.ValueColumn] = value;
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x0600048B RID: 1163 RVA: 0x00023F7C File Offset: 0x0002217C
			// (set) Token: 0x0600048C RID: 1164 RVA: 0x00023FC0 File Offset: 0x000221C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Type
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.a.TypeColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Type' in table 'tR_RequestForRepairClient' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.TypeColumn] = value;
				}
			}

			// Token: 0x0600048D RID: 1165 RVA: 0x00023FDC File Offset: 0x000221DC
			public int e()
			{
				int result;
				try
				{
					result = (int)base[this.a.GesIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'GesId' in table 'tR_RequestForRepairClient' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600048E RID: 1166 RVA: 0x00024020 File Offset: 0x00022220
			public void d(int A_0)
			{
				base[this.a.GesIdColumn] = A_0;
			}

			// Token: 0x0600048F RID: 1167 RVA: 0x0002403C File Offset: 0x0002223C
			public string f()
			{
				string result;
				try
				{
					result = (string)base[this.a.GesNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'GesName' in table 'tR_RequestForRepairClient' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000490 RID: 1168 RVA: 0x00024080 File Offset: 0x00022280
			public void b(string value)
			{
				base[this.a.GesNameColumn] = value;
			}

			// Token: 0x06000491 RID: 1169 RVA: 0x00024094 File Offset: 0x00022294
			public bool g()
			{
				bool result;
				try
				{
					result = (bool)base[this.a.IsDefaultColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'IsDefault' in table 'tR_RequestForRepairClient' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000492 RID: 1170 RVA: 0x000240D8 File Offset: 0x000222D8
			public void a(bool A_0)
			{
				base[this.a.IsDefaultColumn] = A_0;
			}

			// Token: 0x06000493 RID: 1171 RVA: 0x000240F1 File Offset: 0x000222F1
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool h()
			{
				return base.IsNull(this.a.NameColumn);
			}

			// Token: 0x06000494 RID: 1172 RVA: 0x00024104 File Offset: 0x00022304
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void i()
			{
				base[this.a.NameColumn] = Convert.DBNull;
			}

			// Token: 0x06000495 RID: 1173 RVA: 0x0002411C File Offset: 0x0002231C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool j()
			{
				return base.IsNull(this.a.ValueColumn);
			}

			// Token: 0x06000496 RID: 1174 RVA: 0x0002412F File Offset: 0x0002232F
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void k()
			{
				base[this.a.ValueColumn] = Convert.DBNull;
			}

			// Token: 0x06000497 RID: 1175 RVA: 0x00024147 File Offset: 0x00022347
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool l()
			{
				return base.IsNull(this.a.TypeColumn);
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x0002415A File Offset: 0x0002235A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void m()
			{
				base[this.a.TypeColumn] = Convert.DBNull;
			}

			// Token: 0x06000499 RID: 1177 RVA: 0x00024172 File Offset: 0x00022372
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool n()
			{
				return base.IsNull(this.a.GesIdColumn);
			}

			// Token: 0x0600049A RID: 1178 RVA: 0x00024185 File Offset: 0x00022385
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void o()
			{
				base[this.a.GesIdColumn] = Convert.DBNull;
			}

			// Token: 0x0600049B RID: 1179 RVA: 0x0002419D File Offset: 0x0002239D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool p()
			{
				return base.IsNull(this.a.GesNameColumn);
			}

			// Token: 0x0600049C RID: 1180 RVA: 0x000241B0 File Offset: 0x000223B0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void q()
			{
				base[this.a.GesNameColumn] = Convert.DBNull;
			}

			// Token: 0x0600049D RID: 1181 RVA: 0x000241C8 File Offset: 0x000223C8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool r()
			{
				return base.IsNull(this.a.IsDefaultColumn);
			}

			// Token: 0x0600049E RID: 1182 RVA: 0x000241DB File Offset: 0x000223DB
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void s()
			{
				base[this.a.IsDefaultColumn] = Convert.DBNull;
			}

			// Token: 0x04000293 RID: 659
			private DataSetGES.tR_RequestForRepairClientDataTable a;
		}

		// Token: 0x02000068 RID: 104
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tJ_RequestForRepairAddressDataTable : TypedTableBase<DataSetGES.x>
		{
			// Token: 0x0600049F RID: 1183 RVA: 0x000241F3 File Offset: 0x000223F3
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tJ_RequestForRepairAddressDataTable()
			{
				base.TableName = "tJ_RequestForRepairAddress";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x060004A0 RID: 1184 RVA: 0x00024218 File Offset: 0x00022418
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tJ_RequestForRepairAddressDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x060004A1 RID: 1185 RVA: 0x000242C0 File Offset: 0x000224C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected tJ_RequestForRepairAddressDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.i();
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000242D0 File Offset: 0x000224D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000242D8 File Offset: 0x000224D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idRequestColumn
			{
				get
				{
					return this.columnidRequest;
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060004A4 RID: 1188 RVA: 0x000242E0 File Offset: 0x000224E0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idKladrObjColumn
			{
				get
				{
					return this.columnidKladrObj;
				}
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060004A5 RID: 1189 RVA: 0x000242E8 File Offset: 0x000224E8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idKladrStreetColumn
			{
				get
				{
					return this.columnidKladrStreet;
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060004A6 RID: 1190 RVA: 0x000242F0 File Offset: 0x000224F0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn HouseColumn
			{
				get
				{
					return this.columnHouse;
				}
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060004A7 RID: 1191 RVA: 0x000242F8 File Offset: 0x000224F8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00024300 File Offset: 0x00022500
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

			// Token: 0x170000E5 RID: 229
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.x this[int A_0]
			{
				get
				{
					return (DataSetGES.x)base.Rows[A_0];
				}
			}

			// Token: 0x1400002C RID: 44
			// (add) Token: 0x060004AA RID: 1194 RVA: 0x00024320 File Offset: 0x00022520
			// (remove) Token: 0x060004AB RID: 1195 RVA: 0x00024358 File Offset: 0x00022558
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.j tJ_RequestForRepairAddressRowChanging;

			// Token: 0x1400002D RID: 45
			// (add) Token: 0x060004AC RID: 1196 RVA: 0x00024390 File Offset: 0x00022590
			// (remove) Token: 0x060004AD RID: 1197 RVA: 0x000243C8 File Offset: 0x000225C8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.j tJ_RequestForRepairAddressRowChanged;

			// Token: 0x1400002E RID: 46
			// (add) Token: 0x060004AE RID: 1198 RVA: 0x00024400 File Offset: 0x00022600
			// (remove) Token: 0x060004AF RID: 1199 RVA: 0x00024438 File Offset: 0x00022638
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.j tJ_RequestForRepairAddressRowDeleting;

			// Token: 0x1400002F RID: 47
			// (add) Token: 0x060004B0 RID: 1200 RVA: 0x00024470 File Offset: 0x00022670
			// (remove) Token: 0x060004B1 RID: 1201 RVA: 0x000244A8 File Offset: 0x000226A8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.j tJ_RequestForRepairAddressRowDeleted;

			// Token: 0x060004B2 RID: 1202 RVA: 0x000244DD File Offset: 0x000226DD
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void a(DataSetGES.x A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x060004B3 RID: 1203 RVA: 0x000244EC File Offset: 0x000226EC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.x a(int A_0, int A_1, int A_2, string A_3, string A_4)
			{
				DataSetGES.x x = (DataSetGES.x)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					A_0,
					A_1,
					A_2,
					A_3,
					A_4
				};
				x.ItemArray = itemArray;
				base.Rows.Add(x);
				return x;
			}

			// Token: 0x060004B4 RID: 1204 RVA: 0x00024545 File Offset: 0x00022745
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.x b(int A_0)
			{
				return (DataSetGES.x)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x060004B5 RID: 1205 RVA: 0x00024566 File Offset: 0x00022766
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetGES.tJ_RequestForRepairAddressDataTable tJ_RequestForRepairAddressDataTable = (DataSetGES.tJ_RequestForRepairAddressDataTable)base.Clone();
				tJ_RequestForRepairAddressDataTable.i();
				return tJ_RequestForRepairAddressDataTable;
			}

			// Token: 0x060004B6 RID: 1206 RVA: 0x00024579 File Offset: 0x00022779
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.tJ_RequestForRepairAddressDataTable();
			}

			// Token: 0x060004B7 RID: 1207 RVA: 0x00024580 File Offset: 0x00022780
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void i()
			{
				this.columnid = base.Columns["id"];
				this.columnidRequest = base.Columns["idRequest"];
				this.columnidKladrObj = base.Columns["idKladrObj"];
				this.columnidKladrStreet = base.Columns["idKladrStreet"];
				this.columnHouse = base.Columns["House"];
				this.columnName = base.Columns["Name"];
			}

			// Token: 0x060004B8 RID: 1208 RVA: 0x00024614 File Offset: 0x00022814
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void a()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidRequest = new DataColumn("idRequest", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidRequest);
				this.columnidKladrObj = new DataColumn("idKladrObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidKladrObj);
				this.columnidKladrStreet = new DataColumn("idKladrStreet", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidKladrStreet);
				this.columnHouse = new DataColumn("House", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHouse);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnid
				}, true));
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = -1L;
				this.columnid.AutoIncrementStep = -1L;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
				this.columnidRequest.AllowDBNull = false;
				this.columnHouse.MaxLength = 50;
				this.columnName.MaxLength = 512;
			}

			// Token: 0x060004B9 RID: 1209 RVA: 0x000247C7 File Offset: 0x000229C7
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.x j()
			{
				return (DataSetGES.x)base.NewRow();
			}

			// Token: 0x060004BA RID: 1210 RVA: 0x000247D4 File Offset: 0x000229D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.x(builder);
			}

			// Token: 0x060004BB RID: 1211 RVA: 0x000247DC File Offset: 0x000229DC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.x);
			}

			// Token: 0x060004BC RID: 1212 RVA: 0x000247E8 File Offset: 0x000229E8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tJ_RequestForRepairAddressRowChanged != null)
				{
					this.tJ_RequestForRepairAddressRowChanged(this, new DataSetGES.al((DataSetGES.x)e.Row, e.Action));
				}
			}

			// Token: 0x060004BD RID: 1213 RVA: 0x0002481B File Offset: 0x00022A1B
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tJ_RequestForRepairAddressRowChanging != null)
				{
					this.tJ_RequestForRepairAddressRowChanging(this, new DataSetGES.al((DataSetGES.x)e.Row, e.Action));
				}
			}

			// Token: 0x060004BE RID: 1214 RVA: 0x0002484E File Offset: 0x00022A4E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tJ_RequestForRepairAddressRowDeleted != null)
				{
					this.tJ_RequestForRepairAddressRowDeleted(this, new DataSetGES.al((DataSetGES.x)e.Row, e.Action));
				}
			}

			// Token: 0x060004BF RID: 1215 RVA: 0x00024881 File Offset: 0x00022A81
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tJ_RequestForRepairAddressRowDeleting != null)
				{
					this.tJ_RequestForRepairAddressRowDeleting(this, new DataSetGES.al((DataSetGES.x)e.Row, e.Action));
				}
			}

			// Token: 0x060004C0 RID: 1216 RVA: 0x000248B4 File Offset: 0x00022AB4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void b(DataSetGES.x A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x060004C1 RID: 1217 RVA: 0x000248C4 File Offset: 0x00022AC4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tJ_RequestForRepairAddressDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000294 RID: 660
			private DataColumn columnid;

			// Token: 0x04000295 RID: 661
			private DataColumn columnidRequest;

			// Token: 0x04000296 RID: 662
			private DataColumn columnidKladrObj;

			// Token: 0x04000297 RID: 663
			private DataColumn columnidKladrStreet;

			// Token: 0x04000298 RID: 664
			private DataColumn columnHouse;

			// Token: 0x04000299 RID: 665
			private DataColumn columnName;
		}

		// Token: 0x02000069 RID: 105
		public class x : DataRow
		{
			// Token: 0x060004C2 RID: 1218 RVA: 0x00024AB8 File Offset: 0x00022CB8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal x(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.tJ_RequestForRepairAddressDataTable)base.Table;
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00024AD2 File Offset: 0x00022CD2
			// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00024AEA File Offset: 0x00022CEA
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int id
			{
				get
				{
					return (int)base[this.a.idColumn];
				}
				set
				{
					base[this.a.idColumn] = value;
				}
			}

			// Token: 0x060004C5 RID: 1221 RVA: 0x00024B03 File Offset: 0x00022D03
			public int b()
			{
				return (int)base[this.a.idRequestColumn];
			}

			// Token: 0x060004C6 RID: 1222 RVA: 0x00024B1B File Offset: 0x00022D1B
			public void b(int A_0)
			{
				base[this.a.idRequestColumn] = A_0;
			}

			// Token: 0x060004C7 RID: 1223 RVA: 0x00024B34 File Offset: 0x00022D34
			public int c()
			{
				int result;
				try
				{
					result = (int)base[this.a.idKladrObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idKladrObj' in table 'tJ_RequestForRepairAddress' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060004C8 RID: 1224 RVA: 0x00024B78 File Offset: 0x00022D78
			public void c(int A_0)
			{
				base[this.a.idKladrObjColumn] = A_0;
			}

			// Token: 0x060004C9 RID: 1225 RVA: 0x00024B94 File Offset: 0x00022D94
			public int d()
			{
				int result;
				try
				{
					result = (int)base[this.a.idKladrStreetColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idKladrStreet' in table 'tJ_RequestForRepairAddress' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060004CA RID: 1226 RVA: 0x00024BD8 File Offset: 0x00022DD8
			public void d(int A_0)
			{
				base[this.a.idKladrStreetColumn] = A_0;
			}

			// Token: 0x060004CB RID: 1227 RVA: 0x00024BF4 File Offset: 0x00022DF4
			public string e()
			{
				string result;
				try
				{
					result = (string)base[this.a.HouseColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'House' in table 'tJ_RequestForRepairAddress' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060004CC RID: 1228 RVA: 0x00024C38 File Offset: 0x00022E38
			public void a(string value)
			{
				base[this.a.HouseColumn] = value;
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x060004CD RID: 1229 RVA: 0x00024C4C File Offset: 0x00022E4C
			// (set) Token: 0x060004CE RID: 1230 RVA: 0x00024C90 File Offset: 0x00022E90
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.a.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'tJ_RequestForRepairAddress' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.NameColumn] = value;
				}
			}

			// Token: 0x060004CF RID: 1231 RVA: 0x00024CA4 File Offset: 0x00022EA4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool g()
			{
				return base.IsNull(this.a.idKladrObjColumn);
			}

			// Token: 0x060004D0 RID: 1232 RVA: 0x00024CB7 File Offset: 0x00022EB7
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void h()
			{
				base[this.a.idKladrObjColumn] = Convert.DBNull;
			}

			// Token: 0x060004D1 RID: 1233 RVA: 0x00024CCF File Offset: 0x00022ECF
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool i()
			{
				return base.IsNull(this.a.idKladrStreetColumn);
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x00024CE2 File Offset: 0x00022EE2
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void j()
			{
				base[this.a.idKladrStreetColumn] = Convert.DBNull;
			}

			// Token: 0x060004D3 RID: 1235 RVA: 0x00024CFA File Offset: 0x00022EFA
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool k()
			{
				return base.IsNull(this.a.HouseColumn);
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x00024D0D File Offset: 0x00022F0D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void l()
			{
				base[this.a.HouseColumn] = Convert.DBNull;
			}

			// Token: 0x060004D5 RID: 1237 RVA: 0x00024D25 File Offset: 0x00022F25
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool m()
			{
				return base.IsNull(this.a.NameColumn);
			}

			// Token: 0x060004D6 RID: 1238 RVA: 0x00024D38 File Offset: 0x00022F38
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void n()
			{
				base[this.a.NameColumn] = Convert.DBNull;
			}

			// Token: 0x0400029E RID: 670
			private DataSetGES.tJ_RequestForRepairAddressDataTable a;
		}

		// Token: 0x0200006A RID: 106
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tJ_DamageDataTable : TypedTableBase<DataSetGES.y>
		{
			// Token: 0x060004D7 RID: 1239 RVA: 0x00024D50 File Offset: 0x00022F50
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tJ_DamageDataTable()
			{
				base.TableName = "tJ_Damage";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x060004D8 RID: 1240 RVA: 0x00024D78 File Offset: 0x00022F78
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tJ_DamageDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x060004D9 RID: 1241 RVA: 0x00024E20 File Offset: 0x00023020
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected tJ_DamageDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.ai();
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x060004DA RID: 1242 RVA: 0x00024E30 File Offset: 0x00023030
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x060004DB RID: 1243 RVA: 0x00024E38 File Offset: 0x00023038
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn numDocColumn
			{
				get
				{
					return this.columnnumDoc;
				}
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x060004DC RID: 1244 RVA: 0x00024E40 File Offset: 0x00023040
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DateDocColumn
			{
				get
				{
					return this.columnDateDoc;
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x060004DD RID: 1245 RVA: 0x00024E48 File Offset: 0x00023048
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TypeDocColumn
			{
				get
				{
					return this.columnTypeDoc;
				}
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x060004DE RID: 1246 RVA: 0x00024E50 File Offset: 0x00023050
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NumRequestColumn
			{
				get
				{
					return this.columnNumRequest;
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x060004DF RID: 1247 RVA: 0x00024E58 File Offset: 0x00023058
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idCompilerColumn
			{
				get
				{
					return this.columnidCompiler;
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00024E60 File Offset: 0x00023060
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idDivisionColumn
			{
				get
				{
					return this.columnidDivision;
				}
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00024E68 File Offset: 0x00023068
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idSchmObjColumn
			{
				get
				{
					return this.columnidSchmObj;
				}
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00024E70 File Offset: 0x00023070
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idMapColumn
			{
				get
				{
					return this.columnidMap;
				}
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00024E78 File Offset: 0x00023078
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idLineSchmObjColumn
			{
				get
				{
					return this.columnidLineSchmObj;
				}
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00024E80 File Offset: 0x00023080
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idLineSectionColumn
			{
				get
				{
					return this.columnidLineSection;
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00024E88 File Offset: 0x00023088
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DefectLocationColumn
			{
				get
				{
					return this.columnDefectLocation;
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00024E90 File Offset: 0x00023090
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idReasonColumn
			{
				get
				{
					return this.columnidReason;
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00024E98 File Offset: 0x00023098
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idCompletedWorkColumn
			{
				get
				{
					return this.columnidCompletedWork;
				}
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00024EA0 File Offset: 0x000230A0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ComletedWorkTextColumn
			{
				get
				{
					return this.columnComletedWorkText;
				}
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00024EA8 File Offset: 0x000230A8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn isApplyColumn
			{
				get
				{
					return this.columnisApply;
				}
			}

			// Token: 0x170000F8 RID: 248
			// (get) Token: 0x060004EA RID: 1258 RVA: 0x00024EB0 File Offset: 0x000230B0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idWorkerApplyColumn
			{
				get
				{
					return this.columnidWorkerApply;
				}
			}

			// Token: 0x170000F9 RID: 249
			// (get) Token: 0x060004EB RID: 1259 RVA: 0x00024EB8 File Offset: 0x000230B8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DateApplyColumn
			{
				get
				{
					return this.columnDateApply;
				}
			}

			// Token: 0x170000FA RID: 250
			// (get) Token: 0x060004EC RID: 1260 RVA: 0x00024EC0 File Offset: 0x000230C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idDivisionApplyColumn
			{
				get
				{
					return this.columnidDivisionApply;
				}
			}

			// Token: 0x170000FB RID: 251
			// (get) Token: 0x060004ED RID: 1261 RVA: 0x00024EC8 File Offset: 0x000230C8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn isLaboratoryColumn
			{
				get
				{
					return this.columnisLaboratory;
				}
			}

			// Token: 0x170000FC RID: 252
			// (get) Token: 0x060004EE RID: 1262 RVA: 0x00024ED0 File Offset: 0x000230D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idParentColumn
			{
				get
				{
					return this.columnidParent;
				}
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x060004EF RID: 1263 RVA: 0x00024ED8 File Offset: 0x000230D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idOwnerColumn
			{
				get
				{
					return this.columnidOwner;
				}
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00024EE0 File Offset: 0x000230E0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DateOwnerColumn
			{
				get
				{
					return this.columnDateOwner;
				}
			}

			// Token: 0x170000FF RID: 255
			// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00024EE8 File Offset: 0x000230E8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DatePlanApplyColumn
			{
				get
				{
					return this.columnDatePlanApply;
				}
			}

			// Token: 0x17000100 RID: 256
			// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00024EF0 File Offset: 0x000230F0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idReasonPTSColumn
			{
				get
				{
					return this.columnidReasonPTS;
				}
			}

			// Token: 0x17000101 RID: 257
			// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00024EF8 File Offset: 0x000230F8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DivisionInstructionColumn
			{
				get
				{
					return this.columnDivisionInstruction;
				}
			}

			// Token: 0x17000102 RID: 258
			// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00024F00 File Offset: 0x00023100
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn LaboratoryInstructionColumn
			{
				get
				{
					return this.columnLaboratoryInstruction;
				}
			}

			// Token: 0x17000103 RID: 259
			// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00024F08 File Offset: 0x00023108
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idCompletedWorkODSColumn
			{
				get
				{
					return this.columnidCompletedWorkODS;
				}
			}

			// Token: 0x17000104 RID: 260
			// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00024F10 File Offset: 0x00023110
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CompletedWorkTextODSColumn
			{
				get
				{
					return this.columnCompletedWorkTextODS;
				}
			}

			// Token: 0x17000105 RID: 261
			// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00024F18 File Offset: 0x00023118
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CommentXmlColumn
			{
				get
				{
					return this.columnCommentXml;
				}
			}

			// Token: 0x17000106 RID: 262
			// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00024F20 File Offset: 0x00023120
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idReqForRepairColumn
			{
				get
				{
					return this.columnidReqForRepair;
				}
			}

			// Token: 0x17000107 RID: 263
			// (get) Token: 0x060004F9 RID: 1273 RVA: 0x00024F28 File Offset: 0x00023128
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DeletedColumn
			{
				get
				{
					return this.columnDeleted;
				}
			}

			// Token: 0x17000108 RID: 264
			// (get) Token: 0x060004FA RID: 1274 RVA: 0x00024F30 File Offset: 0x00023130
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

			// Token: 0x17000109 RID: 265
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.y this[int A_0]
			{
				get
				{
					return (DataSetGES.y)base.Rows[A_0];
				}
			}

			// Token: 0x14000030 RID: 48
			// (add) Token: 0x060004FC RID: 1276 RVA: 0x00024F50 File Offset: 0x00023150
			// (remove) Token: 0x060004FD RID: 1277 RVA: 0x00024F88 File Offset: 0x00023188
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.k tJ_DamageRowChanging;

			// Token: 0x14000031 RID: 49
			// (add) Token: 0x060004FE RID: 1278 RVA: 0x00024FC0 File Offset: 0x000231C0
			// (remove) Token: 0x060004FF RID: 1279 RVA: 0x00024FF8 File Offset: 0x000231F8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.k tJ_DamageRowChanged;

			// Token: 0x14000032 RID: 50
			// (add) Token: 0x06000500 RID: 1280 RVA: 0x00025030 File Offset: 0x00023230
			// (remove) Token: 0x06000501 RID: 1281 RVA: 0x00025068 File Offset: 0x00023268
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.k tJ_DamageRowDeleting;

			// Token: 0x14000033 RID: 51
			// (add) Token: 0x06000502 RID: 1282 RVA: 0x000250A0 File Offset: 0x000232A0
			// (remove) Token: 0x06000503 RID: 1283 RVA: 0x000250D8 File Offset: 0x000232D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.k tJ_DamageRowDeleted;

			// Token: 0x06000504 RID: 1284 RVA: 0x0002510D File Offset: 0x0002330D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void a(DataSetGES.y A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x06000505 RID: 1285 RVA: 0x0002511C File Offset: 0x0002331C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.y a(int A_0, DateTime A_1, int A_2, string A_3, int A_4, int A_5, int A_6, int A_7, int A_8, int A_9, string A_10, int A_11, int A_12, string A_13, bool A_14, int A_15, DateTime A_16, int A_17, bool A_18, int A_19, int A_20, DateTime A_21, DateTime A_22, int A_23, string A_24, string A_25, int A_26, string A_27, string A_28, int A_29, bool A_30)
			{
				DataSetGES.y y = (DataSetGES.y)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					A_0,
					A_1,
					A_2,
					A_3,
					A_4,
					A_5,
					A_6,
					A_7,
					A_8,
					A_9,
					A_10,
					A_11,
					A_12,
					A_13,
					A_14,
					A_15,
					A_16,
					A_17,
					A_18,
					A_19,
					A_20,
					A_21,
					A_22,
					A_23,
					A_24,
					A_25,
					A_26,
					A_27,
					A_28,
					A_29,
					A_30
				};
				y.ItemArray = itemArray;
				base.Rows.Add(y);
				return y;
			}

			// Token: 0x06000506 RID: 1286 RVA: 0x00025278 File Offset: 0x00023478
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.y b(int A_0)
			{
				return (DataSetGES.y)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x06000507 RID: 1287 RVA: 0x00025299 File Offset: 0x00023499
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetGES.tJ_DamageDataTable tJ_DamageDataTable = (DataSetGES.tJ_DamageDataTable)base.Clone();
				tJ_DamageDataTable.ai();
				return tJ_DamageDataTable;
			}

			// Token: 0x06000508 RID: 1288 RVA: 0x000252AC File Offset: 0x000234AC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.tJ_DamageDataTable();
			}

			// Token: 0x06000509 RID: 1289 RVA: 0x000252B4 File Offset: 0x000234B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void ai()
			{
				this.columnid = base.Columns["id"];
				this.columnnumDoc = base.Columns["numDoc"];
				this.columnDateDoc = base.Columns["DateDoc"];
				this.columnTypeDoc = base.Columns["TypeDoc"];
				this.columnNumRequest = base.Columns["NumRequest"];
				this.columnidCompiler = base.Columns["idCompiler"];
				this.columnidDivision = base.Columns["idDivision"];
				this.columnidSchmObj = base.Columns["idSchmObj"];
				this.columnidMap = base.Columns["idMap"];
				this.columnidLineSchmObj = base.Columns["idLineSchmObj"];
				this.columnidLineSection = base.Columns["idLineSection"];
				this.columnDefectLocation = base.Columns["DefectLocation"];
				this.columnidReason = base.Columns["idReason"];
				this.columnidCompletedWork = base.Columns["idCompletedWork"];
				this.columnComletedWorkText = base.Columns["ComletedWorkText"];
				this.columnisApply = base.Columns["isApply"];
				this.columnidWorkerApply = base.Columns["idWorkerApply"];
				this.columnDateApply = base.Columns["DateApply"];
				this.columnidDivisionApply = base.Columns["idDivisionApply"];
				this.columnisLaboratory = base.Columns["isLaboratory"];
				this.columnidParent = base.Columns["idParent"];
				this.columnidOwner = base.Columns["idOwner"];
				this.columnDateOwner = base.Columns["DateOwner"];
				this.columnDatePlanApply = base.Columns["DatePlanApply"];
				this.columnidReasonPTS = base.Columns["idReasonPTS"];
				this.columnDivisionInstruction = base.Columns["DivisionInstruction"];
				this.columnLaboratoryInstruction = base.Columns["LaboratoryInstruction"];
				this.columnidCompletedWorkODS = base.Columns["idCompletedWorkODS"];
				this.columnCompletedWorkTextODS = base.Columns["CompletedWorkTextODS"];
				this.columnCommentXml = base.Columns["CommentXml"];
				this.columnidReqForRepair = base.Columns["idReqForRepair"];
				this.columnDeleted = base.Columns["Deleted"];
			}

			// Token: 0x0600050A RID: 1290 RVA: 0x00025584 File Offset: 0x00023784
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void a()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnnumDoc = new DataColumn("numDoc", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnnumDoc);
				this.columnDateDoc = new DataColumn("DateDoc", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateDoc);
				this.columnTypeDoc = new DataColumn("TypeDoc", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTypeDoc);
				this.columnNumRequest = new DataColumn("NumRequest", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNumRequest);
				this.columnidCompiler = new DataColumn("idCompiler", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidCompiler);
				this.columnidDivision = new DataColumn("idDivision", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidDivision);
				this.columnidSchmObj = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidSchmObj);
				this.columnidMap = new DataColumn("idMap", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidMap);
				this.columnidLineSchmObj = new DataColumn("idLineSchmObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidLineSchmObj);
				this.columnidLineSection = new DataColumn("idLineSection", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidLineSection);
				this.columnDefectLocation = new DataColumn("DefectLocation", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDefectLocation);
				this.columnidReason = new DataColumn("idReason", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidReason);
				this.columnidCompletedWork = new DataColumn("idCompletedWork", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidCompletedWork);
				this.columnComletedWorkText = new DataColumn("ComletedWorkText", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnComletedWorkText);
				this.columnisApply = new DataColumn("isApply", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnisApply);
				this.columnidWorkerApply = new DataColumn("idWorkerApply", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidWorkerApply);
				this.columnDateApply = new DataColumn("DateApply", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateApply);
				this.columnidDivisionApply = new DataColumn("idDivisionApply", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidDivisionApply);
				this.columnisLaboratory = new DataColumn("isLaboratory", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnisLaboratory);
				this.columnidParent = new DataColumn("idParent", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidParent);
				this.columnidOwner = new DataColumn("idOwner", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidOwner);
				this.columnDateOwner = new DataColumn("DateOwner", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateOwner);
				this.columnDatePlanApply = new DataColumn("DatePlanApply", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDatePlanApply);
				this.columnidReasonPTS = new DataColumn("idReasonPTS", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidReasonPTS);
				this.columnDivisionInstruction = new DataColumn("DivisionInstruction", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDivisionInstruction);
				this.columnLaboratoryInstruction = new DataColumn("LaboratoryInstruction", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnLaboratoryInstruction);
				this.columnidCompletedWorkODS = new DataColumn("idCompletedWorkODS", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidCompletedWorkODS);
				this.columnCompletedWorkTextODS = new DataColumn("CompletedWorkTextODS", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCompletedWorkTextODS);
				this.columnCommentXml = new DataColumn("CommentXml", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCommentXml);
				this.columnidReqForRepair = new DataColumn("idReqForRepair", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidReqForRepair);
				this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnDeleted);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnid
				}, true));
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = -1L;
				this.columnid.AutoIncrementStep = -1L;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
				this.columnTypeDoc.AllowDBNull = false;
				this.columnNumRequest.MaxLength = 50;
				this.columnDefectLocation.MaxLength = 1024;
				this.columnComletedWorkText.MaxLength = 2028;
				this.columnDivisionInstruction.MaxLength = 2028;
				this.columnLaboratoryInstruction.MaxLength = 2028;
				this.columnCompletedWorkTextODS.MaxLength = 2028;
				this.columnCommentXml.MaxLength = int.MaxValue;
				this.columnDeleted.AllowDBNull = false;
				this.columnDeleted.DefaultValue = false;
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x00025C36 File Offset: 0x00023E36
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.y aj()
			{
				return (DataSetGES.y)base.NewRow();
			}

			// Token: 0x0600050C RID: 1292 RVA: 0x00025C43 File Offset: 0x00023E43
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.y(builder);
			}

			// Token: 0x0600050D RID: 1293 RVA: 0x00025C4B File Offset: 0x00023E4B
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.y);
			}

			// Token: 0x0600050E RID: 1294 RVA: 0x00025C57 File Offset: 0x00023E57
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tJ_DamageRowChanged != null)
				{
					this.tJ_DamageRowChanged(this, new DataSetGES.am((DataSetGES.y)e.Row, e.Action));
				}
			}

			// Token: 0x0600050F RID: 1295 RVA: 0x00025C8A File Offset: 0x00023E8A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tJ_DamageRowChanging != null)
				{
					this.tJ_DamageRowChanging(this, new DataSetGES.am((DataSetGES.y)e.Row, e.Action));
				}
			}

			// Token: 0x06000510 RID: 1296 RVA: 0x00025CBD File Offset: 0x00023EBD
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tJ_DamageRowDeleted != null)
				{
					this.tJ_DamageRowDeleted(this, new DataSetGES.am((DataSetGES.y)e.Row, e.Action));
				}
			}

			// Token: 0x06000511 RID: 1297 RVA: 0x00025CF0 File Offset: 0x00023EF0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tJ_DamageRowDeleting != null)
				{
					this.tJ_DamageRowDeleting(this, new DataSetGES.am((DataSetGES.y)e.Row, e.Action));
				}
			}

			// Token: 0x06000512 RID: 1298 RVA: 0x00025D23 File Offset: 0x00023F23
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void b(DataSetGES.y A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x06000513 RID: 1299 RVA: 0x00025D34 File Offset: 0x00023F34
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tJ_DamageDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x0400029F RID: 671
			private DataColumn columnid;

			// Token: 0x040002A0 RID: 672
			private DataColumn columnnumDoc;

			// Token: 0x040002A1 RID: 673
			private DataColumn columnDateDoc;

			// Token: 0x040002A2 RID: 674
			private DataColumn columnTypeDoc;

			// Token: 0x040002A3 RID: 675
			private DataColumn columnNumRequest;

			// Token: 0x040002A4 RID: 676
			private DataColumn columnidCompiler;

			// Token: 0x040002A5 RID: 677
			private DataColumn columnidDivision;

			// Token: 0x040002A6 RID: 678
			private DataColumn columnidSchmObj;

			// Token: 0x040002A7 RID: 679
			private DataColumn columnidMap;

			// Token: 0x040002A8 RID: 680
			private DataColumn columnidLineSchmObj;

			// Token: 0x040002A9 RID: 681
			private DataColumn columnidLineSection;

			// Token: 0x040002AA RID: 682
			private DataColumn columnDefectLocation;

			// Token: 0x040002AB RID: 683
			private DataColumn columnidReason;

			// Token: 0x040002AC RID: 684
			private DataColumn columnidCompletedWork;

			// Token: 0x040002AD RID: 685
			private DataColumn columnComletedWorkText;

			// Token: 0x040002AE RID: 686
			private DataColumn columnisApply;

			// Token: 0x040002AF RID: 687
			private DataColumn columnidWorkerApply;

			// Token: 0x040002B0 RID: 688
			private DataColumn columnDateApply;

			// Token: 0x040002B1 RID: 689
			private DataColumn columnidDivisionApply;

			// Token: 0x040002B2 RID: 690
			private DataColumn columnisLaboratory;

			// Token: 0x040002B3 RID: 691
			private DataColumn columnidParent;

			// Token: 0x040002B4 RID: 692
			private DataColumn columnidOwner;

			// Token: 0x040002B5 RID: 693
			private DataColumn columnDateOwner;

			// Token: 0x040002B6 RID: 694
			private DataColumn columnDatePlanApply;

			// Token: 0x040002B7 RID: 695
			private DataColumn columnidReasonPTS;

			// Token: 0x040002B8 RID: 696
			private DataColumn columnDivisionInstruction;

			// Token: 0x040002B9 RID: 697
			private DataColumn columnLaboratoryInstruction;

			// Token: 0x040002BA RID: 698
			private DataColumn columnidCompletedWorkODS;

			// Token: 0x040002BB RID: 699
			private DataColumn columnCompletedWorkTextODS;

			// Token: 0x040002BC RID: 700
			private DataColumn columnCommentXml;

			// Token: 0x040002BD RID: 701
			private DataColumn columnidReqForRepair;

			// Token: 0x040002BE RID: 702
			private DataColumn columnDeleted;
		}

		// Token: 0x0200006B RID: 107
		public class y : DataRow
		{
			// Token: 0x06000514 RID: 1300 RVA: 0x00025F28 File Offset: 0x00024128
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal y(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.tJ_DamageDataTable)base.Table;
			}

			// Token: 0x1700010A RID: 266
			// (get) Token: 0x06000515 RID: 1301 RVA: 0x00025F42 File Offset: 0x00024142
			// (set) Token: 0x06000516 RID: 1302 RVA: 0x00025F5A File Offset: 0x0002415A
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int id
			{
				get
				{
					return (int)base[this.a.idColumn];
				}
				set
				{
					base[this.a.idColumn] = value;
				}
			}

			// Token: 0x06000517 RID: 1303 RVA: 0x00025F74 File Offset: 0x00024174
			public int b()
			{
				int result;
				try
				{
					result = (int)base[this.a.numDocColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numDoc' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000518 RID: 1304 RVA: 0x00025FB8 File Offset: 0x000241B8
			public void b(int A_0)
			{
				base[this.a.numDocColumn] = A_0;
			}

			// Token: 0x06000519 RID: 1305 RVA: 0x00025FD4 File Offset: 0x000241D4
			public DateTime c()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.a.DateDocColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateDoc' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600051A RID: 1306 RVA: 0x00026018 File Offset: 0x00024218
			public void a(DateTime A_0)
			{
				base[this.a.DateDocColumn] = A_0;
			}

			// Token: 0x0600051B RID: 1307 RVA: 0x00026031 File Offset: 0x00024231
			public int d()
			{
				return (int)base[this.a.TypeDocColumn];
			}

			// Token: 0x0600051C RID: 1308 RVA: 0x00026049 File Offset: 0x00024249
			public void c(int A_0)
			{
				base[this.a.TypeDocColumn] = A_0;
			}

			// Token: 0x0600051D RID: 1309 RVA: 0x00026064 File Offset: 0x00024264
			public string e()
			{
				string result;
				try
				{
					result = (string)base[this.a.NumRequestColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NumRequest' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600051E RID: 1310 RVA: 0x000260A8 File Offset: 0x000242A8
			public void a(string value)
			{
				base[this.a.NumRequestColumn] = value;
			}

			// Token: 0x0600051F RID: 1311 RVA: 0x000260BC File Offset: 0x000242BC
			public int f()
			{
				int result;
				try
				{
					result = (int)base[this.a.idCompilerColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idCompiler' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000520 RID: 1312 RVA: 0x00026100 File Offset: 0x00024300
			public void d(int A_0)
			{
				base[this.a.idCompilerColumn] = A_0;
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x0002611C File Offset: 0x0002431C
			public int g()
			{
				int result;
				try
				{
					result = (int)base[this.a.idDivisionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idDivision' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000522 RID: 1314 RVA: 0x00026160 File Offset: 0x00024360
			public void e(int A_0)
			{
				base[this.a.idDivisionColumn] = A_0;
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x06000523 RID: 1315 RVA: 0x0002617C File Offset: 0x0002437C
			// (set) Token: 0x06000524 RID: 1316 RVA: 0x000261C0 File Offset: 0x000243C0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idSchmObj
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.a.idSchmObjColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idSchmObj' in table 'tJ_Damage' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.a.idSchmObjColumn] = value;
				}
			}

			// Token: 0x06000525 RID: 1317 RVA: 0x000261DC File Offset: 0x000243DC
			public int i()
			{
				int result;
				try
				{
					result = (int)base[this.a.idMapColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idMap' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000526 RID: 1318 RVA: 0x00026220 File Offset: 0x00024420
			public void g(int A_0)
			{
				base[this.a.idMapColumn] = A_0;
			}

			// Token: 0x06000527 RID: 1319 RVA: 0x0002623C File Offset: 0x0002443C
			public int j()
			{
				int result;
				try
				{
					result = (int)base[this.a.idLineSchmObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idLineSchmObj' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000528 RID: 1320 RVA: 0x00026280 File Offset: 0x00024480
			public void h(int A_0)
			{
				base[this.a.idLineSchmObjColumn] = A_0;
			}

			// Token: 0x06000529 RID: 1321 RVA: 0x0002629C File Offset: 0x0002449C
			public int k()
			{
				int result;
				try
				{
					result = (int)base[this.a.idLineSectionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idLineSection' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x000262E0 File Offset: 0x000244E0
			public void i(int A_0)
			{
				base[this.a.idLineSectionColumn] = A_0;
			}

			// Token: 0x0600052B RID: 1323 RVA: 0x000262FC File Offset: 0x000244FC
			public string l()
			{
				string result;
				try
				{
					result = (string)base[this.a.DefectLocationColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DefectLocation' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600052C RID: 1324 RVA: 0x00026340 File Offset: 0x00024540
			public void b(string value)
			{
				base[this.a.DefectLocationColumn] = value;
			}

			// Token: 0x0600052D RID: 1325 RVA: 0x00026354 File Offset: 0x00024554
			public int m()
			{
				int result;
				try
				{
					result = (int)base[this.a.idReasonColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idReason' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600052E RID: 1326 RVA: 0x00026398 File Offset: 0x00024598
			public void j(int A_0)
			{
				base[this.a.idReasonColumn] = A_0;
			}

			// Token: 0x0600052F RID: 1327 RVA: 0x000263B4 File Offset: 0x000245B4
			public int n()
			{
				int result;
				try
				{
					result = (int)base[this.a.idCompletedWorkColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idCompletedWork' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000530 RID: 1328 RVA: 0x000263F8 File Offset: 0x000245F8
			public void k(int A_0)
			{
				base[this.a.idCompletedWorkColumn] = A_0;
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x00026414 File Offset: 0x00024614
			public string o()
			{
				string result;
				try
				{
					result = (string)base[this.a.ComletedWorkTextColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ComletedWorkText' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000532 RID: 1330 RVA: 0x00026458 File Offset: 0x00024658
			public void c(string value)
			{
				base[this.a.ComletedWorkTextColumn] = value;
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x0002646C File Offset: 0x0002466C
			public bool p()
			{
				bool result;
				try
				{
					result = (bool)base[this.a.isApplyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isApply' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x000264B0 File Offset: 0x000246B0
			public void a(bool A_0)
			{
				base[this.a.isApplyColumn] = A_0;
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x000264CC File Offset: 0x000246CC
			public int q()
			{
				int result;
				try
				{
					result = (int)base[this.a.idWorkerApplyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idWorkerApply' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x00026510 File Offset: 0x00024710
			public void l(int A_0)
			{
				base[this.a.idWorkerApplyColumn] = A_0;
			}

			// Token: 0x06000537 RID: 1335 RVA: 0x0002652C File Offset: 0x0002472C
			public DateTime r()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.a.DateApplyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateApply' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000538 RID: 1336 RVA: 0x00026570 File Offset: 0x00024770
			public void b(DateTime A_0)
			{
				base[this.a.DateApplyColumn] = A_0;
			}

			// Token: 0x06000539 RID: 1337 RVA: 0x0002658C File Offset: 0x0002478C
			public int s()
			{
				int result;
				try
				{
					result = (int)base[this.a.idDivisionApplyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idDivisionApply' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600053A RID: 1338 RVA: 0x000265D0 File Offset: 0x000247D0
			public void m(int A_0)
			{
				base[this.a.idDivisionApplyColumn] = A_0;
			}

			// Token: 0x0600053B RID: 1339 RVA: 0x000265EC File Offset: 0x000247EC
			public bool t()
			{
				bool result;
				try
				{
					result = (bool)base[this.a.isLaboratoryColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isLaboratory' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600053C RID: 1340 RVA: 0x00026630 File Offset: 0x00024830
			public void b(bool A_0)
			{
				base[this.a.isLaboratoryColumn] = A_0;
			}

			// Token: 0x0600053D RID: 1341 RVA: 0x0002664C File Offset: 0x0002484C
			public int u()
			{
				int result;
				try
				{
					result = (int)base[this.a.idParentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idParent' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600053E RID: 1342 RVA: 0x00026690 File Offset: 0x00024890
			public void n(int A_0)
			{
				base[this.a.idParentColumn] = A_0;
			}

			// Token: 0x0600053F RID: 1343 RVA: 0x000266AC File Offset: 0x000248AC
			public int v()
			{
				int result;
				try
				{
					result = (int)base[this.a.idOwnerColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idOwner' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000540 RID: 1344 RVA: 0x000266F0 File Offset: 0x000248F0
			public void o(int A_0)
			{
				base[this.a.idOwnerColumn] = A_0;
			}

			// Token: 0x06000541 RID: 1345 RVA: 0x0002670C File Offset: 0x0002490C
			public DateTime w()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.a.DateOwnerColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateOwner' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000542 RID: 1346 RVA: 0x00026750 File Offset: 0x00024950
			public void c(DateTime A_0)
			{
				base[this.a.DateOwnerColumn] = A_0;
			}

			// Token: 0x06000543 RID: 1347 RVA: 0x0002676C File Offset: 0x0002496C
			public DateTime x()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.a.DatePlanApplyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DatePlanApply' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000544 RID: 1348 RVA: 0x000267B0 File Offset: 0x000249B0
			public void d(DateTime A_0)
			{
				base[this.a.DatePlanApplyColumn] = A_0;
			}

			// Token: 0x06000545 RID: 1349 RVA: 0x000267CC File Offset: 0x000249CC
			public int y()
			{
				int result;
				try
				{
					result = (int)base[this.a.idReasonPTSColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idReasonPTS' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000546 RID: 1350 RVA: 0x00026810 File Offset: 0x00024A10
			public void p(int A_0)
			{
				base[this.a.idReasonPTSColumn] = A_0;
			}

			// Token: 0x06000547 RID: 1351 RVA: 0x0002682C File Offset: 0x00024A2C
			public string z()
			{
				string result;
				try
				{
					result = (string)base[this.a.DivisionInstructionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DivisionInstruction' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000548 RID: 1352 RVA: 0x00026870 File Offset: 0x00024A70
			public void d(string value)
			{
				base[this.a.DivisionInstructionColumn] = value;
			}

			// Token: 0x06000549 RID: 1353 RVA: 0x00026884 File Offset: 0x00024A84
			public string aa()
			{
				string result;
				try
				{
					result = (string)base[this.a.LaboratoryInstructionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'LaboratoryInstruction' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x000268C8 File Offset: 0x00024AC8
			public void e(string value)
			{
				base[this.a.LaboratoryInstructionColumn] = value;
			}

			// Token: 0x0600054B RID: 1355 RVA: 0x000268DC File Offset: 0x00024ADC
			public int ab()
			{
				int result;
				try
				{
					result = (int)base[this.a.idCompletedWorkODSColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idCompletedWorkODS' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600054C RID: 1356 RVA: 0x00026920 File Offset: 0x00024B20
			public void q(int A_0)
			{
				base[this.a.idCompletedWorkODSColumn] = A_0;
			}

			// Token: 0x0600054D RID: 1357 RVA: 0x0002693C File Offset: 0x00024B3C
			public string ac()
			{
				string result;
				try
				{
					result = (string)base[this.a.CompletedWorkTextODSColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CompletedWorkTextODS' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600054E RID: 1358 RVA: 0x00026980 File Offset: 0x00024B80
			public void f(string value)
			{
				base[this.a.CompletedWorkTextODSColumn] = value;
			}

			// Token: 0x0600054F RID: 1359 RVA: 0x00026994 File Offset: 0x00024B94
			public string ad()
			{
				string result;
				try
				{
					result = (string)base[this.a.CommentXmlColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CommentXml' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000550 RID: 1360 RVA: 0x000269D8 File Offset: 0x00024BD8
			public void g(string value)
			{
				base[this.a.CommentXmlColumn] = value;
			}

			// Token: 0x06000551 RID: 1361 RVA: 0x000269EC File Offset: 0x00024BEC
			public int ae()
			{
				int result;
				try
				{
					result = (int)base[this.a.idReqForRepairColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idReqForRepair' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000552 RID: 1362 RVA: 0x00026A30 File Offset: 0x00024C30
			public void r(int A_0)
			{
				base[this.a.idReqForRepairColumn] = A_0;
			}

			// Token: 0x06000553 RID: 1363 RVA: 0x00026A49 File Offset: 0x00024C49
			public bool af()
			{
				return (bool)base[this.a.DeletedColumn];
			}

			// Token: 0x06000554 RID: 1364 RVA: 0x00026A61 File Offset: 0x00024C61
			public void c(bool A_0)
			{
				base[this.a.DeletedColumn] = A_0;
			}

			// Token: 0x06000555 RID: 1365 RVA: 0x00026A7A File Offset: 0x00024C7A
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool ag()
			{
				return base.IsNull(this.a.numDocColumn);
			}

			// Token: 0x06000556 RID: 1366 RVA: 0x00026A8D File Offset: 0x00024C8D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void ah()
			{
				base[this.a.numDocColumn] = Convert.DBNull;
			}

			// Token: 0x06000557 RID: 1367 RVA: 0x00026AA5 File Offset: 0x00024CA5
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool ai()
			{
				return base.IsNull(this.a.DateDocColumn);
			}

			// Token: 0x06000558 RID: 1368 RVA: 0x00026AB8 File Offset: 0x00024CB8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void aj()
			{
				base[this.a.DateDocColumn] = Convert.DBNull;
			}

			// Token: 0x06000559 RID: 1369 RVA: 0x00026AD0 File Offset: 0x00024CD0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool ak()
			{
				return base.IsNull(this.a.NumRequestColumn);
			}

			// Token: 0x0600055A RID: 1370 RVA: 0x00026AE3 File Offset: 0x00024CE3
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void al()
			{
				base[this.a.NumRequestColumn] = Convert.DBNull;
			}

			// Token: 0x0600055B RID: 1371 RVA: 0x00026AFB File Offset: 0x00024CFB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool am()
			{
				return base.IsNull(this.a.idCompilerColumn);
			}

			// Token: 0x0600055C RID: 1372 RVA: 0x00026B0E File Offset: 0x00024D0E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void an()
			{
				base[this.a.idCompilerColumn] = Convert.DBNull;
			}

			// Token: 0x0600055D RID: 1373 RVA: 0x00026B26 File Offset: 0x00024D26
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool ao()
			{
				return base.IsNull(this.a.idDivisionColumn);
			}

			// Token: 0x0600055E RID: 1374 RVA: 0x00026B39 File Offset: 0x00024D39
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void ap()
			{
				base[this.a.idDivisionColumn] = Convert.DBNull;
			}

			// Token: 0x0600055F RID: 1375 RVA: 0x00026B51 File Offset: 0x00024D51
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool aq()
			{
				return base.IsNull(this.a.idSchmObjColumn);
			}

			// Token: 0x06000560 RID: 1376 RVA: 0x00026B64 File Offset: 0x00024D64
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void ar()
			{
				base[this.a.idSchmObjColumn] = Convert.DBNull;
			}

			// Token: 0x06000561 RID: 1377 RVA: 0x00026B7C File Offset: 0x00024D7C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool @as()
			{
				return base.IsNull(this.a.idMapColumn);
			}

			// Token: 0x06000562 RID: 1378 RVA: 0x00026B8F File Offset: 0x00024D8F
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void at()
			{
				base[this.a.idMapColumn] = Convert.DBNull;
			}

			// Token: 0x06000563 RID: 1379 RVA: 0x00026BA7 File Offset: 0x00024DA7
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool au()
			{
				return base.IsNull(this.a.idLineSchmObjColumn);
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x00026BBA File Offset: 0x00024DBA
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void av()
			{
				base[this.a.idLineSchmObjColumn] = Convert.DBNull;
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x00026BD2 File Offset: 0x00024DD2
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool aw()
			{
				return base.IsNull(this.a.idLineSectionColumn);
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x00026BE5 File Offset: 0x00024DE5
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void ax()
			{
				base[this.a.idLineSectionColumn] = Convert.DBNull;
			}

			// Token: 0x06000567 RID: 1383 RVA: 0x00026BFD File Offset: 0x00024DFD
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool ay()
			{
				return base.IsNull(this.a.DefectLocationColumn);
			}

			// Token: 0x06000568 RID: 1384 RVA: 0x00026C10 File Offset: 0x00024E10
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void az()
			{
				base[this.a.DefectLocationColumn] = Convert.DBNull;
			}

			// Token: 0x06000569 RID: 1385 RVA: 0x00026C28 File Offset: 0x00024E28
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool a0()
			{
				return base.IsNull(this.a.idReasonColumn);
			}

			// Token: 0x0600056A RID: 1386 RVA: 0x00026C3B File Offset: 0x00024E3B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void a1()
			{
				base[this.a.idReasonColumn] = Convert.DBNull;
			}

			// Token: 0x0600056B RID: 1387 RVA: 0x00026C53 File Offset: 0x00024E53
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool a2()
			{
				return base.IsNull(this.a.idCompletedWorkColumn);
			}

			// Token: 0x0600056C RID: 1388 RVA: 0x00026C66 File Offset: 0x00024E66
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void a3()
			{
				base[this.a.idCompletedWorkColumn] = Convert.DBNull;
			}

			// Token: 0x0600056D RID: 1389 RVA: 0x00026C7E File Offset: 0x00024E7E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool a4()
			{
				return base.IsNull(this.a.ComletedWorkTextColumn);
			}

			// Token: 0x0600056E RID: 1390 RVA: 0x00026C91 File Offset: 0x00024E91
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void a5()
			{
				base[this.a.ComletedWorkTextColumn] = Convert.DBNull;
			}

			// Token: 0x0600056F RID: 1391 RVA: 0x00026CA9 File Offset: 0x00024EA9
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool a6()
			{
				return base.IsNull(this.a.isApplyColumn);
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x00026CBC File Offset: 0x00024EBC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void a7()
			{
				base[this.a.isApplyColumn] = Convert.DBNull;
			}

			// Token: 0x06000571 RID: 1393 RVA: 0x00026CD4 File Offset: 0x00024ED4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool a8()
			{
				return base.IsNull(this.a.idWorkerApplyColumn);
			}

			// Token: 0x06000572 RID: 1394 RVA: 0x00026CE7 File Offset: 0x00024EE7
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void a9()
			{
				base[this.a.idWorkerApplyColumn] = Convert.DBNull;
			}

			// Token: 0x06000573 RID: 1395 RVA: 0x00026CFF File Offset: 0x00024EFF
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool ba()
			{
				return base.IsNull(this.a.DateApplyColumn);
			}

			// Token: 0x06000574 RID: 1396 RVA: 0x00026D12 File Offset: 0x00024F12
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void bb()
			{
				base[this.a.DateApplyColumn] = Convert.DBNull;
			}

			// Token: 0x06000575 RID: 1397 RVA: 0x00026D2A File Offset: 0x00024F2A
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool bc()
			{
				return base.IsNull(this.a.idDivisionApplyColumn);
			}

			// Token: 0x06000576 RID: 1398 RVA: 0x00026D3D File Offset: 0x00024F3D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void bd()
			{
				base[this.a.idDivisionApplyColumn] = Convert.DBNull;
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x00026D55 File Offset: 0x00024F55
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool be()
			{
				return base.IsNull(this.a.isLaboratoryColumn);
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x00026D68 File Offset: 0x00024F68
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bf()
			{
				base[this.a.isLaboratoryColumn] = Convert.DBNull;
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x00026D80 File Offset: 0x00024F80
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bg()
			{
				return base.IsNull(this.a.idParentColumn);
			}

			// Token: 0x0600057A RID: 1402 RVA: 0x00026D93 File Offset: 0x00024F93
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bh()
			{
				base[this.a.idParentColumn] = Convert.DBNull;
			}

			// Token: 0x0600057B RID: 1403 RVA: 0x00026DAB File Offset: 0x00024FAB
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool bi()
			{
				return base.IsNull(this.a.idOwnerColumn);
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x00026DBE File Offset: 0x00024FBE
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bj()
			{
				base[this.a.idOwnerColumn] = Convert.DBNull;
			}

			// Token: 0x0600057D RID: 1405 RVA: 0x00026DD6 File Offset: 0x00024FD6
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bk()
			{
				return base.IsNull(this.a.DateOwnerColumn);
			}

			// Token: 0x0600057E RID: 1406 RVA: 0x00026DE9 File Offset: 0x00024FE9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void bl()
			{
				base[this.a.DateOwnerColumn] = Convert.DBNull;
			}

			// Token: 0x0600057F RID: 1407 RVA: 0x00026E01 File Offset: 0x00025001
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bm()
			{
				return base.IsNull(this.a.DatePlanApplyColumn);
			}

			// Token: 0x06000580 RID: 1408 RVA: 0x00026E14 File Offset: 0x00025014
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bn()
			{
				base[this.a.DatePlanApplyColumn] = Convert.DBNull;
			}

			// Token: 0x06000581 RID: 1409 RVA: 0x00026E2C File Offset: 0x0002502C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bo()
			{
				return base.IsNull(this.a.idReasonPTSColumn);
			}

			// Token: 0x06000582 RID: 1410 RVA: 0x00026E3F File Offset: 0x0002503F
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bp()
			{
				base[this.a.idReasonPTSColumn] = Convert.DBNull;
			}

			// Token: 0x06000583 RID: 1411 RVA: 0x00026E57 File Offset: 0x00025057
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool bq()
			{
				return base.IsNull(this.a.DivisionInstructionColumn);
			}

			// Token: 0x06000584 RID: 1412 RVA: 0x00026E6A File Offset: 0x0002506A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void br()
			{
				base[this.a.DivisionInstructionColumn] = Convert.DBNull;
			}

			// Token: 0x06000585 RID: 1413 RVA: 0x00026E82 File Offset: 0x00025082
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool bs()
			{
				return base.IsNull(this.a.LaboratoryInstructionColumn);
			}

			// Token: 0x06000586 RID: 1414 RVA: 0x00026E95 File Offset: 0x00025095
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void bt()
			{
				base[this.a.LaboratoryInstructionColumn] = Convert.DBNull;
			}

			// Token: 0x06000587 RID: 1415 RVA: 0x00026EAD File Offset: 0x000250AD
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool bu()
			{
				return base.IsNull(this.a.idCompletedWorkODSColumn);
			}

			// Token: 0x06000588 RID: 1416 RVA: 0x00026EC0 File Offset: 0x000250C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bv()
			{
				base[this.a.idCompletedWorkODSColumn] = Convert.DBNull;
			}

			// Token: 0x06000589 RID: 1417 RVA: 0x00026ED8 File Offset: 0x000250D8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool bw()
			{
				return base.IsNull(this.a.CompletedWorkTextODSColumn);
			}

			// Token: 0x0600058A RID: 1418 RVA: 0x00026EEB File Offset: 0x000250EB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bx()
			{
				base[this.a.CompletedWorkTextODSColumn] = Convert.DBNull;
			}

			// Token: 0x0600058B RID: 1419 RVA: 0x00026F03 File Offset: 0x00025103
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool by()
			{
				return base.IsNull(this.a.CommentXmlColumn);
			}

			// Token: 0x0600058C RID: 1420 RVA: 0x00026F16 File Offset: 0x00025116
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void bz()
			{
				base[this.a.CommentXmlColumn] = Convert.DBNull;
			}

			// Token: 0x0600058D RID: 1421 RVA: 0x00026F2E File Offset: 0x0002512E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool b0()
			{
				return base.IsNull(this.a.idReqForRepairColumn);
			}

			// Token: 0x0600058E RID: 1422 RVA: 0x00026F41 File Offset: 0x00025141
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void b1()
			{
				base[this.a.idReqForRepairColumn] = Convert.DBNull;
			}

			// Token: 0x040002C3 RID: 707
			private DataSetGES.tJ_DamageDataTable a;
		}

		// Token: 0x0200006C RID: 108
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tJ_DamageHVDataTable : TypedTableBase<DataSetGES.z>
		{
			// Token: 0x0600058F RID: 1423 RVA: 0x00026F59 File Offset: 0x00025159
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tJ_DamageHVDataTable()
			{
				base.TableName = "tJ_DamageHV";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x06000590 RID: 1424 RVA: 0x00026F80 File Offset: 0x00025180
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tJ_DamageHVDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x06000591 RID: 1425 RVA: 0x00027028 File Offset: 0x00025228
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected tJ_DamageHVDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.q();
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x06000592 RID: 1426 RVA: 0x00027038 File Offset: 0x00025238
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idDamageColumn
			{
				get
				{
					return this.columnidDamage;
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x06000593 RID: 1427 RVA: 0x00027040 File Offset: 0x00025240
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTypeRZAColumn
			{
				get
				{
					return this.columnidTypeRZA;
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000594 RID: 1428 RVA: 0x00027048 File Offset: 0x00025248
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CountSchmObjColumn
			{
				get
				{
					return this.columnCountSchmObj;
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000595 RID: 1429 RVA: 0x00027050 File Offset: 0x00025250
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CountSchmObjOffColumn
			{
				get
				{
					return this.columnCountSchmObjOff;
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000596 RID: 1430 RVA: 0x00027058 File Offset: 0x00025258
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ConnectedPowerColumn
			{
				get
				{
					return this.columnConnectedPower;
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000597 RID: 1431 RVA: 0x00027060 File Offset: 0x00025260
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CoefFIColumn
			{
				get
				{
					return this.columnCoefFI;
				}
			}

			// Token: 0x17000112 RID: 274
			// (get) Token: 0x06000598 RID: 1432 RVA: 0x00027068 File Offset: 0x00025268
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NoAdmissionKWTColumn
			{
				get
				{
					return this.columnNoAdmissionKWT;
				}
			}

			// Token: 0x17000113 RID: 275
			// (get) Token: 0x06000599 RID: 1433 RVA: 0x00027070 File Offset: 0x00025270
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn AVRColumn
			{
				get
				{
					return this.columnAVR;
				}
			}

			// Token: 0x17000114 RID: 276
			// (get) Token: 0x0600059A RID: 1434 RVA: 0x00027078 File Offset: 0x00025278
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn APRColumn
			{
				get
				{
					return this.columnAPR;
				}
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x0600059B RID: 1435 RVA: 0x00027080 File Offset: 0x00025280
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TransOffColumn
			{
				get
				{
					return this.columnTransOff;
				}
			}

			// Token: 0x17000116 RID: 278
			// (get) Token: 0x0600059C RID: 1436 RVA: 0x00027088 File Offset: 0x00025288
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn AbnOffColumn
			{
				get
				{
					return this.columnAbnOff;
				}
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x0600059D RID: 1437 RVA: 0x00027090 File Offset: 0x00025290
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PowerAColumn
			{
				get
				{
					return this.columnPowerA;
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x0600059E RID: 1438 RVA: 0x00027098 File Offset: 0x00025298
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn PowerVColumn
			{
				get
				{
					return this.columnPowerV;
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x0600059F RID: 1439 RVA: 0x000270A0 File Offset: 0x000252A0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CoefSeasonColumn
			{
				get
				{
					return this.columnCoefSeason;
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x060005A0 RID: 1440 RVA: 0x000270A8 File Offset: 0x000252A8
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

			// Token: 0x1700011B RID: 283
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.z this[int A_0]
			{
				get
				{
					return (DataSetGES.z)base.Rows[A_0];
				}
			}

			// Token: 0x14000034 RID: 52
			// (add) Token: 0x060005A2 RID: 1442 RVA: 0x000270C8 File Offset: 0x000252C8
			// (remove) Token: 0x060005A3 RID: 1443 RVA: 0x00027100 File Offset: 0x00025300
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.l tJ_DamageHVRowChanging;

			// Token: 0x14000035 RID: 53
			// (add) Token: 0x060005A4 RID: 1444 RVA: 0x00027138 File Offset: 0x00025338
			// (remove) Token: 0x060005A5 RID: 1445 RVA: 0x00027170 File Offset: 0x00025370
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.l tJ_DamageHVRowChanged;

			// Token: 0x14000036 RID: 54
			// (add) Token: 0x060005A6 RID: 1446 RVA: 0x000271A8 File Offset: 0x000253A8
			// (remove) Token: 0x060005A7 RID: 1447 RVA: 0x000271E0 File Offset: 0x000253E0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.l tJ_DamageHVRowDeleting;

			// Token: 0x14000037 RID: 55
			// (add) Token: 0x060005A8 RID: 1448 RVA: 0x00027218 File Offset: 0x00025418
			// (remove) Token: 0x060005A9 RID: 1449 RVA: 0x00027250 File Offset: 0x00025450
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.l tJ_DamageHVRowDeleted;

			// Token: 0x060005AA RID: 1450 RVA: 0x00027285 File Offset: 0x00025485
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void a(DataSetGES.z A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x060005AB RID: 1451 RVA: 0x00027294 File Offset: 0x00025494
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.z a(int A_0, int A_1, int A_2, int A_3, decimal A_4, decimal A_5, decimal A_6, bool A_7, bool A_8, string A_9, string A_10, decimal A_11, decimal A_12, decimal A_13)
			{
				DataSetGES.z z = (DataSetGES.z)base.NewRow();
				object[] itemArray = new object[]
				{
					A_0,
					A_1,
					A_2,
					A_3,
					A_4,
					A_5,
					A_6,
					A_7,
					A_8,
					A_9,
					A_10,
					A_11,
					A_12,
					A_13
				};
				z.ItemArray = itemArray;
				base.Rows.Add(z);
				return z;
			}

			// Token: 0x060005AC RID: 1452 RVA: 0x0002734D File Offset: 0x0002554D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.z b(int A_0)
			{
				return (DataSetGES.z)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x060005AD RID: 1453 RVA: 0x0002736E File Offset: 0x0002556E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetGES.tJ_DamageHVDataTable tJ_DamageHVDataTable = (DataSetGES.tJ_DamageHVDataTable)base.Clone();
				tJ_DamageHVDataTable.q();
				return tJ_DamageHVDataTable;
			}

			// Token: 0x060005AE RID: 1454 RVA: 0x00027381 File Offset: 0x00025581
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.tJ_DamageHVDataTable();
			}

			// Token: 0x060005AF RID: 1455 RVA: 0x00027388 File Offset: 0x00025588
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void q()
			{
				this.columnidDamage = base.Columns["idDamage"];
				this.columnidTypeRZA = base.Columns["idTypeRZA"];
				this.columnCountSchmObj = base.Columns["CountSchmObj"];
				this.columnCountSchmObjOff = base.Columns["CountSchmObjOff"];
				this.columnConnectedPower = base.Columns["ConnectedPower"];
				this.columnCoefFI = base.Columns["CoefFI"];
				this.columnNoAdmissionKWT = base.Columns["NoAdmissionKWT"];
				this.columnAVR = base.Columns["AVR"];
				this.columnAPR = base.Columns["APR"];
				this.columnTransOff = base.Columns["TransOff"];
				this.columnAbnOff = base.Columns["AbnOff"];
				this.columnPowerA = base.Columns["PowerA"];
				this.columnPowerV = base.Columns["PowerV"];
				this.columnCoefSeason = base.Columns["CoefSeason"];
			}

			// Token: 0x060005B0 RID: 1456 RVA: 0x000274CC File Offset: 0x000256CC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void a()
			{
				this.columnidDamage = new DataColumn("idDamage", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidDamage);
				this.columnidTypeRZA = new DataColumn("idTypeRZA", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTypeRZA);
				this.columnCountSchmObj = new DataColumn("CountSchmObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnCountSchmObj);
				this.columnCountSchmObjOff = new DataColumn("CountSchmObjOff", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnCountSchmObjOff);
				this.columnConnectedPower = new DataColumn("ConnectedPower", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnConnectedPower);
				this.columnCoefFI = new DataColumn("CoefFI", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnCoefFI);
				this.columnNoAdmissionKWT = new DataColumn("NoAdmissionKWT", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnNoAdmissionKWT);
				this.columnAVR = new DataColumn("AVR", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnAVR);
				this.columnAPR = new DataColumn("APR", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnAPR);
				this.columnTransOff = new DataColumn("TransOff", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTransOff);
				this.columnAbnOff = new DataColumn("AbnOff", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAbnOff);
				this.columnPowerA = new DataColumn("PowerA", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnPowerA);
				this.columnPowerV = new DataColumn("PowerV", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnPowerV);
				this.columnCoefSeason = new DataColumn("CoefSeason", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnCoefSeason);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnidDamage
				}, true));
				this.columnidDamage.AllowDBNull = false;
				this.columnidDamage.Unique = true;
				this.columnTransOff.MaxLength = int.MaxValue;
				this.columnAbnOff.MaxLength = int.MaxValue;
			}

			// Token: 0x060005B1 RID: 1457 RVA: 0x000277AC File Offset: 0x000259AC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.z r()
			{
				return (DataSetGES.z)base.NewRow();
			}

			// Token: 0x060005B2 RID: 1458 RVA: 0x000277B9 File Offset: 0x000259B9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.z(builder);
			}

			// Token: 0x060005B3 RID: 1459 RVA: 0x000277C1 File Offset: 0x000259C1
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.z);
			}

			// Token: 0x060005B4 RID: 1460 RVA: 0x000277CD File Offset: 0x000259CD
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tJ_DamageHVRowChanged != null)
				{
					this.tJ_DamageHVRowChanged(this, new DataSetGES.an((DataSetGES.z)e.Row, e.Action));
				}
			}

			// Token: 0x060005B5 RID: 1461 RVA: 0x00027800 File Offset: 0x00025A00
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tJ_DamageHVRowChanging != null)
				{
					this.tJ_DamageHVRowChanging(this, new DataSetGES.an((DataSetGES.z)e.Row, e.Action));
				}
			}

			// Token: 0x060005B6 RID: 1462 RVA: 0x00027833 File Offset: 0x00025A33
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tJ_DamageHVRowDeleted != null)
				{
					this.tJ_DamageHVRowDeleted(this, new DataSetGES.an((DataSetGES.z)e.Row, e.Action));
				}
			}

			// Token: 0x060005B7 RID: 1463 RVA: 0x00027866 File Offset: 0x00025A66
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tJ_DamageHVRowDeleting != null)
				{
					this.tJ_DamageHVRowDeleting(this, new DataSetGES.an((DataSetGES.z)e.Row, e.Action));
				}
			}

			// Token: 0x060005B8 RID: 1464 RVA: 0x00027899 File Offset: 0x00025A99
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void b(DataSetGES.z A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x060005B9 RID: 1465 RVA: 0x000278A8 File Offset: 0x00025AA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tJ_DamageHVDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x040002C4 RID: 708
			private DataColumn columnidDamage;

			// Token: 0x040002C5 RID: 709
			private DataColumn columnidTypeRZA;

			// Token: 0x040002C6 RID: 710
			private DataColumn columnCountSchmObj;

			// Token: 0x040002C7 RID: 711
			private DataColumn columnCountSchmObjOff;

			// Token: 0x040002C8 RID: 712
			private DataColumn columnConnectedPower;

			// Token: 0x040002C9 RID: 713
			private DataColumn columnCoefFI;

			// Token: 0x040002CA RID: 714
			private DataColumn columnNoAdmissionKWT;

			// Token: 0x040002CB RID: 715
			private DataColumn columnAVR;

			// Token: 0x040002CC RID: 716
			private DataColumn columnAPR;

			// Token: 0x040002CD RID: 717
			private DataColumn columnTransOff;

			// Token: 0x040002CE RID: 718
			private DataColumn columnAbnOff;

			// Token: 0x040002CF RID: 719
			private DataColumn columnPowerA;

			// Token: 0x040002D0 RID: 720
			private DataColumn columnPowerV;

			// Token: 0x040002D1 RID: 721
			private DataColumn columnCoefSeason;
		}

		// Token: 0x0200006D RID: 109
		public class z : DataRow
		{
			// Token: 0x060005BA RID: 1466 RVA: 0x00027A9C File Offset: 0x00025C9C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal z(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.tJ_DamageHVDataTable)base.Table;
			}

			// Token: 0x060005BB RID: 1467 RVA: 0x00027AB6 File Offset: 0x00025CB6
			public int a()
			{
				return (int)base[this.a.idDamageColumn];
			}

			// Token: 0x060005BC RID: 1468 RVA: 0x00027ACE File Offset: 0x00025CCE
			public void a(int A_0)
			{
				base[this.a.idDamageColumn] = A_0;
			}

			// Token: 0x060005BD RID: 1469 RVA: 0x00027AE8 File Offset: 0x00025CE8
			public int b()
			{
				int result;
				try
				{
					result = (int)base[this.a.idTypeRZAColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idTypeRZA' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005BE RID: 1470 RVA: 0x00027B2C File Offset: 0x00025D2C
			public void b(int A_0)
			{
				base[this.a.idTypeRZAColumn] = A_0;
			}

			// Token: 0x060005BF RID: 1471 RVA: 0x00027B48 File Offset: 0x00025D48
			public int c()
			{
				int result;
				try
				{
					result = (int)base[this.a.CountSchmObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CountSchmObj' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005C0 RID: 1472 RVA: 0x00027B8C File Offset: 0x00025D8C
			public void c(int A_0)
			{
				base[this.a.CountSchmObjColumn] = A_0;
			}

			// Token: 0x060005C1 RID: 1473 RVA: 0x00027BA8 File Offset: 0x00025DA8
			public int d()
			{
				int result;
				try
				{
					result = (int)base[this.a.CountSchmObjOffColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CountSchmObjOff' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005C2 RID: 1474 RVA: 0x00027BEC File Offset: 0x00025DEC
			public void d(int A_0)
			{
				base[this.a.CountSchmObjOffColumn] = A_0;
			}

			// Token: 0x060005C3 RID: 1475 RVA: 0x00027C08 File Offset: 0x00025E08
			public decimal e()
			{
				decimal result;
				try
				{
					result = (decimal)base[this.a.ConnectedPowerColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ConnectedPower' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005C4 RID: 1476 RVA: 0x00027C4C File Offset: 0x00025E4C
			public void a(decimal A_0)
			{
				base[this.a.ConnectedPowerColumn] = A_0;
			}

			// Token: 0x060005C5 RID: 1477 RVA: 0x00027C68 File Offset: 0x00025E68
			public decimal f()
			{
				decimal result;
				try
				{
					result = (decimal)base[this.a.CoefFIColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CoefFI' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005C6 RID: 1478 RVA: 0x00027CAC File Offset: 0x00025EAC
			public void b(decimal A_0)
			{
				base[this.a.CoefFIColumn] = A_0;
			}

			// Token: 0x060005C7 RID: 1479 RVA: 0x00027CC8 File Offset: 0x00025EC8
			public decimal g()
			{
				decimal result;
				try
				{
					result = (decimal)base[this.a.NoAdmissionKWTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoAdmissionKWT' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005C8 RID: 1480 RVA: 0x00027D0C File Offset: 0x00025F0C
			public void c(decimal A_0)
			{
				base[this.a.NoAdmissionKWTColumn] = A_0;
			}

			// Token: 0x060005C9 RID: 1481 RVA: 0x00027D28 File Offset: 0x00025F28
			public bool h()
			{
				bool result;
				try
				{
					result = (bool)base[this.a.AVRColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'AVR' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x00027D6C File Offset: 0x00025F6C
			public void a(bool A_0)
			{
				base[this.a.AVRColumn] = A_0;
			}

			// Token: 0x060005CB RID: 1483 RVA: 0x00027D88 File Offset: 0x00025F88
			public bool i()
			{
				bool result;
				try
				{
					result = (bool)base[this.a.APRColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'APR' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005CC RID: 1484 RVA: 0x00027DCC File Offset: 0x00025FCC
			public void b(bool A_0)
			{
				base[this.a.APRColumn] = A_0;
			}

			// Token: 0x060005CD RID: 1485 RVA: 0x00027DE8 File Offset: 0x00025FE8
			public string j()
			{
				string result;
				try
				{
					result = (string)base[this.a.TransOffColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TransOff' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005CE RID: 1486 RVA: 0x00027E2C File Offset: 0x0002602C
			public void a(string value)
			{
				base[this.a.TransOffColumn] = value;
			}

			// Token: 0x060005CF RID: 1487 RVA: 0x00027E40 File Offset: 0x00026040
			public string k()
			{
				string result;
				try
				{
					result = (string)base[this.a.AbnOffColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'AbnOff' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005D0 RID: 1488 RVA: 0x00027E84 File Offset: 0x00026084
			public void b(string value)
			{
				base[this.a.AbnOffColumn] = value;
			}

			// Token: 0x060005D1 RID: 1489 RVA: 0x00027E98 File Offset: 0x00026098
			public decimal l()
			{
				decimal result;
				try
				{
					result = (decimal)base[this.a.PowerAColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PowerA' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005D2 RID: 1490 RVA: 0x00027EDC File Offset: 0x000260DC
			public void d(decimal A_0)
			{
				base[this.a.PowerAColumn] = A_0;
			}

			// Token: 0x060005D3 RID: 1491 RVA: 0x00027EF8 File Offset: 0x000260F8
			public decimal m()
			{
				decimal result;
				try
				{
					result = (decimal)base[this.a.PowerVColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PowerV' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005D4 RID: 1492 RVA: 0x00027F3C File Offset: 0x0002613C
			public void e(decimal A_0)
			{
				base[this.a.PowerVColumn] = A_0;
			}

			// Token: 0x060005D5 RID: 1493 RVA: 0x00027F58 File Offset: 0x00026158
			public decimal n()
			{
				decimal result;
				try
				{
					result = (decimal)base[this.a.CoefSeasonColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CoefSeason' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x060005D6 RID: 1494 RVA: 0x00027F9C File Offset: 0x0002619C
			public void f(decimal A_0)
			{
				base[this.a.CoefSeasonColumn] = A_0;
			}

			// Token: 0x060005D7 RID: 1495 RVA: 0x00027FB5 File Offset: 0x000261B5
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool o()
			{
				return base.IsNull(this.a.idTypeRZAColumn);
			}

			// Token: 0x060005D8 RID: 1496 RVA: 0x00027FC8 File Offset: 0x000261C8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void p()
			{
				base[this.a.idTypeRZAColumn] = Convert.DBNull;
			}

			// Token: 0x060005D9 RID: 1497 RVA: 0x00027FE0 File Offset: 0x000261E0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool q()
			{
				return base.IsNull(this.a.CountSchmObjColumn);
			}

			// Token: 0x060005DA RID: 1498 RVA: 0x00027FF3 File Offset: 0x000261F3
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void r()
			{
				base[this.a.CountSchmObjColumn] = Convert.DBNull;
			}

			// Token: 0x060005DB RID: 1499 RVA: 0x0002800B File Offset: 0x0002620B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool s()
			{
				return base.IsNull(this.a.CountSchmObjOffColumn);
			}

			// Token: 0x060005DC RID: 1500 RVA: 0x0002801E File Offset: 0x0002621E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void t()
			{
				base[this.a.CountSchmObjOffColumn] = Convert.DBNull;
			}

			// Token: 0x060005DD RID: 1501 RVA: 0x00028036 File Offset: 0x00026236
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool u()
			{
				return base.IsNull(this.a.ConnectedPowerColumn);
			}

			// Token: 0x060005DE RID: 1502 RVA: 0x00028049 File Offset: 0x00026249
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void v()
			{
				base[this.a.ConnectedPowerColumn] = Convert.DBNull;
			}

			// Token: 0x060005DF RID: 1503 RVA: 0x00028061 File Offset: 0x00026261
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool w()
			{
				return base.IsNull(this.a.CoefFIColumn);
			}

			// Token: 0x060005E0 RID: 1504 RVA: 0x00028074 File Offset: 0x00026274
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void x()
			{
				base[this.a.CoefFIColumn] = Convert.DBNull;
			}

			// Token: 0x060005E1 RID: 1505 RVA: 0x0002808C File Offset: 0x0002628C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool y()
			{
				return base.IsNull(this.a.NoAdmissionKWTColumn);
			}

			// Token: 0x060005E2 RID: 1506 RVA: 0x0002809F File Offset: 0x0002629F
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void z()
			{
				base[this.a.NoAdmissionKWTColumn] = Convert.DBNull;
			}

			// Token: 0x060005E3 RID: 1507 RVA: 0x000280B7 File Offset: 0x000262B7
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool aa()
			{
				return base.IsNull(this.a.AVRColumn);
			}

			// Token: 0x060005E4 RID: 1508 RVA: 0x000280CA File Offset: 0x000262CA
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void ab()
			{
				base[this.a.AVRColumn] = Convert.DBNull;
			}

			// Token: 0x060005E5 RID: 1509 RVA: 0x000280E2 File Offset: 0x000262E2
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool ac()
			{
				return base.IsNull(this.a.APRColumn);
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x000280F5 File Offset: 0x000262F5
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void ad()
			{
				base[this.a.APRColumn] = Convert.DBNull;
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x0002810D File Offset: 0x0002630D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool ae()
			{
				return base.IsNull(this.a.TransOffColumn);
			}

			// Token: 0x060005E8 RID: 1512 RVA: 0x00028120 File Offset: 0x00026320
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void af()
			{
				base[this.a.TransOffColumn] = Convert.DBNull;
			}

			// Token: 0x060005E9 RID: 1513 RVA: 0x00028138 File Offset: 0x00026338
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool ag()
			{
				return base.IsNull(this.a.AbnOffColumn);
			}

			// Token: 0x060005EA RID: 1514 RVA: 0x0002814B File Offset: 0x0002634B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void ah()
			{
				base[this.a.AbnOffColumn] = Convert.DBNull;
			}

			// Token: 0x060005EB RID: 1515 RVA: 0x00028163 File Offset: 0x00026363
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool ai()
			{
				return base.IsNull(this.a.PowerAColumn);
			}

			// Token: 0x060005EC RID: 1516 RVA: 0x00028176 File Offset: 0x00026376
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void aj()
			{
				base[this.a.PowerAColumn] = Convert.DBNull;
			}

			// Token: 0x060005ED RID: 1517 RVA: 0x0002818E File Offset: 0x0002638E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool ak()
			{
				return base.IsNull(this.a.PowerVColumn);
			}

			// Token: 0x060005EE RID: 1518 RVA: 0x000281A1 File Offset: 0x000263A1
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void al()
			{
				base[this.a.PowerVColumn] = Convert.DBNull;
			}

			// Token: 0x060005EF RID: 1519 RVA: 0x000281B9 File Offset: 0x000263B9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool am()
			{
				return base.IsNull(this.a.CoefSeasonColumn);
			}

			// Token: 0x060005F0 RID: 1520 RVA: 0x000281CC File Offset: 0x000263CC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void an()
			{
				base[this.a.CoefSeasonColumn] = Convert.DBNull;
			}

			// Token: 0x040002D6 RID: 726
			private DataSetGES.tJ_DamageHVDataTable a;
		}

		// Token: 0x0200006E RID: 110
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tJ_DamageLVDataTable : TypedTableBase<DataSetGES.aa>
		{
			// Token: 0x060005F1 RID: 1521 RVA: 0x000281E4 File Offset: 0x000263E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tJ_DamageLVDataTable()
			{
				base.TableName = "tJ_DamageLV";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x060005F2 RID: 1522 RVA: 0x0002820C File Offset: 0x0002640C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tJ_DamageLVDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x060005F3 RID: 1523 RVA: 0x000282B4 File Offset: 0x000264B4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected tJ_DamageLVDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.h();
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x060005F4 RID: 1524 RVA: 0x000282C4 File Offset: 0x000264C4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idDamageColumn
			{
				get
				{
					return this.columnidDamage;
				}
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x060005F5 RID: 1525 RVA: 0x000282CC File Offset: 0x000264CC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DeclarerColumn
			{
				get
				{
					return this.columnDeclarer;
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x060005F6 RID: 1526 RVA: 0x000282D4 File Offset: 0x000264D4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DeclarerTelColumn
			{
				get
				{
					return this.columnDeclarerTel;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000282DC File Offset: 0x000264DC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DeclarerAddressColumn
			{
				get
				{
					return this.columnDeclarerAddress;
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x060005F8 RID: 1528 RVA: 0x000282E4 File Offset: 0x000264E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn AbnOffColumn
			{
				get
				{
					return this.columnAbnOff;
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x060005F9 RID: 1529 RVA: 0x000282EC File Offset: 0x000264EC
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

			// Token: 0x17000122 RID: 290
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.aa this[int A_0]
			{
				get
				{
					return (DataSetGES.aa)base.Rows[A_0];
				}
			}

			// Token: 0x14000038 RID: 56
			// (add) Token: 0x060005FB RID: 1531 RVA: 0x0002830C File Offset: 0x0002650C
			// (remove) Token: 0x060005FC RID: 1532 RVA: 0x00028344 File Offset: 0x00026544
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.m tJ_DamageLVRowChanging;

			// Token: 0x14000039 RID: 57
			// (add) Token: 0x060005FD RID: 1533 RVA: 0x0002837C File Offset: 0x0002657C
			// (remove) Token: 0x060005FE RID: 1534 RVA: 0x000283B4 File Offset: 0x000265B4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.m tJ_DamageLVRowChanged;

			// Token: 0x1400003A RID: 58
			// (add) Token: 0x060005FF RID: 1535 RVA: 0x000283EC File Offset: 0x000265EC
			// (remove) Token: 0x06000600 RID: 1536 RVA: 0x00028424 File Offset: 0x00026624
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.m tJ_DamageLVRowDeleting;

			// Token: 0x1400003B RID: 59
			// (add) Token: 0x06000601 RID: 1537 RVA: 0x0002845C File Offset: 0x0002665C
			// (remove) Token: 0x06000602 RID: 1538 RVA: 0x00028494 File Offset: 0x00026694
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.m tJ_DamageLVRowDeleted;

			// Token: 0x06000603 RID: 1539 RVA: 0x000284C9 File Offset: 0x000266C9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void a(DataSetGES.aa A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x06000604 RID: 1540 RVA: 0x000284D8 File Offset: 0x000266D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.aa a(int A_0, string A_1, string A_2, string A_3, string A_4)
			{
				DataSetGES.aa aa = (DataSetGES.aa)base.NewRow();
				object[] itemArray = new object[]
				{
					A_0,
					A_1,
					A_2,
					A_3,
					A_4
				};
				aa.ItemArray = itemArray;
				base.Rows.Add(aa);
				return aa;
			}

			// Token: 0x06000605 RID: 1541 RVA: 0x00028527 File Offset: 0x00026727
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.aa b(int A_0)
			{
				return (DataSetGES.aa)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x06000606 RID: 1542 RVA: 0x00028548 File Offset: 0x00026748
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetGES.tJ_DamageLVDataTable tJ_DamageLVDataTable = (DataSetGES.tJ_DamageLVDataTable)base.Clone();
				tJ_DamageLVDataTable.h();
				return tJ_DamageLVDataTable;
			}

			// Token: 0x06000607 RID: 1543 RVA: 0x0002855B File Offset: 0x0002675B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.tJ_DamageLVDataTable();
			}

			// Token: 0x06000608 RID: 1544 RVA: 0x00028564 File Offset: 0x00026764
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void h()
			{
				this.columnidDamage = base.Columns["idDamage"];
				this.columnDeclarer = base.Columns["Declarer"];
				this.columnDeclarerTel = base.Columns["DeclarerTel"];
				this.columnDeclarerAddress = base.Columns["DeclarerAddress"];
				this.columnAbnOff = base.Columns["AbnOff"];
			}

			// Token: 0x06000609 RID: 1545 RVA: 0x000285E0 File Offset: 0x000267E0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void a()
			{
				this.columnidDamage = new DataColumn("idDamage", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidDamage);
				this.columnDeclarer = new DataColumn("Declarer", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDeclarer);
				this.columnDeclarerTel = new DataColumn("DeclarerTel", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDeclarerTel);
				this.columnDeclarerAddress = new DataColumn("DeclarerAddress", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDeclarerAddress);
				this.columnAbnOff = new DataColumn("AbnOff", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAbnOff);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnidDamage
				}, true));
				this.columnidDamage.AllowDBNull = false;
				this.columnidDamage.Unique = true;
				this.columnDeclarer.MaxLength = 256;
				this.columnDeclarerTel.MaxLength = 256;
				this.columnDeclarerAddress.MaxLength = 512;
				this.columnAbnOff.MaxLength = int.MaxValue;
			}

			// Token: 0x0600060A RID: 1546 RVA: 0x0002874B File Offset: 0x0002694B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.aa i()
			{
				return (DataSetGES.aa)base.NewRow();
			}

			// Token: 0x0600060B RID: 1547 RVA: 0x00028758 File Offset: 0x00026958
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.aa(builder);
			}

			// Token: 0x0600060C RID: 1548 RVA: 0x00028760 File Offset: 0x00026960
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.aa);
			}

			// Token: 0x0600060D RID: 1549 RVA: 0x0002876C File Offset: 0x0002696C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tJ_DamageLVRowChanged != null)
				{
					this.tJ_DamageLVRowChanged(this, new DataSetGES.ao((DataSetGES.aa)e.Row, e.Action));
				}
			}

			// Token: 0x0600060E RID: 1550 RVA: 0x0002879F File Offset: 0x0002699F
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tJ_DamageLVRowChanging != null)
				{
					this.tJ_DamageLVRowChanging(this, new DataSetGES.ao((DataSetGES.aa)e.Row, e.Action));
				}
			}

			// Token: 0x0600060F RID: 1551 RVA: 0x000287D2 File Offset: 0x000269D2
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tJ_DamageLVRowDeleted != null)
				{
					this.tJ_DamageLVRowDeleted(this, new DataSetGES.ao((DataSetGES.aa)e.Row, e.Action));
				}
			}

			// Token: 0x06000610 RID: 1552 RVA: 0x00028805 File Offset: 0x00026A05
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tJ_DamageLVRowDeleting != null)
				{
					this.tJ_DamageLVRowDeleting(this, new DataSetGES.ao((DataSetGES.aa)e.Row, e.Action));
				}
			}

			// Token: 0x06000611 RID: 1553 RVA: 0x00028838 File Offset: 0x00026A38
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void b(DataSetGES.aa A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x06000612 RID: 1554 RVA: 0x00028848 File Offset: 0x00026A48
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tJ_DamageLVDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x040002D7 RID: 727
			private DataColumn columnidDamage;

			// Token: 0x040002D8 RID: 728
			private DataColumn columnDeclarer;

			// Token: 0x040002D9 RID: 729
			private DataColumn columnDeclarerTel;

			// Token: 0x040002DA RID: 730
			private DataColumn columnDeclarerAddress;

			// Token: 0x040002DB RID: 731
			private DataColumn columnAbnOff;
		}

		// Token: 0x0200006F RID: 111
		public class aa : DataRow
		{
			// Token: 0x06000613 RID: 1555 RVA: 0x00028A3C File Offset: 0x00026C3C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal aa(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.tJ_DamageLVDataTable)base.Table;
			}

			// Token: 0x06000614 RID: 1556 RVA: 0x00028A56 File Offset: 0x00026C56
			public int a()
			{
				return (int)base[this.a.idDamageColumn];
			}

			// Token: 0x06000615 RID: 1557 RVA: 0x00028A6E File Offset: 0x00026C6E
			public void a(int A_0)
			{
				base[this.a.idDamageColumn] = A_0;
			}

			// Token: 0x06000616 RID: 1558 RVA: 0x00028A88 File Offset: 0x00026C88
			public string b()
			{
				string result;
				try
				{
					result = (string)base[this.a.DeclarerColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Declarer' in table 'tJ_DamageLV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000617 RID: 1559 RVA: 0x00028ACC File Offset: 0x00026CCC
			public void a(string value)
			{
				base[this.a.DeclarerColumn] = value;
			}

			// Token: 0x06000618 RID: 1560 RVA: 0x00028AE0 File Offset: 0x00026CE0
			public string c()
			{
				string result;
				try
				{
					result = (string)base[this.a.DeclarerTelColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DeclarerTel' in table 'tJ_DamageLV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000619 RID: 1561 RVA: 0x00028B24 File Offset: 0x00026D24
			public void b(string value)
			{
				base[this.a.DeclarerTelColumn] = value;
			}

			// Token: 0x0600061A RID: 1562 RVA: 0x00028B38 File Offset: 0x00026D38
			public string d()
			{
				string result;
				try
				{
					result = (string)base[this.a.DeclarerAddressColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DeclarerAddress' in table 'tJ_DamageLV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600061B RID: 1563 RVA: 0x00028B7C File Offset: 0x00026D7C
			public void c(string value)
			{
				base[this.a.DeclarerAddressColumn] = value;
			}

			// Token: 0x0600061C RID: 1564 RVA: 0x00028B90 File Offset: 0x00026D90
			public string e()
			{
				string result;
				try
				{
					result = (string)base[this.a.AbnOffColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'AbnOff' in table 'tJ_DamageLV' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600061D RID: 1565 RVA: 0x00028BD4 File Offset: 0x00026DD4
			public void d(string value)
			{
				base[this.a.AbnOffColumn] = value;
			}

			// Token: 0x0600061E RID: 1566 RVA: 0x00028BE8 File Offset: 0x00026DE8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool f()
			{
				return base.IsNull(this.a.DeclarerColumn);
			}

			// Token: 0x0600061F RID: 1567 RVA: 0x00028BFB File Offset: 0x00026DFB
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void g()
			{
				base[this.a.DeclarerColumn] = Convert.DBNull;
			}

			// Token: 0x06000620 RID: 1568 RVA: 0x00028C13 File Offset: 0x00026E13
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool h()
			{
				return base.IsNull(this.a.DeclarerTelColumn);
			}

			// Token: 0x06000621 RID: 1569 RVA: 0x00028C26 File Offset: 0x00026E26
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void i()
			{
				base[this.a.DeclarerTelColumn] = Convert.DBNull;
			}

			// Token: 0x06000622 RID: 1570 RVA: 0x00028C3E File Offset: 0x00026E3E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool j()
			{
				return base.IsNull(this.a.DeclarerAddressColumn);
			}

			// Token: 0x06000623 RID: 1571 RVA: 0x00028C51 File Offset: 0x00026E51
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void k()
			{
				base[this.a.DeclarerAddressColumn] = Convert.DBNull;
			}

			// Token: 0x06000624 RID: 1572 RVA: 0x00028C69 File Offset: 0x00026E69
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool l()
			{
				return base.IsNull(this.a.AbnOffColumn);
			}

			// Token: 0x06000625 RID: 1573 RVA: 0x00028C7C File Offset: 0x00026E7C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void m()
			{
				base[this.a.AbnOffColumn] = Convert.DBNull;
			}

			// Token: 0x040002E0 RID: 736
			private DataSetGES.tJ_DamageLVDataTable a;
		}

		// Token: 0x02000070 RID: 112
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tJ_RequestForRepairLogDataTable : TypedTableBase<DataSetGES.ab>
		{
			// Token: 0x06000626 RID: 1574 RVA: 0x00028C94 File Offset: 0x00026E94
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tJ_RequestForRepairLogDataTable()
			{
				base.TableName = "tJ_RequestForRepairLog";
				this.BeginInit();
				this.a();
				this.EndInit();
			}

			// Token: 0x06000627 RID: 1575 RVA: 0x00028CBC File Offset: 0x00026EBC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tJ_RequestForRepairLogDataTable(DataTable A_0)
			{
				base.TableName = A_0.TableName;
				if (A_0.CaseSensitive != A_0.DataSet.CaseSensitive)
				{
					base.CaseSensitive = A_0.CaseSensitive;
				}
				if (A_0.Locale.ToString() != A_0.DataSet.Locale.ToString())
				{
					base.Locale = A_0.Locale;
				}
				if (A_0.Namespace != A_0.DataSet.Namespace)
				{
					base.Namespace = A_0.Namespace;
				}
				base.Prefix = A_0.Prefix;
				base.MinimumCapacity = A_0.MinimumCapacity;
			}

			// Token: 0x06000628 RID: 1576 RVA: 0x00028D64 File Offset: 0x00026F64
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected tJ_RequestForRepairLogDataTable(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
			{
				this.l();
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000629 RID: 1577 RVA: 0x00028D74 File Offset: 0x00026F74
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idColumn
			{
				get
				{
					return this.columnid;
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x0600062A RID: 1578 RVA: 0x00028D7C File Offset: 0x00026F7C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idRequestColumn
			{
				get
				{
					return this.columnidRequest;
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x0600062B RID: 1579 RVA: 0x00028D84 File Offset: 0x00026F84
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dateLogColumn
			{
				get
				{
					return this.columndateLog;
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x0600062C RID: 1580 RVA: 0x00028D8C File Offset: 0x00026F8C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn userLogIDColumn
			{
				get
				{
					return this.columnuserLogID;
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x0600062D RID: 1581 RVA: 0x00028D94 File Offset: 0x00026F94
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn userLogColumn
			{
				get
				{
					return this.columnuserLog;
				}
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x0600062E RID: 1582 RVA: 0x00028D9C File Offset: 0x00026F9C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn userLogNameColumn
			{
				get
				{
					return this.columnuserLogName;
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x0600062F RID: 1583 RVA: 0x00028DA4 File Offset: 0x00026FA4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idCommandColumn
			{
				get
				{
					return this.columnidCommand;
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000630 RID: 1584 RVA: 0x00028DAC File Offset: 0x00026FAC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CommandColumn
			{
				get
				{
					return this.columnCommand;
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000631 RID: 1585 RVA: 0x00028DB4 File Offset: 0x00026FB4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn isSiteColumn
			{
				get
				{
					return this.columnisSite;
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000632 RID: 1586 RVA: 0x00028DBC File Offset: 0x00026FBC
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

			// Token: 0x1700012D RID: 301
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.ab this[int A_0]
			{
				get
				{
					return (DataSetGES.ab)base.Rows[A_0];
				}
			}

			// Token: 0x1400003C RID: 60
			// (add) Token: 0x06000634 RID: 1588 RVA: 0x00028DDC File Offset: 0x00026FDC
			// (remove) Token: 0x06000635 RID: 1589 RVA: 0x00028E14 File Offset: 0x00027014
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.n tJ_RequestForRepairLogRowChanging;

			// Token: 0x1400003D RID: 61
			// (add) Token: 0x06000636 RID: 1590 RVA: 0x00028E4C File Offset: 0x0002704C
			// (remove) Token: 0x06000637 RID: 1591 RVA: 0x00028E84 File Offset: 0x00027084
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.n tJ_RequestForRepairLogRowChanged;

			// Token: 0x1400003E RID: 62
			// (add) Token: 0x06000638 RID: 1592 RVA: 0x00028EBC File Offset: 0x000270BC
			// (remove) Token: 0x06000639 RID: 1593 RVA: 0x00028EF4 File Offset: 0x000270F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.n tJ_RequestForRepairLogRowDeleting;

			// Token: 0x1400003F RID: 63
			// (add) Token: 0x0600063A RID: 1594 RVA: 0x00028F2C File Offset: 0x0002712C
			// (remove) Token: 0x0600063B RID: 1595 RVA: 0x00028F64 File Offset: 0x00027164
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetGES.n tJ_RequestForRepairLogRowDeleted;

			// Token: 0x0600063C RID: 1596 RVA: 0x00028F99 File Offset: 0x00027199
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void a(DataSetGES.ab A_0)
			{
				base.Rows.Add(A_0);
			}

			// Token: 0x0600063D RID: 1597 RVA: 0x00028FA8 File Offset: 0x000271A8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.ab a(int A_0, DateTime A_1, int A_2, string A_3, string A_4, int A_5, string A_6, bool A_7)
			{
				DataSetGES.ab ab = (DataSetGES.ab)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					A_0,
					A_1,
					A_2,
					A_3,
					A_4,
					A_5,
					A_6,
					A_7
				};
				ab.ItemArray = itemArray;
				base.Rows.Add(ab);
				return ab;
			}

			// Token: 0x0600063E RID: 1598 RVA: 0x0002901B File Offset: 0x0002721B
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetGES.ab b(int A_0)
			{
				return (DataSetGES.ab)base.Rows.Find(new object[]
				{
					A_0
				});
			}

			// Token: 0x0600063F RID: 1599 RVA: 0x0002903C File Offset: 0x0002723C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetGES.tJ_RequestForRepairLogDataTable tJ_RequestForRepairLogDataTable = (DataSetGES.tJ_RequestForRepairLogDataTable)base.Clone();
				tJ_RequestForRepairLogDataTable.l();
				return tJ_RequestForRepairLogDataTable;
			}

			// Token: 0x06000640 RID: 1600 RVA: 0x0002904F File Offset: 0x0002724F
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetGES.tJ_RequestForRepairLogDataTable();
			}

			// Token: 0x06000641 RID: 1601 RVA: 0x00029058 File Offset: 0x00027258
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void l()
			{
				this.columnid = base.Columns["id"];
				this.columnidRequest = base.Columns["idRequest"];
				this.columndateLog = base.Columns["dateLog"];
				this.columnuserLogID = base.Columns["userLogID"];
				this.columnuserLog = base.Columns["userLog"];
				this.columnuserLogName = base.Columns["userLogName"];
				this.columnidCommand = base.Columns["idCommand"];
				this.columnCommand = base.Columns["Command"];
				this.columnisSite = base.Columns["isSite"];
			}

			// Token: 0x06000642 RID: 1602 RVA: 0x0002912C File Offset: 0x0002732C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void a()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidRequest = new DataColumn("idRequest", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidRequest);
				this.columndateLog = new DataColumn("dateLog", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columndateLog);
				this.columnuserLogID = new DataColumn("userLogID", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnuserLogID);
				this.columnuserLog = new DataColumn("userLog", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnuserLog);
				this.columnuserLogName = new DataColumn("userLogName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnuserLogName);
				this.columnidCommand = new DataColumn("idCommand", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidCommand);
				this.columnCommand = new DataColumn("Command", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCommand);
				this.columnisSite = new DataColumn("isSite", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnisSite);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnid
				}, true));
				this.columnid.AutoIncrement = true;
				this.columnid.AutoIncrementSeed = -1L;
				this.columnid.AutoIncrementStep = -1L;
				this.columnid.AllowDBNull = false;
				this.columnid.ReadOnly = true;
				this.columnid.Unique = true;
				this.columnidRequest.AllowDBNull = false;
				this.columndateLog.AllowDBNull = false;
				this.columnuserLog.MaxLength = 50;
				this.columnuserLogName.MaxLength = 128;
				this.columnidCommand.AllowDBNull = false;
				this.columnCommand.MaxLength = 128;
				this.columnisSite.AllowDBNull = false;
			}

			// Token: 0x06000643 RID: 1603 RVA: 0x0002939A File Offset: 0x0002759A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetGES.ab m()
			{
				return (DataSetGES.ab)base.NewRow();
			}

			// Token: 0x06000644 RID: 1604 RVA: 0x000293A7 File Offset: 0x000275A7
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetGES.ab(builder);
			}

			// Token: 0x06000645 RID: 1605 RVA: 0x000293AF File Offset: 0x000275AF
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetGES.ab);
			}

			// Token: 0x06000646 RID: 1606 RVA: 0x000293BB File Offset: 0x000275BB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tJ_RequestForRepairLogRowChanged != null)
				{
					this.tJ_RequestForRepairLogRowChanged(this, new DataSetGES.ap((DataSetGES.ab)e.Row, e.Action));
				}
			}

			// Token: 0x06000647 RID: 1607 RVA: 0x000293EE File Offset: 0x000275EE
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tJ_RequestForRepairLogRowChanging != null)
				{
					this.tJ_RequestForRepairLogRowChanging(this, new DataSetGES.ap((DataSetGES.ab)e.Row, e.Action));
				}
			}

			// Token: 0x06000648 RID: 1608 RVA: 0x00029421 File Offset: 0x00027621
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tJ_RequestForRepairLogRowDeleted != null)
				{
					this.tJ_RequestForRepairLogRowDeleted(this, new DataSetGES.ap((DataSetGES.ab)e.Row, e.Action));
				}
			}

			// Token: 0x06000649 RID: 1609 RVA: 0x00029454 File Offset: 0x00027654
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tJ_RequestForRepairLogRowDeleting != null)
				{
					this.tJ_RequestForRepairLogRowDeleting(this, new DataSetGES.ap((DataSetGES.ab)e.Row, e.Action));
				}
			}

			// Token: 0x0600064A RID: 1610 RVA: 0x00029487 File Offset: 0x00027687
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void b(DataSetGES.ab A_0)
			{
				base.Rows.Remove(A_0);
			}

			// Token: 0x0600064B RID: 1611 RVA: 0x00029498 File Offset: 0x00027698
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType a(XmlSchemaSet A_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetGES dataSetGES = new DataSetGES();
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
				xmlSchemaAttribute.FixedValue = dataSetGES.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tJ_RequestForRepairLogDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetGES.GetSchemaSerializable();
				if (A_0.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in A_0.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
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
				}
				A_0.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x040002E1 RID: 737
			private DataColumn columnid;

			// Token: 0x040002E2 RID: 738
			private DataColumn columnidRequest;

			// Token: 0x040002E3 RID: 739
			private DataColumn columndateLog;

			// Token: 0x040002E4 RID: 740
			private DataColumn columnuserLogID;

			// Token: 0x040002E5 RID: 741
			private DataColumn columnuserLog;

			// Token: 0x040002E6 RID: 742
			private DataColumn columnuserLogName;

			// Token: 0x040002E7 RID: 743
			private DataColumn columnidCommand;

			// Token: 0x040002E8 RID: 744
			private DataColumn columnCommand;

			// Token: 0x040002E9 RID: 745
			private DataColumn columnisSite;
		}

		// Token: 0x02000071 RID: 113
		public class ab : DataRow
		{
			// Token: 0x0600064C RID: 1612 RVA: 0x0002968C File Offset: 0x0002788C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal ab(DataRowBuilder A_0) : base(A_0)
			{
				this.a = (DataSetGES.tJ_RequestForRepairLogDataTable)base.Table;
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x0600064D RID: 1613 RVA: 0x000296A6 File Offset: 0x000278A6
			// (set) Token: 0x0600064E RID: 1614 RVA: 0x000296BE File Offset: 0x000278BE
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int id
			{
				get
				{
					return (int)base[this.a.idColumn];
				}
				set
				{
					base[this.a.idColumn] = value;
				}
			}

			// Token: 0x0600064F RID: 1615 RVA: 0x000296D7 File Offset: 0x000278D7
			public int b()
			{
				return (int)base[this.a.idRequestColumn];
			}

			// Token: 0x06000650 RID: 1616 RVA: 0x000296EF File Offset: 0x000278EF
			public void b(int A_0)
			{
				base[this.a.idRequestColumn] = A_0;
			}

			// Token: 0x06000651 RID: 1617 RVA: 0x00029708 File Offset: 0x00027908
			public DateTime c()
			{
				return (DateTime)base[this.a.dateLogColumn];
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x00029720 File Offset: 0x00027920
			public void a(DateTime A_0)
			{
				base[this.a.dateLogColumn] = A_0;
			}

			// Token: 0x06000653 RID: 1619 RVA: 0x0002973C File Offset: 0x0002793C
			public int d()
			{
				int result;
				try
				{
					result = (int)base[this.a.userLogIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'userLogID' in table 'tJ_RequestForRepairLog' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000654 RID: 1620 RVA: 0x00029780 File Offset: 0x00027980
			public void c(int A_0)
			{
				base[this.a.userLogIDColumn] = A_0;
			}

			// Token: 0x06000655 RID: 1621 RVA: 0x0002979C File Offset: 0x0002799C
			public string e()
			{
				string result;
				try
				{
					result = (string)base[this.a.userLogColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'userLog' in table 'tJ_RequestForRepairLog' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000656 RID: 1622 RVA: 0x000297E0 File Offset: 0x000279E0
			public void a(string value)
			{
				base[this.a.userLogColumn] = value;
			}

			// Token: 0x06000657 RID: 1623 RVA: 0x000297F4 File Offset: 0x000279F4
			public string f()
			{
				string result;
				try
				{
					result = (string)base[this.a.userLogNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'userLogName' in table 'tJ_RequestForRepairLog' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x06000658 RID: 1624 RVA: 0x00029838 File Offset: 0x00027A38
			public void b(string value)
			{
				base[this.a.userLogNameColumn] = value;
			}

			// Token: 0x06000659 RID: 1625 RVA: 0x0002984C File Offset: 0x00027A4C
			public int g()
			{
				return (int)base[this.a.idCommandColumn];
			}

			// Token: 0x0600065A RID: 1626 RVA: 0x00029864 File Offset: 0x00027A64
			public void d(int A_0)
			{
				base[this.a.idCommandColumn] = A_0;
			}

			// Token: 0x0600065B RID: 1627 RVA: 0x00029880 File Offset: 0x00027A80
			public string h()
			{
				string result;
				try
				{
					result = (string)base[this.a.CommandColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Command' in table 'tJ_RequestForRepairLog' is DBNull.", innerException);
				}
				return result;
			}

			// Token: 0x0600065C RID: 1628 RVA: 0x000298C4 File Offset: 0x00027AC4
			public void c(string value)
			{
				base[this.a.CommandColumn] = value;
			}

			// Token: 0x0600065D RID: 1629 RVA: 0x000298D8 File Offset: 0x00027AD8
			public bool i()
			{
				return (bool)base[this.a.isSiteColumn];
			}

			// Token: 0x0600065E RID: 1630 RVA: 0x000298F0 File Offset: 0x00027AF0
			public void a(bool A_0)
			{
				base[this.a.isSiteColumn] = A_0;
			}

			// Token: 0x0600065F RID: 1631 RVA: 0x00029909 File Offset: 0x00027B09
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool j()
			{
				return base.IsNull(this.a.userLogIDColumn);
			}

			// Token: 0x06000660 RID: 1632 RVA: 0x0002991C File Offset: 0x00027B1C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void k()
			{
				base[this.a.userLogIDColumn] = Convert.DBNull;
			}

			// Token: 0x06000661 RID: 1633 RVA: 0x00029934 File Offset: 0x00027B34
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool l()
			{
				return base.IsNull(this.a.userLogColumn);
			}

			// Token: 0x06000662 RID: 1634 RVA: 0x00029947 File Offset: 0x00027B47
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void m()
			{
				base[this.a.userLogColumn] = Convert.DBNull;
			}

			// Token: 0x06000663 RID: 1635 RVA: 0x0002995F File Offset: 0x00027B5F
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool n()
			{
				return base.IsNull(this.a.userLogNameColumn);
			}

			// Token: 0x06000664 RID: 1636 RVA: 0x00029972 File Offset: 0x00027B72
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void o()
			{
				base[this.a.userLogNameColumn] = Convert.DBNull;
			}

			// Token: 0x06000665 RID: 1637 RVA: 0x0002998A File Offset: 0x00027B8A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool p()
			{
				return base.IsNull(this.a.CommandColumn);
			}

			// Token: 0x06000666 RID: 1638 RVA: 0x0002999D File Offset: 0x00027B9D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void q()
			{
				base[this.a.CommandColumn] = Convert.DBNull;
			}

			// Token: 0x040002EE RID: 750
			private DataSetGES.tJ_RequestForRepairLogDataTable a;
		}

		// Token: 0x02000072 RID: 114
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ac : EventArgs
		{
			// Token: 0x06000667 RID: 1639 RVA: 0x000299B5 File Offset: 0x00027BB5
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public ac(DataSetGES.o A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x06000668 RID: 1640 RVA: 0x000299CB File Offset: 0x00027BCB
			public DataSetGES.o a()
			{
				return this.a;
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x000299D3 File Offset: 0x00027BD3
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x040002EF RID: 751
			private DataSetGES.o a;

			// Token: 0x040002F0 RID: 752
			private DataRowAction b;
		}

		// Token: 0x02000073 RID: 115
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ad : EventArgs
		{
			// Token: 0x0600066A RID: 1642 RVA: 0x000299DB File Offset: 0x00027BDB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ad(DataSetGES.p A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x0600066B RID: 1643 RVA: 0x000299F1 File Offset: 0x00027BF1
			public DataSetGES.p a()
			{
				return this.a;
			}

			// Token: 0x0600066C RID: 1644 RVA: 0x000299F9 File Offset: 0x00027BF9
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x040002F1 RID: 753
			private DataSetGES.p a;

			// Token: 0x040002F2 RID: 754
			private DataRowAction b;
		}

		// Token: 0x02000074 RID: 116
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ae : EventArgs
		{
			// Token: 0x0600066D RID: 1645 RVA: 0x00029A01 File Offset: 0x00027C01
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public ae(DataSetGES.q A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x0600066E RID: 1646 RVA: 0x00029A17 File Offset: 0x00027C17
			public DataSetGES.q a()
			{
				return this.a;
			}

			// Token: 0x0600066F RID: 1647 RVA: 0x00029A1F File Offset: 0x00027C1F
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x040002F3 RID: 755
			private DataSetGES.q a;

			// Token: 0x040002F4 RID: 756
			private DataRowAction b;
		}

		// Token: 0x02000075 RID: 117
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class af : EventArgs
		{
			// Token: 0x06000670 RID: 1648 RVA: 0x00029A27 File Offset: 0x00027C27
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public af(DataSetGES.r A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x06000671 RID: 1649 RVA: 0x00029A3D File Offset: 0x00027C3D
			public DataSetGES.r a()
			{
				return this.a;
			}

			// Token: 0x06000672 RID: 1650 RVA: 0x00029A45 File Offset: 0x00027C45
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x040002F5 RID: 757
			private DataSetGES.r a;

			// Token: 0x040002F6 RID: 758
			private DataRowAction b;
		}

		// Token: 0x02000076 RID: 118
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ag : EventArgs
		{
			// Token: 0x06000673 RID: 1651 RVA: 0x00029A4D File Offset: 0x00027C4D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ag(DataSetGES.s A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x06000674 RID: 1652 RVA: 0x00029A63 File Offset: 0x00027C63
			public DataSetGES.s a()
			{
				return this.a;
			}

			// Token: 0x06000675 RID: 1653 RVA: 0x00029A6B File Offset: 0x00027C6B
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x040002F7 RID: 759
			private DataSetGES.s a;

			// Token: 0x040002F8 RID: 760
			private DataRowAction b;
		}

		// Token: 0x02000077 RID: 119
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ah : EventArgs
		{
			// Token: 0x06000676 RID: 1654 RVA: 0x00029A73 File Offset: 0x00027C73
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public ah(DataSetGES.t A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x06000677 RID: 1655 RVA: 0x00029A89 File Offset: 0x00027C89
			public DataSetGES.t a()
			{
				return this.a;
			}

			// Token: 0x06000678 RID: 1656 RVA: 0x00029A91 File Offset: 0x00027C91
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x040002F9 RID: 761
			private DataSetGES.t a;

			// Token: 0x040002FA RID: 762
			private DataRowAction b;
		}

		// Token: 0x02000078 RID: 120
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ai : EventArgs
		{
			// Token: 0x06000679 RID: 1657 RVA: 0x00029A99 File Offset: 0x00027C99
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ai(DataSetGES.u A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x0600067A RID: 1658 RVA: 0x00029AAF File Offset: 0x00027CAF
			public DataSetGES.u a()
			{
				return this.a;
			}

			// Token: 0x0600067B RID: 1659 RVA: 0x00029AB7 File Offset: 0x00027CB7
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x040002FB RID: 763
			private DataSetGES.u a;

			// Token: 0x040002FC RID: 764
			private DataRowAction b;
		}

		// Token: 0x02000079 RID: 121
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class aj : EventArgs
		{
			// Token: 0x0600067C RID: 1660 RVA: 0x00029ABF File Offset: 0x00027CBF
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public aj(DataSetGES.v A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x0600067D RID: 1661 RVA: 0x00029AD5 File Offset: 0x00027CD5
			public DataSetGES.v a()
			{
				return this.a;
			}

			// Token: 0x0600067E RID: 1662 RVA: 0x00029ADD File Offset: 0x00027CDD
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x040002FD RID: 765
			private DataSetGES.v a;

			// Token: 0x040002FE RID: 766
			private DataRowAction b;
		}

		// Token: 0x0200007A RID: 122
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ak : EventArgs
		{
			// Token: 0x0600067F RID: 1663 RVA: 0x00029AE5 File Offset: 0x00027CE5
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ak(DataSetGES.w A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x06000680 RID: 1664 RVA: 0x00029AFB File Offset: 0x00027CFB
			public DataSetGES.w a()
			{
				return this.a;
			}

			// Token: 0x06000681 RID: 1665 RVA: 0x00029B03 File Offset: 0x00027D03
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x040002FF RID: 767
			private DataSetGES.w a;

			// Token: 0x04000300 RID: 768
			private DataRowAction b;
		}

		// Token: 0x0200007B RID: 123
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class al : EventArgs
		{
			// Token: 0x06000682 RID: 1666 RVA: 0x00029B0B File Offset: 0x00027D0B
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public al(DataSetGES.x A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x06000683 RID: 1667 RVA: 0x00029B21 File Offset: 0x00027D21
			public DataSetGES.x a()
			{
				return this.a;
			}

			// Token: 0x06000684 RID: 1668 RVA: 0x00029B29 File Offset: 0x00027D29
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x04000301 RID: 769
			private DataSetGES.x a;

			// Token: 0x04000302 RID: 770
			private DataRowAction b;
		}

		// Token: 0x0200007C RID: 124
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class am : EventArgs
		{
			// Token: 0x06000685 RID: 1669 RVA: 0x00029B31 File Offset: 0x00027D31
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public am(DataSetGES.y A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x06000686 RID: 1670 RVA: 0x00029B47 File Offset: 0x00027D47
			public DataSetGES.y a()
			{
				return this.a;
			}

			// Token: 0x06000687 RID: 1671 RVA: 0x00029B4F File Offset: 0x00027D4F
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x04000303 RID: 771
			private DataSetGES.y a;

			// Token: 0x04000304 RID: 772
			private DataRowAction b;
		}

		// Token: 0x0200007D RID: 125
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class an : EventArgs
		{
			// Token: 0x06000688 RID: 1672 RVA: 0x00029B57 File Offset: 0x00027D57
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public an(DataSetGES.z A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x06000689 RID: 1673 RVA: 0x00029B6D File Offset: 0x00027D6D
			public DataSetGES.z a()
			{
				return this.a;
			}

			// Token: 0x0600068A RID: 1674 RVA: 0x00029B75 File Offset: 0x00027D75
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x04000305 RID: 773
			private DataSetGES.z a;

			// Token: 0x04000306 RID: 774
			private DataRowAction b;
		}

		// Token: 0x0200007E RID: 126
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ao : EventArgs
		{
			// Token: 0x0600068B RID: 1675 RVA: 0x00029B7D File Offset: 0x00027D7D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public ao(DataSetGES.aa A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x0600068C RID: 1676 RVA: 0x00029B93 File Offset: 0x00027D93
			public DataSetGES.aa a()
			{
				return this.a;
			}

			// Token: 0x0600068D RID: 1677 RVA: 0x00029B9B File Offset: 0x00027D9B
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x04000307 RID: 775
			private DataSetGES.aa a;

			// Token: 0x04000308 RID: 776
			private DataRowAction b;
		}

		// Token: 0x0200007F RID: 127
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ap : EventArgs
		{
			// Token: 0x0600068E RID: 1678 RVA: 0x00029BA3 File Offset: 0x00027DA3
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ap(DataSetGES.ab A_0, DataRowAction A_1)
			{
				this.a = A_0;
				this.b = A_1;
			}

			// Token: 0x0600068F RID: 1679 RVA: 0x00029BB9 File Offset: 0x00027DB9
			public DataSetGES.ab a()
			{
				return this.a;
			}

			// Token: 0x06000690 RID: 1680 RVA: 0x00029BC1 File Offset: 0x00027DC1
			public DataRowAction b()
			{
				return this.b;
			}

			// Token: 0x04000309 RID: 777
			private DataSetGES.ab a;

			// Token: 0x0400030A RID: 778
			private DataRowAction b;
		}
	}
}
