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

namespace Passport.Forms.AirLine.Report
{
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[XmlRoot("DataSetReportAirLinePassport")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	public class DataSetReportAirLinePassport : DataSet
	{
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport()
		{
			base.BeginInit();
			this.method_2();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_15);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected DataSetReportAirLinePassport(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			if (base.IsBinarySerialized(info, context))
			{
				this.method_1(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_15);
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
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.method_15);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport.dtAirLineEquipmentDataTable dtAirLineEquipment
		{
			get
			{
				return this.tabledtAirLineEquipment;
			}
		}

		[DebuggerNonUserCode]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport.tp_AirLineReportDataTable tp_AirLineReport
		{
			get
			{
				return this.tabletp_AirLineReport;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport.dtCrossingDataTable dtCrossing
		{
			get
			{
				return this.tabledtCrossing;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public DataSetReportAirLinePassport.dtTerrainDataTable dtTerrain
		{
			get
			{
				return this.tabledtTerrain;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public DataSetReportAirLinePassport.dsCountPoleDataTable dsCountPole
		{
			get
			{
				return this.tabledsCountPole;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport.dtBranchDataTable dtBranch
		{
			get
			{
				return this.tabledtBranch;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public DataSetReportAirLinePassport.dtCableInsertionDataTable dtCableInsertion
		{
			get
			{
				return this.tabledtCableInsertion;
			}
		}

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public DataSetReportAirLinePassport.dtPylonEquipmentDataTable dtPylonEquipment
		{
			get
			{
				return this.tabledtPylonEquipment;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public DataSetReportAirLinePassport.dtJointSuspensionDataTable dtJointSuspension
		{
			get
			{
				return this.tabledtJointSuspension;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport.tBranchDataTable tBranch
		{
			get
			{
				return this.tabletBranch;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport.dtPylonsDataTable dtPylons
		{
			get
			{
				return this.tabledtPylons;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetReportAirLinePassport.dtRoadDataTable dtRoad
		{
			get
			{
				return this.tabledtRoad;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(true)]
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
			DataSetReportAirLinePassport dataSetReportAirLinePassport = (DataSetReportAirLinePassport)base.Clone();
			dataSetReportAirLinePassport.method_0();
			dataSetReportAirLinePassport.SchemaSerializationMode = this.SchemaSerializationMode;
			return dataSetReportAirLinePassport;
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			this.tabledtAirLineEquipment = (DataSetReportAirLinePassport.dtAirLineEquipmentDataTable)base.Tables["dtAirLineEquipment"];
			if (bool_0 && this.tabledtAirLineEquipment != null)
			{
				this.tabledtAirLineEquipment.method_0();
			}
			this.tabletp_AirLineReport = (DataSetReportAirLinePassport.tp_AirLineReportDataTable)base.Tables["tp_AirLineReport"];
			if (bool_0 && this.tabletp_AirLineReport != null)
			{
				this.tabletp_AirLineReport.method_0();
			}
			this.tabledtCrossing = (DataSetReportAirLinePassport.dtCrossingDataTable)base.Tables["dtCrossing"];
			if (bool_0 && this.tabledtCrossing != null)
			{
				this.tabledtCrossing.method_0();
			}
			this.tabledtTerrain = (DataSetReportAirLinePassport.dtTerrainDataTable)base.Tables["dtTerrain"];
			if (bool_0 && this.tabledtTerrain != null)
			{
				this.tabledtTerrain.method_0();
			}
			this.tabledsCountPole = (DataSetReportAirLinePassport.dsCountPoleDataTable)base.Tables["dsCountPole"];
			if (bool_0 && this.tabledsCountPole != null)
			{
				this.tabledsCountPole.method_0();
			}
			this.tabledtBranch = (DataSetReportAirLinePassport.dtBranchDataTable)base.Tables["dtBranch"];
			if (bool_0 && this.tabledtBranch != null)
			{
				this.tabledtBranch.method_0();
			}
			this.tabledtCableInsertion = (DataSetReportAirLinePassport.dtCableInsertionDataTable)base.Tables["dtCableInsertion"];
			if (bool_0 && this.tabledtCableInsertion != null)
			{
				this.tabledtCableInsertion.method_0();
			}
			this.tabledtPylonEquipment = (DataSetReportAirLinePassport.dtPylonEquipmentDataTable)base.Tables["dtPylonEquipment"];
			if (bool_0 && this.tabledtPylonEquipment != null)
			{
				this.tabledtPylonEquipment.method_0();
			}
			this.tabledtJointSuspension = (DataSetReportAirLinePassport.dtJointSuspensionDataTable)base.Tables["dtJointSuspension"];
			if (bool_0 && this.tabledtJointSuspension != null)
			{
				this.tabledtJointSuspension.method_0();
			}
			this.tabletBranch = (DataSetReportAirLinePassport.tBranchDataTable)base.Tables["tBranch"];
			if (bool_0 && this.tabletBranch != null)
			{
				this.tabletBranch.method_0();
			}
			this.tabledtPylons = (DataSetReportAirLinePassport.dtPylonsDataTable)base.Tables["dtPylons"];
			if (bool_0 && this.tabledtPylons != null)
			{
				this.tabledtPylons.method_0();
			}
			this.tabledtRoad = (DataSetReportAirLinePassport.dtRoadDataTable)base.Tables["dtRoad"];
			if (bool_0 && this.tabledtRoad != null)
			{
				this.tabledtRoad.method_0();
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
			this.tabledtAirLineEquipment = new DataSetReportAirLinePassport.dtAirLineEquipmentDataTable();
			base.Tables.Add(this.tabledtAirLineEquipment);
			this.tabletp_AirLineReport = new DataSetReportAirLinePassport.tp_AirLineReportDataTable();
			base.Tables.Add(this.tabletp_AirLineReport);
			this.tabledtCrossing = new DataSetReportAirLinePassport.dtCrossingDataTable();
			base.Tables.Add(this.tabledtCrossing);
			this.tabledtTerrain = new DataSetReportAirLinePassport.dtTerrainDataTable();
			base.Tables.Add(this.tabledtTerrain);
			this.tabledsCountPole = new DataSetReportAirLinePassport.dsCountPoleDataTable();
			base.Tables.Add(this.tabledsCountPole);
			this.tabledtBranch = new DataSetReportAirLinePassport.dtBranchDataTable();
			base.Tables.Add(this.tabledtBranch);
			this.tabledtCableInsertion = new DataSetReportAirLinePassport.dtCableInsertionDataTable();
			base.Tables.Add(this.tabledtCableInsertion);
			this.tabledtPylonEquipment = new DataSetReportAirLinePassport.dtPylonEquipmentDataTable();
			base.Tables.Add(this.tabledtPylonEquipment);
			this.tabledtJointSuspension = new DataSetReportAirLinePassport.dtJointSuspensionDataTable();
			base.Tables.Add(this.tabledtJointSuspension);
			this.tabletBranch = new DataSetReportAirLinePassport.tBranchDataTable();
			base.Tables.Add(this.tabletBranch);
			this.tabledtPylons = new DataSetReportAirLinePassport.dtPylonsDataTable();
			base.Tables.Add(this.tabledtPylons);
			this.tabledtRoad = new DataSetReportAirLinePassport.dtRoadDataTable();
			base.Tables.Add(this.tabledtRoad);
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool method_14()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_15(object sender, CollectionChangeEventArgs e)
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
			DataSetReportAirLinePassport dataSetReportAirLinePassport = new DataSetReportAirLinePassport();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dataSetReportAirLinePassport.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSetReportAirLinePassport.GetSchemaSerializable();
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

		private DataSetReportAirLinePassport.dtAirLineEquipmentDataTable tabledtAirLineEquipment;

		private DataSetReportAirLinePassport.tp_AirLineReportDataTable tabletp_AirLineReport;

		private DataSetReportAirLinePassport.dtCrossingDataTable tabledtCrossing;

		private DataSetReportAirLinePassport.dtTerrainDataTable tabledtTerrain;

		private DataSetReportAirLinePassport.dsCountPoleDataTable tabledsCountPole;

		private DataSetReportAirLinePassport.dtBranchDataTable tabledtBranch;

		private DataSetReportAirLinePassport.dtCableInsertionDataTable tabledtCableInsertion;

		private DataSetReportAirLinePassport.dtPylonEquipmentDataTable tabledtPylonEquipment;

		private DataSetReportAirLinePassport.dtJointSuspensionDataTable tabledtJointSuspension;

		private DataSetReportAirLinePassport.tBranchDataTable tabletBranch;

		private DataSetReportAirLinePassport.dtPylonsDataTable tabledtPylons;

		private DataSetReportAirLinePassport.dtRoadDataTable tabledtRoad;

		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtAirLineEquipmentRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEvent dtAirLineEquipmentRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void tp_AirLineReportRowChangeEventHandler(object sender, DataSetReportAirLinePassport.tp_AirLineReportRowChangeEvent tp_AirLineReportRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtCrossingRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtCrossingRowChangeEvent dtCrossingRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtTerrainRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtTerrainRowChangeEvent dtTerrainRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dsCountPoleRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dsCountPoleRowChangeEvent dsCountPoleRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtBranchRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtBranchRowChangeEvent dtBranchRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtCableInsertionRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtCableInsertionRowChangeEvent dtCableInsertionRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtPylonEquipmentRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEvent dtPylonEquipmentRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtJointSuspensionRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtJointSuspensionRowChangeEvent dtJointSuspensionRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void tBranchRowChangeEventHandler(object sender, DataSetReportAirLinePassport.tBranchRowChangeEvent tBranchRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtPylonsRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtPylonsRowChangeEvent dtPylonsRowChangeEvent_0);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void dtRoadRowChangeEventHandler(object sender, DataSetReportAirLinePassport.dtRoadRowChangeEvent dtRoadRowChangeEvent_0);

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtAirLineEquipmentDataTable : TypedTableBase<DataSetReportAirLinePassport.dtAirLineEquipmentRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtAirLineEquipmentDataTable()
			{
				base.TableName = "dtAirLineEquipment";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtAirLineEquipmentDataTable(DataTable dataTable_0)
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
			protected dtAirLineEquipmentDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
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
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_13
			{
				get
				{
					return this.dataColumn_13;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn PoleNumColumn
			{
				get
				{
					return this.columnPoleNum;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PoleCountColumn
			{
				get
				{
					return this.columnPoleCount;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_17
			{
				get
				{
					return this.dataColumn_17;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_18
			{
				get
				{
					return this.dataColumn_18;
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
			public DataSetReportAirLinePassport.dtAirLineEquipmentRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtAirLineEquipmentRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEventHandler dtAirLineEquipmentRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtAirLineEquipmentRow(DataSetReportAirLinePassport.dtAirLineEquipmentRow dtAirLineEquipmentRow_0)
			{
				base.Rows.Add(dtAirLineEquipmentRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtAirLineEquipmentRow AdddtAirLineEquipmentRow(int int_0, string Name, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, string string_12, string string_13, string string_14, string string_15, string string_16, string PoleNum, int PoleCount, string string_17, string string_18)
			{
				DataSetReportAirLinePassport.dtAirLineEquipmentRow dtAirLineEquipmentRow = (DataSetReportAirLinePassport.dtAirLineEquipmentRow)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.columnid = base.Columns["id"];
				this.columnName = base.Columns["Name"];
				this.dataColumn_0 = base.Columns["ГодУстановки"];
				this.dataColumn_1 = base.Columns["Стойка"];
				this.dataColumn_2 = base.Columns["Подкос"];
				this.dataColumn_3 = base.Columns["Приставка"];
				this.dataColumn_4 = base.Columns["Тип"];
				this.dataColumn_5 = base.Columns["Количество"];
				this.dataColumn_6 = base.Columns["НаличиеКонтура"];
				this.dataColumn_7 = base.Columns["Сопротивление"];
				this.dataColumn_8 = base.Columns["Принадлежность"];
				this.dataColumn_9 = base.Columns["ТипФундамента"];
				this.dataColumn_10 = base.Columns["СхемаПроводовИТросов"];
				this.dataColumn_11 = base.Columns["Назначение"];
				this.dataColumn_12 = base.Columns["ТипГирлянды"];
				this.dataColumn_13 = base.Columns["ДлинаКабеляМ"];
				this.dataColumn_14 = base.Columns["МаркаКабеля"];
				this.dataColumn_15 = base.Columns["ТипКонцевойМуфты"];
				this.dataColumn_16 = base.Columns["ТипОпоры"];
				this.columnPoleNum = base.Columns["PoleNum"];
				this.columnPoleCount = base.Columns["PoleCount"];
				this.dataColumn_17 = base.Columns["ВсегоНаЛинии"];
				this.dataColumn_18 = base.Columns["ТипИзолятора"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.dataColumn_0 = new DataColumn("ГодУстановки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Стойка", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("Подкос", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("Приставка", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("Тип", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Количество", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("НаличиеКонтура", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("Сопротивление", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("Принадлежность", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("ТипФундамента", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("СхемаПроводовИТросов", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("Назначение", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("ТипГирлянды", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
				this.dataColumn_13 = new DataColumn("ДлинаКабеляМ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_13);
				this.dataColumn_14 = new DataColumn("МаркаКабеля", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_14);
				this.dataColumn_15 = new DataColumn("ТипКонцевойМуфты", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_15);
				this.dataColumn_16 = new DataColumn("ТипОпоры", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_16);
				this.columnPoleNum = new DataColumn("PoleNum", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPoleNum);
				this.columnPoleCount = new DataColumn("PoleCount", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnPoleCount);
				this.dataColumn_17 = new DataColumn("ВсегоНаЛинии", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_17);
				this.dataColumn_18 = new DataColumn("ТипИзолятора", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_18);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtAirLineEquipmentRow NewdtAirLineEquipmentRow()
			{
				return (DataSetReportAirLinePassport.dtAirLineEquipmentRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtAirLineEquipmentRowChanged != null)
				{
					this.dtAirLineEquipmentRowChanged(this, new DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtAirLineEquipmentRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtAirLineEquipmentRowChanging != null)
				{
					this.dtAirLineEquipmentRowChanging(this, new DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtAirLineEquipmentRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtAirLineEquipmentRowDeleted != null)
				{
					this.dtAirLineEquipmentRowDeleted(this, new DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtAirLineEquipmentRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtAirLineEquipmentRowDeleting != null)
				{
					this.dtAirLineEquipmentRowDeleting(this, new DataSetReportAirLinePassport.dtAirLineEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtAirLineEquipmentRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovedtAirLineEquipmentRow(DataSetReportAirLinePassport.dtAirLineEquipmentRow dtAirLineEquipmentRow_0)
			{
				base.Rows.Remove(dtAirLineEquipmentRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
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

			private DataColumn columnPoleNum;

			private DataColumn columnPoleCount;

			private DataColumn dataColumn_17;

			private DataColumn dataColumn_18;
		}

		public class dtAirLineEquipmentRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtAirLineEquipmentRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.dtAirLineEquipmentDataTable_0 = (DataSetReportAirLinePassport.dtAirLineEquipmentDataTable)base.Table;
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsNameNull()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_3()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_4()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_2);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_14()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_7);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_17()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_8] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_23()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_11] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_26()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_13);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_27()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_13] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_33()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_16] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_34()
			{
				return base.IsNull(this.dtAirLineEquipmentDataTable_0.DataColumn_17);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_37()
			{
				base[this.dtAirLineEquipmentDataTable_0.DataColumn_18] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtAirLineEquipmentDataTable dtAirLineEquipmentDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tp_AirLineReportDataTable : TypedTableBase<DataSetReportAirLinePassport.tp_AirLineReportRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tp_AirLineReportDataTable()
			{
				base.TableName = "tp_AirLineReport";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tp_AirLineReportDataTable(DataTable dataTable_0)
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
			protected tp_AirLineReportDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
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
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_16
			{
				get
				{
					return this.dataColumn_16;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_17
			{
				get
				{
					return this.dataColumn_17;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_18
			{
				get
				{
					return this.dataColumn_18;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DataColumn_19
			{
				get
				{
					return this.dataColumn_19;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_20
			{
				get
				{
					return this.dataColumn_20;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NumberColumn
			{
				get
				{
					return this.columnNumber;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_21
			{
				get
				{
					return this.dataColumn_21;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_22
			{
				get
				{
					return this.dataColumn_22;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DataColumn_23
			{
				get
				{
					return this.dataColumn_23;
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
			public DataSetReportAirLinePassport.tp_AirLineReportRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.tp_AirLineReportRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tp_AirLineReportRowChangeEventHandler tp_AirLineReportRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Addtp_AirLineReportRow(DataSetReportAirLinePassport.tp_AirLineReportRow tp_AirLineReportRow_0)
			{
				base.Rows.Add(tp_AirLineReportRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.tp_AirLineReportRow Addtp_AirLineReportRow(int int_0, string string_0, string Name, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, string string_12, string string_13, string string_14, string string_15, string string_16, string string_17, string string_18, string string_19, string string_20, string Number, string string_21, string string_22, string string_23)
			{
				DataSetReportAirLinePassport.tp_AirLineReportRow tp_AirLineReportRow = (DataSetReportAirLinePassport.tp_AirLineReportRow)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.tp_AirLineReportDataTable tp_AirLineReportDataTable = (DataSetReportAirLinePassport.tp_AirLineReportDataTable)base.Clone();
				tp_AirLineReportDataTable.method_0();
				return tp_AirLineReportDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.tp_AirLineReportDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.columnid = base.Columns["id"];
				this.dataColumn_0 = base.Columns["Напряжение"];
				this.columnName = base.Columns["Name"];
				this.dataColumn_1 = base.Columns["ГодПостройки"];
				this.dataColumn_2 = base.Columns["ГодВводаВЭксплуатацию"];
				this.dataColumn_3 = base.Columns["ИнвентарныйНомер"];
				this.dataColumn_4 = base.Columns["НаименованиеПроектирующейОрганизации"];
				this.dataColumn_5 = base.Columns["НаименованиеСтроительноМонтажнойОрганизации"];
				this.dataColumn_6 = base.Columns["ПротяженностьЛинии"];
				this.dataColumn_7 = base.Columns["ДлинаПролета"];
				this.dataColumn_8 = base.Columns["МаркаПровода"];
				this.dataColumn_9 = base.Columns["ДлинаПроводаОбщая"];
				this.dataColumn_10 = base.Columns["РасстояниеМеждуПроводамиВФазе"];
				this.dataColumn_11 = base.Columns["МаркаГазотроса"];
				this.dataColumn_12 = base.Columns["МаркаТросаОттяжек"];
				this.dataColumn_13 = base.Columns["РайонКлиматическихУсловий"];
				this.dataColumn_14 = base.Columns["ТипПоддерживающегоУстройстваНаВсейЛинии"];
				this.dataColumn_15 = base.Columns["ТипПоддерживающегоУстройстваНаПереходах"];
				this.dataColumn_16 = base.Columns["РасстояниеМеждуДистанционнымиРаспорками"];
				this.dataColumn_17 = base.Columns["КоличествоЦепей"];
				this.dataColumn_18 = base.Columns["Регион"];
				this.dataColumn_19 = base.Columns["Участок"];
				this.dataColumn_20 = base.Columns["СечениеПровода"];
				this.columnNumber = base.Columns["Number"];
				this.dataColumn_21 = base.Columns["Проектирующая"];
				this.dataColumn_22 = base.Columns["СтроительноМонтажная"];
				this.dataColumn_23 = base.Columns["ДатаВводаВЭксплуатацию"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.dataColumn_0 = new DataColumn("Напряжение", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.dataColumn_1 = new DataColumn("ГодПостройки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("ГодВводаВЭксплуатацию", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("ИнвентарныйНомер", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("НаименованиеПроектирующейОрганизации", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("НаименованиеСтроительноМонтажнойОрганизации", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("ПротяженностьЛинии", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("ДлинаПролета", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.dataColumn_8 = new DataColumn("МаркаПровода", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("ДлинаПроводаОбщая", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.dataColumn_10 = new DataColumn("РасстояниеМеждуПроводамиВФазе", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_10);
				this.dataColumn_11 = new DataColumn("МаркаГазотроса", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_11);
				this.dataColumn_12 = new DataColumn("МаркаТросаОттяжек", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_12);
				this.dataColumn_13 = new DataColumn("РайонКлиматическихУсловий", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_13);
				this.dataColumn_14 = new DataColumn("ТипПоддерживающегоУстройстваНаВсейЛинии", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_14);
				this.dataColumn_15 = new DataColumn("ТипПоддерживающегоУстройстваНаПереходах", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_15);
				this.dataColumn_16 = new DataColumn("РасстояниеМеждуДистанционнымиРаспорками", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_16);
				this.dataColumn_17 = new DataColumn("КоличествоЦепей", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_17);
				this.dataColumn_18 = new DataColumn("Регион", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_18);
				this.dataColumn_19 = new DataColumn("Участок", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_19);
				this.dataColumn_20 = new DataColumn("СечениеПровода", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_20);
				this.columnNumber = new DataColumn("Number", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNumber);
				this.dataColumn_21 = new DataColumn("Проектирующая", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_21);
				this.dataColumn_22 = new DataColumn("СтроительноМонтажная", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_22);
				this.dataColumn_23 = new DataColumn("ДатаВводаВЭксплуатацию", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_23);
				this.dataColumn_0.Caption = "voltage";
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tp_AirLineReportRowChanged != null)
				{
					this.tp_AirLineReportRowChanged(this, new DataSetReportAirLinePassport.tp_AirLineReportRowChangeEvent((DataSetReportAirLinePassport.tp_AirLineReportRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tp_AirLineReportRowChanging != null)
				{
					this.tp_AirLineReportRowChanging(this, new DataSetReportAirLinePassport.tp_AirLineReportRowChangeEvent((DataSetReportAirLinePassport.tp_AirLineReportRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tp_AirLineReportRowDeleted != null)
				{
					this.tp_AirLineReportRowDeleted(this, new DataSetReportAirLinePassport.tp_AirLineReportRowChangeEvent((DataSetReportAirLinePassport.tp_AirLineReportRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tp_AirLineReportRowDeleting != null)
				{
					this.tp_AirLineReportRowDeleting(this, new DataSetReportAirLinePassport.tp_AirLineReportRowChangeEvent((DataSetReportAirLinePassport.tp_AirLineReportRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void Removetp_AirLineReportRow(DataSetReportAirLinePassport.tp_AirLineReportRow tp_AirLineReportRow_0)
			{
				base.Rows.Remove(tp_AirLineReportRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
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

			private DataColumn dataColumn_0;

			private DataColumn columnName;

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

			private DataColumn columnNumber;

			private DataColumn dataColumn_21;

			private DataColumn dataColumn_22;

			private DataColumn dataColumn_23;
		}

		public class tp_AirLineReportRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tp_AirLineReportRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tp_AirLineReportDataTable_0 = (DataSetReportAirLinePassport.tp_AirLineReportDataTable)base.Table;
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetidNull()
			{
				base[this.tp_AirLineReportDataTable_0.idColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_2()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_1);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_3()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_9()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_4] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_10()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_5);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_15()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_7] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_16()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_8);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_10);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_21()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_10] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_27()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_13] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_32()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_16);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_33()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_16] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_37()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_18] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_40()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_20);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_41()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_20] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_45()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_22] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_46()
			{
				return base.IsNull(this.tp_AirLineReportDataTable_0.DataColumn_23);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_47()
			{
				base[this.tp_AirLineReportDataTable_0.DataColumn_23] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.tp_AirLineReportDataTable tp_AirLineReportDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtCrossingDataTable : TypedTableBase<DataSetReportAirLinePassport.dtCrossingRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtCrossingDataTable()
			{
				base.TableName = "dtCrossing";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtCrossingDataTable(DataTable dataTable_0)
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
			protected dtCrossingDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
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
			public DataColumn CrossingNameColumn
			{
				get
				{
					return this.columnCrossingName;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CountSpansColumn
			{
				get
				{
					return this.columnCountSpans;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn SpanNumbersColumn
			{
				get
				{
					return this.columnSpanNumbers;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idCrossingColumn
			{
				get
				{
					return this.columnidCrossing;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ShortCrossingNameColumn
			{
				get
				{
					return this.columnShortCrossingName;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn PylonNumbersColumn
			{
				get
				{
					return this.columnPylonNumbers;
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
			public DataSetReportAirLinePassport.dtCrossingRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtCrossingRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCrossingRowChangeEventHandler dtCrossingRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtCrossingRow(DataSetReportAirLinePassport.dtCrossingRow dtCrossingRow_0)
			{
				base.Rows.Add(dtCrossingRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
				this.columnidObjList = base.Columns["idObjList"];
				this.columnCrossingName = base.Columns["CrossingName"];
				this.columnCountSpans = base.Columns["CountSpans"];
				this.columnSpanNumbers = base.Columns["SpanNumbers"];
				this.columnidCrossing = base.Columns["idCrossing"];
				this.columnShortCrossingName = base.Columns["ShortCrossingName"];
				this.columnPylonNumbers = base.Columns["PylonNumbers"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.columnidObjList = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObjList);
				this.columnCrossingName = new DataColumn("CrossingName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCrossingName);
				this.columnCountSpans = new DataColumn("CountSpans", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnCountSpans);
				this.columnSpanNumbers = new DataColumn("SpanNumbers", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSpanNumbers);
				this.columnidCrossing = new DataColumn("idCrossing", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidCrossing);
				this.columnShortCrossingName = new DataColumn("ShortCrossingName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnShortCrossingName);
				this.columnPylonNumbers = new DataColumn("PylonNumbers", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPylonNumbers);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtCrossingRowChanged != null)
				{
					this.dtCrossingRowChanged(this, new DataSetReportAirLinePassport.dtCrossingRowChangeEvent((DataSetReportAirLinePassport.dtCrossingRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtCrossingRowChanging != null)
				{
					this.dtCrossingRowChanging(this, new DataSetReportAirLinePassport.dtCrossingRowChangeEvent((DataSetReportAirLinePassport.dtCrossingRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtCrossingRowDeleted != null)
				{
					this.dtCrossingRowDeleted(this, new DataSetReportAirLinePassport.dtCrossingRowChangeEvent((DataSetReportAirLinePassport.dtCrossingRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtCrossingRowDeleting != null)
				{
					this.dtCrossingRowDeleting(this, new DataSetReportAirLinePassport.dtCrossingRowChangeEvent((DataSetReportAirLinePassport.dtCrossingRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovedtCrossingRow(DataSetReportAirLinePassport.dtCrossingRow dtCrossingRow_0)
			{
				base.Rows.Remove(dtCrossingRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
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

			private DataColumn columnidObjList;

			private DataColumn columnCrossingName;

			private DataColumn columnCountSpans;

			private DataColumn columnSpanNumbers;

			private DataColumn columnidCrossing;

			private DataColumn columnShortCrossingName;

			private DataColumn columnPylonNumbers;
		}

		public class dtCrossingRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtCrossingRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.dtCrossingDataTable_0 = (DataSetReportAirLinePassport.dtCrossingDataTable)base.Table;
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetidCrossingNull()
			{
				base[this.dtCrossingDataTable_0.idCrossingColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtTerrainDataTable : TypedTableBase<DataSetReportAirLinePassport.dtTerrainRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtTerrainDataTable()
			{
				base.TableName = "dtTerrain";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtTerrainDataTable(DataTable dataTable_0)
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
			protected dtTerrainDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
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
			public DataColumn idTerrainColumn
			{
				get
				{
					return this.columnidTerrain;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TerrainNameColumn
			{
				get
				{
					return this.columnTerrainName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SpanNumbersColumn
			{
				get
				{
					return this.columnSpanNumbers;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn FullLengthColumn
			{
				get
				{
					return this.columnFullLength;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn PylonNumbersColumn
			{
				get
				{
					return this.columnPylonNumbers;
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
			public DataSetReportAirLinePassport.dtTerrainRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtTerrainRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtTerrainRowChangeEventHandler dtTerrainRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtTerrainRow(DataSetReportAirLinePassport.dtTerrainRow dtTerrainRow_0)
			{
				base.Rows.Add(dtTerrainRow_0);
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
				this.columnidObjList = base.Columns["idObjList"];
				this.columnidTerrain = base.Columns["idTerrain"];
				this.columnTerrainName = base.Columns["TerrainName"];
				this.columnSpanNumbers = base.Columns["SpanNumbers"];
				this.columnFullLength = base.Columns["FullLength"];
				this.columnPylonNumbers = base.Columns["PylonNumbers"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.columnidObjList = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObjList);
				this.columnidTerrain = new DataColumn("idTerrain", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTerrain);
				this.columnTerrainName = new DataColumn("TerrainName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTerrainName);
				this.columnSpanNumbers = new DataColumn("SpanNumbers", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSpanNumbers);
				this.columnFullLength = new DataColumn("FullLength", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFullLength);
				this.columnPylonNumbers = new DataColumn("PylonNumbers", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPylonNumbers);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtTerrainRow NewdtTerrainRow()
			{
				return (DataSetReportAirLinePassport.dtTerrainRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetReportAirLinePassport.dtTerrainRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtTerrainRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtTerrainRowChanged != null)
				{
					this.dtTerrainRowChanged(this, new DataSetReportAirLinePassport.dtTerrainRowChangeEvent((DataSetReportAirLinePassport.dtTerrainRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtTerrainRowChanging != null)
				{
					this.dtTerrainRowChanging(this, new DataSetReportAirLinePassport.dtTerrainRowChangeEvent((DataSetReportAirLinePassport.dtTerrainRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtTerrainRowDeleted != null)
				{
					this.dtTerrainRowDeleted(this, new DataSetReportAirLinePassport.dtTerrainRowChangeEvent((DataSetReportAirLinePassport.dtTerrainRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtTerrainRowDeleting != null)
				{
					this.dtTerrainRowDeleting(this, new DataSetReportAirLinePassport.dtTerrainRowChangeEvent((DataSetReportAirLinePassport.dtTerrainRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtTerrainRow(DataSetReportAirLinePassport.dtTerrainRow dtTerrainRow_0)
			{
				base.Rows.Remove(dtTerrainRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
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

			private DataColumn columnidObjList;

			private DataColumn columnidTerrain;

			private DataColumn columnTerrainName;

			private DataColumn columnSpanNumbers;

			private DataColumn columnFullLength;

			private DataColumn columnPylonNumbers;
		}

		public class dtTerrainRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtTerrainRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetTerrainNameNull()
			{
				base[this.dtTerrainDataTable_0.TerrainNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsFullLengthNull()
			{
				return base.IsNull(this.dtTerrainDataTable_0.FullLengthColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetFullLengthNull()
			{
				base[this.dtTerrainDataTable_0.FullLengthColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsPylonNumbersNull()
			{
				return base.IsNull(this.dtTerrainDataTable_0.PylonNumbersColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetPylonNumbersNull()
			{
				base[this.dtTerrainDataTable_0.PylonNumbersColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtTerrainDataTable dtTerrainDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dsCountPoleDataTable : TypedTableBase<DataSetReportAirLinePassport.dsCountPoleRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dsCountPoleDataTable()
			{
				base.TableName = "dsCountPole";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dsCountPoleDataTable(DataTable dataTable_0)
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
			protected dsCountPoleDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
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
			public DataColumn KoncColumn
			{
				get
				{
					return this.columnKonc;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn OtvColumn
			{
				get
				{
					return this.columnOtv;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn UglColumn
			{
				get
				{
					return this.columnUgl;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PromColumn
			{
				get
				{
					return this.columnProm;
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
			public DataSetReportAirLinePassport.dsCountPoleRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dsCountPoleRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dsCountPoleRowChangeEventHandler dsCountPoleRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddsCountPoleRow(DataSetReportAirLinePassport.dsCountPoleRow dsCountPoleRow_0)
			{
				base.Rows.Add(dsCountPoleRow_0);
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dsCountPoleDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.columnidObjList = base.Columns["idObjList"];
				this.columnKonc = base.Columns["Konc"];
				this.columnOtv = base.Columns["Otv"];
				this.columnUgl = base.Columns["Ugl"];
				this.columnProm = base.Columns["Prom"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.columnidObjList = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObjList);
				this.columnKonc = new DataColumn("Konc", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnKonc);
				this.columnOtv = new DataColumn("Otv", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnOtv);
				this.columnUgl = new DataColumn("Ugl", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnUgl);
				this.columnProm = new DataColumn("Prom", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnProm);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dsCountPoleRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dsCountPoleRowChanged != null)
				{
					this.dsCountPoleRowChanged(this, new DataSetReportAirLinePassport.dsCountPoleRowChangeEvent((DataSetReportAirLinePassport.dsCountPoleRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dsCountPoleRowChanging != null)
				{
					this.dsCountPoleRowChanging(this, new DataSetReportAirLinePassport.dsCountPoleRowChangeEvent((DataSetReportAirLinePassport.dsCountPoleRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dsCountPoleRowDeleted != null)
				{
					this.dsCountPoleRowDeleted(this, new DataSetReportAirLinePassport.dsCountPoleRowChangeEvent((DataSetReportAirLinePassport.dsCountPoleRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dsCountPoleRowDeleting != null)
				{
					this.dsCountPoleRowDeleting(this, new DataSetReportAirLinePassport.dsCountPoleRowChangeEvent((DataSetReportAirLinePassport.dsCountPoleRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedsCountPoleRow(DataSetReportAirLinePassport.dsCountPoleRow dsCountPoleRow_0)
			{
				base.Rows.Remove(dsCountPoleRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
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

			private DataColumn columnidObjList;

			private DataColumn columnKonc;

			private DataColumn columnOtv;

			private DataColumn columnUgl;

			private DataColumn columnProm;
		}

		public class dsCountPoleRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dsCountPoleRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsidObjListNull()
			{
				return base.IsNull(this.dsCountPoleDataTable_0.idObjListColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsPromNull()
			{
				return base.IsNull(this.dsCountPoleDataTable_0.PromColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPromNull()
			{
				base[this.dsCountPoleDataTable_0.PromColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dsCountPoleDataTable dsCountPoleDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtBranchDataTable : TypedTableBase<DataSetReportAirLinePassport.dtBranchRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtBranchDataTable()
			{
				base.TableName = "dtBranch";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtBranchDataTable(DataTable dataTable_0)
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
			protected dtBranchDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PoleNumColumn
			{
				get
				{
					return this.columnPoleNum;
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
			public DataSetReportAirLinePassport.dtBranchRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtBranchRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtBranchRowChangeEventHandler dtBranchRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtBranchRow(DataSetReportAirLinePassport.dtBranchRow dtBranchRow_0)
			{
				base.Rows.Add(dtBranchRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
				dtBranchDataTable.method_0();
				return dtBranchDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtBranchDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.columnPoleNum = base.Columns["PoleNum"];
				this.dataColumn_0 = base.Columns["ДлинаОтветвленияМ"];
				this.dataColumn_1 = base.Columns["ЧислоВводов"];
				this.dataColumn_2 = base.Columns["ТипПровода"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.columnPoleNum = new DataColumn("PoleNum", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPoleNum);
				this.dataColumn_0 = new DataColumn("ДлинаОтветвленияМ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("ЧислоВводов", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("ТипПровода", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtBranchRow NewdtBranchRow()
			{
				return (DataSetReportAirLinePassport.dtBranchRow)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtBranchRowChanged != null)
				{
					this.dtBranchRowChanged(this, new DataSetReportAirLinePassport.dtBranchRowChangeEvent((DataSetReportAirLinePassport.dtBranchRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtBranchRowChanging != null)
				{
					this.dtBranchRowChanging(this, new DataSetReportAirLinePassport.dtBranchRowChangeEvent((DataSetReportAirLinePassport.dtBranchRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtBranchRowDeleted != null)
				{
					this.dtBranchRowDeleted(this, new DataSetReportAirLinePassport.dtBranchRowChangeEvent((DataSetReportAirLinePassport.dtBranchRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtBranchRowDeleting != null)
				{
					this.dtBranchRowDeleting(this, new DataSetReportAirLinePassport.dtBranchRowChangeEvent((DataSetReportAirLinePassport.dtBranchRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtBranchRow(DataSetReportAirLinePassport.dtBranchRow dtBranchRow_0)
			{
				base.Rows.Remove(dtBranchRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
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

			private DataColumn columnPoleNum;

			private DataColumn dataColumn_0;

			private DataColumn dataColumn_1;

			private DataColumn dataColumn_2;
		}

		public class dtBranchRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtBranchRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_1()
			{
				base[this.dtBranchDataTable_0.DataColumn_0] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_2()
			{
				return base.IsNull(this.dtBranchDataTable_0.DataColumn_1);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_3()
			{
				base[this.dtBranchDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_4()
			{
				return base.IsNull(this.dtBranchDataTable_0.DataColumn_2);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5()
			{
				base[this.dtBranchDataTable_0.DataColumn_2] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtBranchDataTable dtBranchDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtCableInsertionDataTable : TypedTableBase<DataSetReportAirLinePassport.dtCableInsertionRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtCableInsertionDataTable()
			{
				base.TableName = "dtCableInsertion";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtCableInsertionDataTable(DataTable dataTable_0)
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
			protected dtCableInsertionDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PoleNumColumn
			{
				get
				{
					return this.columnPoleNum;
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
			public DataSetReportAirLinePassport.dtCableInsertionRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtCableInsertionRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtCableInsertionRowChangeEventHandler dtCableInsertionRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtCableInsertionRow(DataSetReportAirLinePassport.dtCableInsertionRow dtCableInsertionRow_0)
			{
				base.Rows.Add(dtCableInsertionRow_0);
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
				this.columnPoleNum = base.Columns["PoleNum"];
				this.dataColumn_0 = base.Columns["Назначение"];
				this.dataColumn_1 = base.Columns["ДлинаКабеляМ"];
				this.dataColumn_2 = base.Columns["МаркаКабеля"];
				this.dataColumn_3 = base.Columns["ТипКонцевойМуфты"];
				this.dataColumn_4 = base.Columns["ТипСоединительнойМуфты"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.columnPoleNum = new DataColumn("PoleNum", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPoleNum);
				this.dataColumn_0 = new DataColumn("Назначение", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("ДлинаКабеляМ", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("МаркаКабеля", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("ТипКонцевойМуфты", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("ТипСоединительнойМуфты", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtCableInsertionRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtCableInsertionRowChanged != null)
				{
					this.dtCableInsertionRowChanged(this, new DataSetReportAirLinePassport.dtCableInsertionRowChangeEvent((DataSetReportAirLinePassport.dtCableInsertionRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtCableInsertionRowChanging != null)
				{
					this.dtCableInsertionRowChanging(this, new DataSetReportAirLinePassport.dtCableInsertionRowChangeEvent((DataSetReportAirLinePassport.dtCableInsertionRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtCableInsertionRowDeleted != null)
				{
					this.dtCableInsertionRowDeleted(this, new DataSetReportAirLinePassport.dtCableInsertionRowChangeEvent((DataSetReportAirLinePassport.dtCableInsertionRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtCableInsertionRowDeleting != null)
				{
					this.dtCableInsertionRowDeleting(this, new DataSetReportAirLinePassport.dtCableInsertionRowChangeEvent((DataSetReportAirLinePassport.dtCableInsertionRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovedtCableInsertionRow(DataSetReportAirLinePassport.dtCableInsertionRow dtCableInsertionRow_0)
			{
				base.Rows.Remove(dtCableInsertionRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
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

			private DataColumn columnPoleNum;

			private DataColumn dataColumn_0;

			private DataColumn dataColumn_1;

			private DataColumn dataColumn_2;

			private DataColumn dataColumn_3;

			private DataColumn dataColumn_4;
		}

		public class dtCableInsertionRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtCableInsertionRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.dtCableInsertionDataTable_0 = (DataSetReportAirLinePassport.dtCableInsertionDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_1()
			{
				base[this.dtCableInsertionDataTable_0.DataColumn_0] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_2()
			{
				return base.IsNull(this.dtCableInsertionDataTable_0.DataColumn_1);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_3()
			{
				base[this.dtCableInsertionDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_9()
			{
				base[this.dtCableInsertionDataTable_0.DataColumn_4] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtCableInsertionDataTable dtCableInsertionDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtPylonEquipmentDataTable : TypedTableBase<DataSetReportAirLinePassport.dtPylonEquipmentRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtPylonEquipmentDataTable()
			{
				base.TableName = "dtPylonEquipment";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtPylonEquipmentDataTable(DataTable dataTable_0)
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
			protected dtPylonEquipmentDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
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
			public DataColumn TypeEquipmentColumn
			{
				get
				{
					return this.columnTypeEquipment;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CountColumn
			{
				get
				{
					return this.columnCount;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn PoleNumColumn
			{
				get
				{
					return this.columnPoleNum;
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
			public DataSetReportAirLinePassport.dtPylonEquipmentRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtPylonEquipmentRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEventHandler dtPylonEquipmentRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtPylonEquipmentRow(DataSetReportAirLinePassport.dtPylonEquipmentRow dtPylonEquipmentRow_0)
			{
				base.Rows.Add(dtPylonEquipmentRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtPylonEquipmentDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.columnName = base.Columns["Name"];
				this.columnTypeEquipment = base.Columns["TypeEquipment"];
				this.columnCount = base.Columns["Count"];
				this.columnPoleNum = base.Columns["PoleNum"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnTypeEquipment = new DataColumn("TypeEquipment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTypeEquipment);
				this.columnCount = new DataColumn("Count", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCount);
				this.columnPoleNum = new DataColumn("PoleNum", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPoleNum);
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
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtPylonEquipmentRowChanged != null)
				{
					this.dtPylonEquipmentRowChanged(this, new DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtPylonEquipmentRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtPylonEquipmentRowChanging != null)
				{
					this.dtPylonEquipmentRowChanging(this, new DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtPylonEquipmentRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtPylonEquipmentRowDeleted != null)
				{
					this.dtPylonEquipmentRowDeleted(this, new DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtPylonEquipmentRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtPylonEquipmentRowDeleting != null)
				{
					this.dtPylonEquipmentRowDeleting(this, new DataSetReportAirLinePassport.dtPylonEquipmentRowChangeEvent((DataSetReportAirLinePassport.dtPylonEquipmentRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtPylonEquipmentRow(DataSetReportAirLinePassport.dtPylonEquipmentRow dtPylonEquipmentRow_0)
			{
				base.Rows.Remove(dtPylonEquipmentRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
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

			private DataColumn columnName;

			private DataColumn columnTypeEquipment;

			private DataColumn columnCount;

			private DataColumn columnPoleNum;
		}

		public class dtPylonEquipmentRow : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtPylonEquipmentRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.dtPylonEquipmentDataTable_0 = (DataSetReportAirLinePassport.dtPylonEquipmentDataTable)base.Table;
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameNull()
			{
				base[this.dtPylonEquipmentDataTable_0.NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtJointSuspensionDataTable : TypedTableBase<DataSetReportAirLinePassport.dtJointSuspensionRow>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtJointSuspensionDataTable()
			{
				base.TableName = "dtJointSuspension";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtJointSuspensionDataTable(DataTable dataTable_0)
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
			protected dtJointSuspensionDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
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
			public DataColumn DataColumn_0
			{
				get
				{
					return this.dataColumn_0;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn PoleNumColumn
			{
				get
				{
					return this.columnPoleNum;
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
			public DataColumn WireDistanceColumn
			{
				get
				{
					return this.columnWireDistance;
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
			public DataSetReportAirLinePassport.dtJointSuspensionRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtJointSuspensionRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtJointSuspensionRowChangeEventHandler dtJointSuspensionRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtJointSuspensionRow(DataSetReportAirLinePassport.dtJointSuspensionRow dtJointSuspensionRow_0)
			{
				base.Rows.Add(dtJointSuspensionRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
				this.columnName = base.Columns["Name"];
				this.dataColumn_0 = base.Columns["Напряжение"];
				this.columnPoleNum = base.Columns["PoleNum"];
				this.dataColumn_1 = base.Columns["МаркаКабеля"];
				this.columnWireDistance = base.Columns["WireDistance"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.dataColumn_0 = new DataColumn("Напряжение", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.columnPoleNum = new DataColumn("PoleNum", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPoleNum);
				this.dataColumn_1 = new DataColumn("МаркаКабеля", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.columnWireDistance = new DataColumn("WireDistance", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnWireDistance);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtJointSuspensionRowChanged != null)
				{
					this.dtJointSuspensionRowChanged(this, new DataSetReportAirLinePassport.dtJointSuspensionRowChangeEvent((DataSetReportAirLinePassport.dtJointSuspensionRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtJointSuspensionRowChanging != null)
				{
					this.dtJointSuspensionRowChanging(this, new DataSetReportAirLinePassport.dtJointSuspensionRowChangeEvent((DataSetReportAirLinePassport.dtJointSuspensionRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtJointSuspensionRowDeleted != null)
				{
					this.dtJointSuspensionRowDeleted(this, new DataSetReportAirLinePassport.dtJointSuspensionRowChangeEvent((DataSetReportAirLinePassport.dtJointSuspensionRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtJointSuspensionRowDeleting != null)
				{
					this.dtJointSuspensionRowDeleting(this, new DataSetReportAirLinePassport.dtJointSuspensionRowChangeEvent((DataSetReportAirLinePassport.dtJointSuspensionRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemovedtJointSuspensionRow(DataSetReportAirLinePassport.dtJointSuspensionRow dtJointSuspensionRow_0)
			{
				base.Rows.Remove(dtJointSuspensionRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
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

			private DataColumn columnName;

			private DataColumn dataColumn_0;

			private DataColumn columnPoleNum;

			private DataColumn dataColumn_1;

			private DataColumn columnWireDistance;
		}

		public class dtJointSuspensionRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtJointSuspensionRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tBranchDataTable : TypedTableBase<DataSetReportAirLinePassport.tBranchRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tBranchDataTable()
			{
				base.TableName = "tBranch";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tBranchDataTable(DataTable dataTable_0)
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
			protected tBranchDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
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
			public DataColumn idAirLineColumn
			{
				get
				{
					return this.columnidAirLine;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idPoleColumn
			{
				get
				{
					return this.columnidPole;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idObjColumn
			{
				get
				{
					return this.columnidObj;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PoleNameColumn
			{
				get
				{
					return this.columnPoleName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ObjNameColumn
			{
				get
				{
					return this.columnObjName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn cableTypeColumn
			{
				get
				{
					return this.columncableType;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn cableLengthColumn
			{
				get
				{
					return this.columncableLength;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CountColumn
			{
				get
				{
					return this.columnCount;
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
			public DataSetReportAirLinePassport.tBranchRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.tBranchRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.tBranchRowChangeEventHandler tBranchRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddtBranchRow(DataSetReportAirLinePassport.tBranchRow tBranchRow_0)
			{
				base.Rows.Add(tBranchRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.tBranchRow AddtBranchRow(int int_0, int idAirLine, int idPole, int idObj, string PoleName, string ObjName, string cableType, string cableLength, int Count)
			{
				DataSetReportAirLinePassport.tBranchRow tBranchRow = (DataSetReportAirLinePassport.tBranchRow)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
				this.columnid = base.Columns["id"];
				this.columnidAirLine = base.Columns["idAirLine"];
				this.columnidPole = base.Columns["idPole"];
				this.columnidObj = base.Columns["idObj"];
				this.columnPoleName = base.Columns["PoleName"];
				this.columnObjName = base.Columns["ObjName"];
				this.columncableType = base.Columns["cableType"];
				this.columncableLength = base.Columns["cableLength"];
				this.columnCount = base.Columns["Count"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidAirLine = new DataColumn("idAirLine", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidAirLine);
				this.columnidPole = new DataColumn("idPole", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidPole);
				this.columnidObj = new DataColumn("idObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObj);
				this.columnPoleName = new DataColumn("PoleName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPoleName);
				this.columnObjName = new DataColumn("ObjName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnObjName);
				this.columncableType = new DataColumn("cableType", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncableType);
				this.columncableLength = new DataColumn("cableLength", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncableLength);
				this.columnCount = new DataColumn("Count", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnCount);
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tBranchRowChanged != null)
				{
					this.tBranchRowChanged(this, new DataSetReportAirLinePassport.tBranchRowChangeEvent((DataSetReportAirLinePassport.tBranchRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tBranchRowChanging != null)
				{
					this.tBranchRowChanging(this, new DataSetReportAirLinePassport.tBranchRowChangeEvent((DataSetReportAirLinePassport.tBranchRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tBranchRowDeleted != null)
				{
					this.tBranchRowDeleted(this, new DataSetReportAirLinePassport.tBranchRowChangeEvent((DataSetReportAirLinePassport.tBranchRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tBranchRowDeleting != null)
				{
					this.tBranchRowDeleting(this, new DataSetReportAirLinePassport.tBranchRowChangeEvent((DataSetReportAirLinePassport.tBranchRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovetBranchRow(DataSetReportAirLinePassport.tBranchRow tBranchRow_0)
			{
				base.Rows.Remove(tBranchRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
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

			private DataColumn columnidAirLine;

			private DataColumn columnidPole;

			private DataColumn columnidObj;

			private DataColumn columnPoleName;

			private DataColumn columnObjName;

			private DataColumn columncableType;

			private DataColumn columncableLength;

			private DataColumn columnCount;
		}

		public class tBranchRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tBranchRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tBranchDataTable_0 = (DataSetReportAirLinePassport.tBranchDataTable)base.Table;
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsidNull()
			{
				return base.IsNull(this.tBranchDataTable_0.idColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsPoleNameNull()
			{
				return base.IsNull(this.tBranchDataTable_0.PoleNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtPylonsDataTable : TypedTableBase<DataSetReportAirLinePassport.dtPylonsRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtPylonsDataTable()
			{
				base.TableName = "dtPylons";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtPylonsDataTable(DataTable dataTable_0)
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
			protected dtPylonsDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
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
					return this.dataColumn_7;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn SpanLengthColumn
			{
				get
				{
					return this.columnSpanLength;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CableMakeUpColumn
			{
				get
				{
					return this.columnCableMakeUp;
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn EquipmentListColumn
			{
				get
				{
					return this.columnEquipmentList;
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
			public DataSetReportAirLinePassport.dtPylonsRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtPylonsRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtPylonsRowChangeEventHandler dtPylonsRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AdddtPylonsRow(DataSetReportAirLinePassport.dtPylonsRow dtPylonsRow_0)
			{
				base.Rows.Add(dtPylonsRow_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtPylonsRow AdddtPylonsRow(int int_0, string Name, string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, decimal SpanLength, string CableMakeUp, string string_8, string string_9, string EquipmentList, string typeName)
			{
				DataSetReportAirLinePassport.dtPylonsRow dtPylonsRow = (DataSetReportAirLinePassport.dtPylonsRow)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtPylonsDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_0()
			{
				this.columnid = base.Columns["id"];
				this.columnName = base.Columns["Name"];
				this.dataColumn_0 = base.Columns["Тип"];
				this.dataColumn_1 = base.Columns["Принадлежность"];
				this.dataColumn_2 = base.Columns["ГодУстановки"];
				this.dataColumn_3 = base.Columns["Стойка"];
				this.dataColumn_4 = base.Columns["Подкос"];
				this.dataColumn_5 = base.Columns["Приставка"];
				this.dataColumn_6 = base.Columns["ТипИзолятора"];
				this.dataColumn_7 = base.Columns["Количество"];
				this.columnSpanLength = base.Columns["SpanLength"];
				this.columnCableMakeUp = base.Columns["CableMakeUp"];
				this.dataColumn_8 = base.Columns["НаличиеКонтура"];
				this.dataColumn_9 = base.Columns["Сопротивление"];
				this.columnEquipmentList = base.Columns["EquipmentList"];
				this.columntypeName = base.Columns["typeName"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_1()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.dataColumn_0 = new DataColumn("Тип", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_0);
				this.dataColumn_1 = new DataColumn("Принадлежность", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_1);
				this.dataColumn_2 = new DataColumn("ГодУстановки", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_2);
				this.dataColumn_3 = new DataColumn("Стойка", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_3);
				this.dataColumn_4 = new DataColumn("Подкос", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_4);
				this.dataColumn_5 = new DataColumn("Приставка", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_5);
				this.dataColumn_6 = new DataColumn("ТипИзолятора", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_6);
				this.dataColumn_7 = new DataColumn("Количество", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_7);
				this.columnSpanLength = new DataColumn("SpanLength", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnSpanLength);
				this.columnCableMakeUp = new DataColumn("CableMakeUp", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCableMakeUp);
				this.dataColumn_8 = new DataColumn("НаличиеКонтура", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_8);
				this.dataColumn_9 = new DataColumn("Сопротивление", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.dataColumn_9);
				this.columnEquipmentList = new DataColumn("EquipmentList", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnEquipmentList);
				this.columntypeName = new DataColumn("typeName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntypeName);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtPylonsRow NewdtPylonsRow()
			{
				return (DataSetReportAirLinePassport.dtPylonsRow)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtPylonsRowChanged != null)
				{
					this.dtPylonsRowChanged(this, new DataSetReportAirLinePassport.dtPylonsRowChangeEvent((DataSetReportAirLinePassport.dtPylonsRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtPylonsRowChanging != null)
				{
					this.dtPylonsRowChanging(this, new DataSetReportAirLinePassport.dtPylonsRowChangeEvent((DataSetReportAirLinePassport.dtPylonsRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtPylonsRowDeleted != null)
				{
					this.dtPylonsRowDeleted(this, new DataSetReportAirLinePassport.dtPylonsRowChangeEvent((DataSetReportAirLinePassport.dtPylonsRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtPylonsRowDeleting != null)
				{
					this.dtPylonsRowDeleting(this, new DataSetReportAirLinePassport.dtPylonsRowChangeEvent((DataSetReportAirLinePassport.dtPylonsRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovedtPylonsRow(DataSetReportAirLinePassport.dtPylonsRow dtPylonsRow_0)
			{
				base.Rows.Remove(dtPylonsRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
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

			private DataColumn dataColumn_0;

			private DataColumn dataColumn_1;

			private DataColumn dataColumn_2;

			private DataColumn dataColumn_3;

			private DataColumn dataColumn_4;

			private DataColumn dataColumn_5;

			private DataColumn dataColumn_6;

			private DataColumn dataColumn_7;

			private DataColumn columnSpanLength;

			private DataColumn columnCableMakeUp;

			private DataColumn dataColumn_8;

			private DataColumn dataColumn_9;

			private DataColumn columnEquipmentList;

			private DataColumn columntypeName;
		}

		public class dtPylonsRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtPylonsRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.dtPylonsDataTable_0 = (DataSetReportAirLinePassport.dtPylonsDataTable)base.Table;
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_3()
			{
				base[this.dtPylonsDataTable_0.DataColumn_1] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_8()
			{
				return base.IsNull(this.dtPylonsDataTable_0.DataColumn_4);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetSpanLengthNull()
			{
				base[this.dtPylonsDataTable_0.SpanLengthColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsEquipmentListNull()
			{
				return base.IsNull(this.dtPylonsDataTable_0.EquipmentListColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetEquipmentListNull()
			{
				base[this.dtPylonsDataTable_0.EquipmentListColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IstypeNameNull()
			{
				return base.IsNull(this.dtPylonsDataTable_0.typeNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SettypeNameNull()
			{
				base[this.dtPylonsDataTable_0.typeNameColumn] = Convert.DBNull;
			}

			private DataSetReportAirLinePassport.dtPylonsDataTable dtPylonsDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class dtRoadDataTable : TypedTableBase<DataSetReportAirLinePassport.dtRoadRow>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtRoadDataTable()
			{
				base.TableName = "dtRoad";
				this.BeginInit();
				this.method_1();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal dtRoadDataTable(DataTable dataTable_0)
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
			protected dtRoadDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				this.method_0();
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idRoadTypeColumn
			{
				get
				{
					return this.columnidRoadType;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn RoadNameColumn
			{
				get
				{
					return this.columnRoadName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PylonNumbersColumn
			{
				get
				{
					return this.columnPylonNumbers;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CharacteristicColumn
			{
				get
				{
					return this.columnCharacteristic;
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
			public DataSetReportAirLinePassport.dtRoadRow this[int index]
			{
				get
				{
					return (DataSetReportAirLinePassport.dtRoadRow)base.Rows[index];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetReportAirLinePassport.dtRoadRowChangeEventHandler dtRoadRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AdddtRoadRow(DataSetReportAirLinePassport.dtRoadRow dtRoadRow_0)
			{
				base.Rows.Add(dtRoadRow_0);
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetReportAirLinePassport.dtRoadDataTable dtRoadDataTable = (DataSetReportAirLinePassport.dtRoadDataTable)base.Clone();
				dtRoadDataTable.method_0();
				return dtRoadDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetReportAirLinePassport.dtRoadDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_0()
			{
				this.columnidObjList = base.Columns["idObjList"];
				this.columnidRoadType = base.Columns["idRoadType"];
				this.columnRoadName = base.Columns["RoadName"];
				this.columnPylonNumbers = base.Columns["PylonNumbers"];
				this.columnCharacteristic = base.Columns["Characteristic"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_1()
			{
				this.columnidObjList = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObjList);
				this.columnidRoadType = new DataColumn("idRoadType", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidRoadType);
				this.columnRoadName = new DataColumn("RoadName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRoadName);
				this.columnPylonNumbers = new DataColumn("PylonNumbers", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPylonNumbers);
				this.columnCharacteristic = new DataColumn("Characteristic", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCharacteristic);
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetReportAirLinePassport.dtRoadRow);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.dtRoadRowChanged != null)
				{
					this.dtRoadRowChanged(this, new DataSetReportAirLinePassport.dtRoadRowChangeEvent((DataSetReportAirLinePassport.dtRoadRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.dtRoadRowChanging != null)
				{
					this.dtRoadRowChanging(this, new DataSetReportAirLinePassport.dtRoadRowChangeEvent((DataSetReportAirLinePassport.dtRoadRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.dtRoadRowDeleted != null)
				{
					this.dtRoadRowDeleted(this, new DataSetReportAirLinePassport.dtRoadRowChangeEvent((DataSetReportAirLinePassport.dtRoadRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.dtRoadRowDeleting != null)
				{
					this.dtRoadRowDeleting(this, new DataSetReportAirLinePassport.dtRoadRowChangeEvent((DataSetReportAirLinePassport.dtRoadRow)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemovedtRoadRow(DataSetReportAirLinePassport.dtRoadRow dtRoadRow_0)
			{
				base.Rows.Remove(dtRoadRow_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
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

			private DataColumn columnidObjList;

			private DataColumn columnidRoadType;

			private DataColumn columnRoadName;

			private DataColumn columnPylonNumbers;

			private DataColumn columnCharacteristic;
		}

		public class dtRoadRow : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal dtRoadRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetPylonNumbersNull()
			{
				base[this.dtRoadDataTable_0.PylonNumbersColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtAirLineEquipmentRowChangeEvent : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtAirLineEquipmentRowChangeEvent(DataSetReportAirLinePassport.dtAirLineEquipmentRow dtAirLineEquipmentRow_1, DataRowAction action)
			{
				this.dtAirLineEquipmentRow_0 = dtAirLineEquipmentRow_1;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			public tp_AirLineReportRowChangeEvent(DataSetReportAirLinePassport.tp_AirLineReportRow tp_AirLineReportRow_1, DataRowAction action)
			{
				this.tp_AirLineReportRow_0 = tp_AirLineReportRow_1;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.tp_AirLineReportRow Row
			{
				get
				{
					return this.tp_AirLineReportRow_0;
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

			private DataSetReportAirLinePassport.tp_AirLineReportRow tp_AirLineReportRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtCrossingRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtCrossingRowChangeEvent(DataSetReportAirLinePassport.dtCrossingRow dtCrossingRow_1, DataRowAction action)
			{
				this.dtCrossingRow_0 = dtCrossingRow_1;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dtCrossingRow Row
			{
				get
				{
					return this.dtCrossingRow_0;
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

			private DataSetReportAirLinePassport.dtCrossingRow dtCrossingRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtTerrainRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtTerrainRowChangeEvent(DataSetReportAirLinePassport.dtTerrainRow dtTerrainRow_1, DataRowAction action)
			{
				this.dtTerrainRow_0 = dtTerrainRow_1;
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
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dsCountPoleRowChangeEvent(DataSetReportAirLinePassport.dsCountPoleRow dsCountPoleRow_1, DataRowAction action)
			{
				this.dsCountPoleRow_0 = dsCountPoleRow_1;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetReportAirLinePassport.dsCountPoleRow Row
			{
				get
				{
					return this.dsCountPoleRow_0;
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

			private DataSetReportAirLinePassport.dsCountPoleRow dsCountPoleRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtBranchRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtBranchRowChangeEvent(DataSetReportAirLinePassport.dtBranchRow dtBranchRow_1, DataRowAction action)
			{
				this.dtBranchRow_0 = dtBranchRow_1;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetReportAirLinePassport.dtBranchRow Row
			{
				get
				{
					return this.dtBranchRow_0;
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

			private DataSetReportAirLinePassport.dtBranchRow dtBranchRow_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class dtCableInsertionRowChangeEvent : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public dtCableInsertionRowChangeEvent(DataSetReportAirLinePassport.dtCableInsertionRow dtCableInsertionRow_1, DataRowAction action)
			{
				this.dtCableInsertionRow_0 = dtCableInsertionRow_1;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtPylonEquipmentRowChangeEvent(DataSetReportAirLinePassport.dtPylonEquipmentRow dtPylonEquipmentRow_1, DataRowAction action)
			{
				this.dtPylonEquipmentRow_0 = dtPylonEquipmentRow_1;
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
			public dtJointSuspensionRowChangeEvent(DataSetReportAirLinePassport.dtJointSuspensionRow dtJointSuspensionRow_1, DataRowAction action)
			{
				this.dtJointSuspensionRow_0 = dtJointSuspensionRow_1;
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
			public tBranchRowChangeEvent(DataSetReportAirLinePassport.tBranchRow tBranchRow_1, DataRowAction action)
			{
				this.tBranchRow_0 = tBranchRow_1;
				this.dataRowAction_0 = action;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public dtPylonsRowChangeEvent(DataSetReportAirLinePassport.dtPylonsRow dtPylonsRow_1, DataRowAction action)
			{
				this.dtPylonsRow_0 = dtPylonsRow_1;
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
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
			public dtRoadRowChangeEvent(DataSetReportAirLinePassport.dtRoadRow dtRoadRow_1, DataRowAction action)
			{
				this.dtRoadRow_0 = dtRoadRow_1;
				this.dataRowAction_0 = action;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
	}
}
