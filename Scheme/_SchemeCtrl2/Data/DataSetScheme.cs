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
	[DesignerCategory("code")]
	[XmlRoot("DataSetScheme")]
	[HelpKeyword("vs.data.DataSet")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	internal class DataSetScheme : DataSet
	{
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSetScheme()
		{
			base.BeginInit();
			this.method_2();
			CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_31);
			base.Tables.CollectionChanged += value;
			base.Relations.CollectionChanged += value;
			base.EndInit();
			this.method_32();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected DataSetScheme(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0, false)
		{
			if (base.IsBinarySerialized(serializationInfo_0, streamingContext_0))
			{
				this.method_1(false);
				CollectionChangeEventHandler value = new CollectionChangeEventHandler(this.method_31);
				this.Tables.CollectionChanged += value;
				this.Relations.CollectionChanged += value;
				if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == SchemaSerializationMode.ExcludeSchema)
				{
					this.method_32();
				}
				return;
			}
			string s = (string)serializationInfo_0.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
				if (dataSet.Tables["tSchm_ObjList"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_ObjListDataTable(dataSet.Tables["tSchm_ObjList"]));
				}
				if (dataSet.Tables["tSchm_Schemes"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_SchemesDataTable(dataSet.Tables["tSchm_Schemes"]));
				}
				if (dataSet.Tables["tSchm_Settings"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_SettingsDataTable(dataSet.Tables["tSchm_Settings"]));
				}
				if (dataSet.Tables["tSchm_Relation"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_RelationDataTable(dataSet.Tables["tSchm_Relation"]));
				}
				if (dataSet.Tables["tSchm_Xml"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_XmlDataTable(dataSet.Tables["tSchm_Xml"]));
				}
				if (dataSet.Tables["vSchm_ObjListXml"] != null)
				{
					base.Tables.Add(new DataSetScheme.vSchm_ObjListXmlDataTable(dataSet.Tables["vSchm_ObjListXml"]));
				}
				if (dataSet.Tables["tOPC_MessageConfig"] != null)
				{
					base.Tables.Add(new DataSetScheme.tOPC_MessageConfigDataTable(dataSet.Tables["tOPC_MessageConfig"]));
				}
				if (dataSet.Tables["tR_Classifier"] != null)
				{
					base.Tables.Add(new DataSetScheme.tR_ClassifierDataTable(dataSet.Tables["tR_Classifier"]));
				}
				if (dataSet.Tables["vSchm_ObjList"] != null)
				{
					base.Tables.Add(new DataSetScheme.vSchm_ObjListDataTable(dataSet.Tables["vSchm_ObjList"]));
				}
				if (dataSet.Tables["tSchm_ObjFilter"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_ObjFilterDataTable(dataSet.Tables["tSchm_ObjFilter"]));
				}
				if (dataSet.Tables["tSchm_Label"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_LabelDataTable(dataSet.Tables["tSchm_Label"]));
				}
				if (dataSet.Tables["tSchm_Lock"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_LockDataTable(dataSet.Tables["tSchm_Lock"]));
				}
				if (dataSet.Tables["tSchm_LogDispatcher"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_LogDispatcherDataTable(dataSet.Tables["tSchm_LogDispatcher"]));
				}
				if (dataSet.Tables["vSchm_TreeCellLine"] != null)
				{
					base.Tables.Add(new DataSetScheme.vSchm_TreeCellLineDataTable(dataSet.Tables["vSchm_TreeCellLine"]));
				}
				if (dataSet.Tables["tP_Passport"] != null)
				{
					base.Tables.Add(new DataSetScheme.tP_PassportDataTable(dataSet.Tables["tP_Passport"]));
				}
				if (dataSet.Tables["vSchm_CabSection"] != null)
				{
					base.Tables.Add(new DataSetScheme.vSchm_CabSectionDataTable(dataSet.Tables["vSchm_CabSection"]));
				}
				if (dataSet.Tables["tJ_RelayProtectionAutomation"] != null)
				{
					base.Tables.Add(new DataSetScheme.tJ_RelayProtectionAutomationDataTable(dataSet.Tables["tJ_RelayProtectionAutomation"]));
				}
				if (dataSet.Tables["tJ_RelayProtectionAutomationValue"] != null)
				{
					base.Tables.Add(new DataSetScheme.tJ_RelayProtectionAutomationValueDataTable(dataSet.Tables["tJ_RelayProtectionAutomationValue"]));
				}
				if (dataSet.Tables["vJ_RelayProtectionAutomation"] != null)
				{
					base.Tables.Add(new DataSetScheme.vJ_RelayProtectionAutomationDataTable(dataSet.Tables["vJ_RelayProtectionAutomation"]));
				}
				if (dataSet.Tables["vSchm_LogDispatcher"] != null)
				{
					base.Tables.Add(new DataSetScheme.vSchm_LogDispatcherDataTable(dataSet.Tables["vSchm_LogDispatcher"]));
				}
				if (dataSet.Tables["tP_CharList"] != null)
				{
					base.Tables.Add(new DataSetScheme.tP_CharListDataTable(dataSet.Tables["tP_CharList"]));
				}
				if (dataSet.Tables["tP_CabOperation"] != null)
				{
					base.Tables.Add(new DataSetScheme.tP_CabOperationDataTable(dataSet.Tables["tP_CabOperation"]));
				}
				if (dataSet.Tables["v_AbnObjRazresh"] != null)
				{
					base.Tables.Add(new DataSetScheme.v_AbnObjRazreshDataTable(dataSet.Tables["v_AbnObjRazresh"]));
				}
				if (dataSet.Tables["tAbnContact"] != null)
				{
					base.Tables.Add(new DataSetScheme.tAbnContactDataTable(dataSet.Tables["tAbnContact"]));
				}
				if (dataSet.Tables["tSchm_ObjFile"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_ObjFileDataTable(dataSet.Tables["tSchm_ObjFile"]));
				}
				if (dataSet.Tables["vL_SchmAbnFull"] != null)
				{
					base.Tables.Add(new DataSetScheme.vL_SchmAbnFullDataTable(dataSet.Tables["vL_SchmAbnFull"]));
				}
				if (dataSet.Tables["vP_PassportDataReports"] != null)
				{
					base.Tables.Add(new DataSetScheme.vP_PassportDataReportsDataTable(dataSet.Tables["vP_PassportDataReports"]));
				}
				if (dataSet.Tables["tSchm_Ercloud"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_ErcloudDataTable(dataSet.Tables["tSchm_Ercloud"]));
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
				this.method_32();
			}
			base.GetSerializationData(serializationInfo_0, streamingContext_0);
			CollectionChangeEventHandler value2 = new CollectionChangeEventHandler(this.method_31);
			base.Tables.CollectionChanged += value2;
			this.Relations.CollectionChanged += value2;
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public DataSetScheme.tSchm_ObjListDataTable tSchm_ObjList
		{
			get
			{
				return this.tabletSchm_ObjList;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		public DataSetScheme.tSchm_SchemesDataTable tSchm_Schemes
		{
			get
			{
				return this.tabletSchm_Schemes;
			}
		}

		[DebuggerNonUserCode]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetScheme.tSchm_SettingsDataTable tSchm_Settings
		{
			get
			{
				return this.tabletSchm_Settings;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public DataSetScheme.tSchm_RelationDataTable tSchm_Relation
		{
			get
			{
				return this.tabletSchm_Relation;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public DataSetScheme.tSchm_XmlDataTable tSchm_Xml
		{
			get
			{
				return this.tabletSchm_Xml;
			}
		}

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public DataSetScheme.vSchm_ObjListXmlDataTable vSchm_ObjListXml
		{
			get
			{
				return this.tablevSchm_ObjListXml;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetScheme.tOPC_MessageConfigDataTable tOPC_MessageConfig
		{
			get
			{
				return this.tabletOPC_MessageConfig;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetScheme.tR_ClassifierDataTable tR_Classifier
		{
			get
			{
				return this.tabletR_Classifier;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetScheme.vSchm_ObjListDataTable vSchm_ObjList
		{
			get
			{
				return this.tablevSchm_ObjList;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public DataSetScheme.tSchm_ObjFilterDataTable tSchm_ObjFilter
		{
			get
			{
				return this.tabletSchm_ObjFilter;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public DataSetScheme.tSchm_LabelDataTable tSchm_Label
		{
			get
			{
				return this.tabletSchm_Label;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public DataSetScheme.tSchm_LockDataTable tSchm_Lock
		{
			get
			{
				return this.tabletSchm_Lock;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetScheme.tSchm_LogDispatcherDataTable tSchm_LogDispatcher
		{
			get
			{
				return this.tabletSchm_LogDispatcher;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public DataSetScheme.vSchm_TreeCellLineDataTable vSchm_TreeCellLine
		{
			get
			{
				return this.tablevSchm_TreeCellLine;
			}
		}

		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public DataSetScheme.tP_PassportDataTable tP_Passport
		{
			get
			{
				return this.tabletP_Passport;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetScheme.vSchm_CabSectionDataTable vSchm_CabSection
		{
			get
			{
				return this.tablevSchm_CabSection;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetScheme.tJ_RelayProtectionAutomationDataTable tJ_RelayProtectionAutomation
		{
			get
			{
				return this.tabletJ_RelayProtectionAutomation;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetScheme.tJ_RelayProtectionAutomationValueDataTable tJ_RelayProtectionAutomationValue
		{
			get
			{
				return this.tabletJ_RelayProtectionAutomationValue;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetScheme.vJ_RelayProtectionAutomationDataTable vJ_RelayProtectionAutomation
		{
			get
			{
				return this.tablevJ_RelayProtectionAutomation;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public DataSetScheme.vSchm_LogDispatcherDataTable vSchm_LogDispatcher
		{
			get
			{
				return this.tablevSchm_LogDispatcher;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public DataSetScheme.tP_CharListDataTable tP_CharList
		{
			get
			{
				return this.tabletP_CharList;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetScheme.tP_CabOperationDataTable tP_CabOperation
		{
			get
			{
				return this.tabletP_CabOperation;
			}
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetScheme.v_AbnObjRazreshDataTable v_AbnObjRazresh
		{
			get
			{
				return this.tablev_AbnObjRazresh;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		public DataSetScheme.tAbnContactDataTable tAbnContact
		{
			get
			{
				return this.tabletAbnContact;
			}
		}

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetScheme.tSchm_ObjFileDataTable tSchm_ObjFile
		{
			get
			{
				return this.tabletSchm_ObjFile;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DebuggerNonUserCode]
		public DataSetScheme.vL_SchmAbnFullDataTable vL_SchmAbnFull
		{
			get
			{
				return this.tablevL_SchmAbnFull;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DataSetScheme.vP_PassportDataReportsDataTable vP_PassportDataReports
		{
			get
			{
				return this.tablevP_PassportDataReports;
			}
		}

		[DebuggerNonUserCode]
		[Browsable(false)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public DataSetScheme.tSchm_ErcloudDataTable tSchm_Ercloud
		{
			get
			{
				return this.tabletSchm_Ercloud;
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
			DataSetScheme dataSetScheme = (DataSetScheme)base.Clone();
			dataSetScheme.method_0();
			dataSetScheme.method_32();
			dataSetScheme.SchemaSerializationMode = this.SchemaSerializationMode;
			return dataSetScheme;
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["tSchm_ObjList"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_ObjListDataTable(dataSet.Tables["tSchm_ObjList"]));
				}
				if (dataSet.Tables["tSchm_Schemes"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_SchemesDataTable(dataSet.Tables["tSchm_Schemes"]));
				}
				if (dataSet.Tables["tSchm_Settings"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_SettingsDataTable(dataSet.Tables["tSchm_Settings"]));
				}
				if (dataSet.Tables["tSchm_Relation"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_RelationDataTable(dataSet.Tables["tSchm_Relation"]));
				}
				if (dataSet.Tables["tSchm_Xml"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_XmlDataTable(dataSet.Tables["tSchm_Xml"]));
				}
				if (dataSet.Tables["vSchm_ObjListXml"] != null)
				{
					base.Tables.Add(new DataSetScheme.vSchm_ObjListXmlDataTable(dataSet.Tables["vSchm_ObjListXml"]));
				}
				if (dataSet.Tables["tOPC_MessageConfig"] != null)
				{
					base.Tables.Add(new DataSetScheme.tOPC_MessageConfigDataTable(dataSet.Tables["tOPC_MessageConfig"]));
				}
				if (dataSet.Tables["tR_Classifier"] != null)
				{
					base.Tables.Add(new DataSetScheme.tR_ClassifierDataTable(dataSet.Tables["tR_Classifier"]));
				}
				if (dataSet.Tables["vSchm_ObjList"] != null)
				{
					base.Tables.Add(new DataSetScheme.vSchm_ObjListDataTable(dataSet.Tables["vSchm_ObjList"]));
				}
				if (dataSet.Tables["tSchm_ObjFilter"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_ObjFilterDataTable(dataSet.Tables["tSchm_ObjFilter"]));
				}
				if (dataSet.Tables["tSchm_Label"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_LabelDataTable(dataSet.Tables["tSchm_Label"]));
				}
				if (dataSet.Tables["tSchm_Lock"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_LockDataTable(dataSet.Tables["tSchm_Lock"]));
				}
				if (dataSet.Tables["tSchm_LogDispatcher"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_LogDispatcherDataTable(dataSet.Tables["tSchm_LogDispatcher"]));
				}
				if (dataSet.Tables["vSchm_TreeCellLine"] != null)
				{
					base.Tables.Add(new DataSetScheme.vSchm_TreeCellLineDataTable(dataSet.Tables["vSchm_TreeCellLine"]));
				}
				if (dataSet.Tables["tP_Passport"] != null)
				{
					base.Tables.Add(new DataSetScheme.tP_PassportDataTable(dataSet.Tables["tP_Passport"]));
				}
				if (dataSet.Tables["vSchm_CabSection"] != null)
				{
					base.Tables.Add(new DataSetScheme.vSchm_CabSectionDataTable(dataSet.Tables["vSchm_CabSection"]));
				}
				if (dataSet.Tables["tJ_RelayProtectionAutomation"] != null)
				{
					base.Tables.Add(new DataSetScheme.tJ_RelayProtectionAutomationDataTable(dataSet.Tables["tJ_RelayProtectionAutomation"]));
				}
				if (dataSet.Tables["tJ_RelayProtectionAutomationValue"] != null)
				{
					base.Tables.Add(new DataSetScheme.tJ_RelayProtectionAutomationValueDataTable(dataSet.Tables["tJ_RelayProtectionAutomationValue"]));
				}
				if (dataSet.Tables["vJ_RelayProtectionAutomation"] != null)
				{
					base.Tables.Add(new DataSetScheme.vJ_RelayProtectionAutomationDataTable(dataSet.Tables["vJ_RelayProtectionAutomation"]));
				}
				if (dataSet.Tables["vSchm_LogDispatcher"] != null)
				{
					base.Tables.Add(new DataSetScheme.vSchm_LogDispatcherDataTable(dataSet.Tables["vSchm_LogDispatcher"]));
				}
				if (dataSet.Tables["tP_CharList"] != null)
				{
					base.Tables.Add(new DataSetScheme.tP_CharListDataTable(dataSet.Tables["tP_CharList"]));
				}
				if (dataSet.Tables["tP_CabOperation"] != null)
				{
					base.Tables.Add(new DataSetScheme.tP_CabOperationDataTable(dataSet.Tables["tP_CabOperation"]));
				}
				if (dataSet.Tables["v_AbnObjRazresh"] != null)
				{
					base.Tables.Add(new DataSetScheme.v_AbnObjRazreshDataTable(dataSet.Tables["v_AbnObjRazresh"]));
				}
				if (dataSet.Tables["tAbnContact"] != null)
				{
					base.Tables.Add(new DataSetScheme.tAbnContactDataTable(dataSet.Tables["tAbnContact"]));
				}
				if (dataSet.Tables["tSchm_ObjFile"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_ObjFileDataTable(dataSet.Tables["tSchm_ObjFile"]));
				}
				if (dataSet.Tables["vL_SchmAbnFull"] != null)
				{
					base.Tables.Add(new DataSetScheme.vL_SchmAbnFullDataTable(dataSet.Tables["vL_SchmAbnFull"]));
				}
				if (dataSet.Tables["vP_PassportDataReports"] != null)
				{
					base.Tables.Add(new DataSetScheme.vP_PassportDataReportsDataTable(dataSet.Tables["vP_PassportDataReports"]));
				}
				if (dataSet.Tables["tSchm_Ercloud"] != null)
				{
					base.Tables.Add(new DataSetScheme.tSchm_ErcloudDataTable(dataSet.Tables["tSchm_Ercloud"]));
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
			this.tabletSchm_ObjList = (DataSetScheme.tSchm_ObjListDataTable)base.Tables["tSchm_ObjList"];
			if (bool_0 && this.tabletSchm_ObjList != null)
			{
				this.tabletSchm_ObjList.method_3();
			}
			this.tabletSchm_Schemes = (DataSetScheme.tSchm_SchemesDataTable)base.Tables["tSchm_Schemes"];
			if (bool_0 && this.tabletSchm_Schemes != null)
			{
				this.tabletSchm_Schemes.method_3();
			}
			this.tabletSchm_Settings = (DataSetScheme.tSchm_SettingsDataTable)base.Tables["tSchm_Settings"];
			if (bool_0 && this.tabletSchm_Settings != null)
			{
				this.tabletSchm_Settings.method_3();
			}
			this.tabletSchm_Relation = (DataSetScheme.tSchm_RelationDataTable)base.Tables["tSchm_Relation"];
			if (bool_0 && this.tabletSchm_Relation != null)
			{
				this.tabletSchm_Relation.method_3();
			}
			this.tabletSchm_Xml = (DataSetScheme.tSchm_XmlDataTable)base.Tables["tSchm_Xml"];
			if (bool_0 && this.tabletSchm_Xml != null)
			{
				this.tabletSchm_Xml.method_3();
			}
			this.tablevSchm_ObjListXml = (DataSetScheme.vSchm_ObjListXmlDataTable)base.Tables["vSchm_ObjListXml"];
			if (bool_0 && this.tablevSchm_ObjListXml != null)
			{
				this.tablevSchm_ObjListXml.method_2();
			}
			this.tabletOPC_MessageConfig = (DataSetScheme.tOPC_MessageConfigDataTable)base.Tables["tOPC_MessageConfig"];
			if (bool_0 && this.tabletOPC_MessageConfig != null)
			{
				this.tabletOPC_MessageConfig.method_3();
			}
			this.tabletR_Classifier = (DataSetScheme.tR_ClassifierDataTable)base.Tables["tR_Classifier"];
			if (bool_0 && this.tabletR_Classifier != null)
			{
				this.tabletR_Classifier.method_3();
			}
			this.tablevSchm_ObjList = (DataSetScheme.vSchm_ObjListDataTable)base.Tables["vSchm_ObjList"];
			if (bool_0 && this.tablevSchm_ObjList != null)
			{
				this.tablevSchm_ObjList.method_3();
			}
			this.tabletSchm_ObjFilter = (DataSetScheme.tSchm_ObjFilterDataTable)base.Tables["tSchm_ObjFilter"];
			if (bool_0 && this.tabletSchm_ObjFilter != null)
			{
				this.tabletSchm_ObjFilter.method_3();
			}
			this.tabletSchm_Label = (DataSetScheme.tSchm_LabelDataTable)base.Tables["tSchm_Label"];
			if (bool_0 && this.tabletSchm_Label != null)
			{
				this.tabletSchm_Label.method_3();
			}
			this.tabletSchm_Lock = (DataSetScheme.tSchm_LockDataTable)base.Tables["tSchm_Lock"];
			if (bool_0 && this.tabletSchm_Lock != null)
			{
				this.tabletSchm_Lock.method_3();
			}
			this.tabletSchm_LogDispatcher = (DataSetScheme.tSchm_LogDispatcherDataTable)base.Tables["tSchm_LogDispatcher"];
			if (bool_0 && this.tabletSchm_LogDispatcher != null)
			{
				this.tabletSchm_LogDispatcher.method_3();
			}
			this.tablevSchm_TreeCellLine = (DataSetScheme.vSchm_TreeCellLineDataTable)base.Tables["vSchm_TreeCellLine"];
			if (bool_0 && this.tablevSchm_TreeCellLine != null)
			{
				this.tablevSchm_TreeCellLine.method_2();
			}
			this.tabletP_Passport = (DataSetScheme.tP_PassportDataTable)base.Tables["tP_Passport"];
			if (bool_0 && this.tabletP_Passport != null)
			{
				this.tabletP_Passport.method_3();
			}
			this.tablevSchm_CabSection = (DataSetScheme.vSchm_CabSectionDataTable)base.Tables["vSchm_CabSection"];
			if (bool_0 && this.tablevSchm_CabSection != null)
			{
				this.tablevSchm_CabSection.method_3();
			}
			this.tabletJ_RelayProtectionAutomation = (DataSetScheme.tJ_RelayProtectionAutomationDataTable)base.Tables["tJ_RelayProtectionAutomation"];
			if (bool_0 && this.tabletJ_RelayProtectionAutomation != null)
			{
				this.tabletJ_RelayProtectionAutomation.method_3();
			}
			this.tabletJ_RelayProtectionAutomationValue = (DataSetScheme.tJ_RelayProtectionAutomationValueDataTable)base.Tables["tJ_RelayProtectionAutomationValue"];
			if (bool_0 && this.tabletJ_RelayProtectionAutomationValue != null)
			{
				this.tabletJ_RelayProtectionAutomationValue.method_3();
			}
			this.tablevJ_RelayProtectionAutomation = (DataSetScheme.vJ_RelayProtectionAutomationDataTable)base.Tables["vJ_RelayProtectionAutomation"];
			if (bool_0 && this.tablevJ_RelayProtectionAutomation != null)
			{
				this.tablevJ_RelayProtectionAutomation.method_3();
			}
			this.tablevSchm_LogDispatcher = (DataSetScheme.vSchm_LogDispatcherDataTable)base.Tables["vSchm_LogDispatcher"];
			if (bool_0 && this.tablevSchm_LogDispatcher != null)
			{
				this.tablevSchm_LogDispatcher.method_2();
			}
			this.tabletP_CharList = (DataSetScheme.tP_CharListDataTable)base.Tables["tP_CharList"];
			if (bool_0 && this.tabletP_CharList != null)
			{
				this.tabletP_CharList.method_3();
			}
			this.tabletP_CabOperation = (DataSetScheme.tP_CabOperationDataTable)base.Tables["tP_CabOperation"];
			if (bool_0 && this.tabletP_CabOperation != null)
			{
				this.tabletP_CabOperation.method_3();
			}
			this.tablev_AbnObjRazresh = (DataSetScheme.v_AbnObjRazreshDataTable)base.Tables["v_AbnObjRazresh"];
			if (bool_0 && this.tablev_AbnObjRazresh != null)
			{
				this.tablev_AbnObjRazresh.method_2();
			}
			this.tabletAbnContact = (DataSetScheme.tAbnContactDataTable)base.Tables["tAbnContact"];
			if (bool_0 && this.tabletAbnContact != null)
			{
				this.tabletAbnContact.method_3();
			}
			this.tabletSchm_ObjFile = (DataSetScheme.tSchm_ObjFileDataTable)base.Tables["tSchm_ObjFile"];
			if (bool_0 && this.tabletSchm_ObjFile != null)
			{
				this.tabletSchm_ObjFile.method_3();
			}
			this.tablevL_SchmAbnFull = (DataSetScheme.vL_SchmAbnFullDataTable)base.Tables["vL_SchmAbnFull"];
			if (bool_0 && this.tablevL_SchmAbnFull != null)
			{
				this.tablevL_SchmAbnFull.method_2();
			}
			this.tablevP_PassportDataReports = (DataSetScheme.vP_PassportDataReportsDataTable)base.Tables["vP_PassportDataReports"];
			if (bool_0 && this.tablevP_PassportDataReports != null)
			{
				this.tablevP_PassportDataReports.method_3();
			}
			this.tabletSchm_Ercloud = (DataSetScheme.tSchm_ErcloudDataTable)base.Tables["tSchm_Ercloud"];
			if (bool_0 && this.tabletSchm_Ercloud != null)
			{
				this.tabletSchm_Ercloud.method_3();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_2()
		{
			base.DataSetName = "DataSetScheme";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/DataSetScheme.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tabletSchm_ObjList = new DataSetScheme.tSchm_ObjListDataTable();
			base.Tables.Add(this.tabletSchm_ObjList);
			this.tabletSchm_Schemes = new DataSetScheme.tSchm_SchemesDataTable();
			base.Tables.Add(this.tabletSchm_Schemes);
			this.tabletSchm_Settings = new DataSetScheme.tSchm_SettingsDataTable();
			base.Tables.Add(this.tabletSchm_Settings);
			this.tabletSchm_Relation = new DataSetScheme.tSchm_RelationDataTable();
			base.Tables.Add(this.tabletSchm_Relation);
			this.tabletSchm_Xml = new DataSetScheme.tSchm_XmlDataTable();
			base.Tables.Add(this.tabletSchm_Xml);
			this.tablevSchm_ObjListXml = new DataSetScheme.vSchm_ObjListXmlDataTable();
			base.Tables.Add(this.tablevSchm_ObjListXml);
			this.tabletOPC_MessageConfig = new DataSetScheme.tOPC_MessageConfigDataTable();
			base.Tables.Add(this.tabletOPC_MessageConfig);
			this.tabletR_Classifier = new DataSetScheme.tR_ClassifierDataTable();
			base.Tables.Add(this.tabletR_Classifier);
			this.tablevSchm_ObjList = new DataSetScheme.vSchm_ObjListDataTable();
			base.Tables.Add(this.tablevSchm_ObjList);
			this.tabletSchm_ObjFilter = new DataSetScheme.tSchm_ObjFilterDataTable();
			base.Tables.Add(this.tabletSchm_ObjFilter);
			this.tabletSchm_Label = new DataSetScheme.tSchm_LabelDataTable();
			base.Tables.Add(this.tabletSchm_Label);
			this.tabletSchm_Lock = new DataSetScheme.tSchm_LockDataTable();
			base.Tables.Add(this.tabletSchm_Lock);
			this.tabletSchm_LogDispatcher = new DataSetScheme.tSchm_LogDispatcherDataTable();
			base.Tables.Add(this.tabletSchm_LogDispatcher);
			this.tablevSchm_TreeCellLine = new DataSetScheme.vSchm_TreeCellLineDataTable();
			base.Tables.Add(this.tablevSchm_TreeCellLine);
			this.tabletP_Passport = new DataSetScheme.tP_PassportDataTable();
			base.Tables.Add(this.tabletP_Passport);
			this.tablevSchm_CabSection = new DataSetScheme.vSchm_CabSectionDataTable();
			base.Tables.Add(this.tablevSchm_CabSection);
			this.tabletJ_RelayProtectionAutomation = new DataSetScheme.tJ_RelayProtectionAutomationDataTable();
			base.Tables.Add(this.tabletJ_RelayProtectionAutomation);
			this.tabletJ_RelayProtectionAutomationValue = new DataSetScheme.tJ_RelayProtectionAutomationValueDataTable();
			base.Tables.Add(this.tabletJ_RelayProtectionAutomationValue);
			this.tablevJ_RelayProtectionAutomation = new DataSetScheme.vJ_RelayProtectionAutomationDataTable(false);
			base.Tables.Add(this.tablevJ_RelayProtectionAutomation);
			this.tablevSchm_LogDispatcher = new DataSetScheme.vSchm_LogDispatcherDataTable();
			base.Tables.Add(this.tablevSchm_LogDispatcher);
			this.tabletP_CharList = new DataSetScheme.tP_CharListDataTable();
			base.Tables.Add(this.tabletP_CharList);
			this.tabletP_CabOperation = new DataSetScheme.tP_CabOperationDataTable();
			base.Tables.Add(this.tabletP_CabOperation);
			this.tablev_AbnObjRazresh = new DataSetScheme.v_AbnObjRazreshDataTable();
			base.Tables.Add(this.tablev_AbnObjRazresh);
			this.tabletAbnContact = new DataSetScheme.tAbnContactDataTable();
			base.Tables.Add(this.tabletAbnContact);
			this.tabletSchm_ObjFile = new DataSetScheme.tSchm_ObjFileDataTable();
			base.Tables.Add(this.tabletSchm_ObjFile);
			this.tablevL_SchmAbnFull = new DataSetScheme.vL_SchmAbnFullDataTable();
			base.Tables.Add(this.tablevL_SchmAbnFull);
			this.tablevP_PassportDataReports = new DataSetScheme.vP_PassportDataReportsDataTable();
			base.Tables.Add(this.tablevP_PassportDataReports);
			this.tabletSchm_Ercloud = new DataSetScheme.tSchm_ErcloudDataTable();
			base.Tables.Add(this.tabletSchm_Ercloud);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool method_27()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool method_28()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool method_29()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool method_30()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_31(object sender, CollectionChangeEventArgs e)
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
			DataSetScheme dataSetScheme = new DataSetScheme();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = dataSetScheme.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void method_32()
		{
			this.vJ_RelayProtectionAutomation.CoefTRColumn.Expression = "amp_primary + '/' + amp_secondary";
		}

		private DataSetScheme.tSchm_ObjListDataTable tabletSchm_ObjList;

		private DataSetScheme.tSchm_SchemesDataTable tabletSchm_Schemes;

		private DataSetScheme.tSchm_SettingsDataTable tabletSchm_Settings;

		private DataSetScheme.tSchm_RelationDataTable tabletSchm_Relation;

		private DataSetScheme.tSchm_XmlDataTable tabletSchm_Xml;

		private DataSetScheme.vSchm_ObjListXmlDataTable tablevSchm_ObjListXml;

		private DataSetScheme.tOPC_MessageConfigDataTable tabletOPC_MessageConfig;

		private DataSetScheme.tR_ClassifierDataTable tabletR_Classifier;

		private DataSetScheme.vSchm_ObjListDataTable tablevSchm_ObjList;

		private DataSetScheme.tSchm_ObjFilterDataTable tabletSchm_ObjFilter;

		private DataSetScheme.tSchm_LabelDataTable tabletSchm_Label;

		private DataSetScheme.tSchm_LockDataTable tabletSchm_Lock;

		private DataSetScheme.tSchm_LogDispatcherDataTable tabletSchm_LogDispatcher;

		private DataSetScheme.vSchm_TreeCellLineDataTable tablevSchm_TreeCellLine;

		private DataSetScheme.tP_PassportDataTable tabletP_Passport;

		private DataSetScheme.vSchm_CabSectionDataTable tablevSchm_CabSection;

		private DataSetScheme.tJ_RelayProtectionAutomationDataTable tabletJ_RelayProtectionAutomation;

		private DataSetScheme.tJ_RelayProtectionAutomationValueDataTable tabletJ_RelayProtectionAutomationValue;

		private DataSetScheme.vJ_RelayProtectionAutomationDataTable tablevJ_RelayProtectionAutomation;

		private DataSetScheme.vSchm_LogDispatcherDataTable tablevSchm_LogDispatcher;

		private DataSetScheme.tP_CharListDataTable tabletP_CharList;

		private DataSetScheme.tP_CabOperationDataTable tabletP_CabOperation;

		private DataSetScheme.v_AbnObjRazreshDataTable tablev_AbnObjRazresh;

		private DataSetScheme.tAbnContactDataTable tabletAbnContact;

		private DataSetScheme.tSchm_ObjFileDataTable tabletSchm_ObjFile;

		private DataSetScheme.vL_SchmAbnFullDataTable tablevL_SchmAbnFull;

		private DataSetScheme.vP_PassportDataReportsDataTable tablevP_PassportDataReports;

		private DataSetScheme.tSchm_ErcloudDataTable tabletSchm_Ercloud;

		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate2(object sender, DataSetScheme.EventArgs0 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate3(object sender, DataSetScheme.EventArgs1 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate4(object sender, DataSetScheme.EventArgs2 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate5(object sender, DataSetScheme.EventArgs3 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate6(object sender, DataSetScheme.EventArgs4 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate7(object sender, DataSetScheme.EventArgs5 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate8(object sender, DataSetScheme.EventArgs6 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate9(object sender, DataSetScheme.EventArgs7 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate10(object sender, DataSetScheme.EventArgs8 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate11(object sender, DataSetScheme.EventArgs9 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate12(object sender, DataSetScheme.EventArgs10 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate13(object sender, DataSetScheme.EventArgs11 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate14(object sender, DataSetScheme.EventArgs12 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate15(object sender, DataSetScheme.EventArgs13 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate16(object sender, DataSetScheme.EventArgs14 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate17(object sender, DataSetScheme.EventArgs15 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate18(object sender, DataSetScheme.EventArgs16 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate19(object sender, DataSetScheme.EventArgs17 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate20(object sender, DataSetScheme.EventArgs18 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate21(object sender, DataSetScheme.EventArgs19 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate22(object sender, DataSetScheme.EventArgs20 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate23(object sender, DataSetScheme.EventArgs21 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate24(object sender, DataSetScheme.EventArgs22 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate25(object sender, DataSetScheme.EventArgs23 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate26(object sender, DataSetScheme.EventArgs24 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate27(object sender, DataSetScheme.EventArgs25 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate28(object sender, DataSetScheme.EventArgs26 e);

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void Delegate29(object sender, DataSetScheme.EventArgs27 e);

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSchm_ObjListDataTable : TypedTableBase<DataSetScheme.Class45>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tSchm_ObjListDataTable()
			{
				base.TableName = "tSchm_ObjList";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tSchm_ObjListDataTable(DataTable dataTable_0)
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
			protected tSchm_ObjListDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IdColumn
			{
				get
				{
					return this.columnId;
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
			public DataColumn TypeCodeIdColumn
			{
				get
				{
					return this.columnTypeCodeId;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn OnOffColumn
			{
				get
				{
					return this.columnOnOff;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idParentColumn
			{
				get
				{
					return this.columnidParent;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idGroupColumn
			{
				get
				{
					return this.columnidGroup;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idParentAddlColumn
			{
				get
				{
					return this.columnidParentAddl;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TagColumn
			{
				get
				{
					return this.columnTag;
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
			public DataSetScheme.Class45 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class45)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate2 tSchm_ObjListRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate2 tSchm_ObjListRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate2 tSchm_ObjListRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate2 tSchm_ObjListRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class45 class45_0)
			{
				base.Rows.Add(class45_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class45 method_1(string string_0, int int_0, bool bool_0, int int_1, int int_2, int int_3, int int_4)
			{
				DataSetScheme.Class45 @class = (DataSetScheme.Class45)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					string_0,
					int_0,
					bool_0,
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
			public DataSetScheme.Class45 method_2(int int_0)
			{
				return (DataSetScheme.Class45)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.tSchm_ObjListDataTable tSchm_ObjListDataTable = (DataSetScheme.tSchm_ObjListDataTable)base.Clone();
				tSchm_ObjListDataTable.method_3();
				return tSchm_ObjListDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tSchm_ObjListDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnId = base.Columns["Id"];
				this.columnName = base.Columns["Name"];
				this.columnTypeCodeId = base.Columns["TypeCodeId"];
				this.columnOnOff = base.Columns["OnOff"];
				this.columnidParent = base.Columns["idParent"];
				this.columnidGroup = base.Columns["idGroup"];
				this.columnidParentAddl = base.Columns["idParentAddl"];
				this.columnTag = base.Columns["Tag"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
			{
				this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnId);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnTypeCodeId = new DataColumn("TypeCodeId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTypeCodeId);
				this.columnOnOff = new DataColumn("OnOff", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnOnOff);
				this.columnidParent = new DataColumn("idParent", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidParent);
				this.columnidGroup = new DataColumn("idGroup", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidGroup);
				this.columnidParentAddl = new DataColumn("idParentAddl", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidParentAddl);
				this.columnTag = new DataColumn("Tag", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTag);
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
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class45 method_5()
			{
				return (DataSetScheme.Class45)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class45(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class45);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tSchm_ObjListRowChanged != null)
				{
					this.tSchm_ObjListRowChanged(this, new DataSetScheme.EventArgs0((DataSetScheme.Class45)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tSchm_ObjListRowChanging != null)
				{
					this.tSchm_ObjListRowChanging(this, new DataSetScheme.EventArgs0((DataSetScheme.Class45)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tSchm_ObjListRowDeleted != null)
				{
					this.tSchm_ObjListRowDeleted(this, new DataSetScheme.EventArgs0((DataSetScheme.Class45)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tSchm_ObjListRowDeleting != null)
				{
					this.tSchm_ObjListRowDeleting(this, new DataSetScheme.EventArgs0((DataSetScheme.Class45)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_6(DataSetScheme.Class45 class45_0)
			{
				base.Rows.Remove(class45_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSchm_ObjListDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnName;

			private DataColumn columnTypeCodeId;

			private DataColumn columnOnOff;

			private DataColumn columnidParent;

			private DataColumn columnidGroup;

			private DataColumn columnidParentAddl;

			private DataColumn columnTag;
		}

		public class Class45 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class45(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tSchm_ObjListDataTable_0 = (DataSetScheme.tSchm_ObjListDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Id
			{
				get
				{
					return (int)base[this.tSchm_ObjListDataTable_0.IdColumn];
				}
				set
				{
					base[this.tSchm_ObjListDataTable_0.IdColumn] = value;
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
						result = (string)base[this.tSchm_ObjListDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'tSchm_ObjList' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tSchm_ObjListDataTable_0.NameColumn] = value;
				}
			}

			public int method_0()
			{
				int result;
				try
				{
					result = (int)base[this.tSchm_ObjListDataTable_0.TypeCodeIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TypeCodeId' in table 'tSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(int int_0)
			{
				base[this.tSchm_ObjListDataTable_0.TypeCodeIdColumn] = int_0;
			}

			public bool method_2()
			{
				bool result;
				try
				{
					result = (bool)base[this.tSchm_ObjListDataTable_0.OnOffColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'OnOff' in table 'tSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(bool bool_0)
			{
				base[this.tSchm_ObjListDataTable_0.OnOffColumn] = bool_0;
			}

			public int method_4()
			{
				int result;
				try
				{
					result = (int)base[this.tSchm_ObjListDataTable_0.idParentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idParent' in table 'tSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(int int_0)
			{
				base[this.tSchm_ObjListDataTable_0.idParentColumn] = int_0;
			}

			public int method_6()
			{
				int result;
				try
				{
					result = (int)base[this.tSchm_ObjListDataTable_0.idGroupColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idGroup' in table 'tSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(int int_0)
			{
				base[this.tSchm_ObjListDataTable_0.idGroupColumn] = int_0;
			}

			public int method_8()
			{
				int result;
				try
				{
					result = (int)base[this.tSchm_ObjListDataTable_0.idParentAddlColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idParentAddl' in table 'tSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(int int_0)
			{
				base[this.tSchm_ObjListDataTable_0.idParentAddlColumn] = int_0;
			}

			public int method_10()
			{
				int result;
				try
				{
					result = (int)base[this.tSchm_ObjListDataTable_0.TagColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Tag' in table 'tSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(int int_0)
			{
				base[this.tSchm_ObjListDataTable_0.TagColumn] = int_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_12()
			{
				return base.IsNull(this.tSchm_ObjListDataTable_0.NameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_13()
			{
				base[this.tSchm_ObjListDataTable_0.NameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_14()
			{
				return base.IsNull(this.tSchm_ObjListDataTable_0.TypeCodeIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_15()
			{
				base[this.tSchm_ObjListDataTable_0.TypeCodeIdColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_16()
			{
				return base.IsNull(this.tSchm_ObjListDataTable_0.OnOffColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_17()
			{
				base[this.tSchm_ObjListDataTable_0.OnOffColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_18()
			{
				return base.IsNull(this.tSchm_ObjListDataTable_0.idParentColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.tSchm_ObjListDataTable_0.idParentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.tSchm_ObjListDataTable_0.idGroupColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.tSchm_ObjListDataTable_0.idGroupColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_22()
			{
				return base.IsNull(this.tSchm_ObjListDataTable_0.idParentAddlColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_23()
			{
				base[this.tSchm_ObjListDataTable_0.idParentAddlColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_24()
			{
				return base.IsNull(this.tSchm_ObjListDataTable_0.TagColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_25()
			{
				base[this.tSchm_ObjListDataTable_0.TagColumn] = Convert.DBNull;
			}

			private DataSetScheme.tSchm_ObjListDataTable tSchm_ObjListDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSchm_SchemesDataTable : TypedTableBase<DataSetScheme.Class46>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tSchm_SchemesDataTable()
			{
				base.TableName = "tSchm_Schemes";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tSchm_SchemesDataTable(DataTable dataTable_0)
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
			protected tSchm_SchemesDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IdColumn
			{
				get
				{
					return this.columnId;
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
			public DataColumn SchmDataXmlColumn
			{
				get
				{
					return this.columnSchmDataXml;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn SchmDataBinaryColumn
			{
				get
				{
					return this.columnSchmDataBinary;
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
			public DataSetScheme.Class46 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class46)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate3 tSchm_SchemesRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate3 tSchm_SchemesRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate3 tSchm_SchemesRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate3 tSchm_SchemesRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class46 class46_0)
			{
				base.Rows.Add(class46_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class46 method_1(string string_0, string string_1, byte[] byte_0)
			{
				DataSetScheme.Class46 @class = (DataSetScheme.Class46)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					string_0,
					string_1,
					byte_0
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class46 method_2(int int_0)
			{
				return (DataSetScheme.Class46)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.tSchm_SchemesDataTable tSchm_SchemesDataTable = (DataSetScheme.tSchm_SchemesDataTable)base.Clone();
				tSchm_SchemesDataTable.method_3();
				return tSchm_SchemesDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tSchm_SchemesDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnId = base.Columns["Id"];
				this.columnName = base.Columns["Name"];
				this.columnSchmDataXml = base.Columns["SchmDataXml"];
				this.columnSchmDataBinary = base.Columns["SchmDataBinary"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
			{
				this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnId);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnSchmDataXml = new DataColumn("SchmDataXml", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSchmDataXml);
				this.columnSchmDataBinary = new DataColumn("SchmDataBinary", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnSchmDataBinary);
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
				this.columnSchmDataXml.MaxLength = int.MaxValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class46 method_5()
			{
				return (DataSetScheme.Class46)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class46(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class46);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tSchm_SchemesRowChanged != null)
				{
					this.tSchm_SchemesRowChanged(this, new DataSetScheme.EventArgs1((DataSetScheme.Class46)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tSchm_SchemesRowChanging != null)
				{
					this.tSchm_SchemesRowChanging(this, new DataSetScheme.EventArgs1((DataSetScheme.Class46)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tSchm_SchemesRowDeleted != null)
				{
					this.tSchm_SchemesRowDeleted(this, new DataSetScheme.EventArgs1((DataSetScheme.Class46)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tSchm_SchemesRowDeleting != null)
				{
					this.tSchm_SchemesRowDeleting(this, new DataSetScheme.EventArgs1((DataSetScheme.Class46)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_6(DataSetScheme.Class46 class46_0)
			{
				base.Rows.Remove(class46_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSchm_SchemesDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnName;

			private DataColumn columnSchmDataXml;

			private DataColumn columnSchmDataBinary;
		}

		public class Class46 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class46(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tSchm_SchemesDataTable_0 = (DataSetScheme.tSchm_SchemesDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Id
			{
				get
				{
					return (int)base[this.tSchm_SchemesDataTable_0.IdColumn];
				}
				set
				{
					base[this.tSchm_SchemesDataTable_0.IdColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					return (string)base[this.tSchm_SchemesDataTable_0.NameColumn];
				}
				set
				{
					base[this.tSchm_SchemesDataTable_0.NameColumn] = value;
				}
			}

			public string method_0()
			{
				string result;
				try
				{
					result = (string)base[this.tSchm_SchemesDataTable_0.SchmDataXmlColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SchmDataXml' in table 'tSchm_Schemes' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(string value)
			{
				base[this.tSchm_SchemesDataTable_0.SchmDataXmlColumn] = value;
			}

			public byte[] method_2()
			{
				byte[] result;
				try
				{
					result = (byte[])base[this.tSchm_SchemesDataTable_0.SchmDataBinaryColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SchmDataBinary' in table 'tSchm_Schemes' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(byte[] byte_0)
			{
				base[this.tSchm_SchemesDataTable_0.SchmDataBinaryColumn] = byte_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_4()
			{
				return base.IsNull(this.tSchm_SchemesDataTable_0.SchmDataXmlColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5()
			{
				base[this.tSchm_SchemesDataTable_0.SchmDataXmlColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.tSchm_SchemesDataTable_0.SchmDataBinaryColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7()
			{
				base[this.tSchm_SchemesDataTable_0.SchmDataBinaryColumn] = Convert.DBNull;
			}

			private DataSetScheme.tSchm_SchemesDataTable tSchm_SchemesDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSchm_SettingsDataTable : TypedTableBase<DataSetScheme.Class47>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tSchm_SettingsDataTable()
			{
				base.TableName = "tSchm_Settings";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tSchm_SettingsDataTable(DataTable dataTable_0)
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
			protected tSchm_SettingsDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn HostIPColumn
			{
				get
				{
					return this.columnHostIP;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn SettingsColumn
			{
				get
				{
					return this.columnSettings;
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
			public DataSetScheme.Class47 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class47)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate4 tSchm_SettingsRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate4 tSchm_SettingsRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate4 tSchm_SettingsRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate4 tSchm_SettingsRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(DataSetScheme.Class47 class47_0)
			{
				base.Rows.Add(class47_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class47 method_1(string string_0, string string_1)
			{
				DataSetScheme.Class47 @class = (DataSetScheme.Class47)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					string_0,
					string_1
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class47 method_2(int int_0)
			{
				return (DataSetScheme.Class47)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.tSchm_SettingsDataTable tSchm_SettingsDataTable = (DataSetScheme.tSchm_SettingsDataTable)base.Clone();
				tSchm_SettingsDataTable.method_3();
				return tSchm_SettingsDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tSchm_SettingsDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnHostIP = base.Columns["HostIP"];
				this.columnSettings = base.Columns["Settings"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnHostIP = new DataColumn("HostIP", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnHostIP);
				this.columnSettings = new DataColumn("Settings", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSettings);
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
				this.columnHostIP.AllowDBNull = false;
				this.columnHostIP.MaxLength = 15;
				this.columnSettings.MaxLength = int.MaxValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class47 method_5()
			{
				return (DataSetScheme.Class47)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class47(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class47);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tSchm_SettingsRowChanged != null)
				{
					this.tSchm_SettingsRowChanged(this, new DataSetScheme.EventArgs2((DataSetScheme.Class47)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tSchm_SettingsRowChanging != null)
				{
					this.tSchm_SettingsRowChanging(this, new DataSetScheme.EventArgs2((DataSetScheme.Class47)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tSchm_SettingsRowDeleted != null)
				{
					this.tSchm_SettingsRowDeleted(this, new DataSetScheme.EventArgs2((DataSetScheme.Class47)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tSchm_SettingsRowDeleting != null)
				{
					this.tSchm_SettingsRowDeleting(this, new DataSetScheme.EventArgs2((DataSetScheme.Class47)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_6(DataSetScheme.Class47 class47_0)
			{
				base.Rows.Remove(class47_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSchm_SettingsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnHostIP;

			private DataColumn columnSettings;
		}

		public class Class47 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class47(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tSchm_SettingsDataTable_0 = (DataSetScheme.tSchm_SettingsDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tSchm_SettingsDataTable_0.idColumn];
				}
				set
				{
					base[this.tSchm_SettingsDataTable_0.idColumn] = value;
				}
			}

			public string method_0()
			{
				return (string)base[this.tSchm_SettingsDataTable_0.HostIPColumn];
			}

			public void method_1(string value)
			{
				base[this.tSchm_SettingsDataTable_0.HostIPColumn] = value;
			}

			public string method_2()
			{
				string result;
				try
				{
					result = (string)base[this.tSchm_SettingsDataTable_0.SettingsColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Settings' in table 'tSchm_Settings' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(string value)
			{
				base[this.tSchm_SettingsDataTable_0.SettingsColumn] = value;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_4()
			{
				return base.IsNull(this.tSchm_SettingsDataTable_0.SettingsColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5()
			{
				base[this.tSchm_SettingsDataTable_0.SettingsColumn] = Convert.DBNull;
			}

			private DataSetScheme.tSchm_SettingsDataTable tSchm_SettingsDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSchm_RelationDataTable : TypedTableBase<DataSetScheme.Class48>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tSchm_RelationDataTable()
			{
				base.TableName = "tSchm_Relation";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tSchm_RelationDataTable(DataTable dataTable_0)
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
			protected tSchm_RelationDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn SourceObjColumn
			{
				get
				{
					return this.columnSourceObj;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DestObjColumn
			{
				get
				{
					return this.columnDestObj;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn EdgeColumn
			{
				get
				{
					return this.columnEdge;
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
			public DataSetScheme.Class48 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class48)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate5 tSchm_RelationRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate5 tSchm_RelationRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate5 tSchm_RelationRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate5 tSchm_RelationRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class48 class48_0)
			{
				base.Rows.Add(class48_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class48 method_1(int int_0, int int_1, int int_2)
			{
				DataSetScheme.Class48 @class = (DataSetScheme.Class48)base.NewRow();
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
			public DataSetScheme.Class48 method_2(int int_0)
			{
				return (DataSetScheme.Class48)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.tSchm_RelationDataTable tSchm_RelationDataTable = (DataSetScheme.tSchm_RelationDataTable)base.Clone();
				tSchm_RelationDataTable.method_3();
				return tSchm_RelationDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tSchm_RelationDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnSourceObj = base.Columns["SourceObj"];
				this.columnDestObj = base.Columns["DestObj"];
				this.columnEdge = base.Columns["Edge"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_4()
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class48 method_5()
			{
				return (DataSetScheme.Class48)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class48(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class48);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tSchm_RelationRowChanged != null)
				{
					this.tSchm_RelationRowChanged(this, new DataSetScheme.EventArgs3((DataSetScheme.Class48)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tSchm_RelationRowChanging != null)
				{
					this.tSchm_RelationRowChanging(this, new DataSetScheme.EventArgs3((DataSetScheme.Class48)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tSchm_RelationRowDeleted != null)
				{
					this.tSchm_RelationRowDeleted(this, new DataSetScheme.EventArgs3((DataSetScheme.Class48)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tSchm_RelationRowDeleting != null)
				{
					this.tSchm_RelationRowDeleting(this, new DataSetScheme.EventArgs3((DataSetScheme.Class48)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_6(DataSetScheme.Class48 class48_0)
			{
				base.Rows.Remove(class48_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSchm_RelationDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnSourceObj;

			private DataColumn columnDestObj;

			private DataColumn columnEdge;
		}

		public class Class48 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class48(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tSchm_RelationDataTable_0 = (DataSetScheme.tSchm_RelationDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tSchm_RelationDataTable_0.idColumn];
				}
				set
				{
					base[this.tSchm_RelationDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.tSchm_RelationDataTable_0.SourceObjColumn];
			}

			public void method_1(int int_0)
			{
				base[this.tSchm_RelationDataTable_0.SourceObjColumn] = int_0;
			}

			public int method_2()
			{
				return (int)base[this.tSchm_RelationDataTable_0.DestObjColumn];
			}

			public void method_3(int int_0)
			{
				base[this.tSchm_RelationDataTable_0.DestObjColumn] = int_0;
			}

			public int method_4()
			{
				int result;
				try
				{
					result = (int)base[this.tSchm_RelationDataTable_0.EdgeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Edge' in table 'tSchm_Relation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(int int_0)
			{
				base[this.tSchm_RelationDataTable_0.EdgeColumn] = int_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_6()
			{
				return base.IsNull(this.tSchm_RelationDataTable_0.EdgeColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7()
			{
				base[this.tSchm_RelationDataTable_0.EdgeColumn] = Convert.DBNull;
			}

			private DataSetScheme.tSchm_RelationDataTable tSchm_RelationDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSchm_XmlDataTable : TypedTableBase<DataSetScheme.Class49>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tSchm_XmlDataTable()
			{
				base.TableName = "tSchm_Xml";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tSchm_XmlDataTable(DataTable dataTable_0)
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
			protected tSchm_XmlDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ObjIdColumn
			{
				get
				{
					return this.columnObjId;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TypeSchemaColumn
			{
				get
				{
					return this.columnTypeSchema;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn SchemaXmlColumn
			{
				get
				{
					return this.columnSchemaXml;
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
			public DataSetScheme.Class49 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class49)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate6 tSchm_XmlRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate6 tSchm_XmlRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate6 tSchm_XmlRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate6 tSchm_XmlRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class49 class49_0)
			{
				base.Rows.Add(class49_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class49 method_1(int int_0, int int_1, string string_0)
			{
				DataSetScheme.Class49 @class = (DataSetScheme.Class49)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					int_0,
					int_1,
					string_0
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class49 method_2(int int_0)
			{
				return (DataSetScheme.Class49)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.tSchm_XmlDataTable tSchm_XmlDataTable = (DataSetScheme.tSchm_XmlDataTable)base.Clone();
				tSchm_XmlDataTable.method_3();
				return tSchm_XmlDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tSchm_XmlDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnId = base.Columns["Id"];
				this.columnObjId = base.Columns["ObjId"];
				this.columnTypeSchema = base.Columns["TypeSchema"];
				this.columnSchemaXml = base.Columns["SchemaXml"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
			{
				this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnId);
				this.columnObjId = new DataColumn("ObjId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnObjId);
				this.columnTypeSchema = new DataColumn("TypeSchema", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTypeSchema);
				this.columnSchemaXml = new DataColumn("SchemaXml", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSchemaXml);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnId
				}, true));
				this.columnId.AutoIncrement = true;
				this.columnId.AutoIncrementSeed = -1L;
				this.columnId.AutoIncrementStep = -1L;
				this.columnId.AllowDBNull = false;
				this.columnId.Unique = true;
				this.columnObjId.AllowDBNull = false;
				this.columnTypeSchema.AllowDBNull = false;
				this.columnSchemaXml.MaxLength = int.MaxValue;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class49 method_5()
			{
				return (DataSetScheme.Class49)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class49(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class49);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tSchm_XmlRowChanged != null)
				{
					this.tSchm_XmlRowChanged(this, new DataSetScheme.EventArgs4((DataSetScheme.Class49)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tSchm_XmlRowChanging != null)
				{
					this.tSchm_XmlRowChanging(this, new DataSetScheme.EventArgs4((DataSetScheme.Class49)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tSchm_XmlRowDeleted != null)
				{
					this.tSchm_XmlRowDeleted(this, new DataSetScheme.EventArgs4((DataSetScheme.Class49)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tSchm_XmlRowDeleting != null)
				{
					this.tSchm_XmlRowDeleting(this, new DataSetScheme.EventArgs4((DataSetScheme.Class49)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_6(DataSetScheme.Class49 class49_0)
			{
				base.Rows.Remove(class49_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSchm_XmlDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnObjId;

			private DataColumn columnTypeSchema;

			private DataColumn columnSchemaXml;
		}

		public class Class49 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class49(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tSchm_XmlDataTable_0 = (DataSetScheme.tSchm_XmlDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Id
			{
				get
				{
					return (int)base[this.tSchm_XmlDataTable_0.IdColumn];
				}
				set
				{
					base[this.tSchm_XmlDataTable_0.IdColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.tSchm_XmlDataTable_0.ObjIdColumn];
			}

			public void method_1(int int_0)
			{
				base[this.tSchm_XmlDataTable_0.ObjIdColumn] = int_0;
			}

			public int method_2()
			{
				return (int)base[this.tSchm_XmlDataTable_0.TypeSchemaColumn];
			}

			public void method_3(int int_0)
			{
				base[this.tSchm_XmlDataTable_0.TypeSchemaColumn] = int_0;
			}

			public string method_4()
			{
				string result;
				try
				{
					result = (string)base[this.tSchm_XmlDataTable_0.SchemaXmlColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SchemaXml' in table 'tSchm_Xml' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(string value)
			{
				base[this.tSchm_XmlDataTable_0.SchemaXmlColumn] = value;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.tSchm_XmlDataTable_0.SchemaXmlColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7()
			{
				base[this.tSchm_XmlDataTable_0.SchemaXmlColumn] = Convert.DBNull;
			}

			private DataSetScheme.tSchm_XmlDataTable tSchm_XmlDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vSchm_ObjListXmlDataTable : TypedTableBase<DataSetScheme.Class50>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public vSchm_ObjListXmlDataTable()
			{
				base.TableName = "vSchm_ObjListXml";
				this.BeginInit();
				this.method_3();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal vSchm_ObjListXmlDataTable(DataTable dataTable_0)
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
			protected vSchm_ObjListXmlDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
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
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
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
			public DataColumn IdParentColumn
			{
				get
				{
					return this.columnIdParent;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn OnOffColumn
			{
				get
				{
					return this.columnOnOff;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TypeSchemaColumn
			{
				get
				{
					return this.columnTypeSchema;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn SchemaXmlColumn
			{
				get
				{
					return this.columnSchemaXml;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idGroupColumn
			{
				get
				{
					return this.columnidGroup;
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
			public DataSetScheme.Class50 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class50)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate7 vSchm_ObjListXmlRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate7 vSchm_ObjListXmlRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate7 vSchm_ObjListXmlRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate7 vSchm_ObjListXmlRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class50 class50_0)
			{
				base.Rows.Add(class50_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class50 method_1(int int_0, string string_0, int int_1, int int_2, bool bool_0, int int_3, string string_1, int int_4)
			{
				DataSetScheme.Class50 @class = (DataSetScheme.Class50)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
					string_0,
					int_1,
					int_2,
					bool_0,
					int_3,
					string_1,
					int_4
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.vSchm_ObjListXmlDataTable vSchm_ObjListXmlDataTable = (DataSetScheme.vSchm_ObjListXmlDataTable)base.Clone();
				vSchm_ObjListXmlDataTable.method_2();
				return vSchm_ObjListXmlDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.vSchm_ObjListXmlDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_2()
			{
				this.columnId = base.Columns["Id"];
				this.columnName = base.Columns["Name"];
				this.columnTypeCodeId = base.Columns["TypeCodeId"];
				this.columnIdParent = base.Columns["IdParent"];
				this.columnOnOff = base.Columns["OnOff"];
				this.columnTypeSchema = base.Columns["TypeSchema"];
				this.columnSchemaXml = base.Columns["SchemaXml"];
				this.columnidGroup = base.Columns["idGroup"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_3()
			{
				this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnId);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnTypeCodeId = new DataColumn("TypeCodeId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTypeCodeId);
				this.columnIdParent = new DataColumn("IdParent", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnIdParent);
				this.columnOnOff = new DataColumn("OnOff", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnOnOff);
				this.columnTypeSchema = new DataColumn("TypeSchema", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTypeSchema);
				this.columnSchemaXml = new DataColumn("SchemaXml", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSchemaXml);
				this.columnidGroup = new DataColumn("idGroup", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidGroup);
				this.columnId.AllowDBNull = false;
				this.columnName.MaxLength = int.MaxValue;
				this.columnSchemaXml.MaxLength = int.MaxValue;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class50 method_4()
			{
				return (DataSetScheme.Class50)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class50(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class50);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vSchm_ObjListXmlRowChanged != null)
				{
					this.vSchm_ObjListXmlRowChanged(this, new DataSetScheme.EventArgs5((DataSetScheme.Class50)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vSchm_ObjListXmlRowChanging != null)
				{
					this.vSchm_ObjListXmlRowChanging(this, new DataSetScheme.EventArgs5((DataSetScheme.Class50)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vSchm_ObjListXmlRowDeleted != null)
				{
					this.vSchm_ObjListXmlRowDeleted(this, new DataSetScheme.EventArgs5((DataSetScheme.Class50)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vSchm_ObjListXmlRowDeleting != null)
				{
					this.vSchm_ObjListXmlRowDeleting(this, new DataSetScheme.EventArgs5((DataSetScheme.Class50)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5(DataSetScheme.Class50 class50_0)
			{
				base.Rows.Remove(class50_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vSchm_ObjListXmlDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnName;

			private DataColumn columnTypeCodeId;

			private DataColumn columnIdParent;

			private DataColumn columnOnOff;

			private DataColumn columnTypeSchema;

			private DataColumn columnSchemaXml;

			private DataColumn columnidGroup;
		}

		public class Class50 : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Class50(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vSchm_ObjListXmlDataTable_0 = (DataSetScheme.vSchm_ObjListXmlDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Id
			{
				get
				{
					return (int)base[this.vSchm_ObjListXmlDataTable_0.IdColumn];
				}
				set
				{
					base[this.vSchm_ObjListXmlDataTable_0.IdColumn] = value;
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
						result = (string)base[this.vSchm_ObjListXmlDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'vSchm_ObjListXml' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vSchm_ObjListXmlDataTable_0.NameColumn] = value;
				}
			}

			public int method_0()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_ObjListXmlDataTable_0.TypeCodeIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TypeCodeId' in table 'vSchm_ObjListXml' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(int int_0)
			{
				base[this.vSchm_ObjListXmlDataTable_0.TypeCodeIdColumn] = int_0;
			}

			public int method_2()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_ObjListXmlDataTable_0.IdParentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'IdParent' in table 'vSchm_ObjListXml' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(int int_0)
			{
				base[this.vSchm_ObjListXmlDataTable_0.IdParentColumn] = int_0;
			}

			public bool method_4()
			{
				bool result;
				try
				{
					result = (bool)base[this.vSchm_ObjListXmlDataTable_0.OnOffColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'OnOff' in table 'vSchm_ObjListXml' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(bool bool_0)
			{
				base[this.vSchm_ObjListXmlDataTable_0.OnOffColumn] = bool_0;
			}

			public int method_6()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_ObjListXmlDataTable_0.TypeSchemaColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TypeSchema' in table 'vSchm_ObjListXml' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(int int_0)
			{
				base[this.vSchm_ObjListXmlDataTable_0.TypeSchemaColumn] = int_0;
			}

			public string method_8()
			{
				string result;
				try
				{
					result = (string)base[this.vSchm_ObjListXmlDataTable_0.SchemaXmlColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SchemaXml' in table 'vSchm_ObjListXml' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(string value)
			{
				base[this.vSchm_ObjListXmlDataTable_0.SchemaXmlColumn] = value;
			}

			public int method_10()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_ObjListXmlDataTable_0.idGroupColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idGroup' in table 'vSchm_ObjListXml' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(int int_0)
			{
				base[this.vSchm_ObjListXmlDataTable_0.idGroupColumn] = int_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_12()
			{
				return base.IsNull(this.vSchm_ObjListXmlDataTable_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_13()
			{
				base[this.vSchm_ObjListXmlDataTable_0.NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_14()
			{
				return base.IsNull(this.vSchm_ObjListXmlDataTable_0.TypeCodeIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_15()
			{
				base[this.vSchm_ObjListXmlDataTable_0.TypeCodeIdColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_16()
			{
				return base.IsNull(this.vSchm_ObjListXmlDataTable_0.IdParentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_17()
			{
				base[this.vSchm_ObjListXmlDataTable_0.IdParentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_18()
			{
				return base.IsNull(this.vSchm_ObjListXmlDataTable_0.OnOffColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.vSchm_ObjListXmlDataTable_0.OnOffColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.vSchm_ObjListXmlDataTable_0.TypeSchemaColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_21()
			{
				base[this.vSchm_ObjListXmlDataTable_0.TypeSchemaColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_22()
			{
				return base.IsNull(this.vSchm_ObjListXmlDataTable_0.SchemaXmlColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_23()
			{
				base[this.vSchm_ObjListXmlDataTable_0.SchemaXmlColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_24()
			{
				return base.IsNull(this.vSchm_ObjListXmlDataTable_0.idGroupColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.vSchm_ObjListXmlDataTable_0.idGroupColumn] = Convert.DBNull;
			}

			private DataSetScheme.vSchm_ObjListXmlDataTable vSchm_ObjListXmlDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tOPC_MessageConfigDataTable : TypedTableBase<DataSetScheme.Class51>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tOPC_MessageConfigDataTable()
			{
				base.TableName = "tOPC_MessageConfig";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tOPC_MessageConfigDataTable(DataTable dataTable_0)
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
			protected tOPC_MessageConfigDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn KeySourceColumn
			{
				get
				{
					return this.columnKeySource;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn KeyMessageColumn
			{
				get
				{
					return this.columnKeyMessage;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IconColumn
			{
				get
				{
					return this.columnIcon;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn AudioColumn
			{
				get
				{
					return this.columnAudio;
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
			public DataSetScheme.Class51 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class51)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate8 tOPC_MessageConfigRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate8 tOPC_MessageConfigRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate8 tOPC_MessageConfigRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate8 tOPC_MessageConfigRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(DataSetScheme.Class51 class51_0)
			{
				base.Rows.Add(class51_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class51 method_1(string string_0, string string_1, byte[] byte_0, byte[] byte_1)
			{
				DataSetScheme.Class51 @class = (DataSetScheme.Class51)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					string_0,
					string_1,
					byte_0,
					byte_1
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class51 method_2(int int_0)
			{
				return (DataSetScheme.Class51)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.tOPC_MessageConfigDataTable tOPC_MessageConfigDataTable = (DataSetScheme.tOPC_MessageConfigDataTable)base.Clone();
				tOPC_MessageConfigDataTable.method_3();
				return tOPC_MessageConfigDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tOPC_MessageConfigDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnKeySource = base.Columns["KeySource"];
				this.columnKeyMessage = base.Columns["KeyMessage"];
				this.columnIcon = base.Columns["Icon"];
				this.columnAudio = base.Columns["Audio"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnKeySource = new DataColumn("KeySource", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKeySource);
				this.columnKeyMessage = new DataColumn("KeyMessage", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKeyMessage);
				this.columnIcon = new DataColumn("Icon", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnIcon);
				this.columnAudio = new DataColumn("Audio", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnAudio);
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
				this.columnKeySource.AllowDBNull = false;
				this.columnKeySource.MaxLength = 100;
				this.columnKeyMessage.AllowDBNull = false;
				this.columnKeyMessage.MaxLength = 100;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class51 method_5()
			{
				return (DataSetScheme.Class51)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class51(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class51);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tOPC_MessageConfigRowChanged != null)
				{
					this.tOPC_MessageConfigRowChanged(this, new DataSetScheme.EventArgs6((DataSetScheme.Class51)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tOPC_MessageConfigRowChanging != null)
				{
					this.tOPC_MessageConfigRowChanging(this, new DataSetScheme.EventArgs6((DataSetScheme.Class51)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tOPC_MessageConfigRowDeleted != null)
				{
					this.tOPC_MessageConfigRowDeleted(this, new DataSetScheme.EventArgs6((DataSetScheme.Class51)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tOPC_MessageConfigRowDeleting != null)
				{
					this.tOPC_MessageConfigRowDeleting(this, new DataSetScheme.EventArgs6((DataSetScheme.Class51)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_6(DataSetScheme.Class51 class51_0)
			{
				base.Rows.Remove(class51_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tOPC_MessageConfigDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnKeySource;

			private DataColumn columnKeyMessage;

			private DataColumn columnIcon;

			private DataColumn columnAudio;
		}

		public class Class51 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class51(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tOPC_MessageConfigDataTable_0 = (DataSetScheme.tOPC_MessageConfigDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tOPC_MessageConfigDataTable_0.idColumn];
				}
				set
				{
					base[this.tOPC_MessageConfigDataTable_0.idColumn] = value;
				}
			}

			public string method_0()
			{
				return (string)base[this.tOPC_MessageConfigDataTable_0.KeySourceColumn];
			}

			public void method_1(string value)
			{
				base[this.tOPC_MessageConfigDataTable_0.KeySourceColumn] = value;
			}

			public string method_2()
			{
				return (string)base[this.tOPC_MessageConfigDataTable_0.KeyMessageColumn];
			}

			public void method_3(string value)
			{
				base[this.tOPC_MessageConfigDataTable_0.KeyMessageColumn] = value;
			}

			public byte[] method_4()
			{
				byte[] result;
				try
				{
					result = (byte[])base[this.tOPC_MessageConfigDataTable_0.IconColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Icon' in table 'tOPC_MessageConfig' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(byte[] byte_0)
			{
				base[this.tOPC_MessageConfigDataTable_0.IconColumn] = byte_0;
			}

			public byte[] method_6()
			{
				byte[] result;
				try
				{
					result = (byte[])base[this.tOPC_MessageConfigDataTable_0.AudioColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Audio' in table 'tOPC_MessageConfig' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(byte[] byte_0)
			{
				base[this.tOPC_MessageConfigDataTable_0.AudioColumn] = byte_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_8()
			{
				return base.IsNull(this.tOPC_MessageConfigDataTable_0.IconColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_9()
			{
				base[this.tOPC_MessageConfigDataTable_0.IconColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_10()
			{
				return base.IsNull(this.tOPC_MessageConfigDataTable_0.AudioColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_11()
			{
				base[this.tOPC_MessageConfigDataTable_0.AudioColumn] = Convert.DBNull;
			}

			private DataSetScheme.tOPC_MessageConfigDataTable tOPC_MessageConfigDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tR_ClassifierDataTable : TypedTableBase<DataSetScheme.Class52>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tR_ClassifierDataTable()
			{
				base.TableName = "tR_Classifier";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tR_ClassifierDataTable(DataTable dataTable_0)
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
			protected tR_ClassifierDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SocrNameColumn
			{
				get
				{
					return this.columnSocrName;
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CommentColumn
			{
				get
				{
					return this.columnComment;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ParentIdColumn
			{
				get
				{
					return this.columnParentId;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ParentKeyColumn
			{
				get
				{
					return this.columnParentKey;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn OtherIdColumn
			{
				get
				{
					return this.columnOtherId;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IsGroupColumn
			{
				get
				{
					return this.columnIsGroup;
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
			public DataSetScheme.Class52 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class52)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate9 tR_ClassifierRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate9 tR_ClassifierRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate9 tR_ClassifierRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate9 tR_ClassifierRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class52 class52_0)
			{
				base.Rows.Add(class52_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class52 method_1(string string_0, string string_1, decimal decimal_0, string string_2, int int_0, string string_3, byte[] byte_0, bool bool_0, bool bool_1)
			{
				DataSetScheme.Class52 @class = (DataSetScheme.Class52)base.NewRow();
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
			public DataSetScheme.Class52 method_2(int int_0)
			{
				return (DataSetScheme.Class52)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.tR_ClassifierDataTable tR_ClassifierDataTable = (DataSetScheme.tR_ClassifierDataTable)base.Clone();
				tR_ClassifierDataTable.method_3();
				return tR_ClassifierDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tR_ClassifierDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class52 method_5()
			{
				return (DataSetScheme.Class52)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class52(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class52);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tR_ClassifierRowChanged != null)
				{
					this.tR_ClassifierRowChanged(this, new DataSetScheme.EventArgs7((DataSetScheme.Class52)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tR_ClassifierRowChanging != null)
				{
					this.tR_ClassifierRowChanging(this, new DataSetScheme.EventArgs7((DataSetScheme.Class52)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tR_ClassifierRowDeleted != null)
				{
					this.tR_ClassifierRowDeleted(this, new DataSetScheme.EventArgs7((DataSetScheme.Class52)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tR_ClassifierRowDeleting != null)
				{
					this.tR_ClassifierRowDeleting(this, new DataSetScheme.EventArgs7((DataSetScheme.Class52)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_6(DataSetScheme.Class52 class52_0)
			{
				base.Rows.Remove(class52_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tR_ClassifierDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnName;

			private DataColumn columnSocrName;

			private DataColumn columnValue;

			private DataColumn columnComment;

			private DataColumn columnParentId;

			private DataColumn columnParentKey;

			private DataColumn columnOtherId;

			private DataColumn columnIsGroup;

			private DataColumn columnDeleted;
		}

		public class Class52 : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Class52(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tR_ClassifierDataTable_0 = (DataSetScheme.tR_ClassifierDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Id
			{
				get
				{
					return (int)base[this.tR_ClassifierDataTable_0.IdColumn];
				}
				set
				{
					base[this.tR_ClassifierDataTable_0.IdColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					return (string)base[this.tR_ClassifierDataTable_0.NameColumn];
				}
				set
				{
					base[this.tR_ClassifierDataTable_0.NameColumn] = value;
				}
			}

			public string method_0()
			{
				string result;
				try
				{
					result = (string)base[this.tR_ClassifierDataTable_0.SocrNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SocrName' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(string value)
			{
				base[this.tR_ClassifierDataTable_0.SocrNameColumn] = value;
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
						result = (decimal)base[this.tR_ClassifierDataTable_0.ValueColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Value' in table 'tR_Classifier' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tR_ClassifierDataTable_0.ValueColumn] = value;
				}
			}

			public string method_2()
			{
				string result;
				try
				{
					result = (string)base[this.tR_ClassifierDataTable_0.CommentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Comment' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(string value)
			{
				base[this.tR_ClassifierDataTable_0.CommentColumn] = value;
			}

			public int method_4()
			{
				int result;
				try
				{
					result = (int)base[this.tR_ClassifierDataTable_0.ParentIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentId' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(int int_0)
			{
				base[this.tR_ClassifierDataTable_0.ParentIdColumn] = int_0;
			}

			public string method_6()
			{
				string result;
				try
				{
					result = (string)base[this.tR_ClassifierDataTable_0.ParentKeyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKey' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(string value)
			{
				base[this.tR_ClassifierDataTable_0.ParentKeyColumn] = value;
			}

			public byte[] method_8()
			{
				byte[] result;
				try
				{
					result = (byte[])base[this.tR_ClassifierDataTable_0.OtherIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'OtherId' in table 'tR_Classifier' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(byte[] byte_0)
			{
				base[this.tR_ClassifierDataTable_0.OtherIdColumn] = byte_0;
			}

			public bool method_10()
			{
				return (bool)base[this.tR_ClassifierDataTable_0.IsGroupColumn];
			}

			public void method_11(bool bool_0)
			{
				base[this.tR_ClassifierDataTable_0.IsGroupColumn] = bool_0;
			}

			public bool method_12()
			{
				return (bool)base[this.tR_ClassifierDataTable_0.DeletedColumn];
			}

			public void method_13(bool bool_0)
			{
				base[this.tR_ClassifierDataTable_0.DeletedColumn] = bool_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_14()
			{
				return base.IsNull(this.tR_ClassifierDataTable_0.SocrNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_15()
			{
				base[this.tR_ClassifierDataTable_0.SocrNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_16()
			{
				return base.IsNull(this.tR_ClassifierDataTable_0.ValueColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_17()
			{
				base[this.tR_ClassifierDataTable_0.ValueColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_18()
			{
				return base.IsNull(this.tR_ClassifierDataTable_0.CommentColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.tR_ClassifierDataTable_0.CommentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.tR_ClassifierDataTable_0.ParentIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.tR_ClassifierDataTable_0.ParentIdColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_22()
			{
				return base.IsNull(this.tR_ClassifierDataTable_0.ParentKeyColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_23()
			{
				base[this.tR_ClassifierDataTable_0.ParentKeyColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.tR_ClassifierDataTable_0.OtherIdColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.tR_ClassifierDataTable_0.OtherIdColumn] = Convert.DBNull;
			}

			private DataSetScheme.tR_ClassifierDataTable tR_ClassifierDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vSchm_ObjListDataTable : TypedTableBase<DataSetScheme.Class53>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public vSchm_ObjListDataTable()
			{
				base.TableName = "vSchm_ObjList";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal vSchm_ObjListDataTable(DataTable dataTable_0)
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
			protected vSchm_ObjListDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn TypeCodeIdColumn
			{
				get
				{
					return this.columnTypeCodeId;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn typecodeColumn
			{
				get
				{
					return this.columntypecode;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn typeCodeSocrColumn
			{
				get
				{
					return this.columntypeCodeSocr;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IdParentColumn
			{
				get
				{
					return this.columnIdParent;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn OnOffColumn
			{
				get
				{
					return this.columnOnOff;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn NamePColumn
			{
				get
				{
					return this.columnNameP;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idGroupColumn
			{
				get
				{
					return this.columnidGroup;
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
			public DataSetScheme.Class53 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class53)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate10 vSchm_ObjListRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate10 vSchm_ObjListRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate10 vSchm_ObjListRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate10 vSchm_ObjListRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class53 class53_0)
			{
				base.Rows.Add(class53_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class53 method_1(int int_0, string string_0, int int_1, string string_1, string string_2, int int_2, bool bool_0, int int_3, int int_4)
			{
				DataSetScheme.Class53 @class = (DataSetScheme.Class53)base.NewRow();
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
					int_4
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class53 method_2(int int_0)
			{
				return (DataSetScheme.Class53)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.vSchm_ObjListDataTable vSchm_ObjListDataTable = (DataSetScheme.vSchm_ObjListDataTable)base.Clone();
				vSchm_ObjListDataTable.method_3();
				return vSchm_ObjListDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.vSchm_ObjListDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnId = base.Columns["Id"];
				this.columnName = base.Columns["Name"];
				this.columnTypeCodeId = base.Columns["TypeCodeId"];
				this.columntypecode = base.Columns["typecode"];
				this.columntypeCodeSocr = base.Columns["typeCodeSocr"];
				this.columnIdParent = base.Columns["IdParent"];
				this.columnOnOff = base.Columns["OnOff"];
				this.columnNameP = base.Columns["NameP"];
				this.columnidGroup = base.Columns["idGroup"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
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
				this.columnidGroup = new DataColumn("idGroup", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidGroup);
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
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class53 method_5()
			{
				return (DataSetScheme.Class53)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class53(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class53);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vSchm_ObjListRowChanged != null)
				{
					this.vSchm_ObjListRowChanged(this, new DataSetScheme.EventArgs8((DataSetScheme.Class53)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vSchm_ObjListRowChanging != null)
				{
					this.vSchm_ObjListRowChanging(this, new DataSetScheme.EventArgs8((DataSetScheme.Class53)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vSchm_ObjListRowDeleted != null)
				{
					this.vSchm_ObjListRowDeleted(this, new DataSetScheme.EventArgs8((DataSetScheme.Class53)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vSchm_ObjListRowDeleting != null)
				{
					this.vSchm_ObjListRowDeleting(this, new DataSetScheme.EventArgs8((DataSetScheme.Class53)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_6(DataSetScheme.Class53 class53_0)
			{
				base.Rows.Remove(class53_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vSchm_ObjListDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnName;

			private DataColumn columnTypeCodeId;

			private DataColumn columntypecode;

			private DataColumn columntypeCodeSocr;

			private DataColumn columnIdParent;

			private DataColumn columnOnOff;

			private DataColumn columnNameP;

			private DataColumn columnidGroup;
		}

		public class Class53 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class53(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vSchm_ObjListDataTable_0 = (DataSetScheme.vSchm_ObjListDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Id
			{
				get
				{
					return (int)base[this.vSchm_ObjListDataTable_0.IdColumn];
				}
				set
				{
					base[this.vSchm_ObjListDataTable_0.IdColumn] = value;
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
						result = (string)base[this.vSchm_ObjListDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'vSchm_ObjList' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vSchm_ObjListDataTable_0.NameColumn] = value;
				}
			}

			public int method_0()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_ObjListDataTable_0.TypeCodeIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TypeCodeId' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(int int_0)
			{
				base[this.vSchm_ObjListDataTable_0.TypeCodeIdColumn] = int_0;
			}

			public string method_2()
			{
				string result;
				try
				{
					result = (string)base[this.vSchm_ObjListDataTable_0.typecodeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typecode' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(string value)
			{
				base[this.vSchm_ObjListDataTable_0.typecodeColumn] = value;
			}

			public string method_4()
			{
				string result;
				try
				{
					result = (string)base[this.vSchm_ObjListDataTable_0.typeCodeSocrColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typeCodeSocr' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(string value)
			{
				base[this.vSchm_ObjListDataTable_0.typeCodeSocrColumn] = value;
			}

			public int method_6()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_ObjListDataTable_0.IdParentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'IdParent' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(int int_0)
			{
				base[this.vSchm_ObjListDataTable_0.IdParentColumn] = int_0;
			}

			public bool method_8()
			{
				bool result;
				try
				{
					result = (bool)base[this.vSchm_ObjListDataTable_0.OnOffColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'OnOff' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(bool bool_0)
			{
				base[this.vSchm_ObjListDataTable_0.OnOffColumn] = bool_0;
			}

			public int method_10()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_ObjListDataTable_0.NamePColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NameP' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(int int_0)
			{
				base[this.vSchm_ObjListDataTable_0.NamePColumn] = int_0;
			}

			public int method_12()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_ObjListDataTable_0.idGroupColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idGroup' in table 'vSchm_ObjList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_13(int int_0)
			{
				base[this.vSchm_ObjListDataTable_0.idGroupColumn] = int_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_14()
			{
				return base.IsNull(this.vSchm_ObjListDataTable_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_15()
			{
				base[this.vSchm_ObjListDataTable_0.NameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_16()
			{
				return base.IsNull(this.vSchm_ObjListDataTable_0.TypeCodeIdColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_17()
			{
				base[this.vSchm_ObjListDataTable_0.TypeCodeIdColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_18()
			{
				return base.IsNull(this.vSchm_ObjListDataTable_0.typecodeColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.vSchm_ObjListDataTable_0.typecodeColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_20()
			{
				return base.IsNull(this.vSchm_ObjListDataTable_0.typeCodeSocrColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.vSchm_ObjListDataTable_0.typeCodeSocrColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_22()
			{
				return base.IsNull(this.vSchm_ObjListDataTable_0.IdParentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_23()
			{
				base[this.vSchm_ObjListDataTable_0.IdParentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.vSchm_ObjListDataTable_0.OnOffColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.vSchm_ObjListDataTable_0.OnOffColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_26()
			{
				return base.IsNull(this.vSchm_ObjListDataTable_0.NamePColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_27()
			{
				base[this.vSchm_ObjListDataTable_0.NamePColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_28()
			{
				return base.IsNull(this.vSchm_ObjListDataTable_0.idGroupColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_29()
			{
				base[this.vSchm_ObjListDataTable_0.idGroupColumn] = Convert.DBNull;
			}

			private DataSetScheme.vSchm_ObjListDataTable vSchm_ObjListDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSchm_ObjFilterDataTable : TypedTableBase<DataSetScheme.Class54>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tSchm_ObjFilterDataTable()
			{
				base.TableName = "tSchm_ObjFilter";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tSchm_ObjFilterDataTable(DataTable dataTable_0)
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
			protected tSchm_ObjFilterDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn idObjColumn
			{
				get
				{
					return this.columnidObj;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idFilterColumn
			{
				get
				{
					return this.columnidFilter;
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
			public DataSetScheme.Class54 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class54)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate11 tSchm_ObjFilterRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate11 tSchm_ObjFilterRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate11 tSchm_ObjFilterRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate11 tSchm_ObjFilterRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class54 class54_0)
			{
				base.Rows.Add(class54_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class54 method_1(int int_0, int int_1)
			{
				DataSetScheme.Class54 @class = (DataSetScheme.Class54)base.NewRow();
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class54 method_2(int int_0)
			{
				return (DataSetScheme.Class54)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.tSchm_ObjFilterDataTable tSchm_ObjFilterDataTable = (DataSetScheme.tSchm_ObjFilterDataTable)base.Clone();
				tSchm_ObjFilterDataTable.method_3();
				return tSchm_ObjFilterDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tSchm_ObjFilterDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnidObj = base.Columns["idObj"];
				this.columnidFilter = base.Columns["idFilter"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidObj = new DataColumn("idObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObj);
				this.columnidFilter = new DataColumn("idFilter", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidFilter);
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
				this.columnidObj.AllowDBNull = false;
				this.columnidFilter.AllowDBNull = false;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class54 method_5()
			{
				return (DataSetScheme.Class54)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class54(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class54);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tSchm_ObjFilterRowChanged != null)
				{
					this.tSchm_ObjFilterRowChanged(this, new DataSetScheme.EventArgs9((DataSetScheme.Class54)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tSchm_ObjFilterRowChanging != null)
				{
					this.tSchm_ObjFilterRowChanging(this, new DataSetScheme.EventArgs9((DataSetScheme.Class54)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tSchm_ObjFilterRowDeleted != null)
				{
					this.tSchm_ObjFilterRowDeleted(this, new DataSetScheme.EventArgs9((DataSetScheme.Class54)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tSchm_ObjFilterRowDeleting != null)
				{
					this.tSchm_ObjFilterRowDeleting(this, new DataSetScheme.EventArgs9((DataSetScheme.Class54)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_6(DataSetScheme.Class54 class54_0)
			{
				base.Rows.Remove(class54_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSchm_ObjFilterDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnidObj;

			private DataColumn columnidFilter;
		}

		public class Class54 : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Class54(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tSchm_ObjFilterDataTable_0 = (DataSetScheme.tSchm_ObjFilterDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tSchm_ObjFilterDataTable_0.idColumn];
				}
				set
				{
					base[this.tSchm_ObjFilterDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.tSchm_ObjFilterDataTable_0.idObjColumn];
			}

			public void method_1(int int_0)
			{
				base[this.tSchm_ObjFilterDataTable_0.idObjColumn] = int_0;
			}

			public int method_2()
			{
				return (int)base[this.tSchm_ObjFilterDataTable_0.idFilterColumn];
			}

			public void method_3(int int_0)
			{
				base[this.tSchm_ObjFilterDataTable_0.idFilterColumn] = int_0;
			}

			private DataSetScheme.tSchm_ObjFilterDataTable tSchm_ObjFilterDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSchm_LabelDataTable : TypedTableBase<DataSetScheme.Class55>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tSchm_LabelDataTable()
			{
				base.TableName = "tSchm_Label";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tSchm_LabelDataTable(DataTable dataTable_0)
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
			protected tSchm_LabelDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TypeLabelColumn
			{
				get
				{
					return this.columnTypeLabel;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idParentColumn
			{
				get
				{
					return this.columnidParent;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn XmlCoordsColumn
			{
				get
				{
					return this.columnXmlCoords;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TagColumn
			{
				get
				{
					return this.columnTag;
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
			public DataSetScheme.Class55 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class55)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate12 tSchm_LabelRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate12 tSchm_LabelRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate12 tSchm_LabelRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate12 tSchm_LabelRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class55 class55_0)
			{
				base.Rows.Add(class55_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class55 method_1(string string_0, int int_0, int int_1, string string_1, int int_2)
			{
				DataSetScheme.Class55 @class = (DataSetScheme.Class55)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					string_0,
					int_0,
					int_1,
					string_1,
					int_2
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class55 method_2(int int_0)
			{
				return (DataSetScheme.Class55)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.tSchm_LabelDataTable tSchm_LabelDataTable = (DataSetScheme.tSchm_LabelDataTable)base.Clone();
				tSchm_LabelDataTable.method_3();
				return tSchm_LabelDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tSchm_LabelDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnName = base.Columns["Name"];
				this.columnTypeLabel = base.Columns["TypeLabel"];
				this.columnidParent = base.Columns["idParent"];
				this.columnXmlCoords = base.Columns["XmlCoords"];
				this.columnTag = base.Columns["Tag"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnTypeLabel = new DataColumn("TypeLabel", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTypeLabel);
				this.columnidParent = new DataColumn("idParent", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidParent);
				this.columnXmlCoords = new DataColumn("XmlCoords", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnXmlCoords);
				this.columnTag = new DataColumn("Tag", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTag);
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
				this.columnName.MaxLength = 128;
				this.columnTypeLabel.AllowDBNull = false;
				this.columnXmlCoords.AllowDBNull = false;
				this.columnXmlCoords.MaxLength = int.MaxValue;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class55 method_5()
			{
				return (DataSetScheme.Class55)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class55(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class55);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tSchm_LabelRowChanged != null)
				{
					this.tSchm_LabelRowChanged(this, new DataSetScheme.EventArgs10((DataSetScheme.Class55)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tSchm_LabelRowChanging != null)
				{
					this.tSchm_LabelRowChanging(this, new DataSetScheme.EventArgs10((DataSetScheme.Class55)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tSchm_LabelRowDeleted != null)
				{
					this.tSchm_LabelRowDeleted(this, new DataSetScheme.EventArgs10((DataSetScheme.Class55)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tSchm_LabelRowDeleting != null)
				{
					this.tSchm_LabelRowDeleting(this, new DataSetScheme.EventArgs10((DataSetScheme.Class55)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_6(DataSetScheme.Class55 class55_0)
			{
				base.Rows.Remove(class55_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSchm_LabelDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnName;

			private DataColumn columnTypeLabel;

			private DataColumn columnidParent;

			private DataColumn columnXmlCoords;

			private DataColumn columnTag;
		}

		public class Class55 : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Class55(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tSchm_LabelDataTable_0 = (DataSetScheme.tSchm_LabelDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tSchm_LabelDataTable_0.idColumn];
				}
				set
				{
					base[this.tSchm_LabelDataTable_0.idColumn] = value;
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
						result = (string)base[this.tSchm_LabelDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'tSchm_Label' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tSchm_LabelDataTable_0.NameColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.tSchm_LabelDataTable_0.TypeLabelColumn];
			}

			public void method_1(int int_0)
			{
				base[this.tSchm_LabelDataTable_0.TypeLabelColumn] = int_0;
			}

			public int method_2()
			{
				int result;
				try
				{
					result = (int)base[this.tSchm_LabelDataTable_0.idParentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idParent' in table 'tSchm_Label' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(int int_0)
			{
				base[this.tSchm_LabelDataTable_0.idParentColumn] = int_0;
			}

			public string method_4()
			{
				return (string)base[this.tSchm_LabelDataTable_0.XmlCoordsColumn];
			}

			public void method_5(string value)
			{
				base[this.tSchm_LabelDataTable_0.XmlCoordsColumn] = value;
			}

			public int method_6()
			{
				int result;
				try
				{
					result = (int)base[this.tSchm_LabelDataTable_0.TagColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Tag' in table 'tSchm_Label' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(int int_0)
			{
				base[this.tSchm_LabelDataTable_0.TagColumn] = int_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_8()
			{
				return base.IsNull(this.tSchm_LabelDataTable_0.NameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_9()
			{
				base[this.tSchm_LabelDataTable_0.NameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_10()
			{
				return base.IsNull(this.tSchm_LabelDataTable_0.idParentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_11()
			{
				base[this.tSchm_LabelDataTable_0.idParentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_12()
			{
				return base.IsNull(this.tSchm_LabelDataTable_0.TagColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_13()
			{
				base[this.tSchm_LabelDataTable_0.TagColumn] = Convert.DBNull;
			}

			private DataSetScheme.tSchm_LabelDataTable tSchm_LabelDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSchm_LockDataTable : TypedTableBase<DataSetScheme.Class56>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tSchm_LockDataTable()
			{
				base.TableName = "tSchm_Lock";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tSchm_LockDataTable(DataTable dataTable_0)
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
			protected tSchm_LockDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn UserNameColumn
			{
				get
				{
					return this.columnUserName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DateColumn
			{
				get
				{
					return this.columnDate;
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
			public DataSetScheme.Class56 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class56)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate13 tSchm_LockRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate13 tSchm_LockRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate13 tSchm_LockRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate13 tSchm_LockRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(DataSetScheme.Class56 class56_0)
			{
				base.Rows.Add(class56_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class56 method_1(string string_0, DateTime dateTime_0)
			{
				DataSetScheme.Class56 @class = (DataSetScheme.Class56)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					string_0,
					dateTime_0
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class56 method_2(int int_0)
			{
				return (DataSetScheme.Class56)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.tSchm_LockDataTable tSchm_LockDataTable = (DataSetScheme.tSchm_LockDataTable)base.Clone();
				tSchm_LockDataTable.method_3();
				return tSchm_LockDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tSchm_LockDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnUserName = base.Columns["UserName"];
				this.columnDate = base.Columns["Date"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnUserName = new DataColumn("UserName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnUserName);
				this.columnDate = new DataColumn("Date", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDate);
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
				this.columnUserName.MaxLength = 128;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class56 method_5()
			{
				return (DataSetScheme.Class56)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class56(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class56);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tSchm_LockRowChanged != null)
				{
					this.tSchm_LockRowChanged(this, new DataSetScheme.EventArgs11((DataSetScheme.Class56)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tSchm_LockRowChanging != null)
				{
					this.tSchm_LockRowChanging(this, new DataSetScheme.EventArgs11((DataSetScheme.Class56)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tSchm_LockRowDeleted != null)
				{
					this.tSchm_LockRowDeleted(this, new DataSetScheme.EventArgs11((DataSetScheme.Class56)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tSchm_LockRowDeleting != null)
				{
					this.tSchm_LockRowDeleting(this, new DataSetScheme.EventArgs11((DataSetScheme.Class56)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_6(DataSetScheme.Class56 class56_0)
			{
				base.Rows.Remove(class56_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSchm_LockDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnUserName;

			private DataColumn columnDate;
		}

		public class Class56 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class56(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tSchm_LockDataTable_0 = (DataSetScheme.tSchm_LockDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tSchm_LockDataTable_0.idColumn];
				}
				set
				{
					base[this.tSchm_LockDataTable_0.idColumn] = value;
				}
			}

			public string method_0()
			{
				string result;
				try
				{
					result = (string)base[this.tSchm_LockDataTable_0.UserNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'UserName' in table 'tSchm_Lock' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(string value)
			{
				base[this.tSchm_LockDataTable_0.UserNameColumn] = value;
			}

			public DateTime method_2()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.tSchm_LockDataTable_0.DateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Date' in table 'tSchm_Lock' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(DateTime dateTime_0)
			{
				base[this.tSchm_LockDataTable_0.DateColumn] = dateTime_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_4()
			{
				return base.IsNull(this.tSchm_LockDataTable_0.UserNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5()
			{
				base[this.tSchm_LockDataTable_0.UserNameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.tSchm_LockDataTable_0.DateColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_7()
			{
				base[this.tSchm_LockDataTable_0.DateColumn] = Convert.DBNull;
			}

			private DataSetScheme.tSchm_LockDataTable tSchm_LockDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSchm_LogDispatcherDataTable : TypedTableBase<DataSetScheme.Class57>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tSchm_LogDispatcherDataTable()
			{
				base.TableName = "tSchm_LogDispatcher";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tSchm_LogDispatcherDataTable(DataTable dataTable_0)
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
			protected tSchm_LogDispatcherDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn idUserColumn
			{
				get
				{
					return this.columnidUser;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn UserNameColumn
			{
				get
				{
					return this.columnUserName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DateLogColumn
			{
				get
				{
					return this.columnDateLog;
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ActionColumn
			{
				get
				{
					return this.columnAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CommentColumn
			{
				get
				{
					return this.columnComment;
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
			public DataSetScheme.Class57 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class57)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate14 tSchm_LogDispatcherRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate14 tSchm_LogDispatcherRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate14 tSchm_LogDispatcherRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate14 tSchm_LogDispatcherRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class57 class57_0)
			{
				base.Rows.Add(class57_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class57 method_1(int int_0, string string_0, DateTime dateTime_0, int int_1, string string_1, string string_2)
			{
				DataSetScheme.Class57 @class = (DataSetScheme.Class57)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					int_0,
					string_0,
					dateTime_0,
					int_1,
					string_1,
					string_2
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class57 method_2(int int_0)
			{
				return (DataSetScheme.Class57)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.tSchm_LogDispatcherDataTable tSchm_LogDispatcherDataTable = (DataSetScheme.tSchm_LogDispatcherDataTable)base.Clone();
				tSchm_LogDispatcherDataTable.method_3();
				return tSchm_LogDispatcherDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tSchm_LogDispatcherDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnidUser = base.Columns["idUser"];
				this.columnUserName = base.Columns["UserName"];
				this.columnDateLog = base.Columns["DateLog"];
				this.columnidObj = base.Columns["idObj"];
				this.columnAction = base.Columns["Action"];
				this.columnComment = base.Columns["Comment"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidUser = new DataColumn("idUser", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidUser);
				this.columnUserName = new DataColumn("UserName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnUserName);
				this.columnDateLog = new DataColumn("DateLog", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateLog);
				this.columnidObj = new DataColumn("idObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObj);
				this.columnAction = new DataColumn("Action", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAction);
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
				this.columnUserName.MaxLength = 100;
				this.columnAction.AllowDBNull = false;
				this.columnAction.MaxLength = 256;
				this.columnComment.MaxLength = 256;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class57 method_5()
			{
				return (DataSetScheme.Class57)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class57(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class57);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tSchm_LogDispatcherRowChanged != null)
				{
					this.tSchm_LogDispatcherRowChanged(this, new DataSetScheme.EventArgs12((DataSetScheme.Class57)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tSchm_LogDispatcherRowChanging != null)
				{
					this.tSchm_LogDispatcherRowChanging(this, new DataSetScheme.EventArgs12((DataSetScheme.Class57)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tSchm_LogDispatcherRowDeleted != null)
				{
					this.tSchm_LogDispatcherRowDeleted(this, new DataSetScheme.EventArgs12((DataSetScheme.Class57)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tSchm_LogDispatcherRowDeleting != null)
				{
					this.tSchm_LogDispatcherRowDeleting(this, new DataSetScheme.EventArgs12((DataSetScheme.Class57)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_6(DataSetScheme.Class57 class57_0)
			{
				base.Rows.Remove(class57_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSchm_LogDispatcherDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnidUser;

			private DataColumn columnUserName;

			private DataColumn columnDateLog;

			private DataColumn columnidObj;

			private DataColumn columnAction;

			private DataColumn columnComment;
		}

		public class Class57 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class57(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tSchm_LogDispatcherDataTable_0 = (DataSetScheme.tSchm_LogDispatcherDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tSchm_LogDispatcherDataTable_0.idColumn];
				}
				set
				{
					base[this.tSchm_LogDispatcherDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				int result;
				try
				{
					result = (int)base[this.tSchm_LogDispatcherDataTable_0.idUserColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idUser' in table 'tSchm_LogDispatcher' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(int int_0)
			{
				base[this.tSchm_LogDispatcherDataTable_0.idUserColumn] = int_0;
			}

			public string method_2()
			{
				string result;
				try
				{
					result = (string)base[this.tSchm_LogDispatcherDataTable_0.UserNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'UserName' in table 'tSchm_LogDispatcher' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(string value)
			{
				base[this.tSchm_LogDispatcherDataTable_0.UserNameColumn] = value;
			}

			public DateTime method_4()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.tSchm_LogDispatcherDataTable_0.DateLogColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateLog' in table 'tSchm_LogDispatcher' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(DateTime dateTime_0)
			{
				base[this.tSchm_LogDispatcherDataTable_0.DateLogColumn] = dateTime_0;
			}

			public int method_6()
			{
				int result;
				try
				{
					result = (int)base[this.tSchm_LogDispatcherDataTable_0.idObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idObj' in table 'tSchm_LogDispatcher' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(int int_0)
			{
				base[this.tSchm_LogDispatcherDataTable_0.idObjColumn] = int_0;
			}

			public string method_8()
			{
				return (string)base[this.tSchm_LogDispatcherDataTable_0.ActionColumn];
			}

			public void method_9(string value)
			{
				base[this.tSchm_LogDispatcherDataTable_0.ActionColumn] = value;
			}

			public string method_10()
			{
				string result;
				try
				{
					result = (string)base[this.tSchm_LogDispatcherDataTable_0.CommentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Comment' in table 'tSchm_LogDispatcher' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(string value)
			{
				base[this.tSchm_LogDispatcherDataTable_0.CommentColumn] = value;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_12()
			{
				return base.IsNull(this.tSchm_LogDispatcherDataTable_0.idUserColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_13()
			{
				base[this.tSchm_LogDispatcherDataTable_0.idUserColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_14()
			{
				return base.IsNull(this.tSchm_LogDispatcherDataTable_0.UserNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_15()
			{
				base[this.tSchm_LogDispatcherDataTable_0.UserNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_16()
			{
				return base.IsNull(this.tSchm_LogDispatcherDataTable_0.DateLogColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_17()
			{
				base[this.tSchm_LogDispatcherDataTable_0.DateLogColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_18()
			{
				return base.IsNull(this.tSchm_LogDispatcherDataTable_0.idObjColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.tSchm_LogDispatcherDataTable_0.idObjColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.tSchm_LogDispatcherDataTable_0.CommentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.tSchm_LogDispatcherDataTable_0.CommentColumn] = Convert.DBNull;
			}

			private DataSetScheme.tSchm_LogDispatcherDataTable tSchm_LogDispatcherDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vSchm_TreeCellLineDataTable : TypedTableBase<DataSetScheme.Class58>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public vSchm_TreeCellLineDataTable()
			{
				base.TableName = "vSchm_TreeCellLine";
				this.BeginInit();
				this.method_3();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal vSchm_TreeCellLineDataTable(DataTable dataTable_0)
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
			protected vSchm_TreeCellLineDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
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
			public DataColumn ParentLinkColumn
			{
				get
				{
					return this.columnParentLink;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
			public DataColumn FullNameColumn
			{
				get
				{
					return this.columnFullName;
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
			public DataSetScheme.Class58 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class58)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate15 vSchm_TreeCellLineRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate15 vSchm_TreeCellLineRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate15 vSchm_TreeCellLineRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate15 vSchm_TreeCellLineRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class58 class58_0)
			{
				base.Rows.Add(class58_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class58 method_1(int int_0, int int_1, int int_2, string string_0, string string_1, string string_2)
			{
				DataSetScheme.Class58 @class = (DataSetScheme.Class58)base.NewRow();
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
				DataSetScheme.vSchm_TreeCellLineDataTable vSchm_TreeCellLineDataTable = (DataSetScheme.vSchm_TreeCellLineDataTable)base.Clone();
				vSchm_TreeCellLineDataTable.method_2();
				return vSchm_TreeCellLineDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.vSchm_TreeCellLineDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_2()
			{
				this.columnId = base.Columns["Id"];
				this.columnParentLink = base.Columns["ParentLink"];
				this.columnTypeCodeId = base.Columns["TypeCodeId"];
				this.columnParentKey = base.Columns["ParentKey"];
				this.columnName = base.Columns["Name"];
				this.columnFullName = base.Columns["FullName"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_3()
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class58 method_4()
			{
				return (DataSetScheme.Class58)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class58(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class58);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vSchm_TreeCellLineRowChanged != null)
				{
					this.vSchm_TreeCellLineRowChanged(this, new DataSetScheme.EventArgs13((DataSetScheme.Class58)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vSchm_TreeCellLineRowChanging != null)
				{
					this.vSchm_TreeCellLineRowChanging(this, new DataSetScheme.EventArgs13((DataSetScheme.Class58)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vSchm_TreeCellLineRowDeleted != null)
				{
					this.vSchm_TreeCellLineRowDeleted(this, new DataSetScheme.EventArgs13((DataSetScheme.Class58)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vSchm_TreeCellLineRowDeleting != null)
				{
					this.vSchm_TreeCellLineRowDeleting(this, new DataSetScheme.EventArgs13((DataSetScheme.Class58)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5(DataSetScheme.Class58 class58_0)
			{
				base.Rows.Remove(class58_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vSchm_TreeCellLineDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnParentLink;

			private DataColumn columnTypeCodeId;

			private DataColumn columnParentKey;

			private DataColumn columnName;

			private DataColumn columnFullName;
		}

		public class Class58 : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Class58(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vSchm_TreeCellLineDataTable_0 = (DataSetScheme.vSchm_TreeCellLineDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Id
			{
				get
				{
					return (int)base[this.vSchm_TreeCellLineDataTable_0.IdColumn];
				}
				set
				{
					base[this.vSchm_TreeCellLineDataTable_0.IdColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.vSchm_TreeCellLineDataTable_0.ParentLinkColumn];
			}

			public void method_1(int int_0)
			{
				base[this.vSchm_TreeCellLineDataTable_0.ParentLinkColumn] = int_0;
			}

			public int method_2()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_TreeCellLineDataTable_0.TypeCodeIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TypeCodeId' in table 'vSchm_TreeCellLine' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(int int_0)
			{
				base[this.vSchm_TreeCellLineDataTable_0.TypeCodeIdColumn] = int_0;
			}

			public string method_4()
			{
				string result;
				try
				{
					result = (string)base[this.vSchm_TreeCellLineDataTable_0.ParentKeyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKey' in table 'vSchm_TreeCellLine' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(string value)
			{
				base[this.vSchm_TreeCellLineDataTable_0.ParentKeyColumn] = value;
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
						result = (string)base[this.vSchm_TreeCellLineDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'vSchm_TreeCellLine' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vSchm_TreeCellLineDataTable_0.NameColumn] = value;
				}
			}

			public string method_6()
			{
				string result;
				try
				{
					result = (string)base[this.vSchm_TreeCellLineDataTable_0.FullNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'FullName' in table 'vSchm_TreeCellLine' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(string value)
			{
				base[this.vSchm_TreeCellLineDataTable_0.FullNameColumn] = value;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_8()
			{
				return base.IsNull(this.vSchm_TreeCellLineDataTable_0.TypeCodeIdColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_9()
			{
				base[this.vSchm_TreeCellLineDataTable_0.TypeCodeIdColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_10()
			{
				return base.IsNull(this.vSchm_TreeCellLineDataTable_0.ParentKeyColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_11()
			{
				base[this.vSchm_TreeCellLineDataTable_0.ParentKeyColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_12()
			{
				return base.IsNull(this.vSchm_TreeCellLineDataTable_0.NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_13()
			{
				base[this.vSchm_TreeCellLineDataTable_0.NameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_14()
			{
				return base.IsNull(this.vSchm_TreeCellLineDataTable_0.FullNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_15()
			{
				base[this.vSchm_TreeCellLineDataTable_0.FullNameColumn] = Convert.DBNull;
			}

			private DataSetScheme.vSchm_TreeCellLineDataTable vSchm_TreeCellLineDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tP_PassportDataTable : TypedTableBase<DataSetScheme.Class59>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tP_PassportDataTable()
			{
				base.TableName = "tP_Passport";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tP_PassportDataTable(DataTable dataTable_0)
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
			protected tP_PassportDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn ParentIdColumn
			{
				get
				{
					return this.columnParentId;
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
			public DataColumn DateColumn
			{
				get
				{
					return this.columnDate;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DateInColumn
			{
				get
				{
					return this.columnDateIn;
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idOldPassportColumn
			{
				get
				{
					return this.columnidOldPassport;
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
			public DataSetScheme.Class59 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class59)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate16 tP_PassportRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate16 tP_PassportRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate16 tP_PassportRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate16 tP_PassportRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class59 class59_0)
			{
				base.Rows.Add(class59_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class59 method_1(int int_0, int int_1, int int_2, int int_3, DateTime dateTime_0, DateTime dateTime_1, bool bool_0, bool bool_1, int int_4)
			{
				DataSetScheme.Class59 @class = (DataSetScheme.Class59)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					int_0,
					int_1,
					int_2,
					int_3,
					dateTime_0,
					dateTime_1,
					bool_0,
					bool_1,
					int_4
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class59 method_2(int int_0)
			{
				return (DataSetScheme.Class59)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.tP_PassportDataTable tP_PassportDataTable = (DataSetScheme.tP_PassportDataTable)base.Clone();
				tP_PassportDataTable.method_3();
				return tP_PassportDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tP_PassportDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnParentId = base.Columns["ParentId"];
				this.columnidObjList = base.Columns["idObjList"];
				this.columnidEquipment = base.Columns["idEquipment"];
				this.columnNumber = base.Columns["Number"];
				this.columnDate = base.Columns["Date"];
				this.columnDateIn = base.Columns["DateIn"];
				this.columnDeleted = base.Columns["Deleted"];
				this.columnisActive = base.Columns["isActive"];
				this.columnidOldPassport = base.Columns["idOldPassport"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnParentId = new DataColumn("ParentId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnParentId);
				this.columnidObjList = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObjList);
				this.columnidEquipment = new DataColumn("idEquipment", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidEquipment);
				this.columnNumber = new DataColumn("Number", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnNumber);
				this.columnDate = new DataColumn("Date", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDate);
				this.columnDateIn = new DataColumn("DateIn", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateIn);
				this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnDeleted);
				this.columnisActive = new DataColumn("isActive", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnisActive);
				this.columnidOldPassport = new DataColumn("idOldPassport", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidOldPassport);
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
				this.columnidObjList.AllowDBNull = false;
				this.columnNumber.AllowDBNull = false;
				this.columnDate.AllowDBNull = false;
				this.columnDateIn.AllowDBNull = false;
				this.columnDeleted.AllowDBNull = false;
				this.columnisActive.AllowDBNull = false;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class59 method_5()
			{
				return (DataSetScheme.Class59)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class59(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class59);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tP_PassportRowChanged != null)
				{
					this.tP_PassportRowChanged(this, new DataSetScheme.EventArgs14((DataSetScheme.Class59)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tP_PassportRowChanging != null)
				{
					this.tP_PassportRowChanging(this, new DataSetScheme.EventArgs14((DataSetScheme.Class59)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tP_PassportRowDeleted != null)
				{
					this.tP_PassportRowDeleted(this, new DataSetScheme.EventArgs14((DataSetScheme.Class59)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tP_PassportRowDeleting != null)
				{
					this.tP_PassportRowDeleting(this, new DataSetScheme.EventArgs14((DataSetScheme.Class59)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_6(DataSetScheme.Class59 class59_0)
			{
				base.Rows.Remove(class59_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tP_PassportDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnParentId;

			private DataColumn columnidObjList;

			private DataColumn columnidEquipment;

			private DataColumn columnNumber;

			private DataColumn columnDate;

			private DataColumn columnDateIn;

			private DataColumn columnDeleted;

			private DataColumn columnisActive;

			private DataColumn columnidOldPassport;
		}

		public class Class59 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class59(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tP_PassportDataTable_0 = (DataSetScheme.tP_PassportDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tP_PassportDataTable_0.idColumn];
				}
				set
				{
					base[this.tP_PassportDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				int result;
				try
				{
					result = (int)base[this.tP_PassportDataTable_0.ParentIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentId' in table 'tP_Passport' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(int int_0)
			{
				base[this.tP_PassportDataTable_0.ParentIdColumn] = int_0;
			}

			public int method_2()
			{
				return (int)base[this.tP_PassportDataTable_0.idObjListColumn];
			}

			public void method_3(int int_0)
			{
				base[this.tP_PassportDataTable_0.idObjListColumn] = int_0;
			}

			public int method_4()
			{
				int result;
				try
				{
					result = (int)base[this.tP_PassportDataTable_0.idEquipmentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idEquipment' in table 'tP_Passport' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(int int_0)
			{
				base[this.tP_PassportDataTable_0.idEquipmentColumn] = int_0;
			}

			public int method_6()
			{
				return (int)base[this.tP_PassportDataTable_0.NumberColumn];
			}

			public void method_7(int int_0)
			{
				base[this.tP_PassportDataTable_0.NumberColumn] = int_0;
			}

			public DateTime method_8()
			{
				return (DateTime)base[this.tP_PassportDataTable_0.DateColumn];
			}

			public void method_9(DateTime dateTime_0)
			{
				base[this.tP_PassportDataTable_0.DateColumn] = dateTime_0;
			}

			public DateTime method_10()
			{
				return (DateTime)base[this.tP_PassportDataTable_0.DateInColumn];
			}

			public void method_11(DateTime dateTime_0)
			{
				base[this.tP_PassportDataTable_0.DateInColumn] = dateTime_0;
			}

			public bool method_12()
			{
				return (bool)base[this.tP_PassportDataTable_0.DeletedColumn];
			}

			public void method_13(bool bool_0)
			{
				base[this.tP_PassportDataTable_0.DeletedColumn] = bool_0;
			}

			public bool method_14()
			{
				return (bool)base[this.tP_PassportDataTable_0.isActiveColumn];
			}

			public void method_15(bool bool_0)
			{
				base[this.tP_PassportDataTable_0.isActiveColumn] = bool_0;
			}

			public int method_16()
			{
				int result;
				try
				{
					result = (int)base[this.tP_PassportDataTable_0.idOldPassportColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idOldPassport' in table 'tP_Passport' is DBNull.", innerException);
				}
				return result;
			}

			public void method_17(int int_0)
			{
				base[this.tP_PassportDataTable_0.idOldPassportColumn] = int_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_18()
			{
				return base.IsNull(this.tP_PassportDataTable_0.ParentIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_19()
			{
				base[this.tP_PassportDataTable_0.ParentIdColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.tP_PassportDataTable_0.idEquipmentColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_21()
			{
				base[this.tP_PassportDataTable_0.idEquipmentColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_22()
			{
				return base.IsNull(this.tP_PassportDataTable_0.idOldPassportColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_23()
			{
				base[this.tP_PassportDataTable_0.idOldPassportColumn] = Convert.DBNull;
			}

			private DataSetScheme.tP_PassportDataTable tP_PassportDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vSchm_CabSectionDataTable : TypedTableBase<DataSetScheme.Class60>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public vSchm_CabSectionDataTable()
			{
				base.TableName = "vSchm_CabSection";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal vSchm_CabSectionDataTable(DataTable dataTable_0)
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
			protected vSchm_CabSectionDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn idClutchFirstColumn
			{
				get
				{
					return this.columnidClutchFirst;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idClutchSecondColumn
			{
				get
				{
					return this.columnidClutchSecond;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CableMakeupColumn
			{
				get
				{
					return this.columnCableMakeup;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn VoltageColumn
			{
				get
				{
					return this.columnVoltage;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn WiresColumn
			{
				get
				{
					return this.columnWires;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CrossSectionColumn
			{
				get
				{
					return this.columnCrossSection;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn LengthColumn
			{
				get
				{
					return this.columnLength;
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
			public DataSetScheme.Class60 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class60)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate17 vSchm_CabSectionRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate17 vSchm_CabSectionRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate17 vSchm_CabSectionRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate17 vSchm_CabSectionRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class60 class60_0)
			{
				base.Rows.Add(class60_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class60 method_1(int int_0, int int_1, int int_2, int int_3, string string_0, decimal decimal_0, int int_4, decimal decimal_1, decimal decimal_2, bool bool_0)
			{
				DataSetScheme.Class60 @class = (DataSetScheme.Class60)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
					int_1,
					int_2,
					int_3,
					string_0,
					decimal_0,
					int_4,
					decimal_1,
					decimal_2,
					bool_0
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class60 method_2(int int_0)
			{
				return (DataSetScheme.Class60)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.vSchm_CabSectionDataTable vSchm_CabSectionDataTable = (DataSetScheme.vSchm_CabSectionDataTable)base.Clone();
				vSchm_CabSectionDataTable.method_3();
				return vSchm_CabSectionDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.vSchm_CabSectionDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnidObjList = base.Columns["idObjList"];
				this.columnidClutchFirst = base.Columns["idClutchFirst"];
				this.columnidClutchSecond = base.Columns["idClutchSecond"];
				this.columnCableMakeup = base.Columns["CableMakeup"];
				this.columnVoltage = base.Columns["Voltage"];
				this.columnWires = base.Columns["Wires"];
				this.columnCrossSection = base.Columns["CrossSection"];
				this.columnLength = base.Columns["Length"];
				this.columnDeleted = base.Columns["Deleted"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidObjList = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObjList);
				this.columnidClutchFirst = new DataColumn("idClutchFirst", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidClutchFirst);
				this.columnidClutchSecond = new DataColumn("idClutchSecond", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidClutchSecond);
				this.columnCableMakeup = new DataColumn("CableMakeup", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCableMakeup);
				this.columnVoltage = new DataColumn("Voltage", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnVoltage);
				this.columnWires = new DataColumn("Wires", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnWires);
				this.columnCrossSection = new DataColumn("CrossSection", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnCrossSection);
				this.columnLength = new DataColumn("Length", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnLength);
				this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnDeleted);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnid
				}, true));
				this.columnid.AllowDBNull = false;
				this.columnid.Unique = true;
				this.columnidObjList.AllowDBNull = false;
				this.columnidClutchFirst.AllowDBNull = false;
				this.columnidClutchSecond.AllowDBNull = false;
				this.columnCableMakeup.AllowDBNull = false;
				this.columnCableMakeup.MaxLength = 50;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class60 method_5()
			{
				return (DataSetScheme.Class60)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class60(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class60);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vSchm_CabSectionRowChanged != null)
				{
					this.vSchm_CabSectionRowChanged(this, new DataSetScheme.EventArgs15((DataSetScheme.Class60)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vSchm_CabSectionRowChanging != null)
				{
					this.vSchm_CabSectionRowChanging(this, new DataSetScheme.EventArgs15((DataSetScheme.Class60)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vSchm_CabSectionRowDeleted != null)
				{
					this.vSchm_CabSectionRowDeleted(this, new DataSetScheme.EventArgs15((DataSetScheme.Class60)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vSchm_CabSectionRowDeleting != null)
				{
					this.vSchm_CabSectionRowDeleting(this, new DataSetScheme.EventArgs15((DataSetScheme.Class60)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_6(DataSetScheme.Class60 class60_0)
			{
				base.Rows.Remove(class60_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vSchm_CabSectionDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnidObjList;

			private DataColumn columnidClutchFirst;

			private DataColumn columnidClutchSecond;

			private DataColumn columnCableMakeup;

			private DataColumn columnVoltage;

			private DataColumn columnWires;

			private DataColumn columnCrossSection;

			private DataColumn columnLength;

			private DataColumn columnDeleted;
		}

		public class Class60 : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Class60(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vSchm_CabSectionDataTable_0 = (DataSetScheme.vSchm_CabSectionDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.vSchm_CabSectionDataTable_0.idColumn];
				}
				set
				{
					base[this.vSchm_CabSectionDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.vSchm_CabSectionDataTable_0.idObjListColumn];
			}

			public void method_1(int int_0)
			{
				base[this.vSchm_CabSectionDataTable_0.idObjListColumn] = int_0;
			}

			public int method_2()
			{
				return (int)base[this.vSchm_CabSectionDataTable_0.idClutchFirstColumn];
			}

			public void method_3(int int_0)
			{
				base[this.vSchm_CabSectionDataTable_0.idClutchFirstColumn] = int_0;
			}

			public int method_4()
			{
				return (int)base[this.vSchm_CabSectionDataTable_0.idClutchSecondColumn];
			}

			public void method_5(int int_0)
			{
				base[this.vSchm_CabSectionDataTable_0.idClutchSecondColumn] = int_0;
			}

			public string method_6()
			{
				return (string)base[this.vSchm_CabSectionDataTable_0.CableMakeupColumn];
			}

			public void method_7(string value)
			{
				base[this.vSchm_CabSectionDataTable_0.CableMakeupColumn] = value;
			}

			public decimal method_8()
			{
				decimal result;
				try
				{
					result = (decimal)base[this.vSchm_CabSectionDataTable_0.VoltageColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Voltage' in table 'vSchm_CabSection' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(decimal decimal_0)
			{
				base[this.vSchm_CabSectionDataTable_0.VoltageColumn] = decimal_0;
			}

			public int method_10()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_CabSectionDataTable_0.WiresColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Wires' in table 'vSchm_CabSection' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(int int_0)
			{
				base[this.vSchm_CabSectionDataTable_0.WiresColumn] = int_0;
			}

			public decimal method_12()
			{
				decimal result;
				try
				{
					result = (decimal)base[this.vSchm_CabSectionDataTable_0.CrossSectionColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CrossSection' in table 'vSchm_CabSection' is DBNull.", innerException);
				}
				return result;
			}

			public void method_13(decimal decimal_0)
			{
				base[this.vSchm_CabSectionDataTable_0.CrossSectionColumn] = decimal_0;
			}

			public decimal method_14()
			{
				decimal result;
				try
				{
					result = (decimal)base[this.vSchm_CabSectionDataTable_0.LengthColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Length' in table 'vSchm_CabSection' is DBNull.", innerException);
				}
				return result;
			}

			public void method_15(decimal decimal_0)
			{
				base[this.vSchm_CabSectionDataTable_0.LengthColumn] = decimal_0;
			}

			public bool method_16()
			{
				bool result;
				try
				{
					result = (bool)base[this.vSchm_CabSectionDataTable_0.DeletedColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Deleted' in table 'vSchm_CabSection' is DBNull.", innerException);
				}
				return result;
			}

			public void method_17(bool bool_0)
			{
				base[this.vSchm_CabSectionDataTable_0.DeletedColumn] = bool_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_18()
			{
				return base.IsNull(this.vSchm_CabSectionDataTable_0.VoltageColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.vSchm_CabSectionDataTable_0.VoltageColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.vSchm_CabSectionDataTable_0.WiresColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_21()
			{
				base[this.vSchm_CabSectionDataTable_0.WiresColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_22()
			{
				return base.IsNull(this.vSchm_CabSectionDataTable_0.CrossSectionColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_23()
			{
				base[this.vSchm_CabSectionDataTable_0.CrossSectionColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.vSchm_CabSectionDataTable_0.LengthColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.vSchm_CabSectionDataTable_0.LengthColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_26()
			{
				return base.IsNull(this.vSchm_CabSectionDataTable_0.DeletedColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_27()
			{
				base[this.vSchm_CabSectionDataTable_0.DeletedColumn] = Convert.DBNull;
			}

			private DataSetScheme.vSchm_CabSectionDataTable vSchm_CabSectionDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tJ_RelayProtectionAutomationDataTable : TypedTableBase<DataSetScheme.Class61>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tJ_RelayProtectionAutomationDataTable()
			{
				base.TableName = "tJ_RelayProtectionAutomation";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tJ_RelayProtectionAutomationDataTable(DataTable dataTable_0)
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
			protected tJ_RelayProtectionAutomationDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn idSchmObjColumn
			{
				get
				{
					return this.columnidSchmObj;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn nameColumn
			{
				get
				{
					return this.columnname;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn deletedColumn
			{
				get
				{
					return this.columndeleted;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn nameExpColumn
			{
				get
				{
					return this.columnnameExp;
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
			public DataSetScheme.Class61 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class61)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate18 tJ_RelayProtectionAutomationRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate18 tJ_RelayProtectionAutomationRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate18 tJ_RelayProtectionAutomationRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate18 tJ_RelayProtectionAutomationRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class61 class61_0)
			{
				base.Rows.Add(class61_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class61 method_1(int int_0, string string_0, bool bool_0, int int_1)
			{
				DataSetScheme.Class61 @class = (DataSetScheme.Class61)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					int_0,
					string_0,
					bool_0,
					int_1
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class61 method_2(int int_0)
			{
				return (DataSetScheme.Class61)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.tJ_RelayProtectionAutomationDataTable tJ_RelayProtectionAutomationDataTable = (DataSetScheme.tJ_RelayProtectionAutomationDataTable)base.Clone();
				tJ_RelayProtectionAutomationDataTable.method_3();
				return tJ_RelayProtectionAutomationDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tJ_RelayProtectionAutomationDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnidSchmObj = base.Columns["idSchmObj"];
				this.columnname = base.Columns["name"];
				this.columndeleted = base.Columns["deleted"];
				this.columnnameExp = base.Columns["nameExp"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidSchmObj = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidSchmObj);
				this.columnname = new DataColumn("name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnname);
				this.columndeleted = new DataColumn("deleted", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columndeleted);
				this.columnnameExp = new DataColumn("nameExp", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnnameExp);
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
				this.columnidSchmObj.AllowDBNull = false;
				this.columnname.MaxLength = 100;
				this.columndeleted.AllowDBNull = false;
				this.columnnameExp.ReadOnly = true;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class61 method_5()
			{
				return (DataSetScheme.Class61)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class61(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class61);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tJ_RelayProtectionAutomationRowChanged != null)
				{
					this.tJ_RelayProtectionAutomationRowChanged(this, new DataSetScheme.EventArgs16((DataSetScheme.Class61)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tJ_RelayProtectionAutomationRowChanging != null)
				{
					this.tJ_RelayProtectionAutomationRowChanging(this, new DataSetScheme.EventArgs16((DataSetScheme.Class61)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tJ_RelayProtectionAutomationRowDeleted != null)
				{
					this.tJ_RelayProtectionAutomationRowDeleted(this, new DataSetScheme.EventArgs16((DataSetScheme.Class61)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tJ_RelayProtectionAutomationRowDeleting != null)
				{
					this.tJ_RelayProtectionAutomationRowDeleting(this, new DataSetScheme.EventArgs16((DataSetScheme.Class61)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_6(DataSetScheme.Class61 class61_0)
			{
				base.Rows.Remove(class61_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tJ_RelayProtectionAutomationDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnidSchmObj;

			private DataColumn columnname;

			private DataColumn columndeleted;

			private DataColumn columnnameExp;
		}

		public class Class61 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class61(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tJ_RelayProtectionAutomationDataTable_0 = (DataSetScheme.tJ_RelayProtectionAutomationDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tJ_RelayProtectionAutomationDataTable_0.idColumn];
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationDataTable_0.idColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int idSchmObj
			{
				get
				{
					return (int)base[this.tJ_RelayProtectionAutomationDataTable_0.idSchmObjColumn];
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationDataTable_0.idSchmObjColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string name
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tJ_RelayProtectionAutomationDataTable_0.nameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'name' in table 'tJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationDataTable_0.nameColumn] = value;
				}
			}

			public bool method_0()
			{
				return (bool)base[this.tJ_RelayProtectionAutomationDataTable_0.deletedColumn];
			}

			public void method_1(bool bool_0)
			{
				base[this.tJ_RelayProtectionAutomationDataTable_0.deletedColumn] = bool_0;
			}

			public int method_2()
			{
				int result;
				try
				{
					result = (int)base[this.tJ_RelayProtectionAutomationDataTable_0.nameExpColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'nameExp' in table 'tJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(int int_0)
			{
				base[this.tJ_RelayProtectionAutomationDataTable_0.nameExpColumn] = int_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_4()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationDataTable_0.nameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5()
			{
				base[this.tJ_RelayProtectionAutomationDataTable_0.nameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_6()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationDataTable_0.nameExpColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7()
			{
				base[this.tJ_RelayProtectionAutomationDataTable_0.nameExpColumn] = Convert.DBNull;
			}

			private DataSetScheme.tJ_RelayProtectionAutomationDataTable tJ_RelayProtectionAutomationDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tJ_RelayProtectionAutomationValueDataTable : TypedTableBase<DataSetScheme.Class62>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tJ_RelayProtectionAutomationValueDataTable()
			{
				base.TableName = "tJ_RelayProtectionAutomationValue";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tJ_RelayProtectionAutomationValueDataTable(DataTable dataTable_0)
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
			protected tJ_RelayProtectionAutomationValueDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn idRelayColumn
			{
				get
				{
					return this.columnidRelay;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn amp_primaryColumn
			{
				get
				{
					return this.columnamp_primary;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn amp_secondaryColumn
			{
				get
				{
					return this.columnamp_secondary;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idTypeTrColumn
			{
				get
				{
					return this.columnidTypeTr;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn amp_mtzColumn
			{
				get
				{
					return this.columnamp_mtz;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn time_mtzColumn
			{
				get
				{
					return this.columntime_mtz;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn amp_toColumn
			{
				get
				{
					return this.columnamp_to;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn time_toColumn
			{
				get
				{
					return this.columntime_to;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn amp_ozzColumn
			{
				get
				{
					return this.columnamp_ozz;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn time_ozzColumn
			{
				get
				{
					return this.columntime_ozz;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn act_ozzColumn
			{
				get
				{
					return this.columnact_ozz;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn speed_mtzColumn
			{
				get
				{
					return this.columnspeed_mtz;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn amp_urovColumn
			{
				get
				{
					return this.columnamp_urov;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn time_urovColumn
			{
				get
				{
					return this.columntime_urov;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn avrColumn
			{
				get
				{
					return this.columnavr;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn lzshColumn
			{
				get
				{
					return this.columnlzsh;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn type_relayColumn
			{
				get
				{
					return this.columntype_relay;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn type_procColumn
			{
				get
				{
					return this.columntype_proc;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn cpColumn
			{
				get
				{
					return this.columncp;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn cp_cellColumn
			{
				get
				{
					return this.columncp_cell;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn commentColumn
			{
				get
				{
					return this.columncomment;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dateCreateColumn
			{
				get
				{
					return this.columndateCreate;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dateInColumn
			{
				get
				{
					return this.columndateIn;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn deletedColumn
			{
				get
				{
					return this.columndeleted;
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
			public DataSetScheme.Class62 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class62)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate19 tJ_RelayProtectionAutomationValueRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate19 tJ_RelayProtectionAutomationValueRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate19 tJ_RelayProtectionAutomationValueRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate19 tJ_RelayProtectionAutomationValueRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(DataSetScheme.Class62 class62_0)
			{
				base.Rows.Add(class62_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class62 method_1(int int_0, int int_1, int int_2, int int_3, int int_4, double double_0, int int_5, double double_1, int int_6, double double_2, string string_0, double double_3, int int_7, double double_4, bool bool_0, bool bool_1, string string_1, string string_2, string string_3, string string_4, string string_5, DateTime dateTime_0, DateTime dateTime_1, bool bool_2)
			{
				DataSetScheme.Class62 @class = (DataSetScheme.Class62)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					int_0,
					int_1,
					int_2,
					int_3,
					int_4,
					double_0,
					int_5,
					double_1,
					int_6,
					double_2,
					string_0,
					double_3,
					int_7,
					double_4,
					bool_0,
					bool_1,
					string_1,
					string_2,
					string_3,
					string_4,
					string_5,
					dateTime_0,
					dateTime_1,
					bool_2
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class62 method_2(int int_0)
			{
				return (DataSetScheme.Class62)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.tJ_RelayProtectionAutomationValueDataTable tJ_RelayProtectionAutomationValueDataTable = (DataSetScheme.tJ_RelayProtectionAutomationValueDataTable)base.Clone();
				tJ_RelayProtectionAutomationValueDataTable.method_3();
				return tJ_RelayProtectionAutomationValueDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tJ_RelayProtectionAutomationValueDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnidRelay = base.Columns["idRelay"];
				this.columnamp_primary = base.Columns["amp_primary"];
				this.columnamp_secondary = base.Columns["amp_secondary"];
				this.columnidTypeTr = base.Columns["idTypeTr"];
				this.columnamp_mtz = base.Columns["amp_mtz"];
				this.columntime_mtz = base.Columns["time_mtz"];
				this.columnamp_to = base.Columns["amp_to"];
				this.columntime_to = base.Columns["time_to"];
				this.columnamp_ozz = base.Columns["amp_ozz"];
				this.columntime_ozz = base.Columns["time_ozz"];
				this.columnact_ozz = base.Columns["act_ozz"];
				this.columnspeed_mtz = base.Columns["speed_mtz"];
				this.columnamp_urov = base.Columns["amp_urov"];
				this.columntime_urov = base.Columns["time_urov"];
				this.columnavr = base.Columns["avr"];
				this.columnlzsh = base.Columns["lzsh"];
				this.columntype_relay = base.Columns["type_relay"];
				this.columntype_proc = base.Columns["type_proc"];
				this.columncp = base.Columns["cp"];
				this.columncp_cell = base.Columns["cp_cell"];
				this.columncomment = base.Columns["comment"];
				this.columndateCreate = base.Columns["dateCreate"];
				this.columndateIn = base.Columns["dateIn"];
				this.columndeleted = base.Columns["deleted"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidRelay = new DataColumn("idRelay", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidRelay);
				this.columnamp_primary = new DataColumn("amp_primary", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnamp_primary);
				this.columnamp_secondary = new DataColumn("amp_secondary", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnamp_secondary);
				this.columnidTypeTr = new DataColumn("idTypeTr", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTypeTr);
				this.columnamp_mtz = new DataColumn("amp_mtz", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnamp_mtz);
				this.columntime_mtz = new DataColumn("time_mtz", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columntime_mtz);
				this.columnamp_to = new DataColumn("amp_to", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnamp_to);
				this.columntime_to = new DataColumn("time_to", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columntime_to);
				this.columnamp_ozz = new DataColumn("amp_ozz", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnamp_ozz);
				this.columntime_ozz = new DataColumn("time_ozz", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columntime_ozz);
				this.columnact_ozz = new DataColumn("act_ozz", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnact_ozz);
				this.columnspeed_mtz = new DataColumn("speed_mtz", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columnspeed_mtz);
				this.columnamp_urov = new DataColumn("amp_urov", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnamp_urov);
				this.columntime_urov = new DataColumn("time_urov", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columntime_urov);
				this.columnavr = new DataColumn("avr", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnavr);
				this.columnlzsh = new DataColumn("lzsh", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnlzsh);
				this.columntype_relay = new DataColumn("type_relay", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntype_relay);
				this.columntype_proc = new DataColumn("type_proc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntype_proc);
				this.columncp = new DataColumn("cp", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncp);
				this.columncp_cell = new DataColumn("cp_cell", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncp_cell);
				this.columncomment = new DataColumn("comment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncomment);
				this.columndateCreate = new DataColumn("dateCreate", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columndateCreate);
				this.columndateIn = new DataColumn("dateIn", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columndateIn);
				this.columndeleted = new DataColumn("deleted", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columndeleted);
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
				this.columnidRelay.AllowDBNull = false;
				this.columntype_relay.MaxLength = 50;
				this.columntype_proc.MaxLength = 50;
				this.columncp.MaxLength = 100;
				this.columncp_cell.MaxLength = 25;
				this.columncomment.MaxLength = 256;
				this.columndateCreate.AllowDBNull = false;
				this.columndateIn.AllowDBNull = false;
				this.columndeleted.AllowDBNull = false;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class62 method_5()
			{
				return (DataSetScheme.Class62)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class62(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class62);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tJ_RelayProtectionAutomationValueRowChanged != null)
				{
					this.tJ_RelayProtectionAutomationValueRowChanged(this, new DataSetScheme.EventArgs17((DataSetScheme.Class62)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tJ_RelayProtectionAutomationValueRowChanging != null)
				{
					this.tJ_RelayProtectionAutomationValueRowChanging(this, new DataSetScheme.EventArgs17((DataSetScheme.Class62)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tJ_RelayProtectionAutomationValueRowDeleted != null)
				{
					this.tJ_RelayProtectionAutomationValueRowDeleted(this, new DataSetScheme.EventArgs17((DataSetScheme.Class62)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tJ_RelayProtectionAutomationValueRowDeleting != null)
				{
					this.tJ_RelayProtectionAutomationValueRowDeleting(this, new DataSetScheme.EventArgs17((DataSetScheme.Class62)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_6(DataSetScheme.Class62 class62_0)
			{
				base.Rows.Remove(class62_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tJ_RelayProtectionAutomationValueDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnidRelay;

			private DataColumn columnamp_primary;

			private DataColumn columnamp_secondary;

			private DataColumn columnidTypeTr;

			private DataColumn columnamp_mtz;

			private DataColumn columntime_mtz;

			private DataColumn columnamp_to;

			private DataColumn columntime_to;

			private DataColumn columnamp_ozz;

			private DataColumn columntime_ozz;

			private DataColumn columnact_ozz;

			private DataColumn columnspeed_mtz;

			private DataColumn columnamp_urov;

			private DataColumn columntime_urov;

			private DataColumn columnavr;

			private DataColumn columnlzsh;

			private DataColumn columntype_relay;

			private DataColumn columntype_proc;

			private DataColumn columncp;

			private DataColumn columncp_cell;

			private DataColumn columncomment;

			private DataColumn columndateCreate;

			private DataColumn columndateIn;

			private DataColumn columndeleted;
		}

		public class Class62 : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Class62(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tJ_RelayProtectionAutomationValueDataTable_0 = (DataSetScheme.tJ_RelayProtectionAutomationValueDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tJ_RelayProtectionAutomationValueDataTable_0.idColumn];
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.tJ_RelayProtectionAutomationValueDataTable_0.idRelayColumn];
			}

			public void method_1(int int_0)
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.idRelayColumn] = int_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int amp_primary
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_primaryColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'amp_primary' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_primaryColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int amp_secondary
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_secondaryColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'amp_secondary' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_secondaryColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idTypeTr
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tJ_RelayProtectionAutomationValueDataTable_0.idTypeTrColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idTypeTr' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.idTypeTrColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int amp_mtz
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_mtzColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'amp_mtz' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_mtzColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public double time_mtz
			{
				get
				{
					double result;
					try
					{
						result = (double)base[this.tJ_RelayProtectionAutomationValueDataTable_0.time_mtzColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'time_mtz' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.time_mtzColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int amp_to
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_toColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'amp_to' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_toColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public double time_to
			{
				get
				{
					double result;
					try
					{
						result = (double)base[this.tJ_RelayProtectionAutomationValueDataTable_0.time_toColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'time_to' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.time_toColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int amp_ozz
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_ozzColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'amp_ozz' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_ozzColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public double time_ozz
			{
				get
				{
					double result;
					try
					{
						result = (double)base[this.tJ_RelayProtectionAutomationValueDataTable_0.time_ozzColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'time_ozz' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.time_ozzColumn] = value;
				}
			}

			public string method_2()
			{
				string result;
				try
				{
					result = (string)base[this.tJ_RelayProtectionAutomationValueDataTable_0.act_ozzColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'act_ozz' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(string value)
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.act_ozzColumn] = value;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public double speed_mtz
			{
				get
				{
					double result;
					try
					{
						result = (double)base[this.tJ_RelayProtectionAutomationValueDataTable_0.speed_mtzColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'speed_mtz' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.speed_mtzColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int amp_urov
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_urovColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'amp_urov' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_urovColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public double time_urov
			{
				get
				{
					double result;
					try
					{
						result = (double)base[this.tJ_RelayProtectionAutomationValueDataTable_0.time_urovColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'time_urov' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.time_urovColumn] = value;
				}
			}

			public bool method_4()
			{
				bool result;
				try
				{
					result = (bool)base[this.tJ_RelayProtectionAutomationValueDataTable_0.avrColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'avr' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(bool bool_0)
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.avrColumn] = bool_0;
			}

			public bool method_6()
			{
				bool result;
				try
				{
					result = (bool)base[this.tJ_RelayProtectionAutomationValueDataTable_0.lzshColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'lzsh' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(bool bool_0)
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.lzshColumn] = bool_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string type_relay
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tJ_RelayProtectionAutomationValueDataTable_0.type_relayColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'type_relay' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.type_relayColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string type_proc
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tJ_RelayProtectionAutomationValueDataTable_0.type_procColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'type_proc' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.type_procColumn] = value;
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
						result = (string)base[this.tJ_RelayProtectionAutomationValueDataTable_0.cpColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'cp' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.cpColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string cp_cell
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.tJ_RelayProtectionAutomationValueDataTable_0.cp_cellColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'cp_cell' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.cp_cellColumn] = value;
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
						result = (string)base[this.tJ_RelayProtectionAutomationValueDataTable_0.commentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'comment' in table 'tJ_RelayProtectionAutomationValue' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.commentColumn] = value;
				}
			}

			public DateTime method_8()
			{
				return (DateTime)base[this.tJ_RelayProtectionAutomationValueDataTable_0.dateCreateColumn];
			}

			public void method_9(DateTime dateTime_0)
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.dateCreateColumn] = dateTime_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dateIn
			{
				get
				{
					return (DateTime)base[this.tJ_RelayProtectionAutomationValueDataTable_0.dateInColumn];
				}
				set
				{
					base[this.tJ_RelayProtectionAutomationValueDataTable_0.dateInColumn] = value;
				}
			}

			public bool method_10()
			{
				return (bool)base[this.tJ_RelayProtectionAutomationValueDataTable_0.deletedColumn];
			}

			public void method_11(bool bool_0)
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.deletedColumn] = bool_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_12()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.amp_primaryColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_13()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_primaryColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_14()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.amp_secondaryColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_15()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_secondaryColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_16()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.idTypeTrColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_17()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.idTypeTrColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_18()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.amp_mtzColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_mtzColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.time_mtzColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_21()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.time_mtzColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_22()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.amp_toColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_23()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_toColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.time_toColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_25()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.time_toColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_26()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.amp_ozzColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_27()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_ozzColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_28()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.time_ozzColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_29()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.time_ozzColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_30()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.act_ozzColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_31()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.act_ozzColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_32()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.speed_mtzColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_33()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.speed_mtzColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_34()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.amp_urovColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_35()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.amp_urovColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_36()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.time_urovColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_37()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.time_urovColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_38()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.avrColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_39()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.avrColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_40()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.lzshColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_41()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.lzshColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_42()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.type_relayColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_43()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.type_relayColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_44()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.type_procColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_45()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.type_procColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_46()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.cpColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_47()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.cpColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_48()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.cp_cellColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_49()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.cp_cellColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_50()
			{
				return base.IsNull(this.tJ_RelayProtectionAutomationValueDataTable_0.commentColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_51()
			{
				base[this.tJ_RelayProtectionAutomationValueDataTable_0.commentColumn] = Convert.DBNull;
			}

			private DataSetScheme.tJ_RelayProtectionAutomationValueDataTable tJ_RelayProtectionAutomationValueDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vJ_RelayProtectionAutomationDataTable : TypedTableBase<DataSetScheme.Class63>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public vJ_RelayProtectionAutomationDataTable() : this(false)
			{
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public vJ_RelayProtectionAutomationDataTable(bool bool_0)
			{
				base.TableName = "vJ_RelayProtectionAutomation";
				this.BeginInit();
				this.method_4();
				if (bool_0)
				{
					this.method_6();
				}
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal vJ_RelayProtectionAutomationDataTable(DataTable dataTable_0)
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
			protected vJ_RelayProtectionAutomationDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn relayidValueColumn
			{
				get
				{
					return this.columnrelayidValue;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn subIdColumn
			{
				get
				{
					return this.columnsubId;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn sub_NameColumn
			{
				get
				{
					return this.columnsub_Name;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn typeSubColumn
			{
				get
				{
					return this.columntypeSub;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn busIDColumn
			{
				get
				{
					return this.columnbusID;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn bus_nameColumn
			{
				get
				{
					return this.columnbus_name;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn cell_NameColumn
			{
				get
				{
					return this.columncell_Name;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn cellIDColumn
			{
				get
				{
					return this.columncellID;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn relNameColumn
			{
				get
				{
					return this.columnrelName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn amp_primaryColumn
			{
				get
				{
					return this.columnamp_primary;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn amp_secondaryColumn
			{
				get
				{
					return this.columnamp_secondary;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idTypeTrColumn
			{
				get
				{
					return this.columnidTypeTr;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TypetrColumn
			{
				get
				{
					return this.columnTypetr;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn amp_mtzColumn
			{
				get
				{
					return this.columnamp_mtz;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn time_mtzColumn
			{
				get
				{
					return this.columntime_mtz;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn amp_toColumn
			{
				get
				{
					return this.columnamp_to;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn time_toColumn
			{
				get
				{
					return this.columntime_to;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn amp_ozzColumn
			{
				get
				{
					return this.columnamp_ozz;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn time_ozzColumn
			{
				get
				{
					return this.columntime_ozz;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn act_ozzColumn
			{
				get
				{
					return this.columnact_ozz;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn speed_mtzColumn
			{
				get
				{
					return this.columnspeed_mtz;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn amp_urovColumn
			{
				get
				{
					return this.columnamp_urov;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn time_urovColumn
			{
				get
				{
					return this.columntime_urov;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn avrColumn
			{
				get
				{
					return this.columnavr;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn lzshColumn
			{
				get
				{
					return this.columnlzsh;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn type_relayColumn
			{
				get
				{
					return this.columntype_relay;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn type_procColumn
			{
				get
				{
					return this.columntype_proc;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn cpColumn
			{
				get
				{
					return this.columncp;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn cp_cellColumn
			{
				get
				{
					return this.columncp_cell;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn commentColumn
			{
				get
				{
					return this.columncomment;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn dateCreateColumn
			{
				get
				{
					return this.columndateCreate;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn dateInColumn
			{
				get
				{
					return this.columndateIn;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn deletedColumn
			{
				get
				{
					return this.columndeleted;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CoefTRColumn
			{
				get
				{
					return this.columnCoefTR;
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
			public DataSetScheme.Class63 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class63)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate20 vJ_RelayProtectionAutomationRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate20 vJ_RelayProtectionAutomationRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate20 vJ_RelayProtectionAutomationRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate20 vJ_RelayProtectionAutomationRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class63 class63_0)
			{
				base.Rows.Add(class63_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class63 method_1(int int_0, int int_1, int int_2, string string_0, int int_3, int int_4, string string_1, string string_2, int int_5, string string_3, int int_6, int int_7, int int_8, string string_4, int int_9, double double_0, int int_10, double double_1, int int_11, double double_2, string string_5, double double_3, int int_12, double double_4, bool bool_0, bool bool_1, string string_6, string string_7, string string_8, string string_9, string string_10, DateTime dateTime_0, DateTime dateTime_1, bool bool_2, string string_11)
			{
				DataSetScheme.Class63 @class = (DataSetScheme.Class63)base.NewRow();
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
					int_5,
					string_3,
					int_6,
					int_7,
					int_8,
					string_4,
					int_9,
					double_0,
					int_10,
					double_1,
					int_11,
					double_2,
					string_5,
					double_3,
					int_12,
					double_4,
					bool_0,
					bool_1,
					string_6,
					string_7,
					string_8,
					string_9,
					string_10,
					dateTime_0,
					dateTime_1,
					bool_2,
					string_11
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class63 method_2(int int_0, int int_1, int int_2, string string_0, int int_3, int int_4, string string_1, string string_2, int int_5, string string_3, int int_6, int int_7, int int_8, string string_4, int int_9, double double_0, int int_10, double double_1, int int_11, double double_2, string string_5, double double_3, int int_12, double double_4, bool bool_0, bool bool_1, string string_6, string string_7, string string_8, string string_9, string string_10, DateTime dateTime_0, DateTime dateTime_1, bool bool_2)
			{
				DataSetScheme.Class63 @class = (DataSetScheme.Class63)base.NewRow();
				object[] array = new object[35];
				array[0] = int_0;
				array[1] = int_1;
				array[2] = int_2;
				array[3] = string_0;
				array[4] = int_3;
				array[5] = int_4;
				array[6] = string_1;
				array[7] = string_2;
				array[8] = int_5;
				array[9] = string_3;
				array[10] = int_6;
				array[11] = int_7;
				array[12] = int_8;
				array[13] = string_4;
				array[14] = int_9;
				array[15] = double_0;
				array[16] = int_10;
				array[17] = double_1;
				array[18] = int_11;
				array[19] = double_2;
				array[20] = string_5;
				array[21] = double_3;
				array[22] = int_12;
				array[23] = double_4;
				array[24] = bool_0;
				array[25] = bool_1;
				array[26] = string_6;
				array[27] = string_7;
				array[28] = string_8;
				array[29] = string_9;
				array[30] = string_10;
				array[31] = dateTime_0;
				array[32] = dateTime_1;
				array[33] = bool_2;
				object[] itemArray = array;
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.vJ_RelayProtectionAutomationDataTable vJ_RelayProtectionAutomationDataTable = (DataSetScheme.vJ_RelayProtectionAutomationDataTable)base.Clone();
				vJ_RelayProtectionAutomationDataTable.method_3();
				return vJ_RelayProtectionAutomationDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.vJ_RelayProtectionAutomationDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnrelayidValue = base.Columns["relayidValue"];
				this.columnsubId = base.Columns["subId"];
				this.columnsub_Name = base.Columns["sub_Name"];
				this.columntypeSub = base.Columns["typeSub"];
				this.columnbusID = base.Columns["busID"];
				this.columnbus_name = base.Columns["bus_name"];
				this.columncell_Name = base.Columns["cell_Name"];
				this.columncellID = base.Columns["cellID"];
				this.columnrelName = base.Columns["relName"];
				this.columnamp_primary = base.Columns["amp_primary"];
				this.columnamp_secondary = base.Columns["amp_secondary"];
				this.columnidTypeTr = base.Columns["idTypeTr"];
				this.columnTypetr = base.Columns["Typetr"];
				this.columnamp_mtz = base.Columns["amp_mtz"];
				this.columntime_mtz = base.Columns["time_mtz"];
				this.columnamp_to = base.Columns["amp_to"];
				this.columntime_to = base.Columns["time_to"];
				this.columnamp_ozz = base.Columns["amp_ozz"];
				this.columntime_ozz = base.Columns["time_ozz"];
				this.columnact_ozz = base.Columns["act_ozz"];
				this.columnspeed_mtz = base.Columns["speed_mtz"];
				this.columnamp_urov = base.Columns["amp_urov"];
				this.columntime_urov = base.Columns["time_urov"];
				this.columnavr = base.Columns["avr"];
				this.columnlzsh = base.Columns["lzsh"];
				this.columntype_relay = base.Columns["type_relay"];
				this.columntype_proc = base.Columns["type_proc"];
				this.columncp = base.Columns["cp"];
				this.columncp_cell = base.Columns["cp_cell"];
				this.columncomment = base.Columns["comment"];
				this.columndateCreate = base.Columns["dateCreate"];
				this.columndateIn = base.Columns["dateIn"];
				this.columndeleted = base.Columns["deleted"];
				this.columnCoefTR = base.Columns["CoefTR"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnrelayidValue = new DataColumn("relayidValue", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnrelayidValue);
				this.columnsubId = new DataColumn("subId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnsubId);
				this.columnsub_Name = new DataColumn("sub_Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnsub_Name);
				this.columntypeSub = new DataColumn("typeSub", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columntypeSub);
				this.columnbusID = new DataColumn("busID", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnbusID);
				this.columnbus_name = new DataColumn("bus_name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnbus_name);
				this.columncell_Name = new DataColumn("cell_Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncell_Name);
				this.columncellID = new DataColumn("cellID", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columncellID);
				this.columnrelName = new DataColumn("relName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnrelName);
				this.columnamp_primary = new DataColumn("amp_primary", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnamp_primary);
				this.columnamp_secondary = new DataColumn("amp_secondary", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnamp_secondary);
				this.columnidTypeTr = new DataColumn("idTypeTr", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidTypeTr);
				this.columnTypetr = new DataColumn("Typetr", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTypetr);
				this.columnamp_mtz = new DataColumn("amp_mtz", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnamp_mtz);
				this.columntime_mtz = new DataColumn("time_mtz", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columntime_mtz);
				this.columnamp_to = new DataColumn("amp_to", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnamp_to);
				this.columntime_to = new DataColumn("time_to", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columntime_to);
				this.columnamp_ozz = new DataColumn("amp_ozz", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnamp_ozz);
				this.columntime_ozz = new DataColumn("time_ozz", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columntime_ozz);
				this.columnact_ozz = new DataColumn("act_ozz", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnact_ozz);
				this.columnspeed_mtz = new DataColumn("speed_mtz", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columnspeed_mtz);
				this.columnamp_urov = new DataColumn("amp_urov", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnamp_urov);
				this.columntime_urov = new DataColumn("time_urov", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columntime_urov);
				this.columnavr = new DataColumn("avr", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnavr);
				this.columnlzsh = new DataColumn("lzsh", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnlzsh);
				this.columntype_relay = new DataColumn("type_relay", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntype_relay);
				this.columntype_proc = new DataColumn("type_proc", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntype_proc);
				this.columncp = new DataColumn("cp", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncp);
				this.columncp_cell = new DataColumn("cp_cell", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncp_cell);
				this.columncomment = new DataColumn("comment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncomment);
				this.columndateCreate = new DataColumn("dateCreate", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columndateCreate);
				this.columndateIn = new DataColumn("dateIn", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columndateIn);
				this.columndeleted = new DataColumn("deleted", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columndeleted);
				this.columnCoefTR = new DataColumn("CoefTR", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCoefTR);
				this.columnsub_Name.ReadOnly = true;
				this.columnsub_Name.MaxLength = 1000;
				this.columnbus_name.MaxLength = 512;
				this.columncell_Name.MaxLength = 512;
				this.columnrelName.MaxLength = 100;
				this.columnTypetr.MaxLength = 100;
				this.columntype_relay.MaxLength = 50;
				this.columntype_proc.MaxLength = 50;
				this.columncp.MaxLength = 100;
				this.columncp_cell.MaxLength = 25;
				this.columncomment.MaxLength = 256;
				this.columnCoefTR.ReadOnly = true;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class63 method_5()
			{
				return (DataSetScheme.Class63)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class63(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class63);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_6()
			{
				this.CoefTRColumn.Expression = "amp_primary + '/' + amp_secondary";
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vJ_RelayProtectionAutomationRowChanged != null)
				{
					this.vJ_RelayProtectionAutomationRowChanged(this, new DataSetScheme.EventArgs18((DataSetScheme.Class63)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vJ_RelayProtectionAutomationRowChanging != null)
				{
					this.vJ_RelayProtectionAutomationRowChanging(this, new DataSetScheme.EventArgs18((DataSetScheme.Class63)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vJ_RelayProtectionAutomationRowDeleted != null)
				{
					this.vJ_RelayProtectionAutomationRowDeleted(this, new DataSetScheme.EventArgs18((DataSetScheme.Class63)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vJ_RelayProtectionAutomationRowDeleting != null)
				{
					this.vJ_RelayProtectionAutomationRowDeleting(this, new DataSetScheme.EventArgs18((DataSetScheme.Class63)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_7(DataSetScheme.Class63 class63_0)
			{
				base.Rows.Remove(class63_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vJ_RelayProtectionAutomationDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnrelayidValue;

			private DataColumn columnsubId;

			private DataColumn columnsub_Name;

			private DataColumn columntypeSub;

			private DataColumn columnbusID;

			private DataColumn columnbus_name;

			private DataColumn columncell_Name;

			private DataColumn columncellID;

			private DataColumn columnrelName;

			private DataColumn columnamp_primary;

			private DataColumn columnamp_secondary;

			private DataColumn columnidTypeTr;

			private DataColumn columnTypetr;

			private DataColumn columnamp_mtz;

			private DataColumn columntime_mtz;

			private DataColumn columnamp_to;

			private DataColumn columntime_to;

			private DataColumn columnamp_ozz;

			private DataColumn columntime_ozz;

			private DataColumn columnact_ozz;

			private DataColumn columnspeed_mtz;

			private DataColumn columnamp_urov;

			private DataColumn columntime_urov;

			private DataColumn columnavr;

			private DataColumn columnlzsh;

			private DataColumn columntype_relay;

			private DataColumn columntype_proc;

			private DataColumn columncp;

			private DataColumn columncp_cell;

			private DataColumn columncomment;

			private DataColumn columndateCreate;

			private DataColumn columndateIn;

			private DataColumn columndeleted;

			private DataColumn columnCoefTR;
		}

		public class Class63 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class63(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vJ_RelayProtectionAutomationDataTable_0 = (DataSetScheme.vJ_RelayProtectionAutomationDataTable)base.Table;
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
						result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				int result;
				try
				{
					result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.relayidValueColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'relayidValue' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(int int_0)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.relayidValueColumn] = int_0;
			}

			public int method_2()
			{
				int result;
				try
				{
					result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.subIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'subId' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(int int_0)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.subIdColumn] = int_0;
			}

			public string method_4()
			{
				string result;
				try
				{
					result = (string)base[this.vJ_RelayProtectionAutomationDataTable_0.sub_NameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'sub_Name' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(string value)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.sub_NameColumn] = value;
			}

			public int method_6()
			{
				int result;
				try
				{
					result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.typeSubColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'typeSub' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(int int_0)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.typeSubColumn] = int_0;
			}

			public int method_8()
			{
				int result;
				try
				{
					result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.busIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'busID' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(int int_0)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.busIDColumn] = int_0;
			}

			public string method_10()
			{
				string result;
				try
				{
					result = (string)base[this.vJ_RelayProtectionAutomationDataTable_0.bus_nameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'bus_name' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(string value)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.bus_nameColumn] = value;
			}

			public string method_12()
			{
				string result;
				try
				{
					result = (string)base[this.vJ_RelayProtectionAutomationDataTable_0.cell_NameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'cell_Name' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_13(string value)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.cell_NameColumn] = value;
			}

			public int method_14()
			{
				int result;
				try
				{
					result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.cellIDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'cellID' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_15(int int_0)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.cellIDColumn] = int_0;
			}

			public string method_16()
			{
				string result;
				try
				{
					result = (string)base[this.vJ_RelayProtectionAutomationDataTable_0.relNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'relName' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_17(string value)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.relNameColumn] = value;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int amp_primary
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.amp_primaryColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'amp_primary' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.amp_primaryColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int amp_secondary
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.amp_secondaryColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'amp_secondary' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.amp_secondaryColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idTypeTr
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.idTypeTrColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idTypeTr' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.idTypeTrColumn] = value;
				}
			}

			public string method_18()
			{
				string result;
				try
				{
					result = (string)base[this.vJ_RelayProtectionAutomationDataTable_0.TypetrColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Typetr' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_19(string value)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.TypetrColumn] = value;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int amp_mtz
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.amp_mtzColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'amp_mtz' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.amp_mtzColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public double time_mtz
			{
				get
				{
					double result;
					try
					{
						result = (double)base[this.vJ_RelayProtectionAutomationDataTable_0.time_mtzColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'time_mtz' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.time_mtzColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int amp_to
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.amp_toColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'amp_to' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.amp_toColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public double time_to
			{
				get
				{
					double result;
					try
					{
						result = (double)base[this.vJ_RelayProtectionAutomationDataTable_0.time_toColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'time_to' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.time_toColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int amp_ozz
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.amp_ozzColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'amp_ozz' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.amp_ozzColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public double time_ozz
			{
				get
				{
					double result;
					try
					{
						result = (double)base[this.vJ_RelayProtectionAutomationDataTable_0.time_ozzColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'time_ozz' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.time_ozzColumn] = value;
				}
			}

			public string method_20()
			{
				string result;
				try
				{
					result = (string)base[this.vJ_RelayProtectionAutomationDataTable_0.act_ozzColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'act_ozz' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_21(string value)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.act_ozzColumn] = value;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public double speed_mtz
			{
				get
				{
					double result;
					try
					{
						result = (double)base[this.vJ_RelayProtectionAutomationDataTable_0.speed_mtzColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'speed_mtz' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.speed_mtzColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int amp_urov
			{
				get
				{
					int result;
					try
					{
						result = (int)base[this.vJ_RelayProtectionAutomationDataTable_0.amp_urovColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'amp_urov' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.amp_urovColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public double time_urov
			{
				get
				{
					double result;
					try
					{
						result = (double)base[this.vJ_RelayProtectionAutomationDataTable_0.time_urovColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'time_urov' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.time_urovColumn] = value;
				}
			}

			public bool method_22()
			{
				bool result;
				try
				{
					result = (bool)base[this.vJ_RelayProtectionAutomationDataTable_0.avrColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'avr' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_23(bool bool_0)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.avrColumn] = bool_0;
			}

			public bool method_24()
			{
				bool result;
				try
				{
					result = (bool)base[this.vJ_RelayProtectionAutomationDataTable_0.lzshColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'lzsh' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_25(bool bool_0)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.lzshColumn] = bool_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string type_relay
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vJ_RelayProtectionAutomationDataTable_0.type_relayColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'type_relay' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.type_relayColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string type_proc
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vJ_RelayProtectionAutomationDataTable_0.type_procColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'type_proc' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.type_procColumn] = value;
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
						result = (string)base[this.vJ_RelayProtectionAutomationDataTable_0.cpColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'cp' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.cpColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string cp_cell
			{
				get
				{
					string result;
					try
					{
						result = (string)base[this.vJ_RelayProtectionAutomationDataTable_0.cp_cellColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'cp_cell' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.cp_cellColumn] = value;
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
						result = (string)base[this.vJ_RelayProtectionAutomationDataTable_0.commentColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'comment' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.commentColumn] = value;
				}
			}

			public DateTime method_26()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.vJ_RelayProtectionAutomationDataTable_0.dateCreateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'dateCreate' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_27(DateTime dateTime_0)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.dateCreateColumn] = dateTime_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime dateIn
			{
				get
				{
					DateTime result;
					try
					{
						result = (DateTime)base[this.vJ_RelayProtectionAutomationDataTable_0.dateInColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'dateIn' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vJ_RelayProtectionAutomationDataTable_0.dateInColumn] = value;
				}
			}

			public bool method_28()
			{
				bool result;
				try
				{
					result = (bool)base[this.vJ_RelayProtectionAutomationDataTable_0.deletedColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'deleted' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_29(bool bool_0)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.deletedColumn] = bool_0;
			}

			public string method_30()
			{
				string result;
				try
				{
					result = (string)base[this.vJ_RelayProtectionAutomationDataTable_0.CoefTRColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CoefTR' in table 'vJ_RelayProtectionAutomation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_31(string value)
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.CoefTRColumn] = value;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_32()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.idColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_33()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.idColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_34()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.relayidValueColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_35()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.relayidValueColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_36()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.subIdColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_37()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.subIdColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_38()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.sub_NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_39()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.sub_NameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_40()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.typeSubColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_41()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.typeSubColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_42()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.busIDColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_43()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.busIDColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_44()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.bus_nameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_45()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.bus_nameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_46()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.cell_NameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_47()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.cell_NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_48()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.cellIDColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_49()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.cellIDColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_50()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.relNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_51()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.relNameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_52()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.amp_primaryColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_53()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.amp_primaryColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_54()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.amp_secondaryColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_55()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.amp_secondaryColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_56()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.idTypeTrColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_57()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.idTypeTrColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_58()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.TypetrColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_59()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.TypetrColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_60()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.amp_mtzColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_61()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.amp_mtzColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_62()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.time_mtzColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_63()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.time_mtzColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_64()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.amp_toColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_65()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.amp_toColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_66()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.time_toColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_67()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.time_toColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_68()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.amp_ozzColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_69()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.amp_ozzColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_70()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.time_ozzColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_71()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.time_ozzColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_72()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.act_ozzColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_73()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.act_ozzColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_74()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.speed_mtzColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_75()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.speed_mtzColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_76()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.amp_urovColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_77()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.amp_urovColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_78()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.time_urovColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_79()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.time_urovColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_80()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.avrColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_81()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.avrColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_82()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.lzshColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_83()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.lzshColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_84()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.type_relayColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_85()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.type_relayColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_86()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.type_procColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_87()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.type_procColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_88()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.cpColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_89()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.cpColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_90()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.cp_cellColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_91()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.cp_cellColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_92()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.commentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_93()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.commentColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_94()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.dateCreateColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_95()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.dateCreateColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_96()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.dateInColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_97()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.dateInColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_98()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.deletedColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_99()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.deletedColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_100()
			{
				return base.IsNull(this.vJ_RelayProtectionAutomationDataTable_0.CoefTRColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_101()
			{
				base[this.vJ_RelayProtectionAutomationDataTable_0.CoefTRColumn] = Convert.DBNull;
			}

			private DataSetScheme.vJ_RelayProtectionAutomationDataTable vJ_RelayProtectionAutomationDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vSchm_LogDispatcherDataTable : TypedTableBase<DataSetScheme.Class64>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public vSchm_LogDispatcherDataTable()
			{
				base.TableName = "vSchm_LogDispatcher";
				this.BeginInit();
				this.method_3();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal vSchm_LogDispatcherDataTable(DataTable dataTable_0)
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
			protected vSchm_LogDispatcherDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
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
			public DataColumn idUserColumn
			{
				get
				{
					return this.columnidUser;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IdWorkerColumn
			{
				get
				{
					return this.columnIdWorker;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn usernameColumn
			{
				get
				{
					return this.columnusername;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DateLogColumn
			{
				get
				{
					return this.columnDateLog;
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
			public DataColumn NameObjColumn
			{
				get
				{
					return this.columnNameObj;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ActionColumn
			{
				get
				{
					return this.columnAction;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CommentColumn
			{
				get
				{
					return this.columnComment;
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
			public DataSetScheme.Class64 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class64)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate21 vSchm_LogDispatcherRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate21 vSchm_LogDispatcherRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate21 vSchm_LogDispatcherRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate21 vSchm_LogDispatcherRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class64 class64_0)
			{
				base.Rows.Add(class64_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class64 method_1(int int_0, int int_1, int int_2, string string_0, DateTime dateTime_0, int int_3, string string_1, string string_2, string string_3)
			{
				DataSetScheme.Class64 @class = (DataSetScheme.Class64)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
					int_1,
					int_2,
					string_0,
					dateTime_0,
					int_3,
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
				DataSetScheme.vSchm_LogDispatcherDataTable vSchm_LogDispatcherDataTable = (DataSetScheme.vSchm_LogDispatcherDataTable)base.Clone();
				vSchm_LogDispatcherDataTable.method_2();
				return vSchm_LogDispatcherDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.vSchm_LogDispatcherDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_2()
			{
				this.columnid = base.Columns["id"];
				this.columnidUser = base.Columns["idUser"];
				this.columnIdWorker = base.Columns["IdWorker"];
				this.columnusername = base.Columns["username"];
				this.columnDateLog = base.Columns["DateLog"];
				this.columnidObj = base.Columns["idObj"];
				this.columnNameObj = base.Columns["NameObj"];
				this.columnAction = base.Columns["Action"];
				this.columnComment = base.Columns["Comment"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_3()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidUser = new DataColumn("idUser", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidUser);
				this.columnIdWorker = new DataColumn("IdWorker", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnIdWorker);
				this.columnusername = new DataColumn("username", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnusername);
				this.columnDateLog = new DataColumn("DateLog", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateLog);
				this.columnidObj = new DataColumn("idObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObj);
				this.columnNameObj = new DataColumn("NameObj", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnNameObj);
				this.columnAction = new DataColumn("Action", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAction);
				this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnComment);
				this.columnid.AllowDBNull = false;
				this.columnusername.ReadOnly = true;
				this.columnusername.MaxLength = 50;
				this.columnNameObj.ReadOnly = true;
				this.columnNameObj.MaxLength = 1000;
				this.columnAction.AllowDBNull = false;
				this.columnAction.MaxLength = 256;
				this.columnComment.MaxLength = 256;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class64 method_4()
			{
				return (DataSetScheme.Class64)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class64(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class64);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vSchm_LogDispatcherRowChanged != null)
				{
					this.vSchm_LogDispatcherRowChanged(this, new DataSetScheme.EventArgs19((DataSetScheme.Class64)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vSchm_LogDispatcherRowChanging != null)
				{
					this.vSchm_LogDispatcherRowChanging(this, new DataSetScheme.EventArgs19((DataSetScheme.Class64)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vSchm_LogDispatcherRowDeleted != null)
				{
					this.vSchm_LogDispatcherRowDeleted(this, new DataSetScheme.EventArgs19((DataSetScheme.Class64)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vSchm_LogDispatcherRowDeleting != null)
				{
					this.vSchm_LogDispatcherRowDeleting(this, new DataSetScheme.EventArgs19((DataSetScheme.Class64)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5(DataSetScheme.Class64 class64_0)
			{
				base.Rows.Remove(class64_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vSchm_LogDispatcherDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnidUser;

			private DataColumn columnIdWorker;

			private DataColumn columnusername;

			private DataColumn columnDateLog;

			private DataColumn columnidObj;

			private DataColumn columnNameObj;

			private DataColumn columnAction;

			private DataColumn columnComment;
		}

		public class Class64 : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Class64(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vSchm_LogDispatcherDataTable_0 = (DataSetScheme.vSchm_LogDispatcherDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.vSchm_LogDispatcherDataTable_0.idColumn];
				}
				set
				{
					base[this.vSchm_LogDispatcherDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_LogDispatcherDataTable_0.idUserColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idUser' in table 'vSchm_LogDispatcher' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(int int_0)
			{
				base[this.vSchm_LogDispatcherDataTable_0.idUserColumn] = int_0;
			}

			public int method_2()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_LogDispatcherDataTable_0.IdWorkerColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'IdWorker' in table 'vSchm_LogDispatcher' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(int int_0)
			{
				base[this.vSchm_LogDispatcherDataTable_0.IdWorkerColumn] = int_0;
			}

			public string method_4()
			{
				string result;
				try
				{
					result = (string)base[this.vSchm_LogDispatcherDataTable_0.usernameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'username' in table 'vSchm_LogDispatcher' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(string value)
			{
				base[this.vSchm_LogDispatcherDataTable_0.usernameColumn] = value;
			}

			public DateTime method_6()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.vSchm_LogDispatcherDataTable_0.DateLogColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateLog' in table 'vSchm_LogDispatcher' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(DateTime dateTime_0)
			{
				base[this.vSchm_LogDispatcherDataTable_0.DateLogColumn] = dateTime_0;
			}

			public int method_8()
			{
				int result;
				try
				{
					result = (int)base[this.vSchm_LogDispatcherDataTable_0.idObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idObj' in table 'vSchm_LogDispatcher' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(int int_0)
			{
				base[this.vSchm_LogDispatcherDataTable_0.idObjColumn] = int_0;
			}

			public string method_10()
			{
				string result;
				try
				{
					result = (string)base[this.vSchm_LogDispatcherDataTable_0.NameObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NameObj' in table 'vSchm_LogDispatcher' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(string value)
			{
				base[this.vSchm_LogDispatcherDataTable_0.NameObjColumn] = value;
			}

			public string method_12()
			{
				return (string)base[this.vSchm_LogDispatcherDataTable_0.ActionColumn];
			}

			public void method_13(string value)
			{
				base[this.vSchm_LogDispatcherDataTable_0.ActionColumn] = value;
			}

			public string method_14()
			{
				string result;
				try
				{
					result = (string)base[this.vSchm_LogDispatcherDataTable_0.CommentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Comment' in table 'vSchm_LogDispatcher' is DBNull.", innerException);
				}
				return result;
			}

			public void method_15(string value)
			{
				base[this.vSchm_LogDispatcherDataTable_0.CommentColumn] = value;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_16()
			{
				return base.IsNull(this.vSchm_LogDispatcherDataTable_0.idUserColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_17()
			{
				base[this.vSchm_LogDispatcherDataTable_0.idUserColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_18()
			{
				return base.IsNull(this.vSchm_LogDispatcherDataTable_0.IdWorkerColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.vSchm_LogDispatcherDataTable_0.IdWorkerColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_20()
			{
				return base.IsNull(this.vSchm_LogDispatcherDataTable_0.usernameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.vSchm_LogDispatcherDataTable_0.usernameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_22()
			{
				return base.IsNull(this.vSchm_LogDispatcherDataTable_0.DateLogColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_23()
			{
				base[this.vSchm_LogDispatcherDataTable_0.DateLogColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.vSchm_LogDispatcherDataTable_0.idObjColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_25()
			{
				base[this.vSchm_LogDispatcherDataTable_0.idObjColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_26()
			{
				return base.IsNull(this.vSchm_LogDispatcherDataTable_0.NameObjColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_27()
			{
				base[this.vSchm_LogDispatcherDataTable_0.NameObjColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_28()
			{
				return base.IsNull(this.vSchm_LogDispatcherDataTable_0.CommentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_29()
			{
				base[this.vSchm_LogDispatcherDataTable_0.CommentColumn] = Convert.DBNull;
			}

			private DataSetScheme.vSchm_LogDispatcherDataTable vSchm_LogDispatcherDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tP_CharListDataTable : TypedTableBase<DataSetScheme.Class65>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public tP_CharListDataTable()
			{
				base.TableName = "tP_CharList";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tP_CharListDataTable(DataTable dataTable_0)
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
			protected tP_CharListDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn ParentIdColumn
			{
				get
				{
					return this.columnParentId;
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
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ShortNameColumn
			{
				get
				{
					return this.columnShortName;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TypeColumn
			{
				get
				{
					return this.columnType;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn FormatColumn
			{
				get
				{
					return this.columnFormat;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idValueListColumn
			{
				get
				{
					return this.columnidValueList;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TableNameColumn
			{
				get
				{
					return this.columnTableName;
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CommentColumn
			{
				get
				{
					return this.columnComment;
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
			public DataColumn PanelColumn
			{
				get
				{
					return this.columnPanel;
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
			public DataSetScheme.Class65 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class65)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate22 tP_CharListRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate22 tP_CharListRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate22 tP_CharListRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate22 tP_CharListRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(DataSetScheme.Class65 class65_0)
			{
				base.Rows.Add(class65_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class65 method_1(int int_0, string string_0, string string_1, string string_2, int int_1, int int_2, int int_3, string string_3, int int_4, string string_4, bool bool_0, bool bool_1, bool bool_2)
			{
				DataSetScheme.Class65 @class = (DataSetScheme.Class65)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					int_0,
					string_0,
					string_1,
					string_2,
					int_1,
					int_2,
					int_3,
					string_3,
					int_4,
					string_4,
					bool_0,
					bool_1,
					bool_2
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class65 method_2(int int_0)
			{
				return (DataSetScheme.Class65)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.tP_CharListDataTable tP_CharListDataTable = (DataSetScheme.tP_CharListDataTable)base.Clone();
				tP_CharListDataTable.method_3();
				return tP_CharListDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tP_CharListDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnParentId = base.Columns["ParentId"];
				this.columnParentKey = base.Columns["ParentKey"];
				this.columnName = base.Columns["Name"];
				this.columnShortName = base.Columns["ShortName"];
				this.columnType = base.Columns["Type"];
				this.columnFormat = base.Columns["Format"];
				this.columnidValueList = base.Columns["idValueList"];
				this.columnTableName = base.Columns["TableName"];
				this.columnTabIndex = base.Columns["TabIndex"];
				this.columnComment = base.Columns["Comment"];
				this.columnisGroup = base.Columns["isGroup"];
				this.columnPanel = base.Columns["Panel"];
				this.columnDeleted = base.Columns["Deleted"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnParentId = new DataColumn("ParentId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnParentId);
				this.columnParentKey = new DataColumn("ParentKey", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParentKey);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnShortName = new DataColumn("ShortName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnShortName);
				this.columnType = new DataColumn("Type", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnType);
				this.columnFormat = new DataColumn("Format", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnFormat);
				this.columnidValueList = new DataColumn("idValueList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidValueList);
				this.columnTableName = new DataColumn("TableName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTableName);
				this.columnTabIndex = new DataColumn("TabIndex", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTabIndex);
				this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnComment);
				this.columnisGroup = new DataColumn("isGroup", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnisGroup);
				this.columnPanel = new DataColumn("Panel", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnPanel);
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
				this.columnParentKey.MaxLength = 50;
				this.columnName.AllowDBNull = false;
				this.columnName.MaxLength = 50;
				this.columnShortName.MaxLength = 50;
				this.columnTableName.MaxLength = 50;
				this.columnComment.MaxLength = 250;
				this.columnisGroup.AllowDBNull = false;
				this.columnPanel.AllowDBNull = false;
				this.columnDeleted.AllowDBNull = false;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class65 method_5()
			{
				return (DataSetScheme.Class65)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class65(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class65);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tP_CharListRowChanged != null)
				{
					this.tP_CharListRowChanged(this, new DataSetScheme.EventArgs20((DataSetScheme.Class65)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tP_CharListRowChanging != null)
				{
					this.tP_CharListRowChanging(this, new DataSetScheme.EventArgs20((DataSetScheme.Class65)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tP_CharListRowDeleted != null)
				{
					this.tP_CharListRowDeleted(this, new DataSetScheme.EventArgs20((DataSetScheme.Class65)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tP_CharListRowDeleting != null)
				{
					this.tP_CharListRowDeleting(this, new DataSetScheme.EventArgs20((DataSetScheme.Class65)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_6(DataSetScheme.Class65 class65_0)
			{
				base.Rows.Remove(class65_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tP_CharListDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnParentId;

			private DataColumn columnParentKey;

			private DataColumn columnName;

			private DataColumn columnShortName;

			private DataColumn columnType;

			private DataColumn columnFormat;

			private DataColumn columnidValueList;

			private DataColumn columnTableName;

			private DataColumn columnTabIndex;

			private DataColumn columnComment;

			private DataColumn columnisGroup;

			private DataColumn columnPanel;

			private DataColumn columnDeleted;
		}

		public class Class65 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class65(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tP_CharListDataTable_0 = (DataSetScheme.tP_CharListDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tP_CharListDataTable_0.idColumn];
				}
				set
				{
					base[this.tP_CharListDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				int result;
				try
				{
					result = (int)base[this.tP_CharListDataTable_0.ParentIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentId' in table 'tP_CharList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(int int_0)
			{
				base[this.tP_CharListDataTable_0.ParentIdColumn] = int_0;
			}

			public string method_2()
			{
				string result;
				try
				{
					result = (string)base[this.tP_CharListDataTable_0.ParentKeyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKey' in table 'tP_CharList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(string value)
			{
				base[this.tP_CharListDataTable_0.ParentKeyColumn] = value;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					return (string)base[this.tP_CharListDataTable_0.NameColumn];
				}
				set
				{
					base[this.tP_CharListDataTable_0.NameColumn] = value;
				}
			}

			public string method_4()
			{
				string result;
				try
				{
					result = (string)base[this.tP_CharListDataTable_0.ShortNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ShortName' in table 'tP_CharList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(string value)
			{
				base[this.tP_CharListDataTable_0.ShortNameColumn] = value;
			}

			public int method_6()
			{
				int result;
				try
				{
					result = (int)base[this.tP_CharListDataTable_0.TypeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Type' in table 'tP_CharList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(int int_0)
			{
				base[this.tP_CharListDataTable_0.TypeColumn] = int_0;
			}

			public int method_8()
			{
				int result;
				try
				{
					result = (int)base[this.tP_CharListDataTable_0.FormatColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Format' in table 'tP_CharList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(int int_0)
			{
				base[this.tP_CharListDataTable_0.FormatColumn] = int_0;
			}

			public int method_10()
			{
				int result;
				try
				{
					result = (int)base[this.tP_CharListDataTable_0.idValueListColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idValueList' in table 'tP_CharList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(int int_0)
			{
				base[this.tP_CharListDataTable_0.idValueListColumn] = int_0;
			}

			public string method_12()
			{
				string result;
				try
				{
					result = (string)base[this.tP_CharListDataTable_0.TableNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TableName' in table 'tP_CharList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_13(string value)
			{
				base[this.tP_CharListDataTable_0.TableNameColumn] = value;
			}

			public int method_14()
			{
				int result;
				try
				{
					result = (int)base[this.tP_CharListDataTable_0.TabIndexColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TabIndex' in table 'tP_CharList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_15(int int_0)
			{
				base[this.tP_CharListDataTable_0.TabIndexColumn] = int_0;
			}

			public string method_16()
			{
				string result;
				try
				{
					result = (string)base[this.tP_CharListDataTable_0.CommentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Comment' in table 'tP_CharList' is DBNull.", innerException);
				}
				return result;
			}

			public void method_17(string value)
			{
				base[this.tP_CharListDataTable_0.CommentColumn] = value;
			}

			public bool method_18()
			{
				return (bool)base[this.tP_CharListDataTable_0.isGroupColumn];
			}

			public void method_19(bool bool_0)
			{
				base[this.tP_CharListDataTable_0.isGroupColumn] = bool_0;
			}

			public bool method_20()
			{
				return (bool)base[this.tP_CharListDataTable_0.PanelColumn];
			}

			public void method_21(bool bool_0)
			{
				base[this.tP_CharListDataTable_0.PanelColumn] = bool_0;
			}

			public bool method_22()
			{
				return (bool)base[this.tP_CharListDataTable_0.DeletedColumn];
			}

			public void method_23(bool bool_0)
			{
				base[this.tP_CharListDataTable_0.DeletedColumn] = bool_0;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_24()
			{
				return base.IsNull(this.tP_CharListDataTable_0.ParentIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_25()
			{
				base[this.tP_CharListDataTable_0.ParentIdColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_26()
			{
				return base.IsNull(this.tP_CharListDataTable_0.ParentKeyColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_27()
			{
				base[this.tP_CharListDataTable_0.ParentKeyColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_28()
			{
				return base.IsNull(this.tP_CharListDataTable_0.ShortNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_29()
			{
				base[this.tP_CharListDataTable_0.ShortNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_30()
			{
				return base.IsNull(this.tP_CharListDataTable_0.TypeColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_31()
			{
				base[this.tP_CharListDataTable_0.TypeColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_32()
			{
				return base.IsNull(this.tP_CharListDataTable_0.FormatColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_33()
			{
				base[this.tP_CharListDataTable_0.FormatColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_34()
			{
				return base.IsNull(this.tP_CharListDataTable_0.idValueListColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_35()
			{
				base[this.tP_CharListDataTable_0.idValueListColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_36()
			{
				return base.IsNull(this.tP_CharListDataTable_0.TableNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_37()
			{
				base[this.tP_CharListDataTable_0.TableNameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_38()
			{
				return base.IsNull(this.tP_CharListDataTable_0.TabIndexColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_39()
			{
				base[this.tP_CharListDataTable_0.TabIndexColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_40()
			{
				return base.IsNull(this.tP_CharListDataTable_0.CommentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_41()
			{
				base[this.tP_CharListDataTable_0.CommentColumn] = Convert.DBNull;
			}

			private DataSetScheme.tP_CharListDataTable tP_CharListDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tP_CabOperationDataTable : TypedTableBase<DataSetScheme.Class66>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tP_CabOperationDataTable()
			{
				base.TableName = "tP_CabOperation";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tP_CabOperationDataTable(DataTable dataTable_0)
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
			protected tP_CabOperationDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn DateDecommissioningColumn
			{
				get
				{
					return this.columnDateDecommissioning;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DateCommissioningColumn
			{
				get
				{
					return this.columnDateCommissioning;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ReasonColumn
			{
				get
				{
					return this.columnReason;
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
			public DataSetScheme.Class66 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class66)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate23 tP_CabOperationRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate23 tP_CabOperationRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate23 tP_CabOperationRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate23 tP_CabOperationRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class66 class66_0)
			{
				base.Rows.Add(class66_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class66 method_1(int int_0, DateTime dateTime_0, DateTime dateTime_1, int int_1, bool bool_0)
			{
				DataSetScheme.Class66 @class = (DataSetScheme.Class66)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					int_0,
					dateTime_0,
					dateTime_1,
					int_1,
					bool_0
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class66 method_2(int int_0)
			{
				return (DataSetScheme.Class66)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.tP_CabOperationDataTable tP_CabOperationDataTable = (DataSetScheme.tP_CabOperationDataTable)base.Clone();
				tP_CabOperationDataTable.method_3();
				return tP_CabOperationDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tP_CabOperationDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnidObjList = base.Columns["idObjList"];
				this.columnDateDecommissioning = base.Columns["DateDecommissioning"];
				this.columnDateCommissioning = base.Columns["DateCommissioning"];
				this.columnReason = base.Columns["Reason"];
				this.columnDeleted = base.Columns["Deleted"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidObjList = new DataColumn("idObjList", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObjList);
				this.columnDateDecommissioning = new DataColumn("DateDecommissioning", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateDecommissioning);
				this.columnDateCommissioning = new DataColumn("DateCommissioning", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateCommissioning);
				this.columnReason = new DataColumn("Reason", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnReason);
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
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class66 method_5()
			{
				return (DataSetScheme.Class66)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class66(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class66);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tP_CabOperationRowChanged != null)
				{
					this.tP_CabOperationRowChanged(this, new DataSetScheme.EventArgs21((DataSetScheme.Class66)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tP_CabOperationRowChanging != null)
				{
					this.tP_CabOperationRowChanging(this, new DataSetScheme.EventArgs21((DataSetScheme.Class66)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tP_CabOperationRowDeleted != null)
				{
					this.tP_CabOperationRowDeleted(this, new DataSetScheme.EventArgs21((DataSetScheme.Class66)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tP_CabOperationRowDeleting != null)
				{
					this.tP_CabOperationRowDeleting(this, new DataSetScheme.EventArgs21((DataSetScheme.Class66)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_6(DataSetScheme.Class66 class66_0)
			{
				base.Rows.Remove(class66_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tP_CabOperationDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnidObjList;

			private DataColumn columnDateDecommissioning;

			private DataColumn columnDateCommissioning;

			private DataColumn columnReason;

			private DataColumn columnDeleted;
		}

		public class Class66 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class66(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tP_CabOperationDataTable_0 = (DataSetScheme.tP_CabOperationDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tP_CabOperationDataTable_0.idColumn];
				}
				set
				{
					base[this.tP_CabOperationDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				int result;
				try
				{
					result = (int)base[this.tP_CabOperationDataTable_0.idObjListColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idObjList' in table 'tP_CabOperation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(int int_0)
			{
				base[this.tP_CabOperationDataTable_0.idObjListColumn] = int_0;
			}

			public DateTime method_2()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.tP_CabOperationDataTable_0.DateDecommissioningColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateDecommissioning' in table 'tP_CabOperation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(DateTime dateTime_0)
			{
				base[this.tP_CabOperationDataTable_0.DateDecommissioningColumn] = dateTime_0;
			}

			public DateTime method_4()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.tP_CabOperationDataTable_0.DateCommissioningColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateCommissioning' in table 'tP_CabOperation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(DateTime dateTime_0)
			{
				base[this.tP_CabOperationDataTable_0.DateCommissioningColumn] = dateTime_0;
			}

			public int method_6()
			{
				int result;
				try
				{
					result = (int)base[this.tP_CabOperationDataTable_0.ReasonColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Reason' in table 'tP_CabOperation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(int int_0)
			{
				base[this.tP_CabOperationDataTable_0.ReasonColumn] = int_0;
			}

			public bool method_8()
			{
				bool result;
				try
				{
					result = (bool)base[this.tP_CabOperationDataTable_0.DeletedColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Deleted' in table 'tP_CabOperation' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(bool bool_0)
			{
				base[this.tP_CabOperationDataTable_0.DeletedColumn] = bool_0;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_10()
			{
				return base.IsNull(this.tP_CabOperationDataTable_0.idObjListColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_11()
			{
				base[this.tP_CabOperationDataTable_0.idObjListColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_12()
			{
				return base.IsNull(this.tP_CabOperationDataTable_0.DateDecommissioningColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_13()
			{
				base[this.tP_CabOperationDataTable_0.DateDecommissioningColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_14()
			{
				return base.IsNull(this.tP_CabOperationDataTable_0.DateCommissioningColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_15()
			{
				base[this.tP_CabOperationDataTable_0.DateCommissioningColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_16()
			{
				return base.IsNull(this.tP_CabOperationDataTable_0.ReasonColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_17()
			{
				base[this.tP_CabOperationDataTable_0.ReasonColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_18()
			{
				return base.IsNull(this.tP_CabOperationDataTable_0.DeletedColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_19()
			{
				base[this.tP_CabOperationDataTable_0.DeletedColumn] = Convert.DBNull;
			}

			private DataSetScheme.tP_CabOperationDataTable tP_CabOperationDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class v_AbnObjRazreshDataTable : TypedTableBase<DataSetScheme.Class67>
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public v_AbnObjRazreshDataTable()
			{
				base.TableName = "v_AbnObjRazresh";
				this.BeginInit();
				this.method_3();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal v_AbnObjRazreshDataTable(DataTable dataTable_0)
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
			protected v_AbnObjRazreshDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_2();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idAbnColumn
			{
				get
				{
					return this.columnidAbn;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn codeAbonentColumn
			{
				get
				{
					return this.columncodeAbonent;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn nameAbnColumn
			{
				get
				{
					return this.columnnameAbn;
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

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn nameObjColumn
			{
				get
				{
					return this.columnnameObj;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn categoryNameColumn
			{
				get
				{
					return this.columncategoryName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn tariffNameColumn
			{
				get
				{
					return this.columntariffName;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn RazreshColumn
			{
				get
				{
					return this.columnRazresh;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn busHighColumn
			{
				get
				{
					return this.columnbusHigh;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn busLowColumn
			{
				get
				{
					return this.columnbusLow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn rubilnikColumn
			{
				get
				{
					return this.columnrubilnik;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PowerColumn
			{
				get
				{
					return this.columnPower;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn id_razrColumn
			{
				get
				{
					return this.columnid_razr;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ContactColumn
			{
				get
				{
					return this.columnContact;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn tpNameColumn
			{
				get
				{
					return this.columntpName;
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
			public DataSetScheme.Class67 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class67)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate24 v_AbnObjRazreshRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate24 v_AbnObjRazreshRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate24 v_AbnObjRazreshRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate24 v_AbnObjRazreshRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(DataSetScheme.Class67 class67_0)
			{
				base.Rows.Add(class67_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class67 method_1(int int_0, int int_1, string string_0, int int_2, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, double double_0, int int_3, string string_8, string string_9)
			{
				DataSetScheme.Class67 @class = (DataSetScheme.Class67)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
					int_1,
					string_0,
					int_2,
					string_1,
					string_2,
					string_3,
					string_4,
					string_5,
					string_6,
					string_7,
					double_0,
					int_3,
					string_8,
					string_9
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.v_AbnObjRazreshDataTable v_AbnObjRazreshDataTable = (DataSetScheme.v_AbnObjRazreshDataTable)base.Clone();
				v_AbnObjRazreshDataTable.method_2();
				return v_AbnObjRazreshDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.v_AbnObjRazreshDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_2()
			{
				this.columnidAbn = base.Columns["idAbn"];
				this.columncodeAbonent = base.Columns["codeAbonent"];
				this.columnnameAbn = base.Columns["nameAbn"];
				this.columnidObj = base.Columns["idObj"];
				this.columnnameObj = base.Columns["nameObj"];
				this.columncategoryName = base.Columns["categoryName"];
				this.columntariffName = base.Columns["tariffName"];
				this.columnRazresh = base.Columns["Razresh"];
				this.columnbusHigh = base.Columns["busHigh"];
				this.columnbusLow = base.Columns["busLow"];
				this.columnrubilnik = base.Columns["rubilnik"];
				this.columnPower = base.Columns["Power"];
				this.columnid_razr = base.Columns["id_razr"];
				this.columnContact = base.Columns["Contact"];
				this.columntpName = base.Columns["tpName"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_3()
			{
				this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidAbn);
				this.columncodeAbonent = new DataColumn("codeAbonent", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columncodeAbonent);
				this.columnnameAbn = new DataColumn("nameAbn", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnnameAbn);
				this.columnidObj = new DataColumn("idObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObj);
				this.columnnameObj = new DataColumn("nameObj", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnnameObj);
				this.columncategoryName = new DataColumn("categoryName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncategoryName);
				this.columntariffName = new DataColumn("tariffName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntariffName);
				this.columnRazresh = new DataColumn("Razresh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnRazresh);
				this.columnbusHigh = new DataColumn("busHigh", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnbusHigh);
				this.columnbusLow = new DataColumn("busLow", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnbusLow);
				this.columnrubilnik = new DataColumn("rubilnik", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnrubilnik);
				this.columnPower = new DataColumn("Power", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columnPower);
				this.columnid_razr = new DataColumn("id_razr", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid_razr);
				this.columnContact = new DataColumn("Contact", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnContact);
				this.columntpName = new DataColumn("tpName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columntpName);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class67 method_4()
			{
				return (DataSetScheme.Class67)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class67(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class67);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.v_AbnObjRazreshRowChanged != null)
				{
					this.v_AbnObjRazreshRowChanged(this, new DataSetScheme.EventArgs22((DataSetScheme.Class67)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.v_AbnObjRazreshRowChanging != null)
				{
					this.v_AbnObjRazreshRowChanging(this, new DataSetScheme.EventArgs22((DataSetScheme.Class67)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.v_AbnObjRazreshRowDeleted != null)
				{
					this.v_AbnObjRazreshRowDeleted(this, new DataSetScheme.EventArgs22((DataSetScheme.Class67)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.v_AbnObjRazreshRowDeleting != null)
				{
					this.v_AbnObjRazreshRowDeleting(this, new DataSetScheme.EventArgs22((DataSetScheme.Class67)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_5(DataSetScheme.Class67 class67_0)
			{
				base.Rows.Remove(class67_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "v_AbnObjRazreshDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnidAbn;

			private DataColumn columncodeAbonent;

			private DataColumn columnnameAbn;

			private DataColumn columnidObj;

			private DataColumn columnnameObj;

			private DataColumn columncategoryName;

			private DataColumn columntariffName;

			private DataColumn columnRazresh;

			private DataColumn columnbusHigh;

			private DataColumn columnbusLow;

			private DataColumn columnrubilnik;

			private DataColumn columnPower;

			private DataColumn columnid_razr;

			private DataColumn columnContact;

			private DataColumn columntpName;
		}

		public class Class67 : DataRow
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal Class67(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.v_AbnObjRazreshDataTable_0 = (DataSetScheme.v_AbnObjRazreshDataTable)base.Table;
			}

			public int method_0()
			{
				int result;
				try
				{
					result = (int)base[this.v_AbnObjRazreshDataTable_0.idAbnColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idAbn' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_1(int int_0)
			{
				base[this.v_AbnObjRazreshDataTable_0.idAbnColumn] = int_0;
			}

			public int method_2()
			{
				int result;
				try
				{
					result = (int)base[this.v_AbnObjRazreshDataTable_0.codeAbonentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'codeAbonent' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(int int_0)
			{
				base[this.v_AbnObjRazreshDataTable_0.codeAbonentColumn] = int_0;
			}

			public string method_4()
			{
				string result;
				try
				{
					result = (string)base[this.v_AbnObjRazreshDataTable_0.nameAbnColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'nameAbn' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(string value)
			{
				base[this.v_AbnObjRazreshDataTable_0.nameAbnColumn] = value;
			}

			public int method_6()
			{
				int result;
				try
				{
					result = (int)base[this.v_AbnObjRazreshDataTable_0.idObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idObj' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(int int_0)
			{
				base[this.v_AbnObjRazreshDataTable_0.idObjColumn] = int_0;
			}

			public string method_8()
			{
				string result;
				try
				{
					result = (string)base[this.v_AbnObjRazreshDataTable_0.nameObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'nameObj' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(string value)
			{
				base[this.v_AbnObjRazreshDataTable_0.nameObjColumn] = value;
			}

			public string method_10()
			{
				string result;
				try
				{
					result = (string)base[this.v_AbnObjRazreshDataTable_0.categoryNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'categoryName' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(string value)
			{
				base[this.v_AbnObjRazreshDataTable_0.categoryNameColumn] = value;
			}

			public string method_12()
			{
				string result;
				try
				{
					result = (string)base[this.v_AbnObjRazreshDataTable_0.tariffNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'tariffName' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_13(string value)
			{
				base[this.v_AbnObjRazreshDataTable_0.tariffNameColumn] = value;
			}

			public string method_14()
			{
				string result;
				try
				{
					result = (string)base[this.v_AbnObjRazreshDataTable_0.RazreshColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Razresh' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_15(string value)
			{
				base[this.v_AbnObjRazreshDataTable_0.RazreshColumn] = value;
			}

			public string method_16()
			{
				string result;
				try
				{
					result = (string)base[this.v_AbnObjRazreshDataTable_0.busHighColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'busHigh' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_17(string value)
			{
				base[this.v_AbnObjRazreshDataTable_0.busHighColumn] = value;
			}

			public string method_18()
			{
				string result;
				try
				{
					result = (string)base[this.v_AbnObjRazreshDataTable_0.busLowColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'busLow' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_19(string value)
			{
				base[this.v_AbnObjRazreshDataTable_0.busLowColumn] = value;
			}

			public string method_20()
			{
				string result;
				try
				{
					result = (string)base[this.v_AbnObjRazreshDataTable_0.rubilnikColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'rubilnik' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_21(string value)
			{
				base[this.v_AbnObjRazreshDataTable_0.rubilnikColumn] = value;
			}

			public double method_22()
			{
				double result;
				try
				{
					result = (double)base[this.v_AbnObjRazreshDataTable_0.PowerColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Power' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_23(double double_0)
			{
				base[this.v_AbnObjRazreshDataTable_0.PowerColumn] = double_0;
			}

			public int method_24()
			{
				int result;
				try
				{
					result = (int)base[this.v_AbnObjRazreshDataTable_0.id_razrColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'id_razr' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_25(int int_0)
			{
				base[this.v_AbnObjRazreshDataTable_0.id_razrColumn] = int_0;
			}

			public string method_26()
			{
				string result;
				try
				{
					result = (string)base[this.v_AbnObjRazreshDataTable_0.ContactColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Contact' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_27(string value)
			{
				base[this.v_AbnObjRazreshDataTable_0.ContactColumn] = value;
			}

			public string method_28()
			{
				string result;
				try
				{
					result = (string)base[this.v_AbnObjRazreshDataTable_0.tpNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'tpName' in table 'v_AbnObjRazresh' is DBNull.", innerException);
				}
				return result;
			}

			public void method_29(string value)
			{
				base[this.v_AbnObjRazreshDataTable_0.tpNameColumn] = value;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_30()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.idAbnColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_31()
			{
				base[this.v_AbnObjRazreshDataTable_0.idAbnColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_32()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.codeAbonentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_33()
			{
				base[this.v_AbnObjRazreshDataTable_0.codeAbonentColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_34()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.nameAbnColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_35()
			{
				base[this.v_AbnObjRazreshDataTable_0.nameAbnColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_36()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.idObjColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_37()
			{
				base[this.v_AbnObjRazreshDataTable_0.idObjColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_38()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.nameObjColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_39()
			{
				base[this.v_AbnObjRazreshDataTable_0.nameObjColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_40()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.categoryNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_41()
			{
				base[this.v_AbnObjRazreshDataTable_0.categoryNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_42()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.tariffNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_43()
			{
				base[this.v_AbnObjRazreshDataTable_0.tariffNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_44()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.RazreshColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_45()
			{
				base[this.v_AbnObjRazreshDataTable_0.RazreshColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_46()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.busHighColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_47()
			{
				base[this.v_AbnObjRazreshDataTable_0.busHighColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_48()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.busLowColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_49()
			{
				base[this.v_AbnObjRazreshDataTable_0.busLowColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_50()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.rubilnikColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_51()
			{
				base[this.v_AbnObjRazreshDataTable_0.rubilnikColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_52()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.PowerColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_53()
			{
				base[this.v_AbnObjRazreshDataTable_0.PowerColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_54()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.id_razrColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_55()
			{
				base[this.v_AbnObjRazreshDataTable_0.id_razrColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_56()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.ContactColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_57()
			{
				base[this.v_AbnObjRazreshDataTable_0.ContactColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_58()
			{
				return base.IsNull(this.v_AbnObjRazreshDataTable_0.tpNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_59()
			{
				base[this.v_AbnObjRazreshDataTable_0.tpNameColumn] = Convert.DBNull;
			}

			private DataSetScheme.v_AbnObjRazreshDataTable v_AbnObjRazreshDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tAbnContactDataTable : TypedTableBase<DataSetScheme.Class68>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tAbnContactDataTable()
			{
				base.TableName = "tAbnContact";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tAbnContactDataTable(DataTable dataTable_0)
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
			protected tAbnContactDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn idAbnColumn
			{
				get
				{
					return this.columnidAbn;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn FColumn
			{
				get
				{
					return this.columnF;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IColumn
			{
				get
				{
					return this.columnI;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn OColumn
			{
				get
				{
					return this.columnO;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PostColumn
			{
				get
				{
					return this.columnPost;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PhoneColumn
			{
				get
				{
					return this.columnPhone;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DateChangeColumn
			{
				get
				{
					return this.columnDateChange;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CommentColumn
			{
				get
				{
					return this.columnComment;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn emailColumn
			{
				get
				{
					return this.columnemail;
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
			public DataSetScheme.Class68 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class68)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate25 tAbnContactRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate25 tAbnContactRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate25 tAbnContactRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate25 tAbnContactRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class68 class68_0)
			{
				base.Rows.Add(class68_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class68 method_1(int int_0, string string_0, string string_1, string string_2, string string_3, string string_4, DateTime dateTime_0, string string_5, string string_6)
			{
				DataSetScheme.Class68 @class = (DataSetScheme.Class68)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					int_0,
					string_0,
					string_1,
					string_2,
					string_3,
					string_4,
					dateTime_0,
					string_5,
					string_6
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class68 method_2(int int_0)
			{
				return (DataSetScheme.Class68)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.tAbnContactDataTable tAbnContactDataTable = (DataSetScheme.tAbnContactDataTable)base.Clone();
				tAbnContactDataTable.method_3();
				return tAbnContactDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tAbnContactDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnidAbn = base.Columns["idAbn"];
				this.columnF = base.Columns["F"];
				this.columnI = base.Columns["I"];
				this.columnO = base.Columns["O"];
				this.columnPost = base.Columns["Post"];
				this.columnPhone = base.Columns["Phone"];
				this.columnDateChange = base.Columns["DateChange"];
				this.columnComment = base.Columns["Comment"];
				this.columnemail = base.Columns["email"];
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidAbn);
				this.columnF = new DataColumn("F", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnF);
				this.columnI = new DataColumn("I", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnI);
				this.columnO = new DataColumn("O", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnO);
				this.columnPost = new DataColumn("Post", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPost);
				this.columnPhone = new DataColumn("Phone", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnPhone);
				this.columnDateChange = new DataColumn("DateChange", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateChange);
				this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnComment);
				this.columnemail = new DataColumn("email", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnemail);
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
				this.columnidAbn.AllowDBNull = false;
				this.columnF.MaxLength = 70;
				this.columnI.MaxLength = 70;
				this.columnO.MaxLength = 70;
				this.columnPost.MaxLength = 100;
				this.columnPhone.MaxLength = 100;
				this.columnComment.MaxLength = 500;
				this.columnemail.MaxLength = 100;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class68 method_5()
			{
				return (DataSetScheme.Class68)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class68(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class68);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tAbnContactRowChanged != null)
				{
					this.tAbnContactRowChanged(this, new DataSetScheme.EventArgs23((DataSetScheme.Class68)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tAbnContactRowChanging != null)
				{
					this.tAbnContactRowChanging(this, new DataSetScheme.EventArgs23((DataSetScheme.Class68)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tAbnContactRowDeleted != null)
				{
					this.tAbnContactRowDeleted(this, new DataSetScheme.EventArgs23((DataSetScheme.Class68)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tAbnContactRowDeleting != null)
				{
					this.tAbnContactRowDeleting(this, new DataSetScheme.EventArgs23((DataSetScheme.Class68)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_6(DataSetScheme.Class68 class68_0)
			{
				base.Rows.Remove(class68_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tAbnContactDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnidAbn;

			private DataColumn columnF;

			private DataColumn columnI;

			private DataColumn columnO;

			private DataColumn columnPost;

			private DataColumn columnPhone;

			private DataColumn columnDateChange;

			private DataColumn columnComment;

			private DataColumn columnemail;
		}

		public class Class68 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class68(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tAbnContactDataTable_0 = (DataSetScheme.tAbnContactDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tAbnContactDataTable_0.idColumn];
				}
				set
				{
					base[this.tAbnContactDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.tAbnContactDataTable_0.idAbnColumn];
			}

			public void method_1(int int_0)
			{
				base[this.tAbnContactDataTable_0.idAbnColumn] = int_0;
			}

			public string method_2()
			{
				string result;
				try
				{
					result = (string)base[this.tAbnContactDataTable_0.FColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'F' in table 'tAbnContact' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(string value)
			{
				base[this.tAbnContactDataTable_0.FColumn] = value;
			}

			public string method_4()
			{
				string result;
				try
				{
					result = (string)base[this.tAbnContactDataTable_0.IColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'I' in table 'tAbnContact' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(string value)
			{
				base[this.tAbnContactDataTable_0.IColumn] = value;
			}

			public string method_6()
			{
				string result;
				try
				{
					result = (string)base[this.tAbnContactDataTable_0.OColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'O' in table 'tAbnContact' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(string value)
			{
				base[this.tAbnContactDataTable_0.OColumn] = value;
			}

			public string method_8()
			{
				string result;
				try
				{
					result = (string)base[this.tAbnContactDataTable_0.PostColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Post' in table 'tAbnContact' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(string value)
			{
				base[this.tAbnContactDataTable_0.PostColumn] = value;
			}

			public string method_10()
			{
				string result;
				try
				{
					result = (string)base[this.tAbnContactDataTable_0.PhoneColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Phone' in table 'tAbnContact' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(string value)
			{
				base[this.tAbnContactDataTable_0.PhoneColumn] = value;
			}

			public DateTime method_12()
			{
				DateTime result;
				try
				{
					result = (DateTime)base[this.tAbnContactDataTable_0.DateChangeColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateChange' in table 'tAbnContact' is DBNull.", innerException);
				}
				return result;
			}

			public void method_13(DateTime dateTime_0)
			{
				base[this.tAbnContactDataTable_0.DateChangeColumn] = dateTime_0;
			}

			public string method_14()
			{
				string result;
				try
				{
					result = (string)base[this.tAbnContactDataTable_0.CommentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Comment' in table 'tAbnContact' is DBNull.", innerException);
				}
				return result;
			}

			public void method_15(string value)
			{
				base[this.tAbnContactDataTable_0.CommentColumn] = value;
			}

			public string method_16()
			{
				string result;
				try
				{
					result = (string)base[this.tAbnContactDataTable_0.emailColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'email' in table 'tAbnContact' is DBNull.", innerException);
				}
				return result;
			}

			public void method_17(string value)
			{
				base[this.tAbnContactDataTable_0.emailColumn] = value;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_18()
			{
				return base.IsNull(this.tAbnContactDataTable_0.FColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_19()
			{
				base[this.tAbnContactDataTable_0.FColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_20()
			{
				return base.IsNull(this.tAbnContactDataTable_0.IColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.tAbnContactDataTable_0.IColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_22()
			{
				return base.IsNull(this.tAbnContactDataTable_0.OColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_23()
			{
				base[this.tAbnContactDataTable_0.OColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_24()
			{
				return base.IsNull(this.tAbnContactDataTable_0.PostColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_25()
			{
				base[this.tAbnContactDataTable_0.PostColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_26()
			{
				return base.IsNull(this.tAbnContactDataTable_0.PhoneColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_27()
			{
				base[this.tAbnContactDataTable_0.PhoneColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_28()
			{
				return base.IsNull(this.tAbnContactDataTable_0.DateChangeColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_29()
			{
				base[this.tAbnContactDataTable_0.DateChangeColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_30()
			{
				return base.IsNull(this.tAbnContactDataTable_0.CommentColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_31()
			{
				base[this.tAbnContactDataTable_0.CommentColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_32()
			{
				return base.IsNull(this.tAbnContactDataTable_0.emailColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_33()
			{
				base[this.tAbnContactDataTable_0.emailColumn] = Convert.DBNull;
			}

			private DataSetScheme.tAbnContactDataTable tAbnContactDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSchm_ObjFileDataTable : TypedTableBase<DataSetScheme.Class69>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tSchm_ObjFileDataTable()
			{
				base.TableName = "tSchm_ObjFile";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal tSchm_ObjFileDataTable(DataTable dataTable_0)
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
			protected tSchm_ObjFileDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn idObjColumn
			{
				get
				{
					return this.columnidObj;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DocumentColumn
			{
				get
				{
					return this.columnDocument;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn FileNameColumn
			{
				get
				{
					return this.columnFileName;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DateInColumn
			{
				get
				{
					return this.columnDateIn;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CommentColumn
			{
				get
				{
					return this.columnComment;
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
			public DataSetScheme.Class69 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class69)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate26 tSchm_ObjFileRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate26 tSchm_ObjFileRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate26 tSchm_ObjFileRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate26 tSchm_ObjFileRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(DataSetScheme.Class69 class69_0)
			{
				base.Rows.Add(class69_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class69 method_1(int int_0, byte[] byte_0, string string_0, DateTime dateTime_0, string string_1)
			{
				DataSetScheme.Class69 @class = (DataSetScheme.Class69)base.NewRow();
				object[] itemArray = new object[]
				{
					null,
					int_0,
					byte_0,
					string_0,
					dateTime_0,
					string_1
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class69 method_2(int int_0)
			{
				return (DataSetScheme.Class69)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.tSchm_ObjFileDataTable tSchm_ObjFileDataTable = (DataSetScheme.tSchm_ObjFileDataTable)base.Clone();
				tSchm_ObjFileDataTable.method_3();
				return tSchm_ObjFileDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tSchm_ObjFileDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnidObj = base.Columns["idObj"];
				this.columnDocument = base.Columns["Document"];
				this.columnFileName = base.Columns["FileName"];
				this.columnDateIn = base.Columns["DateIn"];
				this.columnComment = base.Columns["Comment"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidObj = new DataColumn("idObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidObj);
				this.columnDocument = new DataColumn("Document", typeof(byte[]), null, MappingType.Element);
				base.Columns.Add(this.columnDocument);
				this.columnFileName = new DataColumn("FileName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnFileName);
				this.columnDateIn = new DataColumn("DateIn", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnDateIn);
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
				this.columnid.Unique = true;
				this.columnidObj.AutoIncrementSeed = -1L;
				this.columnidObj.AutoIncrementStep = -1L;
				this.columnidObj.AllowDBNull = false;
				this.columnidObj.ReadOnly = true;
				this.columnDocument.AllowDBNull = false;
				this.columnFileName.AllowDBNull = false;
				this.columnFileName.MaxLength = 1024;
				this.columnDateIn.AllowDBNull = false;
				this.columnComment.MaxLength = 1024;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class69 method_5()
			{
				return (DataSetScheme.Class69)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class69(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class69);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tSchm_ObjFileRowChanged != null)
				{
					this.tSchm_ObjFileRowChanged(this, new DataSetScheme.EventArgs24((DataSetScheme.Class69)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tSchm_ObjFileRowChanging != null)
				{
					this.tSchm_ObjFileRowChanging(this, new DataSetScheme.EventArgs24((DataSetScheme.Class69)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tSchm_ObjFileRowDeleted != null)
				{
					this.tSchm_ObjFileRowDeleted(this, new DataSetScheme.EventArgs24((DataSetScheme.Class69)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tSchm_ObjFileRowDeleting != null)
				{
					this.tSchm_ObjFileRowDeleting(this, new DataSetScheme.EventArgs24((DataSetScheme.Class69)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_6(DataSetScheme.Class69 class69_0)
			{
				base.Rows.Remove(class69_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSchm_ObjFileDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnidObj;

			private DataColumn columnDocument;

			private DataColumn columnFileName;

			private DataColumn columnDateIn;

			private DataColumn columnComment;
		}

		public class Class69 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class69(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tSchm_ObjFileDataTable_0 = (DataSetScheme.tSchm_ObjFileDataTable)base.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tSchm_ObjFileDataTable_0.idColumn];
				}
				set
				{
					base[this.tSchm_ObjFileDataTable_0.idColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.tSchm_ObjFileDataTable_0.idObjColumn];
			}

			public void method_1(int int_0)
			{
				base[this.tSchm_ObjFileDataTable_0.idObjColumn] = int_0;
			}

			public byte[] method_2()
			{
				return (byte[])base[this.tSchm_ObjFileDataTable_0.DocumentColumn];
			}

			public void method_3(byte[] byte_0)
			{
				base[this.tSchm_ObjFileDataTable_0.DocumentColumn] = byte_0;
			}

			public string method_4()
			{
				return (string)base[this.tSchm_ObjFileDataTable_0.FileNameColumn];
			}

			public void method_5(string value)
			{
				base[this.tSchm_ObjFileDataTable_0.FileNameColumn] = value;
			}

			public DateTime method_6()
			{
				return (DateTime)base[this.tSchm_ObjFileDataTable_0.DateInColumn];
			}

			public void method_7(DateTime dateTime_0)
			{
				base[this.tSchm_ObjFileDataTable_0.DateInColumn] = dateTime_0;
			}

			public string method_8()
			{
				string result;
				try
				{
					result = (string)base[this.tSchm_ObjFileDataTable_0.CommentColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Comment' in table 'tSchm_ObjFile' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(string value)
			{
				base[this.tSchm_ObjFileDataTable_0.CommentColumn] = value;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_10()
			{
				return base.IsNull(this.tSchm_ObjFileDataTable_0.CommentColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_11()
			{
				base[this.tSchm_ObjFileDataTable_0.CommentColumn] = Convert.DBNull;
			}

			private DataSetScheme.tSchm_ObjFileDataTable tSchm_ObjFileDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vL_SchmAbnFullDataTable : TypedTableBase<DataSetScheme.Class70>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public vL_SchmAbnFullDataTable()
			{
				base.TableName = "vL_SchmAbnFull";
				this.BeginInit();
				this.method_3();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal vL_SchmAbnFullDataTable(DataTable dataTable_0)
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
			protected vL_SchmAbnFullDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_2();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idAbnColumn
			{
				get
				{
					return this.columnidAbn;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn codeAbonentColumn
			{
				get
				{
					return this.columncodeAbonent;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn nameAbnColumn
			{
				get
				{
					return this.columnnameAbn;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn typeAbnColumn
			{
				get
				{
					return this.columntypeAbn;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn aBnActiveColumn
			{
				get
				{
					return this.columnaBnActive;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idAbnObjColumn
			{
				get
				{
					return this.columnidAbnObj;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn nameObjColumn
			{
				get
				{
					return this.columnnameObj;
				}
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
			public DataColumn streetnameColumn
			{
				get
				{
					return this.columnstreetname;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn houseColumn
			{
				get
				{
					return this.columnhouse;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn objActiveColumn
			{
				get
				{
					return this.columnobjActive;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CategoryNameColumn
			{
				get
				{
					return this.columnCategoryName;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn TarifNameColumn
			{
				get
				{
					return this.columnTarifName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PowerSetColumn
			{
				get
				{
					return this.columnPowerSet;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn PowerFactColumn
			{
				get
				{
					return this.columnPowerFact;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn contactColumn
			{
				get
				{
					return this.columncontact;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn AbnNetColumn
			{
				get
				{
					return this.columnAbnNet;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn abnServicingColumn
			{
				get
				{
					return this.columnabnServicing;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idSchmObjColumn
			{
				get
				{
					return this.columnidSchmObj;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn cellIdColumn
			{
				get
				{
					return this.columncellId;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn CellNameColumn
			{
				get
				{
					return this.columnCellName;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn busidColumn
			{
				get
				{
					return this.columnbusid;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn busnameColumn
			{
				get
				{
					return this.columnbusname;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn subidColumn
			{
				get
				{
					return this.columnsubid;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn subnameColumn
			{
				get
				{
					return this.columnsubname;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn schmObjNameColumn
			{
				get
				{
					return this.columnschmObjName;
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
			public DataSetScheme.Class70 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class70)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate27 vL_SchmAbnFullRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate27 vL_SchmAbnFullRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate27 vL_SchmAbnFullRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate27 vL_SchmAbnFullRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(DataSetScheme.Class70 class70_0)
			{
				base.Rows.Add(class70_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class70 method_1(int int_0, int int_1, string string_0, int int_2, bool bool_0, int int_3, string string_1, int int_4, string string_2, string string_3, int int_5, string string_4, string string_5, double double_0, double double_1, string string_6, string string_7, string string_8, int int_6, int int_7, string string_9, int int_8, string string_10, int int_9, string string_11, string string_12)
			{
				DataSetScheme.Class70 @class = (DataSetScheme.Class70)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
					int_1,
					string_0,
					int_2,
					bool_0,
					int_3,
					string_1,
					int_4,
					string_2,
					string_3,
					int_5,
					string_4,
					string_5,
					double_0,
					double_1,
					string_6,
					string_7,
					string_8,
					int_6,
					int_7,
					string_9,
					int_8,
					string_10,
					int_9,
					string_11,
					string_12
				};
				@class.ItemArray = itemArray;
				base.Rows.Add(@class);
				return @class;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.vL_SchmAbnFullDataTable vL_SchmAbnFullDataTable = (DataSetScheme.vL_SchmAbnFullDataTable)base.Clone();
				vL_SchmAbnFullDataTable.method_2();
				return vL_SchmAbnFullDataTable;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.vL_SchmAbnFullDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void method_2()
			{
				this.columnidAbn = base.Columns["idAbn"];
				this.columncodeAbonent = base.Columns["codeAbonent"];
				this.columnnameAbn = base.Columns["nameAbn"];
				this.columntypeAbn = base.Columns["typeAbn"];
				this.columnaBnActive = base.Columns["aBnActive"];
				this.columnidAbnObj = base.Columns["idAbnObj"];
				this.columnnameObj = base.Columns["nameObj"];
				this.columnid = base.Columns["id"];
				this.columnstreetname = base.Columns["streetname"];
				this.columnhouse = base.Columns["house"];
				this.columnobjActive = base.Columns["objActive"];
				this.columnCategoryName = base.Columns["CategoryName"];
				this.columnTarifName = base.Columns["TarifName"];
				this.columnPowerSet = base.Columns["PowerSet"];
				this.columnPowerFact = base.Columns["PowerFact"];
				this.columncontact = base.Columns["contact"];
				this.columnAbnNet = base.Columns["AbnNet"];
				this.columnabnServicing = base.Columns["abnServicing"];
				this.columnidSchmObj = base.Columns["idSchmObj"];
				this.columncellId = base.Columns["cellId"];
				this.columnCellName = base.Columns["CellName"];
				this.columnbusid = base.Columns["busid"];
				this.columnbusname = base.Columns["busname"];
				this.columnsubid = base.Columns["subid"];
				this.columnsubname = base.Columns["subname"];
				this.columnschmObjName = base.Columns["schmObjName"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_3()
			{
				this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidAbn);
				this.columncodeAbonent = new DataColumn("codeAbonent", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columncodeAbonent);
				this.columnnameAbn = new DataColumn("nameAbn", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnnameAbn);
				this.columntypeAbn = new DataColumn("typeAbn", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columntypeAbn);
				this.columnaBnActive = new DataColumn("aBnActive", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnaBnActive);
				this.columnidAbnObj = new DataColumn("idAbnObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidAbnObj);
				this.columnnameObj = new DataColumn("nameObj", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnnameObj);
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnstreetname = new DataColumn("streetname", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnstreetname);
				this.columnhouse = new DataColumn("house", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnhouse);
				this.columnobjActive = new DataColumn("objActive", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnobjActive);
				this.columnCategoryName = new DataColumn("CategoryName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCategoryName);
				this.columnTarifName = new DataColumn("TarifName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnTarifName);
				this.columnPowerSet = new DataColumn("PowerSet", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columnPowerSet);
				this.columnPowerFact = new DataColumn("PowerFact", typeof(double), null, MappingType.Element);
				base.Columns.Add(this.columnPowerFact);
				this.columncontact = new DataColumn("contact", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columncontact);
				this.columnAbnNet = new DataColumn("AbnNet", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnAbnNet);
				this.columnabnServicing = new DataColumn("abnServicing", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnabnServicing);
				this.columnidSchmObj = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidSchmObj);
				this.columncellId = new DataColumn("cellId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columncellId);
				this.columnCellName = new DataColumn("CellName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCellName);
				this.columnbusid = new DataColumn("busid", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnbusid);
				this.columnbusname = new DataColumn("busname", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnbusname);
				this.columnsubid = new DataColumn("subid", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnsubid);
				this.columnsubname = new DataColumn("subname", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnsubname);
				this.columnschmObjName = new DataColumn("schmObjName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnschmObjName);
				this.columnidAbn.AllowDBNull = false;
				this.columncodeAbonent.AllowDBNull = false;
				this.columnnameAbn.MaxLength = 100;
				this.columntypeAbn.AllowDBNull = false;
				this.columnnameObj.MaxLength = 385;
				this.columnstreetname.MaxLength = 91;
				this.columnhouse.MaxLength = 30;
				this.columnCategoryName.MaxLength = 100;
				this.columnTarifName.MaxLength = 100;
				this.columncontact.MaxLength = int.MaxValue;
				this.columnCellName.MaxLength = 563;
				this.columnbusname.MaxLength = 563;
				this.columnsubname.MaxLength = 563;
				this.columnschmObjName.MaxLength = 1691;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class70 method_4()
			{
				return (DataSetScheme.Class70)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class70(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class70);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vL_SchmAbnFullRowChanged != null)
				{
					this.vL_SchmAbnFullRowChanged(this, new DataSetScheme.EventArgs25((DataSetScheme.Class70)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vL_SchmAbnFullRowChanging != null)
				{
					this.vL_SchmAbnFullRowChanging(this, new DataSetScheme.EventArgs25((DataSetScheme.Class70)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vL_SchmAbnFullRowDeleted != null)
				{
					this.vL_SchmAbnFullRowDeleted(this, new DataSetScheme.EventArgs25((DataSetScheme.Class70)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vL_SchmAbnFullRowDeleting != null)
				{
					this.vL_SchmAbnFullRowDeleting(this, new DataSetScheme.EventArgs25((DataSetScheme.Class70)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_5(DataSetScheme.Class70 class70_0)
			{
				base.Rows.Remove(class70_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vL_SchmAbnFullDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnidAbn;

			private DataColumn columncodeAbonent;

			private DataColumn columnnameAbn;

			private DataColumn columntypeAbn;

			private DataColumn columnaBnActive;

			private DataColumn columnidAbnObj;

			private DataColumn columnnameObj;

			private DataColumn columnid;

			private DataColumn columnstreetname;

			private DataColumn columnhouse;

			private DataColumn columnobjActive;

			private DataColumn columnCategoryName;

			private DataColumn columnTarifName;

			private DataColumn columnPowerSet;

			private DataColumn columnPowerFact;

			private DataColumn columncontact;

			private DataColumn columnAbnNet;

			private DataColumn columnabnServicing;

			private DataColumn columnidSchmObj;

			private DataColumn columncellId;

			private DataColumn columnCellName;

			private DataColumn columnbusid;

			private DataColumn columnbusname;

			private DataColumn columnsubid;

			private DataColumn columnsubname;

			private DataColumn columnschmObjName;
		}

		public class Class70 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class70(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vL_SchmAbnFullDataTable_0 = (DataSetScheme.vL_SchmAbnFullDataTable)base.Table;
			}

			public int method_0()
			{
				return (int)base[this.vL_SchmAbnFullDataTable_0.idAbnColumn];
			}

			public void method_1(int int_0)
			{
				base[this.vL_SchmAbnFullDataTable_0.idAbnColumn] = int_0;
			}

			public int method_2()
			{
				return (int)base[this.vL_SchmAbnFullDataTable_0.codeAbonentColumn];
			}

			public void method_3(int int_0)
			{
				base[this.vL_SchmAbnFullDataTable_0.codeAbonentColumn] = int_0;
			}

			public string method_4()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.nameAbnColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'nameAbn' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.nameAbnColumn] = value;
			}

			public int method_6()
			{
				return (int)base[this.vL_SchmAbnFullDataTable_0.typeAbnColumn];
			}

			public void method_7(int int_0)
			{
				base[this.vL_SchmAbnFullDataTable_0.typeAbnColumn] = int_0;
			}

			public bool method_8()
			{
				bool result;
				try
				{
					result = (bool)base[this.vL_SchmAbnFullDataTable_0.aBnActiveColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'aBnActive' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(bool bool_0)
			{
				base[this.vL_SchmAbnFullDataTable_0.aBnActiveColumn] = bool_0;
			}

			public int method_10()
			{
				int result;
				try
				{
					result = (int)base[this.vL_SchmAbnFullDataTable_0.idAbnObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'idAbnObj' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(int int_0)
			{
				base[this.vL_SchmAbnFullDataTable_0.idAbnObjColumn] = int_0;
			}

			public string method_12()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.nameObjColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'nameObj' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_13(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.nameObjColumn] = value;
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
						result = (int)base[this.vL_SchmAbnFullDataTable_0.idColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'id' in table 'vL_SchmAbnFull' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vL_SchmAbnFullDataTable_0.idColumn] = value;
				}
			}

			public string method_14()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.streetnameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'streetname' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_15(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.streetnameColumn] = value;
			}

			public string method_16()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.houseColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'house' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_17(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.houseColumn] = value;
			}

			public int method_18()
			{
				int result;
				try
				{
					result = (int)base[this.vL_SchmAbnFullDataTable_0.objActiveColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'objActive' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_19(int int_0)
			{
				base[this.vL_SchmAbnFullDataTable_0.objActiveColumn] = int_0;
			}

			public string method_20()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.CategoryNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CategoryName' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_21(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.CategoryNameColumn] = value;
			}

			public string method_22()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.TarifNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TarifName' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_23(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.TarifNameColumn] = value;
			}

			public double method_24()
			{
				double result;
				try
				{
					result = (double)base[this.vL_SchmAbnFullDataTable_0.PowerSetColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PowerSet' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_25(double double_0)
			{
				base[this.vL_SchmAbnFullDataTable_0.PowerSetColumn] = double_0;
			}

			public double method_26()
			{
				double result;
				try
				{
					result = (double)base[this.vL_SchmAbnFullDataTable_0.PowerFactColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'PowerFact' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_27(double double_0)
			{
				base[this.vL_SchmAbnFullDataTable_0.PowerFactColumn] = double_0;
			}

			public string method_28()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.contactColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'contact' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_29(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.contactColumn] = value;
			}

			public string method_30()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.AbnNetColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'AbnNet' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_31(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.AbnNetColumn] = value;
			}

			public string method_32()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.abnServicingColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'abnServicing' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_33(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.abnServicingColumn] = value;
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
						result = (int)base[this.vL_SchmAbnFullDataTable_0.idSchmObjColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'idSchmObj' in table 'vL_SchmAbnFull' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vL_SchmAbnFullDataTable_0.idSchmObjColumn] = value;
				}
			}

			public int method_34()
			{
				int result;
				try
				{
					result = (int)base[this.vL_SchmAbnFullDataTable_0.cellIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'cellId' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_35(int int_0)
			{
				base[this.vL_SchmAbnFullDataTable_0.cellIdColumn] = int_0;
			}

			public string method_36()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.CellNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CellName' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_37(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.CellNameColumn] = value;
			}

			public int method_38()
			{
				int result;
				try
				{
					result = (int)base[this.vL_SchmAbnFullDataTable_0.busidColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'busid' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_39(int int_0)
			{
				base[this.vL_SchmAbnFullDataTable_0.busidColumn] = int_0;
			}

			public string method_40()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.busnameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'busname' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_41(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.busnameColumn] = value;
			}

			public int method_42()
			{
				int result;
				try
				{
					result = (int)base[this.vL_SchmAbnFullDataTable_0.subidColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'subid' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_43(int int_0)
			{
				base[this.vL_SchmAbnFullDataTable_0.subidColumn] = int_0;
			}

			public string method_44()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.subnameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'subname' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_45(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.subnameColumn] = value;
			}

			public string method_46()
			{
				string result;
				try
				{
					result = (string)base[this.vL_SchmAbnFullDataTable_0.schmObjNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'schmObjName' in table 'vL_SchmAbnFull' is DBNull.", innerException);
				}
				return result;
			}

			public void method_47(string value)
			{
				base[this.vL_SchmAbnFullDataTable_0.schmObjNameColumn] = value;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_48()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.nameAbnColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_49()
			{
				base[this.vL_SchmAbnFullDataTable_0.nameAbnColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_50()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.aBnActiveColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_51()
			{
				base[this.vL_SchmAbnFullDataTable_0.aBnActiveColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_52()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.idAbnObjColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_53()
			{
				base[this.vL_SchmAbnFullDataTable_0.idAbnObjColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_54()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.nameObjColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_55()
			{
				base[this.vL_SchmAbnFullDataTable_0.nameObjColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_56()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.idColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_57()
			{
				base[this.vL_SchmAbnFullDataTable_0.idColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_58()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.streetnameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_59()
			{
				base[this.vL_SchmAbnFullDataTable_0.streetnameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_60()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.houseColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_61()
			{
				base[this.vL_SchmAbnFullDataTable_0.houseColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_62()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.objActiveColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_63()
			{
				base[this.vL_SchmAbnFullDataTable_0.objActiveColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_64()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.CategoryNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_65()
			{
				base[this.vL_SchmAbnFullDataTable_0.CategoryNameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_66()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.TarifNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_67()
			{
				base[this.vL_SchmAbnFullDataTable_0.TarifNameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_68()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.PowerSetColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_69()
			{
				base[this.vL_SchmAbnFullDataTable_0.PowerSetColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_70()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.PowerFactColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_71()
			{
				base[this.vL_SchmAbnFullDataTable_0.PowerFactColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_72()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.contactColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_73()
			{
				base[this.vL_SchmAbnFullDataTable_0.contactColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_74()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.AbnNetColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_75()
			{
				base[this.vL_SchmAbnFullDataTable_0.AbnNetColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_76()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.abnServicingColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_77()
			{
				base[this.vL_SchmAbnFullDataTable_0.abnServicingColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_78()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.idSchmObjColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_79()
			{
				base[this.vL_SchmAbnFullDataTable_0.idSchmObjColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_80()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.cellIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_81()
			{
				base[this.vL_SchmAbnFullDataTable_0.cellIdColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_82()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.CellNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_83()
			{
				base[this.vL_SchmAbnFullDataTable_0.CellNameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_84()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.busidColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_85()
			{
				base[this.vL_SchmAbnFullDataTable_0.busidColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_86()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.busnameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_87()
			{
				base[this.vL_SchmAbnFullDataTable_0.busnameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_88()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.subidColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_89()
			{
				base[this.vL_SchmAbnFullDataTable_0.subidColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_90()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.subnameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_91()
			{
				base[this.vL_SchmAbnFullDataTable_0.subnameColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_92()
			{
				return base.IsNull(this.vL_SchmAbnFullDataTable_0.schmObjNameColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_93()
			{
				base[this.vL_SchmAbnFullDataTable_0.schmObjNameColumn] = Convert.DBNull;
			}

			private DataSetScheme.vL_SchmAbnFullDataTable vL_SchmAbnFullDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class vP_PassportDataReportsDataTable : TypedTableBase<DataSetScheme.Class71>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public vP_PassportDataReportsDataTable()
			{
				base.TableName = "vP_PassportDataReports";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal vP_PassportDataReportsDataTable(DataTable dataTable_0)
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
			protected vP_PassportDataReportsDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IdObjColumn
			{
				get
				{
					return this.columnIdObj;
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
			public DataColumn CharNameColumn
			{
				get
				{
					return this.columnCharName;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn CharValueColumn
			{
				get
				{
					return this.columnCharValue;
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
			public DataSetScheme.Class71 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class71)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate28 vP_PassportDataReportsRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate28 vP_PassportDataReportsRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate28 vP_PassportDataReportsRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate28 vP_PassportDataReportsRowDeleted;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_0(DataSetScheme.Class71 class71_0)
			{
				base.Rows.Add(class71_0);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class71 method_1(int int_0, string string_0, int int_1, string string_1, string string_2, string string_3, string string_4)
			{
				DataSetScheme.Class71 @class = (DataSetScheme.Class71)base.NewRow();
				object[] itemArray = new object[]
				{
					int_0,
					string_0,
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

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class71 method_2(int int_0)
			{
				return (DataSetScheme.Class71)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				DataSetScheme.vP_PassportDataReportsDataTable vP_PassportDataReportsDataTable = (DataSetScheme.vP_PassportDataReportsDataTable)base.Clone();
				vP_PassportDataReportsDataTable.method_3();
				return vP_PassportDataReportsDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.vP_PassportDataReportsDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnIdObj = base.Columns["IdObj"];
				this.columnName = base.Columns["Name"];
				this.columnTypeCodeId = base.Columns["TypeCodeId"];
				this.columnParentKey = base.Columns["ParentKey"];
				this.columnDate = base.Columns["Date"];
				this.columnCharName = base.Columns["CharName"];
				this.columnCharValue = base.Columns["CharValue"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_4()
			{
				this.columnIdObj = new DataColumn("IdObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnIdObj);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnTypeCodeId = new DataColumn("TypeCodeId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTypeCodeId);
				this.columnParentKey = new DataColumn("ParentKey", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnParentKey);
				this.columnDate = new DataColumn("Date", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDate);
				this.columnCharName = new DataColumn("CharName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCharName);
				this.columnCharValue = new DataColumn("CharValue", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnCharValue);
				base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[]
				{
					this.columnIdObj
				}, true));
				this.columnIdObj.AllowDBNull = false;
				this.columnIdObj.Unique = true;
				this.columnName.ReadOnly = true;
				this.columnName.MaxLength = 565;
				this.columnParentKey.MaxLength = 50;
				this.columnDate.ReadOnly = true;
				this.columnDate.MaxLength = 10;
				this.columnCharName.MaxLength = 50;
				this.columnCharValue.ReadOnly = true;
				this.columnCharValue.MaxLength = 512;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataSetScheme.Class71 method_5()
			{
				return (DataSetScheme.Class71)base.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class71(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class71);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.vP_PassportDataReportsRowChanged != null)
				{
					this.vP_PassportDataReportsRowChanged(this, new DataSetScheme.EventArgs26((DataSetScheme.Class71)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.vP_PassportDataReportsRowChanging != null)
				{
					this.vP_PassportDataReportsRowChanging(this, new DataSetScheme.EventArgs26((DataSetScheme.Class71)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.vP_PassportDataReportsRowDeleted != null)
				{
					this.vP_PassportDataReportsRowDeleted(this, new DataSetScheme.EventArgs26((DataSetScheme.Class71)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.vP_PassportDataReportsRowDeleting != null)
				{
					this.vP_PassportDataReportsRowDeleting(this, new DataSetScheme.EventArgs26((DataSetScheme.Class71)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_6(DataSetScheme.Class71 class71_0)
			{
				base.Rows.Remove(class71_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "vP_PassportDataReportsDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnIdObj;

			private DataColumn columnName;

			private DataColumn columnTypeCodeId;

			private DataColumn columnParentKey;

			private DataColumn columnDate;

			private DataColumn columnCharName;

			private DataColumn columnCharValue;
		}

		public class Class71 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class71(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.vP_PassportDataReportsDataTable_0 = (DataSetScheme.vP_PassportDataReportsDataTable)base.Table;
			}

			public int method_0()
			{
				return (int)base[this.vP_PassportDataReportsDataTable_0.IdObjColumn];
			}

			public void method_1(int int_0)
			{
				base[this.vP_PassportDataReportsDataTable_0.IdObjColumn] = int_0;
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
						result = (string)base[this.vP_PassportDataReportsDataTable_0.NameColumn];
					}
					catch (InvalidCastException innerException)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'vP_PassportDataReports' is DBNull.", innerException);
					}
					return result;
				}
				set
				{
					base[this.vP_PassportDataReportsDataTable_0.NameColumn] = value;
				}
			}

			public int method_2()
			{
				int result;
				try
				{
					result = (int)base[this.vP_PassportDataReportsDataTable_0.TypeCodeIdColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TypeCodeId' in table 'vP_PassportDataReports' is DBNull.", innerException);
				}
				return result;
			}

			public void method_3(int int_0)
			{
				base[this.vP_PassportDataReportsDataTable_0.TypeCodeIdColumn] = int_0;
			}

			public string method_4()
			{
				string result;
				try
				{
					result = (string)base[this.vP_PassportDataReportsDataTable_0.ParentKeyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ParentKey' in table 'vP_PassportDataReports' is DBNull.", innerException);
				}
				return result;
			}

			public void method_5(string value)
			{
				base[this.vP_PassportDataReportsDataTable_0.ParentKeyColumn] = value;
			}

			public string method_6()
			{
				string result;
				try
				{
					result = (string)base[this.vP_PassportDataReportsDataTable_0.DateColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'Date' in table 'vP_PassportDataReports' is DBNull.", innerException);
				}
				return result;
			}

			public void method_7(string value)
			{
				base[this.vP_PassportDataReportsDataTable_0.DateColumn] = value;
			}

			public string method_8()
			{
				string result;
				try
				{
					result = (string)base[this.vP_PassportDataReportsDataTable_0.CharNameColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CharName' in table 'vP_PassportDataReports' is DBNull.", innerException);
				}
				return result;
			}

			public void method_9(string value)
			{
				base[this.vP_PassportDataReportsDataTable_0.CharNameColumn] = value;
			}

			public string method_10()
			{
				string result;
				try
				{
					result = (string)base[this.vP_PassportDataReportsDataTable_0.CharValueColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'CharValue' in table 'vP_PassportDataReports' is DBNull.", innerException);
				}
				return result;
			}

			public void method_11(string value)
			{
				base[this.vP_PassportDataReportsDataTable_0.CharValueColumn] = value;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_12()
			{
				return base.IsNull(this.vP_PassportDataReportsDataTable_0.NameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_13()
			{
				base[this.vP_PassportDataReportsDataTable_0.NameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_14()
			{
				return base.IsNull(this.vP_PassportDataReportsDataTable_0.TypeCodeIdColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_15()
			{
				base[this.vP_PassportDataReportsDataTable_0.TypeCodeIdColumn] = Convert.DBNull;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool method_16()
			{
				return base.IsNull(this.vP_PassportDataReportsDataTable_0.ParentKeyColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_17()
			{
				base[this.vP_PassportDataReportsDataTable_0.ParentKeyColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_18()
			{
				return base.IsNull(this.vP_PassportDataReportsDataTable_0.DateColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_19()
			{
				base[this.vP_PassportDataReportsDataTable_0.DateColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_20()
			{
				return base.IsNull(this.vP_PassportDataReportsDataTable_0.CharNameColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_21()
			{
				base[this.vP_PassportDataReportsDataTable_0.CharNameColumn] = Convert.DBNull;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool method_22()
			{
				return base.IsNull(this.vP_PassportDataReportsDataTable_0.CharValueColumn);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_23()
			{
				base[this.vP_PassportDataReportsDataTable_0.CharValueColumn] = Convert.DBNull;
			}

			private DataSetScheme.vP_PassportDataReportsDataTable vP_PassportDataReportsDataTable_0;
		}

		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class tSchm_ErcloudDataTable : TypedTableBase<DataSetScheme.Class72>
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public tSchm_ErcloudDataTable()
			{
				base.TableName = "tSchm_Ercloud";
				this.BeginInit();
				this.method_4();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal tSchm_ErcloudDataTable(DataTable dataTable_0)
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
			protected tSchm_ErcloudDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
			{
				this.method_3();
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
			public DataColumn idSchmObjColumn
			{
				get
				{
					return this.columnidSchmObj;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn idErcloudObjColumn
			{
				get
				{
					return this.columnidErcloudObj;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn idConnectColumn
			{
				get
				{
					return this.columnidConnect;
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
			public DataSetScheme.Class72 this[int int_0]
			{
				get
				{
					return (DataSetScheme.Class72)base.Rows[int_0];
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate29 tSchm_ErcloudRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate29 tSchm_ErcloudRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate29 tSchm_ErcloudRowDeleting;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event DataSetScheme.Delegate29 tSchm_ErcloudRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void method_0(DataSetScheme.Class72 class72_0)
			{
				base.Rows.Add(class72_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class72 method_1(int int_0, int int_1, int int_2)
			{
				DataSetScheme.Class72 @class = (DataSetScheme.Class72)base.NewRow();
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
			public DataSetScheme.Class72 method_2(int int_0)
			{
				return (DataSetScheme.Class72)base.Rows.Find(new object[]
				{
					int_0
				});
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				DataSetScheme.tSchm_ErcloudDataTable tSchm_ErcloudDataTable = (DataSetScheme.tSchm_ErcloudDataTable)base.Clone();
				tSchm_ErcloudDataTable.method_3();
				return tSchm_ErcloudDataTable;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new DataSetScheme.tSchm_ErcloudDataTable();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void method_3()
			{
				this.columnid = base.Columns["id"];
				this.columnidSchmObj = base.Columns["idSchmObj"];
				this.columnidErcloudObj = base.Columns["idErcloudObj"];
				this.columnidConnect = base.Columns["idConnect"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void method_4()
			{
				this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnid);
				this.columnidSchmObj = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidSchmObj);
				this.columnidErcloudObj = new DataColumn("idErcloudObj", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidErcloudObj);
				this.columnidConnect = new DataColumn("idConnect", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnidConnect);
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
				this.columnidSchmObj.AllowDBNull = false;
				this.columnidErcloudObj.AllowDBNull = false;
				this.columnidConnect.AllowDBNull = false;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataSetScheme.Class72 method_5()
			{
				return (DataSetScheme.Class72)base.NewRow();
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new DataSetScheme.Class72(builder);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(DataSetScheme.Class72);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanged(dataRowChangeEventArgs_0);
				if (this.tSchm_ErcloudRowChanged != null)
				{
					this.tSchm_ErcloudRowChanged(this, new DataSetScheme.EventArgs27((DataSetScheme.Class72)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowChanging(dataRowChangeEventArgs_0);
				if (this.tSchm_ErcloudRowChanging != null)
				{
					this.tSchm_ErcloudRowChanging(this, new DataSetScheme.EventArgs27((DataSetScheme.Class72)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleted(dataRowChangeEventArgs_0);
				if (this.tSchm_ErcloudRowDeleted != null)
				{
					this.tSchm_ErcloudRowDeleted(this, new DataSetScheme.EventArgs27((DataSetScheme.Class72)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
			{
				base.OnRowDeleting(dataRowChangeEventArgs_0);
				if (this.tSchm_ErcloudRowDeleting != null)
				{
					this.tSchm_ErcloudRowDeleting(this, new DataSetScheme.EventArgs27((DataSetScheme.Class72)dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void method_6(DataSetScheme.Class72 class72_0)
			{
				base.Rows.Remove(class72_0);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				DataSetScheme dataSetScheme = new DataSetScheme();
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
				xmlSchemaAttribute.FixedValue = dataSetScheme.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "tSchm_ErcloudDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = dataSetScheme.GetSchemaSerializable();
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

			private DataColumn columnid;

			private DataColumn columnidSchmObj;

			private DataColumn columnidErcloudObj;

			private DataColumn columnidConnect;
		}

		public class Class72 : DataRow
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal Class72(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
			{
				this.tSchm_ErcloudDataTable_0 = (DataSetScheme.tSchm_ErcloudDataTable)base.Table;
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int Int32_0
			{
				get
				{
					return (int)base[this.tSchm_ErcloudDataTable_0.idColumn];
				}
				set
				{
					base[this.tSchm_ErcloudDataTable_0.idColumn] = value;
				}
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int idSchmObj
			{
				get
				{
					return (int)base[this.tSchm_ErcloudDataTable_0.idSchmObjColumn];
				}
				set
				{
					base[this.tSchm_ErcloudDataTable_0.idSchmObjColumn] = value;
				}
			}

			public int method_0()
			{
				return (int)base[this.tSchm_ErcloudDataTable_0.idErcloudObjColumn];
			}

			public void method_1(int int_0)
			{
				base[this.tSchm_ErcloudDataTable_0.idErcloudObjColumn] = int_0;
			}

			public int method_2()
			{
				return (int)base[this.tSchm_ErcloudDataTable_0.idConnectColumn];
			}

			public void method_3(int int_0)
			{
				base[this.tSchm_ErcloudDataTable_0.idConnectColumn] = int_0;
			}

			private DataSetScheme.tSchm_ErcloudDataTable tSchm_ErcloudDataTable_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs0 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs0(DataSetScheme.Class45 class45_1, DataRowAction dataRowAction_1)
			{
				this.class45_0 = class45_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class45 method_0()
			{
				return this.class45_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class45 class45_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs1 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs1(DataSetScheme.Class46 class46_1, DataRowAction dataRowAction_1)
			{
				this.class46_0 = class46_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class46 method_0()
			{
				return this.class46_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class46 class46_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs2 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs2(DataSetScheme.Class47 class47_1, DataRowAction dataRowAction_1)
			{
				this.class47_0 = class47_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class47 method_0()
			{
				return this.class47_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class47 class47_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs3 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs3(DataSetScheme.Class48 class48_1, DataRowAction dataRowAction_1)
			{
				this.class48_0 = class48_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class48 method_0()
			{
				return this.class48_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class48 class48_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs4 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs4(DataSetScheme.Class49 class49_1, DataRowAction dataRowAction_1)
			{
				this.class49_0 = class49_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class49 method_0()
			{
				return this.class49_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class49 class49_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs5 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs5(DataSetScheme.Class50 class50_1, DataRowAction dataRowAction_1)
			{
				this.class50_0 = class50_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class50 method_0()
			{
				return this.class50_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class50 class50_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs6 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs6(DataSetScheme.Class51 class51_1, DataRowAction dataRowAction_1)
			{
				this.class51_0 = class51_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class51 method_0()
			{
				return this.class51_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class51 class51_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs7 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs7(DataSetScheme.Class52 class52_1, DataRowAction dataRowAction_1)
			{
				this.class52_0 = class52_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class52 method_0()
			{
				return this.class52_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class52 class52_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs8 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs8(DataSetScheme.Class53 class53_1, DataRowAction dataRowAction_1)
			{
				this.class53_0 = class53_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class53 method_0()
			{
				return this.class53_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class53 class53_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs9 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs9(DataSetScheme.Class54 class54_1, DataRowAction dataRowAction_1)
			{
				this.class54_0 = class54_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class54 method_0()
			{
				return this.class54_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class54 class54_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs10 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs10(DataSetScheme.Class55 class55_1, DataRowAction dataRowAction_1)
			{
				this.class55_0 = class55_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class55 method_0()
			{
				return this.class55_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class55 class55_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs11 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs11(DataSetScheme.Class56 class56_1, DataRowAction dataRowAction_1)
			{
				this.class56_0 = class56_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class56 method_0()
			{
				return this.class56_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class56 class56_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs12 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs12(DataSetScheme.Class57 class57_1, DataRowAction dataRowAction_1)
			{
				this.class57_0 = class57_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class57 method_0()
			{
				return this.class57_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class57 class57_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs13 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs13(DataSetScheme.Class58 class58_1, DataRowAction dataRowAction_1)
			{
				this.class58_0 = class58_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class58 method_0()
			{
				return this.class58_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class58 class58_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs14 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs14(DataSetScheme.Class59 class59_1, DataRowAction dataRowAction_1)
			{
				this.class59_0 = class59_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class59 method_0()
			{
				return this.class59_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class59 class59_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs15 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs15(DataSetScheme.Class60 class60_1, DataRowAction dataRowAction_1)
			{
				this.class60_0 = class60_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class60 method_0()
			{
				return this.class60_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class60 class60_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs16 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs16(DataSetScheme.Class61 class61_1, DataRowAction dataRowAction_1)
			{
				this.class61_0 = class61_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class61 method_0()
			{
				return this.class61_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class61 class61_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs17 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs17(DataSetScheme.Class62 class62_1, DataRowAction dataRowAction_1)
			{
				this.class62_0 = class62_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class62 method_0()
			{
				return this.class62_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class62 class62_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs18 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs18(DataSetScheme.Class63 class63_1, DataRowAction dataRowAction_1)
			{
				this.class63_0 = class63_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class63 method_0()
			{
				return this.class63_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class63 class63_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs19 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs19(DataSetScheme.Class64 class64_1, DataRowAction dataRowAction_1)
			{
				this.class64_0 = class64_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class64 method_0()
			{
				return this.class64_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class64 class64_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs20 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs20(DataSetScheme.Class65 class65_1, DataRowAction dataRowAction_1)
			{
				this.class65_0 = class65_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class65 method_0()
			{
				return this.class65_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class65 class65_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs21 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs21(DataSetScheme.Class66 class66_1, DataRowAction dataRowAction_1)
			{
				this.class66_0 = class66_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class66 method_0()
			{
				return this.class66_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class66 class66_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs22 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs22(DataSetScheme.Class67 class67_1, DataRowAction dataRowAction_1)
			{
				this.class67_0 = class67_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class67 method_0()
			{
				return this.class67_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class67 class67_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs23 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs23(DataSetScheme.Class68 class68_1, DataRowAction dataRowAction_1)
			{
				this.class68_0 = class68_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class68 method_0()
			{
				return this.class68_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class68 class68_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs24 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs24(DataSetScheme.Class69 class69_1, DataRowAction dataRowAction_1)
			{
				this.class69_0 = class69_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class69 method_0()
			{
				return this.class69_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class69 class69_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs25 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs25(DataSetScheme.Class70 class70_1, DataRowAction dataRowAction_1)
			{
				this.class70_0 = class70_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class70 method_0()
			{
				return this.class70_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class70 class70_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs26 : EventArgs
		{
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public EventArgs26(DataSetScheme.Class71 class71_1, DataRowAction dataRowAction_1)
			{
				this.class71_0 = class71_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class71 method_0()
			{
				return this.class71_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class71 class71_0;

			private DataRowAction dataRowAction_0;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class EventArgs27 : EventArgs
		{
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public EventArgs27(DataSetScheme.Class72 class72_1, DataRowAction dataRowAction_1)
			{
				this.class72_0 = class72_1;
				this.dataRowAction_0 = dataRowAction_1;
			}

			public DataSetScheme.Class72 method_0()
			{
				return this.class72_0;
			}

			public DataRowAction method_1()
			{
				return this.dataRowAction_0;
			}

			private DataSetScheme.Class72 class72_0;

			private DataRowAction dataRowAction_0;
		}
	}
}
