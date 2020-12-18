namespace Documents.Forms.DailyReport.DataSets
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Data;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable, XmlSchemaProvider("GetTypedDataSetSchema"), HelpKeyword("vs.data.DataSet"), DesignerCategory("code"), ToolboxItem(true), XmlRoot("DataSetDamage")]
    internal class DataSetDamage : DataSet
    {
        private System.Data.SchemaSerializationMode _schemaSerializationMode;
        private ReportDailyDefectDataTable tableReportDailyDefect;
        private ReportDailyHVDataTable tableReportDailyHV;
        private ReportDailyLVDataTable tableReportDailyLV;
        private table23DataTable tabletable23;
        private table31DataTable tabletable31;
        private table4DataTable tabletable4;
        private tJ_DamageDataTable tabletJ_Damage;
        private tJ_DamageActDetectionDataTable tabletJ_DamageActDetection;
        private tJ_DamageCharacterDataTable tabletJ_DamageCharacter;
        private tJ_DamageHVDataTable tabletJ_DamageHV;
        private tJ_DamageLVDataTable tabletJ_DamageLV;
        private tJ_DamageOnDataTable tabletJ_DamageOn;
        private tJ_TemperatureDataTable tabletJ_Temperature;
        private tMapObjDataTable tabletMapObj;
        private tReportDetectionCrashDataTable tabletReportDetectionCrash;
        private tReportDetectionNetRegDataTable tabletReportDetectionNetReg;
        private tReportDetectionNoAdmissKWTDataTable tabletReportDetectionNoAdmissKWT;
        private tReportDetectionReasonCrashDataTable tabletReportDetectionReasonCrash;
        private tReportIterruptLVDataTable tabletReportIterruptLV;
        private tSettingsDataTable tabletSettings;
        private vJ_DamageDataTable tablevJ_Damage;
        private vJ_TemperatureDataTable tablevJ_Temperature;
        private vWorkerGroupDataTable tablevWorkerGroup;

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public DataSetDamage()
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            base.BeginInit();
            this.method_2();
            CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_26);
            base.Tables.CollectionChanged += handler;
            base.Relations.CollectionChanged += handler;
            base.EndInit();
            this.method_27();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected DataSetDamage(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0, false)
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            if (base.IsBinarySerialized(serializationInfo_0, streamingContext_0))
            {
                this.method_1(false);
                CollectionChangeEventHandler handler2 = new CollectionChangeEventHandler(this.method_26);
                this.Tables.CollectionChanged += handler2;
                this.Relations.CollectionChanged += handler2;
                if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == System.Data.SchemaSerializationMode.ExcludeSchema)
                {
                    this.method_27();
                }
            }
            else
            {
                string s = (string) serializationInfo_0.GetValue("XmlSchema", typeof(string));
                if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == System.Data.SchemaSerializationMode.IncludeSchema)
                {
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
                    if (dataSet.Tables["tJ_Damage"] != null)
                    {
                        base.Tables.Add(new tJ_DamageDataTable(dataSet.Tables["tJ_Damage"]));
                    }
                    if (dataSet.Tables["tMapObj"] != null)
                    {
                        base.Tables.Add(new tMapObjDataTable(dataSet.Tables["tMapObj"]));
                    }
                    if (dataSet.Tables["tJ_DamageLV"] != null)
                    {
                        base.Tables.Add(new tJ_DamageLVDataTable(dataSet.Tables["tJ_DamageLV"]));
                    }
                    if (dataSet.Tables["vWorkerGroup"] != null)
                    {
                        base.Tables.Add(new vWorkerGroupDataTable(dataSet.Tables["vWorkerGroup"]));
                    }
                    if (dataSet.Tables["tJ_DamageOn"] != null)
                    {
                        base.Tables.Add(new tJ_DamageOnDataTable(dataSet.Tables["tJ_DamageOn"]));
                    }
                    if (dataSet.Tables["ReportDailyLV"] != null)
                    {
                        base.Tables.Add(new ReportDailyLVDataTable(dataSet.Tables["ReportDailyLV"]));
                    }
                    if (dataSet.Tables["tJ_Temperature"] != null)
                    {
                        base.Tables.Add(new tJ_TemperatureDataTable(dataSet.Tables["tJ_Temperature"]));
                    }
                    if (dataSet.Tables["vJ_Temperature"] != null)
                    {
                        base.Tables.Add(new vJ_TemperatureDataTable(dataSet.Tables["vJ_Temperature"]));
                    }
                    if (dataSet.Tables["tReportIterruptLV"] != null)
                    {
                        base.Tables.Add(new tReportIterruptLVDataTable(dataSet.Tables["tReportIterruptLV"]));
                    }
                    if (dataSet.Tables["ReportDailyDefect"] != null)
                    {
                        base.Tables.Add(new ReportDailyDefectDataTable(dataSet.Tables["ReportDailyDefect"]));
                    }
                    if (dataSet.Tables["vJ_Damage"] != null)
                    {
                        base.Tables.Add(new vJ_DamageDataTable(dataSet.Tables["vJ_Damage"]));
                    }
                    if (dataSet.Tables["ReportDailyHV"] != null)
                    {
                        base.Tables.Add(new ReportDailyHVDataTable(dataSet.Tables["ReportDailyHV"]));
                    }
                    if (dataSet.Tables["tJ_DamageCharacter"] != null)
                    {
                        base.Tables.Add(new tJ_DamageCharacterDataTable(dataSet.Tables["tJ_DamageCharacter"]));
                    }
                    if (dataSet.Tables["tJ_DamageActDetection"] != null)
                    {
                        base.Tables.Add(new tJ_DamageActDetectionDataTable(dataSet.Tables["tJ_DamageActDetection"]));
                    }
                    if (dataSet.Tables["table23"] != null)
                    {
                        base.Tables.Add(new table23DataTable(dataSet.Tables["table23"]));
                    }
                    if (dataSet.Tables["table31"] != null)
                    {
                        base.Tables.Add(new table31DataTable(dataSet.Tables["table31"]));
                    }
                    if (dataSet.Tables["table4"] != null)
                    {
                        base.Tables.Add(new table4DataTable(dataSet.Tables["table4"]));
                    }
                    if (dataSet.Tables["tJ_DamageHV"] != null)
                    {
                        base.Tables.Add(new tJ_DamageHVDataTable(dataSet.Tables["tJ_DamageHV"]));
                    }
                    if (dataSet.Tables["tReportDetectionCrash"] != null)
                    {
                        base.Tables.Add(new tReportDetectionCrashDataTable(dataSet.Tables["tReportDetectionCrash"]));
                    }
                    if (dataSet.Tables["tReportDetectionReasonCrash"] != null)
                    {
                        base.Tables.Add(new tReportDetectionReasonCrashDataTable(dataSet.Tables["tReportDetectionReasonCrash"]));
                    }
                    if (dataSet.Tables["tReportDetectionNetReg"] != null)
                    {
                        base.Tables.Add(new tReportDetectionNetRegDataTable(dataSet.Tables["tReportDetectionNetReg"]));
                    }
                    if (dataSet.Tables["tReportDetectionNoAdmissKWT"] != null)
                    {
                        base.Tables.Add(new tReportDetectionNoAdmissKWTDataTable(dataSet.Tables["tReportDetectionNoAdmissKWT"]));
                    }
                    if (dataSet.Tables["tSettings"] != null)
                    {
                        base.Tables.Add(new tSettingsDataTable(dataSet.Tables["tSettings"]));
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
                    this.method_27();
                }
                base.GetSerializationData(serializationInfo_0, streamingContext_0);
                CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_26);
                base.Tables.CollectionChanged += handler;
                this.Relations.CollectionChanged += handler;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public override DataSet Clone()
        {
            DataSetDamage damage1 = (DataSetDamage) base.Clone();
            damage1.method_0();
            damage1.method_27();
            damage1.SchemaSerializationMode = this.SchemaSerializationMode;
            return damage1;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected override XmlSchema GetSchemaSerializable()
        {
            MemoryStream w = new MemoryStream();
            base.WriteXmlSchema(new XmlTextWriter(w, null));
            w.Position = 0L;
            return XmlSchema.Read(new XmlTextReader(w), null);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void InitializeDerivedDataSet()
        {
            base.BeginInit();
            this.method_2();
            base.EndInit();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void method_0()
        {
            this.method_1(true);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void method_1(bool bool_0)
        {
            this.tabletJ_Damage = (tJ_DamageDataTable) base.Tables["tJ_Damage"];
            if (bool_0 && (this.tabletJ_Damage != null))
            {
                this.tabletJ_Damage.method_3();
            }
            this.tabletMapObj = (tMapObjDataTable) base.Tables["tMapObj"];
            if (bool_0 && (this.tabletMapObj != null))
            {
                this.tabletMapObj.method_3();
            }
            this.tabletJ_DamageLV = (tJ_DamageLVDataTable) base.Tables["tJ_DamageLV"];
            if (bool_0 && (this.tabletJ_DamageLV != null))
            {
                this.tabletJ_DamageLV.method_3();
            }
            this.tablevWorkerGroup = (vWorkerGroupDataTable) base.Tables["vWorkerGroup"];
            if (bool_0 && (this.tablevWorkerGroup != null))
            {
                this.tablevWorkerGroup.method_2();
            }
            this.tabletJ_DamageOn = (tJ_DamageOnDataTable) base.Tables["tJ_DamageOn"];
            if (bool_0 && (this.tabletJ_DamageOn != null))
            {
                this.tabletJ_DamageOn.method_3();
            }
            this.tableReportDailyLV = (ReportDailyLVDataTable) base.Tables["ReportDailyLV"];
            if (bool_0 && (this.tableReportDailyLV != null))
            {
                this.tableReportDailyLV.method_2();
            }
            this.tabletJ_Temperature = (tJ_TemperatureDataTable) base.Tables["tJ_Temperature"];
            if (bool_0 && (this.tabletJ_Temperature != null))
            {
                this.tabletJ_Temperature.method_4();
            }
            this.tablevJ_Temperature = (vJ_TemperatureDataTable) base.Tables["vJ_Temperature"];
            if (bool_0 && (this.tablevJ_Temperature != null))
            {
                this.tablevJ_Temperature.method_4();
            }
            this.tabletReportIterruptLV = (tReportIterruptLVDataTable) base.Tables["tReportIterruptLV"];
            if (bool_0 && (this.tabletReportIterruptLV != null))
            {
                this.tabletReportIterruptLV.method_2();
            }
            this.tableReportDailyDefect = (ReportDailyDefectDataTable) base.Tables["ReportDailyDefect"];
            if (bool_0 && (this.tableReportDailyDefect != null))
            {
                this.tableReportDailyDefect.method_2();
            }
            this.tablevJ_Damage = (vJ_DamageDataTable) base.Tables["vJ_Damage"];
            if (bool_0 && (this.tablevJ_Damage != null))
            {
                this.tablevJ_Damage.method_3();
            }
            this.tableReportDailyHV = (ReportDailyHVDataTable) base.Tables["ReportDailyHV"];
            if (bool_0 && (this.tableReportDailyHV != null))
            {
                this.tableReportDailyHV.method_2();
            }
            this.tabletJ_DamageCharacter = (tJ_DamageCharacterDataTable) base.Tables["tJ_DamageCharacter"];
            if (bool_0 && (this.tabletJ_DamageCharacter != null))
            {
                this.tabletJ_DamageCharacter.method_3();
            }
            this.tabletJ_DamageActDetection = (tJ_DamageActDetectionDataTable) base.Tables["tJ_DamageActDetection"];
            if (bool_0 && (this.tabletJ_DamageActDetection != null))
            {
                this.tabletJ_DamageActDetection.method_3();
            }
            this.tabletable23 = (table23DataTable) base.Tables["table23"];
            if (bool_0 && (this.tabletable23 != null))
            {
                this.tabletable23.method_2();
            }
            this.tabletable31 = (table31DataTable) base.Tables["table31"];
            if (bool_0 && (this.tabletable31 != null))
            {
                this.tabletable31.method_2();
            }
            this.tabletable4 = (table4DataTable) base.Tables["table4"];
            if (bool_0 && (this.tabletable4 != null))
            {
                this.tabletable4.method_2();
            }
            this.tabletJ_DamageHV = (tJ_DamageHVDataTable) base.Tables["tJ_DamageHV"];
            if (bool_0 && (this.tabletJ_DamageHV != null))
            {
                this.tabletJ_DamageHV.method_3();
            }
            this.tabletReportDetectionCrash = (tReportDetectionCrashDataTable) base.Tables["tReportDetectionCrash"];
            if (bool_0 && (this.tabletReportDetectionCrash != null))
            {
                this.tabletReportDetectionCrash.method_2();
            }
            this.tabletReportDetectionReasonCrash = (tReportDetectionReasonCrashDataTable) base.Tables["tReportDetectionReasonCrash"];
            if (bool_0 && (this.tabletReportDetectionReasonCrash != null))
            {
                this.tabletReportDetectionReasonCrash.method_2();
            }
            this.tabletReportDetectionNetReg = (tReportDetectionNetRegDataTable) base.Tables["tReportDetectionNetReg"];
            if (bool_0 && (this.tabletReportDetectionNetReg != null))
            {
                this.tabletReportDetectionNetReg.method_2();
            }
            this.tabletReportDetectionNoAdmissKWT = (tReportDetectionNoAdmissKWTDataTable) base.Tables["tReportDetectionNoAdmissKWT"];
            if (bool_0 && (this.tabletReportDetectionNoAdmissKWT != null))
            {
                this.tabletReportDetectionNoAdmissKWT.method_2();
            }
            this.tabletSettings = (tSettingsDataTable) base.Tables["tSettings"];
            if (bool_0 && (this.tabletSettings != null))
            {
                this.tabletSettings.method_3();
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_10()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_11()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_12()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_13()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_14()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_15()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_16()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_17()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_18()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_19()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_2()
        {
            base.DataSetName = "DataSetDamage";
            base.Prefix = "";
            base.Namespace = "http://tempuri.org/DataSetDamage.xsd";
            base.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tabletJ_Damage = new tJ_DamageDataTable();
            base.Tables.Add(this.tabletJ_Damage);
            this.tabletMapObj = new tMapObjDataTable();
            base.Tables.Add(this.tabletMapObj);
            this.tabletJ_DamageLV = new tJ_DamageLVDataTable();
            base.Tables.Add(this.tabletJ_DamageLV);
            this.tablevWorkerGroup = new vWorkerGroupDataTable();
            base.Tables.Add(this.tablevWorkerGroup);
            this.tabletJ_DamageOn = new tJ_DamageOnDataTable();
            base.Tables.Add(this.tabletJ_DamageOn);
            this.tableReportDailyLV = new ReportDailyLVDataTable();
            base.Tables.Add(this.tableReportDailyLV);
            this.tabletJ_Temperature = new tJ_TemperatureDataTable(false);
            base.Tables.Add(this.tabletJ_Temperature);
            this.tablevJ_Temperature = new vJ_TemperatureDataTable(false);
            base.Tables.Add(this.tablevJ_Temperature);
            this.tabletReportIterruptLV = new tReportIterruptLVDataTable();
            base.Tables.Add(this.tabletReportIterruptLV);
            this.tableReportDailyDefect = new ReportDailyDefectDataTable();
            base.Tables.Add(this.tableReportDailyDefect);
            this.tablevJ_Damage = new vJ_DamageDataTable();
            base.Tables.Add(this.tablevJ_Damage);
            this.tableReportDailyHV = new ReportDailyHVDataTable();
            base.Tables.Add(this.tableReportDailyHV);
            this.tabletJ_DamageCharacter = new tJ_DamageCharacterDataTable();
            base.Tables.Add(this.tabletJ_DamageCharacter);
            this.tabletJ_DamageActDetection = new tJ_DamageActDetectionDataTable();
            base.Tables.Add(this.tabletJ_DamageActDetection);
            this.tabletable23 = new table23DataTable();
            base.Tables.Add(this.tabletable23);
            this.tabletable31 = new table31DataTable();
            base.Tables.Add(this.tabletable31);
            this.tabletable4 = new table4DataTable();
            base.Tables.Add(this.tabletable4);
            this.tabletJ_DamageHV = new tJ_DamageHVDataTable();
            base.Tables.Add(this.tabletJ_DamageHV);
            this.tabletReportDetectionCrash = new tReportDetectionCrashDataTable();
            base.Tables.Add(this.tabletReportDetectionCrash);
            this.tabletReportDetectionReasonCrash = new tReportDetectionReasonCrashDataTable();
            base.Tables.Add(this.tabletReportDetectionReasonCrash);
            this.tabletReportDetectionNetReg = new tReportDetectionNetRegDataTable();
            base.Tables.Add(this.tabletReportDetectionNetReg);
            this.tabletReportDetectionNoAdmissKWT = new tReportDetectionNoAdmissKWTDataTable();
            base.Tables.Add(this.tabletReportDetectionNoAdmissKWT);
            this.tabletSettings = new tSettingsDataTable();
            base.Tables.Add(this.tabletSettings);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_20()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_21()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_22()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_23()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_24()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_25()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void method_26(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Remove)
            {
                this.method_0();
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void method_27()
        {
            this.tJ_Temperature.NightColumn.Expression = "isnull('от ' +NightDown + ' ' , '') + isnull('до ' + nightUp, '')";
            this.tJ_Temperature.DayColumn.Expression = "isnull('от ' +DayDown + ' ' , '') + isnull('до ' + DayUp, '')";
            this.tJ_Temperature.SpeedColumn.Expression = "isnull('от ' +SpeedDown + ' ' , '') + isnull('до ' + SpeedUp, '')";
            this.vJ_Temperature.NightColumn.Expression = "isnull('от ' +NightDown + ' ' , '') + isnull('до ' + nightUp, '')";
            this.vJ_Temperature.DayColumn.Expression = "isnull('от ' +DayDown + ' ' , '') + isnull('до ' + DayUp, '')";
            this.vJ_Temperature.SpeedColumn.Expression = "isnull(SpeedDown + ' - ' , '') + isnull( SpeedUp, '')";
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_3()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_4()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_5()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_6()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_7()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_8()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_9()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(XmlReader reader)
        {
            if (base.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)
            {
                this.Reset();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(reader);
                if (dataSet.Tables["tJ_Damage"] != null)
                {
                    base.Tables.Add(new tJ_DamageDataTable(dataSet.Tables["tJ_Damage"]));
                }
                if (dataSet.Tables["tMapObj"] != null)
                {
                    base.Tables.Add(new tMapObjDataTable(dataSet.Tables["tMapObj"]));
                }
                if (dataSet.Tables["tJ_DamageLV"] != null)
                {
                    base.Tables.Add(new tJ_DamageLVDataTable(dataSet.Tables["tJ_DamageLV"]));
                }
                if (dataSet.Tables["vWorkerGroup"] != null)
                {
                    base.Tables.Add(new vWorkerGroupDataTable(dataSet.Tables["vWorkerGroup"]));
                }
                if (dataSet.Tables["tJ_DamageOn"] != null)
                {
                    base.Tables.Add(new tJ_DamageOnDataTable(dataSet.Tables["tJ_DamageOn"]));
                }
                if (dataSet.Tables["ReportDailyLV"] != null)
                {
                    base.Tables.Add(new ReportDailyLVDataTable(dataSet.Tables["ReportDailyLV"]));
                }
                if (dataSet.Tables["tJ_Temperature"] != null)
                {
                    base.Tables.Add(new tJ_TemperatureDataTable(dataSet.Tables["tJ_Temperature"]));
                }
                if (dataSet.Tables["vJ_Temperature"] != null)
                {
                    base.Tables.Add(new vJ_TemperatureDataTable(dataSet.Tables["vJ_Temperature"]));
                }
                if (dataSet.Tables["tReportIterruptLV"] != null)
                {
                    base.Tables.Add(new tReportIterruptLVDataTable(dataSet.Tables["tReportIterruptLV"]));
                }
                if (dataSet.Tables["ReportDailyDefect"] != null)
                {
                    base.Tables.Add(new ReportDailyDefectDataTable(dataSet.Tables["ReportDailyDefect"]));
                }
                if (dataSet.Tables["vJ_Damage"] != null)
                {
                    base.Tables.Add(new vJ_DamageDataTable(dataSet.Tables["vJ_Damage"]));
                }
                if (dataSet.Tables["ReportDailyHV"] != null)
                {
                    base.Tables.Add(new ReportDailyHVDataTable(dataSet.Tables["ReportDailyHV"]));
                }
                if (dataSet.Tables["tJ_DamageCharacter"] != null)
                {
                    base.Tables.Add(new tJ_DamageCharacterDataTable(dataSet.Tables["tJ_DamageCharacter"]));
                }
                if (dataSet.Tables["tJ_DamageActDetection"] != null)
                {
                    base.Tables.Add(new tJ_DamageActDetectionDataTable(dataSet.Tables["tJ_DamageActDetection"]));
                }
                if (dataSet.Tables["table23"] != null)
                {
                    base.Tables.Add(new table23DataTable(dataSet.Tables["table23"]));
                }
                if (dataSet.Tables["table31"] != null)
                {
                    base.Tables.Add(new table31DataTable(dataSet.Tables["table31"]));
                }
                if (dataSet.Tables["table4"] != null)
                {
                    base.Tables.Add(new table4DataTable(dataSet.Tables["table4"]));
                }
                if (dataSet.Tables["tJ_DamageHV"] != null)
                {
                    base.Tables.Add(new tJ_DamageHVDataTable(dataSet.Tables["tJ_DamageHV"]));
                }
                if (dataSet.Tables["tReportDetectionCrash"] != null)
                {
                    base.Tables.Add(new tReportDetectionCrashDataTable(dataSet.Tables["tReportDetectionCrash"]));
                }
                if (dataSet.Tables["tReportDetectionReasonCrash"] != null)
                {
                    base.Tables.Add(new tReportDetectionReasonCrashDataTable(dataSet.Tables["tReportDetectionReasonCrash"]));
                }
                if (dataSet.Tables["tReportDetectionNetReg"] != null)
                {
                    base.Tables.Add(new tReportDetectionNetRegDataTable(dataSet.Tables["tReportDetectionNetReg"]));
                }
                if (dataSet.Tables["tReportDetectionNoAdmissKWT"] != null)
                {
                    base.Tables.Add(new tReportDetectionNoAdmissKWTDataTable(dataSet.Tables["tReportDetectionNoAdmissKWT"]));
                }
                if (dataSet.Tables["tSettings"] != null)
                {
                    base.Tables.Add(new tSettingsDataTable(dataSet.Tables["tSettings"]));
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
                base.ReadXml(reader);
                this.method_0();
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeRelations()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected override bool ShouldSerializeTables()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
        {
            DataSetDamage damage = new DataSetDamage();
            XmlSchemaComplexType type = new XmlSchemaComplexType();
            XmlSchemaSequence sequence = new XmlSchemaSequence();
            XmlSchemaAny item = new XmlSchemaAny {
                Namespace = damage.Namespace
            };
            sequence.Items.Add(item);
            type.Particle = sequence;
            XmlSchema schemaSerializable = damage.GetSchemaSerializable();
            if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
            {
                XmlSchemaComplexType type2;
                MemoryStream stream = new MemoryStream();
                MemoryStream stream2 = new MemoryStream();
                try
                {
                    schemaSerializable.Write(stream);
                    IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                    while (enumerator.MoveNext())
                    {
                        stream2.SetLength(0L);
                        ((XmlSchema) enumerator.Current).Write(stream2);
                        if (stream.Length == stream2.Length)
                        {
                            stream.Position = 0L;
                            stream2.Position = 0L;
                            while (stream.Position != stream.Length)
                            {
                                if (stream.ReadByte() != stream2.ReadByte())
                                {
                                    break;
                                }
                            }
                            if (stream.Position == stream.Length)
                            {
                                goto Label_011B;
                            }
                        }
                    }
                    goto Label_013A;
                Label_011B:
                    type2 = type;
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Close();
                    }
                    if (stream2 != null)
                    {
                        stream2.Close();
                    }
                }
                return type2;
            }
        Label_013A:
            xmlSchemaSet_0.Add(schemaSerializable);
            return type;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public ReportDailyDefectDataTable ReportDailyDefect
        {
            get
            {
                return this.tableReportDailyDefect;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ReportDailyHVDataTable ReportDailyHV
        {
            get
            {
                return this.tableReportDailyHV;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public ReportDailyLVDataTable ReportDailyLV
        {
            get
            {
                return this.tableReportDailyLV;
            }
        }

        [DebuggerNonUserCode, Browsable(true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override System.Data.SchemaSerializationMode SchemaSerializationMode
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public table23DataTable table23
        {
            get
            {
                return this.tabletable23;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public table31DataTable table31
        {
            get
            {
                return this.tabletable31;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false)]
        public table4DataTable table4
        {
            get
            {
                return this.tabletable4;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public DataTableCollection Tables
        {
            get
            {
                return base.Tables;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tJ_DamageDataTable tJ_Damage
        {
            get
            {
                return this.tabletJ_Damage;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tJ_DamageActDetectionDataTable tJ_DamageActDetection
        {
            get
            {
                return this.tabletJ_DamageActDetection;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public tJ_DamageCharacterDataTable tJ_DamageCharacter
        {
            get
            {
                return this.tabletJ_DamageCharacter;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tJ_DamageHVDataTable tJ_DamageHV
        {
            get
            {
                return this.tabletJ_DamageHV;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tJ_DamageLVDataTable tJ_DamageLV
        {
            get
            {
                return this.tabletJ_DamageLV;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public tJ_DamageOnDataTable tJ_DamageOn
        {
            get
            {
                return this.tabletJ_DamageOn;
            }
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tJ_TemperatureDataTable tJ_Temperature
        {
            get
            {
                return this.tabletJ_Temperature;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tMapObjDataTable tMapObj
        {
            get
            {
                return this.tabletMapObj;
            }
        }

        [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tReportDetectionCrashDataTable tReportDetectionCrash
        {
            get
            {
                return this.tabletReportDetectionCrash;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode]
        public tReportDetectionNetRegDataTable tReportDetectionNetReg
        {
            get
            {
                return this.tabletReportDetectionNetReg;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tReportDetectionNoAdmissKWTDataTable tReportDetectionNoAdmissKWT
        {
            get
            {
                return this.tabletReportDetectionNoAdmissKWT;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public tReportDetectionReasonCrashDataTable tReportDetectionReasonCrash
        {
            get
            {
                return this.tabletReportDetectionReasonCrash;
            }
        }

        [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tReportIterruptLVDataTable tReportIterruptLV
        {
            get
            {
                return this.tabletReportIterruptLV;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tSettingsDataTable tSettings
        {
            get
            {
                return this.tabletSettings;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public vJ_DamageDataTable vJ_Damage
        {
            get
            {
                return this.tablevJ_Damage;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public vJ_TemperatureDataTable vJ_Temperature
        {
            get
            {
                return this.tablevJ_Temperature;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public vWorkerGroupDataTable vWorkerGroup
        {
            get
            {
                return this.tablevWorkerGroup;
            }
        }

        public class Class328 : DataRow
        {
            private DataSetDamage.tJ_DamageDataTable tJ_DamageDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class328(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_DamageDataTable_0 = (DataSetDamage.tJ_DamageDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.numDocColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'numDoc' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tJ_DamageDataTable_0.numDocColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idDivisionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idDivision' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_100()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.LaboratoryInstructionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_101()
            {
                base[this.tJ_DamageDataTable_0.LaboratoryInstructionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_102()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idCompletedWorkODSColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_103()
            {
                base[this.tJ_DamageDataTable_0.idCompletedWorkODSColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_104()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.CompletedWorkTextODSColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_105()
            {
                base[this.tJ_DamageDataTable_0.CompletedWorkTextODSColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_106()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idReqForRepairColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_107()
            {
                base[this.tJ_DamageDataTable_0.idReqForRepairColumn] = Convert.DBNull;
            }

            public void method_11(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idDivisionColumn] = int_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idSchmObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idSchmObj' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idSchmObjColumn] = int_0;
            }

            public int method_14()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idMapColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idMap' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idMapColumn] = int_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageDataTable_0.DefectLocationColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DefectLocation' in table 'tJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.tJ_DamageDataTable_0.DefectLocationColumn] = string_0;
            }

            public int method_18()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idReasonColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idReason' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_19(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idReasonColumn] = int_0;
            }

            public DateTime method_2()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_DamageDataTable_0.DateDocColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateDoc' in table 'tJ_Damage' is DBNull.", exception);
                }
                return time;
            }

            public int method_20()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idCompletedWorkColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idCompletedWork' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_21(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idCompletedWorkColumn] = int_0;
            }

            public string method_22()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageDataTable_0.ComletedWorkTextColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ComletedWorkText' in table 'tJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_23(string string_0)
            {
                base[this.tJ_DamageDataTable_0.ComletedWorkTextColumn] = string_0;
            }

            public bool method_24()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tJ_DamageDataTable_0.isApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isApply' in table 'tJ_Damage' is DBNull.", exception);
                }
                return flag;
            }

            public void method_25(bool bool_0)
            {
                base[this.tJ_DamageDataTable_0.isApplyColumn] = bool_0;
            }

            public int method_26()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idWorkerApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idWorkerApply' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_27(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idWorkerApplyColumn] = int_0;
            }

            public DateTime method_28()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_DamageDataTable_0.DatePlanApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DatePlanApply' in table 'tJ_Damage' is DBNull.", exception);
                }
                return time;
            }

            public void method_29(DateTime dateTime_0)
            {
                base[this.tJ_DamageDataTable_0.DatePlanApplyColumn] = dateTime_0;
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.tJ_DamageDataTable_0.DateDocColumn] = dateTime_0;
            }

            public DateTime method_30()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_DamageDataTable_0.DateApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateApply' in table 'tJ_Damage' is DBNull.", exception);
                }
                return time;
            }

            public void method_31(DateTime dateTime_0)
            {
                base[this.tJ_DamageDataTable_0.DateApplyColumn] = dateTime_0;
            }

            public int method_32()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idDivisionApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idDivisionApply' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_33(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idDivisionApplyColumn] = int_0;
            }

            public bool method_34()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tJ_DamageDataTable_0.isLaboratoryColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isLaboratory' in table 'tJ_Damage' is DBNull.", exception);
                }
                return flag;
            }

            public void method_35(bool bool_0)
            {
                base[this.tJ_DamageDataTable_0.isLaboratoryColumn] = bool_0;
            }

            public int method_36()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idParentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idParent' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_37(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idParentColumn] = int_0;
            }

            public int method_38()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idOwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idOwner' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_39(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idOwnerColumn] = int_0;
            }

            public int method_4()
            {
                return (int) base[this.tJ_DamageDataTable_0.TypeDocColumn];
            }

            public DateTime method_40()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_DamageDataTable_0.DateOwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateOwner' in table 'tJ_Damage' is DBNull.", exception);
                }
                return time;
            }

            public void method_41(DateTime dateTime_0)
            {
                base[this.tJ_DamageDataTable_0.DateOwnerColumn] = dateTime_0;
            }

            public int method_42()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idReasonPTSColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idReasonPTS' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_43(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idReasonPTSColumn] = int_0;
            }

            public string method_44()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageDataTable_0.DivisionInstructionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DivisionInstruction' in table 'tJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_45(string string_0)
            {
                base[this.tJ_DamageDataTable_0.DivisionInstructionColumn] = string_0;
            }

            public string method_46()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageDataTable_0.LaboratoryInstructionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'LaboratoryInstruction' in table 'tJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_47(string string_0)
            {
                base[this.tJ_DamageDataTable_0.LaboratoryInstructionColumn] = string_0;
            }

            public int method_48()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idCompletedWorkODSColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idCompletedWorkODS' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_49(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idCompletedWorkODSColumn] = int_0;
            }

            public void method_5(int int_0)
            {
                base[this.tJ_DamageDataTable_0.TypeDocColumn] = int_0;
            }

            public string method_50()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageDataTable_0.CompletedWorkTextODSColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CompletedWorkTextODS' in table 'tJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_51(string string_0)
            {
                base[this.tJ_DamageDataTable_0.CompletedWorkTextODSColumn] = string_0;
            }

            public bool method_52()
            {
                return (bool) base[this.tJ_DamageDataTable_0.deletedColumn];
            }

            public void method_53(bool bool_0)
            {
                base[this.tJ_DamageDataTable_0.deletedColumn] = bool_0;
            }

            public int method_54()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idReqForRepairColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idReqForRepair' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_55(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idReqForRepairColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.numDocColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_57()
            {
                base[this.tJ_DamageDataTable_0.numDocColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_58()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.DateDocColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_59()
            {
                base[this.tJ_DamageDataTable_0.DateDocColumn] = Convert.DBNull;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageDataTable_0.NumRequestColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NumRequest' in table 'tJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_60()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.NumRequestColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_61()
            {
                base[this.tJ_DamageDataTable_0.NumRequestColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_62()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idCompilerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_63()
            {
                base[this.tJ_DamageDataTable_0.idCompilerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_64()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idDivisionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_65()
            {
                base[this.tJ_DamageDataTable_0.idDivisionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_66()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idSchmObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_67()
            {
                base[this.tJ_DamageDataTable_0.idSchmObjColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_68()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idMapColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_69()
            {
                base[this.tJ_DamageDataTable_0.idMapColumn] = Convert.DBNull;
            }

            public void method_7(string string_0)
            {
                base[this.tJ_DamageDataTable_0.NumRequestColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_70()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.DefectLocationColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_71()
            {
                base[this.tJ_DamageDataTable_0.DefectLocationColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_72()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idReasonColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_73()
            {
                base[this.tJ_DamageDataTable_0.idReasonColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_74()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idCompletedWorkColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_75()
            {
                base[this.tJ_DamageDataTable_0.idCompletedWorkColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_76()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.ComletedWorkTextColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_77()
            {
                base[this.tJ_DamageDataTable_0.ComletedWorkTextColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_78()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.isApplyColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_79()
            {
                base[this.tJ_DamageDataTable_0.isApplyColumn] = Convert.DBNull;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageDataTable_0.idCompilerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idCompiler' in table 'tJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_80()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idWorkerApplyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_81()
            {
                base[this.tJ_DamageDataTable_0.idWorkerApplyColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_82()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.DatePlanApplyColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_83()
            {
                base[this.tJ_DamageDataTable_0.DatePlanApplyColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_84()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.DateApplyColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_85()
            {
                base[this.tJ_DamageDataTable_0.DateApplyColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_86()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idDivisionApplyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_87()
            {
                base[this.tJ_DamageDataTable_0.idDivisionApplyColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_88()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.isLaboratoryColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_89()
            {
                base[this.tJ_DamageDataTable_0.isLaboratoryColumn] = Convert.DBNull;
            }

            public void method_9(int int_0)
            {
                base[this.tJ_DamageDataTable_0.idCompilerColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_90()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idParentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_91()
            {
                base[this.tJ_DamageDataTable_0.idParentColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_92()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idOwnerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_93()
            {
                base[this.tJ_DamageDataTable_0.idOwnerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_94()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.DateOwnerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_95()
            {
                base[this.tJ_DamageDataTable_0.DateOwnerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_96()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.idReasonPTSColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_97()
            {
                base[this.tJ_DamageDataTable_0.idReasonPTSColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_98()
            {
                return base.IsNull(this.tJ_DamageDataTable_0.DivisionInstructionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_99()
            {
                base[this.tJ_DamageDataTable_0.DivisionInstructionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_DamageDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_DamageDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class329 : DataRow
        {
            private DataSetDamage.tMapObjDataTable tMapObjDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class329(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tMapObjDataTable_0 = (DataSetDamage.tMapObjDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tMapObjDataTable_0.idMapColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tMapObjDataTable_0.idMapColumn] = int_0;
            }

            public bool method_10()
            {
                return (bool) base[this.tMapObjDataTable_0.IsHouseColumn];
            }

            public void method_11(bool bool_0)
            {
                base[this.tMapObjDataTable_0.IsHouseColumn] = bool_0;
            }

            public string method_12()
            {
                string str;
                try
                {
                    str = (string) base[this.tMapObjDataTable_0.IndexColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Index' in table 'tMapObj' is DBNull.", exception);
                }
                return str;
            }

            public void method_13(string string_0)
            {
                base[this.tMapObjDataTable_0.IndexColumn] = string_0;
            }

            public double method_14()
            {
                double num;
                try
                {
                    num = (double) base[this.tMapObjDataTable_0.LatitudeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Latitude' in table 'tMapObj' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(double double_0)
            {
                base[this.tMapObjDataTable_0.LatitudeColumn] = double_0;
            }

            public double method_16()
            {
                double num;
                try
                {
                    num = (double) base[this.tMapObjDataTable_0.LongitudeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Longitude' in table 'tMapObj' is DBNull.", exception);
                }
                return num;
            }

            public void method_17(double double_0)
            {
                base[this.tMapObjDataTable_0.LongitudeColumn] = double_0;
            }

            public bool method_18()
            {
                return (bool) base[this.tMapObjDataTable_0.DeletedColumn];
            }

            public void method_19(bool bool_0)
            {
                base[this.tMapObjDataTable_0.DeletedColumn] = bool_0;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tMapObjDataTable_0.RaionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Raion' in table 'tMapObj' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.tMapObjDataTable_0.RaionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_21()
            {
                base[this.tMapObjDataTable_0.RaionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_22()
            {
                return base.IsNull(this.tMapObjDataTable_0.HouseColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_23()
            {
                base[this.tMapObjDataTable_0.HouseColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_24()
            {
                return base.IsNull(this.tMapObjDataTable_0.HousePrefixColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_25()
            {
                base[this.tMapObjDataTable_0.HousePrefixColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_26()
            {
                return base.IsNull(this.tMapObjDataTable_0.NameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_27()
            {
                base[this.tMapObjDataTable_0.NameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_28()
            {
                return base.IsNull(this.tMapObjDataTable_0.IndexColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_29()
            {
                base[this.tMapObjDataTable_0.IndexColumn] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.tMapObjDataTable_0.RaionColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_30()
            {
                return base.IsNull(this.tMapObjDataTable_0.LatitudeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.tMapObjDataTable_0.LatitudeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_32()
            {
                return base.IsNull(this.tMapObjDataTable_0.LongitudeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_33()
            {
                base[this.tMapObjDataTable_0.LongitudeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_34()
            {
                return base.IsNull(this.tMapObjDataTable_0.CommentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_35()
            {
                base[this.tMapObjDataTable_0.CommentColumn] = Convert.DBNull;
            }

            public int method_4()
            {
                return (int) base[this.tMapObjDataTable_0.StreetColumn];
            }

            public void method_5(int int_0)
            {
                base[this.tMapObjDataTable_0.StreetColumn] = int_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tMapObjDataTable_0.HouseColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'House' in table 'tMapObj' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.tMapObjDataTable_0.HouseColumn] = int_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.tMapObjDataTable_0.HousePrefixColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'HousePrefix' in table 'tMapObj' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.tMapObjDataTable_0.HousePrefixColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tMapObjDataTable_0.CommentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Comment' in table 'tMapObj' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tMapObjDataTable_0.CommentColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Name
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tMapObjDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'tMapObj' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tMapObjDataTable_0.NameColumn] = value;
                }
            }
        }

        public class Class330 : DataRow
        {
            private DataSetDamage.tJ_DamageLVDataTable tJ_DamageLVDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class330(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_DamageLVDataTable_0 = (DataSetDamage.tJ_DamageLVDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_DamageLVDataTable_0.idDamageColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_DamageLVDataTable_0.idDamageColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_10()
            {
                return base.IsNull(this.tJ_DamageLVDataTable_0.DeclarerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_11()
            {
                base[this.tJ_DamageLVDataTable_0.DeclarerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.tJ_DamageLVDataTable_0.DeclarerTelColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.tJ_DamageLVDataTable_0.DeclarerTelColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_14()
            {
                return base.IsNull(this.tJ_DamageLVDataTable_0.DeclarerAddressColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_15()
            {
                base[this.tJ_DamageLVDataTable_0.DeclarerAddressColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.tJ_DamageLVDataTable_0.AbnOffColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.tJ_DamageLVDataTable_0.AbnOffColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageLVDataTable_0.DeclarerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Declarer' in table 'tJ_DamageLV' is DBNull.", exception);
                }
                return str;
            }

            public void method_3(string string_0)
            {
                base[this.tJ_DamageLVDataTable_0.DeclarerColumn] = string_0;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageLVDataTable_0.DeclarerTelColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DeclarerTel' in table 'tJ_DamageLV' is DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.tJ_DamageLVDataTable_0.DeclarerTelColumn] = string_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageLVDataTable_0.DeclarerAddressColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DeclarerAddress' in table 'tJ_DamageLV' is DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.tJ_DamageLVDataTable_0.DeclarerAddressColumn] = string_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageLVDataTable_0.AbnOffColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'AbnOff' in table 'tJ_DamageLV' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.tJ_DamageLVDataTable_0.AbnOffColumn] = string_0;
            }
        }

        public class Class331 : DataRow
        {
            private DataSetDamage.vWorkerGroupDataTable vWorkerGroupDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class331(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vWorkerGroupDataTable_0 = (DataSetDamage.vWorkerGroupDataTable) base.Table;
            }

            public DateTime method_0()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vWorkerGroupDataTable_0.DateBeginColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateBegin' in table 'vWorkerGroup' is DBNull.", exception);
                }
                return time;
            }

            public void method_1(DateTime dateTime_0)
            {
                base[this.vWorkerGroupDataTable_0.DateBeginColumn] = dateTime_0;
            }

            public short method_10()
            {
                short num;
                try
                {
                    num = (short) base[this.vWorkerGroupDataTable_0.GroupElectricalColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'GroupElectrical' in table 'vWorkerGroup' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(short short_0)
            {
                base[this.vWorkerGroupDataTable_0.GroupElectricalColumn] = short_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_12()
            {
                return base.IsNull(this.vWorkerGroupDataTable_0.FIOColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.vWorkerGroupDataTable_0.FIOColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.vWorkerGroupDataTable_0.DateBeginColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.vWorkerGroupDataTable_0.DateBeginColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_16()
            {
                return base.IsNull(this.vWorkerGroupDataTable_0.DateEndColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.vWorkerGroupDataTable_0.DateEndColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.vWorkerGroupDataTable_0.idGroupColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.vWorkerGroupDataTable_0.idGroupColumn] = Convert.DBNull;
            }

            public DateTime method_2()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vWorkerGroupDataTable_0.DateEndColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateEnd' in table 'vWorkerGroup' is DBNull.", exception);
                }
                return time;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.vWorkerGroupDataTable_0.WorkerGroupColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.vWorkerGroupDataTable_0.WorkerGroupColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_22()
            {
                return base.IsNull(this.vWorkerGroupDataTable_0.ParentKeyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_23()
            {
                base[this.vWorkerGroupDataTable_0.ParentKeyColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_24()
            {
                return base.IsNull(this.vWorkerGroupDataTable_0.DescriptionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.vWorkerGroupDataTable_0.DescriptionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_26()
            {
                return base.IsNull(this.vWorkerGroupDataTable_0.idDescriptionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_27()
            {
                base[this.vWorkerGroupDataTable_0.idDescriptionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_28()
            {
                return base.IsNull(this.vWorkerGroupDataTable_0.GroupElectricalColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_29()
            {
                base[this.vWorkerGroupDataTable_0.GroupElectricalColumn] = Convert.DBNull;
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.vWorkerGroupDataTable_0.DateEndColumn] = dateTime_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.vWorkerGroupDataTable_0.idGroupColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idGroup' in table 'vWorkerGroup' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.vWorkerGroupDataTable_0.idGroupColumn] = int_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.vWorkerGroupDataTable_0.WorkerGroupColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'WorkerGroup' in table 'vWorkerGroup' is DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.vWorkerGroupDataTable_0.WorkerGroupColumn] = string_0;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.vWorkerGroupDataTable_0.idDescriptionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idDescription' in table 'vWorkerGroup' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(int int_0)
            {
                base[this.vWorkerGroupDataTable_0.idDescriptionColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Description
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vWorkerGroupDataTable_0.DescriptionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Description' in table 'vWorkerGroup' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vWorkerGroupDataTable_0.DescriptionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FIO
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vWorkerGroupDataTable_0.FIOColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'FIO' in table 'vWorkerGroup' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vWorkerGroupDataTable_0.FIOColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vWorkerGroupDataTable_0.idColumn];
                }
                set
                {
                    base[this.vWorkerGroupDataTable_0.idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ParentKey
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vWorkerGroupDataTable_0.ParentKeyColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'ParentKey' in table 'vWorkerGroup' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vWorkerGroupDataTable_0.ParentKeyColumn] = value;
                }
            }
        }

        public class Class332 : DataRow
        {
            private DataSetDamage.tJ_DamageOnDataTable tJ_DamageOnDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class332(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_DamageOnDataTable_0 = (DataSetDamage.tJ_DamageOnDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_DamageOnDataTable_0.idDamageColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_DamageOnDataTable_0.idDamageColumn] = int_0;
            }

            public DateTime method_2()
            {
                return (DateTime) base[this.tJ_DamageOnDataTable_0.dateOnColumn];
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.tJ_DamageOnDataTable_0.dateOnColumn] = dateTime_0;
            }

            public int method_4()
            {
                return (int) base[this.tJ_DamageOnDataTable_0.countSchmObjColumn];
            }

            public void method_5(int int_0)
            {
                base[this.tJ_DamageOnDataTable_0.countSchmObjColumn] = int_0;
            }

            public decimal method_6()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_DamageOnDataTable_0.noAdmissionKWTColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'noAdmissionKWT' in table 'tJ_DamageOn' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(decimal decimal_0)
            {
                base[this.tJ_DamageOnDataTable_0.noAdmissionKWTColumn] = decimal_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.tJ_DamageOnDataTable_0.noAdmissionKWTColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.tJ_DamageOnDataTable_0.noAdmissionKWTColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_DamageOnDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_DamageOnDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class333 : DataRow
        {
            private DataSetDamage.ReportDailyLVDataTable reportDailyLVDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class333(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.reportDailyLVDataTable_0 = (DataSetDamage.ReportDailyLVDataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyLVDataTable_0.numRequestColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'numRequest' in table 'ReportDailyLV' is DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.reportDailyLVDataTable_0.numRequestColumn] = string_0;
            }

            public string method_10()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyLVDataTable_0.CharacterColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Character' in table 'ReportDailyLV' is DBNull.", exception);
                }
                return str;
            }

            public void method_11(string string_0)
            {
                base[this.reportDailyLVDataTable_0.CharacterColumn] = string_0;
            }

            public DateTime method_12()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.reportDailyLVDataTable_0.dateApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateApply' in table 'ReportDailyLV' is DBNull.", exception);
                }
                return time;
            }

            public void method_13(DateTime dateTime_0)
            {
                base[this.reportDailyLVDataTable_0.dateApplyColumn] = dateTime_0;
            }

            public string method_14()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyLVDataTable_0.completedWorkColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'completedWork' in table 'ReportDailyLV' is DBNull.", exception);
                }
                return str;
            }

            public void method_15(string string_0)
            {
                base[this.reportDailyLVDataTable_0.completedWorkColumn] = string_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyLVDataTable_0.workCompilerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'workCompiler' in table 'ReportDailyLV' is DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.reportDailyLVDataTable_0.workCompilerColumn] = string_0;
            }

            public string method_18()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyLVDataTable_0.workApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'workApply' in table 'ReportDailyLV' is DBNull.", exception);
                }
                return str;
            }

            public void method_19(string string_0)
            {
                base[this.reportDailyLVDataTable_0.workApplyColumn] = string_0;
            }

            public DateTime method_2()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.reportDailyLVDataTable_0.dateDocColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateDoc' in table 'ReportDailyLV' is DBNull.", exception);
                }
                return time;
            }

            public string method_20()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyLVDataTable_0.NetRegionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NetRegion' in table 'ReportDailyLV' is DBNull.", exception);
                }
                return str;
            }

            public void method_21(string string_0)
            {
                base[this.reportDailyLVDataTable_0.NetRegionColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_22()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.idColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_23()
            {
                base[this.reportDailyLVDataTable_0.idColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_24()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.numRequestColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.reportDailyLVDataTable_0.numRequestColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_26()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.dateDocColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_27()
            {
                base[this.reportDailyLVDataTable_0.dateDocColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_28()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.defectLocationColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_29()
            {
                base[this.reportDailyLVDataTable_0.defectLocationColumn] = Convert.DBNull;
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.reportDailyLVDataTable_0.dateDocColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_30()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.ReasonColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.reportDailyLVDataTable_0.ReasonColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_32()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.idSchmObjColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_33()
            {
                base[this.reportDailyLVDataTable_0.idSchmObjColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_34()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.schmObjNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_35()
            {
                base[this.reportDailyLVDataTable_0.schmObjNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_36()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.CharacterColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_37()
            {
                base[this.reportDailyLVDataTable_0.CharacterColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_38()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.dateApplyColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_39()
            {
                base[this.reportDailyLVDataTable_0.dateApplyColumn] = Convert.DBNull;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyLVDataTable_0.defectLocationColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'defectLocation' in table 'ReportDailyLV' is DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_40()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.completedWorkColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_41()
            {
                base[this.reportDailyLVDataTable_0.completedWorkColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.workCompilerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_43()
            {
                base[this.reportDailyLVDataTable_0.workCompilerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_44()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.workApplyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_45()
            {
                base[this.reportDailyLVDataTable_0.workApplyColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_46()
            {
                return base.IsNull(this.reportDailyLVDataTable_0.NetRegionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_47()
            {
                base[this.reportDailyLVDataTable_0.NetRegionColumn] = Convert.DBNull;
            }

            public void method_5(string string_0)
            {
                base[this.reportDailyLVDataTable_0.defectLocationColumn] = string_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.reportDailyLVDataTable_0.idSchmObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idSchmObj' in table 'ReportDailyLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.reportDailyLVDataTable_0.idSchmObjColumn] = int_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyLVDataTable_0.schmObjNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'schmObjName' in table 'ReportDailyLV' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.reportDailyLVDataTable_0.schmObjNameColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.reportDailyLVDataTable_0.idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'id' in table 'ReportDailyLV' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.reportDailyLVDataTable_0.idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Reason
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.reportDailyLVDataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Reason' in table 'ReportDailyLV' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.reportDailyLVDataTable_0.ReasonColumn] = value;
                }
            }
        }

        public class Class334 : DataRow
        {
            private DataSetDamage.tJ_TemperatureDataTable tJ_TemperatureDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class334(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_TemperatureDataTable_0 = (DataSetDamage.tJ_TemperatureDataTable) base.Table;
            }

            public DateTime method_0()
            {
                return (DateTime) base[this.tJ_TemperatureDataTable_0.DateTempColumn];
            }

            public void method_1(DateTime dateTime_0)
            {
                base[this.tJ_TemperatureDataTable_0.DateTempColumn] = dateTime_0;
            }

            public short method_10()
            {
                short num;
                try
                {
                    num = (short) base[this.tJ_TemperatureDataTable_0.TempAverageColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TempAverage' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(short short_0)
            {
                base[this.tJ_TemperatureDataTable_0.TempAverageColumn] = short_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_TemperatureDataTable_0.WindColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Wind' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.tJ_TemperatureDataTable_0.WindColumn] = int_0;
            }

            public short method_14()
            {
                short num;
                try
                {
                    num = (short) base[this.tJ_TemperatureDataTable_0.SpeedDownColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'SpeedDown' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(short short_0)
            {
                base[this.tJ_TemperatureDataTable_0.SpeedDownColumn] = short_0;
            }

            public short method_16()
            {
                short num;
                try
                {
                    num = (short) base[this.tJ_TemperatureDataTable_0.SpeedUpColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'SpeedUp' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_17(short short_0)
            {
                base[this.tJ_TemperatureDataTable_0.SpeedUpColumn] = short_0;
            }

            public DateTime method_18()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_TemperatureDataTable_0.DateOwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateOwner' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return time;
            }

            public void method_19(DateTime dateTime_0)
            {
                base[this.tJ_TemperatureDataTable_0.DateOwnerColumn] = dateTime_0;
            }

            public short method_2()
            {
                short num;
                try
                {
                    num = (short) base[this.tJ_TemperatureDataTable_0.NightDownColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NightDown' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public int method_20()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_TemperatureDataTable_0.idOwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idOwner' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_21(int int_0)
            {
                base[this.tJ_TemperatureDataTable_0.idOwnerColumn] = int_0;
            }

            public string method_22()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_TemperatureDataTable_0.OwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Owner' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return str;
            }

            public void method_23(string string_0)
            {
                base[this.tJ_TemperatureDataTable_0.OwnerColumn] = string_0;
            }

            public string method_24()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_TemperatureDataTable_0.NightColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Night' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return str;
            }

            public void method_25(string string_0)
            {
                base[this.tJ_TemperatureDataTable_0.NightColumn] = string_0;
            }

            public string method_26()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_TemperatureDataTable_0.DayColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Day' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return str;
            }

            public void method_27(string string_0)
            {
                base[this.tJ_TemperatureDataTable_0.DayColumn] = string_0;
            }

            public string method_28()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_TemperatureDataTable_0.SpeedColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Speed' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return str;
            }

            public void method_29(string string_0)
            {
                base[this.tJ_TemperatureDataTable_0.SpeedColumn] = string_0;
            }

            public void method_3(short short_0)
            {
                base[this.tJ_TemperatureDataTable_0.NightDownColumn] = short_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_30()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.NightDownColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.tJ_TemperatureDataTable_0.NightDownColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_32()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.NightUpColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_33()
            {
                base[this.tJ_TemperatureDataTable_0.NightUpColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_34()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.DayDownColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_35()
            {
                base[this.tJ_TemperatureDataTable_0.DayDownColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_36()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.DayUpColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_37()
            {
                base[this.tJ_TemperatureDataTable_0.DayUpColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_38()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.TempAverageColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_39()
            {
                base[this.tJ_TemperatureDataTable_0.TempAverageColumn] = Convert.DBNull;
            }

            public short method_4()
            {
                short num;
                try
                {
                    num = (short) base[this.tJ_TemperatureDataTable_0.NightUpColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NightUp' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_40()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.WindColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_41()
            {
                base[this.tJ_TemperatureDataTable_0.WindColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_42()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.SpeedDownColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_43()
            {
                base[this.tJ_TemperatureDataTable_0.SpeedDownColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_44()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.SpeedUpColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_45()
            {
                base[this.tJ_TemperatureDataTable_0.SpeedUpColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_46()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.CommentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.tJ_TemperatureDataTable_0.CommentColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_48()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.DateOwnerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_49()
            {
                base[this.tJ_TemperatureDataTable_0.DateOwnerColumn] = Convert.DBNull;
            }

            public void method_5(short short_0)
            {
                base[this.tJ_TemperatureDataTable_0.NightUpColumn] = short_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_50()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.idOwnerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.tJ_TemperatureDataTable_0.idOwnerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_52()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.OwnerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_53()
            {
                base[this.tJ_TemperatureDataTable_0.OwnerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_54()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.NightColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_55()
            {
                base[this.tJ_TemperatureDataTable_0.NightColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.DayColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_57()
            {
                base[this.tJ_TemperatureDataTable_0.DayColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_58()
            {
                return base.IsNull(this.tJ_TemperatureDataTable_0.SpeedColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_59()
            {
                base[this.tJ_TemperatureDataTable_0.SpeedColumn] = Convert.DBNull;
            }

            public short method_6()
            {
                short num;
                try
                {
                    num = (short) base[this.tJ_TemperatureDataTable_0.DayDownColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DayDown' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(short short_0)
            {
                base[this.tJ_TemperatureDataTable_0.DayDownColumn] = short_0;
            }

            public short method_8()
            {
                short num;
                try
                {
                    num = (short) base[this.tJ_TemperatureDataTable_0.DayUpColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DayUp' in table 'tJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(short short_0)
            {
                base[this.tJ_TemperatureDataTable_0.DayUpColumn] = short_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tJ_TemperatureDataTable_0.CommentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Comment' in table 'tJ_Temperature' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tJ_TemperatureDataTable_0.CommentColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_TemperatureDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_TemperatureDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class335 : DataRow
        {
            private DataSetDamage.vJ_TemperatureDataTable vJ_TemperatureDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class335(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vJ_TemperatureDataTable_0 = (DataSetDamage.vJ_TemperatureDataTable) base.Table;
            }

            public DateTime method_0()
            {
                return (DateTime) base[this.vJ_TemperatureDataTable_0.DateTempColumn];
            }

            public void method_1(DateTime dateTime_0)
            {
                base[this.vJ_TemperatureDataTable_0.DateTempColumn] = dateTime_0;
            }

            public short method_10()
            {
                short num;
                try
                {
                    num = (short) base[this.vJ_TemperatureDataTable_0.TempAverageColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TempAverage' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(short short_0)
            {
                base[this.vJ_TemperatureDataTable_0.TempAverageColumn] = short_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_TemperatureDataTable_0.WindColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Wind' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.vJ_TemperatureDataTable_0.WindColumn] = int_0;
            }

            public string method_14()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_TemperatureDataTable_0.WindNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'WindName' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return str;
            }

            public void method_15(string string_0)
            {
                base[this.vJ_TemperatureDataTable_0.WindNameColumn] = string_0;
            }

            public short method_16()
            {
                short num;
                try
                {
                    num = (short) base[this.vJ_TemperatureDataTable_0.SpeedDownColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'SpeedDown' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_17(short short_0)
            {
                base[this.vJ_TemperatureDataTable_0.SpeedDownColumn] = short_0;
            }

            public short method_18()
            {
                short num;
                try
                {
                    num = (short) base[this.vJ_TemperatureDataTable_0.SpeedUpColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'SpeedUp' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_19(short short_0)
            {
                base[this.vJ_TemperatureDataTable_0.SpeedUpColumn] = short_0;
            }

            public short method_2()
            {
                short num;
                try
                {
                    num = (short) base[this.vJ_TemperatureDataTable_0.NightDownColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NightDown' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public DateTime method_20()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_TemperatureDataTable_0.DateOwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateOwner' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return time;
            }

            public void method_21(DateTime dateTime_0)
            {
                base[this.vJ_TemperatureDataTable_0.DateOwnerColumn] = dateTime_0;
            }

            public int method_22()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_TemperatureDataTable_0.idOwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idOwner' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_23(int int_0)
            {
                base[this.vJ_TemperatureDataTable_0.idOwnerColumn] = int_0;
            }

            public string method_24()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_TemperatureDataTable_0.OwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Owner' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return str;
            }

            public void method_25(string string_0)
            {
                base[this.vJ_TemperatureDataTable_0.OwnerColumn] = string_0;
            }

            public string method_26()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_TemperatureDataTable_0.NightColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Night' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return str;
            }

            public void method_27(string string_0)
            {
                base[this.vJ_TemperatureDataTable_0.NightColumn] = string_0;
            }

            public string method_28()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_TemperatureDataTable_0.DayColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Day' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return str;
            }

            public void method_29(string string_0)
            {
                base[this.vJ_TemperatureDataTable_0.DayColumn] = string_0;
            }

            public void method_3(short short_0)
            {
                base[this.vJ_TemperatureDataTable_0.NightDownColumn] = short_0;
            }

            public string method_30()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_TemperatureDataTable_0.SpeedColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Speed' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return str;
            }

            public void method_31(string string_0)
            {
                base[this.vJ_TemperatureDataTable_0.SpeedColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_32()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.NightDownColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_33()
            {
                base[this.vJ_TemperatureDataTable_0.NightDownColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_34()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.NightUpColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_35()
            {
                base[this.vJ_TemperatureDataTable_0.NightUpColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_36()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.DayDownColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_37()
            {
                base[this.vJ_TemperatureDataTable_0.DayDownColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_38()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.DayUpColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_39()
            {
                base[this.vJ_TemperatureDataTable_0.DayUpColumn] = Convert.DBNull;
            }

            public short method_4()
            {
                short num;
                try
                {
                    num = (short) base[this.vJ_TemperatureDataTable_0.NightUpColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NightUp' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_40()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.TempAverageColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_41()
            {
                base[this.vJ_TemperatureDataTable_0.TempAverageColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.WindColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_43()
            {
                base[this.vJ_TemperatureDataTable_0.WindColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_44()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.WindNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_45()
            {
                base[this.vJ_TemperatureDataTable_0.WindNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_46()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.SpeedDownColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.vJ_TemperatureDataTable_0.SpeedDownColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_48()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.SpeedUpColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_49()
            {
                base[this.vJ_TemperatureDataTable_0.SpeedUpColumn] = Convert.DBNull;
            }

            public void method_5(short short_0)
            {
                base[this.vJ_TemperatureDataTable_0.NightUpColumn] = short_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.CommentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_51()
            {
                base[this.vJ_TemperatureDataTable_0.CommentColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_52()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.DateOwnerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_53()
            {
                base[this.vJ_TemperatureDataTable_0.DateOwnerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_54()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.idOwnerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_55()
            {
                base[this.vJ_TemperatureDataTable_0.idOwnerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.OwnerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_57()
            {
                base[this.vJ_TemperatureDataTable_0.OwnerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_58()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.NightColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_59()
            {
                base[this.vJ_TemperatureDataTable_0.NightColumn] = Convert.DBNull;
            }

            public short method_6()
            {
                short num;
                try
                {
                    num = (short) base[this.vJ_TemperatureDataTable_0.DayDownColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DayDown' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_60()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.DayColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_61()
            {
                base[this.vJ_TemperatureDataTable_0.DayColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_62()
            {
                return base.IsNull(this.vJ_TemperatureDataTable_0.SpeedColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_63()
            {
                base[this.vJ_TemperatureDataTable_0.SpeedColumn] = Convert.DBNull;
            }

            public void method_7(short short_0)
            {
                base[this.vJ_TemperatureDataTable_0.DayDownColumn] = short_0;
            }

            public short method_8()
            {
                short num;
                try
                {
                    num = (short) base[this.vJ_TemperatureDataTable_0.DayUpColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DayUp' in table 'vJ_Temperature' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(short short_0)
            {
                base[this.vJ_TemperatureDataTable_0.DayUpColumn] = short_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vJ_TemperatureDataTable_0.CommentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Comment' in table 'vJ_Temperature' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vJ_TemperatureDataTable_0.CommentColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vJ_TemperatureDataTable_0.idColumn];
                }
                set
                {
                    base[this.vJ_TemperatureDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class336 : DataRow
        {
            private DataSetDamage.tReportIterruptLVDataTable tReportIterruptLVDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class336(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tReportIterruptLVDataTable_0 = (DataSetDamage.tReportIterruptLVDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.numNetRegionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'numNetRegion' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.numNetRegionColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c14Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c14' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_100()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c19Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_101()
            {
                base[this.tReportIterruptLVDataTable_0.c19Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_102()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c21Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_103()
            {
                base[this.tReportIterruptLVDataTable_0.c21Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_104()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c22Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_105()
            {
                base[this.tReportIterruptLVDataTable_0.c22Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_106()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c23Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_107()
            {
                base[this.tReportIterruptLVDataTable_0.c23Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_108()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c24Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_109()
            {
                base[this.tReportIterruptLVDataTable_0.c24Column] = Convert.DBNull;
            }

            public void method_11(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c14Column] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_110()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c25Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_111()
            {
                base[this.tReportIterruptLVDataTable_0.c25Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_112()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c26Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_113()
            {
                base[this.tReportIterruptLVDataTable_0.c26Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_114()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c27Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_115()
            {
                base[this.tReportIterruptLVDataTable_0.c27Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_116()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c31Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_117()
            {
                base[this.tReportIterruptLVDataTable_0.c31Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_118()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c32Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_119()
            {
                base[this.tReportIterruptLVDataTable_0.c32Column] = Convert.DBNull;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c15Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c15' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_120()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c33Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_121()
            {
                base[this.tReportIterruptLVDataTable_0.c33Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_122()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c34Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_123()
            {
                base[this.tReportIterruptLVDataTable_0.c34Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_124()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c35Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_125()
            {
                base[this.tReportIterruptLVDataTable_0.c35Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_126()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c36Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_127()
            {
                base[this.tReportIterruptLVDataTable_0.c36Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_128()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c37Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_129()
            {
                base[this.tReportIterruptLVDataTable_0.c37Column] = Convert.DBNull;
            }

            public void method_13(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c15Column] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_130()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c41Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_131()
            {
                base[this.tReportIterruptLVDataTable_0.c41Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_132()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c42Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_133()
            {
                base[this.tReportIterruptLVDataTable_0.c42Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_134()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c43Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_135()
            {
                base[this.tReportIterruptLVDataTable_0.c43Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_136()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c44Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_137()
            {
                base[this.tReportIterruptLVDataTable_0.c44Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_138()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c45Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_139()
            {
                base[this.tReportIterruptLVDataTable_0.c45Column] = Convert.DBNull;
            }

            public int method_14()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c16Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c16' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_140()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c46Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_141()
            {
                base[this.tReportIterruptLVDataTable_0.c46Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_142()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c51Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_143()
            {
                base[this.tReportIterruptLVDataTable_0.c51Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_144()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c52Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_145()
            {
                base[this.tReportIterruptLVDataTable_0.c52Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_146()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c53Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_147()
            {
                base[this.tReportIterruptLVDataTable_0.c53Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_148()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c54Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_149()
            {
                base[this.tReportIterruptLVDataTable_0.c54Column] = Convert.DBNull;
            }

            public void method_15(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c16Column] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_150()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c55Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_151()
            {
                base[this.tReportIterruptLVDataTable_0.c55Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_152()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c56Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_153()
            {
                base[this.tReportIterruptLVDataTable_0.c56Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_154()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c57Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_155()
            {
                base[this.tReportIterruptLVDataTable_0.c57Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_156()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c61Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_157()
            {
                base[this.tReportIterruptLVDataTable_0.c61Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_158()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c62Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_159()
            {
                base[this.tReportIterruptLVDataTable_0.c62Column] = Convert.DBNull;
            }

            public int method_16()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c17Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c17' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_17(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c17Column] = int_0;
            }

            public int method_18()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c18Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c18' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_19(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c18Column] = int_0;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.tReportIterruptLVDataTable_0.netRegionValueColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'netRegionValue' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return str;
            }

            public int method_20()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c19Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c19' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_21(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c19Column] = int_0;
            }

            public int method_22()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c21Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c21' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_23(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c21Column] = int_0;
            }

            public int method_24()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c22Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c22' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_25(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c22Column] = int_0;
            }

            public int method_26()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c23Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c23' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_27(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c23Column] = int_0;
            }

            public int method_28()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c24Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c24' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_29(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c24Column] = int_0;
            }

            public void method_3(string string_0)
            {
                base[this.tReportIterruptLVDataTable_0.netRegionValueColumn] = string_0;
            }

            public int method_30()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c25Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c25' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_31(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c25Column] = int_0;
            }

            public int method_32()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c26Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c26' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_33(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c26Column] = int_0;
            }

            public int method_34()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c27Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c27' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_35(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c27Column] = int_0;
            }

            public int method_36()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c31Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c31' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_37(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c31Column] = int_0;
            }

            public int method_38()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c32Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c32' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_39(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c32Column] = int_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c11Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c11' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public int method_40()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c33Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c33' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_41(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c33Column] = int_0;
            }

            public int method_42()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c34Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c34' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_43(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c34Column] = int_0;
            }

            public int method_44()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c35Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c35' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_45(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c35Column] = int_0;
            }

            public int method_46()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c36Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c36' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_47(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c36Column] = int_0;
            }

            public int method_48()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c37Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c37' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_49(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c37Column] = int_0;
            }

            public void method_5(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c11Column] = int_0;
            }

            public int method_50()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c41Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c41' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_51(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c41Column] = int_0;
            }

            public int method_52()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c42Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c42' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_53(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c42Column] = int_0;
            }

            public int method_54()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c43Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c43' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_55(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c43Column] = int_0;
            }

            public int method_56()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c44Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c44' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_57(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c44Column] = int_0;
            }

            public int method_58()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c45Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c45' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_59(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c45Column] = int_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c12Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c12' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public int method_60()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c46Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c46' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_61(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c46Column] = int_0;
            }

            public int method_62()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c51Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c51' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_63(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c51Column] = int_0;
            }

            public int method_64()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c52Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c52' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_65(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c52Column] = int_0;
            }

            public int method_66()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c53Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c53' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_67(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c53Column] = int_0;
            }

            public int method_68()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c54Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c54' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_69(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c54Column] = int_0;
            }

            public void method_7(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c12Column] = int_0;
            }

            public int method_70()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c55Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c55' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_71(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c55Column] = int_0;
            }

            public int method_72()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c56Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c56' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_73(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c56Column] = int_0;
            }

            public int method_74()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c57Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c57' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_75(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c57Column] = int_0;
            }

            public int method_76()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c61Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c61' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_77(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c61Column] = int_0;
            }

            public int method_78()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c62Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c62' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            public void method_79(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c62Column] = int_0;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportIterruptLVDataTable_0.c13Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'c13' in table 'tReportIterruptLV' is DBNull.", exception);
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_80()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.numNetRegionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_81()
            {
                base[this.tReportIterruptLVDataTable_0.numNetRegionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_82()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.netRegionValueColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_83()
            {
                base[this.tReportIterruptLVDataTable_0.netRegionValueColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_84()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c11Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_85()
            {
                base[this.tReportIterruptLVDataTable_0.c11Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_86()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c12Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_87()
            {
                base[this.tReportIterruptLVDataTable_0.c12Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_88()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c13Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_89()
            {
                base[this.tReportIterruptLVDataTable_0.c13Column] = Convert.DBNull;
            }

            public void method_9(int int_0)
            {
                base[this.tReportIterruptLVDataTable_0.c13Column] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_90()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c14Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_91()
            {
                base[this.tReportIterruptLVDataTable_0.c14Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_92()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c15Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_93()
            {
                base[this.tReportIterruptLVDataTable_0.c15Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_94()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c16Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_95()
            {
                base[this.tReportIterruptLVDataTable_0.c16Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_96()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c17Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_97()
            {
                base[this.tReportIterruptLVDataTable_0.c17Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_98()
            {
                return base.IsNull(this.tReportIterruptLVDataTable_0.c18Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_99()
            {
                base[this.tReportIterruptLVDataTable_0.c18Column] = Convert.DBNull;
            }
        }

        public class Class337 : DataRow
        {
            private DataSetDamage.ReportDailyDefectDataTable reportDailyDefectDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class337(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.reportDailyDefectDataTable_0 = (DataSetDamage.ReportDailyDefectDataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyDefectDataTable_0.numRequestColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'numRequest' in table 'ReportDailyDefect' is DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.reportDailyDefectDataTable_0.numRequestColumn] = string_0;
            }

            public string method_10()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyDefectDataTable_0.numRequestParentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'numRequestParent' in table 'ReportDailyDefect' is DBNull.", exception);
                }
                return str;
            }

            public void method_11(string string_0)
            {
                base[this.reportDailyDefectDataTable_0.numRequestParentColumn] = string_0;
            }

            public DateTime method_12()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.reportDailyDefectDataTable_0.dateDocParentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateDocParent' in table 'ReportDailyDefect' is DBNull.", exception);
                }
                return time;
            }

            public void method_13(DateTime dateTime_0)
            {
                base[this.reportDailyDefectDataTable_0.dateDocParentColumn] = dateTime_0;
            }

            public string method_14()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyDefectDataTable_0.typeDocParentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeDocParent' in table 'ReportDailyDefect' is DBNull.", exception);
                }
                return str;
            }

            public void method_15(string string_0)
            {
                base[this.reportDailyDefectDataTable_0.typeDocParentColumn] = string_0;
            }

            public bool method_16()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.reportDailyDefectDataTable_0.isApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isApply' in table 'ReportDailyDefect' is DBNull.", exception);
                }
                return flag;
            }

            public void method_17(bool bool_0)
            {
                base[this.reportDailyDefectDataTable_0.isApplyColumn] = bool_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.reportDailyDefectDataTable_0.idColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.reportDailyDefectDataTable_0.idColumn] = Convert.DBNull;
            }

            public DateTime method_2()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.reportDailyDefectDataTable_0.dateDocColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateDoc' in table 'ReportDailyDefect' is DBNull.", exception);
                }
                return time;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.reportDailyDefectDataTable_0.numRequestColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_21()
            {
                base[this.reportDailyDefectDataTable_0.numRequestColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_22()
            {
                return base.IsNull(this.reportDailyDefectDataTable_0.dateDocColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_23()
            {
                base[this.reportDailyDefectDataTable_0.dateDocColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_24()
            {
                return base.IsNull(this.reportDailyDefectDataTable_0.idDivisionApplyColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.reportDailyDefectDataTable_0.idDivisionApplyColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_26()
            {
                return base.IsNull(this.reportDailyDefectDataTable_0.DivisionApplyColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_27()
            {
                base[this.reportDailyDefectDataTable_0.DivisionApplyColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_28()
            {
                return base.IsNull(this.reportDailyDefectDataTable_0.DivisionInstructionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_29()
            {
                base[this.reportDailyDefectDataTable_0.DivisionInstructionColumn] = Convert.DBNull;
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.reportDailyDefectDataTable_0.dateDocColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_30()
            {
                return base.IsNull(this.reportDailyDefectDataTable_0.ValueColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.reportDailyDefectDataTable_0.ValueColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_32()
            {
                return base.IsNull(this.reportDailyDefectDataTable_0.numRequestParentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_33()
            {
                base[this.reportDailyDefectDataTable_0.numRequestParentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_34()
            {
                return base.IsNull(this.reportDailyDefectDataTable_0.dateDocParentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_35()
            {
                base[this.reportDailyDefectDataTable_0.dateDocParentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_36()
            {
                return base.IsNull(this.reportDailyDefectDataTable_0.typeDocParentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_37()
            {
                base[this.reportDailyDefectDataTable_0.typeDocParentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_38()
            {
                return base.IsNull(this.reportDailyDefectDataTable_0.isApplyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_39()
            {
                base[this.reportDailyDefectDataTable_0.isApplyColumn] = Convert.DBNull;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.reportDailyDefectDataTable_0.idDivisionApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idDivisionApply' in table 'ReportDailyDefect' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.reportDailyDefectDataTable_0.idDivisionApplyColumn] = int_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyDefectDataTable_0.DivisionApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DivisionApply' in table 'ReportDailyDefect' is DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.reportDailyDefectDataTable_0.DivisionApplyColumn] = string_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyDefectDataTable_0.DivisionInstructionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DivisionInstruction' in table 'ReportDailyDefect' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.reportDailyDefectDataTable_0.DivisionInstructionColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.reportDailyDefectDataTable_0.idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'id' in table 'ReportDailyDefect' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.reportDailyDefectDataTable_0.idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public decimal Value
            {
                get
                {
                    decimal num;
                    try
                    {
                        num = (decimal) base[this.reportDailyDefectDataTable_0.ValueColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Value' in table 'ReportDailyDefect' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.reportDailyDefectDataTable_0.ValueColumn] = value;
                }
            }
        }

        public class Class338 : DataRow
        {
            private DataSetDamage.vJ_DamageDataTable vJ_DamageDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class338(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vJ_DamageDataTable_0 = (DataSetDamage.vJ_DamageDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_DamageDataTable_0.numDocColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'numDoc' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.vJ_DamageDataTable_0.numDocColumn] = int_0;
            }

            public string method_10()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.TypeDocNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TypeDocName' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_100()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.idCompilerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_101()
            {
                base[this.vJ_DamageDataTable_0.idCompilerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_102()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.compilerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_103()
            {
                base[this.vJ_DamageDataTable_0.compilerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_104()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.idDivisionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_105()
            {
                base[this.vJ_DamageDataTable_0.idDivisionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_106()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.DivisionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_107()
            {
                base[this.vJ_DamageDataTable_0.DivisionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_108()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.idSchmObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_109()
            {
                base[this.vJ_DamageDataTable_0.idSchmObjColumn] = Convert.DBNull;
            }

            public void method_11(string string_0)
            {
                base[this.vJ_DamageDataTable_0.TypeDocNameColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_110()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.schmObjNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_111()
            {
                base[this.vJ_DamageDataTable_0.schmObjNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_112()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.idSubColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_113()
            {
                base[this.vJ_DamageDataTable_0.idSubColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_114()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.NetRegionSubColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_115()
            {
                base[this.vJ_DamageDataTable_0.NetRegionSubColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_116()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.idMapColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_117()
            {
                base[this.vJ_DamageDataTable_0.idMapColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_118()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.defectLocationColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_119()
            {
                base[this.vJ_DamageDataTable_0.defectLocationColumn] = Convert.DBNull;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_DamageDataTable_0.idCompilerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idCompiler' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_120()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.idReasonColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_121()
            {
                base[this.vJ_DamageDataTable_0.idReasonColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_122()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.ReasonColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_123()
            {
                base[this.vJ_DamageDataTable_0.ReasonColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_124()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.idCompletedWorkColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_125()
            {
                base[this.vJ_DamageDataTable_0.idCompletedWorkColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_126()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.completedWorkColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_127()
            {
                base[this.vJ_DamageDataTable_0.completedWorkColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_128()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.ComletedWorkTextColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_129()
            {
                base[this.vJ_DamageDataTable_0.ComletedWorkTextColumn] = Convert.DBNull;
            }

            public void method_13(int int_0)
            {
                base[this.vJ_DamageDataTable_0.idCompilerColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_130()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.isApplyColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_131()
            {
                base[this.vJ_DamageDataTable_0.isApplyColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_132()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.idWorkerApplyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_133()
            {
                base[this.vJ_DamageDataTable_0.idWorkerApplyColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_134()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.workerApplyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_135()
            {
                base[this.vJ_DamageDataTable_0.workerApplyColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_136()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.dateApplyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_137()
            {
                base[this.vJ_DamageDataTable_0.dateApplyColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_138()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.idDivisionApplyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_139()
            {
                base[this.vJ_DamageDataTable_0.idDivisionApplyColumn] = Convert.DBNull;
            }

            public string method_14()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.compilerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'compiler' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_140()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.DivisionApplyColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_141()
            {
                base[this.vJ_DamageDataTable_0.DivisionApplyColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_142()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.isLaboratoryColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_143()
            {
                base[this.vJ_DamageDataTable_0.isLaboratoryColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_144()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.idParentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_145()
            {
                base[this.vJ_DamageDataTable_0.idParentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_146()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.ownerNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_147()
            {
                base[this.vJ_DamageDataTable_0.ownerNameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_148()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.dateOwnerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_149()
            {
                base[this.vJ_DamageDataTable_0.dateOwnerColumn] = Convert.DBNull;
            }

            public void method_15(string string_0)
            {
                base[this.vJ_DamageDataTable_0.compilerColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_150()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.KodPTSStrColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_151()
            {
                base[this.vJ_DamageDataTable_0.KodPTSStrColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_152()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.KodPTSColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_153()
            {
                base[this.vJ_DamageDataTable_0.KodPTSColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_154()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.InstructionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_155()
            {
                base[this.vJ_DamageDataTable_0.InstructionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_156()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.idReqForRepairColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_157()
            {
                base[this.vJ_DamageDataTable_0.idReqForRepairColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_158()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.deletedColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_159()
            {
                base[this.vJ_DamageDataTable_0.deletedColumn] = Convert.DBNull;
            }

            public int method_16()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_DamageDataTable_0.idDivisionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idDivision' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_160()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.numcrashColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_161()
            {
                base[this.vJ_DamageDataTable_0.numcrashColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_162()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.signCrashTypeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_163()
            {
                base[this.vJ_DamageDataTable_0.signCrashTypeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_164()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.signCrashNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_165()
            {
                base[this.vJ_DamageDataTable_0.signCrashNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_166()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.typeEquipColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_167()
            {
                base[this.vJ_DamageDataTable_0.typeEquipColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_168()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.typeEquipNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_169()
            {
                base[this.vJ_DamageDataTable_0.typeEquipNameColumn] = Convert.DBNull;
            }

            public void method_17(int int_0)
            {
                base[this.vJ_DamageDataTable_0.idDivisionColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_170()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.reasonCrashEquipTypeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_171()
            {
                base[this.vJ_DamageDataTable_0.reasonCrashEquipTypeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_172()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.reasonCrashEquipNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_173()
            {
                base[this.vJ_DamageDataTable_0.reasonCrashEquipNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_174()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.reasonCrashTypeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_175()
            {
                base[this.vJ_DamageDataTable_0.reasonCrashTypeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_176()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.reasonCrashNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_177()
            {
                base[this.vJ_DamageDataTable_0.reasonCrashNameColumn] = Convert.DBNull;
            }

            public string method_18()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.DivisionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Division' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_19(string string_0)
            {
                base[this.vJ_DamageDataTable_0.DivisionColumn] = string_0;
            }

            public DateTime method_2()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_DamageDataTable_0.dateDocColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateDoc' in table 'vJ_Damage' is DBNull.", exception);
                }
                return time;
            }

            public int method_20()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_DamageDataTable_0.idSchmObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idSchmObj' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_21(int int_0)
            {
                base[this.vJ_DamageDataTable_0.idSchmObjColumn] = int_0;
            }

            public string method_22()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.schmObjNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'schmObjName' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_23(string string_0)
            {
                base[this.vJ_DamageDataTable_0.schmObjNameColumn] = string_0;
            }

            public int method_24()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_DamageDataTable_0.idSubColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idSub' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_25(int int_0)
            {
                base[this.vJ_DamageDataTable_0.idSubColumn] = int_0;
            }

            public string method_26()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.NetRegionSubColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NetRegionSub' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_27(string string_0)
            {
                base[this.vJ_DamageDataTable_0.NetRegionSubColumn] = string_0;
            }

            public int method_28()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_DamageDataTable_0.idMapColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idMap' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_29(int int_0)
            {
                base[this.vJ_DamageDataTable_0.idMapColumn] = int_0;
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.vJ_DamageDataTable_0.dateDocColumn] = dateTime_0;
            }

            public string method_30()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.defectLocationColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'defectLocation' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_31(string string_0)
            {
                base[this.vJ_DamageDataTable_0.defectLocationColumn] = string_0;
            }

            public int method_32()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_DamageDataTable_0.idReasonColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idReason' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_33(int int_0)
            {
                base[this.vJ_DamageDataTable_0.idReasonColumn] = int_0;
            }

            public int method_34()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_DamageDataTable_0.idCompletedWorkColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idCompletedWork' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_35(int int_0)
            {
                base[this.vJ_DamageDataTable_0.idCompletedWorkColumn] = int_0;
            }

            public string method_36()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.completedWorkColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'completedWork' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_37(string string_0)
            {
                base[this.vJ_DamageDataTable_0.completedWorkColumn] = string_0;
            }

            public string method_38()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.ComletedWorkTextColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ComletedWorkText' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_39(string string_0)
            {
                base[this.vJ_DamageDataTable_0.ComletedWorkTextColumn] = string_0;
            }

            public DateTime method_4()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_DamageDataTable_0.datePlanEndColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'datePlanEnd' in table 'vJ_Damage' is DBNull.", exception);
                }
                return time;
            }

            public bool method_40()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.vJ_DamageDataTable_0.isApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isApply' in table 'vJ_Damage' is DBNull.", exception);
                }
                return flag;
            }

            public void method_41(bool bool_0)
            {
                base[this.vJ_DamageDataTable_0.isApplyColumn] = bool_0;
            }

            public int method_42()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_DamageDataTable_0.idWorkerApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idWorkerApply' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_43(int int_0)
            {
                base[this.vJ_DamageDataTable_0.idWorkerApplyColumn] = int_0;
            }

            public string method_44()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.workerApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'workerApply' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_45(string string_0)
            {
                base[this.vJ_DamageDataTable_0.workerApplyColumn] = string_0;
            }

            public DateTime method_46()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_DamageDataTable_0.dateApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateApply' in table 'vJ_Damage' is DBNull.", exception);
                }
                return time;
            }

            public void method_47(DateTime dateTime_0)
            {
                base[this.vJ_DamageDataTable_0.dateApplyColumn] = dateTime_0;
            }

            public int method_48()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_DamageDataTable_0.idDivisionApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idDivisionApply' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_49(int int_0)
            {
                base[this.vJ_DamageDataTable_0.idDivisionApplyColumn] = int_0;
            }

            public void method_5(DateTime dateTime_0)
            {
                base[this.vJ_DamageDataTable_0.datePlanEndColumn] = dateTime_0;
            }

            public string method_50()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.DivisionApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DivisionApply' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_51(string string_0)
            {
                base[this.vJ_DamageDataTable_0.DivisionApplyColumn] = string_0;
            }

            public bool method_52()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.vJ_DamageDataTable_0.isLaboratoryColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isLaboratory' in table 'vJ_Damage' is DBNull.", exception);
                }
                return flag;
            }

            public void method_53(bool bool_0)
            {
                base[this.vJ_DamageDataTable_0.isLaboratoryColumn] = bool_0;
            }

            public int method_54()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_DamageDataTable_0.idParentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idParent' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_55(int int_0)
            {
                base[this.vJ_DamageDataTable_0.idParentColumn] = int_0;
            }

            public string method_56()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.ownerNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ownerName' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_57(string string_0)
            {
                base[this.vJ_DamageDataTable_0.ownerNameColumn] = string_0;
            }

            public DateTime method_58()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_DamageDataTable_0.dateOwnerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateOwner' in table 'vJ_Damage' is DBNull.", exception);
                }
                return time;
            }

            public void method_59(DateTime dateTime_0)
            {
                base[this.vJ_DamageDataTable_0.dateOwnerColumn] = dateTime_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.numrequestColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'numrequest' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public string method_60()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.KodPTSStrColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'KodPTSStr' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_61(string string_0)
            {
                base[this.vJ_DamageDataTable_0.KodPTSStrColumn] = string_0;
            }

            public decimal method_62()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.vJ_DamageDataTable_0.KodPTSColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'KodPTS' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_63(decimal decimal_0)
            {
                base[this.vJ_DamageDataTable_0.KodPTSColumn] = decimal_0;
            }

            public string method_64()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.InstructionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Instruction' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_65(string string_0)
            {
                base[this.vJ_DamageDataTable_0.InstructionColumn] = string_0;
            }

            public int method_66()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_DamageDataTable_0.idReqForRepairColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idReqForRepair' in table 'vJ_Damage' is DBNull.", exception);
                }
                return num;
            }

            public void method_67(int int_0)
            {
                base[this.vJ_DamageDataTable_0.idReqForRepairColumn] = int_0;
            }

            public bool method_68()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.vJ_DamageDataTable_0.deletedColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'deleted' in table 'vJ_Damage' is DBNull.", exception);
                }
                return flag;
            }

            public void method_69(bool bool_0)
            {
                base[this.vJ_DamageDataTable_0.deletedColumn] = bool_0;
            }

            public void method_7(string string_0)
            {
                base[this.vJ_DamageDataTable_0.numrequestColumn] = string_0;
            }

            public string method_70()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.numcrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'numcrash' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_71(string string_0)
            {
                base[this.vJ_DamageDataTable_0.numcrashColumn] = string_0;
            }

            public string method_72()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.signCrashTypeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'signCrashType' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_73(string string_0)
            {
                base[this.vJ_DamageDataTable_0.signCrashTypeColumn] = string_0;
            }

            public string method_74()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.signCrashNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'signCrashName' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_75(string string_0)
            {
                base[this.vJ_DamageDataTable_0.signCrashNameColumn] = string_0;
            }

            public string method_76()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.typeEquipColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeEquip' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_77(string string_0)
            {
                base[this.vJ_DamageDataTable_0.typeEquipColumn] = string_0;
            }

            public string method_78()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.typeEquipNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeEquipName' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_79(string string_0)
            {
                base[this.vJ_DamageDataTable_0.typeEquipNameColumn] = string_0;
            }

            public int method_8()
            {
                return (int) base[this.vJ_DamageDataTable_0.TypeDocColumn];
            }

            public string method_80()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.reasonCrashEquipTypeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'reasonCrashEquipType' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_81(string string_0)
            {
                base[this.vJ_DamageDataTable_0.reasonCrashEquipTypeColumn] = string_0;
            }

            public string method_82()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.reasonCrashEquipNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'reasonCrashEquipName' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_83(string string_0)
            {
                base[this.vJ_DamageDataTable_0.reasonCrashEquipNameColumn] = string_0;
            }

            public string method_84()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.reasonCrashTypeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'reasonCrashType' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_85(string string_0)
            {
                base[this.vJ_DamageDataTable_0.reasonCrashTypeColumn] = string_0;
            }

            public string method_86()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_DamageDataTable_0.reasonCrashNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'reasonCrashName' in table 'vJ_Damage' is DBNull.", exception);
                }
                return str;
            }

            public void method_87(string string_0)
            {
                base[this.vJ_DamageDataTable_0.reasonCrashNameColumn] = string_0;
            }

            public bool method_88()
            {
                return (bool) base[this.vJ_DamageDataTable_0.isNoSESNOColumn];
            }

            public void method_89(bool bool_0)
            {
                base[this.vJ_DamageDataTable_0.isNoSESNOColumn] = bool_0;
            }

            public void method_9(int int_0)
            {
                base[this.vJ_DamageDataTable_0.TypeDocColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_90()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.numDocColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_91()
            {
                base[this.vJ_DamageDataTable_0.numDocColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_92()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.dateDocColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_93()
            {
                base[this.vJ_DamageDataTable_0.dateDocColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_94()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.datePlanEndColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_95()
            {
                base[this.vJ_DamageDataTable_0.datePlanEndColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_96()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.numrequestColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_97()
            {
                base[this.vJ_DamageDataTable_0.numrequestColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_98()
            {
                return base.IsNull(this.vJ_DamageDataTable_0.TypeDocNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_99()
            {
                base[this.vJ_DamageDataTable_0.TypeDocNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vJ_DamageDataTable_0.idColumn];
                }
                set
                {
                    base[this.vJ_DamageDataTable_0.idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Reason
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vJ_DamageDataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Reason' in table 'vJ_Damage' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vJ_DamageDataTable_0.ReasonColumn] = value;
                }
            }
        }

        public class Class339 : DataRow
        {
            private DataSetDamage.ReportDailyHVDataTable reportDailyHVDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class339(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.reportDailyHVDataTable_0 = (DataSetDamage.ReportDailyHVDataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyHVDataTable_0.numRequestColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'numRequest' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.reportDailyHVDataTable_0.numRequestColumn] = string_0;
            }

            public decimal method_10()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.reportDailyHVDataTable_0.ConnectedPowerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ConnectedPower' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(decimal decimal_0)
            {
                base[this.reportDailyHVDataTable_0.ConnectedPowerColumn] = decimal_0;
            }

            public DateTime method_12()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.reportDailyHVDataTable_0.dateDocColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateDoc' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return time;
            }

            public void method_13(DateTime dateTime_0)
            {
                base[this.reportDailyHVDataTable_0.dateDocColumn] = dateTime_0;
            }

            public DateTime method_14()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.reportDailyHVDataTable_0.dateApplyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateApply' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return time;
            }

            public void method_15(DateTime dateTime_0)
            {
                base[this.reportDailyHVDataTable_0.dateApplyColumn] = dateTime_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyHVDataTable_0.typeRZAColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeRZA' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.reportDailyHVDataTable_0.typeRZAColumn] = string_0;
            }

            public decimal method_18()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.reportDailyHVDataTable_0.NoAdmissionKWTColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NoAdmissionKWT' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return num;
            }

            public void method_19(decimal decimal_0)
            {
                base[this.reportDailyHVDataTable_0.NoAdmissionKWTColumn] = decimal_0;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyHVDataTable_0.schmObjNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'schmObjName' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return str;
            }

            public string method_20()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyHVDataTable_0.reasonAndLocationColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'reasonAndLocation' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return str;
            }

            public void method_21(string string_0)
            {
                base[this.reportDailyHVDataTable_0.reasonAndLocationColumn] = string_0;
            }

            public string method_22()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyHVDataTable_0.CharacterColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Character' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return str;
            }

            public void method_23(string string_0)
            {
                base[this.reportDailyHVDataTable_0.CharacterColumn] = string_0;
            }

            public string method_24()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyHVDataTable_0.completedWorkColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'completedWork' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return str;
            }

            public void method_25(string string_0)
            {
                base[this.reportDailyHVDataTable_0.completedWorkColumn] = string_0;
            }

            public string method_26()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyHVDataTable_0.CompilerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Compiler' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return str;
            }

            public void method_27(string string_0)
            {
                base[this.reportDailyHVDataTable_0.CompilerColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_28()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.idColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_29()
            {
                base[this.reportDailyHVDataTable_0.idColumn] = Convert.DBNull;
            }

            public void method_3(string string_0)
            {
                base[this.reportDailyHVDataTable_0.schmObjNameColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_30()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.numRequestColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.reportDailyHVDataTable_0.numRequestColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_32()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.schmObjNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_33()
            {
                base[this.reportDailyHVDataTable_0.schmObjNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_34()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.subscriberColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_35()
            {
                base[this.reportDailyHVDataTable_0.subscriberColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_36()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.PowerAColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_37()
            {
                base[this.reportDailyHVDataTable_0.PowerAColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_38()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.CountSchmObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_39()
            {
                base[this.reportDailyHVDataTable_0.CountSchmObjColumn] = Convert.DBNull;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.reportDailyHVDataTable_0.subscriberColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'subscriber' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return str;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_40()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.ConnectedPowerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_41()
            {
                base[this.reportDailyHVDataTable_0.ConnectedPowerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.dateDocColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_43()
            {
                base[this.reportDailyHVDataTable_0.dateDocColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_44()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.dateApplyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_45()
            {
                base[this.reportDailyHVDataTable_0.dateApplyColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_46()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.typeRZAColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.reportDailyHVDataTable_0.typeRZAColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_48()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.NoAdmissionKWTColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_49()
            {
                base[this.reportDailyHVDataTable_0.NoAdmissionKWTColumn] = Convert.DBNull;
            }

            public void method_5(string string_0)
            {
                base[this.reportDailyHVDataTable_0.subscriberColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.reasonAndLocationColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.reportDailyHVDataTable_0.reasonAndLocationColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_52()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.CharacterColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_53()
            {
                base[this.reportDailyHVDataTable_0.CharacterColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_54()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.completedWorkColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_55()
            {
                base[this.reportDailyHVDataTable_0.completedWorkColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_56()
            {
                return base.IsNull(this.reportDailyHVDataTable_0.CompilerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_57()
            {
                base[this.reportDailyHVDataTable_0.CompilerColumn] = Convert.DBNull;
            }

            public decimal method_6()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.reportDailyHVDataTable_0.PowerAColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'PowerA' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(decimal decimal_0)
            {
                base[this.reportDailyHVDataTable_0.PowerAColumn] = decimal_0;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.reportDailyHVDataTable_0.CountSchmObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CountSchmObj' in table 'ReportDailyHV' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(int int_0)
            {
                base[this.reportDailyHVDataTable_0.CountSchmObjColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.reportDailyHVDataTable_0.idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'id' in table 'ReportDailyHV' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.reportDailyHVDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class340 : DataRow
        {
            private DataSetDamage.tJ_DamageCharacterDataTable tJ_DamageCharacterDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class340(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_DamageCharacterDataTable_0 = (DataSetDamage.tJ_DamageCharacterDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_DamageCharacterDataTable_0.idDamageColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_DamageCharacterDataTable_0.idDamageColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageCharacterDataTable_0.idLineSectionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idLineSection' in table 'tJ_DamageCharacter' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.tJ_DamageCharacterDataTable_0.idLineSectionColumn] = int_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageCharacterDataTable_0.idCharacterParentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idCharacterParent' in table 'tJ_DamageCharacter' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.tJ_DamageCharacterDataTable_0.idCharacterParentColumn] = int_0;
            }

            public string method_14()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageCharacterDataTable_0.ParametersColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Parameters' in table 'tJ_DamageCharacter' is DBNull.", exception);
                }
                return str;
            }

            public void method_15(string string_0)
            {
                base[this.tJ_DamageCharacterDataTable_0.ParametersColumn] = string_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageCharacterDataTable_0.SchmObjNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'SchmObjName' in table 'tJ_DamageCharacter' is DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.tJ_DamageCharacterDataTable_0.SchmObjNameColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.col1Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.tJ_DamageCharacterDataTable_0.col1Column] = Convert.DBNull;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageCharacterDataTable_0.col1Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'col1' in table 'tJ_DamageCharacter' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.col2Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.tJ_DamageCharacterDataTable_0.col2Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_22()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.col3Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_23()
            {
                base[this.tJ_DamageCharacterDataTable_0.col3Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_24()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.idSchmObjColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.tJ_DamageCharacterDataTable_0.idSchmObjColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_26()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.idLineSectionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_27()
            {
                base[this.tJ_DamageCharacterDataTable_0.idLineSectionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_28()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.idCharacterParentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_29()
            {
                base[this.tJ_DamageCharacterDataTable_0.idCharacterParentColumn] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.tJ_DamageCharacterDataTable_0.col1Column] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_30()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.ParametersColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_31()
            {
                base[this.tJ_DamageCharacterDataTable_0.ParametersColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_32()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.idMarkColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_33()
            {
                base[this.tJ_DamageCharacterDataTable_0.idMarkColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_34()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.idParametersColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_35()
            {
                base[this.tJ_DamageCharacterDataTable_0.idParametersColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_36()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.idVoltageColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_37()
            {
                base[this.tJ_DamageCharacterDataTable_0.idVoltageColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_38()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.nodeDetailColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_39()
            {
                base[this.tJ_DamageCharacterDataTable_0.nodeDetailColumn] = Convert.DBNull;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageCharacterDataTable_0.col2Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'col2' in table 'tJ_DamageCharacter' is DBNull.", exception);
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_40()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.nodeDetailTxtColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_41()
            {
                base[this.tJ_DamageCharacterDataTable_0.nodeDetailTxtColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.CountDefectEquipmentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_43()
            {
                base[this.tJ_DamageCharacterDataTable_0.CountDefectEquipmentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_44()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.idVoltageSetiColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_45()
            {
                base[this.tJ_DamageCharacterDataTable_0.idVoltageSetiColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_46()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.AutoProtectColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.tJ_DamageCharacterDataTable_0.AutoProtectColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_48()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.ManufacturerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_49()
            {
                base[this.tJ_DamageCharacterDataTable_0.ManufacturerColumn] = Convert.DBNull;
            }

            public void method_5(int int_0)
            {
                base[this.tJ_DamageCharacterDataTable_0.col2Column] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_50()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.FactoryNumberColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.tJ_DamageCharacterDataTable_0.FactoryNumberColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_52()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.YearManufactureColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_53()
            {
                base[this.tJ_DamageCharacterDataTable_0.YearManufactureColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_54()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.idNeutralStateColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_55()
            {
                base[this.tJ_DamageCharacterDataTable_0.idNeutralStateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.ClauseFailColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_57()
            {
                base[this.tJ_DamageCharacterDataTable_0.ClauseFailColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_58()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.LengthOverloadColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_59()
            {
                base[this.tJ_DamageCharacterDataTable_0.LengthOverloadColumn] = Convert.DBNull;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageCharacterDataTable_0.col3Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'col3' in table 'tJ_DamageCharacter' is DBNull.", exception);
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_60()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.LengthLineColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_61()
            {
                base[this.tJ_DamageCharacterDataTable_0.LengthLineColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_62()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.idMaterialColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_63()
            {
                base[this.tJ_DamageCharacterDataTable_0.idMaterialColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_64()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.ClauseWorkColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_65()
            {
                base[this.tJ_DamageCharacterDataTable_0.ClauseWorkColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_66()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.idCharacterDamageColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_67()
            {
                base[this.tJ_DamageCharacterDataTable_0.idCharacterDamageColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_68()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.idReasonDamageColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_69()
            {
                base[this.tJ_DamageCharacterDataTable_0.idReasonDamageColumn] = Convert.DBNull;
            }

            public void method_7(int int_0)
            {
                base[this.tJ_DamageCharacterDataTable_0.col3Column] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_70()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.AssociatedFactColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_71()
            {
                base[this.tJ_DamageCharacterDataTable_0.AssociatedFactColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_72()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.yearBegEquipmentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_73()
            {
                base[this.tJ_DamageCharacterDataTable_0.yearBegEquipmentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_74()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.lenghtWorkEquipmentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_75()
            {
                base[this.tJ_DamageCharacterDataTable_0.lenghtWorkEquipmentColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_76()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.LastDateTestColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_77()
            {
                base[this.tJ_DamageCharacterDataTable_0.LastDateTestColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_78()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.timeRecoveryColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_79()
            {
                base[this.tJ_DamageCharacterDataTable_0.timeRecoveryColumn] = Convert.DBNull;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageCharacterDataTable_0.idSchmObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idSchmObj' in table 'tJ_DamageCharacter' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_80()
            {
                return base.IsNull(this.tJ_DamageCharacterDataTable_0.SchmObjNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_81()
            {
                base[this.tJ_DamageCharacterDataTable_0.SchmObjNameColumn] = Convert.DBNull;
            }

            public void method_9(int int_0)
            {
                base[this.tJ_DamageCharacterDataTable_0.idSchmObjColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string AssociatedFact
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tJ_DamageCharacterDataTable_0.AssociatedFactColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'AssociatedFact' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.AssociatedFactColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool AutoProtect
            {
                get
                {
                    bool flag;
                    try
                    {
                        flag = (bool) base[this.tJ_DamageCharacterDataTable_0.AutoProtectColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'AutoProtect' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return flag;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.AutoProtectColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int ClauseFail
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.ClauseFailColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'ClauseFail' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.ClauseFailColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int ClauseWork
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.ClauseWorkColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'ClauseWork' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.ClauseWorkColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int CountDefectEquipment
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.CountDefectEquipmentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'CountDefectEquipment' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.CountDefectEquipmentColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FactoryNumber
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tJ_DamageCharacterDataTable_0.FactoryNumberColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'FactoryNumber' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.FactoryNumberColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idCharacterDamage
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.idCharacterDamageColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idCharacterDamage' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.idCharacterDamageColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idMark
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.idMarkColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idMark' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.idMarkColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idMaterial
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.idMaterialColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idMaterial' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.idMaterialColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int idNeutralState
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.idNeutralStateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idNeutralState' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.idNeutralStateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int idParameters
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.idParametersColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idParameters' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.idParametersColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int idReasonDamage
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.idReasonDamageColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idReasonDamage' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.idReasonDamageColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idVoltage
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.idVoltageColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idVoltage' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.idVoltageColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int idVoltageSeti
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.idVoltageSetiColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idVoltageSeti' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.idVoltageSetiColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_DamageCharacterDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime LastDateTest
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tJ_DamageCharacterDataTable_0.LastDateTestColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'LastDateTest' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.LastDateTestColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int lenghtWorkEquipment
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.lenghtWorkEquipmentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'lenghtWorkEquipment' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.lenghtWorkEquipmentColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int LengthLine
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.LengthLineColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'LengthLine' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.LengthLineColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int LengthOverload
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.LengthOverloadColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'LengthOverload' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.LengthOverloadColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Manufacturer
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tJ_DamageCharacterDataTable_0.ManufacturerColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Manufacturer' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.ManufacturerColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int nodeDetail
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.nodeDetailColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'nodeDetail' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.nodeDetailColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string nodeDetailTxt
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tJ_DamageCharacterDataTable_0.nodeDetailTxtColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'nodeDetailTxt' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.nodeDetailTxtColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime timeRecovery
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tJ_DamageCharacterDataTable_0.timeRecoveryColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'timeRecovery' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.timeRecoveryColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int yearBegEquipment
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tJ_DamageCharacterDataTable_0.yearBegEquipmentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'yearBegEquipment' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.yearBegEquipmentColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public short YearManufacture
            {
                get
                {
                    short num;
                    try
                    {
                        num = (short) base[this.tJ_DamageCharacterDataTable_0.YearManufactureColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'YearManufacture' in table 'tJ_DamageCharacter' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tJ_DamageCharacterDataTable_0.YearManufactureColumn] = value;
                }
            }
        }

        public class Class341 : DataRow
        {
            private DataSetDamage.tJ_DamageActDetectionDataTable tJ_DamageActDetectionDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class341(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_DamageActDetectionDataTable_0 = (DataSetDamage.tJ_DamageActDetectionDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_DamageActDetectionDataTable_0.idDamageColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.idDamageColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageActDetectionDataTable_0.idReasonCrashEquipmentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idReasonCrashEquipment' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.idReasonCrashEquipmentColumn] = int_0;
            }

            public DateTime method_12()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_DamageActDetectionDataTable_0.dateEndCrashLocalColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateEndCrashLocal' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return time;
            }

            public void method_13(DateTime dateTime_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.dateEndCrashLocalColumn] = dateTime_0;
            }

            public DateTime method_14()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_DamageActDetectionDataTable_0.dateEndCrashMoscowColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateEndCrashMoscow' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return time;
            }

            public void method_15(DateTime dateTime_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.dateEndCrashMoscowColumn] = dateTime_0;
            }

            public int method_16()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageActDetectionDataTable_0.idStatusBeforeCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idStatusBeforeCrash' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return num;
            }

            public void method_17(int int_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.idStatusBeforeCrashColumn] = int_0;
            }

            public bool method_18()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tJ_DamageActDetectionDataTable_0.isCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isCrash' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return flag;
            }

            public void method_19(bool bool_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.isCrashColumn] = bool_0;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageActDetectionDataTable_0.idOrgColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idOrg' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return num;
            }

            public bool method_20()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tJ_DamageActDetectionDataTable_0.isNoOffColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isNoOff' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return flag;
            }

            public void method_21(bool bool_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.isNoOffColumn] = bool_0;
            }

            public string method_22()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageActDetectionDataTable_0.NoCrashMeasureColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NoCrashMeasure' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return str;
            }

            public void method_23(string string_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.NoCrashMeasureColumn] = string_0;
            }

            public int method_24()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageActDetectionDataTable_0.idStatusCurrentCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idStatusCurrentCrash' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return num;
            }

            public void method_25(int int_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.idStatusCurrentCrashColumn] = int_0;
            }

            public string method_26()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageActDetectionDataTable_0.DefectionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Defection' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return str;
            }

            public void method_27(string string_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.DefectionColumn] = string_0;
            }

            public int method_28()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageActDetectionDataTable_0.idReasonBeginCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idReasonBeginCrash' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return num;
            }

            public void method_29(int int_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.idReasonBeginCrashColumn] = int_0;
            }

            public void method_3(int int_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.idOrgColumn] = int_0;
            }

            public int method_30()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageActDetectionDataTable_0.idClassifierDamageColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idClassifierDamage' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return num;
            }

            public void method_31(int int_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.idClassifierDamageColumn] = int_0;
            }

            public int method_32()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageActDetectionDataTable_0.idFaultColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idFault' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return num;
            }

            public void method_33(int int_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.idFaultColumn] = int_0;
            }

            public string method_34()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageActDetectionDataTable_0.ComissionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Comission' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return str;
            }

            public void method_35(string string_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.ComissionColumn] = string_0;
            }

            public string method_36()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageActDetectionDataTable_0.TotalComissionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TotalComission' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return str;
            }

            public void method_37(string string_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.TotalComissionColumn] = string_0;
            }

            public string method_38()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageActDetectionDataTable_0.numCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'numCrash' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return str;
            }

            public void method_39(string string_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.numCrashColumn] = string_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageActDetectionDataTable_0.idSignCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idSignCrash' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return num;
            }

            public string method_40()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageActDetectionDataTable_0.StatusCurrentCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'StatusCurrentCrash' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return str;
            }

            public void method_41(string string_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.StatusCurrentCrashColumn] = string_0;
            }

            public string method_42()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageActDetectionDataTable_0.ReasonBeginCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ReasonBeginCrash' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return str;
            }

            public void method_43(string string_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.ReasonBeginCrashColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_44()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.idOrgColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_45()
            {
                base[this.tJ_DamageActDetectionDataTable_0.idOrgColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_46()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.idSignCrashColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_47()
            {
                base[this.tJ_DamageActDetectionDataTable_0.idSignCrashColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_48()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.idTypeEquipmentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_49()
            {
                base[this.tJ_DamageActDetectionDataTable_0.idTypeEquipmentColumn] = Convert.DBNull;
            }

            public void method_5(int int_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.idSignCrashColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_50()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.idReasonCrashColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_51()
            {
                base[this.tJ_DamageActDetectionDataTable_0.idReasonCrashColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_52()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.idReasonCrashEquipmentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_53()
            {
                base[this.tJ_DamageActDetectionDataTable_0.idReasonCrashEquipmentColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_54()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.dateEndCrashLocalColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_55()
            {
                base[this.tJ_DamageActDetectionDataTable_0.dateEndCrashLocalColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.dateEndCrashMoscowColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_57()
            {
                base[this.tJ_DamageActDetectionDataTable_0.dateEndCrashMoscowColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_58()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.idStatusBeforeCrashColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_59()
            {
                base[this.tJ_DamageActDetectionDataTable_0.idStatusBeforeCrashColumn] = Convert.DBNull;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageActDetectionDataTable_0.idTypeEquipmentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idTypeEquipment' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_60()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.isCrashColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_61()
            {
                base[this.tJ_DamageActDetectionDataTable_0.isCrashColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_62()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.isNoOffColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_63()
            {
                base[this.tJ_DamageActDetectionDataTable_0.isNoOffColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_64()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.NoCrashMeasureColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_65()
            {
                base[this.tJ_DamageActDetectionDataTable_0.NoCrashMeasureColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_66()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.idStatusCurrentCrashColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_67()
            {
                base[this.tJ_DamageActDetectionDataTable_0.idStatusCurrentCrashColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_68()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.DefectionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_69()
            {
                base[this.tJ_DamageActDetectionDataTable_0.DefectionColumn] = Convert.DBNull;
            }

            public void method_7(int int_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.idTypeEquipmentColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_70()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.idReasonBeginCrashColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_71()
            {
                base[this.tJ_DamageActDetectionDataTable_0.idReasonBeginCrashColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_72()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.idClassifierDamageColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_73()
            {
                base[this.tJ_DamageActDetectionDataTable_0.idClassifierDamageColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_74()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.idFaultColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_75()
            {
                base[this.tJ_DamageActDetectionDataTable_0.idFaultColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_76()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.ComissionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_77()
            {
                base[this.tJ_DamageActDetectionDataTable_0.ComissionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_78()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.TotalComissionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_79()
            {
                base[this.tJ_DamageActDetectionDataTable_0.TotalComissionColumn] = Convert.DBNull;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageActDetectionDataTable_0.idReasonCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idReasonCrash' in table 'tJ_DamageActDetection' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_80()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.numCrashColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_81()
            {
                base[this.tJ_DamageActDetectionDataTable_0.numCrashColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_82()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.StatusCurrentCrashColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_83()
            {
                base[this.tJ_DamageActDetectionDataTable_0.StatusCurrentCrashColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_84()
            {
                return base.IsNull(this.tJ_DamageActDetectionDataTable_0.ReasonBeginCrashColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_85()
            {
                base[this.tJ_DamageActDetectionDataTable_0.ReasonBeginCrashColumn] = Convert.DBNull;
            }

            public void method_9(int int_0)
            {
                base[this.tJ_DamageActDetectionDataTable_0.idReasonCrashColumn] = int_0;
            }
        }

        public class Class342 : DataRow
        {
            private DataSetDamage.table23DataTable table23DataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class342(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.table23DataTable_0 = (DataSetDamage.table23DataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.table23DataTable_0.NPAColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NPA' in table 'table23' is DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.table23DataTable_0.NPAColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_10()
            {
                return base.IsNull(this.table23DataTable_0.PunktNPAColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.table23DataTable_0.PunktNPAColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.table23DataTable_0.OrgColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_13()
            {
                base[this.table23DataTable_0.OrgColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.table23DataTable_0.PunktNPAColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'PunktNPA' in table 'table23' is DBNull.", exception);
                }
                return str;
            }

            public void method_3(string string_0)
            {
                base[this.table23DataTable_0.PunktNPAColumn] = string_0;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.table23DataTable_0.OrgColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Org' in table 'table23' is DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.table23DataTable_0.OrgColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_6()
            {
                return base.IsNull(this.table23DataTable_0.DescriptionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_7()
            {
                base[this.table23DataTable_0.DescriptionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_8()
            {
                return base.IsNull(this.table23DataTable_0.NPAColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.table23DataTable_0.NPAColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Description
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.table23DataTable_0.DescriptionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Description' in table 'table23' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.table23DataTable_0.DescriptionColumn] = value;
                }
            }
        }

        public class Class343 : DataRow
        {
            private DataSetDamage.table31DataTable table31DataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class343(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.table31DataTable_0 = (DataSetDamage.table31DataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.table31DataTable_0.MeasureColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Measure' in table 'table31' is DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.table31DataTable_0.MeasureColumn] = string_0;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.table31DataTable_0.OrgColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Org' in table 'table31' is DBNull.", exception);
                }
                return str;
            }

            public void method_3(string string_0)
            {
                base[this.table31DataTable_0.OrgColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_4()
            {
                return base.IsNull(this.table31DataTable_0.MeasureColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5()
            {
                base[this.table31DataTable_0.MeasureColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_6()
            {
                return base.IsNull(this.table31DataTable_0.DateColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.table31DataTable_0.DateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_8()
            {
                return base.IsNull(this.table31DataTable_0.OrgColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.table31DataTable_0.OrgColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Date
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.table31DataTable_0.DateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Date' in table 'table31' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.table31DataTable_0.DateColumn] = value;
                }
            }
        }

        public class Class344 : DataRow
        {
            private DataSetDamage.table4DataTable table4DataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class344(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.table4DataTable_0 = (DataSetDamage.table4DataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.table4DataTable_0.numColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'num' in table 'table4' is DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.table4DataTable_0.numColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_2()
            {
                return base.IsNull(this.table4DataTable_0.numColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_3()
            {
                base[this.table4DataTable_0.numColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_4()
            {
                return base.IsNull(this.table4DataTable_0.DescriptionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5()
            {
                base[this.table4DataTable_0.DescriptionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Description
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.table4DataTable_0.DescriptionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Description' in table 'table4' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.table4DataTable_0.DescriptionColumn] = value;
                }
            }
        }

        public class Class345 : DataRow
        {
            private DataSetDamage.tJ_DamageHVDataTable tJ_DamageHVDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class345(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_DamageHVDataTable_0 = (DataSetDamage.tJ_DamageHVDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_DamageHVDataTable_0.idDamageColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_DamageHVDataTable_0.idDamageColumn] = int_0;
            }

            public decimal method_10()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_DamageHVDataTable_0.CoefFIColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoefFI' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(decimal decimal_0)
            {
                base[this.tJ_DamageHVDataTable_0.CoefFIColumn] = decimal_0;
            }

            public decimal method_12()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_DamageHVDataTable_0.NoAdmissionKWTColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NoAdmissionKWT' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(decimal decimal_0)
            {
                base[this.tJ_DamageHVDataTable_0.NoAdmissionKWTColumn] = decimal_0;
            }

            public bool method_14()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tJ_DamageHVDataTable_0.AVRColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'AVR' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return flag;
            }

            public void method_15(bool bool_0)
            {
                base[this.tJ_DamageHVDataTable_0.AVRColumn] = bool_0;
            }

            public bool method_16()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tJ_DamageHVDataTable_0.APRColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'APR' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return flag;
            }

            public void method_17(bool bool_0)
            {
                base[this.tJ_DamageHVDataTable_0.APRColumn] = bool_0;
            }

            public string method_18()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageHVDataTable_0.TransOffColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'TransOff' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return str;
            }

            public void method_19(string string_0)
            {
                base[this.tJ_DamageHVDataTable_0.TransOffColumn] = string_0;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageHVDataTable_0.idTypeRZAColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idTypeRZA' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return num;
            }

            public string method_20()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_DamageHVDataTable_0.AbnOffColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'AbnOff' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return str;
            }

            public void method_21(string string_0)
            {
                base[this.tJ_DamageHVDataTable_0.AbnOffColumn] = string_0;
            }

            public decimal method_22()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_DamageHVDataTable_0.PowerAColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'PowerA' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return num;
            }

            public void method_23(decimal decimal_0)
            {
                base[this.tJ_DamageHVDataTable_0.PowerAColumn] = decimal_0;
            }

            public decimal method_24()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_DamageHVDataTable_0.PowerVColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'PowerV' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return num;
            }

            public void method_25(decimal decimal_0)
            {
                base[this.tJ_DamageHVDataTable_0.PowerVColumn] = decimal_0;
            }

            public decimal method_26()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_DamageHVDataTable_0.CoefSeasonColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CoefSeason' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return num;
            }

            public void method_27(decimal decimal_0)
            {
                base[this.tJ_DamageHVDataTable_0.CoefSeasonColumn] = decimal_0;
            }

            public bool method_28()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tJ_DamageHVDataTable_0.isAverageColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isAverage' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return flag;
            }

            public void method_29(bool bool_0)
            {
                base[this.tJ_DamageHVDataTable_0.isAverageColumn] = bool_0;
            }

            public void method_3(int int_0)
            {
                base[this.tJ_DamageHVDataTable_0.idTypeRZAColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_30()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.idTypeRZAColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_31()
            {
                base[this.tJ_DamageHVDataTable_0.idTypeRZAColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_32()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.CountSchmObjColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_33()
            {
                base[this.tJ_DamageHVDataTable_0.CountSchmObjColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_34()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.CountSchmObjOffColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_35()
            {
                base[this.tJ_DamageHVDataTable_0.CountSchmObjOffColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_36()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.ConnectedPowerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_37()
            {
                base[this.tJ_DamageHVDataTable_0.ConnectedPowerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_38()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.CoefFIColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_39()
            {
                base[this.tJ_DamageHVDataTable_0.CoefFIColumn] = Convert.DBNull;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageHVDataTable_0.CountSchmObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CountSchmObj' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_40()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.NoAdmissionKWTColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_41()
            {
                base[this.tJ_DamageHVDataTable_0.NoAdmissionKWTColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_42()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.AVRColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_43()
            {
                base[this.tJ_DamageHVDataTable_0.AVRColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_44()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.APRColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_45()
            {
                base[this.tJ_DamageHVDataTable_0.APRColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_46()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.TransOffColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.tJ_DamageHVDataTable_0.TransOffColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_48()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.AbnOffColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_49()
            {
                base[this.tJ_DamageHVDataTable_0.AbnOffColumn] = Convert.DBNull;
            }

            public void method_5(int int_0)
            {
                base[this.tJ_DamageHVDataTable_0.CountSchmObjColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.PowerAColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.tJ_DamageHVDataTable_0.PowerAColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_52()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.PowerVColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_53()
            {
                base[this.tJ_DamageHVDataTable_0.PowerVColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_54()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.CoefSeasonColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_55()
            {
                base[this.tJ_DamageHVDataTable_0.CoefSeasonColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.tJ_DamageHVDataTable_0.isAverageColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_57()
            {
                base[this.tJ_DamageHVDataTable_0.isAverageColumn] = Convert.DBNull;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_DamageHVDataTable_0.CountSchmObjOffColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'CountSchmObjOff' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.tJ_DamageHVDataTable_0.CountSchmObjOffColumn] = int_0;
            }

            public decimal method_8()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.tJ_DamageHVDataTable_0.ConnectedPowerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ConnectedPower' in table 'tJ_DamageHV' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(decimal decimal_0)
            {
                base[this.tJ_DamageHVDataTable_0.ConnectedPowerColumn] = decimal_0;
            }
        }

        public class Class346 : DataRow
        {
            private DataSetDamage.tReportDetectionCrashDataTable tReportDetectionCrashDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class346(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tReportDetectionCrashDataTable_0 = (DataSetDamage.tReportDetectionCrashDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionCrashDataTable_0.MonthColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Month' in table 'tReportDetectionCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tReportDetectionCrashDataTable_0.MonthColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionCrashDataTable_0.id1518Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id1518' in table 'tReportDetectionCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.tReportDetectionCrashDataTable_0.id1518Column] = int_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionCrashDataTable_0.id1519Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id1519' in table 'tReportDetectionCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.tReportDetectionCrashDataTable_0.id1519Column] = int_0;
            }

            public int method_14()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionCrashDataTable_0.id1520Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id1520' in table 'tReportDetectionCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(int int_0)
            {
                base[this.tReportDetectionCrashDataTable_0.id1520Column] = int_0;
            }

            public bool method_16()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tReportDetectionCrashDataTable_0.isCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isCrash' in table 'tReportDetectionCrash' is DBNull.", exception);
                }
                return flag;
            }

            public void method_17(bool bool_0)
            {
                base[this.tReportDetectionCrashDataTable_0.isCrashColumn] = bool_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.tReportDetectionCrashDataTable_0.idColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.tReportDetectionCrashDataTable_0.idColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionCrashDataTable_0.id756Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id756' in table 'tReportDetectionCrash' is DBNull.", exception);
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_20()
            {
                return base.IsNull(this.tReportDetectionCrashDataTable_0.MonthColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.tReportDetectionCrashDataTable_0.MonthColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_22()
            {
                return base.IsNull(this.tReportDetectionCrashDataTable_0.id756Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.tReportDetectionCrashDataTable_0.id756Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_24()
            {
                return base.IsNull(this.tReportDetectionCrashDataTable_0.id757Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_25()
            {
                base[this.tReportDetectionCrashDataTable_0.id757Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_26()
            {
                return base.IsNull(this.tReportDetectionCrashDataTable_0.id758Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_27()
            {
                base[this.tReportDetectionCrashDataTable_0.id758Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_28()
            {
                return base.IsNull(this.tReportDetectionCrashDataTable_0.id759Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_29()
            {
                base[this.tReportDetectionCrashDataTable_0.id759Column] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.tReportDetectionCrashDataTable_0.id756Column] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_30()
            {
                return base.IsNull(this.tReportDetectionCrashDataTable_0.id1518Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.tReportDetectionCrashDataTable_0.id1518Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_32()
            {
                return base.IsNull(this.tReportDetectionCrashDataTable_0.id1519Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_33()
            {
                base[this.tReportDetectionCrashDataTable_0.id1519Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_34()
            {
                return base.IsNull(this.tReportDetectionCrashDataTable_0.id1520Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_35()
            {
                base[this.tReportDetectionCrashDataTable_0.id1520Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_36()
            {
                return base.IsNull(this.tReportDetectionCrashDataTable_0.isCrashColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_37()
            {
                base[this.tReportDetectionCrashDataTable_0.isCrashColumn] = Convert.DBNull;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionCrashDataTable_0.id757Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id757' in table 'tReportDetectionCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.tReportDetectionCrashDataTable_0.id757Column] = int_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionCrashDataTable_0.id758Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id758' in table 'tReportDetectionCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.tReportDetectionCrashDataTable_0.id758Column] = int_0;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionCrashDataTable_0.id759Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id759' in table 'tReportDetectionCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(int int_0)
            {
                base[this.tReportDetectionCrashDataTable_0.id759Column] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tReportDetectionCrashDataTable_0.idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'id' in table 'tReportDetectionCrash' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tReportDetectionCrashDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class347 : DataRow
        {
            private DataSetDamage.tReportDetectionReasonCrashDataTable tReportDetectionReasonCrashDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class347(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tReportDetectionReasonCrashDataTable_0 = (DataSetDamage.tReportDetectionReasonCrashDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionReasonCrashDataTable_0.reasonCodeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'reasonCode' in table 'tReportDetectionReasonCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tReportDetectionReasonCrashDataTable_0.reasonCodeColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionReasonCrashDataTable_0.id1518Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id1518' in table 'tReportDetectionReasonCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id1518Column] = int_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionReasonCrashDataTable_0.id1519Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id1519' in table 'tReportDetectionReasonCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id1519Column] = int_0;
            }

            public int method_14()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionReasonCrashDataTable_0.id1520Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id1520' in table 'tReportDetectionReasonCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_15(int int_0)
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id1520Column] = int_0;
            }

            public bool method_16()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tReportDetectionReasonCrashDataTable_0.isCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isCrash' in table 'tReportDetectionReasonCrash' is DBNull.", exception);
                }
                return flag;
            }

            public void method_17(bool bool_0)
            {
                base[this.tReportDetectionReasonCrashDataTable_0.isCrashColumn] = bool_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.tReportDetectionReasonCrashDataTable_0.idColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.tReportDetectionReasonCrashDataTable_0.idColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionReasonCrashDataTable_0.id756Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id756' in table 'tReportDetectionReasonCrash' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.tReportDetectionReasonCrashDataTable_0.reasonCodeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.tReportDetectionReasonCrashDataTable_0.reasonCodeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_22()
            {
                return base.IsNull(this.tReportDetectionReasonCrashDataTable_0.ReasonColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_23()
            {
                base[this.tReportDetectionReasonCrashDataTable_0.ReasonColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_24()
            {
                return base.IsNull(this.tReportDetectionReasonCrashDataTable_0.id756Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id756Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_26()
            {
                return base.IsNull(this.tReportDetectionReasonCrashDataTable_0.id757Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_27()
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id757Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_28()
            {
                return base.IsNull(this.tReportDetectionReasonCrashDataTable_0.id758Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_29()
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id758Column] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id756Column] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_30()
            {
                return base.IsNull(this.tReportDetectionReasonCrashDataTable_0.id759Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id759Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_32()
            {
                return base.IsNull(this.tReportDetectionReasonCrashDataTable_0.id1518Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_33()
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id1518Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_34()
            {
                return base.IsNull(this.tReportDetectionReasonCrashDataTable_0.id1519Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_35()
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id1519Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_36()
            {
                return base.IsNull(this.tReportDetectionReasonCrashDataTable_0.id1520Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_37()
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id1520Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_38()
            {
                return base.IsNull(this.tReportDetectionReasonCrashDataTable_0.isCrashColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_39()
            {
                base[this.tReportDetectionReasonCrashDataTable_0.isCrashColumn] = Convert.DBNull;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionReasonCrashDataTable_0.id757Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id757' in table 'tReportDetectionReasonCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id757Column] = int_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionReasonCrashDataTable_0.id758Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id758' in table 'tReportDetectionReasonCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id758Column] = int_0;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionReasonCrashDataTable_0.id759Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id759' in table 'tReportDetectionReasonCrash' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(int int_0)
            {
                base[this.tReportDetectionReasonCrashDataTable_0.id759Column] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tReportDetectionReasonCrashDataTable_0.idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'id' in table 'tReportDetectionReasonCrash' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tReportDetectionReasonCrashDataTable_0.idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Reason
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tReportDetectionReasonCrashDataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Reason' in table 'tReportDetectionReasonCrash' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tReportDetectionReasonCrashDataTable_0.ReasonColumn] = value;
                }
            }
        }

        public class Class348 : DataRow
        {
            private DataSetDamage.tReportDetectionNetRegDataTable tReportDetectionNetRegDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class348(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tReportDetectionNetRegDataTable_0 = (DataSetDamage.tReportDetectionNetRegDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionNetRegDataTable_0.typeNetRegColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeNetReg' in table 'tReportDetectionNetReg' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tReportDetectionNetRegDataTable_0.typeNetRegColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_10()
            {
                return base.IsNull(this.tReportDetectionNetRegDataTable_0.typeNetRegColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.tReportDetectionNetRegDataTable_0.typeNetRegColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.tReportDetectionNetRegDataTable_0.id1518Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_13()
            {
                base[this.tReportDetectionNetRegDataTable_0.id1518Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_14()
            {
                return base.IsNull(this.tReportDetectionNetRegDataTable_0.id1519Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_15()
            {
                base[this.tReportDetectionNetRegDataTable_0.id1519Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_16()
            {
                return base.IsNull(this.tReportDetectionNetRegDataTable_0.id1520Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_17()
            {
                base[this.tReportDetectionNetRegDataTable_0.id1520Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.tReportDetectionNetRegDataTable_0.isCrashColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.tReportDetectionNetRegDataTable_0.isCrashColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionNetRegDataTable_0.id1518Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id1518' in table 'tReportDetectionNetReg' is DBNull.", exception);
                }
                return num;
            }

            public void method_3(int int_0)
            {
                base[this.tReportDetectionNetRegDataTable_0.id1518Column] = int_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionNetRegDataTable_0.id1519Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id1519' in table 'tReportDetectionNetReg' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.tReportDetectionNetRegDataTable_0.id1519Column] = int_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionNetRegDataTable_0.id1520Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id1520' in table 'tReportDetectionNetReg' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.tReportDetectionNetRegDataTable_0.id1520Column] = int_0;
            }

            public bool method_8()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tReportDetectionNetRegDataTable_0.isCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isCrash' in table 'tReportDetectionNetReg' is DBNull.", exception);
                }
                return flag;
            }

            public void method_9(bool bool_0)
            {
                base[this.tReportDetectionNetRegDataTable_0.isCrashColumn] = bool_0;
            }
        }

        public class Class349 : DataRow
        {
            private DataSetDamage.tReportDetectionNoAdmissKWTDataTable tReportDetectionNoAdmissKWTDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class349(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tReportDetectionNoAdmissKWTDataTable_0 = (DataSetDamage.tReportDetectionNoAdmissKWTDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionNoAdmissKWTDataTable_0.isCrashColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isCrash' in table 'tReportDetectionNoAdmissKWT' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tReportDetectionNoAdmissKWTDataTable_0.isCrashColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.tReportDetectionNoAdmissKWTDataTable_0.isCrashColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.tReportDetectionNoAdmissKWTDataTable_0.isCrashColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_12()
            {
                return base.IsNull(this.tReportDetectionNoAdmissKWTDataTable_0.id756Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_13()
            {
                base[this.tReportDetectionNoAdmissKWTDataTable_0.id756Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.tReportDetectionNoAdmissKWTDataTable_0.id757Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.tReportDetectionNoAdmissKWTDataTable_0.id757Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_16()
            {
                return base.IsNull(this.tReportDetectionNoAdmissKWTDataTable_0.id758Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_17()
            {
                base[this.tReportDetectionNoAdmissKWTDataTable_0.id758Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.tReportDetectionNoAdmissKWTDataTable_0.id759Column);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.tReportDetectionNoAdmissKWTDataTable_0.id759Column] = Convert.DBNull;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionNoAdmissKWTDataTable_0.id756Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id756' in table 'tReportDetectionNoAdmissKWT' is DBNull.", exception);
                }
                return num;
            }

            public void method_3(int int_0)
            {
                base[this.tReportDetectionNoAdmissKWTDataTable_0.id756Column] = int_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionNoAdmissKWTDataTable_0.id757Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id757' in table 'tReportDetectionNoAdmissKWT' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.tReportDetectionNoAdmissKWTDataTable_0.id757Column] = int_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionNoAdmissKWTDataTable_0.id758Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id758' in table 'tReportDetectionNoAdmissKWT' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.tReportDetectionNoAdmissKWTDataTable_0.id758Column] = int_0;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.tReportDetectionNoAdmissKWTDataTable_0.id759Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'id759' in table 'tReportDetectionNoAdmissKWT' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(int int_0)
            {
                base[this.tReportDetectionNoAdmissKWTDataTable_0.id759Column] = int_0;
            }
        }

        public class Class350 : DataRow
        {
            private DataSetDamage.tSettingsDataTable tSettingsDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class350(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tSettingsDataTable_0 = (DataSetDamage.tSettingsDataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.tSettingsDataTable_0.HostIpColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'HostIp' in table 'tSettings' is DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.tSettingsDataTable_0.HostIpColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.tSettingsDataTable_0.ModuleColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.tSettingsDataTable_0.ModuleColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.tSettingsDataTable_0.SettingsColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Settings' in table 'tSettings' is DBNull.", exception);
                }
                return str;
            }

            public void method_3(string string_0)
            {
                base[this.tSettingsDataTable_0.SettingsColumn] = string_0;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.tSettingsDataTable_0.ModuleColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Module' in table 'tSettings' is DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.tSettingsDataTable_0.ModuleColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_6()
            {
                return base.IsNull(this.tSettingsDataTable_0.HostIpColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.tSettingsDataTable_0.HostIpColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.tSettingsDataTable_0.SettingsColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.tSettingsDataTable_0.SettingsColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tSettingsDataTable_0.idColumn];
                }
                set
                {
                    base[this.tSettingsDataTable_0.idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate188(object sender, DataSetDamage.EventArgs184 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate189(object sender, DataSetDamage.EventArgs185 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate190(object sender, DataSetDamage.EventArgs186 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate191(object sender, DataSetDamage.EventArgs187 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate192(object sender, DataSetDamage.EventArgs188 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate193(object sender, DataSetDamage.EventArgs189 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate194(object sender, DataSetDamage.EventArgs190 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate195(object sender, DataSetDamage.EventArgs191 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate196(object sender, DataSetDamage.EventArgs192 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate197(object sender, DataSetDamage.EventArgs193 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate198(object sender, DataSetDamage.EventArgs194 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate199(object sender, DataSetDamage.EventArgs195 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate200(object sender, DataSetDamage.EventArgs196 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate201(object sender, DataSetDamage.EventArgs197 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate202(object sender, DataSetDamage.EventArgs198 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate203(object sender, DataSetDamage.EventArgs199 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate204(object sender, DataSetDamage.EventArgs200 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate205(object sender, DataSetDamage.EventArgs201 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate206(object sender, DataSetDamage.EventArgs202 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate207(object sender, DataSetDamage.EventArgs203 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate208(object sender, DataSetDamage.EventArgs204 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate209(object sender, DataSetDamage.EventArgs205 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate210(object sender, DataSetDamage.EventArgs206 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs184 : EventArgs
        {
            private DataSetDamage.Class328 class328_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs184(DataSetDamage.Class328 class328_1, DataRowAction dataRowAction_1)
            {
                this.class328_0 = class328_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class328 method_0()
            {
                return this.class328_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs185 : EventArgs
        {
            private DataSetDamage.Class329 class329_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs185(DataSetDamage.Class329 class329_1, DataRowAction dataRowAction_1)
            {
                this.class329_0 = class329_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class329 method_0()
            {
                return this.class329_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs186 : EventArgs
        {
            private DataSetDamage.Class330 class330_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs186(DataSetDamage.Class330 class330_1, DataRowAction dataRowAction_1)
            {
                this.class330_0 = class330_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class330 method_0()
            {
                return this.class330_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs187 : EventArgs
        {
            private DataSetDamage.Class331 class331_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs187(DataSetDamage.Class331 class331_1, DataRowAction dataRowAction_1)
            {
                this.class331_0 = class331_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class331 method_0()
            {
                return this.class331_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs188 : EventArgs
        {
            private DataSetDamage.Class332 class332_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs188(DataSetDamage.Class332 class332_1, DataRowAction dataRowAction_1)
            {
                this.class332_0 = class332_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class332 method_0()
            {
                return this.class332_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs189 : EventArgs
        {
            private DataSetDamage.Class333 class333_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs189(DataSetDamage.Class333 class333_1, DataRowAction dataRowAction_1)
            {
                this.class333_0 = class333_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class333 method_0()
            {
                return this.class333_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs190 : EventArgs
        {
            private DataSetDamage.Class334 class334_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs190(DataSetDamage.Class334 class334_1, DataRowAction dataRowAction_1)
            {
                this.class334_0 = class334_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class334 method_0()
            {
                return this.class334_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs191 : EventArgs
        {
            private DataSetDamage.Class335 class335_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs191(DataSetDamage.Class335 class335_1, DataRowAction dataRowAction_1)
            {
                this.class335_0 = class335_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class335 method_0()
            {
                return this.class335_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs192 : EventArgs
        {
            private DataSetDamage.Class336 class336_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs192(DataSetDamage.Class336 class336_1, DataRowAction dataRowAction_1)
            {
                this.class336_0 = class336_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class336 method_0()
            {
                return this.class336_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs193 : EventArgs
        {
            private DataSetDamage.Class337 class337_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs193(DataSetDamage.Class337 class337_1, DataRowAction dataRowAction_1)
            {
                this.class337_0 = class337_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class337 method_0()
            {
                return this.class337_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs194 : EventArgs
        {
            private DataSetDamage.Class338 class338_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs194(DataSetDamage.Class338 class338_1, DataRowAction dataRowAction_1)
            {
                this.class338_0 = class338_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class338 method_0()
            {
                return this.class338_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs195 : EventArgs
        {
            private DataSetDamage.Class339 class339_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs195(DataSetDamage.Class339 class339_1, DataRowAction dataRowAction_1)
            {
                this.class339_0 = class339_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class339 method_0()
            {
                return this.class339_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs196 : EventArgs
        {
            private DataSetDamage.Class340 class340_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs196(DataSetDamage.Class340 class340_1, DataRowAction dataRowAction_1)
            {
                this.class340_0 = class340_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class340 method_0()
            {
                return this.class340_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs197 : EventArgs
        {
            private DataSetDamage.Class341 class341_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs197(DataSetDamage.Class341 class341_1, DataRowAction dataRowAction_1)
            {
                this.class341_0 = class341_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class341 method_0()
            {
                return this.class341_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs198 : EventArgs
        {
            private DataSetDamage.Class342 class342_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs198(DataSetDamage.Class342 class342_1, DataRowAction dataRowAction_1)
            {
                this.class342_0 = class342_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class342 method_0()
            {
                return this.class342_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs199 : EventArgs
        {
            private DataSetDamage.Class343 class343_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs199(DataSetDamage.Class343 class343_1, DataRowAction dataRowAction_1)
            {
                this.class343_0 = class343_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class343 method_0()
            {
                return this.class343_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs200 : EventArgs
        {
            private DataSetDamage.Class344 class344_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs200(DataSetDamage.Class344 class344_1, DataRowAction dataRowAction_1)
            {
                this.class344_0 = class344_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class344 method_0()
            {
                return this.class344_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs201 : EventArgs
        {
            private DataSetDamage.Class345 class345_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs201(DataSetDamage.Class345 class345_1, DataRowAction dataRowAction_1)
            {
                this.class345_0 = class345_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class345 method_0()
            {
                return this.class345_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs202 : EventArgs
        {
            private DataSetDamage.Class346 class346_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs202(DataSetDamage.Class346 class346_1, DataRowAction dataRowAction_1)
            {
                this.class346_0 = class346_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class346 method_0()
            {
                return this.class346_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs203 : EventArgs
        {
            private DataSetDamage.Class347 class347_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs203(DataSetDamage.Class347 class347_1, DataRowAction dataRowAction_1)
            {
                this.class347_0 = class347_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class347 method_0()
            {
                return this.class347_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs204 : EventArgs
        {
            private DataSetDamage.Class348 class348_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs204(DataSetDamage.Class348 class348_1, DataRowAction dataRowAction_1)
            {
                this.class348_0 = class348_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class348 method_0()
            {
                return this.class348_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs205 : EventArgs
        {
            private DataSetDamage.Class349 class349_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs205(DataSetDamage.Class349 class349_1, DataRowAction dataRowAction_1)
            {
                this.class349_0 = class349_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class349 method_0()
            {
                return this.class349_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs206 : EventArgs
        {
            private DataSetDamage.Class350 class350_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs206(DataSetDamage.Class350 class350_1, DataRowAction dataRowAction_1)
            {
                this.class350_0 = class350_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetDamage.Class350 method_0()
            {
                return this.class350_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class ReportDailyDefectDataTable : TypedTableBase<DataSetDamage.Class337>
        {
            private DataColumn columndateDoc;
            private DataColumn columndateDocParent;
            private DataColumn columnDivisionApply;
            private DataColumn columnDivisionInstruction;
            private DataColumn columnid;
            private DataColumn columnidDivisionApply;
            private DataColumn columnisApply;
            private DataColumn columnnumRequest;
            private DataColumn columnnumRequestParent;
            private DataColumn columntypeDocParent;
            private DataColumn columnValue;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate197 ReportDailyDefectRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate197 ReportDailyDefectRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate197 ReportDailyDefectRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate197 ReportDailyDefectRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public ReportDailyDefectDataTable()
            {
                base.TableName = "ReportDailyDefect";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ReportDailyDefectDataTable(DataTable dataTable_0)
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected ReportDailyDefectDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.ReportDailyDefectDataTable table1 = (DataSetDamage.ReportDailyDefectDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.ReportDailyDefectDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class337);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetDamage.Class337 class337_0)
            {
                base.Rows.Add(class337_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class337 method_1(int int_0, string string_0, DateTime dateTime_0, int int_1, string string_1, string string_2, decimal decimal_0, string string_3, DateTime dateTime_1, string string_4, bool bool_0)
            {
                DataSetDamage.Class337 row = (DataSetDamage.Class337) base.NewRow();
                object[] objArray = new object[] { int_0, string_0, dateTime_0, int_1, string_1, string_2, decimal_0, string_3, dateTime_1, string_4, bool_0 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnid = base.Columns["id"];
                this.columnnumRequest = base.Columns["numRequest"];
                this.columndateDoc = base.Columns["dateDoc"];
                this.columnidDivisionApply = base.Columns["idDivisionApply"];
                this.columnDivisionApply = base.Columns["DivisionApply"];
                this.columnDivisionInstruction = base.Columns["DivisionInstruction"];
                this.columnValue = base.Columns["Value"];
                this.columnnumRequestParent = base.Columns["numRequestParent"];
                this.columndateDocParent = base.Columns["dateDocParent"];
                this.columntypeDocParent = base.Columns["typeDocParent"];
                this.columnisApply = base.Columns["isApply"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnnumRequest = new DataColumn("numRequest", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnumRequest);
                this.columndateDoc = new DataColumn("dateDoc", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateDoc);
                this.columnidDivisionApply = new DataColumn("idDivisionApply", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidDivisionApply);
                this.columnDivisionApply = new DataColumn("DivisionApply", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDivisionApply);
                this.columnDivisionInstruction = new DataColumn("DivisionInstruction", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDivisionInstruction);
                this.columnValue = new DataColumn("Value", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnValue);
                this.columnnumRequestParent = new DataColumn("numRequestParent", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnumRequestParent);
                this.columndateDocParent = new DataColumn("dateDocParent", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateDocParent);
                this.columntypeDocParent = new DataColumn("typeDocParent", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntypeDocParent);
                this.columnisApply = new DataColumn("isApply", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisApply);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class337 method_4()
            {
                return (DataSetDamage.Class337) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(DataSetDamage.Class337 class337_0)
            {
                base.Rows.Remove(class337_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class337(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.ReportDailyDefectRowChanged != null)
                {
                    this.ReportDailyDefectRowChanged(this, new DataSetDamage.EventArgs193((DataSetDamage.Class337) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.ReportDailyDefectRowChanging != null)
                {
                    this.ReportDailyDefectRowChanging(this, new DataSetDamage.EventArgs193((DataSetDamage.Class337) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.ReportDailyDefectRowDeleted != null)
                {
                    this.ReportDailyDefectRowDeleted(this, new DataSetDamage.EventArgs193((DataSetDamage.Class337) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.ReportDailyDefectRowDeleting != null)
                {
                    this.ReportDailyDefectRowDeleting(this, new DataSetDamage.EventArgs193((DataSetDamage.Class337) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "ReportDailyDefectDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateDocColumn
            {
                get
                {
                    return this.columndateDoc;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateDocParentColumn
            {
                get
                {
                    return this.columndateDocParent;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DivisionApplyColumn
            {
                get
                {
                    return this.columnDivisionApply;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DivisionInstructionColumn
            {
                get
                {
                    return this.columnDivisionInstruction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idDivisionApplyColumn
            {
                get
                {
                    return this.columnidDivisionApply;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn isApplyColumn
            {
                get
                {
                    return this.columnisApply;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class337 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class337) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn numRequestColumn
            {
                get
                {
                    return this.columnnumRequest;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn numRequestParentColumn
            {
                get
                {
                    return this.columnnumRequestParent;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeDocParentColumn
            {
                get
                {
                    return this.columntypeDocParent;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ValueColumn
            {
                get
                {
                    return this.columnValue;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class ReportDailyHVDataTable : TypedTableBase<DataSetDamage.Class339>
        {
            private DataColumn columnCharacter;
            private DataColumn columnCompiler;
            private DataColumn columncompletedWork;
            private DataColumn columnConnectedPower;
            private DataColumn columnCountSchmObj;
            private DataColumn columndateApply;
            private DataColumn columndateDoc;
            private DataColumn columnid;
            private DataColumn columnNoAdmissionKWT;
            private DataColumn columnnumRequest;
            private DataColumn columnPowerA;
            private DataColumn columnreasonAndLocation;
            private DataColumn columnschmObjName;
            private DataColumn columnsubscriber;
            private DataColumn columntypeRZA;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate199 ReportDailyHVRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate199 ReportDailyHVRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate199 ReportDailyHVRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate199 ReportDailyHVRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ReportDailyHVDataTable()
            {
                base.TableName = "ReportDailyHV";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ReportDailyHVDataTable(DataTable dataTable_0)
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected ReportDailyHVDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetDamage.ReportDailyHVDataTable table1 = (DataSetDamage.ReportDailyHVDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.ReportDailyHVDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class339);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetDamage.Class339 class339_0)
            {
                base.Rows.Add(class339_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class339 method_1(int int_0, string string_0, string string_1, string string_2, decimal decimal_0, int int_1, decimal decimal_1, DateTime dateTime_0, DateTime dateTime_1, string string_3, decimal decimal_2, string string_4, string string_5, string string_6, string string_7)
            {
                DataSetDamage.Class339 row = (DataSetDamage.Class339) base.NewRow();
                object[] objArray = new object[] { int_0, string_0, string_1, string_2, decimal_0, int_1, decimal_1, dateTime_0, dateTime_1, string_3, decimal_2, string_4, string_5, string_6, string_7 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnid = base.Columns["id"];
                this.columnnumRequest = base.Columns["numRequest"];
                this.columnschmObjName = base.Columns["schmObjName"];
                this.columnsubscriber = base.Columns["subscriber"];
                this.columnPowerA = base.Columns["PowerA"];
                this.columnCountSchmObj = base.Columns["CountSchmObj"];
                this.columnConnectedPower = base.Columns["ConnectedPower"];
                this.columndateDoc = base.Columns["dateDoc"];
                this.columndateApply = base.Columns["dateApply"];
                this.columntypeRZA = base.Columns["typeRZA"];
                this.columnNoAdmissionKWT = base.Columns["NoAdmissionKWT"];
                this.columnreasonAndLocation = base.Columns["reasonAndLocation"];
                this.columnCharacter = base.Columns["Character"];
                this.columncompletedWork = base.Columns["completedWork"];
                this.columnCompiler = base.Columns["Compiler"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnnumRequest = new DataColumn("numRequest", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnumRequest);
                this.columnschmObjName = new DataColumn("schmObjName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnschmObjName);
                this.columnsubscriber = new DataColumn("subscriber", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnsubscriber);
                this.columnPowerA = new DataColumn("PowerA", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnPowerA);
                this.columnCountSchmObj = new DataColumn("CountSchmObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCountSchmObj);
                this.columnConnectedPower = new DataColumn("ConnectedPower", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnConnectedPower);
                this.columndateDoc = new DataColumn("dateDoc", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateDoc);
                this.columndateApply = new DataColumn("dateApply", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateApply);
                this.columntypeRZA = new DataColumn("typeRZA", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntypeRZA);
                this.columnNoAdmissionKWT = new DataColumn("NoAdmissionKWT", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnNoAdmissionKWT);
                this.columnreasonAndLocation = new DataColumn("reasonAndLocation", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnreasonAndLocation);
                this.columnCharacter = new DataColumn("Character", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnCharacter);
                this.columncompletedWork = new DataColumn("completedWork", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncompletedWork);
                this.columnCompiler = new DataColumn("Compiler", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnCompiler);
                this.columnschmObjName.Caption = "dateDoc";
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class339 method_4()
            {
                return (DataSetDamage.Class339) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(DataSetDamage.Class339 class339_0)
            {
                base.Rows.Remove(class339_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class339(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.ReportDailyHVRowChanged != null)
                {
                    this.ReportDailyHVRowChanged(this, new DataSetDamage.EventArgs195((DataSetDamage.Class339) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.ReportDailyHVRowChanging != null)
                {
                    this.ReportDailyHVRowChanging(this, new DataSetDamage.EventArgs195((DataSetDamage.Class339) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.ReportDailyHVRowDeleted != null)
                {
                    this.ReportDailyHVRowDeleted(this, new DataSetDamage.EventArgs195((DataSetDamage.Class339) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.ReportDailyHVRowDeleting != null)
                {
                    this.ReportDailyHVRowDeleting(this, new DataSetDamage.EventArgs195((DataSetDamage.Class339) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "ReportDailyHVDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CharacterColumn
            {
                get
                {
                    return this.columnCharacter;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CompilerColumn
            {
                get
                {
                    return this.columnCompiler;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn completedWorkColumn
            {
                get
                {
                    return this.columncompletedWork;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ConnectedPowerColumn
            {
                get
                {
                    return this.columnConnectedPower;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CountSchmObjColumn
            {
                get
                {
                    return this.columnCountSchmObj;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateApplyColumn
            {
                get
                {
                    return this.columndateApply;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateDocColumn
            {
                get
                {
                    return this.columndateDoc;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class339 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class339) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NoAdmissionKWTColumn
            {
                get
                {
                    return this.columnNoAdmissionKWT;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn numRequestColumn
            {
                get
                {
                    return this.columnnumRequest;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PowerAColumn
            {
                get
                {
                    return this.columnPowerA;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn reasonAndLocationColumn
            {
                get
                {
                    return this.columnreasonAndLocation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn schmObjNameColumn
            {
                get
                {
                    return this.columnschmObjName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn subscriberColumn
            {
                get
                {
                    return this.columnsubscriber;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn typeRZAColumn
            {
                get
                {
                    return this.columntypeRZA;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class ReportDailyLVDataTable : TypedTableBase<DataSetDamage.Class333>
        {
            private DataColumn columnCharacter;
            private DataColumn columncompletedWork;
            private DataColumn columndateApply;
            private DataColumn columndateDoc;
            private DataColumn columndefectLocation;
            private DataColumn columnid;
            private DataColumn columnidSchmObj;
            private DataColumn columnNetRegion;
            private DataColumn columnnumRequest;
            private DataColumn columnReason;
            private DataColumn columnschmObjName;
            private DataColumn columnworkApply;
            private DataColumn columnworkCompiler;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate193 ReportDailyLVRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate193 ReportDailyLVRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate193 ReportDailyLVRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate193 ReportDailyLVRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public ReportDailyLVDataTable()
            {
                base.TableName = "ReportDailyLV";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ReportDailyLVDataTable(DataTable dataTable_0)
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected ReportDailyLVDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.ReportDailyLVDataTable table1 = (DataSetDamage.ReportDailyLVDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.ReportDailyLVDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class333);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetDamage.Class333 class333_0)
            {
                base.Rows.Add(class333_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class333 method_1(int int_0, string string_0, DateTime dateTime_0, string string_1, string string_2, int int_1, string string_3, string string_4, DateTime dateTime_1, string string_5, string string_6, string string_7, string string_8)
            {
                DataSetDamage.Class333 row = (DataSetDamage.Class333) base.NewRow();
                object[] objArray = new object[] { int_0, string_0, dateTime_0, string_1, string_2, int_1, string_3, string_4, dateTime_1, string_5, string_6, string_7, string_8 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnid = base.Columns["id"];
                this.columnnumRequest = base.Columns["numRequest"];
                this.columndateDoc = base.Columns["dateDoc"];
                this.columndefectLocation = base.Columns["defectLocation"];
                this.columnReason = base.Columns["Reason"];
                this.columnidSchmObj = base.Columns["idSchmObj"];
                this.columnschmObjName = base.Columns["schmObjName"];
                this.columnCharacter = base.Columns["Character"];
                this.columndateApply = base.Columns["dateApply"];
                this.columncompletedWork = base.Columns["completedWork"];
                this.columnworkCompiler = base.Columns["workCompiler"];
                this.columnworkApply = base.Columns["workApply"];
                this.columnNetRegion = base.Columns["NetRegion"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnnumRequest = new DataColumn("numRequest", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnumRequest);
                this.columndateDoc = new DataColumn("dateDoc", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateDoc);
                this.columndefectLocation = new DataColumn("defectLocation", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndefectLocation);
                this.columnReason = new DataColumn("Reason", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnidSchmObj = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSchmObj);
                this.columnschmObjName = new DataColumn("schmObjName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnschmObjName);
                this.columnCharacter = new DataColumn("Character", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnCharacter);
                this.columndateApply = new DataColumn("dateApply", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateApply);
                this.columncompletedWork = new DataColumn("completedWork", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncompletedWork);
                this.columnworkCompiler = new DataColumn("workCompiler", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnworkCompiler);
                this.columnworkApply = new DataColumn("workApply", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnworkApply);
                this.columnNetRegion = new DataColumn("NetRegion", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNetRegion);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class333 method_4()
            {
                return (DataSetDamage.Class333) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(DataSetDamage.Class333 class333_0)
            {
                base.Rows.Remove(class333_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class333(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.ReportDailyLVRowChanged != null)
                {
                    this.ReportDailyLVRowChanged(this, new DataSetDamage.EventArgs189((DataSetDamage.Class333) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.ReportDailyLVRowChanging != null)
                {
                    this.ReportDailyLVRowChanging(this, new DataSetDamage.EventArgs189((DataSetDamage.Class333) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.ReportDailyLVRowDeleted != null)
                {
                    this.ReportDailyLVRowDeleted(this, new DataSetDamage.EventArgs189((DataSetDamage.Class333) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.ReportDailyLVRowDeleting != null)
                {
                    this.ReportDailyLVRowDeleting(this, new DataSetDamage.EventArgs189((DataSetDamage.Class333) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "ReportDailyLVDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CharacterColumn
            {
                get
                {
                    return this.columnCharacter;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn completedWorkColumn
            {
                get
                {
                    return this.columncompletedWork;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateApplyColumn
            {
                get
                {
                    return this.columndateApply;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateDocColumn
            {
                get
                {
                    return this.columndateDoc;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn defectLocationColumn
            {
                get
                {
                    return this.columndefectLocation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idSchmObjColumn
            {
                get
                {
                    return this.columnidSchmObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class333 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class333) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NetRegionColumn
            {
                get
                {
                    return this.columnNetRegion;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn numRequestColumn
            {
                get
                {
                    return this.columnnumRequest;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ReasonColumn
            {
                get
                {
                    return this.columnReason;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn schmObjNameColumn
            {
                get
                {
                    return this.columnschmObjName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn workApplyColumn
            {
                get
                {
                    return this.columnworkApply;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn workCompilerColumn
            {
                get
                {
                    return this.columnworkCompiler;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class table23DataTable : TypedTableBase<DataSetDamage.Class342>
        {
            private DataColumn columnDescription;
            private DataColumn columnNPA;
            private DataColumn columnOrg;
            private DataColumn columnPunktNPA;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate202 table23RowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate202 table23RowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate202 table23RowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate202 table23RowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public table23DataTable()
            {
                base.TableName = "table23";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal table23DataTable(DataTable dataTable_0)
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected table23DataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.table23DataTable table1 = (DataSetDamage.table23DataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.table23DataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class342);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetDamage.Class342 class342_0)
            {
                base.Rows.Add(class342_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class342 method_1(string string_0, string string_1, string string_2, string string_3)
            {
                DataSetDamage.Class342 row = (DataSetDamage.Class342) base.NewRow();
                object[] objArray = new object[] { string_0, string_1, string_2, string_3 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnDescription = base.Columns["Description"];
                this.columnNPA = base.Columns["NPA"];
                this.columnPunktNPA = base.Columns["PunktNPA"];
                this.columnOrg = base.Columns["Org"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDescription);
                this.columnNPA = new DataColumn("NPA", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNPA);
                this.columnPunktNPA = new DataColumn("PunktNPA", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPunktNPA);
                this.columnOrg = new DataColumn("Org", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnOrg);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class342 method_4()
            {
                return (DataSetDamage.Class342) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(DataSetDamage.Class342 class342_0)
            {
                base.Rows.Remove(class342_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class342(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.table23RowChanged != null)
                {
                    this.table23RowChanged(this, new DataSetDamage.EventArgs198((DataSetDamage.Class342) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.table23RowChanging != null)
                {
                    this.table23RowChanging(this, new DataSetDamage.EventArgs198((DataSetDamage.Class342) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.table23RowDeleted != null)
                {
                    this.table23RowDeleted(this, new DataSetDamage.EventArgs198((DataSetDamage.Class342) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.table23RowDeleting != null)
                {
                    this.table23RowDeleting(this, new DataSetDamage.EventArgs198((DataSetDamage.Class342) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "table23DataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DescriptionColumn
            {
                get
                {
                    return this.columnDescription;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class342 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class342) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NPAColumn
            {
                get
                {
                    return this.columnNPA;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn OrgColumn
            {
                get
                {
                    return this.columnOrg;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PunktNPAColumn
            {
                get
                {
                    return this.columnPunktNPA;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class table31DataTable : TypedTableBase<DataSetDamage.Class343>
        {
            private DataColumn columnDate;
            private DataColumn columnMeasure;
            private DataColumn columnOrg;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate203 table31RowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate203 table31RowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate203 table31RowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate203 table31RowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public table31DataTable()
            {
                base.TableName = "table31";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal table31DataTable(DataTable dataTable_0)
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected table31DataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetDamage.table31DataTable table1 = (DataSetDamage.table31DataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.table31DataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class343);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetDamage.Class343 class343_0)
            {
                base.Rows.Add(class343_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class343 method_1(string string_0, string string_1, string string_2)
            {
                DataSetDamage.Class343 row = (DataSetDamage.Class343) base.NewRow();
                object[] objArray = new object[] { string_0, string_1, string_2 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnMeasure = base.Columns["Measure"];
                this.columnDate = base.Columns["Date"];
                this.columnOrg = base.Columns["Org"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnMeasure = new DataColumn("Measure", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnMeasure);
                this.columnDate = new DataColumn("Date", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDate);
                this.columnOrg = new DataColumn("Org", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnOrg);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class343 method_4()
            {
                return (DataSetDamage.Class343) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(DataSetDamage.Class343 class343_0)
            {
                base.Rows.Remove(class343_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class343(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.table31RowChanged != null)
                {
                    this.table31RowChanged(this, new DataSetDamage.EventArgs199((DataSetDamage.Class343) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.table31RowChanging != null)
                {
                    this.table31RowChanging(this, new DataSetDamage.EventArgs199((DataSetDamage.Class343) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.table31RowDeleted != null)
                {
                    this.table31RowDeleted(this, new DataSetDamage.EventArgs199((DataSetDamage.Class343) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.table31RowDeleting != null)
                {
                    this.table31RowDeleting(this, new DataSetDamage.EventArgs199((DataSetDamage.Class343) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "table31DataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateColumn
            {
                get
                {
                    return this.columnDate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class343 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class343) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn MeasureColumn
            {
                get
                {
                    return this.columnMeasure;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn OrgColumn
            {
                get
                {
                    return this.columnOrg;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class table4DataTable : TypedTableBase<DataSetDamage.Class344>
        {
            private DataColumn columnDescription;
            private DataColumn columnnum;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate204 table4RowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate204 table4RowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate204 table4RowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate204 table4RowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public table4DataTable()
            {
                base.TableName = "table4";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal table4DataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected table4DataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.table4DataTable table1 = (DataSetDamage.table4DataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.table4DataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class344);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetDamage.Class344 class344_0)
            {
                base.Rows.Add(class344_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class344 method_1(string string_0, string string_1)
            {
                DataSetDamage.Class344 row = (DataSetDamage.Class344) base.NewRow();
                object[] objArray = new object[] { string_0, string_1 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnnum = base.Columns["num"];
                this.columnDescription = base.Columns["Description"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnnum = new DataColumn("num", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnum);
                this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDescription);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class344 method_4()
            {
                return (DataSetDamage.Class344) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(DataSetDamage.Class344 class344_0)
            {
                base.Rows.Remove(class344_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class344(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.table4RowChanged != null)
                {
                    this.table4RowChanged(this, new DataSetDamage.EventArgs200((DataSetDamage.Class344) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.table4RowChanging != null)
                {
                    this.table4RowChanging(this, new DataSetDamage.EventArgs200((DataSetDamage.Class344) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.table4RowDeleted != null)
                {
                    this.table4RowDeleted(this, new DataSetDamage.EventArgs200((DataSetDamage.Class344) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.table4RowDeleting != null)
                {
                    this.table4RowDeleting(this, new DataSetDamage.EventArgs200((DataSetDamage.Class344) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "table4DataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DescriptionColumn
            {
                get
                {
                    return this.columnDescription;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class344 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class344) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn numColumn
            {
                get
                {
                    return this.columnnum;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_DamageActDetectionDataTable : TypedTableBase<DataSetDamage.Class341>
        {
            private DataColumn columnComission;
            private DataColumn columndateEndCrashLocal;
            private DataColumn columndateEndCrashMoscow;
            private DataColumn columnDefection;
            private DataColumn columnidClassifierDamage;
            private DataColumn columnidDamage;
            private DataColumn columnidFault;
            private DataColumn columnidOrg;
            private DataColumn columnidReasonBeginCrash;
            private DataColumn columnidReasonCrash;
            private DataColumn columnidReasonCrashEquipment;
            private DataColumn columnidSignCrash;
            private DataColumn columnidStatusBeforeCrash;
            private DataColumn columnidStatusCurrentCrash;
            private DataColumn columnidTypeEquipment;
            private DataColumn columnisCrash;
            private DataColumn columnisNoOff;
            private DataColumn columnNoCrashMeasure;
            private DataColumn columnnumCrash;
            private DataColumn columnReasonBeginCrash;
            private DataColumn columnStatusCurrentCrash;
            private DataColumn columnTotalComission;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate201 tJ_DamageActDetectionRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate201 tJ_DamageActDetectionRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate201 tJ_DamageActDetectionRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate201 tJ_DamageActDetectionRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tJ_DamageActDetectionDataTable()
            {
                base.TableName = "tJ_DamageActDetection";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_DamageActDetectionDataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tJ_DamageActDetectionDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetDamage.tJ_DamageActDetectionDataTable table1 = (DataSetDamage.tJ_DamageActDetectionDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tJ_DamageActDetectionDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class341);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetDamage.Class341 class341_0)
            {
                base.Rows.Add(class341_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class341 method_1(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, DateTime dateTime_0, DateTime dateTime_1, int int_6, bool bool_0, bool bool_1, string string_0, int int_7, string string_1, int int_8, int int_9, int int_10, string string_2, string string_3, string string_4, string string_5, string string_6)
            {
                DataSetDamage.Class341 row = (DataSetDamage.Class341) base.NewRow();
                object[] objArray = new object[] { 
                    int_0, int_1, int_2, int_3, int_4, int_5, dateTime_0, dateTime_1, int_6, bool_0, bool_1, string_0, int_7, string_1, int_8, int_9,
                    int_10, string_2, string_3, string_4, string_5, string_6
                };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class341 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetDamage.Class341) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnidDamage = base.Columns["idDamage"];
                this.columnidOrg = base.Columns["idOrg"];
                this.columnidSignCrash = base.Columns["idSignCrash"];
                this.columnidTypeEquipment = base.Columns["idTypeEquipment"];
                this.columnidReasonCrash = base.Columns["idReasonCrash"];
                this.columnidReasonCrashEquipment = base.Columns["idReasonCrashEquipment"];
                this.columndateEndCrashLocal = base.Columns["dateEndCrashLocal"];
                this.columndateEndCrashMoscow = base.Columns["dateEndCrashMoscow"];
                this.columnidStatusBeforeCrash = base.Columns["idStatusBeforeCrash"];
                this.columnisCrash = base.Columns["isCrash"];
                this.columnisNoOff = base.Columns["isNoOff"];
                this.columnNoCrashMeasure = base.Columns["NoCrashMeasure"];
                this.columnidStatusCurrentCrash = base.Columns["idStatusCurrentCrash"];
                this.columnDefection = base.Columns["Defection"];
                this.columnidReasonBeginCrash = base.Columns["idReasonBeginCrash"];
                this.columnidClassifierDamage = base.Columns["idClassifierDamage"];
                this.columnidFault = base.Columns["idFault"];
                this.columnComission = base.Columns["Comission"];
                this.columnTotalComission = base.Columns["TotalComission"];
                this.columnnumCrash = base.Columns["numCrash"];
                this.columnStatusCurrentCrash = base.Columns["StatusCurrentCrash"];
                this.columnReasonBeginCrash = base.Columns["ReasonBeginCrash"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnidDamage = new DataColumn("idDamage", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidDamage);
                this.columnidOrg = new DataColumn("idOrg", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidOrg);
                this.columnidSignCrash = new DataColumn("idSignCrash", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSignCrash);
                this.columnidTypeEquipment = new DataColumn("idTypeEquipment", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidTypeEquipment);
                this.columnidReasonCrash = new DataColumn("idReasonCrash", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidReasonCrash);
                this.columnidReasonCrashEquipment = new DataColumn("idReasonCrashEquipment", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidReasonCrashEquipment);
                this.columndateEndCrashLocal = new DataColumn("dateEndCrashLocal", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateEndCrashLocal);
                this.columndateEndCrashMoscow = new DataColumn("dateEndCrashMoscow", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateEndCrashMoscow);
                this.columnidStatusBeforeCrash = new DataColumn("idStatusBeforeCrash", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidStatusBeforeCrash);
                this.columnisCrash = new DataColumn("isCrash", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisCrash);
                this.columnisNoOff = new DataColumn("isNoOff", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisNoOff);
                this.columnNoCrashMeasure = new DataColumn("NoCrashMeasure", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNoCrashMeasure);
                this.columnidStatusCurrentCrash = new DataColumn("idStatusCurrentCrash", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidStatusCurrentCrash);
                this.columnDefection = new DataColumn("Defection", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDefection);
                this.columnidReasonBeginCrash = new DataColumn("idReasonBeginCrash", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidReasonBeginCrash);
                this.columnidClassifierDamage = new DataColumn("idClassifierDamage", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidClassifierDamage);
                this.columnidFault = new DataColumn("idFault", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidFault);
                this.columnComission = new DataColumn("Comission", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComission);
                this.columnTotalComission = new DataColumn("TotalComission", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTotalComission);
                this.columnnumCrash = new DataColumn("numCrash", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnumCrash);
                this.columnStatusCurrentCrash = new DataColumn("StatusCurrentCrash", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnStatusCurrentCrash);
                this.columnReasonBeginCrash = new DataColumn("ReasonBeginCrash", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReasonBeginCrash);
                DataColumn[] columns = new DataColumn[] { this.columnidDamage };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnidDamage.AllowDBNull = false;
                this.columnidDamage.Unique = true;
                this.columnNoCrashMeasure.MaxLength = 0x7fffffff;
                this.columnDefection.MaxLength = 0x7fffffff;
                this.columnComission.MaxLength = 0x7fffffff;
                this.columnTotalComission.MaxLength = 0x7d0;
                this.columnStatusCurrentCrash.MaxLength = 0x7d0;
                this.columnReasonBeginCrash.MaxLength = 0x7d0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class341 method_5()
            {
                return (DataSetDamage.Class341) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetDamage.Class341 class341_0)
            {
                base.Rows.Remove(class341_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class341(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_DamageActDetectionRowChanged != null)
                {
                    this.tJ_DamageActDetectionRowChanged(this, new DataSetDamage.EventArgs197((DataSetDamage.Class341) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_DamageActDetectionRowChanging != null)
                {
                    this.tJ_DamageActDetectionRowChanging(this, new DataSetDamage.EventArgs197((DataSetDamage.Class341) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_DamageActDetectionRowDeleted != null)
                {
                    this.tJ_DamageActDetectionRowDeleted(this, new DataSetDamage.EventArgs197((DataSetDamage.Class341) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_DamageActDetectionRowDeleting != null)
                {
                    this.tJ_DamageActDetectionRowDeleting(this, new DataSetDamage.EventArgs197((DataSetDamage.Class341) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_DamageActDetectionDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ComissionColumn
            {
                get
                {
                    return this.columnComission;
                }
            }

            [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateEndCrashLocalColumn
            {
                get
                {
                    return this.columndateEndCrashLocal;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateEndCrashMoscowColumn
            {
                get
                {
                    return this.columndateEndCrashMoscow;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DefectionColumn
            {
                get
                {
                    return this.columnDefection;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idClassifierDamageColumn
            {
                get
                {
                    return this.columnidClassifierDamage;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idDamageColumn
            {
                get
                {
                    return this.columnidDamage;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idFaultColumn
            {
                get
                {
                    return this.columnidFault;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idOrgColumn
            {
                get
                {
                    return this.columnidOrg;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idReasonBeginCrashColumn
            {
                get
                {
                    return this.columnidReasonBeginCrash;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idReasonCrashColumn
            {
                get
                {
                    return this.columnidReasonCrash;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idReasonCrashEquipmentColumn
            {
                get
                {
                    return this.columnidReasonCrashEquipment;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idSignCrashColumn
            {
                get
                {
                    return this.columnidSignCrash;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idStatusBeforeCrashColumn
            {
                get
                {
                    return this.columnidStatusBeforeCrash;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idStatusCurrentCrashColumn
            {
                get
                {
                    return this.columnidStatusCurrentCrash;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idTypeEquipmentColumn
            {
                get
                {
                    return this.columnidTypeEquipment;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn isCrashColumn
            {
                get
                {
                    return this.columnisCrash;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn isNoOffColumn
            {
                get
                {
                    return this.columnisNoOff;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class341 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class341) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NoCrashMeasureColumn
            {
                get
                {
                    return this.columnNoCrashMeasure;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn numCrashColumn
            {
                get
                {
                    return this.columnnumCrash;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ReasonBeginCrashColumn
            {
                get
                {
                    return this.columnReasonBeginCrash;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn StatusCurrentCrashColumn
            {
                get
                {
                    return this.columnStatusCurrentCrash;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TotalComissionColumn
            {
                get
                {
                    return this.columnTotalComission;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_DamageCharacterDataTable : TypedTableBase<DataSetDamage.Class340>
        {
            private DataColumn columnAssociatedFact;
            private DataColumn columnAutoProtect;
            private DataColumn columnClauseFail;
            private DataColumn columnClauseWork;
            private DataColumn columncol1;
            private DataColumn columncol2;
            private DataColumn columncol3;
            private DataColumn columnCountDefectEquipment;
            private DataColumn columnFactoryNumber;
            private DataColumn columnid;
            private DataColumn columnidCharacterDamage;
            private DataColumn columnidCharacterParent;
            private DataColumn columnidDamage;
            private DataColumn columnidLineSection;
            private DataColumn columnidMark;
            private DataColumn columnidMaterial;
            private DataColumn columnidNeutralState;
            private DataColumn columnidParameters;
            private DataColumn columnidReasonDamage;
            private DataColumn columnidSchmObj;
            private DataColumn columnidVoltage;
            private DataColumn columnidVoltageSeti;
            private DataColumn columnLastDateTest;
            private DataColumn columnlenghtWorkEquipment;
            private DataColumn columnLengthLine;
            private DataColumn columnLengthOverload;
            private DataColumn columnManufacturer;
            private DataColumn columnnodeDetail;
            private DataColumn columnnodeDetailTxt;
            private DataColumn columnParameters;
            private DataColumn columnSchmObjName;
            private DataColumn columntimeRecovery;
            private DataColumn columnyearBegEquipment;
            private DataColumn columnYearManufacture;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate200 tJ_DamageCharacterRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate200 tJ_DamageCharacterRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate200 tJ_DamageCharacterRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate200 tJ_DamageCharacterRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tJ_DamageCharacterDataTable()
            {
                base.TableName = "tJ_DamageCharacter";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_DamageCharacterDataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tJ_DamageCharacterDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetDamage.tJ_DamageCharacterDataTable table1 = (DataSetDamage.tJ_DamageCharacterDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tJ_DamageCharacterDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class340);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetDamage.Class340 class340_0)
            {
                base.Rows.Add(class340_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class340 method_1(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, string string_0, int int_7, int int_8, int int_9, int int_10, string string_1, int int_11, int int_12, bool bool_0, string string_2, string string_3, short short_0, int int_13, int int_14, int int_15, int int_16, int int_17, int int_18, int int_19, int int_20, string string_4, int int_21, int int_22, DateTime dateTime_0, DateTime dateTime_1, string string_5)
            {
                DataSetDamage.Class340 row = (DataSetDamage.Class340) base.NewRow();
                object[] objArray1 = new object[0x22];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = int_2;
                objArray1[4] = int_3;
                objArray1[5] = int_4;
                objArray1[6] = int_5;
                objArray1[7] = int_6;
                objArray1[8] = string_0;
                objArray1[9] = int_7;
                objArray1[10] = int_8;
                objArray1[11] = int_9;
                objArray1[12] = int_10;
                objArray1[13] = string_1;
                objArray1[14] = int_11;
                objArray1[15] = int_12;
                objArray1[0x10] = bool_0;
                objArray1[0x11] = string_2;
                objArray1[0x12] = string_3;
                objArray1[0x13] = short_0;
                objArray1[20] = int_13;
                objArray1[0x15] = int_14;
                objArray1[0x16] = int_15;
                objArray1[0x17] = int_16;
                objArray1[0x18] = int_17;
                objArray1[0x19] = int_18;
                objArray1[0x1a] = int_19;
                objArray1[0x1b] = int_20;
                objArray1[0x1c] = string_4;
                objArray1[0x1d] = int_21;
                objArray1[30] = int_22;
                objArray1[0x1f] = dateTime_0;
                objArray1[0x20] = dateTime_1;
                objArray1[0x21] = string_5;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class340 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetDamage.Class340) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid =     base.Columns["id"];
                this.columnidDamage =   base.Columns["idDamage"];
                this.columncol1 = base.Columns["col1"];
                this.columncol2 = base.Columns["col2"];
                this.columncol3 = base.Columns["col3"];
                this.columnidSchmObj = base.Columns["idSchmObj"];
                this.columnidLineSection = base.Columns["idLineSection"];
                this.columnidCharacterParent = base.Columns["idCharacterParent"];
                this.columnParameters = base.Columns["Parameters"];
                this.columnidMark = base.Columns["idMark"];
                this.columnidParameters = base.Columns["idParameters"];
                this.columnidVoltage = base.Columns["idVoltage"];
                this.columnnodeDetail = base.Columns["nodeDetail"];
                this.columnnodeDetailTxt = base.Columns["nodeDetailTxt"];
                this.columnCountDefectEquipment = base.Columns["CountDefectEquipment"];
                this.columnidVoltageSeti = base.Columns["idVoltageSeti"];
                this.columnAutoProtect = base.Columns["AutoProtect"];
                this.columnManufacturer = base.Columns["Manufacturer"];
                this.columnFactoryNumber = base.Columns["FactoryNumber"];
                this.columnYearManufacture = base.Columns["YearManufacture"];
                this.columnidNeutralState = base.Columns["idNeutralState"];
                this.columnClauseFail = base.Columns["ClauseFail"];
                this.columnLengthOverload = base.Columns["LengthOverload"];
                this.columnLengthLine = base.Columns["LengthLine"];
                this.columnidMaterial = base.Columns["idMaterial"];
                this.columnClauseWork = base.Columns["ClauseWork"];
                this.columnidCharacterDamage = base.Columns["idCharacterDamage"];
                this.columnidReasonDamage = base.Columns["idReasonDamage"];
                this.columnAssociatedFact = base.Columns["AssociatedFact"];
                this.columnyearBegEquipment = base.Columns["yearBegEquipment"];
                this.columnlenghtWorkEquipment = base.Columns["lenghtWorkEquipment"];
                this.columnLastDateTest = base.Columns["LastDateTest"];
                this.columntimeRecovery = base.Columns["timeRecovery"];
                this.columnSchmObjName = base.Columns["SchmObjName"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidDamage = new DataColumn("idDamage", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidDamage);
                this.columncol1 = new DataColumn("col1", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columncol1);
                this.columncol2 = new DataColumn("col2", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columncol2);
                this.columncol3 = new DataColumn("col3", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columncol3);
                this.columnidSchmObj = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSchmObj);
                this.columnidLineSection = new DataColumn("idLineSection", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidLineSection);
                this.columnidCharacterParent = new DataColumn("idCharacterParent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidCharacterParent);
                this.columnParameters = new DataColumn("Parameters", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnParameters);
                this.columnidMark = new DataColumn("idMark", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidMark);
                this.columnidParameters = new DataColumn("idParameters", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidParameters);
                this.columnidVoltage = new DataColumn("idVoltage", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidVoltage);
                this.columnnodeDetail = new DataColumn("nodeDetail", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnodeDetail);
                this.columnnodeDetailTxt = new DataColumn("nodeDetailTxt", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnodeDetailTxt);
                this.columnCountDefectEquipment = new DataColumn("CountDefectEquipment", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCountDefectEquipment);
                this.columnidVoltageSeti = new DataColumn("idVoltageSeti", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidVoltageSeti);
                this.columnAutoProtect = new DataColumn("AutoProtect", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnAutoProtect);
                this.columnManufacturer = new DataColumn("Manufacturer", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnManufacturer);
                this.columnFactoryNumber = new DataColumn("FactoryNumber", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFactoryNumber);
                this.columnYearManufacture = new DataColumn("YearManufacture", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnYearManufacture);
                this.columnidNeutralState = new DataColumn("idNeutralState", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidNeutralState);
                this.columnClauseFail = new DataColumn("ClauseFail", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnClauseFail);
                this.columnLengthOverload = new DataColumn("LengthOverload", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnLengthOverload);
                this.columnLengthLine = new DataColumn("LengthLine", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnLengthLine);
                this.columnidMaterial = new DataColumn("idMaterial", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidMaterial);
                this.columnClauseWork = new DataColumn("ClauseWork", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnClauseWork);
                this.columnidCharacterDamage = new DataColumn("idCharacterDamage", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidCharacterDamage);
                this.columnidReasonDamage = new DataColumn("idReasonDamage", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidReasonDamage);
                this.columnAssociatedFact = new DataColumn("AssociatedFact", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnAssociatedFact);
                this.columnyearBegEquipment = new DataColumn("yearBegEquipment", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnyearBegEquipment);
                this.columnlenghtWorkEquipment = new DataColumn("lenghtWorkEquipment", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnlenghtWorkEquipment);
                this.columnLastDateTest = new DataColumn("LastDateTest", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnLastDateTest);
                this.columntimeRecovery = new DataColumn("timeRecovery", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columntimeRecovery);
                this.columnSchmObjName = new DataColumn("SchmObjName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnSchmObjName);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidDamage.AllowDBNull = false;
                this.columnParameters.MaxLength = 0x7fffffff;
                this.columnnodeDetailTxt.MaxLength = 0x100;
                this.columnManufacturer.MaxLength = 0x80;
                this.columnFactoryNumber.MaxLength = 0x80;
                this.columnAssociatedFact.MaxLength = 0x200;
                this.columnSchmObjName.MaxLength = 0x100;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class340 method_5()
            {
                return (DataSetDamage.Class340) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetDamage.Class340 class340_0)
            {
                base.Rows.Remove(class340_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class340(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_DamageCharacterRowChanged != null)
                {
                    this.tJ_DamageCharacterRowChanged(this, new DataSetDamage.EventArgs196((DataSetDamage.Class340) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_DamageCharacterRowChanging != null)
                {
                    this.tJ_DamageCharacterRowChanging(this, new DataSetDamage.EventArgs196((DataSetDamage.Class340) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_DamageCharacterRowDeleted != null)
                {
                    this.tJ_DamageCharacterRowDeleted(this, new DataSetDamage.EventArgs196((DataSetDamage.Class340) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_DamageCharacterRowDeleting != null)
                {
                    this.tJ_DamageCharacterRowDeleting(this, new DataSetDamage.EventArgs196((DataSetDamage.Class340) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_DamageCharacterDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AssociatedFactColumn
            {
                get
                {
                    return this.columnAssociatedFact;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AutoProtectColumn
            {
                get
                {
                    return this.columnAutoProtect;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ClauseFailColumn
            {
                get
                {
                    return this.columnClauseFail;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ClauseWorkColumn
            {
                get
                {
                    return this.columnClauseWork;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn col1Column
            {
                get
                {
                    return this.columncol1;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn col2Column
            {
                get
                {
                    return this.columncol2;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn col3Column
            {
                get
                {
                    return this.columncol3;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CountDefectEquipmentColumn
            {
                get
                {
                    return this.columnCountDefectEquipment;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn FactoryNumberColumn
            {
                get
                {
                    return this.columnFactoryNumber;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idCharacterDamageColumn
            {
                get
                {
                    return this.columnidCharacterDamage;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idCharacterParentColumn
            {
                get
                {
                    return this.columnidCharacterParent;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idDamageColumn
            {
                get
                {
                    return this.columnidDamage;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idLineSectionColumn
            {
                get
                {
                    return this.columnidLineSection;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idMarkColumn
            {
                get
                {
                    return this.columnidMark;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idMaterialColumn
            {
                get
                {
                    return this.columnidMaterial;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idNeutralStateColumn
            {
                get
                {
                    return this.columnidNeutralState;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idParametersColumn
            {
                get
                {
                    return this.columnidParameters;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idReasonDamageColumn
            {
                get
                {
                    return this.columnidReasonDamage;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idSchmObjColumn
            {
                get
                {
                    return this.columnidSchmObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idVoltageColumn
            {
                get
                {
                    return this.columnidVoltage;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idVoltageSetiColumn
            {
                get
                {
                    return this.columnidVoltageSeti;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class340 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class340) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LastDateTestColumn
            {
                get
                {
                    return this.columnLastDateTest;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn lenghtWorkEquipmentColumn
            {
                get
                {
                    return this.columnlenghtWorkEquipment;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LengthLineColumn
            {
                get
                {
                    return this.columnLengthLine;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LengthOverloadColumn
            {
                get
                {
                    return this.columnLengthOverload;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ManufacturerColumn
            {
                get
                {
                    return this.columnManufacturer;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nodeDetailColumn
            {
                get
                {
                    return this.columnnodeDetail;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn nodeDetailTxtColumn
            {
                get
                {
                    return this.columnnodeDetailTxt;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ParametersColumn
            {
                get
                {
                    return this.columnParameters;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SchmObjNameColumn
            {
                get
                {
                    return this.columnSchmObjName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn timeRecoveryColumn
            {
                get
                {
                    return this.columntimeRecovery;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn yearBegEquipmentColumn
            {
                get
                {
                    return this.columnyearBegEquipment;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn YearManufactureColumn
            {
                get
                {
                    return this.columnYearManufacture;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_DamageDataTable : TypedTableBase<DataSetDamage.Class328>
        {
            private DataColumn columnComletedWorkText;
            private DataColumn columnCompletedWorkTextODS;
            private DataColumn columnDateApply;
            private DataColumn columnDateDoc;
            private DataColumn columnDateOwner;
            private DataColumn columnDatePlanApply;
            private DataColumn columnDefectLocation;
            private DataColumn columndeleted;
            private DataColumn columnDivisionInstruction;
            private DataColumn columnid;
            private DataColumn columnidCompiler;
            private DataColumn columnidCompletedWork;
            private DataColumn columnidCompletedWorkODS;
            private DataColumn columnidDivision;
            private DataColumn columnidDivisionApply;
            private DataColumn columnidMap;
            private DataColumn columnidOwner;
            private DataColumn columnidParent;
            private DataColumn columnidReason;
            private DataColumn columnidReasonPTS;
            private DataColumn columnidReqForRepair;
            private DataColumn columnidSchmObj;
            private DataColumn columnidWorkerApply;
            private DataColumn columnisApply;
            private DataColumn columnisLaboratory;
            private DataColumn columnLaboratoryInstruction;
            private DataColumn columnnumDoc;
            private DataColumn columnNumRequest;
            private DataColumn columnTypeDoc;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate188 tJ_DamageRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate188 tJ_DamageRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate188 tJ_DamageRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate188 tJ_DamageRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tJ_DamageDataTable()
            {
                base.TableName = "tJ_Damage";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_DamageDataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tJ_DamageDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.tJ_DamageDataTable table1 = (DataSetDamage.tJ_DamageDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tJ_DamageDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class328);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetDamage.Class328 class328_0)
            {
                base.Rows.Add(class328_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class328 method_1(int int_0, DateTime dateTime_0, int int_1, string string_0, int int_2, int int_3, int int_4, int int_5, string string_1, int int_6, int int_7, string string_2, bool bool_0, int int_8, DateTime dateTime_1, DateTime dateTime_2, int int_9, bool bool_1, int int_10, int int_11, DateTime dateTime_3, int int_12, string string_3, string string_4, int int_13, string string_5, bool bool_2, int int_14)
            {
                DataSetDamage.Class328 row = (DataSetDamage.Class328) base.NewRow();
                object[] objArray1 = new object[0x1d];
                objArray1[1] = int_0;
                objArray1[2] = dateTime_0;
                objArray1[3] = int_1;
                objArray1[4] = string_0;
                objArray1[5] = int_2;
                objArray1[6] = int_3;
                objArray1[7] = int_4;
                objArray1[8] = int_5;
                objArray1[9] = string_1;
                objArray1[10] = int_6;
                objArray1[11] = int_7;
                objArray1[12] = string_2;
                objArray1[13] = bool_0;
                objArray1[14] = int_8;
                objArray1[15] = dateTime_1;
                objArray1[0x10] = dateTime_2;
                objArray1[0x11] = int_9;
                objArray1[0x12] = bool_1;
                objArray1[0x13] = int_10;
                objArray1[20] = int_11;
                objArray1[0x15] = dateTime_3;
                objArray1[0x16] = int_12;
                objArray1[0x17] = string_3;
                objArray1[0x18] = string_4;
                objArray1[0x19] = int_13;
                objArray1[0x1a] = string_5;
                objArray1[0x1b] = bool_2;
                objArray1[0x1c] = int_14;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class328 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetDamage.Class328) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
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
                this.columnDefectLocation = base.Columns["DefectLocation"];
                this.columnidReason = base.Columns["idReason"];
                this.columnidCompletedWork = base.Columns["idCompletedWork"];
                this.columnComletedWorkText = base.Columns["ComletedWorkText"];
                this.columnisApply = base.Columns["isApply"];
                this.columnidWorkerApply = base.Columns["idWorkerApply"];
                this.columnDatePlanApply = base.Columns["DatePlanApply"];
                this.columnDateApply = base.Columns["DateApply"];
                this.columnidDivisionApply = base.Columns["idDivisionApply"];
                this.columnisLaboratory = base.Columns["isLaboratory"];
                this.columnidParent = base.Columns["idParent"];
                this.columnidOwner = base.Columns["idOwner"];
                this.columnDateOwner = base.Columns["DateOwner"];
                this.columnidReasonPTS = base.Columns["idReasonPTS"];
                this.columnDivisionInstruction = base.Columns["DivisionInstruction"];
                this.columnLaboratoryInstruction = base.Columns["LaboratoryInstruction"];
                this.columnidCompletedWorkODS = base.Columns["idCompletedWorkODS"];
                this.columnCompletedWorkTextODS = base.Columns["CompletedWorkTextODS"];
                this.columndeleted = base.Columns["deleted"];
                this.columnidReqForRepair = base.Columns["idReqForRepair"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
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
                this.columnDatePlanApply = new DataColumn("DatePlanApply", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDatePlanApply);
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
                this.columndeleted = new DataColumn("deleted", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columndeleted);
                this.columnidReqForRepair = new DataColumn("idReqForRepair", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidReqForRepair);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnTypeDoc.AllowDBNull = false;
                this.columnNumRequest.MaxLength = 50;
                this.columnDefectLocation.MaxLength = 0x400;
                this.columnComletedWorkText.MaxLength = 0x7ec;
                this.columndeleted.AllowDBNull = false;
                this.columndeleted.DefaultValue = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class328 method_5()
            {
                return (DataSetDamage.Class328) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetDamage.Class328 class328_0)
            {
                base.Rows.Remove(class328_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class328(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_DamageRowChanged != null)
                {
                    this.tJ_DamageRowChanged(this, new DataSetDamage.EventArgs184((DataSetDamage.Class328) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_DamageRowChanging != null)
                {
                    this.tJ_DamageRowChanging(this, new DataSetDamage.EventArgs184((DataSetDamage.Class328) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_DamageRowDeleted != null)
                {
                    this.tJ_DamageRowDeleted(this, new DataSetDamage.EventArgs184((DataSetDamage.Class328) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_DamageRowDeleting != null)
                {
                    this.tJ_DamageRowDeleting(this, new DataSetDamage.EventArgs184((DataSetDamage.Class328) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_DamageDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ComletedWorkTextColumn
            {
                get
                {
                    return this.columnComletedWorkText;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CompletedWorkTextODSColumn
            {
                get
                {
                    return this.columnCompletedWorkTextODS;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateApplyColumn
            {
                get
                {
                    return this.columnDateApply;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateDocColumn
            {
                get
                {
                    return this.columnDateDoc;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateOwnerColumn
            {
                get
                {
                    return this.columnDateOwner;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DatePlanApplyColumn
            {
                get
                {
                    return this.columnDatePlanApply;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DefectLocationColumn
            {
                get
                {
                    return this.columnDefectLocation;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn deletedColumn
            {
                get
                {
                    return this.columndeleted;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DivisionInstructionColumn
            {
                get
                {
                    return this.columnDivisionInstruction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idCompilerColumn
            {
                get
                {
                    return this.columnidCompiler;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idCompletedWorkColumn
            {
                get
                {
                    return this.columnidCompletedWork;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idCompletedWorkODSColumn
            {
                get
                {
                    return this.columnidCompletedWorkODS;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idDivisionApplyColumn
            {
                get
                {
                    return this.columnidDivisionApply;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idDivisionColumn
            {
                get
                {
                    return this.columnidDivision;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idMapColumn
            {
                get
                {
                    return this.columnidMap;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idOwnerColumn
            {
                get
                {
                    return this.columnidOwner;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idParentColumn
            {
                get
                {
                    return this.columnidParent;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idReasonColumn
            {
                get
                {
                    return this.columnidReason;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idReasonPTSColumn
            {
                get
                {
                    return this.columnidReasonPTS;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idReqForRepairColumn
            {
                get
                {
                    return this.columnidReqForRepair;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idSchmObjColumn
            {
                get
                {
                    return this.columnidSchmObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idWorkerApplyColumn
            {
                get
                {
                    return this.columnidWorkerApply;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn isApplyColumn
            {
                get
                {
                    return this.columnisApply;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn isLaboratoryColumn
            {
                get
                {
                    return this.columnisLaboratory;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class328 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class328) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LaboratoryInstructionColumn
            {
                get
                {
                    return this.columnLaboratoryInstruction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn numDocColumn
            {
                get
                {
                    return this.columnnumDoc;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NumRequestColumn
            {
                get
                {
                    return this.columnNumRequest;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TypeDocColumn
            {
                get
                {
                    return this.columnTypeDoc;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_DamageHVDataTable : TypedTableBase<DataSetDamage.Class345>
        {
            private DataColumn columnAbnOff;
            private DataColumn columnAPR;
            private DataColumn columnAVR;
            private DataColumn columnCoefFI;
            private DataColumn columnCoefSeason;
            private DataColumn columnConnectedPower;
            private DataColumn columnCountSchmObj;
            private DataColumn columnCountSchmObjOff;
            private DataColumn columnidDamage;
            private DataColumn columnidTypeRZA;
            private DataColumn columnisAverage;
            private DataColumn columnNoAdmissionKWT;
            private DataColumn columnPowerA;
            private DataColumn columnPowerV;
            private DataColumn columnTransOff;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate205 tJ_DamageHVRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate205 tJ_DamageHVRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate205 tJ_DamageHVRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate205 tJ_DamageHVRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tJ_DamageHVDataTable()
            {
                base.TableName = "tJ_DamageHV";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_DamageHVDataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tJ_DamageHVDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetDamage.tJ_DamageHVDataTable table1 = (DataSetDamage.tJ_DamageHVDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tJ_DamageHVDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class345);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetDamage.Class345 class345_0)
            {
                base.Rows.Add(class345_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class345 method_1(int int_0, int int_1, int int_2, int int_3, decimal decimal_0, decimal decimal_1, decimal decimal_2, bool bool_0, bool bool_1, string string_0, string string_1, decimal decimal_3, decimal decimal_4, decimal decimal_5, bool bool_2)
            {
                DataSetDamage.Class345 row = (DataSetDamage.Class345) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, int_2, int_3, decimal_0, decimal_1, decimal_2, bool_0, bool_1, string_0, string_1, decimal_3, decimal_4, decimal_5, bool_2 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class345 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetDamage.Class345) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
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
                this.columnisAverage = base.Columns["isAverage"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
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
                this.columnisAverage = new DataColumn("isAverage", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisAverage);
                DataColumn[] columns = new DataColumn[] { this.columnidDamage };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnidDamage.AllowDBNull = false;
                this.columnidDamage.Unique = true;
                this.columnTransOff.MaxLength = 0x7fffffff;
                this.columnAbnOff.MaxLength = 0x7fffffff;
                this.columnisAverage.DefaultValue = true;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class345 method_5()
            {
                return (DataSetDamage.Class345) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetDamage.Class345 class345_0)
            {
                base.Rows.Remove(class345_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class345(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_DamageHVRowChanged != null)
                {
                    this.tJ_DamageHVRowChanged(this, new DataSetDamage.EventArgs201((DataSetDamage.Class345) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_DamageHVRowChanging != null)
                {
                    this.tJ_DamageHVRowChanging(this, new DataSetDamage.EventArgs201((DataSetDamage.Class345) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_DamageHVRowDeleted != null)
                {
                    this.tJ_DamageHVRowDeleted(this, new DataSetDamage.EventArgs201((DataSetDamage.Class345) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_DamageHVRowDeleting != null)
                {
                    this.tJ_DamageHVRowDeleting(this, new DataSetDamage.EventArgs201((DataSetDamage.Class345) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_DamageHVDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn AbnOffColumn
            {
                get
                {
                    return this.columnAbnOff;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn APRColumn
            {
                get
                {
                    return this.columnAPR;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn AVRColumn
            {
                get
                {
                    return this.columnAVR;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CoefFIColumn
            {
                get
                {
                    return this.columnCoefFI;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CoefSeasonColumn
            {
                get
                {
                    return this.columnCoefSeason;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ConnectedPowerColumn
            {
                get
                {
                    return this.columnConnectedPower;
                }
            }

            [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CountSchmObjColumn
            {
                get
                {
                    return this.columnCountSchmObj;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CountSchmObjOffColumn
            {
                get
                {
                    return this.columnCountSchmObjOff;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idDamageColumn
            {
                get
                {
                    return this.columnidDamage;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idTypeRZAColumn
            {
                get
                {
                    return this.columnidTypeRZA;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn isAverageColumn
            {
                get
                {
                    return this.columnisAverage;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class345 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class345) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NoAdmissionKWTColumn
            {
                get
                {
                    return this.columnNoAdmissionKWT;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PowerAColumn
            {
                get
                {
                    return this.columnPowerA;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PowerVColumn
            {
                get
                {
                    return this.columnPowerV;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TransOffColumn
            {
                get
                {
                    return this.columnTransOff;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_DamageLVDataTable : TypedTableBase<DataSetDamage.Class330>
        {
            private DataColumn columnAbnOff;
            private DataColumn columnDeclarer;
            private DataColumn columnDeclarerAddress;
            private DataColumn columnDeclarerTel;
            private DataColumn columnidDamage;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate190 tJ_DamageLVRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate190 tJ_DamageLVRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate190 tJ_DamageLVRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate190 tJ_DamageLVRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_DamageLVDataTable()
            {
                base.TableName = "tJ_DamageLV";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_DamageLVDataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tJ_DamageLVDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.tJ_DamageLVDataTable table1 = (DataSetDamage.tJ_DamageLVDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tJ_DamageLVDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class330);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetDamage.Class330 class330_0)
            {
                base.Rows.Add(class330_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class330 method_1(int int_0, string string_0, string string_1, string string_2, string string_3)
            {
                DataSetDamage.Class330 row = (DataSetDamage.Class330) base.NewRow();
                object[] objArray = new object[] { int_0, string_0, string_1, string_2, string_3 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class330 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetDamage.Class330) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnidDamage = base.Columns["idDamage"];
                this.columnDeclarer = base.Columns["Declarer"];
                this.columnDeclarerTel = base.Columns["DeclarerTel"];
                this.columnDeclarerAddress = base.Columns["DeclarerAddress"];
                this.columnAbnOff = base.Columns["AbnOff"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
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
                DataColumn[] columns = new DataColumn[] { this.columnidDamage };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnidDamage.AllowDBNull = false;
                this.columnidDamage.Unique = true;
                this.columnDeclarer.MaxLength = 0x100;
                this.columnDeclarerTel.MaxLength = 0x100;
                this.columnDeclarerAddress.Caption = "DeclarerAddREss";
                this.columnDeclarerAddress.MaxLength = 0x200;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class330 method_5()
            {
                return (DataSetDamage.Class330) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetDamage.Class330 class330_0)
            {
                base.Rows.Remove(class330_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class330(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_DamageLVRowChanged != null)
                {
                    this.tJ_DamageLVRowChanged(this, new DataSetDamage.EventArgs186((DataSetDamage.Class330) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_DamageLVRowChanging != null)
                {
                    this.tJ_DamageLVRowChanging(this, new DataSetDamage.EventArgs186((DataSetDamage.Class330) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_DamageLVRowDeleted != null)
                {
                    this.tJ_DamageLVRowDeleted(this, new DataSetDamage.EventArgs186((DataSetDamage.Class330) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_DamageLVRowDeleting != null)
                {
                    this.tJ_DamageLVRowDeleting(this, new DataSetDamage.EventArgs186((DataSetDamage.Class330) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_DamageLVDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AbnOffColumn
            {
                get
                {
                    return this.columnAbnOff;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DeclarerAddressColumn
            {
                get
                {
                    return this.columnDeclarerAddress;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DeclarerColumn
            {
                get
                {
                    return this.columnDeclarer;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DeclarerTelColumn
            {
                get
                {
                    return this.columnDeclarerTel;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idDamageColumn
            {
                get
                {
                    return this.columnidDamage;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class330 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class330) base.Rows[int_0];
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_DamageOnDataTable : TypedTableBase<DataSetDamage.Class332>
        {
            private DataColumn columncountSchmObj;
            private DataColumn columndateOn;
            private DataColumn columnid;
            private DataColumn columnidDamage;
            private DataColumn columnnoAdmissionKWT;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate192 tJ_DamageOnRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate192 tJ_DamageOnRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate192 tJ_DamageOnRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate192 tJ_DamageOnRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tJ_DamageOnDataTable()
            {
                base.TableName = "tJ_DamageOn";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_DamageOnDataTable(DataTable dataTable_0)
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tJ_DamageOnDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.tJ_DamageOnDataTable table1 = (DataSetDamage.tJ_DamageOnDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tJ_DamageOnDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class332);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetDamage.Class332 class332_0)
            {
                base.Rows.Add(class332_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class332 method_1(int int_0, DateTime dateTime_0, int int_1, decimal decimal_0)
            {
                DataSetDamage.Class332 row = (DataSetDamage.Class332) base.NewRow();
                object[] objArray1 = new object[5];
                objArray1[1] = int_0;
                objArray1[2] = dateTime_0;
                objArray1[3] = int_1;
                objArray1[4] = decimal_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class332 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetDamage.Class332) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidDamage = base.Columns["idDamage"];
                this.columndateOn = base.Columns["dateOn"];
                this.columncountSchmObj = base.Columns["countSchmObj"];
                this.columnnoAdmissionKWT = base.Columns["noAdmissionKWT"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidDamage = new DataColumn("idDamage", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidDamage);
                this.columndateOn = new DataColumn("dateOn", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateOn);
                this.columncountSchmObj = new DataColumn("countSchmObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columncountSchmObj);
                this.columnnoAdmissionKWT = new DataColumn("noAdmissionKWT", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnnoAdmissionKWT);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidDamage.AllowDBNull = false;
                this.columndateOn.AllowDBNull = false;
                this.columncountSchmObj.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class332 method_5()
            {
                return (DataSetDamage.Class332) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetDamage.Class332 class332_0)
            {
                base.Rows.Remove(class332_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class332(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_DamageOnRowChanged != null)
                {
                    this.tJ_DamageOnRowChanged(this, new DataSetDamage.EventArgs188((DataSetDamage.Class332) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_DamageOnRowChanging != null)
                {
                    this.tJ_DamageOnRowChanging(this, new DataSetDamage.EventArgs188((DataSetDamage.Class332) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_DamageOnRowDeleted != null)
                {
                    this.tJ_DamageOnRowDeleted(this, new DataSetDamage.EventArgs188((DataSetDamage.Class332) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_DamageOnRowDeleting != null)
                {
                    this.tJ_DamageOnRowDeleting(this, new DataSetDamage.EventArgs188((DataSetDamage.Class332) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_DamageOnDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn countSchmObjColumn
            {
                get
                {
                    return this.columncountSchmObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateOnColumn
            {
                get
                {
                    return this.columndateOn;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idDamageColumn
            {
                get
                {
                    return this.columnidDamage;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class332 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class332) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn noAdmissionKWTColumn
            {
                get
                {
                    return this.columnnoAdmissionKWT;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_TemperatureDataTable : TypedTableBase<DataSetDamage.Class334>
        {
            private DataColumn columnComment;
            private DataColumn columnDateOwner;
            private DataColumn columnDateTemp;
            private DataColumn columnDay;
            private DataColumn columnDayDown;
            private DataColumn columnDayUp;
            private DataColumn columnid;
            private DataColumn columnidOwner;
            private DataColumn columnNight;
            private DataColumn columnNightDown;
            private DataColumn columnNightUp;
            private DataColumn columnOwner;
            private DataColumn columnSpeed;
            private DataColumn columnSpeedDown;
            private DataColumn columnSpeedUp;
            private DataColumn columnTempAverage;
            private DataColumn columnWind;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate194 tJ_TemperatureRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate194 tJ_TemperatureRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate194 tJ_TemperatureRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate194 tJ_TemperatureRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tJ_TemperatureDataTable() : this(false)
            {
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_TemperatureDataTable(bool bool_0)
            {
                base.TableName = "tJ_Temperature";
                this.BeginInit();
                this.method_5();
                if (bool_0)
                {
                    this.method_7();
                }
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tJ_TemperatureDataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tJ_TemperatureDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_4();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.tJ_TemperatureDataTable table1 = (DataSetDamage.tJ_TemperatureDataTable) base.Clone();
                table1.method_4();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tJ_TemperatureDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class334);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetDamage.Class334 class334_0)
            {
                base.Rows.Add(class334_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class334 method_1(DateTime dateTime_0, short short_0, short short_1, short short_2, short short_3, short short_4, int int_0, short short_5, short short_6, string string_0, DateTime dateTime_1, int int_1, string string_1, string string_2, string string_3, string string_4)
            {
                DataSetDamage.Class334 row = (DataSetDamage.Class334) base.NewRow();
                object[] objArray1 = new object[0x11];
                objArray1[1] = dateTime_0;
                objArray1[2] = short_0;
                objArray1[3] = short_1;
                objArray1[4] = short_2;
                objArray1[5] = short_3;
                objArray1[6] = short_4;
                objArray1[7] = int_0;
                objArray1[8] = short_5;
                objArray1[9] = short_6;
                objArray1[10] = string_0;
                objArray1[11] = dateTime_1;
                objArray1[12] = int_1;
                objArray1[13] = string_1;
                objArray1[14] = string_2;
                objArray1[15] = string_3;
                objArray1[0x10] = string_4;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class334 method_2(DateTime dateTime_0, short short_0, short short_1, short short_2, short short_3, short short_4, int int_0, short short_5, short short_6, string string_0, DateTime dateTime_1, int int_1, string string_1)
            {
                DataSetDamage.Class334 row = (DataSetDamage.Class334) base.NewRow();
                object[] objArray1 = new object[0x11];
                objArray1[1] = dateTime_0;
                objArray1[2] = short_0;
                objArray1[3] = short_1;
                objArray1[4] = short_2;
                objArray1[5] = short_3;
                objArray1[6] = short_4;
                objArray1[7] = int_0;
                objArray1[8] = short_5;
                objArray1[9] = short_6;
                objArray1[10] = string_0;
                objArray1[11] = dateTime_1;
                objArray1[12] = int_1;
                objArray1[13] = string_1;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class334 method_3(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetDamage.Class334) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_4()
            {
                this.columnid = base.Columns["id"];
                this.columnDateTemp = base.Columns["DateTemp"];
                this.columnNightDown = base.Columns["NightDown"];
                this.columnNightUp = base.Columns["NightUp"];
                this.columnDayDown = base.Columns["DayDown"];
                this.columnDayUp = base.Columns["DayUp"];
                this.columnTempAverage = base.Columns["TempAverage"];
                this.columnWind = base.Columns["Wind"];
                this.columnSpeedDown = base.Columns["SpeedDown"];
                this.columnSpeedUp = base.Columns["SpeedUp"];
                this.columnComment = base.Columns["Comment"];
                this.columnDateOwner = base.Columns["DateOwner"];
                this.columnidOwner = base.Columns["idOwner"];
                this.columnOwner = base.Columns["Owner"];
                this.columnNight = base.Columns["Night"];
                this.columnDay = base.Columns["Day"];
                this.columnSpeed = base.Columns["Speed"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_5()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnDateTemp = new DataColumn("DateTemp", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateTemp);
                this.columnNightDown = new DataColumn("NightDown", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnNightDown);
                this.columnNightUp = new DataColumn("NightUp", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnNightUp);
                this.columnDayDown = new DataColumn("DayDown", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnDayDown);
                this.columnDayUp = new DataColumn("DayUp", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnDayUp);
                this.columnTempAverage = new DataColumn("TempAverage", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnTempAverage);
                this.columnWind = new DataColumn("Wind", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnWind);
                this.columnSpeedDown = new DataColumn("SpeedDown", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnSpeedDown);
                this.columnSpeedUp = new DataColumn("SpeedUp", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnSpeedUp);
                this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComment);
                this.columnDateOwner = new DataColumn("DateOwner", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateOwner);
                this.columnidOwner = new DataColumn("idOwner", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidOwner);
                this.columnOwner = new DataColumn("Owner", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnOwner);
                this.columnNight = new DataColumn("Night", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNight);
                this.columnDay = new DataColumn("Day", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDay);
                this.columnSpeed = new DataColumn("Speed", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnSpeed);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnDateTemp.AllowDBNull = false;
                this.columnComment.MaxLength = 0x100;
                this.columnOwner.MaxLength = 0x100;
                this.columnNight.ReadOnly = true;
                this.columnDay.ReadOnly = true;
                this.columnSpeed.ReadOnly = true;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class334 method_6()
            {
                return (DataSetDamage.Class334) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_7()
            {
                this.NightColumn.Expression = "isnull('от ' +NightDown + ' ' , '') + isnull('до ' + nightUp, '')";
                this.DayColumn.Expression = "isnull('от ' +DayDown + ' ' , '') + isnull('до ' + DayUp, '')";
                this.SpeedColumn.Expression = "isnull('от ' +SpeedDown + ' ' , '') + isnull('до ' + SpeedUp, '')";
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_8(DataSetDamage.Class334 class334_0)
            {
                base.Rows.Remove(class334_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class334(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_TemperatureRowChanged != null)
                {
                    this.tJ_TemperatureRowChanged(this, new DataSetDamage.EventArgs190((DataSetDamage.Class334) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_TemperatureRowChanging != null)
                {
                    this.tJ_TemperatureRowChanging(this, new DataSetDamage.EventArgs190((DataSetDamage.Class334) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_TemperatureRowDeleted != null)
                {
                    this.tJ_TemperatureRowDeleted(this, new DataSetDamage.EventArgs190((DataSetDamage.Class334) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_TemperatureRowDeleting != null)
                {
                    this.tJ_TemperatureRowDeleting(this, new DataSetDamage.EventArgs190((DataSetDamage.Class334) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_TemperatureDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CommentColumn
            {
                get
                {
                    return this.columnComment;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateOwnerColumn
            {
                get
                {
                    return this.columnDateOwner;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateTempColumn
            {
                get
                {
                    return this.columnDateTemp;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DayColumn
            {
                get
                {
                    return this.columnDay;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DayDownColumn
            {
                get
                {
                    return this.columnDayDown;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DayUpColumn
            {
                get
                {
                    return this.columnDayUp;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idOwnerColumn
            {
                get
                {
                    return this.columnidOwner;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class334 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class334) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NightColumn
            {
                get
                {
                    return this.columnNight;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NightDownColumn
            {
                get
                {
                    return this.columnNightDown;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NightUpColumn
            {
                get
                {
                    return this.columnNightUp;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn OwnerColumn
            {
                get
                {
                    return this.columnOwner;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn SpeedColumn
            {
                get
                {
                    return this.columnSpeed;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SpeedDownColumn
            {
                get
                {
                    return this.columnSpeedDown;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn SpeedUpColumn
            {
                get
                {
                    return this.columnSpeedUp;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TempAverageColumn
            {
                get
                {
                    return this.columnTempAverage;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn WindColumn
            {
                get
                {
                    return this.columnWind;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tMapObjDataTable : TypedTableBase<DataSetDamage.Class329>
        {
            private DataColumn columnComment;
            private DataColumn columnDeleted;
            private DataColumn columnHouse;
            private DataColumn columnHousePrefix;
            private DataColumn columnidMap;
            private DataColumn columnIndex;
            private DataColumn columnIsHouse;
            private DataColumn columnLatitude;
            private DataColumn columnLongitude;
            private DataColumn columnName;
            private DataColumn columnRaion;
            private DataColumn columnStreet;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate189 tMapObjRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate189 tMapObjRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate189 tMapObjRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate189 tMapObjRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tMapObjDataTable()
            {
                base.TableName = "tMapObj";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tMapObjDataTable(DataTable dataTable_0)
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tMapObjDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.tMapObjDataTable table1 = (DataSetDamage.tMapObjDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tMapObjDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class329);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetDamage.Class329 class329_0)
            {
                base.Rows.Add(class329_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class329 method_1(int int_0, int int_1, int int_2, string string_0, bool bool_0, string string_1, string string_2, double double_0, double double_1, string string_3, bool bool_1)
            {
                DataSetDamage.Class329 row = (DataSetDamage.Class329) base.NewRow();
                object[] objArray1 = new object[12];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = int_2;
                objArray1[4] = string_0;
                objArray1[5] = bool_0;
                objArray1[6] = string_1;
                objArray1[7] = string_2;
                objArray1[8] = double_0;
                objArray1[9] = double_1;
                objArray1[10] = string_3;
                objArray1[11] = bool_1;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class329 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetDamage.Class329) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnidMap = base.Columns["idMap"];
                this.columnRaion = base.Columns["Raion"];
                this.columnStreet = base.Columns["Street"];
                this.columnHouse = base.Columns["House"];
                this.columnHousePrefix = base.Columns["HousePrefix"];
                this.columnIsHouse = base.Columns["IsHouse"];
                this.columnName = base.Columns["Name"];
                this.columnIndex = base.Columns["Index"];
                this.columnLatitude = base.Columns["Latitude"];
                this.columnLongitude = base.Columns["Longitude"];
                this.columnComment = base.Columns["Comment"];
                this.columnDeleted = base.Columns["Deleted"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnidMap = new DataColumn("idMap", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidMap);
                this.columnRaion = new DataColumn("Raion", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnRaion);
                this.columnStreet = new DataColumn("Street", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnStreet);
                this.columnHouse = new DataColumn("House", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnHouse);
                this.columnHousePrefix = new DataColumn("HousePrefix", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnHousePrefix);
                this.columnIsHouse = new DataColumn("IsHouse", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnIsHouse);
                this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnIndex = new DataColumn("Index", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnIndex);
                this.columnLatitude = new DataColumn("Latitude", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnLatitude);
                this.columnLongitude = new DataColumn("Longitude", typeof(double), null, MappingType.Element);
                base.Columns.Add(this.columnLongitude);
                this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComment);
                this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnDeleted);
                DataColumn[] columns = new DataColumn[] { this.columnidMap };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnidMap.AutoIncrement = true;
                this.columnidMap.AutoIncrementSeed = -1L;
                this.columnidMap.AutoIncrementStep = -1L;
                this.columnidMap.AllowDBNull = false;
                this.columnidMap.ReadOnly = true;
                this.columnidMap.Unique = true;
                this.columnStreet.AllowDBNull = false;
                this.columnHousePrefix.MaxLength = 20;
                this.columnIsHouse.AllowDBNull = false;
                this.columnName.MaxLength = 40;
                this.columnIndex.MaxLength = 6;
                this.columnComment.MaxLength = 0x400;
                this.columnDeleted.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class329 method_5()
            {
                return (DataSetDamage.Class329) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetDamage.Class329 class329_0)
            {
                base.Rows.Remove(class329_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class329(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tMapObjRowChanged != null)
                {
                    this.tMapObjRowChanged(this, new DataSetDamage.EventArgs185((DataSetDamage.Class329) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tMapObjRowChanging != null)
                {
                    this.tMapObjRowChanging(this, new DataSetDamage.EventArgs185((DataSetDamage.Class329) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tMapObjRowDeleted != null)
                {
                    this.tMapObjRowDeleted(this, new DataSetDamage.EventArgs185((DataSetDamage.Class329) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tMapObjRowDeleting != null)
                {
                    this.tMapObjRowDeleting(this, new DataSetDamage.EventArgs185((DataSetDamage.Class329) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tMapObjDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CommentColumn
            {
                get
                {
                    return this.columnComment;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DeletedColumn
            {
                get
                {
                    return this.columnDeleted;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn HouseColumn
            {
                get
                {
                    return this.columnHouse;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn HousePrefixColumn
            {
                get
                {
                    return this.columnHousePrefix;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idMapColumn
            {
                get
                {
                    return this.columnidMap;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IndexColumn
            {
                get
                {
                    return this.columnIndex;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IsHouseColumn
            {
                get
                {
                    return this.columnIsHouse;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class329 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class329) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn LatitudeColumn
            {
                get
                {
                    return this.columnLatitude;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn LongitudeColumn
            {
                get
                {
                    return this.columnLongitude;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NameColumn
            {
                get
                {
                    return this.columnName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn RaionColumn
            {
                get
                {
                    return this.columnRaion;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn StreetColumn
            {
                get
                {
                    return this.columnStreet;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tReportDetectionCrashDataTable : TypedTableBase<DataSetDamage.Class346>
        {
            private DataColumn columnid;
            private DataColumn columnid1518;
            private DataColumn columnid1519;
            private DataColumn columnid1520;
            private DataColumn columnid756;
            private DataColumn columnid757;
            private DataColumn columnid758;
            private DataColumn columnid759;
            private DataColumn columnisCrash;
            private DataColumn columnMonth;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate206 tReportDetectionCrashRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate206 tReportDetectionCrashRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate206 tReportDetectionCrashRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate206 tReportDetectionCrashRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tReportDetectionCrashDataTable()
            {
                base.TableName = "tReportDetectionCrash";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tReportDetectionCrashDataTable(DataTable dataTable_0)
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tReportDetectionCrashDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.tReportDetectionCrashDataTable table1 = (DataSetDamage.tReportDetectionCrashDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tReportDetectionCrashDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class346);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetDamage.Class346 class346_0)
            {
                base.Rows.Add(class346_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class346 method_1(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, bool bool_0)
            {
                DataSetDamage.Class346 row = (DataSetDamage.Class346) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, int_2, int_3, int_4, int_5, int_6, int_7, int_8, bool_0 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnid = base.Columns["id"];
                this.columnMonth = base.Columns["Month"];
                this.columnid756 = base.Columns["id756"];
                this.columnid757 = base.Columns["id757"];
                this.columnid758 = base.Columns["id758"];
                this.columnid759 = base.Columns["id759"];
                this.columnid1518 = base.Columns["id1518"];
                this.columnid1519 = base.Columns["id1519"];
                this.columnid1520 = base.Columns["id1520"];
                this.columnisCrash = base.Columns["isCrash"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnMonth = new DataColumn("Month", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnMonth);
                this.columnid756 = new DataColumn("id756", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid756);
                this.columnid757 = new DataColumn("id757", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid757);
                this.columnid758 = new DataColumn("id758", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid758);
                this.columnid759 = new DataColumn("id759", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid759);
                this.columnid1518 = new DataColumn("id1518", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid1518);
                this.columnid1519 = new DataColumn("id1519", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid1519);
                this.columnid1520 = new DataColumn("id1520", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid1520);
                this.columnisCrash = new DataColumn("isCrash", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisCrash);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class346 method_4()
            {
                return (DataSetDamage.Class346) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(DataSetDamage.Class346 class346_0)
            {
                base.Rows.Remove(class346_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class346(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tReportDetectionCrashRowChanged != null)
                {
                    this.tReportDetectionCrashRowChanged(this, new DataSetDamage.EventArgs202((DataSetDamage.Class346) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tReportDetectionCrashRowChanging != null)
                {
                    this.tReportDetectionCrashRowChanging(this, new DataSetDamage.EventArgs202((DataSetDamage.Class346) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tReportDetectionCrashRowDeleted != null)
                {
                    this.tReportDetectionCrashRowDeleted(this, new DataSetDamage.EventArgs202((DataSetDamage.Class346) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tReportDetectionCrashRowDeleting != null)
                {
                    this.tReportDetectionCrashRowDeleting(this, new DataSetDamage.EventArgs202((DataSetDamage.Class346) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tReportDetectionCrashDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn id1518Column
            {
                get
                {
                    return this.columnid1518;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn id1519Column
            {
                get
                {
                    return this.columnid1519;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn id1520Column
            {
                get
                {
                    return this.columnid1520;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn id756Column
            {
                get
                {
                    return this.columnid756;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn id757Column
            {
                get
                {
                    return this.columnid757;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn id758Column
            {
                get
                {
                    return this.columnid758;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn id759Column
            {
                get
                {
                    return this.columnid759;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn isCrashColumn
            {
                get
                {
                    return this.columnisCrash;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class346 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class346) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn MonthColumn
            {
                get
                {
                    return this.columnMonth;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tReportDetectionNetRegDataTable : TypedTableBase<DataSetDamage.Class348>
        {
            private DataColumn columnid1518;
            private DataColumn columnid1519;
            private DataColumn columnid1520;
            private DataColumn columnisCrash;
            private DataColumn columntypeNetReg;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate208 tReportDetectionNetRegRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate208 tReportDetectionNetRegRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate208 tReportDetectionNetRegRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate208 tReportDetectionNetRegRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tReportDetectionNetRegDataTable()
            {
                base.TableName = "tReportDetectionNetReg";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tReportDetectionNetRegDataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tReportDetectionNetRegDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetDamage.tReportDetectionNetRegDataTable table1 = (DataSetDamage.tReportDetectionNetRegDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tReportDetectionNetRegDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class348);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetDamage.Class348 class348_0)
            {
                base.Rows.Add(class348_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class348 method_1(int int_0, int int_1, int int_2, int int_3, bool bool_0)
            {
                DataSetDamage.Class348 row = (DataSetDamage.Class348) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, int_2, int_3, bool_0 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columntypeNetReg = base.Columns["typeNetReg"];
                this.columnid1518 = base.Columns["id1518"];
                this.columnid1519 = base.Columns["id1519"];
                this.columnid1520 = base.Columns["id1520"];
                this.columnisCrash = base.Columns["isCrash"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columntypeNetReg = new DataColumn("typeNetReg", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columntypeNetReg);
                this.columnid1518 = new DataColumn("id1518", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid1518);
                this.columnid1519 = new DataColumn("id1519", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid1519);
                this.columnid1520 = new DataColumn("id1520", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid1520);
                this.columnisCrash = new DataColumn("isCrash", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisCrash);
                this.columntypeNetReg.Caption = "Month";
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class348 method_4()
            {
                return (DataSetDamage.Class348) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(DataSetDamage.Class348 class348_0)
            {
                base.Rows.Remove(class348_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class348(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tReportDetectionNetRegRowChanged != null)
                {
                    this.tReportDetectionNetRegRowChanged(this, new DataSetDamage.EventArgs204((DataSetDamage.Class348) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tReportDetectionNetRegRowChanging != null)
                {
                    this.tReportDetectionNetRegRowChanging(this, new DataSetDamage.EventArgs204((DataSetDamage.Class348) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tReportDetectionNetRegRowDeleted != null)
                {
                    this.tReportDetectionNetRegRowDeleted(this, new DataSetDamage.EventArgs204((DataSetDamage.Class348) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tReportDetectionNetRegRowDeleting != null)
                {
                    this.tReportDetectionNetRegRowDeleting(this, new DataSetDamage.EventArgs204((DataSetDamage.Class348) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tReportDetectionNetRegDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn id1518Column
            {
                get
                {
                    return this.columnid1518;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn id1519Column
            {
                get
                {
                    return this.columnid1519;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn id1520Column
            {
                get
                {
                    return this.columnid1520;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn isCrashColumn
            {
                get
                {
                    return this.columnisCrash;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class348 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class348) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeNetRegColumn
            {
                get
                {
                    return this.columntypeNetReg;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tReportDetectionNoAdmissKWTDataTable : TypedTableBase<DataSetDamage.Class349>
        {
            private DataColumn columnid756;
            private DataColumn columnid757;
            private DataColumn columnid758;
            private DataColumn columnid759;
            private DataColumn columnisCrash;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate209 tReportDetectionNoAdmissKWTRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate209 tReportDetectionNoAdmissKWTRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate209 tReportDetectionNoAdmissKWTRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate209 tReportDetectionNoAdmissKWTRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tReportDetectionNoAdmissKWTDataTable()
            {
                base.TableName = "tReportDetectionNoAdmissKWT";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tReportDetectionNoAdmissKWTDataTable(DataTable dataTable_0)
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tReportDetectionNoAdmissKWTDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetDamage.tReportDetectionNoAdmissKWTDataTable table1 = (DataSetDamage.tReportDetectionNoAdmissKWTDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tReportDetectionNoAdmissKWTDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class349);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetDamage.Class349 class349_0)
            {
                base.Rows.Add(class349_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class349 method_1(int int_0, int int_1, int int_2, int int_3, int int_4)
            {
                DataSetDamage.Class349 row = (DataSetDamage.Class349) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, int_2, int_3, int_4 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnisCrash = base.Columns["isCrash"];
                this.columnid756 = base.Columns["id756"];
                this.columnid757 = base.Columns["id757"];
                this.columnid758 = base.Columns["id758"];
                this.columnid759 = base.Columns["id759"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnisCrash = new DataColumn("isCrash", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnisCrash);
                this.columnid756 = new DataColumn("id756", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid756);
                this.columnid757 = new DataColumn("id757", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid757);
                this.columnid758 = new DataColumn("id758", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid758);
                this.columnid759 = new DataColumn("id759", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid759);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class349 method_4()
            {
                return (DataSetDamage.Class349) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(DataSetDamage.Class349 class349_0)
            {
                base.Rows.Remove(class349_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class349(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tReportDetectionNoAdmissKWTRowChanged != null)
                {
                    this.tReportDetectionNoAdmissKWTRowChanged(this, new DataSetDamage.EventArgs205((DataSetDamage.Class349) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tReportDetectionNoAdmissKWTRowChanging != null)
                {
                    this.tReportDetectionNoAdmissKWTRowChanging(this, new DataSetDamage.EventArgs205((DataSetDamage.Class349) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tReportDetectionNoAdmissKWTRowDeleted != null)
                {
                    this.tReportDetectionNoAdmissKWTRowDeleted(this, new DataSetDamage.EventArgs205((DataSetDamage.Class349) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tReportDetectionNoAdmissKWTRowDeleting != null)
                {
                    this.tReportDetectionNoAdmissKWTRowDeleting(this, new DataSetDamage.EventArgs205((DataSetDamage.Class349) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tReportDetectionNoAdmissKWTDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn id756Column
            {
                get
                {
                    return this.columnid756;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn id757Column
            {
                get
                {
                    return this.columnid757;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn id758Column
            {
                get
                {
                    return this.columnid758;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn id759Column
            {
                get
                {
                    return this.columnid759;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn isCrashColumn
            {
                get
                {
                    return this.columnisCrash;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class349 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class349) base.Rows[int_0];
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tReportDetectionReasonCrashDataTable : TypedTableBase<DataSetDamage.Class347>
        {
            private DataColumn columnid;
            private DataColumn columnid1518;
            private DataColumn columnid1519;
            private DataColumn columnid1520;
            private DataColumn columnid756;
            private DataColumn columnid757;
            private DataColumn columnid758;
            private DataColumn columnid759;
            private DataColumn columnisCrash;
            private DataColumn columnReason;
            private DataColumn columnreasonCode;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate207 tReportDetectionReasonCrashRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate207 tReportDetectionReasonCrashRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate207 tReportDetectionReasonCrashRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate207 tReportDetectionReasonCrashRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tReportDetectionReasonCrashDataTable()
            {
                base.TableName = "tReportDetectionReasonCrash";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tReportDetectionReasonCrashDataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tReportDetectionReasonCrashDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.tReportDetectionReasonCrashDataTable table1 = (DataSetDamage.tReportDetectionReasonCrashDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tReportDetectionReasonCrashDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class347);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetDamage.Class347 class347_0)
            {
                base.Rows.Add(class347_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class347 method_1(int int_0, int int_1, string string_0, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, bool bool_0)
            {
                DataSetDamage.Class347 row = (DataSetDamage.Class347) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, string_0, int_2, int_3, int_4, int_5, int_6, int_7, int_8, bool_0 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnid = base.Columns["id"];
                this.columnreasonCode = base.Columns["reasonCode"];
                this.columnReason = base.Columns["Reason"];
                this.columnid756 = base.Columns["id756"];
                this.columnid757 = base.Columns["id757"];
                this.columnid758 = base.Columns["id758"];
                this.columnid759 = base.Columns["id759"];
                this.columnid1518 = base.Columns["id1518"];
                this.columnid1519 = base.Columns["id1519"];
                this.columnid1520 = base.Columns["id1520"];
                this.columnisCrash = base.Columns["isCrash"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnreasonCode = new DataColumn("reasonCode", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnreasonCode);
                this.columnReason = new DataColumn("Reason", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnid756 = new DataColumn("id756", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid756);
                this.columnid757 = new DataColumn("id757", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid757);
                this.columnid758 = new DataColumn("id758", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid758);
                this.columnid759 = new DataColumn("id759", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid759);
                this.columnid1518 = new DataColumn("id1518", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid1518);
                this.columnid1519 = new DataColumn("id1519", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid1519);
                this.columnid1520 = new DataColumn("id1520", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid1520);
                this.columnisCrash = new DataColumn("isCrash", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisCrash);
                this.columnreasonCode.Caption = "Month";
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class347 method_4()
            {
                return (DataSetDamage.Class347) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(DataSetDamage.Class347 class347_0)
            {
                base.Rows.Remove(class347_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class347(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tReportDetectionReasonCrashRowChanged != null)
                {
                    this.tReportDetectionReasonCrashRowChanged(this, new DataSetDamage.EventArgs203((DataSetDamage.Class347) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tReportDetectionReasonCrashRowChanging != null)
                {
                    this.tReportDetectionReasonCrashRowChanging(this, new DataSetDamage.EventArgs203((DataSetDamage.Class347) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tReportDetectionReasonCrashRowDeleted != null)
                {
                    this.tReportDetectionReasonCrashRowDeleted(this, new DataSetDamage.EventArgs203((DataSetDamage.Class347) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tReportDetectionReasonCrashRowDeleting != null)
                {
                    this.tReportDetectionReasonCrashRowDeleting(this, new DataSetDamage.EventArgs203((DataSetDamage.Class347) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tReportDetectionReasonCrashDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn id1518Column
            {
                get
                {
                    return this.columnid1518;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn id1519Column
            {
                get
                {
                    return this.columnid1519;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn id1520Column
            {
                get
                {
                    return this.columnid1520;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn id756Column
            {
                get
                {
                    return this.columnid756;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn id757Column
            {
                get
                {
                    return this.columnid757;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn id758Column
            {
                get
                {
                    return this.columnid758;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn id759Column
            {
                get
                {
                    return this.columnid759;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn isCrashColumn
            {
                get
                {
                    return this.columnisCrash;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class347 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class347) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn reasonCodeColumn
            {
                get
                {
                    return this.columnreasonCode;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ReasonColumn
            {
                get
                {
                    return this.columnReason;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tReportIterruptLVDataTable : TypedTableBase<DataSetDamage.Class336>
        {
            private DataColumn columnc11;
            private DataColumn columnc12;
            private DataColumn columnc13;
            private DataColumn columnc14;
            private DataColumn columnc15;
            private DataColumn columnc16;
            private DataColumn columnc17;
            private DataColumn columnc18;
            private DataColumn columnc19;
            private DataColumn columnc21;
            private DataColumn columnc22;
            private DataColumn columnc23;
            private DataColumn columnc24;
            private DataColumn columnc25;
            private DataColumn columnc26;
            private DataColumn columnc27;
            private DataColumn columnc31;
            private DataColumn columnc32;
            private DataColumn columnc33;
            private DataColumn columnc34;
            private DataColumn columnc35;
            private DataColumn columnc36;
            private DataColumn columnc37;
            private DataColumn columnc41;
            private DataColumn columnc42;
            private DataColumn columnc43;
            private DataColumn columnc44;
            private DataColumn columnc45;
            private DataColumn columnc46;
            private DataColumn columnc51;
            private DataColumn columnc52;
            private DataColumn columnc53;
            private DataColumn columnc54;
            private DataColumn columnc55;
            private DataColumn columnc56;
            private DataColumn columnc57;
            private DataColumn columnc61;
            private DataColumn columnc62;
            private DataColumn columnnetRegionValue;
            private DataColumn columnnumNetRegion;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate196 tReportIterruptLVRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate196 tReportIterruptLVRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate196 tReportIterruptLVRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate196 tReportIterruptLVRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tReportIterruptLVDataTable()
            {
                base.TableName = "tReportIterruptLV";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tReportIterruptLVDataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tReportIterruptLVDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.tReportIterruptLVDataTable table1 = (DataSetDamage.tReportIterruptLVDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tReportIterruptLVDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class336);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetDamage.Class336 class336_0)
            {
                base.Rows.Add(class336_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class336 method_1(int int_0, string string_0, int int_1, int int_2, int int_3, int int_4, int int_5, int int_6, int int_7, int int_8, int int_9, int int_10, int int_11, int int_12, int int_13, int int_14, int int_15, int int_16, int int_17, int int_18, int int_19, int int_20, int int_21, int int_22, int int_23, int int_24, int int_25, int int_26, int int_27, int int_28, int int_29, int int_30, int int_31, int int_32, int int_33, int int_34, int int_35, int int_36, int int_37, int int_38)
            {
                DataSetDamage.Class336 row = (DataSetDamage.Class336) base.NewRow();
                object[] objArray = new object[] { 
                    int_0, string_0, int_1, int_2, int_3, int_4, int_5, int_6, int_7, int_8, int_9, int_10, int_11, int_12, int_13, int_14,
                    int_15, int_16, int_17, int_18, int_19, int_20, int_21, int_22, int_23, int_24, int_25, int_26, int_27, int_28, int_29, int_30,
                    int_31, int_32, int_33, int_34, int_35, int_36, int_37, int_38
                };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnnumNetRegion = base.Columns["numNetRegion"];
                this.columnnetRegionValue = base.Columns["netRegionValue"];
                this.columnc11 = base.Columns["c11"];
                this.columnc12 = base.Columns["c12"];
                this.columnc13 = base.Columns["c13"];
                this.columnc14 = base.Columns["c14"];
                this.columnc15 = base.Columns["c15"];
                this.columnc16 = base.Columns["c16"];
                this.columnc17 = base.Columns["c17"];
                this.columnc18 = base.Columns["c18"];
                this.columnc19 = base.Columns["c19"];
                this.columnc21 = base.Columns["c21"];
                this.columnc22 = base.Columns["c22"];
                this.columnc23 = base.Columns["c23"];
                this.columnc24 = base.Columns["c24"];
                this.columnc25 = base.Columns["c25"];
                this.columnc26 = base.Columns["c26"];
                this.columnc27 = base.Columns["c27"];
                this.columnc31 = base.Columns["c31"];
                this.columnc32 = base.Columns["c32"];
                this.columnc33 = base.Columns["c33"];
                this.columnc34 = base.Columns["c34"];
                this.columnc35 = base.Columns["c35"];
                this.columnc36 = base.Columns["c36"];
                this.columnc37 = base.Columns["c37"];
                this.columnc41 = base.Columns["c41"];
                this.columnc42 = base.Columns["c42"];
                this.columnc43 = base.Columns["c43"];
                this.columnc44 = base.Columns["c44"];
                this.columnc45 = base.Columns["c45"];
                this.columnc46 = base.Columns["c46"];
                this.columnc51 = base.Columns["c51"];
                this.columnc52 = base.Columns["c52"];
                this.columnc53 = base.Columns["c53"];
                this.columnc54 = base.Columns["c54"];
                this.columnc55 = base.Columns["c55"];
                this.columnc56 = base.Columns["c56"];
                this.columnc57 = base.Columns["c57"];
                this.columnc61 = base.Columns["c61"];
                this.columnc62 = base.Columns["c62"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnnumNetRegion = new DataColumn("numNetRegion", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnumNetRegion);
                this.columnnetRegionValue = new DataColumn("netRegionValue", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnetRegionValue);
                this.columnc11 = new DataColumn("c11", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc11);
                this.columnc12 = new DataColumn("c12", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc12);
                this.columnc13 = new DataColumn("c13", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc13);
                this.columnc14 = new DataColumn("c14", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc14);
                this.columnc15 = new DataColumn("c15", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc15);
                this.columnc16 = new DataColumn("c16", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc16);
                this.columnc17 = new DataColumn("c17", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc17);
                this.columnc18 = new DataColumn("c18", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc18);
                this.columnc19 = new DataColumn("c19", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc19);
                this.columnc21 = new DataColumn("c21", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc21);
                this.columnc22 = new DataColumn("c22", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc22);
                this.columnc23 = new DataColumn("c23", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc23);
                this.columnc24 = new DataColumn("c24", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc24);
                this.columnc25 = new DataColumn("c25", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc25);
                this.columnc26 = new DataColumn("c26", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc26);
                this.columnc27 = new DataColumn("c27", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc27);
                this.columnc31 = new DataColumn("c31", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc31);
                this.columnc32 = new DataColumn("c32", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc32);
                this.columnc33 = new DataColumn("c33", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc33);
                this.columnc34 = new DataColumn("c34", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc34);
                this.columnc35 = new DataColumn("c35", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc35);
                this.columnc36 = new DataColumn("c36", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc36);
                this.columnc37 = new DataColumn("c37", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc37);
                this.columnc41 = new DataColumn("c41", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc41);
                this.columnc42 = new DataColumn("c42", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc42);
                this.columnc43 = new DataColumn("c43", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc43);
                this.columnc44 = new DataColumn("c44", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc44);
                this.columnc45 = new DataColumn("c45", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc45);
                this.columnc46 = new DataColumn("c46", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc46);
                this.columnc51 = new DataColumn("c51", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc51);
                this.columnc52 = new DataColumn("c52", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc52);
                this.columnc53 = new DataColumn("c53", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc53);
                this.columnc54 = new DataColumn("c54", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc54);
                this.columnc55 = new DataColumn("c55", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc55);
                this.columnc56 = new DataColumn("c56", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc56);
                this.columnc57 = new DataColumn("c57", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc57);
                this.columnc61 = new DataColumn("c61", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc61);
                this.columnc62 = new DataColumn("c62", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnc62);
                this.columnc11.Caption = "11";
                this.columnc12.Caption = "12";
                this.columnc13.Caption = "13";
                this.columnc14.Caption = "14";
                this.columnc15.Caption = "15";
                this.columnc16.Caption = "16";
                this.columnc17.Caption = "17";
                this.columnc18.Caption = "18";
                this.columnc19.Caption = "19";
                this.columnc21.Caption = "21";
                this.columnc22.Caption = "22";
                this.columnc23.Caption = "23";
                this.columnc24.Caption = "24";
                this.columnc25.Caption = "25";
                this.columnc26.Caption = "26";
                this.columnc27.Caption = "27";
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class336 method_4()
            {
                return (DataSetDamage.Class336) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(DataSetDamage.Class336 class336_0)
            {
                base.Rows.Remove(class336_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class336(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tReportIterruptLVRowChanged != null)
                {
                    this.tReportIterruptLVRowChanged(this, new DataSetDamage.EventArgs192((DataSetDamage.Class336) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tReportIterruptLVRowChanging != null)
                {
                    this.tReportIterruptLVRowChanging(this, new DataSetDamage.EventArgs192((DataSetDamage.Class336) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tReportIterruptLVRowDeleted != null)
                {
                    this.tReportIterruptLVRowDeleted(this, new DataSetDamage.EventArgs192((DataSetDamage.Class336) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tReportIterruptLVRowDeleting != null)
                {
                    this.tReportIterruptLVRowDeleting(this, new DataSetDamage.EventArgs192((DataSetDamage.Class336) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tReportIterruptLVDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c11Column
            {
                get
                {
                    return this.columnc11;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c12Column
            {
                get
                {
                    return this.columnc12;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c13Column
            {
                get
                {
                    return this.columnc13;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c14Column
            {
                get
                {
                    return this.columnc14;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c15Column
            {
                get
                {
                    return this.columnc15;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c16Column
            {
                get
                {
                    return this.columnc16;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c17Column
            {
                get
                {
                    return this.columnc17;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c18Column
            {
                get
                {
                    return this.columnc18;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c19Column
            {
                get
                {
                    return this.columnc19;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c21Column
            {
                get
                {
                    return this.columnc21;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c22Column
            {
                get
                {
                    return this.columnc22;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c23Column
            {
                get
                {
                    return this.columnc23;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c24Column
            {
                get
                {
                    return this.columnc24;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c25Column
            {
                get
                {
                    return this.columnc25;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c26Column
            {
                get
                {
                    return this.columnc26;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c27Column
            {
                get
                {
                    return this.columnc27;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c31Column
            {
                get
                {
                    return this.columnc31;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c32Column
            {
                get
                {
                    return this.columnc32;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c33Column
            {
                get
                {
                    return this.columnc33;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c34Column
            {
                get
                {
                    return this.columnc34;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c35Column
            {
                get
                {
                    return this.columnc35;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c36Column
            {
                get
                {
                    return this.columnc36;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c37Column
            {
                get
                {
                    return this.columnc37;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c41Column
            {
                get
                {
                    return this.columnc41;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c42Column
            {
                get
                {
                    return this.columnc42;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c43Column
            {
                get
                {
                    return this.columnc43;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c44Column
            {
                get
                {
                    return this.columnc44;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c45Column
            {
                get
                {
                    return this.columnc45;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c46Column
            {
                get
                {
                    return this.columnc46;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c51Column
            {
                get
                {
                    return this.columnc51;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c52Column
            {
                get
                {
                    return this.columnc52;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c53Column
            {
                get
                {
                    return this.columnc53;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c54Column
            {
                get
                {
                    return this.columnc54;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c55Column
            {
                get
                {
                    return this.columnc55;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn c56Column
            {
                get
                {
                    return this.columnc56;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c57Column
            {
                get
                {
                    return this.columnc57;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c61Column
            {
                get
                {
                    return this.columnc61;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn c62Column
            {
                get
                {
                    return this.columnc62;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class336 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class336) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn netRegionValueColumn
            {
                get
                {
                    return this.columnnetRegionValue;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn numNetRegionColumn
            {
                get
                {
                    return this.columnnumNetRegion;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tSettingsDataTable : TypedTableBase<DataSetDamage.Class350>
        {
            private DataColumn columnHostIp;
            private DataColumn columnid;
            private DataColumn columnModule;
            private DataColumn columnSettings;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate210 tSettingsRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate210 tSettingsRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate210 tSettingsRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate210 tSettingsRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tSettingsDataTable()
            {
                base.TableName = "tSettings";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tSettingsDataTable(DataTable dataTable_0)
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tSettingsDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetDamage.tSettingsDataTable table1 = (DataSetDamage.tSettingsDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.tSettingsDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class350);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetDamage.Class350 class350_0)
            {
                base.Rows.Add(class350_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class350 method_1(string string_0, string string_1, string string_2)
            {
                DataSetDamage.Class350 row = (DataSetDamage.Class350) base.NewRow();
                object[] objArray1 = new object[4];
                objArray1[1] = string_0;
                objArray1[2] = string_1;
                objArray1[3] = string_2;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class350 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetDamage.Class350) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnHostIp = base.Columns["HostIp"];
                this.columnSettings = base.Columns["Settings"];
                this.columnModule = base.Columns["Module"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnHostIp = new DataColumn("HostIp", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnHostIp);
                this.columnSettings = new DataColumn("Settings", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnSettings);
                this.columnModule = new DataColumn("Module", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnModule);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnHostIp.MaxLength = 15;
                this.columnModule.MaxLength = 50;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class350 method_5()
            {
                return (DataSetDamage.Class350) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetDamage.Class350 class350_0)
            {
                base.Rows.Remove(class350_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class350(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tSettingsRowChanged != null)
                {
                    this.tSettingsRowChanged(this, new DataSetDamage.EventArgs206((DataSetDamage.Class350) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tSettingsRowChanging != null)
                {
                    this.tSettingsRowChanging(this, new DataSetDamage.EventArgs206((DataSetDamage.Class350) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tSettingsRowDeleted != null)
                {
                    this.tSettingsRowDeleted(this, new DataSetDamage.EventArgs206((DataSetDamage.Class350) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tSettingsRowDeleting != null)
                {
                    this.tSettingsRowDeleting(this, new DataSetDamage.EventArgs206((DataSetDamage.Class350) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tSettingsDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn HostIpColumn
            {
                get
                {
                    return this.columnHostIp;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class350 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class350) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ModuleColumn
            {
                get
                {
                    return this.columnModule;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SettingsColumn
            {
                get
                {
                    return this.columnSettings;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vJ_DamageDataTable : TypedTableBase<DataSetDamage.Class338>
        {
            private DataColumn columnComletedWorkText;
            private DataColumn columncompiler;
            private DataColumn columncompletedWork;
            private DataColumn columndateApply;
            private DataColumn columndateDoc;
            private DataColumn columndateOwner;
            private DataColumn columndatePlanEnd;
            private DataColumn columndefectLocation;
            private DataColumn columndeleted;
            private DataColumn columnDivision;
            private DataColumn columnDivisionApply;
            private DataColumn columnid;
            private DataColumn columnidCompiler;
            private DataColumn columnidCompletedWork;
            private DataColumn columnidDivision;
            private DataColumn columnidDivisionApply;
            private DataColumn columnidMap;
            private DataColumn columnidParent;
            private DataColumn columnidReason;
            private DataColumn columnidReqForRepair;
            private DataColumn columnidSchmObj;
            private DataColumn columnidSub;
            private DataColumn columnidWorkerApply;
            private DataColumn columnInstruction;
            private DataColumn columnisApply;
            private DataColumn columnisLaboratory;
            private DataColumn columnisNoSESNO;
            private DataColumn columnKodPTS;
            private DataColumn columnKodPTSStr;
            private DataColumn columnNetRegionSub;
            private DataColumn columnnumcrash;
            private DataColumn columnnumDoc;
            private DataColumn columnnumrequest;
            private DataColumn columnownerName;
            private DataColumn columnReason;
            private DataColumn columnreasonCrashEquipName;
            private DataColumn columnreasonCrashEquipType;
            private DataColumn columnreasonCrashName;
            private DataColumn columnreasonCrashType;
            private DataColumn columnschmObjName;
            private DataColumn columnsignCrashName;
            private DataColumn columnsignCrashType;
            private DataColumn columnTypeDoc;
            private DataColumn columnTypeDocName;
            private DataColumn columntypeEquip;
            private DataColumn columntypeEquipName;
            private DataColumn columnworkerApply;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate198 vJ_DamageRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate198 vJ_DamageRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate198 vJ_DamageRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate198 vJ_DamageRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vJ_DamageDataTable()
            {
                base.TableName = "vJ_Damage";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal vJ_DamageDataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected vJ_DamageDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.vJ_DamageDataTable table1 = (DataSetDamage.vJ_DamageDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.vJ_DamageDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class338);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetDamage.Class338 class338_0)
            {
                base.Rows.Add(class338_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class338 method_1(int int_0, int int_1, DateTime dateTime_0, DateTime dateTime_1, string string_0, int int_2, string string_1, int int_3, string string_2, int int_4, string string_3, int int_5, string string_4, int int_6, string string_5, int int_7, string string_6, int int_8, string string_7, int int_9, string string_8, string string_9, bool bool_0, int int_10, string string_10, DateTime dateTime_2, int int_11, string string_11, bool bool_1, int int_12, string string_12, DateTime dateTime_3, string string_13, decimal decimal_0, string string_14, int int_13, bool bool_2, string string_15, string string_16, string string_17, string string_18, string string_19, string string_20, string string_21, string string_22, string string_23, bool bool_3)
            {
                DataSetDamage.Class338 row = (DataSetDamage.Class338) base.NewRow();
                object[] objArray = new object[] { 
                    int_0, int_1, dateTime_0, dateTime_1, string_0, int_2, string_1, int_3, string_2, int_4, string_3, int_5, string_4, int_6, string_5, int_7,
                    string_6, int_8, string_7, int_9, string_8, string_9, bool_0, int_10, string_10, dateTime_2, int_11, string_11, bool_1, int_12, string_12, dateTime_3,
                    string_13, decimal_0, string_14, int_13, bool_2, string_15, string_16, string_17, string_18, string_19, string_20, string_21, string_22, string_23, bool_3
                };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class338 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetDamage.Class338) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnnumDoc = base.Columns["numDoc"];
                this.columndateDoc = base.Columns["dateDoc"];
                this.columndatePlanEnd = base.Columns["datePlanEnd"];
                this.columnnumrequest = base.Columns["numrequest"];
                this.columnTypeDoc = base.Columns["TypeDoc"];
                this.columnTypeDocName = base.Columns["TypeDocName"];
                this.columnidCompiler = base.Columns["idCompiler"];
                this.columncompiler = base.Columns["compiler"];
                this.columnidDivision = base.Columns["idDivision"];
                this.columnDivision = base.Columns["Division"];
                this.columnidSchmObj = base.Columns["idSchmObj"];
                this.columnschmObjName = base.Columns["schmObjName"];
                this.columnidSub = base.Columns["idSub"];
                this.columnNetRegionSub = base.Columns["NetRegionSub"];
                this.columnidMap = base.Columns["idMap"];
                this.columndefectLocation = base.Columns["defectLocation"];
                this.columnidReason = base.Columns["idReason"];
                this.columnReason = base.Columns["Reason"];
                this.columnidCompletedWork = base.Columns["idCompletedWork"];
                this.columncompletedWork = base.Columns["completedWork"];
                this.columnComletedWorkText = base.Columns["ComletedWorkText"];
                this.columnisApply = base.Columns["isApply"];
                this.columnidWorkerApply = base.Columns["idWorkerApply"];
                this.columnworkerApply = base.Columns["workerApply"];
                this.columndateApply = base.Columns["dateApply"];
                this.columnidDivisionApply = base.Columns["idDivisionApply"];
                this.columnDivisionApply = base.Columns["DivisionApply"];
                this.columnisLaboratory = base.Columns["isLaboratory"];
                this.columnidParent = base.Columns["idParent"];
                this.columnownerName = base.Columns["ownerName"];
                this.columndateOwner = base.Columns["dateOwner"];
                this.columnKodPTSStr = base.Columns["KodPTSStr"];
                this.columnKodPTS = base.Columns["KodPTS"];
                this.columnInstruction = base.Columns["Instruction"];
                this.columnidReqForRepair = base.Columns["idReqForRepair"];
                this.columndeleted = base.Columns["deleted"];
                this.columnnumcrash = base.Columns["numcrash"];
                this.columnsignCrashType = base.Columns["signCrashType"];
                this.columnsignCrashName = base.Columns["signCrashName"];
                this.columntypeEquip = base.Columns["typeEquip"];
                this.columntypeEquipName = base.Columns["typeEquipName"];
                this.columnreasonCrashEquipType = base.Columns["reasonCrashEquipType"];
                this.columnreasonCrashEquipName = base.Columns["reasonCrashEquipName"];
                this.columnreasonCrashType = base.Columns["reasonCrashType"];
                this.columnreasonCrashName = base.Columns["reasonCrashName"];
                this.columnisNoSESNO = base.Columns["isNoSESNO"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnnumDoc = new DataColumn("numDoc", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnumDoc);
                this.columndateDoc = new DataColumn("dateDoc", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateDoc);
                this.columndatePlanEnd = new DataColumn("datePlanEnd", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndatePlanEnd);
                this.columnnumrequest = new DataColumn("numrequest", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnumrequest);
                this.columnTypeDoc = new DataColumn("TypeDoc", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnTypeDoc);
                this.columnTypeDocName = new DataColumn("TypeDocName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTypeDocName);
                this.columnidCompiler = new DataColumn("idCompiler", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidCompiler);
                this.columncompiler = new DataColumn("compiler", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncompiler);
                this.columnidDivision = new DataColumn("idDivision", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidDivision);
                this.columnDivision = new DataColumn("Division", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDivision);
                this.columnidSchmObj = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSchmObj);
                this.columnschmObjName = new DataColumn("schmObjName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnschmObjName);
                this.columnidSub = new DataColumn("idSub", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSub);
                this.columnNetRegionSub = new DataColumn("NetRegionSub", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNetRegionSub);
                this.columnidMap = new DataColumn("idMap", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidMap);
                this.columndefectLocation = new DataColumn("defectLocation", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndefectLocation);
                this.columnidReason = new DataColumn("idReason", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidReason);
                this.columnReason = new DataColumn("Reason", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnidCompletedWork = new DataColumn("idCompletedWork", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidCompletedWork);
                this.columncompletedWork = new DataColumn("completedWork", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncompletedWork);
                this.columnComletedWorkText = new DataColumn("ComletedWorkText", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComletedWorkText);
                this.columnisApply = new DataColumn("isApply", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisApply);
                this.columnidWorkerApply = new DataColumn("idWorkerApply", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidWorkerApply);
                this.columnworkerApply = new DataColumn("workerApply", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnworkerApply);
                this.columndateApply = new DataColumn("dateApply", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateApply);
                this.columnidDivisionApply = new DataColumn("idDivisionApply", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidDivisionApply);
                this.columnDivisionApply = new DataColumn("DivisionApply", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDivisionApply);
                this.columnisLaboratory = new DataColumn("isLaboratory", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisLaboratory);
                this.columnidParent = new DataColumn("idParent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidParent);
                this.columnownerName = new DataColumn("ownerName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnownerName);
                this.columndateOwner = new DataColumn("dateOwner", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateOwner);
                this.columnKodPTSStr = new DataColumn("KodPTSStr", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnKodPTSStr);
                this.columnKodPTS = new DataColumn("KodPTS", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnKodPTS);
                this.columnInstruction = new DataColumn("Instruction", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnInstruction);
                this.columnidReqForRepair = new DataColumn("idReqForRepair", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidReqForRepair);
                this.columndeleted = new DataColumn("deleted", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columndeleted);
                this.columnnumcrash = new DataColumn("numcrash", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnnumcrash);
                this.columnsignCrashType = new DataColumn("signCrashType", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnsignCrashType);
                this.columnsignCrashName = new DataColumn("signCrashName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnsignCrashName);
                this.columntypeEquip = new DataColumn("typeEquip", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntypeEquip);
                this.columntypeEquipName = new DataColumn("typeEquipName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntypeEquipName);
                this.columnreasonCrashEquipType = new DataColumn("reasonCrashEquipType", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnreasonCrashEquipType);
                this.columnreasonCrashEquipName = new DataColumn("reasonCrashEquipName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnreasonCrashEquipName);
                this.columnreasonCrashType = new DataColumn("reasonCrashType", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnreasonCrashType);
                this.columnreasonCrashName = new DataColumn("reasonCrashName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnreasonCrashName);
                this.columnisNoSESNO = new DataColumn("isNoSESNO", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisNoSESNO);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnnumrequest.MaxLength = 50;
                this.columnTypeDoc.AllowDBNull = false;
                this.columnTypeDocName.MaxLength = 100;
                this.columncompiler.ReadOnly = true;
                this.columncompiler.MaxLength = 0x23;
                this.columnDivision.MaxLength = 100;
                this.columnschmObjName.ReadOnly = true;
                this.columnschmObjName.MaxLength = 0x731;
                this.columnidSub.ReadOnly = true;
                this.columndefectLocation.ReadOnly = true;
                this.columndefectLocation.MaxLength = 0x4b3;
                this.columnReason.MaxLength = 100;
                this.columncompletedWork.MaxLength = 100;
                this.columnComletedWorkText.MaxLength = 0x7ec;
                this.columnworkerApply.ReadOnly = true;
                this.columnworkerApply.MaxLength = 0x23;
                this.columnDivisionApply.MaxLength = 100;
                this.columnownerName.MaxLength = 50;
                this.columnInstruction.ReadOnly = true;
                this.columnInstruction.MaxLength = 0xfda;
                this.columnisNoSESNO.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class338 method_5()
            {
                return (DataSetDamage.Class338) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetDamage.Class338 class338_0)
            {
                base.Rows.Remove(class338_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class338(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vJ_DamageRowChanged != null)
                {
                    this.vJ_DamageRowChanged(this, new DataSetDamage.EventArgs194((DataSetDamage.Class338) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vJ_DamageRowChanging != null)
                {
                    this.vJ_DamageRowChanging(this, new DataSetDamage.EventArgs194((DataSetDamage.Class338) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vJ_DamageRowDeleted != null)
                {
                    this.vJ_DamageRowDeleted(this, new DataSetDamage.EventArgs194((DataSetDamage.Class338) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vJ_DamageRowDeleting != null)
                {
                    this.vJ_DamageRowDeleting(this, new DataSetDamage.EventArgs194((DataSetDamage.Class338) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vJ_DamageDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ComletedWorkTextColumn
            {
                get
                {
                    return this.columnComletedWorkText;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn compilerColumn
            {
                get
                {
                    return this.columncompiler;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn completedWorkColumn
            {
                get
                {
                    return this.columncompletedWork;
                }
            }

            [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateApplyColumn
            {
                get
                {
                    return this.columndateApply;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateDocColumn
            {
                get
                {
                    return this.columndateDoc;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateOwnerColumn
            {
                get
                {
                    return this.columndateOwner;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn datePlanEndColumn
            {
                get
                {
                    return this.columndatePlanEnd;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn defectLocationColumn
            {
                get
                {
                    return this.columndefectLocation;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn deletedColumn
            {
                get
                {
                    return this.columndeleted;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DivisionApplyColumn
            {
                get
                {
                    return this.columnDivisionApply;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DivisionColumn
            {
                get
                {
                    return this.columnDivision;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idCompilerColumn
            {
                get
                {
                    return this.columnidCompiler;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idCompletedWorkColumn
            {
                get
                {
                    return this.columnidCompletedWork;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idDivisionApplyColumn
            {
                get
                {
                    return this.columnidDivisionApply;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idDivisionColumn
            {
                get
                {
                    return this.columnidDivision;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idMapColumn
            {
                get
                {
                    return this.columnidMap;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idParentColumn
            {
                get
                {
                    return this.columnidParent;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idReasonColumn
            {
                get
                {
                    return this.columnidReason;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idReqForRepairColumn
            {
                get
                {
                    return this.columnidReqForRepair;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idSchmObjColumn
            {
                get
                {
                    return this.columnidSchmObj;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idSubColumn
            {
                get
                {
                    return this.columnidSub;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idWorkerApplyColumn
            {
                get
                {
                    return this.columnidWorkerApply;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn InstructionColumn
            {
                get
                {
                    return this.columnInstruction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn isApplyColumn
            {
                get
                {
                    return this.columnisApply;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn isLaboratoryColumn
            {
                get
                {
                    return this.columnisLaboratory;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn isNoSESNOColumn
            {
                get
                {
                    return this.columnisNoSESNO;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class338 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class338) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn KodPTSColumn
            {
                get
                {
                    return this.columnKodPTS;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn KodPTSStrColumn
            {
                get
                {
                    return this.columnKodPTSStr;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NetRegionSubColumn
            {
                get
                {
                    return this.columnNetRegionSub;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn numcrashColumn
            {
                get
                {
                    return this.columnnumcrash;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn numDocColumn
            {
                get
                {
                    return this.columnnumDoc;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn numrequestColumn
            {
                get
                {
                    return this.columnnumrequest;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ownerNameColumn
            {
                get
                {
                    return this.columnownerName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ReasonColumn
            {
                get
                {
                    return this.columnReason;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn reasonCrashEquipNameColumn
            {
                get
                {
                    return this.columnreasonCrashEquipName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn reasonCrashEquipTypeColumn
            {
                get
                {
                    return this.columnreasonCrashEquipType;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn reasonCrashNameColumn
            {
                get
                {
                    return this.columnreasonCrashName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn reasonCrashTypeColumn
            {
                get
                {
                    return this.columnreasonCrashType;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn schmObjNameColumn
            {
                get
                {
                    return this.columnschmObjName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn signCrashNameColumn
            {
                get
                {
                    return this.columnsignCrashName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn signCrashTypeColumn
            {
                get
                {
                    return this.columnsignCrashType;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TypeDocColumn
            {
                get
                {
                    return this.columnTypeDoc;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TypeDocNameColumn
            {
                get
                {
                    return this.columnTypeDocName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn typeEquipColumn
            {
                get
                {
                    return this.columntypeEquip;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn typeEquipNameColumn
            {
                get
                {
                    return this.columntypeEquipName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn workerApplyColumn
            {
                get
                {
                    return this.columnworkerApply;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vJ_TemperatureDataTable : TypedTableBase<DataSetDamage.Class335>
        {
            private DataColumn columnComment;
            private DataColumn columnDateOwner;
            private DataColumn columnDateTemp;
            private DataColumn columnDay;
            private DataColumn columnDayDown;
            private DataColumn columnDayUp;
            private DataColumn columnid;
            private DataColumn columnidOwner;
            private DataColumn columnNight;
            private DataColumn columnNightDown;
            private DataColumn columnNightUp;
            private DataColumn columnOwner;
            private DataColumn columnSpeed;
            private DataColumn columnSpeedDown;
            private DataColumn columnSpeedUp;
            private DataColumn columnTempAverage;
            private DataColumn columnWind;
            private DataColumn columnWindName;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate195 vJ_TemperatureRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate195 vJ_TemperatureRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate195 vJ_TemperatureRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate195 vJ_TemperatureRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vJ_TemperatureDataTable() : this(false)
            {
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vJ_TemperatureDataTable(bool bool_0)
            {
                base.TableName = "vJ_Temperature";
                this.BeginInit();
                this.method_5();
                if (bool_0)
                {
                    this.method_7();
                }
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vJ_TemperatureDataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected vJ_TemperatureDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_4();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetDamage.vJ_TemperatureDataTable table1 = (DataSetDamage.vJ_TemperatureDataTable) base.Clone();
                table1.method_4();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.vJ_TemperatureDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class335);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetDamage.Class335 class335_0)
            {
                base.Rows.Add(class335_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class335 method_1(DateTime dateTime_0, short short_0, short short_1, short short_2, short short_3, short short_4, int int_0, string string_0, short short_5, short short_6, string string_1, DateTime dateTime_1, int int_1, string string_2, string string_3, string string_4, string string_5)
            {
                DataSetDamage.Class335 row = (DataSetDamage.Class335) base.NewRow();
                object[] objArray1 = new object[0x12];
                objArray1[1] = dateTime_0;
                objArray1[2] = short_0;
                objArray1[3] = short_1;
                objArray1[4] = short_2;
                objArray1[5] = short_3;
                objArray1[6] = short_4;
                objArray1[7] = int_0;
                objArray1[8] = string_0;
                objArray1[9] = short_5;
                objArray1[10] = short_6;
                objArray1[11] = string_1;
                objArray1[12] = dateTime_1;
                objArray1[13] = int_1;
                objArray1[14] = string_2;
                objArray1[15] = string_3;
                objArray1[0x10] = string_4;
                objArray1[0x11] = string_5;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class335 method_2(DateTime dateTime_0, short short_0, short short_1, short short_2, short short_3, short short_4, int int_0, string string_0, short short_5, short short_6, string string_1, DateTime dateTime_1, int int_1, string string_2)
            {
                DataSetDamage.Class335 row = (DataSetDamage.Class335) base.NewRow();
                object[] objArray1 = new object[0x12];
                objArray1[1] = dateTime_0;
                objArray1[2] = short_0;
                objArray1[3] = short_1;
                objArray1[4] = short_2;
                objArray1[5] = short_3;
                objArray1[6] = short_4;
                objArray1[7] = int_0;
                objArray1[8] = string_0;
                objArray1[9] = short_5;
                objArray1[10] = short_6;
                objArray1[11] = string_1;
                objArray1[12] = dateTime_1;
                objArray1[13] = int_1;
                objArray1[14] = string_2;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class335 method_3(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetDamage.Class335) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_4()
            {
                this.columnid = base.Columns["id"];
                this.columnDateTemp = base.Columns["DateTemp"];
                this.columnNightDown = base.Columns["NightDown"];
                this.columnNightUp = base.Columns["NightUp"];
                this.columnDayDown = base.Columns["DayDown"];
                this.columnDayUp = base.Columns["DayUp"];
                this.columnTempAverage = base.Columns["TempAverage"];
                this.columnWind = base.Columns["Wind"];
                this.columnWindName = base.Columns["WindName"];
                this.columnSpeedDown = base.Columns["SpeedDown"];
                this.columnSpeedUp = base.Columns["SpeedUp"];
                this.columnComment = base.Columns["Comment"];
                this.columnDateOwner = base.Columns["DateOwner"];
                this.columnidOwner = base.Columns["idOwner"];
                this.columnOwner = base.Columns["Owner"];
                this.columnNight = base.Columns["Night"];
                this.columnDay = base.Columns["Day"];
                this.columnSpeed = base.Columns["Speed"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_5()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnDateTemp = new DataColumn("DateTemp", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateTemp);
                this.columnNightDown = new DataColumn("NightDown", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnNightDown);
                this.columnNightUp = new DataColumn("NightUp", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnNightUp);
                this.columnDayDown = new DataColumn("DayDown", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnDayDown);
                this.columnDayUp = new DataColumn("DayUp", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnDayUp);
                this.columnTempAverage = new DataColumn("TempAverage", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnTempAverage);
                this.columnWind = new DataColumn("Wind", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnWind);
                this.columnWindName = new DataColumn("WindName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnWindName);
                this.columnSpeedDown = new DataColumn("SpeedDown", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnSpeedDown);
                this.columnSpeedUp = new DataColumn("SpeedUp", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnSpeedUp);
                this.columnComment = new DataColumn("Comment", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComment);
                this.columnDateOwner = new DataColumn("DateOwner", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateOwner);
                this.columnidOwner = new DataColumn("idOwner", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidOwner);
                this.columnOwner = new DataColumn("Owner", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnOwner);
                this.columnNight = new DataColumn("Night", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNight);
                this.columnDay = new DataColumn("Day", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDay);
                this.columnSpeed = new DataColumn("Speed", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnSpeed);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnDateTemp.AllowDBNull = false;
                this.columnComment.MaxLength = 0x100;
                this.columnOwner.MaxLength = 0x100;
                this.columnNight.ReadOnly = true;
                this.columnDay.ReadOnly = true;
                this.columnSpeed.ReadOnly = true;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class335 method_6()
            {
                return (DataSetDamage.Class335) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_7()
            {
                this.NightColumn.Expression = "isnull('от ' +NightDown + ' ' , '') + isnull('до ' + nightUp, '')";
                this.DayColumn.Expression = "isnull('от ' +DayDown + ' ' , '') + isnull('до ' + DayUp, '')";
                this.SpeedColumn.Expression = "isnull(SpeedDown + ' - ' , '') + isnull( SpeedUp, '')";
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_8(DataSetDamage.Class335 class335_0)
            {
                base.Rows.Remove(class335_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class335(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vJ_TemperatureRowChanged != null)
                {
                    this.vJ_TemperatureRowChanged(this, new DataSetDamage.EventArgs191((DataSetDamage.Class335) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vJ_TemperatureRowChanging != null)
                {
                    this.vJ_TemperatureRowChanging(this, new DataSetDamage.EventArgs191((DataSetDamage.Class335) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vJ_TemperatureRowDeleted != null)
                {
                    this.vJ_TemperatureRowDeleted(this, new DataSetDamage.EventArgs191((DataSetDamage.Class335) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vJ_TemperatureRowDeleting != null)
                {
                    this.vJ_TemperatureRowDeleting(this, new DataSetDamage.EventArgs191((DataSetDamage.Class335) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vJ_TemperatureDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CommentColumn
            {
                get
                {
                    return this.columnComment;
                }
            }

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateOwnerColumn
            {
                get
                {
                    return this.columnDateOwner;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateTempColumn
            {
                get
                {
                    return this.columnDateTemp;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DayColumn
            {
                get
                {
                    return this.columnDay;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DayDownColumn
            {
                get
                {
                    return this.columnDayDown;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DayUpColumn
            {
                get
                {
                    return this.columnDayUp;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idOwnerColumn
            {
                get
                {
                    return this.columnidOwner;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class335 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class335) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NightColumn
            {
                get
                {
                    return this.columnNight;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NightDownColumn
            {
                get
                {
                    return this.columnNightDown;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NightUpColumn
            {
                get
                {
                    return this.columnNightUp;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn OwnerColumn
            {
                get
                {
                    return this.columnOwner;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn SpeedColumn
            {
                get
                {
                    return this.columnSpeed;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SpeedDownColumn
            {
                get
                {
                    return this.columnSpeedDown;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn SpeedUpColumn
            {
                get
                {
                    return this.columnSpeedUp;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TempAverageColumn
            {
                get
                {
                    return this.columnTempAverage;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn WindColumn
            {
                get
                {
                    return this.columnWind;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn WindNameColumn
            {
                get
                {
                    return this.columnWindName;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vWorkerGroupDataTable : TypedTableBase<DataSetDamage.Class331>
        {
            private DataColumn columnDateBegin;
            private DataColumn columnDateEnd;
            private DataColumn columnDescription;
            private DataColumn columnFIO;
            private DataColumn columnGroupElectrical;
            private DataColumn columnid;
            private DataColumn columnidDescription;
            private DataColumn columnidGroup;
            private DataColumn columnParentKey;
            private DataColumn columnWorkerGroup;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate191 vWorkerGroupRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate191 vWorkerGroupRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate191 vWorkerGroupRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetDamage.Delegate191 vWorkerGroupRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vWorkerGroupDataTable()
            {
                base.TableName = "vWorkerGroup";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vWorkerGroupDataTable(DataTable dataTable_0)
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected vWorkerGroupDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetDamage.vWorkerGroupDataTable table1 = (DataSetDamage.vWorkerGroupDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetDamage.vWorkerGroupDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetDamage.Class331);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetDamage.Class331 class331_0)
            {
                base.Rows.Add(class331_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetDamage.Class331 method_1(int int_0, string string_0, DateTime dateTime_0, DateTime dateTime_1, int int_1, string string_1, string string_2, string string_3, int int_2, short short_0)
            {
                DataSetDamage.Class331 row = (DataSetDamage.Class331) base.NewRow();
                object[] objArray = new object[] { int_0, string_0, dateTime_0, dateTime_1, int_1, string_1, string_2, string_3, int_2, short_0 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnid = base.Columns["id"];
                this.columnFIO = base.Columns["FIO"];
                this.columnDateBegin = base.Columns["DateBegin"];
                this.columnDateEnd = base.Columns["DateEnd"];
                this.columnidGroup = base.Columns["idGroup"];
                this.columnWorkerGroup = base.Columns["WorkerGroup"];
                this.columnParentKey = base.Columns["ParentKey"];
                this.columnDescription = base.Columns["Description"];
                this.columnidDescription = base.Columns["idDescription"];
                this.columnGroupElectrical = base.Columns["GroupElectrical"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnFIO = new DataColumn("FIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFIO);
                this.columnDateBegin = new DataColumn("DateBegin", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateBegin);
                this.columnDateEnd = new DataColumn("DateEnd", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateEnd);
                this.columnidGroup = new DataColumn("idGroup", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidGroup);
                this.columnWorkerGroup = new DataColumn("WorkerGroup", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnWorkerGroup);
                this.columnParentKey = new DataColumn("ParentKey", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnParentKey);
                this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDescription);
                this.columnidDescription = new DataColumn("idDescription", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidDescription);
                this.columnGroupElectrical = new DataColumn("GroupElectrical", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnGroupElectrical);
                this.columnid.AllowDBNull = false;
                this.columnFIO.ReadOnly = true;
                this.columnFIO.MaxLength = 0x23;
                this.columnWorkerGroup.MaxLength = 100;
                this.columnParentKey.MaxLength = 50;
                this.columnDescription.MaxLength = 100;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class331 method_4()
            {
                return (DataSetDamage.Class331) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(DataSetDamage.Class331 class331_0)
            {
                base.Rows.Remove(class331_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetDamage.Class331(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vWorkerGroupRowChanged != null)
                {
                    this.vWorkerGroupRowChanged(this, new DataSetDamage.EventArgs187((DataSetDamage.Class331) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vWorkerGroupRowChanging != null)
                {
                    this.vWorkerGroupRowChanging(this, new DataSetDamage.EventArgs187((DataSetDamage.Class331) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vWorkerGroupRowDeleted != null)
                {
                    this.vWorkerGroupRowDeleted(this, new DataSetDamage.EventArgs187((DataSetDamage.Class331) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vWorkerGroupRowDeleting != null)
                {
                    this.vWorkerGroupRowDeleting(this, new DataSetDamage.EventArgs187((DataSetDamage.Class331) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetDamage damage = new DataSetDamage();
                XmlSchemaAny item = new XmlSchemaAny {
                    Namespace = "http://www.w3.org/2001/XMLSchema",
                    MinOccurs = 0M,
                    MaxOccurs = 79228162514264337593543950335M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(item);
                XmlSchemaAny any2 = new XmlSchemaAny {
                    Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1",
                    MinOccurs = 1M,
                    ProcessContents = XmlSchemaContentProcessing.Lax
                };
                sequence.Items.Add(any2);
                XmlSchemaAttribute attribute = new XmlSchemaAttribute {
                    Name = "namespace",
                    FixedValue = damage.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vWorkerGroupDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = damage.GetSchemaSerializable();
                if (xmlSchemaSet_0.Contains(schemaSerializable.TargetNamespace))
                {
                    XmlSchemaComplexType type2;
                    MemoryStream stream = new MemoryStream();
                    MemoryStream stream2 = new MemoryStream();
                    try
                    {
                        schemaSerializable.Write(stream);
                        IEnumerator enumerator = xmlSchemaSet_0.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            stream2.SetLength(0L);
                            ((XmlSchema) enumerator.Current).Write(stream2);
                            if (stream.Length == stream2.Length)
                            {
                                stream.Position = 0L;
                                stream2.Position = 0L;
                                while (stream.Position != stream.Length)
                                {
                                    if (stream.ReadByte() != stream2.ReadByte())
                                    {
                                        break;
                                    }
                                }
                                if (stream.Position == stream.Length)
                                {
                                    goto Label_01CE;
                                }
                            }
                        }
                        goto Label_01ED;
                    Label_01CE:
                        type2 = type;
                    }
                    finally
                    {
                        if (stream != null)
                        {
                            stream.Close();
                        }
                        if (stream2 != null)
                        {
                            stream2.Close();
                        }
                    }
                    return type2;
                }
            Label_01ED:
                xmlSchemaSet_0.Add(schemaSerializable);
                return type;
            }

            [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateBeginColumn
            {
                get
                {
                    return this.columnDateBegin;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateEndColumn
            {
                get
                {
                    return this.columnDateEnd;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DescriptionColumn
            {
                get
                {
                    return this.columnDescription;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FIOColumn
            {
                get
                {
                    return this.columnFIO;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn GroupElectricalColumn
            {
                get
                {
                    return this.columnGroupElectrical;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idDescriptionColumn
            {
                get
                {
                    return this.columnidDescription;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idGroupColumn
            {
                get
                {
                    return this.columnidGroup;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetDamage.Class331 this[int int_0]
            {
                get
                {
                    return (DataSetDamage.Class331) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ParentKeyColumn
            {
                get
                {
                    return this.columnParentKey;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn WorkerGroupColumn
            {
                get
                {
                    return this.columnWorkerGroup;
                }
            }
        }
    }
}

