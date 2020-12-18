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

namespace Passport.Forms.AirLine.Report
{
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.DataSet")]
	[XmlRoot("DataSetReportAirLinePassport")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[ToolboxItem(true)]
	[Serializable]
	public class DataSetReportAirLinePassport : DataSet
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSetReportAirLinePassport()
		{
			Class330.Mus9JxKz1CNxy();
			this.schemaSerializationMode_0 = SchemaSerializationMode.IncludeSchema;
			base..ctor();
			base.BeginInit();
			this.method_2();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_25);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected DataSetReportAirLinePassport(SerializationInfo info, StreamingContext context)
		{
			Class330.Mus9JxKz1CNxy();
			this.schemaSerializationMode_0 = SchemaSerializationMode.IncludeSchema;
			base..ctor(info, context, false);
			if (base.IsBinarySerialized(info, context))
			{
				this.method_1(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_25);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
				return;
			}
			string s = (string)info.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["dtAirLineEquipment"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtAirLineEquipmentDataTable(dataSet.Tables["dtAirLineEquipment"]));
				}
				if (dataSet.Tables["tp_AirLineReport"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.tp_AirLineReportDataTable(dataSet.Tables["tp_AirLineReport"]));
				}
				if (dataSet.Tables["dtCrossing"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtCrossingDataTable(dataSet.Tables["dtCrossing"]));
				}
				if (dataSet.Tables["dtTerrain"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtTerrainDataTable(dataSet.Tables["dtTerrain"]));
				}
				if (dataSet.Tables["dsCountPole"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dsCountPoleDataTable(dataSet.Tables["dsCountPole"]));
				}
				if (dataSet.Tables["dtBranch"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtBranchDataTable(dataSet.Tables["dtBranch"]));
				}
				if (dataSet.Tables["dtCableInsertion"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtCableInsertionDataTable(dataSet.Tables["dtCableInsertion"]));
				}
				if (dataSet.Tables["dtPylonEquipment"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtPylonEquipmentDataTable(dataSet.Tables["dtPylonEquipment"]));
				}
				if (dataSet.Tables["dtJointSuspension"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtJointSuspensionDataTable(dataSet.Tables["dtJointSuspension"]));
				}
				if (dataSet.Tables["tBranch"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.tBranchDataTable(dataSet.Tables["tBranch"]));
				}
				if (dataSet.Tables["dtPylons"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtPylonsDataTable(dataSet.Tables["dtPylons"]));
				}
				if (dataSet.Tables["dtRoad"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtRoadDataTable(dataSet.Tables["dtRoad"]));
				}
				if (dataSet.Tables["vDocAirLineRepair"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.vDocAirLineRepairDataTable(dataSet.Tables["vDocAirLineRepair"]));
				}
				if (dataSet.Tables["vDocPylonEquipRepair"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.vDocPylonEquipRepairDataTable(dataSet.Tables["vDocPylonEquipRepair"]));
				}
				if (dataSet.Tables["tSettings"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.tSettingsDataTable(dataSet.Tables["tSettings"]));
				}
				if (dataSet.Tables["dtReportAirLineRepairMain"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtReportAirLineRepairMainDataTable(dataSet.Tables["dtReportAirLineRepairMain"]));
				}
				if (dataSet.Tables["dtReportAirLineRepairWork"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtReportAirLineRepairWorkDataTable(dataSet.Tables["dtReportAirLineRepairWork"]));
				}
				if (dataSet.Tables["dtReportAirLineRepairAddress"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtReportAirLineRepairAddressDataTable(dataSet.Tables["dtReportAirLineRepairAddress"]));
				}
				if (dataSet.Tables["dtInspectAirLineDefect"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtInspectAirLineDefectDataTable(dataSet.Tables["dtInspectAirLineDefect"]));
				}
				if (dataSet.Tables["dtInspectAirLineWorker"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtInspectAirLineWorkerDataTable(dataSet.Tables["dtInspectAirLineWorker"]));
				}
				if (dataSet.Tables["dtInspectAirLineOther"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtInspectAirLineOtherDataTable(dataSet.Tables["dtInspectAirLineOther"]));
				}
				if (dataSet.Tables["dtPylonEquipExplMian"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtPylonEquipExplMianDataTable(dataSet.Tables["dtPylonEquipExplMian"]));
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
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.method_25);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetReportAirLinePassport.dtAirLineEquipmentDataTable dtAirLineEquipment
		{
			get
			{
				return this.dtAirLineEquipmentDataTable_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public DataSetReportAirLinePassport.tp_AirLineReportDataTable tp_AirLineReport
		{
			get
			{
				return this.tp_AirLineReportDataTable_0;
			}
		}

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetReportAirLinePassport.dtCrossingDataTable dtCrossing
		{
			get
			{
				return this.dtCrossingDataTable_0;
			}
		}

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetReportAirLinePassport.dtTerrainDataTable dtTerrain
		{
			get
			{
				return this.dtTerrainDataTable_0;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSetReportAirLinePassport.dsCountPoleDataTable dsCountPole
		{
			get
			{
				return this.dsCountPoleDataTable_0;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSetReportAirLinePassport.dtBranchDataTable dtBranch
		{
			get
			{
				return this.dtBranchDataTable_0;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport.dtCableInsertionDataTable dtCableInsertion
		{
			get
			{
				return this.dtCableInsertionDataTable_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public DataSetReportAirLinePassport.dtPylonEquipmentDataTable dtPylonEquipment
		{
			get
			{
				return this.dtPylonEquipmentDataTable_0;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public DataSetReportAirLinePassport.dtJointSuspensionDataTable dtJointSuspension
		{
			get
			{
				return this.dtJointSuspensionDataTable_0;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public DataSetReportAirLinePassport.tBranchDataTable tBranch
		{
			get
			{
				return this.tBranchDataTable_0;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport.dtPylonsDataTable dtPylons
		{
			get
			{
				return this.dtPylonsDataTable_0;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public DataSetReportAirLinePassport.dtRoadDataTable dtRoad
		{
			get
			{
				return this.qBimcXoHjrW;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport.vDocAirLineRepairDataTable vDocAirLineRepair
		{
			get
			{
				return this.vDocAirLineRepairDataTable_0;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		public DataSetReportAirLinePassport.vDocPylonEquipRepairDataTable vDocPylonEquipRepair
		{
			get
			{
				return this.vDocPylonEquipRepairDataTable_0;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSetReportAirLinePassport.tSettingsDataTable tSettings
		{
			get
			{
				return this.tSettingsDataTable_0;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport.dtReportAirLineRepairMainDataTable dtReportAirLineRepairMain
		{
			get
			{
				return this.dtReportAirLineRepairMainDataTable_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public DataSetReportAirLinePassport.dtReportAirLineRepairWorkDataTable dtReportAirLineRepairWork
		{
			get
			{
				return this.dtReportAirLineRepairWorkDataTable_0;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSetReportAirLinePassport.dtReportAirLineRepairAddressDataTable dtReportAirLineRepairAddress
		{
			get
			{
				return this.dtReportAirLineRepairAddressDataTable_0;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public DataSetReportAirLinePassport.dtInspectAirLineDefectDataTable dtInspectAirLineDefect
		{
			get
			{
				return this.dtInspectAirLineDefectDataTable_0;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport.dtInspectAirLineWorkerDataTable dtInspectAirLineWorker
		{
			get
			{
				return this.dtInspectAirLineWorkerDataTable_0;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetReportAirLinePassport.dtInspectAirLineOtherDataTable dtInspectAirLineOther
		{
			get
			{
				return this.dtInspectAirLineOtherDataTable_0;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		public DataSetReportAirLinePassport.dtPylonEquipExplMianDataTable dtPylonEquipExplMian
		{
			get
			{
				return this.dtPylonEquipExplMianDataTable_0;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[Browsable(true)]
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
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
			DataSetReportAirLinePassport dataSetReportAirLinePassport = (DataSetReportAirLinePassport)base.Clone();
			dataSetReportAirLinePassport.method_0();
			dataSetReportAirLinePassport.SchemaSerializationMode = this.SchemaSerializationMode;
			return dataSetReportAirLinePassport;
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
				if (dataSet.Tables["dtAirLineEquipment"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtAirLineEquipmentDataTable(dataSet.Tables["dtAirLineEquipment"]));
				}
				if (dataSet.Tables["tp_AirLineReport"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.tp_AirLineReportDataTable(dataSet.Tables["tp_AirLineReport"]));
				}
				if (dataSet.Tables["dtCrossing"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtCrossingDataTable(dataSet.Tables["dtCrossing"]));
				}
				if (dataSet.Tables["dtTerrain"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtTerrainDataTable(dataSet.Tables["dtTerrain"]));
				}
				if (dataSet.Tables["dsCountPole"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dsCountPoleDataTable(dataSet.Tables["dsCountPole"]));
				}
				if (dataSet.Tables["dtBranch"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtBranchDataTable(dataSet.Tables["dtBranch"]));
				}
				if (dataSet.Tables["dtCableInsertion"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtCableInsertionDataTable(dataSet.Tables["dtCableInsertion"]));
				}
				if (dataSet.Tables["dtPylonEquipment"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtPylonEquipmentDataTable(dataSet.Tables["dtPylonEquipment"]));
				}
				if (dataSet.Tables["dtJointSuspension"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtJointSuspensionDataTable(dataSet.Tables["dtJointSuspension"]));
				}
				if (dataSet.Tables["tBranch"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.tBranchDataTable(dataSet.Tables["tBranch"]));
				}
				if (dataSet.Tables["dtPylons"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtPylonsDataTable(dataSet.Tables["dtPylons"]));
				}
				if (dataSet.Tables["dtRoad"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtRoadDataTable(dataSet.Tables["dtRoad"]));
				}
				if (dataSet.Tables["vDocAirLineRepair"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.vDocAirLineRepairDataTable(dataSet.Tables["vDocAirLineRepair"]));
				}
				if (dataSet.Tables["vDocPylonEquipRepair"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.vDocPylonEquipRepairDataTable(dataSet.Tables["vDocPylonEquipRepair"]));
				}
				if (dataSet.Tables["tSettings"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.tSettingsDataTable(dataSet.Tables["tSettings"]));
				}
				if (dataSet.Tables["dtReportAirLineRepairMain"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtReportAirLineRepairMainDataTable(dataSet.Tables["dtReportAirLineRepairMain"]));
				}
				if (dataSet.Tables["dtReportAirLineRepairWork"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtReportAirLineRepairWorkDataTable(dataSet.Tables["dtReportAirLineRepairWork"]));
				}
				if (dataSet.Tables["dtReportAirLineRepairAddress"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtReportAirLineRepairAddressDataTable(dataSet.Tables["dtReportAirLineRepairAddress"]));
				}
				if (dataSet.Tables["dtInspectAirLineDefect"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtInspectAirLineDefectDataTable(dataSet.Tables["dtInspectAirLineDefect"]));
				}
				if (dataSet.Tables["dtInspectAirLineWorker"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtInspectAirLineWorkerDataTable(dataSet.Tables["dtInspectAirLineWorker"]));
				}
				if (dataSet.Tables["dtInspectAirLineOther"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtInspectAirLineOtherDataTable(dataSet.Tables["dtInspectAirLineOther"]));
				}
				if (dataSet.Tables["dtPylonEquipExplMian"] != null)
				{
					base.Tables.Add(new DataSetReportAirLinePassport.dtPylonEquipExplMianDataTable(dataSet.Tables["dtPylonEquipExplMian"]));
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
			this.dtAirLineEquipmentDataTable_0 = (DataSetReportAirLinePassport.dtAirLineEquipmentDataTable)base.Tables["dtAirLineEquipment"];
			if (bool_0 && this.dtAirLineEquipmentDataTable_0 != null)
			{
				this.dtAirLineEquipmentDataTable_0.method_0();
			}
			this.tp_AirLineReportDataTable_0 = (DataSetReportAirLinePassport.tp_AirLineReportDataTable)base.Tables["tp_AirLineReport"];
			if (bool_0 && this.tp_AirLineReportDataTable_0 != null)
			{
				this.tp_AirLineReportDataTable_0.method_0();
			}
			this.dtCrossingDataTable_0 = (DataSetReportAirLinePassport.dtCrossingDataTable)base.Tables["dtCrossing"];
			if (bool_0 && this.dtCrossingDataTable_0 != null)
			{
				this.dtCrossingDataTable_0.method_0();
			}
			this.dtTerrainDataTable_0 = (DataSetReportAirLinePassport.dtTerrainDataTable)base.Tables["dtTerrain"];
			if (bool_0 && this.dtTerrainDataTable_0 != null)
			{
				this.dtTerrainDataTable_0.method_0();
			}
			this.dsCountPoleDataTable_0 = (DataSetReportAirLinePassport.dsCountPoleDataTable)base.Tables["dsCountPole"];
			if (bool_0 && this.dsCountPoleDataTable_0 != null)
			{
				this.dsCountPoleDataTable_0.method_0();
			}
			this.dtBranchDataTable_0 = (DataSetReportAirLinePassport.dtBranchDataTable)base.Tables["dtBranch"];
			if (bool_0 && this.dtBranchDataTable_0 != null)
			{
				this.dtBranchDataTable_0.DhBaTtWiXdp();
			}
			this.dtCableInsertionDataTable_0 = (DataSetReportAirLinePassport.dtCableInsertionDataTable)base.Tables["dtCableInsertion"];
			if (bool_0 && this.dtCableInsertionDataTable_0 != null)
			{
				this.dtCableInsertionDataTable_0.method_0();
			}
			this.dtPylonEquipmentDataTable_0 = (DataSetReportAirLinePassport.dtPylonEquipmentDataTable)base.Tables["dtPylonEquipment"];
			if (bool_0 && this.dtPylonEquipmentDataTable_0 != null)
			{
				this.dtPylonEquipmentDataTable_0.method_0();
			}
			this.dtJointSuspensionDataTable_0 = (DataSetReportAirLinePassport.dtJointSuspensionDataTable)base.Tables["dtJointSuspension"];
			if (bool_0 && this.dtJointSuspensionDataTable_0 != null)
			{
				this.dtJointSuspensionDataTable_0.method_0();
			}
			this.tBranchDataTable_0 = (DataSetReportAirLinePassport.tBranchDataTable)base.Tables["tBranch"];
			if (bool_0 && this.tBranchDataTable_0 != null)
			{
				this.tBranchDataTable_0.method_0();
			}
			this.dtPylonsDataTable_0 = (DataSetReportAirLinePassport.dtPylonsDataTable)base.Tables["dtPylons"];
			if (bool_0 && this.dtPylonsDataTable_0 != null)
			{
				this.dtPylonsDataTable_0.method_0();
			}
			this.qBimcXoHjrW = (DataSetReportAirLinePassport.dtRoadDataTable)base.Tables["dtRoad"];
			if (bool_0 && this.qBimcXoHjrW != null)
			{
				this.qBimcXoHjrW.method_0();
			}
			this.vDocAirLineRepairDataTable_0 = (DataSetReportAirLinePassport.vDocAirLineRepairDataTable)base.Tables["vDocAirLineRepair"];
			if (bool_0 && this.vDocAirLineRepairDataTable_0 != null)
			{
				this.vDocAirLineRepairDataTable_0.method_0();
			}
			this.vDocPylonEquipRepairDataTable_0 = (DataSetReportAirLinePassport.vDocPylonEquipRepairDataTable)base.Tables["vDocPylonEquipRepair"];
			if (bool_0 && this.vDocPylonEquipRepairDataTable_0 != null)
			{
				this.vDocPylonEquipRepairDataTable_0.method_0();
			}
			this.tSettingsDataTable_0 = (DataSetReportAirLinePassport.tSettingsDataTable)base.Tables["tSettings"];
			if (bool_0 && this.tSettingsDataTable_0 != null)
			{
				this.tSettingsDataTable_0.method_0();
			}
			this.dtReportAirLineRepairMainDataTable_0 = (DataSetReportAirLinePassport.dtReportAirLineRepairMainDataTable)base.Tables["dtReportAirLineRepairMain"];
			if (bool_0 && this.dtReportAirLineRepairMainDataTable_0 != null)
			{
				this.dtReportAirLineRepairMainDataTable_0.method_0();
			}
			this.dtReportAirLineRepairWorkDataTable_0 = (DataSetReportAirLinePassport.dtReportAirLineRepairWorkDataTable)base.Tables["dtReportAirLineRepairWork"];
			if (bool_0 && this.dtReportAirLineRepairWorkDataTable_0 != null)
			{
				this.dtReportAirLineRepairWorkDataTable_0.method_0();
			}
			this.dtReportAirLineRepairAddressDataTable_0 = (DataSetReportAirLinePassport.dtReportAirLineRepairAddressDataTable)base.Tables["dtReportAirLineRepairAddress"];
			if (bool_0 && this.dtReportAirLineRepairAddressDataTable_0 != null)
			{
				this.dtReportAirLineRepairAddressDataTable_0.method_0();
			}
			this.dtInspectAirLineDefectDataTable_0 = (DataSetReportAirLinePassport.dtInspectAirLineDefectDataTable)base.Tables["dtInspectAirLineDefect"];
			if (bool_0 && this.dtInspectAirLineDefectDataTable_0 != null)
			{
				this.dtInspectAirLineDefectDataTable_0.method_0();
			}
			this.dtInspectAirLineWorkerDataTable_0 = (DataSetReportAirLinePassport.dtInspectAirLineWorkerDataTable)base.Tables["dtInspectAirLineWorker"];
			if (bool_0 && this.dtInspectAirLineWorkerDataTable_0 != null)
			{
				this.dtInspectAirLineWorkerDataTable_0.method_0();
			}
			this.dtInspectAirLineOtherDataTable_0 = (DataSetReportAirLinePassport.dtInspectAirLineOtherDataTable)base.Tables["dtInspectAirLineOther"];
			if (bool_0 && this.dtInspectAirLineOtherDataTable_0 != null)
			{
				this.dtInspectAirLineOtherDataTable_0.method_0();
			}
			this.dtPylonEquipExplMianDataTable_0 = (DataSetReportAirLinePassport.dtPylonEquipExplMianDataTable)base.Tables["dtPylonEquipExplMian"];
			if (bool_0 && this.dtPylonEquipExplMianDataTable_0 != null)
			{
				this.dtPylonEquipExplMianDataTable_0.method_0();
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void method_2()
		{
			base.DataSetName = "DataSetReportAirLinePassport";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/DataSetReportAirLinePassport.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.dtAirLineEquipmentDataTable_0 = new DataSetReportAirLinePassport.dtAirLineEquipmentDataTable();
			base.Tables.Add(this.dtAirLineEquipmentDataTable_0);
			this.tp_AirLineReportDataTable_0 = new DataSetReportAirLinePassport.tp_AirLineReportDataTable();
			base.Tables.Add(this.tp_AirLineReportDataTable_0);
			this.dtCrossingDataTable_0 = new DataSetReportAirLinePassport.dtCrossingDataTable();
			base.Tables.Add(this.dtCrossingDataTable_0);
			this.dtTerrainDataTable_0 = new DataSetReportAirLinePassport.dtTerrainDataTable();
			base.Tables.Add(this.dtTerrainDataTable_0);
			this.dsCountPoleDataTable_0 = new DataSetReportAirLinePassport.dsCountPoleDataTable();
			base.Tables.Add(this.dsCountPoleDataTable_0);
			this.dtBranchDataTable_0 = new DataSetReportAirLinePassport.dtBranchDataTable();
			base.Tables.Add(this.dtBranchDataTable_0);
			this.dtCableInsertionDataTable_0 = new DataSetReportAirLinePassport.dtCableInsertionDataTable();
			base.Tables.Add(this.dtCableInsertionDataTable_0);
			this.dtPylonEquipmentDataTable_0 = new DataSetReportAirLinePassport.dtPylonEquipmentDataTable();
			base.Tables.Add(this.dtPylonEquipmentDataTable_0);
			this.dtJointSuspensionDataTable_0 = new DataSetReportAirLinePassport.dtJointSuspensionDataTable();
			base.Tables.Add(this.dtJointSuspensionDataTable_0);
			this.tBranchDataTable_0 = new DataSetReportAirLinePassport.tBranchDataTable();
			base.Tables.Add(this.tBranchDataTable_0);
			this.dtPylonsDataTable_0 = new DataSetReportAirLinePassport.dtPylonsDataTable();
			base.Tables.Add(this.dtPylonsDataTable_0);
			this.qBimcXoHjrW = new DataSetReportAirLinePassport.dtRoadDataTable();
			base.Tables.Add(this.qBimcXoHjrW);
			this.vDocAirLineRepairDataTable_0 = new DataSetReportAirLinePassport.vDocAirLineRepairDataTable();
			base.Tables.Add(this.vDocAirLineRepairDataTable_0);
			this.vDocPylonEquipRepairDataTable_0 = new DataSetReportAirLinePassport.vDocPylonEquipRepairDataTable();
			base.Tables.Add(this.vDocPylonEquipRepairDataTable_0);
			this.tSettingsDataTable_0 = new DataSetReportAirLinePassport.tSettingsDataTable();
			base.Tables.Add(this.tSettingsDataTable_0);
			this.dtReportAirLineRepairMainDataTable_0 = new DataSetReportAirLinePassport.dtReportAirLineRepairMainDataTable();
			base.Tables.Add(this.dtReportAirLineRepairMainDataTable_0);
			this.dtReportAirLineRepairWorkDataTable_0 = new DataSetReportAirLinePassport.dtReportAirLineRepairWorkDataTable();
			base.Tables.Add(this.dtReportAirLineRepairWorkDataTable_0);
			this.dtReportAirLineRepairAddressDataTable_0 = new DataSetReportAirLinePassport.dtReportAirLineRepairAddressDataTable();
			base.Tables.Add(this.dtReportAirLineRepairAddressDataTable_0);
			this.dtInspectAirLineDefectDataTable_0 = new DataSetReportAirLinePassport.dtInspectAirLineDefectDataTable();
			base.Tables.Add(this.dtInspectAirLineDefectDataTable_0);
			this.dtInspectAirLineWorkerDataTable_0 = new DataSetReportAirLinePassport.dtInspectAirLineWorkerDataTable();
			base.Tables.Add(this.dtInspectAirLineWorkerDataTable_0);
			this.dtInspectAirLineOtherDataTable_0 = new DataSetReportAirLinePassport.dtInspectAirLineOtherDataTable();
			base.Tables.Add(this.dtInspectAirLineOtherDataTable_0);
			this.dtPylonEquipExplMianDataTable_0 = new DataSetReportAirLinePassport.dtPylonEquipExplMianDataTable();
			base.Tables.Add(this.dtPylonEquipExplMianDataTable_0);
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool method_9()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool method_24()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_25(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.method_0();
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dataSetReportAirLinePassport.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

		private DataSetReportAirLinePassport.dtAirLineEquipmentDataTable dtAirLineEquipmentDataTable_0;

		private DataSetReportAirLinePassport.tp_AirLineReportDataTable tp_AirLineReportDataTable_0;

		private DataSetReportAirLinePassport.dtCrossingDataTable dtCrossingDataTable_0;

		private DataSetReportAirLinePassport.dtTerrainDataTable dtTerrainDataTable_0;

		private DataSetReportAirLinePassport.dsCountPoleDataTable dsCountPoleDataTable_0;

		private DataSetReportAirLinePassport.dtBranchDataTable dtBranchDataTable_0;

		private DataSetReportAirLinePassport.dtCableInsertionDataTable dtCableInsertionDataTable_0;

		private DataSetReportAirLinePassport.dtPylonEquipmentDataTable dtPylonEquipmentDataTable_0;

		private DataSetReportAirLinePassport.dtJointSuspensionDataTable dtJointSuspensionDataTable_0;

		private DataSetReportAirLinePassport.tBranchDataTable tBranchDataTable_0;

		private DataSetReportAirLinePassport.dtPylonsDataTable dtPylonsDataTable_0;

		private DataSetReportAirLinePassport.dtRoadDataTable qBimcXoHjrW;

		private DataSetReportAirLinePassport.vDocAirLineRepairDataTable vDocAirLineRepairDataTable_0;

		private DataSetReportAirLinePassport.vDocPylonEquipRepairDataTable vDocPylonEquipRepairDataTable_0;

		private DataSetReportAirLinePassport.tSettingsDataTable tSettingsDataTable_0;

		private DataSetReportAirLinePassport.dtReportAirLineRepairMainDataTable dtReportAirLineRepairMainDataTable_0;

		private DataSetReportAirLinePassport.dtReportAirLineRepairWorkDataTable dtReportAirLineRepairWorkDataTable_0;

		private DataSetReportAirLinePassport.dtReportAirLineRepairAddressDataTable dtReportAirLineRepairAddressDataTable_0;

		private DataSetReportAirLinePassport.dtInspectAirLineDefectDataTable dtInspectAirLineDefectDataTable_0;

		private DataSetReportAirLinePassport.dtInspectAirLineWorkerDataTable dtInspectAirLineWorkerDataTable_0;

		private DataSetReportAirLinePassport.dtInspectAirLineOtherDataTable dtInspectAirLineOtherDataTable_0;

		private DataSetReportAirLinePassport.dtPylonEquipExplMianDataTable dtPylonEquipExplMianDataTable_0;

		private SchemaSerializationMode schemaSerializationMode_0;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtAirLineEquipmentRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void tp_AirLineReportRowChangeEventHandler(object sender, DataSetReportAirLinePassport.tp_AirLineReportRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtCrossingRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtCrossingRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtTerrainRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtTerrainRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dsCountPoleRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dsCountPoleRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtBranchRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtBranchRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtCableInsertionRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtCableInsertionRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtPylonEquipmentRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtJointSuspensionRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtJointSuspensionRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void tBranchRowChangeEventHandler(object sender, DataSetReportAirLinePassport.tBranchRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtPylonsRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtPylonsRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtRoadRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtRoadRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void vDocAirLineRepairRowChangeEventHandler(object sender, DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void vDocPylonEquipRepairRowChangeEventHandler(object sender, DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void tSettingsRowChangeEventHandler(object sender, DataSetReportAirLinePassport.tSettingsRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtReportAirLineRepairMainRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtReportAirLineRepairWorkRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtReportAirLineRepairAddressRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtInspectAirLineDefectRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtInspectAirLineWorkerRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtInspectAirLineOtherRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEvent e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtPylonEquipExplMianRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEvent e);

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtAirLineEquipmentDataTable : TypedTableBase<DataSetReportAirLinePassport.dtAirLineEquipmentRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtAirLineEquipmentDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtAirLineEquipment";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtAirLineEquipmentDataTable(DataTable table)
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
			protected dtAirLineEquipmentDataTable(SerializationInfo info, StreamingContext context)
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
			public DataColumn NameColumn
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_16
			{
				get
				{
					return this.dataColumn_18;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PoleNumColumn
			{
				get
				{
					return this.dataColumn_19;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PoleCountColumn
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_18
			{
				get
				{
					return this.dataColumn_22;
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
			public DataSetReportAirLinePassport.dtAirLineEquipmentRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtAirLineEquipmentRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler = this.dtAirLineEquipmentRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler2;
					do
					{
						dtAirLineEquipmentRowChangeEventHandler2 = dtAirLineEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler)Delegate.Combine(dtAirLineEquipmentRowChangeEventHandler2, value);
						dtAirLineEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler>(ref this.dtAirLineEquipmentRowChangeEventHandler_0, value2, dtAirLineEquipmentRowChangeEventHandler2);
					}
					while (dtAirLineEquipmentRowChangeEventHandler != dtAirLineEquipmentRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler = this.dtAirLineEquipmentRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler2;
					do
					{
						dtAirLineEquipmentRowChangeEventHandler2 = dtAirLineEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler)Delegate.Remove(dtAirLineEquipmentRowChangeEventHandler2, value);
						dtAirLineEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler>(ref this.dtAirLineEquipmentRowChangeEventHandler_0, value2, dtAirLineEquipmentRowChangeEventHandler2);
					}
					while (dtAirLineEquipmentRowChangeEventHandler != dtAirLineEquipmentRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler = this.dtAirLineEquipmentRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler2;
					do
					{
						dtAirLineEquipmentRowChangeEventHandler2 = dtAirLineEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler)Delegate.Combine(dtAirLineEquipmentRowChangeEventHandler2, value);
						dtAirLineEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler>(ref this.dtAirLineEquipmentRowChangeEventHandler_1, value2, dtAirLineEquipmentRowChangeEventHandler2);
					}
					while (dtAirLineEquipmentRowChangeEventHandler != dtAirLineEquipmentRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler = this.dtAirLineEquipmentRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler2;
					do
					{
						dtAirLineEquipmentRowChangeEventHandler2 = dtAirLineEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler)Delegate.Remove(dtAirLineEquipmentRowChangeEventHandler2, value);
						dtAirLineEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler>(ref this.dtAirLineEquipmentRowChangeEventHandler_1, value2, dtAirLineEquipmentRowChangeEventHandler2);
					}
					while (dtAirLineEquipmentRowChangeEventHandler != dtAirLineEquipmentRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler = this.dtAirLineEquipmentRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler2;
					do
					{
						dtAirLineEquipmentRowChangeEventHandler2 = dtAirLineEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler)Delegate.Combine(dtAirLineEquipmentRowChangeEventHandler2, value);
						dtAirLineEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler>(ref this.dtAirLineEquipmentRowChangeEventHandler_2, value2, dtAirLineEquipmentRowChangeEventHandler2);
					}
					while (dtAirLineEquipmentRowChangeEventHandler != dtAirLineEquipmentRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler = this.dtAirLineEquipmentRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler2;
					do
					{
						dtAirLineEquipmentRowChangeEventHandler2 = dtAirLineEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler)Delegate.Remove(dtAirLineEquipmentRowChangeEventHandler2, value);
						dtAirLineEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler>(ref this.dtAirLineEquipmentRowChangeEventHandler_2, value2, dtAirLineEquipmentRowChangeEventHandler2);
					}
					while (dtAirLineEquipmentRowChangeEventHandler != dtAirLineEquipmentRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler = this.dtAirLineEquipmentRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler2;
					do
					{
						dtAirLineEquipmentRowChangeEventHandler2 = dtAirLineEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler)Delegate.Combine(dtAirLineEquipmentRowChangeEventHandler2, value);
						dtAirLineEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler>(ref this.dtAirLineEquipmentRowChangeEventHandler_3, value2, dtAirLineEquipmentRowChangeEventHandler2);
					}
					while (dtAirLineEquipmentRowChangeEventHandler != dtAirLineEquipmentRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler = this.dtAirLineEquipmentRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler2;
					do
					{
						dtAirLineEquipmentRowChangeEventHandler2 = dtAirLineEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler)Delegate.Remove(dtAirLineEquipmentRowChangeEventHandler2, value);
						dtAirLineEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler>(ref this.dtAirLineEquipmentRowChangeEventHandler_3, value2, dtAirLineEquipmentRowChangeEventHandler2);
					}
					while (dtAirLineEquipmentRowChangeEventHandler != dtAirLineEquipmentRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtAirLineEquipmentRow(DataSetReportAirLinePassport.dtAirLineEquipmentRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtAirLineEquipmentRow AdddtAirLineEquipmentRow(int id, string Name, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, string string_12, string string_13, string string_14, string string_15, string string_16, string PoleNum, int PoleCount, string string_17, string string_18)
			{
				DataSetReportAirLinePassport.dtAirLineEquipmentRow dtAirLineEquipmentRow = (DataSetReportAirLinePassport.dtAirLineEquipmentRow)base.NewRow();
				object[] itemArray = new object[]
				{
					id,
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
					string_16,
					PoleNum,
					PoleCount,
					string_17,
					string_18
				};
				dtAirLineEquipmentRow.ItemArray = itemArray;
				base.Rows.Add(dtAirLineEquipmentRow);
				return dtAirLineEquipmentRow;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtAirLineEquipmentDataTable dtAirLineEquipmentDataTable = (DataSetReportAirLinePassport.dtAirLineEquipmentDataTable)base.Clone();
				dtAirLineEquipmentDataTable.method_0();
				return dtAirLineEquipmentDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtAirLineEquipmentDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["Name"];
				this.dataColumn_2 = base.Columns["ГодУстановки"];
				this.dataColumn_3 = base.Columns["Стойка"];
				this.dataColumn_4 = base.Columns["Подкос"];
				this.dataColumn_5 = base.Columns["Приставка"];
				this.dataColumn_6 = base.Columns["Тип"];
				this.dataColumn_7 = base.Columns["Количество"];
				this.dataColumn_8 = base.Columns["НаличиеКонтура"];
				this.dataColumn_9 = base.Columns["Сопротивление"];
				this.dataColumn_10 = base.Columns["Принадлежность"];
				this.dataColumn_11 = base.Columns["ТипФундамента"];
				this.dataColumn_12 = base.Columns["СхемаПроводовИТросов"];
				this.dataColumn_13 = base.Columns["Назначение"];
				this.dataColumn_14 = base.Columns["ТипГирлянды"];
				this.dataColumn_15 = base.Columns["ДлинаКабеляМ"];
				this.dataColumn_16 = base.Columns["МаркаКабеля"];
				this.dataColumn_17 = base.Columns["ТипКонцевойМуфты"];
				this.dataColumn_18 = base.Columns["ТипОпоры"];
				this.dataColumn_19 = base.Columns["PoleNum"];
				this.dataColumn_20 = base.Columns["PoleCount"];
				this.dataColumn_21 = base.Columns["ВсегоНаЛинии"];
				this.dataColumn_22 = base.Columns["ТипИзолятора"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("ГодУстановки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("Стойка", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("Подкос", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Приставка", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("Тип", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("Количество", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("НаличиеКонтура", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("Сопротивление", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("Принадлежность", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("ТипФундамента", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("СхемаПроводовИТросов", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
				this.dataColumn_13 = new DataColumn("Назначение", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_13);
				this.dataColumn_14 = new DataColumn("ТипГирлянды", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_14);
				this.dataColumn_15 = new DataColumn("ДлинаКабеляМ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_15);
				this.dataColumn_16 = new DataColumn("МаркаКабеля", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_16);
				this.dataColumn_17 = new DataColumn("ТипКонцевойМуфты", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_17);
				this.dataColumn_18 = new DataColumn("ТипОпоры", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_18);
				this.dataColumn_19 = new DataColumn("PoleNum", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_19);
				this.dataColumn_20 = new DataColumn("PoleCount", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_20);
				this.dataColumn_21 = new DataColumn("ВсегоНаЛинии", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_21);
				this.dataColumn_22 = new DataColumn("ТипИзолятора", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_22);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtAirLineEquipmentRow NewdtAirLineEquipmentRow()
			{
				return (DataSetReportAirLinePassport.dtAirLineEquipmentRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtAirLineEquipmentRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtAirLineEquipmentRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtAirLineEquipmentRowChangeEventHandler_1 != null)
				{
					this.dtAirLineEquipmentRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtAirLineEquipmentRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtAirLineEquipmentRowChangeEventHandler_0 != null)
				{
					this.dtAirLineEquipmentRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtAirLineEquipmentRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtAirLineEquipmentRowChangeEventHandler_3 != null)
				{
					this.dtAirLineEquipmentRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtAirLineEquipmentRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtAirLineEquipmentRowChangeEventHandler_2 != null)
				{
					this.dtAirLineEquipmentRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtAirLineEquipmentRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovedtAirLineEquipmentRow(DataSetReportAirLinePassport.dtAirLineEquipmentRow row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtAirLineEquipmentDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			private DataColumn dataColumn_21;

			private DataColumn dataColumn_22;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tp_AirLineReportDataTable : TypedTableBase<DataSetReportAirLinePassport.tp_AirLineReportRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tp_AirLineReportDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "tp_AirLineReport";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tp_AirLineReportDataTable(DataTable table)
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
			protected tp_AirLineReportDataTable(SerializationInfo info, StreamingContext context)
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
			public DataColumn DataColumn_0
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			public DataColumn DataColumn_20
			{
				get
				{
					return this.dataColumn_22;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NumberColumn
			{
				get
				{
					return this.dataColumn_23;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			public DataSetReportAirLinePassport.tp_AirLineReportRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.tp_AirLineReportRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler = this.tp_AirLineReportRowChangeEventHandler_0;
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler2;
					do
					{
						tp_AirLineReportRowChangeEventHandler2 = tp_AirLineReportRowChangeEventHandler;
						DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler)Delegate.Combine(tp_AirLineReportRowChangeEventHandler2, value);
						tp_AirLineReportRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler>(ref this.tp_AirLineReportRowChangeEventHandler_0, value2, tp_AirLineReportRowChangeEventHandler2);
					}
					while (tp_AirLineReportRowChangeEventHandler != tp_AirLineReportRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler = this.tp_AirLineReportRowChangeEventHandler_0;
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler2;
					do
					{
						tp_AirLineReportRowChangeEventHandler2 = tp_AirLineReportRowChangeEventHandler;
						DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler)Delegate.Remove(tp_AirLineReportRowChangeEventHandler2, value);
						tp_AirLineReportRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler>(ref this.tp_AirLineReportRowChangeEventHandler_0, value2, tp_AirLineReportRowChangeEventHandler2);
					}
					while (tp_AirLineReportRowChangeEventHandler != tp_AirLineReportRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler = this.tp_AirLineReportRowChangeEventHandler_1;
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler2;
					do
					{
						tp_AirLineReportRowChangeEventHandler2 = tp_AirLineReportRowChangeEventHandler;
						DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler)Delegate.Combine(tp_AirLineReportRowChangeEventHandler2, value);
						tp_AirLineReportRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler>(ref this.tp_AirLineReportRowChangeEventHandler_1, value2, tp_AirLineReportRowChangeEventHandler2);
					}
					while (tp_AirLineReportRowChangeEventHandler != tp_AirLineReportRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler = this.tp_AirLineReportRowChangeEventHandler_1;
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler2;
					do
					{
						tp_AirLineReportRowChangeEventHandler2 = tp_AirLineReportRowChangeEventHandler;
						DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler)Delegate.Remove(tp_AirLineReportRowChangeEventHandler2, value);
						tp_AirLineReportRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler>(ref this.tp_AirLineReportRowChangeEventHandler_1, value2, tp_AirLineReportRowChangeEventHandler2);
					}
					while (tp_AirLineReportRowChangeEventHandler != tp_AirLineReportRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler = this.tp_AirLineReportRowChangeEventHandler_2;
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler2;
					do
					{
						tp_AirLineReportRowChangeEventHandler2 = tp_AirLineReportRowChangeEventHandler;
						DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler)Delegate.Combine(tp_AirLineReportRowChangeEventHandler2, value);
						tp_AirLineReportRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler>(ref this.tp_AirLineReportRowChangeEventHandler_2, value2, tp_AirLineReportRowChangeEventHandler2);
					}
					while (tp_AirLineReportRowChangeEventHandler != tp_AirLineReportRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler = this.tp_AirLineReportRowChangeEventHandler_2;
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler2;
					do
					{
						tp_AirLineReportRowChangeEventHandler2 = tp_AirLineReportRowChangeEventHandler;
						DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler)Delegate.Remove(tp_AirLineReportRowChangeEventHandler2, value);
						tp_AirLineReportRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler>(ref this.tp_AirLineReportRowChangeEventHandler_2, value2, tp_AirLineReportRowChangeEventHandler2);
					}
					while (tp_AirLineReportRowChangeEventHandler != tp_AirLineReportRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler = this.tp_AirLineReportRowChangeEventHandler_3;
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler2;
					do
					{
						tp_AirLineReportRowChangeEventHandler2 = tp_AirLineReportRowChangeEventHandler;
						DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler)Delegate.Combine(tp_AirLineReportRowChangeEventHandler2, value);
						tp_AirLineReportRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler>(ref this.tp_AirLineReportRowChangeEventHandler_3, value2, tp_AirLineReportRowChangeEventHandler2);
					}
					while (tp_AirLineReportRowChangeEventHandler != tp_AirLineReportRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler = this.tp_AirLineReportRowChangeEventHandler_3;
					DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler2;
					do
					{
						tp_AirLineReportRowChangeEventHandler2 = tp_AirLineReportRowChangeEventHandler;
						DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler)Delegate.Remove(tp_AirLineReportRowChangeEventHandler2, value);
						tp_AirLineReportRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler>(ref this.tp_AirLineReportRowChangeEventHandler_3, value2, tp_AirLineReportRowChangeEventHandler2);
					}
					while (tp_AirLineReportRowChangeEventHandler != tp_AirLineReportRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Addtp_AirLineReportRow(DataSetReportAirLinePassport.tp_AirLineReportRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.tp_AirLineReportRow Addtp_AirLineReportRow(int id, string string_0, string Name, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, string string_12, string string_13, string string_14, string string_15, string string_16, string string_17, string string_18, string string_19, string string_20, string Number, string string_21, string string_22, string string_23)
			{
				DataSetReportAirLinePassport.tp_AirLineReportRow tp_AirLineReportRow = (DataSetReportAirLinePassport.tp_AirLineReportRow)base.NewRow();
				object[] itemArray = new object[]
				{
					id,
					string_0,
					Name,
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
					string_16,
					string_17,
					string_18,
					string_19,
					string_20,
					Number,
					string_21,
					string_22,
					string_23
				};
				tp_AirLineReportRow.ItemArray = itemArray;
				base.Rows.Add(tp_AirLineReportRow);
				return tp_AirLineReportRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.tp_AirLineReportDataTable tp_AirLineReportDataTable = (DataSetReportAirLinePassport.tp_AirLineReportDataTable)base.Clone();
				tp_AirLineReportDataTable.method_0();
				return tp_AirLineReportDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.tp_AirLineReportDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["Напряжение"];
				this.dataColumn_2 = base.Columns["Name"];
				this.dataColumn_3 = base.Columns["ГодПостройки"];
				this.dataColumn_4 = base.Columns["ГодВводаВЭксплуатацию"];
				this.dataColumn_5 = base.Columns["ИнвентарныйНомер"];
				this.dataColumn_6 = base.Columns["НаименованиеПроектирующейОрганизации"];
				this.dataColumn_7 = base.Columns["НаименованиеСтроительноМонтажнойОрганизации"];
				this.dataColumn_8 = base.Columns["ПротяженностьЛинии"];
				this.dataColumn_9 = base.Columns["ДлинаПролета"];
				this.dataColumn_10 = base.Columns["МаркаПровода"];
				this.dataColumn_11 = base.Columns["ДлинаПроводаОбщая"];
				this.dataColumn_12 = base.Columns["РасстояниеМеждуПроводамиВФазе"];
				this.dataColumn_13 = base.Columns["МаркаГазотроса"];
				this.dataColumn_14 = base.Columns["МаркаТросаОттяжек"];
				this.dataColumn_15 = base.Columns["РайонКлиматическихУсловий"];
				this.dataColumn_16 = base.Columns["ТипПоддерживающегоУстройстваНаВсейЛинии"];
				this.dataColumn_17 = base.Columns["ТипПоддерживающегоУстройстваНаПереходах"];
				this.dataColumn_18 = base.Columns["РасстояниеМеждуДистанционнымиРаспорками"];
				this.dataColumn_19 = base.Columns["КоличествоЦепей"];
				this.dataColumn_20 = base.Columns["Регион"];
				this.dataColumn_21 = base.Columns["Участок"];
				this.dataColumn_22 = base.Columns["СечениеПровода"];
				this.dataColumn_23 = base.Columns["Number"];
				this.dataColumn_24 = base.Columns["Проектирующая"];
				this.dataColumn_25 = base.Columns["СтроительноМонтажная"];
				this.dataColumn_26 = base.Columns["ДатаВводаВЭксплуатацию"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Напряжение", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("ГодПостройки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("ГодВводаВЭксплуатацию", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("ИнвентарныйНомер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("НаименованиеПроектирующейОрганизации", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("НаименованиеСтроительноМонтажнойОрганизации", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("ПротяженностьЛинии", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("ДлинаПролета", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("МаркаПровода", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("ДлинаПроводаОбщая", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("РасстояниеМеждуПроводамиВФазе", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
				this.dataColumn_13 = new DataColumn("МаркаГазотроса", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_13);
				this.dataColumn_14 = new DataColumn("МаркаТросаОттяжек", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_14);
				this.dataColumn_15 = new DataColumn("РайонКлиматическихУсловий", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_15);
				this.dataColumn_16 = new DataColumn("ТипПоддерживающегоУстройстваНаВсейЛинии", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_16);
				this.dataColumn_17 = new DataColumn("ТипПоддерживающегоУстройстваНаПереходах", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_17);
				this.dataColumn_18 = new DataColumn("РасстояниеМеждуДистанционнымиРаспорками", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_18);
				this.dataColumn_19 = new DataColumn("КоличествоЦепей", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_19);
				this.dataColumn_20 = new DataColumn("Регион", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_20);
				this.dataColumn_21 = new DataColumn("Участок", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_21);
				this.dataColumn_22 = new DataColumn("СечениеПровода", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_22);
				this.dataColumn_23 = new DataColumn("Number", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_23);
				this.dataColumn_24 = new DataColumn("Проектирующая", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_24);
				this.dataColumn_25 = new DataColumn("СтроительноМонтажная", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_25);
				this.dataColumn_26 = new DataColumn("ДатаВводаВЭксплуатацию", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_26);
				this.dataColumn_1.Caption = "voltage";
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.tp_AirLineReportRow Newtp_AirLineReportRow()
			{
				return (DataSetReportAirLinePassport.tp_AirLineReportRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.tp_AirLineReportRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.tp_AirLineReportRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tp_AirLineReportRowChangeEventHandler_1 != null)
				{
					this.tp_AirLineReportRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.tp_AirLineReportRowChangeEvent((DataSetReportAirLinePassport.tp_AirLineReportRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tp_AirLineReportRowChangeEventHandler_0 != null)
				{
					this.tp_AirLineReportRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.tp_AirLineReportRowChangeEvent((DataSetReportAirLinePassport.tp_AirLineReportRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tp_AirLineReportRowChangeEventHandler_3 != null)
				{
					this.tp_AirLineReportRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.tp_AirLineReportRowChangeEvent((DataSetReportAirLinePassport.tp_AirLineReportRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tp_AirLineReportRowChangeEventHandler_2 != null)
				{
					this.tp_AirLineReportRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.tp_AirLineReportRowChangeEvent((DataSetReportAirLinePassport.tp_AirLineReportRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Removetp_AirLineReportRow(DataSetReportAirLinePassport.tp_AirLineReportRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tp_AirLineReportDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			private DataColumn dataColumn_21;

			private DataColumn dataColumn_22;

			private DataColumn dataColumn_23;

			private DataColumn dataColumn_24;

			private DataColumn dataColumn_25;

			private DataColumn dataColumn_26;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtCrossingDataTable : TypedTableBase<DataSetReportAirLinePassport.dtCrossingRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtCrossingDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtCrossing";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtCrossingDataTable(DataTable table)
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
			protected dtCrossingDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idObjListColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CrossingNameColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CountSpansColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn SpanNumbersColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idCrossingColumn
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ShortCrossingNameColumn
			{
				get
				{
					return this.dataColumn_5;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn PylonNumbersColumn
			{
				get
				{
					return this.dataColumn_6;
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
			public DataSetReportAirLinePassport.dtCrossingRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtCrossingRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler = this.dtCrossingRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler2;
					do
					{
						dtCrossingRowChangeEventHandler2 = dtCrossingRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler)Delegate.Combine(dtCrossingRowChangeEventHandler2, value);
						dtCrossingRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler>(ref this.dtCrossingRowChangeEventHandler_0, value2, dtCrossingRowChangeEventHandler2);
					}
					while (dtCrossingRowChangeEventHandler != dtCrossingRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler = this.dtCrossingRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler2;
					do
					{
						dtCrossingRowChangeEventHandler2 = dtCrossingRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler)Delegate.Remove(dtCrossingRowChangeEventHandler2, value);
						dtCrossingRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler>(ref this.dtCrossingRowChangeEventHandler_0, value2, dtCrossingRowChangeEventHandler2);
					}
					while (dtCrossingRowChangeEventHandler != dtCrossingRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler = this.dtCrossingRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler2;
					do
					{
						dtCrossingRowChangeEventHandler2 = dtCrossingRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler)Delegate.Combine(dtCrossingRowChangeEventHandler2, value);
						dtCrossingRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler>(ref this.dtCrossingRowChangeEventHandler_1, value2, dtCrossingRowChangeEventHandler2);
					}
					while (dtCrossingRowChangeEventHandler != dtCrossingRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler = this.dtCrossingRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler2;
					do
					{
						dtCrossingRowChangeEventHandler2 = dtCrossingRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler)Delegate.Remove(dtCrossingRowChangeEventHandler2, value);
						dtCrossingRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler>(ref this.dtCrossingRowChangeEventHandler_1, value2, dtCrossingRowChangeEventHandler2);
					}
					while (dtCrossingRowChangeEventHandler != dtCrossingRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler = this.dtCrossingRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler2;
					do
					{
						dtCrossingRowChangeEventHandler2 = dtCrossingRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler)Delegate.Combine(dtCrossingRowChangeEventHandler2, value);
						dtCrossingRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler>(ref this.dtCrossingRowChangeEventHandler_2, value2, dtCrossingRowChangeEventHandler2);
					}
					while (dtCrossingRowChangeEventHandler != dtCrossingRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler = this.dtCrossingRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler2;
					do
					{
						dtCrossingRowChangeEventHandler2 = dtCrossingRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler)Delegate.Remove(dtCrossingRowChangeEventHandler2, value);
						dtCrossingRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler>(ref this.dtCrossingRowChangeEventHandler_2, value2, dtCrossingRowChangeEventHandler2);
					}
					while (dtCrossingRowChangeEventHandler != dtCrossingRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler = this.dtCrossingRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler2;
					do
					{
						dtCrossingRowChangeEventHandler2 = dtCrossingRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler)Delegate.Combine(dtCrossingRowChangeEventHandler2, value);
						dtCrossingRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler>(ref this.dtCrossingRowChangeEventHandler_3, value2, dtCrossingRowChangeEventHandler2);
					}
					while (dtCrossingRowChangeEventHandler != dtCrossingRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler = this.dtCrossingRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler2;
					do
					{
						dtCrossingRowChangeEventHandler2 = dtCrossingRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler)Delegate.Remove(dtCrossingRowChangeEventHandler2, value);
						dtCrossingRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler>(ref this.dtCrossingRowChangeEventHandler_3, value2, dtCrossingRowChangeEventHandler2);
					}
					while (dtCrossingRowChangeEventHandler != dtCrossingRowChangeEventHandler2);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtCrossingRow(DataSetReportAirLinePassport.dtCrossingRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtCrossingRow AdddtCrossingRow(int idObjList, string CrossingName, int CountSpans, string SpanNumbers, int idCrossing, string ShortCrossingName, string PylonNumbers)
			{
				DataSetReportAirLinePassport.dtCrossingRow dtCrossingRow = (DataSetReportAirLinePassport.dtCrossingRow)base.NewRow();
				object[] itemArray = new object[]
				{
					idObjList,
					CrossingName,
					CountSpans,
					SpanNumbers,
					idCrossing,
					ShortCrossingName,
					PylonNumbers
				};
				dtCrossingRow.ItemArray = itemArray;
				base.Rows.Add(dtCrossingRow);
				return dtCrossingRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtCrossingDataTable dtCrossingDataTable = (DataSetReportAirLinePassport.dtCrossingDataTable)base.Clone();
				dtCrossingDataTable.method_0();
				return dtCrossingDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtCrossingDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["idObjList"];
				this.dataColumn_1 = base.Columns["CrossingName"];
				this.dataColumn_2 = base.Columns["CountSpans"];
				this.dataColumn_3 = base.Columns["SpanNumbers"];
				this.dataColumn_4 = base.Columns["idCrossing"];
				this.dataColumn_5 = base.Columns["ShortCrossingName"];
				this.dataColumn_6 = base.Columns["PylonNumbers"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("CrossingName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("CountSpans", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("SpanNumbers", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("idCrossing", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("ShortCrossingName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("PylonNumbers", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtCrossingRow NewdtCrossingRow()
			{
				return (DataSetReportAirLinePassport.dtCrossingRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtCrossingRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtCrossingRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtCrossingRowChangeEventHandler_1 != null)
				{
					this.dtCrossingRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtCrossingRowChangeEvent((DataSetReportAirLinePassport.dtCrossingRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtCrossingRowChangeEventHandler_0 != null)
				{
					this.dtCrossingRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtCrossingRowChangeEvent((DataSetReportAirLinePassport.dtCrossingRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtCrossingRowChangeEventHandler_3 != null)
				{
					this.dtCrossingRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtCrossingRowChangeEvent((DataSetReportAirLinePassport.dtCrossingRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtCrossingRowChangeEventHandler_2 != null)
				{
					this.dtCrossingRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtCrossingRowChangeEvent((DataSetReportAirLinePassport.dtCrossingRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtCrossingRow(DataSetReportAirLinePassport.dtCrossingRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtCrossingDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtTerrainDataTable : TypedTableBase<DataSetReportAirLinePassport.dtTerrainRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtTerrainDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtTerrain";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtTerrainDataTable(DataTable table)
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
			protected dtTerrainDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idObjListColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idTerrainColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TerrainNameColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn SpanNumbersColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn FullLengthColumn
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn PylonNumbersColumn
			{
				get
				{
					return this.dataColumn_5;
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
			public DataSetReportAirLinePassport.dtTerrainRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtTerrainRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler = this.dtTerrainRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler2;
					do
					{
						dtTerrainRowChangeEventHandler2 = dtTerrainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler)Delegate.Combine(dtTerrainRowChangeEventHandler2, value);
						dtTerrainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler>(ref this.dtTerrainRowChangeEventHandler_0, value2, dtTerrainRowChangeEventHandler2);
					}
					while (dtTerrainRowChangeEventHandler != dtTerrainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler = this.dtTerrainRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler2;
					do
					{
						dtTerrainRowChangeEventHandler2 = dtTerrainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler)Delegate.Remove(dtTerrainRowChangeEventHandler2, value);
						dtTerrainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler>(ref this.dtTerrainRowChangeEventHandler_0, value2, dtTerrainRowChangeEventHandler2);
					}
					while (dtTerrainRowChangeEventHandler != dtTerrainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler = this.dtTerrainRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler2;
					do
					{
						dtTerrainRowChangeEventHandler2 = dtTerrainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler)Delegate.Combine(dtTerrainRowChangeEventHandler2, value);
						dtTerrainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler>(ref this.dtTerrainRowChangeEventHandler_1, value2, dtTerrainRowChangeEventHandler2);
					}
					while (dtTerrainRowChangeEventHandler != dtTerrainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler = this.dtTerrainRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler2;
					do
					{
						dtTerrainRowChangeEventHandler2 = dtTerrainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler)Delegate.Remove(dtTerrainRowChangeEventHandler2, value);
						dtTerrainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler>(ref this.dtTerrainRowChangeEventHandler_1, value2, dtTerrainRowChangeEventHandler2);
					}
					while (dtTerrainRowChangeEventHandler != dtTerrainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler = this.dtTerrainRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler2;
					do
					{
						dtTerrainRowChangeEventHandler2 = dtTerrainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler)Delegate.Combine(dtTerrainRowChangeEventHandler2, value);
						dtTerrainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler>(ref this.dtTerrainRowChangeEventHandler_2, value2, dtTerrainRowChangeEventHandler2);
					}
					while (dtTerrainRowChangeEventHandler != dtTerrainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler = this.dtTerrainRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler2;
					do
					{
						dtTerrainRowChangeEventHandler2 = dtTerrainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler)Delegate.Remove(dtTerrainRowChangeEventHandler2, value);
						dtTerrainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler>(ref this.dtTerrainRowChangeEventHandler_2, value2, dtTerrainRowChangeEventHandler2);
					}
					while (dtTerrainRowChangeEventHandler != dtTerrainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler = this.dtTerrainRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler2;
					do
					{
						dtTerrainRowChangeEventHandler2 = dtTerrainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler)Delegate.Combine(dtTerrainRowChangeEventHandler2, value);
						dtTerrainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler>(ref this.dtTerrainRowChangeEventHandler_3, value2, dtTerrainRowChangeEventHandler2);
					}
					while (dtTerrainRowChangeEventHandler != dtTerrainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler = this.dtTerrainRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler2;
					do
					{
						dtTerrainRowChangeEventHandler2 = dtTerrainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler)Delegate.Remove(dtTerrainRowChangeEventHandler2, value);
						dtTerrainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler>(ref this.dtTerrainRowChangeEventHandler_3, value2, dtTerrainRowChangeEventHandler2);
					}
					while (dtTerrainRowChangeEventHandler != dtTerrainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtTerrainRow(DataSetReportAirLinePassport.dtTerrainRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtTerrainRow AdddtTerrainRow(int idObjList, int idTerrain, string TerrainName, string SpanNumbers, string FullLength, string PylonNumbers)
			{
				DataSetReportAirLinePassport.dtTerrainRow dtTerrainRow = (DataSetReportAirLinePassport.dtTerrainRow)base.NewRow();
				object[] itemArray = new object[]
				{
					idObjList,
					idTerrain,
					TerrainName,
					SpanNumbers,
					FullLength,
					PylonNumbers
				};
				dtTerrainRow.ItemArray = itemArray;
				base.Rows.Add(dtTerrainRow);
				return dtTerrainRow;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtTerrainDataTable dtTerrainDataTable = (DataSetReportAirLinePassport.dtTerrainDataTable)base.Clone();
				dtTerrainDataTable.method_0();
				return dtTerrainDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtTerrainDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["idObjList"];
				this.dataColumn_1 = base.Columns["idTerrain"];
				this.dataColumn_2 = base.Columns["TerrainName"];
				this.dataColumn_3 = base.Columns["SpanNumbers"];
				this.dataColumn_4 = base.Columns["FullLength"];
				this.dataColumn_5 = base.Columns["PylonNumbers"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("idTerrain", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("TerrainName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("SpanNumbers", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("FullLength", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("PylonNumbers", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtTerrainRow NewdtTerrainRow()
			{
				return (DataSetReportAirLinePassport.dtTerrainRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtTerrainRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtTerrainRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtTerrainRowChangeEventHandler_1 != null)
				{
					this.dtTerrainRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtTerrainRowChangeEvent((DataSetReportAirLinePassport.dtTerrainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtTerrainRowChangeEventHandler_0 != null)
				{
					this.dtTerrainRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtTerrainRowChangeEvent((DataSetReportAirLinePassport.dtTerrainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtTerrainRowChangeEventHandler_3 != null)
				{
					this.dtTerrainRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtTerrainRowChangeEvent((DataSetReportAirLinePassport.dtTerrainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtTerrainRowChangeEventHandler_2 != null)
				{
					this.dtTerrainRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtTerrainRowChangeEvent((DataSetReportAirLinePassport.dtTerrainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtTerrainRow(DataSetReportAirLinePassport.dtTerrainRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtTerrainDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dsCountPoleDataTable : TypedTableBase<DataSetReportAirLinePassport.dsCountPoleRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dsCountPoleDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dsCountPole";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dsCountPoleDataTable(DataTable table)
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
			protected dsCountPoleDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idObjListColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn KoncColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn OtvColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn UglColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn PromColumn
			{
				get
				{
					return this.dataColumn_4;
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
			public DataSetReportAirLinePassport.dsCountPoleRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dsCountPoleRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler = this.dsCountPoleRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler2;
					do
					{
						dsCountPoleRowChangeEventHandler2 = dsCountPoleRowChangeEventHandler;
						DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler)Delegate.Combine(dsCountPoleRowChangeEventHandler2, value);
						dsCountPoleRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler>(ref this.dsCountPoleRowChangeEventHandler_0, value2, dsCountPoleRowChangeEventHandler2);
					}
					while (dsCountPoleRowChangeEventHandler != dsCountPoleRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler = this.dsCountPoleRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler2;
					do
					{
						dsCountPoleRowChangeEventHandler2 = dsCountPoleRowChangeEventHandler;
						DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler)Delegate.Remove(dsCountPoleRowChangeEventHandler2, value);
						dsCountPoleRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler>(ref this.dsCountPoleRowChangeEventHandler_0, value2, dsCountPoleRowChangeEventHandler2);
					}
					while (dsCountPoleRowChangeEventHandler != dsCountPoleRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler = this.dsCountPoleRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler2;
					do
					{
						dsCountPoleRowChangeEventHandler2 = dsCountPoleRowChangeEventHandler;
						DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler)Delegate.Combine(dsCountPoleRowChangeEventHandler2, value);
						dsCountPoleRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler>(ref this.dsCountPoleRowChangeEventHandler_1, value2, dsCountPoleRowChangeEventHandler2);
					}
					while (dsCountPoleRowChangeEventHandler != dsCountPoleRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler = this.dsCountPoleRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler2;
					do
					{
						dsCountPoleRowChangeEventHandler2 = dsCountPoleRowChangeEventHandler;
						DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler)Delegate.Remove(dsCountPoleRowChangeEventHandler2, value);
						dsCountPoleRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler>(ref this.dsCountPoleRowChangeEventHandler_1, value2, dsCountPoleRowChangeEventHandler2);
					}
					while (dsCountPoleRowChangeEventHandler != dsCountPoleRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler = this.dsCountPoleRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler2;
					do
					{
						dsCountPoleRowChangeEventHandler2 = dsCountPoleRowChangeEventHandler;
						DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler)Delegate.Combine(dsCountPoleRowChangeEventHandler2, value);
						dsCountPoleRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler>(ref this.dsCountPoleRowChangeEventHandler_2, value2, dsCountPoleRowChangeEventHandler2);
					}
					while (dsCountPoleRowChangeEventHandler != dsCountPoleRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler = this.dsCountPoleRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler2;
					do
					{
						dsCountPoleRowChangeEventHandler2 = dsCountPoleRowChangeEventHandler;
						DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler)Delegate.Remove(dsCountPoleRowChangeEventHandler2, value);
						dsCountPoleRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler>(ref this.dsCountPoleRowChangeEventHandler_2, value2, dsCountPoleRowChangeEventHandler2);
					}
					while (dsCountPoleRowChangeEventHandler != dsCountPoleRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler = this.dsCountPoleRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler2;
					do
					{
						dsCountPoleRowChangeEventHandler2 = dsCountPoleRowChangeEventHandler;
						DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler)Delegate.Combine(dsCountPoleRowChangeEventHandler2, value);
						dsCountPoleRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler>(ref this.dsCountPoleRowChangeEventHandler_3, value2, dsCountPoleRowChangeEventHandler2);
					}
					while (dsCountPoleRowChangeEventHandler != dsCountPoleRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler = this.dsCountPoleRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler2;
					do
					{
						dsCountPoleRowChangeEventHandler2 = dsCountPoleRowChangeEventHandler;
						DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler)Delegate.Remove(dsCountPoleRowChangeEventHandler2, value);
						dsCountPoleRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler>(ref this.dsCountPoleRowChangeEventHandler_3, value2, dsCountPoleRowChangeEventHandler2);
					}
					while (dsCountPoleRowChangeEventHandler != dsCountPoleRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddsCountPoleRow(DataSetReportAirLinePassport.dsCountPoleRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dsCountPoleRow AdddsCountPoleRow(int idObjList, int Konc, int Otv, int Ugl, int Prom)
			{
				DataSetReportAirLinePassport.dsCountPoleRow dsCountPoleRow = (DataSetReportAirLinePassport.dsCountPoleRow)base.NewRow();
				object[] itemArray = new object[]
				{
					idObjList,
					Konc,
					Otv,
					Ugl,
					Prom
				};
				dsCountPoleRow.ItemArray = itemArray;
				base.Rows.Add(dsCountPoleRow);
				return dsCountPoleRow;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dsCountPoleDataTable dsCountPoleDataTable = (DataSetReportAirLinePassport.dsCountPoleDataTable)base.Clone();
				dsCountPoleDataTable.method_0();
				return dsCountPoleDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dsCountPoleDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["idObjList"];
				this.dataColumn_1 = base.Columns["Konc"];
				this.dataColumn_2 = base.Columns["Otv"];
				this.dataColumn_3 = base.Columns["Ugl"];
				this.dataColumn_4 = base.Columns["Prom"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Konc", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("Otv", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("Ugl", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("Prom", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dsCountPoleRow NewdsCountPoleRow()
			{
				return (DataSetReportAirLinePassport.dsCountPoleRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dsCountPoleRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dsCountPoleRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dsCountPoleRowChangeEventHandler_1 != null)
				{
					this.dsCountPoleRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dsCountPoleRowChangeEvent((DataSetReportAirLinePassport.dsCountPoleRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dsCountPoleRowChangeEventHandler_0 != null)
				{
					this.dsCountPoleRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dsCountPoleRowChangeEvent((DataSetReportAirLinePassport.dsCountPoleRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dsCountPoleRowChangeEventHandler_3 != null)
				{
					this.dsCountPoleRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dsCountPoleRowChangeEvent((DataSetReportAirLinePassport.dsCountPoleRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dsCountPoleRowChangeEventHandler_2 != null)
				{
					this.dsCountPoleRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dsCountPoleRowChangeEvent((DataSetReportAirLinePassport.dsCountPoleRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedsCountPoleRow(DataSetReportAirLinePassport.dsCountPoleRow row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dsCountPoleDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtBranchDataTable : TypedTableBase<DataSetReportAirLinePassport.dtBranchRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtBranchDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtBranch";
				this.BeginInit();
				this.method_0();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtBranchDataTable(DataTable table)
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
			protected dtBranchDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.DhBaTtWiXdp();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PoleNumColumn
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
			public DataSetReportAirLinePassport.dtBranchRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtBranchRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler = this.dtBranchRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler2;
					do
					{
						dtBranchRowChangeEventHandler2 = dtBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.dtBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtBranchRowChangeEventHandler)Delegate.Combine(dtBranchRowChangeEventHandler2, value);
						dtBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtBranchRowChangeEventHandler>(ref this.dtBranchRowChangeEventHandler_0, value2, dtBranchRowChangeEventHandler2);
					}
					while (dtBranchRowChangeEventHandler != dtBranchRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler = this.dtBranchRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler2;
					do
					{
						dtBranchRowChangeEventHandler2 = dtBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.dtBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtBranchRowChangeEventHandler)Delegate.Remove(dtBranchRowChangeEventHandler2, value);
						dtBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtBranchRowChangeEventHandler>(ref this.dtBranchRowChangeEventHandler_0, value2, dtBranchRowChangeEventHandler2);
					}
					while (dtBranchRowChangeEventHandler != dtBranchRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler = this.dtBranchRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler2;
					do
					{
						dtBranchRowChangeEventHandler2 = dtBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.dtBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtBranchRowChangeEventHandler)Delegate.Combine(dtBranchRowChangeEventHandler2, value);
						dtBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtBranchRowChangeEventHandler>(ref this.dtBranchRowChangeEventHandler_1, value2, dtBranchRowChangeEventHandler2);
					}
					while (dtBranchRowChangeEventHandler != dtBranchRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler = this.dtBranchRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler2;
					do
					{
						dtBranchRowChangeEventHandler2 = dtBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.dtBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtBranchRowChangeEventHandler)Delegate.Remove(dtBranchRowChangeEventHandler2, value);
						dtBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtBranchRowChangeEventHandler>(ref this.dtBranchRowChangeEventHandler_1, value2, dtBranchRowChangeEventHandler2);
					}
					while (dtBranchRowChangeEventHandler != dtBranchRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler = this.dtBranchRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler2;
					do
					{
						dtBranchRowChangeEventHandler2 = dtBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.dtBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtBranchRowChangeEventHandler)Delegate.Combine(dtBranchRowChangeEventHandler2, value);
						dtBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtBranchRowChangeEventHandler>(ref this.dtBranchRowChangeEventHandler_2, value2, dtBranchRowChangeEventHandler2);
					}
					while (dtBranchRowChangeEventHandler != dtBranchRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler = this.dtBranchRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler2;
					do
					{
						dtBranchRowChangeEventHandler2 = dtBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.dtBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtBranchRowChangeEventHandler)Delegate.Remove(dtBranchRowChangeEventHandler2, value);
						dtBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtBranchRowChangeEventHandler>(ref this.dtBranchRowChangeEventHandler_2, value2, dtBranchRowChangeEventHandler2);
					}
					while (dtBranchRowChangeEventHandler != dtBranchRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler = this.dtBranchRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler2;
					do
					{
						dtBranchRowChangeEventHandler2 = dtBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.dtBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtBranchRowChangeEventHandler)Delegate.Combine(dtBranchRowChangeEventHandler2, value);
						dtBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtBranchRowChangeEventHandler>(ref this.dtBranchRowChangeEventHandler_3, value2, dtBranchRowChangeEventHandler2);
					}
					while (dtBranchRowChangeEventHandler != dtBranchRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler = this.dtBranchRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler2;
					do
					{
						dtBranchRowChangeEventHandler2 = dtBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.dtBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtBranchRowChangeEventHandler)Delegate.Remove(dtBranchRowChangeEventHandler2, value);
						dtBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtBranchRowChangeEventHandler>(ref this.dtBranchRowChangeEventHandler_3, value2, dtBranchRowChangeEventHandler2);
					}
					while (dtBranchRowChangeEventHandler != dtBranchRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtBranchRow(DataSetReportAirLinePassport.dtBranchRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtBranchRow AdddtBranchRow(string PoleNum, string string_0, string string_1, string string_2)
			{
				DataSetReportAirLinePassport.dtBranchRow dtBranchRow = (DataSetReportAirLinePassport.dtBranchRow)base.NewRow();
				object[] itemArray = new object[]
				{
					PoleNum,
					string_0,
					string_1,
					string_2
				};
				dtBranchRow.ItemArray = itemArray;
				base.Rows.Add(dtBranchRow);
				return dtBranchRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtBranchDataTable dtBranchDataTable = (DataSetReportAirLinePassport.dtBranchDataTable)base.Clone();
				dtBranchDataTable.DhBaTtWiXdp();
				return dtBranchDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtBranchDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void DhBaTtWiXdp()
			{
				this.dataColumn_0 = base.Columns["PoleNum"];
				this.dataColumn_1 = base.Columns["ДлинаОтветвленияМ"];
				this.dataColumn_2 = base.Columns["ЧислоВводов"];
				this.dataColumn_3 = base.Columns["ТипПровода"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_0()
			{
				this.dataColumn_0 = new DataColumn("PoleNum", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("ДлинаОтветвленияМ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("ЧислоВводов", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("ТипПровода", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtBranchRow NewdtBranchRow()
			{
				return (DataSetReportAirLinePassport.dtBranchRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtBranchRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtBranchRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtBranchRowChangeEventHandler_1 != null)
				{
					this.dtBranchRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtBranchRowChangeEvent((DataSetReportAirLinePassport.dtBranchRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtBranchRowChangeEventHandler_0 != null)
				{
					this.dtBranchRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtBranchRowChangeEvent((DataSetReportAirLinePassport.dtBranchRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtBranchRowChangeEventHandler_3 != null)
				{
					this.dtBranchRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtBranchRowChangeEvent((DataSetReportAirLinePassport.dtBranchRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtBranchRowChangeEventHandler_2 != null)
				{
					this.dtBranchRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtBranchRowChangeEvent((DataSetReportAirLinePassport.dtBranchRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtBranchRow(DataSetReportAirLinePassport.dtBranchRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtBranchDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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
			private DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtCableInsertionDataTable : TypedTableBase<DataSetReportAirLinePassport.dtCableInsertionRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtCableInsertionDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtCableInsertion";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtCableInsertionDataTable(DataTable table)
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
			protected dtCableInsertionDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PoleNumColumn
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
					return this.DtEaTvagdEy;
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
			public DataColumn DataColumn_4
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtCableInsertionRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtCableInsertionRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler = this.dtCableInsertionRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler2;
					do
					{
						dtCableInsertionRowChangeEventHandler2 = dtCableInsertionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler)Delegate.Combine(dtCableInsertionRowChangeEventHandler2, value);
						dtCableInsertionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler>(ref this.dtCableInsertionRowChangeEventHandler_0, value2, dtCableInsertionRowChangeEventHandler2);
					}
					while (dtCableInsertionRowChangeEventHandler != dtCableInsertionRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler = this.dtCableInsertionRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler2;
					do
					{
						dtCableInsertionRowChangeEventHandler2 = dtCableInsertionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler)Delegate.Remove(dtCableInsertionRowChangeEventHandler2, value);
						dtCableInsertionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler>(ref this.dtCableInsertionRowChangeEventHandler_0, value2, dtCableInsertionRowChangeEventHandler2);
					}
					while (dtCableInsertionRowChangeEventHandler != dtCableInsertionRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler = this.dtCableInsertionRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler2;
					do
					{
						dtCableInsertionRowChangeEventHandler2 = dtCableInsertionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler)Delegate.Combine(dtCableInsertionRowChangeEventHandler2, value);
						dtCableInsertionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler>(ref this.dtCableInsertionRowChangeEventHandler_1, value2, dtCableInsertionRowChangeEventHandler2);
					}
					while (dtCableInsertionRowChangeEventHandler != dtCableInsertionRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler = this.dtCableInsertionRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler2;
					do
					{
						dtCableInsertionRowChangeEventHandler2 = dtCableInsertionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler)Delegate.Remove(dtCableInsertionRowChangeEventHandler2, value);
						dtCableInsertionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler>(ref this.dtCableInsertionRowChangeEventHandler_1, value2, dtCableInsertionRowChangeEventHandler2);
					}
					while (dtCableInsertionRowChangeEventHandler != dtCableInsertionRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler = this.dtCableInsertionRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler2;
					do
					{
						dtCableInsertionRowChangeEventHandler2 = dtCableInsertionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler)Delegate.Combine(dtCableInsertionRowChangeEventHandler2, value);
						dtCableInsertionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler>(ref this.dtCableInsertionRowChangeEventHandler_2, value2, dtCableInsertionRowChangeEventHandler2);
					}
					while (dtCableInsertionRowChangeEventHandler != dtCableInsertionRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler = this.dtCableInsertionRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler2;
					do
					{
						dtCableInsertionRowChangeEventHandler2 = dtCableInsertionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler)Delegate.Remove(dtCableInsertionRowChangeEventHandler2, value);
						dtCableInsertionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler>(ref this.dtCableInsertionRowChangeEventHandler_2, value2, dtCableInsertionRowChangeEventHandler2);
					}
					while (dtCableInsertionRowChangeEventHandler != dtCableInsertionRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler = this.dtCableInsertionRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler2;
					do
					{
						dtCableInsertionRowChangeEventHandler2 = dtCableInsertionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler)Delegate.Combine(dtCableInsertionRowChangeEventHandler2, value);
						dtCableInsertionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler>(ref this.dtCableInsertionRowChangeEventHandler_3, value2, dtCableInsertionRowChangeEventHandler2);
					}
					while (dtCableInsertionRowChangeEventHandler != dtCableInsertionRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler = this.dtCableInsertionRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler2;
					do
					{
						dtCableInsertionRowChangeEventHandler2 = dtCableInsertionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler)Delegate.Remove(dtCableInsertionRowChangeEventHandler2, value);
						dtCableInsertionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler>(ref this.dtCableInsertionRowChangeEventHandler_3, value2, dtCableInsertionRowChangeEventHandler2);
					}
					while (dtCableInsertionRowChangeEventHandler != dtCableInsertionRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtCableInsertionRow(DataSetReportAirLinePassport.dtCableInsertionRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtCableInsertionRow AdddtCableInsertionRow(string PoleNum, string string_0, string string_1, string string_2, string string_3, string string_4)
			{
				DataSetReportAirLinePassport.dtCableInsertionRow dtCableInsertionRow = (DataSetReportAirLinePassport.dtCableInsertionRow)base.NewRow();
				object[] itemArray = new object[]
				{
					PoleNum,
					string_0,
					string_1,
					string_2,
					string_3,
					string_4
				};
				dtCableInsertionRow.ItemArray = itemArray;
				base.Rows.Add(dtCableInsertionRow);
				return dtCableInsertionRow;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtCableInsertionDataTable dtCableInsertionDataTable = (DataSetReportAirLinePassport.dtCableInsertionDataTable)base.Clone();
				dtCableInsertionDataTable.method_0();
				return dtCableInsertionDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtCableInsertionDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["PoleNum"];
				this.DtEaTvagdEy = base.Columns["Назначение"];
				this.dataColumn_1 = base.Columns["ДлинаКабеляМ"];
				this.dataColumn_2 = base.Columns["МаркаКабеля"];
				this.dataColumn_3 = base.Columns["ТипКонцевойМуфты"];
				this.dataColumn_4 = base.Columns["ТипСоединительнойМуфты"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("PoleNum", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.DtEaTvagdEy = new DataColumn("Назначение", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.DtEaTvagdEy);
				this.dataColumn_1 = new DataColumn("ДлинаКабеляМ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("МаркаКабеля", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("ТипКонцевойМуфты", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("ТипСоединительнойМуфты", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtCableInsertionRow NewdtCableInsertionRow()
			{
				return (DataSetReportAirLinePassport.dtCableInsertionRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtCableInsertionRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtCableInsertionRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtCableInsertionRowChangeEventHandler_1 != null)
				{
					this.dtCableInsertionRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtCableInsertionRowChangeEvent((DataSetReportAirLinePassport.dtCableInsertionRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtCableInsertionRowChangeEventHandler_0 != null)
				{
					this.dtCableInsertionRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtCableInsertionRowChangeEvent((DataSetReportAirLinePassport.dtCableInsertionRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtCableInsertionRowChangeEventHandler_3 != null)
				{
					this.dtCableInsertionRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtCableInsertionRowChangeEvent((DataSetReportAirLinePassport.dtCableInsertionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtCableInsertionRowChangeEventHandler_2 != null)
				{
					this.dtCableInsertionRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtCableInsertionRowChangeEvent((DataSetReportAirLinePassport.dtCableInsertionRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtCableInsertionRow(DataSetReportAirLinePassport.dtCableInsertionRow row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtCableInsertionDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			private DataColumn DtEaTvagdEy;

			private DataColumn dataColumn_1;

			private DataColumn dataColumn_2;

			private DataColumn dataColumn_3;

			private DataColumn dataColumn_4;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtPylonEquipmentDataTable : TypedTableBase<DataSetReportAirLinePassport.dtPylonEquipmentRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtPylonEquipmentDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtPylonEquipment";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtPylonEquipmentDataTable(DataTable table)
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
			protected dtPylonEquipmentDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TypeEquipmentColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CountColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PoleNumColumn
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
			public DataSetReportAirLinePassport.dtPylonEquipmentRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtPylonEquipmentRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler = this.dtPylonEquipmentRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler2;
					do
					{
						dtPylonEquipmentRowChangeEventHandler2 = dtPylonEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler)Delegate.Combine(dtPylonEquipmentRowChangeEventHandler2, value);
						dtPylonEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler>(ref this.dtPylonEquipmentRowChangeEventHandler_0, value2, dtPylonEquipmentRowChangeEventHandler2);
					}
					while (dtPylonEquipmentRowChangeEventHandler != dtPylonEquipmentRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler = this.dtPylonEquipmentRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler2;
					do
					{
						dtPylonEquipmentRowChangeEventHandler2 = dtPylonEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler)Delegate.Remove(dtPylonEquipmentRowChangeEventHandler2, value);
						dtPylonEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler>(ref this.dtPylonEquipmentRowChangeEventHandler_0, value2, dtPylonEquipmentRowChangeEventHandler2);
					}
					while (dtPylonEquipmentRowChangeEventHandler != dtPylonEquipmentRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler = this.dtPylonEquipmentRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler2;
					do
					{
						dtPylonEquipmentRowChangeEventHandler2 = dtPylonEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler)Delegate.Combine(dtPylonEquipmentRowChangeEventHandler2, value);
						dtPylonEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler>(ref this.dtPylonEquipmentRowChangeEventHandler_1, value2, dtPylonEquipmentRowChangeEventHandler2);
					}
					while (dtPylonEquipmentRowChangeEventHandler != dtPylonEquipmentRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler = this.dtPylonEquipmentRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler2;
					do
					{
						dtPylonEquipmentRowChangeEventHandler2 = dtPylonEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler)Delegate.Remove(dtPylonEquipmentRowChangeEventHandler2, value);
						dtPylonEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler>(ref this.dtPylonEquipmentRowChangeEventHandler_1, value2, dtPylonEquipmentRowChangeEventHandler2);
					}
					while (dtPylonEquipmentRowChangeEventHandler != dtPylonEquipmentRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler = this.dtPylonEquipmentRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler2;
					do
					{
						dtPylonEquipmentRowChangeEventHandler2 = dtPylonEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler)Delegate.Combine(dtPylonEquipmentRowChangeEventHandler2, value);
						dtPylonEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler>(ref this.dtPylonEquipmentRowChangeEventHandler_2, value2, dtPylonEquipmentRowChangeEventHandler2);
					}
					while (dtPylonEquipmentRowChangeEventHandler != dtPylonEquipmentRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler = this.dtPylonEquipmentRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler2;
					do
					{
						dtPylonEquipmentRowChangeEventHandler2 = dtPylonEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler)Delegate.Remove(dtPylonEquipmentRowChangeEventHandler2, value);
						dtPylonEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler>(ref this.dtPylonEquipmentRowChangeEventHandler_2, value2, dtPylonEquipmentRowChangeEventHandler2);
					}
					while (dtPylonEquipmentRowChangeEventHandler != dtPylonEquipmentRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler = this.dtPylonEquipmentRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler2;
					do
					{
						dtPylonEquipmentRowChangeEventHandler2 = dtPylonEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler)Delegate.Combine(dtPylonEquipmentRowChangeEventHandler2, value);
						dtPylonEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler>(ref this.dtPylonEquipmentRowChangeEventHandler_3, value2, dtPylonEquipmentRowChangeEventHandler2);
					}
					while (dtPylonEquipmentRowChangeEventHandler != dtPylonEquipmentRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler = this.dtPylonEquipmentRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler2;
					do
					{
						dtPylonEquipmentRowChangeEventHandler2 = dtPylonEquipmentRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler)Delegate.Remove(dtPylonEquipmentRowChangeEventHandler2, value);
						dtPylonEquipmentRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler>(ref this.dtPylonEquipmentRowChangeEventHandler_3, value2, dtPylonEquipmentRowChangeEventHandler2);
					}
					while (dtPylonEquipmentRowChangeEventHandler != dtPylonEquipmentRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtPylonEquipmentRow(DataSetReportAirLinePassport.dtPylonEquipmentRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtPylonEquipmentRow AdddtPylonEquipmentRow(string Name, string TypeEquipment, string Count, string PoleNum)
			{
				DataSetReportAirLinePassport.dtPylonEquipmentRow dtPylonEquipmentRow = (DataSetReportAirLinePassport.dtPylonEquipmentRow)base.NewRow();
				object[] itemArray = new object[]
				{
					Name,
					TypeEquipment,
					Count,
					PoleNum
				};
				dtPylonEquipmentRow.ItemArray = itemArray;
				base.Rows.Add(dtPylonEquipmentRow);
				return dtPylonEquipmentRow;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtPylonEquipmentDataTable dtPylonEquipmentDataTable = (DataSetReportAirLinePassport.dtPylonEquipmentDataTable)base.Clone();
				dtPylonEquipmentDataTable.method_0();
				return dtPylonEquipmentDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtPylonEquipmentDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["Name"];
				this.dataColumn_1 = base.Columns["TypeEquipment"];
				this.dataColumn_2 = base.Columns["Count"];
				this.dataColumn_3 = base.Columns["PoleNum"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("TypeEquipment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("Count", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("PoleNum", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtPylonEquipmentRow NewdtPylonEquipmentRow()
			{
				return (DataSetReportAirLinePassport.dtPylonEquipmentRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtPylonEquipmentRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtPylonEquipmentRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtPylonEquipmentRowChangeEventHandler_1 != null)
				{
					this.dtPylonEquipmentRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtPylonEquipmentRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtPylonEquipmentRowChangeEventHandler_0 != null)
				{
					this.dtPylonEquipmentRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtPylonEquipmentRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtPylonEquipmentRowChangeEventHandler_3 != null)
				{
					this.dtPylonEquipmentRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtPylonEquipmentRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtPylonEquipmentRowChangeEventHandler_2 != null)
				{
					this.dtPylonEquipmentRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtPylonEquipmentRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtPylonEquipmentRow(DataSetReportAirLinePassport.dtPylonEquipmentRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtPylonEquipmentDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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
			private DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtJointSuspensionDataTable : TypedTableBase<DataSetReportAirLinePassport.dtJointSuspensionRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtJointSuspensionDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtJointSuspension";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtJointSuspensionDataTable(DataTable table)
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
			protected dtJointSuspensionDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
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
			public DataColumn PoleNumColumn
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
			public DataColumn WireDistanceColumn
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtJointSuspensionRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtJointSuspensionRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler = this.dtJointSuspensionRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler2;
					do
					{
						dtJointSuspensionRowChangeEventHandler2 = dtJointSuspensionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler)Delegate.Combine(dtJointSuspensionRowChangeEventHandler2, value);
						dtJointSuspensionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler>(ref this.dtJointSuspensionRowChangeEventHandler_0, value2, dtJointSuspensionRowChangeEventHandler2);
					}
					while (dtJointSuspensionRowChangeEventHandler != dtJointSuspensionRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler = this.dtJointSuspensionRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler2;
					do
					{
						dtJointSuspensionRowChangeEventHandler2 = dtJointSuspensionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler)Delegate.Remove(dtJointSuspensionRowChangeEventHandler2, value);
						dtJointSuspensionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler>(ref this.dtJointSuspensionRowChangeEventHandler_0, value2, dtJointSuspensionRowChangeEventHandler2);
					}
					while (dtJointSuspensionRowChangeEventHandler != dtJointSuspensionRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler = this.gthaTgTxko1;
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler2;
					do
					{
						dtJointSuspensionRowChangeEventHandler2 = dtJointSuspensionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler)Delegate.Combine(dtJointSuspensionRowChangeEventHandler2, value);
						dtJointSuspensionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler>(ref this.gthaTgTxko1, value2, dtJointSuspensionRowChangeEventHandler2);
					}
					while (dtJointSuspensionRowChangeEventHandler != dtJointSuspensionRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler = this.gthaTgTxko1;
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler2;
					do
					{
						dtJointSuspensionRowChangeEventHandler2 = dtJointSuspensionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler)Delegate.Remove(dtJointSuspensionRowChangeEventHandler2, value);
						dtJointSuspensionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler>(ref this.gthaTgTxko1, value2, dtJointSuspensionRowChangeEventHandler2);
					}
					while (dtJointSuspensionRowChangeEventHandler != dtJointSuspensionRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler = this.dtJointSuspensionRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler2;
					do
					{
						dtJointSuspensionRowChangeEventHandler2 = dtJointSuspensionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler)Delegate.Combine(dtJointSuspensionRowChangeEventHandler2, value);
						dtJointSuspensionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler>(ref this.dtJointSuspensionRowChangeEventHandler_1, value2, dtJointSuspensionRowChangeEventHandler2);
					}
					while (dtJointSuspensionRowChangeEventHandler != dtJointSuspensionRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler = this.dtJointSuspensionRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler2;
					do
					{
						dtJointSuspensionRowChangeEventHandler2 = dtJointSuspensionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler)Delegate.Remove(dtJointSuspensionRowChangeEventHandler2, value);
						dtJointSuspensionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler>(ref this.dtJointSuspensionRowChangeEventHandler_1, value2, dtJointSuspensionRowChangeEventHandler2);
					}
					while (dtJointSuspensionRowChangeEventHandler != dtJointSuspensionRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler = this.dtJointSuspensionRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler2;
					do
					{
						dtJointSuspensionRowChangeEventHandler2 = dtJointSuspensionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler)Delegate.Combine(dtJointSuspensionRowChangeEventHandler2, value);
						dtJointSuspensionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler>(ref this.dtJointSuspensionRowChangeEventHandler_2, value2, dtJointSuspensionRowChangeEventHandler2);
					}
					while (dtJointSuspensionRowChangeEventHandler != dtJointSuspensionRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler = this.dtJointSuspensionRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler2;
					do
					{
						dtJointSuspensionRowChangeEventHandler2 = dtJointSuspensionRowChangeEventHandler;
						DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler)Delegate.Remove(dtJointSuspensionRowChangeEventHandler2, value);
						dtJointSuspensionRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler>(ref this.dtJointSuspensionRowChangeEventHandler_2, value2, dtJointSuspensionRowChangeEventHandler2);
					}
					while (dtJointSuspensionRowChangeEventHandler != dtJointSuspensionRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtJointSuspensionRow(DataSetReportAirLinePassport.dtJointSuspensionRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtJointSuspensionRow AdddtJointSuspensionRow(string Name, string string_0, string PoleNum, string string_1, string WireDistance)
			{
				DataSetReportAirLinePassport.dtJointSuspensionRow dtJointSuspensionRow = (DataSetReportAirLinePassport.dtJointSuspensionRow)base.NewRow();
				object[] itemArray = new object[]
				{
					Name,
					string_0,
					PoleNum,
					string_1,
					WireDistance
				};
				dtJointSuspensionRow.ItemArray = itemArray;
				base.Rows.Add(dtJointSuspensionRow);
				return dtJointSuspensionRow;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtJointSuspensionDataTable dtJointSuspensionDataTable = (DataSetReportAirLinePassport.dtJointSuspensionDataTable)base.Clone();
				dtJointSuspensionDataTable.method_0();
				return dtJointSuspensionDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtJointSuspensionDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["Name"];
				this.dataColumn_1 = base.Columns["Напряжение"];
				this.dataColumn_2 = base.Columns["PoleNum"];
				this.dataColumn_3 = base.Columns["МаркаКабеля"];
				this.dataColumn_4 = base.Columns["WireDistance"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Напряжение", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("PoleNum", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("МаркаКабеля", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("WireDistance", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtJointSuspensionRow NewdtJointSuspensionRow()
			{
				return (DataSetReportAirLinePassport.dtJointSuspensionRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtJointSuspensionRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtJointSuspensionRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.gthaTgTxko1 != null)
				{
					this.gthaTgTxko1(this, new DataSetReportAirLinePassport.dtJointSuspensionRowChangeEvent((DataSetReportAirLinePassport.dtJointSuspensionRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtJointSuspensionRowChangeEventHandler_0 != null)
				{
					this.dtJointSuspensionRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtJointSuspensionRowChangeEvent((DataSetReportAirLinePassport.dtJointSuspensionRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtJointSuspensionRowChangeEventHandler_2 != null)
				{
					this.dtJointSuspensionRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtJointSuspensionRowChangeEvent((DataSetReportAirLinePassport.dtJointSuspensionRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtJointSuspensionRowChangeEventHandler_1 != null)
				{
					this.dtJointSuspensionRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtJointSuspensionRowChangeEvent((DataSetReportAirLinePassport.dtJointSuspensionRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtJointSuspensionRow(DataSetReportAirLinePassport.dtJointSuspensionRow row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtJointSuspensionDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler gthaTgTxko1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChangeEventHandler_2;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tBranchDataTable : TypedTableBase<DataSetReportAirLinePassport.tBranchRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tBranchDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "tBranch";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tBranchDataTable(DataTable table)
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
			protected tBranchDataTable(SerializationInfo info, StreamingContext context)
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
			public DataColumn idAirLineColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idPoleColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idObjColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PoleNameColumn
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObjNameColumn
			{
				get
				{
					return this.dataColumn_5;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn cableTypeColumn
			{
				get
				{
					return this.dataColumn_6;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn cableLengthColumn
			{
				get
				{
					return this.dataColumn_7;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CountColumn
			{
				get
				{
					return this.dataColumn_8;
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
			public DataSetReportAirLinePassport.tBranchRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.tBranchRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler = this.tBranchRowChangeEventHandler_0;
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler2;
					do
					{
						tBranchRowChangeEventHandler2 = tBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.tBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tBranchRowChangeEventHandler)Delegate.Combine(tBranchRowChangeEventHandler2, value);
						tBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tBranchRowChangeEventHandler>(ref this.tBranchRowChangeEventHandler_0, value2, tBranchRowChangeEventHandler2);
					}
					while (tBranchRowChangeEventHandler != tBranchRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler = this.tBranchRowChangeEventHandler_0;
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler2;
					do
					{
						tBranchRowChangeEventHandler2 = tBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.tBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tBranchRowChangeEventHandler)Delegate.Remove(tBranchRowChangeEventHandler2, value);
						tBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tBranchRowChangeEventHandler>(ref this.tBranchRowChangeEventHandler_0, value2, tBranchRowChangeEventHandler2);
					}
					while (tBranchRowChangeEventHandler != tBranchRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler = this.tBranchRowChangeEventHandler_1;
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler2;
					do
					{
						tBranchRowChangeEventHandler2 = tBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.tBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tBranchRowChangeEventHandler)Delegate.Combine(tBranchRowChangeEventHandler2, value);
						tBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tBranchRowChangeEventHandler>(ref this.tBranchRowChangeEventHandler_1, value2, tBranchRowChangeEventHandler2);
					}
					while (tBranchRowChangeEventHandler != tBranchRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler = this.tBranchRowChangeEventHandler_1;
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler2;
					do
					{
						tBranchRowChangeEventHandler2 = tBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.tBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tBranchRowChangeEventHandler)Delegate.Remove(tBranchRowChangeEventHandler2, value);
						tBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tBranchRowChangeEventHandler>(ref this.tBranchRowChangeEventHandler_1, value2, tBranchRowChangeEventHandler2);
					}
					while (tBranchRowChangeEventHandler != tBranchRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler = this.tBranchRowChangeEventHandler_2;
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler2;
					do
					{
						tBranchRowChangeEventHandler2 = tBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.tBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tBranchRowChangeEventHandler)Delegate.Combine(tBranchRowChangeEventHandler2, value);
						tBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tBranchRowChangeEventHandler>(ref this.tBranchRowChangeEventHandler_2, value2, tBranchRowChangeEventHandler2);
					}
					while (tBranchRowChangeEventHandler != tBranchRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler = this.tBranchRowChangeEventHandler_2;
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler2;
					do
					{
						tBranchRowChangeEventHandler2 = tBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.tBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tBranchRowChangeEventHandler)Delegate.Remove(tBranchRowChangeEventHandler2, value);
						tBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tBranchRowChangeEventHandler>(ref this.tBranchRowChangeEventHandler_2, value2, tBranchRowChangeEventHandler2);
					}
					while (tBranchRowChangeEventHandler != tBranchRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler = this.tBranchRowChangeEventHandler_3;
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler2;
					do
					{
						tBranchRowChangeEventHandler2 = tBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.tBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tBranchRowChangeEventHandler)Delegate.Combine(tBranchRowChangeEventHandler2, value);
						tBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tBranchRowChangeEventHandler>(ref this.tBranchRowChangeEventHandler_3, value2, tBranchRowChangeEventHandler2);
					}
					while (tBranchRowChangeEventHandler != tBranchRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler = this.tBranchRowChangeEventHandler_3;
					DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler2;
					do
					{
						tBranchRowChangeEventHandler2 = tBranchRowChangeEventHandler;
						DataSetReportAirLinePassport.tBranchRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tBranchRowChangeEventHandler)Delegate.Remove(tBranchRowChangeEventHandler2, value);
						tBranchRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tBranchRowChangeEventHandler>(ref this.tBranchRowChangeEventHandler_3, value2, tBranchRowChangeEventHandler2);
					}
					while (tBranchRowChangeEventHandler != tBranchRowChangeEventHandler2);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddtBranchRow(DataSetReportAirLinePassport.tBranchRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.tBranchRow AddtBranchRow(int id, int idAirLine, int idPole, int idObj, string PoleName, string ObjName, string cableType, string cableLength, int Count)
			{
				DataSetReportAirLinePassport.tBranchRow tBranchRow = (DataSetReportAirLinePassport.tBranchRow)base.NewRow();
				object[] itemArray = new object[]
				{
					id,
					idAirLine,
					idPole,
					idObj,
					PoleName,
					ObjName,
					cableType,
					cableLength,
					Count
				};
				tBranchRow.ItemArray = itemArray;
				base.Rows.Add(tBranchRow);
				return tBranchRow;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.tBranchDataTable tBranchDataTable = (DataSetReportAirLinePassport.tBranchDataTable)base.Clone();
				tBranchDataTable.method_0();
				return tBranchDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.tBranchDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["idAirLine"];
				this.dataColumn_2 = base.Columns["idPole"];
				this.dataColumn_3 = base.Columns["idObj"];
				this.dataColumn_4 = base.Columns["PoleName"];
				this.dataColumn_5 = base.Columns["ObjName"];
				this.dataColumn_6 = base.Columns["cableType"];
				this.dataColumn_7 = base.Columns["cableLength"];
				this.dataColumn_8 = base.Columns["Count"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("idAirLine", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("idPole", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("idObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("PoleName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("ObjName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("cableType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("cableLength", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("Count", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.tBranchRow NewtBranchRow()
			{
				return (DataSetReportAirLinePassport.tBranchRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.tBranchRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.tBranchRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tBranchRowChangeEventHandler_1 != null)
				{
					this.tBranchRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.tBranchRowChangeEvent((DataSetReportAirLinePassport.tBranchRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tBranchRowChangeEventHandler_0 != null)
				{
					this.tBranchRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.tBranchRowChangeEvent((DataSetReportAirLinePassport.tBranchRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tBranchRowChangeEventHandler_3 != null)
				{
					this.tBranchRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.tBranchRowChangeEvent((DataSetReportAirLinePassport.tBranchRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tBranchRowChangeEventHandler_2 != null)
				{
					this.tBranchRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.tBranchRowChangeEvent((DataSetReportAirLinePassport.tBranchRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovetBranchRow(DataSetReportAirLinePassport.tBranchRow row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tBranchDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			[CompilerGenerated]
			private DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtPylonsDataTable : TypedTableBase<DataSetReportAirLinePassport.dtPylonsRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtPylonsDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtPylons";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtPylonsDataTable(DataTable table)
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
			protected dtPylonsDataTable(SerializationInfo info, StreamingContext context)
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
			public DataColumn NameColumn
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_5
			{
				get
				{
					return this.dataColumn_7;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_6
			{
				get
				{
					return this.dataColumn_8;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_7
			{
				get
				{
					return this.dataColumn_9;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SpanLengthColumn
			{
				get
				{
					return this.dataColumn_10;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CableMakeUpColumn
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
			public DataColumn EquipmentListColumn
			{
				get
				{
					return this.dataColumn_14;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn typeNameColumn
			{
				get
				{
					return this.dataColumn_15;
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
			public DataSetReportAirLinePassport.dtPylonsRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtPylonsRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler = this.dtPylonsRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler2;
					do
					{
						dtPylonsRowChangeEventHandler2 = dtPylonsRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler)Delegate.Combine(dtPylonsRowChangeEventHandler2, value);
						dtPylonsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler>(ref this.dtPylonsRowChangeEventHandler_0, value2, dtPylonsRowChangeEventHandler2);
					}
					while (dtPylonsRowChangeEventHandler != dtPylonsRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler = this.dtPylonsRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler2;
					do
					{
						dtPylonsRowChangeEventHandler2 = dtPylonsRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler)Delegate.Remove(dtPylonsRowChangeEventHandler2, value);
						dtPylonsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler>(ref this.dtPylonsRowChangeEventHandler_0, value2, dtPylonsRowChangeEventHandler2);
					}
					while (dtPylonsRowChangeEventHandler != dtPylonsRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler = this.dtPylonsRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler2;
					do
					{
						dtPylonsRowChangeEventHandler2 = dtPylonsRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler)Delegate.Combine(dtPylonsRowChangeEventHandler2, value);
						dtPylonsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler>(ref this.dtPylonsRowChangeEventHandler_1, value2, dtPylonsRowChangeEventHandler2);
					}
					while (dtPylonsRowChangeEventHandler != dtPylonsRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler = this.dtPylonsRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler2;
					do
					{
						dtPylonsRowChangeEventHandler2 = dtPylonsRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler)Delegate.Remove(dtPylonsRowChangeEventHandler2, value);
						dtPylonsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler>(ref this.dtPylonsRowChangeEventHandler_1, value2, dtPylonsRowChangeEventHandler2);
					}
					while (dtPylonsRowChangeEventHandler != dtPylonsRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler = this.dtPylonsRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler2;
					do
					{
						dtPylonsRowChangeEventHandler2 = dtPylonsRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler)Delegate.Combine(dtPylonsRowChangeEventHandler2, value);
						dtPylonsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler>(ref this.dtPylonsRowChangeEventHandler_2, value2, dtPylonsRowChangeEventHandler2);
					}
					while (dtPylonsRowChangeEventHandler != dtPylonsRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler = this.dtPylonsRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler2;
					do
					{
						dtPylonsRowChangeEventHandler2 = dtPylonsRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler)Delegate.Remove(dtPylonsRowChangeEventHandler2, value);
						dtPylonsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler>(ref this.dtPylonsRowChangeEventHandler_2, value2, dtPylonsRowChangeEventHandler2);
					}
					while (dtPylonsRowChangeEventHandler != dtPylonsRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler = this.dtPylonsRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler2;
					do
					{
						dtPylonsRowChangeEventHandler2 = dtPylonsRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler)Delegate.Combine(dtPylonsRowChangeEventHandler2, value);
						dtPylonsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler>(ref this.dtPylonsRowChangeEventHandler_3, value2, dtPylonsRowChangeEventHandler2);
					}
					while (dtPylonsRowChangeEventHandler != dtPylonsRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler = this.dtPylonsRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler2;
					do
					{
						dtPylonsRowChangeEventHandler2 = dtPylonsRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler)Delegate.Remove(dtPylonsRowChangeEventHandler2, value);
						dtPylonsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler>(ref this.dtPylonsRowChangeEventHandler_3, value2, dtPylonsRowChangeEventHandler2);
					}
					while (dtPylonsRowChangeEventHandler != dtPylonsRowChangeEventHandler2);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtPylonsRow(DataSetReportAirLinePassport.dtPylonsRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtPylonsRow AdddtPylonsRow(int id, string Name, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, decimal SpanLength, string CableMakeUp, string string_8, string string_9, string EquipmentList, string typeName)
			{
				DataSetReportAirLinePassport.dtPylonsRow dtPylonsRow = (DataSetReportAirLinePassport.dtPylonsRow)base.NewRow();
				object[] itemArray = new object[]
				{
					id,
					Name,
					string_0,
					string_1,
					string_2,
					string_3,
					string_4,
					string_5,
					string_6,
					string_7,
					SpanLength,
					CableMakeUp,
					string_8,
					string_9,
					EquipmentList,
					typeName
				};
				dtPylonsRow.ItemArray = itemArray;
				base.Rows.Add(dtPylonsRow);
				return dtPylonsRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtPylonsDataTable dtPylonsDataTable = (DataSetReportAirLinePassport.dtPylonsDataTable)base.Clone();
				dtPylonsDataTable.method_0();
				return dtPylonsDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtPylonsDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["Name"];
				this.dataColumn_2 = base.Columns["Тип"];
				this.dataColumn_3 = base.Columns["Принадлежность"];
				this.dataColumn_4 = base.Columns["ГодУстановки"];
				this.dataColumn_5 = base.Columns["Стойка"];
				this.dataColumn_6 = base.Columns["Подкос"];
				this.dataColumn_7 = base.Columns["Приставка"];
				this.dataColumn_8 = base.Columns["ТипИзолятора"];
				this.dataColumn_9 = base.Columns["Количество"];
				this.dataColumn_10 = base.Columns["SpanLength"];
				this.dataColumn_11 = base.Columns["CableMakeUp"];
				this.dataColumn_12 = base.Columns["НаличиеКонтура"];
				this.dataColumn_13 = base.Columns["Сопротивление"];
				this.dataColumn_14 = base.Columns["EquipmentList"];
				this.dataColumn_15 = base.Columns["typeName"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("Тип", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("Принадлежность", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("ГодУстановки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Стойка", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("Подкос", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("Приставка", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("ТипИзолятора", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("Количество", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("SpanLength", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("CableMakeUp", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("НаличиеКонтура", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
				this.dataColumn_13 = new DataColumn("Сопротивление", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_13);
				this.dataColumn_14 = new DataColumn("EquipmentList", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_14);
				this.dataColumn_15 = new DataColumn("typeName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_15);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtPylonsRow NewdtPylonsRow()
			{
				return (DataSetReportAirLinePassport.dtPylonsRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtPylonsRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtPylonsRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtPylonsRowChangeEventHandler_1 != null)
				{
					this.dtPylonsRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtPylonsRowChangeEvent((DataSetReportAirLinePassport.dtPylonsRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtPylonsRowChangeEventHandler_0 != null)
				{
					this.dtPylonsRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtPylonsRowChangeEvent((DataSetReportAirLinePassport.dtPylonsRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtPylonsRowChangeEventHandler_3 != null)
				{
					this.dtPylonsRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtPylonsRowChangeEvent((DataSetReportAirLinePassport.dtPylonsRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtPylonsRowChangeEventHandler_2 != null)
				{
					this.dtPylonsRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtPylonsRowChangeEvent((DataSetReportAirLinePassport.dtPylonsRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtPylonsRow(DataSetReportAirLinePassport.dtPylonsRow row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtPylonsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtRoadDataTable : TypedTableBase<DataSetReportAirLinePassport.dtRoadRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtRoadDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtRoad";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtRoadDataTable(DataTable table)
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
			protected dtRoadDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idObjListColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idRoadTypeColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn RoadNameColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PylonNumbersColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CharacteristicColumn
			{
				get
				{
					return this.dataColumn_4;
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
			public DataSetReportAirLinePassport.dtRoadRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtRoadRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler = this.dtRoadRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler2;
					do
					{
						dtRoadRowChangeEventHandler2 = dtRoadRowChangeEventHandler;
						DataSetReportAirLinePassport.dtRoadRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtRoadRowChangeEventHandler)Delegate.Combine(dtRoadRowChangeEventHandler2, value);
						dtRoadRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtRoadRowChangeEventHandler>(ref this.dtRoadRowChangeEventHandler_0, value2, dtRoadRowChangeEventHandler2);
					}
					while (dtRoadRowChangeEventHandler != dtRoadRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler = this.dtRoadRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler2;
					do
					{
						dtRoadRowChangeEventHandler2 = dtRoadRowChangeEventHandler;
						DataSetReportAirLinePassport.dtRoadRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtRoadRowChangeEventHandler)Delegate.Remove(dtRoadRowChangeEventHandler2, value);
						dtRoadRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtRoadRowChangeEventHandler>(ref this.dtRoadRowChangeEventHandler_0, value2, dtRoadRowChangeEventHandler2);
					}
					while (dtRoadRowChangeEventHandler != dtRoadRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler = this.dtRoadRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler2;
					do
					{
						dtRoadRowChangeEventHandler2 = dtRoadRowChangeEventHandler;
						DataSetReportAirLinePassport.dtRoadRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtRoadRowChangeEventHandler)Delegate.Combine(dtRoadRowChangeEventHandler2, value);
						dtRoadRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtRoadRowChangeEventHandler>(ref this.dtRoadRowChangeEventHandler_1, value2, dtRoadRowChangeEventHandler2);
					}
					while (dtRoadRowChangeEventHandler != dtRoadRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler = this.dtRoadRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler2;
					do
					{
						dtRoadRowChangeEventHandler2 = dtRoadRowChangeEventHandler;
						DataSetReportAirLinePassport.dtRoadRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtRoadRowChangeEventHandler)Delegate.Remove(dtRoadRowChangeEventHandler2, value);
						dtRoadRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtRoadRowChangeEventHandler>(ref this.dtRoadRowChangeEventHandler_1, value2, dtRoadRowChangeEventHandler2);
					}
					while (dtRoadRowChangeEventHandler != dtRoadRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler = this.dtRoadRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler2;
					do
					{
						dtRoadRowChangeEventHandler2 = dtRoadRowChangeEventHandler;
						DataSetReportAirLinePassport.dtRoadRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtRoadRowChangeEventHandler)Delegate.Combine(dtRoadRowChangeEventHandler2, value);
						dtRoadRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtRoadRowChangeEventHandler>(ref this.dtRoadRowChangeEventHandler_2, value2, dtRoadRowChangeEventHandler2);
					}
					while (dtRoadRowChangeEventHandler != dtRoadRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler = this.dtRoadRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler2;
					do
					{
						dtRoadRowChangeEventHandler2 = dtRoadRowChangeEventHandler;
						DataSetReportAirLinePassport.dtRoadRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtRoadRowChangeEventHandler)Delegate.Remove(dtRoadRowChangeEventHandler2, value);
						dtRoadRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtRoadRowChangeEventHandler>(ref this.dtRoadRowChangeEventHandler_2, value2, dtRoadRowChangeEventHandler2);
					}
					while (dtRoadRowChangeEventHandler != dtRoadRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler = this.dtRoadRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler2;
					do
					{
						dtRoadRowChangeEventHandler2 = dtRoadRowChangeEventHandler;
						DataSetReportAirLinePassport.dtRoadRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtRoadRowChangeEventHandler)Delegate.Combine(dtRoadRowChangeEventHandler2, value);
						dtRoadRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtRoadRowChangeEventHandler>(ref this.dtRoadRowChangeEventHandler_3, value2, dtRoadRowChangeEventHandler2);
					}
					while (dtRoadRowChangeEventHandler != dtRoadRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler = this.dtRoadRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler2;
					do
					{
						dtRoadRowChangeEventHandler2 = dtRoadRowChangeEventHandler;
						DataSetReportAirLinePassport.dtRoadRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtRoadRowChangeEventHandler)Delegate.Remove(dtRoadRowChangeEventHandler2, value);
						dtRoadRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtRoadRowChangeEventHandler>(ref this.dtRoadRowChangeEventHandler_3, value2, dtRoadRowChangeEventHandler2);
					}
					while (dtRoadRowChangeEventHandler != dtRoadRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtRoadRow(DataSetReportAirLinePassport.dtRoadRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtRoadRow AdddtRoadRow(int idObjList, int idRoadType, string RoadName, string PylonNumbers, string Characteristic)
			{
				DataSetReportAirLinePassport.dtRoadRow dtRoadRow = (DataSetReportAirLinePassport.dtRoadRow)base.NewRow();
				object[] itemArray = new object[]
				{
					idObjList,
					idRoadType,
					RoadName,
					PylonNumbers,
					Characteristic
				};
				dtRoadRow.ItemArray = itemArray;
				base.Rows.Add(dtRoadRow);
				return dtRoadRow;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtRoadDataTable dtRoadDataTable = (DataSetReportAirLinePassport.dtRoadDataTable)base.Clone();
				dtRoadDataTable.method_0();
				return dtRoadDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtRoadDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["idObjList"];
				this.dataColumn_1 = base.Columns["idRoadType"];
				this.dataColumn_2 = base.Columns["RoadName"];
				this.dataColumn_3 = base.Columns["PylonNumbers"];
				this.dataColumn_4 = base.Columns["Characteristic"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("idRoadType", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("RoadName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("PylonNumbers", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("Characteristic", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtRoadRow NewdtRoadRow()
			{
				return (DataSetReportAirLinePassport.dtRoadRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtRoadRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtRoadRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtRoadRowChangeEventHandler_1 != null)
				{
					this.dtRoadRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtRoadRowChangeEvent((DataSetReportAirLinePassport.dtRoadRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtRoadRowChangeEventHandler_0 != null)
				{
					this.dtRoadRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtRoadRowChangeEvent((DataSetReportAirLinePassport.dtRoadRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtRoadRowChangeEventHandler_3 != null)
				{
					this.dtRoadRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtRoadRowChangeEvent((DataSetReportAirLinePassport.dtRoadRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtRoadRowChangeEventHandler_2 != null)
				{
					this.dtRoadRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtRoadRowChangeEvent((DataSetReportAirLinePassport.dtRoadRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtRoadRow(DataSetReportAirLinePassport.dtRoadRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtRoadDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vDocAirLineRepairDataTable : TypedTableBase<DataSetReportAirLinePassport.vDocAirLineRepairRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public vDocAirLineRepairDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "vDocAirLineRepair";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal vDocAirLineRepairDataTable(DataTable table)
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
			protected vDocAirLineRepairDataTable(SerializationInfo info, StreamingContext context)
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParentIdColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn numberDocColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dateDocColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn typeDocColumn
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idReasonColumn
			{
				get
				{
					return this.dataColumn_5;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn reasonColumn
			{
				get
				{
					return this.dataColumn_6;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn FromColumn
			{
				get
				{
					return this.dataColumn_7;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ToColumn
			{
				get
				{
					return this.dataColumn_8;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dateStartUpColumn
			{
				get
				{
					return this.dataColumn_9;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn commentColumn
			{
				get
				{
					return this.dataColumn_10;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn typeDocNameColumn
			{
				get
				{
					return this.dataColumn_11;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idObjListColumn
			{
				get
				{
					return this.dataColumn_12;
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
			public DataSetReportAirLinePassport.vDocAirLineRepairRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.vDocAirLineRepairRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler = this.vDocAirLineRepairRowChangeEventHandler_0;
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler2;
					do
					{
						vDocAirLineRepairRowChangeEventHandler2 = vDocAirLineRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler)Delegate.Combine(vDocAirLineRepairRowChangeEventHandler2, value);
						vDocAirLineRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler>(ref this.vDocAirLineRepairRowChangeEventHandler_0, value2, vDocAirLineRepairRowChangeEventHandler2);
					}
					while (vDocAirLineRepairRowChangeEventHandler != vDocAirLineRepairRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler = this.vDocAirLineRepairRowChangeEventHandler_0;
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler2;
					do
					{
						vDocAirLineRepairRowChangeEventHandler2 = vDocAirLineRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler)Delegate.Remove(vDocAirLineRepairRowChangeEventHandler2, value);
						vDocAirLineRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler>(ref this.vDocAirLineRepairRowChangeEventHandler_0, value2, vDocAirLineRepairRowChangeEventHandler2);
					}
					while (vDocAirLineRepairRowChangeEventHandler != vDocAirLineRepairRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler = this.vDocAirLineRepairRowChangeEventHandler_1;
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler2;
					do
					{
						vDocAirLineRepairRowChangeEventHandler2 = vDocAirLineRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler)Delegate.Combine(vDocAirLineRepairRowChangeEventHandler2, value);
						vDocAirLineRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler>(ref this.vDocAirLineRepairRowChangeEventHandler_1, value2, vDocAirLineRepairRowChangeEventHandler2);
					}
					while (vDocAirLineRepairRowChangeEventHandler != vDocAirLineRepairRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler = this.vDocAirLineRepairRowChangeEventHandler_1;
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler2;
					do
					{
						vDocAirLineRepairRowChangeEventHandler2 = vDocAirLineRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler)Delegate.Remove(vDocAirLineRepairRowChangeEventHandler2, value);
						vDocAirLineRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler>(ref this.vDocAirLineRepairRowChangeEventHandler_1, value2, vDocAirLineRepairRowChangeEventHandler2);
					}
					while (vDocAirLineRepairRowChangeEventHandler != vDocAirLineRepairRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler = this.vDocAirLineRepairRowChangeEventHandler_2;
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler2;
					do
					{
						vDocAirLineRepairRowChangeEventHandler2 = vDocAirLineRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler)Delegate.Combine(vDocAirLineRepairRowChangeEventHandler2, value);
						vDocAirLineRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler>(ref this.vDocAirLineRepairRowChangeEventHandler_2, value2, vDocAirLineRepairRowChangeEventHandler2);
					}
					while (vDocAirLineRepairRowChangeEventHandler != vDocAirLineRepairRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler = this.vDocAirLineRepairRowChangeEventHandler_2;
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler2;
					do
					{
						vDocAirLineRepairRowChangeEventHandler2 = vDocAirLineRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler)Delegate.Remove(vDocAirLineRepairRowChangeEventHandler2, value);
						vDocAirLineRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler>(ref this.vDocAirLineRepairRowChangeEventHandler_2, value2, vDocAirLineRepairRowChangeEventHandler2);
					}
					while (vDocAirLineRepairRowChangeEventHandler != vDocAirLineRepairRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler = this.vDocAirLineRepairRowChangeEventHandler_3;
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler2;
					do
					{
						vDocAirLineRepairRowChangeEventHandler2 = vDocAirLineRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler)Delegate.Combine(vDocAirLineRepairRowChangeEventHandler2, value);
						vDocAirLineRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler>(ref this.vDocAirLineRepairRowChangeEventHandler_3, value2, vDocAirLineRepairRowChangeEventHandler2);
					}
					while (vDocAirLineRepairRowChangeEventHandler != vDocAirLineRepairRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler = this.vDocAirLineRepairRowChangeEventHandler_3;
					DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler2;
					do
					{
						vDocAirLineRepairRowChangeEventHandler2 = vDocAirLineRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler)Delegate.Remove(vDocAirLineRepairRowChangeEventHandler2, value);
						vDocAirLineRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler>(ref this.vDocAirLineRepairRowChangeEventHandler_3, value2, vDocAirLineRepairRowChangeEventHandler2);
					}
					while (vDocAirLineRepairRowChangeEventHandler != vDocAirLineRepairRowChangeEventHandler2);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddvDocAirLineRepairRow(DataSetReportAirLinePassport.vDocAirLineRepairRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.vDocAirLineRepairRow AddvDocAirLineRepairRow(int id, int ParentId, string numberDoc, DateTime dateDoc, int typeDoc, int idReason, string reason, string From, string To, DateTime dateStartUp, string comment, string typeDocName, int idObjList)
			{
				DataSetReportAirLinePassport.vDocAirLineRepairRow vDocAirLineRepairRow = (DataSetReportAirLinePassport.vDocAirLineRepairRow)base.NewRow();
				object[] itemArray = new object[]
				{
					id,
					ParentId,
					numberDoc,
					dateDoc,
					typeDoc,
					idReason,
					reason,
					From,
					To,
					dateStartUp,
					comment,
					typeDocName,
					idObjList
				};
				vDocAirLineRepairRow.ItemArray = itemArray;
				base.Rows.Add(vDocAirLineRepairRow);
				return vDocAirLineRepairRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.vDocAirLineRepairDataTable vDocAirLineRepairDataTable = (DataSetReportAirLinePassport.vDocAirLineRepairDataTable)base.Clone();
				vDocAirLineRepairDataTable.method_0();
				return vDocAirLineRepairDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.vDocAirLineRepairDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["ParentId"];
				this.dataColumn_2 = base.Columns["numberDoc"];
				this.dataColumn_3 = base.Columns["dateDoc"];
				this.dataColumn_4 = base.Columns["typeDoc"];
				this.dataColumn_5 = base.Columns["idReason"];
				this.dataColumn_6 = base.Columns["reason"];
				this.dataColumn_7 = base.Columns["From"];
				this.dataColumn_8 = base.Columns["To"];
				this.dataColumn_9 = base.Columns["dateStartUp"];
				this.dataColumn_10 = base.Columns["comment"];
				this.dataColumn_11 = base.Columns["typeDocName"];
				this.dataColumn_12 = base.Columns["idObjList"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("ParentId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("numberDoc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("dateDoc", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("typeDoc", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("idReason", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("reason", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("From", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("To", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("dateStartUp", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("comment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("typeDocName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.vDocAirLineRepairRow NewvDocAirLineRepairRow()
			{
				return (DataSetReportAirLinePassport.vDocAirLineRepairRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.vDocAirLineRepairRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.vDocAirLineRepairRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.vDocAirLineRepairRowChangeEventHandler_1 != null)
				{
					this.vDocAirLineRepairRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEvent((DataSetReportAirLinePassport.vDocAirLineRepairRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.vDocAirLineRepairRowChangeEventHandler_0 != null)
				{
					this.vDocAirLineRepairRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEvent((DataSetReportAirLinePassport.vDocAirLineRepairRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.vDocAirLineRepairRowChangeEventHandler_3 != null)
				{
					this.vDocAirLineRepairRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEvent((DataSetReportAirLinePassport.vDocAirLineRepairRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.vDocAirLineRepairRowChangeEventHandler_2 != null)
				{
					this.vDocAirLineRepairRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEvent((DataSetReportAirLinePassport.vDocAirLineRepairRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovevDocAirLineRepairRow(DataSetReportAirLinePassport.vDocAirLineRepairRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vDocAirLineRepairDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			[CompilerGenerated]
			private DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.vDocAirLineRepairRowChangeEventHandler vDocAirLineRepairRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vDocPylonEquipRepairDataTable : TypedTableBase<DataSetReportAirLinePassport.vDocPylonEquipRepairRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public vDocPylonEquipRepairDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "vDocPylonEquipRepair";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal vDocPylonEquipRepairDataTable(DataTable table)
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
			protected vDocPylonEquipRepairDataTable(SerializationInfo info, StreamingContext context)
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParentIdColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn numberDocColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn dateDocColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn typeDocColumn
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn typeDocNameColumn
			{
				get
				{
					return this.dataColumn_5;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idTypeWorkColumn
			{
				get
				{
					return this.dataColumn_6;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idReasonColumn
			{
				get
				{
					return this.dataColumn_7;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idPylonColumn
			{
				get
				{
					return this.dataColumn_8;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idEquipmentColumn
			{
				get
				{
					return this.dataColumn_9;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn typeWorkColumn
			{
				get
				{
					return this.dataColumn_10;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn reasonColumn
			{
				get
				{
					return this.dataColumn_11;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn pylonColumn
			{
				get
				{
					return this.dataColumn_12;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn equipmentColumn
			{
				get
				{
					return this.dataColumn_13;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn commentColumn
			{
				get
				{
					return this.dataColumn_14;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idObjListColumn
			{
				get
				{
					return this.dataColumn_15;
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
			public DataSetReportAirLinePassport.vDocPylonEquipRepairRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.vDocPylonEquipRepairRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler = this.vDocPylonEquipRepairRowChangeEventHandler_0;
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler2;
					do
					{
						vDocPylonEquipRepairRowChangeEventHandler2 = vDocPylonEquipRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler)Delegate.Combine(vDocPylonEquipRepairRowChangeEventHandler2, value);
						vDocPylonEquipRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler>(ref this.vDocPylonEquipRepairRowChangeEventHandler_0, value2, vDocPylonEquipRepairRowChangeEventHandler2);
					}
					while (vDocPylonEquipRepairRowChangeEventHandler != vDocPylonEquipRepairRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler = this.vDocPylonEquipRepairRowChangeEventHandler_0;
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler2;
					do
					{
						vDocPylonEquipRepairRowChangeEventHandler2 = vDocPylonEquipRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler)Delegate.Remove(vDocPylonEquipRepairRowChangeEventHandler2, value);
						vDocPylonEquipRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler>(ref this.vDocPylonEquipRepairRowChangeEventHandler_0, value2, vDocPylonEquipRepairRowChangeEventHandler2);
					}
					while (vDocPylonEquipRepairRowChangeEventHandler != vDocPylonEquipRepairRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler = this.vDocPylonEquipRepairRowChangeEventHandler_1;
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler2;
					do
					{
						vDocPylonEquipRepairRowChangeEventHandler2 = vDocPylonEquipRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler)Delegate.Combine(vDocPylonEquipRepairRowChangeEventHandler2, value);
						vDocPylonEquipRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler>(ref this.vDocPylonEquipRepairRowChangeEventHandler_1, value2, vDocPylonEquipRepairRowChangeEventHandler2);
					}
					while (vDocPylonEquipRepairRowChangeEventHandler != vDocPylonEquipRepairRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler = this.vDocPylonEquipRepairRowChangeEventHandler_1;
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler2;
					do
					{
						vDocPylonEquipRepairRowChangeEventHandler2 = vDocPylonEquipRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler)Delegate.Remove(vDocPylonEquipRepairRowChangeEventHandler2, value);
						vDocPylonEquipRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler>(ref this.vDocPylonEquipRepairRowChangeEventHandler_1, value2, vDocPylonEquipRepairRowChangeEventHandler2);
					}
					while (vDocPylonEquipRepairRowChangeEventHandler != vDocPylonEquipRepairRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler = this.vDocPylonEquipRepairRowChangeEventHandler_2;
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler2;
					do
					{
						vDocPylonEquipRepairRowChangeEventHandler2 = vDocPylonEquipRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler)Delegate.Combine(vDocPylonEquipRepairRowChangeEventHandler2, value);
						vDocPylonEquipRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler>(ref this.vDocPylonEquipRepairRowChangeEventHandler_2, value2, vDocPylonEquipRepairRowChangeEventHandler2);
					}
					while (vDocPylonEquipRepairRowChangeEventHandler != vDocPylonEquipRepairRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler = this.vDocPylonEquipRepairRowChangeEventHandler_2;
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler2;
					do
					{
						vDocPylonEquipRepairRowChangeEventHandler2 = vDocPylonEquipRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler)Delegate.Remove(vDocPylonEquipRepairRowChangeEventHandler2, value);
						vDocPylonEquipRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler>(ref this.vDocPylonEquipRepairRowChangeEventHandler_2, value2, vDocPylonEquipRepairRowChangeEventHandler2);
					}
					while (vDocPylonEquipRepairRowChangeEventHandler != vDocPylonEquipRepairRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler = this.vDocPylonEquipRepairRowChangeEventHandler_3;
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler2;
					do
					{
						vDocPylonEquipRepairRowChangeEventHandler2 = vDocPylonEquipRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler)Delegate.Combine(vDocPylonEquipRepairRowChangeEventHandler2, value);
						vDocPylonEquipRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler>(ref this.vDocPylonEquipRepairRowChangeEventHandler_3, value2, vDocPylonEquipRepairRowChangeEventHandler2);
					}
					while (vDocPylonEquipRepairRowChangeEventHandler != vDocPylonEquipRepairRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler = this.vDocPylonEquipRepairRowChangeEventHandler_3;
					DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler2;
					do
					{
						vDocPylonEquipRepairRowChangeEventHandler2 = vDocPylonEquipRepairRowChangeEventHandler;
						DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler value2 = (DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler)Delegate.Remove(vDocPylonEquipRepairRowChangeEventHandler2, value);
						vDocPylonEquipRepairRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler>(ref this.vDocPylonEquipRepairRowChangeEventHandler_3, value2, vDocPylonEquipRepairRowChangeEventHandler2);
					}
					while (vDocPylonEquipRepairRowChangeEventHandler != vDocPylonEquipRepairRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddvDocPylonEquipRepairRow(DataSetReportAirLinePassport.vDocPylonEquipRepairRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.vDocPylonEquipRepairRow AddvDocPylonEquipRepairRow(int id, int ParentId, string numberDoc, DateTime dateDoc, int typeDoc, string typeDocName, int idTypeWork, int idReason, int idPylon, int idEquipment, string typeWork, string reason, string pylon, string equipment, string comment, int idObjList)
			{
				DataSetReportAirLinePassport.vDocPylonEquipRepairRow vDocPylonEquipRepairRow = (DataSetReportAirLinePassport.vDocPylonEquipRepairRow)base.NewRow();
				object[] itemArray = new object[]
				{
					id,
					ParentId,
					numberDoc,
					dateDoc,
					typeDoc,
					typeDocName,
					idTypeWork,
					idReason,
					idPylon,
					idEquipment,
					typeWork,
					reason,
					pylon,
					equipment,
					comment,
					idObjList
				};
				vDocPylonEquipRepairRow.ItemArray = itemArray;
				base.Rows.Add(vDocPylonEquipRepairRow);
				return vDocPylonEquipRepairRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.vDocPylonEquipRepairDataTable vDocPylonEquipRepairDataTable = (DataSetReportAirLinePassport.vDocPylonEquipRepairDataTable)base.Clone();
				vDocPylonEquipRepairDataTable.method_0();
				return vDocPylonEquipRepairDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.vDocPylonEquipRepairDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["ParentId"];
				this.dataColumn_2 = base.Columns["numberDoc"];
				this.dataColumn_3 = base.Columns["dateDoc"];
				this.dataColumn_4 = base.Columns["typeDoc"];
				this.dataColumn_5 = base.Columns["typeDocName"];
				this.dataColumn_6 = base.Columns["idTypeWork"];
				this.dataColumn_7 = base.Columns["idReason"];
				this.dataColumn_8 = base.Columns["idPylon"];
				this.dataColumn_9 = base.Columns["idEquipment"];
				this.dataColumn_10 = base.Columns["typeWork"];
				this.dataColumn_11 = base.Columns["reason"];
				this.dataColumn_12 = base.Columns["pylon"];
				this.dataColumn_13 = base.Columns["equipment"];
				this.dataColumn_14 = base.Columns["comment"];
				this.dataColumn_15 = base.Columns["idObjList"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("ParentId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("numberDoc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("dateDoc", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("typeDoc", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("typeDocName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("idTypeWork", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("idReason", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("idPylon", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("idEquipment", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("typeWork", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("reason", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("pylon", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
				this.dataColumn_13 = new DataColumn("equipment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_13);
				this.dataColumn_14 = new DataColumn("comment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_14);
				this.dataColumn_15 = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_15);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.vDocPylonEquipRepairRow NewvDocPylonEquipRepairRow()
			{
				return (DataSetReportAirLinePassport.vDocPylonEquipRepairRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.vDocPylonEquipRepairRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.vDocPylonEquipRepairRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.vDocPylonEquipRepairRowChangeEventHandler_1 != null)
				{
					this.vDocPylonEquipRepairRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEvent((DataSetReportAirLinePassport.vDocPylonEquipRepairRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.vDocPylonEquipRepairRowChangeEventHandler_0 != null)
				{
					this.vDocPylonEquipRepairRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEvent((DataSetReportAirLinePassport.vDocPylonEquipRepairRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.vDocPylonEquipRepairRowChangeEventHandler_3 != null)
				{
					this.vDocPylonEquipRepairRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEvent((DataSetReportAirLinePassport.vDocPylonEquipRepairRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.vDocPylonEquipRepairRowChangeEventHandler_2 != null)
				{
					this.vDocPylonEquipRepairRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEvent((DataSetReportAirLinePassport.vDocPylonEquipRepairRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovevDocPylonEquipRepairRow(DataSetReportAirLinePassport.vDocPylonEquipRepairRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vDocPylonEquipRepairDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			[CompilerGenerated]
			private DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.vDocPylonEquipRepairRowChangeEventHandler vDocPylonEquipRepairRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSettingsDataTable : TypedTableBase<DataSetReportAirLinePassport.tSettingsRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tSettingsDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "tSettings";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tSettingsDataTable(DataTable table)
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
			protected tSettingsDataTable(SerializationInfo info, StreamingContext context)
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
			public DataColumn HostIpColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SettingsColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ModuleColumn
			{
				get
				{
					return this.dataColumn_3;
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
			public DataSetReportAirLinePassport.tSettingsRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.tSettingsRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler = this.tSettingsRowChangeEventHandler_0;
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler2;
					do
					{
						tSettingsRowChangeEventHandler2 = tSettingsRowChangeEventHandler;
						DataSetReportAirLinePassport.tSettingsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tSettingsRowChangeEventHandler)Delegate.Combine(tSettingsRowChangeEventHandler2, value);
						tSettingsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tSettingsRowChangeEventHandler>(ref this.tSettingsRowChangeEventHandler_0, value2, tSettingsRowChangeEventHandler2);
					}
					while (tSettingsRowChangeEventHandler != tSettingsRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler = this.tSettingsRowChangeEventHandler_0;
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler2;
					do
					{
						tSettingsRowChangeEventHandler2 = tSettingsRowChangeEventHandler;
						DataSetReportAirLinePassport.tSettingsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tSettingsRowChangeEventHandler)Delegate.Remove(tSettingsRowChangeEventHandler2, value);
						tSettingsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tSettingsRowChangeEventHandler>(ref this.tSettingsRowChangeEventHandler_0, value2, tSettingsRowChangeEventHandler2);
					}
					while (tSettingsRowChangeEventHandler != tSettingsRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler = this.tSettingsRowChangeEventHandler_1;
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler2;
					do
					{
						tSettingsRowChangeEventHandler2 = tSettingsRowChangeEventHandler;
						DataSetReportAirLinePassport.tSettingsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tSettingsRowChangeEventHandler)Delegate.Combine(tSettingsRowChangeEventHandler2, value);
						tSettingsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tSettingsRowChangeEventHandler>(ref this.tSettingsRowChangeEventHandler_1, value2, tSettingsRowChangeEventHandler2);
					}
					while (tSettingsRowChangeEventHandler != tSettingsRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler = this.tSettingsRowChangeEventHandler_1;
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler2;
					do
					{
						tSettingsRowChangeEventHandler2 = tSettingsRowChangeEventHandler;
						DataSetReportAirLinePassport.tSettingsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tSettingsRowChangeEventHandler)Delegate.Remove(tSettingsRowChangeEventHandler2, value);
						tSettingsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tSettingsRowChangeEventHandler>(ref this.tSettingsRowChangeEventHandler_1, value2, tSettingsRowChangeEventHandler2);
					}
					while (tSettingsRowChangeEventHandler != tSettingsRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler = this.tSettingsRowChangeEventHandler_2;
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler2;
					do
					{
						tSettingsRowChangeEventHandler2 = tSettingsRowChangeEventHandler;
						DataSetReportAirLinePassport.tSettingsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tSettingsRowChangeEventHandler)Delegate.Combine(tSettingsRowChangeEventHandler2, value);
						tSettingsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tSettingsRowChangeEventHandler>(ref this.tSettingsRowChangeEventHandler_2, value2, tSettingsRowChangeEventHandler2);
					}
					while (tSettingsRowChangeEventHandler != tSettingsRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler = this.tSettingsRowChangeEventHandler_2;
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler2;
					do
					{
						tSettingsRowChangeEventHandler2 = tSettingsRowChangeEventHandler;
						DataSetReportAirLinePassport.tSettingsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tSettingsRowChangeEventHandler)Delegate.Remove(tSettingsRowChangeEventHandler2, value);
						tSettingsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tSettingsRowChangeEventHandler>(ref this.tSettingsRowChangeEventHandler_2, value2, tSettingsRowChangeEventHandler2);
					}
					while (tSettingsRowChangeEventHandler != tSettingsRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler = this.tSettingsRowChangeEventHandler_3;
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler2;
					do
					{
						tSettingsRowChangeEventHandler2 = tSettingsRowChangeEventHandler;
						DataSetReportAirLinePassport.tSettingsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tSettingsRowChangeEventHandler)Delegate.Combine(tSettingsRowChangeEventHandler2, value);
						tSettingsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tSettingsRowChangeEventHandler>(ref this.tSettingsRowChangeEventHandler_3, value2, tSettingsRowChangeEventHandler2);
					}
					while (tSettingsRowChangeEventHandler != tSettingsRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler = this.tSettingsRowChangeEventHandler_3;
					DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler2;
					do
					{
						tSettingsRowChangeEventHandler2 = tSettingsRowChangeEventHandler;
						DataSetReportAirLinePassport.tSettingsRowChangeEventHandler value2 = (DataSetReportAirLinePassport.tSettingsRowChangeEventHandler)Delegate.Remove(tSettingsRowChangeEventHandler2, value);
						tSettingsRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.tSettingsRowChangeEventHandler>(ref this.tSettingsRowChangeEventHandler_3, value2, tSettingsRowChangeEventHandler2);
					}
					while (tSettingsRowChangeEventHandler != tSettingsRowChangeEventHandler2);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddtSettingsRow(DataSetReportAirLinePassport.tSettingsRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.tSettingsRow AddtSettingsRow(string HostIp, string Settings, string Module)
			{
				DataSetReportAirLinePassport.tSettingsRow tSettingsRow = (DataSetReportAirLinePassport.tSettingsRow)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					HostIp,
					Settings,
					Module
				};
				tSettingsRow.ItemArray = itemArray;
				base.Rows.Add(tSettingsRow);
				return tSettingsRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.tSettingsRow FindByid(int id)
			{
				return (DataSetReportAirLinePassport.tSettingsRow)base.Rows.Find(new object[]
				{
					id
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.tSettingsDataTable tSettingsDataTable = (DataSetReportAirLinePassport.tSettingsDataTable)base.Clone();
				tSettingsDataTable.method_0();
				return tSettingsDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.tSettingsDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["HostIp"];
				this.dataColumn_2 = base.Columns["Settings"];
				this.dataColumn_3 = base.Columns["Module"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.tSettingsRow NewtSettingsRow()
			{
				return (DataSetReportAirLinePassport.tSettingsRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.tSettingsRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.tSettingsRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.tSettingsRowChangeEventHandler_1 != null)
				{
					this.tSettingsRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.tSettingsRowChangeEvent((DataSetReportAirLinePassport.tSettingsRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.tSettingsRowChangeEventHandler_0 != null)
				{
					this.tSettingsRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.tSettingsRowChangeEvent((DataSetReportAirLinePassport.tSettingsRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.tSettingsRowChangeEventHandler_3 != null)
				{
					this.tSettingsRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.tSettingsRowChangeEvent((DataSetReportAirLinePassport.tSettingsRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.tSettingsRowChangeEventHandler_2 != null)
				{
					this.tSettingsRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.tSettingsRowChangeEvent((DataSetReportAirLinePassport.tSettingsRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovetSettingsRow(DataSetReportAirLinePassport.tSettingsRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSettingsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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
			private DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.tSettingsRowChangeEventHandler tSettingsRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtReportAirLineRepairMainDataTable : TypedTableBase<DataSetReportAirLinePassport.dtReportAirLineRepairMainRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtReportAirLineRepairMainDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtReportAirLineRepairMain";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtReportAirLineRepairMainDataTable(DataTable table)
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
			protected dtReportAirLineRepairMainDataTable(SerializationInfo info, StreamingContext context)
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParentIdColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn numberDocColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dateDocColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn commentColumn
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idHeadNetRegionColumn
			{
				get
				{
					return this.dataColumn_5;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idEngineerPTSColumn
			{
				get
				{
					return this.dataColumn_6;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn LengthColumn
			{
				get
				{
					return this.dataColumn_7;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn FromColumn
			{
				get
				{
					return this.dataColumn_8;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ToColumn
			{
				get
				{
					return this.dataColumn_9;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn treeCountColumn
			{
				get
				{
					return this.dataColumn_10;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn postHeadRegionColumn
			{
				get
				{
					return this.dataColumn_11;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn nameHeadRegionColumn
			{
				get
				{
					return this.dataColumn_12;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn postEngineerPTSColumn
			{
				get
				{
					return this.dataColumn_13;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn nameEngineerPTSColumn
			{
				get
				{
					return this.dataColumn_14;
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
			public DataSetReportAirLinePassport.dtReportAirLineRepairMainRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtReportAirLineRepairMainRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler = this.dtReportAirLineRepairMainRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairMainRowChangeEventHandler2 = dtReportAirLineRepairMainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler)Delegate.Combine(dtReportAirLineRepairMainRowChangeEventHandler2, value);
						dtReportAirLineRepairMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler>(ref this.dtReportAirLineRepairMainRowChangeEventHandler_0, value2, dtReportAirLineRepairMainRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairMainRowChangeEventHandler != dtReportAirLineRepairMainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler = this.dtReportAirLineRepairMainRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairMainRowChangeEventHandler2 = dtReportAirLineRepairMainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler)Delegate.Remove(dtReportAirLineRepairMainRowChangeEventHandler2, value);
						dtReportAirLineRepairMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler>(ref this.dtReportAirLineRepairMainRowChangeEventHandler_0, value2, dtReportAirLineRepairMainRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairMainRowChangeEventHandler != dtReportAirLineRepairMainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler = this.dtReportAirLineRepairMainRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairMainRowChangeEventHandler2 = dtReportAirLineRepairMainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler)Delegate.Combine(dtReportAirLineRepairMainRowChangeEventHandler2, value);
						dtReportAirLineRepairMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler>(ref this.dtReportAirLineRepairMainRowChangeEventHandler_1, value2, dtReportAirLineRepairMainRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairMainRowChangeEventHandler != dtReportAirLineRepairMainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler = this.dtReportAirLineRepairMainRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairMainRowChangeEventHandler2 = dtReportAirLineRepairMainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler)Delegate.Remove(dtReportAirLineRepairMainRowChangeEventHandler2, value);
						dtReportAirLineRepairMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler>(ref this.dtReportAirLineRepairMainRowChangeEventHandler_1, value2, dtReportAirLineRepairMainRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairMainRowChangeEventHandler != dtReportAirLineRepairMainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler = this.dtReportAirLineRepairMainRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairMainRowChangeEventHandler2 = dtReportAirLineRepairMainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler)Delegate.Combine(dtReportAirLineRepairMainRowChangeEventHandler2, value);
						dtReportAirLineRepairMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler>(ref this.dtReportAirLineRepairMainRowChangeEventHandler_2, value2, dtReportAirLineRepairMainRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairMainRowChangeEventHandler != dtReportAirLineRepairMainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler = this.dtReportAirLineRepairMainRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairMainRowChangeEventHandler2 = dtReportAirLineRepairMainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler)Delegate.Remove(dtReportAirLineRepairMainRowChangeEventHandler2, value);
						dtReportAirLineRepairMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler>(ref this.dtReportAirLineRepairMainRowChangeEventHandler_2, value2, dtReportAirLineRepairMainRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairMainRowChangeEventHandler != dtReportAirLineRepairMainRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler = this.dtReportAirLineRepairMainRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairMainRowChangeEventHandler2 = dtReportAirLineRepairMainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler)Delegate.Combine(dtReportAirLineRepairMainRowChangeEventHandler2, value);
						dtReportAirLineRepairMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler>(ref this.dtReportAirLineRepairMainRowChangeEventHandler_3, value2, dtReportAirLineRepairMainRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairMainRowChangeEventHandler != dtReportAirLineRepairMainRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler = this.dtReportAirLineRepairMainRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairMainRowChangeEventHandler2 = dtReportAirLineRepairMainRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler)Delegate.Remove(dtReportAirLineRepairMainRowChangeEventHandler2, value);
						dtReportAirLineRepairMainRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler>(ref this.dtReportAirLineRepairMainRowChangeEventHandler_3, value2, dtReportAirLineRepairMainRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairMainRowChangeEventHandler != dtReportAirLineRepairMainRowChangeEventHandler2);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtReportAirLineRepairMainRow(DataSetReportAirLinePassport.dtReportAirLineRepairMainRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtReportAirLineRepairMainRow AdddtReportAirLineRepairMainRow(int id, int ParentId, string numberDoc, string dateDoc, string comment, int idHeadNetRegion, int idEngineerPTS, string Length, string From, string To, string treeCount, string postHeadRegion, string nameHeadRegion, string postEngineerPTS, string nameEngineerPTS)
			{
				DataSetReportAirLinePassport.dtReportAirLineRepairMainRow dtReportAirLineRepairMainRow = (DataSetReportAirLinePassport.dtReportAirLineRepairMainRow)base.NewRow();
				object[] itemArray = new object[]
				{
					id,
					ParentId,
					numberDoc,
					dateDoc,
					comment,
					idHeadNetRegion,
					idEngineerPTS,
					Length,
					From,
					To,
					treeCount,
					postHeadRegion,
					nameHeadRegion,
					postEngineerPTS,
					nameEngineerPTS
				};
				dtReportAirLineRepairMainRow.ItemArray = itemArray;
				base.Rows.Add(dtReportAirLineRepairMainRow);
				return dtReportAirLineRepairMainRow;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtReportAirLineRepairMainDataTable dtReportAirLineRepairMainDataTable = (DataSetReportAirLinePassport.dtReportAirLineRepairMainDataTable)base.Clone();
				dtReportAirLineRepairMainDataTable.method_0();
				return dtReportAirLineRepairMainDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtReportAirLineRepairMainDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["ParentId"];
				this.dataColumn_2 = base.Columns["numberDoc"];
				this.dataColumn_3 = base.Columns["dateDoc"];
				this.dataColumn_4 = base.Columns["comment"];
				this.dataColumn_5 = base.Columns["idHeadNetRegion"];
				this.dataColumn_6 = base.Columns["idEngineerPTS"];
				this.dataColumn_7 = base.Columns["Length"];
				this.dataColumn_8 = base.Columns["From"];
				this.dataColumn_9 = base.Columns["To"];
				this.dataColumn_10 = base.Columns["treeCount"];
				this.dataColumn_11 = base.Columns["postHeadRegion"];
				this.dataColumn_12 = base.Columns["nameHeadRegion"];
				this.dataColumn_13 = base.Columns["postEngineerPTS"];
				this.dataColumn_14 = base.Columns["nameEngineerPTS"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("ParentId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("numberDoc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("dateDoc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("comment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("idHeadNetRegion", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("idEngineerPTS", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("Length", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("From", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("To", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("treeCount", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("postHeadRegion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("nameHeadRegion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
				this.dataColumn_13 = new DataColumn("postEngineerPTS", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_13);
				this.dataColumn_14 = new DataColumn("nameEngineerPTS", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_14);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtReportAirLineRepairMainRow NewdtReportAirLineRepairMainRow()
			{
				return (DataSetReportAirLinePassport.dtReportAirLineRepairMainRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtReportAirLineRepairMainRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtReportAirLineRepairMainRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtReportAirLineRepairMainRowChangeEventHandler_1 != null)
				{
					this.dtReportAirLineRepairMainRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEvent((DataSetReportAirLinePassport.dtReportAirLineRepairMainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtReportAirLineRepairMainRowChangeEventHandler_0 != null)
				{
					this.dtReportAirLineRepairMainRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEvent((DataSetReportAirLinePassport.dtReportAirLineRepairMainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtReportAirLineRepairMainRowChangeEventHandler_3 != null)
				{
					this.dtReportAirLineRepairMainRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEvent((DataSetReportAirLinePassport.dtReportAirLineRepairMainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtReportAirLineRepairMainRowChangeEventHandler_2 != null)
				{
					this.dtReportAirLineRepairMainRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEvent((DataSetReportAirLinePassport.dtReportAirLineRepairMainRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtReportAirLineRepairMainRow(DataSetReportAirLinePassport.dtReportAirLineRepairMainRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtReportAirLineRepairMainDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtReportAirLineRepairMainRowChangeEventHandler dtReportAirLineRepairMainRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtReportAirLineRepairWorkDataTable : TypedTableBase<DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtReportAirLineRepairWorkDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtReportAirLineRepairWork";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtReportAirLineRepairWorkDataTable(DataTable table)
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
			protected dtReportAirLineRepairWorkDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idDocColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NameColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn UnitColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CountColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idPylonColumn
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PylonColumn
			{
				get
				{
					return this.dataColumn_5;
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
			public DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler = this.dtReportAirLineRepairWorkRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairWorkRowChangeEventHandler2 = dtReportAirLineRepairWorkRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler)Delegate.Combine(dtReportAirLineRepairWorkRowChangeEventHandler2, value);
						dtReportAirLineRepairWorkRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler>(ref this.dtReportAirLineRepairWorkRowChangeEventHandler_0, value2, dtReportAirLineRepairWorkRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairWorkRowChangeEventHandler != dtReportAirLineRepairWorkRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler = this.dtReportAirLineRepairWorkRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairWorkRowChangeEventHandler2 = dtReportAirLineRepairWorkRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler)Delegate.Remove(dtReportAirLineRepairWorkRowChangeEventHandler2, value);
						dtReportAirLineRepairWorkRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler>(ref this.dtReportAirLineRepairWorkRowChangeEventHandler_0, value2, dtReportAirLineRepairWorkRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairWorkRowChangeEventHandler != dtReportAirLineRepairWorkRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler = this.dtReportAirLineRepairWorkRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairWorkRowChangeEventHandler2 = dtReportAirLineRepairWorkRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler)Delegate.Combine(dtReportAirLineRepairWorkRowChangeEventHandler2, value);
						dtReportAirLineRepairWorkRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler>(ref this.dtReportAirLineRepairWorkRowChangeEventHandler_1, value2, dtReportAirLineRepairWorkRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairWorkRowChangeEventHandler != dtReportAirLineRepairWorkRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler = this.dtReportAirLineRepairWorkRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairWorkRowChangeEventHandler2 = dtReportAirLineRepairWorkRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler)Delegate.Remove(dtReportAirLineRepairWorkRowChangeEventHandler2, value);
						dtReportAirLineRepairWorkRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler>(ref this.dtReportAirLineRepairWorkRowChangeEventHandler_1, value2, dtReportAirLineRepairWorkRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairWorkRowChangeEventHandler != dtReportAirLineRepairWorkRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler = this.dtReportAirLineRepairWorkRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairWorkRowChangeEventHandler2 = dtReportAirLineRepairWorkRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler)Delegate.Combine(dtReportAirLineRepairWorkRowChangeEventHandler2, value);
						dtReportAirLineRepairWorkRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler>(ref this.dtReportAirLineRepairWorkRowChangeEventHandler_2, value2, dtReportAirLineRepairWorkRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairWorkRowChangeEventHandler != dtReportAirLineRepairWorkRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler = this.dtReportAirLineRepairWorkRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairWorkRowChangeEventHandler2 = dtReportAirLineRepairWorkRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler)Delegate.Remove(dtReportAirLineRepairWorkRowChangeEventHandler2, value);
						dtReportAirLineRepairWorkRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler>(ref this.dtReportAirLineRepairWorkRowChangeEventHandler_2, value2, dtReportAirLineRepairWorkRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairWorkRowChangeEventHandler != dtReportAirLineRepairWorkRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler = this.dtReportAirLineRepairWorkRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairWorkRowChangeEventHandler2 = dtReportAirLineRepairWorkRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler)Delegate.Combine(dtReportAirLineRepairWorkRowChangeEventHandler2, value);
						dtReportAirLineRepairWorkRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler>(ref this.dtReportAirLineRepairWorkRowChangeEventHandler_3, value2, dtReportAirLineRepairWorkRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairWorkRowChangeEventHandler != dtReportAirLineRepairWorkRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler = this.dtReportAirLineRepairWorkRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairWorkRowChangeEventHandler2 = dtReportAirLineRepairWorkRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler)Delegate.Remove(dtReportAirLineRepairWorkRowChangeEventHandler2, value);
						dtReportAirLineRepairWorkRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler>(ref this.dtReportAirLineRepairWorkRowChangeEventHandler_3, value2, dtReportAirLineRepairWorkRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairWorkRowChangeEventHandler != dtReportAirLineRepairWorkRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtReportAirLineRepairWorkRow(DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow AdddtReportAirLineRepairWorkRow(int idDoc, string Name, string Unit, string Count, int idPylon, string Pylon)
			{
				DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow dtReportAirLineRepairWorkRow = (DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow)base.NewRow();
				object[] itemArray = new object[]
				{
					idDoc,
					Name,
					Unit,
					Count,
					idPylon,
					Pylon
				};
				dtReportAirLineRepairWorkRow.ItemArray = itemArray;
				base.Rows.Add(dtReportAirLineRepairWorkRow);
				return dtReportAirLineRepairWorkRow;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtReportAirLineRepairWorkDataTable dtReportAirLineRepairWorkDataTable = (DataSetReportAirLinePassport.dtReportAirLineRepairWorkDataTable)base.Clone();
				dtReportAirLineRepairWorkDataTable.method_0();
				return dtReportAirLineRepairWorkDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtReportAirLineRepairWorkDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["idDoc"];
				this.dataColumn_1 = base.Columns["Name"];
				this.dataColumn_2 = base.Columns["Unit"];
				this.dataColumn_3 = base.Columns["Count"];
				this.dataColumn_4 = base.Columns["idPylon"];
				this.dataColumn_5 = base.Columns["Pylon"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("idDoc", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("Unit", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("Count", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("idPylon", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Pylon", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow NewdtReportAirLineRepairWorkRow()
			{
				return (DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtReportAirLineRepairWorkRowChangeEventHandler_1 != null)
				{
					this.dtReportAirLineRepairWorkRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEvent((DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtReportAirLineRepairWorkRowChangeEventHandler_0 != null)
				{
					this.dtReportAirLineRepairWorkRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEvent((DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtReportAirLineRepairWorkRowChangeEventHandler_3 != null)
				{
					this.dtReportAirLineRepairWorkRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEvent((DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtReportAirLineRepairWorkRowChangeEventHandler_2 != null)
				{
					this.dtReportAirLineRepairWorkRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEvent((DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtReportAirLineRepairWorkRow(DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtReportAirLineRepairWorkDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtReportAirLineRepairWorkRowChangeEventHandler dtReportAirLineRepairWorkRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtReportAirLineRepairAddressDataTable : TypedTableBase<DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtReportAirLineRepairAddressDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtReportAirLineRepairAddress";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtReportAirLineRepairAddressDataTable(DataTable table)
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
			protected dtReportAirLineRepairAddressDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idDocColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ParentIdColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idObjListColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.dataColumn_3;
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
			public DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler = this.dtReportAirLineRepairAddressRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairAddressRowChangeEventHandler2 = dtReportAirLineRepairAddressRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler)Delegate.Combine(dtReportAirLineRepairAddressRowChangeEventHandler2, value);
						dtReportAirLineRepairAddressRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler>(ref this.dtReportAirLineRepairAddressRowChangeEventHandler_0, value2, dtReportAirLineRepairAddressRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairAddressRowChangeEventHandler != dtReportAirLineRepairAddressRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler = this.dtReportAirLineRepairAddressRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairAddressRowChangeEventHandler2 = dtReportAirLineRepairAddressRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler)Delegate.Remove(dtReportAirLineRepairAddressRowChangeEventHandler2, value);
						dtReportAirLineRepairAddressRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler>(ref this.dtReportAirLineRepairAddressRowChangeEventHandler_0, value2, dtReportAirLineRepairAddressRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairAddressRowChangeEventHandler != dtReportAirLineRepairAddressRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler = this.dtReportAirLineRepairAddressRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairAddressRowChangeEventHandler2 = dtReportAirLineRepairAddressRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler)Delegate.Combine(dtReportAirLineRepairAddressRowChangeEventHandler2, value);
						dtReportAirLineRepairAddressRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler>(ref this.dtReportAirLineRepairAddressRowChangeEventHandler_1, value2, dtReportAirLineRepairAddressRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairAddressRowChangeEventHandler != dtReportAirLineRepairAddressRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler = this.dtReportAirLineRepairAddressRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairAddressRowChangeEventHandler2 = dtReportAirLineRepairAddressRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler)Delegate.Remove(dtReportAirLineRepairAddressRowChangeEventHandler2, value);
						dtReportAirLineRepairAddressRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler>(ref this.dtReportAirLineRepairAddressRowChangeEventHandler_1, value2, dtReportAirLineRepairAddressRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairAddressRowChangeEventHandler != dtReportAirLineRepairAddressRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler = this.dtReportAirLineRepairAddressRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairAddressRowChangeEventHandler2 = dtReportAirLineRepairAddressRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler)Delegate.Combine(dtReportAirLineRepairAddressRowChangeEventHandler2, value);
						dtReportAirLineRepairAddressRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler>(ref this.dtReportAirLineRepairAddressRowChangeEventHandler_2, value2, dtReportAirLineRepairAddressRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairAddressRowChangeEventHandler != dtReportAirLineRepairAddressRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler = this.dtReportAirLineRepairAddressRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairAddressRowChangeEventHandler2 = dtReportAirLineRepairAddressRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler)Delegate.Remove(dtReportAirLineRepairAddressRowChangeEventHandler2, value);
						dtReportAirLineRepairAddressRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler>(ref this.dtReportAirLineRepairAddressRowChangeEventHandler_2, value2, dtReportAirLineRepairAddressRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairAddressRowChangeEventHandler != dtReportAirLineRepairAddressRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler = this.dtReportAirLineRepairAddressRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairAddressRowChangeEventHandler2 = dtReportAirLineRepairAddressRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler)Delegate.Combine(dtReportAirLineRepairAddressRowChangeEventHandler2, value);
						dtReportAirLineRepairAddressRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler>(ref this.dtReportAirLineRepairAddressRowChangeEventHandler_3, value2, dtReportAirLineRepairAddressRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairAddressRowChangeEventHandler != dtReportAirLineRepairAddressRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler = this.dtReportAirLineRepairAddressRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler2;
					do
					{
						dtReportAirLineRepairAddressRowChangeEventHandler2 = dtReportAirLineRepairAddressRowChangeEventHandler;
						DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler)Delegate.Remove(dtReportAirLineRepairAddressRowChangeEventHandler2, value);
						dtReportAirLineRepairAddressRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler>(ref this.dtReportAirLineRepairAddressRowChangeEventHandler_3, value2, dtReportAirLineRepairAddressRowChangeEventHandler2);
					}
					while (dtReportAirLineRepairAddressRowChangeEventHandler != dtReportAirLineRepairAddressRowChangeEventHandler2);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtReportAirLineRepairAddressRow(DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow AdddtReportAirLineRepairAddressRow(int idDoc, int ParentId, int idObjList, string Name)
			{
				DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow dtReportAirLineRepairAddressRow = (DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow)base.NewRow();
				object[] itemArray = new object[]
				{
					idDoc,
					ParentId,
					idObjList,
					Name
				};
				dtReportAirLineRepairAddressRow.ItemArray = itemArray;
				base.Rows.Add(dtReportAirLineRepairAddressRow);
				return dtReportAirLineRepairAddressRow;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtReportAirLineRepairAddressDataTable dtReportAirLineRepairAddressDataTable = (DataSetReportAirLinePassport.dtReportAirLineRepairAddressDataTable)base.Clone();
				dtReportAirLineRepairAddressDataTable.method_0();
				return dtReportAirLineRepairAddressDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtReportAirLineRepairAddressDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["idDoc"];
				this.dataColumn_1 = base.Columns["ParentId"];
				this.dataColumn_2 = base.Columns["idObjList"];
				this.dataColumn_3 = base.Columns["Name"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("idDoc", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("ParentId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow NewdtReportAirLineRepairAddressRow()
			{
				return (DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtReportAirLineRepairAddressRowChangeEventHandler_1 != null)
				{
					this.dtReportAirLineRepairAddressRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEvent((DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtReportAirLineRepairAddressRowChangeEventHandler_0 != null)
				{
					this.dtReportAirLineRepairAddressRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEvent((DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtReportAirLineRepairAddressRowChangeEventHandler_3 != null)
				{
					this.dtReportAirLineRepairAddressRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEvent((DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtReportAirLineRepairAddressRowChangeEventHandler_2 != null)
				{
					this.dtReportAirLineRepairAddressRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEvent((DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovedtReportAirLineRepairAddressRow(DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtReportAirLineRepairAddressDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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
			private DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtReportAirLineRepairAddressRowChangeEventHandler dtReportAirLineRepairAddressRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtInspectAirLineDefectDataTable : TypedTableBase<DataSetReportAirLinePassport.dtInspectAirLineDefectRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtInspectAirLineDefectDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtInspectAirLineDefect";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtInspectAirLineDefectDataTable(DataTable table)
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
			protected dtInspectAirLineDefectDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idDocColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DefectColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PylonColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idPylonColumn
			{
				get
				{
					return this.dataColumn_3;
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
			public DataSetReportAirLinePassport.dtInspectAirLineDefectRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtInspectAirLineDefectRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler = this.dtInspectAirLineDefectRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler2;
					do
					{
						dtInspectAirLineDefectRowChangeEventHandler2 = dtInspectAirLineDefectRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler)Delegate.Combine(dtInspectAirLineDefectRowChangeEventHandler2, value);
						dtInspectAirLineDefectRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler>(ref this.dtInspectAirLineDefectRowChangeEventHandler_0, value2, dtInspectAirLineDefectRowChangeEventHandler2);
					}
					while (dtInspectAirLineDefectRowChangeEventHandler != dtInspectAirLineDefectRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler = this.dtInspectAirLineDefectRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler2;
					do
					{
						dtInspectAirLineDefectRowChangeEventHandler2 = dtInspectAirLineDefectRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler)Delegate.Remove(dtInspectAirLineDefectRowChangeEventHandler2, value);
						dtInspectAirLineDefectRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler>(ref this.dtInspectAirLineDefectRowChangeEventHandler_0, value2, dtInspectAirLineDefectRowChangeEventHandler2);
					}
					while (dtInspectAirLineDefectRowChangeEventHandler != dtInspectAirLineDefectRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler = this.dtInspectAirLineDefectRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler2;
					do
					{
						dtInspectAirLineDefectRowChangeEventHandler2 = dtInspectAirLineDefectRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler)Delegate.Combine(dtInspectAirLineDefectRowChangeEventHandler2, value);
						dtInspectAirLineDefectRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler>(ref this.dtInspectAirLineDefectRowChangeEventHandler_1, value2, dtInspectAirLineDefectRowChangeEventHandler2);
					}
					while (dtInspectAirLineDefectRowChangeEventHandler != dtInspectAirLineDefectRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler = this.dtInspectAirLineDefectRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler2;
					do
					{
						dtInspectAirLineDefectRowChangeEventHandler2 = dtInspectAirLineDefectRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler)Delegate.Remove(dtInspectAirLineDefectRowChangeEventHandler2, value);
						dtInspectAirLineDefectRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler>(ref this.dtInspectAirLineDefectRowChangeEventHandler_1, value2, dtInspectAirLineDefectRowChangeEventHandler2);
					}
					while (dtInspectAirLineDefectRowChangeEventHandler != dtInspectAirLineDefectRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler = this.dtInspectAirLineDefectRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler2;
					do
					{
						dtInspectAirLineDefectRowChangeEventHandler2 = dtInspectAirLineDefectRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler)Delegate.Combine(dtInspectAirLineDefectRowChangeEventHandler2, value);
						dtInspectAirLineDefectRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler>(ref this.dtInspectAirLineDefectRowChangeEventHandler_2, value2, dtInspectAirLineDefectRowChangeEventHandler2);
					}
					while (dtInspectAirLineDefectRowChangeEventHandler != dtInspectAirLineDefectRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler = this.dtInspectAirLineDefectRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler2;
					do
					{
						dtInspectAirLineDefectRowChangeEventHandler2 = dtInspectAirLineDefectRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler)Delegate.Remove(dtInspectAirLineDefectRowChangeEventHandler2, value);
						dtInspectAirLineDefectRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler>(ref this.dtInspectAirLineDefectRowChangeEventHandler_2, value2, dtInspectAirLineDefectRowChangeEventHandler2);
					}
					while (dtInspectAirLineDefectRowChangeEventHandler != dtInspectAirLineDefectRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler = this.dtInspectAirLineDefectRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler2;
					do
					{
						dtInspectAirLineDefectRowChangeEventHandler2 = dtInspectAirLineDefectRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler)Delegate.Combine(dtInspectAirLineDefectRowChangeEventHandler2, value);
						dtInspectAirLineDefectRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler>(ref this.dtInspectAirLineDefectRowChangeEventHandler_3, value2, dtInspectAirLineDefectRowChangeEventHandler2);
					}
					while (dtInspectAirLineDefectRowChangeEventHandler != dtInspectAirLineDefectRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler = this.dtInspectAirLineDefectRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler2;
					do
					{
						dtInspectAirLineDefectRowChangeEventHandler2 = dtInspectAirLineDefectRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler)Delegate.Remove(dtInspectAirLineDefectRowChangeEventHandler2, value);
						dtInspectAirLineDefectRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler>(ref this.dtInspectAirLineDefectRowChangeEventHandler_3, value2, dtInspectAirLineDefectRowChangeEventHandler2);
					}
					while (dtInspectAirLineDefectRowChangeEventHandler != dtInspectAirLineDefectRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtInspectAirLineDefectRow(DataSetReportAirLinePassport.dtInspectAirLineDefectRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtInspectAirLineDefectRow AdddtInspectAirLineDefectRow(int idDoc, string Defect, string Pylon, int idPylon)
			{
				DataSetReportAirLinePassport.dtInspectAirLineDefectRow dtInspectAirLineDefectRow = (DataSetReportAirLinePassport.dtInspectAirLineDefectRow)base.NewRow();
				object[] itemArray = new object[]
				{
					idDoc,
					Defect,
					Pylon,
					idPylon
				};
				dtInspectAirLineDefectRow.ItemArray = itemArray;
				base.Rows.Add(dtInspectAirLineDefectRow);
				return dtInspectAirLineDefectRow;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtInspectAirLineDefectDataTable dtInspectAirLineDefectDataTable = (DataSetReportAirLinePassport.dtInspectAirLineDefectDataTable)base.Clone();
				dtInspectAirLineDefectDataTable.method_0();
				return dtInspectAirLineDefectDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtInspectAirLineDefectDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["idDoc"];
				this.dataColumn_1 = base.Columns["Defect"];
				this.dataColumn_2 = base.Columns["Pylon"];
				this.dataColumn_3 = base.Columns["idPylon"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("idDoc", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Defect", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("Pylon", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("idPylon", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtInspectAirLineDefectRow NewdtInspectAirLineDefectRow()
			{
				return (DataSetReportAirLinePassport.dtInspectAirLineDefectRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtInspectAirLineDefectRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtInspectAirLineDefectRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtInspectAirLineDefectRowChangeEventHandler_1 != null)
				{
					this.dtInspectAirLineDefectRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEvent((DataSetReportAirLinePassport.dtInspectAirLineDefectRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtInspectAirLineDefectRowChangeEventHandler_0 != null)
				{
					this.dtInspectAirLineDefectRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEvent((DataSetReportAirLinePassport.dtInspectAirLineDefectRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtInspectAirLineDefectRowChangeEventHandler_3 != null)
				{
					this.dtInspectAirLineDefectRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEvent((DataSetReportAirLinePassport.dtInspectAirLineDefectRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtInspectAirLineDefectRowChangeEventHandler_2 != null)
				{
					this.dtInspectAirLineDefectRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEvent((DataSetReportAirLinePassport.dtInspectAirLineDefectRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovedtInspectAirLineDefectRow(DataSetReportAirLinePassport.dtInspectAirLineDefectRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtInspectAirLineDefectDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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
			private DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtInspectAirLineDefectRowChangeEventHandler dtInspectAirLineDefectRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtInspectAirLineWorkerDataTable : TypedTableBase<DataSetReportAirLinePassport.dtInspectAirLineWorkerRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtInspectAirLineWorkerDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtInspectAirLineWorker";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtInspectAirLineWorkerDataTable(DataTable table)
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
			protected dtInspectAirLineWorkerDataTable(SerializationInfo info, StreamingContext context)
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
			public DataSetReportAirLinePassport.dtInspectAirLineWorkerRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtInspectAirLineWorkerRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler = this.dtInspectAirLineWorkerRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler2;
					do
					{
						dtInspectAirLineWorkerRowChangeEventHandler2 = dtInspectAirLineWorkerRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler)Delegate.Combine(dtInspectAirLineWorkerRowChangeEventHandler2, value);
						dtInspectAirLineWorkerRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler>(ref this.dtInspectAirLineWorkerRowChangeEventHandler_0, value2, dtInspectAirLineWorkerRowChangeEventHandler2);
					}
					while (dtInspectAirLineWorkerRowChangeEventHandler != dtInspectAirLineWorkerRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler = this.dtInspectAirLineWorkerRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler2;
					do
					{
						dtInspectAirLineWorkerRowChangeEventHandler2 = dtInspectAirLineWorkerRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler)Delegate.Remove(dtInspectAirLineWorkerRowChangeEventHandler2, value);
						dtInspectAirLineWorkerRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler>(ref this.dtInspectAirLineWorkerRowChangeEventHandler_0, value2, dtInspectAirLineWorkerRowChangeEventHandler2);
					}
					while (dtInspectAirLineWorkerRowChangeEventHandler != dtInspectAirLineWorkerRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler = this.dtInspectAirLineWorkerRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler2;
					do
					{
						dtInspectAirLineWorkerRowChangeEventHandler2 = dtInspectAirLineWorkerRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler)Delegate.Combine(dtInspectAirLineWorkerRowChangeEventHandler2, value);
						dtInspectAirLineWorkerRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler>(ref this.dtInspectAirLineWorkerRowChangeEventHandler_1, value2, dtInspectAirLineWorkerRowChangeEventHandler2);
					}
					while (dtInspectAirLineWorkerRowChangeEventHandler != dtInspectAirLineWorkerRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler = this.dtInspectAirLineWorkerRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler2;
					do
					{
						dtInspectAirLineWorkerRowChangeEventHandler2 = dtInspectAirLineWorkerRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler)Delegate.Remove(dtInspectAirLineWorkerRowChangeEventHandler2, value);
						dtInspectAirLineWorkerRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler>(ref this.dtInspectAirLineWorkerRowChangeEventHandler_1, value2, dtInspectAirLineWorkerRowChangeEventHandler2);
					}
					while (dtInspectAirLineWorkerRowChangeEventHandler != dtInspectAirLineWorkerRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler = this.dtInspectAirLineWorkerRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler2;
					do
					{
						dtInspectAirLineWorkerRowChangeEventHandler2 = dtInspectAirLineWorkerRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler)Delegate.Combine(dtInspectAirLineWorkerRowChangeEventHandler2, value);
						dtInspectAirLineWorkerRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler>(ref this.dtInspectAirLineWorkerRowChangeEventHandler_2, value2, dtInspectAirLineWorkerRowChangeEventHandler2);
					}
					while (dtInspectAirLineWorkerRowChangeEventHandler != dtInspectAirLineWorkerRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler = this.dtInspectAirLineWorkerRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler2;
					do
					{
						dtInspectAirLineWorkerRowChangeEventHandler2 = dtInspectAirLineWorkerRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler)Delegate.Remove(dtInspectAirLineWorkerRowChangeEventHandler2, value);
						dtInspectAirLineWorkerRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler>(ref this.dtInspectAirLineWorkerRowChangeEventHandler_2, value2, dtInspectAirLineWorkerRowChangeEventHandler2);
					}
					while (dtInspectAirLineWorkerRowChangeEventHandler != dtInspectAirLineWorkerRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler = this.dtInspectAirLineWorkerRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler2;
					do
					{
						dtInspectAirLineWorkerRowChangeEventHandler2 = dtInspectAirLineWorkerRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler)Delegate.Combine(dtInspectAirLineWorkerRowChangeEventHandler2, value);
						dtInspectAirLineWorkerRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler>(ref this.dtInspectAirLineWorkerRowChangeEventHandler_3, value2, dtInspectAirLineWorkerRowChangeEventHandler2);
					}
					while (dtInspectAirLineWorkerRowChangeEventHandler != dtInspectAirLineWorkerRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler = this.dtInspectAirLineWorkerRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler2;
					do
					{
						dtInspectAirLineWorkerRowChangeEventHandler2 = dtInspectAirLineWorkerRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler)Delegate.Remove(dtInspectAirLineWorkerRowChangeEventHandler2, value);
						dtInspectAirLineWorkerRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler>(ref this.dtInspectAirLineWorkerRowChangeEventHandler_3, value2, dtInspectAirLineWorkerRowChangeEventHandler2);
					}
					while (dtInspectAirLineWorkerRowChangeEventHandler != dtInspectAirLineWorkerRowChangeEventHandler2);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtInspectAirLineWorkerRow(DataSetReportAirLinePassport.dtInspectAirLineWorkerRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtInspectAirLineWorkerRow AdddtInspectAirLineWorkerRow(int id, string Name)
			{
				DataSetReportAirLinePassport.dtInspectAirLineWorkerRow dtInspectAirLineWorkerRow = (DataSetReportAirLinePassport.dtInspectAirLineWorkerRow)base.NewRow();
				object[] itemArray = new object[]
				{
					id,
					Name
				};
				dtInspectAirLineWorkerRow.ItemArray = itemArray;
				base.Rows.Add(dtInspectAirLineWorkerRow);
				return dtInspectAirLineWorkerRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtInspectAirLineWorkerDataTable dtInspectAirLineWorkerDataTable = (DataSetReportAirLinePassport.dtInspectAirLineWorkerDataTable)base.Clone();
				dtInspectAirLineWorkerDataTable.method_0();
				return dtInspectAirLineWorkerDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtInspectAirLineWorkerDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["id"];
				this.dataColumn_1 = base.Columns["Name"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtInspectAirLineWorkerRow NewdtInspectAirLineWorkerRow()
			{
				return (DataSetReportAirLinePassport.dtInspectAirLineWorkerRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtInspectAirLineWorkerRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtInspectAirLineWorkerRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtInspectAirLineWorkerRowChangeEventHandler_1 != null)
				{
					this.dtInspectAirLineWorkerRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEvent((DataSetReportAirLinePassport.dtInspectAirLineWorkerRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtInspectAirLineWorkerRowChangeEventHandler_0 != null)
				{
					this.dtInspectAirLineWorkerRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEvent((DataSetReportAirLinePassport.dtInspectAirLineWorkerRow)e.Row, e.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtInspectAirLineWorkerRowChangeEventHandler_3 != null)
				{
					this.dtInspectAirLineWorkerRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEvent((DataSetReportAirLinePassport.dtInspectAirLineWorkerRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtInspectAirLineWorkerRowChangeEventHandler_2 != null)
				{
					this.dtInspectAirLineWorkerRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEvent((DataSetReportAirLinePassport.dtInspectAirLineWorkerRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtInspectAirLineWorkerRow(DataSetReportAirLinePassport.dtInspectAirLineWorkerRow row)
			{
				base.Rows.Remove(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtInspectAirLineWorkerDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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
			private DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtInspectAirLineWorkerRowChangeEventHandler dtInspectAirLineWorkerRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtInspectAirLineOtherDataTable : TypedTableBase<DataSetReportAirLinePassport.dtInspectAirLineOtherRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtInspectAirLineOtherDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtInspectAirLineOther";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtInspectAirLineOtherDataTable(DataTable table)
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
			protected dtInspectAirLineOtherDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TypeInspectColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idTypeInspectColumn
			{
				get
				{
					return this.dataColumn_1;
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
			public DataSetReportAirLinePassport.dtInspectAirLineOtherRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtInspectAirLineOtherRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler = this.dtInspectAirLineOtherRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler2;
					do
					{
						dtInspectAirLineOtherRowChangeEventHandler2 = dtInspectAirLineOtherRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler)Delegate.Combine(dtInspectAirLineOtherRowChangeEventHandler2, value);
						dtInspectAirLineOtherRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler>(ref this.dtInspectAirLineOtherRowChangeEventHandler_0, value2, dtInspectAirLineOtherRowChangeEventHandler2);
					}
					while (dtInspectAirLineOtherRowChangeEventHandler != dtInspectAirLineOtherRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler = this.dtInspectAirLineOtherRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler2;
					do
					{
						dtInspectAirLineOtherRowChangeEventHandler2 = dtInspectAirLineOtherRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler)Delegate.Remove(dtInspectAirLineOtherRowChangeEventHandler2, value);
						dtInspectAirLineOtherRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler>(ref this.dtInspectAirLineOtherRowChangeEventHandler_0, value2, dtInspectAirLineOtherRowChangeEventHandler2);
					}
					while (dtInspectAirLineOtherRowChangeEventHandler != dtInspectAirLineOtherRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler = this.dtInspectAirLineOtherRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler2;
					do
					{
						dtInspectAirLineOtherRowChangeEventHandler2 = dtInspectAirLineOtherRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler)Delegate.Combine(dtInspectAirLineOtherRowChangeEventHandler2, value);
						dtInspectAirLineOtherRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler>(ref this.dtInspectAirLineOtherRowChangeEventHandler_1, value2, dtInspectAirLineOtherRowChangeEventHandler2);
					}
					while (dtInspectAirLineOtherRowChangeEventHandler != dtInspectAirLineOtherRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler = this.dtInspectAirLineOtherRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler2;
					do
					{
						dtInspectAirLineOtherRowChangeEventHandler2 = dtInspectAirLineOtherRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler)Delegate.Remove(dtInspectAirLineOtherRowChangeEventHandler2, value);
						dtInspectAirLineOtherRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler>(ref this.dtInspectAirLineOtherRowChangeEventHandler_1, value2, dtInspectAirLineOtherRowChangeEventHandler2);
					}
					while (dtInspectAirLineOtherRowChangeEventHandler != dtInspectAirLineOtherRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler = this.dtInspectAirLineOtherRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler2;
					do
					{
						dtInspectAirLineOtherRowChangeEventHandler2 = dtInspectAirLineOtherRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler)Delegate.Combine(dtInspectAirLineOtherRowChangeEventHandler2, value);
						dtInspectAirLineOtherRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler>(ref this.dtInspectAirLineOtherRowChangeEventHandler_2, value2, dtInspectAirLineOtherRowChangeEventHandler2);
					}
					while (dtInspectAirLineOtherRowChangeEventHandler != dtInspectAirLineOtherRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler = this.dtInspectAirLineOtherRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler2;
					do
					{
						dtInspectAirLineOtherRowChangeEventHandler2 = dtInspectAirLineOtherRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler)Delegate.Remove(dtInspectAirLineOtherRowChangeEventHandler2, value);
						dtInspectAirLineOtherRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler>(ref this.dtInspectAirLineOtherRowChangeEventHandler_2, value2, dtInspectAirLineOtherRowChangeEventHandler2);
					}
					while (dtInspectAirLineOtherRowChangeEventHandler != dtInspectAirLineOtherRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler = this.dtInspectAirLineOtherRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler2;
					do
					{
						dtInspectAirLineOtherRowChangeEventHandler2 = dtInspectAirLineOtherRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler)Delegate.Combine(dtInspectAirLineOtherRowChangeEventHandler2, value);
						dtInspectAirLineOtherRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler>(ref this.dtInspectAirLineOtherRowChangeEventHandler_3, value2, dtInspectAirLineOtherRowChangeEventHandler2);
					}
					while (dtInspectAirLineOtherRowChangeEventHandler != dtInspectAirLineOtherRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler = this.dtInspectAirLineOtherRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler2;
					do
					{
						dtInspectAirLineOtherRowChangeEventHandler2 = dtInspectAirLineOtherRowChangeEventHandler;
						DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler)Delegate.Remove(dtInspectAirLineOtherRowChangeEventHandler2, value);
						dtInspectAirLineOtherRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler>(ref this.dtInspectAirLineOtherRowChangeEventHandler_3, value2, dtInspectAirLineOtherRowChangeEventHandler2);
					}
					while (dtInspectAirLineOtherRowChangeEventHandler != dtInspectAirLineOtherRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtInspectAirLineOtherRow(DataSetReportAirLinePassport.dtInspectAirLineOtherRow row)
			{
				base.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtInspectAirLineOtherRow AdddtInspectAirLineOtherRow(string TypeInspect, int idTypeInspect)
			{
				DataSetReportAirLinePassport.dtInspectAirLineOtherRow dtInspectAirLineOtherRow = (DataSetReportAirLinePassport.dtInspectAirLineOtherRow)base.NewRow();
				object[] itemArray = new object[]
				{
					TypeInspect,
					idTypeInspect
				};
				dtInspectAirLineOtherRow.ItemArray = itemArray;
				base.Rows.Add(dtInspectAirLineOtherRow);
				return dtInspectAirLineOtherRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtInspectAirLineOtherDataTable dtInspectAirLineOtherDataTable = (DataSetReportAirLinePassport.dtInspectAirLineOtherDataTable)base.Clone();
				dtInspectAirLineOtherDataTable.method_0();
				return dtInspectAirLineOtherDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtInspectAirLineOtherDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["TypeInspect"];
				this.dataColumn_1 = base.Columns["idTypeInspect"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("TypeInspect", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("idTypeInspect", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtInspectAirLineOtherRow NewdtInspectAirLineOtherRow()
			{
				return (DataSetReportAirLinePassport.dtInspectAirLineOtherRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtInspectAirLineOtherRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtInspectAirLineOtherRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtInspectAirLineOtherRowChangeEventHandler_1 != null)
				{
					this.dtInspectAirLineOtherRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEvent((DataSetReportAirLinePassport.dtInspectAirLineOtherRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtInspectAirLineOtherRowChangeEventHandler_0 != null)
				{
					this.dtInspectAirLineOtherRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEvent((DataSetReportAirLinePassport.dtInspectAirLineOtherRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtInspectAirLineOtherRowChangeEventHandler_3 != null)
				{
					this.dtInspectAirLineOtherRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEvent((DataSetReportAirLinePassport.dtInspectAirLineOtherRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtInspectAirLineOtherRowChangeEventHandler_2 != null)
				{
					this.dtInspectAirLineOtherRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEvent((DataSetReportAirLinePassport.dtInspectAirLineOtherRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtInspectAirLineOtherRow(DataSetReportAirLinePassport.dtInspectAirLineOtherRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtInspectAirLineOtherDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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
			private DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtInspectAirLineOtherRowChangeEventHandler dtInspectAirLineOtherRowChangeEventHandler_3;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtPylonEquipExplMianDataTable : TypedTableBase<DataSetReportAirLinePassport.dtPylonEquipExplMianRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtPylonEquipExplMianDataTable()
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				base.TableName = "dtPylonEquipExplMian";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtPylonEquipExplMianDataTable(DataTable table)
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
			protected dtPylonEquipExplMianDataTable(SerializationInfo info, StreamingContext context)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(info, context);
				this.method_0();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idDocColumn
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn netRegionColumn
			{
				get
				{
					return this.dataColumn_1;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn dateDocColumn
			{
				get
				{
					return this.ftfaGuoqUxV;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idObjListColumn
			{
				get
				{
					return this.dataColumn_2;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObjListColumn
			{
				get
				{
					return this.dataColumn_3;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idPylonColumn
			{
				get
				{
					return this.dataColumn_4;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PylonColumn
			{
				get
				{
					return this.dataColumn_5;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idTypeEquipColumn
			{
				get
				{
					return this.dataColumn_6;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TypeEquipColumn
			{
				get
				{
					return this.dataColumn_7;
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
			public DataSetReportAirLinePassport.dtPylonEquipExplMianRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtPylonEquipExplMianRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChanging
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler = this.dtPylonEquipExplMianRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler2;
					do
					{
						dtPylonEquipExplMianRowChangeEventHandler2 = dtPylonEquipExplMianRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler)Delegate.Combine(dtPylonEquipExplMianRowChangeEventHandler2, value);
						dtPylonEquipExplMianRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler>(ref this.dtPylonEquipExplMianRowChangeEventHandler_0, value2, dtPylonEquipExplMianRowChangeEventHandler2);
					}
					while (dtPylonEquipExplMianRowChangeEventHandler != dtPylonEquipExplMianRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler = this.dtPylonEquipExplMianRowChangeEventHandler_0;
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler2;
					do
					{
						dtPylonEquipExplMianRowChangeEventHandler2 = dtPylonEquipExplMianRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler)Delegate.Remove(dtPylonEquipExplMianRowChangeEventHandler2, value);
						dtPylonEquipExplMianRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler>(ref this.dtPylonEquipExplMianRowChangeEventHandler_0, value2, dtPylonEquipExplMianRowChangeEventHandler2);
					}
					while (dtPylonEquipExplMianRowChangeEventHandler != dtPylonEquipExplMianRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChanged
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler = this.dtPylonEquipExplMianRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler2;
					do
					{
						dtPylonEquipExplMianRowChangeEventHandler2 = dtPylonEquipExplMianRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler)Delegate.Combine(dtPylonEquipExplMianRowChangeEventHandler2, value);
						dtPylonEquipExplMianRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler>(ref this.dtPylonEquipExplMianRowChangeEventHandler_1, value2, dtPylonEquipExplMianRowChangeEventHandler2);
					}
					while (dtPylonEquipExplMianRowChangeEventHandler != dtPylonEquipExplMianRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler = this.dtPylonEquipExplMianRowChangeEventHandler_1;
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler2;
					do
					{
						dtPylonEquipExplMianRowChangeEventHandler2 = dtPylonEquipExplMianRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler)Delegate.Remove(dtPylonEquipExplMianRowChangeEventHandler2, value);
						dtPylonEquipExplMianRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler>(ref this.dtPylonEquipExplMianRowChangeEventHandler_1, value2, dtPylonEquipExplMianRowChangeEventHandler2);
					}
					while (dtPylonEquipExplMianRowChangeEventHandler != dtPylonEquipExplMianRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowDeleting
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler = this.dtPylonEquipExplMianRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler2;
					do
					{
						dtPylonEquipExplMianRowChangeEventHandler2 = dtPylonEquipExplMianRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler)Delegate.Combine(dtPylonEquipExplMianRowChangeEventHandler2, value);
						dtPylonEquipExplMianRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler>(ref this.dtPylonEquipExplMianRowChangeEventHandler_2, value2, dtPylonEquipExplMianRowChangeEventHandler2);
					}
					while (dtPylonEquipExplMianRowChangeEventHandler != dtPylonEquipExplMianRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler = this.dtPylonEquipExplMianRowChangeEventHandler_2;
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler2;
					do
					{
						dtPylonEquipExplMianRowChangeEventHandler2 = dtPylonEquipExplMianRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler)Delegate.Remove(dtPylonEquipExplMianRowChangeEventHandler2, value);
						dtPylonEquipExplMianRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler>(ref this.dtPylonEquipExplMianRowChangeEventHandler_2, value2, dtPylonEquipExplMianRowChangeEventHandler2);
					}
					while (dtPylonEquipExplMianRowChangeEventHandler != dtPylonEquipExplMianRowChangeEventHandler2);
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowDeleted
			{
				[CompilerGenerated]
				add
				{
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler = this.dtPylonEquipExplMianRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler2;
					do
					{
						dtPylonEquipExplMianRowChangeEventHandler2 = dtPylonEquipExplMianRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler)Delegate.Combine(dtPylonEquipExplMianRowChangeEventHandler2, value);
						dtPylonEquipExplMianRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler>(ref this.dtPylonEquipExplMianRowChangeEventHandler_3, value2, dtPylonEquipExplMianRowChangeEventHandler2);
					}
					while (dtPylonEquipExplMianRowChangeEventHandler != dtPylonEquipExplMianRowChangeEventHandler2);
				}
				[CompilerGenerated]
				remove
				{
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler = this.dtPylonEquipExplMianRowChangeEventHandler_3;
					DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler2;
					do
					{
						dtPylonEquipExplMianRowChangeEventHandler2 = dtPylonEquipExplMianRowChangeEventHandler;
						DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler value2 = (DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler)Delegate.Remove(dtPylonEquipExplMianRowChangeEventHandler2, value);
						dtPylonEquipExplMianRowChangeEventHandler = Interlocked.CompareExchange<DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler>(ref this.dtPylonEquipExplMianRowChangeEventHandler_3, value2, dtPylonEquipExplMianRowChangeEventHandler2);
					}
					while (dtPylonEquipExplMianRowChangeEventHandler != dtPylonEquipExplMianRowChangeEventHandler2);
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtPylonEquipExplMianRow(DataSetReportAirLinePassport.dtPylonEquipExplMianRow row)
			{
				base.Rows.Add(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtPylonEquipExplMianRow AdddtPylonEquipExplMianRow(string idDoc, string netRegion, string dateDoc, string idObjList, string ObjList, string idPylon, string Pylon, string idTypeEquip, string TypeEquip)
			{
				DataSetReportAirLinePassport.dtPylonEquipExplMianRow dtPylonEquipExplMianRow = (DataSetReportAirLinePassport.dtPylonEquipExplMianRow)base.NewRow();
				object[] itemArray = new object[]
				{
					idDoc,
					netRegion,
					dateDoc,
					idObjList,
					ObjList,
					idPylon,
					Pylon,
					idTypeEquip,
					TypeEquip
				};
				dtPylonEquipExplMianRow.ItemArray = itemArray;
				base.Rows.Add(dtPylonEquipExplMianRow);
				return dtPylonEquipExplMianRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtPylonEquipExplMianDataTable dtPylonEquipExplMianDataTable = (DataSetReportAirLinePassport.dtPylonEquipExplMianDataTable)base.Clone();
				dtPylonEquipExplMianDataTable.method_0();
				return dtPylonEquipExplMianDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtPylonEquipExplMianDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.dataColumn_0 = base.Columns["idDoc"];
				this.dataColumn_1 = base.Columns["netRegion"];
				this.ftfaGuoqUxV = base.Columns["dateDoc"];
				this.dataColumn_2 = base.Columns["idObjList"];
				this.dataColumn_3 = base.Columns["ObjList"];
				this.dataColumn_4 = base.Columns["idPylon"];
				this.dataColumn_5 = base.Columns["Pylon"];
				this.dataColumn_6 = base.Columns["idTypeEquip"];
				this.dataColumn_7 = base.Columns["TypeEquip"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.dataColumn_0 = new DataColumn("idDoc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("netRegion", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.ftfaGuoqUxV = new DataColumn("dateDoc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.ftfaGuoqUxV);
				this.dataColumn_2 = new DataColumn("idObjList", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("ObjList", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("idPylon", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Pylon", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("idTypeEquip", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("TypeEquip", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtPylonEquipExplMianRow NewdtPylonEquipExplMianRow()
			{
				return (DataSetReportAirLinePassport.dtPylonEquipExplMianRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtPylonEquipExplMianRow(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtPylonEquipExplMianRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.dtPylonEquipExplMianRowChangeEventHandler_1 != null)
				{
					this.dtPylonEquipExplMianRowChangeEventHandler_1(this, new DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEvent((DataSetReportAirLinePassport.dtPylonEquipExplMianRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.dtPylonEquipExplMianRowChangeEventHandler_0 != null)
				{
					this.dtPylonEquipExplMianRowChangeEventHandler_0(this, new DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEvent((DataSetReportAirLinePassport.dtPylonEquipExplMianRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.dtPylonEquipExplMianRowChangeEventHandler_3 != null)
				{
					this.dtPylonEquipExplMianRowChangeEventHandler_3(this, new DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEvent((DataSetReportAirLinePassport.dtPylonEquipExplMianRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.dtPylonEquipExplMianRowChangeEventHandler_2 != null)
				{
					this.dtPylonEquipExplMianRowChangeEventHandler_2(this, new DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEvent((DataSetReportAirLinePassport.dtPylonEquipExplMianRow)e.Row, e.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtPylonEquipExplMianRow(DataSetReportAirLinePassport.dtPylonEquipExplMianRow row)
			{
				base.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
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
				xmlSchemaAttribute.FixedValue = dataSetReportAirLinePassport.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "dtPylonEquipExplMianDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

			private DataColumn ftfaGuoqUxV;

			private DataColumn dataColumn_2;

			private DataColumn dataColumn_3;

			private DataColumn dataColumn_4;

			private DataColumn dataColumn_5;

			private DataColumn dataColumn_6;

			private DataColumn dataColumn_7;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler_0;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler_1;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler_2;

			[CompilerGenerated]
			private DataSetReportAirLinePassport.dtPylonEquipExplMianRowChangeEventHandler dtPylonEquipExplMianRowChangeEventHandler_3;
		}

		public class dtAirLineEquipmentRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtAirLineEquipmentRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtAirLineEquipmentDataTable_0 = (DataSetReportAirLinePassport.dtAirLineEquipmentDataTable)base.Table;
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
						result = (int)base[this.dtAirLineEquipmentDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.idColumn] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.NameColumn] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_0];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ГодУстановки' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_0] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_1];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Стойка' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_1] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_2];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Подкос' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_2] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_3];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Приставка' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_3] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_4];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Тип' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_4] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_5];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Количество' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_5] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_6];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'НаличиеКонтура' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_6] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_7];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Сопротивление' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_7] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_8];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Принадлежность' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_8] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_9];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ТипФундамента' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_9] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_10];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'СхемаПроводовИТросов' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_10] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_11];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Назначение' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_11] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_12];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ТипГирлянды' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_12] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_13];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ДлинаКабеляМ' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_13] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_14];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'МаркаКабеля' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_14] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_15];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ТипКонцевойМуфты' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_15] = value;
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
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_16];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ТипОпоры' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_16] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string PoleNum
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtAirLineEquipmentDataTable_0.PoleNumColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PoleNum' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.PoleNumColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int PoleCount
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtAirLineEquipmentDataTable_0.PoleCountColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PoleCount' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.PoleCountColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_17
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_17];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ВсегоНаЛинии' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_17] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_18
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtAirLineEquipmentDataTable_0.DataColumn_18];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ТипИзолятора' in table 'dtAirLineEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtAirLineEquipmentDataTable_0.DataColumn_18] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidNull()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.idColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidNull()
			{
				base[this.dtAirLineEquipmentDataTable_0.idColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.NameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameNull()
			{
				base[this.dtAirLineEquipmentDataTable_0.NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_0()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_1()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_0] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_2()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_1);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_3()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_4()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_2);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_2] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_3);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_3] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_8()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_4);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_9()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_4] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_10()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_5);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_11()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_5] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_12()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_6);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_13()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_6] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_14()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_7);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_15()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_7] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_16()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_8);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_17()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_8] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_18()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_9);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_9] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_10);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_21()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_10] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_22()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_11);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_23()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_11] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_24()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_12);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_25()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_12] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_26()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_13);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_27()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_13] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_28()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_14);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_29()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_14] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_30()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_15);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_31()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_15] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_32()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_16);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_33()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_16] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsPoleNumNull()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.PoleNumColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPoleNumNull()
			{
				base[this.dtAirLineEquipmentDataTable_0.PoleNumColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPoleCountNull()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.PoleCountColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetPoleCountNull()
			{
				base[this.dtAirLineEquipmentDataTable_0.PoleCountColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_34()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_17);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_35()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_17] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_36()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_18);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_37()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_18] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtAirLineEquipmentDataTable dtAirLineEquipmentDataTable_0;
		}

		public class tp_AirLineReportRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tp_AirLineReportRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.tp_AirLineReportDataTable_0 = (DataSetReportAirLinePassport.tp_AirLineReportDataTable)base.Table;
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
						result = (int)base[this.tp_AirLineReportDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.idColumn] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_0];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Напряжение' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_0] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.NameColumn] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_1];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ГодПостройки' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_1] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_2];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ГодВводаВЭксплуатацию' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_2] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_3];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ИнвентарныйНомер' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_3] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_4];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'НаименованиеПроектирующейОрганизации' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_4] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_5];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'НаименованиеСтроительноМонтажнойОрганизации' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_5] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_6];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ПротяженностьЛинии' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_6] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_7];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ДлинаПролета' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_7] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_8];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'МаркаПровода' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_8] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_9];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ДлинаПроводаОбщая' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_9] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_10];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'РасстояниеМеждуПроводамиВФазе' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_10] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_11];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'МаркаГазотроса' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_11] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_12];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'МаркаТросаОттяжек' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_12] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_13];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'РайонКлиматическихУсловий' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_13] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_14];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ТипПоддерживающегоУстройстваНаВсейЛинии' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_14] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_15];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ТипПоддерживающегоУстройстваНаПереходах' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_15] = value;
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
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_16];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'РасстояниеМеждуДистанционнымиРаспорками' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_16] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_17
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_17];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'КоличествоЦепей' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_17] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_18
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_18];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Регион' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_18] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_19
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_19];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Участок' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_19] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_20
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_20];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'СечениеПровода' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_20] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Number
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tp_AirLineReportDataTable_0.NumberColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Number' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.NumberColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_21
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_21];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Проектирующая' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_21] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string String_22
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_22];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'СтроительноМонтажная' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_22] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string String_23
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tp_AirLineReportDataTable_0.DataColumn_23];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ДатаВводаВЭксплуатацию' in table 'tp_AirLineReport' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tp_AirLineReportDataTable_0.DataColumn_23] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidNull()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.tp_AirLineReportDataTable_0.idColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_0()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_1()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_0] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.NameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameNull()
			{
				base[this.tp_AirLineReportDataTable_0.NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_2()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_1);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_3()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_4()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_2);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_2] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_3);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_3] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_8()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_4);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_9()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_4] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_10()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_5);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_11()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_5] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_12()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_6);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_13()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_6] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_14()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_7);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_15()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_7] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_16()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_8);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_17()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_8] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_18()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_9);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_9] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_20()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_10);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_10] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_22()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_11);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_23()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_11] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_12);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_12] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_26()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_13);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_27()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_13] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_28()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_14);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_29()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_14] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_30()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_15);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_31()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_15] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_32()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_16);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_33()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_16] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_34()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_17);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_35()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_17] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_36()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_18);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_37()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_18] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_38()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_19);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_39()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_19] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_40()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_20);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_41()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_20] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNumberNull()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.NumberColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNumberNull()
			{
				base[this.tp_AirLineReportDataTable_0.NumberColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_42()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_21);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_43()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_21] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_44()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_22);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_45()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_22] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_46()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_23);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_47()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_23] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.tp_AirLineReportDataTable tp_AirLineReportDataTable_0;
		}

		public class dtCrossingRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtCrossingRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtCrossingDataTable_0 = (DataSetReportAirLinePassport.dtCrossingDataTable)base.Table;
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
						result = (int)base[this.dtCrossingDataTable_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'dtCrossing' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCrossingDataTable_0.idObjListColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string CrossingName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtCrossingDataTable_0.CrossingNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CrossingName' in table 'dtCrossing' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCrossingDataTable_0.CrossingNameColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int CountSpans
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtCrossingDataTable_0.CountSpansColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CountSpans' in table 'dtCrossing' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCrossingDataTable_0.CountSpansColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string SpanNumbers
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtCrossingDataTable_0.SpanNumbersColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SpanNumbers' in table 'dtCrossing' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCrossingDataTable_0.SpanNumbersColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idCrossing
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtCrossingDataTable_0.idCrossingColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idCrossing' in table 'dtCrossing' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCrossingDataTable_0.idCrossingColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ShortCrossingName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtCrossingDataTable_0.ShortCrossingNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ShortCrossingName' in table 'dtCrossing' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCrossingDataTable_0.ShortCrossingNameColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string PylonNumbers
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtCrossingDataTable_0.PylonNumbersColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PylonNumbers' in table 'dtCrossing' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCrossingDataTable_0.PylonNumbersColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.dtCrossingDataTable_0.idObjListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidObjListNull()
			{
				base[this.dtCrossingDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsCrossingNameNull()
			{
				return base.IsNull(this.dtCrossingDataTable_0.CrossingNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetCrossingNameNull()
			{
				base[this.dtCrossingDataTable_0.CrossingNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCountSpansNull()
			{
				return base.IsNull(this.dtCrossingDataTable_0.CountSpansColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetCountSpansNull()
			{
				base[this.dtCrossingDataTable_0.CountSpansColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsSpanNumbersNull()
			{
				return base.IsNull(this.dtCrossingDataTable_0.SpanNumbersColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSpanNumbersNull()
			{
				base[this.dtCrossingDataTable_0.SpanNumbersColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidCrossingNull()
			{
				return base.IsNull(this.dtCrossingDataTable_0.idCrossingColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidCrossingNull()
			{
				base[this.dtCrossingDataTable_0.idCrossingColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsShortCrossingNameNull()
			{
				return base.IsNull(this.dtCrossingDataTable_0.ShortCrossingNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetShortCrossingNameNull()
			{
				base[this.dtCrossingDataTable_0.ShortCrossingNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPylonNumbersNull()
			{
				return base.IsNull(this.dtCrossingDataTable_0.PylonNumbersColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPylonNumbersNull()
			{
				base[this.dtCrossingDataTable_0.PylonNumbersColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtCrossingDataTable dtCrossingDataTable_0;
		}

		public class dtTerrainRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtTerrainRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtTerrainDataTable_0 = (DataSetReportAirLinePassport.dtTerrainDataTable)base.Table;
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
						result = (int)base[this.dtTerrainDataTable_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'dtTerrain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtTerrainDataTable_0.idObjListColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTerrain
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtTerrainDataTable_0.idTerrainColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idTerrain' in table 'dtTerrain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtTerrainDataTable_0.idTerrainColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string TerrainName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtTerrainDataTable_0.TerrainNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TerrainName' in table 'dtTerrain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtTerrainDataTable_0.TerrainNameColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string SpanNumbers
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtTerrainDataTable_0.SpanNumbersColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SpanNumbers' in table 'dtTerrain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtTerrainDataTable_0.SpanNumbersColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string FullLength
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtTerrainDataTable_0.FullLengthColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'FullLength' in table 'dtTerrain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtTerrainDataTable_0.FullLengthColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string PylonNumbers
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtTerrainDataTable_0.PylonNumbersColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PylonNumbers' in table 'dtTerrain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtTerrainDataTable_0.PylonNumbersColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.dtTerrainDataTable_0.idObjListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidObjListNull()
			{
				base[this.dtTerrainDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidTerrainNull()
			{
				return base.IsNull(this.dtTerrainDataTable_0.idTerrainColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidTerrainNull()
			{
				base[this.dtTerrainDataTable_0.idTerrainColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsTerrainNameNull()
			{
				return base.IsNull(this.dtTerrainDataTable_0.TerrainNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetTerrainNameNull()
			{
				base[this.dtTerrainDataTable_0.TerrainNameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsSpanNumbersNull()
			{
				return base.IsNull(this.dtTerrainDataTable_0.SpanNumbersColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSpanNumbersNull()
			{
				base[this.dtTerrainDataTable_0.SpanNumbersColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsFullLengthNull()
			{
				return base.IsNull(this.dtTerrainDataTable_0.FullLengthColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetFullLengthNull()
			{
				base[this.dtTerrainDataTable_0.FullLengthColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPylonNumbersNull()
			{
				return base.IsNull(this.dtTerrainDataTable_0.PylonNumbersColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPylonNumbersNull()
			{
				base[this.dtTerrainDataTable_0.PylonNumbersColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtTerrainDataTable dtTerrainDataTable_0;
		}

		public class dsCountPoleRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dsCountPoleRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dsCountPoleDataTable_0 = (DataSetReportAirLinePassport.dsCountPoleDataTable)base.Table;
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
						result = (int)base[this.dsCountPoleDataTable_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'dsCountPole' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dsCountPoleDataTable_0.idObjListColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Konc
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dsCountPoleDataTable_0.KoncColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Konc' in table 'dsCountPole' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dsCountPoleDataTable_0.KoncColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Otv
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dsCountPoleDataTable_0.OtvColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Otv' in table 'dsCountPole' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dsCountPoleDataTable_0.OtvColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Ugl
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dsCountPoleDataTable_0.UglColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Ugl' in table 'dsCountPole' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dsCountPoleDataTable_0.UglColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Prom
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dsCountPoleDataTable_0.PromColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Prom' in table 'dsCountPole' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dsCountPoleDataTable_0.PromColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.dsCountPoleDataTable_0.idObjListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidObjListNull()
			{
				base[this.dsCountPoleDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsKoncNull()
			{
				return base.IsNull(this.dsCountPoleDataTable_0.KoncColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetKoncNull()
			{
				base[this.dsCountPoleDataTable_0.KoncColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsOtvNull()
			{
				return base.IsNull(this.dsCountPoleDataTable_0.OtvColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetOtvNull()
			{
				base[this.dsCountPoleDataTable_0.OtvColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsUglNull()
			{
				return base.IsNull(this.dsCountPoleDataTable_0.UglColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetUglNull()
			{
				base[this.dsCountPoleDataTable_0.UglColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPromNull()
			{
				return base.IsNull(this.dsCountPoleDataTable_0.PromColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetPromNull()
			{
				base[this.dsCountPoleDataTable_0.PromColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dsCountPoleDataTable dsCountPoleDataTable_0;
		}

		public class dtBranchRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtBranchRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtBranchDataTable_0 = (DataSetReportAirLinePassport.dtBranchDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string PoleNum
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtBranchDataTable_0.PoleNumColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PoleNum' in table 'dtBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtBranchDataTable_0.PoleNumColumn] = value;
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
						result = (string)base[this.dtBranchDataTable_0.DataColumn_0];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ДлинаОтветвленияМ' in table 'dtBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtBranchDataTable_0.DataColumn_0] = value;
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
						result = (string)base[this.dtBranchDataTable_0.DataColumn_1];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ЧислоВводов' in table 'dtBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtBranchDataTable_0.DataColumn_1] = value;
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
						result = (string)base[this.dtBranchDataTable_0.DataColumn_2];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ТипПровода' in table 'dtBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtBranchDataTable_0.DataColumn_2] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsPoleNumNull()
			{
				return base.IsNull(this.dtBranchDataTable_0.PoleNumColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPoleNumNull()
			{
				base[this.dtBranchDataTable_0.PoleNumColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_0()
			{
				return base.IsNull(this.dtBranchDataTable_0.DataColumn_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_1()
			{
				base[this.dtBranchDataTable_0.DataColumn_0] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_2()
			{
				return base.IsNull(this.dtBranchDataTable_0.DataColumn_1);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_3()
			{
				base[this.dtBranchDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_4()
			{
				return base.IsNull(this.dtBranchDataTable_0.DataColumn_2);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5()
			{
				base[this.dtBranchDataTable_0.DataColumn_2] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtBranchDataTable dtBranchDataTable_0;
		}

		public class dtCableInsertionRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtCableInsertionRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtCableInsertionDataTable_0 = (DataSetReportAirLinePassport.dtCableInsertionDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string PoleNum
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtCableInsertionDataTable_0.PoleNumColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PoleNum' in table 'dtCableInsertion' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCableInsertionDataTable_0.PoleNumColumn] = value;
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
						result = (string)base[this.dtCableInsertionDataTable_0.DataColumn_0];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Назначение' in table 'dtCableInsertion' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCableInsertionDataTable_0.DataColumn_0] = value;
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
						result = (string)base[this.dtCableInsertionDataTable_0.DataColumn_1];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ДлинаКабеляМ' in table 'dtCableInsertion' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCableInsertionDataTable_0.DataColumn_1] = value;
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
						result = (string)base[this.dtCableInsertionDataTable_0.DataColumn_2];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'МаркаКабеля' in table 'dtCableInsertion' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCableInsertionDataTable_0.DataColumn_2] = value;
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
						result = (string)base[this.dtCableInsertionDataTable_0.DataColumn_3];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ТипКонцевойМуфты' in table 'dtCableInsertion' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCableInsertionDataTable_0.DataColumn_3] = value;
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
						result = (string)base[this.dtCableInsertionDataTable_0.DataColumn_4];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ТипСоединительнойМуфты' in table 'dtCableInsertion' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtCableInsertionDataTable_0.DataColumn_4] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPoleNumNull()
			{
				return base.IsNull(this.dtCableInsertionDataTable_0.PoleNumColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetPoleNumNull()
			{
				base[this.dtCableInsertionDataTable_0.PoleNumColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_0()
			{
				return base.IsNull(this.dtCableInsertionDataTable_0.DataColumn_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_1()
			{
				base[this.dtCableInsertionDataTable_0.DataColumn_0] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_2()
			{
				return base.IsNull(this.dtCableInsertionDataTable_0.DataColumn_1);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_3()
			{
				base[this.dtCableInsertionDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_4()
			{
				return base.IsNull(this.dtCableInsertionDataTable_0.DataColumn_2);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5()
			{
				base[this.dtCableInsertionDataTable_0.DataColumn_2] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.dtCableInsertionDataTable_0.DataColumn_3);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7()
			{
				base[this.dtCableInsertionDataTable_0.DataColumn_3] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_8()
			{
				return base.IsNull(this.dtCableInsertionDataTable_0.DataColumn_4);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_9()
			{
				base[this.dtCableInsertionDataTable_0.DataColumn_4] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtCableInsertionDataTable dtCableInsertionDataTable_0;
		}

		public class dtPylonEquipmentRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtPylonEquipmentRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtPylonEquipmentDataTable_0 = (DataSetReportAirLinePassport.dtPylonEquipmentDataTable)base.Table;
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
						result = (string)base[this.dtPylonEquipmentDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtPylonEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipmentDataTable_0.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string TypeEquipment
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonEquipmentDataTable_0.TypeEquipmentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TypeEquipment' in table 'dtPylonEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipmentDataTable_0.TypeEquipmentColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Count
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonEquipmentDataTable_0.CountColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Count' in table 'dtPylonEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipmentDataTable_0.CountColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string PoleNum
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonEquipmentDataTable_0.PoleNumColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PoleNum' in table 'dtPylonEquipment' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipmentDataTable_0.PoleNumColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtPylonEquipmentDataTable_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.dtPylonEquipmentDataTable_0.NameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsTypeEquipmentNull()
			{
				return base.IsNull(this.dtPylonEquipmentDataTable_0.TypeEquipmentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTypeEquipmentNull()
			{
				base[this.dtPylonEquipmentDataTable_0.TypeEquipmentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsCountNull()
			{
				return base.IsNull(this.dtPylonEquipmentDataTable_0.CountColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetCountNull()
			{
				base[this.dtPylonEquipmentDataTable_0.CountColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPoleNumNull()
			{
				return base.IsNull(this.dtPylonEquipmentDataTable_0.PoleNumColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPoleNumNull()
			{
				base[this.dtPylonEquipmentDataTable_0.PoleNumColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtPylonEquipmentDataTable dtPylonEquipmentDataTable_0;
		}

		public class dtJointSuspensionRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtJointSuspensionRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtJointSuspensionDataTable_0 = (DataSetReportAirLinePassport.dtJointSuspensionDataTable)base.Table;
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
						result = (string)base[this.dtJointSuspensionDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtJointSuspension' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtJointSuspensionDataTable_0.NameColumn] = value;
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
						result = (string)base[this.dtJointSuspensionDataTable_0.DataColumn_0];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Напряжение' in table 'dtJointSuspension' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtJointSuspensionDataTable_0.DataColumn_0] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string PoleNum
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtJointSuspensionDataTable_0.PoleNumColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PoleNum' in table 'dtJointSuspension' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtJointSuspensionDataTable_0.PoleNumColumn] = value;
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
						result = (string)base[this.dtJointSuspensionDataTable_0.DataColumn_1];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'МаркаКабеля' in table 'dtJointSuspension' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtJointSuspensionDataTable_0.DataColumn_1] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string WireDistance
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtJointSuspensionDataTable_0.WireDistanceColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'WireDistance' in table 'dtJointSuspension' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtJointSuspensionDataTable_0.WireDistanceColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtJointSuspensionDataTable_0.NameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameNull()
			{
				base[this.dtJointSuspensionDataTable_0.NameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_0()
			{
				return base.IsNull(this.dtJointSuspensionDataTable_0.DataColumn_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_1()
			{
				base[this.dtJointSuspensionDataTable_0.DataColumn_0] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsPoleNumNull()
			{
				return base.IsNull(this.dtJointSuspensionDataTable_0.PoleNumColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetPoleNumNull()
			{
				base[this.dtJointSuspensionDataTable_0.PoleNumColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_2()
			{
				return base.IsNull(this.dtJointSuspensionDataTable_0.DataColumn_1);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_3()
			{
				base[this.dtJointSuspensionDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsWireDistanceNull()
			{
				return base.IsNull(this.dtJointSuspensionDataTable_0.WireDistanceColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetWireDistanceNull()
			{
				base[this.dtJointSuspensionDataTable_0.WireDistanceColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtJointSuspensionDataTable dtJointSuspensionDataTable_0;
		}

		public class tBranchRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tBranchRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.tBranchDataTable_0 = (DataSetReportAirLinePassport.tBranchDataTable)base.Table;
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
						result = (int)base[this.tBranchDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'tBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tBranchDataTable_0.idColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idAirLine
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tBranchDataTable_0.idAirLineColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idAirLine' in table 'tBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tBranchDataTable_0.idAirLineColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idPole
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tBranchDataTable_0.idPoleColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idPole' in table 'tBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tBranchDataTable_0.idPoleColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idObj
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tBranchDataTable_0.idObjColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObj' in table 'tBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tBranchDataTable_0.idObjColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string PoleName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tBranchDataTable_0.PoleNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PoleName' in table 'tBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tBranchDataTable_0.PoleNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ObjName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tBranchDataTable_0.ObjNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ObjName' in table 'tBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tBranchDataTable_0.ObjNameColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string cableType
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tBranchDataTable_0.cableTypeColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'cableType' in table 'tBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tBranchDataTable_0.cableTypeColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string cableLength
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tBranchDataTable_0.cableLengthColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'cableLength' in table 'tBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tBranchDataTable_0.cableLengthColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Count
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tBranchDataTable_0.CountColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Count' in table 'tBranch' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tBranchDataTable_0.CountColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidNull()
			{
				return base.IsNull(this.tBranchDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.tBranchDataTable_0.idColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidAirLineNull()
			{
				return base.IsNull(this.tBranchDataTable_0.idAirLineColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidAirLineNull()
			{
				base[this.tBranchDataTable_0.idAirLineColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidPoleNull()
			{
				return base.IsNull(this.tBranchDataTable_0.idPoleColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidPoleNull()
			{
				base[this.tBranchDataTable_0.idPoleColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidObjNull()
			{
				return base.IsNull(this.tBranchDataTable_0.idObjColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidObjNull()
			{
				base[this.tBranchDataTable_0.idObjColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsPoleNameNull()
			{
				return base.IsNull(this.tBranchDataTable_0.PoleNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetPoleNameNull()
			{
				base[this.tBranchDataTable_0.PoleNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsObjNameNull()
			{
				return base.IsNull(this.tBranchDataTable_0.ObjNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetObjNameNull()
			{
				base[this.tBranchDataTable_0.ObjNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IscableTypeNull()
			{
				return base.IsNull(this.tBranchDataTable_0.cableTypeColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetcableTypeNull()
			{
				base[this.tBranchDataTable_0.cableTypeColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IscableLengthNull()
			{
				return base.IsNull(this.tBranchDataTable_0.cableLengthColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetcableLengthNull()
			{
				base[this.tBranchDataTable_0.cableLengthColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCountNull()
			{
				return base.IsNull(this.tBranchDataTable_0.CountColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCountNull()
			{
				base[this.tBranchDataTable_0.CountColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.tBranchDataTable tBranchDataTable_0;
		}

		public class dtPylonsRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtPylonsRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtPylonsDataTable_0 = (DataSetReportAirLinePassport.dtPylonsDataTable)base.Table;
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
						result = (int)base[this.dtPylonsDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.idColumn] = value;
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
						result = (string)base[this.dtPylonsDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.NameColumn] = value;
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
						result = (string)base[this.dtPylonsDataTable_0.DataColumn_0];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Тип' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.DataColumn_0] = value;
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
						result = (string)base[this.dtPylonsDataTable_0.DataColumn_1];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Принадлежность' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.DataColumn_1] = value;
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
						result = (string)base[this.dtPylonsDataTable_0.DataColumn_2];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ГодУстановки' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.DataColumn_2] = value;
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
						result = (string)base[this.dtPylonsDataTable_0.DataColumn_3];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Стойка' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.DataColumn_3] = value;
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
						result = (string)base[this.dtPylonsDataTable_0.DataColumn_4];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Подкос' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.DataColumn_4] = value;
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
						result = (string)base[this.dtPylonsDataTable_0.DataColumn_5];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Приставка' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.DataColumn_5] = value;
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
						result = (string)base[this.dtPylonsDataTable_0.DataColumn_6];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ТипИзолятора' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.DataColumn_6] = value;
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
						result = (string)base[this.dtPylonsDataTable_0.DataColumn_7];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Количество' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.DataColumn_7] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal SpanLength
			{
				get
				{
					decimal result;
					try
					{
						result = (decimal)base[this.dtPylonsDataTable_0.SpanLengthColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'SpanLength' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.SpanLengthColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string CableMakeUp
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonsDataTable_0.CableMakeUpColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'CableMakeUp' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.CableMakeUpColumn] = value;
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
						result = (string)base[this.dtPylonsDataTable_0.DataColumn_8];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'НаличиеКонтура' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.DataColumn_8] = value;
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
						result = (string)base[this.dtPylonsDataTable_0.DataColumn_9];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Сопротивление' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.DataColumn_9] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string EquipmentList
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonsDataTable_0.EquipmentListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'EquipmentList' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.EquipmentListColumn] = value;
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
						result = (string)base[this.dtPylonsDataTable_0.typeNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'typeName' in table 'dtPylons' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonsDataTable_0.typeNameColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidNull()
			{
				return base.IsNull(this.dtPylonsDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.dtPylonsDataTable_0.idColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtPylonsDataTable_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.dtPylonsDataTable_0.NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_0()
			{
				return base.IsNull(this.dtPylonsDataTable_0.DataColumn_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_1()
			{
				base[this.dtPylonsDataTable_0.DataColumn_0] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_2()
			{
				return base.IsNull(this.dtPylonsDataTable_0.DataColumn_1);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_3()
			{
				base[this.dtPylonsDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_4()
			{
				return base.IsNull(this.dtPylonsDataTable_0.DataColumn_2);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5()
			{
				base[this.dtPylonsDataTable_0.DataColumn_2] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.dtPylonsDataTable_0.DataColumn_3);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7()
			{
				base[this.dtPylonsDataTable_0.DataColumn_3] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_8()
			{
				return base.IsNull(this.dtPylonsDataTable_0.DataColumn_4);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_9()
			{
				base[this.dtPylonsDataTable_0.DataColumn_4] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_10()
			{
				return base.IsNull(this.dtPylonsDataTable_0.DataColumn_5);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_11()
			{
				base[this.dtPylonsDataTable_0.DataColumn_5] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_12()
			{
				return base.IsNull(this.dtPylonsDataTable_0.DataColumn_6);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_13()
			{
				base[this.dtPylonsDataTable_0.DataColumn_6] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_14()
			{
				return base.IsNull(this.dtPylonsDataTable_0.DataColumn_7);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_15()
			{
				base[this.dtPylonsDataTable_0.DataColumn_7] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsSpanLengthNull()
			{
				return base.IsNull(this.dtPylonsDataTable_0.SpanLengthColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSpanLengthNull()
			{
				base[this.dtPylonsDataTable_0.SpanLengthColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsCableMakeUpNull()
			{
				return base.IsNull(this.dtPylonsDataTable_0.CableMakeUpColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetCableMakeUpNull()
			{
				base[this.dtPylonsDataTable_0.CableMakeUpColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_16()
			{
				return base.IsNull(this.dtPylonsDataTable_0.DataColumn_8);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_17()
			{
				base[this.dtPylonsDataTable_0.DataColumn_8] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_18()
			{
				return base.IsNull(this.dtPylonsDataTable_0.DataColumn_9);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_19()
			{
				base[this.dtPylonsDataTable_0.DataColumn_9] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsEquipmentListNull()
			{
				return base.IsNull(this.dtPylonsDataTable_0.EquipmentListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetEquipmentListNull()
			{
				base[this.dtPylonsDataTable_0.EquipmentListColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IstypeNameNull()
			{
				return base.IsNull(this.dtPylonsDataTable_0.typeNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SettypeNameNull()
			{
				base[this.dtPylonsDataTable_0.typeNameColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtPylonsDataTable dtPylonsDataTable_0;
		}

		public class dtRoadRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtRoadRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtRoadDataTable_0 = (DataSetReportAirLinePassport.dtRoadDataTable)base.Table;
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
						result = (int)base[this.dtRoadDataTable_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'dtRoad' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtRoadDataTable_0.idObjListColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idRoadType
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtRoadDataTable_0.idRoadTypeColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idRoadType' in table 'dtRoad' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtRoadDataTable_0.idRoadTypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string RoadName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtRoadDataTable_0.RoadNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'RoadName' in table 'dtRoad' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtRoadDataTable_0.RoadNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string PylonNumbers
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtRoadDataTable_0.PylonNumbersColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'PylonNumbers' in table 'dtRoad' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtRoadDataTable_0.PylonNumbersColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Characteristic
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtRoadDataTable_0.CharacteristicColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Characteristic' in table 'dtRoad' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtRoadDataTable_0.CharacteristicColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.dtRoadDataTable_0.idObjListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidObjListNull()
			{
				base[this.dtRoadDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidRoadTypeNull()
			{
				return base.IsNull(this.dtRoadDataTable_0.idRoadTypeColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidRoadTypeNull()
			{
				base[this.dtRoadDataTable_0.idRoadTypeColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsRoadNameNull()
			{
				return base.IsNull(this.dtRoadDataTable_0.RoadNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetRoadNameNull()
			{
				base[this.dtRoadDataTable_0.RoadNameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsPylonNumbersNull()
			{
				return base.IsNull(this.dtRoadDataTable_0.PylonNumbersColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetPylonNumbersNull()
			{
				base[this.dtRoadDataTable_0.PylonNumbersColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsCharacteristicNull()
			{
				return base.IsNull(this.dtRoadDataTable_0.CharacteristicColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetCharacteristicNull()
			{
				base[this.dtRoadDataTable_0.CharacteristicColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtRoadDataTable dtRoadDataTable_0;
		}

		public class vDocAirLineRepairRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal vDocAirLineRepairRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.vDocAirLineRepairDataTable_0 = (DataSetReportAirLinePassport.vDocAirLineRepairDataTable)base.Table;
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
						result = (int)base[this.vDocAirLineRepairDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.idColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int ParentId
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vDocAirLineRepairDataTable_0.ParentIdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ParentId' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.ParentIdColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string numberDoc
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocAirLineRepairDataTable_0.numberDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'numberDoc' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.numberDocColumn] = value;
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
						result = (DateTime)base[this.vDocAirLineRepairDataTable_0.dateDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'dateDoc' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.dateDocColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int typeDoc
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vDocAirLineRepairDataTable_0.typeDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'typeDoc' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.typeDocColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idReason
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vDocAirLineRepairDataTable_0.idReasonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idReason' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.idReasonColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string reason
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocAirLineRepairDataTable_0.reasonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'reason' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.reasonColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string From
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocAirLineRepairDataTable_0.FromColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'From' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.FromColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string To
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocAirLineRepairDataTable_0.ToColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'To' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.ToColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dateStartUp
			{
				get
				{
					DateTime result;
					try
					{
						result = (DateTime)base[this.vDocAirLineRepairDataTable_0.dateStartUpColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'dateStartUp' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.dateStartUpColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string comment
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocAirLineRepairDataTable_0.commentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'comment' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.commentColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string typeDocName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocAirLineRepairDataTable_0.typeDocNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'typeDocName' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.typeDocNameColumn] = value;
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
						result = (int)base[this.vDocAirLineRepairDataTable_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'vDocAirLineRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocAirLineRepairDataTable_0.idObjListColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.vDocAirLineRepairDataTable_0.idColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsParentIdNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.ParentIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetParentIdNull()
			{
				base[this.vDocAirLineRepairDataTable_0.ParentIdColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsnumberDocNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.numberDocColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetnumberDocNull()
			{
				base[this.vDocAirLineRepairDataTable_0.numberDocColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdateDocNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.dateDocColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdateDocNull()
			{
				base[this.vDocAirLineRepairDataTable_0.dateDocColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IstypeDocNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.typeDocColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SettypeDocNull()
			{
				base[this.vDocAirLineRepairDataTable_0.typeDocColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidReasonNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.idReasonColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidReasonNull()
			{
				base[this.vDocAirLineRepairDataTable_0.idReasonColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsreasonNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.reasonColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetreasonNull()
			{
				base[this.vDocAirLineRepairDataTable_0.reasonColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsFromNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.FromColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetFromNull()
			{
				base[this.vDocAirLineRepairDataTable_0.FromColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsToNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.ToColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetToNull()
			{
				base[this.vDocAirLineRepairDataTable_0.ToColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsdateStartUpNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.dateStartUpColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetdateStartUpNull()
			{
				base[this.vDocAirLineRepairDataTable_0.dateStartUpColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IscommentNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.commentColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetcommentNull()
			{
				base[this.vDocAirLineRepairDataTable_0.commentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IstypeDocNameNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.typeDocNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SettypeDocNameNull()
			{
				base[this.vDocAirLineRepairDataTable_0.typeDocNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.vDocAirLineRepairDataTable_0.idObjListColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidObjListNull()
			{
				base[this.vDocAirLineRepairDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.vDocAirLineRepairDataTable vDocAirLineRepairDataTable_0;
		}

		public class vDocPylonEquipRepairRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal vDocPylonEquipRepairRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.vDocPylonEquipRepairDataTable_0 = (DataSetReportAirLinePassport.vDocPylonEquipRepairDataTable)base.Table;
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
						result = (int)base[this.vDocPylonEquipRepairDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.idColumn] = value;
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
						result = (int)base[this.vDocPylonEquipRepairDataTable_0.ParentIdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ParentId' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.ParentIdColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string numberDoc
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocPylonEquipRepairDataTable_0.numberDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'numberDoc' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.numberDocColumn] = value;
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
						result = (DateTime)base[this.vDocPylonEquipRepairDataTable_0.dateDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'dateDoc' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.dateDocColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int typeDoc
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vDocPylonEquipRepairDataTable_0.typeDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'typeDoc' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.typeDocColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string typeDocName
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocPylonEquipRepairDataTable_0.typeDocNameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'typeDocName' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.typeDocNameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idTypeWork
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vDocPylonEquipRepairDataTable_0.idTypeWorkColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idTypeWork' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.idTypeWorkColumn] = value;
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
						result = (int)base[this.vDocPylonEquipRepairDataTable_0.idReasonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idReason' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.idReasonColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idPylon
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vDocPylonEquipRepairDataTable_0.idPylonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idPylon' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.idPylonColumn] = value;
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
						result = (int)base[this.vDocPylonEquipRepairDataTable_0.idEquipmentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idEquipment' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.idEquipmentColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string typeWork
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocPylonEquipRepairDataTable_0.typeWorkColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'typeWork' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.typeWorkColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string reason
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocPylonEquipRepairDataTable_0.reasonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'reason' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.reasonColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string pylon
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocPylonEquipRepairDataTable_0.pylonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'pylon' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.pylonColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string equipment
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocPylonEquipRepairDataTable_0.equipmentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'equipment' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.equipmentColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string comment
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vDocPylonEquipRepairDataTable_0.commentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'comment' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.commentColumn] = value;
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
						result = (int)base[this.vDocPylonEquipRepairDataTable_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'vDocPylonEquipRepair' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vDocPylonEquipRepairDataTable_0.idObjListColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.idColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsParentIdNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.ParentIdColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetParentIdNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.ParentIdColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsnumberDocNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.numberDocColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetnumberDocNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.numberDocColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdateDocNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.dateDocColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetdateDocNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.dateDocColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IstypeDocNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.typeDocColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SettypeDocNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.typeDocColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IstypeDocNameNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.typeDocNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SettypeDocNameNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.typeDocNameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidTypeWorkNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.idTypeWorkColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidTypeWorkNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.idTypeWorkColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidReasonNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.idReasonColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidReasonNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.idReasonColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidPylonNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.idPylonColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidPylonNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.idPylonColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidEquipmentNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.idEquipmentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidEquipmentNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.idEquipmentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IstypeWorkNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.typeWorkColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SettypeWorkNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.typeWorkColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsreasonNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.reasonColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetreasonNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.reasonColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IspylonNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.pylonColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetpylonNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.pylonColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsequipmentNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.equipmentColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetequipmentNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.equipmentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IscommentNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.commentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetcommentNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.commentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.vDocPylonEquipRepairDataTable_0.idObjListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidObjListNull()
			{
				base[this.vDocPylonEquipRepairDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.vDocPylonEquipRepairDataTable vDocPylonEquipRepairDataTable_0;
		}

		public class tSettingsRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tSettingsRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.tSettingsDataTable_0 = (DataSetReportAirLinePassport.tSettingsDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int id
			{
				get
				{
					return (int)base[this.tSettingsDataTable_0.idColumn];
				}
				set
				{
					base[this.tSettingsDataTable_0.idColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string HostIp
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tSettingsDataTable_0.HostIpColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'HostIp' in table 'tSettings' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tSettingsDataTable_0.HostIpColumn] = value;
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
						result = (string)base[this.tSettingsDataTable_0.SettingsColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Settings' in table 'tSettings' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tSettingsDataTable_0.SettingsColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Module
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tSettingsDataTable_0.ModuleColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Module' in table 'tSettings' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tSettingsDataTable_0.ModuleColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsHostIpNull()
			{
				return base.IsNull(this.tSettingsDataTable_0.HostIpColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetHostIpNull()
			{
				base[this.tSettingsDataTable_0.HostIpColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsSettingsNull()
			{
				return base.IsNull(this.tSettingsDataTable_0.SettingsColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetSettingsNull()
			{
				base[this.tSettingsDataTable_0.SettingsColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsModuleNull()
			{
				return base.IsNull(this.tSettingsDataTable_0.ModuleColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetModuleNull()
			{
				base[this.tSettingsDataTable_0.ModuleColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.tSettingsDataTable tSettingsDataTable_0;
		}

		public class dtReportAirLineRepairMainRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtReportAirLineRepairMainRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtReportAirLineRepairMainDataTable_0 = (DataSetReportAirLinePassport.dtReportAirLineRepairMainDataTable)base.Table;
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
						result = (int)base[this.dtReportAirLineRepairMainDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.idColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int ParentId
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtReportAirLineRepairMainDataTable_0.ParentIdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ParentId' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.ParentIdColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string numberDoc
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairMainDataTable_0.numberDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'numberDoc' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.numberDocColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string dateDoc
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairMainDataTable_0.dateDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'dateDoc' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.dateDocColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string comment
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairMainDataTable_0.commentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'comment' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.commentColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idHeadNetRegion
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtReportAirLineRepairMainDataTable_0.idHeadNetRegionColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idHeadNetRegion' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.idHeadNetRegionColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idEngineerPTS
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtReportAirLineRepairMainDataTable_0.idEngineerPTSColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idEngineerPTS' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.idEngineerPTSColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Length
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairMainDataTable_0.LengthColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Length' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.LengthColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string From
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairMainDataTable_0.FromColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'From' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.FromColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string To
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairMainDataTable_0.ToColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'To' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.ToColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string treeCount
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairMainDataTable_0.treeCountColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'treeCount' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.treeCountColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string postHeadRegion
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairMainDataTable_0.postHeadRegionColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'postHeadRegion' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.postHeadRegionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string nameHeadRegion
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairMainDataTable_0.nameHeadRegionColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'nameHeadRegion' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.nameHeadRegionColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string postEngineerPTS
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairMainDataTable_0.postEngineerPTSColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'postEngineerPTS' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.postEngineerPTSColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string nameEngineerPTS
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairMainDataTable_0.nameEngineerPTSColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'nameEngineerPTS' in table 'dtReportAirLineRepairMain' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairMainDataTable_0.nameEngineerPTSColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.idColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsParentIdNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.ParentIdColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetParentIdNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.ParentIdColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsnumberDocNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.numberDocColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetnumberDocNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.numberDocColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsdateDocNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.dateDocColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetdateDocNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.dateDocColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IscommentNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.commentColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetcommentNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.commentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidHeadNetRegionNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.idHeadNetRegionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidHeadNetRegionNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.idHeadNetRegionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidEngineerPTSNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.idEngineerPTSColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidEngineerPTSNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.idEngineerPTSColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsLengthNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.LengthColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetLengthNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.LengthColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsFromNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.FromColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetFromNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.FromColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsToNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.ToColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetToNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.ToColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IstreeCountNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.treeCountColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SettreeCountNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.treeCountColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IspostHeadRegionNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.postHeadRegionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetpostHeadRegionNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.postHeadRegionColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsnameHeadRegionNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.nameHeadRegionColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetnameHeadRegionNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.nameHeadRegionColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IspostEngineerPTSNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.postEngineerPTSColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetpostEngineerPTSNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.postEngineerPTSColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsnameEngineerPTSNull()
			{
				return base.IsNull(this.dtReportAirLineRepairMainDataTable_0.nameEngineerPTSColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetnameEngineerPTSNull()
			{
				base[this.dtReportAirLineRepairMainDataTable_0.nameEngineerPTSColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtReportAirLineRepairMainDataTable dtReportAirLineRepairMainDataTable_0;
		}

		public class dtReportAirLineRepairWorkRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtReportAirLineRepairWorkRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtReportAirLineRepairWorkDataTable_0 = (DataSetReportAirLinePassport.dtReportAirLineRepairWorkDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idDoc
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtReportAirLineRepairWorkDataTable_0.idDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idDoc' in table 'dtReportAirLineRepairWork' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairWorkDataTable_0.idDocColumn] = value;
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
						result = (string)base[this.dtReportAirLineRepairWorkDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtReportAirLineRepairWork' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairWorkDataTable_0.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Unit
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairWorkDataTable_0.UnitColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Unit' in table 'dtReportAirLineRepairWork' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairWorkDataTable_0.UnitColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Count
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairWorkDataTable_0.CountColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Count' in table 'dtReportAirLineRepairWork' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairWorkDataTable_0.CountColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idPylon
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtReportAirLineRepairWorkDataTable_0.idPylonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idPylon' in table 'dtReportAirLineRepairWork' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairWorkDataTable_0.idPylonColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Pylon
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtReportAirLineRepairWorkDataTable_0.PylonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Pylon' in table 'dtReportAirLineRepairWork' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairWorkDataTable_0.PylonColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidDocNull()
			{
				return base.IsNull(this.dtReportAirLineRepairWorkDataTable_0.idDocColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidDocNull()
			{
				base[this.dtReportAirLineRepairWorkDataTable_0.idDocColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtReportAirLineRepairWorkDataTable_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.dtReportAirLineRepairWorkDataTable_0.NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsUnitNull()
			{
				return base.IsNull(this.dtReportAirLineRepairWorkDataTable_0.UnitColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetUnitNull()
			{
				base[this.dtReportAirLineRepairWorkDataTable_0.UnitColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsCountNull()
			{
				return base.IsNull(this.dtReportAirLineRepairWorkDataTable_0.CountColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetCountNull()
			{
				base[this.dtReportAirLineRepairWorkDataTable_0.CountColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidPylonNull()
			{
				return base.IsNull(this.dtReportAirLineRepairWorkDataTable_0.idPylonColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidPylonNull()
			{
				base[this.dtReportAirLineRepairWorkDataTable_0.idPylonColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsPylonNull()
			{
				return base.IsNull(this.dtReportAirLineRepairWorkDataTable_0.PylonColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPylonNull()
			{
				base[this.dtReportAirLineRepairWorkDataTable_0.PylonColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtReportAirLineRepairWorkDataTable dtReportAirLineRepairWorkDataTable_0;
		}

		public class dtReportAirLineRepairAddressRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtReportAirLineRepairAddressRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtReportAirLineRepairAddressDataTable_0 = (DataSetReportAirLinePassport.dtReportAirLineRepairAddressDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idDoc
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtReportAirLineRepairAddressDataTable_0.idDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idDoc' in table 'dtReportAirLineRepairAddress' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairAddressDataTable_0.idDocColumn] = value;
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
						result = (int)base[this.dtReportAirLineRepairAddressDataTable_0.ParentIdColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ParentId' in table 'dtReportAirLineRepairAddress' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairAddressDataTable_0.ParentIdColumn] = value;
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
						result = (int)base[this.dtReportAirLineRepairAddressDataTable_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'dtReportAirLineRepairAddress' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairAddressDataTable_0.idObjListColumn] = value;
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
						result = (string)base[this.dtReportAirLineRepairAddressDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtReportAirLineRepairAddress' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtReportAirLineRepairAddressDataTable_0.NameColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidDocNull()
			{
				return base.IsNull(this.dtReportAirLineRepairAddressDataTable_0.idDocColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidDocNull()
			{
				base[this.dtReportAirLineRepairAddressDataTable_0.idDocColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsParentIdNull()
			{
				return base.IsNull(this.dtReportAirLineRepairAddressDataTable_0.ParentIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetParentIdNull()
			{
				base[this.dtReportAirLineRepairAddressDataTable_0.ParentIdColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.dtReportAirLineRepairAddressDataTable_0.idObjListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidObjListNull()
			{
				base[this.dtReportAirLineRepairAddressDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtReportAirLineRepairAddressDataTable_0.NameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameNull()
			{
				base[this.dtReportAirLineRepairAddressDataTable_0.NameColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtReportAirLineRepairAddressDataTable dtReportAirLineRepairAddressDataTable_0;
		}

		public class dtInspectAirLineDefectRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtInspectAirLineDefectRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtInspectAirLineDefectDataTable_0 = (DataSetReportAirLinePassport.dtInspectAirLineDefectDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idDoc
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtInspectAirLineDefectDataTable_0.idDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idDoc' in table 'dtInspectAirLineDefect' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtInspectAirLineDefectDataTable_0.idDocColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Defect
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtInspectAirLineDefectDataTable_0.DefectColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Defect' in table 'dtInspectAirLineDefect' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtInspectAirLineDefectDataTable_0.DefectColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Pylon
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtInspectAirLineDefectDataTable_0.PylonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Pylon' in table 'dtInspectAirLineDefect' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtInspectAirLineDefectDataTable_0.PylonColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idPylon
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtInspectAirLineDefectDataTable_0.idPylonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idPylon' in table 'dtInspectAirLineDefect' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtInspectAirLineDefectDataTable_0.idPylonColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidDocNull()
			{
				return base.IsNull(this.dtInspectAirLineDefectDataTable_0.idDocColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidDocNull()
			{
				base[this.dtInspectAirLineDefectDataTable_0.idDocColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDefectNull()
			{
				return base.IsNull(this.dtInspectAirLineDefectDataTable_0.DefectColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetDefectNull()
			{
				base[this.dtInspectAirLineDefectDataTable_0.DefectColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPylonNull()
			{
				return base.IsNull(this.dtInspectAirLineDefectDataTable_0.PylonColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPylonNull()
			{
				base[this.dtInspectAirLineDefectDataTable_0.PylonColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidPylonNull()
			{
				return base.IsNull(this.dtInspectAirLineDefectDataTable_0.idPylonColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidPylonNull()
			{
				base[this.dtInspectAirLineDefectDataTable_0.idPylonColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtInspectAirLineDefectDataTable dtInspectAirLineDefectDataTable_0;
		}

		public class dtInspectAirLineWorkerRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtInspectAirLineWorkerRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtInspectAirLineWorkerDataTable_0 = (DataSetReportAirLinePassport.dtInspectAirLineWorkerDataTable)base.Table;
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
						result = (int)base[this.dtInspectAirLineWorkerDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'dtInspectAirLineWorker' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtInspectAirLineWorkerDataTable_0.idColumn] = value;
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
						result = (string)base[this.dtInspectAirLineWorkerDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'dtInspectAirLineWorker' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtInspectAirLineWorkerDataTable_0.NameColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidNull()
			{
				return base.IsNull(this.dtInspectAirLineWorkerDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidNull()
			{
				base[this.dtInspectAirLineWorkerDataTable_0.idColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtInspectAirLineWorkerDataTable_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.dtInspectAirLineWorkerDataTable_0.NameColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtInspectAirLineWorkerDataTable dtInspectAirLineWorkerDataTable_0;
		}

		public class dtInspectAirLineOtherRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtInspectAirLineOtherRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtInspectAirLineOtherDataTable_0 = (DataSetReportAirLinePassport.dtInspectAirLineOtherDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string TypeInspect
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtInspectAirLineOtherDataTable_0.TypeInspectColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TypeInspect' in table 'dtInspectAirLineOther' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtInspectAirLineOtherDataTable_0.TypeInspectColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idTypeInspect
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.dtInspectAirLineOtherDataTable_0.idTypeInspectColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idTypeInspect' in table 'dtInspectAirLineOther' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtInspectAirLineOtherDataTable_0.idTypeInspectColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsTypeInspectNull()
			{
				return base.IsNull(this.dtInspectAirLineOtherDataTable_0.TypeInspectColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetTypeInspectNull()
			{
				base[this.dtInspectAirLineOtherDataTable_0.TypeInspectColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidTypeInspectNull()
			{
				return base.IsNull(this.dtInspectAirLineOtherDataTable_0.idTypeInspectColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidTypeInspectNull()
			{
				base[this.dtInspectAirLineOtherDataTable_0.idTypeInspectColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtInspectAirLineOtherDataTable dtInspectAirLineOtherDataTable_0;
		}

		public class dtPylonEquipExplMianRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtPylonEquipExplMianRow(DataRowBuilder rb)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor(rb);
				this.dtPylonEquipExplMianDataTable_0 = (DataSetReportAirLinePassport.dtPylonEquipExplMianDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string idDoc
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonEquipExplMianDataTable_0.idDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idDoc' in table 'dtPylonEquipExplMian' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipExplMianDataTable_0.idDocColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string netRegion
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonEquipExplMianDataTable_0.netRegionColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'netRegion' in table 'dtPylonEquipExplMian' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipExplMianDataTable_0.netRegionColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string dateDoc
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonEquipExplMianDataTable_0.dateDocColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'dateDoc' in table 'dtPylonEquipExplMian' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipExplMianDataTable_0.dateDocColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string idObjList
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonEquipExplMianDataTable_0.idObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idObjList' in table 'dtPylonEquipExplMian' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipExplMianDataTable_0.idObjListColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string ObjList
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonEquipExplMianDataTable_0.ObjListColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'ObjList' in table 'dtPylonEquipExplMian' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipExplMianDataTable_0.ObjListColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string idPylon
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonEquipExplMianDataTable_0.idPylonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idPylon' in table 'dtPylonEquipExplMian' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipExplMianDataTable_0.idPylonColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Pylon
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonEquipExplMianDataTable_0.PylonColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Pylon' in table 'dtPylonEquipExplMian' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipExplMianDataTable_0.PylonColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string idTypeEquip
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonEquipExplMianDataTable_0.idTypeEquipColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idTypeEquip' in table 'dtPylonEquipExplMian' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipExplMianDataTable_0.idTypeEquipColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string TypeEquip
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.dtPylonEquipExplMianDataTable_0.TypeEquipColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'TypeEquip' in table 'dtPylonEquipExplMian' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.dtPylonEquipExplMianDataTable_0.TypeEquipColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidDocNull()
			{
				return base.IsNull(this.dtPylonEquipExplMianDataTable_0.idDocColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidDocNull()
			{
				base[this.dtPylonEquipExplMianDataTable_0.idDocColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsnetRegionNull()
			{
				return base.IsNull(this.dtPylonEquipExplMianDataTable_0.netRegionColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetnetRegionNull()
			{
				base[this.dtPylonEquipExplMianDataTable_0.netRegionColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsdateDocNull()
			{
				return base.IsNull(this.dtPylonEquipExplMianDataTable_0.dateDocColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetdateDocNull()
			{
				base[this.dtPylonEquipExplMianDataTable_0.dateDocColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.dtPylonEquipExplMianDataTable_0.idObjListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidObjListNull()
			{
				base[this.dtPylonEquipExplMianDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsObjListNull()
			{
				return base.IsNull(this.dtPylonEquipExplMianDataTable_0.ObjListColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetObjListNull()
			{
				base[this.dtPylonEquipExplMianDataTable_0.ObjListColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidPylonNull()
			{
				return base.IsNull(this.dtPylonEquipExplMianDataTable_0.idPylonColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidPylonNull()
			{
				base[this.dtPylonEquipExplMianDataTable_0.idPylonColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPylonNull()
			{
				return base.IsNull(this.dtPylonEquipExplMianDataTable_0.PylonColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPylonNull()
			{
				base[this.dtPylonEquipExplMianDataTable_0.PylonColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidTypeEquipNull()
			{
				return base.IsNull(this.dtPylonEquipExplMianDataTable_0.idTypeEquipColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidTypeEquipNull()
			{
				base[this.dtPylonEquipExplMianDataTable_0.idTypeEquipColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsTypeEquipNull()
			{
				return base.IsNull(this.dtPylonEquipExplMianDataTable_0.TypeEquipColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetTypeEquipNull()
			{
				base[this.dtPylonEquipExplMianDataTable_0.TypeEquipColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtPylonEquipExplMianDataTable dtPylonEquipExplMianDataTable_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtAirLineEquipmentRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtAirLineEquipmentRowChangeEvent(DataSetReportAirLinePassport.dtAirLineEquipmentRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtAirLineEquipmentRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtAirLineEquipmentRow Row
			{
				get
				{
					return this.dtAirLineEquipmentRow_0;
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

			private DataSetReportAirLinePassport.dtAirLineEquipmentRow dtAirLineEquipmentRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class tp_AirLineReportRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tp_AirLineReportRowChangeEvent(DataSetReportAirLinePassport.tp_AirLineReportRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.tp_AirLineReportRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.tp_AirLineReportRow Row
			{
				get
				{
					return this.tp_AirLineReportRow_0;
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

			private DataSetReportAirLinePassport.tp_AirLineReportRow tp_AirLineReportRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtCrossingRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtCrossingRowChangeEvent(DataSetReportAirLinePassport.dtCrossingRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtCrossingRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtCrossingRow Row
			{
				get
				{
					return this.dtCrossingRow_0;
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

			private DataSetReportAirLinePassport.dtCrossingRow dtCrossingRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtTerrainRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtTerrainRowChangeEvent(DataSetReportAirLinePassport.dtTerrainRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtTerrainRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtTerrainRow Row
			{
				get
				{
					return this.dtTerrainRow_0;
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

			private DataSetReportAirLinePassport.dtTerrainRow dtTerrainRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dsCountPoleRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsCountPoleRowChangeEvent(DataSetReportAirLinePassport.dsCountPoleRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dsCountPoleRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dsCountPoleRow Row
			{
				get
				{
					return this.dsCountPoleRow_0;
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

			private DataSetReportAirLinePassport.dsCountPoleRow dsCountPoleRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtBranchRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtBranchRowChangeEvent(DataSetReportAirLinePassport.dtBranchRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtBranchRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtBranchRow Row
			{
				get
				{
					return this.dtBranchRow_0;
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

			private DataSetReportAirLinePassport.dtBranchRow dtBranchRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtCableInsertionRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtCableInsertionRowChangeEvent(DataSetReportAirLinePassport.dtCableInsertionRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtCableInsertionRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtCableInsertionRow Row
			{
				get
				{
					return this.dtCableInsertionRow_0;
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

			private DataSetReportAirLinePassport.dtCableInsertionRow dtCableInsertionRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtPylonEquipmentRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtPylonEquipmentRowChangeEvent(DataSetReportAirLinePassport.dtPylonEquipmentRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtPylonEquipmentRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtPylonEquipmentRow Row
			{
				get
				{
					return this.dtPylonEquipmentRow_0;
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

			private DataSetReportAirLinePassport.dtPylonEquipmentRow dtPylonEquipmentRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtJointSuspensionRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtJointSuspensionRowChangeEvent(DataSetReportAirLinePassport.dtJointSuspensionRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtJointSuspensionRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtJointSuspensionRow Row
			{
				get
				{
					return this.dtJointSuspensionRow_0;
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

			private DataSetReportAirLinePassport.dtJointSuspensionRow dtJointSuspensionRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class tBranchRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tBranchRowChangeEvent(DataSetReportAirLinePassport.tBranchRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.tBranchRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.tBranchRow Row
			{
				get
				{
					return this.tBranchRow_0;
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

			private DataSetReportAirLinePassport.tBranchRow tBranchRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtPylonsRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtPylonsRowChangeEvent(DataSetReportAirLinePassport.dtPylonsRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtPylonsRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtPylonsRow Row
			{
				get
				{
					return this.dtPylonsRow_0;
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

			private DataSetReportAirLinePassport.dtPylonsRow dtPylonsRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtRoadRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtRoadRowChangeEvent(DataSetReportAirLinePassport.dtRoadRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtRoadRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtRoadRow Row
			{
				get
				{
					return this.dtRoadRow_0;
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

			private DataSetReportAirLinePassport.dtRoadRow dtRoadRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class vDocAirLineRepairRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public vDocAirLineRepairRowChangeEvent(DataSetReportAirLinePassport.vDocAirLineRepairRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.vDocAirLineRepairRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.vDocAirLineRepairRow Row
			{
				get
				{
					return this.vDocAirLineRepairRow_0;
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

			private DataSetReportAirLinePassport.vDocAirLineRepairRow vDocAirLineRepairRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class vDocPylonEquipRepairRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public vDocPylonEquipRepairRowChangeEvent(DataSetReportAirLinePassport.vDocPylonEquipRepairRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.vDocPylonEquipRepairRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.vDocPylonEquipRepairRow Row
			{
				get
				{
					return this.vDocPylonEquipRepairRow_0;
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

			private DataSetReportAirLinePassport.vDocPylonEquipRepairRow vDocPylonEquipRepairRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class tSettingsRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tSettingsRowChangeEvent(DataSetReportAirLinePassport.tSettingsRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.JmfaOhKvwKy = row;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.tSettingsRow Row
			{
				get
				{
					return this.JmfaOhKvwKy;
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

			private DataSetReportAirLinePassport.tSettingsRow JmfaOhKvwKy;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtReportAirLineRepairMainRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtReportAirLineRepairMainRowChangeEvent(DataSetReportAirLinePassport.dtReportAirLineRepairMainRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtReportAirLineRepairMainRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtReportAirLineRepairMainRow Row
			{
				get
				{
					return this.dtReportAirLineRepairMainRow_0;
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

			private DataSetReportAirLinePassport.dtReportAirLineRepairMainRow dtReportAirLineRepairMainRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtReportAirLineRepairWorkRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtReportAirLineRepairWorkRowChangeEvent(DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtReportAirLineRepairWorkRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow Row
			{
				get
				{
					return this.dtReportAirLineRepairWorkRow_0;
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

			private DataSetReportAirLinePassport.dtReportAirLineRepairWorkRow dtReportAirLineRepairWorkRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtReportAirLineRepairAddressRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtReportAirLineRepairAddressRowChangeEvent(DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtReportAirLineRepairAddressRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow Row
			{
				get
				{
					return this.dtReportAirLineRepairAddressRow_0;
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

			private DataSetReportAirLinePassport.dtReportAirLineRepairAddressRow dtReportAirLineRepairAddressRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtInspectAirLineDefectRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtInspectAirLineDefectRowChangeEvent(DataSetReportAirLinePassport.dtInspectAirLineDefectRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtInspectAirLineDefectRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtInspectAirLineDefectRow Row
			{
				get
				{
					return this.dtInspectAirLineDefectRow_0;
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

			private DataSetReportAirLinePassport.dtInspectAirLineDefectRow dtInspectAirLineDefectRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtInspectAirLineWorkerRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtInspectAirLineWorkerRowChangeEvent(DataSetReportAirLinePassport.dtInspectAirLineWorkerRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtInspectAirLineWorkerRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtInspectAirLineWorkerRow Row
			{
				get
				{
					return this.dtInspectAirLineWorkerRow_0;
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

			private DataSetReportAirLinePassport.dtInspectAirLineWorkerRow dtInspectAirLineWorkerRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtInspectAirLineOtherRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtInspectAirLineOtherRowChangeEvent(DataSetReportAirLinePassport.dtInspectAirLineOtherRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtInspectAirLineOtherRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtInspectAirLineOtherRow Row
			{
				get
				{
					return this.dtInspectAirLineOtherRow_0;
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

			private DataSetReportAirLinePassport.dtInspectAirLineOtherRow dtInspectAirLineOtherRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtPylonEquipExplMianRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtPylonEquipExplMianRowChangeEvent(DataSetReportAirLinePassport.dtPylonEquipExplMianRow row, DataRowAction action)
			{
				Class330.Mus9JxKz1CNxy();
				base..ctor();
				this.dtPylonEquipExplMianRow_0 = row;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtPylonEquipExplMianRow Row
			{
				get
				{
					return this.dtPylonEquipExplMianRow_0;
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

			private DataSetReportAirLinePassport.dtPylonEquipExplMianRow dtPylonEquipExplMianRow_0;

			private DataRowAction dataRowAction_0;
		}
	}
}
