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

[DesignerCategory("code")]
[XmlRoot("DataSetOrder")]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[ToolboxItem(true)]
[HelpKeyword("vs.data.DataSet")]
[Serializable]
internal class Class469 : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class469()
	{
		Class611.H9nE6ZDzTF9kb();
		this.schemaSerializationMode_0 = SchemaSerializationMode.IncludeSchema;
		
		base.BeginInit();
		this.method_2();
		CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_17);
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		base.EndInit();
		this.method_18();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	protected Class469(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		Class611.H9nE6ZDzTF9kb();
		this.schemaSerializationMode_0 = SchemaSerializationMode.IncludeSchema;
		base..ctor(serializationInfo_0, streamingContext_0, false);
		if (base.IsBinarySerialized(serializationInfo_0, streamingContext_0))
		{
			this.method_1(false);
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_17);
			this.DataTableCollection_0.CollectionChanged += value;
			this.DataRelationCollection_0.CollectionChanged += value;
			if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == SchemaSerializationMode.ExcludeSchema)
			{
				this.method_18();
			}
			return;
		}
		string s = (string)serializationInfo_0.GetValue("XmlSchema", typeof(string));
		if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["tJ_Order"] != null)
			{
				base.Tables.Add(new Class469.Class470(dataSet.Tables["tJ_Order"]));
			}
			if (dataSet.Tables["vJ_Order"] != null)
			{
				base.Tables.Add(new Class469.Class471(dataSet.Tables["vJ_Order"]));
			}
			if (dataSet.Tables["tR_Classifier"] != null)
			{
				base.Tables.Add(new Class469.Class472(dataSet.Tables["tR_Classifier"]));
			}
			if (dataSet.Tables["vR_Worker"] != null)
			{
				base.Tables.Add(new Class469.Class473(dataSet.Tables["vR_Worker"]));
			}
			if (dataSet.Tables["vWorkerGroup"] != null)
			{
				base.Tables.Add(new Class469.Class474(dataSet.Tables["vWorkerGroup"]));
			}
			if (dataSet.Tables["tJ_OrderBrigade"] != null)
			{
				base.Tables.Add(new Class469.Class475(dataSet.Tables["tJ_OrderBrigade"]));
			}
			if (dataSet.Tables["tj_DailyTourReport"] != null)
			{
				base.Tables.Add(new Class469.Class476(dataSet.Tables["tj_DailyTourReport"]));
			}
			if (dataSet.Tables["tJ_OrderInstruction"] != null)
			{
				base.Tables.Add(new Class469.Class477(dataSet.Tables["tJ_OrderInstruction"]));
			}
			if (dataSet.Tables["tJ_OrderResolution"] != null)
			{
				base.Tables.Add(new Class469.Class478(dataSet.Tables["tJ_OrderResolution"]));
			}
			if (dataSet.Tables["vJ_OrderEvents"] != null)
			{
				base.Tables.Add(new Class469.Class479(dataSet.Tables["vJ_OrderEvents"]));
			}
			if (dataSet.Tables["tL_OrderSchmObjList"] != null)
			{
				base.Tables.Add(new Class469.Class480(dataSet.Tables["tL_OrderSchmObjList"]));
			}
			if (dataSet.Tables["vSchm_ObjList"] != null)
			{
				base.Tables.Add(new Class469.Class481(dataSet.Tables["vSchm_ObjList"]));
			}
			if (dataSet.Tables["vSchm_TreeCellLine"] != null)
			{
				base.Tables.Add(new Class469.Class482(dataSet.Tables["vSchm_TreeCellLine"]));
			}
			if (dataSet.Tables["tSchm_Relation"] != null)
			{
				base.Tables.Add(new Class469.Class483(dataSet.Tables["tSchm_Relation"]));
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
			this.method_18();
		}
		base.GetSerializationData(serializationInfo_0, streamingContext_0);
		CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.method_17);
		base.Tables.CollectionChanged += value2;
		this.DataRelationCollection_0.CollectionChanged += value2;
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class469.Class470 tJ_Order
	{
		get
		{
			return this.class470_0;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Class469.Class471 vJ_Order
	{
		get
		{
			return this.class471_0;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class469.Class472 tR_Classifier
	{
		get
		{
			return this.class472_0;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	public Class469.Class473 vR_Worker
	{
		get
		{
			return this.class473_0;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Class469.Class474 vWorkerGroup
	{
		get
		{
			return this.class474_0;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Class469.Class475 tJ_OrderBrigade
	{
		get
		{
			return this.class475_0;
		}
	}

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class469.Class476 tj_DailyTourReport
	{
		get
		{
			return this.class476_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class469.Class477 tJ_OrderInstruction
	{
		get
		{
			return this.class477_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class469.Class478 tJ_OrderResolution
	{
		get
		{
			return this.class478_0;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class469.Class479 vJ_OrderEvents
	{
		get
		{
			return this.class479_0;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class469.Class480 tL_OrderSchmObjList
	{
		get
		{
			return this.class480_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class469.Class481 vSchm_ObjList
	{
		get
		{
			return this.class481_0;
		}
	}

	[DebuggerNonUserCode]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class469.Class482 vSchm_TreeCellLine
	{
		get
		{
			return this.oZtCusYnXrm;
		}
	}

	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Class469.Class483 tSchm_Relation
	{
		get
		{
			return this.class483_0;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(true)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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

	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public DataTableCollection DataTableCollection_0
	{
		get
		{
			return base.Tables;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public DataRelationCollection DataRelationCollection_0
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
		Class469 @class = (Class469)base.Clone();
		@class.method_0();
		@class.method_18();
		@class.SchemaSerializationMode = this.SchemaSerializationMode;
		return @class;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			if (dataSet.Tables["tJ_Order"] != null)
			{
				base.Tables.Add(new Class469.Class470(dataSet.Tables["tJ_Order"]));
			}
			if (dataSet.Tables["vJ_Order"] != null)
			{
				base.Tables.Add(new Class469.Class471(dataSet.Tables["vJ_Order"]));
			}
			if (dataSet.Tables["tR_Classifier"] != null)
			{
				base.Tables.Add(new Class469.Class472(dataSet.Tables["tR_Classifier"]));
			}
			if (dataSet.Tables["vR_Worker"] != null)
			{
				base.Tables.Add(new Class469.Class473(dataSet.Tables["vR_Worker"]));
			}
			if (dataSet.Tables["vWorkerGroup"] != null)
			{
				base.Tables.Add(new Class469.Class474(dataSet.Tables["vWorkerGroup"]));
			}
			if (dataSet.Tables["tJ_OrderBrigade"] != null)
			{
				base.Tables.Add(new Class469.Class475(dataSet.Tables["tJ_OrderBrigade"]));
			}
			if (dataSet.Tables["tj_DailyTourReport"] != null)
			{
				base.Tables.Add(new Class469.Class476(dataSet.Tables["tj_DailyTourReport"]));
			}
			if (dataSet.Tables["tJ_OrderInstruction"] != null)
			{
				base.Tables.Add(new Class469.Class477(dataSet.Tables["tJ_OrderInstruction"]));
			}
			if (dataSet.Tables["tJ_OrderResolution"] != null)
			{
				base.Tables.Add(new Class469.Class478(dataSet.Tables["tJ_OrderResolution"]));
			}
			if (dataSet.Tables["vJ_OrderEvents"] != null)
			{
				base.Tables.Add(new Class469.Class479(dataSet.Tables["vJ_OrderEvents"]));
			}
			if (dataSet.Tables["tL_OrderSchmObjList"] != null)
			{
				base.Tables.Add(new Class469.Class480(dataSet.Tables["tL_OrderSchmObjList"]));
			}
			if (dataSet.Tables["vSchm_ObjList"] != null)
			{
				base.Tables.Add(new Class469.Class481(dataSet.Tables["vSchm_ObjList"]));
			}
			if (dataSet.Tables["vSchm_TreeCellLine"] != null)
			{
				base.Tables.Add(new Class469.Class482(dataSet.Tables["vSchm_TreeCellLine"]));
			}
			if (dataSet.Tables["tSchm_Relation"] != null)
			{
				base.Tables.Add(new Class469.Class483(dataSet.Tables["tSchm_Relation"]));
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal void method_1(bool bool_0)
	{
		this.class470_0 = (Class469.Class470)base.Tables["tJ_Order"];
		if (bool_0 && this.class470_0 != null)
		{
			this.class470_0.method_2();
		}
		this.class471_0 = (Class469.Class471)base.Tables["vJ_Order"];
		if (bool_0 && this.class471_0 != null)
		{
			this.class471_0.method_4();
		}
		this.class472_0 = (Class469.Class472)base.Tables["tR_Classifier"];
		if (bool_0 && this.class472_0 != null)
		{
			this.class472_0.method_3();
		}
		this.class473_0 = (Class469.Class473)base.Tables["vR_Worker"];
		if (bool_0 && this.class473_0 != null)
		{
			this.class473_0.method_3();
		}
		this.class474_0 = (Class469.Class474)base.Tables["vWorkerGroup"];
		if (bool_0 && this.class474_0 != null)
		{
			this.class474_0.method_2();
		}
		this.class475_0 = (Class469.Class475)base.Tables["tJ_OrderBrigade"];
		if (bool_0 && this.class475_0 != null)
		{
			this.class475_0.method_3();
		}
		this.class476_0 = (Class469.Class476)base.Tables["tj_DailyTourReport"];
		if (bool_0 && this.class476_0 != null)
		{
			this.class476_0.method_3();
		}
		this.class477_0 = (Class469.Class477)base.Tables["tJ_OrderInstruction"];
		if (bool_0 && this.class477_0 != null)
		{
			this.class477_0.method_3();
		}
		this.class478_0 = (Class469.Class478)base.Tables["tJ_OrderResolution"];
		if (bool_0 && this.class478_0 != null)
		{
			this.class478_0.method_3();
		}
		this.class479_0 = (Class469.Class479)base.Tables["vJ_OrderEvents"];
		if (bool_0 && this.class479_0 != null)
		{
			this.class479_0.method_2();
		}
		this.class480_0 = (Class469.Class480)base.Tables["tL_OrderSchmObjList"];
		if (bool_0 && this.class480_0 != null)
		{
			this.class480_0.method_3();
		}
		this.class481_0 = (Class469.Class481)base.Tables["vSchm_ObjList"];
		if (bool_0 && this.class481_0 != null)
		{
			this.class481_0.method_3();
		}
		this.oZtCusYnXrm = (Class469.Class482)base.Tables["vSchm_TreeCellLine"];
		if (bool_0 && this.oZtCusYnXrm != null)
		{
			this.oZtCusYnXrm.method_2();
		}
		this.class483_0 = (Class469.Class483)base.Tables["tSchm_Relation"];
		if (bool_0 && this.class483_0 != null)
		{
			this.class483_0.method_3();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void method_2()
	{
		base.DataSetName = "DataSetOrder";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/DataSetOrder.xsd";
		base.EnforceConstraints = true;
		this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.class470_0 = new Class469.Class470();
		base.Tables.Add(this.class470_0);
		this.class471_0 = new Class469.Class471(false);
		base.Tables.Add(this.class471_0);
		this.class472_0 = new Class469.Class472();
		base.Tables.Add(this.class472_0);
		this.class473_0 = new Class469.Class473();
		base.Tables.Add(this.class473_0);
		this.class474_0 = new Class469.Class474();
		base.Tables.Add(this.class474_0);
		this.class475_0 = new Class469.Class475();
		base.Tables.Add(this.class475_0);
		this.class476_0 = new Class469.Class476();
		base.Tables.Add(this.class476_0);
		this.class477_0 = new Class469.Class477();
		base.Tables.Add(this.class477_0);
		this.class478_0 = new Class469.Class478();
		base.Tables.Add(this.class478_0);
		this.class479_0 = new Class469.Class479();
		base.Tables.Add(this.class479_0);
		this.class480_0 = new Class469.Class480();
		base.Tables.Add(this.class480_0);
		this.class481_0 = new Class469.Class481();
		base.Tables.Add(this.class481_0);
		this.oZtCusYnXrm = new Class469.Class482();
		base.Tables.Add(this.oZtCusYnXrm);
		this.class483_0 = new Class469.Class483();
		base.Tables.Add(this.class483_0);
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool method_7()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool method_8()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool method_9()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool method_10()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool method_11()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_12()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool method_13()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool method_14()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool method_15()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool method_16()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void method_17(object sender, CollectionChangeEventArgs e)
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
		Class469 @class = new Class469();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = @class.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void method_18()
	{
		this.vJ_Order.DataColumn_26.Expression = "OutputFIO + convert(13,System.Char) + convert(10,System.Char)+ MakerFIO";
		this.vJ_Order.DataColumn_27.Expression = "resWorker+ convert(13,System.Char) + convert(10,System.Char) + beginRes";
	}

	private Class469.Class470 class470_0;

	private Class469.Class471 class471_0;

	private Class469.Class472 class472_0;

	private Class469.Class473 class473_0;

	private Class469.Class474 class474_0;

	private Class469.Class475 class475_0;

	private Class469.Class476 class476_0;

	private Class469.Class477 class477_0;

	private Class469.Class478 class478_0;

	private Class469.Class479 class479_0;

	private Class469.Class480 class480_0;

	private Class469.Class481 class481_0;

	private Class469.Class482 oZtCusYnXrm;

	private Class469.Class483 class483_0;

	private SchemaSerializationMode schemaSerializationMode_0;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate219(object sender, Class469.EventArgs215 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate220(object sender, Class469.EventArgs216 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate221(object sender, Class469.EventArgs217 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate222(object sender, Class469.EventArgs218 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate223(object sender, Class469.EventArgs219 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate224(object sender, Class469.EventArgs220 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate225(object sender, Class469.EventArgs221 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate226(object sender, Class469.EventArgs222 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate227(object sender, Class469.EventArgs223 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate228(object sender, Class469.EventArgs224 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate229(object sender, Class469.EventArgs225 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate230(object sender, Class469.EventArgs226 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate231(object sender, Class469.EventArgs227 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate232(object sender, Class469.EventArgs228 e);

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class470 : TypedTableBase<Class469.Class484>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class470()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "tJ_Order";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class470(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class470(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_2();
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
		public DataColumn DataColumn_0
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_1
		{
			get
			{
				return this.dataColumn_2;
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_3
		{
			get
			{
				return this.dataColumn_4;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_4
		{
			get
			{
				return this.dataColumn_5;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_5
		{
			get
			{
				return this.dataColumn_6;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_8
		{
			get
			{
				return this.dataColumn_9;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_9
		{
			get
			{
				return this.dataColumn_10;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_10
		{
			get
			{
				return this.dataColumn_11;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_11
		{
			get
			{
				return this.dataColumn_12;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_12
		{
			get
			{
				return this.dataColumn_13;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_13
		{
			get
			{
				return this.dataColumn_14;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_14
		{
			get
			{
				return this.dataColumn_15;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_15
		{
			get
			{
				return this.dataColumn_16;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_16
		{
			get
			{
				return this.dataColumn_17;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_17
		{
			get
			{
				return this.dataColumn_18;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idDivisionColumn
		{
			get
			{
				return this.dataColumn_19;
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
		public Class469.Class484 this[int int_0]
		{
			get
			{
				return (Class469.Class484)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate219 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate219 @delegate = this.delegate219_0;
				Class469.Delegate219 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate219 value2 = (Class469.Delegate219)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate219>(ref this.delegate219_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate219 @delegate = this.delegate219_0;
				Class469.Delegate219 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate219 value2 = (Class469.Delegate219)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate219>(ref this.delegate219_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate219 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate219 @delegate = this.delegate219_1;
				Class469.Delegate219 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate219 value2 = (Class469.Delegate219)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate219>(ref this.delegate219_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate219 @delegate = this.delegate219_1;
				Class469.Delegate219 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate219 value2 = (Class469.Delegate219)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate219>(ref this.delegate219_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate219 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate219 @delegate = this.delegate219_2;
				Class469.Delegate219 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate219 value2 = (Class469.Delegate219)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate219>(ref this.delegate219_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate219 @delegate = this.delegate219_2;
				Class469.Delegate219 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate219 value2 = (Class469.Delegate219)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate219>(ref this.delegate219_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate219 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate219 @delegate = this.delegate219_3;
				Class469.Delegate219 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate219 value2 = (Class469.Delegate219)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate219>(ref this.delegate219_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate219 @delegate = this.delegate219_3;
				Class469.Delegate219 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate219 value2 = (Class469.Delegate219)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate219>(ref this.delegate219_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class469.Class484 class484_0)
		{
			base.Rows.Add(class484_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class484 wFeHmmlxYjL(int int_0, DateTime dateTime_0, DateTime dateTime_1, int int_1, string string_0, int int_2, int int_3, int int_4, int int_5, string string_1, DateTime dateTime_2, int int_6, bool bool_0, DateTime dateTime_3, int int_7, int int_8, DateTime dateTime_4, DateTime dateTime_5, int int_9)
		{
			Class469.Class484 @class = (Class469.Class484)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				int_0,
				dateTime_0,
				dateTime_1,
				int_1,
				string_0,
				int_2,
				int_3,
				int_4,
				int_5,
				string_1,
				dateTime_2,
				int_6,
				bool_0,
				dateTime_3,
				int_7,
				int_8,
				dateTime_4,
				dateTime_5,
				int_9
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class484 method_1(int int_0)
		{
			return (Class469.Class484)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class469.Class470 @class = (Class469.Class470)base.Clone();
			@class.method_2();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class470();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["num"];
			this.dataColumn_2 = base.Columns["dateBegin"];
			this.dataColumn_3 = base.Columns["dateEnd"];
			this.dataColumn_4 = base.Columns["idSR"];
			this.dataColumn_5 = base.Columns["instruction"];
			this.dataColumn_6 = base.Columns["headworker"];
			this.dataColumn_7 = base.Columns["acceptworker"];
			this.dataColumn_8 = base.Columns["watchWorker"];
			this.dataColumn_9 = base.Columns["makerWorker"];
			this.dataColumn_10 = base.Columns["otherInstruction"];
			this.dataColumn_11 = base.Columns["dateOutput"];
			this.dataColumn_12 = base.Columns["outputWorker"];
			this.dataColumn_13 = base.Columns["registered"];
			this.dataColumn_14 = base.Columns["dateClose"];
			this.dataColumn_15 = base.Columns["closeWorker"];
			this.dataColumn_16 = base.Columns["extWorker"];
			this.dataColumn_17 = base.Columns["dateExt"];
			this.dataColumn_18 = base.Columns["dateEndExt"];
			this.dataColumn_19 = base.Columns["idDivision"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("num", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("dateBegin", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("dateEnd", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("idSR", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("instruction", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("headworker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("acceptworker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("watchWorker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("makerWorker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("otherInstruction", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("dateOutput", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("outputWorker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			this.dataColumn_13 = new DataColumn("registered", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_13);
			this.dataColumn_14 = new DataColumn("dateClose", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_14);
			this.dataColumn_15 = new DataColumn("closeWorker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_15);
			this.dataColumn_16 = new DataColumn("extWorker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_16);
			this.dataColumn_17 = new DataColumn("dateExt", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_17);
			this.dataColumn_18 = new DataColumn("dateEndExt", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_18);
			this.dataColumn_19 = new DataColumn("idDivision", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_19);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.ReadOnly = true;
			this.dataColumn_0.Unique = true;
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_2.AllowDBNull = false;
			this.dataColumn_3.AllowDBNull = false;
			this.dataColumn_4.AllowDBNull = false;
			this.dataColumn_5.AllowDBNull = false;
			this.dataColumn_5.MaxLength = 500;
			this.dataColumn_7.AllowDBNull = false;
			this.dataColumn_9.AllowDBNull = false;
			this.dataColumn_11.AllowDBNull = false;
			this.dataColumn_12.AllowDBNull = false;
			this.dataColumn_13.AllowDBNull = false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class484 method_4()
		{
			return (Class469.Class484)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class484(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class484);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate219_1 != null)
			{
				this.delegate219_1(this, new Class469.EventArgs215((Class469.Class484)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate219_0 != null)
			{
				this.delegate219_0(this, new Class469.EventArgs215((Class469.Class484)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate219_3 != null)
			{
				this.delegate219_3(this, new Class469.EventArgs215((Class469.Class484)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate219_2 != null)
			{
				this.delegate219_2(this, new Class469.EventArgs215((Class469.Class484)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5(Class469.Class484 class484_0)
		{
			base.Rows.Remove(class484_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "tJ_OrderDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		[CompilerGenerated]
		private Class469.Delegate219 delegate219_0;

		[CompilerGenerated]
		private Class469.Delegate219 delegate219_1;

		[CompilerGenerated]
		private Class469.Delegate219 delegate219_2;

		[CompilerGenerated]
		private Class469.Delegate219 delegate219_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class471 : TypedTableBase<Class469.Class485>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class471()
		{
			Class611.H9nE6ZDzTF9kb();
			this..ctor(false);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class471(bool bool_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "vJ_Order";
			this.BeginInit();
			this.method_5();
			if (bool_0)
			{
				this.method_7();
			}
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class471(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class471(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_4();
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
		public DataColumn DataColumn_0
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_1
		{
			get
			{
				return this.dataColumn_2;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_4
		{
			get
			{
				return this.dataColumn_5;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_7
		{
			get
			{
				return this.dataColumn_8;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn shxHniFuvSD
		{
			get
			{
				return this.dataColumn_9;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_8
		{
			get
			{
				return this.dataColumn_10;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_9
		{
			get
			{
				return this.dataColumn_11;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_10
		{
			get
			{
				return this.dataColumn_12;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_11
		{
			get
			{
				return this.dataColumn_13;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_12
		{
			get
			{
				return this.dataColumn_14;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_13
		{
			get
			{
				return this.dataColumn_15;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_14
		{
			get
			{
				return this.dataColumn_16;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_15
		{
			get
			{
				return this.dataColumn_17;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_16
		{
			get
			{
				return this.dataColumn_18;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_17
		{
			get
			{
				return this.dataColumn_19;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_18
		{
			get
			{
				return this.dataColumn_20;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_19
		{
			get
			{
				return this.dataColumn_21;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_20
		{
			get
			{
				return this.dataColumn_22;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_21
		{
			get
			{
				return this.dataColumn_23;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_22
		{
			get
			{
				return this.dataColumn_24;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_23
		{
			get
			{
				return this.dataColumn_25;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_24
		{
			get
			{
				return this.dataColumn_26;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_25
		{
			get
			{
				return this.dataColumn_27;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_26
		{
			get
			{
				return this.dataColumn_28;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_27
		{
			get
			{
				return this.dataColumn_29;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_28
		{
			get
			{
				return this.dataColumn_30;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_29
		{
			get
			{
				return this.dataColumn_31;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_30
		{
			get
			{
				return this.dataColumn_32;
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
		public Class469.Class485 this[int int_0]
		{
			get
			{
				return (Class469.Class485)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate220 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate220 @delegate = this.delegate220_0;
				Class469.Delegate220 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate220 value2 = (Class469.Delegate220)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate220>(ref this.delegate220_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate220 @delegate = this.delegate220_0;
				Class469.Delegate220 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate220 value2 = (Class469.Delegate220)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate220>(ref this.delegate220_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate220 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate220 @delegate = this.delegate220_1;
				Class469.Delegate220 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate220 value2 = (Class469.Delegate220)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate220>(ref this.delegate220_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate220 @delegate = this.delegate220_1;
				Class469.Delegate220 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate220 value2 = (Class469.Delegate220)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate220>(ref this.delegate220_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate220 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate220 @delegate = this.delegate220_2;
				Class469.Delegate220 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate220 value2 = (Class469.Delegate220)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate220>(ref this.delegate220_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate220 @delegate = this.delegate220_2;
				Class469.Delegate220 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate220 value2 = (Class469.Delegate220)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate220>(ref this.delegate220_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate220 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate220 @delegate = this.delegate220_3;
				Class469.Delegate220 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate220 value2 = (Class469.Delegate220)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate220>(ref this.delegate220_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate220 @delegate = this.delegate220_3;
				Class469.Delegate220 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate220 value2 = (Class469.Delegate220)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate220>(ref this.delegate220_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class469.Class485 class485_0)
		{
			base.Rows.Add(class485_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class485 method_1(int int_0, int int_1, DateTime dateTime_0, DateTime dateTime_1, int int_2, decimal decimal_0, string string_0, string string_1, int int_3, string string_2, int int_4, string string_3, int int_5, string string_4, int int_6, string string_5, string string_6, DateTime dateTime_2, int int_7, string string_7, bool bool_0, DateTime dateTime_3, int int_8, string string_8, DateTime dateTime_4, DateTime dateTime_5, int int_9, string string_9, string string_10, string string_11, int int_10, string string_12, DateTime dateTime_6)
		{
			Class469.Class485 @class = (Class469.Class485)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				int_1,
				dateTime_0,
				dateTime_1,
				int_2,
				decimal_0,
				string_0,
				string_1,
				int_3,
				string_2,
				int_4,
				string_3,
				int_5,
				string_4,
				int_6,
				string_5,
				string_6,
				dateTime_2,
				int_7,
				string_7,
				bool_0,
				dateTime_3,
				int_8,
				string_8,
				dateTime_4,
				dateTime_5,
				int_9,
				string_9,
				string_10,
				string_11,
				int_10,
				string_12,
				dateTime_6
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class485 method_2(int int_0, int int_1, DateTime dateTime_0, DateTime dateTime_1, int int_2, decimal decimal_0, string string_0, string string_1, int int_3, string string_2, int int_4, string string_3, int int_5, string string_4, int int_6, string string_5, string string_6, DateTime dateTime_2, int int_7, string string_7, bool bool_0, DateTime dateTime_3, int int_8, string string_8, DateTime dateTime_4, DateTime dateTime_5, int int_9, string string_9, int int_10, string string_10, DateTime dateTime_6)
		{
			Class469.Class485 @class = (Class469.Class485)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				int_1,
				dateTime_0,
				dateTime_1,
				int_2,
				decimal_0,
				string_0,
				string_1,
				int_3,
				string_2,
				int_4,
				string_3,
				int_5,
				string_4,
				int_6,
				string_5,
				string_6,
				dateTime_2,
				int_7,
				string_7,
				bool_0,
				dateTime_3,
				int_8,
				string_8,
				dateTime_4,
				dateTime_5,
				int_9,
				string_9,
				null,
				null,
				int_10,
				string_10,
				dateTime_6
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class485 method_3(int int_0)
		{
			return (Class469.Class485)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class469.Class471 @class = (Class469.Class471)base.Clone();
			@class.method_4();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class471();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_4()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["num"];
			this.dataColumn_2 = base.Columns["dateBegin"];
			this.dataColumn_3 = base.Columns["dateEnd"];
			this.dataColumn_4 = base.Columns["idSR"];
			this.dataColumn_5 = base.Columns["srNum"];
			this.dataColumn_6 = base.Columns["srName"];
			this.dataColumn_7 = base.Columns["instruction"];
			this.dataColumn_8 = base.Columns["headworker"];
			this.dataColumn_9 = base.Columns["headFio"];
			this.dataColumn_10 = base.Columns["acceptworker"];
			this.dataColumn_11 = base.Columns["acceptFIO"];
			this.dataColumn_12 = base.Columns["watchWorker"];
			this.dataColumn_13 = base.Columns["watchFIO"];
			this.dataColumn_14 = base.Columns["makerWorker"];
			this.dataColumn_15 = base.Columns["makerFIO"];
			this.dataColumn_16 = base.Columns["otherInstruction"];
			this.dataColumn_17 = base.Columns["dateOutput"];
			this.dataColumn_18 = base.Columns["outputWorker"];
			this.dataColumn_19 = base.Columns["outputFIO"];
			this.dataColumn_20 = base.Columns["registered"];
			this.dataColumn_21 = base.Columns["dateClose"];
			this.dataColumn_22 = base.Columns["closeWorker"];
			this.dataColumn_23 = base.Columns["closeFIO"];
			this.dataColumn_24 = base.Columns["beginRes"];
			this.dataColumn_25 = base.Columns["EndRes"];
			this.dataColumn_26 = base.Columns["resWorkerId"];
			this.dataColumn_27 = base.Columns["resWorker"];
			this.dataColumn_28 = base.Columns["OutputMaker"];
			this.dataColumn_29 = base.Columns["Resolution"];
			this.dataColumn_30 = base.Columns["extWorker"];
			this.dataColumn_31 = base.Columns["extFio"];
			this.dataColumn_32 = base.Columns["DateEndExt"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_5()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("num", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("dateBegin", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("dateEnd", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("idSR", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("srNum", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("srName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("instruction", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("headworker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("headFio", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("acceptworker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("acceptFIO", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("watchWorker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			this.dataColumn_13 = new DataColumn("watchFIO", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_13);
			this.dataColumn_14 = new DataColumn("makerWorker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_14);
			this.dataColumn_15 = new DataColumn("makerFIO", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_15);
			this.dataColumn_16 = new DataColumn("otherInstruction", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_16);
			this.dataColumn_17 = new DataColumn("dateOutput", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_17);
			this.dataColumn_18 = new DataColumn("outputWorker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_18);
			this.dataColumn_19 = new DataColumn("outputFIO", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_19);
			this.dataColumn_20 = new DataColumn("registered", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_20);
			this.dataColumn_21 = new DataColumn("dateClose", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_21);
			this.dataColumn_22 = new DataColumn("closeWorker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_22);
			this.dataColumn_23 = new DataColumn("closeFIO", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_23);
			this.dataColumn_24 = new DataColumn("beginRes", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_24);
			this.dataColumn_25 = new DataColumn("EndRes", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_25);
			this.dataColumn_26 = new DataColumn("resWorkerId", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_26);
			this.dataColumn_27 = new DataColumn("resWorker", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_27);
			this.dataColumn_28 = new DataColumn("OutputMaker", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_28);
			this.dataColumn_29 = new DataColumn("Resolution", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_29);
			this.dataColumn_30 = new DataColumn("extWorker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_30);
			this.dataColumn_31 = new DataColumn("extFio", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_31);
			this.dataColumn_32 = new DataColumn("DateEndExt", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_32);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.Unique = true;
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_2.AllowDBNull = false;
			this.dataColumn_3.AllowDBNull = false;
			this.dataColumn_4.AllowDBNull = false;
			this.dataColumn_6.MaxLength = 100;
			this.dataColumn_7.AllowDBNull = false;
			this.dataColumn_7.MaxLength = 500;
			this.dataColumn_9.ReadOnly = true;
			this.dataColumn_9.MaxLength = 35;
			this.dataColumn_10.AllowDBNull = false;
			this.dataColumn_11.ReadOnly = true;
			this.dataColumn_11.MaxLength = 35;
			this.dataColumn_13.ReadOnly = true;
			this.dataColumn_13.MaxLength = 35;
			this.dataColumn_14.AllowDBNull = false;
			this.dataColumn_15.ReadOnly = true;
			this.dataColumn_15.MaxLength = 35;
			this.dataColumn_17.AllowDBNull = false;
			this.dataColumn_18.AllowDBNull = false;
			this.dataColumn_19.ReadOnly = true;
			this.dataColumn_19.MaxLength = 35;
			this.dataColumn_20.AllowDBNull = false;
			this.dataColumn_23.ReadOnly = true;
			this.dataColumn_23.MaxLength = 35;
			this.dataColumn_27.ReadOnly = true;
			this.dataColumn_27.MaxLength = 35;
			this.dataColumn_28.ReadOnly = true;
			this.dataColumn_29.ReadOnly = true;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class485 method_6()
		{
			return (Class469.Class485)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class485(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class485);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_7()
		{
			this.DataColumn_26.Expression = "OutputFIO + convert(13,System.Char) + convert(10,System.Char)+ MakerFIO";
			this.DataColumn_27.Expression = "resWorker+ convert(13,System.Char) + convert(10,System.Char) + beginRes";
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate220_1 != null)
			{
				this.delegate220_1(this, new Class469.EventArgs216((Class469.Class485)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate220_0 != null)
			{
				this.delegate220_0(this, new Class469.EventArgs216((Class469.Class485)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate220_3 != null)
			{
				this.delegate220_3(this, new Class469.EventArgs216((Class469.Class485)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate220_2 != null)
			{
				this.delegate220_2(this, new Class469.EventArgs216((Class469.Class485)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_8(Class469.Class485 class485_0)
		{
			base.Rows.Remove(class485_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "vJ_OrderDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		private DataColumn dataColumn_21;

		private DataColumn dataColumn_22;

		private DataColumn dataColumn_23;

		private DataColumn dataColumn_24;

		private DataColumn dataColumn_25;

		private DataColumn dataColumn_26;

		private DataColumn dataColumn_27;

		private DataColumn dataColumn_28;

		private DataColumn dataColumn_29;

		private DataColumn dataColumn_30;

		private DataColumn dataColumn_31;

		private DataColumn dataColumn_32;

		[CompilerGenerated]
		private Class469.Delegate220 delegate220_0;

		[CompilerGenerated]
		private Class469.Delegate220 delegate220_1;

		[CompilerGenerated]
		private Class469.Delegate220 delegate220_2;

		[CompilerGenerated]
		private Class469.Delegate220 delegate220_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class472 : TypedTableBase<Class469.Class486>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class472()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "tR_Classifier";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class472(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class472(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
		public Class469.Class486 this[int int_0]
		{
			get
			{
				return (Class469.Class486)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate221 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate221 @delegate = this.delegate221_0;
				Class469.Delegate221 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate221 value2 = (Class469.Delegate221)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate221>(ref this.delegate221_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate221 @delegate = this.delegate221_0;
				Class469.Delegate221 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate221 value2 = (Class469.Delegate221)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate221>(ref this.delegate221_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate221 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate221 @delegate = this.delegate221_1;
				Class469.Delegate221 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate221 value2 = (Class469.Delegate221)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate221>(ref this.delegate221_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate221 @delegate = this.delegate221_1;
				Class469.Delegate221 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate221 value2 = (Class469.Delegate221)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate221>(ref this.delegate221_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate221 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate221 @delegate = this.delegate221_2;
				Class469.Delegate221 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate221 value2 = (Class469.Delegate221)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate221>(ref this.delegate221_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate221 @delegate = this.delegate221_2;
				Class469.Delegate221 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate221 value2 = (Class469.Delegate221)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate221>(ref this.delegate221_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate221 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate221 @delegate = this.delegate221_3;
				Class469.Delegate221 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate221 value2 = (Class469.Delegate221)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate221>(ref this.delegate221_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate221 @delegate = this.delegate221_3;
				Class469.Delegate221 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate221 value2 = (Class469.Delegate221)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate221>(ref this.delegate221_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class469.Class486 class486_0)
		{
			base.Rows.Add(class486_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class486 method_1(string string_0, string string_1, decimal decimal_0, string string_2, int int_0, string string_3, byte[] byte_0, bool bool_0, bool bool_1)
		{
			Class469.Class486 @class = (Class469.Class486)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				string_0,
				string_1,
				decimal_0,
				string_2,
				int_0,
				string_3,
				byte_0,
				bool_0,
				bool_1
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class486 method_2(int int_0)
		{
			return (Class469.Class486)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class469.Class472 @class = (Class469.Class472)base.Clone();
			@class.method_3();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class472();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["Id"];
			this.dataColumn_1 = base.Columns["Name"];
			this.dataColumn_2 = base.Columns["SocrName"];
			this.dataColumn_3 = base.Columns["Value"];
			this.dataColumn_4 = base.Columns["Comment"];
			this.dataColumn_5 = base.Columns["ParentId"];
			this.dataColumn_6 = base.Columns["ParentKey"];
			this.dataColumn_7 = base.Columns["OtherId"];
			this.dataColumn_8 = base.Columns["IsGroup"];
			this.dataColumn_9 = base.Columns["Deleted"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("Id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("Name", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("SocrName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("Value", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("Comment", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("ParentId", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("ParentKey", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("OtherId", typeof(byte[]), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("IsGroup", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.AutoIncrementSeed = -1L;
			this.dataColumn_0.AutoIncrementStep = -1L;
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.ReadOnly = true;
			this.dataColumn_0.Unique = true;
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_1.MaxLength = 100;
			this.dataColumn_2.MaxLength = 50;
			this.dataColumn_4.MaxLength = 1024;
			this.dataColumn_6.MaxLength = 50;
			this.dataColumn_8.AllowDBNull = false;
			this.dataColumn_9.AllowDBNull = false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class486 method_5()
		{
			return (Class469.Class486)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class486(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class486);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate221_1 != null)
			{
				this.delegate221_1(this, new Class469.EventArgs217((Class469.Class486)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate221_0 != null)
			{
				this.delegate221_0(this, new Class469.EventArgs217((Class469.Class486)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate221_3 != null)
			{
				this.delegate221_3(this, new Class469.EventArgs217((Class469.Class486)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate221_2 != null)
			{
				this.delegate221_2(this, new Class469.EventArgs217((Class469.Class486)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_6(Class469.Class486 class486_0)
		{
			base.Rows.Remove(class486_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "tR_ClassifierDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		[CompilerGenerated]
		private Class469.Delegate221 delegate221_0;

		[CompilerGenerated]
		private Class469.Delegate221 delegate221_1;

		[CompilerGenerated]
		private Class469.Delegate221 delegate221_2;

		[CompilerGenerated]
		private Class469.Delegate221 delegate221_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class473 : TypedTableBase<Class469.Class487>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class473()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "vR_Worker";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class473(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class473(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_0
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_1
		{
			get
			{
				return this.dataColumn_2;
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
		public Class469.Class487 this[int int_0]
		{
			get
			{
				return (Class469.Class487)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate222 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate222 @delegate = this.delegate222_0;
				Class469.Delegate222 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate222 value2 = (Class469.Delegate222)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate222>(ref this.delegate222_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate222 @delegate = this.delegate222_0;
				Class469.Delegate222 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate222 value2 = (Class469.Delegate222)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate222>(ref this.delegate222_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate222 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate222 @delegate = this.delegate222_1;
				Class469.Delegate222 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate222 value2 = (Class469.Delegate222)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate222>(ref this.delegate222_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate222 @delegate = this.delegate222_1;
				Class469.Delegate222 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate222 value2 = (Class469.Delegate222)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate222>(ref this.delegate222_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate222 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate222 @delegate = this.delegate222_2;
				Class469.Delegate222 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate222 value2 = (Class469.Delegate222)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate222>(ref this.delegate222_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate222 @delegate = this.delegate222_2;
				Class469.Delegate222 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate222 value2 = (Class469.Delegate222)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate222>(ref this.delegate222_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate222 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate222 @delegate = this.delegate222_3;
				Class469.Delegate222 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate222 value2 = (Class469.Delegate222)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate222>(ref this.delegate222_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate222 @delegate = this.delegate222_3;
				Class469.Delegate222 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate222 value2 = (Class469.Delegate222)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate222>(ref this.delegate222_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class469.Class487 class487_0)
		{
			base.Rows.Add(class487_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class487 method_1(int int_0, string string_0, DateTime dateTime_0, DateTime dateTime_1, short short_0)
		{
			Class469.Class487 @class = (Class469.Class487)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				string_0,
				dateTime_0,
				dateTime_1,
				short_0
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class487 method_2(int int_0)
		{
			return (Class469.Class487)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class469.Class473 @class = (Class469.Class473)base.Clone();
			@class.method_3();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class473();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["FIO"];
			this.dataColumn_2 = base.Columns["DateBegin"];
			this.dataColumn_3 = base.Columns["DateEnd"];
			this.dataColumn_4 = base.Columns["GroupElectrical"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("FIO", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("DateBegin", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("DateEnd", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("GroupElectrical", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.Unique = true;
			this.dataColumn_1.ReadOnly = true;
			this.dataColumn_1.MaxLength = 35;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class487 method_5()
		{
			return (Class469.Class487)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class487(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class487);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate222_1 != null)
			{
				this.delegate222_1(this, new Class469.EventArgs218((Class469.Class487)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate222_0 != null)
			{
				this.delegate222_0(this, new Class469.EventArgs218((Class469.Class487)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate222_3 != null)
			{
				this.delegate222_3(this, new Class469.EventArgs218((Class469.Class487)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate222_2 != null)
			{
				this.delegate222_2(this, new Class469.EventArgs218((Class469.Class487)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_6(Class469.Class487 class487_0)
		{
			base.Rows.Remove(class487_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "vR_WorkerDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		[CompilerGenerated]
		private Class469.Delegate222 delegate222_0;

		[CompilerGenerated]
		private Class469.Delegate222 delegate222_1;

		[CompilerGenerated]
		private Class469.Delegate222 delegate222_2;

		[CompilerGenerated]
		private Class469.Delegate222 delegate222_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class474 : TypedTableBase<Class469.Class488>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class474()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "vWorkerGroup";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class474(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class474(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_2();
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
		public DataColumn DataColumn_0
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_1
		{
			get
			{
				return this.dataColumn_2;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_4
		{
			get
			{
				return this.dataColumn_5;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_5
		{
			get
			{
				return this.dataColumn_6;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_6
		{
			get
			{
				return this.dataColumn_7;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
				return this.dataColumn_9;
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class488 this[int int_0]
		{
			get
			{
				return (Class469.Class488)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate223 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate223 @delegate = this.delegate223_0;
				Class469.Delegate223 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate223 value2 = (Class469.Delegate223)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate223>(ref this.delegate223_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate223 @delegate = this.delegate223_0;
				Class469.Delegate223 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate223 value2 = (Class469.Delegate223)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate223>(ref this.delegate223_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate223 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate223 @delegate = this.delegate223_1;
				Class469.Delegate223 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate223 value2 = (Class469.Delegate223)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate223>(ref this.delegate223_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate223 @delegate = this.delegate223_1;
				Class469.Delegate223 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate223 value2 = (Class469.Delegate223)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate223>(ref this.delegate223_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate223 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate223 @delegate = this.delegate223_2;
				Class469.Delegate223 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate223 value2 = (Class469.Delegate223)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate223>(ref this.delegate223_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate223 @delegate = this.delegate223_2;
				Class469.Delegate223 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate223 value2 = (Class469.Delegate223)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate223>(ref this.delegate223_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate223 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate223 @delegate = this.delegate223_3;
				Class469.Delegate223 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate223 value2 = (Class469.Delegate223)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate223>(ref this.delegate223_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate223 @delegate = this.delegate223_3;
				Class469.Delegate223 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate223 value2 = (Class469.Delegate223)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate223>(ref this.delegate223_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class469.Class488 class488_0)
		{
			base.Rows.Add(class488_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class488 method_1(int int_0, string string_0, DateTime dateTime_0, DateTime dateTime_1, int int_1, string string_1, string string_2, string string_3, int int_2, short short_0)
		{
			Class469.Class488 @class = (Class469.Class488)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				string_0,
				dateTime_0,
				dateTime_1,
				int_1,
				string_1,
				string_2,
				string_3,
				int_2,
				short_0
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class469.Class474 @class = (Class469.Class474)base.Clone();
			@class.method_2();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class474();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["FIO"];
			this.dataColumn_2 = base.Columns["DateBegin"];
			this.dataColumn_3 = base.Columns["DateEnd"];
			this.dataColumn_4 = base.Columns["idGroup"];
			this.dataColumn_5 = base.Columns["WorkerGroup"];
			this.dataColumn_6 = base.Columns["ParentKey"];
			this.dataColumn_7 = base.Columns["Description"];
			this.dataColumn_8 = base.Columns["idDescription"];
			this.dataColumn_9 = base.Columns["GroupElectrical"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("FIO", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("DateBegin", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("DateEnd", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("idGroup", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("WorkerGroup", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("ParentKey", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("Description", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("idDescription", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("GroupElectrical", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_1.ReadOnly = true;
			this.dataColumn_1.MaxLength = 35;
			this.dataColumn_5.MaxLength = 100;
			this.dataColumn_6.MaxLength = 50;
			this.dataColumn_7.MaxLength = 100;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class488 method_4()
		{
			return (Class469.Class488)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class488(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class488);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate223_1 != null)
			{
				this.delegate223_1(this, new Class469.EventArgs219((Class469.Class488)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate223_0 != null)
			{
				this.delegate223_0(this, new Class469.EventArgs219((Class469.Class488)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate223_3 != null)
			{
				this.delegate223_3(this, new Class469.EventArgs219((Class469.Class488)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate223_2 != null)
			{
				this.delegate223_2(this, new Class469.EventArgs219((Class469.Class488)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5(Class469.Class488 class488_0)
		{
			base.Rows.Remove(class488_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "vWorkerGroupDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		[CompilerGenerated]
		private Class469.Delegate223 delegate223_0;

		[CompilerGenerated]
		private Class469.Delegate223 delegate223_1;

		[CompilerGenerated]
		private Class469.Delegate223 delegate223_2;

		[CompilerGenerated]
		private Class469.Delegate223 delegate223_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class475 : TypedTableBase<Class469.Class489>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class475()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "tJ_OrderBrigade";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class475(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class475(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
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
		public DataColumn DataColumn_0
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idWorkerColumn
		{
			get
			{
				return this.dataColumn_2;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_1
		{
			get
			{
				return this.dataColumn_3;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_2
		{
			get
			{
				return this.dataColumn_4;
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class489 this[int int_0]
		{
			get
			{
				return (Class469.Class489)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate224 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate224 @delegate = this.delegate224_0;
				Class469.Delegate224 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate224 value2 = (Class469.Delegate224)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate224>(ref this.delegate224_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate224 @delegate = this.delegate224_0;
				Class469.Delegate224 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate224 value2 = (Class469.Delegate224)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate224>(ref this.delegate224_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate224 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate224 @delegate = this.delegate224_1;
				Class469.Delegate224 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate224 value2 = (Class469.Delegate224)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate224>(ref this.delegate224_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate224 @delegate = this.delegate224_1;
				Class469.Delegate224 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate224 value2 = (Class469.Delegate224)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate224>(ref this.delegate224_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate224 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate224 @delegate = this.delegate224_2;
				Class469.Delegate224 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate224 value2 = (Class469.Delegate224)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate224>(ref this.delegate224_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate224 @delegate = this.delegate224_2;
				Class469.Delegate224 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate224 value2 = (Class469.Delegate224)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate224>(ref this.delegate224_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate224 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate224 @delegate = this.delegate224_3;
				Class469.Delegate224 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate224 value2 = (Class469.Delegate224)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate224>(ref this.delegate224_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate224 @delegate = this.delegate224_3;
				Class469.Delegate224 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate224 value2 = (Class469.Delegate224)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate224>(ref this.delegate224_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class469.Class489 class489_0)
		{
			base.Rows.Add(class489_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class489 method_1(int int_0, int int_1, int int_2, bool bool_0)
		{
			Class469.Class489 @class = (Class469.Class489)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				int_0,
				int_1,
				int_2,
				bool_0
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class489 method_2(int int_0)
		{
			return (Class469.Class489)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class469.Class475 @class = (Class469.Class475)base.Clone();
			@class.method_3();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class475();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["idOrder"];
			this.dataColumn_2 = base.Columns["idWorker"];
			this.dataColumn_3 = base.Columns["idJobTitle"];
			this.dataColumn_4 = base.Columns["isUnderstudy"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("idOrder", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("idWorker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("idJobTitle", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("isUnderstudy", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.AutoIncrementSeed = -1L;
			this.dataColumn_0.AutoIncrementStep = -1L;
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.ReadOnly = true;
			this.dataColumn_0.Unique = true;
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_2.AllowDBNull = false;
			this.dataColumn_4.DefaultValue = false;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class489 method_5()
		{
			return (Class469.Class489)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class489(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class489);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate224_1 != null)
			{
				this.delegate224_1(this, new Class469.EventArgs220((Class469.Class489)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate224_0 != null)
			{
				this.delegate224_0(this, new Class469.EventArgs220((Class469.Class489)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate224_3 != null)
			{
				this.delegate224_3(this, new Class469.EventArgs220((Class469.Class489)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate224_2 != null)
			{
				this.delegate224_2(this, new Class469.EventArgs220((Class469.Class489)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_6(Class469.Class489 class489_0)
		{
			base.Rows.Remove(class489_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "tJ_OrderBrigadeDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		[CompilerGenerated]
		private Class469.Delegate224 delegate224_0;

		[CompilerGenerated]
		private Class469.Delegate224 delegate224_1;

		[CompilerGenerated]
		private Class469.Delegate224 delegate224_2;

		[CompilerGenerated]
		private Class469.Delegate224 delegate224_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class476 : TypedTableBase<Class469.Class490>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class476()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "tj_DailyTourReport";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class476(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class476(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
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
		public DataColumn DataColumn_0
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_1
		{
			get
			{
				return this.dataColumn_2;
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_3
		{
			get
			{
				return this.dataColumn_4;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_4
		{
			get
			{
				return this.dataColumn_5;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
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
		public Class469.Class490 this[int int_0]
		{
			get
			{
				return (Class469.Class490)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate225 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate225 @delegate = this.delegate225_0;
				Class469.Delegate225 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate225 value2 = (Class469.Delegate225)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate225>(ref this.delegate225_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate225 @delegate = this.delegate225_0;
				Class469.Delegate225 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate225 value2 = (Class469.Delegate225)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate225>(ref this.delegate225_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate225 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate225 @delegate = this.delegate225_1;
				Class469.Delegate225 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate225 value2 = (Class469.Delegate225)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate225>(ref this.delegate225_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate225 @delegate = this.delegate225_1;
				Class469.Delegate225 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate225 value2 = (Class469.Delegate225)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate225>(ref this.delegate225_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate225 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate225 @delegate = this.delegate225_2;
				Class469.Delegate225 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate225 value2 = (Class469.Delegate225)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate225>(ref this.delegate225_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate225 @delegate = this.delegate225_2;
				Class469.Delegate225 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate225 value2 = (Class469.Delegate225)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate225>(ref this.delegate225_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate225 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate225 @delegate = this.delegate225_3;
				Class469.Delegate225 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate225 value2 = (Class469.Delegate225)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate225>(ref this.delegate225_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate225 @delegate = this.delegate225_3;
				Class469.Delegate225 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate225 value2 = (Class469.Delegate225)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate225>(ref this.delegate225_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class469.Class490 class490_0)
		{
			base.Rows.Add(class490_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class490 method_1(DateTime dateTime_0, int int_0, int int_1, int int_2, int int_3)
		{
			Class469.Class490 @class = (Class469.Class490)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				dateTime_0,
				int_0,
				int_1,
				int_2,
				int_3
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class490 method_2(int int_0)
		{
			return (Class469.Class490)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class469.Class476 @class = (Class469.Class476)base.Clone();
			@class.method_3();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class476();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["date"];
			this.dataColumn_2 = base.Columns["was"];
			this.dataColumn_3 = base.Columns["disp1"];
			this.dataColumn_4 = base.Columns["disp2"];
			this.dataColumn_5 = base.Columns["disp3"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("was", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("disp1", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("disp2", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("disp3", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.AutoIncrementSeed = -1L;
			this.dataColumn_0.AutoIncrementStep = -1L;
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.ReadOnly = true;
			this.dataColumn_0.Unique = true;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class490 method_5()
		{
			return (Class469.Class490)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class490(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class490);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate225_1 != null)
			{
				this.delegate225_1(this, new Class469.EventArgs221((Class469.Class490)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate225_0 != null)
			{
				this.delegate225_0(this, new Class469.EventArgs221((Class469.Class490)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate225_3 != null)
			{
				this.delegate225_3(this, new Class469.EventArgs221((Class469.Class490)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate225_2 != null)
			{
				this.delegate225_2(this, new Class469.EventArgs221((Class469.Class490)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_6(Class469.Class490 class490_0)
		{
			base.Rows.Remove(class490_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "tj_DailyTourReportDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private DataColumn dataColumn_5;

		[CompilerGenerated]
		private Class469.Delegate225 delegate225_0;

		[CompilerGenerated]
		private Class469.Delegate225 delegate225_1;

		[CompilerGenerated]
		private Class469.Delegate225 delegate225_2;

		[CompilerGenerated]
		private Class469.Delegate225 delegate225_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class477 : TypedTableBase<Class469.Class491>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class477()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "tJ_OrderInstruction";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class477(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class477(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
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
		public DataColumn DataColumn_0
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_1
		{
			get
			{
				return this.dataColumn_2;
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class491 this[int int_0]
		{
			get
			{
				return (Class469.Class491)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate226 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate226 @delegate = this.GjyHdgrvUrw;
				Class469.Delegate226 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate226 value2 = (Class469.Delegate226)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate226>(ref this.GjyHdgrvUrw, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate226 @delegate = this.GjyHdgrvUrw;
				Class469.Delegate226 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate226 value2 = (Class469.Delegate226)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate226>(ref this.GjyHdgrvUrw, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate226 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate226 @delegate = this.delegate226_0;
				Class469.Delegate226 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate226 value2 = (Class469.Delegate226)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate226>(ref this.delegate226_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate226 @delegate = this.delegate226_0;
				Class469.Delegate226 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate226 value2 = (Class469.Delegate226)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate226>(ref this.delegate226_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate226 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate226 @delegate = this.delegate226_1;
				Class469.Delegate226 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate226 value2 = (Class469.Delegate226)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate226>(ref this.delegate226_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate226 @delegate = this.delegate226_1;
				Class469.Delegate226 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate226 value2 = (Class469.Delegate226)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate226>(ref this.delegate226_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate226 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate226 @delegate = this.delegate226_2;
				Class469.Delegate226 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate226 value2 = (Class469.Delegate226)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate226>(ref this.delegate226_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate226 @delegate = this.delegate226_2;
				Class469.Delegate226 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate226 value2 = (Class469.Delegate226)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate226>(ref this.delegate226_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class469.Class491 class491_0)
		{
			base.Rows.Add(class491_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class491 method_1(int int_0, string string_0, string string_1, int int_1)
		{
			Class469.Class491 @class = (Class469.Class491)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				int_0,
				string_0,
				string_1,
				int_1
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class491 method_2(int int_0)
		{
			return (Class469.Class491)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class469.Class477 @class = (Class469.Class477)base.Clone();
			@class.method_3();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class477();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["idOrder"];
			this.dataColumn_2 = base.Columns["NameObj"];
			this.dataColumn_3 = base.Columns["Instruction"];
			this.dataColumn_4 = base.Columns["rec_num"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("idOrder", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("NameObj", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("Instruction", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("rec_num", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.AutoIncrementSeed = -1L;
			this.dataColumn_0.AutoIncrementStep = -1L;
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.ReadOnly = true;
			this.dataColumn_0.Unique = true;
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_2.AllowDBNull = false;
			this.dataColumn_2.MaxLength = 350;
			this.dataColumn_3.AllowDBNull = false;
			this.dataColumn_3.MaxLength = 350;
			this.dataColumn_4.AutoIncrementSeed = 1L;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class491 method_5()
		{
			return (Class469.Class491)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class491(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class491);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate226_0 != null)
			{
				this.delegate226_0(this, new Class469.EventArgs222((Class469.Class491)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.GjyHdgrvUrw != null)
			{
				this.GjyHdgrvUrw(this, new Class469.EventArgs222((Class469.Class491)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate226_2 != null)
			{
				this.delegate226_2(this, new Class469.EventArgs222((Class469.Class491)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate226_1 != null)
			{
				this.delegate226_1(this, new Class469.EventArgs222((Class469.Class491)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_6(Class469.Class491 class491_0)
		{
			base.Rows.Remove(class491_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "tJ_OrderInstructionDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		[CompilerGenerated]
		private Class469.Delegate226 GjyHdgrvUrw;

		[CompilerGenerated]
		private Class469.Delegate226 delegate226_0;

		[CompilerGenerated]
		private Class469.Delegate226 delegate226_1;

		[CompilerGenerated]
		private Class469.Delegate226 delegate226_2;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class478 : TypedTableBase<Class469.Class492>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class478()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "tJ_OrderResolution";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class478(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class478(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
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
		public DataColumn DataColumn_0
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idWorkerColumn
		{
			get
			{
				return this.dataColumn_2;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_1
		{
			get
			{
				return this.dataColumn_3;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_2
		{
			get
			{
				return this.dataColumn_4;
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class492 this[int int_0]
		{
			get
			{
				return (Class469.Class492)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate227 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate227 @delegate = this.delegate227_0;
				Class469.Delegate227 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate227 value2 = (Class469.Delegate227)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate227>(ref this.delegate227_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate227 @delegate = this.delegate227_0;
				Class469.Delegate227 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate227 value2 = (Class469.Delegate227)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate227>(ref this.delegate227_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate227 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate227 @delegate = this.delegate227_1;
				Class469.Delegate227 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate227 value2 = (Class469.Delegate227)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate227>(ref this.delegate227_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate227 @delegate = this.delegate227_1;
				Class469.Delegate227 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate227 value2 = (Class469.Delegate227)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate227>(ref this.delegate227_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate227 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate227 @delegate = this.nKbHsvsKaIs;
				Class469.Delegate227 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate227 value2 = (Class469.Delegate227)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate227>(ref this.nKbHsvsKaIs, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate227 @delegate = this.nKbHsvsKaIs;
				Class469.Delegate227 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate227 value2 = (Class469.Delegate227)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate227>(ref this.nKbHsvsKaIs, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate227 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate227 @delegate = this.delegate227_2;
				Class469.Delegate227 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate227 value2 = (Class469.Delegate227)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate227>(ref this.delegate227_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate227 @delegate = this.delegate227_2;
				Class469.Delegate227 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate227 value2 = (Class469.Delegate227)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate227>(ref this.delegate227_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class469.Class492 class492_0)
		{
			base.Rows.Add(class492_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class492 method_1(int int_0, int int_1, DateTime dateTime_0, DateTime dateTime_1)
		{
			Class469.Class492 @class = (Class469.Class492)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				int_0,
				int_1,
				dateTime_0,
				dateTime_1
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class492 method_2(int int_0)
		{
			return (Class469.Class492)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class469.Class478 @class = (Class469.Class478)base.Clone();
			@class.method_3();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class478();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["idOrder"];
			this.dataColumn_2 = base.Columns["idWorker"];
			this.dataColumn_3 = base.Columns["DateBegin"];
			this.dataColumn_4 = base.Columns["DateEnd"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("idOrder", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("idWorker", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("DateBegin", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("DateEnd", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.AutoIncrementSeed = -1L;
			this.dataColumn_0.AutoIncrementStep = -1L;
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.ReadOnly = true;
			this.dataColumn_0.Unique = true;
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_2.AllowDBNull = false;
			this.dataColumn_3.AllowDBNull = false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class492 method_5()
		{
			return (Class469.Class492)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class492(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class492);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate227_1 != null)
			{
				this.delegate227_1(this, new Class469.EventArgs223((Class469.Class492)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate227_0 != null)
			{
				this.delegate227_0(this, new Class469.EventArgs223((Class469.Class492)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate227_2 != null)
			{
				this.delegate227_2(this, new Class469.EventArgs223((Class469.Class492)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.nKbHsvsKaIs != null)
			{
				this.nKbHsvsKaIs(this, new Class469.EventArgs223((Class469.Class492)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_6(Class469.Class492 class492_0)
		{
			base.Rows.Remove(class492_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "tJ_OrderResolutionDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		[CompilerGenerated]
		private Class469.Delegate227 delegate227_0;

		[CompilerGenerated]
		private Class469.Delegate227 delegate227_1;

		[CompilerGenerated]
		private Class469.Delegate227 nKbHsvsKaIs;

		[CompilerGenerated]
		private Class469.Delegate227 delegate227_2;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class479 : TypedTableBase<Class469.Class493>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class479()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "vJ_OrderEvents";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class479(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class479(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_2();
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
		public DataColumn DataColumn_0
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_1
		{
			get
			{
				return this.dataColumn_2;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_2
		{
			get
			{
				return this.dataColumn_3;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
				return this.dataColumn_9;
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
		public Class469.Class493 this[int int_0]
		{
			get
			{
				return (Class469.Class493)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate228 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate228 @delegate = this.delegate228_0;
				Class469.Delegate228 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate228 value2 = (Class469.Delegate228)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate228>(ref this.delegate228_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate228 @delegate = this.delegate228_0;
				Class469.Delegate228 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate228 value2 = (Class469.Delegate228)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate228>(ref this.delegate228_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate228 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate228 @delegate = this.delegate228_1;
				Class469.Delegate228 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate228 value2 = (Class469.Delegate228)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate228>(ref this.delegate228_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate228 @delegate = this.delegate228_1;
				Class469.Delegate228 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate228 value2 = (Class469.Delegate228)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate228>(ref this.delegate228_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate228 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate228 @delegate = this.delegate228_2;
				Class469.Delegate228 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate228 value2 = (Class469.Delegate228)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate228>(ref this.delegate228_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate228 @delegate = this.delegate228_2;
				Class469.Delegate228 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate228 value2 = (Class469.Delegate228)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate228>(ref this.delegate228_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate228 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate228 @delegate = this.delegate228_3;
				Class469.Delegate228 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate228 value2 = (Class469.Delegate228)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate228>(ref this.delegate228_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate228 @delegate = this.delegate228_3;
				Class469.Delegate228 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate228 value2 = (Class469.Delegate228)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate228>(ref this.delegate228_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class469.Class493 class493_0)
		{
			base.Rows.Add(class493_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class493 method_1(int int_0, int int_1, int int_2, string string_0, string string_1, string string_2, string string_3, DateTime dateTime_0, int int_3, string string_4)
		{
			Class469.Class493 @class = (Class469.Class493)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				int_1,
				int_2,
				string_0,
				string_1,
				string_2,
				string_3,
				dateTime_0,
				int_3,
				string_4
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class469.Class479 @class = (Class469.Class479)base.Clone();
			@class.method_2();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class479();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["num"];
			this.dataColumn_2 = base.Columns["srNum"];
			this.dataColumn_3 = base.Columns["instruction"];
			this.dataColumn_4 = base.Columns["acceptFIO"];
			this.dataColumn_5 = base.Columns["makerFio"];
			this.dataColumn_6 = base.Columns["Evnt"];
			this.dataColumn_7 = base.Columns["EvntDate"];
			this.dataColumn_8 = base.Columns["closed"];
			this.dataColumn_9 = base.Columns["disp"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("num", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("srNum", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("instruction", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("acceptFIO", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("makerFio", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("Evnt", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("EvntDate", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("closed", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("disp", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_3.AllowDBNull = false;
			this.dataColumn_3.MaxLength = 500;
			this.dataColumn_4.MaxLength = 35;
			this.dataColumn_5.MaxLength = 35;
			this.dataColumn_6.AllowDBNull = false;
			this.dataColumn_6.MaxLength = 16;
			this.dataColumn_8.AllowDBNull = false;
			this.dataColumn_9.MaxLength = 35;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class493 method_4()
		{
			return (Class469.Class493)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class493(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class493);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate228_1 != null)
			{
				this.delegate228_1(this, new Class469.EventArgs224((Class469.Class493)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate228_0 != null)
			{
				this.delegate228_0(this, new Class469.EventArgs224((Class469.Class493)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate228_3 != null)
			{
				this.delegate228_3(this, new Class469.EventArgs224((Class469.Class493)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate228_2 != null)
			{
				this.delegate228_2(this, new Class469.EventArgs224((Class469.Class493)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void gtuHsetbBin(Class469.Class493 class493_0)
		{
			base.Rows.Remove(class493_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "vJ_OrderEventsDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		[CompilerGenerated]
		private Class469.Delegate228 delegate228_0;

		[CompilerGenerated]
		private Class469.Delegate228 delegate228_1;

		[CompilerGenerated]
		private Class469.Delegate228 delegate228_2;

		[CompilerGenerated]
		private Class469.Delegate228 delegate228_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class480 : TypedTableBase<Class469.Class494>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class480()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "tL_OrderSchmObjList";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class480(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class480(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_0
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idSchmObjColumn
		{
			get
			{
				return this.dataColumn_2;
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
		public Class469.Class494 this[int int_0]
		{
			get
			{
				return (Class469.Class494)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate229 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate229 @delegate = this.delegate229_0;
				Class469.Delegate229 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate229 value2 = (Class469.Delegate229)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate229>(ref this.delegate229_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate229 @delegate = this.delegate229_0;
				Class469.Delegate229 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate229 value2 = (Class469.Delegate229)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate229>(ref this.delegate229_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate229 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate229 @delegate = this.delegate229_1;
				Class469.Delegate229 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate229 value2 = (Class469.Delegate229)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate229>(ref this.delegate229_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate229 @delegate = this.delegate229_1;
				Class469.Delegate229 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate229 value2 = (Class469.Delegate229)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate229>(ref this.delegate229_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate229 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate229 @delegate = this.delegate229_2;
				Class469.Delegate229 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate229 value2 = (Class469.Delegate229)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate229>(ref this.delegate229_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate229 @delegate = this.delegate229_2;
				Class469.Delegate229 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate229 value2 = (Class469.Delegate229)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate229>(ref this.delegate229_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate229 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate229 @delegate = this.delegate229_3;
				Class469.Delegate229 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate229 value2 = (Class469.Delegate229)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate229>(ref this.delegate229_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate229 @delegate = this.delegate229_3;
				Class469.Delegate229 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate229 value2 = (Class469.Delegate229)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate229>(ref this.delegate229_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class469.Class494 class494_0)
		{
			base.Rows.Add(class494_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class494 method_1(int int_0, int int_1)
		{
			Class469.Class494 @class = (Class469.Class494)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				int_0,
				int_1
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class494 method_2(int int_0)
		{
			return (Class469.Class494)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class469.Class480 @class = (Class469.Class480)base.Clone();
			@class.method_3();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class480();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["idOrder"];
			this.dataColumn_2 = base.Columns["idSchmObj"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("idOrder", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.AutoIncrementSeed = -1L;
			this.dataColumn_0.AutoIncrementStep = -1L;
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.ReadOnly = true;
			this.dataColumn_0.Unique = true;
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_2.AllowDBNull = false;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class494 method_5()
		{
			return (Class469.Class494)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class494(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class494);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate229_1 != null)
			{
				this.delegate229_1(this, new Class469.EventArgs225((Class469.Class494)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate229_0 != null)
			{
				this.delegate229_0(this, new Class469.EventArgs225((Class469.Class494)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate229_3 != null)
			{
				this.delegate229_3(this, new Class469.EventArgs225((Class469.Class494)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate229_2 != null)
			{
				this.delegate229_2(this, new Class469.EventArgs225((Class469.Class494)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_6(Class469.Class494 class494_0)
		{
			base.Rows.Remove(class494_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "tL_OrderSchmObjListDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		[CompilerGenerated]
		private Class469.Delegate229 delegate229_0;

		[CompilerGenerated]
		private Class469.Delegate229 delegate229_1;

		[CompilerGenerated]
		private Class469.Delegate229 delegate229_2;

		[CompilerGenerated]
		private Class469.Delegate229 delegate229_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class481 : TypedTableBase<Class469.Class495>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class481()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "vSchm_ObjList";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class481(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class481(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class495 this[int int_0]
		{
			get
			{
				return (Class469.Class495)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate230 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate230 @delegate = this.delegate230_0;
				Class469.Delegate230 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate230 value2 = (Class469.Delegate230)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate230>(ref this.delegate230_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate230 @delegate = this.delegate230_0;
				Class469.Delegate230 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate230 value2 = (Class469.Delegate230)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate230>(ref this.delegate230_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate230 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate230 @delegate = this.delegate230_1;
				Class469.Delegate230 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate230 value2 = (Class469.Delegate230)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate230>(ref this.delegate230_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate230 @delegate = this.delegate230_1;
				Class469.Delegate230 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate230 value2 = (Class469.Delegate230)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate230>(ref this.delegate230_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate230 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate230 @delegate = this.delegate230_2;
				Class469.Delegate230 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate230 value2 = (Class469.Delegate230)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate230>(ref this.delegate230_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate230 @delegate = this.delegate230_2;
				Class469.Delegate230 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate230 value2 = (Class469.Delegate230)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate230>(ref this.delegate230_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate230 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate230 @delegate = this.delegate230_3;
				Class469.Delegate230 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate230 value2 = (Class469.Delegate230)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate230>(ref this.delegate230_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate230 @delegate = this.delegate230_3;
				Class469.Delegate230 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate230 value2 = (Class469.Delegate230)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate230>(ref this.delegate230_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class469.Class495 class495_0)
		{
			base.Rows.Add(class495_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class495 method_1(int int_0, string string_0, int int_1, string string_1, string string_2, int int_2, bool bool_0, int int_3, bool bool_1)
		{
			Class469.Class495 @class = (Class469.Class495)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				string_0,
				int_1,
				string_1,
				string_2,
				int_2,
				bool_0,
				int_3,
				bool_1
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class495 method_2(int int_0)
		{
			return (Class469.Class495)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class469.Class481 @class = (Class469.Class481)base.Clone();
			@class.method_3();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class481();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["Id"];
			this.dataColumn_1 = base.Columns["Name"];
			this.dataColumn_2 = base.Columns["TypeCodeId"];
			this.dataColumn_3 = base.Columns["typecode"];
			this.dataColumn_4 = base.Columns["typeCodeSocr"];
			this.dataColumn_5 = base.Columns["IdParent"];
			this.dataColumn_6 = base.Columns["OnOff"];
			this.dataColumn_7 = base.Columns["NameP"];
			this.dataColumn_8 = base.Columns["Deleted"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("Id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("Name", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("TypeCodeId", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("typecode", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("typeCodeSocr", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("IdParent", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("OnOff", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("NameP", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.Unique = true;
			this.dataColumn_1.MaxLength = 512;
			this.dataColumn_3.MaxLength = 100;
			this.dataColumn_4.MaxLength = 50;
			this.dataColumn_7.ReadOnly = true;
			this.dataColumn_8.AllowDBNull = false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class495 method_5()
		{
			return (Class469.Class495)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class495(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class495);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate230_1 != null)
			{
				this.delegate230_1(this, new Class469.EventArgs226((Class469.Class495)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate230_0 != null)
			{
				this.delegate230_0(this, new Class469.EventArgs226((Class469.Class495)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate230_3 != null)
			{
				this.delegate230_3(this, new Class469.EventArgs226((Class469.Class495)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate230_2 != null)
			{
				this.delegate230_2(this, new Class469.EventArgs226((Class469.Class495)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_6(Class469.Class495 class495_0)
		{
			base.Rows.Remove(class495_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "vSchm_ObjListDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private DataColumn dataColumn_5;

		private DataColumn dataColumn_6;

		private DataColumn dataColumn_7;

		private DataColumn dataColumn_8;

		[CompilerGenerated]
		private Class469.Delegate230 delegate230_0;

		[CompilerGenerated]
		private Class469.Delegate230 delegate230_1;

		[CompilerGenerated]
		private Class469.Delegate230 delegate230_2;

		[CompilerGenerated]
		private Class469.Delegate230 delegate230_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class482 : TypedTableBase<Class469.Class496>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class482()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "vSchm_TreeCellLine";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class482(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class482(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_2();
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
		[Browsable(false)]
		[DebuggerNonUserCode]
		public int Count
		{
			get
			{
				return base.Rows.Count;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class496 this[int int_0]
		{
			get
			{
				return (Class469.Class496)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate231 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate231 @delegate = this.delegate231_0;
				Class469.Delegate231 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate231 value2 = (Class469.Delegate231)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate231>(ref this.delegate231_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate231 @delegate = this.delegate231_0;
				Class469.Delegate231 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate231 value2 = (Class469.Delegate231)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate231>(ref this.delegate231_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate231 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate231 @delegate = this.delegate231_1;
				Class469.Delegate231 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate231 value2 = (Class469.Delegate231)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate231>(ref this.delegate231_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate231 @delegate = this.delegate231_1;
				Class469.Delegate231 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate231 value2 = (Class469.Delegate231)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate231>(ref this.delegate231_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate231 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate231 @delegate = this.delegate231_2;
				Class469.Delegate231 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate231 value2 = (Class469.Delegate231)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate231>(ref this.delegate231_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate231 @delegate = this.delegate231_2;
				Class469.Delegate231 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate231 value2 = (Class469.Delegate231)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate231>(ref this.delegate231_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate231 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate231 @delegate = this.delegate231_3;
				Class469.Delegate231 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate231 value2 = (Class469.Delegate231)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate231>(ref this.delegate231_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate231 @delegate = this.delegate231_3;
				Class469.Delegate231 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate231 value2 = (Class469.Delegate231)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate231>(ref this.delegate231_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class469.Class496 class496_0)
		{
			base.Rows.Add(class496_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class496 method_1(int int_0, int int_1, int int_2, string string_0, string string_1, string string_2)
		{
			Class469.Class496 @class = (Class469.Class496)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				int_1,
				int_2,
				string_0,
				string_1,
				string_2
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class469.Class482 @class = (Class469.Class482)base.Clone();
			@class.method_2();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class482();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["Id"];
			this.dataColumn_1 = base.Columns["ParentLink"];
			this.dataColumn_2 = base.Columns["TypeCodeId"];
			this.dataColumn_3 = base.Columns["ParentKey"];
			this.dataColumn_4 = base.Columns["Name"];
			this.dataColumn_5 = base.Columns["FullName"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("Id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("ParentLink", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("TypeCodeId", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("ParentKey", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("Name", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("FullName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_3.MaxLength = 50;
			this.dataColumn_4.MaxLength = 512;
			this.dataColumn_5.ReadOnly = true;
			this.dataColumn_5.MaxLength = 565;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class496 method_4()
		{
			return (Class469.Class496)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class496(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class496);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate231_1 != null)
			{
				this.delegate231_1(this, new Class469.EventArgs227((Class469.Class496)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate231_0 != null)
			{
				this.delegate231_0(this, new Class469.EventArgs227((Class469.Class496)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate231_3 != null)
			{
				this.delegate231_3(this, new Class469.EventArgs227((Class469.Class496)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate231_2 != null)
			{
				this.delegate231_2(this, new Class469.EventArgs227((Class469.Class496)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5(Class469.Class496 class496_0)
		{
			base.Rows.Remove(class496_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "vSchm_TreeCellLineDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		private DataColumn dataColumn_5;

		[CompilerGenerated]
		private Class469.Delegate231 delegate231_0;

		[CompilerGenerated]
		private Class469.Delegate231 delegate231_1;

		[CompilerGenerated]
		private Class469.Delegate231 delegate231_2;

		[CompilerGenerated]
		private Class469.Delegate231 delegate231_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class483 : TypedTableBase<Class469.Class497>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class483()
		{
			Class611.H9nE6ZDzTF9kb();
			
			base.TableName = "tSchm_Relation";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class483(DataTable dataTable_0)
		{
			Class611.H9nE6ZDzTF9kb();
			
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
		protected Class483(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
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
		public DataColumn DataColumn_0
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_1
		{
			get
			{
				return this.dataColumn_2;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_2
		{
			get
			{
				return this.dataColumn_3;
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
		public Class469.Class497 this[int int_0]
		{
			get
			{
				return (Class469.Class497)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate232 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate232 @delegate = this.delegate232_0;
				Class469.Delegate232 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate232 value2 = (Class469.Delegate232)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate232>(ref this.delegate232_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate232 @delegate = this.delegate232_0;
				Class469.Delegate232 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate232 value2 = (Class469.Delegate232)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate232>(ref this.delegate232_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate232 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate232 @delegate = this.delegate232_1;
				Class469.Delegate232 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate232 value2 = (Class469.Delegate232)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate232>(ref this.delegate232_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate232 @delegate = this.delegate232_1;
				Class469.Delegate232 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate232 value2 = (Class469.Delegate232)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate232>(ref this.delegate232_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate232 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate232 @delegate = this.delegate232_2;
				Class469.Delegate232 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate232 value2 = (Class469.Delegate232)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate232>(ref this.delegate232_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate232 @delegate = this.delegate232_2;
				Class469.Delegate232 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate232 value2 = (Class469.Delegate232)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate232>(ref this.delegate232_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class469.Delegate232 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class469.Delegate232 @delegate = this.delegate232_3;
				Class469.Delegate232 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate232 value2 = (Class469.Delegate232)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate232>(ref this.delegate232_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class469.Delegate232 @delegate = this.delegate232_3;
				Class469.Delegate232 delegate2;
				do
				{
					delegate2 = @delegate;
					Class469.Delegate232 value2 = (Class469.Delegate232)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class469.Delegate232>(ref this.delegate232_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class469.Class497 class497_0)
		{
			base.Rows.Add(class497_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class497 method_1(int int_0, int int_1, int int_2)
		{
			Class469.Class497 @class = (Class469.Class497)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				int_0,
				int_1,
				int_2
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class497 method_2(int int_0)
		{
			return (Class469.Class497)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class469.Class483 @class = (Class469.Class483)base.Clone();
			@class.method_3();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class469.Class483();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["SourceObj"];
			this.dataColumn_2 = base.Columns["DestObj"];
			this.dataColumn_3 = base.Columns["Edge"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("SourceObj", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("DestObj", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("Edge", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.AutoIncrementSeed = -1L;
			this.dataColumn_0.AutoIncrementStep = -1L;
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.ReadOnly = true;
			this.dataColumn_0.Unique = true;
			this.dataColumn_1.AllowDBNull = false;
			this.dataColumn_2.AllowDBNull = false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class497 method_5()
		{
			return (Class469.Class497)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class469.Class497(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class469.Class497);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate232_1 != null)
			{
				this.delegate232_1(this, new Class469.EventArgs228((Class469.Class497)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate232_0 != null)
			{
				this.delegate232_0(this, new Class469.EventArgs228((Class469.Class497)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate232_3 != null)
			{
				this.delegate232_3(this, new Class469.EventArgs228((Class469.Class497)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate232_2 != null)
			{
				this.delegate232_2(this, new Class469.EventArgs228((Class469.Class497)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_6(Class469.Class497 class497_0)
		{
			base.Rows.Remove(class497_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class469 @class = new Class469();
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
			xmlSchemaAttribute.FixedValue = @class.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "tSchm_RelationDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = @class.GetSchemaSerializable();
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

		private DataColumn dataColumn_0;

		private DataColumn dataColumn_1;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		[CompilerGenerated]
		private Class469.Delegate232 delegate232_0;

		[CompilerGenerated]
		private Class469.Delegate232 delegate232_1;

		[CompilerGenerated]
		private Class469.Delegate232 delegate232_2;

		[CompilerGenerated]
		private Class469.Delegate232 delegate232_3;
	}

	public class Class484 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class484(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class470_0 = (Class469.Class470)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id
		{
			get
			{
				return (int)base[this.class470_0.idColumn];
			}
			set
			{
				base[this.class470_0.idColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int num
		{
			get
			{
				return (int)base[this.class470_0.DataColumn_0];
			}
			set
			{
				base[this.class470_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateBegin
		{
			get
			{
				return (DateTime)base[this.class470_0.DataColumn_1];
			}
			set
			{
				base[this.class470_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateEnd
		{
			get
			{
				return (DateTime)base[this.class470_0.DataColumn_2];
			}
			set
			{
				base[this.class470_0.DataColumn_2] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idSR
		{
			get
			{
				return (int)base[this.class470_0.DataColumn_3];
			}
			set
			{
				base[this.class470_0.DataColumn_3] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string instruction
		{
			get
			{
				return (string)base[this.class470_0.DataColumn_4];
			}
			set
			{
				base[this.class470_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int headworker
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class470_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'headworker' in table 'tJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class470_0.DataColumn_5] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int acceptworker
		{
			get
			{
				return (int)base[this.class470_0.DataColumn_6];
			}
			set
			{
				base[this.class470_0.DataColumn_6] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int watchWorker
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class470_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'watchWorker' in table 'tJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class470_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int makerWorker
		{
			get
			{
				return (int)base[this.class470_0.DataColumn_8];
			}
			set
			{
				base[this.class470_0.DataColumn_8] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string otherInstruction
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class470_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'otherInstruction' in table 'tJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class470_0.DataColumn_9] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime dateOutput
		{
			get
			{
				return (DateTime)base[this.class470_0.DataColumn_10];
			}
			set
			{
				base[this.class470_0.DataColumn_10] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int outputWorker
		{
			get
			{
				return (int)base[this.class470_0.DataColumn_11];
			}
			set
			{
				base[this.class470_0.DataColumn_11] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool registered
		{
			get
			{
				return (bool)base[this.class470_0.DataColumn_12];
			}
			set
			{
				base[this.class470_0.DataColumn_12] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime dateClose
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class470_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateClose' in table 'tJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class470_0.DataColumn_13] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int closeWorker
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class470_0.DataColumn_14];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'closeWorker' in table 'tJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class470_0.DataColumn_14] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int extWorker
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class470_0.DataColumn_15];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'extWorker' in table 'tJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class470_0.DataColumn_15] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime dateExt
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class470_0.DataColumn_16];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateExt' in table 'tJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class470_0.DataColumn_16] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime dateEndExt
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class470_0.DataColumn_17];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateEndExt' in table 'tJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class470_0.DataColumn_17] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idDivision
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class470_0.idDivisionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idDivision' in table 'tJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class470_0.idDivisionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class470_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class470_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_2()
		{
			return base.IsNull(this.class470_0.DataColumn_7);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class470_0.DataColumn_7] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_4()
		{
			return base.IsNull(this.class470_0.DataColumn_9);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5()
		{
			base[this.class470_0.DataColumn_9] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class470_0.DataColumn_13);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class470_0.DataColumn_13] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool GugHuMoKoNI()
		{
			return base.IsNull(this.class470_0.DataColumn_14);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_8()
		{
			base[this.class470_0.DataColumn_14] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_9()
		{
			return base.IsNull(this.class470_0.DataColumn_15);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_10()
		{
			base[this.class470_0.DataColumn_15] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_11()
		{
			return base.IsNull(this.class470_0.DataColumn_16);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_12()
		{
			base[this.class470_0.DataColumn_16] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_13()
		{
			return base.IsNull(this.class470_0.DataColumn_17);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_14()
		{
			base[this.class470_0.DataColumn_17] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_15()
		{
			return base.IsNull(this.class470_0.idDivisionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_16()
		{
			base[this.class470_0.idDivisionColumn] = Convert.DBNull;
		}

		private Class469.Class470 class470_0;
	}

	public class Class485 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class485(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class471_0 = (Class469.Class471)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id
		{
			get
			{
				return (int)base[this.class471_0.idColumn];
			}
			set
			{
				base[this.class471_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int num
		{
			get
			{
				return (int)base[this.class471_0.DataColumn_0];
			}
			set
			{
				base[this.class471_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateBegin
		{
			get
			{
				return (DateTime)base[this.class471_0.DataColumn_1];
			}
			set
			{
				base[this.class471_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateEnd
		{
			get
			{
				return (DateTime)base[this.class471_0.DataColumn_2];
			}
			set
			{
				base[this.class471_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idSR
		{
			get
			{
				return (int)base[this.class471_0.DataColumn_3];
			}
			set
			{
				base[this.class471_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal srNum
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class471_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'srNum' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string srName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class471_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'srName' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string instruction
		{
			get
			{
				return (string)base[this.class471_0.DataColumn_6];
			}
			set
			{
				base[this.class471_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int headworker
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class471_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'headworker' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string headFio
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class471_0.shxHniFuvSD];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'headFio' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.shxHniFuvSD] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int acceptworker
		{
			get
			{
				return (int)base[this.class471_0.DataColumn_8];
			}
			set
			{
				base[this.class471_0.DataColumn_8] = value;
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
					result = (string)base[this.class471_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'acceptFIO' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_9] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int watchWorker
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class471_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'watchWorker' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_10] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string watchFIO
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class471_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'watchFIO' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_11] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int makerWorker
		{
			get
			{
				return (int)base[this.class471_0.DataColumn_12];
			}
			set
			{
				base[this.class471_0.DataColumn_12] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string makerFIO
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class471_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'makerFIO' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_13] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string otherInstruction
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class471_0.DataColumn_14];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'otherInstruction' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_14] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateOutput
		{
			get
			{
				return (DateTime)base[this.class471_0.DataColumn_15];
			}
			set
			{
				base[this.class471_0.DataColumn_15] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int outputWorker
		{
			get
			{
				return (int)base[this.class471_0.DataColumn_16];
			}
			set
			{
				base[this.class471_0.DataColumn_16] = value;
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
					result = (string)base[this.class471_0.DataColumn_17];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'outputFIO' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_17] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool registered
		{
			get
			{
				return (bool)base[this.class471_0.DataColumn_18];
			}
			set
			{
				base[this.class471_0.DataColumn_18] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateClose
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class471_0.DataColumn_19];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateClose' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_19] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int closeWorker
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class471_0.DataColumn_20];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'closeWorker' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_20] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string closeFIO
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class471_0.DataColumn_21];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'closeFIO' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_21] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime beginRes
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class471_0.DataColumn_22];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'beginRes' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_22] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime EndRes
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class471_0.DataColumn_23];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'EndRes' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_23] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int resWorkerId
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class471_0.DataColumn_24];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'resWorkerId' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_24] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string resWorker
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class471_0.DataColumn_25];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'resWorker' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_25] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string OutputMaker
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class471_0.DataColumn_26];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'OutputMaker' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_26] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Resolution
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class471_0.DataColumn_27];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Resolution' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_27] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int extWorker
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class471_0.DataColumn_28];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'extWorker' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_28] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string extFio
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class471_0.DataColumn_29];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'extFio' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_29] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DateEndExt
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class471_0.DataColumn_30];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateEndExt' in table 'vJ_Order' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class471_0.DataColumn_30] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class471_0.DataColumn_4);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class471_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_2()
		{
			return base.IsNull(this.class471_0.DataColumn_5);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class471_0.DataColumn_5] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class471_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class471_0.DataColumn_7] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class471_0.shxHniFuvSD);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class471_0.shxHniFuvSD] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class471_0.DataColumn_9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class471_0.DataColumn_9] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class471_0.DataColumn_10);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class471_0.DataColumn_10] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_12()
		{
			return base.IsNull(this.class471_0.DataColumn_11);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_13()
		{
			base[this.class471_0.DataColumn_11] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_14()
		{
			return base.IsNull(this.class471_0.DataColumn_13);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class471_0.DataColumn_13] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_16()
		{
			return base.IsNull(this.class471_0.DataColumn_14);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_17()
		{
			base[this.class471_0.DataColumn_14] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_18()
		{
			return base.IsNull(this.class471_0.DataColumn_17);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_19()
		{
			base[this.class471_0.DataColumn_17] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_20()
		{
			return base.IsNull(this.class471_0.DataColumn_19);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_21()
		{
			base[this.class471_0.DataColumn_19] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_22()
		{
			return base.IsNull(this.class471_0.DataColumn_20);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_23()
		{
			base[this.class471_0.DataColumn_20] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_24()
		{
			return base.IsNull(this.class471_0.DataColumn_21);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_25()
		{
			base[this.class471_0.DataColumn_21] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_26()
		{
			return base.IsNull(this.class471_0.DataColumn_22);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_27()
		{
			base[this.class471_0.DataColumn_22] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_28()
		{
			return base.IsNull(this.class471_0.DataColumn_23);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_29()
		{
			base[this.class471_0.DataColumn_23] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_30()
		{
			return base.IsNull(this.class471_0.DataColumn_24);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_31()
		{
			base[this.class471_0.DataColumn_24] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_32()
		{
			return base.IsNull(this.class471_0.DataColumn_25);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_33()
		{
			base[this.class471_0.DataColumn_25] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_34()
		{
			return base.IsNull(this.class471_0.DataColumn_26);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_35()
		{
			base[this.class471_0.DataColumn_26] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_36()
		{
			return base.IsNull(this.class471_0.DataColumn_27);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_37()
		{
			base[this.class471_0.DataColumn_27] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_38()
		{
			return base.IsNull(this.class471_0.DataColumn_28);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_39()
		{
			base[this.class471_0.DataColumn_28] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_40()
		{
			return base.IsNull(this.class471_0.DataColumn_29);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_41()
		{
			base[this.class471_0.DataColumn_29] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_42()
		{
			return base.IsNull(this.class471_0.DataColumn_30);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_43()
		{
			base[this.class471_0.DataColumn_30] = Convert.DBNull;
		}

		private Class469.Class471 class471_0;
	}

	public class Class486 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class486(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class472_0 = (Class469.Class472)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Id
		{
			get
			{
				return (int)base[this.class472_0.DataColumn_0];
			}
			set
			{
				base[this.class472_0.DataColumn_0] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Name
		{
			get
			{
				return (string)base[this.class472_0.DataColumn_1];
			}
			set
			{
				base[this.class472_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SocrName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class472_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SocrName' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class472_0.DataColumn_2] = value;
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
					result = (decimal)base[this.class472_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Value' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class472_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Comment
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class472_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Comment' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class472_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int ParentId
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class472_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentId' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class472_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ParentKey
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class472_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKey' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class472_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public byte[] OtherId
		{
			get
			{
				byte[] result;
				try
				{
					result = (byte[])base[this.class472_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'OtherId' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class472_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsGroup
		{
			get
			{
				return (bool)base[this.class472_0.DataColumn_8];
			}
			set
			{
				base[this.class472_0.DataColumn_8] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Deleted
		{
			get
			{
				return (bool)base[this.class472_0.DataColumn_9];
			}
			set
			{
				base[this.class472_0.DataColumn_9] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class472_0.DataColumn_2);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class472_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_2()
		{
			return base.IsNull(this.class472_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class472_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class472_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class472_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class472_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class472_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class472_0.DataColumn_6);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_9()
		{
			base[this.class472_0.DataColumn_6] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class472_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class472_0.DataColumn_7] = Convert.DBNull;
		}

		private Class469.Class472 class472_0;
	}

	public class Class487 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class487(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class473_0 = (Class469.Class473)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id
		{
			get
			{
				return (int)base[this.class473_0.idColumn];
			}
			set
			{
				base[this.class473_0.idColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string FIO
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class473_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'FIO' in table 'vR_Worker' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class473_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime DateBegin
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class473_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateBegin' in table 'vR_Worker' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class473_0.DataColumn_1] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DateEnd
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class473_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateEnd' in table 'vR_Worker' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class473_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public short GroupElectrical
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class473_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'GroupElectrical' in table 'vR_Worker' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class473_0.DataColumn_3] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class473_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class473_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class473_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class473_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_4()
		{
			return base.IsNull(this.class473_0.DataColumn_2);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5()
		{
			base[this.class473_0.DataColumn_2] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class473_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class473_0.DataColumn_3] = Convert.DBNull;
		}

		private Class469.Class473 class473_0;
	}

	public class Class488 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class488(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class474_0 = (Class469.Class474)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id
		{
			get
			{
				return (int)base[this.class474_0.idColumn];
			}
			set
			{
				base[this.class474_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string FIO
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class474_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'FIO' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class474_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime DateBegin
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class474_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateBegin' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class474_0.DataColumn_1] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DateEnd
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class474_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateEnd' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class474_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idGroup
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class474_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idGroup' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class474_0.DataColumn_3] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string WorkerGroup
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class474_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'WorkerGroup' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class474_0.DataColumn_4] = value;
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
					result = (string)base[this.class474_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKey' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class474_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Description
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class474_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Description' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class474_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idDescription
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class474_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idDescription' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class474_0.DataColumn_7] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short GroupElectrical
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class474_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'GroupElectrical' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class474_0.DataColumn_8] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class474_0.DataColumn_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class474_0.DataColumn_0] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_2()
		{
			return base.IsNull(this.class474_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class474_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class474_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class474_0.DataColumn_2] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class474_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class474_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_8()
		{
			return base.IsNull(this.class474_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class474_0.DataColumn_4] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_10()
		{
			return base.IsNull(this.class474_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class474_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class474_0.DataColumn_6);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class474_0.DataColumn_6] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_14()
		{
			return base.IsNull(this.class474_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class474_0.DataColumn_7] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_16()
		{
			return base.IsNull(this.class474_0.DataColumn_8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_17()
		{
			base[this.class474_0.DataColumn_8] = Convert.DBNull;
		}

		private Class469.Class474 class474_0;
	}

	public class Class489 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class489(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class475_0 = (Class469.Class475)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id
		{
			get
			{
				return (int)base[this.class475_0.idColumn];
			}
			set
			{
				base[this.class475_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idOrder
		{
			get
			{
				return (int)base[this.class475_0.DataColumn_0];
			}
			set
			{
				base[this.class475_0.DataColumn_0] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idWorker
		{
			get
			{
				return (int)base[this.class475_0.idWorkerColumn];
			}
			set
			{
				base[this.class475_0.idWorkerColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idJobTitle
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class475_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idJobTitle' in table 'tJ_OrderBrigade' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class475_0.DataColumn_1] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool isUnderstudy
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class475_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isUnderstudy' in table 'tJ_OrderBrigade' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class475_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class475_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class475_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_2()
		{
			return base.IsNull(this.class475_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class475_0.DataColumn_2] = Convert.DBNull;
		}

		private Class469.Class475 class475_0;
	}

	public class Class490 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class490(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class476_0 = (Class469.Class476)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[this.class476_0.idColumn];
			}
			set
			{
				base[this.class476_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime date
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class476_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'date' in table 'tj_DailyTourReport' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class476_0.DataColumn_0] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int was
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class476_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'was' in table 'tj_DailyTourReport' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class476_0.DataColumn_1] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int disp1
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class476_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'disp1' in table 'tj_DailyTourReport' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class476_0.DataColumn_2] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int disp2
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class476_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'disp2' in table 'tj_DailyTourReport' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class476_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int disp3
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class476_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'disp3' in table 'tj_DailyTourReport' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class476_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class476_0.DataColumn_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class476_0.DataColumn_0] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_2()
		{
			return base.IsNull(this.class476_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class476_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_4()
		{
			return base.IsNull(this.class476_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class476_0.DataColumn_2] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class476_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class476_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_8()
		{
			return base.IsNull(this.class476_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class476_0.DataColumn_4] = Convert.DBNull;
		}

		private Class469.Class476 class476_0;
	}

	public class Class491 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class491(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class477_0 = (Class469.Class477)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[this.class477_0.idColumn];
			}
			set
			{
				base[this.class477_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idOrder
		{
			get
			{
				return (int)base[this.class477_0.DataColumn_0];
			}
			set
			{
				base[this.class477_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NameObj
		{
			get
			{
				return (string)base[this.class477_0.DataColumn_1];
			}
			set
			{
				base[this.class477_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Instruction
		{
			get
			{
				return (string)base[this.class477_0.DataColumn_2];
			}
			set
			{
				base[this.class477_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int rec_num
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class477_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'rec_num' in table 'tJ_OrderInstruction' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class477_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class477_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class477_0.DataColumn_3] = Convert.DBNull;
		}

		private Class469.Class477 class477_0;
	}

	public class Class492 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class492(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class478_0 = (Class469.Class478)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id
		{
			get
			{
				return (int)base[this.class478_0.idColumn];
			}
			set
			{
				base[this.class478_0.idColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idOrder
		{
			get
			{
				return (int)base[this.class478_0.DataColumn_0];
			}
			set
			{
				base[this.class478_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idWorker
		{
			get
			{
				return (int)base[this.class478_0.idWorkerColumn];
			}
			set
			{
				base[this.class478_0.idWorkerColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime DateBegin
		{
			get
			{
				return (DateTime)base[this.class478_0.DataColumn_1];
			}
			set
			{
				base[this.class478_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime DateEnd
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class478_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateEnd' in table 'tJ_OrderResolution' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class478_0.DataColumn_2] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class478_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class478_0.DataColumn_2] = Convert.DBNull;
		}

		private Class469.Class478 class478_0;
	}

	public class Class493 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class493(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class479_0 = (Class469.Class479)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[this.class479_0.idColumn];
			}
			set
			{
				base[this.class479_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int num
		{
			get
			{
				return (int)base[this.class479_0.DataColumn_0];
			}
			set
			{
				base[this.class479_0.DataColumn_0] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int srNum
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class479_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'srNum' in table 'vJ_OrderEvents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class479_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string instruction
		{
			get
			{
				return (string)base[this.class479_0.DataColumn_2];
			}
			set
			{
				base[this.class479_0.DataColumn_2] = value;
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
					result = (string)base[this.class479_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'acceptFIO' in table 'vJ_OrderEvents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class479_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string makerFio
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class479_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'makerFio' in table 'vJ_OrderEvents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class479_0.DataColumn_4] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Evnt
		{
			get
			{
				return (string)base[this.class479_0.DataColumn_5];
			}
			set
			{
				base[this.class479_0.DataColumn_5] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime EvntDate
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class479_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'EvntDate' in table 'vJ_OrderEvents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class479_0.DataColumn_6] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int closed
		{
			get
			{
				return (int)base[this.class479_0.DataColumn_7];
			}
			set
			{
				base[this.class479_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string disp
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class479_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'disp' in table 'vJ_OrderEvents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class479_0.DataColumn_8] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class479_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class479_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class479_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class479_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class479_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class479_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class479_0.DataColumn_6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class479_0.DataColumn_6] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class479_0.DataColumn_8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class479_0.DataColumn_8] = Convert.DBNull;
		}

		private Class469.Class479 class479_0;
	}

	public class Class494 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class494(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class480_0 = (Class469.Class480)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id
		{
			get
			{
				return (int)base[this.class480_0.idColumn];
			}
			set
			{
				base[this.class480_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idOrder
		{
			get
			{
				return (int)base[this.class480_0.DataColumn_0];
			}
			set
			{
				base[this.class480_0.DataColumn_0] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idSchmObj
		{
			get
			{
				return (int)base[this.class480_0.idSchmObjColumn];
			}
			set
			{
				base[this.class480_0.idSchmObjColumn] = value;
			}
		}

		private Class469.Class480 class480_0;
	}

	public class Class495 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class495(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class481_0 = (Class469.Class481)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Id
		{
			get
			{
				return (int)base[this.class481_0.DataColumn_0];
			}
			set
			{
				base[this.class481_0.DataColumn_0] = value;
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
					result = (string)base[this.class481_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Name' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class481_0.DataColumn_1] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int TypeCodeId
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class481_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TypeCodeId' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class481_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string typecode
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class481_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typecode' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class481_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string typeCodeSocr
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class481_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typeCodeSocr' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class481_0.DataColumn_4] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int IdParent
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class481_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'IdParent' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class481_0.DataColumn_5] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool OnOff
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class481_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'OnOff' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class481_0.DataColumn_6] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int NameP
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class481_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NameP' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class481_0.DataColumn_7] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool Deleted
		{
			get
			{
				return (bool)base[this.class481_0.DataColumn_8];
			}
			set
			{
				base[this.class481_0.DataColumn_8] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class481_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class481_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class481_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class481_0.DataColumn_2] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class481_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5()
		{
			base[this.class481_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class481_0.DataColumn_4);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class481_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class481_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class481_0.DataColumn_5] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_10()
		{
			return base.IsNull(this.class481_0.DataColumn_6);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_11()
		{
			base[this.class481_0.DataColumn_6] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class481_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_13()
		{
			base[this.class481_0.DataColumn_7] = Convert.DBNull;
		}

		private Class469.Class481 class481_0;
	}

	public class Class496 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class496(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class482_0 = (Class469.Class482)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Id
		{
			get
			{
				return (int)base[this.class482_0.DataColumn_0];
			}
			set
			{
				base[this.class482_0.DataColumn_0] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int ParentLink
		{
			get
			{
				return (int)base[this.class482_0.DataColumn_1];
			}
			set
			{
				base[this.class482_0.DataColumn_1] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int TypeCodeId
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class482_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TypeCodeId' in table 'vSchm_TreeCellLine' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class482_0.DataColumn_2] = value;
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
					result = (string)base[this.class482_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKey' in table 'vSchm_TreeCellLine' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class482_0.DataColumn_3] = value;
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
					result = (string)base[this.class482_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Name' in table 'vSchm_TreeCellLine' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class482_0.DataColumn_4] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string FullName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class482_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'FullName' in table 'vSchm_TreeCellLine' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class482_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class482_0.DataColumn_2);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class482_0.DataColumn_2] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class482_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class482_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class482_0.DataColumn_4);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5()
		{
			base[this.class482_0.DataColumn_4] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class482_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class482_0.DataColumn_5] = Convert.DBNull;
		}

		private Class469.Class482 class482_0;
	}

	public class Class497 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class497(DataRowBuilder dataRowBuilder_0)
		{
			Class611.H9nE6ZDzTF9kb();
			base..ctor(dataRowBuilder_0);
			this.class483_0 = (Class469.Class483)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[this.class483_0.idColumn];
			}
			set
			{
				base[this.class483_0.idColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int SourceObj
		{
			get
			{
				return (int)base[this.class483_0.DataColumn_0];
			}
			set
			{
				base[this.class483_0.DataColumn_0] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int DestObj
		{
			get
			{
				return (int)base[this.class483_0.DataColumn_1];
			}
			set
			{
				base[this.class483_0.DataColumn_1] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Edge
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class483_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Edge' in table 'tSchm_Relation' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class483_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class483_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class483_0.DataColumn_2] = Convert.DBNull;
		}

		private Class469.Class483 class483_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs215 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs215(Class469.Class484 class484_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class484_0 = class484_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class484 Row
		{
			get
			{
				return this.class484_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class484 class484_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs216 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs216(Class469.Class485 class485_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class485_0 = class485_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class485 Row
		{
			get
			{
				return this.class485_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class485 class485_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs217 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs217(Class469.Class486 class486_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class486_0 = class486_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class486 Row
		{
			get
			{
				return this.class486_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class486 class486_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs218 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs218(Class469.Class487 class487_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class487_0 = class487_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class487 Row
		{
			get
			{
				return this.class487_0;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class487 class487_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs219 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs219(Class469.Class488 class488_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class488_0 = class488_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class488 Row
		{
			get
			{
				return this.class488_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class488 class488_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs220 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs220(Class469.Class489 class489_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class489_0 = class489_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class489 Row
		{
			get
			{
				return this.class489_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class489 class489_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs221 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs221(Class469.Class490 class490_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class490_0 = class490_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class490 Row
		{
			get
			{
				return this.class490_0;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class490 class490_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs222 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs222(Class469.Class491 class491_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class491_0 = class491_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class491 Row
		{
			get
			{
				return this.class491_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class491 class491_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs223 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs223(Class469.Class492 class492_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class492_0 = class492_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class492 Row
		{
			get
			{
				return this.class492_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class492 class492_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs224 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs224(Class469.Class493 class493_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class493_0 = class493_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class493 Row
		{
			get
			{
				return this.class493_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class493 class493_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs225 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs225(Class469.Class494 class494_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class494_0 = class494_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class494 Row
		{
			get
			{
				return this.class494_0;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class494 class494_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs226 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs226(Class469.Class495 class495_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class495_0 = class495_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class495 Row
		{
			get
			{
				return this.class495_0;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class495 class495_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs227 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs227(Class469.Class496 class496_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class496_0 = class496_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class469.Class496 Row
		{
			get
			{
				return this.class496_0;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class496 class496_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs228 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs228(Class469.Class497 class497_1, DataRowAction dataRowAction_1)
		{
			Class611.H9nE6ZDzTF9kb();
			
			this.class497_0 = class497_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class469.Class497 Row
		{
			get
			{
				return this.class497_0;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataRowAction DataRowAction_0
		{
			get
			{
				return this.dataRowAction_0;
			}
		}

		private Class469.Class497 class497_0;

		private DataRowAction dataRowAction_0;
	}
}
