namespace Documents.DataSets
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

    [Serializable, XmlRoot("DataSetOrder"), DesignerCategory("code"), XmlSchemaProvider("GetTypedDataSetSchema"), ToolboxItem(true), HelpKeyword("vs.data.DataSet")]
    internal class DataSetOrder : DataSet
    {
        private System.Data.SchemaSerializationMode _schemaSerializationMode;
        private tj_DailyTourReportDataTable tabletj_DailyTourReport;
        private tJ_OrderDataTable tabletJ_Order;
        private tJ_OrderBrigadeDataTable tabletJ_OrderBrigade;
        private tJ_OrderInstructionDataTable tabletJ_OrderInstruction;
        private tJ_OrderResolutionDataTable tabletJ_OrderResolution;
        private tL_OrderSchmObjListDataTable tabletL_OrderSchmObjList;
        private tR_ClassifierDataTable tabletR_Classifier;
        private tSchm_RelationDataTable tabletSchm_Relation;
        private vJ_OrderDataTable tablevJ_Order;
        private vJ_OrderEventsDataTable tablevJ_OrderEvents;
        private vR_WorkerDataTable tablevR_Worker;
        private vSchm_ObjListDataTable tablevSchm_ObjList;
        private vSchm_TreeCellLineDataTable tablevSchm_TreeCellLine;
        private vWorkerGroupDataTable tablevWorkerGroup;

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public DataSetOrder()
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            base.BeginInit();
            this.method_2();
            CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_17);
            base.Tables.CollectionChanged += handler;
            base.Relations.CollectionChanged += handler;
            base.EndInit();
            this.method_18();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected DataSetOrder(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0, false)
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            if (base.IsBinarySerialized(serializationInfo_0, streamingContext_0))
            {
                this.method_1(false);
                CollectionChangeEventHandler handler2 = new CollectionChangeEventHandler(this.method_17);
                this.Tables.CollectionChanged += handler2;
                this.Relations.CollectionChanged += handler2;
                if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == System.Data.SchemaSerializationMode.ExcludeSchema)
                {
                    this.method_18();
                }
            }
            else
            {
                string s = (string) serializationInfo_0.GetValue("XmlSchema", typeof(string));
                if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == System.Data.SchemaSerializationMode.IncludeSchema)
                {
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
                    if (dataSet.Tables["tJ_Order"] != null)
                    {
                        base.Tables.Add(new tJ_OrderDataTable(dataSet.Tables["tJ_Order"]));
                    }
                    if (dataSet.Tables["vJ_Order"] != null)
                    {
                        base.Tables.Add(new vJ_OrderDataTable(dataSet.Tables["vJ_Order"]));
                    }
                    if (dataSet.Tables["tR_Classifier"] != null)
                    {
                        base.Tables.Add(new tR_ClassifierDataTable(dataSet.Tables["tR_Classifier"]));
                    }
                    if (dataSet.Tables["vR_Worker"] != null)
                    {
                        base.Tables.Add(new vR_WorkerDataTable(dataSet.Tables["vR_Worker"]));
                    }
                    if (dataSet.Tables["vWorkerGroup"] != null)
                    {
                        base.Tables.Add(new vWorkerGroupDataTable(dataSet.Tables["vWorkerGroup"]));
                    }
                    if (dataSet.Tables["tJ_OrderBrigade"] != null)
                    {
                        base.Tables.Add(new tJ_OrderBrigadeDataTable(dataSet.Tables["tJ_OrderBrigade"]));
                    }
                    if (dataSet.Tables["tj_DailyTourReport"] != null)
                    {
                        base.Tables.Add(new tj_DailyTourReportDataTable(dataSet.Tables["tj_DailyTourReport"]));
                    }
                    if (dataSet.Tables["tJ_OrderInstruction"] != null)
                    {
                        base.Tables.Add(new tJ_OrderInstructionDataTable(dataSet.Tables["tJ_OrderInstruction"]));
                    }
                    if (dataSet.Tables["tJ_OrderResolution"] != null)
                    {
                        base.Tables.Add(new tJ_OrderResolutionDataTable(dataSet.Tables["tJ_OrderResolution"]));
                    }
                    if (dataSet.Tables["vJ_OrderEvents"] != null)
                    {
                        base.Tables.Add(new vJ_OrderEventsDataTable(dataSet.Tables["vJ_OrderEvents"]));
                    }
                    if (dataSet.Tables["tL_OrderSchmObjList"] != null)
                    {
                        base.Tables.Add(new tL_OrderSchmObjListDataTable(dataSet.Tables["tL_OrderSchmObjList"]));
                    }
                    if (dataSet.Tables["vSchm_ObjList"] != null)
                    {
                        base.Tables.Add(new vSchm_ObjListDataTable(dataSet.Tables["vSchm_ObjList"]));
                    }
                    if (dataSet.Tables["vSchm_TreeCellLine"] != null)
                    {
                        base.Tables.Add(new vSchm_TreeCellLineDataTable(dataSet.Tables["vSchm_TreeCellLine"]));
                    }
                    if (dataSet.Tables["tSchm_Relation"] != null)
                    {
                        base.Tables.Add(new tSchm_RelationDataTable(dataSet.Tables["tSchm_Relation"]));
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
                CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_17);
                base.Tables.CollectionChanged += handler;
                this.Relations.CollectionChanged += handler;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override DataSet Clone()
        {
            DataSetOrder order1 = (DataSetOrder) base.Clone();
            order1.method_0();
            order1.method_18();
            order1.SchemaSerializationMode = this.SchemaSerializationMode;
            return order1;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected override XmlSchema GetSchemaSerializable()
        {
            MemoryStream w = new MemoryStream();
            base.WriteXmlSchema(new XmlTextWriter(w, null));
            w.Position = 0L;
            return XmlSchema.Read(new XmlTextReader(w), null);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        internal void method_1(bool bool_0)
        {
            this.tabletJ_Order = (tJ_OrderDataTable) base.Tables["tJ_Order"];
            if (bool_0 && (this.tabletJ_Order != null))
            {
                this.tabletJ_Order.method_3();
            }
            this.tablevJ_Order = (vJ_OrderDataTable) base.Tables["vJ_Order"];
            if (bool_0 && (this.tablevJ_Order != null))
            {
                this.tablevJ_Order.method_4();
            }
            this.tabletR_Classifier = (tR_ClassifierDataTable) base.Tables["tR_Classifier"];
            if (bool_0 && (this.tabletR_Classifier != null))
            {
                this.tabletR_Classifier.method_3();
            }
            this.tablevR_Worker = (vR_WorkerDataTable) base.Tables["vR_Worker"];
            if (bool_0 && (this.tablevR_Worker != null))
            {
                this.tablevR_Worker.method_3();
            }
            this.tablevWorkerGroup = (vWorkerGroupDataTable) base.Tables["vWorkerGroup"];
            if (bool_0 && (this.tablevWorkerGroup != null))
            {
                this.tablevWorkerGroup.method_2();
            }
            this.tabletJ_OrderBrigade = (tJ_OrderBrigadeDataTable) base.Tables["tJ_OrderBrigade"];
            if (bool_0 && (this.tabletJ_OrderBrigade != null))
            {
                this.tabletJ_OrderBrigade.method_3();
            }
            this.tabletj_DailyTourReport = (tj_DailyTourReportDataTable) base.Tables["tj_DailyTourReport"];
            if (bool_0 && (this.tabletj_DailyTourReport != null))
            {
                this.tabletj_DailyTourReport.method_3();
            }
            this.tabletJ_OrderInstruction = (tJ_OrderInstructionDataTable) base.Tables["tJ_OrderInstruction"];
            if (bool_0 && (this.tabletJ_OrderInstruction != null))
            {
                this.tabletJ_OrderInstruction.method_3();
            }
            this.tabletJ_OrderResolution = (tJ_OrderResolutionDataTable) base.Tables["tJ_OrderResolution"];
            if (bool_0 && (this.tabletJ_OrderResolution != null))
            {
                this.tabletJ_OrderResolution.method_3();
            }
            this.tablevJ_OrderEvents = (vJ_OrderEventsDataTable) base.Tables["vJ_OrderEvents"];
            if (bool_0 && (this.tablevJ_OrderEvents != null))
            {
                this.tablevJ_OrderEvents.method_2();
            }
            this.tabletL_OrderSchmObjList = (tL_OrderSchmObjListDataTable) base.Tables["tL_OrderSchmObjList"];
            if (bool_0 && (this.tabletL_OrderSchmObjList != null))
            {
                this.tabletL_OrderSchmObjList.method_3();
            }
            this.tablevSchm_ObjList = (vSchm_ObjListDataTable) base.Tables["vSchm_ObjList"];
            if (bool_0 && (this.tablevSchm_ObjList != null))
            {
                this.tablevSchm_ObjList.method_3();
            }
            this.tablevSchm_TreeCellLine = (vSchm_TreeCellLineDataTable) base.Tables["vSchm_TreeCellLine"];
            if (bool_0 && (this.tablevSchm_TreeCellLine != null))
            {
                this.tablevSchm_TreeCellLine.method_2();
            }
            this.tabletSchm_Relation = (tSchm_RelationDataTable) base.Tables["tSchm_Relation"];
            if (bool_0 && (this.tabletSchm_Relation != null))
            {
                this.tabletSchm_Relation.method_3();
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_12()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_13()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_14()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_15()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_16()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_17(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Remove)
            {
                this.method_0();
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_18()
        {
            this.vJ_Order.OutputMakerColumn.Expression = "OutputFIO + convert(13,System.Char) + convert(10,System.Char)+ MakerFIO";
            this.vJ_Order.ResolutionColumn.Expression = "resWorker+ convert(13,System.Char) + convert(10,System.Char) + beginRes";
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_2()
        {
            base.DataSetName = "DataSetOrder";
            base.Prefix = "";
            base.Namespace = "http://tempuri.org/DataSetOrder.xsd";
            base.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tabletJ_Order = new tJ_OrderDataTable();
            base.Tables.Add(this.tabletJ_Order);
            this.tablevJ_Order = new vJ_OrderDataTable(false);
            base.Tables.Add(this.tablevJ_Order);
            this.tabletR_Classifier = new tR_ClassifierDataTable();
            base.Tables.Add(this.tabletR_Classifier);
            this.tablevR_Worker = new vR_WorkerDataTable();
            base.Tables.Add(this.tablevR_Worker);
            this.tablevWorkerGroup = new vWorkerGroupDataTable();
            base.Tables.Add(this.tablevWorkerGroup);
            this.tabletJ_OrderBrigade = new tJ_OrderBrigadeDataTable();
            base.Tables.Add(this.tabletJ_OrderBrigade);
            this.tabletj_DailyTourReport = new tj_DailyTourReportDataTable();
            base.Tables.Add(this.tabletj_DailyTourReport);
            this.tabletJ_OrderInstruction = new tJ_OrderInstructionDataTable();
            base.Tables.Add(this.tabletJ_OrderInstruction);
            this.tabletJ_OrderResolution = new tJ_OrderResolutionDataTable();
            base.Tables.Add(this.tabletJ_OrderResolution);
            this.tablevJ_OrderEvents = new vJ_OrderEventsDataTable();
            base.Tables.Add(this.tablevJ_OrderEvents);
            this.tabletL_OrderSchmObjList = new tL_OrderSchmObjListDataTable();
            base.Tables.Add(this.tabletL_OrderSchmObjList);
            this.tablevSchm_ObjList = new vSchm_ObjListDataTable();
            base.Tables.Add(this.tablevSchm_ObjList);
            this.tablevSchm_TreeCellLine = new vSchm_TreeCellLineDataTable();
            base.Tables.Add(this.tablevSchm_TreeCellLine);
            this.tabletSchm_Relation = new tSchm_RelationDataTable();
            base.Tables.Add(this.tabletSchm_Relation);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_3()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_7()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_8()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_9()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected override void ReadXmlSerializable(XmlReader reader)
        {
            if (base.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)
            {
                this.Reset();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(reader);
                if (dataSet.Tables["tJ_Order"] != null)
                {
                    base.Tables.Add(new tJ_OrderDataTable(dataSet.Tables["tJ_Order"]));
                }
                if (dataSet.Tables["vJ_Order"] != null)
                {
                    base.Tables.Add(new vJ_OrderDataTable(dataSet.Tables["vJ_Order"]));
                }
                if (dataSet.Tables["tR_Classifier"] != null)
                {
                    base.Tables.Add(new tR_ClassifierDataTable(dataSet.Tables["tR_Classifier"]));
                }
                if (dataSet.Tables["vR_Worker"] != null)
                {
                    base.Tables.Add(new vR_WorkerDataTable(dataSet.Tables["vR_Worker"]));
                }
                if (dataSet.Tables["vWorkerGroup"] != null)
                {
                    base.Tables.Add(new vWorkerGroupDataTable(dataSet.Tables["vWorkerGroup"]));
                }
                if (dataSet.Tables["tJ_OrderBrigade"] != null)
                {
                    base.Tables.Add(new tJ_OrderBrigadeDataTable(dataSet.Tables["tJ_OrderBrigade"]));
                }
                if (dataSet.Tables["tj_DailyTourReport"] != null)
                {
                    base.Tables.Add(new tj_DailyTourReportDataTable(dataSet.Tables["tj_DailyTourReport"]));
                }
                if (dataSet.Tables["tJ_OrderInstruction"] != null)
                {
                    base.Tables.Add(new tJ_OrderInstructionDataTable(dataSet.Tables["tJ_OrderInstruction"]));
                }
                if (dataSet.Tables["tJ_OrderResolution"] != null)
                {
                    base.Tables.Add(new tJ_OrderResolutionDataTable(dataSet.Tables["tJ_OrderResolution"]));
                }
                if (dataSet.Tables["vJ_OrderEvents"] != null)
                {
                    base.Tables.Add(new vJ_OrderEventsDataTable(dataSet.Tables["vJ_OrderEvents"]));
                }
                if (dataSet.Tables["tL_OrderSchmObjList"] != null)
                {
                    base.Tables.Add(new tL_OrderSchmObjListDataTable(dataSet.Tables["tL_OrderSchmObjList"]));
                }
                if (dataSet.Tables["vSchm_ObjList"] != null)
                {
                    base.Tables.Add(new vSchm_ObjListDataTable(dataSet.Tables["vSchm_ObjList"]));
                }
                if (dataSet.Tables["vSchm_TreeCellLine"] != null)
                {
                    base.Tables.Add(new vSchm_TreeCellLineDataTable(dataSet.Tables["vSchm_TreeCellLine"]));
                }
                if (dataSet.Tables["tSchm_Relation"] != null)
                {
                    base.Tables.Add(new tSchm_RelationDataTable(dataSet.Tables["tSchm_Relation"]));
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override bool ShouldSerializeTables()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
        {
            DataSetOrder order = new DataSetOrder();
            XmlSchemaComplexType type = new XmlSchemaComplexType();
            XmlSchemaSequence sequence = new XmlSchemaSequence();
            XmlSchemaAny item = new XmlSchemaAny {
                Namespace = order.Namespace
            };
            sequence.Items.Add(item);
            type.Particle = sequence;
            XmlSchema schemaSerializable = order.GetSchemaSerializable();
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
        public DataTableCollection Tables
        {
            get
            {
                return base.Tables;
            }
        }

        [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tj_DailyTourReportDataTable tj_DailyTourReport
        {
            get
            {
                return this.tabletj_DailyTourReport;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tJ_OrderDataTable tJ_Order
        {
            get
            {
                return this.tabletJ_Order;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
        public tJ_OrderBrigadeDataTable tJ_OrderBrigade
        {
            get
            {
                return this.tabletJ_OrderBrigade;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false)]
        public tJ_OrderInstructionDataTable tJ_OrderInstruction
        {
            get
            {
                return this.tabletJ_OrderInstruction;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false)]
        public tJ_OrderResolutionDataTable tJ_OrderResolution
        {
            get
            {
                return this.tabletJ_OrderResolution;
            }
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tL_OrderSchmObjListDataTable tL_OrderSchmObjList
        {
            get
            {
                return this.tabletL_OrderSchmObjList;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tR_ClassifierDataTable tR_Classifier
        {
            get
            {
                return this.tabletR_Classifier;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode]
        public tSchm_RelationDataTable tSchm_Relation
        {
            get
            {
                return this.tabletSchm_Relation;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
        public vJ_OrderDataTable vJ_Order
        {
            get
            {
                return this.tablevJ_Order;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public vJ_OrderEventsDataTable vJ_OrderEvents
        {
            get
            {
                return this.tablevJ_OrderEvents;
            }
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public vR_WorkerDataTable vR_Worker
        {
            get
            {
                return this.tablevR_Worker;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public vSchm_ObjListDataTable vSchm_ObjList
        {
            get
            {
                return this.tablevSchm_ObjList;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
        public vSchm_TreeCellLineDataTable vSchm_TreeCellLine
        {
            get
            {
                return this.tablevSchm_TreeCellLine;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public vWorkerGroupDataTable vWorkerGroup
        {
            get
            {
                return this.tablevWorkerGroup;
            }
        }

        public class Class372 : DataRow
        {
            private DataSetOrder.tJ_OrderDataTable tJ_OrderDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class372(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_OrderDataTable_0 = (DataSetOrder.tJ_OrderDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_OrderDataTable_0.numColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_OrderDataTable_0.numColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_OrderDataTable_0.watchWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'watchWorker' in table 'tJ_Order' is DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.tJ_OrderDataTable_0.watchWorkerColumn] = int_0;
            }

            public int method_12()
            {
                return (int) base[this.tJ_OrderDataTable_0.makerWorkerColumn];
            }

            public void method_13(int int_0)
            {
                base[this.tJ_OrderDataTable_0.makerWorkerColumn] = int_0;
            }

            public string method_14()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_OrderDataTable_0.otherInstructionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'otherInstruction' in table 'tJ_Order' is DBNull.", exception);
                }
                return str;
            }

            public void method_15(string string_0)
            {
                base[this.tJ_OrderDataTable_0.otherInstructionColumn] = string_0;
            }

            public DateTime method_16()
            {
                return (DateTime) base[this.tJ_OrderDataTable_0.dateOutputColumn];
            }

            public void method_17(DateTime dateTime_0)
            {
                base[this.tJ_OrderDataTable_0.dateOutputColumn] = dateTime_0;
            }

            public int method_18()
            {
                return (int) base[this.tJ_OrderDataTable_0.outputWorkerColumn];
            }

            public void method_19(int int_0)
            {
                base[this.tJ_OrderDataTable_0.outputWorkerColumn] = int_0;
            }

            public int method_2()
            {
                return (int) base[this.tJ_OrderDataTable_0.idSRColumn];
            }

            public bool method_20()
            {
                return (bool) base[this.tJ_OrderDataTable_0.registeredColumn];
            }

            public void method_21(bool bool_0)
            {
                base[this.tJ_OrderDataTable_0.registeredColumn] = bool_0;
            }

            public DateTime method_22()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_OrderDataTable_0.dateCloseColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateClose' in table 'tJ_Order' is DBNull.", exception);
                }
                return time;
            }

            public void method_23(DateTime dateTime_0)
            {
                base[this.tJ_OrderDataTable_0.dateCloseColumn] = dateTime_0;
            }

            public int method_24()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_OrderDataTable_0.closeWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'closeWorker' in table 'tJ_Order' is DBNull.", exception);
                }
                return num;
            }

            public void method_25(int int_0)
            {
                base[this.tJ_OrderDataTable_0.closeWorkerColumn] = int_0;
            }

            public int method_26()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_OrderDataTable_0.extWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'extWorker' in table 'tJ_Order' is DBNull.", exception);
                }
                return num;
            }

            public void method_27(int int_0)
            {
                base[this.tJ_OrderDataTable_0.extWorkerColumn] = int_0;
            }

            public DateTime method_28()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_OrderDataTable_0.dateExtColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateExt' in table 'tJ_Order' is DBNull.", exception);
                }
                return time;
            }

            public void method_29(DateTime dateTime_0)
            {
                base[this.tJ_OrderDataTable_0.dateExtColumn] = dateTime_0;
            }

            public void method_3(int int_0)
            {
                base[this.tJ_OrderDataTable_0.idSRColumn] = int_0;
            }

            public DateTime method_30()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_OrderDataTable_0.dateEndExtColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateEndExt' in table 'tJ_Order' is DBNull.", exception);
                }
                return time;
            }

            public void method_31(DateTime dateTime_0)
            {
                base[this.tJ_OrderDataTable_0.dateEndExtColumn] = dateTime_0;
            }

            public int method_32()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_OrderDataTable_0.idDivisionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idDivision' in table 'tJ_Order' is DBNull.", exception);
                }
                return num;
            }

            public void method_33(int int_0)
            {
                base[this.tJ_OrderDataTable_0.idDivisionColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_34()
            {
                return base.IsNull(this.tJ_OrderDataTable_0.headworkerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_35()
            {
                base[this.tJ_OrderDataTable_0.headworkerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_36()
            {
                return base.IsNull(this.tJ_OrderDataTable_0.watchWorkerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_37()
            {
                base[this.tJ_OrderDataTable_0.watchWorkerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_38()
            {
                return base.IsNull(this.tJ_OrderDataTable_0.otherInstructionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_39()
            {
                base[this.tJ_OrderDataTable_0.otherInstructionColumn] = Convert.DBNull;
            }

            public string method_4()
            {
                return (string) base[this.tJ_OrderDataTable_0.instructionColumn];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_40()
            {
                return base.IsNull(this.tJ_OrderDataTable_0.dateCloseColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_41()
            {
                base[this.tJ_OrderDataTable_0.dateCloseColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.tJ_OrderDataTable_0.closeWorkerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_43()
            {
                base[this.tJ_OrderDataTable_0.closeWorkerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_44()
            {
                return base.IsNull(this.tJ_OrderDataTable_0.extWorkerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_45()
            {
                base[this.tJ_OrderDataTable_0.extWorkerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_46()
            {
                return base.IsNull(this.tJ_OrderDataTable_0.dateExtColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.tJ_OrderDataTable_0.dateExtColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_48()
            {
                return base.IsNull(this.tJ_OrderDataTable_0.dateEndExtColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_49()
            {
                base[this.tJ_OrderDataTable_0.dateEndExtColumn] = Convert.DBNull;
            }

            public void method_5(string string_0)
            {
                base[this.tJ_OrderDataTable_0.instructionColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.tJ_OrderDataTable_0.idDivisionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_51()
            {
                base[this.tJ_OrderDataTable_0.idDivisionColumn] = Convert.DBNull;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_OrderDataTable_0.headworkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'headworker' in table 'tJ_Order' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.tJ_OrderDataTable_0.headworkerColumn] = int_0;
            }

            public int method_8()
            {
                return (int) base[this.tJ_OrderDataTable_0.acceptworkerColumn];
            }

            public void method_9(int int_0)
            {
                base[this.tJ_OrderDataTable_0.acceptworkerColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime dateBegin
            {
                get
                {
                    return (DateTime) base[this.tJ_OrderDataTable_0.dateBeginColumn];
                }
                set
                {
                    base[this.tJ_OrderDataTable_0.dateBeginColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime dateEnd
            {
                get
                {
                    return (DateTime) base[this.tJ_OrderDataTable_0.dateEndColumn];
                }
                set
                {
                    base[this.tJ_OrderDataTable_0.dateEndColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_OrderDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_OrderDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class373 : DataRow
        {
            private DataSetOrder.vJ_OrderDataTable vJ_OrderDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class373(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vJ_OrderDataTable_0 = (DataSetOrder.vJ_OrderDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vJ_OrderDataTable_0.numColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vJ_OrderDataTable_0.numColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_OrderDataTable_0.headworkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'headworker' in table 'vJ_Order' is DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_100()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.extFioColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_101()
            {
                base[this.vJ_OrderDataTable_0.extFioColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_102()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.DateEndExtColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_103()
            {
                base[this.vJ_OrderDataTable_0.DateEndExtColumn] = Convert.DBNull;
            }

            public void method_11(int int_0)
            {
                base[this.vJ_OrderDataTable_0.headworkerColumn] = int_0;
            }

            public string method_12()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderDataTable_0.headFioColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'headFio' in table 'vJ_Order' is DBNull.", exception);
                }
                return str;
            }

            public void method_13(string string_0)
            {
                base[this.vJ_OrderDataTable_0.headFioColumn] = string_0;
            }

            public int method_14()
            {
                return (int) base[this.vJ_OrderDataTable_0.acceptworkerColumn];
            }

            public void method_15(int int_0)
            {
                base[this.vJ_OrderDataTable_0.acceptworkerColumn] = int_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderDataTable_0.acceptFIOColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'acceptFIO' in table 'vJ_Order' is DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.vJ_OrderDataTable_0.acceptFIOColumn] = string_0;
            }

            public int method_18()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_OrderDataTable_0.watchWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'watchWorker' in table 'vJ_Order' is DBNull.", exception);
                }
                return num;
            }

            public void method_19(int int_0)
            {
                base[this.vJ_OrderDataTable_0.watchWorkerColumn] = int_0;
            }

            public int method_2()
            {
                return (int) base[this.vJ_OrderDataTable_0.idSRColumn];
            }

            public string method_20()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderDataTable_0.watchFIOColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'watchFIO' in table 'vJ_Order' is DBNull.", exception);
                }
                return str;
            }

            public void method_21(string string_0)
            {
                base[this.vJ_OrderDataTable_0.watchFIOColumn] = string_0;
            }

            public int method_22()
            {
                return (int) base[this.vJ_OrderDataTable_0.makerWorkerColumn];
            }

            public void method_23(int int_0)
            {
                base[this.vJ_OrderDataTable_0.makerWorkerColumn] = int_0;
            }

            public string method_24()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderDataTable_0.makerFIOColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'makerFIO' in table 'vJ_Order' is DBNull.", exception);
                }
                return str;
            }

            public void method_25(string string_0)
            {
                base[this.vJ_OrderDataTable_0.makerFIOColumn] = string_0;
            }

            public string method_26()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderDataTable_0.otherInstructionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'otherInstruction' in table 'vJ_Order' is DBNull.", exception);
                }
                return str;
            }

            public void method_27(string string_0)
            {
                base[this.vJ_OrderDataTable_0.otherInstructionColumn] = string_0;
            }

            public DateTime method_28()
            {
                return (DateTime) base[this.vJ_OrderDataTable_0.dateOutputColumn];
            }

            public void method_29(DateTime dateTime_0)
            {
                base[this.vJ_OrderDataTable_0.dateOutputColumn] = dateTime_0;
            }

            public void method_3(int int_0)
            {
                base[this.vJ_OrderDataTable_0.idSRColumn] = int_0;
            }

            public int method_30()
            {
                return (int) base[this.vJ_OrderDataTable_0.outputWorkerColumn];
            }

            public void method_31(int int_0)
            {
                base[this.vJ_OrderDataTable_0.outputWorkerColumn] = int_0;
            }

            public string method_32()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderDataTable_0.outputFIOColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'outputFIO' in table 'vJ_Order' is DBNull.", exception);
                }
                return str;
            }

            public void method_33(string string_0)
            {
                base[this.vJ_OrderDataTable_0.outputFIOColumn] = string_0;
            }

            public bool method_34()
            {
                return (bool) base[this.vJ_OrderDataTable_0.registeredColumn];
            }

            public void method_35(bool bool_0)
            {
                base[this.vJ_OrderDataTable_0.registeredColumn] = bool_0;
            }

            public DateTime method_36()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_OrderDataTable_0.dateCloseColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateClose' in table 'vJ_Order' is DBNull.", exception);
                }
                return time;
            }

            public void method_37(DateTime dateTime_0)
            {
                base[this.vJ_OrderDataTable_0.dateCloseColumn] = dateTime_0;
            }

            public int method_38()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_OrderDataTable_0.closeWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'closeWorker' in table 'vJ_Order' is DBNull.", exception);
                }
                return num;
            }

            public void method_39(int int_0)
            {
                base[this.vJ_OrderDataTable_0.closeWorkerColumn] = int_0;
            }

            public decimal method_4()
            {
                decimal num;
                try
                {
                    num = (decimal) base[this.vJ_OrderDataTable_0.srNumColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'srNum' in table 'vJ_Order' is DBNull.", exception);
                }
                return num;
            }

            public string method_40()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderDataTable_0.closeFIOColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'closeFIO' in table 'vJ_Order' is DBNull.", exception);
                }
                return str;
            }

            public void method_41(string string_0)
            {
                base[this.vJ_OrderDataTable_0.closeFIOColumn] = string_0;
            }

            public DateTime method_42()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_OrderDataTable_0.beginResColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'beginRes' in table 'vJ_Order' is DBNull.", exception);
                }
                return time;
            }

            public void method_43(DateTime dateTime_0)
            {
                base[this.vJ_OrderDataTable_0.beginResColumn] = dateTime_0;
            }

            public DateTime method_44()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_OrderDataTable_0.EndResColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'EndRes' in table 'vJ_Order' is DBNull.", exception);
                }
                return time;
            }

            public void method_45(DateTime dateTime_0)
            {
                base[this.vJ_OrderDataTable_0.EndResColumn] = dateTime_0;
            }

            public int method_46()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_OrderDataTable_0.resWorkerIdColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'resWorkerId' in table 'vJ_Order' is DBNull.", exception);
                }
                return num;
            }

            public void method_47(int int_0)
            {
                base[this.vJ_OrderDataTable_0.resWorkerIdColumn] = int_0;
            }

            public string method_48()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderDataTable_0.resWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'resWorker' in table 'vJ_Order' is DBNull.", exception);
                }
                return str;
            }

            public void method_49(string string_0)
            {
                base[this.vJ_OrderDataTable_0.resWorkerColumn] = string_0;
            }

            public void method_5(decimal decimal_0)
            {
                base[this.vJ_OrderDataTable_0.srNumColumn] = decimal_0;
            }

            public string method_50()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderDataTable_0.OutputMakerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'OutputMaker' in table 'vJ_Order' is DBNull.", exception);
                }
                return str;
            }

            public void method_51(string string_0)
            {
                base[this.vJ_OrderDataTable_0.OutputMakerColumn] = string_0;
            }

            public string method_52()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderDataTable_0.ResolutionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Resolution' in table 'vJ_Order' is DBNull.", exception);
                }
                return str;
            }

            public void method_53(string string_0)
            {
                base[this.vJ_OrderDataTable_0.ResolutionColumn] = string_0;
            }

            public int method_54()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_OrderDataTable_0.extWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'extWorker' in table 'vJ_Order' is DBNull.", exception);
                }
                return num;
            }

            public void method_55(int int_0)
            {
                base[this.vJ_OrderDataTable_0.extWorkerColumn] = int_0;
            }

            public string method_56()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderDataTable_0.extFioColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'extFio' in table 'vJ_Order' is DBNull.", exception);
                }
                return str;
            }

            public void method_57(string string_0)
            {
                base[this.vJ_OrderDataTable_0.extFioColumn] = string_0;
            }

            public DateTime method_58()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_OrderDataTable_0.DateEndExtColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateEndExt' in table 'vJ_Order' is DBNull.", exception);
                }
                return time;
            }

            public void method_59(DateTime dateTime_0)
            {
                base[this.vJ_OrderDataTable_0.DateEndExtColumn] = dateTime_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderDataTable_0.srNameColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'srName' in table 'vJ_Order' is DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_60()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.srNumColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_61()
            {
                base[this.vJ_OrderDataTable_0.srNumColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_62()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.srNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_63()
            {
                base[this.vJ_OrderDataTable_0.srNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_64()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.headworkerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_65()
            {
                base[this.vJ_OrderDataTable_0.headworkerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_66()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.headFioColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_67()
            {
                base[this.vJ_OrderDataTable_0.headFioColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_68()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.acceptFIOColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_69()
            {
                base[this.vJ_OrderDataTable_0.acceptFIOColumn] = Convert.DBNull;
            }

            public void method_7(string string_0)
            {
                base[this.vJ_OrderDataTable_0.srNameColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_70()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.watchWorkerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_71()
            {
                base[this.vJ_OrderDataTable_0.watchWorkerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_72()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.watchFIOColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_73()
            {
                base[this.vJ_OrderDataTable_0.watchFIOColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_74()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.makerFIOColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_75()
            {
                base[this.vJ_OrderDataTable_0.makerFIOColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_76()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.otherInstructionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_77()
            {
                base[this.vJ_OrderDataTable_0.otherInstructionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_78()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.outputFIOColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_79()
            {
                base[this.vJ_OrderDataTable_0.outputFIOColumn] = Convert.DBNull;
            }

            public string method_8()
            {
                return (string) base[this.vJ_OrderDataTable_0.instructionColumn];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_80()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.dateCloseColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_81()
            {
                base[this.vJ_OrderDataTable_0.dateCloseColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_82()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.closeWorkerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_83()
            {
                base[this.vJ_OrderDataTable_0.closeWorkerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_84()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.closeFIOColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_85()
            {
                base[this.vJ_OrderDataTable_0.closeFIOColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_86()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.beginResColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_87()
            {
                base[this.vJ_OrderDataTable_0.beginResColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_88()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.EndResColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_89()
            {
                base[this.vJ_OrderDataTable_0.EndResColumn] = Convert.DBNull;
            }

            public void method_9(string string_0)
            {
                base[this.vJ_OrderDataTable_0.instructionColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_90()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.resWorkerIdColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_91()
            {
                base[this.vJ_OrderDataTable_0.resWorkerIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_92()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.resWorkerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_93()
            {
                base[this.vJ_OrderDataTable_0.resWorkerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_94()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.OutputMakerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_95()
            {
                base[this.vJ_OrderDataTable_0.OutputMakerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_96()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.ResolutionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_97()
            {
                base[this.vJ_OrderDataTable_0.ResolutionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_98()
            {
                return base.IsNull(this.vJ_OrderDataTable_0.extWorkerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_99()
            {
                base[this.vJ_OrderDataTable_0.extWorkerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime dateBegin
            {
                get
                {
                    return (DateTime) base[this.vJ_OrderDataTable_0.dateBeginColumn];
                }
                set
                {
                    base[this.vJ_OrderDataTable_0.dateBeginColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime dateEnd
            {
                get
                {
                    return (DateTime) base[this.vJ_OrderDataTable_0.dateEndColumn];
                }
                set
                {
                    base[this.vJ_OrderDataTable_0.dateEndColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vJ_OrderDataTable_0.idColumn];
                }
                set
                {
                    base[this.vJ_OrderDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class374 : DataRow
        {
            private DataSetOrder.tR_ClassifierDataTable tR_ClassifierDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class374(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tR_ClassifierDataTable_0 = (DataSetOrder.tR_ClassifierDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tR_ClassifierDataTable_0.ParentIdColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'ParentId' in table 'tR_Classifier' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tR_ClassifierDataTable_0.ParentIdColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.tR_ClassifierDataTable_0.ValueColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_11()
            {
                base[this.tR_ClassifierDataTable_0.ValueColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.tR_ClassifierDataTable_0.CommentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.tR_ClassifierDataTable_0.CommentColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_14()
            {
                return base.IsNull(this.tR_ClassifierDataTable_0.ParentIdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_15()
            {
                base[this.tR_ClassifierDataTable_0.ParentIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.tR_ClassifierDataTable_0.ParentKeyColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_17()
            {
                base[this.tR_ClassifierDataTable_0.ParentKeyColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.tR_ClassifierDataTable_0.OtherIdColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.tR_ClassifierDataTable_0.OtherIdColumn] = Convert.DBNull;
            }

            public byte[] method_2()
            {
                byte[] buffer;
                try
                {
                    buffer = (byte[]) base[this.tR_ClassifierDataTable_0.OtherIdColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'OtherId' in table 'tR_Classifier' is DBNull.", exception);
                }
                return buffer;
            }

            public void method_3(byte[] byte_0)
            {
                base[this.tR_ClassifierDataTable_0.OtherIdColumn] = byte_0;
            }

            public bool method_4()
            {
                return (bool) base[this.tR_ClassifierDataTable_0.IsGroupColumn];
            }

            public void method_5(bool bool_0)
            {
                base[this.tR_ClassifierDataTable_0.IsGroupColumn] = bool_0;
            }

            public bool method_6()
            {
                return (bool) base[this.tR_ClassifierDataTable_0.DeletedColumn];
            }

            public void method_7(bool bool_0)
            {
                base[this.tR_ClassifierDataTable_0.DeletedColumn] = bool_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.tR_ClassifierDataTable_0.SocrNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_9()
            {
                base[this.tR_ClassifierDataTable_0.SocrNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comment
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tR_ClassifierDataTable_0.CommentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Comment' in table 'tR_Classifier' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tR_ClassifierDataTable_0.CommentColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Id
            {
                get
                {
                    return (int) base[this.tR_ClassifierDataTable_0.IdColumn];
                }
                set
                {
                    base[this.tR_ClassifierDataTable_0.IdColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Name
            {
                get
                {
                    return (string) base[this.tR_ClassifierDataTable_0.NameColumn];
                }
                set
                {
                    base[this.tR_ClassifierDataTable_0.NameColumn] = value;
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
                        str = (string) base[this.tR_ClassifierDataTable_0.ParentKeyColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'ParentKey' in table 'tR_Classifier' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tR_ClassifierDataTable_0.ParentKeyColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string SocrName
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tR_ClassifierDataTable_0.SocrNameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'SocrName' in table 'tR_Classifier' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tR_ClassifierDataTable_0.SocrNameColumn] = value;
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
                        num = (decimal) base[this.tR_ClassifierDataTable_0.ValueColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Value' in table 'tR_Classifier' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tR_ClassifierDataTable_0.ValueColumn] = value;
                }
            }
        }

        public class Class375 : DataRow
        {
            private DataSetOrder.vR_WorkerDataTable vR_WorkerDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class375(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vR_WorkerDataTable_0 = (DataSetOrder.vR_WorkerDataTable) base.Table;
            }

            public DateTime method_0()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vR_WorkerDataTable_0.DateBeginColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateBegin' in table 'vR_Worker' is DBNull.", exception);
                }
                return time;
            }

            public void method_1(DateTime dateTime_0)
            {
                base[this.vR_WorkerDataTable_0.DateBeginColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.vR_WorkerDataTable_0.DateEndColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_11()
            {
                base[this.vR_WorkerDataTable_0.DateEndColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_12()
            {
                return base.IsNull(this.vR_WorkerDataTable_0.GroupElectricalColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_13()
            {
                base[this.vR_WorkerDataTable_0.GroupElectricalColumn] = Convert.DBNull;
            }

            public DateTime method_2()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vR_WorkerDataTable_0.DateEndColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateEnd' in table 'vR_Worker' is DBNull.", exception);
                }
                return time;
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.vR_WorkerDataTable_0.DateEndColumn] = dateTime_0;
            }

            public short method_4()
            {
                short num;
                try
                {
                    num = (short) base[this.vR_WorkerDataTable_0.GroupElectricalColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'GroupElectrical' in table 'vR_Worker' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(short short_0)
            {
                base[this.vR_WorkerDataTable_0.GroupElectricalColumn] = short_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_6()
            {
                return base.IsNull(this.vR_WorkerDataTable_0.FIOColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.vR_WorkerDataTable_0.FIOColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_8()
            {
                return base.IsNull(this.vR_WorkerDataTable_0.DateBeginColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.vR_WorkerDataTable_0.DateBeginColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FIO
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vR_WorkerDataTable_0.FIOColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'FIO' in table 'vR_Worker' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vR_WorkerDataTable_0.FIOColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vR_WorkerDataTable_0.idColumn];
                }
                set
                {
                    base[this.vR_WorkerDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class376 : DataRow
        {
            private DataSetOrder.vWorkerGroupDataTable vWorkerGroupDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class376(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vWorkerGroupDataTable_0 = (DataSetOrder.vWorkerGroupDataTable) base.Table;
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.vWorkerGroupDataTable_0.FIOColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.vWorkerGroupDataTable_0.DateEndColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.vWorkerGroupDataTable_0.DateEndColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_20()
            {
                return base.IsNull(this.vWorkerGroupDataTable_0.WorkerGroupColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_27()
            {
                base[this.vWorkerGroupDataTable_0.idDescriptionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

        public class Class377 : DataRow
        {
            private DataSetOrder.tJ_OrderBrigadeDataTable tJ_OrderBrigadeDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class377(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_OrderBrigadeDataTable_0 = (DataSetOrder.tJ_OrderBrigadeDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_OrderBrigadeDataTable_0.idOrderColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_OrderBrigadeDataTable_0.idOrderColumn] = int_0;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_OrderBrigadeDataTable_0.idJobTitleColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'idJobTitle' in table 'tJ_OrderBrigade' is DBNull.", exception);
                }
                return num;
            }

            public void method_3(int int_0)
            {
                base[this.tJ_OrderBrigadeDataTable_0.idJobTitleColumn] = int_0;
            }

            public bool method_4()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tJ_OrderBrigadeDataTable_0.isUnderstudyColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'isUnderstudy' in table 'tJ_OrderBrigade' is DBNull.", exception);
                }
                return flag;
            }

            public void method_5(bool bool_0)
            {
                base[this.tJ_OrderBrigadeDataTable_0.isUnderstudyColumn] = bool_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_6()
            {
                return base.IsNull(this.tJ_OrderBrigadeDataTable_0.idJobTitleColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.tJ_OrderBrigadeDataTable_0.idJobTitleColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_8()
            {
                return base.IsNull(this.tJ_OrderBrigadeDataTable_0.isUnderstudyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_9()
            {
                base[this.tJ_OrderBrigadeDataTable_0.isUnderstudyColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int idWorker
            {
                get
                {
                    return (int) base[this.tJ_OrderBrigadeDataTable_0.idWorkerColumn];
                }
                set
                {
                    base[this.tJ_OrderBrigadeDataTable_0.idWorkerColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_OrderBrigadeDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_OrderBrigadeDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class378 : DataRow
        {
            private DataSetOrder.tj_DailyTourReportDataTable tj_DailyTourReportDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class378(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tj_DailyTourReportDataTable_0 = (DataSetOrder.tj_DailyTourReportDataTable) base.Table;
            }

            public DateTime method_0()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tj_DailyTourReportDataTable_0.dateColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'date' in table 'tj_DailyTourReport' is DBNull.", exception);
                }
                return time;
            }

            public void method_1(DateTime dateTime_0)
            {
                base[this.tj_DailyTourReportDataTable_0.dateColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.tj_DailyTourReportDataTable_0.dateColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.tj_DailyTourReportDataTable_0.dateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_12()
            {
                return base.IsNull(this.tj_DailyTourReportDataTable_0.wasColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_13()
            {
                base[this.tj_DailyTourReportDataTable_0.wasColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_14()
            {
                return base.IsNull(this.tj_DailyTourReportDataTable_0.disp1Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_15()
            {
                base[this.tj_DailyTourReportDataTable_0.disp1Column] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.tj_DailyTourReportDataTable_0.disp2Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.tj_DailyTourReportDataTable_0.disp2Column] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.tj_DailyTourReportDataTable_0.disp3Column);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.tj_DailyTourReportDataTable_0.disp3Column] = Convert.DBNull;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tj_DailyTourReportDataTable_0.wasColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'was' in table 'tj_DailyTourReport' is DBNull.", exception);
                }
                return num;
            }

            public void method_3(int int_0)
            {
                base[this.tj_DailyTourReportDataTable_0.wasColumn] = int_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tj_DailyTourReportDataTable_0.disp1Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'disp1' in table 'tj_DailyTourReport' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.tj_DailyTourReportDataTable_0.disp1Column] = int_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tj_DailyTourReportDataTable_0.disp2Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'disp2' in table 'tj_DailyTourReport' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.tj_DailyTourReportDataTable_0.disp2Column] = int_0;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.tj_DailyTourReportDataTable_0.disp3Column];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'disp3' in table 'tj_DailyTourReport' is DBNull.", exception);
                }
                return num;
            }

            public void method_9(int int_0)
            {
                base[this.tj_DailyTourReportDataTable_0.disp3Column] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tj_DailyTourReportDataTable_0.idColumn];
                }
                set
                {
                    base[this.tj_DailyTourReportDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class379 : DataRow
        {
            private DataSetOrder.tJ_OrderInstructionDataTable tJ_OrderInstructionDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class379(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_OrderInstructionDataTable_0 = (DataSetOrder.tJ_OrderInstructionDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_OrderInstructionDataTable_0.idOrderColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_OrderInstructionDataTable_0.idOrderColumn] = int_0;
            }

            public string method_2()
            {
                return (string) base[this.tJ_OrderInstructionDataTable_0.NameObjColumn];
            }

            public void method_3(string string_0)
            {
                base[this.tJ_OrderInstructionDataTable_0.NameObjColumn] = string_0;
            }

            public string method_4()
            {
                return (string) base[this.tJ_OrderInstructionDataTable_0.InstructionColumn];
            }

            public void method_5(string string_0)
            {
                base[this.tJ_OrderInstructionDataTable_0.InstructionColumn] = string_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_OrderInstructionDataTable_0.rec_numColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'rec_num' in table 'tJ_OrderInstruction' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.tJ_OrderInstructionDataTable_0.rec_numColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.tJ_OrderInstructionDataTable_0.rec_numColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.tJ_OrderInstructionDataTable_0.rec_numColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_OrderInstructionDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_OrderInstructionDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class380 : DataRow
        {
            private DataSetOrder.tJ_OrderResolutionDataTable tJ_OrderResolutionDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class380(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_OrderResolutionDataTable_0 = (DataSetOrder.tJ_OrderResolutionDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tJ_OrderResolutionDataTable_0.idOrderColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tJ_OrderResolutionDataTable_0.idOrderColumn] = int_0;
            }

            public DateTime method_2()
            {
                return (DateTime) base[this.tJ_OrderResolutionDataTable_0.DateBeginColumn];
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.tJ_OrderResolutionDataTable_0.DateBeginColumn] = dateTime_0;
            }

            public DateTime method_4()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_OrderResolutionDataTable_0.DateEndColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DateEnd' in table 'tJ_OrderResolution' is DBNull.", exception);
                }
                return time;
            }

            public void method_5(DateTime dateTime_0)
            {
                base[this.tJ_OrderResolutionDataTable_0.DateEndColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_6()
            {
                return base.IsNull(this.tJ_OrderResolutionDataTable_0.DateEndColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.tJ_OrderResolutionDataTable_0.DateEndColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int idWorker
            {
                get
                {
                    return (int) base[this.tJ_OrderResolutionDataTable_0.idWorkerColumn];
                }
                set
                {
                    base[this.tJ_OrderResolutionDataTable_0.idWorkerColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_OrderResolutionDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_OrderResolutionDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class381 : DataRow
        {
            private DataSetOrder.vJ_OrderEventsDataTable vJ_OrderEventsDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class381(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vJ_OrderEventsDataTable_0 = (DataSetOrder.vJ_OrderEventsDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vJ_OrderEventsDataTable_0.numColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vJ_OrderEventsDataTable_0.numColumn] = int_0;
            }

            public string method_10()
            {
                return (string) base[this.vJ_OrderEventsDataTable_0.EvntColumn];
            }

            public void method_11(string string_0)
            {
                base[this.vJ_OrderEventsDataTable_0.EvntColumn] = string_0;
            }

            public DateTime method_12()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.vJ_OrderEventsDataTable_0.EvntDateColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'EvntDate' in table 'vJ_OrderEvents' is DBNull.", exception);
                }
                return time;
            }

            public void method_13(DateTime dateTime_0)
            {
                base[this.vJ_OrderEventsDataTable_0.EvntDateColumn] = dateTime_0;
            }

            public int method_14()
            {
                return (int) base[this.vJ_OrderEventsDataTable_0.closedColumn];
            }

            public void method_15(int int_0)
            {
                base[this.vJ_OrderEventsDataTable_0.closedColumn] = int_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderEventsDataTable_0.dispColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'disp' in table 'vJ_OrderEvents' is DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.vJ_OrderEventsDataTable_0.dispColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.vJ_OrderEventsDataTable_0.srNumColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.vJ_OrderEventsDataTable_0.srNumColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.vJ_OrderEventsDataTable_0.srNumColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'srNum' in table 'vJ_OrderEvents' is DBNull.", exception);
                }
                return num;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_20()
            {
                return base.IsNull(this.vJ_OrderEventsDataTable_0.acceptFIOColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_21()
            {
                base[this.vJ_OrderEventsDataTable_0.acceptFIOColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_22()
            {
                return base.IsNull(this.vJ_OrderEventsDataTable_0.makerFioColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_23()
            {
                base[this.vJ_OrderEventsDataTable_0.makerFioColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_24()
            {
                return base.IsNull(this.vJ_OrderEventsDataTable_0.EvntDateColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.vJ_OrderEventsDataTable_0.EvntDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_26()
            {
                return base.IsNull(this.vJ_OrderEventsDataTable_0.dispColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_27()
            {
                base[this.vJ_OrderEventsDataTable_0.dispColumn] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.vJ_OrderEventsDataTable_0.srNumColumn] = int_0;
            }

            public string method_4()
            {
                return (string) base[this.vJ_OrderEventsDataTable_0.instructionColumn];
            }

            public void method_5(string string_0)
            {
                base[this.vJ_OrderEventsDataTable_0.instructionColumn] = string_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderEventsDataTable_0.acceptFIOColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'acceptFIO' in table 'vJ_OrderEvents' is DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.vJ_OrderEventsDataTable_0.acceptFIOColumn] = string_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.vJ_OrderEventsDataTable_0.makerFioColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'makerFio' in table 'vJ_OrderEvents' is DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.vJ_OrderEventsDataTable_0.makerFioColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.vJ_OrderEventsDataTable_0.idColumn];
                }
                set
                {
                    base[this.vJ_OrderEventsDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class382 : DataRow
        {
            private DataSetOrder.tL_OrderSchmObjListDataTable tL_OrderSchmObjListDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class382(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tL_OrderSchmObjListDataTable_0 = (DataSetOrder.tL_OrderSchmObjListDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tL_OrderSchmObjListDataTable_0.idOrderColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tL_OrderSchmObjListDataTable_0.idOrderColumn] = int_0;
            }

            public int method_2()
            {
                return (int) base[this.tL_OrderSchmObjListDataTable_0.idSchmObjColumn];
            }

            public void method_3(int int_0)
            {
                base[this.tL_OrderSchmObjListDataTable_0.idSchmObjColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tL_OrderSchmObjListDataTable_0.idColumn];
                }
                set
                {
                    base[this.tL_OrderSchmObjListDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class383 : DataRow
        {
            private DataSetOrder.vSchm_ObjListDataTable vSchm_ObjListDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class383(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vSchm_ObjListDataTable_0 = (DataSetOrder.vSchm_ObjListDataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.vSchm_ObjListDataTable_0.typecodeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typecode' in table 'vSchm_ObjList' is DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.vSchm_ObjListDataTable_0.typecodeColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.vSchm_ObjListDataTable_0.NameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_11()
            {
                base[this.vSchm_ObjListDataTable_0.NameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_12()
            {
                return base.IsNull(this.vSchm_ObjListDataTable_0.TypeCodeIdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.vSchm_ObjListDataTable_0.TypeCodeIdColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.vSchm_ObjListDataTable_0.typecodeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.vSchm_ObjListDataTable_0.typecodeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.vSchm_ObjListDataTable_0.typeCodeSocrColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.vSchm_ObjListDataTable_0.typeCodeSocrColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.vSchm_ObjListDataTable_0.IdParentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.vSchm_ObjListDataTable_0.IdParentColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.vSchm_ObjListDataTable_0.typeCodeSocrColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'typeCodeSocr' in table 'vSchm_ObjList' is DBNull.", exception);
                }
                return str;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_20()
            {
                return base.IsNull(this.vSchm_ObjListDataTable_0.OnOffColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.vSchm_ObjListDataTable_0.OnOffColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_22()
            {
                return base.IsNull(this.vSchm_ObjListDataTable_0.NamePColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_23()
            {
                base[this.vSchm_ObjListDataTable_0.NamePColumn] = Convert.DBNull;
            }

            public void method_3(string string_0)
            {
                base[this.vSchm_ObjListDataTable_0.typeCodeSocrColumn] = string_0;
            }

            public bool method_4()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.vSchm_ObjListDataTable_0.OnOffColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'OnOff' in table 'vSchm_ObjList' is DBNull.", exception);
                }
                return flag;
            }

            public void method_5(bool bool_0)
            {
                base[this.vSchm_ObjListDataTable_0.OnOffColumn] = bool_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.vSchm_ObjListDataTable_0.NamePColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'NameP' in table 'vSchm_ObjList' is DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.vSchm_ObjListDataTable_0.NamePColumn] = int_0;
            }

            public bool method_8()
            {
                return (bool) base[this.vSchm_ObjListDataTable_0.DeletedColumn];
            }

            public void method_9(bool bool_0)
            {
                base[this.vSchm_ObjListDataTable_0.DeletedColumn] = bool_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Id
            {
                get
                {
                    return (int) base[this.vSchm_ObjListDataTable_0.IdColumn];
                }
                set
                {
                    base[this.vSchm_ObjListDataTable_0.IdColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int IdParent
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.vSchm_ObjListDataTable_0.IdParentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'IdParent' in table 'vSchm_ObjList' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vSchm_ObjListDataTable_0.IdParentColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Name
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vSchm_ObjListDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'vSchm_ObjList' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vSchm_ObjListDataTable_0.NameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int TypeCodeId
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.vSchm_ObjListDataTable_0.TypeCodeIdColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'TypeCodeId' in table 'vSchm_ObjList' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vSchm_ObjListDataTable_0.TypeCodeIdColumn] = value;
                }
            }
        }

        public class Class384 : DataRow
        {
            private DataSetOrder.vSchm_TreeCellLineDataTable vSchm_TreeCellLineDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class384(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vSchm_TreeCellLineDataTable_0 = (DataSetOrder.vSchm_TreeCellLineDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.vSchm_TreeCellLineDataTable_0.ParentLinkColumn];
            }

            public void method_1(int int_0)
            {
                base[this.vSchm_TreeCellLineDataTable_0.ParentLinkColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_2()
            {
                return base.IsNull(this.vSchm_TreeCellLineDataTable_0.TypeCodeIdColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_3()
            {
                base[this.vSchm_TreeCellLineDataTable_0.TypeCodeIdColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_4()
            {
                return base.IsNull(this.vSchm_TreeCellLineDataTable_0.ParentKeyColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5()
            {
                base[this.vSchm_TreeCellLineDataTable_0.ParentKeyColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_6()
            {
                return base.IsNull(this.vSchm_TreeCellLineDataTable_0.NameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.vSchm_TreeCellLineDataTable_0.NameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.vSchm_TreeCellLineDataTable_0.FullNameColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.vSchm_TreeCellLineDataTable_0.FullNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string FullName
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vSchm_TreeCellLineDataTable_0.FullNameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'FullName' in table 'vSchm_TreeCellLine' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vSchm_TreeCellLineDataTable_0.FullNameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Id
            {
                get
                {
                    return (int) base[this.vSchm_TreeCellLineDataTable_0.IdColumn];
                }
                set
                {
                    base[this.vSchm_TreeCellLineDataTable_0.IdColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Name
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vSchm_TreeCellLineDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'vSchm_TreeCellLine' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vSchm_TreeCellLineDataTable_0.NameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string ParentKey
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vSchm_TreeCellLineDataTable_0.ParentKeyColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'ParentKey' in table 'vSchm_TreeCellLine' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vSchm_TreeCellLineDataTable_0.ParentKeyColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int TypeCodeId
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.vSchm_TreeCellLineDataTable_0.TypeCodeIdColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'TypeCodeId' in table 'vSchm_TreeCellLine' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vSchm_TreeCellLineDataTable_0.TypeCodeIdColumn] = value;
                }
            }
        }

        public class Class385 : DataRow
        {
            private DataSetOrder.tSchm_RelationDataTable tSchm_RelationDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class385(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tSchm_RelationDataTable_0 = (DataSetOrder.tSchm_RelationDataTable) base.Table;
            }

            public int method_0()
            {
                return (int) base[this.tSchm_RelationDataTable_0.SourceObjColumn];
            }

            public void method_1(int int_0)
            {
                base[this.tSchm_RelationDataTable_0.SourceObjColumn] = int_0;
            }

            public int method_2()
            {
                return (int) base[this.tSchm_RelationDataTable_0.DestObjColumn];
            }

            public void method_3(int int_0)
            {
                base[this.tSchm_RelationDataTable_0.DestObjColumn] = int_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tSchm_RelationDataTable_0.EdgeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'Edge' in table 'tSchm_Relation' is DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.tSchm_RelationDataTable_0.EdgeColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_6()
            {
                return base.IsNull(this.tSchm_RelationDataTable_0.EdgeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_7()
            {
                base[this.tSchm_RelationDataTable_0.EdgeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tSchm_RelationDataTable_0.idColumn];
                }
                set
                {
                    base[this.tSchm_RelationDataTable_0.idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate223(object sender, DataSetOrder.EventArgs219 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate224(object sender, DataSetOrder.EventArgs220 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate225(object sender, DataSetOrder.EventArgs221 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate226(object sender, DataSetOrder.EventArgs222 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate227(object sender, DataSetOrder.EventArgs223 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate228(object sender, DataSetOrder.EventArgs224 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate229(object sender, DataSetOrder.EventArgs225 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate230(object sender, DataSetOrder.EventArgs226 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate231(object sender, DataSetOrder.EventArgs227 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate232(object sender, DataSetOrder.EventArgs228 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate233(object sender, DataSetOrder.EventArgs229 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate234(object sender, DataSetOrder.EventArgs230 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate235(object sender, DataSetOrder.EventArgs231 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate236(object sender, DataSetOrder.EventArgs232 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs219 : EventArgs
        {
            private DataSetOrder.Class372 class372_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs219(DataSetOrder.Class372 class372_1, DataRowAction dataRowAction_1)
            {
                this.class372_0 = class372_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class372 method_0()
            {
                return this.class372_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs220 : EventArgs
        {
            private DataSetOrder.Class373 class373_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs220(DataSetOrder.Class373 class373_1, DataRowAction dataRowAction_1)
            {
                this.class373_0 = class373_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class373 method_0()
            {
                return this.class373_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs221 : EventArgs
        {
            private DataSetOrder.Class374 class374_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs221(DataSetOrder.Class374 class374_1, DataRowAction dataRowAction_1)
            {
                this.class374_0 = class374_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class374 method_0()
            {
                return this.class374_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs222 : EventArgs
        {
            private DataSetOrder.Class375 class375_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs222(DataSetOrder.Class375 class375_1, DataRowAction dataRowAction_1)
            {
                this.class375_0 = class375_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class375 method_0()
            {
                return this.class375_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs223 : EventArgs
        {
            private DataSetOrder.Class376 class376_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs223(DataSetOrder.Class376 class376_1, DataRowAction dataRowAction_1)
            {
                this.class376_0 = class376_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class376 method_0()
            {
                return this.class376_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs224 : EventArgs
        {
            private DataSetOrder.Class377 class377_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs224(DataSetOrder.Class377 class377_1, DataRowAction dataRowAction_1)
            {
                this.class377_0 = class377_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class377 method_0()
            {
                return this.class377_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs225 : EventArgs
        {
            private DataSetOrder.Class378 class378_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs225(DataSetOrder.Class378 class378_1, DataRowAction dataRowAction_1)
            {
                this.class378_0 = class378_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class378 method_0()
            {
                return this.class378_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs226 : EventArgs
        {
            private DataSetOrder.Class379 class379_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs226(DataSetOrder.Class379 class379_1, DataRowAction dataRowAction_1)
            {
                this.class379_0 = class379_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class379 method_0()
            {
                return this.class379_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs227 : EventArgs
        {
            private DataSetOrder.Class380 class380_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs227(DataSetOrder.Class380 class380_1, DataRowAction dataRowAction_1)
            {
                this.class380_0 = class380_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class380 method_0()
            {
                return this.class380_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs228 : EventArgs
        {
            private DataSetOrder.Class381 class381_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs228(DataSetOrder.Class381 class381_1, DataRowAction dataRowAction_1)
            {
                this.class381_0 = class381_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class381 method_0()
            {
                return this.class381_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs229 : EventArgs
        {
            private DataSetOrder.Class382 class382_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs229(DataSetOrder.Class382 class382_1, DataRowAction dataRowAction_1)
            {
                this.class382_0 = class382_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class382 method_0()
            {
                return this.class382_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs230 : EventArgs
        {
            private DataSetOrder.Class383 class383_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs230(DataSetOrder.Class383 class383_1, DataRowAction dataRowAction_1)
            {
                this.class383_0 = class383_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class383 method_0()
            {
                return this.class383_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs231 : EventArgs
        {
            private DataSetOrder.Class384 class384_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs231(DataSetOrder.Class384 class384_1, DataRowAction dataRowAction_1)
            {
                this.class384_0 = class384_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class384 method_0()
            {
                return this.class384_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs232 : EventArgs
        {
            private DataSetOrder.Class385 class385_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs232(DataSetOrder.Class385 class385_1, DataRowAction dataRowAction_1)
            {
                this.class385_0 = class385_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetOrder.Class385 method_0()
            {
                return this.class385_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tj_DailyTourReportDataTable : TypedTableBase<DataSetOrder.Class378>
        {
            private DataColumn columndate;
            private DataColumn columndisp1;
            private DataColumn columndisp2;
            private DataColumn columndisp3;
            private DataColumn columnid;
            private DataColumn columnwas;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate229 tj_DailyTourReportRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate229 tj_DailyTourReportRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate229 tj_DailyTourReportRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate229 tj_DailyTourReportRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tj_DailyTourReportDataTable()
            {
                base.TableName = "tj_DailyTourReport";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tj_DailyTourReportDataTable(DataTable dataTable_0)
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
            protected tj_DailyTourReportDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetOrder.tj_DailyTourReportDataTable table1 = (DataSetOrder.tj_DailyTourReportDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.tj_DailyTourReportDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class378);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetOrder.Class378 class378_0)
            {
                base.Rows.Add(class378_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class378 method_1(DateTime dateTime_0, int int_0, int int_1, int int_2, int int_3)
            {
                DataSetOrder.Class378 row = (DataSetOrder.Class378) base.NewRow();
                object[] objArray1 = new object[6];
                objArray1[1] = dateTime_0;
                objArray1[2] = int_0;
                objArray1[3] = int_1;
                objArray1[4] = int_2;
                objArray1[5] = int_3;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class378 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetOrder.Class378) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columndate = base.Columns["date"];
                this.columnwas = base.Columns["was"];
                this.columndisp1 = base.Columns["disp1"];
                this.columndisp2 = base.Columns["disp2"];
                this.columndisp3 = base.Columns["disp3"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columndate = new DataColumn("date", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndate);
                this.columnwas = new DataColumn("was", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnwas);
                this.columndisp1 = new DataColumn("disp1", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columndisp1);
                this.columndisp2 = new DataColumn("disp2", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columndisp2);
                this.columndisp3 = new DataColumn("disp3", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columndisp3);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class378 method_5()
            {
                return (DataSetOrder.Class378) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetOrder.Class378 class378_0)
            {
                base.Rows.Remove(class378_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class378(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tj_DailyTourReportRowChanged != null)
                {
                    this.tj_DailyTourReportRowChanged(this, new DataSetOrder.EventArgs225((DataSetOrder.Class378) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tj_DailyTourReportRowChanging != null)
                {
                    this.tj_DailyTourReportRowChanging(this, new DataSetOrder.EventArgs225((DataSetOrder.Class378) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tj_DailyTourReportRowDeleted != null)
                {
                    this.tj_DailyTourReportRowDeleted(this, new DataSetOrder.EventArgs225((DataSetOrder.Class378) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tj_DailyTourReportRowDeleting != null)
                {
                    this.tj_DailyTourReportRowDeleting(this, new DataSetOrder.EventArgs225((DataSetOrder.Class378) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tj_DailyTourReportDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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
            public DataColumn dateColumn
            {
                get
                {
                    return this.columndate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn disp1Column
            {
                get
                {
                    return this.columndisp1;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn disp2Column
            {
                get
                {
                    return this.columndisp2;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn disp3Column
            {
                get
                {
                    return this.columndisp3;
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
            public DataSetOrder.Class378 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class378) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn wasColumn
            {
                get
                {
                    return this.columnwas;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_OrderBrigadeDataTable : TypedTableBase<DataSetOrder.Class377>
        {
            private DataColumn columnid;
            private DataColumn columnidJobTitle;
            private DataColumn columnidOrder;
            private DataColumn columnidWorker;
            private DataColumn columnisUnderstudy;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate228 tJ_OrderBrigadeRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate228 tJ_OrderBrigadeRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate228 tJ_OrderBrigadeRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate228 tJ_OrderBrigadeRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_OrderBrigadeDataTable()
            {
                base.TableName = "tJ_OrderBrigade";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_OrderBrigadeDataTable(DataTable dataTable_0)
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
            protected tJ_OrderBrigadeDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetOrder.tJ_OrderBrigadeDataTable table1 = (DataSetOrder.tJ_OrderBrigadeDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.tJ_OrderBrigadeDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class377);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetOrder.Class377 class377_0)
            {
                base.Rows.Add(class377_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class377 method_1(int int_0, int int_1, int int_2, bool bool_0)
            {
                DataSetOrder.Class377 row = (DataSetOrder.Class377) base.NewRow();
                object[] objArray1 = new object[5];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = int_2;
                objArray1[4] = bool_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class377 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetOrder.Class377) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidOrder = base.Columns["idOrder"];
                this.columnidWorker = base.Columns["idWorker"];
                this.columnidJobTitle = base.Columns["idJobTitle"];
                this.columnisUnderstudy = base.Columns["isUnderstudy"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidOrder = new DataColumn("idOrder", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidOrder);
                this.columnidWorker = new DataColumn("idWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidWorker);
                this.columnidJobTitle = new DataColumn("idJobTitle", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidJobTitle);
                this.columnisUnderstudy = new DataColumn("isUnderstudy", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisUnderstudy);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidOrder.AllowDBNull = false;
                this.columnidWorker.AllowDBNull = false;
                this.columnisUnderstudy.DefaultValue = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class377 method_5()
            {
                return (DataSetOrder.Class377) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetOrder.Class377 class377_0)
            {
                base.Rows.Remove(class377_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class377(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_OrderBrigadeRowChanged != null)
                {
                    this.tJ_OrderBrigadeRowChanged(this, new DataSetOrder.EventArgs224((DataSetOrder.Class377) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_OrderBrigadeRowChanging != null)
                {
                    this.tJ_OrderBrigadeRowChanging(this, new DataSetOrder.EventArgs224((DataSetOrder.Class377) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_OrderBrigadeRowDeleted != null)
                {
                    this.tJ_OrderBrigadeRowDeleted(this, new DataSetOrder.EventArgs224((DataSetOrder.Class377) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_OrderBrigadeRowDeleting != null)
                {
                    this.tJ_OrderBrigadeRowDeleting(this, new DataSetOrder.EventArgs224((DataSetOrder.Class377) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_OrderBrigadeDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idJobTitleColumn
            {
                get
                {
                    return this.columnidJobTitle;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idOrderColumn
            {
                get
                {
                    return this.columnidOrder;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idWorkerColumn
            {
                get
                {
                    return this.columnidWorker;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn isUnderstudyColumn
            {
                get
                {
                    return this.columnisUnderstudy;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class377 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class377) base.Rows[int_0];
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_OrderDataTable : TypedTableBase<DataSetOrder.Class372>
        {
            private DataColumn columnacceptworker;
            private DataColumn columncloseWorker;
            private DataColumn columndateBegin;
            private DataColumn columndateClose;
            private DataColumn columndateEnd;
            private DataColumn columndateEndExt;
            private DataColumn columndateExt;
            private DataColumn columndateOutput;
            private DataColumn columnextWorker;
            private DataColumn columnheadworker;
            private DataColumn columnid;
            private DataColumn columnidDivision;
            private DataColumn columnidSR;
            private DataColumn columninstruction;
            private DataColumn columnmakerWorker;
            private DataColumn columnnum;
            private DataColumn columnotherInstruction;
            private DataColumn columnoutputWorker;
            private DataColumn columnregistered;
            private DataColumn columnwatchWorker;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate223 tJ_OrderRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate223 tJ_OrderRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate223 tJ_OrderRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate223 tJ_OrderRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_OrderDataTable()
            {
                base.TableName = "tJ_Order";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tJ_OrderDataTable(DataTable dataTable_0)
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
            protected tJ_OrderDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetOrder.tJ_OrderDataTable table1 = (DataSetOrder.tJ_OrderDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.tJ_OrderDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class372);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetOrder.Class372 class372_0)
            {
                base.Rows.Add(class372_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class372 method_1(int int_0, DateTime dateTime_0, DateTime dateTime_1, int int_1, string string_0, int int_2, int int_3, int int_4, int int_5, string string_1, DateTime dateTime_2, int int_6, bool bool_0, DateTime dateTime_3, int int_7, int int_8, DateTime dateTime_4, DateTime dateTime_5, int int_9)
            {
                DataSetOrder.Class372 row = (DataSetOrder.Class372) base.NewRow();
                object[] objArray1 = new object[20];
                objArray1[1] = int_0;
                objArray1[2] = dateTime_0;
                objArray1[3] = dateTime_1;
                objArray1[4] = int_1;
                objArray1[5] = string_0;
                objArray1[6] = int_2;
                objArray1[7] = int_3;
                objArray1[8] = int_4;
                objArray1[9] = int_5;
                objArray1[10] = string_1;
                objArray1[11] = dateTime_2;
                objArray1[12] = int_6;
                objArray1[13] = bool_0;
                objArray1[14] = dateTime_3;
                objArray1[15] = int_7;
                objArray1[0x10] = int_8;
                objArray1[0x11] = dateTime_4;
                objArray1[0x12] = dateTime_5;
                objArray1[0x13] = int_9;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class372 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetOrder.Class372) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnnum = base.Columns["num"];
                this.columndateBegin = base.Columns["dateBegin"];
                this.columndateEnd = base.Columns["dateEnd"];
                this.columnidSR = base.Columns["idSR"];
                this.columninstruction = base.Columns["instruction"];
                this.columnheadworker = base.Columns["headworker"];
                this.columnacceptworker = base.Columns["acceptworker"];
                this.columnwatchWorker = base.Columns["watchWorker"];
                this.columnmakerWorker = base.Columns["makerWorker"];
                this.columnotherInstruction = base.Columns["otherInstruction"];
                this.columndateOutput = base.Columns["dateOutput"];
                this.columnoutputWorker = base.Columns["outputWorker"];
                this.columnregistered = base.Columns["registered"];
                this.columndateClose = base.Columns["dateClose"];
                this.columncloseWorker = base.Columns["closeWorker"];
                this.columnextWorker = base.Columns["extWorker"];
                this.columndateExt = base.Columns["dateExt"];
                this.columndateEndExt = base.Columns["dateEndExt"];
                this.columnidDivision = base.Columns["idDivision"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnnum = new DataColumn("num", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnum);
                this.columndateBegin = new DataColumn("dateBegin", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateBegin);
                this.columndateEnd = new DataColumn("dateEnd", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateEnd);
                this.columnidSR = new DataColumn("idSR", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSR);
                this.columninstruction = new DataColumn("instruction", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninstruction);
                this.columnheadworker = new DataColumn("headworker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnheadworker);
                this.columnacceptworker = new DataColumn("acceptworker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnacceptworker);
                this.columnwatchWorker = new DataColumn("watchWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnwatchWorker);
                this.columnmakerWorker = new DataColumn("makerWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmakerWorker);
                this.columnotherInstruction = new DataColumn("otherInstruction", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnotherInstruction);
                this.columndateOutput = new DataColumn("dateOutput", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateOutput);
                this.columnoutputWorker = new DataColumn("outputWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnoutputWorker);
                this.columnregistered = new DataColumn("registered", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnregistered);
                this.columndateClose = new DataColumn("dateClose", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateClose);
                this.columncloseWorker = new DataColumn("closeWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columncloseWorker);
                this.columnextWorker = new DataColumn("extWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnextWorker);
                this.columndateExt = new DataColumn("dateExt", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateExt);
                this.columndateEndExt = new DataColumn("dateEndExt", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateEndExt);
                this.columnidDivision = new DataColumn("idDivision", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidDivision);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnnum.AllowDBNull = false;
                this.columndateBegin.AllowDBNull = false;
                this.columndateEnd.AllowDBNull = false;
                this.columnidSR.AllowDBNull = false;
                this.columninstruction.AllowDBNull = false;
                this.columninstruction.MaxLength = 500;
                this.columnacceptworker.AllowDBNull = false;
                this.columnmakerWorker.AllowDBNull = false;
                this.columndateOutput.AllowDBNull = false;
                this.columnoutputWorker.AllowDBNull = false;
                this.columnregistered.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class372 method_5()
            {
                return (DataSetOrder.Class372) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetOrder.Class372 class372_0)
            {
                base.Rows.Remove(class372_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class372(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_OrderRowChanged != null)
                {
                    this.tJ_OrderRowChanged(this, new DataSetOrder.EventArgs219((DataSetOrder.Class372) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_OrderRowChanging != null)
                {
                    this.tJ_OrderRowChanging(this, new DataSetOrder.EventArgs219((DataSetOrder.Class372) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_OrderRowDeleted != null)
                {
                    this.tJ_OrderRowDeleted(this, new DataSetOrder.EventArgs219((DataSetOrder.Class372) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_OrderRowDeleting != null)
                {
                    this.tJ_OrderRowDeleting(this, new DataSetOrder.EventArgs219((DataSetOrder.Class372) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_OrderDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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
            public DataColumn acceptworkerColumn
            {
                get
                {
                    return this.columnacceptworker;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn closeWorkerColumn
            {
                get
                {
                    return this.columncloseWorker;
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
            public DataColumn dateBeginColumn
            {
                get
                {
                    return this.columndateBegin;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateCloseColumn
            {
                get
                {
                    return this.columndateClose;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateEndColumn
            {
                get
                {
                    return this.columndateEnd;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateEndExtColumn
            {
                get
                {
                    return this.columndateEndExt;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateExtColumn
            {
                get
                {
                    return this.columndateExt;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateOutputColumn
            {
                get
                {
                    return this.columndateOutput;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn extWorkerColumn
            {
                get
                {
                    return this.columnextWorker;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn headworkerColumn
            {
                get
                {
                    return this.columnheadworker;
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
            public DataColumn idDivisionColumn
            {
                get
                {
                    return this.columnidDivision;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idSRColumn
            {
                get
                {
                    return this.columnidSR;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn instructionColumn
            {
                get
                {
                    return this.columninstruction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class372 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class372) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn makerWorkerColumn
            {
                get
                {
                    return this.columnmakerWorker;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn numColumn
            {
                get
                {
                    return this.columnnum;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn otherInstructionColumn
            {
                get
                {
                    return this.columnotherInstruction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn outputWorkerColumn
            {
                get
                {
                    return this.columnoutputWorker;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn registeredColumn
            {
                get
                {
                    return this.columnregistered;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn watchWorkerColumn
            {
                get
                {
                    return this.columnwatchWorker;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_OrderInstructionDataTable : TypedTableBase<DataSetOrder.Class379>
        {
            private DataColumn columnid;
            private DataColumn columnidOrder;
            private DataColumn columnInstruction;
            private DataColumn columnNameObj;
            private DataColumn columnrec_num;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate230 tJ_OrderInstructionRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate230 tJ_OrderInstructionRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate230 tJ_OrderInstructionRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate230 tJ_OrderInstructionRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_OrderInstructionDataTable()
            {
                base.TableName = "tJ_OrderInstruction";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tJ_OrderInstructionDataTable(DataTable dataTable_0)
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
            protected tJ_OrderInstructionDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetOrder.tJ_OrderInstructionDataTable table1 = (DataSetOrder.tJ_OrderInstructionDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.tJ_OrderInstructionDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class379);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetOrder.Class379 class379_0)
            {
                base.Rows.Add(class379_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class379 method_1(int int_0, string string_0, string string_1, int int_1)
            {
                DataSetOrder.Class379 row = (DataSetOrder.Class379) base.NewRow();
                object[] objArray1 = new object[5];
                objArray1[1] = int_0;
                objArray1[2] = string_0;
                objArray1[3] = string_1;
                objArray1[4] = int_1;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class379 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetOrder.Class379) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidOrder = base.Columns["idOrder"];
                this.columnNameObj = base.Columns["NameObj"];
                this.columnInstruction = base.Columns["Instruction"];
                this.columnrec_num = base.Columns["rec_num"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidOrder = new DataColumn("idOrder", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidOrder);
                this.columnNameObj = new DataColumn("NameObj", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNameObj);
                this.columnInstruction = new DataColumn("Instruction", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnInstruction);
                this.columnrec_num = new DataColumn("rec_num", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnrec_num);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidOrder.AllowDBNull = false;
                this.columnNameObj.AllowDBNull = false;
                this.columnNameObj.MaxLength = 350;
                this.columnInstruction.AllowDBNull = false;
                this.columnInstruction.MaxLength = 350;
                this.columnrec_num.AutoIncrementSeed = 1L;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class379 method_5()
            {
                return (DataSetOrder.Class379) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetOrder.Class379 class379_0)
            {
                base.Rows.Remove(class379_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class379(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_OrderInstructionRowChanged != null)
                {
                    this.tJ_OrderInstructionRowChanged(this, new DataSetOrder.EventArgs226((DataSetOrder.Class379) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_OrderInstructionRowChanging != null)
                {
                    this.tJ_OrderInstructionRowChanging(this, new DataSetOrder.EventArgs226((DataSetOrder.Class379) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_OrderInstructionRowDeleted != null)
                {
                    this.tJ_OrderInstructionRowDeleted(this, new DataSetOrder.EventArgs226((DataSetOrder.Class379) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_OrderInstructionRowDeleting != null)
                {
                    this.tJ_OrderInstructionRowDeleting(this, new DataSetOrder.EventArgs226((DataSetOrder.Class379) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_OrderInstructionDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
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
            public DataColumn idOrderColumn
            {
                get
                {
                    return this.columnidOrder;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn InstructionColumn
            {
                get
                {
                    return this.columnInstruction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class379 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class379) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NameObjColumn
            {
                get
                {
                    return this.columnNameObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn rec_numColumn
            {
                get
                {
                    return this.columnrec_num;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_OrderResolutionDataTable : TypedTableBase<DataSetOrder.Class380>
        {
            private DataColumn columnDateBegin;
            private DataColumn columnDateEnd;
            private DataColumn columnid;
            private DataColumn columnidOrder;
            private DataColumn columnidWorker;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate231 tJ_OrderResolutionRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate231 tJ_OrderResolutionRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate231 tJ_OrderResolutionRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate231 tJ_OrderResolutionRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_OrderResolutionDataTable()
            {
                base.TableName = "tJ_OrderResolution";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tJ_OrderResolutionDataTable(DataTable dataTable_0)
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
            protected tJ_OrderResolutionDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetOrder.tJ_OrderResolutionDataTable table1 = (DataSetOrder.tJ_OrderResolutionDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.tJ_OrderResolutionDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class380);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetOrder.Class380 class380_0)
            {
                base.Rows.Add(class380_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class380 method_1(int int_0, int int_1, DateTime dateTime_0, DateTime dateTime_1)
            {
                DataSetOrder.Class380 row = (DataSetOrder.Class380) base.NewRow();
                object[] objArray1 = new object[5];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = dateTime_0;
                objArray1[4] = dateTime_1;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class380 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetOrder.Class380) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidOrder = base.Columns["idOrder"];
                this.columnidWorker = base.Columns["idWorker"];
                this.columnDateBegin = base.Columns["DateBegin"];
                this.columnDateEnd = base.Columns["DateEnd"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidOrder = new DataColumn("idOrder", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidOrder);
                this.columnidWorker = new DataColumn("idWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidWorker);
                this.columnDateBegin = new DataColumn("DateBegin", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateBegin);
                this.columnDateEnd = new DataColumn("DateEnd", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateEnd);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidOrder.AllowDBNull = false;
                this.columnidWorker.AllowDBNull = false;
                this.columnDateBegin.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class380 method_5()
            {
                return (DataSetOrder.Class380) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetOrder.Class380 class380_0)
            {
                base.Rows.Remove(class380_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class380(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_OrderResolutionRowChanged != null)
                {
                    this.tJ_OrderResolutionRowChanged(this, new DataSetOrder.EventArgs227((DataSetOrder.Class380) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_OrderResolutionRowChanging != null)
                {
                    this.tJ_OrderResolutionRowChanging(this, new DataSetOrder.EventArgs227((DataSetOrder.Class380) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_OrderResolutionRowDeleted != null)
                {
                    this.tJ_OrderResolutionRowDeleted(this, new DataSetOrder.EventArgs227((DataSetOrder.Class380) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_OrderResolutionRowDeleting != null)
                {
                    this.tJ_OrderResolutionRowDeleting(this, new DataSetOrder.EventArgs227((DataSetOrder.Class380) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_OrderResolutionDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idOrderColumn
            {
                get
                {
                    return this.columnidOrder;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idWorkerColumn
            {
                get
                {
                    return this.columnidWorker;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class380 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class380) base.Rows[int_0];
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tL_OrderSchmObjListDataTable : TypedTableBase<DataSetOrder.Class382>
        {
            private DataColumn columnid;
            private DataColumn columnidOrder;
            private DataColumn columnidSchmObj;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate233 tL_OrderSchmObjListRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate233 tL_OrderSchmObjListRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate233 tL_OrderSchmObjListRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate233 tL_OrderSchmObjListRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tL_OrderSchmObjListDataTable()
            {
                base.TableName = "tL_OrderSchmObjList";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tL_OrderSchmObjListDataTable(DataTable dataTable_0)
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
            protected tL_OrderSchmObjListDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetOrder.tL_OrderSchmObjListDataTable table1 = (DataSetOrder.tL_OrderSchmObjListDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.tL_OrderSchmObjListDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class382);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetOrder.Class382 class382_0)
            {
                base.Rows.Add(class382_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class382 method_1(int int_0, int int_1)
            {
                DataSetOrder.Class382 row = (DataSetOrder.Class382) base.NewRow();
                object[] objArray1 = new object[3];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class382 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetOrder.Class382) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnidOrder = base.Columns["idOrder"];
                this.columnidSchmObj = base.Columns["idSchmObj"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidOrder = new DataColumn("idOrder", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidOrder);
                this.columnidSchmObj = new DataColumn("idSchmObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSchmObj);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidOrder.AllowDBNull = false;
                this.columnidSchmObj.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class382 method_5()
            {
                return (DataSetOrder.Class382) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetOrder.Class382 class382_0)
            {
                base.Rows.Remove(class382_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class382(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tL_OrderSchmObjListRowChanged != null)
                {
                    this.tL_OrderSchmObjListRowChanged(this, new DataSetOrder.EventArgs229((DataSetOrder.Class382) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tL_OrderSchmObjListRowChanging != null)
                {
                    this.tL_OrderSchmObjListRowChanging(this, new DataSetOrder.EventArgs229((DataSetOrder.Class382) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tL_OrderSchmObjListRowDeleted != null)
                {
                    this.tL_OrderSchmObjListRowDeleted(this, new DataSetOrder.EventArgs229((DataSetOrder.Class382) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tL_OrderSchmObjListRowDeleting != null)
                {
                    this.tL_OrderSchmObjListRowDeleting(this, new DataSetOrder.EventArgs229((DataSetOrder.Class382) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tL_OrderSchmObjListDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
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
            public DataColumn idOrderColumn
            {
                get
                {
                    return this.columnidOrder;
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class382 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class382) base.Rows[int_0];
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tR_ClassifierDataTable : TypedTableBase<DataSetOrder.Class374>
        {
            private DataColumn columnComment;
            private DataColumn columnDeleted;
            private DataColumn columnId;
            private DataColumn columnIsGroup;
            private DataColumn columnName;
            private DataColumn columnOtherId;
            private DataColumn columnParentId;
            private DataColumn columnParentKey;
            private DataColumn columnSocrName;
            private DataColumn columnValue;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate225 tR_ClassifierRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate225 tR_ClassifierRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate225 tR_ClassifierRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate225 tR_ClassifierRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tR_ClassifierDataTable()
            {
                base.TableName = "tR_Classifier";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected tR_ClassifierDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetOrder.tR_ClassifierDataTable table1 = (DataSetOrder.tR_ClassifierDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.tR_ClassifierDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class374);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetOrder.Class374 class374_0)
            {
                base.Rows.Add(class374_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class374 method_1(string string_0, string string_1, decimal decimal_0, string string_2, int int_0, string string_3, byte[] byte_0, bool bool_0, bool bool_1)
            {
                DataSetOrder.Class374 row = (DataSetOrder.Class374) base.NewRow();
                object[] objArray1 = new object[10];
                objArray1[1] = string_0;
                objArray1[2] = string_1;
                objArray1[3] = decimal_0;
                objArray1[4] = string_2;
                objArray1[5] = int_0;
                objArray1[6] = string_3;
                objArray1[7] = byte_0;
                objArray1[8] = bool_0;
                objArray1[9] = bool_1;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class374 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetOrder.Class374) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
                DataColumn[] columns = new DataColumn[] { this.columnId };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnId.AutoIncrement = true;
                this.columnId.AutoIncrementSeed = -1L;
                this.columnId.AutoIncrementStep = -1L;
                this.columnId.AllowDBNull = false;
                this.columnId.ReadOnly = true;
                this.columnId.Unique = true;
                this.columnName.AllowDBNull = false;
                this.columnName.MaxLength = 100;
                this.columnSocrName.MaxLength = 50;
                this.columnComment.MaxLength = 0x400;
                this.columnParentKey.MaxLength = 50;
                this.columnIsGroup.AllowDBNull = false;
                this.columnDeleted.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class374 method_5()
            {
                return (DataSetOrder.Class374) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetOrder.Class374 class374_0)
            {
                base.Rows.Remove(class374_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class374(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tR_ClassifierRowChanged != null)
                {
                    this.tR_ClassifierRowChanged(this, new DataSetOrder.EventArgs221((DataSetOrder.Class374) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tR_ClassifierRowChanging != null)
                {
                    this.tR_ClassifierRowChanging(this, new DataSetOrder.EventArgs221((DataSetOrder.Class374) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tR_ClassifierRowDeleted != null)
                {
                    this.tR_ClassifierRowDeleted(this, new DataSetOrder.EventArgs221((DataSetOrder.Class374) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tR_ClassifierRowDeleting != null)
                {
                    this.tR_ClassifierRowDeleting(this, new DataSetOrder.EventArgs221((DataSetOrder.Class374) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tR_ClassifierDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DeletedColumn
            {
                get
                {
                    return this.columnDeleted;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IdColumn
            {
                get
                {
                    return this.columnId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IsGroupColumn
            {
                get
                {
                    return this.columnIsGroup;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class374 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class374) base.Rows[int_0];
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn OtherIdColumn
            {
                get
                {
                    return this.columnOtherId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ParentIdColumn
            {
                get
                {
                    return this.columnParentId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ParentKeyColumn
            {
                get
                {
                    return this.columnParentKey;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SocrNameColumn
            {
                get
                {
                    return this.columnSocrName;
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
        public class tSchm_RelationDataTable : TypedTableBase<DataSetOrder.Class385>
        {
            private DataColumn columnDestObj;
            private DataColumn columnEdge;
            private DataColumn columnid;
            private DataColumn columnSourceObj;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate236 tSchm_RelationRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate236 tSchm_RelationRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate236 tSchm_RelationRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate236 tSchm_RelationRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tSchm_RelationDataTable()
            {
                base.TableName = "tSchm_Relation";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected tSchm_RelationDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetOrder.tSchm_RelationDataTable table1 = (DataSetOrder.tSchm_RelationDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.tSchm_RelationDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class385);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetOrder.Class385 class385_0)
            {
                base.Rows.Add(class385_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class385 method_1(int int_0, int int_1, int int_2)
            {
                DataSetOrder.Class385 row = (DataSetOrder.Class385) base.NewRow();
                object[] objArray1 = new object[4];
                objArray1[1] = int_0;
                objArray1[2] = int_1;
                objArray1[3] = int_2;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class385 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetOrder.Class385) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnSourceObj = base.Columns["SourceObj"];
                this.columnDestObj = base.Columns["DestObj"];
                this.columnEdge = base.Columns["Edge"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnSourceObj.AllowDBNull = false;
                this.columnDestObj.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class385 method_5()
            {
                return (DataSetOrder.Class385) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetOrder.Class385 class385_0)
            {
                base.Rows.Remove(class385_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class385(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tSchm_RelationRowChanged != null)
                {
                    this.tSchm_RelationRowChanged(this, new DataSetOrder.EventArgs232((DataSetOrder.Class385) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tSchm_RelationRowChanging != null)
                {
                    this.tSchm_RelationRowChanging(this, new DataSetOrder.EventArgs232((DataSetOrder.Class385) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tSchm_RelationRowDeleted != null)
                {
                    this.tSchm_RelationRowDeleted(this, new DataSetOrder.EventArgs232((DataSetOrder.Class385) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tSchm_RelationRowDeleting != null)
                {
                    this.tSchm_RelationRowDeleting(this, new DataSetOrder.EventArgs232((DataSetOrder.Class385) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tSchm_RelationDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DestObjColumn
            {
                get
                {
                    return this.columnDestObj;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn EdgeColumn
            {
                get
                {
                    return this.columnEdge;
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
            public DataSetOrder.Class385 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class385) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn SourceObjColumn
            {
                get
                {
                    return this.columnSourceObj;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vJ_OrderDataTable : TypedTableBase<DataSetOrder.Class373>
        {
            private DataColumn columnacceptFIO;
            private DataColumn columnacceptworker;
            private DataColumn columnbeginRes;
            private DataColumn columncloseFIO;
            private DataColumn columncloseWorker;
            private DataColumn columndateBegin;
            private DataColumn columndateClose;
            private DataColumn columndateEnd;
            private DataColumn columnDateEndExt;
            private DataColumn columndateOutput;
            private DataColumn columnEndRes;
            private DataColumn columnextFio;
            private DataColumn columnextWorker;
            private DataColumn columnheadFio;
            private DataColumn columnheadworker;
            private DataColumn columnid;
            private DataColumn columnidSR;
            private DataColumn columninstruction;
            private DataColumn columnmakerFIO;
            private DataColumn columnmakerWorker;
            private DataColumn columnnum;
            private DataColumn columnotherInstruction;
            private DataColumn columnoutputFIO;
            private DataColumn columnOutputMaker;
            private DataColumn columnoutputWorker;
            private DataColumn columnregistered;
            private DataColumn columnResolution;
            private DataColumn columnresWorker;
            private DataColumn columnresWorkerId;
            private DataColumn columnsrName;
            private DataColumn columnsrNum;
            private DataColumn columnwatchFIO;
            private DataColumn columnwatchWorker;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate224 vJ_OrderRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate224 vJ_OrderRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate224 vJ_OrderRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate224 vJ_OrderRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vJ_OrderDataTable() : this(false)
            {
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vJ_OrderDataTable(bool bool_0)
            {
                base.TableName = "vJ_Order";
                this.BeginInit();
                this.method_5();
                if (bool_0)
                {
                    this.method_7();
                }
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal vJ_OrderDataTable(DataTable dataTable_0)
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
            protected vJ_OrderDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_4();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetOrder.vJ_OrderDataTable table1 = (DataSetOrder.vJ_OrderDataTable) base.Clone();
                table1.method_4();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.vJ_OrderDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class373);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetOrder.Class373 class373_0)
            {
                base.Rows.Add(class373_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class373 method_1(int int_0, int int_1, DateTime dateTime_0, DateTime dateTime_1, int int_2, decimal decimal_0, string string_0, string string_1, int int_3, string string_2, int int_4, string string_3, int int_5, string string_4, int int_6, string string_5, string string_6, DateTime dateTime_2, int int_7, string string_7, bool bool_0, DateTime dateTime_3, int int_8, string string_8, DateTime dateTime_4, DateTime dateTime_5, int int_9, string string_9, string string_10, string string_11, int int_10, string string_12, DateTime dateTime_6)
            {
                DataSetOrder.Class373 row = (DataSetOrder.Class373) base.NewRow();
                object[] objArray = new object[] { 
                    int_0, int_1, dateTime_0, dateTime_1, int_2, decimal_0, string_0, string_1, int_3, string_2, int_4, string_3, int_5, string_4, int_6, string_5,
                    string_6, dateTime_2, int_7, string_7, bool_0, dateTime_3, int_8, string_8, dateTime_4, dateTime_5, int_9, string_9, string_10, string_11, int_10, string_12,
                    dateTime_6
                };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class373 method_2(int int_0, int int_1, DateTime dateTime_0, DateTime dateTime_1, int int_2, decimal decimal_0, string string_0, string string_1, int int_3, string string_2, int int_4, string string_3, int int_5, string string_4, int int_6, string string_5, string string_6, DateTime dateTime_2, int int_7, string string_7, bool bool_0, DateTime dateTime_3, int int_8, string string_8, DateTime dateTime_4, DateTime dateTime_5, int int_9, string string_9, int int_10, string string_10, DateTime dateTime_6)
            {
                DataSetOrder.Class373 row = (DataSetOrder.Class373) base.NewRow();
                object[] objArray1 = new object[0x21];
                objArray1[0] = int_0;
                objArray1[1] = int_1;
                objArray1[2] = dateTime_0;
                objArray1[3] = dateTime_1;
                objArray1[4] = int_2;
                objArray1[5] = decimal_0;
                objArray1[6] = string_0;
                objArray1[7] = string_1;
                objArray1[8] = int_3;
                objArray1[9] = string_2;
                objArray1[10] = int_4;
                objArray1[11] = string_3;
                objArray1[12] = int_5;
                objArray1[13] = string_4;
                objArray1[14] = int_6;
                objArray1[15] = string_5;
                objArray1[0x10] = string_6;
                objArray1[0x11] = dateTime_2;
                objArray1[0x12] = int_7;
                objArray1[0x13] = string_7;
                objArray1[20] = bool_0;
                objArray1[0x15] = dateTime_3;
                objArray1[0x16] = int_8;
                objArray1[0x17] = string_8;
                objArray1[0x18] = dateTime_4;
                objArray1[0x19] = dateTime_5;
                objArray1[0x1a] = int_9;
                objArray1[0x1b] = string_9;
                objArray1[30] = int_10;
                objArray1[0x1f] = string_10;
                objArray1[0x20] = dateTime_6;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class373 method_3(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetOrder.Class373) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_4()
            {
                this.columnid = base.Columns["id"];
                this.columnnum = base.Columns["num"];
                this.columndateBegin = base.Columns["dateBegin"];
                this.columndateEnd = base.Columns["dateEnd"];
                this.columnidSR = base.Columns["idSR"];
                this.columnsrNum = base.Columns["srNum"];
                this.columnsrName = base.Columns["srName"];
                this.columninstruction = base.Columns["instruction"];
                this.columnheadworker = base.Columns["headworker"];
                this.columnheadFio = base.Columns["headFio"];
                this.columnacceptworker = base.Columns["acceptworker"];
                this.columnacceptFIO = base.Columns["acceptFIO"];
                this.columnwatchWorker = base.Columns["watchWorker"];
                this.columnwatchFIO = base.Columns["watchFIO"];
                this.columnmakerWorker = base.Columns["makerWorker"];
                this.columnmakerFIO = base.Columns["makerFIO"];
                this.columnotherInstruction = base.Columns["otherInstruction"];
                this.columndateOutput = base.Columns["dateOutput"];
                this.columnoutputWorker = base.Columns["outputWorker"];
                this.columnoutputFIO = base.Columns["outputFIO"];
                this.columnregistered = base.Columns["registered"];
                this.columndateClose = base.Columns["dateClose"];
                this.columncloseWorker = base.Columns["closeWorker"];
                this.columncloseFIO = base.Columns["closeFIO"];
                this.columnbeginRes = base.Columns["beginRes"];
                this.columnEndRes = base.Columns["EndRes"];
                this.columnresWorkerId = base.Columns["resWorkerId"];
                this.columnresWorker = base.Columns["resWorker"];
                this.columnOutputMaker = base.Columns["OutputMaker"];
                this.columnResolution = base.Columns["Resolution"];
                this.columnextWorker = base.Columns["extWorker"];
                this.columnextFio = base.Columns["extFio"];
                this.columnDateEndExt = base.Columns["DateEndExt"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_5()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnnum = new DataColumn("num", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnum);
                this.columndateBegin = new DataColumn("dateBegin", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateBegin);
                this.columndateEnd = new DataColumn("dateEnd", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateEnd);
                this.columnidSR = new DataColumn("idSR", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidSR);
                this.columnsrNum = new DataColumn("srNum", typeof(decimal), null, MappingType.Element);
                base.Columns.Add(this.columnsrNum);
                this.columnsrName = new DataColumn("srName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnsrName);
                this.columninstruction = new DataColumn("instruction", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninstruction);
                this.columnheadworker = new DataColumn("headworker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnheadworker);
                this.columnheadFio = new DataColumn("headFio", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnheadFio);
                this.columnacceptworker = new DataColumn("acceptworker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnacceptworker);
                this.columnacceptFIO = new DataColumn("acceptFIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnacceptFIO);
                this.columnwatchWorker = new DataColumn("watchWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnwatchWorker);
                this.columnwatchFIO = new DataColumn("watchFIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnwatchFIO);
                this.columnmakerWorker = new DataColumn("makerWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnmakerWorker);
                this.columnmakerFIO = new DataColumn("makerFIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnmakerFIO);
                this.columnotherInstruction = new DataColumn("otherInstruction", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnotherInstruction);
                this.columndateOutput = new DataColumn("dateOutput", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateOutput);
                this.columnoutputWorker = new DataColumn("outputWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnoutputWorker);
                this.columnoutputFIO = new DataColumn("outputFIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnoutputFIO);
                this.columnregistered = new DataColumn("registered", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnregistered);
                this.columndateClose = new DataColumn("dateClose", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateClose);
                this.columncloseWorker = new DataColumn("closeWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columncloseWorker);
                this.columncloseFIO = new DataColumn("closeFIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columncloseFIO);
                this.columnbeginRes = new DataColumn("beginRes", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnbeginRes);
                this.columnEndRes = new DataColumn("EndRes", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnEndRes);
                this.columnresWorkerId = new DataColumn("resWorkerId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnresWorkerId);
                this.columnresWorker = new DataColumn("resWorker", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnresWorker);
                this.columnOutputMaker = new DataColumn("OutputMaker", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnOutputMaker);
                this.columnResolution = new DataColumn("Resolution", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnResolution);
                this.columnextWorker = new DataColumn("extWorker", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnextWorker);
                this.columnextFio = new DataColumn("extFio", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnextFio);
                this.columnDateEndExt = new DataColumn("DateEndExt", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateEndExt);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnnum.AllowDBNull = false;
                this.columndateBegin.AllowDBNull = false;
                this.columndateEnd.AllowDBNull = false;
                this.columnidSR.AllowDBNull = false;
                this.columnsrName.MaxLength = 100;
                this.columninstruction.AllowDBNull = false;
                this.columninstruction.MaxLength = 500;
                this.columnheadFio.ReadOnly = true;
                this.columnheadFio.MaxLength = 0x23;
                this.columnacceptworker.AllowDBNull = false;
                this.columnacceptFIO.ReadOnly = true;
                this.columnacceptFIO.MaxLength = 0x23;
                this.columnwatchFIO.ReadOnly = true;
                this.columnwatchFIO.MaxLength = 0x23;
                this.columnmakerWorker.AllowDBNull = false;
                this.columnmakerFIO.ReadOnly = true;
                this.columnmakerFIO.MaxLength = 0x23;
                this.columndateOutput.AllowDBNull = false;
                this.columnoutputWorker.AllowDBNull = false;
                this.columnoutputFIO.ReadOnly = true;
                this.columnoutputFIO.MaxLength = 0x23;
                this.columnregistered.AllowDBNull = false;
                this.columncloseFIO.ReadOnly = true;
                this.columncloseFIO.MaxLength = 0x23;
                this.columnresWorker.ReadOnly = true;
                this.columnresWorker.MaxLength = 0x23;
                this.columnOutputMaker.ReadOnly = true;
                this.columnResolution.ReadOnly = true;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class373 method_6()
            {
                return (DataSetOrder.Class373) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_7()
            {
                this.OutputMakerColumn.Expression = "OutputFIO + convert(13,System.Char) + convert(10,System.Char)+ MakerFIO";
                this.ResolutionColumn.Expression = "resWorker+ convert(13,System.Char) + convert(10,System.Char) + beginRes";
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_8(DataSetOrder.Class373 class373_0)
            {
                base.Rows.Remove(class373_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class373(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vJ_OrderRowChanged != null)
                {
                    this.vJ_OrderRowChanged(this, new DataSetOrder.EventArgs220((DataSetOrder.Class373) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vJ_OrderRowChanging != null)
                {
                    this.vJ_OrderRowChanging(this, new DataSetOrder.EventArgs220((DataSetOrder.Class373) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vJ_OrderRowDeleted != null)
                {
                    this.vJ_OrderRowDeleted(this, new DataSetOrder.EventArgs220((DataSetOrder.Class373) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vJ_OrderRowDeleting != null)
                {
                    this.vJ_OrderRowDeleting(this, new DataSetOrder.EventArgs220((DataSetOrder.Class373) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vJ_OrderDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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
            public DataColumn acceptFIOColumn
            {
                get
                {
                    return this.columnacceptFIO;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn acceptworkerColumn
            {
                get
                {
                    return this.columnacceptworker;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn beginResColumn
            {
                get
                {
                    return this.columnbeginRes;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn closeFIOColumn
            {
                get
                {
                    return this.columncloseFIO;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn closeWorkerColumn
            {
                get
                {
                    return this.columncloseWorker;
                }
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
            public DataColumn dateBeginColumn
            {
                get
                {
                    return this.columndateBegin;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateCloseColumn
            {
                get
                {
                    return this.columndateClose;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateEndColumn
            {
                get
                {
                    return this.columndateEnd;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateEndExtColumn
            {
                get
                {
                    return this.columnDateEndExt;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dateOutputColumn
            {
                get
                {
                    return this.columndateOutput;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn EndResColumn
            {
                get
                {
                    return this.columnEndRes;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn extFioColumn
            {
                get
                {
                    return this.columnextFio;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn extWorkerColumn
            {
                get
                {
                    return this.columnextWorker;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn headFioColumn
            {
                get
                {
                    return this.columnheadFio;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn headworkerColumn
            {
                get
                {
                    return this.columnheadworker;
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
            public DataColumn idSRColumn
            {
                get
                {
                    return this.columnidSR;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn instructionColumn
            {
                get
                {
                    return this.columninstruction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class373 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class373) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn makerFIOColumn
            {
                get
                {
                    return this.columnmakerFIO;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn makerWorkerColumn
            {
                get
                {
                    return this.columnmakerWorker;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn otherInstructionColumn
            {
                get
                {
                    return this.columnotherInstruction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn outputFIOColumn
            {
                get
                {
                    return this.columnoutputFIO;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn OutputMakerColumn
            {
                get
                {
                    return this.columnOutputMaker;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn outputWorkerColumn
            {
                get
                {
                    return this.columnoutputWorker;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn registeredColumn
            {
                get
                {
                    return this.columnregistered;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ResolutionColumn
            {
                get
                {
                    return this.columnResolution;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn resWorkerColumn
            {
                get
                {
                    return this.columnresWorker;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn resWorkerIdColumn
            {
                get
                {
                    return this.columnresWorkerId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn srNameColumn
            {
                get
                {
                    return this.columnsrName;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn srNumColumn
            {
                get
                {
                    return this.columnsrNum;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn watchFIOColumn
            {
                get
                {
                    return this.columnwatchFIO;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn watchWorkerColumn
            {
                get
                {
                    return this.columnwatchWorker;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vJ_OrderEventsDataTable : TypedTableBase<DataSetOrder.Class381>
        {
            private DataColumn columnacceptFIO;
            private DataColumn columnclosed;
            private DataColumn columndisp;
            private DataColumn columnEvnt;
            private DataColumn columnEvntDate;
            private DataColumn columnid;
            private DataColumn columninstruction;
            private DataColumn columnmakerFio;
            private DataColumn columnnum;
            private DataColumn columnsrNum;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate232 vJ_OrderEventsRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate232 vJ_OrderEventsRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate232 vJ_OrderEventsRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate232 vJ_OrderEventsRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vJ_OrderEventsDataTable()
            {
                base.TableName = "vJ_OrderEvents";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal vJ_OrderEventsDataTable(DataTable dataTable_0)
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
            protected vJ_OrderEventsDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetOrder.vJ_OrderEventsDataTable table1 = (DataSetOrder.vJ_OrderEventsDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.vJ_OrderEventsDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class381);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(DataSetOrder.Class381 class381_0)
            {
                base.Rows.Add(class381_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class381 method_1(int int_0, int int_1, int int_2, string string_0, string string_1, string string_2, string string_3, DateTime dateTime_0, int int_3, string string_4)
            {
                DataSetOrder.Class381 row = (DataSetOrder.Class381) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, int_2, string_0, string_1, string_2, string_3, dateTime_0, int_3, string_4 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnid = base.Columns["id"];
                this.columnnum = base.Columns["num"];
                this.columnsrNum = base.Columns["srNum"];
                this.columninstruction = base.Columns["instruction"];
                this.columnacceptFIO = base.Columns["acceptFIO"];
                this.columnmakerFio = base.Columns["makerFio"];
                this.columnEvnt = base.Columns["Evnt"];
                this.columnEvntDate = base.Columns["EvntDate"];
                this.columnclosed = base.Columns["closed"];
                this.columndisp = base.Columns["disp"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnnum = new DataColumn("num", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnum);
                this.columnsrNum = new DataColumn("srNum", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnsrNum);
                this.columninstruction = new DataColumn("instruction", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columninstruction);
                this.columnacceptFIO = new DataColumn("acceptFIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnacceptFIO);
                this.columnmakerFio = new DataColumn("makerFio", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnmakerFio);
                this.columnEvnt = new DataColumn("Evnt", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnEvnt);
                this.columnEvntDate = new DataColumn("EvntDate", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnEvntDate);
                this.columnclosed = new DataColumn("closed", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnclosed);
                this.columndisp = new DataColumn("disp", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columndisp);
                this.columnid.AllowDBNull = false;
                this.columnnum.AllowDBNull = false;
                this.columninstruction.AllowDBNull = false;
                this.columninstruction.MaxLength = 500;
                this.columnacceptFIO.MaxLength = 0x23;
                this.columnmakerFio.MaxLength = 0x23;
                this.columnEvnt.AllowDBNull = false;
                this.columnEvnt.MaxLength = 0x10;
                this.columnclosed.AllowDBNull = false;
                this.columndisp.MaxLength = 0x23;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class381 method_4()
            {
                return (DataSetOrder.Class381) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(DataSetOrder.Class381 class381_0)
            {
                base.Rows.Remove(class381_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class381(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vJ_OrderEventsRowChanged != null)
                {
                    this.vJ_OrderEventsRowChanged(this, new DataSetOrder.EventArgs228((DataSetOrder.Class381) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vJ_OrderEventsRowChanging != null)
                {
                    this.vJ_OrderEventsRowChanging(this, new DataSetOrder.EventArgs228((DataSetOrder.Class381) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vJ_OrderEventsRowDeleted != null)
                {
                    this.vJ_OrderEventsRowDeleted(this, new DataSetOrder.EventArgs228((DataSetOrder.Class381) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vJ_OrderEventsRowDeleting != null)
                {
                    this.vJ_OrderEventsRowDeleting(this, new DataSetOrder.EventArgs228((DataSetOrder.Class381) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vJ_OrderEventsDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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
            public DataColumn acceptFIOColumn
            {
                get
                {
                    return this.columnacceptFIO;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn closedColumn
            {
                get
                {
                    return this.columnclosed;
                }
            }

            [DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn dispColumn
            {
                get
                {
                    return this.columndisp;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn EvntColumn
            {
                get
                {
                    return this.columnEvnt;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn EvntDateColumn
            {
                get
                {
                    return this.columnEvntDate;
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
            public DataColumn instructionColumn
            {
                get
                {
                    return this.columninstruction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class381 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class381) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn makerFioColumn
            {
                get
                {
                    return this.columnmakerFio;
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn srNumColumn
            {
                get
                {
                    return this.columnsrNum;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vR_WorkerDataTable : TypedTableBase<DataSetOrder.Class375>
        {
            private DataColumn columnDateBegin;
            private DataColumn columnDateEnd;
            private DataColumn columnFIO;
            private DataColumn columnGroupElectrical;
            private DataColumn columnid;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate226 vR_WorkerRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate226 vR_WorkerRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate226 vR_WorkerRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate226 vR_WorkerRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vR_WorkerDataTable()
            {
                base.TableName = "vR_Worker";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vR_WorkerDataTable(DataTable dataTable_0)
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
            protected vR_WorkerDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetOrder.vR_WorkerDataTable table1 = (DataSetOrder.vR_WorkerDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.vR_WorkerDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class375);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetOrder.Class375 class375_0)
            {
                base.Rows.Add(class375_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class375 method_1(int int_0, string string_0, DateTime dateTime_0, DateTime dateTime_1, short short_0)
            {
                DataSetOrder.Class375 row = (DataSetOrder.Class375) base.NewRow();
                object[] objArray = new object[] { int_0, string_0, dateTime_0, dateTime_1, short_0 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class375 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetOrder.Class375) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnFIO = base.Columns["FIO"];
                this.columnDateBegin = base.Columns["DateBegin"];
                this.columnDateEnd = base.Columns["DateEnd"];
                this.columnGroupElectrical = base.Columns["GroupElectrical"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnFIO = new DataColumn("FIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFIO);
                this.columnDateBegin = new DataColumn("DateBegin", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateBegin);
                this.columnDateEnd = new DataColumn("DateEnd", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateEnd);
                this.columnGroupElectrical = new DataColumn("GroupElectrical", typeof(short), null, MappingType.Element);
                base.Columns.Add(this.columnGroupElectrical);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columnFIO.ReadOnly = true;
                this.columnFIO.MaxLength = 0x23;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class375 method_5()
            {
                return (DataSetOrder.Class375) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(DataSetOrder.Class375 class375_0)
            {
                base.Rows.Remove(class375_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class375(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vR_WorkerRowChanged != null)
                {
                    this.vR_WorkerRowChanged(this, new DataSetOrder.EventArgs222((DataSetOrder.Class375) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vR_WorkerRowChanging != null)
                {
                    this.vR_WorkerRowChanging(this, new DataSetOrder.EventArgs222((DataSetOrder.Class375) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vR_WorkerRowDeleted != null)
                {
                    this.vR_WorkerRowDeleted(this, new DataSetOrder.EventArgs222((DataSetOrder.Class375) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vR_WorkerRowDeleting != null)
                {
                    this.vR_WorkerRowDeleting(this, new DataSetOrder.EventArgs222((DataSetOrder.Class375) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vR_WorkerDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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

            [Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class375 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class375) base.Rows[int_0];
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vSchm_ObjListDataTable : TypedTableBase<DataSetOrder.Class383>
        {
            private DataColumn columnDeleted;
            private DataColumn columnId;
            private DataColumn columnIdParent;
            private DataColumn columnName;
            private DataColumn columnNameP;
            private DataColumn columnOnOff;
            private DataColumn columntypecode;
            private DataColumn columnTypeCodeId;
            private DataColumn columntypeCodeSocr;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate234 vSchm_ObjListRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate234 vSchm_ObjListRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate234 vSchm_ObjListRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate234 vSchm_ObjListRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vSchm_ObjListDataTable()
            {
                base.TableName = "vSchm_ObjList";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected vSchm_ObjListDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetOrder.vSchm_ObjListDataTable table1 = (DataSetOrder.vSchm_ObjListDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.vSchm_ObjListDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class383);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetOrder.Class383 class383_0)
            {
                base.Rows.Add(class383_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class383 method_1(int int_0, string string_0, int int_1, string string_1, string string_2, int int_2, bool bool_0, int int_3, bool bool_1)
            {
                DataSetOrder.Class383 row = (DataSetOrder.Class383) base.NewRow();
                object[] objArray = new object[] { int_0, string_0, int_1, string_1, string_2, int_2, bool_0, int_3, bool_1 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class383 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetOrder.Class383) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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
                this.columnDeleted = base.Columns["Deleted"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
                this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnDeleted);
                DataColumn[] columns = new DataColumn[] { this.columnId };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnId.AllowDBNull = false;
                this.columnId.Unique = true;
                this.columnName.MaxLength = 0x200;
                this.columntypecode.MaxLength = 100;
                this.columntypeCodeSocr.MaxLength = 50;
                this.columnNameP.ReadOnly = true;
                this.columnDeleted.AllowDBNull = false;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class383 method_5()
            {
                return (DataSetOrder.Class383) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetOrder.Class383 class383_0)
            {
                base.Rows.Remove(class383_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class383(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vSchm_ObjListRowChanged != null)
                {
                    this.vSchm_ObjListRowChanged(this, new DataSetOrder.EventArgs230((DataSetOrder.Class383) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vSchm_ObjListRowChanging != null)
                {
                    this.vSchm_ObjListRowChanging(this, new DataSetOrder.EventArgs230((DataSetOrder.Class383) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vSchm_ObjListRowDeleted != null)
                {
                    this.vSchm_ObjListRowDeleted(this, new DataSetOrder.EventArgs230((DataSetOrder.Class383) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vSchm_ObjListRowDeleting != null)
                {
                    this.vSchm_ObjListRowDeleting(this, new DataSetOrder.EventArgs230((DataSetOrder.Class383) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vSchm_ObjListDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DeletedColumn
            {
                get
                {
                    return this.columnDeleted;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IdColumn
            {
                get
                {
                    return this.columnId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IdParentColumn
            {
                get
                {
                    return this.columnIdParent;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class383 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class383) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NameColumn
            {
                get
                {
                    return this.columnName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NamePColumn
            {
                get
                {
                    return this.columnNameP;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn OnOffColumn
            {
                get
                {
                    return this.columnOnOff;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn typecodeColumn
            {
                get
                {
                    return this.columntypecode;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TypeCodeIdColumn
            {
                get
                {
                    return this.columnTypeCodeId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn typeCodeSocrColumn
            {
                get
                {
                    return this.columntypeCodeSocr;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vSchm_TreeCellLineDataTable : TypedTableBase<DataSetOrder.Class384>
        {
            private DataColumn columnFullName;
            private DataColumn columnId;
            private DataColumn columnName;
            private DataColumn columnParentKey;
            private DataColumn columnParentLink;
            private DataColumn columnTypeCodeId;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate235 vSchm_TreeCellLineRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate235 vSchm_TreeCellLineRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate235 vSchm_TreeCellLineRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate235 vSchm_TreeCellLineRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vSchm_TreeCellLineDataTable()
            {
                base.TableName = "vSchm_TreeCellLine";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected vSchm_TreeCellLineDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetOrder.vSchm_TreeCellLineDataTable table1 = (DataSetOrder.vSchm_TreeCellLineDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.vSchm_TreeCellLineDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class384);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetOrder.Class384 class384_0)
            {
                base.Rows.Add(class384_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class384 method_1(int int_0, int int_1, int int_2, string string_0, string string_1, string string_2)
            {
                DataSetOrder.Class384 row = (DataSetOrder.Class384) base.NewRow();
                object[] objArray = new object[] { int_0, int_1, int_2, string_0, string_1, string_2 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnId = base.Columns["Id"];
                this.columnParentLink = base.Columns["ParentLink"];
                this.columnTypeCodeId = base.Columns["TypeCodeId"];
                this.columnParentKey = base.Columns["ParentKey"];
                this.columnName = base.Columns["Name"];
                this.columnFullName = base.Columns["FullName"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
                this.columnName.MaxLength = 0x200;
                this.columnFullName.ReadOnly = true;
                this.columnFullName.MaxLength = 0x235;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class384 method_4()
            {
                return (DataSetOrder.Class384) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(DataSetOrder.Class384 class384_0)
            {
                base.Rows.Remove(class384_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class384(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vSchm_TreeCellLineRowChanged != null)
                {
                    this.vSchm_TreeCellLineRowChanged(this, new DataSetOrder.EventArgs231((DataSetOrder.Class384) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vSchm_TreeCellLineRowChanging != null)
                {
                    this.vSchm_TreeCellLineRowChanging(this, new DataSetOrder.EventArgs231((DataSetOrder.Class384) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vSchm_TreeCellLineRowDeleted != null)
                {
                    this.vSchm_TreeCellLineRowDeleted(this, new DataSetOrder.EventArgs231((DataSetOrder.Class384) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vSchm_TreeCellLineRowDeleting != null)
                {
                    this.vSchm_TreeCellLineRowDeleting(this, new DataSetOrder.EventArgs231((DataSetOrder.Class384) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vSchm_TreeCellLineDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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
            public DataColumn FullNameColumn
            {
                get
                {
                    return this.columnFullName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IdColumn
            {
                get
                {
                    return this.columnId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetOrder.Class384 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class384) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NameColumn
            {
                get
                {
                    return this.columnName;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ParentLinkColumn
            {
                get
                {
                    return this.columnParentLink;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TypeCodeIdColumn
            {
                get
                {
                    return this.columnTypeCodeId;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vWorkerGroupDataTable : TypedTableBase<DataSetOrder.Class376>
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
            public event DataSetOrder.Delegate227 vWorkerGroupRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate227 vWorkerGroupRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate227 vWorkerGroupRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetOrder.Delegate227 vWorkerGroupRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public vWorkerGroupDataTable()
            {
                base.TableName = "vWorkerGroup";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected vWorkerGroupDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetOrder.vWorkerGroupDataTable table1 = (DataSetOrder.vWorkerGroupDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetOrder.vWorkerGroupDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(DataSetOrder.Class376);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetOrder.Class376 class376_0)
            {
                base.Rows.Add(class376_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class376 method_1(int int_0, string string_0, DateTime dateTime_0, DateTime dateTime_1, int int_1, string string_1, string string_2, string string_3, int int_2, short short_0)
            {
                DataSetOrder.Class376 row = (DataSetOrder.Class376) base.NewRow();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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
            public DataSetOrder.Class376 method_4()
            {
                return (DataSetOrder.Class376) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(DataSetOrder.Class376 class376_0)
            {
                base.Rows.Remove(class376_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetOrder.Class376(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vWorkerGroupRowChanged != null)
                {
                    this.vWorkerGroupRowChanged(this, new DataSetOrder.EventArgs223((DataSetOrder.Class376) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vWorkerGroupRowChanging != null)
                {
                    this.vWorkerGroupRowChanging(this, new DataSetOrder.EventArgs223((DataSetOrder.Class376) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vWorkerGroupRowDeleted != null)
                {
                    this.vWorkerGroupRowDeleted(this, new DataSetOrder.EventArgs223((DataSetOrder.Class376) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vWorkerGroupRowDeleting != null)
                {
                    this.vWorkerGroupRowDeleting(this, new DataSetOrder.EventArgs223((DataSetOrder.Class376) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetOrder order = new DataSetOrder();
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
                    FixedValue = order.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vWorkerGroupDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = order.GetSchemaSerializable();
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
            public DataColumn DateBeginColumn
            {
                get
                {
                    return this.columnDateBegin;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateEndColumn
            {
                get
                {
                    return this.columnDateEnd;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DescriptionColumn
            {
                get
                {
                    return this.columnDescription;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn FIOColumn
            {
                get
                {
                    return this.columnFIO;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn GroupElectricalColumn
            {
                get
                {
                    return this.columnGroupElectrical;
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
            public DataColumn idDescriptionColumn
            {
                get
                {
                    return this.columnidDescription;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idGroupColumn
            {
                get
                {
                    return this.columnidGroup;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetOrder.Class376 this[int int_0]
            {
                get
                {
                    return (DataSetOrder.Class376) base.Rows[int_0];
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

