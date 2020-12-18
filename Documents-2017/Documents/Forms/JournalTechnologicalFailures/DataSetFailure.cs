namespace Documents.Forms.JournalTechnologicalFailures
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

    [Serializable, XmlRoot("DataSetFailure"), ToolboxItem(true), DesignerCategory("code"), XmlSchemaProvider("GetTypedDataSetSchema"), HelpKeyword("vs.data.DataSet")]
    internal class DataSetFailure : DataSet
    {
        private System.Data.SchemaSerializationMode _schemaSerializationMode;
        private tJ_TechnologicalFailuresDataTable tabletJ_TechnologicalFailures;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public DataSetFailure()
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            base.BeginInit();
            this.method_2();
            CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_4);
            base.Tables.CollectionChanged += handler;
            base.Relations.CollectionChanged += handler;
            base.EndInit();
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected DataSetFailure(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0, false)
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            if (base.IsBinarySerialized(serializationInfo_0, streamingContext_0))
            {
                this.method_1(false);
                CollectionChangeEventHandler handler2 = new CollectionChangeEventHandler(this.method_4);
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
                    if (dataSet.Tables["tJ_TechnologicalFailures"] != null)
                    {
                        base.Tables.Add(new tJ_TechnologicalFailuresDataTable(dataSet.Tables["tJ_TechnologicalFailures"]));
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
                CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_4);
                base.Tables.CollectionChanged += handler;
                this.Relations.CollectionChanged += handler;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override DataSet Clone()
        {
            DataSetFailure failure1 = (DataSetFailure) base.Clone();
            failure1.method_0();
            failure1.SchemaSerializationMode = this.SchemaSerializationMode;
            return failure1;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        internal void method_0()
        {
            this.method_1(true);
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        internal void method_1(bool bool_0)
        {
            this.tabletJ_TechnologicalFailures = (tJ_TechnologicalFailuresDataTable) base.Tables["tJ_TechnologicalFailures"];
            if (bool_0 && (this.tabletJ_TechnologicalFailures != null))
            {
                this.tabletJ_TechnologicalFailures.method_3();
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void method_2()
        {
            base.DataSetName = "DataSetFailure";
            base.Prefix = "";
            base.Namespace = "http://tempuri.org/DataSetFailure.xsd";
            base.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tabletJ_TechnologicalFailures = new tJ_TechnologicalFailuresDataTable();
            base.Tables.Add(this.tabletJ_TechnologicalFailures);
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private bool method_3()
        {
            return false;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_4(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Remove)
            {
                this.method_0();
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected override void ReadXmlSerializable(XmlReader reader)
        {
            if (base.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)
            {
                this.Reset();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(reader);
                if (dataSet.Tables["tJ_TechnologicalFailures"] != null)
                {
                    base.Tables.Add(new tJ_TechnologicalFailuresDataTable(dataSet.Tables["tJ_TechnologicalFailures"]));
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
            DataSetFailure failure = new DataSetFailure();
            XmlSchemaComplexType type = new XmlSchemaComplexType();
            XmlSchemaSequence sequence = new XmlSchemaSequence();
            XmlSchemaAny item = new XmlSchemaAny {
                Namespace = failure.Namespace
            };
            sequence.Items.Add(item);
            type.Particle = sequence;
            XmlSchema schemaSerializable = failure.GetSchemaSerializable();
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode]
        public DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), Browsable(true), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public DataTableCollection Tables
        {
            get
            {
                return base.Tables;
            }
        }

        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public tJ_TechnologicalFailuresDataTable tJ_TechnologicalFailures
        {
            get
            {
                return this.tabletJ_TechnologicalFailures;
            }
        }

        public class Class307 : DataRow
        {
            private DataSetFailure.tJ_TechnologicalFailuresDataTable tJ_TechnologicalFailuresDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal Class307(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tJ_TechnologicalFailuresDataTable_0 = (DataSetFailure.tJ_TechnologicalFailuresDataTable) base.Table;
            }

            public int method_0()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_TechnologicalFailuresDataTable_0.numColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'num' in table 'tJ_TechnologicalFailures' is DBNull.", exception);
                }
                return num;
            }

            public void method_1(int int_0)
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.numColumn] = int_0;
            }

            public string method_10()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_TechnologicalFailuresDataTable_0.abonentsColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'abonents' in table 'tJ_TechnologicalFailures' is DBNull.", exception);
                }
                return str;
            }

            public void method_11(string string_0)
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.abonentsColumn] = string_0;
            }

            public int method_12()
            {
                int num;
                try
                {
                    num = (int) base[this.tJ_TechnologicalFailuresDataTable_0.DownTimeColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'DownTime' in table 'tJ_TechnologicalFailures' is DBNull.", exception);
                }
                return num;
            }

            public void method_13(int int_0)
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.DownTimeColumn] = int_0;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_14()
            {
                return base.IsNull(this.tJ_TechnologicalFailuresDataTable_0.numColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_15()
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.numColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_16()
            {
                return base.IsNull(this.tJ_TechnologicalFailuresDataTable_0.dateOffColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_17()
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.dateOffColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_18()
            {
                return base.IsNull(this.tJ_TechnologicalFailuresDataTable_0.schmObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_19()
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.schmObjColumn] = Convert.DBNull;
            }

            public DateTime method_2()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_TechnologicalFailuresDataTable_0.dateOffColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateOff' in table 'tJ_TechnologicalFailures' is DBNull.", exception);
                }
                return time;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_20()
            {
                return base.IsNull(this.tJ_TechnologicalFailuresDataTable_0.textColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_21()
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.textColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_22()
            {
                return base.IsNull(this.tJ_TechnologicalFailuresDataTable_0.dateOnColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_23()
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.dateOnColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool method_24()
            {
                return base.IsNull(this.tJ_TechnologicalFailuresDataTable_0.abonentsColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_25()
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.abonentsColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool method_26()
            {
                return base.IsNull(this.tJ_TechnologicalFailuresDataTable_0.DownTimeColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_27()
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.DownTimeColumn] = Convert.DBNull;
            }

            public void method_3(DateTime dateTime_0)
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.dateOffColumn] = dateTime_0;
            }

            public string method_4()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_TechnologicalFailuresDataTable_0.schmObjColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'schmObj' in table 'tJ_TechnologicalFailures' is DBNull.", exception);
                }
                return str;
            }

            public void method_5(string string_0)
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.schmObjColumn] = string_0;
            }

            public string method_6()
            {
                string str;
                try
                {
                    str = (string) base[this.tJ_TechnologicalFailuresDataTable_0.textColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'text' in table 'tJ_TechnologicalFailures' is DBNull.", exception);
                }
                return str;
            }

            public void method_7(string string_0)
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.textColumn] = string_0;
            }

            public DateTime method_8()
            {
                DateTime time;
                try
                {
                    time = (DateTime) base[this.tJ_TechnologicalFailuresDataTable_0.dateOnColumn];
                }
                catch (InvalidCastException exception)
                {
                    throw new StrongTypingException("The value for column 'dateOn' in table 'tJ_TechnologicalFailures' is DBNull.", exception);
                }
                return time;
            }

            public void method_9(DateTime dateTime_0)
            {
                base[this.tJ_TechnologicalFailuresDataTable_0.dateOnColumn] = dateTime_0;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tJ_TechnologicalFailuresDataTable_0.idColumn];
                }
                set
                {
                    base[this.tJ_TechnologicalFailuresDataTable_0.idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void Delegate168(object sender, DataSetFailure.EventArgs166 e);

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class EventArgs166 : EventArgs
        {
            private DataSetFailure.Class307 class307_0;
            private DataRowAction dataRowAction_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public EventArgs166(DataSetFailure.Class307 class307_1, DataRowAction dataRowAction_1)
            {
                this.class307_0 = class307_1;
                this.dataRowAction_0 = dataRowAction_1;
            }

            public DataSetFailure.Class307 method_0()
            {
                return this.class307_0;
            }

            public DataRowAction method_1()
            {
                return this.dataRowAction_0;
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tJ_TechnologicalFailuresDataTable : TypedTableBase<DataSetFailure.Class307>
        {
            private DataColumn columnabonents;
            private DataColumn columndateOff;
            private DataColumn columndateOn;
            private DataColumn columnDownTime;
            private DataColumn columnid;
            private DataColumn columnnum;
            private DataColumn columnschmObj;
            private DataColumn columntext;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFailure.Delegate168 tJ_TechnologicalFailuresRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFailure.Delegate168 tJ_TechnologicalFailuresRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFailure.Delegate168 tJ_TechnologicalFailuresRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetFailure.Delegate168 tJ_TechnologicalFailuresRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tJ_TechnologicalFailuresDataTable()
            {
                base.TableName = "tJ_TechnologicalFailures";
                this.BeginInit();
                this.method_4();
                this.EndInit();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tJ_TechnologicalFailuresDataTable(DataTable dataTable_0)
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
            protected tJ_TechnologicalFailuresDataTable(SerializationInfo serializationInfo_0, StreamingContext streamingContext_0) : base(serializationInfo_0, streamingContext_0)
            {
                this.method_3();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetFailure.tJ_TechnologicalFailuresDataTable table1 = (DataSetFailure.tJ_TechnologicalFailuresDataTable) base.Clone();
                table1.method_3();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetFailure.tJ_TechnologicalFailuresDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetFailure.Class307);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void method_0(DataSetFailure.Class307 class307_0)
            {
                base.Rows.Add(class307_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetFailure.Class307 method_1(int int_0, DateTime dateTime_0, string string_0, string string_1, DateTime dateTime_1, string string_2, int int_1)
            {
                DataSetFailure.Class307 row = (DataSetFailure.Class307) base.NewRow();
                object[] objArray1 = new object[8];
                objArray1[1] = int_0;
                objArray1[2] = dateTime_0;
                objArray1[3] = string_0;
                objArray1[4] = string_1;
                objArray1[5] = dateTime_1;
                objArray1[6] = string_2;
                objArray1[7] = int_1;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetFailure.Class307 method_2(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetFailure.Class307) base.Rows.Find(keys);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal void method_3()
            {
                this.columnid = base.Columns["id"];
                this.columnnum = base.Columns["num"];
                this.columndateOff = base.Columns["dateOff"];
                this.columnschmObj = base.Columns["schmObj"];
                this.columntext = base.Columns["text"];
                this.columndateOn = base.Columns["dateOn"];
                this.columnabonents = base.Columns["abonents"];
                this.columnDownTime = base.Columns["DownTime"];
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private void method_4()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnnum = new DataColumn("num", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnnum);
                this.columndateOff = new DataColumn("dateOff", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateOff);
                this.columnschmObj = new DataColumn("schmObj", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnschmObj);
                this.columntext = new DataColumn("text", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columntext);
                this.columndateOn = new DataColumn("dateOn", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateOn);
                this.columnabonents = new DataColumn("abonents", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnabonents);
                this.columnDownTime = new DataColumn("DownTime", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnDownTime);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.Unique = true;
                this.columntext.MaxLength = 0x400;
                this.columnabonents.MaxLength = 0x400;
                this.columnDownTime.ReadOnly = true;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetFailure.Class307 method_5()
            {
                return (DataSetFailure.Class307) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void method_6(DataSetFailure.Class307 class307_0)
            {
                base.Rows.Remove(class307_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetFailure.Class307(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tJ_TechnologicalFailuresRowChanged != null)
                {
                    this.tJ_TechnologicalFailuresRowChanged(this, new DataSetFailure.EventArgs166((DataSetFailure.Class307) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tJ_TechnologicalFailuresRowChanging != null)
                {
                    this.tJ_TechnologicalFailuresRowChanging(this, new DataSetFailure.EventArgs166((DataSetFailure.Class307) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tJ_TechnologicalFailuresRowDeleted != null)
                {
                    this.tJ_TechnologicalFailuresRowDeleted(this, new DataSetFailure.EventArgs166((DataSetFailure.Class307) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tJ_TechnologicalFailuresRowDeleting != null)
                {
                    this.tJ_TechnologicalFailuresRowDeleting(this, new DataSetFailure.EventArgs166((DataSetFailure.Class307) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType smethod_0(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetFailure failure = new DataSetFailure();
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
                    FixedValue = failure.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tJ_TechnologicalFailuresDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = failure.GetSchemaSerializable();
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
            public DataColumn abonentsColumn
            {
                get
                {
                    return this.columnabonents;
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
            public DataColumn dateOffColumn
            {
                get
                {
                    return this.columndateOff;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn dateOnColumn
            {
                get
                {
                    return this.columndateOn;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DownTimeColumn
            {
                get
                {
                    return this.columnDownTime;
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
            public DataSetFailure.Class307 this[int int_0]
            {
                get
                {
                    return (DataSetFailure.Class307) base.Rows[int_0];
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
            public DataColumn schmObjColumn
            {
                get
                {
                    return this.columnschmObj;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn textColumn
            {
                get
                {
                    return this.columntext;
                }
            }
        }
    }
}

