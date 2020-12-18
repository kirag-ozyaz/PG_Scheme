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

    [Serializable, DesignerCategory("code"), ToolboxItem(true), XmlRoot("DataSetAbnObjAct"), HelpKeyword("vs.data.DataSet"), XmlSchemaProvider("GetTypedDataSetSchema")]
    public class DataSetAbnObjAct : DataSet
    {
        private System.Data.SchemaSerializationMode _schemaSerializationMode;
        private tAbnObjDoc_FileDataTable tabletAbnObjDoc_File;
        private tAbnObjDoc_ListDataTable tabletAbnObjDoc_List;
        private vActBalanceDataTable tablevActBalance;

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        public DataSetAbnObjAct()
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            base.BeginInit();
            this.method_2();
            CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_6);
            base.Tables.CollectionChanged += handler;
            base.Relations.CollectionChanged += handler;
            base.EndInit();
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected DataSetAbnObjAct(SerializationInfo info, StreamingContext context) : base(info, context, false)
        {
            this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            if (base.IsBinarySerialized(info, context))
            {
                this.method_1(false);
                CollectionChangeEventHandler handler2 = new CollectionChangeEventHandler(this.method_6);
                this.Tables.CollectionChanged += handler2;
                this.Relations.CollectionChanged += handler2;
            }
            else
            {
                string s = (string) info.GetValue("XmlSchema", typeof(string));
                if (base.DetermineSchemaSerializationMode(info, context) == System.Data.SchemaSerializationMode.IncludeSchema)
                {
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
                    if (dataSet.Tables["vActBalance"] != null)
                    {
                        base.Tables.Add(new vActBalanceDataTable(dataSet.Tables["vActBalance"]));
                    }
                    if (dataSet.Tables["tAbnObjDoc_File"] != null)
                    {
                        base.Tables.Add(new tAbnObjDoc_FileDataTable(dataSet.Tables["tAbnObjDoc_File"]));
                    }
                    if (dataSet.Tables["tAbnObjDoc_List"] != null)
                    {
                        base.Tables.Add(new tAbnObjDoc_ListDataTable(dataSet.Tables["tAbnObjDoc_List"]));
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
                CollectionChangeEventHandler handler = new CollectionChangeEventHandler(this.method_6);
                base.Tables.CollectionChanged += handler;
                this.Relations.CollectionChanged += handler;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public override DataSet Clone()
        {
            DataSetAbnObjAct act1 = (DataSetAbnObjAct) base.Clone();
            act1.method_0();
            act1.SchemaSerializationMode = this.SchemaSerializationMode;
            return act1;
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
        public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xmlSchemaSet_0)
        {
            DataSetAbnObjAct act = new DataSetAbnObjAct();
            XmlSchemaComplexType type = new XmlSchemaComplexType();
            XmlSchemaSequence sequence = new XmlSchemaSequence();
            XmlSchemaAny item = new XmlSchemaAny {
                Namespace = act.Namespace
            };
            sequence.Items.Add(item);
            type.Particle = sequence;
            XmlSchema schemaSerializable = act.GetSchemaSerializable();
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        internal void method_1(bool bool_0)
        {
            this.tablevActBalance = (vActBalanceDataTable) base.Tables["vActBalance"];
            if (bool_0 && (this.tablevActBalance != null))
            {
                this.tablevActBalance.method_0();
            }
            this.tabletAbnObjDoc_File = (tAbnObjDoc_FileDataTable) base.Tables["tAbnObjDoc_File"];
            if (bool_0 && (this.tabletAbnObjDoc_File != null))
            {
                this.tabletAbnObjDoc_File.method_0();
            }
            this.tabletAbnObjDoc_List = (tAbnObjDoc_ListDataTable) base.Tables["tAbnObjDoc_List"];
            if (bool_0 && (this.tabletAbnObjDoc_List != null))
            {
                this.tabletAbnObjDoc_List.method_0();
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private void method_2()
        {
            base.DataSetName = "DataSetAbnObjAct";
            base.Prefix = "";
            base.Namespace = "http://tempuri.org/DataSetAbnObjAct.xsd";
            base.EnforceConstraints = true;
            this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            this.tablevActBalance = new vActBalanceDataTable();
            base.Tables.Add(this.tablevActBalance);
            this.tabletAbnObjDoc_File = new tAbnObjDoc_FileDataTable();
            base.Tables.Add(this.tabletAbnObjDoc_File);
            this.tabletAbnObjDoc_List = new tAbnObjDoc_ListDataTable();
            base.Tables.Add(this.tabletAbnObjDoc_List);
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

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        private bool method_5()
        {
            return false;
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private void method_6(object sender, CollectionChangeEventArgs e)
        {
            if (e.Action == CollectionChangeAction.Remove)
            {
                this.method_0();
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
        protected override void ReadXmlSerializable(XmlReader reader)
        {
            if (base.DetermineSchemaSerializationMode(reader) == System.Data.SchemaSerializationMode.IncludeSchema)
            {
                this.Reset();
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(reader);
                if (dataSet.Tables["vActBalance"] != null)
                {
                    base.Tables.Add(new vActBalanceDataTable(dataSet.Tables["vActBalance"]));
                }
                if (dataSet.Tables["tAbnObjDoc_File"] != null)
                {
                    base.Tables.Add(new tAbnObjDoc_FileDataTable(dataSet.Tables["tAbnObjDoc_File"]));
                }
                if (dataSet.Tables["tAbnObjDoc_List"] != null)
                {
                    base.Tables.Add(new tAbnObjDoc_ListDataTable(dataSet.Tables["tAbnObjDoc_List"]));
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

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataRelationCollection Relations
        {
            get
            {
                return base.Relations;
            }
        }

        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
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

        [Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), DebuggerNonUserCode]
        public tAbnObjDoc_FileDataTable tAbnObjDoc_File
        {
            get
            {
                return this.tabletAbnObjDoc_File;
            }
        }

        [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false)]
        public tAbnObjDoc_ListDataTable tAbnObjDoc_List
        {
            get
            {
                return this.tabletAbnObjDoc_List;
            }
        }

        [DebuggerNonUserCode, DesignerSerializationVisibility(DesignerSerializationVisibility.Content), Browsable(false), GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public vActBalanceDataTable vActBalance
        {
            get
            {
                return this.tablevActBalance;
            }
        }

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tAbnObjDoc_FileDataTable : TypedTableBase<DataSetAbnObjAct.tAbnObjDoc_FileRow>
        {
            private DataColumn columndateChange;
            private DataColumn columnFile;
            private DataColumn columnFileName;
            private DataColumn columnid;
            private DataColumn columnidList;
            private DataColumn columnidTemplate;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetAbnObjAct.tAbnObjDoc_FileRowChangeEventHandler tAbnObjDoc_FileRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetAbnObjAct.tAbnObjDoc_FileRowChangeEventHandler tAbnObjDoc_FileRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetAbnObjAct.tAbnObjDoc_FileRowChangeEventHandler tAbnObjDoc_FileRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetAbnObjAct.tAbnObjDoc_FileRowChangeEventHandler tAbnObjDoc_FileRowDeleting;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tAbnObjDoc_FileDataTable()
            {
                base.TableName = "tAbnObjDoc_File";
                this.BeginInit();
                this.method_1();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tAbnObjDoc_FileDataTable(DataTable dataTable_0)
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
            protected tAbnObjDoc_FileDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.method_0();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void AddtAbnObjDoc_FileRow(DataSetAbnObjAct.tAbnObjDoc_FileRow tAbnObjDoc_FileRow_0)
            {
                base.Rows.Add(tAbnObjDoc_FileRow_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetAbnObjAct.tAbnObjDoc_FileRow AddtAbnObjDoc_FileRow(int idList, string FileName, byte[] File, DateTime dateChange, int idTemplate)
            {
                DataSetAbnObjAct.tAbnObjDoc_FileRow row = (DataSetAbnObjAct.tAbnObjDoc_FileRow) base.NewRow();
                object[] objArray1 = new object[6];
                objArray1[1] = idList;
                objArray1[2] = FileName;
                objArray1[3] = File;
                objArray1[4] = dateChange;
                objArray1[5] = idTemplate;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetAbnObjAct.tAbnObjDoc_FileDataTable table1 = (DataSetAbnObjAct.tAbnObjDoc_FileDataTable) base.Clone();
                table1.method_0();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetAbnObjAct.tAbnObjDoc_FileDataTable();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetAbnObjAct.tAbnObjDoc_FileRow FindByid(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetAbnObjAct.tAbnObjDoc_FileRow) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetAbnObjAct.tAbnObjDoc_FileRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetAbnObjAct act = new DataSetAbnObjAct();
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
                    FixedValue = act.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tAbnObjDoc_FileDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = act.GetSchemaSerializable();
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
            internal void method_0()
            {
                this.columnid = base.Columns["id"];
                this.columnidList = base.Columns["idList"];
                this.columnFileName = base.Columns["FileName"];
                this.columnFile = base.Columns["File"];
                this.columndateChange = base.Columns["dateChange"];
                this.columnidTemplate = base.Columns["idTemplate"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_1()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidList = new DataColumn("idList", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidList);
                this.columnFileName = new DataColumn("FileName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnFileName);
                this.columnFile = new DataColumn("File", typeof(byte[]), null, MappingType.Element);
                base.Columns.Add(this.columnFile);
                this.columndateChange = new DataColumn("dateChange", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columndateChange);
                this.columnidTemplate = new DataColumn("idTemplate", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidTemplate);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidList.AllowDBNull = false;
                this.columnFileName.AllowDBNull = false;
                this.columnFileName.MaxLength = 0x400;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetAbnObjAct.tAbnObjDoc_FileRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetAbnObjAct.tAbnObjDoc_FileRow NewtAbnObjDoc_FileRow()
            {
                return (DataSetAbnObjAct.tAbnObjDoc_FileRow) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tAbnObjDoc_FileRowChanged != null)
                {
                    this.tAbnObjDoc_FileRowChanged(this, new DataSetAbnObjAct.tAbnObjDoc_FileRowChangeEvent((DataSetAbnObjAct.tAbnObjDoc_FileRow) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tAbnObjDoc_FileRowChanging != null)
                {
                    this.tAbnObjDoc_FileRowChanging(this, new DataSetAbnObjAct.tAbnObjDoc_FileRowChangeEvent((DataSetAbnObjAct.tAbnObjDoc_FileRow) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tAbnObjDoc_FileRowDeleted != null)
                {
                    this.tAbnObjDoc_FileRowDeleted(this, new DataSetAbnObjAct.tAbnObjDoc_FileRowChangeEvent((DataSetAbnObjAct.tAbnObjDoc_FileRow) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tAbnObjDoc_FileRowDeleting != null)
                {
                    this.tAbnObjDoc_FileRowDeleting(this, new DataSetAbnObjAct.tAbnObjDoc_FileRowChangeEvent((DataSetAbnObjAct.tAbnObjDoc_FileRow) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemovetAbnObjDoc_FileRow(DataSetAbnObjAct.tAbnObjDoc_FileRow tAbnObjDoc_FileRow_0)
            {
                base.Rows.Remove(tAbnObjDoc_FileRow_0);
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
            public DataColumn dateChangeColumn
            {
                get
                {
                    return this.columndateChange;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FileColumn
            {
                get
                {
                    return this.columnFile;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn FileNameColumn
            {
                get
                {
                    return this.columnFileName;
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
            public DataColumn idListColumn
            {
                get
                {
                    return this.columnidList;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idTemplateColumn
            {
                get
                {
                    return this.columnidTemplate;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetAbnObjAct.tAbnObjDoc_FileRow this[int index]
            {
                get
                {
                    return (DataSetAbnObjAct.tAbnObjDoc_FileRow) base.Rows[index];
                }
            }
        }

        public class tAbnObjDoc_FileRow : DataRow
        {
            private DataSetAbnObjAct.tAbnObjDoc_FileDataTable tAbnObjDoc_FileDataTable_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tAbnObjDoc_FileRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tAbnObjDoc_FileDataTable_0 = (DataSetAbnObjAct.tAbnObjDoc_FileDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsdateChangeNull()
            {
                return base.IsNull(this.tAbnObjDoc_FileDataTable_0.dateChangeColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsFileNull()
            {
                return base.IsNull(this.tAbnObjDoc_FileDataTable_0.FileColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsidTemplateNull()
            {
                return base.IsNull(this.tAbnObjDoc_FileDataTable_0.idTemplateColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetdateChangeNull()
            {
                base[this.tAbnObjDoc_FileDataTable_0.dateChangeColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetFileNull()
            {
                base[this.tAbnObjDoc_FileDataTable_0.FileColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetidTemplateNull()
            {
                base[this.tAbnObjDoc_FileDataTable_0.idTemplateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime dateChange
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.tAbnObjDoc_FileDataTable_0.dateChangeColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'dateChange' in table 'tAbnObjDoc_File' is DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.tAbnObjDoc_FileDataTable_0.dateChangeColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public byte[] File
            {
                get
                {
                    byte[] buffer;
                    try
                    {
                        buffer = (byte[]) base[this.tAbnObjDoc_FileDataTable_0.FileColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'File' in table 'tAbnObjDoc_File' is DBNull.", exception);
                    }
                    return buffer;
                }
                set
                {
                    base[this.tAbnObjDoc_FileDataTable_0.FileColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string FileName
            {
                get
                {
                    return (string) base[this.tAbnObjDoc_FileDataTable_0.FileNameColumn];
                }
                set
                {
                    base[this.tAbnObjDoc_FileDataTable_0.FileNameColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int idList
            {
                get
                {
                    return (int) base[this.tAbnObjDoc_FileDataTable_0.idListColumn];
                }
                set
                {
                    base[this.tAbnObjDoc_FileDataTable_0.idListColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idTemplate
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tAbnObjDoc_FileDataTable_0.idTemplateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idTemplate' in table 'tAbnObjDoc_File' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tAbnObjDoc_FileDataTable_0.idTemplateColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tAbnObjDoc_FileDataTable_0.idColumn];
                }
                set
                {
                    base[this.tAbnObjDoc_FileDataTable_0.idColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tAbnObjDoc_FileRowChangeEvent : EventArgs
        {
            private DataRowAction dataRowAction_0;
            private DataSetAbnObjAct.tAbnObjDoc_FileRow tAbnObjDoc_FileRow_0;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public tAbnObjDoc_FileRowChangeEvent(DataSetAbnObjAct.tAbnObjDoc_FileRow tAbnObjDoc_FileRow_1, DataRowAction action)
            {
                this.tAbnObjDoc_FileRow_0 = tAbnObjDoc_FileRow_1;
                this.dataRowAction_0 = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.dataRowAction_0;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetAbnObjAct.tAbnObjDoc_FileRow Row
            {
                get
                {
                    return this.tAbnObjDoc_FileRow_0;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tAbnObjDoc_FileRowChangeEventHandler(object sender, DataSetAbnObjAct.tAbnObjDoc_FileRowChangeEvent tAbnObjDoc_FileRowChangeEvent_0);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class tAbnObjDoc_ListDataTable : TypedTableBase<DataSetAbnObjAct.tAbnObjDoc_ListRow>
        {
            private DataColumn columnDeleted;
            private DataColumn columnDocDate;
            private DataColumn columnDocNumber;
            private DataColumn columnid;
            private DataColumn columnidAbn;
            private DataColumn columnidAbnObj;
            private DataColumn columnidDocType;
            private DataColumn columnisActive;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetAbnObjAct.tAbnObjDoc_ListRowChangeEventHandler tAbnObjDoc_ListRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetAbnObjAct.tAbnObjDoc_ListRowChangeEventHandler tAbnObjDoc_ListRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetAbnObjAct.tAbnObjDoc_ListRowChangeEventHandler tAbnObjDoc_ListRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetAbnObjAct.tAbnObjDoc_ListRowChangeEventHandler tAbnObjDoc_ListRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tAbnObjDoc_ListDataTable()
            {
                base.TableName = "tAbnObjDoc_List";
                this.BeginInit();
                this.method_1();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal tAbnObjDoc_ListDataTable(DataTable dataTable_0)
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
            protected tAbnObjDoc_ListDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.method_0();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void AddtAbnObjDoc_ListRow(DataSetAbnObjAct.tAbnObjDoc_ListRow tAbnObjDoc_ListRow_0)
            {
                base.Rows.Add(tAbnObjDoc_ListRow_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetAbnObjAct.tAbnObjDoc_ListRow AddtAbnObjDoc_ListRow(int idAbnObj, string DocNumber, DateTime DocDate, int idDocType, bool isActive, bool Deleted, int idAbn)
            {
                DataSetAbnObjAct.tAbnObjDoc_ListRow row = (DataSetAbnObjAct.tAbnObjDoc_ListRow) base.NewRow();
                object[] objArray1 = new object[8];
                objArray1[1] = idAbnObj;
                objArray1[2] = DocNumber;
                objArray1[3] = DocDate;
                objArray1[4] = idDocType;
                objArray1[5] = isActive;
                objArray1[6] = Deleted;
                objArray1[7] = idAbn;
                object[] objArray = objArray1;
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public override DataTable Clone()
            {
                DataSetAbnObjAct.tAbnObjDoc_ListDataTable table1 = (DataSetAbnObjAct.tAbnObjDoc_ListDataTable) base.Clone();
                table1.method_0();
                return table1;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataTable CreateInstance()
            {
                return new DataSetAbnObjAct.tAbnObjDoc_ListDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetAbnObjAct.tAbnObjDoc_ListRow FindByid(int int_0)
            {
                object[] keys = new object[] { int_0 };
                return (DataSetAbnObjAct.tAbnObjDoc_ListRow) base.Rows.Find(keys);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetAbnObjAct.tAbnObjDoc_ListRow);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetAbnObjAct act = new DataSetAbnObjAct();
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
                    FixedValue = act.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "tAbnObjDoc_ListDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = act.GetSchemaSerializable();
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
            internal void method_0()
            {
                this.columnid = base.Columns["id"];
                this.columnidAbnObj = base.Columns["idAbnObj"];
                this.columnDocNumber = base.Columns["DocNumber"];
                this.columnDocDate = base.Columns["DocDate"];
                this.columnidDocType = base.Columns["idDocType"];
                this.columnisActive = base.Columns["isActive"];
                this.columnDeleted = base.Columns["Deleted"];
                this.columnidAbn = base.Columns["idAbn"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_1()
            {
                this.columnid = new DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnidAbnObj = new DataColumn("idAbnObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbnObj);
                this.columnDocNumber = new DataColumn("DocNumber", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnDocNumber);
                this.columnDocDate = new DataColumn("DocDate", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnDocDate);
                this.columnidDocType = new DataColumn("idDocType", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidDocType);
                this.columnisActive = new DataColumn("isActive", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnisActive);
                this.columnDeleted = new DataColumn("Deleted", typeof(bool), null, MappingType.Element);
                base.Columns.Add(this.columnDeleted);
                this.columnidAbn = new DataColumn("idAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbn);
                DataColumn[] columns = new DataColumn[] { this.columnid };
                base.Constraints.Add(new UniqueConstraint("Constraint1", columns, true));
                this.columnid.AutoIncrement = true;
                this.columnid.AutoIncrementSeed = -1L;
                this.columnid.AutoIncrementStep = -1L;
                this.columnid.AllowDBNull = false;
                this.columnid.ReadOnly = true;
                this.columnid.Unique = true;
                this.columnidAbnObj.AllowDBNull = false;
                this.columnDocNumber.AllowDBNull = false;
                this.columnDocNumber.MaxLength = 20;
                this.columnDocDate.AllowDBNull = false;
                this.columnidDocType.AllowDBNull = false;
                this.columnisActive.AllowDBNull = false;
                this.columnDeleted.AllowDBNull = false;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetAbnObjAct.tAbnObjDoc_ListRow(builder);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetAbnObjAct.tAbnObjDoc_ListRow NewtAbnObjDoc_ListRow()
            {
                return (DataSetAbnObjAct.tAbnObjDoc_ListRow) base.NewRow();
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.tAbnObjDoc_ListRowChanged != null)
                {
                    this.tAbnObjDoc_ListRowChanged(this, new DataSetAbnObjAct.tAbnObjDoc_ListRowChangeEvent((DataSetAbnObjAct.tAbnObjDoc_ListRow) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.tAbnObjDoc_ListRowChanging != null)
                {
                    this.tAbnObjDoc_ListRowChanging(this, new DataSetAbnObjAct.tAbnObjDoc_ListRowChangeEvent((DataSetAbnObjAct.tAbnObjDoc_ListRow) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.tAbnObjDoc_ListRowDeleted != null)
                {
                    this.tAbnObjDoc_ListRowDeleted(this, new DataSetAbnObjAct.tAbnObjDoc_ListRowChangeEvent((DataSetAbnObjAct.tAbnObjDoc_ListRow) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.tAbnObjDoc_ListRowDeleting != null)
                {
                    this.tAbnObjDoc_ListRowDeleting(this, new DataSetAbnObjAct.tAbnObjDoc_ListRowChangeEvent((DataSetAbnObjAct.tAbnObjDoc_ListRow) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void RemovetAbnObjDoc_ListRow(DataSetAbnObjAct.tAbnObjDoc_ListRow tAbnObjDoc_ListRow_0)
            {
                base.Rows.Remove(tAbnObjDoc_ListRow_0);
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
            public DataColumn DeletedColumn
            {
                get
                {
                    return this.columnDeleted;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn DocDateColumn
            {
                get
                {
                    return this.columnDocDate;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn DocNumberColumn
            {
                get
                {
                    return this.columnDocNumber;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataColumn idAbnColumn
            {
                get
                {
                    return this.columnidAbn;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn idAbnObjColumn
            {
                get
                {
                    return this.columnidAbnObj;
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
            public DataColumn idDocTypeColumn
            {
                get
                {
                    return this.columnidDocType;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataColumn isActiveColumn
            {
                get
                {
                    return this.columnisActive;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetAbnObjAct.tAbnObjDoc_ListRow this[int index]
            {
                get
                {
                    return (DataSetAbnObjAct.tAbnObjDoc_ListRow) base.Rows[index];
                }
            }
        }

        public class tAbnObjDoc_ListRow : DataRow
        {
            private DataSetAbnObjAct.tAbnObjDoc_ListDataTable tAbnObjDoc_ListDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal tAbnObjDoc_ListRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.tAbnObjDoc_ListDataTable_0 = (DataSetAbnObjAct.tAbnObjDoc_ListDataTable) base.Table;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsidAbnNull()
            {
                return base.IsNull(this.tAbnObjDoc_ListDataTable_0.idAbnColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetidAbnNull()
            {
                base[this.tAbnObjDoc_ListDataTable_0.idAbnColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool Deleted
            {
                get
                {
                    return (bool) base[this.tAbnObjDoc_ListDataTable_0.DeletedColumn];
                }
                set
                {
                    base[this.tAbnObjDoc_ListDataTable_0.DeletedColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime DocDate
            {
                get
                {
                    return (DateTime) base[this.tAbnObjDoc_ListDataTable_0.DocDateColumn];
                }
                set
                {
                    base[this.tAbnObjDoc_ListDataTable_0.DocDateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string DocNumber
            {
                get
                {
                    return (string) base[this.tAbnObjDoc_ListDataTable_0.DocNumberColumn];
                }
                set
                {
                    base[this.tAbnObjDoc_ListDataTable_0.DocNumberColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public int idAbn
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.tAbnObjDoc_ListDataTable_0.idAbnColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idAbn' in table 'tAbnObjDoc_List' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.tAbnObjDoc_ListDataTable_0.idAbnColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idAbnObj
            {
                get
                {
                    return (int) base[this.tAbnObjDoc_ListDataTable_0.idAbnObjColumn];
                }
                set
                {
                    base[this.tAbnObjDoc_ListDataTable_0.idAbnObjColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idDocType
            {
                get
                {
                    return (int) base[this.tAbnObjDoc_ListDataTable_0.idDocTypeColumn];
                }
                set
                {
                    base[this.tAbnObjDoc_ListDataTable_0.idDocTypeColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    return (int) base[this.tAbnObjDoc_ListDataTable_0.idColumn];
                }
                set
                {
                    base[this.tAbnObjDoc_ListDataTable_0.idColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool isActive
            {
                get
                {
                    return (bool) base[this.tAbnObjDoc_ListDataTable_0.isActiveColumn];
                }
                set
                {
                    base[this.tAbnObjDoc_ListDataTable_0.isActiveColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class tAbnObjDoc_ListRowChangeEvent : EventArgs
        {
            private DataRowAction dataRowAction_0;
            private DataSetAbnObjAct.tAbnObjDoc_ListRow tAbnObjDoc_ListRow_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public tAbnObjDoc_ListRowChangeEvent(DataSetAbnObjAct.tAbnObjDoc_ListRow tAbnObjDoc_ListRow_1, DataRowAction action)
            {
                this.tAbnObjDoc_ListRow_0 = tAbnObjDoc_ListRow_1;
                this.dataRowAction_0 = action;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataRowAction Action
            {
                get
                {
                    return this.dataRowAction_0;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetAbnObjAct.tAbnObjDoc_ListRow Row
            {
                get
                {
                    return this.tAbnObjDoc_ListRow_0;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void tAbnObjDoc_ListRowChangeEventHandler(object sender, DataSetAbnObjAct.tAbnObjDoc_ListRowChangeEvent tAbnObjDoc_ListRowChangeEvent_0);

        [Serializable, XmlSchemaProvider("GetTypedTableSchema")]
        public class vActBalanceDataTable : TypedTableBase<DataSetAbnObjAct.vActBalanceRow>
        {
            private System.Data.DataColumn columnActDate;
            private System.Data.DataColumn columnActNumber;
            private System.Data.DataColumn columnActRegion;
            private System.Data.DataColumn columnCodeAbonent;
            private System.Data.DataColumn columnData;
            private System.Data.DataColumn columndeleted;
            private System.Data.DataColumn columnid;
            private System.Data.DataColumn columnidAbn;
            private System.Data.DataColumn columnidAbnObj;
            private System.Data.DataColumn columnidList;
            private System.Data.DataColumn columnisActive;
            private System.Data.DataColumn columnName;
            private System.Data.DataColumn columnObjName;
            private System.Data.DataColumn columnStationList;
            private System.Data.DataColumn columnTypeDoc;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetAbnObjAct.vActBalanceRowChangeEventHandler vActBalanceRowChanged;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetAbnObjAct.vActBalanceRowChangeEventHandler vActBalanceRowChanging;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetAbnObjAct.vActBalanceRowChangeEventHandler vActBalanceRowDeleted;

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            [field: CompilerGenerated]
            public event DataSetAbnObjAct.vActBalanceRowChangeEventHandler vActBalanceRowDeleting;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vActBalanceDataTable()
            {
                base.TableName = "vActBalance";
                this.BeginInit();
                this.method_1();
                this.EndInit();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            internal vActBalanceDataTable(DataTable dataTable_0)
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
            protected vActBalanceDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
            {
                this.method_0();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void AddvActBalanceRow(DataSetAbnObjAct.vActBalanceRow vActBalanceRow_0)
            {
                base.Rows.Add(vActBalanceRow_0);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetAbnObjAct.vActBalanceRow AddvActBalanceRow(int int_0, string TypeDoc, int CodeAbonent, string Name, string ObjName, string Data, int idList, int idAbn, int idAbnObj, string StationList, string ActNumber, DateTime ActDate, string ActRegion, int isActive, int deleted)
            {
                DataSetAbnObjAct.vActBalanceRow row = (DataSetAbnObjAct.vActBalanceRow) base.NewRow();
                object[] objArray = new object[] { int_0, TypeDoc, CodeAbonent, Name, ObjName, Data, idList, idAbn, idAbnObj, StationList, ActNumber, ActDate, ActRegion, isActive, deleted };
                row.ItemArray = objArray;
                base.Rows.Add(row);
                return row;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public override DataTable Clone()
            {
                DataSetAbnObjAct.vActBalanceDataTable table1 = (DataSetAbnObjAct.vActBalanceDataTable) base.Clone();
                table1.method_0();
                return table1;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override DataTable CreateInstance()
            {
                return new DataSetAbnObjAct.vActBalanceDataTable();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override Type GetRowType()
            {
                return typeof(DataSetAbnObjAct.vActBalanceRow);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xmlSchemaSet_0)
            {
                XmlSchemaComplexType type = new XmlSchemaComplexType();
                XmlSchemaSequence sequence = new XmlSchemaSequence();
                DataSetAbnObjAct act = new DataSetAbnObjAct();
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
                    FixedValue = act.Namespace
                };
                type.Attributes.Add(attribute);
                XmlSchemaAttribute attribute2 = new XmlSchemaAttribute {
                    Name = "tableTypeName",
                    FixedValue = "vActBalanceDataTable"
                };
                type.Attributes.Add(attribute2);
                type.Particle = sequence;
                XmlSchema schemaSerializable = act.GetSchemaSerializable();
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
            internal void method_0()
            {
                this.columnid = base.Columns["id"];
                this.columnTypeDoc = base.Columns["TypeDoc"];
                this.columnCodeAbonent = base.Columns["CodeAbonent"];
                this.columnName = base.Columns["Name"];
                this.columnObjName = base.Columns["ObjName"];
                this.columnData = base.Columns["Data"];
                this.columnidList = base.Columns["idList"];
                this.columnidAbn = base.Columns["idAbn"];
                this.columnidAbnObj = base.Columns["idAbnObj"];
                this.columnStationList = base.Columns["StationList"];
                this.columnActNumber = base.Columns["ActNumber"];
                this.columnActDate = base.Columns["ActDate"];
                this.columnActRegion = base.Columns["ActRegion"];
                this.columnisActive = base.Columns["isActive"];
                this.columndeleted = base.Columns["deleted"];
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            private void method_1()
            {
                this.columnid = new System.Data.DataColumn("id", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnid);
                this.columnTypeDoc = new System.Data.DataColumn("TypeDoc", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnTypeDoc);
                this.columnCodeAbonent = new System.Data.DataColumn("CodeAbonent", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnCodeAbonent);
                this.columnName = new System.Data.DataColumn("Name", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnName);
                this.columnObjName = new System.Data.DataColumn("ObjName", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnObjName);
                this.columnData = new System.Data.DataColumn("Data", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnData);
                this.columnidList = new System.Data.DataColumn("idList", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidList);
                this.columnidAbn = new System.Data.DataColumn("idAbn", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbn);
                this.columnidAbnObj = new System.Data.DataColumn("idAbnObj", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnidAbnObj);
                this.columnStationList = new System.Data.DataColumn("StationList", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnStationList);
                this.columnActNumber = new System.Data.DataColumn("ActNumber", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnActNumber);
                this.columnActDate = new System.Data.DataColumn("ActDate", typeof(DateTime), null, MappingType.Element);
                base.Columns.Add(this.columnActDate);
                this.columnActRegion = new System.Data.DataColumn("ActRegion", typeof(string), null, MappingType.Element);
                base.Columns.Add(this.columnActRegion);
                this.columnisActive = new System.Data.DataColumn("isActive", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columnisActive);
                this.columndeleted = new System.Data.DataColumn("deleted", typeof(int), null, MappingType.Element);
                base.Columns.Add(this.columndeleted);
                this.columnTypeDoc.AllowDBNull = false;
                this.columnTypeDoc.MaxLength = 100;
                this.columnName.MaxLength = 100;
                this.columnObjName.MaxLength = 0xff;
                this.columnStationList.ReadOnly = true;
                this.columnStationList.MaxLength = 500;
                this.columnActNumber.AllowDBNull = false;
                this.columnActNumber.MaxLength = 20;
                this.columnActDate.ReadOnly = true;
                this.columnActRegion.MaxLength = 100;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
            {
                return new DataSetAbnObjAct.vActBalanceRow(builder);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetAbnObjAct.vActBalanceRow NewvActBalanceRow()
            {
                return (DataSetAbnObjAct.vActBalanceRow) base.NewRow();
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowChanged(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanged(dataRowChangeEventArgs_0);
                if (this.vActBalanceRowChanged != null)
                {
                    this.vActBalanceRowChanged(this, new DataSetAbnObjAct.vActBalanceRowChangeEvent((DataSetAbnObjAct.vActBalanceRow) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowChanging(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowChanging(dataRowChangeEventArgs_0);
                if (this.vActBalanceRowChanging != null)
                {
                    this.vActBalanceRowChanging(this, new DataSetAbnObjAct.vActBalanceRowChangeEvent((DataSetAbnObjAct.vActBalanceRow) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            protected override void OnRowDeleted(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleted(dataRowChangeEventArgs_0);
                if (this.vActBalanceRowDeleted != null)
                {
                    this.vActBalanceRowDeleted(this, new DataSetAbnObjAct.vActBalanceRowChangeEvent((DataSetAbnObjAct.vActBalanceRow) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            protected override void OnRowDeleting(DataRowChangeEventArgs dataRowChangeEventArgs_0)
            {
                base.OnRowDeleting(dataRowChangeEventArgs_0);
                if (this.vActBalanceRowDeleting != null)
                {
                    this.vActBalanceRowDeleting(this, new DataSetAbnObjAct.vActBalanceRowChangeEvent((DataSetAbnObjAct.vActBalanceRow) dataRowChangeEventArgs_0.Row, dataRowChangeEventArgs_0.Action));
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void RemovevActBalanceRow(DataSetAbnObjAct.vActBalanceRow vActBalanceRow_0)
            {
                base.Rows.Remove(vActBalanceRow_0);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public System.Data.DataColumn ActDateColumn
            {
                get
                {
                    return this.columnActDate;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.Data.DataColumn ActNumberColumn
            {
                get
                {
                    return this.columnActNumber;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.Data.DataColumn ActRegionColumn
            {
                get
                {
                    return this.columnActRegion;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public System.Data.DataColumn CodeAbonentColumn
            {
                get
                {
                    return this.columnCodeAbonent;
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
            public System.Data.DataColumn DataColumn
            {
                get
                {
                    return this.columnData;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public System.Data.DataColumn deletedColumn
            {
                get
                {
                    return this.columndeleted;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public System.Data.DataColumn idAbnColumn
            {
                get
                {
                    return this.columnidAbn;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public System.Data.DataColumn idAbnObjColumn
            {
                get
                {
                    return this.columnidAbnObj;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public System.Data.DataColumn idColumn
            {
                get
                {
                    return this.columnid;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.Data.DataColumn idListColumn
            {
                get
                {
                    return this.columnidList;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public System.Data.DataColumn isActiveColumn
            {
                get
                {
                    return this.columnisActive;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataSetAbnObjAct.vActBalanceRow this[int index]
            {
                get
                {
                    return (DataSetAbnObjAct.vActBalanceRow) base.Rows[index];
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.Data.DataColumn NameColumn
            {
                get
                {
                    return this.columnName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.Data.DataColumn ObjNameColumn
            {
                get
                {
                    return this.columnObjName;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public System.Data.DataColumn StationListColumn
            {
                get
                {
                    return this.columnStationList;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public System.Data.DataColumn TypeDocColumn
            {
                get
                {
                    return this.columnTypeDoc;
                }
            }
        }

        public class vActBalanceRow : DataRow
        {
            private DataSetAbnObjAct.vActBalanceDataTable vActBalanceDataTable_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal vActBalanceRow(DataRowBuilder dataRowBuilder_0) : base(dataRowBuilder_0)
            {
                this.vActBalanceDataTable_0 = (DataSetAbnObjAct.vActBalanceDataTable) base.Table;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsActDateNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.ActDateColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsActRegionNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.ActRegionColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsCodeAbonentNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.CodeAbonentColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsDataNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.DataColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsdeletedNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.deletedColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsidAbnNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.idAbnColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsidAbnObjNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.idAbnObjColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsidListNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.idListColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsidNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.idColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsisActiveNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.isActiveColumn);
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public bool IsNameNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.NameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsObjNameNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.ObjNameColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public bool IsStationListNull()
            {
                return base.IsNull(this.vActBalanceDataTable_0.StationListColumn);
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetActDateNull()
            {
                base[this.vActBalanceDataTable_0.ActDateColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetActRegionNull()
            {
                base[this.vActBalanceDataTable_0.ActRegionColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetCodeAbonentNull()
            {
                base[this.vActBalanceDataTable_0.CodeAbonentColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetDataNull()
            {
                base[this.vActBalanceDataTable_0.DataColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetdeletedNull()
            {
                base[this.vActBalanceDataTable_0.deletedColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetidAbnNull()
            {
                base[this.vActBalanceDataTable_0.idAbnColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetidAbnObjNull()
            {
                base[this.vActBalanceDataTable_0.idAbnObjColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetidListNull()
            {
                base[this.vActBalanceDataTable_0.idListColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetidNull()
            {
                base[this.vActBalanceDataTable_0.idColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetisActiveNull()
            {
                base[this.vActBalanceDataTable_0.isActiveColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetNameNull()
            {
                base[this.vActBalanceDataTable_0.NameColumn] = Convert.DBNull;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public void SetObjNameNull()
            {
                base[this.vActBalanceDataTable_0.ObjNameColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public void SetStationListNull()
            {
                base[this.vActBalanceDataTable_0.StationListColumn] = Convert.DBNull;
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DateTime ActDate
            {
                get
                {
                    DateTime time;
                    try
                    {
                        time = (DateTime) base[this.vActBalanceDataTable_0.ActDateColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'ActDate' in table 'vActBalance' is DBNull.", exception);
                    }
                    return time;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.ActDateColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string ActNumber
            {
                get
                {
                    return (string) base[this.vActBalanceDataTable_0.ActNumberColumn];
                }
                set
                {
                    base[this.vActBalanceDataTable_0.ActNumberColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string ActRegion
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vActBalanceDataTable_0.ActRegionColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'ActRegion' in table 'vActBalance' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.ActRegionColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int CodeAbonent
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.vActBalanceDataTable_0.CodeAbonentColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'CodeAbonent' in table 'vActBalance' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.CodeAbonentColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string Data
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vActBalanceDataTable_0.DataColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Data' in table 'vActBalance' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.DataColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int deleted
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.vActBalanceDataTable_0.deletedColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'deleted' in table 'vActBalance' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.deletedColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idAbn
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.vActBalanceDataTable_0.idAbnColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idAbn' in table 'vActBalance' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.idAbnColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idAbnObj
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.vActBalanceDataTable_0.idAbnObjColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idAbnObj' in table 'vActBalance' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.idAbnObjColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int idList
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.vActBalanceDataTable_0.idListColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'idList' in table 'vActBalance' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.idListColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Int32_0
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.vActBalanceDataTable_0.idColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'id' in table 'vActBalance' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.idColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int isActive
            {
                get
                {
                    int num;
                    try
                    {
                        num = (int) base[this.vActBalanceDataTable_0.isActiveColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'isActive' in table 'vActBalance' is DBNull.", exception);
                    }
                    return num;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.isActiveColumn] = value;
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
                        str = (string) base[this.vActBalanceDataTable_0.NameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'Name' in table 'vActBalance' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.NameColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string ObjName
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vActBalanceDataTable_0.ObjNameColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'ObjName' in table 'vActBalance' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.ObjNameColumn] = value;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public string StationList
            {
                get
                {
                    string str;
                    try
                    {
                        str = (string) base[this.vActBalanceDataTable_0.StationListColumn];
                    }
                    catch (InvalidCastException exception)
                    {
                        throw new StrongTypingException("The value for column 'StationList' in table 'vActBalance' is DBNull.", exception);
                    }
                    return str;
                }
                set
                {
                    base[this.vActBalanceDataTable_0.StationListColumn] = value;
                }
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public string TypeDoc
            {
                get
                {
                    return (string) base[this.vActBalanceDataTable_0.TypeDocColumn];
                }
                set
                {
                    base[this.vActBalanceDataTable_0.TypeDocColumn] = value;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public class vActBalanceRowChangeEvent : EventArgs
        {
            private DataRowAction dataRowAction_0;
            private DataSetAbnObjAct.vActBalanceRow vActBalanceRow_0;

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public vActBalanceRowChangeEvent(DataSetAbnObjAct.vActBalanceRow vActBalanceRow_1, DataRowAction action)
            {
                this.vActBalanceRow_0 = vActBalanceRow_1;
                this.dataRowAction_0 = action;
            }

            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0"), DebuggerNonUserCode]
            public DataRowAction Action
            {
                get
                {
                    return this.dataRowAction_0;
                }
            }

            [DebuggerNonUserCode, GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public DataSetAbnObjAct.vActBalanceRow Row
            {
                get
                {
                    return this.vActBalanceRow_0;
                }
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public delegate void vActBalanceRowChangeEventHandler(object sender, DataSetAbnObjAct.vActBalanceRowChangeEvent vActBalanceRowChangeEvent_0);
    }
}

