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
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("DataSetDamage")]
[HelpKeyword("vs.data.DataSet")]
[ToolboxItem(true)]
[Serializable]
internal class Class171 : DataSet
{
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class171()
	{
		//
		this.schemaSerializationMode_0 = SchemaSerializationMode.IncludeSchema;
		
		base.BeginInit();
		this.method_2();
		CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_28);
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		base.EndInit();
		this.method_29();
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	protected Class171(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
	{
		//
		this.schemaSerializationMode_0 = SchemaSerializationMode.IncludeSchema;
		//base..ctor(serializationInfo_0, streamingContext_0, false);
		if (base.IsBinarySerialized(serializationInfo_0, streamingContext_0))
		{
			this.method_1(false);
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_28);
			this.DataTableCollection_0.CollectionChanged += value;
			this.DataRelationCollection_0.CollectionChanged += value;
			if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == SchemaSerializationMode.ExcludeSchema)
			{
				this.method_29();
			}
			return;
		}
		string s = (string)serializationInfo_0.GetValue("XmlSchema", typeof(string));
		if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["tJ_Damage"] != null)
			{
				base.Tables.Add(new Class171.Class172(dataSet.Tables["tJ_Damage"]));
			}
			if (dataSet.Tables["tMapObj"] != null)
			{
				base.Tables.Add(new Class171.Class173(dataSet.Tables["tMapObj"]));
			}
			if (dataSet.Tables["tJ_DamageLV"] != null)
			{
				base.Tables.Add(new Class171.Class174(dataSet.Tables["tJ_DamageLV"]));
			}
			if (dataSet.Tables["vWorkerGroup"] != null)
			{
				base.Tables.Add(new Class171.Class175(dataSet.Tables["vWorkerGroup"]));
			}
			if (dataSet.Tables["tJ_DamageOn"] != null)
			{
				base.Tables.Add(new Class171.Class176(dataSet.Tables["tJ_DamageOn"]));
			}
			if (dataSet.Tables["ReportDailyLV"] != null)
			{
				base.Tables.Add(new Class171.Class177(dataSet.Tables["ReportDailyLV"]));
			}
			if (dataSet.Tables["tJ_Temperature"] != null)
			{
				base.Tables.Add(new Class171.Class178(dataSet.Tables["tJ_Temperature"]));
			}
			if (dataSet.Tables["vJ_Temperature"] != null)
			{
				base.Tables.Add(new Class171.Class179(dataSet.Tables["vJ_Temperature"]));
			}
			if (dataSet.Tables["tReportIterruptLV"] != null)
			{
				base.Tables.Add(new Class171.Class180(dataSet.Tables["tReportIterruptLV"]));
			}
			if (dataSet.Tables["ReportDailyDefect"] != null)
			{
				base.Tables.Add(new Class171.Class181(dataSet.Tables["ReportDailyDefect"]));
			}
			if (dataSet.Tables["vJ_Damage"] != null)
			{
				base.Tables.Add(new Class171.Class182(dataSet.Tables["vJ_Damage"]));
			}
			if (dataSet.Tables["ReportDailyHV"] != null)
			{
				base.Tables.Add(new Class171.Class183(dataSet.Tables["ReportDailyHV"]));
			}
			if (dataSet.Tables["tJ_DamageCharacter"] != null)
			{
				base.Tables.Add(new Class171.tJ_DamageCharacterDataTable(dataSet.Tables["tJ_DamageCharacter"]));
			}
			if (dataSet.Tables["tJ_DamageActDetection"] != null)
			{
				base.Tables.Add(new Class171.Class185(dataSet.Tables["tJ_DamageActDetection"]));
			}
			if (dataSet.Tables["table23"] != null)
			{
				base.Tables.Add(new Class171.Class186(dataSet.Tables["table23"]));
			}
			if (dataSet.Tables["table31"] != null)
			{
				base.Tables.Add(new Class171.Class187(dataSet.Tables["table31"]));
			}
			if (dataSet.Tables["table4"] != null)
			{
				base.Tables.Add(new Class171.Class188(dataSet.Tables["table4"]));
			}
			if (dataSet.Tables["tJ_DamageHV"] != null)
			{
				base.Tables.Add(new Class171.Class189(dataSet.Tables["tJ_DamageHV"]));
			}
			if (dataSet.Tables["tReportDetectionCrash"] != null)
			{
				base.Tables.Add(new Class171.Class190(dataSet.Tables["tReportDetectionCrash"]));
			}
			if (dataSet.Tables["tReportDetectionReasonCrash"] != null)
			{
				base.Tables.Add(new Class171.tReportDetectionReasonCrashDataTable(dataSet.Tables["tReportDetectionReasonCrash"]));
			}
			if (dataSet.Tables["tReportDetectionNetReg"] != null)
			{
				base.Tables.Add(new Class171.Class192(dataSet.Tables["tReportDetectionNetReg"]));
			}
			if (dataSet.Tables["tReportDetectionNoAdmissKWT"] != null)
			{
				base.Tables.Add(new Class171.Class193(dataSet.Tables["tReportDetectionNoAdmissKWT"]));
			}
			if (dataSet.Tables["tSettings"] != null)
			{
				base.Tables.Add(new Class171.tSettingsDataTable(dataSet.Tables["tSettings"]));
			}
			if (dataSet.Tables["Report81"] != null)
			{
				base.Tables.Add(new Class171.Class195(dataSet.Tables["Report81"]));
			}
			if (dataSet.Tables["ReportAccidents"] != null)
			{
				base.Tables.Add(new Class171.ReportAccidentsDataTable(dataSet.Tables["ReportAccidents"]));
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
			this.method_29();
		}
		base.GetSerializationData(serializationInfo_0, streamingContext_0);
		CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.method_28);
		base.Tables.CollectionChanged += value2;
		this.DataRelationCollection_0.CollectionChanged += value2;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Class171.Class172 tJ_Damage
	{
		get
		{
			return this.class172_0;
		}
	}

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Class171.Class173 tMapObj
	{
		get
		{
			return this.class173_0;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public Class171.Class174 tJ_DamageLV
	{
		get
		{
			return this.class174_0;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public Class171.Class175 vWorkerGroup
	{
		get
		{
			return this.class175_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class171.Class176 tJ_DamageOn
	{
		get
		{
			return this.class176_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class171.Class177 ReportDailyLV
	{
		get
		{
			return this.class177_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class171.Class178 tJ_Temperature
	{
		get
		{
			return this.class178_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class171.Class179 vJ_Temperature
	{
		get
		{
			return this.class179_0;
		}
	}

	[Browsable(false)]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class171.Class180 tReportIterruptLV
	{
		get
		{
			return this.class180_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class171.Class181 ReportDailyDefect
	{
		get
		{
			return this.class181_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class171.Class182 vJ_Damage
	{
		get
		{
			return this.class182_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class171.Class183 ReportDailyHV
	{
		get
		{
			return this.class183_0;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[Browsable(false)]
	[DebuggerNonUserCode]
	public Class171.tJ_DamageCharacterDataTable tJ_DamageCharacter
	{
		get
		{
			return this.DsrClxMliil;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class171.Class185 tJ_DamageActDetection
	{
		get
		{
			return this.class185_0;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class171.Class186 table23
	{
		get
		{
			return this.class186_0;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	public Class171.Class187 table31
	{
		get
		{
			return this.class187_0;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class171.Class188 table4
	{
		get
		{
			return this.class188_0;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class171.Class189 tJ_DamageHV
	{
		get
		{
			return this.class189_0;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[Browsable(false)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class171.Class190 tReportDetectionCrash
	{
		get
		{
			return this.class190_0;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public Class171.tReportDetectionReasonCrashDataTable tReportDetectionReasonCrash
	{
		get
		{
			return this.class191_0;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[Browsable(false)]
	public Class171.Class192 tReportDetectionNetReg
	{
		get
		{
			return this.class192_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class171.Class193 tReportDetectionNoAdmissKWT
	{
		get
		{
			return this.class193_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class171.tSettingsDataTable tSettings
	{
		get
		{
			return this.class194_0;
		}
	}

	[Browsable(false)]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public Class171.Class195 Report81
	{
		get
		{
			return this.class195_0;
		}
	}

	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public Class171.ReportAccidentsDataTable ReportAccidents
	{
		get
		{
			return this.class196_0;
		}
	}

	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[DebuggerNonUserCode]
	public DataTableCollection DataTableCollection_0
	{
		get
		{
			return base.Tables;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
		Class171 @class = (Class171)base.Clone();
		@class.method_0();
		@class.method_29();
		@class.SchemaSerializationMode = this.SchemaSerializationMode;
		return @class;
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
			if (dataSet.Tables["tJ_Damage"] != null)
			{
				base.Tables.Add(new Class171.Class172(dataSet.Tables["tJ_Damage"]));
			}
			if (dataSet.Tables["tMapObj"] != null)
			{
				base.Tables.Add(new Class171.Class173(dataSet.Tables["tMapObj"]));
			}
			if (dataSet.Tables["tJ_DamageLV"] != null)
			{
				base.Tables.Add(new Class171.Class174(dataSet.Tables["tJ_DamageLV"]));
			}
			if (dataSet.Tables["vWorkerGroup"] != null)
			{
				base.Tables.Add(new Class171.Class175(dataSet.Tables["vWorkerGroup"]));
			}
			if (dataSet.Tables["tJ_DamageOn"] != null)
			{
				base.Tables.Add(new Class171.Class176(dataSet.Tables["tJ_DamageOn"]));
			}
			if (dataSet.Tables["ReportDailyLV"] != null)
			{
				base.Tables.Add(new Class171.Class177(dataSet.Tables["ReportDailyLV"]));
			}
			if (dataSet.Tables["tJ_Temperature"] != null)
			{
				base.Tables.Add(new Class171.Class178(dataSet.Tables["tJ_Temperature"]));
			}
			if (dataSet.Tables["vJ_Temperature"] != null)
			{
				base.Tables.Add(new Class171.Class179(dataSet.Tables["vJ_Temperature"]));
			}
			if (dataSet.Tables["tReportIterruptLV"] != null)
			{
				base.Tables.Add(new Class171.Class180(dataSet.Tables["tReportIterruptLV"]));
			}
			if (dataSet.Tables["ReportDailyDefect"] != null)
			{
				base.Tables.Add(new Class171.Class181(dataSet.Tables["ReportDailyDefect"]));
			}
			if (dataSet.Tables["vJ_Damage"] != null)
			{
				base.Tables.Add(new Class171.Class182(dataSet.Tables["vJ_Damage"]));
			}
			if (dataSet.Tables["ReportDailyHV"] != null)
			{
				base.Tables.Add(new Class171.Class183(dataSet.Tables["ReportDailyHV"]));
			}
			if (dataSet.Tables["tJ_DamageCharacter"] != null)
			{
				base.Tables.Add(new Class171.tJ_DamageCharacterDataTable(dataSet.Tables["tJ_DamageCharacter"]));
			}
			if (dataSet.Tables["tJ_DamageActDetection"] != null)
			{
				base.Tables.Add(new Class171.Class185(dataSet.Tables["tJ_DamageActDetection"]));
			}
			if (dataSet.Tables["table23"] != null)
			{
				base.Tables.Add(new Class171.Class186(dataSet.Tables["table23"]));
			}
			if (dataSet.Tables["table31"] != null)
			{
				base.Tables.Add(new Class171.Class187(dataSet.Tables["table31"]));
			}
			if (dataSet.Tables["table4"] != null)
			{
				base.Tables.Add(new Class171.Class188(dataSet.Tables["table4"]));
			}
			if (dataSet.Tables["tJ_DamageHV"] != null)
			{
				base.Tables.Add(new Class171.Class189(dataSet.Tables["tJ_DamageHV"]));
			}
			if (dataSet.Tables["tReportDetectionCrash"] != null)
			{
				base.Tables.Add(new Class171.Class190(dataSet.Tables["tReportDetectionCrash"]));
			}
			if (dataSet.Tables["tReportDetectionReasonCrash"] != null)
			{
				base.Tables.Add(new Class171.tReportDetectionReasonCrashDataTable(dataSet.Tables["tReportDetectionReasonCrash"]));
			}
			if (dataSet.Tables["tReportDetectionNetReg"] != null)
			{
				base.Tables.Add(new Class171.Class192(dataSet.Tables["tReportDetectionNetReg"]));
			}
			if (dataSet.Tables["tReportDetectionNoAdmissKWT"] != null)
			{
				base.Tables.Add(new Class171.Class193(dataSet.Tables["tReportDetectionNoAdmissKWT"]));
			}
			if (dataSet.Tables["tSettings"] != null)
			{
				base.Tables.Add(new Class171.tSettingsDataTable(dataSet.Tables["tSettings"]));
			}
			if (dataSet.Tables["Report81"] != null)
			{
				base.Tables.Add(new Class171.Class195(dataSet.Tables["Report81"]));
			}
			if (dataSet.Tables["ReportAccidents"] != null)
			{
				base.Tables.Add(new Class171.ReportAccidentsDataTable(dataSet.Tables["ReportAccidents"]));
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
		this.class172_0 = (Class171.Class172)base.Tables["tJ_Damage"];
		if (bool_0 && this.class172_0 != null)
		{
			this.class172_0.method_3();
		}
		this.class173_0 = (Class171.Class173)base.Tables["tMapObj"];
		if (bool_0 && this.class173_0 != null)
		{
			this.class173_0.method_3();
		}
		this.class174_0 = (Class171.Class174)base.Tables["tJ_DamageLV"];
		if (bool_0 && this.class174_0 != null)
		{
			this.class174_0.method_3();
		}
		this.class175_0 = (Class171.Class175)base.Tables["vWorkerGroup"];
		if (bool_0 && this.class175_0 != null)
		{
			this.class175_0.method_2();
		}
		this.class176_0 = (Class171.Class176)base.Tables["tJ_DamageOn"];
		if (bool_0 && this.class176_0 != null)
		{
			this.class176_0.method_3();
		}
		this.class177_0 = (Class171.Class177)base.Tables["ReportDailyLV"];
		if (bool_0 && this.class177_0 != null)
		{
			this.class177_0.method_2();
		}
		this.class178_0 = (Class171.Class178)base.Tables["tJ_Temperature"];
		if (bool_0 && this.class178_0 != null)
		{
			this.class178_0.method_4();
		}
		this.class179_0 = (Class171.Class179)base.Tables["vJ_Temperature"];
		if (bool_0 && this.class179_0 != null)
		{
			this.class179_0.method_4();
		}
		this.class180_0 = (Class171.Class180)base.Tables["tReportIterruptLV"];
		if (bool_0 && this.class180_0 != null)
		{
			this.class180_0.method_2();
		}
		this.class181_0 = (Class171.Class181)base.Tables["ReportDailyDefect"];
		if (bool_0 && this.class181_0 != null)
		{
			this.class181_0.method_2();
		}
		this.class182_0 = (Class171.Class182)base.Tables["vJ_Damage"];
		if (bool_0 && this.class182_0 != null)
		{
			this.class182_0.method_2();
		}
		this.class183_0 = (Class171.Class183)base.Tables["ReportDailyHV"];
		if (bool_0 && this.class183_0 != null)
		{
			this.class183_0.method_2();
		}
		this.DsrClxMliil = (Class171.tJ_DamageCharacterDataTable)base.Tables["tJ_DamageCharacter"];
		if (bool_0 && this.DsrClxMliil != null)
		{
			this.DsrClxMliil.method_3();
		}
		this.class185_0 = (Class171.Class185)base.Tables["tJ_DamageActDetection"];
		if (bool_0 && this.class185_0 != null)
		{
			this.class185_0.method_3();
		}
		this.class186_0 = (Class171.Class186)base.Tables["table23"];
		if (bool_0 && this.class186_0 != null)
		{
			this.class186_0.method_2();
		}
		this.class187_0 = (Class171.Class187)base.Tables["table31"];
		if (bool_0 && this.class187_0 != null)
		{
			this.class187_0.method_2();
		}
		this.class188_0 = (Class171.Class188)base.Tables["table4"];
		if (bool_0 && this.class188_0 != null)
		{
			this.class188_0.method_2();
		}
		this.class189_0 = (Class171.Class189)base.Tables["tJ_DamageHV"];
		if (bool_0 && this.class189_0 != null)
		{
			this.class189_0.method_3();
		}
		this.class190_0 = (Class171.Class190)base.Tables["tReportDetectionCrash"];
		if (bool_0 && this.class190_0 != null)
		{
			this.class190_0.method_2();
		}
		this.class191_0 = (Class171.tReportDetectionReasonCrashDataTable)base.Tables["tReportDetectionReasonCrash"];
		if (bool_0 && this.class191_0 != null)
		{
			this.class191_0.method_2();
		}
		this.class192_0 = (Class171.Class192)base.Tables["tReportDetectionNetReg"];
		if (bool_0 && this.class192_0 != null)
		{
			this.class192_0.method_2();
		}
		this.class193_0 = (Class171.Class193)base.Tables["tReportDetectionNoAdmissKWT"];
		if (bool_0 && this.class193_0 != null)
		{
			this.class193_0.method_1();
		}
		this.class194_0 = (Class171.tSettingsDataTable)base.Tables["tSettings"];
		if (bool_0 && this.class194_0 != null)
		{
			this.class194_0.method_3();
		}
		this.class195_0 = (Class171.Class195)base.Tables["Report81"];
		if (bool_0 && this.class195_0 != null)
		{
			this.class195_0.method_2();
		}
		this.class196_0 = (Class171.ReportAccidentsDataTable)base.Tables["ReportAccidents"];
		if (bool_0 && this.class196_0 != null)
		{
			this.class196_0.method_2();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void method_2()
	{
		base.DataSetName = "DataSetDamage";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/DataSetDamage.xsd";
		base.EnforceConstraints = true;
		this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		this.class172_0 = new Class171.Class172();
		base.Tables.Add(this.class172_0);
		this.class173_0 = new Class171.Class173();
		base.Tables.Add(this.class173_0);
		this.class174_0 = new Class171.Class174();
		base.Tables.Add(this.class174_0);
		this.class175_0 = new Class171.Class175();
		base.Tables.Add(this.class175_0);
		this.class176_0 = new Class171.Class176();
		base.Tables.Add(this.class176_0);
		this.class177_0 = new Class171.Class177();
		base.Tables.Add(this.class177_0);
		this.class178_0 = new Class171.Class178(false);
		base.Tables.Add(this.class178_0);
		this.class179_0 = new Class171.Class179(false);
		base.Tables.Add(this.class179_0);
		this.class180_0 = new Class171.Class180();
		base.Tables.Add(this.class180_0);
		this.class181_0 = new Class171.Class181();
		base.Tables.Add(this.class181_0);
		this.class182_0 = new Class171.Class182();
		base.Tables.Add(this.class182_0);
		this.class183_0 = new Class171.Class183();
		base.Tables.Add(this.class183_0);
		this.DsrClxMliil = new Class171.tJ_DamageCharacterDataTable();
		base.Tables.Add(this.DsrClxMliil);
		this.class185_0 = new Class171.Class185();
		base.Tables.Add(this.class185_0);
		this.class186_0 = new Class171.Class186();
		base.Tables.Add(this.class186_0);
		this.class187_0 = new Class171.Class187();
		base.Tables.Add(this.class187_0);
		this.class188_0 = new Class171.Class188();
		base.Tables.Add(this.class188_0);
		this.class189_0 = new Class171.Class189();
		base.Tables.Add(this.class189_0);
		this.class190_0 = new Class171.Class190();
		base.Tables.Add(this.class190_0);
		this.class191_0 = new Class171.tReportDetectionReasonCrashDataTable();
		base.Tables.Add(this.class191_0);
		this.class192_0 = new Class171.Class192();
		base.Tables.Add(this.class192_0);
		this.class193_0 = new Class171.Class193();
		base.Tables.Add(this.class193_0);
		this.class194_0 = new Class171.tSettingsDataTable();
		base.Tables.Add(this.class194_0);
		this.class195_0 = new Class171.Class195();
		base.Tables.Add(this.class195_0);
		this.class196_0 = new Class171.ReportAccidentsDataTable();
		base.Tables.Add(this.class196_0);
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

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_11()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool method_12()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_13()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_14()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_15()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_16()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_17()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool method_18()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_19()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_20()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_21()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_22()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_23()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_24()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_25()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private bool method_26()
	{
		return false;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	[DebuggerNonUserCode]
	private bool method_27()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	private void method_28(object sender, CollectionChangeEventArgs e)
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
		Class171 @class = new Class171();
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
	private void method_29()
	{
		this.tJ_Temperature.DataColumn_13.Expression = "isnull('от ' +NightDown + ' ' , '') + isnull('до ' + nightUp, '')";
		this.tJ_Temperature.DataColumn_14.Expression = "isnull('от ' +DayDown + ' ' , '') + isnull('до ' + DayUp, '')";
		this.tJ_Temperature.DataColumn_15.Expression = "isnull('от ' +SpeedDown + ' ' , '') + isnull('до ' + SpeedUp, '')";
		this.vJ_Temperature.DataColumn_14.Expression = "isnull('от ' +NightDown + ' ' , '') + isnull('до ' + nightUp, '')";
		this.vJ_Temperature.DataColumn_15.Expression = "isnull('от ' +DayDown + ' ' , '') + isnull('до ' + DayUp, '')";
		this.vJ_Temperature.DataColumn_16.Expression = "isnull(SpeedDown + ' - ' , '') + isnull( SpeedUp, '')";
	}

	private Class171.Class172 class172_0;

	private Class171.Class173 class173_0;

	private Class171.Class174 class174_0;

	private Class171.Class175 class175_0;

	private Class171.Class176 class176_0;

	private Class171.Class177 class177_0;

	private Class171.Class178 class178_0;

	private Class171.Class179 class179_0;

	private Class171.Class180 class180_0;

	private Class171.Class181 class181_0;

	private Class171.Class182 class182_0;

	private Class171.Class183 class183_0;

	private Class171.tJ_DamageCharacterDataTable DsrClxMliil;

	private Class171.Class185 class185_0;

	private Class171.Class186 class186_0;

	private Class171.Class187 class187_0;

	private Class171.Class188 class188_0;

	private Class171.Class189 class189_0;

	private Class171.Class190 class190_0;

	private Class171.tReportDetectionReasonCrashDataTable class191_0;

	private Class171.Class192 class192_0;

	private Class171.Class193 class193_0;

	private Class171.tSettingsDataTable class194_0;

	private Class171.Class195 class195_0;

	private Class171.ReportAccidentsDataTable class196_0;

	private SchemaSerializationMode schemaSerializationMode_0;

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate75(object sender, Class171.EventArgs71 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate76(object sender, Class171.EventArgs72 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate77(object sender, Class171.EventArgs73 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate78(object sender, Class171.EventArgs74 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate79(object sender, Class171.EventArgs75 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate80(object sender, Class171.EventArgs76 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate81(object sender, Class171.EventArgs77 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate82(object sender, Class171.EventArgs78 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate83(object sender, Class171.EventArgs79 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate84(object sender, Class171.EventArgs80 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate85(object sender, Class171.EventArgs81 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate86(object sender, Class171.EventArgs82 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate87(object sender, Class171.EventArgs83 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate88(object sender, Class171.EventArgs84 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate89(object sender, Class171.EventArgs85 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate90(object sender, Class171.EventArgs86 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate91(object sender, Class171.EventArgs87 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate92(object sender, Class171.EventArgs88 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate93(object sender, Class171.EventArgs89 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate94(object sender, Class171.EventArgs90 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate95(object sender, Class171.EventArgs91 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate96(object sender, Class171.EventArgs92 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate97(object sender, Class171.EventArgs93 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate98(object sender, Class171.EventArgs94 e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public delegate void Delegate99(object sender, Class171.EventArgs95 e);

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class172 : TypedTableBase<Class171.Class197>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class172()
		{
			//
			
			base.TableName = "tJ_Damage";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class172(DataTable dataTable_0)
		{
			//
			
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
		protected Class172(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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
		public DataColumn idDivisionColumn
		{
			get
			{
				return this.dataColumn_6;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idSchmObjColumn
		{
			get
			{
				return this.dataColumn_7;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_5
		{
			get
			{
				return this.dataColumn_8;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_6
		{
			get
			{
				return this.dataColumn_9;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_7
		{
			get
			{
				return this.dataColumn_10;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_8
		{
			get
			{
				return this.dataColumn_11;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_9
		{
			get
			{
				return this.dataColumn_12;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_10
		{
			get
			{
				return this.dataColumn_13;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_11
		{
			get
			{
				return this.dataColumn_14;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_12
		{
			get
			{
				return this.dataColumn_15;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_13
		{
			get
			{
				return this.dataColumn_16;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_14
		{
			get
			{
				return this.dataColumn_17;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_15
		{
			get
			{
				return this.dataColumn_18;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_16
		{
			get
			{
				return this.dataColumn_19;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_17
		{
			get
			{
				return this.dataColumn_20;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_18
		{
			get
			{
				return this.dataColumn_21;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_19
		{
			get
			{
				return this.dataColumn_22;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_20
		{
			get
			{
				return this.dataColumn_23;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_21
		{
			get
			{
				return this.dataColumn_24;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_22
		{
			get
			{
				return this.dataColumn_25;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_23
		{
			get
			{
				return this.dataColumn_26;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_24
		{
			get
			{
				return this.dataColumn_27;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_25
		{
			get
			{
				return this.dataColumn_28;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_26
		{
			get
			{
				return this.dataColumn_29;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_27
		{
			get
			{
				return this.dataColumn_30;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_28
		{
			get
			{
				return this.dataColumn_31;
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
		public Class171.Class197 this[int int_0]
		{
			get
			{
				return (Class171.Class197)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate75 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate75 @delegate = this.delegate75_0;
				Class171.Delegate75 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate75 value2 = (Class171.Delegate75)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate75>(ref this.delegate75_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate75 @delegate = this.delegate75_0;
				Class171.Delegate75 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate75 value2 = (Class171.Delegate75)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate75>(ref this.delegate75_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate75 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate75 @delegate = this.delegate75_1;
				Class171.Delegate75 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate75 value2 = (Class171.Delegate75)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate75>(ref this.delegate75_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate75 @delegate = this.delegate75_1;
				Class171.Delegate75 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate75 value2 = (Class171.Delegate75)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate75>(ref this.delegate75_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate75 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate75 @delegate = this.delegate75_2;
				Class171.Delegate75 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate75 value2 = (Class171.Delegate75)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate75>(ref this.delegate75_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate75 @delegate = this.delegate75_2;
				Class171.Delegate75 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate75 value2 = (Class171.Delegate75)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate75>(ref this.delegate75_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate75 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate75 @delegate = this.delegate75_3;
				Class171.Delegate75 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate75 value2 = (Class171.Delegate75)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate75>(ref this.delegate75_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate75 @delegate = this.delegate75_3;
				Class171.Delegate75 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate75 value2 = (Class171.Delegate75)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate75>(ref this.delegate75_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class171.Class197 class197_0)
		{
			base.Rows.Add(class197_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class197 method_1(int int_0, DateTime dateTime_0, int int_1, string string_0, int int_2, int int_3, int int_4, int int_5, int int_6, string string_1, int int_7, int int_8, string string_2, bool bool_0, int int_9, DateTime dateTime_1, DateTime dateTime_2, int int_10, bool bool_1, int int_11, int int_12, DateTime dateTime_3, int int_13, string string_3, string string_4, int int_14, string string_5, bool bool_2, int int_15, bool bool_3, string string_6)
		{
			Class171.Class197 @class = (Class171.Class197)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				int_0,
				dateTime_0,
				int_1,
				string_0,
				int_2,
				int_3,
				int_4,
				int_5,
				int_6,
				string_1,
				int_7,
				int_8,
				string_2,
				bool_0,
				int_9,
				dateTime_1,
				dateTime_2,
				int_10,
				bool_1,
				int_11,
				int_12,
				dateTime_3,
				int_13,
				string_3,
				string_4,
				int_14,
				string_5,
				bool_2,
				int_15,
				bool_3,
				string_6
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class197 method_2(int int_0)
		{
			return (Class171.Class197)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.Class172 @class = (Class171.Class172)base.Clone();
			@class.method_3();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class172();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["numDoc"];
			this.dataColumn_2 = base.Columns["DateDoc"];
			this.dataColumn_3 = base.Columns["TypeDoc"];
			this.dataColumn_4 = base.Columns["NumRequest"];
			this.dataColumn_5 = base.Columns["idCompiler"];
			this.dataColumn_6 = base.Columns["idDivision"];
			this.dataColumn_7 = base.Columns["idSchmObj"];
			this.dataColumn_8 = base.Columns["idMap"];
			this.dataColumn_9 = base.Columns["idStreet"];
			this.dataColumn_10 = base.Columns["DefectLocation"];
			this.dataColumn_11 = base.Columns["idReason"];
			this.dataColumn_12 = base.Columns["idCompletedWork"];
			this.dataColumn_13 = base.Columns["ComletedWorkText"];
			this.dataColumn_14 = base.Columns["isApply"];
			this.dataColumn_15 = base.Columns["idWorkerApply"];
			this.dataColumn_16 = base.Columns["DatePlanApply"];
			this.dataColumn_17 = base.Columns["DateApply"];
			this.dataColumn_18 = base.Columns["idDivisionApply"];
			this.dataColumn_19 = base.Columns["isLaboratory"];
			this.dataColumn_20 = base.Columns["idParent"];
			this.dataColumn_21 = base.Columns["idOwner"];
			this.dataColumn_22 = base.Columns["DateOwner"];
			this.dataColumn_23 = base.Columns["idReasonPTS"];
			this.dataColumn_24 = base.Columns["DivisionInstruction"];
			this.dataColumn_25 = base.Columns["LaboratoryInstruction"];
			this.dataColumn_26 = base.Columns["idCompletedWorkODS"];
			this.dataColumn_27 = base.Columns["CompletedWorkTextODS"];
			this.dataColumn_28 = base.Columns["deleted"];
			this.dataColumn_29 = base.Columns["idReqForRepair"];
			this.dataColumn_30 = base.Columns["is81"];
			this.dataColumn_31 = base.Columns["CommentXml"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("numDoc", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("DateDoc", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("TypeDoc", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("NumRequest", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("idCompiler", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("idDivision", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("idMap", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("idStreet", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("DefectLocation", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("idReason", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("idCompletedWork", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			this.dataColumn_13 = new DataColumn("ComletedWorkText", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_13);
			this.dataColumn_14 = new DataColumn("isApply", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_14);
			this.dataColumn_15 = new DataColumn("idWorkerApply", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_15);
			this.dataColumn_16 = new DataColumn("DatePlanApply", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_16);
			this.dataColumn_17 = new DataColumn("DateApply", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_17);
			this.dataColumn_18 = new DataColumn("idDivisionApply", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_18);
			this.dataColumn_19 = new DataColumn("isLaboratory", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_19);
			this.dataColumn_20 = new DataColumn("idParent", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_20);
			this.dataColumn_21 = new DataColumn("idOwner", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_21);
			this.dataColumn_22 = new DataColumn("DateOwner", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_22);
			this.dataColumn_23 = new DataColumn("idReasonPTS", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_23);
			this.dataColumn_24 = new DataColumn("DivisionInstruction", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_24);
			this.dataColumn_25 = new DataColumn("LaboratoryInstruction", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_25);
			this.dataColumn_26 = new DataColumn("idCompletedWorkODS", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_26);
			this.dataColumn_27 = new DataColumn("CompletedWorkTextODS", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_27);
			this.dataColumn_28 = new DataColumn("deleted", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_28);
			this.dataColumn_29 = new DataColumn("idReqForRepair", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_29);
			this.dataColumn_30 = new DataColumn("is81", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_30);
			this.dataColumn_31 = new DataColumn("CommentXml", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_31);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AutoIncrement = true;
			this.dataColumn_0.AutoIncrementSeed = -1L;
			this.dataColumn_0.AutoIncrementStep = -1L;
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.Unique = true;
			this.dataColumn_3.AllowDBNull = false;
			this.dataColumn_4.MaxLength = 50;
			this.dataColumn_10.MaxLength = 1024;
			this.dataColumn_13.MaxLength = 2028;
			this.dataColumn_28.AllowDBNull = false;
			this.dataColumn_28.DefaultValue = false;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class197 method_5()
		{
			return (Class171.Class197)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class197(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class197);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate75_1 != null)
			{
				this.delegate75_1(this, new Class171.EventArgs71((Class171.Class197)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate75_0 != null)
			{
				this.delegate75_0(this, new Class171.EventArgs71((Class171.Class197)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate75_3 != null)
			{
				this.delegate75_3(this, new Class171.EventArgs71((Class171.Class197)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate75_2 != null)
			{
				this.delegate75_2(this, new Class171.EventArgs71((Class171.Class197)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_6(Class171.Class197 class197_0)
		{
			base.Rows.Remove(class197_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tJ_DamageDataTable";
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

		[CompilerGenerated]
		private Class171.Delegate75 delegate75_0;

		[CompilerGenerated]
		private Class171.Delegate75 delegate75_1;

		[CompilerGenerated]
		private Class171.Delegate75 delegate75_2;

		[CompilerGenerated]
		private Class171.Delegate75 delegate75_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class173 : TypedTableBase<Class171.Class198>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class173()
		{
			//
			
			base.TableName = "tMapObj";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class173(DataTable dataTable_0)
		{
			//
			
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
		protected Class173(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_7
		{
			get
			{
				return this.vneZvyLtXsE;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_8
		{
			get
			{
				return this.dataColumn_7;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_9
		{
			get
			{
				return this.dataColumn_8;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_10
		{
			get
			{
				return this.dataColumn_9;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_11
		{
			get
			{
				return this.dataColumn_10;
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
		public Class171.Class198 this[int int_0]
		{
			get
			{
				return (Class171.Class198)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate76 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate76 @delegate = this.delegate76_0;
				Class171.Delegate76 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate76 value2 = (Class171.Delegate76)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate76>(ref this.delegate76_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate76 @delegate = this.delegate76_0;
				Class171.Delegate76 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate76 value2 = (Class171.Delegate76)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate76>(ref this.delegate76_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate76 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate76 @delegate = this.delegate76_1;
				Class171.Delegate76 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate76 value2 = (Class171.Delegate76)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate76>(ref this.delegate76_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate76 @delegate = this.delegate76_1;
				Class171.Delegate76 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate76 value2 = (Class171.Delegate76)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate76>(ref this.delegate76_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate76 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate76 @delegate = this.delegate76_2;
				Class171.Delegate76 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate76 value2 = (Class171.Delegate76)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate76>(ref this.delegate76_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate76 @delegate = this.delegate76_2;
				Class171.Delegate76 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate76 value2 = (Class171.Delegate76)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate76>(ref this.delegate76_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate76 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate76 @delegate = this.klyZvPcmcca;
				Class171.Delegate76 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate76 value2 = (Class171.Delegate76)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate76>(ref this.klyZvPcmcca, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate76 @delegate = this.klyZvPcmcca;
				Class171.Delegate76 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate76 value2 = (Class171.Delegate76)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate76>(ref this.klyZvPcmcca, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class198 class198_0)
		{
			base.Rows.Add(class198_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class198 method_1(int int_0, int int_1, int int_2, string string_0, bool bool_0, string string_1, string string_2, double double_0, double double_1, string string_3, bool bool_1)
		{
			Class171.Class198 @class = (Class171.Class198)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				int_0,
				int_1,
				int_2,
				string_0,
				bool_0,
				string_1,
				string_2,
				double_0,
				double_1,
				string_3,
				bool_1
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class198 method_2(int int_0)
		{
			return (Class171.Class198)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.Class173 @class = (Class171.Class173)base.Clone();
			@class.method_3();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class173();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["idMap"];
			this.dataColumn_1 = base.Columns["Raion"];
			this.dataColumn_2 = base.Columns["Street"];
			this.dataColumn_3 = base.Columns["House"];
			this.dataColumn_4 = base.Columns["HousePrefix"];
			this.dataColumn_5 = base.Columns["IsHouse"];
			this.dataColumn_6 = base.Columns["Name"];
			this.vneZvyLtXsE = base.Columns["Index"];
			this.dataColumn_7 = base.Columns["Latitude"];
			this.dataColumn_8 = base.Columns["Longitude"];
			this.dataColumn_9 = base.Columns["Comment"];
			this.dataColumn_10 = base.Columns["Deleted"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("idMap", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("Raion", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("Street", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("House", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("HousePrefix", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("IsHouse", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("Name", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.vneZvyLtXsE = new DataColumn("Index", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.vneZvyLtXsE);
			this.dataColumn_7 = new DataColumn("Latitude", typeof(double), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("Longitude", typeof(double), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("Comment", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
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
			this.dataColumn_2.AllowDBNull = false;
			this.dataColumn_4.MaxLength = 20;
			this.dataColumn_5.AllowDBNull = false;
			this.dataColumn_6.MaxLength = 40;
			this.vneZvyLtXsE.MaxLength = 6;
			this.dataColumn_9.MaxLength = 1024;
			this.dataColumn_10.AllowDBNull = false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class198 method_5()
		{
			return (Class171.Class198)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class198(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class198);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate76_1 != null)
			{
				this.delegate76_1(this, new Class171.EventArgs72((Class171.Class198)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate76_0 != null)
			{
				this.delegate76_0(this, new Class171.EventArgs72((Class171.Class198)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.klyZvPcmcca != null)
			{
				this.klyZvPcmcca(this, new Class171.EventArgs72((Class171.Class198)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate76_2 != null)
			{
				this.delegate76_2(this, new Class171.EventArgs72((Class171.Class198)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_6(Class171.Class198 class198_0)
		{
			base.Rows.Remove(class198_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tMapObjDataTable";
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

		private DataColumn vneZvyLtXsE;

		private DataColumn dataColumn_7;

		private DataColumn dataColumn_8;

		private DataColumn dataColumn_9;

		private DataColumn dataColumn_10;

		[CompilerGenerated]
		private Class171.Delegate76 delegate76_0;

		[CompilerGenerated]
		private Class171.Delegate76 delegate76_1;

		[CompilerGenerated]
		private Class171.Delegate76 delegate76_2;

		[CompilerGenerated]
		private Class171.Delegate76 klyZvPcmcca;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class174 : TypedTableBase<Class171.Class199>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class174()
		{
			//
			
			base.TableName = "tJ_DamageLV";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class174(DataTable dataTable_0)
		{
			//
			
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
		protected Class174(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idDamageColumn
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
		public Class171.Class199 this[int int_0]
		{
			get
			{
				return (Class171.Class199)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate77 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate77 @delegate = this.delegate77_0;
				Class171.Delegate77 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate77 value2 = (Class171.Delegate77)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate77>(ref this.delegate77_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate77 @delegate = this.delegate77_0;
				Class171.Delegate77 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate77 value2 = (Class171.Delegate77)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate77>(ref this.delegate77_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate77 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate77 @delegate = this.delegate77_1;
				Class171.Delegate77 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate77 value2 = (Class171.Delegate77)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate77>(ref this.delegate77_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate77 @delegate = this.delegate77_1;
				Class171.Delegate77 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate77 value2 = (Class171.Delegate77)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate77>(ref this.delegate77_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate77 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate77 @delegate = this.delegate77_2;
				Class171.Delegate77 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate77 value2 = (Class171.Delegate77)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate77>(ref this.delegate77_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate77 @delegate = this.delegate77_2;
				Class171.Delegate77 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate77 value2 = (Class171.Delegate77)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate77>(ref this.delegate77_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate77 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate77 @delegate = this.delegate77_3;
				Class171.Delegate77 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate77 value2 = (Class171.Delegate77)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate77>(ref this.delegate77_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate77 @delegate = this.delegate77_3;
				Class171.Delegate77 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate77 value2 = (Class171.Delegate77)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate77>(ref this.delegate77_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class171.Class199 class199_0)
		{
			base.Rows.Add(class199_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class199 method_1(int int_0, string string_0, string string_1, string string_2)
		{
			Class171.Class199 @class = (Class171.Class199)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
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
		public Class171.Class199 method_2(int int_0)
		{
			return (Class171.Class199)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class171.Class174 @class = (Class171.Class174)base.Clone();
			@class.method_3();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class174();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["idDamage"];
			this.dataColumn_1 = base.Columns["Declarer"];
			this.dataColumn_2 = base.Columns["DeclarerTel"];
			this.dataColumn_3 = base.Columns["DeclarerAddress"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("idDamage", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("Declarer", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("DeclarerTel", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("DeclarerAddress", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.Unique = true;
			this.dataColumn_1.MaxLength = 256;
			this.dataColumn_2.MaxLength = 256;
			this.dataColumn_3.Caption = "DeclarerAddREss";
			this.dataColumn_3.MaxLength = 512;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class199 method_5()
		{
			return (Class171.Class199)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class199(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class199);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate77_1 != null)
			{
				this.delegate77_1(this, new Class171.EventArgs73((Class171.Class199)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate77_0 != null)
			{
				this.delegate77_0(this, new Class171.EventArgs73((Class171.Class199)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate77_3 != null)
			{
				this.delegate77_3(this, new Class171.EventArgs73((Class171.Class199)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate77_2 != null)
			{
				this.delegate77_2(this, new Class171.EventArgs73((Class171.Class199)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_6(Class171.Class199 class199_0)
		{
			base.Rows.Remove(class199_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tJ_DamageLVDataTable";
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
		private Class171.Delegate77 delegate77_0;

		[CompilerGenerated]
		private Class171.Delegate77 delegate77_1;

		[CompilerGenerated]
		private Class171.Delegate77 delegate77_2;

		[CompilerGenerated]
		private Class171.Delegate77 delegate77_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class175 : TypedTableBase<Class171.Class200>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class175()
		{
			//
			
			base.TableName = "vWorkerGroup";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class175(DataTable dataTable_0)
		{
			//
			
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
		protected Class175(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
		public Class171.Class200 this[int int_0]
		{
			get
			{
				return (Class171.Class200)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate78 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate78 @delegate = this.delegate78_0;
				Class171.Delegate78 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate78 value2 = (Class171.Delegate78)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate78>(ref this.delegate78_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate78 @delegate = this.delegate78_0;
				Class171.Delegate78 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate78 value2 = (Class171.Delegate78)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate78>(ref this.delegate78_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate78 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate78 @delegate = this.delegate78_1;
				Class171.Delegate78 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate78 value2 = (Class171.Delegate78)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate78>(ref this.delegate78_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate78 @delegate = this.delegate78_1;
				Class171.Delegate78 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate78 value2 = (Class171.Delegate78)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate78>(ref this.delegate78_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate78 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate78 @delegate = this.delegate78_2;
				Class171.Delegate78 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate78 value2 = (Class171.Delegate78)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate78>(ref this.delegate78_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate78 @delegate = this.delegate78_2;
				Class171.Delegate78 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate78 value2 = (Class171.Delegate78)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate78>(ref this.delegate78_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate78 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate78 @delegate = this.delegate78_3;
				Class171.Delegate78 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate78 value2 = (Class171.Delegate78)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate78>(ref this.delegate78_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate78 @delegate = this.delegate78_3;
				Class171.Delegate78 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate78 value2 = (Class171.Delegate78)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate78>(ref this.delegate78_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class200 class200_0)
		{
			base.Rows.Add(class200_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class200 method_1(int int_0, string string_0, DateTime dateTime_0, DateTime dateTime_1, int int_1, string string_1, string string_2, string string_3, int int_2, short short_0)
		{
			Class171.Class200 @class = (Class171.Class200)base.NewRow();
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class171.Class175 @class = (Class171.Class175)base.Clone();
			@class.method_2();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class175();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
		public Class171.Class200 method_4()
		{
			return (Class171.Class200)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class200(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class200);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate78_1 != null)
			{
				this.delegate78_1(this, new Class171.EventArgs74((Class171.Class200)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate78_0 != null)
			{
				this.delegate78_0(this, new Class171.EventArgs74((Class171.Class200)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate78_3 != null)
			{
				this.delegate78_3(this, new Class171.EventArgs74((Class171.Class200)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate78_2 != null)
			{
				this.delegate78_2(this, new Class171.EventArgs74((Class171.Class200)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5(Class171.Class200 class200_0)
		{
			base.Rows.Remove(class200_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
		private Class171.Delegate78 delegate78_0;

		[CompilerGenerated]
		private Class171.Delegate78 delegate78_1;

		[CompilerGenerated]
		private Class171.Delegate78 delegate78_2;

		[CompilerGenerated]
		private Class171.Delegate78 delegate78_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class176 : TypedTableBase<Class171.Class201>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class176()
		{
			//
			
			base.TableName = "tJ_DamageOn";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class176(DataTable dataTable_0)
		{
			//
			
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
		protected Class176(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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
		public DataColumn idDamageColumn
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn dateOnColumn
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
				return this.dataColumn_3;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn noAdmissionKWTColumn
		{
			get
			{
				return this.dataColumn_4;
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
		public Class171.Class201 this[int int_0]
		{
			get
			{
				return (Class171.Class201)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate79 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate79 @delegate = this.delegate79_0;
				Class171.Delegate79 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate79 value2 = (Class171.Delegate79)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate79>(ref this.delegate79_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate79 @delegate = this.delegate79_0;
				Class171.Delegate79 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate79 value2 = (Class171.Delegate79)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate79>(ref this.delegate79_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate79 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate79 @delegate = this.delegate79_1;
				Class171.Delegate79 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate79 value2 = (Class171.Delegate79)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate79>(ref this.delegate79_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate79 @delegate = this.delegate79_1;
				Class171.Delegate79 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate79 value2 = (Class171.Delegate79)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate79>(ref this.delegate79_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate79 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate79 @delegate = this.delegate79_2;
				Class171.Delegate79 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate79 value2 = (Class171.Delegate79)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate79>(ref this.delegate79_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate79 @delegate = this.delegate79_2;
				Class171.Delegate79 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate79 value2 = (Class171.Delegate79)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate79>(ref this.delegate79_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate79 IcxZcmogjVK
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate79 @delegate = this.delegate79_3;
				Class171.Delegate79 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate79 value2 = (Class171.Delegate79)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate79>(ref this.delegate79_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate79 @delegate = this.delegate79_3;
				Class171.Delegate79 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate79 value2 = (Class171.Delegate79)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate79>(ref this.delegate79_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class171.Class201 class201_0)
		{
			base.Rows.Add(class201_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class201 method_1(int int_0, DateTime dateTime_0, int int_1, decimal decimal_0)
		{
			Class171.Class201 @class = (Class171.Class201)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				int_0,
				dateTime_0,
				int_1,
				decimal_0
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class201 method_2(int int_0)
		{
			return (Class171.Class201)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.Class176 @class = (Class171.Class176)base.Clone();
			@class.method_3();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class176();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["idDamage"];
			this.dataColumn_2 = base.Columns["dateOn"];
			this.dataColumn_3 = base.Columns["countSchmObj"];
			this.dataColumn_4 = base.Columns["noAdmissionKWT"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("idDamage", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("dateOn", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("countSchmObj", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("noAdmissionKWT", typeof(decimal), null, MappingType.Element);
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
		public Class171.Class201 method_5()
		{
			return (Class171.Class201)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class201(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class201);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate79_1 != null)
			{
				this.delegate79_1(this, new Class171.EventArgs75((Class171.Class201)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate79_0 != null)
			{
				this.delegate79_0(this, new Class171.EventArgs75((Class171.Class201)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate79_3 != null)
			{
				this.delegate79_3(this, new Class171.EventArgs75((Class171.Class201)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate79_2 != null)
			{
				this.delegate79_2(this, new Class171.EventArgs75((Class171.Class201)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_6(Class171.Class201 class201_0)
		{
			base.Rows.Remove(class201_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tJ_DamageOnDataTable";
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
		private Class171.Delegate79 delegate79_0;

		[CompilerGenerated]
		private Class171.Delegate79 delegate79_1;

		[CompilerGenerated]
		private Class171.Delegate79 delegate79_2;

		[CompilerGenerated]
		private Class171.Delegate79 delegate79_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class177 : TypedTableBase<Class171.Class202>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class177()
		{
			//
			
			base.TableName = "ReportDailyLV";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class177(DataTable dataTable_0)
		{
			//
			
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
		protected Class177(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn usaZcabGutT
		{
			get
			{
				return this.dataColumn_4;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idSchmObjColumn
		{
			get
			{
				return this.dataColumn_5;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_3
		{
			get
			{
				return this.dataColumn_6;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_4
		{
			get
			{
				return this.dataColumn_7;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_5
		{
			get
			{
				return this.dataColumn_8;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_6
		{
			get
			{
				return this.dataColumn_9;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_7
		{
			get
			{
				return this.dataColumn_10;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_8
		{
			get
			{
				return this.dataColumn_11;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_9
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
		public Class171.Class202 this[int int_0]
		{
			get
			{
				return (Class171.Class202)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate80 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate80 @delegate = this.delegate80_0;
				Class171.Delegate80 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate80 value2 = (Class171.Delegate80)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate80>(ref this.delegate80_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate80 @delegate = this.delegate80_0;
				Class171.Delegate80 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate80 value2 = (Class171.Delegate80)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate80>(ref this.delegate80_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate80 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate80 @delegate = this.delegate80_1;
				Class171.Delegate80 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate80 value2 = (Class171.Delegate80)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate80>(ref this.delegate80_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate80 @delegate = this.delegate80_1;
				Class171.Delegate80 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate80 value2 = (Class171.Delegate80)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate80>(ref this.delegate80_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate80 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate80 @delegate = this.delegate80_2;
				Class171.Delegate80 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate80 value2 = (Class171.Delegate80)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate80>(ref this.delegate80_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate80 @delegate = this.delegate80_2;
				Class171.Delegate80 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate80 value2 = (Class171.Delegate80)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate80>(ref this.delegate80_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate80 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate80 @delegate = this.tpeZaTlAeAH;
				Class171.Delegate80 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate80 value2 = (Class171.Delegate80)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate80>(ref this.tpeZaTlAeAH, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate80 @delegate = this.tpeZaTlAeAH;
				Class171.Delegate80 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate80 value2 = (Class171.Delegate80)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate80>(ref this.tpeZaTlAeAH, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class171.Class202 class202_0)
		{
			base.Rows.Add(class202_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class202 method_1(int int_0, string string_0, DateTime dateTime_0, string string_1, string string_2, int int_1, string string_3, string string_4, DateTime dateTime_1, string string_5, string string_6, string string_7, string string_8)
		{
			Class171.Class202 @class = (Class171.Class202)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				string_0,
				dateTime_0,
				string_1,
				string_2,
				int_1,
				string_3,
				string_4,
				dateTime_1,
				string_5,
				string_6,
				string_7,
				string_8
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class171.Class177 @class = (Class171.Class177)base.Clone();
			@class.method_2();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class177();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["numRequest"];
			this.dataColumn_2 = base.Columns["dateDoc"];
			this.dataColumn_3 = base.Columns["defectLocation"];
			this.dataColumn_4 = base.Columns["Reason"];
			this.dataColumn_5 = base.Columns["idSchmObj"];
			this.dataColumn_6 = base.Columns["schmObjName"];
			this.dataColumn_7 = base.Columns["Character"];
			this.dataColumn_8 = base.Columns["dateApply"];
			this.dataColumn_9 = base.Columns["completedWork"];
			this.dataColumn_10 = base.Columns["workCompiler"];
			this.dataColumn_11 = base.Columns["workApply"];
			this.dataColumn_12 = base.Columns["NetRegion"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("numRequest", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("dateDoc", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("defectLocation", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("Reason", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("schmObjName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("Character", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("dateApply", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("completedWork", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("workCompiler", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("workApply", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("NetRegion", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class202 method_4()
		{
			return (Class171.Class202)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class202(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class202);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate80_1 != null)
			{
				this.delegate80_1(this, new Class171.EventArgs76((Class171.Class202)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate80_0 != null)
			{
				this.delegate80_0(this, new Class171.EventArgs76((Class171.Class202)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.tpeZaTlAeAH != null)
			{
				this.tpeZaTlAeAH(this, new Class171.EventArgs76((Class171.Class202)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate80_2 != null)
			{
				this.delegate80_2(this, new Class171.EventArgs76((Class171.Class202)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5(Class171.Class202 class202_0)
		{
			base.Rows.Remove(class202_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "ReportDailyLVDataTable";
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

		[CompilerGenerated]
		private Class171.Delegate80 delegate80_0;

		[CompilerGenerated]
		private Class171.Delegate80 delegate80_1;

		[CompilerGenerated]
		private Class171.Delegate80 delegate80_2;

		[CompilerGenerated]
		private Class171.Delegate80 tpeZaTlAeAH;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class178 : TypedTableBase<Class171.Class203>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class178()
		{
			//
			this..ctor(false);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class178(bool bool_0)
		{
			//
			
			base.TableName = "tJ_Temperature";
			this.BeginInit();
			this.method_5();
			if (bool_0)
			{
				this.method_7();
			}
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class178(DataTable dataTable_0)
		{
			//
			
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
		protected Class178(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_4();
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_11
		{
			get
			{
				return this.dataColumn_12;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_12
		{
			get
			{
				return this.dataColumn_13;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_13
		{
			get
			{
				return this.dataColumn_14;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_14
		{
			get
			{
				return this.dataColumn_15;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_15
		{
			get
			{
				return this.dataColumn_16;
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
		public Class171.Class203 this[int int_0]
		{
			get
			{
				return (Class171.Class203)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate81 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate81 @delegate = this.hueZkvrfdif;
				Class171.Delegate81 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate81 value2 = (Class171.Delegate81)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate81>(ref this.hueZkvrfdif, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate81 @delegate = this.hueZkvrfdif;
				Class171.Delegate81 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate81 value2 = (Class171.Delegate81)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate81>(ref this.hueZkvrfdif, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate81 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate81 @delegate = this.delegate81_0;
				Class171.Delegate81 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate81 value2 = (Class171.Delegate81)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate81>(ref this.delegate81_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate81 @delegate = this.delegate81_0;
				Class171.Delegate81 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate81 value2 = (Class171.Delegate81)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate81>(ref this.delegate81_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate81 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate81 @delegate = this.yEoZkcoigte;
				Class171.Delegate81 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate81 value2 = (Class171.Delegate81)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate81>(ref this.yEoZkcoigte, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate81 @delegate = this.yEoZkcoigte;
				Class171.Delegate81 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate81 value2 = (Class171.Delegate81)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate81>(ref this.yEoZkcoigte, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate81 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate81 @delegate = this.delegate81_1;
				Class171.Delegate81 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate81 value2 = (Class171.Delegate81)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate81>(ref this.delegate81_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate81 @delegate = this.delegate81_1;
				Class171.Delegate81 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate81 value2 = (Class171.Delegate81)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate81>(ref this.delegate81_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class171.Class203 class203_0)
		{
			base.Rows.Add(class203_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class203 method_1(DateTime dateTime_0, short short_0, short short_1, short short_2, short short_3, short short_4, int int_0, short short_5, short short_6, string string_0, DateTime dateTime_1, int int_1, string string_1, string string_2, string string_3, string string_4)
		{
			Class171.Class203 @class = (Class171.Class203)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				dateTime_0,
				short_0,
				short_1,
				short_2,
				short_3,
				short_4,
				int_0,
				short_5,
				short_6,
				string_0,
				dateTime_1,
				int_1,
				string_1,
				string_2,
				string_3,
				string_4
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class203 method_2(DateTime dateTime_0, short short_0, short short_1, short short_2, short short_3, short short_4, int int_0, short short_5, short short_6, string string_0, DateTime dateTime_1, int int_1, string string_1)
		{
			Class171.Class203 @class = (Class171.Class203)base.NewRow();
			object[] array = new object[17];
			array[1] = dateTime_0;
			array[2] = short_0;
			array[3] = short_1;
			array[4] = short_2;
			array[5] = short_3;
			array[6] = short_4;
			array[7] = int_0;
			array[8] = short_5;
			array[9] = short_6;
			array[10] = string_0;
			array[11] = dateTime_1;
			array[12] = int_1;
			array[13] = string_1;
			object[] itemArray = array;
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class203 method_3(int int_0)
		{
			return (Class171.Class203)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class171.Class178 @class = (Class171.Class178)base.Clone();
			@class.method_4();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class178();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_4()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["DateTemp"];
			this.dataColumn_2 = base.Columns["NightDown"];
			this.dataColumn_3 = base.Columns["NightUp"];
			this.dataColumn_4 = base.Columns["DayDown"];
			this.dataColumn_5 = base.Columns["DayUp"];
			this.dataColumn_6 = base.Columns["TempAverage"];
			this.dataColumn_7 = base.Columns["Wind"];
			this.dataColumn_8 = base.Columns["SpeedDown"];
			this.dataColumn_9 = base.Columns["SpeedUp"];
			this.dataColumn_10 = base.Columns["Comment"];
			this.dataColumn_11 = base.Columns["DateOwner"];
			this.dataColumn_12 = base.Columns["idOwner"];
			this.dataColumn_13 = base.Columns["Owner"];
			this.dataColumn_14 = base.Columns["Night"];
			this.dataColumn_15 = base.Columns["Day"];
			this.dataColumn_16 = base.Columns["Speed"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_5()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("DateTemp", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("NightDown", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("NightUp", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("DayDown", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("DayUp", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("TempAverage", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("Wind", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("SpeedDown", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("SpeedUp", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("Comment", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("DateOwner", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("idOwner", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			this.dataColumn_13 = new DataColumn("Owner", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_13);
			this.dataColumn_14 = new DataColumn("Night", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_14);
			this.dataColumn_15 = new DataColumn("Day", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_15);
			this.dataColumn_16 = new DataColumn("Speed", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_16);
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
			this.dataColumn_10.MaxLength = 256;
			this.dataColumn_13.MaxLength = 256;
			this.dataColumn_14.ReadOnly = true;
			this.dataColumn_15.ReadOnly = true;
			this.dataColumn_16.ReadOnly = true;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class203 method_6()
		{
			return (Class171.Class203)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class203(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class203);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_7()
		{
			this.DataColumn_13.Expression = "isnull('от ' +NightDown + ' ' , '') + isnull('до ' + nightUp, '')";
			this.DataColumn_14.Expression = "isnull('от ' +DayDown + ' ' , '') + isnull('до ' + DayUp, '')";
			this.DataColumn_15.Expression = "isnull('от ' +SpeedDown + ' ' , '') + isnull('до ' + SpeedUp, '')";
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate81_0 != null)
			{
				this.delegate81_0(this, new Class171.EventArgs77((Class171.Class203)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.hueZkvrfdif != null)
			{
				this.hueZkvrfdif(this, new Class171.EventArgs77((Class171.Class203)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate81_1 != null)
			{
				this.delegate81_1(this, new Class171.EventArgs77((Class171.Class203)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.yEoZkcoigte != null)
			{
				this.yEoZkcoigte(this, new Class171.EventArgs77((Class171.Class203)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_8(Class171.Class203 class203_0)
		{
			base.Rows.Remove(class203_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tJ_TemperatureDataTable";
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

		[CompilerGenerated]
		private Class171.Delegate81 hueZkvrfdif;

		[CompilerGenerated]
		private Class171.Delegate81 delegate81_0;

		[CompilerGenerated]
		private Class171.Delegate81 yEoZkcoigte;

		[CompilerGenerated]
		private Class171.Delegate81 delegate81_1;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class179 : TypedTableBase<Class171.Class204>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class179()
		{
			//
			this..ctor(false);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class179(bool bool_0)
		{
			//
			
			base.TableName = "vJ_Temperature";
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
		internal Class179(DataTable dataTable_0)
		{
			//
			
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
		protected Class179(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_4();
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_12
		{
			get
			{
				return this.dataColumn_13;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_13
		{
			get
			{
				return this.dataColumn_14;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_16
		{
			get
			{
				return this.dataColumn_17;
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
		public Class171.Class204 this[int int_0]
		{
			get
			{
				return (Class171.Class204)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate82 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate82 @delegate = this.delegate82_0;
				Class171.Delegate82 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate82 value2 = (Class171.Delegate82)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate82>(ref this.delegate82_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate82 @delegate = this.delegate82_0;
				Class171.Delegate82 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate82 value2 = (Class171.Delegate82)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate82>(ref this.delegate82_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate82 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate82 @delegate = this.delegate82_1;
				Class171.Delegate82 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate82 value2 = (Class171.Delegate82)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate82>(ref this.delegate82_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate82 @delegate = this.delegate82_1;
				Class171.Delegate82 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate82 value2 = (Class171.Delegate82)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate82>(ref this.delegate82_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate82 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate82 @delegate = this.delegate82_2;
				Class171.Delegate82 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate82 value2 = (Class171.Delegate82)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate82>(ref this.delegate82_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate82 @delegate = this.delegate82_2;
				Class171.Delegate82 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate82 value2 = (Class171.Delegate82)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate82>(ref this.delegate82_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate82 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate82 @delegate = this.delegate82_3;
				Class171.Delegate82 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate82 value2 = (Class171.Delegate82)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate82>(ref this.delegate82_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate82 @delegate = this.delegate82_3;
				Class171.Delegate82 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate82 value2 = (Class171.Delegate82)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate82>(ref this.delegate82_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class204 class204_0)
		{
			base.Rows.Add(class204_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class204 method_1(DateTime dateTime_0, short short_0, short short_1, short short_2, short short_3, short short_4, int int_0, string string_0, short short_5, short short_6, string string_1, DateTime dateTime_1, int int_1, string string_2, string string_3, string string_4, string string_5)
		{
			Class171.Class204 @class = (Class171.Class204)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				dateTime_0,
				short_0,
				short_1,
				short_2,
				short_3,
				short_4,
				int_0,
				string_0,
				short_5,
				short_6,
				string_1,
				dateTime_1,
				int_1,
				string_2,
				string_3,
				string_4,
				string_5
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class204 method_2(DateTime dateTime_0, short short_0, short short_1, short short_2, short short_3, short short_4, int int_0, string string_0, short short_5, short short_6, string string_1, DateTime dateTime_1, int int_1, string string_2)
		{
			Class171.Class204 @class = (Class171.Class204)base.NewRow();
			object[] array = new object[18];
			array[1] = dateTime_0;
			array[2] = short_0;
			array[3] = short_1;
			array[4] = short_2;
			array[5] = short_3;
			array[6] = short_4;
			array[7] = int_0;
			array[8] = string_0;
			array[9] = short_5;
			array[10] = short_6;
			array[11] = string_1;
			array[12] = dateTime_1;
			array[13] = int_1;
			array[14] = string_2;
			object[] itemArray = array;
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class204 method_3(int int_0)
		{
			return (Class171.Class204)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.Class179 @class = (Class171.Class179)base.Clone();
			@class.method_4();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class179();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_4()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["DateTemp"];
			this.dataColumn_2 = base.Columns["NightDown"];
			this.dataColumn_3 = base.Columns["NightUp"];
			this.dataColumn_4 = base.Columns["DayDown"];
			this.dataColumn_5 = base.Columns["DayUp"];
			this.dataColumn_6 = base.Columns["TempAverage"];
			this.dataColumn_7 = base.Columns["Wind"];
			this.dataColumn_8 = base.Columns["WindName"];
			this.dataColumn_9 = base.Columns["SpeedDown"];
			this.dataColumn_10 = base.Columns["SpeedUp"];
			this.dataColumn_11 = base.Columns["Comment"];
			this.dataColumn_12 = base.Columns["DateOwner"];
			this.dataColumn_13 = base.Columns["idOwner"];
			this.dataColumn_14 = base.Columns["Owner"];
			this.dataColumn_15 = base.Columns["Night"];
			this.dataColumn_16 = base.Columns["Day"];
			this.dataColumn_17 = base.Columns["Speed"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_5()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("DateTemp", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("NightDown", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("NightUp", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("DayDown", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("DayUp", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("TempAverage", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("Wind", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("WindName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("SpeedDown", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("SpeedUp", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("Comment", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("DateOwner", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			this.dataColumn_13 = new DataColumn("idOwner", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_13);
			this.dataColumn_14 = new DataColumn("Owner", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_14);
			this.dataColumn_15 = new DataColumn("Night", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_15);
			this.dataColumn_16 = new DataColumn("Day", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_16);
			this.dataColumn_17 = new DataColumn("Speed", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_17);
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
			this.dataColumn_11.MaxLength = 256;
			this.dataColumn_14.MaxLength = 256;
			this.dataColumn_15.ReadOnly = true;
			this.dataColumn_16.ReadOnly = true;
			this.dataColumn_17.ReadOnly = true;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class204 method_6()
		{
			return (Class171.Class204)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class204(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class204);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_7()
		{
			this.DataColumn_14.Expression = "isnull('от ' +NightDown + ' ' , '') + isnull('до ' + nightUp, '')";
			this.DataColumn_15.Expression = "isnull('от ' +DayDown + ' ' , '') + isnull('до ' + DayUp, '')";
			this.DataColumn_16.Expression = "isnull(SpeedDown + ' - ' , '') + isnull( SpeedUp, '')";
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate82_1 != null)
			{
				this.delegate82_1(this, new Class171.EventArgs78((Class171.Class204)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate82_0 != null)
			{
				this.delegate82_0(this, new Class171.EventArgs78((Class171.Class204)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate82_3 != null)
			{
				this.delegate82_3(this, new Class171.EventArgs78((Class171.Class204)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate82_2 != null)
			{
				this.delegate82_2(this, new Class171.EventArgs78((Class171.Class204)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_8(Class171.Class204 class204_0)
		{
			base.Rows.Remove(class204_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "vJ_TemperatureDataTable";
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

		[CompilerGenerated]
		private Class171.Delegate82 delegate82_0;

		[CompilerGenerated]
		private Class171.Delegate82 delegate82_1;

		[CompilerGenerated]
		private Class171.Delegate82 delegate82_2;

		[CompilerGenerated]
		private Class171.Delegate82 delegate82_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class180 : TypedTableBase<Class171.Class205>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class180()
		{
			//
			
			base.TableName = "tReportIterruptLV";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class180(DataTable dataTable_0)
		{
			//
			
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
		protected Class180(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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
				return this.BejZehwIkLt;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_7
		{
			get
			{
				return this.dataColumn_6;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_8
		{
			get
			{
				return this.dataColumn_7;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_9
		{
			get
			{
				return this.dataColumn_8;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_10
		{
			get
			{
				return this.dataColumn_9;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_11
		{
			get
			{
				return this.dataColumn_10;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_12
		{
			get
			{
				return this.dataColumn_11;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_13
		{
			get
			{
				return this.dataColumn_12;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_14
		{
			get
			{
				return this.dataColumn_13;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_15
		{
			get
			{
				return this.dataColumn_14;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_16
		{
			get
			{
				return this.dataColumn_15;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_17
		{
			get
			{
				return this.dataColumn_16;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_18
		{
			get
			{
				return this.dataColumn_17;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_19
		{
			get
			{
				return this.dataColumn_18;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_20
		{
			get
			{
				return this.dataColumn_19;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_21
		{
			get
			{
				return this.dataColumn_20;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_22
		{
			get
			{
				return this.dataColumn_21;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_23
		{
			get
			{
				return this.dataColumn_22;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_24
		{
			get
			{
				return this.dataColumn_23;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_25
		{
			get
			{
				return this.dataColumn_24;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_26
		{
			get
			{
				return this.dataColumn_25;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_27
		{
			get
			{
				return this.dataColumn_26;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_28
		{
			get
			{
				return this.dataColumn_27;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_29
		{
			get
			{
				return this.dataColumn_28;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn ufmZhKeGqtF
		{
			get
			{
				return this.dataColumn_29;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_30
		{
			get
			{
				return this.dataColumn_30;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_31
		{
			get
			{
				return this.dataColumn_31;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_32
		{
			get
			{
				return this.dataColumn_32;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn pyoZeyhgvqT
		{
			get
			{
				return this.dataColumn_33;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_33
		{
			get
			{
				return this.dataColumn_34;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_34
		{
			get
			{
				return this.dataColumn_35;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_35
		{
			get
			{
				return this.dataColumn_36;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_36
		{
			get
			{
				return this.dataColumn_37;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_37
		{
			get
			{
				return this.dataColumn_38;
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
		public Class171.Class205 this[int int_0]
		{
			get
			{
				return (Class171.Class205)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate83 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate83 @delegate = this.delegate83_0;
				Class171.Delegate83 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate83 value2 = (Class171.Delegate83)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate83>(ref this.delegate83_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate83 @delegate = this.delegate83_0;
				Class171.Delegate83 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate83 value2 = (Class171.Delegate83)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate83>(ref this.delegate83_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate83 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate83 @delegate = this.delegate83_1;
				Class171.Delegate83 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate83 value2 = (Class171.Delegate83)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate83>(ref this.delegate83_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate83 @delegate = this.delegate83_1;
				Class171.Delegate83 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate83 value2 = (Class171.Delegate83)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate83>(ref this.delegate83_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate83 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate83 @delegate = this.delegate83_2;
				Class171.Delegate83 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate83 value2 = (Class171.Delegate83)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate83>(ref this.delegate83_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate83 @delegate = this.delegate83_2;
				Class171.Delegate83 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate83 value2 = (Class171.Delegate83)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate83>(ref this.delegate83_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate83 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate83 @delegate = this.delegate83_3;
				Class171.Delegate83 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate83 value2 = (Class171.Delegate83)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate83>(ref this.delegate83_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate83 @delegate = this.delegate83_3;
				Class171.Delegate83 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate83 value2 = (Class171.Delegate83)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate83>(ref this.delegate83_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class171.Class205 class205_0)
		{
			base.Rows.Add(class205_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class205 method_1(int int_0, string string_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, int int_9, int int_10, int int_11, int int_12, int int_13, int int_14, int int_15, int int_16, int int_17, int int_18, int int_19, int int_20, int int_21, int int_22, int int_23, int int_24, int int_25, int int_26, int int_27, int int_28, int int_29, int int_30, int int_31, int int_32, int int_33, int int_34, int int_35, int int_36, int int_37, int int_38)
		{
			Class171.Class205 @class = (Class171.Class205)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				string_0,
				int_1,
				int_2,
				int_3,
				int_4,
				int_5,
				int_6,
				int_7,
				int_8,
				int_9,
				int_10,
				int_11,
				int_12,
				int_13,
				int_14,
				int_15,
				int_16,
				int_17,
				int_18,
				int_19,
				int_20,
				int_21,
				int_22,
				int_23,
				int_24,
				int_25,
				int_26,
				int_27,
				int_28,
				int_29,
				int_30,
				int_31,
				int_32,
				int_33,
				int_34,
				int_35,
				int_36,
				int_37,
				int_38
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.Class180 @class = (Class171.Class180)base.Clone();
			@class.method_2();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class180();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["numNetRegion"];
			this.dataColumn_1 = base.Columns["netRegionValue"];
			this.dataColumn_2 = base.Columns["c11"];
			this.dataColumn_3 = base.Columns["c12"];
			this.dataColumn_4 = base.Columns["c13"];
			this.dataColumn_5 = base.Columns["c14"];
			this.BejZehwIkLt = base.Columns["c15"];
			this.dataColumn_6 = base.Columns["c16"];
			this.dataColumn_7 = base.Columns["c17"];
			this.dataColumn_8 = base.Columns["c18"];
			this.dataColumn_9 = base.Columns["c19"];
			this.dataColumn_10 = base.Columns["c21"];
			this.dataColumn_11 = base.Columns["c22"];
			this.dataColumn_12 = base.Columns["c23"];
			this.dataColumn_13 = base.Columns["c24"];
			this.dataColumn_14 = base.Columns["c25"];
			this.dataColumn_15 = base.Columns["c26"];
			this.dataColumn_16 = base.Columns["c27"];
			this.dataColumn_17 = base.Columns["c31"];
			this.dataColumn_18 = base.Columns["c32"];
			this.dataColumn_19 = base.Columns["c33"];
			this.dataColumn_20 = base.Columns["c34"];
			this.dataColumn_21 = base.Columns["c35"];
			this.dataColumn_22 = base.Columns["c36"];
			this.dataColumn_23 = base.Columns["c37"];
			this.dataColumn_24 = base.Columns["c41"];
			this.dataColumn_25 = base.Columns["c42"];
			this.dataColumn_26 = base.Columns["c43"];
			this.dataColumn_27 = base.Columns["c44"];
			this.dataColumn_28 = base.Columns["c45"];
			this.dataColumn_29 = base.Columns["c46"];
			this.dataColumn_30 = base.Columns["c51"];
			this.dataColumn_31 = base.Columns["c52"];
			this.dataColumn_32 = base.Columns["c53"];
			this.dataColumn_33 = base.Columns["c54"];
			this.dataColumn_34 = base.Columns["c55"];
			this.dataColumn_35 = base.Columns["c56"];
			this.dataColumn_36 = base.Columns["c57"];
			this.dataColumn_37 = base.Columns["c61"];
			this.dataColumn_38 = base.Columns["c62"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("numNetRegion", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("netRegionValue", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("c11", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("c12", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("c13", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("c14", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.BejZehwIkLt = new DataColumn("c15", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.BejZehwIkLt);
			this.dataColumn_6 = new DataColumn("c16", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("c17", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("c18", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("c19", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("c21", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("c22", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("c23", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			this.dataColumn_13 = new DataColumn("c24", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_13);
			this.dataColumn_14 = new DataColumn("c25", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_14);
			this.dataColumn_15 = new DataColumn("c26", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_15);
			this.dataColumn_16 = new DataColumn("c27", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_16);
			this.dataColumn_17 = new DataColumn("c31", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_17);
			this.dataColumn_18 = new DataColumn("c32", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_18);
			this.dataColumn_19 = new DataColumn("c33", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_19);
			this.dataColumn_20 = new DataColumn("c34", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_20);
			this.dataColumn_21 = new DataColumn("c35", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_21);
			this.dataColumn_22 = new DataColumn("c36", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_22);
			this.dataColumn_23 = new DataColumn("c37", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_23);
			this.dataColumn_24 = new DataColumn("c41", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_24);
			this.dataColumn_25 = new DataColumn("c42", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_25);
			this.dataColumn_26 = new DataColumn("c43", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_26);
			this.dataColumn_27 = new DataColumn("c44", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_27);
			this.dataColumn_28 = new DataColumn("c45", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_28);
			this.dataColumn_29 = new DataColumn("c46", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_29);
			this.dataColumn_30 = new DataColumn("c51", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_30);
			this.dataColumn_31 = new DataColumn("c52", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_31);
			this.dataColumn_32 = new DataColumn("c53", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_32);
			this.dataColumn_33 = new DataColumn("c54", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_33);
			this.dataColumn_34 = new DataColumn("c55", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_34);
			this.dataColumn_35 = new DataColumn("c56", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_35);
			this.dataColumn_36 = new DataColumn("c57", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_36);
			this.dataColumn_37 = new DataColumn("c61", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_37);
			this.dataColumn_38 = new DataColumn("c62", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_38);
			this.dataColumn_2.Caption = "11";
			this.dataColumn_3.Caption = "12";
			this.dataColumn_4.Caption = "13";
			this.dataColumn_5.Caption = "14";
			this.BejZehwIkLt.Caption = "15";
			this.dataColumn_6.Caption = "16";
			this.dataColumn_7.Caption = "17";
			this.dataColumn_8.Caption = "18";
			this.dataColumn_9.Caption = "19";
			this.dataColumn_10.Caption = "21";
			this.dataColumn_11.Caption = "22";
			this.dataColumn_12.Caption = "23";
			this.dataColumn_13.Caption = "24";
			this.dataColumn_14.Caption = "25";
			this.dataColumn_15.Caption = "26";
			this.dataColumn_16.Caption = "27";
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class205 method_4()
		{
			return (Class171.Class205)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class205(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class205);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate83_1 != null)
			{
				this.delegate83_1(this, new Class171.EventArgs79((Class171.Class205)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate83_0 != null)
			{
				this.delegate83_0(this, new Class171.EventArgs79((Class171.Class205)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate83_3 != null)
			{
				this.delegate83_3(this, new Class171.EventArgs79((Class171.Class205)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate83_2 != null)
			{
				this.delegate83_2(this, new Class171.EventArgs79((Class171.Class205)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5(Class171.Class205 class205_0)
		{
			base.Rows.Remove(class205_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tReportIterruptLVDataTable";
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

		private DataColumn BejZehwIkLt;

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

		private DataColumn dataColumn_33;

		private DataColumn dataColumn_34;

		private DataColumn dataColumn_35;

		private DataColumn dataColumn_36;

		private DataColumn dataColumn_37;

		private DataColumn dataColumn_38;

		[CompilerGenerated]
		private Class171.Delegate83 delegate83_0;

		[CompilerGenerated]
		private Class171.Delegate83 delegate83_1;

		[CompilerGenerated]
		private Class171.Delegate83 delegate83_2;

		[CompilerGenerated]
		private Class171.Delegate83 delegate83_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class181 : TypedTableBase<Class171.Class206>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class181()
		{
			//
			
			base.TableName = "ReportDailyDefect";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class181(DataTable dataTable_0)
		{
			//
			
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
		protected Class181(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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
		public DataColumn DataColumn_8
		{
			get
			{
				return this.dataColumn_9;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_9
		{
			get
			{
				return this.dataColumn_10;
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
		public Class171.Class206 this[int int_0]
		{
			get
			{
				return (Class171.Class206)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate84 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate84 @delegate = this.delegate84_0;
				Class171.Delegate84 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate84 value2 = (Class171.Delegate84)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate84>(ref this.delegate84_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate84 @delegate = this.delegate84_0;
				Class171.Delegate84 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate84 value2 = (Class171.Delegate84)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate84>(ref this.delegate84_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate84 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate84 @delegate = this.delegate84_1;
				Class171.Delegate84 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate84 value2 = (Class171.Delegate84)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate84>(ref this.delegate84_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate84 @delegate = this.delegate84_1;
				Class171.Delegate84 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate84 value2 = (Class171.Delegate84)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate84>(ref this.delegate84_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate84 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate84 @delegate = this.delegate84_2;
				Class171.Delegate84 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate84 value2 = (Class171.Delegate84)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate84>(ref this.delegate84_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate84 @delegate = this.delegate84_2;
				Class171.Delegate84 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate84 value2 = (Class171.Delegate84)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate84>(ref this.delegate84_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate84 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate84 @delegate = this.delegate84_3;
				Class171.Delegate84 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate84 value2 = (Class171.Delegate84)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate84>(ref this.delegate84_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate84 @delegate = this.delegate84_3;
				Class171.Delegate84 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate84 value2 = (Class171.Delegate84)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate84>(ref this.delegate84_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class206 class206_0)
		{
			base.Rows.Add(class206_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class206 method_1(int int_0, string string_0, DateTime dateTime_0, int int_1, string string_1, string string_2, decimal decimal_0, string string_3, DateTime dateTime_1, string string_4, bool bool_0)
		{
			Class171.Class206 @class = (Class171.Class206)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				string_0,
				dateTime_0,
				int_1,
				string_1,
				string_2,
				decimal_0,
				string_3,
				dateTime_1,
				string_4,
				bool_0
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class171.Class181 @class = (Class171.Class181)base.Clone();
			@class.method_2();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class181();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["numRequest"];
			this.dataColumn_2 = base.Columns["dateDoc"];
			this.dataColumn_3 = base.Columns["idDivisionApply"];
			this.dataColumn_4 = base.Columns["DivisionApply"];
			this.dataColumn_5 = base.Columns["DivisionInstruction"];
			this.dataColumn_6 = base.Columns["Value"];
			this.dataColumn_7 = base.Columns["numRequestParent"];
			this.dataColumn_8 = base.Columns["dateDocParent"];
			this.dataColumn_9 = base.Columns["typeDocParent"];
			this.dataColumn_10 = base.Columns["isApply"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("numRequest", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("dateDoc", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("idDivisionApply", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("DivisionApply", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("DivisionInstruction", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("Value", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("numRequestParent", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("dateDocParent", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("typeDocParent", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("isApply", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class206 method_4()
		{
			return (Class171.Class206)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class206(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class206);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate84_1 != null)
			{
				this.delegate84_1(this, new Class171.EventArgs80((Class171.Class206)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate84_0 != null)
			{
				this.delegate84_0(this, new Class171.EventArgs80((Class171.Class206)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate84_3 != null)
			{
				this.delegate84_3(this, new Class171.EventArgs80((Class171.Class206)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate84_2 != null)
			{
				this.delegate84_2(this, new Class171.EventArgs80((Class171.Class206)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5(Class171.Class206 class206_0)
		{
			base.Rows.Remove(class206_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "ReportDailyDefectDataTable";
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

		[CompilerGenerated]
		private Class171.Delegate84 delegate84_0;

		[CompilerGenerated]
		private Class171.Delegate84 delegate84_1;

		[CompilerGenerated]
		private Class171.Delegate84 delegate84_2;

		[CompilerGenerated]
		private Class171.Delegate84 delegate84_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class182 : TypedTableBase<Class171.Class207>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class182()
		{
			//
			
			base.TableName = "vJ_Damage";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class182(DataTable dataTable_0)
		{
			//
			
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
		protected Class182(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn phsZwXoscks
		{
			get
			{
				return this.dataColumn_8;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idDivisionColumn
		{
			get
			{
				return this.dataColumn_9;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_7
		{
			get
			{
				return this.dataColumn_10;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idSchmObjColumn
		{
			get
			{
				return this.dataColumn_11;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_8
		{
			get
			{
				return this.dataColumn_12;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idSubColumn
		{
			get
			{
				return this.dataColumn_13;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_9
		{
			get
			{
				return this.dataColumn_14;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_10
		{
			get
			{
				return this.dataColumn_15;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_11
		{
			get
			{
				return this.dataColumn_16;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_12
		{
			get
			{
				return this.dataColumn_17;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_13
		{
			get
			{
				return this.dataColumn_18;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_14
		{
			get
			{
				return this.dataColumn_19;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_15
		{
			get
			{
				return this.dataColumn_20;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_16
		{
			get
			{
				return this.dataColumn_21;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_17
		{
			get
			{
				return this.dataColumn_22;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_18
		{
			get
			{
				return this.dataColumn_23;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_19
		{
			get
			{
				return this.dataColumn_24;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_20
		{
			get
			{
				return this.dataColumn_25;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_21
		{
			get
			{
				return this.dataColumn_26;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_22
		{
			get
			{
				return this.dataColumn_27;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_23
		{
			get
			{
				return this.dataColumn_28;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_24
		{
			get
			{
				return this.dataColumn_29;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_25
		{
			get
			{
				return this.dataColumn_30;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_26
		{
			get
			{
				return this.dataColumn_31;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_27
		{
			get
			{
				return this.dataColumn_32;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_28
		{
			get
			{
				return this.dataColumn_33;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_29
		{
			get
			{
				return this.dataColumn_34;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_30
		{
			get
			{
				return this.dataColumn_35;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_31
		{
			get
			{
				return this.dataColumn_36;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_32
		{
			get
			{
				return this.dataColumn_37;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_33
		{
			get
			{
				return this.dataColumn_38;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_34
		{
			get
			{
				return this.dataColumn_39;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_35
		{
			get
			{
				return this.dataColumn_40;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_36
		{
			get
			{
				return this.dataColumn_41;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_37
		{
			get
			{
				return this.dataColumn_42;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_38
		{
			get
			{
				return this.dataColumn_43;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_39
		{
			get
			{
				return this.dataColumn_44;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_40
		{
			get
			{
				return this.dataColumn_45;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_41
		{
			get
			{
				return this.dataColumn_46;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_42
		{
			get
			{
				return this.dataColumn_47;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_43
		{
			get
			{
				return this.dataColumn_48;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_44
		{
			get
			{
				return this.dataColumn_49;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_45
		{
			get
			{
				return this.dataColumn_50;
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
		public Class171.Class207 this[int int_0]
		{
			get
			{
				return (Class171.Class207)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate85 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate85 @delegate = this.delegate85_0;
				Class171.Delegate85 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate85 value2 = (Class171.Delegate85)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate85>(ref this.delegate85_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate85 @delegate = this.delegate85_0;
				Class171.Delegate85 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate85 value2 = (Class171.Delegate85)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate85>(ref this.delegate85_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate85 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate85 @delegate = this.delegate85_1;
				Class171.Delegate85 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate85 value2 = (Class171.Delegate85)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate85>(ref this.delegate85_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate85 @delegate = this.delegate85_1;
				Class171.Delegate85 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate85 value2 = (Class171.Delegate85)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate85>(ref this.delegate85_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate85 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate85 @delegate = this.delegate85_2;
				Class171.Delegate85 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate85 value2 = (Class171.Delegate85)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate85>(ref this.delegate85_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate85 @delegate = this.delegate85_2;
				Class171.Delegate85 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate85 value2 = (Class171.Delegate85)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate85>(ref this.delegate85_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate85 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate85 @delegate = this.delegate85_3;
				Class171.Delegate85 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate85 value2 = (Class171.Delegate85)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate85>(ref this.delegate85_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate85 @delegate = this.delegate85_3;
				Class171.Delegate85 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate85 value2 = (Class171.Delegate85)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate85>(ref this.delegate85_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class207 class207_0)
		{
			base.Rows.Add(class207_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class207 IvtZwmowZwa(int int_0, int int_1, DateTime dateTime_0, DateTime dateTime_1, string string_0, int int_2, string string_1, int int_3, string string_2, int int_4, string string_3, int int_5, string string_4, int int_6, string string_5, int int_7, string string_6, int int_8, string string_7, int int_9, string string_8, string string_9, bool bool_0, int int_10, string string_10, DateTime dateTime_2, int int_11, string string_11, bool bool_1, int int_12, string string_12, DateTime dateTime_3, string string_13, decimal decimal_0, string string_14, int int_13, bool bool_2, string string_15, string string_16, string string_17, string string_18, string string_19, string string_20, string string_21, string string_22, string string_23, bool bool_3, string string_24, string string_25, string string_26, bool bool_4)
		{
			Class171.Class207 @class = (Class171.Class207)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				int_1,
				dateTime_0,
				dateTime_1,
				string_0,
				int_2,
				string_1,
				int_3,
				string_2,
				int_4,
				string_3,
				int_5,
				string_4,
				int_6,
				string_5,
				int_7,
				string_6,
				int_8,
				string_7,
				int_9,
				string_8,
				string_9,
				bool_0,
				int_10,
				string_10,
				dateTime_2,
				int_11,
				string_11,
				bool_1,
				int_12,
				string_12,
				dateTime_3,
				string_13,
				decimal_0,
				string_14,
				int_13,
				bool_2,
				string_15,
				string_16,
				string_17,
				string_18,
				string_19,
				string_20,
				string_21,
				string_22,
				string_23,
				bool_3,
				string_24,
				string_25,
				string_26,
				bool_4
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class207 method_1(int int_0)
		{
			return (Class171.Class207)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.Class182 @class = (Class171.Class182)base.Clone();
			@class.method_2();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class182();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["numDoc"];
			this.dataColumn_2 = base.Columns["dateDoc"];
			this.dataColumn_3 = base.Columns["datePlanEnd"];
			this.dataColumn_4 = base.Columns["numrequest"];
			this.dataColumn_5 = base.Columns["TypeDoc"];
			this.dataColumn_6 = base.Columns["TypeDocName"];
			this.dataColumn_7 = base.Columns["idCompiler"];
			this.dataColumn_8 = base.Columns["compiler"];
			this.dataColumn_9 = base.Columns["idDivision"];
			this.dataColumn_10 = base.Columns["Division"];
			this.dataColumn_11 = base.Columns["idSchmObj"];
			this.dataColumn_12 = base.Columns["schmObjName"];
			this.dataColumn_13 = base.Columns["idSub"];
			this.dataColumn_14 = base.Columns["NetRegionSub"];
			this.dataColumn_15 = base.Columns["idMap"];
			this.dataColumn_16 = base.Columns["defectLocation"];
			this.dataColumn_17 = base.Columns["idReason"];
			this.dataColumn_18 = base.Columns["Reason"];
			this.dataColumn_19 = base.Columns["idCompletedWork"];
			this.dataColumn_20 = base.Columns["completedWork"];
			this.dataColumn_21 = base.Columns["ComletedWorkText"];
			this.dataColumn_22 = base.Columns["isApply"];
			this.dataColumn_23 = base.Columns["idWorkerApply"];
			this.dataColumn_24 = base.Columns["workerApply"];
			this.dataColumn_25 = base.Columns["dateApply"];
			this.dataColumn_26 = base.Columns["idDivisionApply"];
			this.dataColumn_27 = base.Columns["DivisionApply"];
			this.dataColumn_28 = base.Columns["isLaboratory"];
			this.dataColumn_29 = base.Columns["idParent"];
			this.dataColumn_30 = base.Columns["ownerName"];
			this.dataColumn_31 = base.Columns["dateOwner"];
			this.dataColumn_32 = base.Columns["KodPTSStr"];
			this.dataColumn_33 = base.Columns["KodPTS"];
			this.dataColumn_34 = base.Columns["Instruction"];
			this.dataColumn_35 = base.Columns["idReqForRepair"];
			this.dataColumn_36 = base.Columns["deleted"];
			this.dataColumn_37 = base.Columns["numcrash"];
			this.dataColumn_38 = base.Columns["signCrashType"];
			this.dataColumn_39 = base.Columns["signCrashName"];
			this.dataColumn_40 = base.Columns["typeEquip"];
			this.dataColumn_41 = base.Columns["typeEquipName"];
			this.dataColumn_42 = base.Columns["reasonCrashEquipType"];
			this.dataColumn_43 = base.Columns["reasonCrashEquipName"];
			this.dataColumn_44 = base.Columns["reasonCrashType"];
			this.dataColumn_45 = base.Columns["reasonCrashName"];
			this.dataColumn_46 = base.Columns["isNoSESNO"];
			this.dataColumn_47 = base.Columns["Character"];
			this.dataColumn_48 = base.Columns["City"];
			this.dataColumn_49 = base.Columns["Street"];
			this.dataColumn_50 = base.Columns["is81"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("numDoc", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("dateDoc", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("datePlanEnd", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("numrequest", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("TypeDoc", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("TypeDocName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("idCompiler", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("compiler", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("idDivision", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("Division", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("schmObjName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			this.dataColumn_13 = new DataColumn("idSub", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_13);
			this.dataColumn_14 = new DataColumn("NetRegionSub", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_14);
			this.dataColumn_15 = new DataColumn("idMap", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_15);
			this.dataColumn_16 = new DataColumn("defectLocation", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_16);
			this.dataColumn_17 = new DataColumn("idReason", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_17);
			this.dataColumn_18 = new DataColumn("Reason", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_18);
			this.dataColumn_19 = new DataColumn("idCompletedWork", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_19);
			this.dataColumn_20 = new DataColumn("completedWork", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_20);
			this.dataColumn_21 = new DataColumn("ComletedWorkText", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_21);
			this.dataColumn_22 = new DataColumn("isApply", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_22);
			this.dataColumn_23 = new DataColumn("idWorkerApply", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_23);
			this.dataColumn_24 = new DataColumn("workerApply", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_24);
			this.dataColumn_25 = new DataColumn("dateApply", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_25);
			this.dataColumn_26 = new DataColumn("idDivisionApply", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_26);
			this.dataColumn_27 = new DataColumn("DivisionApply", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_27);
			this.dataColumn_28 = new DataColumn("isLaboratory", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_28);
			this.dataColumn_29 = new DataColumn("idParent", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_29);
			this.dataColumn_30 = new DataColumn("ownerName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_30);
			this.dataColumn_31 = new DataColumn("dateOwner", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_31);
			this.dataColumn_32 = new DataColumn("KodPTSStr", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_32);
			this.dataColumn_33 = new DataColumn("KodPTS", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_33);
			this.dataColumn_34 = new DataColumn("Instruction", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_34);
			this.dataColumn_35 = new DataColumn("idReqForRepair", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_35);
			this.dataColumn_36 = new DataColumn("deleted", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_36);
			this.dataColumn_37 = new DataColumn("numcrash", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_37);
			this.dataColumn_38 = new DataColumn("signCrashType", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_38);
			this.dataColumn_39 = new DataColumn("signCrashName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_39);
			this.dataColumn_40 = new DataColumn("typeEquip", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_40);
			this.dataColumn_41 = new DataColumn("typeEquipName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_41);
			this.dataColumn_42 = new DataColumn("reasonCrashEquipType", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_42);
			this.dataColumn_43 = new DataColumn("reasonCrashEquipName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_43);
			this.dataColumn_44 = new DataColumn("reasonCrashType", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_44);
			this.dataColumn_45 = new DataColumn("reasonCrashName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_45);
			this.dataColumn_46 = new DataColumn("isNoSESNO", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_46);
			this.dataColumn_47 = new DataColumn("Character", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_47);
			this.dataColumn_48 = new DataColumn("City", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_48);
			this.dataColumn_49 = new DataColumn("Street", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_49);
			this.dataColumn_50 = new DataColumn("is81", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_50);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.Unique = true;
			this.dataColumn_4.MaxLength = 50;
			this.dataColumn_5.AllowDBNull = false;
			this.dataColumn_6.MaxLength = 100;
			this.dataColumn_8.ReadOnly = true;
			this.dataColumn_8.MaxLength = 35;
			this.dataColumn_10.MaxLength = 100;
			this.dataColumn_12.ReadOnly = true;
			this.dataColumn_12.MaxLength = 1841;
			this.dataColumn_13.ReadOnly = true;
			this.dataColumn_16.ReadOnly = true;
			this.dataColumn_16.MaxLength = 1203;
			this.dataColumn_18.MaxLength = 100;
			this.dataColumn_20.MaxLength = 100;
			this.dataColumn_21.MaxLength = 2028;
			this.dataColumn_24.ReadOnly = true;
			this.dataColumn_24.MaxLength = 35;
			this.dataColumn_27.MaxLength = 100;
			this.dataColumn_30.MaxLength = 50;
			this.dataColumn_34.ReadOnly = true;
			this.dataColumn_34.MaxLength = 4058;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class207 method_4()
		{
			return (Class171.Class207)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class207(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class207);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate85_1 != null)
			{
				this.delegate85_1(this, new Class171.EventArgs81((Class171.Class207)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate85_0 != null)
			{
				this.delegate85_0(this, new Class171.EventArgs81((Class171.Class207)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate85_3 != null)
			{
				this.delegate85_3(this, new Class171.EventArgs81((Class171.Class207)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate85_2 != null)
			{
				this.delegate85_2(this, new Class171.EventArgs81((Class171.Class207)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5(Class171.Class207 class207_0)
		{
			base.Rows.Remove(class207_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "vJ_DamageDataTable";
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

		private DataColumn dataColumn_33;

		private DataColumn dataColumn_34;

		private DataColumn dataColumn_35;

		private DataColumn dataColumn_36;

		private DataColumn dataColumn_37;

		private DataColumn dataColumn_38;

		private DataColumn dataColumn_39;

		private DataColumn dataColumn_40;

		private DataColumn dataColumn_41;

		private DataColumn dataColumn_42;

		private DataColumn dataColumn_43;

		private DataColumn dataColumn_44;

		private DataColumn dataColumn_45;

		private DataColumn dataColumn_46;

		private DataColumn dataColumn_47;

		private DataColumn dataColumn_48;

		private DataColumn dataColumn_49;

		private DataColumn dataColumn_50;

		[CompilerGenerated]
		private Class171.Delegate85 delegate85_0;

		[CompilerGenerated]
		private Class171.Delegate85 delegate85_1;

		[CompilerGenerated]
		private Class171.Delegate85 delegate85_2;

		[CompilerGenerated]
		private Class171.Delegate85 delegate85_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class183 : TypedTableBase<Class171.Class208>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class183()
		{
			//
			
			base.TableName = "ReportDailyHV";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class183(DataTable dataTable_0)
		{
			//
			
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
		protected Class183(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_9
		{
			get
			{
				return this.dataColumn_10;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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
		public Class171.Class208 this[int int_0]
		{
			get
			{
				return (Class171.Class208)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate86 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate86 @delegate = this.delegate86_0;
				Class171.Delegate86 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate86 value2 = (Class171.Delegate86)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate86>(ref this.delegate86_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate86 @delegate = this.delegate86_0;
				Class171.Delegate86 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate86 value2 = (Class171.Delegate86)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate86>(ref this.delegate86_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate86 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate86 @delegate = this.delegate86_1;
				Class171.Delegate86 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate86 value2 = (Class171.Delegate86)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate86>(ref this.delegate86_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate86 @delegate = this.delegate86_1;
				Class171.Delegate86 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate86 value2 = (Class171.Delegate86)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate86>(ref this.delegate86_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate86 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate86 @delegate = this.delegate86_2;
				Class171.Delegate86 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate86 value2 = (Class171.Delegate86)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate86>(ref this.delegate86_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate86 @delegate = this.delegate86_2;
				Class171.Delegate86 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate86 value2 = (Class171.Delegate86)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate86>(ref this.delegate86_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate86 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate86 @delegate = this.delegate86_3;
				Class171.Delegate86 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate86 value2 = (Class171.Delegate86)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate86>(ref this.delegate86_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate86 @delegate = this.delegate86_3;
				Class171.Delegate86 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate86 value2 = (Class171.Delegate86)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate86>(ref this.delegate86_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class208 class208_0)
		{
			base.Rows.Add(class208_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class208 method_1(int int_0, string string_0, string string_1, string string_2, decimal decimal_0, int int_1, decimal decimal_1, DateTime dateTime_0, DateTime dateTime_1, string string_3, decimal decimal_2, string string_4, string string_5, string string_6, string string_7)
		{
			Class171.Class208 @class = (Class171.Class208)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				string_0,
				string_1,
				string_2,
				decimal_0,
				int_1,
				decimal_1,
				dateTime_0,
				dateTime_1,
				string_3,
				decimal_2,
				string_4,
				string_5,
				string_6,
				string_7
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.Class183 @class = (Class171.Class183)base.Clone();
			@class.method_2();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class183();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["numRequest"];
			this.dataColumn_2 = base.Columns["schmObjName"];
			this.dataColumn_3 = base.Columns["subscriber"];
			this.dataColumn_4 = base.Columns["PowerA"];
			this.dataColumn_5 = base.Columns["CountSchmObj"];
			this.dataColumn_6 = base.Columns["ConnectedPower"];
			this.dataColumn_7 = base.Columns["dateDoc"];
			this.dataColumn_8 = base.Columns["dateApply"];
			this.dataColumn_9 = base.Columns["typeRZA"];
			this.dataColumn_10 = base.Columns["NoAdmissionKWT"];
			this.dataColumn_11 = base.Columns["reasonAndLocation"];
			this.dataColumn_12 = base.Columns["Character"];
			this.dataColumn_13 = base.Columns["completedWork"];
			this.dataColumn_14 = base.Columns["Compiler"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("numRequest", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("schmObjName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("subscriber", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("PowerA", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("CountSchmObj", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("ConnectedPower", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("dateDoc", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("dateApply", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("typeRZA", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("NoAdmissionKWT", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("reasonAndLocation", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("Character", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			this.dataColumn_13 = new DataColumn("completedWork", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_13);
			this.dataColumn_14 = new DataColumn("Compiler", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_14);
			this.dataColumn_2.Caption = "dateDoc";
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class208 method_4()
		{
			return (Class171.Class208)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class208(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class208);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate86_1 != null)
			{
				this.delegate86_1(this, new Class171.EventArgs82((Class171.Class208)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate86_0 != null)
			{
				this.delegate86_0(this, new Class171.EventArgs82((Class171.Class208)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate86_3 != null)
			{
				this.delegate86_3(this, new Class171.EventArgs82((Class171.Class208)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate86_2 != null)
			{
				this.delegate86_2(this, new Class171.EventArgs82((Class171.Class208)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5(Class171.Class208 class208_0)
		{
			base.Rows.Remove(class208_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "ReportDailyHVDataTable";
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

		[CompilerGenerated]
		private Class171.Delegate86 delegate86_0;

		[CompilerGenerated]
		private Class171.Delegate86 delegate86_1;

		[CompilerGenerated]
		private Class171.Delegate86 delegate86_2;

		[CompilerGenerated]
		private Class171.Delegate86 delegate86_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class tJ_DamageCharacterDataTable : TypedTableBase<Class171.Class209>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public tJ_DamageCharacterDataTable()
		{
			//
			
			base.TableName = "tJ_DamageCharacter";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal tJ_DamageCharacterDataTable(DataTable dataTable_0)
		{
			//
			
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
		protected tJ_DamageCharacterDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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
		public DataColumn idDamageColumn
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_0
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_2
		{
			get
			{
				return this.dataColumn_4;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idSchmObjColumn
		{
			get
			{
				return this.dataColumn_5;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idLineSectionColumn
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_8
		{
			get
			{
				return this.dataColumn_12;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_13
		{
			get
			{
				return this.dataColumn_17;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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
		public DataColumn DataColumn_17
		{
			get
			{
				return this.dataColumn_21;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_18
		{
			get
			{
				return this.dataColumn_22;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_19
		{
			get
			{
				return this.dataColumn_23;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_20
		{
			get
			{
				return this.dataColumn_24;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_21
		{
			get
			{
				return this.dataColumn_25;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_22
		{
			get
			{
				return this.dataColumn_26;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_23
		{
			get
			{
				return this.dataColumn_27;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_24
		{
			get
			{
				return this.dataColumn_28;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_25
		{
			get
			{
				return this.dataColumn_29;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_26
		{
			get
			{
				return this.dataColumn_30;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_27
		{
			get
			{
				return this.dataColumn_31;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_28
		{
			get
			{
				return this.dataColumn_32;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_29
		{
			get
			{
				return this.dataColumn_33;
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
		public Class171.Class209 this[int int_0]
		{
			get
			{
				return (Class171.Class209)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate87 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate87 @delegate = this.delegate87_0;
				Class171.Delegate87 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate87 value2 = (Class171.Delegate87)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate87>(ref this.delegate87_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate87 @delegate = this.delegate87_0;
				Class171.Delegate87 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate87 value2 = (Class171.Delegate87)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate87>(ref this.delegate87_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate87 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate87 @delegate = this.delegate87_1;
				Class171.Delegate87 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate87 value2 = (Class171.Delegate87)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate87>(ref this.delegate87_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate87 @delegate = this.delegate87_1;
				Class171.Delegate87 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate87 value2 = (Class171.Delegate87)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate87>(ref this.delegate87_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate87 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate87 @delegate = this.delegate87_2;
				Class171.Delegate87 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate87 value2 = (Class171.Delegate87)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate87>(ref this.delegate87_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate87 @delegate = this.delegate87_2;
				Class171.Delegate87 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate87 value2 = (Class171.Delegate87)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate87>(ref this.delegate87_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate87 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate87 @delegate = this.delegate87_3;
				Class171.Delegate87 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate87 value2 = (Class171.Delegate87)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate87>(ref this.delegate87_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate87 @delegate = this.delegate87_3;
				Class171.Delegate87 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate87 value2 = (Class171.Delegate87)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate87>(ref this.delegate87_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class209 class209_0)
		{
			base.Rows.Add(class209_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class209 method_1(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, string string_0, int int_7, int int_8, int int_9, int int_10, string string_1, int int_11, int int_12, bool bool_0, string string_2, string string_3, short short_0, int int_13, int int_14, int int_15, int int_16, int int_17, int int_18, int int_19, int int_20, string string_4, int int_21, int int_22, DateTime dateTime_0, DateTime dateTime_1, string string_5)
		{
			Class171.Class209 @class = (Class171.Class209)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				int_0,
				int_1,
				int_2,
				int_3,
				int_4,
				int_5,
				int_6,
				string_0,
				int_7,
				int_8,
				int_9,
				int_10,
				string_1,
				int_11,
				int_12,
				bool_0,
				string_2,
				string_3,
				short_0,
				int_13,
				int_14,
				int_15,
				int_16,
				int_17,
				int_18,
				int_19,
				int_20,
				string_4,
				int_21,
				int_22,
				dateTime_0,
				dateTime_1,
				string_5
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class209 method_2(int int_0)
		{
			return (Class171.Class209)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.tJ_DamageCharacterDataTable @class = (Class171.tJ_DamageCharacterDataTable)base.Clone();
			@class.method_3();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.tJ_DamageCharacterDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["idDamage"];
			this.dataColumn_2 = base.Columns["col1"];
			this.dataColumn_3 = base.Columns["col2"];
			this.dataColumn_4 = base.Columns["col3"];
			this.dataColumn_5 = base.Columns["idSchmObj"];
			this.dataColumn_6 = base.Columns["idLineSection"];
			this.dataColumn_7 = base.Columns["idCharacterParent"];
			this.dataColumn_8 = base.Columns["Parameters"];
			this.dataColumn_9 = base.Columns["idMark"];
			this.dataColumn_10 = base.Columns["idParameters"];
			this.dataColumn_11 = base.Columns["idVoltage"];
			this.dataColumn_12 = base.Columns["nodeDetail"];
			this.dataColumn_13 = base.Columns["nodeDetailTxt"];
			this.dataColumn_14 = base.Columns["CountDefectEquipment"];
			this.dataColumn_15 = base.Columns["idVoltageSeti"];
			this.dataColumn_16 = base.Columns["AutoProtect"];
			this.dataColumn_17 = base.Columns["Manufacturer"];
			this.dataColumn_18 = base.Columns["FactoryNumber"];
			this.dataColumn_19 = base.Columns["YearManufacture"];
			this.dataColumn_20 = base.Columns["idNeutralState"];
			this.dataColumn_21 = base.Columns["ClauseFail"];
			this.dataColumn_22 = base.Columns["LengthOverload"];
			this.dataColumn_23 = base.Columns["LengthLine"];
			this.dataColumn_24 = base.Columns["idMaterial"];
			this.dataColumn_25 = base.Columns["ClauseWork"];
			this.dataColumn_26 = base.Columns["idCharacterDamage"];
			this.dataColumn_27 = base.Columns["idReasonDamage"];
			this.dataColumn_28 = base.Columns["AssociatedFact"];
			this.dataColumn_29 = base.Columns["yearBegEquipment"];
			this.dataColumn_30 = base.Columns["lenghtWorkEquipment"];
			this.dataColumn_31 = base.Columns["LastDateTest"];
			this.dataColumn_32 = base.Columns["timeRecovery"];
			this.dataColumn_33 = base.Columns["SchmObjName"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("idDamage", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("col1", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("col2", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("col3", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("idLineSection", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("idCharacterParent", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("Parameters", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("idMark", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("idParameters", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("idVoltage", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("nodeDetail", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			this.dataColumn_13 = new DataColumn("nodeDetailTxt", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_13);
			this.dataColumn_14 = new DataColumn("CountDefectEquipment", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_14);
			this.dataColumn_15 = new DataColumn("idVoltageSeti", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_15);
			this.dataColumn_16 = new DataColumn("AutoProtect", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_16);
			this.dataColumn_17 = new DataColumn("Manufacturer", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_17);
			this.dataColumn_18 = new DataColumn("FactoryNumber", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_18);
			this.dataColumn_19 = new DataColumn("YearManufacture", typeof(short), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_19);
			this.dataColumn_20 = new DataColumn("idNeutralState", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_20);
			this.dataColumn_21 = new DataColumn("ClauseFail", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_21);
			this.dataColumn_22 = new DataColumn("LengthOverload", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_22);
			this.dataColumn_23 = new DataColumn("LengthLine", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_23);
			this.dataColumn_24 = new DataColumn("idMaterial", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_24);
			this.dataColumn_25 = new DataColumn("ClauseWork", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_25);
			this.dataColumn_26 = new DataColumn("idCharacterDamage", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_26);
			this.dataColumn_27 = new DataColumn("idReasonDamage", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_27);
			this.dataColumn_28 = new DataColumn("AssociatedFact", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_28);
			this.dataColumn_29 = new DataColumn("yearBegEquipment", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_29);
			this.dataColumn_30 = new DataColumn("lenghtWorkEquipment", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_30);
			this.dataColumn_31 = new DataColumn("LastDateTest", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_31);
			this.dataColumn_32 = new DataColumn("timeRecovery", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_32);
			this.dataColumn_33 = new DataColumn("SchmObjName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_33);
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
			this.dataColumn_8.MaxLength = int.MaxValue;
			this.dataColumn_13.MaxLength = 256;
			this.dataColumn_17.MaxLength = 128;
			this.dataColumn_18.MaxLength = 128;
			this.dataColumn_28.MaxLength = 512;
			this.dataColumn_33.MaxLength = 256;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class209 method_5()
		{
			return (Class171.Class209)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class209(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class209);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate87_1 != null)
			{
				this.delegate87_1(this, new Class171.EventArgs83((Class171.Class209)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate87_0 != null)
			{
				this.delegate87_0(this, new Class171.EventArgs83((Class171.Class209)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate87_3 != null)
			{
				this.delegate87_3(this, new Class171.EventArgs83((Class171.Class209)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate87_2 != null)
			{
				this.delegate87_2(this, new Class171.EventArgs83((Class171.Class209)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_6(Class171.Class209 class209_0)
		{
			base.Rows.Remove(class209_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tJ_DamageCharacterDataTable";
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

		private DataColumn dataColumn_33;

		[CompilerGenerated]
		private Class171.Delegate87 delegate87_0;

		[CompilerGenerated]
		private Class171.Delegate87 delegate87_1;

		[CompilerGenerated]
		private Class171.Delegate87 delegate87_2;

		[CompilerGenerated]
		private Class171.Delegate87 delegate87_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class185 : TypedTableBase<Class171.Class210>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class185()
		{
			//
			
			base.TableName = "tJ_DamageActDetection";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class185(DataTable dataTable_0)
		{
			//
			
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
		protected Class185(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idDamageColumn
		{
			get
			{
				return this.dataColumn_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idOrgColumn
		{
			get
			{
				return this.dataColumn_1;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_0
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_2
		{
			get
			{
				return this.dataColumn_4;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_3
		{
			get
			{
				return this.dataColumn_5;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_4
		{
			get
			{
				return this.dataColumn_6;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_5
		{
			get
			{
				return this.dataColumn_7;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_6
		{
			get
			{
				return this.dataColumn_8;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_7
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_10
		{
			get
			{
				return this.dataColumn_12;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_17
		{
			get
			{
				return this.dataColumn_19;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
		public Class171.Class210 this[int int_0]
		{
			get
			{
				return (Class171.Class210)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate88 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate88 @delegate = this.delegate88_0;
				Class171.Delegate88 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate88 value2 = (Class171.Delegate88)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate88>(ref this.delegate88_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate88 @delegate = this.delegate88_0;
				Class171.Delegate88 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate88 value2 = (Class171.Delegate88)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate88>(ref this.delegate88_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate88 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate88 @delegate = this.delegate88_1;
				Class171.Delegate88 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate88 value2 = (Class171.Delegate88)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate88>(ref this.delegate88_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate88 @delegate = this.delegate88_1;
				Class171.Delegate88 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate88 value2 = (Class171.Delegate88)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate88>(ref this.delegate88_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate88 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate88 @delegate = this.delegate88_2;
				Class171.Delegate88 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate88 value2 = (Class171.Delegate88)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate88>(ref this.delegate88_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate88 @delegate = this.delegate88_2;
				Class171.Delegate88 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate88 value2 = (Class171.Delegate88)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate88>(ref this.delegate88_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate88 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate88 @delegate = this.delegate88_3;
				Class171.Delegate88 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate88 value2 = (Class171.Delegate88)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate88>(ref this.delegate88_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate88 @delegate = this.delegate88_3;
				Class171.Delegate88 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate88 value2 = (Class171.Delegate88)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate88>(ref this.delegate88_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class210 class210_0)
		{
			base.Rows.Add(class210_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class210 method_1(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, DateTime dateTime_0, DateTime dateTime_1, int int_6, bool bool_0, bool bool_1, string string_0, int int_7, string string_1, int int_8, int int_9, int int_10, string string_2, string string_3, string string_4, string string_5, string string_6)
		{
			Class171.Class210 @class = (Class171.Class210)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				int_1,
				int_2,
				int_3,
				int_4,
				int_5,
				dateTime_0,
				dateTime_1,
				int_6,
				bool_0,
				bool_1,
				string_0,
				int_7,
				string_1,
				int_8,
				int_9,
				int_10,
				string_2,
				string_3,
				string_4,
				string_5,
				string_6
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class210 method_2(int int_0)
		{
			return (Class171.Class210)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class171.Class185 @class = (Class171.Class185)base.Clone();
			@class.method_3();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class185();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["idDamage"];
			this.dataColumn_1 = base.Columns["idOrg"];
			this.dataColumn_2 = base.Columns["idSignCrash"];
			this.dataColumn_3 = base.Columns["idTypeEquipment"];
			this.dataColumn_4 = base.Columns["idReasonCrash"];
			this.dataColumn_5 = base.Columns["idReasonCrashEquipment"];
			this.dataColumn_6 = base.Columns["dateEndCrashLocal"];
			this.dataColumn_7 = base.Columns["dateEndCrashMoscow"];
			this.dataColumn_8 = base.Columns["idStatusBeforeCrash"];
			this.dataColumn_9 = base.Columns["isCrash"];
			this.dataColumn_10 = base.Columns["isNoOff"];
			this.dataColumn_11 = base.Columns["NoCrashMeasure"];
			this.dataColumn_12 = base.Columns["idStatusCurrentCrash"];
			this.dataColumn_13 = base.Columns["Defection"];
			this.dataColumn_14 = base.Columns["idReasonBeginCrash"];
			this.dataColumn_15 = base.Columns["idClassifierDamage"];
			this.dataColumn_16 = base.Columns["idFault"];
			this.dataColumn_17 = base.Columns["Comission"];
			this.dataColumn_18 = base.Columns["TotalComission"];
			this.dataColumn_19 = base.Columns["numCrash"];
			this.dataColumn_20 = base.Columns["StatusCurrentCrash"];
			this.dataColumn_21 = base.Columns["ReasonBeginCrash"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("idDamage", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("idOrg", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("idSignCrash", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("idTypeEquipment", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("idReasonCrash", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("idReasonCrashEquipment", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("dateEndCrashLocal", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("dateEndCrashMoscow", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("idStatusBeforeCrash", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("isCrash", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("isNoOff", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("NoCrashMeasure", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("idStatusCurrentCrash", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			this.dataColumn_13 = new DataColumn("Defection", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_13);
			this.dataColumn_14 = new DataColumn("idReasonBeginCrash", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_14);
			this.dataColumn_15 = new DataColumn("idClassifierDamage", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_15);
			this.dataColumn_16 = new DataColumn("idFault", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_16);
			this.dataColumn_17 = new DataColumn("Comission", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_17);
			this.dataColumn_18 = new DataColumn("TotalComission", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_18);
			this.dataColumn_19 = new DataColumn("numCrash", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_19);
			this.dataColumn_20 = new DataColumn("StatusCurrentCrash", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_20);
			this.dataColumn_21 = new DataColumn("ReasonBeginCrash", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_21);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.Unique = true;
			this.dataColumn_11.MaxLength = int.MaxValue;
			this.dataColumn_13.MaxLength = int.MaxValue;
			this.dataColumn_17.MaxLength = int.MaxValue;
			this.dataColumn_18.MaxLength = 2000;
			this.dataColumn_20.MaxLength = 2000;
			this.dataColumn_21.MaxLength = 2000;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class210 method_5()
		{
			return (Class171.Class210)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class210(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class210);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate88_1 != null)
			{
				this.delegate88_1(this, new Class171.EventArgs84((Class171.Class210)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate88_0 != null)
			{
				this.delegate88_0(this, new Class171.EventArgs84((Class171.Class210)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate88_3 != null)
			{
				this.delegate88_3(this, new Class171.EventArgs84((Class171.Class210)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate88_2 != null)
			{
				this.delegate88_2(this, new Class171.EventArgs84((Class171.Class210)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_6(Class171.Class210 class210_0)
		{
			base.Rows.Remove(class210_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tJ_DamageActDetectionDataTable";
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

		[CompilerGenerated]
		private Class171.Delegate88 delegate88_0;

		[CompilerGenerated]
		private Class171.Delegate88 delegate88_1;

		[CompilerGenerated]
		private Class171.Delegate88 delegate88_2;

		[CompilerGenerated]
		private Class171.Delegate88 delegate88_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class186 : TypedTableBase<Class171.Class211>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class186()
		{
			//
			
			base.TableName = "table23";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class186(DataTable dataTable_0)
		{
			//
			
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
		protected Class186(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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
		public Class171.Class211 this[int int_0]
		{
			get
			{
				return (Class171.Class211)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate89 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate89 @delegate = this.delegate89_0;
				Class171.Delegate89 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate89 value2 = (Class171.Delegate89)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate89>(ref this.delegate89_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate89 @delegate = this.delegate89_0;
				Class171.Delegate89 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate89 value2 = (Class171.Delegate89)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate89>(ref this.delegate89_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate89 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate89 @delegate = this.delegate89_1;
				Class171.Delegate89 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate89 value2 = (Class171.Delegate89)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate89>(ref this.delegate89_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate89 @delegate = this.delegate89_1;
				Class171.Delegate89 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate89 value2 = (Class171.Delegate89)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate89>(ref this.delegate89_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate89 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate89 @delegate = this.delegate89_2;
				Class171.Delegate89 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate89 value2 = (Class171.Delegate89)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate89>(ref this.delegate89_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate89 @delegate = this.delegate89_2;
				Class171.Delegate89 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate89 value2 = (Class171.Delegate89)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate89>(ref this.delegate89_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate89 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate89 @delegate = this.delegate89_3;
				Class171.Delegate89 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate89 value2 = (Class171.Delegate89)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate89>(ref this.delegate89_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate89 @delegate = this.delegate89_3;
				Class171.Delegate89 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate89 value2 = (Class171.Delegate89)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate89>(ref this.delegate89_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class171.Class211 class211_0)
		{
			base.Rows.Add(class211_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class211 method_1(string string_0, string string_1, string string_2, string string_3)
		{
			Class171.Class211 @class = (Class171.Class211)base.NewRow();
			object[] itemArray = new object[]
			{
				string_0,
				string_1,
				string_2,
				string_3
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.Class186 @class = (Class171.Class186)base.Clone();
			@class.method_2();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class186();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["Description"];
			this.dataColumn_1 = base.Columns["NPA"];
			this.dataColumn_2 = base.Columns["PunktNPA"];
			this.dataColumn_3 = base.Columns["Org"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("Description", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("NPA", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("PunktNPA", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("Org", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class211 method_4()
		{
			return (Class171.Class211)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class211(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class211);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate89_1 != null)
			{
				this.delegate89_1(this, new Class171.EventArgs85((Class171.Class211)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate89_0 != null)
			{
				this.delegate89_0(this, new Class171.EventArgs85((Class171.Class211)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate89_3 != null)
			{
				this.delegate89_3(this, new Class171.EventArgs85((Class171.Class211)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate89_2 != null)
			{
				this.delegate89_2(this, new Class171.EventArgs85((Class171.Class211)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5(Class171.Class211 class211_0)
		{
			base.Rows.Remove(class211_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "table23DataTable";
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
		private Class171.Delegate89 delegate89_0;

		[CompilerGenerated]
		private Class171.Delegate89 delegate89_1;

		[CompilerGenerated]
		private Class171.Delegate89 delegate89_2;

		[CompilerGenerated]
		private Class171.Delegate89 delegate89_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class187 : TypedTableBase<Class171.Class212>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class187()
		{
			//
			
			base.TableName = "table31";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class187(DataTable dataTable_0)
		{
			//
			
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
		protected Class187(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_2();
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
		public Class171.Class212 this[int int_0]
		{
			get
			{
				return (Class171.Class212)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate90 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate90 @delegate = this.delegate90_0;
				Class171.Delegate90 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate90 value2 = (Class171.Delegate90)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate90>(ref this.delegate90_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate90 @delegate = this.delegate90_0;
				Class171.Delegate90 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate90 value2 = (Class171.Delegate90)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate90>(ref this.delegate90_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate90 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate90 @delegate = this.delegate90_1;
				Class171.Delegate90 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate90 value2 = (Class171.Delegate90)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate90>(ref this.delegate90_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate90 @delegate = this.delegate90_1;
				Class171.Delegate90 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate90 value2 = (Class171.Delegate90)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate90>(ref this.delegate90_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate90 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate90 @delegate = this.delegate90_2;
				Class171.Delegate90 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate90 value2 = (Class171.Delegate90)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate90>(ref this.delegate90_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate90 @delegate = this.delegate90_2;
				Class171.Delegate90 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate90 value2 = (Class171.Delegate90)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate90>(ref this.delegate90_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate90 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate90 @delegate = this.delegate90_3;
				Class171.Delegate90 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate90 value2 = (Class171.Delegate90)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate90>(ref this.delegate90_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate90 @delegate = this.delegate90_3;
				Class171.Delegate90 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate90 value2 = (Class171.Delegate90)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate90>(ref this.delegate90_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class212 class212_0)
		{
			base.Rows.Add(class212_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class212 method_1(string string_0, string string_1, string string_2)
		{
			Class171.Class212 @class = (Class171.Class212)base.NewRow();
			object[] itemArray = new object[]
			{
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
			Class171.Class187 @class = (Class171.Class187)base.Clone();
			@class.method_2();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class187();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["Measure"];
			this.dataColumn_1 = base.Columns["Date"];
			this.dataColumn_2 = base.Columns["Org"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("Measure", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("Date", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("Org", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class212 method_4()
		{
			return (Class171.Class212)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class212(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class212);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate90_1 != null)
			{
				this.delegate90_1(this, new Class171.EventArgs86((Class171.Class212)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate90_0 != null)
			{
				this.delegate90_0(this, new Class171.EventArgs86((Class171.Class212)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate90_3 != null)
			{
				this.delegate90_3(this, new Class171.EventArgs86((Class171.Class212)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate90_2 != null)
			{
				this.delegate90_2(this, new Class171.EventArgs86((Class171.Class212)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5(Class171.Class212 class212_0)
		{
			base.Rows.Remove(class212_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "table31DataTable";
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
		private Class171.Delegate90 delegate90_0;

		[CompilerGenerated]
		private Class171.Delegate90 delegate90_1;

		[CompilerGenerated]
		private Class171.Delegate90 delegate90_2;

		[CompilerGenerated]
		private Class171.Delegate90 delegate90_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class188 : TypedTableBase<Class171.Class213>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class188()
		{
			//
			
			base.TableName = "table4";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class188(DataTable dataTable_0)
		{
			//
			
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
		protected Class188(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_2();
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
		public Class171.Class213 this[int int_0]
		{
			get
			{
				return (Class171.Class213)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate91 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate91 @delegate = this.delegate91_0;
				Class171.Delegate91 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate91 value2 = (Class171.Delegate91)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate91>(ref this.delegate91_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate91 @delegate = this.delegate91_0;
				Class171.Delegate91 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate91 value2 = (Class171.Delegate91)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate91>(ref this.delegate91_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate91 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate91 @delegate = this.delegate91_1;
				Class171.Delegate91 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate91 value2 = (Class171.Delegate91)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate91>(ref this.delegate91_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate91 @delegate = this.delegate91_1;
				Class171.Delegate91 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate91 value2 = (Class171.Delegate91)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate91>(ref this.delegate91_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate91 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate91 @delegate = this.delegate91_2;
				Class171.Delegate91 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate91 value2 = (Class171.Delegate91)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate91>(ref this.delegate91_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate91 @delegate = this.delegate91_2;
				Class171.Delegate91 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate91 value2 = (Class171.Delegate91)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate91>(ref this.delegate91_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate91 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate91 @delegate = this.delegate91_3;
				Class171.Delegate91 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate91 value2 = (Class171.Delegate91)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate91>(ref this.delegate91_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate91 @delegate = this.delegate91_3;
				Class171.Delegate91 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate91 value2 = (Class171.Delegate91)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate91>(ref this.delegate91_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class213 class213_0)
		{
			base.Rows.Add(class213_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class213 method_1(string string_0, string string_1)
		{
			Class171.Class213 @class = (Class171.Class213)base.NewRow();
			object[] itemArray = new object[]
			{
				string_0,
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
			Class171.Class188 @class = (Class171.Class188)base.Clone();
			@class.method_2();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class188();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["num"];
			this.dataColumn_1 = base.Columns["Description"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("num", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("Description", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class213 method_4()
		{
			return (Class171.Class213)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class213(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class213);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate91_1 != null)
			{
				this.delegate91_1(this, new Class171.EventArgs87((Class171.Class213)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate91_0 != null)
			{
				this.delegate91_0(this, new Class171.EventArgs87((Class171.Class213)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate91_3 != null)
			{
				this.delegate91_3(this, new Class171.EventArgs87((Class171.Class213)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate91_2 != null)
			{
				this.delegate91_2(this, new Class171.EventArgs87((Class171.Class213)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5(Class171.Class213 class213_0)
		{
			base.Rows.Remove(class213_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "table4DataTable";
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

		[CompilerGenerated]
		private Class171.Delegate91 delegate91_0;

		[CompilerGenerated]
		private Class171.Delegate91 delegate91_1;

		[CompilerGenerated]
		private Class171.Delegate91 delegate91_2;

		[CompilerGenerated]
		private Class171.Delegate91 delegate91_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class189 : TypedTableBase<Class171.Class214>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class189()
		{
			//
			
			base.TableName = "tJ_DamageHV";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class189(DataTable dataTable_0)
		{
			//
			
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
		protected Class189(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_3();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn idDamageColumn
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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
		public Class171.Class214 this[int int_0]
		{
			get
			{
				return (Class171.Class214)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate92 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate92 @delegate = this.delegate92_0;
				Class171.Delegate92 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate92 value2 = (Class171.Delegate92)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate92>(ref this.delegate92_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate92 @delegate = this.delegate92_0;
				Class171.Delegate92 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate92 value2 = (Class171.Delegate92)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate92>(ref this.delegate92_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate92 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate92 @delegate = this.delegate92_1;
				Class171.Delegate92 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate92 value2 = (Class171.Delegate92)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate92>(ref this.delegate92_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate92 @delegate = this.delegate92_1;
				Class171.Delegate92 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate92 value2 = (Class171.Delegate92)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate92>(ref this.delegate92_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate92 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate92 @delegate = this.delegate92_2;
				Class171.Delegate92 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate92 value2 = (Class171.Delegate92)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate92>(ref this.delegate92_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate92 @delegate = this.delegate92_2;
				Class171.Delegate92 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate92 value2 = (Class171.Delegate92)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate92>(ref this.delegate92_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate92 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate92 @delegate = this.delegate92_3;
				Class171.Delegate92 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate92 value2 = (Class171.Delegate92)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate92>(ref this.delegate92_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate92 @delegate = this.delegate92_3;
				Class171.Delegate92 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate92 value2 = (Class171.Delegate92)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate92>(ref this.delegate92_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class214 class214_0)
		{
			base.Rows.Add(class214_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class214 method_1(int int_0, int int_1, int int_2, int int_3, decimal decimal_0, decimal decimal_1, decimal decimal_2, bool bool_0, bool bool_1, decimal decimal_3, decimal decimal_4, decimal decimal_5, bool bool_2)
		{
			Class171.Class214 @class = (Class171.Class214)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				int_1,
				int_2,
				int_3,
				decimal_0,
				decimal_1,
				decimal_2,
				bool_0,
				bool_1,
				decimal_3,
				decimal_4,
				decimal_5,
				bool_2
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class214 method_2(int int_0)
		{
			return (Class171.Class214)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class171.Class189 @class = (Class171.Class189)base.Clone();
			@class.method_3();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class189();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["idDamage"];
			this.dataColumn_1 = base.Columns["idTypeRZA"];
			this.dataColumn_2 = base.Columns["CountSchmObj"];
			this.dataColumn_3 = base.Columns["CountSchmObjOff"];
			this.dataColumn_4 = base.Columns["ConnectedPower"];
			this.dataColumn_5 = base.Columns["CoefFI"];
			this.dataColumn_6 = base.Columns["NoAdmissionKWT"];
			this.dataColumn_7 = base.Columns["AVR"];
			this.dataColumn_8 = base.Columns["APR"];
			this.dataColumn_9 = base.Columns["PowerA"];
			this.dataColumn_10 = base.Columns["PowerV"];
			this.dataColumn_11 = base.Columns["CoefSeason"];
			this.dataColumn_12 = base.Columns["isAverage"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("idDamage", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("idTypeRZA", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("CountSchmObj", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("CountSchmObjOff", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("ConnectedPower", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("CoefFI", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("NoAdmissionKWT", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("AVR", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("APR", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("PowerA", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("PowerV", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("CoefSeason", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("isAverage", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
			{
				this.dataColumn_0
			}, true));
			this.dataColumn_0.AllowDBNull = false;
			this.dataColumn_0.Unique = true;
			this.dataColumn_12.DefaultValue = true;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class214 method_5()
		{
			return (Class171.Class214)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class214(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class214);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate92_1 != null)
			{
				this.delegate92_1(this, new Class171.EventArgs88((Class171.Class214)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate92_0 != null)
			{
				this.delegate92_0(this, new Class171.EventArgs88((Class171.Class214)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate92_3 != null)
			{
				this.delegate92_3(this, new Class171.EventArgs88((Class171.Class214)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate92_2 != null)
			{
				this.delegate92_2(this, new Class171.EventArgs88((Class171.Class214)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_6(Class171.Class214 class214_0)
		{
			base.Rows.Remove(class214_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tJ_DamageHVDataTable";
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

		[CompilerGenerated]
		private Class171.Delegate92 delegate92_0;

		[CompilerGenerated]
		private Class171.Delegate92 delegate92_1;

		[CompilerGenerated]
		private Class171.Delegate92 delegate92_2;

		[CompilerGenerated]
		private Class171.Delegate92 delegate92_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class190 : TypedTableBase<Class171.Class215>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class190()
		{
			//
			
			base.TableName = "tReportDetectionCrash";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class190(DataTable dataTable_0)
		{
			//
			
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
		protected Class190(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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
		public Class171.Class215 this[int int_0]
		{
			get
			{
				return (Class171.Class215)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate93 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate93 @delegate = this.delegate93_0;
				Class171.Delegate93 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate93 value2 = (Class171.Delegate93)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate93>(ref this.delegate93_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate93 @delegate = this.delegate93_0;
				Class171.Delegate93 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate93 value2 = (Class171.Delegate93)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate93>(ref this.delegate93_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate93 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate93 @delegate = this.delegate93_1;
				Class171.Delegate93 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate93 value2 = (Class171.Delegate93)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate93>(ref this.delegate93_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate93 @delegate = this.delegate93_1;
				Class171.Delegate93 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate93 value2 = (Class171.Delegate93)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate93>(ref this.delegate93_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate93 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate93 @delegate = this.delegate93_2;
				Class171.Delegate93 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate93 value2 = (Class171.Delegate93)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate93>(ref this.delegate93_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate93 @delegate = this.delegate93_2;
				Class171.Delegate93 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate93 value2 = (Class171.Delegate93)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate93>(ref this.delegate93_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate93 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate93 @delegate = this.delegate93_3;
				Class171.Delegate93 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate93 value2 = (Class171.Delegate93)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate93>(ref this.delegate93_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate93 @delegate = this.delegate93_3;
				Class171.Delegate93 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate93 value2 = (Class171.Delegate93)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate93>(ref this.delegate93_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class215 class215_0)
		{
			base.Rows.Add(class215_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class215 method_1(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, bool bool_0, string string_0)
		{
			Class171.Class215 @class = (Class171.Class215)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				int_1,
				int_2,
				int_3,
				int_4,
				int_5,
				int_6,
				int_7,
				int_8,
				bool_0,
				string_0
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class171.Class190 @class = (Class171.Class190)base.Clone();
			@class.method_2();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class190();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["Month"];
			this.dataColumn_2 = base.Columns["id756"];
			this.dataColumn_3 = base.Columns["id757"];
			this.dataColumn_4 = base.Columns["id758"];
			this.dataColumn_5 = base.Columns["id759"];
			this.dataColumn_6 = base.Columns["id1518"];
			this.dataColumn_7 = base.Columns["id1519"];
			this.dataColumn_8 = base.Columns["id1520"];
			this.dataColumn_9 = base.Columns["isCrash"];
			this.dataColumn_10 = base.Columns["id2308"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("Month", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("id756", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("id757", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("id758", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("id759", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("id1518", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("id1519", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("id1520", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("isCrash", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("id2308", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class215 method_4()
		{
			return (Class171.Class215)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class215(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class215);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate93_1 != null)
			{
				this.delegate93_1(this, new Class171.EventArgs89((Class171.Class215)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate93_0 != null)
			{
				this.delegate93_0(this, new Class171.EventArgs89((Class171.Class215)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate93_3 != null)
			{
				this.delegate93_3(this, new Class171.EventArgs89((Class171.Class215)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate93_2 != null)
			{
				this.delegate93_2(this, new Class171.EventArgs89((Class171.Class215)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5(Class171.Class215 class215_0)
		{
			base.Rows.Remove(class215_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tReportDetectionCrashDataTable";
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

		[CompilerGenerated]
		private Class171.Delegate93 delegate93_0;

		[CompilerGenerated]
		private Class171.Delegate93 delegate93_1;

		[CompilerGenerated]
		private Class171.Delegate93 delegate93_2;

		[CompilerGenerated]
		private Class171.Delegate93 delegate93_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class tReportDetectionReasonCrashDataTable : TypedTableBase<Class171.Class216>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public tReportDetectionReasonCrashDataTable()
		{
			//
			
			base.TableName = "tReportDetectionReasonCrash";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal tReportDetectionReasonCrashDataTable(DataTable dataTable_0)
		{
			//
			
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
		protected tReportDetectionReasonCrashDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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
		public DataColumn DataColumn_8
		{
			get
			{
				return this.dataColumn_9;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
		public Class171.Class216 this[int int_0]
		{
			get
			{
				return (Class171.Class216)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate94 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate94 @delegate = this.delegate94_0;
				Class171.Delegate94 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate94 value2 = (Class171.Delegate94)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate94>(ref this.delegate94_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate94 @delegate = this.delegate94_0;
				Class171.Delegate94 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate94 value2 = (Class171.Delegate94)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate94>(ref this.delegate94_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate94 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate94 @delegate = this.delegate94_1;
				Class171.Delegate94 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate94 value2 = (Class171.Delegate94)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate94>(ref this.delegate94_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate94 @delegate = this.delegate94_1;
				Class171.Delegate94 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate94 value2 = (Class171.Delegate94)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate94>(ref this.delegate94_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate94 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate94 @delegate = this.delegate94_2;
				Class171.Delegate94 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate94 value2 = (Class171.Delegate94)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate94>(ref this.delegate94_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate94 @delegate = this.delegate94_2;
				Class171.Delegate94 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate94 value2 = (Class171.Delegate94)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate94>(ref this.delegate94_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate94 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate94 @delegate = this.delegate94_3;
				Class171.Delegate94 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate94 value2 = (Class171.Delegate94)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate94>(ref this.delegate94_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate94 @delegate = this.delegate94_3;
				Class171.Delegate94 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate94 value2 = (Class171.Delegate94)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate94>(ref this.delegate94_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class171.Class216 class216_0)
		{
			base.Rows.Add(class216_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class216 method_1(int int_0, int int_1, string string_0, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, bool bool_0, string string_1)
		{
			Class171.Class216 @class = (Class171.Class216)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				int_1,
				string_0,
				int_2,
				int_3,
				int_4,
				int_5,
				int_6,
				int_7,
				int_8,
				bool_0,
				string_1
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataTable Clone()
		{
			Class171.tReportDetectionReasonCrashDataTable @class = (Class171.tReportDetectionReasonCrashDataTable)base.Clone();
			@class.method_2();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.tReportDetectionReasonCrashDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["reasonCode"];
			this.dataColumn_2 = base.Columns["Reason"];
			this.dataColumn_3 = base.Columns["id756"];
			this.dataColumn_4 = base.Columns["id757"];
			this.dataColumn_5 = base.Columns["id758"];
			this.dataColumn_6 = base.Columns["id759"];
			this.dataColumn_7 = base.Columns["id1518"];
			this.dataColumn_8 = base.Columns["id1519"];
			this.dataColumn_9 = base.Columns["id1520"];
			this.dataColumn_10 = base.Columns["isCrash"];
			this.dataColumn_11 = base.Columns["id2308"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("reasonCode", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("Reason", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("id756", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("id757", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("id758", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("id759", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("id1518", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("id1519", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("id1520", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("isCrash", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("id2308", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_1.Caption = "Month";
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class216 method_4()
		{
			return (Class171.Class216)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class216(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class216);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate94_1 != null)
			{
				this.delegate94_1(this, new Class171.EventArgs90((Class171.Class216)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate94_0 != null)
			{
				this.delegate94_0(this, new Class171.EventArgs90((Class171.Class216)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate94_3 != null)
			{
				this.delegate94_3(this, new Class171.EventArgs90((Class171.Class216)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate94_2 != null)
			{
				this.delegate94_2(this, new Class171.EventArgs90((Class171.Class216)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5(Class171.Class216 class216_0)
		{
			base.Rows.Remove(class216_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tReportDetectionReasonCrashDataTable";
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

		[CompilerGenerated]
		private Class171.Delegate94 delegate94_0;

		[CompilerGenerated]
		private Class171.Delegate94 delegate94_1;

		[CompilerGenerated]
		private Class171.Delegate94 delegate94_2;

		[CompilerGenerated]
		private Class171.Delegate94 delegate94_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class192 : TypedTableBase<Class171.Class217>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class192()
		{
			//
			
			base.TableName = "tReportDetectionNetReg";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class192(DataTable dataTable_0)
		{
			//
			
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
		protected Class192(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_2();
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
				return this.fFiZgwebDkG;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_3
		{
			get
			{
				return this.dataColumn_2;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_4
		{
			get
			{
				return this.dataColumn_3;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_5
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
		public Class171.Class217 this[int int_0]
		{
			get
			{
				return (Class171.Class217)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate95 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate95 @delegate = this.delegate95_0;
				Class171.Delegate95 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate95 value2 = (Class171.Delegate95)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate95>(ref this.delegate95_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate95 @delegate = this.delegate95_0;
				Class171.Delegate95 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate95 value2 = (Class171.Delegate95)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate95>(ref this.delegate95_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate95 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate95 @delegate = this.delegate95_1;
				Class171.Delegate95 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate95 value2 = (Class171.Delegate95)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate95>(ref this.delegate95_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate95 @delegate = this.delegate95_1;
				Class171.Delegate95 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate95 value2 = (Class171.Delegate95)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate95>(ref this.delegate95_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate95 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate95 @delegate = this.delegate95_2;
				Class171.Delegate95 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate95 value2 = (Class171.Delegate95)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate95>(ref this.delegate95_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate95 @delegate = this.delegate95_2;
				Class171.Delegate95 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate95 value2 = (Class171.Delegate95)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate95>(ref this.delegate95_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate95 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate95 @delegate = this.delegate95_3;
				Class171.Delegate95 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate95 value2 = (Class171.Delegate95)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate95>(ref this.delegate95_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate95 @delegate = this.delegate95_3;
				Class171.Delegate95 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate95 value2 = (Class171.Delegate95)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate95>(ref this.delegate95_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class171.Class217 class217_0)
		{
			base.Rows.Add(class217_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class217 method_1(int int_0, int int_1, int int_2, int int_3, bool bool_0, string string_0)
		{
			Class171.Class217 @class = (Class171.Class217)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				int_1,
				int_2,
				int_3,
				bool_0,
				string_0
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.Class192 @class = (Class171.Class192)base.Clone();
			@class.method_2();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class192();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["typeNetReg"];
			this.dataColumn_1 = base.Columns["id1518"];
			this.fFiZgwebDkG = base.Columns["id1519"];
			this.dataColumn_2 = base.Columns["id1520"];
			this.dataColumn_3 = base.Columns["isCrash"];
			this.dataColumn_4 = base.Columns["id2308"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("typeNetReg", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("id1518", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.fFiZgwebDkG = new DataColumn("id1519", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.fFiZgwebDkG);
			this.dataColumn_2 = new DataColumn("id1520", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("isCrash", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("id2308", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_0.Caption = "Month";
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class217 method_4()
		{
			return (Class171.Class217)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class217(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class217);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate95_1 != null)
			{
				this.delegate95_1(this, new Class171.EventArgs91((Class171.Class217)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate95_0 != null)
			{
				this.delegate95_0(this, new Class171.EventArgs91((Class171.Class217)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate95_3 != null)
			{
				this.delegate95_3(this, new Class171.EventArgs91((Class171.Class217)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate95_2 != null)
			{
				this.delegate95_2(this, new Class171.EventArgs91((Class171.Class217)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5(Class171.Class217 class217_0)
		{
			base.Rows.Remove(class217_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tReportDetectionNetRegDataTable";
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

		private DataColumn fFiZgwebDkG;

		private DataColumn dataColumn_2;

		private DataColumn dataColumn_3;

		private DataColumn dataColumn_4;

		[CompilerGenerated]
		private Class171.Delegate95 delegate95_0;

		[CompilerGenerated]
		private Class171.Delegate95 delegate95_1;

		[CompilerGenerated]
		private Class171.Delegate95 delegate95_2;

		[CompilerGenerated]
		private Class171.Delegate95 delegate95_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class193 : TypedTableBase<Class171.Class218>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class193()
		{
			//
			
			base.TableName = "tReportDetectionNoAdmissKWT";
			this.BeginInit();
			this.method_2();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class193(DataTable dataTable_0)
		{
			//
			
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
		protected Class193(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_1();
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
		public Class171.Class218 this[int int_0]
		{
			get
			{
				return (Class171.Class218)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate96 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate96 @delegate = this.delegate96_0;
				Class171.Delegate96 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate96 value2 = (Class171.Delegate96)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate96>(ref this.delegate96_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate96 @delegate = this.delegate96_0;
				Class171.Delegate96 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate96 value2 = (Class171.Delegate96)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate96>(ref this.delegate96_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate96 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate96 @delegate = this.delegate96_1;
				Class171.Delegate96 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate96 value2 = (Class171.Delegate96)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate96>(ref this.delegate96_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate96 @delegate = this.delegate96_1;
				Class171.Delegate96 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate96 value2 = (Class171.Delegate96)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate96>(ref this.delegate96_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate96 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate96 @delegate = this.delegate96_2;
				Class171.Delegate96 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate96 value2 = (Class171.Delegate96)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate96>(ref this.delegate96_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate96 @delegate = this.delegate96_2;
				Class171.Delegate96 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate96 value2 = (Class171.Delegate96)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate96>(ref this.delegate96_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate96 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate96 @delegate = this.delegate96_3;
				Class171.Delegate96 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate96 value2 = (Class171.Delegate96)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate96>(ref this.delegate96_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate96 @delegate = this.delegate96_3;
				Class171.Delegate96 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate96 value2 = (Class171.Delegate96)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate96>(ref this.delegate96_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_0(Class171.Class218 class218_0)
		{
			base.Rows.Add(class218_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class218 nkiZgLlTaiZ(int int_0, int int_1, int int_2, int int_3, int int_4)
		{
			Class171.Class218 @class = (Class171.Class218)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				int_1,
				int_2,
				int_3,
				int_4
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.Class193 @class = (Class171.Class193)base.Clone();
			@class.method_1();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class193();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_1()
		{
			this.dataColumn_0 = base.Columns["isCrash"];
			this.dataColumn_1 = base.Columns["id756"];
			this.dataColumn_2 = base.Columns["id757"];
			this.dataColumn_3 = base.Columns["id758"];
			this.dataColumn_4 = base.Columns["id759"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_2()
		{
			this.dataColumn_0 = new DataColumn("isCrash", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("id756", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("id757", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("id758", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("id759", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class218 method_3()
		{
			return (Class171.Class218)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class218(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class218);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate96_1 != null)
			{
				this.delegate96_1(this, new Class171.EventArgs92((Class171.Class218)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate96_0 != null)
			{
				this.delegate96_0(this, new Class171.EventArgs92((Class171.Class218)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate96_3 != null)
			{
				this.delegate96_3(this, new Class171.EventArgs92((Class171.Class218)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate96_2 != null)
			{
				this.delegate96_2(this, new Class171.EventArgs92((Class171.Class218)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_4(Class171.Class218 class218_0)
		{
			base.Rows.Remove(class218_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tReportDetectionNoAdmissKWTDataTable";
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
		private Class171.Delegate96 delegate96_0;

		[CompilerGenerated]
		private Class171.Delegate96 delegate96_1;

		[CompilerGenerated]
		private Class171.Delegate96 delegate96_2;

		[CompilerGenerated]
		private Class171.Delegate96 delegate96_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class tSettingsDataTable : TypedTableBase<Class171.Class219>
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public tSettingsDataTable()
		{
			//
			
			base.TableName = "tSettings";
			this.BeginInit();
			this.method_4();
			this.EndInit();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal tSettingsDataTable(DataTable dataTable_0)
		{
			//
			
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
		protected tSettingsDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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
		public Class171.Class219 this[int int_0]
		{
			get
			{
				return (Class171.Class219)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate97 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate97 @delegate = this.delegate97_0;
				Class171.Delegate97 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate97 value2 = (Class171.Delegate97)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate97>(ref this.delegate97_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate97 @delegate = this.delegate97_0;
				Class171.Delegate97 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate97 value2 = (Class171.Delegate97)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate97>(ref this.delegate97_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate97 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate97 @delegate = this.delegate97_1;
				Class171.Delegate97 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate97 value2 = (Class171.Delegate97)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate97>(ref this.delegate97_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate97 @delegate = this.delegate97_1;
				Class171.Delegate97 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate97 value2 = (Class171.Delegate97)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate97>(ref this.delegate97_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate97 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate97 @delegate = this.delegate97_2;
				Class171.Delegate97 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate97 value2 = (Class171.Delegate97)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate97>(ref this.delegate97_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate97 @delegate = this.delegate97_2;
				Class171.Delegate97 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate97 value2 = (Class171.Delegate97)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate97>(ref this.delegate97_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate97 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate97 @delegate = this.delegate97_3;
				Class171.Delegate97 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate97 value2 = (Class171.Delegate97)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate97>(ref this.delegate97_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate97 @delegate = this.delegate97_3;
				Class171.Delegate97 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate97 value2 = (Class171.Delegate97)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate97>(ref this.delegate97_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class171.Class219 class219_0)
		{
			base.Rows.Add(class219_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class219 method_1(string string_0, string string_1, string string_2)
		{
			Class171.Class219 @class = (Class171.Class219)base.NewRow();
			object[] itemArray = new object[]
			{
				null,
				string_0,
				string_1,
				string_2
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class219 method_2(int int_0)
		{
			return (Class171.Class219)base.Rows.Find(new object[]
			{
				int_0
			});
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.tSettingsDataTable @class = (Class171.tSettingsDataTable)base.Clone();
			@class.method_3();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.tSettingsDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_3()
		{
			this.dataColumn_0 = base.Columns["id"];
			this.dataColumn_1 = base.Columns["HostIp"];
			this.dataColumn_2 = base.Columns["Settings"];
			this.dataColumn_3 = base.Columns["Module"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_4()
		{
			this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("HostIp", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("Settings", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("Module", typeof(string), null, MappingType.Element);
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
			this.dataColumn_1.MaxLength = 15;
			this.dataColumn_3.MaxLength = 50;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class219 method_5()
		{
			return (Class171.Class219)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class219(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class219);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate97_1 != null)
			{
				this.delegate97_1(this, new Class171.EventArgs93((Class171.Class219)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate97_0 != null)
			{
				this.delegate97_0(this, new Class171.EventArgs93((Class171.Class219)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate97_3 != null)
			{
				this.delegate97_3(this, new Class171.EventArgs93((Class171.Class219)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate97_2 != null)
			{
				this.delegate97_2(this, new Class171.EventArgs93((Class171.Class219)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_6(Class171.Class219 class219_0)
		{
			base.Rows.Remove(class219_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "tSettingsDataTable";
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
		private Class171.Delegate97 delegate97_0;

		[CompilerGenerated]
		private Class171.Delegate97 delegate97_1;

		[CompilerGenerated]
		private Class171.Delegate97 delegate97_2;

		[CompilerGenerated]
		private Class171.Delegate97 delegate97_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class Class195 : TypedTableBase<Class171.Class220>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class195()
		{
			//
			
			base.TableName = "Report81";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class195(DataTable dataTable_0)
		{
			//
			
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
		protected Class195(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn subNameColumn
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
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_15
		{
			get
			{
				return this.dataColumn_16;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_18
		{
			get
			{
				return this.dataColumn_19;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_19
		{
			get
			{
				return this.dataColumn_20;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_20
		{
			get
			{
				return this.dataColumn_21;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_21
		{
			get
			{
				return this.dataColumn_22;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_22
		{
			get
			{
				return this.dataColumn_23;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_23
		{
			get
			{
				return this.dataColumn_24;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_24
		{
			get
			{
				return this.dataColumn_25;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_25
		{
			get
			{
				return this.dataColumn_26;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_26
		{
			get
			{
				return this.dataColumn_27;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_27
		{
			get
			{
				return this.dataColumn_28;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_28
		{
			get
			{
				return this.dataColumn_29;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_29
		{
			get
			{
				return this.dataColumn_30;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_30
		{
			get
			{
				return this.dataColumn_31;
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
		public Class171.Class220 this[int int_0]
		{
			get
			{
				return (Class171.Class220)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate98 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate98 @delegate = this.delegate98_0;
				Class171.Delegate98 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate98 value2 = (Class171.Delegate98)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate98>(ref this.delegate98_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate98 @delegate = this.delegate98_0;
				Class171.Delegate98 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate98 value2 = (Class171.Delegate98)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate98>(ref this.delegate98_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate98 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate98 @delegate = this.delegate98_1;
				Class171.Delegate98 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate98 value2 = (Class171.Delegate98)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate98>(ref this.delegate98_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate98 @delegate = this.delegate98_1;
				Class171.Delegate98 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate98 value2 = (Class171.Delegate98)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate98>(ref this.delegate98_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate98 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate98 @delegate = this.delegate98_2;
				Class171.Delegate98 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate98 value2 = (Class171.Delegate98)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate98>(ref this.delegate98_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate98 @delegate = this.delegate98_2;
				Class171.Delegate98 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate98 value2 = (Class171.Delegate98)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate98>(ref this.delegate98_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate98 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate98 @delegate = this.delegate98_3;
				Class171.Delegate98 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate98 value2 = (Class171.Delegate98)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate98>(ref this.delegate98_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate98 @delegate = this.delegate98_3;
				Class171.Delegate98 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate98 value2 = (Class171.Delegate98)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate98>(ref this.delegate98_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class171.Class220 class220_0)
		{
			base.Rows.Add(class220_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class220 method_1(int int_0, string string_0, double double_0, string string_1, string string_2, string string_3, decimal decimal_0, string string_4, bool bool_0, bool bool_1, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, int int_9, int int_10, int int_11, int int_12, int int_13, int int_14, int int_15, int int_16, int int_17, DateTime dateTime_0, DateTime dateTime_1, DateTime dateTime_2, string string_5, string string_6)
		{
			Class171.Class220 @class = (Class171.Class220)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				string_0,
				double_0,
				string_1,
				string_2,
				string_3,
				decimal_0,
				string_4,
				bool_0,
				bool_1,
				int_1,
				int_2,
				int_3,
				int_4,
				int_5,
				int_6,
				int_7,
				int_8,
				int_9,
				int_10,
				int_11,
				int_12,
				int_13,
				int_14,
				int_15,
				int_16,
				int_17,
				dateTime_0,
				dateTime_1,
				dateTime_2,
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
			Class171.Class195 @class = (Class171.Class195)base.Clone();
			@class.method_2();
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataTable CreateInstance()
		{
			return new Class171.Class195();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["IdDamage"];
			this.dataColumn_1 = base.Columns["SRName"];
			this.dataColumn_2 = base.Columns["netRegionValue"];
			this.dataColumn_3 = base.Columns["schmObjName"];
			this.dataColumn_4 = base.Columns["subName"];
			this.dataColumn_5 = base.Columns["TypeSchmObj"];
			this.dataColumn_6 = base.Columns["PowerV"];
			this.dataColumn_7 = base.Columns["Reason"];
			this.dataColumn_8 = base.Columns["APV"];
			this.dataColumn_9 = base.Columns["AVR"];
			this.dataColumn_10 = base.Columns["countPointCat1Full"];
			this.dataColumn_11 = base.Columns["countPointCat1"];
			this.dataColumn_12 = base.Columns["countPointCat2Full"];
			this.dataColumn_13 = base.Columns["countPointCat2"];
			this.dataColumn_14 = base.Columns["countPointCat3"];
			this.dataColumn_15 = base.Columns["countPointEE"];
			this.dataColumn_16 = base.Columns["countPointSource"];
			this.dataColumn_17 = base.Columns["countAbnObjCat1Full"];
			this.dataColumn_18 = base.Columns["countAbnObjCat1"];
			this.dataColumn_19 = base.Columns["countAbnObjCat2Full"];
			this.dataColumn_20 = base.Columns["countAbnObjCat2"];
			this.dataColumn_21 = base.Columns["countAbnObjCat3"];
			this.dataColumn_22 = base.Columns["countAbnObjEE"];
			this.dataColumn_23 = base.Columns["countAbnObjSource"];
			this.dataColumn_24 = base.Columns["countAbnObj150"];
			this.dataColumn_25 = base.Columns["countAbnObj150670"];
			this.dataColumn_26 = base.Columns["countAbnObj670"];
			this.dataColumn_27 = base.Columns["dateBegin"];
			this.dataColumn_28 = base.Columns["dateApply"];
			this.dataColumn_29 = base.Columns["dateApplyMax"];
			this.dataColumn_30 = base.Columns["TypeDoc"];
			this.dataColumn_31 = base.Columns["numDateDoc"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("IdDamage", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("SRName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("netRegionValue", typeof(double), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("schmObjName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("subName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("TypeSchmObj", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("PowerV", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("Reason", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("APV", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("AVR", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("countPointCat1Full", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("countPointCat1", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("countPointCat2Full", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			this.dataColumn_13 = new DataColumn("countPointCat2", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_13);
			this.dataColumn_14 = new DataColumn("countPointCat3", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_14);
			this.dataColumn_15 = new DataColumn("countPointEE", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_15);
			this.dataColumn_16 = new DataColumn("countPointSource", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_16);
			this.dataColumn_17 = new DataColumn("countAbnObjCat1Full", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_17);
			this.dataColumn_18 = new DataColumn("countAbnObjCat1", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_18);
			this.dataColumn_19 = new DataColumn("countAbnObjCat2Full", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_19);
			this.dataColumn_20 = new DataColumn("countAbnObjCat2", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_20);
			this.dataColumn_21 = new DataColumn("countAbnObjCat3", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_21);
			this.dataColumn_22 = new DataColumn("countAbnObjEE", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_22);
			this.dataColumn_23 = new DataColumn("countAbnObjSource", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_23);
			this.dataColumn_24 = new DataColumn("countAbnObj150", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_24);
			this.dataColumn_25 = new DataColumn("countAbnObj150670", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_25);
			this.dataColumn_26 = new DataColumn("countAbnObj670", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_26);
			this.dataColumn_27 = new DataColumn("dateBegin", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_27);
			this.dataColumn_28 = new DataColumn("dateApply", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_28);
			this.dataColumn_29 = new DataColumn("dateApplyMax", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_29);
			this.dataColumn_30 = new DataColumn("TypeDoc", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_30);
			this.dataColumn_31 = new DataColumn("numDateDoc", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_31);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class220 method_4()
		{
			return (Class171.Class220)base.NewRow();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class220(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class220);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate98_1 != null)
			{
				this.delegate98_1(this, new Class171.EventArgs94((Class171.Class220)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate98_0 != null)
			{
				this.delegate98_0(this, new Class171.EventArgs94((Class171.Class220)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate98_3 != null)
			{
				this.delegate98_3(this, new Class171.EventArgs94((Class171.Class220)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate98_2 != null)
			{
				this.delegate98_2(this, new Class171.EventArgs94((Class171.Class220)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5(Class171.Class220 class220_0)
		{
			base.Rows.Remove(class220_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "Report81DataTable";
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

		[CompilerGenerated]
		private Class171.Delegate98 delegate98_0;

		[CompilerGenerated]
		private Class171.Delegate98 delegate98_1;

		[CompilerGenerated]
		private Class171.Delegate98 delegate98_2;

		[CompilerGenerated]
		private Class171.Delegate98 delegate98_3;
	}

	[XmlSchemaProvider("GetTypedTableSchema")]
	[Serializable]
	public class ReportAccidentsDataTable : TypedTableBase<Class171.Class221>
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ReportAccidentsDataTable()
		{
			//
			
			base.TableName = "ReportAccidents";
			this.BeginInit();
			this.method_3();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal ReportAccidentsDataTable(DataTable dataTable_0)
		{
			//
			
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
		protected ReportAccidentsDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0)
		{
			//
			base..ctor(serializationInfo_0, streamingContext_0);
			this.method_2();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idDamageColumn
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
		public DataColumn subNameColumn
		{
			get
			{
				return this.dataColumn_9;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn cellNameColumn
		{
			get
			{
				return this.dataColumn_10;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_8
		{
			get
			{
				return this.dataColumn_11;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn DataColumn_9
		{
			get
			{
				return this.dataColumn_12;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataColumn idSchmObjColumn
		{
			get
			{
				return this.dataColumn_13;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_10
		{
			get
			{
				return this.dataColumn_14;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_16
		{
			get
			{
				return this.dataColumn_20;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_17
		{
			get
			{
				return this.dataColumn_21;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_18
		{
			get
			{
				return this.dataColumn_22;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataColumn DataColumn_19
		{
			get
			{
				return this.dataColumn_23;
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
		public Class171.Class221 this[int int_0]
		{
			get
			{
				return (Class171.Class221)base.Rows[int_0];
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate99 Event_0
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate99 @delegate = this.delegate99_0;
				Class171.Delegate99 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate99 value2 = (Class171.Delegate99)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate99>(ref this.delegate99_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate99 @delegate = this.delegate99_0;
				Class171.Delegate99 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate99 value2 = (Class171.Delegate99)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate99>(ref this.delegate99_0, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate99 Event_1
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate99 @delegate = this.delegate99_1;
				Class171.Delegate99 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate99 value2 = (Class171.Delegate99)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate99>(ref this.delegate99_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate99 @delegate = this.delegate99_1;
				Class171.Delegate99 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate99 value2 = (Class171.Delegate99)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate99>(ref this.delegate99_1, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate99 Event_2
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate99 @delegate = this.delegate99_2;
				Class171.Delegate99 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate99 value2 = (Class171.Delegate99)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate99>(ref this.delegate99_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate99 @delegate = this.delegate99_2;
				Class171.Delegate99 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate99 value2 = (Class171.Delegate99)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate99>(ref this.delegate99_2, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public event Class171.Delegate99 Event_3
		{
			[CompilerGenerated]
			add
			{
				Class171.Delegate99 @delegate = this.delegate99_3;
				Class171.Delegate99 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate99 value2 = (Class171.Delegate99)Delegate.Combine(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate99>(ref this.delegate99_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
			[CompilerGenerated]
			remove
			{
				Class171.Delegate99 @delegate = this.delegate99_3;
				Class171.Delegate99 delegate2;
				do
				{
					delegate2 = @delegate;
					Class171.Delegate99 value2 = (Class171.Delegate99)Delegate.Remove(delegate2, value);
					@delegate = Interlocked.CompareExchange<Class171.Delegate99>(ref this.delegate99_3, value2, delegate2);
				}
				while (@delegate != delegate2);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_0(Class171.Class221 class221_0)
		{
			base.Rows.Add(class221_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class221 method_1(int int_0, string string_0, int int_1, bool bool_0, DateTime dateTime_0, DateTime dateTime_1, string string_1, bool bool_1, decimal decimal_0, string string_2, string string_3, string string_4, string string_5, int int_2, string string_6, string string_7, string string_8, string string_9, decimal decimal_1, string string_10, int int_3, string string_11, DateTime dateTime_2, DateTime dateTime_3)
		{
			Class171.Class221 @class = (Class171.Class221)base.NewRow();
			object[] itemArray = new object[]
			{
				int_0,
				string_0,
				int_1,
				bool_0,
				dateTime_0,
				dateTime_1,
				string_1,
				bool_1,
				decimal_0,
				string_2,
				string_3,
				string_4,
				string_5,
				int_2,
				string_6,
				string_7,
				string_8,
				string_9,
				decimal_1,
				string_10,
				int_3,
				string_11,
				dateTime_2,
				dateTime_3
			};
			@class.ItemArray = itemArray;
			base.Rows.Add(@class);
			return @class;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataTable Clone()
		{
			Class171.ReportAccidentsDataTable @class = (Class171.ReportAccidentsDataTable)base.Clone();
			@class.method_2();
			return @class;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new Class171.ReportAccidentsDataTable();
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void method_2()
		{
			this.dataColumn_0 = base.Columns["idDamage"];
			this.dataColumn_1 = base.Columns["numCrash"];
			this.dataColumn_2 = base.Columns["numCrashMonth"];
			this.dataColumn_3 = base.Columns["isCrash"];
			this.dataColumn_4 = base.Columns["dateDoc"];
			this.dataColumn_5 = base.Columns["dateEnd"];
			this.dataColumn_6 = base.Columns["timeCrash"];
			this.dataColumn_7 = base.Columns["isApply"];
			this.dataColumn_8 = base.Columns["netRegionValue"];
			this.dataColumn_9 = base.Columns["subName"];
			this.dataColumn_10 = base.Columns["cellName"];
			this.dataColumn_11 = base.Columns["typeRZA"];
			this.dataColumn_12 = base.Columns["TypeSchmObj"];
			this.dataColumn_13 = base.Columns["idSchmObj"];
			this.dataColumn_14 = base.Columns["SubScribe"];
			this.dataColumn_15 = base.Columns["defectLocation"];
			this.dataColumn_16 = base.Columns["Character"];
			this.dataColumn_17 = base.Columns["abnNAme"];
			this.dataColumn_18 = base.Columns["NoAdmissionKWT"];
			this.dataColumn_19 = base.Columns["Mark"];
			this.dataColumn_20 = base.Columns["passIn"];
			this.dataColumn_21 = base.Columns["LineLenght"];
			this.dataColumn_22 = base.Columns["DAteTesting"];
			this.dataColumn_23 = base.Columns["timeRecovery"];
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_3()
		{
			this.dataColumn_0 = new DataColumn("idDamage", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_0);
			this.dataColumn_1 = new DataColumn("numCrash", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_1);
			this.dataColumn_2 = new DataColumn("numCrashMonth", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_2);
			this.dataColumn_3 = new DataColumn("isCrash", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_3);
			this.dataColumn_4 = new DataColumn("dateDoc", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_4);
			this.dataColumn_5 = new DataColumn("dateEnd", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_5);
			this.dataColumn_6 = new DataColumn("timeCrash", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_6);
			this.dataColumn_7 = new DataColumn("isApply", typeof(bool), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_7);
			this.dataColumn_8 = new DataColumn("netRegionValue", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_8);
			this.dataColumn_9 = new DataColumn("subName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_9);
			this.dataColumn_10 = new DataColumn("cellName", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_10);
			this.dataColumn_11 = new DataColumn("typeRZA", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_11);
			this.dataColumn_12 = new DataColumn("TypeSchmObj", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_12);
			this.dataColumn_13 = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_13);
			this.dataColumn_14 = new DataColumn("SubScribe", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_14);
			this.dataColumn_15 = new DataColumn("defectLocation", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_15);
			this.dataColumn_16 = new DataColumn("Character", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_16);
			this.dataColumn_17 = new DataColumn("abnNAme", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_17);
			this.dataColumn_18 = new DataColumn("NoAdmissionKWT", typeof(decimal), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_18);
			this.dataColumn_19 = new DataColumn("Mark", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_19);
			this.dataColumn_20 = new DataColumn("passIn", typeof(int), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_20);
			this.dataColumn_21 = new DataColumn("LineLenght", typeof(string), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_21);
			this.dataColumn_22 = new DataColumn("DAteTesting", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_22);
			this.dataColumn_23 = new DataColumn("timeRecovery", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(this.dataColumn_23);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class221 method_4()
		{
			return (Class171.Class221)base.NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new Class171.Class221(builder);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override Type GetRowType()
		{
			return typeof(Class171.Class221);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.delegate99_1 != null)
			{
				this.delegate99_1(this, new Class171.EventArgs95((Class171.Class221)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.delegate99_0 != null)
			{
				this.delegate99_0(this, new Class171.EventArgs95((Class171.Class221)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.delegate99_3 != null)
			{
				this.delegate99_3(this, new Class171.EventArgs95((Class171.Class221)e.Row, e.Action));
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.delegate99_2 != null)
			{
				this.delegate99_2(this, new Class171.EventArgs95((Class171.Class221)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5(Class171.Class221 class221_0)
		{
			base.Rows.Remove(class221_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			Class171 @class = new Class171();
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
			xmlSchemaAttribute2.FixedValue = "ReportAccidentsDataTable";
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

		[CompilerGenerated]
		private Class171.Delegate99 delegate99_0;

		[CompilerGenerated]
		private Class171.Delegate99 delegate99_1;

		[CompilerGenerated]
		private Class171.Delegate99 delegate99_2;

		[CompilerGenerated]
		private Class171.Delegate99 delegate99_3;
	}

	public class Class197 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class197(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class172_0 = (Class171.Class172)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[this.class172_0.idColumn];
			}
			set
			{
				base[this.class172_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int numDoc
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numDoc' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime DateDoc
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class172_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateDoc' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_1] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int TypeDoc
		{
			get
			{
				return (int)base[this.class172_0.DataColumn_2];
			}
			set
			{
				base[this.class172_0.DataColumn_2] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NumRequest
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class172_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NumRequest' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idCompiler
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idCompiler' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_4] = value;
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
					result = (int)base[this.class172_0.idDivisionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idDivision' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.idDivisionColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idSchmObj
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.idSchmObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idSchmObj' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.idSchmObjColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idMap
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idMap' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_5] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idStreet
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idStreet' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DefectLocation
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class172_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DefectLocation' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idReason
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idReason' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_8] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idCompletedWork
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idCompletedWork' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_9] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ComletedWorkText
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class172_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ComletedWorkText' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_10] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool isApply
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class172_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isApply' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_11] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idWorkerApply
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.DataColumn_12];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idWorkerApply' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_12] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DatePlanApply
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class172_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DatePlanApply' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_13] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime DateApply
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class172_0.DataColumn_14];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateApply' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_14] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idDivisionApply
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.DataColumn_15];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idDivisionApply' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_15] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool isLaboratory
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class172_0.DataColumn_16];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isLaboratory' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_16] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idParent
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.DataColumn_17];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idParent' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_17] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int idOwner
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.DataColumn_18];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idOwner' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_18] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DateOwner
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class172_0.DataColumn_19];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateOwner' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_19] = value;
			}
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
					result = (int)base[this.class172_0.DataColumn_20];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idReasonPTS' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_20] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DivisionInstruction
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class172_0.DataColumn_21];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DivisionInstruction' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_21] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string LaboratoryInstruction
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class172_0.DataColumn_22];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'LaboratoryInstruction' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_22] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idCompletedWorkODS
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.DataColumn_23];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idCompletedWorkODS' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_23] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string CompletedWorkTextODS
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class172_0.DataColumn_24];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CompletedWorkTextODS' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_24] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool deleted
		{
			get
			{
				return (bool)base[this.class172_0.DataColumn_25];
			}
			set
			{
				base[this.class172_0.DataColumn_25] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idReqForRepair
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class172_0.DataColumn_26];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idReqForRepair' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_26] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool is81
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class172_0.DataColumn_27];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'is81' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_27] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string CommentXml
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class172_0.DataColumn_28];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CommentXml' in table 'tJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class172_0.DataColumn_28] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class172_0.DataColumn_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class172_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class172_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class172_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class172_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class172_0.DataColumn_3] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class172_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class172_0.DataColumn_4] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_8()
		{
			return base.IsNull(this.class172_0.idDivisionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class172_0.idDivisionColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class172_0.idSchmObjColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class172_0.idSchmObjColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class172_0.DataColumn_5);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class172_0.DataColumn_5] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_14()
		{
			return base.IsNull(this.class172_0.DataColumn_6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class172_0.DataColumn_6] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_16()
		{
			return base.IsNull(this.class172_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_17()
		{
			base[this.class172_0.DataColumn_7] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_18()
		{
			return base.IsNull(this.class172_0.DataColumn_8);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_19()
		{
			base[this.class172_0.DataColumn_8] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_20()
		{
			return base.IsNull(this.class172_0.DataColumn_9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_21()
		{
			base[this.class172_0.DataColumn_9] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_22()
		{
			return base.IsNull(this.class172_0.DataColumn_10);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_23()
		{
			base[this.class172_0.DataColumn_10] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_24()
		{
			return base.IsNull(this.class172_0.DataColumn_11);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_25()
		{
			base[this.class172_0.DataColumn_11] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_26()
		{
			return base.IsNull(this.class172_0.DataColumn_12);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_27()
		{
			base[this.class172_0.DataColumn_12] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_28()
		{
			return base.IsNull(this.class172_0.DataColumn_13);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_29()
		{
			base[this.class172_0.DataColumn_13] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_30()
		{
			return base.IsNull(this.class172_0.DataColumn_14);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_31()
		{
			base[this.class172_0.DataColumn_14] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_32()
		{
			return base.IsNull(this.class172_0.DataColumn_15);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_33()
		{
			base[this.class172_0.DataColumn_15] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_34()
		{
			return base.IsNull(this.class172_0.DataColumn_16);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_35()
		{
			base[this.class172_0.DataColumn_16] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_36()
		{
			return base.IsNull(this.class172_0.DataColumn_17);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_37()
		{
			base[this.class172_0.DataColumn_17] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_38()
		{
			return base.IsNull(this.class172_0.DataColumn_18);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_39()
		{
			base[this.class172_0.DataColumn_18] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_40()
		{
			return base.IsNull(this.class172_0.DataColumn_19);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_41()
		{
			base[this.class172_0.DataColumn_19] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_42()
		{
			return base.IsNull(this.class172_0.DataColumn_20);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_43()
		{
			base[this.class172_0.DataColumn_20] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_44()
		{
			return base.IsNull(this.class172_0.DataColumn_21);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_45()
		{
			base[this.class172_0.DataColumn_21] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_46()
		{
			return base.IsNull(this.class172_0.DataColumn_22);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_47()
		{
			base[this.class172_0.DataColumn_22] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_48()
		{
			return base.IsNull(this.class172_0.DataColumn_23);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_49()
		{
			base[this.class172_0.DataColumn_23] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_50()
		{
			return base.IsNull(this.class172_0.DataColumn_24);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_51()
		{
			base[this.class172_0.DataColumn_24] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_52()
		{
			return base.IsNull(this.class172_0.DataColumn_26);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_53()
		{
			base[this.class172_0.DataColumn_26] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_54()
		{
			return base.IsNull(this.class172_0.DataColumn_27);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_55()
		{
			base[this.class172_0.DataColumn_27] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_56()
		{
			return base.IsNull(this.class172_0.DataColumn_28);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_57()
		{
			base[this.class172_0.DataColumn_28] = Convert.DBNull;
		}

		private Class171.Class172 class172_0;
	}

	public class Class198 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class198(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class173_0 = (Class171.Class173)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idMap
		{
			get
			{
				return (int)base[this.class173_0.DataColumn_0];
			}
			set
			{
				base[this.class173_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Raion
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class173_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Raion' in table 'tMapObj' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class173_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Street
		{
			get
			{
				return (int)base[this.class173_0.DataColumn_2];
			}
			set
			{
				base[this.class173_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int House
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class173_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'House' in table 'tMapObj' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class173_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string HousePrefix
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class173_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HousePrefix' in table 'tMapObj' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class173_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool IsHouse
		{
			get
			{
				return (bool)base[this.class173_0.DataColumn_5];
			}
			set
			{
				base[this.class173_0.DataColumn_5] = value;
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
					result = (string)base[this.class173_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Name' in table 'tMapObj' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class173_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Index
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class173_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Index' in table 'tMapObj' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class173_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double Latitude
		{
			get
			{
				double result;
				try
				{
					result = (double)base[this.class173_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Latitude' in table 'tMapObj' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class173_0.DataColumn_8] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double Longitude
		{
			get
			{
				double result;
				try
				{
					result = (double)base[this.class173_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Longitude' in table 'tMapObj' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class173_0.DataColumn_9] = value;
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
					result = (string)base[this.class173_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Comment' in table 'tMapObj' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class173_0.DataColumn_10] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Deleted
		{
			get
			{
				return (bool)base[this.class173_0.DataColumn_11];
			}
			set
			{
				base[this.class173_0.DataColumn_11] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class173_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class173_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class173_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class173_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class173_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class173_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class173_0.DataColumn_6);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class173_0.DataColumn_6] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class173_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class173_0.DataColumn_7] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_10()
		{
			return base.IsNull(this.class173_0.DataColumn_8);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_11()
		{
			base[this.class173_0.DataColumn_8] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class173_0.DataColumn_9);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class173_0.DataColumn_9] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_14()
		{
			return base.IsNull(this.class173_0.DataColumn_10);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_15()
		{
			base[this.class173_0.DataColumn_10] = Convert.DBNull;
		}

		private Class171.Class173 class173_0;
	}

	public class Class199 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class199(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class174_0 = (Class171.Class174)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idDamage
		{
			get
			{
				return (int)base[this.class174_0.idDamageColumn];
			}
			set
			{
				base[this.class174_0.idDamageColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Declarer
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class174_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Declarer' in table 'tJ_DamageLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class174_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DeclarerTel
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class174_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DeclarerTel' in table 'tJ_DamageLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class174_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DeclarerAddress
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class174_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DeclarerAddress' in table 'tJ_DamageLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class174_0.DataColumn_2] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class174_0.DataColumn_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class174_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class174_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class174_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class174_0.DataColumn_2);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5()
		{
			base[this.class174_0.DataColumn_2] = Convert.DBNull;
		}

		private Class171.Class174 class174_0;
	}

	public class Class200 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class200(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class175_0 = (Class171.Class175)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[this.class175_0.idColumn];
			}
			set
			{
				base[this.class175_0.idColumn] = value;
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
					result = (string)base[this.class175_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'FIO' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class175_0.DataColumn_0] = value;
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
					result = (DateTime)base[this.class175_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateBegin' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class175_0.DataColumn_1] = value;
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
					result = (DateTime)base[this.class175_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateEnd' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class175_0.DataColumn_2] = value;
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
					result = (int)base[this.class175_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idGroup' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class175_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string WorkerGroup
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class175_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'WorkerGroup' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class175_0.DataColumn_4] = value;
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
					result = (string)base[this.class175_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKey' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class175_0.DataColumn_5] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Description
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class175_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Description' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class175_0.DataColumn_6] = value;
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
					result = (int)base[this.class175_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idDescription' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class175_0.DataColumn_7] = value;
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
					result = (short)base[this.class175_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'GroupElectrical' in table 'vWorkerGroup' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class175_0.DataColumn_8] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class175_0.DataColumn_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class175_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class175_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class175_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class175_0.DataColumn_2);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5()
		{
			base[this.class175_0.DataColumn_2] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class175_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class175_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_8()
		{
			return base.IsNull(this.class175_0.DataColumn_4);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_9()
		{
			base[this.class175_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class175_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class175_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class175_0.DataColumn_6);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class175_0.DataColumn_6] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_14()
		{
			return base.IsNull(this.class175_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class175_0.DataColumn_7] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_16()
		{
			return base.IsNull(this.class175_0.DataColumn_8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_17()
		{
			base[this.class175_0.DataColumn_8] = Convert.DBNull;
		}

		private Class171.Class175 class175_0;
	}

	public class Class201 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class201(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class176_0 = (Class171.Class176)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[this.class176_0.idColumn];
			}
			set
			{
				base[this.class176_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idDamage
		{
			get
			{
				return (int)base[this.class176_0.idDamageColumn];
			}
			set
			{
				base[this.class176_0.idDamageColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateOn
		{
			get
			{
				return (DateTime)base[this.class176_0.dateOnColumn];
			}
			set
			{
				base[this.class176_0.dateOnColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int countSchmObj
		{
			get
			{
				return (int)base[this.class176_0.DataColumn_0];
			}
			set
			{
				base[this.class176_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal noAdmissionKWT
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class176_0.noAdmissionKWTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'noAdmissionKWT' in table 'tJ_DamageOn' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class176_0.noAdmissionKWTColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class176_0.noAdmissionKWTColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class176_0.noAdmissionKWTColumn] = Convert.DBNull;
		}

		private Class171.Class176 class176_0;
	}

	public class Class202 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class202(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class177_0 = (Class171.Class177)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class177_0.idColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.idColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string numRequest
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class177_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numRequest' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateDoc
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class177_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateDoc' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string defectLocation
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class177_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'defectLocation' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Reason
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class177_0.usaZcabGutT];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Reason' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.usaZcabGutT] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idSchmObj
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class177_0.idSchmObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idSchmObj' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.idSchmObjColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string schmObjName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class177_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'schmObjName' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.DataColumn_3] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Character
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class177_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Character' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.DataColumn_4] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime dateApply
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class177_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateApply' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string completedWork
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class177_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'completedWork' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.DataColumn_6] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string workCompiler
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class177_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'workCompiler' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string workApply
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class177_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'workApply' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.DataColumn_8] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string NetRegion
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class177_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NetRegion' in table 'ReportDailyLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class177_0.DataColumn_9] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class177_0.idColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class177_0.idColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class177_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class177_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class177_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5()
		{
			base[this.class177_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class177_0.DataColumn_2);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class177_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class177_0.usaZcabGutT);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_9()
		{
			base[this.class177_0.usaZcabGutT] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class177_0.idSchmObjColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class177_0.idSchmObjColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class177_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class177_0.DataColumn_3] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_14()
		{
			return base.IsNull(this.class177_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class177_0.DataColumn_4] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_16()
		{
			return base.IsNull(this.class177_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_17()
		{
			base[this.class177_0.DataColumn_5] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_18()
		{
			return base.IsNull(this.class177_0.DataColumn_6);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_19()
		{
			base[this.class177_0.DataColumn_6] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_20()
		{
			return base.IsNull(this.class177_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_21()
		{
			base[this.class177_0.DataColumn_7] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_22()
		{
			return base.IsNull(this.class177_0.DataColumn_8);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_23()
		{
			base[this.class177_0.DataColumn_8] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_24()
		{
			return base.IsNull(this.class177_0.DataColumn_9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_25()
		{
			base[this.class177_0.DataColumn_9] = Convert.DBNull;
		}

		private Class171.Class177 class177_0;
	}

	public class Class203 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class203(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class178_0 = (Class171.Class178)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[this.class178_0.idColumn];
			}
			set
			{
				base[this.class178_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime DateTemp
		{
			get
			{
				return (DateTime)base[this.class178_0.DataColumn_0];
			}
			set
			{
				base[this.class178_0.DataColumn_0] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short NightDown
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class178_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NightDown' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_1] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short NightUp
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class178_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NightUp' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public short DayDown
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class178_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DayDown' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public short DayUp
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class178_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DayUp' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_4] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short TempAverage
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class178_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TempAverage' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_5] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int Wind
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class178_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Wind' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public short SpeedDown
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class178_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SpeedDown' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_7] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short SpeedUp
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class178_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SpeedUp' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_8] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Comment
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class178_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Comment' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_9] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DateOwner
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class178_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateOwner' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_10] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idOwner
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class178_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idOwner' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_11] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Owner
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class178_0.DataColumn_12];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Owner' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_12] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Night
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class178_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Night' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_13] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Day
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class178_0.DataColumn_14];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Day' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_14] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Speed
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class178_0.DataColumn_15];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Speed' in table 'tJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class178_0.DataColumn_15] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class178_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class178_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class178_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class178_0.DataColumn_2] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class178_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class178_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class178_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class178_0.DataColumn_4] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_8()
		{
			return base.IsNull(this.class178_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class178_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class178_0.DataColumn_6);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_11()
		{
			base[this.class178_0.DataColumn_6] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class178_0.DataColumn_7);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class178_0.DataColumn_7] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool WgcZqdinvns()
		{
			return base.IsNull(this.class178_0.DataColumn_8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_14()
		{
			base[this.class178_0.DataColumn_8] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_15()
		{
			return base.IsNull(this.class178_0.DataColumn_9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_16()
		{
			base[this.class178_0.DataColumn_9] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_17()
		{
			return base.IsNull(this.class178_0.DataColumn_10);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_18()
		{
			base[this.class178_0.DataColumn_10] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_19()
		{
			return base.IsNull(this.class178_0.DataColumn_11);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_20()
		{
			base[this.class178_0.DataColumn_11] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_21()
		{
			return base.IsNull(this.class178_0.DataColumn_12);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_22()
		{
			base[this.class178_0.DataColumn_12] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_23()
		{
			return base.IsNull(this.class178_0.DataColumn_13);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void lweZqYjncs5()
		{
			base[this.class178_0.DataColumn_13] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_24()
		{
			return base.IsNull(this.class178_0.DataColumn_14);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_25()
		{
			base[this.class178_0.DataColumn_14] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_26()
		{
			return base.IsNull(this.class178_0.DataColumn_15);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_27()
		{
			base[this.class178_0.DataColumn_15] = Convert.DBNull;
		}

		private Class171.Class178 class178_0;
	}

	public class Class204 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class204(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class179_0 = (Class171.Class179)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[this.class179_0.idColumn];
			}
			set
			{
				base[this.class179_0.idColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime DateTemp
		{
			get
			{
				return (DateTime)base[this.class179_0.DataColumn_0];
			}
			set
			{
				base[this.class179_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public short NightDown
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class179_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NightDown' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_1] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short NightUp
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class179_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NightUp' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public short DayDown
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class179_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DayDown' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public short DayUp
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class179_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DayUp' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_4] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public short TempAverage
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class179_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TempAverage' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Wind
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class179_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Wind' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string WindName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class179_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'WindName' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public short SpeedDown
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class179_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SpeedDown' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_8] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public short SpeedUp
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class179_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SpeedUp' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_9] = value;
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
					result = (string)base[this.class179_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Comment' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_10] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime DateOwner
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class179_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateOwner' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_11] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idOwner
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class179_0.DataColumn_12];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idOwner' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_12] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Owner
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class179_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Owner' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_13] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Night
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class179_0.DataColumn_14];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Night' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_14] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Day
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class179_0.DataColumn_15];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Day' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_15] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Speed
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class179_0.DataColumn_16];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Speed' in table 'vJ_Temperature' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class179_0.DataColumn_16] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class179_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class179_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class179_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class179_0.DataColumn_2] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class179_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class179_0.DataColumn_3] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class179_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class179_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class179_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class179_0.DataColumn_5] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_10()
		{
			return base.IsNull(this.class179_0.DataColumn_6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class179_0.DataColumn_6] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class179_0.DataColumn_7);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class179_0.DataColumn_7] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_14()
		{
			return base.IsNull(this.class179_0.DataColumn_8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class179_0.DataColumn_8] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_16()
		{
			return base.IsNull(this.class179_0.DataColumn_9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_17()
		{
			base[this.class179_0.DataColumn_9] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_18()
		{
			return base.IsNull(this.class179_0.DataColumn_10);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_19()
		{
			base[this.class179_0.DataColumn_10] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_20()
		{
			return base.IsNull(this.class179_0.DataColumn_11);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_21()
		{
			base[this.class179_0.DataColumn_11] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_22()
		{
			return base.IsNull(this.class179_0.DataColumn_12);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_23()
		{
			base[this.class179_0.DataColumn_12] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_24()
		{
			return base.IsNull(this.class179_0.DataColumn_13);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_25()
		{
			base[this.class179_0.DataColumn_13] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_26()
		{
			return base.IsNull(this.class179_0.DataColumn_14);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_27()
		{
			base[this.class179_0.DataColumn_14] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_28()
		{
			return base.IsNull(this.class179_0.DataColumn_15);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_29()
		{
			base[this.class179_0.DataColumn_15] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_30()
		{
			return base.IsNull(this.class179_0.DataColumn_16);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_31()
		{
			base[this.class179_0.DataColumn_16] = Convert.DBNull;
		}

		private Class171.Class179 class179_0;
	}

	public class Class205 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class205(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class180_0 = (Class171.Class180)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int numNetRegion
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numNetRegion' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_0] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string netRegionValue
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class180_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'netRegionValue' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c11
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c11' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_2] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c12
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c12' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_3] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c13
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c13' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_4] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c14
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c14' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_5] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c15
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c15' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_6] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c16
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c16' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c17
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c17' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_8] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c18
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c18' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_9] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c19
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c19' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_10] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c21
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c21' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_11] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c22
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_12];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c22' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_12] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c23
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c23' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_13] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c24
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_14];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c24' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_14] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c25
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_15];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c25' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_15] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c26
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_16];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c26' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_16] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c27
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_17];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c27' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_17] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c31
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_18];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c31' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_18] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c32
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_19];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c32' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_19] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c33
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_20];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c33' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_20] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c34
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_21];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c34' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_21] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c35
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_22];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c35' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_22] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c36
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_23];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c36' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_23] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c37
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_24];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c37' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_24] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c41
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_25];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c41' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_25] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c42
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_26];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c42' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_26] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c43
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_27];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c43' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_27] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c44
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_28];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c44' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_28] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c45
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_29];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c45' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_29] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c46
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.ufmZhKeGqtF];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c46' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.ufmZhKeGqtF] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c51
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_30];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c51' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_30] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c52
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_31];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c52' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_31] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c53
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_32];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c53' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_32] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c54
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.pyoZeyhgvqT];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c54' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.pyoZeyhgvqT] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c55
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_33];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c55' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_33] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c56
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_34];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c56' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_34] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c57
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_35];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c57' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_35] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int c61
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_36];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c61' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_36] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int c62
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class180_0.DataColumn_37];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'c62' in table 'tReportIterruptLV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class180_0.DataColumn_37] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class180_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class180_0.DataColumn_0] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_2()
		{
			return base.IsNull(this.class180_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class180_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_4()
		{
			return base.IsNull(this.class180_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class180_0.DataColumn_2] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class180_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class180_0.DataColumn_3] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class180_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class180_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class180_0.DataColumn_5);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_11()
		{
			base[this.class180_0.DataColumn_5] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_12()
		{
			return base.IsNull(this.class180_0.DataColumn_6);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class180_0.DataColumn_6] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_14()
		{
			return base.IsNull(this.class180_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class180_0.DataColumn_7] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_16()
		{
			return base.IsNull(this.class180_0.DataColumn_8);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_17()
		{
			base[this.class180_0.DataColumn_8] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_18()
		{
			return base.IsNull(this.class180_0.DataColumn_9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_19()
		{
			base[this.class180_0.DataColumn_9] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_20()
		{
			return base.IsNull(this.class180_0.DataColumn_10);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_21()
		{
			base[this.class180_0.DataColumn_10] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_22()
		{
			return base.IsNull(this.class180_0.DataColumn_11);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_23()
		{
			base[this.class180_0.DataColumn_11] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_24()
		{
			return base.IsNull(this.class180_0.DataColumn_12);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_25()
		{
			base[this.class180_0.DataColumn_12] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_26()
		{
			return base.IsNull(this.class180_0.DataColumn_13);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_27()
		{
			base[this.class180_0.DataColumn_13] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_28()
		{
			return base.IsNull(this.class180_0.DataColumn_14);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_29()
		{
			base[this.class180_0.DataColumn_14] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_30()
		{
			return base.IsNull(this.class180_0.DataColumn_15);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_31()
		{
			base[this.class180_0.DataColumn_15] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_32()
		{
			return base.IsNull(this.class180_0.DataColumn_16);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_33()
		{
			base[this.class180_0.DataColumn_16] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_34()
		{
			return base.IsNull(this.class180_0.DataColumn_17);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_35()
		{
			base[this.class180_0.DataColumn_17] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_36()
		{
			return base.IsNull(this.class180_0.DataColumn_18);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_37()
		{
			base[this.class180_0.DataColumn_18] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_38()
		{
			return base.IsNull(this.class180_0.DataColumn_19);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_39()
		{
			base[this.class180_0.DataColumn_19] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_40()
		{
			return base.IsNull(this.class180_0.DataColumn_20);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_41()
		{
			base[this.class180_0.DataColumn_20] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_42()
		{
			return base.IsNull(this.class180_0.DataColumn_21);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_43()
		{
			base[this.class180_0.DataColumn_21] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_44()
		{
			return base.IsNull(this.class180_0.DataColumn_22);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_45()
		{
			base[this.class180_0.DataColumn_22] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_46()
		{
			return base.IsNull(this.class180_0.DataColumn_23);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_47()
		{
			base[this.class180_0.DataColumn_23] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_48()
		{
			return base.IsNull(this.class180_0.DataColumn_24);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_49()
		{
			base[this.class180_0.DataColumn_24] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_50()
		{
			return base.IsNull(this.class180_0.DataColumn_25);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_51()
		{
			base[this.class180_0.DataColumn_25] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_52()
		{
			return base.IsNull(this.class180_0.DataColumn_26);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_53()
		{
			base[this.class180_0.DataColumn_26] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_54()
		{
			return base.IsNull(this.class180_0.DataColumn_27);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_55()
		{
			base[this.class180_0.DataColumn_27] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_56()
		{
			return base.IsNull(this.class180_0.DataColumn_28);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_57()
		{
			base[this.class180_0.DataColumn_28] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_58()
		{
			return base.IsNull(this.class180_0.DataColumn_29);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_59()
		{
			base[this.class180_0.DataColumn_29] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_60()
		{
			return base.IsNull(this.class180_0.ufmZhKeGqtF);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_61()
		{
			base[this.class180_0.ufmZhKeGqtF] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_62()
		{
			return base.IsNull(this.class180_0.DataColumn_30);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_63()
		{
			base[this.class180_0.DataColumn_30] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_64()
		{
			return base.IsNull(this.class180_0.DataColumn_31);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_65()
		{
			base[this.class180_0.DataColumn_31] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_66()
		{
			return base.IsNull(this.class180_0.DataColumn_32);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_67()
		{
			base[this.class180_0.DataColumn_32] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_68()
		{
			return base.IsNull(this.class180_0.pyoZeyhgvqT);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_69()
		{
			base[this.class180_0.pyoZeyhgvqT] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_70()
		{
			return base.IsNull(this.class180_0.DataColumn_33);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_71()
		{
			base[this.class180_0.DataColumn_33] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_72()
		{
			return base.IsNull(this.class180_0.DataColumn_34);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_73()
		{
			base[this.class180_0.DataColumn_34] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_74()
		{
			return base.IsNull(this.class180_0.DataColumn_35);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_75()
		{
			base[this.class180_0.DataColumn_35] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_76()
		{
			return base.IsNull(this.class180_0.DataColumn_36);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_77()
		{
			base[this.class180_0.DataColumn_36] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_78()
		{
			return base.IsNull(this.class180_0.DataColumn_37);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_79()
		{
			base[this.class180_0.DataColumn_37] = Convert.DBNull;
		}

		private Class171.Class180 class180_0;
	}

	public class Class206 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class206(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class181_0 = (Class171.Class181)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class181_0.idColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id' in table 'ReportDailyDefect' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class181_0.idColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string numRequest
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class181_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numRequest' in table 'ReportDailyDefect' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class181_0.DataColumn_0] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime dateDoc
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class181_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateDoc' in table 'ReportDailyDefect' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class181_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idDivisionApply
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class181_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idDivisionApply' in table 'ReportDailyDefect' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class181_0.DataColumn_2] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string DivisionApply
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class181_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DivisionApply' in table 'ReportDailyDefect' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class181_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DivisionInstruction
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class181_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DivisionInstruction' in table 'ReportDailyDefect' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class181_0.DataColumn_4] = value;
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
					result = (decimal)base[this.class181_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Value' in table 'ReportDailyDefect' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class181_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string numRequestParent
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class181_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numRequestParent' in table 'ReportDailyDefect' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class181_0.DataColumn_6] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DateTime dateDocParent
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class181_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateDocParent' in table 'ReportDailyDefect' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class181_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string typeDocParent
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class181_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typeDocParent' in table 'ReportDailyDefect' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class181_0.DataColumn_8] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool isApply
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class181_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isApply' in table 'ReportDailyDefect' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class181_0.DataColumn_9] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class181_0.idColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class181_0.idColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_2()
		{
			return base.IsNull(this.class181_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class181_0.DataColumn_0] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_4()
		{
			return base.IsNull(this.class181_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class181_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class181_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class181_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class181_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class181_0.DataColumn_3] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class181_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class181_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class181_0.DataColumn_5);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class181_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_14()
		{
			return base.IsNull(this.class181_0.DataColumn_6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class181_0.DataColumn_6] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_16()
		{
			return base.IsNull(this.class181_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_17()
		{
			base[this.class181_0.DataColumn_7] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_18()
		{
			return base.IsNull(this.class181_0.DataColumn_8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_19()
		{
			base[this.class181_0.DataColumn_8] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_20()
		{
			return base.IsNull(this.class181_0.DataColumn_9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_21()
		{
			base[this.class181_0.DataColumn_9] = Convert.DBNull;
		}

		private Class171.Class181 class181_0;
	}

	public class Class207 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class207(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class182_0 = (Class171.Class182)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[this.class182_0.idColumn];
			}
			set
			{
				base[this.class182_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int numDoc
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class182_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numDoc' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateDoc
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class182_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateDoc' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime datePlanEnd
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class182_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'datePlanEnd' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string numrequest
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numrequest' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int TypeDoc
		{
			get
			{
				return (int)base[this.class182_0.DataColumn_4];
			}
			set
			{
				base[this.class182_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TypeDocName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TypeDocName' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idCompiler
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class182_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idCompiler' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string compiler
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.phsZwXoscks];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'compiler' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.phsZwXoscks] = value;
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
					result = (int)base[this.class182_0.idDivisionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idDivision' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.idDivisionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Division
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Division' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idSchmObj
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class182_0.idSchmObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idSchmObj' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.idSchmObjColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string schmObjName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'schmObjName' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_8] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idSub
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class182_0.idSubColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idSub' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.idSubColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NetRegionSub
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NetRegionSub' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_9] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idMap
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class182_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idMap' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_10] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string defectLocation
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'defectLocation' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_11] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idReason
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class182_0.DataColumn_12];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idReason' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_12] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Reason
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Reason' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_13] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idCompletedWork
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class182_0.DataColumn_14];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idCompletedWork' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_14] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string completedWork
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_15];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'completedWork' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_15] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ComletedWorkText
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_16];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ComletedWorkText' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_16] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool isApply
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class182_0.DataColumn_17];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isApply' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_17] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idWorkerApply
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class182_0.DataColumn_18];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idWorkerApply' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_18] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string workerApply
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_19];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'workerApply' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_19] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateApply
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class182_0.DataColumn_20];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateApply' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_20] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idDivisionApply
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class182_0.DataColumn_21];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idDivisionApply' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_21] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string DivisionApply
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_22];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DivisionApply' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_22] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool isLaboratory
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class182_0.DataColumn_23];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isLaboratory' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_23] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idParent
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class182_0.DataColumn_24];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idParent' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_24] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ownerName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_25];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ownerName' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_25] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateOwner
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class182_0.DataColumn_26];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateOwner' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_26] = value;
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
					result = (string)base[this.class182_0.DataColumn_27];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'KodPTSStr' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_27] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal KodPTS
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class182_0.DataColumn_28];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'KodPTS' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_28] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Instruction
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_29];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Instruction' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_29] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idReqForRepair
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class182_0.DataColumn_30];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idReqForRepair' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_30] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool deleted
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class182_0.DataColumn_31];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'deleted' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_31] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string numcrash
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_32];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numcrash' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_32] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string signCrashType
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_33];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'signCrashType' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_33] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string signCrashName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_34];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'signCrashName' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_34] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string typeEquip
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_35];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typeEquip' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_35] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string typeEquipName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_36];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typeEquipName' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_36] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string reasonCrashEquipType
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_37];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'reasonCrashEquipType' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_37] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string reasonCrashEquipName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_38];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'reasonCrashEquipName' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_38] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string reasonCrashType
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_39];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'reasonCrashType' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_39] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string reasonCrashName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_40];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'reasonCrashName' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_40] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool Boolean_0
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class182_0.DataColumn_41];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isNoSESNO' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_41] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Character
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_42];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Character' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_42] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string City
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_43];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'City' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_43] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Street
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class182_0.DataColumn_44];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Street' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_44] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool is81
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class182_0.DataColumn_45];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'is81' in table 'vJ_Damage' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class182_0.DataColumn_45] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class182_0.DataColumn_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class182_0.DataColumn_0] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_2()
		{
			return base.IsNull(this.class182_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class182_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_4()
		{
			return base.IsNull(this.class182_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class182_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class182_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class182_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_8()
		{
			return base.IsNull(this.class182_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class182_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class182_0.DataColumn_6);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_11()
		{
			base[this.class182_0.DataColumn_6] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class182_0.phsZwXoscks);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class182_0.phsZwXoscks] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_14()
		{
			return base.IsNull(this.class182_0.idDivisionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class182_0.idDivisionColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_16()
		{
			return base.IsNull(this.class182_0.DataColumn_7);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_17()
		{
			base[this.class182_0.DataColumn_7] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_18()
		{
			return base.IsNull(this.class182_0.idSchmObjColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_19()
		{
			base[this.class182_0.idSchmObjColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_20()
		{
			return base.IsNull(this.class182_0.DataColumn_8);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_21()
		{
			base[this.class182_0.DataColumn_8] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_22()
		{
			return base.IsNull(this.class182_0.idSubColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_23()
		{
			base[this.class182_0.idSubColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_24()
		{
			return base.IsNull(this.class182_0.DataColumn_9);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_25()
		{
			base[this.class182_0.DataColumn_9] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_26()
		{
			return base.IsNull(this.class182_0.DataColumn_10);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_27()
		{
			base[this.class182_0.DataColumn_10] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_28()
		{
			return base.IsNull(this.class182_0.DataColumn_11);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_29()
		{
			base[this.class182_0.DataColumn_11] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_30()
		{
			return base.IsNull(this.class182_0.DataColumn_12);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_31()
		{
			base[this.class182_0.DataColumn_12] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_32()
		{
			return base.IsNull(this.class182_0.DataColumn_13);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_33()
		{
			base[this.class182_0.DataColumn_13] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_34()
		{
			return base.IsNull(this.class182_0.DataColumn_14);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_35()
		{
			base[this.class182_0.DataColumn_14] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_36()
		{
			return base.IsNull(this.class182_0.DataColumn_15);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_37()
		{
			base[this.class182_0.DataColumn_15] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_38()
		{
			return base.IsNull(this.class182_0.DataColumn_16);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_39()
		{
			base[this.class182_0.DataColumn_16] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_40()
		{
			return base.IsNull(this.class182_0.DataColumn_17);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_41()
		{
			base[this.class182_0.DataColumn_17] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_42()
		{
			return base.IsNull(this.class182_0.DataColumn_18);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_43()
		{
			base[this.class182_0.DataColumn_18] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_44()
		{
			return base.IsNull(this.class182_0.DataColumn_19);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_45()
		{
			base[this.class182_0.DataColumn_19] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_46()
		{
			return base.IsNull(this.class182_0.DataColumn_20);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_47()
		{
			base[this.class182_0.DataColumn_20] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_48()
		{
			return base.IsNull(this.class182_0.DataColumn_21);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_49()
		{
			base[this.class182_0.DataColumn_21] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_50()
		{
			return base.IsNull(this.class182_0.DataColumn_22);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_51()
		{
			base[this.class182_0.DataColumn_22] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_52()
		{
			return base.IsNull(this.class182_0.DataColumn_23);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_53()
		{
			base[this.class182_0.DataColumn_23] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_54()
		{
			return base.IsNull(this.class182_0.DataColumn_24);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_55()
		{
			base[this.class182_0.DataColumn_24] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_56()
		{
			return base.IsNull(this.class182_0.DataColumn_25);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_57()
		{
			base[this.class182_0.DataColumn_25] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_58()
		{
			return base.IsNull(this.class182_0.DataColumn_26);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_59()
		{
			base[this.class182_0.DataColumn_26] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_60()
		{
			return base.IsNull(this.class182_0.DataColumn_27);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_61()
		{
			base[this.class182_0.DataColumn_27] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_62()
		{
			return base.IsNull(this.class182_0.DataColumn_28);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_63()
		{
			base[this.class182_0.DataColumn_28] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_64()
		{
			return base.IsNull(this.class182_0.DataColumn_29);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_65()
		{
			base[this.class182_0.DataColumn_29] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_66()
		{
			return base.IsNull(this.class182_0.DataColumn_30);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_67()
		{
			base[this.class182_0.DataColumn_30] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_68()
		{
			return base.IsNull(this.class182_0.DataColumn_31);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_69()
		{
			base[this.class182_0.DataColumn_31] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_70()
		{
			return base.IsNull(this.class182_0.DataColumn_32);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_71()
		{
			base[this.class182_0.DataColumn_32] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_72()
		{
			return base.IsNull(this.class182_0.DataColumn_33);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_73()
		{
			base[this.class182_0.DataColumn_33] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_74()
		{
			return base.IsNull(this.class182_0.DataColumn_34);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_75()
		{
			base[this.class182_0.DataColumn_34] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_76()
		{
			return base.IsNull(this.class182_0.DataColumn_35);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_77()
		{
			base[this.class182_0.DataColumn_35] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_78()
		{
			return base.IsNull(this.class182_0.DataColumn_36);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_79()
		{
			base[this.class182_0.DataColumn_36] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_80()
		{
			return base.IsNull(this.class182_0.DataColumn_37);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_81()
		{
			base[this.class182_0.DataColumn_37] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_82()
		{
			return base.IsNull(this.class182_0.DataColumn_38);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_83()
		{
			base[this.class182_0.DataColumn_38] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_84()
		{
			return base.IsNull(this.class182_0.DataColumn_39);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_85()
		{
			base[this.class182_0.DataColumn_39] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_86()
		{
			return base.IsNull(this.class182_0.DataColumn_40);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_87()
		{
			base[this.class182_0.DataColumn_40] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_88()
		{
			return base.IsNull(this.class182_0.DataColumn_41);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_89()
		{
			base[this.class182_0.DataColumn_41] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_90()
		{
			return base.IsNull(this.class182_0.DataColumn_42);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_91()
		{
			base[this.class182_0.DataColumn_42] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_92()
		{
			return base.IsNull(this.class182_0.DataColumn_43);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_93()
		{
			base[this.class182_0.DataColumn_43] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_94()
		{
			return base.IsNull(this.class182_0.DataColumn_44);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_95()
		{
			base[this.class182_0.DataColumn_44] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_96()
		{
			return base.IsNull(this.class182_0.DataColumn_45);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_97()
		{
			base[this.class182_0.DataColumn_45] = Convert.DBNull;
		}

		private Class171.Class182 class182_0;
	}

	public class Class208 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class208(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class183_0 = (Class171.Class183)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class183_0.idColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string numRequest
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class183_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numRequest' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string schmObjName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class183_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'schmObjName' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string subscriber
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class183_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'subscriber' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal PowerA
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class183_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PowerA' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int CountSchmObj
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class183_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CountSchmObj' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal ConnectedPower
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class183_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ConnectedPower' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateDoc
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class183_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateDoc' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateApply
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class183_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateApply' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string typeRZA
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class183_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typeRZA' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_8] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal NoAdmissionKWT
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class183_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoAdmissionKWT' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_9] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string reasonAndLocation
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class183_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'reasonAndLocation' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_10] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Character
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class183_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Character' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_11] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string completedWork
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class183_0.DataColumn_12];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'completedWork' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_12] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Compiler
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class183_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Compiler' in table 'ReportDailyHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class183_0.DataColumn_13] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class183_0.idColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class183_0.idColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class183_0.DataColumn_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class183_0.DataColumn_0] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_4()
		{
			return base.IsNull(this.class183_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5()
		{
			base[this.class183_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class183_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class183_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class183_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class183_0.DataColumn_3] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class183_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class183_0.DataColumn_4] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_12()
		{
			return base.IsNull(this.class183_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_13()
		{
			base[this.class183_0.DataColumn_5] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_14()
		{
			return base.IsNull(this.class183_0.DataColumn_6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class183_0.DataColumn_6] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_16()
		{
			return base.IsNull(this.class183_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_17()
		{
			base[this.class183_0.DataColumn_7] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_18()
		{
			return base.IsNull(this.class183_0.DataColumn_8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_19()
		{
			base[this.class183_0.DataColumn_8] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_20()
		{
			return base.IsNull(this.class183_0.DataColumn_9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_21()
		{
			base[this.class183_0.DataColumn_9] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_22()
		{
			return base.IsNull(this.class183_0.DataColumn_10);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_23()
		{
			base[this.class183_0.DataColumn_10] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_24()
		{
			return base.IsNull(this.class183_0.DataColumn_11);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_25()
		{
			base[this.class183_0.DataColumn_11] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_26()
		{
			return base.IsNull(this.class183_0.DataColumn_12);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_27()
		{
			base[this.class183_0.DataColumn_12] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_28()
		{
			return base.IsNull(this.class183_0.DataColumn_13);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_29()
		{
			base[this.class183_0.DataColumn_13] = Convert.DBNull;
		}

		private Class171.Class183 class183_0;
	}

	public class Class209 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class209(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class184_0 = (Class171.tJ_DamageCharacterDataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[this.class184_0.idColumn];
			}
			set
			{
				base[this.class184_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idDamage
		{
			get
			{
				return (int)base[this.class184_0.idDamageColumn];
			}
			set
			{
				base[this.class184_0.idDamageColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int col1
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'col1' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int col2
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'col2' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int col3
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'col3' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idSchmObj
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.idSchmObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idSchmObj' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.idSchmObjColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idLineSection
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.idLineSectionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idLineSection' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.idLineSectionColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idCharacterParent
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idCharacterParent' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Parameters
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class184_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Parameters' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idMark
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idMark' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idParameters
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idParameters' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idVoltage
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idVoltage' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int nodeDetail
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'nodeDetail' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_8] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string nodeDetailTxt
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class184_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'nodeDetailTxt' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_9] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int CountDefectEquipment
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CountDefectEquipment' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_10] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idVoltageSeti
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idVoltageSeti' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_11] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool AutoProtect
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class184_0.DataColumn_12];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'AutoProtect' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_12] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Manufacturer
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class184_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Manufacturer' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_13] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string FactoryNumber
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class184_0.DataColumn_14];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'FactoryNumber' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_14] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public short YearManufacture
		{
			get
			{
				short result;
				try
				{
					result = (short)base[this.class184_0.DataColumn_15];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'YearManufacture' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_15] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idNeutralState
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_16];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idNeutralState' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_16] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int ClauseFail
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_17];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ClauseFail' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_17] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int LengthOverload
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_18];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'LengthOverload' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_18] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int LengthLine
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_19];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'LengthLine' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_19] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idMaterial
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_20];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idMaterial' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_20] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int ClauseWork
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_21];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ClauseWork' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_21] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idCharacterDamage
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_22];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idCharacterDamage' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_22] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idReasonDamage
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_23];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idReasonDamage' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_23] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string AssociatedFact
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class184_0.DataColumn_24];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'AssociatedFact' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_24] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int yearBegEquipment
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_25];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'yearBegEquipment' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_25] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int lenghtWorkEquipment
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class184_0.DataColumn_26];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'lenghtWorkEquipment' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_26] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime LastDateTest
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class184_0.DataColumn_27];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'LastDateTest' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_27] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime timeRecovery
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class184_0.DataColumn_28];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'timeRecovery' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_28] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SchmObjName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class184_0.DataColumn_29];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SchmObjName' in table 'tJ_DamageCharacter' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class184_0.DataColumn_29] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class184_0.DataColumn_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class184_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class184_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class184_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_4()
		{
			return base.IsNull(this.class184_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class184_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class184_0.idSchmObjColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class184_0.idSchmObjColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_8()
		{
			return base.IsNull(this.class184_0.idLineSectionColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class184_0.idLineSectionColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_10()
		{
			return base.IsNull(this.class184_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class184_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_12()
		{
			return base.IsNull(this.class184_0.DataColumn_4);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class184_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_14()
		{
			return base.IsNull(this.class184_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class184_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_16()
		{
			return base.IsNull(this.class184_0.DataColumn_6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_17()
		{
			base[this.class184_0.DataColumn_6] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_18()
		{
			return base.IsNull(this.class184_0.DataColumn_7);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_19()
		{
			base[this.class184_0.DataColumn_7] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_20()
		{
			return base.IsNull(this.class184_0.DataColumn_8);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_21()
		{
			base[this.class184_0.DataColumn_8] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_22()
		{
			return base.IsNull(this.class184_0.DataColumn_9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_23()
		{
			base[this.class184_0.DataColumn_9] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_24()
		{
			return base.IsNull(this.class184_0.DataColumn_10);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_25()
		{
			base[this.class184_0.DataColumn_10] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_26()
		{
			return base.IsNull(this.class184_0.DataColumn_11);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_27()
		{
			base[this.class184_0.DataColumn_11] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_28()
		{
			return base.IsNull(this.class184_0.DataColumn_12);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_29()
		{
			base[this.class184_0.DataColumn_12] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_30()
		{
			return base.IsNull(this.class184_0.DataColumn_13);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_31()
		{
			base[this.class184_0.DataColumn_13] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_32()
		{
			return base.IsNull(this.class184_0.DataColumn_14);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_33()
		{
			base[this.class184_0.DataColumn_14] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_34()
		{
			return base.IsNull(this.class184_0.DataColumn_15);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_35()
		{
			base[this.class184_0.DataColumn_15] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_36()
		{
			return base.IsNull(this.class184_0.DataColumn_16);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_37()
		{
			base[this.class184_0.DataColumn_16] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_38()
		{
			return base.IsNull(this.class184_0.DataColumn_17);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_39()
		{
			base[this.class184_0.DataColumn_17] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_40()
		{
			return base.IsNull(this.class184_0.DataColumn_18);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_41()
		{
			base[this.class184_0.DataColumn_18] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_42()
		{
			return base.IsNull(this.class184_0.DataColumn_19);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_43()
		{
			base[this.class184_0.DataColumn_19] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_44()
		{
			return base.IsNull(this.class184_0.DataColumn_20);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_45()
		{
			base[this.class184_0.DataColumn_20] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_46()
		{
			return base.IsNull(this.class184_0.DataColumn_21);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_47()
		{
			base[this.class184_0.DataColumn_21] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_48()
		{
			return base.IsNull(this.class184_0.DataColumn_22);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_49()
		{
			base[this.class184_0.DataColumn_22] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_50()
		{
			return base.IsNull(this.class184_0.DataColumn_23);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_51()
		{
			base[this.class184_0.DataColumn_23] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_52()
		{
			return base.IsNull(this.class184_0.DataColumn_24);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_53()
		{
			base[this.class184_0.DataColumn_24] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_54()
		{
			return base.IsNull(this.class184_0.DataColumn_25);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_55()
		{
			base[this.class184_0.DataColumn_25] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_56()
		{
			return base.IsNull(this.class184_0.DataColumn_26);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_57()
		{
			base[this.class184_0.DataColumn_26] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_58()
		{
			return base.IsNull(this.class184_0.DataColumn_27);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_59()
		{
			base[this.class184_0.DataColumn_27] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_60()
		{
			return base.IsNull(this.class184_0.DataColumn_28);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_61()
		{
			base[this.class184_0.DataColumn_28] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_62()
		{
			return base.IsNull(this.class184_0.DataColumn_29);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_63()
		{
			base[this.class184_0.DataColumn_29] = Convert.DBNull;
		}

		private Class171.tJ_DamageCharacterDataTable class184_0;
	}

	public class Class210 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class210(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class185_0 = (Class171.Class185)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idDamage
		{
			get
			{
				return (int)base[this.class185_0.idDamageColumn];
			}
			set
			{
				base[this.class185_0.idDamageColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idOrg
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class185_0.idOrgColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idOrg' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.idOrgColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idSignCrash
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class185_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idSignCrash' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idTypeEquipment
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class185_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idTypeEquipment' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idReasonCrash
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class185_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idReasonCrash' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idReasonCrashEquipment
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class185_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idReasonCrashEquipment' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateEndCrashLocal
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class185_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateEndCrashLocal' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateEndCrashMoscow
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class185_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateEndCrashMoscow' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idStatusBeforeCrash
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class185_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idStatusBeforeCrash' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool isCrash
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class185_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isCrash' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool isNoOff
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class185_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isNoOff' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_8] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NoCrashMeasure
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class185_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoCrashMeasure' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_9] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idStatusCurrentCrash
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class185_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idStatusCurrentCrash' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_10] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Defection
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class185_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Defection' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_11] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idReasonBeginCrash
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class185_0.DataColumn_12];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idReasonBeginCrash' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_12] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idClassifierDamage
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class185_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idClassifierDamage' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_13] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idFault
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class185_0.DataColumn_14];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idFault' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_14] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Comission
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class185_0.DataColumn_15];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Comission' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_15] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TotalComission
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class185_0.DataColumn_16];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TotalComission' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_16] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string numCrash
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class185_0.DataColumn_17];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numCrash' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_17] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string StatusCurrentCrash
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class185_0.DataColumn_18];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'StatusCurrentCrash' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_18] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string ReasonBeginCrash
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class185_0.DataColumn_19];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ReasonBeginCrash' in table 'tJ_DamageActDetection' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class185_0.DataColumn_19] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class185_0.idOrgColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class185_0.idOrgColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class185_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class185_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class185_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class185_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class185_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class185_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class185_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_9()
		{
			base[this.class185_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_10()
		{
			return base.IsNull(this.class185_0.DataColumn_4);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_11()
		{
			base[this.class185_0.DataColumn_4] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_12()
		{
			return base.IsNull(this.class185_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_13()
		{
			base[this.class185_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_14()
		{
			return base.IsNull(this.class185_0.DataColumn_6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class185_0.DataColumn_6] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_16()
		{
			return base.IsNull(this.class185_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_17()
		{
			base[this.class185_0.DataColumn_7] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_18()
		{
			return base.IsNull(this.class185_0.DataColumn_8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_19()
		{
			base[this.class185_0.DataColumn_8] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_20()
		{
			return base.IsNull(this.class185_0.DataColumn_9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_21()
		{
			base[this.class185_0.DataColumn_9] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_22()
		{
			return base.IsNull(this.class185_0.DataColumn_10);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_23()
		{
			base[this.class185_0.DataColumn_10] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_24()
		{
			return base.IsNull(this.class185_0.DataColumn_11);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_25()
		{
			base[this.class185_0.DataColumn_11] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_26()
		{
			return base.IsNull(this.class185_0.DataColumn_12);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_27()
		{
			base[this.class185_0.DataColumn_12] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_28()
		{
			return base.IsNull(this.class185_0.DataColumn_13);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_29()
		{
			base[this.class185_0.DataColumn_13] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_30()
		{
			return base.IsNull(this.class185_0.DataColumn_14);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_31()
		{
			base[this.class185_0.DataColumn_14] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_32()
		{
			return base.IsNull(this.class185_0.DataColumn_15);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_33()
		{
			base[this.class185_0.DataColumn_15] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_34()
		{
			return base.IsNull(this.class185_0.DataColumn_16);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_35()
		{
			base[this.class185_0.DataColumn_16] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_36()
		{
			return base.IsNull(this.class185_0.DataColumn_17);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_37()
		{
			base[this.class185_0.DataColumn_17] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_38()
		{
			return base.IsNull(this.class185_0.DataColumn_18);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_39()
		{
			base[this.class185_0.DataColumn_18] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_40()
		{
			return base.IsNull(this.class185_0.DataColumn_19);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_41()
		{
			base[this.class185_0.DataColumn_19] = Convert.DBNull;
		}

		private Class171.Class185 class185_0;
	}

	public class Class211 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class211(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class186_0 = (Class171.Class186)base.Table;
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
					result = (string)base[this.class186_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Description' in table 'table23' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class186_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string NPA
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class186_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NPA' in table 'table23' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class186_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string PunktNPA
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class186_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PunktNPA' in table 'table23' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class186_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Org
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class186_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Org' in table 'table23' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class186_0.DataColumn_3] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class186_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class186_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class186_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class186_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class186_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class186_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class186_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class186_0.DataColumn_3] = Convert.DBNull;
		}

		private Class171.Class186 class186_0;
	}

	public class Class212 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class212(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class187_0 = (Class171.Class187)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Measure
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class187_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Measure' in table 'table31' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class187_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Date
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class187_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Date' in table 'table31' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class187_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Org
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class187_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Org' in table 'table31' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class187_0.DataColumn_2] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class187_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class187_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class187_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class187_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class187_0.DataColumn_2);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5()
		{
			base[this.class187_0.DataColumn_2] = Convert.DBNull;
		}

		private Class171.Class187 class187_0;
	}

	public class Class213 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class213(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class188_0 = (Class171.Class188)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string num
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class188_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'num' in table 'table4' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class188_0.DataColumn_0] = value;
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
					result = (string)base[this.class188_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Description' in table 'table4' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class188_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class188_0.DataColumn_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class188_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class188_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class188_0.DataColumn_1] = Convert.DBNull;
		}

		private Class171.Class188 class188_0;
	}

	public class Class214 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class214(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class189_0 = (Class171.Class189)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idDamage
		{
			get
			{
				return (int)base[this.class189_0.idDamageColumn];
			}
			set
			{
				base[this.class189_0.idDamageColumn] = value;
			}
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
					result = (int)base[this.class189_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idTypeRZA' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class189_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int CountSchmObj
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class189_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CountSchmObj' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class189_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int CountSchmObjOff
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class189_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CountSchmObjOff' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class189_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal ConnectedPower
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class189_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ConnectedPower' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class189_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal CoefFI
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class189_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CoefFI' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class189_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal NoAdmissionKWT
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class189_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoAdmissionKWT' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class189_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool AVR
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class189_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'AVR' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class189_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool APR
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class189_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'APR' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class189_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal PowerA
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class189_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PowerA' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class189_0.DataColumn_8] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal PowerV
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class189_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PowerV' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class189_0.DataColumn_9] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal CoefSeason
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class189_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CoefSeason' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class189_0.DataColumn_10] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool isAverage
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class189_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isAverage' in table 'tJ_DamageHV' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class189_0.DataColumn_11] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class189_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class189_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class189_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class189_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_4()
		{
			return base.IsNull(this.class189_0.DataColumn_2);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5()
		{
			base[this.class189_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class189_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class189_0.DataColumn_3] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class189_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class189_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class189_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class189_0.DataColumn_5] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_12()
		{
			return base.IsNull(this.class189_0.DataColumn_6);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class189_0.DataColumn_6] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_14()
		{
			return base.IsNull(this.class189_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class189_0.DataColumn_7] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_16()
		{
			return base.IsNull(this.class189_0.DataColumn_8);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_17()
		{
			base[this.class189_0.DataColumn_8] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_18()
		{
			return base.IsNull(this.class189_0.DataColumn_9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_19()
		{
			base[this.class189_0.DataColumn_9] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_20()
		{
			return base.IsNull(this.class189_0.DataColumn_10);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_21()
		{
			base[this.class189_0.DataColumn_10] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_22()
		{
			return base.IsNull(this.class189_0.DataColumn_11);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_23()
		{
			base[this.class189_0.DataColumn_11] = Convert.DBNull;
		}

		private Class171.Class189 class189_0;
	}

	public class Class215 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class215(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class190_0 = (Class171.Class190)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class190_0.idColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id' in table 'tReportDetectionCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class190_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int Month
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class190_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Month' in table 'tReportDetectionCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class190_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id756
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class190_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id756' in table 'tReportDetectionCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class190_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id757
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class190_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id757' in table 'tReportDetectionCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class190_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id758
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class190_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id758' in table 'tReportDetectionCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class190_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id759
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class190_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id759' in table 'tReportDetectionCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class190_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id1518
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class190_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id1518' in table 'tReportDetectionCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class190_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id1519
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class190_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id1519' in table 'tReportDetectionCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class190_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id1520
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class190_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id1520' in table 'tReportDetectionCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class190_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool isCrash
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class190_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isCrash' in table 'tReportDetectionCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class190_0.DataColumn_8] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string id2308
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class190_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id2308' in table 'tReportDetectionCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class190_0.DataColumn_9] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class190_0.idColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class190_0.idColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class190_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class190_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class190_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class190_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class190_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class190_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class190_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class190_0.DataColumn_3] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_10()
		{
			return base.IsNull(this.class190_0.DataColumn_4);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_11()
		{
			base[this.class190_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class190_0.DataColumn_5);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class190_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_14()
		{
			return base.IsNull(this.class190_0.DataColumn_6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class190_0.DataColumn_6] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_16()
		{
			return base.IsNull(this.class190_0.DataColumn_7);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_17()
		{
			base[this.class190_0.DataColumn_7] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_18()
		{
			return base.IsNull(this.class190_0.DataColumn_8);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_19()
		{
			base[this.class190_0.DataColumn_8] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_20()
		{
			return base.IsNull(this.class190_0.DataColumn_9);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_21()
		{
			base[this.class190_0.DataColumn_9] = Convert.DBNull;
		}

		private Class171.Class190 class190_0;
	}

	public class Class216 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class216(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class191_0 = (Class171.tReportDetectionReasonCrashDataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class191_0.idColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id' in table 'tReportDetectionReasonCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class191_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int reasonCode
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class191_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'reasonCode' in table 'tReportDetectionReasonCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class191_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Reason
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class191_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Reason' in table 'tReportDetectionReasonCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class191_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id756
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class191_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id756' in table 'tReportDetectionReasonCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class191_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id757
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class191_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id757' in table 'tReportDetectionReasonCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class191_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id758
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class191_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id758' in table 'tReportDetectionReasonCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class191_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id759
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class191_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id759' in table 'tReportDetectionReasonCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class191_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id1518
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class191_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id1518' in table 'tReportDetectionReasonCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class191_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id1519
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class191_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id1519' in table 'tReportDetectionReasonCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class191_0.DataColumn_7] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id1520
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class191_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id1520' in table 'tReportDetectionReasonCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class191_0.DataColumn_8] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool isCrash
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class191_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isCrash' in table 'tReportDetectionReasonCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class191_0.DataColumn_9] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string id2308
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class191_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id2308' in table 'tReportDetectionReasonCrash' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class191_0.DataColumn_10] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class191_0.idColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class191_0.idColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class191_0.DataColumn_0);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class191_0.DataColumn_0] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_4()
		{
			return base.IsNull(this.class191_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class191_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class191_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class191_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class191_0.DataColumn_3);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class191_0.DataColumn_3] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class191_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class191_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class191_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_13()
		{
			base[this.class191_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_14()
		{
			return base.IsNull(this.class191_0.DataColumn_6);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_15()
		{
			base[this.class191_0.DataColumn_6] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_16()
		{
			return base.IsNull(this.class191_0.DataColumn_7);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_17()
		{
			base[this.class191_0.DataColumn_7] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_18()
		{
			return base.IsNull(this.class191_0.DataColumn_8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_19()
		{
			base[this.class191_0.DataColumn_8] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_20()
		{
			return base.IsNull(this.class191_0.DataColumn_9);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_21()
		{
			base[this.class191_0.DataColumn_9] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_22()
		{
			return base.IsNull(this.class191_0.DataColumn_10);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_23()
		{
			base[this.class191_0.DataColumn_10] = Convert.DBNull;
		}

		private Class171.tReportDetectionReasonCrashDataTable class191_0;
	}

	public class Class217 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class217(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class192_0 = (Class171.Class192)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int typeNetReg
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class192_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typeNetReg' in table 'tReportDetectionNetReg' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class192_0.DataColumn_0] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id1518
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class192_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id1518' in table 'tReportDetectionNetReg' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class192_0.DataColumn_1] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id1519
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class192_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id1519' in table 'tReportDetectionNetReg' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class192_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id1520
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class192_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id1520' in table 'tReportDetectionNetReg' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class192_0.DataColumn_3] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool isCrash
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class192_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isCrash' in table 'tReportDetectionNetReg' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class192_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string id2308
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class192_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id2308' in table 'tReportDetectionNetReg' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class192_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class192_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class192_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class192_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class192_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_4()
		{
			return base.IsNull(this.class192_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class192_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class192_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class192_0.DataColumn_3] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class192_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class192_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class192_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class192_0.DataColumn_5] = Convert.DBNull;
		}

		private Class171.Class192 class192_0;
	}

	public class Class218 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class218(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class193_0 = (Class171.Class193)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int isCrash
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class193_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isCrash' in table 'tReportDetectionNoAdmissKWT' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class193_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id756
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class193_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id756' in table 'tReportDetectionNoAdmissKWT' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class193_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id757
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class193_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id757' in table 'tReportDetectionNoAdmissKWT' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class193_0.DataColumn_2] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int id758
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class193_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id758' in table 'tReportDetectionNoAdmissKWT' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class193_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id759
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class193_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id759' in table 'tReportDetectionNoAdmissKWT' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class193_0.DataColumn_4] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class193_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class193_0.DataColumn_0] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_2()
		{
			return base.IsNull(this.class193_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class193_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class193_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class193_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class193_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class193_0.DataColumn_3] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class193_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_9()
		{
			base[this.class193_0.DataColumn_4] = Convert.DBNull;
		}

		private Class171.Class193 class193_0;
	}

	public class Class219 : DataRow
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal Class219(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class194_0 = (Class171.tSettingsDataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int id
		{
			get
			{
				return (int)base[this.class194_0.idColumn];
			}
			set
			{
				base[this.class194_0.idColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string HostIp
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class194_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HostIp' in table 'tSettings' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class194_0.DataColumn_0] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Settings
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class194_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Settings' in table 'tSettings' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class194_0.DataColumn_1] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Module
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class194_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Module' in table 'tSettings' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class194_0.DataColumn_2] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class194_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class194_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class194_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class194_0.DataColumn_1] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_4()
		{
			return base.IsNull(this.class194_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_5()
		{
			base[this.class194_0.DataColumn_2] = Convert.DBNull;
		}

		private Class171.tSettingsDataTable class194_0;
	}

	public class Class220 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class220(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class195_0 = (Class171.Class195)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int IdDamage
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'IdDamage' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SRName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class195_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SRName' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public double netRegionValue
		{
			get
			{
				double result;
				try
				{
					result = (double)base[this.class195_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'netRegionValue' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string schmObjName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class195_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'schmObjName' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_3] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string subName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class195_0.subNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'subName' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.subNameColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TypeSchmObj
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class195_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TypeSchmObj' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal PowerV
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class195_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PowerV' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_5] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string Reason
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class195_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Reason' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool APV
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class195_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'APV' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool AVR
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class195_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'AVR' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_8] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int countPointCat1Full
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countPointCat1Full' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_9] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int countPointCat1
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countPointCat1' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_10] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int countPointCat2Full
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countPointCat2Full' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_11] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int countPointCat2
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_12];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countPointCat2' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_12] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int countPointCat3
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countPointCat3' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_13] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int countPointEE
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_14];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countPointEE' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_14] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int countPointSource
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_15];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countPointSource' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_15] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int countAbnObjCat1Full
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_16];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countAbnObjCat1Full' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_16] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int countAbnObjCat1
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_17];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countAbnObjCat1' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_17] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int countAbnObjCat2Full
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_18];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countAbnObjCat2Full' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_18] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int countAbnObjCat2
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_19];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countAbnObjCat2' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_19] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int countAbnObjCat3
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_20];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countAbnObjCat3' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_20] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int countAbnObjEE
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_21];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countAbnObjEE' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_21] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int countAbnObjSource
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_22];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countAbnObjSource' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_22] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int countAbnObj150
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_23];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countAbnObj150' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_23] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int countAbnObj150670
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_24];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countAbnObj150670' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_24] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int countAbnObj670
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class195_0.DataColumn_25];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'countAbnObj670' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_25] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateBegin
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class195_0.DataColumn_26];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateBegin' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_26] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateApply
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class195_0.DataColumn_27];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateApply' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_27] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateApplyMax
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class195_0.DataColumn_28];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateApplyMax' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_28] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string TypeDoc
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class195_0.DataColumn_29];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TypeDoc' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_29] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string numDateDoc
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class195_0.DataColumn_30];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numDateDoc' in table 'Report81' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class195_0.DataColumn_30] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_0()
		{
			return base.IsNull(this.class195_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_1()
		{
			base[this.class195_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_2()
		{
			return base.IsNull(this.class195_0.DataColumn_1);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_3()
		{
			base[this.class195_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class195_0.DataColumn_2);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5()
		{
			base[this.class195_0.DataColumn_2] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_6()
		{
			return base.IsNull(this.class195_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_7()
		{
			base[this.class195_0.DataColumn_3] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_8()
		{
			return base.IsNull(this.class195_0.subNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_9()
		{
			base[this.class195_0.subNameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_10()
		{
			return base.IsNull(this.class195_0.DataColumn_4);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_11()
		{
			base[this.class195_0.DataColumn_4] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_12()
		{
			return base.IsNull(this.class195_0.DataColumn_5);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_13()
		{
			base[this.class195_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_14()
		{
			return base.IsNull(this.class195_0.DataColumn_6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class195_0.DataColumn_6] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_16()
		{
			return base.IsNull(this.class195_0.DataColumn_7);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_17()
		{
			base[this.class195_0.DataColumn_7] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_18()
		{
			return base.IsNull(this.class195_0.DataColumn_8);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_19()
		{
			base[this.class195_0.DataColumn_8] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_20()
		{
			return base.IsNull(this.class195_0.DataColumn_9);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_21()
		{
			base[this.class195_0.DataColumn_9] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_22()
		{
			return base.IsNull(this.class195_0.DataColumn_10);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_23()
		{
			base[this.class195_0.DataColumn_10] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_24()
		{
			return base.IsNull(this.class195_0.DataColumn_11);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_25()
		{
			base[this.class195_0.DataColumn_11] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_26()
		{
			return base.IsNull(this.class195_0.DataColumn_12);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_27()
		{
			base[this.class195_0.DataColumn_12] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_28()
		{
			return base.IsNull(this.class195_0.DataColumn_13);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_29()
		{
			base[this.class195_0.DataColumn_13] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_30()
		{
			return base.IsNull(this.class195_0.DataColumn_14);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_31()
		{
			base[this.class195_0.DataColumn_14] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_32()
		{
			return base.IsNull(this.class195_0.DataColumn_15);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_33()
		{
			base[this.class195_0.DataColumn_15] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_34()
		{
			return base.IsNull(this.class195_0.DataColumn_16);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_35()
		{
			base[this.class195_0.DataColumn_16] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_36()
		{
			return base.IsNull(this.class195_0.DataColumn_17);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_37()
		{
			base[this.class195_0.DataColumn_17] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_38()
		{
			return base.IsNull(this.class195_0.DataColumn_18);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_39()
		{
			base[this.class195_0.DataColumn_18] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_40()
		{
			return base.IsNull(this.class195_0.DataColumn_19);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_41()
		{
			base[this.class195_0.DataColumn_19] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_42()
		{
			return base.IsNull(this.class195_0.DataColumn_20);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_43()
		{
			base[this.class195_0.DataColumn_20] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_44()
		{
			return base.IsNull(this.class195_0.DataColumn_21);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_45()
		{
			base[this.class195_0.DataColumn_21] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_46()
		{
			return base.IsNull(this.class195_0.DataColumn_22);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_47()
		{
			base[this.class195_0.DataColumn_22] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_48()
		{
			return base.IsNull(this.class195_0.DataColumn_23);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_49()
		{
			base[this.class195_0.DataColumn_23] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_50()
		{
			return base.IsNull(this.class195_0.DataColumn_24);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_51()
		{
			base[this.class195_0.DataColumn_24] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_52()
		{
			return base.IsNull(this.class195_0.DataColumn_25);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_53()
		{
			base[this.class195_0.DataColumn_25] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_54()
		{
			return base.IsNull(this.class195_0.DataColumn_26);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_55()
		{
			base[this.class195_0.DataColumn_26] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_56()
		{
			return base.IsNull(this.class195_0.DataColumn_27);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_57()
		{
			base[this.class195_0.DataColumn_27] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_58()
		{
			return base.IsNull(this.class195_0.DataColumn_28);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_59()
		{
			base[this.class195_0.DataColumn_28] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_60()
		{
			return base.IsNull(this.class195_0.DataColumn_29);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_61()
		{
			base[this.class195_0.DataColumn_29] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_62()
		{
			return base.IsNull(this.class195_0.DataColumn_30);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_63()
		{
			base[this.class195_0.DataColumn_30] = Convert.DBNull;
		}

		private Class171.Class195 class195_0;
	}

	public class Class221 : DataRow
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal Class221(DataRowBuilder dataRowBuilder_0)
		{
			//
			base..ctor(dataRowBuilder_0);
			this.class196_0 = (Class171.ReportAccidentsDataTable)base.Table;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idDamage
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class196_0.idDamageColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idDamage' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.idDamageColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string numCrash
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class196_0.DataColumn_0];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numCrash' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_0] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int numCrashMonth
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class196_0.DataColumn_1];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'numCrashMonth' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_1] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool isCrash
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class196_0.DataColumn_2];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isCrash' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_2] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateDoc
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class196_0.DataColumn_3];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateDoc' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_3] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime dateEnd
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class196_0.DataColumn_4];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateEnd' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_4] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string timeCrash
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class196_0.DataColumn_5];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'timeCrash' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_5] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool isApply
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base[this.class196_0.DataColumn_6];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'isApply' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_6] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal netRegionValue
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class196_0.DataColumn_7];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'netRegionValue' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_7] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string subName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class196_0.subNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'subName' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.subNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string cellName
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class196_0.cellNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'cellName' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.cellNameColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string typeRZA
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class196_0.DataColumn_8];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typeRZA' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_8] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public string TypeSchmObj
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class196_0.DataColumn_9];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TypeSchmObj' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_9] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int idSchmObj
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class196_0.idSchmObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idSchmObj' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.idSchmObjColumn] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string SubScribe
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class196_0.DataColumn_10];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SubScribe' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_10] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string defectLocation
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class196_0.DataColumn_11];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'defectLocation' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_11] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Character
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class196_0.DataColumn_12];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Character' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_12] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string abnNAme
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class196_0.DataColumn_13];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'abnNAme' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_13] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public decimal NoAdmissionKWT
		{
			get
			{
				decimal result;
				try
				{
					result = (decimal)base[this.class196_0.DataColumn_14];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoAdmissionKWT' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_14] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string Mark
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class196_0.DataColumn_15];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Mark' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_15] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public int passIn
		{
			get
			{
				int result;
				try
				{
					result = (int)base[this.class196_0.DataColumn_16];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'passIn' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_16] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public string LineLenght
		{
			get
			{
				string result;
				try
				{
					result = (string)base[this.class196_0.DataColumn_17];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'LineLenght' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_17] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime DateTime_0
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class196_0.DataColumn_18];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DAteTesting' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_18] = value;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DateTime timeRecovery
		{
			get
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.class196_0.DataColumn_19];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'timeRecovery' in table 'ReportAccidents' is DBNull.", innerException);
				}
				return result;
			}
			set
			{
				base[this.class196_0.DataColumn_19] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_0()
		{
			return base.IsNull(this.class196_0.idDamageColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_1()
		{
			base[this.class196_0.idDamageColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_2()
		{
			return base.IsNull(this.class196_0.DataColumn_0);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_3()
		{
			base[this.class196_0.DataColumn_0] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_4()
		{
			return base.IsNull(this.class196_0.DataColumn_1);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_5()
		{
			base[this.class196_0.DataColumn_1] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_6()
		{
			return base.IsNull(this.class196_0.DataColumn_2);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_7()
		{
			base[this.class196_0.DataColumn_2] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_8()
		{
			return base.IsNull(this.class196_0.DataColumn_3);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_9()
		{
			base[this.class196_0.DataColumn_3] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_10()
		{
			return base.IsNull(this.class196_0.DataColumn_4);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_11()
		{
			base[this.class196_0.DataColumn_4] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_12()
		{
			return base.IsNull(this.class196_0.DataColumn_5);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_13()
		{
			base[this.class196_0.DataColumn_5] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_14()
		{
			return base.IsNull(this.class196_0.DataColumn_6);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_15()
		{
			base[this.class196_0.DataColumn_6] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_16()
		{
			return base.IsNull(this.class196_0.DataColumn_7);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_17()
		{
			base[this.class196_0.DataColumn_7] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_18()
		{
			return base.IsNull(this.class196_0.subNameColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_19()
		{
			base[this.class196_0.subNameColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_20()
		{
			return base.IsNull(this.class196_0.cellNameColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_21()
		{
			base[this.class196_0.cellNameColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_22()
		{
			return base.IsNull(this.class196_0.DataColumn_8);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_23()
		{
			base[this.class196_0.DataColumn_8] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_24()
		{
			return base.IsNull(this.class196_0.DataColumn_9);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_25()
		{
			base[this.class196_0.DataColumn_9] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_26()
		{
			return base.IsNull(this.class196_0.idSchmObjColumn);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_27()
		{
			base[this.class196_0.idSchmObjColumn] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_28()
		{
			return base.IsNull(this.class196_0.DataColumn_10);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_29()
		{
			base[this.class196_0.DataColumn_10] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_30()
		{
			return base.IsNull(this.class196_0.DataColumn_11);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_31()
		{
			base[this.class196_0.DataColumn_11] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_32()
		{
			return base.IsNull(this.class196_0.DataColumn_12);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_33()
		{
			base[this.class196_0.DataColumn_12] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_34()
		{
			return base.IsNull(this.class196_0.DataColumn_13);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_35()
		{
			base[this.class196_0.DataColumn_13] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_36()
		{
			return base.IsNull(this.class196_0.DataColumn_14);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_37()
		{
			base[this.class196_0.DataColumn_14] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_38()
		{
			return base.IsNull(this.class196_0.DataColumn_15);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public void method_39()
		{
			base[this.class196_0.DataColumn_15] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_40()
		{
			return base.IsNull(this.class196_0.DataColumn_16);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_41()
		{
			base[this.class196_0.DataColumn_16] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_42()
		{
			return base.IsNull(this.class196_0.DataColumn_17);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_43()
		{
			base[this.class196_0.DataColumn_17] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool method_44()
		{
			return base.IsNull(this.class196_0.DataColumn_18);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_45()
		{
			base[this.class196_0.DataColumn_18] = Convert.DBNull;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public bool method_46()
		{
			return base.IsNull(this.class196_0.DataColumn_19);
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public void method_47()
		{
			base[this.class196_0.DataColumn_19] = Convert.DBNull;
		}

		private Class171.ReportAccidentsDataTable class196_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs71 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs71(Class171.Class197 class197_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class197_0 = class197_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class197 Row
		{
			get
			{
				return this.class197_0;
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

		private Class171.Class197 class197_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs72 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs72(Class171.Class198 class198_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class198_0 = class198_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class198 Row
		{
			get
			{
				return this.class198_0;
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

		private Class171.Class198 class198_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs73 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs73(Class171.Class199 class199_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class199_0 = class199_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class199 Row
		{
			get
			{
				return this.class199_0;
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

		private Class171.Class199 class199_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs74 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs74(Class171.Class200 class200_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class200_0 = class200_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class200 Row
		{
			get
			{
				return this.class200_0;
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

		private Class171.Class200 class200_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs75 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs75(Class171.Class201 class201_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class201_0 = class201_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class201 Row
		{
			get
			{
				return this.class201_0;
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

		private Class171.Class201 class201_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs76 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs76(Class171.Class202 class202_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class202_0 = class202_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class202 Row
		{
			get
			{
				return this.class202_0;
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

		private Class171.Class202 class202_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs77 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs77(Class171.Class203 class203_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class203_0 = class203_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class203 Row
		{
			get
			{
				return this.class203_0;
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

		private Class171.Class203 class203_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs78 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs78(Class171.Class204 class204_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class204_0 = class204_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class204 Row
		{
			get
			{
				return this.class204_0;
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

		private Class171.Class204 class204_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs79 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs79(Class171.Class205 class205_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class205_0 = class205_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class205 Row
		{
			get
			{
				return this.class205_0;
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

		private Class171.Class205 class205_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs80 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs80(Class171.Class206 class206_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class206_0 = class206_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class206 Row
		{
			get
			{
				return this.class206_0;
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

		private Class171.Class206 class206_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs81 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs81(Class171.Class207 class207_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class207_0 = class207_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class207 Row
		{
			get
			{
				return this.class207_0;
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

		private Class171.Class207 class207_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs82 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs82(Class171.Class208 class208_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class208_0 = class208_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class208 Row
		{
			get
			{
				return this.class208_0;
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

		private Class171.Class208 class208_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs83 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs83(Class171.Class209 class209_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class209_0 = class209_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class209 Row
		{
			get
			{
				return this.class209_0;
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

		private Class171.Class209 class209_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs84 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs84(Class171.Class210 class210_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class210_0 = class210_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class210 Row
		{
			get
			{
				return this.class210_0;
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

		private Class171.Class210 class210_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs85 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs85(Class171.Class211 class211_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class211_0 = class211_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class211 Row
		{
			get
			{
				return this.class211_0;
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

		private Class171.Class211 class211_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs86 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs86(Class171.Class212 class212_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class212_0 = class212_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class212 Row
		{
			get
			{
				return this.class212_0;
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

		private Class171.Class212 class212_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs87 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs87(Class171.Class213 class213_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class213_0 = class213_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class213 Row
		{
			get
			{
				return this.class213_0;
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

		private Class171.Class213 class213_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs88 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs88(Class171.Class214 class214_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class214_0 = class214_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class214 Row
		{
			get
			{
				return this.class214_0;
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

		private Class171.Class214 class214_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs89 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs89(Class171.Class215 class215_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class215_0 = class215_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class215 Row
		{
			get
			{
				return this.class215_0;
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

		private Class171.Class215 class215_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs90 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs90(Class171.Class216 class216_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class216_0 = class216_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class216 Row
		{
			get
			{
				return this.class216_0;
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

		private Class171.Class216 class216_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs91 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs91(Class171.Class217 class217_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class217_0 = class217_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class217 Row
		{
			get
			{
				return this.class217_0;
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

		private Class171.Class217 class217_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs92 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs92(Class171.Class218 class218_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class218_0 = class218_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class218 Row
		{
			get
			{
				return this.class218_0;
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

		private Class171.Class218 class218_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs93 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs93(Class171.Class219 class219_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class219_0 = class219_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Class171.Class219 Row
		{
			get
			{
				return this.class219_0;
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

		private Class171.Class219 class219_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs94 : EventArgs
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public EventArgs94(Class171.Class220 class220_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class220_0 = class220_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class220 Row
		{
			get
			{
				return this.class220_0;
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

		private Class171.Class220 class220_0;

		private DataRowAction dataRowAction_0;
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
	public class EventArgs95 : EventArgs
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public EventArgs95(Class171.Class221 class221_1, DataRowAction dataRowAction_1)
		{
			//
			
			this.class221_0 = class221_1;
			this.dataRowAction_0 = dataRowAction_1;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public Class171.Class221 Row
		{
			get
			{
				return this.class221_0;
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

		private Class171.Class221 class221_0;

		private DataRowAction dataRowAction_0;
	}
}
