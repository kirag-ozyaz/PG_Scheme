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

    [Serializable, ToolboxItem(true), HelpKeyword("vs.data.DataSet"), XmlSchemaProvider("GetTypedDataSetSchema"), DesignerCategory("code"), XmlRoot("OrgDataSet")]
    internal class OrgDataSet : DataSet
    {
        private System.Data.SchemaSerializationMode _schemaSerializationMode;
        private CancelReport1DataTableDataTable tableCancelReport1DataTable;
        private NetAreaDataTable tableNetArea;
        private ODSReportDataTableDataTable tableODSReportDataTable;
        private Report1DataTableDataTable tableReport1DataTable;
        private ReportODSDataTable tableReportODS;
        private tAbonentDataTable tabletAbonent;
        private tAbonentNCDataTable tabletAbonentNC;
        private tblAbnDataTable tabletblAbn;
        private tblAbnAplConnectPointForIndividualUsersDataTable tabletblAbnAplConnectPointForIndividualUsers;
        private tblAbnAplForDisconDataTable tabletblAbnAplForDiscon;
        private tblAbnAplForDisconIndividualUsersDataTable tabletblAbnAplForDisconIndividualUsers;
        private tblAbnAplForDisconIndividualUsersForCancelDataTable tabletblAbnAplForDisconIndividualUsersForCancel;
        private tblAbnAplForDisconObjectsDataTable tabletblAbnAplForDisconObjects;
        private tblAbnAplForDisconReasonDataTable tabletblAbnAplForDisconReason;
        private tblAbnObjDataTable tabletblAbnObj;
        private tblAbnObj1DataTable tabletblAbnObj1;
        private tblAbnObj2DataTable tabletblAbnObj2;
        private tR_WorkerDataTable tabletR_Worker;

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public OrgDataSet()
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            base.BeginInit();
            this.method_2();
            CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_21);
            base.Tables.CollectionChanged += handler;
            base.Relations.CollectionChanged += handler;
            base.EndInit();
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected OrgDataSet(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0, false)
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            if (base.IsBinarySerialized(serializationInfo_0, streamingContext_0))
            {
                this.method_1(false);
                CollectionChangeEventHandler handler2 = new CollectionChangeEventHandler(this.method_21);
                this.Tables.CollectionChanged += handler2;
                this.Relations.CollectionChanged += handler2;
            }
            else
            {
                string s = (string) serializationInfo_0.GetValue("XmlSchema", typeof(string));
                if (base.DetermineSchemaSerializationMode(serializationInfo_0, streamingContext_0) == System.Data.SchemaSerializationMode.IncludeSchema)
                {
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
                    if (dataSet.Tables["tblAbnAplForDiscon"] != null)
                    {
                        base.Tables.Add(new tblAbnAplForDisconDataTable(dataSet.Tables["tblAbnAplForDiscon"]));
                    }
                    if (dataSet.Tables["tblAbnAplForDisconObjects"] != null)
                    {
                        base.Tables.Add(new tblAbnAplForDisconObjectsDataTable(dataSet.Tables["tblAbnAplForDisconObjects"]));
                    }
                    if (dataSet.Tables["tblAbnAplForDisconReason"] != null)
                    {
                        base.Tables.Add(new tblAbnAplForDisconReasonDataTable(dataSet.Tables["tblAbnAplForDisconReason"]));
                    }
                    if (dataSet.Tables["tblAbnObj"] != null)
                    {
                        base.Tables.Add(new tblAbnObjDataTable(dataSet.Tables["tblAbnObj"]));
                    }
                    if (dataSet.Tables["tblAbn"] != null)
                    {
                        base.Tables.Add(new tblAbnDataTable(dataSet.Tables["tblAbn"]));
                    }
                    if (dataSet.Tables["tblAbnAplForDisconIndividualUsers"] != null)
                    {
                        base.Tables.Add(new tblAbnAplForDisconIndividualUsersDataTable(dataSet.Tables["tblAbnAplForDisconIndividualUsers"]));
                    }
                    if (dataSet.Tables["tAbonent"] != null)
                    {
                        base.Tables.Add(new tAbonentDataTable(dataSet.Tables["tAbonent"]));
                    }
                    if (dataSet.Tables["tblAbnObj1"] != null)
                    {
                        base.Tables.Add(new tblAbnObj1DataTable(dataSet.Tables["tblAbnObj1"]));
                    }
                    if (dataSet.Tables["tAbonentNC"] != null)
                    {
                        base.Tables.Add(new tAbonentNCDataTable(dataSet.Tables["tAbonentNC"]));
                    }
                    if (dataSet.Tables["tblAbnAplConnectPointForIndividualUsers"] != null)
                    {
                        base.Tables.Add(new tblAbnAplConnectPointForIndividualUsersDataTable(dataSet.Tables["tblAbnAplConnectPointForIndividualUsers"]));
                    }
                    if (dataSet.Tables["tblAbnObj2"] != null)
                    {
                        base.Tables.Add(new tblAbnObj2DataTable(dataSet.Tables["tblAbnObj2"]));
                    }
                    if (dataSet.Tables["tblAbnAplForDisconIndividualUsersForCancel"] != null)
                    {
                        base.Tables.Add(new tblAbnAplForDisconIndividualUsersForCancelDataTable(dataSet.Tables["tblAbnAplForDisconIndividualUsersForCancel"]));
                    }
                    if (dataSet.Tables["NetArea"] != null)
                    {
                        base.Tables.Add(new NetAreaDataTable(dataSet.Tables["NetArea"]));
                    }
                    if (dataSet.Tables["tR_Worker"] != null)
                    {
                        base.Tables.Add(new tR_WorkerDataTable(dataSet.Tables["tR_Worker"]));
                    }
                    if (dataSet.Tables["Report1DataTable"] != null)
                    {
                        base.Tables.Add(new Report1DataTableDataTable(dataSet.Tables["Report1DataTable"]));
                    }
                    if (dataSet.Tables["ODSReportDataTable"] != null)
                    {
                        base.Tables.Add(new ODSReportDataTableDataTable(dataSet.Tables["ODSReportDataTable"]));
                    }
                    if (dataSet.Tables["ReportODS"] != null)
                    {
                        base.Tables.Add(new ReportODSDataTable(dataSet.Tables["ReportODS"]));
                    }
                    if (dataSet.Tables["CancelReport1DataTable"] != null)
                    {
                        base.Tables.Add(new CancelReport1DataTableDataTable(dataSet.Tables["CancelReport1DataTable"]));
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
                CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_21);
                base.Tables.CollectionChanged += handler;
                this.Relations.CollectionChanged += handler;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override DataSet Clone()
        {
            OrgDataSet set1 = (OrgDataSet) base.Clone();
            set1.method_0();
            set1.SchemaSerializationMode = this.SchemaSerializationMode;
            return set1;
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
            this.tabletblAbnAplForDiscon = (tblAbnAplForDisconDataTable) base.Tables["tblAbnAplForDiscon"];
            if (bool_0 && (this.tabletblAbnAplForDiscon != null))
            {
                this.tabletblAbnAplForDiscon.method_2();
            }
            this.tabletblAbnAplForDisconObjects = (tblAbnAplForDisconObjectsDataTable) base.Tables["tblAbnAplForDisconObjects"];
            if (bool_0 && (this.tabletblAbnAplForDisconObjects != null))
            {
                this.tabletblAbnAplForDisconObjects.method_2();
            }
            this.tabletblAbnAplForDisconReason = (tblAbnAplForDisconReasonDataTable) base.Tables["tblAbnAplForDisconReason"];
            if (bool_0 && (this.tabletblAbnAplForDisconReason != null))
            {
                this.tabletblAbnAplForDisconReason.method_2();
            }
            this.tabletblAbnObj = (tblAbnObjDataTable) base.Tables["tblAbnObj"];
            if (bool_0 && (this.tabletblAbnObj != null))
            {
                this.tabletblAbnObj.method_2();
            }
            this.tabletblAbn = (tblAbnDataTable) base.Tables["tblAbn"];
            if (bool_0 && (this.tabletblAbn != null))
            {
                this.tabletblAbn.method_2();
            }
            this.tabletblAbnAplForDisconIndividualUsers = (tblAbnAplForDisconIndividualUsersDataTable) base.Tables["tblAbnAplForDisconIndividualUsers"];
            if (bool_0 && (this.tabletblAbnAplForDisconIndividualUsers != null))
            {
                this.tabletblAbnAplForDisconIndividualUsers.method_2();
            }
            this.tabletAbonent = (tAbonentDataTable) base.Tables["tAbonent"];
            if (bool_0 && (this.tabletAbonent != null))
            {
                this.tabletAbonent.method_2();
            }
            this.tabletblAbnObj1 = (tblAbnObj1DataTable) base.Tables["tblAbnObj1"];
            if (bool_0 && (this.tabletblAbnObj1 != null))
            {
                this.tabletblAbnObj1.method_3();
            }
            this.tabletAbonentNC = (tAbonentNCDataTable) base.Tables["tAbonentNC"];
            if (bool_0 && (this.tabletAbonentNC != null))
            {
                this.tabletAbonentNC.method_2();
            }
            this.tabletblAbnAplConnectPointForIndividualUsers = (tblAbnAplConnectPointForIndividualUsersDataTable) base.Tables["tblAbnAplConnectPointForIndividualUsers"];
            if (bool_0 && (this.tabletblAbnAplConnectPointForIndividualUsers != null))
            {
                this.tabletblAbnAplConnectPointForIndividualUsers.method_2();
            }
            this.tabletblAbnObj2 = (tblAbnObj2DataTable) base.Tables["tblAbnObj2"];
            if (bool_0 && (this.tabletblAbnObj2 != null))
            {
                this.tabletblAbnObj2.method_2();
            }
            this.tabletblAbnAplForDisconIndividualUsersForCancel = (tblAbnAplForDisconIndividualUsersForCancelDataTable) base.Tables["tblAbnAplForDisconIndividualUsersForCancel"];
            if (bool_0 && (this.tabletblAbnAplForDisconIndividualUsersForCancel != null))
            {
                this.tabletblAbnAplForDisconIndividualUsersForCancel.method_3();
            }
            this.tableNetArea = (NetAreaDataTable) base.Tables["NetArea"];
            if (bool_0 && (this.tableNetArea != null))
            {
                this.tableNetArea.method_3();
            }
            this.tabletR_Worker = (tR_WorkerDataTable) base.Tables["tR_Worker"];
            if (bool_0 && (this.tabletR_Worker != null))
            {
                this.tabletR_Worker.method_3();
            }
            this.tableReport1DataTable = (Report1DataTableDataTable) base.Tables["Report1DataTable"];
            if (bool_0 && (this.tableReport1DataTable != null))
            {
                this.tableReport1DataTable.method_2();
            }
            this.tableODSReportDataTable = (ODSReportDataTableDataTable) base.Tables["ODSReportDataTable"];
            if (bool_0 && (this.tableODSReportDataTable != null))
            {
                this.tableODSReportDataTable.method_2();
            }
            this.tableReportODS = (ReportODSDataTable) base.Tables["ReportODS"];
            if (bool_0 && (this.tableReportODS != null))
            {
                this.tableReportODS.method_2();
            }
            this.tableCancelReport1DataTable = (CancelReport1DataTableDataTable) base.Tables["CancelReport1DataTable"];
            if (bool_0 && (this.tableCancelReport1DataTable != null))
            {
                this.tableCancelReport1DataTable.method_2();
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_13()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_17()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_18()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_19()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_2()
        {
            base.DataSetName = "OrgDataSet";
            base.Prefix = "";
            base.Namespace = "http://tempuri.org/OrgDataSet.xsd";
            base.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tabletblAbnAplForDiscon = new tblAbnAplForDisconDataTable();
            base.Tables.Add(this.tabletblAbnAplForDiscon);
            this.tabletblAbnAplForDisconObjects = new tblAbnAplForDisconObjectsDataTable();
            base.Tables.Add(this.tabletblAbnAplForDisconObjects);
            this.tabletblAbnAplForDisconReason = new tblAbnAplForDisconReasonDataTable();
            base.Tables.Add(this.tabletblAbnAplForDisconReason);
            this.tabletblAbnObj = new tblAbnObjDataTable();
            base.Tables.Add(this.tabletblAbnObj);
            this.tabletblAbn = new tblAbnDataTable();
            base.Tables.Add(this.tabletblAbn);
            this.tabletblAbnAplForDisconIndividualUsers = new tblAbnAplForDisconIndividualUsersDataTable();
            base.Tables.Add(this.tabletblAbnAplForDisconIndividualUsers);
            this.tabletAbonent = new tAbonentDataTable();
            base.Tables.Add(this.tabletAbonent);
            this.tabletblAbnObj1 = new tblAbnObj1DataTable();
            base.Tables.Add(this.tabletblAbnObj1);
            this.tabletAbonentNC = new tAbonentNCDataTable();
            base.Tables.Add(this.tabletAbonentNC);
            this.tabletblAbnAplConnectPointForIndividualUsers = new tblAbnAplConnectPointForIndividualUsersDataTable();
            base.Tables.Add(this.tabletblAbnAplConnectPointForIndividualUsers);
            this.tabletblAbnObj2 = new tblAbnObj2DataTable();
            base.Tables.Add(this.tabletblAbnObj2);
            this.tabletblAbnAplForDisconIndividualUsersForCancel = new tblAbnAplForDisconIndividualUsersForCancelDataTable();
            base.Tables.Add(this.tabletblAbnAplForDisconIndividualUsersForCancel);
            this.tableNetArea = new NetAreaDataTable();
            base.Tables.Add(this.tableNetArea);
            this.tabletR_Worker = new tR_WorkerDataTable();
            base.Tables.Add(this.tabletR_Worker);
            this.tableReport1DataTable = new Report1DataTableDataTable();
            base.Tables.Add(this.tableReport1DataTable);
            this.tableODSReportDataTable = new ODSReportDataTableDataTable();
            base.Tables.Add(this.tableODSReportDataTable);
            this.tableReportODS = new ReportODSDataTable();
            base.Tables.Add(this.tableReportODS);
            this.tableCancelReport1DataTable = new CancelReport1DataTableDataTable();
            base.Tables.Add(this.tableCancelReport1DataTable);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_20()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_21(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Remove)
            {
                this.method_0();
            }
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected override void ReadXmlSerializable(XmlReader reader)
        {
            if (base.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)
            {
                this.Reset();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(reader);
                if (dataSet.Tables["tblAbnAplForDiscon"] != null)
                {
                    base.Tables.Add(new tblAbnAplForDisconDataTable(dataSet.Tables["tblAbnAplForDiscon"]));
                }
                if (dataSet.Tables["tblAbnAplForDisconObjects"] != null)
                {
                    base.Tables.Add(new tblAbnAplForDisconObjectsDataTable(dataSet.Tables["tblAbnAplForDisconObjects"]));
                }
                if (dataSet.Tables["tblAbnAplForDisconReason"] != null)
                {
                    base.Tables.Add(new tblAbnAplForDisconReasonDataTable(dataSet.Tables["tblAbnAplForDisconReason"]));
                }
                if (dataSet.Tables["tblAbnObj"] != null)
                {
                    base.Tables.Add(new tblAbnObjDataTable(dataSet.Tables["tblAbnObj"]));
                }
                if (dataSet.Tables["tblAbn"] != null)
                {
                    base.Tables.Add(new tblAbnDataTable(dataSet.Tables["tblAbn"]));
                }
                if (dataSet.Tables["tblAbnAplForDisconIndividualUsers"] != null)
                {
                    base.Tables.Add(new tblAbnAplForDisconIndividualUsersDataTable(dataSet.Tables["tblAbnAplForDisconIndividualUsers"]));
                }
                if (dataSet.Tables["tAbonent"] != null)
                {
                    base.Tables.Add(new tAbonentDataTable(dataSet.Tables["tAbonent"]));
                }
                if (dataSet.Tables["tblAbnObj1"] != null)
                {
                    base.Tables.Add(new tblAbnObj1DataTable(dataSet.Tables["tblAbnObj1"]));
                }
                if (dataSet.Tables["tAbonentNC"] != null)
                {
                    base.Tables.Add(new tAbonentNCDataTable(dataSet.Tables["tAbonentNC"]));
                }
                if (dataSet.Tables["tblAbnAplConnectPointForIndividualUsers"] != null)
                {
                    base.Tables.Add(new tblAbnAplConnectPointForIndividualUsersDataTable(dataSet.Tables["tblAbnAplConnectPointForIndividualUsers"]));
                }
                if (dataSet.Tables["tblAbnObj2"] != null)
                {
                    base.Tables.Add(new tblAbnObj2DataTable(dataSet.Tables["tblAbnObj2"]));
                }
                if (dataSet.Tables["tblAbnAplForDisconIndividualUsersForCancel"] != null)
                {
                    base.Tables.Add(new tblAbnAplForDisconIndividualUsersForCancelDataTable(dataSet.Tables["tblAbnAplForDisconIndividualUsersForCancel"]));
                }
                if (dataSet.Tables["NetArea"] != null)
                {
                    base.Tables.Add(new NetAreaDataTable(dataSet.Tables["NetArea"]));
                }
                if (dataSet.Tables["tR_Worker"] != null)
                {
                    base.Tables.Add(new tR_WorkerDataTable(dataSet.Tables["tR_Worker"]));
                }
                if (dataSet.Tables["Report1DataTable"] != null)
                {
                    base.Tables.Add(new Report1DataTableDataTable(dataSet.Tables["Report1DataTable"]));
                }
                if (dataSet.Tables["ODSReportDataTable"] != null)
                {
                    base.Tables.Add(new ODSReportDataTableDataTable(dataSet.Tables["ODSReportDataTable"]));
                }
                if (dataSet.Tables["ReportODS"] != null)
                {
                    base.Tables.Add(new ReportODSDataTable(dataSet.Tables["ReportODS"]));
                }
                if (dataSet.Tables["CancelReport1DataTable"] != null)
                {
                    base.Tables.Add(new CancelReport1DataTableDataTable(dataSet.Tables["CancelReport1DataTable"]));
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
        {
            OrgDataSet set = new OrgDataSet();
            XmlSchemaComplexType type = new XmlSchemaComplexType();
            XmlSchemaSequence sequence = new XmlSchemaSequence();
            XmlSchemaAny item = new XmlSchemaAny {
                Namespace = set.Namespace
            };
            sequence.Items.Add(item);
            type.Particle = sequence;
            XmlSchema schemaSerializable = set.GetSchemaSerializable();
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public CancelReport1DataTableDataTable CancelReport1DataTable
        {
            get
            {
                return this.tableCancelReport1DataTable;
            }
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public NetAreaDataTable NetArea
        {
            get
            {
                return this.tableNetArea;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode]
        public ODSReportDataTableDataTable ODSReportDataTable
        {
            get
            {
                return this.tableODSReportDataTable;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode]
        public Report1DataTableDataTable Report1DataTable
        {
            get
            {
                return this.tableReport1DataTable;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public ReportODSDataTable ReportODS
        {
            get
            {
                return this.tableReportODS;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(true), DebuggerNonUserCode]
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataTableCollection Tables
        {
            get
            {
                return base.Tables;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tAbonentDataTable tAbonent
        {
            get
            {
                return this.tabletAbonent;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public tAbonentNCDataTable tAbonentNC
        {
            get
            {
                return this.tabletAbonentNC;
            }
        }

        [DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tblAbnDataTable tblAbn
        {
            get
            {
                return this.tabletblAbn;
            }
        }

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public tblAbnAplConnectPointForIndividualUsersDataTable tblAbnAplConnectPointForIndividualUsers
        {
            get
            {
                return this.tabletblAbnAplConnectPointForIndividualUsers;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false)]
        public tblAbnAplForDisconDataTable tblAbnAplForDiscon
        {
            get
            {
                return this.tabletblAbnAplForDiscon;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public tblAbnAplForDisconIndividualUsersDataTable tblAbnAplForDisconIndividualUsers
        {
            get
            {
                return this.tabletblAbnAplForDisconIndividualUsers;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public tblAbnAplForDisconIndividualUsersForCancelDataTable tblAbnAplForDisconIndividualUsersForCancel
        {
            get
            {
                return this.tabletblAbnAplForDisconIndividualUsersForCancel;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tblAbnAplForDisconObjectsDataTable tblAbnAplForDisconObjects
        {
            get
            {
                return this.tabletblAbnAplForDisconObjects;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tblAbnAplForDisconReasonDataTable tblAbnAplForDisconReason
        {
            get
            {
                return this.tabletblAbnAplForDisconReason;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
        public tblAbnObjDataTable tblAbnObj
        {
            get
            {
                return this.tabletblAbnObj;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode, Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tblAbnObj1DataTable tblAbnObj1
        {
            get
            {
                return this.tabletblAbnObj1;
            }
        }

        [DebuggerNonUserCode, Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public tblAbnObj2DataTable tblAbnObj2
        {
            get
            {
                return this.tabletblAbnObj2;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public tR_WorkerDataTable tR_Worker
        {
            get
            {
                return this.tabletR_Worker;
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class CancelReport1DataTableDataTable : TypedTableBase<OrgDataSet.Class427>
        {
            private DataColumn columnAbn;
            private DataColumn columnDateTimeExecution;
            private DataColumn columnNumDateDog;
            private DataColumn columnObj;
            private DataColumn columnOldAppl;
            private DataColumn columnReason;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate278 CancelReport1DataTableRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate278 CancelReport1DataTableRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate278 CancelReport1DataTableRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate278 CancelReport1DataTableRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public CancelReport1DataTableDataTable()
            {
                base.TableName = "CancelReport1DataTable";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal CancelReport1DataTableDataTable(DataTable dataTable_0)
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
            protected CancelReport1DataTableDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.CancelReport1DataTableDataTable table1 = (OrgDataSet.CancelReport1DataTableDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.CancelReport1DataTableDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class427);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(OrgDataSet.Class427 class427_0)
            {
                base.Rows.Add(class427_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class427 method_1(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5)
            {
                OrgDataSet.Class427 row = (OrgDataSet.Class427) base.NewRow();
                object[] objArray = new object[] { string_0, string_1, string_2, string_3, string_4, string_5 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnNumDateDog = base.Columns["NumDateDog"];
                this.columnAbn = base.Columns["Abn"];
                this.columnObj = base.Columns["Obj"];
                this.columnDateTimeExecution = base.Columns["DateTimeExecution"];
                this.columnReason = base.Columns["Reason"];
                this.columnOldAppl = base.Columns["OldAppl"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnNumDateDog = new DataColumn("NumDateDog", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNumDateDog);
                this.columnAbn = new DataColumn("Abn", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnAbn);
                this.columnObj = new DataColumn("Obj", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnObj);
                this.columnDateTimeExecution = new DataColumn("DateTimeExecution", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDateTimeExecution);
                this.columnReason = new DataColumn("Reason", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnOldAppl = new DataColumn("OldAppl", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnOldAppl);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class427 method_4()
            {
                return (OrgDataSet.Class427) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(OrgDataSet.Class427 class427_0)
            {
                base.Rows.Remove(class427_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class427(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.CancelReport1DataTableRowChanged != null)
                {
                    this.CancelReport1DataTableRowChanged(this, new OrgDataSet.EventArgs274((OrgDataSet.Class427) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.CancelReport1DataTableRowChanging != null)
                {
                    this.CancelReport1DataTableRowChanging(this, new OrgDataSet.EventArgs274((OrgDataSet.Class427) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.CancelReport1DataTableRowDeleted != null)
                {
                    this.CancelReport1DataTableRowDeleted(this, new OrgDataSet.EventArgs274((OrgDataSet.Class427) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.CancelReport1DataTableRowDeleting != null)
                {
                    this.CancelReport1DataTableRowDeleting(this, new OrgDataSet.EventArgs274((OrgDataSet.Class427) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "CancelReport1DataTableDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn AbnColumn
            {
                get
                {
                    return this.columnAbn;
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
            public DataColumn DateTimeExecutionColumn
            {
                get
                {
                    return this.columnDateTimeExecution;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class427 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class427) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NumDateDogColumn
            {
                get
                {
                    return this.columnNumDateDog;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ObjColumn
            {
                get
                {
                    return this.columnObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn OldApplColumn
            {
                get
                {
                    return this.columnOldAppl;
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

        public class Class410 : DataRow
        {
            private OrgDataSet.tblAbnAplForDisconDataTable tblAbnAplForDisconDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class410(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tblAbnAplForDisconDataTable_0 = (OrgDataSet.tblAbnAplForDisconDataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconDataTable_0.NumDocColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NumDoc' в таблице 'tblAbnAplForDiscon' равно DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.tblAbnAplForDisconDataTable_0.NumDocColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_10()
            {
                return base.IsNull(this.tblAbnAplForDisconDataTable_0.NumDocColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_11()
            {
                base[this.tblAbnAplForDisconDataTable_0.NumDocColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_12()
            {
                return base.IsNull(this.tblAbnAplForDisconDataTable_0.NetAreaColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_13()
            {
                base[this.tblAbnAplForDisconDataTable_0.NetAreaColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_14()
            {
                return base.IsNull(this.tblAbnAplForDisconDataTable_0.TypeActionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_15()
            {
                base[this.tblAbnAplForDisconDataTable_0.TypeActionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.tblAbnAplForDisconDataTable_0.DateApplColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.tblAbnAplForDisconDataTable_0.DateApplColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.tblAbnAplForDisconDataTable_0.DateActionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.tblAbnAplForDisconDataTable_0.DateActionColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconDataTable_0.NetAreaCaptionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NetAreaCaption' в таблице 'tblAbnAplForDiscon' равно DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.tblAbnAplForDisconDataTable_0.NetAreaCaptionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.tblAbnAplForDisconDataTable_0.NetAreaCaptionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_22()
            {
                return base.IsNull(this.tblAbnAplForDisconDataTable_0.TypeActionCaptionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.tblAbnAplForDisconDataTable_0.TypeActionCaptionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_24()
            {
                return base.IsNull(this.tblAbnAplForDisconDataTable_0.IdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_25()
            {
                base[this.tblAbnAplForDisconDataTable_0.IdColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_26()
            {
                return base.IsNull(this.tblAbnAplForDisconDataTable_0.LegalAbnsColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_27()
            {
                base[this.tblAbnAplForDisconDataTable_0.LegalAbnsColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_28()
            {
                return base.IsNull(this.tblAbnAplForDisconDataTable_0.SentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_29()
            {
                base[this.tblAbnAplForDisconDataTable_0.SentColumn] = Convert.DBNull;
            }

            public void method_3(string string_0)
            {
                base[this.tblAbnAplForDisconDataTable_0.NetAreaCaptionColumn] = string_0;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconDataTable_0.TypeActionCaptionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'TypeActionCaption' в таблице 'tblAbnAplForDiscon' равно DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.tblAbnAplForDisconDataTable_0.TypeActionCaptionColumn] = string_0;
            }

            public bool method_6()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tblAbnAplForDisconDataTable_0.LegalAbnsColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'LegalAbns' в таблице 'tblAbnAplForDiscon' равно DBNull.", exception);
                }
                return flag;
            }

            public void method_7(bool bool_0)
            {
                base[this.tblAbnAplForDisconDataTable_0.LegalAbnsColumn] = bool_0;
            }

            public DateTime method_8()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tblAbnAplForDisconDataTable_0.SentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Sent' в таблице 'tblAbnAplForDiscon' равно DBNull.", exception);
                }
                return time;
            }

            public void method_9(DateTime dateTime_0)
            {
                base[this.tblAbnAplForDisconDataTable_0.SentColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime DateAction
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tblAbnAplForDisconDataTable_0.DateActionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateAction' в таблице 'tblAbnAplForDiscon' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblAbnAplForDisconDataTable_0.DateActionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime DateAppl
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tblAbnAplForDisconDataTable_0.DateApplColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateAppl' в таблице 'tblAbnAplForDiscon' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblAbnAplForDisconDataTable_0.DateApplColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Id
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconDataTable_0.IdColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Id' в таблице 'tblAbnAplForDiscon' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconDataTable_0.IdColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int NetArea
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconDataTable_0.NetAreaColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'NetArea' в таблице 'tblAbnAplForDiscon' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconDataTable_0.NetAreaColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int TypeAction
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconDataTable_0.TypeActionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'TypeAction' в таблице 'tblAbnAplForDiscon' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconDataTable_0.TypeActionColumn] = value;
                }
            }
        }

        public class Class411 : DataRow
        {
            private OrgDataSet.tblAbnAplForDisconObjectsDataTable tblAbnAplForDisconObjectsDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class411(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tblAbnAplForDisconObjectsDataTable_0 = (OrgDataSet.tblAbnAplForDisconObjectsDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnAplForDisconObjectsDataTable_0.IdAplForDisconColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'IdAplForDiscon' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.IdAplForDisconColumn] = int_0;
            }

            public DateTime method_10()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tblAbnAplForDisconObjectsDataTable_0.DateExecColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'DateExec' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return time;
            }

            public void method_11(DateTime dateTime_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.DateExecColumn] = dateTime_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnAplForDisconObjectsDataTable_0.FIOExecColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'FIOExec' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.FIOExecColumn] = int_0;
            }

            public string method_14()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconObjectsDataTable_0.ReasonFailureColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'ReasonFailure' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return str;
            }

            public void method_15(string string_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.ReasonFailureColumn] = string_0;
            }

            public int method_16()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnAplForDisconObjectsDataTable_0.NetAreaExecColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NetAreaExec' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return num;
            }

            public void method_17(int int_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.NetAreaExecColumn] = int_0;
            }

            public string method_18()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconObjectsDataTable_0.OfficerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Officer' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return str;
            }

            public void method_19(string string_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.OfficerColumn] = string_0;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnAplForDisconObjectsDataTable_0.AbnIdColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'AbnId' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return num;
            }

            public string method_20()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconObjectsDataTable_0.ReasonCaptionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'ReasonCaption' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return str;
            }

            public void method_21(string string_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.ReasonCaptionColumn] = string_0;
            }

            public string method_22()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconObjectsDataTable_0.CancelAplNumDocColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'CancelAplNumDoc' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return str;
            }

            public void method_23(string string_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.CancelAplNumDocColumn] = string_0;
            }

            public string method_24()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconObjectsDataTable_0.NetAreaExecDescriptionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NetAreaExecDescription' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return str;
            }

            public void method_25(string string_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.NetAreaExecDescriptionColumn] = string_0;
            }

            public string method_26()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconObjectsDataTable_0.FIOWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'FIOWorker' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return str;
            }

            public void method_27(string string_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.FIOWorkerColumn] = string_0;
            }

            public bool method_28()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tblAbnAplForDisconObjectsDataTable_0.MatrixColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Matrix' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return flag;
            }

            public void method_29(bool bool_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.MatrixColumn] = bool_0;
            }

            public void method_3(int int_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.AbnIdColumn] = int_0;
            }

            public DateTime method_30()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tblAbnAplForDisconObjectsDataTable_0.SentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Sent' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return time;
            }

            public void method_31(DateTime dateTime_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.SentColumn] = dateTime_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_32()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.IdColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_33()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.IdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_34()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.IdAplForDisconColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_35()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.IdAplForDisconColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_36()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.AbnIdColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_37()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.AbnIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_38()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.AbnObjIdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_39()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.AbnObjIdColumn] = Convert.DBNull;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnAplForDisconObjectsDataTable_0.AbnObjIdColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'AbnObjId' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_40()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.PlaceIdColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_41()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.PlaceIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.ReasonColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_43()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.ReasonColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_44()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.CommentsColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_45()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.CommentsColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_46()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.DateDogColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_47()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.DateDogColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_48()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.CodeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_49()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.CodeColumn] = Convert.DBNull;
            }

            public void method_5(int int_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.AbnObjIdColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.NameShortColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.NameShortColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_52()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.AbnObjColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_53()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.AbnObjColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_54()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.IdCancelAplColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_55()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.IdCancelAplColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_56()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.DateExecColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_57()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.DateExecColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_58()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.FIOExecColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_59()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.FIOExecColumn] = Convert.DBNull;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconObjectsDataTable_0.AbnObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'AbnObj' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return str;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_60()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.ReasonFailureColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_61()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.ReasonFailureColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_62()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.NetAreaExecColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_63()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.NetAreaExecColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_64()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.OfficerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_65()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.OfficerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_66()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.ReasonCaptionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_67()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.ReasonCaptionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_68()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.CancelAplNumDocColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_69()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.CancelAplNumDocColumn] = Convert.DBNull;
            }

            public void method_7(string string_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.AbnObjColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_70()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.NetAreaExecDescriptionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_71()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.NetAreaExecDescriptionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_72()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.FIOWorkerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_73()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.FIOWorkerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_74()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.NoDogAbnColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_75()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.NoDogAbnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_76()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.NoDogObjColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_77()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.NoDogObjColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_78()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.MatrixColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_79()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.MatrixColumn] = Convert.DBNull;
            }

            public int method_8()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnAplForDisconObjectsDataTable_0.IdCancelAplColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'IdCancelApl' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_80()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.DateApplColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_81()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.DateApplColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_82()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.TypeActionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_83()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.TypeActionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_84()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.NetAreaColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_85()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.NetAreaColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_86()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.DateActionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_87()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.DateActionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_88()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.SentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_89()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.SentColumn] = Convert.DBNull;
            }

            public void method_9(int int_0)
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.IdCancelAplColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_90()
            {
                return base.IsNull(this.tblAbnAplForDisconObjectsDataTable_0.IsFullRestrictionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_91()
            {
                base[this.tblAbnAplForDisconObjectsDataTable_0.IsFullRestrictionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Code
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconObjectsDataTable_0.CodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Code' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.CodeColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnAplForDisconObjectsDataTable_0.CommentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Comments' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.CommentsColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime DateAction
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tblAbnAplForDisconObjectsDataTable_0.DateActionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateAction' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.DateActionColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime DateAppl
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tblAbnAplForDisconObjectsDataTable_0.DateApplColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateAppl' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.DateApplColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime DateDog
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tblAbnAplForDisconObjectsDataTable_0.DateDogColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateDog' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.DateDogColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Id
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconObjectsDataTable_0.IdColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Id' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.IdColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsFullRestriction
            {
                get
                {
                    bool flag;
                    try
                    {
                        flag = (bool) base[this.tblAbnAplForDisconObjectsDataTable_0.IsFullRestrictionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'IsFullRestriction' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return flag;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.IsFullRestrictionColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string NameShort
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnAplForDisconObjectsDataTable_0.NameShortColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'NameShort' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.NameShortColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int NetArea
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconObjectsDataTable_0.NetAreaColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'NetArea' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.NetAreaColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string NoDogAbn
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnAplForDisconObjectsDataTable_0.NoDogAbnColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'NoDogAbn' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.NoDogAbnColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string NoDogObj
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnAplForDisconObjectsDataTable_0.NoDogObjColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'NoDogObj' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.NoDogObjColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string PlaceId
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnAplForDisconObjectsDataTable_0.PlaceIdColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'PlaceId' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.PlaceIdColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Reason
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconObjectsDataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Reason' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.ReasonColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int TypeAction
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconObjectsDataTable_0.TypeActionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'TypeAction' в таблице 'tblAbnAplForDisconObjects' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconObjectsDataTable_0.TypeActionColumn] = value;
                }
            }
        }

        public class Class412 : DataRow
        {
            private OrgDataSet.tblAbnAplForDisconReasonDataTable tblAbnAplForDisconReasonDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class412(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tblAbnAplForDisconReasonDataTable_0 = (OrgDataSet.tblAbnAplForDisconReasonDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnAplForDisconReasonDataTable_0.IdTypeAplColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'IdTypeApl' в таблице 'tblAbnAplForDisconReason' равно DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tblAbnAplForDisconReasonDataTable_0.IdTypeAplColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_2()
            {
                return base.IsNull(this.tblAbnAplForDisconReasonDataTable_0.IdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_3()
            {
                base[this.tblAbnAplForDisconReasonDataTable_0.IdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_4()
            {
                return base.IsNull(this.tblAbnAplForDisconReasonDataTable_0.ReasonColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5()
            {
                base[this.tblAbnAplForDisconReasonDataTable_0.ReasonColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_6()
            {
                return base.IsNull(this.tblAbnAplForDisconReasonDataTable_0.IdTypeAplColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.tblAbnAplForDisconReasonDataTable_0.IdTypeAplColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Id
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconReasonDataTable_0.IdColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Id' в таблице 'tblAbnAplForDisconReason' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconReasonDataTable_0.IdColumn] = value;
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
                        str = (string) base[this.tblAbnAplForDisconReasonDataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Reason' в таблице 'tblAbnAplForDisconReason' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplForDisconReasonDataTable_0.ReasonColumn] = value;
                }
            }
        }

        public class Class413 : DataRow
        {
            private OrgDataSet.tblAbnObjDataTable tblAbnObjDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class413(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tblAbnObjDataTable_0 = (OrgDataSet.tblAbnObjDataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnObjDataTable_0.TitleColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Title' в таблице 'tblAbnObj' равно DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.tblAbnObjDataTable_0.TitleColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_10()
            {
                return base.IsNull(this.tblAbnObjDataTable_0.ObjIdColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.tblAbnObjDataTable_0.ObjIdColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_12()
            {
                return base.IsNull(this.tblAbnObjDataTable_0.PointColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.tblAbnObjDataTable_0.PointColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.tblAbnObjDataTable_0.AbnIDColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.tblAbnObjDataTable_0.AbnIDColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.tblAbnObjDataTable_0.LabelColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.tblAbnObjDataTable_0.LabelColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.tblAbnObjDataTable_0.ReasonColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.tblAbnObjDataTable_0.ReasonColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnObjDataTable_0.ObjIdColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'ObjId' в таблице 'tblAbnObj' равно DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.tblAbnObjDataTable_0.CommentsColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.tblAbnObjDataTable_0.CommentsColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_22()
            {
                return base.IsNull(this.tblAbnObjDataTable_0.IsFullRestrictionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.tblAbnObjDataTable_0.IsFullRestrictionColumn] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.tblAbnObjDataTable_0.ObjIdColumn] = int_0;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnObjDataTable_0.AbnIDColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'AbnID' в таблице 'tblAbnObj' равно DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.tblAbnObjDataTable_0.AbnIDColumn] = int_0;
            }

            public bool method_6()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tblAbnObjDataTable_0.LabelColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Label' в таблице 'tblAbnObj' равно DBNull.", exception);
                }
                return flag;
            }

            public void method_7(bool bool_0)
            {
                base[this.tblAbnObjDataTable_0.LabelColumn] = bool_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.tblAbnObjDataTable_0.TitleColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_9()
            {
                base[this.tblAbnObjDataTable_0.TitleColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnObjDataTable_0.CommentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Comments' в таблице 'tblAbnObj' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnObjDataTable_0.CommentsColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsFullRestriction
            {
                get
                {
                    bool flag;
                    try
                    {
                        flag = (bool) base[this.tblAbnObjDataTable_0.IsFullRestrictionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'IsFullRestriction' в таблице 'tblAbnObj' равно DBNull.", exception);
                    }
                    return flag;
                }
                set
                {
                    base[this.tblAbnObjDataTable_0.IsFullRestrictionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Point
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnObjDataTable_0.PointColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Point' в таблице 'tblAbnObj' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnObjDataTable_0.PointColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Reason
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnObjDataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Reason' в таблице 'tblAbnObj' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnObjDataTable_0.ReasonColumn] = value;
                }
            }
        }

        public class Class414 : DataRow
        {
            private OrgDataSet.tblAbnDataTable tblAbnDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class414(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tblAbnDataTable_0 = (OrgDataSet.tblAbnDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnDataTable_0.AbnIDColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'AbnID' в таблице 'tblAbn' равно DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tblAbnDataTable_0.AbnIDColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_2()
            {
                return base.IsNull(this.tblAbnDataTable_0.AbnIDColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_3()
            {
                base[this.tblAbnDataTable_0.AbnIDColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_4()
            {
                return base.IsNull(this.tblAbnDataTable_0.NameShortColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5()
            {
                base[this.tblAbnDataTable_0.NameShortColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_6()
            {
                return base.IsNull(this.tblAbnDataTable_0.DateDogColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.tblAbnDataTable_0.DateDogColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.tblAbnDataTable_0.CodeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.tblAbnDataTable_0.CodeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Code
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnDataTable_0.CodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Code' в таблице 'tblAbn' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnDataTable_0.CodeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime DateDog
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tblAbnDataTable_0.DateDogColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateDog' в таблице 'tblAbn' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblAbnDataTable_0.DateDogColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string NameShort
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnDataTable_0.NameShortColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'NameShort' в таблице 'tblAbn' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnDataTable_0.NameShortColumn] = value;
                }
            }
        }

        public class Class415 : DataRow
        {
            private OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable tblAbnAplForDisconIndividualUsersDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class415(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tblAbnAplForDisconIndividualUsersDataTable_0 = (OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IdAplForDisconColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'IdAplForDiscon' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IdAplForDisconColumn] = int_0;
            }

            public int method_10()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.FioExecColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'FioExec' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return num;
            }

            public void method_11(int int_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.FioExecColumn] = int_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.NetAreaExecColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NetAreaExec' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.NetAreaExecColumn] = int_0;
            }

            public string method_14()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.ReasonFailureColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'ReasonFailure' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return str;
            }

            public void method_15(string string_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.ReasonFailureColumn] = string_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.ReasonCaptionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'ReasonCaption' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.ReasonCaptionColumn] = string_0;
            }

            public string method_18()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.CancelAplNumColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'CancelAplNum' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return str;
            }

            public void method_19(string string_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.CancelAplNumColumn] = string_0;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IdAbnColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'IdAbn' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return num;
            }

            public string method_20()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.NetAreaExecDescriptionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NetAreaExecDescription' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return str;
            }

            public void method_21(string string_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.NetAreaExecDescriptionColumn] = string_0;
            }

            public string method_22()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.FIOWorkerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'FIOWorker' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return str;
            }

            public void method_23(string string_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.FIOWorkerColumn] = string_0;
            }

            public bool method_24()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.MatrixColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Matrix' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return flag;
            }

            public void method_25(bool bool_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.MatrixColumn] = bool_0;
            }

            public DateTime method_26()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.SentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Sent' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return time;
            }

            public void method_27(DateTime dateTime_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.SentColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_28()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.IdColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_29()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IdColumn] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IdAbnColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_30()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.FIOColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.FIOColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_32()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.AddressColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_33()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.AddressColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_34()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.PlaceIdColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_35()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.PlaceIdColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_36()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.ReasonColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_37()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.ReasonColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_38()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.IdAplForDisconColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_39()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IdAplForDisconColumn] = Convert.DBNull;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IdCancelAplColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'IdCancelApl' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return num;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_40()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.CommentsColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_41()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.CommentsColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.IsNCColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_43()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IsNCColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_44()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.IdAbnColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_45()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IdAbnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_46()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.CodeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_47()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.CodeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_48()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.DateDogColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_49()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.DateDogColumn] = Convert.DBNull;
            }

            public void method_5(int int_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IdCancelAplColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.IdCancelAplColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IdCancelAplColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_52()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.PointColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_53()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.PointColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_54()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.OfficerColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_55()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.OfficerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.DateExecColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_57()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.DateExecColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_58()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.FioExecColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_59()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.FioExecColumn] = Convert.DBNull;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.OfficerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Officer' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_60()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.NetAreaExecColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_61()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.NetAreaExecColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_62()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.ReasonFailureColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_63()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.ReasonFailureColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_64()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.ReasonCaptionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_65()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.ReasonCaptionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_66()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.CancelAplNumColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_67()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.CancelAplNumColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_68()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.NetAreaExecDescriptionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_69()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.NetAreaExecDescriptionColumn] = Convert.DBNull;
            }

            public void method_7(string string_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.OfficerColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_70()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.FIOWorkerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_71()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.FIOWorkerColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_72()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.MatrixColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_73()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.MatrixColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_74()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.SentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_75()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.SentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_76()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.DateActionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_77()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.DateActionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_78()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.TypeActionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_79()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.TypeActionColumn] = Convert.DBNull;
            }

            public DateTime method_8()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.DateExecColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'DateExec' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                }
                return time;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_80()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.NetAreaColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_81()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.NetAreaColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_82()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.DateApplColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_83()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.DateApplColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_84()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersDataTable_0.IsFullRestrictionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_85()
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IsFullRestrictionColumn] = Convert.DBNull;
            }

            public void method_9(DateTime dateTime_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersDataTable_0.DateExecColumn] = dateTime_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Address
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.AddressColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Address' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.AddressColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Code
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.CodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Code' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.CodeColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.CommentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Comments' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.CommentsColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime DateAction
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.DateActionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateAction' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.DateActionColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime DateAppl
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.DateApplColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateAppl' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.DateApplColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime DateDog
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.DateDogColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateDog' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.DateDogColumn] = value;
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
                        str = (string) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.FIOColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'FIO' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.FIOColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Id
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IdColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Id' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IdColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsFullRestriction
            {
                get
                {
                    bool flag;
                    try
                    {
                        flag = (bool) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IsFullRestrictionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'IsFullRestriction' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return flag;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IsFullRestrictionColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsNC
            {
                get
                {
                    bool flag;
                    try
                    {
                        flag = (bool) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IsNCColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'IsNC' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return flag;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.IsNCColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int NetArea
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.NetAreaColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'NetArea' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.NetAreaColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int PlaceId
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.PlaceIdColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'PlaceId' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.PlaceIdColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Point
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.PointColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Point' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.PointColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Reason
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Reason' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.ReasonColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int TypeAction
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconIndividualUsersDataTable_0.TypeActionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'TypeAction' в таблице 'tblAbnAplForDisconIndividualUsers' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersDataTable_0.TypeActionColumn] = value;
                }
            }
        }

        public class Class416 : DataRow
        {
            private OrgDataSet.tAbonentDataTable tAbonentDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class416(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tAbonentDataTable_0 = (OrgDataSet.tAbonentDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tAbonentDataTable_0.CodeAbonentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'CodeAbonent' в таблице 'tAbonent' равно DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tAbonentDataTable_0.CodeAbonentColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.tAbonentDataTable_0.AddressColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_11()
            {
                base[this.tAbonentDataTable_0.AddressColumn] = Convert.DBNull;
            }

            public DateTime method_2()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tAbonentDataTable_0.StartDateColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'StartDate' в таблице 'tAbonent' равно DBNull.", exception);
                }
                return time;
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.tAbonentDataTable_0.StartDateColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_4()
            {
                return base.IsNull(this.tAbonentDataTable_0.CodeAbonentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5()
            {
                base[this.tAbonentDataTable_0.CodeAbonentColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_6()
            {
                return base.IsNull(this.tAbonentDataTable_0.StartDateColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.tAbonentDataTable_0.StartDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.tAbonentDataTable_0.FIOColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_9()
            {
                base[this.tAbonentDataTable_0.FIOColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Address
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tAbonentDataTable_0.AddressColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Address' в таблице 'tAbonent' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tAbonentDataTable_0.AddressColumn] = value;
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
                        str = (string) base[this.tAbonentDataTable_0.FIOColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'FIO' в таблице 'tAbonent' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tAbonentDataTable_0.FIOColumn] = value;
                }
            }
        }

        public class Class417 : DataRow
        {
            private OrgDataSet.tblAbnObj1DataTable tblAbnObj1DataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class417(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tblAbnObj1DataTable_0 = (OrgDataSet.tblAbnObj1DataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnObj1DataTable_0.TitleColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Title' в таблице 'tblAbnObj1' равно DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.tblAbnObj1DataTable_0.TitleColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_10()
            {
                return base.IsNull(this.tblAbnObj1DataTable_0.PointColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.tblAbnObj1DataTable_0.PointColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.tblAbnObj1DataTable_0.LabelColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_13()
            {
                base[this.tblAbnObj1DataTable_0.LabelColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.tblAbnObj1DataTable_0.ReasonColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.tblAbnObj1DataTable_0.ReasonColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.tblAbnObj1DataTable_0.idPointColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_17()
            {
                base[this.tblAbnObj1DataTable_0.idPointColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.tblAbnObj1DataTable_0.CommentsColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.tblAbnObj1DataTable_0.CommentsColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                return (int) base[this.tblAbnObj1DataTable_0.ObjIdColumn];
            }

            public void method_3(int int_0)
            {
                base[this.tblAbnObj1DataTable_0.ObjIdColumn] = int_0;
            }

            public bool method_4()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tblAbnObj1DataTable_0.LabelColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Label' в таблице 'tblAbnObj1' равно DBNull.", exception);
                }
                return flag;
            }

            public void method_5(bool bool_0)
            {
                base[this.tblAbnObj1DataTable_0.LabelColumn] = bool_0;
            }

            public int method_6()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnObj1DataTable_0.idPointColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'idPoint' в таблице 'tblAbnObj1' равно DBNull.", exception);
                }
                return num;
            }

            public void method_7(int int_0)
            {
                base[this.tblAbnObj1DataTable_0.idPointColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_8()
            {
                return base.IsNull(this.tblAbnObj1DataTable_0.TitleColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_9()
            {
                base[this.tblAbnObj1DataTable_0.TitleColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnObj1DataTable_0.CommentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Comments' в таблице 'tblAbnObj1' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnObj1DataTable_0.CommentsColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Point
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnObj1DataTable_0.PointColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Point' в таблице 'tblAbnObj1' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnObj1DataTable_0.PointColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Reason
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnObj1DataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Reason' в таблице 'tblAbnObj1' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnObj1DataTable_0.ReasonColumn] = value;
                }
            }
        }

        public class Class418 : DataRow
        {
            private OrgDataSet.tAbonentNCDataTable tAbonentNCDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class418(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tAbonentNCDataTable_0 = (OrgDataSet.tAbonentNCDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tAbonentNCDataTable_0.CodeAbonentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'CodeAbonent' в таблице 'tAbonentNC' равно DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tAbonentNCDataTable_0.CodeAbonentColumn] = int_0;
            }

            public DateTime method_2()
            {
                return (DateTime) base[this.tAbonentNCDataTable_0.StartDateColumn];
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.tAbonentNCDataTable_0.StartDateColumn] = dateTime_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_4()
            {
                return base.IsNull(this.tAbonentNCDataTable_0.CodeAbonentColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5()
            {
                base[this.tAbonentNCDataTable_0.CodeAbonentColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_6()
            {
                return base.IsNull(this.tAbonentNCDataTable_0.FIOColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_7()
            {
                base[this.tAbonentNCDataTable_0.FIOColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string FIO
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tAbonentNCDataTable_0.FIOColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'FIO' в таблице 'tAbonentNC' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tAbonentNCDataTable_0.FIOColumn] = value;
                }
            }
        }

        public class Class419 : DataRow
        {
            private OrgDataSet.tblAbnAplConnectPointForIndividualUsersDataTable tblAbnAplConnectPointForIndividualUsersDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class419(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tblAbnAplConnectPointForIndividualUsersDataTable_0 = (OrgDataSet.tblAbnAplConnectPointForIndividualUsersDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_0()
            {
                return base.IsNull(this.tblAbnAplConnectPointForIndividualUsersDataTable_0.IdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_1()
            {
                base[this.tblAbnAplConnectPointForIndividualUsersDataTable_0.IdColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_2()
            {
                return base.IsNull(this.tblAbnAplConnectPointForIndividualUsersDataTable_0.PointColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_3()
            {
                base[this.tblAbnAplConnectPointForIndividualUsersDataTable_0.PointColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Id
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplConnectPointForIndividualUsersDataTable_0.IdColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Id' в таблице 'tblAbnAplConnectPointForIndividualUsers' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplConnectPointForIndividualUsersDataTable_0.IdColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Point
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnAplConnectPointForIndividualUsersDataTable_0.PointColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Point' в таблице 'tblAbnAplConnectPointForIndividualUsers' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplConnectPointForIndividualUsersDataTable_0.PointColumn] = value;
                }
            }
        }

        public class Class420 : DataRow
        {
            private OrgDataSet.tblAbnObj2DataTable tblAbnObj2DataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class420(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tblAbnObj2DataTable_0 = (OrgDataSet.tblAbnObj2DataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnObj2DataTable_0.AbnIDColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'AbnID' в таблице 'tblAbnObj2' равно DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tblAbnObj2DataTable_0.AbnIDColumn] = int_0;
            }

            public string method_10()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnObj2DataTable_0.idPointColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'idPoint' в таблице 'tblAbnObj2' равно DBNull.", exception);
                }
                return str;
            }

            public void method_11(string string_0)
            {
                base[this.tblAbnObj2DataTable_0.idPointColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.AbnIDColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.tblAbnObj2DataTable_0.AbnIDColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.TitleColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.tblAbnObj2DataTable_0.TitleColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.ObjIdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.tblAbnObj2DataTable_0.ObjIdColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.DateDogColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.tblAbnObj2DataTable_0.DateDogColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnObj2DataTable_0.TitleColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Title' в таблице 'tblAbnObj2' равно DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.CodeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.tblAbnObj2DataTable_0.CodeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_22()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.NameShortColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.tblAbnObj2DataTable_0.NameShortColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_24()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.LabelColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.tblAbnObj2DataTable_0.LabelColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_26()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.ReasonColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_27()
            {
                base[this.tblAbnObj2DataTable_0.ReasonColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_28()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.CommentsColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_29()
            {
                base[this.tblAbnObj2DataTable_0.CommentsColumn] = Convert.DBNull;
            }

            public void method_3(string string_0)
            {
                base[this.tblAbnObj2DataTable_0.TitleColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_30()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.idPointColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_31()
            {
                base[this.tblAbnObj2DataTable_0.idPointColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_32()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.NoDogAbnColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_33()
            {
                base[this.tblAbnObj2DataTable_0.NoDogAbnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_34()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.NoDogObjColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_35()
            {
                base[this.tblAbnObj2DataTable_0.NoDogObjColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_36()
            {
                return base.IsNull(this.tblAbnObj2DataTable_0.DateActionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_37()
            {
                base[this.tblAbnObj2DataTable_0.DateActionColumn] = Convert.DBNull;
            }

            public int method_4()
            {
                int num;
                try
                {
                    num = (int) base[this.tblAbnObj2DataTable_0.ObjIdColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'ObjId' в таблице 'tblAbnObj2' равно DBNull.", exception);
                }
                return num;
            }

            public void method_5(int int_0)
            {
                base[this.tblAbnObj2DataTable_0.ObjIdColumn] = int_0;
            }

            public int method_6()
            {
                return (int) base[this.tblAbnObj2DataTable_0.CanceledAplIdColumn];
            }

            public void method_7(int int_0)
            {
                base[this.tblAbnObj2DataTable_0.CanceledAplIdColumn] = int_0;
            }

            public bool method_8()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tblAbnObj2DataTable_0.LabelColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Label' в таблице 'tblAbnObj2' равно DBNull.", exception);
                }
                return flag;
            }

            public void method_9(bool bool_0)
            {
                base[this.tblAbnObj2DataTable_0.LabelColumn] = bool_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Code
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnObj2DataTable_0.CodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Code' в таблице 'tblAbnObj2' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnObj2DataTable_0.CodeColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnObj2DataTable_0.CommentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Comments' в таблице 'tblAbnObj2' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnObj2DataTable_0.CommentsColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime DateAction
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tblAbnObj2DataTable_0.DateActionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateAction' в таблице 'tblAbnObj2' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblAbnObj2DataTable_0.DateActionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime DateDog
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tblAbnObj2DataTable_0.DateDogColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateDog' в таблице 'tblAbnObj2' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblAbnObj2DataTable_0.DateDogColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string NameShort
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnObj2DataTable_0.NameShortColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'NameShort' в таблице 'tblAbnObj2' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnObj2DataTable_0.NameShortColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string NoDogAbn
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnObj2DataTable_0.NoDogAbnColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'NoDogAbn' в таблице 'tblAbnObj2' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnObj2DataTable_0.NoDogAbnColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string NoDogObj
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnObj2DataTable_0.NoDogObjColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'NoDogObj' в таблице 'tblAbnObj2' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnObj2DataTable_0.NoDogObjColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Reason
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnObj2DataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Reason' в таблице 'tblAbnObj2' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnObj2DataTable_0.ReasonColumn] = value;
                }
            }
        }

        public class Class421 : DataRow
        {
            private OrgDataSet.tblAbnAplForDisconIndividualUsersForCancelDataTable tblAbnAplForDisconIndividualUsersForCancelDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class421(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0 = (OrgDataSet.tblAbnAplForDisconIndividualUsersForCancelDataTable) base.Table;
            }

            public bool method_0()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.LabelColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Label' в таблице 'tblAbnAplForDisconIndividualUsersForCancel' равно DBNull.", exception);
                }
                return flag;
            }

            public void method_1(bool bool_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.LabelColumn] = bool_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_10()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.PlaceIdColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.PlaceIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.IsNCColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.IsNCColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.CodeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_15()
            {
                base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.CodeColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_16()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.DateDogColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_17()
            {
                base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.DateDogColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.ReasonColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.ReasonColumn] = Convert.DBNull;
            }

            public int method_2()
            {
                return (int) base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.CanceledAplIdColumn];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.LabelColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_21()
            {
                base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.LabelColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_22()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.PlaceColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.PlaceColumn] = Convert.DBNull;
            }

            public void method_3(int int_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.CanceledAplIdColumn] = int_0;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.PlaceColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Place' в таблице 'tblAbnAplForDisconIndividualUsersForCancel' равно DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.PlaceColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_6()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.FIOColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_7()
            {
                base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.FIOColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_8()
            {
                return base.IsNull(this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.AddressColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_9()
            {
                base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.AddressColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Address
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.AddressColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Address' в таблице 'tblAbnAplForDisconIndividualUsersForCancel' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.AddressColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Code
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.CodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Code' в таблице 'tblAbnAplForDisconIndividualUsersForCancel' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.CodeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime DateDog
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.DateDogColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateDog' в таблице 'tblAbnAplForDisconIndividualUsersForCancel' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.DateDogColumn] = value;
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
                        str = (string) base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.FIOColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'FIO' в таблице 'tblAbnAplForDisconIndividualUsersForCancel' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.FIOColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Id
            {
                get
                {
                    return (int) base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.IdColumn];
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.IdColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsNC
            {
                get
                {
                    bool flag;
                    try
                    {
                        flag = (bool) base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.IsNCColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'IsNC' в таблице 'tblAbnAplForDisconIndividualUsersForCancel' равно DBNull.", exception);
                    }
                    return flag;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.IsNCColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int PlaceId
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.PlaceIdColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'PlaceId' в таблице 'tblAbnAplForDisconIndividualUsersForCancel' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.PlaceIdColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Reason
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Reason' в таблице 'tblAbnAplForDisconIndividualUsersForCancel' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tblAbnAplForDisconIndividualUsersForCancelDataTable_0.ReasonColumn] = value;
                }
            }
        }

        public class Class422 : DataRow
        {
            private OrgDataSet.NetAreaDataTable netAreaDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class422(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.netAreaDataTable_0 = (OrgDataSet.NetAreaDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Description
            {
                get
                {
                    return (string) base[this.netAreaDataTable_0.DescriptionColumn];
                }
                set
                {
                    base[this.netAreaDataTable_0.DescriptionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.netAreaDataTable_0.idColumn];
                }
                set
                {
                    base[this.netAreaDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class423 : DataRow
        {
            private OrgDataSet.tR_WorkerDataTable tR_WorkerDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class423(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tR_WorkerDataTable_0 = (OrgDataSet.tR_WorkerDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_0()
            {
                return base.IsNull(this.tR_WorkerDataTable_0.FIOColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_1()
            {
                base[this.tR_WorkerDataTable_0.FIOColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string FIO
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.tR_WorkerDataTable_0.FIOColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'FIO' в таблице 'tR_Worker' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.tR_WorkerDataTable_0.FIOColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tR_WorkerDataTable_0.idColumn];
                }
                set
                {
                    base[this.tR_WorkerDataTable_0.idColumn] = value;
                }
            }
        }

        public class Class424 : DataRow
        {
            private OrgDataSet.Report1DataTableDataTable report1DataTableDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class424(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.report1DataTableDataTable_0 = (OrgDataSet.Report1DataTableDataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.report1DataTableDataTable_0.NumDateDogColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NumDateDog' в таблице 'Report1DataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.report1DataTableDataTable_0.NumDateDogColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_10()
            {
                return base.IsNull(this.report1DataTableDataTable_0.NumDateDogColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_11()
            {
                base[this.report1DataTableDataTable_0.NumDateDogColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_12()
            {
                return base.IsNull(this.report1DataTableDataTable_0.AbnColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.report1DataTableDataTable_0.AbnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_14()
            {
                return base.IsNull(this.report1DataTableDataTable_0.ObjColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.report1DataTableDataTable_0.ObjColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_16()
            {
                return base.IsNull(this.report1DataTableDataTable_0.PointColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.report1DataTableDataTable_0.PointColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.report1DataTableDataTable_0.DateTimeExecutionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.report1DataTableDataTable_0.DateTimeExecutionColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.report1DataTableDataTable_0.AbnColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Abn' в таблице 'Report1DataTable' равно DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.report1DataTableDataTable_0.ReasonColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_21()
            {
                base[this.report1DataTableDataTable_0.ReasonColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_22()
            {
                return base.IsNull(this.report1DataTableDataTable_0.CommentsColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.report1DataTableDataTable_0.CommentsColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_24()
            {
                return base.IsNull(this.report1DataTableDataTable_0.KindRestrictionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.report1DataTableDataTable_0.KindRestrictionColumn] = Convert.DBNull;
            }

            public void method_3(string string_0)
            {
                base[this.report1DataTableDataTable_0.AbnColumn] = string_0;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.report1DataTableDataTable_0.ObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Obj' в таблице 'Report1DataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.report1DataTableDataTable_0.ObjColumn] = string_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.report1DataTableDataTable_0.DateTimeExecutionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'DateTimeExecution' в таблице 'Report1DataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.report1DataTableDataTable_0.DateTimeExecutionColumn] = string_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.report1DataTableDataTable_0.KindRestrictionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'KindRestriction' в таблице 'Report1DataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.report1DataTableDataTable_0.KindRestrictionColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.report1DataTableDataTable_0.CommentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Comments' в таблице 'Report1DataTable' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.report1DataTableDataTable_0.CommentsColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Point
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.report1DataTableDataTable_0.PointColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Point' в таблице 'Report1DataTable' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.report1DataTableDataTable_0.PointColumn] = value;
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
                        str = (string) base[this.report1DataTableDataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Reason' в таблице 'Report1DataTable' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.report1DataTableDataTable_0.ReasonColumn] = value;
                }
            }
        }

        public class Class425 : DataRow
        {
            private OrgDataSet.ODSReportDataTableDataTable odsreportDataTableDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class425(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.odsreportDataTableDataTable_0 = (OrgDataSet.ODSReportDataTableDataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.odsreportDataTableDataTable_0.PlaceColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Place' в таблице 'ODSReportDataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.odsreportDataTableDataTable_0.PlaceColumn] = string_0;
            }

            public string method_10()
            {
                string str;
                try
                {
                    str = (string) base[this.odsreportDataTableDataTable_0.PlanDateColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'PlanDate' в таблице 'ODSReportDataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_11(string string_0)
            {
                base[this.odsreportDataTableDataTable_0.PlanDateColumn] = string_0;
            }

            public string method_12()
            {
                string str;
                try
                {
                    str = (string) base[this.odsreportDataTableDataTable_0.FaktDateColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'FaktDate' в таблице 'ODSReportDataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_13(string string_0)
            {
                base[this.odsreportDataTableDataTable_0.FaktDateColumn] = string_0;
            }

            public string method_14()
            {
                string str;
                try
                {
                    str = (string) base[this.odsreportDataTableDataTable_0.FIOExecColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'FIOExec' в таблице 'ODSReportDataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_15(string string_0)
            {
                base[this.odsreportDataTableDataTable_0.FIOExecColumn] = string_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.odsreportDataTableDataTable_0.NumCancelAplColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NumCancelApl' в таблице 'ODSReportDataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.odsreportDataTableDataTable_0.NumCancelAplColumn] = string_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_18()
            {
                return base.IsNull(this.odsreportDataTableDataTable_0.PlaceColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.odsreportDataTableDataTable_0.PlaceColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.odsreportDataTableDataTable_0.NumAplReasoneColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NumAplReasone' в таблице 'ODSReportDataTable' равно DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.odsreportDataTableDataTable_0.NumAplReasoneColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.odsreportDataTableDataTable_0.NumAplReasoneColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_22()
            {
                return base.IsNull(this.odsreportDataTableDataTable_0.NumDogColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.odsreportDataTableDataTable_0.NumDogColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_24()
            {
                return base.IsNull(this.odsreportDataTableDataTable_0.ObjColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.odsreportDataTableDataTable_0.ObjColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_26()
            {
                return base.IsNull(this.odsreportDataTableDataTable_0.PointColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_27()
            {
                base[this.odsreportDataTableDataTable_0.PointColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_28()
            {
                return base.IsNull(this.odsreportDataTableDataTable_0.TypeAplColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_29()
            {
                base[this.odsreportDataTableDataTable_0.TypeAplColumn] = Convert.DBNull;
            }

            public void method_3(string string_0)
            {
                base[this.odsreportDataTableDataTable_0.NumAplReasoneColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_30()
            {
                return base.IsNull(this.odsreportDataTableDataTable_0.PlanDateColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.odsreportDataTableDataTable_0.PlanDateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_32()
            {
                return base.IsNull(this.odsreportDataTableDataTable_0.FaktDateColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_33()
            {
                base[this.odsreportDataTableDataTable_0.FaktDateColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_34()
            {
                return base.IsNull(this.odsreportDataTableDataTable_0.FIOExecColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_35()
            {
                base[this.odsreportDataTableDataTable_0.FIOExecColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_36()
            {
                return base.IsNull(this.odsreportDataTableDataTable_0.NumCancelAplColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_37()
            {
                base[this.odsreportDataTableDataTable_0.NumCancelAplColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_38()
            {
                return base.IsNull(this.odsreportDataTableDataTable_0.CommentsColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_39()
            {
                base[this.odsreportDataTableDataTable_0.CommentsColumn] = Convert.DBNull;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.odsreportDataTableDataTable_0.NumDogColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NumDog' в таблице 'ODSReportDataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.odsreportDataTableDataTable_0.NumDogColumn] = string_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.odsreportDataTableDataTable_0.ObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Obj' в таблице 'ODSReportDataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.odsreportDataTableDataTable_0.ObjColumn] = string_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.odsreportDataTableDataTable_0.TypeAplColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'TypeApl' в таблице 'ODSReportDataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.odsreportDataTableDataTable_0.TypeAplColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.odsreportDataTableDataTable_0.CommentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Comments' в таблице 'ODSReportDataTable' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.odsreportDataTableDataTable_0.CommentsColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Point
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.odsreportDataTableDataTable_0.PointColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Point' в таблице 'ODSReportDataTable' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.odsreportDataTableDataTable_0.PointColumn] = value;
                }
            }
        }

        public class Class426 : DataRow
        {
            private OrgDataSet.ReportODSDataTable reportODSDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Class426(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.reportODSDataTable_0 = (OrgDataSet.ReportODSDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.reportODSDataTable_0.AbnIdColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'AbnId' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.reportODSDataTable_0.AbnIdColumn] = int_0;
            }

            public string method_10()
            {
                string str;
                try
                {
                    str = (string) base[this.reportODSDataTable_0.TitleColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Title' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return str;
            }

            public void method_11(string string_0)
            {
                base[this.reportODSDataTable_0.TitleColumn] = string_0;
            }

            public string method_12()
            {
                string str;
                try
                {
                    str = (string) base[this.reportODSDataTable_0.NumCancelAplColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NumCancelApl' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return str;
            }

            public void method_13(string string_0)
            {
                base[this.reportODSDataTable_0.NumCancelAplColumn] = string_0;
            }

            public string method_14()
            {
                string str;
                try
                {
                    str = (string) base[this.reportODSDataTable_0.TypeActionCaptionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'TypeActionCaption' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return str;
            }

            public void method_15(string string_0)
            {
                base[this.reportODSDataTable_0.TypeActionCaptionColumn] = string_0;
            }

            public string method_16()
            {
                string str;
                try
                {
                    str = (string) base[this.reportODSDataTable_0.OfficerColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Officer' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return str;
            }

            public void method_17(string string_0)
            {
                base[this.reportODSDataTable_0.OfficerColumn] = string_0;
            }

            public string method_18()
            {
                string str;
                try
                {
                    str = (string) base[this.reportODSDataTable_0.ReasonFailureColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'ReasonFailure' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return str;
            }

            public void method_19(string string_0)
            {
                base[this.reportODSDataTable_0.ReasonFailureColumn] = string_0;
            }

            public int method_2()
            {
                int num;
                try
                {
                    num = (int) base[this.reportODSDataTable_0.AbnObjIdColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'AbnObjId' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return num;
            }

            public string method_20()
            {
                string str;
                try
                {
                    str = (string) base[this.reportODSDataTable_0.NetAreaExecColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NetAreaExec' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return str;
            }

            public void method_21(string string_0)
            {
                base[this.reportODSDataTable_0.NetAreaExecColumn] = string_0;
            }

            public bool method_22()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.reportODSDataTable_0.legalColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'legal' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return flag;
            }

            public void method_23(bool bool_0)
            {
                base[this.reportODSDataTable_0.legalColumn] = bool_0;
            }

            public int method_24()
            {
                int num;
                try
                {
                    num = (int) base[this.reportODSDataTable_0.IdCancelAplColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'IdCancelApl' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return num;
            }

            public void method_25(int int_0)
            {
                base[this.reportODSDataTable_0.IdCancelAplColumn] = int_0;
            }

            public string method_26()
            {
                string str;
                try
                {
                    str = (string) base[this.reportODSDataTable_0.SentColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Sent' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return str;
            }

            public void method_27(string string_0)
            {
                base[this.reportODSDataTable_0.SentColumn] = string_0;
            }

            public bool method_28()
            {
                bool flag;
                try
                {
                    flag = (bool) base[this.reportODSDataTable_0.MatrixColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Matrix' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return flag;
            }

            public void method_29(bool bool_0)
            {
                base[this.reportODSDataTable_0.MatrixColumn] = bool_0;
            }

            public void method_3(int int_0)
            {
                base[this.reportODSDataTable_0.AbnObjIdColumn] = int_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_30()
            {
                return base.IsNull(this.reportODSDataTable_0.AbnIdColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_31()
            {
                base[this.reportODSDataTable_0.AbnIdColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_32()
            {
                return base.IsNull(this.reportODSDataTable_0.AbnObjIdColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_33()
            {
                base[this.reportODSDataTable_0.AbnObjIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_34()
            {
                return base.IsNull(this.reportODSDataTable_0.PlaceIdColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_35()
            {
                base[this.reportODSDataTable_0.PlaceIdColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_36()
            {
                return base.IsNull(this.reportODSDataTable_0.CommentsColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_37()
            {
                base[this.reportODSDataTable_0.CommentsColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_38()
            {
                return base.IsNull(this.reportODSDataTable_0.FIOExecColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_39()
            {
                base[this.reportODSDataTable_0.FIOExecColumn] = Convert.DBNull;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.reportODSDataTable_0.FIOExecColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'FIOExec' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_40()
            {
                return base.IsNull(this.reportODSDataTable_0.DateExecColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_41()
            {
                base[this.reportODSDataTable_0.DateExecColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_42()
            {
                return base.IsNull(this.reportODSDataTable_0.NetAreaColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_43()
            {
                base[this.reportODSDataTable_0.NetAreaColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_44()
            {
                return base.IsNull(this.reportODSDataTable_0.NumDocColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_45()
            {
                base[this.reportODSDataTable_0.NumDocColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_46()
            {
                return base.IsNull(this.reportODSDataTable_0.TypeActionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_47()
            {
                base[this.reportODSDataTable_0.TypeActionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_48()
            {
                return base.IsNull(this.reportODSDataTable_0.IsFullRestrictionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_49()
            {
                base[this.reportODSDataTable_0.IsFullRestrictionColumn] = Convert.DBNull;
            }

            public void method_5(string string_0)
            {
                base[this.reportODSDataTable_0.FIOExecColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_50()
            {
                return base.IsNull(this.reportODSDataTable_0.DateActionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_51()
            {
                base[this.reportODSDataTable_0.DateActionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_52()
            {
                return base.IsNull(this.reportODSDataTable_0.CodeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_53()
            {
                base[this.reportODSDataTable_0.CodeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_54()
            {
                return base.IsNull(this.reportODSDataTable_0.TitleColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_55()
            {
                base[this.reportODSDataTable_0.TitleColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_56()
            {
                return base.IsNull(this.reportODSDataTable_0.AddressColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_57()
            {
                base[this.reportODSDataTable_0.AddressColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_58()
            {
                return base.IsNull(this.reportODSDataTable_0.NumCancelAplColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_59()
            {
                base[this.reportODSDataTable_0.NumCancelAplColumn] = Convert.DBNull;
            }

            public DateTime method_6()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.reportODSDataTable_0.DateExecColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'DateExec' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return time;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_60()
            {
                return base.IsNull(this.reportODSDataTable_0.PointColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_61()
            {
                base[this.reportODSDataTable_0.PointColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_62()
            {
                return base.IsNull(this.reportODSDataTable_0.ReasonColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_63()
            {
                base[this.reportODSDataTable_0.ReasonColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_64()
            {
                return base.IsNull(this.reportODSDataTable_0.TypeActionCaptionColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_65()
            {
                base[this.reportODSDataTable_0.TypeActionCaptionColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_66()
            {
                return base.IsNull(this.reportODSDataTable_0.OfficerColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_67()
            {
                base[this.reportODSDataTable_0.OfficerColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_68()
            {
                return base.IsNull(this.reportODSDataTable_0.ReasonFailureColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_69()
            {
                base[this.reportODSDataTable_0.ReasonFailureColumn] = Convert.DBNull;
            }

            public void method_7(DateTime dateTime_0)
            {
                base[this.reportODSDataTable_0.DateExecColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_70()
            {
                return base.IsNull(this.reportODSDataTable_0.NetAreaExecColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_71()
            {
                base[this.reportODSDataTable_0.NetAreaExecColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_72()
            {
                return base.IsNull(this.reportODSDataTable_0.legalColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_73()
            {
                base[this.reportODSDataTable_0.legalColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_74()
            {
                return base.IsNull(this.reportODSDataTable_0.IdCancelAplColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_75()
            {
                base[this.reportODSDataTable_0.IdCancelAplColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_76()
            {
                return base.IsNull(this.reportODSDataTable_0.SentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_77()
            {
                base[this.reportODSDataTable_0.SentColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_78()
            {
                return base.IsNull(this.reportODSDataTable_0.MatrixColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_79()
            {
                base[this.reportODSDataTable_0.MatrixColumn] = Convert.DBNull;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.reportODSDataTable_0.NumDocColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NumDoc' в таблице 'ReportODS' равно DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.reportODSDataTable_0.NumDocColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Address
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.reportODSDataTable_0.AddressColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Address' в таблице 'ReportODS' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.reportODSDataTable_0.AddressColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Code
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.reportODSDataTable_0.CodeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Code' в таблице 'ReportODS' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.reportODSDataTable_0.CodeColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Comments
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.reportODSDataTable_0.CommentsColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Comments' в таблице 'ReportODS' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.reportODSDataTable_0.CommentsColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DateTime DateAction
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.reportODSDataTable_0.DateActionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'DateAction' в таблице 'ReportODS' равно DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.reportODSDataTable_0.DateActionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string IsFullRestriction
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.reportODSDataTable_0.IsFullRestrictionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'IsFullRestriction' в таблице 'ReportODS' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.reportODSDataTable_0.IsFullRestrictionColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string NetArea
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.reportODSDataTable_0.NetAreaColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'NetArea' в таблице 'ReportODS' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.reportODSDataTable_0.NetAreaColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int PlaceId
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.reportODSDataTable_0.PlaceIdColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'PlaceId' в таблице 'ReportODS' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.reportODSDataTable_0.PlaceIdColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Point
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.reportODSDataTable_0.PointColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Point' в таблице 'ReportODS' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.reportODSDataTable_0.PointColumn] = value;
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
                        str = (string) base[this.reportODSDataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Reason' в таблице 'ReportODS' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.reportODSDataTable_0.ReasonColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int TypeAction
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.reportODSDataTable_0.TypeActionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'TypeAction' в таблице 'ReportODS' равно DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.reportODSDataTable_0.TypeActionColumn] = value;
                }
            }
        }

        public class Class427 : DataRow
        {
            private OrgDataSet.CancelReport1DataTableDataTable cancelReport1DataTableDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class427(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.cancelReport1DataTableDataTable_0 = (OrgDataSet.CancelReport1DataTableDataTable) base.Table;
            }

            public string method_0()
            {
                string str;
                try
                {
                    str = (string) base[this.cancelReport1DataTableDataTable_0.NumDateDogColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'NumDateDog' в таблице 'CancelReport1DataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_1(string string_0)
            {
                base[this.cancelReport1DataTableDataTable_0.NumDateDogColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_10()
            {
                return base.IsNull(this.cancelReport1DataTableDataTable_0.NumDateDogColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_11()
            {
                base[this.cancelReport1DataTableDataTable_0.NumDateDogColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_12()
            {
                return base.IsNull(this.cancelReport1DataTableDataTable_0.AbnColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_13()
            {
                base[this.cancelReport1DataTableDataTable_0.AbnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_14()
            {
                return base.IsNull(this.cancelReport1DataTableDataTable_0.ObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_15()
            {
                base[this.cancelReport1DataTableDataTable_0.ObjColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_16()
            {
                return base.IsNull(this.cancelReport1DataTableDataTable_0.DateTimeExecutionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_17()
            {
                base[this.cancelReport1DataTableDataTable_0.DateTimeExecutionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.cancelReport1DataTableDataTable_0.ReasonColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_19()
            {
                base[this.cancelReport1DataTableDataTable_0.ReasonColumn] = Convert.DBNull;
            }

            public string method_2()
            {
                string str;
                try
                {
                    str = (string) base[this.cancelReport1DataTableDataTable_0.AbnColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Abn' в таблице 'CancelReport1DataTable' равно DBNull.", exception);
                }
                return str;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.cancelReport1DataTableDataTable_0.OldApplColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_21()
            {
                base[this.cancelReport1DataTableDataTable_0.OldApplColumn] = Convert.DBNull;
            }

            public void method_3(string string_0)
            {
                base[this.cancelReport1DataTableDataTable_0.AbnColumn] = string_0;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.cancelReport1DataTableDataTable_0.ObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'Obj' в таблице 'CancelReport1DataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.cancelReport1DataTableDataTable_0.ObjColumn] = string_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.cancelReport1DataTableDataTable_0.DateTimeExecutionColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'DateTimeExecution' в таблице 'CancelReport1DataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.cancelReport1DataTableDataTable_0.DateTimeExecutionColumn] = string_0;
            }

            public string method_8()
            {
                string str;
                try
                {
                    str = (string) base[this.cancelReport1DataTableDataTable_0.OldApplColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("Значение для столбца 'OldAppl' в таблице 'CancelReport1DataTable' равно DBNull.", exception);
                }
                return str;
            }

            public void method_9(string string_0)
            {
                base[this.cancelReport1DataTableDataTable_0.OldApplColumn] = string_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string Reason
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.cancelReport1DataTableDataTable_0.ReasonColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("Значение для столбца 'Reason' в таблице 'CancelReport1DataTable' равно DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.cancelReport1DataTableDataTable_0.ReasonColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate261(object sender, OrgDataSet.EventArgs257 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate262(object sender, OrgDataSet.EventArgs258 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate263(object sender, OrgDataSet.EventArgs259 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate264(object sender, OrgDataSet.EventArgs260 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate265(object sender, OrgDataSet.EventArgs261 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate266(object sender, OrgDataSet.EventArgs262 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate267(object sender, OrgDataSet.EventArgs263 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate268(object sender, OrgDataSet.EventArgs264 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate269(object sender, OrgDataSet.EventArgs265 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate270(object sender, OrgDataSet.EventArgs266 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate271(object sender, OrgDataSet.EventArgs267 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate272(object sender, OrgDataSet.EventArgs268 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate273(object sender, OrgDataSet.EventArgs269 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate274(object sender, OrgDataSet.EventArgs270 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate275(object sender, OrgDataSet.EventArgs271 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate276(object sender, OrgDataSet.EventArgs272 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate277(object sender, OrgDataSet.EventArgs273 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate278(object sender, OrgDataSet.EventArgs274 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs257 : EventArgs
        {
            private OrgDataSet.Class410 class410_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs257(OrgDataSet.Class410 class410_1, DataRowAction dataRowAction_1)
            {
                this.class410_0 = class410_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class410 method_0()
            {
                return this.class410_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs258 : EventArgs
        {
            private OrgDataSet.Class411 class411_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs258(OrgDataSet.Class411 class411_1, DataRowAction dataRowAction_1)
            {
                this.class411_0 = class411_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class411 method_0()
            {
                return this.class411_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs259 : EventArgs
        {
            private OrgDataSet.Class412 class412_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs259(OrgDataSet.Class412 class412_1, DataRowAction dataRowAction_1)
            {
                this.class412_0 = class412_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class412 method_0()
            {
                return this.class412_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs260 : EventArgs
        {
            private OrgDataSet.Class413 class413_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs260(OrgDataSet.Class413 class413_1, DataRowAction dataRowAction_1)
            {
                this.class413_0 = class413_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class413 method_0()
            {
                return this.class413_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs261 : EventArgs
        {
            private OrgDataSet.Class414 class414_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs261(OrgDataSet.Class414 class414_1, DataRowAction dataRowAction_1)
            {
                this.class414_0 = class414_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class414 method_0()
            {
                return this.class414_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs262 : EventArgs
        {
            private OrgDataSet.Class415 class415_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs262(OrgDataSet.Class415 class415_1, DataRowAction dataRowAction_1)
            {
                this.class415_0 = class415_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class415 method_0()
            {
                return this.class415_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs263 : EventArgs
        {
            private OrgDataSet.Class416 class416_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs263(OrgDataSet.Class416 class416_1, DataRowAction dataRowAction_1)
            {
                this.class416_0 = class416_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class416 method_0()
            {
                return this.class416_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs264 : EventArgs
        {
            private OrgDataSet.Class417 class417_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs264(OrgDataSet.Class417 class417_1, DataRowAction dataRowAction_1)
            {
                this.class417_0 = class417_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class417 method_0()
            {
                return this.class417_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs265 : EventArgs
        {
            private OrgDataSet.Class418 class418_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs265(OrgDataSet.Class418 class418_1, DataRowAction dataRowAction_1)
            {
                this.class418_0 = class418_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class418 method_0()
            {
                return this.class418_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs266 : EventArgs
        {
            private OrgDataSet.Class419 class419_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs266(OrgDataSet.Class419 class419_1, DataRowAction dataRowAction_1)
            {
                this.class419_0 = class419_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class419 method_0()
            {
                return this.class419_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs267 : EventArgs
        {
            private OrgDataSet.Class420 class420_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs267(OrgDataSet.Class420 class420_1, DataRowAction dataRowAction_1)
            {
                this.class420_0 = class420_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class420 method_0()
            {
                return this.class420_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs268 : EventArgs
        {
            private OrgDataSet.Class421 class421_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs268(OrgDataSet.Class421 class421_1, DataRowAction dataRowAction_1)
            {
                this.class421_0 = class421_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class421 method_0()
            {
                return this.class421_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs269 : EventArgs
        {
            private OrgDataSet.Class422 class422_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs269(OrgDataSet.Class422 class422_1, DataRowAction dataRowAction_1)
            {
                this.class422_0 = class422_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class422 method_0()
            {
                return this.class422_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs270 : EventArgs
        {
            private OrgDataSet.Class423 class423_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs270(OrgDataSet.Class423 class423_1, DataRowAction dataRowAction_1)
            {
                this.class423_0 = class423_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class423 method_0()
            {
                return this.class423_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs271 : EventArgs
        {
            private OrgDataSet.Class424 class424_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs271(OrgDataSet.Class424 class424_1, DataRowAction dataRowAction_1)
            {
                this.class424_0 = class424_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class424 method_0()
            {
                return this.class424_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs272 : EventArgs
        {
            private OrgDataSet.Class425 class425_0;
            private DataRowAction dataRowAction_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public EventArgs272(OrgDataSet.Class425 class425_1, DataRowAction dataRowAction_1)
            {
                this.class425_0 = class425_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class425 method_0()
            {
                return this.class425_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs273 : EventArgs
        {
            private OrgDataSet.Class426 class426_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs273(OrgDataSet.Class426 class426_1, DataRowAction dataRowAction_1)
            {
                this.class426_0 = class426_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class426 method_0()
            {
                return this.class426_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs274 : EventArgs
        {
            private OrgDataSet.Class427 class427_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs274(OrgDataSet.Class427 class427_1, DataRowAction dataRowAction_1)
            {
                this.class427_0 = class427_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public OrgDataSet.Class427 method_0()
            {
                return this.class427_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class NetAreaDataTable : TypedTableBase<OrgDataSet.Class422>
        {
            private DataColumn columnDescription;
            private DataColumn columnid;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate273 NetAreaRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate273 NetAreaRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate273 NetAreaRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate273 NetAreaRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public NetAreaDataTable()
            {
                base.TableName = "NetArea";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal NetAreaDataTable(DataTable dataTable_0)
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
            protected NetAreaDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.NetAreaDataTable table1 = (OrgDataSet.NetAreaDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.NetAreaDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class422);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(OrgDataSet.Class422 class422_0)
            {
                base.Rows.Add(class422_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class422 method_1(string string_0)
            {
                OrgDataSet.Class422 row = (OrgDataSet.Class422) base.NewRow();
                object[] objArray1 = new object[2];
                objArray1[1] = string_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class422 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (OrgDataSet.Class422) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnDescription = base.Columns["Description"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnDescription = new DataColumn("Description", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDescription);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnDescription.AllowDBNull = false;
                this.columnDescription.MaxLength = 100;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class422 method_5()
            {
                return (OrgDataSet.Class422) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(OrgDataSet.Class422 class422_0)
            {
                base.Rows.Remove(class422_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class422(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.NetAreaRowChanged != null)
                {
                    this.NetAreaRowChanged(this, new OrgDataSet.EventArgs269((OrgDataSet.Class422) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.NetAreaRowChanging != null)
                {
                    this.NetAreaRowChanging(this, new OrgDataSet.EventArgs269((OrgDataSet.Class422) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.NetAreaRowDeleted != null)
                {
                    this.NetAreaRowDeleted(this, new OrgDataSet.EventArgs269((OrgDataSet.Class422) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.NetAreaRowDeleting != null)
                {
                    this.NetAreaRowDeleting(this, new OrgDataSet.EventArgs269((OrgDataSet.Class422) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "NetAreaDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn DescriptionColumn
            {
                get
                {
                    return this.columnDescription;
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
            public OrgDataSet.Class422 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class422) base.Rows[int_0];
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class ODSReportDataTableDataTable : TypedTableBase<OrgDataSet.Class425>
        {
            private DataColumn columnComments;
            private DataColumn columnFaktDate;
            private DataColumn columnFIOExec;
            private DataColumn columnNumAplReasone;
            private DataColumn columnNumCancelApl;
            private DataColumn columnNumDog;
            private DataColumn columnObj;
            private DataColumn columnPlace;
            private DataColumn columnPlanDate;
            private DataColumn columnPoint;
            private DataColumn columnTypeApl;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate276 ODSReportDataTableRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate276 ODSReportDataTableRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate276 ODSReportDataTableRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate276 ODSReportDataTableRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ODSReportDataTableDataTable()
            {
                base.TableName = "ODSReportDataTable";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ODSReportDataTableDataTable(DataTable dataTable_0)
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
            protected ODSReportDataTableDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                OrgDataSet.ODSReportDataTableDataTable table1 = (OrgDataSet.ODSReportDataTableDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.ODSReportDataTableDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class425);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(OrgDataSet.Class425 class425_0)
            {
                base.Rows.Add(class425_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class425 method_1(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10)
            {
                OrgDataSet.Class425 row = (OrgDataSet.Class425) base.NewRow();
                object[] objArray = new object[] { string_0, string_1, string_2, string_3, string_4, string_5, string_6, string_7, string_8, string_9, string_10 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnPlace = base.Columns["Place"];
                this.columnNumAplReasone = base.Columns["NumAplReasone"];
                this.columnNumDog = base.Columns["NumDog"];
                this.columnObj = base.Columns["Obj"];
                this.columnPoint = base.Columns["Point"];
                this.columnTypeApl = base.Columns["TypeApl"];
                this.columnPlanDate = base.Columns["PlanDate"];
                this.columnFaktDate = base.Columns["FaktDate"];
                this.columnFIOExec = base.Columns["FIOExec"];
                this.columnNumCancelApl = base.Columns["NumCancelApl"];
                this.columnComments = base.Columns["Comments"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnPlace = new DataColumn("Place", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPlace);
                this.columnNumAplReasone = new DataColumn("NumAplReasone", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNumAplReasone);
                this.columnNumDog = new DataColumn("NumDog", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNumDog);
                this.columnObj = new DataColumn("Obj", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnObj);
                this.columnPoint = new DataColumn("Point", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPoint);
                this.columnTypeApl = new DataColumn("TypeApl", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTypeApl);
                this.columnPlanDate = new DataColumn("PlanDate", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPlanDate);
                this.columnFaktDate = new DataColumn("FaktDate", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFaktDate);
                this.columnFIOExec = new DataColumn("FIOExec", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFIOExec);
                this.columnNumCancelApl = new DataColumn("NumCancelApl", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNumCancelApl);
                this.columnComments = new DataColumn("Comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComments);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class425 method_4()
            {
                return (OrgDataSet.Class425) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(OrgDataSet.Class425 class425_0)
            {
                base.Rows.Remove(class425_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class425(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.ODSReportDataTableRowChanged != null)
                {
                    this.ODSReportDataTableRowChanged(this, new OrgDataSet.EventArgs272((OrgDataSet.Class425) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.ODSReportDataTableRowChanging != null)
                {
                    this.ODSReportDataTableRowChanging(this, new OrgDataSet.EventArgs272((OrgDataSet.Class425) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.ODSReportDataTableRowDeleted != null)
                {
                    this.ODSReportDataTableRowDeleted(this, new OrgDataSet.EventArgs272((OrgDataSet.Class425) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.ODSReportDataTableRowDeleting != null)
                {
                    this.ODSReportDataTableRowDeleting(this, new OrgDataSet.EventArgs272((OrgDataSet.Class425) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "ODSReportDataTableDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn CommentsColumn
            {
                get
                {
                    return this.columnComments;
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
            public DataColumn FaktDateColumn
            {
                get
                {
                    return this.columnFaktDate;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FIOExecColumn
            {
                get
                {
                    return this.columnFIOExec;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class425 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class425) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NumAplReasoneColumn
            {
                get
                {
                    return this.columnNumAplReasone;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NumCancelAplColumn
            {
                get
                {
                    return this.columnNumCancelApl;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NumDogColumn
            {
                get
                {
                    return this.columnNumDog;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ObjColumn
            {
                get
                {
                    return this.columnObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn PlaceColumn
            {
                get
                {
                    return this.columnPlace;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PlanDateColumn
            {
                get
                {
                    return this.columnPlanDate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PointColumn
            {
                get
                {
                    return this.columnPoint;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TypeAplColumn
            {
                get
                {
                    return this.columnTypeApl;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class Report1DataTableDataTable : TypedTableBase<OrgDataSet.Class424>
        {
            private DataColumn columnAbn;
            private DataColumn columnComments;
            private DataColumn columnDateTimeExecution;
            private DataColumn columnKindRestriction;
            private DataColumn columnNumDateDog;
            private DataColumn columnObj;
            private DataColumn columnPoint;
            private DataColumn columnReason;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate275 Report1DataTableRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate275 Report1DataTableRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate275 Report1DataTableRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate275 Report1DataTableRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public Report1DataTableDataTable()
            {
                base.TableName = "Report1DataTable";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal Report1DataTableDataTable(DataTable dataTable_0)
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
            protected Report1DataTableDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.Report1DataTableDataTable table1 = (OrgDataSet.Report1DataTableDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.Report1DataTableDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class424);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(OrgDataSet.Class424 class424_0)
            {
                base.Rows.Add(class424_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class424 method_1(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6, string string_7)
            {
                OrgDataSet.Class424 row = (OrgDataSet.Class424) base.NewRow();
                object[] objArray = new object[] { string_0, string_1, string_2, string_3, string_4, string_5, string_6, string_7 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnNumDateDog = base.Columns["NumDateDog"];
                this.columnAbn = base.Columns["Abn"];
                this.columnObj = base.Columns["Obj"];
                this.columnPoint = base.Columns["Point"];
                this.columnDateTimeExecution = base.Columns["DateTimeExecution"];
                this.columnReason = base.Columns["Reason"];
                this.columnComments = base.Columns["Comments"];
                this.columnKindRestriction = base.Columns["KindRestriction"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnNumDateDog = new DataColumn("NumDateDog", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNumDateDog);
                this.columnAbn = new DataColumn("Abn", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnAbn);
                this.columnObj = new DataColumn("Obj", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnObj);
                this.columnPoint = new DataColumn("Point", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPoint);
                this.columnDateTimeExecution = new DataColumn("DateTimeExecution", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDateTimeExecution);
                this.columnReason = new DataColumn("Reason", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnComments = new DataColumn("Comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComments);
                this.columnKindRestriction = new DataColumn("KindRestriction", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnKindRestriction);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class424 method_4()
            {
                return (OrgDataSet.Class424) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(OrgDataSet.Class424 class424_0)
            {
                base.Rows.Remove(class424_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class424(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.Report1DataTableRowChanged != null)
                {
                    this.Report1DataTableRowChanged(this, new OrgDataSet.EventArgs271((OrgDataSet.Class424) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.Report1DataTableRowChanging != null)
                {
                    this.Report1DataTableRowChanging(this, new OrgDataSet.EventArgs271((OrgDataSet.Class424) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.Report1DataTableRowDeleted != null)
                {
                    this.Report1DataTableRowDeleted(this, new OrgDataSet.EventArgs271((OrgDataSet.Class424) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.Report1DataTableRowDeleting != null)
                {
                    this.Report1DataTableRowDeleting(this, new OrgDataSet.EventArgs271((OrgDataSet.Class424) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "Report1DataTableDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn AbnColumn
            {
                get
                {
                    return this.columnAbn;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CommentsColumn
            {
                get
                {
                    return this.columnComments;
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
            public DataColumn DateTimeExecutionColumn
            {
                get
                {
                    return this.columnDateTimeExecution;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class424 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class424) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn KindRestrictionColumn
            {
                get
                {
                    return this.columnKindRestriction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NumDateDogColumn
            {
                get
                {
                    return this.columnNumDateDog;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ObjColumn
            {
                get
                {
                    return this.columnObj;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PointColumn
            {
                get
                {
                    return this.columnPoint;
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
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class ReportODSDataTable : TypedTableBase<OrgDataSet.Class426>
        {
            private DataColumn columnAbnId;
            private DataColumn columnAbnObjId;
            private DataColumn columnAddress;
            private DataColumn columnCode;
            private DataColumn columnComments;
            private DataColumn columnDateAction;
            private DataColumn columnDateExec;
            private DataColumn columnFIOExec;
            private DataColumn columnIdCancelApl;
            private DataColumn columnIsFullRestriction;
            private DataColumn columnlegal;
            private DataColumn columnMatrix;
            private DataColumn columnNetArea;
            private DataColumn columnNetAreaExec;
            private DataColumn columnNumCancelApl;
            private DataColumn columnNumDoc;
            private DataColumn columnOfficer;
            private DataColumn columnPlaceId;
            private DataColumn columnPoint;
            private DataColumn columnReason;
            private DataColumn columnReasonFailure;
            private DataColumn columnSent;
            private DataColumn columnTitle;
            private DataColumn columnTypeAction;
            private DataColumn columnTypeActionCaption;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate277 ReportODSRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate277 ReportODSRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate277 ReportODSRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate277 ReportODSRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public ReportODSDataTable()
            {
                base.TableName = "ReportODS";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal ReportODSDataTable(DataTable dataTable_0)
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
            protected ReportODSDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.ReportODSDataTable table1 = (OrgDataSet.ReportODSDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.ReportODSDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class426);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(OrgDataSet.Class426 class426_0)
            {
                base.Rows.Add(class426_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class426 method_1(int int_0, int int_1, int int_2, string string_0, string string_1, DateTime dateTime_0, string string_2, string string_3, int int_3, string string_4, DateTime dateTime_1, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, string string_12, string string_13, string string_14, bool bool_0, int int_4, string string_15, bool bool_1)
            {
                OrgDataSet.Class426 row = (OrgDataSet.Class426) base.NewRow();
                object[] objArray = new object[] { 
                    int_0, int_1, int_2, string_0, string_1, dateTime_0, string_2, string_3, int_3, string_4, dateTime_1, string_5, string_6, string_7, string_8, string_9,
                    string_10, string_11, string_12, string_13, string_14, bool_0, int_4, string_15, bool_1
                };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnAbnId = base.Columns["AbnId"];
                this.columnAbnObjId = base.Columns["AbnObjId"];
                this.columnPlaceId = base.Columns["PlaceId"];
                this.columnComments = base.Columns["Comments"];
                this.columnFIOExec = base.Columns["FIOExec"];
                this.columnDateExec = base.Columns["DateExec"];
                this.columnNetArea = base.Columns["NetArea"];
                this.columnNumDoc = base.Columns["NumDoc"];
                this.columnTypeAction = base.Columns["TypeAction"];
                this.columnIsFullRestriction = base.Columns["IsFullRestriction"];
                this.columnDateAction = base.Columns["DateAction"];
                this.columnCode = base.Columns["Code"];
                this.columnTitle = base.Columns["Title"];
                this.columnAddress = base.Columns["Address"];
                this.columnNumCancelApl = base.Columns["NumCancelApl"];
                this.columnPoint = base.Columns["Point"];
                this.columnReason = base.Columns["Reason"];
                this.columnTypeActionCaption = base.Columns["TypeActionCaption"];
                this.columnOfficer = base.Columns["Officer"];
                this.columnReasonFailure = base.Columns["ReasonFailure"];
                this.columnNetAreaExec = base.Columns["NetAreaExec"];
                this.columnlegal = base.Columns["legal"];
                this.columnIdCancelApl = base.Columns["IdCancelApl"];
                this.columnSent = base.Columns["Sent"];
                this.columnMatrix = base.Columns["Matrix"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnAbnId = new DataColumn("AbnId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnAbnId);
                this.columnAbnObjId = new DataColumn("AbnObjId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnAbnObjId);
                this.columnPlaceId = new DataColumn("PlaceId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnPlaceId);
                this.columnComments = new DataColumn("Comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComments);
                this.columnFIOExec = new DataColumn("FIOExec", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFIOExec);
                this.columnDateExec = new DataColumn("DateExec", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateExec);
                this.columnNetArea = new DataColumn("NetArea", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNetArea);
                this.columnNumDoc = new DataColumn("NumDoc", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNumDoc);
                this.columnTypeAction = new DataColumn("TypeAction", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnTypeAction);
                this.columnIsFullRestriction = new DataColumn("IsFullRestriction", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnIsFullRestriction);
                this.columnDateAction = new DataColumn("DateAction", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateAction);
                this.columnCode = new DataColumn("Code", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnCode);
                this.columnTitle = new DataColumn("Title", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTitle);
                this.columnAddress = new DataColumn("Address", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnAddress);
                this.columnNumCancelApl = new DataColumn("NumCancelApl", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNumCancelApl);
                this.columnPoint = new DataColumn("Point", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPoint);
                this.columnReason = new DataColumn("Reason", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnTypeActionCaption = new DataColumn("TypeActionCaption", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTypeActionCaption);
                this.columnOfficer = new DataColumn("Officer", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnOfficer);
                this.columnReasonFailure = new DataColumn("ReasonFailure", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReasonFailure);
                this.columnNetAreaExec = new DataColumn("NetAreaExec", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNetAreaExec);
                this.columnlegal = new DataColumn("legal", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnlegal);
                this.columnIdCancelApl = new DataColumn("IdCancelApl", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnIdCancelApl);
                this.columnSent = new DataColumn("Sent", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnSent);
                this.columnMatrix = new DataColumn("Matrix", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnMatrix);
                this.columnComments.MaxLength = 0xff;
                this.columnFIOExec.MaxLength = 100;
                this.columnNetArea.DefaultValue = "";
                this.columnTitle.MaxLength = 0xff;
                this.columnAddress.MaxLength = 0xff;
                this.columnNumCancelApl.MaxLength = 10;
                this.columnPoint.MaxLength = 0x100;
                this.columnReason.MaxLength = 100;
                this.columnlegal.DefaultValue = true;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class426 method_4()
            {
                return (OrgDataSet.Class426) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(OrgDataSet.Class426 class426_0)
            {
                base.Rows.Remove(class426_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class426(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.ReportODSRowChanged != null)
                {
                    this.ReportODSRowChanged(this, new OrgDataSet.EventArgs273((OrgDataSet.Class426) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.ReportODSRowChanging != null)
                {
                    this.ReportODSRowChanging(this, new OrgDataSet.EventArgs273((OrgDataSet.Class426) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.ReportODSRowDeleted != null)
                {
                    this.ReportODSRowDeleted(this, new OrgDataSet.EventArgs273((OrgDataSet.Class426) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.ReportODSRowDeleting != null)
                {
                    this.ReportODSRowDeleting(this, new OrgDataSet.EventArgs273((OrgDataSet.Class426) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "ReportODSDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn AbnIdColumn
            {
                get
                {
                    return this.columnAbnId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn AbnObjIdColumn
            {
                get
                {
                    return this.columnAbnObjId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AddressColumn
            {
                get
                {
                    return this.columnAddress;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CodeColumn
            {
                get
                {
                    return this.columnCode;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CommentsColumn
            {
                get
                {
                    return this.columnComments;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateActionColumn
            {
                get
                {
                    return this.columnDateAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateExecColumn
            {
                get
                {
                    return this.columnDateExec;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn FIOExecColumn
            {
                get
                {
                    return this.columnFIOExec;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IdCancelAplColumn
            {
                get
                {
                    return this.columnIdCancelApl;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IsFullRestrictionColumn
            {
                get
                {
                    return this.columnIsFullRestriction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class426 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class426) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn legalColumn
            {
                get
                {
                    return this.columnlegal;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn MatrixColumn
            {
                get
                {
                    return this.columnMatrix;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NetAreaColumn
            {
                get
                {
                    return this.columnNetArea;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NetAreaExecColumn
            {
                get
                {
                    return this.columnNetAreaExec;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NumCancelAplColumn
            {
                get
                {
                    return this.columnNumCancelApl;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NumDocColumn
            {
                get
                {
                    return this.columnNumDoc;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn OfficerColumn
            {
                get
                {
                    return this.columnOfficer;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PlaceIdColumn
            {
                get
                {
                    return this.columnPlaceId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PointColumn
            {
                get
                {
                    return this.columnPoint;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ReasonFailureColumn
            {
                get
                {
                    return this.columnReasonFailure;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn SentColumn
            {
                get
                {
                    return this.columnSent;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TitleColumn
            {
                get
                {
                    return this.columnTitle;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TypeActionCaptionColumn
            {
                get
                {
                    return this.columnTypeActionCaption;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TypeActionColumn
            {
                get
                {
                    return this.columnTypeAction;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tAbonentDataTable : TypedTableBase<OrgDataSet.Class416>
        {
            private DataColumn columnAddress;
            private DataColumn columnCodeAbonent;
            private DataColumn columnFIO;
            private DataColumn columnStartDate;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate267 tAbonentRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate267 tAbonentRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate267 tAbonentRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate267 tAbonentRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tAbonentDataTable()
            {
                base.TableName = "tAbonent";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tAbonentDataTable(DataTable dataTable_0)
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
            protected tAbonentDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.tAbonentDataTable table1 = (OrgDataSet.tAbonentDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tAbonentDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class416);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(OrgDataSet.Class416 class416_0)
            {
                base.Rows.Add(class416_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class416 method_1(int int_0, DateTime dateTime_0, string string_0, string string_1)
            {
                OrgDataSet.Class416 row = (OrgDataSet.Class416) base.NewRow();
                object[] objArray = new object[] { int_0, dateTime_0, string_0, string_1 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnCodeAbonent = base.Columns["CodeAbonent"];
                this.columnStartDate = base.Columns["StartDate"];
                this.columnFIO = base.Columns["FIO"];
                this.columnAddress = base.Columns["Address"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnCodeAbonent = new DataColumn("CodeAbonent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCodeAbonent);
                this.columnStartDate = new DataColumn("StartDate", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnStartDate);
                this.columnFIO = new DataColumn("FIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFIO);
                this.columnAddress = new DataColumn("Address", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnAddress);
                this.columnFIO.MaxLength = 50;
                this.columnAddress.ReadOnly = true;
                this.columnAddress.MaxLength = 0x1af;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class416 method_4()
            {
                return (OrgDataSet.Class416) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(OrgDataSet.Class416 class416_0)
            {
                base.Rows.Remove(class416_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class416(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tAbonentRowChanged != null)
                {
                    this.tAbonentRowChanged(this, new OrgDataSet.EventArgs263((OrgDataSet.Class416) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tAbonentRowChanging != null)
                {
                    this.tAbonentRowChanging(this, new OrgDataSet.EventArgs263((OrgDataSet.Class416) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tAbonentRowDeleted != null)
                {
                    this.tAbonentRowDeleted(this, new OrgDataSet.EventArgs263((OrgDataSet.Class416) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tAbonentRowDeleting != null)
                {
                    this.tAbonentRowDeleting(this, new OrgDataSet.EventArgs263((OrgDataSet.Class416) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tAbonentDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn AddressColumn
            {
                get
                {
                    return this.columnAddress;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CodeAbonentColumn
            {
                get
                {
                    return this.columnCodeAbonent;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FIOColumn
            {
                get
                {
                    return this.columnFIO;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class416 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class416) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn StartDateColumn
            {
                get
                {
                    return this.columnStartDate;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tAbonentNCDataTable : TypedTableBase<OrgDataSet.Class418>
        {
            private DataColumn columnCodeAbonent;
            private DataColumn columnFIO;
            private DataColumn columnStartDate;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate269 tAbonentNCRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate269 tAbonentNCRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate269 tAbonentNCRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate269 tAbonentNCRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tAbonentNCDataTable()
            {
                base.TableName = "tAbonentNC";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tAbonentNCDataTable(DataTable dataTable_0)
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
            protected tAbonentNCDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.tAbonentNCDataTable table1 = (OrgDataSet.tAbonentNCDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tAbonentNCDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class418);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(OrgDataSet.Class418 class418_0)
            {
                base.Rows.Add(class418_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class418 method_1(int int_0, DateTime dateTime_0, string string_0)
            {
                OrgDataSet.Class418 row = (OrgDataSet.Class418) base.NewRow();
                object[] objArray = new object[] { int_0, dateTime_0, string_0 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnCodeAbonent = base.Columns["CodeAbonent"];
                this.columnStartDate = base.Columns["StartDate"];
                this.columnFIO = base.Columns["FIO"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnCodeAbonent = new DataColumn("CodeAbonent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCodeAbonent);
                this.columnStartDate = new DataColumn("StartDate", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnStartDate);
                this.columnFIO = new DataColumn("FIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFIO);
                this.columnStartDate.AllowDBNull = false;
                this.columnFIO.MaxLength = 50;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class418 method_4()
            {
                return (OrgDataSet.Class418) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(OrgDataSet.Class418 class418_0)
            {
                base.Rows.Remove(class418_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class418(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tAbonentNCRowChanged != null)
                {
                    this.tAbonentNCRowChanged(this, new OrgDataSet.EventArgs265((OrgDataSet.Class418) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tAbonentNCRowChanging != null)
                {
                    this.tAbonentNCRowChanging(this, new OrgDataSet.EventArgs265((OrgDataSet.Class418) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tAbonentNCRowDeleted != null)
                {
                    this.tAbonentNCRowDeleted(this, new OrgDataSet.EventArgs265((OrgDataSet.Class418) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tAbonentNCRowDeleting != null)
                {
                    this.tAbonentNCRowDeleting(this, new OrgDataSet.EventArgs265((OrgDataSet.Class418) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tAbonentNCDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn CodeAbonentColumn
            {
                get
                {
                    return this.columnCodeAbonent;
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn FIOColumn
            {
                get
                {
                    return this.columnFIO;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class418 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class418) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn StartDateColumn
            {
                get
                {
                    return this.columnStartDate;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblAbnAplConnectPointForIndividualUsersDataTable : TypedTableBase<OrgDataSet.Class419>
        {
            private DataColumn columnId;
            private DataColumn columnPoint;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate270 tblAbnAplConnectPointForIndividualUsersRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate270 tblAbnAplConnectPointForIndividualUsersRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate270 tblAbnAplConnectPointForIndividualUsersRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate270 tblAbnAplConnectPointForIndividualUsersRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tblAbnAplConnectPointForIndividualUsersDataTable()
            {
                base.TableName = "tblAbnAplConnectPointForIndividualUsers";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tblAbnAplConnectPointForIndividualUsersDataTable(DataTable dataTable_0)
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
            protected tblAbnAplConnectPointForIndividualUsersDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.tblAbnAplConnectPointForIndividualUsersDataTable table1 = (OrgDataSet.tblAbnAplConnectPointForIndividualUsersDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tblAbnAplConnectPointForIndividualUsersDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class419);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(OrgDataSet.Class419 class419_0)
            {
                base.Rows.Add(class419_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class419 method_1(int int_0, string string_0)
            {
                OrgDataSet.Class419 row = (OrgDataSet.Class419) base.NewRow();
                object[] objArray = new object[] { int_0, string_0 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnId = base.Columns["Id"];
                this.columnPoint = base.Columns["Point"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnId);
                this.columnPoint = new DataColumn("Point", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPoint);
                this.columnId.AutoIncrementSeed = -1L;
                this.columnId.AutoIncrementStep = -1L;
                this.columnPoint.MaxLength = 0xff;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class419 method_4()
            {
                return (OrgDataSet.Class419) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(OrgDataSet.Class419 class419_0)
            {
                base.Rows.Remove(class419_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class419(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tblAbnAplConnectPointForIndividualUsersRowChanged != null)
                {
                    this.tblAbnAplConnectPointForIndividualUsersRowChanged(this, new OrgDataSet.EventArgs266((OrgDataSet.Class419) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tblAbnAplConnectPointForIndividualUsersRowChanging != null)
                {
                    this.tblAbnAplConnectPointForIndividualUsersRowChanging(this, new OrgDataSet.EventArgs266((OrgDataSet.Class419) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tblAbnAplConnectPointForIndividualUsersRowDeleted != null)
                {
                    this.tblAbnAplConnectPointForIndividualUsersRowDeleted(this, new OrgDataSet.EventArgs266((OrgDataSet.Class419) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tblAbnAplConnectPointForIndividualUsersRowDeleting != null)
                {
                    this.tblAbnAplConnectPointForIndividualUsersRowDeleting(this, new OrgDataSet.EventArgs266((OrgDataSet.Class419) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tblAbnAplConnectPointForIndividualUsersDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IdColumn
            {
                get
                {
                    return this.columnId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class419 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class419) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PointColumn
            {
                get
                {
                    return this.columnPoint;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblAbnAplForDisconDataTable : TypedTableBase<OrgDataSet.Class410>
        {
            private DataColumn columnDateAction;
            private DataColumn columnDateAppl;
            private DataColumn columnId;
            private DataColumn columnLegalAbns;
            private DataColumn columnNetArea;
            private DataColumn columnNetAreaCaption;
            private DataColumn columnNumDoc;
            private DataColumn columnSent;
            private DataColumn columnTypeAction;
            private DataColumn columnTypeActionCaption;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate261 tblAbnAplForDisconRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate261 tblAbnAplForDisconRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate261 tblAbnAplForDisconRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate261 tblAbnAplForDisconRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tblAbnAplForDisconDataTable()
            {
                base.TableName = "tblAbnAplForDiscon";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tblAbnAplForDisconDataTable(DataTable dataTable_0)
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
            protected tblAbnAplForDisconDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.tblAbnAplForDisconDataTable table1 = (OrgDataSet.tblAbnAplForDisconDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tblAbnAplForDisconDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class410);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(OrgDataSet.Class410 class410_0)
            {
                base.Rows.Add(class410_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class410 method_1(string string_0, int int_0, int int_1, DateTime dateTime_0, DateTime dateTime_1, string string_1, string string_2, int int_2, bool bool_0, DateTime dateTime_2)
            {
                OrgDataSet.Class410 row = (OrgDataSet.Class410) base.NewRow();
                object[] objArray = new object[] { string_0, int_0, int_1, dateTime_0, dateTime_1, string_1, string_2, int_2, bool_0, dateTime_2 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnNumDoc = base.Columns["NumDoc"];
                this.columnNetArea = base.Columns["NetArea"];
                this.columnTypeAction = base.Columns["TypeAction"];
                this.columnDateAppl = base.Columns["DateAppl"];
                this.columnDateAction = base.Columns["DateAction"];
                this.columnNetAreaCaption = base.Columns["NetAreaCaption"];
                this.columnTypeActionCaption = base.Columns["TypeActionCaption"];
                this.columnId = base.Columns["Id"];
                this.columnLegalAbns = base.Columns["LegalAbns"];
                this.columnSent = base.Columns["Sent"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnNumDoc = new DataColumn("NumDoc", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNumDoc);
                this.columnNetArea = new DataColumn("NetArea", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnNetArea);
                this.columnTypeAction = new DataColumn("TypeAction", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnTypeAction);
                this.columnDateAppl = new DataColumn("DateAppl", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateAppl);
                this.columnDateAction = new DataColumn("DateAction", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateAction);
                this.columnNetAreaCaption = new DataColumn("NetAreaCaption", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNetAreaCaption);
                this.columnTypeActionCaption = new DataColumn("TypeActionCaption", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTypeActionCaption);
                this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnId);
                this.columnLegalAbns = new DataColumn("LegalAbns", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnLegalAbns);
                this.columnSent = new DataColumn("Sent", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnSent);
                this.columnNumDoc.MaxLength = 10;
                this.columnId.AutoIncrementSeed = -1L;
                this.columnId.AutoIncrementStep = -1L;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class410 method_4()
            {
                return (OrgDataSet.Class410) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(OrgDataSet.Class410 class410_0)
            {
                base.Rows.Remove(class410_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class410(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconRowChanged != null)
                {
                    this.tblAbnAplForDisconRowChanged(this, new OrgDataSet.EventArgs257((OrgDataSet.Class410) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconRowChanging != null)
                {
                    this.tblAbnAplForDisconRowChanging(this, new OrgDataSet.EventArgs257((OrgDataSet.Class410) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconRowDeleted != null)
                {
                    this.tblAbnAplForDisconRowDeleted(this, new OrgDataSet.EventArgs257((OrgDataSet.Class410) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconRowDeleting != null)
                {
                    this.tblAbnAplForDisconRowDeleting(this, new OrgDataSet.EventArgs257((OrgDataSet.Class410) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tblAbnAplForDisconDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateActionColumn
            {
                get
                {
                    return this.columnDateAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateApplColumn
            {
                get
                {
                    return this.columnDateAppl;
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
            public OrgDataSet.Class410 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class410) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LegalAbnsColumn
            {
                get
                {
                    return this.columnLegalAbns;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NetAreaCaptionColumn
            {
                get
                {
                    return this.columnNetAreaCaption;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NetAreaColumn
            {
                get
                {
                    return this.columnNetArea;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NumDocColumn
            {
                get
                {
                    return this.columnNumDoc;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn SentColumn
            {
                get
                {
                    return this.columnSent;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TypeActionCaptionColumn
            {
                get
                {
                    return this.columnTypeActionCaption;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn TypeActionColumn
            {
                get
                {
                    return this.columnTypeAction;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblAbnAplForDisconIndividualUsersDataTable : TypedTableBase<OrgDataSet.Class415>
        {
            private DataColumn columnAddress;
            private DataColumn columnCancelAplNum;
            private DataColumn columnCode;
            private DataColumn columnComments;
            private DataColumn columnDateAction;
            private DataColumn columnDateAppl;
            private DataColumn columnDateDog;
            private DataColumn columnDateExec;
            private DataColumn columnFIO;
            private DataColumn columnFioExec;
            private DataColumn columnFIOWorker;
            private DataColumn columnId;
            private DataColumn columnIdAbn;
            private DataColumn columnIdAplForDiscon;
            private DataColumn columnIdCancelApl;
            private DataColumn columnIsFullRestriction;
            private DataColumn columnIsNC;
            private DataColumn columnMatrix;
            private DataColumn columnNetArea;
            private DataColumn columnNetAreaExec;
            private DataColumn columnNetAreaExecDescription;
            private DataColumn columnOfficer;
            private DataColumn columnPlaceId;
            private DataColumn columnPoint;
            private DataColumn columnReason;
            private DataColumn columnReasonCaption;
            private DataColumn columnReasonFailure;
            private DataColumn columnSent;
            private DataColumn columnTypeAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate266 tblAbnAplForDisconIndividualUsersRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate266 tblAbnAplForDisconIndividualUsersRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate266 tblAbnAplForDisconIndividualUsersRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate266 tblAbnAplForDisconIndividualUsersRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tblAbnAplForDisconIndividualUsersDataTable()
            {
                base.TableName = "tblAbnAplForDisconIndividualUsers";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tblAbnAplForDisconIndividualUsersDataTable(DataTable dataTable_0)
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
            protected tblAbnAplForDisconIndividualUsersDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable table1 = (OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tblAbnAplForDisconIndividualUsersDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class415);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(OrgDataSet.Class415 class415_0)
            {
                base.Rows.Add(class415_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class415 method_1(int int_0, string string_0, string string_1, int int_1, int int_2, int int_3, string string_2, bool bool_0, int int_4, int int_5, DateTime dateTime_0, int int_6, string string_3, string string_4, DateTime dateTime_1, int int_7, int int_8, string string_5, string string_6, string string_7, string string_8, string string_9, bool bool_1, DateTime dateTime_2, DateTime dateTime_3, int int_9, int int_10, DateTime dateTime_4, bool bool_2)
            {
                OrgDataSet.Class415 row = (OrgDataSet.Class415) base.NewRow();
                object[] objArray = new object[] { 
                    int_0, string_0, string_1, int_1, int_2, int_3, string_2, bool_0, int_4, int_5, dateTime_0, int_6, string_3, string_4, dateTime_1, int_7,
                    int_8, string_5, string_6, string_7, string_8, string_9, bool_1, dateTime_2, dateTime_3, int_9, int_10, dateTime_4, bool_2
                };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnId = base.Columns["Id"];
                this.columnFIO = base.Columns["FIO"];
                this.columnAddress = base.Columns["Address"];
                this.columnPlaceId = base.Columns["PlaceId"];
                this.columnReason = base.Columns["Reason"];
                this.columnIdAplForDiscon = base.Columns["IdAplForDiscon"];
                this.columnComments = base.Columns["Comments"];
                this.columnIsNC = base.Columns["IsNC"];
                this.columnIdAbn = base.Columns["IdAbn"];
                this.columnCode = base.Columns["Code"];
                this.columnDateDog = base.Columns["DateDog"];
                this.columnIdCancelApl = base.Columns["IdCancelApl"];
                this.columnPoint = base.Columns["Point"];
                this.columnOfficer = base.Columns["Officer"];
                this.columnDateExec = base.Columns["DateExec"];
                this.columnFioExec = base.Columns["FioExec"];
                this.columnNetAreaExec = base.Columns["NetAreaExec"];
                this.columnReasonFailure = base.Columns["ReasonFailure"];
                this.columnReasonCaption = base.Columns["ReasonCaption"];
                this.columnCancelAplNum = base.Columns["CancelAplNum"];
                this.columnNetAreaExecDescription = base.Columns["NetAreaExecDescription"];
                this.columnFIOWorker = base.Columns["FIOWorker"];
                this.columnMatrix = base.Columns["Matrix"];
                this.columnSent = base.Columns["Sent"];
                this.columnDateAction = base.Columns["DateAction"];
                this.columnTypeAction = base.Columns["TypeAction"];
                this.columnNetArea = base.Columns["NetArea"];
                this.columnDateAppl = base.Columns["DateAppl"];
                this.columnIsFullRestriction = base.Columns["IsFullRestriction"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnId);
                this.columnFIO = new DataColumn("FIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFIO);
                this.columnAddress = new DataColumn("Address", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnAddress);
                this.columnPlaceId = new DataColumn("PlaceId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnPlaceId);
                this.columnReason = new DataColumn("Reason", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnIdAplForDiscon = new DataColumn("IdAplForDiscon", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnIdAplForDiscon);
                this.columnComments = new DataColumn("Comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComments);
                this.columnIsNC = new DataColumn("IsNC", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnIsNC);
                this.columnIdAbn = new DataColumn("IdAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnIdAbn);
                this.columnCode = new DataColumn("Code", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCode);
                this.columnDateDog = new DataColumn("DateDog", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateDog);
                this.columnIdCancelApl = new DataColumn("IdCancelApl", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnIdCancelApl);
                this.columnPoint = new DataColumn("Point", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPoint);
                this.columnOfficer = new DataColumn("Officer", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnOfficer);
                this.columnDateExec = new DataColumn("DateExec", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateExec);
                this.columnFioExec = new DataColumn("FioExec", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnFioExec);
                this.columnNetAreaExec = new DataColumn("NetAreaExec", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnNetAreaExec);
                this.columnReasonFailure = new DataColumn("ReasonFailure", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReasonFailure);
                this.columnReasonCaption = new DataColumn("ReasonCaption", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReasonCaption);
                this.columnCancelAplNum = new DataColumn("CancelAplNum", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnCancelAplNum);
                this.columnNetAreaExecDescription = new DataColumn("NetAreaExecDescription", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNetAreaExecDescription);
                this.columnFIOWorker = new DataColumn("FIOWorker", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFIOWorker);
                this.columnMatrix = new DataColumn("Matrix", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnMatrix);
                this.columnSent = new DataColumn("Sent", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnSent);
                this.columnDateAction = new DataColumn("DateAction", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateAction);
                this.columnTypeAction = new DataColumn("TypeAction", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnTypeAction);
                this.columnNetArea = new DataColumn("NetArea", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnNetArea);
                this.columnDateAppl = new DataColumn("DateAppl", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateAppl);
                this.columnIsFullRestriction = new DataColumn("IsFullRestriction", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnIsFullRestriction);
                this.columnId.AutoIncrementSeed = -1L;
                this.columnId.AutoIncrementStep = -1L;
                this.columnFIO.MaxLength = 100;
                this.columnAddress.MaxLength = 200;
                this.columnComments.MaxLength = 0xff;
                this.columnPoint.MaxLength = 0xff;
                this.columnOfficer.MaxLength = 100;
                this.columnReasonFailure.MaxLength = 500;
                this.columnReasonCaption.MaxLength = 100;
                this.columnCancelAplNum.MaxLength = 10;
                this.columnNetAreaExecDescription.MaxLength = 100;
                this.columnFIOWorker.ReadOnly = true;
                this.columnFIOWorker.MaxLength = 70;
                this.columnIsFullRestriction.DefaultValue = true;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class415 method_4()
            {
                return (OrgDataSet.Class415) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(OrgDataSet.Class415 class415_0)
            {
                base.Rows.Remove(class415_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class415(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconIndividualUsersRowChanged != null)
                {
                    this.tblAbnAplForDisconIndividualUsersRowChanged(this, new OrgDataSet.EventArgs262((OrgDataSet.Class415) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconIndividualUsersRowChanging != null)
                {
                    this.tblAbnAplForDisconIndividualUsersRowChanging(this, new OrgDataSet.EventArgs262((OrgDataSet.Class415) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconIndividualUsersRowDeleted != null)
                {
                    this.tblAbnAplForDisconIndividualUsersRowDeleted(this, new OrgDataSet.EventArgs262((OrgDataSet.Class415) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconIndividualUsersRowDeleting != null)
                {
                    this.tblAbnAplForDisconIndividualUsersRowDeleting(this, new OrgDataSet.EventArgs262((OrgDataSet.Class415) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tblAbnAplForDisconIndividualUsersDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn AddressColumn
            {
                get
                {
                    return this.columnAddress;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CancelAplNumColumn
            {
                get
                {
                    return this.columnCancelAplNum;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CodeColumn
            {
                get
                {
                    return this.columnCode;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CommentsColumn
            {
                get
                {
                    return this.columnComments;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateActionColumn
            {
                get
                {
                    return this.columnDateAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateApplColumn
            {
                get
                {
                    return this.columnDateAppl;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateDogColumn
            {
                get
                {
                    return this.columnDateDog;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateExecColumn
            {
                get
                {
                    return this.columnDateExec;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FioExecColumn
            {
                get
                {
                    return this.columnFioExec;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn FIOWorkerColumn
            {
                get
                {
                    return this.columnFIOWorker;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IdAbnColumn
            {
                get
                {
                    return this.columnIdAbn;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IdAplForDisconColumn
            {
                get
                {
                    return this.columnIdAplForDiscon;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IdCancelAplColumn
            {
                get
                {
                    return this.columnIdCancelApl;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IdColumn
            {
                get
                {
                    return this.columnId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IsFullRestrictionColumn
            {
                get
                {
                    return this.columnIsFullRestriction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IsNCColumn
            {
                get
                {
                    return this.columnIsNC;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class415 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class415) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn MatrixColumn
            {
                get
                {
                    return this.columnMatrix;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NetAreaColumn
            {
                get
                {
                    return this.columnNetArea;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NetAreaExecColumn
            {
                get
                {
                    return this.columnNetAreaExec;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NetAreaExecDescriptionColumn
            {
                get
                {
                    return this.columnNetAreaExecDescription;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn OfficerColumn
            {
                get
                {
                    return this.columnOfficer;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PlaceIdColumn
            {
                get
                {
                    return this.columnPlaceId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PointColumn
            {
                get
                {
                    return this.columnPoint;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ReasonCaptionColumn
            {
                get
                {
                    return this.columnReasonCaption;
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
            public DataColumn ReasonFailureColumn
            {
                get
                {
                    return this.columnReasonFailure;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn SentColumn
            {
                get
                {
                    return this.columnSent;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TypeActionColumn
            {
                get
                {
                    return this.columnTypeAction;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblAbnAplForDisconIndividualUsersForCancelDataTable : TypedTableBase<OrgDataSet.Class421>
        {
            private DataColumn columnAddress;
            private DataColumn columnCanceledAplId;
            private DataColumn columnCode;
            private DataColumn columnDateDog;
            private DataColumn columnFIO;
            private DataColumn columnId;
            private DataColumn columnIsNC;
            private DataColumn columnLabel;
            private DataColumn columnPlace;
            private DataColumn columnPlaceId;
            private DataColumn columnReason;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate272 tblAbnAplForDisconIndividualUsersForCancelRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate272 tblAbnAplForDisconIndividualUsersForCancelRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate272 tblAbnAplForDisconIndividualUsersForCancelRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate272 tblAbnAplForDisconIndividualUsersForCancelRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tblAbnAplForDisconIndividualUsersForCancelDataTable()
            {
                base.TableName = "tblAbnAplForDisconIndividualUsersForCancel";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tblAbnAplForDisconIndividualUsersForCancelDataTable(DataTable dataTable_0)
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
            protected tblAbnAplForDisconIndividualUsersForCancelDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                OrgDataSet.tblAbnAplForDisconIndividualUsersForCancelDataTable table1 = (OrgDataSet.tblAbnAplForDisconIndividualUsersForCancelDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tblAbnAplForDisconIndividualUsersForCancelDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class421);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(OrgDataSet.Class421 class421_0)
            {
                base.Rows.Add(class421_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class421 method_1(string string_0, string string_1, int int_0, bool bool_0, int int_1, DateTime dateTime_0, int int_2, bool bool_1, string string_2)
            {
                OrgDataSet.Class421 row = (OrgDataSet.Class421) base.NewRow();
                object[] objArray1 = new object[11];
                objArray1[0] = string_0;
                objArray1[1] = string_1;
                objArray1[2] = int_0;
                objArray1[3] = bool_0;
                objArray1[4] = int_1;
                objArray1[5] = dateTime_0;
                objArray1[6] = int_2;
                objArray1[7] = bool_1;
                objArray1[10] = string_2;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class421 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (OrgDataSet.Class421) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnFIO = base.Columns["FIO"];
                this.columnAddress = base.Columns["Address"];
                this.columnPlaceId = base.Columns["PlaceId"];
                this.columnIsNC = base.Columns["IsNC"];
                this.columnCode = base.Columns["Code"];
                this.columnDateDog = base.Columns["DateDog"];
                this.columnReason = base.Columns["Reason"];
                this.columnLabel = base.Columns["Label"];
                this.columnId = base.Columns["Id"];
                this.columnCanceledAplId = base.Columns["CanceledAplId"];
                this.columnPlace = base.Columns["Place"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_4()
            {
                this.columnFIO = new DataColumn("FIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFIO);
                this.columnAddress = new DataColumn("Address", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnAddress);
                this.columnPlaceId = new DataColumn("PlaceId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnPlaceId);
                this.columnIsNC = new DataColumn("IsNC", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnIsNC);
                this.columnCode = new DataColumn("Code", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCode);
                this.columnDateDog = new DataColumn("DateDog", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateDog);
                this.columnReason = new DataColumn("Reason", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnLabel = new DataColumn("Label", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnLabel);
                this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnId);
                this.columnCanceledAplId = new DataColumn("CanceledAplId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCanceledAplId);
                this.columnPlace = new DataColumn("Place", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPlace);
                DataColumn[] columns = new DataColumn[] { this.columnId };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnFIO.MaxLength = 100;
                this.columnAddress.MaxLength = 200;
                this.columnLabel.DefaultValue = false;
                this.columnId.AutoIncrement = true;
                this.columnId.AutoIncrementSeed = -1L;
                this.columnId.AutoIncrementStep = -1L;
                this.columnId.AllowDBNull = false;
                this.columnId.ReadOnly = true;
                this.columnId.Unique = true;
                this.columnCanceledAplId.AutoIncrement = true;
                this.columnCanceledAplId.AutoIncrementSeed = -1L;
                this.columnCanceledAplId.AutoIncrementStep = -1L;
                this.columnCanceledAplId.AllowDBNull = false;
                this.columnCanceledAplId.ReadOnly = true;
                this.columnPlace.MaxLength = 0xff;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class421 method_5()
            {
                return (OrgDataSet.Class421) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(OrgDataSet.Class421 class421_0)
            {
                base.Rows.Remove(class421_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class421(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconIndividualUsersForCancelRowChanged != null)
                {
                    this.tblAbnAplForDisconIndividualUsersForCancelRowChanged(this, new OrgDataSet.EventArgs268((OrgDataSet.Class421) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconIndividualUsersForCancelRowChanging != null)
                {
                    this.tblAbnAplForDisconIndividualUsersForCancelRowChanging(this, new OrgDataSet.EventArgs268((OrgDataSet.Class421) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconIndividualUsersForCancelRowDeleted != null)
                {
                    this.tblAbnAplForDisconIndividualUsersForCancelRowDeleted(this, new OrgDataSet.EventArgs268((OrgDataSet.Class421) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconIndividualUsersForCancelRowDeleting != null)
                {
                    this.tblAbnAplForDisconIndividualUsersForCancelRowDeleting(this, new OrgDataSet.EventArgs268((OrgDataSet.Class421) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tblAbnAplForDisconIndividualUsersForCancelDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn AddressColumn
            {
                get
                {
                    return this.columnAddress;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CanceledAplIdColumn
            {
                get
                {
                    return this.columnCanceledAplId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CodeColumn
            {
                get
                {
                    return this.columnCode;
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
            public DataColumn DateDogColumn
            {
                get
                {
                    return this.columnDateDog;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IdColumn
            {
                get
                {
                    return this.columnId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IsNCColumn
            {
                get
                {
                    return this.columnIsNC;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class421 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class421) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn LabelColumn
            {
                get
                {
                    return this.columnLabel;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn PlaceColumn
            {
                get
                {
                    return this.columnPlace;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PlaceIdColumn
            {
                get
                {
                    return this.columnPlaceId;
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
        public class tblAbnAplForDisconObjectsDataTable : TypedTableBase<OrgDataSet.Class411>
        {
            private DataColumn columnAbnId;
            private DataColumn columnAbnObj;
            private DataColumn columnAbnObjId;
            private DataColumn columnCancelAplNumDoc;
            private DataColumn columnCode;
            private DataColumn columnComments;
            private DataColumn columnDateAction;
            private DataColumn columnDateAppl;
            private DataColumn columnDateDog;
            private DataColumn columnDateExec;
            private DataColumn columnFIOExec;
            private DataColumn columnFIOWorker;
            private DataColumn columnId;
            private DataColumn columnIdAplForDiscon;
            private DataColumn columnIdCancelApl;
            private DataColumn columnIsFullRestriction;
            private DataColumn columnMatrix;
            private DataColumn columnNameShort;
            private DataColumn columnNetArea;
            private DataColumn columnNetAreaExec;
            private DataColumn columnNetAreaExecDescription;
            private DataColumn columnNoDogAbn;
            private DataColumn columnNoDogObj;
            private DataColumn columnOfficer;
            private DataColumn columnPlaceId;
            private DataColumn columnReason;
            private DataColumn columnReasonCaption;
            private DataColumn columnReasonFailure;
            private DataColumn columnSent;
            private DataColumn columnTypeAction;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate262 tblAbnAplForDisconObjectsRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate262 tblAbnAplForDisconObjectsRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate262 tblAbnAplForDisconObjectsRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate262 tblAbnAplForDisconObjectsRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tblAbnAplForDisconObjectsDataTable()
            {
                base.TableName = "tblAbnAplForDisconObjects";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tblAbnAplForDisconObjectsDataTable(DataTable dataTable_0)
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
            protected tblAbnAplForDisconObjectsDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.tblAbnAplForDisconObjectsDataTable table1 = (OrgDataSet.tblAbnAplForDisconObjectsDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tblAbnAplForDisconObjectsDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class411);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(OrgDataSet.Class411 class411_0)
            {
                base.Rows.Add(class411_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class411 method_1(int int_0, int int_1, int int_2, int int_3, string string_0, int int_4, string string_1, DateTime dateTime_0, int int_5, string string_2, string string_3, int int_6, DateTime dateTime_1, int int_7, string string_4, int int_8, string string_5, string string_6, string string_7, string string_8, string string_9, string string_10, string string_11, bool bool_0, DateTime dateTime_2, int int_9, int int_10, DateTime dateTime_3, DateTime dateTime_4, bool bool_1)
            {
                OrgDataSet.Class411 row = (OrgDataSet.Class411) base.NewRow();
                object[] objArray = new object[] { 
                    int_0, int_1, int_2, int_3, string_0, int_4, string_1, dateTime_0, int_5, string_2, string_3, int_6, dateTime_1, int_7, string_4, int_8,
                    string_5, string_6, string_7, string_8, string_9, string_10, string_11, bool_0, dateTime_2, int_9, int_10, dateTime_3, dateTime_4, bool_1
                };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnId = base.Columns["Id"];
                this.columnIdAplForDiscon = base.Columns["IdAplForDiscon"];
                this.columnAbnId = base.Columns["AbnId"];
                this.columnAbnObjId = base.Columns["AbnObjId"];
                this.columnPlaceId = base.Columns["PlaceId"];
                this.columnReason = base.Columns["Reason"];
                this.columnComments = base.Columns["Comments"];
                this.columnDateDog = base.Columns["DateDog"];
                this.columnCode = base.Columns["Code"];
                this.columnNameShort = base.Columns["NameShort"];
                this.columnAbnObj = base.Columns["AbnObj"];
                this.columnIdCancelApl = base.Columns["IdCancelApl"];
                this.columnDateExec = base.Columns["DateExec"];
                this.columnFIOExec = base.Columns["FIOExec"];
                this.columnReasonFailure = base.Columns["ReasonFailure"];
                this.columnNetAreaExec = base.Columns["NetAreaExec"];
                this.columnOfficer = base.Columns["Officer"];
                this.columnReasonCaption = base.Columns["ReasonCaption"];
                this.columnCancelAplNumDoc = base.Columns["CancelAplNumDoc"];
                this.columnNetAreaExecDescription = base.Columns["NetAreaExecDescription"];
                this.columnFIOWorker = base.Columns["FIOWorker"];
                this.columnNoDogAbn = base.Columns["NoDogAbn"];
                this.columnNoDogObj = base.Columns["NoDogObj"];
                this.columnMatrix = base.Columns["Matrix"];
                this.columnDateAppl = base.Columns["DateAppl"];
                this.columnTypeAction = base.Columns["TypeAction"];
                this.columnNetArea = base.Columns["NetArea"];
                this.columnDateAction = base.Columns["DateAction"];
                this.columnSent = base.Columns["Sent"];
                this.columnIsFullRestriction = base.Columns["IsFullRestriction"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnId);
                this.columnIdAplForDiscon = new DataColumn("IdAplForDiscon", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnIdAplForDiscon);
                this.columnAbnId = new DataColumn("AbnId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnAbnId);
                this.columnAbnObjId = new DataColumn("AbnObjId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnAbnObjId);
                this.columnPlaceId = new DataColumn("PlaceId", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPlaceId);
                this.columnReason = new DataColumn("Reason", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnComments = new DataColumn("Comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComments);
                this.columnDateDog = new DataColumn("DateDog", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateDog);
                this.columnCode = new DataColumn("Code", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCode);
                this.columnNameShort = new DataColumn("NameShort", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNameShort);
                this.columnAbnObj = new DataColumn("AbnObj", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnAbnObj);
                this.columnIdCancelApl = new DataColumn("IdCancelApl", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnIdCancelApl);
                this.columnDateExec = new DataColumn("DateExec", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateExec);
                this.columnFIOExec = new DataColumn("FIOExec", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnFIOExec);
                this.columnReasonFailure = new DataColumn("ReasonFailure", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReasonFailure);
                this.columnNetAreaExec = new DataColumn("NetAreaExec", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnNetAreaExec);
                this.columnOfficer = new DataColumn("Officer", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnOfficer);
                this.columnReasonCaption = new DataColumn("ReasonCaption", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReasonCaption);
                this.columnCancelAplNumDoc = new DataColumn("CancelAplNumDoc", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnCancelAplNumDoc);
                this.columnNetAreaExecDescription = new DataColumn("NetAreaExecDescription", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNetAreaExecDescription);
                this.columnFIOWorker = new DataColumn("FIOWorker", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFIOWorker);
                this.columnNoDogAbn = new DataColumn("NoDogAbn", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNoDogAbn);
                this.columnNoDogObj = new DataColumn("NoDogObj", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNoDogObj);
                this.columnMatrix = new DataColumn("Matrix", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnMatrix);
                this.columnDateAppl = new DataColumn("DateAppl", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateAppl);
                this.columnTypeAction = new DataColumn("TypeAction", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnTypeAction);
                this.columnNetArea = new DataColumn("NetArea", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnNetArea);
                this.columnDateAction = new DataColumn("DateAction", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateAction);
                this.columnSent = new DataColumn("Sent", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnSent);
                this.columnIsFullRestriction = new DataColumn("IsFullRestriction", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnIsFullRestriction);
                this.columnComments.MaxLength = 0xff;
                this.columnNameShort.MaxLength = 0xff;
                this.columnAbnObj.MaxLength = 0xff;
                this.columnReasonFailure.MaxLength = 500;
                this.columnOfficer.MaxLength = 100;
                this.columnReasonCaption.MaxLength = 100;
                this.columnCancelAplNumDoc.MaxLength = 10;
                this.columnNetAreaExecDescription.MaxLength = 100;
                this.columnFIOWorker.ReadOnly = true;
                this.columnFIOWorker.MaxLength = 70;
                this.columnIsFullRestriction.DefaultValue = true;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class411 method_4()
            {
                return (OrgDataSet.Class411) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(OrgDataSet.Class411 class411_0)
            {
                base.Rows.Remove(class411_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class411(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconObjectsRowChanged != null)
                {
                    this.tblAbnAplForDisconObjectsRowChanged(this, new OrgDataSet.EventArgs258((OrgDataSet.Class411) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconObjectsRowChanging != null)
                {
                    this.tblAbnAplForDisconObjectsRowChanging(this, new OrgDataSet.EventArgs258((OrgDataSet.Class411) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconObjectsRowDeleted != null)
                {
                    this.tblAbnAplForDisconObjectsRowDeleted(this, new OrgDataSet.EventArgs258((OrgDataSet.Class411) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconObjectsRowDeleting != null)
                {
                    this.tblAbnAplForDisconObjectsRowDeleting(this, new OrgDataSet.EventArgs258((OrgDataSet.Class411) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tblAbnAplForDisconObjectsDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn AbnIdColumn
            {
                get
                {
                    return this.columnAbnId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn AbnObjColumn
            {
                get
                {
                    return this.columnAbnObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn AbnObjIdColumn
            {
                get
                {
                    return this.columnAbnObjId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CancelAplNumDocColumn
            {
                get
                {
                    return this.columnCancelAplNumDoc;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CodeColumn
            {
                get
                {
                    return this.columnCode;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CommentsColumn
            {
                get
                {
                    return this.columnComments;
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateActionColumn
            {
                get
                {
                    return this.columnDateAction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateApplColumn
            {
                get
                {
                    return this.columnDateAppl;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateDogColumn
            {
                get
                {
                    return this.columnDateDog;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DateExecColumn
            {
                get
                {
                    return this.columnDateExec;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn FIOExecColumn
            {
                get
                {
                    return this.columnFIOExec;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn FIOWorkerColumn
            {
                get
                {
                    return this.columnFIOWorker;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IdAplForDisconColumn
            {
                get
                {
                    return this.columnIdAplForDiscon;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IdCancelAplColumn
            {
                get
                {
                    return this.columnIdCancelApl;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IdColumn
            {
                get
                {
                    return this.columnId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IsFullRestrictionColumn
            {
                get
                {
                    return this.columnIsFullRestriction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class411 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class411) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn MatrixColumn
            {
                get
                {
                    return this.columnMatrix;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NameShortColumn
            {
                get
                {
                    return this.columnNameShort;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NetAreaColumn
            {
                get
                {
                    return this.columnNetArea;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NetAreaExecColumn
            {
                get
                {
                    return this.columnNetAreaExec;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NetAreaExecDescriptionColumn
            {
                get
                {
                    return this.columnNetAreaExecDescription;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NoDogAbnColumn
            {
                get
                {
                    return this.columnNoDogAbn;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NoDogObjColumn
            {
                get
                {
                    return this.columnNoDogObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn OfficerColumn
            {
                get
                {
                    return this.columnOfficer;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn PlaceIdColumn
            {
                get
                {
                    return this.columnPlaceId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn ReasonCaptionColumn
            {
                get
                {
                    return this.columnReasonCaption;
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
            public DataColumn ReasonFailureColumn
            {
                get
                {
                    return this.columnReasonFailure;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn SentColumn
            {
                get
                {
                    return this.columnSent;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TypeActionColumn
            {
                get
                {
                    return this.columnTypeAction;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblAbnAplForDisconReasonDataTable : TypedTableBase<OrgDataSet.Class412>
        {
            private DataColumn columnId;
            private DataColumn columnIdTypeApl;
            private DataColumn columnReason;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate263 tblAbnAplForDisconReasonRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate263 tblAbnAplForDisconReasonRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate263 tblAbnAplForDisconReasonRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate263 tblAbnAplForDisconReasonRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tblAbnAplForDisconReasonDataTable()
            {
                base.TableName = "tblAbnAplForDisconReason";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tblAbnAplForDisconReasonDataTable(DataTable dataTable_0)
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
            protected tblAbnAplForDisconReasonDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.tblAbnAplForDisconReasonDataTable table1 = (OrgDataSet.tblAbnAplForDisconReasonDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tblAbnAplForDisconReasonDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class412);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(OrgDataSet.Class412 class412_0)
            {
                base.Rows.Add(class412_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class412 method_1(int int_0, string string_0, int int_1)
            {
                OrgDataSet.Class412 row = (OrgDataSet.Class412) base.NewRow();
                object[] objArray = new object[] { int_0, string_0, int_1 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnId = base.Columns["Id"];
                this.columnReason = base.Columns["Reason"];
                this.columnIdTypeApl = base.Columns["IdTypeApl"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnId);
                this.columnReason = new DataColumn("Reason", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnIdTypeApl = new DataColumn("IdTypeApl", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnIdTypeApl);
                this.columnReason.MaxLength = 0xff;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class412 method_4()
            {
                return (OrgDataSet.Class412) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(OrgDataSet.Class412 class412_0)
            {
                base.Rows.Remove(class412_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class412(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconReasonRowChanged != null)
                {
                    this.tblAbnAplForDisconReasonRowChanged(this, new OrgDataSet.EventArgs259((OrgDataSet.Class412) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconReasonRowChanging != null)
                {
                    this.tblAbnAplForDisconReasonRowChanging(this, new OrgDataSet.EventArgs259((OrgDataSet.Class412) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconReasonRowDeleted != null)
                {
                    this.tblAbnAplForDisconReasonRowDeleted(this, new OrgDataSet.EventArgs259((OrgDataSet.Class412) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tblAbnAplForDisconReasonRowDeleting != null)
                {
                    this.tblAbnAplForDisconReasonRowDeleting(this, new OrgDataSet.EventArgs259((OrgDataSet.Class412) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tblAbnAplForDisconReasonDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn IdColumn
            {
                get
                {
                    return this.columnId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn IdTypeAplColumn
            {
                get
                {
                    return this.columnIdTypeApl;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class412 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class412) base.Rows[int_0];
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
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblAbnDataTable : TypedTableBase<OrgDataSet.Class414>
        {
            private DataColumn columnAbnID;
            private DataColumn columnCode;
            private DataColumn columnDateDog;
            private DataColumn columnNameShort;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate265 tblAbnRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate265 tblAbnRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate265 tblAbnRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate265 tblAbnRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tblAbnDataTable()
            {
                base.TableName = "tblAbn";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tblAbnDataTable(DataTable dataTable_0)
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
            protected tblAbnDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.tblAbnDataTable table1 = (OrgDataSet.tblAbnDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tblAbnDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class414);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(OrgDataSet.Class414 class414_0)
            {
                base.Rows.Add(class414_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class414 method_1(string string_0, DateTime dateTime_0, int int_0)
            {
                OrgDataSet.Class414 row = (OrgDataSet.Class414) base.NewRow();
                object[] objArray1 = new object[4];
                objArray1[1] = string_0;
                objArray1[2] = dateTime_0;
                objArray1[3] = int_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnAbnID = base.Columns["AbnID"];
                this.columnNameShort = base.Columns["NameShort"];
                this.columnDateDog = base.Columns["DateDog"];
                this.columnCode = base.Columns["Code"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_3()
            {
                this.columnAbnID = new DataColumn("AbnID", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnAbnID);
                this.columnNameShort = new DataColumn("NameShort", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNameShort);
                this.columnDateDog = new DataColumn("DateDog", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateDog);
                this.columnCode = new DataColumn("Code", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCode);
                this.columnAbnID.AutoIncrement = true;
                this.columnAbnID.AutoIncrementSeed = -1L;
                this.columnAbnID.AutoIncrementStep = -1L;
                this.columnAbnID.ReadOnly = true;
                this.columnNameShort.MaxLength = 0xff;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class414 method_4()
            {
                return (OrgDataSet.Class414) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_5(OrgDataSet.Class414 class414_0)
            {
                base.Rows.Remove(class414_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class414(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tblAbnRowChanged != null)
                {
                    this.tblAbnRowChanged(this, new OrgDataSet.EventArgs261((OrgDataSet.Class414) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tblAbnRowChanging != null)
                {
                    this.tblAbnRowChanging(this, new OrgDataSet.EventArgs261((OrgDataSet.Class414) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tblAbnRowDeleted != null)
                {
                    this.tblAbnRowDeleted(this, new OrgDataSet.EventArgs261((OrgDataSet.Class414) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tblAbnRowDeleting != null)
                {
                    this.tblAbnRowDeleting(this, new OrgDataSet.EventArgs261((OrgDataSet.Class414) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tblAbnDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn AbnIDColumn
            {
                get
                {
                    return this.columnAbnID;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CodeColumn
            {
                get
                {
                    return this.columnCode;
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
            public DataColumn DateDogColumn
            {
                get
                {
                    return this.columnDateDog;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class414 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class414) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NameShortColumn
            {
                get
                {
                    return this.columnNameShort;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblAbnObj1DataTable : TypedTableBase<OrgDataSet.Class417>
        {
            private DataColumn columnComments;
            private DataColumn columnidPoint;
            private DataColumn columnLabel;
            private DataColumn columnObjId;
            private DataColumn columnPoint;
            private DataColumn columnReason;
            private DataColumn columnTitle;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate268 tblAbnObj1RowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate268 tblAbnObj1RowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate268 tblAbnObj1RowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate268 tblAbnObj1RowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tblAbnObj1DataTable()
            {
                base.TableName = "tblAbnObj1";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tblAbnObj1DataTable(DataTable dataTable_0)
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
            protected tblAbnObj1DataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                OrgDataSet.tblAbnObj1DataTable table1 = (OrgDataSet.tblAbnObj1DataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tblAbnObj1DataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class417);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(OrgDataSet.Class417 class417_0)
            {
                base.Rows.Add(class417_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class417 method_1(string string_0, string string_1, bool bool_0, int int_0, int int_1, string string_2)
            {
                OrgDataSet.Class417 row = (OrgDataSet.Class417) base.NewRow();
                object[] objArray1 = new object[7];
                objArray1[0] = string_0;
                objArray1[2] = string_1;
                objArray1[3] = bool_0;
                objArray1[4] = int_0;
                objArray1[5] = int_1;
                objArray1[6] = string_2;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class417 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (OrgDataSet.Class417) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnTitle = base.Columns["Title"];
                this.columnObjId = base.Columns["ObjId"];
                this.columnPoint = base.Columns["Point"];
                this.columnLabel = base.Columns["Label"];
                this.columnReason = base.Columns["Reason"];
                this.columnidPoint = base.Columns["idPoint"];
                this.columnComments = base.Columns["Comments"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnTitle = new DataColumn("Title", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTitle);
                this.columnObjId = new DataColumn("ObjId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnObjId);
                this.columnPoint = new DataColumn("Point", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPoint);
                this.columnLabel = new DataColumn("Label", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnLabel);
                this.columnReason = new DataColumn("Reason", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnidPoint = new DataColumn("idPoint", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidPoint);
                this.columnComments = new DataColumn("Comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComments);
                DataColumn[] columns = new DataColumn[] { this.columnObjId };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnTitle.MaxLength = 0xff;
                this.columnObjId.AutoIncrement = true;
                this.columnObjId.AutoIncrementSeed = -1L;
                this.columnObjId.AutoIncrementStep = -1L;
                this.columnObjId.AllowDBNull = false;
                this.columnObjId.ReadOnly = true;
                this.columnObjId.Unique = true;
                this.columnPoint.MaxLength = 0xff;
                this.columnLabel.DefaultValue = false;
                this.columnComments.MaxLength = 0xff;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class417 method_5()
            {
                return (OrgDataSet.Class417) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(OrgDataSet.Class417 class417_0)
            {
                base.Rows.Remove(class417_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class417(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tblAbnObj1RowChanged != null)
                {
                    this.tblAbnObj1RowChanged(this, new OrgDataSet.EventArgs264((OrgDataSet.Class417) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tblAbnObj1RowChanging != null)
                {
                    this.tblAbnObj1RowChanging(this, new OrgDataSet.EventArgs264((OrgDataSet.Class417) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tblAbnObj1RowDeleted != null)
                {
                    this.tblAbnObj1RowDeleted(this, new OrgDataSet.EventArgs264((OrgDataSet.Class417) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tblAbnObj1RowDeleting != null)
                {
                    this.tblAbnObj1RowDeleting(this, new OrgDataSet.EventArgs264((OrgDataSet.Class417) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tblAbnObj1DataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn CommentsColumn
            {
                get
                {
                    return this.columnComments;
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
            public DataColumn idPointColumn
            {
                get
                {
                    return this.columnidPoint;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class417 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class417) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LabelColumn
            {
                get
                {
                    return this.columnLabel;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ObjIdColumn
            {
                get
                {
                    return this.columnObjId;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn PointColumn
            {
                get
                {
                    return this.columnPoint;
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
            public DataColumn TitleColumn
            {
                get
                {
                    return this.columnTitle;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblAbnObj2DataTable : TypedTableBase<OrgDataSet.Class420>
        {
            private DataColumn columnAbnID;
            private DataColumn columnCanceledAplId;
            private DataColumn columnCode;
            private DataColumn columnComments;
            private DataColumn columnDateAction;
            private DataColumn columnDateDog;
            private DataColumn columnidPoint;
            private DataColumn columnLabel;
            private DataColumn columnNameShort;
            private DataColumn columnNoDogAbn;
            private DataColumn columnNoDogObj;
            private DataColumn columnObjId;
            private DataColumn columnReason;
            private DataColumn columnTitle;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate271 tblAbnObj2RowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate271 tblAbnObj2RowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate271 tblAbnObj2RowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate271 tblAbnObj2RowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tblAbnObj2DataTable()
            {
                base.TableName = "tblAbnObj2";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tblAbnObj2DataTable(DataTable dataTable_0)
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
            protected tblAbnObj2DataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.tblAbnObj2DataTable table1 = (OrgDataSet.tblAbnObj2DataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tblAbnObj2DataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class420);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(OrgDataSet.Class420 class420_0)
            {
                base.Rows.Add(class420_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class420 method_1(int int_0, string string_0, int int_1, DateTime dateTime_0, int int_2, string string_1, int int_3, bool bool_0, int int_4, string string_2, string string_3, string string_4, string string_5, DateTime dateTime_1)
            {
                OrgDataSet.Class420 row = (OrgDataSet.Class420) base.NewRow();
                object[] objArray = new object[] { int_0, string_0, int_1, dateTime_0, int_2, string_1, int_3, bool_0, int_4, string_2, string_3, string_4, string_5, dateTime_1 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_2()
            {
                this.columnAbnID = base.Columns["AbnID"];
                this.columnTitle = base.Columns["Title"];
                this.columnObjId = base.Columns["ObjId"];
                this.columnDateDog = base.Columns["DateDog"];
                this.columnCode = base.Columns["Code"];
                this.columnNameShort = base.Columns["NameShort"];
                this.columnCanceledAplId = base.Columns["CanceledAplId"];
                this.columnLabel = base.Columns["Label"];
                this.columnReason = base.Columns["Reason"];
                this.columnComments = base.Columns["Comments"];
                this.columnidPoint = base.Columns["idPoint"];
                this.columnNoDogAbn = base.Columns["NoDogAbn"];
                this.columnNoDogObj = base.Columns["NoDogObj"];
                this.columnDateAction = base.Columns["DateAction"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnAbnID = new DataColumn("AbnID", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnAbnID);
                this.columnTitle = new DataColumn("Title", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTitle);
                this.columnObjId = new DataColumn("ObjId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnObjId);
                this.columnDateDog = new DataColumn("DateDog", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateDog);
                this.columnCode = new DataColumn("Code", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCode);
                this.columnNameShort = new DataColumn("NameShort", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNameShort);
                this.columnCanceledAplId = new DataColumn("CanceledAplId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCanceledAplId);
                this.columnLabel = new DataColumn("Label", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnLabel);
                this.columnReason = new DataColumn("Reason", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnComments = new DataColumn("Comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComments);
                this.columnidPoint = new DataColumn("idPoint", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnidPoint);
                this.columnNoDogAbn = new DataColumn("NoDogAbn", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNoDogAbn);
                this.columnNoDogObj = new DataColumn("NoDogObj", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnNoDogObj);
                this.columnDateAction = new DataColumn("DateAction", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDateAction);
                this.columnTitle.MaxLength = 0xff;
                this.columnObjId.AutoIncrementSeed = -1L;
                this.columnObjId.AutoIncrementStep = -1L;
                this.columnObjId.ReadOnly = true;
                this.columnNameShort.MaxLength = 0xff;
                this.columnCanceledAplId.AutoIncrementSeed = -1L;
                this.columnCanceledAplId.AutoIncrementStep = -1L;
                this.columnCanceledAplId.AllowDBNull = false;
                this.columnCanceledAplId.ReadOnly = true;
                this.columnLabel.DefaultValue = false;
                this.columnComments.DefaultValue = " ";
                this.columnidPoint.MaxLength = 0x7fffffff;
                this.columnNoDogAbn.MaxLength = 100;
                this.columnNoDogObj.MaxLength = 0xff;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class420 method_4()
            {
                return (OrgDataSet.Class420) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(OrgDataSet.Class420 class420_0)
            {
                base.Rows.Remove(class420_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class420(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tblAbnObj2RowChanged != null)
                {
                    this.tblAbnObj2RowChanged(this, new OrgDataSet.EventArgs267((OrgDataSet.Class420) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tblAbnObj2RowChanging != null)
                {
                    this.tblAbnObj2RowChanging(this, new OrgDataSet.EventArgs267((OrgDataSet.Class420) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tblAbnObj2RowDeleted != null)
                {
                    this.tblAbnObj2RowDeleted(this, new OrgDataSet.EventArgs267((OrgDataSet.Class420) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tblAbnObj2RowDeleting != null)
                {
                    this.tblAbnObj2RowDeleting(this, new OrgDataSet.EventArgs267((OrgDataSet.Class420) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tblAbnObj2DataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn AbnIDColumn
            {
                get
                {
                    return this.columnAbnID;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CanceledAplIdColumn
            {
                get
                {
                    return this.columnCanceledAplId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CodeColumn
            {
                get
                {
                    return this.columnCode;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn CommentsColumn
            {
                get
                {
                    return this.columnComments;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), Browsable(false)]
            public int Count
            {
                get
                {
                    return base.Rows.Count;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateActionColumn
            {
                get
                {
                    return this.columnDateAction;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DateDogColumn
            {
                get
                {
                    return this.columnDateDog;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idPointColumn
            {
                get
                {
                    return this.columnidPoint;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class420 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class420) base.Rows[int_0];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn LabelColumn
            {
                get
                {
                    return this.columnLabel;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn NameShortColumn
            {
                get
                {
                    return this.columnNameShort;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NoDogAbnColumn
            {
                get
                {
                    return this.columnNoDogAbn;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn NoDogObjColumn
            {
                get
                {
                    return this.columnNoDogObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ObjIdColumn
            {
                get
                {
                    return this.columnObjId;
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
            public DataColumn TitleColumn
            {
                get
                {
                    return this.columnTitle;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tblAbnObjDataTable : TypedTableBase<OrgDataSet.Class413>
        {
            private DataColumn columnAbnID;
            private DataColumn columnComments;
            private DataColumn columnIsFullRestriction;
            private DataColumn columnLabel;
            private DataColumn columnObjId;
            private DataColumn columnPoint;
            private DataColumn columnReason;
            private DataColumn columnTitle;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate264 tblAbnObjRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate264 tblAbnObjRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate264 tblAbnObjRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate264 tblAbnObjRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tblAbnObjDataTable()
            {
                base.TableName = "tblAbnObj";
                this.BeginInit();
                this.method_3();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tblAbnObjDataTable(DataTable dataTable_0)
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
            protected tblAbnObjDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_2();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                OrgDataSet.tblAbnObjDataTable table1 = (OrgDataSet.tblAbnObjDataTable) base.Clone();
                table1.method_2();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tblAbnObjDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class413);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_0(OrgDataSet.Class413 class413_0)
            {
                base.Rows.Add(class413_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class413 method_1(string string_0, int int_0, string string_1, int int_1, bool bool_0, int int_2, string string_2, bool bool_1)
            {
                OrgDataSet.Class413 row = (OrgDataSet.Class413) base.NewRow();
                object[] objArray = new object[] { string_0, int_0, string_1, int_1, bool_0, int_2, string_2, bool_1 };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_2()
            {
                this.columnTitle = base.Columns["Title"];
                this.columnObjId = base.Columns["ObjId"];
                this.columnPoint = base.Columns["Point"];
                this.columnAbnID = base.Columns["AbnID"];
                this.columnLabel = base.Columns["Label"];
                this.columnReason = base.Columns["Reason"];
                this.columnComments = base.Columns["Comments"];
                this.columnIsFullRestriction = base.Columns["IsFullRestriction"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_3()
            {
                this.columnTitle = new DataColumn("Title", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTitle);
                this.columnObjId = new DataColumn("ObjId", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnObjId);
                this.columnPoint = new DataColumn("Point", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnPoint);
                this.columnAbnID = new DataColumn("AbnID", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnAbnID);
                this.columnLabel = new DataColumn("Label", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnLabel);
                this.columnReason = new DataColumn("Reason", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnReason);
                this.columnComments = new DataColumn("Comments", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnComments);
                this.columnIsFullRestriction = new DataColumn("IsFullRestriction", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnIsFullRestriction);
                this.columnTitle.MaxLength = 0xff;
                this.columnObjId.AutoIncrementSeed = -1L;
                this.columnObjId.AutoIncrementStep = -1L;
                this.columnObjId.ReadOnly = true;
                this.columnPoint.MaxLength = 0xff;
                this.columnLabel.DefaultValue = false;
                this.columnComments.DefaultValue = " ";
                this.columnComments.MaxLength = 0xff;
                this.columnIsFullRestriction.DefaultValue = true;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public OrgDataSet.Class413 method_4()
            {
                return (OrgDataSet.Class413) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_5(OrgDataSet.Class413 class413_0)
            {
                base.Rows.Remove(class413_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class413(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tblAbnObjRowChanged != null)
                {
                    this.tblAbnObjRowChanged(this, new OrgDataSet.EventArgs260((OrgDataSet.Class413) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tblAbnObjRowChanging != null)
                {
                    this.tblAbnObjRowChanging(this, new OrgDataSet.EventArgs260((OrgDataSet.Class413) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tblAbnObjRowDeleted != null)
                {
                    this.tblAbnObjRowDeleted(this, new OrgDataSet.EventArgs260((OrgDataSet.Class413) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tblAbnObjRowDeleting != null)
                {
                    this.tblAbnObjRowDeleting(this, new OrgDataSet.EventArgs260((OrgDataSet.Class413) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tblAbnObjDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn AbnIDColumn
            {
                get
                {
                    return this.columnAbnID;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn CommentsColumn
            {
                get
                {
                    return this.columnComments;
                }
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
            public DataColumn IsFullRestrictionColumn
            {
                get
                {
                    return this.columnIsFullRestriction;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class413 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class413) base.Rows[int_0];
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn LabelColumn
            {
                get
                {
                    return this.columnLabel;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn ObjIdColumn
            {
                get
                {
                    return this.columnObjId;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn PointColumn
            {
                get
                {
                    return this.columnPoint;
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

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn TitleColumn
            {
                get
                {
                    return this.columnTitle;
                }
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tR_WorkerDataTable : TypedTableBase<OrgDataSet.Class423>
        {
            private DataColumn columnFIO;
            private DataColumn columnid;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate274 tR_WorkerRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate274 tR_WorkerRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate274 tR_WorkerRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event OrgDataSet.Delegate274 tR_WorkerRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tR_WorkerDataTable()
            {
                base.TableName = "tR_Worker";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tR_WorkerDataTable(DataTable dataTable_0)
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
            protected tR_WorkerDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                OrgDataSet.tR_WorkerDataTable table1 = (OrgDataSet.tR_WorkerDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new OrgDataSet.tR_WorkerDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override Type GetRowType()
            {
                return typeof(OrgDataSet.Class423);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(OrgDataSet.Class423 class423_0)
            {
                base.Rows.Add(class423_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class423 method_1(string string_0)
            {
                OrgDataSet.Class423 row = (OrgDataSet.Class423) base.NewRow();
                object[] objArray1 = new object[2];
                objArray1[1] = string_0;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class423 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (OrgDataSet.Class423) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnFIO = base.Columns["FIO"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnFIO = new DataColumn("FIO", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFIO);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnFIO.ReadOnly = true;
                this.columnFIO.MaxLength = 0x48;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public OrgDataSet.Class423 method_5()
            {
                return (OrgDataSet.Class423) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_6(OrgDataSet.Class423 class423_0)
            {
                base.Rows.Remove(class423_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new OrgDataSet.Class423(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tR_WorkerRowChanged != null)
                {
                    this.tR_WorkerRowChanged(this, new OrgDataSet.EventArgs270((OrgDataSet.Class423) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tR_WorkerRowChanging != null)
                {
                    this.tR_WorkerRowChanging(this, new OrgDataSet.EventArgs270((OrgDataSet.Class423) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tR_WorkerRowDeleted != null)
                {
                    this.tR_WorkerRowDeleted(this, new OrgDataSet.EventArgs270((OrgDataSet.Class423) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tR_WorkerRowDeleting != null)
                {
                    this.tR_WorkerRowDeleting(this, new OrgDataSet.EventArgs270((OrgDataSet.Class423) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                OrgDataSet set = new OrgDataSet();
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
                    FixedValue = set.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tR_WorkerDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = set.GetSchemaSerializable();
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
            public DataColumn FIOColumn
            {
                get
                {
                    return this.columnFIO;
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
            public OrgDataSet.Class423 this[int int_0]
            {
                get
                {
                    return (OrgDataSet.Class423) base.Rows[int_0];
                }
            }
        }
    }
}

